using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>OGG Vorbis audio stream driver.</para>
    /// </summary>
    public partial class AudioStreamOGGVorbis : AudioStream
    {
        /// <summary>
        /// <para>Contains the audio data in bytes.</para>
        /// </summary>
        public byte[] Data
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetData();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetData(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the stream will automatically loop when it reaches the end.</para>
        /// </summary>
        public bool Loop
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return HasLoop();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLoop(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Time in seconds at which the stream starts after being looped.</para>
        /// </summary>
        public float LoopOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLoopOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLoopOffset(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AudioStreamOGGVorbis";

        public AudioStreamOGGVorbis() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioStreamOGGVorbis_Ctor(this);
        }

        internal AudioStreamOGGVorbis(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_data");

        [GodotMethod("set_data")]
        [Obsolete("SetData is deprecated. Use the Data property instead.")]
        public void SetData(byte[] data)
        {
            NativeCalls.godot_icall_1_183(method_bind_0, Object.GetPtr(this), data);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_data");

        [GodotMethod("get_data")]
        [Obsolete("GetData is deprecated. Use the Data property instead.")]
        public byte[] GetData()
        {
            return NativeCalls.godot_icall_0_2(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_loop");

        [GodotMethod("set_loop")]
        [Obsolete("SetLoop is deprecated. Use the Loop property instead.")]
        public void SetLoop(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_loop");

        [GodotMethod("has_loop")]
        [Obsolete("HasLoop is deprecated. Use the Loop property instead.")]
        public bool HasLoop()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_loop_offset");

        [GodotMethod("set_loop_offset")]
        [Obsolete("SetLoopOffset is deprecated. Use the LoopOffset property instead.")]
        public void SetLoopOffset(float seconds)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), seconds);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_loop_offset");

        [GodotMethod("get_loop_offset")]
        [Obsolete("GetLoopOffset is deprecated. Use the LoopOffset property instead.")]
        public float GetLoopOffset()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
