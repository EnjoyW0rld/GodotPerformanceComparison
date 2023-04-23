using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>OptionButton is a type button that provides a selectable list of items when pressed. The item selected becomes the "current" item and is displayed as the button text.</para>
    /// <para>See also <see cref="Godot.BaseButton"/> which contains common properties and methods associated with this node.</para>
    /// </summary>
    public partial class OptionButton : Button
    {
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
        /// <para>The index of the currently selected item, or <c>-1</c> if no item is selected.</para>
        /// </summary>
        public int Selected
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSelected();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SelectInt(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "OptionButton";

        public OptionButton() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_OptionButton_Ctor(this);
        }

        internal OptionButton(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_item");

        /// <summary>
        /// <para>Adds an item, with text <c>label</c> and (optionally) <c>id</c>. If no <c>id</c> is passed, the item index will be used as the item's ID. New items are appended at the end.</para>
        /// </summary>
        [GodotMethod("add_item")]
        public void AddItem(string label, int id = -1)
        {
            NativeCalls.godot_icall_2_110(method_bind_0, Object.GetPtr(this), label, id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_icon_item");

        /// <summary>
        /// <para>Adds an item, with a <c>texture</c> icon, text <c>label</c> and (optionally) <c>id</c>. If no <c>id</c> is passed, the item index will be used as the item's ID. New items are appended at the end.</para>
        /// </summary>
        [GodotMethod("add_icon_item")]
        public void AddIconItem(Texture texture, string label, int id = -1)
        {
            NativeCalls.godot_icall_3_708(method_bind_1, Object.GetPtr(this), Object.GetPtr(texture), label, id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_text");

        /// <summary>
        /// <para>Sets the text of the item at index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("set_item_text")]
        public void SetItemText(int idx, string text)
        {
            NativeCalls.godot_icall_2_121(method_bind_2, Object.GetPtr(this), idx, text);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_icon");

        /// <summary>
        /// <para>Sets the icon of the item at index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("set_item_icon")]
        public void SetItemIcon(int idx, Texture texture)
        {
            NativeCalls.godot_icall_2_58(method_bind_3, Object.GetPtr(this), idx, Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_disabled");

        /// <summary>
        /// <para>Sets whether the item at index <c>idx</c> is disabled.</para>
        /// <para>Disabled items are drawn differently in the dropdown and are not selectable by the user. If the current selected item is set as disabled, it will remain selected.</para>
        /// </summary>
        [GodotMethod("set_item_disabled")]
        public void SetItemDisabled(int idx, bool disabled)
        {
            NativeCalls.godot_icall_2_23(method_bind_4, Object.GetPtr(this), idx, disabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_id");

        /// <summary>
        /// <para>Sets the ID of the item at index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("set_item_id")]
        public void SetItemId(int idx, int id)
        {
            NativeCalls.godot_icall_2_65(method_bind_5, Object.GetPtr(this), idx, id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_metadata");

        /// <summary>
        /// <para>Sets the metadata of an item. Metadata may be of any type and can be used to store extra information about an item, such as an external string ID.</para>
        /// </summary>
        [GodotMethod("set_item_metadata")]
        public void SetItemMetadata(int idx, object metadata)
        {
            NativeCalls.godot_icall_2_542(method_bind_6, Object.GetPtr(this), idx, metadata);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_tooltip");

        /// <summary>
        /// <para>Sets the tooltip of the item at index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("set_item_tooltip")]
        public void SetItemTooltip(int idx, string tooltip)
        {
            NativeCalls.godot_icall_2_121(method_bind_7, Object.GetPtr(this), idx, tooltip);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_text");

        /// <summary>
        /// <para>Returns the text of the item at index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_item_text")]
        public string GetItemText(int idx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_8, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_icon");

        /// <summary>
        /// <para>Returns the icon of the item at index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_item_icon")]
        public Texture GetItemIcon(int idx)
        {
            return NativeCalls.godot_icall_1_59(method_bind_9, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_id");

        /// <summary>
        /// <para>Returns the ID of the item at index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_item_id")]
        public int GetItemId(int idx)
        {
            return NativeCalls.godot_icall_1_11(method_bind_10, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_index");

        /// <summary>
        /// <para>Returns the index of the item with the given <c>id</c>.</para>
        /// </summary>
        [GodotMethod("get_item_index")]
        public int GetItemIndex(int id)
        {
            return NativeCalls.godot_icall_1_11(method_bind_11, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_metadata");

        /// <summary>
        /// <para>Retrieves the metadata of an item. Metadata may be any type and can be used to store extra information about an item, such as an external string ID.</para>
        /// </summary>
        [GodotMethod("get_item_metadata")]
        public object GetItemMetadata(int idx)
        {
            return NativeCalls.godot_icall_1_543(method_bind_12, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_tooltip");

        /// <summary>
        /// <para>Returns the tooltip of the item at index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_item_tooltip")]
        public string GetItemTooltip(int idx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_13, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_item_disabled");

        /// <summary>
        /// <para>Returns <c>true</c> if the item at index <c>idx</c> is disabled.</para>
        /// </summary>
        [GodotMethod("is_item_disabled")]
        public bool IsItemDisabled(int idx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_14, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_count");

        /// <summary>
        /// <para>Returns the amount of items in the OptionButton, including separators.</para>
        /// </summary>
        [GodotMethod("get_item_count")]
        public int GetItemCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_separator");

        /// <summary>
        /// <para>Adds a separator to the list of items. Separators help to group items. Separator also takes up an index and is appended at the end.</para>
        /// </summary>
        [GodotMethod("add_separator")]
        public void AddSeparator()
        {
            NativeCalls.godot_icall_0_3(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Clears all the items in the <see cref="Godot.OptionButton"/>.</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "select");

        /// <summary>
        /// <para>Selects an item by index and makes it the current item. This will work even if the item is disabled.</para>
        /// <para>Passing <c>-1</c> as the index deselects any currently selected item.</para>
        /// </summary>
        [GodotMethod("select")]
        public void Select(int idx)
        {
            NativeCalls.godot_icall_1_4(method_bind_18, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_selected");

        [GodotMethod("get_selected")]
        [Obsolete("GetSelected is deprecated. Use the Selected property instead.")]
        public int GetSelected()
        {
            return NativeCalls.godot_icall_0_5(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_selected_id");

        /// <summary>
        /// <para>Returns the ID of the selected item, or <c>-1</c> if no item is selected.</para>
        /// </summary>
        [GodotMethod("get_selected_id")]
        public int GetSelectedId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_selected_metadata");

        /// <summary>
        /// <para>Gets the metadata of the selected item. Metadata for items can be set using <see cref="Godot.OptionButton.SetItemMetadata"/>.</para>
        /// </summary>
        [GodotMethod("get_selected_metadata")]
        public object GetSelectedMetadata()
        {
            return NativeCalls.godot_icall_0_547(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_item");

        /// <summary>
        /// <para>Removes the item at index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("remove_item")]
        public void RemoveItem(int idx)
        {
            NativeCalls.godot_icall_1_4(method_bind_22, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_select_int");

        [Obsolete("_SelectInt is deprecated. Use the Selected property instead.")]
        internal void _SelectInt(int arg0)
        {
            NativeCalls.godot_icall_1_4(method_bind_23, Object.GetPtr(this), arg0);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_popup");

        /// <summary>
        /// <para>Returns the <see cref="Godot.PopupMenu"/> contained in this button.</para>
        /// <para>Warning: This is a required internal node, removing and freeing it may cause a crash. If you wish to hide it or any of its children, use their <see cref="Godot.CanvasItem.Visible"/> property.</para>
        /// </summary>
        [GodotMethod("get_popup")]
        public PopupMenu GetPopup()
        {
            return NativeCalls.godot_icall_0_591(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_items");

        [Obsolete("_SetItems is deprecated. Use the Items property instead.")]
        internal void _SetItems(Godot.Collections.Array arg0)
        {
            NativeCalls.godot_icall_1_92(method_bind_25, Object.GetPtr(this), arg0.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_items");

        [Obsolete("_GetItems is deprecated. Use the Items property instead.")]
        internal Godot.Collections.Array _GetItems()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_26, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
