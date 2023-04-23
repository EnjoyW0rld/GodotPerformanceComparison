using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>PopupDialog is a base class for popup dialogs, along with <see cref="Godot.WindowDialog"/>.</para>
    /// </summary>
    public partial class PopupDialog : Popup
    {
        private const string nativeName = "PopupDialog";

        public PopupDialog() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PopupDialog_Ctor(this);
        }

        internal PopupDialog(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
