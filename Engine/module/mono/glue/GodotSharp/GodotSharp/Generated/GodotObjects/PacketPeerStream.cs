using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>PacketStreamPeer provides a wrapper for working using packets over a stream. This allows for using packet based code with StreamPeers. PacketPeerStream implements a custom protocol over the StreamPeer, so the user should not read or write to the wrapped StreamPeer directly.</para>
    /// </summary>
    public partial class PacketPeerStream : PacketPeer
    {
        public int InputBufferMaxSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputBufferMaxSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputBufferMaxSize(value);
            }
#pragma warning restore CS0618
        }

        public int OutputBufferMaxSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOutputBufferMaxSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOutputBufferMaxSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The wrapped <see cref="Godot.StreamPeer"/> object.</para>
        /// </summary>
        public StreamPeer StreamPeer
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetStreamPeer();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetStreamPeer(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "PacketPeerStream";

        public PacketPeerStream() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PacketPeerStream_Ctor(this);
        }

        internal PacketPeerStream(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_stream_peer");

        [GodotMethod("set_stream_peer")]
        [Obsolete("SetStreamPeer is deprecated. Use the StreamPeer property instead.")]
        public void SetStreamPeer(StreamPeer peer)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(peer));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stream_peer");

        [GodotMethod("get_stream_peer")]
        [Obsolete("GetStreamPeer is deprecated. Use the StreamPeer property instead.")]
        public StreamPeer GetStreamPeer()
        {
            return NativeCalls.godot_icall_0_489(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_input_buffer_max_size");

        [GodotMethod("set_input_buffer_max_size")]
        [Obsolete("SetInputBufferMaxSize is deprecated. Use the InputBufferMaxSize property instead.")]
        public void SetInputBufferMaxSize(int maxSizeBytes)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), maxSizeBytes);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_output_buffer_max_size");

        [GodotMethod("set_output_buffer_max_size")]
        [Obsolete("SetOutputBufferMaxSize is deprecated. Use the OutputBufferMaxSize property instead.")]
        public void SetOutputBufferMaxSize(int maxSizeBytes)
        {
            NativeCalls.godot_icall_1_4(method_bind_3, Object.GetPtr(this), maxSizeBytes);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_input_buffer_max_size");

        [GodotMethod("get_input_buffer_max_size")]
        [Obsolete("GetInputBufferMaxSize is deprecated. Use the InputBufferMaxSize property instead.")]
        public int GetInputBufferMaxSize()
        {
            return NativeCalls.godot_icall_0_5(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_output_buffer_max_size");

        [GodotMethod("get_output_buffer_max_size")]
        [Obsolete("GetOutputBufferMaxSize is deprecated. Use the OutputBufferMaxSize property instead.")]
        public int GetOutputBufferMaxSize()
        {
            return NativeCalls.godot_icall_0_5(method_bind_5, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
