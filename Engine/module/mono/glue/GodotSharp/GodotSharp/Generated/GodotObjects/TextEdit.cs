using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>TextEdit is meant for editing large, multiline text. It also has facilities for editing code, such as syntax highlighting support and multiple levels of undo/redo.</para>
    /// <para>Note: When holding down <c>Alt</c>, the vertical scroll wheel will scroll 5 times as fast as it would normally do. This also works in the Godot script editor.</para>
    /// </summary>
    public partial class TextEdit : Control
    {
        public enum SearchFlags
        {
            /// <summary>
            /// <para>Match case when searching.</para>
            /// </summary>
            MatchCase = 1,
            /// <summary>
            /// <para>Match whole words when searching.</para>
            /// </summary>
            WholeWords = 2,
            /// <summary>
            /// <para>Search from end to beginning.</para>
            /// </summary>
            Backwards = 4
        }

        public enum SearchResult
        {
            /// <summary>
            /// <para>Used to access the result column from <see cref="Godot.TextEdit.Search"/>.</para>
            /// </summary>
            Column = 0,
            /// <summary>
            /// <para>Used to access the result line from <see cref="Godot.TextEdit.Search"/>.</para>
            /// </summary>
            Line = 1
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
            /// </summary>
            Paste = 2,
            /// <summary>
            /// <para>Erases the whole <see cref="Godot.TextEdit"/> text.</para>
            /// </summary>
            Clear = 3,
            /// <summary>
            /// <para>Selects the whole <see cref="Godot.TextEdit"/> text.</para>
            /// </summary>
            SelectAll = 4,
            /// <summary>
            /// <para>Undoes the previous action.</para>
            /// </summary>
            Undo = 5,
            /// <summary>
            /// <para>Redoes the previous action.</para>
            /// </summary>
            Redo = 6,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.TextEdit.MenuItems"/> enum.</para>
            /// </summary>
            Max = 7
        }

        /// <summary>
        /// <para>String value of the <see cref="Godot.TextEdit"/>.</para>
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
        /// <para>If <c>true</c>, read-only mode is enabled. Existing text cannot be modified and new text cannot be added.</para>
        /// </summary>
        public bool Readonly
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsReadonly();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetReadonly(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the line containing the cursor is highlighted.</para>
        /// </summary>
        public bool HighlightCurrentLine
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsHighlightCurrentLineEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHighlightCurrentLine(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, any custom color properties that have been set for this <see cref="Godot.TextEdit"/> will be visible.</para>
        /// </summary>
        public bool SyntaxHighlighting
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsSyntaxColoringEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSyntaxColoring(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, line numbers are displayed to the left of the text.</para>
        /// </summary>
        public bool ShowLineNumbers
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsShowLineNumbersEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShowLineNumbers(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the "tab" character will have a visible representation.</para>
        /// </summary>
        public bool DrawTabs
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDrawingTabs();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDrawTabs(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the "space" character will have a visible representation.</para>
        /// </summary>
        public bool DrawSpaces
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDrawingSpaces();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDrawSpaces(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the bookmark gutter is visible.</para>
        /// </summary>
        public bool BookmarkGutter
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsBookmarkGutterEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBookmarkGutterEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the breakpoint gutter is visible.</para>
        /// </summary>
        public bool BreakpointGutter
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsBreakpointGutterEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBreakpointGutterEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the fold gutter is visible. This enables folding groups of indented lines.</para>
        /// </summary>
        public bool FoldGutter
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDrawingFoldGutter();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDrawFoldGutter(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, all occurrences of the selected text will be highlighted.</para>
        /// </summary>
        public bool HighlightAllOccurrences
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsHighlightAllOccurrencesEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHighlightAllOccurrences(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, custom <c>font_color_selected</c> will be used for selected text.</para>
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
        /// <para>If <c>true</c>, a right-click displays the context menu.</para>
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
        /// <para>If <c>true</c>, shortcut keys for context menu items are enabled, even if the context menu is disabled.</para>
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
        /// <para>If <c>true</c>, text can be selected.</para>
        /// <para>If <c>false</c>, text can not be selected by the user or by the <see cref="Godot.TextEdit.Select"/> or <see cref="Godot.TextEdit.SelectAll"/> methods.</para>
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
        /// <para>If <c>true</c>, allow drag and drop of selected text.</para>
        /// </summary>
        public bool DragAndDropSelectionEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDragAndDropSelectionEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDragAndDropSelectionEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, sets the <c>step</c> of the scrollbars to <c>0.25</c> which results in smoother scrolling.</para>
        /// </summary>
        public bool SmoothScrolling
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsSmoothScrollEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSmoothScrollEnable(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Vertical scroll sensitivity.</para>
        /// </summary>
        public float VScrollSpeed
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVScrollSpeed();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVScrollSpeed(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, all lines that have been set to hidden by <see cref="Godot.TextEdit.SetLineAsHidden"/>, will not be visible.</para>
        /// </summary>
        public bool HidingEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsHidingEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHidingEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, enables text wrapping when it goes beyond the edge of what is visible.</para>
        /// </summary>
        public bool WrapEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsWrapEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetWrapEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If there is a vertical scrollbar, this determines the current vertical scroll value in line numbers, starting at 0 for the top line.</para>
        /// </summary>
        public double ScrollVertical
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVScroll();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVScroll(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If there is a horizontal scrollbar, this determines the current horizontal scroll value in pixels.</para>
        /// </summary>
        public int ScrollHorizontal
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHScroll();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHScroll(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, a minimap is shown, providing an outline of your source code.</para>
        /// </summary>
        public bool MinimapDraw
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDrawingMinimap();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                DrawMinimap(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The width, in pixels, of the minimap.</para>
        /// </summary>
        public int MinimapWidth
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMinimapWidth();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMinimapWidth(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the caret displays as a rectangle.</para>
        /// <para>If <c>false</c>, the caret displays as a bar.</para>
        /// </summary>
        public bool CaretBlockMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return CursorIsBlockMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                CursorSetBlockMode(value);
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
        /// <para>If <c>true</c>, a right-click moves the cursor at the mouse position before displaying the context menu.</para>
        /// <para>If <c>false</c>, the context menu disregards mouse location.</para>
        /// </summary>
        public bool CaretMovingByRightClick
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsRightClickMovingCaret();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRightClickMovesCaret(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "TextEdit";

        public TextEdit() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_TextEdit_Ctor(this);
        }

        internal TextEdit(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_text");

        [GodotMethod("set_text")]
        [Obsolete("SetText is deprecated. Use the Text property instead.")]
        public void SetText(string text)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), text);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "insert_text_at_cursor");

        /// <summary>
        /// <para>Insert the specified text at the cursor position.</para>
        /// </summary>
        [GodotMethod("insert_text_at_cursor")]
        public void InsertTextAtCursor(string text)
        {
            NativeCalls.godot_icall_1_54(method_bind_1, Object.GetPtr(this), text);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_line_count");

        /// <summary>
        /// <para>Returns the amount of total lines in the text.</para>
        /// </summary>
        [GodotMethod("get_line_count")]
        public int GetLineCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_text");

        [GodotMethod("get_text")]
        [Obsolete("GetText is deprecated. Use the Text property instead.")]
        public string GetText()
        {
            return NativeCalls.godot_icall_0_6(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_line");

        /// <summary>
        /// <para>Returns the text of a specific line.</para>
        /// </summary>
        [GodotMethod("get_line")]
        public string GetLine(int line)
        {
            return NativeCalls.godot_icall_1_89(method_bind_4, Object.GetPtr(this), line);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_line");

        /// <summary>
        /// <para>Sets the text for a specific line.</para>
        /// </summary>
        [GodotMethod("set_line")]
        public void SetLine(int line, string newText)
        {
            NativeCalls.godot_icall_2_121(method_bind_5, Object.GetPtr(this), line, newText);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_line_wrapped_text");

        /// <summary>
        /// <para>Returns an array of <see cref="string"/>s representing each wrapped index.</para>
        /// </summary>
        [GodotMethod("get_line_wrapped_text")]
        public string[] GetLineWrappedText(int line)
        {
            return NativeCalls.godot_icall_1_832(method_bind_6, Object.GetPtr(this), line);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_line_width");

        /// <summary>
        /// <para>Returns the width in pixels of the <c>wrap_index</c> on <c>line</c>.</para>
        /// </summary>
        [GodotMethod("get_line_width")]
        public int GetLineWidth(int line, int wrapIndex = -1)
        {
            return NativeCalls.godot_icall_2_60(method_bind_7, Object.GetPtr(this), line, wrapIndex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_line_height");

        /// <summary>
        /// <para>Returns the height of a largest line.</para>
        /// </summary>
        [GodotMethod("get_line_height")]
        public int GetLineHeight()
        {
            return NativeCalls.godot_icall_0_5(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_line_wrapped");

        /// <summary>
        /// <para>Returns if the given line is wrapped.</para>
        /// </summary>
        [GodotMethod("is_line_wrapped")]
        public bool IsLineWrapped(int line)
        {
            return NativeCalls.godot_icall_1_35(method_bind_9, Object.GetPtr(this), line);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_line_wrap_count");

        /// <summary>
        /// <para>Returns the number of times the given line is wrapped.</para>
        /// </summary>
        [GodotMethod("get_line_wrap_count")]
        public int GetLineWrapCount(int line)
        {
            return NativeCalls.godot_icall_1_11(method_bind_10, Object.GetPtr(this), line);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "center_viewport_to_cursor");

        /// <summary>
        /// <para>Centers the viewport on the line the editing cursor is at. This also resets the <see cref="Godot.TextEdit.ScrollHorizontal"/> value to <c>0</c>.</para>
        /// </summary>
        [GodotMethod("center_viewport_to_cursor")]
        public void CenterViewportToCursor()
        {
            NativeCalls.godot_icall_0_3(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "cursor_set_column");

        /// <summary>
        /// <para>Moves the cursor at the specified <c>column</c> index.</para>
        /// <para>If <c>adjust_viewport</c> is set to <c>true</c>, the viewport will center at the cursor position after the move occurs.</para>
        /// </summary>
        [GodotMethod("cursor_set_column")]
        public void CursorSetColumn(int column, bool adjustViewport = true)
        {
            NativeCalls.godot_icall_2_23(method_bind_12, Object.GetPtr(this), column, adjustViewport);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "cursor_set_line");

        /// <summary>
        /// <para>Moves the cursor at the specified <c>line</c> index.</para>
        /// <para>If <c>adjust_viewport</c> is set to <c>true</c>, the viewport will center at the cursor position after the move occurs.</para>
        /// <para>If <c>can_be_hidden</c> is set to <c>true</c>, the specified <c>line</c> can be hidden using <see cref="Godot.TextEdit.SetLineAsHidden"/>.</para>
        /// </summary>
        [GodotMethod("cursor_set_line")]
        public void CursorSetLine(int line, bool adjustViewport = true, bool canBeHidden = true, int wrapIndex = 0)
        {
            NativeCalls.godot_icall_4_918(method_bind_13, Object.GetPtr(this), line, adjustViewport, canBeHidden, wrapIndex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "cursor_get_column");

        /// <summary>
        /// <para>Returns the column the editing cursor is at.</para>
        /// </summary>
        [GodotMethod("cursor_get_column")]
        public int CursorGetColumn()
        {
            return NativeCalls.godot_icall_0_5(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "cursor_get_line");

        /// <summary>
        /// <para>Returns the line the editing cursor is at.</para>
        /// </summary>
        [GodotMethod("cursor_get_line")]
        public int CursorGetLine()
        {
            return NativeCalls.godot_icall_0_5(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "cursor_set_blink_enabled");

        [GodotMethod("cursor_set_blink_enabled")]
        [Obsolete("CursorSetBlinkEnabled is deprecated. Use the CaretBlink property instead.")]
        public void CursorSetBlinkEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_16, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "cursor_get_blink_enabled");

        [GodotMethod("cursor_get_blink_enabled")]
        [Obsolete("CursorGetBlinkEnabled is deprecated. Use the CaretBlink property instead.")]
        public bool CursorGetBlinkEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "cursor_set_blink_speed");

        [GodotMethod("cursor_set_blink_speed")]
        [Obsolete("CursorSetBlinkSpeed is deprecated. Use the CaretBlinkSpeed property instead.")]
        public void CursorSetBlinkSpeed(float blinkSpeed)
        {
            NativeCalls.godot_icall_1_15(method_bind_18, Object.GetPtr(this), blinkSpeed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "cursor_get_blink_speed");

        [GodotMethod("cursor_get_blink_speed")]
        [Obsolete("CursorGetBlinkSpeed is deprecated. Use the CaretBlinkSpeed property instead.")]
        public float CursorGetBlinkSpeed()
        {
            return NativeCalls.godot_icall_0_14(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "cursor_set_block_mode");

        [GodotMethod("cursor_set_block_mode")]
        [Obsolete("CursorSetBlockMode is deprecated. Use the CaretBlockMode property instead.")]
        public void CursorSetBlockMode(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_20, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "cursor_is_block_mode");

        [GodotMethod("cursor_is_block_mode")]
        [Obsolete("CursorIsBlockMode is deprecated. Use the CaretBlockMode property instead.")]
        public bool CursorIsBlockMode()
        {
            return NativeCalls.godot_icall_0_7(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_right_click_moves_caret");

        [GodotMethod("set_right_click_moves_caret")]
        [Obsolete("SetRightClickMovesCaret is deprecated. Use the CaretMovingByRightClick property instead.")]
        public void SetRightClickMovesCaret(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_22, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_right_click_moving_caret");

        [GodotMethod("is_right_click_moving_caret")]
        [Obsolete("IsRightClickMovingCaret is deprecated. Use the CaretMovingByRightClick property instead.")]
        public bool IsRightClickMovingCaret()
        {
            return NativeCalls.godot_icall_0_7(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pos_at_line_column");

        /// <summary>
        /// <para>Returns the local position for the given <c>line</c> and <c>column</c>. If <c>x</c> or <c>y</c> of the returned vector equal <c>-1</c>, the position is outside of the viewable area of the control.</para>
        /// <para>Note: The Y position corresponds to the bottom side of the line. Use <see cref="Godot.TextEdit.GetRectAtLineColumn"/> to get the top side position.</para>
        /// </summary>
        [GodotMethod("get_pos_at_line_column")]
        public Vector2 GetPosAtLineColumn(int line, int column)
        {
            NativeCalls.godot_icall_2_82(method_bind_24, Object.GetPtr(this), line, column, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rect_at_line_column");

        /// <summary>
        /// <para>Returns the local position and size for the grapheme at the given <c>line</c> and <c>column</c>. If <c>x</c> or <c>y</c> position of the returned rect equal <c>-1</c>, the position is outside of the viewable area of the control.</para>
        /// <para>Note: The Y position of the returned rect corresponds to the top side of the line, unlike <see cref="Godot.TextEdit.GetPosAtLineColumn"/> which returns the bottom side.</para>
        /// </summary>
        [GodotMethod("get_rect_at_line_column")]
        public Rect2 GetRectAtLineColumn(int line, int column)
        {
            NativeCalls.godot_icall_2_919(method_bind_25, Object.GetPtr(this), line, column, out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_line_column_at_pos");

        /// <summary>
        /// <para>Returns the line and column at the given position. In the returned vector, <c>x</c> is the column, <c>y</c> is the line.</para>
        /// </summary>
        [GodotMethod("get_line_column_at_pos")]
        public Vector2 GetLineColumnAtPos(Vector2 position)
        {
            NativeCalls.godot_icall_1_47(method_bind_26, Object.GetPtr(this), ref position, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_readonly");

        [GodotMethod("set_readonly")]
        [Obsolete("SetReadonly is deprecated. Use the Readonly property instead.")]
        public void SetReadonly(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_27, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_readonly");

        [GodotMethod("is_readonly")]
        [Obsolete("IsReadonly is deprecated. Use the Readonly property instead.")]
        public bool IsReadonly()
        {
            return NativeCalls.godot_icall_0_7(method_bind_28, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_wrap_enabled");

        [GodotMethod("set_wrap_enabled")]
        [Obsolete("SetWrapEnabled is deprecated. Use the WrapEnabled property instead.")]
        public void SetWrapEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_29, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_wrap_enabled");

        [GodotMethod("is_wrap_enabled")]
        [Obsolete("IsWrapEnabled is deprecated. Use the WrapEnabled property instead.")]
        public bool IsWrapEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_30, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_context_menu_enabled");

        [GodotMethod("set_context_menu_enabled")]
        [Obsolete("SetContextMenuEnabled is deprecated. Use the ContextMenuEnabled property instead.")]
        public void SetContextMenuEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_31, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_context_menu_enabled");

        [GodotMethod("is_context_menu_enabled")]
        [Obsolete("IsContextMenuEnabled is deprecated. Use the ContextMenuEnabled property instead.")]
        public bool IsContextMenuEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_32, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shortcut_keys_enabled");

        [GodotMethod("set_shortcut_keys_enabled")]
        [Obsolete("SetShortcutKeysEnabled is deprecated. Use the ShortcutKeysEnabled property instead.")]
        public void SetShortcutKeysEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_33, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_shortcut_keys_enabled");

        [GodotMethod("is_shortcut_keys_enabled")]
        [Obsolete("IsShortcutKeysEnabled is deprecated. Use the ShortcutKeysEnabled property instead.")]
        public bool IsShortcutKeysEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_34, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_virtual_keyboard_enabled");

        [GodotMethod("set_virtual_keyboard_enabled")]
        [Obsolete("SetVirtualKeyboardEnabled is deprecated. Use the VirtualKeyboardEnabled property instead.")]
        public void SetVirtualKeyboardEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_35, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_virtual_keyboard_enabled");

        [GodotMethod("is_virtual_keyboard_enabled")]
        [Obsolete("IsVirtualKeyboardEnabled is deprecated. Use the VirtualKeyboardEnabled property instead.")]
        public bool IsVirtualKeyboardEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_36, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_middle_mouse_paste_enabled");

        [GodotMethod("set_middle_mouse_paste_enabled")]
        [Obsolete("SetMiddleMousePasteEnabled is deprecated. Use the MiddleMousePasteEnabled property instead.")]
        public void SetMiddleMousePasteEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_37, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_middle_mouse_paste_enabled");

        [GodotMethod("is_middle_mouse_paste_enabled")]
        [Obsolete("IsMiddleMousePasteEnabled is deprecated. Use the MiddleMousePasteEnabled property instead.")]
        public bool IsMiddleMousePasteEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_38, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_selecting_enabled");

        [GodotMethod("set_selecting_enabled")]
        [Obsolete("SetSelectingEnabled is deprecated. Use the SelectingEnabled property instead.")]
        public void SetSelectingEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_39, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_selecting_enabled");

        [GodotMethod("is_selecting_enabled")]
        [Obsolete("IsSelectingEnabled is deprecated. Use the SelectingEnabled property instead.")]
        public bool IsSelectingEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_40, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_deselect_on_focus_loss_enabled");

        [GodotMethod("set_deselect_on_focus_loss_enabled")]
        [Obsolete("SetDeselectOnFocusLossEnabled is deprecated. Use the DeselectOnFocusLossEnabled property instead.")]
        public void SetDeselectOnFocusLossEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_41, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_deselect_on_focus_loss_enabled");

        [GodotMethod("is_deselect_on_focus_loss_enabled")]
        [Obsolete("IsDeselectOnFocusLossEnabled is deprecated. Use the DeselectOnFocusLossEnabled property instead.")]
        public bool IsDeselectOnFocusLossEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_42, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_drag_and_drop_selection_enabled");

        [GodotMethod("set_drag_and_drop_selection_enabled")]
        [Obsolete("SetDragAndDropSelectionEnabled is deprecated. Use the DragAndDropSelectionEnabled property instead.")]
        public void SetDragAndDropSelectionEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_43, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_drag_and_drop_selection_enabled");

        [GodotMethod("is_drag_and_drop_selection_enabled")]
        [Obsolete("IsDragAndDropSelectionEnabled is deprecated. Use the DragAndDropSelectionEnabled property instead.")]
        public bool IsDragAndDropSelectionEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_44, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_line_set_as_safe");

        /// <summary>
        /// <para>Returns <c>true</c> when the specified <c>line</c> is marked as safe.</para>
        /// </summary>
        [GodotMethod("is_line_set_as_safe")]
        public bool IsLineSetAsSafe(int line)
        {
            return NativeCalls.godot_icall_1_35(method_bind_45, Object.GetPtr(this), line);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_line_as_safe");

        /// <summary>
        /// <para>If <c>true</c>, marks the <c>line</c> as safe.</para>
        /// <para>This will show the line number with the color provided in the <c>safe_line_number_color</c> theme property.</para>
        /// </summary>
        [GodotMethod("set_line_as_safe")]
        public void SetLineAsSafe(int line, bool safe)
        {
            NativeCalls.godot_icall_2_23(method_bind_46, Object.GetPtr(this), line, safe);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_line_set_as_bookmark");

        /// <summary>
        /// <para>Returns <c>true</c> when the specified <c>line</c> is bookmarked.</para>
        /// </summary>
        [GodotMethod("is_line_set_as_bookmark")]
        public bool IsLineSetAsBookmark(int line)
        {
            return NativeCalls.godot_icall_1_35(method_bind_47, Object.GetPtr(this), line);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_line_as_bookmark");

        /// <summary>
        /// <para>Bookmarks the <c>line</c> if <c>bookmark</c> is <c>true</c>. Deletes the bookmark if <c>bookmark</c> is <c>false</c>.</para>
        /// <para>Bookmarks are shown in the <see cref="Godot.TextEdit.BreakpointGutter"/>.</para>
        /// </summary>
        [GodotMethod("set_line_as_bookmark")]
        public void SetLineAsBookmark(int line, bool bookmark)
        {
            NativeCalls.godot_icall_2_23(method_bind_48, Object.GetPtr(this), line, bookmark);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_line_as_breakpoint");

        /// <summary>
        /// <para>Adds or removes the breakpoint in <c>line</c>. Breakpoints are shown in the <see cref="Godot.TextEdit.BreakpointGutter"/>.</para>
        /// </summary>
        [GodotMethod("set_line_as_breakpoint")]
        public void SetLineAsBreakpoint(int line, bool breakpoint)
        {
            NativeCalls.godot_icall_2_23(method_bind_49, Object.GetPtr(this), line, breakpoint);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_line_set_as_breakpoint");

        /// <summary>
        /// <para>Returns <c>true</c> when the specified <c>line</c> has a breakpoint.</para>
        /// </summary>
        [GodotMethod("is_line_set_as_breakpoint")]
        public bool IsLineSetAsBreakpoint(int line)
        {
            return NativeCalls.godot_icall_1_35(method_bind_50, Object.GetPtr(this), line);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "cut");

        /// <summary>
        /// <para>Cut's the current selection.</para>
        /// </summary>
        [GodotMethod("cut")]
        public void Cut()
        {
            NativeCalls.godot_icall_0_3(method_bind_51, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "copy");

        /// <summary>
        /// <para>Copy's the current text selection.</para>
        /// </summary>
        [GodotMethod("copy")]
        public void Copy()
        {
            NativeCalls.godot_icall_0_3(method_bind_52, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_53 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "paste");

        /// <summary>
        /// <para>Paste the current selection.</para>
        /// </summary>
        [GodotMethod("paste")]
        public void Paste()
        {
            NativeCalls.godot_icall_0_3(method_bind_53, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_54 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "select");

        /// <summary>
        /// <para>Perform selection, from line/column to line/column.</para>
        /// <para>If <see cref="Godot.TextEdit.SelectingEnabled"/> is <c>false</c>, no selection will occur.</para>
        /// </summary>
        [GodotMethod("select")]
        public void Select(int fromLine, int fromColumn, int toLine, int toColumn)
        {
            NativeCalls.godot_icall_4_101(method_bind_54, Object.GetPtr(this), fromLine, fromColumn, toLine, toColumn);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_55 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "select_all");

        /// <summary>
        /// <para>Select all the text.</para>
        /// <para>If <see cref="Godot.TextEdit.SelectingEnabled"/> is <c>false</c>, no selection will occur.</para>
        /// </summary>
        [GodotMethod("select_all")]
        public void SelectAll()
        {
            NativeCalls.godot_icall_0_3(method_bind_55, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_56 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "deselect");

        /// <summary>
        /// <para>Deselects the current selection.</para>
        /// </summary>
        [GodotMethod("deselect")]
        public void Deselect()
        {
            NativeCalls.godot_icall_0_3(method_bind_56, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_57 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_selection_active");

        /// <summary>
        /// <para>Returns <c>true</c> if the selection is active.</para>
        /// </summary>
        [GodotMethod("is_selection_active")]
        public bool IsSelectionActive()
        {
            return NativeCalls.godot_icall_0_7(method_bind_57, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_58 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_selection_from_line");

        /// <summary>
        /// <para>Returns the selection begin line.</para>
        /// </summary>
        [GodotMethod("get_selection_from_line")]
        public int GetSelectionFromLine()
        {
            return NativeCalls.godot_icall_0_5(method_bind_58, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_59 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_selection_from_column");

        /// <summary>
        /// <para>Returns the selection begin column.</para>
        /// </summary>
        [GodotMethod("get_selection_from_column")]
        public int GetSelectionFromColumn()
        {
            return NativeCalls.godot_icall_0_5(method_bind_59, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_60 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_selection_to_line");

        /// <summary>
        /// <para>Returns the selection end line.</para>
        /// </summary>
        [GodotMethod("get_selection_to_line")]
        public int GetSelectionToLine()
        {
            return NativeCalls.godot_icall_0_5(method_bind_60, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_61 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_selection_to_column");

        /// <summary>
        /// <para>Returns the selection end column.</para>
        /// </summary>
        [GodotMethod("get_selection_to_column")]
        public int GetSelectionToColumn()
        {
            return NativeCalls.godot_icall_0_5(method_bind_61, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_62 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_selection_text");

        /// <summary>
        /// <para>Returns the text inside the selection.</para>
        /// </summary>
        [GodotMethod("get_selection_text")]
        public string GetSelectionText()
        {
            return NativeCalls.godot_icall_0_6(method_bind_62, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_63 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_mouse_over_selection");

        /// <summary>
        /// <para>Returns whether the mouse is over selection. If <c>edges</c> is <c>true</c>, the edges are considered part of the selection.</para>
        /// </summary>
        [GodotMethod("is_mouse_over_selection")]
        public bool IsMouseOverSelection(bool edges)
        {
            return NativeCalls.godot_icall_1_448(method_bind_63, Object.GetPtr(this), edges);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_64 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_word_under_cursor");

        /// <summary>
        /// <para>Returns a <see cref="string"/> text with the word under the caret (text cursor) location.</para>
        /// </summary>
        [GodotMethod("get_word_under_cursor")]
        public string GetWordUnderCursor()
        {
            return NativeCalls.godot_icall_0_6(method_bind_64, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_65 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "search");

        /// <summary>
        /// <para>Perform a search inside the text. Search flags can be specified in the <see cref="Godot.TextEdit.SearchFlags"/> enum.</para>
        /// <para>Returns an empty <c>PoolIntArray</c> if no result was found. Otherwise, the result line and column can be accessed at indices specified in the <see cref="Godot.TextEdit.SearchResult"/> enum, e.g:</para>
        /// <para><code>
        /// var result = search(key, flags, line, column)
        /// if result.size() &gt; 0:
        ///     # Result found.
        ///     var res_line = result[TextEdit.SEARCH_RESULT_LINE]
        ///     var res_column = result[TextEdit.SEARCH_RESULT_COLUMN]
        /// </code></para>
        /// </summary>
        [GodotMethod("search")]
        public int[] Search(string key, uint flags, int fromLine, int fromColumn)
        {
            return NativeCalls.godot_icall_4_920(method_bind_65, Object.GetPtr(this), key, flags, fromLine, fromColumn);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_66 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_undo");

        /// <summary>
        /// <para>Returns <c>true</c> if an "undo" action is available.</para>
        /// </summary>
        [GodotMethod("has_undo")]
        public bool HasUndo()
        {
            return NativeCalls.godot_icall_0_7(method_bind_66, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_67 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_redo");

        /// <summary>
        /// <para>Returns <c>true</c> if a "redo" action is available.</para>
        /// </summary>
        [GodotMethod("has_redo")]
        public bool HasRedo()
        {
            return NativeCalls.godot_icall_0_7(method_bind_67, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_68 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "undo");

        /// <summary>
        /// <para>Perform undo operation.</para>
        /// </summary>
        [GodotMethod("undo")]
        public void Undo()
        {
            NativeCalls.godot_icall_0_3(method_bind_68, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_69 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "redo");

        /// <summary>
        /// <para>Perform redo operation.</para>
        /// </summary>
        [GodotMethod("redo")]
        public void Redo()
        {
            NativeCalls.godot_icall_0_3(method_bind_69, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_70 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_undo_history");

        /// <summary>
        /// <para>Clears the undo history.</para>
        /// </summary>
        [GodotMethod("clear_undo_history")]
        public void ClearUndoHistory()
        {
            NativeCalls.godot_icall_0_3(method_bind_70, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_71 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_show_line_numbers");

        [GodotMethod("set_show_line_numbers")]
        [Obsolete("SetShowLineNumbers is deprecated. Use the ShowLineNumbers property instead.")]
        public void SetShowLineNumbers(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_71, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_72 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_show_line_numbers_enabled");

        [GodotMethod("is_show_line_numbers_enabled")]
        [Obsolete("IsShowLineNumbersEnabled is deprecated. Use the ShowLineNumbers property instead.")]
        public bool IsShowLineNumbersEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_72, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_73 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_draw_tabs");

        [GodotMethod("set_draw_tabs")]
        [Obsolete("SetDrawTabs is deprecated. Use the DrawTabs property instead.")]
        public void SetDrawTabs(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_73, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_74 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_drawing_tabs");

        [GodotMethod("is_drawing_tabs")]
        [Obsolete("IsDrawingTabs is deprecated. Use the DrawTabs property instead.")]
        public bool IsDrawingTabs()
        {
            return NativeCalls.godot_icall_0_7(method_bind_74, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_75 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_draw_spaces");

        [GodotMethod("set_draw_spaces")]
        [Obsolete("SetDrawSpaces is deprecated. Use the DrawSpaces property instead.")]
        public void SetDrawSpaces(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_75, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_76 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_drawing_spaces");

        [GodotMethod("is_drawing_spaces")]
        [Obsolete("IsDrawingSpaces is deprecated. Use the DrawSpaces property instead.")]
        public bool IsDrawingSpaces()
        {
            return NativeCalls.godot_icall_0_7(method_bind_76, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_77 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bookmark_gutter_enabled");

        [GodotMethod("set_bookmark_gutter_enabled")]
        [Obsolete("SetBookmarkGutterEnabled is deprecated. Use the BookmarkGutter property instead.")]
        public void SetBookmarkGutterEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_77, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_78 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_bookmark_gutter_enabled");

        [GodotMethod("is_bookmark_gutter_enabled")]
        [Obsolete("IsBookmarkGutterEnabled is deprecated. Use the BookmarkGutter property instead.")]
        public bool IsBookmarkGutterEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_78, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_79 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_breakpoint_gutter_enabled");

        [GodotMethod("set_breakpoint_gutter_enabled")]
        [Obsolete("SetBreakpointGutterEnabled is deprecated. Use the BreakpointGutter property instead.")]
        public void SetBreakpointGutterEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_79, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_80 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_breakpoint_gutter_enabled");

        [GodotMethod("is_breakpoint_gutter_enabled")]
        [Obsolete("IsBreakpointGutterEnabled is deprecated. Use the BreakpointGutter property instead.")]
        public bool IsBreakpointGutterEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_80, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_81 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_draw_fold_gutter");

        [GodotMethod("set_draw_fold_gutter")]
        [Obsolete("SetDrawFoldGutter is deprecated. Use the FoldGutter property instead.")]
        public void SetDrawFoldGutter(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_81, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_82 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_drawing_fold_gutter");

        [GodotMethod("is_drawing_fold_gutter")]
        [Obsolete("IsDrawingFoldGutter is deprecated. Use the FoldGutter property instead.")]
        public bool IsDrawingFoldGutter()
        {
            return NativeCalls.godot_icall_0_7(method_bind_82, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_83 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_total_gutter_width");

        /// <summary>
        /// <para>Returns the total width of all gutters and internal padding.</para>
        /// </summary>
        [GodotMethod("get_total_gutter_width")]
        public int GetTotalGutterWidth()
        {
            return NativeCalls.godot_icall_0_5(method_bind_83, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_84 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_visible_rows");

        /// <summary>
        /// <para>Returns the number of visible lines, including wrapped text.</para>
        /// </summary>
        [GodotMethod("get_visible_rows")]
        public int GetVisibleRows()
        {
            return NativeCalls.godot_icall_0_5(method_bind_84, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_85 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_total_visible_rows");

        /// <summary>
        /// <para>Returns the total amount of lines that could be drawn.</para>
        /// </summary>
        [GodotMethod("get_total_visible_rows")]
        public int GetTotalVisibleRows()
        {
            return NativeCalls.godot_icall_0_5(method_bind_85, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_86 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_hiding_enabled");

        [GodotMethod("set_hiding_enabled")]
        [Obsolete("SetHidingEnabled is deprecated. Use the HidingEnabled property instead.")]
        public void SetHidingEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_86, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_87 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_hiding_enabled");

        [GodotMethod("is_hiding_enabled")]
        [Obsolete("IsHidingEnabled is deprecated. Use the HidingEnabled property instead.")]
        public bool IsHidingEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_87, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_88 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_line_as_hidden");

        /// <summary>
        /// <para>If <c>true</c>, hides the line of the specified index.</para>
        /// </summary>
        [GodotMethod("set_line_as_hidden")]
        public void SetLineAsHidden(int line, bool enable)
        {
            NativeCalls.godot_icall_2_23(method_bind_88, Object.GetPtr(this), line, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_89 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_line_hidden");

        /// <summary>
        /// <para>Returns whether the line at the specified index is hidden or not.</para>
        /// </summary>
        [GodotMethod("is_line_hidden")]
        public bool IsLineHidden(int line)
        {
            return NativeCalls.godot_icall_1_35(method_bind_89, Object.GetPtr(this), line);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_90 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "fold_all_lines");

        /// <summary>
        /// <para>Folds all lines that are possible to be folded (see <see cref="Godot.TextEdit.CanFold"/>).</para>
        /// </summary>
        [GodotMethod("fold_all_lines")]
        public void FoldAllLines()
        {
            NativeCalls.godot_icall_0_3(method_bind_90, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_91 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "unhide_all_lines");

        /// <summary>
        /// <para>Unhide all lines that were previously set to hidden by <see cref="Godot.TextEdit.SetLineAsHidden"/>.</para>
        /// </summary>
        [GodotMethod("unhide_all_lines")]
        public void UnhideAllLines()
        {
            NativeCalls.godot_icall_0_3(method_bind_91, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_92 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "fold_line");

        /// <summary>
        /// <para>Folds the given line, if possible (see <see cref="Godot.TextEdit.CanFold"/>).</para>
        /// </summary>
        [GodotMethod("fold_line")]
        public void FoldLine(int line)
        {
            NativeCalls.godot_icall_1_4(method_bind_92, Object.GetPtr(this), line);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_93 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "unfold_line");

        /// <summary>
        /// <para>Unfolds the given line, if folded.</para>
        /// </summary>
        [GodotMethod("unfold_line")]
        public void UnfoldLine(int line)
        {
            NativeCalls.godot_icall_1_4(method_bind_93, Object.GetPtr(this), line);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_94 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "toggle_fold_line");

        /// <summary>
        /// <para>Toggle the folding of the code block at the given line.</para>
        /// </summary>
        [GodotMethod("toggle_fold_line")]
        public void ToggleFoldLine(int line)
        {
            NativeCalls.godot_icall_1_4(method_bind_94, Object.GetPtr(this), line);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_95 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "can_fold");

        /// <summary>
        /// <para>Returns if the given line is foldable, that is, it has indented lines right below it.</para>
        /// </summary>
        [GodotMethod("can_fold")]
        public bool CanFold(int line)
        {
            return NativeCalls.godot_icall_1_35(method_bind_95, Object.GetPtr(this), line);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_96 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_folded");

        /// <summary>
        /// <para>Returns whether the line at the specified index is folded or not.</para>
        /// </summary>
        [GodotMethod("is_folded")]
        public bool IsFolded(int line)
        {
            return NativeCalls.godot_icall_1_35(method_bind_96, Object.GetPtr(this), line);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_97 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_highlight_all_occurrences");

        [GodotMethod("set_highlight_all_occurrences")]
        [Obsolete("SetHighlightAllOccurrences is deprecated. Use the HighlightAllOccurrences property instead.")]
        public void SetHighlightAllOccurrences(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_97, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_98 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_highlight_all_occurrences_enabled");

        [GodotMethod("is_highlight_all_occurrences_enabled")]
        [Obsolete("IsHighlightAllOccurrencesEnabled is deprecated. Use the HighlightAllOccurrences property instead.")]
        public bool IsHighlightAllOccurrencesEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_98, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_99 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_override_selected_font_color");

        [GodotMethod("set_override_selected_font_color")]
        [Obsolete("SetOverrideSelectedFontColor is deprecated. Use the OverrideSelectedFontColor property instead.")]
        public void SetOverrideSelectedFontColor(bool @override)
        {
            NativeCalls.godot_icall_1_16(method_bind_99, Object.GetPtr(this), @override);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_100 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_overriding_selected_font_color");

        [GodotMethod("is_overriding_selected_font_color")]
        [Obsolete("IsOverridingSelectedFontColor is deprecated. Use the OverrideSelectedFontColor property instead.")]
        public bool IsOverridingSelectedFontColor()
        {
            return NativeCalls.godot_icall_0_7(method_bind_100, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_101 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_syntax_coloring");

        [GodotMethod("set_syntax_coloring")]
        [Obsolete("SetSyntaxColoring is deprecated. Use the SyntaxHighlighting property instead.")]
        public void SetSyntaxColoring(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_101, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_102 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_syntax_coloring_enabled");

        [GodotMethod("is_syntax_coloring_enabled")]
        [Obsolete("IsSyntaxColoringEnabled is deprecated. Use the SyntaxHighlighting property instead.")]
        public bool IsSyntaxColoringEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_102, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_103 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_highlight_current_line");

        [GodotMethod("set_highlight_current_line")]
        [Obsolete("SetHighlightCurrentLine is deprecated. Use the HighlightCurrentLine property instead.")]
        public void SetHighlightCurrentLine(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_103, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_104 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_highlight_current_line_enabled");

        [GodotMethod("is_highlight_current_line_enabled")]
        [Obsolete("IsHighlightCurrentLineEnabled is deprecated. Use the HighlightCurrentLine property instead.")]
        public bool IsHighlightCurrentLineEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_104, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_105 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_smooth_scroll_enable");

        [GodotMethod("set_smooth_scroll_enable")]
        [Obsolete("SetSmoothScrollEnable is deprecated. Use the SmoothScrolling property instead.")]
        public void SetSmoothScrollEnable(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_105, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_106 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_smooth_scroll_enabled");

        [GodotMethod("is_smooth_scroll_enabled")]
        [Obsolete("IsSmoothScrollEnabled is deprecated. Use the SmoothScrolling property instead.")]
        public bool IsSmoothScrollEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_106, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_107 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_v_scroll_speed");

        [GodotMethod("set_v_scroll_speed")]
        [Obsolete("SetVScrollSpeed is deprecated. Use the VScrollSpeed property instead.")]
        public void SetVScrollSpeed(float speed)
        {
            NativeCalls.godot_icall_1_15(method_bind_107, Object.GetPtr(this), speed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_108 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_v_scroll_speed");

        [GodotMethod("get_v_scroll_speed")]
        [Obsolete("GetVScrollSpeed is deprecated. Use the VScrollSpeed property instead.")]
        public float GetVScrollSpeed()
        {
            return NativeCalls.godot_icall_0_14(method_bind_108, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_109 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_v_scroll");

        [GodotMethod("set_v_scroll")]
        [Obsolete("SetVScroll is deprecated. Use the ScrollVertical property instead.")]
        public void SetVScroll(double value)
        {
            NativeCalls.godot_icall_1_496(method_bind_109, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_110 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_v_scroll");

        [GodotMethod("get_v_scroll")]
        [Obsolete("GetVScroll is deprecated. Use the ScrollVertical property instead.")]
        public double GetVScroll()
        {
            return NativeCalls.godot_icall_0_179(method_bind_110, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_111 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_h_scroll");

        [GodotMethod("set_h_scroll")]
        [Obsolete("SetHScroll is deprecated. Use the ScrollHorizontal property instead.")]
        public void SetHScroll(int value)
        {
            NativeCalls.godot_icall_1_4(method_bind_111, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_112 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_h_scroll");

        [GodotMethod("get_h_scroll")]
        [Obsolete("GetHScroll is deprecated. Use the ScrollHorizontal property instead.")]
        public int GetHScroll()
        {
            return NativeCalls.godot_icall_0_5(method_bind_112, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_113 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_keyword_color");

        /// <summary>
        /// <para>Adds a <c>keyword</c> and its <see cref="Godot.Color"/>.</para>
        /// </summary>
        [GodotMethod("add_keyword_color")]
        public void AddKeywordColor(string keyword, Color color)
        {
            NativeCalls.godot_icall_2_316(method_bind_113, Object.GetPtr(this), keyword, ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_114 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_keyword_color");

        /// <summary>
        /// <para>Returns whether the specified <c>keyword</c> has a color set to it or not.</para>
        /// </summary>
        [GodotMethod("has_keyword_color")]
        public bool HasKeywordColor(string keyword)
        {
            return NativeCalls.godot_icall_1_108(method_bind_114, Object.GetPtr(this), keyword);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_115 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_keyword_color");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Color"/> of the specified <c>keyword</c>.</para>
        /// </summary>
        [GodotMethod("get_keyword_color")]
        public Color GetKeywordColor(string keyword)
        {
            NativeCalls.godot_icall_1_921(method_bind_115, Object.GetPtr(this), keyword, out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_116 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_color_region");

        /// <summary>
        /// <para>Adds color region (given the delimiters) and its colors.</para>
        /// </summary>
        [GodotMethod("add_color_region")]
        public void AddColorRegion(string beginKey, string endKey, Color color, bool lineOnly = false)
        {
            NativeCalls.godot_icall_4_922(method_bind_116, Object.GetPtr(this), beginKey, endKey, ref color, lineOnly);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_117 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_colors");

        /// <summary>
        /// <para>Clears all custom syntax coloring information previously added with <see cref="Godot.TextEdit.AddColorRegion"/> or <see cref="Godot.TextEdit.AddKeywordColor"/>.</para>
        /// </summary>
        [GodotMethod("clear_colors")]
        public void ClearColors()
        {
            NativeCalls.godot_icall_0_3(method_bind_117, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_118 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "menu_option");

        /// <summary>
        /// <para>Triggers a right-click menu action by the specified index. See <see cref="Godot.TextEdit.MenuItems"/> for a list of available indexes.</para>
        /// </summary>
        [GodotMethod("menu_option")]
        public void MenuOption(int option)
        {
            NativeCalls.godot_icall_1_4(method_bind_118, Object.GetPtr(this), option);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_119 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_menu");

        /// <summary>
        /// <para>Returns the <see cref="Godot.PopupMenu"/> of this <see cref="Godot.TextEdit"/>. By default, this menu is displayed when right-clicking on the <see cref="Godot.TextEdit"/>.</para>
        /// <para>Warning: This is a required internal node, removing and freeing it may cause a crash. If you wish to hide it or any of its children, use their <see cref="Godot.CanvasItem.Visible"/> property.</para>
        /// </summary>
        [GodotMethod("get_menu")]
        public PopupMenu GetMenu()
        {
            return NativeCalls.godot_icall_0_591(method_bind_119, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_120 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_breakpoints");

        /// <summary>
        /// <para>Returns an array containing the line number of each breakpoint.</para>
        /// </summary>
        [GodotMethod("get_breakpoints")]
        public Godot.Collections.Array GetBreakpoints()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_120, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_121 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_breakpoints");

        /// <summary>
        /// <para>Removes all the breakpoints. This will not fire the <c>breakpoint_toggled</c> signal.</para>
        /// </summary>
        [GodotMethod("remove_breakpoints")]
        public void RemoveBreakpoints()
        {
            NativeCalls.godot_icall_0_3(method_bind_121, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_122 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_minimap");

        [GodotMethod("draw_minimap")]
        [Obsolete("DrawMinimap is deprecated. Use the MinimapDraw property instead.")]
        public void DrawMinimap(bool draw)
        {
            NativeCalls.godot_icall_1_16(method_bind_122, Object.GetPtr(this), draw);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_123 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_drawing_minimap");

        [GodotMethod("is_drawing_minimap")]
        [Obsolete("IsDrawingMinimap is deprecated. Use the MinimapDraw property instead.")]
        public bool IsDrawingMinimap()
        {
            return NativeCalls.godot_icall_0_7(method_bind_123, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_124 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_minimap_width");

        [GodotMethod("set_minimap_width")]
        [Obsolete("SetMinimapWidth is deprecated. Use the MinimapWidth property instead.")]
        public void SetMinimapWidth(int width)
        {
            NativeCalls.godot_icall_1_4(method_bind_124, Object.GetPtr(this), width);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_125 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_minimap_width");

        [GodotMethod("get_minimap_width")]
        [Obsolete("GetMinimapWidth is deprecated. Use the MinimapWidth property instead.")]
        public int GetMinimapWidth()
        {
            return NativeCalls.godot_icall_0_5(method_bind_125, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
