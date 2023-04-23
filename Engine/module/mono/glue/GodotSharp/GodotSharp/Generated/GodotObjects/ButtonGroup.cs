using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Group of <see cref="Godot.Button"/>. All direct and indirect children buttons become radios. Only one allows being pressed.</para>
    /// <para><see cref="Godot.BaseButton.ToggleMode"/> should be <c>true</c>.</para>
    /// </summary>
    public partial class ButtonGroup : Resource
    {
        private const string nativeName = "ButtonGroup";

        public ButtonGroup() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ButtonGroup_Ctor(this);
        }

        internal ButtonGroup(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pressed_button");

        /// <summary>
        /// <para>Returns the current pressed button.</para>
        /// </summary>
        [GodotMethod("get_pressed_button")]
        public BaseButton GetPressedButton()
        {
            return NativeCalls.godot_icall_0_224(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_buttons");

        /// <summary>
        /// <para>Returns an <see cref="Godot.Collections.Array"/> of <see cref="Godot.Button"/>s who have this as their <see cref="Godot.ButtonGroup"/> (see <see cref="Godot.BaseButton.Group"/>).</para>
        /// </summary>
        [GodotMethod("get_buttons")]
        public Godot.Collections.Array GetButtons()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_1, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
