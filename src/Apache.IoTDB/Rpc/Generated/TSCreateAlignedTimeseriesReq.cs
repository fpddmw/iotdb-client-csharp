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


public partial class TSCreateAlignedTimeseriesReq : TBase
{
  private List<string> _measurementAlias;
  private List<Dictionary<string, string>> _tagsList;
  private List<Dictionary<string, string>> _attributesList;

  public long SessionId { get; set; }

  public string PrefixPath { get; set; }

  public List<string> Measurements { get; set; }

  public List<int> DataTypes { get; set; }

  public List<int> Encodings { get; set; }

  public List<int> Compressors { get; set; }

  public List<string> MeasurementAlias
  {
    get
    {
      return _measurementAlias;
    }
    set
    {
      __isset.measurementAlias = true;
      this._measurementAlias = value;
    }
  }

  public List<Dictionary<string, string>> TagsList
  {
    get
    {
      return _tagsList;
    }
    set
    {
      __isset.tagsList = true;
      this._tagsList = value;
    }
  }

  public List<Dictionary<string, string>> AttributesList
  {
    get
    {
      return _attributesList;
    }
    set
    {
      __isset.attributesList = true;
      this._attributesList = value;
    }
  }


  public Isset __isset;
  public struct Isset
  {
    public bool measurementAlias;
    public bool tagsList;
    public bool attributesList;
  }

  public TSCreateAlignedTimeseriesReq()
  {
  }

  public TSCreateAlignedTimeseriesReq(long sessionId, string prefixPath, List<string> measurements, List<int> dataTypes, List<int> encodings, List<int> compressors) : this()
  {
    this.SessionId = sessionId;
    this.PrefixPath = prefixPath;
    this.Measurements = measurements;
    this.DataTypes = dataTypes;
    this.Encodings = encodings;
    this.Compressors = compressors;
  }

  public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      bool isset_sessionId = false;
      bool isset_prefixPath = false;
      bool isset_measurements = false;
      bool isset_dataTypes = false;
      bool isset_encodings = false;
      bool isset_compressors = false;
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
            if (field.Type == TType.I64)
            {
              SessionId = await iprot.ReadI64Async(cancellationToken);
              isset_sessionId = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 2:
            if (field.Type == TType.String)
            {
              PrefixPath = await iprot.ReadStringAsync(cancellationToken);
              isset_prefixPath = true;
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
                TList _list346 = await iprot.ReadListBeginAsync(cancellationToken);
                Measurements = new List<string>(_list346.Count);
                for(int _i347 = 0; _i347 < _list346.Count; ++_i347)
                {
                  string _elem348;
                  _elem348 = await iprot.ReadStringAsync(cancellationToken);
                  Measurements.Add(_elem348);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
              isset_measurements = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 4:
            if (field.Type == TType.List)
            {
              {
                TList _list349 = await iprot.ReadListBeginAsync(cancellationToken);
                DataTypes = new List<int>(_list349.Count);
                for(int _i350 = 0; _i350 < _list349.Count; ++_i350)
                {
                  int _elem351;
                  _elem351 = await iprot.ReadI32Async(cancellationToken);
                  DataTypes.Add(_elem351);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
              isset_dataTypes = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 5:
            if (field.Type == TType.List)
            {
              {
                TList _list352 = await iprot.ReadListBeginAsync(cancellationToken);
                Encodings = new List<int>(_list352.Count);
                for(int _i353 = 0; _i353 < _list352.Count; ++_i353)
                {
                  int _elem354;
                  _elem354 = await iprot.ReadI32Async(cancellationToken);
                  Encodings.Add(_elem354);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
              isset_encodings = true;
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
                TList _list355 = await iprot.ReadListBeginAsync(cancellationToken);
                Compressors = new List<int>(_list355.Count);
                for(int _i356 = 0; _i356 < _list355.Count; ++_i356)
                {
                  int _elem357;
                  _elem357 = await iprot.ReadI32Async(cancellationToken);
                  Compressors.Add(_elem357);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
              isset_compressors = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 7:
            if (field.Type == TType.List)
            {
              {
                TList _list358 = await iprot.ReadListBeginAsync(cancellationToken);
                MeasurementAlias = new List<string>(_list358.Count);
                for(int _i359 = 0; _i359 < _list358.Count; ++_i359)
                {
                  string _elem360;
                  _elem360 = await iprot.ReadStringAsync(cancellationToken);
                  MeasurementAlias.Add(_elem360);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 8:
            if (field.Type == TType.List)
            {
              {
                TList _list361 = await iprot.ReadListBeginAsync(cancellationToken);
                TagsList = new List<Dictionary<string, string>>(_list361.Count);
                for(int _i362 = 0; _i362 < _list361.Count; ++_i362)
                {
                  Dictionary<string, string> _elem363;
                  {
                    TMap _map364 = await iprot.ReadMapBeginAsync(cancellationToken);
                    _elem363 = new Dictionary<string, string>(_map364.Count);
                    for(int _i365 = 0; _i365 < _map364.Count; ++_i365)
                    {
                      string _key366;
                      string _val367;
                      _key366 = await iprot.ReadStringAsync(cancellationToken);
                      _val367 = await iprot.ReadStringAsync(cancellationToken);
                      _elem363[_key366] = _val367;
                    }
                    await iprot.ReadMapEndAsync(cancellationToken);
                  }
                  TagsList.Add(_elem363);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 9:
            if (field.Type == TType.List)
            {
              {
                TList _list368 = await iprot.ReadListBeginAsync(cancellationToken);
                AttributesList = new List<Dictionary<string, string>>(_list368.Count);
                for(int _i369 = 0; _i369 < _list368.Count; ++_i369)
                {
                  Dictionary<string, string> _elem370;
                  {
                    TMap _map371 = await iprot.ReadMapBeginAsync(cancellationToken);
                    _elem370 = new Dictionary<string, string>(_map371.Count);
                    for(int _i372 = 0; _i372 < _map371.Count; ++_i372)
                    {
                      string _key373;
                      string _val374;
                      _key373 = await iprot.ReadStringAsync(cancellationToken);
                      _val374 = await iprot.ReadStringAsync(cancellationToken);
                      _elem370[_key373] = _val374;
                    }
                    await iprot.ReadMapEndAsync(cancellationToken);
                  }
                  AttributesList.Add(_elem370);
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
      if (!isset_sessionId)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      if (!isset_prefixPath)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      if (!isset_measurements)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      if (!isset_dataTypes)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      if (!isset_encodings)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      if (!isset_compressors)
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
      var tmp375 = new TStruct("TSCreateAlignedTimeseriesReq");
      await oprot.WriteStructBeginAsync(tmp375, cancellationToken);
      var tmp376 = new TField();
      tmp376.Name = "sessionId";
      tmp376.Type = TType.I64;
      tmp376.ID = 1;
      await oprot.WriteFieldBeginAsync(tmp376, cancellationToken);
      await oprot.WriteI64Async(SessionId, cancellationToken);
      await oprot.WriteFieldEndAsync(cancellationToken);
      if((PrefixPath != null))
      {
        tmp376.Name = "prefixPath";
        tmp376.Type = TType.String;
        tmp376.ID = 2;
        await oprot.WriteFieldBeginAsync(tmp376, cancellationToken);
        await oprot.WriteStringAsync(PrefixPath, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((Measurements != null))
      {
        tmp376.Name = "measurements";
        tmp376.Type = TType.List;
        tmp376.ID = 3;
        await oprot.WriteFieldBeginAsync(tmp376, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.String, Measurements.Count), cancellationToken);
          foreach (string _iter377 in Measurements)
          {
            await oprot.WriteStringAsync(_iter377, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((DataTypes != null))
      {
        tmp376.Name = "dataTypes";
        tmp376.Type = TType.List;
        tmp376.ID = 4;
        await oprot.WriteFieldBeginAsync(tmp376, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.I32, DataTypes.Count), cancellationToken);
          foreach (int _iter378 in DataTypes)
          {
            await oprot.WriteI32Async(_iter378, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((Encodings != null))
      {
        tmp376.Name = "encodings";
        tmp376.Type = TType.List;
        tmp376.ID = 5;
        await oprot.WriteFieldBeginAsync(tmp376, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.I32, Encodings.Count), cancellationToken);
          foreach (int _iter379 in Encodings)
          {
            await oprot.WriteI32Async(_iter379, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((Compressors != null))
      {
        tmp376.Name = "compressors";
        tmp376.Type = TType.List;
        tmp376.ID = 6;
        await oprot.WriteFieldBeginAsync(tmp376, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.I32, Compressors.Count), cancellationToken);
          foreach (int _iter380 in Compressors)
          {
            await oprot.WriteI32Async(_iter380, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((MeasurementAlias != null) && __isset.measurementAlias)
      {
        tmp376.Name = "measurementAlias";
        tmp376.Type = TType.List;
        tmp376.ID = 7;
        await oprot.WriteFieldBeginAsync(tmp376, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.String, MeasurementAlias.Count), cancellationToken);
          foreach (string _iter381 in MeasurementAlias)
          {
            await oprot.WriteStringAsync(_iter381, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((TagsList != null) && __isset.tagsList)
      {
        tmp376.Name = "tagsList";
        tmp376.Type = TType.List;
        tmp376.ID = 8;
        await oprot.WriteFieldBeginAsync(tmp376, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.Map, TagsList.Count), cancellationToken);
          foreach (Dictionary<string, string> _iter382 in TagsList)
          {
            {
              await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.String, _iter382.Count), cancellationToken);
              foreach (string _iter383 in _iter382.Keys)
              {
                await oprot.WriteStringAsync(_iter383, cancellationToken);
                await oprot.WriteStringAsync(_iter382[_iter383], cancellationToken);
              }
              await oprot.WriteMapEndAsync(cancellationToken);
            }
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((AttributesList != null) && __isset.attributesList)
      {
        tmp376.Name = "attributesList";
        tmp376.Type = TType.List;
        tmp376.ID = 9;
        await oprot.WriteFieldBeginAsync(tmp376, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.Map, AttributesList.Count), cancellationToken);
          foreach (Dictionary<string, string> _iter384 in AttributesList)
          {
            {
              await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.String, _iter384.Count), cancellationToken);
              foreach (string _iter385 in _iter384.Keys)
              {
                await oprot.WriteStringAsync(_iter385, cancellationToken);
                await oprot.WriteStringAsync(_iter384[_iter385], cancellationToken);
              }
              await oprot.WriteMapEndAsync(cancellationToken);
            }
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
    if (!(that is TSCreateAlignedTimeseriesReq other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return System.Object.Equals(SessionId, other.SessionId)
      && System.Object.Equals(PrefixPath, other.PrefixPath)
      && TCollections.Equals(Measurements, other.Measurements)
      && TCollections.Equals(DataTypes, other.DataTypes)
      && TCollections.Equals(Encodings, other.Encodings)
      && TCollections.Equals(Compressors, other.Compressors)
      && ((__isset.measurementAlias == other.__isset.measurementAlias) && ((!__isset.measurementAlias) || (TCollections.Equals(MeasurementAlias, other.MeasurementAlias))))
      && ((__isset.tagsList == other.__isset.tagsList) && ((!__isset.tagsList) || (TCollections.Equals(TagsList, other.TagsList))))
      && ((__isset.attributesList == other.__isset.attributesList) && ((!__isset.attributesList) || (TCollections.Equals(AttributesList, other.AttributesList))));
  }

  public override int GetHashCode() {
    int hashcode = 157;
    unchecked {
      hashcode = (hashcode * 397) + SessionId.GetHashCode();
      if((PrefixPath != null))
      {
        hashcode = (hashcode * 397) + PrefixPath.GetHashCode();
      }
      if((Measurements != null))
      {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(Measurements);
      }
      if((DataTypes != null))
      {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(DataTypes);
      }
      if((Encodings != null))
      {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(Encodings);
      }
      if((Compressors != null))
      {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(Compressors);
      }
      if((MeasurementAlias != null) && __isset.measurementAlias)
      {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(MeasurementAlias);
      }
      if((TagsList != null) && __isset.tagsList)
      {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(TagsList);
      }
      if((AttributesList != null) && __isset.attributesList)
      {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(AttributesList);
      }
    }
    return hashcode;
  }

  public override string ToString()
  {
    var tmp386 = new StringBuilder("TSCreateAlignedTimeseriesReq(");
    tmp386.Append(", SessionId: ");
    SessionId.ToString(tmp386);
    if((PrefixPath != null))
    {
      tmp386.Append(", PrefixPath: ");
      PrefixPath.ToString(tmp386);
    }
    if((Measurements != null))
    {
      tmp386.Append(", Measurements: ");
      Measurements.ToString(tmp386);
    }
    if((DataTypes != null))
    {
      tmp386.Append(", DataTypes: ");
      DataTypes.ToString(tmp386);
    }
    if((Encodings != null))
    {
      tmp386.Append(", Encodings: ");
      Encodings.ToString(tmp386);
    }
    if((Compressors != null))
    {
      tmp386.Append(", Compressors: ");
      Compressors.ToString(tmp386);
    }
    if((MeasurementAlias != null) && __isset.measurementAlias)
    {
      tmp386.Append(", MeasurementAlias: ");
      MeasurementAlias.ToString(tmp386);
    }
    if((TagsList != null) && __isset.tagsList)
    {
      tmp386.Append(", TagsList: ");
      TagsList.ToString(tmp386);
    }
    if((AttributesList != null) && __isset.attributesList)
    {
      tmp386.Append(", AttributesList: ");
      AttributesList.ToString(tmp386);
    }
    tmp386.Append(')');
    return tmp386.ToString();
  }
}

