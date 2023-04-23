using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Translates to <c>faceforward(N, I, Nref)</c> in the shader language. The function has three vector parameters: <c>N</c>, the vector to orient, <c>I</c>, the incident vector, and <c>Nref</c>, the reference vector. If the dot product of <c>I</c> and <c>Nref</c> is smaller than zero the return value is <c>N</c>. Otherwise, <c>-N</c> is returned.</para>
    /// </summary>
    public partial class VisualShaderNodeFaceForward : VisualShaderNode
    {
        private const string nativeName = "VisualShaderNodeFaceForward";

        public VisualShaderNodeFaceForward() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeFaceForward_Ctor(this);
        }

        internal VisualShaderNodeFaceForward(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
