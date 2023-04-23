using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Empty stylebox (really does not display anything).</para>
    /// </summary>
    public partial class StyleBoxEmpty : StyleBox
    {
        private const string nativeName = "StyleBoxEmpty";

        public StyleBoxEmpty() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_StyleBoxEmpty_Ctor(this);
        }

        internal StyleBoxEmpty(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
