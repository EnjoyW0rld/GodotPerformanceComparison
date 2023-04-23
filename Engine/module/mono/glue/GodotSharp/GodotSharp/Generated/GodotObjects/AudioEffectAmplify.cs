using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Increases or decreases the volume being routed through the audio bus.</para>
    /// </summary>
    public partial class AudioEffectAmplify : AudioEffect
    {
        /// <summary>
        /// <para>Amount of amplification in decibels. Positive values make the sound louder, negative values make it quieter. Value can range from -80 to 24.</para>
        /// </summary>
        public float VolumeDb
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVolumeDb();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVolumeDb(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AudioEffectAmplify";

        public AudioEffectAmplify() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectAmplify_Ctor(this);
        }

        internal AudioEffectAmplify(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_volume_db");

        [GodotMethod("set_volume_db")]
        [Obsolete("SetVolumeDb is deprecated. Use the VolumeDb property instead.")]
        public void SetVolumeDb(float volume)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), volume);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_volume_db");

        [GodotMethod("get_volume_db")]
        [Obsolete("GetVolumeDb is deprecated. Use the VolumeDb property instead.")]
        public float GetVolumeDb()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
