using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Rich text can contain custom text, fonts, images and some basic formatting. The label manages these as an internal tag stack. It also adapts itself to given width/heights.</para>
    /// <para>Note: Assignments to <see cref="Godot.RichTextLabel.BbcodeText"/> clear the tag stack and reconstruct it from the property's contents. Any edits made to <see cref="Godot.RichTextLabel.BbcodeText"/> will erase previous edits made from other manual sources such as <see cref="Godot.RichTextLabel.AppendBbcode"/> and the <c>push_*</c> / <see cref="Godot.RichTextLabel.Pop"/> methods.</para>
    /// <para>Note: RichTextLabel doesn't support entangled BBCode tags. For example, instead of using <c>[b]bold[i]bold italic[/b]italic[/i]</c>, use <c>[b]bold[i]bold italic[/i][/b][i]italic[/i]</c>.</para>
    /// <para>Note: <c>push_*/pop</c> functions won't affect BBCode.</para>
    /// <para>Note: Unlike <see cref="Godot.Label"/>, RichTextLabel doesn't have a property to horizontally align text to the center. Instead, enable <see cref="Godot.RichTextLabel.BbcodeEnabled"/> and surround the text in a <c>[center]</c> tag as follows: <c>[center]Example[/center]</c>. There is currently no built-in way to vertically align text either, but this can be emulated by relying on anchors/containers and the <see cref="Godot.RichTextLabel.FitContentHeight"/> property.</para>
    /// <para>Note: Unicode characters after <c>0xffff</c> (such as most emoji) are not supported on Windows. They will display as unknown characters instead. This will be resolved in Godot 4.0.</para>
    /// </summary>
    public partial class RichTextLabel : Control
    {
        public enum Align
        {
            /// <summary>
            /// <para>Makes text left aligned.</para>
            /// </summary>
            Left = 0,
            /// <summary>
            /// <para>Makes text centered.</para>
            /// </summary>
            Center = 1,
            /// <summary>
            /// <para>Makes text right aligned.</para>
            /// </summary>
            Right = 2,
            /// <summary>
            /// <para>Makes text fill width.</para>
            /// </summary>
            Fill = 3
        }

        public enum ListType
        {
            /// <summary>
            /// <para>Each list item has a number marker.</para>
            /// </summary>
            Numbers = 0,
            /// <summary>
            /// <para>Each list item has a letter marker.</para>
            /// </summary>
            Letters = 1,
            /// <summary>
            /// <para>Each list item has a filled circle marker.</para>
            /// </summary>
            Dots = 2
        }

        public enum ItemType
        {
            Frame = 0,
            Text = 1,
            Image = 2,
            Newline = 3,
            Font = 4,
            Color = 5,
            Underline = 6,
            Strikethrough = 7,
            Align = 8,
            Indent = 9,
            List = 10,
            Table = 11,
            Fade = 12,
            Shake = 13,
            Wave = 14,
            Tornado = 15,
            Rainbow = 16,
            Customfx = 18,
            Meta = 17
        }

        public enum InlineAlign
        {
            /// <summary>
            /// <para>Aligns top of the inline image to the top of the text.</para>
            /// </summary>
            Top = 0,
            /// <summary>
            /// <para>Aligns center of the inline image to the center of the text.</para>
            /// </summary>
            Center = 1,
            /// <summary>
            /// <para>Aligns bottom of the inline image to the baseline of the text.</para>
            /// </summary>
            Baseline = 2,
            /// <summary>
            /// <para>Aligns bottom of the inline image to the bottom of the text.</para>
            /// </summary>
            Bottom = 3
        }

        /// <summary>
        /// <para>If <c>true</c>, the label uses BBCode formatting.</para>
        /// <para>Note: Trying to alter the <see cref="Godot.RichTextLabel"/>'s text with <see cref="Godot.RichTextLabel.AddText"/> will reset this to <c>false</c>. Use instead <see cref="Godot.RichTextLabel.AppendBbcode"/> to preserve BBCode formatting.</para>
        /// </summary>
        public bool BbcodeEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUsingBbcode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseBbcode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The label's text in BBCode format. Is not representative of manual modifications to the internal tag stack. Erases changes made by other methods when edited.</para>
        /// <para>Note: It is unadvised to use the <c>+=</c> operator with <c>bbcode_text</c> (e.g. <c>bbcode_text += "some string"</c>) as it replaces the whole text and can cause slowdowns. It will also erase all BBCode that was added to stack using <c>push_*</c> methods. Use <see cref="Godot.RichTextLabel.AppendBbcode"/> for adding text instead, unless you absolutely need to close a tag that was opened in an earlier method call.</para>
        /// </summary>
        public string BbcodeText
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBbcode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBbcode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The restricted number of characters to display in the label. If <c>-1</c>, all characters will be displayed.</para>
        /// <para>Note: Setting this property updates <see cref="Godot.RichTextLabel.PercentVisible"/> based on current <see cref="Godot.RichTextLabel.GetTotalCharacterCount"/>.</para>
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
        /// <para>The range of characters to display, as a <see cref="float"/> between 0.0 and 1.0. When assigned an out of range value, it's the same as assigning 1.0.</para>
        /// <para>Note: Setting this property updates <see cref="Godot.RichTextLabel.VisibleCharacters"/> based on current <see cref="Godot.RichTextLabel.GetTotalCharacterCount"/>.</para>
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
        /// <para>If <c>true</c>, the label underlines meta tags such as <c>[url]{text}[/url]</c>.</para>
        /// </summary>
        public bool MetaUnderlined
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsMetaUnderlined();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMetaUnderline(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The number of spaces associated with a single tab length. Does not affect <c>\t</c> in text tags, only indent tags.</para>
        /// </summary>
        public int TabSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTabSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTabSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The raw text of the label.</para>
        /// <para>When set, clears the tag stack and adds a raw text tag to the top of it. Does not parse BBCodes. Does not modify <see cref="Godot.RichTextLabel.BbcodeText"/>.</para>
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
        /// <para>If <c>true</c>, the label's height will be automatically updated to fit its content.</para>
        /// <para>Note: This property is used as a workaround to fix issues with <see cref="Godot.RichTextLabel"/> in <see cref="Godot.Container"/>s, but it's unreliable in some cases and will be removed in future versions.</para>
        /// </summary>
        public bool FitContentHeight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsFitContentHeightEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFitContentHeight(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the scrollbar is visible. Setting this to <c>false</c> does not block scrolling completely. See <see cref="Godot.RichTextLabel.ScrollToLine"/>.</para>
        /// </summary>
        public bool ScrollActive
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsScrollActive();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetScrollActive(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the window scrolls down to display new content automatically.</para>
        /// </summary>
        public bool ScrollFollowing
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsScrollFollowing();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetScrollFollow(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the label allows text selection.</para>
        /// </summary>
        public bool SelectionEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsSelectionEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSelectionEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the label uses the custom font color.</para>
        /// </summary>
        public bool OverrideSelectedFontColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsOverridingSelectedFontColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOverrideSelectedFontColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the selected text will be deselected when focus is lost.</para>
        /// </summary>
        public bool DeselectOnFocusLossEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDeselectOnFocusLossEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDeselectOnFocusLossEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The currently installed custom effects. This is an array of <see cref="Godot.RichTextEffect"/>s.</para>
        /// <para>To add a custom effect, it's more convenient to use <see cref="Godot.RichTextLabel.InstallEffect"/>.</para>
        /// </summary>
        public Godot.Collections.Array CustomEffects
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEffects();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEffects(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "RichTextLabel";

        public RichTextLabel() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_RichTextLabel_Ctor(this);
        }

        internal RichTextLabel(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_text");

        [GodotMethod("get_text")]
        [Obsolete("GetText is deprecated. Use the Text property instead.")]
        public string GetText()
        {
            return NativeCalls.godot_icall_0_6(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_text");

        /// <summary>
        /// <para>Adds raw non-BBCode-parsed text to the tag stack.</para>
        /// </summary>
        [GodotMethod("add_text")]
        public void AddText(string text)
        {
            NativeCalls.godot_icall_1_54(method_bind_1, Object.GetPtr(this), text);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_text");

        [GodotMethod("set_text")]
        [Obsolete("SetText is deprecated. Use the Text property instead.")]
        public void SetText(string text)
        {
            NativeCalls.godot_icall_1_54(method_bind_2, Object.GetPtr(this), text);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_image");

        /// <summary>
        /// <para>Adds an image's opening and closing tags to the tag stack, optionally providing a <c>width</c> and <c>height</c> to resize the image.</para>
        /// <para>If <c>width</c> or <c>height</c> is set to 0, the image size will be adjusted in order to keep the original aspect ratio.</para>
        /// </summary>
        [GodotMethod("add_image")]
        public void AddImage(Texture image, int width = 0, int height = 0, RichTextLabel.InlineAlign align = (RichTextLabel.InlineAlign)2)
        {
            NativeCalls.godot_icall_4_822(method_bind_3, Object.GetPtr(this), Object.GetPtr(image), width, height, (int)align);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "newline");

        /// <summary>
        /// <para>Adds a newline tag to the tag stack.</para>
        /// </summary>
        [GodotMethod("newline")]
        public void Newline()
        {
            NativeCalls.godot_icall_0_3(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_line");

        /// <summary>
        /// <para>Removes a line of content from the label. Returns <c>true</c> if the line exists.</para>
        /// <para>The <c>line</c> argument is the index of the line to remove, it can take values in the interval <c>[0, get_line_count() - 1]</c>.</para>
        /// </summary>
        [GodotMethod("remove_line")]
        public bool RemoveLine(int line)
        {
            return NativeCalls.godot_icall_1_35(method_bind_5, Object.GetPtr(this), line);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "push_font");

        /// <summary>
        /// <para>Adds a <c>[font]</c> tag to the tag stack. Overrides default fonts for its duration.</para>
        /// </summary>
        [GodotMethod("push_font")]
        public void PushFont(Font font)
        {
            NativeCalls.godot_icall_1_24(method_bind_6, Object.GetPtr(this), Object.GetPtr(font));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "push_normal");

        /// <summary>
        /// <para>Adds a <c>[font]</c> tag with a normal font to the tag stack.</para>
        /// </summary>
        [GodotMethod("push_normal")]
        public void PushNormal()
        {
            NativeCalls.godot_icall_0_3(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "push_bold");

        /// <summary>
        /// <para>Adds a <c>[font]</c> tag with a bold font to the tag stack. This is the same as adding a <c>[b]</c> tag if not currently in a <c>[i]</c> tag.</para>
        /// </summary>
        [GodotMethod("push_bold")]
        public void PushBold()
        {
            NativeCalls.godot_icall_0_3(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "push_bold_italics");

        /// <summary>
        /// <para>Adds a <c>[font]</c> tag with a bold italics font to the tag stack.</para>
        /// </summary>
        [GodotMethod("push_bold_italics")]
        public void PushBoldItalics()
        {
            NativeCalls.godot_icall_0_3(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "push_italics");

        /// <summary>
        /// <para>Adds a <c>[font]</c> tag with a italics font to the tag stack. This is the same as adding a <c>[i]</c> tag if not currently in a <c>[b]</c> tag.</para>
        /// </summary>
        [GodotMethod("push_italics")]
        public void PushItalics()
        {
            NativeCalls.godot_icall_0_3(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "push_mono");

        /// <summary>
        /// <para>Adds a <c>[font]</c> tag with a monospace font to the tag stack.</para>
        /// </summary>
        [GodotMethod("push_mono")]
        public void PushMono()
        {
            NativeCalls.godot_icall_0_3(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "push_color");

        /// <summary>
        /// <para>Adds a <c>[color]</c> tag to the tag stack.</para>
        /// </summary>
        [GodotMethod("push_color")]
        public void PushColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_12, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "push_align");

        /// <summary>
        /// <para>Adds an <c>[align]</c> tag based on the given <c>align</c> value. See <see cref="Godot.RichTextLabel.Align"/> for possible values.</para>
        /// </summary>
        [GodotMethod("push_align")]
        public void PushAlign(RichTextLabel.Align align)
        {
            NativeCalls.godot_icall_1_4(method_bind_13, Object.GetPtr(this), (int)align);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "push_indent");

        /// <summary>
        /// <para>Adds an <c>[indent]</c> tag to the tag stack. Multiplies <c>level</c> by current <see cref="Godot.RichTextLabel.TabSize"/> to determine new margin length.</para>
        /// </summary>
        [GodotMethod("push_indent")]
        public void PushIndent(int level)
        {
            NativeCalls.godot_icall_1_4(method_bind_14, Object.GetPtr(this), level);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "push_list");

        /// <summary>
        /// <para>Adds a <c>[list]</c> tag to the tag stack. Similar to the BBCodes <c>[ol]</c> or <c>[ul]</c>, but supports more list types. Not fully implemented!</para>
        /// </summary>
        [GodotMethod("push_list")]
        public void PushList(RichTextLabel.ListType type)
        {
            NativeCalls.godot_icall_1_4(method_bind_15, Object.GetPtr(this), (int)type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "push_meta");

        /// <summary>
        /// <para>Adds a <c>[meta]</c> tag to the tag stack. Similar to the BBCode <c>[url=something]{text}[/url]</c>, but supports non-<see cref="string"/> metadata types.</para>
        /// </summary>
        [GodotMethod("push_meta")]
        public void PushMeta(object data)
        {
            NativeCalls.godot_icall_1_548(method_bind_16, Object.GetPtr(this), data);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "push_underline");

        /// <summary>
        /// <para>Adds a <c>[u]</c> tag to the tag stack.</para>
        /// </summary>
        [GodotMethod("push_underline")]
        public void PushUnderline()
        {
            NativeCalls.godot_icall_0_3(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "push_strikethrough");

        /// <summary>
        /// <para>Adds a <c>[s]</c> tag to the tag stack.</para>
        /// </summary>
        [GodotMethod("push_strikethrough")]
        public void PushStrikethrough()
        {
            NativeCalls.godot_icall_0_3(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "push_table");

        /// <summary>
        /// <para>Adds a <c>[table=columns]</c> tag to the tag stack.</para>
        /// </summary>
        [GodotMethod("push_table")]
        public void PushTable(int columns)
        {
            NativeCalls.godot_icall_1_4(method_bind_19, Object.GetPtr(this), columns);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_table_column_expand");

        /// <summary>
        /// <para>Edits the selected column's expansion options. If <c>expand</c> is <c>true</c>, the column expands in proportion to its expansion ratio versus the other columns' ratios.</para>
        /// <para>For example, 2 columns with ratios 3 and 4 plus 70 pixels in available width would expand 30 and 40 pixels, respectively.</para>
        /// <para>If <c>expand</c> is <c>false</c>, the column will not contribute to the total ratio.</para>
        /// </summary>
        [GodotMethod("set_table_column_expand")]
        public void SetTableColumnExpand(int column, bool expand, int ratio)
        {
            NativeCalls.godot_icall_3_823(method_bind_20, Object.GetPtr(this), column, expand, ratio);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "push_cell");

        /// <summary>
        /// <para>Adds a <c>[cell]</c> tag to the tag stack. Must be inside a <c>[table]</c> tag. See <see cref="Godot.RichTextLabel.PushTable"/> for details.</para>
        /// </summary>
        [GodotMethod("push_cell")]
        public void PushCell()
        {
            NativeCalls.godot_icall_0_3(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "pop");

        /// <summary>
        /// <para>Terminates the current tag. Use after <c>push_*</c> methods to close BBCodes manually. Does not need to follow <c>add_*</c> methods.</para>
        /// </summary>
        [GodotMethod("pop")]
        public void Pop()
        {
            NativeCalls.godot_icall_0_3(method_bind_22, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Clears the tag stack and sets <see cref="Godot.RichTextLabel.BbcodeText"/> to an empty string.</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_selected_text");

        /// <summary>
        /// <para>Returns the current selection text. Does not include BBCodes.</para>
        /// </summary>
        [GodotMethod("get_selected_text")]
        public string GetSelectedText()
        {
            return NativeCalls.godot_icall_0_6(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "deselect");

        /// <summary>
        /// <para>Clears the current selection.</para>
        /// </summary>
        [GodotMethod("deselect")]
        public void Deselect()
        {
            NativeCalls.godot_icall_0_3(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_meta_underline");

        [GodotMethod("set_meta_underline")]
        [Obsolete("SetMetaUnderline is deprecated. Use the MetaUnderlined property instead.")]
        public void SetMetaUnderline(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_26, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_meta_underlined");

        [GodotMethod("is_meta_underlined")]
        [Obsolete("IsMetaUnderlined is deprecated. Use the MetaUnderlined property instead.")]
        public bool IsMetaUnderlined()
        {
            return NativeCalls.godot_icall_0_7(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_override_selected_font_color");

        [GodotMethod("set_override_selected_font_color")]
        [Obsolete("SetOverrideSelectedFontColor is deprecated. Use the OverrideSelectedFontColor property instead.")]
        public void SetOverrideSelectedFontColor(bool @override)
        {
            NativeCalls.godot_icall_1_16(method_bind_28, Object.GetPtr(this), @override);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_overriding_selected_font_color");

        [GodotMethod("is_overriding_selected_font_color")]
        [Obsolete("IsOverridingSelectedFontColor is deprecated. Use the OverrideSelectedFontColor property instead.")]
        public bool IsOverridingSelectedFontColor()
        {
            return NativeCalls.godot_icall_0_7(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_scroll_active");

        [GodotMethod("set_scroll_active")]
        [Obsolete("SetScrollActive is deprecated. Use the ScrollActive property instead.")]
        public void SetScrollActive(bool active)
        {
            NativeCalls.godot_icall_1_16(method_bind_30, Object.GetPtr(this), active);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_scroll_active");

        [GodotMethod("is_scroll_active")]
        [Obsolete("IsScrollActive is deprecated. Use the ScrollActive property instead.")]
        public bool IsScrollActive()
        {
            return NativeCalls.godot_icall_0_7(method_bind_31, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_scroll_follow");

        [GodotMethod("set_scroll_follow")]
        [Obsolete("SetScrollFollow is deprecated. Use the ScrollFollowing property instead.")]
        public void SetScrollFollow(bool follow)
        {
            NativeCalls.godot_icall_1_16(method_bind_32, Object.GetPtr(this), follow);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_scroll_following");

        [GodotMethod("is_scroll_following")]
        [Obsolete("IsScrollFollowing is deprecated. Use the ScrollFollowing property instead.")]
        public bool IsScrollFollowing()
        {
            return NativeCalls.godot_icall_0_7(method_bind_33, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_v_scroll");

        /// <summary>
        /// <para>Returns the vertical scrollbar.</para>
        /// <para>Warning: This is a required internal node, removing and freeing it may cause a crash. If you wish to hide it or any of its children, use their <see cref="Godot.CanvasItem.Visible"/> property.</para>
        /// </summary>
        [GodotMethod("get_v_scroll")]
        public VScrollBar GetVScroll()
        {
            return NativeCalls.godot_icall_0_546(method_bind_34, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "scroll_to_line");

        /// <summary>
        /// <para>Scrolls the window's top line to match <c>line</c>.</para>
        /// </summary>
        [GodotMethod("scroll_to_line")]
        public void ScrollToLine(int line)
        {
            NativeCalls.godot_icall_1_4(method_bind_35, Object.GetPtr(this), line);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tab_size");

        [GodotMethod("set_tab_size")]
        [Obsolete("SetTabSize is deprecated. Use the TabSize property instead.")]
        public void SetTabSize(int spaces)
        {
            NativeCalls.godot_icall_1_4(method_bind_36, Object.GetPtr(this), spaces);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tab_size");

        [GodotMethod("get_tab_size")]
        [Obsolete("GetTabSize is deprecated. Use the TabSize property instead.")]
        public int GetTabSize()
        {
            return NativeCalls.godot_icall_0_5(method_bind_37, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fit_content_height");

        [GodotMethod("set_fit_content_height")]
        [Obsolete("SetFitContentHeight is deprecated. Use the FitContentHeight property instead.")]
        public void SetFitContentHeight(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_38, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_fit_content_height_enabled");

        [GodotMethod("is_fit_content_height_enabled")]
        [Obsolete("IsFitContentHeightEnabled is deprecated. Use the FitContentHeight property instead.")]
        public bool IsFitContentHeightEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_39, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_selection_enabled");

        [GodotMethod("set_selection_enabled")]
        [Obsolete("SetSelectionEnabled is deprecated. Use the SelectionEnabled property instead.")]
        public void SetSelectionEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_40, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_selection_enabled");

        [GodotMethod("is_selection_enabled")]
        [Obsolete("IsSelectionEnabled is deprecated. Use the SelectionEnabled property instead.")]
        public bool IsSelectionEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_41, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_deselect_on_focus_loss_enabled");

        [GodotMethod("set_deselect_on_focus_loss_enabled")]
        [Obsolete("SetDeselectOnFocusLossEnabled is deprecated. Use the DeselectOnFocusLossEnabled property instead.")]
        public void SetDeselectOnFocusLossEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_42, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_deselect_on_focus_loss_enabled");

        [GodotMethod("is_deselect_on_focus_loss_enabled")]
        [Obsolete("IsDeselectOnFocusLossEnabled is deprecated. Use the DeselectOnFocusLossEnabled property instead.")]
        public bool IsDeselectOnFocusLossEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_43, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "parse_bbcode");

        /// <summary>
        /// <para>The assignment version of <see cref="Godot.RichTextLabel.AppendBbcode"/>. Clears the tag stack and inserts the new content.</para>
        /// <para>Note: This method internals' can't possibly fail, but an error code is returned for backwards compatibility, which will always be <c>OK</c>.</para>
        /// </summary>
        [GodotMethod("parse_bbcode")]
        public Error ParseBbcode(string bbcode)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_44, Object.GetPtr(this), bbcode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "append_bbcode");

        /// <summary>
        /// <para>Parses <c>bbcode</c> and adds tags to the tag stack as needed.</para>
        /// <para>Note: Using this method, you can't close a tag that was opened in a previous <see cref="Godot.RichTextLabel.AppendBbcode"/> call. This is done to improve performance, especially when updating large RichTextLabels since rebuilding the whole BBCode every time would be slower. If you absolutely need to close a tag in a future method call, append the <see cref="Godot.RichTextLabel.BbcodeText"/> instead of using <see cref="Godot.RichTextLabel.AppendBbcode"/>.</para>
        /// <para>Note: This method internals' can't possibly fail, but an error code is returned for backwards compatibility, which will always be <c>OK</c>.</para>
        /// </summary>
        [GodotMethod("append_bbcode")]
        public Error AppendBbcode(string bbcode)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_45, Object.GetPtr(this), bbcode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bbcode");

        [GodotMethod("set_bbcode")]
        [Obsolete("SetBbcode is deprecated. Use the BbcodeText property instead.")]
        public void SetBbcode(string text)
        {
            NativeCalls.godot_icall_1_54(method_bind_46, Object.GetPtr(this), text);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bbcode");

        [GodotMethod("get_bbcode")]
        [Obsolete("GetBbcode is deprecated. Use the BbcodeText property instead.")]
        public string GetBbcode()
        {
            return NativeCalls.godot_icall_0_6(method_bind_47, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_visible_characters");

        [GodotMethod("set_visible_characters")]
        [Obsolete("SetVisibleCharacters is deprecated. Use the VisibleCharacters property instead.")]
        public void SetVisibleCharacters(int amount)
        {
            NativeCalls.godot_icall_1_4(method_bind_48, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_visible_characters");

        [GodotMethod("get_visible_characters")]
        [Obsolete("GetVisibleCharacters is deprecated. Use the VisibleCharacters property instead.")]
        public int GetVisibleCharacters()
        {
            return NativeCalls.godot_icall_0_5(method_bind_49, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_percent_visible");

        [GodotMethod("set_percent_visible")]
        [Obsolete("SetPercentVisible is deprecated. Use the PercentVisible property instead.")]
        public void SetPercentVisible(float percentVisible)
        {
            NativeCalls.godot_icall_1_15(method_bind_50, Object.GetPtr(this), percentVisible);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_percent_visible");

        [GodotMethod("get_percent_visible")]
        [Obsolete("GetPercentVisible is deprecated. Use the PercentVisible property instead.")]
        public float GetPercentVisible()
        {
            return NativeCalls.godot_icall_0_14(method_bind_51, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_total_character_count");

        /// <summary>
        /// <para>Returns the total number of characters from text tags. Does not include BBCodes.</para>
        /// </summary>
        [GodotMethod("get_total_character_count")]
        public int GetTotalCharacterCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_52, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_53 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_bbcode");

        [GodotMethod("set_use_bbcode")]
        [Obsolete("SetUseBbcode is deprecated. Use the BbcodeEnabled property instead.")]
        public void SetUseBbcode(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_53, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_54 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_using_bbcode");

        [GodotMethod("is_using_bbcode")]
        [Obsolete("IsUsingBbcode is deprecated. Use the BbcodeEnabled property instead.")]
        public bool IsUsingBbcode()
        {
            return NativeCalls.godot_icall_0_7(method_bind_54, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_55 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_line_count");

        /// <summary>
        /// <para>Returns the total number of newlines in the tag stack's text tags. Considers wrapped text as one line.</para>
        /// </summary>
        [GodotMethod("get_line_count")]
        public int GetLineCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_55, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_56 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_visible_line_count");

        /// <summary>
        /// <para>Returns the number of visible lines.</para>
        /// </summary>
        [GodotMethod("get_visible_line_count")]
        public int GetVisibleLineCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_56, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_57 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_content_height");

        /// <summary>
        /// <para>Returns the height of the content.</para>
        /// </summary>
        [GodotMethod("get_content_height")]
        public int GetContentHeight()
        {
            return NativeCalls.godot_icall_0_5(method_bind_57, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_58 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "parse_expressions_for_values");

        /// <summary>
        /// <para>Parses BBCode parameter <c>expressions</c> into a dictionary.</para>
        /// </summary>
        [GodotMethod("parse_expressions_for_values")]
        public Godot.Collections.Dictionary ParseExpressionsForValues(string[] expressions)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_1_824(method_bind_58, Object.GetPtr(this), expressions));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_59 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_effects");

        [GodotMethod("set_effects")]
        [Obsolete("SetEffects is deprecated. Use the CustomEffects property instead.")]
        public void SetEffects(Godot.Collections.Array effects)
        {
            NativeCalls.godot_icall_1_92(method_bind_59, Object.GetPtr(this), effects.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_60 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_effects");

        [GodotMethod("get_effects")]
        [Obsolete("GetEffects is deprecated. Use the CustomEffects property instead.")]
        public Godot.Collections.Array GetEffects()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_60, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_61 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "install_effect");

        /// <summary>
        /// <para>Installs a custom effect. <c>effect</c> should be a valid <see cref="Godot.RichTextEffect"/>.</para>
        /// </summary>
        [GodotMethod("install_effect")]
        public void InstallEffect(object effect)
        {
            NativeCalls.godot_icall_1_548(method_bind_61, Object.GetPtr(this), effect);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
