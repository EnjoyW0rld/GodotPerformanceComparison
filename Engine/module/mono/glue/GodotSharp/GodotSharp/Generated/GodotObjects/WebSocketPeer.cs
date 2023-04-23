using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This class represents a specific WebSocket connection, allowing you to do lower level operations with it.</para>
    /// <para>You can choose to write to the socket in binary or text mode, and you can recognize the mode used for writing by the other peer.</para>
    /// </summary>
    public partial class WebSocketPeer : PacketPeer
    {
        public enum WriteMode
        {
            /// <summary>
            /// <para>Specifies that WebSockets messages should be transferred as text payload (only valid UTF-8 is allowed).</para>
            /// </summary>
            Text = 0,
            /// <summary>
            /// <para>Specifies that WebSockets messages should be transferred as binary payload (any byte combination is allowed).</para>
            /// </summary>
            Binary = 1
        }

        private const string nativeName = "WebSocketPeer";

        public WebSocketPeer() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_WebSocketPeer_Ctor(this);
        }

        internal WebSocketPeer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_write_mode");

        /// <summary>
        /// <para>Gets the current selected write mode. See <see cref="Godot.WebSocketPeer.WriteMode"/>.</para>
        /// </summary>
        [GodotMethod("get_write_mode")]
        public WebSocketPeer.WriteMode GetWriteMode()
        {
            return (WebSocketPeer.WriteMode)NativeCalls.godot_icall_0_1161(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_write_mode");

        /// <summary>
        /// <para>Sets the socket to use the given <see cref="Godot.WebSocketPeer.WriteMode"/>.</para>
        /// </summary>
        [GodotMethod("set_write_mode")]
        public void SetWriteMode(WebSocketPeer.WriteMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_1, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_connected_to_host");

        /// <summary>
        /// <para>Returns <c>true</c> if this peer is currently connected.</para>
        /// </summary>
        [GodotMethod("is_connected_to_host")]
        public bool IsConnectedToHost()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "was_string_packet");

        /// <summary>
        /// <para>Returns <c>true</c> if the last received packet was sent as a text payload. See <see cref="Godot.WebSocketPeer.WriteMode"/>.</para>
        /// </summary>
        [GodotMethod("was_string_packet")]
        public bool WasStringPacket()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "close");

        /// <summary>
        /// <para>Closes this WebSocket connection. <c>code</c> is the status code for the closure (see RFC 6455 section 7.4 for a list of valid status codes). <c>reason</c> is the human readable reason for closing the connection (can be any UTF-8 string that's smaller than 123 bytes).</para>
        /// <para>Note: To achieve a clean close, you will need to keep polling until either <c>WebSocketClient.connection_closed</c> or <c>WebSocketServer.client_disconnected</c> is received.</para>
        /// <para>Note: The HTML5 export might not support all status codes. Please refer to browser-specific documentation for more details.</para>
        /// </summary>
        [GodotMethod("close")]
        public void Close(int code = 1000, string reason = "")
        {
            NativeCalls.godot_icall_2_121(method_bind_4, Object.GetPtr(this), code, reason);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connected_host");

        /// <summary>
        /// <para>Returns the IP address of the connected peer.</para>
        /// <para>Note: Not available in the HTML5 export.</para>
        /// </summary>
        [GodotMethod("get_connected_host")]
        public string GetConnectedHost()
        {
            return NativeCalls.godot_icall_0_6(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connected_port");

        /// <summary>
        /// <para>Returns the remote port of the connected peer.</para>
        /// <para>Note: Not available in the HTML5 export.</para>
        /// </summary>
        [GodotMethod("get_connected_port")]
        public ushort GetConnectedPort()
        {
            return NativeCalls.godot_icall_0_895(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_no_delay");

        /// <summary>
        /// <para>Disable Nagle's algorithm on the underling TCP socket (default). See <see cref="Godot.StreamPeerTCP.SetNoDelay"/> for more information.</para>
        /// <para>Note: Not available in the HTML5 export.</para>
        /// </summary>
        [GodotMethod("set_no_delay")]
        public void SetNoDelay(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_7, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_outbound_buffered_amount");

        /// <summary>
        /// <para>Returns the current amount of data in the outbound websocket buffer. Note: HTML5 exports use WebSocket.bufferedAmount, while other platforms use an internal buffer.</para>
        /// </summary>
        [GodotMethod("get_current_outbound_buffered_amount")]
        public int GetCurrentOutboundBufferedAmount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_8, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
