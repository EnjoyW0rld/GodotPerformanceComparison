using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Plays audio that dampens with distance from a given position.</para>
    /// <para>By default, audio is heard from the screen center. This can be changed by adding a <see cref="Godot.Listener2D"/> node to the scene and enabling it by calling <see cref="Godot.Listener2D.MakeCurrent"/> on it.</para>
    /// <para>See also <see cref="Godot.AudioStreamPlayer"/> to play a sound non-positionally.</para>
    /// <para>Note: Hiding an <see cref="Godot.AudioStreamPlayer2D"/> node does not disable its audio output. To temporarily disable an <see cref="Godot.AudioStreamPlayer2D"/>'s audio output, set <see cref="Godot.AudioStreamPlayer2D.VolumeDb"/> to a very low value like <c>-100</c> (which isn't audible to human hearing).</para>
    /// </summary>
    public partial class AudioStreamPlayer2D : Node2D
    {
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
        /// <para>Base volume without dampening.</para>
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
        /// <para>Maximum distance from which audio is still hearable.</para>
        /// </summary>
        public float MaxDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaxDistance();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaxDistance(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Dampens audio over distance with this as an exponent.</para>
        /// </summary>
        public float Attenuation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAttenuation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAttenuation(value);
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

        /// <summary>
        /// <para>Determines which <see cref="Godot.Area2D"/> layers affect the sound for reverb and audio bus effects. Areas can be used to redirect <see cref="Godot.AudioStream"/>s so that they play in a certain audio bus. An example of how you might use this is making a "water" area so that sounds played in the water are redirected through an audio bus to make them sound like they are being played underwater.</para>
        /// </summary>
        public uint AreaMask
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAreaMask();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAreaMask(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AudioStreamPlayer2D";

        public AudioStreamPlayer2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioStreamPlayer2D_Ctor(this);
        }

        internal AudioStreamPlayer2D(bool memoryOwn) : base(memoryOwn) {}

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
        /// <para>Plays the audio from the given position <c>from_position</c>, in seconds.</para>
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
        /// <para>Returns the position in the <see cref="Godot.AudioStream"/>.</para>
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
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_playing");

        [Obsolete("_SetPlaying is deprecated. Use the Playing property instead.")]
        internal void _SetPlaying(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_15, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max_distance");

        [GodotMethod("set_max_distance")]
        [Obsolete("SetMaxDistance is deprecated. Use the MaxDistance property instead.")]
        public void SetMaxDistance(float pixels)
        {
            NativeCalls.godot_icall_1_15(method_bind_16, Object.GetPtr(this), pixels);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max_distance");

        [GodotMethod("get_max_distance")]
        [Obsolete("GetMaxDistance is deprecated. Use the MaxDistance property instead.")]
        public float GetMaxDistance()
        {
            return NativeCalls.godot_icall_0_14(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_attenuation");

        [GodotMethod("set_attenuation")]
        [Obsolete("SetAttenuation is deprecated. Use the Attenuation property instead.")]
        public void SetAttenuation(float curve)
        {
            NativeCalls.godot_icall_1_15(method_bind_18, Object.GetPtr(this), curve);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_attenuation");

        [GodotMethod("get_attenuation")]
        [Obsolete("GetAttenuation is deprecated. Use the Attenuation property instead.")]
        public float GetAttenuation()
        {
            return NativeCalls.godot_icall_0_14(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_area_mask");

        [GodotMethod("set_area_mask")]
        [Obsolete("SetAreaMask is deprecated. Use the AreaMask property instead.")]
        public void SetAreaMask(uint mask)
        {
            NativeCalls.godot_icall_1_187(method_bind_20, Object.GetPtr(this), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_area_mask");

        [GodotMethod("get_area_mask")]
        [Obsolete("GetAreaMask is deprecated. Use the AreaMask property instead.")]
        public uint GetAreaMask()
        {
            return NativeCalls.godot_icall_0_188(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_stream_paused");

        [GodotMethod("set_stream_paused")]
        [Obsolete("SetStreamPaused is deprecated. Use the StreamPaused property instead.")]
        public void SetStreamPaused(bool pause)
        {
            NativeCalls.godot_icall_1_16(method_bind_22, Object.GetPtr(this), pause);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stream_paused");

        [GodotMethod("get_stream_paused")]
        [Obsolete("GetStreamPaused is deprecated. Use the StreamPaused property instead.")]
        public bool GetStreamPaused()
        {
            return NativeCalls.godot_icall_0_7(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stream_playback");

        /// <summary>
        /// <para>Returns the <see cref="Godot.AudioStreamPlayback"/> object associated with this <see cref="Godot.AudioStreamPlayer2D"/>.</para>
        /// </summary>
        [GodotMethod("get_stream_playback")]
        public AudioStreamPlayback GetStreamPlayback()
        {
            return NativeCalls.godot_icall_0_186(method_bind_24, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
