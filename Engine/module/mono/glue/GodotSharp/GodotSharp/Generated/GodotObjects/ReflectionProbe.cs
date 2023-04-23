using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Capture its surroundings as a dual paraboloid image, and stores versions of it with increasing levels of blur to simulate different material roughnesses.</para>
    /// <para>The <see cref="Godot.ReflectionProbe"/> is used to create high-quality reflections at a low performance cost (when <see cref="Godot.ReflectionProbe.UpdateMode"/> is <see cref="Godot.ReflectionProbe.UpdateModeEnum.Once"/>). <see cref="Godot.ReflectionProbe"/>s can be blended together and with the rest of the scene smoothly. <see cref="Godot.ReflectionProbe"/>s can also be combined with <see cref="Godot.GIProbe"/> and screen-space reflections (<see cref="Godot.Environment.SsReflectionsEnabled"/>) to get more accurate reflections in specific areas. <see cref="Godot.ReflectionProbe"/>s render all objects within their <see cref="Godot.ReflectionProbe.CullMask"/>, so updating them can be quite expensive. It is best to update them once with the important static objects and then leave them as-is.</para>
    /// <para>Note: Unlike <see cref="Godot.GIProbe"/>, <see cref="Godot.ReflectionProbe"/>s only source their environment from a <see cref="Godot.WorldEnvironment"/> node. If you specify an <see cref="Godot.Environment"/> resource within a <see cref="Godot.Camera"/> node, it will be ignored by the <see cref="Godot.ReflectionProbe"/>. This can lead to incorrect lighting within the <see cref="Godot.ReflectionProbe"/>.</para>
    /// <para>Note: By default, Godot will only render 16 reflection probes. If you need more, increase the number of atlas subdivisions. This setting can be found in .</para>
    /// <para>Note: The GLES2 backend will only display two reflection probes at the same time for a single mesh. If possible, split up large meshes that span over multiple reflection probes into smaller ones.</para>
    /// </summary>
    public partial class ReflectionProbe : VisualInstance
    {
        public enum UpdateModeEnum
        {
            /// <summary>
            /// <para>Update the probe once on the next frame (recommended for most objects). The corresponding radiance map will be generated over the following six frames. This takes more time to update than <see cref="Godot.ReflectionProbe.UpdateModeEnum.Always"/>, but it has a lower performance cost and can result in higher-quality reflections. The ReflectionProbe is updated when its transform changes, but not when nearby geometry changes. You can force a <see cref="Godot.ReflectionProbe"/> update by moving the <see cref="Godot.ReflectionProbe"/> slightly in any direction.</para>
            /// </summary>
            Once = 0,
            /// <summary>
            /// <para>Update the probe every frame. This provides better results for fast-moving dynamic objects (such as cars). However, it has a significant performance cost. Due to the cost, it's recommended to only use one ReflectionProbe with <see cref="Godot.ReflectionProbe.UpdateModeEnum.Always"/> at most per scene. For all other use cases, use <see cref="Godot.ReflectionProbe.UpdateModeEnum.Once"/>.</para>
            /// </summary>
            Always = 1
        }

        /// <summary>
        /// <para>Sets how frequently the <see cref="Godot.ReflectionProbe"/> is updated. Can be <see cref="Godot.ReflectionProbe.UpdateModeEnum.Once"/> or <see cref="Godot.ReflectionProbe.UpdateModeEnum.Always"/>.</para>
        /// </summary>
        public ReflectionProbe.UpdateModeEnum UpdateMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUpdateMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUpdateMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Defines the reflection intensity. Intensity modulates the strength of the reflection.</para>
        /// </summary>
        public float Intensity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetIntensity();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetIntensity(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum distance away from the <see cref="Godot.ReflectionProbe"/> an object can be before it is culled. Decrease this to improve performance, especially when using the <see cref="Godot.ReflectionProbe.UpdateModeEnum.Always"/> <see cref="Godot.ReflectionProbe.UpdateMode"/>.</para>
        /// <para>Note: The maximum reflection distance is always at least equal to the <see cref="Godot.ReflectionProbe.Extents"/>. This means that decreasing <see cref="Godot.ReflectionProbe.MaxDistance"/> will not always cull objects from reflections, especially if the reflection probe's <see cref="Godot.ReflectionProbe.Extents"/> are already large.</para>
        /// </summary>
        public float MaxDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaxDistance();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaxDistance(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The size of the reflection probe. The larger the extents the more space covered by the probe which will lower the perceived resolution. It is best to keep the extents only as large as you need them.</para>
        /// <para>Note: To better fit areas that are not aligned to the grid, you can rotate the <see cref="Godot.ReflectionProbe"/> node.</para>
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
        /// <para>Sets the origin offset to be used when this <see cref="Godot.ReflectionProbe"/> is in <see cref="Godot.ReflectionProbe.BoxProjection"/> mode. This can be set to a non-zero value to ensure a reflection fits a rectangle-shaped room, while reducing the amount of objects that "get in the way" of the reflection.</para>
        /// </summary>
        public Vector3 OriginOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOriginOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOriginOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, enables box projection. This makes reflections look more correct in rectangle-shaped rooms by offsetting the reflection center depending on the camera's location.</para>
        /// <para>Note: To better fit rectangle-shaped rooms that are not aligned to the grid, you can rotate the <see cref="Godot.ReflectionProbe"/> node.</para>
        /// </summary>
        public bool BoxProjection
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsBoxProjectionEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnableBoxProjection(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, computes shadows in the reflection probe. This makes the reflection probe slower to render; you may want to disable this if using the <see cref="Godot.ReflectionProbe.UpdateModeEnum.Always"/> <see cref="Godot.ReflectionProbe.UpdateMode"/>.</para>
        /// </summary>
        public bool EnableShadows
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return AreShadowsEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnableShadows(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the cull mask which determines what objects are drawn by this probe. Every <see cref="Godot.VisualInstance"/> with a layer included in this cull mask will be rendered by the probe. To improve performance, it is best to only include large objects which are likely to take up a lot of space in the reflection.</para>
        /// </summary>
        public uint CullMask
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCullMask();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCullMask(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, reflections will ignore sky contribution. Ambient lighting is then controlled by the <c>interior_ambient_*</c> properties.</para>
        /// </summary>
        public bool InteriorEnable
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsSetAsInterior();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAsInterior(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the ambient light color to be used when this probe is set to <see cref="Godot.ReflectionProbe.InteriorEnable"/>.</para>
        /// </summary>
        public Color InteriorAmbientColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInteriorAmbient();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInteriorAmbient(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the energy multiplier for this reflection probe's ambient light contribution when set to <see cref="Godot.ReflectionProbe.InteriorEnable"/>.</para>
        /// </summary>
        public float InteriorAmbientEnergy
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInteriorAmbientEnergy();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInteriorAmbientEnergy(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the contribution value for how much the reflection affects the ambient light for this reflection probe when set to <see cref="Godot.ReflectionProbe.InteriorEnable"/>. Useful so that ambient light matches the color of the room.</para>
        /// </summary>
        public float InteriorAmbientContrib
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInteriorAmbientProbeContribution();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInteriorAmbientProbeContribution(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ReflectionProbe";

        public ReflectionProbe() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ReflectionProbe_Ctor(this);
        }

        internal ReflectionProbe(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_intensity");

        [GodotMethod("set_intensity")]
        [Obsolete("SetIntensity is deprecated. Use the Intensity property instead.")]
        public void SetIntensity(float intensity)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), intensity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_intensity");

        [GodotMethod("get_intensity")]
        [Obsolete("GetIntensity is deprecated. Use the Intensity property instead.")]
        public float GetIntensity()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_interior_ambient");

        [GodotMethod("set_interior_ambient")]
        [Obsolete("SetInteriorAmbient is deprecated. Use the InteriorAmbientColor property instead.")]
        public void SetInteriorAmbient(Color ambient)
        {
            NativeCalls.godot_icall_1_199(method_bind_2, Object.GetPtr(this), ref ambient);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_interior_ambient");

        [GodotMethod("get_interior_ambient")]
        [Obsolete("GetInteriorAmbient is deprecated. Use the InteriorAmbientColor property instead.")]
        public Color GetInteriorAmbient()
        {
            NativeCalls.godot_icall_0_200(method_bind_3, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_interior_ambient_energy");

        [GodotMethod("set_interior_ambient_energy")]
        [Obsolete("SetInteriorAmbientEnergy is deprecated. Use the InteriorAmbientEnergy property instead.")]
        public void SetInteriorAmbientEnergy(float ambientEnergy)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), ambientEnergy);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_interior_ambient_energy");

        [GodotMethod("get_interior_ambient_energy")]
        [Obsolete("GetInteriorAmbientEnergy is deprecated. Use the InteriorAmbientEnergy property instead.")]
        public float GetInteriorAmbientEnergy()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_interior_ambient_probe_contribution");

        [GodotMethod("set_interior_ambient_probe_contribution")]
        [Obsolete("SetInteriorAmbientProbeContribution is deprecated. Use the InteriorAmbientContrib property instead.")]
        public void SetInteriorAmbientProbeContribution(float ambientProbeContribution)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), ambientProbeContribution);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_interior_ambient_probe_contribution");

        [GodotMethod("get_interior_ambient_probe_contribution")]
        [Obsolete("GetInteriorAmbientProbeContribution is deprecated. Use the InteriorAmbientContrib property instead.")]
        public float GetInteriorAmbientProbeContribution()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max_distance");

        [GodotMethod("set_max_distance")]
        [Obsolete("SetMaxDistance is deprecated. Use the MaxDistance property instead.")]
        public void SetMaxDistance(float maxDistance)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), maxDistance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max_distance");

        [GodotMethod("get_max_distance")]
        [Obsolete("GetMaxDistance is deprecated. Use the MaxDistance property instead.")]
        public float GetMaxDistance()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_extents");

        [GodotMethod("set_extents")]
        [Obsolete("SetExtents is deprecated. Use the Extents property instead.")]
        public void SetExtents(Vector3 extents)
        {
            NativeCalls.godot_icall_1_148(method_bind_10, Object.GetPtr(this), ref extents);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_extents");

        [GodotMethod("get_extents")]
        [Obsolete("GetExtents is deprecated. Use the Extents property instead.")]
        public Vector3 GetExtents()
        {
            NativeCalls.godot_icall_0_8(method_bind_11, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_origin_offset");

        [GodotMethod("set_origin_offset")]
        [Obsolete("SetOriginOffset is deprecated. Use the OriginOffset property instead.")]
        public void SetOriginOffset(Vector3 originOffset)
        {
            NativeCalls.godot_icall_1_148(method_bind_12, Object.GetPtr(this), ref originOffset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_origin_offset");

        [GodotMethod("get_origin_offset")]
        [Obsolete("GetOriginOffset is deprecated. Use the OriginOffset property instead.")]
        public Vector3 GetOriginOffset()
        {
            NativeCalls.godot_icall_0_8(method_bind_13, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_as_interior");

        [GodotMethod("set_as_interior")]
        [Obsolete("SetAsInterior is deprecated. Use the InteriorEnable property instead.")]
        public void SetAsInterior(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_14, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_set_as_interior");

        [GodotMethod("is_set_as_interior")]
        [Obsolete("IsSetAsInterior is deprecated. Use the InteriorEnable property instead.")]
        public bool IsSetAsInterior()
        {
            return NativeCalls.godot_icall_0_7(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_enable_box_projection");

        [GodotMethod("set_enable_box_projection")]
        [Obsolete("SetEnableBoxProjection is deprecated. Use the BoxProjection property instead.")]
        public void SetEnableBoxProjection(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_16, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_box_projection_enabled");

        [GodotMethod("is_box_projection_enabled")]
        [Obsolete("IsBoxProjectionEnabled is deprecated. Use the BoxProjection property instead.")]
        public bool IsBoxProjectionEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_enable_shadows");

        [GodotMethod("set_enable_shadows")]
        [Obsolete("SetEnableShadows is deprecated. Use the EnableShadows property instead.")]
        public void SetEnableShadows(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_18, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "are_shadows_enabled");

        [GodotMethod("are_shadows_enabled")]
        [Obsolete("AreShadowsEnabled is deprecated. Use the EnableShadows property instead.")]
        public bool AreShadowsEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cull_mask");

        [GodotMethod("set_cull_mask")]
        [Obsolete("SetCullMask is deprecated. Use the CullMask property instead.")]
        public void SetCullMask(uint layers)
        {
            NativeCalls.godot_icall_1_187(method_bind_20, Object.GetPtr(this), layers);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cull_mask");

        [GodotMethod("get_cull_mask")]
        [Obsolete("GetCullMask is deprecated. Use the CullMask property instead.")]
        public uint GetCullMask()
        {
            return NativeCalls.godot_icall_0_188(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_update_mode");

        [GodotMethod("set_update_mode")]
        [Obsolete("SetUpdateMode is deprecated. Use the UpdateMode property instead.")]
        public void SetUpdateMode(ReflectionProbe.UpdateModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_22, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_update_mode");

        [GodotMethod("get_update_mode")]
        [Obsolete("GetUpdateMode is deprecated. Use the UpdateMode property instead.")]
        public ReflectionProbe.UpdateModeEnum GetUpdateMode()
        {
            return (ReflectionProbe.UpdateModeEnum)NativeCalls.godot_icall_0_814(method_bind_23, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
