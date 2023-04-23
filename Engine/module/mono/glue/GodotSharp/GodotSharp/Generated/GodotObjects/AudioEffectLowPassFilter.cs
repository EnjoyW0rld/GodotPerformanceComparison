using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Cuts frequencies higher than the <see cref="Godot.AudioEffectFilter.CutoffHz"/> and allows lower frequencies to pass.</para>
    /// </summary>
    public partial class AudioEffectLowPassFilter : AudioEffectFilter
    {
        private const string nativeName = "AudioEffectLowPassFilter";

        public AudioEffectLowPassFilter() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectLowPassFilter_Ctor(this);
        }

        internal AudioEffectLowPassFilter(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
