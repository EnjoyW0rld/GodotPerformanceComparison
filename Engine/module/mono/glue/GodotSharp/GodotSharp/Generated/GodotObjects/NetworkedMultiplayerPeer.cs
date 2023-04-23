using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Manages the connection to network peers. Assigns unique IDs to each client connected to the server. See also <see cref="Godot.MultiplayerAPI"/>.</para>
    /// <para>Note: The high-level multiplayer API protocol is an implementation detail and isn't meant to be used by non-Godot servers. It may change without notice.</para>
    /// </summary>
    public abstract partial class NetworkedMultiplayerPeer : PacketPeer
    {
        /// <summary>
        /// <para>Packets are sent to the server and then redistributed to other peers.</para>
        /// </summary>
        public const int TargetPeerBroadcast = 0;
        /// <summary>
        /// <para>Packets are sent to the server alone.</para>
        /// </summary>
        public const int TargetPeerServer = 1;

        public enum ConnectionStatus
        {
            /// <summary>
            /// <para>The ongoing connection disconnected.</para>
            /// </summary>
            Disconnected = 0,
            /// <summary>
            /// <para>A connection attempt is ongoing.</para>
            /// </summary>
            Connecting = 1,
            /// <summary>
            /// <para>The connection attempt succeeded.</para>
            /// </summary>
            Connected = 2
        }

        public enum TransferModeEnum
        {
            /// <summary>
            /// <para>Packets are not acknowledged, no resend attempts are made for lost packets. Packets may arrive in any order. Potentially faster than <see cref="Godot.NetworkedMultiplayerPeer.TransferModeEnum.UnreliableOrdered"/>. Use for non-critical data, and always consider whether the order matters.</para>
            /// </summary>
            Unreliable = 0,
            /// <summary>
            /// <para>Packets are not acknowledged, no resend attempts are made for lost packets. Packets are received in the order they were sent in. Potentially faster than <see cref="Godot.NetworkedMultiplayerPeer.TransferModeEnum.Reliable"/>. Use for non-critical data or data that would be outdated if received late due to resend attempt(s) anyway, for example movement and positional data.</para>
            /// </summary>
            UnreliableOrdered = 1,
            /// <summary>
            /// <para>Packets must be received and resend attempts should be made until the packets are acknowledged. Packets must be received in the order they were sent in. Most reliable transfer mode, but potentially the slowest due to the overhead. Use for critical data that must be transmitted and arrive in order, for example an ability being triggered or a chat message. Consider carefully if the information really is critical, and use sparingly.</para>
            /// </summary>
            Reliable = 2
        }

        /// <summary>
        /// <para>If <c>true</c>, this <see cref="Godot.NetworkedMultiplayerPeer"/> refuses new connections.</para>
        /// </summary>
        public bool RefuseNewConnections
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsRefusingNewConnections();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRefuseNewConnections(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The manner in which to send packets to the <c>target_peer</c>. See <see cref="Godot.NetworkedMultiplayerPeer.TransferModeEnum"/>.</para>
        /// </summary>
        public NetworkedMultiplayerPeer.TransferModeEnum TransferMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTransferMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTransferMode(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "NetworkedMultiplayerPeer";

        internal NetworkedMultiplayerPeer() {}

        internal NetworkedMultiplayerPeer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_transfer_mode");

        [GodotMethod("set_transfer_mode")]
        [Obsolete("SetTransferMode is deprecated. Use the TransferMode property instead.")]
        public void SetTransferMode(NetworkedMultiplayerPeer.TransferModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_transfer_mode");

        [GodotMethod("get_transfer_mode")]
        [Obsolete("GetTransferMode is deprecated. Use the TransferMode property instead.")]
        public NetworkedMultiplayerPeer.TransferModeEnum GetTransferMode()
        {
            return (NetworkedMultiplayerPeer.TransferModeEnum)NativeCalls.godot_icall_0_669(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_target_peer");

        /// <summary>
        /// <para>Sets the peer to which packets will be sent.</para>
        /// <para>The <c>id</c> can be one of: <see cref="Godot.NetworkedMultiplayerPeer.TargetPeerBroadcast"/> to send to all connected peers, <see cref="Godot.NetworkedMultiplayerPeer.TargetPeerServer"/> to send to the peer acting as server, a valid peer ID to send to that specific peer, a negative peer ID to send to all peers except that one. By default, the target peer is <see cref="Godot.NetworkedMultiplayerPeer.TargetPeerBroadcast"/>.</para>
        /// </summary>
        [GodotMethod("set_target_peer")]
        public void SetTargetPeer(int id)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_packet_peer");

        /// <summary>
        /// <para>Returns the ID of the <see cref="Godot.NetworkedMultiplayerPeer"/> who sent the most recent packet.</para>
        /// </summary>
        [GodotMethod("get_packet_peer")]
        public int GetPacketPeer()
        {
            return NativeCalls.godot_icall_0_5(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "poll");

        /// <summary>
        /// <para>Waits up to 1 second to receive a new network event.</para>
        /// </summary>
        [GodotMethod("poll")]
        public void Poll()
        {
            NativeCalls.godot_icall_0_3(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connection_status");

        /// <summary>
        /// <para>Returns the current state of the connection. See <see cref="Godot.NetworkedMultiplayerPeer.ConnectionStatus"/>.</para>
        /// </summary>
        [GodotMethod("get_connection_status")]
        public NetworkedMultiplayerPeer.ConnectionStatus GetConnectionStatus()
        {
            return (NetworkedMultiplayerPeer.ConnectionStatus)NativeCalls.godot_icall_0_670(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_unique_id");

        /// <summary>
        /// <para>Returns the ID of this <see cref="Godot.NetworkedMultiplayerPeer"/>.</para>
        /// </summary>
        [GodotMethod("get_unique_id")]
        public int GetUniqueId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_refuse_new_connections");

        [GodotMethod("set_refuse_new_connections")]
        [Obsolete("SetRefuseNewConnections is deprecated. Use the RefuseNewConnections property instead.")]
        public void SetRefuseNewConnections(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_7, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_refusing_new_connections");

        [GodotMethod("is_refusing_new_connections")]
        [Obsolete("IsRefusingNewConnections is deprecated. Use the RefuseNewConnections property instead.")]
        public bool IsRefusingNewConnections()
        {
            return NativeCalls.godot_icall_0_7(method_bind_8, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
