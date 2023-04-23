using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Translated to <c>uniform samplerCube</c> in the shader language. The output value can be used as port for <see cref="Godot.VisualShaderNodeCubeMap"/>.</para>
    /// </summary>
    public partial class VisualShaderNodeCubeMapUniform : VisualShaderNodeTextureUniform
    {
        private const string nativeName = "VisualShaderNodeCubeMapUniform";

        public VisualShaderNodeCubeMapUniform() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeCubeMapUniform_Ctor(this);
        }

        internal VisualShaderNodeCubeMapUniform(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
