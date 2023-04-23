using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Label3D displays plain text in a 3D world. It gives you control over the horizontal and vertical alignment.</para>
    /// </summary>
    public partial class Label3D : GeometryInstance
    {
        public enum Align
        {
            /// <summary>
            /// <para>Align rows to the left (default).</para>
            /// </summary>
            Left = 0,
            /// <summary>
            /// <para>Align rows centered.</para>
            /// </summary>
            Center = 1,
            /// <summary>
            /// <para>Align rows to the right.</para>
            /// </summary>
            Right = 2,
            /// <summary>
            /// <para>Expand row whitespaces to fit the width.</para>
            /// </summary>
            Fill = 3
        }

        public enum DrawFlags
        {
            /// <summary>
            /// <para>If set, lights in the environment affect the label.</para>
            /// </summary>
            Shaded = 0,
            /// <summary>
            /// <para>If set, text can be seen from the back as well. If not, the text is invisible when looking at it from behind.</para>
            /// </summary>
            DoubleSided = 1,
            /// <summary>
            /// <para>Disables the depth test, so this object is drawn on top of all others. However, objects drawn after it in the draw order may cover it.</para>
            /// </summary>
            DisableDepthTest = 2,
            /// <summary>
            /// <para>Label is scaled by depth so that it always appears the same size on screen.</para>
            /// </summary>
            FixedSize = 3,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.Label3D.DrawFlags"/> enum.</para>
            /// </summary>
            Max = 4
        }

        public enum AlphaCutMode
        {
            /// <summary>
            /// <para>This mode performs standard alpha blending. It can display translucent areas, but transparency sorting issues may be visible when multiple transparent materials are overlapping.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>This mode only allows fully transparent or fully opaque pixels. This mode is also known as alpha testing or 1-bit transparency.</para>
            /// <para>Note: This mode might have issues with anti-aliased fonts and outlines, try adjusting <see cref="Godot.Label3D.AlphaScissorThreshold"/> or using SDF font.</para>
            /// <para>Note: When using text with overlapping glyphs (e.g., cursive scripts), this mode might have transparency sorting issues between the main text and the outline.</para>
            /// </summary>
            Discard = 1,
            /// <summary>
            /// <para>This mode draws fully opaque pixels in the depth prepass. This is slower than <see cref="Godot.Label3D.AlphaCutMode.Disabled"/> or <see cref="Godot.Label3D.AlphaCutMode.Discard"/>, but it allows displaying translucent areas and smooth edges while using proper sorting.</para>
            /// <para>Note: When using text with overlapping glyphs (e.g., cursive scripts), this mode might have transparency sorting issues between the main text and the outline.</para>
            /// </summary>
            OpaquePrepass = 2
        }

        public enum VAlign
        {
            /// <summary>
            /// <para>Align the whole text to the top.</para>
            /// </summary>
            Top = 0,
            /// <summary>
            /// <para>Align the whole text to the center.</para>
            /// </summary>
            Center = 1,
            /// <summary>
            /// <para>Align the whole text to the bottom.</para>
            /// </summary>
            Bottom = 2,
            /// <summary>
            /// <para>Align the whole text by spreading the rows.</para>
            /// </summary>
            Fill = 3
        }

        /// <summary>
        /// <para>The size of one pixel's width on the label to scale it in 3D.</para>
        /// </summary>
        public float PixelSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPixelSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPixelSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The text drawing offset (in pixels).</para>
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
        /// <para>The billboard mode to use for the label. See <see cref="Godot.SpatialMaterial.BillboardMode"/> for possible values.</para>
        /// </summary>
        public SpatialMaterial.BillboardMode Billboard
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBillboardMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBillboardMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the <see cref="Godot.Light"/> in the <see cref="Godot.Environment"/> has effects on the label.</para>
        /// </summary>
        public bool Shaded
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDrawFlag((Label3D.DrawFlags)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDrawFlag((Label3D.DrawFlags)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, text can be seen from the back as well, if <c>false</c>, it is invisible when looking at it from behind.</para>
        /// </summary>
        public bool DoubleSided
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDrawFlag((Label3D.DrawFlags)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDrawFlag((Label3D.DrawFlags)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, depth testing is disabled and the object will be drawn in render order.</para>
        /// </summary>
        public bool NoDepthTest
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDrawFlag((Label3D.DrawFlags)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDrawFlag((Label3D.DrawFlags)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the label is rendered at the same size regardless of distance.</para>
        /// </summary>
        public bool FixedSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDrawFlag((Label3D.DrawFlags)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDrawFlag((Label3D.DrawFlags)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The alpha cutting mode to use for the sprite. See <see cref="Godot.Label3D.AlphaCutMode"/> for possible values.</para>
        /// </summary>
        public Label3D.AlphaCutMode AlphaCut
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAlphaCutMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAlphaCutMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Threshold at which the alpha scissor will discard values.</para>
        /// </summary>
        public float AlphaScissorThreshold
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAlphaScissorThreshold();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAlphaScissorThreshold(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the render priority for the text. Higher priority objects will be sorted in front of lower priority objects.</para>
        /// <para>Note: This only applies if <see cref="Godot.Label3D.AlphaCut"/> is set to <see cref="Godot.Label3D.AlphaCutMode.Disabled"/> (default value).</para>
        /// <para>Note: This only applies to sorting of transparent objects. This will not impact how transparent objects are sorted relative to opaque objects. This is because opaque objects are not sorted, while transparent objects are sorted from back to front (subject to priority).</para>
        /// </summary>
        public int RenderPriority
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRenderPriority();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRenderPriority(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the render priority for the text outline. Higher priority objects will be sorted in front of lower priority objects.</para>
        /// <para>Note: This only applies if <see cref="Godot.Label3D.AlphaCut"/> is set to <see cref="Godot.Label3D.AlphaCutMode.Disabled"/> (default value).</para>
        /// <para>Note: This only applies to sorting of transparent objects. This will not impact how transparent objects are sorted relative to opaque objects. This is because opaque objects are not sorted, while transparent objects are sorted from back to front (subject to priority).</para>
        /// </summary>
        public int OutlineRenderPriority
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOutlineRenderPriority();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOutlineRenderPriority(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Text <see cref="Godot.Color"/> of the <see cref="Godot.Label3D"/>.</para>
        /// </summary>
        public Color Modulate
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
        /// <para>The tint of <see cref="Godot.Font"/>'s outline.</para>
        /// </summary>
        public Color OutlineModulate
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOutlineModulate();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOutlineModulate(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The text to display on screen.</para>
        /// </summary>
        public string Text
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetText();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetText(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para><see cref="Godot.Font"/> used for the <see cref="Godot.Label3D"/>'s text.</para>
        /// </summary>
        public Font Font
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFont();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFont(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Controls the text's horizontal alignment. Supports left, center, right. Set it to one of the <see cref="Godot.Label3D.Align"/> constants.</para>
        /// </summary>
        public Label3D.Align HorizontalAlignment
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHorizontalAlignment();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHorizontalAlignment(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Controls the text's vertical alignment. Supports top, center, bottom. Set it to one of the <see cref="Godot.Label3D.VAlign"/> constants.</para>
        /// </summary>
        public Label3D.VAlign VerticalAlignment
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVerticalAlignment();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVerticalAlignment(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, all the text displays as UPPERCASE.</para>
        /// </summary>
        public bool Uppercase
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUppercase();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUppercase(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Vertical space between lines in multiline <see cref="Godot.Label3D"/>.</para>
        /// </summary>
        public float LineSpacing
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLineSpacing();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLineSpacing(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, wraps the text to the <see cref="Godot.Label3D.Width"/>.</para>
        /// </summary>
        public bool Autowrap
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAutowrap();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAutowrap(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Text width (in pixels), used for autowrap and fill alignment.</para>
        /// </summary>
        public float Width
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetWidth();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetWidth(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Label3D";

        public Label3D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Label3D_Ctor(this);
        }

        internal Label3D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_horizontal_alignment");

        [GodotMethod("set_horizontal_alignment")]
        [Obsolete("SetHorizontalAlignment is deprecated. Use the HorizontalAlignment property instead.")]
        public void SetHorizontalAlignment(Label3D.Align alignment)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)alignment);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_horizontal_alignment");

        [GodotMethod("get_horizontal_alignment")]
        [Obsolete("GetHorizontalAlignment is deprecated. Use the HorizontalAlignment property instead.")]
        public Label3D.Align GetHorizontalAlignment()
        {
            return (Label3D.Align)NativeCalls.godot_icall_0_576(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_vertical_alignment");

        [GodotMethod("set_vertical_alignment")]
        [Obsolete("SetVerticalAlignment is deprecated. Use the VerticalAlignment property instead.")]
        public void SetVerticalAlignment(Label3D.VAlign alignment)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)alignment);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_vertical_alignment");

        [GodotMethod("get_vertical_alignment")]
        [Obsolete("GetVerticalAlignment is deprecated. Use the VerticalAlignment property instead.")]
        public Label3D.VAlign GetVerticalAlignment()
        {
            return (Label3D.VAlign)NativeCalls.godot_icall_0_577(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_modulate");

        [GodotMethod("set_modulate")]
        [Obsolete("SetModulate is deprecated. Use the Modulate property instead.")]
        public void SetModulate(Color modulate)
        {
            NativeCalls.godot_icall_1_199(method_bind_4, Object.GetPtr(this), ref modulate);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_modulate");

        [GodotMethod("get_modulate")]
        [Obsolete("GetModulate is deprecated. Use the Modulate property instead.")]
        public Color GetModulate()
        {
            NativeCalls.godot_icall_0_200(method_bind_5, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_outline_modulate");

        [GodotMethod("set_outline_modulate")]
        [Obsolete("SetOutlineModulate is deprecated. Use the OutlineModulate property instead.")]
        public void SetOutlineModulate(Color modulate)
        {
            NativeCalls.godot_icall_1_199(method_bind_6, Object.GetPtr(this), ref modulate);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_outline_modulate");

        [GodotMethod("get_outline_modulate")]
        [Obsolete("GetOutlineModulate is deprecated. Use the OutlineModulate property instead.")]
        public Color GetOutlineModulate()
        {
            NativeCalls.godot_icall_0_200(method_bind_7, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_text");

        [GodotMethod("set_text")]
        [Obsolete("SetText is deprecated. Use the Text property instead.")]
        public void SetText(string text)
        {
            NativeCalls.godot_icall_1_54(method_bind_8, Object.GetPtr(this), text);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_text");

        [GodotMethod("get_text")]
        [Obsolete("GetText is deprecated. Use the Text property instead.")]
        public string GetText()
        {
            return NativeCalls.godot_icall_0_6(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_uppercase");

        [GodotMethod("set_uppercase")]
        [Obsolete("SetUppercase is deprecated. Use the Uppercase property instead.")]
        public void SetUppercase(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_uppercase");

        [GodotMethod("is_uppercase")]
        [Obsolete("IsUppercase is deprecated. Use the Uppercase property instead.")]
        public bool IsUppercase()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_render_priority");

        [GodotMethod("set_render_priority")]
        [Obsolete("SetRenderPriority is deprecated. Use the RenderPriority property instead.")]
        public void SetRenderPriority(int priority)
        {
            NativeCalls.godot_icall_1_4(method_bind_12, Object.GetPtr(this), priority);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_render_priority");

        [GodotMethod("get_render_priority")]
        [Obsolete("GetRenderPriority is deprecated. Use the RenderPriority property instead.")]
        public int GetRenderPriority()
        {
            return NativeCalls.godot_icall_0_5(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_outline_render_priority");

        [GodotMethod("set_outline_render_priority")]
        [Obsolete("SetOutlineRenderPriority is deprecated. Use the OutlineRenderPriority property instead.")]
        public void SetOutlineRenderPriority(int priority)
        {
            NativeCalls.godot_icall_1_4(method_bind_14, Object.GetPtr(this), priority);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_outline_render_priority");

        [GodotMethod("get_outline_render_priority")]
        [Obsolete("GetOutlineRenderPriority is deprecated. Use the OutlineRenderPriority property instead.")]
        public int GetOutlineRenderPriority()
        {
            return NativeCalls.godot_icall_0_5(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_font");

        [GodotMethod("set_font")]
        [Obsolete("SetFont is deprecated. Use the Font property instead.")]
        public void SetFont(Font font)
        {
            NativeCalls.godot_icall_1_24(method_bind_16, Object.GetPtr(this), Object.GetPtr(font));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_font");

        [GodotMethod("get_font")]
        [Obsolete("GetFont is deprecated. Use the Font property instead.")]
        public Font GetFont()
        {
            return NativeCalls.godot_icall_0_322(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_line_spacing");

        [GodotMethod("set_line_spacing")]
        [Obsolete("SetLineSpacing is deprecated. Use the LineSpacing property instead.")]
        public void SetLineSpacing(float lineSpacing)
        {
            NativeCalls.godot_icall_1_15(method_bind_18, Object.GetPtr(this), lineSpacing);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_line_spacing");

        [GodotMethod("get_line_spacing")]
        [Obsolete("GetLineSpacing is deprecated. Use the LineSpacing property instead.")]
        public float GetLineSpacing()
        {
            return NativeCalls.godot_icall_0_14(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_autowrap");

        [GodotMethod("set_autowrap")]
        [Obsolete("SetAutowrap is deprecated. Use the Autowrap property instead.")]
        public void SetAutowrap(bool autowrapMode)
        {
            NativeCalls.godot_icall_1_16(method_bind_20, Object.GetPtr(this), autowrapMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_autowrap");

        [GodotMethod("get_autowrap")]
        [Obsolete("GetAutowrap is deprecated. Use the Autowrap property instead.")]
        public bool GetAutowrap()
        {
            return NativeCalls.godot_icall_0_7(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_width");

        [GodotMethod("set_width")]
        [Obsolete("SetWidth is deprecated. Use the Width property instead.")]
        public void SetWidth(float width)
        {
            NativeCalls.godot_icall_1_15(method_bind_22, Object.GetPtr(this), width);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_width");

        [GodotMethod("get_width")]
        [Obsolete("GetWidth is deprecated. Use the Width property instead.")]
        public float GetWidth()
        {
            return NativeCalls.godot_icall_0_14(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pixel_size");

        [GodotMethod("set_pixel_size")]
        [Obsolete("SetPixelSize is deprecated. Use the PixelSize property instead.")]
        public void SetPixelSize(float pixelSize)
        {
            NativeCalls.godot_icall_1_15(method_bind_24, Object.GetPtr(this), pixelSize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pixel_size");

        [GodotMethod("get_pixel_size")]
        [Obsolete("GetPixelSize is deprecated. Use the PixelSize property instead.")]
        public float GetPixelSize()
        {
            return NativeCalls.godot_icall_0_14(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_offset");

        [GodotMethod("set_offset")]
        [Obsolete("SetOffset is deprecated. Use the Offset property instead.")]
        public void SetOffset(Vector2 offset)
        {
            NativeCalls.godot_icall_1_57(method_bind_26, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_offset");

        [GodotMethod("get_offset")]
        [Obsolete("GetOffset is deprecated. Use the Offset property instead.")]
        public Vector2 GetOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_27, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_draw_flag");

        /// <summary>
        /// <para>If <c>true</c>, the specified flag will be enabled. See <see cref="Godot.Label3D.DrawFlags"/> for a list of flags.</para>
        /// </summary>
        [GodotMethod("set_draw_flag")]
        [Obsolete("SetDrawFlag is deprecated. Use the FixedSize property instead.")]
        public void SetDrawFlag(Label3D.DrawFlags flag, bool enabled)
        {
            NativeCalls.godot_icall_2_23(method_bind_28, Object.GetPtr(this), (int)flag, enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_draw_flag");

        /// <summary>
        /// <para>Returns the value of the specified flag.</para>
        /// </summary>
        [GodotMethod("get_draw_flag")]
        [Obsolete("GetDrawFlag is deprecated. Use the FixedSize property instead.")]
        public bool GetDrawFlag(Label3D.DrawFlags flag)
        {
            return NativeCalls.godot_icall_1_35(method_bind_29, Object.GetPtr(this), (int)flag);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_billboard_mode");

        [GodotMethod("set_billboard_mode")]
        [Obsolete("SetBillboardMode is deprecated. Use the Billboard property instead.")]
        public void SetBillboardMode(SpatialMaterial.BillboardMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_30, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_billboard_mode");

        [GodotMethod("get_billboard_mode")]
        [Obsolete("GetBillboardMode is deprecated. Use the Billboard property instead.")]
        public SpatialMaterial.BillboardMode GetBillboardMode()
        {
            return (SpatialMaterial.BillboardMode)NativeCalls.godot_icall_0_578(method_bind_31, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_alpha_cut_mode");

        [GodotMethod("set_alpha_cut_mode")]
        [Obsolete("SetAlphaCutMode is deprecated. Use the AlphaCut property instead.")]
        public void SetAlphaCutMode(Label3D.AlphaCutMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_32, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_alpha_cut_mode");

        [GodotMethod("get_alpha_cut_mode")]
        [Obsolete("GetAlphaCutMode is deprecated. Use the AlphaCut property instead.")]
        public Label3D.AlphaCutMode GetAlphaCutMode()
        {
            return (Label3D.AlphaCutMode)NativeCalls.godot_icall_0_579(method_bind_33, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_alpha_scissor_threshold");

        [GodotMethod("set_alpha_scissor_threshold")]
        [Obsolete("SetAlphaScissorThreshold is deprecated. Use the AlphaScissorThreshold property instead.")]
        public void SetAlphaScissorThreshold(float threshold)
        {
            NativeCalls.godot_icall_1_15(method_bind_34, Object.GetPtr(this), threshold);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_alpha_scissor_threshold");

        [GodotMethod("get_alpha_scissor_threshold")]
        [Obsolete("GetAlphaScissorThreshold is deprecated. Use the AlphaScissorThreshold property instead.")]
        public float GetAlphaScissorThreshold()
        {
            return NativeCalls.godot_icall_0_14(method_bind_35, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "generate_triangle_mesh");

        /// <summary>
        /// <para>Returns a <see cref="Godot.TriangleMesh"/> with the label's vertices following its current configuration (such as its <see cref="Godot.Label3D.PixelSize"/>).</para>
        /// </summary>
        [GodotMethod("generate_triangle_mesh")]
        public TriangleMesh GenerateTriangleMesh()
        {
            return NativeCalls.godot_icall_0_580(method_bind_36, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
