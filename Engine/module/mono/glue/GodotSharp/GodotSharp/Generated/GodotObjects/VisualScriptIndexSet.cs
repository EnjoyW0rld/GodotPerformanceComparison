using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.VisualScriptIndexSet"/> will set the value stored in an array or a dictionary under the given index to the provided new value.</para>
    /// </summary>
    public partial class VisualScriptIndexSet : VisualScriptNode
    {
        private const string nativeName = "VisualScriptIndexSet";

        public VisualScriptIndexSet() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptIndexSet_Ctor(this);
        }

        internal VisualScriptIndexSet(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
