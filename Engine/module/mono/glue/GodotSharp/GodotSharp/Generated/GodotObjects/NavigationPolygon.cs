using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>There are two ways to create polygons. Either by using the <see cref="Godot.NavigationPolygon.AddOutline"/> method, or using the <see cref="Godot.NavigationPolygon.AddPolygon"/> method.</para>
    /// <para>Using <see cref="Godot.NavigationPolygon.AddOutline"/>:</para>
    /// <para><code>
    /// var polygon = NavigationPolygon.new()
    /// var outline = PoolVector2Array([Vector2(0, 0), Vector2(0, 50), Vector2(50, 50), Vector2(50, 0)])
    /// polygon.add_outline(outline)
    /// polygon.make_polygons_from_outlines()
    /// $NavigationPolygonInstance.navpoly = polygon
    /// </code></para>
    /// <para>Using <see cref="Godot.NavigationPolygon.AddPolygon"/> and indices of the vertices array.</para>
    /// <para><code>
    /// var polygon = NavigationPolygon.new()
    /// var vertices = PoolVector2Array([Vector2(0, 0), Vector2(0, 50), Vector2(50, 50), Vector2(50, 0)])
    /// polygon.set_vertices(vertices)
    /// var indices = PoolIntArray([0, 1, 2, 3])
    /// polygon.add_polygon(indices)
    /// $NavigationPolygonInstance.navpoly = polygon
    /// </code></para>
    /// </summary>
    public partial class NavigationPolygon : Resource
    {
        public Vector2[] Vertices
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVertices();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVertices(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array Polygons
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetPolygons();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetPolygons(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array Outlines
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetOutlines();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetOutlines(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "NavigationPolygon";

        public NavigationPolygon() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_NavigationPolygon_Ctor(this);
        }

        internal NavigationPolygon(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_vertices");

        /// <summary>
        /// <para>Sets the vertices that can be then indexed to create polygons with the <see cref="Godot.NavigationPolygon.AddPolygon"/> method.</para>
        /// </summary>
        [GodotMethod("set_vertices")]
        [Obsolete("SetVertices is deprecated. Use the Vertices property instead.")]
        public void SetVertices(Vector2[] vertices)
        {
            NativeCalls.godot_icall_1_235(method_bind_0, Object.GetPtr(this), vertices);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_vertices");

        /// <summary>
        /// <para>Returns a <see cref="Godot.Vector2"/> containing all the vertices being used to create the polygons.</para>
        /// </summary>
        [GodotMethod("get_vertices")]
        [Obsolete("GetVertices is deprecated. Use the Vertices property instead.")]
        public Vector2[] GetVertices()
        {
            return NativeCalls.godot_icall_0_236(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_polygon");

        /// <summary>
        /// <para>Adds a polygon using the indices of the vertices you get when calling <see cref="Godot.NavigationPolygon.GetVertices"/>.</para>
        /// </summary>
        [GodotMethod("add_polygon")]
        public void AddPolygon(int[] polygon)
        {
            NativeCalls.godot_icall_1_102(method_bind_2, Object.GetPtr(this), polygon);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_polygon_count");

        /// <summary>
        /// <para>Returns the count of all polygons.</para>
        /// </summary>
        [GodotMethod("get_polygon_count")]
        public int GetPolygonCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_polygon");

        /// <summary>
        /// <para>Returns a <see cref="int"/> containing the indices of the vertices of a created polygon.</para>
        /// </summary>
        [GodotMethod("get_polygon")]
        public int[] GetPolygon(int idx)
        {
            return NativeCalls.godot_icall_1_36(method_bind_4, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_polygons");

        /// <summary>
        /// <para>Clears the array of polygons, but it doesn't clear the array of outlines and vertices.</para>
        /// </summary>
        [GodotMethod("clear_polygons")]
        public void ClearPolygons()
        {
            NativeCalls.godot_icall_0_3(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mesh");

        /// <summary>
        /// <para>Returns the <see cref="Godot.NavigationMesh"/> resulting from this navigation polygon. This navmesh can be used to update the navmesh of a region with the <see cref="Godot.NavigationServer.RegionSetNavmesh"/> API directly (as 2D uses the 3D server behind the scene).</para>
        /// </summary>
        [GodotMethod("get_mesh")]
        public NavigationMesh GetMesh()
        {
            return NativeCalls.godot_icall_0_652(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_outline");

        /// <summary>
        /// <para>Appends a <see cref="Godot.Vector2"/> that contains the vertices of an outline to the internal array that contains all the outlines. You have to call <see cref="Godot.NavigationPolygon.MakePolygonsFromOutlines"/> in order for this array to be converted to polygons that the engine will use.</para>
        /// </summary>
        [GodotMethod("add_outline")]
        public void AddOutline(Vector2[] outline)
        {
            NativeCalls.godot_icall_1_235(method_bind_7, Object.GetPtr(this), outline);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_outline_at_index");

        /// <summary>
        /// <para>Adds a <see cref="Godot.Vector2"/> that contains the vertices of an outline to the internal array that contains all the outlines at a fixed position. You have to call <see cref="Godot.NavigationPolygon.MakePolygonsFromOutlines"/> in order for this array to be converted to polygons that the engine will use.</para>
        /// </summary>
        [GodotMethod("add_outline_at_index")]
        public void AddOutlineAtIndex(Vector2[] outline, int index)
        {
            NativeCalls.godot_icall_2_653(method_bind_8, Object.GetPtr(this), outline, index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_outline_count");

        /// <summary>
        /// <para>Returns the number of outlines that were created in the editor or by script.</para>
        /// </summary>
        [GodotMethod("get_outline_count")]
        public int GetOutlineCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_outline");

        /// <summary>
        /// <para>Changes an outline created in the editor or by script. You have to call <see cref="Godot.NavigationPolygon.MakePolygonsFromOutlines"/> for the polygons to update.</para>
        /// </summary>
        [GodotMethod("set_outline")]
        public void SetOutline(int idx, Vector2[] outline)
        {
            NativeCalls.godot_icall_2_654(method_bind_10, Object.GetPtr(this), idx, outline);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_outline");

        /// <summary>
        /// <para>Returns a <see cref="Godot.Vector2"/> containing the vertices of an outline that was created in the editor or by script.</para>
        /// </summary>
        [GodotMethod("get_outline")]
        public Vector2[] GetOutline(int idx)
        {
            return NativeCalls.godot_icall_1_164(method_bind_11, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_outline");

        /// <summary>
        /// <para>Removes an outline created in the editor or by script. You have to call <see cref="Godot.NavigationPolygon.MakePolygonsFromOutlines"/> for the polygons to update.</para>
        /// </summary>
        [GodotMethod("remove_outline")]
        public void RemoveOutline(int idx)
        {
            NativeCalls.godot_icall_1_4(method_bind_12, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_outlines");

        /// <summary>
        /// <para>Clears the array of the outlines, but it doesn't clear the vertices and the polygons that were created by them.</para>
        /// </summary>
        [GodotMethod("clear_outlines")]
        public void ClearOutlines()
        {
            NativeCalls.godot_icall_0_3(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "make_polygons_from_outlines");

        /// <summary>
        /// <para>Creates polygons from the outlines added in the editor or by script.</para>
        /// </summary>
        [GodotMethod("make_polygons_from_outlines")]
        public void MakePolygonsFromOutlines()
        {
            NativeCalls.godot_icall_0_3(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_polygons");

        [Obsolete("_SetPolygons is deprecated. Use the Polygons property instead.")]
        internal void _SetPolygons(Godot.Collections.Array polygons)
        {
            NativeCalls.godot_icall_1_92(method_bind_15, Object.GetPtr(this), polygons.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_polygons");

        [Obsolete("_GetPolygons is deprecated. Use the Polygons property instead.")]
        internal Godot.Collections.Array _GetPolygons()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_16, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_outlines");

        [Obsolete("_SetOutlines is deprecated. Use the Outlines property instead.")]
        internal void _SetOutlines(Godot.Collections.Array outlines)
        {
            NativeCalls.godot_icall_1_92(method_bind_17, Object.GetPtr(this), outlines.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_outlines");

        [Obsolete("_GetOutlines is deprecated. Use the Outlines property instead.")]
        internal Godot.Collections.Array _GetOutlines()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_18, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
