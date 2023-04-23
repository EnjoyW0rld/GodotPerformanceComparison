using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Custom Godot Shader Language expression, which is placed on top of the generated shader. You can place various function definitions inside to call later in <see cref="Godot.VisualShaderNodeExpression"/>s (which are injected in the main shader functions). You can also declare varyings, uniforms and global constants.</para>
    /// </summary>
    public partial class VisualShaderNodeGlobalExpression : VisualShaderNodeExpression
    {
        private const string nativeName = "VisualShaderNodeGlobalExpression";

        public VisualShaderNodeGlobalExpression() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeGlobalExpression_Ctor(this);
        }

        internal VisualShaderNodeGlobalExpression(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
