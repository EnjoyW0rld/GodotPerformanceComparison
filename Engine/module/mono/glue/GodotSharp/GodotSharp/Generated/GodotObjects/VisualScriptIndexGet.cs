using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.VisualScriptIndexGet"/> will return the value stored in an array or a dictionary under the given index.</para>
    /// </summary>
    public partial class VisualScriptIndexGet : VisualScriptNode
    {
        private const string nativeName = "VisualScriptIndexGet";

        public VisualScriptIndexGet() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptIndexGet_Ctor(this);
        }

        internal VisualScriptIndexGet(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
