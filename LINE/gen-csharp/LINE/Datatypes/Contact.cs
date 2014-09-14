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
  public partial class Contact : TBase
  {
    private string _mid;
    private long _createdTime;
    private ContactType _type;
    private ContactStatus _status;
    private ContactRelation _relation;
    private string _displayName;
    private string _phoneticName;
    private string _pictureStatus;
    private string _thumbnailUrl;
    private string _statusMessage;
    private string _displayNameOverridden;
    private long _favoriteTime;
    private bool _capableVoiceCall;
    private bool _capableVideoCall;
    private bool _capableMyhome;
    private bool _capableBuddy;
    private int _attributes;
    private long _settings;
    private string _picturePath;

    public string Mid
    {
      get
      {
        return _mid;
      }
      set
      {
        __isset.mid = true;
        this._mid = value;
      }
    }

    public long CreatedTime
    {
      get
      {
        return _createdTime;
      }
      set
      {
        __isset.createdTime = true;
        this._createdTime = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="ContactType"/>
    /// </summary>
    public ContactType Type
    {
      get
      {
        return _type;
      }
      set
      {
        __isset.type = true;
        this._type = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="ContactStatus"/>
    /// </summary>
    public ContactStatus Status
    {
      get
      {
        return _status;
      }
      set
      {
        __isset.status = true;
        this._status = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="ContactRelation"/>
    /// </summary>
    public ContactRelation Relation
    {
      get
      {
        return _relation;
      }
      set
      {
        __isset.relation = true;
        this._relation = value;
      }
    }

    public string DisplayName
    {
      get
      {
        return _displayName;
      }
      set
      {
        __isset.displayName = true;
        this._displayName = value;
      }
    }

    public string PhoneticName
    {
      get
      {
        return _phoneticName;
      }
      set
      {
        __isset.phoneticName = true;
        this._phoneticName = value;
      }
    }

    public string PictureStatus
    {
      get
      {
        return _pictureStatus;
      }
      set
      {
        __isset.pictureStatus = true;
        this._pictureStatus = value;
      }
    }

    public string ThumbnailUrl
    {
      get
      {
        return _thumbnailUrl;
      }
      set
      {
        __isset.thumbnailUrl = true;
        this._thumbnailUrl = value;
      }
    }

    public string StatusMessage
    {
      get
      {
        return _statusMessage;
      }
      set
      {
        __isset.statusMessage = true;
        this._statusMessage = value;
      }
    }

    public string DisplayNameOverridden
    {
      get
      {
        return _displayNameOverridden;
      }
      set
      {
        __isset.displayNameOverridden = true;
        this._displayNameOverridden = value;
      }
    }

    public long FavoriteTime
    {
      get
      {
        return _favoriteTime;
      }
      set
      {
        __isset.favoriteTime = true;
        this._favoriteTime = value;
      }
    }

    public bool CapableVoiceCall
    {
      get
      {
        return _capableVoiceCall;
      }
      set
      {
        __isset.capableVoiceCall = true;
        this._capableVoiceCall = value;
      }
    }

    public bool CapableVideoCall
    {
      get
      {
        return _capableVideoCall;
      }
      set
      {
        __isset.capableVideoCall = true;
        this._capableVideoCall = value;
      }
    }

    public bool CapableMyhome
    {
      get
      {
        return _capableMyhome;
      }
      set
      {
        __isset.capableMyhome = true;
        this._capableMyhome = value;
      }
    }

    public bool CapableBuddy
    {
      get
      {
        return _capableBuddy;
      }
      set
      {
        __isset.capableBuddy = true;
        this._capableBuddy = value;
      }
    }

    public int Attributes
    {
      get
      {
        return _attributes;
      }
      set
      {
        __isset.attributes = true;
        this._attributes = value;
      }
    }

    public long Settings
    {
      get
      {
        return _settings;
      }
      set
      {
        __isset.settings = true;
        this._settings = value;
      }
    }

    public string PicturePath
    {
      get
      {
        return _picturePath;
      }
      set
      {
        __isset.picturePath = true;
        this._picturePath = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool mid;
      public bool createdTime;
      public bool type;
      public bool status;
      public bool relation;
      public bool displayName;
      public bool phoneticName;
      public bool pictureStatus;
      public bool thumbnailUrl;
      public bool statusMessage;
      public bool displayNameOverridden;
      public bool favoriteTime;
      public bool capableVoiceCall;
      public bool capableVideoCall;
      public bool capableMyhome;
      public bool capableBuddy;
      public bool attributes;
      public bool settings;
      public bool picturePath;
    }

    public Contact() {
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
              Mid = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I64) {
              CreatedTime = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.I32) {
              Type = (ContactType)iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.I32) {
              Status = (ContactStatus)iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 21:
            if (field.Type == TType.I32) {
              Relation = (ContactRelation)iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 22:
            if (field.Type == TType.String) {
              DisplayName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 23:
            if (field.Type == TType.String) {
              PhoneticName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 24:
            if (field.Type == TType.String) {
              PictureStatus = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 25:
            if (field.Type == TType.String) {
              ThumbnailUrl = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 26:
            if (field.Type == TType.String) {
              StatusMessage = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 27:
            if (field.Type == TType.String) {
              DisplayNameOverridden = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 28:
            if (field.Type == TType.I64) {
              FavoriteTime = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 31:
            if (field.Type == TType.Bool) {
              CapableVoiceCall = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 32:
            if (field.Type == TType.Bool) {
              CapableVideoCall = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 33:
            if (field.Type == TType.Bool) {
              CapableMyhome = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 34:
            if (field.Type == TType.Bool) {
              CapableBuddy = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 35:
            if (field.Type == TType.I32) {
              Attributes = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 36:
            if (field.Type == TType.I64) {
              Settings = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 37:
            if (field.Type == TType.String) {
              PicturePath = iprot.ReadString();
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
      TStruct struc = new TStruct("Contact");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Mid != null && __isset.mid) {
        field.Name = "mid";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Mid);
        oprot.WriteFieldEnd();
      }
      if (__isset.createdTime) {
        field.Name = "createdTime";
        field.Type = TType.I64;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(CreatedTime);
        oprot.WriteFieldEnd();
      }
      if (__isset.type) {
        field.Name = "type";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)Type);
        oprot.WriteFieldEnd();
      }
      if (__isset.status) {
        field.Name = "status";
        field.Type = TType.I32;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)Status);
        oprot.WriteFieldEnd();
      }
      if (__isset.relation) {
        field.Name = "relation";
        field.Type = TType.I32;
        field.ID = 21;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)Relation);
        oprot.WriteFieldEnd();
      }
      if (DisplayName != null && __isset.displayName) {
        field.Name = "displayName";
        field.Type = TType.String;
        field.ID = 22;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(DisplayName);
        oprot.WriteFieldEnd();
      }
      if (PhoneticName != null && __isset.phoneticName) {
        field.Name = "phoneticName";
        field.Type = TType.String;
        field.ID = 23;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(PhoneticName);
        oprot.WriteFieldEnd();
      }
      if (PictureStatus != null && __isset.pictureStatus) {
        field.Name = "pictureStatus";
        field.Type = TType.String;
        field.ID = 24;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(PictureStatus);
        oprot.WriteFieldEnd();
      }
      if (ThumbnailUrl != null && __isset.thumbnailUrl) {
        field.Name = "thumbnailUrl";
        field.Type = TType.String;
        field.ID = 25;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ThumbnailUrl);
        oprot.WriteFieldEnd();
      }
      if (StatusMessage != null && __isset.statusMessage) {
        field.Name = "statusMessage";
        field.Type = TType.String;
        field.ID = 26;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(StatusMessage);
        oprot.WriteFieldEnd();
      }
      if (DisplayNameOverridden != null && __isset.displayNameOverridden) {
        field.Name = "displayNameOverridden";
        field.Type = TType.String;
        field.ID = 27;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(DisplayNameOverridden);
        oprot.WriteFieldEnd();
      }
      if (__isset.favoriteTime) {
        field.Name = "favoriteTime";
        field.Type = TType.I64;
        field.ID = 28;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(FavoriteTime);
        oprot.WriteFieldEnd();
      }
      if (__isset.capableVoiceCall) {
        field.Name = "capableVoiceCall";
        field.Type = TType.Bool;
        field.ID = 31;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(CapableVoiceCall);
        oprot.WriteFieldEnd();
      }
      if (__isset.capableVideoCall) {
        field.Name = "capableVideoCall";
        field.Type = TType.Bool;
        field.ID = 32;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(CapableVideoCall);
        oprot.WriteFieldEnd();
      }
      if (__isset.capableMyhome) {
        field.Name = "capableMyhome";
        field.Type = TType.Bool;
        field.ID = 33;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(CapableMyhome);
        oprot.WriteFieldEnd();
      }
      if (__isset.capableBuddy) {
        field.Name = "capableBuddy";
        field.Type = TType.Bool;
        field.ID = 34;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(CapableBuddy);
        oprot.WriteFieldEnd();
      }
      if (__isset.attributes) {
        field.Name = "attributes";
        field.Type = TType.I32;
        field.ID = 35;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Attributes);
        oprot.WriteFieldEnd();
      }
      if (__isset.settings) {
        field.Name = "settings";
        field.Type = TType.I64;
        field.ID = 36;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(Settings);
        oprot.WriteFieldEnd();
      }
      if (PicturePath != null && __isset.picturePath) {
        field.Name = "picturePath";
        field.Type = TType.String;
        field.ID = 37;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(PicturePath);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("Contact(");
      sb.Append("Mid: ");
      sb.Append(Mid);
      sb.Append(",CreatedTime: ");
      sb.Append(CreatedTime);
      sb.Append(",Type: ");
      sb.Append(Type);
      sb.Append(",Status: ");
      sb.Append(Status);
      sb.Append(",Relation: ");
      sb.Append(Relation);
      sb.Append(",DisplayName: ");
      sb.Append(DisplayName);
      sb.Append(",PhoneticName: ");
      sb.Append(PhoneticName);
      sb.Append(",PictureStatus: ");
      sb.Append(PictureStatus);
      sb.Append(",ThumbnailUrl: ");
      sb.Append(ThumbnailUrl);
      sb.Append(",StatusMessage: ");
      sb.Append(StatusMessage);
      sb.Append(",DisplayNameOverridden: ");
      sb.Append(DisplayNameOverridden);
      sb.Append(",FavoriteTime: ");
      sb.Append(FavoriteTime);
      sb.Append(",CapableVoiceCall: ");
      sb.Append(CapableVoiceCall);
      sb.Append(",CapableVideoCall: ");
      sb.Append(CapableVideoCall);
      sb.Append(",CapableMyhome: ");
      sb.Append(CapableMyhome);
      sb.Append(",CapableBuddy: ");
      sb.Append(CapableBuddy);
      sb.Append(",Attributes: ");
      sb.Append(Attributes);
      sb.Append(",Settings: ");
      sb.Append(Settings);
      sb.Append(",PicturePath: ");
      sb.Append(PicturePath);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
