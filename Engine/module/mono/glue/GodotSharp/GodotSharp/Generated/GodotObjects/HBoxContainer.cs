using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Horizontal box container. See <see cref="Godot.BoxContainer"/>.</para>
    /// </summary>
    public partial class HBoxContainer : BoxContainer
    {
        private const string nativeName = "HBoxContainer";

        public HBoxContainer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_HBoxContainer_Ctor(this);
        }

        internal HBoxContainer(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
