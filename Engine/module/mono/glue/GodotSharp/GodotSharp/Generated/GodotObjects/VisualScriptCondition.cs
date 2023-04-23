using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A Visual Script node that checks a <see cref="bool"/> input port. If <c>true</c>, it will exit via the "true" sequence port. If <c>false</c>, it will exit via the "false" sequence port. After exiting either, it exits via the "done" port. Sequence ports may be left disconnected.</para>
    /// <para>Input Ports:</para>
    /// <para>- Sequence: <c>if (cond) is</c></para>
    /// <para>- Data (boolean): <c>cond</c></para>
    /// <para>Output Ports:</para>
    /// <para>- Sequence: <c>true</c></para>
    /// <para>- Sequence: <c>false</c></para>
    /// <para>- Sequence: <c>done</c></para>
    /// </summary>
    public partial class VisualScriptCondition : VisualScriptNode
    {
        private const string nativeName = "VisualScriptCondition";

        public VisualScriptCondition() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptCondition_Ctor(this);
        }

        internal VisualScriptCondition(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
