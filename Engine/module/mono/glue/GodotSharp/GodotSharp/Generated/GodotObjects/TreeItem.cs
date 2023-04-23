using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Control for a single item inside a <see cref="Godot.Tree"/>. May have child <see cref="Godot.TreeItem"/>s and be styled as well as contain buttons.</para>
    /// <para>You can remove a <see cref="Godot.TreeItem"/> by using <see cref="Godot.Object.Free"/>.</para>
    /// </summary>
    public abstract partial class TreeItem : Object
    {
        public enum TreeCellMode
        {
            /// <summary>
            /// <para>Cell contains a string.</para>
            /// </summary>
            String = 0,
            /// <summary>
            /// <para>Cell contains a checkbox.</para>
            /// </summary>
            Check = 1,
            /// <summary>
            /// <para>Cell contains a range.</para>
            /// </summary>
            Range = 2,
            /// <summary>
            /// <para>Cell contains an icon.</para>
            /// </summary>
            Icon = 3,
            Custom = 4
        }

        public enum TextAlign
        {
            /// <summary>
            /// <para>Align text to the left. See <c>set_text_align()</c>.</para>
            /// </summary>
            Left = 0,
            /// <summary>
            /// <para>Center text. See <c>set_text_align()</c>.</para>
            /// </summary>
            Center = 1,
            /// <summary>
            /// <para>Align text to the right. See <c>set_text_align()</c>.</para>
            /// </summary>
            Right = 2
        }

        /// <summary>
        /// <para>If <c>true</c>, the TreeItem is collapsed.</para>
        /// </summary>
        public bool Collapsed
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsCollapsed();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCollapsed(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, folding is disabled for this TreeItem.</para>
        /// </summary>
        public bool DisableFolding
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsFoldingDisabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDisableFolding(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The custom minimum height.</para>
        /// </summary>
        public int CustomMinimumHeight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCustomMinimumHeight();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCustomMinimumHeight(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "TreeItem";

        internal TreeItem() {}

        internal TreeItem(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cell_mode");

        /// <summary>
        /// <para>Sets the given column's cell mode to <c>mode</c>. See <see cref="Godot.TreeItem.TreeCellMode"/> constants.</para>
        /// </summary>
        [GodotMethod("set_cell_mode")]
        public void SetCellMode(int column, TreeItem.TreeCellMode mode)
        {
            NativeCalls.godot_icall_2_65(method_bind_0, Object.GetPtr(this), column, (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cell_mode");

        /// <summary>
        /// <para>Returns the column's cell mode.</para>
        /// </summary>
        [GodotMethod("get_cell_mode")]
        public TreeItem.TreeCellMode GetCellMode(int column)
        {
            return (TreeItem.TreeCellMode)NativeCalls.godot_icall_1_979(method_bind_1, Object.GetPtr(this), column);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_checked");

        /// <summary>
        /// <para>If <c>true</c>, the column <c>column</c> is checked.</para>
        /// </summary>
        [GodotMethod("set_checked")]
        public void SetChecked(int column, bool @checked)
        {
            NativeCalls.godot_icall_2_23(method_bind_2, Object.GetPtr(this), column, @checked);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_checked");

        /// <summary>
        /// <para>Returns <c>true</c> if the given column is checked.</para>
        /// </summary>
        [GodotMethod("is_checked")]
        public bool IsChecked(int column)
        {
            return NativeCalls.godot_icall_1_35(method_bind_3, Object.GetPtr(this), column);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_text");

        /// <summary>
        /// <para>Sets the given column's text value.</para>
        /// </summary>
        [GodotMethod("set_text")]
        public void SetText(int column, string text)
        {
            NativeCalls.godot_icall_2_121(method_bind_4, Object.GetPtr(this), column, text);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_text");

        /// <summary>
        /// <para>Returns the given column's text.</para>
        /// </summary>
        [GodotMethod("get_text")]
        public string GetText(int column)
        {
            return NativeCalls.godot_icall_1_89(method_bind_5, Object.GetPtr(this), column);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_suffix");

        /// <summary>
        /// <para>Sets a string to be shown after a column's value (for example, a unit abbreviation).</para>
        /// </summary>
        [GodotMethod("set_suffix")]
        public void SetSuffix(int column, string text)
        {
            NativeCalls.godot_icall_2_121(method_bind_6, Object.GetPtr(this), column, text);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_suffix");

        /// <summary>
        /// <para>Gets the suffix string shown after the column value.</para>
        /// </summary>
        [GodotMethod("get_suffix")]
        public string GetSuffix(int column)
        {
            return NativeCalls.godot_icall_1_89(method_bind_7, Object.GetPtr(this), column);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_icon");

        /// <summary>
        /// <para>Sets the given column's icon <see cref="Godot.Texture"/>.</para>
        /// </summary>
        [GodotMethod("set_icon")]
        public void SetIcon(int column, Texture texture)
        {
            NativeCalls.godot_icall_2_58(method_bind_8, Object.GetPtr(this), column, Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_icon");

        /// <summary>
        /// <para>Returns the given column's icon <see cref="Godot.Texture"/>. Error if no icon is set.</para>
        /// </summary>
        [GodotMethod("get_icon")]
        public Texture GetIcon(int column)
        {
            return NativeCalls.godot_icall_1_59(method_bind_9, Object.GetPtr(this), column);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_icon_region");

        /// <summary>
        /// <para>Sets the given column's icon's texture region.</para>
        /// </summary>
        [GodotMethod("set_icon_region")]
        public void SetIconRegion(int column, Rect2 region)
        {
            NativeCalls.godot_icall_2_215(method_bind_10, Object.GetPtr(this), column, ref region);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_icon_region");

        /// <summary>
        /// <para>Returns the icon <see cref="Godot.Texture"/> region as <see cref="Godot.Rect2"/>.</para>
        /// </summary>
        [GodotMethod("get_icon_region")]
        public Rect2 GetIconRegion(int column)
        {
            NativeCalls.godot_icall_1_541(method_bind_11, Object.GetPtr(this), column, out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_icon_max_width");

        /// <summary>
        /// <para>Sets the given column's icon's maximum width.</para>
        /// </summary>
        [GodotMethod("set_icon_max_width")]
        public void SetIconMaxWidth(int column, int width)
        {
            NativeCalls.godot_icall_2_65(method_bind_12, Object.GetPtr(this), column, width);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_icon_max_width");

        /// <summary>
        /// <para>Returns the column's icon's maximum width.</para>
        /// </summary>
        [GodotMethod("get_icon_max_width")]
        public int GetIconMaxWidth(int column)
        {
            return NativeCalls.godot_icall_1_11(method_bind_13, Object.GetPtr(this), column);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_icon_modulate");

        /// <summary>
        /// <para>Modulates the given column's icon with <c>modulate</c>.</para>
        /// </summary>
        [GodotMethod("set_icon_modulate")]
        public void SetIconModulate(int column, Color modulate)
        {
            NativeCalls.godot_icall_2_464(method_bind_14, Object.GetPtr(this), column, ref modulate);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_icon_modulate");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Color"/> modulating the column's icon.</para>
        /// </summary>
        [GodotMethod("get_icon_modulate")]
        public Color GetIconModulate(int column)
        {
            NativeCalls.godot_icall_1_465(method_bind_15, Object.GetPtr(this), column, out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_range");

        /// <summary>
        /// <para>Sets the value of a <see cref="Godot.TreeItem.TreeCellMode.Range"/> column.</para>
        /// </summary>
        [GodotMethod("set_range")]
        public void SetRange(int column, double value)
        {
            NativeCalls.godot_icall_2_980(method_bind_16, Object.GetPtr(this), column, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_range");

        /// <summary>
        /// <para>Returns the value of a <see cref="Godot.TreeItem.TreeCellMode.Range"/> column.</para>
        /// </summary>
        [GodotMethod("get_range")]
        public double GetRange(int column)
        {
            return NativeCalls.godot_icall_1_981(method_bind_17, Object.GetPtr(this), column);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_range_config");

        /// <summary>
        /// <para>Sets the range of accepted values for a column. The column must be in the <see cref="Godot.TreeItem.TreeCellMode.Range"/> mode.</para>
        /// <para>If <c>expr</c> is <c>true</c>, the edit mode slider will use an exponential scale as with <see cref="Godot.Range.ExpEdit"/>.</para>
        /// </summary>
        [GodotMethod("set_range_config")]
        public void SetRangeConfig(int column, double min, double max, double step, bool expr = false)
        {
            NativeCalls.godot_icall_5_982(method_bind_18, Object.GetPtr(this), column, min, max, step, expr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_range_config");

        /// <summary>
        /// <para>Returns a dictionary containing the range parameters for a given column. The keys are "min", "max", "step", and "expr".</para>
        /// </summary>
        [GodotMethod("get_range_config")]
        public Godot.Collections.Dictionary GetRangeConfig(int column)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_1_983(method_bind_19, Object.GetPtr(this), column));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_metadata");

        /// <summary>
        /// <para>Sets the metadata value for the given column, which can be retrieved later using <see cref="Godot.TreeItem.GetMetadata"/>. This can be used, for example, to store a reference to the original data.</para>
        /// </summary>
        [GodotMethod("set_metadata")]
        public void SetMetadata(int column, object meta)
        {
            NativeCalls.godot_icall_2_542(method_bind_20, Object.GetPtr(this), column, meta);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_metadata");

        /// <summary>
        /// <para>Returns the metadata value that was set for the given column using <see cref="Godot.TreeItem.SetMetadata"/>.</para>
        /// </summary>
        [GodotMethod("get_metadata")]
        public object GetMetadata(int column)
        {
            return NativeCalls.godot_icall_1_543(method_bind_21, Object.GetPtr(this), column);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_custom_draw");

        /// <summary>
        /// <para>Sets the given column's custom draw callback to <c>callback</c> method on <c>object</c>.</para>
        /// <para>The <c>callback</c> should accept two arguments: the <see cref="Godot.TreeItem"/> that is drawn and its position and size as a <see cref="Godot.Rect2"/>.</para>
        /// </summary>
        [GodotMethod("set_custom_draw")]
        public void SetCustomDraw(int column, Object @object, string callback)
        {
            NativeCalls.godot_icall_3_984(method_bind_22, Object.GetPtr(this), column, Object.GetPtr(@object), callback);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collapsed");

        [GodotMethod("set_collapsed")]
        [Obsolete("SetCollapsed is deprecated. Use the Collapsed property instead.")]
        public void SetCollapsed(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_23, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_collapsed");

        [GodotMethod("is_collapsed")]
        [Obsolete("IsCollapsed is deprecated. Use the Collapsed property instead.")]
        public bool IsCollapsed()
        {
            return NativeCalls.godot_icall_0_7(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_custom_minimum_height");

        [GodotMethod("set_custom_minimum_height")]
        [Obsolete("SetCustomMinimumHeight is deprecated. Use the CustomMinimumHeight property instead.")]
        public void SetCustomMinimumHeight(int height)
        {
            NativeCalls.godot_icall_1_4(method_bind_25, Object.GetPtr(this), height);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_custom_minimum_height");

        [GodotMethod("get_custom_minimum_height")]
        [Obsolete("GetCustomMinimumHeight is deprecated. Use the CustomMinimumHeight property instead.")]
        public int GetCustomMinimumHeight()
        {
            return NativeCalls.godot_icall_0_5(method_bind_26, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_next");

        /// <summary>
        /// <para>Returns the next sibling TreeItem in the tree or a null object if there is none.</para>
        /// </summary>
        [GodotMethod("get_next")]
        public TreeItem GetNext()
        {
            return NativeCalls.godot_icall_0_974(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_prev");

        /// <summary>
        /// <para>Returns the previous sibling TreeItem in the tree or a null object if there is none.</para>
        /// </summary>
        [GodotMethod("get_prev")]
        public TreeItem GetPrev()
        {
            return NativeCalls.godot_icall_0_974(method_bind_28, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_parent");

        /// <summary>
        /// <para>Returns the parent TreeItem or a null object if there is none.</para>
        /// </summary>
        [GodotMethod("get_parent")]
        public TreeItem GetParent()
        {
            return NativeCalls.godot_icall_0_974(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_children");

        /// <summary>
        /// <para>Returns the TreeItem's first child item or a null object if there is none.</para>
        /// </summary>
        [GodotMethod("get_children")]
        public TreeItem GetChildren()
        {
            return NativeCalls.godot_icall_0_974(method_bind_30, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_next_visible");

        /// <summary>
        /// <para>Returns the next visible sibling TreeItem in the tree or a null object if there is none.</para>
        /// <para>If <c>wrap</c> is enabled, the method will wrap around to the first visible element in the tree when called on the last visible element, otherwise it returns <c>null</c>.</para>
        /// </summary>
        [GodotMethod("get_next_visible")]
        public TreeItem GetNextVisible(bool wrap = false)
        {
            return NativeCalls.godot_icall_1_985(method_bind_31, Object.GetPtr(this), wrap);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_prev_visible");

        /// <summary>
        /// <para>Returns the previous visible sibling TreeItem in the tree or a null object if there is none.</para>
        /// <para>If <c>wrap</c> is enabled, the method will wrap around to the last visible element in the tree when called on the first visible element, otherwise it returns <c>null</c>.</para>
        /// </summary>
        [GodotMethod("get_prev_visible")]
        public TreeItem GetPrevVisible(bool wrap = false)
        {
            return NativeCalls.godot_icall_1_985(method_bind_32, Object.GetPtr(this), wrap);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_child");

        /// <summary>
        /// <para>Removes the given child <see cref="Godot.TreeItem"/> and all its children from the <see cref="Godot.Tree"/>. Note that it doesn't free the item from memory, so it can be reused later. To completely remove a <see cref="Godot.TreeItem"/> use <see cref="Godot.Object.Free"/>.</para>
        /// </summary>
        [GodotMethod("remove_child")]
        public void RemoveChild(Object child)
        {
            NativeCalls.godot_icall_1_53(method_bind_33, Object.GetPtr(this), Object.GetPtr(child));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_selectable");

        /// <summary>
        /// <para>If <c>true</c>, the given column is selectable.</para>
        /// </summary>
        [GodotMethod("set_selectable")]
        public void SetSelectable(int column, bool selectable)
        {
            NativeCalls.godot_icall_2_23(method_bind_34, Object.GetPtr(this), column, selectable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_selectable");

        /// <summary>
        /// <para>Returns <c>true</c> if column <c>column</c> is selectable.</para>
        /// </summary>
        [GodotMethod("is_selectable")]
        public bool IsSelectable(int column)
        {
            return NativeCalls.godot_icall_1_35(method_bind_35, Object.GetPtr(this), column);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_selected");

        /// <summary>
        /// <para>Returns <c>true</c> if column <c>column</c> is selected.</para>
        /// </summary>
        [GodotMethod("is_selected")]
        public bool IsSelected(int column)
        {
            return NativeCalls.godot_icall_1_35(method_bind_36, Object.GetPtr(this), column);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "select");

        /// <summary>
        /// <para>Selects the column <c>column</c>.</para>
        /// </summary>
        [GodotMethod("select")]
        public void Select(int column)
        {
            NativeCalls.godot_icall_1_4(method_bind_37, Object.GetPtr(this), column);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "deselect");

        /// <summary>
        /// <para>Deselects the given column.</para>
        /// </summary>
        [GodotMethod("deselect")]
        public void Deselect(int column)
        {
            NativeCalls.godot_icall_1_4(method_bind_38, Object.GetPtr(this), column);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_editable");

        /// <summary>
        /// <para>If <c>true</c>, column <c>column</c> is editable.</para>
        /// </summary>
        [GodotMethod("set_editable")]
        public void SetEditable(int column, bool enabled)
        {
            NativeCalls.godot_icall_2_23(method_bind_39, Object.GetPtr(this), column, enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_editable");

        /// <summary>
        /// <para>Returns <c>true</c> if column <c>column</c> is editable.</para>
        /// </summary>
        [GodotMethod("is_editable")]
        public bool IsEditable(int column)
        {
            return NativeCalls.godot_icall_1_35(method_bind_40, Object.GetPtr(this), column);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_custom_color");

        /// <summary>
        /// <para>Sets the given column's custom color.</para>
        /// </summary>
        [GodotMethod("set_custom_color")]
        public void SetCustomColor(int column, Color color)
        {
            NativeCalls.godot_icall_2_464(method_bind_41, Object.GetPtr(this), column, ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_custom_color");

        /// <summary>
        /// <para>Resets the color for the given column to default.</para>
        /// </summary>
        [GodotMethod("clear_custom_color")]
        public void ClearCustomColor(int column)
        {
            NativeCalls.godot_icall_1_4(method_bind_42, Object.GetPtr(this), column);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_custom_color");

        /// <summary>
        /// <para>Returns the custom color of column <c>column</c>.</para>
        /// </summary>
        [GodotMethod("get_custom_color")]
        public Color GetCustomColor(int column)
        {
            NativeCalls.godot_icall_1_465(method_bind_43, Object.GetPtr(this), column, out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_custom_bg_color");

        /// <summary>
        /// <para>Sets the given column's custom background color and whether to just use it as an outline.</para>
        /// </summary>
        [GodotMethod("set_custom_bg_color")]
        public void SetCustomBgColor(int column, Color color, bool justOutline = false)
        {
            NativeCalls.godot_icall_3_986(method_bind_44, Object.GetPtr(this), column, ref color, justOutline);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_custom_bg_color");

        /// <summary>
        /// <para>Resets the background color for the given column to default.</para>
        /// </summary>
        [GodotMethod("clear_custom_bg_color")]
        public void ClearCustomBgColor(int column)
        {
            NativeCalls.godot_icall_1_4(method_bind_45, Object.GetPtr(this), column);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_custom_bg_color");

        /// <summary>
        /// <para>Returns the custom background color of column <c>column</c>.</para>
        /// </summary>
        [GodotMethod("get_custom_bg_color")]
        public Color GetCustomBgColor(int column)
        {
            NativeCalls.godot_icall_1_465(method_bind_46, Object.GetPtr(this), column, out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_custom_as_button");

        [GodotMethod("set_custom_as_button")]
        public void SetCustomAsButton(int column, bool enable)
        {
            NativeCalls.godot_icall_2_23(method_bind_47, Object.GetPtr(this), column, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_custom_set_as_button");

        [GodotMethod("is_custom_set_as_button")]
        public bool IsCustomSetAsButton(int column)
        {
            return NativeCalls.godot_icall_1_35(method_bind_48, Object.GetPtr(this), column);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_button");

        /// <summary>
        /// <para>Adds a button with <see cref="Godot.Texture"/> <c>button</c> at column <c>column</c>. The <c>id</c> is used to identify the button. If not specified, the next available index is used, which may be retrieved by calling <see cref="Godot.TreeItem.GetButtonCount"/> immediately before this method. Optionally, the button can be <c>disabled</c> and have a <c>tooltip</c>.</para>
        /// </summary>
        [GodotMethod("add_button")]
        public void AddButton(int column, Texture button, int id = -1, bool disabled = false, string tooltip = "")
        {
            NativeCalls.godot_icall_5_987(method_bind_49, Object.GetPtr(this), column, Object.GetPtr(button), id, disabled, tooltip);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_button_count");

        /// <summary>
        /// <para>Returns the number of buttons in column <c>column</c>.</para>
        /// </summary>
        [GodotMethod("get_button_count")]
        public int GetButtonCount(int column)
        {
            return NativeCalls.godot_icall_1_11(method_bind_50, Object.GetPtr(this), column);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_button_tooltip");

        /// <summary>
        /// <para>Returns the tooltip string for the button at index <c>button_idx</c> in column <c>column</c>.</para>
        /// </summary>
        [GodotMethod("get_button_tooltip")]
        public string GetButtonTooltip(int column, int buttonIdx)
        {
            return NativeCalls.godot_icall_2_78(method_bind_51, Object.GetPtr(this), column, buttonIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_button_id");

        /// <summary>
        /// <para>Returns the id for the button at index <c>button_idx</c> in column <c>column</c>.</para>
        /// </summary>
        [GodotMethod("get_button_id")]
        public int GetButtonId(int column, int buttonIdx)
        {
            return NativeCalls.godot_icall_2_60(method_bind_52, Object.GetPtr(this), column, buttonIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_53 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_button_by_id");

        /// <summary>
        /// <para>Returns the button index if there is a button with id <c>id</c> in column <c>column</c>, otherwise returns -1.</para>
        /// </summary>
        [GodotMethod("get_button_by_id")]
        public int GetButtonById(int column, int id)
        {
            return NativeCalls.godot_icall_2_60(method_bind_53, Object.GetPtr(this), column, id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_54 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_button");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Texture"/> of the button at index <c>button_idx</c> in column <c>column</c>.</para>
        /// </summary>
        [GodotMethod("get_button")]
        public Texture GetButton(int column, int buttonIdx)
        {
            return NativeCalls.godot_icall_2_988(method_bind_54, Object.GetPtr(this), column, buttonIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_55 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_button");

        /// <summary>
        /// <para>Sets the given column's button <see cref="Godot.Texture"/> at index <c>button_idx</c> to <c>button</c>.</para>
        /// </summary>
        [GodotMethod("set_button")]
        public void SetButton(int column, int buttonIdx, Texture button)
        {
            NativeCalls.godot_icall_3_85(method_bind_55, Object.GetPtr(this), column, buttonIdx, Object.GetPtr(button));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_56 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "erase_button");

        /// <summary>
        /// <para>Removes the button at index <c>button_idx</c> in column <c>column</c>.</para>
        /// </summary>
        [GodotMethod("erase_button")]
        public void EraseButton(int column, int buttonIdx)
        {
            NativeCalls.godot_icall_2_65(method_bind_56, Object.GetPtr(this), column, buttonIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_57 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_button_disabled");

        /// <summary>
        /// <para>If <c>true</c>, disables the button at index <c>button_idx</c> in column <c>column</c>.</para>
        /// </summary>
        [GodotMethod("set_button_disabled")]
        public void SetButtonDisabled(int column, int buttonIdx, bool disabled)
        {
            NativeCalls.godot_icall_3_37(method_bind_57, Object.GetPtr(this), column, buttonIdx, disabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_58 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_button_disabled");

        /// <summary>
        /// <para>Returns <c>true</c> if the button at index <c>button_idx</c> for the given column is disabled.</para>
        /// </summary>
        [GodotMethod("is_button_disabled")]
        public bool IsButtonDisabled(int column, int buttonIdx)
        {
            return NativeCalls.godot_icall_2_177(method_bind_58, Object.GetPtr(this), column, buttonIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_59 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_expand_right");

        /// <summary>
        /// <para>If <c>true</c>, column <c>column</c> is expanded to the right.</para>
        /// </summary>
        [GodotMethod("set_expand_right")]
        public void SetExpandRight(int column, bool enable)
        {
            NativeCalls.godot_icall_2_23(method_bind_59, Object.GetPtr(this), column, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_60 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_expand_right");

        /// <summary>
        /// <para>Returns <c>true</c> if <c>expand_right</c> is set.</para>
        /// </summary>
        [GodotMethod("get_expand_right")]
        public bool GetExpandRight(int column)
        {
            return NativeCalls.godot_icall_1_35(method_bind_60, Object.GetPtr(this), column);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_61 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tooltip");

        /// <summary>
        /// <para>Sets the given column's tooltip text.</para>
        /// </summary>
        [GodotMethod("set_tooltip")]
        public void SetTooltip(int column, string tooltip)
        {
            NativeCalls.godot_icall_2_121(method_bind_61, Object.GetPtr(this), column, tooltip);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_62 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tooltip");

        /// <summary>
        /// <para>Returns the given column's tooltip.</para>
        /// </summary>
        [GodotMethod("get_tooltip")]
        public string GetTooltip(int column)
        {
            return NativeCalls.godot_icall_1_89(method_bind_62, Object.GetPtr(this), column);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_63 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_text_align");

        /// <summary>
        /// <para>Sets the given column's text alignment. See <see cref="Godot.TreeItem.TextAlign"/> for possible values.</para>
        /// </summary>
        [GodotMethod("set_text_align")]
        public void SetTextAlign(int column, TreeItem.TextAlign textAlign)
        {
            NativeCalls.godot_icall_2_65(method_bind_63, Object.GetPtr(this), column, (int)textAlign);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_64 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_text_align");

        /// <summary>
        /// <para>Returns the given column's text alignment.</para>
        /// </summary>
        [GodotMethod("get_text_align")]
        public TreeItem.TextAlign GetTextAlign(int column)
        {
            return (TreeItem.TextAlign)NativeCalls.godot_icall_1_989(method_bind_64, Object.GetPtr(this), column);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_65 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "move_to_top");

        /// <summary>
        /// <para>Moves this TreeItem to the top in the <see cref="Godot.Tree"/> hierarchy.</para>
        /// </summary>
        [GodotMethod("move_to_top")]
        public void MoveToTop()
        {
            NativeCalls.godot_icall_0_3(method_bind_65, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_66 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "move_to_bottom");

        /// <summary>
        /// <para>Moves this TreeItem to the bottom in the <see cref="Godot.Tree"/> hierarchy.</para>
        /// </summary>
        [GodotMethod("move_to_bottom")]
        public void MoveToBottom()
        {
            NativeCalls.godot_icall_0_3(method_bind_66, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_67 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_disable_folding");

        [GodotMethod("set_disable_folding")]
        [Obsolete("SetDisableFolding is deprecated. Use the DisableFolding property instead.")]
        public void SetDisableFolding(bool disable)
        {
            NativeCalls.godot_icall_1_16(method_bind_67, Object.GetPtr(this), disable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_68 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_folding_disabled");

        [GodotMethod("is_folding_disabled")]
        [Obsolete("IsFoldingDisabled is deprecated. Use the DisableFolding property instead.")]
        public bool IsFoldingDisabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_68, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_69 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "call_recursive");

        /// <summary>
        /// <para>Calls the <c>method</c> on the actual TreeItem and its children recursively. Pass parameters as a comma separated list.</para>
        /// </summary>
        [GodotMethod("call_recursive")]
        public object CallRecursive(string method, params object[] @args)
        {
            return NativeCalls.godot_icall_2_558(method_bind_69, Object.GetPtr(this), method, @args);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
