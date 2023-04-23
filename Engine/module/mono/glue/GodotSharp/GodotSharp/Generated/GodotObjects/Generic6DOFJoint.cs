using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The first 3 DOF axes are linear axes, which represent translation of Bodies, and the latter 3 DOF axes represent the angular motion. Each axis can be either locked, or limited.</para>
    /// </summary>
    public partial class Generic6DOFJoint : Joint
    {
        public enum Param
        {
            /// <summary>
            /// <para>The minimum difference between the pivot points' axes.</para>
            /// </summary>
            LinearLowerLimit = 0,
            /// <summary>
            /// <para>The maximum difference between the pivot points' axes.</para>
            /// </summary>
            LinearUpperLimit = 1,
            /// <summary>
            /// <para>A factor applied to the movement across the axes. The lower, the slower the movement.</para>
            /// </summary>
            LinearLimitSoftness = 2,
            /// <summary>
            /// <para>The amount of restitution on the axes' movement. The lower, the more momentum gets lost.</para>
            /// </summary>
            LinearRestitution = 3,
            /// <summary>
            /// <para>The amount of damping that happens at the linear motion across the axes.</para>
            /// </summary>
            LinearDamping = 4,
            /// <summary>
            /// <para>The velocity the linear motor will try to reach.</para>
            /// </summary>
            LinearMotorTargetVelocity = 5,
            /// <summary>
            /// <para>The maximum force the linear motor will apply while trying to reach the velocity target.</para>
            /// </summary>
            LinearMotorForceLimit = 6,
            LinearSpringStiffness = 7,
            LinearSpringDamping = 8,
            LinearSpringEquilibriumPoint = 9,
            /// <summary>
            /// <para>The minimum rotation in negative direction to break loose and rotate around the axes.</para>
            /// </summary>
            AngularLowerLimit = 10,
            /// <summary>
            /// <para>The minimum rotation in positive direction to break loose and rotate around the axes.</para>
            /// </summary>
            AngularUpperLimit = 11,
            /// <summary>
            /// <para>The speed of all rotations across the axes.</para>
            /// </summary>
            AngularLimitSoftness = 12,
            /// <summary>
            /// <para>The amount of rotational damping across the axes. The lower, the more dampening occurs.</para>
            /// </summary>
            AngularDamping = 13,
            /// <summary>
            /// <para>The amount of rotational restitution across the axes. The lower, the more restitution occurs.</para>
            /// </summary>
            AngularRestitution = 14,
            /// <summary>
            /// <para>The maximum amount of force that can occur, when rotating around the axes.</para>
            /// </summary>
            AngularForceLimit = 15,
            /// <summary>
            /// <para>When rotating across the axes, this error tolerance factor defines how much the correction gets slowed down. The lower, the slower.</para>
            /// </summary>
            AngularErp = 16,
            /// <summary>
            /// <para>Target speed for the motor at the axes.</para>
            /// </summary>
            AngularMotorTargetVelocity = 17,
            /// <summary>
            /// <para>Maximum acceleration for the motor at the axes.</para>
            /// </summary>
            AngularMotorForceLimit = 18,
            AngularSpringStiffness = 19,
            AngularSpringDamping = 20,
            AngularSpringEquilibriumPoint = 21,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.Generic6DOFJoint.Param"/> enum.</para>
            /// </summary>
            Max = 22
        }

        public enum Flag
        {
            /// <summary>
            /// <para>If enabled, linear motion is possible within the given limits.</para>
            /// </summary>
            EnableLinearLimit = 0,
            /// <summary>
            /// <para>If enabled, rotational motion is possible within the given limits.</para>
            /// </summary>
            EnableAngularLimit = 1,
            EnableLinearSpring = 3,
            EnableAngularSpring = 2,
            /// <summary>
            /// <para>If enabled, there is a rotational motor across these axes.</para>
            /// </summary>
            EnableMotor = 4,
            /// <summary>
            /// <para>If enabled, there is a linear motor across these axes.</para>
            /// </summary>
            EnableLinearMotor = 5,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.Generic6DOFJoint.Flag"/> enum.</para>
            /// </summary>
            Max = 6
        }

        /// <summary>
        /// <para>If <c>true</c>, the linear motion across the X axis is limited.</para>
        /// </summary>
        public bool LinearLimitX__enabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlagX((Generic6DOFJoint.Flag)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlagX((Generic6DOFJoint.Flag)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum difference between the pivot points' X axis.</para>
        /// </summary>
        public float LinearLimitX__upperDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamX((Generic6DOFJoint.Param)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamX((Generic6DOFJoint.Param)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The minimum difference between the pivot points' X axis.</para>
        /// </summary>
        public float LinearLimitX__lowerDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamX((Generic6DOFJoint.Param)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamX((Generic6DOFJoint.Param)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A factor applied to the movement across the X axis. The lower, the slower the movement.</para>
        /// </summary>
        public float LinearLimitX__softness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamX((Generic6DOFJoint.Param)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamX((Generic6DOFJoint.Param)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of restitution on the X axis movement. The lower, the more momentum gets lost.</para>
        /// </summary>
        public float LinearLimitX__restitution
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamX((Generic6DOFJoint.Param)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamX((Generic6DOFJoint.Param)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of damping that happens at the X motion.</para>
        /// </summary>
        public float LinearLimitX__damping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamX((Generic6DOFJoint.Param)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamX((Generic6DOFJoint.Param)4, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, then there is a linear motor on the X axis. It will attempt to reach the target velocity while staying within the force limits.</para>
        /// </summary>
        public bool LinearMotorX__enabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlagX((Generic6DOFJoint.Flag)5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlagX((Generic6DOFJoint.Flag)5, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The speed that the linear motor will attempt to reach on the X axis.</para>
        /// </summary>
        public float LinearMotorX__targetVelocity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamX((Generic6DOFJoint.Param)5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamX((Generic6DOFJoint.Param)5, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum force the linear motor can apply on the X axis while trying to reach the target velocity.</para>
        /// </summary>
        public float LinearMotorX__forceLimit
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamX((Generic6DOFJoint.Param)6);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamX((Generic6DOFJoint.Param)6, value);
            }
#pragma warning restore CS0618
        }

        public bool LinearSpringX__enabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlagX((Generic6DOFJoint.Flag)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlagX((Generic6DOFJoint.Flag)3, value);
            }
#pragma warning restore CS0618
        }

        public float LinearSpringX__stiffness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamX((Generic6DOFJoint.Param)7);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamX((Generic6DOFJoint.Param)7, value);
            }
#pragma warning restore CS0618
        }

        public float LinearSpringX__damping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamX((Generic6DOFJoint.Param)8);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamX((Generic6DOFJoint.Param)8, value);
            }
#pragma warning restore CS0618
        }

        public float LinearSpringX__equilibriumPoint
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamX((Generic6DOFJoint.Param)9);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamX((Generic6DOFJoint.Param)9, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, rotation across the X axis is limited.</para>
        /// </summary>
        public bool AngularLimitX__enabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlagX((Generic6DOFJoint.Flag)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlagX((Generic6DOFJoint.Flag)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The minimum rotation in positive direction to break loose and rotate around the X axis.</para>
        /// </summary>
        public float AngularLimitX__upperAngle
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetAngularHiLimitX();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetAngularHiLimitX(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The minimum rotation in negative direction to break loose and rotate around the X axis.</para>
        /// </summary>
        public float AngularLimitX__lowerAngle
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetAngularLoLimitX();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetAngularLoLimitX(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The speed of all rotations across the X axis.</para>
        /// </summary>
        public float AngularLimitX__softness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamX((Generic6DOFJoint.Param)12);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamX((Generic6DOFJoint.Param)12, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of rotational restitution across the X axis. The lower, the more restitution occurs.</para>
        /// </summary>
        public float AngularLimitX__restitution
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamX((Generic6DOFJoint.Param)14);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamX((Generic6DOFJoint.Param)14, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of rotational damping across the X axis.</para>
        /// <para>The lower, the longer an impulse from one side takes to travel to the other side.</para>
        /// </summary>
        public float AngularLimitX__damping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamX((Generic6DOFJoint.Param)13);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamX((Generic6DOFJoint.Param)13, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum amount of force that can occur, when rotating around the X axis.</para>
        /// </summary>
        public float AngularLimitX__forceLimit
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamX((Generic6DOFJoint.Param)15);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamX((Generic6DOFJoint.Param)15, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When rotating across the X axis, this error tolerance factor defines how much the correction gets slowed down. The lower, the slower.</para>
        /// </summary>
        public float AngularLimitX__erp
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamX((Generic6DOFJoint.Param)16);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamX((Generic6DOFJoint.Param)16, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, a rotating motor at the X axis is enabled.</para>
        /// </summary>
        public bool AngularMotorX__enabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlagX((Generic6DOFJoint.Flag)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlagX((Generic6DOFJoint.Flag)4, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Target speed for the motor at the X axis.</para>
        /// </summary>
        public float AngularMotorX__targetVelocity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamX((Generic6DOFJoint.Param)17);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamX((Generic6DOFJoint.Param)17, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Maximum acceleration for the motor at the X axis.</para>
        /// </summary>
        public float AngularMotorX__forceLimit
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamX((Generic6DOFJoint.Param)18);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamX((Generic6DOFJoint.Param)18, value);
            }
#pragma warning restore CS0618
        }

        public bool AngularSpringX__enabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlagX((Generic6DOFJoint.Flag)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlagX((Generic6DOFJoint.Flag)2, value);
            }
#pragma warning restore CS0618
        }

        public float AngularSpringX__stiffness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamX((Generic6DOFJoint.Param)19);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamX((Generic6DOFJoint.Param)19, value);
            }
#pragma warning restore CS0618
        }

        public float AngularSpringX__damping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamX((Generic6DOFJoint.Param)20);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamX((Generic6DOFJoint.Param)20, value);
            }
#pragma warning restore CS0618
        }

        public float AngularSpringX__equilibriumPoint
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamX((Generic6DOFJoint.Param)21);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamX((Generic6DOFJoint.Param)21, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the linear motion across the Y axis is limited.</para>
        /// </summary>
        public bool LinearLimitY__enabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlagY((Generic6DOFJoint.Flag)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlagY((Generic6DOFJoint.Flag)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum difference between the pivot points' Y axis.</para>
        /// </summary>
        public float LinearLimitY__upperDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamY((Generic6DOFJoint.Param)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamY((Generic6DOFJoint.Param)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The minimum difference between the pivot points' Y axis.</para>
        /// </summary>
        public float LinearLimitY__lowerDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamY((Generic6DOFJoint.Param)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamY((Generic6DOFJoint.Param)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A factor applied to the movement across the Y axis. The lower, the slower the movement.</para>
        /// </summary>
        public float LinearLimitY__softness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamY((Generic6DOFJoint.Param)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamY((Generic6DOFJoint.Param)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of restitution on the Y axis movement. The lower, the more momentum gets lost.</para>
        /// </summary>
        public float LinearLimitY__restitution
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamY((Generic6DOFJoint.Param)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamY((Generic6DOFJoint.Param)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of damping that happens at the Y motion.</para>
        /// </summary>
        public float LinearLimitY__damping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamY((Generic6DOFJoint.Param)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamY((Generic6DOFJoint.Param)4, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, then there is a linear motor on the Y axis. It will attempt to reach the target velocity while staying within the force limits.</para>
        /// </summary>
        public bool LinearMotorY__enabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlagY((Generic6DOFJoint.Flag)5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlagY((Generic6DOFJoint.Flag)5, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The speed that the linear motor will attempt to reach on the Y axis.</para>
        /// </summary>
        public float LinearMotorY__targetVelocity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamY((Generic6DOFJoint.Param)5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamY((Generic6DOFJoint.Param)5, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum force the linear motor can apply on the Y axis while trying to reach the target velocity.</para>
        /// </summary>
        public float LinearMotorY__forceLimit
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamY((Generic6DOFJoint.Param)6);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamY((Generic6DOFJoint.Param)6, value);
            }
#pragma warning restore CS0618
        }

        public bool LinearSpringY__enabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlagY((Generic6DOFJoint.Flag)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlagY((Generic6DOFJoint.Flag)3, value);
            }
#pragma warning restore CS0618
        }

        public float LinearSpringY__stiffness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamY((Generic6DOFJoint.Param)7);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamY((Generic6DOFJoint.Param)7, value);
            }
#pragma warning restore CS0618
        }

        public float LinearSpringY__damping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamY((Generic6DOFJoint.Param)8);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamY((Generic6DOFJoint.Param)8, value);
            }
#pragma warning restore CS0618
        }

        public float LinearSpringY__equilibriumPoint
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamY((Generic6DOFJoint.Param)9);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamY((Generic6DOFJoint.Param)9, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, rotation across the Y axis is limited.</para>
        /// </summary>
        public bool AngularLimitY__enabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlagY((Generic6DOFJoint.Flag)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlagY((Generic6DOFJoint.Flag)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The minimum rotation in positive direction to break loose and rotate around the Y axis.</para>
        /// </summary>
        public float AngularLimitY__upperAngle
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetAngularHiLimitY();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetAngularHiLimitY(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The minimum rotation in negative direction to break loose and rotate around the Y axis.</para>
        /// </summary>
        public float AngularLimitY__lowerAngle
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetAngularLoLimitY();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetAngularLoLimitY(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The speed of all rotations across the Y axis.</para>
        /// </summary>
        public float AngularLimitY__softness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamY((Generic6DOFJoint.Param)12);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamY((Generic6DOFJoint.Param)12, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of rotational restitution across the Y axis. The lower, the more restitution occurs.</para>
        /// </summary>
        public float AngularLimitY__restitution
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamY((Generic6DOFJoint.Param)14);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamY((Generic6DOFJoint.Param)14, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of rotational damping across the Y axis. The lower, the more dampening occurs.</para>
        /// </summary>
        public float AngularLimitY__damping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamY((Generic6DOFJoint.Param)13);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamY((Generic6DOFJoint.Param)13, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum amount of force that can occur, when rotating around the Y axis.</para>
        /// </summary>
        public float AngularLimitY__forceLimit
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamY((Generic6DOFJoint.Param)15);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamY((Generic6DOFJoint.Param)15, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When rotating across the Y axis, this error tolerance factor defines how much the correction gets slowed down. The lower, the slower.</para>
        /// </summary>
        public float AngularLimitY__erp
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamY((Generic6DOFJoint.Param)16);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamY((Generic6DOFJoint.Param)16, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, a rotating motor at the Y axis is enabled.</para>
        /// </summary>
        public bool AngularMotorY__enabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlagY((Generic6DOFJoint.Flag)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlagY((Generic6DOFJoint.Flag)4, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Target speed for the motor at the Y axis.</para>
        /// </summary>
        public float AngularMotorY__targetVelocity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamY((Generic6DOFJoint.Param)17);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamY((Generic6DOFJoint.Param)17, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Maximum acceleration for the motor at the Y axis.</para>
        /// </summary>
        public float AngularMotorY__forceLimit
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamY((Generic6DOFJoint.Param)18);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamY((Generic6DOFJoint.Param)18, value);
            }
#pragma warning restore CS0618
        }

        public bool AngularSpringY__enabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlagY((Generic6DOFJoint.Flag)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlagY((Generic6DOFJoint.Flag)2, value);
            }
#pragma warning restore CS0618
        }

        public float AngularSpringY__stiffness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamY((Generic6DOFJoint.Param)19);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamY((Generic6DOFJoint.Param)19, value);
            }
#pragma warning restore CS0618
        }

        public float AngularSpringY__damping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamY((Generic6DOFJoint.Param)20);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamY((Generic6DOFJoint.Param)20, value);
            }
#pragma warning restore CS0618
        }

        public float AngularSpringY__equilibriumPoint
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamY((Generic6DOFJoint.Param)21);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamY((Generic6DOFJoint.Param)21, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the linear motion across the Z axis is limited.</para>
        /// </summary>
        public bool LinearLimitZ__enabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlagZ((Generic6DOFJoint.Flag)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlagZ((Generic6DOFJoint.Flag)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum difference between the pivot points' Z axis.</para>
        /// </summary>
        public float LinearLimitZ__upperDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamZ((Generic6DOFJoint.Param)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamZ((Generic6DOFJoint.Param)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The minimum difference between the pivot points' Z axis.</para>
        /// </summary>
        public float LinearLimitZ__lowerDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamZ((Generic6DOFJoint.Param)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamZ((Generic6DOFJoint.Param)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A factor applied to the movement across the Z axis. The lower, the slower the movement.</para>
        /// </summary>
        public float LinearLimitZ__softness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamZ((Generic6DOFJoint.Param)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamZ((Generic6DOFJoint.Param)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of restitution on the Z axis movement. The lower, the more momentum gets lost.</para>
        /// </summary>
        public float LinearLimitZ__restitution
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamZ((Generic6DOFJoint.Param)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamZ((Generic6DOFJoint.Param)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of damping that happens at the Z motion.</para>
        /// </summary>
        public float LinearLimitZ__damping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamZ((Generic6DOFJoint.Param)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamZ((Generic6DOFJoint.Param)4, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, then there is a linear motor on the Z axis. It will attempt to reach the target velocity while staying within the force limits.</para>
        /// </summary>
        public bool LinearMotorZ__enabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlagZ((Generic6DOFJoint.Flag)5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlagZ((Generic6DOFJoint.Flag)5, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The speed that the linear motor will attempt to reach on the Z axis.</para>
        /// </summary>
        public float LinearMotorZ__targetVelocity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamZ((Generic6DOFJoint.Param)5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamZ((Generic6DOFJoint.Param)5, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum force the linear motor can apply on the Z axis while trying to reach the target velocity.</para>
        /// </summary>
        public float LinearMotorZ__forceLimit
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamZ((Generic6DOFJoint.Param)6);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamZ((Generic6DOFJoint.Param)6, value);
            }
#pragma warning restore CS0618
        }

        public bool LinearSpringZ__enabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlagZ((Generic6DOFJoint.Flag)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlagZ((Generic6DOFJoint.Flag)3, value);
            }
#pragma warning restore CS0618
        }

        public float LinearSpringZ__stiffness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamZ((Generic6DOFJoint.Param)7);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamZ((Generic6DOFJoint.Param)7, value);
            }
#pragma warning restore CS0618
        }

        public float LinearSpringZ__damping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamZ((Generic6DOFJoint.Param)8);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamZ((Generic6DOFJoint.Param)8, value);
            }
#pragma warning restore CS0618
        }

        public float LinearSpringZ__equilibriumPoint
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamZ((Generic6DOFJoint.Param)9);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamZ((Generic6DOFJoint.Param)9, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, rotation across the Z axis is limited.</para>
        /// </summary>
        public bool AngularLimitZ__enabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlagZ((Generic6DOFJoint.Flag)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlagZ((Generic6DOFJoint.Flag)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The minimum rotation in positive direction to break loose and rotate around the Z axis.</para>
        /// </summary>
        public float AngularLimitZ__upperAngle
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetAngularHiLimitZ();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetAngularHiLimitZ(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The minimum rotation in negative direction to break loose and rotate around the Z axis.</para>
        /// </summary>
        public float AngularLimitZ__lowerAngle
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetAngularLoLimitZ();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetAngularLoLimitZ(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The speed of all rotations across the Z axis.</para>
        /// </summary>
        public float AngularLimitZ__softness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamZ((Generic6DOFJoint.Param)12);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamZ((Generic6DOFJoint.Param)12, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of rotational restitution across the Z axis. The lower, the more restitution occurs.</para>
        /// </summary>
        public float AngularLimitZ__restitution
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamZ((Generic6DOFJoint.Param)14);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamZ((Generic6DOFJoint.Param)14, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of rotational damping across the Z axis. The lower, the more dampening occurs.</para>
        /// </summary>
        public float AngularLimitZ__damping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamZ((Generic6DOFJoint.Param)13);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamZ((Generic6DOFJoint.Param)13, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum amount of force that can occur, when rotating around the Z axis.</para>
        /// </summary>
        public float AngularLimitZ__forceLimit
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamZ((Generic6DOFJoint.Param)15);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamZ((Generic6DOFJoint.Param)15, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When rotating across the Z axis, this error tolerance factor defines how much the correction gets slowed down. The lower, the slower.</para>
        /// </summary>
        public float AngularLimitZ__erp
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamZ((Generic6DOFJoint.Param)16);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamZ((Generic6DOFJoint.Param)16, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, a rotating motor at the Z axis is enabled.</para>
        /// </summary>
        public bool AngularMotorZ__enabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlagZ((Generic6DOFJoint.Flag)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlagZ((Generic6DOFJoint.Flag)4, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Target speed for the motor at the Z axis.</para>
        /// </summary>
        public float AngularMotorZ__targetVelocity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamZ((Generic6DOFJoint.Param)17);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamZ((Generic6DOFJoint.Param)17, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Maximum acceleration for the motor at the Z axis.</para>
        /// </summary>
        public float AngularMotorZ__forceLimit
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamZ((Generic6DOFJoint.Param)18);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamZ((Generic6DOFJoint.Param)18, value);
            }
#pragma warning restore CS0618
        }

        public bool AngularSpringZ__enabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlagZ((Generic6DOFJoint.Flag)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlagZ((Generic6DOFJoint.Flag)2, value);
            }
#pragma warning restore CS0618
        }

        public float AngularSpringZ__stiffness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamZ((Generic6DOFJoint.Param)19);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamZ((Generic6DOFJoint.Param)19, value);
            }
#pragma warning restore CS0618
        }

        public float AngularSpringZ__damping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamZ((Generic6DOFJoint.Param)20);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamZ((Generic6DOFJoint.Param)20, value);
            }
#pragma warning restore CS0618
        }

        public float AngularSpringZ__equilibriumPoint
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamZ((Generic6DOFJoint.Param)21);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamZ((Generic6DOFJoint.Param)21, value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Generic6DOFJoint";

        public Generic6DOFJoint() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Generic6DOFJoint_Ctor(this);
        }

        internal Generic6DOFJoint(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_angular_hi_limit_x");

        [Obsolete("_SetAngularHiLimitX is deprecated. Use the AngularLimitX__upperAngle property instead.")]
        internal void _SetAngularHiLimitX(float angle)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), angle);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_angular_hi_limit_x");

        [Obsolete("_GetAngularHiLimitX is deprecated. Use the AngularLimitX__upperAngle property instead.")]
        internal float _GetAngularHiLimitX()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_angular_lo_limit_x");

        [Obsolete("_SetAngularLoLimitX is deprecated. Use the AngularLimitX__lowerAngle property instead.")]
        internal void _SetAngularLoLimitX(float angle)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), angle);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_angular_lo_limit_x");

        [Obsolete("_GetAngularLoLimitX is deprecated. Use the AngularLimitX__lowerAngle property instead.")]
        internal float _GetAngularLoLimitX()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_angular_hi_limit_y");

        [Obsolete("_SetAngularHiLimitY is deprecated. Use the AngularLimitY__upperAngle property instead.")]
        internal void _SetAngularHiLimitY(float angle)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), angle);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_angular_hi_limit_y");

        [Obsolete("_GetAngularHiLimitY is deprecated. Use the AngularLimitY__upperAngle property instead.")]
        internal float _GetAngularHiLimitY()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_angular_lo_limit_y");

        [Obsolete("_SetAngularLoLimitY is deprecated. Use the AngularLimitY__lowerAngle property instead.")]
        internal void _SetAngularLoLimitY(float angle)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), angle);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_angular_lo_limit_y");

        [Obsolete("_GetAngularLoLimitY is deprecated. Use the AngularLimitY__lowerAngle property instead.")]
        internal float _GetAngularLoLimitY()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_angular_hi_limit_z");

        [Obsolete("_SetAngularHiLimitZ is deprecated. Use the AngularLimitZ__upperAngle property instead.")]
        internal void _SetAngularHiLimitZ(float angle)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), angle);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_angular_hi_limit_z");

        [Obsolete("_GetAngularHiLimitZ is deprecated. Use the AngularLimitZ__upperAngle property instead.")]
        internal float _GetAngularHiLimitZ()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_angular_lo_limit_z");

        [Obsolete("_SetAngularLoLimitZ is deprecated. Use the AngularLimitZ__lowerAngle property instead.")]
        internal void _SetAngularLoLimitZ(float angle)
        {
            NativeCalls.godot_icall_1_15(method_bind_10, Object.GetPtr(this), angle);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_angular_lo_limit_z");

        [Obsolete("_GetAngularLoLimitZ is deprecated. Use the AngularLimitZ__lowerAngle property instead.")]
        internal float _GetAngularLoLimitZ()
        {
            return NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_param_x");

        [GodotMethod("set_param_x")]
        [Obsolete("SetParamX is deprecated. Use the AngularSpringX__equilibriumPoint property instead.")]
        public void SetParamX(Generic6DOFJoint.Param param, float value)
        {
            NativeCalls.godot_icall_2_34(method_bind_12, Object.GetPtr(this), (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_param_x");

        [GodotMethod("get_param_x")]
        [Obsolete("GetParamX is deprecated. Use the AngularSpringX__equilibriumPoint property instead.")]
        public float GetParamX(Generic6DOFJoint.Param param)
        {
            return NativeCalls.godot_icall_1_12(method_bind_13, Object.GetPtr(this), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_param_y");

        [GodotMethod("set_param_y")]
        [Obsolete("SetParamY is deprecated. Use the AngularSpringY__equilibriumPoint property instead.")]
        public void SetParamY(Generic6DOFJoint.Param param, float value)
        {
            NativeCalls.godot_icall_2_34(method_bind_14, Object.GetPtr(this), (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_param_y");

        [GodotMethod("get_param_y")]
        [Obsolete("GetParamY is deprecated. Use the AngularSpringY__equilibriumPoint property instead.")]
        public float GetParamY(Generic6DOFJoint.Param param)
        {
            return NativeCalls.godot_icall_1_12(method_bind_15, Object.GetPtr(this), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_param_z");

        [GodotMethod("set_param_z")]
        [Obsolete("SetParamZ is deprecated. Use the AngularSpringZ__equilibriumPoint property instead.")]
        public void SetParamZ(Generic6DOFJoint.Param param, float value)
        {
            NativeCalls.godot_icall_2_34(method_bind_16, Object.GetPtr(this), (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_param_z");

        [GodotMethod("get_param_z")]
        [Obsolete("GetParamZ is deprecated. Use the AngularSpringZ__equilibriumPoint property instead.")]
        public float GetParamZ(Generic6DOFJoint.Param param)
        {
            return NativeCalls.godot_icall_1_12(method_bind_17, Object.GetPtr(this), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flag_x");

        [GodotMethod("set_flag_x")]
        [Obsolete("SetFlagX is deprecated. Use the AngularSpringX__enabled property instead.")]
        public void SetFlagX(Generic6DOFJoint.Flag flag, bool value)
        {
            NativeCalls.godot_icall_2_23(method_bind_18, Object.GetPtr(this), (int)flag, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_flag_x");

        [GodotMethod("get_flag_x")]
        [Obsolete("GetFlagX is deprecated. Use the AngularSpringX__enabled property instead.")]
        public bool GetFlagX(Generic6DOFJoint.Flag flag)
        {
            return NativeCalls.godot_icall_1_35(method_bind_19, Object.GetPtr(this), (int)flag);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flag_y");

        [GodotMethod("set_flag_y")]
        [Obsolete("SetFlagY is deprecated. Use the AngularSpringY__enabled property instead.")]
        public void SetFlagY(Generic6DOFJoint.Flag flag, bool value)
        {
            NativeCalls.godot_icall_2_23(method_bind_20, Object.GetPtr(this), (int)flag, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_flag_y");

        [GodotMethod("get_flag_y")]
        [Obsolete("GetFlagY is deprecated. Use the AngularSpringY__enabled property instead.")]
        public bool GetFlagY(Generic6DOFJoint.Flag flag)
        {
            return NativeCalls.godot_icall_1_35(method_bind_21, Object.GetPtr(this), (int)flag);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flag_z");

        [GodotMethod("set_flag_z")]
        [Obsolete("SetFlagZ is deprecated. Use the AngularSpringZ__enabled property instead.")]
        public void SetFlagZ(Generic6DOFJoint.Flag flag, bool value)
        {
            NativeCalls.godot_icall_2_23(method_bind_22, Object.GetPtr(this), (int)flag, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_flag_z");

        [GodotMethod("get_flag_z")]
        [Obsolete("GetFlagZ is deprecated. Use the AngularSpringZ__enabled property instead.")]
        public bool GetFlagZ(Generic6DOFJoint.Flag flag)
        {
            return NativeCalls.godot_icall_1_35(method_bind_23, Object.GetPtr(this), (int)flag);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
