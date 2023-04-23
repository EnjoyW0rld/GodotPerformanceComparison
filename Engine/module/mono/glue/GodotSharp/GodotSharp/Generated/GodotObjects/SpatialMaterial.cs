using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This provides a default material with a wide variety of rendering features and properties without the need to write shader code. See the tutorial below for details.</para>
    /// </summary>
    public partial class SpatialMaterial : Material
    {
        public enum AsyncModeEnum
        {
            /// <summary>
            /// <para>The real conditioned shader needed on each situation will be sent for background compilation. In the meantime, a very complex shader that adapts to every situation will be used ("ubershader"). This ubershader is much slower to render, but will keep the game running without stalling to compile. Once shader compilation is done, the ubershader is replaced by the traditional optimized shader.</para>
            /// </summary>
            Visible = 0,
            /// <summary>
            /// <para>Anything with this material applied won't be rendered while this material's shader is being compiled.</para>
            /// <para>This is useful for optimization, in cases where the visuals won't suffer from having certain non-essential elements missing during the short time their shaders are being compiled.</para>
            /// </summary>
            Hidden = 1
        }

        public enum EmissionOperatorEnum
        {
            /// <summary>
            /// <para>Adds the emission color to the color from the emission texture.</para>
            /// </summary>
            Add = 0,
            /// <summary>
            /// <para>Multiplies the emission color by the color from the emission texture.</para>
            /// </summary>
            Multiply = 1
        }

        public enum DiffuseMode
        {
            /// <summary>
            /// <para>Default diffuse scattering algorithm.</para>
            /// </summary>
            Burley = 0,
            /// <summary>
            /// <para>Diffuse scattering ignores roughness.</para>
            /// </summary>
            Lambert = 1,
            /// <summary>
            /// <para>Extends Lambert to cover more than 90 degrees when roughness increases.</para>
            /// </summary>
            LambertWrap = 2,
            /// <summary>
            /// <para>Attempts to use roughness to emulate microsurfacing.</para>
            /// </summary>
            OrenNayar = 3,
            /// <summary>
            /// <para>Uses a hard cut for lighting, with smoothing affected by roughness.</para>
            /// </summary>
            Toon = 4
        }

        public enum SpecularMode
        {
            /// <summary>
            /// <para>Default specular blob.</para>
            /// </summary>
            SchlickGgx = 0,
            /// <summary>
            /// <para>Older specular algorithm, included for compatibility.</para>
            /// </summary>
            Blinn = 1,
            /// <summary>
            /// <para>Older specular algorithm, included for compatibility.</para>
            /// </summary>
            Phong = 2,
            /// <summary>
            /// <para>Toon blob which changes size based on roughness.</para>
            /// </summary>
            Toon = 3,
            /// <summary>
            /// <para>No specular blob.</para>
            /// </summary>
            Disabled = 4
        }

        public enum Feature
        {
            /// <summary>
            /// <para>Constant for setting <see cref="Godot.SpatialMaterial.FlagsTransparent"/>.</para>
            /// </summary>
            Transparent = 0,
            /// <summary>
            /// <para>Constant for setting <see cref="Godot.SpatialMaterial.EmissionEnabled"/>.</para>
            /// </summary>
            Emission = 1,
            /// <summary>
            /// <para>Constant for setting <see cref="Godot.SpatialMaterial.NormalEnabled"/>.</para>
            /// </summary>
            NormalMapping = 2,
            /// <summary>
            /// <para>Constant for setting <see cref="Godot.SpatialMaterial.RimEnabled"/>.</para>
            /// </summary>
            Rim = 3,
            /// <summary>
            /// <para>Constant for setting <see cref="Godot.SpatialMaterial.ClearcoatEnabled"/>.</para>
            /// </summary>
            Clearcoat = 4,
            /// <summary>
            /// <para>Constant for setting <see cref="Godot.SpatialMaterial.AnisotropyEnabled"/>.</para>
            /// </summary>
            Anisotropy = 5,
            /// <summary>
            /// <para>Constant for setting <see cref="Godot.SpatialMaterial.AoEnabled"/>.</para>
            /// </summary>
            AmbientOcclusion = 6,
            /// <summary>
            /// <para>Constant for setting <see cref="Godot.SpatialMaterial.DepthEnabled"/>.</para>
            /// </summary>
            DepthMapping = 7,
            /// <summary>
            /// <para>Constant for setting <see cref="Godot.SpatialMaterial.SubsurfScatterEnabled"/>.</para>
            /// </summary>
            SubsuraceScattering = 8,
            /// <summary>
            /// <para>Constant for setting <see cref="Godot.SpatialMaterial.TransmissionEnabled"/>.</para>
            /// </summary>
            Transmission = 9,
            /// <summary>
            /// <para>Constant for setting <see cref="Godot.SpatialMaterial.RefractionEnabled"/>.</para>
            /// </summary>
            Refraction = 10,
            /// <summary>
            /// <para>Constant for setting <see cref="Godot.SpatialMaterial.DetailEnabled"/>.</para>
            /// </summary>
            Detail = 11,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.SpatialMaterial.Feature"/> enum.</para>
            /// </summary>
            Max = 12
        }

        public enum Flags
        {
            /// <summary>
            /// <para>No lighting is used on the object. Color comes directly from <c>ALBEDO</c>.</para>
            /// </summary>
            Unshaded = 0,
            /// <summary>
            /// <para>Lighting is calculated per-vertex rather than per-pixel. This can be used to increase the speed of the shader at the cost of quality.</para>
            /// </summary>
            UseVertexLighting = 1,
            /// <summary>
            /// <para>Disables the depth test, so this object is drawn on top of all others. However, objects drawn after it in the draw order may cover it.</para>
            /// </summary>
            DisableDepthTest = 2,
            /// <summary>
            /// <para>Set <c>ALBEDO</c> to the per-vertex color specified in the mesh.</para>
            /// </summary>
            AlbedoFromVertexColor = 3,
            /// <summary>
            /// <para>Vertex color is in sRGB space and needs to be converted to linear. Only applies in the GLES3 renderer.</para>
            /// </summary>
            SrgbVertexColor = 4,
            /// <summary>
            /// <para>Uses point size to alter the size of primitive points. Also changes the albedo texture lookup to use <c>POINT_COORD</c> instead of <c>UV</c>.</para>
            /// </summary>
            UsePointSize = 5,
            /// <summary>
            /// <para>Object is scaled by depth so that it always appears the same size on screen.</para>
            /// </summary>
            FixedSize = 6,
            /// <summary>
            /// <para>Shader will keep the scale set for the mesh. Otherwise the scale is lost when billboarding. Only applies when <see cref="Godot.SpatialMaterial.ParamsBillboardMode"/> is <see cref="Godot.SpatialMaterial.BillboardMode.Enabled"/>.</para>
            /// </summary>
            BillboardKeepScale = 7,
            /// <summary>
            /// <para>Use triplanar texture lookup for all texture lookups that would normally use <c>UV</c>.</para>
            /// </summary>
            Uv1UseTriplanar = 8,
            /// <summary>
            /// <para>Use triplanar texture lookup for all texture lookups that would normally use <c>UV2</c>.</para>
            /// </summary>
            Uv2UseTriplanar = 9,
            /// <summary>
            /// <para>Use <c>UV2</c> coordinates to look up from the <see cref="Godot.SpatialMaterial.AoTexture"/>.</para>
            /// </summary>
            AoOnUv2 = 11,
            /// <summary>
            /// <para>Use <c>UV2</c> coordinates to look up from the <see cref="Godot.SpatialMaterial.EmissionTexture"/>.</para>
            /// </summary>
            EmissionOnUv2 = 12,
            /// <summary>
            /// <para>Use alpha scissor. Set by <see cref="Godot.SpatialMaterial.ParamsUseAlphaScissor"/>.</para>
            /// </summary>
            UseAlphaScissor = 13,
            /// <summary>
            /// <para>Use world coordinates in the triplanar texture lookup instead of local coordinates.</para>
            /// </summary>
            TriplanarUseWorld = 10,
            /// <summary>
            /// <para>Forces the shader to convert albedo from sRGB space to linear space.</para>
            /// </summary>
            AlbedoTextureForceSrgb = 14,
            /// <summary>
            /// <para>Disables receiving shadows from other objects.</para>
            /// </summary>
            DontReceiveShadows = 15,
            /// <summary>
            /// <para>Disables receiving ambient light.</para>
            /// </summary>
            DisableAmbientLight = 17,
            /// <summary>
            /// <para>Ensures that normals appear correct, even with non-uniform scaling.</para>
            /// </summary>
            EnsureCorrectNormals = 16,
            /// <summary>
            /// <para>Enables the shadow to opacity feature.</para>
            /// </summary>
            UseShadowToOpacity = 18,
            /// <summary>
            /// <para>Enables signed distance field rendering shader.</para>
            /// </summary>
            AlbedoTextureSdf = 19,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.SpatialMaterial.Flags"/> enum.</para>
            /// </summary>
            Max = 20
        }

        public enum CullMode
        {
            /// <summary>
            /// <para>Default cull mode. The back of the object is culled when not visible.</para>
            /// </summary>
            Back = 0,
            /// <summary>
            /// <para>The front of the object is culled when not visible.</para>
            /// </summary>
            Front = 1,
            /// <summary>
            /// <para>No culling is performed.</para>
            /// </summary>
            Disabled = 2
        }

        public enum DetailUV
        {
            /// <summary>
            /// <para>Use <c>UV</c> with the detail texture.</para>
            /// </summary>
            Uv1 = 0,
            /// <summary>
            /// <para>Use <c>UV2</c> with the detail texture.</para>
            /// </summary>
            Uv2 = 1
        }

        public enum DistanceFadeModeEnum
        {
            /// <summary>
            /// <para>Do not use distance fade.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>Smoothly fades the object out based on each pixel's distance from the camera using the alpha channel.</para>
            /// </summary>
            PixelAlpha = 1,
            /// <summary>
            /// <para>Smoothly fades the object out based on each pixel's distance from the camera using a dither approach. Dithering discards pixels based on a set pattern to smoothly fade without enabling transparency. On certain hardware this can be faster than <see cref="Godot.SpatialMaterial.DistanceFadeModeEnum.PixelAlpha"/>.</para>
            /// </summary>
            PixelDither = 2,
            /// <summary>
            /// <para>Smoothly fades the object out based on the object's distance from the camera using a dither approach. Dithering discards pixels based on a set pattern to smoothly fade without enabling transparency. On certain hardware this can be faster than <see cref="Godot.SpatialMaterial.DistanceFadeModeEnum.PixelAlpha"/>.</para>
            /// </summary>
            ObjectDither = 3
        }

        public enum BillboardMode
        {
            /// <summary>
            /// <para>Billboard mode is disabled.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>The object's Z axis will always face the camera.</para>
            /// </summary>
            Enabled = 1,
            /// <summary>
            /// <para>The object's X axis will always face the camera.</para>
            /// </summary>
            FixedY = 2,
            /// <summary>
            /// <para>Used for particle systems when assigned to <see cref="Godot.Particles"/> and <see cref="Godot.CPUParticles"/> nodes. Enables <c>particles_anim_*</c> properties.</para>
            /// <para>The <see cref="Godot.ParticlesMaterial.AnimSpeed"/> or <see cref="Godot.CPUParticles.AnimSpeed"/> should also be set to a positive value for the animation to play.</para>
            /// </summary>
            Particles = 3
        }

        public enum DepthDrawMode
        {
            /// <summary>
            /// <para>Default depth draw mode. Depth is drawn only for opaque objects.</para>
            /// </summary>
            OpaqueOnly = 0,
            /// <summary>
            /// <para>Depth draw is calculated for both opaque and transparent objects.</para>
            /// </summary>
            Always = 1,
            /// <summary>
            /// <para>No depth draw.</para>
            /// </summary>
            Disabled = 2,
            /// <summary>
            /// <para>For transparent objects, an opaque pass is made first with the opaque parts, then transparency is drawn.</para>
            /// </summary>
            AlphaOpaquePrepass = 3
        }

        public enum TextureChannel
        {
            /// <summary>
            /// <para>Used to read from the red channel of a texture.</para>
            /// </summary>
            Red = 0,
            /// <summary>
            /// <para>Used to read from the green channel of a texture.</para>
            /// </summary>
            Green = 1,
            /// <summary>
            /// <para>Used to read from the blue channel of a texture.</para>
            /// </summary>
            Blue = 2,
            /// <summary>
            /// <para>Used to read from the alpha channel of a texture.</para>
            /// </summary>
            Alpha = 3,
            /// <summary>
            /// <para>Currently unused.</para>
            /// </summary>
            Grayscale = 4
        }

        public enum BlendMode
        {
            /// <summary>
            /// <para>Default blend mode. The color of the object is blended over the background based on the object's alpha value.</para>
            /// </summary>
            Mix = 0,
            /// <summary>
            /// <para>The color of the object is added to the background.</para>
            /// </summary>
            Add = 1,
            /// <summary>
            /// <para>The color of the object is subtracted from the background.</para>
            /// </summary>
            Sub = 2,
            /// <summary>
            /// <para>The color of the object is multiplied by the background.</para>
            /// </summary>
            Mul = 3
        }

        public enum TextureParam
        {
            /// <summary>
            /// <para>Texture specifying per-pixel color.</para>
            /// </summary>
            Albedo = 0,
            /// <summary>
            /// <para>Texture specifying per-pixel metallic value.</para>
            /// </summary>
            Metallic = 1,
            /// <summary>
            /// <para>Texture specifying per-pixel roughness value.</para>
            /// </summary>
            Roughness = 2,
            /// <summary>
            /// <para>Texture specifying per-pixel emission color.</para>
            /// </summary>
            Emission = 3,
            /// <summary>
            /// <para>Texture specifying per-pixel normal vector.</para>
            /// </summary>
            Normal = 4,
            /// <summary>
            /// <para>Texture specifying per-pixel rim value.</para>
            /// </summary>
            Rim = 5,
            /// <summary>
            /// <para>Texture specifying per-pixel clearcoat value.</para>
            /// </summary>
            Clearcoat = 6,
            /// <summary>
            /// <para>Texture specifying per-pixel flowmap direction for use with <see cref="Godot.SpatialMaterial.Anisotropy"/>.</para>
            /// </summary>
            Flowmap = 7,
            /// <summary>
            /// <para>Texture specifying per-pixel ambient occlusion value.</para>
            /// </summary>
            AmbientOcclusion = 8,
            /// <summary>
            /// <para>Texture specifying per-pixel depth.</para>
            /// </summary>
            Depth = 9,
            /// <summary>
            /// <para>Texture specifying per-pixel subsurface scattering.</para>
            /// </summary>
            SubsurfaceScattering = 10,
            /// <summary>
            /// <para>Texture specifying per-pixel transmission color.</para>
            /// </summary>
            Transmission = 11,
            /// <summary>
            /// <para>Texture specifying per-pixel refraction strength.</para>
            /// </summary>
            Refraction = 12,
            /// <summary>
            /// <para>Texture specifying per-pixel detail mask blending value.</para>
            /// </summary>
            DetailMask = 13,
            /// <summary>
            /// <para>Texture specifying per-pixel detail color.</para>
            /// </summary>
            DetailAlbedo = 14,
            /// <summary>
            /// <para>Texture specifying per-pixel detail normal.</para>
            /// </summary>
            DetailNormal = 15,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.SpatialMaterial.TextureParam"/> enum.</para>
            /// </summary>
            Max = 16
        }

        /// <summary>
        /// <para>If <c>true</c>, transparency is enabled on the body. See also <see cref="Godot.SpatialMaterial.ParamsBlendMode"/>.</para>
        /// </summary>
        public bool FlagsTransparent
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFeature((SpatialMaterial.Feature)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFeature((SpatialMaterial.Feature)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, enables the "shadow to opacity" render mode where lighting modifies the alpha so shadowed areas are opaque and non-shadowed areas are transparent. Useful for overlaying shadows onto a camera feed in AR.</para>
        /// </summary>
        public bool FlagsUseShadowToOpacity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((SpatialMaterial.Flags)18);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((SpatialMaterial.Flags)18, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the object is unaffected by lighting.</para>
        /// </summary>
        public bool FlagsUnshaded
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((SpatialMaterial.Flags)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((SpatialMaterial.Flags)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, lighting is calculated per vertex rather than per pixel. This may increase performance on low-end devices, especially for meshes with a lower polygon count. The downside is that shading becomes much less accurate, with visible linear interpolation between vertices that are joined together. This can be compensated by ensuring meshes have a sufficient level of subdivision (but not too much, to avoid reducing performance). Some material features are also not supported when vertex shading is enabled.</para>
        /// <para>See also  which can globally enable vertex shading on all materials.</para>
        /// <para>Note: By default, vertex shading is enforced on mobile platforms by 's <c>mobile</c> override.</para>
        /// <para>Note: <see cref="Godot.SpatialMaterial.FlagsVertexLighting"/> has no effect if <see cref="Godot.SpatialMaterial.FlagsUnshaded"/> is <c>true</c>.</para>
        /// </summary>
        public bool FlagsVertexLighting
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((SpatialMaterial.Flags)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((SpatialMaterial.Flags)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, depth testing is disabled and the object will be drawn in render order.</para>
        /// </summary>
        public bool FlagsNoDepthTest
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((SpatialMaterial.Flags)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((SpatialMaterial.Flags)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, render point size can be changed.</para>
        /// <para>Note: This is only effective for objects whose geometry is point-based rather than triangle-based. See also <see cref="Godot.SpatialMaterial.ParamsPointSize"/>.</para>
        /// </summary>
        public bool FlagsUsePointSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((SpatialMaterial.Flags)5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((SpatialMaterial.Flags)5, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, triplanar mapping is calculated in world space rather than object local space. See also <see cref="Godot.SpatialMaterial.Uv1Triplanar"/>.</para>
        /// </summary>
        public bool FlagsWorldTriplanar
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((SpatialMaterial.Flags)10);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((SpatialMaterial.Flags)10, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the object is rendered at the same size regardless of distance.</para>
        /// </summary>
        public bool FlagsFixedSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((SpatialMaterial.Flags)6);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((SpatialMaterial.Flags)6, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Forces a conversion of the <see cref="Godot.SpatialMaterial.AlbedoTexture"/> from sRGB space to linear space.</para>
        /// </summary>
        public bool FlagsAlbedoTexForceSrgb
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((SpatialMaterial.Flags)14);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((SpatialMaterial.Flags)14, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the object receives no shadow that would otherwise be cast onto it.</para>
        /// </summary>
        public bool FlagsDoNotReceiveShadows
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((SpatialMaterial.Flags)15);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((SpatialMaterial.Flags)15, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the object receives no ambient light.</para>
        /// </summary>
        public bool FlagsDisableAmbientLight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((SpatialMaterial.Flags)17);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((SpatialMaterial.Flags)17, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the shader will compute extra operations to make sure the normal stays correct when using a non-uniform scale. Only enable if using non-uniform scaling.</para>
        /// </summary>
        public bool FlagsEnsureCorrectNormals
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((SpatialMaterial.Flags)16);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((SpatialMaterial.Flags)16, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Enables signed distance field rendering shader.</para>
        /// </summary>
        public bool FlagsAlbedoTexMsdf
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((SpatialMaterial.Flags)19);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((SpatialMaterial.Flags)19, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the vertex color is used as albedo color.</para>
        /// </summary>
        public bool VertexColorUseAsAlbedo
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((SpatialMaterial.Flags)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((SpatialMaterial.Flags)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the model's vertex colors are processed as sRGB mode.</para>
        /// </summary>
        public bool VertexColorIsSrgb
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((SpatialMaterial.Flags)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((SpatialMaterial.Flags)4, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The algorithm used for diffuse light scattering. See <see cref="Godot.SpatialMaterial.DiffuseMode"/>.</para>
        /// </summary>
        public SpatialMaterial.DiffuseMode ParamsDiffuseMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDiffuseMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDiffuseMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The method for rendering the specular blob. See <see cref="Godot.SpatialMaterial.SpecularMode"/>.</para>
        /// </summary>
        public SpatialMaterial.SpecularMode ParamsSpecularMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSpecularMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSpecularMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The material's blend mode.</para>
        /// <para>Note: Values other than <c>Mix</c> force the object into the transparent pipeline. See <see cref="Godot.SpatialMaterial.BlendMode"/>.</para>
        /// </summary>
        public SpatialMaterial.BlendMode ParamsBlendMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Which side of the object is not drawn when backfaces are rendered. See <see cref="Godot.SpatialMaterial.CullMode"/>.</para>
        /// </summary>
        public SpatialMaterial.CullMode ParamsCullMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCullMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCullMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Determines when depth rendering takes place. See <see cref="Godot.SpatialMaterial.DepthDrawMode"/>. See also <see cref="Godot.SpatialMaterial.FlagsTransparent"/>.</para>
        /// </summary>
        public SpatialMaterial.DepthDrawMode ParamsDepthDrawMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDepthDrawMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDepthDrawMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Currently unimplemented in Godot.</para>
        /// </summary>
        public float ParamsLineWidth
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLineWidth();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLineWidth(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The point size in pixels. See <see cref="Godot.SpatialMaterial.FlagsUsePointSize"/>.</para>
        /// </summary>
        public float ParamsPointSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPointSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPointSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Controls how the object faces the camera. See <see cref="Godot.SpatialMaterial.BillboardMode"/>.</para>
        /// <para>Note: Billboard mode is not suitable for VR because the left-right vector of the camera is not horizontal when the screen is attached to your head instead of on the table. See <a href="https://github.com/godotengine/godot/issues/41567">GitHub issue #41567</a> for details.</para>
        /// </summary>
        public SpatialMaterial.BillboardMode ParamsBillboardMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBillboardMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBillboardMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the shader will keep the scale set for the mesh. Otherwise the scale is lost when billboarding. Only applies when <see cref="Godot.SpatialMaterial.ParamsBillboardMode"/> is <see cref="Godot.SpatialMaterial.BillboardMode.Enabled"/>.</para>
        /// </summary>
        public bool ParamsBillboardKeepScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((SpatialMaterial.Flags)7);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((SpatialMaterial.Flags)7, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, enables the vertex grow setting. See <see cref="Godot.SpatialMaterial.ParamsGrowAmount"/>.</para>
        /// </summary>
        public bool ParamsGrow
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsGrowEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGrowEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Grows object vertices in the direction of their normals.</para>
        /// </summary>
        public float ParamsGrowAmount
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGrow();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGrow(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the shader will discard all pixels that have an alpha value less than <see cref="Godot.SpatialMaterial.ParamsAlphaScissorThreshold"/>.</para>
        /// </summary>
        public bool ParamsUseAlphaScissor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((SpatialMaterial.Flags)13);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((SpatialMaterial.Flags)13, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Threshold at which the alpha scissor will discard values.</para>
        /// </summary>
        public float ParamsAlphaScissorThreshold
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAlphaScissorThreshold();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAlphaScissorThreshold(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The number of horizontal frames in the particle sprite sheet. Only enabled when using <see cref="Godot.SpatialMaterial.BillboardMode.Particles"/>. See <see cref="Godot.SpatialMaterial.ParamsBillboardMode"/>.</para>
        /// </summary>
        public int ParticlesAnimHFrames
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParticlesAnimHFrames();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParticlesAnimHFrames(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The number of vertical frames in the particle sprite sheet. Only enabled when using <see cref="Godot.SpatialMaterial.BillboardMode.Particles"/>. See <see cref="Godot.SpatialMaterial.ParamsBillboardMode"/>.</para>
        /// </summary>
        public int ParticlesAnimVFrames
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParticlesAnimVFrames();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParticlesAnimVFrames(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, particle animations are looped. Only enabled when using <see cref="Godot.SpatialMaterial.BillboardMode.Particles"/>. See <see cref="Godot.SpatialMaterial.ParamsBillboardMode"/>.</para>
        /// </summary>
        public bool ParticlesAnimLoop
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParticlesAnimLoop();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParticlesAnimLoop(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The material's base color.</para>
        /// </summary>
        public Color AlbedoColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAlbedo();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAlbedo(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Texture to multiply by <see cref="Godot.SpatialMaterial.AlbedoColor"/>. Used for basic texturing of objects.</para>
        /// </summary>
        public Texture AlbedoTexture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexture((SpatialMaterial.TextureParam)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexture((SpatialMaterial.TextureParam)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A high value makes the material appear more like a metal. Non-metals use their albedo as the diffuse color and add diffuse to the specular reflection. With non-metals, the reflection appears on top of the albedo color. Metals use their albedo as a multiplier to the specular reflection and set the diffuse color to black resulting in a tinted reflection. Materials work better when fully metal or fully non-metal, values between <c>0</c> and <c>1</c> should only be used for blending between metal and non-metal sections. To alter the amount of reflection use <see cref="Godot.SpatialMaterial.Roughness"/>.</para>
        /// </summary>
        public float Metallic
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMetallic();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMetallic(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the size of the specular lobe. The specular lobe is the bright spot that is reflected from light sources.</para>
        /// <para>Note: Unlike <see cref="Godot.SpatialMaterial.Metallic"/>, this is not energy-conserving, so it should be left at <c>0.5</c> in most cases. See also <see cref="Godot.SpatialMaterial.Roughness"/>.</para>
        /// </summary>
        public float MetallicSpecular
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSpecular();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSpecular(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Texture used to specify metallic for an object. This is multiplied by <see cref="Godot.SpatialMaterial.Metallic"/>.</para>
        /// </summary>
        public Texture MetallicTexture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexture((SpatialMaterial.TextureParam)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexture((SpatialMaterial.TextureParam)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Specifies the channel of the <see cref="Godot.SpatialMaterial.MetallicTexture"/> in which the metallic information is stored. This is useful when you store the information for multiple effects in a single texture. For example if you stored metallic in the red channel, roughness in the blue, and ambient occlusion in the green you could reduce the number of textures you use.</para>
        /// </summary>
        public SpatialMaterial.TextureChannel MetallicTextureChannel
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMetallicTextureChannel();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMetallicTextureChannel(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Surface reflection. A value of <c>0</c> represents a perfect mirror while a value of <c>1</c> completely blurs the reflection. See also <see cref="Godot.SpatialMaterial.Metallic"/>.</para>
        /// </summary>
        public float Roughness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRoughness();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRoughness(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Texture used to control the roughness per-pixel. Multiplied by <see cref="Godot.SpatialMaterial.Roughness"/>.</para>
        /// </summary>
        public Texture RoughnessTexture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexture((SpatialMaterial.TextureParam)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexture((SpatialMaterial.TextureParam)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Specifies the channel of the <see cref="Godot.SpatialMaterial.AoTexture"/> in which the ambient occlusion information is stored. This is useful when you store the information for multiple effects in a single texture. For example if you stored metallic in the red channel, roughness in the blue, and ambient occlusion in the green you could reduce the number of textures you use.</para>
        /// </summary>
        public SpatialMaterial.TextureChannel RoughnessTextureChannel
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRoughnessTextureChannel();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRoughnessTextureChannel(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the body emits light. Emitting light makes the object appear brighter. The object can also cast light on other objects if a <see cref="Godot.GIProbe"/> or <see cref="Godot.BakedLightmap"/> is used and this object is used in baked lighting.</para>
        /// </summary>
        public bool EmissionEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFeature((SpatialMaterial.Feature)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFeature((SpatialMaterial.Feature)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The emitted light's color. See <see cref="Godot.SpatialMaterial.EmissionEnabled"/>.</para>
        /// </summary>
        public Color Emission
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEmission();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEmission(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The emitted light's strength. See <see cref="Godot.SpatialMaterial.EmissionEnabled"/>.</para>
        /// </summary>
        public float EmissionEnergy
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEmissionEnergy();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEmissionEnergy(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets how <see cref="Godot.SpatialMaterial.Emission"/> interacts with <see cref="Godot.SpatialMaterial.EmissionTexture"/>. Can either add or multiply. See <see cref="Godot.SpatialMaterial.EmissionOperatorEnum"/> for options.</para>
        /// </summary>
        public SpatialMaterial.EmissionOperatorEnum EmissionOperator
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEmissionOperator();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEmissionOperator(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Use <c>UV2</c> to read from the <see cref="Godot.SpatialMaterial.EmissionTexture"/>.</para>
        /// </summary>
        public bool EmissionOnUv2
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((SpatialMaterial.Flags)12);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((SpatialMaterial.Flags)12, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Texture that specifies how much surface emits light at a given point.</para>
        /// </summary>
        public Texture EmissionTexture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexture((SpatialMaterial.TextureParam)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexture((SpatialMaterial.TextureParam)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, normal mapping is enabled.</para>
        /// </summary>
        public bool NormalEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFeature((SpatialMaterial.Feature)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFeature((SpatialMaterial.Feature)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The strength of the normal map's effect.</para>
        /// </summary>
        public float NormalScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNormalScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetNormalScale(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Texture used to specify the normal at a given pixel. The <c>normal_texture</c> only uses the red and green channels; the blue and alpha channels are ignored. The normal read from <c>normal_texture</c> is oriented around the surface normal provided by the <see cref="Godot.Mesh"/>.</para>
        /// <para>Note: The mesh must have both normals and tangents defined in its vertex data. Otherwise, the normal map won't render correctly and will only appear to darken the whole surface. If creating geometry with <see cref="Godot.SurfaceTool"/>, you can use <see cref="Godot.SurfaceTool.GenerateNormals"/> and <see cref="Godot.SurfaceTool.GenerateTangents"/> to automatically generate normals and tangents respectively.</para>
        /// <para>Note: Godot expects the normal map to use X+, Y+, and Z+ coordinates. See <a href="http://wiki.polycount.com/wiki/Normal_Map_Technical_Details#Common_Swizzle_Coordinates">this page</a> for a comparison of normal map coordinates expected by popular engines.</para>
        /// </summary>
        public Texture NormalTexture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexture((SpatialMaterial.TextureParam)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexture((SpatialMaterial.TextureParam)4, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, rim effect is enabled. Rim lighting increases the brightness at glancing angles on an object.</para>
        /// <para>Note: Rim lighting is not visible if the material has <see cref="Godot.SpatialMaterial.FlagsUnshaded"/> set to <c>true</c>.</para>
        /// </summary>
        public bool RimEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFeature((SpatialMaterial.Feature)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFeature((SpatialMaterial.Feature)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the strength of the rim lighting effect.</para>
        /// </summary>
        public float Rim
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRim();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRim(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of to blend light and albedo color when rendering rim effect. If <c>0</c> the light color is used, while <c>1</c> means albedo color is used. An intermediate value generally works best.</para>
        /// </summary>
        public float RimTint
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRimTint();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRimTint(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Texture used to set the strength of the rim lighting effect per-pixel. Multiplied by <see cref="Godot.SpatialMaterial.Rim"/>.</para>
        /// </summary>
        public Texture RimTexture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexture((SpatialMaterial.TextureParam)5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexture((SpatialMaterial.TextureParam)5, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, clearcoat rendering is enabled. Adds a secondary transparent pass to the lighting calculation resulting in an added specular blob. This makes materials appear as if they have a clear layer on them that can be either glossy or rough.</para>
        /// <para>Note: Clearcoat rendering is not visible if the material has <see cref="Godot.SpatialMaterial.FlagsUnshaded"/> set to <c>true</c>.</para>
        /// </summary>
        public bool ClearcoatEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFeature((SpatialMaterial.Feature)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFeature((SpatialMaterial.Feature)4, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the strength of the clearcoat effect. Setting to <c>0</c> looks the same as disabling the clearcoat effect.</para>
        /// </summary>
        public float Clearcoat
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetClearcoat();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetClearcoat(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the roughness of the clearcoat pass. A higher value results in a smoother clearcoat while a lower value results in a rougher clearcoat.</para>
        /// </summary>
        public float ClearcoatGloss
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetClearcoatGloss();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetClearcoatGloss(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Texture that defines the strength of the clearcoat effect and the glossiness of the clearcoat. Strength is specified in the red channel while glossiness is specified in the green channel.</para>
        /// </summary>
        public Texture ClearcoatTexture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexture((SpatialMaterial.TextureParam)6);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexture((SpatialMaterial.TextureParam)6, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, anisotropy is enabled. Anisotropy changes the shape of the specular blob and aligns it to tangent space. This is useful for brushed aluminium and hair reflections.</para>
        /// <para>Note: Mesh tangents are needed for anisotropy to work. If the mesh does not contain tangents, the anisotropy effect will appear broken.</para>
        /// <para>Note: Material anisotropy should not to be confused with anisotropic texture filtering. Anisotropic texture filtering can be enabled by selecting a texture in the FileSystem dock, going to the Import dock, checking the Anisotropic checkbox then clicking Reimport. The anisotropic filtering level can be changed by adjusting .</para>
        /// </summary>
        public bool AnisotropyEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFeature((SpatialMaterial.Feature)5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFeature((SpatialMaterial.Feature)5, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The strength of the anisotropy effect. This is multiplied by <see cref="Godot.SpatialMaterial.AnisotropyFlowmap"/>'s alpha channel if a texture is defined there and the texture contains an alpha channel.</para>
        /// </summary>
        public float Anisotropy
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAnisotropy();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAnisotropy(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Texture that offsets the tangent map for anisotropy calculations and optionally controls the anisotropy effect (if an alpha channel is present). The flowmap texture is expected to be a derivative map, with the red channel representing distortion on the X axis and green channel representing distortion on the Y axis. Values below 0.5 will result in negative distortion, whereas values above 0.5 will result in positive distortion.</para>
        /// <para>If present, the texture's alpha channel will be used to multiply the strength of the <see cref="Godot.SpatialMaterial.Anisotropy"/> effect. Fully opaque pixels will keep the anisotropy effect's original strength while fully transparent pixels will disable the anisotropy effect entirely. The flowmap texture's blue channel is ignored.</para>
        /// </summary>
        public Texture AnisotropyFlowmap
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexture((SpatialMaterial.TextureParam)7);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexture((SpatialMaterial.TextureParam)7, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, ambient occlusion is enabled. Ambient occlusion darkens areas based on the <see cref="Godot.SpatialMaterial.AoTexture"/>.</para>
        /// </summary>
        public bool AoEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFeature((SpatialMaterial.Feature)6);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFeature((SpatialMaterial.Feature)6, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Amount that ambient occlusion affects lighting from lights. If <c>0</c>, ambient occlusion only affects ambient light. If <c>1</c>, ambient occlusion affects lights just as much as it affects ambient light. This can be used to impact the strength of the ambient occlusion effect, but typically looks unrealistic.</para>
        /// </summary>
        public float AoLightAffect
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAoLightAffect();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAoLightAffect(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Texture that defines the amount of ambient occlusion for a given point on the object.</para>
        /// </summary>
        public Texture AoTexture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexture((SpatialMaterial.TextureParam)8);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexture((SpatialMaterial.TextureParam)8, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, use <c>UV2</c> coordinates to look up from the <see cref="Godot.SpatialMaterial.AoTexture"/>.</para>
        /// </summary>
        public bool AoOnUv2
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((SpatialMaterial.Flags)11);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((SpatialMaterial.Flags)11, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Specifies the channel of the <see cref="Godot.SpatialMaterial.AoTexture"/> in which the ambient occlusion information is stored. This is useful when you store the information for multiple effects in a single texture. For example if you stored metallic in the red channel, roughness in the blue, and ambient occlusion in the green you could reduce the number of textures you use.</para>
        /// </summary>
        public SpatialMaterial.TextureChannel AoTextureChannel
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAoTextureChannel();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAoTextureChannel(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, depth mapping is enabled (also called "parallax mapping" or "height mapping"). See also <see cref="Godot.SpatialMaterial.NormalEnabled"/>.</para>
        /// <para>Note: Depth mapping is not supported if triplanar mapping is used on the same material. The value of <see cref="Godot.SpatialMaterial.DepthEnabled"/> will be ignored if <see cref="Godot.SpatialMaterial.Uv1Triplanar"/> is enabled.</para>
        /// </summary>
        public bool DepthEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFeature((SpatialMaterial.Feature)7);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFeature((SpatialMaterial.Feature)7, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Scales the depth offset effect. A higher number will create a larger depth.</para>
        /// </summary>
        public float DepthScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDepthScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDepthScale(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the shader will read depth texture at multiple points along the view ray to determine occlusion and parrallax. This can be very performance demanding, but results in more realistic looking depth mapping.</para>
        /// </summary>
        public bool DepthDeepParallax
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDepthDeepParallaxEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDepthDeepParallax(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Number of layers to use when using <see cref="Godot.SpatialMaterial.DepthDeepParallax"/> and the view direction is parallel to the surface of the object. A higher number will be more performance demanding while a lower number may not look as crisp.</para>
        /// </summary>
        public int DepthMinLayers
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDepthDeepParallaxMinLayers();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDepthDeepParallaxMinLayers(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Number of layers to use when using <see cref="Godot.SpatialMaterial.DepthDeepParallax"/> and the view direction is perpendicular to the surface of the object. A higher number will be more performance demanding while a lower number may not look as crisp.</para>
        /// </summary>
        public int DepthMaxLayers
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDepthDeepParallaxMaxLayers();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDepthDeepParallaxMaxLayers(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, direction of the tangent is flipped before using in the depth effect. This may be necessary if you have encoded your tangents in a way that is conflicting with the depth effect.</para>
        /// </summary>
        public bool DepthFlipTangent
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDepthDeepParallaxFlipTangent();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDepthDeepParallaxFlipTangent(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, direction of the binormal is flipped before using in the depth effect. This may be necessary if you have encoded your binormals in a way that is conflicting with the depth effect.</para>
        /// </summary>
        public bool DepthFlipBinormal
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDepthDeepParallaxFlipBinormal();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDepthDeepParallaxFlipBinormal(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Texture used to determine depth at a given pixel. Depth is always stored in the red channel.</para>
        /// </summary>
        public Texture DepthTexture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexture((SpatialMaterial.TextureParam)9);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexture((SpatialMaterial.TextureParam)9, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, subsurface scattering is enabled. Emulates light that penetrates an object's surface, is scattered, and then emerges.</para>
        /// </summary>
        public bool SubsurfScatterEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFeature((SpatialMaterial.Feature)8);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFeature((SpatialMaterial.Feature)8, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The strength of the subsurface scattering effect.</para>
        /// </summary>
        public float SubsurfScatterStrength
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSubsurfaceScatteringStrength();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSubsurfaceScatteringStrength(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Texture used to control the subsurface scattering strength. Stored in the red texture channel. Multiplied by <see cref="Godot.SpatialMaterial.SubsurfScatterStrength"/>.</para>
        /// </summary>
        public Texture SubsurfScatterTexture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexture((SpatialMaterial.TextureParam)10);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexture((SpatialMaterial.TextureParam)10, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the transmission effect is enabled.</para>
        /// </summary>
        public bool TransmissionEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFeature((SpatialMaterial.Feature)9);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFeature((SpatialMaterial.Feature)9, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The color used by the transmission effect. Represents the light passing through an object.</para>
        /// </summary>
        public Color Transmission
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTransmission();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTransmission(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Texture used to control the transmission effect per-pixel. Added to <see cref="Godot.SpatialMaterial.Transmission"/>.</para>
        /// </summary>
        public Texture TransmissionTexture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexture((SpatialMaterial.TextureParam)11);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexture((SpatialMaterial.TextureParam)11, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the refraction effect is enabled. Refraction distorts transparency based on light from behind the object. When using the GLES3 backend, the material's roughness value will affect the blurriness of the refraction. Higher roughness values will make the refraction look blurrier.</para>
        /// </summary>
        public bool RefractionEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFeature((SpatialMaterial.Feature)10);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFeature((SpatialMaterial.Feature)10, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The strength of the refraction effect. Higher values result in a more distorted appearance for the refraction.</para>
        /// </summary>
        public float RefractionScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRefraction();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRefraction(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Texture that controls the strength of the refraction per-pixel. Multiplied by <see cref="Godot.SpatialMaterial.RefractionScale"/>.</para>
        /// </summary>
        public Texture RefractionTexture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexture((SpatialMaterial.TextureParam)12);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexture((SpatialMaterial.TextureParam)12, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Specifies the channel of the <see cref="Godot.SpatialMaterial.RefractionTexture"/> in which the refraction information is stored. This is useful when you store the information for multiple effects in a single texture. For example if you stored metallic in the red channel, roughness in the blue, and ambient occlusion in the green you could reduce the number of textures you use.</para>
        /// </summary>
        public SpatialMaterial.TextureChannel RefractionTextureChannel
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRefractionTextureChannel();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRefractionTextureChannel(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, enables the detail overlay. Detail is a second texture that gets mixed over the surface of the object based on <see cref="Godot.SpatialMaterial.DetailMask"/>. This can be used to add variation to objects, or to blend between two different albedo/normal textures.</para>
        /// </summary>
        public bool DetailEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFeature((SpatialMaterial.Feature)11);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFeature((SpatialMaterial.Feature)11, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Texture used to specify how the detail textures get blended with the base textures.</para>
        /// </summary>
        public Texture DetailMask
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexture((SpatialMaterial.TextureParam)13);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexture((SpatialMaterial.TextureParam)13, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Specifies how the <see cref="Godot.SpatialMaterial.DetailAlbedo"/> should blend with the current <c>ALBEDO</c>. See <see cref="Godot.SpatialMaterial.BlendMode"/> for options.</para>
        /// </summary>
        public SpatialMaterial.BlendMode DetailBlendMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDetailBlendMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDetailBlendMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Specifies whether to use <c>UV</c> or <c>UV2</c> for the detail layer. See <see cref="Godot.SpatialMaterial.DetailUV"/> for options.</para>
        /// </summary>
        public SpatialMaterial.DetailUV DetailUvLayer
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDetailUv();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDetailUv(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Texture that specifies the color of the detail overlay.</para>
        /// </summary>
        public Texture DetailAlbedo
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexture((SpatialMaterial.TextureParam)14);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexture((SpatialMaterial.TextureParam)14, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Texture that specifies the per-pixel normal of the detail overlay.</para>
        /// <para>Note: Godot expects the normal map to use X+, Y+, and Z+ coordinates. See <a href="http://wiki.polycount.com/wiki/Normal_Map_Technical_Details#Common_Swizzle_Coordinates">this page</a> for a comparison of normal map coordinates expected by popular engines.</para>
        /// </summary>
        public Texture DetailNormal
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexture((SpatialMaterial.TextureParam)15);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexture((SpatialMaterial.TextureParam)15, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>How much to scale the <c>UV</c> coordinates. This is multiplied by <c>UV</c> in the vertex function.</para>
        /// </summary>
        public Vector3 Uv1Scale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUv1Scale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUv1Scale(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>How much to offset the <c>UV</c> coordinates. This amount will be added to <c>UV</c> in the vertex function. This can be used to offset a texture.</para>
        /// </summary>
        public Vector3 Uv1Offset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUv1Offset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUv1Offset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, instead of using <c>UV</c> textures will use a triplanar texture lookup to determine how to apply textures. Triplanar uses the orientation of the object's surface to blend between texture coordinates. It reads from the source texture 3 times, once for each axis and then blends between the results based on how closely the pixel aligns with each axis. This is often used for natural features to get a realistic blend of materials. Because triplanar texturing requires many more texture reads per-pixel it is much slower than normal UV texturing. Additionally, because it is blending the texture between the three axes, it is unsuitable when you are trying to achieve crisp texturing.</para>
        /// </summary>
        public bool Uv1Triplanar
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((SpatialMaterial.Flags)8);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((SpatialMaterial.Flags)8, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A lower number blends the texture more softly while a higher number blends the texture more sharply.</para>
        /// </summary>
        public float Uv1TriplanarSharpness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUv1TriplanarBlendSharpness();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUv1TriplanarBlendSharpness(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>How much to scale the <c>UV2</c> coordinates. This is multiplied by <c>UV2</c> in the vertex function.</para>
        /// </summary>
        public Vector3 Uv2Scale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUv2Scale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUv2Scale(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>How much to offset the <c>UV2</c> coordinates. This amount will be added to <c>UV2</c> in the vertex function. This can be used to offset a texture.</para>
        /// </summary>
        public Vector3 Uv2Offset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUv2Offset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUv2Offset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, instead of using <c>UV2</c> textures will use a triplanar texture lookup to determine how to apply textures. Triplanar uses the orientation of the object's surface to blend between texture coordinates. It reads from the source texture 3 times, once for each axis and then blends between the results based on how closely the pixel aligns with each axis. This is often used for natural features to get a realistic blend of materials. Because triplanar texturing requires many more texture reads per-pixel it is much slower than normal UV texturing. Additionally, because it is blending the texture between the three axes, it is unsuitable when you are trying to achieve crisp texturing.</para>
        /// </summary>
        public bool Uv2Triplanar
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((SpatialMaterial.Flags)9);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((SpatialMaterial.Flags)9, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A lower number blends the texture more softly while a higher number blends the texture more sharply.</para>
        /// </summary>
        public float Uv2TriplanarSharpness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUv2TriplanarBlendSharpness();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUv2TriplanarBlendSharpness(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the proximity fade effect is enabled. The proximity fade effect fades out each pixel based on its distance to another object.</para>
        /// </summary>
        public bool ProximityFadeEnable
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsProximityFadeEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetProximityFade(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Distance over which the fade effect takes place. The larger the distance the longer it takes for an object to fade.</para>
        /// </summary>
        public float ProximityFadeDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetProximityFadeDistance();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetProximityFadeDistance(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Specifies which type of fade to use. Can be any of the <see cref="Godot.SpatialMaterial.DistanceFadeModeEnum"/>s.</para>
        /// </summary>
        public SpatialMaterial.DistanceFadeModeEnum DistanceFadeMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDistanceFade();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDistanceFade(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Distance at which the object starts to become visible. If the object is less than this distance away, it will be invisible.</para>
        /// <para>Note: If <c>distance_fade_min_distance</c> is greater than <c>distance_fade_max_distance</c>, the behavior will be reversed. The object will start to fade away at <c>distance_fade_max_distance</c> and will fully disappear once it reaches <c>distance_fade_min_distance</c>.</para>
        /// </summary>
        public float DistanceFadeMinDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDistanceFadeMinDistance();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDistanceFadeMinDistance(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Distance at which the object appears fully opaque.</para>
        /// <para>Note: If <c>distance_fade_max_distance</c> is less than <c>distance_fade_min_distance</c>, the behavior will be reversed. The object will start to fade away at <c>distance_fade_max_distance</c> and will fully disappear once it reaches <c>distance_fade_min_distance</c>.</para>
        /// </summary>
        public float DistanceFadeMaxDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDistanceFadeMaxDistance();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDistanceFadeMaxDistance(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If  is <c>Synchronous</c> (with or without cache), this determines how this material must behave in regards to asynchronous shader compilation.</para>
        /// <para><see cref="Godot.SpatialMaterial.AsyncModeEnum.Visible"/> is the default and the best for most cases.</para>
        /// </summary>
        public SpatialMaterial.AsyncModeEnum AsyncMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAsyncMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAsyncMode(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "SpatialMaterial";

        public SpatialMaterial() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_SpatialMaterial_Ctor(this);
        }

        internal SpatialMaterial(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_albedo");

        [GodotMethod("set_albedo")]
        [Obsolete("SetAlbedo is deprecated. Use the AlbedoColor property instead.")]
        public void SetAlbedo(Color albedo)
        {
            NativeCalls.godot_icall_1_199(method_bind_0, Object.GetPtr(this), ref albedo);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_albedo");

        [GodotMethod("get_albedo")]
        [Obsolete("GetAlbedo is deprecated. Use the AlbedoColor property instead.")]
        public Color GetAlbedo()
        {
            NativeCalls.godot_icall_0_200(method_bind_1, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_specular");

        [GodotMethod("set_specular")]
        [Obsolete("SetSpecular is deprecated. Use the MetallicSpecular property instead.")]
        public void SetSpecular(float specular)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), specular);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_specular");

        [GodotMethod("get_specular")]
        [Obsolete("GetSpecular is deprecated. Use the MetallicSpecular property instead.")]
        public float GetSpecular()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_metallic");

        [GodotMethod("set_metallic")]
        [Obsolete("SetMetallic is deprecated. Use the Metallic property instead.")]
        public void SetMetallic(float metallic)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), metallic);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_metallic");

        [GodotMethod("get_metallic")]
        [Obsolete("GetMetallic is deprecated. Use the Metallic property instead.")]
        public float GetMetallic()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_roughness");

        [GodotMethod("set_roughness")]
        [Obsolete("SetRoughness is deprecated. Use the Roughness property instead.")]
        public void SetRoughness(float roughness)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), roughness);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_roughness");

        [GodotMethod("get_roughness")]
        [Obsolete("GetRoughness is deprecated. Use the Roughness property instead.")]
        public float GetRoughness()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission");

        [GodotMethod("set_emission")]
        [Obsolete("SetEmission is deprecated. Use the Emission property instead.")]
        public void SetEmission(Color emission)
        {
            NativeCalls.godot_icall_1_199(method_bind_8, Object.GetPtr(this), ref emission);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission");

        [GodotMethod("get_emission")]
        [Obsolete("GetEmission is deprecated. Use the Emission property instead.")]
        public Color GetEmission()
        {
            NativeCalls.godot_icall_0_200(method_bind_9, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_energy");

        [GodotMethod("set_emission_energy")]
        [Obsolete("SetEmissionEnergy is deprecated. Use the EmissionEnergy property instead.")]
        public void SetEmissionEnergy(float emissionEnergy)
        {
            NativeCalls.godot_icall_1_15(method_bind_10, Object.GetPtr(this), emissionEnergy);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_energy");

        [GodotMethod("get_emission_energy")]
        [Obsolete("GetEmissionEnergy is deprecated. Use the EmissionEnergy property instead.")]
        public float GetEmissionEnergy()
        {
            return NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_normal_scale");

        [GodotMethod("set_normal_scale")]
        [Obsolete("SetNormalScale is deprecated. Use the NormalScale property instead.")]
        public void SetNormalScale(float normalScale)
        {
            NativeCalls.godot_icall_1_15(method_bind_12, Object.GetPtr(this), normalScale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_normal_scale");

        [GodotMethod("get_normal_scale")]
        [Obsolete("GetNormalScale is deprecated. Use the NormalScale property instead.")]
        public float GetNormalScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rim");

        [GodotMethod("set_rim")]
        [Obsolete("SetRim is deprecated. Use the Rim property instead.")]
        public void SetRim(float rim)
        {
            NativeCalls.godot_icall_1_15(method_bind_14, Object.GetPtr(this), rim);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rim");

        [GodotMethod("get_rim")]
        [Obsolete("GetRim is deprecated. Use the Rim property instead.")]
        public float GetRim()
        {
            return NativeCalls.godot_icall_0_14(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rim_tint");

        [GodotMethod("set_rim_tint")]
        [Obsolete("SetRimTint is deprecated. Use the RimTint property instead.")]
        public void SetRimTint(float rimTint)
        {
            NativeCalls.godot_icall_1_15(method_bind_16, Object.GetPtr(this), rimTint);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rim_tint");

        [GodotMethod("get_rim_tint")]
        [Obsolete("GetRimTint is deprecated. Use the RimTint property instead.")]
        public float GetRimTint()
        {
            return NativeCalls.godot_icall_0_14(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_clearcoat");

        [GodotMethod("set_clearcoat")]
        [Obsolete("SetClearcoat is deprecated. Use the Clearcoat property instead.")]
        public void SetClearcoat(float clearcoat)
        {
            NativeCalls.godot_icall_1_15(method_bind_18, Object.GetPtr(this), clearcoat);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_clearcoat");

        [GodotMethod("get_clearcoat")]
        [Obsolete("GetClearcoat is deprecated. Use the Clearcoat property instead.")]
        public float GetClearcoat()
        {
            return NativeCalls.godot_icall_0_14(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_clearcoat_gloss");

        [GodotMethod("set_clearcoat_gloss")]
        [Obsolete("SetClearcoatGloss is deprecated. Use the ClearcoatGloss property instead.")]
        public void SetClearcoatGloss(float clearcoatGloss)
        {
            NativeCalls.godot_icall_1_15(method_bind_20, Object.GetPtr(this), clearcoatGloss);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_clearcoat_gloss");

        [GodotMethod("get_clearcoat_gloss")]
        [Obsolete("GetClearcoatGloss is deprecated. Use the ClearcoatGloss property instead.")]
        public float GetClearcoatGloss()
        {
            return NativeCalls.godot_icall_0_14(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_anisotropy");

        [GodotMethod("set_anisotropy")]
        [Obsolete("SetAnisotropy is deprecated. Use the Anisotropy property instead.")]
        public void SetAnisotropy(float anisotropy)
        {
            NativeCalls.godot_icall_1_15(method_bind_22, Object.GetPtr(this), anisotropy);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_anisotropy");

        [GodotMethod("get_anisotropy")]
        [Obsolete("GetAnisotropy is deprecated. Use the Anisotropy property instead.")]
        public float GetAnisotropy()
        {
            return NativeCalls.godot_icall_0_14(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_depth_scale");

        [GodotMethod("set_depth_scale")]
        [Obsolete("SetDepthScale is deprecated. Use the DepthScale property instead.")]
        public void SetDepthScale(float depthScale)
        {
            NativeCalls.godot_icall_1_15(method_bind_24, Object.GetPtr(this), depthScale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_depth_scale");

        [GodotMethod("get_depth_scale")]
        [Obsolete("GetDepthScale is deprecated. Use the DepthScale property instead.")]
        public float GetDepthScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_subsurface_scattering_strength");

        [GodotMethod("set_subsurface_scattering_strength")]
        [Obsolete("SetSubsurfaceScatteringStrength is deprecated. Use the SubsurfScatterStrength property instead.")]
        public void SetSubsurfaceScatteringStrength(float strength)
        {
            NativeCalls.godot_icall_1_15(method_bind_26, Object.GetPtr(this), strength);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_subsurface_scattering_strength");

        [GodotMethod("get_subsurface_scattering_strength")]
        [Obsolete("GetSubsurfaceScatteringStrength is deprecated. Use the SubsurfScatterStrength property instead.")]
        public float GetSubsurfaceScatteringStrength()
        {
            return NativeCalls.godot_icall_0_14(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_transmission");

        [GodotMethod("set_transmission")]
        [Obsolete("SetTransmission is deprecated. Use the Transmission property instead.")]
        public void SetTransmission(Color transmission)
        {
            NativeCalls.godot_icall_1_199(method_bind_28, Object.GetPtr(this), ref transmission);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_transmission");

        [GodotMethod("get_transmission")]
        [Obsolete("GetTransmission is deprecated. Use the Transmission property instead.")]
        public Color GetTransmission()
        {
            NativeCalls.godot_icall_0_200(method_bind_29, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_refraction");

        [GodotMethod("set_refraction")]
        [Obsolete("SetRefraction is deprecated. Use the RefractionScale property instead.")]
        public void SetRefraction(float refraction)
        {
            NativeCalls.godot_icall_1_15(method_bind_30, Object.GetPtr(this), refraction);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_refraction");

        [GodotMethod("get_refraction")]
        [Obsolete("GetRefraction is deprecated. Use the RefractionScale property instead.")]
        public float GetRefraction()
        {
            return NativeCalls.godot_icall_0_14(method_bind_31, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_line_width");

        [GodotMethod("set_line_width")]
        [Obsolete("SetLineWidth is deprecated. Use the ParamsLineWidth property instead.")]
        public void SetLineWidth(float lineWidth)
        {
            NativeCalls.godot_icall_1_15(method_bind_32, Object.GetPtr(this), lineWidth);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_line_width");

        [GodotMethod("get_line_width")]
        [Obsolete("GetLineWidth is deprecated. Use the ParamsLineWidth property instead.")]
        public float GetLineWidth()
        {
            return NativeCalls.godot_icall_0_14(method_bind_33, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_point_size");

        [GodotMethod("set_point_size")]
        [Obsolete("SetPointSize is deprecated. Use the ParamsPointSize property instead.")]
        public void SetPointSize(float pointSize)
        {
            NativeCalls.godot_icall_1_15(method_bind_34, Object.GetPtr(this), pointSize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_point_size");

        [GodotMethod("get_point_size")]
        [Obsolete("GetPointSize is deprecated. Use the ParamsPointSize property instead.")]
        public float GetPointSize()
        {
            return NativeCalls.godot_icall_0_14(method_bind_35, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_detail_uv");

        [GodotMethod("set_detail_uv")]
        [Obsolete("SetDetailUv is deprecated. Use the DetailUvLayer property instead.")]
        public void SetDetailUv(SpatialMaterial.DetailUV detailUv)
        {
            NativeCalls.godot_icall_1_4(method_bind_36, Object.GetPtr(this), (int)detailUv);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_detail_uv");

        [GodotMethod("get_detail_uv")]
        [Obsolete("GetDetailUv is deprecated. Use the DetailUvLayer property instead.")]
        public SpatialMaterial.DetailUV GetDetailUv()
        {
            return (SpatialMaterial.DetailUV)NativeCalls.godot_icall_0_869(method_bind_37, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_blend_mode");

        [GodotMethod("set_blend_mode")]
        [Obsolete("SetBlendMode is deprecated. Use the ParamsBlendMode property instead.")]
        public void SetBlendMode(SpatialMaterial.BlendMode blendMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_38, Object.GetPtr(this), (int)blendMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_blend_mode");

        [GodotMethod("get_blend_mode")]
        [Obsolete("GetBlendMode is deprecated. Use the ParamsBlendMode property instead.")]
        public SpatialMaterial.BlendMode GetBlendMode()
        {
            return (SpatialMaterial.BlendMode)NativeCalls.godot_icall_0_870(method_bind_39, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_depth_draw_mode");

        [GodotMethod("set_depth_draw_mode")]
        [Obsolete("SetDepthDrawMode is deprecated. Use the ParamsDepthDrawMode property instead.")]
        public void SetDepthDrawMode(SpatialMaterial.DepthDrawMode depthDrawMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_40, Object.GetPtr(this), (int)depthDrawMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_depth_draw_mode");

        [GodotMethod("get_depth_draw_mode")]
        [Obsolete("GetDepthDrawMode is deprecated. Use the ParamsDepthDrawMode property instead.")]
        public SpatialMaterial.DepthDrawMode GetDepthDrawMode()
        {
            return (SpatialMaterial.DepthDrawMode)NativeCalls.godot_icall_0_871(method_bind_41, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cull_mode");

        [GodotMethod("set_cull_mode")]
        [Obsolete("SetCullMode is deprecated. Use the ParamsCullMode property instead.")]
        public void SetCullMode(SpatialMaterial.CullMode cullMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_42, Object.GetPtr(this), (int)cullMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cull_mode");

        [GodotMethod("get_cull_mode")]
        [Obsolete("GetCullMode is deprecated. Use the ParamsCullMode property instead.")]
        public SpatialMaterial.CullMode GetCullMode()
        {
            return (SpatialMaterial.CullMode)NativeCalls.godot_icall_0_872(method_bind_43, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_diffuse_mode");

        [GodotMethod("set_diffuse_mode")]
        [Obsolete("SetDiffuseMode is deprecated. Use the ParamsDiffuseMode property instead.")]
        public void SetDiffuseMode(SpatialMaterial.DiffuseMode diffuseMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_44, Object.GetPtr(this), (int)diffuseMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_diffuse_mode");

        [GodotMethod("get_diffuse_mode")]
        [Obsolete("GetDiffuseMode is deprecated. Use the ParamsDiffuseMode property instead.")]
        public SpatialMaterial.DiffuseMode GetDiffuseMode()
        {
            return (SpatialMaterial.DiffuseMode)NativeCalls.godot_icall_0_873(method_bind_45, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_specular_mode");

        [GodotMethod("set_specular_mode")]
        [Obsolete("SetSpecularMode is deprecated. Use the ParamsSpecularMode property instead.")]
        public void SetSpecularMode(SpatialMaterial.SpecularMode specularMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_46, Object.GetPtr(this), (int)specularMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_specular_mode");

        [GodotMethod("get_specular_mode")]
        [Obsolete("GetSpecularMode is deprecated. Use the ParamsSpecularMode property instead.")]
        public SpatialMaterial.SpecularMode GetSpecularMode()
        {
            return (SpatialMaterial.SpecularMode)NativeCalls.godot_icall_0_874(method_bind_47, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flag");

        /// <summary>
        /// <para>If <c>true</c>, enables the specified flag. Flags are optional behavior that can be turned on and off. Only one flag can be enabled at a time with this function, the flag enumerators cannot be bit-masked together to enable or disable multiple flags at once. Flags can also be enabled by setting the corresponding member to <c>true</c>. See <see cref="Godot.SpatialMaterial.Flags"/> enumerator for options.</para>
        /// </summary>
        [GodotMethod("set_flag")]
        [Obsolete("SetFlag is deprecated. Use the Uv2Triplanar property instead.")]
        public void SetFlag(SpatialMaterial.Flags flag, bool enable)
        {
            NativeCalls.godot_icall_2_23(method_bind_48, Object.GetPtr(this), (int)flag, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_flag");

        /// <summary>
        /// <para>Returns <c>true</c>, if the specified flag is enabled. See <see cref="Godot.SpatialMaterial.Flags"/> enumerator for options.</para>
        /// </summary>
        [GodotMethod("get_flag")]
        [Obsolete("GetFlag is deprecated. Use the Uv2Triplanar property instead.")]
        public bool GetFlag(SpatialMaterial.Flags flag)
        {
            return NativeCalls.godot_icall_1_35(method_bind_49, Object.GetPtr(this), (int)flag);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_feature");

        /// <summary>
        /// <para>If <c>true</c>, enables the specified <see cref="Godot.SpatialMaterial.Feature"/>. Many features that are available in <see cref="Godot.SpatialMaterial"/>s need to be enabled before use. This way the cost for using the feature is only incurred when specified. Features can also be enabled by setting the corresponding member to <c>true</c>.</para>
        /// </summary>
        [GodotMethod("set_feature")]
        [Obsolete("SetFeature is deprecated. Use the DetailEnabled property instead.")]
        public void SetFeature(SpatialMaterial.Feature feature, bool enable)
        {
            NativeCalls.godot_icall_2_23(method_bind_50, Object.GetPtr(this), (int)feature, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_feature");

        /// <summary>
        /// <para>Returns <c>true</c>, if the specified <see cref="Godot.SpatialMaterial.Feature"/> is enabled.</para>
        /// </summary>
        [GodotMethod("get_feature")]
        [Obsolete("GetFeature is deprecated. Use the DetailEnabled property instead.")]
        public bool GetFeature(SpatialMaterial.Feature feature)
        {
            return NativeCalls.godot_icall_1_35(method_bind_51, Object.GetPtr(this), (int)feature);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture");

        /// <summary>
        /// <para>Sets the <see cref="Godot.Texture"/> to be used by the specified <see cref="Godot.SpatialMaterial.TextureParam"/>. This function is called when setting members ending in <c>*_texture</c>.</para>
        /// </summary>
        [GodotMethod("set_texture")]
        [Obsolete("SetTexture is deprecated. Use the DetailNormal property instead.")]
        public void SetTexture(SpatialMaterial.TextureParam param, Texture texture)
        {
            NativeCalls.godot_icall_2_58(method_bind_52, Object.GetPtr(this), (int)param, Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_53 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Texture"/> associated with the specified <see cref="Godot.SpatialMaterial.TextureParam"/>.</para>
        /// </summary>
        [GodotMethod("get_texture")]
        [Obsolete("GetTexture is deprecated. Use the DetailNormal property instead.")]
        public Texture GetTexture(SpatialMaterial.TextureParam param)
        {
            return NativeCalls.godot_icall_1_59(method_bind_53, Object.GetPtr(this), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_54 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_detail_blend_mode");

        [GodotMethod("set_detail_blend_mode")]
        [Obsolete("SetDetailBlendMode is deprecated. Use the DetailBlendMode property instead.")]
        public void SetDetailBlendMode(SpatialMaterial.BlendMode detailBlendMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_54, Object.GetPtr(this), (int)detailBlendMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_55 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_detail_blend_mode");

        [GodotMethod("get_detail_blend_mode")]
        [Obsolete("GetDetailBlendMode is deprecated. Use the DetailBlendMode property instead.")]
        public SpatialMaterial.BlendMode GetDetailBlendMode()
        {
            return (SpatialMaterial.BlendMode)NativeCalls.godot_icall_0_870(method_bind_55, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_56 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_uv1_scale");

        [GodotMethod("set_uv1_scale")]
        [Obsolete("SetUv1Scale is deprecated. Use the Uv1Scale property instead.")]
        public void SetUv1Scale(Vector3 scale)
        {
            NativeCalls.godot_icall_1_148(method_bind_56, Object.GetPtr(this), ref scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_57 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_uv1_scale");

        [GodotMethod("get_uv1_scale")]
        [Obsolete("GetUv1Scale is deprecated. Use the Uv1Scale property instead.")]
        public Vector3 GetUv1Scale()
        {
            NativeCalls.godot_icall_0_8(method_bind_57, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_58 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_uv1_offset");

        [GodotMethod("set_uv1_offset")]
        [Obsolete("SetUv1Offset is deprecated. Use the Uv1Offset property instead.")]
        public void SetUv1Offset(Vector3 offset)
        {
            NativeCalls.godot_icall_1_148(method_bind_58, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_59 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_uv1_offset");

        [GodotMethod("get_uv1_offset")]
        [Obsolete("GetUv1Offset is deprecated. Use the Uv1Offset property instead.")]
        public Vector3 GetUv1Offset()
        {
            NativeCalls.godot_icall_0_8(method_bind_59, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_60 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_uv1_triplanar_blend_sharpness");

        [GodotMethod("set_uv1_triplanar_blend_sharpness")]
        [Obsolete("SetUv1TriplanarBlendSharpness is deprecated. Use the Uv1TriplanarSharpness property instead.")]
        public void SetUv1TriplanarBlendSharpness(float sharpness)
        {
            NativeCalls.godot_icall_1_15(method_bind_60, Object.GetPtr(this), sharpness);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_61 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_uv1_triplanar_blend_sharpness");

        [GodotMethod("get_uv1_triplanar_blend_sharpness")]
        [Obsolete("GetUv1TriplanarBlendSharpness is deprecated. Use the Uv1TriplanarSharpness property instead.")]
        public float GetUv1TriplanarBlendSharpness()
        {
            return NativeCalls.godot_icall_0_14(method_bind_61, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_62 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_uv2_scale");

        [GodotMethod("set_uv2_scale")]
        [Obsolete("SetUv2Scale is deprecated. Use the Uv2Scale property instead.")]
        public void SetUv2Scale(Vector3 scale)
        {
            NativeCalls.godot_icall_1_148(method_bind_62, Object.GetPtr(this), ref scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_63 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_uv2_scale");

        [GodotMethod("get_uv2_scale")]
        [Obsolete("GetUv2Scale is deprecated. Use the Uv2Scale property instead.")]
        public Vector3 GetUv2Scale()
        {
            NativeCalls.godot_icall_0_8(method_bind_63, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_64 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_uv2_offset");

        [GodotMethod("set_uv2_offset")]
        [Obsolete("SetUv2Offset is deprecated. Use the Uv2Offset property instead.")]
        public void SetUv2Offset(Vector3 offset)
        {
            NativeCalls.godot_icall_1_148(method_bind_64, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_65 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_uv2_offset");

        [GodotMethod("get_uv2_offset")]
        [Obsolete("GetUv2Offset is deprecated. Use the Uv2Offset property instead.")]
        public Vector3 GetUv2Offset()
        {
            NativeCalls.godot_icall_0_8(method_bind_65, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_66 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_uv2_triplanar_blend_sharpness");

        [GodotMethod("set_uv2_triplanar_blend_sharpness")]
        [Obsolete("SetUv2TriplanarBlendSharpness is deprecated. Use the Uv2TriplanarSharpness property instead.")]
        public void SetUv2TriplanarBlendSharpness(float sharpness)
        {
            NativeCalls.godot_icall_1_15(method_bind_66, Object.GetPtr(this), sharpness);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_67 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_uv2_triplanar_blend_sharpness");

        [GodotMethod("get_uv2_triplanar_blend_sharpness")]
        [Obsolete("GetUv2TriplanarBlendSharpness is deprecated. Use the Uv2TriplanarSharpness property instead.")]
        public float GetUv2TriplanarBlendSharpness()
        {
            return NativeCalls.godot_icall_0_14(method_bind_67, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_68 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_billboard_mode");

        [GodotMethod("set_billboard_mode")]
        [Obsolete("SetBillboardMode is deprecated. Use the ParamsBillboardMode property instead.")]
        public void SetBillboardMode(SpatialMaterial.BillboardMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_68, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_69 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_billboard_mode");

        [GodotMethod("get_billboard_mode")]
        [Obsolete("GetBillboardMode is deprecated. Use the ParamsBillboardMode property instead.")]
        public SpatialMaterial.BillboardMode GetBillboardMode()
        {
            return (SpatialMaterial.BillboardMode)NativeCalls.godot_icall_0_578(method_bind_69, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_70 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_particles_anim_h_frames");

        [GodotMethod("set_particles_anim_h_frames")]
        [Obsolete("SetParticlesAnimHFrames is deprecated. Use the ParticlesAnimHFrames property instead.")]
        public void SetParticlesAnimHFrames(int frames)
        {
            NativeCalls.godot_icall_1_4(method_bind_70, Object.GetPtr(this), frames);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_71 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_particles_anim_h_frames");

        [GodotMethod("get_particles_anim_h_frames")]
        [Obsolete("GetParticlesAnimHFrames is deprecated. Use the ParticlesAnimHFrames property instead.")]
        public int GetParticlesAnimHFrames()
        {
            return NativeCalls.godot_icall_0_5(method_bind_71, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_72 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_particles_anim_v_frames");

        [GodotMethod("set_particles_anim_v_frames")]
        [Obsolete("SetParticlesAnimVFrames is deprecated. Use the ParticlesAnimVFrames property instead.")]
        public void SetParticlesAnimVFrames(int frames)
        {
            NativeCalls.godot_icall_1_4(method_bind_72, Object.GetPtr(this), frames);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_73 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_particles_anim_v_frames");

        [GodotMethod("get_particles_anim_v_frames")]
        [Obsolete("GetParticlesAnimVFrames is deprecated. Use the ParticlesAnimVFrames property instead.")]
        public int GetParticlesAnimVFrames()
        {
            return NativeCalls.godot_icall_0_5(method_bind_73, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_74 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_particles_anim_loop");

        [GodotMethod("set_particles_anim_loop")]
        [Obsolete("SetParticlesAnimLoop is deprecated. Use the ParticlesAnimLoop property instead.")]
        public void SetParticlesAnimLoop(bool loop)
        {
            NativeCalls.godot_icall_1_16(method_bind_74, Object.GetPtr(this), loop);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_75 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_particles_anim_loop");

        [GodotMethod("get_particles_anim_loop")]
        [Obsolete("GetParticlesAnimLoop is deprecated. Use the ParticlesAnimLoop property instead.")]
        public bool GetParticlesAnimLoop()
        {
            return NativeCalls.godot_icall_0_7(method_bind_75, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_76 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_depth_deep_parallax");

        [GodotMethod("set_depth_deep_parallax")]
        [Obsolete("SetDepthDeepParallax is deprecated. Use the DepthDeepParallax property instead.")]
        public void SetDepthDeepParallax(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_76, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_77 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_depth_deep_parallax_enabled");

        [GodotMethod("is_depth_deep_parallax_enabled")]
        [Obsolete("IsDepthDeepParallaxEnabled is deprecated. Use the DepthDeepParallax property instead.")]
        public bool IsDepthDeepParallaxEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_77, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_78 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_depth_deep_parallax_min_layers");

        [GodotMethod("set_depth_deep_parallax_min_layers")]
        [Obsolete("SetDepthDeepParallaxMinLayers is deprecated. Use the DepthMinLayers property instead.")]
        public void SetDepthDeepParallaxMinLayers(int layer)
        {
            NativeCalls.godot_icall_1_4(method_bind_78, Object.GetPtr(this), layer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_79 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_depth_deep_parallax_min_layers");

        [GodotMethod("get_depth_deep_parallax_min_layers")]
        [Obsolete("GetDepthDeepParallaxMinLayers is deprecated. Use the DepthMinLayers property instead.")]
        public int GetDepthDeepParallaxMinLayers()
        {
            return NativeCalls.godot_icall_0_5(method_bind_79, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_80 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_depth_deep_parallax_max_layers");

        [GodotMethod("set_depth_deep_parallax_max_layers")]
        [Obsolete("SetDepthDeepParallaxMaxLayers is deprecated. Use the DepthMaxLayers property instead.")]
        public void SetDepthDeepParallaxMaxLayers(int layer)
        {
            NativeCalls.godot_icall_1_4(method_bind_80, Object.GetPtr(this), layer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_81 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_depth_deep_parallax_max_layers");

        [GodotMethod("get_depth_deep_parallax_max_layers")]
        [Obsolete("GetDepthDeepParallaxMaxLayers is deprecated. Use the DepthMaxLayers property instead.")]
        public int GetDepthDeepParallaxMaxLayers()
        {
            return NativeCalls.godot_icall_0_5(method_bind_81, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_82 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_depth_deep_parallax_flip_tangent");

        [GodotMethod("set_depth_deep_parallax_flip_tangent")]
        [Obsolete("SetDepthDeepParallaxFlipTangent is deprecated. Use the DepthFlipTangent property instead.")]
        public void SetDepthDeepParallaxFlipTangent(bool flip)
        {
            NativeCalls.godot_icall_1_16(method_bind_82, Object.GetPtr(this), flip);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_83 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_depth_deep_parallax_flip_tangent");

        [GodotMethod("get_depth_deep_parallax_flip_tangent")]
        [Obsolete("GetDepthDeepParallaxFlipTangent is deprecated. Use the DepthFlipTangent property instead.")]
        public bool GetDepthDeepParallaxFlipTangent()
        {
            return NativeCalls.godot_icall_0_7(method_bind_83, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_84 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_depth_deep_parallax_flip_binormal");

        [GodotMethod("set_depth_deep_parallax_flip_binormal")]
        [Obsolete("SetDepthDeepParallaxFlipBinormal is deprecated. Use the DepthFlipBinormal property instead.")]
        public void SetDepthDeepParallaxFlipBinormal(bool flip)
        {
            NativeCalls.godot_icall_1_16(method_bind_84, Object.GetPtr(this), flip);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_85 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_depth_deep_parallax_flip_binormal");

        [GodotMethod("get_depth_deep_parallax_flip_binormal")]
        [Obsolete("GetDepthDeepParallaxFlipBinormal is deprecated. Use the DepthFlipBinormal property instead.")]
        public bool GetDepthDeepParallaxFlipBinormal()
        {
            return NativeCalls.godot_icall_0_7(method_bind_85, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_86 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_grow");

        [GodotMethod("set_grow")]
        [Obsolete("SetGrow is deprecated. Use the ParamsGrowAmount property instead.")]
        public void SetGrow(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_86, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_87 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_grow");

        [GodotMethod("get_grow")]
        [Obsolete("GetGrow is deprecated. Use the ParamsGrowAmount property instead.")]
        public float GetGrow()
        {
            return NativeCalls.godot_icall_0_14(method_bind_87, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_88 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_operator");

        [GodotMethod("set_emission_operator")]
        [Obsolete("SetEmissionOperator is deprecated. Use the EmissionOperator property instead.")]
        public void SetEmissionOperator(SpatialMaterial.EmissionOperatorEnum @operator)
        {
            NativeCalls.godot_icall_1_4(method_bind_88, Object.GetPtr(this), (int)@operator);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_89 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_operator");

        [GodotMethod("get_emission_operator")]
        [Obsolete("GetEmissionOperator is deprecated. Use the EmissionOperator property instead.")]
        public SpatialMaterial.EmissionOperatorEnum GetEmissionOperator()
        {
            return (SpatialMaterial.EmissionOperatorEnum)NativeCalls.godot_icall_0_875(method_bind_89, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_90 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ao_light_affect");

        [GodotMethod("set_ao_light_affect")]
        [Obsolete("SetAoLightAffect is deprecated. Use the AoLightAffect property instead.")]
        public void SetAoLightAffect(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_90, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_91 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ao_light_affect");

        [GodotMethod("get_ao_light_affect")]
        [Obsolete("GetAoLightAffect is deprecated. Use the AoLightAffect property instead.")]
        public float GetAoLightAffect()
        {
            return NativeCalls.godot_icall_0_14(method_bind_91, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_92 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_alpha_scissor_threshold");

        [GodotMethod("set_alpha_scissor_threshold")]
        [Obsolete("SetAlphaScissorThreshold is deprecated. Use the ParamsAlphaScissorThreshold property instead.")]
        public void SetAlphaScissorThreshold(float threshold)
        {
            NativeCalls.godot_icall_1_15(method_bind_92, Object.GetPtr(this), threshold);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_93 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_alpha_scissor_threshold");

        [GodotMethod("get_alpha_scissor_threshold")]
        [Obsolete("GetAlphaScissorThreshold is deprecated. Use the ParamsAlphaScissorThreshold property instead.")]
        public float GetAlphaScissorThreshold()
        {
            return NativeCalls.godot_icall_0_14(method_bind_93, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_94 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_grow_enabled");

        [GodotMethod("set_grow_enabled")]
        [Obsolete("SetGrowEnabled is deprecated. Use the ParamsGrow property instead.")]
        public void SetGrowEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_94, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_95 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_grow_enabled");

        [GodotMethod("is_grow_enabled")]
        [Obsolete("IsGrowEnabled is deprecated. Use the ParamsGrow property instead.")]
        public bool IsGrowEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_95, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_96 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_metallic_texture_channel");

        [GodotMethod("set_metallic_texture_channel")]
        [Obsolete("SetMetallicTextureChannel is deprecated. Use the MetallicTextureChannel property instead.")]
        public void SetMetallicTextureChannel(SpatialMaterial.TextureChannel channel)
        {
            NativeCalls.godot_icall_1_4(method_bind_96, Object.GetPtr(this), (int)channel);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_97 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_metallic_texture_channel");

        [GodotMethod("get_metallic_texture_channel")]
        [Obsolete("GetMetallicTextureChannel is deprecated. Use the MetallicTextureChannel property instead.")]
        public SpatialMaterial.TextureChannel GetMetallicTextureChannel()
        {
            return (SpatialMaterial.TextureChannel)NativeCalls.godot_icall_0_876(method_bind_97, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_98 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_roughness_texture_channel");

        [GodotMethod("set_roughness_texture_channel")]
        [Obsolete("SetRoughnessTextureChannel is deprecated. Use the RoughnessTextureChannel property instead.")]
        public void SetRoughnessTextureChannel(SpatialMaterial.TextureChannel channel)
        {
            NativeCalls.godot_icall_1_4(method_bind_98, Object.GetPtr(this), (int)channel);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_99 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_roughness_texture_channel");

        [GodotMethod("get_roughness_texture_channel")]
        [Obsolete("GetRoughnessTextureChannel is deprecated. Use the RoughnessTextureChannel property instead.")]
        public SpatialMaterial.TextureChannel GetRoughnessTextureChannel()
        {
            return (SpatialMaterial.TextureChannel)NativeCalls.godot_icall_0_876(method_bind_99, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_100 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ao_texture_channel");

        [GodotMethod("set_ao_texture_channel")]
        [Obsolete("SetAoTextureChannel is deprecated. Use the AoTextureChannel property instead.")]
        public void SetAoTextureChannel(SpatialMaterial.TextureChannel channel)
        {
            NativeCalls.godot_icall_1_4(method_bind_100, Object.GetPtr(this), (int)channel);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_101 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ao_texture_channel");

        [GodotMethod("get_ao_texture_channel")]
        [Obsolete("GetAoTextureChannel is deprecated. Use the AoTextureChannel property instead.")]
        public SpatialMaterial.TextureChannel GetAoTextureChannel()
        {
            return (SpatialMaterial.TextureChannel)NativeCalls.godot_icall_0_876(method_bind_101, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_102 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_refraction_texture_channel");

        [GodotMethod("set_refraction_texture_channel")]
        [Obsolete("SetRefractionTextureChannel is deprecated. Use the RefractionTextureChannel property instead.")]
        public void SetRefractionTextureChannel(SpatialMaterial.TextureChannel channel)
        {
            NativeCalls.godot_icall_1_4(method_bind_102, Object.GetPtr(this), (int)channel);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_103 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_refraction_texture_channel");

        [GodotMethod("get_refraction_texture_channel")]
        [Obsolete("GetRefractionTextureChannel is deprecated. Use the RefractionTextureChannel property instead.")]
        public SpatialMaterial.TextureChannel GetRefractionTextureChannel()
        {
            return (SpatialMaterial.TextureChannel)NativeCalls.godot_icall_0_876(method_bind_103, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_104 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_proximity_fade");

        [GodotMethod("set_proximity_fade")]
        [Obsolete("SetProximityFade is deprecated. Use the ProximityFadeEnable property instead.")]
        public void SetProximityFade(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_104, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_105 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_proximity_fade_enabled");

        [GodotMethod("is_proximity_fade_enabled")]
        [Obsolete("IsProximityFadeEnabled is deprecated. Use the ProximityFadeEnable property instead.")]
        public bool IsProximityFadeEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_105, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_106 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_proximity_fade_distance");

        [GodotMethod("set_proximity_fade_distance")]
        [Obsolete("SetProximityFadeDistance is deprecated. Use the ProximityFadeDistance property instead.")]
        public void SetProximityFadeDistance(float distance)
        {
            NativeCalls.godot_icall_1_15(method_bind_106, Object.GetPtr(this), distance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_107 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_proximity_fade_distance");

        [GodotMethod("get_proximity_fade_distance")]
        [Obsolete("GetProximityFadeDistance is deprecated. Use the ProximityFadeDistance property instead.")]
        public float GetProximityFadeDistance()
        {
            return NativeCalls.godot_icall_0_14(method_bind_107, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_108 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_distance_fade");

        [GodotMethod("set_distance_fade")]
        [Obsolete("SetDistanceFade is deprecated. Use the DistanceFadeMode property instead.")]
        public void SetDistanceFade(SpatialMaterial.DistanceFadeModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_108, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_109 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_distance_fade");

        [GodotMethod("get_distance_fade")]
        [Obsolete("GetDistanceFade is deprecated. Use the DistanceFadeMode property instead.")]
        public SpatialMaterial.DistanceFadeModeEnum GetDistanceFade()
        {
            return (SpatialMaterial.DistanceFadeModeEnum)NativeCalls.godot_icall_0_877(method_bind_109, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_110 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_distance_fade_max_distance");

        [GodotMethod("set_distance_fade_max_distance")]
        [Obsolete("SetDistanceFadeMaxDistance is deprecated. Use the DistanceFadeMaxDistance property instead.")]
        public void SetDistanceFadeMaxDistance(float distance)
        {
            NativeCalls.godot_icall_1_15(method_bind_110, Object.GetPtr(this), distance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_111 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_distance_fade_max_distance");

        [GodotMethod("get_distance_fade_max_distance")]
        [Obsolete("GetDistanceFadeMaxDistance is deprecated. Use the DistanceFadeMaxDistance property instead.")]
        public float GetDistanceFadeMaxDistance()
        {
            return NativeCalls.godot_icall_0_14(method_bind_111, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_112 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_distance_fade_min_distance");

        [GodotMethod("set_distance_fade_min_distance")]
        [Obsolete("SetDistanceFadeMinDistance is deprecated. Use the DistanceFadeMinDistance property instead.")]
        public void SetDistanceFadeMinDistance(float distance)
        {
            NativeCalls.godot_icall_1_15(method_bind_112, Object.GetPtr(this), distance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_113 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_distance_fade_min_distance");

        [GodotMethod("get_distance_fade_min_distance")]
        [Obsolete("GetDistanceFadeMinDistance is deprecated. Use the DistanceFadeMinDistance property instead.")]
        public float GetDistanceFadeMinDistance()
        {
            return NativeCalls.godot_icall_0_14(method_bind_113, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_114 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_async_mode");

        [GodotMethod("set_async_mode")]
        [Obsolete("SetAsyncMode is deprecated. Use the AsyncMode property instead.")]
        public void SetAsyncMode(SpatialMaterial.AsyncModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_114, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_115 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_async_mode");

        [GodotMethod("get_async_mode")]
        [Obsolete("GetAsyncMode is deprecated. Use the AsyncMode property instead.")]
        public SpatialMaterial.AsyncModeEnum GetAsyncMode()
        {
            return (SpatialMaterial.AsyncModeEnum)NativeCalls.godot_icall_0_878(method_bind_115, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
