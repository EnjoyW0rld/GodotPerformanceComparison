using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>BaseButton is the abstract base class for buttons, so it shouldn't be used directly (it doesn't display anything). Other types of buttons inherit from it.</para>
    /// </summary>
    public abstract partial class BaseButton : Control
    {
        public enum ActionModeEnum
        {
            /// <summary>
            /// <para>Require just a press to consider the button clicked.</para>
            /// </summary>
            Press = 0,
            /// <summary>
            /// <para>Require a press and a subsequent release before considering the button clicked.</para>
            /// </summary>
            Release = 1
        }

        public enum DrawMode
        {
            /// <summary>
            /// <para>The normal state (i.e. not pressed, not hovered, not toggled and enabled) of buttons.</para>
            /// </summary>
            Normal = 0,
            /// <summary>
            /// <para>The state of buttons are pressed.</para>
            /// </summary>
            Pressed = 1,
            /// <summary>
            /// <para>The state of buttons are hovered.</para>
            /// </summary>
            Hover = 2,
            /// <summary>
            /// <para>The state of buttons are disabled.</para>
            /// </summary>
            Disabled = 3,
            /// <summary>
            /// <para>The state of buttons are both hovered and pressed.</para>
            /// </summary>
            HoverPressed = 4
        }

        /// <summary>
        /// <para>If <c>true</c>, the button is in disabled state and can't be clicked or toggled.</para>
        /// </summary>
        public bool Disabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDisabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDisabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the button is in toggle mode. Makes the button flip state between pressed and unpressed each time its area is clicked.</para>
        /// </summary>
        public bool ToggleMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsToggleMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetToggleMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the button will add information about its shortcut in the tooltip.</para>
        /// </summary>
        public bool ShortcutInTooltip
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsShortcutInTooltipEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShortcutInTooltip(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the button's state is pressed. Means the button is pressed down or toggled (if <see cref="Godot.BaseButton.ToggleMode"/> is active). Only works if <see cref="Godot.BaseButton.ToggleMode"/> is <c>true</c>.</para>
        /// <para>Note: Setting <see cref="Godot.BaseButton.Pressed"/> will result in <c>toggled</c> to be emitted. If you want to change the pressed state without emitting that signal, use <see cref="Godot.BaseButton.SetPressedNoSignal"/>.</para>
        /// </summary>
        public bool Pressed
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsPressed();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPressed(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Determines when the button is considered clicked, one of the <see cref="Godot.BaseButton.ActionModeEnum"/> constants.</para>
        /// </summary>
        public BaseButton.ActionModeEnum ActionMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetActionMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetActionMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Binary mask to choose which mouse buttons this button will respond to.</para>
        /// <para>To allow both left-click and right-click, use <c>BUTTON_MASK_LEFT | BUTTON_MASK_RIGHT</c>.</para>
        /// </summary>
        public int ButtonMask
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetButtonMask();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetButtonMask(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Deprecated. This property has been deprecated due to redundancy and will be removed in Godot 4.0. This property no longer has any effect when set. Please use <see cref="Godot.Control.FocusMode"/> instead.</para>
        /// </summary>
        public Control.FocusModeEnum EnabledFocusMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEnabledFocusMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnabledFocusMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the button stays pressed when moving the cursor outside the button while pressing it.</para>
        /// <para>Note: This property only affects the button's visual appearance. Signals will be emitted at the same moment regardless of this property's value.</para>
        /// </summary>
        public bool KeepPressedOutside
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsKeepPressedOutside();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetKeepPressedOutside(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para><see cref="Godot.ShortCut"/> associated to the button.</para>
        /// </summary>
        public ShortCut Shortcut
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShortcut();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShortcut(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para><see cref="Godot.ButtonGroup"/> associated to the button.</para>
        /// </summary>
        public ButtonGroup Group
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetButtonGroup();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetButtonGroup(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "BaseButton";

        internal BaseButton() {}

        internal BaseButton(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>Called when the button is pressed. If you need to know the button's pressed state (and <see cref="Godot.BaseButton.ToggleMode"/> is active), use <see cref="Godot.BaseButton._Toggled"/> instead.</para>
        /// </summary>
        [GodotMethod("_pressed")]
        public virtual void _Pressed()
        {
            return;
        }

        /// <summary>
        /// <para>Called when the button is toggled (only if <see cref="Godot.BaseButton.ToggleMode"/> is active).</para>
        /// </summary>
        [GodotMethod("_toggled")]
        public virtual void _Toggled(bool buttonPressed)
        {
            return;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pressed");

        [GodotMethod("set_pressed")]
        [Obsolete("SetPressed is deprecated. Use the Pressed property instead.")]
        public void SetPressed(bool pressed)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), pressed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_pressed");

        [GodotMethod("is_pressed")]
        [Obsolete("IsPressed is deprecated. Use the Pressed property instead.")]
        public bool IsPressed()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pressed_no_signal");

        /// <summary>
        /// <para>Changes the <see cref="Godot.BaseButton.Pressed"/> state of the button, without emitting <c>toggled</c>. Use when you just want to change the state of the button without sending the pressed event (e.g. when initializing scene). Only works if <see cref="Godot.BaseButton.ToggleMode"/> is <c>true</c>.</para>
        /// <para>Note: This method doesn't unpress other buttons in its button <see cref="Godot.BaseButton.Group"/>.</para>
        /// </summary>
        [GodotMethod("set_pressed_no_signal")]
        public void SetPressedNoSignal(bool pressed)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), pressed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_hovered");

        /// <summary>
        /// <para>Returns <c>true</c> if the mouse has entered the button and has not left it yet.</para>
        /// </summary>
        [GodotMethod("is_hovered")]
        public bool IsHovered()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_toggle_mode");

        [GodotMethod("set_toggle_mode")]
        [Obsolete("SetToggleMode is deprecated. Use the ToggleMode property instead.")]
        public void SetToggleMode(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_toggle_mode");

        [GodotMethod("is_toggle_mode")]
        [Obsolete("IsToggleMode is deprecated. Use the ToggleMode property instead.")]
        public bool IsToggleMode()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shortcut_in_tooltip");

        [GodotMethod("set_shortcut_in_tooltip")]
        [Obsolete("SetShortcutInTooltip is deprecated. Use the ShortcutInTooltip property instead.")]
        public void SetShortcutInTooltip(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_shortcut_in_tooltip_enabled");

        [GodotMethod("is_shortcut_in_tooltip_enabled")]
        [Obsolete("IsShortcutInTooltipEnabled is deprecated. Use the ShortcutInTooltip property instead.")]
        public bool IsShortcutInTooltipEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_disabled");

        [GodotMethod("set_disabled")]
        [Obsolete("SetDisabled is deprecated. Use the Disabled property instead.")]
        public void SetDisabled(bool disabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_8, Object.GetPtr(this), disabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_disabled");

        [GodotMethod("is_disabled")]
        [Obsolete("IsDisabled is deprecated. Use the Disabled property instead.")]
        public bool IsDisabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_action_mode");

        [GodotMethod("set_action_mode")]
        [Obsolete("SetActionMode is deprecated. Use the ActionMode property instead.")]
        public void SetActionMode(BaseButton.ActionModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_10, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_action_mode");

        [GodotMethod("get_action_mode")]
        [Obsolete("GetActionMode is deprecated. Use the ActionMode property instead.")]
        public BaseButton.ActionModeEnum GetActionMode()
        {
            return (BaseButton.ActionModeEnum)NativeCalls.godot_icall_0_205(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_button_mask");

        [GodotMethod("set_button_mask")]
        [Obsolete("SetButtonMask is deprecated. Use the ButtonMask property instead.")]
        public void SetButtonMask(int mask)
        {
            NativeCalls.godot_icall_1_4(method_bind_12, Object.GetPtr(this), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_button_mask");

        [GodotMethod("get_button_mask")]
        [Obsolete("GetButtonMask is deprecated. Use the ButtonMask property instead.")]
        public int GetButtonMask()
        {
            return NativeCalls.godot_icall_0_5(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_draw_mode");

        /// <summary>
        /// <para>Returns the visual state used to draw the button. This is useful mainly when implementing your own draw code by either overriding _draw() or connecting to "draw" signal. The visual state of the button is defined by the <see cref="Godot.BaseButton.DrawMode"/> enum.</para>
        /// </summary>
        [GodotMethod("get_draw_mode")]
        public BaseButton.DrawMode GetDrawMode()
        {
            return (BaseButton.DrawMode)NativeCalls.godot_icall_0_206(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_enabled_focus_mode");

        [GodotMethod("set_enabled_focus_mode")]
        [Obsolete("SetEnabledFocusMode is deprecated. Use the EnabledFocusMode property instead.")]
        public void SetEnabledFocusMode(Control.FocusModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_15, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_enabled_focus_mode");

        [GodotMethod("get_enabled_focus_mode")]
        [Obsolete("GetEnabledFocusMode is deprecated. Use the EnabledFocusMode property instead.")]
        public Control.FocusModeEnum GetEnabledFocusMode()
        {
            return (Control.FocusModeEnum)NativeCalls.godot_icall_0_207(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_keep_pressed_outside");

        [GodotMethod("set_keep_pressed_outside")]
        [Obsolete("SetKeepPressedOutside is deprecated. Use the KeepPressedOutside property instead.")]
        public void SetKeepPressedOutside(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_17, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_keep_pressed_outside");

        [GodotMethod("is_keep_pressed_outside")]
        [Obsolete("IsKeepPressedOutside is deprecated. Use the KeepPressedOutside property instead.")]
        public bool IsKeepPressedOutside()
        {
            return NativeCalls.godot_icall_0_7(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shortcut");

        [GodotMethod("set_shortcut")]
        [Obsolete("SetShortcut is deprecated. Use the Shortcut property instead.")]
        public void SetShortcut(ShortCut shortcut)
        {
            NativeCalls.godot_icall_1_24(method_bind_19, Object.GetPtr(this), Object.GetPtr(shortcut));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shortcut");

        [GodotMethod("get_shortcut")]
        [Obsolete("GetShortcut is deprecated. Use the Shortcut property instead.")]
        public ShortCut GetShortcut()
        {
            return NativeCalls.godot_icall_0_208(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_button_group");

        [GodotMethod("set_button_group")]
        [Obsolete("SetButtonGroup is deprecated. Use the Group property instead.")]
        public void SetButtonGroup(ButtonGroup buttonGroup)
        {
            NativeCalls.godot_icall_1_24(method_bind_21, Object.GetPtr(this), Object.GetPtr(buttonGroup));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_button_group");

        [GodotMethod("get_button_group")]
        [Obsolete("GetButtonGroup is deprecated. Use the Group property instead.")]
        public ButtonGroup GetButtonGroup()
        {
            return NativeCalls.godot_icall_0_209(method_bind_22, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
