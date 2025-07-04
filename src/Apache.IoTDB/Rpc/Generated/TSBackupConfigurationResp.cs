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


public partial class TSBackupConfigurationResp : TBase
{
  private bool _enableOperationSync;
  private string _secondaryAddress;
  private int _secondaryPort;

  public TSStatus Status { get; set; }

  public bool EnableOperationSync
  {
    get
    {
      return _enableOperationSync;
    }
    set
    {
      __isset.enableOperationSync = true;
      this._enableOperationSync = value;
    }
  }

  public string SecondaryAddress
  {
    get
    {
      return _secondaryAddress;
    }
    set
    {
      __isset.secondaryAddress = true;
      this._secondaryAddress = value;
    }
  }

  public int SecondaryPort
  {
    get
    {
      return _secondaryPort;
    }
    set
    {
      __isset.secondaryPort = true;
      this._secondaryPort = value;
    }
  }


  public Isset __isset;
  public struct Isset
  {
    public bool enableOperationSync;
    public bool secondaryAddress;
    public bool secondaryPort;
  }

  public TSBackupConfigurationResp()
  {
  }

  public TSBackupConfigurationResp(TSStatus status) : this()
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
            if (field.Type == TType.Bool)
            {
              EnableOperationSync = await iprot.ReadBoolAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 3:
            if (field.Type == TType.String)
            {
              SecondaryAddress = await iprot.ReadStringAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 4:
            if (field.Type == TType.I32)
            {
              SecondaryPort = await iprot.ReadI32Async(cancellationToken);
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
      var tmp583 = new TStruct("TSBackupConfigurationResp");
      await oprot.WriteStructBeginAsync(tmp583, cancellationToken);
      var tmp584 = new TField();
      if((Status != null))
      {
        tmp584.Name = "status";
        tmp584.Type = TType.Struct;
        tmp584.ID = 1;
        await oprot.WriteFieldBeginAsync(tmp584, cancellationToken);
        await Status.WriteAsync(oprot, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if(__isset.enableOperationSync)
      {
        tmp584.Name = "enableOperationSync";
        tmp584.Type = TType.Bool;
        tmp584.ID = 2;
        await oprot.WriteFieldBeginAsync(tmp584, cancellationToken);
        await oprot.WriteBoolAsync(EnableOperationSync, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((SecondaryAddress != null) && __isset.secondaryAddress)
      {
        tmp584.Name = "secondaryAddress";
        tmp584.Type = TType.String;
        tmp584.ID = 3;
        await oprot.WriteFieldBeginAsync(tmp584, cancellationToken);
        await oprot.WriteStringAsync(SecondaryAddress, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if(__isset.secondaryPort)
      {
        tmp584.Name = "secondaryPort";
        tmp584.Type = TType.I32;
        tmp584.ID = 4;
        await oprot.WriteFieldBeginAsync(tmp584, cancellationToken);
        await oprot.WriteI32Async(SecondaryPort, cancellationToken);
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
    if (!(that is TSBackupConfigurationResp other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return System.Object.Equals(Status, other.Status)
      && ((__isset.enableOperationSync == other.__isset.enableOperationSync) && ((!__isset.enableOperationSync) || (System.Object.Equals(EnableOperationSync, other.EnableOperationSync))))
      && ((__isset.secondaryAddress == other.__isset.secondaryAddress) && ((!__isset.secondaryAddress) || (System.Object.Equals(SecondaryAddress, other.SecondaryAddress))))
      && ((__isset.secondaryPort == other.__isset.secondaryPort) && ((!__isset.secondaryPort) || (System.Object.Equals(SecondaryPort, other.SecondaryPort))));
  }

  public override int GetHashCode() {
    int hashcode = 157;
    unchecked {
      if((Status != null))
      {
        hashcode = (hashcode * 397) + Status.GetHashCode();
      }
      if(__isset.enableOperationSync)
      {
        hashcode = (hashcode * 397) + EnableOperationSync.GetHashCode();
      }
      if((SecondaryAddress != null) && __isset.secondaryAddress)
      {
        hashcode = (hashcode * 397) + SecondaryAddress.GetHashCode();
      }
      if(__isset.secondaryPort)
      {
        hashcode = (hashcode * 397) + SecondaryPort.GetHashCode();
      }
    }
    return hashcode;
  }

  public override string ToString()
  {
    var tmp585 = new StringBuilder("TSBackupConfigurationResp(");
    if((Status != null))
    {
      tmp585.Append(", Status: ");
      Status.ToString(tmp585);
    }
    if(__isset.enableOperationSync)
    {
      tmp585.Append(", EnableOperationSync: ");
      EnableOperationSync.ToString(tmp585);
    }
    if((SecondaryAddress != null) && __isset.secondaryAddress)
    {
      tmp585.Append(", SecondaryAddress: ");
      SecondaryAddress.ToString(tmp585);
    }
    if(__isset.secondaryPort)
    {
      tmp585.Append(", SecondaryPort: ");
      SecondaryPort.ToString(tmp585);
    }
    tmp585.Append(')');
    return tmp585.ToString();
  }
}

