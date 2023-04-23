using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Allows control of <see cref="Godot.AnimationTree"/> state machines created with <see cref="Godot.AnimationNodeStateMachine"/>. Retrieve with <c>$AnimationTree.get("parameters/playback")</c>.</para>
    /// <para>Example:</para>
    /// <para><code>
    /// var state_machine = $AnimationTree.get("parameters/playback")
    /// state_machine.travel("some_state")
    /// </code></para>
    /// </summary>
    public partial class AnimationNodeStateMachinePlayback : Resource
    {
        private const string nativeName = "AnimationNodeStateMachinePlayback";

        public AnimationNodeStateMachinePlayback() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AnimationNodeStateMachinePlayback_Ctor(this);
        }

        internal AnimationNodeStateMachinePlayback(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "travel");

        /// <summary>
        /// <para>Transitions from the current state to another one, following the shortest path.</para>
        /// </summary>
        [GodotMethod("travel")]
        public void Travel(string toNode)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), toNode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "start");

        /// <summary>
        /// <para>Starts playing the given animation.</para>
        /// </summary>
        [GodotMethod("start")]
        public void Start(string node)
        {
            NativeCalls.godot_icall_1_54(method_bind_1, Object.GetPtr(this), node);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "stop");

        /// <summary>
        /// <para>Stops the currently playing animation.</para>
        /// </summary>
        [GodotMethod("stop")]
        public void Stop()
        {
            NativeCalls.godot_icall_0_3(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_playing");

        /// <summary>
        /// <para>Returns <c>true</c> if an animation is playing.</para>
        /// </summary>
        [GodotMethod("is_playing")]
        public bool IsPlaying()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_node");

        /// <summary>
        /// <para>Returns the currently playing animation state.</para>
        /// </summary>
        [GodotMethod("get_current_node")]
        public string GetCurrentNode()
        {
            return NativeCalls.godot_icall_0_6(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_play_position");

        /// <summary>
        /// <para>Returns the playback position within the current animation state.</para>
        /// </summary>
        [GodotMethod("get_current_play_position")]
        public float GetCurrentPlayPosition()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_length");

        [GodotMethod("get_current_length")]
        public float GetCurrentLength()
        {
            return NativeCalls.godot_icall_0_14(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_travel_path");

        /// <summary>
        /// <para>Returns the current travel path as computed internally by the A* algorithm.</para>
        /// </summary>
        [GodotMethod("get_travel_path")]
        public string[] GetTravelPath()
        {
            return NativeCalls.godot_icall_0_119(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
