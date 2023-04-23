using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Note: This class is only compiled in editor builds. Run-time glTF loading and saving is not available in exported projects. References to <see cref="Godot.GLTFBufferView"/> within a script will cause an error in an exported project.</para>
    /// </summary>
    public partial class GLTFBufferView : Resource
    {
        public int Buffer
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBuffer();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBuffer(value);
            }
#pragma warning restore CS0618
        }

        public int ByteOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetByteOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetByteOffset(value);
            }
#pragma warning restore CS0618
        }

        public int ByteLength
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetByteLength();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetByteLength(value);
            }
#pragma warning restore CS0618
        }

        public int ByteStride
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetByteStride();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetByteStride(value);
            }
#pragma warning restore CS0618
        }

        public bool Indices
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetIndices();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetIndices(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "GLTFBufferView";

        public GLTFBufferView() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GLTFBufferView_Ctor(this);
        }

        internal GLTFBufferView(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_buffer");

        [GodotMethod("get_buffer")]
        [Obsolete("GetBuffer is deprecated. Use the Buffer property instead.")]
        public int GetBuffer()
        {
            return NativeCalls.godot_icall_0_5(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_buffer");

        [GodotMethod("set_buffer")]
        [Obsolete("SetBuffer is deprecated. Use the Buffer property instead.")]
        public void SetBuffer(int buffer)
        {
            NativeCalls.godot_icall_1_4(method_bind_1, Object.GetPtr(this), buffer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_byte_offset");

        [GodotMethod("get_byte_offset")]
        [Obsolete("GetByteOffset is deprecated. Use the ByteOffset property instead.")]
        public int GetByteOffset()
        {
            return NativeCalls.godot_icall_0_5(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_byte_offset");

        [GodotMethod("set_byte_offset")]
        [Obsolete("SetByteOffset is deprecated. Use the ByteOffset property instead.")]
        public void SetByteOffset(int byteOffset)
        {
            NativeCalls.godot_icall_1_4(method_bind_3, Object.GetPtr(this), byteOffset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_byte_length");

        [GodotMethod("get_byte_length")]
        [Obsolete("GetByteLength is deprecated. Use the ByteLength property instead.")]
        public int GetByteLength()
        {
            return NativeCalls.godot_icall_0_5(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_byte_length");

        [GodotMethod("set_byte_length")]
        [Obsolete("SetByteLength is deprecated. Use the ByteLength property instead.")]
        public void SetByteLength(int byteLength)
        {
            NativeCalls.godot_icall_1_4(method_bind_5, Object.GetPtr(this), byteLength);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_byte_stride");

        [GodotMethod("get_byte_stride")]
        [Obsolete("GetByteStride is deprecated. Use the ByteStride property instead.")]
        public int GetByteStride()
        {
            return NativeCalls.godot_icall_0_5(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_byte_stride");

        [GodotMethod("set_byte_stride")]
        [Obsolete("SetByteStride is deprecated. Use the ByteStride property instead.")]
        public void SetByteStride(int byteStride)
        {
            NativeCalls.godot_icall_1_4(method_bind_7, Object.GetPtr(this), byteStride);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_indices");

        [GodotMethod("get_indices")]
        [Obsolete("GetIndices is deprecated. Use the Indices property instead.")]
        public bool GetIndices()
        {
            return NativeCalls.godot_icall_0_7(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_indices");

        [GodotMethod("set_indices")]
        [Obsolete("SetIndices is deprecated. Use the Indices property instead.")]
        public void SetIndices(bool indices)
        {
            NativeCalls.godot_icall_1_16(method_bind_9, Object.GetPtr(this), indices);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
