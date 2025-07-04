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


public partial class TDataNodeConfiguration : TBase
{

  public TDataNodeLocation Location { get; set; }

  public TNodeResource Resource { get; set; }

  public TDataNodeConfiguration()
  {
  }

  public TDataNodeConfiguration(TDataNodeLocation location, TNodeResource resource) : this()
  {
    this.Location = location;
    this.Resource = resource;
  }

  public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      bool isset_location = false;
      bool isset_resource = false;
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
              Location = new TDataNodeLocation();
              await Location.ReadAsync(iprot, cancellationToken);
              isset_location = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 2:
            if (field.Type == TType.Struct)
            {
              Resource = new TNodeResource();
              await Resource.ReadAsync(iprot, cancellationToken);
              isset_resource = true;
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
      if (!isset_location)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      if (!isset_resource)
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
      var tmp48 = new TStruct("TDataNodeConfiguration");
      await oprot.WriteStructBeginAsync(tmp48, cancellationToken);
      var tmp49 = new TField();
      if((Location != null))
      {
        tmp49.Name = "location";
        tmp49.Type = TType.Struct;
        tmp49.ID = 1;
        await oprot.WriteFieldBeginAsync(tmp49, cancellationToken);
        await Location.WriteAsync(oprot, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((Resource != null))
      {
        tmp49.Name = "resource";
        tmp49.Type = TType.Struct;
        tmp49.ID = 2;
        await oprot.WriteFieldBeginAsync(tmp49, cancellationToken);
        await Resource.WriteAsync(oprot, cancellationToken);
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
    if (!(that is TDataNodeConfiguration other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return System.Object.Equals(Location, other.Location)
      && System.Object.Equals(Resource, other.Resource);
  }

  public override int GetHashCode() {
    int hashcode = 157;
    unchecked {
      if((Location != null))
      {
        hashcode = (hashcode * 397) + Location.GetHashCode();
      }
      if((Resource != null))
      {
        hashcode = (hashcode * 397) + Resource.GetHashCode();
      }
    }
    return hashcode;
  }

  public override string ToString()
  {
    var tmp50 = new StringBuilder("TDataNodeConfiguration(");
    if((Location != null))
    {
      tmp50.Append(", Location: ");
      Location.ToString(tmp50);
    }
    if((Resource != null))
    {
      tmp50.Append(", Resource: ");
      Resource.ToString(tmp50);
    }
    tmp50.Append(')');
    return tmp50.ToString();
  }
}

