using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Horizontal version of <see cref="Godot.ScrollBar"/>, which goes from left (min) to right (max).</para>
    /// </summary>
    public partial class HScrollBar : ScrollBar
    {
        private const string nativeName = "HScrollBar";

        public HScrollBar() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_HScrollBar_Ctor(this);
        }

        internal HScrollBar(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
