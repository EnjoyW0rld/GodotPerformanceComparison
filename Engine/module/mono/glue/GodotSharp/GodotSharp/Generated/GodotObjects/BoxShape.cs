using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>3D box shape that can be a child of a <see cref="Godot.PhysicsBody"/> or <see cref="Godot.Area"/>.</para>
    /// </summary>
    public partial class BoxShape : Shape
    {
        /// <summary>
        /// <para>The box's half extents. The width, height and depth of this shape is twice the half extents.</para>
        /// </summary>
        public Vector3 Extents
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

        private const string nativeName = "BoxShape";

        public BoxShape() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_BoxShape_Ctor(this);
        }

        internal BoxShape(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_extents");

        [GodotMethod("set_extents")]
        [Obsolete("SetExtents is deprecated. Use the Extents property instead.")]
        public void SetExtents(Vector3 extents)
        {
            NativeCalls.godot_icall_1_148(method_bind_0, Object.GetPtr(this), ref extents);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_extents");

        [GodotMethod("get_extents")]
        [Obsolete("GetExtents is deprecated. Use the Extents property instead.")]
        public Vector3 GetExtents()
        {
            NativeCalls.godot_icall_0_8(method_bind_1, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
