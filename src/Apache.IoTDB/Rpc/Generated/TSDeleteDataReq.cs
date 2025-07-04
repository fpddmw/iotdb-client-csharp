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


public partial class TSDeleteDataReq : TBase
{

  public long SessionId { get; set; }

  public List<string> Paths { get; set; }

  public long StartTime { get; set; }

  public long EndTime { get; set; }

  public TSDeleteDataReq()
  {
  }

  public TSDeleteDataReq(long sessionId, List<string> paths, long startTime, long endTime) : this()
  {
    this.SessionId = sessionId;
    this.Paths = paths;
    this.StartTime = startTime;
    this.EndTime = endTime;
  }

  public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      bool isset_sessionId = false;
      bool isset_paths = false;
      bool isset_startTime = false;
      bool isset_endTime = false;
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
            if (field.Type == TType.List)
            {
              {
                TList _list319 = await iprot.ReadListBeginAsync(cancellationToken);
                Paths = new List<string>(_list319.Count);
                for(int _i320 = 0; _i320 < _list319.Count; ++_i320)
                {
                  string _elem321;
                  _elem321 = await iprot.ReadStringAsync(cancellationToken);
                  Paths.Add(_elem321);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
              isset_paths = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 3:
            if (field.Type == TType.I64)
            {
              StartTime = await iprot.ReadI64Async(cancellationToken);
              isset_startTime = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 4:
            if (field.Type == TType.I64)
            {
              EndTime = await iprot.ReadI64Async(cancellationToken);
              isset_endTime = true;
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
      if (!isset_paths)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      if (!isset_startTime)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      if (!isset_endTime)
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
      var tmp322 = new TStruct("TSDeleteDataReq");
      await oprot.WriteStructBeginAsync(tmp322, cancellationToken);
      var tmp323 = new TField();
      tmp323.Name = "sessionId";
      tmp323.Type = TType.I64;
      tmp323.ID = 1;
      await oprot.WriteFieldBeginAsync(tmp323, cancellationToken);
      await oprot.WriteI64Async(SessionId, cancellationToken);
      await oprot.WriteFieldEndAsync(cancellationToken);
      if((Paths != null))
      {
        tmp323.Name = "paths";
        tmp323.Type = TType.List;
        tmp323.ID = 2;
        await oprot.WriteFieldBeginAsync(tmp323, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.String, Paths.Count), cancellationToken);
          foreach (string _iter324 in Paths)
          {
            await oprot.WriteStringAsync(_iter324, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      tmp323.Name = "startTime";
      tmp323.Type = TType.I64;
      tmp323.ID = 3;
      await oprot.WriteFieldBeginAsync(tmp323, cancellationToken);
      await oprot.WriteI64Async(StartTime, cancellationToken);
      await oprot.WriteFieldEndAsync(cancellationToken);
      tmp323.Name = "endTime";
      tmp323.Type = TType.I64;
      tmp323.ID = 4;
      await oprot.WriteFieldBeginAsync(tmp323, cancellationToken);
      await oprot.WriteI64Async(EndTime, cancellationToken);
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
    if (!(that is TSDeleteDataReq other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return System.Object.Equals(SessionId, other.SessionId)
      && TCollections.Equals(Paths, other.Paths)
      && System.Object.Equals(StartTime, other.StartTime)
      && System.Object.Equals(EndTime, other.EndTime);
  }

  public override int GetHashCode() {
    int hashcode = 157;
    unchecked {
      hashcode = (hashcode * 397) + SessionId.GetHashCode();
      if((Paths != null))
      {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(Paths);
      }
      hashcode = (hashcode * 397) + StartTime.GetHashCode();
      hashcode = (hashcode * 397) + EndTime.GetHashCode();
    }
    return hashcode;
  }

  public override string ToString()
  {
    var tmp325 = new StringBuilder("TSDeleteDataReq(");
    tmp325.Append(", SessionId: ");
    SessionId.ToString(tmp325);
    if((Paths != null))
    {
      tmp325.Append(", Paths: ");
      Paths.ToString(tmp325);
    }
    tmp325.Append(", StartTime: ");
    StartTime.ToString(tmp325);
    tmp325.Append(", EndTime: ");
    EndTime.ToString(tmp325);
    tmp325.Append(')');
    return tmp325.ToString();
  }
}

