using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Frequency bands:</para>
    /// <para>Band 1: 32 Hz</para>
    /// <para>Band 2: 100 Hz</para>
    /// <para>Band 3: 320 Hz</para>
    /// <para>Band 4: 1000 Hz</para>
    /// <para>Band 5: 3200 Hz</para>
    /// <para>Band 6: 10000 Hz</para>
    /// <para>See also <see cref="Godot.AudioEffectEQ"/>, <see cref="Godot.AudioEffectEQ10"/>, <see cref="Godot.AudioEffectEQ21"/>.</para>
    /// </summary>
    public partial class AudioEffectEQ6 : AudioEffectEQ
    {
        private const string nativeName = "AudioEffectEQ6";

        public AudioEffectEQ6() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectEQ6_Ctor(this);
        }

        internal AudioEffectEQ6(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
