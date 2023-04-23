using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Constrains a value to lie between <c>min</c> and <c>max</c> values. The operation is performed on each component of the vector individually.</para>
    /// </summary>
    public partial class VisualShaderNodeVectorClamp : VisualShaderNode
    {
        private const string nativeName = "VisualShaderNodeVectorClamp";

        public VisualShaderNodeVectorClamp() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeVectorClamp_Ctor(this);
        }

        internal VisualShaderNodeVectorClamp(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
