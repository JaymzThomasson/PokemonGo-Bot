// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Map/MapObjectsStatus.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Map {

  /// <summary>Holder for reflection information generated from POGOProtos/Map/MapObjectsStatus.proto</summary>
  public static partial class MapObjectsStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Map/MapObjectsStatus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MapObjectsStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVQT0dPUHJvdG9zL01hcC9NYXBPYmplY3RzU3RhdHVzLnByb3RvEg5QT0dP",
            "UHJvdG9zLk1hcCpFChBNYXBPYmplY3RzU3RhdHVzEhAKDFVOU0VUX1NUQVRV",
            "UxAAEgsKB1NVQ0NFU1MQARISCg5MT0NBVElPTl9VTlNFVBACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Map.MapObjectsStatus), }, null));
    }
    #endregion

  }
  #region Enums
  public enum MapObjectsStatus {
    [pbr::OriginalName("UNSET_STATUS")] UnsetStatus = 0,
    [pbr::OriginalName("SUCCESS")] Success = 1,
    [pbr::OriginalName("LOCATION_UNSET")] LocationUnset = 2,
  }

  #endregion

}

#endregion Designer generated code
