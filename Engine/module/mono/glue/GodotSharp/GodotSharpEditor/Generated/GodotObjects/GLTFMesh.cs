using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Note: This class is only compiled in editor builds. Run-time glTF loading and saving is not available in exported projects. References to <see cref="Godot.GLTFMesh"/> within a script will cause an error in an exported project.</para>
    /// </summary>
    public partial class GLTFMesh : Resource
    {
        public ArrayMesh Mesh
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMesh();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMesh(value);
            }
#pragma warning restore CS0618
        }

        public float[] BlendWeights
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendWeights();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendWeights(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array InstanceMaterials
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInstanceMaterials();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInstanceMaterials(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "GLTFMesh";

        public GLTFMesh() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_GLTFMesh_Ctor(this);
        }

        internal GLTFMesh(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mesh");

        [GodotMethod("get_mesh")]
        [Obsolete("GetMesh is deprecated. Use the Mesh property instead.")]
        public ArrayMesh GetMesh()
        {
            return NativeCalls.godot_icall_0_453(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mesh");

        [GodotMethod("set_mesh")]
        [Obsolete("SetMesh is deprecated. Use the Mesh property instead.")]
        public void SetMesh(ArrayMesh mesh)
        {
            NativeCalls.godot_icall_1_24(method_bind_1, Object.GetPtr(this), Object.GetPtr(mesh));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_blend_weights");

        [GodotMethod("get_blend_weights")]
        [Obsolete("GetBlendWeights is deprecated. Use the BlendWeights property instead.")]
        public float[] GetBlendWeights()
        {
            return NativeCalls.godot_icall_0_356(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_blend_weights");

        [GodotMethod("set_blend_weights")]
        [Obsolete("SetBlendWeights is deprecated. Use the BlendWeights property instead.")]
        public void SetBlendWeights(float[] blendWeights)
        {
            NativeCalls.godot_icall_1_452(method_bind_3, Object.GetPtr(this), blendWeights);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_instance_materials");

        [GodotMethod("get_instance_materials")]
        [Obsolete("GetInstanceMaterials is deprecated. Use the InstanceMaterials property instead.")]
        public Godot.Collections.Array GetInstanceMaterials()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_4, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_instance_materials");

        [GodotMethod("set_instance_materials")]
        [Obsolete("SetInstanceMaterials is deprecated. Use the InstanceMaterials property instead.")]
        public void SetInstanceMaterials(Godot.Collections.Array instanceMaterials)
        {
            NativeCalls.godot_icall_1_92(method_bind_5, Object.GetPtr(this), instanceMaterials.GetPtr());
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
