using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This audio effect does not affect sound output, but can be used for real-time audio visualizations.</para>
    /// <para>See also <see cref="Godot.AudioStreamGenerator"/> for procedurally generating sounds.</para>
    /// </summary>
    public partial class AudioEffectSpectrumAnalyzer : AudioEffect
    {
        public enum FFT_Size
        {
            /// <summary>
            /// <para>Use a buffer of 256 samples for the Fast Fourier transform. Lowest latency, but least stable over time.</para>
            /// </summary>
            Size256 = 0,
            /// <summary>
            /// <para>Use a buffer of 512 samples for the Fast Fourier transform. Low latency, but less stable over time.</para>
            /// </summary>
            Size512 = 1,
            /// <summary>
            /// <para>Use a buffer of 1024 samples for the Fast Fourier transform. This is a compromise between latency and stability over time.</para>
            /// </summary>
            Size1024 = 2,
            /// <summary>
            /// <para>Use a buffer of 2048 samples for the Fast Fourier transform. High latency, but stable over time.</para>
            /// </summary>
            Size2048 = 3,
            /// <summary>
            /// <para>Use a buffer of 4096 samples for the Fast Fourier transform. Highest latency, but most stable over time.</para>
            /// </summary>
            Size4096 = 4,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.AudioEffectSpectrumAnalyzer.FFT_Size"/> enum.</para>
            /// </summary>
            Max = 5
        }

        /// <summary>
        /// <para>The length of the buffer to keep (in seconds). Higher values keep data around for longer, but require more memory.</para>
        /// </summary>
        public float BufferLength
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBufferLength();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBufferLength(value);
            }
#pragma warning restore CS0618
        }

        public float TapBackPos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTapBackPos();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTapBackPos(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The size of the <a href="https://en.wikipedia.org/wiki/Fast_Fourier_transform">Fast Fourier transform</a> buffer. Higher values smooth out the spectrum analysis over time, but have greater latency. The effects of this higher latency are especially noticeable with sudden amplitude changes.</para>
        /// </summary>
        public AudioEffectSpectrumAnalyzer.FFT_Size FftSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFftSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFftSize(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AudioEffectSpectrumAnalyzer";

        public AudioEffectSpectrumAnalyzer() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectSpectrumAnalyzer_Ctor(this);
        }

        internal AudioEffectSpectrumAnalyzer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_buffer_length");

        [GodotMethod("set_buffer_length")]
        [Obsolete("SetBufferLength is deprecated. Use the BufferLength property instead.")]
        public void SetBufferLength(float seconds)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), seconds);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_buffer_length");

        [GodotMethod("get_buffer_length")]
        [Obsolete("GetBufferLength is deprecated. Use the BufferLength property instead.")]
        public float GetBufferLength()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tap_back_pos");

        [GodotMethod("set_tap_back_pos")]
        [Obsolete("SetTapBackPos is deprecated. Use the TapBackPos property instead.")]
        public void SetTapBackPos(float seconds)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), seconds);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tap_back_pos");

        [GodotMethod("get_tap_back_pos")]
        [Obsolete("GetTapBackPos is deprecated. Use the TapBackPos property instead.")]
        public float GetTapBackPos()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fft_size");

        [GodotMethod("set_fft_size")]
        [Obsolete("SetFftSize is deprecated. Use the FftSize property instead.")]
        public void SetFftSize(AudioEffectSpectrumAnalyzer.FFT_Size size)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), (int)size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fft_size");

        [GodotMethod("get_fft_size")]
        [Obsolete("GetFftSize is deprecated. Use the FftSize property instead.")]
        public AudioEffectSpectrumAnalyzer.FFT_Size GetFftSize()
        {
            return (AudioEffectSpectrumAnalyzer.FFT_Size)NativeCalls.godot_icall_0_171(method_bind_5, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
