using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>GridMap lets you place meshes on a grid interactively. It works both from the editor and from scripts, which can help you create in-game level editors.</para>
    /// <para>GridMaps use a <see cref="Godot.MeshLibrary"/> which contains a list of tiles. Each tile is a mesh with materials plus optional collision and navigation shapes.</para>
    /// <para>A GridMap contains a collection of cells. Each grid cell refers to a tile in the <see cref="Godot.MeshLibrary"/>. All cells in the map have the same dimensions.</para>
    /// <para>Internally, a GridMap is split into a sparse collection of octants for efficient rendering and physics processing. Every octant has the same dimensions and can contain several cells.</para>
    /// <para>Note: GridMap doesn't extend <see cref="Godot.VisualInstance"/> and therefore can't be hidden or cull masked based on <see cref="Godot.VisualInstance.Layers"/>. If you make a light not affect the first layer, the whole GridMap won't be lit by the light in question.</para>
    /// </summary>
    public partial class GridMap : Spatial
    {
        /// <summary>
        /// <para>Invalid cell item that can be used in <see cref="Godot.GridMap.SetCellItem"/> to clear cells (or represent an empty cell in <see cref="Godot.GridMap.GetCellItem"/>).</para>
        /// </summary>
        public const int InvalidCellItem = -1;

        /// <summary>
        /// <para>The assigned <see cref="Godot.MeshLibrary"/>.</para>
        /// </summary>
        public MeshLibrary MeshLibrary
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMeshLibrary();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMeshLibrary(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Overrides the default friction and bounce physics properties for the whole <see cref="Godot.GridMap"/>.</para>
        /// </summary>
        public PhysicsMaterial PhysicsMaterial
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPhysicsMaterial();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPhysicsMaterial(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Controls whether this GridMap will be baked in a <see cref="Godot.BakedLightmap"/> or not.</para>
        /// </summary>
        public bool UseInBakedLight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUseInBakedLight();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseInBakedLight(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The dimensions of the grid's cells.</para>
        /// <para>This does not affect the size of the meshes. See <see cref="Godot.GridMap.CellScale"/>.</para>
        /// </summary>
        public Vector3 CellSize
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
        /// <para>The size of each octant measured in number of cells. This applies to all three axis.</para>
        /// </summary>
        public int CellOctantSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOctantSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOctantSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, grid items are centered on the X axis.</para>
        /// </summary>
        public bool CellCenterX
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCenterX();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCenterX(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, grid items are centered on the Y axis.</para>
        /// </summary>
        public bool CellCenterY
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCenterY();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCenterY(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, grid items are centered on the Z axis.</para>
        /// </summary>
        public bool CellCenterZ
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCenterZ();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCenterZ(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The scale of the cell items.</para>
        /// <para>This does not affect the size of the grid cells themselves, only the items in them. This can be used to make cell items overlap their neighbors.</para>
        /// </summary>
        public float CellScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCellScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCellScale(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The physics layers this GridMap is in.</para>
        /// <para>GridMaps act as static bodies, meaning they aren't affected by gravity or other forces. They only affect other physics bodies that collide with them.</para>
        /// </summary>
        public uint CollisionLayer
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCollisionLayer();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCollisionLayer(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The physics layers this GridMap detects collisions in. See <a href="$DOCS_URL/tutorials/physics/physics_introduction.html#collision-layers-and-masks">Collision layers and masks</a> in the documentation for more information.</para>
        /// </summary>
        public uint CollisionMask
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCollisionMask();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCollisionMask(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, this GridMap uses cell navmesh resources to create navigation regions.</para>
        /// </summary>
        public bool BakeNavigation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsBakingNavigation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBakeNavigation(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The navigation layers the GridMap generates its navigation regions in.</para>
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

        private const string nativeName = "GridMap";

        public GridMap() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GridMap_Ctor(this);
        }

        internal GridMap(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_layer");

        [GodotMethod("set_collision_layer")]
        [Obsolete("SetCollisionLayer is deprecated. Use the CollisionLayer property instead.")]
        public void SetCollisionLayer(uint layer)
        {
            NativeCalls.godot_icall_1_187(method_bind_0, Object.GetPtr(this), layer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_layer");

        [GodotMethod("get_collision_layer")]
        [Obsolete("GetCollisionLayer is deprecated. Use the CollisionLayer property instead.")]
        public uint GetCollisionLayer()
        {
            return NativeCalls.godot_icall_0_188(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_mask");

        [GodotMethod("set_collision_mask")]
        [Obsolete("SetCollisionMask is deprecated. Use the CollisionMask property instead.")]
        public void SetCollisionMask(uint mask)
        {
            NativeCalls.godot_icall_1_187(method_bind_2, Object.GetPtr(this), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_mask");

        [GodotMethod("get_collision_mask")]
        [Obsolete("GetCollisionMask is deprecated. Use the CollisionMask property instead.")]
        public uint GetCollisionMask()
        {
            return NativeCalls.godot_icall_0_188(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_mask_bit");

        /// <summary>
        /// <para>Sets an individual bit on the <see cref="Godot.GridMap.CollisionMask"/>.</para>
        /// </summary>
        [GodotMethod("set_collision_mask_bit")]
        public void SetCollisionMaskBit(int bit, bool value)
        {
            NativeCalls.godot_icall_2_23(method_bind_4, Object.GetPtr(this), bit, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_mask_bit");

        /// <summary>
        /// <para>Returns an individual bit on the <see cref="Godot.GridMap.CollisionMask"/>.</para>
        /// </summary>
        [GodotMethod("get_collision_mask_bit")]
        public bool GetCollisionMaskBit(int bit)
        {
            return NativeCalls.godot_icall_1_35(method_bind_5, Object.GetPtr(this), bit);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_layer_bit");

        /// <summary>
        /// <para>Sets an individual bit on the <see cref="Godot.GridMap.CollisionLayer"/>.</para>
        /// </summary>
        [GodotMethod("set_collision_layer_bit")]
        public void SetCollisionLayerBit(int bit, bool value)
        {
            NativeCalls.godot_icall_2_23(method_bind_6, Object.GetPtr(this), bit, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_layer_bit");

        /// <summary>
        /// <para>Returns an individual bit on the <see cref="Godot.GridMap.CollisionLayer"/>.</para>
        /// </summary>
        [GodotMethod("get_collision_layer_bit")]
        public bool GetCollisionLayerBit(int bit)
        {
            return NativeCalls.godot_icall_1_35(method_bind_7, Object.GetPtr(this), bit);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_physics_material");

        [GodotMethod("set_physics_material")]
        [Obsolete("SetPhysicsMaterial is deprecated. Use the PhysicsMaterial property instead.")]
        public void SetPhysicsMaterial(PhysicsMaterial material)
        {
            NativeCalls.godot_icall_1_24(method_bind_8, Object.GetPtr(this), Object.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_physics_material");

        [GodotMethod("get_physics_material")]
        [Obsolete("GetPhysicsMaterial is deprecated. Use the PhysicsMaterial property instead.")]
        public PhysicsMaterial GetPhysicsMaterial()
        {
            return NativeCalls.godot_icall_0_477(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bake_navigation");

        [GodotMethod("set_bake_navigation")]
        [Obsolete("SetBakeNavigation is deprecated. Use the BakeNavigation property instead.")]
        public void SetBakeNavigation(bool bakeNavigation)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), bakeNavigation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_baking_navigation");

        [GodotMethod("is_baking_navigation")]
        [Obsolete("IsBakingNavigation is deprecated. Use the BakeNavigation property instead.")]
        public bool IsBakingNavigation()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_navigation_layers");

        [GodotMethod("set_navigation_layers")]
        [Obsolete("SetNavigationLayers is deprecated. Use the NavigationLayers property instead.")]
        public void SetNavigationLayers(uint navigationLayers)
        {
            NativeCalls.godot_icall_1_187(method_bind_12, Object.GetPtr(this), navigationLayers);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_navigation_layers");

        [GodotMethod("get_navigation_layers")]
        [Obsolete("GetNavigationLayers is deprecated. Use the NavigationLayers property instead.")]
        public uint GetNavigationLayers()
        {
            return NativeCalls.godot_icall_0_188(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mesh_library");

        [GodotMethod("set_mesh_library")]
        [Obsolete("SetMeshLibrary is deprecated. Use the MeshLibrary property instead.")]
        public void SetMeshLibrary(MeshLibrary meshLibrary)
        {
            NativeCalls.godot_icall_1_24(method_bind_14, Object.GetPtr(this), Object.GetPtr(meshLibrary));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mesh_library");

        [GodotMethod("get_mesh_library")]
        [Obsolete("GetMeshLibrary is deprecated. Use the MeshLibrary property instead.")]
        public MeshLibrary GetMeshLibrary()
        {
            return NativeCalls.godot_icall_0_478(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cell_size");

        [GodotMethod("set_cell_size")]
        [Obsolete("SetCellSize is deprecated. Use the CellSize property instead.")]
        public void SetCellSize(Vector3 size)
        {
            NativeCalls.godot_icall_1_148(method_bind_16, Object.GetPtr(this), ref size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cell_size");

        [GodotMethod("get_cell_size")]
        [Obsolete("GetCellSize is deprecated. Use the CellSize property instead.")]
        public Vector3 GetCellSize()
        {
            NativeCalls.godot_icall_0_8(method_bind_17, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cell_scale");

        [GodotMethod("set_cell_scale")]
        [Obsolete("SetCellScale is deprecated. Use the CellScale property instead.")]
        public void SetCellScale(float scale)
        {
            NativeCalls.godot_icall_1_15(method_bind_18, Object.GetPtr(this), scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cell_scale");

        [GodotMethod("get_cell_scale")]
        [Obsolete("GetCellScale is deprecated. Use the CellScale property instead.")]
        public float GetCellScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_octant_size");

        [GodotMethod("set_octant_size")]
        [Obsolete("SetOctantSize is deprecated. Use the CellOctantSize property instead.")]
        public void SetOctantSize(int size)
        {
            NativeCalls.godot_icall_1_4(method_bind_20, Object.GetPtr(this), size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_octant_size");

        [GodotMethod("get_octant_size")]
        [Obsolete("GetOctantSize is deprecated. Use the CellOctantSize property instead.")]
        public int GetOctantSize()
        {
            return NativeCalls.godot_icall_0_5(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cell_item");

        /// <summary>
        /// <para>Sets the mesh index for the cell referenced by its grid-based X, Y and Z coordinates.</para>
        /// <para>A negative item index such as <see cref="Godot.GridMap.InvalidCellItem"/> will clear the cell.</para>
        /// <para>Optionally, the item's orientation can be passed. For valid orientation values, see <c>Basis.get_orthogonal_index</c>.</para>
        /// </summary>
        [GodotMethod("set_cell_item")]
        public void SetCellItem(int x, int y, int z, int item, int orientation = 0)
        {
            NativeCalls.godot_icall_5_479(method_bind_22, Object.GetPtr(this), x, y, z, item, orientation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cell_item");

        /// <summary>
        /// <para>The <see cref="Godot.MeshLibrary"/> item index located at the grid-based X, Y and Z coordinates. If the cell is empty, <see cref="Godot.GridMap.InvalidCellItem"/> will be returned.</para>
        /// </summary>
        [GodotMethod("get_cell_item")]
        public int GetCellItem(int x, int y, int z)
        {
            return NativeCalls.godot_icall_3_480(method_bind_23, Object.GetPtr(this), x, y, z);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cell_item_orientation");

        /// <summary>
        /// <para>The orientation of the cell at the grid-based X, Y and Z coordinates. -1 is returned if the cell is empty.</para>
        /// </summary>
        [GodotMethod("get_cell_item_orientation")]
        public int GetCellItemOrientation(int x, int y, int z)
        {
            return NativeCalls.godot_icall_3_480(method_bind_24, Object.GetPtr(this), x, y, z);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "world_to_map");

        /// <summary>
        /// <para>Returns the coordinates of the grid cell containing the given point.</para>
        /// <para><c>pos</c> should be in the GridMap's local coordinate space.</para>
        /// </summary>
        [GodotMethod("world_to_map")]
        public Vector3 WorldToMap(Vector3 pos)
        {
            NativeCalls.godot_icall_1_40(method_bind_25, Object.GetPtr(this), ref pos, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "map_to_world");

        /// <summary>
        /// <para>Returns the position of a grid cell in the GridMap's local coordinate space.</para>
        /// </summary>
        [GodotMethod("map_to_world")]
        public Vector3 MapToWorld(int x, int y, int z)
        {
            NativeCalls.godot_icall_3_481(method_bind_26, Object.GetPtr(this), x, y, z, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "resource_changed");

        [GodotMethod("resource_changed")]
        public void ResourceChanged(Resource resource)
        {
            NativeCalls.godot_icall_1_24(method_bind_27, Object.GetPtr(this), Object.GetPtr(resource));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_center_x");

        [GodotMethod("set_center_x")]
        [Obsolete("SetCenterX is deprecated. Use the CellCenterX property instead.")]
        public void SetCenterX(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_28, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_center_x");

        [GodotMethod("get_center_x")]
        [Obsolete("GetCenterX is deprecated. Use the CellCenterX property instead.")]
        public bool GetCenterX()
        {
            return NativeCalls.godot_icall_0_7(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_center_y");

        [GodotMethod("set_center_y")]
        [Obsolete("SetCenterY is deprecated. Use the CellCenterY property instead.")]
        public void SetCenterY(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_30, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_center_y");

        [GodotMethod("get_center_y")]
        [Obsolete("GetCenterY is deprecated. Use the CellCenterY property instead.")]
        public bool GetCenterY()
        {
            return NativeCalls.godot_icall_0_7(method_bind_31, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_center_z");

        [GodotMethod("set_center_z")]
        [Obsolete("SetCenterZ is deprecated. Use the CellCenterZ property instead.")]
        public void SetCenterZ(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_32, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_center_z");

        [GodotMethod("get_center_z")]
        [Obsolete("GetCenterZ is deprecated. Use the CellCenterZ property instead.")]
        public bool GetCenterZ()
        {
            return NativeCalls.godot_icall_0_7(method_bind_33, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_clip");

        [GodotMethod("set_clip")]
        public void SetClip(bool enabled, bool clipabove = true, int floor = 0, Vector3.Axis axis = (Vector3.Axis)0)
        {
            NativeCalls.godot_icall_4_482(method_bind_34, Object.GetPtr(this), enabled, clipabove, floor, (int)axis);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Clear all cells.</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_35, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_used_cells");

        /// <summary>
        /// <para>Returns an array of <see cref="Godot.Vector3"/> with the non-empty cell coordinates in the grid map.</para>
        /// </summary>
        [GodotMethod("get_used_cells")]
        public Godot.Collections.Array GetUsedCells()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_36, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_used_cells_by_item");

        /// <summary>
        /// <para>Returns an array of all cells with the given item index specified in <c>item</c>.</para>
        /// </summary>
        [GodotMethod("get_used_cells_by_item")]
        public Godot.Collections.Array GetUsedCellsByItem(int item)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_1_483(method_bind_37, Object.GetPtr(this), item));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_meshes");

        /// <summary>
        /// <para>Returns an array of <see cref="Godot.Transform"/> and <see cref="Godot.Mesh"/> references corresponding to the non-empty cells in the grid. The transforms are specified in world space.</para>
        /// </summary>
        [GodotMethod("get_meshes")]
        public Godot.Collections.Array GetMeshes()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_38, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bake_meshes");

        /// <summary>
        /// <para>Returns an array of <see cref="Godot.ArrayMesh"/>es and <see cref="Godot.Transform"/> references of all bake meshes that exist within the current GridMap.</para>
        /// </summary>
        [GodotMethod("get_bake_meshes")]
        public Godot.Collections.Array GetBakeMeshes()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_39, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bake_mesh_instance");

        [GodotMethod("get_bake_mesh_instance")]
        public RID GetBakeMeshInstance(int idx)
        {
            return new RID(NativeCalls.godot_icall_1_484(method_bind_40, Object.GetPtr(this), idx));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_baked_meshes");

        [GodotMethod("clear_baked_meshes")]
        public void ClearBakedMeshes()
        {
            NativeCalls.godot_icall_0_3(method_bind_41, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "make_baked_meshes");

        [GodotMethod("make_baked_meshes")]
        public void MakeBakedMeshes(bool genLightmapUv = false, float lightmapUvTexelSize = 0.1f)
        {
            NativeCalls.godot_icall_2_485(method_bind_42, Object.GetPtr(this), genLightmapUv, lightmapUvTexelSize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_in_baked_light");

        [GodotMethod("set_use_in_baked_light")]
        [Obsolete("SetUseInBakedLight is deprecated. Use the UseInBakedLight property instead.")]
        public void SetUseInBakedLight(bool useInBakedLight)
        {
            NativeCalls.godot_icall_1_16(method_bind_43, Object.GetPtr(this), useInBakedLight);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_use_in_baked_light");

        [GodotMethod("get_use_in_baked_light")]
        [Obsolete("GetUseInBakedLight is deprecated. Use the UseInBakedLight property instead.")]
        public bool GetUseInBakedLight()
        {
            return NativeCalls.godot_icall_0_7(method_bind_44, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
