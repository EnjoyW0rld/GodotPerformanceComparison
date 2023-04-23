using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A checkbox allows the user to make a binary choice (choosing only one of two possible options). It's similar to <see cref="Godot.CheckButton"/> in functionality, but it has a different appearance. To follow established UX patterns, it's recommended to use CheckBox when toggling it has no immediate effect on something. For instance, it should be used when toggling it will only do something once a confirmation button is pressed.</para>
    /// <para>See also <see cref="Godot.BaseButton"/> which contains common properties and methods associated with this node.</para>
    /// </summary>
    public partial class CheckBox : Button
    {
        private const string nativeName = "CheckBox";

        public CheckBox() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CheckBox_Ctor(this);
        }

        internal CheckBox(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
