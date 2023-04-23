using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Panel container type. This container fits controls inside of the delimited area of a stylebox. It's useful for giving controls an outline.</para>
    /// </summary>
    public partial class PanelContainer : Container
    {
        private const string nativeName = "PanelContainer";

        public PanelContainer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PanelContainer_Ctor(this);
        }

        internal PanelContainer(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
