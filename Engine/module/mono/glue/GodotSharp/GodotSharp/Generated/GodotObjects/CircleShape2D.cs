using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Circular shape for 2D collisions. This shape is useful for modeling balls or small characters and its collision detection with everything else is very fast.</para>
    /// </summary>
    public partial class CircleShape2D : Shape2D
    {
        /// <summary>
        /// <para>The circle's radius.</para>
        /// </summary>
        public float Radius
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRadius();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRadius(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "CircleShape2D";

        public CircleShape2D() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CircleShape2D_Ctor(this);
        }

        internal CircleShape2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_radius");

        [GodotMethod("set_radius")]
        [Obsolete("SetRadius is deprecated. Use the Radius property instead.")]
        public void SetRadius(float radius)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), radius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_radius");

        [GodotMethod("get_radius")]
        [Obsolete("GetRadius is deprecated. Use the Radius property instead.")]
        public float GetRadius()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
