using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class AudioEffectLowShelfFilter : AudioEffectFilter
    {
        private const string nativeName = "AudioEffectLowShelfFilter";

        public AudioEffectLowShelfFilter() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectLowShelfFilter_Ctor(this);
        }

        internal AudioEffectLowShelfFilter(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
