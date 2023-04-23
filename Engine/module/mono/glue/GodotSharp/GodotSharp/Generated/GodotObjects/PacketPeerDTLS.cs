using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This class represents a DTLS peer connection. It can be used to connect to a DTLS server, and is returned by <see cref="Godot.DTLSServer.TakeConnection"/>.</para>
    /// <para>Warning: SSL/TLS certificate revocation and certificate pinning are currently not supported. Revoked certificates are accepted as long as they are otherwise valid. If this is a concern, you may want to use automatically managed certificates with a short validity period.</para>
    /// </summary>
    public partial class PacketPeerDTLS : PacketPeer
    {
        public enum Status
        {
            /// <summary>
            /// <para>A status representing a <see cref="Godot.PacketPeerDTLS"/> that is disconnected.</para>
            /// </summary>
            Disconnected = 0,
            /// <summary>
            /// <para>A status representing a <see cref="Godot.PacketPeerDTLS"/> that is currently performing the handshake with a remote peer.</para>
            /// </summary>
            Handshaking = 1,
            /// <summary>
            /// <para>A status representing a <see cref="Godot.PacketPeerDTLS"/> that is connected to a remote peer.</para>
            /// </summary>
            Connected = 2,
            /// <summary>
            /// <para>A status representing a <see cref="Godot.PacketPeerDTLS"/> in a generic error state.</para>
            /// </summary>
            Error = 3,
            /// <summary>
            /// <para>An error status that shows a mismatch in the DTLS certificate domain presented by the host and the domain requested for validation.</para>
            /// </summary>
            ErrorHostnameMismatch = 4
        }

        private const string nativeName = "PacketPeerDTLS";

        public PacketPeerDTLS() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PacketPeerDTLS_Ctor(this);
        }

        internal PacketPeerDTLS(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "poll");

        /// <summary>
        /// <para>Poll the connection to check for incoming packets. Call this frequently to update the status and keep the connection working.</para>
        /// </summary>
        [GodotMethod("poll")]
        public void Poll()
        {
            NativeCalls.godot_icall_0_3(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "connect_to_peer");

        /// <summary>
        /// <para>Connects a <c>peer</c> beginning the DTLS handshake using the underlying <see cref="Godot.PacketPeerUDP"/> which must be connected (see <see cref="Godot.PacketPeerUDP.ConnectToHost"/>). If <c>validate_certs</c> is <c>true</c>, <see cref="Godot.PacketPeerDTLS"/> will validate that the certificate presented by the remote peer and match it with the <c>for_hostname</c> argument. You can specify a custom <see cref="Godot.X509Certificate"/> to use for validation via the <c>valid_certificate</c> argument.</para>
        /// </summary>
        [GodotMethod("connect_to_peer")]
        public Error ConnectToPeer(PacketPeerUDP packetPeer, bool validateCerts = true, string forHostname = "", X509Certificate validCertificate = null)
        {
            return (Error)NativeCalls.godot_icall_4_718(method_bind_1, Object.GetPtr(this), Object.GetPtr(packetPeer), validateCerts, forHostname, Object.GetPtr(validCertificate));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_status");

        /// <summary>
        /// <para>Returns the status of the connection. See <see cref="Godot.PacketPeerDTLS.Status"/> for values.</para>
        /// </summary>
        [GodotMethod("get_status")]
        public PacketPeerDTLS.Status GetStatus()
        {
            return (PacketPeerDTLS.Status)NativeCalls.godot_icall_0_719(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "disconnect_from_peer");

        /// <summary>
        /// <para>Disconnects this peer, terminating the DTLS session.</para>
        /// </summary>
        [GodotMethod("disconnect_from_peer")]
        public void DisconnectFromPeer()
        {
            NativeCalls.godot_icall_0_3(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
