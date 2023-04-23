using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Different types are available: clip, tan, lo-fi (bit crushing), overdrive, or waveshape.</para>
    /// <para>By distorting the waveform the frequency content change, which will often make the sound "crunchy" or "abrasive". For games, it can simulate sound coming from some saturated device or speaker very efficiently.</para>
    /// </summary>
    public partial class AudioEffectDistortion : AudioEffect
    {
        public enum ModeEnum
        {
            /// <summary>
            /// <para>Digital distortion effect which cuts off peaks at the top and bottom of the waveform.</para>
            /// </summary>
            Clip = 0,
            Atan = 1,
            /// <summary>
            /// <para>Low-resolution digital distortion effect. You can use it to emulate the sound of early digital audio devices.</para>
            /// </summary>
            Lofi = 2,
            /// <summary>
            /// <para>Emulates the warm distortion produced by a field effect transistor, which is commonly used in solid-state musical instrument amplifiers.</para>
            /// </summary>
            Overdrive = 3,
            /// <summary>
            /// <para>Waveshaper distortions are used mainly by electronic musicians to achieve an extra-abrasive sound.</para>
            /// </summary>
            Waveshape = 4
        }

        /// <summary>
        /// <para>Distortion type.</para>
        /// </summary>
        public AudioEffectDistortion.ModeEnum Mode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Increases or decreases the volume before the effect. Value can range from -60 to 60.</para>
        /// </summary>
        public float PreGain
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPreGain();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPreGain(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>High-pass filter, in Hz. Frequencies higher than this value will not be affected by the distortion. Value can range from 1 to 20000.</para>
        /// </summary>
        public float KeepHfHz
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetKeepHfHz();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetKeepHfHz(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Distortion power. Value can range from 0 to 1.</para>
        /// </summary>
        public float Drive
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDrive();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDrive(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Increases or decreases the volume after the effect. Value can range from -80 to 24.</para>
        /// </summary>
        public float PostGain
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPostGain();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPostGain(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AudioEffectDistortion";

        public AudioEffectDistortion() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectDistortion_Ctor(this);
        }

        internal AudioEffectDistortion(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mode");

        [GodotMethod("set_mode")]
        [Obsolete("SetMode is deprecated. Use the Mode property instead.")]
        public void SetMode(AudioEffectDistortion.ModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mode");

        [GodotMethod("get_mode")]
        [Obsolete("GetMode is deprecated. Use the Mode property instead.")]
        public AudioEffectDistortion.ModeEnum GetMode()
        {
            return (AudioEffectDistortion.ModeEnum)NativeCalls.godot_icall_0_166(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pre_gain");

        [GodotMethod("set_pre_gain")]
        [Obsolete("SetPreGain is deprecated. Use the PreGain property instead.")]
        public void SetPreGain(float preGain)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), preGain);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pre_gain");

        [GodotMethod("get_pre_gain")]
        [Obsolete("GetPreGain is deprecated. Use the PreGain property instead.")]
        public float GetPreGain()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_keep_hf_hz");

        [GodotMethod("set_keep_hf_hz")]
        [Obsolete("SetKeepHfHz is deprecated. Use the KeepHfHz property instead.")]
        public void SetKeepHfHz(float keepHfHz)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), keepHfHz);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_keep_hf_hz");

        [GodotMethod("get_keep_hf_hz")]
        [Obsolete("GetKeepHfHz is deprecated. Use the KeepHfHz property instead.")]
        public float GetKeepHfHz()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_drive");

        [GodotMethod("set_drive")]
        [Obsolete("SetDrive is deprecated. Use the Drive property instead.")]
        public void SetDrive(float drive)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), drive);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_drive");

        [GodotMethod("get_drive")]
        [Obsolete("GetDrive is deprecated. Use the Drive property instead.")]
        public float GetDrive()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_post_gain");

        [GodotMethod("set_post_gain")]
        [Obsolete("SetPostGain is deprecated. Use the PostGain property instead.")]
        public void SetPostGain(float postGain)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), postGain);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_post_gain");

        [GodotMethod("get_post_gain")]
        [Obsolete("GetPostGain is deprecated. Use the PostGain property instead.")]
        public float GetPostGain()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
