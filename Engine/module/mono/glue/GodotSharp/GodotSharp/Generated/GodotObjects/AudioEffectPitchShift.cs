using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Allows modulation of pitch independently of tempo. All frequencies can be increased/decreased with minimal effect on transients.</para>
    /// </summary>
    public partial class AudioEffectPitchShift : AudioEffect
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
            /// <para>Represents the size of the <see cref="Godot.AudioEffectPitchShift.FFT_Size"/> enum.</para>
            /// </summary>
            Max = 5
        }

        /// <summary>
        /// <para>The pitch scale to use. <c>1.0</c> is the default pitch and plays sounds unaltered. <see cref="Godot.AudioEffectPitchShift.PitchScale"/> can range from <c>0.0</c> (infinitely low pitch, inaudible) to <c>16</c> (16 times higher than the initial pitch).</para>
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
        /// <para>The oversampling factor to use. Higher values result in better quality, but are more demanding on the CPU and may cause audio cracking if the CPU can't keep up.</para>
        /// </summary>
        public int Oversampling
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOversampling();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOversampling(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The size of the <a href="https://en.wikipedia.org/wiki/Fast_Fourier_transform">Fast Fourier transform</a> buffer. Higher values smooth out the effect over time, but have greater latency. The effects of this higher latency are especially noticeable on sounds that have sudden amplitude changes.</para>
        /// </summary>
        public AudioEffectPitchShift.FFT_Size FftSize
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

        private const string nativeName = "AudioEffectPitchShift";

        public AudioEffectPitchShift() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectPitchShift_Ctor(this);
        }

        internal AudioEffectPitchShift(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pitch_scale");

        [GodotMethod("set_pitch_scale")]
        [Obsolete("SetPitchScale is deprecated. Use the PitchScale property instead.")]
        public void SetPitchScale(float rate)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), rate);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pitch_scale");

        [GodotMethod("get_pitch_scale")]
        [Obsolete("GetPitchScale is deprecated. Use the PitchScale property instead.")]
        public float GetPitchScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_oversampling");

        [GodotMethod("set_oversampling")]
        [Obsolete("SetOversampling is deprecated. Use the Oversampling property instead.")]
        public void SetOversampling(int amount)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_oversampling");

        [GodotMethod("get_oversampling")]
        [Obsolete("GetOversampling is deprecated. Use the Oversampling property instead.")]
        public int GetOversampling()
        {
            return NativeCalls.godot_icall_0_5(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fft_size");

        [GodotMethod("set_fft_size")]
        [Obsolete("SetFftSize is deprecated. Use the FftSize property instead.")]
        public void SetFftSize(AudioEffectPitchShift.FFT_Size size)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), (int)size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fft_size");

        [GodotMethod("get_fft_size")]
        [Obsolete("GetFftSize is deprecated. Use the FftSize property instead.")]
        public AudioEffectPitchShift.FFT_Size GetFftSize()
        {
            return (AudioEffectPitchShift.FFT_Size)NativeCalls.godot_icall_0_168(method_bind_5, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
