using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Plays input signal back after a period of time. The delayed signal may be played back multiple times to create the sound of a repeating, decaying echo. Delay effects range from a subtle echo effect to a pronounced blending of previous sounds with new sounds.</para>
    /// </summary>
    public partial class AudioEffectDelay : AudioEffect
    {
        /// <summary>
        /// <para>Output percent of original sound. At 0, only delayed sounds are output. Value can range from 0 to 1.</para>
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
        /// <para>If <c>true</c>, <c>tap1</c> will be enabled.</para>
        /// </summary>
        public bool Tap1__active
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsTap1Active();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTap1Active(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para><c>tap1</c> delay time in milliseconds.</para>
        /// </summary>
        public float Tap1__delayMs
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTap1DelayMs();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTap1DelayMs(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sound level for <c>tap1</c>.</para>
        /// </summary>
        public float Tap1__levelDb
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTap1LevelDb();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTap1LevelDb(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Pan position for <c>tap1</c>. Value can range from -1 (fully left) to 1 (fully right).</para>
        /// </summary>
        public float Tap1__pan
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTap1Pan();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTap1Pan(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, <c>tap2</c> will be enabled.</para>
        /// </summary>
        public bool Tap2__active
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsTap2Active();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTap2Active(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Tap2 delay time in milliseconds.</para>
        /// </summary>
        public float Tap2__delayMs
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTap2DelayMs();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTap2DelayMs(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sound level for <c>tap2</c>.</para>
        /// </summary>
        public float Tap2__levelDb
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTap2LevelDb();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTap2LevelDb(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Pan position for <c>tap2</c>. Value can range from -1 (fully left) to 1 (fully right).</para>
        /// </summary>
        public float Tap2__pan
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTap2Pan();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTap2Pan(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, feedback is enabled.</para>
        /// </summary>
        public bool Feedback__active
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsFeedbackActive();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFeedbackActive(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Feedback delay time in milliseconds.</para>
        /// </summary>
        public float Feedback__delayMs
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFeedbackDelayMs();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFeedbackDelayMs(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sound level for <c>tap1</c>.</para>
        /// </summary>
        public float Feedback__levelDb
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFeedbackLevelDb();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFeedbackLevelDb(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Low-pass filter for feedback, in Hz. Frequencies below this value are filtered out of the source signal.</para>
        /// </summary>
        public float Feedback__lowpass
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFeedbackLowpass();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFeedbackLowpass(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AudioEffectDelay";

        public AudioEffectDelay() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectDelay_Ctor(this);
        }

        internal AudioEffectDelay(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dry");

        [GodotMethod("set_dry")]
        [Obsolete("SetDry is deprecated. Use the Dry property instead.")]
        public void SetDry(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_dry");

        [GodotMethod("get_dry")]
        [Obsolete("GetDry is deprecated. Use the Dry property instead.")]
        public float GetDry()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tap1_active");

        [GodotMethod("set_tap1_active")]
        [Obsolete("SetTap1Active is deprecated. Use the Tap1__active property instead.")]
        public void SetTap1Active(bool amount)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_tap1_active");

        [GodotMethod("is_tap1_active")]
        [Obsolete("IsTap1Active is deprecated. Use the Tap1__active property instead.")]
        public bool IsTap1Active()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tap1_delay_ms");

        [GodotMethod("set_tap1_delay_ms")]
        [Obsolete("SetTap1DelayMs is deprecated. Use the Tap1__delayMs property instead.")]
        public void SetTap1DelayMs(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tap1_delay_ms");

        [GodotMethod("get_tap1_delay_ms")]
        [Obsolete("GetTap1DelayMs is deprecated. Use the Tap1__delayMs property instead.")]
        public float GetTap1DelayMs()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tap1_level_db");

        [GodotMethod("set_tap1_level_db")]
        [Obsolete("SetTap1LevelDb is deprecated. Use the Tap1__levelDb property instead.")]
        public void SetTap1LevelDb(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tap1_level_db");

        [GodotMethod("get_tap1_level_db")]
        [Obsolete("GetTap1LevelDb is deprecated. Use the Tap1__levelDb property instead.")]
        public float GetTap1LevelDb()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tap1_pan");

        [GodotMethod("set_tap1_pan")]
        [Obsolete("SetTap1Pan is deprecated. Use the Tap1__pan property instead.")]
        public void SetTap1Pan(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tap1_pan");

        [GodotMethod("get_tap1_pan")]
        [Obsolete("GetTap1Pan is deprecated. Use the Tap1__pan property instead.")]
        public float GetTap1Pan()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tap2_active");

        [GodotMethod("set_tap2_active")]
        [Obsolete("SetTap2Active is deprecated. Use the Tap2__active property instead.")]
        public void SetTap2Active(bool amount)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_tap2_active");

        [GodotMethod("is_tap2_active")]
        [Obsolete("IsTap2Active is deprecated. Use the Tap2__active property instead.")]
        public bool IsTap2Active()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tap2_delay_ms");

        [GodotMethod("set_tap2_delay_ms")]
        [Obsolete("SetTap2DelayMs is deprecated. Use the Tap2__delayMs property instead.")]
        public void SetTap2DelayMs(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_12, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tap2_delay_ms");

        [GodotMethod("get_tap2_delay_ms")]
        [Obsolete("GetTap2DelayMs is deprecated. Use the Tap2__delayMs property instead.")]
        public float GetTap2DelayMs()
        {
            return NativeCalls.godot_icall_0_14(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tap2_level_db");

        [GodotMethod("set_tap2_level_db")]
        [Obsolete("SetTap2LevelDb is deprecated. Use the Tap2__levelDb property instead.")]
        public void SetTap2LevelDb(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_14, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tap2_level_db");

        [GodotMethod("get_tap2_level_db")]
        [Obsolete("GetTap2LevelDb is deprecated. Use the Tap2__levelDb property instead.")]
        public float GetTap2LevelDb()
        {
            return NativeCalls.godot_icall_0_14(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tap2_pan");

        [GodotMethod("set_tap2_pan")]
        [Obsolete("SetTap2Pan is deprecated. Use the Tap2__pan property instead.")]
        public void SetTap2Pan(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_16, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tap2_pan");

        [GodotMethod("get_tap2_pan")]
        [Obsolete("GetTap2Pan is deprecated. Use the Tap2__pan property instead.")]
        public float GetTap2Pan()
        {
            return NativeCalls.godot_icall_0_14(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_feedback_active");

        [GodotMethod("set_feedback_active")]
        [Obsolete("SetFeedbackActive is deprecated. Use the Feedback__active property instead.")]
        public void SetFeedbackActive(bool amount)
        {
            NativeCalls.godot_icall_1_16(method_bind_18, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_feedback_active");

        [GodotMethod("is_feedback_active")]
        [Obsolete("IsFeedbackActive is deprecated. Use the Feedback__active property instead.")]
        public bool IsFeedbackActive()
        {
            return NativeCalls.godot_icall_0_7(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_feedback_delay_ms");

        [GodotMethod("set_feedback_delay_ms")]
        [Obsolete("SetFeedbackDelayMs is deprecated. Use the Feedback__delayMs property instead.")]
        public void SetFeedbackDelayMs(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_20, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_feedback_delay_ms");

        [GodotMethod("get_feedback_delay_ms")]
        [Obsolete("GetFeedbackDelayMs is deprecated. Use the Feedback__delayMs property instead.")]
        public float GetFeedbackDelayMs()
        {
            return NativeCalls.godot_icall_0_14(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_feedback_level_db");

        [GodotMethod("set_feedback_level_db")]
        [Obsolete("SetFeedbackLevelDb is deprecated. Use the Feedback__levelDb property instead.")]
        public void SetFeedbackLevelDb(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_22, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_feedback_level_db");

        [GodotMethod("get_feedback_level_db")]
        [Obsolete("GetFeedbackLevelDb is deprecated. Use the Feedback__levelDb property instead.")]
        public float GetFeedbackLevelDb()
        {
            return NativeCalls.godot_icall_0_14(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_feedback_lowpass");

        [GodotMethod("set_feedback_lowpass")]
        [Obsolete("SetFeedbackLowpass is deprecated. Use the Feedback__lowpass property instead.")]
        public void SetFeedbackLowpass(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_24, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_feedback_lowpass");

        [GodotMethod("get_feedback_lowpass")]
        [Obsolete("GetFeedbackLowpass is deprecated. Use the Feedback__lowpass property instead.")]
        public float GetFeedbackLowpass()
        {
            return NativeCalls.godot_icall_0_14(method_bind_25, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
