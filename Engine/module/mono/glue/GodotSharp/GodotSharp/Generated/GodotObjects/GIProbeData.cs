using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class GIProbeData : Resource
    {
        public AABB Bounds
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBounds();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBounds(value);
            }
#pragma warning restore CS0618
        }

        public float CellSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCellSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCellSize(value);
            }
#pragma warning restore CS0618
        }

        public Transform ToCellXform
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetToCellXform();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetToCellXform(value);
            }
#pragma warning restore CS0618
        }

        public int[] DynamicData
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDynamicData();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDynamicData(value);
            }
#pragma warning restore CS0618
        }

        public int DynamicRange
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDynamicRange();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDynamicRange(value);
            }
#pragma warning restore CS0618
        }

        public float Energy
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEnergy();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnergy(value);
            }
#pragma warning restore CS0618
        }

        public float Bias
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBias();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBias(value);
            }
#pragma warning restore CS0618
        }

        public float NormalBias
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNormalBias();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetNormalBias(value);
            }
#pragma warning restore CS0618
        }

        public float Propagation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPropagation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPropagation(value);
            }
#pragma warning restore CS0618
        }

        public bool Interior
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInterior();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInterior(value);
            }
#pragma warning restore CS0618
        }

        public bool Compress
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsCompressed();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCompress(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "GIProbeData";

        public GIProbeData() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GIProbeData_Ctor(this);
        }

        internal GIProbeData(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bounds");

        [GodotMethod("set_bounds")]
        [Obsolete("SetBounds is deprecated. Use the Bounds property instead.")]
        public void SetBounds(AABB bounds)
        {
            NativeCalls.godot_icall_1_157(method_bind_0, Object.GetPtr(this), ref bounds);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bounds");

        [GodotMethod("get_bounds")]
        [Obsolete("GetBounds is deprecated. Use the Bounds property instead.")]
        public AABB GetBounds()
        {
            NativeCalls.godot_icall_0_158(method_bind_1, Object.GetPtr(this), out AABB argRet); return (AABB)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cell_size");

        [GodotMethod("set_cell_size")]
        [Obsolete("SetCellSize is deprecated. Use the CellSize property instead.")]
        public void SetCellSize(float cellSize)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), cellSize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cell_size");

        [GodotMethod("get_cell_size")]
        [Obsolete("GetCellSize is deprecated. Use the CellSize property instead.")]
        public float GetCellSize()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_to_cell_xform");

        [GodotMethod("set_to_cell_xform")]
        [Obsolete("SetToCellXform is deprecated. Use the ToCellXform property instead.")]
        public void SetToCellXform(Transform toCellXform)
        {
            NativeCalls.godot_icall_1_202(method_bind_4, Object.GetPtr(this), ref toCellXform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_to_cell_xform");

        [GodotMethod("get_to_cell_xform")]
        [Obsolete("GetToCellXform is deprecated. Use the ToCellXform property instead.")]
        public Transform GetToCellXform()
        {
            NativeCalls.godot_icall_0_22(method_bind_5, Object.GetPtr(this), out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dynamic_data");

        [GodotMethod("set_dynamic_data")]
        [Obsolete("SetDynamicData is deprecated. Use the DynamicData property instead.")]
        public void SetDynamicData(int[] dynamicData)
        {
            NativeCalls.godot_icall_1_102(method_bind_6, Object.GetPtr(this), dynamicData);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_dynamic_data");

        [GodotMethod("get_dynamic_data")]
        [Obsolete("GetDynamicData is deprecated. Use the DynamicData property instead.")]
        public int[] GetDynamicData()
        {
            return NativeCalls.godot_icall_0_103(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dynamic_range");

        [GodotMethod("set_dynamic_range")]
        [Obsolete("SetDynamicRange is deprecated. Use the DynamicRange property instead.")]
        public void SetDynamicRange(int dynamicRange)
        {
            NativeCalls.godot_icall_1_4(method_bind_8, Object.GetPtr(this), dynamicRange);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_dynamic_range");

        [GodotMethod("get_dynamic_range")]
        [Obsolete("GetDynamicRange is deprecated. Use the DynamicRange property instead.")]
        public int GetDynamicRange()
        {
            return NativeCalls.godot_icall_0_5(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_energy");

        [GodotMethod("set_energy")]
        [Obsolete("SetEnergy is deprecated. Use the Energy property instead.")]
        public void SetEnergy(float energy)
        {
            NativeCalls.godot_icall_1_15(method_bind_10, Object.GetPtr(this), energy);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_energy");

        [GodotMethod("get_energy")]
        [Obsolete("GetEnergy is deprecated. Use the Energy property instead.")]
        public float GetEnergy()
        {
            return NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bias");

        [GodotMethod("set_bias")]
        [Obsolete("SetBias is deprecated. Use the Bias property instead.")]
        public void SetBias(float bias)
        {
            NativeCalls.godot_icall_1_15(method_bind_12, Object.GetPtr(this), bias);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bias");

        [GodotMethod("get_bias")]
        [Obsolete("GetBias is deprecated. Use the Bias property instead.")]
        public float GetBias()
        {
            return NativeCalls.godot_icall_0_14(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_normal_bias");

        [GodotMethod("set_normal_bias")]
        [Obsolete("SetNormalBias is deprecated. Use the NormalBias property instead.")]
        public void SetNormalBias(float bias)
        {
            NativeCalls.godot_icall_1_15(method_bind_14, Object.GetPtr(this), bias);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_normal_bias");

        [GodotMethod("get_normal_bias")]
        [Obsolete("GetNormalBias is deprecated. Use the NormalBias property instead.")]
        public float GetNormalBias()
        {
            return NativeCalls.godot_icall_0_14(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_propagation");

        [GodotMethod("set_propagation")]
        [Obsolete("SetPropagation is deprecated. Use the Propagation property instead.")]
        public void SetPropagation(float propagation)
        {
            NativeCalls.godot_icall_1_15(method_bind_16, Object.GetPtr(this), propagation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_propagation");

        [GodotMethod("get_propagation")]
        [Obsolete("GetPropagation is deprecated. Use the Propagation property instead.")]
        public float GetPropagation()
        {
            return NativeCalls.godot_icall_0_14(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_interior");

        [GodotMethod("set_interior")]
        [Obsolete("SetInterior is deprecated. Use the Interior property instead.")]
        public void SetInterior(bool interior)
        {
            NativeCalls.godot_icall_1_16(method_bind_18, Object.GetPtr(this), interior);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_interior");

        [GodotMethod("is_interior")]
        [Obsolete("IsInterior is deprecated. Use the Interior property instead.")]
        public bool IsInterior()
        {
            return NativeCalls.godot_icall_0_7(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_compress");

        [GodotMethod("set_compress")]
        [Obsolete("SetCompress is deprecated. Use the Compress property instead.")]
        public void SetCompress(bool compress)
        {
            NativeCalls.godot_icall_1_16(method_bind_20, Object.GetPtr(this), compress);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_compressed");

        [GodotMethod("is_compressed")]
        [Obsolete("IsCompressed is deprecated. Use the Compress property instead.")]
        public bool IsCompressed()
        {
            return NativeCalls.godot_icall_0_7(method_bind_21, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
