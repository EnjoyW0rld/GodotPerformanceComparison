using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A WebRTC connection between the local computer and a remote peer. Provides an interface to connect, maintain and monitor the connection.</para>
    /// <para>Setting up a WebRTC connection between two peers from now on) may not seem a trivial task, but it can be broken down into 3 main steps:</para>
    /// <para>- The peer that wants to initiate the connection (<c>A</c> from now on) creates an offer and send it to the other peer (<c>B</c> from now on).</para>
    /// <para>- <c>B</c> receives the offer, generate and answer, and sends it to <c>A</c>).</para>
    /// <para>- <c>A</c> and <c>B</c> then generates and exchange ICE candidates with each other.</para>
    /// <para>After these steps, the connection should become connected. Keep on reading or look into the tutorial for more information.</para>
    /// </summary>
    public partial class WebRTCPeerConnection : Reference
    {
        public enum ConnectionState
        {
            /// <summary>
            /// <para>The connection is new, data channels and an offer can be created in this state.</para>
            /// </summary>
            New = 0,
            /// <summary>
            /// <para>The peer is connecting, ICE is in progress, none of the transports has failed.</para>
            /// </summary>
            Connecting = 1,
            /// <summary>
            /// <para>The peer is connected, all ICE transports are connected.</para>
            /// </summary>
            Connected = 2,
            /// <summary>
            /// <para>At least one ICE transport is disconnected.</para>
            /// </summary>
            Disconnected = 3,
            /// <summary>
            /// <para>One or more of the ICE transports failed.</para>
            /// </summary>
            Failed = 4,
            /// <summary>
            /// <para>The peer connection is closed (after calling <see cref="Godot.WebRTCPeerConnection.Close"/> for example).</para>
            /// </summary>
            Closed = 5
        }

        private const string nativeName = "WebRTCPeerConnection";

        public WebRTCPeerConnection() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_WebRTCPeerConnection_Ctor(this);
        }

        internal WebRTCPeerConnection(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "initialize");

        /// <summary>
        /// <para>Re-initialize this peer connection, closing any previously active connection, and going back to state <see cref="Godot.WebRTCPeerConnection.ConnectionState.New"/>. A dictionary of <c>options</c> can be passed to configure the peer connection.</para>
        /// <para>Valid <c>options</c> are:</para>
        /// <para><code>
        /// {
        ///     "iceServers": [
        ///         {
        ///             "urls": [ "stun:stun.example.com:3478" ], # One or more STUN servers.
        ///         },
        ///         {
        ///             "urls": [ "turn:turn.example.com:3478" ], # One or more TURN servers.
        ///             "username": "a_username", # Optional username for the TURN server.
        ///             "credential": "a_password", # Optional password for the TURN server.
        ///         }
        ///     ]
        /// }
        /// </code></para>
        /// </summary>
        /// <param name="configuration">If the parameter is null, then the default value is new Godot.Collections.Dictionary()</param>
        [GodotMethod("initialize")]
        public Error Initialize(Godot.Collections.Dictionary configuration = null)
        {
            Godot.Collections.Dictionary configuration_in = configuration != null ? configuration : new Godot.Collections.Dictionary();
            return (Error)NativeCalls.godot_icall_1_1154(method_bind_0, Object.GetPtr(this), configuration_in.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_data_channel");

        /// <summary>
        /// <para>Returns a new <see cref="Godot.WebRTCDataChannel"/> (or <c>null</c> on failure) with given <c>label</c> and optionally configured via the <c>options</c> dictionary. This method can only be called when the connection is in state <see cref="Godot.WebRTCPeerConnection.ConnectionState.New"/>.</para>
        /// <para>There are two ways to create a working data channel: either call <see cref="Godot.WebRTCPeerConnection.CreateDataChannel"/> on only one of the peer and listen to <c>data_channel_received</c> on the other, or call <see cref="Godot.WebRTCPeerConnection.CreateDataChannel"/> on both peers, with the same values, and the <c>negotiated</c> option set to <c>true</c>.</para>
        /// <para>Valid <c>options</c> are:</para>
        /// <para><code>
        /// {
        ///     "negotiated": true, # When set to true (default off), means the channel is negotiated out of band. "id" must be set too. "data_channel_received" will not be called.
        ///     "id": 1, # When "negotiated" is true this value must also be set to the same value on both peer.
        /// 
        ///     # Only one of maxRetransmits and maxPacketLifeTime can be specified, not both. They make the channel unreliable (but also better at real time).
        ///     "maxRetransmits": 1, # Specify the maximum number of attempt the peer will make to retransmits packets if they are not acknowledged.
        ///     "maxPacketLifeTime": 100, # Specify the maximum amount of time before giving up retransmitions of unacknowledged packets (in milliseconds).
        ///     "ordered": true, # When in unreliable mode (i.e. either "maxRetransmits" or "maxPacketLifetime" is set), "ordered" (true by default) specify if packet ordering is to be enforced.
        /// 
        ///     "protocol": "my-custom-protocol", # A custom sub-protocol string for this channel.
        /// }
        /// </code></para>
        /// <para>Note: You must keep a reference to channels created this way, or it will be closed.</para>
        /// </summary>
        /// <param name="options">If the parameter is null, then the default value is new Godot.Collections.Dictionary()</param>
        [GodotMethod("create_data_channel")]
        public WebRTCDataChannel CreateDataChannel(string label, Godot.Collections.Dictionary options = null)
        {
            Godot.Collections.Dictionary options_in = options != null ? options : new Godot.Collections.Dictionary();
            return NativeCalls.godot_icall_2_1155(method_bind_1, Object.GetPtr(this), label, options_in.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_offer");

        /// <summary>
        /// <para>Creates a new SDP offer to start a WebRTC connection with a remote peer. At least one <see cref="Godot.WebRTCDataChannel"/> must have been created before calling this method.</para>
        /// <para>If this functions returns <c>OK</c>, <c>session_description_created</c> will be called when the session is ready to be sent.</para>
        /// </summary>
        [GodotMethod("create_offer")]
        public Error CreateOffer()
        {
            return (Error)NativeCalls.godot_icall_0_389(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_local_description");

        /// <summary>
        /// <para>Sets the SDP description of the local peer. This should be called in response to <c>session_description_created</c>.</para>
        /// <para>After calling this function the peer will start emitting <c>ice_candidate_created</c> (unless an <see cref="Godot.Error"/> different from <c>OK</c> is returned).</para>
        /// </summary>
        [GodotMethod("set_local_description")]
        public Error SetLocalDescription(string type, string sdp)
        {
            return (Error)NativeCalls.godot_icall_2_136(method_bind_3, Object.GetPtr(this), type, sdp);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_remote_description");

        /// <summary>
        /// <para>Sets the SDP description of the remote peer. This should be called with the values generated by a remote peer and received over the signaling server.</para>
        /// <para>If <c>type</c> is <c>offer</c> the peer will emit <c>session_description_created</c> with the appropriate answer.</para>
        /// <para>If <c>type</c> is <c>answer</c> the peer will start emitting <c>ice_candidate_created</c>.</para>
        /// </summary>
        [GodotMethod("set_remote_description")]
        public Error SetRemoteDescription(string type, string sdp)
        {
            return (Error)NativeCalls.godot_icall_2_136(method_bind_4, Object.GetPtr(this), type, sdp);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_ice_candidate");

        /// <summary>
        /// <para>Add an ice candidate generated by a remote peer (and received over the signaling server). See <c>ice_candidate_created</c>.</para>
        /// </summary>
        [GodotMethod("add_ice_candidate")]
        public Error AddIceCandidate(string media, int index, string name)
        {
            return (Error)NativeCalls.godot_icall_3_1156(method_bind_5, Object.GetPtr(this), media, index, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "poll");

        /// <summary>
        /// <para>Call this method frequently (e.g. in <see cref="Godot.Node._Process"/> or <see cref="Godot.Node._PhysicsProcess"/>) to properly receive signals.</para>
        /// </summary>
        [GodotMethod("poll")]
        public Error Poll()
        {
            return (Error)NativeCalls.godot_icall_0_389(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "close");

        /// <summary>
        /// <para>Close the peer connection and all data channels associated with it.</para>
        /// <para>Note: You cannot reuse this object for a new connection unless you call <see cref="Godot.WebRTCPeerConnection.Initialize"/>.</para>
        /// </summary>
        [GodotMethod("close")]
        public void Close()
        {
            NativeCalls.godot_icall_0_3(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connection_state");

        /// <summary>
        /// <para>Returns the connection state. See <see cref="Godot.WebRTCPeerConnection.ConnectionState"/>.</para>
        /// </summary>
        [GodotMethod("get_connection_state")]
        public WebRTCPeerConnection.ConnectionState GetConnectionState()
        {
            return (WebRTCPeerConnection.ConnectionState)NativeCalls.godot_icall_0_1157(method_bind_8, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
