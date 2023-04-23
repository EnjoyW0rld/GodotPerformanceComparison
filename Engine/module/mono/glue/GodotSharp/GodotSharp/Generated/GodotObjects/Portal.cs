using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.Portal"/>s are a special type of <see cref="Godot.MeshInstance"/> that allow the portal culling system to 'see' from one room to the next. They often correspond to doors and windows in level geometry. By only allowing <see cref="Godot.Camera"/>s to see through portals, this allows the system to cull out all the objects in rooms that cannot be seen through portals. This is a form of occlusion culling, and can greatly increase performance.</para>
    /// <para>There are some limitations to the form of portals:</para>
    /// <para>They must be single sided convex polygons, and usually you would orientate their front faces outward from the <see cref="Godot.Room"/> they are placed in. The vertices should be positioned on a single plane (although their positioning does not have to be perfect).</para>
    /// <para>There is no need to place an opposite portal in an adjacent room, links are made two-way automatically.</para>
    /// </summary>
    public partial class Portal : Spatial
    {
        /// <summary>
        /// <para>Visibility through <see cref="Godot.Portal"/>s can be turned on and off at runtime - this is useful for having closable doors.</para>
        /// </summary>
        public bool PortalActive
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPortalActive();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPortalActive(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Portals default to being two way - see through in both directions, however you can make them one way, visible from the source room only.</para>
        /// </summary>
        public bool TwoWay
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsTwoWay();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTwoWay(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>This is a shortcut for setting the linked <see cref="Godot.Room"/> in the name of the <see cref="Godot.Portal"/> (the name is used during conversion).</para>
        /// </summary>
        public NodePath LinkedRoom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLinkedRoom();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLinkedRoom(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>In most cases you will want to use the default <see cref="Godot.Portal"/> margin in your portals (this is set in the <see cref="Godot.RoomManager"/>).</para>
        /// <para>If you want to override this default, set this value to <c>false</c>, and the local <see cref="Godot.Portal.PortalMargin"/> will take effect.</para>
        /// </summary>
        public bool UseDefaultMargin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUseDefaultMargin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseDefaultMargin(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Some objects are so big that they may be present in more than one <see cref="Godot.Room"/> ('sprawling'). As we often don't want objects that *just* breach the edges to be assigned to neighbouring rooms, you can assign an extra margin through the <see cref="Godot.Portal"/> to allow objects to breach without sprawling.</para>
        /// </summary>
        public float PortalMargin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPortalMargin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPortalMargin(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The points defining the shape of the <see cref="Godot.Portal"/> polygon (which should be convex).</para>
        /// <para>These are defined in 2D, with <c>0,0</c> being the origin of the <see cref="Godot.Portal"/> node's <see cref="Godot.Spatial.GlobalTransform"/>.</para>
        /// <para>Note: These raw points are sanitized for winding order internally.</para>
        /// </summary>
        public Vector2[] Points
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPoints();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPoints(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Portal";

        public Portal() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Portal_Ctor(this);
        }

        internal Portal(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_portal_active");

        [GodotMethod("set_portal_active")]
        [Obsolete("SetPortalActive is deprecated. Use the PortalActive property instead.")]
        public void SetPortalActive(bool pActive)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), pActive);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_portal_active");

        [GodotMethod("get_portal_active")]
        [Obsolete("GetPortalActive is deprecated. Use the PortalActive property instead.")]
        public bool GetPortalActive()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_two_way");

        [GodotMethod("set_two_way")]
        [Obsolete("SetTwoWay is deprecated. Use the TwoWay property instead.")]
        public void SetTwoWay(bool pTwoWay)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), pTwoWay);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_two_way");

        [GodotMethod("is_two_way")]
        [Obsolete("IsTwoWay is deprecated. Use the TwoWay property instead.")]
        public bool IsTwoWay()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_default_margin");

        [GodotMethod("set_use_default_margin")]
        [Obsolete("SetUseDefaultMargin is deprecated. Use the UseDefaultMargin property instead.")]
        public void SetUseDefaultMargin(bool pUse)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), pUse);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_use_default_margin");

        [GodotMethod("get_use_default_margin")]
        [Obsolete("GetUseDefaultMargin is deprecated. Use the UseDefaultMargin property instead.")]
        public bool GetUseDefaultMargin()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_portal_margin");

        [GodotMethod("set_portal_margin")]
        [Obsolete("SetPortalMargin is deprecated. Use the PortalMargin property instead.")]
        public void SetPortalMargin(float pMargin)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), pMargin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_portal_margin");

        [GodotMethod("get_portal_margin")]
        [Obsolete("GetPortalMargin is deprecated. Use the PortalMargin property instead.")]
        public float GetPortalMargin()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_linked_room");

        [GodotMethod("set_linked_room")]
        [Obsolete("SetLinkedRoom is deprecated. Use the LinkedRoom property instead.")]
        public void SetLinkedRoom(NodePath pRoom)
        {
            NativeCalls.godot_icall_1_129(method_bind_8, Object.GetPtr(this), NodePath.GetPtr(pRoom));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_linked_room");

        [GodotMethod("get_linked_room")]
        [Obsolete("GetLinkedRoom is deprecated. Use the LinkedRoom property instead.")]
        public NodePath GetLinkedRoom()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_9, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_points");

        [GodotMethod("set_points")]
        [Obsolete("SetPoints is deprecated. Use the Points property instead.")]
        public void SetPoints(Vector2[] points)
        {
            NativeCalls.godot_icall_1_235(method_bind_10, Object.GetPtr(this), points);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_points");

        [GodotMethod("get_points")]
        [Obsolete("GetPoints is deprecated. Use the Points property instead.")]
        public Vector2[] GetPoints()
        {
            return NativeCalls.godot_icall_0_236(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_point");

        /// <summary>
        /// <para>Sets individual points. Primarily for use by the editor.</para>
        /// </summary>
        [GodotMethod("set_point")]
        public void SetPoint(int index, Vector2 position)
        {
            NativeCalls.godot_icall_2_45(method_bind_12, Object.GetPtr(this), index, ref position);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
