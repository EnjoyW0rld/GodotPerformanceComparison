using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A HingeJoint normally uses the Z axis of body A as the hinge axis, another axis can be specified when adding it manually though. See also <see cref="Godot.Generic6DOFJoint"/>.</para>
    /// </summary>
    public partial class HingeJoint : Joint
    {
        public enum Param
        {
            /// <summary>
            /// <para>The speed with which the two bodies get pulled together when they move in different directions.</para>
            /// </summary>
            Bias = 0,
            /// <summary>
            /// <para>The maximum rotation. Only active if <see cref="Godot.HingeJoint.AngularLimit__enable"/> is <c>true</c>.</para>
            /// </summary>
            LimitUpper = 1,
            /// <summary>
            /// <para>The minimum rotation. Only active if <see cref="Godot.HingeJoint.AngularLimit__enable"/> is <c>true</c>.</para>
            /// </summary>
            LimitLower = 2,
            /// <summary>
            /// <para>The speed with which the rotation across the axis perpendicular to the hinge gets corrected.</para>
            /// </summary>
            LimitBias = 3,
            LimitSoftness = 4,
            /// <summary>
            /// <para>The lower this value, the more the rotation gets slowed down.</para>
            /// </summary>
            LimitRelaxation = 5,
            /// <summary>
            /// <para>Target speed for the motor.</para>
            /// </summary>
            MotorTargetVelocity = 6,
            /// <summary>
            /// <para>Maximum acceleration for the motor.</para>
            /// </summary>
            MotorMaxImpulse = 7,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.HingeJoint.Param"/> enum.</para>
            /// </summary>
            Max = 8
        }

        public enum Flag
        {
            /// <summary>
            /// <para>If <c>true</c>, the hinges maximum and minimum rotation, defined by <see cref="Godot.HingeJoint.AngularLimit__lower"/> and <see cref="Godot.HingeJoint.AngularLimit__upper"/> has effects.</para>
            /// </summary>
            UseLimit = 0,
            /// <summary>
            /// <para>When activated, a motor turns the hinge.</para>
            /// </summary>
            EnableMotor = 1,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.HingeJoint.Flag"/> enum.</para>
            /// </summary>
            Max = 2
        }

        /// <summary>
        /// <para>The speed with which the two bodies get pulled together when they move in different directions.</para>
        /// </summary>
        public float Params__bias
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((HingeJoint.Param)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((HingeJoint.Param)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the hinges maximum and minimum rotation, defined by <see cref="Godot.HingeJoint.AngularLimit__lower"/> and <see cref="Godot.HingeJoint.AngularLimit__upper"/> has effects.</para>
        /// </summary>
        public bool AngularLimit__enable
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((HingeJoint.Flag)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((HingeJoint.Flag)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum rotation. Only active if <see cref="Godot.HingeJoint.AngularLimit__enable"/> is <c>true</c>.</para>
        /// </summary>
        public float AngularLimit__upper
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetUpperLimit();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetUpperLimit(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The minimum rotation. Only active if <see cref="Godot.HingeJoint.AngularLimit__enable"/> is <c>true</c>.</para>
        /// </summary>
        public float AngularLimit__lower
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetLowerLimit();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetLowerLimit(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The speed with which the rotation across the axis perpendicular to the hinge gets corrected.</para>
        /// </summary>
        public float AngularLimit__bias
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((HingeJoint.Param)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((HingeJoint.Param)3, value);
            }
#pragma warning restore CS0618
        }

        public float AngularLimit__softness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((HingeJoint.Param)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((HingeJoint.Param)4, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The lower this value, the more the rotation gets slowed down.</para>
        /// </summary>
        public float AngularLimit__relaxation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((HingeJoint.Param)5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((HingeJoint.Param)5, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When activated, a motor turns the hinge.</para>
        /// </summary>
        public bool Motor__enable
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((HingeJoint.Flag)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((HingeJoint.Flag)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Target speed for the motor.</para>
        /// </summary>
        public float Motor__targetVelocity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((HingeJoint.Param)6);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((HingeJoint.Param)6, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Maximum acceleration for the motor.</para>
        /// </summary>
        public float Motor__maxImpulse
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((HingeJoint.Param)7);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((HingeJoint.Param)7, value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "HingeJoint";

        public HingeJoint() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_HingeJoint_Ctor(this);
        }

        internal HingeJoint(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_param");

        /// <summary>
        /// <para>Sets the value of the specified parameter.</para>
        /// </summary>
        [GodotMethod("set_param")]
        [Obsolete("SetParam is deprecated. Use the Motor__maxImpulse property instead.")]
        public void SetParam(HingeJoint.Param param, float value)
        {
            NativeCalls.godot_icall_2_34(method_bind_0, Object.GetPtr(this), (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_param");

        /// <summary>
        /// <para>Returns the value of the specified parameter.</para>
        /// </summary>
        [GodotMethod("get_param")]
        [Obsolete("GetParam is deprecated. Use the Motor__maxImpulse property instead.")]
        public float GetParam(HingeJoint.Param param)
        {
            return NativeCalls.godot_icall_1_12(method_bind_1, Object.GetPtr(this), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flag");

        /// <summary>
        /// <para>If <c>true</c>, enables the specified flag.</para>
        /// </summary>
        [GodotMethod("set_flag")]
        [Obsolete("SetFlag is deprecated. Use the Motor__enable property instead.")]
        public void SetFlag(HingeJoint.Flag flag, bool enabled)
        {
            NativeCalls.godot_icall_2_23(method_bind_2, Object.GetPtr(this), (int)flag, enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_flag");

        /// <summary>
        /// <para>Returns the value of the specified flag.</para>
        /// </summary>
        [GodotMethod("get_flag")]
        [Obsolete("GetFlag is deprecated. Use the Motor__enable property instead.")]
        public bool GetFlag(HingeJoint.Flag flag)
        {
            return NativeCalls.godot_icall_1_35(method_bind_3, Object.GetPtr(this), (int)flag);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_upper_limit");

        [Obsolete("_SetUpperLimit is deprecated. Use the AngularLimit__upper property instead.")]
        internal void _SetUpperLimit(float upperLimit)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), upperLimit);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_upper_limit");

        [Obsolete("_GetUpperLimit is deprecated. Use the AngularLimit__upper property instead.")]
        internal float _GetUpperLimit()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_lower_limit");

        [Obsolete("_SetLowerLimit is deprecated. Use the AngularLimit__lower property instead.")]
        internal void _SetLowerLimit(float lowerLimit)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), lowerLimit);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_lower_limit");

        [Obsolete("_GetLowerLimit is deprecated. Use the AngularLimit__lower property instead.")]
        internal float _GetLowerLimit()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
