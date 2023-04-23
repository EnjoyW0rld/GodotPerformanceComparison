using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>LineEdit provides a single-line string editor, used for text fields.</para>
    /// <para>It features many built-in shortcuts which will always be available (<c>Ctrl</c> here maps to <c>Command</c> on macOS):</para>
    /// <para>- Ctrl + C: Copy</para>
    /// <para>- Ctrl + X: Cut</para>
    /// <para>- Ctrl + V or Ctrl + Y: Paste/"yank"</para>
    /// <para>- Ctrl + Z: Undo</para>
    /// <para>- Ctrl + Shift + Z: Redo</para>
    /// <para>- Ctrl + U: Delete text from the cursor position to the beginning of the line</para>
    /// <para>- Ctrl + K: Delete text from the cursor position to the end of the line</para>
    /// <para>- Ctrl + A: Select all text</para>
    /// <para>- Up/Down arrow: Move the cursor to the beginning/end of the line</para>
    /// <para>On macOS, some extra keyboard shortcuts are available:</para>
    /// <para>- Ctrl + F: Like the right arrow key, move the cursor one character right</para>
    /// <para>- Ctrl + B: Like the left arrow key, move the cursor one character left</para>
    /// <para>- Ctrl + P: Like the up arrow key, move the cursor to the previous line</para>
    /// <para>- Ctrl + N: Like the down arrow key, move the cursor to the next line</para>
    /// <para>- Ctrl + D: Like the Delete key, delete the character on the right side of cursor</para>
    /// <para>- Ctrl + H: Like the Backspace key, delete the character on the left side of the cursor</para>
    /// <para>- Command + Left arrow: Like the Home key, move the cursor to the beginning of the line</para>
    /// <para>- Command + Right arrow: Like the End key, move the cursor to the end of the line</para>
    /// </summary>
    public partial class LineEdit : Control
    {
        public enum AlignEnum
        {
            /// <summary>
            /// <para>Aligns the text on the left-hand side of the <see cref="Godot.LineEdit"/>.</para>
            /// </summary>
            Left = 0,
            /// <summary>
            /// <para>Centers the text in the middle of the <see cref="Godot.LineEdit"/>.</para>
            /// </summary>
            Center = 1,
            /// <summary>
            /// <para>Aligns the text on the right-hand side of the <see cref="Godot.LineEdit"/>.</para>
            /// </summary>
            Right = 2,
            /// <summary>
            /// <para>Stretches whitespaces to fit the <see cref="Godot.LineEdit"/>'s width.</para>
            /// </summary>
            Fill = 3
        }

        public enum MenuItems
        {
            /// <summary>
            /// <para>Cuts (copies and clears) the selected text.</para>
            /// </summary>
            Cut = 0,
            /// <summary>
            /// <para>Copies the selected text.</para>
            /// </summary>
            Copy = 1,
            /// <summary>
            /// <para>Pastes the clipboard text over the selected text (or at the cursor's position).</para>
            /// <para>Non-printable escape characters are automatically stripped from the OS clipboard via <c>String.strip_escapes</c>.</para>
            /// </summary>
            Paste = 2,
            /// <summary>
            /// <para>Erases the whole <see cref="Godot.LineEdit"/> text.</para>
            /// </summary>
            Clear = 3,
            /// <summary>
            /// <para>Selects the whole <see cref="Godot.LineEdit"/> text.</para>
            /// </summary>
            SelectAll = 4,
            /// <summary>
            /// <para>Undoes the previous action.</para>
            /// </summary>
            Undo = 5,
            /// <summary>
            /// <para>Reverse the last undo action.</para>
            /// </summary>
            Redo = 6,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.LineEdit.MenuItems"/> enum.</para>
            /// </summary>
            Max = 7
        }

        /// <summary>
        /// <para>String value of the <see cref="Godot.LineEdit"/>.</para>
        /// <para>Note: Changing text using this property won't emit the <c>text_changed</c> signal.</para>
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
        /// <para>Text alignment as defined in the <see cref="Godot.LineEdit.AlignEnum"/> enum.</para>
        /// </summary>
        public LineEdit.AlignEnum Align
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
        /// <para>Maximum amount of characters that can be entered inside the <see cref="Godot.LineEdit"/>. If <c>0</c>, there is no limit.</para>
        /// <para>When a limit is defined, characters that would exceed <see cref="Godot.LineEdit.MaxLength"/> are truncated. This happens both for existing <see cref="Godot.LineEdit.Text"/> contents when setting the max length, or for new text inserted in the <see cref="Godot.LineEdit"/>, including pasting. If any input text is truncated, the <c>text_change_rejected</c> signal is emitted with the truncated substring as parameter.</para>
        /// <para>Example:</para>
        /// <para><code>
        /// text = "Hello world"
        /// max_length = 5
        /// # `text` becomes "Hello".
        /// max_length = 10
        /// text += " goodbye"
        /// # `text` becomes "Hello good".
        /// # `text_change_rejected` is emitted with "bye" as parameter.
        /// </code></para>
        /// </summary>
        public int MaxLength
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaxLength();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaxLength(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>false</c>, existing text cannot be modified and new text cannot be added.</para>
        /// </summary>
        public bool Editable
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsEditable();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEditable(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, every character is replaced with the secret character (see <see cref="Godot.LineEdit.SecretCharacter"/>).</para>
        /// </summary>
        public bool Secret
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsSecret();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSecret(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The character to use to mask secret input (defaults to "*"). Only a single character can be used as the secret character.</para>
        /// </summary>
        public string SecretCharacter
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSecretCharacter();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSecretCharacter(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the <see cref="Godot.LineEdit"/> width will increase to stay longer than the <see cref="Godot.LineEdit.Text"/>. It will not compress if the <see cref="Godot.LineEdit.Text"/> is shortened.</para>
        /// </summary>
        public bool ExpandToTextLength
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetExpandToTextLength();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExpandToTextLength(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the context menu will appear when right-clicked.</para>
        /// </summary>
        public bool ContextMenuEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsContextMenuEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetContextMenuEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the native virtual keyboard is shown when focused on platforms that support it.</para>
        /// </summary>
        public bool VirtualKeyboardEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsVirtualKeyboardEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVirtualKeyboardEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the <see cref="Godot.LineEdit"/> will show a clear button if <c>text</c> is not empty, which can be used to clear the text quickly.</para>
        /// </summary>
        public bool ClearButtonEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsClearButtonEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetClearButtonEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>false</c>, using shortcuts will be disabled.</para>
        /// </summary>
        public bool ShortcutKeysEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsShortcutKeysEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShortcutKeysEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>false</c>, using middle mouse button to paste clipboard will be disabled.</para>
        /// <para>Note: This method is only implemented on Linux.</para>
        /// </summary>
        public bool MiddleMousePasteEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsMiddleMousePasteEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMiddleMousePasteEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>false</c>, it's impossible to select the text using mouse nor keyboard.</para>
        /// </summary>
        public bool SelectingEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsSelectingEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSelectingEnabled(value);
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
        /// <para>Sets the icon that will appear in the right end of the <see cref="Godot.LineEdit"/> if there's no <see cref="Godot.LineEdit.Text"/>, or always, if <see cref="Godot.LineEdit.ClearButtonEnabled"/> is set to <c>false</c>.</para>
        /// </summary>
        public Texture RightIcon
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRightIcon();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRightIcon(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Text shown when the <see cref="Godot.LineEdit"/> is empty. It is not the <see cref="Godot.LineEdit"/>'s default value (see <see cref="Godot.LineEdit.Text"/>).</para>
        /// </summary>
        public string PlaceholderText
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPlaceholder();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPlaceholder(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Opacity of the <see cref="Godot.LineEdit.PlaceholderText"/>. From <c>0</c> to <c>1</c>.</para>
        /// </summary>
        public float PlaceholderAlpha
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPlaceholderAlpha();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPlaceholderAlpha(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the caret (visual cursor) blinks.</para>
        /// </summary>
        public bool CaretBlink
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return CursorGetBlinkEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                CursorSetBlinkEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Duration (in seconds) of a caret's blinking cycle.</para>
        /// </summary>
        public float CaretBlinkSpeed
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return CursorGetBlinkSpeed();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                CursorSetBlinkSpeed(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The cursor's position inside the <see cref="Godot.LineEdit"/>. When set, the text may scroll to accommodate it.</para>
        /// </summary>
        public int CaretPosition
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCursorPosition();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCursorPosition(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "LineEdit";

        public LineEdit() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_LineEdit_Ctor(this);
        }

        internal LineEdit(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_align");

        [GodotMethod("set_align")]
        [Obsolete("SetAlign is deprecated. Use the Align property instead.")]
        public void SetAlign(LineEdit.AlignEnum align)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)align);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_align");

        [GodotMethod("get_align")]
        [Obsolete("GetAlign is deprecated. Use the Align property instead.")]
        public LineEdit.AlignEnum GetAlign()
        {
            return (LineEdit.AlignEnum)NativeCalls.godot_icall_0_590(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Erases the <see cref="Godot.LineEdit"/>'s <see cref="Godot.LineEdit.Text"/>.</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "select");

        /// <summary>
        /// <para>Selects characters inside <see cref="Godot.LineEdit"/> between <c>from</c> and <c>to</c>. By default, <c>from</c> is at the beginning and <c>to</c> at the end.</para>
        /// <para><code>
        /// text = "Welcome"
        /// select() # Will select "Welcome".
        /// select(4) # Will select "ome".
        /// select(2, 5) # Will select "lco".
        /// </code></para>
        /// </summary>
        [GodotMethod("select")]
        public void Select(int from = 0, int to = -1)
        {
            NativeCalls.godot_icall_2_65(method_bind_3, Object.GetPtr(this), from, to);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "select_all");

        /// <summary>
        /// <para>Selects the whole <see cref="string"/>.</para>
        /// </summary>
        [GodotMethod("select_all")]
        public void SelectAll()
        {
            NativeCalls.godot_icall_0_3(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "deselect");

        /// <summary>
        /// <para>Clears the current selection.</para>
        /// </summary>
        [GodotMethod("deselect")]
        public void Deselect()
        {
            NativeCalls.godot_icall_0_3(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_selection");

        /// <summary>
        /// <para>Returns <c>true</c> if the user has selected text.</para>
        /// </summary>
        [GodotMethod("has_selection")]
        public bool HasSelection()
        {
            return NativeCalls.godot_icall_0_7(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_selection_from_column");

        /// <summary>
        /// <para>Returns the selection begin column.</para>
        /// </summary>
        [GodotMethod("get_selection_from_column")]
        public int GetSelectionFromColumn()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_selection_to_column");

        /// <summary>
        /// <para>Returns the selection end column.</para>
        /// </summary>
        [GodotMethod("get_selection_to_column")]
        public int GetSelectionToColumn()
        {
            return NativeCalls.godot_icall_0_5(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_text");

        [GodotMethod("set_text")]
        [Obsolete("SetText is deprecated. Use the Text property instead.")]
        public void SetText(string text)
        {
            NativeCalls.godot_icall_1_54(method_bind_9, Object.GetPtr(this), text);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_text");

        [GodotMethod("get_text")]
        [Obsolete("GetText is deprecated. Use the Text property instead.")]
        public string GetText()
        {
            return NativeCalls.godot_icall_0_6(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_placeholder");

        [GodotMethod("set_placeholder")]
        [Obsolete("SetPlaceholder is deprecated. Use the PlaceholderText property instead.")]
        public void SetPlaceholder(string text)
        {
            NativeCalls.godot_icall_1_54(method_bind_11, Object.GetPtr(this), text);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_placeholder");

        [GodotMethod("get_placeholder")]
        [Obsolete("GetPlaceholder is deprecated. Use the PlaceholderText property instead.")]
        public string GetPlaceholder()
        {
            return NativeCalls.godot_icall_0_6(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_placeholder_alpha");

        [GodotMethod("set_placeholder_alpha")]
        [Obsolete("SetPlaceholderAlpha is deprecated. Use the PlaceholderAlpha property instead.")]
        public void SetPlaceholderAlpha(float alpha)
        {
            NativeCalls.godot_icall_1_15(method_bind_13, Object.GetPtr(this), alpha);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_placeholder_alpha");

        [GodotMethod("get_placeholder_alpha")]
        [Obsolete("GetPlaceholderAlpha is deprecated. Use the PlaceholderAlpha property instead.")]
        public float GetPlaceholderAlpha()
        {
            return NativeCalls.godot_icall_0_14(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cursor_position");

        [GodotMethod("set_cursor_position")]
        [Obsolete("SetCursorPosition is deprecated. Use the CaretPosition property instead.")]
        public void SetCursorPosition(int position)
        {
            NativeCalls.godot_icall_1_4(method_bind_15, Object.GetPtr(this), position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cursor_position");

        [GodotMethod("get_cursor_position")]
        [Obsolete("GetCursorPosition is deprecated. Use the CaretPosition property instead.")]
        public int GetCursorPosition()
        {
            return NativeCalls.godot_icall_0_5(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_scroll_offset");

        /// <summary>
        /// <para>Returns the scroll offset due to <see cref="Godot.LineEdit.CaretPosition"/>, as a number of characters.</para>
        /// </summary>
        [GodotMethod("get_scroll_offset")]
        public int GetScrollOffset()
        {
            return NativeCalls.godot_icall_0_5(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_expand_to_text_length");

        [GodotMethod("set_expand_to_text_length")]
        [Obsolete("SetExpandToTextLength is deprecated. Use the ExpandToTextLength property instead.")]
        public void SetExpandToTextLength(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_18, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_expand_to_text_length");

        [GodotMethod("get_expand_to_text_length")]
        [Obsolete("GetExpandToTextLength is deprecated. Use the ExpandToTextLength property instead.")]
        public bool GetExpandToTextLength()
        {
            return NativeCalls.godot_icall_0_7(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "cursor_set_blink_enabled");

        [GodotMethod("cursor_set_blink_enabled")]
        [Obsolete("CursorSetBlinkEnabled is deprecated. Use the CaretBlink property instead.")]
        public void CursorSetBlinkEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_20, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "cursor_get_blink_enabled");

        [GodotMethod("cursor_get_blink_enabled")]
        [Obsolete("CursorGetBlinkEnabled is deprecated. Use the CaretBlink property instead.")]
        public bool CursorGetBlinkEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "cursor_set_blink_speed");

        [GodotMethod("cursor_set_blink_speed")]
        [Obsolete("CursorSetBlinkSpeed is deprecated. Use the CaretBlinkSpeed property instead.")]
        public void CursorSetBlinkSpeed(float blinkSpeed)
        {
            NativeCalls.godot_icall_1_15(method_bind_22, Object.GetPtr(this), blinkSpeed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "cursor_get_blink_speed");

        [GodotMethod("cursor_get_blink_speed")]
        [Obsolete("CursorGetBlinkSpeed is deprecated. Use the CaretBlinkSpeed property instead.")]
        public float CursorGetBlinkSpeed()
        {
            return NativeCalls.godot_icall_0_14(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max_length");

        [GodotMethod("set_max_length")]
        [Obsolete("SetMaxLength is deprecated. Use the MaxLength property instead.")]
        public void SetMaxLength(int chars)
        {
            NativeCalls.godot_icall_1_4(method_bind_24, Object.GetPtr(this), chars);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max_length");

        [GodotMethod("get_max_length")]
        [Obsolete("GetMaxLength is deprecated. Use the MaxLength property instead.")]
        public int GetMaxLength()
        {
            return NativeCalls.godot_icall_0_5(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "append_at_cursor");

        /// <summary>
        /// <para>Adds <c>text</c> after the cursor. If the resulting value is longer than <see cref="Godot.LineEdit.MaxLength"/>, nothing happens.</para>
        /// </summary>
        [GodotMethod("append_at_cursor")]
        public void AppendAtCursor(string text)
        {
            NativeCalls.godot_icall_1_54(method_bind_26, Object.GetPtr(this), text);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "delete_char_at_cursor");

        /// <summary>
        /// <para>Deletes one character at the cursor's current position (equivalent to pressing the <c>Delete</c> key).</para>
        /// </summary>
        [GodotMethod("delete_char_at_cursor")]
        public void DeleteCharAtCursor()
        {
            NativeCalls.godot_icall_0_3(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "delete_text");

        /// <summary>
        /// <para>Deletes a section of the <see cref="Godot.LineEdit.Text"/> going from position <c>from_column</c> to <c>to_column</c>. Both parameters should be within the text's length.</para>
        /// </summary>
        [GodotMethod("delete_text")]
        public void DeleteText(int fromColumn, int toColumn)
        {
            NativeCalls.godot_icall_2_65(method_bind_28, Object.GetPtr(this), fromColumn, toColumn);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_editable");

        [GodotMethod("set_editable")]
        [Obsolete("SetEditable is deprecated. Use the Editable property instead.")]
        public void SetEditable(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_29, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_editable");

        [GodotMethod("is_editable")]
        [Obsolete("IsEditable is deprecated. Use the Editable property instead.")]
        public bool IsEditable()
        {
            return NativeCalls.godot_icall_0_7(method_bind_30, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_secret");

        [GodotMethod("set_secret")]
        [Obsolete("SetSecret is deprecated. Use the Secret property instead.")]
        public void SetSecret(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_31, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_secret");

        [GodotMethod("is_secret")]
        [Obsolete("IsSecret is deprecated. Use the Secret property instead.")]
        public bool IsSecret()
        {
            return NativeCalls.godot_icall_0_7(method_bind_32, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_secret_character");

        [GodotMethod("set_secret_character")]
        [Obsolete("SetSecretCharacter is deprecated. Use the SecretCharacter property instead.")]
        public void SetSecretCharacter(string character)
        {
            NativeCalls.godot_icall_1_54(method_bind_33, Object.GetPtr(this), character);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_secret_character");

        [GodotMethod("get_secret_character")]
        [Obsolete("GetSecretCharacter is deprecated. Use the SecretCharacter property instead.")]
        public string GetSecretCharacter()
        {
            return NativeCalls.godot_icall_0_6(method_bind_34, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "menu_option");

        /// <summary>
        /// <para>Executes a given action as defined in the <see cref="Godot.LineEdit.MenuItems"/> enum.</para>
        /// </summary>
        [GodotMethod("menu_option")]
        public void MenuOption(int option)
        {
            NativeCalls.godot_icall_1_4(method_bind_35, Object.GetPtr(this), option);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_menu");

        /// <summary>
        /// <para>Returns the <see cref="Godot.PopupMenu"/> of this <see cref="Godot.LineEdit"/>. By default, this menu is displayed when right-clicking on the <see cref="Godot.LineEdit"/>.</para>
        /// <para>Warning: This is a required internal node, removing and freeing it may cause a crash. If you wish to hide it or any of its children, use their <see cref="Godot.CanvasItem.Visible"/> property.</para>
        /// </summary>
        [GodotMethod("get_menu")]
        public PopupMenu GetMenu()
        {
            return NativeCalls.godot_icall_0_591(method_bind_36, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_context_menu_enabled");

        [GodotMethod("set_context_menu_enabled")]
        [Obsolete("SetContextMenuEnabled is deprecated. Use the ContextMenuEnabled property instead.")]
        public void SetContextMenuEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_37, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_context_menu_enabled");

        [GodotMethod("is_context_menu_enabled")]
        [Obsolete("IsContextMenuEnabled is deprecated. Use the ContextMenuEnabled property instead.")]
        public bool IsContextMenuEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_38, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_virtual_keyboard_enabled");

        [GodotMethod("set_virtual_keyboard_enabled")]
        [Obsolete("SetVirtualKeyboardEnabled is deprecated. Use the VirtualKeyboardEnabled property instead.")]
        public void SetVirtualKeyboardEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_39, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_virtual_keyboard_enabled");

        [GodotMethod("is_virtual_keyboard_enabled")]
        [Obsolete("IsVirtualKeyboardEnabled is deprecated. Use the VirtualKeyboardEnabled property instead.")]
        public bool IsVirtualKeyboardEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_40, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_clear_button_enabled");

        [GodotMethod("set_clear_button_enabled")]
        [Obsolete("SetClearButtonEnabled is deprecated. Use the ClearButtonEnabled property instead.")]
        public void SetClearButtonEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_41, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_clear_button_enabled");

        [GodotMethod("is_clear_button_enabled")]
        [Obsolete("IsClearButtonEnabled is deprecated. Use the ClearButtonEnabled property instead.")]
        public bool IsClearButtonEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_42, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shortcut_keys_enabled");

        [GodotMethod("set_shortcut_keys_enabled")]
        [Obsolete("SetShortcutKeysEnabled is deprecated. Use the ShortcutKeysEnabled property instead.")]
        public void SetShortcutKeysEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_43, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_shortcut_keys_enabled");

        [GodotMethod("is_shortcut_keys_enabled")]
        [Obsolete("IsShortcutKeysEnabled is deprecated. Use the ShortcutKeysEnabled property instead.")]
        public bool IsShortcutKeysEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_44, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_middle_mouse_paste_enabled");

        [GodotMethod("set_middle_mouse_paste_enabled")]
        [Obsolete("SetMiddleMousePasteEnabled is deprecated. Use the MiddleMousePasteEnabled property instead.")]
        public void SetMiddleMousePasteEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_45, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_middle_mouse_paste_enabled");

        [GodotMethod("is_middle_mouse_paste_enabled")]
        [Obsolete("IsMiddleMousePasteEnabled is deprecated. Use the MiddleMousePasteEnabled property instead.")]
        public bool IsMiddleMousePasteEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_46, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_selecting_enabled");

        [GodotMethod("set_selecting_enabled")]
        [Obsolete("SetSelectingEnabled is deprecated. Use the SelectingEnabled property instead.")]
        public void SetSelectingEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_47, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_selecting_enabled");

        [GodotMethod("is_selecting_enabled")]
        [Obsolete("IsSelectingEnabled is deprecated. Use the SelectingEnabled property instead.")]
        public bool IsSelectingEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_48, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_deselect_on_focus_loss_enabled");

        [GodotMethod("set_deselect_on_focus_loss_enabled")]
        [Obsolete("SetDeselectOnFocusLossEnabled is deprecated. Use the DeselectOnFocusLossEnabled property instead.")]
        public void SetDeselectOnFocusLossEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_49, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_deselect_on_focus_loss_enabled");

        [GodotMethod("is_deselect_on_focus_loss_enabled")]
        [Obsolete("IsDeselectOnFocusLossEnabled is deprecated. Use the DeselectOnFocusLossEnabled property instead.")]
        public bool IsDeselectOnFocusLossEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_50, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_right_icon");

        [GodotMethod("set_right_icon")]
        [Obsolete("SetRightIcon is deprecated. Use the RightIcon property instead.")]
        public void SetRightIcon(Texture icon)
        {
            NativeCalls.godot_icall_1_24(method_bind_51, Object.GetPtr(this), Object.GetPtr(icon));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_right_icon");

        [GodotMethod("get_right_icon")]
        [Obsolete("GetRightIcon is deprecated. Use the RightIcon property instead.")]
        public Texture GetRightIcon()
        {
            return NativeCalls.godot_icall_0_161(method_bind_52, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
