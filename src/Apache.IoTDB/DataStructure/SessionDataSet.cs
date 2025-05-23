/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thrift;

namespace Apache.IoTDB.DataStructure
{
    public class SessionDataSet : System.IDisposable
    {
        private readonly long _queryId;
        private readonly long _statementId;
        private readonly string _sql;
        private readonly List<string> _columnNames;
        private readonly Dictionary<string, int> _columnNameIndexMap;
        private readonly Dictionary<int, int> _duplicateLocation;
        private readonly List<string> _columnTypeLst;
        private TSQueryDataSet _queryDataset;
        private readonly byte[] _currentBitmap;
        private readonly int _columnSize;
        private List<ByteBuffer> _valueBufferLst, _bitmapBufferLst;
        private ByteBuffer _timeBuffer;
        private readonly ConcurrentClientQueue _clientQueue;
        private Client _client;
        private int _rowIndex;
        private bool _hasCatchedResult;
        private RowRecord _cachedRowRecord;
        private bool _isClosed = false;
        private bool disposedValue;
        private RpcDataSet _rpcDataSet;

        private string TimestampStr => "Time";
        private int StartIndex => 2;
        private int Flag => 0x80;
        private int DefaultTimeout => 10000;
        public int FetchSize { get; set; }
        public int RowCount { get; set; }
        public SessionDataSet(string sql, TSExecuteStatementResp resp, Client client, ConcurrentClientQueue clientQueue, long statementId)
        {
            _clientQueue = clientQueue;
            _client = client;
            _sql = sql;
            _queryDataset = resp.QueryDataSet;
            _queryId = resp.QueryId;
            _statementId = statementId;
            _columnSize = resp.Columns.Count;
            _currentBitmap = new byte[_columnSize];
            _columnNames = new List<string>();
            _timeBuffer = new ByteBuffer(_queryDataset.Time);
            // column name -> column location
            _columnNameIndexMap = new Dictionary<string, int>();
            _columnTypeLst = new List<string>();
            _duplicateLocation = new Dictionary<int, int>();
            _valueBufferLst = new List<ByteBuffer>();
            _bitmapBufferLst = new List<ByteBuffer>();
            // some internal variable
            _hasCatchedResult = false;
            _rowIndex = 0;
            RowCount = _queryDataset.Time.Length / sizeof(long);

            _columnNames = resp.Columns;
            _columnTypeLst = resp.DataTypeList;

            int deduplicateIdx = 0;
            Dictionary<string, int> columnToFirstIndexMap = new Dictionary<string, int>();
            for (var i = 0; i < _columnSize; i++)
            {
                var columnName = _columnNames[i];
                if (_columnNameIndexMap.ContainsKey(columnName))
                {
                    _duplicateLocation[i] = columnToFirstIndexMap[columnName];
                }
                else
                {
                    columnToFirstIndexMap[columnName] = i;
                    if (resp.ColumnNameIndexMap != null)
                    {
                        int valueIndex = resp.ColumnNameIndexMap[columnName];
                        _columnNameIndexMap[columnName] = valueIndex;
                        _valueBufferLst.Add(new ByteBuffer(_queryDataset.ValueList[valueIndex]));
                        _bitmapBufferLst.Add(new ByteBuffer(_queryDataset.BitmapList[valueIndex]));
                    }
                    else
                    {
                        _columnNameIndexMap[columnName] = deduplicateIdx;
                        _valueBufferLst.Add(new ByteBuffer(_queryDataset.ValueList[deduplicateIdx]));
                        _bitmapBufferLst.Add(new ByteBuffer(_queryDataset.BitmapList[deduplicateIdx]));
                    }
                    deduplicateIdx++;
                }
            }
        }
        public List<string> ColumnNames => _columnNames;


        private List<string> GetColumnNames()
        {
            var lst = new List<string>
            {
                "timestamp"
            };
            lst.AddRange(_columnNames);
            return lst;
        }

        public void ShowTableNames()
        {
            var str = GetColumnNames()
                .Aggregate("", (current, name) => current + (name + "\t\t"));

            Console.WriteLine(str);
        }
        public bool HasNext()
        {
            if (_hasCatchedResult)
            {
                return true;
            }

            // we have consumed all current data, fetch some more
            if (!_timeBuffer.HasRemaining())
            {
                if (!FetchResults())
                {
                    return false;
                }
            }

            ConstructOneRow();
            _hasCatchedResult = true;
            return true;
        }

        public RowRecord Next()
        {
            if (!_hasCatchedResult)
            {
                if (!HasNext())
                {
                    return null;
                }
            }

            _hasCatchedResult = false;
            return _cachedRowRecord;
        }
        public RowRecord GetRow()
        {
            return _cachedRowRecord;
        }

        private TSDataType GetDataTypeFromStr(string str)
        {
            return str switch
            {
                "BOOLEAN" => TSDataType.BOOLEAN,
                "INT32" => TSDataType.INT32,
                "INT64" => TSDataType.INT64,
                "FLOAT" => TSDataType.FLOAT,
                "DOUBLE" => TSDataType.DOUBLE,
                "TEXT" => TSDataType.TEXT,
                "NULLTYPE" => TSDataType.NONE,
                "TIMESTAMP" => TSDataType.TIMESTAMP,
                "DATE" => TSDataType.DATE,
                "BLOB" => TSDataType.BLOB,
                "STRING" => TSDataType.STRING,
                _ => TSDataType.STRING
            };
        }

        private void ConstructOneRow()
        {
            List<object> fieldList = new List<Object>();

            for (int i = 0; i < _columnSize; i++)
            {
                if (_duplicateLocation.ContainsKey(i))
                {
                    var field = fieldList[_duplicateLocation[i]];
                    fieldList.Add(field);
                }
                else
                {
                    var columnValueBuffer = _valueBufferLst[i];
                    var columnBitmapBuffer = _bitmapBufferLst[i];

                    if (_rowIndex % 8 == 0)
                    {
                        _currentBitmap[i] = columnBitmapBuffer.GetByte();
                    }

                    object localField;
                    if (!IsNull(i, _rowIndex))
                    {
                        var columnDataType = GetDataTypeFromStr(_columnTypeLst[i]);


                        switch (columnDataType)
                        {
                            case TSDataType.BOOLEAN:
                                localField = columnValueBuffer.GetBool();
                                break;
                            case TSDataType.INT32:
                                // case TSDataType.DATE:
                                localField = columnValueBuffer.GetInt();
                                break;
                            case TSDataType.DATE:
                                localField = Utils.ParseIntToDate(columnValueBuffer.GetInt());
                                break;
                            case TSDataType.INT64:
                            case TSDataType.TIMESTAMP:
                                localField = columnValueBuffer.GetLong();
                                break;
                            case TSDataType.FLOAT:
                                localField = columnValueBuffer.GetFloat();
                                break;
                            case TSDataType.DOUBLE:
                                localField = columnValueBuffer.GetDouble();
                                break;
                            case TSDataType.TEXT:
                            case TSDataType.STRING:
                                // case TSDataType.BLOB:
                                localField = columnValueBuffer.GetStr();
                                break;
                            case TSDataType.BLOB:
                                localField = columnValueBuffer.GetBinary();
                                break;
                            // TODO
                            default:
                                string err_msg = "value format not supported";
                                throw new TException(err_msg, null);
                        }

                        fieldList.Add(localField);
                    }
                    else
                    {
                        localField = null;
                        fieldList.Add(DBNull.Value);
                    }
                }
            }

            long timestamp = _timeBuffer.GetLong();
            _rowIndex += 1;
            _cachedRowRecord = new RowRecord(timestamp, fieldList, _columnNames);
        }

        private bool IsNull(int loc, int row_index)
        {
            byte bitmap = _currentBitmap[loc];
            int shift = row_index % 8;
            return ((Flag >> shift) & bitmap) == 0;
        }

        private bool FetchResults()
        {
            _rowIndex = 0;
            var req = new TSFetchResultsReq(_client.SessionId, _sql, FetchSize, _queryId, true)
            {
                Timeout = DefaultTimeout
            };
            try
            {
                var task = _client.ServiceClient.fetchResultsAsync(req);

                var resp = task.ConfigureAwait(false).GetAwaiter().GetResult();

                if (resp.HasResultSet)
                {
                    _queryDataset = resp.QueryDataSet;
                    // reset buffer
                    _timeBuffer = new ByteBuffer(resp.QueryDataSet.Time);
                    _valueBufferLst = new List<ByteBuffer>();
                    _bitmapBufferLst = new List<ByteBuffer>();
                    for (int index = 0; index < _queryDataset.ValueList.Count; index++)
                    {
                        string columnName = _columnNames[index];
                        int valueIndex = _columnNameIndexMap[columnName];
                        _valueBufferLst.Add(new ByteBuffer(_queryDataset.ValueList[valueIndex]));
                        _bitmapBufferLst.Add(new ByteBuffer(_queryDataset.BitmapList[valueIndex]));
                    }

                    // reset row index
                    _rowIndex = 0;
                }

                return resp.HasResultSet;
            }
            catch (TException e)
            {
                throw new TException("Cannot fetch result from server, because of network connection", e);
            }
        }

        public async Task Close()
        {
            if (!_isClosed)
            {
                var req = new TSCloseOperationReq(_client.SessionId)
                {
                    QueryId = _queryId,
                    StatementId = _statementId
                };

                try
                {
                    var status = await _client.ServiceClient.closeOperationAsync(req);
                }
                catch (TException e)
                {
                    throw new TException("Operation Handle Close Failed", e);
                }
                finally
                {
                    // remain current logic
                    _clientQueue.Add(_client);
                    _client = null;
                }
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    try
                    {
                        this.Close().Wait();
                    }
                    catch
                    {
                    }
                }
                _queryDataset = null;
                _timeBuffer = null;
                _valueBufferLst = null;
                _bitmapBufferLst = null;
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
