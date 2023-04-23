using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Pin joint for 3D rigid bodies. It pins 2 bodies (rigid or static) together. See also <see cref="Godot.Generic6DOFJoint"/>.</para>
    /// </summary>
    public partial class PinJoint : Joint
    {
        public enum Param
        {
            /// <summary>
            /// <para>The force with which the pinned objects stay in positional relation to each other. The higher, the stronger.</para>
            /// </summary>
            Bias = 0,
            /// <summary>
            /// <para>The force with which the pinned objects stay in velocity relation to each other. The higher, the stronger.</para>
            /// </summary>
            Damping = 1,
            /// <summary>
            /// <para>If above 0, this value is the maximum value for an impulse that this Joint produces.</para>
            /// </summary>
            ImpulseClamp = 2
        }

        /// <summary>
        /// <para>The force with which the pinned objects stay in positional relation to each other. The higher, the stronger.</para>
        /// </summary>
        public float Params__bias
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((PinJoint.Param)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((PinJoint.Param)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The force with which the pinned objects stay in velocity relation to each other. The higher, the stronger.</para>
        /// </summary>
        public float Params__damping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((PinJoint.Param)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((PinJoint.Param)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If above 0, this value is the maximum value for an impulse that this Joint produces.</para>
        /// </summary>
        public float Params__impulseClamp
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((PinJoint.Param)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((PinJoint.Param)2, value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "PinJoint";

        public PinJoint() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PinJoint_Ctor(this);
        }

        internal PinJoint(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_param");

        /// <summary>
        /// <para>Sets the value of the specified parameter.</para>
        /// </summary>
        [GodotMethod("set_param")]
        [Obsolete("SetParam is deprecated. Use the Params__impulseClamp property instead.")]
        public void SetParam(PinJoint.Param param, float value)
        {
            NativeCalls.godot_icall_2_34(method_bind_0, Object.GetPtr(this), (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_param");

        /// <summary>
        /// <para>Returns the value of the specified parameter.</para>
        /// </summary>
        [GodotMethod("get_param")]
        [Obsolete("GetParam is deprecated. Use the Params__impulseClamp property instead.")]
        public float GetParam(PinJoint.Param param)
        {
            return NativeCalls.godot_icall_1_12(method_bind_1, Object.GetPtr(this), (int)param);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
