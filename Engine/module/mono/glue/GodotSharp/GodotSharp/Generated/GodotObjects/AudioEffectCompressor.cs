using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Dynamic range compressor reduces the level of the sound when the amplitude goes over a certain threshold in Decibels. One of the main uses of a compressor is to increase the dynamic range by clipping as little as possible (when sound goes over 0dB).</para>
    /// <para>Compressor has many uses in the mix:</para>
    /// <para>- In the Master bus to compress the whole output (although an <see cref="Godot.AudioEffectLimiter"/> is probably better).</para>
    /// <para>- In voice channels to ensure they sound as balanced as possible.</para>
    /// <para>- Sidechained. This can reduce the sound level sidechained with another audio bus for threshold detection. This technique is common in video game mixing to the level of music and SFX while voices are being heard.</para>
    /// <para>- Accentuates transients by using a wider attack, making effects sound more punchy.</para>
    /// </summary>
    public partial class AudioEffectCompressor : AudioEffect
    {
        /// <summary>
        /// <para>The level above which compression is applied to the audio. Value can range from -60 to 0.</para>
        /// </summary>
        public float Threshold
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetThreshold();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetThreshold(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Amount of compression applied to the audio once it passes the threshold level. The higher the ratio, the more the loud parts of the audio will be compressed. Value can range from 1 to 48.</para>
        /// </summary>
        public float Ratio
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRatio();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRatio(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Gain applied to the output signal.</para>
        /// </summary>
        public float Gain
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGain();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGain(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Compressor's reaction time when the signal exceeds the threshold, in microseconds. Value can range from 20 to 2000.</para>
        /// </summary>
        public float AttackUs
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAttackUs();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAttackUs(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Compressor's delay time to stop reducing the signal after the signal level falls below the threshold, in milliseconds. Value can range from 20 to 2000.</para>
        /// </summary>
        public float ReleaseMs
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetReleaseMs();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetReleaseMs(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Balance between original signal and effect signal. Value can range from 0 (totally dry) to 1 (totally wet).</para>
        /// </summary>
        public float Mix
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMix();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMix(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Reduce the sound level using another audio bus for threshold detection.</para>
        /// </summary>
        public string Sidechain
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSidechain();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSidechain(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AudioEffectCompressor";

        public AudioEffectCompressor() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectCompressor_Ctor(this);
        }

        internal AudioEffectCompressor(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_threshold");

        [GodotMethod("set_threshold")]
        [Obsolete("SetThreshold is deprecated. Use the Threshold property instead.")]
        public void SetThreshold(float threshold)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), threshold);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_threshold");

        [GodotMethod("get_threshold")]
        [Obsolete("GetThreshold is deprecated. Use the Threshold property instead.")]
        public float GetThreshold()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ratio");

        [GodotMethod("set_ratio")]
        [Obsolete("SetRatio is deprecated. Use the Ratio property instead.")]
        public void SetRatio(float ratio)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), ratio);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ratio");

        [GodotMethod("get_ratio")]
        [Obsolete("GetRatio is deprecated. Use the Ratio property instead.")]
        public float GetRatio()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_gain");

        [GodotMethod("set_gain")]
        [Obsolete("SetGain is deprecated. Use the Gain property instead.")]
        public void SetGain(float gain)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), gain);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_gain");

        [GodotMethod("get_gain")]
        [Obsolete("GetGain is deprecated. Use the Gain property instead.")]
        public float GetGain()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_attack_us");

        [GodotMethod("set_attack_us")]
        [Obsolete("SetAttackUs is deprecated. Use the AttackUs property instead.")]
        public void SetAttackUs(float attackUs)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), attackUs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_attack_us");

        [GodotMethod("get_attack_us")]
        [Obsolete("GetAttackUs is deprecated. Use the AttackUs property instead.")]
        public float GetAttackUs()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_release_ms");

        [GodotMethod("set_release_ms")]
        [Obsolete("SetReleaseMs is deprecated. Use the ReleaseMs property instead.")]
        public void SetReleaseMs(float releaseMs)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), releaseMs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_release_ms");

        [GodotMethod("get_release_ms")]
        [Obsolete("GetReleaseMs is deprecated. Use the ReleaseMs property instead.")]
        public float GetReleaseMs()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mix");

        [GodotMethod("set_mix")]
        [Obsolete("SetMix is deprecated. Use the Mix property instead.")]
        public void SetMix(float mix)
        {
            NativeCalls.godot_icall_1_15(method_bind_10, Object.GetPtr(this), mix);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mix");

        [GodotMethod("get_mix")]
        [Obsolete("GetMix is deprecated. Use the Mix property instead.")]
        public float GetMix()
        {
            return NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sidechain");

        [GodotMethod("set_sidechain")]
        [Obsolete("SetSidechain is deprecated. Use the Sidechain property instead.")]
        public void SetSidechain(string sidechain)
        {
            NativeCalls.godot_icall_1_54(method_bind_12, Object.GetPtr(this), sidechain);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sidechain");

        [GodotMethod("get_sidechain")]
        [Obsolete("GetSidechain is deprecated. Use the Sidechain property instead.")]
        public string GetSidechain()
        {
            return NativeCalls.godot_icall_0_6(method_bind_13, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
