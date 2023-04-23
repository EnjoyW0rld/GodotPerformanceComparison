using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Direct access object to a space in the <see cref="Godot.PhysicsServer"/>. It's used mainly to do queries against objects and areas residing in a given space.</para>
    /// </summary>
    public abstract partial class PhysicsDirectSpaceState : Object
    {
        private const string nativeName = "PhysicsDirectSpaceState";

        internal PhysicsDirectSpaceState() {}

        internal PhysicsDirectSpaceState(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "intersect_point");

        /// <summary>
        /// <para>Checks whether a point is inside any solid shape. The shapes the point is inside of are returned in an array containing dictionaries with the following fields:</para>
        /// <para><c>collider</c>: The colliding object.</para>
        /// <para><c>collider_id</c>: The colliding object's ID.</para>
        /// <para><c>rid</c>: The intersecting object's <see cref="Godot.RID"/>.</para>
        /// <para><c>shape</c>: The shape index of the colliding shape.</para>
        /// <para>The number of intersections can be limited with the <c>max_results</c> parameter, to reduce the processing time.</para>
        /// <para>Additionally, the method can take an <c>exclude</c> array of objects or <see cref="Godot.RID"/>s that are to be excluded from collisions, a <c>collision_mask</c> bitmask representing the physics layers to check in, or booleans to determine if the ray should collide with <see cref="Godot.PhysicsBody"/>s or <see cref="Godot.Area"/>s, respectively.</para>
        /// </summary>
        /// <param name="exclude">If the parameter is null, then the default value is new Godot.Collections.Array { }</param>
        [GodotMethod("intersect_point")]
        public Godot.Collections.Array IntersectPoint(Vector3 point, int maxResults = 32, Godot.Collections.Array exclude = null, uint collisionLayer = (uint)2147483647, bool collideWithBodies = true, bool collideWithAreas = false)
        {
            Godot.Collections.Array exclude_in = exclude != null ? exclude : new Godot.Collections.Array { };
            return new Godot.Collections.Array(NativeCalls.godot_icall_6_771(method_bind_0, Object.GetPtr(this), ref point, maxResults, exclude_in.GetPtr(), collisionLayer, collideWithBodies, collideWithAreas));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "intersect_ray");

        /// <summary>
        /// <para>Intersects a ray in a given space. The returned object is a dictionary with the following fields:</para>
        /// <para><c>collider</c>: The colliding object.</para>
        /// <para><c>collider_id</c>: The colliding object's ID.</para>
        /// <para><c>normal</c>: The object's surface normal at the intersection point.</para>
        /// <para><c>position</c>: The intersection point.</para>
        /// <para><c>rid</c>: The intersecting object's <see cref="Godot.RID"/>.</para>
        /// <para><c>shape</c>: The shape index of the colliding shape.</para>
        /// <para>If the ray did not intersect anything, then an empty dictionary is returned instead.</para>
        /// <para>Additionally, the method can take an <c>exclude</c> array of objects or <see cref="Godot.RID"/>s that are to be excluded from collisions, a <c>collision_mask</c> bitmask representing the physics layers to check in, or booleans to determine if the ray should collide with <see cref="Godot.PhysicsBody"/>s or <see cref="Godot.Area"/>s, respectively.</para>
        /// </summary>
        /// <param name="exclude">If the parameter is null, then the default value is new Godot.Collections.Array { }</param>
        [GodotMethod("intersect_ray")]
        public Godot.Collections.Dictionary IntersectRay(Vector3 from, Vector3 to, Godot.Collections.Array exclude = null, uint collisionMask = (uint)2147483647, bool collideWithBodies = true, bool collideWithAreas = false)
        {
            Godot.Collections.Array exclude_in = exclude != null ? exclude : new Godot.Collections.Array { };
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_6_772(method_bind_1, Object.GetPtr(this), ref from, ref to, exclude_in.GetPtr(), collisionMask, collideWithBodies, collideWithAreas));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "intersect_shape");

        /// <summary>
        /// <para>Checks the intersections of a shape, given through a <see cref="Godot.PhysicsShapeQueryParameters"/> object, against the space. The intersected shapes are returned in an array containing dictionaries with the following fields:</para>
        /// <para><c>collider</c>: The colliding object.</para>
        /// <para><c>collider_id</c>: The colliding object's ID.</para>
        /// <para><c>rid</c>: The intersecting object's <see cref="Godot.RID"/>.</para>
        /// <para><c>shape</c>: The shape index of the colliding shape.</para>
        /// <para>The number of intersections can be limited with the <c>max_results</c> parameter, to reduce the processing time.</para>
        /// </summary>
        [GodotMethod("intersect_shape")]
        public Godot.Collections.Array IntersectShape(PhysicsShapeQueryParameters shape, int maxResults = 32)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_2_738(method_bind_2, Object.GetPtr(this), Object.GetPtr(shape), maxResults));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "cast_motion");

        /// <summary>
        /// <para>Checks how far a <see cref="Godot.Shape"/> can move without colliding. All the parameters for the query, including the shape, are supplied through a <see cref="Godot.PhysicsShapeQueryParameters"/> object.</para>
        /// <para>Returns an array with the safe and unsafe proportions (between 0 and 1) of the motion. The safe proportion is the maximum fraction of the motion that can be made without a collision. The unsafe proportion is the minimum fraction of the distance that must be moved for a collision. If no collision is detected a result of <c>[1.0, 1.0]</c> will be returned.</para>
        /// <para>Note: Any <see cref="Godot.Shape"/>s that the shape is already colliding with e.g. inside of, will be ignored. Use <see cref="Godot.PhysicsDirectSpaceState.CollideShape"/> to determine the <see cref="Godot.Shape"/>s that the shape is already colliding with.</para>
        /// </summary>
        [GodotMethod("cast_motion")]
        public Godot.Collections.Array CastMotion(PhysicsShapeQueryParameters shape, Vector3 motion)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_2_773(method_bind_3, Object.GetPtr(this), Object.GetPtr(shape), ref motion));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "collide_shape");

        /// <summary>
        /// <para>Checks the intersections of a shape, given through a <see cref="Godot.PhysicsShapeQueryParameters"/> object, against the space. The resulting array contains a list of points where the shape intersects another. Like with <see cref="Godot.PhysicsDirectSpaceState.IntersectShape"/>, the number of returned results can be limited to save processing time.</para>
        /// </summary>
        [GodotMethod("collide_shape")]
        public Godot.Collections.Array CollideShape(PhysicsShapeQueryParameters shape, int maxResults = 32)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_2_738(method_bind_4, Object.GetPtr(this), Object.GetPtr(shape), maxResults));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rest_info");

        /// <summary>
        /// <para>Checks the intersections of a shape, given through a <see cref="Godot.PhysicsShapeQueryParameters"/> object, against the space. If it collides with more than one shape, the nearest one is selected. The returned object is a dictionary containing the following fields:</para>
        /// <para><c>collider_id</c>: The colliding object's ID.</para>
        /// <para><c>linear_velocity</c>: The colliding object's velocity <see cref="Godot.Vector3"/>. If the object is an <see cref="Godot.Area"/>, the result is <c>(0, 0, 0)</c>.</para>
        /// <para><c>normal</c>: The object's surface normal at the intersection point.</para>
        /// <para><c>point</c>: The intersection point.</para>
        /// <para><c>rid</c>: The intersecting object's <see cref="Godot.RID"/>.</para>
        /// <para><c>shape</c>: The shape index of the colliding shape.</para>
        /// <para>If the shape did not intersect anything, then an empty dictionary is returned instead.</para>
        /// </summary>
        [GodotMethod("get_rest_info")]
        public Godot.Collections.Dictionary GetRestInfo(PhysicsShapeQueryParameters shape)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_1_740(method_bind_5, Object.GetPtr(this), Object.GetPtr(shape)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
