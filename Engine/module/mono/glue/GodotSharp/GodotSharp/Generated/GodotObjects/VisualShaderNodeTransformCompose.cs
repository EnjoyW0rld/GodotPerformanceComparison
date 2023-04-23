using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Creates a 4x4 transform matrix using four vectors of type <c>vec3</c>. Each vector is one row in the matrix and the last column is a <c>vec4(0, 0, 0, 1)</c>.</para>
    /// </summary>
    public partial class VisualShaderNodeTransformCompose : VisualShaderNode
    {
        private const string nativeName = "VisualShaderNodeTransformCompose";

        public VisualShaderNodeTransformCompose() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeTransformCompose_Ctor(this);
        }

        internal VisualShaderNodeTransformCompose(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
