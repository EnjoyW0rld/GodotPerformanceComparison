using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Frequency bands:</para>
    /// <para>Band 1: 22 Hz</para>
    /// <para>Band 2: 32 Hz</para>
    /// <para>Band 3: 44 Hz</para>
    /// <para>Band 4: 63 Hz</para>
    /// <para>Band 5: 90 Hz</para>
    /// <para>Band 6: 125 Hz</para>
    /// <para>Band 7: 175 Hz</para>
    /// <para>Band 8: 250 Hz</para>
    /// <para>Band 9: 350 Hz</para>
    /// <para>Band 10: 500 Hz</para>
    /// <para>Band 11: 700 Hz</para>
    /// <para>Band 12: 1000 Hz</para>
    /// <para>Band 13: 1400 Hz</para>
    /// <para>Band 14: 2000 Hz</para>
    /// <para>Band 15: 2800 Hz</para>
    /// <para>Band 16: 4000 Hz</para>
    /// <para>Band 17: 5600 Hz</para>
    /// <para>Band 18: 8000 Hz</para>
    /// <para>Band 19: 11000 Hz</para>
    /// <para>Band 20: 16000 Hz</para>
    /// <para>Band 21: 22000 Hz</para>
    /// <para>See also <see cref="Godot.AudioEffectEQ"/>, <see cref="Godot.AudioEffectEQ6"/>, <see cref="Godot.AudioEffectEQ10"/>.</para>
    /// </summary>
    public partial class AudioEffectEQ21 : AudioEffectEQ
    {
        private const string nativeName = "AudioEffectEQ21";

        public AudioEffectEQ21() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectEQ21_Ctor(this);
        }

        internal AudioEffectEQ21(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
