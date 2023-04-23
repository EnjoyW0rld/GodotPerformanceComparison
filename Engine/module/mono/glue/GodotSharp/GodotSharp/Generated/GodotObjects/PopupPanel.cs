using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Class for displaying popups with a panel background. In some cases it might be simpler to use than <see cref="Godot.Popup"/>, since it provides a configurable background. If you are making windows, better check <see cref="Godot.WindowDialog"/>.</para>
    /// <para>If any <see cref="Godot.Control"/> node is added as a child of this <see cref="Godot.PopupPanel"/>, it will be stretched to fit the panel's size (similar to how <see cref="Godot.PanelContainer"/> works).</para>
    /// </summary>
    public partial class PopupPanel : Popup
    {
        private const string nativeName = "PopupPanel";

        public PopupPanel() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PopupPanel_Ctor(this);
        }

        internal PopupPanel(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
