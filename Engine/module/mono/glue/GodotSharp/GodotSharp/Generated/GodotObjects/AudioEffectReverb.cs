using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Simulates rooms of different sizes. Its parameters can be adjusted to simulate the sound of a specific room.</para>
    /// </summary>
    public partial class AudioEffectReverb : AudioEffect
    {
        /// <summary>
        /// <para>Time between the original signal and the early reflections of the reverb signal, in milliseconds.</para>
        /// </summary>
        public float PredelayMsec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPredelayMsec();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPredelayMsec(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Output percent of predelay. Value can range from 0 to 1.</para>
        /// </summary>
        public float PredelayFeedback
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPredelayFeedback();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPredelayFeedback(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Dimensions of simulated room. Bigger means more echoes. Value can range from 0 to 1.</para>
        /// </summary>
        public float RoomSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRoomSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRoomSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Defines how reflective the imaginary room's walls are. Value can range from 0 to 1.</para>
        /// </summary>
        public float Damping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDamping();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDamping(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Widens or narrows the stereo image of the reverb tail. 1 means fully widens. Value can range from 0 to 1.</para>
        /// </summary>
        public float Spread
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSpread();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSpread(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>High-pass filter passes signals with a frequency higher than a certain cutoff frequency and attenuates signals with frequencies lower than the cutoff frequency. Value can range from 0 to 1.</para>
        /// </summary>
        public float Hipass
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHpf();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHpf(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Output percent of original sound. At 0, only modified sound is outputted. Value can range from 0 to 1.</para>
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
        /// <para>Output percent of modified sound. At 0, only original sound is outputted. Value can range from 0 to 1.</para>
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

        private const string nativeName = "AudioEffectReverb";

        public AudioEffectReverb() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectReverb_Ctor(this);
        }

        internal AudioEffectReverb(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_predelay_msec");

        [GodotMethod("set_predelay_msec")]
        [Obsolete("SetPredelayMsec is deprecated. Use the PredelayMsec property instead.")]
        public void SetPredelayMsec(float msec)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), msec);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_predelay_msec");

        [GodotMethod("get_predelay_msec")]
        [Obsolete("GetPredelayMsec is deprecated. Use the PredelayMsec property instead.")]
        public float GetPredelayMsec()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_predelay_feedback");

        [GodotMethod("set_predelay_feedback")]
        [Obsolete("SetPredelayFeedback is deprecated. Use the PredelayFeedback property instead.")]
        public void SetPredelayFeedback(float feedback)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), feedback);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_predelay_feedback");

        [GodotMethod("get_predelay_feedback")]
        [Obsolete("GetPredelayFeedback is deprecated. Use the PredelayFeedback property instead.")]
        public float GetPredelayFeedback()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_room_size");

        [GodotMethod("set_room_size")]
        [Obsolete("SetRoomSize is deprecated. Use the RoomSize property instead.")]
        public void SetRoomSize(float size)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_room_size");

        [GodotMethod("get_room_size")]
        [Obsolete("GetRoomSize is deprecated. Use the RoomSize property instead.")]
        public float GetRoomSize()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_damping");

        [GodotMethod("set_damping")]
        [Obsolete("SetDamping is deprecated. Use the Damping property instead.")]
        public void SetDamping(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_damping");

        [GodotMethod("get_damping")]
        [Obsolete("GetDamping is deprecated. Use the Damping property instead.")]
        public float GetDamping()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_spread");

        [GodotMethod("set_spread")]
        [Obsolete("SetSpread is deprecated. Use the Spread property instead.")]
        public void SetSpread(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_spread");

        [GodotMethod("get_spread")]
        [Obsolete("GetSpread is deprecated. Use the Spread property instead.")]
        public float GetSpread()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dry");

        [GodotMethod("set_dry")]
        [Obsolete("SetDry is deprecated. Use the Dry property instead.")]
        public void SetDry(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_10, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_dry");

        [GodotMethod("get_dry")]
        [Obsolete("GetDry is deprecated. Use the Dry property instead.")]
        public float GetDry()
        {
            return NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_wet");

        [GodotMethod("set_wet")]
        [Obsolete("SetWet is deprecated. Use the Wet property instead.")]
        public void SetWet(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_12, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_wet");

        [GodotMethod("get_wet")]
        [Obsolete("GetWet is deprecated. Use the Wet property instead.")]
        public float GetWet()
        {
            return NativeCalls.godot_icall_0_14(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_hpf");

        [GodotMethod("set_hpf")]
        [Obsolete("SetHpf is deprecated. Use the Hipass property instead.")]
        public void SetHpf(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_14, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_hpf");

        [GodotMethod("get_hpf")]
        [Obsolete("GetHpf is deprecated. Use the Hipass property instead.")]
        public float GetHpf()
        {
            return NativeCalls.godot_icall_0_14(method_bind_15, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
