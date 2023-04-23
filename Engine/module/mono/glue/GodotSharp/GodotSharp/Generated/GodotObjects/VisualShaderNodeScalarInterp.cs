using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Translates to <c>mix(a, b, weight)</c> in the shader language.</para>
    /// </summary>
    public partial class VisualShaderNodeScalarInterp : VisualShaderNode
    {
        private const string nativeName = "VisualShaderNodeScalarInterp";

        public VisualShaderNodeScalarInterp() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeScalarInterp_Ctor(this);
        }

        internal VisualShaderNodeScalarInterp(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
