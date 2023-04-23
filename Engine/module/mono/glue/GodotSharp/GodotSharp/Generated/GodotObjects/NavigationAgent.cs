using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>3D agent that is used in navigation to reach a location while avoiding static and dynamic obstacles. The dynamic obstacles are avoided using RVO (Reciprocal Velocity Obstacles) collision avoidance. The agent needs navigation data to work correctly. By default this node will register to the default <see cref="Godot.World"/> navigation map. If this node is a child of a <see cref="Godot.Navigation"/> node it will register to the navigation map of the navigation node or the function <see cref="Godot.NavigationAgent.SetNavigation"/> can be used to set the navigation node directly. <see cref="Godot.NavigationAgent"/> is physics safe.</para>
    /// <para>Note: After <see cref="Godot.NavigationAgent.SetTargetLocation"/> is used it is required to use the <see cref="Godot.NavigationAgent.GetNextLocation"/> function once every physics frame to update the internal path logic of the NavigationAgent. The returned vector position from this function should be used as the next movement position for the agent's parent Node.</para>
    /// <para>Note: By default, the expensive calculations for avoidance are done in a thread. In HTML5 exports without thread support, they will be done on the main thread, which can lead to performance issues.</para>
    /// </summary>
    public partial class NavigationAgent : Node
    {
        /// <summary>
        /// <para>The distance threshold before a path point is considered to be reached. This will allow an agent to not have to hit a path point on the path exactly, but in the area. If this value is set to high the NavigationAgent will skip points on the path which can lead to leaving the navigation mesh. If this value is set to low the NavigationAgent will be stuck in a repath loop cause it will constantly overshoot or undershoot the distance to the next point on each physics frame update.</para>
        /// </summary>
        public float PathDesiredDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPathDesiredDistance();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPathDesiredDistance(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The distance threshold before the final target point is considered to be reached. This will allow an agent to not have to hit the point of the final target exactly, but only the area. If this value is set to low the NavigationAgent will be stuck in a repath loop cause it will constantly overshoot or undershoot the distance to the final target point on each physics frame update.</para>
        /// </summary>
        public float TargetDesiredDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTargetDesiredDistance();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTargetDesiredDistance(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The NavigationAgent height offset is subtracted from the y-axis value of any vector path position for this NavigationAgent. The NavigationAgent height offset does not change or influence the navigation mesh or pathfinding query result. Additional navigation maps that use regions with navigation meshes that the developer baked with appropriate agent radius or height values are required to support different-sized agents.</para>
        /// </summary>
        public float AgentHeightOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAgentHeightOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAgentHeightOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum distance the agent is allowed away from the ideal path to the final location. This can happen due to trying to avoid collisions. When the maximum distance is exceeded, it recalculates the ideal path.</para>
        /// </summary>
        public float PathMaxDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPathMaxDistance();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPathMaxDistance(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A bitfield determining all navigation map layers the <see cref="Godot.NavigationAgent"/> belongs to. On path requests the agent will ignore navmeshes without at least one matching layer.</para>
        /// </summary>
        public uint NavigationLayers
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNavigationLayers();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetNavigationLayers(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c> the agent is registered for an RVO avoidance callback on the <see cref="Godot.NavigationServer"/>. When <see cref="Godot.NavigationAgent.SetVelocity"/> is used and the processing is completed a <c>safe_velocity</c> Vector3 is received with a signal connection to <c>velocity_computed</c>. Avoidance processing with many registered agents has a significant performance cost and should only be enabled on agents that currently require it.</para>
        /// </summary>
        public bool AvoidanceEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAvoidanceEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAvoidanceEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The radius of the avoidance agent. This is the "body" of the avoidance agent and not the avoidance maneuver starting radius (which is controlled by <see cref="Godot.NavigationAgent.NeighborDist"/>).</para>
        /// <para>Does not affect normal pathfinding. To change an actor's pathfinding radius bake <see cref="Godot.NavigationMesh"/> resources with a different <see cref="Godot.NavigationMesh.AgentRadius"/> property and use different navigation maps for each actor size.</para>
        /// </summary>
        public float Radius
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRadius();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRadius(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The distance to search for other agents.</para>
        /// </summary>
        public float NeighborDist
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNeighborDist();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetNeighborDist(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum number of neighbors for the agent to consider.</para>
        /// </summary>
        public int MaxNeighbors
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaxNeighbors();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaxNeighbors(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The minimal amount of time for which this agent's velocities, that are computed with the collision avoidance algorithm, are safe with respect to other agents. The larger the number, the sooner the agent will respond to other agents, but the less freedom in choosing its velocities. Must be positive.</para>
        /// </summary>
        public float TimeHorizon
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTimeHorizon();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTimeHorizon(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum speed that an agent can move.</para>
        /// </summary>
        public float MaxSpeed
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaxSpeed();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaxSpeed(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Ignores collisions on the Y axis. Must be <c>true</c> to move on a horizontal plane.</para>
        /// </summary>
        public bool IgnoreY
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetIgnoreY();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetIgnoreY(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "NavigationAgent";

        public NavigationAgent() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_NavigationAgent_Ctor(this);
        }

        internal NavigationAgent(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rid");

        /// <summary>
        /// <para>Returns the <see cref="Godot.RID"/> of this agent on the <see cref="Godot.NavigationServer"/>.</para>
        /// </summary>
        [GodotMethod("get_rid")]
        public RID GetRid()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_0, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_avoidance_enabled");

        [GodotMethod("set_avoidance_enabled")]
        [Obsolete("SetAvoidanceEnabled is deprecated. Use the AvoidanceEnabled property instead.")]
        public void SetAvoidanceEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_1, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_avoidance_enabled");

        [GodotMethod("get_avoidance_enabled")]
        [Obsolete("GetAvoidanceEnabled is deprecated. Use the AvoidanceEnabled property instead.")]
        public bool GetAvoidanceEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_path_desired_distance");

        [GodotMethod("set_path_desired_distance")]
        [Obsolete("SetPathDesiredDistance is deprecated. Use the PathDesiredDistance property instead.")]
        public void SetPathDesiredDistance(float desiredDistance)
        {
            NativeCalls.godot_icall_1_15(method_bind_3, Object.GetPtr(this), desiredDistance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_path_desired_distance");

        [GodotMethod("get_path_desired_distance")]
        [Obsolete("GetPathDesiredDistance is deprecated. Use the PathDesiredDistance property instead.")]
        public float GetPathDesiredDistance()
        {
            return NativeCalls.godot_icall_0_14(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_target_desired_distance");

        [GodotMethod("set_target_desired_distance")]
        [Obsolete("SetTargetDesiredDistance is deprecated. Use the TargetDesiredDistance property instead.")]
        public void SetTargetDesiredDistance(float desiredDistance)
        {
            NativeCalls.godot_icall_1_15(method_bind_5, Object.GetPtr(this), desiredDistance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_target_desired_distance");

        [GodotMethod("get_target_desired_distance")]
        [Obsolete("GetTargetDesiredDistance is deprecated. Use the TargetDesiredDistance property instead.")]
        public float GetTargetDesiredDistance()
        {
            return NativeCalls.godot_icall_0_14(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_radius");

        [GodotMethod("set_radius")]
        [Obsolete("SetRadius is deprecated. Use the Radius property instead.")]
        public void SetRadius(float radius)
        {
            NativeCalls.godot_icall_1_15(method_bind_7, Object.GetPtr(this), radius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_radius");

        [GodotMethod("get_radius")]
        [Obsolete("GetRadius is deprecated. Use the Radius property instead.")]
        public float GetRadius()
        {
            return NativeCalls.godot_icall_0_14(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_agent_height_offset");

        [GodotMethod("set_agent_height_offset")]
        [Obsolete("SetAgentHeightOffset is deprecated. Use the AgentHeightOffset property instead.")]
        public void SetAgentHeightOffset(float agentHeightOffset)
        {
            NativeCalls.godot_icall_1_15(method_bind_9, Object.GetPtr(this), agentHeightOffset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_agent_height_offset");

        [GodotMethod("get_agent_height_offset")]
        [Obsolete("GetAgentHeightOffset is deprecated. Use the AgentHeightOffset property instead.")]
        public float GetAgentHeightOffset()
        {
            return NativeCalls.godot_icall_0_14(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ignore_y");

        [GodotMethod("set_ignore_y")]
        [Obsolete("SetIgnoreY is deprecated. Use the IgnoreY property instead.")]
        public void SetIgnoreY(bool ignore)
        {
            NativeCalls.godot_icall_1_16(method_bind_11, Object.GetPtr(this), ignore);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ignore_y");

        [GodotMethod("get_ignore_y")]
        [Obsolete("GetIgnoreY is deprecated. Use the IgnoreY property instead.")]
        public bool GetIgnoreY()
        {
            return NativeCalls.godot_icall_0_7(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_navigation");

        /// <summary>
        /// <para>Sets the <see cref="Godot.Navigation"/> node used by the agent. Useful when you don't want to make the agent a child of a <see cref="Godot.Navigation"/> node.</para>
        /// </summary>
        [GodotMethod("set_navigation")]
        public void SetNavigation(Node navigation)
        {
            NativeCalls.godot_icall_1_53(method_bind_13, Object.GetPtr(this), Object.GetPtr(navigation));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_navigation");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Navigation"/> node that the agent is using for its navigation system.</para>
        /// </summary>
        [GodotMethod("get_navigation")]
        public Node GetNavigation()
        {
            return NativeCalls.godot_icall_0_257(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_neighbor_dist");

        [GodotMethod("set_neighbor_dist")]
        [Obsolete("SetNeighborDist is deprecated. Use the NeighborDist property instead.")]
        public void SetNeighborDist(float neighborDist)
        {
            NativeCalls.godot_icall_1_15(method_bind_15, Object.GetPtr(this), neighborDist);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_neighbor_dist");

        [GodotMethod("get_neighbor_dist")]
        [Obsolete("GetNeighborDist is deprecated. Use the NeighborDist property instead.")]
        public float GetNeighborDist()
        {
            return NativeCalls.godot_icall_0_14(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max_neighbors");

        [GodotMethod("set_max_neighbors")]
        [Obsolete("SetMaxNeighbors is deprecated. Use the MaxNeighbors property instead.")]
        public void SetMaxNeighbors(int maxNeighbors)
        {
            NativeCalls.godot_icall_1_4(method_bind_17, Object.GetPtr(this), maxNeighbors);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max_neighbors");

        [GodotMethod("get_max_neighbors")]
        [Obsolete("GetMaxNeighbors is deprecated. Use the MaxNeighbors property instead.")]
        public int GetMaxNeighbors()
        {
            return NativeCalls.godot_icall_0_5(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_time_horizon");

        [GodotMethod("set_time_horizon")]
        [Obsolete("SetTimeHorizon is deprecated. Use the TimeHorizon property instead.")]
        public void SetTimeHorizon(float timeHorizon)
        {
            NativeCalls.godot_icall_1_15(method_bind_19, Object.GetPtr(this), timeHorizon);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_time_horizon");

        [GodotMethod("get_time_horizon")]
        [Obsolete("GetTimeHorizon is deprecated. Use the TimeHorizon property instead.")]
        public float GetTimeHorizon()
        {
            return NativeCalls.godot_icall_0_14(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max_speed");

        [GodotMethod("set_max_speed")]
        [Obsolete("SetMaxSpeed is deprecated. Use the MaxSpeed property instead.")]
        public void SetMaxSpeed(float maxSpeed)
        {
            NativeCalls.godot_icall_1_15(method_bind_21, Object.GetPtr(this), maxSpeed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max_speed");

        [GodotMethod("get_max_speed")]
        [Obsolete("GetMaxSpeed is deprecated. Use the MaxSpeed property instead.")]
        public float GetMaxSpeed()
        {
            return NativeCalls.godot_icall_0_14(method_bind_22, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_path_max_distance");

        [GodotMethod("set_path_max_distance")]
        [Obsolete("SetPathMaxDistance is deprecated. Use the PathMaxDistance property instead.")]
        public void SetPathMaxDistance(float maxSpeed)
        {
            NativeCalls.godot_icall_1_15(method_bind_23, Object.GetPtr(this), maxSpeed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_path_max_distance");

        [GodotMethod("get_path_max_distance")]
        [Obsolete("GetPathMaxDistance is deprecated. Use the PathMaxDistance property instead.")]
        public float GetPathMaxDistance()
        {
            return NativeCalls.godot_icall_0_14(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_navigation_layers");

        [GodotMethod("set_navigation_layers")]
        [Obsolete("SetNavigationLayers is deprecated. Use the NavigationLayers property instead.")]
        public void SetNavigationLayers(uint navigationLayers)
        {
            NativeCalls.godot_icall_1_187(method_bind_25, Object.GetPtr(this), navigationLayers);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_navigation_layers");

        [GodotMethod("get_navigation_layers")]
        [Obsolete("GetNavigationLayers is deprecated. Use the NavigationLayers property instead.")]
        public uint GetNavigationLayers()
        {
            return NativeCalls.godot_icall_0_188(method_bind_26, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_navigation_map");

        /// <summary>
        /// <para>Sets the <see cref="Godot.RID"/> of the navigation map this NavigationAgent node should use and also updates the <c>agent</c> on the NavigationServer.</para>
        /// </summary>
        [GodotMethod("set_navigation_map")]
        public void SetNavigationMap(RID navigationMap)
        {
            NativeCalls.godot_icall_1_285(method_bind_27, Object.GetPtr(this), RID.GetPtr(navigationMap));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_navigation_map");

        /// <summary>
        /// <para>Returns the <see cref="Godot.RID"/> of the navigation map for this NavigationAgent node. This function returns always the map set on the NavigationAgent node and not the map of the abstract agent on the NavigationServer. If the agent map is changed directly with the NavigationServer API the NavigationAgent node will not be aware of the map change. Use <see cref="Godot.NavigationAgent.SetNavigationMap"/> to change the navigation map for the NavigationAgent and also update the agent on the NavigationServer.</para>
        /// </summary>
        [GodotMethod("get_navigation_map")]
        public RID GetNavigationMap()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_28, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_target_location");

        /// <summary>
        /// <para>Sets the user desired final location. This will clear the current navigation path.</para>
        /// </summary>
        [GodotMethod("set_target_location")]
        public void SetTargetLocation(Vector3 location)
        {
            NativeCalls.godot_icall_1_148(method_bind_29, Object.GetPtr(this), ref location);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_target_location");

        /// <summary>
        /// <para>Returns the user-defined target location (set with <see cref="Godot.NavigationAgent.SetTargetLocation"/>).</para>
        /// </summary>
        [GodotMethod("get_target_location")]
        public Vector3 GetTargetLocation()
        {
            NativeCalls.godot_icall_0_8(method_bind_30, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_next_location");

        /// <summary>
        /// <para>Returns the next location in global coordinates that can be moved to, making sure that there are no static objects in the way. If the agent does not have a navigation path, it will return the position of the agent's parent. The use of this function once every physics frame is required to update the internal path logic of the NavigationAgent.</para>
        /// </summary>
        [GodotMethod("get_next_location")]
        public Vector3 GetNextLocation()
        {
            NativeCalls.godot_icall_0_8(method_bind_31, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "distance_to_target");

        /// <summary>
        /// <para>Returns the distance to the target location, using the agent's global position. The user must set the target location with <see cref="Godot.NavigationAgent.SetTargetLocation"/> in order for this to be accurate.</para>
        /// </summary>
        [GodotMethod("distance_to_target")]
        public float DistanceToTarget()
        {
            return NativeCalls.godot_icall_0_14(method_bind_32, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_velocity");

        /// <summary>
        /// <para>Sends the passed in velocity to the collision avoidance algorithm. It will adjust the velocity to avoid collisions. Once the adjustment to the velocity is complete, it will emit the <c>velocity_computed</c> signal.</para>
        /// </summary>
        [GodotMethod("set_velocity")]
        public void SetVelocity(Vector3 velocity)
        {
            NativeCalls.godot_icall_1_148(method_bind_33, Object.GetPtr(this), ref velocity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_nav_path");

        /// <summary>
        /// <para>Returns this agent's current path from start to finish in global coordinates. The path only updates when the target location is changed or the agent requires a repath. The path array is not intended to be used in direct path movement as the agent has its own internal path logic that would get corrupted by changing the path array manually. Use the intended <see cref="Godot.NavigationAgent.GetNextLocation"/> once every physics frame to receive the next path point for the agents movement as this function also updates the internal path logic.</para>
        /// </summary>
        [GodotMethod("get_nav_path")]
        public Vector3[] GetNavPath()
        {
            return NativeCalls.godot_icall_0_230(method_bind_34, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_nav_path_index");

        /// <summary>
        /// <para>Returns which index the agent is currently on in the navigation path's <see cref="Godot.Vector3"/>.</para>
        /// </summary>
        [GodotMethod("get_nav_path_index")]
        public int GetNavPathIndex()
        {
            return NativeCalls.godot_icall_0_5(method_bind_35, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_target_reached");

        /// <summary>
        /// <para>Returns <c>true</c> if the target location is reached. The target location is set using <see cref="Godot.NavigationAgent.SetTargetLocation"/>. It may not always be possible to reach the target location. It should always be possible to reach the final location though. See <see cref="Godot.NavigationAgent.GetFinalLocation"/>.</para>
        /// </summary>
        [GodotMethod("is_target_reached")]
        public bool IsTargetReached()
        {
            return NativeCalls.godot_icall_0_7(method_bind_36, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_target_reachable");

        /// <summary>
        /// <para>Returns <c>true</c> if the target location is reachable. The target location is set using <see cref="Godot.NavigationAgent.SetTargetLocation"/>.</para>
        /// </summary>
        [GodotMethod("is_target_reachable")]
        public bool IsTargetReachable()
        {
            return NativeCalls.godot_icall_0_7(method_bind_37, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_navigation_finished");

        /// <summary>
        /// <para>Returns <c>true</c> if the navigation path's final location has been reached.</para>
        /// </summary>
        [GodotMethod("is_navigation_finished")]
        public bool IsNavigationFinished()
        {
            return NativeCalls.godot_icall_0_7(method_bind_38, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_final_location");

        /// <summary>
        /// <para>Returns the reachable final location in global coordinates. This can change if the navigation path is altered in any way. Because of this, it would be best to check this each frame.</para>
        /// </summary>
        [GodotMethod("get_final_location")]
        public Vector3 GetFinalLocation()
        {
            NativeCalls.godot_icall_0_8(method_bind_39, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
