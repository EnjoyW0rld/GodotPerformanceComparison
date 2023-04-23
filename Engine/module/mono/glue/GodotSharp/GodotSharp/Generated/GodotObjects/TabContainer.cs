using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Arranges <see cref="Godot.Control"/> children into a tabbed view, creating a tab for each one. The active tab's corresponding <see cref="Godot.Control"/> has its <c>visible</c> property set to <c>true</c>, and all other children's to <c>false</c>.</para>
    /// <para>Ignores non-<see cref="Godot.Control"/> children.</para>
    /// <para>Note: The drawing of the clickable tabs themselves is handled by this node. Adding <see cref="Godot.Tabs"/> as children is not needed.</para>
    /// </summary>
    public partial class TabContainer : Container
    {
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
            Right = 2
        }

        /// <summary>
        /// <para>The alignment of all tabs in the tab container. See the <see cref="Godot.TabContainer.TabAlignEnum"/> constants for details.</para>
        /// </summary>
        public TabContainer.TabAlignEnum TabAlign
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
        /// <para>The current tab index. When set, this index's <see cref="Godot.Control"/> node's <c>visible</c> property is set to <c>true</c> and all others are set to <c>false</c>.</para>
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
        /// <para>If <c>true</c>, tabs are visible. If <c>false</c>, tabs' content and titles are hidden.</para>
        /// </summary>
        public bool TabsVisible
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return AreTabsVisible();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTabsVisible(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, all tabs are drawn in front of the panel. If <c>false</c>, inactive tabs are drawn behind the panel.</para>
        /// </summary>
        public bool AllTabsInFront
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsAllTabsInFront();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAllTabsInFront(value);
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

        /// <summary>
        /// <para>If <c>true</c>, children <see cref="Godot.Control"/> nodes that are hidden have their minimum size take into account in the total, instead of only the currently visible one.</para>
        /// </summary>
        public bool UseHiddenTabsForMinSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUseHiddenTabsForMinSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseHiddenTabsForMinSize(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "TabContainer";

        public TabContainer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_TabContainer_Ctor(this);
        }

        internal TabContainer(bool memoryOwn) : base(memoryOwn) {}

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
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_tab_control");

        /// <summary>
        /// <para>Returns the child <see cref="Godot.Control"/> node located at the active tab index.</para>
        /// </summary>
        [GodotMethod("get_current_tab_control")]
        public Control GetCurrentTabControl()
        {
            return NativeCalls.godot_icall_0_314(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tab_control");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Control"/> node from the tab at index <c>tab_idx</c>.</para>
        /// </summary>
        [GodotMethod("get_tab_control")]
        public Control GetTabControl(int tabIdx)
        {
            return NativeCalls.godot_icall_1_912(method_bind_5, Object.GetPtr(this), tabIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tab_align");

        [GodotMethod("set_tab_align")]
        [Obsolete("SetTabAlign is deprecated. Use the TabAlign property instead.")]
        public void SetTabAlign(TabContainer.TabAlignEnum align)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), (int)align);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tab_align");

        [GodotMethod("get_tab_align")]
        [Obsolete("GetTabAlign is deprecated. Use the TabAlign property instead.")]
        public TabContainer.TabAlignEnum GetTabAlign()
        {
            return (TabContainer.TabAlignEnum)NativeCalls.godot_icall_0_913(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tabs_visible");

        [GodotMethod("set_tabs_visible")]
        [Obsolete("SetTabsVisible is deprecated. Use the TabsVisible property instead.")]
        public void SetTabsVisible(bool visible)
        {
            NativeCalls.godot_icall_1_16(method_bind_8, Object.GetPtr(this), visible);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "are_tabs_visible");

        [GodotMethod("are_tabs_visible")]
        [Obsolete("AreTabsVisible is deprecated. Use the TabsVisible property instead.")]
        public bool AreTabsVisible()
        {
            return NativeCalls.godot_icall_0_7(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_all_tabs_in_front");

        [GodotMethod("set_all_tabs_in_front")]
        [Obsolete("SetAllTabsInFront is deprecated. Use the AllTabsInFront property instead.")]
        public void SetAllTabsInFront(bool isFront)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), isFront);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_all_tabs_in_front");

        [GodotMethod("is_all_tabs_in_front")]
        [Obsolete("IsAllTabsInFront is deprecated. Use the AllTabsInFront property instead.")]
        public bool IsAllTabsInFront()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tab_title");

        /// <summary>
        /// <para>Sets a title for the tab at index <c>tab_idx</c>. Tab titles default to the name of the indexed child node.</para>
        /// </summary>
        [GodotMethod("set_tab_title")]
        public void SetTabTitle(int tabIdx, string title)
        {
            NativeCalls.godot_icall_2_121(method_bind_12, Object.GetPtr(this), tabIdx, title);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tab_title");

        /// <summary>
        /// <para>Returns the title of the tab at index <c>tab_idx</c>. Tab titles default to the name of the indexed child node, but this can be overridden with <see cref="Godot.TabContainer.SetTabTitle"/>.</para>
        /// </summary>
        [GodotMethod("get_tab_title")]
        public string GetTabTitle(int tabIdx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_13, Object.GetPtr(this), tabIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tab_icon");

        /// <summary>
        /// <para>Sets an icon for the tab at index <c>tab_idx</c>.</para>
        /// </summary>
        [GodotMethod("set_tab_icon")]
        public void SetTabIcon(int tabIdx, Texture icon)
        {
            NativeCalls.godot_icall_2_58(method_bind_14, Object.GetPtr(this), tabIdx, Object.GetPtr(icon));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tab_icon");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Texture"/> for the tab at index <c>tab_idx</c> or <c>null</c> if the tab has no <see cref="Godot.Texture"/>.</para>
        /// </summary>
        [GodotMethod("get_tab_icon")]
        public Texture GetTabIcon(int tabIdx)
        {
            return NativeCalls.godot_icall_1_59(method_bind_15, Object.GetPtr(this), tabIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tab_disabled");

        /// <summary>
        /// <para>If <c>disabled</c> is <c>true</c>, disables the tab at index <c>tab_idx</c>, making it non-interactable.</para>
        /// </summary>
        [GodotMethod("set_tab_disabled")]
        public void SetTabDisabled(int tabIdx, bool disabled)
        {
            NativeCalls.godot_icall_2_23(method_bind_16, Object.GetPtr(this), tabIdx, disabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tab_disabled");

        /// <summary>
        /// <para>Returns <c>true</c> if the tab at index <c>tab_idx</c> is disabled.</para>
        /// </summary>
        [GodotMethod("get_tab_disabled")]
        public bool GetTabDisabled(int tabIdx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_17, Object.GetPtr(this), tabIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tab_hidden");

        /// <summary>
        /// <para>If <c>hidden</c> is <c>true</c>, hides the tab at index <c>tab_idx</c>, making it disappear from the tab area.</para>
        /// </summary>
        [GodotMethod("set_tab_hidden")]
        public void SetTabHidden(int tabIdx, bool hidden)
        {
            NativeCalls.godot_icall_2_23(method_bind_18, Object.GetPtr(this), tabIdx, hidden);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tab_hidden");

        /// <summary>
        /// <para>Returns <c>true</c> if the tab at index <c>tab_idx</c> is hidden.</para>
        /// </summary>
        [GodotMethod("get_tab_hidden")]
        public bool GetTabHidden(int tabIdx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_19, Object.GetPtr(this), tabIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tab_idx_at_point");

        /// <summary>
        /// <para>Returns the index of the tab at local coordinates <c>point</c>. Returns <c>-1</c> if the point is outside the control boundaries or if there's no tab at the queried position.</para>
        /// </summary>
        [GodotMethod("get_tab_idx_at_point")]
        public int GetTabIdxAtPoint(Vector2 point)
        {
            return NativeCalls.godot_icall_1_914(method_bind_20, Object.GetPtr(this), ref point);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_popup");

        /// <summary>
        /// <para>If set on a <see cref="Godot.Popup"/> node instance, a popup menu icon appears in the top-right corner of the <see cref="Godot.TabContainer"/>. Clicking it will expand the <see cref="Godot.Popup"/> node.</para>
        /// </summary>
        [GodotMethod("set_popup")]
        public void SetPopup(Node popup)
        {
            NativeCalls.godot_icall_1_53(method_bind_21, Object.GetPtr(this), Object.GetPtr(popup));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_popup");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Popup"/> node instance if one has been set already with <see cref="Godot.TabContainer.SetPopup"/>.</para>
        /// <para>Warning: This is a required internal node, removing and freeing it may cause a crash. If you wish to hide it or any of its children, use their <see cref="Godot.CanvasItem.Visible"/> property.</para>
        /// </summary>
        [GodotMethod("get_popup")]
        public Popup GetPopup()
        {
            return NativeCalls.godot_icall_0_915(method_bind_22, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_drag_to_rearrange_enabled");

        [GodotMethod("set_drag_to_rearrange_enabled")]
        [Obsolete("SetDragToRearrangeEnabled is deprecated. Use the DragToRearrangeEnabled property instead.")]
        public void SetDragToRearrangeEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_23, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_drag_to_rearrange_enabled");

        [GodotMethod("get_drag_to_rearrange_enabled")]
        [Obsolete("GetDragToRearrangeEnabled is deprecated. Use the DragToRearrangeEnabled property instead.")]
        public bool GetDragToRearrangeEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tabs_rearrange_group");

        /// <summary>
        /// <para>Defines rearrange group id, choose for each <see cref="Godot.TabContainer"/> the same value to enable tab drag between <see cref="Godot.TabContainer"/>. Enable drag with <see cref="Godot.TabContainer.DragToRearrangeEnabled"/>.</para>
        /// </summary>
        [GodotMethod("set_tabs_rearrange_group")]
        public void SetTabsRearrangeGroup(int groupId)
        {
            NativeCalls.godot_icall_1_4(method_bind_25, Object.GetPtr(this), groupId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tabs_rearrange_group");

        /// <summary>
        /// <para>Returns the <see cref="Godot.TabContainer"/> rearrange group id.</para>
        /// </summary>
        [GodotMethod("get_tabs_rearrange_group")]
        public int GetTabsRearrangeGroup()
        {
            return NativeCalls.godot_icall_0_5(method_bind_26, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_hidden_tabs_for_min_size");

        [GodotMethod("set_use_hidden_tabs_for_min_size")]
        [Obsolete("SetUseHiddenTabsForMinSize is deprecated. Use the UseHiddenTabsForMinSize property instead.")]
        public void SetUseHiddenTabsForMinSize(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_27, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_use_hidden_tabs_for_min_size");

        [GodotMethod("get_use_hidden_tabs_for_min_size")]
        [Obsolete("GetUseHiddenTabsForMinSize is deprecated. Use the UseHiddenTabsForMinSize property instead.")]
        public bool GetUseHiddenTabsForMinSize()
        {
            return NativeCalls.godot_icall_0_7(method_bind_28, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
