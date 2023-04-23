using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Slides across the X axis of the pivot object. See also <see cref="Godot.Generic6DOFJoint"/>.</para>
    /// </summary>
    public partial class SliderJoint : Joint
    {
        public enum Param
        {
            /// <summary>
            /// <para>The maximum difference between the pivot points on their X axis before damping happens.</para>
            /// </summary>
            LinearLimitUpper = 0,
            /// <summary>
            /// <para>The minimum difference between the pivot points on their X axis before damping happens.</para>
            /// </summary>
            LinearLimitLower = 1,
            /// <summary>
            /// <para>A factor applied to the movement across the slider axis once the limits get surpassed. The lower, the slower the movement.</para>
            /// </summary>
            LinearLimitSoftness = 2,
            /// <summary>
            /// <para>The amount of restitution once the limits are surpassed. The lower, the more velocityenergy gets lost.</para>
            /// </summary>
            LinearLimitRestitution = 3,
            /// <summary>
            /// <para>The amount of damping once the slider limits are surpassed.</para>
            /// </summary>
            LinearLimitDamping = 4,
            /// <summary>
            /// <para>A factor applied to the movement across the slider axis as long as the slider is in the limits. The lower, the slower the movement.</para>
            /// </summary>
            LinearMotionSoftness = 5,
            /// <summary>
            /// <para>The amount of restitution inside the slider limits.</para>
            /// </summary>
            LinearMotionRestitution = 6,
            /// <summary>
            /// <para>The amount of damping inside the slider limits.</para>
            /// </summary>
            LinearMotionDamping = 7,
            /// <summary>
            /// <para>A factor applied to the movement across axes orthogonal to the slider.</para>
            /// </summary>
            LinearOrthogonalSoftness = 8,
            /// <summary>
            /// <para>The amount of restitution when movement is across axes orthogonal to the slider.</para>
            /// </summary>
            LinearOrthogonalRestitution = 9,
            /// <summary>
            /// <para>The amount of damping when movement is across axes orthogonal to the slider.</para>
            /// </summary>
            LinearOrthogonalDamping = 10,
            /// <summary>
            /// <para>The upper limit of rotation in the slider.</para>
            /// </summary>
            AngularLimitUpper = 11,
            /// <summary>
            /// <para>The lower limit of rotation in the slider.</para>
            /// </summary>
            AngularLimitLower = 12,
            /// <summary>
            /// <para>A factor applied to the all rotation once the limit is surpassed.</para>
            /// </summary>
            AngularLimitSoftness = 13,
            /// <summary>
            /// <para>The amount of restitution of the rotation when the limit is surpassed.</para>
            /// </summary>
            AngularLimitRestitution = 14,
            /// <summary>
            /// <para>The amount of damping of the rotation when the limit is surpassed.</para>
            /// </summary>
            AngularLimitDamping = 15,
            /// <summary>
            /// <para>A factor applied to the all rotation in the limits.</para>
            /// </summary>
            AngularMotionSoftness = 16,
            /// <summary>
            /// <para>The amount of restitution of the rotation in the limits.</para>
            /// </summary>
            AngularMotionRestitution = 17,
            /// <summary>
            /// <para>The amount of damping of the rotation in the limits.</para>
            /// </summary>
            AngularMotionDamping = 18,
            /// <summary>
            /// <para>A factor applied to the all rotation across axes orthogonal to the slider.</para>
            /// </summary>
            AngularOrthogonalSoftness = 19,
            /// <summary>
            /// <para>The amount of restitution of the rotation across axes orthogonal to the slider.</para>
            /// </summary>
            AngularOrthogonalRestitution = 20,
            /// <summary>
            /// <para>The amount of damping of the rotation across axes orthogonal to the slider.</para>
            /// </summary>
            AngularOrthogonalDamping = 21,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.SliderJoint.Param"/> enum.</para>
            /// </summary>
            Max = 22
        }

        /// <summary>
        /// <para>The maximum difference between the pivot points on their X axis before damping happens.</para>
        /// </summary>
        public float LinearLimit__upperDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((SliderJoint.Param)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((SliderJoint.Param)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The minimum difference between the pivot points on their X axis before damping happens.</para>
        /// </summary>
        public float LinearLimit__lowerDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((SliderJoint.Param)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((SliderJoint.Param)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A factor applied to the movement across the slider axis once the limits get surpassed. The lower, the slower the movement.</para>
        /// </summary>
        public float LinearLimit__softness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((SliderJoint.Param)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((SliderJoint.Param)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of restitution once the limits are surpassed. The lower, the more velocity-energy gets lost.</para>
        /// </summary>
        public float LinearLimit__restitution
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((SliderJoint.Param)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((SliderJoint.Param)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of damping that happens once the limit defined by <see cref="Godot.SliderJoint.LinearLimit__lowerDistance"/> and <see cref="Godot.SliderJoint.LinearLimit__upperDistance"/> is surpassed.</para>
        /// </summary>
        public float LinearLimit__damping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((SliderJoint.Param)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((SliderJoint.Param)4, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A factor applied to the movement across the slider axis as long as the slider is in the limits. The lower, the slower the movement.</para>
        /// </summary>
        public float LinearMotion__softness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((SliderJoint.Param)5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((SliderJoint.Param)5, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of restitution inside the slider limits.</para>
        /// </summary>
        public float LinearMotion__restitution
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((SliderJoint.Param)6);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((SliderJoint.Param)6, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of damping inside the slider limits.</para>
        /// </summary>
        public float LinearMotion__damping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((SliderJoint.Param)7);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((SliderJoint.Param)7, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A factor applied to the movement across axes orthogonal to the slider.</para>
        /// </summary>
        public float LinearOrtho__softness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((SliderJoint.Param)8);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((SliderJoint.Param)8, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of restitution when movement is across axes orthogonal to the slider.</para>
        /// </summary>
        public float LinearOrtho__restitution
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((SliderJoint.Param)9);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((SliderJoint.Param)9, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of damping when movement is across axes orthogonal to the slider.</para>
        /// </summary>
        public float LinearOrtho__damping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((SliderJoint.Param)10);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((SliderJoint.Param)10, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The upper limit of rotation in the slider.</para>
        /// </summary>
        public float AngularLimit__upperAngle
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetUpperLimitAngular();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetUpperLimitAngular(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The lower limit of rotation in the slider.</para>
        /// </summary>
        public float AngularLimit__lowerAngle
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetLowerLimitAngular();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetLowerLimitAngular(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A factor applied to the all rotation once the limit is surpassed.</para>
        /// <para>Makes all rotation slower when between 0 and 1.</para>
        /// </summary>
        public float AngularLimit__softness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((SliderJoint.Param)13);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((SliderJoint.Param)13, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of restitution of the rotation when the limit is surpassed.</para>
        /// <para>Does not affect damping.</para>
        /// </summary>
        public float AngularLimit__restitution
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((SliderJoint.Param)14);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((SliderJoint.Param)14, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of damping of the rotation when the limit is surpassed.</para>
        /// <para>A lower damping value allows a rotation initiated by body A to travel to body B slower.</para>
        /// </summary>
        public float AngularLimit__damping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((SliderJoint.Param)15);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((SliderJoint.Param)15, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A factor applied to the all rotation in the limits.</para>
        /// </summary>
        public float AngularMotion__softness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((SliderJoint.Param)16);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((SliderJoint.Param)16, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of restitution of the rotation in the limits.</para>
        /// </summary>
        public float AngularMotion__restitution
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((SliderJoint.Param)17);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((SliderJoint.Param)17, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of damping of the rotation in the limits.</para>
        /// </summary>
        public float AngularMotion__damping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((SliderJoint.Param)18);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((SliderJoint.Param)18, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A factor applied to the all rotation across axes orthogonal to the slider.</para>
        /// </summary>
        public float AngularOrtho__softness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((SliderJoint.Param)19);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((SliderJoint.Param)19, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of restitution of the rotation across axes orthogonal to the slider.</para>
        /// </summary>
        public float AngularOrtho__restitution
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((SliderJoint.Param)20);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((SliderJoint.Param)20, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of damping of the rotation across axes orthogonal to the slider.</para>
        /// </summary>
        public float AngularOrtho__damping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((SliderJoint.Param)21);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((SliderJoint.Param)21, value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "SliderJoint";

        public SliderJoint() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_SliderJoint_Ctor(this);
        }

        internal SliderJoint(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_param");

        [GodotMethod("set_param")]
        [Obsolete("SetParam is deprecated. Use the AngularOrtho__damping property instead.")]
        public void SetParam(SliderJoint.Param param, float value)
        {
            NativeCalls.godot_icall_2_34(method_bind_0, Object.GetPtr(this), (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_param");

        [GodotMethod("get_param")]
        [Obsolete("GetParam is deprecated. Use the AngularOrtho__damping property instead.")]
        public float GetParam(SliderJoint.Param param)
        {
            return NativeCalls.godot_icall_1_12(method_bind_1, Object.GetPtr(this), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_upper_limit_angular");

        [Obsolete("_SetUpperLimitAngular is deprecated. Use the AngularLimit__upperAngle property instead.")]
        internal void _SetUpperLimitAngular(float upperLimitAngular)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), upperLimitAngular);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_upper_limit_angular");

        [Obsolete("_GetUpperLimitAngular is deprecated. Use the AngularLimit__upperAngle property instead.")]
        internal float _GetUpperLimitAngular()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_lower_limit_angular");

        [Obsolete("_SetLowerLimitAngular is deprecated. Use the AngularLimit__lowerAngle property instead.")]
        internal void _SetLowerLimitAngular(float lowerLimitAngular)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), lowerLimitAngular);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_lower_limit_angular");

        [Obsolete("_GetLowerLimitAngular is deprecated. Use the AngularLimit__lowerAngle property instead.")]
        internal float _GetLowerLimitAngular()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
