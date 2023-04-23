using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Class representing a square <see cref="Godot.PrimitiveMesh"/>. This flat mesh does not have a thickness. By default, this mesh is aligned on the X and Y axes; this default rotation is more suited for use with billboarded materials. Unlike <see cref="Godot.PlaneMesh"/>, this mesh doesn't provide subdivision options.</para>
    /// </summary>
    public partial class QuadMesh : PrimitiveMesh
    {
        /// <summary>
        /// <para>Size on the X and Y axes.</para>
        /// </summary>
        public Vector2 Size
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Offset of the generated Quad. Useful for particles.</para>
        /// </summary>
        public Vector3 CenterOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCenterOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCenterOffset(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "QuadMesh";

        public QuadMesh() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_QuadMesh_Ctor(this);
        }

        internal QuadMesh(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_size");

        [GodotMethod("set_size")]
        [Obsolete("SetSize is deprecated. Use the Size property instead.")]
        public void SetSize(Vector2 size)
        {
            NativeCalls.godot_icall_1_57(method_bind_0, Object.GetPtr(this), ref size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_size");

        [GodotMethod("get_size")]
        [Obsolete("GetSize is deprecated. Use the Size property instead.")]
        public Vector2 GetSize()
        {
            NativeCalls.godot_icall_0_18(method_bind_1, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_center_offset");

        [GodotMethod("set_center_offset")]
        [Obsolete("SetCenterOffset is deprecated. Use the CenterOffset property instead.")]
        public void SetCenterOffset(Vector3 centerOffset)
        {
            NativeCalls.godot_icall_1_148(method_bind_2, Object.GetPtr(this), ref centerOffset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_center_offset");

        [GodotMethod("get_center_offset")]
        [Obsolete("GetCenterOffset is deprecated. Use the CenterOffset property instead.")]
        public Vector3 GetCenterOffset()
        {
            NativeCalls.godot_icall_0_8(method_bind_3, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
