using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This visual shader node is present in all shader graphs in form of "Output" block with multiple output value ports.</para>
    /// </summary>
    public abstract partial class VisualShaderNodeOutput : VisualShaderNode
    {
        private const string nativeName = "VisualShaderNodeOutput";

        internal VisualShaderNodeOutput() {}

        internal VisualShaderNodeOutput(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
