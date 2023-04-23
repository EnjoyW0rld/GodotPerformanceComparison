using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>NavigationServer is the server responsible for all 3D navigation. It handles several objects, namely maps, regions and agents.</para>
    /// <para>Maps are made up of regions, which are made of navigation meshes. Together, they define the navigable areas in the 3D world.</para>
    /// <para>Note: Most NavigationServer changes take effect after the next physics frame and not immediately. This includes all changes made to maps, regions or agents by navigation related Nodes in the SceneTree or made through scripts.</para>
    /// <para>For two regions to be connected to each other, they must share a similar edge. An edge is considered connected to another if both of its two vertices are at a distance less than <see cref="Godot.Navigation.EdgeConnectionMargin"/> to the respective other edge's vertex.</para>
    /// <para>To use the collision avoidance system, you may use agents. You can set an agent's target velocity, then the servers will emit a callback with a modified velocity.</para>
    /// <para>Note: The collision avoidance system ignores regions. Using the modified velocity as-is might lead to pushing and agent outside of a navigable area. This is a limitation of the collision avoidance system, any more complex situation may require the use of the physics engine.</para>
    /// <para>Note: By default, the expensive calculations for avoidance are done in a thread. In HTML5 exports without thread support, they will be done on the main thread, which can lead to performance issues.</para>
    /// <para>This server keeps tracks of any call and executes them during the sync phase. This means that you can request any change to the map, using any thread, without worrying.</para>
    /// </summary>
    public static partial class NavigationServer
    {
        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(NavigationServer).Name);
                return singleton;
            }
        }

        private const string nativeName = "NavigationServer";
        internal static IntPtr ptr = NativeCalls.godot_icall_NavigationServer_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_maps");

        /// <summary>
        /// <para>Returns all created navigation map <see cref="Godot.RID"/>s on the NavigationServer. This returns both 2D and 3D created navigation maps as there is technically no distinction between them.</para>
        /// </summary>
        [GodotMethod("get_maps")]
        public static Godot.Collections.Array GetMaps()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_0, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "map_create");

        /// <summary>
        /// <para>Create a new map.</para>
        /// </summary>
        [GodotMethod("map_create")]
        public static RID MapCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_1, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "map_set_active");

        /// <summary>
        /// <para>Sets the map active.</para>
        /// </summary>
        [GodotMethod("map_set_active")]
        public static void MapSetActive(RID map, bool active)
        {
            NativeCalls.godot_icall_2_628(method_bind_2, ptr, RID.GetPtr(map), active);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "map_is_active");

        /// <summary>
        /// <para>Returns <c>true</c> if the map is active.</para>
        /// </summary>
        [GodotMethod("map_is_active")]
        public static bool MapIsActive(RID map)
        {
            return NativeCalls.godot_icall_1_629(method_bind_3, ptr, RID.GetPtr(map));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "map_set_up");

        /// <summary>
        /// <para>Sets the map up direction.</para>
        /// </summary>
        [GodotMethod("map_set_up")]
        public static void MapSetUp(RID map, Vector3 up)
        {
            NativeCalls.godot_icall_2_656(method_bind_4, ptr, RID.GetPtr(map), ref up);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "map_get_up");

        /// <summary>
        /// <para>Returns the map's up direction.</para>
        /// </summary>
        [GodotMethod("map_get_up")]
        public static Vector3 MapGetUp(RID map)
        {
            NativeCalls.godot_icall_1_657(method_bind_5, ptr, RID.GetPtr(map), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "map_set_cell_size");

        /// <summary>
        /// <para>Set the map cell size used to weld the navigation mesh polygons.</para>
        /// </summary>
        [GodotMethod("map_set_cell_size")]
        public static void MapSetCellSize(RID map, float cellSize)
        {
            NativeCalls.godot_icall_2_630(method_bind_6, ptr, RID.GetPtr(map), cellSize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "map_get_cell_size");

        /// <summary>
        /// <para>Returns the map cell size.</para>
        /// </summary>
        [GodotMethod("map_get_cell_size")]
        public static float MapGetCellSize(RID map)
        {
            return NativeCalls.godot_icall_1_631(method_bind_7, ptr, RID.GetPtr(map));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "map_set_cell_height");

        /// <summary>
        /// <para>Set the map cell height used to weld the navigation mesh polygons.</para>
        /// </summary>
        [GodotMethod("map_set_cell_height")]
        public static void MapSetCellHeight(RID map, float cellHeight)
        {
            NativeCalls.godot_icall_2_630(method_bind_8, ptr, RID.GetPtr(map), cellHeight);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "map_get_cell_height");

        /// <summary>
        /// <para>Returns the map cell height.</para>
        /// </summary>
        [GodotMethod("map_get_cell_height")]
        public static float MapGetCellHeight(RID map)
        {
            return NativeCalls.godot_icall_1_631(method_bind_9, ptr, RID.GetPtr(map));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "map_set_edge_connection_margin");

        /// <summary>
        /// <para>Set the map edge connection margin used to weld the compatible region edges.</para>
        /// </summary>
        [GodotMethod("map_set_edge_connection_margin")]
        public static void MapSetEdgeConnectionMargin(RID map, float margin)
        {
            NativeCalls.godot_icall_2_630(method_bind_10, ptr, RID.GetPtr(map), margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "map_get_edge_connection_margin");

        /// <summary>
        /// <para>Returns the edge connection margin of the map. This distance is the minimum vertex distance needed to connect two edges from different regions.</para>
        /// </summary>
        [GodotMethod("map_get_edge_connection_margin")]
        public static float MapGetEdgeConnectionMargin(RID map)
        {
            return NativeCalls.godot_icall_1_631(method_bind_11, ptr, RID.GetPtr(map));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "map_get_path");

        /// <summary>
        /// <para>Returns the navigation path to reach the destination from the origin. <c>navigation_layers</c> is a bitmask of all region layers that are allowed to be in the path.</para>
        /// </summary>
        [GodotMethod("map_get_path")]
        public static Vector3[] MapGetPath(RID map, Vector3 origin, Vector3 destination, bool optimize, uint navigationLayers = (uint)1)
        {
            return NativeCalls.godot_icall_5_658(method_bind_12, ptr, RID.GetPtr(map), ref origin, ref destination, optimize, navigationLayers);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "map_get_closest_point_to_segment");

        /// <summary>
        /// <para>Returns the closest point between the navigation surface and the segment.</para>
        /// </summary>
        [GodotMethod("map_get_closest_point_to_segment")]
        public static Vector3 MapGetClosestPointToSegment(RID map, Vector3 start, Vector3 end, bool useCollision = false)
        {
            NativeCalls.godot_icall_4_659(method_bind_13, ptr, RID.GetPtr(map), ref start, ref end, useCollision, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "map_get_closest_point");

        /// <summary>
        /// <para>Returns the point closest to the provided <c>to_point</c> on the navigation mesh surface.</para>
        /// </summary>
        [GodotMethod("map_get_closest_point")]
        public static Vector3 MapGetClosestPoint(RID map, Vector3 toPoint)
        {
            NativeCalls.godot_icall_2_660(method_bind_14, ptr, RID.GetPtr(map), ref toPoint, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "map_get_closest_point_normal");

        /// <summary>
        /// <para>Returns the normal for the point returned by <see cref="Godot.NavigationServer.MapGetClosestPoint"/>.</para>
        /// </summary>
        [GodotMethod("map_get_closest_point_normal")]
        public static Vector3 MapGetClosestPointNormal(RID map, Vector3 toPoint)
        {
            NativeCalls.godot_icall_2_660(method_bind_15, ptr, RID.GetPtr(map), ref toPoint, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "map_get_closest_point_owner");

        /// <summary>
        /// <para>Returns the owner region RID for the point returned by <see cref="Godot.NavigationServer.MapGetClosestPoint"/>.</para>
        /// </summary>
        [GodotMethod("map_get_closest_point_owner")]
        public static RID MapGetClosestPointOwner(RID map, Vector3 toPoint)
        {
            return new RID(NativeCalls.godot_icall_2_661(method_bind_16, ptr, RID.GetPtr(map), ref toPoint));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "map_get_regions");

        /// <summary>
        /// <para>Returns all navigation regions <see cref="Godot.RID"/>s that are currently assigned to the requested navigation <c>map</c>.</para>
        /// </summary>
        [GodotMethod("map_get_regions")]
        public static Godot.Collections.Array MapGetRegions(RID map)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_1_635(method_bind_17, ptr, RID.GetPtr(map)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "map_get_agents");

        /// <summary>
        /// <para>Returns all navigation agents <see cref="Godot.RID"/>s that are currently assigned to the requested navigation <c>map</c>.</para>
        /// </summary>
        [GodotMethod("map_get_agents")]
        public static Godot.Collections.Array MapGetAgents(RID map)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_1_635(method_bind_18, ptr, RID.GetPtr(map)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "map_force_update");

        /// <summary>
        /// <para>This function immediately forces synchronization of the specified navigation <c>map</c> <see cref="Godot.RID"/>. By default navigation maps are only synchronized at the end of each physics frame. This function can be used to immediately (re)calculate all the navigation meshes and region connections of the navigation map. This makes it possible to query a navigation path for a changed map immediately and in the same frame (multiple times if needed).</para>
        /// <para>Due to technical restrictions the current NavigationServer command queue will be flushed. This means all already queued update commands for this physics frame will be executed, even those intended for other maps, regions and agents not part of the specified map. The expensive computation of the navigation meshes and region connections of a map will only be done for the specified map. Other maps will receive the normal synchronization at the end of the physics frame. Should the specified map receive changes after the forced update it will update again as well when the other maps receive their update.</para>
        /// <para>Avoidance processing and dispatch of the <c>safe_velocity</c> signals is untouched by this function and continues to happen for all maps and agents at the end of the physics frame.</para>
        /// <para>Note: With great power comes great responsibility. This function should only be used by users that really know what they are doing and have a good reason for it. Forcing an immediate update of a navigation map requires locking the NavigationServer and flushing the entire NavigationServer command queue. Not only can this severely impact the performance of a game but it can also introduce bugs if used inappropriately without much foresight.</para>
        /// </summary>
        [GodotMethod("map_force_update")]
        public static void MapForceUpdate(RID map)
        {
            NativeCalls.godot_icall_1_285(method_bind_19, ptr, RID.GetPtr(map));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "region_create");

        /// <summary>
        /// <para>Creates a new region.</para>
        /// </summary>
        [GodotMethod("region_create")]
        public static RID RegionCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_20, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "region_set_enter_cost");

        /// <summary>
        /// <para>Sets the <c>enter_cost</c> for this <c>region</c>.</para>
        /// </summary>
        [GodotMethod("region_set_enter_cost")]
        public static void RegionSetEnterCost(RID region, float enterCost)
        {
            NativeCalls.godot_icall_2_630(method_bind_21, ptr, RID.GetPtr(region), enterCost);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "region_get_enter_cost");

        /// <summary>
        /// <para>Returns the <c>enter_cost</c> of this <c>region</c>.</para>
        /// </summary>
        [GodotMethod("region_get_enter_cost")]
        public static float RegionGetEnterCost(RID region)
        {
            return NativeCalls.godot_icall_1_631(method_bind_22, ptr, RID.GetPtr(region));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "region_set_travel_cost");

        /// <summary>
        /// <para>Sets the <c>travel_cost</c> for this <c>region</c>.</para>
        /// </summary>
        [GodotMethod("region_set_travel_cost")]
        public static void RegionSetTravelCost(RID region, float travelCost)
        {
            NativeCalls.godot_icall_2_630(method_bind_23, ptr, RID.GetPtr(region), travelCost);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "region_get_travel_cost");

        /// <summary>
        /// <para>Returns the <c>travel_cost</c> of this <c>region</c>.</para>
        /// </summary>
        [GodotMethod("region_get_travel_cost")]
        public static float RegionGetTravelCost(RID region)
        {
            return NativeCalls.godot_icall_1_631(method_bind_24, ptr, RID.GetPtr(region));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "region_owns_point");

        /// <summary>
        /// <para>Returns <c>true</c> if the provided <c>point</c> in world space is currently owned by the provided navigation <c>region</c>. Owned in this context means that one of the region's navigation mesh polygon faces has a possible position at the closest distance to this point compared to all other navigation meshes from other navigation regions that are also registered on the navigation map of the provided region.</para>
        /// <para>If multiple navigation meshes have positions at equal distance the navigation region whose polygons are processed first wins the ownership. Polygons are processed in the same order that navigation regions were registered on the NavigationServer.</para>
        /// <para>Note: If navigation meshes from different navigation regions overlap (which should be avoided in general) the result might not be what is expected.</para>
        /// </summary>
        [GodotMethod("region_owns_point")]
        public static bool RegionOwnsPoint(RID region, Vector3 point)
        {
            return NativeCalls.godot_icall_2_662(method_bind_25, ptr, RID.GetPtr(region), ref point);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "region_set_map");

        /// <summary>
        /// <para>Sets the map for the region.</para>
        /// </summary>
        [GodotMethod("region_set_map")]
        public static void RegionSetMap(RID region, RID map)
        {
            NativeCalls.godot_icall_2_637(method_bind_26, ptr, RID.GetPtr(region), RID.GetPtr(map));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "region_get_map");

        /// <summary>
        /// <para>Returns the navigation map <see cref="Godot.RID"/> the requested <c>region</c> is currently assigned to.</para>
        /// </summary>
        [GodotMethod("region_get_map")]
        public static RID RegionGetMap(RID region)
        {
            return new RID(NativeCalls.godot_icall_1_638(method_bind_27, ptr, RID.GetPtr(region)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "region_set_navigation_layers");

        /// <summary>
        /// <para>Set the region's navigation layers. This allows selecting regions from a path request (when using <see cref="Godot.NavigationServer.MapGetPath"/>).</para>
        /// </summary>
        [GodotMethod("region_set_navigation_layers")]
        public static void RegionSetNavigationLayers(RID region, uint navigationLayers)
        {
            NativeCalls.godot_icall_2_639(method_bind_28, ptr, RID.GetPtr(region), navigationLayers);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "region_get_navigation_layers");

        /// <summary>
        /// <para>Returns the region's navigation layers.</para>
        /// </summary>
        [GodotMethod("region_get_navigation_layers")]
        public static uint RegionGetNavigationLayers(RID region)
        {
            return NativeCalls.godot_icall_1_640(method_bind_29, ptr, RID.GetPtr(region));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "region_set_transform");

        /// <summary>
        /// <para>Sets the global transformation for the region.</para>
        /// </summary>
        [GodotMethod("region_set_transform")]
        public static void RegionSetTransform(RID region, Transform transform)
        {
            NativeCalls.godot_icall_2_663(method_bind_30, ptr, RID.GetPtr(region), ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "region_set_navmesh");

        /// <summary>
        /// <para>Sets the navigation mesh for the region.</para>
        /// </summary>
        [GodotMethod("region_set_navmesh")]
        public static void RegionSetNavmesh(RID region, NavigationMesh navMesh)
        {
            NativeCalls.godot_icall_2_642(method_bind_31, ptr, RID.GetPtr(region), Object.GetPtr(navMesh));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "region_bake_navmesh");

        /// <summary>
        /// <para>Bakes the navigation mesh.</para>
        /// </summary>
        [GodotMethod("region_bake_navmesh")]
        public static void RegionBakeNavmesh(NavigationMesh mesh, Node node)
        {
            NativeCalls.godot_icall_2_651(method_bind_32, ptr, Object.GetPtr(mesh), Object.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "region_get_connections_count");

        /// <summary>
        /// <para>Returns how many connections this <c>region</c> has with other regions in the map.</para>
        /// </summary>
        [GodotMethod("region_get_connections_count")]
        public static int RegionGetConnectionsCount(RID region)
        {
            return NativeCalls.godot_icall_1_643(method_bind_33, ptr, RID.GetPtr(region));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "region_get_connection_pathway_start");

        /// <summary>
        /// <para>Returns the starting point of a connection door. <c>connection</c> is an index between 0 and the return value of <see cref="Godot.NavigationServer.RegionGetConnectionsCount"/>.</para>
        /// </summary>
        [GodotMethod("region_get_connection_pathway_start")]
        public static Vector3 RegionGetConnectionPathwayStart(RID region, int connection)
        {
            NativeCalls.godot_icall_2_664(method_bind_34, ptr, RID.GetPtr(region), connection, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "region_get_connection_pathway_end");

        /// <summary>
        /// <para>Returns the ending point of a connection door. <c>connection</c> is an index between 0 and the return value of <see cref="Godot.NavigationServer.RegionGetConnectionsCount"/>.</para>
        /// </summary>
        [GodotMethod("region_get_connection_pathway_end")]
        public static Vector3 RegionGetConnectionPathwayEnd(RID region, int connection)
        {
            NativeCalls.godot_icall_2_664(method_bind_35, ptr, RID.GetPtr(region), connection, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "agent_create");

        /// <summary>
        /// <para>Creates the agent.</para>
        /// </summary>
        [GodotMethod("agent_create")]
        public static RID AgentCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_36, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "agent_set_map");

        /// <summary>
        /// <para>Puts the agent in the map.</para>
        /// </summary>
        [GodotMethod("agent_set_map")]
        public static void AgentSetMap(RID agent, RID map)
        {
            NativeCalls.godot_icall_2_637(method_bind_37, ptr, RID.GetPtr(agent), RID.GetPtr(map));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "agent_get_map");

        /// <summary>
        /// <para>Returns the navigation map <see cref="Godot.RID"/> the requested <c>agent</c> is currently assigned to.</para>
        /// </summary>
        [GodotMethod("agent_get_map")]
        public static RID AgentGetMap(RID agent)
        {
            return new RID(NativeCalls.godot_icall_1_638(method_bind_38, ptr, RID.GetPtr(agent)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "agent_set_neighbor_dist");

        /// <summary>
        /// <para>Sets the maximum distance to other agents this agent takes into account in the navigation. The larger this number, the longer the running time of the simulation. If the number is too low, the simulation will not be safe.</para>
        /// </summary>
        [GodotMethod("agent_set_neighbor_dist")]
        public static void AgentSetNeighborDist(RID agent, float dist)
        {
            NativeCalls.godot_icall_2_630(method_bind_39, ptr, RID.GetPtr(agent), dist);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "agent_set_max_neighbors");

        /// <summary>
        /// <para>Sets the maximum number of other agents the agent takes into account in the navigation. The larger this number, the longer the running time of the simulation. If the number is too low, the simulation will not be safe.</para>
        /// </summary>
        [GodotMethod("agent_set_max_neighbors")]
        public static void AgentSetMaxNeighbors(RID agent, int count)
        {
            NativeCalls.godot_icall_2_645(method_bind_40, ptr, RID.GetPtr(agent), count);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "agent_set_time_horizon");

        /// <summary>
        /// <para>The minimal amount of time for which the agent's velocities that are computed by the simulation are safe with respect to other agents. The larger this number, the sooner this agent will respond to the presence of other agents, but the less freedom this agent has in choosing its velocities. Must be positive.</para>
        /// </summary>
        [GodotMethod("agent_set_time_horizon")]
        public static void AgentSetTimeHorizon(RID agent, float time)
        {
            NativeCalls.godot_icall_2_630(method_bind_41, ptr, RID.GetPtr(agent), time);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "agent_set_radius");

        /// <summary>
        /// <para>Sets the radius of the agent.</para>
        /// </summary>
        [GodotMethod("agent_set_radius")]
        public static void AgentSetRadius(RID agent, float radius)
        {
            NativeCalls.godot_icall_2_630(method_bind_42, ptr, RID.GetPtr(agent), radius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "agent_set_max_speed");

        /// <summary>
        /// <para>Sets the maximum speed of the agent. Must be positive.</para>
        /// </summary>
        [GodotMethod("agent_set_max_speed")]
        public static void AgentSetMaxSpeed(RID agent, float maxSpeed)
        {
            NativeCalls.godot_icall_2_630(method_bind_43, ptr, RID.GetPtr(agent), maxSpeed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "agent_set_velocity");

        /// <summary>
        /// <para>Sets the current velocity of the agent.</para>
        /// </summary>
        [GodotMethod("agent_set_velocity")]
        public static void AgentSetVelocity(RID agent, Vector3 velocity)
        {
            NativeCalls.godot_icall_2_656(method_bind_44, ptr, RID.GetPtr(agent), ref velocity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "agent_set_target_velocity");

        /// <summary>
        /// <para>Sets the new target velocity.</para>
        /// </summary>
        [GodotMethod("agent_set_target_velocity")]
        public static void AgentSetTargetVelocity(RID agent, Vector3 targetVelocity)
        {
            NativeCalls.godot_icall_2_656(method_bind_45, ptr, RID.GetPtr(agent), ref targetVelocity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "agent_set_position");

        /// <summary>
        /// <para>Sets the position of the agent in world space.</para>
        /// </summary>
        [GodotMethod("agent_set_position")]
        public static void AgentSetPosition(RID agent, Vector3 position)
        {
            NativeCalls.godot_icall_2_656(method_bind_46, ptr, RID.GetPtr(agent), ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "agent_is_map_changed");

        /// <summary>
        /// <para>Returns <c>true</c> if the map got changed the previous frame.</para>
        /// </summary>
        [GodotMethod("agent_is_map_changed")]
        public static bool AgentIsMapChanged(RID agent)
        {
            return NativeCalls.godot_icall_1_629(method_bind_47, ptr, RID.GetPtr(agent));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "agent_set_callback");

        /// <summary>
        /// <para>Callback called at the end of the RVO process. If a callback is created manually and the agent is placed on a navigation map it will calculate avoidance for the agent and dispatch the calculated <c>safe_velocity</c> to the <c>receiver</c> object with a signal to the chosen <c>method</c> name.</para>
        /// <para>Note: Created callbacks are always processed independently of the SceneTree state as long as the agent is on a navigation map and not freed. To disable the dispatch of a callback from an agent use <see cref="Godot.NavigationServer.AgentSetCallback"/> again with a <c>null</c> object as the <c>receiver</c>.</para>
        /// </summary>
        [GodotMethod("agent_set_callback")]
        public static void AgentSetCallback(RID agent, Object receiver, string method, object userdata = null)
        {
            NativeCalls.godot_icall_4_647(method_bind_48, ptr, RID.GetPtr(agent), Object.GetPtr(receiver), method, userdata);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "free_rid");

        /// <summary>
        /// <para>Destroys the given RID.</para>
        /// </summary>
        [GodotMethod("free_rid")]
        public static void FreeRid(RID rid)
        {
            NativeCalls.godot_icall_1_285(method_bind_49, ptr, RID.GetPtr(rid));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_active");

        /// <summary>
        /// <para>Control activation of this server.</para>
        /// </summary>
        [GodotMethod("set_active")]
        public static void SetActive(bool active)
        {
            NativeCalls.godot_icall_1_16(method_bind_50, ptr, active);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "process");

        /// <summary>
        /// <para>Process the collision avoidance agents.</para>
        /// <para>The result of this process is needed by the physics server, so this must be called in the main thread.</para>
        /// <para>Note: This function is not thread safe.</para>
        /// </summary>
        [GodotMethod("process")]
        public static void Process(float deltaTime)
        {
            NativeCalls.godot_icall_1_15(method_bind_51, ptr, deltaTime);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
