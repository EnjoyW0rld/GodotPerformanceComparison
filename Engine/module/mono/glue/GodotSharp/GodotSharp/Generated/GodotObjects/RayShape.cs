using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Ray shape for 3D collisions, which can be set into a <see cref="Godot.PhysicsBody"/> or <see cref="Godot.Area"/>. A ray is not really a collision body; instead, it tries to separate itself from whatever is touching its far endpoint. It's often useful for characters.</para>
    /// </summary>
    public partial class RayShape : Shape
    {
        /// <summary>
        /// <para>The ray's length.</para>
        /// </summary>
        public float Length
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLength();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLength(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, allow the shape to return the correct normal.</para>
        /// </summary>
        public bool SlipsOnSlope
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSlipsOnSlope();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSlipsOnSlope(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "RayShape";

        public RayShape() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_RayShape_Ctor(this);
        }

        internal RayShape(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_length");

        [GodotMethod("set_length")]
        [Obsolete("SetLength is deprecated. Use the Length property instead.")]
        public void SetLength(float length)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), length);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_length");

        [GodotMethod("get_length")]
        [Obsolete("GetLength is deprecated. Use the Length property instead.")]
        public float GetLength()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_slips_on_slope");

        [GodotMethod("set_slips_on_slope")]
        [Obsolete("SetSlipsOnSlope is deprecated. Use the SlipsOnSlope property instead.")]
        public void SetSlipsOnSlope(bool active)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), active);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_slips_on_slope");

        [GodotMethod("get_slips_on_slope")]
        [Obsolete("GetSlipsOnSlope is deprecated. Use the SlipsOnSlope property instead.")]
        public bool GetSlipsOnSlope()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
