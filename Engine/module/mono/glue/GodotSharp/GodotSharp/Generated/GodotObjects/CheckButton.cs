using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>CheckButton is a toggle button displayed as a check field. It's similar to <see cref="Godot.CheckBox"/> in functionality, but it has a different appearance. To follow established UX patterns, it's recommended to use CheckButton when toggling it has an immediate effect on something. For instance, it should be used if toggling it enables/disables a setting without requiring the user to press a confirmation button.</para>
    /// <para>See also <see cref="Godot.BaseButton"/> which contains common properties and methods associated with this node.</para>
    /// </summary>
    public partial class CheckButton : Button
    {
        private const string nativeName = "CheckButton";

        public CheckButton() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CheckButton_Ctor(this);
        }

        internal CheckButton(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
