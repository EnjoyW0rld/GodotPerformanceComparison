using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>PhysicsServer is the server responsible for all 3D physics. It can create many kinds of physics objects, but does not insert them on the node tree.</para>
    /// </summary>
    public static partial class PhysicsServer
    {
        public enum BodyAxis
        {
            LinearX = 1,
            LinearY = 2,
            LinearZ = 4,
            AngularX = 8,
            AngularY = 16,
            AngularZ = 32
        }

        public enum ProcessInfo
        {
            /// <summary>
            /// <para>Constant to get the number of objects that are not sleeping.</para>
            /// </summary>
            ActiveObjects = 0,
            /// <summary>
            /// <para>Constant to get the number of possible collisions.</para>
            /// </summary>
            CollisionPairs = 1,
            /// <summary>
            /// <para>Constant to get the number of space regions where a collision could occur.</para>
            /// </summary>
            IslandCount = 2
        }

        public enum AreaBodyStatus
        {
            /// <summary>
            /// <para>The value of the first parameter and area callback function receives, when an object enters one of its shapes.</para>
            /// </summary>
            Added = 0,
            /// <summary>
            /// <para>The value of the first parameter and area callback function receives, when an object exits one of its shapes.</para>
            /// </summary>
            Removed = 1
        }

        public enum BodyMode
        {
            /// <summary>
            /// <para>Constant for static bodies.</para>
            /// </summary>
            Static = 0,
            /// <summary>
            /// <para>Constant for kinematic bodies.</para>
            /// </summary>
            Kinematic = 1,
            /// <summary>
            /// <para>Constant for rigid bodies.</para>
            /// </summary>
            Rigid = 2,
            /// <summary>
            /// <para>Constant for rigid bodies in character mode. In this mode, a body can not rotate, and only its linear velocity is affected by physics.</para>
            /// </summary>
            Character = 3
        }

        public enum ShapeType
        {
            /// <summary>
            /// <para>The <see cref="Godot.Shape"/> is a <see cref="Godot.PlaneShape"/>.</para>
            /// </summary>
            Plane = 0,
            /// <summary>
            /// <para>The <see cref="Godot.Shape"/> is a <see cref="Godot.RayShape"/>.</para>
            /// </summary>
            Ray = 1,
            /// <summary>
            /// <para>The <see cref="Godot.Shape"/> is a <see cref="Godot.SphereShape"/>.</para>
            /// </summary>
            Sphere = 2,
            /// <summary>
            /// <para>The <see cref="Godot.Shape"/> is a <see cref="Godot.BoxShape"/>.</para>
            /// </summary>
            Box = 3,
            /// <summary>
            /// <para>The <see cref="Godot.Shape"/> is a <see cref="Godot.CapsuleShape"/>.</para>
            /// </summary>
            Capsule = 4,
            /// <summary>
            /// <para>The <see cref="Godot.Shape"/> is a <see cref="Godot.CylinderShape"/>.</para>
            /// </summary>
            Cylinder = 5,
            /// <summary>
            /// <para>The <see cref="Godot.Shape"/> is a <see cref="Godot.ConvexPolygonShape"/>.</para>
            /// </summary>
            ConvexPolygon = 6,
            /// <summary>
            /// <para>The <see cref="Godot.Shape"/> is a <see cref="Godot.ConcavePolygonShape"/>.</para>
            /// </summary>
            ConcavePolygon = 7,
            /// <summary>
            /// <para>The <see cref="Godot.Shape"/> is a <see cref="Godot.HeightMapShape"/>.</para>
            /// </summary>
            Heightmap = 8,
            /// <summary>
            /// <para>This constant is used internally by the engine. Any attempt to create this kind of shape results in an error.</para>
            /// </summary>
            Custom = 9
        }

        public enum PinJointParam
        {
            /// <summary>
            /// <para>The strength with which the pinned objects try to stay in positional relation to each other.</para>
            /// <para>The higher, the stronger.</para>
            /// </summary>
            Bias = 0,
            /// <summary>
            /// <para>The strength with which the pinned objects try to stay in velocity relation to each other.</para>
            /// <para>The higher, the stronger.</para>
            /// </summary>
            Damping = 1,
            /// <summary>
            /// <para>If above 0, this value is the maximum value for an impulse that this Joint puts on its ends.</para>
            /// </summary>
            ImpulseClamp = 2
        }

        public enum SpaceParameter
        {
            /// <summary>
            /// <para>Constant to set/get the maximum distance a pair of bodies has to move before their collision status has to be recalculated.</para>
            /// </summary>
            ContactRecycleRadius = 0,
            /// <summary>
            /// <para>Constant to set/get the maximum distance a shape can be from another before they are considered separated.</para>
            /// </summary>
            ContactMaxSeparation = 1,
            /// <summary>
            /// <para>Constant to set/get the maximum distance a shape can penetrate another shape before it is considered a collision.</para>
            /// </summary>
            BodyMaxAllowedPenetration = 2,
            /// <summary>
            /// <para>Constant to set/get the threshold linear velocity of activity. A body marked as potentially inactive for both linear and angular velocity will be put to sleep after the time given.</para>
            /// </summary>
            BodyLinearVelocitySleepThreshold = 3,
            /// <summary>
            /// <para>Constant to set/get the threshold angular velocity of activity. A body marked as potentially inactive for both linear and angular velocity will be put to sleep after the time given.</para>
            /// </summary>
            BodyAngularVelocitySleepThreshold = 4,
            /// <summary>
            /// <para>Constant to set/get the maximum time of activity. A body marked as potentially inactive for both linear and angular velocity will be put to sleep after this time.</para>
            /// </summary>
            BodyTimeToSleep = 5,
            BodyAngularVelocityDampRatio = 6,
            /// <summary>
            /// <para>Constant to set/get the default solver bias for all physics constraints. A solver bias is a factor controlling how much two objects "rebound", after violating a constraint, to avoid leaving them in that state because of numerical imprecision.</para>
            /// </summary>
            ConstraintDefaultBias = 7
        }

        public enum ConeTwistJointParam
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
            /// <para>The ease with which the Joint twists, if it's too low, it takes more force to twist the joint.</para>
            /// </summary>
            Softness = 3,
            /// <summary>
            /// <para>Defines, how fast the swing- and twist-speed-difference on both sides gets synced.</para>
            /// </summary>
            Relaxation = 4
        }

        public enum JointType
        {
            /// <summary>
            /// <para>The <see cref="Godot.Joint"/> is a <see cref="Godot.PinJoint"/>.</para>
            /// </summary>
            Pin = 0,
            /// <summary>
            /// <para>The <see cref="Godot.Joint"/> is a <see cref="Godot.HingeJoint"/>.</para>
            /// </summary>
            Hinge = 1,
            /// <summary>
            /// <para>The <see cref="Godot.Joint"/> is a <see cref="Godot.SliderJoint"/>.</para>
            /// </summary>
            Slider = 2,
            /// <summary>
            /// <para>The <see cref="Godot.Joint"/> is a <see cref="Godot.ConeTwistJoint"/>.</para>
            /// </summary>
            ConeTwist = 3,
            /// <summary>
            /// <para>The <see cref="Godot.Joint"/> is a <see cref="Godot.Generic6DOFJoint"/>.</para>
            /// </summary>
            Joint6dof = 4
        }

        public enum BodyState
        {
            /// <summary>
            /// <para>Constant to set/get the current transform matrix of the body.</para>
            /// </summary>
            Transform = 0,
            /// <summary>
            /// <para>Constant to set/get the current linear velocity of the body.</para>
            /// </summary>
            LinearVelocity = 1,
            /// <summary>
            /// <para>Constant to set/get the current angular velocity of the body.</para>
            /// </summary>
            AngularVelocity = 2,
            /// <summary>
            /// <para>Constant to sleep/wake up a body, or to get whether it is sleeping.</para>
            /// </summary>
            Sleeping = 3,
            /// <summary>
            /// <para>Constant to set/get whether the body can sleep.</para>
            /// </summary>
            CanSleep = 4
        }

        public enum BodyParameter
        {
            /// <summary>
            /// <para>Constant to set/get a body's bounce factor.</para>
            /// </summary>
            Bounce = 0,
            /// <summary>
            /// <para>Constant to set/get a body's friction.</para>
            /// </summary>
            Friction = 1,
            /// <summary>
            /// <para>Constant to set/get a body's mass.</para>
            /// </summary>
            Mass = 2,
            /// <summary>
            /// <para>Constant to set/get a body's gravity multiplier.</para>
            /// </summary>
            GravityScale = 3,
            /// <summary>
            /// <para>Constant to set/get a body's linear dampening factor.</para>
            /// </summary>
            LinearDamp = 4,
            /// <summary>
            /// <para>Constant to set/get a body's angular dampening factor.</para>
            /// </summary>
            AngularDamp = 5,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.PhysicsServer.BodyParameter"/> enum.</para>
            /// </summary>
            Max = 6
        }

        public enum G6DOFJointAxisParam
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
            /// <para>A factor that gets applied to the movement across the axes. The lower, the slower the movement.</para>
            /// </summary>
            LinearLimitSoftness = 2,
            /// <summary>
            /// <para>The amount of restitution on the axes movement. The lower, the more velocity-energy gets lost.</para>
            /// </summary>
            LinearRestitution = 3,
            /// <summary>
            /// <para>The amount of damping that happens at the linear motion across the axes.</para>
            /// </summary>
            LinearDamping = 4,
            /// <summary>
            /// <para>The velocity that the joint's linear motor will attempt to reach.</para>
            /// </summary>
            LinearMotorTargetVelocity = 5,
            /// <summary>
            /// <para>The maximum force that the linear motor can apply while trying to reach the target velocity.</para>
            /// </summary>
            LinearMotorForceLimit = 6,
            /// <summary>
            /// <para>The minimum rotation in negative direction to break loose and rotate around the axes.</para>
            /// </summary>
            AngularLowerLimit = 10,
            /// <summary>
            /// <para>The minimum rotation in positive direction to break loose and rotate around the axes.</para>
            /// </summary>
            AngularUpperLimit = 11,
            /// <summary>
            /// <para>A factor that gets multiplied onto all rotations across the axes.</para>
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
            /// <para>When correcting the crossing of limits in rotation across the axes, this error tolerance factor defines how much the correction gets slowed down. The lower, the slower.</para>
            /// </summary>
            AngularErp = 16,
            /// <summary>
            /// <para>Target speed for the motor at the axes.</para>
            /// </summary>
            AngularMotorTargetVelocity = 17,
            /// <summary>
            /// <para>Maximum acceleration for the motor at the axes.</para>
            /// </summary>
            AngularMotorForceLimit = 18
        }

        public enum SliderJointParam
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
            /// <para>A factor that gets applied to the all rotation in the limits.</para>
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
            /// <para>A factor that gets applied to the all rotation across axes orthogonal to the slider.</para>
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
            /// <para>Represents the size of the <see cref="Godot.PhysicsServer.SliderJointParam"/> enum.</para>
            /// </summary>
            Max = 22
        }

        public enum HingeJointParam
        {
            /// <summary>
            /// <para>The speed with which the two bodies get pulled together when they move in different directions.</para>
            /// </summary>
            Bias = 0,
            /// <summary>
            /// <para>The maximum rotation across the Hinge.</para>
            /// </summary>
            LimitUpper = 1,
            /// <summary>
            /// <para>The minimum rotation across the Hinge.</para>
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
            MotorMaxImpulse = 7
        }

        public enum G6DOFJointAxisFlag
        {
            /// <summary>
            /// <para>If set, linear motion is possible within the given limits.</para>
            /// </summary>
            LinearLimit = 0,
            /// <summary>
            /// <para>If set, rotational motion is possible.</para>
            /// </summary>
            AngularLimit = 1,
            /// <summary>
            /// <para>If set, there is a rotational motor across these axes.</para>
            /// </summary>
            Motor = 4,
            /// <summary>
            /// <para>If set, there is a linear motor on this axis that targets a specific velocity.</para>
            /// </summary>
            LinearMotor = 5
        }

        public enum HingeJointFlag
        {
            /// <summary>
            /// <para>If <c>true</c>, the Hinge has a maximum and a minimum rotation.</para>
            /// </summary>
            UseLimit = 0,
            /// <summary>
            /// <para>If <c>true</c>, a motor turns the Hinge.</para>
            /// </summary>
            EnableMotor = 1
        }

        public enum AreaSpaceOverrideMode
        {
            /// <summary>
            /// <para>This area does not affect gravity/damp. These are generally areas that exist only to detect collisions, and objects entering or exiting them.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>This area adds its gravity/damp values to whatever has been calculated so far. This way, many overlapping areas can combine their physics to make interesting effects.</para>
            /// </summary>
            Combine = 1,
            /// <summary>
            /// <para>This area adds its gravity/damp values to whatever has been calculated so far. Then stops taking into account the rest of the areas, even the default one.</para>
            /// </summary>
            CombineReplace = 2,
            /// <summary>
            /// <para>This area replaces any gravity/damp, even the default one, and stops taking into account the rest of the areas.</para>
            /// </summary>
            Replace = 3,
            /// <summary>
            /// <para>This area replaces any gravity/damp calculated so far, but keeps calculating the rest of the areas, down to the default one.</para>
            /// </summary>
            ReplaceCombine = 4
        }

        public enum AreaParameter
        {
            /// <summary>
            /// <para>Constant to set/get gravity strength in an area.</para>
            /// </summary>
            Gravity = 0,
            /// <summary>
            /// <para>Constant to set/get gravity vector/center in an area.</para>
            /// </summary>
            GravityVector = 1,
            /// <summary>
            /// <para>Constant to set/get whether the gravity vector of an area is a direction, or a center point.</para>
            /// </summary>
            GravityIsPoint = 2,
            /// <summary>
            /// <para>Constant to set/get the falloff factor for point gravity of an area. The greater this value is, the faster the strength of gravity decreases with the square of distance.</para>
            /// </summary>
            GravityDistanceScale = 3,
            /// <summary>
            /// <para>This constant was used to set/get the falloff factor for point gravity. It has been superseded by <see cref="Godot.PhysicsServer.AreaParameter.GravityDistanceScale"/>.</para>
            /// </summary>
            GravityPointAttenuation = 4,
            /// <summary>
            /// <para>Constant to set/get the linear dampening factor of an area.</para>
            /// </summary>
            LinearDamp = 5,
            /// <summary>
            /// <para>Constant to set/get the angular dampening factor of an area.</para>
            /// </summary>
            AngularDamp = 6,
            /// <summary>
            /// <para>Constant to set/get the priority (order of processing) of an area.</para>
            /// </summary>
            Priority = 7
        }

        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(PhysicsServer).Name);
                return singleton;
            }
        }

        private const string nativeName = "PhysicsServer";
        internal static IntPtr ptr = NativeCalls.godot_icall_PhysicsServer_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shape_create");

        /// <summary>
        /// <para>Creates a shape of a type from <see cref="Godot.PhysicsServer.ShapeType"/>. Does not assign it to a body or an area. To do so, you must use <see cref="Godot.PhysicsServer.AreaSetShape"/> or <see cref="Godot.PhysicsServer.BodySetShape"/>.</para>
        /// </summary>
        [GodotMethod("shape_create")]
        public static RID ShapeCreate(PhysicsServer.ShapeType type)
        {
            return new RID(NativeCalls.godot_icall_1_484(method_bind_0, ptr, (int)type));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shape_set_data");

        /// <summary>
        /// <para>Sets the shape data that defines its shape and size. The data to be passed depends on the kind of shape created <see cref="Godot.PhysicsServer.ShapeGetType"/>.</para>
        /// </summary>
        [GodotMethod("shape_set_data")]
        public static void ShapeSetData(RID shape, object data)
        {
            NativeCalls.godot_icall_2_741(method_bind_1, ptr, RID.GetPtr(shape), data);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shape_get_type");

        /// <summary>
        /// <para>Returns the type of shape (see <see cref="Godot.PhysicsServer.ShapeType"/> constants).</para>
        /// </summary>
        [GodotMethod("shape_get_type")]
        public static PhysicsServer.ShapeType ShapeGetType(RID shape)
        {
            return (PhysicsServer.ShapeType)NativeCalls.godot_icall_1_774(method_bind_2, ptr, RID.GetPtr(shape));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shape_get_data");

        /// <summary>
        /// <para>Returns the shape data.</para>
        /// </summary>
        [GodotMethod("shape_get_data")]
        public static object ShapeGetData(RID shape)
        {
            return NativeCalls.godot_icall_1_743(method_bind_3, ptr, RID.GetPtr(shape));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "space_create");

        /// <summary>
        /// <para>Creates a space. A space is a collection of parameters for the physics engine that can be assigned to an area or a body. It can be assigned to an area with <see cref="Godot.PhysicsServer.AreaSetSpace"/>, or to a body with <see cref="Godot.PhysicsServer.BodySetSpace"/>.</para>
        /// </summary>
        [GodotMethod("space_create")]
        public static RID SpaceCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_4, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "space_set_active");

        /// <summary>
        /// <para>Marks a space as active. It will not have an effect, unless it is assigned to an area or body.</para>
        /// </summary>
        [GodotMethod("space_set_active")]
        public static void SpaceSetActive(RID space, bool active)
        {
            NativeCalls.godot_icall_2_628(method_bind_5, ptr, RID.GetPtr(space), active);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "space_is_active");

        /// <summary>
        /// <para>Returns whether the space is active.</para>
        /// </summary>
        [GodotMethod("space_is_active")]
        public static bool SpaceIsActive(RID space)
        {
            return NativeCalls.godot_icall_1_629(method_bind_6, ptr, RID.GetPtr(space));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "space_set_param");

        /// <summary>
        /// <para>Sets the value for a space parameter. A list of available parameters is on the <see cref="Godot.PhysicsServer.SpaceParameter"/> constants.</para>
        /// </summary>
        [GodotMethod("space_set_param")]
        public static void SpaceSetParam(RID space, PhysicsServer.SpaceParameter param, float value)
        {
            NativeCalls.godot_icall_3_744(method_bind_7, ptr, RID.GetPtr(space), (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "space_get_param");

        /// <summary>
        /// <para>Returns the value of a space parameter.</para>
        /// </summary>
        [GodotMethod("space_get_param")]
        public static float SpaceGetParam(RID space, PhysicsServer.SpaceParameter param)
        {
            return NativeCalls.godot_icall_2_745(method_bind_8, ptr, RID.GetPtr(space), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "space_get_direct_state");

        /// <summary>
        /// <para>Returns the state of a space, a <see cref="Godot.PhysicsDirectSpaceState"/>. This object can be used to make collision/intersection queries.</para>
        /// </summary>
        [GodotMethod("space_get_direct_state")]
        public static PhysicsDirectSpaceState SpaceGetDirectState(RID space)
        {
            return NativeCalls.godot_icall_1_775(method_bind_9, ptr, RID.GetPtr(space));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_create");

        /// <summary>
        /// <para>Creates an <see cref="Godot.Area"/>.</para>
        /// </summary>
        [GodotMethod("area_create")]
        public static RID AreaCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_10, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_space");

        /// <summary>
        /// <para>Assigns a space to the area.</para>
        /// </summary>
        [GodotMethod("area_set_space")]
        public static void AreaSetSpace(RID area, RID space)
        {
            NativeCalls.godot_icall_2_637(method_bind_11, ptr, RID.GetPtr(area), RID.GetPtr(space));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_get_space");

        /// <summary>
        /// <para>Returns the space assigned to the area.</para>
        /// </summary>
        [GodotMethod("area_get_space")]
        public static RID AreaGetSpace(RID area)
        {
            return new RID(NativeCalls.godot_icall_1_638(method_bind_12, ptr, RID.GetPtr(area)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_space_override_mode");

        /// <summary>
        /// <para>Sets the space override mode for the area. The modes are described in the <see cref="Godot.PhysicsServer.AreaSpaceOverrideMode"/> constants.</para>
        /// </summary>
        [GodotMethod("area_set_space_override_mode")]
        public static void AreaSetSpaceOverrideMode(RID area, PhysicsServer.AreaSpaceOverrideMode mode)
        {
            NativeCalls.godot_icall_2_645(method_bind_13, ptr, RID.GetPtr(area), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_get_space_override_mode");

        /// <summary>
        /// <para>Returns the space override mode for the area.</para>
        /// </summary>
        [GodotMethod("area_get_space_override_mode")]
        public static PhysicsServer.AreaSpaceOverrideMode AreaGetSpaceOverrideMode(RID area)
        {
            return (PhysicsServer.AreaSpaceOverrideMode)NativeCalls.godot_icall_1_776(method_bind_14, ptr, RID.GetPtr(area));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_add_shape");

        /// <summary>
        /// <para>Adds a shape to the area, along with a transform matrix. Shapes are usually referenced by their index, so you should track which shape has a given index.</para>
        /// </summary>
        /// <param name="transform">If the parameter is null, then the default value is Transform.Identity</param>
        [GodotMethod("area_add_shape")]
        public static void AreaAddShape(RID area, RID shape, Nullable<Transform> transform = null, bool disabled = false)
        {
            Transform transform_in = transform.HasValue ? transform.Value : Transform.Identity;
            NativeCalls.godot_icall_4_777(method_bind_15, ptr, RID.GetPtr(area), RID.GetPtr(shape), ref transform_in, disabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_shape");

        /// <summary>
        /// <para>Substitutes a given area shape by another. The old shape is selected by its index, the new one by its <see cref="Godot.RID"/>.</para>
        /// </summary>
        [GodotMethod("area_set_shape")]
        public static void AreaSetShape(RID area, int shapeIdx, RID shape)
        {
            NativeCalls.godot_icall_3_749(method_bind_16, ptr, RID.GetPtr(area), shapeIdx, RID.GetPtr(shape));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_shape_transform");

        /// <summary>
        /// <para>Sets the transform matrix for an area shape.</para>
        /// </summary>
        [GodotMethod("area_set_shape_transform")]
        public static void AreaSetShapeTransform(RID area, int shapeIdx, Transform transform)
        {
            NativeCalls.godot_icall_3_778(method_bind_17, ptr, RID.GetPtr(area), shapeIdx, ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_shape_disabled");

        [GodotMethod("area_set_shape_disabled")]
        public static void AreaSetShapeDisabled(RID area, int shapeIdx, bool disabled)
        {
            NativeCalls.godot_icall_3_751(method_bind_18, ptr, RID.GetPtr(area), shapeIdx, disabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_get_shape_count");

        /// <summary>
        /// <para>Returns the number of shapes assigned to an area.</para>
        /// </summary>
        [GodotMethod("area_get_shape_count")]
        public static int AreaGetShapeCount(RID area)
        {
            return NativeCalls.godot_icall_1_643(method_bind_19, ptr, RID.GetPtr(area));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_get_shape");

        /// <summary>
        /// <para>Returns the <see cref="Godot.RID"/> of the nth shape of an area.</para>
        /// </summary>
        [GodotMethod("area_get_shape")]
        public static RID AreaGetShape(RID area, int shapeIdx)
        {
            return new RID(NativeCalls.godot_icall_2_752(method_bind_20, ptr, RID.GetPtr(area), shapeIdx));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_get_shape_transform");

        /// <summary>
        /// <para>Returns the transform matrix of a shape within an area.</para>
        /// </summary>
        [GodotMethod("area_get_shape_transform")]
        public static Transform AreaGetShapeTransform(RID area, int shapeIdx)
        {
            NativeCalls.godot_icall_2_779(method_bind_21, ptr, RID.GetPtr(area), shapeIdx, out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_remove_shape");

        /// <summary>
        /// <para>Removes a shape from an area. It does not delete the shape, so it can be reassigned later.</para>
        /// </summary>
        [GodotMethod("area_remove_shape")]
        public static void AreaRemoveShape(RID area, int shapeIdx)
        {
            NativeCalls.godot_icall_2_645(method_bind_22, ptr, RID.GetPtr(area), shapeIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_clear_shapes");

        /// <summary>
        /// <para>Removes all shapes from an area. It does not delete the shapes, so they can be reassigned later.</para>
        /// </summary>
        [GodotMethod("area_clear_shapes")]
        public static void AreaClearShapes(RID area)
        {
            NativeCalls.godot_icall_1_285(method_bind_23, ptr, RID.GetPtr(area));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_collision_layer");

        /// <summary>
        /// <para>Assigns the area to one or many physics layers.</para>
        /// </summary>
        [GodotMethod("area_set_collision_layer")]
        public static void AreaSetCollisionLayer(RID area, uint layer)
        {
            NativeCalls.godot_icall_2_639(method_bind_24, ptr, RID.GetPtr(area), layer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_collision_mask");

        /// <summary>
        /// <para>Sets which physics layers the area will monitor.</para>
        /// </summary>
        [GodotMethod("area_set_collision_mask")]
        public static void AreaSetCollisionMask(RID area, uint mask)
        {
            NativeCalls.godot_icall_2_639(method_bind_25, ptr, RID.GetPtr(area), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_param");

        /// <summary>
        /// <para>Sets the value for an area parameter. A list of available parameters is on the <see cref="Godot.PhysicsServer.AreaParameter"/> constants.</para>
        /// </summary>
        [GodotMethod("area_set_param")]
        public static void AreaSetParam(RID area, PhysicsServer.AreaParameter param, object value)
        {
            NativeCalls.godot_icall_3_754(method_bind_26, ptr, RID.GetPtr(area), (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_transform");

        /// <summary>
        /// <para>Sets the transform matrix for an area.</para>
        /// </summary>
        [GodotMethod("area_set_transform")]
        public static void AreaSetTransform(RID area, Transform transform)
        {
            NativeCalls.godot_icall_2_663(method_bind_27, ptr, RID.GetPtr(area), ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_get_param");

        /// <summary>
        /// <para>Returns an area parameter value. A list of available parameters is on the <see cref="Godot.PhysicsServer.AreaParameter"/> constants.</para>
        /// </summary>
        [GodotMethod("area_get_param")]
        public static object AreaGetParam(RID area, PhysicsServer.AreaParameter param)
        {
            return NativeCalls.godot_icall_2_755(method_bind_28, ptr, RID.GetPtr(area), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_get_transform");

        /// <summary>
        /// <para>Returns the transform matrix for an area.</para>
        /// </summary>
        [GodotMethod("area_get_transform")]
        public static Transform AreaGetTransform(RID area)
        {
            NativeCalls.godot_icall_1_780(method_bind_29, ptr, RID.GetPtr(area), out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_attach_object_instance_id");

        /// <summary>
        /// <para>Assigns the area to a descendant of <see cref="Godot.Object"/>, so it can exist in the node tree.</para>
        /// </summary>
        [GodotMethod("area_attach_object_instance_id")]
        public static void AreaAttachObjectInstanceId(RID area, ulong id)
        {
            NativeCalls.godot_icall_2_757(method_bind_30, ptr, RID.GetPtr(area), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_get_object_instance_id");

        /// <summary>
        /// <para>Gets the instance ID of the object the area is assigned to.</para>
        /// </summary>
        [GodotMethod("area_get_object_instance_id")]
        public static ulong AreaGetObjectInstanceId(RID area)
        {
            return NativeCalls.godot_icall_1_758(method_bind_31, ptr, RID.GetPtr(area));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_monitor_callback");

        /// <summary>
        /// <para>Sets the function to call when any body/area enters or exits the area. This callback will be called for any object interacting with the area, and takes five parameters:</para>
        /// <para>1: <see cref="Godot.PhysicsServer.AreaBodyStatus.Added"/> or <see cref="Godot.PhysicsServer.AreaBodyStatus.Removed"/>, depending on whether the object entered or exited the area.</para>
        /// <para>2: <see cref="Godot.RID"/> of the object that entered/exited the area.</para>
        /// <para>3: Instance ID of the object that entered/exited the area.</para>
        /// <para>4: The shape index of the object that entered/exited the area.</para>
        /// <para>5: The shape index of the area where the object entered/exited.</para>
        /// </summary>
        [GodotMethod("area_set_monitor_callback")]
        public static void AreaSetMonitorCallback(RID area, Object receiver, string method)
        {
            NativeCalls.godot_icall_3_759(method_bind_32, ptr, RID.GetPtr(area), Object.GetPtr(receiver), method);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_area_monitor_callback");

        [GodotMethod("area_set_area_monitor_callback")]
        public static void AreaSetAreaMonitorCallback(RID area, Object receiver, string method)
        {
            NativeCalls.godot_icall_3_759(method_bind_33, ptr, RID.GetPtr(area), Object.GetPtr(receiver), method);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_monitorable");

        [GodotMethod("area_set_monitorable")]
        public static void AreaSetMonitorable(RID area, bool monitorable)
        {
            NativeCalls.godot_icall_2_628(method_bind_34, ptr, RID.GetPtr(area), monitorable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_ray_pickable");

        /// <summary>
        /// <para>Sets object pickable with rays.</para>
        /// </summary>
        [GodotMethod("area_set_ray_pickable")]
        public static void AreaSetRayPickable(RID area, bool enable)
        {
            NativeCalls.godot_icall_2_628(method_bind_35, ptr, RID.GetPtr(area), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_is_ray_pickable");

        /// <summary>
        /// <para>If <c>true</c>, area collides with rays.</para>
        /// </summary>
        [GodotMethod("area_is_ray_pickable")]
        public static bool AreaIsRayPickable(RID area)
        {
            return NativeCalls.godot_icall_1_629(method_bind_36, ptr, RID.GetPtr(area));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_create");

        /// <summary>
        /// <para>Creates a physics body. The first parameter can be any value from <see cref="Godot.PhysicsServer.BodyMode"/> constants, for the type of body created. Additionally, the body can be created in sleeping state to save processing time.</para>
        /// </summary>
        [GodotMethod("body_create")]
        public static RID BodyCreate(PhysicsServer.BodyMode mode = (PhysicsServer.BodyMode)2, bool initSleeping = false)
        {
            return new RID(NativeCalls.godot_icall_2_781(method_bind_37, ptr, (int)mode, initSleeping));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_space");

        /// <summary>
        /// <para>Assigns a space to the body (see <see cref="Godot.PhysicsServer.SpaceCreate"/>).</para>
        /// </summary>
        [GodotMethod("body_set_space")]
        public static void BodySetSpace(RID body, RID space)
        {
            NativeCalls.godot_icall_2_637(method_bind_38, ptr, RID.GetPtr(body), RID.GetPtr(space));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_space");

        /// <summary>
        /// <para>Returns the <see cref="Godot.RID"/> of the space assigned to a body.</para>
        /// </summary>
        [GodotMethod("body_get_space")]
        public static RID BodyGetSpace(RID body)
        {
            return new RID(NativeCalls.godot_icall_1_638(method_bind_39, ptr, RID.GetPtr(body)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_mode");

        /// <summary>
        /// <para>Sets the body mode, from one of the <see cref="Godot.PhysicsServer.BodyMode"/> constants.</para>
        /// </summary>
        [GodotMethod("body_set_mode")]
        public static void BodySetMode(RID body, PhysicsServer.BodyMode mode)
        {
            NativeCalls.godot_icall_2_645(method_bind_40, ptr, RID.GetPtr(body), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_mode");

        /// <summary>
        /// <para>Returns the body mode.</para>
        /// </summary>
        [GodotMethod("body_get_mode")]
        public static PhysicsServer.BodyMode BodyGetMode(RID body)
        {
            return (PhysicsServer.BodyMode)NativeCalls.godot_icall_1_782(method_bind_41, ptr, RID.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_collision_layer");

        /// <summary>
        /// <para>Sets the physics layer or layers a body belongs to.</para>
        /// </summary>
        [GodotMethod("body_set_collision_layer")]
        public static void BodySetCollisionLayer(RID body, uint layer)
        {
            NativeCalls.godot_icall_2_639(method_bind_42, ptr, RID.GetPtr(body), layer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_collision_layer");

        /// <summary>
        /// <para>Returns the physics layer or layers a body belongs to.</para>
        /// </summary>
        [GodotMethod("body_get_collision_layer")]
        public static uint BodyGetCollisionLayer(RID body)
        {
            return NativeCalls.godot_icall_1_640(method_bind_43, ptr, RID.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_collision_mask");

        /// <summary>
        /// <para>Sets the physics layer or layers a body can collide with.</para>
        /// </summary>
        [GodotMethod("body_set_collision_mask")]
        public static void BodySetCollisionMask(RID body, uint mask)
        {
            NativeCalls.godot_icall_2_639(method_bind_44, ptr, RID.GetPtr(body), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_collision_mask");

        /// <summary>
        /// <para>Returns the physics layer or layers a body can collide with.</para>
        /// </summary>
        [GodotMethod("body_get_collision_mask")]
        public static uint BodyGetCollisionMask(RID body)
        {
            return NativeCalls.godot_icall_1_640(method_bind_45, ptr, RID.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_add_shape");

        /// <summary>
        /// <para>Adds a shape to the body, along with a transform matrix. Shapes are usually referenced by their index, so you should track which shape has a given index.</para>
        /// </summary>
        /// <param name="transform">If the parameter is null, then the default value is Transform.Identity</param>
        [GodotMethod("body_add_shape")]
        public static void BodyAddShape(RID body, RID shape, Nullable<Transform> transform = null, bool disabled = false)
        {
            Transform transform_in = transform.HasValue ? transform.Value : Transform.Identity;
            NativeCalls.godot_icall_4_777(method_bind_46, ptr, RID.GetPtr(body), RID.GetPtr(shape), ref transform_in, disabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_shape");

        /// <summary>
        /// <para>Substitutes a given body shape by another. The old shape is selected by its index, the new one by its <see cref="Godot.RID"/>.</para>
        /// </summary>
        [GodotMethod("body_set_shape")]
        public static void BodySetShape(RID body, int shapeIdx, RID shape)
        {
            NativeCalls.godot_icall_3_749(method_bind_47, ptr, RID.GetPtr(body), shapeIdx, RID.GetPtr(shape));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_shape_transform");

        /// <summary>
        /// <para>Sets the transform matrix for a body shape.</para>
        /// </summary>
        [GodotMethod("body_set_shape_transform")]
        public static void BodySetShapeTransform(RID body, int shapeIdx, Transform transform)
        {
            NativeCalls.godot_icall_3_778(method_bind_48, ptr, RID.GetPtr(body), shapeIdx, ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_shape_disabled");

        [GodotMethod("body_set_shape_disabled")]
        public static void BodySetShapeDisabled(RID body, int shapeIdx, bool disabled)
        {
            NativeCalls.godot_icall_3_751(method_bind_49, ptr, RID.GetPtr(body), shapeIdx, disabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_shape_count");

        /// <summary>
        /// <para>Returns the number of shapes assigned to a body.</para>
        /// </summary>
        [GodotMethod("body_get_shape_count")]
        public static int BodyGetShapeCount(RID body)
        {
            return NativeCalls.godot_icall_1_643(method_bind_50, ptr, RID.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_shape");

        /// <summary>
        /// <para>Returns the <see cref="Godot.RID"/> of the nth shape of a body.</para>
        /// </summary>
        [GodotMethod("body_get_shape")]
        public static RID BodyGetShape(RID body, int shapeIdx)
        {
            return new RID(NativeCalls.godot_icall_2_752(method_bind_51, ptr, RID.GetPtr(body), shapeIdx));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_shape_transform");

        /// <summary>
        /// <para>Returns the transform matrix of a body shape.</para>
        /// </summary>
        [GodotMethod("body_get_shape_transform")]
        public static Transform BodyGetShapeTransform(RID body, int shapeIdx)
        {
            NativeCalls.godot_icall_2_779(method_bind_52, ptr, RID.GetPtr(body), shapeIdx, out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_53 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_remove_shape");

        /// <summary>
        /// <para>Removes a shape from a body. The shape is not deleted, so it can be reused afterwards.</para>
        /// </summary>
        [GodotMethod("body_remove_shape")]
        public static void BodyRemoveShape(RID body, int shapeIdx)
        {
            NativeCalls.godot_icall_2_645(method_bind_53, ptr, RID.GetPtr(body), shapeIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_54 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_clear_shapes");

        /// <summary>
        /// <para>Removes all shapes from a body.</para>
        /// </summary>
        [GodotMethod("body_clear_shapes")]
        public static void BodyClearShapes(RID body)
        {
            NativeCalls.godot_icall_1_285(method_bind_54, ptr, RID.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_55 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_attach_object_instance_id");

        /// <summary>
        /// <para>Assigns the area to a descendant of <see cref="Godot.Object"/>, so it can exist in the node tree.</para>
        /// </summary>
        [GodotMethod("body_attach_object_instance_id")]
        public static void BodyAttachObjectInstanceId(RID body, uint id)
        {
            NativeCalls.godot_icall_2_639(method_bind_55, ptr, RID.GetPtr(body), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_56 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_object_instance_id");

        /// <summary>
        /// <para>Gets the instance ID of the object the area is assigned to.</para>
        /// </summary>
        [GodotMethod("body_get_object_instance_id")]
        public static uint BodyGetObjectInstanceId(RID body)
        {
            return NativeCalls.godot_icall_1_640(method_bind_56, ptr, RID.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_57 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_enable_continuous_collision_detection");

        /// <summary>
        /// <para>If <c>true</c>, the continuous collision detection mode is enabled.</para>
        /// <para>Continuous collision detection tries to predict where a moving body will collide, instead of moving it and correcting its movement if it collided.</para>
        /// </summary>
        [GodotMethod("body_set_enable_continuous_collision_detection")]
        public static void BodySetEnableContinuousCollisionDetection(RID body, bool enable)
        {
            NativeCalls.godot_icall_2_628(method_bind_57, ptr, RID.GetPtr(body), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_58 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_is_continuous_collision_detection_enabled");

        /// <summary>
        /// <para>If <c>true</c>, the continuous collision detection mode is enabled.</para>
        /// </summary>
        [GodotMethod("body_is_continuous_collision_detection_enabled")]
        public static bool BodyIsContinuousCollisionDetectionEnabled(RID body)
        {
            return NativeCalls.godot_icall_1_629(method_bind_58, ptr, RID.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_59 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_param");

        /// <summary>
        /// <para>Sets a body parameter. A list of available parameters is on the <see cref="Godot.PhysicsServer.BodyParameter"/> constants.</para>
        /// </summary>
        [GodotMethod("body_set_param")]
        public static void BodySetParam(RID body, PhysicsServer.BodyParameter param, float value)
        {
            NativeCalls.godot_icall_3_744(method_bind_59, ptr, RID.GetPtr(body), (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_60 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_param");

        /// <summary>
        /// <para>Returns the value of a body parameter. A list of available parameters is on the <see cref="Godot.PhysicsServer.BodyParameter"/> constants.</para>
        /// </summary>
        [GodotMethod("body_get_param")]
        public static float BodyGetParam(RID body, PhysicsServer.BodyParameter param)
        {
            return NativeCalls.godot_icall_2_745(method_bind_60, ptr, RID.GetPtr(body), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_61 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_kinematic_safe_margin");

        [GodotMethod("body_set_kinematic_safe_margin")]
        public static void BodySetKinematicSafeMargin(RID body, float margin)
        {
            NativeCalls.godot_icall_2_630(method_bind_61, ptr, RID.GetPtr(body), margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_62 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_kinematic_safe_margin");

        [GodotMethod("body_get_kinematic_safe_margin")]
        public static float BodyGetKinematicSafeMargin(RID body)
        {
            return NativeCalls.godot_icall_1_631(method_bind_62, ptr, RID.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_63 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_state");

        /// <summary>
        /// <para>Sets a body state (see <see cref="Godot.PhysicsServer.BodyState"/> constants).</para>
        /// </summary>
        [GodotMethod("body_set_state")]
        public static void BodySetState(RID body, PhysicsServer.BodyState state, object value)
        {
            NativeCalls.godot_icall_3_754(method_bind_63, ptr, RID.GetPtr(body), (int)state, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_64 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_state");

        /// <summary>
        /// <para>Returns a body state.</para>
        /// </summary>
        [GodotMethod("body_get_state")]
        public static object BodyGetState(RID body, PhysicsServer.BodyState state)
        {
            return NativeCalls.godot_icall_2_755(method_bind_64, ptr, RID.GetPtr(body), (int)state);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_65 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_add_central_force");

        [GodotMethod("body_add_central_force")]
        public static void BodyAddCentralForce(RID body, Vector3 force)
        {
            NativeCalls.godot_icall_2_656(method_bind_65, ptr, RID.GetPtr(body), ref force);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_66 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_add_force");

        [GodotMethod("body_add_force")]
        public static void BodyAddForce(RID body, Vector3 force, Vector3 position)
        {
            NativeCalls.godot_icall_3_783(method_bind_66, ptr, RID.GetPtr(body), ref force, ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_67 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_add_torque");

        [GodotMethod("body_add_torque")]
        public static void BodyAddTorque(RID body, Vector3 torque)
        {
            NativeCalls.godot_icall_2_656(method_bind_67, ptr, RID.GetPtr(body), ref torque);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_68 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_apply_central_impulse");

        [GodotMethod("body_apply_central_impulse")]
        public static void BodyApplyCentralImpulse(RID body, Vector3 impulse)
        {
            NativeCalls.godot_icall_2_656(method_bind_68, ptr, RID.GetPtr(body), ref impulse);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_69 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_apply_impulse");

        /// <summary>
        /// <para>Gives the body a push at a <c>position</c> in the direction of the <c>impulse</c>.</para>
        /// </summary>
        [GodotMethod("body_apply_impulse")]
        public static void BodyApplyImpulse(RID body, Vector3 position, Vector3 impulse)
        {
            NativeCalls.godot_icall_3_783(method_bind_69, ptr, RID.GetPtr(body), ref position, ref impulse);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_70 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_apply_torque_impulse");

        /// <summary>
        /// <para>Gives the body a push to rotate it.</para>
        /// </summary>
        [GodotMethod("body_apply_torque_impulse")]
        public static void BodyApplyTorqueImpulse(RID body, Vector3 impulse)
        {
            NativeCalls.godot_icall_2_656(method_bind_70, ptr, RID.GetPtr(body), ref impulse);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_71 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_axis_velocity");

        /// <summary>
        /// <para>Sets an axis velocity. The velocity in the given vector axis will be set as the given vector length. This is useful for jumping behavior.</para>
        /// </summary>
        [GodotMethod("body_set_axis_velocity")]
        public static void BodySetAxisVelocity(RID body, Vector3 axisVelocity)
        {
            NativeCalls.godot_icall_2_656(method_bind_71, ptr, RID.GetPtr(body), ref axisVelocity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_72 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_axis_lock");

        [GodotMethod("body_set_axis_lock")]
        public static void BodySetAxisLock(RID body, PhysicsServer.BodyAxis axis, bool @lock)
        {
            NativeCalls.godot_icall_3_751(method_bind_72, ptr, RID.GetPtr(body), (int)axis, @lock);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_73 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_is_axis_locked");

        [GodotMethod("body_is_axis_locked")]
        public static bool BodyIsAxisLocked(RID body, PhysicsServer.BodyAxis axis)
        {
            return NativeCalls.godot_icall_2_784(method_bind_73, ptr, RID.GetPtr(body), (int)axis);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_74 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_add_collision_exception");

        /// <summary>
        /// <para>Adds a body to the list of bodies exempt from collisions.</para>
        /// </summary>
        [GodotMethod("body_add_collision_exception")]
        public static void BodyAddCollisionException(RID body, RID exceptedBody)
        {
            NativeCalls.godot_icall_2_637(method_bind_74, ptr, RID.GetPtr(body), RID.GetPtr(exceptedBody));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_75 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_remove_collision_exception");

        /// <summary>
        /// <para>Removes a body from the list of bodies exempt from collisions.</para>
        /// <para>Continuous collision detection tries to predict where a moving body will collide, instead of moving it and correcting its movement if it collided.</para>
        /// </summary>
        [GodotMethod("body_remove_collision_exception")]
        public static void BodyRemoveCollisionException(RID body, RID exceptedBody)
        {
            NativeCalls.godot_icall_2_637(method_bind_75, ptr, RID.GetPtr(body), RID.GetPtr(exceptedBody));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_76 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_max_contacts_reported");

        /// <summary>
        /// <para>Sets the maximum contacts to report. Bodies can keep a log of the contacts with other bodies, this is enabled by setting the maximum amount of contacts reported to a number greater than 0.</para>
        /// </summary>
        [GodotMethod("body_set_max_contacts_reported")]
        public static void BodySetMaxContactsReported(RID body, int amount)
        {
            NativeCalls.godot_icall_2_645(method_bind_76, ptr, RID.GetPtr(body), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_77 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_max_contacts_reported");

        /// <summary>
        /// <para>Returns the maximum contacts that can be reported. See <see cref="Godot.PhysicsServer.BodySetMaxContactsReported"/>.</para>
        /// </summary>
        [GodotMethod("body_get_max_contacts_reported")]
        public static int BodyGetMaxContactsReported(RID body)
        {
            return NativeCalls.godot_icall_1_643(method_bind_77, ptr, RID.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_78 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_omit_force_integration");

        /// <summary>
        /// <para>Sets whether a body uses a callback function to calculate its own physics (see <see cref="Godot.PhysicsServer.BodySetForceIntegrationCallback"/>).</para>
        /// </summary>
        [GodotMethod("body_set_omit_force_integration")]
        public static void BodySetOmitForceIntegration(RID body, bool enable)
        {
            NativeCalls.godot_icall_2_628(method_bind_78, ptr, RID.GetPtr(body), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_79 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_is_omitting_force_integration");

        /// <summary>
        /// <para>Returns whether a body uses a callback function to calculate its own physics (see <see cref="Godot.PhysicsServer.BodySetForceIntegrationCallback"/>).</para>
        /// </summary>
        [GodotMethod("body_is_omitting_force_integration")]
        public static bool BodyIsOmittingForceIntegration(RID body)
        {
            return NativeCalls.godot_icall_1_629(method_bind_79, ptr, RID.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_80 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_force_integration_callback");

        /// <summary>
        /// <para>Sets the function used to calculate physics for an object, if that object allows it (see <see cref="Godot.PhysicsServer.BodySetOmitForceIntegration"/>).</para>
        /// </summary>
        [GodotMethod("body_set_force_integration_callback")]
        public static void BodySetForceIntegrationCallback(RID body, Object receiver, string method, object userdata = null)
        {
            NativeCalls.godot_icall_4_647(method_bind_80, ptr, RID.GetPtr(body), Object.GetPtr(receiver), method, userdata);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_81 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_ray_pickable");

        /// <summary>
        /// <para>Sets the body pickable with rays if <c>enabled</c> is set.</para>
        /// </summary>
        [GodotMethod("body_set_ray_pickable")]
        public static void BodySetRayPickable(RID body, bool enable)
        {
            NativeCalls.godot_icall_2_628(method_bind_81, ptr, RID.GetPtr(body), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_82 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_is_ray_pickable");

        /// <summary>
        /// <para>If <c>true</c>, the body can be detected by rays.</para>
        /// </summary>
        [GodotMethod("body_is_ray_pickable")]
        public static bool BodyIsRayPickable(RID body)
        {
            return NativeCalls.godot_icall_1_629(method_bind_82, ptr, RID.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_83 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_test_motion");

        /// <summary>
        /// <para>Returns <c>true</c> if a collision would result from moving in the given direction from a given point in space. <see cref="Godot.PhysicsTestMotionResult"/> can be passed to return additional information in.</para>
        /// </summary>
        /// <param name="exclude">If the parameter is null, then the default value is new Godot.Collections.Array { }</param>
        [GodotMethod("body_test_motion")]
        public static bool BodyTestMotion(RID body, Transform from, Vector3 motion, bool infiniteInertia, PhysicsTestMotionResult result = null, bool excludeRaycastShapes = true, Godot.Collections.Array exclude = null)
        {
            Godot.Collections.Array exclude_in = exclude != null ? exclude : new Godot.Collections.Array { };
            return NativeCalls.godot_icall_7_785(method_bind_83, ptr, RID.GetPtr(body), ref from, ref motion, infiniteInertia, Object.GetPtr(result), excludeRaycastShapes, exclude_in.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_84 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_direct_state");

        /// <summary>
        /// <para>Returns the <see cref="Godot.PhysicsDirectBodyState"/> of the body. Returns <c>null</c> if the body is destroyed or removed from the physics space.</para>
        /// </summary>
        [GodotMethod("body_get_direct_state")]
        public static PhysicsDirectBodyState BodyGetDirectState(RID body)
        {
            return NativeCalls.godot_icall_1_786(method_bind_84, ptr, RID.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_85 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "joint_create_pin");

        /// <summary>
        /// <para>Creates a <see cref="Godot.PinJoint"/>.</para>
        /// </summary>
        [GodotMethod("joint_create_pin")]
        public static RID JointCreatePin(RID bodyA, Vector3 localA, RID bodyB, Vector3 localB)
        {
            return new RID(NativeCalls.godot_icall_4_787(method_bind_85, ptr, RID.GetPtr(bodyA), ref localA, RID.GetPtr(bodyB), ref localB));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_86 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "pin_joint_set_param");

        /// <summary>
        /// <para>Sets a pin_joint parameter (see <see cref="Godot.PhysicsServer.PinJointParam"/> constants).</para>
        /// </summary>
        [GodotMethod("pin_joint_set_param")]
        public static void PinJointSetParam(RID joint, PhysicsServer.PinJointParam param, float value)
        {
            NativeCalls.godot_icall_3_744(method_bind_86, ptr, RID.GetPtr(joint), (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_87 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "pin_joint_get_param");

        /// <summary>
        /// <para>Gets a pin_joint parameter (see <see cref="Godot.PhysicsServer.PinJointParam"/> constants).</para>
        /// </summary>
        [GodotMethod("pin_joint_get_param")]
        public static float PinJointGetParam(RID joint, PhysicsServer.PinJointParam param)
        {
            return NativeCalls.godot_icall_2_745(method_bind_87, ptr, RID.GetPtr(joint), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_88 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "pin_joint_set_local_a");

        /// <summary>
        /// <para>Sets position of the joint in the local space of body a of the joint.</para>
        /// </summary>
        [GodotMethod("pin_joint_set_local_a")]
        public static void PinJointSetLocalA(RID joint, Vector3 localA)
        {
            NativeCalls.godot_icall_2_656(method_bind_88, ptr, RID.GetPtr(joint), ref localA);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_89 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "pin_joint_get_local_a");

        /// <summary>
        /// <para>Returns position of the joint in the local space of body a of the joint.</para>
        /// </summary>
        [GodotMethod("pin_joint_get_local_a")]
        public static Vector3 PinJointGetLocalA(RID joint)
        {
            NativeCalls.godot_icall_1_657(method_bind_89, ptr, RID.GetPtr(joint), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_90 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "pin_joint_set_local_b");

        /// <summary>
        /// <para>Sets position of the joint in the local space of body b of the joint.</para>
        /// </summary>
        [GodotMethod("pin_joint_set_local_b")]
        public static void PinJointSetLocalB(RID joint, Vector3 localB)
        {
            NativeCalls.godot_icall_2_656(method_bind_90, ptr, RID.GetPtr(joint), ref localB);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_91 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "pin_joint_get_local_b");

        /// <summary>
        /// <para>Returns position of the joint in the local space of body b of the joint.</para>
        /// </summary>
        [GodotMethod("pin_joint_get_local_b")]
        public static Vector3 PinJointGetLocalB(RID joint)
        {
            NativeCalls.godot_icall_1_657(method_bind_91, ptr, RID.GetPtr(joint), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_92 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "joint_create_hinge");

        /// <summary>
        /// <para>Creates a <see cref="Godot.HingeJoint"/>.</para>
        /// </summary>
        [GodotMethod("joint_create_hinge")]
        public static RID JointCreateHinge(RID bodyA, Transform hingeA, RID bodyB, Transform hingeB)
        {
            return new RID(NativeCalls.godot_icall_4_788(method_bind_92, ptr, RID.GetPtr(bodyA), ref hingeA, RID.GetPtr(bodyB), ref hingeB));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_93 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "hinge_joint_set_param");

        /// <summary>
        /// <para>Sets a hinge_joint parameter (see <see cref="Godot.PhysicsServer.HingeJointParam"/> constants).</para>
        /// </summary>
        [GodotMethod("hinge_joint_set_param")]
        public static void HingeJointSetParam(RID joint, PhysicsServer.HingeJointParam param, float value)
        {
            NativeCalls.godot_icall_3_744(method_bind_93, ptr, RID.GetPtr(joint), (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_94 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "hinge_joint_get_param");

        /// <summary>
        /// <para>Gets a hinge_joint parameter (see <see cref="Godot.PhysicsServer.HingeJointParam"/>).</para>
        /// </summary>
        [GodotMethod("hinge_joint_get_param")]
        public static float HingeJointGetParam(RID joint, PhysicsServer.HingeJointParam param)
        {
            return NativeCalls.godot_icall_2_745(method_bind_94, ptr, RID.GetPtr(joint), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_95 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "hinge_joint_set_flag");

        /// <summary>
        /// <para>Sets a hinge_joint flag (see <see cref="Godot.PhysicsServer.HingeJointFlag"/> constants).</para>
        /// </summary>
        [GodotMethod("hinge_joint_set_flag")]
        public static void HingeJointSetFlag(RID joint, PhysicsServer.HingeJointFlag flag, bool enabled)
        {
            NativeCalls.godot_icall_3_751(method_bind_95, ptr, RID.GetPtr(joint), (int)flag, enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_96 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "hinge_joint_get_flag");

        /// <summary>
        /// <para>Gets a hinge_joint flag (see <see cref="Godot.PhysicsServer.HingeJointFlag"/> constants).</para>
        /// </summary>
        [GodotMethod("hinge_joint_get_flag")]
        public static bool HingeJointGetFlag(RID joint, PhysicsServer.HingeJointFlag flag)
        {
            return NativeCalls.godot_icall_2_784(method_bind_96, ptr, RID.GetPtr(joint), (int)flag);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_97 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "joint_create_slider");

        /// <summary>
        /// <para>Creates a <see cref="Godot.SliderJoint"/>.</para>
        /// </summary>
        [GodotMethod("joint_create_slider")]
        public static RID JointCreateSlider(RID bodyA, Transform localRefA, RID bodyB, Transform localRefB)
        {
            return new RID(NativeCalls.godot_icall_4_788(method_bind_97, ptr, RID.GetPtr(bodyA), ref localRefA, RID.GetPtr(bodyB), ref localRefB));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_98 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "slider_joint_set_param");

        /// <summary>
        /// <para>Gets a slider_joint parameter (see <see cref="Godot.PhysicsServer.SliderJointParam"/> constants).</para>
        /// </summary>
        [GodotMethod("slider_joint_set_param")]
        public static void SliderJointSetParam(RID joint, PhysicsServer.SliderJointParam param, float value)
        {
            NativeCalls.godot_icall_3_744(method_bind_98, ptr, RID.GetPtr(joint), (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_99 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "slider_joint_get_param");

        /// <summary>
        /// <para>Gets a slider_joint parameter (see <see cref="Godot.PhysicsServer.SliderJointParam"/> constants).</para>
        /// </summary>
        [GodotMethod("slider_joint_get_param")]
        public static float SliderJointGetParam(RID joint, PhysicsServer.SliderJointParam param)
        {
            return NativeCalls.godot_icall_2_745(method_bind_99, ptr, RID.GetPtr(joint), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_100 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "joint_create_cone_twist");

        /// <summary>
        /// <para>Creates a <see cref="Godot.ConeTwistJoint"/>.</para>
        /// </summary>
        [GodotMethod("joint_create_cone_twist")]
        public static RID JointCreateConeTwist(RID bodyA, Transform localRefA, RID bodyB, Transform localRefB)
        {
            return new RID(NativeCalls.godot_icall_4_788(method_bind_100, ptr, RID.GetPtr(bodyA), ref localRefA, RID.GetPtr(bodyB), ref localRefB));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_101 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "cone_twist_joint_set_param");

        /// <summary>
        /// <para>Sets a cone_twist_joint parameter (see <see cref="Godot.PhysicsServer.ConeTwistJointParam"/> constants).</para>
        /// </summary>
        [GodotMethod("cone_twist_joint_set_param")]
        public static void ConeTwistJointSetParam(RID joint, PhysicsServer.ConeTwistJointParam param, float value)
        {
            NativeCalls.godot_icall_3_744(method_bind_101, ptr, RID.GetPtr(joint), (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_102 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "cone_twist_joint_get_param");

        /// <summary>
        /// <para>Gets a cone_twist_joint parameter (see <see cref="Godot.PhysicsServer.ConeTwistJointParam"/> constants).</para>
        /// </summary>
        [GodotMethod("cone_twist_joint_get_param")]
        public static float ConeTwistJointGetParam(RID joint, PhysicsServer.ConeTwistJointParam param)
        {
            return NativeCalls.godot_icall_2_745(method_bind_102, ptr, RID.GetPtr(joint), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_103 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "joint_get_type");

        /// <summary>
        /// <para>Returns the type of the Joint.</para>
        /// </summary>
        [GodotMethod("joint_get_type")]
        public static PhysicsServer.JointType JointGetType(RID joint)
        {
            return (PhysicsServer.JointType)NativeCalls.godot_icall_1_789(method_bind_103, ptr, RID.GetPtr(joint));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_104 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "joint_set_solver_priority");

        /// <summary>
        /// <para>Sets the priority value of the Joint.</para>
        /// </summary>
        [GodotMethod("joint_set_solver_priority")]
        public static void JointSetSolverPriority(RID joint, int priority)
        {
            NativeCalls.godot_icall_2_645(method_bind_104, ptr, RID.GetPtr(joint), priority);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_105 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "joint_get_solver_priority");

        /// <summary>
        /// <para>Gets the priority value of the Joint.</para>
        /// </summary>
        [GodotMethod("joint_get_solver_priority")]
        public static int JointGetSolverPriority(RID joint)
        {
            return NativeCalls.godot_icall_1_643(method_bind_105, ptr, RID.GetPtr(joint));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_106 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "joint_create_generic_6dof");

        /// <summary>
        /// <para>Creates a <see cref="Godot.Generic6DOFJoint"/>.</para>
        /// </summary>
        [GodotMethod("joint_create_generic_6dof")]
        public static RID JointCreateGeneric6dof(RID bodyA, Transform localRefA, RID bodyB, Transform localRefB)
        {
            return new RID(NativeCalls.godot_icall_4_788(method_bind_106, ptr, RID.GetPtr(bodyA), ref localRefA, RID.GetPtr(bodyB), ref localRefB));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_107 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "generic_6dof_joint_set_param");

        /// <summary>
        /// <para>Sets a generic_6_DOF_joint parameter (see <see cref="Godot.PhysicsServer.G6DOFJointAxisParam"/> constants).</para>
        /// </summary>
        [GodotMethod("generic_6dof_joint_set_param")]
        public static void Generic6dofJointSetParam(RID joint, Vector3.Axis axis, PhysicsServer.G6DOFJointAxisParam param, float value)
        {
            NativeCalls.godot_icall_4_790(method_bind_107, ptr, RID.GetPtr(joint), (int)axis, (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_108 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "generic_6dof_joint_get_param");

        /// <summary>
        /// <para>Gets a generic_6_DOF_joint parameter (see <see cref="Godot.PhysicsServer.G6DOFJointAxisParam"/> constants).</para>
        /// </summary>
        [GodotMethod("generic_6dof_joint_get_param")]
        public static float Generic6dofJointGetParam(RID joint, Vector3.Axis axis, PhysicsServer.G6DOFJointAxisParam param)
        {
            return NativeCalls.godot_icall_3_791(method_bind_108, ptr, RID.GetPtr(joint), (int)axis, (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_109 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "generic_6dof_joint_set_flag");

        /// <summary>
        /// <para>Sets a generic_6_DOF_joint flag (see <see cref="Godot.PhysicsServer.G6DOFJointAxisFlag"/> constants).</para>
        /// </summary>
        [GodotMethod("generic_6dof_joint_set_flag")]
        public static void Generic6dofJointSetFlag(RID joint, Vector3.Axis axis, PhysicsServer.G6DOFJointAxisFlag flag, bool enable)
        {
            NativeCalls.godot_icall_4_792(method_bind_109, ptr, RID.GetPtr(joint), (int)axis, (int)flag, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_110 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "generic_6dof_joint_get_flag");

        /// <summary>
        /// <para>Gets a generic_6_DOF_joint flag (see <see cref="Godot.PhysicsServer.G6DOFJointAxisFlag"/> constants).</para>
        /// </summary>
        [GodotMethod("generic_6dof_joint_get_flag")]
        public static bool Generic6dofJointGetFlag(RID joint, Vector3.Axis axis, PhysicsServer.G6DOFJointAxisFlag flag)
        {
            return NativeCalls.godot_icall_3_793(method_bind_110, ptr, RID.GetPtr(joint), (int)axis, (int)flag);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_111 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "free_rid");

        /// <summary>
        /// <para>Destroys any of the objects created by PhysicsServer. If the <see cref="Godot.RID"/> passed is not one of the objects that can be created by PhysicsServer, an error will be sent to the console.</para>
        /// </summary>
        [GodotMethod("free_rid")]
        public static void FreeRid(RID rid)
        {
            NativeCalls.godot_icall_1_285(method_bind_111, ptr, RID.GetPtr(rid));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_112 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_active");

        /// <summary>
        /// <para>Activates or deactivates the 3D physics engine.</para>
        /// </summary>
        [GodotMethod("set_active")]
        public static void SetActive(bool active)
        {
            NativeCalls.godot_icall_1_16(method_bind_112, ptr, active);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_113 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_iterations");

        /// <summary>
        /// <para>Sets the amount of iterations for calculating velocities of colliding bodies. The greater the amount of iterations, the more accurate the collisions will be. However, a greater amount of iterations requires more CPU power, which can decrease performance. The default value is <c>8</c>.</para>
        /// <para>Note: Only has an effect when using the GodotPhysics engine, not the default Bullet physics engine.</para>
        /// </summary>
        [GodotMethod("set_collision_iterations")]
        public static void SetCollisionIterations(int iterations)
        {
            NativeCalls.godot_icall_1_4(method_bind_113, ptr, iterations);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_114 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_process_info");

        /// <summary>
        /// <para>Returns information about the current state of the 3D physics engine. See <see cref="Godot.PhysicsServer.ProcessInfo"/> for a list of available states. Only implemented for Godot Physics.</para>
        /// </summary>
        [GodotMethod("get_process_info")]
        public static int GetProcessInfo(PhysicsServer.ProcessInfo processInfo)
        {
            return NativeCalls.godot_icall_1_11(method_bind_114, ptr, (int)processInfo);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
