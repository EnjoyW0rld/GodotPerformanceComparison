using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Loops while a condition is <c>true</c>. Execution continues out the <c>exit</c> Sequence port when the loop terminates.</para>
    /// <para>Input Ports:</para>
    /// <para>- Sequence: <c>while(cond)</c></para>
    /// <para>- Data (bool): <c>cond</c></para>
    /// <para>Output Ports:</para>
    /// <para>- Sequence: <c>repeat</c></para>
    /// <para>- Sequence: <c>exit</c></para>
    /// </summary>
    public partial class VisualScriptWhile : VisualScriptNode
    {
        private const string nativeName = "VisualScriptWhile";

        public VisualScriptWhile() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptWhile_Ctor(this);
        }

        internal VisualScriptWhile(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
