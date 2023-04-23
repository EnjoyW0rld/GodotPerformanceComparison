using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A Visual Script node that can execute a custom expression. Values can be provided for the input and the expression result can be retrieved from the output.</para>
    /// </summary>
    public partial class VisualScriptExpression : VisualScriptNode
    {
        private const string nativeName = "VisualScriptExpression";

        public VisualScriptExpression() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptExpression_Ctor(this);
        }

        internal VisualScriptExpression(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
