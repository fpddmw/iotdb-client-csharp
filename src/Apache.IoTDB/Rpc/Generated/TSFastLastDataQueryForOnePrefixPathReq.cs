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


public partial class TSFastLastDataQueryForOnePrefixPathReq : TBase
{
  private int _fetchSize;
  private bool _enableRedirectQuery;
  private bool _jdbcQuery;
  private long _timeout;

  public long SessionId { get; set; }

  public List<string> Prefixes { get; set; }

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

  public long StatementId { get; set; }

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


  public Isset __isset;
  public struct Isset
  {
    public bool fetchSize;
    public bool enableRedirectQuery;
    public bool jdbcQuery;
    public bool timeout;
  }

  public TSFastLastDataQueryForOnePrefixPathReq()
  {
  }

  public TSFastLastDataQueryForOnePrefixPathReq(long sessionId, List<string> prefixes, long statementId) : this()
  {
    this.SessionId = sessionId;
    this.Prefixes = prefixes;
    this.StatementId = statementId;
  }

  public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      bool isset_sessionId = false;
      bool isset_prefixes = false;
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
            if (field.Type == TType.List)
            {
              {
                TList _list404 = await iprot.ReadListBeginAsync(cancellationToken);
                Prefixes = new List<string>(_list404.Count);
                for(int _i405 = 0; _i405 < _list404.Count; ++_i405)
                {
                  string _elem406;
                  _elem406 = await iprot.ReadStringAsync(cancellationToken);
                  Prefixes.Add(_elem406);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
              isset_prefixes = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 3:
            if (field.Type == TType.I32)
            {
              FetchSize = await iprot.ReadI32Async(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 4:
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
          case 5:
            if (field.Type == TType.Bool)
            {
              EnableRedirectQuery = await iprot.ReadBoolAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 6:
            if (field.Type == TType.Bool)
            {
              JdbcQuery = await iprot.ReadBoolAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 7:
            if (field.Type == TType.I64)
            {
              Timeout = await iprot.ReadI64Async(cancellationToken);
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
      if (!isset_prefixes)
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
      var tmp407 = new TStruct("TSFastLastDataQueryForOnePrefixPathReq");
      await oprot.WriteStructBeginAsync(tmp407, cancellationToken);
      var tmp408 = new TField();
      tmp408.Name = "sessionId";
      tmp408.Type = TType.I64;
      tmp408.ID = 1;
      await oprot.WriteFieldBeginAsync(tmp408, cancellationToken);
      await oprot.WriteI64Async(SessionId, cancellationToken);
      await oprot.WriteFieldEndAsync(cancellationToken);
      if((Prefixes != null))
      {
        tmp408.Name = "prefixes";
        tmp408.Type = TType.List;
        tmp408.ID = 2;
        await oprot.WriteFieldBeginAsync(tmp408, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.String, Prefixes.Count), cancellationToken);
          foreach (string _iter409 in Prefixes)
          {
            await oprot.WriteStringAsync(_iter409, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if(__isset.fetchSize)
      {
        tmp408.Name = "fetchSize";
        tmp408.Type = TType.I32;
        tmp408.ID = 3;
        await oprot.WriteFieldBeginAsync(tmp408, cancellationToken);
        await oprot.WriteI32Async(FetchSize, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      tmp408.Name = "statementId";
      tmp408.Type = TType.I64;
      tmp408.ID = 4;
      await oprot.WriteFieldBeginAsync(tmp408, cancellationToken);
      await oprot.WriteI64Async(StatementId, cancellationToken);
      await oprot.WriteFieldEndAsync(cancellationToken);
      if(__isset.enableRedirectQuery)
      {
        tmp408.Name = "enableRedirectQuery";
        tmp408.Type = TType.Bool;
        tmp408.ID = 5;
        await oprot.WriteFieldBeginAsync(tmp408, cancellationToken);
        await oprot.WriteBoolAsync(EnableRedirectQuery, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if(__isset.jdbcQuery)
      {
        tmp408.Name = "jdbcQuery";
        tmp408.Type = TType.Bool;
        tmp408.ID = 6;
        await oprot.WriteFieldBeginAsync(tmp408, cancellationToken);
        await oprot.WriteBoolAsync(JdbcQuery, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if(__isset.timeout)
      {
        tmp408.Name = "timeout";
        tmp408.Type = TType.I64;
        tmp408.ID = 7;
        await oprot.WriteFieldBeginAsync(tmp408, cancellationToken);
        await oprot.WriteI64Async(Timeout, cancellationToken);
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
    if (!(that is TSFastLastDataQueryForOnePrefixPathReq other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return System.Object.Equals(SessionId, other.SessionId)
      && TCollections.Equals(Prefixes, other.Prefixes)
      && ((__isset.fetchSize == other.__isset.fetchSize) && ((!__isset.fetchSize) || (System.Object.Equals(FetchSize, other.FetchSize))))
      && System.Object.Equals(StatementId, other.StatementId)
      && ((__isset.enableRedirectQuery == other.__isset.enableRedirectQuery) && ((!__isset.enableRedirectQuery) || (System.Object.Equals(EnableRedirectQuery, other.EnableRedirectQuery))))
      && ((__isset.jdbcQuery == other.__isset.jdbcQuery) && ((!__isset.jdbcQuery) || (System.Object.Equals(JdbcQuery, other.JdbcQuery))))
      && ((__isset.timeout == other.__isset.timeout) && ((!__isset.timeout) || (System.Object.Equals(Timeout, other.Timeout))));
  }

  public override int GetHashCode() {
    int hashcode = 157;
    unchecked {
      hashcode = (hashcode * 397) + SessionId.GetHashCode();
      if((Prefixes != null))
      {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(Prefixes);
      }
      if(__isset.fetchSize)
      {
        hashcode = (hashcode * 397) + FetchSize.GetHashCode();
      }
      hashcode = (hashcode * 397) + StatementId.GetHashCode();
      if(__isset.enableRedirectQuery)
      {
        hashcode = (hashcode * 397) + EnableRedirectQuery.GetHashCode();
      }
      if(__isset.jdbcQuery)
      {
        hashcode = (hashcode * 397) + JdbcQuery.GetHashCode();
      }
      if(__isset.timeout)
      {
        hashcode = (hashcode * 397) + Timeout.GetHashCode();
      }
    }
    return hashcode;
  }

  public override string ToString()
  {
    var tmp410 = new StringBuilder("TSFastLastDataQueryForOnePrefixPathReq(");
    tmp410.Append(", SessionId: ");
    SessionId.ToString(tmp410);
    if((Prefixes != null))
    {
      tmp410.Append(", Prefixes: ");
      Prefixes.ToString(tmp410);
    }
    if(__isset.fetchSize)
    {
      tmp410.Append(", FetchSize: ");
      FetchSize.ToString(tmp410);
    }
    tmp410.Append(", StatementId: ");
    StatementId.ToString(tmp410);
    if(__isset.enableRedirectQuery)
    {
      tmp410.Append(", EnableRedirectQuery: ");
      EnableRedirectQuery.ToString(tmp410);
    }
    if(__isset.jdbcQuery)
    {
      tmp410.Append(", JdbcQuery: ");
      JdbcQuery.ToString(tmp410);
    }
    if(__isset.timeout)
    {
      tmp410.Append(", Timeout: ");
      Timeout.ToString(tmp410);
    }
    tmp410.Append(')');
    return tmp410.ToString();
  }
}

