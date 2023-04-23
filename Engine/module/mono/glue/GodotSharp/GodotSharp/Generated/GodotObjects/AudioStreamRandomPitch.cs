using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Randomly varies pitch on each start.</para>
    /// </summary>
    public partial class AudioStreamRandomPitch : AudioStream
    {
        /// <summary>
        /// <para>The current <see cref="Godot.AudioStream"/>.</para>
        /// </summary>
        public AudioStream AudioStream
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAudioStream();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAudioStream(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The intensity of random pitch variation.</para>
        /// </summary>
        public float RandomPitch
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRandomPitch();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRandomPitch(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AudioStreamRandomPitch";

        public AudioStreamRandomPitch() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioStreamRandomPitch_Ctor(this);
        }

        internal AudioStreamRandomPitch(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_audio_stream");

        [GodotMethod("set_audio_stream")]
        [Obsolete("SetAudioStream is deprecated. Use the AudioStream property instead.")]
        public void SetAudioStream(AudioStream stream)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(stream));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_audio_stream");

        [GodotMethod("get_audio_stream")]
        [Obsolete("GetAudioStream is deprecated. Use the AudioStream property instead.")]
        public AudioStream GetAudioStream()
        {
            return NativeCalls.godot_icall_0_184(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_random_pitch");

        [GodotMethod("set_random_pitch")]
        [Obsolete("SetRandomPitch is deprecated. Use the RandomPitch property instead.")]
        public void SetRandomPitch(float scale)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_random_pitch");

        [GodotMethod("get_random_pitch")]
        [Obsolete("GetRandomPitch is deprecated. Use the RandomPitch property instead.")]
        public float GetRandomPitch()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
