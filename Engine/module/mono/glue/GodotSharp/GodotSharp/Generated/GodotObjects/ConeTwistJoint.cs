using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The joint can rotate the bodies across an axis defined by the local x-axes of the <see cref="Godot.Joint"/>.</para>
    /// <para>The twist axis is initiated as the X axis of the <see cref="Godot.Joint"/>.</para>
    /// <para>Once the Bodies swing, the twist axis is calculated as the middle of the x-axes of the Joint in the local space of the two Bodies. See also <see cref="Godot.Generic6DOFJoint"/>.</para>
    /// </summary>
    public partial class ConeTwistJoint : Joint
    {
        public enum Param
        {
            /// <summary>
            /// <para>Swing is rotation from side to side, around the axis perpendicular to the twist axis.</para>
            /// <para>The swing span defines, how much rotation will not get corrected along the swing axis.</para>
            /// <para>Could be defined as looseness in the <see cref="Godot.ConeTwistJoint"/>.</para>
            /// <para>If below 0.05, this behavior is locked.</para>
            /// </summary>
            SwingSpan = 0,
            /// <summary>
            /// <para>Twist is the rotation around the twist axis, this value defined how far the joint can twist.</para>
            /// <para>Twist is locked if below 0.05.</para>
            /// </summary>
            TwistSpan = 1,
            /// <summary>
            /// <para>The speed with which the swing or twist will take place.</para>
            /// <para>The higher, the faster.</para>
            /// </summary>
            Bias = 2,
            /// <summary>
            /// <para>The ease with which the joint starts to twist. If it's too low, it takes more force to start twisting the joint.</para>
            /// </summary>
            Softness = 3,
            /// <summary>
            /// <para>Defines, how fast the swing- and twist-speed-difference on both sides gets synced.</para>
            /// </summary>
            Relaxation = 4,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.ConeTwistJoint.Param"/> enum.</para>
            /// </summary>
            Max = 5
        }

        /// <summary>
        /// <para>Swing is rotation from side to side, around the axis perpendicular to the twist axis.</para>
        /// <para>The swing span defines, how much rotation will not get corrected along the swing axis.</para>
        /// <para>Could be defined as looseness in the <see cref="Godot.ConeTwistJoint"/>.</para>
        /// <para>If below 0.05, this behavior is locked.</para>
        /// </summary>
        public float SwingSpan
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetSwingSpan();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetSwingSpan(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Twist is the rotation around the twist axis, this value defined how far the joint can twist.</para>
        /// <para>Twist is locked if below 0.05.</para>
        /// </summary>
        public float TwistSpan
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetTwistSpan();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetTwistSpan(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The speed with which the swing or twist will take place.</para>
        /// <para>The higher, the faster.</para>
        /// </summary>
        public float Bias
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((ConeTwistJoint.Param)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((ConeTwistJoint.Param)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The ease with which the joint starts to twist. If it's too low, it takes more force to start twisting the joint.</para>
        /// </summary>
        public float Softness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((ConeTwistJoint.Param)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((ConeTwistJoint.Param)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Defines, how fast the swing- and twist-speed-difference on both sides gets synced.</para>
        /// </summary>
        public float Relaxation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((ConeTwistJoint.Param)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((ConeTwistJoint.Param)4, value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ConeTwistJoint";

        public ConeTwistJoint() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ConeTwistJoint_Ctor(this);
        }

        internal ConeTwistJoint(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_param");

        [GodotMethod("set_param")]
        [Obsolete("SetParam is deprecated. Use the Relaxation property instead.")]
        public void SetParam(ConeTwistJoint.Param param, float value)
        {
            NativeCalls.godot_icall_2_34(method_bind_0, Object.GetPtr(this), (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_param");

        [GodotMethod("get_param")]
        [Obsolete("GetParam is deprecated. Use the Relaxation property instead.")]
        public float GetParam(ConeTwistJoint.Param param)
        {
            return NativeCalls.godot_icall_1_12(method_bind_1, Object.GetPtr(this), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_swing_span");

        [Obsolete("_SetSwingSpan is deprecated. Use the SwingSpan property instead.")]
        internal void _SetSwingSpan(float swingSpan)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), swingSpan);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_swing_span");

        [Obsolete("_GetSwingSpan is deprecated. Use the SwingSpan property instead.")]
        internal float _GetSwingSpan()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_twist_span");

        [Obsolete("_SetTwistSpan is deprecated. Use the TwistSpan property instead.")]
        internal void _SetTwistSpan(float twistSpan)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), twistSpan);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_twist_span");

        [Obsolete("_GetTwistSpan is deprecated. Use the TwistSpan property instead.")]
        internal float _GetTwistSpan()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
