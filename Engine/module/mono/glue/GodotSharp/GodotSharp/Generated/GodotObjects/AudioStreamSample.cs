using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>AudioStreamSample stores sound samples loaded from WAV files. To play the stored sound, use an <see cref="Godot.AudioStreamPlayer"/> (for non-positional audio) or <see cref="Godot.AudioStreamPlayer2D"/>/<see cref="Godot.AudioStreamPlayer3D"/> (for positional audio). The sound can be looped.</para>
    /// <para>This class can also be used to store dynamically-generated PCM audio data. See also <see cref="Godot.AudioStreamGenerator"/> for procedural audio generation.</para>
    /// </summary>
    public partial class AudioStreamSample : AudioStream
    {
        public enum LoopModeEnum
        {
            /// <summary>
            /// <para>Audio does not loop.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>Audio loops the data between <see cref="Godot.AudioStreamSample.LoopBegin"/> and <see cref="Godot.AudioStreamSample.LoopEnd"/>, playing forward only.</para>
            /// </summary>
            Forward = 1,
            /// <summary>
            /// <para>Audio loops the data between <see cref="Godot.AudioStreamSample.LoopBegin"/> and <see cref="Godot.AudioStreamSample.LoopEnd"/>, playing back and forth.</para>
            /// </summary>
            PingPong = 2,
            /// <summary>
            /// <para>Audio loops the data between <see cref="Godot.AudioStreamSample.LoopBegin"/> and <see cref="Godot.AudioStreamSample.LoopEnd"/>, playing backward only.</para>
            /// </summary>
            Backward = 3
        }

        public enum FormatEnum
        {
            /// <summary>
            /// <para>8-bit audio codec.</para>
            /// </summary>
            Format8Bits = 0,
            /// <summary>
            /// <para>16-bit audio codec.</para>
            /// </summary>
            Format16Bits = 1,
            /// <summary>
            /// <para>Audio is compressed using IMA ADPCM.</para>
            /// </summary>
            ImaAdpcm = 2
        }

        /// <summary>
        /// <para>Contains the audio data in bytes.</para>
        /// <para>Note: This property expects signed PCM8 data. To convert unsigned PCM8 to signed PCM8, subtract 128 from each byte.</para>
        /// </summary>
        public byte[] Data
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetData();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetData(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Audio format. See <see cref="Godot.AudioStreamSample.FormatEnum"/> constants for values.</para>
        /// </summary>
        public AudioStreamSample.FormatEnum Format
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFormat();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFormat(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The loop mode. This information will be imported automatically from the WAV file if present. See <see cref="Godot.AudioStreamSample.LoopModeEnum"/> constants for values.</para>
        /// </summary>
        public AudioStreamSample.LoopModeEnum LoopMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLoopMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLoopMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The loop start point (in number of samples, relative to the beginning of the sample). This information will be imported automatically from the WAV file if present.</para>
        /// </summary>
        public int LoopBegin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLoopBegin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLoopBegin(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The loop end point (in number of samples, relative to the beginning of the sample). This information will be imported automatically from the WAV file if present.</para>
        /// </summary>
        public int LoopEnd
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLoopEnd();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLoopEnd(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The sample rate for mixing this audio. Higher values require more storage space, but result in better quality.</para>
        /// <para>In games, common sample rates in use are <c>11025</c>, <c>16000</c>, <c>22050</c>, <c>32000</c>, <c>44100</c>, and <c>48000</c>.</para>
        /// <para>According to the <a href="https://en.wikipedia.org/wiki/Nyquist%E2%80%93Shannon_sampling_theorem">Nyquist-Shannon sampling theorem</a>, there is no quality difference to human hearing when going past 40,000 Hz (since most humans can only hear up to ~20,000 Hz, often less). If you are using lower-pitched sounds such as voices, lower sample rates such as <c>32000</c> or <c>22050</c> may be usable with no loss in quality.</para>
        /// </summary>
        public int MixRate
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMixRate();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMixRate(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, audio is stereo.</para>
        /// </summary>
        public bool Stereo
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsStereo();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetStereo(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AudioStreamSample";

        public AudioStreamSample() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioStreamSample_Ctor(this);
        }

        internal AudioStreamSample(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_data");

        [GodotMethod("set_data")]
        [Obsolete("SetData is deprecated. Use the Data property instead.")]
        public void SetData(byte[] data)
        {
            NativeCalls.godot_icall_1_183(method_bind_0, Object.GetPtr(this), data);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_data");

        [GodotMethod("get_data")]
        [Obsolete("GetData is deprecated. Use the Data property instead.")]
        public byte[] GetData()
        {
            return NativeCalls.godot_icall_0_2(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_format");

        [GodotMethod("set_format")]
        [Obsolete("SetFormat is deprecated. Use the Format property instead.")]
        public void SetFormat(AudioStreamSample.FormatEnum format)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)format);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_format");

        [GodotMethod("get_format")]
        [Obsolete("GetFormat is deprecated. Use the Format property instead.")]
        public AudioStreamSample.FormatEnum GetFormat()
        {
            return (AudioStreamSample.FormatEnum)NativeCalls.godot_icall_0_169(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_loop_mode");

        [GodotMethod("set_loop_mode")]
        [Obsolete("SetLoopMode is deprecated. Use the LoopMode property instead.")]
        public void SetLoopMode(AudioStreamSample.LoopModeEnum loopMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), (int)loopMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_loop_mode");

        [GodotMethod("get_loop_mode")]
        [Obsolete("GetLoopMode is deprecated. Use the LoopMode property instead.")]
        public AudioStreamSample.LoopModeEnum GetLoopMode()
        {
            return (AudioStreamSample.LoopModeEnum)NativeCalls.godot_icall_0_192(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_loop_begin");

        [GodotMethod("set_loop_begin")]
        [Obsolete("SetLoopBegin is deprecated. Use the LoopBegin property instead.")]
        public void SetLoopBegin(int loopBegin)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), loopBegin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_loop_begin");

        [GodotMethod("get_loop_begin")]
        [Obsolete("GetLoopBegin is deprecated. Use the LoopBegin property instead.")]
        public int GetLoopBegin()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_loop_end");

        [GodotMethod("set_loop_end")]
        [Obsolete("SetLoopEnd is deprecated. Use the LoopEnd property instead.")]
        public void SetLoopEnd(int loopEnd)
        {
            NativeCalls.godot_icall_1_4(method_bind_8, Object.GetPtr(this), loopEnd);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_loop_end");

        [GodotMethod("get_loop_end")]
        [Obsolete("GetLoopEnd is deprecated. Use the LoopEnd property instead.")]
        public int GetLoopEnd()
        {
            return NativeCalls.godot_icall_0_5(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mix_rate");

        [GodotMethod("set_mix_rate")]
        [Obsolete("SetMixRate is deprecated. Use the MixRate property instead.")]
        public void SetMixRate(int mixRate)
        {
            NativeCalls.godot_icall_1_4(method_bind_10, Object.GetPtr(this), mixRate);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mix_rate");

        [GodotMethod("get_mix_rate")]
        [Obsolete("GetMixRate is deprecated. Use the MixRate property instead.")]
        public int GetMixRate()
        {
            return NativeCalls.godot_icall_0_5(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_stereo");

        [GodotMethod("set_stereo")]
        [Obsolete("SetStereo is deprecated. Use the Stereo property instead.")]
        public void SetStereo(bool stereo)
        {
            NativeCalls.godot_icall_1_16(method_bind_12, Object.GetPtr(this), stereo);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_stereo");

        [GodotMethod("is_stereo")]
        [Obsolete("IsStereo is deprecated. Use the Stereo property instead.")]
        public bool IsStereo()
        {
            return NativeCalls.godot_icall_0_7(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "save_to_wav");

        /// <summary>
        /// <para>Saves the AudioStreamSample as a WAV file to <c>path</c>. Samples with IMA ADPCM format can't be saved.</para>
        /// <para>Note: A <c>.wav</c> extension is automatically appended to <c>path</c> if it is missing.</para>
        /// </summary>
        [GodotMethod("save_to_wav")]
        public Error SaveToWav(string path)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_14, Object.GetPtr(this), path);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
