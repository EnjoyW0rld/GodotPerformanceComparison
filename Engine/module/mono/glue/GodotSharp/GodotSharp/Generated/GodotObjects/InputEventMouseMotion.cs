using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Contains mouse and pen motion information. Supports relative, absolute positions and speed. See <see cref="Godot.Node._Input"/>.</para>
    /// <para>Note: The behavior of this event is affected by the value of <see cref="Godot.Input.UseAccumulatedInput"/>. When set to <c>true</c> (default), mouse/pen motion events received from the OS will be merged to emit an accumulated event only once per frame rendered at most. When set to <c>false</c>, the events will be emitted as received, which means that they can be emitted multiple times per frame rendered, allowing for precise input reporting at the expense of CPU usage.</para>
    /// <para>Note: If you use InputEventMouseMotion to draw lines, consider implementing <a href="https://en.wikipedia.org/wiki/Bresenham%27s_line_algorithm">Bresenham's line algorithm</a> as well to avoid visible gaps in lines if the user is moving the mouse quickly.</para>
    /// </summary>
    public partial class InputEventMouseMotion : InputEventMouse
    {
        /// <summary>
        /// <para>Represents the angles of tilt of the pen. Positive X-coordinate value indicates a tilt to the right. Positive Y-coordinate value indicates a tilt toward the user. Ranges from <c>-1.0</c> to <c>1.0</c> for both axes.</para>
        /// </summary>
        public Vector2 Tilt
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTilt();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTilt(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Represents the pressure the user puts on the pen. Ranges from <c>0.0</c> to <c>1.0</c>.</para>
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
        /// <para>Returns <c>true</c> when using the eraser end of a stylus pen.</para>
        /// <para>Note: This property is implemented on Linux, macOS and Windows.</para>
        /// </summary>
        public bool PenInverted
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPenInverted();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPenInverted(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The mouse position relative to the previous position (position at the last frame).</para>
        /// <para>Note: Since <see cref="Godot.InputEventMouseMotion"/> is only emitted when the mouse moves, the last event won't have a relative position of <c>Vector2(0, 0)</c> when the user stops moving the mouse.</para>
        /// </summary>
        public Vector2 Relative
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRelative();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRelative(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The mouse speed in pixels per second.</para>
        /// </summary>
        public Vector2 Speed
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSpeed();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSpeed(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "InputEventMouseMotion";

        public InputEventMouseMotion() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_InputEventMouseMotion_Ctor(this);
        }

        internal InputEventMouseMotion(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tilt");

        [GodotMethod("set_tilt")]
        [Obsolete("SetTilt is deprecated. Use the Tilt property instead.")]
        public void SetTilt(Vector2 tilt)
        {
            NativeCalls.godot_icall_1_57(method_bind_0, Object.GetPtr(this), ref tilt);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tilt");

        [GodotMethod("get_tilt")]
        [Obsolete("GetTilt is deprecated. Use the Tilt property instead.")]
        public Vector2 GetTilt()
        {
            NativeCalls.godot_icall_0_18(method_bind_1, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
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
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pen_inverted");

        [GodotMethod("set_pen_inverted")]
        [Obsolete("SetPenInverted is deprecated. Use the PenInverted property instead.")]
        public void SetPenInverted(bool penInverted)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), penInverted);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pen_inverted");

        [GodotMethod("get_pen_inverted")]
        [Obsolete("GetPenInverted is deprecated. Use the PenInverted property instead.")]
        public bool GetPenInverted()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_relative");

        [GodotMethod("set_relative")]
        [Obsolete("SetRelative is deprecated. Use the Relative property instead.")]
        public void SetRelative(Vector2 relative)
        {
            NativeCalls.godot_icall_1_57(method_bind_6, Object.GetPtr(this), ref relative);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_relative");

        [GodotMethod("get_relative")]
        [Obsolete("GetRelative is deprecated. Use the Relative property instead.")]
        public Vector2 GetRelative()
        {
            NativeCalls.godot_icall_0_18(method_bind_7, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_speed");

        [GodotMethod("set_speed")]
        [Obsolete("SetSpeed is deprecated. Use the Speed property instead.")]
        public void SetSpeed(Vector2 speed)
        {
            NativeCalls.godot_icall_1_57(method_bind_8, Object.GetPtr(this), ref speed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_speed");

        [GodotMethod("get_speed")]
        [Obsolete("GetSpeed is deprecated. Use the Speed property instead.")]
        public Vector2 GetSpeed()
        {
            NativeCalls.godot_icall_0_18(method_bind_9, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
