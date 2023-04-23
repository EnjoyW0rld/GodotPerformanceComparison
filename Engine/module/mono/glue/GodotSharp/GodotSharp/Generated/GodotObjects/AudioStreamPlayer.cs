using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Plays an audio stream non-positionally.</para>
    /// <para>To play audio positionally, use <see cref="Godot.AudioStreamPlayer2D"/> or <see cref="Godot.AudioStreamPlayer3D"/> instead of <see cref="Godot.AudioStreamPlayer"/>.</para>
    /// </summary>
    public partial class AudioStreamPlayer : Node
    {
        public enum MixTargetEnum
        {
            /// <summary>
            /// <para>The audio will be played only on the first channel.</para>
            /// </summary>
            Stereo = 0,
            /// <summary>
            /// <para>The audio will be played on all surround channels.</para>
            /// </summary>
            Surround = 1,
            /// <summary>
            /// <para>The audio will be played on the second channel, which is usually the center.</para>
            /// </summary>
            Center = 2
        }

        /// <summary>
        /// <para>The <see cref="Godot.AudioStream"/> object to be played.</para>
        /// </summary>
        public AudioStream Stream
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetStream();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetStream(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Volume of sound, in dB.</para>
        /// </summary>
        public float VolumeDb
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVolumeDb();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVolumeDb(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The pitch and the tempo of the audio, as a multiplier of the audio sample's sample rate.</para>
        /// </summary>
        public float PitchScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPitchScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPitchScale(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, audio is playing.</para>
        /// </summary>
        public bool Playing
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsPlaying();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetPlaying(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, audio plays when added to scene tree.</para>
        /// </summary>
        public bool Autoplay
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsAutoplayEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAutoplay(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the playback is paused. You can resume it by setting <c>stream_paused</c> to <c>false</c>.</para>
        /// </summary>
        public bool StreamPaused
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetStreamPaused();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetStreamPaused(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If the audio configuration has more than two speakers, this sets the target channels. See <see cref="Godot.AudioStreamPlayer.MixTargetEnum"/> constants.</para>
        /// </summary>
        public AudioStreamPlayer.MixTargetEnum MixTarget
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMixTarget();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMixTarget(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Bus on which this audio is playing.</para>
        /// <para>Note: When setting this property, keep in mind that no validation is performed to see if the given name matches an existing bus. This is because audio bus layouts might be loaded after this property is set. If this given name can't be resolved at runtime, it will fall back to <c>"Master"</c>.</para>
        /// </summary>
        public string Bus
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBus();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBus(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AudioStreamPlayer";

        public AudioStreamPlayer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioStreamPlayer_Ctor(this);
        }

        internal AudioStreamPlayer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_stream");

        [GodotMethod("set_stream")]
        [Obsolete("SetStream is deprecated. Use the Stream property instead.")]
        public void SetStream(AudioStream stream)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(stream));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stream");

        [GodotMethod("get_stream")]
        [Obsolete("GetStream is deprecated. Use the Stream property instead.")]
        public AudioStream GetStream()
        {
            return NativeCalls.godot_icall_0_184(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_volume_db");

        [GodotMethod("set_volume_db")]
        [Obsolete("SetVolumeDb is deprecated. Use the VolumeDb property instead.")]
        public void SetVolumeDb(float volumeDb)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), volumeDb);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_volume_db");

        [GodotMethod("get_volume_db")]
        [Obsolete("GetVolumeDb is deprecated. Use the VolumeDb property instead.")]
        public float GetVolumeDb()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pitch_scale");

        [GodotMethod("set_pitch_scale")]
        [Obsolete("SetPitchScale is deprecated. Use the PitchScale property instead.")]
        public void SetPitchScale(float pitchScale)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), pitchScale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pitch_scale");

        [GodotMethod("get_pitch_scale")]
        [Obsolete("GetPitchScale is deprecated. Use the PitchScale property instead.")]
        public float GetPitchScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "play");

        /// <summary>
        /// <para>Plays the audio from the given <c>from_position</c>, in seconds.</para>
        /// </summary>
        [GodotMethod("play")]
        public void Play(float fromPosition = 0f)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), fromPosition);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "seek");

        /// <summary>
        /// <para>Sets the position from which audio will be played, in seconds.</para>
        /// </summary>
        [GodotMethod("seek")]
        public void Seek(float toPosition)
        {
            NativeCalls.godot_icall_1_15(method_bind_7, Object.GetPtr(this), toPosition);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "stop");

        /// <summary>
        /// <para>Stops the audio.</para>
        /// </summary>
        [GodotMethod("stop")]
        public void Stop()
        {
            NativeCalls.godot_icall_0_3(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_playing");

        [GodotMethod("is_playing")]
        [Obsolete("IsPlaying is deprecated. Use the Playing property instead.")]
        public bool IsPlaying()
        {
            return NativeCalls.godot_icall_0_7(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_playback_position");

        /// <summary>
        /// <para>Returns the position in the <see cref="Godot.AudioStream"/> in seconds.</para>
        /// </summary>
        [GodotMethod("get_playback_position")]
        public float GetPlaybackPosition()
        {
            return NativeCalls.godot_icall_0_14(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bus");

        [GodotMethod("set_bus")]
        [Obsolete("SetBus is deprecated. Use the Bus property instead.")]
        public void SetBus(string bus)
        {
            NativeCalls.godot_icall_1_54(method_bind_11, Object.GetPtr(this), bus);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bus");

        [GodotMethod("get_bus")]
        [Obsolete("GetBus is deprecated. Use the Bus property instead.")]
        public string GetBus()
        {
            return NativeCalls.godot_icall_0_6(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_autoplay");

        [GodotMethod("set_autoplay")]
        [Obsolete("SetAutoplay is deprecated. Use the Autoplay property instead.")]
        public void SetAutoplay(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_13, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_autoplay_enabled");

        [GodotMethod("is_autoplay_enabled")]
        [Obsolete("IsAutoplayEnabled is deprecated. Use the Autoplay property instead.")]
        public bool IsAutoplayEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mix_target");

        [GodotMethod("set_mix_target")]
        [Obsolete("SetMixTarget is deprecated. Use the MixTarget property instead.")]
        public void SetMixTarget(AudioStreamPlayer.MixTargetEnum mixTarget)
        {
            NativeCalls.godot_icall_1_4(method_bind_15, Object.GetPtr(this), (int)mixTarget);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mix_target");

        [GodotMethod("get_mix_target")]
        [Obsolete("GetMixTarget is deprecated. Use the MixTarget property instead.")]
        public AudioStreamPlayer.MixTargetEnum GetMixTarget()
        {
            return (AudioStreamPlayer.MixTargetEnum)NativeCalls.godot_icall_0_185(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_playing");

        [Obsolete("_SetPlaying is deprecated. Use the Playing property instead.")]
        internal void _SetPlaying(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_17, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_stream_paused");

        [GodotMethod("set_stream_paused")]
        [Obsolete("SetStreamPaused is deprecated. Use the StreamPaused property instead.")]
        public void SetStreamPaused(bool pause)
        {
            NativeCalls.godot_icall_1_16(method_bind_18, Object.GetPtr(this), pause);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stream_paused");

        [GodotMethod("get_stream_paused")]
        [Obsolete("GetStreamPaused is deprecated. Use the StreamPaused property instead.")]
        public bool GetStreamPaused()
        {
            return NativeCalls.godot_icall_0_7(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stream_playback");

        /// <summary>
        /// <para>Returns the <see cref="Godot.AudioStreamPlayback"/> object associated with this <see cref="Godot.AudioStreamPlayer"/>.</para>
        /// </summary>
        [GodotMethod("get_stream_playback")]
        public AudioStreamPlayback GetStreamPlayback()
        {
            return NativeCalls.godot_icall_0_186(method_bind_20, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
