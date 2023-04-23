using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Attenuates frequencies in a narrow band around the <see cref="Godot.AudioEffectFilter.CutoffHz"/> and cuts frequencies outside of this range.</para>
    /// </summary>
    public partial class AudioEffectNotchFilter : AudioEffectFilter
    {
        private const string nativeName = "AudioEffectNotchFilter";

        public AudioEffectNotchFilter() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectNotchFilter_Ctor(this);
        }

        internal AudioEffectNotchFilter(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
