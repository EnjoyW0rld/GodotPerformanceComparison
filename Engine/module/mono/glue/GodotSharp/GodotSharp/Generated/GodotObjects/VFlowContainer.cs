using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Vertical version of <see cref="Godot.FlowContainer"/>.</para>
    /// </summary>
    public partial class VFlowContainer : FlowContainer
    {
        private const string nativeName = "VFlowContainer";

        public VFlowContainer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VFlowContainer_Ctor(this);
        }

        internal VFlowContainer(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
