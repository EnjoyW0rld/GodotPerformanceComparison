using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Baked lightmaps are an alternative workflow for adding indirect (or baked) lighting to a scene. Unlike the <see cref="Godot.GIProbe"/> approach, baked lightmaps work fine on low-end PCs and mobile devices as they consume almost no resources in run-time.</para>
    /// <para>Procedural generation: Lightmap baking functionality is only available in the editor. This means <see cref="Godot.BakedLightmap"/> is not suited to procedurally generated or user-built levels. For procedurally generated or user-built levels, use <see cref="Godot.GIProbe"/> instead.</para>
    /// <para>Note: Due to how lightmaps work, most properties only have a visible effect once lightmaps are baked again.</para>
    /// </summary>
    public partial class BakedLightmap : VisualInstance
    {
        public enum BakeQuality
        {
            /// <summary>
            /// <para>The lowest bake quality mode. Fastest to calculate.</para>
            /// </summary>
            Low = 0,
            /// <summary>
            /// <para>The default bake quality mode.</para>
            /// </summary>
            Medium = 1,
            /// <summary>
            /// <para>A higher bake quality mode. Takes longer to calculate.</para>
            /// </summary>
            High = 2,
            /// <summary>
            /// <para>The highest bake quality mode. Takes the longest to calculate.</para>
            /// </summary>
            Ultra = 3
        }

        public enum BakeError
        {
            /// <summary>
            /// <para>Baking was successful.</para>
            /// </summary>
            Ok = 0,
            /// <summary>
            /// <para>Returns if no viable save path is found. This can happen where an <see cref="Godot.BakedLightmap.ImagePath"/> is not specified or when the save location is invalid.</para>
            /// </summary>
            NoSavePath = 1,
            /// <summary>
            /// <para>Currently unused.</para>
            /// </summary>
            NoMeshes = 2,
            /// <summary>
            /// <para>Returns when the baker cannot save per-mesh textures to file.</para>
            /// </summary>
            CantCreateImage = 3,
            /// <summary>
            /// <para>The size of the generated lightmaps is too large.</para>
            /// </summary>
            LightmapSize = 4,
            /// <summary>
            /// <para>Some mesh contains UV2 values outside the <c>[0,1]</c> range.</para>
            /// </summary>
            InvalidMesh = 5,
            /// <summary>
            /// <para>Returns if user cancels baking.</para>
            /// </summary>
            UserAborted = 6,
            /// <summary>
            /// <para>Returns if lightmapper can't be created. Unless you are using a custom lightmapper, please report this as bug.</para>
            /// </summary>
            NoLightmapper = 7,
            /// <summary>
            /// <para>There is no root node to start baking from. Either provide <c>from_node</c> argument or attach this node to a parent that should be used as root.</para>
            /// </summary>
            NoRoot = 8
        }

        public enum EnvironmentModeEnum
        {
            /// <summary>
            /// <para>No environment is used during baking.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>The baked environment is automatically picked from the current scene.</para>
            /// </summary>
            Scene = 1,
            /// <summary>
            /// <para>A custom sky is used as environment during baking.</para>
            /// </summary>
            CustomSky = 2,
            /// <summary>
            /// <para>A custom solid color is used as environment during baking.</para>
            /// </summary>
            CustomColor = 3
        }

        /// <summary>
        /// <para>Size of the baked lightmap. Only meshes inside this region will be included in the baked lightmap, also used as the bounds of the captured region for dynamic lighting.</para>
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
        /// <para>Determines the amount of samples per texel used in indirect light baking. The amount of samples for each quality level can be configured in the project settings.</para>
        /// </summary>
        public BakedLightmap.BakeQuality Quality
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBakeQuality();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBakeQuality(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Number of light bounces that are taken into account during baking. See also <see cref="Godot.BakedLightmap.BounceIndirectEnergy"/>.</para>
        /// </summary>
        public int Bounces
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBounces();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBounces(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The energy multiplier for each bounce. Higher values will make indirect lighting brighter. A value of <c>1.0</c> represents physically accurate behavior, but higher values can be used to make indirect lighting propagate more visibly when using a low number of bounces. This can be used to speed up bake times by lowering the number of <see cref="Godot.BakedLightmap.Bounces"/> then increasing <see cref="Godot.BakedLightmap.BounceIndirectEnergy"/>. Unlike <see cref="Godot.BakedLightmapData.Energy"/>, this property does not affect direct lighting emitted by light nodes, emissive materials and the environment.</para>
        /// <para>Note: <see cref="Godot.BakedLightmap.BounceIndirectEnergy"/> only has an effect if <see cref="Godot.BakedLightmap.Bounces"/> is set to a value greater than or equal to <c>1</c>.</para>
        /// </summary>
        public float BounceIndirectEnergy
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBounceIndirectEnergy();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBounceIndirectEnergy(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When enabled, a lightmap denoiser will be used to reduce the noise inherent to Monte Carlo based global illumination.</para>
        /// </summary>
        public bool UseDenoiser
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUsingDenoiser();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseDenoiser(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, stores the lightmap textures in a high dynamic range format (EXR). If <c>false</c>, stores the lightmap texture in a low dynamic range PNG image. This can be set to <c>false</c> to reduce disk usage, but light values over 1.0 will be clamped and you may see banding caused by the reduced precision.</para>
        /// <para>Note: Setting <see cref="Godot.BakedLightmap.UseHdr"/> to <c>true</c> will decrease lightmap banding even when using the GLES2 backend or if  is <c>false</c>.</para>
        /// </summary>
        public bool UseHdr
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUsingHdr();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseHdr(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Store full color values in the lightmap textures. When disabled, lightmap textures will store a single brightness channel. Can be disabled to reduce disk usage if the scene contains only white lights or you don't mind losing color information in indirect lighting.</para>
        /// </summary>
        public bool UseColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUsingColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Raycasting bias used during baking to avoid floating point precision issues.</para>
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
        /// <para>If a baked mesh doesn't have a UV2 size hint, this value will be used to roughly compute a suitable lightmap size.</para>
        /// </summary>
        public float DefaultTexelsPerUnit
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDefaultTexelsPerUnit();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDefaultTexelsPerUnit(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the lightmapper will merge the textures for all meshes into one or several large layered textures. If <c>false</c>, every mesh will get its own lightmap texture, which is less efficient.</para>
        /// <para>Note: Atlas lightmap rendering is only supported in GLES3, not GLES2. Non-atlas lightmap rendering is supported by both GLES3 and GLES2. If  is <c>true</c>, consider baking lightmaps with <see cref="Godot.BakedLightmap.AtlasGenerate"/> set to <c>false</c> so that the resulting lightmap is visible in both GLES3 and GLES2.</para>
        /// </summary>
        public bool AtlasGenerate
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsGenerateAtlasEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGenerateAtlas(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Maximum size of each lightmap layer, only used when <see cref="Godot.BakedLightmap.AtlasGenerate"/> is enabled.</para>
        /// </summary>
        public int AtlasMaxSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaxAtlasSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaxAtlasSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Decides which environment to use during baking.</para>
        /// </summary>
        public BakedLightmap.EnvironmentModeEnum EnvironmentMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEnvironmentMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnvironmentMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The <see cref="Godot.Sky"/> resource to use when <see cref="Godot.BakedLightmap.EnvironmentMode"/> is set o <see cref="Godot.BakedLightmap.EnvironmentModeEnum.CustomSky"/>.</para>
        /// </summary>
        public Sky EnvironmentCustomSky
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEnvironmentCustomSky();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnvironmentCustomSky(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The rotation of the baked custom sky.</para>
        /// </summary>
        public Vector3 EnvironmentCustomSkyRotationDegrees
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEnvironmentCustomSkyRotationDegrees();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnvironmentCustomSkyRotationDegrees(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The environment color when <see cref="Godot.BakedLightmap.EnvironmentMode"/> is set to <see cref="Godot.BakedLightmap.EnvironmentModeEnum.CustomColor"/>.</para>
        /// </summary>
        public Color EnvironmentCustomColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEnvironmentCustomColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnvironmentCustomColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The energy scaling factor when when <see cref="Godot.BakedLightmap.EnvironmentMode"/> is set to <see cref="Godot.BakedLightmap.EnvironmentModeEnum.CustomColor"/> or <see cref="Godot.BakedLightmap.EnvironmentModeEnum.CustomSky"/>.</para>
        /// </summary>
        public float EnvironmentCustomEnergy
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEnvironmentCustomEnergy();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnvironmentCustomEnergy(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Minimum ambient light for all the lightmap texels. This doesn't take into account any occlusion from the scene's geometry, it simply ensures a minimum amount of light on all the lightmap texels. Can be used for artistic control on shadow color.</para>
        /// </summary>
        public Color EnvironmentMinLight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEnvironmentMinLight();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnvironmentMinLight(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When enabled, an octree containing the scene's lighting information will be computed. This octree will then be used to light dynamic objects in the scene.</para>
        /// </summary>
        public bool CaptureEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCaptureEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCaptureEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Grid size used for real-time capture information on dynamic objects.</para>
        /// </summary>
        public float CaptureCellSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCaptureCellSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCaptureCellSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Bake quality of the capture data.</para>
        /// </summary>
        public BakedLightmap.BakeQuality CaptureQuality
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCaptureQuality();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCaptureQuality(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Bias value to reduce the amount of light propagation in the captured octree.</para>
        /// </summary>
        public float CapturePropagation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCapturePropagation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCapturePropagation(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Deprecated, in previous versions it determined the location where lightmaps were be saved.</para>
        /// </summary>
        public string ImagePath
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetImagePath();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetImagePath(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The calculated light data.</para>
        /// </summary>
        public BakedLightmapData LightData
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLightData();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLightData(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "BakedLightmap";

        public BakedLightmap() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_BakedLightmap_Ctor(this);
        }

        internal BakedLightmap(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_light_data");

        [GodotMethod("set_light_data")]
        [Obsolete("SetLightData is deprecated. Use the LightData property instead.")]
        public void SetLightData(BakedLightmapData data)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(data));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_light_data");

        [GodotMethod("get_light_data")]
        [Obsolete("GetLightData is deprecated. Use the LightData property instead.")]
        public BakedLightmapData GetLightData()
        {
            return NativeCalls.godot_icall_0_195(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bake_quality");

        [GodotMethod("set_bake_quality")]
        [Obsolete("SetBakeQuality is deprecated. Use the Quality property instead.")]
        public void SetBakeQuality(BakedLightmap.BakeQuality quality)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)quality);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bake_quality");

        [GodotMethod("get_bake_quality")]
        [Obsolete("GetBakeQuality is deprecated. Use the Quality property instead.")]
        public BakedLightmap.BakeQuality GetBakeQuality()
        {
            return (BakedLightmap.BakeQuality)NativeCalls.godot_icall_0_196(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bounces");

        [GodotMethod("set_bounces")]
        [Obsolete("SetBounces is deprecated. Use the Bounces property instead.")]
        public void SetBounces(int bounces)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), bounces);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bounces");

        [GodotMethod("get_bounces")]
        [Obsolete("GetBounces is deprecated. Use the Bounces property instead.")]
        public int GetBounces()
        {
            return NativeCalls.godot_icall_0_5(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bounce_indirect_energy");

        [GodotMethod("set_bounce_indirect_energy")]
        [Obsolete("SetBounceIndirectEnergy is deprecated. Use the BounceIndirectEnergy property instead.")]
        public void SetBounceIndirectEnergy(float bounceIndirectEnergy)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), bounceIndirectEnergy);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bounce_indirect_energy");

        [GodotMethod("get_bounce_indirect_energy")]
        [Obsolete("GetBounceIndirectEnergy is deprecated. Use the BounceIndirectEnergy property instead.")]
        public float GetBounceIndirectEnergy()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bias");

        [GodotMethod("set_bias")]
        [Obsolete("SetBias is deprecated. Use the Bias property instead.")]
        public void SetBias(float bias)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), bias);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bias");

        [GodotMethod("get_bias")]
        [Obsolete("GetBias is deprecated. Use the Bias property instead.")]
        public float GetBias()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_environment_mode");

        [GodotMethod("set_environment_mode")]
        [Obsolete("SetEnvironmentMode is deprecated. Use the EnvironmentMode property instead.")]
        public void SetEnvironmentMode(BakedLightmap.EnvironmentModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_10, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_environment_mode");

        [GodotMethod("get_environment_mode")]
        [Obsolete("GetEnvironmentMode is deprecated. Use the EnvironmentMode property instead.")]
        public BakedLightmap.EnvironmentModeEnum GetEnvironmentMode()
        {
            return (BakedLightmap.EnvironmentModeEnum)NativeCalls.godot_icall_0_197(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_environment_custom_sky");

        [GodotMethod("set_environment_custom_sky")]
        [Obsolete("SetEnvironmentCustomSky is deprecated. Use the EnvironmentCustomSky property instead.")]
        public void SetEnvironmentCustomSky(Sky sky)
        {
            NativeCalls.godot_icall_1_24(method_bind_12, Object.GetPtr(this), Object.GetPtr(sky));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_environment_custom_sky");

        [GodotMethod("get_environment_custom_sky")]
        [Obsolete("GetEnvironmentCustomSky is deprecated. Use the EnvironmentCustomSky property instead.")]
        public Sky GetEnvironmentCustomSky()
        {
            return NativeCalls.godot_icall_0_198(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_environment_custom_sky_rotation_degrees");

        [GodotMethod("set_environment_custom_sky_rotation_degrees")]
        [Obsolete("SetEnvironmentCustomSkyRotationDegrees is deprecated. Use the EnvironmentCustomSkyRotationDegrees property instead.")]
        public void SetEnvironmentCustomSkyRotationDegrees(Vector3 rotation)
        {
            NativeCalls.godot_icall_1_148(method_bind_14, Object.GetPtr(this), ref rotation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_environment_custom_sky_rotation_degrees");

        [GodotMethod("get_environment_custom_sky_rotation_degrees")]
        [Obsolete("GetEnvironmentCustomSkyRotationDegrees is deprecated. Use the EnvironmentCustomSkyRotationDegrees property instead.")]
        public Vector3 GetEnvironmentCustomSkyRotationDegrees()
        {
            NativeCalls.godot_icall_0_8(method_bind_15, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_environment_custom_color");

        [GodotMethod("set_environment_custom_color")]
        [Obsolete("SetEnvironmentCustomColor is deprecated. Use the EnvironmentCustomColor property instead.")]
        public void SetEnvironmentCustomColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_16, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_environment_custom_color");

        [GodotMethod("get_environment_custom_color")]
        [Obsolete("GetEnvironmentCustomColor is deprecated. Use the EnvironmentCustomColor property instead.")]
        public Color GetEnvironmentCustomColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_17, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_environment_custom_energy");

        [GodotMethod("set_environment_custom_energy")]
        [Obsolete("SetEnvironmentCustomEnergy is deprecated. Use the EnvironmentCustomEnergy property instead.")]
        public void SetEnvironmentCustomEnergy(float energy)
        {
            NativeCalls.godot_icall_1_15(method_bind_18, Object.GetPtr(this), energy);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_environment_custom_energy");

        [GodotMethod("get_environment_custom_energy")]
        [Obsolete("GetEnvironmentCustomEnergy is deprecated. Use the EnvironmentCustomEnergy property instead.")]
        public float GetEnvironmentCustomEnergy()
        {
            return NativeCalls.godot_icall_0_14(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_environment_min_light");

        [GodotMethod("set_environment_min_light")]
        [Obsolete("SetEnvironmentMinLight is deprecated. Use the EnvironmentMinLight property instead.")]
        public void SetEnvironmentMinLight(Color minLight)
        {
            NativeCalls.godot_icall_1_199(method_bind_20, Object.GetPtr(this), ref minLight);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_environment_min_light");

        [GodotMethod("get_environment_min_light")]
        [Obsolete("GetEnvironmentMinLight is deprecated. Use the EnvironmentMinLight property instead.")]
        public Color GetEnvironmentMinLight()
        {
            NativeCalls.godot_icall_0_200(method_bind_21, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_denoiser");

        [GodotMethod("set_use_denoiser")]
        [Obsolete("SetUseDenoiser is deprecated. Use the UseDenoiser property instead.")]
        public void SetUseDenoiser(bool useDenoiser)
        {
            NativeCalls.godot_icall_1_16(method_bind_22, Object.GetPtr(this), useDenoiser);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_using_denoiser");

        [GodotMethod("is_using_denoiser")]
        [Obsolete("IsUsingDenoiser is deprecated. Use the UseDenoiser property instead.")]
        public bool IsUsingDenoiser()
        {
            return NativeCalls.godot_icall_0_7(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_hdr");

        [GodotMethod("set_use_hdr")]
        [Obsolete("SetUseHdr is deprecated. Use the UseHdr property instead.")]
        public void SetUseHdr(bool useDenoiser)
        {
            NativeCalls.godot_icall_1_16(method_bind_24, Object.GetPtr(this), useDenoiser);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_using_hdr");

        [GodotMethod("is_using_hdr")]
        [Obsolete("IsUsingHdr is deprecated. Use the UseHdr property instead.")]
        public bool IsUsingHdr()
        {
            return NativeCalls.godot_icall_0_7(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_color");

        [GodotMethod("set_use_color")]
        [Obsolete("SetUseColor is deprecated. Use the UseColor property instead.")]
        public void SetUseColor(bool useDenoiser)
        {
            NativeCalls.godot_icall_1_16(method_bind_26, Object.GetPtr(this), useDenoiser);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_using_color");

        [GodotMethod("is_using_color")]
        [Obsolete("IsUsingColor is deprecated. Use the UseColor property instead.")]
        public bool IsUsingColor()
        {
            return NativeCalls.godot_icall_0_7(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_generate_atlas");

        [GodotMethod("set_generate_atlas")]
        [Obsolete("SetGenerateAtlas is deprecated. Use the AtlasGenerate property instead.")]
        public void SetGenerateAtlas(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_28, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_generate_atlas_enabled");

        [GodotMethod("is_generate_atlas_enabled")]
        [Obsolete("IsGenerateAtlasEnabled is deprecated. Use the AtlasGenerate property instead.")]
        public bool IsGenerateAtlasEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max_atlas_size");

        [GodotMethod("set_max_atlas_size")]
        [Obsolete("SetMaxAtlasSize is deprecated. Use the AtlasMaxSize property instead.")]
        public void SetMaxAtlasSize(int maxAtlasSize)
        {
            NativeCalls.godot_icall_1_4(method_bind_30, Object.GetPtr(this), maxAtlasSize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max_atlas_size");

        [GodotMethod("get_max_atlas_size")]
        [Obsolete("GetMaxAtlasSize is deprecated. Use the AtlasMaxSize property instead.")]
        public int GetMaxAtlasSize()
        {
            return NativeCalls.godot_icall_0_5(method_bind_31, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_capture_quality");

        [GodotMethod("set_capture_quality")]
        [Obsolete("SetCaptureQuality is deprecated. Use the CaptureQuality property instead.")]
        public void SetCaptureQuality(BakedLightmap.BakeQuality captureQuality)
        {
            NativeCalls.godot_icall_1_4(method_bind_32, Object.GetPtr(this), (int)captureQuality);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_capture_quality");

        [GodotMethod("get_capture_quality")]
        [Obsolete("GetCaptureQuality is deprecated. Use the CaptureQuality property instead.")]
        public BakedLightmap.BakeQuality GetCaptureQuality()
        {
            return (BakedLightmap.BakeQuality)NativeCalls.godot_icall_0_196(method_bind_33, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_extents");

        [GodotMethod("set_extents")]
        [Obsolete("SetExtents is deprecated. Use the Extents property instead.")]
        public void SetExtents(Vector3 extents)
        {
            NativeCalls.godot_icall_1_148(method_bind_34, Object.GetPtr(this), ref extents);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_extents");

        [GodotMethod("get_extents")]
        [Obsolete("GetExtents is deprecated. Use the Extents property instead.")]
        public Vector3 GetExtents()
        {
            NativeCalls.godot_icall_0_8(method_bind_35, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_default_texels_per_unit");

        [GodotMethod("set_default_texels_per_unit")]
        [Obsolete("SetDefaultTexelsPerUnit is deprecated. Use the DefaultTexelsPerUnit property instead.")]
        public void SetDefaultTexelsPerUnit(float texels)
        {
            NativeCalls.godot_icall_1_15(method_bind_36, Object.GetPtr(this), texels);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_default_texels_per_unit");

        [GodotMethod("get_default_texels_per_unit")]
        [Obsolete("GetDefaultTexelsPerUnit is deprecated. Use the DefaultTexelsPerUnit property instead.")]
        public float GetDefaultTexelsPerUnit()
        {
            return NativeCalls.godot_icall_0_14(method_bind_37, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_capture_propagation");

        [GodotMethod("set_capture_propagation")]
        [Obsolete("SetCapturePropagation is deprecated. Use the CapturePropagation property instead.")]
        public void SetCapturePropagation(float propagation)
        {
            NativeCalls.godot_icall_1_15(method_bind_38, Object.GetPtr(this), propagation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_capture_propagation");

        [GodotMethod("get_capture_propagation")]
        [Obsolete("GetCapturePropagation is deprecated. Use the CapturePropagation property instead.")]
        public float GetCapturePropagation()
        {
            return NativeCalls.godot_icall_0_14(method_bind_39, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_capture_enabled");

        [GodotMethod("set_capture_enabled")]
        [Obsolete("SetCaptureEnabled is deprecated. Use the CaptureEnabled property instead.")]
        public void SetCaptureEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_40, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_capture_enabled");

        [GodotMethod("get_capture_enabled")]
        [Obsolete("GetCaptureEnabled is deprecated. Use the CaptureEnabled property instead.")]
        public bool GetCaptureEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_41, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_capture_cell_size");

        [GodotMethod("set_capture_cell_size")]
        [Obsolete("SetCaptureCellSize is deprecated. Use the CaptureCellSize property instead.")]
        public void SetCaptureCellSize(float captureCellSize)
        {
            NativeCalls.godot_icall_1_15(method_bind_42, Object.GetPtr(this), captureCellSize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_capture_cell_size");

        [GodotMethod("get_capture_cell_size")]
        [Obsolete("GetCaptureCellSize is deprecated. Use the CaptureCellSize property instead.")]
        public float GetCaptureCellSize()
        {
            return NativeCalls.godot_icall_0_14(method_bind_43, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_image_path");

        [GodotMethod("set_image_path")]
        [Obsolete("SetImagePath is deprecated. Use the ImagePath property instead.")]
        public void SetImagePath(string imagePath)
        {
            NativeCalls.godot_icall_1_54(method_bind_44, Object.GetPtr(this), imagePath);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_image_path");

        [GodotMethod("get_image_path")]
        [Obsolete("GetImagePath is deprecated. Use the ImagePath property instead.")]
        public string GetImagePath()
        {
            return NativeCalls.godot_icall_0_6(method_bind_45, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "bake");

        /// <summary>
        /// <para>Bakes the lightmap, scanning from the given <c>from_node</c> root and saves the resulting <see cref="Godot.BakedLightmapData"/> in <c>data_save_path</c>. If no root node is provided, parent of this node will be used as root instead. If no save path is provided it will try to match the path from the current <see cref="Godot.BakedLightmap.LightData"/>.</para>
        /// </summary>
        [GodotMethod("bake")]
        public BakedLightmap.BakeError Bake(Node fromNode = null, string dataSavePath = "")
        {
            return (BakedLightmap.BakeError)NativeCalls.godot_icall_2_201(method_bind_46, Object.GetPtr(this), Object.GetPtr(fromNode), dataSavePath);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
