using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Generate an axis-aligned cuboid <see cref="Godot.PrimitiveMesh"/>.</para>
    /// <para>The cube's UV layout is arranged in a 3×2 layout that allows texturing each face individually. To apply the same texture on all faces, change the material's UV property to <c>Vector3(3, 2, 1)</c>.</para>
    /// <para>Note: When using a large textured <see cref="Godot.CubeMesh"/> (e.g. as a floor), you may stumble upon UV jittering issues depending on the camera angle. To solve this, increase <see cref="Godot.CubeMesh.SubdivideDepth"/>, <see cref="Godot.CubeMesh.SubdivideHeight"/> and <see cref="Godot.CubeMesh.SubdivideWidth"/> until you no longer notice UV jittering.</para>
    /// </summary>
    public partial class CubeMesh : PrimitiveMesh
    {
        /// <summary>
        /// <para>Size of the cuboid mesh.</para>
        /// </summary>
        public Vector3 Size
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
        /// <para>Number of extra edge loops inserted along the X axis.</para>
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
        /// <para>Number of extra edge loops inserted along the Y axis.</para>
        /// </summary>
        public int SubdivideHeight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSubdivideHeight();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSubdivideHeight(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Number of extra edge loops inserted along the Z axis.</para>
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

        private const string nativeName = "CubeMesh";

        public CubeMesh() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CubeMesh_Ctor(this);
        }

        internal CubeMesh(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_size");

        [GodotMethod("set_size")]
        [Obsolete("SetSize is deprecated. Use the Size property instead.")]
        public void SetSize(Vector3 size)
        {
            NativeCalls.godot_icall_1_148(method_bind_0, Object.GetPtr(this), ref size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_size");

        [GodotMethod("get_size")]
        [Obsolete("GetSize is deprecated. Use the Size property instead.")]
        public Vector3 GetSize()
        {
            NativeCalls.godot_icall_0_8(method_bind_1, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
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
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_subdivide_height");

        [GodotMethod("set_subdivide_height")]
        [Obsolete("SetSubdivideHeight is deprecated. Use the SubdivideHeight property instead.")]
        public void SetSubdivideHeight(int divisions)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), divisions);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_subdivide_height");

        [GodotMethod("get_subdivide_height")]
        [Obsolete("GetSubdivideHeight is deprecated. Use the SubdivideHeight property instead.")]
        public int GetSubdivideHeight()
        {
            return NativeCalls.godot_icall_0_5(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_subdivide_depth");

        [GodotMethod("set_subdivide_depth")]
        [Obsolete("SetSubdivideDepth is deprecated. Use the SubdivideDepth property instead.")]
        public void SetSubdivideDepth(int divisions)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), divisions);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_subdivide_depth");

        [GodotMethod("get_subdivide_depth")]
        [Obsolete("GetSubdivideDepth is deprecated. Use the SubdivideDepth property instead.")]
        public int GetSubdivideDepth()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
