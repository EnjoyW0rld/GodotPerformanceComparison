using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.AudioServer"/> is a low-level server interface for audio access. It is in charge of creating sample data (playable audio) as well as its playback via a voice interface.</para>
    /// </summary>
    public static partial class AudioServer
    {
        public enum SpeakerMode
        {
            /// <summary>
            /// <para>Two or fewer speakers were detected.</para>
            /// </summary>
            ModeStereo = 0,
            /// <summary>
            /// <para>A 3.1 channel surround setup was detected.</para>
            /// </summary>
            Surround31 = 1,
            /// <summary>
            /// <para>A 5.1 channel surround setup was detected.</para>
            /// </summary>
            Surround51 = 2,
            /// <summary>
            /// <para>A 7.1 channel surround setup was detected.</para>
            /// </summary>
            Surround71 = 3
        }

        /// <summary>
        /// <para>Number of available audio buses.</para>
        /// </summary>
        public static int BusCount
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBusCount();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBusCount(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Name of the current device for audio output (see <see cref="Godot.AudioServer.GetDeviceList"/>). On systems with multiple audio outputs (such as analog, USB and HDMI audio), this can be used to select the audio output device. The value <c>"Default"</c> will play audio on the system-wide default audio output. If an invalid device name is set, the value will be reverted back to <c>"Default"</c>.</para>
        /// </summary>
        public static string Device
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDevice();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDevice(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Name of the current device for audio input (see <see cref="Godot.AudioServer.CaptureGetDeviceList"/>). On systems with multiple audio inputs (such as analog, USB and HDMI audio), this can be used to select the audio input device. The value <c>"Default"</c> will record audio on the system-wide default audio input. If an invalid device name is set, the value will be reverted back to <c>"Default"</c>.</para>
        /// <para>Note:  must be <c>true</c> for audio input to work. See also that setting's description for caveats related to permissions and operating system privacy settings.</para>
        /// </summary>
        public static string CaptureDevice
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return CaptureGetDevice();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                CaptureSetDevice(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Scales the rate at which audio is played (i.e. setting it to <c>0.5</c> will make the audio be played twice as fast).</para>
        /// </summary>
        public static float GlobalRateScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGlobalRateScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlobalRateScale(value);
            }
#pragma warning restore CS0618
        }

        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(AudioServer).Name);
                return singleton;
            }
        }

        private const string nativeName = "AudioServer";
        internal static IntPtr ptr = NativeCalls.godot_icall_AudioServer_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bus_count");

        [GodotMethod("set_bus_count")]
        [Obsolete("SetBusCount is deprecated. Use the BusCount property instead.")]
        public static void SetBusCount(int amount)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, ptr, amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bus_count");

        [GodotMethod("get_bus_count")]
        [Obsolete("GetBusCount is deprecated. Use the BusCount property instead.")]
        public static int GetBusCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_bus");

        /// <summary>
        /// <para>Removes the bus at index <c>index</c>.</para>
        /// </summary>
        [GodotMethod("remove_bus")]
        public static void RemoveBus(int index)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, ptr, index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_bus");

        /// <summary>
        /// <para>Adds a bus at <c>at_position</c>.</para>
        /// </summary>
        [GodotMethod("add_bus")]
        public static void AddBus(int atPosition = -1)
        {
            NativeCalls.godot_icall_1_4(method_bind_3, ptr, atPosition);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "move_bus");

        /// <summary>
        /// <para>Moves the bus from index <c>index</c> to index <c>to_index</c>.</para>
        /// </summary>
        [GodotMethod("move_bus")]
        public static void MoveBus(int index, int toIndex)
        {
            NativeCalls.godot_icall_2_65(method_bind_4, ptr, index, toIndex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bus_name");

        /// <summary>
        /// <para>Sets the name of the bus at index <c>bus_idx</c> to <c>name</c>.</para>
        /// </summary>
        [GodotMethod("set_bus_name")]
        public static void SetBusName(int busIdx, string name)
        {
            NativeCalls.godot_icall_2_121(method_bind_5, ptr, busIdx, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bus_name");

        /// <summary>
        /// <para>Returns the name of the bus with the index <c>bus_idx</c>.</para>
        /// </summary>
        [GodotMethod("get_bus_name")]
        public static string GetBusName(int busIdx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_6, ptr, busIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bus_index");

        /// <summary>
        /// <para>Returns the index of the bus with the name <c>bus_name</c>.</para>
        /// </summary>
        [GodotMethod("get_bus_index")]
        public static int GetBusIndex(string busName)
        {
            return NativeCalls.godot_icall_1_138(method_bind_7, ptr, busName);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bus_channels");

        /// <summary>
        /// <para>Returns the amount of channels of the bus at index <c>bus_idx</c>.</para>
        /// </summary>
        [GodotMethod("get_bus_channels")]
        public static int GetBusChannels(int busIdx)
        {
            return NativeCalls.godot_icall_1_11(method_bind_8, ptr, busIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bus_volume_db");

        /// <summary>
        /// <para>Sets the volume of the bus at index <c>bus_idx</c> to <c>volume_db</c>.</para>
        /// </summary>
        [GodotMethod("set_bus_volume_db")]
        public static void SetBusVolumeDb(int busIdx, float volumeDb)
        {
            NativeCalls.godot_icall_2_34(method_bind_9, ptr, busIdx, volumeDb);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bus_volume_db");

        /// <summary>
        /// <para>Returns the volume of the bus at index <c>bus_idx</c> in dB.</para>
        /// </summary>
        [GodotMethod("get_bus_volume_db")]
        public static float GetBusVolumeDb(int busIdx)
        {
            return NativeCalls.godot_icall_1_12(method_bind_10, ptr, busIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bus_send");

        /// <summary>
        /// <para>Connects the output of the bus at <c>bus_idx</c> to the bus named <c>send</c>.</para>
        /// </summary>
        [GodotMethod("set_bus_send")]
        public static void SetBusSend(int busIdx, string send)
        {
            NativeCalls.godot_icall_2_121(method_bind_11, ptr, busIdx, send);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bus_send");

        /// <summary>
        /// <para>Returns the name of the bus that the bus at index <c>bus_idx</c> sends to.</para>
        /// </summary>
        [GodotMethod("get_bus_send")]
        public static string GetBusSend(int busIdx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_12, ptr, busIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bus_solo");

        /// <summary>
        /// <para>If <c>true</c>, the bus at index <c>bus_idx</c> is in solo mode.</para>
        /// </summary>
        [GodotMethod("set_bus_solo")]
        public static void SetBusSolo(int busIdx, bool enable)
        {
            NativeCalls.godot_icall_2_23(method_bind_13, ptr, busIdx, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_bus_solo");

        /// <summary>
        /// <para>If <c>true</c>, the bus at index <c>bus_idx</c> is in solo mode.</para>
        /// </summary>
        [GodotMethod("is_bus_solo")]
        public static bool IsBusSolo(int busIdx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_14, ptr, busIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bus_mute");

        /// <summary>
        /// <para>If <c>true</c>, the bus at index <c>bus_idx</c> is muted.</para>
        /// </summary>
        [GodotMethod("set_bus_mute")]
        public static void SetBusMute(int busIdx, bool enable)
        {
            NativeCalls.godot_icall_2_23(method_bind_15, ptr, busIdx, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_bus_mute");

        /// <summary>
        /// <para>If <c>true</c>, the bus at index <c>bus_idx</c> is muted.</para>
        /// </summary>
        [GodotMethod("is_bus_mute")]
        public static bool IsBusMute(int busIdx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_16, ptr, busIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bus_bypass_effects");

        /// <summary>
        /// <para>If <c>true</c>, the bus at index <c>bus_idx</c> is bypassing effects.</para>
        /// </summary>
        [GodotMethod("set_bus_bypass_effects")]
        public static void SetBusBypassEffects(int busIdx, bool enable)
        {
            NativeCalls.godot_icall_2_23(method_bind_17, ptr, busIdx, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_bus_bypassing_effects");

        /// <summary>
        /// <para>If <c>true</c>, the bus at index <c>bus_idx</c> is bypassing effects.</para>
        /// </summary>
        [GodotMethod("is_bus_bypassing_effects")]
        public static bool IsBusBypassingEffects(int busIdx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_18, ptr, busIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_bus_effect");

        /// <summary>
        /// <para>Adds an <see cref="Godot.AudioEffect"/> effect to the bus <c>bus_idx</c> at <c>at_position</c>.</para>
        /// </summary>
        [GodotMethod("add_bus_effect")]
        public static void AddBusEffect(int busIdx, AudioEffect effect, int atPosition = -1)
        {
            NativeCalls.godot_icall_3_173(method_bind_19, ptr, busIdx, Object.GetPtr(effect), atPosition);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_bus_effect");

        /// <summary>
        /// <para>Removes the effect at index <c>effect_idx</c> from the bus at index <c>bus_idx</c>.</para>
        /// </summary>
        [GodotMethod("remove_bus_effect")]
        public static void RemoveBusEffect(int busIdx, int effectIdx)
        {
            NativeCalls.godot_icall_2_65(method_bind_20, ptr, busIdx, effectIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bus_effect_count");

        /// <summary>
        /// <para>Returns the number of effects on the bus at <c>bus_idx</c>.</para>
        /// </summary>
        [GodotMethod("get_bus_effect_count")]
        public static int GetBusEffectCount(int busIdx)
        {
            return NativeCalls.godot_icall_1_11(method_bind_21, ptr, busIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bus_effect");

        /// <summary>
        /// <para>Returns the <see cref="Godot.AudioEffect"/> at position <c>effect_idx</c> in bus <c>bus_idx</c>.</para>
        /// </summary>
        [GodotMethod("get_bus_effect")]
        public static AudioEffect GetBusEffect(int busIdx, int effectIdx)
        {
            return NativeCalls.godot_icall_2_174(method_bind_22, ptr, busIdx, effectIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bus_effect_instance");

        /// <summary>
        /// <para>Returns the <see cref="Godot.AudioEffectInstance"/> assigned to the given bus and effect indices (and optionally channel).</para>
        /// </summary>
        [GodotMethod("get_bus_effect_instance")]
        public static AudioEffectInstance GetBusEffectInstance(int busIdx, int effectIdx, int channel = 0)
        {
            return NativeCalls.godot_icall_3_175(method_bind_23, ptr, busIdx, effectIdx, channel);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "swap_bus_effects");

        /// <summary>
        /// <para>Swaps the position of two effects in bus <c>bus_idx</c>.</para>
        /// </summary>
        [GodotMethod("swap_bus_effects")]
        public static void SwapBusEffects(int busIdx, int effectIdx, int byEffectIdx)
        {
            NativeCalls.godot_icall_3_176(method_bind_24, ptr, busIdx, effectIdx, byEffectIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bus_effect_enabled");

        /// <summary>
        /// <para>If <c>true</c>, the effect at index <c>effect_idx</c> on the bus at index <c>bus_idx</c> is enabled.</para>
        /// </summary>
        [GodotMethod("set_bus_effect_enabled")]
        public static void SetBusEffectEnabled(int busIdx, int effectIdx, bool enabled)
        {
            NativeCalls.godot_icall_3_37(method_bind_25, ptr, busIdx, effectIdx, enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_bus_effect_enabled");

        /// <summary>
        /// <para>If <c>true</c>, the effect at index <c>effect_idx</c> on the bus at index <c>bus_idx</c> is enabled.</para>
        /// </summary>
        [GodotMethod("is_bus_effect_enabled")]
        public static bool IsBusEffectEnabled(int busIdx, int effectIdx)
        {
            return NativeCalls.godot_icall_2_177(method_bind_26, ptr, busIdx, effectIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bus_peak_volume_left_db");

        /// <summary>
        /// <para>Returns the peak volume of the left speaker at bus index <c>bus_idx</c> and channel index <c>channel</c>.</para>
        /// </summary>
        [GodotMethod("get_bus_peak_volume_left_db")]
        public static float GetBusPeakVolumeLeftDb(int busIdx, int channel)
        {
            return NativeCalls.godot_icall_2_70(method_bind_27, ptr, busIdx, channel);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bus_peak_volume_right_db");

        /// <summary>
        /// <para>Returns the peak volume of the right speaker at bus index <c>bus_idx</c> and channel index <c>channel</c>.</para>
        /// </summary>
        [GodotMethod("get_bus_peak_volume_right_db")]
        public static float GetBusPeakVolumeRightDb(int busIdx, int channel)
        {
            return NativeCalls.godot_icall_2_70(method_bind_28, ptr, busIdx, channel);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_global_rate_scale");

        [GodotMethod("set_global_rate_scale")]
        [Obsolete("SetGlobalRateScale is deprecated. Use the GlobalRateScale property instead.")]
        public static void SetGlobalRateScale(float scale)
        {
            NativeCalls.godot_icall_1_15(method_bind_29, ptr, scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_global_rate_scale");

        [GodotMethod("get_global_rate_scale")]
        [Obsolete("GetGlobalRateScale is deprecated. Use the GlobalRateScale property instead.")]
        public static float GetGlobalRateScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_30, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "lock");

        /// <summary>
        /// <para>Locks the audio driver's main loop.</para>
        /// <para>Note: Remember to unlock it afterwards.</para>
        /// </summary>
        [GodotMethod("lock")]
        public static void Lock()
        {
            NativeCalls.godot_icall_0_3(method_bind_31, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "unlock");

        /// <summary>
        /// <para>Unlocks the audio driver's main loop. (After locking it, you should always unlock it.)</para>
        /// </summary>
        [GodotMethod("unlock")]
        public static void Unlock()
        {
            NativeCalls.godot_icall_0_3(method_bind_32, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_speaker_mode");

        /// <summary>
        /// <para>Returns the speaker configuration.</para>
        /// </summary>
        [GodotMethod("get_speaker_mode")]
        public static AudioServer.SpeakerMode GetSpeakerMode()
        {
            return (AudioServer.SpeakerMode)NativeCalls.godot_icall_0_178(method_bind_33, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mix_rate");

        /// <summary>
        /// <para>Returns the sample rate at the output of the <see cref="Godot.AudioServer"/>.</para>
        /// </summary>
        [GodotMethod("get_mix_rate")]
        public static float GetMixRate()
        {
            return NativeCalls.godot_icall_0_14(method_bind_34, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_device_list");

        /// <summary>
        /// <para>Returns the names of all audio devices detected on the system.</para>
        /// </summary>
        [GodotMethod("get_device_list")]
        public static Godot.Collections.Array GetDeviceList()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_35, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_device");

        [GodotMethod("get_device")]
        [Obsolete("GetDevice is deprecated. Use the Device property instead.")]
        public static string GetDevice()
        {
            return NativeCalls.godot_icall_0_6(method_bind_36, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_device");

        [GodotMethod("set_device")]
        [Obsolete("SetDevice is deprecated. Use the Device property instead.")]
        public static void SetDevice(string device)
        {
            NativeCalls.godot_icall_1_54(method_bind_37, ptr, device);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_time_to_next_mix");

        /// <summary>
        /// <para>Returns the relative time until the next mix occurs.</para>
        /// </summary>
        [GodotMethod("get_time_to_next_mix")]
        public static double GetTimeToNextMix()
        {
            return NativeCalls.godot_icall_0_179(method_bind_38, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_time_since_last_mix");

        /// <summary>
        /// <para>Returns the relative time since the last mix occurred.</para>
        /// </summary>
        [GodotMethod("get_time_since_last_mix")]
        public static double GetTimeSinceLastMix()
        {
            return NativeCalls.godot_icall_0_179(method_bind_39, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_output_latency");

        /// <summary>
        /// <para>Returns the audio driver's output latency.</para>
        /// </summary>
        [GodotMethod("get_output_latency")]
        public static double GetOutputLatency()
        {
            return NativeCalls.godot_icall_0_179(method_bind_40, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "capture_get_device_list");

        /// <summary>
        /// <para>Returns the names of all audio input devices detected on the system.</para>
        /// <para>Note:  must be <c>true</c> for audio input to work. See also that setting's description for caveats related to permissions and operating system privacy settings.</para>
        /// </summary>
        [GodotMethod("capture_get_device_list")]
        public static Godot.Collections.Array CaptureGetDeviceList()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_41, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "capture_get_device");

        [GodotMethod("capture_get_device")]
        [Obsolete("CaptureGetDevice is deprecated. Use the CaptureDevice property instead.")]
        public static string CaptureGetDevice()
        {
            return NativeCalls.godot_icall_0_6(method_bind_42, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "capture_set_device");

        [GodotMethod("capture_set_device")]
        [Obsolete("CaptureSetDevice is deprecated. Use the CaptureDevice property instead.")]
        public static void CaptureSetDevice(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_43, ptr, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bus_layout");

        /// <summary>
        /// <para>Overwrites the currently used <see cref="Godot.AudioBusLayout"/>.</para>
        /// </summary>
        [GodotMethod("set_bus_layout")]
        public static void SetBusLayout(AudioBusLayout busLayout)
        {
            NativeCalls.godot_icall_1_24(method_bind_44, ptr, Object.GetPtr(busLayout));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "generate_bus_layout");

        /// <summary>
        /// <para>Generates an <see cref="Godot.AudioBusLayout"/> using the available buses and effects.</para>
        /// </summary>
        [GodotMethod("generate_bus_layout")]
        public static AudioBusLayout GenerateBusLayout()
        {
            return NativeCalls.godot_icall_0_180(method_bind_45, ptr);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
