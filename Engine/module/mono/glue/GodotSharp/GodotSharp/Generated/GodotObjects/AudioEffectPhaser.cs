using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Combines phase-shifted signals with the original signal. The movement of the phase-shifted signals is controlled using a low-frequency oscillator.</para>
    /// </summary>
    public partial class AudioEffectPhaser : AudioEffect
    {
        /// <summary>
        /// <para>Determines the minimum frequency affected by the LFO modulations, in Hz. Value can range from 10 to 10000.</para>
        /// </summary>
        public float RangeMinHz
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRangeMinHz();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRangeMinHz(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Determines the maximum frequency affected by the LFO modulations, in Hz. Value can range from 10 to 10000.</para>
        /// </summary>
        public float RangeMaxHz
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRangeMaxHz();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRangeMaxHz(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Adjusts the rate in Hz at which the effect sweeps up and down across the frequency range.</para>
        /// </summary>
        public float RateHz
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRateHz();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRateHz(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Output percent of modified sound. Value can range from 0.1 to 0.9.</para>
        /// </summary>
        public float Feedback
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFeedback();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFeedback(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Governs how high the filter frequencies sweep. Low value will primarily affect bass frequencies. High value can sweep high into the treble. Value can range from 0.1 to 4.</para>
        /// </summary>
        public float Depth
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDepth();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDepth(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AudioEffectPhaser";

        public AudioEffectPhaser() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectPhaser_Ctor(this);
        }

        internal AudioEffectPhaser(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_range_min_hz");

        [GodotMethod("set_range_min_hz")]
        [Obsolete("SetRangeMinHz is deprecated. Use the RangeMinHz property instead.")]
        public void SetRangeMinHz(float hz)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), hz);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_range_min_hz");

        [GodotMethod("get_range_min_hz")]
        [Obsolete("GetRangeMinHz is deprecated. Use the RangeMinHz property instead.")]
        public float GetRangeMinHz()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_range_max_hz");

        [GodotMethod("set_range_max_hz")]
        [Obsolete("SetRangeMaxHz is deprecated. Use the RangeMaxHz property instead.")]
        public void SetRangeMaxHz(float hz)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), hz);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_range_max_hz");

        [GodotMethod("get_range_max_hz")]
        [Obsolete("GetRangeMaxHz is deprecated. Use the RangeMaxHz property instead.")]
        public float GetRangeMaxHz()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rate_hz");

        [GodotMethod("set_rate_hz")]
        [Obsolete("SetRateHz is deprecated. Use the RateHz property instead.")]
        public void SetRateHz(float hz)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), hz);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rate_hz");

        [GodotMethod("get_rate_hz")]
        [Obsolete("GetRateHz is deprecated. Use the RateHz property instead.")]
        public float GetRateHz()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_feedback");

        [GodotMethod("set_feedback")]
        [Obsolete("SetFeedback is deprecated. Use the Feedback property instead.")]
        public void SetFeedback(float fbk)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), fbk);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_feedback");

        [GodotMethod("get_feedback")]
        [Obsolete("GetFeedback is deprecated. Use the Feedback property instead.")]
        public float GetFeedback()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_depth");

        [GodotMethod("set_depth")]
        [Obsolete("SetDepth is deprecated. Use the Depth property instead.")]
        public void SetDepth(float depth)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), depth);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_depth");

        [GodotMethod("get_depth")]
        [Obsolete("GetDepth is deprecated. Use the Depth property instead.")]
        public float GetDepth()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
