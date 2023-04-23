using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Stores key presses on the keyboard. Supports key presses, key releases and <see cref="Godot.InputEventKey.Echo"/> events.</para>
    /// </summary>
    public partial class InputEventKey : InputEventWithModifiers
    {
        /// <summary>
        /// <para>If <c>true</c>, the key's state is pressed. If <c>false</c>, the key's state is released.</para>
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
        /// <para>The key scancode, which corresponds to one of the <see cref="Godot.KeyList"/> constants. Represent key in the current keyboard layout.</para>
        /// <para>To get a human-readable representation of the <see cref="Godot.InputEventKey"/>, use <c>OS.get_scancode_string(event.scancode)</c> where <c>event</c> is the <see cref="Godot.InputEventKey"/>.</para>
        /// </summary>
        public uint Scancode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetScancode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetScancode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Key physical scancode, which corresponds to one of the <see cref="Godot.KeyList"/> constants. Represent the physical location of a key on the 101/102-key US QWERTY keyboard.</para>
        /// <para>To get a human-readable representation of the <see cref="Godot.InputEventKey"/>, use <c>OS.get_scancode_string(event.physical_scancode)</c> where <c>event</c> is the <see cref="Godot.InputEventKey"/>.</para>
        /// </summary>
        public uint PhysicalScancode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPhysicalScancode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPhysicalScancode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The key Unicode identifier (when relevant). Unicode identifiers for the composite characters and complex scripts may not be available unless IME input mode is active. See <see cref="Godot.OS.SetImeActive"/> for more information.</para>
        /// </summary>
        public uint Unicode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUnicode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUnicode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the key was already pressed before this event. It means the user is holding the key down.</para>
        /// </summary>
        public bool Echo
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsEcho();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEcho(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "InputEventKey";

        public InputEventKey() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_InputEventKey_Ctor(this);
        }

        internal InputEventKey(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pressed");

        [GodotMethod("set_pressed")]
        [Obsolete("SetPressed is deprecated. Use the Pressed property instead.")]
        public void SetPressed(bool pressed)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), pressed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_scancode");

        [GodotMethod("set_scancode")]
        [Obsolete("SetScancode is deprecated. Use the Scancode property instead.")]
        public void SetScancode(uint scancode)
        {
            NativeCalls.godot_icall_1_187(method_bind_1, Object.GetPtr(this), scancode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_scancode");

        [GodotMethod("get_scancode")]
        [Obsolete("GetScancode is deprecated. Use the Scancode property instead.")]
        public uint GetScancode()
        {
            return NativeCalls.godot_icall_0_188(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_physical_scancode");

        [GodotMethod("set_physical_scancode")]
        [Obsolete("SetPhysicalScancode is deprecated. Use the PhysicalScancode property instead.")]
        public void SetPhysicalScancode(uint scancode)
        {
            NativeCalls.godot_icall_1_187(method_bind_3, Object.GetPtr(this), scancode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_physical_scancode");

        [GodotMethod("get_physical_scancode")]
        [Obsolete("GetPhysicalScancode is deprecated. Use the PhysicalScancode property instead.")]
        public uint GetPhysicalScancode()
        {
            return NativeCalls.godot_icall_0_188(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_unicode");

        [GodotMethod("set_unicode")]
        [Obsolete("SetUnicode is deprecated. Use the Unicode property instead.")]
        public void SetUnicode(uint unicode)
        {
            NativeCalls.godot_icall_1_187(method_bind_5, Object.GetPtr(this), unicode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_unicode");

        [GodotMethod("get_unicode")]
        [Obsolete("GetUnicode is deprecated. Use the Unicode property instead.")]
        public uint GetUnicode()
        {
            return NativeCalls.godot_icall_0_188(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_echo");

        [GodotMethod("set_echo")]
        [Obsolete("SetEcho is deprecated. Use the Echo property instead.")]
        public void SetEcho(bool echo)
        {
            NativeCalls.godot_icall_1_16(method_bind_7, Object.GetPtr(this), echo);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_scancode_with_modifiers");

        /// <summary>
        /// <para>Returns the scancode combined with modifier keys such as <c>Shift</c> or <c>Alt</c>. See also <see cref="Godot.InputEventWithModifiers"/>.</para>
        /// <para>To get a human-readable representation of the <see cref="Godot.InputEventKey"/> with modifiers, use <c>OS.get_scancode_string(event.get_scancode_with_modifiers())</c> where <c>event</c> is the <see cref="Godot.InputEventKey"/>.</para>
        /// </summary>
        [GodotMethod("get_scancode_with_modifiers")]
        public uint GetScancodeWithModifiers()
        {
            return NativeCalls.godot_icall_0_188(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_physical_scancode_with_modifiers");

        /// <summary>
        /// <para>Returns the physical scancode combined with modifier keys such as <c>Shift</c> or <c>Alt</c>. See also <see cref="Godot.InputEventWithModifiers"/>.</para>
        /// <para>To get a human-readable representation of the <see cref="Godot.InputEventKey"/> with modifiers, use <c>OS.get_scancode_string(event.get_physical_scancode_with_modifiers())</c> where <c>event</c> is the <see cref="Godot.InputEventKey"/>.</para>
        /// </summary>
        [GodotMethod("get_physical_scancode_with_modifiers")]
        public uint GetPhysicalScancodeWithModifiers()
        {
            return NativeCalls.godot_icall_0_188(method_bind_9, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
