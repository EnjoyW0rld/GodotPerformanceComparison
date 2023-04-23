using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Horizontal split container. See <see cref="Godot.SplitContainer"/>. This goes from left to right.</para>
    /// </summary>
    public partial class HSplitContainer : SplitContainer
    {
        private const string nativeName = "HSplitContainer";

        public HSplitContainer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_HSplitContainer_Ctor(this);
        }

        internal HSplitContainer(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
