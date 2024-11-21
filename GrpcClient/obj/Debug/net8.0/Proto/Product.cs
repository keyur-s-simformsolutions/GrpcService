// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/product.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcServer.Protos {

  /// <summary>Holder for reflection information generated from Proto/product.proto</summary>
  public static partial class ProductReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/product.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProductReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNQcm90by9wcm9kdWN0LnByb3RvEgdwcm9kdWN0Ghtnb29nbGUvcHJvdG9i",
            "dWYvZW1wdHkucHJvdG8iagoOUHJvZHVjdFJlcXVlc3QSEQoJUHJvZHVjdElk",
            "GAEgASgFEhMKC1Byb2R1Y3ROYW1lGAIgASgJEhoKElByb2R1Y3REZXNjcmlw",
            "dGlvbhgDIAEoCRIUCgxQcm9kdWN0UHJpY2UYBCABKAEiawoPUHJvZHVjdFJl",
            "c3BvbnNlEhEKCVByb2R1Y3RJZBgBIAEoBRITCgtQcm9kdWN0TmFtZRgCIAEo",
            "CRIaChJQcm9kdWN0RGVzY3JpcHRpb24YAyABKAkSFAoMUHJvZHVjdFByaWNl",
            "GAQgASgBMs8BCgdQcm9kdWN0Ej8KCkdldFByb2R1Y3QSFy5wcm9kdWN0LlBy",
            "b2R1Y3RSZXF1ZXN0GhgucHJvZHVjdC5Qcm9kdWN0UmVzcG9uc2USPwoKQWRk",
            "UHJvZHVjdBIXLnByb2R1Y3QuUHJvZHVjdFJlcXVlc3QaGC5wcm9kdWN0LlBy",
            "b2R1Y3RSZXNwb25zZRJCCgxMaXN0UHJvZHVjdHMSFi5nb29nbGUucHJvdG9i",
            "dWYuRW1wdHkaGC5wcm9kdWN0LlByb2R1Y3RSZXNwb25zZTABQhSqAhFHcnBj",
            "U2VydmVyLlByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServer.Protos.ProductRequest), global::GrpcServer.Protos.ProductRequest.Parser, new[]{ "ProductId", "ProductName", "ProductDescription", "ProductPrice" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServer.Protos.ProductResponse), global::GrpcServer.Protos.ProductResponse.Parser, new[]{ "ProductId", "ProductName", "ProductDescription", "ProductPrice" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ProductRequest : pb::IMessage<ProductRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProductRequest> _parser = new pb::MessageParser<ProductRequest>(() => new ProductRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProductRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServer.Protos.ProductReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProductRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProductRequest(ProductRequest other) : this() {
      productId_ = other.productId_;
      productName_ = other.productName_;
      productDescription_ = other.productDescription_;
      productPrice_ = other.productPrice_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProductRequest Clone() {
      return new ProductRequest(this);
    }

    /// <summary>Field number for the "ProductId" field.</summary>
    public const int ProductIdFieldNumber = 1;
    private int productId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ProductId {
      get { return productId_; }
      set {
        productId_ = value;
      }
    }

    /// <summary>Field number for the "ProductName" field.</summary>
    public const int ProductNameFieldNumber = 2;
    private string productName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProductName {
      get { return productName_; }
      set {
        productName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ProductDescription" field.</summary>
    public const int ProductDescriptionFieldNumber = 3;
    private string productDescription_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProductDescription {
      get { return productDescription_; }
      set {
        productDescription_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ProductPrice" field.</summary>
    public const int ProductPriceFieldNumber = 4;
    private double productPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double ProductPrice {
      get { return productPrice_; }
      set {
        productPrice_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProductRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProductRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProductId != other.ProductId) return false;
      if (ProductName != other.ProductName) return false;
      if (ProductDescription != other.ProductDescription) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ProductPrice, other.ProductPrice)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ProductId != 0) hash ^= ProductId.GetHashCode();
      if (ProductName.Length != 0) hash ^= ProductName.GetHashCode();
      if (ProductDescription.Length != 0) hash ^= ProductDescription.GetHashCode();
      if (ProductPrice != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ProductPrice);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ProductId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ProductId);
      }
      if (ProductName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ProductName);
      }
      if (ProductDescription.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ProductDescription);
      }
      if (ProductPrice != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(ProductPrice);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ProductId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ProductId);
      }
      if (ProductName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ProductName);
      }
      if (ProductDescription.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ProductDescription);
      }
      if (ProductPrice != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(ProductPrice);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ProductId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ProductId);
      }
      if (ProductName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProductName);
      }
      if (ProductDescription.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProductDescription);
      }
      if (ProductPrice != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ProductRequest other) {
      if (other == null) {
        return;
      }
      if (other.ProductId != 0) {
        ProductId = other.ProductId;
      }
      if (other.ProductName.Length != 0) {
        ProductName = other.ProductName;
      }
      if (other.ProductDescription.Length != 0) {
        ProductDescription = other.ProductDescription;
      }
      if (other.ProductPrice != 0D) {
        ProductPrice = other.ProductPrice;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ProductId = input.ReadInt32();
            break;
          }
          case 18: {
            ProductName = input.ReadString();
            break;
          }
          case 26: {
            ProductDescription = input.ReadString();
            break;
          }
          case 33: {
            ProductPrice = input.ReadDouble();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            ProductId = input.ReadInt32();
            break;
          }
          case 18: {
            ProductName = input.ReadString();
            break;
          }
          case 26: {
            ProductDescription = input.ReadString();
            break;
          }
          case 33: {
            ProductPrice = input.ReadDouble();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ProductResponse : pb::IMessage<ProductResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProductResponse> _parser = new pb::MessageParser<ProductResponse>(() => new ProductResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProductResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServer.Protos.ProductReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProductResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProductResponse(ProductResponse other) : this() {
      productId_ = other.productId_;
      productName_ = other.productName_;
      productDescription_ = other.productDescription_;
      productPrice_ = other.productPrice_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProductResponse Clone() {
      return new ProductResponse(this);
    }

    /// <summary>Field number for the "ProductId" field.</summary>
    public const int ProductIdFieldNumber = 1;
    private int productId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ProductId {
      get { return productId_; }
      set {
        productId_ = value;
      }
    }

    /// <summary>Field number for the "ProductName" field.</summary>
    public const int ProductNameFieldNumber = 2;
    private string productName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProductName {
      get { return productName_; }
      set {
        productName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ProductDescription" field.</summary>
    public const int ProductDescriptionFieldNumber = 3;
    private string productDescription_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProductDescription {
      get { return productDescription_; }
      set {
        productDescription_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ProductPrice" field.</summary>
    public const int ProductPriceFieldNumber = 4;
    private double productPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double ProductPrice {
      get { return productPrice_; }
      set {
        productPrice_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProductResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProductResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProductId != other.ProductId) return false;
      if (ProductName != other.ProductName) return false;
      if (ProductDescription != other.ProductDescription) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ProductPrice, other.ProductPrice)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ProductId != 0) hash ^= ProductId.GetHashCode();
      if (ProductName.Length != 0) hash ^= ProductName.GetHashCode();
      if (ProductDescription.Length != 0) hash ^= ProductDescription.GetHashCode();
      if (ProductPrice != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ProductPrice);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ProductId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ProductId);
      }
      if (ProductName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ProductName);
      }
      if (ProductDescription.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ProductDescription);
      }
      if (ProductPrice != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(ProductPrice);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ProductId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ProductId);
      }
      if (ProductName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ProductName);
      }
      if (ProductDescription.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ProductDescription);
      }
      if (ProductPrice != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(ProductPrice);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ProductId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ProductId);
      }
      if (ProductName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProductName);
      }
      if (ProductDescription.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProductDescription);
      }
      if (ProductPrice != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ProductResponse other) {
      if (other == null) {
        return;
      }
      if (other.ProductId != 0) {
        ProductId = other.ProductId;
      }
      if (other.ProductName.Length != 0) {
        ProductName = other.ProductName;
      }
      if (other.ProductDescription.Length != 0) {
        ProductDescription = other.ProductDescription;
      }
      if (other.ProductPrice != 0D) {
        ProductPrice = other.ProductPrice;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ProductId = input.ReadInt32();
            break;
          }
          case 18: {
            ProductName = input.ReadString();
            break;
          }
          case 26: {
            ProductDescription = input.ReadString();
            break;
          }
          case 33: {
            ProductPrice = input.ReadDouble();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            ProductId = input.ReadInt32();
            break;
          }
          case 18: {
            ProductName = input.ReadString();
            break;
          }
          case 26: {
            ProductDescription = input.ReadString();
            break;
          }
          case 33: {
            ProductPrice = input.ReadDouble();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
