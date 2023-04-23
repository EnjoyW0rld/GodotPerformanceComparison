using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Adds a top, left, bottom, and right margin to all <see cref="Godot.Control"/> nodes that are direct children of the container. To control the <see cref="Godot.MarginContainer"/>'s margin, use the <c>margin_*</c> theme properties listed below.</para>
    /// <para>Note: Be careful, <see cref="Godot.Control"/> margin values are different than the constant margin values. If you want to change the custom margin values of the <see cref="Godot.MarginContainer"/> by code, you should use the following examples:</para>
    /// <para><code>
    /// # This code sample assumes the current script is extending MarginContainer.
    /// var margin_value = 100
    /// add_constant_override("margin_top", margin_value)
    /// add_constant_override("margin_left", margin_value)
    /// add_constant_override("margin_bottom", margin_value)
    /// add_constant_override("margin_right", margin_value)
    /// </code></para>
    /// </summary>
    public partial class MarginContainer : Container
    {
        private const string nativeName = "MarginContainer";

        public MarginContainer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_MarginContainer_Ctor(this);
        }

        internal MarginContainer(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
