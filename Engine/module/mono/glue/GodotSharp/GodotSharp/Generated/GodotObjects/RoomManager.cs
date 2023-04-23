using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>In order to utilize the portal occlusion culling system, you must build your level using <see cref="Godot.Room"/>s and <see cref="Godot.Portal"/>s. Before these can be used at runtime, they must undergo a short conversion process to build the <c>room graph</c>, runtime data needed for portal culling. The <c>room graph</c> is controlled by the <see cref="Godot.RoomManager"/> node, and the <see cref="Godot.RoomManager"/> also contains settings that are common throughout the portal system.</para>
    /// </summary>
    public partial class RoomManager : Spatial
    {
        public enum PVSMode
        {
            /// <summary>
            /// <para>Use only <see cref="Godot.Portal"/>s at runtime to determine visibility. PVS will not be generated at <see cref="Godot.Room"/>s conversion, and gameplay notifications cannot be used.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>Use a combination of PVS and <see cref="Godot.Portal"/>s to determine visibility (this is usually fastest and most accurate).</para>
            /// </summary>
            Partial = 1,
            /// <summary>
            /// <para>Use only the PVS (potentially visible set) of <see cref="Godot.Room"/>s to determine visibility.</para>
            /// </summary>
            Full = 2
        }

        /// <summary>
        /// <para>Switches the portal culling system on and off.</para>
        /// <para>It is important to note that when portal culling is active, it is responsible for all the 3d culling. Some editor visual debugging helpers may not be available when active, so switching the active flag is intended to be used to ensure your <see cref="Godot.Room"/> / <see cref="Godot.Portal"/> layout works within the editor.</para>
        /// <para>Switching to <c>active</c> will have no effect when the <c>room graph</c> is unloaded (the rooms have not yet been converted).</para>
        /// <para>Note: For efficiency, the portal system is designed to work with only the core visual object types. In particular, only nodes derived from <see cref="Godot.VisualInstance"/> are expected to show when the system is active.</para>
        /// </summary>
        public bool Active
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return RoomsGetActive();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                RoomsSetActive(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>For the <see cref="Godot.Room"/> conversion process to succeed, you must point the <see cref="Godot.RoomManager"/> to the parent <see cref="Godot.Node"/> of your <see cref="Godot.Room"/>s and <see cref="Godot.RoomGroup"/>s, which we refer to as the <c>roomlist</c> (the roomlist is not a special node type, it is normally just a <see cref="Godot.Spatial"/>).</para>
        /// </summary>
        public NodePath Roomlist
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRoomlistPath();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRoomlistPath(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Optionally during conversion the potentially visible set (PVS) of rooms that are potentially visible from each room can be calculated. This can be used either to aid in dynamic portal culling, or to totally replace portal culling.</para>
        /// <para>In <c>Full</c> PVS Mode, all objects within the potentially visible rooms will be frustum culled, and rendered if they are within the view frustum.</para>
        /// </summary>
        public RoomManager.PVSMode PvsMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPvsMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPvsMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When using a partial or full PVS, the gameplay monitor allows you to receive callbacks when roaming objects or rooms enter or exit the gameplay area. The gameplay area is defined as either the primary, or secondary PVS.</para>
        /// <para>These callbacks allow you to, for example, reduce processing for objects that are far from the player, or turn on and off AI.</para>
        /// <para>You can either choose to receive callbacks as notifications through the <c>_notification</c> function, or as signals.</para>
        /// <para><c>NOTIFICATION_ENTER_GAMEPLAY</c></para>
        /// <para><c>NOTIFICATION_EXIT_GAMEPLAY</c></para>
        /// <para>Signals: <c>"gameplay_entered"</c>, <c>"gameplay_exited"</c></para>
        /// </summary>
        public bool GameplayMonitor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGameplayMonitorEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGameplayMonitorEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When receiving gameplay callbacks when objects enter and exit gameplay, the gameplay area can be defined by either the primary PVS (potentially visible set) of <see cref="Godot.Room"/>s, or the secondary PVS (the primary PVS and their neighbouring <see cref="Godot.Room"/>s).</para>
        /// <para>Sometimes using the larger gameplay area of the secondary PVS may be preferable.</para>
        /// </summary>
        public bool UseSecondaryPvs
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUseSecondaryPvs();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseSecondaryPvs(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If enabled, the system will attempt to merge similar meshes (particularly in terms of materials) within <see cref="Godot.Room"/>s during conversion. This can significantly reduce the number of drawcalls and state changes required during rendering, albeit at a cost of reduced culling granularity.</para>
        /// <para>Note: This operates at runtime during the conversion process, and will only operate on exported or running projects, in order to prevent accidental alteration to the scene and loss of data.</para>
        /// </summary>
        public bool MergeMeshes
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMergeMeshes();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMergeMeshes(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Shows the <see cref="Godot.Portal"/> margins when the portal gizmo is used in the editor.</para>
        /// </summary>
        public bool ShowMargins
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShowMargins();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShowMargins(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Large objects can 'sprawl' over (be present in) more than one room. It can be useful to visualize which objects are sprawling outside the current room.</para>
        /// <para>Toggling this setting turns this debug view on and off.</para>
        /// </summary>
        public bool DebugSprawl
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDebugSprawl();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDebugSprawl(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When converting rooms, the editor will warn you if overlap is detected between rooms. Overlap can interfere with determining the room that cameras and objects are within. A small amount can be acceptable, depending on your level. Here you can alter the threshold at which the editor warning appears. There are no other side effects.</para>
        /// </summary>
        public int OverlapWarningThreshold
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOverlapWarningThreshold();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOverlapWarningThreshold(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Portal culling normally operates using the current <see cref="Godot.Camera"/> / <see cref="Godot.Camera"/>s, however for debugging purposes within the editor, you can use this setting to override this behavior and force it to use a particular camera to get a better idea of what the occlusion culling is doing.</para>
        /// </summary>
        public NodePath PreviewCamera
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPreviewCameraPath();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPreviewCameraPath(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Portal rendering is recursive - each time a portal is seen through an earlier portal there is some cost. For this reason, and to prevent the possibility of infinite loops, this setting provides a hard limit on the recursion depth.</para>
        /// <para>Note: This value is unused when using <c>Full</c> PVS mode.</para>
        /// </summary>
        public int PortalDepthLimit
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPortalDepthLimit();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPortalDepthLimit(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>During the conversion process, the geometry of objects within <see cref="Godot.Room"/>s, or a custom specified manual bound, are used to generate a convex hull bound.</para>
        /// <para>This convex hull is required in the visibility system, and is used for many purposes. Most importantly, it is used to decide whether the <see cref="Godot.Camera"/> (or an object) is within a <see cref="Godot.Room"/>. The convex hull generating algorithm is good, but occasionally it can create too many (or too few) planes to give a good representation of the room volume.</para>
        /// <para>The <c>room_simplify</c> value can be used to gain fine control over this process. It determines how similar planes can be for them to be considered the same (and duplicates removed). The value can be set between 0 (no simplification) and 1 (maximum simplification).</para>
        /// <para>The value set here is the default for all rooms, but individual rooms can override this value if desired.</para>
        /// <para>The room convex hulls are shown as a wireframe in the editor.</para>
        /// </summary>
        public float RoomSimplify
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRoomSimplify();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRoomSimplify(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Usually we don't want objects that only just cross a boundary into an adjacent <see cref="Godot.Room"/> to sprawl into that room. To prevent this, each <see cref="Godot.Portal"/> has an extra margin, or tolerance zone where objects can enter without sprawling to a neighbouring room.</para>
        /// <para>In most cases you can set this here for all portals. It is possible to override the margin for each portal.</para>
        /// </summary>
        public float DefaultPortalMargin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDefaultPortalMargin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDefaultPortalMargin(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>In order to reduce processing for roaming objects, an expansion is applied to their AABB as they move. This expanded volume is used to calculate which rooms the roaming object is within. If the object's exact AABB is still within this expanded volume on the next move, there is no need to reprocess the object, which can save considerable CPU.</para>
        /// <para>The downside is that if the expansion is too much, the object may end up unexpectedly sprawling into neighbouring rooms and showing up where it might otherwise be culled.</para>
        /// <para>In order to balance roaming performance against culling accuracy, this expansion margin can be customized by the user. It will typically depend on your room and object sizes, and movement speeds. The default value should work reasonably in most circumstances.</para>
        /// </summary>
        public float RoamingExpansionMargin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRoamingExpansionMargin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRoamingExpansionMargin(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "RoomManager";

        public RoomManager() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_RoomManager_Ctor(this);
        }

        internal RoomManager(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rooms_convert");

        /// <summary>
        /// <para>This is the most important function in the whole portal culling system. Without it, the system cannot function.</para>
        /// <para>First it goes through every <see cref="Godot.Room"/> that is a child of the <c>room list</c> node (and <see cref="Godot.RoomGroup"/>s within) and converts and adds it to the <c>room graph</c>.</para>
        /// <para>This works for both <see cref="Godot.Room"/> nodes, and <see cref="Godot.Spatial"/> nodes that follow a special naming convention. They should begin with the prefix 'Room_', followed by the name you wish to give the room, e.g. 'Room_lounge'. This will automatically convert such <see cref="Godot.Spatial"/>s to <see cref="Godot.Room"/> nodes for you. This is useful if you want to build you entire room system in e.g. Blender, and reimport multiple times as you work on the level.</para>
        /// <para>The conversion will try to assign <see cref="Godot.VisualInstance"/>s that are children and grandchildren of the <see cref="Godot.Room"/> to the room. These should be given a suitable <c>portal mode</c> (see the <see cref="Godot.CullInstance"/> documentation). The default <c>portal mode</c> is <c>STATIC</c> - objects which are not expected to move while the level is played, which will typically be most objects.</para>
        /// <para>The conversion will usually use the geometry of these <see cref="Godot.VisualInstance"/>s (and the <see cref="Godot.Portal"/>s) to calculate a convex hull bound for the room. These bounds will be shown in the editor with a wireframe. Alternatively you can specify a manual custom bound for any room, see the <see cref="Godot.Room"/> documentation.</para>
        /// <para>By definition, <see cref="Godot.Camera"/>s within a room can see everything else within the room (that is one advantage to using convex hulls). However, in order to see from one room into adjacent rooms, you must place <see cref="Godot.Portal"/>s, which represent openings that the camera can see through, like windows and doors.</para>
        /// <para><see cref="Godot.Portal"/>s are really just specialized <see cref="Godot.MeshInstance"/>s. In fact you will usually first create a portal by creating a <see cref="Godot.MeshInstance"/>, especially a <c>plane</c> mesh instance. You would move the plane in the editor to cover a window or doorway, with the front face pointing outward from the room. To let the conversion process know you want this mesh to be a portal, again we use a special naming convention. <see cref="Godot.MeshInstance"/>s to be converted to a <see cref="Godot.Portal"/> should start with the prefix 'Portal_'.</para>
        /// <para>You now have a choice - you can leave the name as 'Portal_' and allow the system to automatically detect the nearest <see cref="Godot.Room"/> to link. In most cases this will work fine.</para>
        /// <para>An alternative method is to specify the <see cref="Godot.Room"/> to link to manually, appending a suffix to the portal name, which should be the name of the room you intend to link to. For example 'Portal_lounge' will attempt to link to the room named 'Room_lounge'.</para>
        /// <para>There is a special case here - Godot does not allow two nodes to share the same name. What if you want to manually have more than one portal leading into the same room? Surely they will need to both be called, e.g. 'Portal_lounge'?</para>
        /// <para>The solution is a wildcard character. After the room name, if you use the character '*', this character and anything following it will be ignored. So you can use for example 'Portal_lounge*0', 'Portal_lounge*1' etc.</para>
        /// <para>Note that <see cref="Godot.Portal"/>s that have already been converted to <see cref="Godot.Portal"/> nodes (rather than <see cref="Godot.MeshInstance"/>s) still need to follow the same naming convention, as they will be relinked each time during conversion.</para>
        /// <para>It is recommended that you only place objects in rooms that are desired to stay within those rooms - i.e. <c>portal mode</c>s <c>STATIC</c> or <c>DYNAMIC</c> (not crossing portals). <c>GLOBAL</c> and <c>ROAMING</c> objects are best placed in another part of the scene tree, to avoid confusion. See <see cref="Godot.CullInstance"/> for a full description of portal modes.</para>
        /// </summary>
        [GodotMethod("rooms_convert")]
        public void RoomsConvert()
        {
            NativeCalls.godot_icall_0_3(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rooms_clear");

        /// <summary>
        /// <para>This function clears all converted data from the room graph. Use this before unloading a level, when transitioning from level to level, or returning to a main menu.</para>
        /// </summary>
        [GodotMethod("rooms_clear")]
        public void RoomsClear()
        {
            NativeCalls.godot_icall_0_3(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pvs_mode");

        [GodotMethod("set_pvs_mode")]
        [Obsolete("SetPvsMode is deprecated. Use the PvsMode property instead.")]
        public void SetPvsMode(RoomManager.PVSMode pvsMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)pvsMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pvs_mode");

        [GodotMethod("get_pvs_mode")]
        [Obsolete("GetPvsMode is deprecated. Use the PvsMode property instead.")]
        public RoomManager.PVSMode GetPvsMode()
        {
            return (RoomManager.PVSMode)NativeCalls.godot_icall_0_829(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_roomlist_path");

        [GodotMethod("set_roomlist_path")]
        [Obsolete("SetRoomlistPath is deprecated. Use the Roomlist property instead.")]
        public void SetRoomlistPath(NodePath pPath)
        {
            NativeCalls.godot_icall_1_129(method_bind_4, Object.GetPtr(this), NodePath.GetPtr(pPath));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_roomlist_path");

        [GodotMethod("get_roomlist_path")]
        [Obsolete("GetRoomlistPath is deprecated. Use the Roomlist property instead.")]
        public NodePath GetRoomlistPath()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_5, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rooms_set_active");

        [GodotMethod("rooms_set_active")]
        [Obsolete("RoomsSetActive is deprecated. Use the Active property instead.")]
        public void RoomsSetActive(bool active)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), active);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rooms_get_active");

        [GodotMethod("rooms_get_active")]
        [Obsolete("RoomsGetActive is deprecated. Use the Active property instead.")]
        public bool RoomsGetActive()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_gameplay_monitor_enabled");

        [GodotMethod("set_gameplay_monitor_enabled")]
        [Obsolete("SetGameplayMonitorEnabled is deprecated. Use the GameplayMonitor property instead.")]
        public void SetGameplayMonitorEnabled(bool gameplayMonitor)
        {
            NativeCalls.godot_icall_1_16(method_bind_8, Object.GetPtr(this), gameplayMonitor);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_gameplay_monitor_enabled");

        [GodotMethod("get_gameplay_monitor_enabled")]
        [Obsolete("GetGameplayMonitorEnabled is deprecated. Use the GameplayMonitor property instead.")]
        public bool GetGameplayMonitorEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_secondary_pvs");

        [GodotMethod("set_use_secondary_pvs")]
        [Obsolete("SetUseSecondaryPvs is deprecated. Use the UseSecondaryPvs property instead.")]
        public void SetUseSecondaryPvs(bool useSecondaryPvs)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), useSecondaryPvs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_use_secondary_pvs");

        [GodotMethod("get_use_secondary_pvs")]
        [Obsolete("GetUseSecondaryPvs is deprecated. Use the UseSecondaryPvs property instead.")]
        public bool GetUseSecondaryPvs()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_merge_meshes");

        [GodotMethod("set_merge_meshes")]
        [Obsolete("SetMergeMeshes is deprecated. Use the MergeMeshes property instead.")]
        public void SetMergeMeshes(bool mergeMeshes)
        {
            NativeCalls.godot_icall_1_16(method_bind_12, Object.GetPtr(this), mergeMeshes);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_merge_meshes");

        [GodotMethod("get_merge_meshes")]
        [Obsolete("GetMergeMeshes is deprecated. Use the MergeMeshes property instead.")]
        public bool GetMergeMeshes()
        {
            return NativeCalls.godot_icall_0_7(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_show_margins");

        [GodotMethod("set_show_margins")]
        [Obsolete("SetShowMargins is deprecated. Use the ShowMargins property instead.")]
        public void SetShowMargins(bool showMargins)
        {
            NativeCalls.godot_icall_1_16(method_bind_14, Object.GetPtr(this), showMargins);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_show_margins");

        [GodotMethod("get_show_margins")]
        [Obsolete("GetShowMargins is deprecated. Use the ShowMargins property instead.")]
        public bool GetShowMargins()
        {
            return NativeCalls.godot_icall_0_7(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_debug_sprawl");

        [GodotMethod("set_debug_sprawl")]
        [Obsolete("SetDebugSprawl is deprecated. Use the DebugSprawl property instead.")]
        public void SetDebugSprawl(bool debugSprawl)
        {
            NativeCalls.godot_icall_1_16(method_bind_16, Object.GetPtr(this), debugSprawl);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_debug_sprawl");

        [GodotMethod("get_debug_sprawl")]
        [Obsolete("GetDebugSprawl is deprecated. Use the DebugSprawl property instead.")]
        public bool GetDebugSprawl()
        {
            return NativeCalls.godot_icall_0_7(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_overlap_warning_threshold");

        [GodotMethod("set_overlap_warning_threshold")]
        [Obsolete("SetOverlapWarningThreshold is deprecated. Use the OverlapWarningThreshold property instead.")]
        public void SetOverlapWarningThreshold(int overlapWarningThreshold)
        {
            NativeCalls.godot_icall_1_4(method_bind_18, Object.GetPtr(this), overlapWarningThreshold);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_overlap_warning_threshold");

        [GodotMethod("get_overlap_warning_threshold")]
        [Obsolete("GetOverlapWarningThreshold is deprecated. Use the OverlapWarningThreshold property instead.")]
        public int GetOverlapWarningThreshold()
        {
            return NativeCalls.godot_icall_0_5(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_preview_camera_path");

        [GodotMethod("set_preview_camera_path")]
        [Obsolete("SetPreviewCameraPath is deprecated. Use the PreviewCamera property instead.")]
        public void SetPreviewCameraPath(NodePath previewCamera)
        {
            NativeCalls.godot_icall_1_129(method_bind_20, Object.GetPtr(this), NodePath.GetPtr(previewCamera));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_preview_camera_path");

        [GodotMethod("get_preview_camera_path")]
        [Obsolete("GetPreviewCameraPath is deprecated. Use the PreviewCamera property instead.")]
        public NodePath GetPreviewCameraPath()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_21, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_portal_depth_limit");

        [GodotMethod("set_portal_depth_limit")]
        [Obsolete("SetPortalDepthLimit is deprecated. Use the PortalDepthLimit property instead.")]
        public void SetPortalDepthLimit(int portalDepthLimit)
        {
            NativeCalls.godot_icall_1_4(method_bind_22, Object.GetPtr(this), portalDepthLimit);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_portal_depth_limit");

        [GodotMethod("get_portal_depth_limit")]
        [Obsolete("GetPortalDepthLimit is deprecated. Use the PortalDepthLimit property instead.")]
        public int GetPortalDepthLimit()
        {
            return NativeCalls.godot_icall_0_5(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_room_simplify");

        [GodotMethod("set_room_simplify")]
        [Obsolete("SetRoomSimplify is deprecated. Use the RoomSimplify property instead.")]
        public void SetRoomSimplify(float roomSimplify)
        {
            NativeCalls.godot_icall_1_15(method_bind_24, Object.GetPtr(this), roomSimplify);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_room_simplify");

        [GodotMethod("get_room_simplify")]
        [Obsolete("GetRoomSimplify is deprecated. Use the RoomSimplify property instead.")]
        public float GetRoomSimplify()
        {
            return NativeCalls.godot_icall_0_14(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_default_portal_margin");

        [GodotMethod("set_default_portal_margin")]
        [Obsolete("SetDefaultPortalMargin is deprecated. Use the DefaultPortalMargin property instead.")]
        public void SetDefaultPortalMargin(float defaultPortalMargin)
        {
            NativeCalls.godot_icall_1_15(method_bind_26, Object.GetPtr(this), defaultPortalMargin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_default_portal_margin");

        [GodotMethod("get_default_portal_margin")]
        [Obsolete("GetDefaultPortalMargin is deprecated. Use the DefaultPortalMargin property instead.")]
        public float GetDefaultPortalMargin()
        {
            return NativeCalls.godot_icall_0_14(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_roaming_expansion_margin");

        [GodotMethod("set_roaming_expansion_margin")]
        [Obsolete("SetRoamingExpansionMargin is deprecated. Use the RoamingExpansionMargin property instead.")]
        public void SetRoamingExpansionMargin(float roamingExpansionMargin)
        {
            NativeCalls.godot_icall_1_15(method_bind_28, Object.GetPtr(this), roamingExpansionMargin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_roaming_expansion_margin");

        [GodotMethod("get_roaming_expansion_margin")]
        [Obsolete("GetRoamingExpansionMargin is deprecated. Use the RoamingExpansionMargin property instead.")]
        public float GetRoamingExpansionMargin()
        {
            return NativeCalls.godot_icall_0_14(method_bind_29, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
