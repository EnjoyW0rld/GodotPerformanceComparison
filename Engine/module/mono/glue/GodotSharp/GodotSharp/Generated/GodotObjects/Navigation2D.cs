using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Deprecated. <see cref="Godot.Navigation2D"/> node and <see cref="Godot.Navigation2D.GetSimplePath"/> are deprecated and will be removed in a future version. Use <see cref="Godot.Navigation2DServer.MapGetPath"/> instead.</para>
    /// <para>Navigation2D provides navigation and pathfinding within a 2D area, specified as a collection of <see cref="Godot.NavigationPolygon"/> resources. By default, these are automatically collected from child <see cref="Godot.NavigationPolygonInstance"/> nodes.</para>
    /// </summary>
    public partial class Navigation2D : Node2D
    {
        /// <summary>
        /// <para>The XY plane cell size to use for fields.</para>
        /// </summary>
        public float CellSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCellSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCellSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>This value is used to detect the near edges to connect compatible regions.</para>
        /// </summary>
        public float EdgeConnectionMargin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEdgeConnectionMargin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEdgeConnectionMargin(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A bitfield determining all navigation map layers the navigation can use on a <see cref="Godot.Navigation2D.GetSimplePath"/> path query.</para>
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

        private const string nativeName = "Navigation2D";

        public Navigation2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Navigation2D_Ctor(this);
        }

        internal Navigation2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rid");

        /// <summary>
        /// <para>Returns the object's <see cref="Godot.RID"/>.</para>
        /// </summary>
        [GodotMethod("get_rid")]
        public RID GetRid()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_0, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_simple_path");

        /// <summary>
        /// <para>Deprecated. <see cref="Godot.Navigation2D"/> node and <see cref="Godot.Navigation2D.GetSimplePath"/> are deprecated and will be removed in a future version. Use <see cref="Godot.Navigation2DServer.MapGetPath"/> instead.</para>
        /// <para>Returns the path between two given points. Points are in local coordinate space. If <c>optimize</c> is <c>true</c> (the default), the path is smoothed by merging path segments where possible.</para>
        /// </summary>
        [GodotMethod("get_simple_path")]
        public Vector2[] GetSimplePath(Vector2 start, Vector2 end, bool optimize = true)
        {
            return NativeCalls.godot_icall_3_626(method_bind_1, Object.GetPtr(this), ref start, ref end, optimize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_closest_point");

        /// <summary>
        /// <para>Returns the navigation point closest to the point given. Points are in local coordinate space.</para>
        /// </summary>
        [GodotMethod("get_closest_point")]
        public Vector2 GetClosestPoint(Vector2 toPoint)
        {
            NativeCalls.godot_icall_1_47(method_bind_2, Object.GetPtr(this), ref toPoint, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_closest_point_owner");

        /// <summary>
        /// <para>Returns the owner of the <see cref="Godot.NavigationPolygon"/> which contains the navigation point closest to the point given. This is usually a <see cref="Godot.NavigationPolygonInstance"/>.</para>
        /// </summary>
        [GodotMethod("get_closest_point_owner")]
        public RID GetClosestPointOwner(Vector2 toPoint)
        {
            return new RID(NativeCalls.godot_icall_1_627(method_bind_3, Object.GetPtr(this), ref toPoint));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cell_size");

        [GodotMethod("set_cell_size")]
        [Obsolete("SetCellSize is deprecated. Use the CellSize property instead.")]
        public void SetCellSize(float cellSize)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), cellSize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cell_size");

        [GodotMethod("get_cell_size")]
        [Obsolete("GetCellSize is deprecated. Use the CellSize property instead.")]
        public float GetCellSize()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_edge_connection_margin");

        [GodotMethod("set_edge_connection_margin")]
        [Obsolete("SetEdgeConnectionMargin is deprecated. Use the EdgeConnectionMargin property instead.")]
        public void SetEdgeConnectionMargin(float margin)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_edge_connection_margin");

        [GodotMethod("get_edge_connection_margin")]
        [Obsolete("GetEdgeConnectionMargin is deprecated. Use the EdgeConnectionMargin property instead.")]
        public float GetEdgeConnectionMargin()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_navigation_layers");

        [GodotMethod("set_navigation_layers")]
        [Obsolete("SetNavigationLayers is deprecated. Use the NavigationLayers property instead.")]
        public void SetNavigationLayers(uint navigationLayers)
        {
            NativeCalls.godot_icall_1_187(method_bind_8, Object.GetPtr(this), navigationLayers);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_navigation_layers");

        [GodotMethod("get_navigation_layers")]
        [Obsolete("GetNavigationLayers is deprecated. Use the NavigationLayers property instead.")]
        public uint GetNavigationLayers()
        {
            return NativeCalls.godot_icall_0_188(method_bind_9, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
