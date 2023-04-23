using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Adds a chorus audio effect. The effect applies a filter with voices to duplicate the audio source and manipulate it through the filter.</para>
    /// </summary>
    public partial class AudioEffectChorus : AudioEffect
    {
        /// <summary>
        /// <para>The amount of voices in the effect.</para>
        /// </summary>
        public int VoiceCount
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoiceCount();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoiceCount(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The effect's raw signal.</para>
        /// </summary>
        public float Dry
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDry();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDry(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The effect's processed signal.</para>
        /// </summary>
        public float Wet
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetWet();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetWet(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice's signal delay.</para>
        /// </summary>
        public float Voice__1__delayMs
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoiceDelayMs(0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoiceDelayMs(0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice's filter rate.</para>
        /// </summary>
        public float Voice__1__rateHz
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoiceRateHz(0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoiceRateHz(0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice filter's depth.</para>
        /// </summary>
        public float Voice__1__depthMs
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoiceDepthMs(0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoiceDepthMs(0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice's volume.</para>
        /// </summary>
        public float Voice__1__levelDb
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoiceLevelDb(0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoiceLevelDb(0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice's cutoff frequency.</para>
        /// </summary>
        public float Voice__1__cutoffHz
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoiceCutoffHz(0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoiceCutoffHz(0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice's pan level.</para>
        /// </summary>
        public float Voice__1__pan
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoicePan(0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoicePan(0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice's signal delay.</para>
        /// </summary>
        public float Voice__2__delayMs
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoiceDelayMs(1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoiceDelayMs(1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice's filter rate.</para>
        /// </summary>
        public float Voice__2__rateHz
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoiceRateHz(1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoiceRateHz(1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice filter's depth.</para>
        /// </summary>
        public float Voice__2__depthMs
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoiceDepthMs(1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoiceDepthMs(1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice's volume.</para>
        /// </summary>
        public float Voice__2__levelDb
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoiceLevelDb(1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoiceLevelDb(1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice's cutoff frequency.</para>
        /// </summary>
        public float Voice__2__cutoffHz
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoiceCutoffHz(1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoiceCutoffHz(1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice's pan level.</para>
        /// </summary>
        public float Voice__2__pan
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoicePan(1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoicePan(1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice's signal delay.</para>
        /// </summary>
        public float Voice__3__delayMs
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoiceDelayMs(2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoiceDelayMs(2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice's filter rate.</para>
        /// </summary>
        public float Voice__3__rateHz
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoiceRateHz(2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoiceRateHz(2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice filter's depth.</para>
        /// </summary>
        public float Voice__3__depthMs
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoiceDepthMs(2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoiceDepthMs(2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice's volume.</para>
        /// </summary>
        public float Voice__3__levelDb
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoiceLevelDb(2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoiceLevelDb(2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice's cutoff frequency.</para>
        /// </summary>
        public float Voice__3__cutoffHz
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoiceCutoffHz(2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoiceCutoffHz(2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice's pan level.</para>
        /// </summary>
        public float Voice__3__pan
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoicePan(2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoicePan(2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice's signal delay.</para>
        /// </summary>
        public float Voice__4__delayMs
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoiceDelayMs(3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoiceDelayMs(3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice's filter rate.</para>
        /// </summary>
        public float Voice__4__rateHz
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoiceRateHz(3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoiceRateHz(3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice filter's depth.</para>
        /// </summary>
        public float Voice__4__depthMs
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoiceDepthMs(3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoiceDepthMs(3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice's volume.</para>
        /// </summary>
        public float Voice__4__levelDb
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoiceLevelDb(3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoiceLevelDb(3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice's cutoff frequency.</para>
        /// </summary>
        public float Voice__4__cutoffHz
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoiceCutoffHz(3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoiceCutoffHz(3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The voice's pan level.</para>
        /// </summary>
        public float Voice__4__pan
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVoicePan(3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVoicePan(3, value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AudioEffectChorus";

        public AudioEffectChorus() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectChorus_Ctor(this);
        }

        internal AudioEffectChorus(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_voice_count");

        [GodotMethod("set_voice_count")]
        [Obsolete("SetVoiceCount is deprecated. Use the VoiceCount property instead.")]
        public void SetVoiceCount(int voices)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), voices);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_voice_count");

        [GodotMethod("get_voice_count")]
        [Obsolete("GetVoiceCount is deprecated. Use the VoiceCount property instead.")]
        public int GetVoiceCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_voice_delay_ms");

        [GodotMethod("set_voice_delay_ms")]
        [Obsolete("SetVoiceDelayMs is deprecated. Use the Voice__4__delayMs property instead.")]
        public void SetVoiceDelayMs(int voiceIdx, float delayMs)
        {
            NativeCalls.godot_icall_2_34(method_bind_2, Object.GetPtr(this), voiceIdx, delayMs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_voice_delay_ms");

        [GodotMethod("get_voice_delay_ms")]
        [Obsolete("GetVoiceDelayMs is deprecated. Use the Voice__4__delayMs property instead.")]
        public float GetVoiceDelayMs(int voiceIdx)
        {
            return NativeCalls.godot_icall_1_12(method_bind_3, Object.GetPtr(this), voiceIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_voice_rate_hz");

        [GodotMethod("set_voice_rate_hz")]
        [Obsolete("SetVoiceRateHz is deprecated. Use the Voice__4__rateHz property instead.")]
        public void SetVoiceRateHz(int voiceIdx, float rateHz)
        {
            NativeCalls.godot_icall_2_34(method_bind_4, Object.GetPtr(this), voiceIdx, rateHz);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_voice_rate_hz");

        [GodotMethod("get_voice_rate_hz")]
        [Obsolete("GetVoiceRateHz is deprecated. Use the Voice__4__rateHz property instead.")]
        public float GetVoiceRateHz(int voiceIdx)
        {
            return NativeCalls.godot_icall_1_12(method_bind_5, Object.GetPtr(this), voiceIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_voice_depth_ms");

        [GodotMethod("set_voice_depth_ms")]
        [Obsolete("SetVoiceDepthMs is deprecated. Use the Voice__4__depthMs property instead.")]
        public void SetVoiceDepthMs(int voiceIdx, float depthMs)
        {
            NativeCalls.godot_icall_2_34(method_bind_6, Object.GetPtr(this), voiceIdx, depthMs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_voice_depth_ms");

        [GodotMethod("get_voice_depth_ms")]
        [Obsolete("GetVoiceDepthMs is deprecated. Use the Voice__4__depthMs property instead.")]
        public float GetVoiceDepthMs(int voiceIdx)
        {
            return NativeCalls.godot_icall_1_12(method_bind_7, Object.GetPtr(this), voiceIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_voice_level_db");

        [GodotMethod("set_voice_level_db")]
        [Obsolete("SetVoiceLevelDb is deprecated. Use the Voice__4__levelDb property instead.")]
        public void SetVoiceLevelDb(int voiceIdx, float levelDb)
        {
            NativeCalls.godot_icall_2_34(method_bind_8, Object.GetPtr(this), voiceIdx, levelDb);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_voice_level_db");

        [GodotMethod("get_voice_level_db")]
        [Obsolete("GetVoiceLevelDb is deprecated. Use the Voice__4__levelDb property instead.")]
        public float GetVoiceLevelDb(int voiceIdx)
        {
            return NativeCalls.godot_icall_1_12(method_bind_9, Object.GetPtr(this), voiceIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_voice_cutoff_hz");

        [GodotMethod("set_voice_cutoff_hz")]
        [Obsolete("SetVoiceCutoffHz is deprecated. Use the Voice__4__cutoffHz property instead.")]
        public void SetVoiceCutoffHz(int voiceIdx, float cutoffHz)
        {
            NativeCalls.godot_icall_2_34(method_bind_10, Object.GetPtr(this), voiceIdx, cutoffHz);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_voice_cutoff_hz");

        [GodotMethod("get_voice_cutoff_hz")]
        [Obsolete("GetVoiceCutoffHz is deprecated. Use the Voice__4__cutoffHz property instead.")]
        public float GetVoiceCutoffHz(int voiceIdx)
        {
            return NativeCalls.godot_icall_1_12(method_bind_11, Object.GetPtr(this), voiceIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_voice_pan");

        [GodotMethod("set_voice_pan")]
        [Obsolete("SetVoicePan is deprecated. Use the Voice__4__pan property instead.")]
        public void SetVoicePan(int voiceIdx, float pan)
        {
            NativeCalls.godot_icall_2_34(method_bind_12, Object.GetPtr(this), voiceIdx, pan);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_voice_pan");

        [GodotMethod("get_voice_pan")]
        [Obsolete("GetVoicePan is deprecated. Use the Voice__4__pan property instead.")]
        public float GetVoicePan(int voiceIdx)
        {
            return NativeCalls.godot_icall_1_12(method_bind_13, Object.GetPtr(this), voiceIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_wet");

        [GodotMethod("set_wet")]
        [Obsolete("SetWet is deprecated. Use the Wet property instead.")]
        public void SetWet(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_14, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_wet");

        [GodotMethod("get_wet")]
        [Obsolete("GetWet is deprecated. Use the Wet property instead.")]
        public float GetWet()
        {
            return NativeCalls.godot_icall_0_14(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dry");

        [GodotMethod("set_dry")]
        [Obsolete("SetDry is deprecated. Use the Dry property instead.")]
        public void SetDry(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_16, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_dry");

        [GodotMethod("get_dry")]
        [Obsolete("GetDry is deprecated. Use the Dry property instead.")]
        public float GetDry()
        {
            return NativeCalls.godot_icall_0_14(method_bind_17, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
