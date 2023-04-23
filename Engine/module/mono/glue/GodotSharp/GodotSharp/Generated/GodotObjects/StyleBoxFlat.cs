using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This <see cref="Godot.StyleBox"/> can be used to achieve all kinds of looks without the need of a texture. The following properties are customizable:</para>
    /// <para>- Color</para>
    /// <para>- Border width (individual width for each border)</para>
    /// <para>- Rounded corners (individual radius for each corner)</para>
    /// <para>- Shadow (with blur and offset)</para>
    /// <para>Setting corner radius to high values is allowed. As soon as corners overlap, the stylebox will switch to a relative system. Example:</para>
    /// <para><code>
    /// height = 30
    /// corner_radius_top_left = 50
    /// corner_radius_bottom_left = 100
    /// </code></para>
    /// <para>The relative system now would take the 1:2 ratio of the two left corners to calculate the actual corner width. Both corners added will never be more than the height. Result:</para>
    /// <para><code>
    /// corner_radius_top_left: 10
    /// corner_radius_bottom_left: 20
    /// </code></para>
    /// </summary>
    public partial class StyleBoxFlat : StyleBox
    {
        /// <summary>
        /// <para>The background color of the stylebox.</para>
        /// </summary>
        public Color BgColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBgColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBgColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Toggles drawing of the inner part of the stylebox.</para>
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
        /// <para>If set to a non-zero value on either axis, <see cref="Godot.StyleBoxFlat.Skew"/> distorts the StyleBox horizontally and/or vertically. This can be used for "futuristic"-style UIs. Positive values skew the StyleBox towards the right (X axis) and upwards (Y axis), while negative values skew the StyleBox towards the left (X axis) and downwards (Y axis).</para>
        /// <para>Note: To ensure text does not touch the StyleBox's edges, consider increasing the <see cref="Godot.StyleBox"/>'s content margin (see <see cref="Godot.StyleBox.ContentMarginBottom"/>). It is preferable to increase the content margin instead of the expand margin (see <see cref="Godot.StyleBoxFlat.ExpandMarginBottom"/>), as increasing the expand margin does not increase the size of the clickable area for <see cref="Godot.Control"/>s.</para>
        /// </summary>
        public Vector2 Skew
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSkew();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSkew(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Border width for the left border.</para>
        /// </summary>
        public int BorderWidthLeft
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBorderWidth((Margin)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBorderWidth((Margin)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Border width for the top border.</para>
        /// </summary>
        public int BorderWidthTop
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBorderWidth((Margin)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBorderWidth((Margin)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Border width for the right border.</para>
        /// </summary>
        public int BorderWidthRight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBorderWidth((Margin)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBorderWidth((Margin)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Border width for the bottom border.</para>
        /// </summary>
        public int BorderWidthBottom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBorderWidth((Margin)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBorderWidth((Margin)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the color of the border.</para>
        /// </summary>
        public Color BorderColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBorderColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBorderColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the border will fade into the background color.</para>
        /// </summary>
        public bool BorderBlend
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBorderBlend();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBorderBlend(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The top-left corner's radius. If <c>0</c>, the corner is not rounded.</para>
        /// </summary>
        public int CornerRadiusTopLeft
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCornerRadius((Corner)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCornerRadius((Corner)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The top-right corner's radius. If <c>0</c>, the corner is not rounded.</para>
        /// </summary>
        public int CornerRadiusTopRight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCornerRadius((Corner)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCornerRadius((Corner)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The bottom-right corner's radius. If <c>0</c>, the corner is not rounded.</para>
        /// </summary>
        public int CornerRadiusBottomRight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCornerRadius((Corner)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCornerRadius((Corner)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The bottom-left corner's radius. If <c>0</c>, the corner is not rounded.</para>
        /// </summary>
        public int CornerRadiusBottomLeft
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCornerRadius((Corner)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCornerRadius((Corner)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>This sets the number of vertices used for each corner. Higher values result in rounder corners but take more processing power to compute. When choosing a value, you should take the corner radius (<see cref="Godot.StyleBoxFlat.SetCornerRadiusAll"/>) into account.</para>
        /// <para>For corner radii less than 10, <c>4</c> or <c>5</c> should be enough. For corner radii less than 30, values between <c>8</c> and <c>12</c> should be enough.</para>
        /// <para>A corner detail of <c>1</c> will result in chamfered corners instead of rounded corners, which is useful for some artistic effects.</para>
        /// </summary>
        public int CornerDetail
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCornerDetail();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCornerDetail(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Expands the stylebox outside of the control rect on the left edge. Useful in combination with <see cref="Godot.StyleBoxFlat.BorderWidthLeft"/> to draw a border outside the control rect.</para>
        /// <para>Note: Unlike <see cref="Godot.StyleBox.ContentMarginLeft"/>, <see cref="Godot.StyleBoxFlat.ExpandMarginLeft"/> does not affect the size of the clickable area for <see cref="Godot.Control"/>s. This can negatively impact usability if used wrong, as the user may try to click an area of the StyleBox that cannot actually receive clicks.</para>
        /// </summary>
        public float ExpandMarginLeft
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetExpandMargin((Margin)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExpandMargin((Margin)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Expands the stylebox outside of the control rect on the right edge. Useful in combination with <see cref="Godot.StyleBoxFlat.BorderWidthRight"/> to draw a border outside the control rect.</para>
        /// <para>Note: Unlike <see cref="Godot.StyleBox.ContentMarginRight"/>, <see cref="Godot.StyleBoxFlat.ExpandMarginRight"/> does not affect the size of the clickable area for <see cref="Godot.Control"/>s. This can negatively impact usability if used wrong, as the user may try to click an area of the StyleBox that cannot actually receive clicks.</para>
        /// </summary>
        public float ExpandMarginRight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetExpandMargin((Margin)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExpandMargin((Margin)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Expands the stylebox outside of the control rect on the top edge. Useful in combination with <see cref="Godot.StyleBoxFlat.BorderWidthTop"/> to draw a border outside the control rect.</para>
        /// <para>Note: Unlike <see cref="Godot.StyleBox.ContentMarginTop"/>, <see cref="Godot.StyleBoxFlat.ExpandMarginTop"/> does not affect the size of the clickable area for <see cref="Godot.Control"/>s. This can negatively impact usability if used wrong, as the user may try to click an area of the StyleBox that cannot actually receive clicks.</para>
        /// </summary>
        public float ExpandMarginTop
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetExpandMargin((Margin)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExpandMargin((Margin)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Expands the stylebox outside of the control rect on the bottom edge. Useful in combination with <see cref="Godot.StyleBoxFlat.BorderWidthBottom"/> to draw a border outside the control rect.</para>
        /// <para>Note: Unlike <see cref="Godot.StyleBox.ContentMarginBottom"/>, <see cref="Godot.StyleBoxFlat.ExpandMarginBottom"/> does not affect the size of the clickable area for <see cref="Godot.Control"/>s. This can negatively impact usability if used wrong, as the user may try to click an area of the StyleBox that cannot actually receive clicks.</para>
        /// </summary>
        public float ExpandMarginBottom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetExpandMargin((Margin)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExpandMargin((Margin)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The color of the shadow. This has no effect if <see cref="Godot.StyleBoxFlat.ShadowSize"/> is lower than 1.</para>
        /// </summary>
        public Color ShadowColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShadowColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShadowColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The shadow size in pixels.</para>
        /// </summary>
        public int ShadowSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShadowSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShadowSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The shadow offset in pixels. Adjusts the position of the shadow relatively to the stylebox.</para>
        /// </summary>
        public Vector2 ShadowOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShadowOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShadowOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Antialiasing draws a small ring around the edges, which fades to transparency. As a result, edges look much smoother. This is only noticeable when using rounded corners or <see cref="Godot.StyleBoxFlat.Skew"/>.</para>
        /// <para>Note: When using beveled corners with 45-degree angles (<see cref="Godot.StyleBoxFlat.CornerDetail"/> = 1), it is recommended to set <see cref="Godot.StyleBoxFlat.AntiAliasing"/> to <c>false</c> to ensure crisp visuals and avoid possible visual glitches.</para>
        /// </summary>
        public bool AntiAliasing
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsAntiAliased();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAntiAliased(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>This changes the size of the faded ring. Higher values can be used to achieve a "blurry" effect.</para>
        /// </summary>
        public float AntiAliasingSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAaSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAaSize(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "StyleBoxFlat";

        public StyleBoxFlat() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_StyleBoxFlat_Ctor(this);
        }

        internal StyleBoxFlat(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bg_color");

        [GodotMethod("set_bg_color")]
        [Obsolete("SetBgColor is deprecated. Use the BgColor property instead.")]
        public void SetBgColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_0, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bg_color");

        [GodotMethod("get_bg_color")]
        [Obsolete("GetBgColor is deprecated. Use the BgColor property instead.")]
        public Color GetBgColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_1, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_border_color");

        [GodotMethod("set_border_color")]
        [Obsolete("SetBorderColor is deprecated. Use the BorderColor property instead.")]
        public void SetBorderColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_2, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_border_color");

        [GodotMethod("get_border_color")]
        [Obsolete("GetBorderColor is deprecated. Use the BorderColor property instead.")]
        public Color GetBorderColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_3, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_border_width_all");

        /// <summary>
        /// <para>Sets the border width to <c>width</c> pixels for all margins.</para>
        /// </summary>
        [GodotMethod("set_border_width_all")]
        public void SetBorderWidthAll(int width)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), width);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_border_width_min");

        /// <summary>
        /// <para>Returns the smallest border width out of all four borders.</para>
        /// </summary>
        [GodotMethod("get_border_width_min")]
        public int GetBorderWidthMin()
        {
            return NativeCalls.godot_icall_0_5(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_border_width");

        /// <summary>
        /// <para>Sets the border width to <c>width</c> pixels for the given <c>margin</c>. See <see cref="Godot.Margin"/> for possible values.</para>
        /// </summary>
        [GodotMethod("set_border_width")]
        [Obsolete("SetBorderWidth is deprecated. Use the BorderWidthBottom property instead.")]
        public void SetBorderWidth(Margin margin, int width)
        {
            NativeCalls.godot_icall_2_65(method_bind_6, Object.GetPtr(this), (int)margin, width);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_border_width");

        /// <summary>
        /// <para>Returns the given <c>margin</c>'s border width. See <see cref="Godot.Margin"/> for possible values.</para>
        /// </summary>
        [GodotMethod("get_border_width")]
        [Obsolete("GetBorderWidth is deprecated. Use the BorderWidthBottom property instead.")]
        public int GetBorderWidth(Margin margin)
        {
            return NativeCalls.godot_icall_1_11(method_bind_7, Object.GetPtr(this), (int)margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_border_blend");

        [GodotMethod("set_border_blend")]
        [Obsolete("SetBorderBlend is deprecated. Use the BorderBlend property instead.")]
        public void SetBorderBlend(bool blend)
        {
            NativeCalls.godot_icall_1_16(method_bind_8, Object.GetPtr(this), blend);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_border_blend");

        [GodotMethod("get_border_blend")]
        [Obsolete("GetBorderBlend is deprecated. Use the BorderBlend property instead.")]
        public bool GetBorderBlend()
        {
            return NativeCalls.godot_icall_0_7(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_corner_radius_individual");

        /// <summary>
        /// <para>Sets the corner radius for each corner to <c>radius_top_left</c>, <c>radius_top_right</c>, <c>radius_bottom_right</c>, and <c>radius_bottom_left</c> pixels.</para>
        /// </summary>
        [GodotMethod("set_corner_radius_individual")]
        public void SetCornerRadiusIndividual(int radiusTopLeft, int radiusTopRight, int radiusBottomRight, int radiusBottomLeft)
        {
            NativeCalls.godot_icall_4_101(method_bind_10, Object.GetPtr(this), radiusTopLeft, radiusTopRight, radiusBottomRight, radiusBottomLeft);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_corner_radius_all");

        /// <summary>
        /// <para>Sets the corner radius to <c>radius</c> pixels for all corners.</para>
        /// </summary>
        [GodotMethod("set_corner_radius_all")]
        public void SetCornerRadiusAll(int radius)
        {
            NativeCalls.godot_icall_1_4(method_bind_11, Object.GetPtr(this), radius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_corner_radius");

        /// <summary>
        /// <para>Sets the corner radius to <c>radius</c> pixels for the given <c>corner</c>. See <see cref="Godot.Corner"/> for possible values.</para>
        /// </summary>
        [GodotMethod("set_corner_radius")]
        [Obsolete("SetCornerRadius is deprecated. Use the CornerRadiusBottomLeft property instead.")]
        public void SetCornerRadius(Corner corner, int radius)
        {
            NativeCalls.godot_icall_2_65(method_bind_12, Object.GetPtr(this), (int)corner, radius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_corner_radius");

        /// <summary>
        /// <para>Returns the given <c>corner</c>'s radius. See <see cref="Godot.Corner"/> for possible values.</para>
        /// </summary>
        [GodotMethod("get_corner_radius")]
        [Obsolete("GetCornerRadius is deprecated. Use the CornerRadiusBottomLeft property instead.")]
        public int GetCornerRadius(Corner corner)
        {
            return NativeCalls.godot_icall_1_11(method_bind_13, Object.GetPtr(this), (int)corner);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_expand_margin");

        /// <summary>
        /// <para>Sets the expand margin to <c>size</c> pixels for the given <c>margin</c>. See <see cref="Godot.Margin"/> for possible values.</para>
        /// </summary>
        [GodotMethod("set_expand_margin")]
        [Obsolete("SetExpandMargin is deprecated. Use the ExpandMarginBottom property instead.")]
        public void SetExpandMargin(Margin margin, float size)
        {
            NativeCalls.godot_icall_2_34(method_bind_14, Object.GetPtr(this), (int)margin, size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_expand_margin_all");

        /// <summary>
        /// <para>Sets the expand margin to <c>size</c> pixels for all margins.</para>
        /// </summary>
        [GodotMethod("set_expand_margin_all")]
        public void SetExpandMarginAll(float size)
        {
            NativeCalls.godot_icall_1_15(method_bind_15, Object.GetPtr(this), size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_expand_margin_individual");

        /// <summary>
        /// <para>Sets the expand margin for each margin to <c>size_left</c>, <c>size_top</c>, <c>size_right</c>, and <c>size_bottom</c> pixels.</para>
        /// </summary>
        [GodotMethod("set_expand_margin_individual")]
        public void SetExpandMarginIndividual(float sizeLeft, float sizeTop, float sizeRight, float sizeBottom)
        {
            NativeCalls.godot_icall_4_903(method_bind_16, Object.GetPtr(this), sizeLeft, sizeTop, sizeRight, sizeBottom);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_expand_margin");

        /// <summary>
        /// <para>Returns the size of the given <c>margin</c>'s expand margin. See <see cref="Godot.Margin"/> for possible values.</para>
        /// </summary>
        [GodotMethod("get_expand_margin")]
        [Obsolete("GetExpandMargin is deprecated. Use the ExpandMarginBottom property instead.")]
        public float GetExpandMargin(Margin margin)
        {
            return NativeCalls.godot_icall_1_12(method_bind_17, Object.GetPtr(this), (int)margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_draw_center");

        [GodotMethod("set_draw_center")]
        [Obsolete("SetDrawCenter is deprecated. Use the DrawCenter property instead.")]
        public void SetDrawCenter(bool drawCenter)
        {
            NativeCalls.godot_icall_1_16(method_bind_18, Object.GetPtr(this), drawCenter);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_draw_center_enabled");

        [GodotMethod("is_draw_center_enabled")]
        [Obsolete("IsDrawCenterEnabled is deprecated. Use the DrawCenter property instead.")]
        public bool IsDrawCenterEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_skew");

        [GodotMethod("set_skew")]
        [Obsolete("SetSkew is deprecated. Use the Skew property instead.")]
        public void SetSkew(Vector2 skew)
        {
            NativeCalls.godot_icall_1_57(method_bind_20, Object.GetPtr(this), ref skew);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_skew");

        [GodotMethod("get_skew")]
        [Obsolete("GetSkew is deprecated. Use the Skew property instead.")]
        public Vector2 GetSkew()
        {
            NativeCalls.godot_icall_0_18(method_bind_21, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shadow_color");

        [GodotMethod("set_shadow_color")]
        [Obsolete("SetShadowColor is deprecated. Use the ShadowColor property instead.")]
        public void SetShadowColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_22, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shadow_color");

        [GodotMethod("get_shadow_color")]
        [Obsolete("GetShadowColor is deprecated. Use the ShadowColor property instead.")]
        public Color GetShadowColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_23, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shadow_size");

        [GodotMethod("set_shadow_size")]
        [Obsolete("SetShadowSize is deprecated. Use the ShadowSize property instead.")]
        public void SetShadowSize(int size)
        {
            NativeCalls.godot_icall_1_4(method_bind_24, Object.GetPtr(this), size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shadow_size");

        [GodotMethod("get_shadow_size")]
        [Obsolete("GetShadowSize is deprecated. Use the ShadowSize property instead.")]
        public int GetShadowSize()
        {
            return NativeCalls.godot_icall_0_5(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shadow_offset");

        [GodotMethod("set_shadow_offset")]
        [Obsolete("SetShadowOffset is deprecated. Use the ShadowOffset property instead.")]
        public void SetShadowOffset(Vector2 offset)
        {
            NativeCalls.godot_icall_1_57(method_bind_26, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shadow_offset");

        [GodotMethod("get_shadow_offset")]
        [Obsolete("GetShadowOffset is deprecated. Use the ShadowOffset property instead.")]
        public Vector2 GetShadowOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_27, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_anti_aliased");

        [GodotMethod("set_anti_aliased")]
        [Obsolete("SetAntiAliased is deprecated. Use the AntiAliasing property instead.")]
        public void SetAntiAliased(bool antiAliased)
        {
            NativeCalls.godot_icall_1_16(method_bind_28, Object.GetPtr(this), antiAliased);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_anti_aliased");

        [GodotMethod("is_anti_aliased")]
        [Obsolete("IsAntiAliased is deprecated. Use the AntiAliasing property instead.")]
        public bool IsAntiAliased()
        {
            return NativeCalls.godot_icall_0_7(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_aa_size");

        [GodotMethod("set_aa_size")]
        [Obsolete("SetAaSize is deprecated. Use the AntiAliasingSize property instead.")]
        public void SetAaSize(float size)
        {
            NativeCalls.godot_icall_1_15(method_bind_30, Object.GetPtr(this), size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_aa_size");

        [GodotMethod("get_aa_size")]
        [Obsolete("GetAaSize is deprecated. Use the AntiAliasingSize property instead.")]
        public float GetAaSize()
        {
            return NativeCalls.godot_icall_0_14(method_bind_31, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_corner_detail");

        [GodotMethod("set_corner_detail")]
        [Obsolete("SetCornerDetail is deprecated. Use the CornerDetail property instead.")]
        public void SetCornerDetail(int detail)
        {
            NativeCalls.godot_icall_1_4(method_bind_32, Object.GetPtr(this), detail);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_corner_detail");

        [GodotMethod("get_corner_detail")]
        [Obsolete("GetCornerDetail is deprecated. Use the CornerDetail property instead.")]
        public int GetCornerDetail()
        {
            return NativeCalls.godot_icall_0_5(method_bind_33, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
