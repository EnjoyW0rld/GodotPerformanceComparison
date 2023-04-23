using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.VisualScriptInputAction"/> can be used to check if an action is pressed or released.</para>
    /// </summary>
    public partial class VisualScriptInputAction : VisualScriptNode
    {
        public enum ModeEnum
        {
            /// <summary>
            /// <para><c>True</c> if action is pressed.</para>
            /// </summary>
            Pressed = 0,
            /// <summary>
            /// <para><c>True</c> if action is released (i.e. not pressed).</para>
            /// </summary>
            Released = 1,
            /// <summary>
            /// <para><c>True</c> on the frame the action was pressed.</para>
            /// </summary>
            JustPressed = 2,
            /// <summary>
            /// <para><c>True</c> on the frame the action was released.</para>
            /// </summary>
            JustReleased = 3
        }

        /// <summary>
        /// <para>Name of the action.</para>
        /// </summary>
        public string Action
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetActionName();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetActionName(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>State of the action to check. See <see cref="Godot.VisualScriptInputAction.ModeEnum"/> for options.</para>
        /// </summary>
        public VisualScriptInputAction.ModeEnum Mode
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

        private const string nativeName = "VisualScriptInputAction";

        public VisualScriptInputAction() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptInputAction_Ctor(this);
        }

        internal VisualScriptInputAction(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_action_name");

        [GodotMethod("set_action_name")]
        [Obsolete("SetActionName is deprecated. Use the Action property instead.")]
        public void SetActionName(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_action_name");

        [GodotMethod("get_action_name")]
        [Obsolete("GetActionName is deprecated. Use the Action property instead.")]
        public string GetActionName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_action_mode");

        [GodotMethod("set_action_mode")]
        [Obsolete("SetActionMode is deprecated. Use the Mode property instead.")]
        public void SetActionMode(VisualScriptInputAction.ModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_action_mode");

        [GodotMethod("get_action_mode")]
        [Obsolete("GetActionMode is deprecated. Use the Mode property instead.")]
        public VisualScriptInputAction.ModeEnum GetActionMode()
        {
            return (VisualScriptInputAction.ModeEnum)NativeCalls.godot_icall_0_1035(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
