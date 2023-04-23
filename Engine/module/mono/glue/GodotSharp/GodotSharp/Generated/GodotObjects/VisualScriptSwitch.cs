using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Branches the flow based on an input's value. Use Case Count in the Inspector to set the number of branches and each comparison's optional type.</para>
    /// <para>Input Ports:</para>
    /// <para>- Sequence: <c>'input' is</c></para>
    /// <para>- Data (variant): <c>=</c></para>
    /// <para>- Data (variant): <c>=</c> (optional)</para>
    /// <para>- Data (variant): <c>input</c></para>
    /// <para>Output Ports:</para>
    /// <para>- Sequence</para>
    /// <para>- Sequence (optional)</para>
    /// <para>- Sequence: <c>done</c></para>
    /// </summary>
    public partial class VisualScriptSwitch : VisualScriptNode
    {
        private const string nativeName = "VisualScriptSwitch";

        public VisualScriptSwitch() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptSwitch_Ctor(this);
        }

        internal VisualScriptSwitch(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
