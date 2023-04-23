using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A TileSet is a library of tiles for a <see cref="Godot.TileMap"/>. It contains a list of tiles, each consisting of a sprite and optional collision shapes.</para>
    /// <para>Tiles are referenced by a unique integer ID.</para>
    /// </summary>
    public partial class TileSet : Resource
    {
        public enum TileMode
        {
            SingleTile = 0,
            AutoTile = 1,
            AtlasTile = 2
        }

        public enum AutotileBindings
        {
            Topleft = 1,
            Top = 2,
            Topright = 4,
            Left = 8,
            Center = 16,
            Right = 32,
            Bottomleft = 64,
            Bottom = 128,
            Bottomright = 256
        }

        public enum BitmaskMode
        {
            Bitmask2x2 = 0,
            Bitmask3x3Minimal = 1,
            Bitmask3x3 = 2
        }

        private const string nativeName = "TileSet";

        public TileSet() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_TileSet_Ctor(this);
        }

        internal TileSet(bool memoryOwn) : base(memoryOwn) {}

        [GodotMethod("_forward_atlas_subtile_selection")]
        public virtual Vector2 _ForwardAtlasSubtileSelection(int atlastileId, Object tilemap, Vector2 tileLocation)
        {
            return default(Vector2);
        }

        [GodotMethod("_forward_subtile_selection")]
        public virtual Vector2 _ForwardSubtileSelection(int autotileId, int bitmask, Object tilemap, Vector2 tileLocation)
        {
            return default(Vector2);
        }

        /// <summary>
        /// <para>Determines when the auto-tiler should consider two different auto-tile IDs to be bound together.</para>
        /// <para>Note: <c>neighbor_id</c> will be <c>-1</c> (<see cref="Godot.TileMap.InvalidCell"/>) when checking a tile against an empty neighbor tile.</para>
        /// </summary>
        [GodotMethod("_is_tile_bound")]
        public virtual bool _IsTileBound(int drawnId, int neighborId)
        {
            return default(bool);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_tile");

        /// <summary>
        /// <para>Creates a new tile with the given ID.</para>
        /// </summary>
        [GodotMethod("create_tile")]
        public void CreateTile(int id)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "autotile_clear_bitmask_map");

        /// <summary>
        /// <para>Clears all bitmask information of the autotile.</para>
        /// </summary>
        [GodotMethod("autotile_clear_bitmask_map")]
        public void AutotileClearBitmaskMap(int id)
        {
            NativeCalls.godot_icall_1_4(method_bind_1, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "autotile_set_icon_coordinate");

        /// <summary>
        /// <para>Sets the subtile that will be used as an icon in an atlas/autotile given its coordinates.</para>
        /// <para>The subtile defined as the icon will be used as a fallback when the atlas/autotile's bitmask information is incomplete. It will also be used to represent it in the TileSet editor.</para>
        /// </summary>
        [GodotMethod("autotile_set_icon_coordinate")]
        public void AutotileSetIconCoordinate(int id, Vector2 coord)
        {
            NativeCalls.godot_icall_2_45(method_bind_2, Object.GetPtr(this), id, ref coord);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "autotile_get_icon_coordinate");

        /// <summary>
        /// <para>Returns the subtile that's being used as an icon in an atlas/autotile given its coordinates.</para>
        /// <para>The subtile defined as the icon will be used as a fallback when the atlas/autotile's bitmask information is incomplete. It will also be used to represent it in the TileSet editor.</para>
        /// </summary>
        [GodotMethod("autotile_get_icon_coordinate")]
        public Vector2 AutotileGetIconCoordinate(int id)
        {
            NativeCalls.godot_icall_1_44(method_bind_3, Object.GetPtr(this), id, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "autotile_set_subtile_priority");

        /// <summary>
        /// <para>Sets the priority of the subtile from an autotile given its coordinates.</para>
        /// <para>When more than one subtile has the same bitmask value, one of them will be picked randomly for drawing. Its priority will define how often it will be picked.</para>
        /// </summary>
        [GodotMethod("autotile_set_subtile_priority")]
        public void AutotileSetSubtilePriority(int id, Vector2 coord, int priority)
        {
            NativeCalls.godot_icall_3_947(method_bind_4, Object.GetPtr(this), id, ref coord, priority);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "autotile_get_subtile_priority");

        /// <summary>
        /// <para>Returns the priority of the subtile from an autotile given its coordinates.</para>
        /// <para>When more than one subtile has the same bitmask value, one of them will be picked randomly for drawing. Its priority will define how often it will be picked.</para>
        /// </summary>
        [GodotMethod("autotile_get_subtile_priority")]
        public int AutotileGetSubtilePriority(int id, Vector2 coord)
        {
            return NativeCalls.godot_icall_2_948(method_bind_5, Object.GetPtr(this), id, ref coord);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "autotile_set_z_index");

        /// <summary>
        /// <para>Sets the drawing index of the subtile from an atlas/autotile given its coordinates.</para>
        /// </summary>
        [GodotMethod("autotile_set_z_index")]
        public void AutotileSetZIndex(int id, Vector2 coord, int zIndex)
        {
            NativeCalls.godot_icall_3_947(method_bind_6, Object.GetPtr(this), id, ref coord, zIndex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "autotile_get_z_index");

        /// <summary>
        /// <para>Returns the drawing index of the subtile from an atlas/autotile given its coordinates.</para>
        /// </summary>
        [GodotMethod("autotile_get_z_index")]
        public int AutotileGetZIndex(int id, Vector2 coord)
        {
            return NativeCalls.godot_icall_2_948(method_bind_7, Object.GetPtr(this), id, ref coord);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "autotile_set_light_occluder");

        /// <summary>
        /// <para>Sets the light occluder of the subtile from an atlas/autotile given its coordinates.</para>
        /// </summary>
        [GodotMethod("autotile_set_light_occluder")]
        public void AutotileSetLightOccluder(int id, OccluderPolygon2D lightOccluder, Vector2 coord)
        {
            NativeCalls.godot_icall_3_949(method_bind_8, Object.GetPtr(this), id, Object.GetPtr(lightOccluder), ref coord);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "autotile_get_light_occluder");

        /// <summary>
        /// <para>Returns the light occluder of the subtile from an atlas/autotile given its coordinates.</para>
        /// </summary>
        [GodotMethod("autotile_get_light_occluder")]
        public OccluderPolygon2D AutotileGetLightOccluder(int id, Vector2 coord)
        {
            return NativeCalls.godot_icall_2_950(method_bind_9, Object.GetPtr(this), id, ref coord);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "autotile_set_navigation_polygon");

        /// <summary>
        /// <para>Sets the navigation polygon of the subtile from an atlas/autotile given its coordinates.</para>
        /// </summary>
        [GodotMethod("autotile_set_navigation_polygon")]
        public void AutotileSetNavigationPolygon(int id, NavigationPolygon navigationPolygon, Vector2 coord)
        {
            NativeCalls.godot_icall_3_949(method_bind_10, Object.GetPtr(this), id, Object.GetPtr(navigationPolygon), ref coord);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "autotile_get_navigation_polygon");

        /// <summary>
        /// <para>Returns the navigation polygon of the subtile from an atlas/autotile given its coordinates.</para>
        /// </summary>
        [GodotMethod("autotile_get_navigation_polygon")]
        public NavigationPolygon AutotileGetNavigationPolygon(int id, Vector2 coord)
        {
            return NativeCalls.godot_icall_2_951(method_bind_11, Object.GetPtr(this), id, ref coord);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "autotile_set_bitmask");

        /// <summary>
        /// <para>Sets the bitmask of the subtile from an autotile given its coordinates.</para>
        /// <para>The value is the sum of the values in <see cref="Godot.TileSet.AutotileBindings"/> present in the subtile (e.g. a value of 5 means the bitmask has bindings in both the top left and top right).</para>
        /// </summary>
        [GodotMethod("autotile_set_bitmask")]
        public void AutotileSetBitmask(int id, Vector2 bitmask, uint flag)
        {
            NativeCalls.godot_icall_3_952(method_bind_12, Object.GetPtr(this), id, ref bitmask, flag);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "autotile_get_bitmask");

        /// <summary>
        /// <para>Returns the bitmask of the subtile from an autotile given its coordinates.</para>
        /// <para>The value is the sum of the values in <see cref="Godot.TileSet.AutotileBindings"/> present in the subtile (e.g. a value of 5 means the bitmask has bindings in both the top left and top right).</para>
        /// </summary>
        [GodotMethod("autotile_get_bitmask")]
        public uint AutotileGetBitmask(int id, Vector2 coord)
        {
            return NativeCalls.godot_icall_2_953(method_bind_13, Object.GetPtr(this), id, ref coord);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "autotile_set_bitmask_mode");

        /// <summary>
        /// <para>Sets the <see cref="Godot.TileSet.BitmaskMode"/> of the autotile.</para>
        /// </summary>
        [GodotMethod("autotile_set_bitmask_mode")]
        public void AutotileSetBitmaskMode(int id, TileSet.BitmaskMode mode)
        {
            NativeCalls.godot_icall_2_65(method_bind_14, Object.GetPtr(this), id, (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "autotile_get_bitmask_mode");

        /// <summary>
        /// <para>Returns the <see cref="Godot.TileSet.BitmaskMode"/> of the autotile.</para>
        /// </summary>
        [GodotMethod("autotile_get_bitmask_mode")]
        public TileSet.BitmaskMode AutotileGetBitmaskMode(int id)
        {
            return (TileSet.BitmaskMode)NativeCalls.godot_icall_1_954(method_bind_15, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "autotile_set_spacing");

        /// <summary>
        /// <para>Sets the spacing between subtiles of the atlas/autotile.</para>
        /// </summary>
        [GodotMethod("autotile_set_spacing")]
        public void AutotileSetSpacing(int id, int spacing)
        {
            NativeCalls.godot_icall_2_65(method_bind_16, Object.GetPtr(this), id, spacing);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "autotile_get_spacing");

        /// <summary>
        /// <para>Returns the spacing between subtiles of the atlas/autotile.</para>
        /// </summary>
        [GodotMethod("autotile_get_spacing")]
        public int AutotileGetSpacing(int id)
        {
            return NativeCalls.godot_icall_1_11(method_bind_17, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "autotile_set_size");

        /// <summary>
        /// <para>Sets the size of the subtiles in an atlas/autotile.</para>
        /// </summary>
        [GodotMethod("autotile_set_size")]
        public void AutotileSetSize(int id, Vector2 size)
        {
            NativeCalls.godot_icall_2_45(method_bind_18, Object.GetPtr(this), id, ref size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "autotile_get_size");

        /// <summary>
        /// <para>Returns the size of the subtiles in an atlas/autotile.</para>
        /// </summary>
        [GodotMethod("autotile_get_size")]
        public Vector2 AutotileGetSize(int id)
        {
            NativeCalls.godot_icall_1_44(method_bind_19, Object.GetPtr(this), id, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_set_name");

        /// <summary>
        /// <para>Sets the tile's name.</para>
        /// </summary>
        [GodotMethod("tile_set_name")]
        public void TileSetName(int id, string name)
        {
            NativeCalls.godot_icall_2_121(method_bind_20, Object.GetPtr(this), id, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_get_name");

        /// <summary>
        /// <para>Returns the tile's name.</para>
        /// </summary>
        [GodotMethod("tile_get_name")]
        public string TileGetName(int id)
        {
            return NativeCalls.godot_icall_1_89(method_bind_21, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_set_texture");

        /// <summary>
        /// <para>Sets the tile's texture.</para>
        /// </summary>
        [GodotMethod("tile_set_texture")]
        public void TileSetTexture(int id, Texture texture)
        {
            NativeCalls.godot_icall_2_58(method_bind_22, Object.GetPtr(this), id, Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_get_texture");

        /// <summary>
        /// <para>Returns the tile's texture.</para>
        /// </summary>
        [GodotMethod("tile_get_texture")]
        public Texture TileGetTexture(int id)
        {
            return NativeCalls.godot_icall_1_59(method_bind_23, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_set_normal_map");

        /// <summary>
        /// <para>Sets the tile's normal map texture.</para>
        /// <para>Note: Godot expects the normal map to use X+, Y-, and Z+ coordinates. See <a href="http://wiki.polycount.com/wiki/Normal_Map_Technical_Details#Common_Swizzle_Coordinates">this page</a> for a comparison of normal map coordinates expected by popular engines.</para>
        /// </summary>
        [GodotMethod("tile_set_normal_map")]
        public void TileSetNormalMap(int id, Texture normalMap)
        {
            NativeCalls.godot_icall_2_58(method_bind_24, Object.GetPtr(this), id, Object.GetPtr(normalMap));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_get_normal_map");

        /// <summary>
        /// <para>Returns the tile's normal map texture.</para>
        /// </summary>
        [GodotMethod("tile_get_normal_map")]
        public Texture TileGetNormalMap(int id)
        {
            return NativeCalls.godot_icall_1_59(method_bind_25, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_set_material");

        /// <summary>
        /// <para>Sets the tile's material.</para>
        /// </summary>
        [GodotMethod("tile_set_material")]
        public void TileSetMaterial(int id, ShaderMaterial material)
        {
            NativeCalls.godot_icall_2_58(method_bind_26, Object.GetPtr(this), id, Object.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_get_material");

        /// <summary>
        /// <para>Returns the tile's material.</para>
        /// </summary>
        [GodotMethod("tile_get_material")]
        public ShaderMaterial TileGetMaterial(int id)
        {
            return NativeCalls.godot_icall_1_955(method_bind_27, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_set_modulate");

        /// <summary>
        /// <para>Sets the tile's modulation color.</para>
        /// <para>Note: Modulation is performed by setting the tile's vertex color. To access this in a shader, use <c>COLOR</c> rather than <c>MODULATE</c> (which instead accesses the <see cref="Godot.TileMap"/>'s <see cref="Godot.CanvasItem.Modulate"/> property).</para>
        /// </summary>
        [GodotMethod("tile_set_modulate")]
        public void TileSetModulate(int id, Color color)
        {
            NativeCalls.godot_icall_2_464(method_bind_28, Object.GetPtr(this), id, ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_get_modulate");

        /// <summary>
        /// <para>Returns the tile's modulation color.</para>
        /// </summary>
        [GodotMethod("tile_get_modulate")]
        public Color TileGetModulate(int id)
        {
            NativeCalls.godot_icall_1_465(method_bind_29, Object.GetPtr(this), id, out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_set_texture_offset");

        /// <summary>
        /// <para>Sets the tile's texture offset.</para>
        /// </summary>
        [GodotMethod("tile_set_texture_offset")]
        public void TileSetTextureOffset(int id, Vector2 textureOffset)
        {
            NativeCalls.godot_icall_2_45(method_bind_30, Object.GetPtr(this), id, ref textureOffset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_get_texture_offset");

        /// <summary>
        /// <para>Returns the texture offset of the tile.</para>
        /// </summary>
        [GodotMethod("tile_get_texture_offset")]
        public Vector2 TileGetTextureOffset(int id)
        {
            NativeCalls.godot_icall_1_44(method_bind_31, Object.GetPtr(this), id, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_set_region");

        /// <summary>
        /// <para>Sets the tile's sub-region in the texture. This is common in texture atlases.</para>
        /// </summary>
        [GodotMethod("tile_set_region")]
        public void TileSetRegion(int id, Rect2 region)
        {
            NativeCalls.godot_icall_2_215(method_bind_32, Object.GetPtr(this), id, ref region);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_get_region");

        /// <summary>
        /// <para>Returns the tile sub-region in the texture.</para>
        /// </summary>
        [GodotMethod("tile_get_region")]
        public Rect2 TileGetRegion(int id)
        {
            NativeCalls.godot_icall_1_541(method_bind_33, Object.GetPtr(this), id, out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_set_shape");

        /// <summary>
        /// <para>Sets a shape for the tile, enabling collision.</para>
        /// </summary>
        [GodotMethod("tile_set_shape")]
        public void TileSetShape(int id, int shapeId, Shape2D shape)
        {
            NativeCalls.godot_icall_3_85(method_bind_34, Object.GetPtr(this), id, shapeId, Object.GetPtr(shape));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_get_shape");

        /// <summary>
        /// <para>Returns a tile's given shape.</para>
        /// </summary>
        [GodotMethod("tile_get_shape")]
        public Shape2D TileGetShape(int id, int shapeId)
        {
            return NativeCalls.godot_icall_2_956(method_bind_35, Object.GetPtr(this), id, shapeId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_set_shape_offset");

        /// <summary>
        /// <para>Sets the offset of a tile's shape.</para>
        /// </summary>
        [GodotMethod("tile_set_shape_offset")]
        public void TileSetShapeOffset(int id, int shapeId, Vector2 shapeOffset)
        {
            NativeCalls.godot_icall_3_81(method_bind_36, Object.GetPtr(this), id, shapeId, ref shapeOffset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_get_shape_offset");

        /// <summary>
        /// <para>Returns the offset of a tile's shape.</para>
        /// </summary>
        [GodotMethod("tile_get_shape_offset")]
        public Vector2 TileGetShapeOffset(int id, int shapeId)
        {
            NativeCalls.godot_icall_2_82(method_bind_37, Object.GetPtr(this), id, shapeId, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_set_shape_transform");

        /// <summary>
        /// <para>Sets a <see cref="Godot.Transform2D"/> on a tile's shape.</para>
        /// </summary>
        [GodotMethod("tile_set_shape_transform")]
        public void TileSetShapeTransform(int id, int shapeId, Transform2D shapeTransform)
        {
            NativeCalls.godot_icall_3_957(method_bind_38, Object.GetPtr(this), id, shapeId, ref shapeTransform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_get_shape_transform");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Transform2D"/> of a tile's shape.</para>
        /// </summary>
        [GodotMethod("tile_get_shape_transform")]
        public Transform2D TileGetShapeTransform(int id, int shapeId)
        {
            NativeCalls.godot_icall_2_958(method_bind_39, Object.GetPtr(this), id, shapeId, out Transform2D argRet); return (Transform2D)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_set_shape_one_way");

        /// <summary>
        /// <para>Enables one-way collision on a tile's shape.</para>
        /// </summary>
        [GodotMethod("tile_set_shape_one_way")]
        public void TileSetShapeOneWay(int id, int shapeId, bool oneWay)
        {
            NativeCalls.godot_icall_3_37(method_bind_40, Object.GetPtr(this), id, shapeId, oneWay);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_get_shape_one_way");

        /// <summary>
        /// <para>Returns the one-way collision value of a tile's shape.</para>
        /// </summary>
        [GodotMethod("tile_get_shape_one_way")]
        public bool TileGetShapeOneWay(int id, int shapeId)
        {
            return NativeCalls.godot_icall_2_177(method_bind_41, Object.GetPtr(this), id, shapeId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_set_shape_one_way_margin");

        [GodotMethod("tile_set_shape_one_way_margin")]
        public void TileSetShapeOneWayMargin(int id, int shapeId, float oneWay)
        {
            NativeCalls.godot_icall_3_69(method_bind_42, Object.GetPtr(this), id, shapeId, oneWay);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_get_shape_one_way_margin");

        [GodotMethod("tile_get_shape_one_way_margin")]
        public float TileGetShapeOneWayMargin(int id, int shapeId)
        {
            return NativeCalls.godot_icall_2_70(method_bind_43, Object.GetPtr(this), id, shapeId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_add_shape");

        /// <summary>
        /// <para>Adds a shape to the tile.</para>
        /// </summary>
        /// <param name="autotileCoord">If the parameter is null, then the default value is new Vector2(0, 0)</param>
        [GodotMethod("tile_add_shape")]
        public void TileAddShape(int id, Shape2D shape, Transform2D shapeTransform, bool oneWay = false, Nullable<Vector2> autotileCoord = null)
        {
            Vector2 autotileCoord_in = autotileCoord.HasValue ? autotileCoord.Value : new Vector2(0, 0);
            NativeCalls.godot_icall_5_959(method_bind_44, Object.GetPtr(this), id, Object.GetPtr(shape), ref shapeTransform, oneWay, ref autotileCoord_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_get_shape_count");

        /// <summary>
        /// <para>Returns the number of shapes assigned to a tile.</para>
        /// </summary>
        [GodotMethod("tile_get_shape_count")]
        public int TileGetShapeCount(int id)
        {
            return NativeCalls.godot_icall_1_11(method_bind_45, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_set_shapes");

        /// <summary>
        /// <para>Sets an array of shapes for the tile, enabling collision.</para>
        /// </summary>
        [GodotMethod("tile_set_shapes")]
        public void TileSetShapes(int id, Godot.Collections.Array shapes)
        {
            NativeCalls.godot_icall_2_607(method_bind_46, Object.GetPtr(this), id, shapes.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_get_shapes");

        /// <summary>
        /// <para>Returns an array of dictionaries describing the tile's shapes.</para>
        /// <para>Dictionary structure in the array returned by this method:</para>
        /// <para><code>
        /// {
        ///     "autotile_coord": Vector2,
        ///     "one_way": bool,
        ///     "one_way_margin": int,
        ///     "shape": CollisionShape2D,
        ///     "shape_transform": Transform2D,
        /// }
        /// </code></para>
        /// </summary>
        [GodotMethod("tile_get_shapes")]
        public Godot.Collections.Array TileGetShapes(int id)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_1_483(method_bind_47, Object.GetPtr(this), id));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_set_tile_mode");

        /// <summary>
        /// <para>Sets the tile's <see cref="Godot.TileSet.TileMode"/>.</para>
        /// </summary>
        [GodotMethod("tile_set_tile_mode")]
        public void TileSetTileMode(int id, TileSet.TileMode tilemode)
        {
            NativeCalls.godot_icall_2_65(method_bind_48, Object.GetPtr(this), id, (int)tilemode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_get_tile_mode");

        /// <summary>
        /// <para>Returns the tile's <see cref="Godot.TileSet.TileMode"/>.</para>
        /// </summary>
        [GodotMethod("tile_get_tile_mode")]
        public TileSet.TileMode TileGetTileMode(int id)
        {
            return (TileSet.TileMode)NativeCalls.godot_icall_1_960(method_bind_49, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_set_navigation_polygon");

        /// <summary>
        /// <para>Sets the tile's navigation polygon.</para>
        /// </summary>
        [GodotMethod("tile_set_navigation_polygon")]
        public void TileSetNavigationPolygon(int id, NavigationPolygon navigationPolygon)
        {
            NativeCalls.godot_icall_2_58(method_bind_50, Object.GetPtr(this), id, Object.GetPtr(navigationPolygon));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_get_navigation_polygon");

        /// <summary>
        /// <para>Returns the navigation polygon of the tile.</para>
        /// </summary>
        [GodotMethod("tile_get_navigation_polygon")]
        public NavigationPolygon TileGetNavigationPolygon(int id)
        {
            return NativeCalls.godot_icall_1_961(method_bind_51, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_set_navigation_polygon_offset");

        /// <summary>
        /// <para>Sets an offset for the tile's navigation polygon.</para>
        /// </summary>
        [GodotMethod("tile_set_navigation_polygon_offset")]
        public void TileSetNavigationPolygonOffset(int id, Vector2 navigationPolygonOffset)
        {
            NativeCalls.godot_icall_2_45(method_bind_52, Object.GetPtr(this), id, ref navigationPolygonOffset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_53 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_get_navigation_polygon_offset");

        /// <summary>
        /// <para>Returns the offset of the tile's navigation polygon.</para>
        /// </summary>
        [GodotMethod("tile_get_navigation_polygon_offset")]
        public Vector2 TileGetNavigationPolygonOffset(int id)
        {
            NativeCalls.godot_icall_1_44(method_bind_53, Object.GetPtr(this), id, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_54 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_set_light_occluder");

        /// <summary>
        /// <para>Sets a light occluder for the tile.</para>
        /// </summary>
        [GodotMethod("tile_set_light_occluder")]
        public void TileSetLightOccluder(int id, OccluderPolygon2D lightOccluder)
        {
            NativeCalls.godot_icall_2_58(method_bind_54, Object.GetPtr(this), id, Object.GetPtr(lightOccluder));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_55 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_get_light_occluder");

        /// <summary>
        /// <para>Returns the tile's light occluder.</para>
        /// </summary>
        [GodotMethod("tile_get_light_occluder")]
        public OccluderPolygon2D TileGetLightOccluder(int id)
        {
            return NativeCalls.godot_icall_1_962(method_bind_55, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_56 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_set_occluder_offset");

        /// <summary>
        /// <para>Sets an offset for the tile's light occluder.</para>
        /// </summary>
        [GodotMethod("tile_set_occluder_offset")]
        public void TileSetOccluderOffset(int id, Vector2 occluderOffset)
        {
            NativeCalls.godot_icall_2_45(method_bind_56, Object.GetPtr(this), id, ref occluderOffset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_57 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_get_occluder_offset");

        /// <summary>
        /// <para>Returns the offset of the tile's light occluder.</para>
        /// </summary>
        [GodotMethod("tile_get_occluder_offset")]
        public Vector2 TileGetOccluderOffset(int id)
        {
            NativeCalls.godot_icall_1_44(method_bind_57, Object.GetPtr(this), id, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_58 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_set_z_index");

        /// <summary>
        /// <para>Sets the tile's drawing index.</para>
        /// </summary>
        [GodotMethod("tile_set_z_index")]
        public void TileSetZIndex(int id, int zIndex)
        {
            NativeCalls.godot_icall_2_65(method_bind_58, Object.GetPtr(this), id, zIndex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_59 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tile_get_z_index");

        /// <summary>
        /// <para>Returns the tile's Z index (drawing layer).</para>
        /// </summary>
        [GodotMethod("tile_get_z_index")]
        public int TileGetZIndex(int id)
        {
            return NativeCalls.godot_icall_1_11(method_bind_59, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_60 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_tile");

        /// <summary>
        /// <para>Removes the given tile ID.</para>
        /// </summary>
        [GodotMethod("remove_tile")]
        public void RemoveTile(int id)
        {
            NativeCalls.godot_icall_1_4(method_bind_60, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_61 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Clears all tiles.</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_61, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_62 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_last_unused_tile_id");

        /// <summary>
        /// <para>Returns the ID following the last currently used ID, useful when creating a new tile.</para>
        /// </summary>
        [GodotMethod("get_last_unused_tile_id")]
        public int GetLastUnusedTileId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_62, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_63 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "find_tile_by_name");

        /// <summary>
        /// <para>Returns the first tile matching the given name.</para>
        /// </summary>
        [GodotMethod("find_tile_by_name")]
        public int FindTileByName(string name)
        {
            return NativeCalls.godot_icall_1_138(method_bind_63, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_64 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tiles_ids");

        /// <summary>
        /// <para>Returns an array of all currently used tile IDs.</para>
        /// </summary>
        [GodotMethod("get_tiles_ids")]
        public Godot.Collections.Array GetTilesIds()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_64, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
