using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Server for anything visible. The visual server is the API backend for everything visible. The whole scene system mounts on it to display.</para>
    /// <para>The visual server is completely opaque, the internals are entirely implementation specific and cannot be accessed.</para>
    /// <para>The visual server can be used to bypass the scene system entirely.</para>
    /// <para>Resources are created using the <c>*_create</c> functions.</para>
    /// <para>All objects are drawn to a viewport. You can use the <see cref="Godot.Viewport"/> attached to the <see cref="Godot.SceneTree"/> or you can create one yourself with <see cref="Godot.VisualServer.ViewportCreate"/>. When using a custom scenario or canvas, the scenario or canvas needs to be attached to the viewport using <see cref="Godot.VisualServer.ViewportSetScenario"/> or <see cref="Godot.VisualServer.ViewportAttachCanvas"/>.</para>
    /// <para>In 3D, all visual objects must be associated with a scenario. The scenario is a visual representation of the world. If accessing the visual server from a running game, the scenario can be accessed from the scene tree from any <see cref="Godot.Spatial"/> node with <see cref="Godot.Spatial.GetWorld"/>. Otherwise, a scenario can be created with <see cref="Godot.VisualServer.ScenarioCreate"/>.</para>
    /// <para>Similarly, in 2D, a canvas is needed to draw all canvas items.</para>
    /// <para>In 3D, all visible objects are comprised of a resource and an instance. A resource can be a mesh, a particle system, a light, or any other 3D object. In order to be visible resources must be attached to an instance using <see cref="Godot.VisualServer.InstanceSetBase"/>. The instance must also be attached to the scenario using <see cref="Godot.VisualServer.InstanceSetScenario"/> in order to be visible.</para>
    /// <para>In 2D, all visible objects are some form of canvas item. In order to be visible, a canvas item needs to be the child of a canvas attached to a viewport, or it needs to be the child of another canvas item that is eventually attached to the canvas.</para>
    /// </summary>
    public static partial class VisualServer
    {
        /// <summary>
        /// <para>Marks an error that shows that the index array is empty.</para>
        /// </summary>
        public const int NoIndexArray = -1;
        /// <summary>
        /// <para>Number of weights/bones per vertex.</para>
        /// </summary>
        public const int ArrayWeightsSize = 4;
        /// <summary>
        /// <para>The minimum Z-layer for canvas items.</para>
        /// </summary>
        public const int CanvasItemZMin = -4096;
        /// <summary>
        /// <para>The maximum Z-layer for canvas items.</para>
        /// </summary>
        public const int CanvasItemZMax = 4096;
        /// <summary>
        /// <para>Max number of glow levels that can be used with glow post-process effect.</para>
        /// </summary>
        public const int MaxGlowLevels = 7;
        /// <summary>
        /// <para>Unused enum in Godot 3.x.</para>
        /// </summary>
        public const int MaxCursors = 8;
        /// <summary>
        /// <para>The minimum renderpriority of all materials.</para>
        /// </summary>
        public const int MaterialRenderPriorityMin = -128;
        /// <summary>
        /// <para>The maximum renderpriority of all materials.</para>
        /// </summary>
        public const int MaterialRenderPriorityMax = 127;

        public enum ReflectionProbeUpdateMode
        {
            /// <summary>
            /// <para>Reflection probe will update reflections once and then stop.</para>
            /// </summary>
            Once = 0,
            /// <summary>
            /// <para>Reflection probe will update each frame. This mode is necessary to capture moving objects.</para>
            /// </summary>
            Always = 1
        }

        public enum LightDirectionalShadowDepthRangeMode
        {
            /// <summary>
            /// <para>Keeps shadows stable as camera moves but has lower effective resolution.</para>
            /// </summary>
            Stable = 0,
            /// <summary>
            /// <para>Optimize use of shadow maps, increasing the effective resolution. But may result in shadows moving or flickering slightly.</para>
            /// </summary>
            Optimized = 1
        }

        public enum BlendShapeMode
        {
            /// <summary>
            /// <para>Blend shapes are normalized.</para>
            /// </summary>
            Normalized = 0,
            /// <summary>
            /// <para>Blend shapes are relative to base weight.</para>
            /// </summary>
            Relative = 1
        }

        public enum PrimitiveType
        {
            /// <summary>
            /// <para>Primitive to draw consists of points.</para>
            /// </summary>
            Points = 0,
            /// <summary>
            /// <para>Primitive to draw consists of lines.</para>
            /// </summary>
            Lines = 1,
            /// <summary>
            /// <para>Primitive to draw consists of a line strip from start to end.</para>
            /// </summary>
            LineStrip = 2,
            /// <summary>
            /// <para>Primitive to draw consists of a line loop (a line strip with a line between the last and the first vertex).</para>
            /// </summary>
            LineLoop = 3,
            /// <summary>
            /// <para>Primitive to draw consists of triangles.</para>
            /// </summary>
            Triangles = 4,
            /// <summary>
            /// <para>Primitive to draw consists of a triangle strip (the last 3 vertices are always combined to make a triangle).</para>
            /// </summary>
            TriangleStrip = 5,
            /// <summary>
            /// <para>Primitive to draw consists of a triangle strip (the last 2 vertices are always combined with the first to make a triangle).</para>
            /// </summary>
            TriangleFan = 6,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.VisualServer.PrimitiveType"/> enum.</para>
            /// </summary>
            Max = 7
        }

        public enum TextureType
        {
            /// <summary>
            /// <para>Normal texture with 2 dimensions, width and height.</para>
            /// </summary>
            Type2d = 0,
            /// <summary>
            /// <para>Texture made up of six faces, can be looked up with a <c>vec3</c> in shader.</para>
            /// </summary>
            Cubemap = 2,
            /// <summary>
            /// <para>An array of 2-dimensional textures.</para>
            /// </summary>
            Type2dArray = 3,
            /// <summary>
            /// <para>A 3-dimensional texture with width, height, and depth.</para>
            /// </summary>
            Type3d = 4
        }

        public enum ChangedPriority
        {
            /// <summary>
            /// <para>Used to query for any changes that request a redraw, whatever the priority.</para>
            /// </summary>
            Any = 0,
            /// <summary>
            /// <para>Registered changes which have low priority can be optionally prevented from causing editor redraws. Examples might include dynamic shaders (typically using the <c>TIME</c> built-in).</para>
            /// </summary>
            Low = 1,
            /// <summary>
            /// <para>Registered changes which can cause a redraw default to high priority.</para>
            /// </summary>
            High = 2
        }

        public enum EnvironmentSSAOQuality
        {
            /// <summary>
            /// <para>Lowest quality of screen space ambient occlusion.</para>
            /// </summary>
            Low = 0,
            /// <summary>
            /// <para>Medium quality screen space ambient occlusion.</para>
            /// </summary>
            Medium = 1,
            /// <summary>
            /// <para>Highest quality screen space ambient occlusion.</para>
            /// </summary>
            High = 2
        }

        public enum EnvironmentDOFBlurQuality
        {
            /// <summary>
            /// <para>Use lowest blur quality. Fastest, but may look bad.</para>
            /// </summary>
            Low = 0,
            /// <summary>
            /// <para>Use medium blur quality.</para>
            /// </summary>
            Medium = 1,
            /// <summary>
            /// <para>Used highest blur quality. Looks the best, but is the slowest.</para>
            /// </summary>
            High = 2
        }

        public enum RenderInfo
        {
            /// <summary>
            /// <para>The amount of objects in the frame.</para>
            /// </summary>
            ObjectsInFrame = 0,
            /// <summary>
            /// <para>The amount of vertices in the frame.</para>
            /// </summary>
            VerticesInFrame = 1,
            /// <summary>
            /// <para>The amount of modified materials in the frame.</para>
            /// </summary>
            MaterialChangesInFrame = 2,
            /// <summary>
            /// <para>The amount of shader rebinds in the frame.</para>
            /// </summary>
            ShaderChangesInFrame = 3,
            /// <summary>
            /// <para>The peak amount of shaders that have been under compilation in the frame.</para>
            /// <para>This is useful to know when asynchronous shader compilation has finished for the current shaders on screen.</para>
            /// <para>Note: For complete certainty, only assume there are no outstanding compilations when this value is zero for at least two frames in a row.</para>
            /// <para>Unimplemented in the GLES2 rendering backend, always returns 0.</para>
            /// </summary>
            ShaderCompilesInFrame = 4,
            /// <summary>
            /// <para>The amount of surface changes in the frame.</para>
            /// </summary>
            SurfaceChangesInFrame = 5,
            /// <summary>
            /// <para>The amount of draw calls in frame.</para>
            /// </summary>
            DrawCallsInFrame = 6,
            /// <summary>
            /// <para>The amount of 2d items in the frame.</para>
            /// </summary>
            Info2dItemsInFrame = 7,
            /// <summary>
            /// <para>The amount of 2d draw calls in frame.</para>
            /// </summary>
            Info2dDrawCallsInFrame = 8,
            /// <summary>
            /// <para>Unimplemented in the GLES2 and GLES3 rendering backends, always returns 0.</para>
            /// </summary>
            UsageVideoMemTotal = 9,
            /// <summary>
            /// <para>The amount of video memory used, i.e. texture and vertex memory combined.</para>
            /// </summary>
            VideoMemUsed = 10,
            /// <summary>
            /// <para>The amount of texture memory used.</para>
            /// </summary>
            TextureMemUsed = 11,
            /// <summary>
            /// <para>The amount of vertex memory used.</para>
            /// </summary>
            VertexMemUsed = 12
        }

        public enum NinePatchAxisMode
        {
            /// <summary>
            /// <para>The nine patch gets stretched where needed.</para>
            /// </summary>
            Stretch = 0,
            /// <summary>
            /// <para>The nine patch gets filled with tiles where needed.</para>
            /// </summary>
            Tile = 1,
            /// <summary>
            /// <para>The nine patch gets filled with tiles where needed and stretches them a bit if needed.</para>
            /// </summary>
            TileFit = 2
        }

        public enum ViewportRenderInfo
        {
            /// <summary>
            /// <para>Number of objects drawn in a single frame.</para>
            /// </summary>
            ObjectsInFrame = 0,
            /// <summary>
            /// <para>Number of vertices drawn in a single frame.</para>
            /// </summary>
            VerticesInFrame = 1,
            /// <summary>
            /// <para>Number of material changes during this frame.</para>
            /// </summary>
            MaterialChangesInFrame = 2,
            /// <summary>
            /// <para>Number of shader changes during this frame.</para>
            /// </summary>
            ShaderChangesInFrame = 3,
            /// <summary>
            /// <para>Number of surface changes during this frame.</para>
            /// </summary>
            SurfaceChangesInFrame = 4,
            /// <summary>
            /// <para>Number of draw calls during this frame.</para>
            /// </summary>
            DrawCallsInFrame = 5,
            /// <summary>
            /// <para>Number of 2d items drawn this frame.</para>
            /// </summary>
            Info2dItemsInFrame = 6,
            /// <summary>
            /// <para>Number of 2d draw calls during this frame.</para>
            /// </summary>
            Info2dDrawCallsInFrame = 7,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.VisualServer.ViewportRenderInfo"/> enum.</para>
            /// </summary>
            Max = 8
        }

        public enum ViewportClearMode
        {
            /// <summary>
            /// <para>The viewport is always cleared before drawing.</para>
            /// </summary>
            Always = 0,
            /// <summary>
            /// <para>The viewport is never cleared before drawing.</para>
            /// </summary>
            Never = 1,
            /// <summary>
            /// <para>The viewport is cleared once, then the clear mode is set to <see cref="Godot.VisualServer.ViewportClearMode.Never"/>.</para>
            /// </summary>
            OnlyNextFrame = 2
        }

        public enum LightOmniShadowDetail
        {
            /// <summary>
            /// <para>Use more detail vertically when computing shadow map.</para>
            /// </summary>
            Vertical = 0,
            /// <summary>
            /// <para>Use more detail horizontally when computing shadow map.</para>
            /// </summary>
            Horizontal = 1
        }

        public enum ShaderMode
        {
            /// <summary>
            /// <para>Shader is a 3D shader.</para>
            /// </summary>
            Spatial = 0,
            /// <summary>
            /// <para>Shader is a 2D shader.</para>
            /// </summary>
            CanvasItem = 1,
            /// <summary>
            /// <para>Shader is a particle shader.</para>
            /// </summary>
            Particles = 2,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.VisualServer.ShaderMode"/> enum.</para>
            /// </summary>
            Max = 3
        }

        public enum MultimeshTransformFormat
        {
            /// <summary>
            /// <para>Use <see cref="Godot.Transform2D"/> to store MultiMesh transform.</para>
            /// </summary>
            Transform2d = 0,
            /// <summary>
            /// <para>Use <see cref="Godot.Transform"/> to store MultiMesh transform.</para>
            /// </summary>
            Transform3d = 1
        }

        public enum ShadowCastingSetting
        {
            /// <summary>
            /// <para>Disable shadows from this instance.</para>
            /// </summary>
            Off = 0,
            /// <summary>
            /// <para>Cast shadows from this instance.</para>
            /// </summary>
            On = 1,
            /// <summary>
            /// <para>Disable backface culling when rendering the shadow of the object. This is slightly slower but may result in more correct shadows.</para>
            /// </summary>
            DoubleSided = 2,
            /// <summary>
            /// <para>Only render the shadows from the object. The object itself will not be drawn.</para>
            /// </summary>
            ShadowsOnly = 3
        }

        public enum ViewportDebugDraw
        {
            /// <summary>
            /// <para>Debug draw is disabled. Default setting.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>Debug draw sets objects to unshaded.</para>
            /// </summary>
            Unshaded = 1,
            /// <summary>
            /// <para>Overwrites clear color to <c>(0,0,0,0)</c>.</para>
            /// </summary>
            Overdraw = 2,
            /// <summary>
            /// <para>Debug draw draws objects in wireframe.</para>
            /// </summary>
            Wireframe = 3
        }

        public enum ViewportUsage
        {
            /// <summary>
            /// <para>The Viewport does not render 3D but samples.</para>
            /// </summary>
            Usage2d = 0,
            /// <summary>
            /// <para>The Viewport does not render 3D and does not sample.</para>
            /// </summary>
            Usage2dNoSampling = 1,
            /// <summary>
            /// <para>The Viewport renders 3D with effects.</para>
            /// </summary>
            Usage3d = 2,
            /// <summary>
            /// <para>The Viewport renders 3D but without effects.</para>
            /// </summary>
            Usage3dNoEffects = 3
        }

        public enum EnvironmentBG
        {
            /// <summary>
            /// <para>Use the clear color as background.</para>
            /// </summary>
            ClearColor = 0,
            /// <summary>
            /// <para>Use a specified color as the background.</para>
            /// </summary>
            Color = 1,
            /// <summary>
            /// <para>Use a sky resource for the background.</para>
            /// </summary>
            Sky = 2,
            /// <summary>
            /// <para>Use a custom color for background, but use a sky for shading and reflections.</para>
            /// </summary>
            ColorSky = 3,
            /// <summary>
            /// <para>Use a specified canvas layer as the background. This can be useful for instantiating a 2D scene in a 3D world.</para>
            /// </summary>
            Canvas = 4,
            /// <summary>
            /// <para>Do not clear the background, use whatever was rendered last frame as the background.</para>
            /// </summary>
            Keep = 5,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.VisualServer.EnvironmentBG"/> enum.</para>
            /// </summary>
            Max = 7
        }

        public enum MultimeshCustomDataFormat
        {
            /// <summary>
            /// <para>MultiMesh does not use custom data.</para>
            /// </summary>
            None = 0,
            /// <summary>
            /// <para>MultiMesh custom data uses 8 bits per component. This packs the 4-component custom data into a single float.</para>
            /// </summary>
            Data8bit = 1,
            /// <summary>
            /// <para>MultiMesh custom data uses a float per component.</para>
            /// </summary>
            Float = 2
        }

        public enum LightOmniShadowMode
        {
            /// <summary>
            /// <para>Use a dual paraboloid shadow map for omni lights.</para>
            /// </summary>
            DualParaboloid = 0,
            /// <summary>
            /// <para>Use a cubemap shadow map for omni lights. Slower but better quality than dual paraboloid.</para>
            /// </summary>
            Cube = 1
        }

        public enum TextureFlags
        {
            /// <summary>
            /// <para>Generates mipmaps, which are smaller versions of the same texture to use when zoomed out, keeping the aspect ratio.</para>
            /// </summary>
            Mipmaps = 1,
            /// <summary>
            /// <para>Repeats the texture (instead of clamp to edge).</para>
            /// </summary>
            Repeat = 2,
            /// <summary>
            /// <para>Uses a magnifying filter, to enable smooth zooming in of the texture.</para>
            /// </summary>
            Filter = 4,
            /// <summary>
            /// <para>Uses anisotropic mipmap filtering. Generates smaller versions of the same texture with different aspect ratios.</para>
            /// <para>This results in better-looking textures when viewed from oblique angles.</para>
            /// </summary>
            AnisotropicFilter = 8,
            /// <summary>
            /// <para>Converts the texture to the sRGB color space.</para>
            /// </summary>
            ConvertToLinear = 16,
            /// <summary>
            /// <para>Repeats the texture with alternate sections mirrored.</para>
            /// </summary>
            MirroredRepeat = 32,
            /// <summary>
            /// <para>Texture is a video surface.</para>
            /// </summary>
            UsedForStreaming = 2048,
            /// <summary>
            /// <para>Default flags. <see cref="Godot.VisualServer.TextureFlags.Mipmaps"/>, <see cref="Godot.VisualServer.TextureFlags.Repeat"/> and <see cref="Godot.VisualServer.TextureFlags.Filter"/> are enabled.</para>
            /// </summary>
            Default = 7
        }

        public enum Features
        {
            /// <summary>
            /// <para>Hardware supports shaders. This enum is currently unused in Godot 3.x.</para>
            /// </summary>
            Shaders = 0,
            /// <summary>
            /// <para>Hardware supports multithreading. This enum is currently unused in Godot 3.x.</para>
            /// </summary>
            Multithreaded = 1
        }

        public enum InstanceType
        {
            /// <summary>
            /// <para>The instance does not have a type.</para>
            /// </summary>
            None = 0,
            /// <summary>
            /// <para>The instance is a mesh.</para>
            /// </summary>
            Mesh = 1,
            /// <summary>
            /// <para>The instance is a multimesh.</para>
            /// </summary>
            Multimesh = 2,
            /// <summary>
            /// <para>The instance is an immediate geometry.</para>
            /// </summary>
            Immediate = 3,
            /// <summary>
            /// <para>The instance is a particle emitter.</para>
            /// </summary>
            Particles = 4,
            /// <summary>
            /// <para>The instance is a light.</para>
            /// </summary>
            Light = 5,
            /// <summary>
            /// <para>The instance is a reflection probe.</para>
            /// </summary>
            ReflectionProbe = 6,
            /// <summary>
            /// <para>The instance is a GI probe.</para>
            /// </summary>
            GiProbe = 7,
            /// <summary>
            /// <para>The instance is a lightmap capture.</para>
            /// </summary>
            LightmapCapture = 8,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.VisualServer.InstanceType"/> enum.</para>
            /// </summary>
            Max = 9,
            /// <summary>
            /// <para>A combination of the flags of geometry instances (mesh, multimesh, immediate and particles).</para>
            /// </summary>
            GeometryMask = 30
        }

        public enum EnvironmentSSAOBlur
        {
            /// <summary>
            /// <para>Disables the blur set for SSAO. Will make SSAO look noisier.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>Perform a 1x1 blur on the SSAO output.</para>
            /// </summary>
            Blur1x1 = 1,
            /// <summary>
            /// <para>Performs a 2x2 blur on the SSAO output.</para>
            /// </summary>
            Blur2x2 = 2,
            /// <summary>
            /// <para>Performs a 3x3 blur on the SSAO output. Use this for smoothest SSAO.</para>
            /// </summary>
            Blur3x3 = 3
        }

        public enum EnvironmentToneMapper
        {
            /// <summary>
            /// <para>Output color as they came in. This can cause bright lighting to look blown out, with noticeable clipping in the output colors.</para>
            /// </summary>
            Linear = 0,
            /// <summary>
            /// <para>Use the Reinhard tonemapper. Performs a variation on rendered pixels' colors by this formula: <c>color = color / (1 + color)</c>. This avoids clipping bright highlights, but the resulting image can look a bit dull.</para>
            /// </summary>
            Reinhard = 1,
            /// <summary>
            /// <para>Use the filmic tonemapper. This avoids clipping bright highlights, with a resulting image that usually looks more vivid than <see cref="Godot.VisualServer.EnvironmentToneMapper.Reinhard"/>.</para>
            /// </summary>
            Filmic = 2,
            /// <summary>
            /// <para>Use the legacy Godot version of the Academy Color Encoding System tonemapper. Unlike <see cref="Godot.VisualServer.EnvironmentToneMapper.AcesFitted"/>, this version of ACES does not handle bright lighting in a physically accurate way. ACES typically has a more contrasted output compared to <see cref="Godot.VisualServer.EnvironmentToneMapper.Reinhard"/> and <see cref="Godot.VisualServer.EnvironmentToneMapper.Filmic"/>.</para>
            /// <para>Note: This tonemapping operator will be removed in Godot 4.0 in favor of the more accurate <see cref="Godot.VisualServer.EnvironmentToneMapper.AcesFitted"/>.</para>
            /// </summary>
            Aces = 3,
            /// <summary>
            /// <para>Use the Academy Color Encoding System tonemapper. ACES is slightly more expensive than other options, but it handles bright lighting in a more realistic fashion by desaturating it as it becomes brighter. ACES typically has a more contrasted output compared to <see cref="Godot.VisualServer.EnvironmentToneMapper.Reinhard"/> and <see cref="Godot.VisualServer.EnvironmentToneMapper.Filmic"/>.</para>
            /// </summary>
            AcesFitted = 4
        }

        public enum EnvironmentGlowBlendMode
        {
            /// <summary>
            /// <para>Add the effect of the glow on top of the scene.</para>
            /// </summary>
            Additive = 0,
            /// <summary>
            /// <para>Blends the glow effect with the screen. Does not get as bright as additive.</para>
            /// </summary>
            Screen = 1,
            /// <summary>
            /// <para>Produces a subtle color disturbance around objects.</para>
            /// </summary>
            Softlight = 2,
            /// <summary>
            /// <para>Shows the glow effect by itself without the underlying scene.</para>
            /// </summary>
            Replace = 3
        }

        public enum MultimeshColorFormat
        {
            /// <summary>
            /// <para>MultiMesh does not use per-instance color.</para>
            /// </summary>
            None = 0,
            /// <summary>
            /// <para>MultiMesh color uses 8 bits per component. This packs the color into a single float.</para>
            /// </summary>
            Color8bit = 1,
            /// <summary>
            /// <para>MultiMesh color uses a float per channel.</para>
            /// </summary>
            Float = 2
        }

        public enum CanvasLightShadowFilter
        {
            /// <summary>
            /// <para>Do not apply a filter to canvas light shadows.</para>
            /// </summary>
            None = 0,
            /// <summary>
            /// <para>Use PCF3 filtering to filter canvas light shadows.</para>
            /// </summary>
            Pcf3 = 1,
            /// <summary>
            /// <para>Use PCF5 filtering to filter canvas light shadows.</para>
            /// </summary>
            Pcf5 = 2,
            /// <summary>
            /// <para>Use PCF7 filtering to filter canvas light shadows.</para>
            /// </summary>
            Pcf7 = 3,
            /// <summary>
            /// <para>Use PCF9 filtering to filter canvas light shadows.</para>
            /// </summary>
            Pcf9 = 4,
            /// <summary>
            /// <para>Use PCF13 filtering to filter canvas light shadows.</para>
            /// </summary>
            Pcf13 = 5
        }

        public enum ScenarioDebugMode
        {
            /// <summary>
            /// <para>Do not use a debug mode.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>Draw all objects as wireframe models.</para>
            /// </summary>
            Wireframe = 1,
            /// <summary>
            /// <para>Draw all objects in a way that displays how much overdraw is occurring. Overdraw occurs when a section of pixels is drawn and shaded and then another object covers it up. To optimize a scene, you should reduce overdraw.</para>
            /// </summary>
            Overdraw = 2,
            /// <summary>
            /// <para>Draw all objects without shading. Equivalent to setting all objects shaders to <c>unshaded</c>.</para>
            /// </summary>
            Shadeless = 3
        }

        public enum ViewportUpdateMode
        {
            /// <summary>
            /// <para>Do not update the viewport.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>Update the viewport once then set to disabled.</para>
            /// </summary>
            Once = 1,
            /// <summary>
            /// <para>Update the viewport whenever it is visible.</para>
            /// </summary>
            WhenVisible = 2,
            /// <summary>
            /// <para>Always update the viewport.</para>
            /// </summary>
            Always = 3
        }

        public enum LightBakeMode
        {
            Disabled = 0,
            Indirect = 1,
            All = 2
        }

        public enum ArrayFormat
        {
            /// <summary>
            /// <para>Flag used to mark a vertex array.</para>
            /// </summary>
            FormatVertex = 1,
            /// <summary>
            /// <para>Flag used to mark a normal array.</para>
            /// </summary>
            FormatNormal = 2,
            /// <summary>
            /// <para>Flag used to mark a tangent array.</para>
            /// </summary>
            FormatTangent = 4,
            /// <summary>
            /// <para>Flag used to mark a color array.</para>
            /// </summary>
            FormatColor = 8,
            /// <summary>
            /// <para>Flag used to mark an UV coordinates array.</para>
            /// </summary>
            FormatTexUv = 16,
            /// <summary>
            /// <para>Flag used to mark an UV coordinates array for the second UV coordinates.</para>
            /// </summary>
            FormatTexUv2 = 32,
            /// <summary>
            /// <para>Flag used to mark a bone information array.</para>
            /// </summary>
            FormatBones = 64,
            /// <summary>
            /// <para>Flag used to mark a weights array.</para>
            /// </summary>
            FormatWeights = 128,
            /// <summary>
            /// <para>Flag used to mark an index array.</para>
            /// </summary>
            FormatIndex = 256,
            /// <summary>
            /// <para>Flag used to mark a compressed (half float) vertex array.</para>
            /// </summary>
            CompressVertex = 512,
            /// <summary>
            /// <para>Flag used to mark a compressed (half float) normal array.</para>
            /// </summary>
            CompressNormal = 1024,
            /// <summary>
            /// <para>Flag used to mark a compressed (half float) tangent array.</para>
            /// </summary>
            CompressTangent = 2048,
            /// <summary>
            /// <para>Flag used to mark a compressed (half float) color array.</para>
            /// </summary>
            CompressColor = 4096,
            /// <summary>
            /// <para>Flag used to mark a compressed (half float) UV coordinates array.</para>
            /// </summary>
            CompressTexUv = 8192,
            /// <summary>
            /// <para>Flag used to mark a compressed (half float) UV coordinates array for the second UV coordinates.</para>
            /// </summary>
            CompressTexUv2 = 16384,
            /// <summary>
            /// <para>Flag used to mark a compressed bone array.</para>
            /// </summary>
            CompressBones = 32768,
            /// <summary>
            /// <para>Flag used to mark a compressed (half float) weight array.</para>
            /// </summary>
            CompressWeights = 65536,
            /// <summary>
            /// <para>Flag used to mark a compressed index array.</para>
            /// </summary>
            CompressIndex = 131072,
            /// <summary>
            /// <para>Flag used to mark that the array contains 2D vertices.</para>
            /// </summary>
            FlagUse2dVertices = 262144,
            /// <summary>
            /// <para>Flag used to mark that the array uses 16-bit bones instead of 8-bit.</para>
            /// </summary>
            FlagUse16BitBones = 524288,
            /// <summary>
            /// <para>Flag used to mark that the array uses an octahedral representation of normal and tangent vectors rather than cartesian.</para>
            /// </summary>
            FlagUseOctahedralCompression = 2097152,
            /// <summary>
            /// <para>Used to set flags <see cref="Godot.VisualServer.ArrayFormat.CompressNormal"/>, <see cref="Godot.VisualServer.ArrayFormat.CompressTangent"/>, <see cref="Godot.VisualServer.ArrayFormat.CompressColor"/>, <see cref="Godot.VisualServer.ArrayFormat.CompressTexUv"/>, <see cref="Godot.VisualServer.ArrayFormat.CompressTexUv2"/>, <see cref="Godot.VisualServer.ArrayFormat.CompressWeights"/>, and <see cref="Godot.VisualServer.ArrayFormat.FlagUseOctahedralCompression"/> quickly.</para>
            /// </summary>
            CompressDefault = 2194432
        }

        public enum ParticlesDrawOrder
        {
            /// <summary>
            /// <para>Draw particles in the order that they appear in the particles array.</para>
            /// </summary>
            Index = 0,
            /// <summary>
            /// <para>Sort particles based on their lifetime.</para>
            /// </summary>
            Lifetime = 1,
            /// <summary>
            /// <para>Sort particles based on their distance to the camera.</para>
            /// </summary>
            ViewDepth = 2
        }

        public enum CanvasLightMode
        {
            /// <summary>
            /// <para>Adds light color additive to the canvas.</para>
            /// </summary>
            Add = 0,
            /// <summary>
            /// <para>Adds light color subtractive to the canvas.</para>
            /// </summary>
            Sub = 1,
            /// <summary>
            /// <para>The light adds color depending on transparency.</para>
            /// </summary>
            Mix = 2,
            /// <summary>
            /// <para>The light adds color depending on mask.</para>
            /// </summary>
            Mask = 3
        }

        public enum LightDirectionalShadowMode
        {
            /// <summary>
            /// <para>Use orthogonal shadow projection for directional light.</para>
            /// </summary>
            Orthogonal = 0,
            /// <summary>
            /// <para>Use 2 splits for shadow projection when using directional light.</para>
            /// </summary>
            Parallel2Splits = 1,
            /// <summary>
            /// <para>Use 4 splits for shadow projection when using directional light.</para>
            /// </summary>
            Parallel4Splits = 2
        }

        public enum LightParam
        {
            /// <summary>
            /// <para>The light's energy.</para>
            /// </summary>
            Energy = 0,
            /// <summary>
            /// <para>Secondary multiplier used with indirect light (light bounces).</para>
            /// </summary>
            IndirectEnergy = 1,
            /// <summary>
            /// <para>The light's size, currently only used for soft shadows in baked lightmaps.</para>
            /// </summary>
            Size = 2,
            /// <summary>
            /// <para>The light's influence on specularity.</para>
            /// </summary>
            Specular = 3,
            /// <summary>
            /// <para>The light's range.</para>
            /// </summary>
            Range = 4,
            /// <summary>
            /// <para>The light's attenuation.</para>
            /// </summary>
            Attenuation = 5,
            /// <summary>
            /// <para>The spotlight's angle.</para>
            /// </summary>
            SpotAngle = 6,
            /// <summary>
            /// <para>The spotlight's attenuation.</para>
            /// </summary>
            SpotAttenuation = 7,
            /// <summary>
            /// <para>Scales the shadow color.</para>
            /// </summary>
            ContactShadowSize = 8,
            /// <summary>
            /// <para>Max distance that shadows will be rendered.</para>
            /// </summary>
            ShadowMaxDistance = 9,
            /// <summary>
            /// <para>Proportion of shadow atlas occupied by the first split.</para>
            /// </summary>
            ShadowSplit1Offset = 10,
            /// <summary>
            /// <para>Proportion of shadow atlas occupied by the second split.</para>
            /// </summary>
            ShadowSplit2Offset = 11,
            /// <summary>
            /// <para>Proportion of shadow atlas occupied by the third split. The fourth split occupies the rest.</para>
            /// </summary>
            ShadowSplit3Offset = 12,
            /// <summary>
            /// <para>Normal bias used to offset shadow lookup by object normal. Can be used to fix self-shadowing artifacts.</para>
            /// </summary>
            ShadowNormalBias = 13,
            /// <summary>
            /// <para>Bias the shadow lookup to fix self-shadowing artifacts.</para>
            /// </summary>
            ShadowBias = 14,
            /// <summary>
            /// <para>Increases bias on further splits to fix self-shadowing that only occurs far away from the camera.</para>
            /// </summary>
            ShadowBiasSplitScale = 15,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.VisualServer.LightParam"/> enum.</para>
            /// </summary>
            Max = 16
        }

        public enum ArrayType
        {
            /// <summary>
            /// <para>Array is a vertex array.</para>
            /// </summary>
            Vertex = 0,
            /// <summary>
            /// <para>Array is a normal array.</para>
            /// </summary>
            Normal = 1,
            /// <summary>
            /// <para>Array is a tangent array.</para>
            /// </summary>
            Tangent = 2,
            /// <summary>
            /// <para>Array is a color array.</para>
            /// </summary>
            Color = 3,
            /// <summary>
            /// <para>Array is an UV coordinates array.</para>
            /// </summary>
            TexUv = 4,
            /// <summary>
            /// <para>Array is an UV coordinates array for the second UV coordinates.</para>
            /// </summary>
            TexUv2 = 5,
            /// <summary>
            /// <para>Array contains bone information.</para>
            /// </summary>
            Bones = 6,
            /// <summary>
            /// <para>Array is weight information.</para>
            /// </summary>
            Weights = 7,
            /// <summary>
            /// <para>Array is index array.</para>
            /// </summary>
            Index = 8,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.VisualServer.ArrayType"/> enum.</para>
            /// </summary>
            Max = 9
        }

        public enum CanvasOccluderPolygonCullMode
        {
            /// <summary>
            /// <para>Culling of the canvas occluder is disabled.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>Culling of the canvas occluder is clockwise.</para>
            /// </summary>
            Clockwise = 1,
            /// <summary>
            /// <para>Culling of the canvas occluder is counterclockwise.</para>
            /// </summary>
            CounterClockwise = 2
        }

        public enum InstanceFlags
        {
            /// <summary>
            /// <para>Allows the instance to be used in baked lighting.</para>
            /// </summary>
            UseBakedLight = 0,
            /// <summary>
            /// <para>When set, manually requests to draw geometry on next frame.</para>
            /// </summary>
            DrawNextFrameIfVisible = 1,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.VisualServer.InstanceFlags"/> enum.</para>
            /// </summary>
            Max = 2
        }

        public enum ViewportMSAA
        {
            /// <summary>
            /// <para>Multisample antialiasing is disabled.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>Multisample antialiasing is set to 2×.</para>
            /// </summary>
            Msaa2x = 1,
            /// <summary>
            /// <para>Multisample antialiasing is set to 4×.</para>
            /// </summary>
            Msaa4x = 2,
            /// <summary>
            /// <para>Multisample antialiasing is set to 8×.</para>
            /// </summary>
            Msaa8x = 3,
            /// <summary>
            /// <para>Multisample antialiasing is set to 16×.</para>
            /// </summary>
            Msaa16x = 4,
            /// <summary>
            /// <para>Multisample antialiasing is set to 2× on external texture. Special mode for GLES2 Android VR (Oculus Quest and Go).</para>
            /// </summary>
            Ext2x = 5,
            /// <summary>
            /// <para>Multisample antialiasing is set to 4× on external texture. Special mode for GLES2 Android VR (Oculus Quest and Go).</para>
            /// </summary>
            Ext4x = 6
        }

        public enum LightType
        {
            /// <summary>
            /// <para>Is a directional (sun) light.</para>
            /// </summary>
            Directional = 0,
            /// <summary>
            /// <para>Is an omni light.</para>
            /// </summary>
            Omni = 1,
            /// <summary>
            /// <para>Is a spot light.</para>
            /// </summary>
            Spot = 2
        }

        public enum CubeMapSide
        {
            /// <summary>
            /// <para>Marks the left side of a cubemap.</para>
            /// </summary>
            Left = 0,
            /// <summary>
            /// <para>Marks the right side of a cubemap.</para>
            /// </summary>
            Right = 1,
            /// <summary>
            /// <para>Marks the bottom side of a cubemap.</para>
            /// </summary>
            Bottom = 2,
            /// <summary>
            /// <para>Marks the top side of a cubemap.</para>
            /// </summary>
            Top = 3,
            /// <summary>
            /// <para>Marks the front side of a cubemap.</para>
            /// </summary>
            Front = 4,
            /// <summary>
            /// <para>Marks the back side of a cubemap.</para>
            /// </summary>
            Back = 5
        }

        /// <summary>
        /// <para>If <c>false</c>, disables rendering completely, but the engine logic is still being processed. You can call <see cref="Godot.VisualServer.ForceDraw"/> to draw a frame even with rendering disabled.</para>
        /// </summary>
        public static bool RenderLoopEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsRenderLoopEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRenderLoopEnabled(value);
            }
#pragma warning restore CS0618
        }

        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(VisualServer).Name);
                return singleton;
            }
        }

        private const string nativeName = "VisualServer";
        internal static IntPtr ptr = NativeCalls.godot_icall_VisualServer_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "force_sync");

        /// <summary>
        /// <para>Synchronizes threads.</para>
        /// </summary>
        [GodotMethod("force_sync")]
        public static void ForceSync()
        {
            NativeCalls.godot_icall_0_3(method_bind_0, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "force_draw");

        /// <summary>
        /// <para>Forces a frame to be drawn when the function is called. Drawing a frame updates all <see cref="Godot.Viewport"/>s that are set to update. Use with extreme caution.</para>
        /// </summary>
        [GodotMethod("force_draw")]
        public static void ForceDraw(bool swapBuffers = true, double frameStep = 0)
        {
            NativeCalls.godot_icall_2_1045(method_bind_1, ptr, swapBuffers, frameStep);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "sync");

        /// <summary>
        /// <para>Not implemented in Godot 3.x.</para>
        /// </summary>
        [GodotMethod("sync")]
        public static void Sync()
        {
            NativeCalls.godot_icall_0_3(method_bind_2, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw");

        /// <summary>
        /// <para>Draws a frame. This method is deprecated, please use <see cref="Godot.VisualServer.ForceDraw"/> instead.</para>
        /// </summary>
        [GodotMethod("draw")]
        public static void Draw(bool swapBuffers = true, double frameStep = 0)
        {
            NativeCalls.godot_icall_2_1045(method_bind_3, ptr, swapBuffers, frameStep);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "texture_create");

        /// <summary>
        /// <para>Creates an empty texture and adds it to the VisualServer. It can be accessed with the RID that is returned. This RID will be used in all <c>texture_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// </summary>
        [GodotMethod("texture_create")]
        public static RID TextureCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_4, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "texture_create_from_image");

        /// <summary>
        /// <para>Creates a texture, allocates the space for an image, and fills in the image.</para>
        /// </summary>
        [GodotMethod("texture_create_from_image")]
        public static RID TextureCreateFromImage(Image image, uint flags = (uint)7)
        {
            return new RID(NativeCalls.godot_icall_2_1046(method_bind_5, ptr, Object.GetPtr(image), flags));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "texture_allocate");

        /// <summary>
        /// <para>Allocates the GPU memory for the texture.</para>
        /// </summary>
        [GodotMethod("texture_allocate")]
        public static void TextureAllocate(RID texture, int width, int height, int depth3d, Image.Format format, VisualServer.TextureType type, uint flags = (uint)7)
        {
            NativeCalls.godot_icall_7_1047(method_bind_6, ptr, RID.GetPtr(texture), width, height, depth3d, (int)format, (int)type, flags);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "texture_set_data");

        /// <summary>
        /// <para>Sets the texture's image data. If it's a CubeMap, it sets the image data at a cube side.</para>
        /// </summary>
        [GodotMethod("texture_set_data")]
        public static void TextureSetData(RID texture, Image image, int layer = 0)
        {
            NativeCalls.godot_icall_3_1048(method_bind_7, ptr, RID.GetPtr(texture), Object.GetPtr(image), layer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "texture_set_data_partial");

        /// <summary>
        /// <para>Sets a part of the data for a texture. Warning: this function calls the underlying graphics API directly and may corrupt your texture if used improperly.</para>
        /// </summary>
        [GodotMethod("texture_set_data_partial")]
        public static void TextureSetDataPartial(RID texture, Image image, int srcX, int srcY, int srcW, int srcH, int dstX, int dstY, int dstMip, int layer = 0)
        {
            NativeCalls.godot_icall_10_1049(method_bind_8, ptr, RID.GetPtr(texture), Object.GetPtr(image), srcX, srcY, srcW, srcH, dstX, dstY, dstMip, layer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "texture_get_data");

        /// <summary>
        /// <para>Returns a copy of a texture's image unless it's a CubeMap, in which case it returns the <see cref="Godot.RID"/> of the image at one of the cubes sides.</para>
        /// </summary>
        [GodotMethod("texture_get_data")]
        public static Image TextureGetData(RID texture, int cubeSide = 0)
        {
            return NativeCalls.godot_icall_2_1050(method_bind_9, ptr, RID.GetPtr(texture), cubeSide);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "texture_set_flags");

        /// <summary>
        /// <para>Sets the texture's flags. See <see cref="Godot.VisualServer.TextureFlags"/> for options.</para>
        /// </summary>
        [GodotMethod("texture_set_flags")]
        public static void TextureSetFlags(RID texture, uint flags)
        {
            NativeCalls.godot_icall_2_639(method_bind_10, ptr, RID.GetPtr(texture), flags);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "texture_get_flags");

        /// <summary>
        /// <para>Returns the flags of a texture.</para>
        /// </summary>
        [GodotMethod("texture_get_flags")]
        public static uint TextureGetFlags(RID texture)
        {
            return NativeCalls.godot_icall_1_640(method_bind_11, ptr, RID.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "texture_get_format");

        /// <summary>
        /// <para>Returns the format of the texture's image.</para>
        /// </summary>
        [GodotMethod("texture_get_format")]
        public static Image.Format TextureGetFormat(RID texture)
        {
            return (Image.Format)NativeCalls.godot_icall_1_1051(method_bind_12, ptr, RID.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "texture_get_type");

        /// <summary>
        /// <para>Returns the type of the texture, can be any of the <see cref="Godot.VisualServer.TextureType"/>.</para>
        /// </summary>
        [GodotMethod("texture_get_type")]
        public static VisualServer.TextureType TextureGetType(RID texture)
        {
            return (VisualServer.TextureType)NativeCalls.godot_icall_1_1052(method_bind_13, ptr, RID.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "texture_get_texid");

        /// <summary>
        /// <para>Returns the opengl id of the texture's image.</para>
        /// </summary>
        [GodotMethod("texture_get_texid")]
        public static uint TextureGetTexid(RID texture)
        {
            return NativeCalls.godot_icall_1_640(method_bind_14, ptr, RID.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "texture_get_width");

        /// <summary>
        /// <para>Returns the texture's width.</para>
        /// </summary>
        [GodotMethod("texture_get_width")]
        public static uint TextureGetWidth(RID texture)
        {
            return NativeCalls.godot_icall_1_640(method_bind_15, ptr, RID.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "texture_get_height");

        /// <summary>
        /// <para>Returns the texture's height.</para>
        /// </summary>
        [GodotMethod("texture_get_height")]
        public static uint TextureGetHeight(RID texture)
        {
            return NativeCalls.godot_icall_1_640(method_bind_16, ptr, RID.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "texture_get_depth");

        /// <summary>
        /// <para>Returns the depth of the texture.</para>
        /// </summary>
        [GodotMethod("texture_get_depth")]
        public static uint TextureGetDepth(RID texture)
        {
            return NativeCalls.godot_icall_1_640(method_bind_17, ptr, RID.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "texture_set_size_override");

        /// <summary>
        /// <para>Resizes the texture to the specified dimensions.</para>
        /// </summary>
        [GodotMethod("texture_set_size_override")]
        public static void TextureSetSizeOverride(RID texture, int width, int height, int depth)
        {
            NativeCalls.godot_icall_4_1053(method_bind_18, ptr, RID.GetPtr(texture), width, height, depth);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "texture_set_path");

        /// <summary>
        /// <para>Sets the texture's path.</para>
        /// </summary>
        [GodotMethod("texture_set_path")]
        public static void TextureSetPath(RID texture, string path)
        {
            NativeCalls.godot_icall_2_1054(method_bind_19, ptr, RID.GetPtr(texture), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "texture_get_path");

        /// <summary>
        /// <para>Returns the texture's path.</para>
        /// </summary>
        [GodotMethod("texture_get_path")]
        public static string TextureGetPath(RID texture)
        {
            return NativeCalls.godot_icall_1_1055(method_bind_20, ptr, RID.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "texture_set_shrink_all_x2_on_set_data");

        /// <summary>
        /// <para>If <c>true</c>, sets internal processes to shrink all image data to half the size.</para>
        /// </summary>
        [GodotMethod("texture_set_shrink_all_x2_on_set_data")]
        public static void TextureSetShrinkAllX2OnSetData(bool shrink)
        {
            NativeCalls.godot_icall_1_16(method_bind_21, ptr, shrink);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "texture_set_proxy");

        /// <summary>
        /// <para>Creates an update link between two textures, similar to how <see cref="Godot.ViewportTexture"/>s operate. When the base texture is the texture of a <see cref="Godot.Viewport"/>, every time the viewport renders a new frame, the proxy texture automatically receives an update.</para>
        /// <para>For example, this code links a generic <see cref="Godot.ImageTexture"/> to the texture output of the <see cref="Godot.Viewport"/> using the VisualServer API:</para>
        /// <para><code>
        /// func _ready():
        ///     var viewport_rid = get_viewport().get_viewport_rid()
        ///     var viewport_texture_rid = VisualServer.viewport_get_texture(viewport_rid)
        /// 
        ///     var proxy_texture = ImageTexture.new()
        ///     var viewport_texture_image_data = VisualServer.texture_get_data(viewport_texture_rid)
        /// 
        ///     proxy_texture.create_from_image(viewport_texture_image_data)
        ///     var proxy_texture_rid = proxy_texture.get_rid()
        ///     VisualServer.texture_set_proxy(proxy_texture_rid, viewport_texture_rid)
        /// 
        ///     $TextureRect.texture = proxy_texture
        /// </code></para>
        /// </summary>
        [GodotMethod("texture_set_proxy")]
        public static void TextureSetProxy(RID proxy, RID @base)
        {
            NativeCalls.godot_icall_2_637(method_bind_22, ptr, RID.GetPtr(proxy), RID.GetPtr(@base));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "texture_bind");

        /// <summary>
        /// <para>Binds the texture to a texture slot.</para>
        /// </summary>
        [GodotMethod("texture_bind")]
        public static void TextureBind(RID texture, uint number)
        {
            NativeCalls.godot_icall_2_639(method_bind_23, ptr, RID.GetPtr(texture), number);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "texture_debug_usage");

        /// <summary>
        /// <para>Returns a list of all the textures and their information.</para>
        /// </summary>
        [GodotMethod("texture_debug_usage")]
        public static Godot.Collections.Array TextureDebugUsage()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_24, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "textures_keep_original");

        /// <summary>
        /// <para>If <c>true</c>, the image will be stored in the texture's images array if overwritten.</para>
        /// </summary>
        [GodotMethod("textures_keep_original")]
        public static void TexturesKeepOriginal(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_25, ptr, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "sky_create");

        /// <summary>
        /// <para>Creates an empty sky and adds it to the VisualServer. It can be accessed with the RID that is returned. This RID will be used in all <c>sky_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// </summary>
        [GodotMethod("sky_create")]
        public static RID SkyCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_26, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "sky_set_texture");

        /// <summary>
        /// <para>Sets a sky's texture.</para>
        /// </summary>
        [GodotMethod("sky_set_texture")]
        public static void SkySetTexture(RID sky, RID cubeMap, int radianceSize)
        {
            NativeCalls.godot_icall_3_1056(method_bind_27, ptr, RID.GetPtr(sky), RID.GetPtr(cubeMap), radianceSize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shader_create");

        /// <summary>
        /// <para>Creates an empty shader and adds it to the VisualServer. It can be accessed with the RID that is returned. This RID will be used in all <c>shader_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// </summary>
        [GodotMethod("shader_create")]
        public static RID ShaderCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_28, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shader_set_code");

        /// <summary>
        /// <para>Sets a shader's code.</para>
        /// </summary>
        [GodotMethod("shader_set_code")]
        public static void ShaderSetCode(RID shader, string code)
        {
            NativeCalls.godot_icall_2_1054(method_bind_29, ptr, RID.GetPtr(shader), code);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shader_get_code");

        /// <summary>
        /// <para>Returns a shader's code.</para>
        /// </summary>
        [GodotMethod("shader_get_code")]
        public static string ShaderGetCode(RID shader)
        {
            return NativeCalls.godot_icall_1_1055(method_bind_30, ptr, RID.GetPtr(shader));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shader_get_param_list");

        /// <summary>
        /// <para>Returns the parameters of a shader.</para>
        /// </summary>
        [GodotMethod("shader_get_param_list")]
        public static Godot.Collections.Array ShaderGetParamList(RID shader)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_1_635(method_bind_31, ptr, RID.GetPtr(shader)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shader_set_default_texture_param");

        /// <summary>
        /// <para>Sets a shader's default texture. Overwrites the texture given by name.</para>
        /// </summary>
        [GodotMethod("shader_set_default_texture_param")]
        public static void ShaderSetDefaultTextureParam(RID shader, string name, RID texture)
        {
            NativeCalls.godot_icall_3_1057(method_bind_32, ptr, RID.GetPtr(shader), name, RID.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shader_get_default_texture_param");

        /// <summary>
        /// <para>Returns a default texture from a shader searched by name.</para>
        /// </summary>
        [GodotMethod("shader_get_default_texture_param")]
        public static RID ShaderGetDefaultTextureParam(RID shader, string name)
        {
            return new RID(NativeCalls.godot_icall_2_1058(method_bind_33, ptr, RID.GetPtr(shader), name));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shader_async_hidden_forbidden");

        /// <summary>
        /// <para>If asynchronous shader compilation is enabled, this controls whether <see cref="Godot.SpatialMaterial.AsyncModeEnum.Hidden"/> is obeyed.</para>
        /// <para>For instance, you may want to enable this temporarily before taking a screenshot. This ensures everything is visible even if shaders with async mode hidden are not ready yet.</para>
        /// <para>Reflection probes use this internally to ensure they capture everything regardless the shaders are ready or not.</para>
        /// </summary>
        [GodotMethod("set_shader_async_hidden_forbidden")]
        public static void SetShaderAsyncHiddenForbidden(bool forbidden)
        {
            NativeCalls.godot_icall_1_16(method_bind_34, ptr, forbidden);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "material_create");

        /// <summary>
        /// <para>Creates an empty material and adds it to the VisualServer. It can be accessed with the RID that is returned. This RID will be used in all <c>material_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// </summary>
        [GodotMethod("material_create")]
        public static RID MaterialCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_35, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "material_set_shader");

        /// <summary>
        /// <para>Sets a shader material's shader.</para>
        /// </summary>
        [GodotMethod("material_set_shader")]
        public static void MaterialSetShader(RID shaderMaterial, RID shader)
        {
            NativeCalls.godot_icall_2_637(method_bind_36, ptr, RID.GetPtr(shaderMaterial), RID.GetPtr(shader));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "material_get_shader");

        /// <summary>
        /// <para>Returns the shader of a certain material's shader. Returns an empty RID if the material doesn't have a shader.</para>
        /// </summary>
        [GodotMethod("material_get_shader")]
        public static RID MaterialGetShader(RID shaderMaterial)
        {
            return new RID(NativeCalls.godot_icall_1_638(method_bind_37, ptr, RID.GetPtr(shaderMaterial)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "material_set_param");

        /// <summary>
        /// <para>Sets a material's parameter.</para>
        /// </summary>
        [GodotMethod("material_set_param")]
        public static void MaterialSetParam(RID material, string parameter, object value)
        {
            NativeCalls.godot_icall_3_1059(method_bind_38, ptr, RID.GetPtr(material), parameter, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "material_get_param");

        /// <summary>
        /// <para>Returns the value of a certain material's parameter.</para>
        /// </summary>
        [GodotMethod("material_get_param")]
        public static object MaterialGetParam(RID material, string parameter)
        {
            return NativeCalls.godot_icall_2_1060(method_bind_39, ptr, RID.GetPtr(material), parameter);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "material_get_param_default");

        /// <summary>
        /// <para>Returns the default value for the param if available. Returns <c>null</c> otherwise.</para>
        /// </summary>
        [GodotMethod("material_get_param_default")]
        public static object MaterialGetParamDefault(RID material, string parameter)
        {
            return NativeCalls.godot_icall_2_1060(method_bind_40, ptr, RID.GetPtr(material), parameter);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "material_set_render_priority");

        /// <summary>
        /// <para>Sets a material's render priority.</para>
        /// </summary>
        [GodotMethod("material_set_render_priority")]
        public static void MaterialSetRenderPriority(RID material, int priority)
        {
            NativeCalls.godot_icall_2_645(method_bind_41, ptr, RID.GetPtr(material), priority);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "material_set_line_width");

        /// <summary>
        /// <para>Sets a material's line width.</para>
        /// </summary>
        [GodotMethod("material_set_line_width")]
        public static void MaterialSetLineWidth(RID material, float width)
        {
            NativeCalls.godot_icall_2_630(method_bind_42, ptr, RID.GetPtr(material), width);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "material_set_next_pass");

        /// <summary>
        /// <para>Sets an object's next material.</para>
        /// </summary>
        [GodotMethod("material_set_next_pass")]
        public static void MaterialSetNextPass(RID material, RID nextMaterial)
        {
            NativeCalls.godot_icall_2_637(method_bind_43, ptr, RID.GetPtr(material), RID.GetPtr(nextMaterial));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_create");

        /// <summary>
        /// <para>Creates a new mesh and adds it to the VisualServer. It can be accessed with the RID that is returned. This RID will be used in all <c>mesh_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// <para>To place in a scene, attach this mesh to an instance using <see cref="Godot.VisualServer.InstanceSetBase"/> using the returned RID.</para>
        /// </summary>
        [GodotMethod("mesh_create")]
        public static RID MeshCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_44, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_surface_get_format_offset");

        /// <summary>
        /// <para>Function is unused in Godot 3.x.</para>
        /// </summary>
        [GodotMethod("mesh_surface_get_format_offset")]
        public static uint MeshSurfaceGetFormatOffset(uint format, int vertexLen, int indexLen, int arrayIndex)
        {
            return NativeCalls.godot_icall_4_1061(method_bind_45, ptr, format, vertexLen, indexLen, arrayIndex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_surface_get_format_stride");

        [GodotMethod("mesh_surface_get_format_stride")]
        public static uint MeshSurfaceGetFormatStride(uint format, int vertexLen, int indexLen, int arrayIndex)
        {
            return NativeCalls.godot_icall_4_1061(method_bind_46, ptr, format, vertexLen, indexLen, arrayIndex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_add_surface_from_arrays");

        /// <summary>
        /// <para>Adds a surface generated from the Arrays to a mesh. See <see cref="Godot.VisualServer.PrimitiveType"/> constants for types.</para>
        /// </summary>
        /// <param name="blendShapes">If the parameter is null, then the default value is new Godot.Collections.Array { }</param>
        [GodotMethod("mesh_add_surface_from_arrays")]
        public static void MeshAddSurfaceFromArrays(RID mesh, VisualServer.PrimitiveType primitive, Godot.Collections.Array arrays, Godot.Collections.Array blendShapes = null, uint compressFormat = (uint)2194432)
        {
            Godot.Collections.Array blendShapes_in = blendShapes != null ? blendShapes : new Godot.Collections.Array { };
            NativeCalls.godot_icall_5_1062(method_bind_47, ptr, RID.GetPtr(mesh), (int)primitive, arrays.GetPtr(), blendShapes_in.GetPtr(), compressFormat);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_set_blend_shape_count");

        /// <summary>
        /// <para>Sets a mesh's blend shape count.</para>
        /// </summary>
        [GodotMethod("mesh_set_blend_shape_count")]
        public static void MeshSetBlendShapeCount(RID mesh, int amount)
        {
            NativeCalls.godot_icall_2_645(method_bind_48, ptr, RID.GetPtr(mesh), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_get_blend_shape_count");

        /// <summary>
        /// <para>Returns a mesh's blend shape count.</para>
        /// </summary>
        [GodotMethod("mesh_get_blend_shape_count")]
        public static int MeshGetBlendShapeCount(RID mesh)
        {
            return NativeCalls.godot_icall_1_643(method_bind_49, ptr, RID.GetPtr(mesh));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_set_blend_shape_mode");

        /// <summary>
        /// <para>Sets a mesh's blend shape mode.</para>
        /// </summary>
        [GodotMethod("mesh_set_blend_shape_mode")]
        public static void MeshSetBlendShapeMode(RID mesh, VisualServer.BlendShapeMode mode)
        {
            NativeCalls.godot_icall_2_645(method_bind_50, ptr, RID.GetPtr(mesh), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_get_blend_shape_mode");

        /// <summary>
        /// <para>Returns a mesh's blend shape mode.</para>
        /// </summary>
        [GodotMethod("mesh_get_blend_shape_mode")]
        public static VisualServer.BlendShapeMode MeshGetBlendShapeMode(RID mesh)
        {
            return (VisualServer.BlendShapeMode)NativeCalls.godot_icall_1_1063(method_bind_51, ptr, RID.GetPtr(mesh));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_surface_update_region");

        /// <summary>
        /// <para>Updates a specific region of a vertex buffer for the specified surface. Warning: this function alters the vertex buffer directly with no safety mechanisms, you can easily corrupt your mesh.</para>
        /// </summary>
        [GodotMethod("mesh_surface_update_region")]
        public static void MeshSurfaceUpdateRegion(RID mesh, int surface, int offset, byte[] data)
        {
            NativeCalls.godot_icall_4_1064(method_bind_52, ptr, RID.GetPtr(mesh), surface, offset, data);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_53 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_surface_set_material");

        /// <summary>
        /// <para>Sets a mesh's surface's material.</para>
        /// </summary>
        [GodotMethod("mesh_surface_set_material")]
        public static void MeshSurfaceSetMaterial(RID mesh, int surface, RID material)
        {
            NativeCalls.godot_icall_3_749(method_bind_53, ptr, RID.GetPtr(mesh), surface, RID.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_54 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_surface_get_material");

        /// <summary>
        /// <para>Returns a mesh's surface's material.</para>
        /// </summary>
        [GodotMethod("mesh_surface_get_material")]
        public static RID MeshSurfaceGetMaterial(RID mesh, int surface)
        {
            return new RID(NativeCalls.godot_icall_2_752(method_bind_54, ptr, RID.GetPtr(mesh), surface));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_55 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_surface_get_array_len");

        /// <summary>
        /// <para>Returns a mesh's surface's amount of vertices.</para>
        /// </summary>
        [GodotMethod("mesh_surface_get_array_len")]
        public static int MeshSurfaceGetArrayLen(RID mesh, int surface)
        {
            return NativeCalls.godot_icall_2_1065(method_bind_55, ptr, RID.GetPtr(mesh), surface);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_56 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_surface_get_array_index_len");

        /// <summary>
        /// <para>Returns a mesh's surface's amount of indices.</para>
        /// </summary>
        [GodotMethod("mesh_surface_get_array_index_len")]
        public static int MeshSurfaceGetArrayIndexLen(RID mesh, int surface)
        {
            return NativeCalls.godot_icall_2_1065(method_bind_56, ptr, RID.GetPtr(mesh), surface);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_57 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_surface_get_array");

        /// <summary>
        /// <para>Returns a mesh's surface's vertex buffer.</para>
        /// </summary>
        [GodotMethod("mesh_surface_get_array")]
        public static byte[] MeshSurfaceGetArray(RID mesh, int surface)
        {
            return NativeCalls.godot_icall_2_1066(method_bind_57, ptr, RID.GetPtr(mesh), surface);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_58 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_surface_get_index_array");

        /// <summary>
        /// <para>Returns a mesh's surface's index buffer.</para>
        /// </summary>
        [GodotMethod("mesh_surface_get_index_array")]
        public static byte[] MeshSurfaceGetIndexArray(RID mesh, int surface)
        {
            return NativeCalls.godot_icall_2_1066(method_bind_58, ptr, RID.GetPtr(mesh), surface);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_59 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_surface_get_arrays");

        /// <summary>
        /// <para>Returns a mesh's surface's buffer arrays.</para>
        /// </summary>
        [GodotMethod("mesh_surface_get_arrays")]
        public static Godot.Collections.Array MeshSurfaceGetArrays(RID mesh, int surface)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_2_1067(method_bind_59, ptr, RID.GetPtr(mesh), surface));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_60 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_surface_get_blend_shape_arrays");

        /// <summary>
        /// <para>Returns a mesh's surface's arrays for blend shapes.</para>
        /// </summary>
        [GodotMethod("mesh_surface_get_blend_shape_arrays")]
        public static Godot.Collections.Array MeshSurfaceGetBlendShapeArrays(RID mesh, int surface)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_2_1067(method_bind_60, ptr, RID.GetPtr(mesh), surface));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_61 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_surface_get_format");

        /// <summary>
        /// <para>Returns the format of a mesh's surface.</para>
        /// </summary>
        [GodotMethod("mesh_surface_get_format")]
        public static uint MeshSurfaceGetFormat(RID mesh, int surface)
        {
            return NativeCalls.godot_icall_2_1068(method_bind_61, ptr, RID.GetPtr(mesh), surface);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_62 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_surface_get_primitive_type");

        /// <summary>
        /// <para>Returns the primitive type of a mesh's surface.</para>
        /// </summary>
        [GodotMethod("mesh_surface_get_primitive_type")]
        public static VisualServer.PrimitiveType MeshSurfaceGetPrimitiveType(RID mesh, int surface)
        {
            return (VisualServer.PrimitiveType)NativeCalls.godot_icall_2_1069(method_bind_62, ptr, RID.GetPtr(mesh), surface);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_63 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_surface_get_aabb");

        /// <summary>
        /// <para>Returns a mesh's surface's aabb.</para>
        /// </summary>
        [GodotMethod("mesh_surface_get_aabb")]
        public static AABB MeshSurfaceGetAabb(RID mesh, int surface)
        {
            NativeCalls.godot_icall_2_1070(method_bind_63, ptr, RID.GetPtr(mesh), surface, out AABB argRet); return (AABB)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_64 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_surface_get_skeleton_aabb");

        /// <summary>
        /// <para>Returns the aabb of a mesh's surface's skeleton.</para>
        /// </summary>
        [GodotMethod("mesh_surface_get_skeleton_aabb")]
        public static Godot.Collections.Array MeshSurfaceGetSkeletonAabb(RID mesh, int surface)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_2_1067(method_bind_64, ptr, RID.GetPtr(mesh), surface));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_65 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_remove_surface");

        /// <summary>
        /// <para>Removes a mesh's surface.</para>
        /// </summary>
        [GodotMethod("mesh_remove_surface")]
        public static void MeshRemoveSurface(RID mesh, int index)
        {
            NativeCalls.godot_icall_2_645(method_bind_65, ptr, RID.GetPtr(mesh), index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_66 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_get_surface_count");

        /// <summary>
        /// <para>Returns a mesh's number of surfaces.</para>
        /// </summary>
        [GodotMethod("mesh_get_surface_count")]
        public static int MeshGetSurfaceCount(RID mesh)
        {
            return NativeCalls.godot_icall_1_643(method_bind_66, ptr, RID.GetPtr(mesh));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_67 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_set_custom_aabb");

        /// <summary>
        /// <para>Sets a mesh's custom aabb.</para>
        /// </summary>
        [GodotMethod("mesh_set_custom_aabb")]
        public static void MeshSetCustomAabb(RID mesh, AABB aabb)
        {
            NativeCalls.godot_icall_2_1071(method_bind_67, ptr, RID.GetPtr(mesh), ref aabb);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_68 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_get_custom_aabb");

        /// <summary>
        /// <para>Returns a mesh's custom aabb.</para>
        /// </summary>
        [GodotMethod("mesh_get_custom_aabb")]
        public static AABB MeshGetCustomAabb(RID mesh)
        {
            NativeCalls.godot_icall_1_1072(method_bind_68, ptr, RID.GetPtr(mesh), out AABB argRet); return (AABB)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_69 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mesh_clear");

        /// <summary>
        /// <para>Removes all surfaces from a mesh.</para>
        /// </summary>
        [GodotMethod("mesh_clear")]
        public static void MeshClear(RID mesh)
        {
            NativeCalls.godot_icall_1_285(method_bind_69, ptr, RID.GetPtr(mesh));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_70 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "multimesh_create");

        /// <summary>
        /// <para>Creates a new multimesh on the VisualServer and returns an <see cref="Godot.RID"/> handle. This RID will be used in all <c>multimesh_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// <para>To place in a scene, attach this multimesh to an instance using <see cref="Godot.VisualServer.InstanceSetBase"/> using the returned RID.</para>
        /// </summary>
        [GodotMethod("multimesh_create")]
        public static RID MultimeshCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_70, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_71 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "multimesh_allocate");

        /// <summary>
        /// <para>Allocates space for the multimesh data. Format parameters determine how the data will be stored by OpenGL. See <see cref="Godot.VisualServer.MultimeshTransformFormat"/>, <see cref="Godot.VisualServer.MultimeshColorFormat"/>, and <see cref="Godot.VisualServer.MultimeshCustomDataFormat"/> for usage. Equivalent to <see cref="Godot.MultiMesh.InstanceCount"/>.</para>
        /// </summary>
        [GodotMethod("multimesh_allocate")]
        public static void MultimeshAllocate(RID multimesh, int instances, VisualServer.MultimeshTransformFormat transformFormat, VisualServer.MultimeshColorFormat colorFormat, VisualServer.MultimeshCustomDataFormat customDataFormat = (VisualServer.MultimeshCustomDataFormat)0)
        {
            NativeCalls.godot_icall_5_1073(method_bind_71, ptr, RID.GetPtr(multimesh), instances, (int)transformFormat, (int)colorFormat, (int)customDataFormat);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_72 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "multimesh_get_instance_count");

        /// <summary>
        /// <para>Returns the number of instances allocated for this multimesh.</para>
        /// </summary>
        [GodotMethod("multimesh_get_instance_count")]
        public static int MultimeshGetInstanceCount(RID multimesh)
        {
            return NativeCalls.godot_icall_1_643(method_bind_72, ptr, RID.GetPtr(multimesh));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_73 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "multimesh_set_mesh");

        /// <summary>
        /// <para>Sets the mesh to be drawn by the multimesh. Equivalent to <see cref="Godot.MultiMesh.Mesh"/>.</para>
        /// </summary>
        [GodotMethod("multimesh_set_mesh")]
        public static void MultimeshSetMesh(RID multimesh, RID mesh)
        {
            NativeCalls.godot_icall_2_637(method_bind_73, ptr, RID.GetPtr(multimesh), RID.GetPtr(mesh));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_74 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "multimesh_instance_set_transform");

        /// <summary>
        /// <para>Sets the <see cref="Godot.Transform"/> for this instance. Equivalent to <see cref="Godot.MultiMesh.SetInstanceTransform"/>.</para>
        /// </summary>
        [GodotMethod("multimesh_instance_set_transform")]
        public static void MultimeshInstanceSetTransform(RID multimesh, int index, Transform transform)
        {
            NativeCalls.godot_icall_3_778(method_bind_74, ptr, RID.GetPtr(multimesh), index, ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_75 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "multimesh_instance_set_transform_2d");

        /// <summary>
        /// <para>Sets the <see cref="Godot.Transform2D"/> for this instance. For use when multimesh is used in 2D. Equivalent to <see cref="Godot.MultiMesh.SetInstanceTransform2d"/>.</para>
        /// </summary>
        [GodotMethod("multimesh_instance_set_transform_2d")]
        public static void MultimeshInstanceSetTransform2d(RID multimesh, int index, Transform2D transform)
        {
            NativeCalls.godot_icall_3_750(method_bind_75, ptr, RID.GetPtr(multimesh), index, ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_76 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "multimesh_instance_set_color");

        /// <summary>
        /// <para>Sets the color by which this instance will be modulated. Equivalent to <see cref="Godot.MultiMesh.SetInstanceColor"/>.</para>
        /// </summary>
        [GodotMethod("multimesh_instance_set_color")]
        public static void MultimeshInstanceSetColor(RID multimesh, int index, Color color)
        {
            NativeCalls.godot_icall_3_1074(method_bind_76, ptr, RID.GetPtr(multimesh), index, ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_77 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "multimesh_instance_set_custom_data");

        /// <summary>
        /// <para>Sets the custom data for this instance. Custom data is passed as a <see cref="Godot.Color"/>, but is interpreted as a <c>vec4</c> in the shader. Equivalent to <see cref="Godot.MultiMesh.SetInstanceCustomData"/>.</para>
        /// </summary>
        [GodotMethod("multimesh_instance_set_custom_data")]
        public static void MultimeshInstanceSetCustomData(RID multimesh, int index, Color customData)
        {
            NativeCalls.godot_icall_3_1074(method_bind_77, ptr, RID.GetPtr(multimesh), index, ref customData);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_78 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "multimesh_get_mesh");

        /// <summary>
        /// <para>Returns the RID of the mesh that will be used in drawing this multimesh.</para>
        /// </summary>
        [GodotMethod("multimesh_get_mesh")]
        public static RID MultimeshGetMesh(RID multimesh)
        {
            return new RID(NativeCalls.godot_icall_1_638(method_bind_78, ptr, RID.GetPtr(multimesh)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_79 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "multimesh_get_aabb");

        /// <summary>
        /// <para>Calculates and returns the axis-aligned bounding box that encloses all instances within the multimesh.</para>
        /// </summary>
        [GodotMethod("multimesh_get_aabb")]
        public static AABB MultimeshGetAabb(RID multimesh)
        {
            NativeCalls.godot_icall_1_1072(method_bind_79, ptr, RID.GetPtr(multimesh), out AABB argRet); return (AABB)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_80 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "multimesh_instance_get_transform");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Transform"/> of the specified instance.</para>
        /// </summary>
        [GodotMethod("multimesh_instance_get_transform")]
        public static Transform MultimeshInstanceGetTransform(RID multimesh, int index)
        {
            NativeCalls.godot_icall_2_779(method_bind_80, ptr, RID.GetPtr(multimesh), index, out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_81 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "multimesh_instance_get_transform_2d");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Transform2D"/> of the specified instance. For use when the multimesh is set to use 2D transforms.</para>
        /// </summary>
        [GodotMethod("multimesh_instance_get_transform_2d")]
        public static Transform2D MultimeshInstanceGetTransform2d(RID multimesh, int index)
        {
            NativeCalls.godot_icall_2_753(method_bind_81, ptr, RID.GetPtr(multimesh), index, out Transform2D argRet); return (Transform2D)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_82 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "multimesh_instance_get_color");

        /// <summary>
        /// <para>Returns the color by which the specified instance will be modulated.</para>
        /// </summary>
        [GodotMethod("multimesh_instance_get_color")]
        public static Color MultimeshInstanceGetColor(RID multimesh, int index)
        {
            NativeCalls.godot_icall_2_1075(method_bind_82, ptr, RID.GetPtr(multimesh), index, out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_83 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "multimesh_instance_get_custom_data");

        /// <summary>
        /// <para>Returns the custom data associated with the specified instance.</para>
        /// </summary>
        [GodotMethod("multimesh_instance_get_custom_data")]
        public static Color MultimeshInstanceGetCustomData(RID multimesh, int index)
        {
            NativeCalls.godot_icall_2_1075(method_bind_83, ptr, RID.GetPtr(multimesh), index, out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_84 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "multimesh_set_visible_instances");

        /// <summary>
        /// <para>Sets the number of instances visible at a given time. If -1, all instances that have been allocated are drawn. Equivalent to <see cref="Godot.MultiMesh.VisibleInstanceCount"/>.</para>
        /// </summary>
        [GodotMethod("multimesh_set_visible_instances")]
        public static void MultimeshSetVisibleInstances(RID multimesh, int visible)
        {
            NativeCalls.godot_icall_2_645(method_bind_84, ptr, RID.GetPtr(multimesh), visible);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_85 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "multimesh_get_visible_instances");

        /// <summary>
        /// <para>Returns the number of visible instances for this multimesh.</para>
        /// </summary>
        [GodotMethod("multimesh_get_visible_instances")]
        public static int MultimeshGetVisibleInstances(RID multimesh)
        {
            return NativeCalls.godot_icall_1_643(method_bind_85, ptr, RID.GetPtr(multimesh));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_86 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "multimesh_set_as_bulk_array");

        /// <summary>
        /// <para>Sets all data related to the instances in one go. This is especially useful when loading the data from disk or preparing the data from GDNative.</para>
        /// <para></para>
        /// <para>All data is packed in one large float array. An array may look like this: Transform for instance 1, color data for instance 1, custom data for instance 1, transform for instance 2, color data for instance 2, etc.</para>
        /// <para></para>
        /// <para><see cref="Godot.Transform"/> is stored as 12 floats, <see cref="Godot.Transform2D"/> is stored as 8 floats, <c>COLOR_8BIT</c> / <c>CUSTOM_DATA_8BIT</c> is stored as 1 float (4 bytes as is) and <c>COLOR_FLOAT</c> / <c>CUSTOM_DATA_FLOAT</c> is stored as 4 floats.</para>
        /// </summary>
        [GodotMethod("multimesh_set_as_bulk_array")]
        public static void MultimeshSetAsBulkArray(RID multimesh, float[] array)
        {
            NativeCalls.godot_icall_2_1076(method_bind_86, ptr, RID.GetPtr(multimesh), array);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_87 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "immediate_create");

        /// <summary>
        /// <para>Creates an immediate geometry and adds it to the VisualServer. It can be accessed with the RID that is returned. This RID will be used in all <c>immediate_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// <para>To place in a scene, attach this immediate geometry to an instance using <see cref="Godot.VisualServer.InstanceSetBase"/> using the returned RID.</para>
        /// </summary>
        [GodotMethod("immediate_create")]
        public static RID ImmediateCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_87, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_88 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "immediate_begin");

        /// <summary>
        /// <para>Sets up <see cref="Godot.ImmediateGeometry"/> internals to prepare for drawing. Equivalent to <see cref="Godot.ImmediateGeometry.Begin"/>.</para>
        /// </summary>
        [GodotMethod("immediate_begin")]
        public static void ImmediateBegin(RID immediate, VisualServer.PrimitiveType primitive, RID texture = null)
        {
            NativeCalls.godot_icall_3_749(method_bind_88, ptr, RID.GetPtr(immediate), (int)primitive, RID.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_89 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "immediate_vertex");

        /// <summary>
        /// <para>Adds the next vertex using the information provided in advance. Equivalent to <see cref="Godot.ImmediateGeometry.AddVertex"/>.</para>
        /// </summary>
        [GodotMethod("immediate_vertex")]
        public static void ImmediateVertex(RID immediate, Vector3 vertex)
        {
            NativeCalls.godot_icall_2_656(method_bind_89, ptr, RID.GetPtr(immediate), ref vertex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_90 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "immediate_vertex_2d");

        /// <summary>
        /// <para>Adds the next vertex using the information provided in advance. This is a helper class that calls <see cref="Godot.VisualServer.ImmediateVertex"/> under the hood. Equivalent to <see cref="Godot.ImmediateGeometry.AddVertex"/>.</para>
        /// </summary>
        [GodotMethod("immediate_vertex_2d")]
        public static void ImmediateVertex2d(RID immediate, Vector2 vertex)
        {
            NativeCalls.godot_icall_2_646(method_bind_90, ptr, RID.GetPtr(immediate), ref vertex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_91 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "immediate_normal");

        /// <summary>
        /// <para>Sets the normal to be used with next vertex. Equivalent to <see cref="Godot.ImmediateGeometry.SetNormal"/>.</para>
        /// </summary>
        [GodotMethod("immediate_normal")]
        public static void ImmediateNormal(RID immediate, Vector3 normal)
        {
            NativeCalls.godot_icall_2_656(method_bind_91, ptr, RID.GetPtr(immediate), ref normal);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_92 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "immediate_tangent");

        /// <summary>
        /// <para>Sets the tangent to be used with next vertex. Equivalent to <see cref="Godot.ImmediateGeometry.SetTangent"/>.</para>
        /// </summary>
        [GodotMethod("immediate_tangent")]
        public static void ImmediateTangent(RID immediate, Plane tangent)
        {
            NativeCalls.godot_icall_2_1077(method_bind_92, ptr, RID.GetPtr(immediate), ref tangent);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_93 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "immediate_color");

        /// <summary>
        /// <para>Sets the color to be used with next vertex. Equivalent to <see cref="Godot.ImmediateGeometry.SetColor"/>.</para>
        /// </summary>
        [GodotMethod("immediate_color")]
        public static void ImmediateColor(RID immediate, Color color)
        {
            NativeCalls.godot_icall_2_858(method_bind_93, ptr, RID.GetPtr(immediate), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_94 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "immediate_uv");

        /// <summary>
        /// <para>Sets the UV to be used with next vertex. Equivalent to <see cref="Godot.ImmediateGeometry.SetUv"/>.</para>
        /// </summary>
        [GodotMethod("immediate_uv")]
        public static void ImmediateUv(RID immediate, Vector2 texUv)
        {
            NativeCalls.godot_icall_2_646(method_bind_94, ptr, RID.GetPtr(immediate), ref texUv);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_95 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "immediate_uv2");

        /// <summary>
        /// <para>Sets the UV2 to be used with next vertex. Equivalent to <see cref="Godot.ImmediateGeometry.SetUv2"/>.</para>
        /// </summary>
        [GodotMethod("immediate_uv2")]
        public static void ImmediateUv2(RID immediate, Vector2 texUv)
        {
            NativeCalls.godot_icall_2_646(method_bind_95, ptr, RID.GetPtr(immediate), ref texUv);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_96 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "immediate_end");

        /// <summary>
        /// <para>Ends drawing the <see cref="Godot.ImmediateGeometry"/> and displays it. Equivalent to <see cref="Godot.ImmediateGeometry.End"/>.</para>
        /// </summary>
        [GodotMethod("immediate_end")]
        public static void ImmediateEnd(RID immediate)
        {
            NativeCalls.godot_icall_1_285(method_bind_96, ptr, RID.GetPtr(immediate));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_97 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "immediate_clear");

        /// <summary>
        /// <para>Clears everything that was set up between <see cref="Godot.VisualServer.ImmediateBegin"/> and <see cref="Godot.VisualServer.ImmediateEnd"/>. Equivalent to <see cref="Godot.ImmediateGeometry.Clear"/>.</para>
        /// </summary>
        [GodotMethod("immediate_clear")]
        public static void ImmediateClear(RID immediate)
        {
            NativeCalls.godot_icall_1_285(method_bind_97, ptr, RID.GetPtr(immediate));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_98 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "immediate_set_material");

        /// <summary>
        /// <para>Sets the material to be used to draw the <see cref="Godot.ImmediateGeometry"/>.</para>
        /// </summary>
        [GodotMethod("immediate_set_material")]
        public static void ImmediateSetMaterial(RID immediate, RID material)
        {
            NativeCalls.godot_icall_2_637(method_bind_98, ptr, RID.GetPtr(immediate), RID.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_99 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "immediate_get_material");

        /// <summary>
        /// <para>Returns the material assigned to the <see cref="Godot.ImmediateGeometry"/>.</para>
        /// </summary>
        [GodotMethod("immediate_get_material")]
        public static RID ImmediateGetMaterial(RID immediate)
        {
            return new RID(NativeCalls.godot_icall_1_638(method_bind_99, ptr, RID.GetPtr(immediate)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_100 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "skeleton_create");

        /// <summary>
        /// <para>Creates a skeleton and adds it to the VisualServer. It can be accessed with the RID that is returned. This RID will be used in all <c>skeleton_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// </summary>
        [GodotMethod("skeleton_create")]
        public static RID SkeletonCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_100, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_101 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "skeleton_allocate");

        /// <summary>
        /// <para>Allocates the GPU buffers for this skeleton.</para>
        /// </summary>
        [GodotMethod("skeleton_allocate")]
        public static void SkeletonAllocate(RID skeleton, int bones, bool is2dSkeleton = false)
        {
            NativeCalls.godot_icall_3_751(method_bind_101, ptr, RID.GetPtr(skeleton), bones, is2dSkeleton);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_102 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "skeleton_get_bone_count");

        /// <summary>
        /// <para>Returns the number of bones allocated for this skeleton.</para>
        /// </summary>
        [GodotMethod("skeleton_get_bone_count")]
        public static int SkeletonGetBoneCount(RID skeleton)
        {
            return NativeCalls.godot_icall_1_643(method_bind_102, ptr, RID.GetPtr(skeleton));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_103 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "skeleton_bone_set_transform");

        /// <summary>
        /// <para>Sets the <see cref="Godot.Transform"/> for a specific bone of this skeleton.</para>
        /// </summary>
        [GodotMethod("skeleton_bone_set_transform")]
        public static void SkeletonBoneSetTransform(RID skeleton, int bone, Transform transform)
        {
            NativeCalls.godot_icall_3_778(method_bind_103, ptr, RID.GetPtr(skeleton), bone, ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_104 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "skeleton_bone_get_transform");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Transform"/> set for a specific bone of this skeleton.</para>
        /// </summary>
        [GodotMethod("skeleton_bone_get_transform")]
        public static Transform SkeletonBoneGetTransform(RID skeleton, int bone)
        {
            NativeCalls.godot_icall_2_779(method_bind_104, ptr, RID.GetPtr(skeleton), bone, out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_105 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "skeleton_bone_set_transform_2d");

        /// <summary>
        /// <para>Sets the <see cref="Godot.Transform2D"/> for a specific bone of this skeleton.</para>
        /// </summary>
        [GodotMethod("skeleton_bone_set_transform_2d")]
        public static void SkeletonBoneSetTransform2d(RID skeleton, int bone, Transform2D transform)
        {
            NativeCalls.godot_icall_3_750(method_bind_105, ptr, RID.GetPtr(skeleton), bone, ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_106 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "skeleton_bone_get_transform_2d");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Transform2D"/> set for a specific bone of this skeleton.</para>
        /// </summary>
        [GodotMethod("skeleton_bone_get_transform_2d")]
        public static Transform2D SkeletonBoneGetTransform2d(RID skeleton, int bone)
        {
            NativeCalls.godot_icall_2_753(method_bind_106, ptr, RID.GetPtr(skeleton), bone, out Transform2D argRet); return (Transform2D)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_107 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "directional_light_create");

        /// <summary>
        /// <para>Creates a directional light and adds it to the VisualServer. It can be accessed with the RID that is returned. This RID can be used in most <c>light_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// <para>To place in a scene, attach this directional light to an instance using <see cref="Godot.VisualServer.InstanceSetBase"/> using the returned RID.</para>
        /// </summary>
        [GodotMethod("directional_light_create")]
        public static RID DirectionalLightCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_107, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_108 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "omni_light_create");

        /// <summary>
        /// <para>Creates a new omni light and adds it to the VisualServer. It can be accessed with the RID that is returned. This RID can be used in most <c>light_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// <para>To place in a scene, attach this omni light to an instance using <see cref="Godot.VisualServer.InstanceSetBase"/> using the returned RID.</para>
        /// </summary>
        [GodotMethod("omni_light_create")]
        public static RID OmniLightCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_108, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_109 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "spot_light_create");

        /// <summary>
        /// <para>Creates a spot light and adds it to the VisualServer. It can be accessed with the RID that is returned. This RID can be used in most <c>light_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// <para>To place in a scene, attach this spot light to an instance using <see cref="Godot.VisualServer.InstanceSetBase"/> using the returned RID.</para>
        /// </summary>
        [GodotMethod("spot_light_create")]
        public static RID SpotLightCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_109, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_110 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "light_set_color");

        /// <summary>
        /// <para>Sets the color of the light. Equivalent to <see cref="Godot.Light.LightColor"/>.</para>
        /// </summary>
        [GodotMethod("light_set_color")]
        public static void LightSetColor(RID light, Color color)
        {
            NativeCalls.godot_icall_2_858(method_bind_110, ptr, RID.GetPtr(light), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_111 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "light_set_param");

        /// <summary>
        /// <para>Sets the specified light parameter. See <see cref="Godot.VisualServer.LightParam"/> for options. Equivalent to <see cref="Godot.Light.SetParam"/>.</para>
        /// </summary>
        [GodotMethod("light_set_param")]
        public static void LightSetParam(RID light, VisualServer.LightParam param, float value)
        {
            NativeCalls.godot_icall_3_744(method_bind_111, ptr, RID.GetPtr(light), (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_112 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "light_set_shadow");

        /// <summary>
        /// <para>If <c>true</c>, light will cast shadows. Equivalent to <see cref="Godot.Light.ShadowEnabled"/>.</para>
        /// </summary>
        [GodotMethod("light_set_shadow")]
        public static void LightSetShadow(RID light, bool enabled)
        {
            NativeCalls.godot_icall_2_628(method_bind_112, ptr, RID.GetPtr(light), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_113 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "light_set_shadow_color");

        /// <summary>
        /// <para>Sets the color of the shadow cast by the light. Equivalent to <see cref="Godot.Light.ShadowColor"/>.</para>
        /// </summary>
        [GodotMethod("light_set_shadow_color")]
        public static void LightSetShadowColor(RID light, Color color)
        {
            NativeCalls.godot_icall_2_858(method_bind_113, ptr, RID.GetPtr(light), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_114 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "light_set_projector");

        /// <summary>
        /// <para>Not implemented in Godot 3.x.</para>
        /// </summary>
        [GodotMethod("light_set_projector")]
        public static void LightSetProjector(RID light, RID texture)
        {
            NativeCalls.godot_icall_2_637(method_bind_114, ptr, RID.GetPtr(light), RID.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_115 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "light_set_negative");

        /// <summary>
        /// <para>If <c>true</c>, light will subtract light instead of adding light. Equivalent to <see cref="Godot.Light.LightNegative"/>.</para>
        /// </summary>
        [GodotMethod("light_set_negative")]
        public static void LightSetNegative(RID light, bool enable)
        {
            NativeCalls.godot_icall_2_628(method_bind_115, ptr, RID.GetPtr(light), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_116 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "light_set_cull_mask");

        /// <summary>
        /// <para>Sets the cull mask for this Light. Lights only affect objects in the selected layers. Equivalent to <see cref="Godot.Light.LightCullMask"/>.</para>
        /// </summary>
        [GodotMethod("light_set_cull_mask")]
        public static void LightSetCullMask(RID light, uint mask)
        {
            NativeCalls.godot_icall_2_639(method_bind_116, ptr, RID.GetPtr(light), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_117 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "light_set_reverse_cull_face_mode");

        /// <summary>
        /// <para>If <c>true</c>, reverses the backface culling of the mesh. This can be useful when you have a flat mesh that has a light behind it. If you need to cast a shadow on both sides of the mesh, set the mesh to use double sided shadows with <see cref="Godot.VisualServer.InstanceGeometrySetCastShadowsSetting"/>. Equivalent to <see cref="Godot.Light.ShadowReverseCullFace"/>.</para>
        /// </summary>
        [GodotMethod("light_set_reverse_cull_face_mode")]
        public static void LightSetReverseCullFaceMode(RID light, bool enabled)
        {
            NativeCalls.godot_icall_2_628(method_bind_117, ptr, RID.GetPtr(light), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_118 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "light_set_use_gi");

        /// <summary>
        /// <para>Sets whether GI probes capture light information from this light. Deprecated method. Use <see cref="Godot.VisualServer.LightSetBakeMode"/> instead. This method is only kept for compatibility reasons and calls <see cref="Godot.VisualServer.LightSetBakeMode"/> internally, setting the bake mode to <see cref="Godot.VisualServer.LightBakeMode.Disabled"/> or <see cref="Godot.VisualServer.LightBakeMode.Indirect"/> depending on the given parameter.</para>
        /// </summary>
        [GodotMethod("light_set_use_gi")]
        public static void LightSetUseGi(RID light, bool enabled)
        {
            NativeCalls.godot_icall_2_628(method_bind_118, ptr, RID.GetPtr(light), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_119 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "light_set_bake_mode");

        /// <summary>
        /// <para>Sets the bake mode for this light, see <see cref="Godot.VisualServer.LightBakeMode"/> for options. The bake mode affects how the light will be baked in <see cref="Godot.BakedLightmap"/>s and <see cref="Godot.GIProbe"/>s.</para>
        /// </summary>
        [GodotMethod("light_set_bake_mode")]
        public static void LightSetBakeMode(RID light, VisualServer.LightBakeMode bakeMode)
        {
            NativeCalls.godot_icall_2_645(method_bind_119, ptr, RID.GetPtr(light), (int)bakeMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_120 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "light_omni_set_shadow_mode");

        /// <summary>
        /// <para>Sets whether to use a dual paraboloid or a cubemap for the shadow map. Dual paraboloid is faster but may suffer from artifacts. Equivalent to <see cref="Godot.OmniLight.OmniShadowMode"/>.</para>
        /// </summary>
        [GodotMethod("light_omni_set_shadow_mode")]
        public static void LightOmniSetShadowMode(RID light, VisualServer.LightOmniShadowMode mode)
        {
            NativeCalls.godot_icall_2_645(method_bind_120, ptr, RID.GetPtr(light), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_121 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "light_omni_set_shadow_detail");

        /// <summary>
        /// <para>Sets whether to use vertical or horizontal detail for this omni light. This can be used to alleviate artifacts in the shadow map. Equivalent to <see cref="Godot.OmniLight.OmniShadowDetail"/>.</para>
        /// </summary>
        [GodotMethod("light_omni_set_shadow_detail")]
        public static void LightOmniSetShadowDetail(RID light, VisualServer.LightOmniShadowDetail detail)
        {
            NativeCalls.godot_icall_2_645(method_bind_121, ptr, RID.GetPtr(light), (int)detail);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_122 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "light_directional_set_shadow_mode");

        /// <summary>
        /// <para>Sets the shadow mode for this directional light. Equivalent to <see cref="Godot.DirectionalLight.DirectionalShadowMode"/>. See <see cref="Godot.VisualServer.LightDirectionalShadowMode"/> for options.</para>
        /// </summary>
        [GodotMethod("light_directional_set_shadow_mode")]
        public static void LightDirectionalSetShadowMode(RID light, VisualServer.LightDirectionalShadowMode mode)
        {
            NativeCalls.godot_icall_2_645(method_bind_122, ptr, RID.GetPtr(light), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_123 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "light_directional_set_blend_splits");

        /// <summary>
        /// <para>If <c>true</c>, this directional light will blend between shadow map splits resulting in a smoother transition between them. Equivalent to <see cref="Godot.DirectionalLight.DirectionalShadowBlendSplits"/>.</para>
        /// </summary>
        [GodotMethod("light_directional_set_blend_splits")]
        public static void LightDirectionalSetBlendSplits(RID light, bool enable)
        {
            NativeCalls.godot_icall_2_628(method_bind_123, ptr, RID.GetPtr(light), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_124 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "light_directional_set_shadow_depth_range_mode");

        /// <summary>
        /// <para>Sets the shadow depth range mode for this directional light. Equivalent to <see cref="Godot.DirectionalLight.DirectionalShadowDepthRange"/>. See <see cref="Godot.VisualServer.LightDirectionalShadowDepthRangeMode"/> for options.</para>
        /// </summary>
        [GodotMethod("light_directional_set_shadow_depth_range_mode")]
        public static void LightDirectionalSetShadowDepthRangeMode(RID light, VisualServer.LightDirectionalShadowDepthRangeMode rangeMode)
        {
            NativeCalls.godot_icall_2_645(method_bind_124, ptr, RID.GetPtr(light), (int)rangeMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_125 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reflection_probe_create");

        /// <summary>
        /// <para>Creates a reflection probe and adds it to the VisualServer. It can be accessed with the RID that is returned. This RID will be used in all <c>reflection_probe_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// <para>To place in a scene, attach this reflection probe to an instance using <see cref="Godot.VisualServer.InstanceSetBase"/> using the returned RID.</para>
        /// </summary>
        [GodotMethod("reflection_probe_create")]
        public static RID ReflectionProbeCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_125, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_126 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reflection_probe_set_update_mode");

        /// <summary>
        /// <para>Sets how often the reflection probe updates. Can either be once or every frame. See <see cref="Godot.VisualServer.ReflectionProbeUpdateMode"/> for options.</para>
        /// </summary>
        [GodotMethod("reflection_probe_set_update_mode")]
        public static void ReflectionProbeSetUpdateMode(RID probe, VisualServer.ReflectionProbeUpdateMode mode)
        {
            NativeCalls.godot_icall_2_645(method_bind_126, ptr, RID.GetPtr(probe), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_127 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reflection_probe_set_intensity");

        /// <summary>
        /// <para>Sets the intensity of the reflection probe. Intensity modulates the strength of the reflection. Equivalent to <see cref="Godot.ReflectionProbe.Intensity"/>.</para>
        /// </summary>
        [GodotMethod("reflection_probe_set_intensity")]
        public static void ReflectionProbeSetIntensity(RID probe, float intensity)
        {
            NativeCalls.godot_icall_2_630(method_bind_127, ptr, RID.GetPtr(probe), intensity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_128 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reflection_probe_set_interior_ambient");

        /// <summary>
        /// <para>Sets the ambient light color for this reflection probe when set to interior mode. Equivalent to <see cref="Godot.ReflectionProbe.InteriorAmbientColor"/>.</para>
        /// </summary>
        [GodotMethod("reflection_probe_set_interior_ambient")]
        public static void ReflectionProbeSetInteriorAmbient(RID probe, Color color)
        {
            NativeCalls.godot_icall_2_858(method_bind_128, ptr, RID.GetPtr(probe), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_129 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reflection_probe_set_interior_ambient_energy");

        /// <summary>
        /// <para>Sets the energy multiplier for this reflection probes ambient light contribution when set to interior mode. Equivalent to <see cref="Godot.ReflectionProbe.InteriorAmbientEnergy"/>.</para>
        /// </summary>
        [GodotMethod("reflection_probe_set_interior_ambient_energy")]
        public static void ReflectionProbeSetInteriorAmbientEnergy(RID probe, float energy)
        {
            NativeCalls.godot_icall_2_630(method_bind_129, ptr, RID.GetPtr(probe), energy);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_130 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reflection_probe_set_interior_ambient_probe_contribution");

        /// <summary>
        /// <para>Sets the contribution value for how much the reflection affects the ambient light for this reflection probe when set to interior mode. Useful so that ambient light matches the color of the room. Equivalent to <see cref="Godot.ReflectionProbe.InteriorAmbientContrib"/>.</para>
        /// </summary>
        [GodotMethod("reflection_probe_set_interior_ambient_probe_contribution")]
        public static void ReflectionProbeSetInteriorAmbientProbeContribution(RID probe, float contrib)
        {
            NativeCalls.godot_icall_2_630(method_bind_130, ptr, RID.GetPtr(probe), contrib);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_131 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reflection_probe_set_max_distance");

        /// <summary>
        /// <para>Sets the max distance away from the probe an object can be before it is culled. Equivalent to <see cref="Godot.ReflectionProbe.MaxDistance"/>.</para>
        /// </summary>
        [GodotMethod("reflection_probe_set_max_distance")]
        public static void ReflectionProbeSetMaxDistance(RID probe, float distance)
        {
            NativeCalls.godot_icall_2_630(method_bind_131, ptr, RID.GetPtr(probe), distance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_132 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reflection_probe_set_extents");

        /// <summary>
        /// <para>Sets the size of the area that the reflection probe will capture. Equivalent to <see cref="Godot.ReflectionProbe.Extents"/>.</para>
        /// </summary>
        [GodotMethod("reflection_probe_set_extents")]
        public static void ReflectionProbeSetExtents(RID probe, Vector3 extents)
        {
            NativeCalls.godot_icall_2_656(method_bind_132, ptr, RID.GetPtr(probe), ref extents);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_133 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reflection_probe_set_origin_offset");

        /// <summary>
        /// <para>Sets the origin offset to be used when this reflection probe is in box project mode. Equivalent to <see cref="Godot.ReflectionProbe.OriginOffset"/>.</para>
        /// </summary>
        [GodotMethod("reflection_probe_set_origin_offset")]
        public static void ReflectionProbeSetOriginOffset(RID probe, Vector3 offset)
        {
            NativeCalls.godot_icall_2_656(method_bind_133, ptr, RID.GetPtr(probe), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_134 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reflection_probe_set_as_interior");

        /// <summary>
        /// <para>If <c>true</c>, reflections will ignore sky contribution. Equivalent to <see cref="Godot.ReflectionProbe.InteriorEnable"/>.</para>
        /// </summary>
        [GodotMethod("reflection_probe_set_as_interior")]
        public static void ReflectionProbeSetAsInterior(RID probe, bool enable)
        {
            NativeCalls.godot_icall_2_628(method_bind_134, ptr, RID.GetPtr(probe), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_135 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reflection_probe_set_enable_box_projection");

        /// <summary>
        /// <para>If <c>true</c>, uses box projection. This can make reflections look more correct in certain situations. Equivalent to <see cref="Godot.ReflectionProbe.BoxProjection"/>.</para>
        /// </summary>
        [GodotMethod("reflection_probe_set_enable_box_projection")]
        public static void ReflectionProbeSetEnableBoxProjection(RID probe, bool enable)
        {
            NativeCalls.godot_icall_2_628(method_bind_135, ptr, RID.GetPtr(probe), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_136 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reflection_probe_set_enable_shadows");

        /// <summary>
        /// <para>If <c>true</c>, computes shadows in the reflection probe. This makes the reflection much slower to compute. Equivalent to <see cref="Godot.ReflectionProbe.EnableShadows"/>.</para>
        /// </summary>
        [GodotMethod("reflection_probe_set_enable_shadows")]
        public static void ReflectionProbeSetEnableShadows(RID probe, bool enable)
        {
            NativeCalls.godot_icall_2_628(method_bind_136, ptr, RID.GetPtr(probe), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_137 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reflection_probe_set_cull_mask");

        /// <summary>
        /// <para>Sets the render cull mask for this reflection probe. Only instances with a matching cull mask will be rendered by this probe. Equivalent to <see cref="Godot.ReflectionProbe.CullMask"/>.</para>
        /// </summary>
        [GodotMethod("reflection_probe_set_cull_mask")]
        public static void ReflectionProbeSetCullMask(RID probe, uint layers)
        {
            NativeCalls.godot_icall_2_639(method_bind_137, ptr, RID.GetPtr(probe), layers);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_138 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gi_probe_create");

        /// <summary>
        /// <para>Creates a GI probe and adds it to the VisualServer. It can be accessed with the RID that is returned. This RID will be used in all <c>gi_probe_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// <para>To place in a scene, attach this GI probe to an instance using <see cref="Godot.VisualServer.InstanceSetBase"/> using the returned RID.</para>
        /// </summary>
        [GodotMethod("gi_probe_create")]
        public static RID GiProbeCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_138, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_139 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gi_probe_set_bounds");

        /// <summary>
        /// <para>Sets the axis-aligned bounding box that covers the extent of the GI probe.</para>
        /// </summary>
        [GodotMethod("gi_probe_set_bounds")]
        public static void GiProbeSetBounds(RID probe, AABB bounds)
        {
            NativeCalls.godot_icall_2_1071(method_bind_139, ptr, RID.GetPtr(probe), ref bounds);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_140 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gi_probe_get_bounds");

        /// <summary>
        /// <para>Returns the axis-aligned bounding box that covers the full extent of the GI probe.</para>
        /// </summary>
        [GodotMethod("gi_probe_get_bounds")]
        public static AABB GiProbeGetBounds(RID probe)
        {
            NativeCalls.godot_icall_1_1072(method_bind_140, ptr, RID.GetPtr(probe), out AABB argRet); return (AABB)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_141 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gi_probe_set_cell_size");

        /// <summary>
        /// <para>Sets the size of individual cells within the GI probe.</para>
        /// </summary>
        [GodotMethod("gi_probe_set_cell_size")]
        public static void GiProbeSetCellSize(RID probe, float range)
        {
            NativeCalls.godot_icall_2_630(method_bind_141, ptr, RID.GetPtr(probe), range);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_142 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gi_probe_get_cell_size");

        /// <summary>
        /// <para>Returns the cell size set by <see cref="Godot.VisualServer.GiProbeSetCellSize"/>.</para>
        /// </summary>
        [GodotMethod("gi_probe_get_cell_size")]
        public static float GiProbeGetCellSize(RID probe)
        {
            return NativeCalls.godot_icall_1_631(method_bind_142, ptr, RID.GetPtr(probe));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_143 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gi_probe_set_to_cell_xform");

        /// <summary>
        /// <para>Sets the to cell <see cref="Godot.Transform"/> for this GI probe.</para>
        /// </summary>
        [GodotMethod("gi_probe_set_to_cell_xform")]
        public static void GiProbeSetToCellXform(RID probe, Transform xform)
        {
            NativeCalls.godot_icall_2_663(method_bind_143, ptr, RID.GetPtr(probe), ref xform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_144 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gi_probe_get_to_cell_xform");

        /// <summary>
        /// <para>Returns the Transform set by <see cref="Godot.VisualServer.GiProbeSetToCellXform"/>.</para>
        /// </summary>
        [GodotMethod("gi_probe_get_to_cell_xform")]
        public static Transform GiProbeGetToCellXform(RID probe)
        {
            NativeCalls.godot_icall_1_780(method_bind_144, ptr, RID.GetPtr(probe), out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_145 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gi_probe_set_dynamic_data");

        /// <summary>
        /// <para>Sets the data to be used in the GI probe for lighting calculations. Normally this is created and called internally within the <see cref="Godot.GIProbe"/> node. You should not try to set this yourself.</para>
        /// </summary>
        [GodotMethod("gi_probe_set_dynamic_data")]
        public static void GiProbeSetDynamicData(RID probe, int[] data)
        {
            NativeCalls.godot_icall_2_1078(method_bind_145, ptr, RID.GetPtr(probe), data);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_146 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gi_probe_get_dynamic_data");

        /// <summary>
        /// <para>Returns the data used by the GI probe.</para>
        /// </summary>
        [GodotMethod("gi_probe_get_dynamic_data")]
        public static int[] GiProbeGetDynamicData(RID probe)
        {
            return NativeCalls.godot_icall_1_1079(method_bind_146, ptr, RID.GetPtr(probe));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_147 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gi_probe_set_dynamic_range");

        /// <summary>
        /// <para>Sets the dynamic range of the GI probe. Dynamic range sets the limit for how bright lights can be. A smaller range captures greater detail but limits how bright lights can be. Equivalent to <see cref="Godot.GIProbe.DynamicRange"/>.</para>
        /// </summary>
        [GodotMethod("gi_probe_set_dynamic_range")]
        public static void GiProbeSetDynamicRange(RID probe, int range)
        {
            NativeCalls.godot_icall_2_645(method_bind_147, ptr, RID.GetPtr(probe), range);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_148 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gi_probe_get_dynamic_range");

        /// <summary>
        /// <para>Returns the dynamic range set for this GI probe. Equivalent to <see cref="Godot.GIProbe.DynamicRange"/>.</para>
        /// </summary>
        [GodotMethod("gi_probe_get_dynamic_range")]
        public static int GiProbeGetDynamicRange(RID probe)
        {
            return NativeCalls.godot_icall_1_643(method_bind_148, ptr, RID.GetPtr(probe));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_149 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gi_probe_set_energy");

        /// <summary>
        /// <para>Sets the energy multiplier for this GI probe. A higher energy makes the indirect light from the GI probe brighter. Equivalent to <see cref="Godot.GIProbe.Energy"/>.</para>
        /// </summary>
        [GodotMethod("gi_probe_set_energy")]
        public static void GiProbeSetEnergy(RID probe, float energy)
        {
            NativeCalls.godot_icall_2_630(method_bind_149, ptr, RID.GetPtr(probe), energy);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_150 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gi_probe_get_energy");

        /// <summary>
        /// <para>Returns the energy multiplier for this GI probe. Equivalent to <see cref="Godot.GIProbe.Energy"/>.</para>
        /// </summary>
        [GodotMethod("gi_probe_get_energy")]
        public static float GiProbeGetEnergy(RID probe)
        {
            return NativeCalls.godot_icall_1_631(method_bind_150, ptr, RID.GetPtr(probe));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_151 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gi_probe_set_bias");

        /// <summary>
        /// <para>Sets the bias value to avoid self-occlusion. Equivalent to <see cref="Godot.GIProbe.Bias"/>.</para>
        /// </summary>
        [GodotMethod("gi_probe_set_bias")]
        public static void GiProbeSetBias(RID probe, float bias)
        {
            NativeCalls.godot_icall_2_630(method_bind_151, ptr, RID.GetPtr(probe), bias);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_152 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gi_probe_get_bias");

        /// <summary>
        /// <para>Returns the bias value for the GI probe. Bias is used to avoid self occlusion. Equivalent to <see cref="Godot.GIProbeData.Bias"/>.</para>
        /// </summary>
        [GodotMethod("gi_probe_get_bias")]
        public static float GiProbeGetBias(RID probe)
        {
            return NativeCalls.godot_icall_1_631(method_bind_152, ptr, RID.GetPtr(probe));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_153 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gi_probe_set_normal_bias");

        /// <summary>
        /// <para>Sets the normal bias for this GI probe. Normal bias behaves similar to the other form of bias and may help reduce self-occlusion. Equivalent to <see cref="Godot.GIProbe.NormalBias"/>.</para>
        /// </summary>
        [GodotMethod("gi_probe_set_normal_bias")]
        public static void GiProbeSetNormalBias(RID probe, float bias)
        {
            NativeCalls.godot_icall_2_630(method_bind_153, ptr, RID.GetPtr(probe), bias);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_154 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gi_probe_get_normal_bias");

        /// <summary>
        /// <para>Returns the normal bias for this GI probe. Equivalent to <see cref="Godot.GIProbe.NormalBias"/>.</para>
        /// </summary>
        [GodotMethod("gi_probe_get_normal_bias")]
        public static float GiProbeGetNormalBias(RID probe)
        {
            return NativeCalls.godot_icall_1_631(method_bind_154, ptr, RID.GetPtr(probe));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_155 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gi_probe_set_propagation");

        /// <summary>
        /// <para>Sets the propagation of light within this GI probe. Equivalent to <see cref="Godot.GIProbe.Propagation"/>.</para>
        /// </summary>
        [GodotMethod("gi_probe_set_propagation")]
        public static void GiProbeSetPropagation(RID probe, float propagation)
        {
            NativeCalls.godot_icall_2_630(method_bind_155, ptr, RID.GetPtr(probe), propagation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_156 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gi_probe_get_propagation");

        /// <summary>
        /// <para>Returns the propagation value for this GI probe. Equivalent to <see cref="Godot.GIProbe.Propagation"/>.</para>
        /// </summary>
        [GodotMethod("gi_probe_get_propagation")]
        public static float GiProbeGetPropagation(RID probe)
        {
            return NativeCalls.godot_icall_1_631(method_bind_156, ptr, RID.GetPtr(probe));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_157 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gi_probe_set_interior");

        /// <summary>
        /// <para>Sets the interior value of this GI probe. A GI probe set to interior does not include the sky when calculating lighting. Equivalent to <see cref="Godot.GIProbe.Interior"/>.</para>
        /// </summary>
        [GodotMethod("gi_probe_set_interior")]
        public static void GiProbeSetInterior(RID probe, bool enable)
        {
            NativeCalls.godot_icall_2_628(method_bind_157, ptr, RID.GetPtr(probe), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_158 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gi_probe_is_interior");

        /// <summary>
        /// <para>Returns <c>true</c> if the GI probe is set to interior, meaning it does not account for sky light. Equivalent to <see cref="Godot.GIProbe.Interior"/>.</para>
        /// </summary>
        [GodotMethod("gi_probe_is_interior")]
        public static bool GiProbeIsInterior(RID probe)
        {
            return NativeCalls.godot_icall_1_629(method_bind_158, ptr, RID.GetPtr(probe));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_159 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gi_probe_set_compress");

        /// <summary>
        /// <para>Sets the compression setting for the GI probe data. Compressed data will take up less space but may look worse. Equivalent to <see cref="Godot.GIProbe.Compress"/>.</para>
        /// </summary>
        [GodotMethod("gi_probe_set_compress")]
        public static void GiProbeSetCompress(RID probe, bool enable)
        {
            NativeCalls.godot_icall_2_628(method_bind_159, ptr, RID.GetPtr(probe), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_160 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "gi_probe_is_compressed");

        /// <summary>
        /// <para>Returns <c>true</c> if the GI probe data associated with this GI probe is compressed. Equivalent to <see cref="Godot.GIProbe.Compress"/>.</para>
        /// </summary>
        [GodotMethod("gi_probe_is_compressed")]
        public static bool GiProbeIsCompressed(RID probe)
        {
            return NativeCalls.godot_icall_1_629(method_bind_160, ptr, RID.GetPtr(probe));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_161 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "lightmap_capture_create");

        /// <summary>
        /// <para>Creates a lightmap capture and adds it to the VisualServer. It can be accessed with the RID that is returned. This RID will be used in all <c>lightmap_capture_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// <para>To place in a scene, attach this lightmap capture to an instance using <see cref="Godot.VisualServer.InstanceSetBase"/> using the returned RID.</para>
        /// </summary>
        [GodotMethod("lightmap_capture_create")]
        public static RID LightmapCaptureCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_161, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_162 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "lightmap_capture_set_bounds");

        /// <summary>
        /// <para>Sets the size of the area covered by the lightmap capture. Equivalent to <see cref="Godot.BakedLightmapData.Bounds"/>.</para>
        /// </summary>
        [GodotMethod("lightmap_capture_set_bounds")]
        public static void LightmapCaptureSetBounds(RID capture, AABB bounds)
        {
            NativeCalls.godot_icall_2_1071(method_bind_162, ptr, RID.GetPtr(capture), ref bounds);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_163 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "lightmap_capture_get_bounds");

        /// <summary>
        /// <para>Returns the size of the lightmap capture area.</para>
        /// </summary>
        [GodotMethod("lightmap_capture_get_bounds")]
        public static AABB LightmapCaptureGetBounds(RID capture)
        {
            NativeCalls.godot_icall_1_1072(method_bind_163, ptr, RID.GetPtr(capture), out AABB argRet); return (AABB)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_164 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "lightmap_capture_set_octree");

        /// <summary>
        /// <para>Sets the octree to be used by this lightmap capture. This function is normally used by the <see cref="Godot.BakedLightmap"/> node. Equivalent to <see cref="Godot.BakedLightmapData.Octree"/>.</para>
        /// </summary>
        [GodotMethod("lightmap_capture_set_octree")]
        public static void LightmapCaptureSetOctree(RID capture, byte[] octree)
        {
            NativeCalls.godot_icall_2_1080(method_bind_164, ptr, RID.GetPtr(capture), octree);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_165 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "lightmap_capture_set_octree_cell_transform");

        /// <summary>
        /// <para>Sets the octree cell transform for this lightmap capture's octree. Equivalent to <see cref="Godot.BakedLightmapData.CellSpaceTransform"/>.</para>
        /// </summary>
        [GodotMethod("lightmap_capture_set_octree_cell_transform")]
        public static void LightmapCaptureSetOctreeCellTransform(RID capture, Transform xform)
        {
            NativeCalls.godot_icall_2_663(method_bind_165, ptr, RID.GetPtr(capture), ref xform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_166 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "lightmap_capture_get_octree_cell_transform");

        /// <summary>
        /// <para>Returns the cell transform for this lightmap capture's octree.</para>
        /// </summary>
        [GodotMethod("lightmap_capture_get_octree_cell_transform")]
        public static Transform LightmapCaptureGetOctreeCellTransform(RID capture)
        {
            NativeCalls.godot_icall_1_780(method_bind_166, ptr, RID.GetPtr(capture), out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_167 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "lightmap_capture_set_octree_cell_subdiv");

        /// <summary>
        /// <para>Sets the subdivision level of this lightmap capture's octree. Equivalent to <see cref="Godot.BakedLightmapData.CellSubdiv"/>.</para>
        /// </summary>
        [GodotMethod("lightmap_capture_set_octree_cell_subdiv")]
        public static void LightmapCaptureSetOctreeCellSubdiv(RID capture, int subdiv)
        {
            NativeCalls.godot_icall_2_645(method_bind_167, ptr, RID.GetPtr(capture), subdiv);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_168 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "lightmap_capture_get_octree_cell_subdiv");

        /// <summary>
        /// <para>Returns the cell subdivision amount used by this lightmap capture's octree.</para>
        /// </summary>
        [GodotMethod("lightmap_capture_get_octree_cell_subdiv")]
        public static int LightmapCaptureGetOctreeCellSubdiv(RID capture)
        {
            return NativeCalls.godot_icall_1_643(method_bind_168, ptr, RID.GetPtr(capture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_169 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "lightmap_capture_get_octree");

        /// <summary>
        /// <para>Returns the octree used by the lightmap capture.</para>
        /// </summary>
        [GodotMethod("lightmap_capture_get_octree")]
        public static byte[] LightmapCaptureGetOctree(RID capture)
        {
            return NativeCalls.godot_icall_1_1081(method_bind_169, ptr, RID.GetPtr(capture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_170 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "lightmap_capture_set_energy");

        /// <summary>
        /// <para>Sets the energy multiplier for this lightmap capture. Equivalent to <see cref="Godot.BakedLightmapData.Energy"/>.</para>
        /// </summary>
        [GodotMethod("lightmap_capture_set_energy")]
        public static void LightmapCaptureSetEnergy(RID capture, float energy)
        {
            NativeCalls.godot_icall_2_630(method_bind_170, ptr, RID.GetPtr(capture), energy);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_171 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "lightmap_capture_get_energy");

        /// <summary>
        /// <para>Returns the energy multiplier used by the lightmap capture.</para>
        /// </summary>
        [GodotMethod("lightmap_capture_get_energy")]
        public static float LightmapCaptureGetEnergy(RID capture)
        {
            return NativeCalls.godot_icall_1_631(method_bind_171, ptr, RID.GetPtr(capture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_172 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "lightmap_capture_set_interior");

        /// <summary>
        /// <para>Sets the "interior" mode for this lightmap capture. Equivalent to <see cref="Godot.BakedLightmapData.Interior"/>.</para>
        /// </summary>
        [GodotMethod("lightmap_capture_set_interior")]
        public static void LightmapCaptureSetInterior(RID capture, bool interior)
        {
            NativeCalls.godot_icall_2_628(method_bind_172, ptr, RID.GetPtr(capture), interior);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_173 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "lightmap_capture_is_interior");

        /// <summary>
        /// <para>Returns <c>true</c> if capture is in "interior" mode.</para>
        /// </summary>
        [GodotMethod("lightmap_capture_is_interior")]
        public static bool LightmapCaptureIsInterior(RID capture)
        {
            return NativeCalls.godot_icall_1_629(method_bind_173, ptr, RID.GetPtr(capture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_174 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "particles_create");

        /// <summary>
        /// <para>Creates a particle system and adds it to the VisualServer. It can be accessed with the RID that is returned. This RID will be used in all <c>particles_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// <para>To place in a scene, attach these particles to an instance using <see cref="Godot.VisualServer.InstanceSetBase"/> using the returned RID.</para>
        /// </summary>
        [GodotMethod("particles_create")]
        public static RID ParticlesCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_174, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_175 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "particles_set_emitting");

        /// <summary>
        /// <para>If <c>true</c>, particles will emit over time. Setting to false does not reset the particles, but only stops their emission. Equivalent to <see cref="Godot.Particles.Emitting"/>.</para>
        /// </summary>
        [GodotMethod("particles_set_emitting")]
        public static void ParticlesSetEmitting(RID particles, bool emitting)
        {
            NativeCalls.godot_icall_2_628(method_bind_175, ptr, RID.GetPtr(particles), emitting);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_176 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "particles_get_emitting");

        /// <summary>
        /// <para>Returns <c>true</c> if particles are currently set to emitting.</para>
        /// </summary>
        [GodotMethod("particles_get_emitting")]
        public static bool ParticlesGetEmitting(RID particles)
        {
            return NativeCalls.godot_icall_1_629(method_bind_176, ptr, RID.GetPtr(particles));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_177 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "particles_set_amount");

        /// <summary>
        /// <para>Sets the number of particles to be drawn and allocates the memory for them. Equivalent to <see cref="Godot.Particles.Amount"/>.</para>
        /// </summary>
        [GodotMethod("particles_set_amount")]
        public static void ParticlesSetAmount(RID particles, int amount)
        {
            NativeCalls.godot_icall_2_645(method_bind_177, ptr, RID.GetPtr(particles), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_178 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "particles_set_lifetime");

        /// <summary>
        /// <para>Sets the lifetime of each particle in the system. Equivalent to <see cref="Godot.Particles.Lifetime"/>.</para>
        /// </summary>
        [GodotMethod("particles_set_lifetime")]
        public static void ParticlesSetLifetime(RID particles, float lifetime)
        {
            NativeCalls.godot_icall_2_630(method_bind_178, ptr, RID.GetPtr(particles), lifetime);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_179 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "particles_set_one_shot");

        /// <summary>
        /// <para>If <c>true</c>, particles will emit once and then stop. Equivalent to <see cref="Godot.Particles.OneShot"/>.</para>
        /// </summary>
        [GodotMethod("particles_set_one_shot")]
        public static void ParticlesSetOneShot(RID particles, bool oneShot)
        {
            NativeCalls.godot_icall_2_628(method_bind_179, ptr, RID.GetPtr(particles), oneShot);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_180 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "particles_set_pre_process_time");

        /// <summary>
        /// <para>Sets the preprocess time for the particles' animation. This lets you delay starting an animation until after the particles have begun emitting. Equivalent to <see cref="Godot.Particles.Preprocess"/>.</para>
        /// </summary>
        [GodotMethod("particles_set_pre_process_time")]
        public static void ParticlesSetPreProcessTime(RID particles, float time)
        {
            NativeCalls.godot_icall_2_630(method_bind_180, ptr, RID.GetPtr(particles), time);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_181 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "particles_set_explosiveness_ratio");

        /// <summary>
        /// <para>Sets the explosiveness ratio. Equivalent to <see cref="Godot.Particles.Explosiveness"/>.</para>
        /// </summary>
        [GodotMethod("particles_set_explosiveness_ratio")]
        public static void ParticlesSetExplosivenessRatio(RID particles, float ratio)
        {
            NativeCalls.godot_icall_2_630(method_bind_181, ptr, RID.GetPtr(particles), ratio);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_182 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "particles_set_randomness_ratio");

        /// <summary>
        /// <para>Sets the emission randomness ratio. This randomizes the emission of particles within their phase. Equivalent to <see cref="Godot.Particles.Randomness"/>.</para>
        /// </summary>
        [GodotMethod("particles_set_randomness_ratio")]
        public static void ParticlesSetRandomnessRatio(RID particles, float ratio)
        {
            NativeCalls.godot_icall_2_630(method_bind_182, ptr, RID.GetPtr(particles), ratio);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_183 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "particles_set_custom_aabb");

        /// <summary>
        /// <para>Sets a custom axis-aligned bounding box for the particle system. Equivalent to <see cref="Godot.Particles.VisibilityAabb"/>.</para>
        /// </summary>
        [GodotMethod("particles_set_custom_aabb")]
        public static void ParticlesSetCustomAabb(RID particles, AABB aabb)
        {
            NativeCalls.godot_icall_2_1071(method_bind_183, ptr, RID.GetPtr(particles), ref aabb);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_184 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "particles_set_speed_scale");

        /// <summary>
        /// <para>Sets the speed scale of the particle system. Equivalent to <see cref="Godot.Particles.SpeedScale"/>.</para>
        /// </summary>
        [GodotMethod("particles_set_speed_scale")]
        public static void ParticlesSetSpeedScale(RID particles, float scale)
        {
            NativeCalls.godot_icall_2_630(method_bind_184, ptr, RID.GetPtr(particles), scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_185 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "particles_set_use_local_coordinates");

        /// <summary>
        /// <para>If <c>true</c>, particles use local coordinates. If <c>false</c> they use global coordinates. Equivalent to <see cref="Godot.Particles.LocalCoords"/>.</para>
        /// </summary>
        [GodotMethod("particles_set_use_local_coordinates")]
        public static void ParticlesSetUseLocalCoordinates(RID particles, bool enable)
        {
            NativeCalls.godot_icall_2_628(method_bind_185, ptr, RID.GetPtr(particles), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_186 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "particles_set_process_material");

        /// <summary>
        /// <para>Sets the material for processing the particles.</para>
        /// <para>Note: This is not the material used to draw the materials. Equivalent to <see cref="Godot.Particles.ProcessMaterial"/>.</para>
        /// </summary>
        [GodotMethod("particles_set_process_material")]
        public static void ParticlesSetProcessMaterial(RID particles, RID material)
        {
            NativeCalls.godot_icall_2_637(method_bind_186, ptr, RID.GetPtr(particles), RID.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_187 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "particles_set_fixed_fps");

        /// <summary>
        /// <para>Sets the frame rate that the particle system rendering will be fixed to. Equivalent to <see cref="Godot.Particles.FixedFps"/>.</para>
        /// </summary>
        [GodotMethod("particles_set_fixed_fps")]
        public static void ParticlesSetFixedFps(RID particles, int fps)
        {
            NativeCalls.godot_icall_2_645(method_bind_187, ptr, RID.GetPtr(particles), fps);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_188 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "particles_set_fractional_delta");

        /// <summary>
        /// <para>If <c>true</c>, uses fractional delta which smooths the movement of the particles. Equivalent to <see cref="Godot.Particles.FractDelta"/>.</para>
        /// </summary>
        [GodotMethod("particles_set_fractional_delta")]
        public static void ParticlesSetFractionalDelta(RID particles, bool enable)
        {
            NativeCalls.godot_icall_2_628(method_bind_188, ptr, RID.GetPtr(particles), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_189 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "particles_is_inactive");

        /// <summary>
        /// <para>Returns <c>true</c> if particles are not emitting and particles are set to inactive.</para>
        /// </summary>
        [GodotMethod("particles_is_inactive")]
        public static bool ParticlesIsInactive(RID particles)
        {
            return NativeCalls.godot_icall_1_629(method_bind_189, ptr, RID.GetPtr(particles));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_190 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "particles_request_process");

        /// <summary>
        /// <para>Add particle system to list of particle systems that need to be updated. Update will take place on the next frame, or on the next call to <see cref="Godot.VisualServer.InstancesCullAabb"/>, <see cref="Godot.VisualServer.InstancesCullConvex"/>, or <see cref="Godot.VisualServer.InstancesCullRay"/>.</para>
        /// </summary>
        [GodotMethod("particles_request_process")]
        public static void ParticlesRequestProcess(RID particles)
        {
            NativeCalls.godot_icall_1_285(method_bind_190, ptr, RID.GetPtr(particles));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_191 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "particles_restart");

        /// <summary>
        /// <para>Reset the particles on the next update. Equivalent to <see cref="Godot.Particles.Restart"/>.</para>
        /// </summary>
        [GodotMethod("particles_restart")]
        public static void ParticlesRestart(RID particles)
        {
            NativeCalls.godot_icall_1_285(method_bind_191, ptr, RID.GetPtr(particles));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_192 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "particles_set_draw_order");

        /// <summary>
        /// <para>Sets the draw order of the particles to one of the named enums from <see cref="Godot.VisualServer.ParticlesDrawOrder"/>. See <see cref="Godot.VisualServer.ParticlesDrawOrder"/> for options. Equivalent to <see cref="Godot.Particles.DrawOrder"/>.</para>
        /// </summary>
        [GodotMethod("particles_set_draw_order")]
        public static void ParticlesSetDrawOrder(RID particles, VisualServer.ParticlesDrawOrder order)
        {
            NativeCalls.godot_icall_2_645(method_bind_192, ptr, RID.GetPtr(particles), (int)order);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_193 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "particles_set_draw_passes");

        /// <summary>
        /// <para>Sets the number of draw passes to use. Equivalent to <see cref="Godot.Particles.DrawPasses"/>.</para>
        /// </summary>
        [GodotMethod("particles_set_draw_passes")]
        public static void ParticlesSetDrawPasses(RID particles, int count)
        {
            NativeCalls.godot_icall_2_645(method_bind_193, ptr, RID.GetPtr(particles), count);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_194 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "particles_set_draw_pass_mesh");

        /// <summary>
        /// <para>Sets the mesh to be used for the specified draw pass. Equivalent to <see cref="Godot.Particles.DrawPass1"/>, <see cref="Godot.Particles.DrawPass2"/>, <see cref="Godot.Particles.DrawPass3"/>, and <see cref="Godot.Particles.DrawPass4"/>.</para>
        /// </summary>
        [GodotMethod("particles_set_draw_pass_mesh")]
        public static void ParticlesSetDrawPassMesh(RID particles, int pass, RID mesh)
        {
            NativeCalls.godot_icall_3_749(method_bind_194, ptr, RID.GetPtr(particles), pass, RID.GetPtr(mesh));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_195 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "particles_get_current_aabb");

        /// <summary>
        /// <para>Calculates and returns the axis-aligned bounding box that contains all the particles. Equivalent to <see cref="Godot.Particles.CaptureAabb"/>.</para>
        /// </summary>
        [GodotMethod("particles_get_current_aabb")]
        public static AABB ParticlesGetCurrentAabb(RID particles)
        {
            NativeCalls.godot_icall_1_1072(method_bind_195, ptr, RID.GetPtr(particles), out AABB argRet); return (AABB)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_196 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "particles_set_emission_transform");

        /// <summary>
        /// <para>Sets the <see cref="Godot.Transform"/> that will be used by the particles when they first emit.</para>
        /// </summary>
        [GodotMethod("particles_set_emission_transform")]
        public static void ParticlesSetEmissionTransform(RID particles, Transform transform)
        {
            NativeCalls.godot_icall_2_663(method_bind_196, ptr, RID.GetPtr(particles), ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_197 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "camera_create");

        /// <summary>
        /// <para>Creates a camera and adds it to the VisualServer. It can be accessed with the RID that is returned. This RID will be used in all <c>camera_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// </summary>
        [GodotMethod("camera_create")]
        public static RID CameraCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_197, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_198 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "camera_set_perspective");

        /// <summary>
        /// <para>Sets camera to use perspective projection. Objects on the screen becomes smaller when they are far away.</para>
        /// </summary>
        [GodotMethod("camera_set_perspective")]
        public static void CameraSetPerspective(RID camera, float fovyDegrees, float zNear, float zFar)
        {
            NativeCalls.godot_icall_4_1082(method_bind_198, ptr, RID.GetPtr(camera), fovyDegrees, zNear, zFar);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_199 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "camera_set_orthogonal");

        /// <summary>
        /// <para>Sets camera to use orthogonal projection, also known as orthographic projection. Objects remain the same size on the screen no matter how far away they are.</para>
        /// </summary>
        [GodotMethod("camera_set_orthogonal")]
        public static void CameraSetOrthogonal(RID camera, float size, float zNear, float zFar)
        {
            NativeCalls.godot_icall_4_1082(method_bind_199, ptr, RID.GetPtr(camera), size, zNear, zFar);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_200 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "camera_set_frustum");

        /// <summary>
        /// <para>Sets camera to use frustum projection. This mode allows adjusting the <c>offset</c> argument to create "tilted frustum" effects.</para>
        /// </summary>
        [GodotMethod("camera_set_frustum")]
        public static void CameraSetFrustum(RID camera, float size, Vector2 offset, float zNear, float zFar)
        {
            NativeCalls.godot_icall_5_1083(method_bind_200, ptr, RID.GetPtr(camera), size, ref offset, zNear, zFar);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_201 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "camera_set_transform");

        /// <summary>
        /// <para>Sets <see cref="Godot.Transform"/> of camera.</para>
        /// </summary>
        [GodotMethod("camera_set_transform")]
        public static void CameraSetTransform(RID camera, Transform transform)
        {
            NativeCalls.godot_icall_2_663(method_bind_201, ptr, RID.GetPtr(camera), ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_202 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "camera_set_cull_mask");

        /// <summary>
        /// <para>Sets the cull mask associated with this camera. The cull mask describes which 3D layers are rendered by this camera. Equivalent to <see cref="Godot.Camera.CullMask"/>.</para>
        /// </summary>
        [GodotMethod("camera_set_cull_mask")]
        public static void CameraSetCullMask(RID camera, uint layers)
        {
            NativeCalls.godot_icall_2_639(method_bind_202, ptr, RID.GetPtr(camera), layers);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_203 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "camera_set_environment");

        /// <summary>
        /// <para>Sets the environment used by this camera. Equivalent to <see cref="Godot.Camera.Environment"/>.</para>
        /// </summary>
        [GodotMethod("camera_set_environment")]
        public static void CameraSetEnvironment(RID camera, RID env)
        {
            NativeCalls.godot_icall_2_637(method_bind_203, ptr, RID.GetPtr(camera), RID.GetPtr(env));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_204 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "camera_set_use_vertical_aspect");

        /// <summary>
        /// <para>If <c>true</c>, preserves the horizontal aspect ratio which is equivalent to <see cref="Godot.Camera.KeepAspectEnum.Width"/>. If <c>false</c>, preserves the vertical aspect ratio which is equivalent to <see cref="Godot.Camera.KeepAspectEnum.Height"/>.</para>
        /// </summary>
        [GodotMethod("camera_set_use_vertical_aspect")]
        public static void CameraSetUseVerticalAspect(RID camera, bool enable)
        {
            NativeCalls.godot_icall_2_628(method_bind_204, ptr, RID.GetPtr(camera), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_205 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_create");

        /// <summary>
        /// <para>Creates an empty viewport and adds it to the VisualServer. It can be accessed with the RID that is returned. This RID will be used in all <c>viewport_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// </summary>
        [GodotMethod("viewport_create")]
        public static RID ViewportCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_205, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_206 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_use_arvr");

        /// <summary>
        /// <para>If <c>true</c>, the viewport uses augmented or virtual reality technologies. See <see cref="Godot.ARVRInterface"/>.</para>
        /// </summary>
        [GodotMethod("viewport_set_use_arvr")]
        public static void ViewportSetUseArvr(RID viewport, bool useArvr)
        {
            NativeCalls.godot_icall_2_628(method_bind_206, ptr, RID.GetPtr(viewport), useArvr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_207 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_size");

        /// <summary>
        /// <para>Sets the viewport's width and height.</para>
        /// </summary>
        [GodotMethod("viewport_set_size")]
        public static void ViewportSetSize(RID viewport, int width, int height)
        {
            NativeCalls.godot_icall_3_1084(method_bind_207, ptr, RID.GetPtr(viewport), width, height);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_208 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_active");

        /// <summary>
        /// <para>If <c>true</c>, sets the viewport active, else sets it inactive.</para>
        /// </summary>
        [GodotMethod("viewport_set_active")]
        public static void ViewportSetActive(RID viewport, bool active)
        {
            NativeCalls.godot_icall_2_628(method_bind_208, ptr, RID.GetPtr(viewport), active);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_209 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_parent_viewport");

        /// <summary>
        /// <para>Sets the viewport's parent to another viewport.</para>
        /// </summary>
        [GodotMethod("viewport_set_parent_viewport")]
        public static void ViewportSetParentViewport(RID viewport, RID parentViewport)
        {
            NativeCalls.godot_icall_2_637(method_bind_209, ptr, RID.GetPtr(viewport), RID.GetPtr(parentViewport));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_210 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_attach_to_screen");

        /// <summary>
        /// <para>Copies viewport to a region of the screen specified by <c>rect</c>. If <see cref="Godot.Viewport.RenderDirectToScreen"/> is <c>true</c>, then viewport does not use a framebuffer and the contents of the viewport are rendered directly to screen. However, note that the root viewport is drawn last, therefore it will draw over the screen. Accordingly, you must set the root viewport to an area that does not cover the area that you have attached this viewport to.</para>
        /// <para>For example, you can set the root viewport to not render at all with the following code:</para>
        /// <para><code>
        /// func _ready():
        ///     get_viewport().set_attach_to_screen_rect(Rect2())
        ///     $Viewport.set_attach_to_screen_rect(Rect2(0, 0, 600, 600))
        /// </code></para>
        /// <para>Using this can result in significant optimization, especially on lower-end devices. However, it comes at the cost of having to manage your viewports manually. For further optimization, see <see cref="Godot.VisualServer.ViewportSetRenderDirectToScreen"/>.</para>
        /// </summary>
        /// <param name="rect">If the parameter is null, then the default value is new Rect2(new Vector2(0, 0), new Vector2(0, 0))</param>
        [GodotMethod("viewport_attach_to_screen")]
        public static void ViewportAttachToScreen(RID viewport, Nullable<Rect2> rect = null, int screen = 0)
        {
            Rect2 rect_in = rect.HasValue ? rect.Value : new Rect2(new Vector2(0, 0), new Vector2(0, 0));
            NativeCalls.godot_icall_3_1085(method_bind_210, ptr, RID.GetPtr(viewport), ref rect_in, screen);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_211 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_render_direct_to_screen");

        /// <summary>
        /// <para>If <c>true</c>, render the contents of the viewport directly to screen. This allows a low-level optimization where you can skip drawing a viewport to the root viewport. While this optimization can result in a significant increase in speed (especially on older devices), it comes at a cost of usability. When this is enabled, you cannot read from the viewport or from the <c>SCREEN_TEXTURE</c>. You also lose the benefit of certain window settings, such as the various stretch modes. Another consequence to be aware of is that in 2D the rendering happens in window coordinates, so if you have a viewport that is double the size of the window, and you set this, then only the portion that fits within the window will be drawn, no automatic scaling is possible, even if your game scene is significantly larger than the window size.</para>
        /// </summary>
        [GodotMethod("viewport_set_render_direct_to_screen")]
        public static void ViewportSetRenderDirectToScreen(RID viewport, bool enabled)
        {
            NativeCalls.godot_icall_2_628(method_bind_211, ptr, RID.GetPtr(viewport), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_212 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_detach");

        /// <summary>
        /// <para>Detaches the viewport from the screen.</para>
        /// </summary>
        [GodotMethod("viewport_detach")]
        public static void ViewportDetach(RID viewport)
        {
            NativeCalls.godot_icall_1_285(method_bind_212, ptr, RID.GetPtr(viewport));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_213 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_update_mode");

        /// <summary>
        /// <para>Sets when the viewport should be updated. See <see cref="Godot.VisualServer.ViewportUpdateMode"/> constants for options.</para>
        /// </summary>
        [GodotMethod("viewport_set_update_mode")]
        public static void ViewportSetUpdateMode(RID viewport, VisualServer.ViewportUpdateMode updateMode)
        {
            NativeCalls.godot_icall_2_645(method_bind_213, ptr, RID.GetPtr(viewport), (int)updateMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_214 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_vflip");

        /// <summary>
        /// <para>If <c>true</c>, the viewport's rendering is flipped vertically.</para>
        /// </summary>
        [GodotMethod("viewport_set_vflip")]
        public static void ViewportSetVflip(RID viewport, bool enabled)
        {
            NativeCalls.godot_icall_2_628(method_bind_214, ptr, RID.GetPtr(viewport), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_215 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_clear_mode");

        /// <summary>
        /// <para>Sets the clear mode of a viewport. See <see cref="Godot.VisualServer.ViewportClearMode"/> for options.</para>
        /// </summary>
        [GodotMethod("viewport_set_clear_mode")]
        public static void ViewportSetClearMode(RID viewport, VisualServer.ViewportClearMode clearMode)
        {
            NativeCalls.godot_icall_2_645(method_bind_215, ptr, RID.GetPtr(viewport), (int)clearMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_216 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_get_texture");

        /// <summary>
        /// <para>Returns the viewport's last rendered frame.</para>
        /// </summary>
        [GodotMethod("viewport_get_texture")]
        public static RID ViewportGetTexture(RID viewport)
        {
            return new RID(NativeCalls.godot_icall_1_638(method_bind_216, ptr, RID.GetPtr(viewport)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_217 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_hide_scenario");

        /// <summary>
        /// <para>Currently unimplemented in Godot 3.x.</para>
        /// </summary>
        [GodotMethod("viewport_set_hide_scenario")]
        public static void ViewportSetHideScenario(RID viewport, bool hidden)
        {
            NativeCalls.godot_icall_2_628(method_bind_217, ptr, RID.GetPtr(viewport), hidden);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_218 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_hide_canvas");

        /// <summary>
        /// <para>If <c>true</c>, the viewport's canvas is not rendered.</para>
        /// </summary>
        [GodotMethod("viewport_set_hide_canvas")]
        public static void ViewportSetHideCanvas(RID viewport, bool hidden)
        {
            NativeCalls.godot_icall_2_628(method_bind_218, ptr, RID.GetPtr(viewport), hidden);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_219 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_disable_environment");

        /// <summary>
        /// <para>If <c>true</c>, rendering of a viewport's environment is disabled.</para>
        /// </summary>
        [GodotMethod("viewport_set_disable_environment")]
        public static void ViewportSetDisableEnvironment(RID viewport, bool disabled)
        {
            NativeCalls.godot_icall_2_628(method_bind_219, ptr, RID.GetPtr(viewport), disabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_220 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_disable_3d");

        /// <summary>
        /// <para>If <c>true</c>, a viewport's 3D rendering is disabled.</para>
        /// </summary>
        [GodotMethod("viewport_set_disable_3d")]
        public static void ViewportSetDisable3d(RID viewport, bool disabled)
        {
            NativeCalls.godot_icall_2_628(method_bind_220, ptr, RID.GetPtr(viewport), disabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_221 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_attach_camera");

        /// <summary>
        /// <para>Sets a viewport's camera.</para>
        /// </summary>
        [GodotMethod("viewport_attach_camera")]
        public static void ViewportAttachCamera(RID viewport, RID camera)
        {
            NativeCalls.godot_icall_2_637(method_bind_221, ptr, RID.GetPtr(viewport), RID.GetPtr(camera));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_222 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_scenario");

        /// <summary>
        /// <para>Sets a viewport's scenario.</para>
        /// <para>The scenario contains information about the <see cref="Godot.VisualServer.ScenarioDebugMode"/>, environment information, reflection atlas etc.</para>
        /// </summary>
        [GodotMethod("viewport_set_scenario")]
        public static void ViewportSetScenario(RID viewport, RID scenario)
        {
            NativeCalls.godot_icall_2_637(method_bind_222, ptr, RID.GetPtr(viewport), RID.GetPtr(scenario));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_223 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_attach_canvas");

        /// <summary>
        /// <para>Sets a viewport's canvas.</para>
        /// </summary>
        [GodotMethod("viewport_attach_canvas")]
        public static void ViewportAttachCanvas(RID viewport, RID canvas)
        {
            NativeCalls.godot_icall_2_637(method_bind_223, ptr, RID.GetPtr(viewport), RID.GetPtr(canvas));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_224 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_remove_canvas");

        /// <summary>
        /// <para>Detaches a viewport from a canvas and vice versa.</para>
        /// </summary>
        [GodotMethod("viewport_remove_canvas")]
        public static void ViewportRemoveCanvas(RID viewport, RID canvas)
        {
            NativeCalls.godot_icall_2_637(method_bind_224, ptr, RID.GetPtr(viewport), RID.GetPtr(canvas));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_225 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_canvas_transform");

        /// <summary>
        /// <para>Sets the transformation of a viewport's canvas.</para>
        /// </summary>
        [GodotMethod("viewport_set_canvas_transform")]
        public static void ViewportSetCanvasTransform(RID viewport, RID canvas, Transform2D offset)
        {
            NativeCalls.godot_icall_3_1086(method_bind_225, ptr, RID.GetPtr(viewport), RID.GetPtr(canvas), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_226 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_transparent_background");

        /// <summary>
        /// <para>If <c>true</c>, the viewport renders its background as transparent.</para>
        /// </summary>
        [GodotMethod("viewport_set_transparent_background")]
        public static void ViewportSetTransparentBackground(RID viewport, bool enabled)
        {
            NativeCalls.godot_icall_2_628(method_bind_226, ptr, RID.GetPtr(viewport), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_227 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_global_canvas_transform");

        /// <summary>
        /// <para>Sets the viewport's global transformation matrix.</para>
        /// </summary>
        [GodotMethod("viewport_set_global_canvas_transform")]
        public static void ViewportSetGlobalCanvasTransform(RID viewport, Transform2D transform)
        {
            NativeCalls.godot_icall_2_641(method_bind_227, ptr, RID.GetPtr(viewport), ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_228 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_canvas_stacking");

        /// <summary>
        /// <para>Sets the stacking order for a viewport's canvas.</para>
        /// <para><c>layer</c> is the actual canvas layer, while <c>sublayer</c> specifies the stacking order of the canvas among those in the same layer.</para>
        /// </summary>
        [GodotMethod("viewport_set_canvas_stacking")]
        public static void ViewportSetCanvasStacking(RID viewport, RID canvas, int layer, int sublayer)
        {
            NativeCalls.godot_icall_4_1087(method_bind_228, ptr, RID.GetPtr(viewport), RID.GetPtr(canvas), layer, sublayer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_229 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_shadow_atlas_size");

        /// <summary>
        /// <para>Sets the size of the shadow atlas's images (used for omni and spot lights). The value will be rounded up to the nearest power of 2.</para>
        /// </summary>
        [GodotMethod("viewport_set_shadow_atlas_size")]
        public static void ViewportSetShadowAtlasSize(RID viewport, int size)
        {
            NativeCalls.godot_icall_2_645(method_bind_229, ptr, RID.GetPtr(viewport), size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_230 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_shadow_atlas_quadrant_subdivision");

        /// <summary>
        /// <para>Sets the shadow atlas quadrant's subdivision.</para>
        /// </summary>
        [GodotMethod("viewport_set_shadow_atlas_quadrant_subdivision")]
        public static void ViewportSetShadowAtlasQuadrantSubdivision(RID viewport, int quadrant, int subdivision)
        {
            NativeCalls.godot_icall_3_1084(method_bind_230, ptr, RID.GetPtr(viewport), quadrant, subdivision);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_231 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_msaa");

        /// <summary>
        /// <para>Sets the anti-aliasing mode. See <see cref="Godot.VisualServer.ViewportMSAA"/> for options.</para>
        /// </summary>
        [GodotMethod("viewport_set_msaa")]
        public static void ViewportSetMsaa(RID viewport, VisualServer.ViewportMSAA msaa)
        {
            NativeCalls.godot_icall_2_645(method_bind_231, ptr, RID.GetPtr(viewport), (int)msaa);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_232 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_use_fxaa");

        /// <summary>
        /// <para>Enables fast approximate antialiasing for this viewport. FXAA is a popular screen-space antialiasing method, which is fast but will make the image look blurry, especially at lower resolutions. It can still work relatively well at large resolutions such as 1440p and 4K. Some of the lost sharpness can be recovered by enabling contrast-adaptive sharpening (see <see cref="Godot.VisualServer.ViewportSetSharpenIntensity"/>).</para>
        /// </summary>
        [GodotMethod("viewport_set_use_fxaa")]
        public static void ViewportSetUseFxaa(RID viewport, bool fxaa)
        {
            NativeCalls.godot_icall_2_628(method_bind_232, ptr, RID.GetPtr(viewport), fxaa);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_233 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_use_debanding");

        /// <summary>
        /// <para>If <c>true</c>, uses a fast post-processing filter to make banding significantly less visible. In some cases, debanding may introduce a slightly noticeable dithering pattern. It's recommended to enable debanding only when actually needed since the dithering pattern will make lossless-compressed screenshots larger.</para>
        /// <para>Note: Only available on the GLES3 backend. <see cref="Godot.Viewport.Hdr"/> must also be <c>true</c> for debanding to be effective.</para>
        /// </summary>
        [GodotMethod("viewport_set_use_debanding")]
        public static void ViewportSetUseDebanding(RID viewport, bool debanding)
        {
            NativeCalls.godot_icall_2_628(method_bind_233, ptr, RID.GetPtr(viewport), debanding);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_234 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_sharpen_intensity");

        /// <summary>
        /// <para>Sets the sharpening <c>intensity</c> for the <c>viewport</c>. If set to a value greater than <c>0.0</c>, contrast-adaptive sharpening will be applied to the 3D viewport. This has a low performance cost and can be used to recover some of the sharpness lost from using FXAA. Values around <c>0.5</c> generally give the best results. See also <see cref="Godot.VisualServer.ViewportSetUseFxaa"/>.</para>
        /// </summary>
        [GodotMethod("viewport_set_sharpen_intensity")]
        public static void ViewportSetSharpenIntensity(RID viewport, float intensity)
        {
            NativeCalls.godot_icall_2_630(method_bind_234, ptr, RID.GetPtr(viewport), intensity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_235 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_hdr");

        /// <summary>
        /// <para>If <c>true</c>, the viewport renders to high dynamic range (HDR) instead of standard dynamic range (SDR). See also <see cref="Godot.VisualServer.ViewportSetUse32BpcDepth"/>.</para>
        /// <para>Note: Only available on the GLES3 backend.</para>
        /// </summary>
        [GodotMethod("viewport_set_hdr")]
        public static void ViewportSetHdr(RID viewport, bool enabled)
        {
            NativeCalls.godot_icall_2_628(method_bind_235, ptr, RID.GetPtr(viewport), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_236 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_use_32_bpc_depth");

        /// <summary>
        /// <para>If <c>true</c>, allocates the viewport's framebuffer with full floating-point precision (32-bit) instead of half floating-point precision (16-bit). Only effective if <see cref="Godot.VisualServer.ViewportSetUse32BpcDepth"/> is used on the same <see cref="Godot.Viewport"/> to set HDR to <c>true</c>.</para>
        /// <para>Note: Only available on the GLES3 backend.</para>
        /// </summary>
        [GodotMethod("viewport_set_use_32_bpc_depth")]
        public static void ViewportSetUse32BpcDepth(RID viewport, bool enabled)
        {
            NativeCalls.godot_icall_2_628(method_bind_236, ptr, RID.GetPtr(viewport), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_237 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_usage");

        /// <summary>
        /// <para>Sets the viewport's 2D/3D mode. See <see cref="Godot.VisualServer.ViewportUsage"/> constants for options.</para>
        /// </summary>
        [GodotMethod("viewport_set_usage")]
        public static void ViewportSetUsage(RID viewport, VisualServer.ViewportUsage usage)
        {
            NativeCalls.godot_icall_2_645(method_bind_237, ptr, RID.GetPtr(viewport), (int)usage);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_238 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_get_render_info");

        /// <summary>
        /// <para>Returns a viewport's render information. For options, see the <see cref="Godot.VisualServer.ViewportRenderInfo"/> constants.</para>
        /// </summary>
        [GodotMethod("viewport_get_render_info")]
        public static int ViewportGetRenderInfo(RID viewport, VisualServer.ViewportRenderInfo info)
        {
            return NativeCalls.godot_icall_2_1065(method_bind_238, ptr, RID.GetPtr(viewport), (int)info);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_239 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "viewport_set_debug_draw");

        /// <summary>
        /// <para>Sets the debug draw mode of a viewport. See <see cref="Godot.VisualServer.ViewportDebugDraw"/> for options.</para>
        /// </summary>
        [GodotMethod("viewport_set_debug_draw")]
        public static void ViewportSetDebugDraw(RID viewport, VisualServer.ViewportDebugDraw draw)
        {
            NativeCalls.godot_icall_2_645(method_bind_239, ptr, RID.GetPtr(viewport), (int)draw);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_240 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "environment_create");

        /// <summary>
        /// <para>Creates an environment and adds it to the VisualServer. It can be accessed with the RID that is returned. This RID will be used in all <c>environment_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// </summary>
        [GodotMethod("environment_create")]
        public static RID EnvironmentCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_240, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_241 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "environment_set_background");

        /// <summary>
        /// <para>Sets the BGMode of the environment. Equivalent to <see cref="Godot.Environment.BackgroundMode"/>.</para>
        /// </summary>
        [GodotMethod("environment_set_background")]
        public static void EnvironmentSetBackground(RID env, VisualServer.EnvironmentBG bg)
        {
            NativeCalls.godot_icall_2_645(method_bind_241, ptr, RID.GetPtr(env), (int)bg);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_242 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "environment_set_sky");

        /// <summary>
        /// <para>Sets the <see cref="Godot.Sky"/> to be used as the environment's background when using BGMode sky. Equivalent to <see cref="Godot.Environment.BackgroundSky"/>.</para>
        /// </summary>
        [GodotMethod("environment_set_sky")]
        public static void EnvironmentSetSky(RID env, RID sky)
        {
            NativeCalls.godot_icall_2_637(method_bind_242, ptr, RID.GetPtr(env), RID.GetPtr(sky));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_243 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "environment_set_sky_custom_fov");

        /// <summary>
        /// <para>Sets a custom field of view for the background <see cref="Godot.Sky"/>. Equivalent to <see cref="Godot.Environment.BackgroundSkyCustomFov"/>.</para>
        /// </summary>
        [GodotMethod("environment_set_sky_custom_fov")]
        public static void EnvironmentSetSkyCustomFov(RID env, float scale)
        {
            NativeCalls.godot_icall_2_630(method_bind_243, ptr, RID.GetPtr(env), scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_244 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "environment_set_sky_orientation");

        /// <summary>
        /// <para>Sets the rotation of the background <see cref="Godot.Sky"/> expressed as a <see cref="Godot.Basis"/>. Equivalent to <see cref="Godot.Environment.BackgroundSkyOrientation"/>.</para>
        /// </summary>
        [GodotMethod("environment_set_sky_orientation")]
        public static void EnvironmentSetSkyOrientation(RID env, Basis orientation)
        {
            NativeCalls.godot_icall_2_1088(method_bind_244, ptr, RID.GetPtr(env), ref orientation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_245 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "environment_set_bg_color");

        /// <summary>
        /// <para>Color displayed for clear areas of the scene (if using Custom color or Color+Sky background modes).</para>
        /// </summary>
        [GodotMethod("environment_set_bg_color")]
        public static void EnvironmentSetBgColor(RID env, Color color)
        {
            NativeCalls.godot_icall_2_858(method_bind_245, ptr, RID.GetPtr(env), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_246 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "environment_set_bg_energy");

        /// <summary>
        /// <para>Sets the intensity of the background color.</para>
        /// </summary>
        [GodotMethod("environment_set_bg_energy")]
        public static void EnvironmentSetBgEnergy(RID env, float energy)
        {
            NativeCalls.godot_icall_2_630(method_bind_246, ptr, RID.GetPtr(env), energy);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_247 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "environment_set_canvas_max_layer");

        /// <summary>
        /// <para>Sets the maximum layer to use if using Canvas background mode.</para>
        /// </summary>
        [GodotMethod("environment_set_canvas_max_layer")]
        public static void EnvironmentSetCanvasMaxLayer(RID env, int maxLayer)
        {
            NativeCalls.godot_icall_2_645(method_bind_247, ptr, RID.GetPtr(env), maxLayer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_248 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "environment_set_ambient_light");

        /// <summary>
        /// <para>Sets the ambient light parameters. See <see cref="Godot.Environment"/> for more details.</para>
        /// </summary>
        [GodotMethod("environment_set_ambient_light")]
        public static void EnvironmentSetAmbientLight(RID env, Color color, float energy = 1f, float skyContibution = 0f)
        {
            NativeCalls.godot_icall_4_1089(method_bind_248, ptr, RID.GetPtr(env), ref color, energy, skyContibution);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_249 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "environment_set_dof_blur_near");

        /// <summary>
        /// <para>Sets the values to be used with the "DoF Near Blur" post-process effect. See <see cref="Godot.Environment"/> for more details.</para>
        /// </summary>
        [GodotMethod("environment_set_dof_blur_near")]
        public static void EnvironmentSetDofBlurNear(RID env, bool enable, float distance, float transition, float farAmount, VisualServer.EnvironmentDOFBlurQuality quality)
        {
            NativeCalls.godot_icall_6_1090(method_bind_249, ptr, RID.GetPtr(env), enable, distance, transition, farAmount, (int)quality);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_250 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "environment_set_dof_blur_far");

        /// <summary>
        /// <para>Sets the values to be used with the "DoF Far Blur" post-process effect. See <see cref="Godot.Environment"/> for more details.</para>
        /// </summary>
        [GodotMethod("environment_set_dof_blur_far")]
        public static void EnvironmentSetDofBlurFar(RID env, bool enable, float distance, float transition, float farAmount, VisualServer.EnvironmentDOFBlurQuality quality)
        {
            NativeCalls.godot_icall_6_1090(method_bind_250, ptr, RID.GetPtr(env), enable, distance, transition, farAmount, (int)quality);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_251 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "environment_set_glow");

        /// <summary>
        /// <para>Sets the variables to be used with the "glow" post-process effect. See <see cref="Godot.Environment"/> for more details.</para>
        /// </summary>
        [GodotMethod("environment_set_glow")]
        public static void EnvironmentSetGlow(RID env, bool enable, int levelFlags, float intensity, float strength, float bloomThreshold, VisualServer.EnvironmentGlowBlendMode blendMode, float hdrBleedThreshold, float hdrBleedScale, float hdrLuminanceCap, bool bicubicUpscale, bool highQuality)
        {
            NativeCalls.godot_icall_12_1091(method_bind_251, ptr, RID.GetPtr(env), enable, levelFlags, intensity, strength, bloomThreshold, (int)blendMode, hdrBleedThreshold, hdrBleedScale, hdrLuminanceCap, bicubicUpscale, highQuality);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_252 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "environment_set_tonemap");

        /// <summary>
        /// <para>Sets the variables to be used with the "tonemap" post-process effect. See <see cref="Godot.Environment"/> for more details.</para>
        /// </summary>
        [GodotMethod("environment_set_tonemap")]
        public static void EnvironmentSetTonemap(RID env, VisualServer.EnvironmentToneMapper toneMapper, float exposure, float white, bool autoExposure, float minLuminance, float maxLuminance, float autoExpSpeed, float autoExpGrey)
        {
            NativeCalls.godot_icall_9_1092(method_bind_252, ptr, RID.GetPtr(env), (int)toneMapper, exposure, white, autoExposure, minLuminance, maxLuminance, autoExpSpeed, autoExpGrey);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_253 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "environment_set_adjustment");

        /// <summary>
        /// <para>Sets the values to be used with the "Adjustment" post-process effect. See <see cref="Godot.Environment"/> for more details.</para>
        /// </summary>
        [GodotMethod("environment_set_adjustment")]
        public static void EnvironmentSetAdjustment(RID env, bool enable, float brightness, float contrast, float saturation, RID ramp)
        {
            NativeCalls.godot_icall_6_1093(method_bind_253, ptr, RID.GetPtr(env), enable, brightness, contrast, saturation, RID.GetPtr(ramp));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_254 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "environment_set_ssr");

        /// <summary>
        /// <para>Sets the variables to be used with the "screen space reflections" post-process effect. See <see cref="Godot.Environment"/> for more details.</para>
        /// </summary>
        [GodotMethod("environment_set_ssr")]
        public static void EnvironmentSetSsr(RID env, bool enable, int maxSteps, float fadeIn, float fadeOut, float depthTolerance, bool roughness)
        {
            NativeCalls.godot_icall_7_1094(method_bind_254, ptr, RID.GetPtr(env), enable, maxSteps, fadeIn, fadeOut, depthTolerance, roughness);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_255 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "environment_set_ssao");

        /// <summary>
        /// <para>Sets the variables to be used with the "Screen Space Ambient Occlusion (SSAO)" post-process effect. See <see cref="Godot.Environment"/> for more details.</para>
        /// </summary>
        [GodotMethod("environment_set_ssao")]
        public static void EnvironmentSetSsao(RID env, bool enable, float radius, float intensity, float radius2, float intensity2, float bias, float lightAffect, float aoChannelAffect, Color color, VisualServer.EnvironmentSSAOQuality quality, VisualServer.EnvironmentSSAOBlur blur, float bilateralSharpness)
        {
            NativeCalls.godot_icall_13_1095(method_bind_255, ptr, RID.GetPtr(env), enable, radius, intensity, radius2, intensity2, bias, lightAffect, aoChannelAffect, ref color, (int)quality, (int)blur, bilateralSharpness);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_256 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "environment_set_fog");

        /// <summary>
        /// <para>Sets the variables to be used with the scene fog. See <see cref="Godot.Environment"/> for more details.</para>
        /// </summary>
        [GodotMethod("environment_set_fog")]
        public static void EnvironmentSetFog(RID env, bool enable, Color color, Color sunColor, float sunAmount)
        {
            NativeCalls.godot_icall_5_1096(method_bind_256, ptr, RID.GetPtr(env), enable, ref color, ref sunColor, sunAmount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_257 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "environment_set_fog_depth");

        /// <summary>
        /// <para>Sets the variables to be used with the fog depth effect. See <see cref="Godot.Environment"/> for more details.</para>
        /// </summary>
        [GodotMethod("environment_set_fog_depth")]
        public static void EnvironmentSetFogDepth(RID env, bool enable, float depthBegin, float depthEnd, float depthCurve, bool transmit, float transmitCurve)
        {
            NativeCalls.godot_icall_7_1097(method_bind_257, ptr, RID.GetPtr(env), enable, depthBegin, depthEnd, depthCurve, transmit, transmitCurve);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_258 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "environment_set_fog_height");

        /// <summary>
        /// <para>Sets the variables to be used with the fog height effect. See <see cref="Godot.Environment"/> for more details.</para>
        /// </summary>
        [GodotMethod("environment_set_fog_height")]
        public static void EnvironmentSetFogHeight(RID env, bool enable, float minHeight, float maxHeight, float heightCurve)
        {
            NativeCalls.godot_icall_5_1098(method_bind_258, ptr, RID.GetPtr(env), enable, minHeight, maxHeight, heightCurve);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_259 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "scenario_create");

        /// <summary>
        /// <para>Creates a scenario and adds it to the VisualServer. It can be accessed with the RID that is returned. This RID will be used in all <c>scenario_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// <para>The scenario is the 3D world that all the visual instances exist in.</para>
        /// </summary>
        [GodotMethod("scenario_create")]
        public static RID ScenarioCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_259, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_260 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "scenario_set_debug");

        /// <summary>
        /// <para>Sets the <see cref="Godot.VisualServer.ScenarioDebugMode"/> for this scenario. See <see cref="Godot.VisualServer.ScenarioDebugMode"/> for options.</para>
        /// </summary>
        [GodotMethod("scenario_set_debug")]
        public static void ScenarioSetDebug(RID scenario, VisualServer.ScenarioDebugMode debugMode)
        {
            NativeCalls.godot_icall_2_645(method_bind_260, ptr, RID.GetPtr(scenario), (int)debugMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_261 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "scenario_set_environment");

        /// <summary>
        /// <para>Sets the environment that will be used with this scenario.</para>
        /// </summary>
        [GodotMethod("scenario_set_environment")]
        public static void ScenarioSetEnvironment(RID scenario, RID environment)
        {
            NativeCalls.godot_icall_2_637(method_bind_261, ptr, RID.GetPtr(scenario), RID.GetPtr(environment));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_262 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "scenario_set_reflection_atlas_size");

        /// <summary>
        /// <para>Sets the size of the reflection atlas shared by all reflection probes in this scenario.</para>
        /// </summary>
        [GodotMethod("scenario_set_reflection_atlas_size")]
        public static void ScenarioSetReflectionAtlasSize(RID scenario, int size, int subdiv)
        {
            NativeCalls.godot_icall_3_1084(method_bind_262, ptr, RID.GetPtr(scenario), size, subdiv);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_263 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "scenario_set_fallback_environment");

        /// <summary>
        /// <para>Sets the fallback environment to be used by this scenario. The fallback environment is used if no environment is set. Internally, this is used by the editor to provide a default environment.</para>
        /// </summary>
        [GodotMethod("scenario_set_fallback_environment")]
        public static void ScenarioSetFallbackEnvironment(RID scenario, RID environment)
        {
            NativeCalls.godot_icall_2_637(method_bind_263, ptr, RID.GetPtr(scenario), RID.GetPtr(environment));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_264 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance_create2");

        /// <summary>
        /// <para>Creates a visual instance, adds it to the VisualServer, and sets both base and scenario. It can be accessed with the RID that is returned. This RID will be used in all <c>instance_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// </summary>
        [GodotMethod("instance_create2")]
        public static RID InstanceCreate2(RID @base, RID scenario)
        {
            return new RID(NativeCalls.godot_icall_2_1099(method_bind_264, ptr, RID.GetPtr(@base), RID.GetPtr(scenario)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_265 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance_create");

        /// <summary>
        /// <para>Creates a visual instance and adds it to the VisualServer. It can be accessed with the RID that is returned. This RID will be used in all <c>instance_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// <para>An instance is a way of placing a 3D object in the scenario. Objects like particles, meshes, and reflection probes need to be associated with an instance to be visible in the scenario using <see cref="Godot.VisualServer.InstanceSetBase"/>.</para>
        /// </summary>
        [GodotMethod("instance_create")]
        public static RID InstanceCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_265, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_266 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance_set_base");

        /// <summary>
        /// <para>Sets the base of the instance. A base can be any of the 3D objects that are created in the VisualServer that can be displayed. For example, any of the light types, mesh, multimesh, immediate geometry, particle system, reflection probe, lightmap capture, and the GI probe are all types that can be set as the base of an instance in order to be displayed in the scenario.</para>
        /// </summary>
        [GodotMethod("instance_set_base")]
        public static void InstanceSetBase(RID instance, RID @base)
        {
            NativeCalls.godot_icall_2_637(method_bind_266, ptr, RID.GetPtr(instance), RID.GetPtr(@base));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_267 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance_set_scenario");

        /// <summary>
        /// <para>Sets the scenario that the instance is in. The scenario is the 3D world that the objects will be displayed in.</para>
        /// </summary>
        [GodotMethod("instance_set_scenario")]
        public static void InstanceSetScenario(RID instance, RID scenario)
        {
            NativeCalls.godot_icall_2_637(method_bind_267, ptr, RID.GetPtr(instance), RID.GetPtr(scenario));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_268 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance_set_layer_mask");

        /// <summary>
        /// <para>Sets the render layers that this instance will be drawn to. Equivalent to <see cref="Godot.VisualInstance.Layers"/>.</para>
        /// </summary>
        [GodotMethod("instance_set_layer_mask")]
        public static void InstanceSetLayerMask(RID instance, uint mask)
        {
            NativeCalls.godot_icall_2_639(method_bind_268, ptr, RID.GetPtr(instance), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_269 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance_set_transform");

        /// <summary>
        /// <para>Sets the world space transform of the instance. Equivalent to <see cref="Godot.Spatial.Transform"/>.</para>
        /// </summary>
        [GodotMethod("instance_set_transform")]
        public static void InstanceSetTransform(RID instance, Transform transform)
        {
            NativeCalls.godot_icall_2_663(method_bind_269, ptr, RID.GetPtr(instance), ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_270 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance_attach_object_instance_id");

        /// <summary>
        /// <para>Attaches a unique Object ID to instance. Object ID must be attached to instance for proper culling with <see cref="Godot.VisualServer.InstancesCullAabb"/>, <see cref="Godot.VisualServer.InstancesCullConvex"/>, and <see cref="Godot.VisualServer.InstancesCullRay"/>.</para>
        /// </summary>
        [GodotMethod("instance_attach_object_instance_id")]
        public static void InstanceAttachObjectInstanceId(RID instance, ulong id)
        {
            NativeCalls.godot_icall_2_757(method_bind_270, ptr, RID.GetPtr(instance), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_271 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance_set_blend_shape_weight");

        /// <summary>
        /// <para>Sets the weight for a given blend shape associated with this instance.</para>
        /// </summary>
        [GodotMethod("instance_set_blend_shape_weight")]
        public static void InstanceSetBlendShapeWeight(RID instance, int shape, float weight)
        {
            NativeCalls.godot_icall_3_744(method_bind_271, ptr, RID.GetPtr(instance), shape, weight);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_272 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance_set_surface_material");

        /// <summary>
        /// <para>Sets the material of a specific surface. Equivalent to <see cref="Godot.MeshInstance.SetSurfaceMaterial"/>.</para>
        /// </summary>
        [GodotMethod("instance_set_surface_material")]
        public static void InstanceSetSurfaceMaterial(RID instance, int surface, RID material)
        {
            NativeCalls.godot_icall_3_749(method_bind_272, ptr, RID.GetPtr(instance), surface, RID.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_273 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance_set_visible");

        /// <summary>
        /// <para>Sets whether an instance is drawn or not. Equivalent to <see cref="Godot.Spatial.Visible"/>.</para>
        /// </summary>
        [GodotMethod("instance_set_visible")]
        public static void InstanceSetVisible(RID instance, bool visible)
        {
            NativeCalls.godot_icall_2_628(method_bind_273, ptr, RID.GetPtr(instance), visible);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_274 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance_set_use_lightmap");

        /// <summary>
        /// <para>Sets the lightmap to use with this instance.</para>
        /// </summary>
        /// <param name="lightmapUvRect">If the parameter is null, then the default value is new Rect2(new Vector2(0, 0), new Vector2(1, 1))</param>
        [GodotMethod("instance_set_use_lightmap")]
        public static void InstanceSetUseLightmap(RID instance, RID lightmapInstance, RID lightmap, int lightmapSlice = -1, Nullable<Rect2> lightmapUvRect = null)
        {
            Rect2 lightmapUvRect_in = lightmapUvRect.HasValue ? lightmapUvRect.Value : new Rect2(new Vector2(0, 0), new Vector2(1, 1));
            NativeCalls.godot_icall_5_1100(method_bind_274, ptr, RID.GetPtr(instance), RID.GetPtr(lightmapInstance), RID.GetPtr(lightmap), lightmapSlice, ref lightmapUvRect_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_275 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance_set_custom_aabb");

        /// <summary>
        /// <para>Sets a custom AABB to use when culling objects from the view frustum. Equivalent to <see cref="Godot.GeometryInstance.SetCustomAabb"/>.</para>
        /// </summary>
        [GodotMethod("instance_set_custom_aabb")]
        public static void InstanceSetCustomAabb(RID instance, AABB aabb)
        {
            NativeCalls.godot_icall_2_1071(method_bind_275, ptr, RID.GetPtr(instance), ref aabb);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_276 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance_attach_skeleton");

        /// <summary>
        /// <para>Attaches a skeleton to an instance. Removes the previous skeleton from the instance.</para>
        /// </summary>
        [GodotMethod("instance_attach_skeleton")]
        public static void InstanceAttachSkeleton(RID instance, RID skeleton)
        {
            NativeCalls.godot_icall_2_637(method_bind_276, ptr, RID.GetPtr(instance), RID.GetPtr(skeleton));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_277 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance_set_exterior");

        /// <summary>
        /// <para>Function not implemented in Godot 3.x.</para>
        /// </summary>
        [GodotMethod("instance_set_exterior")]
        public static void InstanceSetExterior(RID instance, bool enabled)
        {
            NativeCalls.godot_icall_2_628(method_bind_277, ptr, RID.GetPtr(instance), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_278 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance_set_extra_visibility_margin");

        /// <summary>
        /// <para>Sets a margin to increase the size of the AABB when culling objects from the view frustum. This allows you to avoid culling objects that fall outside the view frustum. Equivalent to <see cref="Godot.GeometryInstance.ExtraCullMargin"/>.</para>
        /// </summary>
        [GodotMethod("instance_set_extra_visibility_margin")]
        public static void InstanceSetExtraVisibilityMargin(RID instance, float margin)
        {
            NativeCalls.godot_icall_2_630(method_bind_278, ptr, RID.GetPtr(instance), margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_279 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance_geometry_set_flag");

        /// <summary>
        /// <para>Sets the flag for a given <see cref="Godot.VisualServer.InstanceFlags"/>. See <see cref="Godot.VisualServer.InstanceFlags"/> for more details.</para>
        /// </summary>
        [GodotMethod("instance_geometry_set_flag")]
        public static void InstanceGeometrySetFlag(RID instance, VisualServer.InstanceFlags flag, bool enabled)
        {
            NativeCalls.godot_icall_3_751(method_bind_279, ptr, RID.GetPtr(instance), (int)flag, enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_280 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance_geometry_set_cast_shadows_setting");

        /// <summary>
        /// <para>Sets the shadow casting setting to one of <see cref="Godot.VisualServer.ShadowCastingSetting"/>. Equivalent to <see cref="Godot.GeometryInstance.CastShadow"/>.</para>
        /// </summary>
        [GodotMethod("instance_geometry_set_cast_shadows_setting")]
        public static void InstanceGeometrySetCastShadowsSetting(RID instance, VisualServer.ShadowCastingSetting shadowCastingSetting)
        {
            NativeCalls.godot_icall_2_645(method_bind_280, ptr, RID.GetPtr(instance), (int)shadowCastingSetting);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_281 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance_geometry_set_material_override");

        /// <summary>
        /// <para>Sets a material that will override the material for all surfaces on the mesh associated with this instance. Equivalent to <see cref="Godot.GeometryInstance.MaterialOverride"/>.</para>
        /// </summary>
        [GodotMethod("instance_geometry_set_material_override")]
        public static void InstanceGeometrySetMaterialOverride(RID instance, RID material)
        {
            NativeCalls.godot_icall_2_637(method_bind_281, ptr, RID.GetPtr(instance), RID.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_282 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance_geometry_set_material_overlay");

        /// <summary>
        /// <para>Sets a material that will be rendered for all surfaces on top of active materials for the mesh associated with this instance. Equivalent to <see cref="Godot.GeometryInstance.MaterialOverlay"/>.</para>
        /// </summary>
        [GodotMethod("instance_geometry_set_material_overlay")]
        public static void InstanceGeometrySetMaterialOverlay(RID instance, RID material)
        {
            NativeCalls.godot_icall_2_637(method_bind_282, ptr, RID.GetPtr(instance), RID.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_283 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance_geometry_set_draw_range");

        /// <summary>
        /// <para>Not implemented in Godot 3.x.</para>
        /// </summary>
        [GodotMethod("instance_geometry_set_draw_range")]
        public static void InstanceGeometrySetDrawRange(RID instance, float min, float max, float minMargin, float maxMargin)
        {
            NativeCalls.godot_icall_5_1101(method_bind_283, ptr, RID.GetPtr(instance), min, max, minMargin, maxMargin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_284 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance_geometry_set_as_instance_lod");

        /// <summary>
        /// <para>Not implemented in Godot 3.x.</para>
        /// </summary>
        [GodotMethod("instance_geometry_set_as_instance_lod")]
        public static void InstanceGeometrySetAsInstanceLod(RID instance, RID asLodOfInstance)
        {
            NativeCalls.godot_icall_2_637(method_bind_284, ptr, RID.GetPtr(instance), RID.GetPtr(asLodOfInstance));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_285 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instances_cull_aabb");

        /// <summary>
        /// <para>Returns an array of object IDs intersecting with the provided AABB. Only visual 3D nodes are considered, such as <see cref="Godot.MeshInstance"/> or <see cref="Godot.DirectionalLight"/>. Use <c>@GDScript.instance_from_id</c> to obtain the actual nodes. A scenario RID must be provided, which is available in the <see cref="Godot.World"/> you want to query. This forces an update for all resources queued to update.</para>
        /// <para>Warning: This function is primarily intended for editor usage. For in-game use cases, prefer physics collision.</para>
        /// </summary>
        [GodotMethod("instances_cull_aabb")]
        public static Godot.Collections.Array InstancesCullAabb(AABB aabb, RID scenario = null)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_2_1102(method_bind_285, ptr, ref aabb, RID.GetPtr(scenario)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_286 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instances_cull_ray");

        /// <summary>
        /// <para>Returns an array of object IDs intersecting with the provided 3D ray. Only visual 3D nodes are considered, such as <see cref="Godot.MeshInstance"/> or <see cref="Godot.DirectionalLight"/>. Use <c>@GDScript.instance_from_id</c> to obtain the actual nodes. A scenario RID must be provided, which is available in the <see cref="Godot.World"/> you want to query. This forces an update for all resources queued to update.</para>
        /// <para>Warning: This function is primarily intended for editor usage. For in-game use cases, prefer physics collision.</para>
        /// </summary>
        [GodotMethod("instances_cull_ray")]
        public static Godot.Collections.Array InstancesCullRay(Vector3 from, Vector3 to, RID scenario = null)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_3_1103(method_bind_286, ptr, ref from, ref to, RID.GetPtr(scenario)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_287 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instances_cull_convex");

        /// <summary>
        /// <para>Returns an array of object IDs intersecting with the provided convex shape. Only visual 3D nodes are considered, such as <see cref="Godot.MeshInstance"/> or <see cref="Godot.DirectionalLight"/>. Use <c>@GDScript.instance_from_id</c> to obtain the actual nodes. A scenario RID must be provided, which is available in the <see cref="Godot.World"/> you want to query. This forces an update for all resources queued to update.</para>
        /// <para>Warning: This function is primarily intended for editor usage. For in-game use cases, prefer physics collision.</para>
        /// </summary>
        [GodotMethod("instances_cull_convex")]
        public static Godot.Collections.Array InstancesCullConvex(Godot.Collections.Array convex, RID scenario = null)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_2_1104(method_bind_287, ptr, convex.GetPtr(), RID.GetPtr(scenario)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_288 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_create");

        /// <summary>
        /// <para>Creates a canvas and returns the assigned <see cref="Godot.RID"/>. It can be accessed with the RID that is returned. This RID will be used in all <c>canvas_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// </summary>
        [GodotMethod("canvas_create")]
        public static RID CanvasCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_288, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_289 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_set_item_mirroring");

        /// <summary>
        /// <para>A copy of the canvas item will be drawn with a local offset of the mirroring <see cref="Godot.Vector2"/>.</para>
        /// </summary>
        [GodotMethod("canvas_set_item_mirroring")]
        public static void CanvasSetItemMirroring(RID canvas, RID item, Vector2 mirroring)
        {
            NativeCalls.godot_icall_3_1105(method_bind_289, ptr, RID.GetPtr(canvas), RID.GetPtr(item), ref mirroring);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_290 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_set_modulate");

        /// <summary>
        /// <para>Modulates all colors in the given canvas.</para>
        /// </summary>
        [GodotMethod("canvas_set_modulate")]
        public static void CanvasSetModulate(RID canvas, Color color)
        {
            NativeCalls.godot_icall_2_858(method_bind_290, ptr, RID.GetPtr(canvas), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_291 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_create");

        /// <summary>
        /// <para>Creates a new <see cref="Godot.CanvasItem"/> and returns its <see cref="Godot.RID"/>. It can be accessed with the RID that is returned. This RID will be used in all <c>canvas_item_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// </summary>
        [GodotMethod("canvas_item_create")]
        public static RID CanvasItemCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_291, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_292 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_set_parent");

        /// <summary>
        /// <para>Sets the parent for the <see cref="Godot.CanvasItem"/>. The parent can be another canvas item, or it can be the root canvas that is attached to the viewport.</para>
        /// </summary>
        [GodotMethod("canvas_item_set_parent")]
        public static void CanvasItemSetParent(RID item, RID parent)
        {
            NativeCalls.godot_icall_2_637(method_bind_292, ptr, RID.GetPtr(item), RID.GetPtr(parent));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_293 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_set_visible");

        /// <summary>
        /// <para>Sets if the canvas item (including its children) is visible.</para>
        /// </summary>
        [GodotMethod("canvas_item_set_visible")]
        public static void CanvasItemSetVisible(RID item, bool visible)
        {
            NativeCalls.godot_icall_2_628(method_bind_293, ptr, RID.GetPtr(item), visible);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_294 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_set_light_mask");

        /// <summary>
        /// <para>The light mask. See <see cref="Godot.LightOccluder2D"/> for more information on light masks.</para>
        /// </summary>
        [GodotMethod("canvas_item_set_light_mask")]
        public static void CanvasItemSetLightMask(RID item, int mask)
        {
            NativeCalls.godot_icall_2_645(method_bind_294, ptr, RID.GetPtr(item), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_295 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_set_transform");

        /// <summary>
        /// <para>Sets the <see cref="Godot.CanvasItem"/>'s <see cref="Godot.Transform2D"/>.</para>
        /// </summary>
        [GodotMethod("canvas_item_set_transform")]
        public static void CanvasItemSetTransform(RID item, Transform2D transform)
        {
            NativeCalls.godot_icall_2_641(method_bind_295, ptr, RID.GetPtr(item), ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_296 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_set_clip");

        /// <summary>
        /// <para>Sets clipping for the <see cref="Godot.CanvasItem"/>.</para>
        /// </summary>
        [GodotMethod("canvas_item_set_clip")]
        public static void CanvasItemSetClip(RID item, bool clip)
        {
            NativeCalls.godot_icall_2_628(method_bind_296, ptr, RID.GetPtr(item), clip);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_297 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_set_distance_field_mode");

        /// <summary>
        /// <para>Enables the use of distance fields for GUI elements that are rendering distance field based fonts.</para>
        /// </summary>
        [GodotMethod("canvas_item_set_distance_field_mode")]
        public static void CanvasItemSetDistanceFieldMode(RID item, bool enabled)
        {
            NativeCalls.godot_icall_2_628(method_bind_297, ptr, RID.GetPtr(item), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_298 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_set_custom_rect");

        /// <summary>
        /// <para>Defines a custom drawing rectangle for the <see cref="Godot.CanvasItem"/>.</para>
        /// </summary>
        /// <param name="rect">If the parameter is null, then the default value is new Rect2(new Vector2(0, 0), new Vector2(0, 0))</param>
        [GodotMethod("canvas_item_set_custom_rect")]
        public static void CanvasItemSetCustomRect(RID item, bool useCustomRect, Nullable<Rect2> rect = null)
        {
            Rect2 rect_in = rect.HasValue ? rect.Value : new Rect2(new Vector2(0, 0), new Vector2(0, 0));
            NativeCalls.godot_icall_3_1106(method_bind_298, ptr, RID.GetPtr(item), useCustomRect, ref rect_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_299 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_set_modulate");

        /// <summary>
        /// <para>Sets the color that modulates the <see cref="Godot.CanvasItem"/> and its children.</para>
        /// </summary>
        [GodotMethod("canvas_item_set_modulate")]
        public static void CanvasItemSetModulate(RID item, Color color)
        {
            NativeCalls.godot_icall_2_858(method_bind_299, ptr, RID.GetPtr(item), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_300 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_set_self_modulate");

        /// <summary>
        /// <para>Sets the color that modulates the <see cref="Godot.CanvasItem"/> without children.</para>
        /// </summary>
        [GodotMethod("canvas_item_set_self_modulate")]
        public static void CanvasItemSetSelfModulate(RID item, Color color)
        {
            NativeCalls.godot_icall_2_858(method_bind_300, ptr, RID.GetPtr(item), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_301 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_set_draw_behind_parent");

        /// <summary>
        /// <para>Sets <see cref="Godot.CanvasItem"/> to be drawn behind its parent.</para>
        /// </summary>
        [GodotMethod("canvas_item_set_draw_behind_parent")]
        public static void CanvasItemSetDrawBehindParent(RID item, bool enabled)
        {
            NativeCalls.godot_icall_2_628(method_bind_301, ptr, RID.GetPtr(item), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_302 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_add_line");

        /// <summary>
        /// <para>Adds a line command to the <see cref="Godot.CanvasItem"/>'s draw commands.</para>
        /// </summary>
        [GodotMethod("canvas_item_add_line")]
        public static void CanvasItemAddLine(RID item, Vector2 from, Vector2 to, Color color, float width = 1f, bool antialiased = false)
        {
            NativeCalls.godot_icall_6_1107(method_bind_302, ptr, RID.GetPtr(item), ref from, ref to, ref color, width, antialiased);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_303 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_add_polyline");

        /// <summary>
        /// <para>Adds a polyline, which is a line from multiple points with a width, to the <see cref="Godot.CanvasItem"/>'s draw commands.</para>
        /// </summary>
        [GodotMethod("canvas_item_add_polyline")]
        public static void CanvasItemAddPolyline(RID item, Vector2[] points, Color[] colors, float width = 1f, bool antialiased = false)
        {
            NativeCalls.godot_icall_5_1108(method_bind_303, ptr, RID.GetPtr(item), points, colors, width, antialiased);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_304 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_add_rect");

        /// <summary>
        /// <para>Adds a rectangle to the <see cref="Godot.CanvasItem"/>'s draw commands.</para>
        /// </summary>
        [GodotMethod("canvas_item_add_rect")]
        public static void CanvasItemAddRect(RID item, Rect2 rect, Color color)
        {
            NativeCalls.godot_icall_3_1109(method_bind_304, ptr, RID.GetPtr(item), ref rect, ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_305 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_add_circle");

        /// <summary>
        /// <para>Adds a circle command to the <see cref="Godot.CanvasItem"/>'s draw commands.</para>
        /// </summary>
        [GodotMethod("canvas_item_add_circle")]
        public static void CanvasItemAddCircle(RID item, Vector2 pos, float radius, Color color)
        {
            NativeCalls.godot_icall_4_1110(method_bind_305, ptr, RID.GetPtr(item), ref pos, radius, ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_306 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_add_texture_rect");

        /// <summary>
        /// <para>Adds a textured rect to the <see cref="Godot.CanvasItem"/>'s draw commands.</para>
        /// </summary>
        /// <param name="modulate">If the parameter is null, then the default value is new Color(1, 1, 1, 1)</param>
        [GodotMethod("canvas_item_add_texture_rect")]
        public static void CanvasItemAddTextureRect(RID item, Rect2 rect, RID texture, bool tile = false, Nullable<Color> modulate = null, bool transpose = false, RID normalMap = null)
        {
            Color modulate_in = modulate.HasValue ? modulate.Value : new Color(1, 1, 1, 1);
            NativeCalls.godot_icall_7_1111(method_bind_306, ptr, RID.GetPtr(item), ref rect, RID.GetPtr(texture), tile, ref modulate_in, transpose, RID.GetPtr(normalMap));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_307 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_add_texture_rect_region");

        /// <summary>
        /// <para>Adds a texture rect with region setting to the <see cref="Godot.CanvasItem"/>'s draw commands.</para>
        /// </summary>
        /// <param name="modulate">If the parameter is null, then the default value is new Color(1, 1, 1, 1)</param>
        [GodotMethod("canvas_item_add_texture_rect_region")]
        public static void CanvasItemAddTextureRectRegion(RID item, Rect2 rect, RID texture, Rect2 srcRect, Nullable<Color> modulate = null, bool transpose = false, RID normalMap = null, bool clipUv = true)
        {
            Color modulate_in = modulate.HasValue ? modulate.Value : new Color(1, 1, 1, 1);
            NativeCalls.godot_icall_8_1112(method_bind_307, ptr, RID.GetPtr(item), ref rect, RID.GetPtr(texture), ref srcRect, ref modulate_in, transpose, RID.GetPtr(normalMap), clipUv);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_308 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_add_nine_patch");

        /// <summary>
        /// <para>Adds a nine patch image to the <see cref="Godot.CanvasItem"/>'s draw commands.</para>
        /// <para>See <see cref="Godot.NinePatchRect"/> for more explanation.</para>
        /// </summary>
        /// <param name="modulate">If the parameter is null, then the default value is new Color(1, 1, 1, 1)</param>
        [GodotMethod("canvas_item_add_nine_patch")]
        public static void CanvasItemAddNinePatch(RID item, Rect2 rect, Rect2 source, RID texture, Vector2 topleft, Vector2 bottomright, VisualServer.NinePatchAxisMode xAxisMode = (VisualServer.NinePatchAxisMode)0, VisualServer.NinePatchAxisMode yAxisMode = (VisualServer.NinePatchAxisMode)0, bool drawCenter = true, Nullable<Color> modulate = null, RID normalMap = null)
        {
            Color modulate_in = modulate.HasValue ? modulate.Value : new Color(1, 1, 1, 1);
            NativeCalls.godot_icall_11_1113(method_bind_308, ptr, RID.GetPtr(item), ref rect, ref source, RID.GetPtr(texture), ref topleft, ref bottomright, (int)xAxisMode, (int)yAxisMode, drawCenter, ref modulate_in, RID.GetPtr(normalMap));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_309 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_add_primitive");

        /// <summary>
        /// <para>Adds a primitive to the <see cref="Godot.CanvasItem"/>'s draw commands.</para>
        /// </summary>
        [GodotMethod("canvas_item_add_primitive")]
        public static void CanvasItemAddPrimitive(RID item, Vector2[] points, Color[] colors, Vector2[] uvs, RID texture, float width = 1f, RID normalMap = null)
        {
            NativeCalls.godot_icall_7_1114(method_bind_309, ptr, RID.GetPtr(item), points, colors, uvs, RID.GetPtr(texture), width, RID.GetPtr(normalMap));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_310 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_add_polygon");

        /// <summary>
        /// <para>Adds a polygon to the <see cref="Godot.CanvasItem"/>'s draw commands.</para>
        /// </summary>
        /// <param name="uvs">If the parameter is null, then the default value is Array.Empty&lt;Vector2&gt;()</param>
        [GodotMethod("canvas_item_add_polygon")]
        public static void CanvasItemAddPolygon(RID item, Vector2[] points, Color[] colors, Vector2[] uvs = null, RID texture = null, RID normalMap = null, bool antialiased = false)
        {
            Vector2[] uvs_in = uvs != null ? uvs : Array.Empty<Vector2>();
            NativeCalls.godot_icall_7_1115(method_bind_310, ptr, RID.GetPtr(item), points, colors, uvs_in, RID.GetPtr(texture), RID.GetPtr(normalMap), antialiased);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_311 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_add_triangle_array");

        /// <summary>
        /// <para>Adds a triangle array to the <see cref="Godot.CanvasItem"/>'s draw commands.</para>
        /// </summary>
        /// <param name="uvs">If the parameter is null, then the default value is Array.Empty&lt;Vector2&gt;()</param>
        /// <param name="bones">If the parameter is null, then the default value is Array.Empty&lt;int&gt;()</param>
        /// <param name="weights">If the parameter is null, then the default value is Array.Empty&lt;float&gt;()</param>
        [GodotMethod("canvas_item_add_triangle_array")]
        public static void CanvasItemAddTriangleArray(RID item, int[] indices, Vector2[] points, Color[] colors, Vector2[] uvs = null, int[] bones = null, float[] weights = null, RID texture = null, int count = -1, RID normalMap = null, bool antialiased = false, bool antialiasingUseIndices = false)
        {
            Vector2[] uvs_in = uvs != null ? uvs : Array.Empty<Vector2>();
            int[] bones_in = bones != null ? bones : Array.Empty<int>();
            float[] weights_in = weights != null ? weights : Array.Empty<float>();
            NativeCalls.godot_icall_12_1116(method_bind_311, ptr, RID.GetPtr(item), indices, points, colors, uvs_in, bones_in, weights_in, RID.GetPtr(texture), count, RID.GetPtr(normalMap), antialiased, antialiasingUseIndices);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_312 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_add_mesh");

        /// <summary>
        /// <para>Adds a mesh command to the <see cref="Godot.CanvasItem"/>'s draw commands.</para>
        /// </summary>
        /// <param name="transform">If the parameter is null, then the default value is Transform2D.Identity</param>
        /// <param name="modulate">If the parameter is null, then the default value is new Color(1, 1, 1, 1)</param>
        [GodotMethod("canvas_item_add_mesh")]
        public static void CanvasItemAddMesh(RID item, RID mesh, Nullable<Transform2D> transform = null, Nullable<Color> modulate = null, RID texture = null, RID normalMap = null)
        {
            Transform2D transform_in = transform.HasValue ? transform.Value : Transform2D.Identity;
            Color modulate_in = modulate.HasValue ? modulate.Value : new Color(1, 1, 1, 1);
            NativeCalls.godot_icall_6_1117(method_bind_312, ptr, RID.GetPtr(item), RID.GetPtr(mesh), ref transform_in, ref modulate_in, RID.GetPtr(texture), RID.GetPtr(normalMap));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_313 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_add_multimesh");

        /// <summary>
        /// <para>Adds a <see cref="Godot.MultiMesh"/> to the <see cref="Godot.CanvasItem"/>'s draw commands. Only affects its aabb at the moment.</para>
        /// </summary>
        [GodotMethod("canvas_item_add_multimesh")]
        public static void CanvasItemAddMultimesh(RID item, RID mesh, RID texture, RID normalMap = null)
        {
            NativeCalls.godot_icall_4_1118(method_bind_313, ptr, RID.GetPtr(item), RID.GetPtr(mesh), RID.GetPtr(texture), RID.GetPtr(normalMap));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_314 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_add_particles");

        /// <summary>
        /// <para>Adds a particle system to the <see cref="Godot.CanvasItem"/>'s draw commands.</para>
        /// </summary>
        [GodotMethod("canvas_item_add_particles")]
        public static void CanvasItemAddParticles(RID item, RID particles, RID texture, RID normalMap)
        {
            NativeCalls.godot_icall_4_1118(method_bind_314, ptr, RID.GetPtr(item), RID.GetPtr(particles), RID.GetPtr(texture), RID.GetPtr(normalMap));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_315 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_add_set_transform");

        /// <summary>
        /// <para>Adds a <see cref="Godot.Transform2D"/> command to the <see cref="Godot.CanvasItem"/>'s draw commands.</para>
        /// <para>This sets the extra_matrix uniform when executed. This affects the later commands of the canvas item.</para>
        /// </summary>
        [GodotMethod("canvas_item_add_set_transform")]
        public static void CanvasItemAddSetTransform(RID item, Transform2D transform)
        {
            NativeCalls.godot_icall_2_641(method_bind_315, ptr, RID.GetPtr(item), ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_316 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_add_clip_ignore");

        /// <summary>
        /// <para>If ignore is <c>true</c>, the VisualServer does not perform clipping.</para>
        /// </summary>
        [GodotMethod("canvas_item_add_clip_ignore")]
        public static void CanvasItemAddClipIgnore(RID item, bool ignore)
        {
            NativeCalls.godot_icall_2_628(method_bind_316, ptr, RID.GetPtr(item), ignore);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_317 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_set_sort_children_by_y");

        /// <summary>
        /// <para>Sets if <see cref="Godot.CanvasItem"/>'s children should be sorted by y-position.</para>
        /// </summary>
        [GodotMethod("canvas_item_set_sort_children_by_y")]
        public static void CanvasItemSetSortChildrenByY(RID item, bool enabled)
        {
            NativeCalls.godot_icall_2_628(method_bind_317, ptr, RID.GetPtr(item), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_318 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_set_z_index");

        /// <summary>
        /// <para>Sets the <see cref="Godot.CanvasItem"/>'s Z index, i.e. its draw order (lower indexes are drawn first).</para>
        /// </summary>
        [GodotMethod("canvas_item_set_z_index")]
        public static void CanvasItemSetZIndex(RID item, int zIndex)
        {
            NativeCalls.godot_icall_2_645(method_bind_318, ptr, RID.GetPtr(item), zIndex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_319 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_set_z_as_relative_to_parent");

        /// <summary>
        /// <para>If this is enabled, the Z index of the parent will be added to the children's Z index.</para>
        /// </summary>
        [GodotMethod("canvas_item_set_z_as_relative_to_parent")]
        public static void CanvasItemSetZAsRelativeToParent(RID item, bool enabled)
        {
            NativeCalls.godot_icall_2_628(method_bind_319, ptr, RID.GetPtr(item), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_320 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_set_copy_to_backbuffer");

        /// <summary>
        /// <para>Sets the <see cref="Godot.CanvasItem"/> to copy a rect to the backbuffer.</para>
        /// </summary>
        [GodotMethod("canvas_item_set_copy_to_backbuffer")]
        public static void CanvasItemSetCopyToBackbuffer(RID item, bool enabled, Rect2 rect)
        {
            NativeCalls.godot_icall_3_1106(method_bind_320, ptr, RID.GetPtr(item), enabled, ref rect);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_321 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_clear");

        /// <summary>
        /// <para>Clears the <see cref="Godot.CanvasItem"/> and removes all commands in it.</para>
        /// </summary>
        [GodotMethod("canvas_item_clear")]
        public static void CanvasItemClear(RID item)
        {
            NativeCalls.godot_icall_1_285(method_bind_321, ptr, RID.GetPtr(item));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_322 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_set_draw_index");

        /// <summary>
        /// <para>Sets the index for the <see cref="Godot.CanvasItem"/>.</para>
        /// </summary>
        [GodotMethod("canvas_item_set_draw_index")]
        public static void CanvasItemSetDrawIndex(RID item, int index)
        {
            NativeCalls.godot_icall_2_645(method_bind_322, ptr, RID.GetPtr(item), index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_323 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_set_material");

        /// <summary>
        /// <para>Sets a new material to the <see cref="Godot.CanvasItem"/>.</para>
        /// </summary>
        [GodotMethod("canvas_item_set_material")]
        public static void CanvasItemSetMaterial(RID item, RID material)
        {
            NativeCalls.godot_icall_2_637(method_bind_323, ptr, RID.GetPtr(item), RID.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_324 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_item_set_use_parent_material");

        /// <summary>
        /// <para>Sets if the <see cref="Godot.CanvasItem"/> uses its parent's material.</para>
        /// </summary>
        [GodotMethod("canvas_item_set_use_parent_material")]
        public static void CanvasItemSetUseParentMaterial(RID item, bool enabled)
        {
            NativeCalls.godot_icall_2_628(method_bind_324, ptr, RID.GetPtr(item), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_325 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_create");

        /// <summary>
        /// <para>Creates a canvas light and adds it to the VisualServer. It can be accessed with the RID that is returned. This RID will be used in all <c>canvas_light_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// </summary>
        [GodotMethod("canvas_light_create")]
        public static RID CanvasLightCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_325, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_326 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_attach_to_canvas");

        /// <summary>
        /// <para>Attaches the canvas light to the canvas. Removes it from its previous canvas.</para>
        /// </summary>
        [GodotMethod("canvas_light_attach_to_canvas")]
        public static void CanvasLightAttachToCanvas(RID light, RID canvas)
        {
            NativeCalls.godot_icall_2_637(method_bind_326, ptr, RID.GetPtr(light), RID.GetPtr(canvas));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_327 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_set_enabled");

        /// <summary>
        /// <para>Enables or disables a canvas light.</para>
        /// </summary>
        [GodotMethod("canvas_light_set_enabled")]
        public static void CanvasLightSetEnabled(RID light, bool enabled)
        {
            NativeCalls.godot_icall_2_628(method_bind_327, ptr, RID.GetPtr(light), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_328 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_set_scale");

        /// <summary>
        /// <para>Sets the texture's scale factor of the light. Equivalent to <see cref="Godot.Light2D.TextureScale"/>.</para>
        /// </summary>
        [GodotMethod("canvas_light_set_scale")]
        public static void CanvasLightSetScale(RID light, float scale)
        {
            NativeCalls.godot_icall_2_630(method_bind_328, ptr, RID.GetPtr(light), scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_329 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_set_transform");

        /// <summary>
        /// <para>Sets the canvas light's <see cref="Godot.Transform2D"/>.</para>
        /// </summary>
        [GodotMethod("canvas_light_set_transform")]
        public static void CanvasLightSetTransform(RID light, Transform2D transform)
        {
            NativeCalls.godot_icall_2_641(method_bind_329, ptr, RID.GetPtr(light), ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_330 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_set_texture");

        /// <summary>
        /// <para>Sets texture to be used by light. Equivalent to <see cref="Godot.Light2D.Texture"/>.</para>
        /// </summary>
        [GodotMethod("canvas_light_set_texture")]
        public static void CanvasLightSetTexture(RID light, RID texture)
        {
            NativeCalls.godot_icall_2_637(method_bind_330, ptr, RID.GetPtr(light), RID.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_331 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_set_texture_offset");

        /// <summary>
        /// <para>Sets the offset of the light's texture. Equivalent to <see cref="Godot.Light2D.Offset"/>.</para>
        /// </summary>
        [GodotMethod("canvas_light_set_texture_offset")]
        public static void CanvasLightSetTextureOffset(RID light, Vector2 offset)
        {
            NativeCalls.godot_icall_2_646(method_bind_331, ptr, RID.GetPtr(light), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_332 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_set_color");

        /// <summary>
        /// <para>Sets the color for a light.</para>
        /// </summary>
        [GodotMethod("canvas_light_set_color")]
        public static void CanvasLightSetColor(RID light, Color color)
        {
            NativeCalls.godot_icall_2_858(method_bind_332, ptr, RID.GetPtr(light), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_333 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_set_height");

        /// <summary>
        /// <para>Sets a canvas light's height.</para>
        /// </summary>
        [GodotMethod("canvas_light_set_height")]
        public static void CanvasLightSetHeight(RID light, float height)
        {
            NativeCalls.godot_icall_2_630(method_bind_333, ptr, RID.GetPtr(light), height);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_334 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_set_energy");

        /// <summary>
        /// <para>Sets a canvas light's energy.</para>
        /// </summary>
        [GodotMethod("canvas_light_set_energy")]
        public static void CanvasLightSetEnergy(RID light, float energy)
        {
            NativeCalls.godot_icall_2_630(method_bind_334, ptr, RID.GetPtr(light), energy);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_335 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_set_z_range");

        /// <summary>
        /// <para>Sets the Z range of objects that will be affected by this light. Equivalent to <see cref="Godot.Light2D.RangeZMin"/> and <see cref="Godot.Light2D.RangeZMax"/>.</para>
        /// </summary>
        [GodotMethod("canvas_light_set_z_range")]
        public static void CanvasLightSetZRange(RID light, int minZ, int maxZ)
        {
            NativeCalls.godot_icall_3_1084(method_bind_335, ptr, RID.GetPtr(light), minZ, maxZ);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_336 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_set_layer_range");

        /// <summary>
        /// <para>The layer range that gets rendered with this light.</para>
        /// </summary>
        [GodotMethod("canvas_light_set_layer_range")]
        public static void CanvasLightSetLayerRange(RID light, int minLayer, int maxLayer)
        {
            NativeCalls.godot_icall_3_1084(method_bind_336, ptr, RID.GetPtr(light), minLayer, maxLayer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_337 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_set_item_cull_mask");

        /// <summary>
        /// <para>The light mask. See <see cref="Godot.LightOccluder2D"/> for more information on light masks.</para>
        /// </summary>
        [GodotMethod("canvas_light_set_item_cull_mask")]
        public static void CanvasLightSetItemCullMask(RID light, int mask)
        {
            NativeCalls.godot_icall_2_645(method_bind_337, ptr, RID.GetPtr(light), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_338 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_set_item_shadow_cull_mask");

        /// <summary>
        /// <para>The binary mask used to determine which layers this canvas light's shadows affects. See <see cref="Godot.LightOccluder2D"/> for more information on light masks.</para>
        /// </summary>
        [GodotMethod("canvas_light_set_item_shadow_cull_mask")]
        public static void CanvasLightSetItemShadowCullMask(RID light, int mask)
        {
            NativeCalls.godot_icall_2_645(method_bind_338, ptr, RID.GetPtr(light), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_339 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_set_mode");

        /// <summary>
        /// <para>The mode of the light, see <see cref="Godot.VisualServer.CanvasLightMode"/> constants.</para>
        /// </summary>
        [GodotMethod("canvas_light_set_mode")]
        public static void CanvasLightSetMode(RID light, VisualServer.CanvasLightMode mode)
        {
            NativeCalls.godot_icall_2_645(method_bind_339, ptr, RID.GetPtr(light), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_340 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_set_shadow_enabled");

        /// <summary>
        /// <para>Enables or disables the canvas light's shadow.</para>
        /// </summary>
        [GodotMethod("canvas_light_set_shadow_enabled")]
        public static void CanvasLightSetShadowEnabled(RID light, bool enabled)
        {
            NativeCalls.godot_icall_2_628(method_bind_340, ptr, RID.GetPtr(light), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_341 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_set_shadow_buffer_size");

        /// <summary>
        /// <para>Sets the width of the shadow buffer, size gets scaled to the next power of two for this.</para>
        /// </summary>
        [GodotMethod("canvas_light_set_shadow_buffer_size")]
        public static void CanvasLightSetShadowBufferSize(RID light, int size)
        {
            NativeCalls.godot_icall_2_645(method_bind_341, ptr, RID.GetPtr(light), size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_342 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_set_shadow_gradient_length");

        /// <summary>
        /// <para>Sets the length of the shadow's gradient.</para>
        /// </summary>
        [GodotMethod("canvas_light_set_shadow_gradient_length")]
        public static void CanvasLightSetShadowGradientLength(RID light, float length)
        {
            NativeCalls.godot_icall_2_630(method_bind_342, ptr, RID.GetPtr(light), length);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_343 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_set_shadow_filter");

        /// <summary>
        /// <para>Sets the canvas light's shadow's filter, see <see cref="Godot.VisualServer.CanvasLightShadowFilter"/> constants.</para>
        /// </summary>
        [GodotMethod("canvas_light_set_shadow_filter")]
        public static void CanvasLightSetShadowFilter(RID light, VisualServer.CanvasLightShadowFilter filter)
        {
            NativeCalls.godot_icall_2_645(method_bind_343, ptr, RID.GetPtr(light), (int)filter);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_344 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_set_shadow_color");

        /// <summary>
        /// <para>Sets the color of the canvas light's shadow.</para>
        /// </summary>
        [GodotMethod("canvas_light_set_shadow_color")]
        public static void CanvasLightSetShadowColor(RID light, Color color)
        {
            NativeCalls.godot_icall_2_858(method_bind_344, ptr, RID.GetPtr(light), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_345 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_set_shadow_smooth");

        /// <summary>
        /// <para>Smoothens the shadow. The lower, the smoother.</para>
        /// </summary>
        [GodotMethod("canvas_light_set_shadow_smooth")]
        public static void CanvasLightSetShadowSmooth(RID light, float smooth)
        {
            NativeCalls.godot_icall_2_630(method_bind_345, ptr, RID.GetPtr(light), smooth);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_346 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_occluder_create");

        /// <summary>
        /// <para>Creates a light occluder and adds it to the VisualServer. It can be accessed with the RID that is returned. This RID will be used in all <c>canvas_light_ocluder_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// </summary>
        [GodotMethod("canvas_light_occluder_create")]
        public static RID CanvasLightOccluderCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_346, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_347 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_occluder_attach_to_canvas");

        /// <summary>
        /// <para>Attaches a light occluder to the canvas. Removes it from its previous canvas.</para>
        /// </summary>
        [GodotMethod("canvas_light_occluder_attach_to_canvas")]
        public static void CanvasLightOccluderAttachToCanvas(RID occluder, RID canvas)
        {
            NativeCalls.godot_icall_2_637(method_bind_347, ptr, RID.GetPtr(occluder), RID.GetPtr(canvas));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_348 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_occluder_set_enabled");

        /// <summary>
        /// <para>Enables or disables light occluder.</para>
        /// </summary>
        [GodotMethod("canvas_light_occluder_set_enabled")]
        public static void CanvasLightOccluderSetEnabled(RID occluder, bool enabled)
        {
            NativeCalls.godot_icall_2_628(method_bind_348, ptr, RID.GetPtr(occluder), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_349 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_occluder_set_polygon");

        /// <summary>
        /// <para>Sets a light occluder's polygon.</para>
        /// </summary>
        [GodotMethod("canvas_light_occluder_set_polygon")]
        public static void CanvasLightOccluderSetPolygon(RID occluder, RID polygon)
        {
            NativeCalls.godot_icall_2_637(method_bind_349, ptr, RID.GetPtr(occluder), RID.GetPtr(polygon));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_350 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_occluder_set_transform");

        /// <summary>
        /// <para>Sets a light occluder's <see cref="Godot.Transform2D"/>.</para>
        /// </summary>
        [GodotMethod("canvas_light_occluder_set_transform")]
        public static void CanvasLightOccluderSetTransform(RID occluder, Transform2D transform)
        {
            NativeCalls.godot_icall_2_641(method_bind_350, ptr, RID.GetPtr(occluder), ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_351 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_light_occluder_set_light_mask");

        /// <summary>
        /// <para>The light mask. See <see cref="Godot.LightOccluder2D"/> for more information on light masks.</para>
        /// </summary>
        [GodotMethod("canvas_light_occluder_set_light_mask")]
        public static void CanvasLightOccluderSetLightMask(RID occluder, int mask)
        {
            NativeCalls.godot_icall_2_645(method_bind_351, ptr, RID.GetPtr(occluder), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_352 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_occluder_polygon_create");

        /// <summary>
        /// <para>Creates a new light occluder polygon and adds it to the VisualServer. It can be accessed with the RID that is returned. This RID will be used in all <c>canvas_occluder_polygon_*</c> VisualServer functions.</para>
        /// <para>Once finished with your RID, you will want to free the RID using the VisualServer's <see cref="Godot.VisualServer.FreeRid"/> static method.</para>
        /// </summary>
        [GodotMethod("canvas_occluder_polygon_create")]
        public static RID CanvasOccluderPolygonCreate()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_352, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_353 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_occluder_polygon_set_shape");

        /// <summary>
        /// <para>Sets the shape of the occluder polygon.</para>
        /// </summary>
        [GodotMethod("canvas_occluder_polygon_set_shape")]
        public static void CanvasOccluderPolygonSetShape(RID occluderPolygon, Vector2[] shape, bool closed)
        {
            NativeCalls.godot_icall_3_1119(method_bind_353, ptr, RID.GetPtr(occluderPolygon), shape, closed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_354 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_occluder_polygon_set_shape_as_lines");

        /// <summary>
        /// <para>Sets the shape of the occluder polygon as lines.</para>
        /// </summary>
        [GodotMethod("canvas_occluder_polygon_set_shape_as_lines")]
        public static void CanvasOccluderPolygonSetShapeAsLines(RID occluderPolygon, Vector2[] shape)
        {
            NativeCalls.godot_icall_2_1120(method_bind_354, ptr, RID.GetPtr(occluderPolygon), shape);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_355 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "canvas_occluder_polygon_set_cull_mode");

        /// <summary>
        /// <para>Sets an occluder polygons cull mode. See <see cref="Godot.VisualServer.CanvasOccluderPolygonCullMode"/> constants.</para>
        /// </summary>
        [GodotMethod("canvas_occluder_polygon_set_cull_mode")]
        public static void CanvasOccluderPolygonSetCullMode(RID occluderPolygon, VisualServer.CanvasOccluderPolygonCullMode mode)
        {
            NativeCalls.godot_icall_2_645(method_bind_355, ptr, RID.GetPtr(occluderPolygon), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_356 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "black_bars_set_margins");

        /// <summary>
        /// <para>Sets margin size, where black bars (or images, if <see cref="Godot.VisualServer.BlackBarsSetImages"/> was used) are rendered.</para>
        /// </summary>
        [GodotMethod("black_bars_set_margins")]
        public static void BlackBarsSetMargins(int left, int top, int right, int bottom)
        {
            NativeCalls.godot_icall_4_101(method_bind_356, ptr, left, top, right, bottom);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_357 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "black_bars_set_images");

        /// <summary>
        /// <para>Sets images to be rendered in the window margin.</para>
        /// </summary>
        [GodotMethod("black_bars_set_images")]
        public static void BlackBarsSetImages(RID left, RID top, RID right, RID bottom)
        {
            NativeCalls.godot_icall_4_1118(method_bind_357, ptr, RID.GetPtr(left), RID.GetPtr(top), RID.GetPtr(right), RID.GetPtr(bottom));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_358 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "free_rid");

        /// <summary>
        /// <para>Tries to free an object in the VisualServer.</para>
        /// </summary>
        [GodotMethod("free_rid")]
        public static void FreeRid(RID rid)
        {
            NativeCalls.godot_icall_1_285(method_bind_358, ptr, RID.GetPtr(rid));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_359 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "request_frame_drawn_callback");

        /// <summary>
        /// <para>Schedules a callback to the corresponding named <c>method</c> on <c>where</c> after a frame has been drawn.</para>
        /// <para>The callback method must use only 1 argument which will be called with <c>userdata</c>.</para>
        /// </summary>
        [GodotMethod("request_frame_drawn_callback")]
        public static void RequestFrameDrawnCallback(Object where, string method, object userdata)
        {
            NativeCalls.godot_icall_3_1007(method_bind_359, ptr, Object.GetPtr(where), method, userdata);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_360 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_changed");

        /// <summary>
        /// <para>Returns <c>true</c> if changes have been made to the VisualServer's data. <see cref="Godot.VisualServer.Draw"/> is usually called if this happens.</para>
        /// <para>As changes are registered as either high or low priority (e.g. dynamic shaders), this function takes an optional argument to query either low or high priority changes, or any changes.</para>
        /// </summary>
        [GodotMethod("has_changed")]
        public static bool HasChanged(VisualServer.ChangedPriority queriedPriority = (VisualServer.ChangedPriority)0)
        {
            return NativeCalls.godot_icall_1_35(method_bind_360, ptr, (int)queriedPriority);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_361 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "init");

        /// <summary>
        /// <para>Initializes the visual server. This function is called internally by platform-dependent code during engine initialization. If called from a running game, it will not do anything.</para>
        /// </summary>
        [GodotMethod("init")]
        public static void Init()
        {
            NativeCalls.godot_icall_0_3(method_bind_361, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_362 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "finish");

        /// <summary>
        /// <para>Removes buffers and clears testcubes.</para>
        /// </summary>
        [GodotMethod("finish")]
        public static void Finish()
        {
            NativeCalls.godot_icall_0_3(method_bind_362, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_363 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_render_info");

        /// <summary>
        /// <para>Returns a certain information, see <see cref="Godot.VisualServer.RenderInfo"/> for options.</para>
        /// </summary>
        [GodotMethod("get_render_info")]
        public static ulong GetRenderInfo(VisualServer.RenderInfo info)
        {
            return NativeCalls.godot_icall_1_732(method_bind_363, ptr, (int)info);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_364 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_video_adapter_name");

        /// <summary>
        /// <para>Returns the name of the video adapter (e.g. "GeForce GTX 1080/PCIe/SSE2").</para>
        /// <para>Note: When running a headless or server binary, this function returns an empty string.</para>
        /// </summary>
        [GodotMethod("get_video_adapter_name")]
        public static string GetVideoAdapterName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_364, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_365 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_video_adapter_vendor");

        /// <summary>
        /// <para>Returns the vendor of the video adapter (e.g. "NVIDIA Corporation").</para>
        /// <para>Note: When running a headless or server binary, this function returns an empty string.</para>
        /// </summary>
        [GodotMethod("get_video_adapter_vendor")]
        public static string GetVideoAdapterVendor()
        {
            return NativeCalls.godot_icall_0_6(method_bind_365, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_366 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "make_sphere_mesh");

        /// <summary>
        /// <para>Returns a mesh of a sphere with the given amount of horizontal and vertical subdivisions.</para>
        /// </summary>
        [GodotMethod("make_sphere_mesh")]
        public static RID MakeSphereMesh(int latitudes, int longitudes, float radius)
        {
            return new RID(NativeCalls.godot_icall_3_1121(method_bind_366, ptr, latitudes, longitudes, radius));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_367 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_test_cube");

        /// <summary>
        /// <para>Returns the id of the test cube. Creates one if none exists.</para>
        /// </summary>
        [GodotMethod("get_test_cube")]
        public static RID GetTestCube()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_367, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_368 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_test_texture");

        /// <summary>
        /// <para>Returns the id of the test texture. Creates one if none exists.</para>
        /// </summary>
        [GodotMethod("get_test_texture")]
        public static RID GetTestTexture()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_368, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_369 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_white_texture");

        /// <summary>
        /// <para>Returns the id of a white texture. Creates one if none exists.</para>
        /// </summary>
        [GodotMethod("get_white_texture")]
        public static RID GetWhiteTexture()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_369, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_370 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_boot_image");

        /// <summary>
        /// <para>Sets a boot image. The color defines the background color. If <c>scale</c> is <c>true</c>, the image will be scaled to fit the screen size. If <c>use_filter</c> is <c>true</c>, the image will be scaled with linear interpolation. If <c>use_filter</c> is <c>false</c>, the image will be scaled with nearest-neighbor interpolation.</para>
        /// </summary>
        [GodotMethod("set_boot_image")]
        public static void SetBootImage(Image image, Color color, bool scale, bool useFilter = true)
        {
            NativeCalls.godot_icall_4_1122(method_bind_370, ptr, Object.GetPtr(image), ref color, scale, useFilter);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_371 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_default_clear_color");

        /// <summary>
        /// <para>Sets the default clear color which is used when a specific clear color has not been selected.</para>
        /// </summary>
        [GodotMethod("set_default_clear_color")]
        public static void SetDefaultClearColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_371, ptr, ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_372 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shader_time_scale");

        /// <summary>
        /// <para>Sets the scale to apply to the passage of time for the shaders' <c>TIME</c> builtin.</para>
        /// <para>The default value is <c>1.0</c>, which means <c>TIME</c> will count the real time as it goes by, without narrowing or stretching it.</para>
        /// </summary>
        [GodotMethod("set_shader_time_scale")]
        public static void SetShaderTimeScale(float scale)
        {
            NativeCalls.godot_icall_1_15(method_bind_372, ptr, scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_373 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_feature");

        /// <summary>
        /// <para>Not yet implemented. Always returns <c>false</c>.</para>
        /// </summary>
        [GodotMethod("has_feature")]
        public static bool HasFeature(VisualServer.Features feature)
        {
            return NativeCalls.godot_icall_1_35(method_bind_373, ptr, (int)feature);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_374 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_os_feature");

        /// <summary>
        /// <para>Returns <c>true</c> if the OS supports a certain feature. Features might be <c>s3tc</c>, <c>etc</c>, <c>etc2</c>, <c>pvrtc</c> and <c>skinning_fallback</c>.</para>
        /// <para>When rendering with GLES2, returns <c>true</c> with <c>skinning_fallback</c> in case the hardware doesn't support the default GPU skinning process.</para>
        /// </summary>
        [GodotMethod("has_os_feature")]
        public static bool HasOsFeature(string feature)
        {
            return NativeCalls.godot_icall_1_108(method_bind_374, ptr, feature);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_375 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_debug_generate_wireframes");

        /// <summary>
        /// <para>If <c>true</c>, the engine will generate wireframes for use with the wireframe debug mode.</para>
        /// </summary>
        [GodotMethod("set_debug_generate_wireframes")]
        public static void SetDebugGenerateWireframes(bool generate)
        {
            NativeCalls.godot_icall_1_16(method_bind_375, ptr, generate);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_376 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_occlusion_culling");

        /// <summary>
        /// <para>Enables or disables occlusion culling.</para>
        /// </summary>
        [GodotMethod("set_use_occlusion_culling")]
        public static void SetUseOcclusionCulling(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_376, ptr, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_377 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_render_loop_enabled");

        [GodotMethod("is_render_loop_enabled")]
        [Obsolete("IsRenderLoopEnabled is deprecated. Use the RenderLoopEnabled property instead.")]
        public static bool IsRenderLoopEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_377, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_378 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_render_loop_enabled");

        [GodotMethod("set_render_loop_enabled")]
        [Obsolete("SetRenderLoopEnabled is deprecated. Use the RenderLoopEnabled property instead.")]
        public static void SetRenderLoopEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_378, ptr, enabled);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
