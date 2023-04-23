using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A* (A star) is a computer algorithm that is widely used in pathfinding and graph traversal, the process of plotting short paths among vertices (points), passing through a given set of edges (segments). It enjoys widespread use due to its performance and accuracy. Godot's A* implementation uses points in three-dimensional space and Euclidean distances by default.</para>
    /// <para>You must add points manually with <see cref="Godot.AStar.AddPoint"/> and create segments manually with <see cref="Godot.AStar.ConnectPoints"/>. Then you can test if there is a path between two points with the <see cref="Godot.AStar.ArePointsConnected"/> function, get a path containing indices by <see cref="Godot.AStar.GetIdPath"/>, or one containing actual coordinates with <see cref="Godot.AStar.GetPointPath"/>.</para>
    /// <para>It is also possible to use non-Euclidean distances. To do so, create a class that extends <c>AStar</c> and override methods <see cref="Godot.AStar._ComputeCost"/> and <see cref="Godot.AStar._EstimateCost"/>. Both take two indices and return a length, as is shown in the following example.</para>
    /// <para><code>
    /// class MyAStar:
    ///     extends AStar
    /// 
    ///     func _compute_cost(u, v):
    ///         return abs(u - v)
    /// 
    ///     func _estimate_cost(u, v):
    ///         return min(0, abs(u - v) - 1)
    /// </code></para>
    /// <para><see cref="Godot.AStar._EstimateCost"/> should return a lower bound of the distance, i.e. <c>_estimate_cost(u, v) &lt;= _compute_cost(u, v)</c>. This serves as a hint to the algorithm because the custom <c>_compute_cost</c> might be computation-heavy. If this is not the case, make <see cref="Godot.AStar._EstimateCost"/> return the same value as <see cref="Godot.AStar._ComputeCost"/> to provide the algorithm with the most accurate information.</para>
    /// <para>If the default <see cref="Godot.AStar._EstimateCost"/> and <see cref="Godot.AStar._ComputeCost"/> methods are used, or if the supplied <see cref="Godot.AStar._EstimateCost"/> method returns a lower bound of the cost, then the paths returned by A* will be the lowest-cost paths. Here, the cost of a path equals the sum of the <see cref="Godot.AStar._ComputeCost"/> results of all segments in the path multiplied by the <c>weight_scale</c>s of the endpoints of the respective segments. If the default methods are used and the <c>weight_scale</c>s of all points are set to <c>1.0</c>, then this equals the sum of Euclidean distances of all segments in the path.</para>
    /// </summary>
    public partial class AStar : Reference
    {
        private const string nativeName = "AStar";

        public AStar() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AStar_Ctor(this);
        }

        internal AStar(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>Called when computing the cost between two connected points.</para>
        /// <para>Note that this function is hidden in the default <c>AStar</c> class.</para>
        /// </summary>
        [GodotMethod("_compute_cost")]
        public virtual float _ComputeCost(int fromId, int toId)
        {
            return default(float);
        }

        /// <summary>
        /// <para>Called when estimating the cost between a point and the path's ending point.</para>
        /// <para>Note that this function is hidden in the default <c>AStar</c> class.</para>
        /// </summary>
        [GodotMethod("_estimate_cost")]
        public virtual float _EstimateCost(int fromId, int toId)
        {
            return default(float);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_available_point_id");

        /// <summary>
        /// <para>Returns the next available point ID with no point associated to it.</para>
        /// </summary>
        [GodotMethod("get_available_point_id")]
        public int GetAvailablePointId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_point");

        /// <summary>
        /// <para>Adds a new point at the given position with the given identifier. The <c>id</c> must be 0 or larger, and the <c>weight_scale</c> must be 0.0 or greater.</para>
        /// <para>The <c>weight_scale</c> is multiplied by the result of <see cref="Godot.AStar._ComputeCost"/> when determining the overall cost of traveling across a segment from a neighboring point to this point. Thus, all else being equal, the algorithm prefers points with lower <c>weight_scale</c>s to form a path.</para>
        /// <para><code>
        /// var astar = AStar.new()
        /// astar.add_point(1, Vector3(1, 0, 0), 4) # Adds the point (1, 0, 0) with weight_scale 4 and id 1
        /// </code></para>
        /// <para>If there already exists a point for the given <c>id</c>, its position and weight scale are updated to the given values.</para>
        /// </summary>
        [GodotMethod("add_point")]
        public void AddPoint(int id, Vector3 position, float weightScale = 1f)
        {
            NativeCalls.godot_icall_3_31(method_bind_1, Object.GetPtr(this), id, ref position, weightScale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_point_position");

        /// <summary>
        /// <para>Returns the position of the point associated with the given <c>id</c>.</para>
        /// </summary>
        [GodotMethod("get_point_position")]
        public Vector3 GetPointPosition(int id)
        {
            NativeCalls.godot_icall_1_32(method_bind_2, Object.GetPtr(this), id, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_point_position");

        /// <summary>
        /// <para>Sets the <c>position</c> for the point with the given <c>id</c>.</para>
        /// </summary>
        [GodotMethod("set_point_position")]
        public void SetPointPosition(int id, Vector3 position)
        {
            NativeCalls.godot_icall_2_33(method_bind_3, Object.GetPtr(this), id, ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_point_weight_scale");

        /// <summary>
        /// <para>Returns the weight scale of the point associated with the given <c>id</c>.</para>
        /// </summary>
        [GodotMethod("get_point_weight_scale")]
        public float GetPointWeightScale(int id)
        {
            return NativeCalls.godot_icall_1_12(method_bind_4, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_point_weight_scale");

        /// <summary>
        /// <para>Sets the <c>weight_scale</c> for the point with the given <c>id</c>. The <c>weight_scale</c> is multiplied by the result of <see cref="Godot.AStar._ComputeCost"/> when determining the overall cost of traveling across a segment from a neighboring point to this point.</para>
        /// </summary>
        [GodotMethod("set_point_weight_scale")]
        public void SetPointWeightScale(int id, float weightScale)
        {
            NativeCalls.godot_icall_2_34(method_bind_5, Object.GetPtr(this), id, weightScale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_point");

        /// <summary>
        /// <para>Removes the point associated with the given <c>id</c> from the points pool.</para>
        /// </summary>
        [GodotMethod("remove_point")]
        public void RemovePoint(int id)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_point");

        /// <summary>
        /// <para>Returns whether a point associated with the given <c>id</c> exists.</para>
        /// </summary>
        [GodotMethod("has_point")]
        public bool HasPoint(int id)
        {
            return NativeCalls.godot_icall_1_35(method_bind_7, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_point_connections");

        /// <summary>
        /// <para>Returns an array with the IDs of the points that form the connection with the given point.</para>
        /// <para><code>
        /// var astar = AStar.new()
        /// astar.add_point(1, Vector3(0, 0, 0))
        /// astar.add_point(2, Vector3(0, 1, 0))
        /// astar.add_point(3, Vector3(1, 1, 0))
        /// astar.add_point(4, Vector3(2, 0, 0))
        /// 
        /// astar.connect_points(1, 2, true)
        /// astar.connect_points(1, 3, true)
        /// 
        /// var neighbors = astar.get_point_connections(1) # Returns [2, 3]
        /// </code></para>
        /// </summary>
        [GodotMethod("get_point_connections")]
        public int[] GetPointConnections(int id)
        {
            return NativeCalls.godot_icall_1_36(method_bind_8, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_points");

        /// <summary>
        /// <para>Returns an array of all points.</para>
        /// </summary>
        [GodotMethod("get_points")]
        public Godot.Collections.Array GetPoints()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_9, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_point_disabled");

        /// <summary>
        /// <para>Disables or enables the specified point for pathfinding. Useful for making a temporary obstacle.</para>
        /// </summary>
        [GodotMethod("set_point_disabled")]
        public void SetPointDisabled(int id, bool disabled = true)
        {
            NativeCalls.godot_icall_2_23(method_bind_10, Object.GetPtr(this), id, disabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_point_disabled");

        /// <summary>
        /// <para>Returns whether a point is disabled or not for pathfinding. By default, all points are enabled.</para>
        /// </summary>
        [GodotMethod("is_point_disabled")]
        public bool IsPointDisabled(int id)
        {
            return NativeCalls.godot_icall_1_35(method_bind_11, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "connect_points");

        /// <summary>
        /// <para>Creates a segment between the given points. If <c>bidirectional</c> is <c>false</c>, only movement from <c>id</c> to <c>to_id</c> is allowed, not the reverse direction.</para>
        /// <para><code>
        /// var astar = AStar.new()
        /// astar.add_point(1, Vector3(1, 1, 0))
        /// astar.add_point(2, Vector3(0, 5, 0))
        /// astar.connect_points(1, 2, false)
        /// </code></para>
        /// </summary>
        [GodotMethod("connect_points")]
        public void ConnectPoints(int id, int toId, bool bidirectional = true)
        {
            NativeCalls.godot_icall_3_37(method_bind_12, Object.GetPtr(this), id, toId, bidirectional);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "disconnect_points");

        /// <summary>
        /// <para>Deletes the segment between the given points. If <c>bidirectional</c> is <c>false</c>, only movement from <c>id</c> to <c>to_id</c> is prevented, and a unidirectional segment possibly remains.</para>
        /// </summary>
        [GodotMethod("disconnect_points")]
        public void DisconnectPoints(int id, int toId, bool bidirectional = true)
        {
            NativeCalls.godot_icall_3_37(method_bind_13, Object.GetPtr(this), id, toId, bidirectional);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "are_points_connected");

        /// <summary>
        /// <para>Returns whether the two given points are directly connected by a segment. If <c>bidirectional</c> is <c>false</c>, returns whether movement from <c>id</c> to <c>to_id</c> is possible through this segment.</para>
        /// </summary>
        [GodotMethod("are_points_connected")]
        public bool ArePointsConnected(int id, int toId, bool bidirectional = true)
        {
            return NativeCalls.godot_icall_3_38(method_bind_14, Object.GetPtr(this), id, toId, bidirectional);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_point_count");

        /// <summary>
        /// <para>Returns the number of points currently in the points pool.</para>
        /// </summary>
        [GodotMethod("get_point_count")]
        public int GetPointCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_point_capacity");

        /// <summary>
        /// <para>Returns the capacity of the structure backing the points, useful in conjunction with <c>reserve_space</c>.</para>
        /// </summary>
        [GodotMethod("get_point_capacity")]
        public int GetPointCapacity()
        {
            return NativeCalls.godot_icall_0_5(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reserve_space");

        /// <summary>
        /// <para>Reserves space internally for <c>num_nodes</c> points, useful if you're adding a known large number of points at once, for a grid for instance. New capacity must be greater or equals to old capacity.</para>
        /// </summary>
        [GodotMethod("reserve_space")]
        public void ReserveSpace(int numNodes)
        {
            NativeCalls.godot_icall_1_4(method_bind_17, Object.GetPtr(this), numNodes);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Clears all the points and segments.</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_closest_point");

        /// <summary>
        /// <para>Returns the ID of the closest point to <c>to_position</c>, optionally taking disabled points into account. Returns <c>-1</c> if there are no points in the points pool.</para>
        /// <para>Note: If several points are the closest to <c>to_position</c>, the one with the smallest ID will be returned, ensuring a deterministic result.</para>
        /// </summary>
        [GodotMethod("get_closest_point")]
        public int GetClosestPoint(Vector3 toPosition, bool includeDisabled = false)
        {
            return NativeCalls.godot_icall_2_39(method_bind_19, Object.GetPtr(this), ref toPosition, includeDisabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_closest_position_in_segment");

        /// <summary>
        /// <para>Returns the closest position to <c>to_position</c> that resides inside a segment between two connected points.</para>
        /// <para><code>
        /// var astar = AStar.new()
        /// astar.add_point(1, Vector3(0, 0, 0))
        /// astar.add_point(2, Vector3(0, 5, 0))
        /// astar.connect_points(1, 2)
        /// var res = astar.get_closest_position_in_segment(Vector3(3, 3, 0)) # Returns (0, 3, 0)
        /// </code></para>
        /// <para>The result is in the segment that goes from <c>y = 0</c> to <c>y = 5</c>. It's the closest position in the segment to the given point.</para>
        /// </summary>
        [GodotMethod("get_closest_position_in_segment")]
        public Vector3 GetClosestPositionInSegment(Vector3 toPosition)
        {
            NativeCalls.godot_icall_1_40(method_bind_20, Object.GetPtr(this), ref toPosition, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_point_path");

        /// <summary>
        /// <para>Returns an array with the points that are in the path found by AStar between the given points. The array is ordered from the starting point to the ending point of the path.</para>
        /// <para>Note: This method is not thread-safe. If called from a <see cref="Godot.Thread"/>, it will return an empty <see cref="Godot.Vector3"/> and will print an error message.</para>
        /// </summary>
        [GodotMethod("get_point_path")]
        public Vector3[] GetPointPath(int fromId, int toId)
        {
            return NativeCalls.godot_icall_2_41(method_bind_21, Object.GetPtr(this), fromId, toId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_id_path");

        /// <summary>
        /// <para>Returns an array with the IDs of the points that form the path found by AStar between the given points. The array is ordered from the starting point to the ending point of the path.</para>
        /// <para><code>
        /// var astar = AStar.new()
        /// astar.add_point(1, Vector3(0, 0, 0))
        /// astar.add_point(2, Vector3(0, 1, 0), 1) # Default weight is 1
        /// astar.add_point(3, Vector3(1, 1, 0))
        /// astar.add_point(4, Vector3(2, 0, 0))
        /// 
        /// astar.connect_points(1, 2, false)
        /// astar.connect_points(2, 3, false)
        /// astar.connect_points(4, 3, false)
        /// astar.connect_points(1, 4, false)
        /// 
        /// var res = astar.get_id_path(1, 3) # Returns [1, 2, 3]
        /// </code></para>
        /// <para>If you change the 2nd point's weight to 3, then the result will be <c>[1, 4, 3]</c> instead, because now even though the distance is longer, it's "easier" to get through point 4 than through point 2.</para>
        /// </summary>
        [GodotMethod("get_id_path")]
        public int[] GetIdPath(int fromId, int toId)
        {
            return NativeCalls.godot_icall_2_42(method_bind_22, Object.GetPtr(this), fromId, toId);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
