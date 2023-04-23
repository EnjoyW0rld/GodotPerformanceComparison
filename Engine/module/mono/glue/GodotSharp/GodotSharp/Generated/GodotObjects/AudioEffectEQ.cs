using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>AudioEffectEQ gives you control over frequencies. Use it to compensate for existing deficiencies in audio. AudioEffectEQs are useful on the Master bus to completely master a mix and give it more character. They are also useful when a game is run on a mobile device, to adjust the mix to that kind of speakers (it can be added but disabled when headphones are plugged).</para>
    /// </summary>
    public partial class AudioEffectEQ : AudioEffect
    {
        private const string nativeName = "AudioEffectEQ";

        public AudioEffectEQ() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectEQ_Ctor(this);
        }

        internal AudioEffectEQ(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_band_gain_db");

        /// <summary>
        /// <para>Sets band's gain at the specified index, in dB.</para>
        /// </summary>
        [GodotMethod("set_band_gain_db")]
        public void SetBandGainDb(int bandIdx, float volumeDb)
        {
            NativeCalls.godot_icall_2_34(method_bind_0, Object.GetPtr(this), bandIdx, volumeDb);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_band_gain_db");

        /// <summary>
        /// <para>Returns the band's gain at the specified index, in dB.</para>
        /// </summary>
        [GodotMethod("get_band_gain_db")]
        public float GetBandGainDb(int bandIdx)
        {
            return NativeCalls.godot_icall_1_12(method_bind_1, Object.GetPtr(this), bandIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_band_count");

        /// <summary>
        /// <para>Returns the number of bands of the equalizer.</para>
        /// </summary>
        [GodotMethod("get_band_count")]
        public int GetBandCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_2, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
