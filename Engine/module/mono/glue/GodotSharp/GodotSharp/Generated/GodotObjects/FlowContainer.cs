using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Arranges child <see cref="Godot.Control"/> nodes vertically or horizontally in a left-to-right or top-to-bottom flow.</para>
    /// <para>A line is filled with <see cref="Godot.Control"/> nodes until no more fit on the same line, similar to text in an autowrapped label.</para>
    /// </summary>
    public abstract partial class FlowContainer : Container
    {
        private const string nativeName = "FlowContainer";

        internal FlowContainer() {}

        internal FlowContainer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_line_count");

        /// <summary>
        /// <para>Returns the current line count.</para>
        /// </summary>
        [GodotMethod("get_line_count")]
        public int GetLineCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_0, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
