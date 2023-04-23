using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A <see cref="Godot.NetworkedMultiplayerPeer"/> implementation that can be used as a <see cref="Godot.MultiplayerAPI.NetworkPeer"/> and controlled from a script.</para>
    /// <para>Its purpose is to allow adding a new backend for the high-Level multiplayer API without needing to use GDNative.</para>
    /// </summary>
    public partial class NetworkedMultiplayerCustom : NetworkedMultiplayerPeer
    {
        private const string nativeName = "NetworkedMultiplayerCustom";

        public NetworkedMultiplayerCustom() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_NetworkedMultiplayerCustom_Ctor(this);
        }

        internal NetworkedMultiplayerCustom(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "initialize");

        /// <summary>
        /// <para>Initialize the peer with the given <c>peer_id</c> (must be between 1 and 2147483647).</para>
        /// <para>Can only be called if the connection status is <see cref="Godot.NetworkedMultiplayerPeer.ConnectionStatus.Connecting"/>. See <see cref="Godot.NetworkedMultiplayerCustom.SetConnectionStatus"/>.</para>
        /// </summary>
        [GodotMethod("initialize")]
        public void Initialize(int selfPeerId)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), selfPeerId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max_packet_size");

        /// <summary>
        /// <para>Set the max packet size that this peer can handle.</para>
        /// </summary>
        [GodotMethod("set_max_packet_size")]
        public void SetMaxPacketSize(int maxPacketSize)
        {
            NativeCalls.godot_icall_1_4(method_bind_1, Object.GetPtr(this), maxPacketSize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_connection_status");

        /// <summary>
        /// <para>Set the state of the connection. See <see cref="Godot.NetworkedMultiplayerPeer.ConnectionStatus"/>.</para>
        /// <para>This will emit the <c>NetworkedMultiplayerPeer.connection_succeeded</c>, <c>NetworkedMultiplayerPeer.connection_failed</c> or <c>NetworkedMultiplayerPeer.server_disconnected</c> signals depending on the status and if the peer has the unique network id of <c>1</c>.</para>
        /// <para>You can only change to <see cref="Godot.NetworkedMultiplayerPeer.ConnectionStatus.Connecting"/> from <see cref="Godot.NetworkedMultiplayerPeer.ConnectionStatus.Disconnected"/> and to <see cref="Godot.NetworkedMultiplayerPeer.ConnectionStatus.Connected"/> from <see cref="Godot.NetworkedMultiplayerPeer.ConnectionStatus.Connecting"/>.</para>
        /// </summary>
        [GodotMethod("set_connection_status")]
        public void SetConnectionStatus(NetworkedMultiplayerPeer.ConnectionStatus connectionStatus)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)connectionStatus);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "deliver_packet");

        /// <summary>
        /// <para>Deliver a packet to the local <see cref="Godot.MultiplayerAPI"/>.</para>
        /// <para>When your script receives a packet from other peers over the network (originating from the <c>packet_generated</c> signal on the sending peer), passing it to this method will deliver it locally.</para>
        /// </summary>
        [GodotMethod("deliver_packet")]
        public void DeliverPacket(byte[] buffer, int fromPeerId)
        {
            NativeCalls.godot_icall_2_665(method_bind_3, Object.GetPtr(this), buffer, fromPeerId);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
