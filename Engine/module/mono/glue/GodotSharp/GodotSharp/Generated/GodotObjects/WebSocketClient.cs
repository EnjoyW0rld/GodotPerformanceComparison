using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This class implements a WebSocket client compatible with any RFC 6455-compliant WebSocket server.</para>
    /// <para>This client can be optionally used as a network peer for the <see cref="Godot.MultiplayerAPI"/>.</para>
    /// <para>After starting the client (<see cref="Godot.WebSocketClient.ConnectToUrl"/>), you will need to <see cref="Godot.NetworkedMultiplayerPeer.Poll"/> it at regular intervals (e.g. inside <see cref="Godot.Node._Process"/>).</para>
    /// <para>You will receive appropriate signals when connecting, disconnecting, or when new data is available.</para>
    /// </summary>
    public partial class WebSocketClient : WebSocketMultiplayerPeer
    {
        /// <summary>
        /// <para>If <c>true</c>, SSL certificate verification is enabled.</para>
        /// <para>Note: You must specify the certificates to be used in the Project Settings for it to work when exported.</para>
        /// </summary>
        public bool VerifySsl
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsVerifySslEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVerifySslEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If specified, this <see cref="Godot.X509Certificate"/> will be the only one accepted when connecting to an SSL host. Any other certificate provided by the server will be regarded as invalid.</para>
        /// <para>Note: Specifying a custom <c>trusted_ssl_certificate</c> is not supported in HTML5 exports due to browsers restrictions.</para>
        /// </summary>
        public X509Certificate TrustedSslCertificate
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTrustedSslCertificate();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTrustedSslCertificate(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "WebSocketClient";

        public WebSocketClient() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_WebSocketClient_Ctor(this);
        }

        internal WebSocketClient(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "connect_to_url");

        /// <summary>
        /// <para>Connects to the given URL requesting one of the given <c>protocols</c> as sub-protocol. If the list empty (default), no sub-protocol will be requested.</para>
        /// <para>If <c>true</c> is passed as <c>gd_mp_api</c>, the client will behave like a network peer for the <see cref="Godot.MultiplayerAPI"/>, connections to non-Godot servers will not work, and <c>data_received</c> will not be emitted.</para>
        /// <para>If <c>false</c> is passed instead (default), you must call <see cref="Godot.PacketPeer"/> functions (<c>put_packet</c>, <c>get_packet</c>, etc.) on the <see cref="Godot.WebSocketPeer"/> returned via <c>get_peer(1)</c> and not on this object directly (e.g. <c>get_peer(1).put_packet(data)</c>).</para>
        /// <para>You can optionally pass a list of <c>custom_headers</c> to be added to the handshake HTTP request.</para>
        /// <para>Note: To avoid mixed content warnings or errors in HTML5, you may have to use a <c>url</c> that starts with <c>wss://</c> (secure) instead of <c>ws://</c>. When doing so, make sure to use the fully qualified domain name that matches the one defined in the server's SSL certificate. Do not connect directly via the IP address for <c>wss://</c> connections, as it won't match with the SSL certificate.</para>
        /// <para>Note: Specifying <c>custom_headers</c> is not supported in HTML5 exports due to browsers restrictions.</para>
        /// </summary>
        /// <param name="protocols">If the parameter is null, then the default value is Array.Empty&lt;string&gt;()</param>
        /// <param name="customHeaders">If the parameter is null, then the default value is Array.Empty&lt;string&gt;()</param>
        [GodotMethod("connect_to_url")]
        public Error ConnectToUrl(string url, string[] protocols = null, bool gdMpApi = false, string[] customHeaders = null)
        {
            string[] protocols_in = protocols != null ? protocols : Array.Empty<string>();
            string[] customHeaders_in = customHeaders != null ? customHeaders : Array.Empty<string>();
            return (Error)NativeCalls.godot_icall_4_1158(method_bind_0, Object.GetPtr(this), url, protocols_in, gdMpApi, customHeaders_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "disconnect_from_host");

        /// <summary>
        /// <para>Disconnects this client from the connected host. See <see cref="Godot.WebSocketPeer.Close"/> for more information.</para>
        /// </summary>
        [GodotMethod("disconnect_from_host")]
        public void DisconnectFromHost(int code = 1000, string reason = "")
        {
            NativeCalls.godot_icall_2_121(method_bind_1, Object.GetPtr(this), code, reason);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connected_host");

        /// <summary>
        /// <para>Return the IP address of the currently connected host.</para>
        /// </summary>
        [GodotMethod("get_connected_host")]
        public string GetConnectedHost()
        {
            return NativeCalls.godot_icall_0_6(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connected_port");

        /// <summary>
        /// <para>Return the IP port of the currently connected host.</para>
        /// </summary>
        [GodotMethod("get_connected_port")]
        public ushort GetConnectedPort()
        {
            return NativeCalls.godot_icall_0_895(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_verify_ssl_enabled");

        [GodotMethod("set_verify_ssl_enabled")]
        [Obsolete("SetVerifySslEnabled is deprecated. Use the VerifySsl property instead.")]
        public void SetVerifySslEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_verify_ssl_enabled");

        [GodotMethod("is_verify_ssl_enabled")]
        [Obsolete("IsVerifySslEnabled is deprecated. Use the VerifySsl property instead.")]
        public bool IsVerifySslEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_trusted_ssl_certificate");

        [GodotMethod("get_trusted_ssl_certificate")]
        [Obsolete("GetTrustedSslCertificate is deprecated. Use the TrustedSslCertificate property instead.")]
        public X509Certificate GetTrustedSslCertificate()
        {
            return NativeCalls.godot_icall_0_1159(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_trusted_ssl_certificate");

        [GodotMethod("set_trusted_ssl_certificate")]
        [Obsolete("SetTrustedSslCertificate is deprecated. Use the TrustedSslCertificate property instead.")]
        public void SetTrustedSslCertificate(X509Certificate certificate)
        {
            NativeCalls.godot_icall_1_24(method_bind_7, Object.GetPtr(this), Object.GetPtr(certificate));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
