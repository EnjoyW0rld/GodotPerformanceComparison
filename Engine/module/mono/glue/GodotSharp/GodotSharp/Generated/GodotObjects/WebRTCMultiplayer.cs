using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This class constructs a full mesh of <see cref="Godot.WebRTCPeerConnection"/> (one connection for each peer) that can be used as a <see cref="Godot.MultiplayerAPI.NetworkPeer"/>.</para>
    /// <para>You can add each <see cref="Godot.WebRTCPeerConnection"/> via <see cref="Godot.WebRTCMultiplayer.AddPeer"/> or remove them via <see cref="Godot.WebRTCMultiplayer.RemovePeer"/>. Peers must be added in <see cref="Godot.WebRTCPeerConnection.ConnectionState.New"/> state to allow it to create the appropriate channels. This class will not create offers nor set descriptions, it will only poll them, and notify connections and disconnections.</para>
    /// <para><c>NetworkedMultiplayerPeer.connection_succeeded</c> and <c>NetworkedMultiplayerPeer.server_disconnected</c> will not be emitted unless <c>server_compatibility</c> is <c>true</c> in <see cref="Godot.WebRTCMultiplayer.Initialize"/>. Beside that data transfer works like in a <see cref="Godot.NetworkedMultiplayerPeer"/>.</para>
    /// </summary>
    public partial class WebRTCMultiplayer : NetworkedMultiplayerPeer
    {
        private const string nativeName = "WebRTCMultiplayer";

        public WebRTCMultiplayer() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_WebRTCMultiplayer_Ctor(this);
        }

        internal WebRTCMultiplayer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "initialize");

        /// <summary>
        /// <para>Initialize the multiplayer peer with the given <c>peer_id</c> (must be between 1 and 2147483647).</para>
        /// <para>If <c>server_compatibilty</c> is <c>false</c> (default), the multiplayer peer will be immediately in state <see cref="Godot.NetworkedMultiplayerPeer.ConnectionStatus.Connected"/> and <c>NetworkedMultiplayerPeer.connection_succeeded</c> will not be emitted.</para>
        /// <para>If <c>server_compatibilty</c> is <c>true</c> the peer will suppress all <c>NetworkedMultiplayerPeer.peer_connected</c> signals until a peer with id <see cref="Godot.NetworkedMultiplayerPeer.TargetPeerServer"/> connects and then emit <c>NetworkedMultiplayerPeer.connection_succeeded</c>. After that the signal <c>NetworkedMultiplayerPeer.peer_connected</c> will be emitted for every already connected peer, and any new peer that might connect. If the server peer disconnects after that, signal <c>NetworkedMultiplayerPeer.server_disconnected</c> will be emitted and state will become <see cref="Godot.NetworkedMultiplayerPeer.ConnectionStatus.Connected"/>.</para>
        /// </summary>
        [GodotMethod("initialize")]
        public Error Initialize(int peerId, bool serverCompatibility = false)
        {
            return (Error)NativeCalls.godot_icall_2_1152(method_bind_0, Object.GetPtr(this), peerId, serverCompatibility);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_peer");

        /// <summary>
        /// <para>Add a new peer to the mesh with the given <c>peer_id</c>. The <see cref="Godot.WebRTCPeerConnection"/> must be in state <see cref="Godot.WebRTCPeerConnection.ConnectionState.New"/>.</para>
        /// <para>Three channels will be created for reliable, unreliable, and ordered transport. The value of <c>unreliable_lifetime</c> will be passed to the <c>maxPacketLifetime</c> option when creating unreliable and ordered channels (see <see cref="Godot.WebRTCPeerConnection.CreateDataChannel"/>).</para>
        /// </summary>
        [GodotMethod("add_peer")]
        public Error AddPeer(WebRTCPeerConnection peer, int peerId, int unreliableLifetime = 1)
        {
            return (Error)NativeCalls.godot_icall_3_1153(method_bind_1, Object.GetPtr(this), Object.GetPtr(peer), peerId, unreliableLifetime);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_peer");

        /// <summary>
        /// <para>Remove the peer with given <c>peer_id</c> from the mesh. If the peer was connected, and <c>NetworkedMultiplayerPeer.peer_connected</c> was emitted for it, then <c>NetworkedMultiplayerPeer.peer_disconnected</c> will be emitted.</para>
        /// </summary>
        [GodotMethod("remove_peer")]
        public void RemovePeer(int peerId)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), peerId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_peer");

        /// <summary>
        /// <para>Returns <c>true</c> if the given <c>peer_id</c> is in the peers map (it might not be connected though).</para>
        /// </summary>
        [GodotMethod("has_peer")]
        public bool HasPeer(int peerId)
        {
            return NativeCalls.godot_icall_1_35(method_bind_3, Object.GetPtr(this), peerId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_peer");

        /// <summary>
        /// <para>Return a dictionary representation of the peer with given <c>peer_id</c> with three keys. <c>connection</c> containing the <see cref="Godot.WebRTCPeerConnection"/> to this peer, <c>channels</c> an array of three <see cref="Godot.WebRTCDataChannel"/>, and <c>connected</c> a boolean representing if the peer connection is currently connected (all three channels are open).</para>
        /// </summary>
        [GodotMethod("get_peer")]
        public Godot.Collections.Dictionary GetPeer(int peerId)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_1_983(method_bind_4, Object.GetPtr(this), peerId));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_peers");

        /// <summary>
        /// <para>Returns a dictionary which keys are the peer ids and values the peer representation as in <see cref="Godot.WebRTCMultiplayer.GetPeer"/>.</para>
        /// </summary>
        [GodotMethod("get_peers")]
        public Godot.Collections.Dictionary GetPeers()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_5, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "close");

        /// <summary>
        /// <para>Close all the add peer connections and channels, freeing all resources.</para>
        /// </summary>
        [GodotMethod("close")]
        public void Close()
        {
            NativeCalls.godot_icall_0_3(method_bind_6, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
