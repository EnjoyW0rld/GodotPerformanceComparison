using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Also known as 9-slice panels, NinePatchRect produces clean panels of any size, based on a small texture. To do so, it splits the texture in a 3×3 grid. When you scale the node, it tiles the texture's sides horizontally or vertically, the center on both axes but it doesn't scale or tile the corners.</para>
    /// </summary>
    public partial class NinePatchRect : Control
    {
        public enum AxisStretchMode
        {
            /// <summary>
            /// <para>Stretches the center texture across the NinePatchRect. This may cause the texture to be distorted.</para>
            /// </summary>
            Stretch = 0,
            /// <summary>
            /// <para>Repeats the center texture across the NinePatchRect. This won't cause any visible distortion. The texture must be seamless for this to work without displaying artifacts between edges.</para>
            /// <para>Note: Only supported when using the GLES3 renderer. When using the GLES2 renderer, this will behave like <see cref="Godot.NinePatchRect.AxisStretchMode.Stretch"/>.</para>
            /// </summary>
            Tile = 1,
            /// <summary>
            /// <para>Repeats the center texture across the NinePatchRect, but will also stretch the texture to make sure each tile is visible in full. This may cause the texture to be distorted, but less than <see cref="Godot.NinePatchRect.AxisStretchMode.Stretch"/>. The texture must be seamless for this to work without displaying artifacts between edges.</para>
            /// <para>Note: Only supported when using the GLES3 renderer. When using the GLES2 renderer, this will behave like <see cref="Godot.NinePatchRect.AxisStretchMode.Stretch"/>.</para>
            /// </summary>
            TileFit = 2
        }

        /// <summary>
        /// <para>The node's texture resource.</para>
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
        /// <para>If <c>true</c>, draw the panel's center. Else, only draw the 9-slice's borders.</para>
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

        /// <summary>
        /// <para>Rectangular region of the texture to sample from. If you're working with an atlas, use this property to define the area the 9-slice should use. All other properties are relative to this one. If the rect is empty, NinePatchRect will use the whole texture.</para>
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
        /// <para>The width of the 9-slice's left column. A margin of 16 means the 9-slice's left corners and side will have a width of 16 pixels. You can set all 4 margin values individually to create panels with non-uniform borders.</para>
        /// </summary>
        public int PatchMarginLeft
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPatchMargin((Margin)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPatchMargin((Margin)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The height of the 9-slice's top row. A margin of 16 means the 9-slice's top corners and side will have a height of 16 pixels. You can set all 4 margin values individually to create panels with non-uniform borders.</para>
        /// </summary>
        public int PatchMarginTop
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPatchMargin((Margin)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPatchMargin((Margin)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The width of the 9-slice's right column. A margin of 16 means the 9-slice's right corners and side will have a width of 16 pixels. You can set all 4 margin values individually to create panels with non-uniform borders.</para>
        /// </summary>
        public int PatchMarginRight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPatchMargin((Margin)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPatchMargin((Margin)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The height of the 9-slice's bottom row. A margin of 16 means the 9-slice's bottom corners and side will have a height of 16 pixels. You can set all 4 margin values individually to create panels with non-uniform borders.</para>
        /// </summary>
        public int PatchMarginBottom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPatchMargin((Margin)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPatchMargin((Margin)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The stretch mode to use for horizontal stretching/tiling. See <see cref="Godot.NinePatchRect.AxisStretchMode"/> for possible values.</para>
        /// </summary>
        public NinePatchRect.AxisStretchMode AxisStretchHorizontal
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
        /// <para>The stretch mode to use for vertical stretching/tiling. See <see cref="Godot.NinePatchRect.AxisStretchMode"/> for possible values.</para>
        /// </summary>
        public NinePatchRect.AxisStretchMode AxisStretchVertical
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

        private const string nativeName = "NinePatchRect";

        public NinePatchRect() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_NinePatchRect_Ctor(this);
        }

        internal NinePatchRect(bool memoryOwn) : base(memoryOwn) {}

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
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_patch_margin");

        /// <summary>
        /// <para>Sets the size of the margin identified by the given <see cref="Godot.Margin"/> constant to <c>value</c> in pixels.</para>
        /// </summary>
        [GodotMethod("set_patch_margin")]
        [Obsolete("SetPatchMargin is deprecated. Use the PatchMarginBottom property instead.")]
        public void SetPatchMargin(Margin margin, int value)
        {
            NativeCalls.godot_icall_2_65(method_bind_2, Object.GetPtr(this), (int)margin, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_patch_margin");

        /// <summary>
        /// <para>Returns the size of the margin identified by the given <see cref="Godot.Margin"/> constant.</para>
        /// </summary>
        [GodotMethod("get_patch_margin")]
        [Obsolete("GetPatchMargin is deprecated. Use the PatchMarginBottom property instead.")]
        public int GetPatchMargin(Margin margin)
        {
            return NativeCalls.godot_icall_1_11(method_bind_3, Object.GetPtr(this), (int)margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_region_rect");

        [GodotMethod("set_region_rect")]
        [Obsolete("SetRegionRect is deprecated. Use the RegionRect property instead.")]
        public void SetRegionRect(Rect2 rect)
        {
            NativeCalls.godot_icall_1_162(method_bind_4, Object.GetPtr(this), ref rect);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_region_rect");

        [GodotMethod("get_region_rect")]
        [Obsolete("GetRegionRect is deprecated. Use the RegionRect property instead.")]
        public Rect2 GetRegionRect()
        {
            NativeCalls.godot_icall_0_163(method_bind_5, Object.GetPtr(this), out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_draw_center");

        [GodotMethod("set_draw_center")]
        [Obsolete("SetDrawCenter is deprecated. Use the DrawCenter property instead.")]
        public void SetDrawCenter(bool drawCenter)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), drawCenter);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_draw_center_enabled");

        [GodotMethod("is_draw_center_enabled")]
        [Obsolete("IsDrawCenterEnabled is deprecated. Use the DrawCenter property instead.")]
        public bool IsDrawCenterEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_h_axis_stretch_mode");

        [GodotMethod("set_h_axis_stretch_mode")]
        [Obsolete("SetHAxisStretchMode is deprecated. Use the AxisStretchHorizontal property instead.")]
        public void SetHAxisStretchMode(NinePatchRect.AxisStretchMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_8, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_h_axis_stretch_mode");

        [GodotMethod("get_h_axis_stretch_mode")]
        [Obsolete("GetHAxisStretchMode is deprecated. Use the AxisStretchHorizontal property instead.")]
        public NinePatchRect.AxisStretchMode GetHAxisStretchMode()
        {
            return (NinePatchRect.AxisStretchMode)NativeCalls.godot_icall_0_671(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_v_axis_stretch_mode");

        [GodotMethod("set_v_axis_stretch_mode")]
        [Obsolete("SetVAxisStretchMode is deprecated. Use the AxisStretchVertical property instead.")]
        public void SetVAxisStretchMode(NinePatchRect.AxisStretchMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_10, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_v_axis_stretch_mode");

        [GodotMethod("get_v_axis_stretch_mode")]
        [Obsolete("GetVAxisStretchMode is deprecated. Use the AxisStretchVertical property instead.")]
        public NinePatchRect.AxisStretchMode GetVAxisStretchMode()
        {
            return (NinePatchRect.AxisStretchMode)NativeCalls.godot_icall_0_671(method_bind_11, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
