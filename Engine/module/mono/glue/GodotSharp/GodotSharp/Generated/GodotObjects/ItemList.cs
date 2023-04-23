using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This control provides a selectable list of items that may be in a single (or multiple columns) with option of text, icons, or both text and icon. Tooltips are supported and may be different for every item in the list.</para>
    /// <para>Selectable items in the list may be selected or deselected and multiple selection may be enabled. Selection with right mouse button may also be enabled to allow use of popup context menus. Items may also be "activated" by double-clicking them or by pressing Enter.</para>
    /// <para>Item text only supports single-line strings, newline characters (e.g. <c>\n</c>) in the string won't produce a newline. Text wrapping is enabled in <see cref="Godot.ItemList.IconModeEnum.Top"/> mode, but column's width is adjusted to fully fit its content by default. You need to set <see cref="Godot.ItemList.FixedColumnWidth"/> greater than zero to wrap the text.</para>
    /// <para>Incremental search: Like <see cref="Godot.PopupMenu"/> and <see cref="Godot.Tree"/>, <see cref="Godot.ItemList"/> supports searching within the list while the control is focused. Press a key that matches the first letter of an item's name to select the first item starting with the given letter. After that point, there are two ways to perform incremental search: 1) Press the same key again before the timeout duration to select the next item starting with the same letter. 2) Press letter keys that match the rest of the word before the timeout duration to match to select the item in question directly. Both of these actions will be reset to the beginning of the list if the timeout duration has passed since the last keystroke was registered. You can adjust the timeout duration by changing .</para>
    /// </summary>
    public partial class ItemList : Control
    {
        public enum SelectModeEnum
        {
            /// <summary>
            /// <para>Only allow selecting a single item.</para>
            /// </summary>
            Single = 0,
            /// <summary>
            /// <para>Allows selecting multiple items by holding Ctrl or Shift.</para>
            /// </summary>
            Multi = 1
        }

        public enum IconModeEnum
        {
            /// <summary>
            /// <para>Icon is drawn above the text.</para>
            /// </summary>
            Top = 0,
            /// <summary>
            /// <para>Icon is drawn to the left of the text.</para>
            /// </summary>
            Left = 1
        }

        public Godot.Collections.Array Items
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetItems();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetItems(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Allows single or multiple item selection. See the <see cref="Godot.ItemList.SelectModeEnum"/> constants.</para>
        /// </summary>
        public ItemList.SelectModeEnum SelectMode
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

        /// <summary>
        /// <para>If <c>true</c>, the currently selected item can be selected again.</para>
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
        /// <para>If <c>true</c>, right mouse button click can select items.</para>
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
        /// <para>Maximum lines of text allowed in each item. Space will be reserved even when there is not enough lines of text to display.</para>
        /// <para>Note: This property takes effect only when <see cref="Godot.ItemList.IconMode"/> is <see cref="Godot.ItemList.IconModeEnum.Top"/>. To make the text wrap, <see cref="Godot.ItemList.FixedColumnWidth"/> should be greater than zero.</para>
        /// </summary>
        public int MaxTextLines
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaxTextLines();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaxTextLines(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the control will automatically resize the height to fit its content.</para>
        /// </summary>
        public bool AutoHeight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return HasAutoHeight();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAutoHeight(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Maximum columns the list will have.</para>
        /// <para>If greater than zero, the content will be split among the specified columns.</para>
        /// <para>A value of zero means unlimited columns, i.e. all items will be put in the same row.</para>
        /// </summary>
        public int MaxColumns
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaxColumns();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaxColumns(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Whether all columns will have the same width.</para>
        /// <para>If <c>true</c>, the width is equal to the largest column width of all columns.</para>
        /// </summary>
        public bool SameColumnWidth
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsSameColumnWidth();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSameColumnWidth(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The width all columns will be adjusted to.</para>
        /// <para>A value of zero disables the adjustment, each item will have a width equal to the width of its content and the columns will have an uneven width.</para>
        /// </summary>
        public int FixedColumnWidth
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFixedColumnWidth();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFixedColumnWidth(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The icon position, whether above or to the left of the text. See the <see cref="Godot.ItemList.IconModeEnum"/> constants.</para>
        /// </summary>
        public ItemList.IconModeEnum IconMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetIconMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetIconMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The scale of icon applied after <see cref="Godot.ItemList.FixedIconSize"/> and transposing takes effect.</para>
        /// </summary>
        public float IconScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetIconScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetIconScale(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The size all icons will be adjusted to.</para>
        /// <para>If either X or Y component is not greater than zero, icon size won't be affected.</para>
        /// </summary>
        public Vector2 FixedIconSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFixedIconSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFixedIconSize(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ItemList";

        public ItemList() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ItemList_Ctor(this);
        }

        internal ItemList(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_item");

        /// <summary>
        /// <para>Adds an item to the item list with specified text. Specify an <c>icon</c>, or use <c>null</c> as the <c>icon</c> for a list item with no icon.</para>
        /// <para>If selectable is <c>true</c>, the list item will be selectable.</para>
        /// </summary>
        [GodotMethod("add_item")]
        public void AddItem(string text, Texture icon = null, bool selectable = true)
        {
            NativeCalls.godot_icall_3_539(method_bind_0, Object.GetPtr(this), text, Object.GetPtr(icon), selectable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_icon_item");

        /// <summary>
        /// <para>Adds an item to the item list with no text, only an icon.</para>
        /// </summary>
        [GodotMethod("add_icon_item")]
        public void AddIconItem(Texture icon, bool selectable = true)
        {
            NativeCalls.godot_icall_2_540(method_bind_1, Object.GetPtr(this), Object.GetPtr(icon), selectable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_text");

        /// <summary>
        /// <para>Sets text of the item associated with the specified index.</para>
        /// </summary>
        [GodotMethod("set_item_text")]
        public void SetItemText(int idx, string text)
        {
            NativeCalls.godot_icall_2_121(method_bind_2, Object.GetPtr(this), idx, text);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_text");

        /// <summary>
        /// <para>Returns the text associated with the specified index.</para>
        /// </summary>
        [GodotMethod("get_item_text")]
        public string GetItemText(int idx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_3, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_icon");

        /// <summary>
        /// <para>Sets (or replaces) the icon's <see cref="Godot.Texture"/> associated with the specified index.</para>
        /// </summary>
        [GodotMethod("set_item_icon")]
        public void SetItemIcon(int idx, Texture icon)
        {
            NativeCalls.godot_icall_2_58(method_bind_4, Object.GetPtr(this), idx, Object.GetPtr(icon));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_icon");

        /// <summary>
        /// <para>Returns the icon associated with the specified index.</para>
        /// </summary>
        [GodotMethod("get_item_icon")]
        public Texture GetItemIcon(int idx)
        {
            return NativeCalls.godot_icall_1_59(method_bind_5, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_icon_transposed");

        /// <summary>
        /// <para>Sets whether the item icon will be drawn transposed.</para>
        /// </summary>
        [GodotMethod("set_item_icon_transposed")]
        public void SetItemIconTransposed(int idx, bool transposed)
        {
            NativeCalls.godot_icall_2_23(method_bind_6, Object.GetPtr(this), idx, transposed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_item_icon_transposed");

        /// <summary>
        /// <para>Returns <c>true</c> if the item icon will be drawn transposed, i.e. the X and Y axes are swapped.</para>
        /// </summary>
        [GodotMethod("is_item_icon_transposed")]
        public bool IsItemIconTransposed(int idx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_7, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_icon_region");

        /// <summary>
        /// <para>Sets the region of item's icon used. The whole icon will be used if the region has no area.</para>
        /// </summary>
        [GodotMethod("set_item_icon_region")]
        public void SetItemIconRegion(int idx, Rect2 rect)
        {
            NativeCalls.godot_icall_2_215(method_bind_8, Object.GetPtr(this), idx, ref rect);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_icon_region");

        /// <summary>
        /// <para>Returns the region of item's icon used. The whole icon will be used if the region has no area.</para>
        /// </summary>
        [GodotMethod("get_item_icon_region")]
        public Rect2 GetItemIconRegion(int idx)
        {
            NativeCalls.godot_icall_1_541(method_bind_9, Object.GetPtr(this), idx, out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_icon_modulate");

        /// <summary>
        /// <para>Sets a modulating <see cref="Godot.Color"/> of the item associated with the specified index.</para>
        /// </summary>
        [GodotMethod("set_item_icon_modulate")]
        public void SetItemIconModulate(int idx, Color modulate)
        {
            NativeCalls.godot_icall_2_464(method_bind_10, Object.GetPtr(this), idx, ref modulate);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_icon_modulate");

        /// <summary>
        /// <para>Returns a <see cref="Godot.Color"/> modulating item's icon at the specified index.</para>
        /// </summary>
        [GodotMethod("get_item_icon_modulate")]
        public Color GetItemIconModulate(int idx)
        {
            NativeCalls.godot_icall_1_465(method_bind_11, Object.GetPtr(this), idx, out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_selectable");

        /// <summary>
        /// <para>Allows or disallows selection of the item associated with the specified index.</para>
        /// </summary>
        [GodotMethod("set_item_selectable")]
        public void SetItemSelectable(int idx, bool selectable)
        {
            NativeCalls.godot_icall_2_23(method_bind_12, Object.GetPtr(this), idx, selectable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_item_selectable");

        /// <summary>
        /// <para>Returns <c>true</c> if the item at the specified index is selectable.</para>
        /// </summary>
        [GodotMethod("is_item_selectable")]
        public bool IsItemSelectable(int idx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_13, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_disabled");

        /// <summary>
        /// <para>Disables (or enables) the item at the specified index.</para>
        /// <para>Disabled items cannot be selected and do not trigger activation signals (when double-clicking or pressing Enter).</para>
        /// </summary>
        [GodotMethod("set_item_disabled")]
        public void SetItemDisabled(int idx, bool disabled)
        {
            NativeCalls.godot_icall_2_23(method_bind_14, Object.GetPtr(this), idx, disabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_item_disabled");

        /// <summary>
        /// <para>Returns <c>true</c> if the item at the specified index is disabled.</para>
        /// </summary>
        [GodotMethod("is_item_disabled")]
        public bool IsItemDisabled(int idx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_15, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_metadata");

        /// <summary>
        /// <para>Sets a value (of any type) to be stored with the item associated with the specified index.</para>
        /// </summary>
        [GodotMethod("set_item_metadata")]
        public void SetItemMetadata(int idx, object metadata)
        {
            NativeCalls.godot_icall_2_542(method_bind_16, Object.GetPtr(this), idx, metadata);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_metadata");

        /// <summary>
        /// <para>Returns the metadata value of the specified index.</para>
        /// </summary>
        [GodotMethod("get_item_metadata")]
        public object GetItemMetadata(int idx)
        {
            return NativeCalls.godot_icall_1_543(method_bind_17, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_custom_bg_color");

        /// <summary>
        /// <para>Sets the background color of the item specified by <c>idx</c> index to the specified <see cref="Godot.Color"/>.</para>
        /// </summary>
        [GodotMethod("set_item_custom_bg_color")]
        public void SetItemCustomBgColor(int idx, Color customBgColor)
        {
            NativeCalls.godot_icall_2_464(method_bind_18, Object.GetPtr(this), idx, ref customBgColor);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_custom_bg_color");

        /// <summary>
        /// <para>Returns the custom background color of the item specified by <c>idx</c> index.</para>
        /// </summary>
        [GodotMethod("get_item_custom_bg_color")]
        public Color GetItemCustomBgColor(int idx)
        {
            NativeCalls.godot_icall_1_465(method_bind_19, Object.GetPtr(this), idx, out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_custom_fg_color");

        /// <summary>
        /// <para>Sets the foreground color of the item specified by <c>idx</c> index to the specified <see cref="Godot.Color"/>.</para>
        /// </summary>
        [GodotMethod("set_item_custom_fg_color")]
        public void SetItemCustomFgColor(int idx, Color customFgColor)
        {
            NativeCalls.godot_icall_2_464(method_bind_20, Object.GetPtr(this), idx, ref customFgColor);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_custom_fg_color");

        /// <summary>
        /// <para>Returns the custom foreground color of the item specified by <c>idx</c> index.</para>
        /// </summary>
        [GodotMethod("get_item_custom_fg_color")]
        public Color GetItemCustomFgColor(int idx)
        {
            NativeCalls.godot_icall_1_465(method_bind_21, Object.GetPtr(this), idx, out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_tooltip_enabled");

        /// <summary>
        /// <para>Sets whether the tooltip hint is enabled for specified item index.</para>
        /// </summary>
        [GodotMethod("set_item_tooltip_enabled")]
        public void SetItemTooltipEnabled(int idx, bool enable)
        {
            NativeCalls.godot_icall_2_23(method_bind_22, Object.GetPtr(this), idx, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_item_tooltip_enabled");

        /// <summary>
        /// <para>Returns <c>true</c> if the tooltip is enabled for specified item index.</para>
        /// </summary>
        [GodotMethod("is_item_tooltip_enabled")]
        public bool IsItemTooltipEnabled(int idx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_23, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_tooltip");

        /// <summary>
        /// <para>Sets the tooltip hint for the item associated with the specified index.</para>
        /// </summary>
        [GodotMethod("set_item_tooltip")]
        public void SetItemTooltip(int idx, string tooltip)
        {
            NativeCalls.godot_icall_2_121(method_bind_24, Object.GetPtr(this), idx, tooltip);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_tooltip");

        /// <summary>
        /// <para>Returns the tooltip hint associated with the specified index.</para>
        /// </summary>
        [GodotMethod("get_item_tooltip")]
        public string GetItemTooltip(int idx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_25, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "select");

        /// <summary>
        /// <para>Select the item at the specified index.</para>
        /// <para>Note: This method does not trigger the item selection signal.</para>
        /// </summary>
        [GodotMethod("select")]
        public void Select(int idx, bool single = true)
        {
            NativeCalls.godot_icall_2_23(method_bind_26, Object.GetPtr(this), idx, single);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "unselect");

        /// <summary>
        /// <para>Ensures the item associated with the specified index is not selected.</para>
        /// </summary>
        [GodotMethod("unselect")]
        public void Unselect(int idx)
        {
            NativeCalls.godot_icall_1_4(method_bind_27, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "unselect_all");

        /// <summary>
        /// <para>Ensures there are no items selected.</para>
        /// </summary>
        [GodotMethod("unselect_all")]
        public void UnselectAll()
        {
            NativeCalls.godot_icall_0_3(method_bind_28, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_selected");

        /// <summary>
        /// <para>Returns <c>true</c> if the item at the specified index is currently selected.</para>
        /// </summary>
        [GodotMethod("is_selected")]
        public bool IsSelected(int idx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_29, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_selected_items");

        /// <summary>
        /// <para>Returns an array with the indexes of the selected items.</para>
        /// </summary>
        [GodotMethod("get_selected_items")]
        public int[] GetSelectedItems()
        {
            return NativeCalls.godot_icall_0_103(method_bind_30, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "move_item");

        /// <summary>
        /// <para>Moves item from index <c>from_idx</c> to <c>to_idx</c>.</para>
        /// </summary>
        [GodotMethod("move_item")]
        public void MoveItem(int fromIdx, int toIdx)
        {
            NativeCalls.godot_icall_2_65(method_bind_31, Object.GetPtr(this), fromIdx, toIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_count");

        /// <summary>
        /// <para>Returns the number of items currently in the list.</para>
        /// </summary>
        [GodotMethod("get_item_count")]
        public int GetItemCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_32, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_item");

        /// <summary>
        /// <para>Removes the item specified by <c>idx</c> index from the list.</para>
        /// </summary>
        [GodotMethod("remove_item")]
        public void RemoveItem(int idx)
        {
            NativeCalls.godot_icall_1_4(method_bind_33, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Removes all items from the list.</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_34, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "sort_items_by_text");

        /// <summary>
        /// <para>Sorts items in the list by their text.</para>
        /// </summary>
        [GodotMethod("sort_items_by_text")]
        public void SortItemsByText()
        {
            NativeCalls.godot_icall_0_3(method_bind_35, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fixed_column_width");

        [GodotMethod("set_fixed_column_width")]
        [Obsolete("SetFixedColumnWidth is deprecated. Use the FixedColumnWidth property instead.")]
        public void SetFixedColumnWidth(int width)
        {
            NativeCalls.godot_icall_1_4(method_bind_36, Object.GetPtr(this), width);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fixed_column_width");

        [GodotMethod("get_fixed_column_width")]
        [Obsolete("GetFixedColumnWidth is deprecated. Use the FixedColumnWidth property instead.")]
        public int GetFixedColumnWidth()
        {
            return NativeCalls.godot_icall_0_5(method_bind_37, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_same_column_width");

        [GodotMethod("set_same_column_width")]
        [Obsolete("SetSameColumnWidth is deprecated. Use the SameColumnWidth property instead.")]
        public void SetSameColumnWidth(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_38, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_same_column_width");

        [GodotMethod("is_same_column_width")]
        [Obsolete("IsSameColumnWidth is deprecated. Use the SameColumnWidth property instead.")]
        public bool IsSameColumnWidth()
        {
            return NativeCalls.godot_icall_0_7(method_bind_39, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max_text_lines");

        [GodotMethod("set_max_text_lines")]
        [Obsolete("SetMaxTextLines is deprecated. Use the MaxTextLines property instead.")]
        public void SetMaxTextLines(int lines)
        {
            NativeCalls.godot_icall_1_4(method_bind_40, Object.GetPtr(this), lines);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max_text_lines");

        [GodotMethod("get_max_text_lines")]
        [Obsolete("GetMaxTextLines is deprecated. Use the MaxTextLines property instead.")]
        public int GetMaxTextLines()
        {
            return NativeCalls.godot_icall_0_5(method_bind_41, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max_columns");

        [GodotMethod("set_max_columns")]
        [Obsolete("SetMaxColumns is deprecated. Use the MaxColumns property instead.")]
        public void SetMaxColumns(int amount)
        {
            NativeCalls.godot_icall_1_4(method_bind_42, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max_columns");

        [GodotMethod("get_max_columns")]
        [Obsolete("GetMaxColumns is deprecated. Use the MaxColumns property instead.")]
        public int GetMaxColumns()
        {
            return NativeCalls.godot_icall_0_5(method_bind_43, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_select_mode");

        [GodotMethod("set_select_mode")]
        [Obsolete("SetSelectMode is deprecated. Use the SelectMode property instead.")]
        public void SetSelectMode(ItemList.SelectModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_44, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_select_mode");

        [GodotMethod("get_select_mode")]
        [Obsolete("GetSelectMode is deprecated. Use the SelectMode property instead.")]
        public ItemList.SelectModeEnum GetSelectMode()
        {
            return (ItemList.SelectModeEnum)NativeCalls.godot_icall_0_544(method_bind_45, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_icon_mode");

        [GodotMethod("set_icon_mode")]
        [Obsolete("SetIconMode is deprecated. Use the IconMode property instead.")]
        public void SetIconMode(ItemList.IconModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_46, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_icon_mode");

        [GodotMethod("get_icon_mode")]
        [Obsolete("GetIconMode is deprecated. Use the IconMode property instead.")]
        public ItemList.IconModeEnum GetIconMode()
        {
            return (ItemList.IconModeEnum)NativeCalls.godot_icall_0_545(method_bind_47, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fixed_icon_size");

        [GodotMethod("set_fixed_icon_size")]
        [Obsolete("SetFixedIconSize is deprecated. Use the FixedIconSize property instead.")]
        public void SetFixedIconSize(Vector2 size)
        {
            NativeCalls.godot_icall_1_57(method_bind_48, Object.GetPtr(this), ref size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fixed_icon_size");

        [GodotMethod("get_fixed_icon_size")]
        [Obsolete("GetFixedIconSize is deprecated. Use the FixedIconSize property instead.")]
        public Vector2 GetFixedIconSize()
        {
            NativeCalls.godot_icall_0_18(method_bind_49, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_icon_scale");

        [GodotMethod("set_icon_scale")]
        [Obsolete("SetIconScale is deprecated. Use the IconScale property instead.")]
        public void SetIconScale(float scale)
        {
            NativeCalls.godot_icall_1_15(method_bind_50, Object.GetPtr(this), scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_icon_scale");

        [GodotMethod("get_icon_scale")]
        [Obsolete("GetIconScale is deprecated. Use the IconScale property instead.")]
        public float GetIconScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_51, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_allow_rmb_select");

        [GodotMethod("set_allow_rmb_select")]
        [Obsolete("SetAllowRmbSelect is deprecated. Use the AllowRmbSelect property instead.")]
        public void SetAllowRmbSelect(bool allow)
        {
            NativeCalls.godot_icall_1_16(method_bind_52, Object.GetPtr(this), allow);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_53 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_allow_rmb_select");

        [GodotMethod("get_allow_rmb_select")]
        [Obsolete("GetAllowRmbSelect is deprecated. Use the AllowRmbSelect property instead.")]
        public bool GetAllowRmbSelect()
        {
            return NativeCalls.godot_icall_0_7(method_bind_53, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_54 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_allow_reselect");

        [GodotMethod("set_allow_reselect")]
        [Obsolete("SetAllowReselect is deprecated. Use the AllowReselect property instead.")]
        public void SetAllowReselect(bool allow)
        {
            NativeCalls.godot_icall_1_16(method_bind_54, Object.GetPtr(this), allow);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_55 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_allow_reselect");

        [GodotMethod("get_allow_reselect")]
        [Obsolete("GetAllowReselect is deprecated. Use the AllowReselect property instead.")]
        public bool GetAllowReselect()
        {
            return NativeCalls.godot_icall_0_7(method_bind_55, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_56 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_auto_height");

        [GodotMethod("set_auto_height")]
        [Obsolete("SetAutoHeight is deprecated. Use the AutoHeight property instead.")]
        public void SetAutoHeight(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_56, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_57 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_auto_height");

        [GodotMethod("has_auto_height")]
        [Obsolete("HasAutoHeight is deprecated. Use the AutoHeight property instead.")]
        public bool HasAutoHeight()
        {
            return NativeCalls.godot_icall_0_7(method_bind_57, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_58 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_anything_selected");

        /// <summary>
        /// <para>Returns <c>true</c> if one or more items are selected.</para>
        /// </summary>
        [GodotMethod("is_anything_selected")]
        public bool IsAnythingSelected()
        {
            return NativeCalls.godot_icall_0_7(method_bind_58, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_59 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_at_position");

        /// <summary>
        /// <para>Returns the item index at the given <c>position</c>.</para>
        /// <para>When there is no item at that point, -1 will be returned if <c>exact</c> is <c>true</c>, and the closest item index will be returned otherwise.</para>
        /// </summary>
        [GodotMethod("get_item_at_position")]
        public int GetItemAtPosition(Vector2 position, bool exact = false)
        {
            return NativeCalls.godot_icall_2_46(method_bind_59, Object.GetPtr(this), ref position, exact);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_60 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "ensure_current_is_visible");

        /// <summary>
        /// <para>Ensure current selection is visible, adjusting the scroll position as necessary.</para>
        /// </summary>
        [GodotMethod("ensure_current_is_visible")]
        public void EnsureCurrentIsVisible()
        {
            NativeCalls.godot_icall_0_3(method_bind_60, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_61 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_v_scroll");

        /// <summary>
        /// <para>Returns the vertical scrollbar.</para>
        /// <para>Warning: This is a required internal node, removing and freeing it may cause a crash. If you wish to hide it or any of its children, use their <see cref="Godot.CanvasItem.Visible"/> property.</para>
        /// </summary>
        [GodotMethod("get_v_scroll")]
        public VScrollBar GetVScroll()
        {
            return NativeCalls.godot_icall_0_546(method_bind_61, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_62 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_items");

        [Obsolete("_SetItems is deprecated. Use the Items property instead.")]
        internal void _SetItems(Godot.Collections.Array arg0)
        {
            NativeCalls.godot_icall_1_92(method_bind_62, Object.GetPtr(this), arg0.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_63 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_items");

        [Obsolete("_GetItems is deprecated. Use the Items property instead.")]
        internal Godot.Collections.Array _GetItems()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_63, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
