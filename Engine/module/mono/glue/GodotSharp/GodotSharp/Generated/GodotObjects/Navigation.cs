using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Deprecated. <see cref="Godot.Navigation"/> node and <see cref="Godot.Navigation.GetSimplePath"/> are deprecated and will be removed in a future version. Use <see cref="Godot.NavigationServer.MapGetPath"/> instead.</para>
    /// <para>Provides navigation and pathfinding within a collection of <see cref="Godot.NavigationMesh"/>es. By default, these will be automatically collected from child <see cref="Godot.NavigationMeshInstance"/> nodes. In addition to basic pathfinding, this class also assists with aligning navigation agents with the meshes they are navigating on.</para>
    /// </summary>
    public partial class Navigation : Spatial
    {
        /// <summary>
        /// <para>Defines which direction is up. By default, this is <c>(0, 1, 0)</c>, which is the world's "up" direction.</para>
        /// </summary>
        public Vector3 UpVector
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUpVector();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUpVector(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The XZ plane cell size to use for fields.</para>
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
        /// <para>The cell height to use for fields.</para>
        /// </summary>
        public float CellHeight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCellHeight();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCellHeight(value);
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
        /// <para>A bitfield determining all navigation map layers the navigation can use on a <see cref="Godot.Navigation.GetSimplePath"/> path query.</para>
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

        private const string nativeName = "Navigation";

        public Navigation() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Navigation_Ctor(this);
        }

        internal Navigation(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rid");

        /// <summary>
        /// <para>Returns the <see cref="Godot.RID"/> of the navigation map on the <see cref="Godot.NavigationServer"/>.</para>
        /// </summary>
        [GodotMethod("get_rid")]
        public RID GetRid()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_0, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_simple_path");

        /// <summary>
        /// <para>Deprecated. <see cref="Godot.Navigation"/> node and <see cref="Godot.Navigation.GetSimplePath"/> are deprecated and will be removed in a future version. Use <see cref="Godot.NavigationServer.MapGetPath"/> instead.</para>
        /// <para>Returns the path between two given points. Points are in local coordinate space. If <c>optimize</c> is <c>true</c> (the default), the agent properties associated with each <see cref="Godot.NavigationMesh"/> (radius, height, etc.) are considered in the path calculation, otherwise they are ignored.</para>
        /// </summary>
        [GodotMethod("get_simple_path")]
        public Vector3[] GetSimplePath(Vector3 start, Vector3 end, bool optimize = true)
        {
            return NativeCalls.godot_icall_3_623(method_bind_1, Object.GetPtr(this), ref start, ref end, optimize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_closest_point_to_segment");

        /// <summary>
        /// <para>Returns the navigation point closest to the given line segment. When enabling <c>use_collision</c>, only considers intersection points between segment and navigation meshes. If multiple intersection points are found, the one closest to the segment start point is returned.</para>
        /// </summary>
        [GodotMethod("get_closest_point_to_segment")]
        public Vector3 GetClosestPointToSegment(Vector3 start, Vector3 end, bool useCollision = false)
        {
            NativeCalls.godot_icall_3_624(method_bind_2, Object.GetPtr(this), ref start, ref end, useCollision, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_closest_point");

        /// <summary>
        /// <para>Returns the navigation point closest to the point given. Points are in local coordinate space.</para>
        /// </summary>
        [GodotMethod("get_closest_point")]
        public Vector3 GetClosestPoint(Vector3 toPoint)
        {
            NativeCalls.godot_icall_1_40(method_bind_3, Object.GetPtr(this), ref toPoint, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_closest_point_normal");

        /// <summary>
        /// <para>Returns the surface normal at the navigation point closest to the point given. Useful for rotating a navigation agent according to the navigation mesh it moves on.</para>
        /// </summary>
        [GodotMethod("get_closest_point_normal")]
        public Vector3 GetClosestPointNormal(Vector3 toPoint)
        {
            NativeCalls.godot_icall_1_40(method_bind_4, Object.GetPtr(this), ref toPoint, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_closest_point_owner");

        /// <summary>
        /// <para>Returns the owner of the <see cref="Godot.NavigationMesh"/> which contains the navigation point closest to the point given. This is usually a <see cref="Godot.NavigationMeshInstance"/>.</para>
        /// </summary>
        [GodotMethod("get_closest_point_owner")]
        public RID GetClosestPointOwner(Vector3 toPoint)
        {
            return new RID(NativeCalls.godot_icall_1_625(method_bind_5, Object.GetPtr(this), ref toPoint));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_up_vector");

        [GodotMethod("set_up_vector")]
        [Obsolete("SetUpVector is deprecated. Use the UpVector property instead.")]
        public void SetUpVector(Vector3 up)
        {
            NativeCalls.godot_icall_1_148(method_bind_6, Object.GetPtr(this), ref up);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_up_vector");

        [GodotMethod("get_up_vector")]
        [Obsolete("GetUpVector is deprecated. Use the UpVector property instead.")]
        public Vector3 GetUpVector()
        {
            NativeCalls.godot_icall_0_8(method_bind_7, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cell_size");

        [GodotMethod("set_cell_size")]
        [Obsolete("SetCellSize is deprecated. Use the CellSize property instead.")]
        public void SetCellSize(float cellSize)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), cellSize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cell_size");

        [GodotMethod("get_cell_size")]
        [Obsolete("GetCellSize is deprecated. Use the CellSize property instead.")]
        public float GetCellSize()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cell_height");

        [GodotMethod("set_cell_height")]
        [Obsolete("SetCellHeight is deprecated. Use the CellHeight property instead.")]
        public void SetCellHeight(float cellHeight)
        {
            NativeCalls.godot_icall_1_15(method_bind_10, Object.GetPtr(this), cellHeight);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cell_height");

        [GodotMethod("get_cell_height")]
        [Obsolete("GetCellHeight is deprecated. Use the CellHeight property instead.")]
        public float GetCellHeight()
        {
            return NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_edge_connection_margin");

        [GodotMethod("set_edge_connection_margin")]
        [Obsolete("SetEdgeConnectionMargin is deprecated. Use the EdgeConnectionMargin property instead.")]
        public void SetEdgeConnectionMargin(float margin)
        {
            NativeCalls.godot_icall_1_15(method_bind_12, Object.GetPtr(this), margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_edge_connection_margin");

        [GodotMethod("get_edge_connection_margin")]
        [Obsolete("GetEdgeConnectionMargin is deprecated. Use the EdgeConnectionMargin property instead.")]
        public float GetEdgeConnectionMargin()
        {
            return NativeCalls.godot_icall_0_14(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_navigation_layers");

        [GodotMethod("set_navigation_layers")]
        [Obsolete("SetNavigationLayers is deprecated. Use the NavigationLayers property instead.")]
        public void SetNavigationLayers(uint navigationLayers)
        {
            NativeCalls.godot_icall_1_187(method_bind_14, Object.GetPtr(this), navigationLayers);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_navigation_layers");

        [GodotMethod("get_navigation_layers")]
        [Obsolete("GetNavigationLayers is deprecated. Use the NavigationLayers property instead.")]
        public uint GetNavigationLayers()
        {
            return NativeCalls.godot_icall_0_188(method_bind_15, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
