using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Frequency bands:</para>
    /// <para>Band 1: 31 Hz</para>
    /// <para>Band 2: 62 Hz</para>
    /// <para>Band 3: 125 Hz</para>
    /// <para>Band 4: 250 Hz</para>
    /// <para>Band 5: 500 Hz</para>
    /// <para>Band 6: 1000 Hz</para>
    /// <para>Band 7: 2000 Hz</para>
    /// <para>Band 8: 4000 Hz</para>
    /// <para>Band 9: 8000 Hz</para>
    /// <para>Band 10: 16000 Hz</para>
    /// <para>See also <see cref="Godot.AudioEffectEQ"/>, <see cref="Godot.AudioEffectEQ6"/>, <see cref="Godot.AudioEffectEQ21"/>.</para>
    /// </summary>
    public partial class AudioEffectEQ10 : AudioEffectEQ
    {
        private const string nativeName = "AudioEffectEQ10";

        public AudioEffectEQ10() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectEQ10_Ctor(this);
        }

        internal AudioEffectEQ10(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
