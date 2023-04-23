using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Returns an associated scalar if the provided boolean value is <c>true</c> or <c>false</c>.</para>
    /// </summary>
    public partial class VisualShaderNodeScalarSwitch : VisualShaderNodeSwitch
    {
        private const string nativeName = "VisualShaderNodeScalarSwitch";

        public VisualShaderNodeScalarSwitch() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeScalarSwitch_Ctor(this);
        }

        internal VisualShaderNodeScalarSwitch(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
