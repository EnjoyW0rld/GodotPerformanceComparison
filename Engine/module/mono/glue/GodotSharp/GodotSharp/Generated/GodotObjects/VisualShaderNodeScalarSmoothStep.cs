using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Translates to <c>smoothstep(edge0, edge1, x)</c> in the shader language.</para>
    /// <para>Returns <c>0.0</c> if <c>x</c> is smaller than <c>edge0</c> and <c>1.0</c> if <c>x</c> is larger than <c>edge1</c>. Otherwise the return value is interpolated between <c>0.0</c> and <c>1.0</c> using Hermite polynomials.</para>
    /// </summary>
    public partial class VisualShaderNodeScalarSmoothStep : VisualShaderNode
    {
        private const string nativeName = "VisualShaderNodeScalarSmoothStep";

        public VisualShaderNodeScalarSmoothStep() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeScalarSmoothStep_Ctor(this);
        }

        internal VisualShaderNodeScalarSmoothStep(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
