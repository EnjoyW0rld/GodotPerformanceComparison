using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Class representing a planar <see cref="Godot.PrimitiveMesh"/>. This flat mesh does not have a thickness. By default, this mesh is aligned on the X and Z axes; this default rotation isn't suited for use with billboarded materials. For billboarded materials, use <see cref="Godot.QuadMesh"/> instead.</para>
    /// <para>Note: When using a large textured <see cref="Godot.PlaneMesh"/> (e.g. as a floor), you may stumble upon UV jittering issues depending on the camera angle. To solve this, increase <see cref="Godot.PlaneMesh.SubdivideDepth"/> and <see cref="Godot.PlaneMesh.SubdivideWidth"/> until you no longer notice UV jittering.</para>
    /// </summary>
    public partial class PlaneMesh : PrimitiveMesh
    {
        /// <summary>
        /// <para>Size of the generated plane.</para>
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
        /// <para>Number of subdivision along the X axis.</para>
        /// </summary>
        public int SubdivideWidth
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSubdivideWidth();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSubdivideWidth(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Number of subdivision along the Z axis.</para>
        /// </summary>
        public int SubdivideDepth
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSubdivideDepth();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSubdivideDepth(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Offset from the origin of the generated plane. Useful for particles.</para>
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

        private const string nativeName = "PlaneMesh";

        public PlaneMesh() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PlaneMesh_Ctor(this);
        }

        internal PlaneMesh(bool memoryOwn) : base(memoryOwn) {}

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
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_subdivide_width");

        [GodotMethod("set_subdivide_width")]
        [Obsolete("SetSubdivideWidth is deprecated. Use the SubdivideWidth property instead.")]
        public void SetSubdivideWidth(int subdivide)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), subdivide);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_subdivide_width");

        [GodotMethod("get_subdivide_width")]
        [Obsolete("GetSubdivideWidth is deprecated. Use the SubdivideWidth property instead.")]
        public int GetSubdivideWidth()
        {
            return NativeCalls.godot_icall_0_5(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_subdivide_depth");

        [GodotMethod("set_subdivide_depth")]
        [Obsolete("SetSubdivideDepth is deprecated. Use the SubdivideDepth property instead.")]
        public void SetSubdivideDepth(int subdivide)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), subdivide);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_subdivide_depth");

        [GodotMethod("get_subdivide_depth")]
        [Obsolete("GetSubdivideDepth is deprecated. Use the SubdivideDepth property instead.")]
        public int GetSubdivideDepth()
        {
            return NativeCalls.godot_icall_0_5(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_center_offset");

        [GodotMethod("set_center_offset")]
        [Obsolete("SetCenterOffset is deprecated. Use the CenterOffset property instead.")]
        public void SetCenterOffset(Vector3 offset)
        {
            NativeCalls.godot_icall_1_148(method_bind_6, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_center_offset");

        [GodotMethod("get_center_offset")]
        [Obsolete("GetCenterOffset is deprecated. Use the CenterOffset property instead.")]
        public Vector3 GetCenterOffset()
        {
            NativeCalls.godot_icall_0_8(method_bind_7, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
