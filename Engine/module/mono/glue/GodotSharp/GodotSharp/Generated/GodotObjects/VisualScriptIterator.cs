using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This node steps through each item in a given input. Input can be any sequence data type, such as an <see cref="Godot.Collections.Array"/> or <see cref="string"/>. When each item has been processed, execution passed out the <c>exit</c> Sequence port.</para>
    /// <para>Input Ports:</para>
    /// <para>- Sequence: <c>for (elem) in (input)</c></para>
    /// <para>- Data (variant): <c>input</c></para>
    /// <para>Output Ports:</para>
    /// <para>- Sequence: <c>each</c></para>
    /// <para>- Sequence: <c>exit</c></para>
    /// <para>- Data (variant): <c>elem</c></para>
    /// </summary>
    public partial class VisualScriptIterator : VisualScriptNode
    {
        private const string nativeName = "VisualScriptIterator";

        public VisualScriptIterator() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptIterator_Ctor(this);
        }

        internal VisualScriptIterator(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
