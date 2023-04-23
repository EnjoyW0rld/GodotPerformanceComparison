using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Base class for WebSocket server and client, allowing them to be used as network peer for the <see cref="Godot.MultiplayerAPI"/>.</para>
    /// </summary>
    public abstract partial class WebSocketMultiplayerPeer : NetworkedMultiplayerPeer
    {
        private const string nativeName = "WebSocketMultiplayerPeer";

        internal WebSocketMultiplayerPeer() {}

        internal WebSocketMultiplayerPeer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_buffers");

        /// <summary>
        /// <para>Configures the buffer sizes for this WebSocket peer. Default values can be specified in the Project Settings under <c>network/limits</c>. For server, values are meant per connected peer.</para>
        /// <para>The first two parameters define the size and queued packets limits of the input buffer, the last two of the output buffer.</para>
        /// <para>Buffer sizes are expressed in KiB, so <c>4 = 2^12 = 4096 bytes</c>. All parameters will be rounded up to the nearest power of two.</para>
        /// <para>Note: HTML5 exports only use the input buffer since the output one is managed by browsers.</para>
        /// </summary>
        [GodotMethod("set_buffers")]
        public Error SetBuffers(int inputBufferSizeKb, int inputMaxPackets, int outputBufferSizeKb, int outputMaxPackets)
        {
            return (Error)NativeCalls.godot_icall_4_666(method_bind_0, Object.GetPtr(this), inputBufferSizeKb, inputMaxPackets, outputBufferSizeKb, outputMaxPackets);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_peer");

        /// <summary>
        /// <para>Returns the <see cref="Godot.WebSocketPeer"/> associated to the given <c>peer_id</c>.</para>
        /// </summary>
        [GodotMethod("get_peer")]
        public WebSocketPeer GetPeer(int peerId)
        {
            return NativeCalls.godot_icall_1_1160(method_bind_1, Object.GetPtr(this), peerId);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
