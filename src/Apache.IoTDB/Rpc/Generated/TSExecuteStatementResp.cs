/**
 * Autogenerated by Thrift Compiler (0.15.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions


public partial class TSExecuteStatementResp : TBase
{
  private long _queryId;
  private List<string> _columns;
  private string _operationType;
  private bool _ignoreTimeStamp;
  private List<string> _dataTypeList;
  private TSQueryDataSet _queryDataSet;
  private TSQueryNonAlignDataSet _nonAlignQueryDataSet;
  private Dictionary<string, int> _columnNameIndexMap;
  private List<string> _sgColumns;
  private List<sbyte> _aliasColumns;
  private TSTracingInfo _tracingInfo;
  private List<byte[]> _queryResult;
  private bool _moreData;
  private string _database;
  private bool _tableModel;
  private List<int> _columnIndex2TsBlockColumnIndexList;

  public TSStatus Status { get; set; }

  public long QueryId
  {
    get
    {
      return _queryId;
    }
    set
    {
      __isset.queryId = true;
      this._queryId = value;
    }
  }

  public List<string> Columns
  {
    get
    {
      return _columns;
    }
    set
    {
      __isset.columns = true;
      this._columns = value;
    }
  }

  public string OperationType
  {
    get
    {
      return _operationType;
    }
    set
    {
      __isset.operationType = true;
      this._operationType = value;
    }
  }

  public bool IgnoreTimeStamp
  {
    get
    {
      return _ignoreTimeStamp;
    }
    set
    {
      __isset.ignoreTimeStamp = true;
      this._ignoreTimeStamp = value;
    }
  }

  public List<string> DataTypeList
  {
    get
    {
      return _dataTypeList;
    }
    set
    {
      __isset.dataTypeList = true;
      this._dataTypeList = value;
    }
  }

  public TSQueryDataSet QueryDataSet
  {
    get
    {
      return _queryDataSet;
    }
    set
    {
      __isset.queryDataSet = true;
      this._queryDataSet = value;
    }
  }

  public TSQueryNonAlignDataSet NonAlignQueryDataSet
  {
    get
    {
      return _nonAlignQueryDataSet;
    }
    set
    {
      __isset.nonAlignQueryDataSet = true;
      this._nonAlignQueryDataSet = value;
    }
  }

  public Dictionary<string, int> ColumnNameIndexMap
  {
    get
    {
      return _columnNameIndexMap;
    }
    set
    {
      __isset.columnNameIndexMap = true;
      this._columnNameIndexMap = value;
    }
  }

  public List<string> SgColumns
  {
    get
    {
      return _sgColumns;
    }
    set
    {
      __isset.sgColumns = true;
      this._sgColumns = value;
    }
  }

  public List<sbyte> AliasColumns
  {
    get
    {
      return _aliasColumns;
    }
    set
    {
      __isset.aliasColumns = true;
      this._aliasColumns = value;
    }
  }

  public TSTracingInfo TracingInfo
  {
    get
    {
      return _tracingInfo;
    }
    set
    {
      __isset.tracingInfo = true;
      this._tracingInfo = value;
    }
  }

  public List<byte[]> QueryResult
  {
    get
    {
      return _queryResult;
    }
    set
    {
      __isset.queryResult = true;
      this._queryResult = value;
    }
  }

  public bool MoreData
  {
    get
    {
      return _moreData;
    }
    set
    {
      __isset.moreData = true;
      this._moreData = value;
    }
  }

  public string Database
  {
    get
    {
      return _database;
    }
    set
    {
      __isset.database = true;
      this._database = value;
    }
  }

  public bool TableModel
  {
    get
    {
      return _tableModel;
    }
    set
    {
      __isset.tableModel = true;
      this._tableModel = value;
    }
  }

  public List<int> ColumnIndex2TsBlockColumnIndexList
  {
    get
    {
      return _columnIndex2TsBlockColumnIndexList;
    }
    set
    {
      __isset.columnIndex2TsBlockColumnIndexList = true;
      this._columnIndex2TsBlockColumnIndexList = value;
    }
  }


  public Isset __isset;
  public struct Isset
  {
    public bool queryId;
    public bool columns;
    public bool operationType;
    public bool ignoreTimeStamp;
    public bool dataTypeList;
    public bool queryDataSet;
    public bool nonAlignQueryDataSet;
    public bool columnNameIndexMap;
    public bool sgColumns;
    public bool aliasColumns;
    public bool tracingInfo;
    public bool queryResult;
    public bool moreData;
    public bool database;
    public bool tableModel;
    public bool columnIndex2TsBlockColumnIndexList;
  }

  public TSExecuteStatementResp()
  {
  }

  public TSExecuteStatementResp(TSStatus status) : this()
  {
    this.Status = status;
  }

  public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      bool isset_status = false;
      TField field;
      await iprot.ReadStructBeginAsync(cancellationToken);
      while (true)
      {
        field = await iprot.ReadFieldBeginAsync(cancellationToken);
        if (field.Type == TType.Stop)
        {
          break;
        }

        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.Struct)
            {
              Status = new TSStatus();
              await Status.ReadAsync(iprot, cancellationToken);
              isset_status = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 2:
            if (field.Type == TType.I64)
            {
              QueryId = await iprot.ReadI64Async(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 3:
            if (field.Type == TType.List)
            {
              {
                TList _list36 = await iprot.ReadListBeginAsync(cancellationToken);
                Columns = new List<string>(_list36.Count);
                for(int _i37 = 0; _i37 < _list36.Count; ++_i37)
                {
                  string _elem38;
                  _elem38 = await iprot.ReadStringAsync(cancellationToken);
                  Columns.Add(_elem38);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 4:
            if (field.Type == TType.String)
            {
              OperationType = await iprot.ReadStringAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 5:
            if (field.Type == TType.Bool)
            {
              IgnoreTimeStamp = await iprot.ReadBoolAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 6:
            if (field.Type == TType.List)
            {
              {
                TList _list39 = await iprot.ReadListBeginAsync(cancellationToken);
                DataTypeList = new List<string>(_list39.Count);
                for(int _i40 = 0; _i40 < _list39.Count; ++_i40)
                {
                  string _elem41;
                  _elem41 = await iprot.ReadStringAsync(cancellationToken);
                  DataTypeList.Add(_elem41);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 7:
            if (field.Type == TType.Struct)
            {
              QueryDataSet = new TSQueryDataSet();
              await QueryDataSet.ReadAsync(iprot, cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 8:
            if (field.Type == TType.Struct)
            {
              NonAlignQueryDataSet = new TSQueryNonAlignDataSet();
              await NonAlignQueryDataSet.ReadAsync(iprot, cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 9:
            if (field.Type == TType.Map)
            {
              {
                TMap _map42 = await iprot.ReadMapBeginAsync(cancellationToken);
                ColumnNameIndexMap = new Dictionary<string, int>(_map42.Count);
                for(int _i43 = 0; _i43 < _map42.Count; ++_i43)
                {
                  string _key44;
                  int _val45;
                  _key44 = await iprot.ReadStringAsync(cancellationToken);
                  _val45 = await iprot.ReadI32Async(cancellationToken);
                  ColumnNameIndexMap[_key44] = _val45;
                }
                await iprot.ReadMapEndAsync(cancellationToken);
              }
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 10:
            if (field.Type == TType.List)
            {
              {
                TList _list46 = await iprot.ReadListBeginAsync(cancellationToken);
                SgColumns = new List<string>(_list46.Count);
                for(int _i47 = 0; _i47 < _list46.Count; ++_i47)
                {
                  string _elem48;
                  _elem48 = await iprot.ReadStringAsync(cancellationToken);
                  SgColumns.Add(_elem48);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 11:
            if (field.Type == TType.List)
            {
              {
                TList _list49 = await iprot.ReadListBeginAsync(cancellationToken);
                AliasColumns = new List<sbyte>(_list49.Count);
                for(int _i50 = 0; _i50 < _list49.Count; ++_i50)
                {
                  sbyte _elem51;
                  _elem51 = await iprot.ReadByteAsync(cancellationToken);
                  AliasColumns.Add(_elem51);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 12:
            if (field.Type == TType.Struct)
            {
              TracingInfo = new TSTracingInfo();
              await TracingInfo.ReadAsync(iprot, cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 13:
            if (field.Type == TType.List)
            {
              {
                TList _list52 = await iprot.ReadListBeginAsync(cancellationToken);
                QueryResult = new List<byte[]>(_list52.Count);
                for(int _i53 = 0; _i53 < _list52.Count; ++_i53)
                {
                  byte[] _elem54;
                  _elem54 = await iprot.ReadBinaryAsync(cancellationToken);
                  QueryResult.Add(_elem54);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 14:
            if (field.Type == TType.Bool)
            {
              MoreData = await iprot.ReadBoolAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 15:
            if (field.Type == TType.String)
            {
              Database = await iprot.ReadStringAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 16:
            if (field.Type == TType.Bool)
            {
              TableModel = await iprot.ReadBoolAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 17:
            if (field.Type == TType.List)
            {
              {
                TList _list55 = await iprot.ReadListBeginAsync(cancellationToken);
                ColumnIndex2TsBlockColumnIndexList = new List<int>(_list55.Count);
                for(int _i56 = 0; _i56 < _list55.Count; ++_i56)
                {
                  int _elem57;
                  _elem57 = await iprot.ReadI32Async(cancellationToken);
                  ColumnIndex2TsBlockColumnIndexList.Add(_elem57);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          default: 
            await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            break;
        }

        await iprot.ReadFieldEndAsync(cancellationToken);
      }

      await iprot.ReadStructEndAsync(cancellationToken);
      if (!isset_status)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
    }
    finally
    {
      iprot.DecrementRecursionDepth();
    }
  }

  public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
  {
    oprot.IncrementRecursionDepth();
    try
    {
      var tmp58 = new TStruct("TSExecuteStatementResp");
      await oprot.WriteStructBeginAsync(tmp58, cancellationToken);
      var tmp59 = new TField();
      if((Status != null))
      {
        tmp59.Name = "status";
        tmp59.Type = TType.Struct;
        tmp59.ID = 1;
        await oprot.WriteFieldBeginAsync(tmp59, cancellationToken);
        await Status.WriteAsync(oprot, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if(__isset.queryId)
      {
        tmp59.Name = "queryId";
        tmp59.Type = TType.I64;
        tmp59.ID = 2;
        await oprot.WriteFieldBeginAsync(tmp59, cancellationToken);
        await oprot.WriteI64Async(QueryId, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((Columns != null) && __isset.columns)
      {
        tmp59.Name = "columns";
        tmp59.Type = TType.List;
        tmp59.ID = 3;
        await oprot.WriteFieldBeginAsync(tmp59, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.String, Columns.Count), cancellationToken);
          foreach (string _iter60 in Columns)
          {
            await oprot.WriteStringAsync(_iter60, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((OperationType != null) && __isset.operationType)
      {
        tmp59.Name = "operationType";
        tmp59.Type = TType.String;
        tmp59.ID = 4;
        await oprot.WriteFieldBeginAsync(tmp59, cancellationToken);
        await oprot.WriteStringAsync(OperationType, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if(__isset.ignoreTimeStamp)
      {
        tmp59.Name = "ignoreTimeStamp";
        tmp59.Type = TType.Bool;
        tmp59.ID = 5;
        await oprot.WriteFieldBeginAsync(tmp59, cancellationToken);
        await oprot.WriteBoolAsync(IgnoreTimeStamp, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((DataTypeList != null) && __isset.dataTypeList)
      {
        tmp59.Name = "dataTypeList";
        tmp59.Type = TType.List;
        tmp59.ID = 6;
        await oprot.WriteFieldBeginAsync(tmp59, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.String, DataTypeList.Count), cancellationToken);
          foreach (string _iter61 in DataTypeList)
          {
            await oprot.WriteStringAsync(_iter61, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((QueryDataSet != null) && __isset.queryDataSet)
      {
        tmp59.Name = "queryDataSet";
        tmp59.Type = TType.Struct;
        tmp59.ID = 7;
        await oprot.WriteFieldBeginAsync(tmp59, cancellationToken);
        await QueryDataSet.WriteAsync(oprot, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((NonAlignQueryDataSet != null) && __isset.nonAlignQueryDataSet)
      {
        tmp59.Name = "nonAlignQueryDataSet";
        tmp59.Type = TType.Struct;
        tmp59.ID = 8;
        await oprot.WriteFieldBeginAsync(tmp59, cancellationToken);
        await NonAlignQueryDataSet.WriteAsync(oprot, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((ColumnNameIndexMap != null) && __isset.columnNameIndexMap)
      {
        tmp59.Name = "columnNameIndexMap";
        tmp59.Type = TType.Map;
        tmp59.ID = 9;
        await oprot.WriteFieldBeginAsync(tmp59, cancellationToken);
        {
          await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.I32, ColumnNameIndexMap.Count), cancellationToken);
          foreach (string _iter62 in ColumnNameIndexMap.Keys)
          {
            await oprot.WriteStringAsync(_iter62, cancellationToken);
            await oprot.WriteI32Async(ColumnNameIndexMap[_iter62], cancellationToken);
          }
          await oprot.WriteMapEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((SgColumns != null) && __isset.sgColumns)
      {
        tmp59.Name = "sgColumns";
        tmp59.Type = TType.List;
        tmp59.ID = 10;
        await oprot.WriteFieldBeginAsync(tmp59, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.String, SgColumns.Count), cancellationToken);
          foreach (string _iter63 in SgColumns)
          {
            await oprot.WriteStringAsync(_iter63, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((AliasColumns != null) && __isset.aliasColumns)
      {
        tmp59.Name = "aliasColumns";
        tmp59.Type = TType.List;
        tmp59.ID = 11;
        await oprot.WriteFieldBeginAsync(tmp59, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.Byte, AliasColumns.Count), cancellationToken);
          foreach (sbyte _iter64 in AliasColumns)
          {
            await oprot.WriteByteAsync(_iter64, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((TracingInfo != null) && __isset.tracingInfo)
      {
        tmp59.Name = "tracingInfo";
        tmp59.Type = TType.Struct;
        tmp59.ID = 12;
        await oprot.WriteFieldBeginAsync(tmp59, cancellationToken);
        await TracingInfo.WriteAsync(oprot, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((QueryResult != null) && __isset.queryResult)
      {
        tmp59.Name = "queryResult";
        tmp59.Type = TType.List;
        tmp59.ID = 13;
        await oprot.WriteFieldBeginAsync(tmp59, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.String, QueryResult.Count), cancellationToken);
          foreach (byte[] _iter65 in QueryResult)
          {
            await oprot.WriteBinaryAsync(_iter65, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if(__isset.moreData)
      {
        tmp59.Name = "moreData";
        tmp59.Type = TType.Bool;
        tmp59.ID = 14;
        await oprot.WriteFieldBeginAsync(tmp59, cancellationToken);
        await oprot.WriteBoolAsync(MoreData, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((Database != null) && __isset.database)
      {
        tmp59.Name = "database";
        tmp59.Type = TType.String;
        tmp59.ID = 15;
        await oprot.WriteFieldBeginAsync(tmp59, cancellationToken);
        await oprot.WriteStringAsync(Database, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if(__isset.tableModel)
      {
        tmp59.Name = "tableModel";
        tmp59.Type = TType.Bool;
        tmp59.ID = 16;
        await oprot.WriteFieldBeginAsync(tmp59, cancellationToken);
        await oprot.WriteBoolAsync(TableModel, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((ColumnIndex2TsBlockColumnIndexList != null) && __isset.columnIndex2TsBlockColumnIndexList)
      {
        tmp59.Name = "columnIndex2TsBlockColumnIndexList";
        tmp59.Type = TType.List;
        tmp59.ID = 17;
        await oprot.WriteFieldBeginAsync(tmp59, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.I32, ColumnIndex2TsBlockColumnIndexList.Count), cancellationToken);
          foreach (int _iter66 in ColumnIndex2TsBlockColumnIndexList)
          {
            await oprot.WriteI32Async(_iter66, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      await oprot.WriteFieldStopAsync(cancellationToken);
      await oprot.WriteStructEndAsync(cancellationToken);
    }
    finally
    {
      oprot.DecrementRecursionDepth();
    }
  }

  public override bool Equals(object that)
  {
    if (!(that is TSExecuteStatementResp other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return System.Object.Equals(Status, other.Status)
      && ((__isset.queryId == other.__isset.queryId) && ((!__isset.queryId) || (System.Object.Equals(QueryId, other.QueryId))))
      && ((__isset.columns == other.__isset.columns) && ((!__isset.columns) || (TCollections.Equals(Columns, other.Columns))))
      && ((__isset.operationType == other.__isset.operationType) && ((!__isset.operationType) || (System.Object.Equals(OperationType, other.OperationType))))
      && ((__isset.ignoreTimeStamp == other.__isset.ignoreTimeStamp) && ((!__isset.ignoreTimeStamp) || (System.Object.Equals(IgnoreTimeStamp, other.IgnoreTimeStamp))))
      && ((__isset.dataTypeList == other.__isset.dataTypeList) && ((!__isset.dataTypeList) || (TCollections.Equals(DataTypeList, other.DataTypeList))))
      && ((__isset.queryDataSet == other.__isset.queryDataSet) && ((!__isset.queryDataSet) || (System.Object.Equals(QueryDataSet, other.QueryDataSet))))
      && ((__isset.nonAlignQueryDataSet == other.__isset.nonAlignQueryDataSet) && ((!__isset.nonAlignQueryDataSet) || (System.Object.Equals(NonAlignQueryDataSet, other.NonAlignQueryDataSet))))
      && ((__isset.columnNameIndexMap == other.__isset.columnNameIndexMap) && ((!__isset.columnNameIndexMap) || (TCollections.Equals(ColumnNameIndexMap, other.ColumnNameIndexMap))))
      && ((__isset.sgColumns == other.__isset.sgColumns) && ((!__isset.sgColumns) || (TCollections.Equals(SgColumns, other.SgColumns))))
      && ((__isset.aliasColumns == other.__isset.aliasColumns) && ((!__isset.aliasColumns) || (TCollections.Equals(AliasColumns, other.AliasColumns))))
      && ((__isset.tracingInfo == other.__isset.tracingInfo) && ((!__isset.tracingInfo) || (System.Object.Equals(TracingInfo, other.TracingInfo))))
      && ((__isset.queryResult == other.__isset.queryResult) && ((!__isset.queryResult) || (TCollections.Equals(QueryResult, other.QueryResult))))
      && ((__isset.moreData == other.__isset.moreData) && ((!__isset.moreData) || (System.Object.Equals(MoreData, other.MoreData))))
      && ((__isset.database == other.__isset.database) && ((!__isset.database) || (System.Object.Equals(Database, other.Database))))
      && ((__isset.tableModel == other.__isset.tableModel) && ((!__isset.tableModel) || (System.Object.Equals(TableModel, other.TableModel))))
      && ((__isset.columnIndex2TsBlockColumnIndexList == other.__isset.columnIndex2TsBlockColumnIndexList) && ((!__isset.columnIndex2TsBlockColumnIndexList) || (TCollections.Equals(ColumnIndex2TsBlockColumnIndexList, other.ColumnIndex2TsBlockColumnIndexList))));
  }

  public override int GetHashCode() {
    int hashcode = 157;
    unchecked {
      if((Status != null))
      {
        hashcode = (hashcode * 397) + Status.GetHashCode();
      }
      if(__isset.queryId)
      {
        hashcode = (hashcode * 397) + QueryId.GetHashCode();
      }
      if((Columns != null) && __isset.columns)
      {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(Columns);
      }
      if((OperationType != null) && __isset.operationType)
      {
        hashcode = (hashcode * 397) + OperationType.GetHashCode();
      }
      if(__isset.ignoreTimeStamp)
      {
        hashcode = (hashcode * 397) + IgnoreTimeStamp.GetHashCode();
      }
      if((DataTypeList != null) && __isset.dataTypeList)
      {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(DataTypeList);
      }
      if((QueryDataSet != null) && __isset.queryDataSet)
      {
        hashcode = (hashcode * 397) + QueryDataSet.GetHashCode();
      }
      if((NonAlignQueryDataSet != null) && __isset.nonAlignQueryDataSet)
      {
        hashcode = (hashcode * 397) + NonAlignQueryDataSet.GetHashCode();
      }
      if((ColumnNameIndexMap != null) && __isset.columnNameIndexMap)
      {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(ColumnNameIndexMap);
      }
      if((SgColumns != null) && __isset.sgColumns)
      {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(SgColumns);
      }
      if((AliasColumns != null) && __isset.aliasColumns)
      {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(AliasColumns);
      }
      if((TracingInfo != null) && __isset.tracingInfo)
      {
        hashcode = (hashcode * 397) + TracingInfo.GetHashCode();
      }
      if((QueryResult != null) && __isset.queryResult)
      {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(QueryResult);
      }
      if(__isset.moreData)
      {
        hashcode = (hashcode * 397) + MoreData.GetHashCode();
      }
      if((Database != null) && __isset.database)
      {
        hashcode = (hashcode * 397) + Database.GetHashCode();
      }
      if(__isset.tableModel)
      {
        hashcode = (hashcode * 397) + TableModel.GetHashCode();
      }
      if((ColumnIndex2TsBlockColumnIndexList != null) && __isset.columnIndex2TsBlockColumnIndexList)
      {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(ColumnIndex2TsBlockColumnIndexList);
      }
    }
    return hashcode;
  }

  public override string ToString()
  {
    var tmp67 = new StringBuilder("TSExecuteStatementResp(");
    if((Status != null))
    {
      tmp67.Append(", Status: ");
      Status.ToString(tmp67);
    }
    if(__isset.queryId)
    {
      tmp67.Append(", QueryId: ");
      QueryId.ToString(tmp67);
    }
    if((Columns != null) && __isset.columns)
    {
      tmp67.Append(", Columns: ");
      Columns.ToString(tmp67);
    }
    if((OperationType != null) && __isset.operationType)
    {
      tmp67.Append(", OperationType: ");
      OperationType.ToString(tmp67);
    }
    if(__isset.ignoreTimeStamp)
    {
      tmp67.Append(", IgnoreTimeStamp: ");
      IgnoreTimeStamp.ToString(tmp67);
    }
    if((DataTypeList != null) && __isset.dataTypeList)
    {
      tmp67.Append(", DataTypeList: ");
      DataTypeList.ToString(tmp67);
    }
    if((QueryDataSet != null) && __isset.queryDataSet)
    {
      tmp67.Append(", QueryDataSet: ");
      QueryDataSet.ToString(tmp67);
    }
    if((NonAlignQueryDataSet != null) && __isset.nonAlignQueryDataSet)
    {
      tmp67.Append(", NonAlignQueryDataSet: ");
      NonAlignQueryDataSet.ToString(tmp67);
    }
    if((ColumnNameIndexMap != null) && __isset.columnNameIndexMap)
    {
      tmp67.Append(", ColumnNameIndexMap: ");
      ColumnNameIndexMap.ToString(tmp67);
    }
    if((SgColumns != null) && __isset.sgColumns)
    {
      tmp67.Append(", SgColumns: ");
      SgColumns.ToString(tmp67);
    }
    if((AliasColumns != null) && __isset.aliasColumns)
    {
      tmp67.Append(", AliasColumns: ");
      AliasColumns.ToString(tmp67);
    }
    if((TracingInfo != null) && __isset.tracingInfo)
    {
      tmp67.Append(", TracingInfo: ");
      TracingInfo.ToString(tmp67);
    }
    if((QueryResult != null) && __isset.queryResult)
    {
      tmp67.Append(", QueryResult: ");
      QueryResult.ToString(tmp67);
    }
    if(__isset.moreData)
    {
      tmp67.Append(", MoreData: ");
      MoreData.ToString(tmp67);
    }
    if((Database != null) && __isset.database)
    {
      tmp67.Append(", Database: ");
      Database.ToString(tmp67);
    }
    if(__isset.tableModel)
    {
      tmp67.Append(", TableModel: ");
      TableModel.ToString(tmp67);
    }
    if((ColumnIndex2TsBlockColumnIndexList != null) && __isset.columnIndex2TsBlockColumnIndexList)
    {
      tmp67.Append(", ColumnIndex2TsBlockColumnIndexList: ");
      ColumnIndex2TsBlockColumnIndexList.ToString(tmp67);
    }
    tmp67.Append(')');
    return tmp67.ToString();
  }
}

