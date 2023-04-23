using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A ScrollContainer node meant to contain a <see cref="Godot.Control"/> child. ScrollContainers will automatically create a scrollbar child (<see cref="Godot.HScrollBar"/>, <see cref="Godot.VScrollBar"/>, or both) when needed and will only draw the Control within the ScrollContainer area. Scrollbars will automatically be drawn at the right (for vertical) or bottom (for horizontal) and will enable dragging to move the viewable Control (and its children) within the ScrollContainer. Scrollbars will also automatically resize the grabber based on the <see cref="Godot.Control.RectMinSize"/> of the Control relative to the ScrollContainer. Works great with a <see cref="Godot.Panel"/> control. You can set <c>EXPAND</c> on the children's size flags, so they will upscale to the ScrollContainer's size if it's larger (scroll is invisible for the chosen dimension).</para>
    /// </summary>
    public partial class ScrollContainer : Container
    {
        /// <summary>
        /// <para>If <c>true</c>, the ScrollContainer will automatically scroll to focused children (including indirect children) to make sure they are fully visible.</para>
        /// </summary>
        public bool FollowFocus
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsFollowingFocus();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFollowFocus(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, enables horizontal scrolling.</para>
        /// </summary>
        public bool ScrollHorizontalEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsHScrollEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnableHScroll(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The current horizontal scroll value.</para>
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
        /// <para>If <c>true</c>, enables vertical scrolling.</para>
        /// </summary>
        public bool ScrollVerticalEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsVScrollEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnableVScroll(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The current vertical scroll value.</para>
        /// </summary>
        public int ScrollVertical
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

        public int ScrollDeadzone
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDeadzone();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDeadzone(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ScrollContainer";

        public ScrollContainer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ScrollContainer_Ctor(this);
        }

        internal ScrollContainer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_enable_h_scroll");

        [GodotMethod("set_enable_h_scroll")]
        [Obsolete("SetEnableHScroll is deprecated. Use the ScrollHorizontalEnabled property instead.")]
        public void SetEnableHScroll(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_h_scroll_enabled");

        [GodotMethod("is_h_scroll_enabled")]
        [Obsolete("IsHScrollEnabled is deprecated. Use the ScrollHorizontalEnabled property instead.")]
        public bool IsHScrollEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_enable_v_scroll");

        [GodotMethod("set_enable_v_scroll")]
        [Obsolete("SetEnableVScroll is deprecated. Use the ScrollVerticalEnabled property instead.")]
        public void SetEnableVScroll(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_v_scroll_enabled");

        [GodotMethod("is_v_scroll_enabled")]
        [Obsolete("IsVScrollEnabled is deprecated. Use the ScrollVerticalEnabled property instead.")]
        public bool IsVScrollEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_h_scroll");

        [GodotMethod("set_h_scroll")]
        [Obsolete("SetHScroll is deprecated. Use the ScrollHorizontal property instead.")]
        public void SetHScroll(int value)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_h_scroll");

        [GodotMethod("get_h_scroll")]
        [Obsolete("GetHScroll is deprecated. Use the ScrollHorizontal property instead.")]
        public int GetHScroll()
        {
            return NativeCalls.godot_icall_0_5(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_v_scroll");

        [GodotMethod("set_v_scroll")]
        [Obsolete("SetVScroll is deprecated. Use the ScrollVertical property instead.")]
        public void SetVScroll(int value)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_v_scroll");

        [GodotMethod("get_v_scroll")]
        [Obsolete("GetVScroll is deprecated. Use the ScrollVertical property instead.")]
        public int GetVScroll()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_deadzone");

        [GodotMethod("set_deadzone")]
        [Obsolete("SetDeadzone is deprecated. Use the ScrollDeadzone property instead.")]
        public void SetDeadzone(int deadzone)
        {
            NativeCalls.godot_icall_1_4(method_bind_8, Object.GetPtr(this), deadzone);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_deadzone");

        [GodotMethod("get_deadzone")]
        [Obsolete("GetDeadzone is deprecated. Use the ScrollDeadzone property instead.")]
        public int GetDeadzone()
        {
            return NativeCalls.godot_icall_0_5(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_follow_focus");

        [GodotMethod("set_follow_focus")]
        [Obsolete("SetFollowFocus is deprecated. Use the FollowFocus property instead.")]
        public void SetFollowFocus(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_following_focus");

        [GodotMethod("is_following_focus")]
        [Obsolete("IsFollowingFocus is deprecated. Use the FollowFocus property instead.")]
        public bool IsFollowingFocus()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_h_scrollbar");

        /// <summary>
        /// <para>Returns the horizontal scrollbar <see cref="Godot.HScrollBar"/> of this <see cref="Godot.ScrollContainer"/>.</para>
        /// <para>Warning: This is a required internal node, removing and freeing it may cause a crash. If you wish to disable the horizontal scrollbar, use <see cref="Godot.ScrollContainer.ScrollHorizontalEnabled"/>. If you want to only hide it instead, use its <see cref="Godot.CanvasItem.Visible"/> property.</para>
        /// </summary>
        [GodotMethod("get_h_scrollbar")]
        public HScrollBar GetHScrollbar()
        {
            return NativeCalls.godot_icall_0_850(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_v_scrollbar");

        /// <summary>
        /// <para>Returns the vertical scrollbar <see cref="Godot.VScrollBar"/> of this <see cref="Godot.ScrollContainer"/>.</para>
        /// <para>Warning: This is a required internal node, removing and freeing it may cause a crash. If you wish to disable the vertical scrollbar, use <see cref="Godot.ScrollContainer.ScrollVerticalEnabled"/>. If you want to only hide it instead, use its <see cref="Godot.CanvasItem.Visible"/> property.</para>
        /// </summary>
        [GodotMethod("get_v_scrollbar")]
        public VScrollBar GetVScrollbar()
        {
            return NativeCalls.godot_icall_0_546(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "ensure_control_visible");

        /// <summary>
        /// <para>Ensures the given <c>control</c> is visible (must be a direct or indirect child of the ScrollContainer). Used by <see cref="Godot.ScrollContainer.FollowFocus"/>.</para>
        /// <para>Note: This will not work on a node that was just added during the same frame. If you want to scroll to a newly added child, you must wait until the next frame using <c>SceneTree.idle_frame</c>:</para>
        /// <para><code>
        /// add_child(child_node)
        /// yield(get_tree(), "idle_frame")
        /// ensure_control_visible(child_node)
        /// </code></para>
        /// </summary>
        [GodotMethod("ensure_control_visible")]
        public void EnsureControlVisible(Control control)
        {
            NativeCalls.godot_icall_1_53(method_bind_14, Object.GetPtr(this), Object.GetPtr(control));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
