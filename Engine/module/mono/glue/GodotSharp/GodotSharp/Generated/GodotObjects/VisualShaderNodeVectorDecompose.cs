using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Takes a <c>vec3</c> and decomposes it into three scalar values that can be used as separate inputs.</para>
    /// </summary>
    public partial class VisualShaderNodeVectorDecompose : VisualShaderNode
    {
        private const string nativeName = "VisualShaderNodeVectorDecompose";

        public VisualShaderNodeVectorDecompose() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeVectorDecompose_Ctor(this);
        }

        internal VisualShaderNodeVectorDecompose(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
