using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Resource for environment nodes (like <see cref="Godot.WorldEnvironment"/>) that define multiple environment operations (such as background <see cref="Godot.Sky"/> or <see cref="Godot.Color"/>, ambient light, fog, depth-of-field...). These parameters affect the final render of the scene. The order of these operations is:</para>
    /// <para>- Depth of Field Blur</para>
    /// <para>- Glow</para>
    /// <para>- Tonemap (Auto Exposure)</para>
    /// <para>- Adjustments</para>
    /// <para>If the target <see cref="Godot.Viewport"/> is set to "2D Without Sampling", all post-processing effects will be unavailable. With "3D Without Effects", the following options will be unavailable:</para>
    /// <para>- Ssao</para>
    /// <para>- Ss Reflections</para>
    /// <para>This can be configured for the root Viewport with , or for specific Viewports via the <see cref="Godot.Viewport.Usage"/> property.</para>
    /// <para>Note that  has a mobile platform override to use "3D Without Effects" by default. It improves the performance on mobile devices, but at the same time affects the screen display on mobile devices.</para>
    /// </summary>
    public partial class Environment : Resource
    {
        public enum SSAOBlur
        {
            /// <summary>
            /// <para>No blur for the screen-space ambient occlusion effect (fastest).</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>1×1 blur for the screen-space ambient occlusion effect.</para>
            /// </summary>
            Blur1x1 = 1,
            /// <summary>
            /// <para>2×2 blur for the screen-space ambient occlusion effect.</para>
            /// </summary>
            Blur2x2 = 2,
            /// <summary>
            /// <para>3×3 blur for the screen-space ambient occlusion effect (slowest).</para>
            /// </summary>
            Blur3x3 = 3
        }

        public enum ToneMapper
        {
            /// <summary>
            /// <para>Linear tonemapper operator. Reads the linear data and passes it on unmodified. This can cause bright lighting to look blown out, with noticeable clipping in the output colors.</para>
            /// </summary>
            Linear = 0,
            /// <summary>
            /// <para>Reinhardt tonemapper operator. Performs a variation on rendered pixels' colors by this formula: <c>color = color / (1 + color)</c>. This avoids clipping bright highlights, but the resulting image can look a bit dull.</para>
            /// </summary>
            Reinhardt = 1,
            /// <summary>
            /// <para>Filmic tonemapper operator. This avoids clipping bright highlights, with a resulting image that usually looks more vivid than <see cref="Godot.Environment.ToneMapper.Reinhardt"/>.</para>
            /// </summary>
            Filmic = 2,
            /// <summary>
            /// <para>Use the legacy Godot version of the Academy Color Encoding System tonemapper. Unlike <see cref="Godot.Environment.ToneMapper.AcesFitted"/>, this version of ACES does not handle bright lighting in a physically accurate way. ACES typically has a more contrasted output compared to <see cref="Godot.Environment.ToneMapper.Reinhardt"/> and <see cref="Godot.Environment.ToneMapper.Filmic"/>.</para>
            /// <para>Note: This tonemapping operator will be removed in Godot 4.0 in favor of the more accurate <see cref="Godot.Environment.ToneMapper.AcesFitted"/>.</para>
            /// </summary>
            Aces = 3,
            /// <summary>
            /// <para>Use the Academy Color Encoding System tonemapper. ACES is slightly more expensive than other options, but it handles bright lighting in a more realistic fashion by desaturating it as it becomes brighter. ACES typically has a more contrasted output compared to <see cref="Godot.Environment.ToneMapper.Reinhardt"/> and <see cref="Godot.Environment.ToneMapper.Filmic"/>.</para>
            /// </summary>
            AcesFitted = 4
        }

        public enum GlowBlendModeEnum
        {
            /// <summary>
            /// <para>Additive glow blending mode. Mostly used for particles, glows (bloom), lens flare, bright sources.</para>
            /// </summary>
            Additive = 0,
            /// <summary>
            /// <para>Screen glow blending mode. Increases brightness, used frequently with bloom.</para>
            /// </summary>
            Screen = 1,
            /// <summary>
            /// <para>Soft light glow blending mode. Modifies contrast, exposes shadows and highlights (vivid bloom).</para>
            /// </summary>
            Softlight = 2,
            /// <summary>
            /// <para>Replace glow blending mode. Replaces all pixels' color by the glow value. This can be used to simulate a full-screen blur effect by tweaking the glow parameters to match the original image's brightness.</para>
            /// </summary>
            Replace = 3
        }

        public enum BGMode
        {
            /// <summary>
            /// <para>Keeps on screen every pixel drawn in the background. Only select this mode if you really need to keep the old data. On modern GPUs it will generally not be faster than clearing the background, and can be significantly slower, particularly on mobile.</para>
            /// <para>It can only be safely used in fully-interior scenes (no visible sky or sky reflections). If enabled in a scene where the background is visible, "ghost trail" artifacts will be visible when moving the camera.</para>
            /// </summary>
            Keep = 5,
            /// <summary>
            /// <para>Clears the background using the clear color defined in .</para>
            /// </summary>
            ClearColor = 0,
            /// <summary>
            /// <para>Clears the background using a custom clear color.</para>
            /// </summary>
            Color = 1,
            /// <summary>
            /// <para>Displays a user-defined sky in the background.</para>
            /// </summary>
            Sky = 2,
            /// <summary>
            /// <para>Clears the background using a custom clear color and allows defining a sky for shading and reflection. This mode is slightly faster than <see cref="Godot.Environment.BGMode.Sky"/> and should be preferred in scenes where reflections can be visible, but the sky itself never is (e.g. top-down camera).</para>
            /// </summary>
            ColorSky = 3,
            /// <summary>
            /// <para>Displays a <see cref="Godot.CanvasLayer"/> in the background.</para>
            /// </summary>
            Canvas = 4,
            /// <summary>
            /// <para>Displays a camera feed in the background.</para>
            /// </summary>
            CameraFeed = 6,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.Environment.BGMode"/> enum.</para>
            /// </summary>
            Max = 7
        }

        public enum SSAOQuality
        {
            /// <summary>
            /// <para>Low quality for the screen-space ambient occlusion effect (fastest).</para>
            /// </summary>
            Low = 0,
            /// <summary>
            /// <para>Medium quality for the screen-space ambient occlusion effect.</para>
            /// </summary>
            Medium = 1,
            /// <summary>
            /// <para>High quality for the screen-space ambient occlusion effect (slowest).</para>
            /// </summary>
            High = 2
        }

        public enum DOFBlurQuality
        {
            /// <summary>
            /// <para>Low depth-of-field blur quality (fastest).</para>
            /// </summary>
            Low = 0,
            /// <summary>
            /// <para>Medium depth-of-field blur quality.</para>
            /// </summary>
            Medium = 1,
            /// <summary>
            /// <para>High depth-of-field blur quality (slowest).</para>
            /// </summary>
            High = 2
        }

        /// <summary>
        /// <para>The background mode. See <see cref="Godot.Environment.BGMode"/> for possible values.</para>
        /// </summary>
        public Environment.BGMode BackgroundMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBackground();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBackground(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The <see cref="Godot.Sky"/> resource defined as background.</para>
        /// </summary>
        public Sky BackgroundSky
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSky();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSky(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The <see cref="Godot.Sky"/> resource's custom field of view.</para>
        /// </summary>
        public float BackgroundSkyCustomFov
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSkyCustomFov();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSkyCustomFov(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The <see cref="Godot.Sky"/> resource's rotation expressed as a <see cref="Godot.Basis"/>.</para>
        /// </summary>
        public Basis BackgroundSkyOrientation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSkyOrientation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSkyOrientation(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The <see cref="Godot.Sky"/> resource's rotation expressed as Euler angles in radians.</para>
        /// </summary>
        public Vector3 BackgroundSkyRotation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSkyRotation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSkyRotation(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The <see cref="Godot.Sky"/> resource's rotation expressed as Euler angles in degrees.</para>
        /// </summary>
        public Vector3 BackgroundSkyRotationDegrees
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSkyRotationDegrees();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSkyRotationDegrees(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The <see cref="Godot.Color"/> displayed for clear areas of the scene. Only effective when using the <see cref="Godot.Environment.BGMode.Color"/> or <see cref="Godot.Environment.BGMode.ColorSky"/> background modes).</para>
        /// </summary>
        public Color BackgroundColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBgColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBgColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The power of the light emitted by the background. This affects the sky brightness, the ambient light (if <see cref="Godot.Environment.AmbientLightSkyContribution"/> is greater than <c>0.0</c>) and specular light from the sky.</para>
        /// </summary>
        public float BackgroundEnergy
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBgEnergy();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBgEnergy(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum layer ID to display. Only effective when using the <see cref="Godot.Environment.BGMode.Canvas"/> background mode.</para>
        /// </summary>
        public int BackgroundCanvasMaxLayer
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCanvasMaxLayer();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCanvasMaxLayer(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The ID of the camera feed to show in the background.</para>
        /// </summary>
        public int BackgroundCameraFeedId
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCameraFeedId();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCameraFeedId(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The ambient light's <see cref="Godot.Color"/>.</para>
        /// </summary>
        public Color AmbientLightColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAmbientLightColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAmbientLightColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The ambient light's energy. The higher the value, the stronger the light.</para>
        /// </summary>
        public float AmbientLightEnergy
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAmbientLightEnergy();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAmbientLightEnergy(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Defines the amount of light that the sky brings on the scene. A value of <c>0.0</c> means that the sky's light emission has no effect on the scene illumination, thus all ambient illumination is provided by the ambient light. On the contrary, a value of <c>1.0</c> means that all the light that affects the scene is provided by the sky, thus the ambient light parameter has no effect on the scene.</para>
        /// <para>Note: <see cref="Godot.Environment.AmbientLightSkyContribution"/> is internally clamped between <c>0.0</c> and <c>1.0</c> (inclusive).</para>
        /// </summary>
        public float AmbientLightSkyContribution
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAmbientLightSkyContribution();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAmbientLightSkyContribution(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, fog effects are enabled. <see cref="Godot.Environment.FogHeightEnabled"/> and/or <see cref="Godot.Environment.FogDepthEnabled"/> must be set to <c>true</c> to actually display fog.</para>
        /// </summary>
        public bool FogEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsFogEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFogEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The fog's <see cref="Godot.Color"/>.</para>
        /// </summary>
        public Color FogColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFogColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFogColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The depth fog's <see cref="Godot.Color"/> when looking towards the sun.</para>
        /// </summary>
        public Color FogSunColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFogSunColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFogSunColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The intensity of the depth fog color transition when looking towards the sun. The sun's direction is determined automatically using the DirectionalLight node in the scene.</para>
        /// </summary>
        public float FogSunAmount
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFogSunAmount();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFogSunAmount(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the depth fog effect is enabled. When enabled, fog will appear in the distance (relative to the camera).</para>
        /// </summary>
        public bool FogDepthEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsFogDepthEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFogDepthEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The fog's depth starting distance from the camera.</para>
        /// </summary>
        public float FogDepthBegin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFogDepthBegin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFogDepthBegin(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The fog's depth end distance from the camera. If this value is set to 0, it will be equal to the current camera's <see cref="Godot.Camera.Far"/> value.</para>
        /// </summary>
        public float FogDepthEnd
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFogDepthEnd();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFogDepthEnd(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The fog depth's intensity curve. A number of presets are available in the Inspector by right-clicking the curve.</para>
        /// </summary>
        public float FogDepthCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFogDepthCurve();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFogDepthCurve(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Enables fog's light transmission effect. If <c>true</c>, light will be more visible in the fog to simulate light scattering as in real life.</para>
        /// </summary>
        public bool FogTransmitEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsFogTransmitEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFogTransmitEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The intensity of the fog light transmittance effect. Amount of light that the fog transmits.</para>
        /// </summary>
        public float FogTransmitCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFogTransmitCurve();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFogTransmitCurve(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the height fog effect is enabled. When enabled, fog will appear in a defined height range, regardless of the distance from the camera. This can be used to simulate "deep water" effects with a lower performance cost compared to a dedicated shader.</para>
        /// </summary>
        public bool FogHeightEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsFogHeightEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFogHeightEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The Y coordinate where the height fog will be the least intense. If this value is greater than <see cref="Godot.Environment.FogHeightMax"/>, fog will be displayed from top to bottom. Otherwise, it will be displayed from bottom to top.</para>
        /// </summary>
        public float FogHeightMin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFogHeightMin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFogHeightMin(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The Y coordinate where the height fog will be the most intense. If this value is greater than <see cref="Godot.Environment.FogHeightMin"/>, fog will be displayed from bottom to top. Otherwise, it will be displayed from top to bottom.</para>
        /// </summary>
        public float FogHeightMax
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFogHeightMax();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFogHeightMax(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The height fog's intensity. A number of presets are available in the Inspector by right-clicking the curve.</para>
        /// </summary>
        public float FogHeightCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFogHeightCurve();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFogHeightCurve(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The tonemapping mode to use. Tonemapping is the process that "converts" HDR values to be suitable for rendering on a SDR display. (Godot doesn't support rendering on HDR displays yet.)</para>
        /// </summary>
        public Environment.ToneMapper TonemapMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTonemapper();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTonemapper(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The default exposure used for tonemapping.</para>
        /// </summary>
        public float TonemapExposure
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTonemapExposure();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTonemapExposure(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The white reference value for tonemapping. Only effective if the <see cref="Godot.Environment.TonemapMode"/> isn't set to <see cref="Godot.Environment.ToneMapper.Linear"/>.</para>
        /// </summary>
        public float TonemapWhite
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTonemapWhite();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTonemapWhite(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, enables the tonemapping auto exposure mode of the scene renderer. If <c>true</c>, the renderer will automatically determine the exposure setting to adapt to the scene's illumination and the observed light.</para>
        /// </summary>
        public bool AutoExposureEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTonemapAutoExposure();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTonemapAutoExposure(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The scale of the auto exposure effect. Affects the intensity of auto exposure.</para>
        /// </summary>
        public float AutoExposureScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTonemapAutoExposureGrey();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTonemapAutoExposureGrey(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The minimum luminance value for the auto exposure.</para>
        /// </summary>
        public float AutoExposureMinLuma
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTonemapAutoExposureMin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTonemapAutoExposureMin(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum luminance value for the auto exposure.</para>
        /// </summary>
        public float AutoExposureMaxLuma
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTonemapAutoExposureMax();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTonemapAutoExposureMax(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The speed of the auto exposure effect. Affects the time needed for the camera to perform auto exposure.</para>
        /// </summary>
        public float AutoExposureSpeed
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTonemapAutoExposureSpeed();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTonemapAutoExposureSpeed(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, screen-space reflections are enabled. Screen-space reflections are more accurate than reflections from <see cref="Godot.GIProbe"/>s or <see cref="Godot.ReflectionProbe"/>s, but are slower and can't reflect surfaces occluded by others.</para>
        /// </summary>
        public bool SsReflectionsEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsSsrEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSsrEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum number of steps for screen-space reflections. Higher values are slower.</para>
        /// </summary>
        public int SsReflectionsMaxSteps
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSsrMaxSteps();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSsrMaxSteps(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The fade-in distance for screen-space reflections. Affects the area from the reflected material to the screen-space reflection).</para>
        /// </summary>
        public float SsReflectionsFadeIn
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSsrFadeIn();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSsrFadeIn(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The fade-out distance for screen-space reflections. Affects the area from the screen-space reflection to the "global" reflection.</para>
        /// </summary>
        public float SsReflectionsFadeOut
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSsrFadeOut();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSsrFadeOut(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The depth tolerance for screen-space reflections.</para>
        /// </summary>
        public float SsReflectionsDepthTolerance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSsrDepthTolerance();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSsrDepthTolerance(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, screen-space reflections will take the material roughness into account.</para>
        /// </summary>
        public bool SsReflectionsRoughness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsSsrRough();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSsrRough(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the screen-space ambient occlusion effect is enabled. This darkens objects' corners and cavities to simulate ambient light not reaching the entire object as in real life. This works well for small, dynamic objects, but baked lighting or ambient occlusion textures will do a better job at displaying ambient occlusion on large static objects. This is a costly effect and should be disabled first when running into performance issues.</para>
        /// </summary>
        public bool SsaoEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsSsaoEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSsaoEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The primary screen-space ambient occlusion radius.</para>
        /// </summary>
        public float SsaoRadius
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSsaoRadius();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSsaoRadius(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The primary screen-space ambient occlusion intensity. See also <see cref="Godot.Environment.SsaoRadius"/>.</para>
        /// </summary>
        public float SsaoIntensity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSsaoIntensity();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSsaoIntensity(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The secondary screen-space ambient occlusion radius. If set to a value higher than <c>0</c>, enables the secondary screen-space ambient occlusion effect which can be used to improve the effect's appearance (at the cost of performance).</para>
        /// </summary>
        public float SsaoRadius2
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSsaoRadius2();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSsaoRadius2(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The secondary screen-space ambient occlusion intensity. See also <see cref="Godot.Environment.SsaoRadius2"/>.</para>
        /// </summary>
        public float SsaoIntensity2
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSsaoIntensity2();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSsaoIntensity2(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The screen-space ambient occlusion bias. This should be kept high enough to prevent "smooth" curves from being affected by ambient occlusion.</para>
        /// </summary>
        public float SsaoBias
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSsaoBias();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSsaoBias(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The screen-space ambient occlusion intensity in direct light. In real life, ambient occlusion only applies to indirect light, which means its effects can't be seen in direct light. Values higher than <c>0</c> will make the SSAO effect visible in direct light.</para>
        /// </summary>
        public float SsaoLightAffect
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSsaoDirectLightAffect();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSsaoDirectLightAffect(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The screen-space ambient occlusion intensity on materials that have an AO texture defined. Values higher than <c>0</c> will make the SSAO effect visible in areas darkened by AO textures.</para>
        /// </summary>
        public float SsaoAoChannelAffect
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSsaoAoChannelAffect();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSsaoAoChannelAffect(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The screen-space ambient occlusion color.</para>
        /// </summary>
        public Color SsaoColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSsaoColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSsaoColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The screen-space ambient occlusion quality. Higher qualities will make better use of small objects for ambient occlusion, but are slower.</para>
        /// </summary>
        public Environment.SSAOQuality SsaoQuality
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSsaoQuality();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSsaoQuality(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The screen-space ambient occlusion blur quality. See <see cref="Godot.Environment.SSAOBlur"/> for possible values.</para>
        /// </summary>
        public Environment.SSAOBlur SsaoBlur
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSsaoBlur();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSsaoBlur(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The screen-space ambient occlusion edge sharpness.</para>
        /// </summary>
        public float SsaoEdgeSharpness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSsaoEdgeSharpness();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSsaoEdgeSharpness(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, enables the depth-of-field far blur effect.</para>
        /// </summary>
        public bool DofBlurFarEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDofBlurFarEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDofBlurFarEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The distance from the camera where the far blur effect affects the rendering.</para>
        /// </summary>
        public float DofBlurFarDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDofBlurFarDistance();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDofBlurFarDistance(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The length of the transition between the no-blur area and far blur.</para>
        /// </summary>
        public float DofBlurFarTransition
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDofBlurFarTransition();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDofBlurFarTransition(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of far blur for the depth-of-field effect.</para>
        /// </summary>
        public float DofBlurFarAmount
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDofBlurFarAmount();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDofBlurFarAmount(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The depth-of-field far blur's quality. Higher values can mitigate the visible banding effect seen at higher strengths, but are much slower.</para>
        /// </summary>
        public Environment.DOFBlurQuality DofBlurFarQuality
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDofBlurFarQuality();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDofBlurFarQuality(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, enables the depth-of-field near blur effect.</para>
        /// </summary>
        public bool DofBlurNearEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDofBlurNearEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDofBlurNearEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Distance from the camera where the near blur effect affects the rendering.</para>
        /// </summary>
        public float DofBlurNearDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDofBlurNearDistance();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDofBlurNearDistance(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The length of the transition between the near blur and no-blur area.</para>
        /// </summary>
        public float DofBlurNearTransition
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDofBlurNearTransition();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDofBlurNearTransition(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of near blur for the depth-of-field effect.</para>
        /// </summary>
        public float DofBlurNearAmount
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDofBlurNearAmount();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDofBlurNearAmount(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The depth-of-field near blur's quality. Higher values can mitigate the visible banding effect seen at higher strengths, but are much slower.</para>
        /// </summary>
        public Environment.DOFBlurQuality DofBlurNearQuality
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDofBlurNearQuality();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDofBlurNearQuality(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the glow effect is enabled.</para>
        /// <para>Note: Only effective if  is 3D (not 3D Without Effects). On mobile,  defaults to 3D Without Effects by default, so its <c>.mobile</c> override needs to be changed to 3D.</para>
        /// <para>Note: When using GLES3 on mobile, HDR rendering is disabled by default for performance reasons. This means glow will only be visible if <see cref="Godot.Environment.GlowHdrThreshold"/> is decreased below <c>1.0</c> or if <see cref="Godot.Environment.GlowBloom"/> is increased above <c>0.0</c>. Also consider increasing <see cref="Godot.Environment.GlowIntensity"/> to <c>1.5</c>. If you want glow to behave on mobile like it does on desktop (at a performance cost), enable 's <c>.mobile</c> override.</para>
        /// </summary>
        public bool GlowEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsGlowEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlowEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the 1st level of glow is enabled. This is the most "local" level (least blurry).</para>
        /// </summary>
        public bool GlowLevels__1
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsGlowLevelEnabled(0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlowLevel(0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the 2th level of glow is enabled.</para>
        /// </summary>
        public bool GlowLevels__2
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsGlowLevelEnabled(1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlowLevel(1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the 3th level of glow is enabled.</para>
        /// </summary>
        public bool GlowLevels__3
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsGlowLevelEnabled(2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlowLevel(2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the 4th level of glow is enabled.</para>
        /// </summary>
        public bool GlowLevels__4
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsGlowLevelEnabled(3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlowLevel(3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the 5th level of glow is enabled.</para>
        /// </summary>
        public bool GlowLevels__5
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsGlowLevelEnabled(4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlowLevel(4, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the 6th level of glow is enabled.</para>
        /// </summary>
        public bool GlowLevels__6
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsGlowLevelEnabled(5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlowLevel(5, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the 7th level of glow is enabled. This is the most "global" level (blurriest).</para>
        /// </summary>
        public bool GlowLevels__7
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsGlowLevelEnabled(6);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlowLevel(6, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The glow intensity. When using the GLES2 renderer, this should be increased to 1.5 to compensate for the lack of HDR rendering.</para>
        /// </summary>
        public float GlowIntensity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGlowIntensity();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlowIntensity(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The glow strength. When using the GLES2 renderer, this should be increased to 1.3 to compensate for the lack of HDR rendering.</para>
        /// </summary>
        public float GlowStrength
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGlowStrength();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlowStrength(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The bloom's intensity. If set to a value higher than <c>0</c>, this will make glow visible in areas darker than the <see cref="Godot.Environment.GlowHdrThreshold"/>.</para>
        /// </summary>
        public float GlowBloom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGlowBloom();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlowBloom(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The glow blending mode.</para>
        /// </summary>
        public Environment.GlowBlendModeEnum GlowBlendMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGlowBlendMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlowBlendMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The lower threshold of the HDR glow. When using the GLES2 renderer (which doesn't support HDR), this needs to be below <c>1.0</c> for glow to be visible. A value of <c>0.9</c> works well in this case.</para>
        /// </summary>
        public float GlowHdrThreshold
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGlowHdrBleedThreshold();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlowHdrBleedThreshold(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The higher threshold of the HDR glow. Areas brighter than this threshold will be clamped for the purposes of the glow effect.</para>
        /// </summary>
        public float GlowHdrLuminanceCap
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGlowHdrLuminanceCap();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlowHdrLuminanceCap(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The bleed scale of the HDR glow.</para>
        /// </summary>
        public float GlowHdrScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGlowHdrBleedScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlowHdrBleedScale(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Smooths out the blockiness created by sampling higher levels, at the cost of performance.</para>
        /// <para>Note: When using the GLES2 renderer, this is only available if the GPU supports the <c>GL_EXT_gpu_shader4</c> extension.</para>
        /// </summary>
        public bool GlowBicubicUpscale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsGlowBicubicUpscaleEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlowBicubicUpscale(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Takes more samples during downsample pass of glow. This ensures that single pixels are captured by glow which makes the glow look smoother and more stable during movement. However, it is very expensive and makes the glow post process take twice as long.</para>
        /// </summary>
        public bool GlowHighQuality
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsGlowHighQualityEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlowHighQuality(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, enables the <c>adjustment_*</c> properties provided by this resource. If <c>false</c>, modifications to the <c>adjustment_*</c> properties will have no effect on the rendered scene.</para>
        /// </summary>
        public bool AdjustmentEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsAdjustmentEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAdjustmentEnable(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The global brightness value of the rendered scene. Effective only if <c>adjustment_enabled</c> is <c>true</c>.</para>
        /// </summary>
        public float AdjustmentBrightness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAdjustmentBrightness();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAdjustmentBrightness(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The global contrast value of the rendered scene (default value is 1). Effective only if <c>adjustment_enabled</c> is <c>true</c>.</para>
        /// </summary>
        public float AdjustmentContrast
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAdjustmentContrast();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAdjustmentContrast(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The global color saturation value of the rendered scene (default value is 1). Effective only if <c>adjustment_enabled</c> is <c>true</c>.</para>
        /// </summary>
        public float AdjustmentSaturation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAdjustmentSaturation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAdjustmentSaturation(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Applies the provided <see cref="Godot.Texture"/> resource to affect the global color aspect of the rendered scene. Effective only if <c>adjustment_enabled</c> is <c>true</c>.</para>
        /// </summary>
        public Texture AdjustmentColorCorrection
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAdjustmentColorCorrection();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAdjustmentColorCorrection(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Environment";

        public Environment() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Environment_Ctor(this);
        }

        internal Environment(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_background");

        [GodotMethod("set_background")]
        [Obsolete("SetBackground is deprecated. Use the BackgroundMode property instead.")]
        public void SetBackground(Environment.BGMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sky");

        [GodotMethod("set_sky")]
        [Obsolete("SetSky is deprecated. Use the BackgroundSky property instead.")]
        public void SetSky(Sky sky)
        {
            NativeCalls.godot_icall_1_24(method_bind_1, Object.GetPtr(this), Object.GetPtr(sky));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sky_custom_fov");

        [GodotMethod("set_sky_custom_fov")]
        [Obsolete("SetSkyCustomFov is deprecated. Use the BackgroundSkyCustomFov property instead.")]
        public void SetSkyCustomFov(float scale)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sky_orientation");

        [GodotMethod("set_sky_orientation")]
        [Obsolete("SetSkyOrientation is deprecated. Use the BackgroundSkyOrientation property instead.")]
        public void SetSkyOrientation(Basis orientation)
        {
            NativeCalls.godot_icall_1_424(method_bind_3, Object.GetPtr(this), ref orientation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sky_rotation");

        [GodotMethod("set_sky_rotation")]
        [Obsolete("SetSkyRotation is deprecated. Use the BackgroundSkyRotation property instead.")]
        public void SetSkyRotation(Vector3 eulerRadians)
        {
            NativeCalls.godot_icall_1_148(method_bind_4, Object.GetPtr(this), ref eulerRadians);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sky_rotation_degrees");

        [GodotMethod("set_sky_rotation_degrees")]
        [Obsolete("SetSkyRotationDegrees is deprecated. Use the BackgroundSkyRotationDegrees property instead.")]
        public void SetSkyRotationDegrees(Vector3 eulerDegrees)
        {
            NativeCalls.godot_icall_1_148(method_bind_5, Object.GetPtr(this), ref eulerDegrees);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bg_color");

        [GodotMethod("set_bg_color")]
        [Obsolete("SetBgColor is deprecated. Use the BackgroundColor property instead.")]
        public void SetBgColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_6, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bg_energy");

        [GodotMethod("set_bg_energy")]
        [Obsolete("SetBgEnergy is deprecated. Use the BackgroundEnergy property instead.")]
        public void SetBgEnergy(float energy)
        {
            NativeCalls.godot_icall_1_15(method_bind_7, Object.GetPtr(this), energy);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_canvas_max_layer");

        [GodotMethod("set_canvas_max_layer")]
        [Obsolete("SetCanvasMaxLayer is deprecated. Use the BackgroundCanvasMaxLayer property instead.")]
        public void SetCanvasMaxLayer(int layer)
        {
            NativeCalls.godot_icall_1_4(method_bind_8, Object.GetPtr(this), layer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ambient_light_color");

        [GodotMethod("set_ambient_light_color")]
        [Obsolete("SetAmbientLightColor is deprecated. Use the AmbientLightColor property instead.")]
        public void SetAmbientLightColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_9, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ambient_light_energy");

        [GodotMethod("set_ambient_light_energy")]
        [Obsolete("SetAmbientLightEnergy is deprecated. Use the AmbientLightEnergy property instead.")]
        public void SetAmbientLightEnergy(float energy)
        {
            NativeCalls.godot_icall_1_15(method_bind_10, Object.GetPtr(this), energy);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ambient_light_sky_contribution");

        [GodotMethod("set_ambient_light_sky_contribution")]
        [Obsolete("SetAmbientLightSkyContribution is deprecated. Use the AmbientLightSkyContribution property instead.")]
        public void SetAmbientLightSkyContribution(float energy)
        {
            NativeCalls.godot_icall_1_15(method_bind_11, Object.GetPtr(this), energy);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_camera_feed_id");

        [GodotMethod("set_camera_feed_id")]
        [Obsolete("SetCameraFeedId is deprecated. Use the BackgroundCameraFeedId property instead.")]
        public void SetCameraFeedId(int cameraFeedId)
        {
            NativeCalls.godot_icall_1_4(method_bind_12, Object.GetPtr(this), cameraFeedId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_background");

        [GodotMethod("get_background")]
        [Obsolete("GetBackground is deprecated. Use the BackgroundMode property instead.")]
        public Environment.BGMode GetBackground()
        {
            return (Environment.BGMode)NativeCalls.godot_icall_0_425(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sky");

        [GodotMethod("get_sky")]
        [Obsolete("GetSky is deprecated. Use the BackgroundSky property instead.")]
        public Sky GetSky()
        {
            return NativeCalls.godot_icall_0_198(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sky_custom_fov");

        [GodotMethod("get_sky_custom_fov")]
        [Obsolete("GetSkyCustomFov is deprecated. Use the BackgroundSkyCustomFov property instead.")]
        public float GetSkyCustomFov()
        {
            return NativeCalls.godot_icall_0_14(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sky_orientation");

        [GodotMethod("get_sky_orientation")]
        [Obsolete("GetSkyOrientation is deprecated. Use the BackgroundSkyOrientation property instead.")]
        public Basis GetSkyOrientation()
        {
            NativeCalls.godot_icall_0_20(method_bind_16, Object.GetPtr(this), out Basis argRet); return (Basis)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sky_rotation");

        [GodotMethod("get_sky_rotation")]
        [Obsolete("GetSkyRotation is deprecated. Use the BackgroundSkyRotation property instead.")]
        public Vector3 GetSkyRotation()
        {
            NativeCalls.godot_icall_0_8(method_bind_17, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sky_rotation_degrees");

        [GodotMethod("get_sky_rotation_degrees")]
        [Obsolete("GetSkyRotationDegrees is deprecated. Use the BackgroundSkyRotationDegrees property instead.")]
        public Vector3 GetSkyRotationDegrees()
        {
            NativeCalls.godot_icall_0_8(method_bind_18, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bg_color");

        [GodotMethod("get_bg_color")]
        [Obsolete("GetBgColor is deprecated. Use the BackgroundColor property instead.")]
        public Color GetBgColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_19, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bg_energy");

        [GodotMethod("get_bg_energy")]
        [Obsolete("GetBgEnergy is deprecated. Use the BackgroundEnergy property instead.")]
        public float GetBgEnergy()
        {
            return NativeCalls.godot_icall_0_14(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_canvas_max_layer");

        [GodotMethod("get_canvas_max_layer")]
        [Obsolete("GetCanvasMaxLayer is deprecated. Use the BackgroundCanvasMaxLayer property instead.")]
        public int GetCanvasMaxLayer()
        {
            return NativeCalls.godot_icall_0_5(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ambient_light_color");

        [GodotMethod("get_ambient_light_color")]
        [Obsolete("GetAmbientLightColor is deprecated. Use the AmbientLightColor property instead.")]
        public Color GetAmbientLightColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_22, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ambient_light_energy");

        [GodotMethod("get_ambient_light_energy")]
        [Obsolete("GetAmbientLightEnergy is deprecated. Use the AmbientLightEnergy property instead.")]
        public float GetAmbientLightEnergy()
        {
            return NativeCalls.godot_icall_0_14(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ambient_light_sky_contribution");

        [GodotMethod("get_ambient_light_sky_contribution")]
        [Obsolete("GetAmbientLightSkyContribution is deprecated. Use the AmbientLightSkyContribution property instead.")]
        public float GetAmbientLightSkyContribution()
        {
            return NativeCalls.godot_icall_0_14(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_camera_feed_id");

        [GodotMethod("get_camera_feed_id")]
        [Obsolete("GetCameraFeedId is deprecated. Use the BackgroundCameraFeedId property instead.")]
        public int GetCameraFeedId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fog_enabled");

        [GodotMethod("set_fog_enabled")]
        [Obsolete("SetFogEnabled is deprecated. Use the FogEnabled property instead.")]
        public void SetFogEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_26, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_fog_enabled");

        [GodotMethod("is_fog_enabled")]
        [Obsolete("IsFogEnabled is deprecated. Use the FogEnabled property instead.")]
        public bool IsFogEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fog_color");

        [GodotMethod("set_fog_color")]
        [Obsolete("SetFogColor is deprecated. Use the FogColor property instead.")]
        public void SetFogColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_28, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fog_color");

        [GodotMethod("get_fog_color")]
        [Obsolete("GetFogColor is deprecated. Use the FogColor property instead.")]
        public Color GetFogColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_29, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fog_sun_color");

        [GodotMethod("set_fog_sun_color")]
        [Obsolete("SetFogSunColor is deprecated. Use the FogSunColor property instead.")]
        public void SetFogSunColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_30, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fog_sun_color");

        [GodotMethod("get_fog_sun_color")]
        [Obsolete("GetFogSunColor is deprecated. Use the FogSunColor property instead.")]
        public Color GetFogSunColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_31, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fog_sun_amount");

        [GodotMethod("set_fog_sun_amount")]
        [Obsolete("SetFogSunAmount is deprecated. Use the FogSunAmount property instead.")]
        public void SetFogSunAmount(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_32, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fog_sun_amount");

        [GodotMethod("get_fog_sun_amount")]
        [Obsolete("GetFogSunAmount is deprecated. Use the FogSunAmount property instead.")]
        public float GetFogSunAmount()
        {
            return NativeCalls.godot_icall_0_14(method_bind_33, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fog_depth_enabled");

        [GodotMethod("set_fog_depth_enabled")]
        [Obsolete("SetFogDepthEnabled is deprecated. Use the FogDepthEnabled property instead.")]
        public void SetFogDepthEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_34, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_fog_depth_enabled");

        [GodotMethod("is_fog_depth_enabled")]
        [Obsolete("IsFogDepthEnabled is deprecated. Use the FogDepthEnabled property instead.")]
        public bool IsFogDepthEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_35, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fog_depth_begin");

        [GodotMethod("set_fog_depth_begin")]
        [Obsolete("SetFogDepthBegin is deprecated. Use the FogDepthBegin property instead.")]
        public void SetFogDepthBegin(float distance)
        {
            NativeCalls.godot_icall_1_15(method_bind_36, Object.GetPtr(this), distance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fog_depth_begin");

        [GodotMethod("get_fog_depth_begin")]
        [Obsolete("GetFogDepthBegin is deprecated. Use the FogDepthBegin property instead.")]
        public float GetFogDepthBegin()
        {
            return NativeCalls.godot_icall_0_14(method_bind_37, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fog_depth_end");

        [GodotMethod("set_fog_depth_end")]
        [Obsolete("SetFogDepthEnd is deprecated. Use the FogDepthEnd property instead.")]
        public void SetFogDepthEnd(float distance)
        {
            NativeCalls.godot_icall_1_15(method_bind_38, Object.GetPtr(this), distance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fog_depth_end");

        [GodotMethod("get_fog_depth_end")]
        [Obsolete("GetFogDepthEnd is deprecated. Use the FogDepthEnd property instead.")]
        public float GetFogDepthEnd()
        {
            return NativeCalls.godot_icall_0_14(method_bind_39, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fog_depth_curve");

        [GodotMethod("set_fog_depth_curve")]
        [Obsolete("SetFogDepthCurve is deprecated. Use the FogDepthCurve property instead.")]
        public void SetFogDepthCurve(float curve)
        {
            NativeCalls.godot_icall_1_15(method_bind_40, Object.GetPtr(this), curve);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fog_depth_curve");

        [GodotMethod("get_fog_depth_curve")]
        [Obsolete("GetFogDepthCurve is deprecated. Use the FogDepthCurve property instead.")]
        public float GetFogDepthCurve()
        {
            return NativeCalls.godot_icall_0_14(method_bind_41, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fog_transmit_enabled");

        [GodotMethod("set_fog_transmit_enabled")]
        [Obsolete("SetFogTransmitEnabled is deprecated. Use the FogTransmitEnabled property instead.")]
        public void SetFogTransmitEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_42, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_fog_transmit_enabled");

        [GodotMethod("is_fog_transmit_enabled")]
        [Obsolete("IsFogTransmitEnabled is deprecated. Use the FogTransmitEnabled property instead.")]
        public bool IsFogTransmitEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_43, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fog_transmit_curve");

        [GodotMethod("set_fog_transmit_curve")]
        [Obsolete("SetFogTransmitCurve is deprecated. Use the FogTransmitCurve property instead.")]
        public void SetFogTransmitCurve(float curve)
        {
            NativeCalls.godot_icall_1_15(method_bind_44, Object.GetPtr(this), curve);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fog_transmit_curve");

        [GodotMethod("get_fog_transmit_curve")]
        [Obsolete("GetFogTransmitCurve is deprecated. Use the FogTransmitCurve property instead.")]
        public float GetFogTransmitCurve()
        {
            return NativeCalls.godot_icall_0_14(method_bind_45, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fog_height_enabled");

        [GodotMethod("set_fog_height_enabled")]
        [Obsolete("SetFogHeightEnabled is deprecated. Use the FogHeightEnabled property instead.")]
        public void SetFogHeightEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_46, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_fog_height_enabled");

        [GodotMethod("is_fog_height_enabled")]
        [Obsolete("IsFogHeightEnabled is deprecated. Use the FogHeightEnabled property instead.")]
        public bool IsFogHeightEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_47, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fog_height_min");

        [GodotMethod("set_fog_height_min")]
        [Obsolete("SetFogHeightMin is deprecated. Use the FogHeightMin property instead.")]
        public void SetFogHeightMin(float height)
        {
            NativeCalls.godot_icall_1_15(method_bind_48, Object.GetPtr(this), height);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fog_height_min");

        [GodotMethod("get_fog_height_min")]
        [Obsolete("GetFogHeightMin is deprecated. Use the FogHeightMin property instead.")]
        public float GetFogHeightMin()
        {
            return NativeCalls.godot_icall_0_14(method_bind_49, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fog_height_max");

        [GodotMethod("set_fog_height_max")]
        [Obsolete("SetFogHeightMax is deprecated. Use the FogHeightMax property instead.")]
        public void SetFogHeightMax(float height)
        {
            NativeCalls.godot_icall_1_15(method_bind_50, Object.GetPtr(this), height);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fog_height_max");

        [GodotMethod("get_fog_height_max")]
        [Obsolete("GetFogHeightMax is deprecated. Use the FogHeightMax property instead.")]
        public float GetFogHeightMax()
        {
            return NativeCalls.godot_icall_0_14(method_bind_51, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fog_height_curve");

        [GodotMethod("set_fog_height_curve")]
        [Obsolete("SetFogHeightCurve is deprecated. Use the FogHeightCurve property instead.")]
        public void SetFogHeightCurve(float curve)
        {
            NativeCalls.godot_icall_1_15(method_bind_52, Object.GetPtr(this), curve);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_53 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fog_height_curve");

        [GodotMethod("get_fog_height_curve")]
        [Obsolete("GetFogHeightCurve is deprecated. Use the FogHeightCurve property instead.")]
        public float GetFogHeightCurve()
        {
            return NativeCalls.godot_icall_0_14(method_bind_53, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_54 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tonemapper");

        [GodotMethod("set_tonemapper")]
        [Obsolete("SetTonemapper is deprecated. Use the TonemapMode property instead.")]
        public void SetTonemapper(Environment.ToneMapper mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_54, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_55 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tonemapper");

        [GodotMethod("get_tonemapper")]
        [Obsolete("GetTonemapper is deprecated. Use the TonemapMode property instead.")]
        public Environment.ToneMapper GetTonemapper()
        {
            return (Environment.ToneMapper)NativeCalls.godot_icall_0_426(method_bind_55, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_56 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tonemap_exposure");

        [GodotMethod("set_tonemap_exposure")]
        [Obsolete("SetTonemapExposure is deprecated. Use the TonemapExposure property instead.")]
        public void SetTonemapExposure(float exposure)
        {
            NativeCalls.godot_icall_1_15(method_bind_56, Object.GetPtr(this), exposure);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_57 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tonemap_exposure");

        [GodotMethod("get_tonemap_exposure")]
        [Obsolete("GetTonemapExposure is deprecated. Use the TonemapExposure property instead.")]
        public float GetTonemapExposure()
        {
            return NativeCalls.godot_icall_0_14(method_bind_57, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_58 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tonemap_white");

        [GodotMethod("set_tonemap_white")]
        [Obsolete("SetTonemapWhite is deprecated. Use the TonemapWhite property instead.")]
        public void SetTonemapWhite(float white)
        {
            NativeCalls.godot_icall_1_15(method_bind_58, Object.GetPtr(this), white);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_59 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tonemap_white");

        [GodotMethod("get_tonemap_white")]
        [Obsolete("GetTonemapWhite is deprecated. Use the TonemapWhite property instead.")]
        public float GetTonemapWhite()
        {
            return NativeCalls.godot_icall_0_14(method_bind_59, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_60 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tonemap_auto_exposure");

        [GodotMethod("set_tonemap_auto_exposure")]
        [Obsolete("SetTonemapAutoExposure is deprecated. Use the AutoExposureEnabled property instead.")]
        public void SetTonemapAutoExposure(bool autoExposure)
        {
            NativeCalls.godot_icall_1_16(method_bind_60, Object.GetPtr(this), autoExposure);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_61 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tonemap_auto_exposure");

        [GodotMethod("get_tonemap_auto_exposure")]
        [Obsolete("GetTonemapAutoExposure is deprecated. Use the AutoExposureEnabled property instead.")]
        public bool GetTonemapAutoExposure()
        {
            return NativeCalls.godot_icall_0_7(method_bind_61, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_62 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tonemap_auto_exposure_max");

        [GodotMethod("set_tonemap_auto_exposure_max")]
        [Obsolete("SetTonemapAutoExposureMax is deprecated. Use the AutoExposureMaxLuma property instead.")]
        public void SetTonemapAutoExposureMax(float exposureMax)
        {
            NativeCalls.godot_icall_1_15(method_bind_62, Object.GetPtr(this), exposureMax);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_63 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tonemap_auto_exposure_max");

        [GodotMethod("get_tonemap_auto_exposure_max")]
        [Obsolete("GetTonemapAutoExposureMax is deprecated. Use the AutoExposureMaxLuma property instead.")]
        public float GetTonemapAutoExposureMax()
        {
            return NativeCalls.godot_icall_0_14(method_bind_63, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_64 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tonemap_auto_exposure_min");

        [GodotMethod("set_tonemap_auto_exposure_min")]
        [Obsolete("SetTonemapAutoExposureMin is deprecated. Use the AutoExposureMinLuma property instead.")]
        public void SetTonemapAutoExposureMin(float exposureMin)
        {
            NativeCalls.godot_icall_1_15(method_bind_64, Object.GetPtr(this), exposureMin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_65 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tonemap_auto_exposure_min");

        [GodotMethod("get_tonemap_auto_exposure_min")]
        [Obsolete("GetTonemapAutoExposureMin is deprecated. Use the AutoExposureMinLuma property instead.")]
        public float GetTonemapAutoExposureMin()
        {
            return NativeCalls.godot_icall_0_14(method_bind_65, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_66 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tonemap_auto_exposure_speed");

        [GodotMethod("set_tonemap_auto_exposure_speed")]
        [Obsolete("SetTonemapAutoExposureSpeed is deprecated. Use the AutoExposureSpeed property instead.")]
        public void SetTonemapAutoExposureSpeed(float exposureSpeed)
        {
            NativeCalls.godot_icall_1_15(method_bind_66, Object.GetPtr(this), exposureSpeed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_67 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tonemap_auto_exposure_speed");

        [GodotMethod("get_tonemap_auto_exposure_speed")]
        [Obsolete("GetTonemapAutoExposureSpeed is deprecated. Use the AutoExposureSpeed property instead.")]
        public float GetTonemapAutoExposureSpeed()
        {
            return NativeCalls.godot_icall_0_14(method_bind_67, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_68 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tonemap_auto_exposure_grey");

        [GodotMethod("set_tonemap_auto_exposure_grey")]
        [Obsolete("SetTonemapAutoExposureGrey is deprecated. Use the AutoExposureScale property instead.")]
        public void SetTonemapAutoExposureGrey(float exposureGrey)
        {
            NativeCalls.godot_icall_1_15(method_bind_68, Object.GetPtr(this), exposureGrey);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_69 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tonemap_auto_exposure_grey");

        [GodotMethod("get_tonemap_auto_exposure_grey")]
        [Obsolete("GetTonemapAutoExposureGrey is deprecated. Use the AutoExposureScale property instead.")]
        public float GetTonemapAutoExposureGrey()
        {
            return NativeCalls.godot_icall_0_14(method_bind_69, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_70 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ssr_enabled");

        [GodotMethod("set_ssr_enabled")]
        [Obsolete("SetSsrEnabled is deprecated. Use the SsReflectionsEnabled property instead.")]
        public void SetSsrEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_70, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_71 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_ssr_enabled");

        [GodotMethod("is_ssr_enabled")]
        [Obsolete("IsSsrEnabled is deprecated. Use the SsReflectionsEnabled property instead.")]
        public bool IsSsrEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_71, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_72 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ssr_max_steps");

        [GodotMethod("set_ssr_max_steps")]
        [Obsolete("SetSsrMaxSteps is deprecated. Use the SsReflectionsMaxSteps property instead.")]
        public void SetSsrMaxSteps(int maxSteps)
        {
            NativeCalls.godot_icall_1_4(method_bind_72, Object.GetPtr(this), maxSteps);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_73 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ssr_max_steps");

        [GodotMethod("get_ssr_max_steps")]
        [Obsolete("GetSsrMaxSteps is deprecated. Use the SsReflectionsMaxSteps property instead.")]
        public int GetSsrMaxSteps()
        {
            return NativeCalls.godot_icall_0_5(method_bind_73, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_74 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ssr_fade_in");

        [GodotMethod("set_ssr_fade_in")]
        [Obsolete("SetSsrFadeIn is deprecated. Use the SsReflectionsFadeIn property instead.")]
        public void SetSsrFadeIn(float fadeIn)
        {
            NativeCalls.godot_icall_1_15(method_bind_74, Object.GetPtr(this), fadeIn);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_75 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ssr_fade_in");

        [GodotMethod("get_ssr_fade_in")]
        [Obsolete("GetSsrFadeIn is deprecated. Use the SsReflectionsFadeIn property instead.")]
        public float GetSsrFadeIn()
        {
            return NativeCalls.godot_icall_0_14(method_bind_75, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_76 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ssr_fade_out");

        [GodotMethod("set_ssr_fade_out")]
        [Obsolete("SetSsrFadeOut is deprecated. Use the SsReflectionsFadeOut property instead.")]
        public void SetSsrFadeOut(float fadeOut)
        {
            NativeCalls.godot_icall_1_15(method_bind_76, Object.GetPtr(this), fadeOut);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_77 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ssr_fade_out");

        [GodotMethod("get_ssr_fade_out")]
        [Obsolete("GetSsrFadeOut is deprecated. Use the SsReflectionsFadeOut property instead.")]
        public float GetSsrFadeOut()
        {
            return NativeCalls.godot_icall_0_14(method_bind_77, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_78 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ssr_depth_tolerance");

        [GodotMethod("set_ssr_depth_tolerance")]
        [Obsolete("SetSsrDepthTolerance is deprecated. Use the SsReflectionsDepthTolerance property instead.")]
        public void SetSsrDepthTolerance(float depthTolerance)
        {
            NativeCalls.godot_icall_1_15(method_bind_78, Object.GetPtr(this), depthTolerance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_79 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ssr_depth_tolerance");

        [GodotMethod("get_ssr_depth_tolerance")]
        [Obsolete("GetSsrDepthTolerance is deprecated. Use the SsReflectionsDepthTolerance property instead.")]
        public float GetSsrDepthTolerance()
        {
            return NativeCalls.godot_icall_0_14(method_bind_79, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_80 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ssr_rough");

        [GodotMethod("set_ssr_rough")]
        [Obsolete("SetSsrRough is deprecated. Use the SsReflectionsRoughness property instead.")]
        public void SetSsrRough(bool rough)
        {
            NativeCalls.godot_icall_1_16(method_bind_80, Object.GetPtr(this), rough);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_81 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_ssr_rough");

        [GodotMethod("is_ssr_rough")]
        [Obsolete("IsSsrRough is deprecated. Use the SsReflectionsRoughness property instead.")]
        public bool IsSsrRough()
        {
            return NativeCalls.godot_icall_0_7(method_bind_81, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_82 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ssao_enabled");

        [GodotMethod("set_ssao_enabled")]
        [Obsolete("SetSsaoEnabled is deprecated. Use the SsaoEnabled property instead.")]
        public void SetSsaoEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_82, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_83 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_ssao_enabled");

        [GodotMethod("is_ssao_enabled")]
        [Obsolete("IsSsaoEnabled is deprecated. Use the SsaoEnabled property instead.")]
        public bool IsSsaoEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_83, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_84 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ssao_radius");

        [GodotMethod("set_ssao_radius")]
        [Obsolete("SetSsaoRadius is deprecated. Use the SsaoRadius property instead.")]
        public void SetSsaoRadius(float radius)
        {
            NativeCalls.godot_icall_1_15(method_bind_84, Object.GetPtr(this), radius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_85 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ssao_radius");

        [GodotMethod("get_ssao_radius")]
        [Obsolete("GetSsaoRadius is deprecated. Use the SsaoRadius property instead.")]
        public float GetSsaoRadius()
        {
            return NativeCalls.godot_icall_0_14(method_bind_85, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_86 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ssao_intensity");

        [GodotMethod("set_ssao_intensity")]
        [Obsolete("SetSsaoIntensity is deprecated. Use the SsaoIntensity property instead.")]
        public void SetSsaoIntensity(float intensity)
        {
            NativeCalls.godot_icall_1_15(method_bind_86, Object.GetPtr(this), intensity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_87 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ssao_intensity");

        [GodotMethod("get_ssao_intensity")]
        [Obsolete("GetSsaoIntensity is deprecated. Use the SsaoIntensity property instead.")]
        public float GetSsaoIntensity()
        {
            return NativeCalls.godot_icall_0_14(method_bind_87, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_88 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ssao_radius2");

        [GodotMethod("set_ssao_radius2")]
        [Obsolete("SetSsaoRadius2 is deprecated. Use the SsaoRadius2 property instead.")]
        public void SetSsaoRadius2(float radius)
        {
            NativeCalls.godot_icall_1_15(method_bind_88, Object.GetPtr(this), radius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_89 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ssao_radius2");

        [GodotMethod("get_ssao_radius2")]
        [Obsolete("GetSsaoRadius2 is deprecated. Use the SsaoRadius2 property instead.")]
        public float GetSsaoRadius2()
        {
            return NativeCalls.godot_icall_0_14(method_bind_89, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_90 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ssao_intensity2");

        [GodotMethod("set_ssao_intensity2")]
        [Obsolete("SetSsaoIntensity2 is deprecated. Use the SsaoIntensity2 property instead.")]
        public void SetSsaoIntensity2(float intensity)
        {
            NativeCalls.godot_icall_1_15(method_bind_90, Object.GetPtr(this), intensity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_91 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ssao_intensity2");

        [GodotMethod("get_ssao_intensity2")]
        [Obsolete("GetSsaoIntensity2 is deprecated. Use the SsaoIntensity2 property instead.")]
        public float GetSsaoIntensity2()
        {
            return NativeCalls.godot_icall_0_14(method_bind_91, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_92 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ssao_bias");

        [GodotMethod("set_ssao_bias")]
        [Obsolete("SetSsaoBias is deprecated. Use the SsaoBias property instead.")]
        public void SetSsaoBias(float bias)
        {
            NativeCalls.godot_icall_1_15(method_bind_92, Object.GetPtr(this), bias);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_93 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ssao_bias");

        [GodotMethod("get_ssao_bias")]
        [Obsolete("GetSsaoBias is deprecated. Use the SsaoBias property instead.")]
        public float GetSsaoBias()
        {
            return NativeCalls.godot_icall_0_14(method_bind_93, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_94 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ssao_direct_light_affect");

        [GodotMethod("set_ssao_direct_light_affect")]
        [Obsolete("SetSsaoDirectLightAffect is deprecated. Use the SsaoLightAffect property instead.")]
        public void SetSsaoDirectLightAffect(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_94, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_95 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ssao_direct_light_affect");

        [GodotMethod("get_ssao_direct_light_affect")]
        [Obsolete("GetSsaoDirectLightAffect is deprecated. Use the SsaoLightAffect property instead.")]
        public float GetSsaoDirectLightAffect()
        {
            return NativeCalls.godot_icall_0_14(method_bind_95, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_96 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ssao_ao_channel_affect");

        [GodotMethod("set_ssao_ao_channel_affect")]
        [Obsolete("SetSsaoAoChannelAffect is deprecated. Use the SsaoAoChannelAffect property instead.")]
        public void SetSsaoAoChannelAffect(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_96, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_97 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ssao_ao_channel_affect");

        [GodotMethod("get_ssao_ao_channel_affect")]
        [Obsolete("GetSsaoAoChannelAffect is deprecated. Use the SsaoAoChannelAffect property instead.")]
        public float GetSsaoAoChannelAffect()
        {
            return NativeCalls.godot_icall_0_14(method_bind_97, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_98 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ssao_color");

        [GodotMethod("set_ssao_color")]
        [Obsolete("SetSsaoColor is deprecated. Use the SsaoColor property instead.")]
        public void SetSsaoColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_98, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_99 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ssao_color");

        [GodotMethod("get_ssao_color")]
        [Obsolete("GetSsaoColor is deprecated. Use the SsaoColor property instead.")]
        public Color GetSsaoColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_99, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_100 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ssao_blur");

        [GodotMethod("set_ssao_blur")]
        [Obsolete("SetSsaoBlur is deprecated. Use the SsaoBlur property instead.")]
        public void SetSsaoBlur(Environment.SSAOBlur mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_100, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_101 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ssao_blur");

        [GodotMethod("get_ssao_blur")]
        [Obsolete("GetSsaoBlur is deprecated. Use the SsaoBlur property instead.")]
        public Environment.SSAOBlur GetSsaoBlur()
        {
            return (Environment.SSAOBlur)NativeCalls.godot_icall_0_427(method_bind_101, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_102 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ssao_quality");

        [GodotMethod("set_ssao_quality")]
        [Obsolete("SetSsaoQuality is deprecated. Use the SsaoQuality property instead.")]
        public void SetSsaoQuality(Environment.SSAOQuality quality)
        {
            NativeCalls.godot_icall_1_4(method_bind_102, Object.GetPtr(this), (int)quality);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_103 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ssao_quality");

        [GodotMethod("get_ssao_quality")]
        [Obsolete("GetSsaoQuality is deprecated. Use the SsaoQuality property instead.")]
        public Environment.SSAOQuality GetSsaoQuality()
        {
            return (Environment.SSAOQuality)NativeCalls.godot_icall_0_428(method_bind_103, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_104 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ssao_edge_sharpness");

        [GodotMethod("set_ssao_edge_sharpness")]
        [Obsolete("SetSsaoEdgeSharpness is deprecated. Use the SsaoEdgeSharpness property instead.")]
        public void SetSsaoEdgeSharpness(float edgeSharpness)
        {
            NativeCalls.godot_icall_1_15(method_bind_104, Object.GetPtr(this), edgeSharpness);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_105 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ssao_edge_sharpness");

        [GodotMethod("get_ssao_edge_sharpness")]
        [Obsolete("GetSsaoEdgeSharpness is deprecated. Use the SsaoEdgeSharpness property instead.")]
        public float GetSsaoEdgeSharpness()
        {
            return NativeCalls.godot_icall_0_14(method_bind_105, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_106 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dof_blur_far_enabled");

        [GodotMethod("set_dof_blur_far_enabled")]
        [Obsolete("SetDofBlurFarEnabled is deprecated. Use the DofBlurFarEnabled property instead.")]
        public void SetDofBlurFarEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_106, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_107 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_dof_blur_far_enabled");

        [GodotMethod("is_dof_blur_far_enabled")]
        [Obsolete("IsDofBlurFarEnabled is deprecated. Use the DofBlurFarEnabled property instead.")]
        public bool IsDofBlurFarEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_107, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_108 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dof_blur_far_distance");

        [GodotMethod("set_dof_blur_far_distance")]
        [Obsolete("SetDofBlurFarDistance is deprecated. Use the DofBlurFarDistance property instead.")]
        public void SetDofBlurFarDistance(float intensity)
        {
            NativeCalls.godot_icall_1_15(method_bind_108, Object.GetPtr(this), intensity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_109 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_dof_blur_far_distance");

        [GodotMethod("get_dof_blur_far_distance")]
        [Obsolete("GetDofBlurFarDistance is deprecated. Use the DofBlurFarDistance property instead.")]
        public float GetDofBlurFarDistance()
        {
            return NativeCalls.godot_icall_0_14(method_bind_109, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_110 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dof_blur_far_transition");

        [GodotMethod("set_dof_blur_far_transition")]
        [Obsolete("SetDofBlurFarTransition is deprecated. Use the DofBlurFarTransition property instead.")]
        public void SetDofBlurFarTransition(float intensity)
        {
            NativeCalls.godot_icall_1_15(method_bind_110, Object.GetPtr(this), intensity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_111 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_dof_blur_far_transition");

        [GodotMethod("get_dof_blur_far_transition")]
        [Obsolete("GetDofBlurFarTransition is deprecated. Use the DofBlurFarTransition property instead.")]
        public float GetDofBlurFarTransition()
        {
            return NativeCalls.godot_icall_0_14(method_bind_111, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_112 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dof_blur_far_amount");

        [GodotMethod("set_dof_blur_far_amount")]
        [Obsolete("SetDofBlurFarAmount is deprecated. Use the DofBlurFarAmount property instead.")]
        public void SetDofBlurFarAmount(float intensity)
        {
            NativeCalls.godot_icall_1_15(method_bind_112, Object.GetPtr(this), intensity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_113 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_dof_blur_far_amount");

        [GodotMethod("get_dof_blur_far_amount")]
        [Obsolete("GetDofBlurFarAmount is deprecated. Use the DofBlurFarAmount property instead.")]
        public float GetDofBlurFarAmount()
        {
            return NativeCalls.godot_icall_0_14(method_bind_113, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_114 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dof_blur_far_quality");

        [GodotMethod("set_dof_blur_far_quality")]
        [Obsolete("SetDofBlurFarQuality is deprecated. Use the DofBlurFarQuality property instead.")]
        public void SetDofBlurFarQuality(Environment.DOFBlurQuality intensity)
        {
            NativeCalls.godot_icall_1_4(method_bind_114, Object.GetPtr(this), (int)intensity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_115 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_dof_blur_far_quality");

        [GodotMethod("get_dof_blur_far_quality")]
        [Obsolete("GetDofBlurFarQuality is deprecated. Use the DofBlurFarQuality property instead.")]
        public Environment.DOFBlurQuality GetDofBlurFarQuality()
        {
            return (Environment.DOFBlurQuality)NativeCalls.godot_icall_0_429(method_bind_115, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_116 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dof_blur_near_enabled");

        [GodotMethod("set_dof_blur_near_enabled")]
        [Obsolete("SetDofBlurNearEnabled is deprecated. Use the DofBlurNearEnabled property instead.")]
        public void SetDofBlurNearEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_116, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_117 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_dof_blur_near_enabled");

        [GodotMethod("is_dof_blur_near_enabled")]
        [Obsolete("IsDofBlurNearEnabled is deprecated. Use the DofBlurNearEnabled property instead.")]
        public bool IsDofBlurNearEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_117, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_118 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dof_blur_near_distance");

        [GodotMethod("set_dof_blur_near_distance")]
        [Obsolete("SetDofBlurNearDistance is deprecated. Use the DofBlurNearDistance property instead.")]
        public void SetDofBlurNearDistance(float intensity)
        {
            NativeCalls.godot_icall_1_15(method_bind_118, Object.GetPtr(this), intensity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_119 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_dof_blur_near_distance");

        [GodotMethod("get_dof_blur_near_distance")]
        [Obsolete("GetDofBlurNearDistance is deprecated. Use the DofBlurNearDistance property instead.")]
        public float GetDofBlurNearDistance()
        {
            return NativeCalls.godot_icall_0_14(method_bind_119, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_120 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dof_blur_near_transition");

        [GodotMethod("set_dof_blur_near_transition")]
        [Obsolete("SetDofBlurNearTransition is deprecated. Use the DofBlurNearTransition property instead.")]
        public void SetDofBlurNearTransition(float intensity)
        {
            NativeCalls.godot_icall_1_15(method_bind_120, Object.GetPtr(this), intensity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_121 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_dof_blur_near_transition");

        [GodotMethod("get_dof_blur_near_transition")]
        [Obsolete("GetDofBlurNearTransition is deprecated. Use the DofBlurNearTransition property instead.")]
        public float GetDofBlurNearTransition()
        {
            return NativeCalls.godot_icall_0_14(method_bind_121, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_122 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dof_blur_near_amount");

        [GodotMethod("set_dof_blur_near_amount")]
        [Obsolete("SetDofBlurNearAmount is deprecated. Use the DofBlurNearAmount property instead.")]
        public void SetDofBlurNearAmount(float intensity)
        {
            NativeCalls.godot_icall_1_15(method_bind_122, Object.GetPtr(this), intensity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_123 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_dof_blur_near_amount");

        [GodotMethod("get_dof_blur_near_amount")]
        [Obsolete("GetDofBlurNearAmount is deprecated. Use the DofBlurNearAmount property instead.")]
        public float GetDofBlurNearAmount()
        {
            return NativeCalls.godot_icall_0_14(method_bind_123, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_124 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dof_blur_near_quality");

        [GodotMethod("set_dof_blur_near_quality")]
        [Obsolete("SetDofBlurNearQuality is deprecated. Use the DofBlurNearQuality property instead.")]
        public void SetDofBlurNearQuality(Environment.DOFBlurQuality level)
        {
            NativeCalls.godot_icall_1_4(method_bind_124, Object.GetPtr(this), (int)level);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_125 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_dof_blur_near_quality");

        [GodotMethod("get_dof_blur_near_quality")]
        [Obsolete("GetDofBlurNearQuality is deprecated. Use the DofBlurNearQuality property instead.")]
        public Environment.DOFBlurQuality GetDofBlurNearQuality()
        {
            return (Environment.DOFBlurQuality)NativeCalls.godot_icall_0_429(method_bind_125, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_126 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_glow_enabled");

        [GodotMethod("set_glow_enabled")]
        [Obsolete("SetGlowEnabled is deprecated. Use the GlowEnabled property instead.")]
        public void SetGlowEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_126, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_127 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_glow_enabled");

        [GodotMethod("is_glow_enabled")]
        [Obsolete("IsGlowEnabled is deprecated. Use the GlowEnabled property instead.")]
        public bool IsGlowEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_127, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_128 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_glow_level");

        /// <summary>
        /// <para>Enables or disables the glow level at index <c>idx</c>. Each level relies on the previous level. This means that enabling higher glow levels will slow down the glow effect rendering, even if previous levels aren't enabled.</para>
        /// </summary>
        [GodotMethod("set_glow_level")]
        [Obsolete("SetGlowLevel is deprecated. Use the GlowLevels__7 property instead.")]
        public void SetGlowLevel(int idx, bool enabled)
        {
            NativeCalls.godot_icall_2_23(method_bind_128, Object.GetPtr(this), idx, enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_129 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_glow_level_enabled");

        /// <summary>
        /// <para>Returns <c>true</c> if the glow level <c>idx</c> is specified, <c>false</c> otherwise.</para>
        /// </summary>
        [GodotMethod("is_glow_level_enabled")]
        [Obsolete("IsGlowLevelEnabled is deprecated. Use the GlowLevels__7 property instead.")]
        public bool IsGlowLevelEnabled(int idx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_129, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_130 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_glow_intensity");

        [GodotMethod("set_glow_intensity")]
        [Obsolete("SetGlowIntensity is deprecated. Use the GlowIntensity property instead.")]
        public void SetGlowIntensity(float intensity)
        {
            NativeCalls.godot_icall_1_15(method_bind_130, Object.GetPtr(this), intensity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_131 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_glow_intensity");

        [GodotMethod("get_glow_intensity")]
        [Obsolete("GetGlowIntensity is deprecated. Use the GlowIntensity property instead.")]
        public float GetGlowIntensity()
        {
            return NativeCalls.godot_icall_0_14(method_bind_131, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_132 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_glow_strength");

        [GodotMethod("set_glow_strength")]
        [Obsolete("SetGlowStrength is deprecated. Use the GlowStrength property instead.")]
        public void SetGlowStrength(float strength)
        {
            NativeCalls.godot_icall_1_15(method_bind_132, Object.GetPtr(this), strength);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_133 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_glow_strength");

        [GodotMethod("get_glow_strength")]
        [Obsolete("GetGlowStrength is deprecated. Use the GlowStrength property instead.")]
        public float GetGlowStrength()
        {
            return NativeCalls.godot_icall_0_14(method_bind_133, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_134 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_glow_bloom");

        [GodotMethod("set_glow_bloom")]
        [Obsolete("SetGlowBloom is deprecated. Use the GlowBloom property instead.")]
        public void SetGlowBloom(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_134, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_135 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_glow_bloom");

        [GodotMethod("get_glow_bloom")]
        [Obsolete("GetGlowBloom is deprecated. Use the GlowBloom property instead.")]
        public float GetGlowBloom()
        {
            return NativeCalls.godot_icall_0_14(method_bind_135, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_136 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_glow_blend_mode");

        [GodotMethod("set_glow_blend_mode")]
        [Obsolete("SetGlowBlendMode is deprecated. Use the GlowBlendMode property instead.")]
        public void SetGlowBlendMode(Environment.GlowBlendModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_136, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_137 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_glow_blend_mode");

        [GodotMethod("get_glow_blend_mode")]
        [Obsolete("GetGlowBlendMode is deprecated. Use the GlowBlendMode property instead.")]
        public Environment.GlowBlendModeEnum GetGlowBlendMode()
        {
            return (Environment.GlowBlendModeEnum)NativeCalls.godot_icall_0_430(method_bind_137, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_138 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_glow_hdr_bleed_threshold");

        [GodotMethod("set_glow_hdr_bleed_threshold")]
        [Obsolete("SetGlowHdrBleedThreshold is deprecated. Use the GlowHdrThreshold property instead.")]
        public void SetGlowHdrBleedThreshold(float threshold)
        {
            NativeCalls.godot_icall_1_15(method_bind_138, Object.GetPtr(this), threshold);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_139 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_glow_hdr_bleed_threshold");

        [GodotMethod("get_glow_hdr_bleed_threshold")]
        [Obsolete("GetGlowHdrBleedThreshold is deprecated. Use the GlowHdrThreshold property instead.")]
        public float GetGlowHdrBleedThreshold()
        {
            return NativeCalls.godot_icall_0_14(method_bind_139, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_140 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_glow_hdr_luminance_cap");

        [GodotMethod("set_glow_hdr_luminance_cap")]
        [Obsolete("SetGlowHdrLuminanceCap is deprecated. Use the GlowHdrLuminanceCap property instead.")]
        public void SetGlowHdrLuminanceCap(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_140, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_141 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_glow_hdr_luminance_cap");

        [GodotMethod("get_glow_hdr_luminance_cap")]
        [Obsolete("GetGlowHdrLuminanceCap is deprecated. Use the GlowHdrLuminanceCap property instead.")]
        public float GetGlowHdrLuminanceCap()
        {
            return NativeCalls.godot_icall_0_14(method_bind_141, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_142 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_glow_hdr_bleed_scale");

        [GodotMethod("set_glow_hdr_bleed_scale")]
        [Obsolete("SetGlowHdrBleedScale is deprecated. Use the GlowHdrScale property instead.")]
        public void SetGlowHdrBleedScale(float scale)
        {
            NativeCalls.godot_icall_1_15(method_bind_142, Object.GetPtr(this), scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_143 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_glow_hdr_bleed_scale");

        [GodotMethod("get_glow_hdr_bleed_scale")]
        [Obsolete("GetGlowHdrBleedScale is deprecated. Use the GlowHdrScale property instead.")]
        public float GetGlowHdrBleedScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_143, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_144 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_glow_bicubic_upscale");

        [GodotMethod("set_glow_bicubic_upscale")]
        [Obsolete("SetGlowBicubicUpscale is deprecated. Use the GlowBicubicUpscale property instead.")]
        public void SetGlowBicubicUpscale(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_144, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_145 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_glow_bicubic_upscale_enabled");

        [GodotMethod("is_glow_bicubic_upscale_enabled")]
        [Obsolete("IsGlowBicubicUpscaleEnabled is deprecated. Use the GlowBicubicUpscale property instead.")]
        public bool IsGlowBicubicUpscaleEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_145, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_146 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_glow_high_quality");

        [GodotMethod("set_glow_high_quality")]
        [Obsolete("SetGlowHighQuality is deprecated. Use the GlowHighQuality property instead.")]
        public void SetGlowHighQuality(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_146, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_147 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_glow_high_quality_enabled");

        [GodotMethod("is_glow_high_quality_enabled")]
        [Obsolete("IsGlowHighQualityEnabled is deprecated. Use the GlowHighQuality property instead.")]
        public bool IsGlowHighQualityEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_147, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_148 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_adjustment_enable");

        [GodotMethod("set_adjustment_enable")]
        [Obsolete("SetAdjustmentEnable is deprecated. Use the AdjustmentEnabled property instead.")]
        public void SetAdjustmentEnable(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_148, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_149 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_adjustment_enabled");

        [GodotMethod("is_adjustment_enabled")]
        [Obsolete("IsAdjustmentEnabled is deprecated. Use the AdjustmentEnabled property instead.")]
        public bool IsAdjustmentEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_149, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_150 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_adjustment_brightness");

        [GodotMethod("set_adjustment_brightness")]
        [Obsolete("SetAdjustmentBrightness is deprecated. Use the AdjustmentBrightness property instead.")]
        public void SetAdjustmentBrightness(float brightness)
        {
            NativeCalls.godot_icall_1_15(method_bind_150, Object.GetPtr(this), brightness);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_151 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_adjustment_brightness");

        [GodotMethod("get_adjustment_brightness")]
        [Obsolete("GetAdjustmentBrightness is deprecated. Use the AdjustmentBrightness property instead.")]
        public float GetAdjustmentBrightness()
        {
            return NativeCalls.godot_icall_0_14(method_bind_151, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_152 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_adjustment_contrast");

        [GodotMethod("set_adjustment_contrast")]
        [Obsolete("SetAdjustmentContrast is deprecated. Use the AdjustmentContrast property instead.")]
        public void SetAdjustmentContrast(float contrast)
        {
            NativeCalls.godot_icall_1_15(method_bind_152, Object.GetPtr(this), contrast);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_153 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_adjustment_contrast");

        [GodotMethod("get_adjustment_contrast")]
        [Obsolete("GetAdjustmentContrast is deprecated. Use the AdjustmentContrast property instead.")]
        public float GetAdjustmentContrast()
        {
            return NativeCalls.godot_icall_0_14(method_bind_153, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_154 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_adjustment_saturation");

        [GodotMethod("set_adjustment_saturation")]
        [Obsolete("SetAdjustmentSaturation is deprecated. Use the AdjustmentSaturation property instead.")]
        public void SetAdjustmentSaturation(float saturation)
        {
            NativeCalls.godot_icall_1_15(method_bind_154, Object.GetPtr(this), saturation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_155 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_adjustment_saturation");

        [GodotMethod("get_adjustment_saturation")]
        [Obsolete("GetAdjustmentSaturation is deprecated. Use the AdjustmentSaturation property instead.")]
        public float GetAdjustmentSaturation()
        {
            return NativeCalls.godot_icall_0_14(method_bind_155, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_156 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_adjustment_color_correction");

        [GodotMethod("set_adjustment_color_correction")]
        [Obsolete("SetAdjustmentColorCorrection is deprecated. Use the AdjustmentColorCorrection property instead.")]
        public void SetAdjustmentColorCorrection(Texture colorCorrection)
        {
            NativeCalls.godot_icall_1_24(method_bind_156, Object.GetPtr(this), Object.GetPtr(colorCorrection));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_157 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_adjustment_color_correction");

        [GodotMethod("get_adjustment_color_correction")]
        [Obsolete("GetAdjustmentColorCorrection is deprecated. Use the AdjustmentColorCorrection property instead.")]
        public Texture GetAdjustmentColorCorrection()
        {
            return NativeCalls.godot_icall_0_161(method_bind_157, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
