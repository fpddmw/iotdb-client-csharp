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


public partial class TNodeResource : TBase
{

  public int CpuCoreNum { get; set; }

  public long MaxMemory { get; set; }

  public TNodeResource()
  {
  }

  public TNodeResource(int cpuCoreNum, long maxMemory) : this()
  {
    this.CpuCoreNum = cpuCoreNum;
    this.MaxMemory = maxMemory;
  }

  public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      bool isset_cpuCoreNum = false;
      bool isset_maxMemory = false;
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
            if (field.Type == TType.I32)
            {
              CpuCoreNum = await iprot.ReadI32Async(cancellationToken);
              isset_cpuCoreNum = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 2:
            if (field.Type == TType.I64)
            {
              MaxMemory = await iprot.ReadI64Async(cancellationToken);
              isset_maxMemory = true;
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
      if (!isset_cpuCoreNum)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      if (!isset_maxMemory)
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
      var tmp32 = new TStruct("TNodeResource");
      await oprot.WriteStructBeginAsync(tmp32, cancellationToken);
      var tmp33 = new TField();
      tmp33.Name = "cpuCoreNum";
      tmp33.Type = TType.I32;
      tmp33.ID = 1;
      await oprot.WriteFieldBeginAsync(tmp33, cancellationToken);
      await oprot.WriteI32Async(CpuCoreNum, cancellationToken);
      await oprot.WriteFieldEndAsync(cancellationToken);
      tmp33.Name = "maxMemory";
      tmp33.Type = TType.I64;
      tmp33.ID = 2;
      await oprot.WriteFieldBeginAsync(tmp33, cancellationToken);
      await oprot.WriteI64Async(MaxMemory, cancellationToken);
      await oprot.WriteFieldEndAsync(cancellationToken);
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
    if (!(that is TNodeResource other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return System.Object.Equals(CpuCoreNum, other.CpuCoreNum)
      && System.Object.Equals(MaxMemory, other.MaxMemory);
  }

  public override int GetHashCode() {
    int hashcode = 157;
    unchecked {
      hashcode = (hashcode * 397) + CpuCoreNum.GetHashCode();
      hashcode = (hashcode * 397) + MaxMemory.GetHashCode();
    }
    return hashcode;
  }

  public override string ToString()
  {
    var tmp34 = new StringBuilder("TNodeResource(");
    tmp34.Append(", CpuCoreNum: ");
    CpuCoreNum.ToString(tmp34);
    tmp34.Append(", MaxMemory: ");
    MaxMemory.ToString(tmp34);
    tmp34.Append(')');
    return tmp34.ToString();
  }
}

