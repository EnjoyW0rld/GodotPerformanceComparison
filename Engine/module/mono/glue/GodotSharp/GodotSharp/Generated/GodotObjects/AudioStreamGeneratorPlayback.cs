using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This class is meant to be used with <see cref="Godot.AudioStreamGenerator"/> to play back the generated audio in real-time.</para>
    /// </summary>
    public abstract partial class AudioStreamGeneratorPlayback : AudioStreamPlaybackResampled
    {
        private const string nativeName = "AudioStreamGeneratorPlayback";

        internal AudioStreamGeneratorPlayback() {}

        internal AudioStreamGeneratorPlayback(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "push_frame");

        /// <summary>
        /// <para>Pushes a single audio data frame to the buffer. This is usually less efficient than <see cref="Godot.AudioStreamGeneratorPlayback.PushBuffer"/> in C# and compiled languages via GDNative, but <see cref="Godot.AudioStreamGeneratorPlayback.PushFrame"/> may be more efficient in GDScript.</para>
        /// </summary>
        [GodotMethod("push_frame")]
        public bool PushFrame(Vector2 frame)
        {
            return NativeCalls.godot_icall_1_181(method_bind_0, Object.GetPtr(this), ref frame);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "can_push_buffer");

        /// <summary>
        /// <para>Returns <c>true</c> if a buffer of the size <c>amount</c> can be pushed to the audio sample data buffer without overflowing it, <c>false</c> otherwise.</para>
        /// </summary>
        [GodotMethod("can_push_buffer")]
        public bool CanPushBuffer(int amount)
        {
            return NativeCalls.godot_icall_1_35(method_bind_1, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "push_buffer");

        /// <summary>
        /// <para>Pushes several audio data frames to the buffer. This is usually more efficient than <see cref="Godot.AudioStreamGeneratorPlayback.PushFrame"/> in C# and compiled languages via GDNative, but <see cref="Godot.AudioStreamGeneratorPlayback.PushBuffer"/> may be less efficient in GDScript.</para>
        /// </summary>
        [GodotMethod("push_buffer")]
        public bool PushBuffer(Vector2[] frames)
        {
            return NativeCalls.godot_icall_1_182(method_bind_2, Object.GetPtr(this), frames);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_frames_available");

        /// <summary>
        /// <para>Returns the number of frames that can be pushed to the audio sample data buffer without overflowing it. If the result is <c>0</c>, the buffer is full.</para>
        /// </summary>
        [GodotMethod("get_frames_available")]
        public int GetFramesAvailable()
        {
            return NativeCalls.godot_icall_0_5(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_skips");

        [GodotMethod("get_skips")]
        public int GetSkips()
        {
            return NativeCalls.godot_icall_0_5(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_buffer");

        /// <summary>
        /// <para>Clears the audio sample data buffer.</para>
        /// </summary>
        [GodotMethod("clear_buffer")]
        public void ClearBuffer()
        {
            NativeCalls.godot_icall_0_3(method_bind_5, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
