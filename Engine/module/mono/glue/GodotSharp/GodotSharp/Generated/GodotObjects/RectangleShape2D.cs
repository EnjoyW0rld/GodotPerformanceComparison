using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Rectangle shape for 2D collisions. This shape is useful for modeling box-like 2D objects.</para>
    /// </summary>
    public partial class RectangleShape2D : Shape2D
    {
        /// <summary>
        /// <para>The rectangle's half extents. The width and height of this shape is twice the half extents.</para>
        /// </summary>
        public Vector2 Extents
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetExtents();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExtents(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "RectangleShape2D";

        public RectangleShape2D() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_RectangleShape2D_Ctor(this);
        }

        internal RectangleShape2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_extents");

        [GodotMethod("set_extents")]
        [Obsolete("SetExtents is deprecated. Use the Extents property instead.")]
        public void SetExtents(Vector2 extents)
        {
            NativeCalls.godot_icall_1_57(method_bind_0, Object.GetPtr(this), ref extents);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_extents");

        [GodotMethod("get_extents")]
        [Obsolete("GetExtents is deprecated. Use the Extents property instead.")]
        public Vector2 GetExtents()
        {
            NativeCalls.godot_icall_0_18(method_bind_1, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
