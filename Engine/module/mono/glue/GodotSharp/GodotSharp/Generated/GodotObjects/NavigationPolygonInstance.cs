using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A region of the navigation map. It tells the <see cref="Godot.Navigation2DServer"/> what can be navigated and what cannot, based on its <see cref="Godot.NavigationPolygon"/> resource.</para>
    /// <para>By default this node will register to the default <see cref="Godot.World2D"/> navigation map. If this node is a child of a <see cref="Godot.Navigation2D"/> node it will register to the navigation map of the navigation node.</para>
    /// <para>Two regions can be connected to each other if they share a similar edge. You can set the minimum distance between two vertices required to connect two edges by using <see cref="Godot.Navigation2DServer.MapSetEdgeConnectionMargin"/>.</para>
    /// <para>Note: Overlapping two regions' polygons is not enough for connecting two regions. They must share a similar edge.</para>
    /// <para>The pathfinding cost of entering this region from another region can be controlled with the <see cref="Godot.NavigationPolygonInstance.EnterCost"/> value.</para>
    /// <para>Note: This value is not added to the path cost when the start position is already inside this region.</para>
    /// <para>The pathfinding cost of traveling distances inside this region can be controlled with the <see cref="Godot.NavigationPolygonInstance.TravelCost"/> multiplier.</para>
    /// </summary>
    public partial class NavigationPolygonInstance : Node2D
    {
        /// <summary>
        /// <para>The <see cref="Godot.NavigationPolygon"/> resource to use.</para>
        /// </summary>
        public NavigationPolygon Navpoly
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNavigationPolygon();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetNavigationPolygon(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Determines if the <see cref="Godot.NavigationPolygonInstance"/> is enabled or disabled.</para>
        /// </summary>
        public bool Enabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A bitfield determining all navigation map layers the <see cref="Godot.NavigationPolygon"/> belongs to. On path requests with <see cref="Godot.Navigation2DServer.MapGetPath"/> navmeshes without matching layers will be ignored and the navigation map will only proximity merge different navmeshes with matching layers.</para>
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
        /// <para>When pathfinding enters this region's navmesh from another regions navmesh the <c>enter_cost</c> value is added to the path distance for determining the shortest path.</para>
        /// </summary>
        public float EnterCost
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEnterCost();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnterCost(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When pathfinding moves inside this region's navmesh the traveled distances are multiplied with <c>travel_cost</c> for determining the shortest path.</para>
        /// </summary>
        public float TravelCost
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTravelCost();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTravelCost(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "NavigationPolygonInstance";

        public NavigationPolygonInstance() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_NavigationPolygonInstance_Ctor(this);
        }

        internal NavigationPolygonInstance(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_navigation_polygon");

        [GodotMethod("set_navigation_polygon")]
        [Obsolete("SetNavigationPolygon is deprecated. Use the Navpoly property instead.")]
        public void SetNavigationPolygon(NavigationPolygon navpoly)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(navpoly));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_navigation_polygon");

        [GodotMethod("get_navigation_polygon")]
        [Obsolete("GetNavigationPolygon is deprecated. Use the Navpoly property instead.")]
        public NavigationPolygon GetNavigationPolygon()
        {
            return NativeCalls.godot_icall_0_655(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_enabled");

        [GodotMethod("set_enabled")]
        [Obsolete("SetEnabled is deprecated. Use the Enabled property instead.")]
        public void SetEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_enabled");

        [GodotMethod("is_enabled")]
        [Obsolete("IsEnabled is deprecated. Use the Enabled property instead.")]
        public bool IsEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_navigation_layers");

        [GodotMethod("set_navigation_layers")]
        [Obsolete("SetNavigationLayers is deprecated. Use the NavigationLayers property instead.")]
        public void SetNavigationLayers(uint navigationLayers)
        {
            NativeCalls.godot_icall_1_187(method_bind_4, Object.GetPtr(this), navigationLayers);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_navigation_layers");

        [GodotMethod("get_navigation_layers")]
        [Obsolete("GetNavigationLayers is deprecated. Use the NavigationLayers property instead.")]
        public uint GetNavigationLayers()
        {
            return NativeCalls.godot_icall_0_188(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_region_rid");

        /// <summary>
        /// <para>Returns the <see cref="Godot.RID"/> of this region on the <see cref="Godot.Navigation2DServer"/>. Combined with <see cref="Godot.Navigation2DServer.MapGetClosestPointOwner"/> can be used to identify the <see cref="Godot.NavigationPolygonInstance"/> closest to a point on the merged navigation map.</para>
        /// </summary>
        [GodotMethod("get_region_rid")]
        public RID GetRegionRid()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_6, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_enter_cost");

        [GodotMethod("set_enter_cost")]
        [Obsolete("SetEnterCost is deprecated. Use the EnterCost property instead.")]
        public void SetEnterCost(float enterCost)
        {
            NativeCalls.godot_icall_1_15(method_bind_7, Object.GetPtr(this), enterCost);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_enter_cost");

        [GodotMethod("get_enter_cost")]
        [Obsolete("GetEnterCost is deprecated. Use the EnterCost property instead.")]
        public float GetEnterCost()
        {
            return NativeCalls.godot_icall_0_14(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_travel_cost");

        [GodotMethod("set_travel_cost")]
        [Obsolete("SetTravelCost is deprecated. Use the TravelCost property instead.")]
        public void SetTravelCost(float travelCost)
        {
            NativeCalls.godot_icall_1_15(method_bind_9, Object.GetPtr(this), travelCost);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_travel_cost");

        [GodotMethod("get_travel_cost")]
        [Obsolete("GetTravelCost is deprecated. Use the TravelCost property instead.")]
        public float GetTravelCost()
        {
            return NativeCalls.godot_icall_0_14(method_bind_10, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
