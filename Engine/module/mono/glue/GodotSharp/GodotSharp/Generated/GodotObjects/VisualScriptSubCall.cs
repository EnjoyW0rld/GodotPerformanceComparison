using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.VisualScriptSubCall"/> will call method named <c>_subcall</c> in the current script. It will fail if the method doesn't exist or the provided arguments are wrong.</para>
    /// </summary>
    public partial class VisualScriptSubCall : VisualScriptNode
    {
        private const string nativeName = "VisualScriptSubCall";

        public VisualScriptSubCall() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptSubCall_Ctor(this);
        }

        internal VisualScriptSubCall(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>Called by this node.</para>
        /// </summary>
        [GodotMethod("_subcall")]
        public virtual object _Subcall(object arguments)
        {
            return default(object);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
