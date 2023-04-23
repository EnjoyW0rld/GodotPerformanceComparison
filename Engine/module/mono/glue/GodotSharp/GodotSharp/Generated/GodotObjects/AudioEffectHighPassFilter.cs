using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Cuts frequencies lower than the <see cref="Godot.AudioEffectFilter.CutoffHz"/> and allows higher frequencies to pass.</para>
    /// </summary>
    public partial class AudioEffectHighPassFilter : AudioEffectFilter
    {
        private const string nativeName = "AudioEffectHighPassFilter";

        public AudioEffectHighPassFilter() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectHighPassFilter_Ctor(this);
        }

        internal AudioEffectHighPassFilter(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
