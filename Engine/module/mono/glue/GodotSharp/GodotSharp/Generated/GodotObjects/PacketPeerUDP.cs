using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>UDP packet peer. Can be used to send raw UDP packets as well as <c>Variant</c>s.</para>
    /// </summary>
    public partial class PacketPeerUDP : PacketPeer
    {
        private const string nativeName = "PacketPeerUDP";

        public PacketPeerUDP() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PacketPeerUDP_Ctor(this);
        }

        internal PacketPeerUDP(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "listen");

        /// <summary>
        /// <para>Makes this <see cref="Godot.PacketPeerUDP"/> listen on the <c>port</c> binding to <c>bind_address</c> with a buffer size <c>recv_buf_size</c>.</para>
        /// <para>If <c>bind_address</c> is set to <c>"*"</c> (default), the peer will listen on all available addresses (both IPv4 and IPv6).</para>
        /// <para>If <c>bind_address</c> is set to <c>"0.0.0.0"</c> (for IPv4) or <c>"::"</c> (for IPv6), the peer will listen on all available addresses matching that IP type.</para>
        /// <para>If <c>bind_address</c> is set to any valid address (e.g. <c>"192.168.1.101"</c>, <c>"::1"</c>, etc), the peer will only listen on the interface with that addresses (or fail if no interface with the given address exists).</para>
        /// </summary>
        [GodotMethod("listen")]
        public Error Listen(int port, string bindAddress = "*", int recvBufSize = 65536)
        {
            return (Error)NativeCalls.godot_icall_3_720(method_bind_0, Object.GetPtr(this), port, bindAddress, recvBufSize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "close");

        /// <summary>
        /// <para>Closes the UDP socket the <see cref="Godot.PacketPeerUDP"/> is currently listening on.</para>
        /// </summary>
        [GodotMethod("close")]
        public void Close()
        {
            NativeCalls.godot_icall_0_3(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "wait");

        /// <summary>
        /// <para>Waits for a packet to arrive on the listening port. See <see cref="Godot.PacketPeerUDP.Listen"/>.</para>
        /// <para>Note: <see cref="Godot.PacketPeerUDP.Wait"/> can't be interrupted once it has been called. This can be worked around by allowing the other party to send a specific "death pill" packet like this:</para>
        /// <para><code>
        /// # Server
        /// socket.set_dest_address("127.0.0.1", 789)
        /// socket.put_packet("Time to stop".to_ascii())
        /// 
        /// # Client
        /// while socket.wait() == OK:
        ///     var data = socket.get_packet().get_string_from_ascii()
        ///     if data == "Time to stop":
        ///         return
        /// </code></para>
        /// </summary>
        [GodotMethod("wait")]
        public Error Wait()
        {
            return (Error)NativeCalls.godot_icall_0_389(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_listening");

        /// <summary>
        /// <para>Returns whether this <see cref="Godot.PacketPeerUDP"/> is listening.</para>
        /// </summary>
        [GodotMethod("is_listening")]
        public bool IsListening()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "connect_to_host");

        /// <summary>
        /// <para>Calling this method connects this UDP peer to the given <c>host</c>/<c>port</c> pair. UDP is in reality connectionless, so this option only means that incoming packets from different addresses are automatically discarded, and that outgoing packets are always sent to the connected address (future calls to <see cref="Godot.PacketPeerUDP.SetDestAddress"/> are not allowed). This method does not send any data to the remote peer, to do that, use <see cref="Godot.PacketPeer.PutVar"/> or <see cref="Godot.PacketPeer.PutPacket"/> as usual. See also <see cref="Godot.UDPServer"/>.</para>
        /// <para>Note: Connecting to the remote peer does not help to protect from malicious attacks like IP spoofing, etc. Think about using an encryption technique like SSL or DTLS if you feel like your application is transferring sensitive information.</para>
        /// </summary>
        [GodotMethod("connect_to_host")]
        public Error ConnectToHost(string host, int port)
        {
            return (Error)NativeCalls.godot_icall_2_709(method_bind_4, Object.GetPtr(this), host, port);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_connected_to_host");

        /// <summary>
        /// <para>Returns <c>true</c> if the UDP socket is open and has been connected to a remote address. See <see cref="Godot.PacketPeerUDP.ConnectToHost"/>.</para>
        /// </summary>
        [GodotMethod("is_connected_to_host")]
        public bool IsConnectedToHost()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_packet_ip");

        /// <summary>
        /// <para>Returns the IP of the remote peer that sent the last packet(that was received with <see cref="Godot.PacketPeer.GetPacket"/> or <see cref="Godot.PacketPeer.GetVar"/>).</para>
        /// </summary>
        [GodotMethod("get_packet_ip")]
        public string GetPacketIp()
        {
            return NativeCalls.godot_icall_0_6(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_packet_port");

        /// <summary>
        /// <para>Returns the port of the remote peer that sent the last packet(that was received with <see cref="Godot.PacketPeer.GetPacket"/> or <see cref="Godot.PacketPeer.GetVar"/>).</para>
        /// </summary>
        [GodotMethod("get_packet_port")]
        public int GetPacketPort()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dest_address");

        /// <summary>
        /// <para>Sets the destination address and port for sending packets and variables. A hostname will be resolved using DNS if needed.</para>
        /// <para>Note: <see cref="Godot.PacketPeerUDP.SetBroadcastEnabled"/> must be enabled before sending packets to a broadcast address (e.g. <c>255.255.255.255</c>).</para>
        /// </summary>
        [GodotMethod("set_dest_address")]
        public Error SetDestAddress(string host, int port)
        {
            return (Error)NativeCalls.godot_icall_2_709(method_bind_8, Object.GetPtr(this), host, port);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_broadcast_enabled");

        /// <summary>
        /// <para>Enable or disable sending of broadcast packets (e.g. <c>set_dest_address("255.255.255.255", 4343)</c>. This option is disabled by default.</para>
        /// <para>Note: Some Android devices might require the <c>CHANGE_WIFI_MULTICAST_STATE</c> permission and this option to be enabled to receive broadcast packets too.</para>
        /// </summary>
        [GodotMethod("set_broadcast_enabled")]
        public void SetBroadcastEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_9, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "join_multicast_group");

        /// <summary>
        /// <para>Joins the multicast group specified by <c>multicast_address</c> using the interface identified by <c>interface_name</c>.</para>
        /// <para>You can join the same multicast group with multiple interfaces. Use <see cref="Godot.IP.GetLocalInterfaces"/> to know which are available.</para>
        /// <para>Note: Some Android devices might require the <c>CHANGE_WIFI_MULTICAST_STATE</c> permission for multicast to work.</para>
        /// </summary>
        [GodotMethod("join_multicast_group")]
        public Error JoinMulticastGroup(string multicastAddress, string interfaceName)
        {
            return (Error)NativeCalls.godot_icall_2_136(method_bind_10, Object.GetPtr(this), multicastAddress, interfaceName);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "leave_multicast_group");

        /// <summary>
        /// <para>Removes the interface identified by <c>interface_name</c> from the multicast group specified by <c>multicast_address</c>.</para>
        /// </summary>
        [GodotMethod("leave_multicast_group")]
        public Error LeaveMulticastGroup(string multicastAddress, string interfaceName)
        {
            return (Error)NativeCalls.godot_icall_2_136(method_bind_11, Object.GetPtr(this), multicastAddress, interfaceName);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
