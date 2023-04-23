using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This shows a tree of items that can be selected, expanded and collapsed. The tree can have multiple columns with custom controls like text editing, buttons and popups. It can be useful for structured displays and interactions.</para>
    /// <para>Trees are built via code, using <see cref="Godot.TreeItem"/> objects to create the structure. They have a single root but multiple roots can be simulated if a dummy hidden root is added.</para>
    /// <para><code>
    /// func _ready():
    ///     var tree = Tree.new()
    ///     var root = tree.create_item()
    ///     tree.set_hide_root(true)
    ///     var child1 = tree.create_item(root)
    ///     var child2 = tree.create_item(root)
    ///     var subchild1 = tree.create_item(child1)
    ///     subchild1.set_text(0, "Subchild1")
    /// </code></para>
    /// <para>To iterate over all the <see cref="Godot.TreeItem"/> objects in a <see cref="Godot.Tree"/> object, use <see cref="Godot.TreeItem.GetNext"/> and <see cref="Godot.TreeItem.GetChildren"/> after getting the root through <see cref="Godot.Tree.GetRoot"/>. You can use <see cref="Godot.Object.Free"/> on a <see cref="Godot.TreeItem"/> to remove it from the <see cref="Godot.Tree"/>.</para>
    /// <para>Incremental search: Like <see cref="Godot.ItemList"/> and <see cref="Godot.PopupMenu"/>, <see cref="Godot.Tree"/> supports searching within the list while the control is focused. Press a key that matches the first letter of an item's name to select the first item starting with the given letter. After that point, there are two ways to perform incremental search: 1) Press the same key again before the timeout duration to select the next item starting with the same letter. 2) Press letter keys that match the rest of the word before the timeout duration to match to select the item in question directly. Both of these actions will be reset to the beginning of the list if the timeout duration has passed since the last keystroke was registered. You can adjust the timeout duration by changing .</para>
    /// </summary>
    public partial class Tree : Control
    {
        public enum SelectModeEnum
        {
            /// <summary>
            /// <para>Allows selection of a single cell at a time. From the perspective of items, only a single item is allowed to be selected. And there is only one column selected in the selected item.</para>
            /// <para>The focus cursor is always hidden in this mode, but it is positioned at the current selection, making the currently selected item the currently focused item.</para>
            /// </summary>
            Single = 0,
            /// <summary>
            /// <para>Allows selection of a single row at a time. From the perspective of items, only a single items is allowed to be selected. And all the columns are selected in the selected item.</para>
            /// <para>The focus cursor is always hidden in this mode, but it is positioned at the first column of the current selection, making the currently selected item the currently focused item.</para>
            /// </summary>
            Row = 1,
            /// <summary>
            /// <para>Allows selection of multiple cells at the same time. From the perspective of items, multiple items are allowed to be selected. And there can be multiple columns selected in each selected item.</para>
            /// <para>The focus cursor is visible in this mode, the item or column under the cursor is not necessarily selected.</para>
            /// </summary>
            Multi = 2
        }

        public enum DropModeFlagsEnum
        {
            /// <summary>
            /// <para>Disables all drop sections, but still allows to detect the "on item" drop section by <see cref="Godot.Tree.GetDropSectionAtPosition"/>.</para>
            /// <para>Note: This is the default flag, it has no effect when combined with other flags.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>Enables the "on item" drop section. This drop section covers the entire item.</para>
            /// <para>When combined with <see cref="Godot.Tree.DropModeFlagsEnum.Inbetween"/>, this drop section halves the height and stays centered vertically.</para>
            /// </summary>
            OnItem = 1,
            /// <summary>
            /// <para>Enables "above item" and "below item" drop sections. The "above item" drop section covers the top half of the item, and the "below item" drop section covers the bottom half.</para>
            /// <para>When combined with <see cref="Godot.Tree.DropModeFlagsEnum.OnItem"/>, these drop sections halves the height and stays on top / bottom accordingly.</para>
            /// </summary>
            Inbetween = 2
        }

        /// <summary>
        /// <para>The number of columns.</para>
        /// </summary>
        public int Columns
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetColumns();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetColumns(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, column titles are visible.</para>
        /// </summary>
        public bool ColumnTitlesVisible
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return AreColumnTitlesVisible();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetColumnTitlesVisible(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the currently selected cell may be selected again.</para>
        /// </summary>
        public bool AllowReselect
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAllowReselect();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAllowReselect(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, a right mouse button click can select items.</para>
        /// </summary>
        public bool AllowRmbSelect
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAllowRmbSelect();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAllowRmbSelect(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the folding arrow is hidden.</para>
        /// </summary>
        public bool HideFolding
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsFoldingHidden();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHideFolding(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the tree's root is hidden.</para>
        /// </summary>
        public bool HideRoot
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsRootHidden();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHideRoot(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The drop mode as an OR combination of flags. See <see cref="Godot.Tree.DropModeFlagsEnum"/> constants. Once dropping is done, reverts to <see cref="Godot.Tree.DropModeFlagsEnum.Disabled"/>. Setting this during <see cref="Godot.Control.CanDropData"/> is recommended.</para>
        /// <para>This controls the drop sections, i.e. the decision and drawing of possible drop locations based on the mouse position.</para>
        /// </summary>
        public int DropModeFlags
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDropModeFlags();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDropModeFlags(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Allows single or multiple selection. See the <see cref="Godot.Tree.SelectModeEnum"/> constants.</para>
        /// </summary>
        public Tree.SelectModeEnum SelectMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSelectMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSelectMode(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Tree";

        public Tree() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Tree_Ctor(this);
        }

        internal Tree(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Clears the tree. This removes all items.</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_item");

        /// <summary>
        /// <para>Creates an item in the tree and adds it as a child of <c>parent</c>, which can be either a valid <see cref="Godot.TreeItem"/> or <c>null</c>.</para>
        /// <para>If <c>parent</c> is <c>null</c>, the root item will be the parent, or the new item will be the root itself if the tree is empty.</para>
        /// <para>The new item will be the <c>idx</c>th child of parent, or it will be the last child if there are not enough siblings.</para>
        /// </summary>
        [GodotMethod("create_item")]
        public TreeItem CreateItem(Object parent = null, int idx = -1)
        {
            return NativeCalls.godot_icall_2_973(method_bind_1, Object.GetPtr(this), Object.GetPtr(parent), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_root");

        /// <summary>
        /// <para>Returns the tree's root item, or <c>null</c> if the tree is empty.</para>
        /// </summary>
        [GodotMethod("get_root")]
        public TreeItem GetRoot()
        {
            return NativeCalls.godot_icall_0_974(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_column_min_width");

        /// <summary>
        /// <para>Sets the minimum width of a column. Columns that have the "Expand" flag will use their "min_width" in a similar fashion to <see cref="Godot.Control.SizeFlagsStretchRatio"/>.</para>
        /// </summary>
        [GodotMethod("set_column_min_width")]
        public void SetColumnMinWidth(int column, int minWidth)
        {
            NativeCalls.godot_icall_2_65(method_bind_3, Object.GetPtr(this), column, minWidth);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_column_expand");

        /// <summary>
        /// <para>If <c>true</c>, the column will have the "Expand" flag of <see cref="Godot.Control"/>. Columns that have the "Expand" flag will use their "min_width" in a similar fashion to <see cref="Godot.Control.SizeFlagsStretchRatio"/>.</para>
        /// </summary>
        [GodotMethod("set_column_expand")]
        public void SetColumnExpand(int column, bool expand)
        {
            NativeCalls.godot_icall_2_23(method_bind_4, Object.GetPtr(this), column, expand);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_column_width");

        /// <summary>
        /// <para>Returns the column's width in pixels.</para>
        /// </summary>
        [GodotMethod("get_column_width")]
        public int GetColumnWidth(int column)
        {
            return NativeCalls.godot_icall_1_11(method_bind_5, Object.GetPtr(this), column);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_hide_root");

        [GodotMethod("set_hide_root")]
        [Obsolete("SetHideRoot is deprecated. Use the HideRoot property instead.")]
        public void SetHideRoot(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_root_hidden");

        [GodotMethod("is_root_hidden")]
        [Obsolete("IsRootHidden is deprecated. Use the HideRoot property instead.")]
        public bool IsRootHidden()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_next_selected");

        /// <summary>
        /// <para>Returns the next selected <see cref="Godot.TreeItem"/> after the given one, or <c>null</c> if the end is reached.</para>
        /// <para>If <c>from</c> is <c>null</c>, this returns the first selected item.</para>
        /// </summary>
        [GodotMethod("get_next_selected")]
        public TreeItem GetNextSelected(Object from)
        {
            return NativeCalls.godot_icall_1_975(method_bind_8, Object.GetPtr(this), Object.GetPtr(from));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_selected");

        /// <summary>
        /// <para>Returns the currently focused item, or <c>null</c> if no item is focused.</para>
        /// <para>In <see cref="Godot.Tree.SelectModeEnum.Row"/> and <see cref="Godot.Tree.SelectModeEnum.Single"/> modes, the focused item is same as the selected item. In <see cref="Godot.Tree.SelectModeEnum.Multi"/> mode, the focused item is the item under the focus cursor, not necessarily selected.</para>
        /// <para>To get the currently selected item(s), use <see cref="Godot.Tree.GetNextSelected"/>.</para>
        /// </summary>
        [GodotMethod("get_selected")]
        public TreeItem GetSelected()
        {
            return NativeCalls.godot_icall_0_974(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_selected_column");

        /// <summary>
        /// <para>Returns the currently focused column, or -1 if no column is focused.</para>
        /// <para>In <see cref="Godot.Tree.SelectModeEnum.Single"/> mode, the focused column is the selected column. In <see cref="Godot.Tree.SelectModeEnum.Row"/> mode, the focused column is always 0 if any item is selected. In <see cref="Godot.Tree.SelectModeEnum.Multi"/> mode, the focused column is the column under the focus cursor, and there are not necessarily any column selected.</para>
        /// <para>To tell whether a column of an item is selected, use <see cref="Godot.TreeItem.IsSelected"/>.</para>
        /// </summary>
        [GodotMethod("get_selected_column")]
        public int GetSelectedColumn()
        {
            return NativeCalls.godot_icall_0_5(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pressed_button");

        /// <summary>
        /// <para>Returns the last pressed button's index.</para>
        /// </summary>
        [GodotMethod("get_pressed_button")]
        public int GetPressedButton()
        {
            return NativeCalls.godot_icall_0_5(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_select_mode");

        [GodotMethod("set_select_mode")]
        [Obsolete("SetSelectMode is deprecated. Use the SelectMode property instead.")]
        public void SetSelectMode(Tree.SelectModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_12, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_select_mode");

        [GodotMethod("get_select_mode")]
        [Obsolete("GetSelectMode is deprecated. Use the SelectMode property instead.")]
        public Tree.SelectModeEnum GetSelectMode()
        {
            return (Tree.SelectModeEnum)NativeCalls.godot_icall_0_976(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_columns");

        [GodotMethod("set_columns")]
        [Obsolete("SetColumns is deprecated. Use the Columns property instead.")]
        public void SetColumns(int amount)
        {
            NativeCalls.godot_icall_1_4(method_bind_14, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_columns");

        [GodotMethod("get_columns")]
        [Obsolete("GetColumns is deprecated. Use the Columns property instead.")]
        public int GetColumns()
        {
            return NativeCalls.godot_icall_0_5(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_edited");

        /// <summary>
        /// <para>Returns the currently edited item. Can be used with <c>item_edited</c> to get the item that was modified.</para>
        /// <para><code>
        /// func _ready():
        ///     $Tree.connect("item_edited", self, "on_Tree_item_edited")
        /// 
        /// func on_Tree_item_edited():
        ///     print($Tree.get_edited()) # This item just got edited (e.g. checked).
        /// </code></para>
        /// </summary>
        [GodotMethod("get_edited")]
        public TreeItem GetEdited()
        {
            return NativeCalls.godot_icall_0_974(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_edited_column");

        /// <summary>
        /// <para>Returns the column for the currently edited item.</para>
        /// </summary>
        [GodotMethod("get_edited_column")]
        public int GetEditedColumn()
        {
            return NativeCalls.godot_icall_0_5(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "edit_selected");

        /// <summary>
        /// <para>Edits the selected tree item as if it was clicked. The item must be set editable with <see cref="Godot.TreeItem.SetEditable"/>. Returns <c>true</c> if the item could be edited. Fails if no item is selected.</para>
        /// </summary>
        [GodotMethod("edit_selected")]
        public bool EditSelected()
        {
            return NativeCalls.godot_icall_0_7(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_custom_popup_rect");

        /// <summary>
        /// <para>Returns the rectangle for custom popups. Helper to create custom cell controls that display a popup. See <see cref="Godot.TreeItem.SetCellMode"/>.</para>
        /// </summary>
        [GodotMethod("get_custom_popup_rect")]
        public Rect2 GetCustomPopupRect()
        {
            NativeCalls.godot_icall_0_163(method_bind_19, Object.GetPtr(this), out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_area_rect");

        /// <summary>
        /// <para>Returns the rectangle area for the specified <see cref="Godot.TreeItem"/>. If <c>column</c> is specified, only get the position and size of that column, otherwise get the rectangle containing all columns.</para>
        /// </summary>
        [GodotMethod("get_item_area_rect")]
        public Rect2 GetItemAreaRect(Object item, int column = -1)
        {
            NativeCalls.godot_icall_2_977(method_bind_20, Object.GetPtr(this), Object.GetPtr(item), column, out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_at_position");

        /// <summary>
        /// <para>Returns the tree item at the specified position (relative to the tree origin position).</para>
        /// </summary>
        [GodotMethod("get_item_at_position")]
        public TreeItem GetItemAtPosition(Vector2 position)
        {
            return NativeCalls.godot_icall_1_978(method_bind_21, Object.GetPtr(this), ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_column_at_position");

        /// <summary>
        /// <para>Returns the column index at <c>position</c>, or -1 if no item is there.</para>
        /// </summary>
        [GodotMethod("get_column_at_position")]
        public int GetColumnAtPosition(Vector2 position)
        {
            return NativeCalls.godot_icall_1_914(method_bind_22, Object.GetPtr(this), ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_drop_section_at_position");

        /// <summary>
        /// <para>Returns the drop section at <c>position</c>, or -100 if no item is there.</para>
        /// <para>Values -1, 0, or 1 will be returned for the "above item", "on item", and "below item" drop sections, respectively. See <see cref="Godot.Tree.DropModeFlagsEnum"/> for a description of each drop section.</para>
        /// <para>To get the item which the returned drop section is relative to, use <see cref="Godot.Tree.GetItemAtPosition"/>.</para>
        /// </summary>
        [GodotMethod("get_drop_section_at_position")]
        public int GetDropSectionAtPosition(Vector2 position)
        {
            return NativeCalls.godot_icall_1_914(method_bind_23, Object.GetPtr(this), ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_button_id_at_position");

        /// <summary>
        /// <para>Returns the button id at <c>position</c>, or -1 if no button is there.</para>
        /// </summary>
        [GodotMethod("get_button_id_at_position")]
        public int GetButtonIdAtPosition(Vector2 position)
        {
            return NativeCalls.godot_icall_1_914(method_bind_24, Object.GetPtr(this), ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "ensure_cursor_is_visible");

        /// <summary>
        /// <para>Makes the currently focused cell visible.</para>
        /// <para>This will scroll the tree if necessary. In <see cref="Godot.Tree.SelectModeEnum.Row"/> mode, this will not do horizontal scrolling, as all the cells in the selected row is focused logically.</para>
        /// <para>Note: Despite the name of this method, the focus cursor itself is only visible in <see cref="Godot.Tree.SelectModeEnum.Multi"/> mode.</para>
        /// </summary>
        [GodotMethod("ensure_cursor_is_visible")]
        public void EnsureCursorIsVisible()
        {
            NativeCalls.godot_icall_0_3(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_column_titles_visible");

        [GodotMethod("set_column_titles_visible")]
        [Obsolete("SetColumnTitlesVisible is deprecated. Use the ColumnTitlesVisible property instead.")]
        public void SetColumnTitlesVisible(bool visible)
        {
            NativeCalls.godot_icall_1_16(method_bind_26, Object.GetPtr(this), visible);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "are_column_titles_visible");

        [GodotMethod("are_column_titles_visible")]
        [Obsolete("AreColumnTitlesVisible is deprecated. Use the ColumnTitlesVisible property instead.")]
        public bool AreColumnTitlesVisible()
        {
            return NativeCalls.godot_icall_0_7(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_column_title");

        /// <summary>
        /// <para>Sets the title of a column.</para>
        /// </summary>
        [GodotMethod("set_column_title")]
        public void SetColumnTitle(int column, string title)
        {
            NativeCalls.godot_icall_2_121(method_bind_28, Object.GetPtr(this), column, title);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_column_title");

        /// <summary>
        /// <para>Returns the column's title.</para>
        /// </summary>
        [GodotMethod("get_column_title")]
        public string GetColumnTitle(int column)
        {
            return NativeCalls.godot_icall_1_89(method_bind_29, Object.GetPtr(this), column);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_scroll");

        /// <summary>
        /// <para>Returns the current scrolling position.</para>
        /// </summary>
        [GodotMethod("get_scroll")]
        public Vector2 GetScroll()
        {
            NativeCalls.godot_icall_0_18(method_bind_30, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "scroll_to_item");

        /// <summary>
        /// <para>Causes the <see cref="Godot.Tree"/> to jump to the specified <see cref="Godot.TreeItem"/>.</para>
        /// </summary>
        [GodotMethod("scroll_to_item")]
        public void ScrollToItem(Object item)
        {
            NativeCalls.godot_icall_1_53(method_bind_31, Object.GetPtr(this), Object.GetPtr(item));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_hide_folding");

        [GodotMethod("set_hide_folding")]
        [Obsolete("SetHideFolding is deprecated. Use the HideFolding property instead.")]
        public void SetHideFolding(bool hide)
        {
            NativeCalls.godot_icall_1_16(method_bind_32, Object.GetPtr(this), hide);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_folding_hidden");

        [GodotMethod("is_folding_hidden")]
        [Obsolete("IsFoldingHidden is deprecated. Use the HideFolding property instead.")]
        public bool IsFoldingHidden()
        {
            return NativeCalls.godot_icall_0_7(method_bind_33, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_drop_mode_flags");

        [GodotMethod("set_drop_mode_flags")]
        [Obsolete("SetDropModeFlags is deprecated. Use the DropModeFlags property instead.")]
        public void SetDropModeFlags(int flags)
        {
            NativeCalls.godot_icall_1_4(method_bind_34, Object.GetPtr(this), flags);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_drop_mode_flags");

        [GodotMethod("get_drop_mode_flags")]
        [Obsolete("GetDropModeFlags is deprecated. Use the DropModeFlags property instead.")]
        public int GetDropModeFlags()
        {
            return NativeCalls.godot_icall_0_5(method_bind_35, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_allow_rmb_select");

        [GodotMethod("set_allow_rmb_select")]
        [Obsolete("SetAllowRmbSelect is deprecated. Use the AllowRmbSelect property instead.")]
        public void SetAllowRmbSelect(bool allow)
        {
            NativeCalls.godot_icall_1_16(method_bind_36, Object.GetPtr(this), allow);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_allow_rmb_select");

        [GodotMethod("get_allow_rmb_select")]
        [Obsolete("GetAllowRmbSelect is deprecated. Use the AllowRmbSelect property instead.")]
        public bool GetAllowRmbSelect()
        {
            return NativeCalls.godot_icall_0_7(method_bind_37, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_allow_reselect");

        [GodotMethod("set_allow_reselect")]
        [Obsolete("SetAllowReselect is deprecated. Use the AllowReselect property instead.")]
        public void SetAllowReselect(bool allow)
        {
            NativeCalls.godot_icall_1_16(method_bind_38, Object.GetPtr(this), allow);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_allow_reselect");

        [GodotMethod("get_allow_reselect")]
        [Obsolete("GetAllowReselect is deprecated. Use the AllowReselect property instead.")]
        public bool GetAllowReselect()
        {
            return NativeCalls.godot_icall_0_7(method_bind_39, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
