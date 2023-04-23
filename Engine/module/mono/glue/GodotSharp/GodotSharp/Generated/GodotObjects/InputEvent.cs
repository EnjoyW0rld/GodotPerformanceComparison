using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Base class of all sort of input event. See <see cref="Godot.Node._Input"/>.</para>
    /// </summary>
    public abstract partial class InputEvent : Resource
    {
        /// <summary>
        /// <para>The event's device ID.</para>
        /// <para>Note: This device ID will always be <c>-1</c> for emulated mouse input from a touchscreen. This can be used to distinguish emulated mouse input from physical mouse input.</para>
        /// </summary>
        public int Device
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDevice();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDevice(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "InputEvent";

        internal InputEvent() {}

        internal InputEvent(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_device");

        [GodotMethod("set_device")]
        [Obsolete("SetDevice is deprecated. Use the Device property instead.")]
        public void SetDevice(int device)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), device);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_device");

        [GodotMethod("get_device")]
        [Obsolete("GetDevice is deprecated. Use the Device property instead.")]
        public int GetDevice()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_action");

        /// <summary>
        /// <para>Returns <c>true</c> if this input event matches a pre-defined action of any type.</para>
        /// <para>If <c>exact_match</c> is <c>false</c>, it ignores additional input modifiers for <see cref="Godot.InputEventKey"/> and <see cref="Godot.InputEventMouseButton"/> events, and the direction for <see cref="Godot.InputEventJoypadMotion"/> events.</para>
        /// </summary>
        [GodotMethod("is_action")]
        public bool IsAction(string action, bool exactMatch = false)
        {
            return NativeCalls.godot_icall_2_521(method_bind_2, Object.GetPtr(this), action, exactMatch);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_action_pressed");

        /// <summary>
        /// <para>Returns <c>true</c> if the given action is being pressed (and is not an echo event for <see cref="Godot.InputEventKey"/> events, unless <c>allow_echo</c> is <c>true</c>). Not relevant for events of type <see cref="Godot.InputEventMouseMotion"/> or <see cref="Godot.InputEventScreenDrag"/>.</para>
        /// <para>If <c>exact_match</c> is <c>false</c>, it ignores additional input modifiers for <see cref="Godot.InputEventKey"/> and <see cref="Godot.InputEventMouseButton"/> events, and the direction for <see cref="Godot.InputEventJoypadMotion"/> events.</para>
        /// <para>Note: Due to keyboard ghosting, <see cref="Godot.InputEvent.IsActionPressed"/> may return <c>false</c> even if one of the action's keys is pressed. See <a href="$DOCS_URL/tutorials/inputs/input_examples.html#keyboard-events">Input examples</a> in the documentation for more information.</para>
        /// </summary>
        [GodotMethod("is_action_pressed")]
        public bool IsActionPressed(string action, bool allowEcho = false, bool exactMatch = false)
        {
            return NativeCalls.godot_icall_3_529(method_bind_3, Object.GetPtr(this), action, allowEcho, exactMatch);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_action_released");

        /// <summary>
        /// <para>Returns <c>true</c> if the given action is released (i.e. not pressed). Not relevant for events of type <see cref="Godot.InputEventMouseMotion"/> or <see cref="Godot.InputEventScreenDrag"/>.</para>
        /// <para>If <c>exact_match</c> is <c>false</c>, it ignores additional input modifiers for <see cref="Godot.InputEventKey"/> and <see cref="Godot.InputEventMouseButton"/> events, and the direction for <see cref="Godot.InputEventJoypadMotion"/> events.</para>
        /// </summary>
        [GodotMethod("is_action_released")]
        public bool IsActionReleased(string action, bool exactMatch = false)
        {
            return NativeCalls.godot_icall_2_521(method_bind_4, Object.GetPtr(this), action, exactMatch);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_action_strength");

        /// <summary>
        /// <para>Returns a value between 0.0 and 1.0 depending on the given actions' state. Useful for getting the value of events of type <see cref="Godot.InputEventJoypadMotion"/>.</para>
        /// <para>If <c>exact_match</c> is <c>false</c>, it ignores additional input modifiers for <see cref="Godot.InputEventKey"/> and <see cref="Godot.InputEventMouseButton"/> events, and the direction for <see cref="Godot.InputEventJoypadMotion"/> events.</para>
        /// </summary>
        [GodotMethod("get_action_strength")]
        public float GetActionStrength(string action, bool exactMatch = false)
        {
            return NativeCalls.godot_icall_2_522(method_bind_5, Object.GetPtr(this), action, exactMatch);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_pressed");

        /// <summary>
        /// <para>Returns <c>true</c> if this input event is pressed. Not relevant for events of type <see cref="Godot.InputEventMouseMotion"/> or <see cref="Godot.InputEventScreenDrag"/>.</para>
        /// <para>Note: Due to keyboard ghosting, <see cref="Godot.InputEvent.IsActionPressed"/> may return <c>false</c> even if one of the action's keys is pressed. See <a href="$DOCS_URL/tutorials/inputs/input_examples.html#keyboard-events">Input examples</a> in the documentation for more information.</para>
        /// </summary>
        [GodotMethod("is_pressed")]
        public bool IsPressed()
        {
            return NativeCalls.godot_icall_0_7(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_echo");

        /// <summary>
        /// <para>Returns <c>true</c> if this input event is an echo event (only for events of type <see cref="Godot.InputEventKey"/>).</para>
        /// </summary>
        [GodotMethod("is_echo")]
        public bool IsEcho()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "as_text");

        /// <summary>
        /// <para>Returns a <see cref="string"/> representation of the event.</para>
        /// </summary>
        [GodotMethod("as_text")]
        public string AsText()
        {
            return NativeCalls.godot_icall_0_6(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shortcut_match");

        /// <summary>
        /// <para>Returns <c>true</c> if the specified <c>event</c> matches this event. Only valid for action events i.e key (<see cref="Godot.InputEventKey"/>), button (<see cref="Godot.InputEventMouseButton"/> or <see cref="Godot.InputEventJoypadButton"/>), axis <see cref="Godot.InputEventJoypadMotion"/> or action (<see cref="Godot.InputEventAction"/>) events.</para>
        /// <para>If <c>exact_match</c> is <c>false</c>, it ignores additional input modifiers for <see cref="Godot.InputEventKey"/> and <see cref="Godot.InputEventMouseButton"/> events, and the direction for <see cref="Godot.InputEventJoypadMotion"/> events.</para>
        /// </summary>
        [GodotMethod("shortcut_match")]
        public bool ShortcutMatch(InputEvent @event, bool exactMatch = true)
        {
            return NativeCalls.godot_icall_2_530(method_bind_9, Object.GetPtr(this), Object.GetPtr(@event), exactMatch);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_action_type");

        /// <summary>
        /// <para>Returns <c>true</c> if this input event's type is one that can be assigned to an input action.</para>
        /// </summary>
        [GodotMethod("is_action_type")]
        public bool IsActionType()
        {
            return NativeCalls.godot_icall_0_7(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "accumulate");

        /// <summary>
        /// <para>Returns <c>true</c> if the given input event and this input event can be added together (only for events of type <see cref="Godot.InputEventMouseMotion"/>).</para>
        /// <para>The given input event's position, global position and speed will be copied. The resulting <c>relative</c> is a sum of both events. Both events' modifiers have to be identical.</para>
        /// </summary>
        [GodotMethod("accumulate")]
        public bool Accumulate(InputEvent withEvent)
        {
            return NativeCalls.godot_icall_1_531(method_bind_11, Object.GetPtr(this), Object.GetPtr(withEvent));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "xformed_by");

        /// <summary>
        /// <para>Returns a copy of the given input event which has been offset by <c>local_ofs</c> and transformed by <c>xform</c>. Relevant for events of type <see cref="Godot.InputEventMouseButton"/>, <see cref="Godot.InputEventMouseMotion"/>, <see cref="Godot.InputEventScreenTouch"/>, <see cref="Godot.InputEventScreenDrag"/>, <see cref="Godot.InputEventMagnifyGesture"/> and <see cref="Godot.InputEventPanGesture"/>.</para>
        /// </summary>
        /// <param name="localOfs">If the parameter is null, then the default value is new Vector2(0, 0)</param>
        [GodotMethod("xformed_by")]
        public InputEvent XformedBy(Transform2D xform, Nullable<Vector2> localOfs = null)
        {
            Vector2 localOfs_in = localOfs.HasValue ? localOfs.Value : new Vector2(0, 0);
            return NativeCalls.godot_icall_2_532(method_bind_12, Object.GetPtr(this), ref xform, ref localOfs_in);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
