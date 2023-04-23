using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Simple tabs control, similar to <see cref="Godot.TabContainer"/> but is only in charge of drawing tabs, not interacting with children.</para>
    /// </summary>
    public partial class Tabs : Control
    {
        public enum CloseButtonDisplayPolicy
        {
            /// <summary>
            /// <para>Never show the close buttons.</para>
            /// </summary>
            ShowNever = 0,
            /// <summary>
            /// <para>Only show the close button on the currently active tab.</para>
            /// </summary>
            ShowActiveOnly = 1,
            /// <summary>
            /// <para>Show the close button on all tabs.</para>
            /// </summary>
            ShowAlways = 2,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.Tabs.CloseButtonDisplayPolicy"/> enum.</para>
            /// </summary>
            Max = 3
        }

        public enum TabAlignEnum
        {
            /// <summary>
            /// <para>Align the tabs to the left.</para>
            /// </summary>
            Left = 0,
            /// <summary>
            /// <para>Align the tabs to the center.</para>
            /// </summary>
            Center = 1,
            /// <summary>
            /// <para>Align the tabs to the right.</para>
            /// </summary>
            Right = 2,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.Tabs.TabAlignEnum"/> enum.</para>
            /// </summary>
            Max = 3
        }

        /// <summary>
        /// <para>Select tab at index <c>tab_idx</c>.</para>
        /// </summary>
        public int CurrentTab
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCurrentTab();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCurrentTab(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The alignment of all tabs. See <see cref="Godot.Tabs.TabAlignEnum"/> for details.</para>
        /// </summary>
        public Tabs.TabAlignEnum TabAlign
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTabAlign();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTabAlign(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets when the close button will appear on the tabs. See <see cref="Godot.Tabs.CloseButtonDisplayPolicy"/> for details.</para>
        /// </summary>
        public Tabs.CloseButtonDisplayPolicy TabCloseDisplayPolicy
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTabCloseDisplayPolicy();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTabCloseDisplayPolicy(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>if <c>true</c>, the mouse's scroll wheel can be used to navigate the scroll view.</para>
        /// </summary>
        public bool ScrollingEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetScrollingEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetScrollingEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, tabs can be rearranged with mouse drag.</para>
        /// </summary>
        public bool DragToRearrangeEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDragToRearrangeEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDragToRearrangeEnabled(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Tabs";

        public Tabs() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Tabs_Ctor(this);
        }

        internal Tabs(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tab_count");

        /// <summary>
        /// <para>Returns the number of tabs.</para>
        /// </summary>
        [GodotMethod("get_tab_count")]
        public int GetTabCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_current_tab");

        [GodotMethod("set_current_tab")]
        [Obsolete("SetCurrentTab is deprecated. Use the CurrentTab property instead.")]
        public void SetCurrentTab(int tabIdx)
        {
            NativeCalls.godot_icall_1_4(method_bind_1, Object.GetPtr(this), tabIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_tab");

        [GodotMethod("get_current_tab")]
        [Obsolete("GetCurrentTab is deprecated. Use the CurrentTab property instead.")]
        public int GetCurrentTab()
        {
            return NativeCalls.godot_icall_0_5(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_previous_tab");

        /// <summary>
        /// <para>Returns the previously active tab index.</para>
        /// </summary>
        [GodotMethod("get_previous_tab")]
        public int GetPreviousTab()
        {
            return NativeCalls.godot_icall_0_5(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tab_title");

        /// <summary>
        /// <para>Sets a <c>title</c> for the tab at index <c>tab_idx</c>.</para>
        /// </summary>
        [GodotMethod("set_tab_title")]
        public void SetTabTitle(int tabIdx, string title)
        {
            NativeCalls.godot_icall_2_121(method_bind_4, Object.GetPtr(this), tabIdx, title);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tab_title");

        /// <summary>
        /// <para>Returns the title of the tab at index <c>tab_idx</c>.</para>
        /// </summary>
        [GodotMethod("get_tab_title")]
        public string GetTabTitle(int tabIdx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_5, Object.GetPtr(this), tabIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tab_icon");

        /// <summary>
        /// <para>Sets an <c>icon</c> for the tab at index <c>tab_idx</c>.</para>
        /// </summary>
        [GodotMethod("set_tab_icon")]
        public void SetTabIcon(int tabIdx, Texture icon)
        {
            NativeCalls.godot_icall_2_58(method_bind_6, Object.GetPtr(this), tabIdx, Object.GetPtr(icon));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tab_icon");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Texture"/> for the tab at index <c>tab_idx</c> or <c>null</c> if the tab has no <see cref="Godot.Texture"/>.</para>
        /// </summary>
        [GodotMethod("get_tab_icon")]
        public Texture GetTabIcon(int tabIdx)
        {
            return NativeCalls.godot_icall_1_59(method_bind_7, Object.GetPtr(this), tabIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tab_button_icon");

        /// <summary>
        /// <para>Sets the button icon from the tab at index <c>tab_idx</c>.</para>
        /// </summary>
        [GodotMethod("set_tab_button_icon")]
        public void SetTabButtonIcon(int tabIdx, Texture icon)
        {
            NativeCalls.godot_icall_2_58(method_bind_8, Object.GetPtr(this), tabIdx, Object.GetPtr(icon));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tab_button_icon");

        /// <summary>
        /// <para>Returns the button icon from the tab at index <c>tab_idx</c>.</para>
        /// </summary>
        [GodotMethod("get_tab_button_icon")]
        public Texture GetTabButtonIcon(int tabIdx)
        {
            return NativeCalls.godot_icall_1_59(method_bind_9, Object.GetPtr(this), tabIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tab_disabled");

        /// <summary>
        /// <para>If <c>disabled</c> is <c>true</c>, disables the tab at index <c>tab_idx</c>, making it non-interactable.</para>
        /// </summary>
        [GodotMethod("set_tab_disabled")]
        public void SetTabDisabled(int tabIdx, bool disabled)
        {
            NativeCalls.godot_icall_2_23(method_bind_10, Object.GetPtr(this), tabIdx, disabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tab_disabled");

        /// <summary>
        /// <para>Returns <c>true</c> if the tab at index <c>tab_idx</c> is disabled.</para>
        /// </summary>
        [GodotMethod("get_tab_disabled")]
        public bool GetTabDisabled(int tabIdx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_11, Object.GetPtr(this), tabIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_tab");

        /// <summary>
        /// <para>Removes the tab at index <c>tab_idx</c>.</para>
        /// </summary>
        [GodotMethod("remove_tab")]
        public void RemoveTab(int tabIdx)
        {
            NativeCalls.godot_icall_1_4(method_bind_12, Object.GetPtr(this), tabIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_tab");

        /// <summary>
        /// <para>Adds a new tab.</para>
        /// </summary>
        [GodotMethod("add_tab")]
        public void AddTab(string title = "", Texture icon = null)
        {
            NativeCalls.godot_icall_2_114(method_bind_13, Object.GetPtr(this), title, Object.GetPtr(icon));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tab_align");

        [GodotMethod("set_tab_align")]
        [Obsolete("SetTabAlign is deprecated. Use the TabAlign property instead.")]
        public void SetTabAlign(Tabs.TabAlignEnum align)
        {
            NativeCalls.godot_icall_1_4(method_bind_14, Object.GetPtr(this), (int)align);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tab_align");

        [GodotMethod("get_tab_align")]
        [Obsolete("GetTabAlign is deprecated. Use the TabAlign property instead.")]
        public Tabs.TabAlignEnum GetTabAlign()
        {
            return (Tabs.TabAlignEnum)NativeCalls.godot_icall_0_916(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tab_offset");

        /// <summary>
        /// <para>Returns the number of hidden tabs offsetted to the left.</para>
        /// </summary>
        [GodotMethod("get_tab_offset")]
        public int GetTabOffset()
        {
            return NativeCalls.godot_icall_0_5(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_offset_buttons_visible");

        /// <summary>
        /// <para>Returns <c>true</c> if the offset buttons (the ones that appear when there's not enough space for all tabs) are visible.</para>
        /// </summary>
        [GodotMethod("get_offset_buttons_visible")]
        public bool GetOffsetButtonsVisible()
        {
            return NativeCalls.godot_icall_0_7(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "ensure_tab_visible");

        /// <summary>
        /// <para>Moves the scroll view to make the tab visible.</para>
        /// </summary>
        [GodotMethod("ensure_tab_visible")]
        public void EnsureTabVisible(int idx)
        {
            NativeCalls.godot_icall_1_4(method_bind_18, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tab_rect");

        /// <summary>
        /// <para>Returns tab <see cref="Godot.Rect2"/> with local position and size.</para>
        /// </summary>
        [GodotMethod("get_tab_rect")]
        public Rect2 GetTabRect(int tabIdx)
        {
            NativeCalls.godot_icall_1_541(method_bind_19, Object.GetPtr(this), tabIdx, out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "move_tab");

        /// <summary>
        /// <para>Moves a tab from <c>from</c> to <c>to</c>.</para>
        /// </summary>
        [GodotMethod("move_tab")]
        public void MoveTab(int from, int to)
        {
            NativeCalls.godot_icall_2_65(method_bind_20, Object.GetPtr(this), from, to);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tab_close_display_policy");

        [GodotMethod("set_tab_close_display_policy")]
        [Obsolete("SetTabCloseDisplayPolicy is deprecated. Use the TabCloseDisplayPolicy property instead.")]
        public void SetTabCloseDisplayPolicy(Tabs.CloseButtonDisplayPolicy policy)
        {
            NativeCalls.godot_icall_1_4(method_bind_21, Object.GetPtr(this), (int)policy);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tab_close_display_policy");

        [GodotMethod("get_tab_close_display_policy")]
        [Obsolete("GetTabCloseDisplayPolicy is deprecated. Use the TabCloseDisplayPolicy property instead.")]
        public Tabs.CloseButtonDisplayPolicy GetTabCloseDisplayPolicy()
        {
            return (Tabs.CloseButtonDisplayPolicy)NativeCalls.godot_icall_0_917(method_bind_22, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_scrolling_enabled");

        [GodotMethod("set_scrolling_enabled")]
        [Obsolete("SetScrollingEnabled is deprecated. Use the ScrollingEnabled property instead.")]
        public void SetScrollingEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_23, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_scrolling_enabled");

        [GodotMethod("get_scrolling_enabled")]
        [Obsolete("GetScrollingEnabled is deprecated. Use the ScrollingEnabled property instead.")]
        public bool GetScrollingEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_drag_to_rearrange_enabled");

        [GodotMethod("set_drag_to_rearrange_enabled")]
        [Obsolete("SetDragToRearrangeEnabled is deprecated. Use the DragToRearrangeEnabled property instead.")]
        public void SetDragToRearrangeEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_25, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_drag_to_rearrange_enabled");

        [GodotMethod("get_drag_to_rearrange_enabled")]
        [Obsolete("GetDragToRearrangeEnabled is deprecated. Use the DragToRearrangeEnabled property instead.")]
        public bool GetDragToRearrangeEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_26, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tabs_rearrange_group");

        /// <summary>
        /// <para>Defines the rearrange group ID. Choose for each <see cref="Godot.Tabs"/> the same value to dragging tabs between <see cref="Godot.Tabs"/>. Enable drag with <see cref="Godot.Tabs.DragToRearrangeEnabled"/>.</para>
        /// </summary>
        [GodotMethod("set_tabs_rearrange_group")]
        public void SetTabsRearrangeGroup(int groupId)
        {
            NativeCalls.godot_icall_1_4(method_bind_27, Object.GetPtr(this), groupId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tabs_rearrange_group");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Tabs"/>' rearrange group ID.</para>
        /// </summary>
        [GodotMethod("get_tabs_rearrange_group")]
        public int GetTabsRearrangeGroup()
        {
            return NativeCalls.godot_icall_0_5(method_bind_28, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_select_with_rmb");

        /// <summary>
        /// <para>If <c>true</c>, enables selecting a tab with the right mouse button.</para>
        /// </summary>
        [GodotMethod("set_select_with_rmb")]
        public void SetSelectWithRmb(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_29, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_select_with_rmb");

        /// <summary>
        /// <para>Returns <c>true</c> if select with right mouse button is enabled.</para>
        /// </summary>
        [GodotMethod("get_select_with_rmb")]
        public bool GetSelectWithRmb()
        {
            return NativeCalls.godot_icall_0_7(method_bind_30, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
