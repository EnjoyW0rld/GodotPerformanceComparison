using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A singleton that deals with inputs. This includes key presses, mouse buttons and movement, joypads, and input actions. Actions and their events can be set in the Input Map tab in the Project &gt; Project Settings, or with the <see cref="Godot.InputMap"/> class.</para>
    /// </summary>
    public static partial class Input
    {
        public enum MouseModeEnum
        {
            /// <summary>
            /// <para>Makes the mouse cursor visible if it is hidden.</para>
            /// </summary>
            Visible = 0,
            /// <summary>
            /// <para>Makes the mouse cursor hidden if it is visible.</para>
            /// </summary>
            Hidden = 1,
            /// <summary>
            /// <para>Captures the mouse. The mouse will be hidden and its position locked at the center of the screen.</para>
            /// <para>Note: If you want to process the mouse's movement in this mode, you need to use <see cref="Godot.InputEventMouseMotion.Relative"/>.</para>
            /// </summary>
            Captured = 2,
            /// <summary>
            /// <para>Makes the mouse cursor visible but confines it to the game window.</para>
            /// </summary>
            Confined = 3
        }

        public enum CursorShape
        {
            /// <summary>
            /// <para>Arrow cursor. Standard, default pointing cursor.</para>
            /// </summary>
            Arrow = 0,
            /// <summary>
            /// <para>I-beam cursor. Usually used to show where the text cursor will appear when the mouse is clicked.</para>
            /// </summary>
            Ibeam = 1,
            /// <summary>
            /// <para>Pointing hand cursor. Usually used to indicate the pointer is over a link or other interactable item.</para>
            /// </summary>
            PointingHand = 2,
            /// <summary>
            /// <para>Cross cursor. Typically appears over regions in which a drawing operation can be performed or for selections.</para>
            /// </summary>
            Cross = 3,
            /// <summary>
            /// <para>Wait cursor. Indicates that the application is busy performing an operation. This cursor shape denotes that the application isn't usable during the operation (e.g. something is blocking its main thread).</para>
            /// </summary>
            Wait = 4,
            /// <summary>
            /// <para>Busy cursor. Indicates that the application is busy performing an operation. This cursor shape denotes that the application is still usable during the operation.</para>
            /// </summary>
            Busy = 5,
            /// <summary>
            /// <para>Drag cursor. Usually displayed when dragging something.</para>
            /// </summary>
            Drag = 6,
            /// <summary>
            /// <para>Can drop cursor. Usually displayed when dragging something to indicate that it can be dropped at the current position.</para>
            /// </summary>
            CanDrop = 7,
            /// <summary>
            /// <para>Forbidden cursor. Indicates that the current action is forbidden (for example, when dragging something) or that the control at a position is disabled.</para>
            /// </summary>
            Forbidden = 8,
            /// <summary>
            /// <para>Vertical resize mouse cursor. A double-headed vertical arrow. It tells the user they can resize the window or the panel vertically.</para>
            /// </summary>
            Vsize = 9,
            /// <summary>
            /// <para>Horizontal resize mouse cursor. A double-headed horizontal arrow. It tells the user they can resize the window or the panel horizontally.</para>
            /// </summary>
            Hsize = 10,
            /// <summary>
            /// <para>Window resize mouse cursor. The cursor is a double-headed arrow that goes from the bottom left to the top right. It tells the user they can resize the window or the panel both horizontally and vertically.</para>
            /// </summary>
            Bdiagsize = 11,
            /// <summary>
            /// <para>Window resize mouse cursor. The cursor is a double-headed arrow that goes from the top left to the bottom right, the opposite of <see cref="Godot.Input.CursorShape.Bdiagsize"/>. It tells the user they can resize the window or the panel both horizontally and vertically.</para>
            /// </summary>
            Fdiagsize = 12,
            /// <summary>
            /// <para>Move cursor. Indicates that something can be moved.</para>
            /// </summary>
            Move = 13,
            /// <summary>
            /// <para>Vertical split mouse cursor. On Windows, it's the same as <see cref="Godot.Input.CursorShape.Vsize"/>.</para>
            /// </summary>
            Vsplit = 14,
            /// <summary>
            /// <para>Horizontal split mouse cursor. On Windows, it's the same as <see cref="Godot.Input.CursorShape.Hsize"/>.</para>
            /// </summary>
            Hsplit = 15,
            /// <summary>
            /// <para>Help cursor. Usually a question mark.</para>
            /// </summary>
            Help = 16
        }

        /// <summary>
        /// <para>Controls the mouse mode. See <see cref="Godot.Input.MouseModeEnum"/> for more information.</para>
        /// </summary>
        public static Input.MouseModeEnum MouseMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMouseMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMouseMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, similar input events sent by the operating system are accumulated. When input accumulation is enabled, all input events generated during a frame will be merged and emitted when the frame is done rendering. Therefore, this limits the number of input method calls per second to the rendering FPS.</para>
        /// <para>Input accumulation can be disabled to get slightly more precise/reactive input at the cost of increased CPU usage. In applications where drawing freehand lines is required, input accumulation should generally be disabled while the user is drawing the line to get results that closely follow the actual input.</para>
        /// <para>Note: Input accumulation is enabled by default. It is recommended to keep it enabled for games which don't require very reactive input, as this will decrease CPU usage.</para>
        /// </summary>
        public static bool UseAccumulatedInput
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUsingAccumulatedInput();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseAccumulatedInput(value);
            }
#pragma warning restore CS0618
        }

        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(Input).Name);
                return singleton;
            }
        }

        private const string nativeName = "Input";
        internal static IntPtr ptr = NativeCalls.godot_icall_Input_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_key_pressed");

        /// <summary>
        /// <para>Returns <c>true</c> if you are pressing the key in the current keyboard layout. You can pass a <see cref="Godot.KeyList"/> constant.</para>
        /// <para><see cref="Godot.Input.IsKeyPressed"/> is only recommended over <see cref="Godot.Input.IsPhysicalKeyPressed"/> in non-game applications. This ensures that shortcut keys behave as expected depending on the user's keyboard layout, as keyboard shortcuts are generally dependent on the keyboard layout in non-game applications. If in doubt, use <see cref="Godot.Input.IsPhysicalKeyPressed"/>.</para>
        /// <para>Note: Due to keyboard ghosting, <see cref="Godot.Input.IsKeyPressed"/> may return <c>false</c> even if one of the action's keys is pressed. See <a href="$DOCS_URL/tutorials/inputs/input_examples.html#keyboard-events">Input examples</a> in the documentation for more information.</para>
        /// </summary>
        [GodotMethod("is_key_pressed")]
        public static bool IsKeyPressed(int scancode)
        {
            return NativeCalls.godot_icall_1_35(method_bind_0, ptr, scancode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_physical_key_pressed");

        /// <summary>
        /// <para>Returns <c>true</c> if you are pressing the key in the physical location on the 101/102-key US QWERTY keyboard. You can pass a <see cref="Godot.KeyList"/> constant.</para>
        /// <para><see cref="Godot.Input.IsPhysicalKeyPressed"/> is recommended over <see cref="Godot.Input.IsKeyPressed"/> for in-game actions, as it will make W/A/S/D layouts work regardless of the user's keyboard layout. <see cref="Godot.Input.IsPhysicalKeyPressed"/> will also ensure that the top row number keys work on any keyboard layout. If in doubt, use <see cref="Godot.Input.IsPhysicalKeyPressed"/>.</para>
        /// <para>Note: Due to keyboard ghosting, <see cref="Godot.Input.IsPhysicalKeyPressed"/> may return <c>false</c> even if one of the action's keys is pressed. See <a href="$DOCS_URL/tutorials/inputs/input_examples.html#keyboard-events">Input examples</a> in the documentation for more information.</para>
        /// </summary>
        [GodotMethod("is_physical_key_pressed")]
        public static bool IsPhysicalKeyPressed(int scancode)
        {
            return NativeCalls.godot_icall_1_35(method_bind_1, ptr, scancode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_mouse_button_pressed");

        /// <summary>
        /// <para>Returns <c>true</c> if you are pressing the mouse button specified with <see cref="Godot.ButtonList"/>.</para>
        /// </summary>
        [GodotMethod("is_mouse_button_pressed")]
        public static bool IsMouseButtonPressed(int button)
        {
            return NativeCalls.godot_icall_1_35(method_bind_2, ptr, button);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_joy_button_pressed");

        /// <summary>
        /// <para>Returns <c>true</c> if you are pressing the joypad button (see <see cref="Godot.JoystickList"/>).</para>
        /// </summary>
        [GodotMethod("is_joy_button_pressed")]
        public static bool IsJoyButtonPressed(int device, int button)
        {
            return NativeCalls.godot_icall_2_177(method_bind_3, ptr, device, button);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_action_pressed");

        /// <summary>
        /// <para>Returns <c>true</c> if you are pressing the action event. Note that if an action has multiple buttons assigned and more than one of them is pressed, releasing one button will release the action, even if some other button assigned to this action is still pressed.</para>
        /// <para>If <c>exact</c> is <c>false</c>, it ignores additional input modifiers for <see cref="Godot.InputEventKey"/> and <see cref="Godot.InputEventMouseButton"/> events, and the direction for <see cref="Godot.InputEventJoypadMotion"/> events.</para>
        /// <para>Note: Due to keyboard ghosting, <see cref="Godot.Input.IsActionPressed"/> may return <c>false</c> even if one of the action's keys is pressed. See <a href="$DOCS_URL/tutorials/inputs/input_examples.html#keyboard-events">Input examples</a> in the documentation for more information.</para>
        /// </summary>
        [GodotMethod("is_action_pressed")]
        public static bool IsActionPressed(string action, bool exact = false)
        {
            return NativeCalls.godot_icall_2_521(method_bind_4, ptr, action, exact);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_action_just_pressed");

        /// <summary>
        /// <para>Returns <c>true</c> when the user starts pressing the action event, meaning it's <c>true</c> only on the frame that the user pressed down the button.</para>
        /// <para>This is useful for code that needs to run only once when an action is pressed, instead of every frame while it's pressed.</para>
        /// <para>If <c>exact</c> is <c>false</c>, it ignores additional input modifiers for <see cref="Godot.InputEventKey"/> and <see cref="Godot.InputEventMouseButton"/> events, and the direction for <see cref="Godot.InputEventJoypadMotion"/> events.</para>
        /// <para>Note: Due to keyboard ghosting, <see cref="Godot.Input.IsActionJustPressed"/> may return <c>false</c> even if one of the action's keys is pressed. See <a href="$DOCS_URL/tutorials/inputs/input_examples.html#keyboard-events">Input examples</a> in the documentation for more information.</para>
        /// </summary>
        [GodotMethod("is_action_just_pressed")]
        public static bool IsActionJustPressed(string action, bool exact = false)
        {
            return NativeCalls.godot_icall_2_521(method_bind_5, ptr, action, exact);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_action_just_released");

        /// <summary>
        /// <para>Returns <c>true</c> when the user stops pressing the action event, meaning it's <c>true</c> only on the frame that the user released the button.</para>
        /// <para>If <c>exact</c> is <c>false</c>, it ignores additional input modifiers for <see cref="Godot.InputEventKey"/> and <see cref="Godot.InputEventMouseButton"/> events, and the direction for <see cref="Godot.InputEventJoypadMotion"/> events.</para>
        /// </summary>
        [GodotMethod("is_action_just_released")]
        public static bool IsActionJustReleased(string action, bool exact = false)
        {
            return NativeCalls.godot_icall_2_521(method_bind_6, ptr, action, exact);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_action_strength");

        /// <summary>
        /// <para>Returns a value between 0 and 1 representing the intensity of the given action. In a joypad, for example, the further away the axis (analog sticks or L2, R2 triggers) is from the dead zone, the closer the value will be to 1. If the action is mapped to a control that has no axis as the keyboard, the value returned will be 0 or 1.</para>
        /// <para>If <c>exact</c> is <c>false</c>, it ignores additional input modifiers for <see cref="Godot.InputEventKey"/> and <see cref="Godot.InputEventMouseButton"/> events, and the direction for <see cref="Godot.InputEventJoypadMotion"/> events.</para>
        /// </summary>
        [GodotMethod("get_action_strength")]
        public static float GetActionStrength(string action, bool exact = false)
        {
            return NativeCalls.godot_icall_2_522(method_bind_7, ptr, action, exact);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_action_raw_strength");

        /// <summary>
        /// <para>Returns a value between 0 and 1 representing the raw intensity of the given action, ignoring the action's deadzone. In most cases, you should use <see cref="Godot.Input.GetActionStrength"/> instead.</para>
        /// <para>If <c>exact</c> is <c>false</c>, it ignores additional input modifiers for <see cref="Godot.InputEventKey"/> and <see cref="Godot.InputEventMouseButton"/> events, and the direction for <see cref="Godot.InputEventJoypadMotion"/> events.</para>
        /// </summary>
        [GodotMethod("get_action_raw_strength")]
        public static float GetActionRawStrength(string action, bool exact = false)
        {
            return NativeCalls.godot_icall_2_522(method_bind_8, ptr, action, exact);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_axis");

        /// <summary>
        /// <para>Get axis input by specifying two actions, one negative and one positive.</para>
        /// <para>This is a shorthand for writing <c>Input.get_action_strength("positive_action") - Input.get_action_strength("negative_action")</c>.</para>
        /// </summary>
        [GodotMethod("get_axis")]
        public static float GetAxis(string negativeAction, string positiveAction)
        {
            return NativeCalls.godot_icall_2_126(method_bind_9, ptr, negativeAction, positiveAction);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_vector");

        /// <summary>
        /// <para>Gets an input vector by specifying four actions for the positive and negative X and Y axes.</para>
        /// <para>This method is useful when getting vector input, such as from a joystick, directional pad, arrows, or WASD. The vector has its length limited to 1 and has a circular deadzone, which is useful for using vector input as movement.</para>
        /// <para>By default, the deadzone is automatically calculated from the average of the action deadzones. However, you can override the deadzone to be whatever you want (on the range of 0 to 1).</para>
        /// </summary>
        [GodotMethod("get_vector")]
        public static Vector2 GetVector(string negativeX, string positiveX, string negativeY, string positiveY, float deadzone = -1f)
        {
            NativeCalls.godot_icall_5_523(method_bind_10, ptr, negativeX, positiveX, negativeY, positiveY, deadzone, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_joy_mapping");

        /// <summary>
        /// <para>Adds a new mapping entry (in SDL2 format) to the mapping database. Optionally update already connected devices.</para>
        /// </summary>
        [GodotMethod("add_joy_mapping")]
        public static void AddJoyMapping(string mapping, bool updateExisting = false)
        {
            NativeCalls.godot_icall_2_56(method_bind_11, ptr, mapping, updateExisting);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_joy_mapping");

        /// <summary>
        /// <para>Removes all mappings from the internal database that match the given GUID.</para>
        /// </summary>
        [GodotMethod("remove_joy_mapping")]
        public static void RemoveJoyMapping(string guid)
        {
            NativeCalls.godot_icall_1_54(method_bind_12, ptr, guid);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "joy_connection_changed");

        /// <summary>
        /// <para>Notifies the <see cref="Godot.Input"/> singleton that a connection has changed, to update the state for the <c>device</c> index.</para>
        /// <para>This is used internally and should not have to be called from user scripts. See <c>joy_connection_changed</c> for the signal emitted when this is triggered internally.</para>
        /// </summary>
        [GodotMethod("joy_connection_changed")]
        public static void JoyConnectionChanged(int device, bool connected, string name, string guid)
        {
            NativeCalls.godot_icall_4_524(method_bind_13, ptr, device, connected, name, guid);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_joy_known");

        /// <summary>
        /// <para>Returns <c>true</c> if the system knows the specified device. This means that it sets all button and axis indices exactly as defined in <see cref="Godot.JoystickList"/>. Unknown joypads are not expected to match these constants, but you can still retrieve events from them.</para>
        /// </summary>
        [GodotMethod("is_joy_known")]
        public static bool IsJoyKnown(int device)
        {
            return NativeCalls.godot_icall_1_35(method_bind_14, ptr, device);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_joy_axis");

        /// <summary>
        /// <para>Returns the current value of the joypad axis at given index (see <see cref="Godot.JoystickList"/>).</para>
        /// </summary>
        [GodotMethod("get_joy_axis")]
        public static float GetJoyAxis(int device, int axis)
        {
            return NativeCalls.godot_icall_2_70(method_bind_15, ptr, device, axis);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_joy_name");

        /// <summary>
        /// <para>Returns the name of the joypad at the specified device index.</para>
        /// </summary>
        [GodotMethod("get_joy_name")]
        public static string GetJoyName(int device)
        {
            return NativeCalls.godot_icall_1_89(method_bind_16, ptr, device);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_joy_guid");

        /// <summary>
        /// <para>Returns a SDL2-compatible device GUID on platforms that use gamepad remapping. Returns <c>"Default Gamepad"</c> otherwise.</para>
        /// </summary>
        [GodotMethod("get_joy_guid")]
        public static string GetJoyGuid(int device)
        {
            return NativeCalls.godot_icall_1_89(method_bind_17, ptr, device);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connected_joypads");

        /// <summary>
        /// <para>Returns an <see cref="Godot.Collections.Array"/> containing the device IDs of all currently connected joypads.</para>
        /// </summary>
        [GodotMethod("get_connected_joypads")]
        public static Godot.Collections.Array GetConnectedJoypads()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_18, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_joy_vibration_strength");

        /// <summary>
        /// <para>Returns the strength of the joypad vibration: x is the strength of the weak motor, and y is the strength of the strong motor.</para>
        /// </summary>
        [GodotMethod("get_joy_vibration_strength")]
        public static Vector2 GetJoyVibrationStrength(int device)
        {
            NativeCalls.godot_icall_1_44(method_bind_19, ptr, device, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_joy_vibration_duration");

        /// <summary>
        /// <para>Returns the duration of the current vibration effect in seconds.</para>
        /// </summary>
        [GodotMethod("get_joy_vibration_duration")]
        public static float GetJoyVibrationDuration(int device)
        {
            return NativeCalls.godot_icall_1_12(method_bind_20, ptr, device);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_joy_button_string");

        /// <summary>
        /// <para>Receives a gamepad button from <see cref="Godot.JoystickList"/> and returns its equivalent name as a string.</para>
        /// </summary>
        [GodotMethod("get_joy_button_string")]
        public static string GetJoyButtonString(int buttonIndex)
        {
            return NativeCalls.godot_icall_1_89(method_bind_21, ptr, buttonIndex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_joy_button_index_from_string");

        /// <summary>
        /// <para>Returns the index of the provided button name.</para>
        /// </summary>
        [GodotMethod("get_joy_button_index_from_string")]
        public static int GetJoyButtonIndexFromString(string button)
        {
            return NativeCalls.godot_icall_1_138(method_bind_22, ptr, button);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_joy_axis_string");

        /// <summary>
        /// <para>Receives a <see cref="Godot.JoystickList"/> axis and returns its equivalent name as a string.</para>
        /// </summary>
        [GodotMethod("get_joy_axis_string")]
        public static string GetJoyAxisString(int axisIndex)
        {
            return NativeCalls.godot_icall_1_89(method_bind_23, ptr, axisIndex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_joy_axis_index_from_string");

        /// <summary>
        /// <para>Returns the index of the provided axis name.</para>
        /// </summary>
        [GodotMethod("get_joy_axis_index_from_string")]
        public static int GetJoyAxisIndexFromString(string axis)
        {
            return NativeCalls.godot_icall_1_138(method_bind_24, ptr, axis);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "start_joy_vibration");

        /// <summary>
        /// <para>Starts to vibrate the joypad. Joypads usually come with two rumble motors, a strong and a weak one. <c>weak_magnitude</c> is the strength of the weak motor (between 0 and 1) and <c>strong_magnitude</c> is the strength of the strong motor (between 0 and 1). <c>duration</c> is the duration of the effect in seconds (a duration of 0 will try to play the vibration indefinitely).</para>
        /// <para>Note: Not every hardware is compatible with long effect durations; it is recommended to restart an effect if it has to be played for more than a few seconds.</para>
        /// </summary>
        [GodotMethod("start_joy_vibration")]
        public static void StartJoyVibration(int device, float weakMagnitude, float strongMagnitude, float duration = (float)0)
        {
            NativeCalls.godot_icall_4_525(method_bind_25, ptr, device, weakMagnitude, strongMagnitude, duration);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "stop_joy_vibration");

        /// <summary>
        /// <para>Stops the vibration of the joypad.</para>
        /// </summary>
        [GodotMethod("stop_joy_vibration")]
        public static void StopJoyVibration(int device)
        {
            NativeCalls.godot_icall_1_4(method_bind_26, ptr, device);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "vibrate_handheld");

        /// <summary>
        /// <para>Vibrate handheld devices.</para>
        /// <para>Note: This method is implemented on Android, iOS, and HTML5.</para>
        /// <para>Note: For Android, it requires enabling the <c>VIBRATE</c> permission in the export preset.</para>
        /// <para>Note: For iOS, specifying the duration is supported in iOS 13 and later.</para>
        /// <para>Note: Some web browsers such as Safari and Firefox for Android do not support this method.</para>
        /// </summary>
        [GodotMethod("vibrate_handheld")]
        public static void VibrateHandheld(int durationMs = 500)
        {
            NativeCalls.godot_icall_1_4(method_bind_27, ptr, durationMs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_gravity");

        /// <summary>
        /// <para>Returns the gravity of the device's accelerometer sensor, if the device has one. Otherwise, the method returns <c>Vector3.ZERO</c>.</para>
        /// <para>Note: This method only works on Android and iOS. On other platforms, it always returns <c>Vector3.ZERO</c>. On Android the unit of measurement for each axis is m/s² while on iOS it's a multiple of the Earth's gravitational acceleration <c>g</c> (~9.81 m/s²).</para>
        /// </summary>
        [GodotMethod("get_gravity")]
        public static Vector3 GetGravity()
        {
            NativeCalls.godot_icall_0_8(method_bind_28, ptr, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_accelerometer");

        /// <summary>
        /// <para>Returns the acceleration of the device's accelerometer sensor, if the device has one. Otherwise, the method returns <c>Vector3.ZERO</c>.</para>
        /// <para>Note this method returns an empty <see cref="Godot.Vector3"/> when running from the editor even when your device has an accelerometer. You must export your project to a supported device to read values from the accelerometer.</para>
        /// <para>Note: This method only works on iOS, Android, and UWP. On other platforms, it always returns <c>Vector3.ZERO</c>. On Android the unit of measurement for each axis is m/s² while on iOS and UWP it's a multiple of the Earth's gravitational acceleration <c>g</c> (~9.81 m/s²).</para>
        /// </summary>
        [GodotMethod("get_accelerometer")]
        public static Vector3 GetAccelerometer()
        {
            NativeCalls.godot_icall_0_8(method_bind_29, ptr, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_magnetometer");

        /// <summary>
        /// <para>Returns the magnetic field strength in micro-Tesla for all axes of the device's magnetometer sensor, if the device has one. Otherwise, the method returns <c>Vector3.ZERO</c>.</para>
        /// <para>Note: This method only works on Android, iOS and UWP. On other platforms, it always returns <c>Vector3.ZERO</c>.</para>
        /// </summary>
        [GodotMethod("get_magnetometer")]
        public static Vector3 GetMagnetometer()
        {
            NativeCalls.godot_icall_0_8(method_bind_30, ptr, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_gyroscope");

        /// <summary>
        /// <para>Returns the rotation rate in rad/s around a device's X, Y, and Z axes of the gyroscope sensor, if the device has one. Otherwise, the method returns <c>Vector3.ZERO</c>.</para>
        /// <para>Note: This method only works on Android and iOS. On other platforms, it always returns <c>Vector3.ZERO</c>.</para>
        /// </summary>
        [GodotMethod("get_gyroscope")]
        public static Vector3 GetGyroscope()
        {
            NativeCalls.godot_icall_0_8(method_bind_31, ptr, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_gravity");

        /// <summary>
        /// <para>Sets the gravity value of the accelerometer sensor. Can be used for debugging on devices without a hardware sensor, for example in an editor on a PC.</para>
        /// <para>Note: This value can be immediately overwritten by the hardware sensor value on Android and iOS.</para>
        /// </summary>
        [GodotMethod("set_gravity")]
        public static void SetGravity(Vector3 value)
        {
            NativeCalls.godot_icall_1_148(method_bind_32, ptr, ref value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_accelerometer");

        /// <summary>
        /// <para>Sets the acceleration value of the accelerometer sensor. Can be used for debugging on devices without a hardware sensor, for example in an editor on a PC.</para>
        /// <para>Note: This value can be immediately overwritten by the hardware sensor value on Android and iOS.</para>
        /// </summary>
        [GodotMethod("set_accelerometer")]
        public static void SetAccelerometer(Vector3 value)
        {
            NativeCalls.godot_icall_1_148(method_bind_33, ptr, ref value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_magnetometer");

        /// <summary>
        /// <para>Sets the value of the magnetic field of the magnetometer sensor. Can be used for debugging on devices without a hardware sensor, for example in an editor on a PC.</para>
        /// <para>Note: This value can be immediately overwritten by the hardware sensor value on Android and iOS.</para>
        /// </summary>
        [GodotMethod("set_magnetometer")]
        public static void SetMagnetometer(Vector3 value)
        {
            NativeCalls.godot_icall_1_148(method_bind_34, ptr, ref value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_gyroscope");

        /// <summary>
        /// <para>Sets the value of the rotation rate of the gyroscope sensor. Can be used for debugging on devices without a hardware sensor, for example in an editor on a PC.</para>
        /// <para>Note: This value can be immediately overwritten by the hardware sensor value on Android and iOS.</para>
        /// </summary>
        [GodotMethod("set_gyroscope")]
        public static void SetGyroscope(Vector3 value)
        {
            NativeCalls.godot_icall_1_148(method_bind_35, ptr, ref value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_last_mouse_speed");

        /// <summary>
        /// <para>Returns the mouse speed for the last time the cursor was moved, and this until the next frame where the mouse moves. This means that even if the mouse is not moving, this function will still return the value of the last motion.</para>
        /// </summary>
        [GodotMethod("get_last_mouse_speed")]
        public static Vector2 GetLastMouseSpeed()
        {
            NativeCalls.godot_icall_0_18(method_bind_36, ptr, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mouse_button_mask");

        /// <summary>
        /// <para>Returns mouse buttons as a bitmask. If multiple mouse buttons are pressed at the same time, the bits are added together.</para>
        /// </summary>
        [GodotMethod("get_mouse_button_mask")]
        public static int GetMouseButtonMask()
        {
            return NativeCalls.godot_icall_0_5(method_bind_37, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mouse_mode");

        [GodotMethod("set_mouse_mode")]
        [Obsolete("SetMouseMode is deprecated. Use the MouseMode property instead.")]
        public static void SetMouseMode(Input.MouseModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_38, ptr, (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mouse_mode");

        [GodotMethod("get_mouse_mode")]
        [Obsolete("GetMouseMode is deprecated. Use the MouseMode property instead.")]
        public static Input.MouseModeEnum GetMouseMode()
        {
            return (Input.MouseModeEnum)NativeCalls.godot_icall_0_526(method_bind_39, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "warp_mouse_position");

        /// <summary>
        /// <para>Sets the mouse position to the specified vector, provided in pixels and relative to an origin at the upper left corner of the game window.</para>
        /// <para>Mouse position is clipped to the limits of the screen resolution, or to the limits of the game window if <see cref="Godot.Input.MouseModeEnum"/> is set to <see cref="Godot.Input.MouseModeEnum.Confined"/>.</para>
        /// </summary>
        [GodotMethod("warp_mouse_position")]
        public static void WarpMousePosition(Vector2 to)
        {
            NativeCalls.godot_icall_1_57(method_bind_40, ptr, ref to);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "action_press");

        /// <summary>
        /// <para>This will simulate pressing the specified action.</para>
        /// <para>The strength can be used for non-boolean actions, it's ranged between 0 and 1 representing the intensity of the given action.</para>
        /// <para>Note: This method will not cause any <see cref="Godot.Node._Input"/> calls. It is intended to be used with <see cref="Godot.Input.IsActionPressed"/> and <see cref="Godot.Input.IsActionJustPressed"/>. If you want to simulate <c>_input</c>, use <see cref="Godot.Input.ParseInputEvent"/> instead.</para>
        /// </summary>
        [GodotMethod("action_press")]
        public static void ActionPress(string action, float strength = 1f)
        {
            NativeCalls.godot_icall_2_128(method_bind_41, ptr, action, strength);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "action_release");

        /// <summary>
        /// <para>If the specified action is already pressed, this will release it.</para>
        /// </summary>
        [GodotMethod("action_release")]
        public static void ActionRelease(string action)
        {
            NativeCalls.godot_icall_1_54(method_bind_42, ptr, action);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_default_cursor_shape");

        /// <summary>
        /// <para>Sets the default cursor shape to be used in the viewport instead of <see cref="Godot.Input.CursorShape.Arrow"/>.</para>
        /// <para>Note: If you want to change the default cursor shape for <see cref="Godot.Control"/>'s nodes, use <see cref="Godot.Control.MouseDefaultCursorShape"/> instead.</para>
        /// <para>Note: This method generates an <see cref="Godot.InputEventMouseMotion"/> to update cursor immediately.</para>
        /// </summary>
        [GodotMethod("set_default_cursor_shape")]
        public static void SetDefaultCursorShape(Input.CursorShape shape = (Input.CursorShape)0)
        {
            NativeCalls.godot_icall_1_4(method_bind_43, ptr, (int)shape);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_cursor_shape");

        /// <summary>
        /// <para>Returns the currently assigned cursor shape (see <see cref="Godot.Input.CursorShape"/>).</para>
        /// </summary>
        [GodotMethod("get_current_cursor_shape")]
        public static Input.CursorShape GetCurrentCursorShape()
        {
            return (Input.CursorShape)NativeCalls.godot_icall_0_527(method_bind_44, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_custom_mouse_cursor");

        /// <summary>
        /// <para>Sets a custom mouse cursor image, which is only visible inside the game window. The hotspot can also be specified. Passing <c>null</c> to the image parameter resets to the system cursor. See <see cref="Godot.Input.CursorShape"/> for the list of shapes.</para>
        /// <para><c>image</c>'s size must be lower than 256×256.</para>
        /// <para><c>hotspot</c> must be within <c>image</c>'s size.</para>
        /// <para>Note: <see cref="Godot.AnimatedTexture"/>s aren't supported as custom mouse cursors. If using an <see cref="Godot.AnimatedTexture"/>, only the first frame will be displayed.</para>
        /// <para>Note: Only images imported with the Lossless, Lossy or Uncompressed compression modes are supported. The Video RAM compression mode can't be used for custom cursors.</para>
        /// <para>Note: On the web platform, the maximum allowed cursor image size is 128×128. Cursor images larger than 32×32 will also only be displayed if the mouse cursor image is entirely located within the page for <a href="https://chromestatus.com/feature/5825971391299584">security reasons</a>.</para>
        /// </summary>
        /// <param name="hotspot">If the parameter is null, then the default value is new Vector2(0, 0)</param>
        [GodotMethod("set_custom_mouse_cursor")]
        public static void SetCustomMouseCursor(Resource image, Input.CursorShape shape = (Input.CursorShape)0, Nullable<Vector2> hotspot = null)
        {
            Vector2 hotspot_in = hotspot.HasValue ? hotspot.Value : new Vector2(0, 0);
            NativeCalls.godot_icall_3_528(method_bind_45, ptr, Object.GetPtr(image), (int)shape, ref hotspot_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "parse_input_event");

        /// <summary>
        /// <para>Feeds an <see cref="Godot.InputEvent"/> to the game. Can be used to artificially trigger input events from code. Also generates <see cref="Godot.Node._Input"/> calls.</para>
        /// <para>Example:</para>
        /// <para><code>
        /// var a = InputEventAction.new()
        /// a.action = "ui_cancel"
        /// a.pressed = true
        /// Input.parse_input_event(a)
        /// </code></para>
        /// </summary>
        [GodotMethod("parse_input_event")]
        public static void ParseInputEvent(InputEvent @event)
        {
            NativeCalls.godot_icall_1_24(method_bind_46, ptr, Object.GetPtr(@event));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_accumulated_input");

        [GodotMethod("set_use_accumulated_input")]
        [Obsolete("SetUseAccumulatedInput is deprecated. Use the UseAccumulatedInput property instead.")]
        public static void SetUseAccumulatedInput(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_47, ptr, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_using_accumulated_input");

        [GodotMethod("is_using_accumulated_input")]
        [Obsolete("IsUsingAccumulatedInput is deprecated. Use the UseAccumulatedInput property instead.")]
        public static bool IsUsingAccumulatedInput()
        {
            return NativeCalls.godot_icall_0_7(method_bind_48, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "flush_buffered_events");

        /// <summary>
        /// <para>Sends all input events which are in the current buffer to the game loop. These events may have been buffered as a result of accumulated input (<see cref="Godot.Input.UseAccumulatedInput"/>) or agile input flushing ().</para>
        /// <para>The engine will already do this itself at key execution points (at least once per frame). However, this can be useful in advanced cases where you want precise control over the timing of event handling.</para>
        /// </summary>
        [GodotMethod("flush_buffered_events")]
        public static void FlushBufferedEvents()
        {
            NativeCalls.godot_icall_0_3(method_bind_49, ptr);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
