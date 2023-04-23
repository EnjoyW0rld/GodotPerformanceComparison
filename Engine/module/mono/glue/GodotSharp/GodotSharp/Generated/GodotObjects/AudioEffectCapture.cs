using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>AudioEffectCapture is an AudioEffect which copies all audio frames from the attached audio effect bus into its internal ring buffer.</para>
    /// <para>Application code should consume these audio frames from this ring buffer using <see cref="Godot.AudioEffectCapture.GetBuffer"/> and process it as needed, for example to capture data from an <see cref="Godot.AudioStreamMicrophone"/>, implement application-defined effects, or to transmit audio over the network. When capturing audio data from a microphone, the format of the samples will be stereo 32-bit floating point PCM.</para>
    /// <para>Note:  must be <c>true</c> for audio input to work. See also that setting's description for caveats related to permissions and operating system privacy settings.</para>
    /// </summary>
    public partial class AudioEffectCapture : AudioEffect
    {
        /// <summary>
        /// <para>Length of the internal ring buffer, in seconds. Setting the buffer length will have no effect if already initialized.</para>
        /// </summary>
        public float BufferLength
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBufferLength();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBufferLength(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AudioEffectCapture";

        public AudioEffectCapture() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectCapture_Ctor(this);
        }

        internal AudioEffectCapture(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "can_get_buffer");

        /// <summary>
        /// <para>Returns <c>true</c> if at least <c>frames</c> audio frames are available to read in the internal ring buffer.</para>
        /// </summary>
        [GodotMethod("can_get_buffer")]
        public bool CanGetBuffer(int frames)
        {
            return NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), frames);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_buffer");

        /// <summary>
        /// <para>Gets the next <c>frames</c> audio samples from the internal ring buffer.</para>
        /// <para>Returns a <see cref="Godot.Vector2"/> containing exactly <c>frames</c> audio samples if available, or an empty <see cref="Godot.Vector2"/> if insufficient data was available.</para>
        /// </summary>
        [GodotMethod("get_buffer")]
        public Vector2[] GetBuffer(int frames)
        {
            return NativeCalls.godot_icall_1_164(method_bind_1, Object.GetPtr(this), frames);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_buffer");

        /// <summary>
        /// <para>Clears the internal ring buffer.</para>
        /// </summary>
        [GodotMethod("clear_buffer")]
        public void ClearBuffer()
        {
            NativeCalls.godot_icall_0_3(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_buffer_length");

        [GodotMethod("set_buffer_length")]
        [Obsolete("SetBufferLength is deprecated. Use the BufferLength property instead.")]
        public void SetBufferLength(float bufferLengthSeconds)
        {
            NativeCalls.godot_icall_1_15(method_bind_3, Object.GetPtr(this), bufferLengthSeconds);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_buffer_length");

        [GodotMethod("get_buffer_length")]
        [Obsolete("GetBufferLength is deprecated. Use the BufferLength property instead.")]
        public float GetBufferLength()
        {
            return NativeCalls.godot_icall_0_14(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_frames_available");

        /// <summary>
        /// <para>Returns the number of frames available to read using <see cref="Godot.AudioEffectCapture.GetBuffer"/>.</para>
        /// </summary>
        [GodotMethod("get_frames_available")]
        public int GetFramesAvailable()
        {
            return NativeCalls.godot_icall_0_5(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_discarded_frames");

        /// <summary>
        /// <para>Returns the number of audio frames discarded from the audio bus due to full buffer.</para>
        /// </summary>
        [GodotMethod("get_discarded_frames")]
        public long GetDiscardedFrames()
        {
            return NativeCalls.godot_icall_0_165(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_buffer_length_frames");

        /// <summary>
        /// <para>Returns the total size of the internal ring buffer in frames.</para>
        /// </summary>
        [GodotMethod("get_buffer_length_frames")]
        public int GetBufferLengthFrames()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pushed_frames");

        /// <summary>
        /// <para>Returns the number of audio frames inserted from the audio bus.</para>
        /// </summary>
        [GodotMethod("get_pushed_frames")]
        public long GetPushedFrames()
        {
            return NativeCalls.godot_icall_0_165(method_bind_8, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
