using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Vertical version of <see cref="Godot.Separator"/>. Even though it looks vertical, it is used to separate objects horizontally.</para>
    /// </summary>
    public partial class VSeparator : Separator
    {
        private const string nativeName = "VSeparator";

        public VSeparator() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VSeparator_Ctor(this);
        }

        internal VSeparator(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
