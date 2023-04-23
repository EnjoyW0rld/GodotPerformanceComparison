using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Note: This class is only compiled in editor builds. Run-time glTF loading and saving is not available in exported projects. References to <see cref="Godot.GLTFAccessor"/> within a script will cause an error in an exported project.</para>
    /// </summary>
    public partial class GLTFAccessor : Resource
    {
        public int BufferView
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBufferView();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBufferView(value);
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

        public int ComponentType
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetComponentType();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetComponentType(value);
            }
#pragma warning restore CS0618
        }

        public bool Normalized
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNormalized();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetNormalized(value);
            }
#pragma warning restore CS0618
        }

        public int Count
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCount();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCount(value);
            }
#pragma warning restore CS0618
        }

        public int Type
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetType();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetType(value);
            }
#pragma warning restore CS0618
        }

        public float[] Min
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMin(value);
            }
#pragma warning restore CS0618
        }

        public float[] Max
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMax();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMax(value);
            }
#pragma warning restore CS0618
        }

        public int SparseCount
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSparseCount();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSparseCount(value);
            }
#pragma warning restore CS0618
        }

        public int SparseIndicesBufferView
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSparseIndicesBufferView();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSparseIndicesBufferView(value);
            }
#pragma warning restore CS0618
        }

        public int SparseIndicesByteOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSparseIndicesByteOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSparseIndicesByteOffset(value);
            }
#pragma warning restore CS0618
        }

        public int SparseIndicesComponentType
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSparseIndicesComponentType();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSparseIndicesComponentType(value);
            }
#pragma warning restore CS0618
        }

        public int SparseValuesBufferView
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSparseValuesBufferView();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSparseValuesBufferView(value);
            }
#pragma warning restore CS0618
        }

        public int SparseValuesByteOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSparseValuesByteOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSparseValuesByteOffset(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "GLTFAccessor";

        public GLTFAccessor() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GLTFAccessor_Ctor(this);
        }

        internal GLTFAccessor(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_buffer_view");

        [GodotMethod("get_buffer_view")]
        [Obsolete("GetBufferView is deprecated. Use the BufferView property instead.")]
        public int GetBufferView()
        {
            return NativeCalls.godot_icall_0_5(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_buffer_view");

        [GodotMethod("set_buffer_view")]
        [Obsolete("SetBufferView is deprecated. Use the BufferView property instead.")]
        public void SetBufferView(int bufferView)
        {
            NativeCalls.godot_icall_1_4(method_bind_1, Object.GetPtr(this), bufferView);
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
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_component_type");

        [GodotMethod("get_component_type")]
        [Obsolete("GetComponentType is deprecated. Use the ComponentType property instead.")]
        public int GetComponentType()
        {
            return NativeCalls.godot_icall_0_5(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_component_type");

        [GodotMethod("set_component_type")]
        [Obsolete("SetComponentType is deprecated. Use the ComponentType property instead.")]
        public void SetComponentType(int componentType)
        {
            NativeCalls.godot_icall_1_4(method_bind_5, Object.GetPtr(this), componentType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_normalized");

        [GodotMethod("get_normalized")]
        [Obsolete("GetNormalized is deprecated. Use the Normalized property instead.")]
        public bool GetNormalized()
        {
            return NativeCalls.godot_icall_0_7(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_normalized");

        [GodotMethod("set_normalized")]
        [Obsolete("SetNormalized is deprecated. Use the Normalized property instead.")]
        public void SetNormalized(bool normalized)
        {
            NativeCalls.godot_icall_1_16(method_bind_7, Object.GetPtr(this), normalized);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_count");

        [GodotMethod("get_count")]
        [Obsolete("GetCount is deprecated. Use the Count property instead.")]
        public int GetCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_count");

        [GodotMethod("set_count")]
        [Obsolete("SetCount is deprecated. Use the Count property instead.")]
        public void SetCount(int count)
        {
            NativeCalls.godot_icall_1_4(method_bind_9, Object.GetPtr(this), count);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_type");

        [GodotMethod("get_type")]
        [Obsolete("GetType is deprecated. Use the Type property instead.")]
        public int GetType()
        {
            return NativeCalls.godot_icall_0_5(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_type");

        [GodotMethod("set_type")]
        [Obsolete("SetType is deprecated. Use the Type property instead.")]
        public void SetType(int type)
        {
            NativeCalls.godot_icall_1_4(method_bind_11, Object.GetPtr(this), type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_min");

        [GodotMethod("get_min")]
        [Obsolete("GetMin is deprecated. Use the Min property instead.")]
        public float[] GetMin()
        {
            return NativeCalls.godot_icall_0_356(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_min");

        [GodotMethod("set_min")]
        [Obsolete("SetMin is deprecated. Use the Min property instead.")]
        public void SetMin(float[] min)
        {
            NativeCalls.godot_icall_1_452(method_bind_13, Object.GetPtr(this), min);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max");

        [GodotMethod("get_max")]
        [Obsolete("GetMax is deprecated. Use the Max property instead.")]
        public float[] GetMax()
        {
            return NativeCalls.godot_icall_0_356(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max");

        [GodotMethod("set_max")]
        [Obsolete("SetMax is deprecated. Use the Max property instead.")]
        public void SetMax(float[] max)
        {
            NativeCalls.godot_icall_1_452(method_bind_15, Object.GetPtr(this), max);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sparse_count");

        [GodotMethod("get_sparse_count")]
        [Obsolete("GetSparseCount is deprecated. Use the SparseCount property instead.")]
        public int GetSparseCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sparse_count");

        [GodotMethod("set_sparse_count")]
        [Obsolete("SetSparseCount is deprecated. Use the SparseCount property instead.")]
        public void SetSparseCount(int sparseCount)
        {
            NativeCalls.godot_icall_1_4(method_bind_17, Object.GetPtr(this), sparseCount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sparse_indices_buffer_view");

        [GodotMethod("get_sparse_indices_buffer_view")]
        [Obsolete("GetSparseIndicesBufferView is deprecated. Use the SparseIndicesBufferView property instead.")]
        public int GetSparseIndicesBufferView()
        {
            return NativeCalls.godot_icall_0_5(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sparse_indices_buffer_view");

        [GodotMethod("set_sparse_indices_buffer_view")]
        [Obsolete("SetSparseIndicesBufferView is deprecated. Use the SparseIndicesBufferView property instead.")]
        public void SetSparseIndicesBufferView(int sparseIndicesBufferView)
        {
            NativeCalls.godot_icall_1_4(method_bind_19, Object.GetPtr(this), sparseIndicesBufferView);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sparse_indices_byte_offset");

        [GodotMethod("get_sparse_indices_byte_offset")]
        [Obsolete("GetSparseIndicesByteOffset is deprecated. Use the SparseIndicesByteOffset property instead.")]
        public int GetSparseIndicesByteOffset()
        {
            return NativeCalls.godot_icall_0_5(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sparse_indices_byte_offset");

        [GodotMethod("set_sparse_indices_byte_offset")]
        [Obsolete("SetSparseIndicesByteOffset is deprecated. Use the SparseIndicesByteOffset property instead.")]
        public void SetSparseIndicesByteOffset(int sparseIndicesByteOffset)
        {
            NativeCalls.godot_icall_1_4(method_bind_21, Object.GetPtr(this), sparseIndicesByteOffset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sparse_indices_component_type");

        [GodotMethod("get_sparse_indices_component_type")]
        [Obsolete("GetSparseIndicesComponentType is deprecated. Use the SparseIndicesComponentType property instead.")]
        public int GetSparseIndicesComponentType()
        {
            return NativeCalls.godot_icall_0_5(method_bind_22, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sparse_indices_component_type");

        [GodotMethod("set_sparse_indices_component_type")]
        [Obsolete("SetSparseIndicesComponentType is deprecated. Use the SparseIndicesComponentType property instead.")]
        public void SetSparseIndicesComponentType(int sparseIndicesComponentType)
        {
            NativeCalls.godot_icall_1_4(method_bind_23, Object.GetPtr(this), sparseIndicesComponentType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sparse_values_buffer_view");

        [GodotMethod("get_sparse_values_buffer_view")]
        [Obsolete("GetSparseValuesBufferView is deprecated. Use the SparseValuesBufferView property instead.")]
        public int GetSparseValuesBufferView()
        {
            return NativeCalls.godot_icall_0_5(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sparse_values_buffer_view");

        [GodotMethod("set_sparse_values_buffer_view")]
        [Obsolete("SetSparseValuesBufferView is deprecated. Use the SparseValuesBufferView property instead.")]
        public void SetSparseValuesBufferView(int sparseValuesBufferView)
        {
            NativeCalls.godot_icall_1_4(method_bind_25, Object.GetPtr(this), sparseValuesBufferView);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sparse_values_byte_offset");

        [GodotMethod("get_sparse_values_byte_offset")]
        [Obsolete("GetSparseValuesByteOffset is deprecated. Use the SparseValuesByteOffset property instead.")]
        public int GetSparseValuesByteOffset()
        {
            return NativeCalls.godot_icall_0_5(method_bind_26, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sparse_values_byte_offset");

        [GodotMethod("set_sparse_values_byte_offset")]
        [Obsolete("SetSparseValuesByteOffset is deprecated. Use the SparseValuesByteOffset property instead.")]
        public void SetSparseValuesByteOffset(int sparseValuesByteOffset)
        {
            NativeCalls.godot_icall_1_4(method_bind_27, Object.GetPtr(this), sparseValuesByteOffset);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
