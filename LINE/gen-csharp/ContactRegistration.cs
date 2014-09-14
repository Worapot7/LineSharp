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

namespace LineSharp.Datatypes
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class ContactRegistration : TBase
  {
    private Contact _contact;
    private string _luid;
    private ContactType _contactType;
    private string _contactKey;

    public Contact Contact
    {
      get
      {
        return _contact;
      }
      set
      {
        __isset.contact = true;
        this._contact = value;
      }
    }

    public string Luid
    {
      get
      {
        return _luid;
      }
      set
      {
        __isset.luid = true;
        this._luid = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="ContactType"/>
    /// </summary>
    public ContactType ContactType
    {
      get
      {
        return _contactType;
      }
      set
      {
        __isset.contactType = true;
        this._contactType = value;
      }
    }

    public string ContactKey
    {
      get
      {
        return _contactKey;
      }
      set
      {
        __isset.contactKey = true;
        this._contactKey = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool contact;
      public bool luid;
      public bool contactType;
      public bool contactKey;
    }

    public ContactRegistration() {
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
            if (field.Type == TType.Struct) {
              Contact = new Contact();
              Contact.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.String) {
              Luid = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.I32) {
              ContactType = (ContactType)iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.String) {
              ContactKey = iprot.ReadString();
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
      TStruct struc = new TStruct("ContactRegistration");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Contact != null && __isset.contact) {
        field.Name = "contact";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        Contact.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (Luid != null && __isset.luid) {
        field.Name = "luid";
        field.Type = TType.String;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Luid);
        oprot.WriteFieldEnd();
      }
      if (__isset.contactType) {
        field.Name = "contactType";
        field.Type = TType.I32;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)ContactType);
        oprot.WriteFieldEnd();
      }
      if (ContactKey != null && __isset.contactKey) {
        field.Name = "contactKey";
        field.Type = TType.String;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ContactKey);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ContactRegistration(");
      sb.Append("Contact: ");
      sb.Append(Contact== null ? "<null>" : Contact.ToString());
      sb.Append(",Luid: ");
      sb.Append(Luid);
      sb.Append(",ContactType: ");
      sb.Append(ContactType);
      sb.Append(",ContactKey: ");
      sb.Append(ContactKey);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
