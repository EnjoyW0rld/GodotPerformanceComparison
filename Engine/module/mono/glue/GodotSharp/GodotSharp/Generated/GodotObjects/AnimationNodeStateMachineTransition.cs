using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class AnimationNodeStateMachineTransition : Resource
    {
        public enum SwitchModeEnum
        {
            /// <summary>
            /// <para>Switch to the next state immediately. The current state will end and blend into the beginning of the new one.</para>
            /// </summary>
            Immediate = 0,
            /// <summary>
            /// <para>Switch to the next state immediately, but will seek the new state to the playback position of the old state.</para>
            /// </summary>
            Sync = 1,
            /// <summary>
            /// <para>Wait for the current state playback to end, then switch to the beginning of the next state animation.</para>
            /// </summary>
            AtEnd = 2
        }

        /// <summary>
        /// <para>The transition type.</para>
        /// </summary>
        public AnimationNodeStateMachineTransition.SwitchModeEnum SwitchMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSwitchMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSwitchMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Turn on the transition automatically when this state is reached. This works best with <see cref="Godot.AnimationNodeStateMachineTransition.SwitchModeEnum.AtEnd"/>.</para>
        /// </summary>
        public bool AutoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return HasAutoAdvance();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAutoAdvance(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Turn on auto advance when this condition is set. The provided name will become a boolean parameter on the <see cref="Godot.AnimationTree"/> that can be controlled from code (see <a href="$DOCS_URL/tutorials/animation/animation_tree.html#controlling-from-code">Using AnimationTree</a>). For example, if <see cref="Godot.AnimationTree.TreeRoot"/> is an <see cref="Godot.AnimationNodeStateMachine"/> and <see cref="Godot.AnimationNodeStateMachineTransition.AdvanceCondition"/> is set to <c>"idle"</c>:</para>
        /// <para><code>
        /// $animation_tree["parameters/conditions/idle"] = is_on_floor and (linear_velocity.x == 0)
        /// </code></para>
        /// </summary>
        public string AdvanceCondition
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAdvanceCondition();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAdvanceCondition(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The time to cross-fade between this state and the next.</para>
        /// </summary>
        public float XfadeTime
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetXfadeTime();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetXfadeTime(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Lower priority transitions are preferred when travelling through the tree via <see cref="Godot.AnimationNodeStateMachinePlayback.Travel"/> or <see cref="Godot.AnimationNodeStateMachineTransition.AutoAdvance"/>.</para>
        /// </summary>
        public int Priority
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPriority();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPriority(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Don't use this transition during <see cref="Godot.AnimationNodeStateMachinePlayback.Travel"/> or <see cref="Godot.AnimationNodeStateMachineTransition.AutoAdvance"/>.</para>
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

        private const string nativeName = "AnimationNodeStateMachineTransition";

        public AnimationNodeStateMachineTransition() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AnimationNodeStateMachineTransition_Ctor(this);
        }

        internal AnimationNodeStateMachineTransition(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_switch_mode");

        [GodotMethod("set_switch_mode")]
        [Obsolete("SetSwitchMode is deprecated. Use the SwitchMode property instead.")]
        public void SetSwitchMode(AnimationNodeStateMachineTransition.SwitchModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_switch_mode");

        [GodotMethod("get_switch_mode")]
        [Obsolete("GetSwitchMode is deprecated. Use the SwitchMode property instead.")]
        public AnimationNodeStateMachineTransition.SwitchModeEnum GetSwitchMode()
        {
            return (AnimationNodeStateMachineTransition.SwitchModeEnum)NativeCalls.godot_icall_0_120(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_auto_advance");

        [GodotMethod("set_auto_advance")]
        [Obsolete("SetAutoAdvance is deprecated. Use the AutoAdvance property instead.")]
        public void SetAutoAdvance(bool autoAdvance)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), autoAdvance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_auto_advance");

        [GodotMethod("has_auto_advance")]
        [Obsolete("HasAutoAdvance is deprecated. Use the AutoAdvance property instead.")]
        public bool HasAutoAdvance()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_advance_condition");

        [GodotMethod("set_advance_condition")]
        [Obsolete("SetAdvanceCondition is deprecated. Use the AdvanceCondition property instead.")]
        public void SetAdvanceCondition(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_4, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_advance_condition");

        [GodotMethod("get_advance_condition")]
        [Obsolete("GetAdvanceCondition is deprecated. Use the AdvanceCondition property instead.")]
        public string GetAdvanceCondition()
        {
            return NativeCalls.godot_icall_0_6(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_xfade_time");

        [GodotMethod("set_xfade_time")]
        [Obsolete("SetXfadeTime is deprecated. Use the XfadeTime property instead.")]
        public void SetXfadeTime(float secs)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), secs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_xfade_time");

        [GodotMethod("get_xfade_time")]
        [Obsolete("GetXfadeTime is deprecated. Use the XfadeTime property instead.")]
        public float GetXfadeTime()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
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
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_priority");

        [GodotMethod("set_priority")]
        [Obsolete("SetPriority is deprecated. Use the Priority property instead.")]
        public void SetPriority(int priority)
        {
            NativeCalls.godot_icall_1_4(method_bind_10, Object.GetPtr(this), priority);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_priority");

        [GodotMethod("get_priority")]
        [Obsolete("GetPriority is deprecated. Use the Priority property instead.")]
        public int GetPriority()
        {
            return NativeCalls.godot_icall_0_5(method_bind_11, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
