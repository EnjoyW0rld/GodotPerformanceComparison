using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Translates to <c>determinant(x)</c> in the shader language.</para>
    /// </summary>
    public partial class VisualShaderNodeDeterminant : VisualShaderNode
    {
        private const string nativeName = "VisualShaderNodeDeterminant";

        public VisualShaderNodeDeterminant() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeDeterminant_Ctor(this);
        }

        internal VisualShaderNodeDeterminant(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
