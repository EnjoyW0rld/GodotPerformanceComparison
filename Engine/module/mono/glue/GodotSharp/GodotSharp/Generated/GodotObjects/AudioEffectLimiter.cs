using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A limiter is similar to a compressor, but it's less flexible and designed to disallow sound going over a given dB threshold. Adding one in the Master bus is always recommended to reduce the effects of clipping.</para>
    /// <para>Soft clipping starts to reduce the peaks a little below the threshold level and progressively increases its effect as the input level increases such that the threshold is never exceeded.</para>
    /// </summary>
    public partial class AudioEffectLimiter : AudioEffect
    {
        /// <summary>
        /// <para>The waveform's maximum allowed value, in decibels. Value can range from -20 to -0.1.</para>
        /// </summary>
        public float CeilingDb
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCeilingDb();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCeilingDb(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Threshold from which the limiter begins to be active, in decibels. Value can range from -30 to 0.</para>
        /// </summary>
        public float ThresholdDb
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetThresholdDb();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetThresholdDb(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Applies a gain to the limited waves, in decibels. Value can range from 0 to 6.</para>
        /// </summary>
        public float SoftClipDb
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSoftClipDb();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSoftClipDb(value);
            }
#pragma warning restore CS0618
        }

        public float SoftClipRatio
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSoftClipRatio();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSoftClipRatio(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AudioEffectLimiter";

        public AudioEffectLimiter() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectLimiter_Ctor(this);
        }

        internal AudioEffectLimiter(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ceiling_db");

        [GodotMethod("set_ceiling_db")]
        [Obsolete("SetCeilingDb is deprecated. Use the CeilingDb property instead.")]
        public void SetCeilingDb(float ceiling)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), ceiling);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ceiling_db");

        [GodotMethod("get_ceiling_db")]
        [Obsolete("GetCeilingDb is deprecated. Use the CeilingDb property instead.")]
        public float GetCeilingDb()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_threshold_db");

        [GodotMethod("set_threshold_db")]
        [Obsolete("SetThresholdDb is deprecated. Use the ThresholdDb property instead.")]
        public void SetThresholdDb(float threshold)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), threshold);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_threshold_db");

        [GodotMethod("get_threshold_db")]
        [Obsolete("GetThresholdDb is deprecated. Use the ThresholdDb property instead.")]
        public float GetThresholdDb()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_soft_clip_db");

        [GodotMethod("set_soft_clip_db")]
        [Obsolete("SetSoftClipDb is deprecated. Use the SoftClipDb property instead.")]
        public void SetSoftClipDb(float softClip)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), softClip);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_soft_clip_db");

        [GodotMethod("get_soft_clip_db")]
        [Obsolete("GetSoftClipDb is deprecated. Use the SoftClipDb property instead.")]
        public float GetSoftClipDb()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_soft_clip_ratio");

        [GodotMethod("set_soft_clip_ratio")]
        [Obsolete("SetSoftClipRatio is deprecated. Use the SoftClipRatio property instead.")]
        public void SetSoftClipRatio(float softClip)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), softClip);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_soft_clip_ratio");

        [GodotMethod("get_soft_clip_ratio")]
        [Obsolete("GetSoftClipRatio is deprecated. Use the SoftClipRatio property instead.")]
        public float GetSoftClipRatio()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
