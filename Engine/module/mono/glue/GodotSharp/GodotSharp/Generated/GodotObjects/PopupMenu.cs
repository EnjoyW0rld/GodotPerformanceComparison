using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.PopupMenu"/> is a <see cref="Godot.Control"/> that displays a list of options. They are popular in toolbars or context menus.</para>
    /// <para>Incremental search: Like <see cref="Godot.ItemList"/> and <see cref="Godot.Tree"/>, <see cref="Godot.PopupMenu"/> supports searching within the list while the control is focused. Press a key that matches the first letter of an item's name to select the first item starting with the given letter. After that point, there are two ways to perform incremental search: 1) Press the same key again before the timeout duration to select the next item starting with the same letter. 2) Press letter keys that match the rest of the word before the timeout duration to match to select the item in question directly. Both of these actions will be reset to the beginning of the list if the timeout duration has passed since the last keystroke was registered. You can adjust the timeout duration by changing .</para>
    /// </summary>
    public partial class PopupMenu : Popup
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
        /// <para>If <c>true</c>, hides the <see cref="Godot.PopupMenu"/> when an item is selected.</para>
        /// </summary>
        public bool HideOnItemSelection
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsHideOnItemSelection();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHideOnItemSelection(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, hides the <see cref="Godot.PopupMenu"/> when a checkbox or radio button is selected.</para>
        /// </summary>
        public bool HideOnCheckableItemSelection
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsHideOnCheckableItemSelection();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHideOnCheckableItemSelection(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, hides the <see cref="Godot.PopupMenu"/> when a state item is selected.</para>
        /// </summary>
        public bool HideOnStateItemSelection
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsHideOnStateItemSelection();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHideOnStateItemSelection(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the delay time in seconds for the submenu item to popup on mouse hovering. If the popup menu is added as a child of another (acting as a submenu), it will inherit the delay time of the parent menu item.</para>
        /// </summary>
        public float SubmenuPopupDelay
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSubmenuPopupDelay();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSubmenuPopupDelay(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, allows navigating <see cref="Godot.PopupMenu"/> with letter keys.</para>
        /// </summary>
        public bool AllowSearch
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAllowSearch();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAllowSearch(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "PopupMenu";

        public PopupMenu() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PopupMenu_Ctor(this);
        }

        internal PopupMenu(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_item");

        /// <summary>
        /// <para>Adds a new item with text <c>label</c>.</para>
        /// <para>An <c>id</c> can optionally be provided, as well as an accelerator (<c>accel</c>). If no <c>id</c> is provided, one will be created from the index. If no <c>accel</c> is provided then the default <c>0</c> will be assigned to it. See <see cref="Godot.PopupMenu.GetItemAccelerator"/> for more info on accelerators.</para>
        /// </summary>
        [GodotMethod("add_item")]
        public void AddItem(string label, int id = -1, uint accel = (uint)0)
        {
            NativeCalls.godot_icall_3_798(method_bind_0, Object.GetPtr(this), label, id, accel);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_icon_item");

        /// <summary>
        /// <para>Adds a new item with text <c>label</c> and icon <c>texture</c>.</para>
        /// <para>An <c>id</c> can optionally be provided, as well as an accelerator (<c>accel</c>). If no <c>id</c> is provided, one will be created from the index. If no <c>accel</c> is provided then the default <c>0</c> will be assigned to it. See <see cref="Godot.PopupMenu.GetItemAccelerator"/> for more info on accelerators.</para>
        /// </summary>
        [GodotMethod("add_icon_item")]
        public void AddIconItem(Texture texture, string label, int id = -1, uint accel = (uint)0)
        {
            NativeCalls.godot_icall_4_799(method_bind_1, Object.GetPtr(this), Object.GetPtr(texture), label, id, accel);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_check_item");

        /// <summary>
        /// <para>Adds a new checkable item with text <c>label</c>.</para>
        /// <para>An <c>id</c> can optionally be provided, as well as an accelerator (<c>accel</c>). If no <c>id</c> is provided, one will be created from the index. If no <c>accel</c> is provided then the default <c>0</c> will be assigned to it. See <see cref="Godot.PopupMenu.GetItemAccelerator"/> for more info on accelerators.</para>
        /// <para>Note: Checkable items just display a checkmark, but don't have any built-in checking behavior and must be checked/unchecked manually. See <see cref="Godot.PopupMenu.SetItemChecked"/> for more info on how to control it.</para>
        /// </summary>
        [GodotMethod("add_check_item")]
        public void AddCheckItem(string label, int id = -1, uint accel = (uint)0)
        {
            NativeCalls.godot_icall_3_798(method_bind_2, Object.GetPtr(this), label, id, accel);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_icon_check_item");

        /// <summary>
        /// <para>Adds a new checkable item with text <c>label</c> and icon <c>texture</c>.</para>
        /// <para>An <c>id</c> can optionally be provided, as well as an accelerator (<c>accel</c>). If no <c>id</c> is provided, one will be created from the index. If no <c>accel</c> is provided then the default <c>0</c> will be assigned to it. See <see cref="Godot.PopupMenu.GetItemAccelerator"/> for more info on accelerators.</para>
        /// <para>Note: Checkable items just display a checkmark, but don't have any built-in checking behavior and must be checked/unchecked manually. See <see cref="Godot.PopupMenu.SetItemChecked"/> for more info on how to control it.</para>
        /// </summary>
        [GodotMethod("add_icon_check_item")]
        public void AddIconCheckItem(Texture texture, string label, int id = -1, uint accel = (uint)0)
        {
            NativeCalls.godot_icall_4_799(method_bind_3, Object.GetPtr(this), Object.GetPtr(texture), label, id, accel);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_radio_check_item");

        /// <summary>
        /// <para>Adds a new radio check button with text <c>label</c>.</para>
        /// <para>An <c>id</c> can optionally be provided, as well as an accelerator (<c>accel</c>). If no <c>id</c> is provided, one will be created from the index. If no <c>accel</c> is provided then the default <c>0</c> will be assigned to it. See <see cref="Godot.PopupMenu.GetItemAccelerator"/> for more info on accelerators.</para>
        /// <para>Note: Checkable items just display a checkmark, but don't have any built-in checking behavior and must be checked/unchecked manually. See <see cref="Godot.PopupMenu.SetItemChecked"/> for more info on how to control it.</para>
        /// </summary>
        [GodotMethod("add_radio_check_item")]
        public void AddRadioCheckItem(string label, int id = -1, uint accel = (uint)0)
        {
            NativeCalls.godot_icall_3_798(method_bind_4, Object.GetPtr(this), label, id, accel);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_icon_radio_check_item");

        /// <summary>
        /// <para>Same as <see cref="Godot.PopupMenu.AddIconCheckItem"/>, but uses a radio check button.</para>
        /// </summary>
        [GodotMethod("add_icon_radio_check_item")]
        public void AddIconRadioCheckItem(Texture texture, string label, int id = -1, uint accel = (uint)0)
        {
            NativeCalls.godot_icall_4_799(method_bind_5, Object.GetPtr(this), Object.GetPtr(texture), label, id, accel);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_multistate_item");

        /// <summary>
        /// <para>Adds a new multistate item with text <c>label</c>.</para>
        /// <para>Contrarily to normal binary items, multistate items can have more than two states, as defined by <c>max_states</c>. Each press or activate of the item will increase the state by one. The default value is defined by <c>default_state</c>.</para>
        /// <para>An <c>id</c> can optionally be provided, as well as an accelerator (<c>accel</c>). If no <c>id</c> is provided, one will be created from the index. If no <c>accel</c> is provided then the default <c>0</c> will be assigned to it. See <see cref="Godot.PopupMenu.GetItemAccelerator"/> for more info on accelerators.</para>
        /// </summary>
        [GodotMethod("add_multistate_item")]
        public void AddMultistateItem(string label, int maxStates, int defaultState = 0, int id = -1, uint accel = (uint)0)
        {
            NativeCalls.godot_icall_5_800(method_bind_6, Object.GetPtr(this), label, maxStates, defaultState, id, accel);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_shortcut");

        /// <summary>
        /// <para>Adds a <see cref="Godot.ShortCut"/>.</para>
        /// <para>An <c>id</c> can optionally be provided. If no <c>id</c> is provided, one will be created from the index.</para>
        /// </summary>
        [GodotMethod("add_shortcut")]
        public void AddShortcut(ShortCut shortcut, int id = -1, bool global = false)
        {
            NativeCalls.godot_icall_3_801(method_bind_7, Object.GetPtr(this), Object.GetPtr(shortcut), id, global);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_icon_shortcut");

        /// <summary>
        /// <para>Adds a new item and assigns the specified <see cref="Godot.ShortCut"/> and icon <c>texture</c> to it. Sets the label of the checkbox to the <see cref="Godot.ShortCut"/>'s name.</para>
        /// <para>An <c>id</c> can optionally be provided. If no <c>id</c> is provided, one will be created from the index.</para>
        /// </summary>
        [GodotMethod("add_icon_shortcut")]
        public void AddIconShortcut(Texture texture, ShortCut shortcut, int id = -1, bool global = false)
        {
            NativeCalls.godot_icall_4_802(method_bind_8, Object.GetPtr(this), Object.GetPtr(texture), Object.GetPtr(shortcut), id, global);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_check_shortcut");

        /// <summary>
        /// <para>Adds a new checkable item and assigns the specified <see cref="Godot.ShortCut"/> to it. Sets the label of the checkbox to the <see cref="Godot.ShortCut"/>'s name.</para>
        /// <para>An <c>id</c> can optionally be provided. If no <c>id</c> is provided, one will be created from the index.</para>
        /// <para>Note: Checkable items just display a checkmark, but don't have any built-in checking behavior and must be checked/unchecked manually. See <see cref="Godot.PopupMenu.SetItemChecked"/> for more info on how to control it.</para>
        /// </summary>
        [GodotMethod("add_check_shortcut")]
        public void AddCheckShortcut(ShortCut shortcut, int id = -1, bool global = false)
        {
            NativeCalls.godot_icall_3_801(method_bind_9, Object.GetPtr(this), Object.GetPtr(shortcut), id, global);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_icon_check_shortcut");

        /// <summary>
        /// <para>Adds a new checkable item and assigns the specified <see cref="Godot.ShortCut"/> and icon <c>texture</c> to it. Sets the label of the checkbox to the <see cref="Godot.ShortCut"/>'s name.</para>
        /// <para>An <c>id</c> can optionally be provided. If no <c>id</c> is provided, one will be created from the index.</para>
        /// <para>Note: Checkable items just display a checkmark, but don't have any built-in checking behavior and must be checked/unchecked manually. See <see cref="Godot.PopupMenu.SetItemChecked"/> for more info on how to control it.</para>
        /// </summary>
        [GodotMethod("add_icon_check_shortcut")]
        public void AddIconCheckShortcut(Texture texture, ShortCut shortcut, int id = -1, bool global = false)
        {
            NativeCalls.godot_icall_4_802(method_bind_10, Object.GetPtr(this), Object.GetPtr(texture), Object.GetPtr(shortcut), id, global);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_radio_check_shortcut");

        /// <summary>
        /// <para>Adds a new radio check button and assigns a <see cref="Godot.ShortCut"/> to it. Sets the label of the checkbox to the <see cref="Godot.ShortCut"/>'s name.</para>
        /// <para>An <c>id</c> can optionally be provided. If no <c>id</c> is provided, one will be created from the index.</para>
        /// <para>Note: Checkable items just display a checkmark, but don't have any built-in checking behavior and must be checked/unchecked manually. See <see cref="Godot.PopupMenu.SetItemChecked"/> for more info on how to control it.</para>
        /// </summary>
        [GodotMethod("add_radio_check_shortcut")]
        public void AddRadioCheckShortcut(ShortCut shortcut, int id = -1, bool global = false)
        {
            NativeCalls.godot_icall_3_801(method_bind_11, Object.GetPtr(this), Object.GetPtr(shortcut), id, global);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_icon_radio_check_shortcut");

        /// <summary>
        /// <para>Same as <see cref="Godot.PopupMenu.AddIconCheckShortcut"/>, but uses a radio check button.</para>
        /// </summary>
        [GodotMethod("add_icon_radio_check_shortcut")]
        public void AddIconRadioCheckShortcut(Texture texture, ShortCut shortcut, int id = -1, bool global = false)
        {
            NativeCalls.godot_icall_4_802(method_bind_12, Object.GetPtr(this), Object.GetPtr(texture), Object.GetPtr(shortcut), id, global);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_submenu_item");

        /// <summary>
        /// <para>Adds an item that will act as a submenu of the parent <see cref="Godot.PopupMenu"/> node when clicked. The <c>submenu</c> argument is the name of the child <see cref="Godot.PopupMenu"/> node that will be shown when the item is clicked.</para>
        /// <para>An <c>id</c> can optionally be provided. If no <c>id</c> is provided, one will be created from the index.</para>
        /// </summary>
        [GodotMethod("add_submenu_item")]
        public void AddSubmenuItem(string label, string submenu, int id = -1)
        {
            NativeCalls.godot_icall_3_803(method_bind_13, Object.GetPtr(this), label, submenu, id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_text");

        /// <summary>
        /// <para>Sets the text of the item at index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("set_item_text")]
        public void SetItemText(int idx, string text)
        {
            NativeCalls.godot_icall_2_121(method_bind_14, Object.GetPtr(this), idx, text);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_icon");

        /// <summary>
        /// <para>Replaces the <see cref="Godot.Texture"/> icon of the specified <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("set_item_icon")]
        public void SetItemIcon(int idx, Texture icon)
        {
            NativeCalls.godot_icall_2_58(method_bind_15, Object.GetPtr(this), idx, Object.GetPtr(icon));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_checked");

        /// <summary>
        /// <para>Sets the checkstate status of the item at index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("set_item_checked")]
        public void SetItemChecked(int idx, bool @checked)
        {
            NativeCalls.godot_icall_2_23(method_bind_16, Object.GetPtr(this), idx, @checked);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_id");

        /// <summary>
        /// <para>Sets the <c>id</c> of the item at index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("set_item_id")]
        public void SetItemId(int idx, int id)
        {
            NativeCalls.godot_icall_2_65(method_bind_17, Object.GetPtr(this), idx, id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_accelerator");

        /// <summary>
        /// <para>Sets the accelerator of the item at index <c>idx</c>. Accelerators are special combinations of keys that activate the item, no matter which control is focused.</para>
        /// </summary>
        [GodotMethod("set_item_accelerator")]
        public void SetItemAccelerator(int idx, uint accel)
        {
            NativeCalls.godot_icall_2_804(method_bind_18, Object.GetPtr(this), idx, accel);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_metadata");

        /// <summary>
        /// <para>Sets the metadata of an item, which may be of any type. You can later get it with <see cref="Godot.PopupMenu.GetItemMetadata"/>, which provides a simple way of assigning context data to items.</para>
        /// </summary>
        [GodotMethod("set_item_metadata")]
        public void SetItemMetadata(int idx, object metadata)
        {
            NativeCalls.godot_icall_2_542(method_bind_19, Object.GetPtr(this), idx, metadata);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_disabled");

        /// <summary>
        /// <para>Enables/disables the item at index <c>idx</c>. When it is disabled, it can't be selected and its action can't be invoked.</para>
        /// </summary>
        [GodotMethod("set_item_disabled")]
        public void SetItemDisabled(int idx, bool disabled)
        {
            NativeCalls.godot_icall_2_23(method_bind_20, Object.GetPtr(this), idx, disabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_submenu");

        /// <summary>
        /// <para>Sets the submenu of the item at index <c>idx</c>. The submenu is the name of a child <see cref="Godot.PopupMenu"/> node that would be shown when the item is clicked.</para>
        /// </summary>
        [GodotMethod("set_item_submenu")]
        public void SetItemSubmenu(int idx, string submenu)
        {
            NativeCalls.godot_icall_2_121(method_bind_21, Object.GetPtr(this), idx, submenu);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_as_separator");

        /// <summary>
        /// <para>Mark the item at index <c>idx</c> as a separator, which means that it would be displayed as a line. If <c>false</c>, sets the type of the item to plain text.</para>
        /// </summary>
        [GodotMethod("set_item_as_separator")]
        public void SetItemAsSeparator(int idx, bool enable)
        {
            NativeCalls.godot_icall_2_23(method_bind_22, Object.GetPtr(this), idx, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_as_checkable");

        /// <summary>
        /// <para>Sets whether the item at index <c>idx</c> has a checkbox. If <c>false</c>, sets the type of the item to plain text.</para>
        /// <para>Note: Checkable items just display a checkmark, but don't have any built-in checking behavior and must be checked/unchecked manually.</para>
        /// </summary>
        [GodotMethod("set_item_as_checkable")]
        public void SetItemAsCheckable(int idx, bool enable)
        {
            NativeCalls.godot_icall_2_23(method_bind_23, Object.GetPtr(this), idx, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_as_radio_checkable");

        /// <summary>
        /// <para>Sets the type of the item at the specified index <c>idx</c> to radio button. If <c>false</c>, sets the type of the item to plain text.</para>
        /// </summary>
        [GodotMethod("set_item_as_radio_checkable")]
        public void SetItemAsRadioCheckable(int idx, bool enable)
        {
            NativeCalls.godot_icall_2_23(method_bind_24, Object.GetPtr(this), idx, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_tooltip");

        /// <summary>
        /// <para>Sets the <see cref="string"/> tooltip of the item at the specified index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("set_item_tooltip")]
        public void SetItemTooltip(int idx, string tooltip)
        {
            NativeCalls.godot_icall_2_121(method_bind_25, Object.GetPtr(this), idx, tooltip);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_shortcut");

        /// <summary>
        /// <para>Sets a <see cref="Godot.ShortCut"/> for the specified item <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("set_item_shortcut")]
        public void SetItemShortcut(int idx, ShortCut shortcut, bool global = false)
        {
            NativeCalls.godot_icall_3_805(method_bind_26, Object.GetPtr(this), idx, Object.GetPtr(shortcut), global);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_multistate");

        /// <summary>
        /// <para>Sets the state of a multistate item. See <see cref="Godot.PopupMenu.AddMultistateItem"/> for details.</para>
        /// </summary>
        [GodotMethod("set_item_multistate")]
        public void SetItemMultistate(int idx, int state)
        {
            NativeCalls.godot_icall_2_65(method_bind_27, Object.GetPtr(this), idx, state);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_shortcut_disabled");

        /// <summary>
        /// <para>Disables the <see cref="Godot.ShortCut"/> of the specified index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("set_item_shortcut_disabled")]
        public void SetItemShortcutDisabled(int idx, bool disabled)
        {
            NativeCalls.godot_icall_2_23(method_bind_28, Object.GetPtr(this), idx, disabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "toggle_item_checked");

        /// <summary>
        /// <para>Toggles the check state of the item of the specified index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("toggle_item_checked")]
        public void ToggleItemChecked(int idx)
        {
            NativeCalls.godot_icall_1_4(method_bind_29, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "toggle_item_multistate");

        /// <summary>
        /// <para>Cycle to the next state of a multistate item. See <see cref="Godot.PopupMenu.AddMultistateItem"/> for details.</para>
        /// </summary>
        [GodotMethod("toggle_item_multistate")]
        public void ToggleItemMultistate(int idx)
        {
            NativeCalls.godot_icall_1_4(method_bind_30, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_text");

        /// <summary>
        /// <para>Returns the text of the item at index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_item_text")]
        public string GetItemText(int idx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_31, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_icon");

        /// <summary>
        /// <para>Returns the icon of the item at index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_item_icon")]
        public Texture GetItemIcon(int idx)
        {
            return NativeCalls.godot_icall_1_59(method_bind_32, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_item_checked");

        /// <summary>
        /// <para>Returns <c>true</c> if the item at index <c>idx</c> is checked.</para>
        /// </summary>
        [GodotMethod("is_item_checked")]
        public bool IsItemChecked(int idx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_33, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_id");

        /// <summary>
        /// <para>Returns the id of the item at index <c>idx</c>. <c>id</c> can be manually assigned, while index can not.</para>
        /// </summary>
        [GodotMethod("get_item_id")]
        public int GetItemId(int idx)
        {
            return NativeCalls.godot_icall_1_11(method_bind_34, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_index");

        /// <summary>
        /// <para>Returns the index of the item containing the specified <c>id</c>. Index is automatically assigned to each item by the engine. Index can not be set manually.</para>
        /// </summary>
        [GodotMethod("get_item_index")]
        public int GetItemIndex(int id)
        {
            return NativeCalls.godot_icall_1_11(method_bind_35, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_accelerator");

        /// <summary>
        /// <para>Returns the accelerator of the item at index <c>idx</c>. Accelerators are special combinations of keys that activate the item, no matter which control is focused.</para>
        /// </summary>
        [GodotMethod("get_item_accelerator")]
        public uint GetItemAccelerator(int idx)
        {
            return NativeCalls.godot_icall_1_154(method_bind_36, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_metadata");

        /// <summary>
        /// <para>Returns the metadata of the specified item, which might be of any type. You can set it with <see cref="Godot.PopupMenu.SetItemMetadata"/>, which provides a simple way of assigning context data to items.</para>
        /// </summary>
        [GodotMethod("get_item_metadata")]
        public object GetItemMetadata(int idx)
        {
            return NativeCalls.godot_icall_1_543(method_bind_37, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_item_disabled");

        /// <summary>
        /// <para>Returns <c>true</c> if the item at index <c>idx</c> is disabled. When it is disabled it can't be selected, or its action invoked.</para>
        /// <para>See <see cref="Godot.PopupMenu.SetItemDisabled"/> for more info on how to disable an item.</para>
        /// </summary>
        [GodotMethod("is_item_disabled")]
        public bool IsItemDisabled(int idx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_38, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_submenu");

        /// <summary>
        /// <para>Returns the submenu name of the item at index <c>idx</c>. See <see cref="Godot.PopupMenu.AddSubmenuItem"/> for more info on how to add a submenu.</para>
        /// </summary>
        [GodotMethod("get_item_submenu")]
        public string GetItemSubmenu(int idx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_39, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_item_separator");

        /// <summary>
        /// <para>Returns <c>true</c> if the item is a separator. If it is, it will be displayed as a line. See <see cref="Godot.PopupMenu.AddSeparator"/> for more info on how to add a separator.</para>
        /// </summary>
        [GodotMethod("is_item_separator")]
        public bool IsItemSeparator(int idx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_40, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_item_checkable");

        /// <summary>
        /// <para>Returns <c>true</c> if the item at index <c>idx</c> is checkable in some way, i.e. if it has a checkbox or radio button.</para>
        /// <para>Note: Checkable items just display a checkmark or radio button, but don't have any built-in checking behavior and must be checked/unchecked manually.</para>
        /// </summary>
        [GodotMethod("is_item_checkable")]
        public bool IsItemCheckable(int idx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_41, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_item_radio_checkable");

        /// <summary>
        /// <para>Returns <c>true</c> if the item at index <c>idx</c> has radio button-style checkability.</para>
        /// <para>Note: This is purely cosmetic; you must add the logic for checking/unchecking items in radio groups.</para>
        /// </summary>
        [GodotMethod("is_item_radio_checkable")]
        public bool IsItemRadioCheckable(int idx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_42, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_item_shortcut_disabled");

        /// <summary>
        /// <para>Returns <c>true</c> if the specified item's shortcut is disabled.</para>
        /// </summary>
        [GodotMethod("is_item_shortcut_disabled")]
        public bool IsItemShortcutDisabled(int idx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_43, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_tooltip");

        /// <summary>
        /// <para>Returns the tooltip associated with the specified index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_item_tooltip")]
        public string GetItemTooltip(int idx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_44, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_shortcut");

        /// <summary>
        /// <para>Returns the <see cref="Godot.ShortCut"/> associated with the specified <c>idx</c> item.</para>
        /// </summary>
        [GodotMethod("get_item_shortcut")]
        public ShortCut GetItemShortcut(int idx)
        {
            return NativeCalls.godot_icall_1_806(method_bind_45, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_current_index");

        /// <summary>
        /// <para>Sets the currently focused item as the given <c>index</c>.</para>
        /// <para>Passing <c>-1</c> as the index makes so that no item is focused.</para>
        /// </summary>
        [GodotMethod("set_current_index")]
        public void SetCurrentIndex(int index)
        {
            NativeCalls.godot_icall_1_4(method_bind_46, Object.GetPtr(this), index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_index");

        /// <summary>
        /// <para>Returns the index of the currently focused item. Returns <c>-1</c> if no item is focused.</para>
        /// </summary>
        [GodotMethod("get_current_index")]
        public int GetCurrentIndex()
        {
            return NativeCalls.godot_icall_0_5(method_bind_47, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_count");

        /// <summary>
        /// <para>Returns the number of items in the <see cref="Godot.PopupMenu"/>.</para>
        /// </summary>
        [GodotMethod("get_item_count")]
        public int GetItemCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_48, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_item");

        /// <summary>
        /// <para>Removes the item at index <c>idx</c> from the menu.</para>
        /// <para>Note: The indices of items after the removed item will be shifted by one.</para>
        /// </summary>
        [GodotMethod("remove_item")]
        public void RemoveItem(int idx)
        {
            NativeCalls.godot_icall_1_4(method_bind_49, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_separator");

        /// <summary>
        /// <para>Adds a separator between items. Separators also occupy an index, which you can set by using the <c>id</c> parameter.</para>
        /// <para>A <c>label</c> can optionally be provided, which will appear at the center of the separator.</para>
        /// </summary>
        [GodotMethod("add_separator")]
        public void AddSeparator(string label = "", int id = -1)
        {
            NativeCalls.godot_icall_2_110(method_bind_50, Object.GetPtr(this), label, id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Removes all items from the <see cref="Godot.PopupMenu"/>.</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_51, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_items");

        [Obsolete("_SetItems is deprecated. Use the Items property instead.")]
        internal void _SetItems(Godot.Collections.Array arg0)
        {
            NativeCalls.godot_icall_1_92(method_bind_52, Object.GetPtr(this), arg0.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_53 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_items");

        [Obsolete("_GetItems is deprecated. Use the Items property instead.")]
        internal Godot.Collections.Array _GetItems()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_53, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_54 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_hide_on_item_selection");

        [GodotMethod("set_hide_on_item_selection")]
        [Obsolete("SetHideOnItemSelection is deprecated. Use the HideOnItemSelection property instead.")]
        public void SetHideOnItemSelection(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_54, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_55 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_hide_on_item_selection");

        [GodotMethod("is_hide_on_item_selection")]
        [Obsolete("IsHideOnItemSelection is deprecated. Use the HideOnItemSelection property instead.")]
        public bool IsHideOnItemSelection()
        {
            return NativeCalls.godot_icall_0_7(method_bind_55, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_56 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_hide_on_checkable_item_selection");

        [GodotMethod("set_hide_on_checkable_item_selection")]
        [Obsolete("SetHideOnCheckableItemSelection is deprecated. Use the HideOnCheckableItemSelection property instead.")]
        public void SetHideOnCheckableItemSelection(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_56, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_57 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_hide_on_checkable_item_selection");

        [GodotMethod("is_hide_on_checkable_item_selection")]
        [Obsolete("IsHideOnCheckableItemSelection is deprecated. Use the HideOnCheckableItemSelection property instead.")]
        public bool IsHideOnCheckableItemSelection()
        {
            return NativeCalls.godot_icall_0_7(method_bind_57, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_58 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_hide_on_state_item_selection");

        [GodotMethod("set_hide_on_state_item_selection")]
        [Obsolete("SetHideOnStateItemSelection is deprecated. Use the HideOnStateItemSelection property instead.")]
        public void SetHideOnStateItemSelection(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_58, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_59 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_hide_on_state_item_selection");

        [GodotMethod("is_hide_on_state_item_selection")]
        [Obsolete("IsHideOnStateItemSelection is deprecated. Use the HideOnStateItemSelection property instead.")]
        public bool IsHideOnStateItemSelection()
        {
            return NativeCalls.godot_icall_0_7(method_bind_59, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_60 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_submenu_popup_delay");

        [GodotMethod("set_submenu_popup_delay")]
        [Obsolete("SetSubmenuPopupDelay is deprecated. Use the SubmenuPopupDelay property instead.")]
        public void SetSubmenuPopupDelay(float seconds)
        {
            NativeCalls.godot_icall_1_15(method_bind_60, Object.GetPtr(this), seconds);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_61 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_submenu_popup_delay");

        [GodotMethod("get_submenu_popup_delay")]
        [Obsolete("GetSubmenuPopupDelay is deprecated. Use the SubmenuPopupDelay property instead.")]
        public float GetSubmenuPopupDelay()
        {
            return NativeCalls.godot_icall_0_14(method_bind_61, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_62 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_hide_on_window_lose_focus");

        /// <summary>
        /// <para>Hides the <see cref="Godot.PopupMenu"/> when the window loses focus.</para>
        /// </summary>
        [GodotMethod("set_hide_on_window_lose_focus")]
        public void SetHideOnWindowLoseFocus(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_62, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_63 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_hide_on_window_lose_focus");

        /// <summary>
        /// <para>Returns <c>true</c> if the popup will be hidden when the window loses focus or not.</para>
        /// </summary>
        [GodotMethod("is_hide_on_window_lose_focus")]
        public bool IsHideOnWindowLoseFocus()
        {
            return NativeCalls.godot_icall_0_7(method_bind_63, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_64 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_allow_search");

        [GodotMethod("set_allow_search")]
        [Obsolete("SetAllowSearch is deprecated. Use the AllowSearch property instead.")]
        public void SetAllowSearch(bool allow)
        {
            NativeCalls.godot_icall_1_16(method_bind_64, Object.GetPtr(this), allow);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_65 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_allow_search");

        [GodotMethod("get_allow_search")]
        [Obsolete("GetAllowSearch is deprecated. Use the AllowSearch property instead.")]
        public bool GetAllowSearch()
        {
            return NativeCalls.godot_icall_0_7(method_bind_65, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
