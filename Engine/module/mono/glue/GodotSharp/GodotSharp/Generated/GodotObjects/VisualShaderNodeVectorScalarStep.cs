using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Translates to <c>step(edge, x)</c> in the shader language.</para>
    /// <para>Returns <c>0.0</c> if <c>x</c> is smaller than <c>edge</c> and <c>1.0</c> otherwise.</para>
    /// </summary>
    public partial class VisualShaderNodeVectorScalarStep : VisualShaderNode
    {
        private const string nativeName = "VisualShaderNodeVectorScalarStep";

        public VisualShaderNodeVectorScalarStep() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeVectorScalarStep_Ctor(this);
        }

        internal VisualShaderNodeVectorScalarStep(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
