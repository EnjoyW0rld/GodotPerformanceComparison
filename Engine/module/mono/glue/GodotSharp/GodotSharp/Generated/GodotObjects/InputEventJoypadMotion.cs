using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Stores information about joystick motions. One <see cref="Godot.InputEventJoypadMotion"/> represents one axis at a time.</para>
    /// </summary>
    public partial class InputEventJoypadMotion : InputEvent
    {
        /// <summary>
        /// <para>Axis identifier. Use one of the <see cref="Godot.JoystickList"/> axis constants.</para>
        /// </summary>
        public int Axis
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAxis();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAxis(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Current position of the joystick on the given axis. The value ranges from <c>-1.0</c> to <c>1.0</c>. A value of <c>0</c> means the axis is in its resting position.</para>
        /// </summary>
        public float AxisValue
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAxisValue();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAxisValue(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "InputEventJoypadMotion";

        public InputEventJoypadMotion() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_InputEventJoypadMotion_Ctor(this);
        }

        internal InputEventJoypadMotion(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_axis");

        [GodotMethod("set_axis")]
        [Obsolete("SetAxis is deprecated. Use the Axis property instead.")]
        public void SetAxis(int axis)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), axis);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_axis");

        [GodotMethod("get_axis")]
        [Obsolete("GetAxis is deprecated. Use the Axis property instead.")]
        public int GetAxis()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_axis_value");

        [GodotMethod("set_axis_value")]
        [Obsolete("SetAxisValue is deprecated. Use the AxisValue property instead.")]
        public void SetAxisValue(float axisValue)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), axisValue);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_axis_value");

        [GodotMethod("get_axis_value")]
        [Obsolete("GetAxisValue is deprecated. Use the AxisValue property instead.")]
        public float GetAxisValue()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
