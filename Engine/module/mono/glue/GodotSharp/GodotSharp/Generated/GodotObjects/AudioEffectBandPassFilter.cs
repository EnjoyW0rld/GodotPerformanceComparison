using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Attenuates the frequencies inside of a range around the <see cref="Godot.AudioEffectFilter.CutoffHz"/> and cuts frequencies outside of this band.</para>
    /// </summary>
    public partial class AudioEffectBandPassFilter : AudioEffectFilter
    {
        private const string nativeName = "AudioEffectBandPassFilter";

        public AudioEffectBandPassFilter() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectBandPassFilter_Ctor(this);
        }

        internal AudioEffectBandPassFilter(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
