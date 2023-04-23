using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Input event type for gamepad buttons. For gamepad analog sticks and joysticks, see <see cref="Godot.InputEventJoypadMotion"/>.</para>
    /// </summary>
    public partial class InputEventJoypadButton : InputEvent
    {
        /// <summary>
        /// <para>Button identifier. One of the <see cref="Godot.JoystickList"/> button constants.</para>
        /// </summary>
        public int ButtonIndex
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetButtonIndex();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetButtonIndex(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Represents the pressure the user puts on the button with their finger, if the controller supports it. Ranges from <c>0</c> to <c>1</c>.</para>
        /// </summary>
        public float Pressure
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPressure();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPressure(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the button's state is pressed. If <c>false</c>, the button's state is released.</para>
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

        private const string nativeName = "InputEventJoypadButton";

        public InputEventJoypadButton() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_InputEventJoypadButton_Ctor(this);
        }

        internal InputEventJoypadButton(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_button_index");

        [GodotMethod("set_button_index")]
        [Obsolete("SetButtonIndex is deprecated. Use the ButtonIndex property instead.")]
        public void SetButtonIndex(int buttonIndex)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), buttonIndex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_button_index");

        [GodotMethod("get_button_index")]
        [Obsolete("GetButtonIndex is deprecated. Use the ButtonIndex property instead.")]
        public int GetButtonIndex()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pressure");

        [GodotMethod("set_pressure")]
        [Obsolete("SetPressure is deprecated. Use the Pressure property instead.")]
        public void SetPressure(float pressure)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), pressure);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pressure");

        [GodotMethod("get_pressure")]
        [Obsolete("GetPressure is deprecated. Use the Pressure property instead.")]
        public float GetPressure()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pressed");

        [GodotMethod("set_pressed")]
        [Obsolete("SetPressed is deprecated. Use the Pressed property instead.")]
        public void SetPressed(bool pressed)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), pressed);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
