using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Contains keys events information with modifiers support like <c>Shift</c> or <c>Alt</c>. See <see cref="Godot.Node._Input"/>.</para>
    /// </summary>
    public abstract partial class InputEventWithModifiers : InputEvent
    {
        /// <summary>
        /// <para>State of the <c>Alt</c> modifier.</para>
        /// </summary>
        public bool Alt
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAlt();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAlt(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>State of the <c>Shift</c> modifier.</para>
        /// </summary>
        public bool Shift
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShift();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShift(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>State of the <c>Ctrl</c> modifier.</para>
        /// </summary>
        public bool Control
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetControl();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetControl(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>State of the <c>Meta</c> modifier.</para>
        /// </summary>
        public bool Meta
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMetakey();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMetakey(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>State of the <c>Command</c> modifier.</para>
        /// </summary>
        public bool Command
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCommand();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCommand(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "InputEventWithModifiers";

        internal InputEventWithModifiers() {}

        internal InputEventWithModifiers(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_alt");

        [GodotMethod("set_alt")]
        [Obsolete("SetAlt is deprecated. Use the Alt property instead.")]
        public void SetAlt(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_alt");

        [GodotMethod("get_alt")]
        [Obsolete("GetAlt is deprecated. Use the Alt property instead.")]
        public bool GetAlt()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shift");

        [GodotMethod("set_shift")]
        [Obsolete("SetShift is deprecated. Use the Shift property instead.")]
        public void SetShift(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shift");

        [GodotMethod("get_shift")]
        [Obsolete("GetShift is deprecated. Use the Shift property instead.")]
        public bool GetShift()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_control");

        [GodotMethod("set_control")]
        [Obsolete("SetControl is deprecated. Use the Control property instead.")]
        public void SetControl(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_control");

        [GodotMethod("get_control")]
        [Obsolete("GetControl is deprecated. Use the Control property instead.")]
        public bool GetControl()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_metakey");

        [GodotMethod("set_metakey")]
        [Obsolete("SetMetakey is deprecated. Use the Meta property instead.")]
        public void SetMetakey(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_metakey");

        [GodotMethod("get_metakey")]
        [Obsolete("GetMetakey is deprecated. Use the Meta property instead.")]
        public bool GetMetakey()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_command");

        [GodotMethod("set_command")]
        [Obsolete("SetCommand is deprecated. Use the Command property instead.")]
        public void SetCommand(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_8, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_command");

        [GodotMethod("get_command")]
        [Obsolete("GetCommand is deprecated. Use the Command property instead.")]
        public bool GetCommand()
        {
            return NativeCalls.godot_icall_0_7(method_bind_9, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
