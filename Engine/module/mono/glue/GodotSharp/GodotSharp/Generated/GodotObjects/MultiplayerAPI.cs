using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This class implements most of the logic behind the high-level multiplayer API. See also <see cref="Godot.NetworkedMultiplayerPeer"/>.</para>
    /// <para>By default, <see cref="Godot.SceneTree"/> has a reference to this class that is used to provide multiplayer capabilities (i.e. RPC/RSET) across the whole scene.</para>
    /// <para>It is possible to override the MultiplayerAPI instance used by specific Nodes by setting the <see cref="Godot.Node.CustomMultiplayer"/> property, effectively allowing to run both client and server in the same scene.</para>
    /// <para>Note: The high-level multiplayer API protocol is an implementation detail and isn't meant to be used by non-Godot servers. It may change without notice.</para>
    /// </summary>
    public partial class MultiplayerAPI : Reference
    {
        public enum RPCMode
        {
            /// <summary>
            /// <para>Used with <see cref="Godot.Node.RpcConfig"/> or <see cref="Godot.Node.RsetConfig"/> to disable a method or property for all RPC calls, making it unavailable. Default for all methods.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>Used with <see cref="Godot.Node.RpcConfig"/> or <see cref="Godot.Node.RsetConfig"/> to set a method to be called or a property to be changed only on the remote end, not locally. Analogous to the <c>remote</c> keyword. Calls and property changes are accepted from all remote peers, no matter if they are node's master or puppets.</para>
            /// </summary>
            Remote = 1,
            /// <summary>
            /// <para>Used with <see cref="Godot.Node.RpcConfig"/> or <see cref="Godot.Node.RsetConfig"/> to set a method to be called or a property to be changed only on the network master for this node. Analogous to the <c>master</c> keyword. Only accepts calls or property changes from the node's network puppets, see <see cref="Godot.Node.SetNetworkMaster"/>.</para>
            /// </summary>
            Master = 2,
            /// <summary>
            /// <para>Used with <see cref="Godot.Node.RpcConfig"/> or <see cref="Godot.Node.RsetConfig"/> to set a method to be called or a property to be changed only on puppets for this node. Analogous to the <c>puppet</c> keyword. Only accepts calls or property changes from the node's network master, see <see cref="Godot.Node.SetNetworkMaster"/>.</para>
            /// </summary>
            Puppet = 3,
            /// <summary>
            /// <para>Deprecated. Use <see cref="Godot.MultiplayerAPI.RPCMode.Puppet"/> instead. Analogous to the <c>slave</c> keyword.</para>
            /// </summary>
            Slave = 3,
            /// <summary>
            /// <para>Behave like <see cref="Godot.MultiplayerAPI.RPCMode.Remote"/> but also make the call or property change locally. Analogous to the <c>remotesync</c> keyword.</para>
            /// </summary>
            Remotesync = 4,
            /// <summary>
            /// <para>Deprecated. Use <see cref="Godot.MultiplayerAPI.RPCMode.Remotesync"/> instead. Analogous to the <c>sync</c> keyword.</para>
            /// </summary>
            Sync = 4,
            /// <summary>
            /// <para>Behave like <see cref="Godot.MultiplayerAPI.RPCMode.Master"/> but also make the call or property change locally. Analogous to the <c>mastersync</c> keyword.</para>
            /// </summary>
            Mastersync = 5,
            /// <summary>
            /// <para>Behave like <see cref="Godot.MultiplayerAPI.RPCMode.Puppet"/> but also make the call or property change locally. Analogous to the <c>puppetsync</c> keyword.</para>
            /// </summary>
            Puppetsync = 6
        }

        /// <summary>
        /// <para>If <c>true</c> (or if the <see cref="Godot.MultiplayerAPI.NetworkPeer"/> has <see cref="Godot.PacketPeer.AllowObjectDecoding"/> set to <c>true</c>), the MultiplayerAPI will allow encoding and decoding of object during RPCs/RSETs.</para>
        /// <para>Warning: Deserialized objects can contain code which gets executed. Do not use this option if the serialized object comes from untrusted sources to avoid potential security threats such as remote code execution.</para>
        /// </summary>
        public bool AllowObjectDecoding
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsObjectDecodingAllowed();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAllowObjectDecoding(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the MultiplayerAPI's <see cref="Godot.MultiplayerAPI.NetworkPeer"/> refuses new incoming connections.</para>
        /// </summary>
        public bool RefuseNewNetworkConnections
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsRefusingNewNetworkConnections();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRefuseNewNetworkConnections(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The peer object to handle the RPC system (effectively enabling networking when set). Depending on the peer itself, the MultiplayerAPI will become a network server (check with <see cref="Godot.MultiplayerAPI.IsNetworkServer"/>) and will set root node's network mode to master, or it will become a regular peer with root node set to puppet. All child nodes are set to inherit the network mode by default. Handling of networking-related events (connection, disconnection, new clients) is done by connecting to MultiplayerAPI's signals.</para>
        /// </summary>
        public NetworkedMultiplayerPeer NetworkPeer
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNetworkPeer();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetNetworkPeer(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The root node to use for RPCs. Instead of an absolute path, a relative path will be used to find the node upon which the RPC should be executed.</para>
        /// <para>This effectively allows to have different branches of the scene tree to be managed by different MultiplayerAPI, allowing for example to run both client and server in the same scene.</para>
        /// </summary>
        public Node RootNode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRootNode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRootNode(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "MultiplayerAPI";

        public MultiplayerAPI() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_MultiplayerAPI_Ctor(this);
        }

        internal MultiplayerAPI(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_root_node");

        [GodotMethod("set_root_node")]
        [Obsolete("SetRootNode is deprecated. Use the RootNode property instead.")]
        public void SetRootNode(Node node)
        {
            NativeCalls.godot_icall_1_53(method_bind_0, Object.GetPtr(this), Object.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_root_node");

        [GodotMethod("get_root_node")]
        [Obsolete("GetRootNode is deprecated. Use the RootNode property instead.")]
        public Node GetRootNode()
        {
            return NativeCalls.godot_icall_0_257(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "send_bytes");

        /// <summary>
        /// <para>Sends the given raw <c>bytes</c> to a specific peer identified by <c>id</c> (see <see cref="Godot.NetworkedMultiplayerPeer.SetTargetPeer"/>). Default ID is <c>0</c>, i.e. broadcast to all peers.</para>
        /// </summary>
        [GodotMethod("send_bytes")]
        public Error SendBytes(byte[] bytes, int id = 0, NetworkedMultiplayerPeer.TransferModeEnum mode = (NetworkedMultiplayerPeer.TransferModeEnum)2)
        {
            return (Error)NativeCalls.godot_icall_3_621(method_bind_2, Object.GetPtr(this), bytes, id, (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_network_peer");

        /// <summary>
        /// <para>Returns <c>true</c> if there is a <see cref="Godot.MultiplayerAPI.NetworkPeer"/> set.</para>
        /// </summary>
        [GodotMethod("has_network_peer")]
        public bool HasNetworkPeer()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_network_peer");

        [GodotMethod("get_network_peer")]
        [Obsolete("GetNetworkPeer is deprecated. Use the NetworkPeer property instead.")]
        public NetworkedMultiplayerPeer GetNetworkPeer()
        {
            return NativeCalls.godot_icall_0_622(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_network_unique_id");

        /// <summary>
        /// <para>Returns the unique peer ID of this MultiplayerAPI's <see cref="Godot.MultiplayerAPI.NetworkPeer"/>.</para>
        /// </summary>
        [GodotMethod("get_network_unique_id")]
        public int GetNetworkUniqueId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_network_server");

        /// <summary>
        /// <para>Returns <c>true</c> if this MultiplayerAPI's <see cref="Godot.MultiplayerAPI.NetworkPeer"/> is in server mode (listening for connections).</para>
        /// </summary>
        [GodotMethod("is_network_server")]
        public bool IsNetworkServer()
        {
            return NativeCalls.godot_icall_0_7(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rpc_sender_id");

        /// <summary>
        /// <para>Returns the sender's peer ID for the RPC currently being executed.</para>
        /// <para>Note: If not inside an RPC this method will return 0.</para>
        /// </summary>
        [GodotMethod("get_rpc_sender_id")]
        public int GetRpcSenderId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_network_peer");

        [GodotMethod("set_network_peer")]
        [Obsolete("SetNetworkPeer is deprecated. Use the NetworkPeer property instead.")]
        public void SetNetworkPeer(NetworkedMultiplayerPeer peer)
        {
            NativeCalls.godot_icall_1_24(method_bind_8, Object.GetPtr(this), Object.GetPtr(peer));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "poll");

        /// <summary>
        /// <para>Method used for polling the MultiplayerAPI. You only need to worry about this if you are using <see cref="Godot.Node.CustomMultiplayer"/> override or you set <see cref="Godot.SceneTree.MultiplayerPoll"/> to <c>false</c>. By default, <see cref="Godot.SceneTree"/> will poll its MultiplayerAPI for you.</para>
        /// <para>Note: This method results in RPCs and RSETs being called, so they will be executed in the same context of this function (e.g. <c>_process</c>, <c>physics</c>, <see cref="Godot.Thread"/>).</para>
        /// </summary>
        [GodotMethod("poll")]
        public void Poll()
        {
            NativeCalls.godot_icall_0_3(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Clears the current MultiplayerAPI network state (you shouldn't call this unless you know what you are doing).</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_network_connected_peers");

        /// <summary>
        /// <para>Returns the peer IDs of all connected peers of this MultiplayerAPI's <see cref="Godot.MultiplayerAPI.NetworkPeer"/>.</para>
        /// </summary>
        [GodotMethod("get_network_connected_peers")]
        public int[] GetNetworkConnectedPeers()
        {
            return NativeCalls.godot_icall_0_103(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_refuse_new_network_connections");

        [GodotMethod("set_refuse_new_network_connections")]
        [Obsolete("SetRefuseNewNetworkConnections is deprecated. Use the RefuseNewNetworkConnections property instead.")]
        public void SetRefuseNewNetworkConnections(bool refuse)
        {
            NativeCalls.godot_icall_1_16(method_bind_12, Object.GetPtr(this), refuse);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_refusing_new_network_connections");

        [GodotMethod("is_refusing_new_network_connections")]
        [Obsolete("IsRefusingNewNetworkConnections is deprecated. Use the RefuseNewNetworkConnections property instead.")]
        public bool IsRefusingNewNetworkConnections()
        {
            return NativeCalls.godot_icall_0_7(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_allow_object_decoding");

        [GodotMethod("set_allow_object_decoding")]
        [Obsolete("SetAllowObjectDecoding is deprecated. Use the AllowObjectDecoding property instead.")]
        public void SetAllowObjectDecoding(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_14, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_object_decoding_allowed");

        [GodotMethod("is_object_decoding_allowed")]
        [Obsolete("IsObjectDecodingAllowed is deprecated. Use the AllowObjectDecoding property instead.")]
        public bool IsObjectDecodingAllowed()
        {
            return NativeCalls.godot_icall_0_7(method_bind_15, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
