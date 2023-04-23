using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Stores position, muting, solo, bypass, effects, effect position, volume, and the connections between buses. See <see cref="Godot.AudioServer"/> for usage.</para>
    /// </summary>
    public partial class AudioBusLayout : Resource
    {
        private const string nativeName = "AudioBusLayout";

        public AudioBusLayout() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioBusLayout_Ctor(this);
        }

        internal AudioBusLayout(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
