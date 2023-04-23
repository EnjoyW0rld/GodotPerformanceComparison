using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>TextureProgress works like <see cref="Godot.ProgressBar"/>, but uses up to 3 textures instead of Godot's <see cref="Godot.Theme"/> resource. It can be used to create horizontal, vertical and radial progress bars.</para>
    /// </summary>
    public partial class TextureProgress : Range
    {
        public enum FillModeEnum
        {
            /// <summary>
            /// <para>The <see cref="Godot.TextureProgress.TextureProgress_"/> fills from left to right.</para>
            /// </summary>
            LeftToRight = 0,
            /// <summary>
            /// <para>The <see cref="Godot.TextureProgress.TextureProgress_"/> fills from right to left.</para>
            /// </summary>
            RightToLeft = 1,
            /// <summary>
            /// <para>The <see cref="Godot.TextureProgress.TextureProgress_"/> fills from top to bottom.</para>
            /// </summary>
            TopToBottom = 2,
            /// <summary>
            /// <para>The <see cref="Godot.TextureProgress.TextureProgress_"/> fills from bottom to top.</para>
            /// </summary>
            BottomToTop = 3,
            /// <summary>
            /// <para>Turns the node into a radial bar. The <see cref="Godot.TextureProgress.TextureProgress_"/> fills clockwise. See <see cref="Godot.TextureProgress.RadialCenterOffset"/>, <see cref="Godot.TextureProgress.RadialInitialAngle"/> and <see cref="Godot.TextureProgress.RadialFillDegrees"/> to control the way the bar fills up.</para>
            /// </summary>
            Clockwise = 4,
            /// <summary>
            /// <para>Turns the node into a radial bar. The <see cref="Godot.TextureProgress.TextureProgress_"/> fills counterclockwise. See <see cref="Godot.TextureProgress.RadialCenterOffset"/>, <see cref="Godot.TextureProgress.RadialInitialAngle"/> and <see cref="Godot.TextureProgress.RadialFillDegrees"/> to control the way the bar fills up.</para>
            /// </summary>
            CounterClockwise = 5,
            /// <summary>
            /// <para>The <see cref="Godot.TextureProgress.TextureProgress_"/> fills from the center, expanding both towards the left and the right.</para>
            /// </summary>
            BilinearLeftAndRight = 6,
            /// <summary>
            /// <para>The <see cref="Godot.TextureProgress.TextureProgress_"/> fills from the center, expanding both towards the top and the bottom.</para>
            /// </summary>
            BilinearTopAndBottom = 7,
            /// <summary>
            /// <para>Turns the node into a radial bar. The <see cref="Godot.TextureProgress.TextureProgress_"/> fills radially from the center, expanding both clockwise and counterclockwise. See <see cref="Godot.TextureProgress.RadialCenterOffset"/>, <see cref="Godot.TextureProgress.RadialInitialAngle"/> and <see cref="Godot.TextureProgress.RadialFillDegrees"/> to control the way the bar fills up.</para>
            /// </summary>
            ClockwiseAndCounterClockwise = 8
        }

        /// <summary>
        /// <para><see cref="Godot.Texture"/> that draws under the progress bar. The bar's background.</para>
        /// </summary>
        public Texture TextureUnder
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUnderTexture();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUnderTexture(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para><see cref="Godot.Texture"/> that draws over the progress bar. Use it to add highlights or an upper-frame that hides part of <see cref="Godot.TextureProgress.TextureProgress_"/>.</para>
        /// </summary>
        public Texture TextureOver
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOverTexture();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOverTexture(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para><see cref="Godot.Texture"/> that clips based on the node's <c>value</c> and <see cref="Godot.TextureProgress.FillMode"/>. As <c>value</c> increased, the texture fills up. It shows entirely when <c>value</c> reaches <c>max_value</c>. It doesn't show at all if <c>value</c> is equal to <c>min_value</c>.</para>
        /// <para>The <c>value</c> property comes from <see cref="Godot.Range"/>. See <see cref="Godot.Range.Value"/>, <see cref="Godot.Range.MinValue"/>, <see cref="Godot.Range.MaxValue"/>.</para>
        /// </summary>
        public Texture TextureProgress_
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetProgressTexture();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetProgressTexture(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The offset of <see cref="Godot.TextureProgress.TextureProgress_"/>. Useful for <see cref="Godot.TextureProgress.TextureOver"/> and <see cref="Godot.TextureProgress.TextureUnder"/> with fancy borders, to avoid transparent margins in your progress texture.</para>
        /// </summary>
        public Vector2 TextureProgressOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTextureProgressOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTextureProgressOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The fill direction. See <see cref="Godot.TextureProgress.FillModeEnum"/> for possible values.</para>
        /// </summary>
        public int FillMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFillMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFillMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Multiplies the color of the bar's <c>texture_under</c> texture.</para>
        /// </summary>
        public Color TintUnder
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTintUnder();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTintUnder(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Multiplies the color of the bar's <c>texture_over</c> texture. The effect is similar to <see cref="Godot.CanvasItem.Modulate"/>, except it only affects this specific texture instead of the entire node.</para>
        /// </summary>
        public Color TintOver
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTintOver();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTintOver(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Multiplies the color of the bar's <c>texture_progress</c> texture.</para>
        /// </summary>
        public Color TintProgress
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTintProgress();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTintProgress(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Starting angle for the fill of <see cref="Godot.TextureProgress.TextureProgress_"/> if <see cref="Godot.TextureProgress.FillMode"/> is <see cref="Godot.TextureProgress.FillModeEnum.Clockwise"/> or <see cref="Godot.TextureProgress.FillModeEnum.CounterClockwise"/>. When the node's <c>value</c> is equal to its <c>min_value</c>, the texture doesn't show up at all. When the <c>value</c> increases, the texture fills and tends towards <see cref="Godot.TextureProgress.RadialFillDegrees"/>.</para>
        /// </summary>
        public float RadialInitialAngle
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRadialInitialAngle();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRadialInitialAngle(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Upper limit for the fill of <see cref="Godot.TextureProgress.TextureProgress_"/> if <see cref="Godot.TextureProgress.FillMode"/> is <see cref="Godot.TextureProgress.FillModeEnum.Clockwise"/> or <see cref="Godot.TextureProgress.FillModeEnum.CounterClockwise"/>. When the node's <c>value</c> is equal to its <c>max_value</c>, the texture fills up to this angle.</para>
        /// <para>See <see cref="Godot.Range.Value"/>, <see cref="Godot.Range.MaxValue"/>.</para>
        /// </summary>
        public float RadialFillDegrees
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFillDegrees();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFillDegrees(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Offsets <see cref="Godot.TextureProgress.TextureProgress_"/> if <see cref="Godot.TextureProgress.FillMode"/> is <see cref="Godot.TextureProgress.FillModeEnum.Clockwise"/> or <see cref="Godot.TextureProgress.FillModeEnum.CounterClockwise"/>.</para>
        /// </summary>
        public Vector2 RadialCenterOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRadialCenterOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRadialCenterOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, Godot treats the bar's textures like in <see cref="Godot.NinePatchRect"/>. Use the <c>stretch_margin_*</c> properties like <see cref="Godot.TextureProgress.StretchMarginBottom"/> to set up the nine patch's 3×3 grid. When using a radial <see cref="Godot.TextureProgress.FillMode"/>, this setting will enable stretching.</para>
        /// </summary>
        public bool NinePatchStretch
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNinePatchStretch();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetNinePatchStretch(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The width of the 9-patch's left column.</para>
        /// </summary>
        public int StretchMarginLeft
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetStretchMargin((Margin)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetStretchMargin((Margin)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The height of the 9-patch's top row.</para>
        /// </summary>
        public int StretchMarginTop
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetStretchMargin((Margin)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetStretchMargin((Margin)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The width of the 9-patch's right column.</para>
        /// </summary>
        public int StretchMarginRight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetStretchMargin((Margin)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetStretchMargin((Margin)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The height of the 9-patch's bottom row. A margin of 16 means the 9-slice's bottom corners and side will have a height of 16 pixels. You can set all 4 margin values individually to create panels with non-uniform borders.</para>
        /// </summary>
        public int StretchMarginBottom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetStretchMargin((Margin)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetStretchMargin((Margin)3, value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "TextureProgress";

        public TextureProgress() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_TextureProgress_Ctor(this);
        }

        internal TextureProgress(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_under_texture");

        [GodotMethod("set_under_texture")]
        [Obsolete("SetUnderTexture is deprecated. Use the TextureUnder property instead.")]
        public void SetUnderTexture(Texture tex)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(tex));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_under_texture");

        [GodotMethod("get_under_texture")]
        [Obsolete("GetUnderTexture is deprecated. Use the TextureUnder property instead.")]
        public Texture GetUnderTexture()
        {
            return NativeCalls.godot_icall_0_161(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_progress_texture");

        [GodotMethod("set_progress_texture")]
        [Obsolete("SetProgressTexture is deprecated. Use the TextureProgress_ property instead.")]
        public void SetProgressTexture(Texture tex)
        {
            NativeCalls.godot_icall_1_24(method_bind_2, Object.GetPtr(this), Object.GetPtr(tex));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_progress_texture");

        [GodotMethod("get_progress_texture")]
        [Obsolete("GetProgressTexture is deprecated. Use the TextureProgress_ property instead.")]
        public Texture GetProgressTexture()
        {
            return NativeCalls.godot_icall_0_161(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_over_texture");

        [GodotMethod("set_over_texture")]
        [Obsolete("SetOverTexture is deprecated. Use the TextureOver property instead.")]
        public void SetOverTexture(Texture tex)
        {
            NativeCalls.godot_icall_1_24(method_bind_4, Object.GetPtr(this), Object.GetPtr(tex));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_over_texture");

        [GodotMethod("get_over_texture")]
        [Obsolete("GetOverTexture is deprecated. Use the TextureOver property instead.")]
        public Texture GetOverTexture()
        {
            return NativeCalls.godot_icall_0_161(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fill_mode");

        [GodotMethod("set_fill_mode")]
        [Obsolete("SetFillMode is deprecated. Use the FillMode property instead.")]
        public void SetFillMode(int mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fill_mode");

        [GodotMethod("get_fill_mode")]
        [Obsolete("GetFillMode is deprecated. Use the FillMode property instead.")]
        public int GetFillMode()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tint_under");

        [GodotMethod("set_tint_under")]
        [Obsolete("SetTintUnder is deprecated. Use the TintUnder property instead.")]
        public void SetTintUnder(Color tint)
        {
            NativeCalls.godot_icall_1_199(method_bind_8, Object.GetPtr(this), ref tint);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tint_under");

        [GodotMethod("get_tint_under")]
        [Obsolete("GetTintUnder is deprecated. Use the TintUnder property instead.")]
        public Color GetTintUnder()
        {
            NativeCalls.godot_icall_0_200(method_bind_9, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tint_progress");

        [GodotMethod("set_tint_progress")]
        [Obsolete("SetTintProgress is deprecated. Use the TintProgress property instead.")]
        public void SetTintProgress(Color tint)
        {
            NativeCalls.godot_icall_1_199(method_bind_10, Object.GetPtr(this), ref tint);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tint_progress");

        [GodotMethod("get_tint_progress")]
        [Obsolete("GetTintProgress is deprecated. Use the TintProgress property instead.")]
        public Color GetTintProgress()
        {
            NativeCalls.godot_icall_0_200(method_bind_11, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tint_over");

        [GodotMethod("set_tint_over")]
        [Obsolete("SetTintOver is deprecated. Use the TintOver property instead.")]
        public void SetTintOver(Color tint)
        {
            NativeCalls.godot_icall_1_199(method_bind_12, Object.GetPtr(this), ref tint);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tint_over");

        [GodotMethod("get_tint_over")]
        [Obsolete("GetTintOver is deprecated. Use the TintOver property instead.")]
        public Color GetTintOver()
        {
            NativeCalls.godot_icall_0_200(method_bind_13, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture_progress_offset");

        [GodotMethod("set_texture_progress_offset")]
        [Obsolete("SetTextureProgressOffset is deprecated. Use the TextureProgressOffset property instead.")]
        public void SetTextureProgressOffset(Vector2 offset)
        {
            NativeCalls.godot_icall_1_57(method_bind_14, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture_progress_offset");

        [GodotMethod("get_texture_progress_offset")]
        [Obsolete("GetTextureProgressOffset is deprecated. Use the TextureProgressOffset property instead.")]
        public Vector2 GetTextureProgressOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_15, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_radial_initial_angle");

        [GodotMethod("set_radial_initial_angle")]
        [Obsolete("SetRadialInitialAngle is deprecated. Use the RadialInitialAngle property instead.")]
        public void SetRadialInitialAngle(float mode)
        {
            NativeCalls.godot_icall_1_15(method_bind_16, Object.GetPtr(this), mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_radial_initial_angle");

        [GodotMethod("get_radial_initial_angle")]
        [Obsolete("GetRadialInitialAngle is deprecated. Use the RadialInitialAngle property instead.")]
        public float GetRadialInitialAngle()
        {
            return NativeCalls.godot_icall_0_14(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_radial_center_offset");

        [GodotMethod("set_radial_center_offset")]
        [Obsolete("SetRadialCenterOffset is deprecated. Use the RadialCenterOffset property instead.")]
        public void SetRadialCenterOffset(Vector2 mode)
        {
            NativeCalls.godot_icall_1_57(method_bind_18, Object.GetPtr(this), ref mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_radial_center_offset");

        [GodotMethod("get_radial_center_offset")]
        [Obsolete("GetRadialCenterOffset is deprecated. Use the RadialCenterOffset property instead.")]
        public Vector2 GetRadialCenterOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_19, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fill_degrees");

        [GodotMethod("set_fill_degrees")]
        [Obsolete("SetFillDegrees is deprecated. Use the RadialFillDegrees property instead.")]
        public void SetFillDegrees(float mode)
        {
            NativeCalls.godot_icall_1_15(method_bind_20, Object.GetPtr(this), mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fill_degrees");

        [GodotMethod("get_fill_degrees")]
        [Obsolete("GetFillDegrees is deprecated. Use the RadialFillDegrees property instead.")]
        public float GetFillDegrees()
        {
            return NativeCalls.godot_icall_0_14(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_stretch_margin");

        [GodotMethod("set_stretch_margin")]
        [Obsolete("SetStretchMargin is deprecated. Use the StretchMarginBottom property instead.")]
        public void SetStretchMargin(Margin margin, int value)
        {
            NativeCalls.godot_icall_2_65(method_bind_22, Object.GetPtr(this), (int)margin, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stretch_margin");

        [GodotMethod("get_stretch_margin")]
        [Obsolete("GetStretchMargin is deprecated. Use the StretchMarginBottom property instead.")]
        public int GetStretchMargin(Margin margin)
        {
            return NativeCalls.godot_icall_1_11(method_bind_23, Object.GetPtr(this), (int)margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_nine_patch_stretch");

        [GodotMethod("set_nine_patch_stretch")]
        [Obsolete("SetNinePatchStretch is deprecated. Use the NinePatchStretch property instead.")]
        public void SetNinePatchStretch(bool stretch)
        {
            NativeCalls.godot_icall_1_16(method_bind_24, Object.GetPtr(this), stretch);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_nine_patch_stretch");

        [GodotMethod("get_nine_patch_stretch")]
        [Obsolete("GetNinePatchStretch is deprecated. Use the NinePatchStretch property instead.")]
        public bool GetNinePatchStretch()
        {
            return NativeCalls.godot_icall_0_7(method_bind_25, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
