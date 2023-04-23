using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Panel is a <see cref="Godot.Control"/> that displays an opaque background. It's commonly used as a parent and container for other types of <see cref="Godot.Control"/> nodes.</para>
    /// </summary>
    public partial class Panel : Control
    {
        private const string nativeName = "Panel";

        public Panel() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Panel_Ctor(this);
        }

        internal Panel(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
