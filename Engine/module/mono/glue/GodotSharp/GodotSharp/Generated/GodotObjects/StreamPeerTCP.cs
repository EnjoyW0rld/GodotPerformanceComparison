using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>TCP stream peer. This object can be used to connect to TCP servers, or also is returned by a TCP server.</para>
    /// </summary>
    public partial class StreamPeerTCP : StreamPeer
    {
        public enum Status
        {
            /// <summary>
            /// <para>The initial status of the <see cref="Godot.StreamPeerTCP"/>. This is also the status after disconnecting.</para>
            /// </summary>
            None = 0,
            /// <summary>
            /// <para>A status representing a <see cref="Godot.StreamPeerTCP"/> that is connecting to a host.</para>
            /// </summary>
            Connecting = 1,
            /// <summary>
            /// <para>A status representing a <see cref="Godot.StreamPeerTCP"/> that is connected to a host.</para>
            /// </summary>
            Connected = 2,
            /// <summary>
            /// <para>A status representing a <see cref="Godot.StreamPeerTCP"/> in error state.</para>
            /// </summary>
            Error = 3
        }

        private const string nativeName = "StreamPeerTCP";

        public StreamPeerTCP() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_StreamPeerTCP_Ctor(this);
        }

        internal StreamPeerTCP(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "connect_to_host");

        /// <summary>
        /// <para>Connects to the specified <c>host:port</c> pair. A hostname will be resolved if valid. Returns <c>OK</c> on success or <c>FAILED</c> on failure.</para>
        /// </summary>
        [GodotMethod("connect_to_host")]
        public Error ConnectToHost(string host, int port)
        {
            return (Error)NativeCalls.godot_icall_2_709(method_bind_0, Object.GetPtr(this), host, port);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_connected_to_host");

        /// <summary>
        /// <para>Returns <c>true</c> if this peer is currently connected or is connecting to a host, <c>false</c> otherwise.</para>
        /// </summary>
        [GodotMethod("is_connected_to_host")]
        public bool IsConnectedToHost()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_status");

        /// <summary>
        /// <para>Returns the status of the connection, see <see cref="Godot.StreamPeerTCP.Status"/>.</para>
        /// </summary>
        [GodotMethod("get_status")]
        public StreamPeerTCP.Status GetStatus()
        {
            return (StreamPeerTCP.Status)NativeCalls.godot_icall_0_899(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connected_host");

        /// <summary>
        /// <para>Returns the IP of this peer.</para>
        /// </summary>
        [GodotMethod("get_connected_host")]
        public string GetConnectedHost()
        {
            return NativeCalls.godot_icall_0_6(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connected_port");

        /// <summary>
        /// <para>Returns the port of this peer.</para>
        /// </summary>
        [GodotMethod("get_connected_port")]
        public ushort GetConnectedPort()
        {
            return NativeCalls.godot_icall_0_895(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "disconnect_from_host");

        /// <summary>
        /// <para>Disconnects from host.</para>
        /// </summary>
        [GodotMethod("disconnect_from_host")]
        public void DisconnectFromHost()
        {
            NativeCalls.godot_icall_0_3(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_no_delay");

        /// <summary>
        /// <para>If <c>enabled</c> is <c>true</c>, packets will be sent immediately. If <c>enabled</c> is <c>false</c> (the default), packet transfers will be delayed and combined using <a href="https://en.wikipedia.org/wiki/Nagle%27s_algorithm">Nagle's algorithm</a>.</para>
        /// <para>Note: It's recommended to leave this disabled for applications that send large packets or need to transfer a lot of data, as enabling this can decrease the total available bandwidth.</para>
        /// </summary>
        [GodotMethod("set_no_delay")]
        public void SetNoDelay(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), enabled);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
