using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Vertical split container. See <see cref="Godot.SplitContainer"/>. This goes from top to bottom.</para>
    /// </summary>
    public partial class VSplitContainer : SplitContainer
    {
        private const string nativeName = "VSplitContainer";

        public VSplitContainer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VSplitContainer_Ctor(this);
        }

        internal VSplitContainer(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
