using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Can play, loop, pause a scroll through audio. See <see cref="Godot.AudioStream"/> and <see cref="Godot.AudioStreamOGGVorbis"/> for usage.</para>
    /// </summary>
    public abstract partial class AudioStreamPlayback : Reference
    {
        private const string nativeName = "AudioStreamPlayback";

        internal AudioStreamPlayback() {}

        internal AudioStreamPlayback(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
