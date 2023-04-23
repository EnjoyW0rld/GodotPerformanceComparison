using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Label displays plain text on the screen. It gives you control over the horizontal and vertical alignment and can wrap the text inside the node's bounding rectangle. It doesn't support bold, italics, or other formatting. For that, use <see cref="Godot.RichTextLabel"/> instead.</para>
    /// <para>Note: Contrarily to most other <see cref="Godot.Control"/>s, Label's <see cref="Godot.Control.MouseFilter"/> defaults to <see cref="Godot.Control.MouseFilterEnum.Ignore"/> (i.e. it doesn't react to mouse input events). This implies that a label won't display any configured <see cref="Godot.Control.HintTooltip"/>, unless you change its mouse filter.</para>
    /// <para>Note: Unicode characters after <c>0xffff</c> (such as most emoji) are not supported on Windows. They will display as unknown characters instead. This will be resolved in Godot 4.0.</para>
    /// </summary>
    public partial class Label : Control
    {
        public enum AlignEnum
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
        /// <para>Controls the text's horizontal align. Supports left, center, right, and fill, or justify. Set it to one of the <see cref="Godot.Label.AlignEnum"/> constants.</para>
        /// </summary>
        public Label.AlignEnum Align
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAlign();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAlign(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Controls the text's vertical align. Supports top, center, bottom, and fill. Set it to one of the <see cref="Godot.Label.VAlign"/> constants.</para>
        /// </summary>
        public Label.VAlign Valign
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetValign();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetValign(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, wraps the text inside the node's bounding rectangle. If you resize the node, it will change its height automatically to show all the text.</para>
        /// </summary>
        public bool Autowrap
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return HasAutowrap();
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
        /// <para>If <c>true</c>, the Label only shows the text that fits inside its bounding rectangle and will clip text horizontally.</para>
        /// </summary>
        public bool ClipText
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsClippingText();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetClipText(value);
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
        /// <para>Restricts the number of characters to display. Set to -1 to disable.</para>
        /// </summary>
        public int VisibleCharacters
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVisibleCharacters();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVisibleCharacters(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Limits the amount of visible characters. If you set <c>percent_visible</c> to 0.5, only up to half of the text's characters will display on screen. Useful to animate the text in a dialog box.</para>
        /// </summary>
        public float PercentVisible
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPercentVisible();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPercentVisible(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The node ignores the first <c>lines_skipped</c> lines before it starts to display text.</para>
        /// </summary>
        public int LinesSkipped
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLinesSkipped();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLinesSkipped(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Limits the lines of text the node shows on screen.</para>
        /// </summary>
        public int MaxLinesVisible
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaxLinesVisible();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaxLinesVisible(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Label";

        public Label() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Label_Ctor(this);
        }

        internal Label(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_align");

        [GodotMethod("set_align")]
        [Obsolete("SetAlign is deprecated. Use the Align property instead.")]
        public void SetAlign(Label.AlignEnum align)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)align);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_align");

        [GodotMethod("get_align")]
        [Obsolete("GetAlign is deprecated. Use the Align property instead.")]
        public Label.AlignEnum GetAlign()
        {
            return (Label.AlignEnum)NativeCalls.godot_icall_0_574(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_valign");

        [GodotMethod("set_valign")]
        [Obsolete("SetValign is deprecated. Use the Valign property instead.")]
        public void SetValign(Label.VAlign valign)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)valign);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_valign");

        [GodotMethod("get_valign")]
        [Obsolete("GetValign is deprecated. Use the Valign property instead.")]
        public Label.VAlign GetValign()
        {
            return (Label.VAlign)NativeCalls.godot_icall_0_575(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_text");

        [GodotMethod("set_text")]
        [Obsolete("SetText is deprecated. Use the Text property instead.")]
        public void SetText(string text)
        {
            NativeCalls.godot_icall_1_54(method_bind_4, Object.GetPtr(this), text);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_text");

        [GodotMethod("get_text")]
        [Obsolete("GetText is deprecated. Use the Text property instead.")]
        public string GetText()
        {
            return NativeCalls.godot_icall_0_6(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_autowrap");

        [GodotMethod("set_autowrap")]
        [Obsolete("SetAutowrap is deprecated. Use the Autowrap property instead.")]
        public void SetAutowrap(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_autowrap");

        [GodotMethod("has_autowrap")]
        [Obsolete("HasAutowrap is deprecated. Use the Autowrap property instead.")]
        public bool HasAutowrap()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_clip_text");

        [GodotMethod("set_clip_text")]
        [Obsolete("SetClipText is deprecated. Use the ClipText property instead.")]
        public void SetClipText(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_8, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_clipping_text");

        [GodotMethod("is_clipping_text")]
        [Obsolete("IsClippingText is deprecated. Use the ClipText property instead.")]
        public bool IsClippingText()
        {
            return NativeCalls.godot_icall_0_7(method_bind_9, Object.GetPtr(this));
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
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_line_height");

        /// <summary>
        /// <para>Returns the font size in pixels.</para>
        /// </summary>
        [GodotMethod("get_line_height")]
        public int GetLineHeight()
        {
            return NativeCalls.godot_icall_0_5(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_line_count");

        /// <summary>
        /// <para>Returns the amount of lines of text the Label has.</para>
        /// </summary>
        [GodotMethod("get_line_count")]
        public int GetLineCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_visible_line_count");

        /// <summary>
        /// <para>Returns the number of lines shown. Useful if the <see cref="Godot.Label"/>'s height cannot currently display all lines.</para>
        /// </summary>
        [GodotMethod("get_visible_line_count")]
        public int GetVisibleLineCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_total_character_count");

        /// <summary>
        /// <para>Returns the total number of printable characters in the text (excluding spaces and newlines).</para>
        /// </summary>
        [GodotMethod("get_total_character_count")]
        public int GetTotalCharacterCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_visible_characters");

        [GodotMethod("set_visible_characters")]
        [Obsolete("SetVisibleCharacters is deprecated. Use the VisibleCharacters property instead.")]
        public void SetVisibleCharacters(int amount)
        {
            NativeCalls.godot_icall_1_4(method_bind_16, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_visible_characters");

        [GodotMethod("get_visible_characters")]
        [Obsolete("GetVisibleCharacters is deprecated. Use the VisibleCharacters property instead.")]
        public int GetVisibleCharacters()
        {
            return NativeCalls.godot_icall_0_5(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_percent_visible");

        [GodotMethod("set_percent_visible")]
        [Obsolete("SetPercentVisible is deprecated. Use the PercentVisible property instead.")]
        public void SetPercentVisible(float percentVisible)
        {
            NativeCalls.godot_icall_1_15(method_bind_18, Object.GetPtr(this), percentVisible);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_percent_visible");

        [GodotMethod("get_percent_visible")]
        [Obsolete("GetPercentVisible is deprecated. Use the PercentVisible property instead.")]
        public float GetPercentVisible()
        {
            return NativeCalls.godot_icall_0_14(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_lines_skipped");

        [GodotMethod("set_lines_skipped")]
        [Obsolete("SetLinesSkipped is deprecated. Use the LinesSkipped property instead.")]
        public void SetLinesSkipped(int linesSkipped)
        {
            NativeCalls.godot_icall_1_4(method_bind_20, Object.GetPtr(this), linesSkipped);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_lines_skipped");

        [GodotMethod("get_lines_skipped")]
        [Obsolete("GetLinesSkipped is deprecated. Use the LinesSkipped property instead.")]
        public int GetLinesSkipped()
        {
            return NativeCalls.godot_icall_0_5(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max_lines_visible");

        [GodotMethod("set_max_lines_visible")]
        [Obsolete("SetMaxLinesVisible is deprecated. Use the MaxLinesVisible property instead.")]
        public void SetMaxLinesVisible(int linesVisible)
        {
            NativeCalls.godot_icall_1_4(method_bind_22, Object.GetPtr(this), linesVisible);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max_lines_visible");

        [GodotMethod("get_max_lines_visible")]
        [Obsolete("GetMaxLinesVisible is deprecated. Use the MaxLinesVisible property instead.")]
        public int GetMaxLinesVisible()
        {
            return NativeCalls.godot_icall_0_5(method_bind_23, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
