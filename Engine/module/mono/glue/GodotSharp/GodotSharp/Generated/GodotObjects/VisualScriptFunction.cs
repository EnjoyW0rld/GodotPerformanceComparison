using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.VisualScriptFunction"/> represents a function header. It is the starting point for the function body and can be used to tweak the function's properties (e.g. RPC mode).</para>
    /// </summary>
    public partial class VisualScriptFunction : VisualScriptNode
    {
        private const string nativeName = "VisualScriptFunction";

        public VisualScriptFunction() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptFunction_Ctor(this);
        }

        internal VisualScriptFunction(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
