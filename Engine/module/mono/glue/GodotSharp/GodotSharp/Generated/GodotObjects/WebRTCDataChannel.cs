using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public abstract partial class WebRTCDataChannel : PacketPeer
    {
        public enum WriteModeEnum
        {
            /// <summary>
            /// <para>Tells the channel to send data over this channel as text. An external peer (non-Godot) would receive this as a string.</para>
            /// </summary>
            Text = 0,
            /// <summary>
            /// <para>Tells the channel to send data over this channel as binary. An external peer (non-Godot) would receive this as array buffer or blob.</para>
            /// </summary>
            Binary = 1
        }

        public enum ChannelState
        {
            /// <summary>
            /// <para>The channel was created, but it's still trying to connect.</para>
            /// </summary>
            Connecting = 0,
            /// <summary>
            /// <para>The channel is currently open, and data can flow over it.</para>
            /// </summary>
            Open = 1,
            /// <summary>
            /// <para>The channel is being closed, no new messages will be accepted, but those already in queue will be flushed.</para>
            /// </summary>
            Closing = 2,
            /// <summary>
            /// <para>The channel was closed, or connection failed.</para>
            /// </summary>
            Closed = 3
        }

        /// <summary>
        /// <para>The transfer mode to use when sending outgoing packet. Either text or binary.</para>
        /// </summary>
        public WebRTCDataChannel.WriteModeEnum WriteMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetWriteMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetWriteMode(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "WebRTCDataChannel";

        internal WebRTCDataChannel() {}

        internal WebRTCDataChannel(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "poll");

        /// <summary>
        /// <para>Reserved, but not used for now.</para>
        /// </summary>
        [GodotMethod("poll")]
        public Error Poll()
        {
            return (Error)NativeCalls.godot_icall_0_389(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "close");

        /// <summary>
        /// <para>Closes this data channel, notifying the other peer.</para>
        /// </summary>
        [GodotMethod("close")]
        public void Close()
        {
            NativeCalls.godot_icall_0_3(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "was_string_packet");

        /// <summary>
        /// <para>Returns <c>true</c> if the last received packet was transferred as text. See <see cref="Godot.WebRTCDataChannel.WriteMode"/>.</para>
        /// </summary>
        [GodotMethod("was_string_packet")]
        public bool WasStringPacket()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_write_mode");

        [GodotMethod("set_write_mode")]
        [Obsolete("SetWriteMode is deprecated. Use the WriteMode property instead.")]
        public void SetWriteMode(WebRTCDataChannel.WriteModeEnum writeMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_3, Object.GetPtr(this), (int)writeMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_write_mode");

        [GodotMethod("get_write_mode")]
        [Obsolete("GetWriteMode is deprecated. Use the WriteMode property instead.")]
        public WebRTCDataChannel.WriteModeEnum GetWriteMode()
        {
            return (WebRTCDataChannel.WriteModeEnum)NativeCalls.godot_icall_0_1150(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ready_state");

        /// <summary>
        /// <para>Returns the current state of this channel, see <see cref="Godot.WebRTCDataChannel.ChannelState"/>.</para>
        /// </summary>
        [GodotMethod("get_ready_state")]
        public WebRTCDataChannel.ChannelState GetReadyState()
        {
            return (WebRTCDataChannel.ChannelState)NativeCalls.godot_icall_0_1151(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_label");

        /// <summary>
        /// <para>Returns the label assigned to this channel during creation.</para>
        /// </summary>
        [GodotMethod("get_label")]
        public string GetLabel()
        {
            return NativeCalls.godot_icall_0_6(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_ordered");

        /// <summary>
        /// <para>Returns <c>true</c> if this channel was created with ordering enabled (default).</para>
        /// </summary>
        [GodotMethod("is_ordered")]
        public bool IsOrdered()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_id");

        /// <summary>
        /// <para>Returns the id assigned to this channel during creation (or auto-assigned during negotiation).</para>
        /// <para>If the channel is not negotiated out-of-band the id will only be available after the connection is established (will return <c>65535</c> until then).</para>
        /// </summary>
        [GodotMethod("get_id")]
        public int GetId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max_packet_life_time");

        /// <summary>
        /// <para>Returns the <c>maxPacketLifeTime</c> value assigned to this channel during creation.</para>
        /// <para>Will be <c>65535</c> if not specified.</para>
        /// </summary>
        [GodotMethod("get_max_packet_life_time")]
        public int GetMaxPacketLifeTime()
        {
            return NativeCalls.godot_icall_0_5(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max_retransmits");

        /// <summary>
        /// <para>Returns the <c>maxRetransmits</c> value assigned to this channel during creation.</para>
        /// <para>Will be <c>65535</c> if not specified.</para>
        /// </summary>
        [GodotMethod("get_max_retransmits")]
        public int GetMaxRetransmits()
        {
            return NativeCalls.godot_icall_0_5(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_protocol");

        /// <summary>
        /// <para>Returns the sub-protocol assigned to this channel during creation. An empty string if not specified.</para>
        /// </summary>
        [GodotMethod("get_protocol")]
        public string GetProtocol()
        {
            return NativeCalls.godot_icall_0_6(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_negotiated");

        /// <summary>
        /// <para>Returns <c>true</c> if this channel was created with out-of-band configuration.</para>
        /// </summary>
        [GodotMethod("is_negotiated")]
        public bool IsNegotiated()
        {
            return NativeCalls.godot_icall_0_7(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_buffered_amount");

        /// <summary>
        /// <para>Returns the number of bytes currently queued to be sent over this channel.</para>
        /// </summary>
        [GodotMethod("get_buffered_amount")]
        public int GetBufferedAmount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_13, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
