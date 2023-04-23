using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>PacketPeer is an abstraction and base class for packet-based protocols (such as UDP). It provides an API for sending and receiving packets both as raw data or variables. This makes it easy to transfer data over a protocol, without having to encode data as low-level bytes or having to worry about network ordering.</para>
    /// </summary>
    public abstract partial class PacketPeer : Reference
    {
        /// <summary>
        /// <para>Maximum buffer size allowed when encoding <c>Variant</c>s. Raise this value to support heavier memory allocations.</para>
        /// <para>The <see cref="Godot.PacketPeer.PutVar"/> method allocates memory on the stack, and the buffer used will grow automatically to the closest power of two to match the size of the <c>Variant</c>. If the <c>Variant</c> is bigger than <c>encode_buffer_max_size</c>, the method will error out with <c>ERR_OUT_OF_MEMORY</c>.</para>
        /// </summary>
        public int EncodeBufferMaxSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEncodeBufferMaxSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEncodeBufferMaxSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Deprecated. Use <c>get_var</c> and <c>put_var</c> parameters instead.</para>
        /// <para>If <c>true</c>, the PacketPeer will allow encoding and decoding of object via <see cref="Godot.PacketPeer.GetVar"/> and <see cref="Godot.PacketPeer.PutVar"/>.</para>
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

        private const string nativeName = "PacketPeer";

        internal PacketPeer() {}

        internal PacketPeer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_var");

        /// <summary>
        /// <para>Gets a Variant. If <c>allow_objects</c> (or <see cref="Godot.PacketPeer.AllowObjectDecoding"/>) is <c>true</c>, decoding objects is allowed.</para>
        /// <para>Warning: Deserialized objects can contain code which gets executed. Do not use this option if the serialized object comes from untrusted sources to avoid potential security threats such as remote code execution.</para>
        /// </summary>
        [GodotMethod("get_var")]
        public object GetVar(bool allowObjects = false)
        {
            return NativeCalls.godot_icall_1_716(method_bind_0, Object.GetPtr(this), allowObjects);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "put_var");

        /// <summary>
        /// <para>Sends a <c>Variant</c> as a packet. If <c>full_objects</c> (or <see cref="Godot.PacketPeer.AllowObjectDecoding"/>) is <c>true</c>, encoding objects is allowed (and can potentially include code).</para>
        /// </summary>
        [GodotMethod("put_var")]
        public Error PutVar(object var, bool fullObjects = false)
        {
            return (Error)NativeCalls.godot_icall_2_717(method_bind_1, Object.GetPtr(this), var, fullObjects);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_packet");

        /// <summary>
        /// <para>Gets a raw packet.</para>
        /// </summary>
        [GodotMethod("get_packet")]
        public byte[] GetPacket()
        {
            return NativeCalls.godot_icall_0_2(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "put_packet");

        /// <summary>
        /// <para>Sends a raw packet.</para>
        /// </summary>
        [GodotMethod("put_packet")]
        public Error PutPacket(byte[] buffer)
        {
            return (Error)NativeCalls.godot_icall_1_487(method_bind_3, Object.GetPtr(this), buffer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_packet_error");

        /// <summary>
        /// <para>Returns the error state of the last packet received (via <see cref="Godot.PacketPeer.GetPacket"/> and <see cref="Godot.PacketPeer.GetVar"/>).</para>
        /// </summary>
        [GodotMethod("get_packet_error")]
        public Error GetPacketError()
        {
            return (Error)NativeCalls.godot_icall_0_389(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_available_packet_count");

        /// <summary>
        /// <para>Returns the number of packets currently available in the ring-buffer.</para>
        /// </summary>
        [GodotMethod("get_available_packet_count")]
        public int GetAvailablePacketCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_allow_object_decoding");

        [GodotMethod("set_allow_object_decoding")]
        [Obsolete("SetAllowObjectDecoding is deprecated. Use the AllowObjectDecoding property instead.")]
        public void SetAllowObjectDecoding(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_object_decoding_allowed");

        [GodotMethod("is_object_decoding_allowed")]
        [Obsolete("IsObjectDecodingAllowed is deprecated. Use the AllowObjectDecoding property instead.")]
        public bool IsObjectDecodingAllowed()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_encode_buffer_max_size");

        [GodotMethod("get_encode_buffer_max_size")]
        [Obsolete("GetEncodeBufferMaxSize is deprecated. Use the EncodeBufferMaxSize property instead.")]
        public int GetEncodeBufferMaxSize()
        {
            return NativeCalls.godot_icall_0_5(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_encode_buffer_max_size");

        [GodotMethod("set_encode_buffer_max_size")]
        [Obsolete("SetEncodeBufferMaxSize is deprecated. Use the EncodeBufferMaxSize property instead.")]
        public void SetEncodeBufferMaxSize(int maxSize)
        {
            NativeCalls.godot_icall_1_4(method_bind_9, Object.GetPtr(this), maxSize);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
