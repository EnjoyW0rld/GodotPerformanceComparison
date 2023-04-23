using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Note: This class is only compiled in editor builds. Run-time glTF loading and saving is not available in exported projects. References to <see cref="Godot.PackedSceneGLTF"/> within a script will cause an error in an exported project.</para>
    /// </summary>
    public partial class PackedSceneGLTF : PackedScene
    {
        private const string nativeName = "PackedSceneGLTF";

        public PackedSceneGLTF() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PackedSceneGLTF_Ctor(this);
        }

        internal PackedSceneGLTF(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "export_gltf");

        [GodotMethod("export_gltf")]
        public Error ExportGltf(Node node, string path, int flags = 0, float bakeFps = 1000f)
        {
            return (Error)NativeCalls.godot_icall_4_713(method_bind_0, Object.GetPtr(this), Object.GetPtr(node), path, flags, bakeFps);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "pack_gltf");

        [GodotMethod("pack_gltf")]
        public void PackGltf(string path, int flags = 0, float bakeFps = 1000f, uint compressFlags = (uint)2194432, GLTFState state = null)
        {
            NativeCalls.godot_icall_5_714(method_bind_1, Object.GetPtr(this), path, flags, bakeFps, compressFlags, Object.GetPtr(state));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "import_gltf_scene");

        [GodotMethod("import_gltf_scene")]
        public Node ImportGltfScene(string path, uint flags = (uint)0, float bakeFps = 1000f, uint compressFlags = (uint)2194432, GLTFState state = null)
        {
            return NativeCalls.godot_icall_5_715(method_bind_2, Object.GetPtr(this), path, flags, bakeFps, compressFlags, Object.GetPtr(state));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
