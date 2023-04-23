using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A simple server that opens a UDP socket and returns connected <see cref="Godot.PacketPeerUDP"/> upon receiving new packets. See also <see cref="Godot.PacketPeerUDP.ConnectToHost"/>.</para>
    /// <para>After starting the server (<see cref="Godot.UDPServer.Listen"/>), you will need to <see cref="Godot.UDPServer.Poll"/> it at regular intervals (e.g. inside <see cref="Godot.Node._Process"/>) for it to process new packets, delivering them to the appropriate <see cref="Godot.PacketPeerUDP"/>, and taking new connections.</para>
    /// <para>Below a small example of how it can be used:</para>
    /// <para><code>
    /// # server.gd
    /// extends Node
    /// 
    /// var server := UDPServer.new()
    /// var peers = []
    /// 
    /// func _ready():
    ///     server.listen(4242)
    /// 
    /// func _process(delta):
    ///     server.poll() # Important!
    ///     if server.is_connection_available():
    ///         var peer : PacketPeerUDP = server.take_connection()
    ///         var pkt = peer.get_packet()
    ///         print("Accepted peer: %s:%s" % [peer.get_packet_ip(), peer.get_packet_port()])
    ///         print("Received data: %s" % [pkt.get_string_from_utf8()])
    ///         # Reply so it knows we received the message.
    ///         peer.put_packet(pkt)
    ///         # Keep a reference so we can keep contacting the remote peer.
    ///         peers.append(peer)
    /// 
    ///     for i in range(0, peers.size()):
    ///         pass # Do something with the connected peers.
    /// 
    /// </code></para>
    /// <para><code>
    /// # client.gd
    /// extends Node
    /// 
    /// var udp := PacketPeerUDP.new()
    /// var connected = false
    /// 
    /// func _ready():
    ///     udp.connect_to_host("127.0.0.1", 4242)
    /// 
    /// func _process(delta):
    ///     if !connected:
    ///         # Try to contact server
    ///         udp.put_packet("The answer is... 42!".to_utf8())
    ///     if udp.get_available_packet_count() &gt; 0:
    ///         print("Connected: %s" % udp.get_packet().get_string_from_utf8())
    ///         connected = true
    /// </code></para>
    /// </summary>
    public partial class UDPServer : Reference
    {
        /// <summary>
        /// <para>Define the maximum number of pending connections, during <see cref="Godot.UDPServer.Poll"/>, any new pending connection exceeding that value will be automatically dropped. Setting this value to <c>0</c> effectively prevents any new pending connection to be accepted (e.g. when all your players have connected).</para>
        /// </summary>
        public int MaxPendingConnections
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaxPendingConnections();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaxPendingConnections(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "UDPServer";

        public UDPServer() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_UDPServer_Ctor(this);
        }

        internal UDPServer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "listen");

        /// <summary>
        /// <para>Starts the server by opening a UDP socket listening on the given port. You can optionally specify a <c>bind_address</c> to only listen for packets sent to that address. See also <see cref="Godot.PacketPeerUDP.Listen"/>.</para>
        /// </summary>
        [GodotMethod("listen")]
        public Error Listen(ushort port, string bindAddress = "*")
        {
            return (Error)NativeCalls.godot_icall_2_910(method_bind_0, Object.GetPtr(this), port, bindAddress);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "poll");

        /// <summary>
        /// <para>Call this method at regular intervals (e.g. inside <see cref="Godot.Node._Process"/>) to process new packets. And packet from known address/port pair will be delivered to the appropriate <see cref="Godot.PacketPeerUDP"/>, any packet received from an unknown address/port pair will be added as a pending connection (see <see cref="Godot.UDPServer.IsConnectionAvailable"/>, <see cref="Godot.UDPServer.TakeConnection"/>). The maximum number of pending connection is defined via <see cref="Godot.UDPServer.MaxPendingConnections"/>.</para>
        /// </summary>
        [GodotMethod("poll")]
        public Error Poll()
        {
            return (Error)NativeCalls.godot_icall_0_389(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_connection_available");

        /// <summary>
        /// <para>Returns <c>true</c> if a packet with a new address/port combination was received on the socket.</para>
        /// </summary>
        [GodotMethod("is_connection_available")]
        public bool IsConnectionAvailable()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_listening");

        /// <summary>
        /// <para>Returns <c>true</c> if the socket is open and listening on a port.</para>
        /// </summary>
        [GodotMethod("is_listening")]
        public bool IsListening()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "take_connection");

        /// <summary>
        /// <para>Returns the first pending connection (connected to the appropriate address/port). Will return <c>null</c> if no new connection is available. See also <see cref="Godot.UDPServer.IsConnectionAvailable"/>, <see cref="Godot.PacketPeerUDP.ConnectToHost"/>.</para>
        /// </summary>
        [GodotMethod("take_connection")]
        public PacketPeerUDP TakeConnection()
        {
            return NativeCalls.godot_icall_0_999(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "stop");

        /// <summary>
        /// <para>Stops the server, closing the UDP socket if open. Will close all connected <see cref="Godot.PacketPeerUDP"/> accepted via <see cref="Godot.UDPServer.TakeConnection"/> (remote peers will not be notified).</para>
        /// </summary>
        [GodotMethod("stop")]
        public void Stop()
        {
            NativeCalls.godot_icall_0_3(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max_pending_connections");

        [GodotMethod("set_max_pending_connections")]
        [Obsolete("SetMaxPendingConnections is deprecated. Use the MaxPendingConnections property instead.")]
        public void SetMaxPendingConnections(int maxPendingConnections)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), maxPendingConnections);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max_pending_connections");

        [GodotMethod("get_max_pending_connections")]
        [Obsolete("GetMaxPendingConnections is deprecated. Use the MaxPendingConnections property instead.")]
        public int GetMaxPendingConnections()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
