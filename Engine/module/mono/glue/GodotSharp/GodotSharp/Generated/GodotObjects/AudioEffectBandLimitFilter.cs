using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Limits the frequencies in a range around the <see cref="Godot.AudioEffectFilter.CutoffHz"/> and allows frequencies outside of this range to pass.</para>
    /// </summary>
    public partial class AudioEffectBandLimitFilter : AudioEffectFilter
    {
        private const string nativeName = "AudioEffectBandLimitFilter";

        public AudioEffectBandLimitFilter() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectBandLimitFilter_Ctor(this);
        }

        internal AudioEffectBandLimitFilter(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
