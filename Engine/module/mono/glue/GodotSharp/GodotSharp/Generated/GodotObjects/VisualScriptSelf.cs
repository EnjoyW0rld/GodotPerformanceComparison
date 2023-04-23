using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Provides a reference to the node running the visual script.</para>
    /// <para>Input Ports:</para>
    /// <para>none</para>
    /// <para>Output Ports:</para>
    /// <para>- Data (object): <c>instance</c></para>
    /// </summary>
    public partial class VisualScriptSelf : VisualScriptNode
    {
        private const string nativeName = "VisualScriptSelf";

        public VisualScriptSelf() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptSelf_Ctor(this);
        }

        internal VisualScriptSelf(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
