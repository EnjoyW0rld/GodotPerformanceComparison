using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>StreamPeer is an abstraction and base class for stream-based protocols (such as TCP). It provides an API for sending and receiving data through streams as raw data or strings.</para>
    /// </summary>
    public abstract partial class StreamPeer : Reference
    {
        /// <summary>
        /// <para>If <c>true</c>, this <see cref="Godot.StreamPeer"/> will using big-endian format for encoding and decoding.</para>
        /// </summary>
        public bool BigEndian
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsBigEndianEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBigEndian(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "StreamPeer";

        internal StreamPeer() {}

        internal StreamPeer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "put_data");

        /// <summary>
        /// <para>Sends a chunk of data through the connection, blocking if necessary until the data is done sending. This function returns an <see cref="Godot.Error"/> code.</para>
        /// </summary>
        [GodotMethod("put_data")]
        public Error PutData(byte[] data)
        {
            return (Error)NativeCalls.godot_icall_1_487(method_bind_0, Object.GetPtr(this), data);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "put_partial_data");

        /// <summary>
        /// <para>Sends a chunk of data through the connection. If all the data could not be sent at once, only part of it will. This function returns two values, an <see cref="Godot.Error"/> code and an integer, describing how much data was actually sent.</para>
        /// </summary>
        [GodotMethod("put_partial_data")]
        public Godot.Collections.Array PutPartialData(byte[] data)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_1_885(method_bind_1, Object.GetPtr(this), data));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_data");

        /// <summary>
        /// <para>Returns a chunk data with the received bytes. The amount of bytes to be received can be requested in the <c>bytes</c> argument. If not enough bytes are available, the function will block until the desired amount is received. This function returns two values, an <see cref="Godot.Error"/> code and a data array.</para>
        /// </summary>
        [GodotMethod("get_data")]
        public Godot.Collections.Array GetData(int bytes)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_1_483(method_bind_2, Object.GetPtr(this), bytes));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_partial_data");

        /// <summary>
        /// <para>Returns a chunk data with the received bytes. The amount of bytes to be received can be requested in the "bytes" argument. If not enough bytes are available, the function will return how many were actually received. This function returns two values, an <see cref="Godot.Error"/> code, and a data array.</para>
        /// </summary>
        [GodotMethod("get_partial_data")]
        public Godot.Collections.Array GetPartialData(int bytes)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_1_483(method_bind_3, Object.GetPtr(this), bytes));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_available_bytes");

        /// <summary>
        /// <para>Returns the amount of bytes this <see cref="Godot.StreamPeer"/> has available.</para>
        /// </summary>
        [GodotMethod("get_available_bytes")]
        public int GetAvailableBytes()
        {
            return NativeCalls.godot_icall_0_5(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_big_endian");

        [GodotMethod("set_big_endian")]
        [Obsolete("SetBigEndian is deprecated. Use the BigEndian property instead.")]
        public void SetBigEndian(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_5, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_big_endian_enabled");

        [GodotMethod("is_big_endian_enabled")]
        [Obsolete("IsBigEndianEnabled is deprecated. Use the BigEndian property instead.")]
        public bool IsBigEndianEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "put_8");

        /// <summary>
        /// <para>Puts a signed byte into the stream.</para>
        /// </summary>
        [GodotMethod("put_8")]
        public void Put8(sbyte value)
        {
            NativeCalls.godot_icall_1_886(method_bind_7, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "put_u8");

        /// <summary>
        /// <para>Puts an unsigned byte into the stream.</para>
        /// </summary>
        [GodotMethod("put_u8")]
        public void PutU8(byte value)
        {
            NativeCalls.godot_icall_1_887(method_bind_8, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "put_16");

        /// <summary>
        /// <para>Puts a signed 16-bit value into the stream.</para>
        /// </summary>
        [GodotMethod("put_16")]
        public void Put16(short value)
        {
            NativeCalls.godot_icall_1_888(method_bind_9, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "put_u16");

        /// <summary>
        /// <para>Puts an unsigned 16-bit value into the stream.</para>
        /// </summary>
        [GodotMethod("put_u16")]
        public void PutU16(ushort value)
        {
            NativeCalls.godot_icall_1_889(method_bind_10, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "put_32");

        /// <summary>
        /// <para>Puts a signed 32-bit value into the stream.</para>
        /// </summary>
        [GodotMethod("put_32")]
        public void Put32(int value)
        {
            NativeCalls.godot_icall_1_4(method_bind_11, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "put_u32");

        /// <summary>
        /// <para>Puts an unsigned 32-bit value into the stream.</para>
        /// </summary>
        [GodotMethod("put_u32")]
        public void PutU32(uint value)
        {
            NativeCalls.godot_icall_1_187(method_bind_12, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "put_64");

        /// <summary>
        /// <para>Puts a signed 64-bit value into the stream.</para>
        /// </summary>
        [GodotMethod("put_64")]
        public void Put64(long value)
        {
            NativeCalls.godot_icall_1_890(method_bind_13, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "put_u64");

        /// <summary>
        /// <para>Puts an unsigned 64-bit value into the stream.</para>
        /// </summary>
        [GodotMethod("put_u64")]
        public void PutU64(ulong value)
        {
            NativeCalls.godot_icall_1_283(method_bind_14, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "put_float");

        /// <summary>
        /// <para>Puts a single-precision float into the stream.</para>
        /// </summary>
        [GodotMethod("put_float")]
        public void PutFloat(float value)
        {
            NativeCalls.godot_icall_1_15(method_bind_15, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "put_double");

        /// <summary>
        /// <para>Puts a double-precision float into the stream.</para>
        /// </summary>
        [GodotMethod("put_double")]
        public void PutDouble(double value)
        {
            NativeCalls.godot_icall_1_496(method_bind_16, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "put_string");

        /// <summary>
        /// <para>Puts a zero-terminated ASCII string into the stream prepended by a 32-bit unsigned integer representing its size.</para>
        /// <para>Note: To put an ASCII string without prepending its size, you can use <see cref="Godot.StreamPeer.PutData"/>:</para>
        /// <para><code>
        /// put_data("Hello world".to_ascii())
        /// </code></para>
        /// </summary>
        [GodotMethod("put_string")]
        public void PutString(string value)
        {
            NativeCalls.godot_icall_1_54(method_bind_17, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "put_utf8_string");

        /// <summary>
        /// <para>Puts a zero-terminated UTF-8 string into the stream prepended by a 32 bits unsigned integer representing its size.</para>
        /// <para>Note: To put an UTF-8 string without prepending its size, you can use <see cref="Godot.StreamPeer.PutData"/>:</para>
        /// <para><code>
        /// put_data("Hello world".to_utf8())
        /// </code></para>
        /// </summary>
        [GodotMethod("put_utf8_string")]
        public void PutUtf8String(string value)
        {
            NativeCalls.godot_icall_1_54(method_bind_18, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "put_var");

        /// <summary>
        /// <para>Puts a Variant into the stream. If <c>full_objects</c> is <c>true</c> encoding objects is allowed (and can potentially include code).</para>
        /// </summary>
        [GodotMethod("put_var")]
        public void PutVar(object value, bool fullObjects = false)
        {
            NativeCalls.godot_icall_2_891(method_bind_19, Object.GetPtr(this), value, fullObjects);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_8");

        /// <summary>
        /// <para>Gets a signed byte from the stream.</para>
        /// </summary>
        [GodotMethod("get_8")]
        public sbyte Get8()
        {
            return NativeCalls.godot_icall_0_892(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_u8");

        /// <summary>
        /// <para>Gets an unsigned byte from the stream.</para>
        /// </summary>
        [GodotMethod("get_u8")]
        public byte GetU8()
        {
            return NativeCalls.godot_icall_0_893(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_16");

        /// <summary>
        /// <para>Gets a signed 16-bit value from the stream.</para>
        /// </summary>
        [GodotMethod("get_16")]
        public short Get16()
        {
            return NativeCalls.godot_icall_0_894(method_bind_22, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_u16");

        /// <summary>
        /// <para>Gets an unsigned 16-bit value from the stream.</para>
        /// </summary>
        [GodotMethod("get_u16")]
        public ushort GetU16()
        {
            return NativeCalls.godot_icall_0_895(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_32");

        /// <summary>
        /// <para>Gets a signed 32-bit value from the stream.</para>
        /// </summary>
        [GodotMethod("get_32")]
        public int Get32()
        {
            return NativeCalls.godot_icall_0_5(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_u32");

        /// <summary>
        /// <para>Gets an unsigned 32-bit value from the stream.</para>
        /// </summary>
        [GodotMethod("get_u32")]
        public uint GetU32()
        {
            return NativeCalls.godot_icall_0_188(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_64");

        /// <summary>
        /// <para>Gets a signed 64-bit value from the stream.</para>
        /// </summary>
        [GodotMethod("get_64")]
        public long Get64()
        {
            return NativeCalls.godot_icall_0_165(method_bind_26, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_u64");

        /// <summary>
        /// <para>Gets an unsigned 64-bit value from the stream.</para>
        /// </summary>
        [GodotMethod("get_u64")]
        public ulong GetU64()
        {
            return NativeCalls.godot_icall_0_30(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_float");

        /// <summary>
        /// <para>Gets a single-precision float from the stream.</para>
        /// </summary>
        [GodotMethod("get_float")]
        public float GetFloat()
        {
            return NativeCalls.godot_icall_0_14(method_bind_28, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_double");

        /// <summary>
        /// <para>Gets a double-precision float from the stream.</para>
        /// </summary>
        [GodotMethod("get_double")]
        public double GetDouble()
        {
            return NativeCalls.godot_icall_0_179(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_string");

        /// <summary>
        /// <para>Gets an ASCII string with byte-length <c>bytes</c> from the stream. If <c>bytes</c> is negative (default) the length will be read from the stream using the reverse process of <see cref="Godot.StreamPeer.PutString"/>.</para>
        /// </summary>
        [GodotMethod("get_string")]
        public string GetString(int bytes = -1)
        {
            return NativeCalls.godot_icall_1_89(method_bind_30, Object.GetPtr(this), bytes);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_utf8_string");

        /// <summary>
        /// <para>Gets an UTF-8 string with byte-length <c>bytes</c> from the stream (this decodes the string sent as UTF-8). If <c>bytes</c> is negative (default) the length will be read from the stream using the reverse process of <see cref="Godot.StreamPeer.PutUtf8String"/>.</para>
        /// </summary>
        [GodotMethod("get_utf8_string")]
        public string GetUtf8String(int bytes = -1)
        {
            return NativeCalls.godot_icall_1_89(method_bind_31, Object.GetPtr(this), bytes);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_var");

        /// <summary>
        /// <para>Gets a Variant from the stream. If <c>allow_objects</c> is <c>true</c>, decoding objects is allowed.</para>
        /// <para>Warning: Deserialized objects can contain code which gets executed. Do not use this option if the serialized object comes from untrusted sources to avoid potential security threats such as remote code execution.</para>
        /// </summary>
        [GodotMethod("get_var")]
        public object GetVar(bool allowObjects = false)
        {
            return NativeCalls.godot_icall_1_716(method_bind_32, Object.GetPtr(this), allowObjects);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
