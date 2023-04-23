using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Translates to <c>dot(a, b)</c> in the shader language.</para>
    /// </summary>
    public partial class VisualShaderNodeDotProduct : VisualShaderNode
    {
        private const string nativeName = "VisualShaderNodeDotProduct";

        public VisualShaderNodeDotProduct() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeDotProduct_Ctor(this);
        }

        internal VisualShaderNodeDotProduct(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
