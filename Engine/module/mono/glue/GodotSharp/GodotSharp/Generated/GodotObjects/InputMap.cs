using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Manages all <see cref="Godot.InputEventAction"/> which can be created/modified from the project settings menu Project &gt; Project Settings &gt; Input Map or in code with <see cref="Godot.InputMap.AddAction"/> and <see cref="Godot.InputMap.ActionAddEvent"/>. See <see cref="Godot.Node._Input"/>.</para>
    /// </summary>
    public static partial class InputMap
    {
        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(InputMap).Name);
                return singleton;
            }
        }

        private const string nativeName = "InputMap";
        internal static IntPtr ptr = NativeCalls.godot_icall_InputMap_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_action");

        /// <summary>
        /// <para>Returns <c>true</c> if the <see cref="Godot.InputMap"/> has a registered action with the given name.</para>
        /// </summary>
        [GodotMethod("has_action")]
        public static bool HasAction(string action)
        {
            return NativeCalls.godot_icall_1_108(method_bind_0, ptr, action);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_actions");

        /// <summary>
        /// <para>Returns an array of all actions in the <see cref="Godot.InputMap"/>.</para>
        /// </summary>
        [GodotMethod("get_actions")]
        public static Godot.Collections.Array GetActions()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_1, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_action");

        /// <summary>
        /// <para>Adds an empty action to the <see cref="Godot.InputMap"/> with a configurable <c>deadzone</c>.</para>
        /// <para>An <see cref="Godot.InputEvent"/> can then be added to this action with <see cref="Godot.InputMap.ActionAddEvent"/>.</para>
        /// </summary>
        [GodotMethod("add_action")]
        public static void AddAction(string action, float deadzone = 0.5f)
        {
            NativeCalls.godot_icall_2_128(method_bind_2, ptr, action, deadzone);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "erase_action");

        /// <summary>
        /// <para>Removes an action from the <see cref="Godot.InputMap"/>.</para>
        /// </summary>
        [GodotMethod("erase_action")]
        public static void EraseAction(string action)
        {
            NativeCalls.godot_icall_1_54(method_bind_3, ptr, action);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "action_set_deadzone");

        /// <summary>
        /// <para>Sets a deadzone value for the action.</para>
        /// </summary>
        [GodotMethod("action_set_deadzone")]
        public static void ActionSetDeadzone(string action, float deadzone)
        {
            NativeCalls.godot_icall_2_128(method_bind_4, ptr, action, deadzone);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "action_get_deadzone");

        /// <summary>
        /// <para>Returns a deadzone value for the action.</para>
        /// </summary>
        [GodotMethod("action_get_deadzone")]
        public static float ActionGetDeadzone(string action)
        {
            return NativeCalls.godot_icall_1_140(method_bind_5, ptr, action);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "action_add_event");

        /// <summary>
        /// <para>Adds an <see cref="Godot.InputEvent"/> to an action. This <see cref="Godot.InputEvent"/> will trigger the action.</para>
        /// </summary>
        [GodotMethod("action_add_event")]
        public static void ActionAddEvent(string action, InputEvent @event)
        {
            NativeCalls.godot_icall_2_114(method_bind_6, ptr, action, Object.GetPtr(@event));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "action_has_event");

        /// <summary>
        /// <para>Returns <c>true</c> if the action has the given <see cref="Godot.InputEvent"/> associated with it.</para>
        /// </summary>
        [GodotMethod("action_has_event")]
        public static bool ActionHasEvent(string action, InputEvent @event)
        {
            return NativeCalls.godot_icall_2_533(method_bind_7, ptr, action, Object.GetPtr(@event));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "action_erase_event");

        /// <summary>
        /// <para>Removes an <see cref="Godot.InputEvent"/> from an action.</para>
        /// </summary>
        [GodotMethod("action_erase_event")]
        public static void ActionEraseEvent(string action, InputEvent @event)
        {
            NativeCalls.godot_icall_2_114(method_bind_8, ptr, action, Object.GetPtr(@event));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "action_erase_events");

        /// <summary>
        /// <para>Removes all events from an action.</para>
        /// </summary>
        [GodotMethod("action_erase_events")]
        public static void ActionEraseEvents(string action)
        {
            NativeCalls.godot_icall_1_54(method_bind_9, ptr, action);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_action_list");

        /// <summary>
        /// <para>Returns an array of <see cref="Godot.InputEvent"/>s associated with a given action.</para>
        /// <para>Note: When used in the editor (e.g. a tool script or <see cref="Godot.EditorPlugin"/>), this method will return events for the editor action. If you want to access your project's input binds from the editor, read the <c>input/*</c> settings from <see cref="Godot.ProjectSettings"/>.</para>
        /// </summary>
        [GodotMethod("get_action_list")]
        public static Godot.Collections.Array GetActionList(string action)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_1_534(method_bind_10, ptr, action));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "event_is_action");

        /// <summary>
        /// <para>Returns <c>true</c> if the given event is part of an existing action. This method ignores keyboard modifiers if the given <see cref="Godot.InputEvent"/> is not pressed (for proper release detection). See <see cref="Godot.InputMap.ActionHasEvent"/> if you don't want this behavior.</para>
        /// <para>If <c>exact_match</c> is <c>false</c>, it ignores additional input modifiers for <see cref="Godot.InputEventKey"/> and <see cref="Godot.InputEventMouseButton"/> events, and the direction for <see cref="Godot.InputEventJoypadMotion"/> events.</para>
        /// </summary>
        [GodotMethod("event_is_action")]
        public static bool EventIsAction(InputEvent @event, string action, bool exactMatch = false)
        {
            return NativeCalls.godot_icall_3_535(method_bind_11, ptr, Object.GetPtr(@event), action, exactMatch);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "load_from_globals");

        /// <summary>
        /// <para>Clears all <see cref="Godot.InputEventAction"/> in the <see cref="Godot.InputMap"/> and load it anew from <see cref="Godot.ProjectSettings"/>.</para>
        /// </summary>
        [GodotMethod("load_from_globals")]
        public static void LoadFromGlobals()
        {
            NativeCalls.godot_icall_0_3(method_bind_12, ptr);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
