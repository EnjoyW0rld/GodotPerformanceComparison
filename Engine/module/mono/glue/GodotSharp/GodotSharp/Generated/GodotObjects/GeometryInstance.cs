using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Base node for geometry-based visual instances. Shares some common functionality like visibility and custom materials.</para>
    /// </summary>
    public abstract partial class GeometryInstance : VisualInstance
    {
        public enum Flags
        {
            /// <summary>
            /// <para>Will allow the GeometryInstance to be used when baking lights using a <see cref="Godot.GIProbe"/> or <see cref="Godot.BakedLightmap"/>.</para>
            /// </summary>
            UseBakedLight = 0,
            /// <summary>
            /// <para>Unused in this class, exposed for consistency with <see cref="Godot.VisualServer.InstanceFlags"/>.</para>
            /// </summary>
            DrawNextFrameIfVisible = 1,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.GeometryInstance.Flags"/> enum.</para>
            /// </summary>
            Max = 2
        }

        public enum ShadowCastingSetting
        {
            /// <summary>
            /// <para>Will not cast any shadows.</para>
            /// </summary>
            Off = 0,
            /// <summary>
            /// <para>Will cast shadows from all visible faces in the GeometryInstance.</para>
            /// <para>Will take culling into account, so faces not being rendered will not be taken into account when shadow casting.</para>
            /// </summary>
            On = 1,
            /// <summary>
            /// <para>Will cast shadows from all visible faces in the GeometryInstance.</para>
            /// <para>Will not take culling into account, so all faces will be taken into account when shadow casting.</para>
            /// </summary>
            DoubleSided = 2,
            /// <summary>
            /// <para>Will only show the shadows casted from this object.</para>
            /// <para>In other words, the actual mesh will not be visible, only the shadows casted from the mesh will be.</para>
            /// </summary>
            ShadowsOnly = 3
        }

        public enum LightmapScaleEnum
        {
            /// <summary>
            /// <para>The generated lightmap texture will have the original size.</para>
            /// </summary>
            Scale1x = 0,
            /// <summary>
            /// <para>The generated lightmap texture will be twice as large, on each axis.</para>
            /// </summary>
            Scale2x = 1,
            /// <summary>
            /// <para>The generated lightmap texture will be 4 times as large, on each axis.</para>
            /// </summary>
            Scale4x = 2,
            /// <summary>
            /// <para>The generated lightmap texture will be 8 times as large, on each axis.</para>
            /// </summary>
            Scale8x = 3,
            Max = 4
        }

        /// <summary>
        /// <para>The material override for the whole geometry.</para>
        /// <para>If a material is assigned to this property, it will be used instead of any material set in any material slot of the mesh.</para>
        /// </summary>
        public Material MaterialOverride
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaterialOverride();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaterialOverride(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The material overlay for the whole geometry.</para>
        /// <para>If a material is assigned to this property, it will be rendered on top of any other active material for all the surfaces.</para>
        /// </summary>
        public Material MaterialOverlay
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaterialOverlay();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaterialOverlay(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The selected shadow casting flag. See <see cref="Godot.GeometryInstance.ShadowCastingSetting"/> for possible values.</para>
        /// </summary>
        public GeometryInstance.ShadowCastingSetting CastShadow
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCastShadowsSetting();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCastShadowsSetting(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The extra distance added to the GeometryInstance's bounding box (<see cref="Godot.AABB"/>) to increase its cull box.</para>
        /// </summary>
        public float ExtraCullMargin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetExtraCullMargin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExtraCullMargin(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, this GeometryInstance will be used when baking lights using a <see cref="Godot.GIProbe"/> or <see cref="Godot.BakedLightmap"/>.</para>
        /// </summary>
        public bool UseInBakedLight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((GeometryInstance.Flags)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((GeometryInstance.Flags)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When disabled, the mesh will be taken into account when computing indirect lighting, but the resulting lightmap will not be saved. Useful for emissive only materials or shadow casters.</para>
        /// </summary>
        public bool GenerateLightmap
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGenerateLightmap();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGenerateLightmap(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Scale factor for the generated baked lightmap. Useful for adding detail to certain mesh instances.</para>
        /// </summary>
        public GeometryInstance.LightmapScaleEnum LightmapScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLightmapScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLightmapScale(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The GeometryInstance's min LOD distance.</para>
        /// <para>Note: This property currently has no effect.</para>
        /// </summary>
        public float LodMinDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLodMinDistance();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLodMinDistance(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The GeometryInstance's min LOD margin.</para>
        /// <para>Note: This property currently has no effect.</para>
        /// </summary>
        public float LodMinHysteresis
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLodMinHysteresis();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLodMinHysteresis(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The GeometryInstance's max LOD distance.</para>
        /// <para>Note: This property currently has no effect.</para>
        /// </summary>
        public float LodMaxDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLodMaxDistance();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLodMaxDistance(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The GeometryInstance's max LOD margin.</para>
        /// <para>Note: This property currently has no effect.</para>
        /// </summary>
        public float LodMaxHysteresis
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLodMaxHysteresis();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLodMaxHysteresis(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "GeometryInstance";

        internal GeometryInstance() {}

        internal GeometryInstance(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_material_override");

        [GodotMethod("set_material_override")]
        [Obsolete("SetMaterialOverride is deprecated. Use the MaterialOverride property instead.")]
        public void SetMaterialOverride(Material material)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_material_override");

        [GodotMethod("get_material_override")]
        [Obsolete("GetMaterialOverride is deprecated. Use the MaterialOverride property instead.")]
        public Material GetMaterialOverride()
        {
            return NativeCalls.godot_icall_0_237(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_material_overlay");

        [GodotMethod("set_material_overlay")]
        [Obsolete("SetMaterialOverlay is deprecated. Use the MaterialOverlay property instead.")]
        public void SetMaterialOverlay(Material material)
        {
            NativeCalls.godot_icall_1_24(method_bind_2, Object.GetPtr(this), Object.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_material_overlay");

        [GodotMethod("get_material_overlay")]
        [Obsolete("GetMaterialOverlay is deprecated. Use the MaterialOverlay property instead.")]
        public Material GetMaterialOverlay()
        {
            return NativeCalls.godot_icall_0_237(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flag");

        /// <summary>
        /// <para>Sets the <see cref="Godot.GeometryInstance.Flags"/> specified. See <see cref="Godot.GeometryInstance.Flags"/> for options.</para>
        /// </summary>
        [GodotMethod("set_flag")]
        [Obsolete("SetFlag is deprecated. Use the UseInBakedLight property instead.")]
        public void SetFlag(GeometryInstance.Flags flag, bool value)
        {
            NativeCalls.godot_icall_2_23(method_bind_4, Object.GetPtr(this), (int)flag, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_flag");

        /// <summary>
        /// <para>Returns the <see cref="Godot.GeometryInstance.Flags"/> that have been set for this object.</para>
        /// </summary>
        [GodotMethod("get_flag")]
        [Obsolete("GetFlag is deprecated. Use the UseInBakedLight property instead.")]
        public bool GetFlag(GeometryInstance.Flags flag)
        {
            return NativeCalls.godot_icall_1_35(method_bind_5, Object.GetPtr(this), (int)flag);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cast_shadows_setting");

        [GodotMethod("set_cast_shadows_setting")]
        [Obsolete("SetCastShadowsSetting is deprecated. Use the CastShadow property instead.")]
        public void SetCastShadowsSetting(GeometryInstance.ShadowCastingSetting shadowCastingSetting)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), (int)shadowCastingSetting);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cast_shadows_setting");

        [GodotMethod("get_cast_shadows_setting")]
        [Obsolete("GetCastShadowsSetting is deprecated. Use the CastShadow property instead.")]
        public GeometryInstance.ShadowCastingSetting GetCastShadowsSetting()
        {
            return (GeometryInstance.ShadowCastingSetting)NativeCalls.godot_icall_0_461(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_generate_lightmap");

        [GodotMethod("set_generate_lightmap")]
        [Obsolete("SetGenerateLightmap is deprecated. Use the GenerateLightmap property instead.")]
        public void SetGenerateLightmap(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_8, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_generate_lightmap");

        [GodotMethod("get_generate_lightmap")]
        [Obsolete("GetGenerateLightmap is deprecated. Use the GenerateLightmap property instead.")]
        public bool GetGenerateLightmap()
        {
            return NativeCalls.godot_icall_0_7(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_lightmap_scale");

        [GodotMethod("set_lightmap_scale")]
        [Obsolete("SetLightmapScale is deprecated. Use the LightmapScale property instead.")]
        public void SetLightmapScale(GeometryInstance.LightmapScaleEnum scale)
        {
            NativeCalls.godot_icall_1_4(method_bind_10, Object.GetPtr(this), (int)scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_lightmap_scale");

        [GodotMethod("get_lightmap_scale")]
        [Obsolete("GetLightmapScale is deprecated. Use the LightmapScale property instead.")]
        public GeometryInstance.LightmapScaleEnum GetLightmapScale()
        {
            return (GeometryInstance.LightmapScaleEnum)NativeCalls.godot_icall_0_462(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_lod_max_hysteresis");

        [GodotMethod("set_lod_max_hysteresis")]
        [Obsolete("SetLodMaxHysteresis is deprecated. Use the LodMaxHysteresis property instead.")]
        public void SetLodMaxHysteresis(float mode)
        {
            NativeCalls.godot_icall_1_15(method_bind_12, Object.GetPtr(this), mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_lod_max_hysteresis");

        [GodotMethod("get_lod_max_hysteresis")]
        [Obsolete("GetLodMaxHysteresis is deprecated. Use the LodMaxHysteresis property instead.")]
        public float GetLodMaxHysteresis()
        {
            return NativeCalls.godot_icall_0_14(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_lod_max_distance");

        [GodotMethod("set_lod_max_distance")]
        [Obsolete("SetLodMaxDistance is deprecated. Use the LodMaxDistance property instead.")]
        public void SetLodMaxDistance(float mode)
        {
            NativeCalls.godot_icall_1_15(method_bind_14, Object.GetPtr(this), mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_lod_max_distance");

        [GodotMethod("get_lod_max_distance")]
        [Obsolete("GetLodMaxDistance is deprecated. Use the LodMaxDistance property instead.")]
        public float GetLodMaxDistance()
        {
            return NativeCalls.godot_icall_0_14(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_lod_min_hysteresis");

        [GodotMethod("set_lod_min_hysteresis")]
        [Obsolete("SetLodMinHysteresis is deprecated. Use the LodMinHysteresis property instead.")]
        public void SetLodMinHysteresis(float mode)
        {
            NativeCalls.godot_icall_1_15(method_bind_16, Object.GetPtr(this), mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_lod_min_hysteresis");

        [GodotMethod("get_lod_min_hysteresis")]
        [Obsolete("GetLodMinHysteresis is deprecated. Use the LodMinHysteresis property instead.")]
        public float GetLodMinHysteresis()
        {
            return NativeCalls.godot_icall_0_14(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_lod_min_distance");

        [GodotMethod("set_lod_min_distance")]
        [Obsolete("SetLodMinDistance is deprecated. Use the LodMinDistance property instead.")]
        public void SetLodMinDistance(float mode)
        {
            NativeCalls.godot_icall_1_15(method_bind_18, Object.GetPtr(this), mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_lod_min_distance");

        [GodotMethod("get_lod_min_distance")]
        [Obsolete("GetLodMinDistance is deprecated. Use the LodMinDistance property instead.")]
        public float GetLodMinDistance()
        {
            return NativeCalls.godot_icall_0_14(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_extra_cull_margin");

        [GodotMethod("set_extra_cull_margin")]
        [Obsolete("SetExtraCullMargin is deprecated. Use the ExtraCullMargin property instead.")]
        public void SetExtraCullMargin(float margin)
        {
            NativeCalls.godot_icall_1_15(method_bind_20, Object.GetPtr(this), margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_extra_cull_margin");

        [GodotMethod("get_extra_cull_margin")]
        [Obsolete("GetExtraCullMargin is deprecated. Use the ExtraCullMargin property instead.")]
        public float GetExtraCullMargin()
        {
            return NativeCalls.godot_icall_0_14(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_custom_aabb");

        /// <summary>
        /// <para>Overrides the bounding box of this node with a custom one. To remove it, set an <see cref="Godot.AABB"/> with all fields set to zero.</para>
        /// </summary>
        [GodotMethod("set_custom_aabb")]
        public void SetCustomAabb(AABB aabb)
        {
            NativeCalls.godot_icall_1_157(method_bind_22, Object.GetPtr(this), ref aabb);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
