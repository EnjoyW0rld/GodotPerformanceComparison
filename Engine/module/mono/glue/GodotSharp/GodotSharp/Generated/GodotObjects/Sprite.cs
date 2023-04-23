using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A node that displays a 2D texture. The texture displayed can be a region from a larger atlas texture, or a frame from a sprite sheet animation.</para>
    /// </summary>
    public partial class Sprite : Node2D
    {
        /// <summary>
        /// <para><see cref="Godot.Texture"/> object to draw.</para>
        /// </summary>
        public Texture Texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexture();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexture(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The normal map gives depth to the Sprite.</para>
        /// <para>Note: Godot expects the normal map to use X+, Y-, and Z+ coordinates. See <a href="http://wiki.polycount.com/wiki/Normal_Map_Technical_Details#Common_Swizzle_Coordinates">this page</a> for a comparison of normal map coordinates expected by popular engines.</para>
        /// </summary>
        public Texture NormalMap
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNormalMap();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetNormalMap(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, texture is centered.</para>
        /// </summary>
        public bool Centered
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsCentered();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCentered(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The texture's drawing offset.</para>
        /// </summary>
        public Vector2 Offset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, texture is flipped horizontally.</para>
        /// </summary>
        public bool FlipH
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsFlippedH();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlipH(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, texture is flipped vertically.</para>
        /// </summary>
        public bool FlipV
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsFlippedV();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlipV(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The number of columns in the sprite sheet.</para>
        /// </summary>
        public int Hframes
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHframes();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHframes(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The number of rows in the sprite sheet.</para>
        /// </summary>
        public int Vframes
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVframes();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVframes(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Current frame to display from sprite sheet. <see cref="Godot.Sprite.Hframes"/> or <see cref="Godot.Sprite.Vframes"/> must be greater than 1.</para>
        /// </summary>
        public int Frame
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrame();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrame(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Coordinates of the frame to display from sprite sheet. This is as an alias for the <see cref="Godot.Sprite.Frame"/> property. <see cref="Godot.Sprite.Hframes"/> or <see cref="Godot.Sprite.Vframes"/> must be greater than 1.</para>
        /// </summary>
        public Vector2 FrameCoords
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameCoords();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameCoords(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, texture is cut from a larger atlas texture. See <see cref="Godot.Sprite.RegionRect"/>.</para>
        /// </summary>
        public bool RegionEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsRegion();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRegion(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The region of the atlas texture to display. <see cref="Godot.Sprite.RegionEnabled"/> must be <c>true</c>.</para>
        /// </summary>
        public Rect2 RegionRect
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRegionRect();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRegionRect(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the outermost pixels get blurred out.</para>
        /// </summary>
        public bool RegionFilterClip
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsRegionFilterClipEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRegionFilterClip(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Sprite";

        public Sprite() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Sprite_Ctor(this);
        }

        internal Sprite(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture");

        [GodotMethod("set_texture")]
        [Obsolete("SetTexture is deprecated. Use the Texture property instead.")]
        public void SetTexture(Texture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture");

        [GodotMethod("get_texture")]
        [Obsolete("GetTexture is deprecated. Use the Texture property instead.")]
        public Texture GetTexture()
        {
            return NativeCalls.godot_icall_0_161(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_normal_map");

        [GodotMethod("set_normal_map")]
        [Obsolete("SetNormalMap is deprecated. Use the NormalMap property instead.")]
        public void SetNormalMap(Texture normalMap)
        {
            NativeCalls.godot_icall_1_24(method_bind_2, Object.GetPtr(this), Object.GetPtr(normalMap));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_normal_map");

        [GodotMethod("get_normal_map")]
        [Obsolete("GetNormalMap is deprecated. Use the NormalMap property instead.")]
        public Texture GetNormalMap()
        {
            return NativeCalls.godot_icall_0_161(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_centered");

        [GodotMethod("set_centered")]
        [Obsolete("SetCentered is deprecated. Use the Centered property instead.")]
        public void SetCentered(bool centered)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), centered);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_centered");

        [GodotMethod("is_centered")]
        [Obsolete("IsCentered is deprecated. Use the Centered property instead.")]
        public bool IsCentered()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_offset");

        [GodotMethod("set_offset")]
        [Obsolete("SetOffset is deprecated. Use the Offset property instead.")]
        public void SetOffset(Vector2 offset)
        {
            NativeCalls.godot_icall_1_57(method_bind_6, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_offset");

        [GodotMethod("get_offset")]
        [Obsolete("GetOffset is deprecated. Use the Offset property instead.")]
        public Vector2 GetOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_7, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flip_h");

        [GodotMethod("set_flip_h")]
        [Obsolete("SetFlipH is deprecated. Use the FlipH property instead.")]
        public void SetFlipH(bool flipH)
        {
            NativeCalls.godot_icall_1_16(method_bind_8, Object.GetPtr(this), flipH);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_flipped_h");

        [GodotMethod("is_flipped_h")]
        [Obsolete("IsFlippedH is deprecated. Use the FlipH property instead.")]
        public bool IsFlippedH()
        {
            return NativeCalls.godot_icall_0_7(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flip_v");

        [GodotMethod("set_flip_v")]
        [Obsolete("SetFlipV is deprecated. Use the FlipV property instead.")]
        public void SetFlipV(bool flipV)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), flipV);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_flipped_v");

        [GodotMethod("is_flipped_v")]
        [Obsolete("IsFlippedV is deprecated. Use the FlipV property instead.")]
        public bool IsFlippedV()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_region");

        [GodotMethod("set_region")]
        [Obsolete("SetRegion is deprecated. Use the RegionEnabled property instead.")]
        public void SetRegion(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_12, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_region");

        [GodotMethod("is_region")]
        [Obsolete("IsRegion is deprecated. Use the RegionEnabled property instead.")]
        public bool IsRegion()
        {
            return NativeCalls.godot_icall_0_7(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_pixel_opaque");

        /// <summary>
        /// <para>Returns <c>true</c>, if the pixel at the given position is opaque and <c>false</c> in other case.</para>
        /// <para>Note: It also returns <c>false</c>, if the sprite's texture is <c>null</c> or if the given position is invalid.</para>
        /// </summary>
        [GodotMethod("is_pixel_opaque")]
        public bool IsPixelOpaque(Vector2 pos)
        {
            return NativeCalls.godot_icall_1_181(method_bind_14, Object.GetPtr(this), ref pos);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_region_rect");

        [GodotMethod("set_region_rect")]
        [Obsolete("SetRegionRect is deprecated. Use the RegionRect property instead.")]
        public void SetRegionRect(Rect2 rect)
        {
            NativeCalls.godot_icall_1_162(method_bind_15, Object.GetPtr(this), ref rect);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_region_rect");

        [GodotMethod("get_region_rect")]
        [Obsolete("GetRegionRect is deprecated. Use the RegionRect property instead.")]
        public Rect2 GetRegionRect()
        {
            NativeCalls.godot_icall_0_163(method_bind_16, Object.GetPtr(this), out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_region_filter_clip");

        [GodotMethod("set_region_filter_clip")]
        [Obsolete("SetRegionFilterClip is deprecated. Use the RegionFilterClip property instead.")]
        public void SetRegionFilterClip(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_17, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_region_filter_clip_enabled");

        [GodotMethod("is_region_filter_clip_enabled")]
        [Obsolete("IsRegionFilterClipEnabled is deprecated. Use the RegionFilterClip property instead.")]
        public bool IsRegionFilterClipEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_frame");

        [GodotMethod("set_frame")]
        [Obsolete("SetFrame is deprecated. Use the Frame property instead.")]
        public void SetFrame(int frame)
        {
            NativeCalls.godot_icall_1_4(method_bind_19, Object.GetPtr(this), frame);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_frame");

        [GodotMethod("get_frame")]
        [Obsolete("GetFrame is deprecated. Use the Frame property instead.")]
        public int GetFrame()
        {
            return NativeCalls.godot_icall_0_5(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_frame_coords");

        [GodotMethod("set_frame_coords")]
        [Obsolete("SetFrameCoords is deprecated. Use the FrameCoords property instead.")]
        public void SetFrameCoords(Vector2 coords)
        {
            NativeCalls.godot_icall_1_57(method_bind_21, Object.GetPtr(this), ref coords);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_frame_coords");

        [GodotMethod("get_frame_coords")]
        [Obsolete("GetFrameCoords is deprecated. Use the FrameCoords property instead.")]
        public Vector2 GetFrameCoords()
        {
            NativeCalls.godot_icall_0_18(method_bind_22, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_vframes");

        [GodotMethod("set_vframes")]
        [Obsolete("SetVframes is deprecated. Use the Vframes property instead.")]
        public void SetVframes(int vframes)
        {
            NativeCalls.godot_icall_1_4(method_bind_23, Object.GetPtr(this), vframes);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_vframes");

        [GodotMethod("get_vframes")]
        [Obsolete("GetVframes is deprecated. Use the Vframes property instead.")]
        public int GetVframes()
        {
            return NativeCalls.godot_icall_0_5(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_hframes");

        [GodotMethod("set_hframes")]
        [Obsolete("SetHframes is deprecated. Use the Hframes property instead.")]
        public void SetHframes(int hframes)
        {
            NativeCalls.godot_icall_1_4(method_bind_25, Object.GetPtr(this), hframes);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_hframes");

        [GodotMethod("get_hframes")]
        [Obsolete("GetHframes is deprecated. Use the Hframes property instead.")]
        public int GetHframes()
        {
            return NativeCalls.godot_icall_0_5(method_bind_26, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rect");

        /// <summary>
        /// <para>Returns a <see cref="Godot.Rect2"/> representing the Sprite's boundary in local coordinates. Can be used to detect if the Sprite was clicked. Example:</para>
        /// <para><code>
        /// func _input(event):
        ///     if event is InputEventMouseButton and event.pressed and event.button_index == BUTTON_LEFT:
        ///         if get_rect().has_point(to_local(event.position)):
        ///             print("A click!")
        /// </code></para>
        /// </summary>
        [GodotMethod("get_rect")]
        public Rect2 GetRect()
        {
            NativeCalls.godot_icall_0_163(method_bind_27, Object.GetPtr(this), out Rect2 argRet); return (Rect2)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
