using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Constrains a value to lie between <c>min</c> and <c>max</c> values.</para>
    /// </summary>
    public partial class VisualShaderNodeScalarClamp : VisualShaderNode
    {
        private const string nativeName = "VisualShaderNodeScalarClamp";

        public VisualShaderNodeScalarClamp() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeScalarClamp_Ctor(this);
        }

        internal VisualShaderNodeScalarClamp(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
