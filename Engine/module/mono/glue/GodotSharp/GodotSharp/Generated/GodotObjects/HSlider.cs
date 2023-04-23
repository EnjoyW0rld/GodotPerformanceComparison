using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Horizontal slider. See <see cref="Godot.Slider"/>. This one goes from left (min) to right (max).</para>
    /// <para>Note: The <c>Range.changed</c> and <c>Range.value_changed</c> signals are part of the <see cref="Godot.Range"/> class which this class inherits from.</para>
    /// </summary>
    public partial class HSlider : Slider
    {
        private const string nativeName = "HSlider";

        public HSlider() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_HSlider_Ctor(this);
        }

        internal HSlider(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
