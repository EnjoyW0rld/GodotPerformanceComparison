using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Contains a generic action which can be targeted from several types of inputs. Actions can be created from the Input Map tab in the Project &gt; Project Settings menu. See <see cref="Godot.Node._Input"/>.</para>
    /// </summary>
    public partial class InputEventAction : InputEvent
    {
        /// <summary>
        /// <para>The action's name. Actions are accessed via this <see cref="string"/>.</para>
        /// </summary>
        public string Action
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAction();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAction(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the action's state is pressed. If <c>false</c>, the action's state is released.</para>
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
        /// <para>The action's strength between 0 and 1. This value is considered as equal to 0 if pressed is <c>false</c>. The event strength allows faking analog joypad motion events, by specifying how strongly the joypad axis is bent or pressed.</para>
        /// </summary>
        public float Strength
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetStrength();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetStrength(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "InputEventAction";

        public InputEventAction() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_InputEventAction_Ctor(this);
        }

        internal InputEventAction(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_action");

        [GodotMethod("set_action")]
        [Obsolete("SetAction is deprecated. Use the Action property instead.")]
        public void SetAction(string action)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), action);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_action");

        [GodotMethod("get_action")]
        [Obsolete("GetAction is deprecated. Use the Action property instead.")]
        public string GetAction()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pressed");

        [GodotMethod("set_pressed")]
        [Obsolete("SetPressed is deprecated. Use the Pressed property instead.")]
        public void SetPressed(bool pressed)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), pressed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_strength");

        [GodotMethod("set_strength")]
        [Obsolete("SetStrength is deprecated. Use the Strength property instead.")]
        public void SetStrength(float strength)
        {
            NativeCalls.godot_icall_1_15(method_bind_3, Object.GetPtr(this), strength);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_strength");

        [GodotMethod("get_strength")]
        [Obsolete("GetStrength is deprecated. Use the Strength property instead.")]
        public float GetStrength()
        {
            return NativeCalls.godot_icall_0_14(method_bind_4, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
