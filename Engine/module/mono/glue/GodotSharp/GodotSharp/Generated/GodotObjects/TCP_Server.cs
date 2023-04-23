using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A TCP server. Listens to connections on a port and returns a <see cref="Godot.StreamPeerTCP"/> when it gets an incoming connection.</para>
    /// </summary>
    public partial class TCP_Server : Reference
    {
        private const string nativeName = "TCP_Server";

        public TCP_Server() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_TCP_Server_Ctor(this);
        }

        internal TCP_Server(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "listen");

        /// <summary>
        /// <para>Listen on the <c>port</c> binding to <c>bind_address</c>.</para>
        /// <para>If <c>bind_address</c> is set as <c>"*"</c> (default), the server will listen on all available addresses (both IPv4 and IPv6).</para>
        /// <para>If <c>bind_address</c> is set as <c>"0.0.0.0"</c> (for IPv4) or <c>"::"</c> (for IPv6), the server will listen on all available addresses matching that IP type.</para>
        /// <para>If <c>bind_address</c> is set to any valid address (e.g. <c>"192.168.1.101"</c>, <c>"::1"</c>, etc), the server will only listen on the interface with that addresses (or fail if no interface with the given address exists).</para>
        /// </summary>
        [GodotMethod("listen")]
        public Error Listen(ushort port, string bindAddress = "*")
        {
            return (Error)NativeCalls.godot_icall_2_910(method_bind_0, Object.GetPtr(this), port, bindAddress);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_connection_available");

        /// <summary>
        /// <para>Returns <c>true</c> if a connection is available for taking.</para>
        /// </summary>
        [GodotMethod("is_connection_available")]
        public bool IsConnectionAvailable()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_listening");

        /// <summary>
        /// <para>Returns <c>true</c> if the server is currently listening for connections.</para>
        /// </summary>
        [GodotMethod("is_listening")]
        public bool IsListening()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "take_connection");

        /// <summary>
        /// <para>If a connection is available, returns a StreamPeerTCP with the connection.</para>
        /// </summary>
        [GodotMethod("take_connection")]
        public StreamPeerTCP TakeConnection()
        {
            return NativeCalls.godot_icall_0_911(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "stop");

        /// <summary>
        /// <para>Stops listening.</para>
        /// </summary>
        [GodotMethod("stop")]
        public void Stop()
        {
            NativeCalls.godot_icall_0_3(method_bind_4, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
