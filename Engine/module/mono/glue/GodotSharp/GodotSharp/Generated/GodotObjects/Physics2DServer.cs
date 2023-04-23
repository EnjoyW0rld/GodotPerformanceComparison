using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Physics2DServer is the server responsible for all 2D physics. It can create many kinds of physics objects, but does not insert them on the node tree.</para>
    /// </summary>
    public static partial class Physics2DServer
    {
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

        public enum DampedStringParam
        {
            /// <summary>
            /// <para>Sets the resting length of the spring joint. The joint will always try to go to back this length when pulled apart.</para>
            /// </summary>
            RestLength = 0,
            /// <summary>
            /// <para>Sets the stiffness of the spring joint. The joint applies a force equal to the stiffness times the distance from its resting length.</para>
            /// </summary>
            Stiffness = 1,
            /// <summary>
            /// <para>Sets the damping ratio of the spring joint. A value of 0 indicates an undamped spring, while 1 causes the system to reach equilibrium as fast as possible (critical damping).</para>
            /// </summary>
            Damping = 2
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
            /// <para>This is the constant for creating line shapes. A line shape is an infinite line with an origin point, and a normal. Thus, it can be used for front/behind checks.</para>
            /// </summary>
            Line = 0,
            Ray = 1,
            /// <summary>
            /// <para>This is the constant for creating segment shapes. A segment shape is a line from a point A to a point B. It can be checked for intersections.</para>
            /// </summary>
            Segment = 2,
            /// <summary>
            /// <para>This is the constant for creating circle shapes. A circle shape only has a radius. It can be used for intersections and inside/outside checks.</para>
            /// </summary>
            Circle = 3,
            /// <summary>
            /// <para>This is the constant for creating rectangle shapes. A rectangle shape is defined by a width and a height. It can be used for intersections and inside/outside checks.</para>
            /// </summary>
            Rectangle = 4,
            /// <summary>
            /// <para>This is the constant for creating capsule shapes. A capsule shape is defined by a radius and a length. It can be used for intersections and inside/outside checks.</para>
            /// </summary>
            Capsule = 5,
            /// <summary>
            /// <para>This is the constant for creating convex polygon shapes. A polygon is defined by a list of points. It can be used for intersections and inside/outside checks. Unlike the <see cref="Godot.CollisionPolygon2D.Polygon"/> property, polygons modified with <see cref="Godot.Physics2DServer.ShapeSetData"/> do not verify that the points supplied form is a convex polygon.</para>
            /// </summary>
            ConvexPolygon = 6,
            /// <summary>
            /// <para>This is the constant for creating concave polygon shapes. A polygon is defined by a list of points. It can be used for intersections checks, but not for inside/outside checks.</para>
            /// </summary>
            ConcavePolygon = 7,
            /// <summary>
            /// <para>This constant is used internally by the engine. Any attempt to create this kind of shape results in an error.</para>
            /// </summary>
            Custom = 8
        }

        public enum JointParam
        {
            Bias = 0,
            MaxBias = 1,
            MaxForce = 2
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
            /// <summary>
            /// <para>Constant to set/get the default solver bias for all physics constraints. A solver bias is a factor controlling how much two objects "rebound", after violating a constraint, to avoid leaving them in that state because of numerical imprecision.</para>
            /// </summary>
            ConstraintDefaultBias = 6
        }

        public enum JointType
        {
            /// <summary>
            /// <para>Constant to create pin joints.</para>
            /// </summary>
            Pin = 0,
            /// <summary>
            /// <para>Constant to create groove joints.</para>
            /// </summary>
            Groove = 1,
            /// <summary>
            /// <para>Constant to create damped spring joints.</para>
            /// </summary>
            DampedSpring = 2
        }

        public enum CCDMode
        {
            /// <summary>
            /// <para>Disables continuous collision detection. This is the fastest way to detect body collisions, but can miss small, fast-moving objects.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>Enables continuous collision detection by raycasting. It is faster than shapecasting, but less precise.</para>
            /// </summary>
            CastRay = 1,
            /// <summary>
            /// <para>Enables continuous collision detection by shapecasting. It is the slowest CCD method, and the most precise.</para>
            /// </summary>
            CastShape = 2
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
            /// <para>Constant to set/get a body's inertia.</para>
            /// </summary>
            Inertia = 3,
            /// <summary>
            /// <para>Constant to set/get a body's gravity multiplier.</para>
            /// </summary>
            GravityScale = 4,
            /// <summary>
            /// <para>Constant to set/get a body's linear dampening factor.</para>
            /// </summary>
            LinearDamp = 5,
            /// <summary>
            /// <para>Constant to set/get a body's angular dampening factor.</para>
            /// </summary>
            AngularDamp = 6,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.Physics2DServer.BodyParameter"/> enum.</para>
            /// </summary>
            Max = 7
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
            /// <para>This constant was used to set/get the falloff factor for point gravity. It has been superseded by <see cref="Godot.Physics2DServer.AreaParameter.GravityDistanceScale"/>.</para>
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
                    singleton = Engine.GetSingleton(typeof(Physics2DServer).Name);
                return singleton;
            }
        }

        private const string nativeName = "Physics2DServer";
        internal static IntPtr ptr = NativeCalls.godot_icall_Physics2DServer_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "line_shape_create");

        [GodotMethod("line_shape_create")]
        public static RID LineShapeCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_0, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "ray_shape_create");

        [GodotMethod("ray_shape_create")]
        public static RID RayShapeCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_1, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "segment_shape_create");

        [GodotMethod("segment_shape_create")]
        public static RID SegmentShapeCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_2, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "circle_shape_create");

        [GodotMethod("circle_shape_create")]
        public static RID CircleShapeCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_3, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rectangle_shape_create");

        [GodotMethod("rectangle_shape_create")]
        public static RID RectangleShapeCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_4, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "capsule_shape_create");

        [GodotMethod("capsule_shape_create")]
        public static RID CapsuleShapeCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_5, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "convex_polygon_shape_create");

        [GodotMethod("convex_polygon_shape_create")]
        public static RID ConvexPolygonShapeCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_6, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "concave_polygon_shape_create");

        [GodotMethod("concave_polygon_shape_create")]
        public static RID ConcavePolygonShapeCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_7, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shape_set_data");

        /// <summary>
        /// <para>Sets the shape data that defines its shape and size. The data to be passed depends on the kind of shape created <see cref="Godot.Physics2DServer.ShapeGetType"/>.</para>
        /// </summary>
        [GodotMethod("shape_set_data")]
        public static void ShapeSetData(RID shape, object data)
        {
            NativeCalls.godot_icall_2_741(method_bind_8, ptr, RID.GetPtr(shape), data);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shape_get_type");

        /// <summary>
        /// <para>Returns a shape's type (see <see cref="Godot.Physics2DServer.ShapeType"/>).</para>
        /// </summary>
        [GodotMethod("shape_get_type")]
        public static Physics2DServer.ShapeType ShapeGetType(RID shape)
        {
            return (Physics2DServer.ShapeType)NativeCalls.godot_icall_1_742(method_bind_9, ptr, RID.GetPtr(shape));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shape_get_data");

        /// <summary>
        /// <para>Returns the shape data.</para>
        /// </summary>
        [GodotMethod("shape_get_data")]
        public static object ShapeGetData(RID shape)
        {
            return NativeCalls.godot_icall_1_743(method_bind_10, ptr, RID.GetPtr(shape));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "space_create");

        /// <summary>
        /// <para>Creates a space. A space is a collection of parameters for the physics engine that can be assigned to an area or a body. It can be assigned to an area with <see cref="Godot.Physics2DServer.AreaSetSpace"/>, or to a body with <see cref="Godot.Physics2DServer.BodySetSpace"/>.</para>
        /// </summary>
        [GodotMethod("space_create")]
        public static RID SpaceCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_11, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "space_set_active");

        /// <summary>
        /// <para>Marks a space as active. It will not have an effect, unless it is assigned to an area or body.</para>
        /// </summary>
        [GodotMethod("space_set_active")]
        public static void SpaceSetActive(RID space, bool active)
        {
            NativeCalls.godot_icall_2_628(method_bind_12, ptr, RID.GetPtr(space), active);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "space_is_active");

        /// <summary>
        /// <para>Returns whether the space is active.</para>
        /// </summary>
        [GodotMethod("space_is_active")]
        public static bool SpaceIsActive(RID space)
        {
            return NativeCalls.godot_icall_1_629(method_bind_13, ptr, RID.GetPtr(space));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "space_set_param");

        /// <summary>
        /// <para>Sets the value for a space parameter. See <see cref="Godot.Physics2DServer.SpaceParameter"/> for a list of available parameters.</para>
        /// </summary>
        [GodotMethod("space_set_param")]
        public static void SpaceSetParam(RID space, Physics2DServer.SpaceParameter param, float value)
        {
            NativeCalls.godot_icall_3_744(method_bind_14, ptr, RID.GetPtr(space), (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "space_get_param");

        /// <summary>
        /// <para>Returns the value of a space parameter.</para>
        /// </summary>
        [GodotMethod("space_get_param")]
        public static float SpaceGetParam(RID space, Physics2DServer.SpaceParameter param)
        {
            return NativeCalls.godot_icall_2_745(method_bind_15, ptr, RID.GetPtr(space), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "space_get_direct_state");

        /// <summary>
        /// <para>Returns the state of a space, a <see cref="Godot.Physics2DDirectSpaceState"/>. This object can be used to make collision/intersection queries.</para>
        /// </summary>
        [GodotMethod("space_get_direct_state")]
        public static Physics2DDirectSpaceState SpaceGetDirectState(RID space)
        {
            return NativeCalls.godot_icall_1_746(method_bind_16, ptr, RID.GetPtr(space));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_create");

        /// <summary>
        /// <para>Creates an <see cref="Godot.Area2D"/>. After creating an <see cref="Godot.Area2D"/> with this method, assign it to a space using <see cref="Godot.Physics2DServer.AreaSetSpace"/> to use the created <see cref="Godot.Area2D"/> in the physics world.</para>
        /// </summary>
        [GodotMethod("area_create")]
        public static RID AreaCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_17, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_space");

        /// <summary>
        /// <para>Assigns a space to the area.</para>
        /// </summary>
        [GodotMethod("area_set_space")]
        public static void AreaSetSpace(RID area, RID space)
        {
            NativeCalls.godot_icall_2_637(method_bind_18, ptr, RID.GetPtr(area), RID.GetPtr(space));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_get_space");

        /// <summary>
        /// <para>Returns the space assigned to the area.</para>
        /// </summary>
        [GodotMethod("area_get_space")]
        public static RID AreaGetSpace(RID area)
        {
            return new RID(NativeCalls.godot_icall_1_638(method_bind_19, ptr, RID.GetPtr(area)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_space_override_mode");

        /// <summary>
        /// <para>Sets the space override mode for the area. See <see cref="Godot.Physics2DServer.AreaSpaceOverrideMode"/> for a list of available modes.</para>
        /// </summary>
        [GodotMethod("area_set_space_override_mode")]
        public static void AreaSetSpaceOverrideMode(RID area, Physics2DServer.AreaSpaceOverrideMode mode)
        {
            NativeCalls.godot_icall_2_645(method_bind_20, ptr, RID.GetPtr(area), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_get_space_override_mode");

        /// <summary>
        /// <para>Returns the space override mode for the area.</para>
        /// </summary>
        [GodotMethod("area_get_space_override_mode")]
        public static Physics2DServer.AreaSpaceOverrideMode AreaGetSpaceOverrideMode(RID area)
        {
            return (Physics2DServer.AreaSpaceOverrideMode)NativeCalls.godot_icall_1_747(method_bind_21, ptr, RID.GetPtr(area));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_add_shape");

        /// <summary>
        /// <para>Adds a shape to the area, along with a transform matrix. Shapes are usually referenced by their index, so you should track which shape has a given index.</para>
        /// </summary>
        /// <param name="transform">If the parameter is null, then the default value is Transform2D.Identity</param>
        [GodotMethod("area_add_shape")]
        public static void AreaAddShape(RID area, RID shape, Nullable<Transform2D> transform = null, bool disabled = false)
        {
            Transform2D transform_in = transform.HasValue ? transform.Value : Transform2D.Identity;
            NativeCalls.godot_icall_4_748(method_bind_22, ptr, RID.GetPtr(area), RID.GetPtr(shape), ref transform_in, disabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_shape");

        /// <summary>
        /// <para>Substitutes a given area shape by another. The old shape is selected by its index, the new one by its <see cref="Godot.RID"/>.</para>
        /// </summary>
        [GodotMethod("area_set_shape")]
        public static void AreaSetShape(RID area, int shapeIdx, RID shape)
        {
            NativeCalls.godot_icall_3_749(method_bind_23, ptr, RID.GetPtr(area), shapeIdx, RID.GetPtr(shape));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_shape_transform");

        /// <summary>
        /// <para>Sets the transform matrix for an area shape.</para>
        /// </summary>
        [GodotMethod("area_set_shape_transform")]
        public static void AreaSetShapeTransform(RID area, int shapeIdx, Transform2D transform)
        {
            NativeCalls.godot_icall_3_750(method_bind_24, ptr, RID.GetPtr(area), shapeIdx, ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_shape_disabled");

        /// <summary>
        /// <para>Disables a given shape in an area.</para>
        /// </summary>
        [GodotMethod("area_set_shape_disabled")]
        public static void AreaSetShapeDisabled(RID area, int shapeIdx, bool disabled)
        {
            NativeCalls.godot_icall_3_751(method_bind_25, ptr, RID.GetPtr(area), shapeIdx, disabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_get_shape_count");

        /// <summary>
        /// <para>Returns the number of shapes assigned to an area.</para>
        /// </summary>
        [GodotMethod("area_get_shape_count")]
        public static int AreaGetShapeCount(RID area)
        {
            return NativeCalls.godot_icall_1_643(method_bind_26, ptr, RID.GetPtr(area));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_get_shape");

        /// <summary>
        /// <para>Returns the <see cref="Godot.RID"/> of the nth shape of an area.</para>
        /// </summary>
        [GodotMethod("area_get_shape")]
        public static RID AreaGetShape(RID area, int shapeIdx)
        {
            return new RID(NativeCalls.godot_icall_2_752(method_bind_27, ptr, RID.GetPtr(area), shapeIdx));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_get_shape_transform");

        /// <summary>
        /// <para>Returns the transform matrix of a shape within an area.</para>
        /// </summary>
        [GodotMethod("area_get_shape_transform")]
        public static Transform2D AreaGetShapeTransform(RID area, int shapeIdx)
        {
            NativeCalls.godot_icall_2_753(method_bind_28, ptr, RID.GetPtr(area), shapeIdx, out Transform2D argRet); return (Transform2D)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_remove_shape");

        /// <summary>
        /// <para>Removes a shape from an area. It does not delete the shape, so it can be reassigned later.</para>
        /// </summary>
        [GodotMethod("area_remove_shape")]
        public static void AreaRemoveShape(RID area, int shapeIdx)
        {
            NativeCalls.godot_icall_2_645(method_bind_29, ptr, RID.GetPtr(area), shapeIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_clear_shapes");

        /// <summary>
        /// <para>Removes all shapes from an area. It does not delete the shapes, so they can be reassigned later.</para>
        /// </summary>
        [GodotMethod("area_clear_shapes")]
        public static void AreaClearShapes(RID area)
        {
            NativeCalls.godot_icall_1_285(method_bind_30, ptr, RID.GetPtr(area));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_collision_layer");

        /// <summary>
        /// <para>Assigns the area to one or many physics layers.</para>
        /// </summary>
        [GodotMethod("area_set_collision_layer")]
        public static void AreaSetCollisionLayer(RID area, uint layer)
        {
            NativeCalls.godot_icall_2_639(method_bind_31, ptr, RID.GetPtr(area), layer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_collision_mask");

        /// <summary>
        /// <para>Sets which physics layers the area will monitor.</para>
        /// </summary>
        [GodotMethod("area_set_collision_mask")]
        public static void AreaSetCollisionMask(RID area, uint mask)
        {
            NativeCalls.godot_icall_2_639(method_bind_32, ptr, RID.GetPtr(area), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_param");

        /// <summary>
        /// <para>Sets the value for an area parameter. See <see cref="Godot.Physics2DServer.AreaParameter"/> for a list of available parameters.</para>
        /// </summary>
        [GodotMethod("area_set_param")]
        public static void AreaSetParam(RID area, Physics2DServer.AreaParameter param, object value)
        {
            NativeCalls.godot_icall_3_754(method_bind_33, ptr, RID.GetPtr(area), (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_transform");

        /// <summary>
        /// <para>Sets the transform matrix for an area.</para>
        /// </summary>
        [GodotMethod("area_set_transform")]
        public static void AreaSetTransform(RID area, Transform2D transform)
        {
            NativeCalls.godot_icall_2_641(method_bind_34, ptr, RID.GetPtr(area), ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_get_param");

        /// <summary>
        /// <para>Returns an area parameter value. See <see cref="Godot.Physics2DServer.AreaParameter"/> for a list of available parameters.</para>
        /// </summary>
        [GodotMethod("area_get_param")]
        public static object AreaGetParam(RID area, Physics2DServer.AreaParameter param)
        {
            return NativeCalls.godot_icall_2_755(method_bind_35, ptr, RID.GetPtr(area), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_get_transform");

        /// <summary>
        /// <para>Returns the transform matrix for an area.</para>
        /// </summary>
        [GodotMethod("area_get_transform")]
        public static Transform2D AreaGetTransform(RID area)
        {
            NativeCalls.godot_icall_1_756(method_bind_36, ptr, RID.GetPtr(area), out Transform2D argRet); return (Transform2D)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_attach_object_instance_id");

        /// <summary>
        /// <para>Assigns the area to a descendant of <see cref="Godot.Object"/>, so it can exist in the node tree.</para>
        /// </summary>
        [GodotMethod("area_attach_object_instance_id")]
        public static void AreaAttachObjectInstanceId(RID area, ulong id)
        {
            NativeCalls.godot_icall_2_757(method_bind_37, ptr, RID.GetPtr(area), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_get_object_instance_id");

        /// <summary>
        /// <para>Gets the instance ID of the object the area is assigned to.</para>
        /// </summary>
        [GodotMethod("area_get_object_instance_id")]
        public static ulong AreaGetObjectInstanceId(RID area)
        {
            return NativeCalls.godot_icall_1_758(method_bind_38, ptr, RID.GetPtr(area));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_attach_canvas_instance_id");

        [GodotMethod("area_attach_canvas_instance_id")]
        public static void AreaAttachCanvasInstanceId(RID area, ulong id)
        {
            NativeCalls.godot_icall_2_757(method_bind_39, ptr, RID.GetPtr(area), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_get_canvas_instance_id");

        [GodotMethod("area_get_canvas_instance_id")]
        public static ulong AreaGetCanvasInstanceId(RID area)
        {
            return NativeCalls.godot_icall_1_758(method_bind_40, ptr, RID.GetPtr(area));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_monitor_callback");

        /// <summary>
        /// <para>Sets the function to call when any body/area enters or exits the area. This callback will be called for any object interacting with the area, and takes five parameters:</para>
        /// <para>1: <see cref="Godot.Physics2DServer.AreaBodyStatus.Added"/> or <see cref="Godot.Physics2DServer.AreaBodyStatus.Removed"/>, depending on whether the object entered or exited the area.</para>
        /// <para>2: <see cref="Godot.RID"/> of the object that entered/exited the area.</para>
        /// <para>3: Instance ID of the object that entered/exited the area.</para>
        /// <para>4: The shape index of the object that entered/exited the area.</para>
        /// <para>5: The shape index of the area where the object entered/exited.</para>
        /// </summary>
        [GodotMethod("area_set_monitor_callback")]
        public static void AreaSetMonitorCallback(RID area, Object receiver, string method)
        {
            NativeCalls.godot_icall_3_759(method_bind_41, ptr, RID.GetPtr(area), Object.GetPtr(receiver), method);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_area_monitor_callback");

        [GodotMethod("area_set_area_monitor_callback")]
        public static void AreaSetAreaMonitorCallback(RID area, Object receiver, string method)
        {
            NativeCalls.godot_icall_3_759(method_bind_42, ptr, RID.GetPtr(area), Object.GetPtr(receiver), method);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "area_set_monitorable");

        [GodotMethod("area_set_monitorable")]
        public static void AreaSetMonitorable(RID area, bool monitorable)
        {
            NativeCalls.godot_icall_2_628(method_bind_43, ptr, RID.GetPtr(area), monitorable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_create");

        /// <summary>
        /// <para>Creates a physics body.</para>
        /// </summary>
        [GodotMethod("body_create")]
        public static RID BodyCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_44, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_space");

        /// <summary>
        /// <para>Assigns a space to the body (see <see cref="Godot.Physics2DServer.SpaceCreate"/>).</para>
        /// </summary>
        [GodotMethod("body_set_space")]
        public static void BodySetSpace(RID body, RID space)
        {
            NativeCalls.godot_icall_2_637(method_bind_45, ptr, RID.GetPtr(body), RID.GetPtr(space));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_space");

        /// <summary>
        /// <para>Returns the <see cref="Godot.RID"/> of the space assigned to a body.</para>
        /// </summary>
        [GodotMethod("body_get_space")]
        public static RID BodyGetSpace(RID body)
        {
            return new RID(NativeCalls.godot_icall_1_638(method_bind_46, ptr, RID.GetPtr(body)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_mode");

        /// <summary>
        /// <para>Sets the body mode using one of the <see cref="Godot.Physics2DServer.BodyMode"/> constants.</para>
        /// </summary>
        [GodotMethod("body_set_mode")]
        public static void BodySetMode(RID body, Physics2DServer.BodyMode mode)
        {
            NativeCalls.godot_icall_2_645(method_bind_47, ptr, RID.GetPtr(body), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_mode");

        /// <summary>
        /// <para>Returns the body mode.</para>
        /// </summary>
        [GodotMethod("body_get_mode")]
        public static Physics2DServer.BodyMode BodyGetMode(RID body)
        {
            return (Physics2DServer.BodyMode)NativeCalls.godot_icall_1_760(method_bind_48, ptr, RID.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_add_shape");

        /// <summary>
        /// <para>Adds a shape to the body, along with a transform matrix. Shapes are usually referenced by their index, so you should track which shape has a given index.</para>
        /// </summary>
        /// <param name="transform">If the parameter is null, then the default value is Transform2D.Identity</param>
        [GodotMethod("body_add_shape")]
        public static void BodyAddShape(RID body, RID shape, Nullable<Transform2D> transform = null, bool disabled = false)
        {
            Transform2D transform_in = transform.HasValue ? transform.Value : Transform2D.Identity;
            NativeCalls.godot_icall_4_748(method_bind_49, ptr, RID.GetPtr(body), RID.GetPtr(shape), ref transform_in, disabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_shape");

        /// <summary>
        /// <para>Substitutes a given body shape by another. The old shape is selected by its index, the new one by its <see cref="Godot.RID"/>.</para>
        /// </summary>
        [GodotMethod("body_set_shape")]
        public static void BodySetShape(RID body, int shapeIdx, RID shape)
        {
            NativeCalls.godot_icall_3_749(method_bind_50, ptr, RID.GetPtr(body), shapeIdx, RID.GetPtr(shape));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_shape_transform");

        /// <summary>
        /// <para>Sets the transform matrix for a body shape.</para>
        /// </summary>
        [GodotMethod("body_set_shape_transform")]
        public static void BodySetShapeTransform(RID body, int shapeIdx, Transform2D transform)
        {
            NativeCalls.godot_icall_3_750(method_bind_51, ptr, RID.GetPtr(body), shapeIdx, ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_shape_metadata");

        /// <summary>
        /// <para>Sets metadata of a shape within a body. This metadata is different from <see cref="Godot.Object.SetMeta"/>, and can be retrieved on shape queries.</para>
        /// </summary>
        [GodotMethod("body_set_shape_metadata")]
        public static void BodySetShapeMetadata(RID body, int shapeIdx, object metadata)
        {
            NativeCalls.godot_icall_3_754(method_bind_52, ptr, RID.GetPtr(body), shapeIdx, metadata);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_53 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_shape_count");

        /// <summary>
        /// <para>Returns the number of shapes assigned to a body.</para>
        /// </summary>
        [GodotMethod("body_get_shape_count")]
        public static int BodyGetShapeCount(RID body)
        {
            return NativeCalls.godot_icall_1_643(method_bind_53, ptr, RID.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_54 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_shape");

        /// <summary>
        /// <para>Returns the <see cref="Godot.RID"/> of the nth shape of a body.</para>
        /// </summary>
        [GodotMethod("body_get_shape")]
        public static RID BodyGetShape(RID body, int shapeIdx)
        {
            return new RID(NativeCalls.godot_icall_2_752(method_bind_54, ptr, RID.GetPtr(body), shapeIdx));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_55 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_shape_transform");

        /// <summary>
        /// <para>Returns the transform matrix of a body shape.</para>
        /// </summary>
        [GodotMethod("body_get_shape_transform")]
        public static Transform2D BodyGetShapeTransform(RID body, int shapeIdx)
        {
            NativeCalls.godot_icall_2_753(method_bind_55, ptr, RID.GetPtr(body), shapeIdx, out Transform2D argRet); return (Transform2D)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_56 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_shape_metadata");

        /// <summary>
        /// <para>Returns the metadata of a shape of a body.</para>
        /// </summary>
        [GodotMethod("body_get_shape_metadata")]
        public static object BodyGetShapeMetadata(RID body, int shapeIdx)
        {
            return NativeCalls.godot_icall_2_755(method_bind_56, ptr, RID.GetPtr(body), shapeIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_57 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_remove_shape");

        /// <summary>
        /// <para>Removes a shape from a body. The shape is not deleted, so it can be reused afterwards.</para>
        /// </summary>
        [GodotMethod("body_remove_shape")]
        public static void BodyRemoveShape(RID body, int shapeIdx)
        {
            NativeCalls.godot_icall_2_645(method_bind_57, ptr, RID.GetPtr(body), shapeIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_58 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_clear_shapes");

        /// <summary>
        /// <para>Removes all shapes from a body.</para>
        /// </summary>
        [GodotMethod("body_clear_shapes")]
        public static void BodyClearShapes(RID body)
        {
            NativeCalls.godot_icall_1_285(method_bind_58, ptr, RID.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_59 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_shape_disabled");

        /// <summary>
        /// <para>Disables shape in body if <c>disable</c> is <c>true</c>.</para>
        /// </summary>
        [GodotMethod("body_set_shape_disabled")]
        public static void BodySetShapeDisabled(RID body, int shapeIdx, bool disabled)
        {
            NativeCalls.godot_icall_3_751(method_bind_59, ptr, RID.GetPtr(body), shapeIdx, disabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_60 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_shape_as_one_way_collision");

        /// <summary>
        /// <para>Enables one way collision on body if <c>enable</c> is <c>true</c>.</para>
        /// </summary>
        [GodotMethod("body_set_shape_as_one_way_collision")]
        public static void BodySetShapeAsOneWayCollision(RID body, int shapeIdx, bool enable, float margin)
        {
            NativeCalls.godot_icall_4_761(method_bind_60, ptr, RID.GetPtr(body), shapeIdx, enable, margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_61 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_attach_object_instance_id");

        /// <summary>
        /// <para>Assigns the area to a descendant of <see cref="Godot.Object"/>, so it can exist in the node tree.</para>
        /// </summary>
        [GodotMethod("body_attach_object_instance_id")]
        public static void BodyAttachObjectInstanceId(RID body, uint id)
        {
            NativeCalls.godot_icall_2_639(method_bind_61, ptr, RID.GetPtr(body), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_62 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_object_instance_id");

        /// <summary>
        /// <para>Gets the instance ID of the object the area is assigned to.</para>
        /// </summary>
        [GodotMethod("body_get_object_instance_id")]
        public static uint BodyGetObjectInstanceId(RID body)
        {
            return NativeCalls.godot_icall_1_640(method_bind_62, ptr, RID.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_63 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_attach_canvas_instance_id");

        [GodotMethod("body_attach_canvas_instance_id")]
        public static void BodyAttachCanvasInstanceId(RID body, uint id)
        {
            NativeCalls.godot_icall_2_639(method_bind_63, ptr, RID.GetPtr(body), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_64 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_canvas_instance_id");

        [GodotMethod("body_get_canvas_instance_id")]
        public static uint BodyGetCanvasInstanceId(RID body)
        {
            return NativeCalls.godot_icall_1_640(method_bind_64, ptr, RID.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_65 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_continuous_collision_detection_mode");

        /// <summary>
        /// <para>Sets the continuous collision detection mode using one of the <see cref="Godot.Physics2DServer.CCDMode"/> constants.</para>
        /// <para>Continuous collision detection tries to predict where a moving body will collide, instead of moving it and correcting its movement if it collided.</para>
        /// </summary>
        [GodotMethod("body_set_continuous_collision_detection_mode")]
        public static void BodySetContinuousCollisionDetectionMode(RID body, Physics2DServer.CCDMode mode)
        {
            NativeCalls.godot_icall_2_645(method_bind_65, ptr, RID.GetPtr(body), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_66 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_continuous_collision_detection_mode");

        /// <summary>
        /// <para>Returns the continuous collision detection mode.</para>
        /// </summary>
        [GodotMethod("body_get_continuous_collision_detection_mode")]
        public static Physics2DServer.CCDMode BodyGetContinuousCollisionDetectionMode(RID body)
        {
            return (Physics2DServer.CCDMode)NativeCalls.godot_icall_1_762(method_bind_66, ptr, RID.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_67 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_collision_layer");

        /// <summary>
        /// <para>Sets the physics layer or layers a body belongs to.</para>
        /// </summary>
        [GodotMethod("body_set_collision_layer")]
        public static void BodySetCollisionLayer(RID body, uint layer)
        {
            NativeCalls.godot_icall_2_639(method_bind_67, ptr, RID.GetPtr(body), layer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_68 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_collision_layer");

        /// <summary>
        /// <para>Returns the physics layer or layers a body belongs to.</para>
        /// </summary>
        [GodotMethod("body_get_collision_layer")]
        public static uint BodyGetCollisionLayer(RID body)
        {
            return NativeCalls.godot_icall_1_640(method_bind_68, ptr, RID.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_69 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_collision_mask");

        /// <summary>
        /// <para>Sets the physics layer or layers a body can collide with.</para>
        /// </summary>
        [GodotMethod("body_set_collision_mask")]
        public static void BodySetCollisionMask(RID body, uint mask)
        {
            NativeCalls.godot_icall_2_639(method_bind_69, ptr, RID.GetPtr(body), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_70 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_collision_mask");

        /// <summary>
        /// <para>Returns the physics layer or layers a body can collide with.</para>
        /// </summary>
        [GodotMethod("body_get_collision_mask")]
        public static uint BodyGetCollisionMask(RID body)
        {
            return NativeCalls.godot_icall_1_640(method_bind_70, ptr, RID.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_71 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_param");

        /// <summary>
        /// <para>Sets a body parameter. See <see cref="Godot.Physics2DServer.BodyParameter"/> for a list of available parameters.</para>
        /// </summary>
        [GodotMethod("body_set_param")]
        public static void BodySetParam(RID body, Physics2DServer.BodyParameter param, float value)
        {
            NativeCalls.godot_icall_3_744(method_bind_71, ptr, RID.GetPtr(body), (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_72 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_param");

        /// <summary>
        /// <para>Returns the value of a body parameter. See <see cref="Godot.Physics2DServer.BodyParameter"/> for a list of available parameters.</para>
        /// </summary>
        [GodotMethod("body_get_param")]
        public static float BodyGetParam(RID body, Physics2DServer.BodyParameter param)
        {
            return NativeCalls.godot_icall_2_745(method_bind_72, ptr, RID.GetPtr(body), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_73 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_state");

        /// <summary>
        /// <para>Sets a body state using one of the <see cref="Godot.Physics2DServer.BodyState"/> constants.</para>
        /// <para>Note that the method doesn't take effect immediately. The state will change on the next physics frame.</para>
        /// </summary>
        [GodotMethod("body_set_state")]
        public static void BodySetState(RID body, Physics2DServer.BodyState state, object value)
        {
            NativeCalls.godot_icall_3_754(method_bind_73, ptr, RID.GetPtr(body), (int)state, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_74 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_state");

        /// <summary>
        /// <para>Returns a body state.</para>
        /// </summary>
        [GodotMethod("body_get_state")]
        public static object BodyGetState(RID body, Physics2DServer.BodyState state)
        {
            return NativeCalls.godot_icall_2_755(method_bind_74, ptr, RID.GetPtr(body), (int)state);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_75 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_apply_central_impulse");

        [GodotMethod("body_apply_central_impulse")]
        public static void BodyApplyCentralImpulse(RID body, Vector2 impulse)
        {
            NativeCalls.godot_icall_2_646(method_bind_75, ptr, RID.GetPtr(body), ref impulse);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_76 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_apply_torque_impulse");

        [GodotMethod("body_apply_torque_impulse")]
        public static void BodyApplyTorqueImpulse(RID body, float impulse)
        {
            NativeCalls.godot_icall_2_630(method_bind_76, ptr, RID.GetPtr(body), impulse);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_77 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_apply_impulse");

        /// <summary>
        /// <para>Adds a positioned impulse to the applied force and torque. Both the force and the offset from the body origin are in global coordinates.</para>
        /// </summary>
        [GodotMethod("body_apply_impulse")]
        public static void BodyApplyImpulse(RID body, Vector2 position, Vector2 impulse)
        {
            NativeCalls.godot_icall_3_763(method_bind_77, ptr, RID.GetPtr(body), ref position, ref impulse);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_78 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_add_central_force");

        [GodotMethod("body_add_central_force")]
        public static void BodyAddCentralForce(RID body, Vector2 force)
        {
            NativeCalls.godot_icall_2_646(method_bind_78, ptr, RID.GetPtr(body), ref force);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_79 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_add_force");

        /// <summary>
        /// <para>Adds a positioned force to the applied force and torque. As with <see cref="Godot.Physics2DServer.BodyApplyImpulse"/>, both the force and the offset from the body origin are in global coordinates. A force differs from an impulse in that, while the two are forces, the impulse clears itself after being applied.</para>
        /// </summary>
        [GodotMethod("body_add_force")]
        public static void BodyAddForce(RID body, Vector2 offset, Vector2 force)
        {
            NativeCalls.godot_icall_3_763(method_bind_79, ptr, RID.GetPtr(body), ref offset, ref force);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_80 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_add_torque");

        [GodotMethod("body_add_torque")]
        public static void BodyAddTorque(RID body, float torque)
        {
            NativeCalls.godot_icall_2_630(method_bind_80, ptr, RID.GetPtr(body), torque);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_81 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_axis_velocity");

        /// <summary>
        /// <para>Sets an axis velocity. The velocity in the given vector axis will be set as the given vector length. This is useful for jumping behavior.</para>
        /// </summary>
        [GodotMethod("body_set_axis_velocity")]
        public static void BodySetAxisVelocity(RID body, Vector2 axisVelocity)
        {
            NativeCalls.godot_icall_2_646(method_bind_81, ptr, RID.GetPtr(body), ref axisVelocity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_82 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_add_collision_exception");

        /// <summary>
        /// <para>Adds a body to the list of bodies exempt from collisions.</para>
        /// </summary>
        [GodotMethod("body_add_collision_exception")]
        public static void BodyAddCollisionException(RID body, RID exceptedBody)
        {
            NativeCalls.godot_icall_2_637(method_bind_82, ptr, RID.GetPtr(body), RID.GetPtr(exceptedBody));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_83 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_remove_collision_exception");

        /// <summary>
        /// <para>Removes a body from the list of bodies exempt from collisions.</para>
        /// </summary>
        [GodotMethod("body_remove_collision_exception")]
        public static void BodyRemoveCollisionException(RID body, RID exceptedBody)
        {
            NativeCalls.godot_icall_2_637(method_bind_83, ptr, RID.GetPtr(body), RID.GetPtr(exceptedBody));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_84 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_max_contacts_reported");

        /// <summary>
        /// <para>Sets the maximum contacts to report. Bodies can keep a log of the contacts with other bodies, this is enabled by setting the maximum amount of contacts reported to a number greater than 0.</para>
        /// </summary>
        [GodotMethod("body_set_max_contacts_reported")]
        public static void BodySetMaxContactsReported(RID body, int amount)
        {
            NativeCalls.godot_icall_2_645(method_bind_84, ptr, RID.GetPtr(body), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_85 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_max_contacts_reported");

        /// <summary>
        /// <para>Returns the maximum contacts that can be reported. See <see cref="Godot.Physics2DServer.BodySetMaxContactsReported"/>.</para>
        /// </summary>
        [GodotMethod("body_get_max_contacts_reported")]
        public static int BodyGetMaxContactsReported(RID body)
        {
            return NativeCalls.godot_icall_1_643(method_bind_85, ptr, RID.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_86 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_omit_force_integration");

        /// <summary>
        /// <para>Sets whether a body uses a callback function to calculate its own physics (see <see cref="Godot.Physics2DServer.BodySetForceIntegrationCallback"/>).</para>
        /// </summary>
        [GodotMethod("body_set_omit_force_integration")]
        public static void BodySetOmitForceIntegration(RID body, bool enable)
        {
            NativeCalls.godot_icall_2_628(method_bind_86, ptr, RID.GetPtr(body), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_87 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_is_omitting_force_integration");

        /// <summary>
        /// <para>Returns whether a body uses a callback function to calculate its own physics (see <see cref="Godot.Physics2DServer.BodySetForceIntegrationCallback"/>).</para>
        /// </summary>
        [GodotMethod("body_is_omitting_force_integration")]
        public static bool BodyIsOmittingForceIntegration(RID body)
        {
            return NativeCalls.godot_icall_1_629(method_bind_87, ptr, RID.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_88 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_set_force_integration_callback");

        /// <summary>
        /// <para>Sets the function used to calculate physics for an object, if that object allows it (see <see cref="Godot.Physics2DServer.BodySetOmitForceIntegration"/>).</para>
        /// </summary>
        [GodotMethod("body_set_force_integration_callback")]
        public static void BodySetForceIntegrationCallback(RID body, Object receiver, string method, object userdata = null)
        {
            NativeCalls.godot_icall_4_647(method_bind_88, ptr, RID.GetPtr(body), Object.GetPtr(receiver), method, userdata);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_89 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_test_motion");

        /// <summary>
        /// <para>Returns <c>true</c> if a collision would result from moving in the given direction from a given point in space. Margin increases the size of the shapes involved in the collision detection. <see cref="Godot.Physics2DTestMotionResult"/> can be passed to return additional information in.</para>
        /// </summary>
        /// <param name="exclude">If the parameter is null, then the default value is new Godot.Collections.Array { }</param>
        [GodotMethod("body_test_motion")]
        public static bool BodyTestMotion(RID body, Transform2D from, Vector2 motion, bool infiniteInertia, float margin = 0.08f, Physics2DTestMotionResult result = null, bool excludeRaycastShapes = true, Godot.Collections.Array exclude = null)
        {
            Godot.Collections.Array exclude_in = exclude != null ? exclude : new Godot.Collections.Array { };
            return NativeCalls.godot_icall_8_764(method_bind_89, ptr, RID.GetPtr(body), ref from, ref motion, infiniteInertia, margin, Object.GetPtr(result), excludeRaycastShapes, exclude_in.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_90 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "body_get_direct_state");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Physics2DDirectBodyState"/> of the body. Returns <c>null</c> if the body is destroyed or removed from the physics space.</para>
        /// </summary>
        [GodotMethod("body_get_direct_state")]
        public static Physics2DDirectBodyState BodyGetDirectState(RID body)
        {
            return NativeCalls.godot_icall_1_765(method_bind_90, ptr, RID.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_91 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "joint_set_param");

        /// <summary>
        /// <para>Sets a joint parameter. See <see cref="Godot.Physics2DServer.JointParam"/> for a list of available parameters.</para>
        /// </summary>
        [GodotMethod("joint_set_param")]
        public static void JointSetParam(RID joint, Physics2DServer.JointParam param, float value)
        {
            NativeCalls.godot_icall_3_744(method_bind_91, ptr, RID.GetPtr(joint), (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_92 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "joint_get_param");

        /// <summary>
        /// <para>Returns the value of a joint parameter.</para>
        /// </summary>
        [GodotMethod("joint_get_param")]
        public static float JointGetParam(RID joint, Physics2DServer.JointParam param)
        {
            return NativeCalls.godot_icall_2_745(method_bind_92, ptr, RID.GetPtr(joint), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_93 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "pin_joint_create");

        /// <summary>
        /// <para>Creates a pin joint between two bodies. If not specified, the second body is assumed to be the joint itself.</para>
        /// </summary>
        [GodotMethod("pin_joint_create")]
        public static RID PinJointCreate(Vector2 anchor, RID bodyA, RID bodyB = null)
        {
            return new RID(NativeCalls.godot_icall_3_766(method_bind_93, ptr, ref anchor, RID.GetPtr(bodyA), RID.GetPtr(bodyB)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_94 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "groove_joint_create");

        /// <summary>
        /// <para>Creates a groove joint between two bodies. If not specified, the bodies are assumed to be the joint itself.</para>
        /// </summary>
        [GodotMethod("groove_joint_create")]
        public static RID GrooveJointCreate(Vector2 groove1A, Vector2 groove2A, Vector2 anchorB, RID bodyA = null, RID bodyB = null)
        {
            return new RID(NativeCalls.godot_icall_5_767(method_bind_94, ptr, ref groove1A, ref groove2A, ref anchorB, RID.GetPtr(bodyA), RID.GetPtr(bodyB)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_95 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "damped_spring_joint_create");

        /// <summary>
        /// <para>Creates a damped spring joint between two bodies. If not specified, the second body is assumed to be the joint itself.</para>
        /// </summary>
        [GodotMethod("damped_spring_joint_create")]
        public static RID DampedSpringJointCreate(Vector2 anchorA, Vector2 anchorB, RID bodyA, RID bodyB = null)
        {
            return new RID(NativeCalls.godot_icall_4_768(method_bind_95, ptr, ref anchorA, ref anchorB, RID.GetPtr(bodyA), RID.GetPtr(bodyB)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_96 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "damped_string_joint_set_param");

        /// <summary>
        /// <para>Sets a damped spring joint parameter. See <see cref="Godot.Physics2DServer.DampedStringParam"/> for a list of available parameters.</para>
        /// </summary>
        [GodotMethod("damped_string_joint_set_param")]
        public static void DampedStringJointSetParam(RID joint, Physics2DServer.DampedStringParam param, float value)
        {
            NativeCalls.godot_icall_3_744(method_bind_96, ptr, RID.GetPtr(joint), (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_97 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "damped_string_joint_get_param");

        /// <summary>
        /// <para>Returns the value of a damped spring joint parameter.</para>
        /// </summary>
        [GodotMethod("damped_string_joint_get_param")]
        public static float DampedStringJointGetParam(RID joint, Physics2DServer.DampedStringParam param)
        {
            return NativeCalls.godot_icall_2_745(method_bind_97, ptr, RID.GetPtr(joint), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_98 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "joint_get_type");

        /// <summary>
        /// <para>Returns a joint's type (see <see cref="Godot.Physics2DServer.JointType"/>).</para>
        /// </summary>
        [GodotMethod("joint_get_type")]
        public static Physics2DServer.JointType JointGetType(RID joint)
        {
            return (Physics2DServer.JointType)NativeCalls.godot_icall_1_769(method_bind_98, ptr, RID.GetPtr(joint));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_99 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "free_rid");

        /// <summary>
        /// <para>Destroys any of the objects created by Physics2DServer. If the <see cref="Godot.RID"/> passed is not one of the objects that can be created by Physics2DServer, an error will be sent to the console.</para>
        /// </summary>
        [GodotMethod("free_rid")]
        public static void FreeRid(RID rid)
        {
            NativeCalls.godot_icall_1_285(method_bind_99, ptr, RID.GetPtr(rid));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_100 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_active");

        /// <summary>
        /// <para>Activates or deactivates the 2D physics engine.</para>
        /// </summary>
        [GodotMethod("set_active")]
        public static void SetActive(bool active)
        {
            NativeCalls.godot_icall_1_16(method_bind_100, ptr, active);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_101 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_iterations");

        /// <summary>
        /// <para>Sets the amount of iterations for calculating velocities of colliding bodies. The greater the amount of iterations, the more accurate the collisions will be. However, a greater amount of iterations requires more CPU power, which can decrease performance. The default value is <c>8</c>.</para>
        /// </summary>
        [GodotMethod("set_collision_iterations")]
        public static void SetCollisionIterations(int iterations)
        {
            NativeCalls.godot_icall_1_4(method_bind_101, ptr, iterations);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_102 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_process_info");

        /// <summary>
        /// <para>Returns information about the current state of the 2D physics engine. See <see cref="Godot.Physics2DServer.ProcessInfo"/> for a list of available states.</para>
        /// </summary>
        [GodotMethod("get_process_info")]
        public static int GetProcessInfo(Physics2DServer.ProcessInfo processInfo)
        {
            return NativeCalls.godot_icall_1_11(method_bind_102, ptr, (int)processInfo);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
