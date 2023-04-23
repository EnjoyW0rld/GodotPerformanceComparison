using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This class is used to store the state of a DTLS server. Upon <see cref="Godot.DTLSServer.Setup"/> it converts connected <see cref="Godot.PacketPeerUDP"/> to <see cref="Godot.PacketPeerDTLS"/> accepting them via <see cref="Godot.DTLSServer.TakeConnection"/> as DTLS clients. Under the hood, this class is used to store the DTLS state and cookies of the server. The reason of why the state and cookies are needed is outside of the scope of this documentation.</para>
    /// <para>Below a small example of how to use it:</para>
    /// <para><code>
    /// # server.gd
    /// extends Node
    /// 
    /// var dtls := DTLSServer.new()
    /// var server := UDPServer.new()
    /// var peers = []
    /// 
    /// func _ready():
    ///     server.listen(4242)
    ///     var key = load("key.key") # Your private key.
    ///     var cert = load("cert.crt") # Your X509 certificate.
    ///     dtls.setup(key, cert)
    /// 
    /// func _process(delta):
    ///     while server.is_connection_available():
    ///         var peer : PacketPeerUDP = server.take_connection()
    ///         var dtls_peer : PacketPeerDTLS = dtls.take_connection(peer)
    ///         if dtls_peer.get_status() != PacketPeerDTLS.STATUS_HANDSHAKING:
    ///             continue # It is normal that 50% of the connections fails due to cookie exchange.
    ///         print("Peer connected!")
    ///         peers.append(dtls_peer)
    ///     for p in peers:
    ///         p.poll() # Must poll to update the state.
    ///         if p.get_status() == PacketPeerDTLS.STATUS_CONNECTED:
    ///             while p.get_available_packet_count() &gt; 0:
    ///                 print("Received message from client: %s" % p.get_packet().get_string_from_utf8())
    ///                 p.put_packet("Hello DTLS client".to_utf8())
    /// </code></para>
    /// <para><code>
    /// # client.gd
    /// extends Node
    /// 
    /// var dtls := PacketPeerDTLS.new()
    /// var udp := PacketPeerUDP.new()
    /// var connected = false
    /// 
    /// func _ready():
    ///     udp.connect_to_host("127.0.0.1", 4242)
    ///     dtls.connect_to_peer(udp, false) # Use true in production for certificate validation!
    /// 
    /// func _process(delta):
    ///     dtls.poll()
    ///     if dtls.get_status() == PacketPeerDTLS.STATUS_CONNECTED:
    ///         if !connected:
    ///             # Try to contact server
    ///             dtls.put_packet("The answer is... 42!".to_utf8())
    ///         while dtls.get_available_packet_count() &gt; 0:
    ///             print("Connected: %s" % dtls.get_packet().get_string_from_utf8())
    ///             connected = true
    /// </code></para>
    /// </summary>
    public partial class DTLSServer : Reference
    {
        private const string nativeName = "DTLSServer";

        public DTLSServer() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_DTLSServer_Ctor(this);
        }

        internal DTLSServer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "setup");

        /// <summary>
        /// <para>Setup the DTLS server to use the given <c>private_key</c> and provide the given <c>certificate</c> to clients. You can pass the optional <c>chain</c> parameter to provide additional CA chain information along with the certificate.</para>
        /// </summary>
        [GodotMethod("setup")]
        public Error Setup(CryptoKey key, X509Certificate certificate, X509Certificate chain = null)
        {
            return (Error)NativeCalls.godot_icall_3_360(method_bind_0, Object.GetPtr(this), Object.GetPtr(key), Object.GetPtr(certificate), Object.GetPtr(chain));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "take_connection");

        /// <summary>
        /// <para>Try to initiate the DTLS handshake with the given <c>udp_peer</c> which must be already connected (see <see cref="Godot.PacketPeerUDP.ConnectToHost"/>).</para>
        /// <para>Note: You must check that the state of the return PacketPeerUDP is <see cref="Godot.PacketPeerDTLS.Status.Handshaking"/>, as it is normal that 50% of the new connections will be invalid due to cookie exchange.</para>
        /// </summary>
        [GodotMethod("take_connection")]
        public PacketPeerDTLS TakeConnection(PacketPeerUDP udpPeer)
        {
            return NativeCalls.godot_icall_1_361(method_bind_1, Object.GetPtr(this), Object.GetPtr(udpPeer));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
