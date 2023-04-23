using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A PacketPeer implementation that should be passed to <see cref="Godot.SceneTree.NetworkPeer"/> after being initialized as either a client or server. Events can then be handled by connecting to <see cref="Godot.SceneTree"/> signals.</para>
    /// <para>ENet's purpose is to provide a relatively thin, simple and robust network communication layer on top of UDP (User Datagram Protocol).</para>
    /// <para>Note: ENet only uses UDP, not TCP. When forwarding the server port to make your server accessible on the public Internet, you only need to forward the server port in UDP. You can use the <see cref="Godot.UPNP"/> class to try to forward the server port automatically when starting the server.</para>
    /// </summary>
    public partial class NetworkedMultiplayerENet : NetworkedMultiplayerPeer
    {
        public enum CompressionModeEnum
        {
            /// <summary>
            /// <para>No compression. This uses the most bandwidth, but has the upside of requiring the fewest CPU resources. This option may also be used to make network debugging using tools like Wireshark easier.</para>
            /// </summary>
            None = 0,
            /// <summary>
            /// <para>ENet's built-in range encoding. Works well on small packets, but is not the most efficient algorithm on packets larger than 4 KB.</para>
            /// </summary>
            RangeCoder = 1,
            /// <summary>
            /// <para><a href="http://fastlz.org/">FastLZ</a> compression. This option uses less CPU resources compared to <see cref="Godot.NetworkedMultiplayerENet.CompressionModeEnum.Zlib"/>, at the expense of using more bandwidth.</para>
            /// </summary>
            Fastlz = 2,
            /// <summary>
            /// <para><a href="https://www.zlib.net/">Zlib</a> compression. This option uses less bandwidth compared to <see cref="Godot.NetworkedMultiplayerENet.CompressionModeEnum.Fastlz"/>, at the expense of using more CPU resources. Note that this algorithm is not very efficient on packets smaller than 4 KB. Therefore, it's recommended to use other compression algorithms in most cases.</para>
            /// </summary>
            Zlib = 3,
            /// <summary>
            /// <para><a href="https://facebook.github.io/zstd/">Zstandard</a> compression.</para>
            /// </summary>
            Zstd = 4
        }

        /// <summary>
        /// <para>The compression method used for network packets. These have different tradeoffs of compression speed versus bandwidth, you may need to test which one works best for your use case if you use compression at all.</para>
        /// <para>Note: Most games' network design involve sending many small packets frequently (smaller than 4 KB each). If in doubt, it is recommended to keep the default compression algorithm as it works best on these small packets.</para>
        /// <para>Note: <see cref="Godot.NetworkedMultiplayerENet.CompressionMode"/> must be set to the same value on both the server and all its clients. Clients will fail to connect if the <see cref="Godot.NetworkedMultiplayerENet.CompressionMode"/> set on the client differs from the one set on the server. Prior to Godot 3.4, the default <see cref="Godot.NetworkedMultiplayerENet.CompressionMode"/> was <see cref="Godot.NetworkedMultiplayerENet.CompressionModeEnum.None"/>. Nonetheless, mixing engine versions between clients and server is not recommended and not officially supported.</para>
        /// </summary>
        public NetworkedMultiplayerENet.CompressionModeEnum CompressionMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCompressionMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCompressionMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Set the default channel to be used to transfer data. By default, this value is <c>-1</c> which means that ENet will only use 2 channels: one for reliable packets, and one for unreliable packets. The channel <c>0</c> is reserved and cannot be used. Setting this member to any value between <c>0</c> and <see cref="Godot.NetworkedMultiplayerENet.ChannelCount"/> (excluded) will force ENet to use that channel for sending data. See <see cref="Godot.NetworkedMultiplayerENet.ChannelCount"/> for more information about ENet channels.</para>
        /// </summary>
        public int TransferChannel
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTransferChannel();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTransferChannel(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The number of channels to be used by ENet. Channels are used to separate different kinds of data. In reliable or ordered mode, for example, the packet delivery order is ensured on a per-channel basis. This is done to combat latency and reduces ordering restrictions on packets. The delivery status of a packet in one channel won't stall the delivery of other packets in another channel.</para>
        /// </summary>
        public int ChannelCount
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetChannelCount();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetChannelCount(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Enforce ordered packets when using <see cref="Godot.NetworkedMultiplayerPeer.TransferModeEnum.Unreliable"/> (thus behaving similarly to <see cref="Godot.NetworkedMultiplayerPeer.TransferModeEnum.UnreliableOrdered"/>). This is the only way to use ordering with the RPC system.</para>
        /// </summary>
        public bool AlwaysOrdered
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsAlwaysOrdered();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAlwaysOrdered(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Enable or disable the server feature that notifies clients of other peers' connection/disconnection, and relays messages between them. When this option is <c>false</c>, clients won't be automatically notified of other peers and won't be able to send them packets through the server.</para>
        /// </summary>
        public bool ServerRelay
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsServerRelayEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetServerRelayEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Enable or disable certificate verification when <see cref="Godot.NetworkedMultiplayerENet.UseDtls"/> is <c>true</c>.</para>
        /// </summary>
        public bool DtlsVerify
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDtlsVerifyEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDtlsVerifyEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The hostname used for DTLS verification, to be compared against the "CN" value in the certificate provided by the server.</para>
        /// <para>When set to an empty string, the <c>address</c> parameter passed to <see cref="Godot.NetworkedMultiplayerENet.CreateClient"/> is used instead.</para>
        /// </summary>
        public string DtlsHostname
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDtlsHostname();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDtlsHostname(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When enabled, the client or server created by this peer, will use <see cref="Godot.PacketPeerDTLS"/> instead of raw UDP sockets for communicating with the remote peer. This will make the communication encrypted with DTLS at the cost of higher resource usage and potentially larger packet size.</para>
        /// <para>Note: When creating a DTLS server, make sure you setup the key/certificate pair via <see cref="Godot.NetworkedMultiplayerENet.SetDtlsKey"/> and <see cref="Godot.NetworkedMultiplayerENet.SetDtlsCertificate"/>. For DTLS clients, have a look at the <see cref="Godot.NetworkedMultiplayerENet.DtlsVerify"/> option, and configure the certificate accordingly via <see cref="Godot.NetworkedMultiplayerENet.SetDtlsCertificate"/>.</para>
        /// </summary>
        public bool UseDtls
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDtlsEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDtlsEnabled(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "NetworkedMultiplayerENet";

        public NetworkedMultiplayerENet() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_NetworkedMultiplayerENet_Ctor(this);
        }

        internal NetworkedMultiplayerENet(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_server");

        /// <summary>
        /// <para>Create server that listens to connections via <c>port</c>. The port needs to be an available, unused port between 0 and 65535. Note that ports below 1024 are privileged and may require elevated permissions depending on the platform. To change the interface the server listens on, use <see cref="Godot.NetworkedMultiplayerENet.SetBindIp"/>. The default IP is the wildcard <c>"*"</c>, which listens on all available interfaces. <c>max_clients</c> is the maximum number of clients that are allowed at once, any number up to 4095 may be used, although the achievable number of simultaneous clients may be far lower and depends on the application. For additional details on the bandwidth parameters, see <see cref="Godot.NetworkedMultiplayerENet.CreateClient"/>. Returns <c>OK</c> if a server was created, <c>ERR_ALREADY_IN_USE</c> if this NetworkedMultiplayerENet instance already has an open connection (in which case you need to call <see cref="Godot.NetworkedMultiplayerENet.CloseConnection"/> first) or <c>ERR_CANT_CREATE</c> if the server could not be created.</para>
        /// </summary>
        [GodotMethod("create_server")]
        public Error CreateServer(int port, int maxClients = 32, int inBandwidth = 0, int outBandwidth = 0)
        {
            return (Error)NativeCalls.godot_icall_4_666(method_bind_0, Object.GetPtr(this), port, maxClients, inBandwidth, outBandwidth);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_client");

        /// <summary>
        /// <para>Create client that connects to a server at <c>address</c> using specified <c>port</c>. The given address needs to be either a fully qualified domain name (e.g. <c>"www.example.com"</c>) or an IP address in IPv4 or IPv6 format (e.g. <c>"192.168.1.1"</c>). The <c>port</c> is the port the server is listening on. The <c>in_bandwidth</c> and <c>out_bandwidth</c> parameters can be used to limit the incoming and outgoing bandwidth to the given number of bytes per second. The default of 0 means unlimited bandwidth. Note that ENet will strategically drop packets on specific sides of a connection between peers to ensure the peer's bandwidth is not overwhelmed. The bandwidth parameters also determine the window size of a connection which limits the amount of reliable packets that may be in transit at any given time. Returns <c>OK</c> if a client was created, <c>ERR_ALREADY_IN_USE</c> if this NetworkedMultiplayerENet instance already has an open connection (in which case you need to call <see cref="Godot.NetworkedMultiplayerENet.CloseConnection"/> first) or <c>ERR_CANT_CREATE</c> if the client could not be created. If <c>client_port</c> is specified, the client will also listen to the given port; this is useful for some NAT traversal techniques.</para>
        /// </summary>
        [GodotMethod("create_client")]
        public Error CreateClient(string address, int port, int inBandwidth = 0, int outBandwidth = 0, int clientPort = 0)
        {
            return (Error)NativeCalls.godot_icall_5_667(method_bind_1, Object.GetPtr(this), address, port, inBandwidth, outBandwidth, clientPort);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "close_connection");

        /// <summary>
        /// <para>Closes the connection. Ignored if no connection is currently established. If this is a server it tries to notify all clients before forcibly disconnecting them. If this is a client it simply closes the connection to the server.</para>
        /// </summary>
        [GodotMethod("close_connection")]
        public void CloseConnection(uint waitUsec = (uint)100)
        {
            NativeCalls.godot_icall_1_187(method_bind_2, Object.GetPtr(this), waitUsec);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "disconnect_peer");

        /// <summary>
        /// <para>Disconnect the given peer. If "now" is set to <c>true</c>, the connection will be closed immediately without flushing queued messages.</para>
        /// </summary>
        [GodotMethod("disconnect_peer")]
        public void DisconnectPeer(int id, bool now = false)
        {
            NativeCalls.godot_icall_2_23(method_bind_3, Object.GetPtr(this), id, now);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_compression_mode");

        [GodotMethod("set_compression_mode")]
        [Obsolete("SetCompressionMode is deprecated. Use the CompressionMode property instead.")]
        public void SetCompressionMode(NetworkedMultiplayerENet.CompressionModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_compression_mode");

        [GodotMethod("get_compression_mode")]
        [Obsolete("GetCompressionMode is deprecated. Use the CompressionMode property instead.")]
        public NetworkedMultiplayerENet.CompressionModeEnum GetCompressionMode()
        {
            return (NetworkedMultiplayerENet.CompressionModeEnum)NativeCalls.godot_icall_0_668(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bind_ip");

        /// <summary>
        /// <para>The IP used when creating a server. This is set to the wildcard <c>"*"</c> by default, which binds to all available interfaces. The given IP needs to be in IPv4 or IPv6 address format, for example: <c>"192.168.1.1"</c>.</para>
        /// </summary>
        [GodotMethod("set_bind_ip")]
        public void SetBindIp(string ip)
        {
            NativeCalls.godot_icall_1_54(method_bind_6, Object.GetPtr(this), ip);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dtls_enabled");

        [GodotMethod("set_dtls_enabled")]
        [Obsolete("SetDtlsEnabled is deprecated. Use the UseDtls property instead.")]
        public void SetDtlsEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_7, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_dtls_enabled");

        [GodotMethod("is_dtls_enabled")]
        [Obsolete("IsDtlsEnabled is deprecated. Use the UseDtls property instead.")]
        public bool IsDtlsEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dtls_key");

        /// <summary>
        /// <para>Configure the <see cref="Godot.CryptoKey"/> to use when <see cref="Godot.NetworkedMultiplayerENet.UseDtls"/> is <c>true</c>. Remember to also call <see cref="Godot.NetworkedMultiplayerENet.SetDtlsCertificate"/> to setup your <see cref="Godot.X509Certificate"/>.</para>
        /// </summary>
        [GodotMethod("set_dtls_key")]
        public void SetDtlsKey(CryptoKey key)
        {
            NativeCalls.godot_icall_1_24(method_bind_9, Object.GetPtr(this), Object.GetPtr(key));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dtls_certificate");

        /// <summary>
        /// <para>Configure the <see cref="Godot.X509Certificate"/> to use when <see cref="Godot.NetworkedMultiplayerENet.UseDtls"/> is <c>true</c>. For servers, you must also setup the <see cref="Godot.CryptoKey"/> via <see cref="Godot.NetworkedMultiplayerENet.SetDtlsKey"/>.</para>
        /// </summary>
        [GodotMethod("set_dtls_certificate")]
        public void SetDtlsCertificate(X509Certificate certificate)
        {
            NativeCalls.godot_icall_1_24(method_bind_10, Object.GetPtr(this), Object.GetPtr(certificate));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dtls_verify_enabled");

        [GodotMethod("set_dtls_verify_enabled")]
        [Obsolete("SetDtlsVerifyEnabled is deprecated. Use the DtlsVerify property instead.")]
        public void SetDtlsVerifyEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_11, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_dtls_verify_enabled");

        [GodotMethod("is_dtls_verify_enabled")]
        [Obsolete("IsDtlsVerifyEnabled is deprecated. Use the DtlsVerify property instead.")]
        public bool IsDtlsVerifyEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dtls_hostname");

        [GodotMethod("set_dtls_hostname")]
        [Obsolete("SetDtlsHostname is deprecated. Use the DtlsHostname property instead.")]
        public void SetDtlsHostname(string hostname)
        {
            NativeCalls.godot_icall_1_54(method_bind_13, Object.GetPtr(this), hostname);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_dtls_hostname");

        [GodotMethod("get_dtls_hostname")]
        [Obsolete("GetDtlsHostname is deprecated. Use the DtlsHostname property instead.")]
        public string GetDtlsHostname()
        {
            return NativeCalls.godot_icall_0_6(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_peer_address");

        /// <summary>
        /// <para>Returns the IP address of the given peer.</para>
        /// </summary>
        [GodotMethod("get_peer_address")]
        public string GetPeerAddress(int id)
        {
            return NativeCalls.godot_icall_1_89(method_bind_15, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_peer_port");

        /// <summary>
        /// <para>Returns the remote port of the given peer.</para>
        /// </summary>
        [GodotMethod("get_peer_port")]
        public int GetPeerPort(int id)
        {
            return NativeCalls.godot_icall_1_11(method_bind_16, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_peer_timeout");

        /// <summary>
        /// <para>Sets the timeout parameters for a peer.The timeout parameters control how and when a peer will timeout from a failure to acknowledge reliable traffic. Timeout values are expressed in milliseconds.</para>
        /// <para>The <c>timeout_limit</c> is a factor that, multiplied by a value based on the average round trip time, will determine the timeout limit for a reliable packet. When that limit is reached, the timeout will be doubled, and the peer will be disconnected if that limit has reached <c>timeout_min</c>. The <c>timeout_max</c> parameter, on the other hand, defines a fixed timeout for which any packet must be acknowledged or the peer will be dropped.</para>
        /// </summary>
        [GodotMethod("set_peer_timeout")]
        public void SetPeerTimeout(int id, int timeoutLimit, int timeoutMin, int timeoutMax)
        {
            NativeCalls.godot_icall_4_101(method_bind_17, Object.GetPtr(this), id, timeoutLimit, timeoutMin, timeoutMax);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_packet_channel");

        /// <summary>
        /// <para>Returns the channel of the next packet that will be retrieved via <see cref="Godot.PacketPeer.GetPacket"/>.</para>
        /// </summary>
        [GodotMethod("get_packet_channel")]
        public int GetPacketChannel()
        {
            return NativeCalls.godot_icall_0_5(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_last_packet_channel");

        /// <summary>
        /// <para>Returns the channel of the last packet fetched via <see cref="Godot.PacketPeer.GetPacket"/>.</para>
        /// </summary>
        [GodotMethod("get_last_packet_channel")]
        public int GetLastPacketChannel()
        {
            return NativeCalls.godot_icall_0_5(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_transfer_channel");

        [GodotMethod("set_transfer_channel")]
        [Obsolete("SetTransferChannel is deprecated. Use the TransferChannel property instead.")]
        public void SetTransferChannel(int channel)
        {
            NativeCalls.godot_icall_1_4(method_bind_20, Object.GetPtr(this), channel);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_transfer_channel");

        [GodotMethod("get_transfer_channel")]
        [Obsolete("GetTransferChannel is deprecated. Use the TransferChannel property instead.")]
        public int GetTransferChannel()
        {
            return NativeCalls.godot_icall_0_5(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_channel_count");

        [GodotMethod("set_channel_count")]
        [Obsolete("SetChannelCount is deprecated. Use the ChannelCount property instead.")]
        public void SetChannelCount(int channels)
        {
            NativeCalls.godot_icall_1_4(method_bind_22, Object.GetPtr(this), channels);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_channel_count");

        [GodotMethod("get_channel_count")]
        [Obsolete("GetChannelCount is deprecated. Use the ChannelCount property instead.")]
        public int GetChannelCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_always_ordered");

        [GodotMethod("set_always_ordered")]
        [Obsolete("SetAlwaysOrdered is deprecated. Use the AlwaysOrdered property instead.")]
        public void SetAlwaysOrdered(bool ordered)
        {
            NativeCalls.godot_icall_1_16(method_bind_24, Object.GetPtr(this), ordered);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_always_ordered");

        [GodotMethod("is_always_ordered")]
        [Obsolete("IsAlwaysOrdered is deprecated. Use the AlwaysOrdered property instead.")]
        public bool IsAlwaysOrdered()
        {
            return NativeCalls.godot_icall_0_7(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_server_relay_enabled");

        [GodotMethod("set_server_relay_enabled")]
        [Obsolete("SetServerRelayEnabled is deprecated. Use the ServerRelay property instead.")]
        public void SetServerRelayEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_26, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_server_relay_enabled");

        [GodotMethod("is_server_relay_enabled")]
        [Obsolete("IsServerRelayEnabled is deprecated. Use the ServerRelay property instead.")]
        public bool IsServerRelayEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_27, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
