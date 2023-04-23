using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Allows frequencies other than the <see cref="Godot.AudioEffectFilter.CutoffHz"/> to pass.</para>
    /// </summary>
    public partial class AudioEffectFilter : AudioEffect
    {
        public enum FilterDB
        {
            Filter6db = 0,
            Filter12db = 1,
            Filter18db = 2,
            Filter24db = 3
        }

        /// <summary>
        /// <para>Threshold frequency for the filter, in Hz.</para>
        /// </summary>
        public float CutoffHz
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCutoff();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCutoff(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Amount of boost in the frequency range near the cutoff frequency.</para>
        /// </summary>
        public float Resonance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetResonance();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetResonance(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Gain amount of the frequencies after the filter.</para>
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

        public AudioEffectFilter.FilterDB Db
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDb();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDb(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AudioEffectFilter";

        public AudioEffectFilter() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectFilter_Ctor(this);
        }

        internal AudioEffectFilter(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cutoff");

        [GodotMethod("set_cutoff")]
        [Obsolete("SetCutoff is deprecated. Use the CutoffHz property instead.")]
        public void SetCutoff(float freq)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), freq);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cutoff");

        [GodotMethod("get_cutoff")]
        [Obsolete("GetCutoff is deprecated. Use the CutoffHz property instead.")]
        public float GetCutoff()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_resonance");

        [GodotMethod("set_resonance")]
        [Obsolete("SetResonance is deprecated. Use the Resonance property instead.")]
        public void SetResonance(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_resonance");

        [GodotMethod("get_resonance")]
        [Obsolete("GetResonance is deprecated. Use the Resonance property instead.")]
        public float GetResonance()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_gain");

        [GodotMethod("set_gain")]
        [Obsolete("SetGain is deprecated. Use the Gain property instead.")]
        public void SetGain(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), amount);
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
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_db");

        [GodotMethod("set_db")]
        [Obsolete("SetDb is deprecated. Use the Db property instead.")]
        public void SetDb(AudioEffectFilter.FilterDB amount)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), (int)amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_db");

        [GodotMethod("get_db")]
        [Obsolete("GetDb is deprecated. Use the Db property instead.")]
        public AudioEffectFilter.FilterDB GetDb()
        {
            return (AudioEffectFilter.FilterDB)NativeCalls.godot_icall_0_167(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
