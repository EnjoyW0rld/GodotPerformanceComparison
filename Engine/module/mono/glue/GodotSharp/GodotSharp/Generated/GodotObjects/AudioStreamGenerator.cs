using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This audio stream does not play back sounds, but expects a script to generate audio data for it instead. See also <see cref="Godot.AudioStreamGeneratorPlayback"/>.</para>
    /// <para>See also <see cref="Godot.AudioEffectSpectrumAnalyzer"/> for performing real-time audio spectrum analysis.</para>
    /// <para>Note: Due to performance constraints, this class is best used from C# or from a compiled language via GDNative. If you still want to use this class from GDScript, consider using a lower <see cref="Godot.AudioStreamGenerator.MixRate"/> such as 11,025 Hz or 22,050 Hz.</para>
    /// </summary>
    public partial class AudioStreamGenerator : AudioStream
    {
        /// <summary>
        /// <para>The sample rate to use (in Hz). Higher values are more demanding for the CPU to generate, but result in better quality.</para>
        /// <para>In games, common sample rates in use are <c>11025</c>, <c>16000</c>, <c>22050</c>, <c>32000</c>, <c>44100</c>, and <c>48000</c>.</para>
        /// <para>According to the <a href="https://en.wikipedia.org/wiki/Nyquist%E2%80%93Shannon_sampling_theorem">Nyquist-Shannon sampling theorem</a>, there is no quality difference to human hearing when going past 40,000 Hz (since most humans can only hear up to ~20,000 Hz, often less). If you are generating lower-pitched sounds such as voices, lower sample rates such as <c>32000</c> or <c>22050</c> may be usable with no loss in quality.</para>
        /// </summary>
        public float MixRate
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
        /// <para>The length of the buffer to generate (in seconds). Lower values result in less latency, but require the script to generate audio data faster, resulting in increased CPU usage and more risk for audio cracking if the CPU can't keep up.</para>
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

        private const string nativeName = "AudioStreamGenerator";

        public AudioStreamGenerator() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioStreamGenerator_Ctor(this);
        }

        internal AudioStreamGenerator(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mix_rate");

        [GodotMethod("set_mix_rate")]
        [Obsolete("SetMixRate is deprecated. Use the MixRate property instead.")]
        public void SetMixRate(float hz)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), hz);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mix_rate");

        [GodotMethod("get_mix_rate")]
        [Obsolete("GetMixRate is deprecated. Use the MixRate property instead.")]
        public float GetMixRate()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_buffer_length");

        [GodotMethod("set_buffer_length")]
        [Obsolete("SetBufferLength is deprecated. Use the BufferLength property instead.")]
        public void SetBufferLength(float seconds)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), seconds);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_buffer_length");

        [GodotMethod("get_buffer_length")]
        [Obsolete("GetBufferLength is deprecated. Use the BufferLength property instead.")]
        public float GetBufferLength()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
