using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A Viewport creates a different view into the screen, or a sub-view inside another viewport. Children 2D Nodes will display on it, and children Camera 3D nodes will render on it too.</para>
    /// <para>Optionally, a viewport can have its own 2D or 3D world, so they don't share what they draw with other viewports.</para>
    /// <para>If a viewport is a child of a <see cref="Godot.ViewportContainer"/>, the viewport will automatically take up the container's size, otherwise it must be set manually.</para>
    /// <para>Viewports can also choose to be audio listeners, so they generate positional audio depending on a 2D or 3D camera child of it.</para>
    /// <para>Also, viewports can be assigned to different screens in case the devices have multiple screens.</para>
    /// <para>Finally, viewports can also behave as render targets, in which case they will not be visible unless the associated texture is used to draw.</para>
    /// <para>Note: By default, a newly created Viewport in Godot 3.x will appear to be upside down. Enabling <see cref="Godot.Viewport.RenderTargetVFlip"/> will display the Viewport with the correct orientation.</para>
    /// </summary>
    public partial class Viewport : Node
    {
        public enum ClearMode
        {
            /// <summary>
            /// <para>Always clear the render target before drawing.</para>
            /// </summary>
            Always = 0,
            /// <summary>
            /// <para>Never clear the render target.</para>
            /// </summary>
            Never = 1,
            /// <summary>
            /// <para>Clear the render target next frame, then switch to <see cref="Godot.Viewport.ClearMode.Never"/>.</para>
            /// </summary>
            OnlyNextFrame = 2
        }

        public enum RenderInfo
        {
            /// <summary>
            /// <para>Amount of objects in frame.</para>
            /// </summary>
            ObjectsInFrame = 0,
            /// <summary>
            /// <para>Amount of vertices in frame.</para>
            /// </summary>
            VerticesInFrame = 1,
            /// <summary>
            /// <para>Amount of material changes in frame.</para>
            /// </summary>
            MaterialChangesInFrame = 2,
            /// <summary>
            /// <para>Amount of shader changes in frame.</para>
            /// </summary>
            ShaderChangesInFrame = 3,
            /// <summary>
            /// <para>Amount of surface changes in frame.</para>
            /// </summary>
            SurfaceChangesInFrame = 4,
            /// <summary>
            /// <para>Amount of draw calls in frame.</para>
            /// </summary>
            DrawCallsInFrame = 5,
            /// <summary>
            /// <para>Amount of items or joined items in frame.</para>
            /// </summary>
            Info2dItemsInFrame = 6,
            /// <summary>
            /// <para>Amount of draw calls in frame.</para>
            /// </summary>
            Info2dDrawCallsInFrame = 7,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.Viewport.RenderInfo"/> enum.</para>
            /// </summary>
            Max = 8
        }

        public enum UsageEnum
        {
            /// <summary>
            /// <para>Allocates all buffers needed for drawing 2D scenes. This takes less VRAM than the 3D usage modes. Note that 3D rendering effects such as glow and HDR are not available when using this mode.</para>
            /// </summary>
            Usage2d = 0,
            /// <summary>
            /// <para>Allocates buffers needed for 2D scenes without allocating a buffer for screen copy. Accordingly, you cannot read from the screen. Of the <see cref="Godot.Viewport.UsageEnum"/> types, this requires the least VRAM. Note that 3D rendering effects such as glow and HDR are not available when using this mode.</para>
            /// </summary>
            Usage2dNoSampling = 1,
            /// <summary>
            /// <para>Allocates full buffers for drawing 3D scenes and all 3D effects including buffers needed for 2D scenes and effects.</para>
            /// </summary>
            Usage3d = 2,
            /// <summary>
            /// <para>Allocates buffers needed for drawing 3D scenes. But does not allocate buffers needed for reading from the screen and post-processing effects. Saves some VRAM.</para>
            /// </summary>
            Usage3dNoEffects = 3
        }

        public enum DebugDrawEnum
        {
            /// <summary>
            /// <para>Objects are displayed normally.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>Objects are displayed without light information.</para>
            /// </summary>
            Unshaded = 1,
            /// <summary>
            /// <para>Objected are displayed semi-transparent with additive blending so you can see where they intersect.</para>
            /// </summary>
            Overdraw = 2,
            /// <summary>
            /// <para>Objects are displayed in wireframe style.</para>
            /// </summary>
            Wireframe = 3
        }

        public enum ShadowAtlasQuadrantSubdiv
        {
            /// <summary>
            /// <para>This quadrant will not be used.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>This quadrant will only be used by one shadow map.</para>
            /// </summary>
            Subdiv1 = 1,
            /// <summary>
            /// <para>This quadrant will be split in 4 and used by up to 4 shadow maps.</para>
            /// </summary>
            Subdiv4 = 2,
            /// <summary>
            /// <para>This quadrant will be split 16 ways and used by up to 16 shadow maps.</para>
            /// </summary>
            Subdiv16 = 3,
            /// <summary>
            /// <para>This quadrant will be split 64 ways and used by up to 64 shadow maps.</para>
            /// </summary>
            Subdiv64 = 4,
            /// <summary>
            /// <para>This quadrant will be split 256 ways and used by up to 256 shadow maps. Unless the <see cref="Godot.Viewport.ShadowAtlasSize"/> is very high, the shadows in this quadrant will be very low resolution.</para>
            /// </summary>
            Subdiv256 = 5,
            /// <summary>
            /// <para>This quadrant will be split 1024 ways and used by up to 1024 shadow maps. Unless the <see cref="Godot.Viewport.ShadowAtlasSize"/> is very high, the shadows in this quadrant will be very low resolution.</para>
            /// </summary>
            Subdiv1024 = 6,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.Viewport.ShadowAtlasQuadrantSubdiv"/> enum.</para>
            /// </summary>
            Max = 7
        }

        public enum UpdateMode
        {
            /// <summary>
            /// <para>Do not update the render target.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>Update the render target once, then switch to <see cref="Godot.Viewport.UpdateMode.Disabled"/>.</para>
            /// </summary>
            Once = 1,
            /// <summary>
            /// <para>Update the render target only when it is visible. This is the default value.</para>
            /// </summary>
            WhenVisible = 2,
            /// <summary>
            /// <para>Always update the render target.</para>
            /// </summary>
            Always = 3
        }

        public enum MSAA
        {
            /// <summary>
            /// <para>Multisample anti-aliasing mode disabled. This is the default value.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>Use 2x Multisample Antialiasing.</para>
            /// </summary>
            Msaa2x = 1,
            /// <summary>
            /// <para>Use 4x Multisample Antialiasing.</para>
            /// </summary>
            Msaa4x = 2,
            /// <summary>
            /// <para>Use 8x Multisample Antialiasing. Likely unsupported on low-end and older hardware.</para>
            /// </summary>
            Msaa8x = 3,
            /// <summary>
            /// <para>Use 16x Multisample Antialiasing. Likely unsupported on medium and low-end hardware.</para>
            /// </summary>
            Msaa16x = 4
        }

        /// <summary>
        /// <para>If <c>true</c>, the viewport will be used in AR/VR process.</para>
        /// </summary>
        public bool Arvr
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return UseArvr();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseArvr(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The width and height of viewport. Must be set to a value greater than or equal to 2 pixels on both dimensions. Otherwise, nothing will be displayed.</para>
        /// </summary>
        public Vector2 Size
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the size override affects stretch as well.</para>
        /// </summary>
        public bool SizeOverrideStretch
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsSizeOverrideStretchEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSizeOverrideStretch(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the viewport will use a unique copy of the <see cref="Godot.World"/> defined in <see cref="Godot.Viewport.World"/>.</para>
        /// </summary>
        public bool OwnWorld
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUsingOwnWorld();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseOwnWorld(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The custom <see cref="Godot.World"/> which can be used as 3D environment source.</para>
        /// </summary>
        public World World
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetWorld();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetWorld(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The custom <see cref="Godot.World2D"/> which can be used as 2D environment source.</para>
        /// </summary>
        public World2D World2d
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetWorld2d();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetWorld2d(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the viewport should render its background as transparent.</para>
        /// </summary>
        public bool TransparentBg
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return HasTransparentBackground();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTransparentBackground(value);
            }
#pragma warning restore CS0618
        }

        public bool HandleInputLocally
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsHandlingInputLocally();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHandleInputLocally(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The multisample anti-aliasing mode. A higher number results in smoother edges at the cost of significantly worse performance. A value of 4 is best unless targeting very high-end systems.</para>
        /// </summary>
        public Viewport.MSAA Msaa
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMsaa();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMsaa(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Enables fast approximate antialiasing. FXAA is a popular screen-space antialiasing method, which is fast but will make the image look blurry, especially at lower resolutions. It can still work relatively well at large resolutions such as 1440p and 4K. Some of the lost sharpness can be recovered by enabling contrast-adaptive sharpening (see <see cref="Godot.Viewport.SharpenIntensity"/>).</para>
        /// </summary>
        public bool Fxaa
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUseFxaa();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseFxaa(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, uses a fast post-processing filter to make banding significantly less visible in 3D. 2D rendering is not affected by debanding unless the <see cref="Godot.Environment.BackgroundMode"/> is <see cref="Godot.Environment.BGMode.Canvas"/>. In this case, <see cref="Godot.Viewport.Usage"/> must also be set to <see cref="Godot.Viewport.UsageEnum.Usage3d"/>. See also .</para>
        /// <para>In some cases, debanding may introduce a slightly noticeable dithering pattern. It's recommended to enable debanding only when actually needed since the dithering pattern will make lossless-compressed screenshots larger.</para>
        /// <para>Note: Only available on the GLES3 backend. <see cref="Godot.Viewport.Hdr"/> must also be <c>true</c> for debanding to be effective.</para>
        /// </summary>
        public bool Debanding
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUseDebanding();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseDebanding(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If set to a value greater than <c>0.0</c>, contrast-adaptive sharpening will be applied to the 3D viewport. This has a low performance cost and can be used to recover some of the sharpness lost from using FXAA. Values around <c>0.5</c> generally give the best results. See also <see cref="Godot.Viewport.Fxaa"/>.</para>
        /// </summary>
        public float SharpenIntensity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSharpenIntensity();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSharpenIntensity(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the viewport rendering will receive benefits from High Dynamic Range algorithm. High Dynamic Range allows the viewport to receive values that are outside the 0-1 range. In Godot, HDR uses half floating-point precision (16-bit) by default. To use full floating-point precision (32-bit), enable <see cref="Godot.Viewport.Use32BpcDepth"/>.</para>
        /// <para>Note: Requires <see cref="Godot.Viewport.Usage"/> to be set to <see cref="Godot.Viewport.UsageEnum.Usage3d"/> or <see cref="Godot.Viewport.UsageEnum.Usage3dNoEffects"/>, since HDR is not supported for 2D.</para>
        /// <para>Note: Only available on the GLES3 backend.</para>
        /// </summary>
        public bool Hdr
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHdr();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHdr(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, allocates the viewport's framebuffer with full floating-point precision (32-bit) instead of half floating-point precision (16-bit). Only effective when <see cref="Godot.Viewport.Hdr"/> is also enabled.</para>
        /// <para>Note: Enabling this setting does not improve rendering quality. Using full floating-point precision is slower, and is generally only needed for advanced shaders that require a high level of precision. To reduce banding, enable <see cref="Godot.Viewport.Debanding"/> instead.</para>
        /// <para>Note: Only available on the GLES3 backend.</para>
        /// </summary>
        public bool Use32BpcDepth
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUse32BpcDepth();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUse32BpcDepth(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the viewport will disable 3D rendering. To actually disable allocation of 3D buffers, set <see cref="Godot.Viewport.Usage"/> instead.</para>
        /// </summary>
        public bool Disable3d
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return Is3dDisabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDisable3d(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the result after 3D rendering will not have a linear to sRGB color conversion applied. This is important when the viewport is used as a render target where the result is used as a texture on a 3D object rendered in another viewport. It is also important if the viewport is used to create data that is not color based (noise, heightmaps, pickmaps, etc.). Do not enable this when the viewport is used as a texture on a 2D object or if the viewport is your final output. For the GLES2 driver this will convert the sRGB output to linear, this should only be used for VR plugins that require input in linear color space!</para>
        /// </summary>
        public bool Keep3dLinear
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetKeep3dLinear();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetKeep3dLinear(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The viewport's rendering mode. This controls which buffers are allocated for the viewport (2D only, or 2D + 3D). 2D-only options can reduce memory usage and improve performance slightly, especially on low-end devices.</para>
        /// <para>Note: If set to <see cref="Godot.Viewport.UsageEnum.Usage2d"/> or <see cref="Godot.Viewport.UsageEnum.Usage2dNoSampling"/>, <see cref="Godot.Viewport.Hdr"/> will have no effect when enabled since HDR is not supported for 2D.</para>
        /// </summary>
        public Viewport.UsageEnum Usage
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUsage();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUsage(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, renders the Viewport directly to the screen instead of to the root viewport. Only available in GLES2. This is a low-level optimization and should not be used in most cases. If used, reading from the Viewport or from <c>SCREEN_TEXTURE</c> becomes unavailable. For more information see <see cref="Godot.VisualServer.ViewportSetRenderDirectToScreen"/>.</para>
        /// </summary>
        public bool RenderDirectToScreen
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUsingRenderDirectToScreen();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseRenderDirectToScreen(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The overlay mode for test rendered geometry in debug purposes.</para>
        /// </summary>
        public Viewport.DebugDrawEnum DebugDraw
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDebugDraw();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDebugDraw(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the result of rendering will be flipped vertically. Since Viewports in Godot 3.x render upside-down, it's recommended to set this to <c>true</c> in most situations.</para>
        /// </summary>
        public bool RenderTargetVFlip
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVflip();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVflip(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The clear mode when viewport used as a render target.</para>
        /// <para>Note: This property is intended for 2D usage.</para>
        /// </summary>
        public Viewport.ClearMode RenderTargetClearMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetClearMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetClearMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The update mode when viewport used as a render target.</para>
        /// </summary>
        public Viewport.UpdateMode RenderTargetUpdateMode
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
        /// <para>If <c>true</c>, the viewport will process 2D audio streams.</para>
        /// </summary>
        public bool AudioListenerEnable2d
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsAudioListener2d();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAsAudioListener2d(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the viewport will process 3D audio streams.</para>
        /// </summary>
        public bool AudioListenerEnable3d
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsAudioListener();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAsAudioListener(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the objects rendered by viewport become subjects of mouse picking process.</para>
        /// </summary>
        public bool PhysicsObjectPicking
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPhysicsObjectPicking();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPhysicsObjectPicking(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the viewport will not receive input events.</para>
        /// </summary>
        public bool GuiDisableInput
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputDisabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDisableInput(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the GUI controls on the viewport will lay pixel perfectly.</para>
        /// </summary>
        public bool GuiSnapControlsToPixels
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsSnapControlsToPixelsEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSnapControlsToPixels(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The shadow atlas' resolution (used for omni and spot lights). The value will be rounded up to the nearest power of 2.</para>
        /// <para>Note: If this is set to <c>0</c>, both point and directional shadows won't be visible. Since user-created viewports default to a value of <c>0</c>, this value must be set above <c>0</c> manually (typically at least <c>256</c>).</para>
        /// </summary>
        public int ShadowAtlasSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShadowAtlasSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShadowAtlasSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The subdivision amount of the first quadrant on the shadow atlas.</para>
        /// </summary>
        public Viewport.ShadowAtlasQuadrantSubdiv ShadowAtlasQuad0
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShadowAtlasQuadrantSubdiv(0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShadowAtlasQuadrantSubdiv(0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The subdivision amount of the second quadrant on the shadow atlas.</para>
        /// </summary>
        public Viewport.ShadowAtlasQuadrantSubdiv ShadowAtlasQuad1
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShadowAtlasQuadrantSubdiv(1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShadowAtlasQuadrantSubdiv(1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The subdivision amount of the third quadrant on the shadow atlas.</para>
        /// </summary>
        public Viewport.ShadowAtlasQuadrantSubdiv ShadowAtlasQuad2
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShadowAtlasQuadrantSubdiv(2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShadowAtlasQuadrantSubdiv(2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The subdivision amount of the fourth quadrant on the shadow atlas.</para>
        /// </summary>
        public Viewport.ShadowAtlasQuadrantSubdiv ShadowAtlasQuad3
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShadowAtlasQuadrantSubdiv(3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShadowAtlasQuadrantSubdiv(3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The canvas transform of the viewport, useful for changing the on-screen positions of all child <see cref="Godot.CanvasItem"/>s. This is relative to the global canvas transform of the viewport.</para>
        /// </summary>
        public Transform2D CanvasTransform
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCanvasTransform();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCanvasTransform(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The global canvas transform of the viewport. The canvas transform is relative to this.</para>
        /// </summary>
        public Transform2D GlobalCanvasTransform
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGlobalCanvasTransform();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlobalCanvasTransform(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Viewport";

        public Viewport() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Viewport_Ctor(this);
        }

        internal Viewport(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_arvr");

        [GodotMethod("set_use_arvr")]
        [Obsolete("SetUseArvr is deprecated. Use the Arvr property instead.")]
        public void SetUseArvr(bool use)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), use);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "use_arvr");

        [GodotMethod("use_arvr")]
        [Obsolete("UseArvr is deprecated. Use the Arvr property instead.")]
        public bool UseArvr()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_size");

        [GodotMethod("set_size")]
        [Obsolete("SetSize is deprecated. Use the Size property instead.")]
        public void SetSize(Vector2 size)
        {
            NativeCalls.godot_icall_1_57(method_bind_2, Object.GetPtr(this), ref size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_size");

        [GodotMethod("get_size")]
        [Obsolete("GetSize is deprecated. Use the Size property instead.")]
        public Vector2 GetSize()
        {
            NativeCalls.godot_icall_0_18(method_bind_3, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_world_2d");

        [GodotMethod("set_world_2d")]
        [Obsolete("SetWorld2d is deprecated. Use the World2d property instead.")]
        public void SetWorld2d(World2D world2d)
        {
            NativeCalls.godot_icall_1_24(method_bind_4, Object.GetPtr(this), Object.GetPtr(world2d));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_world_2d");

        [GodotMethod("get_world_2d")]
        [Obsolete("GetWorld2d is deprecated. Use the World2d property instead.")]
        public World2D GetWorld2d()
        {
            return NativeCalls.godot_icall_0_279(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "find_world_2d");

        /// <summary>
        /// <para>Returns the first valid <see cref="Godot.World2D"/> for this viewport, searching the <see cref="Godot.Viewport.World2d"/> property of itself and any Viewport ancestor.</para>
        /// </summary>
        [GodotMethod("find_world_2d")]
        public World2D FindWorld2d()
        {
            return NativeCalls.godot_icall_0_279(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_world");

        [GodotMethod("set_world")]
        [Obsolete("SetWorld is deprecated. Use the World property instead.")]
        public void SetWorld(World world)
        {
            NativeCalls.godot_icall_1_24(method_bind_7, Object.GetPtr(this), Object.GetPtr(world));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_world");

        [GodotMethod("get_world")]
        [Obsolete("GetWorld is deprecated. Use the World property instead.")]
        public World GetWorld()
        {
            return NativeCalls.godot_icall_0_865(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "find_world");

        /// <summary>
        /// <para>Returns the first valid <see cref="Godot.World"/> for this viewport, searching the <see cref="Godot.Viewport.World"/> property of itself and any Viewport ancestor.</para>
        /// </summary>
        [GodotMethod("find_world")]
        public World FindWorld()
        {
            return NativeCalls.godot_icall_0_865(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_canvas_transform");

        [GodotMethod("set_canvas_transform")]
        [Obsolete("SetCanvasTransform is deprecated. Use the CanvasTransform property instead.")]
        public void SetCanvasTransform(Transform2D xform)
        {
            NativeCalls.godot_icall_1_220(method_bind_10, Object.GetPtr(this), ref xform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_canvas_transform");

        [GodotMethod("get_canvas_transform")]
        [Obsolete("GetCanvasTransform is deprecated. Use the CanvasTransform property instead.")]
        public Transform2D GetCanvasTransform()
        {
            NativeCalls.godot_icall_0_221(method_bind_11, Object.GetPtr(this), out Transform2D argRet); return (Transform2D)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_global_canvas_transform");

        [GodotMethod("set_global_canvas_transform")]
        [Obsolete("SetGlobalCanvasTransform is deprecated. Use the GlobalCanvasTransform property instead.")]
        public void SetGlobalCanvasTransform(Transform2D xform)
        {
            NativeCalls.godot_icall_1_220(method_bind_12, Object.GetPtr(this), ref xform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_global_canvas_transform");

        [GodotMethod("get_global_canvas_transform")]
        [Obsolete("GetGlobalCanvasTransform is deprecated. Use the GlobalCanvasTransform property instead.")]
        public Transform2D GetGlobalCanvasTransform()
        {
            NativeCalls.godot_icall_0_221(method_bind_13, Object.GetPtr(this), out Transform2D argRet); return (Transform2D)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_final_transform");

        /// <summary>
        /// <para>Returns the total transform of the viewport.</para>
        /// </summary>
        [GodotMethod("get_final_transform")]
        public Transform2D GetFinalTransform()
        {
            NativeCalls.godot_icall_0_221(method_bind_14, Object.GetPtr(this), out Transform2D argRet); return (Transform2D)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_visible_rect");

        /// <summary>
        /// <para>Returns the visible rectangle in global screen coordinates.</para>
        /// </summary>
        [GodotMethod("get_visible_rect")]
        public Rect2 GetVisibleRect()
        {
            NativeCalls.godot_icall_0_163(method_bind_15, Object.GetPtr(this), out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_transparent_background");

        [GodotMethod("set_transparent_background")]
        [Obsolete("SetTransparentBackground is deprecated. Use the TransparentBg property instead.")]
        public void SetTransparentBackground(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_16, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_transparent_background");

        [GodotMethod("has_transparent_background")]
        [Obsolete("HasTransparentBackground is deprecated. Use the TransparentBg property instead.")]
        public bool HasTransparentBackground()
        {
            return NativeCalls.godot_icall_0_7(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_size_override");

        /// <summary>
        /// <para>Sets the size override of the viewport. If the <c>enable</c> parameter is <c>true</c> the override is used, otherwise it uses the default size. If the size parameter is <c>(-1, -1)</c>, it won't update the size.</para>
        /// </summary>
        /// <param name="size">If the parameter is null, then the default value is new Vector2(-1, -1)</param>
        /// <param name="margin">If the parameter is null, then the default value is new Vector2(0, 0)</param>
        [GodotMethod("set_size_override")]
        public void SetSizeOverride(bool enable, Nullable<Vector2> size = null, Nullable<Vector2> margin = null)
        {
            Vector2 size_in = size.HasValue ? size.Value : new Vector2(-1, -1);
            Vector2 margin_in = margin.HasValue ? margin.Value : new Vector2(0, 0);
            NativeCalls.godot_icall_3_1009(method_bind_18, Object.GetPtr(this), enable, ref size_in, ref margin_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_size_override");

        /// <summary>
        /// <para>Returns the size override set with <see cref="Godot.Viewport.SetSizeOverride"/>.</para>
        /// </summary>
        [GodotMethod("get_size_override")]
        public Vector2 GetSizeOverride()
        {
            NativeCalls.godot_icall_0_18(method_bind_19, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_size_override_enabled");

        /// <summary>
        /// <para>Returns <c>true</c> if the size override is enabled. See <see cref="Godot.Viewport.SetSizeOverride"/>.</para>
        /// </summary>
        [GodotMethod("is_size_override_enabled")]
        public bool IsSizeOverrideEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_size_override_stretch");

        [GodotMethod("set_size_override_stretch")]
        [Obsolete("SetSizeOverrideStretch is deprecated. Use the SizeOverrideStretch property instead.")]
        public void SetSizeOverrideStretch(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_21, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_size_override_stretch_enabled");

        [GodotMethod("is_size_override_stretch_enabled")]
        [Obsolete("IsSizeOverrideStretchEnabled is deprecated. Use the SizeOverrideStretch property instead.")]
        public bool IsSizeOverrideStretchEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_22, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_vflip");

        [GodotMethod("set_vflip")]
        [Obsolete("SetVflip is deprecated. Use the RenderTargetVFlip property instead.")]
        public void SetVflip(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_23, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_vflip");

        [GodotMethod("get_vflip")]
        [Obsolete("GetVflip is deprecated. Use the RenderTargetVFlip property instead.")]
        public bool GetVflip()
        {
            return NativeCalls.godot_icall_0_7(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_clear_mode");

        [GodotMethod("set_clear_mode")]
        [Obsolete("SetClearMode is deprecated. Use the RenderTargetClearMode property instead.")]
        public void SetClearMode(Viewport.ClearMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_25, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_clear_mode");

        [GodotMethod("get_clear_mode")]
        [Obsolete("GetClearMode is deprecated. Use the RenderTargetClearMode property instead.")]
        public Viewport.ClearMode GetClearMode()
        {
            return (Viewport.ClearMode)NativeCalls.godot_icall_0_1010(method_bind_26, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_update_mode");

        [GodotMethod("set_update_mode")]
        [Obsolete("SetUpdateMode is deprecated. Use the RenderTargetUpdateMode property instead.")]
        public void SetUpdateMode(Viewport.UpdateMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_27, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_update_mode");

        [GodotMethod("get_update_mode")]
        [Obsolete("GetUpdateMode is deprecated. Use the RenderTargetUpdateMode property instead.")]
        public Viewport.UpdateMode GetUpdateMode()
        {
            return (Viewport.UpdateMode)NativeCalls.godot_icall_0_1011(method_bind_28, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_msaa");

        [GodotMethod("set_msaa")]
        [Obsolete("SetMsaa is deprecated. Use the Msaa property instead.")]
        public void SetMsaa(Viewport.MSAA msaa)
        {
            NativeCalls.godot_icall_1_4(method_bind_29, Object.GetPtr(this), (int)msaa);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_msaa");

        [GodotMethod("get_msaa")]
        [Obsolete("GetMsaa is deprecated. Use the Msaa property instead.")]
        public Viewport.MSAA GetMsaa()
        {
            return (Viewport.MSAA)NativeCalls.godot_icall_0_1012(method_bind_30, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_fxaa");

        [GodotMethod("set_use_fxaa")]
        [Obsolete("SetUseFxaa is deprecated. Use the Fxaa property instead.")]
        public void SetUseFxaa(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_31, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_use_fxaa");

        [GodotMethod("get_use_fxaa")]
        [Obsolete("GetUseFxaa is deprecated. Use the Fxaa property instead.")]
        public bool GetUseFxaa()
        {
            return NativeCalls.godot_icall_0_7(method_bind_32, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_debanding");

        [GodotMethod("set_use_debanding")]
        [Obsolete("SetUseDebanding is deprecated. Use the Debanding property instead.")]
        public void SetUseDebanding(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_33, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_use_debanding");

        [GodotMethod("get_use_debanding")]
        [Obsolete("GetUseDebanding is deprecated. Use the Debanding property instead.")]
        public bool GetUseDebanding()
        {
            return NativeCalls.godot_icall_0_7(method_bind_34, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sharpen_intensity");

        [GodotMethod("set_sharpen_intensity")]
        [Obsolete("SetSharpenIntensity is deprecated. Use the SharpenIntensity property instead.")]
        public void SetSharpenIntensity(float intensity)
        {
            NativeCalls.godot_icall_1_15(method_bind_35, Object.GetPtr(this), intensity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sharpen_intensity");

        [GodotMethod("get_sharpen_intensity")]
        [Obsolete("GetSharpenIntensity is deprecated. Use the SharpenIntensity property instead.")]
        public float GetSharpenIntensity()
        {
            return NativeCalls.godot_icall_0_14(method_bind_36, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_hdr");

        [GodotMethod("set_hdr")]
        [Obsolete("SetHdr is deprecated. Use the Hdr property instead.")]
        public void SetHdr(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_37, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_hdr");

        [GodotMethod("get_hdr")]
        [Obsolete("GetHdr is deprecated. Use the Hdr property instead.")]
        public bool GetHdr()
        {
            return NativeCalls.godot_icall_0_7(method_bind_38, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_32_bpc_depth");

        [GodotMethod("set_use_32_bpc_depth")]
        [Obsolete("SetUse32BpcDepth is deprecated. Use the Use32BpcDepth property instead.")]
        public void SetUse32BpcDepth(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_39, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_use_32_bpc_depth");

        [GodotMethod("get_use_32_bpc_depth")]
        [Obsolete("GetUse32BpcDepth is deprecated. Use the Use32BpcDepth property instead.")]
        public bool GetUse32BpcDepth()
        {
            return NativeCalls.godot_icall_0_7(method_bind_40, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_usage");

        [GodotMethod("set_usage")]
        [Obsolete("SetUsage is deprecated. Use the Usage property instead.")]
        public void SetUsage(Viewport.UsageEnum usage)
        {
            NativeCalls.godot_icall_1_4(method_bind_41, Object.GetPtr(this), (int)usage);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_usage");

        [GodotMethod("get_usage")]
        [Obsolete("GetUsage is deprecated. Use the Usage property instead.")]
        public Viewport.UsageEnum GetUsage()
        {
            return (Viewport.UsageEnum)NativeCalls.godot_icall_0_1013(method_bind_42, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_debug_draw");

        [GodotMethod("set_debug_draw")]
        [Obsolete("SetDebugDraw is deprecated. Use the DebugDraw property instead.")]
        public void SetDebugDraw(Viewport.DebugDrawEnum debugDraw)
        {
            NativeCalls.godot_icall_1_4(method_bind_43, Object.GetPtr(this), (int)debugDraw);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_debug_draw");

        [GodotMethod("get_debug_draw")]
        [Obsolete("GetDebugDraw is deprecated. Use the DebugDraw property instead.")]
        public Viewport.DebugDrawEnum GetDebugDraw()
        {
            return (Viewport.DebugDrawEnum)NativeCalls.godot_icall_0_1014(method_bind_44, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_render_info");

        /// <summary>
        /// <para>Returns information about the viewport from the rendering pipeline.</para>
        /// </summary>
        [GodotMethod("get_render_info")]
        public int GetRenderInfo(Viewport.RenderInfo info)
        {
            return NativeCalls.godot_icall_1_11(method_bind_45, Object.GetPtr(this), (int)info);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture");

        /// <summary>
        /// <para>Returns the viewport's texture.</para>
        /// <para>Note: Due to the way OpenGL works, the resulting <see cref="Godot.ViewportTexture"/> is flipped vertically. You can use <see cref="Godot.Image.FlipY"/> on the result of <see cref="Godot.Texture.GetData"/> to flip it back, for example:</para>
        /// <para><code>
        /// var img = get_viewport().get_texture().get_data()
        /// img.flip_y()
        /// </code></para>
        /// </summary>
        [GodotMethod("get_texture")]
        public ViewportTexture GetTexture()
        {
            return NativeCalls.godot_icall_0_1015(method_bind_46, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_physics_object_picking");

        [GodotMethod("set_physics_object_picking")]
        [Obsolete("SetPhysicsObjectPicking is deprecated. Use the PhysicsObjectPicking property instead.")]
        public void SetPhysicsObjectPicking(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_47, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_physics_object_picking");

        [GodotMethod("get_physics_object_picking")]
        [Obsolete("GetPhysicsObjectPicking is deprecated. Use the PhysicsObjectPicking property instead.")]
        public bool GetPhysicsObjectPicking()
        {
            return NativeCalls.godot_icall_0_7(method_bind_48, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_viewport_rid");

        /// <summary>
        /// <para>Returns the viewport's RID from the <see cref="Godot.VisualServer"/>.</para>
        /// </summary>
        [GodotMethod("get_viewport_rid")]
        public RID GetViewportRid()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_49, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "input");

        [GodotMethod("input")]
        public void Input(InputEvent localEvent)
        {
            NativeCalls.godot_icall_1_24(method_bind_50, Object.GetPtr(this), Object.GetPtr(localEvent));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "unhandled_input");

        [GodotMethod("unhandled_input")]
        public void UnhandledInput(InputEvent localEvent)
        {
            NativeCalls.godot_icall_1_24(method_bind_51, Object.GetPtr(this), Object.GetPtr(localEvent));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "update_worlds");

        /// <summary>
        /// <para>Forces update of the 2D and 3D worlds.</para>
        /// </summary>
        [GodotMethod("update_worlds")]
        public void UpdateWorlds()
        {
            NativeCalls.godot_icall_0_3(method_bind_52, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_53 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_own_world");

        [GodotMethod("set_use_own_world")]
        [Obsolete("SetUseOwnWorld is deprecated. Use the OwnWorld property instead.")]
        public void SetUseOwnWorld(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_53, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_54 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_using_own_world");

        [GodotMethod("is_using_own_world")]
        [Obsolete("IsUsingOwnWorld is deprecated. Use the OwnWorld property instead.")]
        public bool IsUsingOwnWorld()
        {
            return NativeCalls.godot_icall_0_7(method_bind_54, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_55 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_camera");

        /// <summary>
        /// <para>Returns the active 3D camera.</para>
        /// </summary>
        [GodotMethod("get_camera")]
        public Camera GetCamera()
        {
            return NativeCalls.godot_icall_0_1016(method_bind_55, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_56 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_as_audio_listener");

        [GodotMethod("set_as_audio_listener")]
        [Obsolete("SetAsAudioListener is deprecated. Use the AudioListenerEnable3d property instead.")]
        public void SetAsAudioListener(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_56, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_57 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_audio_listener");

        [GodotMethod("is_audio_listener")]
        [Obsolete("IsAudioListener is deprecated. Use the AudioListenerEnable3d property instead.")]
        public bool IsAudioListener()
        {
            return NativeCalls.godot_icall_0_7(method_bind_57, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_58 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_as_audio_listener_2d");

        [GodotMethod("set_as_audio_listener_2d")]
        [Obsolete("SetAsAudioListener2d is deprecated. Use the AudioListenerEnable2d property instead.")]
        public void SetAsAudioListener2d(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_58, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_59 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_audio_listener_2d");

        [GodotMethod("is_audio_listener_2d")]
        [Obsolete("IsAudioListener2d is deprecated. Use the AudioListenerEnable2d property instead.")]
        public bool IsAudioListener2d()
        {
            return NativeCalls.godot_icall_0_7(method_bind_59, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_60 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_attach_to_screen_rect");

        /// <summary>
        /// <para>Attaches this <see cref="Godot.Viewport"/> to the root <see cref="Godot.Viewport"/> with the specified rectangle. This bypasses the need for another node to display this <see cref="Godot.Viewport"/> but makes you responsible for updating the position of this <see cref="Godot.Viewport"/> manually.</para>
        /// </summary>
        [GodotMethod("set_attach_to_screen_rect")]
        public void SetAttachToScreenRect(Rect2 rect)
        {
            NativeCalls.godot_icall_1_162(method_bind_60, Object.GetPtr(this), ref rect);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_61 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_render_direct_to_screen");

        [GodotMethod("set_use_render_direct_to_screen")]
        [Obsolete("SetUseRenderDirectToScreen is deprecated. Use the RenderDirectToScreen property instead.")]
        public void SetUseRenderDirectToScreen(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_61, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_62 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_using_render_direct_to_screen");

        [GodotMethod("is_using_render_direct_to_screen")]
        [Obsolete("IsUsingRenderDirectToScreen is deprecated. Use the RenderDirectToScreen property instead.")]
        public bool IsUsingRenderDirectToScreen()
        {
            return NativeCalls.godot_icall_0_7(method_bind_62, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_63 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mouse_position");

        /// <summary>
        /// <para>Returns the mouse's position in this <see cref="Godot.Viewport"/> using the coordinate system of this <see cref="Godot.Viewport"/>.</para>
        /// </summary>
        [GodotMethod("get_mouse_position")]
        public Vector2 GetMousePosition()
        {
            NativeCalls.godot_icall_0_18(method_bind_63, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_64 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "warp_mouse");

        /// <summary>
        /// <para>Moves the mouse pointer to the specified position in this <see cref="Godot.Viewport"/> using the coordinate system of this <see cref="Godot.Viewport"/>.</para>
        /// </summary>
        [GodotMethod("warp_mouse")]
        public void WarpMouse(Vector2 toPosition)
        {
            NativeCalls.godot_icall_1_57(method_bind_64, Object.GetPtr(this), ref toPosition);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_65 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gui_has_modal_stack");

        /// <summary>
        /// <para>Returns <c>true</c> if there are visible modals on-screen.</para>
        /// </summary>
        [GodotMethod("gui_has_modal_stack")]
        public bool GuiHasModalStack()
        {
            return NativeCalls.godot_icall_0_7(method_bind_65, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_66 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gui_get_drag_data");

        /// <summary>
        /// <para>Returns the drag data from the GUI, that was previously returned by <see cref="Godot.Control.GetDragData"/>.</para>
        /// </summary>
        [GodotMethod("gui_get_drag_data")]
        public object GuiGetDragData()
        {
            return NativeCalls.godot_icall_0_547(method_bind_66, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_67 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gui_is_dragging");

        /// <summary>
        /// <para>Returns <c>true</c> if the viewport is currently performing a drag operation.</para>
        /// <para>Alternative to <see cref="Godot.Node.NotificationDragBegin"/> and <see cref="Godot.Node.NotificationDragEnd"/> when you prefer polling the value.</para>
        /// </summary>
        [GodotMethod("gui_is_dragging")]
        public bool GuiIsDragging()
        {
            return NativeCalls.godot_icall_0_7(method_bind_67, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_68 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gui_is_drag_successful");

        /// <summary>
        /// <para>Returns <c>true</c> if the drag operation is successful.</para>
        /// </summary>
        [GodotMethod("gui_is_drag_successful")]
        public bool GuiIsDragSuccessful()
        {
            return NativeCalls.godot_icall_0_7(method_bind_68, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_69 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_modal_stack_top");

        /// <summary>
        /// <para>Returns the topmost modal in the stack.</para>
        /// </summary>
        [GodotMethod("get_modal_stack_top")]
        public Control GetModalStackTop()
        {
            return NativeCalls.godot_icall_0_314(method_bind_69, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_70 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_disable_input");

        [GodotMethod("set_disable_input")]
        [Obsolete("SetDisableInput is deprecated. Use the GuiDisableInput property instead.")]
        public void SetDisableInput(bool disable)
        {
            NativeCalls.godot_icall_1_16(method_bind_70, Object.GetPtr(this), disable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_71 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_input_disabled");

        [GodotMethod("is_input_disabled")]
        [Obsolete("IsInputDisabled is deprecated. Use the GuiDisableInput property instead.")]
        public bool IsInputDisabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_71, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_72 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_disable_3d");

        [GodotMethod("set_disable_3d")]
        [Obsolete("SetDisable3d is deprecated. Use the Disable3d property instead.")]
        public void SetDisable3d(bool disable)
        {
            NativeCalls.godot_icall_1_16(method_bind_72, Object.GetPtr(this), disable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_73 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_3d_disabled");

        [GodotMethod("is_3d_disabled")]
        [Obsolete("Is3dDisabled is deprecated. Use the Disable3d property instead.")]
        public bool Is3dDisabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_73, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_74 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_keep_3d_linear");

        [GodotMethod("set_keep_3d_linear")]
        [Obsolete("SetKeep3dLinear is deprecated. Use the Keep3dLinear property instead.")]
        public void SetKeep3dLinear(bool keep3dLinear)
        {
            NativeCalls.godot_icall_1_16(method_bind_74, Object.GetPtr(this), keep3dLinear);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_75 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_keep_3d_linear");

        [GodotMethod("get_keep_3d_linear")]
        [Obsolete("GetKeep3dLinear is deprecated. Use the Keep3dLinear property instead.")]
        public bool GetKeep3dLinear()
        {
            return NativeCalls.godot_icall_0_7(method_bind_75, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_76 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shadow_atlas_size");

        [GodotMethod("set_shadow_atlas_size")]
        [Obsolete("SetShadowAtlasSize is deprecated. Use the ShadowAtlasSize property instead.")]
        public void SetShadowAtlasSize(int size)
        {
            NativeCalls.godot_icall_1_4(method_bind_76, Object.GetPtr(this), size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_77 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shadow_atlas_size");

        [GodotMethod("get_shadow_atlas_size")]
        [Obsolete("GetShadowAtlasSize is deprecated. Use the ShadowAtlasSize property instead.")]
        public int GetShadowAtlasSize()
        {
            return NativeCalls.godot_icall_0_5(method_bind_77, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_78 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_snap_controls_to_pixels");

        [GodotMethod("set_snap_controls_to_pixels")]
        [Obsolete("SetSnapControlsToPixels is deprecated. Use the GuiSnapControlsToPixels property instead.")]
        public void SetSnapControlsToPixels(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_78, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_79 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_snap_controls_to_pixels_enabled");

        [GodotMethod("is_snap_controls_to_pixels_enabled")]
        [Obsolete("IsSnapControlsToPixelsEnabled is deprecated. Use the GuiSnapControlsToPixels property instead.")]
        public bool IsSnapControlsToPixelsEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_79, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_80 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shadow_atlas_quadrant_subdiv");

        /// <summary>
        /// <para>Sets the number of subdivisions to use in the specified quadrant. A higher number of subdivisions allows you to have more shadows in the scene at once, but reduces the quality of the shadows. A good practice is to have quadrants with a varying number of subdivisions and to have as few subdivisions as possible.</para>
        /// </summary>
        [GodotMethod("set_shadow_atlas_quadrant_subdiv")]
        [Obsolete("SetShadowAtlasQuadrantSubdiv is deprecated. Use the ShadowAtlasQuad3 property instead.")]
        public void SetShadowAtlasQuadrantSubdiv(int quadrant, Viewport.ShadowAtlasQuadrantSubdiv subdiv)
        {
            NativeCalls.godot_icall_2_65(method_bind_80, Object.GetPtr(this), quadrant, (int)subdiv);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_81 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shadow_atlas_quadrant_subdiv");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Viewport.ShadowAtlasQuadrantSubdiv"/> of the specified quadrant.</para>
        /// </summary>
        [GodotMethod("get_shadow_atlas_quadrant_subdiv")]
        [Obsolete("GetShadowAtlasQuadrantSubdiv is deprecated. Use the ShadowAtlasQuad3 property instead.")]
        public Viewport.ShadowAtlasQuadrantSubdiv GetShadowAtlasQuadrantSubdiv(int quadrant)
        {
            return (Viewport.ShadowAtlasQuadrantSubdiv)NativeCalls.godot_icall_1_1017(method_bind_81, Object.GetPtr(this), quadrant);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_82 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_input_as_handled");

        /// <summary>
        /// <para>Stops the input from propagating further down the <see cref="Godot.SceneTree"/>.</para>
        /// </summary>
        [GodotMethod("set_input_as_handled")]
        public void SetInputAsHandled()
        {
            NativeCalls.godot_icall_0_3(method_bind_82, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_83 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_input_handled");

        [GodotMethod("is_input_handled")]
        public bool IsInputHandled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_83, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_84 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_handle_input_locally");

        [GodotMethod("set_handle_input_locally")]
        [Obsolete("SetHandleInputLocally is deprecated. Use the HandleInputLocally property instead.")]
        public void SetHandleInputLocally(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_84, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_85 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_handling_input_locally");

        [GodotMethod("is_handling_input_locally")]
        [Obsolete("IsHandlingInputLocally is deprecated. Use the HandleInputLocally property instead.")]
        public bool IsHandlingInputLocally()
        {
            return NativeCalls.godot_icall_0_7(method_bind_85, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
