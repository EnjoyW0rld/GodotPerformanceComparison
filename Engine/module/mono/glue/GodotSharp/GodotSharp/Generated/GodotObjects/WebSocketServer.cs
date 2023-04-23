using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This class implements a WebSocket server that can also support the high-level multiplayer API.</para>
    /// <para>After starting the server (<see cref="Godot.WebSocketServer.Listen"/>), you will need to <see cref="Godot.NetworkedMultiplayerPeer.Poll"/> it at regular intervals (e.g. inside <see cref="Godot.Node._Process"/>). When clients connect, disconnect, or send data, you will receive the appropriate signal.</para>
    /// <para>Note: Not available in HTML5 exports.</para>
    /// </summary>
    public partial class WebSocketServer : WebSocketMultiplayerPeer
    {
        /// <summary>
        /// <para>When not set to <c>*</c> will restrict incoming connections to the specified IP address. Setting <c>bind_ip</c> to <c>127.0.0.1</c> will cause the server to listen only to the local host.</para>
        /// </summary>
        public string BindIp
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBindIp();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBindIp(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When set to a valid <see cref="Godot.CryptoKey"/> (along with <see cref="Godot.WebSocketServer.SslCertificate"/>) will cause the server to require SSL instead of regular TCP (i.e. the <c>wss://</c> protocol).</para>
        /// </summary>
        public CryptoKey PrivateKey
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPrivateKey();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPrivateKey(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When set to a valid <see cref="Godot.X509Certificate"/> (along with <see cref="Godot.WebSocketServer.PrivateKey"/>) will cause the server to require SSL instead of regular TCP (i.e. the <c>wss://</c> protocol).</para>
        /// </summary>
        public X509Certificate SslCertificate
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSslCertificate();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSslCertificate(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When using SSL (see <see cref="Godot.WebSocketServer.PrivateKey"/> and <see cref="Godot.WebSocketServer.SslCertificate"/>), you can set this to a valid <see cref="Godot.X509Certificate"/> to be provided as additional CA chain information during the SSL handshake.</para>
        /// </summary>
        public X509Certificate CaChain
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCaChain();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCaChain(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The time in seconds before a pending client (i.e. a client that has not yet finished the HTTP handshake) is considered stale and forcefully disconnected.</para>
        /// </summary>
        public float HandshakeTimeout
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHandshakeTimeout();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHandshakeTimeout(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "WebSocketServer";

        public WebSocketServer() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_WebSocketServer_Ctor(this);
        }

        internal WebSocketServer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_listening");

        /// <summary>
        /// <para>Returns <c>true</c> if the server is actively listening on a port.</para>
        /// </summary>
        [GodotMethod("is_listening")]
        public bool IsListening()
        {
            return NativeCalls.godot_icall_0_7(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_extra_headers");

        /// <summary>
        /// <para>Sets additional headers to be sent to clients during the HTTP handshake.</para>
        /// </summary>
        /// <param name="headers">If the parameter is null, then the default value is Array.Empty&lt;string&gt;()</param>
        [GodotMethod("set_extra_headers")]
        public void SetExtraHeaders(string[] headers = null)
        {
            string[] headers_in = headers != null ? headers : Array.Empty<string>();
            NativeCalls.godot_icall_1_407(method_bind_1, Object.GetPtr(this), headers_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "listen");

        /// <summary>
        /// <para>Starts listening on the given port.</para>
        /// <para>You can specify the desired subprotocols via the "protocols" array. If the list empty (default), no sub-protocol will be requested.</para>
        /// <para>If <c>true</c> is passed as <c>gd_mp_api</c>, the server will behave like a network peer for the <see cref="Godot.MultiplayerAPI"/>, connections from non-Godot clients will not work, and <c>data_received</c> will not be emitted.</para>
        /// <para>If <c>false</c> is passed instead (default), you must call <see cref="Godot.PacketPeer"/> functions (<c>put_packet</c>, <c>get_packet</c>, etc.), on the <see cref="Godot.WebSocketPeer"/> returned via <c>get_peer(id)</c> to communicate with the peer with given <c>id</c> (e.g. <c>get_peer(id).get_available_packet_count</c>).</para>
        /// </summary>
        /// <param name="protocols">If the parameter is null, then the default value is Array.Empty&lt;string&gt;()</param>
        [GodotMethod("listen")]
        public Error Listen(int port, string[] protocols = null, bool gdMpApi = false)
        {
            string[] protocols_in = protocols != null ? protocols : Array.Empty<string>();
            return (Error)NativeCalls.godot_icall_3_1162(method_bind_2, Object.GetPtr(this), port, protocols_in, gdMpApi);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "stop");

        /// <summary>
        /// <para>Stops the server and clear its state.</para>
        /// </summary>
        [GodotMethod("stop")]
        public void Stop()
        {
            NativeCalls.godot_icall_0_3(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_peer");

        /// <summary>
        /// <para>Returns <c>true</c> if a peer with the given ID is connected.</para>
        /// </summary>
        [GodotMethod("has_peer")]
        public bool HasPeer(int id)
        {
            return NativeCalls.godot_icall_1_35(method_bind_4, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_peer_address");

        /// <summary>
        /// <para>Returns the IP address of the given peer.</para>
        /// </summary>
        [GodotMethod("get_peer_address")]
        public string GetPeerAddress(int id)
        {
            return NativeCalls.godot_icall_1_89(method_bind_5, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_peer_port");

        /// <summary>
        /// <para>Returns the remote port of the given peer.</para>
        /// </summary>
        [GodotMethod("get_peer_port")]
        public int GetPeerPort(int id)
        {
            return NativeCalls.godot_icall_1_11(method_bind_6, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "disconnect_peer");

        /// <summary>
        /// <para>Disconnects the peer identified by <c>id</c> from the server. See <see cref="Godot.WebSocketPeer.Close"/> for more information.</para>
        /// </summary>
        [GodotMethod("disconnect_peer")]
        public void DisconnectPeer(int id, int code = 1000, string reason = "")
        {
            NativeCalls.godot_icall_3_88(method_bind_7, Object.GetPtr(this), id, code, reason);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bind_ip");

        [GodotMethod("get_bind_ip")]
        [Obsolete("GetBindIp is deprecated. Use the BindIp property instead.")]
        public string GetBindIp()
        {
            return NativeCalls.godot_icall_0_6(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bind_ip");

        [GodotMethod("set_bind_ip")]
        [Obsolete("SetBindIp is deprecated. Use the BindIp property instead.")]
        public void SetBindIp(string ip)
        {
            NativeCalls.godot_icall_1_54(method_bind_9, Object.GetPtr(this), ip);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_private_key");

        [GodotMethod("get_private_key")]
        [Obsolete("GetPrivateKey is deprecated. Use the PrivateKey property instead.")]
        public CryptoKey GetPrivateKey()
        {
            return NativeCalls.godot_icall_0_1163(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_private_key");

        [GodotMethod("set_private_key")]
        [Obsolete("SetPrivateKey is deprecated. Use the PrivateKey property instead.")]
        public void SetPrivateKey(CryptoKey key)
        {
            NativeCalls.godot_icall_1_24(method_bind_11, Object.GetPtr(this), Object.GetPtr(key));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ssl_certificate");

        [GodotMethod("get_ssl_certificate")]
        [Obsolete("GetSslCertificate is deprecated. Use the SslCertificate property instead.")]
        public X509Certificate GetSslCertificate()
        {
            return NativeCalls.godot_icall_0_1159(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ssl_certificate");

        [GodotMethod("set_ssl_certificate")]
        [Obsolete("SetSslCertificate is deprecated. Use the SslCertificate property instead.")]
        public void SetSslCertificate(X509Certificate certificate)
        {
            NativeCalls.godot_icall_1_24(method_bind_13, Object.GetPtr(this), Object.GetPtr(certificate));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ca_chain");

        [GodotMethod("get_ca_chain")]
        [Obsolete("GetCaChain is deprecated. Use the CaChain property instead.")]
        public X509Certificate GetCaChain()
        {
            return NativeCalls.godot_icall_0_1159(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ca_chain");

        [GodotMethod("set_ca_chain")]
        [Obsolete("SetCaChain is deprecated. Use the CaChain property instead.")]
        public void SetCaChain(X509Certificate caChain)
        {
            NativeCalls.godot_icall_1_24(method_bind_15, Object.GetPtr(this), Object.GetPtr(caChain));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_handshake_timeout");

        [GodotMethod("get_handshake_timeout")]
        [Obsolete("GetHandshakeTimeout is deprecated. Use the HandshakeTimeout property instead.")]
        public float GetHandshakeTimeout()
        {
            return NativeCalls.godot_icall_0_14(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_handshake_timeout");

        [GodotMethod("set_handshake_timeout")]
        [Obsolete("SetHandshakeTimeout is deprecated. Use the HandshakeTimeout property instead.")]
        public void SetHandshakeTimeout(float timeout)
        {
            NativeCalls.godot_icall_1_15(method_bind_17, Object.GetPtr(this), timeout);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
