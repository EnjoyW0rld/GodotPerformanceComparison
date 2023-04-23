using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Node for 2D tile-based maps. Tilemaps use a <see cref="Godot.TileSet"/> which contain a list of tiles (textures plus optional collision, navigation, and/or occluder shapes) which are used to create grid-based maps.</para>
    /// <para>When doing physics queries against the tilemap, the cell coordinates are encoded as <c>metadata</c> for each detected collision shape returned by methods such as <see cref="Godot.Physics2DDirectSpaceState.IntersectShape"/>, <see cref="Godot.Physics2DDirectBodyState.GetContactColliderShapeMetadata"/>, etc.</para>
    /// </summary>
    public partial class TileMap : Node2D
    {
        /// <summary>
        /// <para>Returned when a cell doesn't exist.</para>
        /// </summary>
        public const int InvalidCell = -1;

        public enum ModeEnum
        {
            /// <summary>
            /// <para>Orthogonal orientation mode.</para>
            /// </summary>
            Square = 0,
            /// <summary>
            /// <para>Isometric orientation mode.</para>
            /// </summary>
            Isometric = 1,
            /// <summary>
            /// <para>Custom orientation mode.</para>
            /// </summary>
            Custom = 2
        }

        public enum TileOrigin
        {
            /// <summary>
            /// <para>Tile origin at its top-left corner.</para>
            /// </summary>
            TopLeft = 0,
            /// <summary>
            /// <para>Tile origin at its center.</para>
            /// </summary>
            Center = 1,
            /// <summary>
            /// <para>Tile origin at its bottom-left corner.</para>
            /// </summary>
            BottomLeft = 2
        }

        public enum HalfOffset
        {
            /// <summary>
            /// <para>Half offset on the X coordinate.</para>
            /// </summary>
            X = 0,
            /// <summary>
            /// <para>Half offset on the Y coordinate.</para>
            /// </summary>
            Y = 1,
            /// <summary>
            /// <para>Half offset disabled.</para>
            /// </summary>
            Disabled = 2,
            /// <summary>
            /// <para>Half offset on the X coordinate (negative).</para>
            /// </summary>
            NegativeX = 3,
            /// <summary>
            /// <para>Half offset on the Y coordinate (negative).</para>
            /// </summary>
            NegativeY = 4
        }

        /// <summary>
        /// <para>The TileMap orientation mode. See <see cref="Godot.TileMap.ModeEnum"/> for possible values.</para>
        /// </summary>
        public TileMap.ModeEnum Mode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The assigned <see cref="Godot.TileSet"/>.</para>
        /// </summary>
        public TileSet TileSet
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTileset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTileset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The TileMap's cell size.</para>
        /// </summary>
        public Vector2 CellSize
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
        /// <para>The TileMap's quadrant size. Optimizes drawing by batching, using chunks of this size.</para>
        /// </summary>
        public int CellQuadrantSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetQuadrantSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetQuadrantSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The custom <see cref="Godot.Transform2D"/> to be applied to the TileMap's cells.</para>
        /// </summary>
        public Transform2D CellCustomTransform
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCustomTransform();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCustomTransform(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Amount to offset alternating tiles. See <see cref="Godot.TileMap.HalfOffset"/> for possible values.</para>
        /// </summary>
        public TileMap.HalfOffset CellHalfOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHalfOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHalfOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Position for tile origin. See <see cref="Godot.TileMap.TileOrigin"/> for possible values.</para>
        /// </summary>
        public TileMap.TileOrigin CellTileOrigin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTileOrigin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTileOrigin(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the TileMap's direct children will be drawn in order of their Y coordinate.</para>
        /// </summary>
        public bool CellYSort
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsYSortModeEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetYSortMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, collision shapes are visible in the editor. Doesn't affect collision shapes visibility at runtime. To show collision shapes at runtime, enable Visible Collision Shapes in the Debug menu instead.</para>
        /// </summary>
        public bool ShowCollision
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsShowCollisionEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShowCollision(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the compatibility with the tilemaps made in Godot 3.1 or earlier is maintained (textures move when the tile origin changes and rotate if the texture size is not homogeneous). This mode presents problems when doing <c>flip_h</c>, <c>flip_v</c> and <c>transpose</c> tile operations on non-homogeneous isometric tiles (e.g. 2:1), in which the texture could not coincide with the collision, thus it is not recommended for isometric or non-square tiles.</para>
        /// <para>If <c>false</c>, the textures do not move when doing <c>flip_h</c>, <c>flip_v</c> operations if no offset is used, nor when changing the tile origin.</para>
        /// <para>The compatibility mode doesn't work with the <see cref="Godot.TileMap.CenteredTextures"/> option, because displacing textures with the <see cref="Godot.TileMap.CellTileOrigin"/> option or in irregular tiles is not relevant when centering those textures.</para>
        /// </summary>
        public bool CompatibilityMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsCompatibilityModeEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCompatibilityMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the textures will be centered in the middle of each tile. This is useful for certain isometric or top-down modes when textures are made larger or smaller than the tiles (e.g. to avoid flickering on tile edges). The offset is still applied, but from the center of the tile. If used, <see cref="Godot.TileMap.CompatibilityMode"/> is ignored.</para>
        /// <para>If <c>false</c>, the texture position start in the top-left corner unless <see cref="Godot.TileMap.CompatibilityMode"/> is enabled.</para>
        /// </summary>
        public bool CenteredTextures
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsCenteredTexturesEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCenteredTextures(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the cell's UVs will be clipped.</para>
        /// </summary>
        public bool CellClipUv
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetClipUv();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetClipUv(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, this tilemap's collision shape will be added to the collision shape of the parent. The parent has to be a <see cref="Godot.CollisionObject2D"/>.</para>
        /// </summary>
        public bool CollisionUseParent
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCollisionUseParent();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCollisionUseParent(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, TileMap collisions will be handled as a kinematic body. If <c>false</c>, collisions will be handled as static body.</para>
        /// </summary>
        public bool CollisionUseKinematic
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCollisionUseKinematic();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCollisionUseKinematic(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Friction value for static body collisions (see <c>collision_use_kinematic</c>).</para>
        /// </summary>
        public float CollisionFriction
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCollisionFriction();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCollisionFriction(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Bounce value for static body collisions (see <c>collision_use_kinematic</c>).</para>
        /// </summary>
        public float CollisionBounce
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCollisionBounce();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCollisionBounce(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The collision layer(s) for all colliders in the TileMap. See <a href="$DOCS_URL/tutorials/physics/physics_introduction.html#collision-layers-and-masks">Collision layers and masks</a> in the documentation for more information.</para>
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
        /// <para>The collision mask(s) for all colliders in the TileMap. See <a href="$DOCS_URL/tutorials/physics/physics_introduction.html#collision-layers-and-masks">Collision layers and masks</a> in the documentation for more information.</para>
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
        /// <para>If <c>true</c>, this TileMap bakes a navigation region.</para>
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
        /// <para>The navigation layers the TileMap generates its navigation regions in.</para>
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
        /// <para>The light mask assigned to all light occluders in the TileMap. The TileSet's light occluders will cast shadows only from Light2D(s) that have the same light mask(s).</para>
        /// </summary>
        public int OccluderLightMask
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOccluderLightMask();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOccluderLightMask(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "TileMap";

        public TileMap() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_TileMap_Ctor(this);
        }

        internal TileMap(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tileset");

        [GodotMethod("set_tileset")]
        [Obsolete("SetTileset is deprecated. Use the TileSet property instead.")]
        public void SetTileset(TileSet tileset)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(tileset));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tileset");

        [GodotMethod("get_tileset")]
        [Obsolete("GetTileset is deprecated. Use the TileSet property instead.")]
        public TileSet GetTileset()
        {
            return NativeCalls.godot_icall_0_940(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mode");

        [GodotMethod("set_mode")]
        [Obsolete("SetMode is deprecated. Use the Mode property instead.")]
        public void SetMode(TileMap.ModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mode");

        [GodotMethod("get_mode")]
        [Obsolete("GetMode is deprecated. Use the Mode property instead.")]
        public TileMap.ModeEnum GetMode()
        {
            return (TileMap.ModeEnum)NativeCalls.godot_icall_0_941(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_half_offset");

        [GodotMethod("set_half_offset")]
        [Obsolete("SetHalfOffset is deprecated. Use the CellHalfOffset property instead.")]
        public void SetHalfOffset(TileMap.HalfOffset halfOffset)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), (int)halfOffset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_half_offset");

        [GodotMethod("get_half_offset")]
        [Obsolete("GetHalfOffset is deprecated. Use the CellHalfOffset property instead.")]
        public TileMap.HalfOffset GetHalfOffset()
        {
            return (TileMap.HalfOffset)NativeCalls.godot_icall_0_942(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_custom_transform");

        [GodotMethod("set_custom_transform")]
        [Obsolete("SetCustomTransform is deprecated. Use the CellCustomTransform property instead.")]
        public void SetCustomTransform(Transform2D customTransform)
        {
            NativeCalls.godot_icall_1_220(method_bind_6, Object.GetPtr(this), ref customTransform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_custom_transform");

        [GodotMethod("get_custom_transform")]
        [Obsolete("GetCustomTransform is deprecated. Use the CellCustomTransform property instead.")]
        public Transform2D GetCustomTransform()
        {
            NativeCalls.godot_icall_0_221(method_bind_7, Object.GetPtr(this), out Transform2D argRet); return (Transform2D)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cell_size");

        [GodotMethod("set_cell_size")]
        [Obsolete("SetCellSize is deprecated. Use the CellSize property instead.")]
        public void SetCellSize(Vector2 size)
        {
            NativeCalls.godot_icall_1_57(method_bind_8, Object.GetPtr(this), ref size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cell_size");

        [GodotMethod("get_cell_size")]
        [Obsolete("GetCellSize is deprecated. Use the CellSize property instead.")]
        public Vector2 GetCellSize()
        {
            NativeCalls.godot_icall_0_18(method_bind_9, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_quadrant_size");

        [GodotMethod("set_quadrant_size")]
        [Obsolete("SetQuadrantSize is deprecated. Use the CellQuadrantSize property instead.")]
        public void SetQuadrantSize(int size)
        {
            NativeCalls.godot_icall_1_4(method_bind_10, Object.GetPtr(this), size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_quadrant_size");

        [GodotMethod("get_quadrant_size")]
        [Obsolete("GetQuadrantSize is deprecated. Use the CellQuadrantSize property instead.")]
        public int GetQuadrantSize()
        {
            return NativeCalls.godot_icall_0_5(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tile_origin");

        [GodotMethod("set_tile_origin")]
        [Obsolete("SetTileOrigin is deprecated. Use the CellTileOrigin property instead.")]
        public void SetTileOrigin(TileMap.TileOrigin origin)
        {
            NativeCalls.godot_icall_1_4(method_bind_12, Object.GetPtr(this), (int)origin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tile_origin");

        [GodotMethod("get_tile_origin")]
        [Obsolete("GetTileOrigin is deprecated. Use the CellTileOrigin property instead.")]
        public TileMap.TileOrigin GetTileOrigin()
        {
            return (TileMap.TileOrigin)NativeCalls.godot_icall_0_943(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_clip_uv");

        [GodotMethod("set_clip_uv")]
        [Obsolete("SetClipUv is deprecated. Use the CellClipUv property instead.")]
        public void SetClipUv(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_14, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_clip_uv");

        [GodotMethod("get_clip_uv")]
        [Obsolete("GetClipUv is deprecated. Use the CellClipUv property instead.")]
        public bool GetClipUv()
        {
            return NativeCalls.godot_icall_0_7(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_y_sort_mode");

        [GodotMethod("set_y_sort_mode")]
        [Obsolete("SetYSortMode is deprecated. Use the CellYSort property instead.")]
        public void SetYSortMode(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_16, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_y_sort_mode_enabled");

        [GodotMethod("is_y_sort_mode_enabled")]
        [Obsolete("IsYSortModeEnabled is deprecated. Use the CellYSort property instead.")]
        public bool IsYSortModeEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_compatibility_mode");

        [GodotMethod("set_compatibility_mode")]
        [Obsolete("SetCompatibilityMode is deprecated. Use the CompatibilityMode property instead.")]
        public void SetCompatibilityMode(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_18, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_compatibility_mode_enabled");

        [GodotMethod("is_compatibility_mode_enabled")]
        [Obsolete("IsCompatibilityModeEnabled is deprecated. Use the CompatibilityMode property instead.")]
        public bool IsCompatibilityModeEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_show_collision");

        [GodotMethod("set_show_collision")]
        [Obsolete("SetShowCollision is deprecated. Use the ShowCollision property instead.")]
        public void SetShowCollision(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_20, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_show_collision_enabled");

        [GodotMethod("is_show_collision_enabled")]
        [Obsolete("IsShowCollisionEnabled is deprecated. Use the ShowCollision property instead.")]
        public bool IsShowCollisionEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_centered_textures");

        [GodotMethod("set_centered_textures")]
        [Obsolete("SetCenteredTextures is deprecated. Use the CenteredTextures property instead.")]
        public void SetCenteredTextures(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_22, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_centered_textures_enabled");

        [GodotMethod("is_centered_textures_enabled")]
        [Obsolete("IsCenteredTexturesEnabled is deprecated. Use the CenteredTextures property instead.")]
        public bool IsCenteredTexturesEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_use_kinematic");

        [GodotMethod("set_collision_use_kinematic")]
        [Obsolete("SetCollisionUseKinematic is deprecated. Use the CollisionUseKinematic property instead.")]
        public void SetCollisionUseKinematic(bool useKinematic)
        {
            NativeCalls.godot_icall_1_16(method_bind_24, Object.GetPtr(this), useKinematic);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_use_kinematic");

        [GodotMethod("get_collision_use_kinematic")]
        [Obsolete("GetCollisionUseKinematic is deprecated. Use the CollisionUseKinematic property instead.")]
        public bool GetCollisionUseKinematic()
        {
            return NativeCalls.godot_icall_0_7(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_use_parent");

        [GodotMethod("set_collision_use_parent")]
        [Obsolete("SetCollisionUseParent is deprecated. Use the CollisionUseParent property instead.")]
        public void SetCollisionUseParent(bool useParent)
        {
            NativeCalls.godot_icall_1_16(method_bind_26, Object.GetPtr(this), useParent);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_use_parent");

        [GodotMethod("get_collision_use_parent")]
        [Obsolete("GetCollisionUseParent is deprecated. Use the CollisionUseParent property instead.")]
        public bool GetCollisionUseParent()
        {
            return NativeCalls.godot_icall_0_7(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_layer");

        [GodotMethod("set_collision_layer")]
        [Obsolete("SetCollisionLayer is deprecated. Use the CollisionLayer property instead.")]
        public void SetCollisionLayer(uint layer)
        {
            NativeCalls.godot_icall_1_187(method_bind_28, Object.GetPtr(this), layer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_layer");

        [GodotMethod("get_collision_layer")]
        [Obsolete("GetCollisionLayer is deprecated. Use the CollisionLayer property instead.")]
        public uint GetCollisionLayer()
        {
            return NativeCalls.godot_icall_0_188(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_mask");

        [GodotMethod("set_collision_mask")]
        [Obsolete("SetCollisionMask is deprecated. Use the CollisionMask property instead.")]
        public void SetCollisionMask(uint mask)
        {
            NativeCalls.godot_icall_1_187(method_bind_30, Object.GetPtr(this), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_mask");

        [GodotMethod("get_collision_mask")]
        [Obsolete("GetCollisionMask is deprecated. Use the CollisionMask property instead.")]
        public uint GetCollisionMask()
        {
            return NativeCalls.godot_icall_0_188(method_bind_31, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_layer_bit");

        /// <summary>
        /// <para>Sets the given collision layer bit.</para>
        /// </summary>
        [GodotMethod("set_collision_layer_bit")]
        public void SetCollisionLayerBit(int bit, bool value)
        {
            NativeCalls.godot_icall_2_23(method_bind_32, Object.GetPtr(this), bit, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_layer_bit");

        /// <summary>
        /// <para>Returns <c>true</c> if the given collision layer bit is set.</para>
        /// </summary>
        [GodotMethod("get_collision_layer_bit")]
        public bool GetCollisionLayerBit(int bit)
        {
            return NativeCalls.godot_icall_1_35(method_bind_33, Object.GetPtr(this), bit);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_mask_bit");

        /// <summary>
        /// <para>Sets the given collision mask bit.</para>
        /// </summary>
        [GodotMethod("set_collision_mask_bit")]
        public void SetCollisionMaskBit(int bit, bool value)
        {
            NativeCalls.godot_icall_2_23(method_bind_34, Object.GetPtr(this), bit, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_mask_bit");

        /// <summary>
        /// <para>Returns <c>true</c> if the given collision mask bit is set.</para>
        /// </summary>
        [GodotMethod("get_collision_mask_bit")]
        public bool GetCollisionMaskBit(int bit)
        {
            return NativeCalls.godot_icall_1_35(method_bind_35, Object.GetPtr(this), bit);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_friction");

        [GodotMethod("set_collision_friction")]
        [Obsolete("SetCollisionFriction is deprecated. Use the CollisionFriction property instead.")]
        public void SetCollisionFriction(float value)
        {
            NativeCalls.godot_icall_1_15(method_bind_36, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_friction");

        [GodotMethod("get_collision_friction")]
        [Obsolete("GetCollisionFriction is deprecated. Use the CollisionFriction property instead.")]
        public float GetCollisionFriction()
        {
            return NativeCalls.godot_icall_0_14(method_bind_37, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_bounce");

        [GodotMethod("set_collision_bounce")]
        [Obsolete("SetCollisionBounce is deprecated. Use the CollisionBounce property instead.")]
        public void SetCollisionBounce(float value)
        {
            NativeCalls.godot_icall_1_15(method_bind_38, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_bounce");

        [GodotMethod("get_collision_bounce")]
        [Obsolete("GetCollisionBounce is deprecated. Use the CollisionBounce property instead.")]
        public float GetCollisionBounce()
        {
            return NativeCalls.godot_icall_0_14(method_bind_39, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bake_navigation");

        [GodotMethod("set_bake_navigation")]
        [Obsolete("SetBakeNavigation is deprecated. Use the BakeNavigation property instead.")]
        public void SetBakeNavigation(bool bakeNavigation)
        {
            NativeCalls.godot_icall_1_16(method_bind_40, Object.GetPtr(this), bakeNavigation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_baking_navigation");

        [GodotMethod("is_baking_navigation")]
        [Obsolete("IsBakingNavigation is deprecated. Use the BakeNavigation property instead.")]
        public bool IsBakingNavigation()
        {
            return NativeCalls.godot_icall_0_7(method_bind_41, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_navigation_layers");

        [GodotMethod("set_navigation_layers")]
        [Obsolete("SetNavigationLayers is deprecated. Use the NavigationLayers property instead.")]
        public void SetNavigationLayers(uint navigationLayers)
        {
            NativeCalls.godot_icall_1_187(method_bind_42, Object.GetPtr(this), navigationLayers);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_navigation_layers");

        [GodotMethod("get_navigation_layers")]
        [Obsolete("GetNavigationLayers is deprecated. Use the NavigationLayers property instead.")]
        public uint GetNavigationLayers()
        {
            return NativeCalls.godot_icall_0_188(method_bind_43, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_occluder_light_mask");

        [GodotMethod("set_occluder_light_mask")]
        [Obsolete("SetOccluderLightMask is deprecated. Use the OccluderLightMask property instead.")]
        public void SetOccluderLightMask(int mask)
        {
            NativeCalls.godot_icall_1_4(method_bind_44, Object.GetPtr(this), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_occluder_light_mask");

        [GodotMethod("get_occluder_light_mask")]
        [Obsolete("GetOccluderLightMask is deprecated. Use the OccluderLightMask property instead.")]
        public int GetOccluderLightMask()
        {
            return NativeCalls.godot_icall_0_5(method_bind_45, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cell");

        /// <summary>
        /// <para>Sets the tile index for the given cell.</para>
        /// <para>An index of <c>-1</c> clears the cell.</para>
        /// <para>Optionally, the tile can also be flipped, transposed, or given autotile coordinates. The autotile coordinate refers to the column and row of the subtile.</para>
        /// <para>Note: Data such as navigation polygons and collision shapes are not immediately updated for performance reasons.</para>
        /// <para>If you need these to be immediately updated, you can call <see cref="Godot.TileMap.UpdateDirtyQuadrants"/>.</para>
        /// <para>Overriding this method also overrides it internally, allowing custom logic to be implemented when tiles are placed/removed:</para>
        /// <para><code>
        /// func set_cell(x, y, tile, flip_x=false, flip_y=false, transpose=false, autotile_coord=Vector2()):
        ///     # Write your custom logic here.
        ///     # To call the default method:
        ///     .set_cell(x, y, tile, flip_x, flip_y, transpose, autotile_coord)
        /// </code></para>
        /// </summary>
        /// <param name="autotileCoord">If the parameter is null, then the default value is new Vector2(0, 0)</param>
        [GodotMethod("set_cell")]
        public void SetCell(int x, int y, int tile, bool flipX = false, bool flipY = false, bool transpose = false, Nullable<Vector2> autotileCoord = null)
        {
            Vector2 autotileCoord_in = autotileCoord.HasValue ? autotileCoord.Value : new Vector2(0, 0);
            NativeCalls.godot_icall_7_944(method_bind_46, Object.GetPtr(this), x, y, tile, flipX, flipY, transpose, ref autotileCoord_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cellv");

        /// <summary>
        /// <para>Sets the tile index for the cell given by a Vector2.</para>
        /// <para>An index of <c>-1</c> clears the cell.</para>
        /// <para>Optionally, the tile can also be flipped, transposed, or given autotile coordinates. The autotile coordinate refers to the column and row of the subtile.</para>
        /// <para>Note: Data such as navigation polygons and collision shapes are not immediately updated for performance reasons.</para>
        /// <para>If you need these to be immediately updated, you can call <see cref="Godot.TileMap.UpdateDirtyQuadrants"/>.</para>
        /// </summary>
        /// <param name="autotileCoord">If the parameter is null, then the default value is new Vector2(0, 0)</param>
        [GodotMethod("set_cellv")]
        public void SetCellv(Vector2 position, int tile, bool flipX = false, bool flipY = false, bool transpose = false, Nullable<Vector2> autotileCoord = null)
        {
            Vector2 autotileCoord_in = autotileCoord.HasValue ? autotileCoord.Value : new Vector2(0, 0);
            NativeCalls.godot_icall_6_945(method_bind_47, Object.GetPtr(this), ref position, tile, flipX, flipY, transpose, ref autotileCoord_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cell");

        /// <summary>
        /// <para>Returns the tile index of the given cell. If no tile exists in the cell, returns <see cref="Godot.TileMap.InvalidCell"/>.</para>
        /// </summary>
        [GodotMethod("get_cell")]
        public int GetCell(int x, int y)
        {
            return NativeCalls.godot_icall_2_60(method_bind_48, Object.GetPtr(this), x, y);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cellv");

        /// <summary>
        /// <para>Returns the tile index of the cell given by a Vector2. If no tile exists in the cell, returns <see cref="Godot.TileMap.InvalidCell"/>.</para>
        /// </summary>
        [GodotMethod("get_cellv")]
        public int GetCellv(Vector2 position)
        {
            return NativeCalls.godot_icall_1_914(method_bind_49, Object.GetPtr(this), ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_cell_x_flipped");

        /// <summary>
        /// <para>Returns <c>true</c> if the given cell is flipped in the X axis.</para>
        /// </summary>
        [GodotMethod("is_cell_x_flipped")]
        public bool IsCellXFlipped(int x, int y)
        {
            return NativeCalls.godot_icall_2_177(method_bind_50, Object.GetPtr(this), x, y);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_cell_y_flipped");

        /// <summary>
        /// <para>Returns <c>true</c> if the given cell is flipped in the Y axis.</para>
        /// </summary>
        [GodotMethod("is_cell_y_flipped")]
        public bool IsCellYFlipped(int x, int y)
        {
            return NativeCalls.godot_icall_2_177(method_bind_51, Object.GetPtr(this), x, y);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_cell_transposed");

        /// <summary>
        /// <para>Returns <c>true</c> if the given cell is transposed, i.e. the X and Y axes are swapped.</para>
        /// </summary>
        [GodotMethod("is_cell_transposed")]
        public bool IsCellTransposed(int x, int y)
        {
            return NativeCalls.godot_icall_2_177(method_bind_52, Object.GetPtr(this), x, y);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_53 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cell_autotile_coord");

        /// <summary>
        /// <para>Returns the coordinate (subtile column and row) of the autotile variation in the tileset. Returns a zero vector if the cell doesn't have autotiling.</para>
        /// </summary>
        [GodotMethod("get_cell_autotile_coord")]
        public Vector2 GetCellAutotileCoord(int x, int y)
        {
            NativeCalls.godot_icall_2_82(method_bind_53, Object.GetPtr(this), x, y, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_54 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "fix_invalid_tiles");

        /// <summary>
        /// <para>Clears cells that do not exist in the tileset.</para>
        /// </summary>
        [GodotMethod("fix_invalid_tiles")]
        public void FixInvalidTiles()
        {
            NativeCalls.godot_icall_0_3(method_bind_54, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_55 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Clears all cells.</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_55, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_56 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_used_cells");

        /// <summary>
        /// <para>Returns a <see cref="Godot.Vector2"/> array with the positions of all cells containing a tile from the tileset (i.e. a tile index different from <c>-1</c>).</para>
        /// </summary>
        [GodotMethod("get_used_cells")]
        public Godot.Collections.Array GetUsedCells()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_56, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_57 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_used_cells_by_id");

        /// <summary>
        /// <para>Returns an array of all cells with the given tile index specified in <c>id</c>.</para>
        /// </summary>
        [GodotMethod("get_used_cells_by_id")]
        public Godot.Collections.Array GetUsedCellsById(int id)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_1_483(method_bind_57, Object.GetPtr(this), id));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_58 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_used_rect");

        /// <summary>
        /// <para>Returns a rectangle enclosing the used (non-empty) tiles of the map.</para>
        /// </summary>
        [GodotMethod("get_used_rect")]
        public Rect2 GetUsedRect()
        {
            NativeCalls.godot_icall_0_163(method_bind_58, Object.GetPtr(this), out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_59 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "map_to_world");

        /// <summary>
        /// <para>Returns the local position of the top left corner of the cell corresponding to the given tilemap (grid-based) coordinates.</para>
        /// <para>To get the global position, use <see cref="Godot.Node2D.ToGlobal"/>:</para>
        /// <para><code>
        /// var local_position = my_tilemap.map_to_world(map_position)
        /// var global_position = my_tilemap.to_global(local_position)
        /// </code></para>
        /// <para>Optionally, the tilemap's half offset can be ignored.</para>
        /// </summary>
        [GodotMethod("map_to_world")]
        public Vector2 MapToWorld(Vector2 mapPosition, bool ignoreHalfOfs = false)
        {
            NativeCalls.godot_icall_2_946(method_bind_59, Object.GetPtr(this), ref mapPosition, ignoreHalfOfs, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_60 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "world_to_map");

        /// <summary>
        /// <para>Returns the tilemap (grid-based) coordinates corresponding to the given local position.</para>
        /// <para>To use this with a global position, first determine the local position with <see cref="Godot.Node2D.ToLocal"/>:</para>
        /// <para><code>
        /// var local_position = my_tilemap.to_local(global_position)
        /// var map_position = my_tilemap.world_to_map(local_position)
        /// </code></para>
        /// </summary>
        [GodotMethod("world_to_map")]
        public Vector2 WorldToMap(Vector2 worldPosition)
        {
            NativeCalls.godot_icall_1_47(method_bind_60, Object.GetPtr(this), ref worldPosition, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_61 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "update_dirty_quadrants");

        /// <summary>
        /// <para>Updates the tile map's quadrants, allowing things such as navigation and collision shapes to be immediately used if modified.</para>
        /// </summary>
        [GodotMethod("update_dirty_quadrants")]
        public void UpdateDirtyQuadrants()
        {
            NativeCalls.godot_icall_0_3(method_bind_61, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_62 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "update_bitmask_area");

        /// <summary>
        /// <para>Applies autotiling rules to the cell (and its adjacent cells) referenced by its grid-based X and Y coordinates.</para>
        /// </summary>
        [GodotMethod("update_bitmask_area")]
        public void UpdateBitmaskArea(Vector2 position)
        {
            NativeCalls.godot_icall_1_57(method_bind_62, Object.GetPtr(this), ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_63 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "update_bitmask_region");

        /// <summary>
        /// <para>Applies autotiling rules to the cells in the given region (specified by grid-based X and Y coordinates).</para>
        /// <para>Calling with invalid (or missing) parameters applies autotiling rules for the entire tilemap.</para>
        /// </summary>
        /// <param name="start">If the parameter is null, then the default value is new Vector2(0, 0)</param>
        /// <param name="end">If the parameter is null, then the default value is new Vector2(0, 0)</param>
        [GodotMethod("update_bitmask_region")]
        public void UpdateBitmaskRegion(Nullable<Vector2> start = null, Nullable<Vector2> end = null)
        {
            Vector2 start_in = start.HasValue ? start.Value : new Vector2(0, 0);
            Vector2 end_in = end.HasValue ? end.Value : new Vector2(0, 0);
            NativeCalls.godot_icall_2_731(method_bind_63, Object.GetPtr(this), ref start_in, ref end_in);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
