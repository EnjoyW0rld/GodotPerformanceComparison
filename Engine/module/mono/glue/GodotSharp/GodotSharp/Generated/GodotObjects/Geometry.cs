using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Geometry provides users with a set of helper functions to create geometric shapes, compute intersections between shapes, and process various other geometric operations.</para>
    /// </summary>
    public static partial class Geometry
    {
        public enum PolyEndType
        {
            /// <summary>
            /// <para>Endpoints are joined using the <see cref="Godot.Geometry.PolyJoinType"/> value and the path filled as a polygon.</para>
            /// </summary>
            Polygon = 0,
            /// <summary>
            /// <para>Endpoints are joined using the <see cref="Godot.Geometry.PolyJoinType"/> value and the path filled as a polyline.</para>
            /// </summary>
            Joined = 1,
            /// <summary>
            /// <para>Endpoints are squared off with no extension.</para>
            /// </summary>
            Butt = 2,
            /// <summary>
            /// <para>Endpoints are squared off and extended by <c>delta</c> units.</para>
            /// </summary>
            Square = 3,
            /// <summary>
            /// <para>Endpoints are rounded off and extended by <c>delta</c> units.</para>
            /// </summary>
            Round = 4
        }

        public enum PolyBooleanOperation
        {
            /// <summary>
            /// <para>Create regions where either subject or clip polygons (or both) are filled.</para>
            /// </summary>
            Union = 0,
            /// <summary>
            /// <para>Create regions where subject polygons are filled except where clip polygons are filled.</para>
            /// </summary>
            Difference = 1,
            /// <summary>
            /// <para>Create regions where both subject and clip polygons are filled.</para>
            /// </summary>
            Intersection = 2,
            /// <summary>
            /// <para>Create regions where either subject or clip polygons are filled but not where both are filled.</para>
            /// </summary>
            Xor = 3
        }

        public enum PolyJoinType
        {
            /// <summary>
            /// <para>Squaring is applied uniformally at all convex edge joins at <c>1 * delta</c>.</para>
            /// </summary>
            Square = 0,
            /// <summary>
            /// <para>While flattened paths can never perfectly trace an arc, they are approximated by a series of arc chords.</para>
            /// </summary>
            Round = 1,
            /// <summary>
            /// <para>There's a necessary limit to mitered joins since offsetting edges that join at very acute angles will produce excessively long and narrow "spikes". For any given edge join, when miter offsetting would exceed that maximum distance, "square" joining is applied.</para>
            /// </summary>
            Miter = 2
        }

        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(Geometry).Name);
                return singleton;
            }
        }

        private const string nativeName = "_Geometry";
        internal static IntPtr ptr = NativeCalls.godot_icall__Geometry_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "build_box_planes");

        /// <summary>
        /// <para>Returns an array with 6 <see cref="Godot.Plane"/>s that describe the sides of a box centered at the origin. The box size is defined by <c>extents</c>, which represents one (positive) corner of the box (i.e. half its actual size).</para>
        /// </summary>
        [GodotMethod("build_box_planes")]
        public static Godot.Collections.Array BuildBoxPlanes(Vector3 extents)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_1_1183(method_bind_0, ptr, ref extents));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "build_cylinder_planes");

        /// <summary>
        /// <para>Returns an array of <see cref="Godot.Plane"/>s closely bounding a faceted cylinder centered at the origin with radius <c>radius</c> and height <c>height</c>. The parameter <c>sides</c> defines how many planes will be generated for the round part of the cylinder. The parameter <c>axis</c> describes the axis along which the cylinder is oriented (0 for X, 1 for Y, 2 for Z).</para>
        /// </summary>
        [GodotMethod("build_cylinder_planes")]
        public static Godot.Collections.Array BuildCylinderPlanes(float radius, float height, int sides, Vector3.Axis axis = (Vector3.Axis)2)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_4_1184(method_bind_1, ptr, radius, height, sides, (int)axis));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "build_capsule_planes");

        /// <summary>
        /// <para>Returns an array of <see cref="Godot.Plane"/>s closely bounding a faceted capsule centered at the origin with radius <c>radius</c> and height <c>height</c>. The parameter <c>sides</c> defines how many planes will be generated for the side part of the capsule, whereas <c>lats</c> gives the number of latitudinal steps at the bottom and top of the capsule. The parameter <c>axis</c> describes the axis along which the capsule is oriented (0 for X, 1 for Y, 2 for Z).</para>
        /// </summary>
        [GodotMethod("build_capsule_planes")]
        public static Godot.Collections.Array BuildCapsulePlanes(float radius, float height, int sides, int lats, Vector3.Axis axis = (Vector3.Axis)2)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_5_1185(method_bind_2, ptr, radius, height, sides, lats, (int)axis));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_point_in_circle");

        /// <summary>
        /// <para>Returns <c>true</c> if <c>point</c> is inside the circle or if it's located exactly on the circle's boundary, otherwise returns <c>false</c>.</para>
        /// </summary>
        [GodotMethod("is_point_in_circle")]
        public static bool IsPointInCircle(Vector2 point, Vector2 circlePosition, float circleRadius)
        {
            return NativeCalls.godot_icall_3_1186(method_bind_3, ptr, ref point, ref circlePosition, circleRadius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "segment_intersects_circle");

        /// <summary>
        /// <para>Given the 2D segment (<c>segment_from</c>, <c>segment_to</c>), returns the position on the segment (as a number between 0 and 1) at which the segment hits the circle that is located at position <c>circle_position</c> and has radius <c>circle_radius</c>. If the segment does not intersect the circle, -1 is returned (this is also the case if the line extending the segment would intersect the circle, but the segment does not).</para>
        /// </summary>
        [GodotMethod("segment_intersects_circle")]
        public static float SegmentIntersectsCircle(Vector2 segmentFrom, Vector2 segmentTo, Vector2 circlePosition, float circleRadius)
        {
            return NativeCalls.godot_icall_4_1187(method_bind_4, ptr, ref segmentFrom, ref segmentTo, ref circlePosition, circleRadius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "segment_intersects_segment_2d");

        /// <summary>
        /// <para>Checks if the two segments (<c>from_a</c>, <c>to_a</c>) and (<c>from_b</c>, <c>to_b</c>) intersect. If yes, return the point of intersection as <see cref="Godot.Vector2"/>. If no intersection takes place, returns <c>null</c>.</para>
        /// </summary>
        [GodotMethod("segment_intersects_segment_2d")]
        public static object SegmentIntersectsSegment2d(Vector2 fromA, Vector2 toA, Vector2 fromB, Vector2 toB)
        {
            return NativeCalls.godot_icall_4_1188(method_bind_5, ptr, ref fromA, ref toA, ref fromB, ref toB);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "line_intersects_line_2d");

        /// <summary>
        /// <para>Checks if the two lines (<c>from_a</c>, <c>dir_a</c>) and (<c>from_b</c>, <c>dir_b</c>) intersect. If yes, return the point of intersection as <see cref="Godot.Vector2"/>. If no intersection takes place, returns <c>null</c>.</para>
        /// <para>Note: The lines are specified using direction vectors, not end points.</para>
        /// </summary>
        [GodotMethod("line_intersects_line_2d")]
        public static object LineIntersectsLine2d(Vector2 fromA, Vector2 dirA, Vector2 fromB, Vector2 dirB)
        {
            return NativeCalls.godot_icall_4_1188(method_bind_6, ptr, ref fromA, ref dirA, ref fromB, ref dirB);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_closest_points_between_segments_2d");

        /// <summary>
        /// <para>Given the two 2D segments (<c>p1</c>, <c>q1</c>) and (<c>p2</c>, <c>q2</c>), finds those two points on the two segments that are closest to each other. Returns a <see cref="Godot.Vector2"/> that contains this point on (<c>p1</c>, <c>q1</c>) as well the accompanying point on (<c>p2</c>, <c>q2</c>).</para>
        /// </summary>
        [GodotMethod("get_closest_points_between_segments_2d")]
        public static Vector2[] GetClosestPointsBetweenSegments2d(Vector2 p1, Vector2 q1, Vector2 p2, Vector2 q2)
        {
            return NativeCalls.godot_icall_4_1189(method_bind_7, ptr, ref p1, ref q1, ref p2, ref q2);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_closest_points_between_segments");

        /// <summary>
        /// <para>Given the two 3D segments (<c>p1</c>, <c>p2</c>) and (<c>q1</c>, <c>q2</c>), finds those two points on the two segments that are closest to each other. Returns a <see cref="Godot.Vector3"/> that contains this point on (<c>p1</c>, <c>p2</c>) as well the accompanying point on (<c>q1</c>, <c>q2</c>).</para>
        /// </summary>
        [GodotMethod("get_closest_points_between_segments")]
        public static Vector3[] GetClosestPointsBetweenSegments(Vector3 p1, Vector3 p2, Vector3 q1, Vector3 q2)
        {
            return NativeCalls.godot_icall_4_1190(method_bind_8, ptr, ref p1, ref p2, ref q1, ref q2);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_closest_point_to_segment_2d");

        /// <summary>
        /// <para>Returns the 2D point on the 2D segment (<c>s1</c>, <c>s2</c>) that is closest to <c>point</c>. The returned point will always be inside the specified segment.</para>
        /// </summary>
        [GodotMethod("get_closest_point_to_segment_2d")]
        public static Vector2 GetClosestPointToSegment2d(Vector2 point, Vector2 s1, Vector2 s2)
        {
            NativeCalls.godot_icall_3_1191(method_bind_9, ptr, ref point, ref s1, ref s2, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_closest_point_to_segment");

        /// <summary>
        /// <para>Returns the 3D point on the 3D segment (<c>s1</c>, <c>s2</c>) that is closest to <c>point</c>. The returned point will always be inside the specified segment.</para>
        /// </summary>
        [GodotMethod("get_closest_point_to_segment")]
        public static Vector3 GetClosestPointToSegment(Vector3 point, Vector3 s1, Vector3 s2)
        {
            NativeCalls.godot_icall_3_1192(method_bind_10, ptr, ref point, ref s1, ref s2, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_closest_point_to_segment_uncapped_2d");

        /// <summary>
        /// <para>Returns the 2D point on the 2D line defined by (<c>s1</c>, <c>s2</c>) that is closest to <c>point</c>. The returned point can be inside the segment (<c>s1</c>, <c>s2</c>) or outside of it, i.e. somewhere on the line extending from the segment.</para>
        /// </summary>
        [GodotMethod("get_closest_point_to_segment_uncapped_2d")]
        public static Vector2 GetClosestPointToSegmentUncapped2d(Vector2 point, Vector2 s1, Vector2 s2)
        {
            NativeCalls.godot_icall_3_1191(method_bind_11, ptr, ref point, ref s1, ref s2, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_closest_point_to_segment_uncapped");

        /// <summary>
        /// <para>Returns the 3D point on the 3D line defined by (<c>s1</c>, <c>s2</c>) that is closest to <c>point</c>. The returned point can be inside the segment (<c>s1</c>, <c>s2</c>) or outside of it, i.e. somewhere on the line extending from the segment.</para>
        /// </summary>
        [GodotMethod("get_closest_point_to_segment_uncapped")]
        public static Vector3 GetClosestPointToSegmentUncapped(Vector3 point, Vector3 s1, Vector3 s2)
        {
            NativeCalls.godot_icall_3_1192(method_bind_12, ptr, ref point, ref s1, ref s2, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_uv84_normal_bit");

        /// <summary>
        /// <para>Used internally by the engine.</para>
        /// </summary>
        [GodotMethod("get_uv84_normal_bit")]
        public static int GetUv84NormalBit(Vector3 normal)
        {
            return NativeCalls.godot_icall_1_1193(method_bind_13, ptr, ref normal);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "ray_intersects_triangle");

        /// <summary>
        /// <para>Tests if the 3D ray starting at <c>from</c> with the direction of <c>dir</c> intersects the triangle specified by <c>a</c>, <c>b</c> and <c>c</c>. If yes, returns the point of intersection as <see cref="Godot.Vector3"/>. If no intersection takes place, an empty <c>Variant</c> is returned.</para>
        /// </summary>
        [GodotMethod("ray_intersects_triangle")]
        public static object RayIntersectsTriangle(Vector3 from, Vector3 dir, Vector3 a, Vector3 b, Vector3 c)
        {
            return NativeCalls.godot_icall_5_1194(method_bind_14, ptr, ref from, ref dir, ref a, ref b, ref c);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "segment_intersects_triangle");

        /// <summary>
        /// <para>Tests if the segment (<c>from</c>, <c>to</c>) intersects the triangle <c>a</c>, <c>b</c>, <c>c</c>. If yes, returns the point of intersection as <see cref="Godot.Vector3"/>. If no intersection takes place, an empty <c>Variant</c> is returned.</para>
        /// </summary>
        [GodotMethod("segment_intersects_triangle")]
        public static object SegmentIntersectsTriangle(Vector3 from, Vector3 to, Vector3 a, Vector3 b, Vector3 c)
        {
            return NativeCalls.godot_icall_5_1194(method_bind_15, ptr, ref from, ref to, ref a, ref b, ref c);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "segment_intersects_sphere");

        /// <summary>
        /// <para>Checks if the segment (<c>from</c>, <c>to</c>) intersects the sphere that is located at <c>sphere_position</c> and has radius <c>sphere_radius</c>. If no, returns an empty <see cref="Godot.Vector3"/>. If yes, returns a <see cref="Godot.Vector3"/> containing the point of intersection and the sphere's normal at the point of intersection.</para>
        /// </summary>
        [GodotMethod("segment_intersects_sphere")]
        public static Vector3[] SegmentIntersectsSphere(Vector3 from, Vector3 to, Vector3 spherePosition, float sphereRadius)
        {
            return NativeCalls.godot_icall_4_1195(method_bind_16, ptr, ref from, ref to, ref spherePosition, sphereRadius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "segment_intersects_cylinder");

        /// <summary>
        /// <para>Checks if the segment (<c>from</c>, <c>to</c>) intersects the cylinder with height <c>height</c> that is centered at the origin and has radius <c>radius</c>. If no, returns an empty <see cref="Godot.Vector3"/>. If an intersection takes place, the returned array contains the point of intersection and the cylinder's normal at the point of intersection.</para>
        /// </summary>
        [GodotMethod("segment_intersects_cylinder")]
        public static Vector3[] SegmentIntersectsCylinder(Vector3 from, Vector3 to, float height, float radius)
        {
            return NativeCalls.godot_icall_4_1196(method_bind_17, ptr, ref from, ref to, height, radius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "segment_intersects_convex");

        /// <summary>
        /// <para>Given a convex hull defined though the <see cref="Godot.Plane"/>s in the array <c>planes</c>, tests if the segment (<c>from</c>, <c>to</c>) intersects with that hull. If an intersection is found, returns a <see cref="Godot.Vector3"/> containing the point the intersection and the hull's normal. If no intersecion is found, an the returned array is empty.</para>
        /// </summary>
        [GodotMethod("segment_intersects_convex")]
        public static Vector3[] SegmentIntersectsConvex(Vector3 from, Vector3 to, Godot.Collections.Array planes)
        {
            return NativeCalls.godot_icall_3_1197(method_bind_18, ptr, ref from, ref to, planes.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "point_is_inside_triangle");

        /// <summary>
        /// <para>Returns if <c>point</c> is inside the triangle specified by <c>a</c>, <c>b</c> and <c>c</c>.</para>
        /// </summary>
        [GodotMethod("point_is_inside_triangle")]
        public static bool PointIsInsideTriangle(Vector2 point, Vector2 a, Vector2 b, Vector2 c)
        {
            return NativeCalls.godot_icall_4_1198(method_bind_19, ptr, ref point, ref a, ref b, ref c);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_polygon_clockwise");

        /// <summary>
        /// <para>Returns <c>true</c> if <c>polygon</c>'s vertices are ordered in clockwise order, otherwise returns <c>false</c>.</para>
        /// </summary>
        [GodotMethod("is_polygon_clockwise")]
        public static bool IsPolygonClockwise(Vector2[] polygon)
        {
            return NativeCalls.godot_icall_1_182(method_bind_20, ptr, polygon);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_point_in_polygon");

        /// <summary>
        /// <para>Returns <c>true</c> if <c>point</c> is inside <c>polygon</c> or if it's located exactly on polygon's boundary, otherwise returns <c>false</c>.</para>
        /// </summary>
        [GodotMethod("is_point_in_polygon")]
        public static bool IsPointInPolygon(Vector2 point, Vector2[] polygon)
        {
            return NativeCalls.godot_icall_2_1199(method_bind_21, ptr, ref point, polygon);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "triangulate_polygon");

        /// <summary>
        /// <para>Triangulates the polygon specified by the points in <c>polygon</c>. Returns a <see cref="int"/> where each triangle consists of three consecutive point indices into <c>polygon</c> (i.e. the returned array will have <c>n * 3</c> elements, with <c>n</c> being the number of found triangles). Output triangles will always be counter clockwise, and the contour will be flipped if it's clockwise. If the triangulation did not succeed, an empty <see cref="int"/> is returned.</para>
        /// </summary>
        [GodotMethod("triangulate_polygon")]
        public static int[] TriangulatePolygon(Vector2[] polygon)
        {
            return NativeCalls.godot_icall_1_1200(method_bind_22, ptr, polygon);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "triangulate_delaunay_2d");

        /// <summary>
        /// <para>Triangulates the area specified by discrete set of <c>points</c> such that no point is inside the circumcircle of any resulting triangle. Returns a <see cref="int"/> where each triangle consists of three consecutive point indices into <c>points</c> (i.e. the returned array will have <c>n * 3</c> elements, with <c>n</c> being the number of found triangles). If the triangulation did not succeed, an empty <see cref="int"/> is returned.</para>
        /// </summary>
        [GodotMethod("triangulate_delaunay_2d")]
        public static int[] TriangulateDelaunay2d(Vector2[] points)
        {
            return NativeCalls.godot_icall_1_1200(method_bind_23, ptr, points);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "convex_hull_2d");

        /// <summary>
        /// <para>Given an array of <see cref="Godot.Vector2"/>s, returns the convex hull as a list of points in counterclockwise order. The last point is the same as the first one.</para>
        /// </summary>
        [GodotMethod("convex_hull_2d")]
        public static Vector2[] ConvexHull2d(Vector2[] points)
        {
            return NativeCalls.godot_icall_1_1201(method_bind_24, ptr, points);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clip_polygon");

        /// <summary>
        /// <para>Clips the polygon defined by the points in <c>points</c> against the <c>plane</c> and returns the points of the clipped polygon.</para>
        /// </summary>
        [GodotMethod("clip_polygon")]
        public static Vector3[] ClipPolygon(Vector3[] points, Plane plane)
        {
            return NativeCalls.godot_icall_2_1202(method_bind_25, ptr, points, ref plane);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "merge_polygons_2d");

        /// <summary>
        /// <para>Merges (combines) <c>polygon_a</c> and <c>polygon_b</c> and returns an array of merged polygons. This performs <see cref="Godot.Geometry.PolyBooleanOperation.Union"/> between polygons.</para>
        /// <para>The operation may result in an outer polygon (boundary) and multiple inner polygons (holes) produced which could be distinguished by calling <see cref="Godot.Geometry.IsPolygonClockwise"/>.</para>
        /// </summary>
        [GodotMethod("merge_polygons_2d")]
        public static Godot.Collections.Array MergePolygons2d(Vector2[] polygonA, Vector2[] polygonB)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_2_1203(method_bind_26, ptr, polygonA, polygonB));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clip_polygons_2d");

        /// <summary>
        /// <para>Clips <c>polygon_a</c> against <c>polygon_b</c> and returns an array of clipped polygons. This performs <see cref="Godot.Geometry.PolyBooleanOperation.Difference"/> between polygons. Returns an empty array if <c>polygon_b</c> completely overlaps <c>polygon_a</c>.</para>
        /// <para>If <c>polygon_b</c> is enclosed by <c>polygon_a</c>, returns an outer polygon (boundary) and inner polygon (hole) which could be distinguished by calling <see cref="Godot.Geometry.IsPolygonClockwise"/>.</para>
        /// </summary>
        [GodotMethod("clip_polygons_2d")]
        public static Godot.Collections.Array ClipPolygons2d(Vector2[] polygonA, Vector2[] polygonB)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_2_1203(method_bind_27, ptr, polygonA, polygonB));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "intersect_polygons_2d");

        /// <summary>
        /// <para>Intersects <c>polygon_a</c> with <c>polygon_b</c> and returns an array of intersected polygons. This performs <see cref="Godot.Geometry.PolyBooleanOperation.Intersection"/> between polygons. In other words, returns common area shared by polygons. Returns an empty array if no intersection occurs.</para>
        /// <para>The operation may result in an outer polygon (boundary) and inner polygon (hole) produced which could be distinguished by calling <see cref="Godot.Geometry.IsPolygonClockwise"/>.</para>
        /// </summary>
        [GodotMethod("intersect_polygons_2d")]
        public static Godot.Collections.Array IntersectPolygons2d(Vector2[] polygonA, Vector2[] polygonB)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_2_1203(method_bind_28, ptr, polygonA, polygonB));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "exclude_polygons_2d");

        /// <summary>
        /// <para>Mutually excludes common area defined by intersection of <c>polygon_a</c> and <c>polygon_b</c> (see <see cref="Godot.Geometry.IntersectPolygons2d"/>) and returns an array of excluded polygons. This performs <see cref="Godot.Geometry.PolyBooleanOperation.Xor"/> between polygons. In other words, returns all but common area between polygons.</para>
        /// <para>The operation may result in an outer polygon (boundary) and inner polygon (hole) produced which could be distinguished by calling <see cref="Godot.Geometry.IsPolygonClockwise"/>.</para>
        /// </summary>
        [GodotMethod("exclude_polygons_2d")]
        public static Godot.Collections.Array ExcludePolygons2d(Vector2[] polygonA, Vector2[] polygonB)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_2_1203(method_bind_29, ptr, polygonA, polygonB));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clip_polyline_with_polygon_2d");

        /// <summary>
        /// <para>Clips <c>polyline</c> against <c>polygon</c> and returns an array of clipped polylines. This performs <see cref="Godot.Geometry.PolyBooleanOperation.Difference"/> between the polyline and the polygon. This operation can be thought of as cutting a line with a closed shape.</para>
        /// </summary>
        [GodotMethod("clip_polyline_with_polygon_2d")]
        public static Godot.Collections.Array ClipPolylineWithPolygon2d(Vector2[] polyline, Vector2[] polygon)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_2_1203(method_bind_30, ptr, polyline, polygon));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "intersect_polyline_with_polygon_2d");

        /// <summary>
        /// <para>Intersects <c>polyline</c> with <c>polygon</c> and returns an array of intersected polylines. This performs <see cref="Godot.Geometry.PolyBooleanOperation.Intersection"/> between the polyline and the polygon. This operation can be thought of as chopping a line with a closed shape.</para>
        /// </summary>
        [GodotMethod("intersect_polyline_with_polygon_2d")]
        public static Godot.Collections.Array IntersectPolylineWithPolygon2d(Vector2[] polyline, Vector2[] polygon)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_2_1203(method_bind_31, ptr, polyline, polygon));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "offset_polygon_2d");

        /// <summary>
        /// <para>Inflates or deflates <c>polygon</c> by <c>delta</c> units (pixels). If <c>delta</c> is positive, makes the polygon grow outward. If <c>delta</c> is negative, shrinks the polygon inward. Returns an array of polygons because inflating/deflating may result in multiple discrete polygons. Returns an empty array if <c>delta</c> is negative and the absolute value of it approximately exceeds the minimum bounding rectangle dimensions of the polygon.</para>
        /// <para>Each polygon's vertices will be rounded as determined by <c>join_type</c>, see <see cref="Godot.Geometry.PolyJoinType"/>.</para>
        /// <para>The operation may result in an outer polygon (boundary) and inner polygon (hole) produced which could be distinguished by calling <see cref="Godot.Geometry.IsPolygonClockwise"/>.</para>
        /// <para>Note: To translate the polygon's vertices specifically, use the <c>Transform2D.xform</c> method:</para>
        /// <para><code>
        /// var polygon = PoolVector2Array([Vector2(0, 0), Vector2(100, 0), Vector2(100, 100), Vector2(0, 100)])
        /// var offset = Vector2(50, 50)
        /// polygon = Transform2D(0, offset).xform(polygon)
        /// print(polygon) # prints [Vector2(50, 50), Vector2(150, 50), Vector2(150, 150), Vector2(50, 150)]
        /// </code></para>
        /// </summary>
        [GodotMethod("offset_polygon_2d")]
        public static Godot.Collections.Array OffsetPolygon2d(Vector2[] polygon, float delta, Geometry.PolyJoinType joinType = (Geometry.PolyJoinType)0)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_3_1204(method_bind_32, ptr, polygon, delta, (int)joinType));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "offset_polyline_2d");

        /// <summary>
        /// <para>Inflates or deflates <c>polyline</c> by <c>delta</c> units (pixels), producing polygons. If <c>delta</c> is positive, makes the polyline grow outward. Returns an array of polygons because inflating/deflating may result in multiple discrete polygons. If <c>delta</c> is negative, returns an empty array.</para>
        /// <para>Each polygon's vertices will be rounded as determined by <c>join_type</c>, see <see cref="Godot.Geometry.PolyJoinType"/>.</para>
        /// <para>Each polygon's endpoints will be rounded as determined by <c>end_type</c>, see <see cref="Godot.Geometry.PolyEndType"/>.</para>
        /// <para>The operation may result in an outer polygon (boundary) and inner polygon (hole) produced which could be distinguished by calling <see cref="Godot.Geometry.IsPolygonClockwise"/>.</para>
        /// </summary>
        [GodotMethod("offset_polyline_2d")]
        public static Godot.Collections.Array OffsetPolyline2d(Vector2[] polyline, float delta, Geometry.PolyJoinType joinType = (Geometry.PolyJoinType)0, Geometry.PolyEndType endType = (Geometry.PolyEndType)3)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_4_1205(method_bind_33, ptr, polyline, delta, (int)joinType, (int)endType));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "make_atlas");

        /// <summary>
        /// <para>Given an array of <see cref="Godot.Vector2"/>s representing tiles, builds an atlas. The returned dictionary has two keys: <c>points</c> is an array of <see cref="Godot.Vector2"/> that specifies the positions of each tile, <c>size</c> contains the overall size of the whole atlas as <see cref="Godot.Vector2"/>.</para>
        /// </summary>
        [GodotMethod("make_atlas")]
        public static Godot.Collections.Dictionary MakeAtlas(Vector2[] sizes)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_1_1206(method_bind_34, ptr, sizes));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
