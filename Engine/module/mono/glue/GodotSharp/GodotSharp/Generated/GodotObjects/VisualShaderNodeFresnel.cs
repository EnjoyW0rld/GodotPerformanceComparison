using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Returns falloff based on the dot product of surface normal and view direction of camera (pass associated inputs to it).</para>
    /// </summary>
    public partial class VisualShaderNodeFresnel : VisualShaderNode
    {
        private const string nativeName = "VisualShaderNodeFresnel";

        public VisualShaderNodeFresnel() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeFresnel_Ctor(this);
        }

        internal VisualShaderNodeFresnel(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
