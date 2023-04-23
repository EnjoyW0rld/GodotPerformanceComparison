using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Vertical box container. See <see cref="Godot.BoxContainer"/>.</para>
    /// </summary>
    public partial class VBoxContainer : BoxContainer
    {
        private const string nativeName = "VBoxContainer";

        public VBoxContainer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VBoxContainer_Ctor(this);
        }

        internal VBoxContainer(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
