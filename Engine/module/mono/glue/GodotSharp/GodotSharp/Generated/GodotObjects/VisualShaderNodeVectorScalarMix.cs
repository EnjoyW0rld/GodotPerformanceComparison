using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Translates to <c>mix(a, b, weight)</c> in the shader language, where <c>a</c> and <c>b</c> are vectors and <c>weight</c> is a scalar.</para>
    /// </summary>
    public partial class VisualShaderNodeVectorScalarMix : VisualShaderNode
    {
        private const string nativeName = "VisualShaderNodeVectorScalarMix";

        public VisualShaderNodeVectorScalarMix() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeVectorScalarMix_Ctor(this);
        }

        internal VisualShaderNodeVectorScalarMix(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
