using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Horizontal version of <see cref="Godot.FlowContainer"/>.</para>
    /// </summary>
    public partial class HFlowContainer : FlowContainer
    {
        private const string nativeName = "HFlowContainer";

        public HFlowContainer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_HFlowContainer_Ctor(this);
        }

        internal HFlowContainer(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
