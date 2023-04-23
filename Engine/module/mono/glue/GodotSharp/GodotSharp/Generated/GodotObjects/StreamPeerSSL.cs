using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>SSL stream peer. This object can be used to connect to an SSL server or accept a single SSL client connection.</para>
    /// </summary>
    public partial class StreamPeerSSL : StreamPeer
    {
        public enum Status
        {
            /// <summary>
            /// <para>A status representing a <see cref="Godot.StreamPeerSSL"/> that is disconnected.</para>
            /// </summary>
            Disconnected = 0,
            /// <summary>
            /// <para>A status representing a <see cref="Godot.StreamPeerSSL"/> during handshaking.</para>
            /// </summary>
            Handshaking = 1,
            /// <summary>
            /// <para>A status representing a <see cref="Godot.StreamPeerSSL"/> that is connected to a host.</para>
            /// </summary>
            Connected = 2,
            /// <summary>
            /// <para>A status representing a <see cref="Godot.StreamPeerSSL"/> in error state.</para>
            /// </summary>
            Error = 3,
            /// <summary>
            /// <para>An error status that shows a mismatch in the SSL certificate domain presented by the host and the domain requested for validation.</para>
            /// </summary>
            ErrorHostnameMismatch = 4
        }

        public bool BlockingHandshake
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsBlockingHandshakeEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlockingHandshakeEnabled(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "StreamPeerSSL";

        public StreamPeerSSL() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_StreamPeerSSL_Ctor(this);
        }

        internal StreamPeerSSL(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "poll");

        /// <summary>
        /// <para>Poll the connection to check for incoming bytes. Call this right before <see cref="Godot.StreamPeer.GetAvailableBytes"/> for it to work properly.</para>
        /// </summary>
        [GodotMethod("poll")]
        public void Poll()
        {
            NativeCalls.godot_icall_0_3(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "accept_stream");

        /// <summary>
        /// <para>Accepts a peer connection as a server using the given <c>private_key</c> and providing the given <c>certificate</c> to the client. You can pass the optional <c>chain</c> parameter to provide additional CA chain information along with the certificate.</para>
        /// </summary>
        [GodotMethod("accept_stream")]
        public Error AcceptStream(StreamPeer stream, CryptoKey privateKey, X509Certificate certificate, X509Certificate chain = null)
        {
            return (Error)NativeCalls.godot_icall_4_897(method_bind_1, Object.GetPtr(this), Object.GetPtr(stream), Object.GetPtr(privateKey), Object.GetPtr(certificate), Object.GetPtr(chain));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "connect_to_stream");

        /// <summary>
        /// <para>Connects to a peer using an underlying <see cref="Godot.StreamPeer"/> <c>stream</c>. If <c>validate_certs</c> is <c>true</c>, <see cref="Godot.StreamPeerSSL"/> will validate that the certificate presented by the peer matches the <c>for_hostname</c>.</para>
        /// <para>Note: Specifying a custom <c>valid_certificate</c> is not supported in HTML5 exports due to browsers restrictions.</para>
        /// </summary>
        [GodotMethod("connect_to_stream")]
        public Error ConnectToStream(StreamPeer stream, bool validateCerts = false, string forHostname = "", X509Certificate validCertificate = null)
        {
            return (Error)NativeCalls.godot_icall_4_718(method_bind_2, Object.GetPtr(this), Object.GetPtr(stream), validateCerts, forHostname, Object.GetPtr(validCertificate));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_status");

        /// <summary>
        /// <para>Returns the status of the connection. See <see cref="Godot.StreamPeerSSL.Status"/> for values.</para>
        /// </summary>
        [GodotMethod("get_status")]
        public StreamPeerSSL.Status GetStatus()
        {
            return (StreamPeerSSL.Status)NativeCalls.godot_icall_0_898(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "disconnect_from_stream");

        /// <summary>
        /// <para>Disconnects from host.</para>
        /// </summary>
        [GodotMethod("disconnect_from_stream")]
        public void DisconnectFromStream()
        {
            NativeCalls.godot_icall_0_3(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_blocking_handshake_enabled");

        [GodotMethod("set_blocking_handshake_enabled")]
        [Obsolete("SetBlockingHandshakeEnabled is deprecated. Use the BlockingHandshake property instead.")]
        public void SetBlockingHandshakeEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_5, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_blocking_handshake_enabled");

        [GodotMethod("is_blocking_handshake_enabled")]
        [Obsolete("IsBlockingHandshakeEnabled is deprecated. Use the BlockingHandshake property instead.")]
        public bool IsBlockingHandshakeEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_6, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
