/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace LINE.Datatypes
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class SnsFriend : TBase
  {
    private string _snsUserId;
    private string _snsUserName;
    private SnsIdType _snsIdType;

    public string SnsUserId
    {
      get
      {
        return _snsUserId;
      }
      set
      {
        __isset.snsUserId = true;
        this._snsUserId = value;
      }
    }

    public string SnsUserName
    {
      get
      {
        return _snsUserName;
      }
      set
      {
        __isset.snsUserName = true;
        this._snsUserName = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="SnsIdType"/>
    /// </summary>
    public SnsIdType SnsIdType
    {
      get
      {
        return _snsIdType;
      }
      set
      {
        __isset.snsIdType = true;
        this._snsIdType = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool snsUserId;
      public bool snsUserName;
      public bool snsIdType;
    }

    public SnsFriend() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              SnsUserId = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              SnsUserName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              SnsIdType = (SnsIdType)iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("SnsFriend");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (SnsUserId != null && __isset.snsUserId) {
        field.Name = "snsUserId";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(SnsUserId);
        oprot.WriteFieldEnd();
      }
      if (SnsUserName != null && __isset.snsUserName) {
        field.Name = "snsUserName";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(SnsUserName);
        oprot.WriteFieldEnd();
      }
      if (__isset.snsIdType) {
        field.Name = "snsIdType";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)SnsIdType);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SnsFriend(");
      sb.Append("SnsUserId: ");
      sb.Append(SnsUserId);
      sb.Append(",SnsUserName: ");
      sb.Append(SnsUserName);
      sb.Append(",SnsIdType: ");
      sb.Append(SnsIdType);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
