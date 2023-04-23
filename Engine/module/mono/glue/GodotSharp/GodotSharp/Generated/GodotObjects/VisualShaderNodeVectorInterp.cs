using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Translates to <c>mix(a, b, weight)</c> in the shader language, where <c>weight</c> is a <see cref="Godot.Vector3"/> with weights for each component.</para>
    /// </summary>
    public partial class VisualShaderNodeVectorInterp : VisualShaderNode
    {
        private const string nativeName = "VisualShaderNodeVectorInterp";

        public VisualShaderNodeVectorInterp() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeVectorInterp_Ctor(this);
        }

        internal VisualShaderNodeVectorInterp(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
