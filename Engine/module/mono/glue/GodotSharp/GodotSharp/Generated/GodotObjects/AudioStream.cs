using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Base class for audio streams. Audio streams are used for sound effects and music playback, and support WAV (via <see cref="Godot.AudioStreamSample"/>) and OGG (via <see cref="Godot.AudioStreamOGGVorbis"/>) file formats.</para>
    /// </summary>
    public abstract partial class AudioStream : Resource
    {
        private const string nativeName = "AudioStream";

        internal AudioStream() {}

        internal AudioStream(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_length");

        /// <summary>
        /// <para>Returns the length of the audio stream in seconds.</para>
        /// </summary>
        [GodotMethod("get_length")]
        public float GetLength()
        {
            return NativeCalls.godot_icall_0_14(method_bind_0, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
