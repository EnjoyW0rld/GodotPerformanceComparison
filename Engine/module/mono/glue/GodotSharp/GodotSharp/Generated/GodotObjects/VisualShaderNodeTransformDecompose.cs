using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Takes a 4x4 transform matrix and decomposes it into four <c>vec3</c> values, one from each row of the matrix.</para>
    /// </summary>
    public partial class VisualShaderNodeTransformDecompose : VisualShaderNode
    {
        private const string nativeName = "VisualShaderNodeTransformDecompose";

        public VisualShaderNodeTransformDecompose() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeTransformDecompose_Ctor(this);
        }

        internal VisualShaderNodeTransformDecompose(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
