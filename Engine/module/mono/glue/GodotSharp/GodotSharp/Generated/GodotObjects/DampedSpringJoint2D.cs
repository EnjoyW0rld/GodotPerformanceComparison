using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Damped spring constraint for 2D physics. This resembles a spring joint that always wants to go back to a given length.</para>
    /// </summary>
    public partial class DampedSpringJoint2D : Joint2D
    {
        /// <summary>
        /// <para>The spring joint's maximum length. The two attached bodies cannot stretch it past this value.</para>
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
        /// <para>When the bodies attached to the spring joint move they stretch or squash it. The joint always tries to resize towards this length.</para>
        /// </summary>
        public float RestLength
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRestLength();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRestLength(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The higher the value, the less the bodies attached to the joint will deform it. The joint applies an opposing force to the bodies, the product of the stiffness multiplied by the size difference from its resting length.</para>
        /// </summary>
        public float Stiffness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetStiffness();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetStiffness(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The spring joint's damping ratio. A value between <c>0</c> and <c>1</c>. When the two bodies move into different directions the system tries to align them to the spring axis again. A high <c>damping</c> value forces the attached bodies to align faster.</para>
        /// </summary>
        public float Damping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDamping();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDamping(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "DampedSpringJoint2D";

        public DampedSpringJoint2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_DampedSpringJoint2D_Ctor(this);
        }

        internal DampedSpringJoint2D(bool memoryOwn) : base(memoryOwn) {}

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
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rest_length");

        [GodotMethod("set_rest_length")]
        [Obsolete("SetRestLength is deprecated. Use the RestLength property instead.")]
        public void SetRestLength(float restLength)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), restLength);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rest_length");

        [GodotMethod("get_rest_length")]
        [Obsolete("GetRestLength is deprecated. Use the RestLength property instead.")]
        public float GetRestLength()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_stiffness");

        [GodotMethod("set_stiffness")]
        [Obsolete("SetStiffness is deprecated. Use the Stiffness property instead.")]
        public void SetStiffness(float stiffness)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), stiffness);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stiffness");

        [GodotMethod("get_stiffness")]
        [Obsolete("GetStiffness is deprecated. Use the Stiffness property instead.")]
        public float GetStiffness()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_damping");

        [GodotMethod("set_damping")]
        [Obsolete("SetDamping is deprecated. Use the Damping property instead.")]
        public void SetDamping(float damping)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), damping);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_damping");

        [GodotMethod("get_damping")]
        [Obsolete("GetDamping is deprecated. Use the Damping property instead.")]
        public float GetDamping()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
