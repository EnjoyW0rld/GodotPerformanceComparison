using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Class representing a prism-shaped <see cref="Godot.PrimitiveMesh"/>.</para>
    /// </summary>
    public partial class PrismMesh : PrimitiveMesh
    {
        /// <summary>
        /// <para>Displacement of the upper edge along the X axis. 0.0 positions edge straight above the bottom-left edge.</para>
        /// </summary>
        public float LeftToRight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLeftToRight();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLeftToRight(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Size of the prism.</para>
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
        /// <para>Number of added edge loops along the X axis.</para>
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
        /// <para>Number of added edge loops along the Y axis.</para>
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
        /// <para>Number of added edge loops along the Z axis.</para>
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

        private const string nativeName = "PrismMesh";

        public PrismMesh() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PrismMesh_Ctor(this);
        }

        internal PrismMesh(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_left_to_right");

        [GodotMethod("set_left_to_right")]
        [Obsolete("SetLeftToRight is deprecated. Use the LeftToRight property instead.")]
        public void SetLeftToRight(float leftToRight)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), leftToRight);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_left_to_right");

        [GodotMethod("get_left_to_right")]
        [Obsolete("GetLeftToRight is deprecated. Use the LeftToRight property instead.")]
        public float GetLeftToRight()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_size");

        [GodotMethod("set_size")]
        [Obsolete("SetSize is deprecated. Use the Size property instead.")]
        public void SetSize(Vector3 size)
        {
            NativeCalls.godot_icall_1_148(method_bind_2, Object.GetPtr(this), ref size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_size");

        [GodotMethod("get_size")]
        [Obsolete("GetSize is deprecated. Use the Size property instead.")]
        public Vector3 GetSize()
        {
            NativeCalls.godot_icall_0_8(method_bind_3, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_subdivide_width");

        [GodotMethod("set_subdivide_width")]
        [Obsolete("SetSubdivideWidth is deprecated. Use the SubdivideWidth property instead.")]
        public void SetSubdivideWidth(int segments)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), segments);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_subdivide_width");

        [GodotMethod("get_subdivide_width")]
        [Obsolete("GetSubdivideWidth is deprecated. Use the SubdivideWidth property instead.")]
        public int GetSubdivideWidth()
        {
            return NativeCalls.godot_icall_0_5(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_subdivide_height");

        [GodotMethod("set_subdivide_height")]
        [Obsolete("SetSubdivideHeight is deprecated. Use the SubdivideHeight property instead.")]
        public void SetSubdivideHeight(int segments)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), segments);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_subdivide_height");

        [GodotMethod("get_subdivide_height")]
        [Obsolete("GetSubdivideHeight is deprecated. Use the SubdivideHeight property instead.")]
        public int GetSubdivideHeight()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_subdivide_depth");

        [GodotMethod("set_subdivide_depth")]
        [Obsolete("SetSubdivideDepth is deprecated. Use the SubdivideDepth property instead.")]
        public void SetSubdivideDepth(int segments)
        {
            NativeCalls.godot_icall_1_4(method_bind_8, Object.GetPtr(this), segments);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_subdivide_depth");

        [GodotMethod("get_subdivide_depth")]
        [Obsolete("GetSubdivideDepth is deprecated. Use the SubdivideDepth property instead.")]
        public int GetSubdivideDepth()
        {
            return NativeCalls.godot_icall_0_5(method_bind_9, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
