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


public partial class TSchemaNode : TBase
{

  public string NodeName { get; set; }

  public sbyte NodeType { get; set; }

  public TSchemaNode()
  {
  }

  public TSchemaNode(string nodeName, sbyte nodeType) : this()
  {
    this.NodeName = nodeName;
    this.NodeType = nodeType;
  }

  public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      bool isset_nodeName = false;
      bool isset_nodeType = false;
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
            if (field.Type == TType.String)
            {
              NodeName = await iprot.ReadStringAsync(cancellationToken);
              isset_nodeName = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 2:
            if (field.Type == TType.Byte)
            {
              NodeType = await iprot.ReadByteAsync(cancellationToken);
              isset_nodeType = true;
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
      if (!isset_nodeName)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      if (!isset_nodeType)
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
      var tmp76 = new TStruct("TSchemaNode");
      await oprot.WriteStructBeginAsync(tmp76, cancellationToken);
      var tmp77 = new TField();
      if((NodeName != null))
      {
        tmp77.Name = "nodeName";
        tmp77.Type = TType.String;
        tmp77.ID = 1;
        await oprot.WriteFieldBeginAsync(tmp77, cancellationToken);
        await oprot.WriteStringAsync(NodeName, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      tmp77.Name = "nodeType";
      tmp77.Type = TType.Byte;
      tmp77.ID = 2;
      await oprot.WriteFieldBeginAsync(tmp77, cancellationToken);
      await oprot.WriteByteAsync(NodeType, cancellationToken);
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
    if (!(that is TSchemaNode other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return System.Object.Equals(NodeName, other.NodeName)
      && System.Object.Equals(NodeType, other.NodeType);
  }

  public override int GetHashCode() {
    int hashcode = 157;
    unchecked {
      if((NodeName != null))
      {
        hashcode = (hashcode * 397) + NodeName.GetHashCode();
      }
      hashcode = (hashcode * 397) + NodeType.GetHashCode();
    }
    return hashcode;
  }

  public override string ToString()
  {
    var tmp78 = new StringBuilder("TSchemaNode(");
    if((NodeName != null))
    {
      tmp78.Append(", NodeName: ");
      NodeName.ToString(tmp78);
    }
    tmp78.Append(", NodeType: ");
    NodeType.ToString(tmp78);
    tmp78.Append(')');
    return tmp78.ToString();
  }
}

