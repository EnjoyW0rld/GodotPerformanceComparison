using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Allows the user to record the sound from an audio bus. This can include all audio output by Godot when used on the "Master" audio bus.</para>
    /// <para>Can be used (with an <see cref="Godot.AudioStreamMicrophone"/>) to record from a microphone.</para>
    /// <para>It sets and gets the format in which the audio file will be recorded (8-bit, 16-bit, or compressed). It checks whether or not the recording is active, and if it is, records the sound. It then returns the recorded sample.</para>
    /// </summary>
    public partial class AudioEffectRecord : AudioEffect
    {
        /// <summary>
        /// <para>Specifies the format in which the sample will be recorded. See <see cref="Godot.AudioStreamSample.FormatEnum"/> for available formats.</para>
        /// </summary>
        public AudioStreamSample.FormatEnum Format
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFormat();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFormat(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AudioEffectRecord";

        public AudioEffectRecord() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectRecord_Ctor(this);
        }

        internal AudioEffectRecord(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_recording_active");

        /// <summary>
        /// <para>If <c>true</c>, the sound will be recorded. Note that restarting the recording will remove the previously recorded sample.</para>
        /// </summary>
        [GodotMethod("set_recording_active")]
        public void SetRecordingActive(bool record)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), record);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_recording_active");

        /// <summary>
        /// <para>Returns whether the recording is active or not.</para>
        /// </summary>
        [GodotMethod("is_recording_active")]
        public bool IsRecordingActive()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_format");

        [GodotMethod("set_format")]
        [Obsolete("SetFormat is deprecated. Use the Format property instead.")]
        public void SetFormat(AudioStreamSample.FormatEnum format)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)format);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_format");

        [GodotMethod("get_format")]
        [Obsolete("GetFormat is deprecated. Use the Format property instead.")]
        public AudioStreamSample.FormatEnum GetFormat()
        {
            return (AudioStreamSample.FormatEnum)NativeCalls.godot_icall_0_169(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_recording");

        /// <summary>
        /// <para>Returns the recorded sample.</para>
        /// </summary>
        [GodotMethod("get_recording")]
        public AudioStreamSample GetRecording()
        {
            return NativeCalls.godot_icall_0_170(method_bind_4, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
