using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>GraphEdit manages the showing of GraphNodes it contains, as well as connections and disconnections between them. Signals are sent for each of these two events. Disconnection between GraphNode slots is disabled by default.</para>
    /// <para>It is greatly advised to enable low-processor usage mode (see <see cref="Godot.OS.LowProcessorUsageMode"/>) when using GraphEdits.</para>
    /// </summary>
    public partial class GraphEdit : Control
    {
        /// <summary>
        /// <para>If <c>true</c>, enables disconnection of existing connections in the GraphEdit by dragging the right end.</para>
        /// </summary>
        public bool RightDisconnects
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsRightDisconnectsEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRightDisconnects(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The scroll offset.</para>
        /// </summary>
        public Vector2 ScrollOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetScrollOfs();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetScrollOfs(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The snapping distance in pixels.</para>
        /// </summary>
        public int SnapDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSnap();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSnap(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, enables snapping.</para>
        /// </summary>
        public bool UseSnap
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUsingSnap();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseSnap(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The current zoom value.</para>
        /// </summary>
        public float Zoom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetZoom();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetZoom(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The lower zoom limit.</para>
        /// </summary>
        public float ZoomMin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetZoomMin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetZoomMin(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The upper zoom limit.</para>
        /// </summary>
        public float ZoomMax
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetZoomMax();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetZoomMax(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The step of each zoom level.</para>
        /// </summary>
        public float ZoomStep
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetZoomStep();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetZoomStep(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, makes a label with the current zoom level visible. The zoom value is displayed in percents.</para>
        /// </summary>
        public bool ShowZoomLabel
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsShowingZoomLabel();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShowZoomLabel(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the minimap is visible.</para>
        /// </summary>
        public bool MinimapEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsMinimapEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMinimapEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The size of the minimap rectangle. The map itself is based on the size of the grid area and is scaled to fit this rectangle.</para>
        /// </summary>
        public Vector2 MinimapSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMinimapSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMinimapSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The opacity of the minimap rectangle.</para>
        /// </summary>
        public float MinimapOpacity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMinimapOpacity();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMinimapOpacity(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "GraphEdit";

        public GraphEdit() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GraphEdit_Ctor(this);
        }

        internal GraphEdit(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "connect_node");

        /// <summary>
        /// <para>Create a connection between the <c>from_port</c> slot of the <c>from</c> GraphNode and the <c>to_port</c> slot of the <c>to</c> GraphNode. If the connection already exists, no connection is created.</para>
        /// </summary>
        [GodotMethod("connect_node")]
        public Error ConnectNode(string from, int fromPort, string to, int toPort)
        {
            return (Error)NativeCalls.godot_icall_4_470(method_bind_0, Object.GetPtr(this), from, fromPort, to, toPort);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_node_connected");

        /// <summary>
        /// <para>Returns <c>true</c> if the <c>from_port</c> slot of the <c>from</c> GraphNode is connected to the <c>to_port</c> slot of the <c>to</c> GraphNode.</para>
        /// </summary>
        [GodotMethod("is_node_connected")]
        public bool IsNodeConnected(string from, int fromPort, string to, int toPort)
        {
            return NativeCalls.godot_icall_4_471(method_bind_1, Object.GetPtr(this), from, fromPort, to, toPort);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "disconnect_node");

        /// <summary>
        /// <para>Removes the connection between the <c>from_port</c> slot of the <c>from</c> GraphNode and the <c>to_port</c> slot of the <c>to</c> GraphNode. If the connection does not exist, no connection is removed.</para>
        /// </summary>
        [GodotMethod("disconnect_node")]
        public void DisconnectNode(string from, int fromPort, string to, int toPort)
        {
            NativeCalls.godot_icall_4_472(method_bind_2, Object.GetPtr(this), from, fromPort, to, toPort);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_connection_activity");

        /// <summary>
        /// <para>Sets the coloration of the connection between <c>from</c>'s <c>from_port</c> and <c>to</c>'s <c>to_port</c> with the color provided in the <c>activity</c> theme property.</para>
        /// </summary>
        [GodotMethod("set_connection_activity")]
        public void SetConnectionActivity(string from, int fromPort, string to, int toPort, float amount)
        {
            NativeCalls.godot_icall_5_473(method_bind_3, Object.GetPtr(this), from, fromPort, to, toPort, amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connection_list");

        /// <summary>
        /// <para>Returns an Array containing the list of connections. A connection consists in a structure of the form <c>{ from_port: 0, from: "GraphNode name 0", to_port: 1, to: "GraphNode name 1" }</c>.</para>
        /// </summary>
        [GodotMethod("get_connection_list")]
        public Godot.Collections.Array GetConnectionList()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_4, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_connections");

        /// <summary>
        /// <para>Removes all connections between nodes.</para>
        /// </summary>
        [GodotMethod("clear_connections")]
        public void ClearConnections()
        {
            NativeCalls.godot_icall_0_3(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_scroll_ofs");

        [GodotMethod("get_scroll_ofs")]
        [Obsolete("GetScrollOfs is deprecated. Use the ScrollOffset property instead.")]
        public Vector2 GetScrollOfs()
        {
            NativeCalls.godot_icall_0_18(method_bind_6, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_scroll_ofs");

        [GodotMethod("set_scroll_ofs")]
        [Obsolete("SetScrollOfs is deprecated. Use the ScrollOffset property instead.")]
        public void SetScrollOfs(Vector2 ofs)
        {
            NativeCalls.godot_icall_1_57(method_bind_7, Object.GetPtr(this), ref ofs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_valid_right_disconnect_type");

        /// <summary>
        /// <para>Makes possible to disconnect nodes when dragging from the slot at the right if it has the specified type.</para>
        /// </summary>
        [GodotMethod("add_valid_right_disconnect_type")]
        public void AddValidRightDisconnectType(int type)
        {
            NativeCalls.godot_icall_1_4(method_bind_8, Object.GetPtr(this), type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_valid_right_disconnect_type");

        /// <summary>
        /// <para>Removes the possibility to disconnect nodes when dragging from the slot at the right if it has the specified type.</para>
        /// </summary>
        [GodotMethod("remove_valid_right_disconnect_type")]
        public void RemoveValidRightDisconnectType(int type)
        {
            NativeCalls.godot_icall_1_4(method_bind_9, Object.GetPtr(this), type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_valid_left_disconnect_type");

        /// <summary>
        /// <para>Makes possible to disconnect nodes when dragging from the slot at the left if it has the specified type.</para>
        /// </summary>
        [GodotMethod("add_valid_left_disconnect_type")]
        public void AddValidLeftDisconnectType(int type)
        {
            NativeCalls.godot_icall_1_4(method_bind_10, Object.GetPtr(this), type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_valid_left_disconnect_type");

        /// <summary>
        /// <para>Removes the possibility to disconnect nodes when dragging from the slot at the left if it has the specified type.</para>
        /// </summary>
        [GodotMethod("remove_valid_left_disconnect_type")]
        public void RemoveValidLeftDisconnectType(int type)
        {
            NativeCalls.godot_icall_1_4(method_bind_11, Object.GetPtr(this), type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_valid_connection_type");

        /// <summary>
        /// <para>Makes possible the connection between two different slot types. The type is defined with the <see cref="Godot.GraphNode.SetSlot"/> method.</para>
        /// </summary>
        [GodotMethod("add_valid_connection_type")]
        public void AddValidConnectionType(int fromType, int toType)
        {
            NativeCalls.godot_icall_2_65(method_bind_12, Object.GetPtr(this), fromType, toType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_valid_connection_type");

        /// <summary>
        /// <para>Makes it not possible to connect between two different slot types. The type is defined with the <see cref="Godot.GraphNode.SetSlot"/> method.</para>
        /// </summary>
        [GodotMethod("remove_valid_connection_type")]
        public void RemoveValidConnectionType(int fromType, int toType)
        {
            NativeCalls.godot_icall_2_65(method_bind_13, Object.GetPtr(this), fromType, toType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_valid_connection_type");

        /// <summary>
        /// <para>Returns whether it's possible to connect slots of the specified types.</para>
        /// </summary>
        [GodotMethod("is_valid_connection_type")]
        public bool IsValidConnectionType(int fromType, int toType)
        {
            return NativeCalls.godot_icall_2_177(method_bind_14, Object.GetPtr(this), fromType, toType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_zoom");

        [GodotMethod("set_zoom")]
        [Obsolete("SetZoom is deprecated. Use the Zoom property instead.")]
        public void SetZoom(float pZoom)
        {
            NativeCalls.godot_icall_1_15(method_bind_15, Object.GetPtr(this), pZoom);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_zoom");

        [GodotMethod("get_zoom")]
        [Obsolete("GetZoom is deprecated. Use the Zoom property instead.")]
        public float GetZoom()
        {
            return NativeCalls.godot_icall_0_14(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_zoom_min");

        [GodotMethod("set_zoom_min")]
        [Obsolete("SetZoomMin is deprecated. Use the ZoomMin property instead.")]
        public void SetZoomMin(float zoomMin)
        {
            NativeCalls.godot_icall_1_15(method_bind_17, Object.GetPtr(this), zoomMin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_zoom_min");

        [GodotMethod("get_zoom_min")]
        [Obsolete("GetZoomMin is deprecated. Use the ZoomMin property instead.")]
        public float GetZoomMin()
        {
            return NativeCalls.godot_icall_0_14(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_zoom_max");

        [GodotMethod("set_zoom_max")]
        [Obsolete("SetZoomMax is deprecated. Use the ZoomMax property instead.")]
        public void SetZoomMax(float zoomMax)
        {
            NativeCalls.godot_icall_1_15(method_bind_19, Object.GetPtr(this), zoomMax);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_zoom_max");

        [GodotMethod("get_zoom_max")]
        [Obsolete("GetZoomMax is deprecated. Use the ZoomMax property instead.")]
        public float GetZoomMax()
        {
            return NativeCalls.godot_icall_0_14(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_zoom_step");

        [GodotMethod("set_zoom_step")]
        [Obsolete("SetZoomStep is deprecated. Use the ZoomStep property instead.")]
        public void SetZoomStep(float zoomStep)
        {
            NativeCalls.godot_icall_1_15(method_bind_21, Object.GetPtr(this), zoomStep);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_zoom_step");

        [GodotMethod("get_zoom_step")]
        [Obsolete("GetZoomStep is deprecated. Use the ZoomStep property instead.")]
        public float GetZoomStep()
        {
            return NativeCalls.godot_icall_0_14(method_bind_22, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_show_zoom_label");

        [GodotMethod("set_show_zoom_label")]
        [Obsolete("SetShowZoomLabel is deprecated. Use the ShowZoomLabel property instead.")]
        public void SetShowZoomLabel(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_23, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_showing_zoom_label");

        [GodotMethod("is_showing_zoom_label")]
        [Obsolete("IsShowingZoomLabel is deprecated. Use the ShowZoomLabel property instead.")]
        public bool IsShowingZoomLabel()
        {
            return NativeCalls.godot_icall_0_7(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_snap");

        [GodotMethod("set_snap")]
        [Obsolete("SetSnap is deprecated. Use the SnapDistance property instead.")]
        public void SetSnap(int pixels)
        {
            NativeCalls.godot_icall_1_4(method_bind_25, Object.GetPtr(this), pixels);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_snap");

        [GodotMethod("get_snap")]
        [Obsolete("GetSnap is deprecated. Use the SnapDistance property instead.")]
        public int GetSnap()
        {
            return NativeCalls.godot_icall_0_5(method_bind_26, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_snap");

        [GodotMethod("set_use_snap")]
        [Obsolete("SetUseSnap is deprecated. Use the UseSnap property instead.")]
        public void SetUseSnap(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_27, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_using_snap");

        [GodotMethod("is_using_snap")]
        [Obsolete("IsUsingSnap is deprecated. Use the UseSnap property instead.")]
        public bool IsUsingSnap()
        {
            return NativeCalls.godot_icall_0_7(method_bind_28, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_minimap_size");

        [GodotMethod("set_minimap_size")]
        [Obsolete("SetMinimapSize is deprecated. Use the MinimapSize property instead.")]
        public void SetMinimapSize(Vector2 pSize)
        {
            NativeCalls.godot_icall_1_57(method_bind_29, Object.GetPtr(this), ref pSize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_minimap_size");

        [GodotMethod("get_minimap_size")]
        [Obsolete("GetMinimapSize is deprecated. Use the MinimapSize property instead.")]
        public Vector2 GetMinimapSize()
        {
            NativeCalls.godot_icall_0_18(method_bind_30, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_minimap_opacity");

        [GodotMethod("set_minimap_opacity")]
        [Obsolete("SetMinimapOpacity is deprecated. Use the MinimapOpacity property instead.")]
        public void SetMinimapOpacity(float pOpacity)
        {
            NativeCalls.godot_icall_1_15(method_bind_31, Object.GetPtr(this), pOpacity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_minimap_opacity");

        [GodotMethod("get_minimap_opacity")]
        [Obsolete("GetMinimapOpacity is deprecated. Use the MinimapOpacity property instead.")]
        public float GetMinimapOpacity()
        {
            return NativeCalls.godot_icall_0_14(method_bind_32, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_minimap_enabled");

        [GodotMethod("set_minimap_enabled")]
        [Obsolete("SetMinimapEnabled is deprecated. Use the MinimapEnabled property instead.")]
        public void SetMinimapEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_33, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_minimap_enabled");

        [GodotMethod("is_minimap_enabled")]
        [Obsolete("IsMinimapEnabled is deprecated. Use the MinimapEnabled property instead.")]
        public bool IsMinimapEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_34, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_right_disconnects");

        [GodotMethod("set_right_disconnects")]
        [Obsolete("SetRightDisconnects is deprecated. Use the RightDisconnects property instead.")]
        public void SetRightDisconnects(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_35, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_right_disconnects_enabled");

        [GodotMethod("is_right_disconnects_enabled")]
        [Obsolete("IsRightDisconnectsEnabled is deprecated. Use the RightDisconnects property instead.")]
        public bool IsRightDisconnectsEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_36, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_zoom_hbox");

        /// <summary>
        /// <para>Gets the <see cref="Godot.HBoxContainer"/> that contains the zooming and grid snap controls in the top left of the graph. You can use this method to reposition the toolbar or to add your own custom controls to it.</para>
        /// <para>Warning: This is a required internal node, removing and freeing it may cause a crash. If you wish to hide it or any of its children, use their <see cref="Godot.CanvasItem.Visible"/> property.</para>
        /// </summary>
        [GodotMethod("get_zoom_hbox")]
        public HBoxContainer GetZoomHbox()
        {
            return NativeCalls.godot_icall_0_474(method_bind_37, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_selected");

        /// <summary>
        /// <para>Sets the specified <c>node</c> as the one selected.</para>
        /// </summary>
        [GodotMethod("set_selected")]
        public void SetSelected(Node node)
        {
            NativeCalls.godot_icall_1_53(method_bind_38, Object.GetPtr(this), Object.GetPtr(node));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
