// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: android/src/main/proto/camera_pose.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Braun.FaceCam {

  /// <summary>Holder for reflection information generated from android/src/main/proto/camera_pose.proto</summary>
  public static partial class CameraPoseReflection {

    #region Descriptor
    /// <summary>File descriptor for android/src/main/proto/camera_pose.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CameraPoseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihhbmRyb2lkL3NyYy9tYWluL3Byb3RvL2NhbWVyYV9wb3NlLnByb3RvEhFm",
            "eWkuYnJhdW4uZmFjZWNhbSKYAQoKQ2FtZXJhUG9zZRISCgpwb3NpdGlvbl94",
            "GAEgASgCEhIKCnBvc2l0aW9uX3kYAiABKAISEgoKcG9zaXRpb25fehgDIAEo",
            "AhISCgpyb3RhdGlvbl94GAQgASgCEhIKCnJvdGF0aW9uX3kYBSABKAISEgoK",
            "cm90YXRpb25fehgGIAEoAhISCgpyb3RhdGlvbl93GAcgASgCQhCqAg1CcmF1",
            "bi5GYWNlQ2FtYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Braun.FaceCam.CameraPose), global::Braun.FaceCam.CameraPose.Parser, new[]{ "PositionX", "PositionY", "PositionZ", "RotationX", "RotationY", "RotationZ", "RotationW" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CameraPose : pb::IMessage<CameraPose> {
    private static readonly pb::MessageParser<CameraPose> _parser = new pb::MessageParser<CameraPose>(() => new CameraPose());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CameraPose> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Braun.FaceCam.CameraPoseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CameraPose() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CameraPose(CameraPose other) : this() {
      positionX_ = other.positionX_;
      positionY_ = other.positionY_;
      positionZ_ = other.positionZ_;
      rotationX_ = other.rotationX_;
      rotationY_ = other.rotationY_;
      rotationZ_ = other.rotationZ_;
      rotationW_ = other.rotationW_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CameraPose Clone() {
      return new CameraPose(this);
    }

    /// <summary>Field number for the "position_x" field.</summary>
    public const int PositionXFieldNumber = 1;
    private float positionX_;
    /// <summary>
    /// Position vector.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float PositionX {
      get { return positionX_; }
      set {
        positionX_ = value;
      }
    }

    /// <summary>Field number for the "position_y" field.</summary>
    public const int PositionYFieldNumber = 2;
    private float positionY_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float PositionY {
      get { return positionY_; }
      set {
        positionY_ = value;
      }
    }

    /// <summary>Field number for the "position_z" field.</summary>
    public const int PositionZFieldNumber = 3;
    private float positionZ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float PositionZ {
      get { return positionZ_; }
      set {
        positionZ_ = value;
      }
    }

    /// <summary>Field number for the "rotation_x" field.</summary>
    public const int RotationXFieldNumber = 4;
    private float rotationX_;
    /// <summary>
    /// Rotation quaternion.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float RotationX {
      get { return rotationX_; }
      set {
        rotationX_ = value;
      }
    }

    /// <summary>Field number for the "rotation_y" field.</summary>
    public const int RotationYFieldNumber = 5;
    private float rotationY_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float RotationY {
      get { return rotationY_; }
      set {
        rotationY_ = value;
      }
    }

    /// <summary>Field number for the "rotation_z" field.</summary>
    public const int RotationZFieldNumber = 6;
    private float rotationZ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float RotationZ {
      get { return rotationZ_; }
      set {
        rotationZ_ = value;
      }
    }

    /// <summary>Field number for the "rotation_w" field.</summary>
    public const int RotationWFieldNumber = 7;
    private float rotationW_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float RotationW {
      get { return rotationW_; }
      set {
        rotationW_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CameraPose);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CameraPose other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PositionX, other.PositionX)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PositionY, other.PositionY)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PositionZ, other.PositionZ)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(RotationX, other.RotationX)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(RotationY, other.RotationY)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(RotationZ, other.RotationZ)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(RotationW, other.RotationW)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PositionX != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PositionX);
      if (PositionY != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PositionY);
      if (PositionZ != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PositionZ);
      if (RotationX != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(RotationX);
      if (RotationY != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(RotationY);
      if (RotationZ != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(RotationZ);
      if (RotationW != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(RotationW);
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
      if (PositionX != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(PositionX);
      }
      if (PositionY != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(PositionY);
      }
      if (PositionZ != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(PositionZ);
      }
      if (RotationX != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(RotationX);
      }
      if (RotationY != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(RotationY);
      }
      if (RotationZ != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(RotationZ);
      }
      if (RotationW != 0F) {
        output.WriteRawTag(61);
        output.WriteFloat(RotationW);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PositionX != 0F) {
        size += 1 + 4;
      }
      if (PositionY != 0F) {
        size += 1 + 4;
      }
      if (PositionZ != 0F) {
        size += 1 + 4;
      }
      if (RotationX != 0F) {
        size += 1 + 4;
      }
      if (RotationY != 0F) {
        size += 1 + 4;
      }
      if (RotationZ != 0F) {
        size += 1 + 4;
      }
      if (RotationW != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CameraPose other) {
      if (other == null) {
        return;
      }
      if (other.PositionX != 0F) {
        PositionX = other.PositionX;
      }
      if (other.PositionY != 0F) {
        PositionY = other.PositionY;
      }
      if (other.PositionZ != 0F) {
        PositionZ = other.PositionZ;
      }
      if (other.RotationX != 0F) {
        RotationX = other.RotationX;
      }
      if (other.RotationY != 0F) {
        RotationY = other.RotationY;
      }
      if (other.RotationZ != 0F) {
        RotationZ = other.RotationZ;
      }
      if (other.RotationW != 0F) {
        RotationW = other.RotationW;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 13: {
            PositionX = input.ReadFloat();
            break;
          }
          case 21: {
            PositionY = input.ReadFloat();
            break;
          }
          case 29: {
            PositionZ = input.ReadFloat();
            break;
          }
          case 37: {
            RotationX = input.ReadFloat();
            break;
          }
          case 45: {
            RotationY = input.ReadFloat();
            break;
          }
          case 53: {
            RotationZ = input.ReadFloat();
            break;
          }
          case 61: {
            RotationW = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
