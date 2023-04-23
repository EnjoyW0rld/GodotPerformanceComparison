using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Calculates distance from point represented by vector <c>p0</c> to vector <c>p1</c>.</para>
    /// <para>Translated to <c>distance(p0, p1)</c> in the shader language.</para>
    /// </summary>
    public partial class VisualShaderNodeVectorDistance : VisualShaderNode
    {
        private const string nativeName = "VisualShaderNodeVectorDistance";

        public VisualShaderNodeVectorDistance() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeVectorDistance_Ctor(this);
        }

        internal VisualShaderNodeVectorDistance(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
