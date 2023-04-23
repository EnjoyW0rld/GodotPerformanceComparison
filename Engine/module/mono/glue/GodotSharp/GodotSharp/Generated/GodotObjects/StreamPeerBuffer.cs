using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Data buffer stream peer that uses a byte array as the stream. This object can be used to handle binary data from network sessions. To handle binary data stored in files, <see cref="Godot.File"/> can be used directly.</para>
    /// <para>A <see cref="Godot.StreamPeerBuffer"/> object keeps an internal cursor which is the offset in bytes to the start of the buffer. Get and put operations are performed at the cursor position and will move the cursor accordingly.</para>
    /// </summary>
    public partial class StreamPeerBuffer : StreamPeer
    {
        /// <summary>
        /// <para>The underlying data buffer. Setting this value resets the cursor.</para>
        /// </summary>
        public byte[] DataArray
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDataArray();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDataArray(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "StreamPeerBuffer";

        public StreamPeerBuffer() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_StreamPeerBuffer_Ctor(this);
        }

        internal StreamPeerBuffer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "seek");

        /// <summary>
        /// <para>Moves the cursor to the specified position. <c>position</c> must be a valid index of <see cref="Godot.StreamPeerBuffer.DataArray"/>.</para>
        /// </summary>
        [GodotMethod("seek")]
        public void Seek(int position)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_size");

        /// <summary>
        /// <para>Returns the size of <see cref="Godot.StreamPeerBuffer.DataArray"/>.</para>
        /// </summary>
        [GodotMethod("get_size")]
        public int GetSize()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_position");

        /// <summary>
        /// <para>Returns the current cursor position.</para>
        /// </summary>
        [GodotMethod("get_position")]
        public int GetPosition()
        {
            return NativeCalls.godot_icall_0_5(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "resize");

        /// <summary>
        /// <para>Resizes the <see cref="Godot.StreamPeerBuffer.DataArray"/>. This doesn't update the cursor.</para>
        /// </summary>
        [GodotMethod("resize")]
        public void Resize(int size)
        {
            NativeCalls.godot_icall_1_4(method_bind_3, Object.GetPtr(this), size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_data_array");

        [GodotMethod("set_data_array")]
        [Obsolete("SetDataArray is deprecated. Use the DataArray property instead.")]
        public void SetDataArray(byte[] data)
        {
            NativeCalls.godot_icall_1_183(method_bind_4, Object.GetPtr(this), data);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_data_array");

        [GodotMethod("get_data_array")]
        [Obsolete("GetDataArray is deprecated. Use the DataArray property instead.")]
        public byte[] GetDataArray()
        {
            return NativeCalls.godot_icall_0_2(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Clears the <see cref="Godot.StreamPeerBuffer.DataArray"/> and resets the cursor.</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "duplicate");

        /// <summary>
        /// <para>Returns a new <see cref="Godot.StreamPeerBuffer"/> with the same <see cref="Godot.StreamPeerBuffer.DataArray"/> content.</para>
        /// </summary>
        [GodotMethod("duplicate")]
        public StreamPeerBuffer Duplicate()
        {
            return NativeCalls.godot_icall_0_896(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
