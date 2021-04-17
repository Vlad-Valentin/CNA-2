// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/zodiac.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ZodiacService {

  /// <summary>Holder for reflection information generated from Protos/zodiac.proto</summary>
  public static partial class ZodiacReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/zodiac.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ZodiacReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNQcm90b3Mvem9kaWFjLnByb3RvEgZ6b2RpYWMaG2dvb2dsZS9wcm90b2J1",
            "Zi9lbXB0eS5wcm90bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90",
            "byIyChBBZGRab2RpYWNSZXF1ZXN0Eh4KBnpvZGlhYxgBIAEoCzIOLnpvZGlh",
            "Yy5ab2RpYWMidQoRQWRkWm9kaWFjUmVzcG9uc2USMAoGc3RhdHVzGAEgASgO",
            "MiAuem9kaWFjLkFkZFpvZGlhY1Jlc3BvbnNlLlN0YXR1cxIMCgRzaWduGAIg",
            "ASgJIiAKBlN0YXR1cxILCgdTVUNDRVNTEAASCQoFRVJST1IQASI4ChVHZXRB",
            "bGxab2RpYWNzUmVzcG9uc2USHwoHem9kaWFjcxgBIAMoCzIOLnpvZGlhYy5a",
            "b2RpYWMiFgoGWm9kaWFjEgwKBGRhdGUYASABKAkylQEKCUhvcm9zY29wZRJA",
            "CglBZGRab2RpYWMSGC56b2RpYWMuQWRkWm9kaWFjUmVxdWVzdBoZLnpvZGlh",
            "Yy5BZGRab2RpYWNSZXNwb25zZRJGCg1HZXRBbGxab2RpYWNzEhYuZ29vZ2xl",
            "LnByb3RvYnVmLkVtcHR5Gh0uem9kaWFjLkdldEFsbFpvZGlhY3NSZXNwb25z",
            "ZUIQqgINWm9kaWFjU2VydmljZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ZodiacService.AddZodiacRequest), global::ZodiacService.AddZodiacRequest.Parser, new[]{ "Zodiac" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ZodiacService.AddZodiacResponse), global::ZodiacService.AddZodiacResponse.Parser, new[]{ "Status", "Sign" }, null, new[]{ typeof(global::ZodiacService.AddZodiacResponse.Types.Status) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ZodiacService.GetAllZodiacsResponse), global::ZodiacService.GetAllZodiacsResponse.Parser, new[]{ "Zodiacs" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ZodiacService.Zodiac), global::ZodiacService.Zodiac.Parser, new[]{ "Date" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AddZodiacRequest : pb::IMessage<AddZodiacRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AddZodiacRequest> _parser = new pb::MessageParser<AddZodiacRequest>(() => new AddZodiacRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddZodiacRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ZodiacService.ZodiacReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddZodiacRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddZodiacRequest(AddZodiacRequest other) : this() {
      zodiac_ = other.zodiac_ != null ? other.zodiac_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddZodiacRequest Clone() {
      return new AddZodiacRequest(this);
    }

    /// <summary>Field number for the "zodiac" field.</summary>
    public const int ZodiacFieldNumber = 1;
    private global::ZodiacService.Zodiac zodiac_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ZodiacService.Zodiac Zodiac {
      get { return zodiac_; }
      set {
        zodiac_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddZodiacRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddZodiacRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Zodiac, other.Zodiac)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (zodiac_ != null) hash ^= Zodiac.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (zodiac_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Zodiac);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (zodiac_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Zodiac);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (zodiac_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Zodiac);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddZodiacRequest other) {
      if (other == null) {
        return;
      }
      if (other.zodiac_ != null) {
        if (zodiac_ == null) {
          Zodiac = new global::ZodiacService.Zodiac();
        }
        Zodiac.MergeFrom(other.Zodiac);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (zodiac_ == null) {
              Zodiac = new global::ZodiacService.Zodiac();
            }
            input.ReadMessage(Zodiac);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (zodiac_ == null) {
              Zodiac = new global::ZodiacService.Zodiac();
            }
            input.ReadMessage(Zodiac);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class AddZodiacResponse : pb::IMessage<AddZodiacResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AddZodiacResponse> _parser = new pb::MessageParser<AddZodiacResponse>(() => new AddZodiacResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddZodiacResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ZodiacService.ZodiacReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddZodiacResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddZodiacResponse(AddZodiacResponse other) : this() {
      status_ = other.status_;
      sign_ = other.sign_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddZodiacResponse Clone() {
      return new AddZodiacResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::ZodiacService.AddZodiacResponse.Types.Status status_ = global::ZodiacService.AddZodiacResponse.Types.Status.Success;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ZodiacService.AddZodiacResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "sign" field.</summary>
    public const int SignFieldNumber = 2;
    private string sign_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Sign {
      get { return sign_; }
      set {
        sign_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddZodiacResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddZodiacResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (Sign != other.Sign) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != global::ZodiacService.AddZodiacResponse.Types.Status.Success) hash ^= Status.GetHashCode();
      if (Sign.Length != 0) hash ^= Sign.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Status != global::ZodiacService.AddZodiacResponse.Types.Status.Success) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      if (Sign.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Sign);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Status != global::ZodiacService.AddZodiacResponse.Types.Status.Success) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      if (Sign.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Sign);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != global::ZodiacService.AddZodiacResponse.Types.Status.Success) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (Sign.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Sign);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddZodiacResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != global::ZodiacService.AddZodiacResponse.Types.Status.Success) {
        Status = other.Status;
      }
      if (other.Sign.Length != 0) {
        Sign = other.Sign;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Status = (global::ZodiacService.AddZodiacResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 18: {
            Sign = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Status = (global::ZodiacService.AddZodiacResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 18: {
            Sign = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the AddZodiacResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("SUCCESS")] Success = 0,
        [pbr::OriginalName("ERROR")] Error = 1,
      }

    }
    #endregion

  }

  public sealed partial class GetAllZodiacsResponse : pb::IMessage<GetAllZodiacsResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetAllZodiacsResponse> _parser = new pb::MessageParser<GetAllZodiacsResponse>(() => new GetAllZodiacsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetAllZodiacsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ZodiacService.ZodiacReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllZodiacsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllZodiacsResponse(GetAllZodiacsResponse other) : this() {
      zodiacs_ = other.zodiacs_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllZodiacsResponse Clone() {
      return new GetAllZodiacsResponse(this);
    }

    /// <summary>Field number for the "zodiacs" field.</summary>
    public const int ZodiacsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ZodiacService.Zodiac> _repeated_zodiacs_codec
        = pb::FieldCodec.ForMessage(10, global::ZodiacService.Zodiac.Parser);
    private readonly pbc::RepeatedField<global::ZodiacService.Zodiac> zodiacs_ = new pbc::RepeatedField<global::ZodiacService.Zodiac>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ZodiacService.Zodiac> Zodiacs {
      get { return zodiacs_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetAllZodiacsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetAllZodiacsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!zodiacs_.Equals(other.zodiacs_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= zodiacs_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      zodiacs_.WriteTo(output, _repeated_zodiacs_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      zodiacs_.WriteTo(ref output, _repeated_zodiacs_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += zodiacs_.CalculateSize(_repeated_zodiacs_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetAllZodiacsResponse other) {
      if (other == null) {
        return;
      }
      zodiacs_.Add(other.zodiacs_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            zodiacs_.AddEntriesFrom(input, _repeated_zodiacs_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            zodiacs_.AddEntriesFrom(ref input, _repeated_zodiacs_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class Zodiac : pb::IMessage<Zodiac>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Zodiac> _parser = new pb::MessageParser<Zodiac>(() => new Zodiac());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Zodiac> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ZodiacService.ZodiacReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Zodiac() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Zodiac(Zodiac other) : this() {
      date_ = other.date_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Zodiac Clone() {
      return new Zodiac(this);
    }

    /// <summary>Field number for the "date" field.</summary>
    public const int DateFieldNumber = 1;
    private string date_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Date {
      get { return date_; }
      set {
        date_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Zodiac);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Zodiac other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Date != other.Date) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Date.Length != 0) hash ^= Date.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Date.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Date);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Date.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Date);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Date.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Date);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Zodiac other) {
      if (other == null) {
        return;
      }
      if (other.Date.Length != 0) {
        Date = other.Date;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Date = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Date = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

      public object this[int index]
      {
          get { throw new System.NotImplementedException(); }
      }
  }

  #endregion

}

#endregion Designer generated code