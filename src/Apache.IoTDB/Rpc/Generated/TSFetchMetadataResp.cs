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


public partial class TSFetchMetadataResp : TBase
{
  private string _metadataInJson;
  private List<string> _columnsList;
  private string _dataType;

  public TSStatus Status { get; set; }

  public string MetadataInJson
  {
    get
    {
      return _metadataInJson;
    }
    set
    {
      __isset.metadataInJson = true;
      this._metadataInJson = value;
    }
  }

  public List<string> ColumnsList
  {
    get
    {
      return _columnsList;
    }
    set
    {
      __isset.columnsList = true;
      this._columnsList = value;
    }
  }

  public string DataType
  {
    get
    {
      return _dataType;
    }
    set
    {
      __isset.dataType = true;
      this._dataType = value;
    }
  }


  public Isset __isset;
  public struct Isset
  {
    public bool metadataInJson;
    public bool columnsList;
    public bool dataType;
  }

  public TSFetchMetadataResp()
  {
  }

  public TSFetchMetadataResp(TSStatus status) : this()
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
            if (field.Type == TType.String)
            {
              MetadataInJson = await iprot.ReadStringAsync(cancellationToken);
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
                TList _list127 = await iprot.ReadListBeginAsync(cancellationToken);
                ColumnsList = new List<string>(_list127.Count);
                for(int _i128 = 0; _i128 < _list127.Count; ++_i128)
                {
                  string _elem129;
                  _elem129 = await iprot.ReadStringAsync(cancellationToken);
                  ColumnsList.Add(_elem129);
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
              DataType = await iprot.ReadStringAsync(cancellationToken);
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
      var tmp130 = new TStruct("TSFetchMetadataResp");
      await oprot.WriteStructBeginAsync(tmp130, cancellationToken);
      var tmp131 = new TField();
      if((Status != null))
      {
        tmp131.Name = "status";
        tmp131.Type = TType.Struct;
        tmp131.ID = 1;
        await oprot.WriteFieldBeginAsync(tmp131, cancellationToken);
        await Status.WriteAsync(oprot, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((MetadataInJson != null) && __isset.metadataInJson)
      {
        tmp131.Name = "metadataInJson";
        tmp131.Type = TType.String;
        tmp131.ID = 2;
        await oprot.WriteFieldBeginAsync(tmp131, cancellationToken);
        await oprot.WriteStringAsync(MetadataInJson, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((ColumnsList != null) && __isset.columnsList)
      {
        tmp131.Name = "columnsList";
        tmp131.Type = TType.List;
        tmp131.ID = 3;
        await oprot.WriteFieldBeginAsync(tmp131, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.String, ColumnsList.Count), cancellationToken);
          foreach (string _iter132 in ColumnsList)
          {
            await oprot.WriteStringAsync(_iter132, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((DataType != null) && __isset.dataType)
      {
        tmp131.Name = "dataType";
        tmp131.Type = TType.String;
        tmp131.ID = 4;
        await oprot.WriteFieldBeginAsync(tmp131, cancellationToken);
        await oprot.WriteStringAsync(DataType, cancellationToken);
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
    if (!(that is TSFetchMetadataResp other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return System.Object.Equals(Status, other.Status)
      && ((__isset.metadataInJson == other.__isset.metadataInJson) && ((!__isset.metadataInJson) || (System.Object.Equals(MetadataInJson, other.MetadataInJson))))
      && ((__isset.columnsList == other.__isset.columnsList) && ((!__isset.columnsList) || (TCollections.Equals(ColumnsList, other.ColumnsList))))
      && ((__isset.dataType == other.__isset.dataType) && ((!__isset.dataType) || (System.Object.Equals(DataType, other.DataType))));
  }

  public override int GetHashCode() {
    int hashcode = 157;
    unchecked {
      if((Status != null))
      {
        hashcode = (hashcode * 397) + Status.GetHashCode();
      }
      if((MetadataInJson != null) && __isset.metadataInJson)
      {
        hashcode = (hashcode * 397) + MetadataInJson.GetHashCode();
      }
      if((ColumnsList != null) && __isset.columnsList)
      {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(ColumnsList);
      }
      if((DataType != null) && __isset.dataType)
      {
        hashcode = (hashcode * 397) + DataType.GetHashCode();
      }
    }
    return hashcode;
  }

  public override string ToString()
  {
    var tmp133 = new StringBuilder("TSFetchMetadataResp(");
    if((Status != null))
    {
      tmp133.Append(", Status: ");
      Status.ToString(tmp133);
    }
    if((MetadataInJson != null) && __isset.metadataInJson)
    {
      tmp133.Append(", MetadataInJson: ");
      MetadataInJson.ToString(tmp133);
    }
    if((ColumnsList != null) && __isset.columnsList)
    {
      tmp133.Append(", ColumnsList: ");
      ColumnsList.ToString(tmp133);
    }
    if((DataType != null) && __isset.dataType)
    {
      tmp133.Append(", DataType: ");
      DataType.ToString(tmp133);
    }
    tmp133.Append(')');
    return tmp133.ToString();
  }
}

