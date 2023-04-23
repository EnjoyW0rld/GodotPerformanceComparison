using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.GIProbe"/>s are used to provide high-quality real-time indirect light to scenes. They precompute the effect of objects that emit light and the effect of static geometry to simulate the behavior of complex light in real-time. <see cref="Godot.GIProbe"/>s need to be baked before using, however, once baked, dynamic objects will receive light from them. Further, lights can be fully dynamic or baked.</para>
    /// <para>Having <see cref="Godot.GIProbe"/>s in a scene can be expensive, the quality of the probe can be turned down in exchange for better performance in the <see cref="Godot.ProjectSettings"/> using .</para>
    /// <para>Procedural generation: <see cref="Godot.GIProbe"/> can be baked in an exported project, which makes it suitable for procedurally generated or user-built levels as long as all the geometry is generated in advance.</para>
    /// <para>Performance: <see cref="Godot.GIProbe"/> is relatively demanding on the GPU and is not suited to low-end hardware such as integrated graphics (consider <see cref="Godot.BakedLightmap"/> instead). To provide a fallback for low-end hardware, consider adding an option to disable <see cref="Godot.GIProbe"/> in your project's options menus. A <see cref="Godot.GIProbe"/> node can be disabled by hiding it.</para>
    /// <para>Note: Meshes should have sufficiently thick walls to avoid light leaks (avoid one-sided walls). For interior levels, enclose your level geometry in a sufficiently large box and bridge the loops to close the mesh. To further prevent light leaks, you can also strategically place temporary <see cref="Godot.MeshInstance"/> nodes with <see cref="Godot.GeometryInstance.UseInBakedLight"/> enabled. These temporary nodes can then be hidden after baking the <see cref="Godot.GIProbe"/> node.</para>
    /// <para>Note: Due to a renderer limitation, emissive <see cref="Godot.ShaderMaterial"/>s cannot emit light when used in a <see cref="Godot.GIProbe"/>. Only emissive <see cref="Godot.SpatialMaterial"/>s can emit light in a <see cref="Godot.GIProbe"/>.</para>
    /// </summary>
    public partial class GIProbe : VisualInstance
    {
        public enum SubdivEnum
        {
            /// <summary>
            /// <para>Use 64 subdivisions. This is the lowest quality setting, but the fastest. Use it if you can, but especially use it on lower-end hardware.</para>
            /// </summary>
            Subdiv64 = 0,
            /// <summary>
            /// <para>Use 128 subdivisions. This is the default quality setting.</para>
            /// </summary>
            Subdiv128 = 1,
            /// <summary>
            /// <para>Use 256 subdivisions.</para>
            /// </summary>
            Subdiv256 = 2,
            /// <summary>
            /// <para>Use 512 subdivisions. This is the highest quality setting, but the slowest. On lower-end hardware, this could cause the GPU to stall.</para>
            /// </summary>
            Subdiv512 = 3,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.GIProbe.SubdivEnum"/> enum.</para>
            /// </summary>
            Max = 4
        }

        /// <summary>
        /// <para>Number of times to subdivide the grid that the <see cref="Godot.GIProbe"/> operates on. A higher number results in finer detail and thus higher visual quality, while lower numbers result in better performance.</para>
        /// </summary>
        public GIProbe.SubdivEnum Subdiv
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSubdiv();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSubdiv(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The size of the area covered by the <see cref="Godot.GIProbe"/>. If you make the extents larger without increasing the subdivisions with <see cref="Godot.GIProbe.Subdiv"/>, the size of each cell will increase and result in lower detailed lighting.</para>
        /// </summary>
        public Vector3 Extents
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetExtents();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExtents(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum brightness that the <see cref="Godot.GIProbe"/> will recognize. Brightness will be scaled within this range.</para>
        /// </summary>
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

        /// <summary>
        /// <para>Energy multiplier. Makes the lighting contribution from the <see cref="Godot.GIProbe"/> brighter.</para>
        /// </summary>
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

        /// <summary>
        /// <para>How much light propagates through the probe internally. A higher value allows light to spread further.</para>
        /// </summary>
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

        /// <summary>
        /// <para>Offsets the lookup of the light contribution from the <see cref="Godot.GIProbe"/>. This can be used to avoid self-shadowing, but may introduce light leaking at higher values. This and <see cref="Godot.GIProbe.NormalBias"/> should be played around with to minimize self-shadowing and light leaking.</para>
        /// <para>Note: <c>bias</c> should usually be above 1.0 as that is the size of the voxels.</para>
        /// </summary>
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

        /// <summary>
        /// <para>Offsets the lookup into the <see cref="Godot.GIProbe"/> based on the object's normal direction. Can be used to reduce some self-shadowing artifacts.</para>
        /// </summary>
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

        /// <summary>
        /// <para>If <c>true</c>, ignores the sky contribution when calculating lighting.</para>
        /// </summary>
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

        /// <summary>
        /// <para>Deprecated. This property has been deprecated due to known bugs and no longer has any effect when enabled.</para>
        /// </summary>
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

        /// <summary>
        /// <para>The <see cref="Godot.GIProbeData"/> resource that holds the data for this <see cref="Godot.GIProbe"/>.</para>
        /// </summary>
        public GIProbeData Data
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetProbeData();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetProbeData(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "GIProbe";

        public GIProbe() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GIProbe_Ctor(this);
        }

        internal GIProbe(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_probe_data");

        [GodotMethod("set_probe_data")]
        [Obsolete("SetProbeData is deprecated. Use the Data property instead.")]
        public void SetProbeData(GIProbeData data)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(data));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_probe_data");

        [GodotMethod("get_probe_data")]
        [Obsolete("GetProbeData is deprecated. Use the Data property instead.")]
        public GIProbeData GetProbeData()
        {
            return NativeCalls.godot_icall_0_449(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_subdiv");

        [GodotMethod("set_subdiv")]
        [Obsolete("SetSubdiv is deprecated. Use the Subdiv property instead.")]
        public void SetSubdiv(GIProbe.SubdivEnum subdiv)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)subdiv);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_subdiv");

        [GodotMethod("get_subdiv")]
        [Obsolete("GetSubdiv is deprecated. Use the Subdiv property instead.")]
        public GIProbe.SubdivEnum GetSubdiv()
        {
            return (GIProbe.SubdivEnum)NativeCalls.godot_icall_0_450(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_extents");

        [GodotMethod("set_extents")]
        [Obsolete("SetExtents is deprecated. Use the Extents property instead.")]
        public void SetExtents(Vector3 extents)
        {
            NativeCalls.godot_icall_1_148(method_bind_4, Object.GetPtr(this), ref extents);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_extents");

        [GodotMethod("get_extents")]
        [Obsolete("GetExtents is deprecated. Use the Extents property instead.")]
        public Vector3 GetExtents()
        {
            NativeCalls.godot_icall_0_8(method_bind_5, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dynamic_range");

        [GodotMethod("set_dynamic_range")]
        [Obsolete("SetDynamicRange is deprecated. Use the DynamicRange property instead.")]
        public void SetDynamicRange(int max)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), max);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_dynamic_range");

        [GodotMethod("get_dynamic_range")]
        [Obsolete("GetDynamicRange is deprecated. Use the DynamicRange property instead.")]
        public int GetDynamicRange()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_energy");

        [GodotMethod("set_energy")]
        [Obsolete("SetEnergy is deprecated. Use the Energy property instead.")]
        public void SetEnergy(float max)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), max);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_energy");

        [GodotMethod("get_energy")]
        [Obsolete("GetEnergy is deprecated. Use the Energy property instead.")]
        public float GetEnergy()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bias");

        [GodotMethod("set_bias")]
        [Obsolete("SetBias is deprecated. Use the Bias property instead.")]
        public void SetBias(float max)
        {
            NativeCalls.godot_icall_1_15(method_bind_10, Object.GetPtr(this), max);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bias");

        [GodotMethod("get_bias")]
        [Obsolete("GetBias is deprecated. Use the Bias property instead.")]
        public float GetBias()
        {
            return NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_normal_bias");

        [GodotMethod("set_normal_bias")]
        [Obsolete("SetNormalBias is deprecated. Use the NormalBias property instead.")]
        public void SetNormalBias(float max)
        {
            NativeCalls.godot_icall_1_15(method_bind_12, Object.GetPtr(this), max);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_normal_bias");

        [GodotMethod("get_normal_bias")]
        [Obsolete("GetNormalBias is deprecated. Use the NormalBias property instead.")]
        public float GetNormalBias()
        {
            return NativeCalls.godot_icall_0_14(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_propagation");

        [GodotMethod("set_propagation")]
        [Obsolete("SetPropagation is deprecated. Use the Propagation property instead.")]
        public void SetPropagation(float max)
        {
            NativeCalls.godot_icall_1_15(method_bind_14, Object.GetPtr(this), max);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_propagation");

        [GodotMethod("get_propagation")]
        [Obsolete("GetPropagation is deprecated. Use the Propagation property instead.")]
        public float GetPropagation()
        {
            return NativeCalls.godot_icall_0_14(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_interior");

        [GodotMethod("set_interior")]
        [Obsolete("SetInterior is deprecated. Use the Interior property instead.")]
        public void SetInterior(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_16, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_interior");

        [GodotMethod("is_interior")]
        [Obsolete("IsInterior is deprecated. Use the Interior property instead.")]
        public bool IsInterior()
        {
            return NativeCalls.godot_icall_0_7(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_compress");

        [GodotMethod("set_compress")]
        [Obsolete("SetCompress is deprecated. Use the Compress property instead.")]
        public void SetCompress(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_18, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_compressed");

        [GodotMethod("is_compressed")]
        [Obsolete("IsCompressed is deprecated. Use the Compress property instead.")]
        public bool IsCompressed()
        {
            return NativeCalls.godot_icall_0_7(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "bake");

        /// <summary>
        /// <para>Bakes the effect from all <see cref="Godot.GeometryInstance"/>s marked with <see cref="Godot.GeometryInstance.UseInBakedLight"/> and <see cref="Godot.Light"/>s marked with either <see cref="Godot.Light.BakeMode.Indirect"/> or <see cref="Godot.Light.BakeMode.All"/>. If <c>create_visual_debug</c> is <c>true</c>, after baking the light, this will generate a <see cref="Godot.MultiMesh"/> that has a cube representing each solid cell with each cube colored to the cell's albedo color. This can be used to visualize the <see cref="Godot.GIProbe"/>'s data and debug any issues that may be occurring.</para>
        /// <para>Note: <see cref="Godot.GIProbe.Bake"/> works from the editor and in exported projects. This makes it suitable for procedurally generated or user-built levels. Baking a <see cref="Godot.GIProbe"/> generally takes from 5 to 20 seconds in most scenes. Reducing <see cref="Godot.GIProbe.Subdiv"/> can speed up baking.</para>
        /// <para>Note: <see cref="Godot.GeometryInstance"/>s and <see cref="Godot.Light"/>s must be fully ready before <see cref="Godot.GIProbe.Bake"/> is called. If you are procedurally creating those and some meshes or lights are missing from your baked <see cref="Godot.GIProbe"/>, use <c>call_deferred("bake")</c> instead of calling <see cref="Godot.GIProbe.Bake"/> directly.</para>
        /// </summary>
        [GodotMethod("bake")]
        public void Bake(Node fromNode = null, bool createVisualDebug = false)
        {
            NativeCalls.godot_icall_2_451(method_bind_20, Object.GetPtr(this), Object.GetPtr(fromNode), createVisualDebug);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "debug_bake");

        /// <summary>
        /// <para>Calls <see cref="Godot.GIProbe.Bake"/> with <c>create_visual_debug</c> enabled.</para>
        /// </summary>
        [GodotMethod("debug_bake")]
        public void DebugBake()
        {
            NativeCalls.godot_icall_0_3(method_bind_21, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
