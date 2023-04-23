using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Horizontal separator. See <see cref="Godot.Separator"/>. Even though it looks horizontal, it is used to separate objects vertically.</para>
    /// </summary>
    public partial class HSeparator : Separator
    {
        private const string nativeName = "HSeparator";

        public HSeparator() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_HSeparator_Ctor(this);
        }

        internal HSeparator(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
