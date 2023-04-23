using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Provides common functionality to nodes that can be culled by the <see cref="Godot.Portal"/> system.</para>
    /// <para><c>Static</c> and <c>Dynamic</c> objects are the most efficiently managed objects in the system, but there are some caveats. They are expected to be present initially when <see cref="Godot.Room"/>s are converted using the <see cref="Godot.RoomManager"/> <c>rooms_convert</c> function, and their lifetime should be the same as the game level (i.e. present until you call <c>rooms_clear</c> on the <see cref="Godot.RoomManager"/>. Although you shouldn't create / delete these objects during gameplay, you can manage their visibility with the standard <c>hide</c> and <c>show</c> commands.</para>
    /// <para><c>Roaming</c> objects on the other hand, require extra processing to keep track of which <see cref="Godot.Room"/> they are within. This enables them to be culled effectively, wherever they are.</para>
    /// <para><c>Global</c> objects are not culled by the portal system, and use view frustum culling only.</para>
    /// <para>Objects that are not <c>Static</c> or <c>Dynamic</c> can be freely created and deleted during the lifetime of the game level.</para>
    /// </summary>
    public abstract partial class CullInstance : Spatial
    {
        public enum PortalModeEnum
        {
            /// <summary>
            /// <para>Use for instances within <see cref="Godot.Room"/>s that will not move - e.g. walls, floors.</para>
            /// <para>Note: If you attempt to delete a <c>PORTAL_MODE_STATIC</c> instance while the room graph is loaded (converted), it will unload the room graph and deactivate portal culling. This is because the room graph data has been invalidated. You will need to reconvert the rooms using the <see cref="Godot.RoomManager"/> to activate the system again.</para>
            /// </summary>
            Static = 0,
            /// <summary>
            /// <para>Use for instances within rooms that will move but not change room - e.g. moving platforms.</para>
            /// <para>Note: If you attempt to delete a <c>PORTAL_MODE_DYNAMIC</c> instance while the room graph is loaded (converted), it will unload the room graph and deactivate portal culling. This is because the room graph data has been invalidated. You will need to reconvert the rooms using the <see cref="Godot.RoomManager"/> to activate the system again.</para>
            /// </summary>
            Dynamic = 1,
            /// <summary>
            /// <para>Use for instances that will move between <see cref="Godot.Room"/>s - e.g. players.</para>
            /// </summary>
            Roaming = 2,
            /// <summary>
            /// <para>Use for instances that will be frustum culled only - e.g. first person weapon, debug.</para>
            /// </summary>
            Global = 3,
            /// <summary>
            /// <para>Use for instances that will not be shown at all - e.g. manual room bounds (specified by prefix 'Bound_').</para>
            /// </summary>
            Ignore = 4
        }

        /// <summary>
        /// <para>When using <see cref="Godot.Room"/>s and <see cref="Godot.Portal"/>s, this specifies how the <see cref="Godot.CullInstance"/> is processed in the system.</para>
        /// </summary>
        public CullInstance.PortalModeEnum PortalMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPortalMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPortalMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When a manual bound has not been explicitly specified for a <see cref="Godot.Room"/>, the convex hull bound will be estimated from the geometry of the objects within the room. This setting determines whether the geometry of an object is included in this estimate of the room bound.</para>
        /// <para>Note: This setting is only relevant when the object is set to <c>PORTAL_MODE_STATIC</c> or <c>PORTAL_MODE_DYNAMIC</c>, and for <see cref="Godot.Portal"/>s.</para>
        /// </summary>
        public bool IncludeInBound
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetIncludeInBound();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetIncludeInBound(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>This allows fine control over the mesh merging feature in the <see cref="Godot.RoomManager"/>.</para>
        /// <para>Setting this option to <c>false</c> can be used to prevent an instance being merged.</para>
        /// </summary>
        public bool AllowMerging
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAllowMerging();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAllowMerging(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When set to <c>0</c>, <see cref="Godot.CullInstance"/>s will be autoplaced in the <see cref="Godot.Room"/> with the highest priority.</para>
        /// <para>When set to a value other than <c>0</c>, the system will attempt to autoplace in a <see cref="Godot.Room"/> with the <c>autoplace_priority</c>, if it is present.</para>
        /// <para>This can be used to control autoplacement of building exteriors in an outer <see cref="Godot.RoomGroup"/>.</para>
        /// </summary>
        public int AutoplacePriority
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPortalAutoplacePriority();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPortalAutoplacePriority(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "CullInstance";

        internal CullInstance() {}

        internal CullInstance(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_portal_mode");

        [GodotMethod("set_portal_mode")]
        [Obsolete("SetPortalMode is deprecated. Use the PortalMode property instead.")]
        public void SetPortalMode(CullInstance.PortalModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_portal_mode");

        [GodotMethod("get_portal_mode")]
        [Obsolete("GetPortalMode is deprecated. Use the PortalMode property instead.")]
        public CullInstance.PortalModeEnum GetPortalMode()
        {
            return (CullInstance.PortalModeEnum)NativeCalls.godot_icall_0_341(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_include_in_bound");

        [GodotMethod("set_include_in_bound")]
        [Obsolete("SetIncludeInBound is deprecated. Use the IncludeInBound property instead.")]
        public void SetIncludeInBound(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_include_in_bound");

        [GodotMethod("get_include_in_bound")]
        [Obsolete("GetIncludeInBound is deprecated. Use the IncludeInBound property instead.")]
        public bool GetIncludeInBound()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_allow_merging");

        [GodotMethod("set_allow_merging")]
        [Obsolete("SetAllowMerging is deprecated. Use the AllowMerging property instead.")]
        public void SetAllowMerging(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_allow_merging");

        [GodotMethod("get_allow_merging")]
        [Obsolete("GetAllowMerging is deprecated. Use the AllowMerging property instead.")]
        public bool GetAllowMerging()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_portal_autoplace_priority");

        [GodotMethod("set_portal_autoplace_priority")]
        [Obsolete("SetPortalAutoplacePriority is deprecated. Use the AutoplacePriority property instead.")]
        public void SetPortalAutoplacePriority(int priority)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), priority);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_portal_autoplace_priority");

        [GodotMethod("get_portal_autoplace_priority")]
        [Obsolete("GetPortalAutoplacePriority is deprecated. Use the AutoplacePriority property instead.")]
        public int GetPortalAutoplacePriority()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
