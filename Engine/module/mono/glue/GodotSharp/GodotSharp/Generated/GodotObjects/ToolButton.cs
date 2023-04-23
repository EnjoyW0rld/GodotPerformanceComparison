using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This is a helper class to generate a flat <see cref="Godot.Button"/> (see <see cref="Godot.Button.Flat"/>), creating a <see cref="Godot.ToolButton"/> is equivalent to:</para>
    /// <para><code>
    /// var btn = Button.new()
    /// btn.flat = true
    /// </code></para>
    /// </summary>
    public partial class ToolButton : Button
    {
        private const string nativeName = "ToolButton";

        public ToolButton() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ToolButton_Ctor(this);
        }

        internal ToolButton(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
