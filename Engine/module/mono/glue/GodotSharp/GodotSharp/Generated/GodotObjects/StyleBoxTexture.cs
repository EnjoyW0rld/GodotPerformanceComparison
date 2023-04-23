using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Texture-based nine-patch <see cref="Godot.StyleBox"/>, in a way similar to <see cref="Godot.NinePatchRect"/>. This stylebox performs a 3×3 scaling of a texture, where only the center cell is fully stretched. This makes it possible to design bordered styles regardless of the stylebox's size.</para>
    /// </summary>
    public partial class StyleBoxTexture : StyleBox
    {
        public enum AxisStretchMode
        {
            /// <summary>
            /// <para>Stretch the stylebox's texture. This results in visible distortion unless the texture size matches the stylebox's size perfectly.</para>
            /// </summary>
            Stretch = 0,
            /// <summary>
            /// <para>Repeats the stylebox's texture to match the stylebox's size according to the nine-patch system.</para>
            /// </summary>
            Tile = 1,
            /// <summary>
            /// <para>Repeats the stylebox's texture to match the stylebox's size according to the nine-patch system. Unlike <see cref="Godot.StyleBoxTexture.AxisStretchMode.Tile"/>, the texture may be slightly stretched to make the nine-patch texture tile seamlessly.</para>
            /// </summary>
            TileFit = 2
        }

        /// <summary>
        /// <para>The texture to use when drawing this style box.</para>
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
        /// <para>The normal map to use when drawing this style box.</para>
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
        /// <para>Species a sub-region of the texture to use.</para>
        /// <para>This is equivalent to first wrapping the texture in an <see cref="Godot.AtlasTexture"/> with the same region.</para>
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
        /// <para>Increases the left margin of the 3×3 texture box.</para>
        /// <para>A higher value means more of the source texture is considered to be part of the left border of the 3×3 box.</para>
        /// <para>This is also the value used as fallback for <see cref="Godot.StyleBox.ContentMarginLeft"/> if it is negative.</para>
        /// </summary>
        public float MarginLeft
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMarginSize((Margin)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMarginSize((Margin)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Increases the right margin of the 3×3 texture box.</para>
        /// <para>A higher value means more of the source texture is considered to be part of the right border of the 3×3 box.</para>
        /// <para>This is also the value used as fallback for <see cref="Godot.StyleBox.ContentMarginRight"/> if it is negative.</para>
        /// </summary>
        public float MarginRight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMarginSize((Margin)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMarginSize((Margin)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Increases the top margin of the 3×3 texture box.</para>
        /// <para>A higher value means more of the source texture is considered to be part of the top border of the 3×3 box.</para>
        /// <para>This is also the value used as fallback for <see cref="Godot.StyleBox.ContentMarginTop"/> if it is negative.</para>
        /// </summary>
        public float MarginTop
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMarginSize((Margin)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMarginSize((Margin)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Increases the bottom margin of the 3×3 texture box.</para>
        /// <para>A higher value means more of the source texture is considered to be part of the bottom border of the 3×3 box.</para>
        /// <para>This is also the value used as fallback for <see cref="Godot.StyleBox.ContentMarginBottom"/> if it is negative.</para>
        /// </summary>
        public float MarginBottom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMarginSize((Margin)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMarginSize((Margin)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Expands the left margin of this style box when drawing, causing it to be drawn larger than requested.</para>
        /// </summary>
        public float ExpandMarginLeft
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetExpandMarginSize((Margin)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExpandMarginSize((Margin)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Expands the right margin of this style box when drawing, causing it to be drawn larger than requested.</para>
        /// </summary>
        public float ExpandMarginRight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetExpandMarginSize((Margin)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExpandMarginSize((Margin)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Expands the top margin of this style box when drawing, causing it to be drawn larger than requested.</para>
        /// </summary>
        public float ExpandMarginTop
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetExpandMarginSize((Margin)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExpandMarginSize((Margin)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Expands the bottom margin of this style box when drawing, causing it to be drawn larger than requested.</para>
        /// </summary>
        public float ExpandMarginBottom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetExpandMarginSize((Margin)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExpandMarginSize((Margin)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Controls how the stylebox's texture will be stretched or tiled horizontally. See <see cref="Godot.StyleBoxTexture.AxisStretchMode"/> for possible values.</para>
        /// </summary>
        public StyleBoxTexture.AxisStretchMode AxisStretchHorizontal
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHAxisStretchMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHAxisStretchMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Controls how the stylebox's texture will be stretched or tiled vertically. See <see cref="Godot.StyleBoxTexture.AxisStretchMode"/> for possible values.</para>
        /// </summary>
        public StyleBoxTexture.AxisStretchMode AxisStretchVertical
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVAxisStretchMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVAxisStretchMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Modulates the color of the texture when this style box is drawn.</para>
        /// </summary>
        public Color ModulateColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetModulate();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetModulate(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the nine-patch texture's center tile will be drawn.</para>
        /// </summary>
        public bool DrawCenter
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDrawCenterEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDrawCenter(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "StyleBoxTexture";

        public StyleBoxTexture() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_StyleBoxTexture_Ctor(this);
        }

        internal StyleBoxTexture(bool memoryOwn) : base(memoryOwn) {}

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
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_margin_size");

        /// <summary>
        /// <para>Sets the margin to <c>size</c> pixels for the given <c>margin</c>. See <see cref="Godot.Margin"/> for possible values.</para>
        /// </summary>
        [GodotMethod("set_margin_size")]
        [Obsolete("SetMarginSize is deprecated. Use the MarginBottom property instead.")]
        public void SetMarginSize(Margin margin, float size)
        {
            NativeCalls.godot_icall_2_34(method_bind_4, Object.GetPtr(this), (int)margin, size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_margin_size");

        /// <summary>
        /// <para>Returns the size of the given <c>margin</c>. See <see cref="Godot.Margin"/> for possible values.</para>
        /// </summary>
        [GodotMethod("get_margin_size")]
        [Obsolete("GetMarginSize is deprecated. Use the MarginBottom property instead.")]
        public float GetMarginSize(Margin margin)
        {
            return NativeCalls.godot_icall_1_12(method_bind_5, Object.GetPtr(this), (int)margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_expand_margin_size");

        /// <summary>
        /// <para>Sets the expand margin to <c>size</c> pixels for the given <c>margin</c>. See <see cref="Godot.Margin"/> for possible values.</para>
        /// </summary>
        [GodotMethod("set_expand_margin_size")]
        [Obsolete("SetExpandMarginSize is deprecated. Use the ExpandMarginBottom property instead.")]
        public void SetExpandMarginSize(Margin margin, float size)
        {
            NativeCalls.godot_icall_2_34(method_bind_6, Object.GetPtr(this), (int)margin, size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_expand_margin_all");

        /// <summary>
        /// <para>Sets the expand margin to <c>size</c> pixels for all margins.</para>
        /// </summary>
        [GodotMethod("set_expand_margin_all")]
        public void SetExpandMarginAll(float size)
        {
            NativeCalls.godot_icall_1_15(method_bind_7, Object.GetPtr(this), size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_expand_margin_individual");

        /// <summary>
        /// <para>Sets the expand margin for each margin to <c>size_left</c>, <c>size_top</c>, <c>size_right</c>, and <c>size_bottom</c> pixels.</para>
        /// </summary>
        [GodotMethod("set_expand_margin_individual")]
        public void SetExpandMarginIndividual(float sizeLeft, float sizeTop, float sizeRight, float sizeBottom)
        {
            NativeCalls.godot_icall_4_903(method_bind_8, Object.GetPtr(this), sizeLeft, sizeTop, sizeRight, sizeBottom);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_expand_margin_size");

        /// <summary>
        /// <para>Returns the size of the given <c>margin</c>'s expand margin. See <see cref="Godot.Margin"/> for possible values.</para>
        /// </summary>
        [GodotMethod("get_expand_margin_size")]
        [Obsolete("GetExpandMarginSize is deprecated. Use the ExpandMarginBottom property instead.")]
        public float GetExpandMarginSize(Margin margin)
        {
            return NativeCalls.godot_icall_1_12(method_bind_9, Object.GetPtr(this), (int)margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_region_rect");

        [GodotMethod("set_region_rect")]
        [Obsolete("SetRegionRect is deprecated. Use the RegionRect property instead.")]
        public void SetRegionRect(Rect2 region)
        {
            NativeCalls.godot_icall_1_162(method_bind_10, Object.GetPtr(this), ref region);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_region_rect");

        [GodotMethod("get_region_rect")]
        [Obsolete("GetRegionRect is deprecated. Use the RegionRect property instead.")]
        public Rect2 GetRegionRect()
        {
            NativeCalls.godot_icall_0_163(method_bind_11, Object.GetPtr(this), out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_draw_center");

        [GodotMethod("set_draw_center")]
        [Obsolete("SetDrawCenter is deprecated. Use the DrawCenter property instead.")]
        public void SetDrawCenter(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_12, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_draw_center_enabled");

        [GodotMethod("is_draw_center_enabled")]
        [Obsolete("IsDrawCenterEnabled is deprecated. Use the DrawCenter property instead.")]
        public bool IsDrawCenterEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_modulate");

        [GodotMethod("set_modulate")]
        [Obsolete("SetModulate is deprecated. Use the ModulateColor property instead.")]
        public void SetModulate(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_14, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_modulate");

        [GodotMethod("get_modulate")]
        [Obsolete("GetModulate is deprecated. Use the ModulateColor property instead.")]
        public Color GetModulate()
        {
            NativeCalls.godot_icall_0_200(method_bind_15, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_h_axis_stretch_mode");

        [GodotMethod("set_h_axis_stretch_mode")]
        [Obsolete("SetHAxisStretchMode is deprecated. Use the AxisStretchHorizontal property instead.")]
        public void SetHAxisStretchMode(StyleBoxTexture.AxisStretchMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_16, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_h_axis_stretch_mode");

        [GodotMethod("get_h_axis_stretch_mode")]
        [Obsolete("GetHAxisStretchMode is deprecated. Use the AxisStretchHorizontal property instead.")]
        public StyleBoxTexture.AxisStretchMode GetHAxisStretchMode()
        {
            return (StyleBoxTexture.AxisStretchMode)NativeCalls.godot_icall_0_904(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_v_axis_stretch_mode");

        [GodotMethod("set_v_axis_stretch_mode")]
        [Obsolete("SetVAxisStretchMode is deprecated. Use the AxisStretchVertical property instead.")]
        public void SetVAxisStretchMode(StyleBoxTexture.AxisStretchMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_18, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_v_axis_stretch_mode");

        [GodotMethod("get_v_axis_stretch_mode")]
        [Obsolete("GetVAxisStretchMode is deprecated. Use the AxisStretchVertical property instead.")]
        public StyleBoxTexture.AxisStretchMode GetVAxisStretchMode()
        {
            return (StyleBoxTexture.AxisStretchMode)NativeCalls.godot_icall_0_904(method_bind_19, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
