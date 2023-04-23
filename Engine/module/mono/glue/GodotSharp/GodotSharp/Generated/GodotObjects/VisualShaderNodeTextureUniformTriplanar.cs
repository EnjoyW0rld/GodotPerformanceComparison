using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Performs a lookup operation on the texture provided as a uniform for the shader, with support for triplanar mapping.</para>
    /// </summary>
    public partial class VisualShaderNodeTextureUniformTriplanar : VisualShaderNodeTextureUniform
    {
        private const string nativeName = "VisualShaderNodeTextureUniformTriplanar";

        public VisualShaderNodeTextureUniformTriplanar() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeTextureUniformTriplanar_Ctor(this);
        }

        internal VisualShaderNodeTextureUniformTriplanar(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
