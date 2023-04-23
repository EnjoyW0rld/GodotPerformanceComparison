using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Translated to <c>refract(I, N, eta)</c> in the shader language, where <c>I</c> is the incident vector, <c>N</c> is the normal vector and <c>eta</c> is the ratio of the indices of the refraction.</para>
    /// </summary>
    public partial class VisualShaderNodeVectorRefract : VisualShaderNode
    {
        private const string nativeName = "VisualShaderNodeVectorRefract";

        public VisualShaderNodeVectorRefract() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeVectorRefract_Ctor(this);
        }

        internal VisualShaderNodeVectorRefract(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
