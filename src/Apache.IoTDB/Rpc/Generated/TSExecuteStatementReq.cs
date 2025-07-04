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


public partial class TSExecuteStatementReq : TBase
{
  private int _fetchSize;
  private long _timeout;
  private bool _enableRedirectQuery;
  private bool _jdbcQuery;

  public long SessionId { get; set; }

  public string Statement { get; set; }

  public long StatementId { get; set; }

  public int FetchSize
  {
    get
    {
      return _fetchSize;
    }
    set
    {
      __isset.fetchSize = true;
      this._fetchSize = value;
    }
  }

  public long Timeout
  {
    get
    {
      return _timeout;
    }
    set
    {
      __isset.timeout = true;
      this._timeout = value;
    }
  }

  public bool EnableRedirectQuery
  {
    get
    {
      return _enableRedirectQuery;
    }
    set
    {
      __isset.enableRedirectQuery = true;
      this._enableRedirectQuery = value;
    }
  }

  public bool JdbcQuery
  {
    get
    {
      return _jdbcQuery;
    }
    set
    {
      __isset.jdbcQuery = true;
      this._jdbcQuery = value;
    }
  }


  public Isset __isset;
  public struct Isset
  {
    public bool fetchSize;
    public bool timeout;
    public bool enableRedirectQuery;
    public bool jdbcQuery;
  }

  public TSExecuteStatementReq()
  {
  }

  public TSExecuteStatementReq(long sessionId, string statement, long statementId) : this()
  {
    this.SessionId = sessionId;
    this.Statement = statement;
    this.StatementId = statementId;
  }

  public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      bool isset_sessionId = false;
      bool isset_statement = false;
      bool isset_statementId = false;
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
              Statement = await iprot.ReadStringAsync(cancellationToken);
              isset_statement = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 3:
            if (field.Type == TType.I64)
            {
              StatementId = await iprot.ReadI64Async(cancellationToken);
              isset_statementId = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 4:
            if (field.Type == TType.I32)
            {
              FetchSize = await iprot.ReadI32Async(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 5:
            if (field.Type == TType.I64)
            {
              Timeout = await iprot.ReadI64Async(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 6:
            if (field.Type == TType.Bool)
            {
              EnableRedirectQuery = await iprot.ReadBoolAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 7:
            if (field.Type == TType.Bool)
            {
              JdbcQuery = await iprot.ReadBoolAsync(cancellationToken);
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
      if (!isset_statement)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      if (!isset_statementId)
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
      var tmp91 = new TStruct("TSExecuteStatementReq");
      await oprot.WriteStructBeginAsync(tmp91, cancellationToken);
      var tmp92 = new TField();
      tmp92.Name = "sessionId";
      tmp92.Type = TType.I64;
      tmp92.ID = 1;
      await oprot.WriteFieldBeginAsync(tmp92, cancellationToken);
      await oprot.WriteI64Async(SessionId, cancellationToken);
      await oprot.WriteFieldEndAsync(cancellationToken);
      if((Statement != null))
      {
        tmp92.Name = "statement";
        tmp92.Type = TType.String;
        tmp92.ID = 2;
        await oprot.WriteFieldBeginAsync(tmp92, cancellationToken);
        await oprot.WriteStringAsync(Statement, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      tmp92.Name = "statementId";
      tmp92.Type = TType.I64;
      tmp92.ID = 3;
      await oprot.WriteFieldBeginAsync(tmp92, cancellationToken);
      await oprot.WriteI64Async(StatementId, cancellationToken);
      await oprot.WriteFieldEndAsync(cancellationToken);
      if(__isset.fetchSize)
      {
        tmp92.Name = "fetchSize";
        tmp92.Type = TType.I32;
        tmp92.ID = 4;
        await oprot.WriteFieldBeginAsync(tmp92, cancellationToken);
        await oprot.WriteI32Async(FetchSize, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if(__isset.timeout)
      {
        tmp92.Name = "timeout";
        tmp92.Type = TType.I64;
        tmp92.ID = 5;
        await oprot.WriteFieldBeginAsync(tmp92, cancellationToken);
        await oprot.WriteI64Async(Timeout, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if(__isset.enableRedirectQuery)
      {
        tmp92.Name = "enableRedirectQuery";
        tmp92.Type = TType.Bool;
        tmp92.ID = 6;
        await oprot.WriteFieldBeginAsync(tmp92, cancellationToken);
        await oprot.WriteBoolAsync(EnableRedirectQuery, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if(__isset.jdbcQuery)
      {
        tmp92.Name = "jdbcQuery";
        tmp92.Type = TType.Bool;
        tmp92.ID = 7;
        await oprot.WriteFieldBeginAsync(tmp92, cancellationToken);
        await oprot.WriteBoolAsync(JdbcQuery, cancellationToken);
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
    if (!(that is TSExecuteStatementReq other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return System.Object.Equals(SessionId, other.SessionId)
      && System.Object.Equals(Statement, other.Statement)
      && System.Object.Equals(StatementId, other.StatementId)
      && ((__isset.fetchSize == other.__isset.fetchSize) && ((!__isset.fetchSize) || (System.Object.Equals(FetchSize, other.FetchSize))))
      && ((__isset.timeout == other.__isset.timeout) && ((!__isset.timeout) || (System.Object.Equals(Timeout, other.Timeout))))
      && ((__isset.enableRedirectQuery == other.__isset.enableRedirectQuery) && ((!__isset.enableRedirectQuery) || (System.Object.Equals(EnableRedirectQuery, other.EnableRedirectQuery))))
      && ((__isset.jdbcQuery == other.__isset.jdbcQuery) && ((!__isset.jdbcQuery) || (System.Object.Equals(JdbcQuery, other.JdbcQuery))));
  }

  public override int GetHashCode() {
    int hashcode = 157;
    unchecked {
      hashcode = (hashcode * 397) + SessionId.GetHashCode();
      if((Statement != null))
      {
        hashcode = (hashcode * 397) + Statement.GetHashCode();
      }
      hashcode = (hashcode * 397) + StatementId.GetHashCode();
      if(__isset.fetchSize)
      {
        hashcode = (hashcode * 397) + FetchSize.GetHashCode();
      }
      if(__isset.timeout)
      {
        hashcode = (hashcode * 397) + Timeout.GetHashCode();
      }
      if(__isset.enableRedirectQuery)
      {
        hashcode = (hashcode * 397) + EnableRedirectQuery.GetHashCode();
      }
      if(__isset.jdbcQuery)
      {
        hashcode = (hashcode * 397) + JdbcQuery.GetHashCode();
      }
    }
    return hashcode;
  }

  public override string ToString()
  {
    var tmp93 = new StringBuilder("TSExecuteStatementReq(");
    tmp93.Append(", SessionId: ");
    SessionId.ToString(tmp93);
    if((Statement != null))
    {
      tmp93.Append(", Statement: ");
      Statement.ToString(tmp93);
    }
    tmp93.Append(", StatementId: ");
    StatementId.ToString(tmp93);
    if(__isset.fetchSize)
    {
      tmp93.Append(", FetchSize: ");
      FetchSize.ToString(tmp93);
    }
    if(__isset.timeout)
    {
      tmp93.Append(", Timeout: ");
      Timeout.ToString(tmp93);
    }
    if(__isset.enableRedirectQuery)
    {
      tmp93.Append(", EnableRedirectQuery: ");
      EnableRedirectQuery.ToString(tmp93);
    }
    if(__isset.jdbcQuery)
    {
      tmp93.Append(", JdbcQuery: ");
      JdbcQuery.ToString(tmp93);
    }
    tmp93.Append(')');
    return tmp93.ToString();
  }
}

