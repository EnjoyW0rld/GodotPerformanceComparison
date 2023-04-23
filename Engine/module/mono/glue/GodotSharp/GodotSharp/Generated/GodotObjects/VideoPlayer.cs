using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Control node for playing video streams using <see cref="Godot.VideoStream"/> resources.</para>
    /// <para>Supported video formats are <a href="https://www.webmproject.org/">WebM</a> (<c>.webm</c>, <see cref="Godot.VideoStreamWebm"/>), <a href="https://www.theora.org/">Ogg Theora</a> (<c>.ogv</c>, <see cref="Godot.VideoStreamTheora"/>), and any format exposed via a GDNative plugin using <see cref="Godot.VideoStreamGDNative"/>.</para>
    /// <para>Note: Due to a bug, VideoPlayer does not support localization remapping yet.</para>
    /// <para>Warning: On HTML5, video playback will perform poorly due to missing architecture-specific assembly optimizations, especially for VP8/VP9.</para>
    /// </summary>
    public partial class VideoPlayer : Control
    {
        /// <summary>
        /// <para>The embedded audio track to play.</para>
        /// </summary>
        public int AudioTrack
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAudioTrack();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAudioTrack(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The assigned video stream. See description for supported formats.</para>
        /// </summary>
        public VideoStream Stream
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
        /// <para>Audio volume in dB.</para>
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
        /// <para>Audio volume as a linear value.</para>
        /// </summary>
        public float Volume
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVolume();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVolume(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, playback starts when the scene loads.</para>
        /// </summary>
        public bool Autoplay
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return HasAutoplay();
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
        /// <para>If <c>true</c>, the video is paused.</para>
        /// </summary>
        public bool Paused
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsPaused();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPaused(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the video scales to the control size. Otherwise, the control minimum size will be automatically adjusted to match the video stream's dimensions.</para>
        /// </summary>
        public bool Expand
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return HasExpand();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExpand(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Amount of time in milliseconds to store in buffer while playing.</para>
        /// </summary>
        public int BufferingMsec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBufferingMsec();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBufferingMsec(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The current position of the stream, in seconds.</para>
        /// <para>Note: Changing this value won't have any effect as seeking is not implemented yet, except in video formats implemented by a GDNative add-on.</para>
        /// </summary>
        public float StreamPosition
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetStreamPosition();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetStreamPosition(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Audio bus to use for sound playback.</para>
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

        private const string nativeName = "VideoPlayer";

        public VideoPlayer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VideoPlayer_Ctor(this);
        }

        internal VideoPlayer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_stream");

        [GodotMethod("set_stream")]
        [Obsolete("SetStream is deprecated. Use the Stream property instead.")]
        public void SetStream(VideoStream stream)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(stream));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stream");

        [GodotMethod("get_stream")]
        [Obsolete("GetStream is deprecated. Use the Stream property instead.")]
        public VideoStream GetStream()
        {
            return NativeCalls.godot_icall_0_1008(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "play");

        /// <summary>
        /// <para>Starts the video playback from the beginning. If the video is paused, this will not unpause the video.</para>
        /// </summary>
        [GodotMethod("play")]
        public void Play()
        {
            NativeCalls.godot_icall_0_3(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "stop");

        /// <summary>
        /// <para>Stops the video playback and sets the stream position to 0.</para>
        /// <para>Note: Although the stream position will be set to 0, the first frame of the video stream won't become the current frame.</para>
        /// </summary>
        [GodotMethod("stop")]
        public void Stop()
        {
            NativeCalls.godot_icall_0_3(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_playing");

        /// <summary>
        /// <para>Returns <c>true</c> if the video is playing.</para>
        /// <para>Note: The video is still considered playing if paused during playback.</para>
        /// </summary>
        [GodotMethod("is_playing")]
        public bool IsPlaying()
        {
            return NativeCalls.godot_icall_0_7(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_paused");

        [GodotMethod("set_paused")]
        [Obsolete("SetPaused is deprecated. Use the Paused property instead.")]
        public void SetPaused(bool paused)
        {
            NativeCalls.godot_icall_1_16(method_bind_5, Object.GetPtr(this), paused);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_paused");

        [GodotMethod("is_paused")]
        [Obsolete("IsPaused is deprecated. Use the Paused property instead.")]
        public bool IsPaused()
        {
            return NativeCalls.godot_icall_0_7(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_volume");

        [GodotMethod("set_volume")]
        [Obsolete("SetVolume is deprecated. Use the Volume property instead.")]
        public void SetVolume(float volume)
        {
            NativeCalls.godot_icall_1_15(method_bind_7, Object.GetPtr(this), volume);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_volume");

        [GodotMethod("get_volume")]
        [Obsolete("GetVolume is deprecated. Use the Volume property instead.")]
        public float GetVolume()
        {
            return NativeCalls.godot_icall_0_14(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_volume_db");

        [GodotMethod("set_volume_db")]
        [Obsolete("SetVolumeDb is deprecated. Use the VolumeDb property instead.")]
        public void SetVolumeDb(float db)
        {
            NativeCalls.godot_icall_1_15(method_bind_9, Object.GetPtr(this), db);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_volume_db");

        [GodotMethod("get_volume_db")]
        [Obsolete("GetVolumeDb is deprecated. Use the VolumeDb property instead.")]
        public float GetVolumeDb()
        {
            return NativeCalls.godot_icall_0_14(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_audio_track");

        [GodotMethod("set_audio_track")]
        [Obsolete("SetAudioTrack is deprecated. Use the AudioTrack property instead.")]
        public void SetAudioTrack(int track)
        {
            NativeCalls.godot_icall_1_4(method_bind_11, Object.GetPtr(this), track);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_audio_track");

        [GodotMethod("get_audio_track")]
        [Obsolete("GetAudioTrack is deprecated. Use the AudioTrack property instead.")]
        public int GetAudioTrack()
        {
            return NativeCalls.godot_icall_0_5(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stream_name");

        /// <summary>
        /// <para>Returns the video stream's name, or <c>"&lt;No Stream&gt;"</c> if no video stream is assigned.</para>
        /// </summary>
        [GodotMethod("get_stream_name")]
        public string GetStreamName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_stream_position");

        [GodotMethod("set_stream_position")]
        [Obsolete("SetStreamPosition is deprecated. Use the StreamPosition property instead.")]
        public void SetStreamPosition(float position)
        {
            NativeCalls.godot_icall_1_15(method_bind_14, Object.GetPtr(this), position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stream_position");

        [GodotMethod("get_stream_position")]
        [Obsolete("GetStreamPosition is deprecated. Use the StreamPosition property instead.")]
        public float GetStreamPosition()
        {
            return NativeCalls.godot_icall_0_14(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_autoplay");

        [GodotMethod("set_autoplay")]
        [Obsolete("SetAutoplay is deprecated. Use the Autoplay property instead.")]
        public void SetAutoplay(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_16, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_autoplay");

        [GodotMethod("has_autoplay")]
        [Obsolete("HasAutoplay is deprecated. Use the Autoplay property instead.")]
        public bool HasAutoplay()
        {
            return NativeCalls.godot_icall_0_7(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_expand");

        [GodotMethod("set_expand")]
        [Obsolete("SetExpand is deprecated. Use the Expand property instead.")]
        public void SetExpand(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_18, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_expand");

        [GodotMethod("has_expand")]
        [Obsolete("HasExpand is deprecated. Use the Expand property instead.")]
        public bool HasExpand()
        {
            return NativeCalls.godot_icall_0_7(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_buffering_msec");

        [GodotMethod("set_buffering_msec")]
        [Obsolete("SetBufferingMsec is deprecated. Use the BufferingMsec property instead.")]
        public void SetBufferingMsec(int msec)
        {
            NativeCalls.godot_icall_1_4(method_bind_20, Object.GetPtr(this), msec);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_buffering_msec");

        [GodotMethod("get_buffering_msec")]
        [Obsolete("GetBufferingMsec is deprecated. Use the BufferingMsec property instead.")]
        public int GetBufferingMsec()
        {
            return NativeCalls.godot_icall_0_5(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bus");

        [GodotMethod("set_bus")]
        [Obsolete("SetBus is deprecated. Use the Bus property instead.")]
        public void SetBus(string bus)
        {
            NativeCalls.godot_icall_1_54(method_bind_22, Object.GetPtr(this), bus);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bus");

        [GodotMethod("get_bus")]
        [Obsolete("GetBus is deprecated. Use the Bus property instead.")]
        public string GetBus()
        {
            return NativeCalls.godot_icall_0_6(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_video_texture");

        /// <summary>
        /// <para>Returns the current frame as a <see cref="Godot.Texture"/>.</para>
        /// </summary>
        [GodotMethod("get_video_texture")]
        public Texture GetVideoTexture()
        {
            return NativeCalls.godot_icall_0_161(method_bind_24, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
