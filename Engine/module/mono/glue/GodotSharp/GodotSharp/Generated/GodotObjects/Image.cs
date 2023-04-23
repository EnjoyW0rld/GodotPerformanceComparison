using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Native image datatype. Contains image data which can be converted to an <see cref="Godot.ImageTexture"/> and provides commonly used image processing methods. The maximum width and height for an <see cref="Godot.Image"/> are <see cref="Godot.Image.MaxWidth"/> and <see cref="Godot.Image.MaxHeight"/>.</para>
    /// <para>An <see cref="Godot.Image"/> cannot be assigned to a <c>texture</c> property of an object directly (such as <see cref="Godot.Sprite"/>), and has to be converted manually to an <see cref="Godot.ImageTexture"/> first.</para>
    /// <para>Note: The maximum image size is 16384×16384 pixels due to graphics hardware limitations. Larger images may fail to import.</para>
    /// </summary>
    public partial class Image : Resource
    {
        /// <summary>
        /// <para>The maximal width allowed for <see cref="Godot.Image"/> resources.</para>
        /// </summary>
        public const int MaxWidth = 16384;
        /// <summary>
        /// <para>The maximal height allowed for <see cref="Godot.Image"/> resources.</para>
        /// </summary>
        public const int MaxHeight = 16384;

        public enum AlphaMode
        {
            /// <summary>
            /// <para>Image does not have alpha.</para>
            /// </summary>
            None = 0,
            /// <summary>
            /// <para>Image stores alpha in a single bit.</para>
            /// </summary>
            Bit = 1,
            /// <summary>
            /// <para>Image uses alpha.</para>
            /// </summary>
            Blend = 2
        }

        public enum CompressSource
        {
            /// <summary>
            /// <para>Source texture (before compression) is a regular texture. Default for all textures.</para>
            /// </summary>
            Generic = 0,
            /// <summary>
            /// <para>Source texture (before compression) is in sRGB space.</para>
            /// </summary>
            Srgb = 1,
            /// <summary>
            /// <para>Source texture (before compression) is a normal texture (e.g. it can be compressed into two channels).</para>
            /// </summary>
            Normal = 2,
            /// <summary>
            /// <para>Source texture (before compression) is a <see cref="Godot.TextureLayered"/>.</para>
            /// </summary>
            Layered = 3
        }

        public enum Interpolation
        {
            /// <summary>
            /// <para>Performs nearest-neighbor interpolation. If the image is resized, it will be pixelated.</para>
            /// </summary>
            Nearest = 0,
            /// <summary>
            /// <para>Performs bilinear interpolation. If the image is resized, it will be blurry. This mode is faster than <see cref="Godot.Image.Interpolation.Cubic"/>, but it results in lower quality.</para>
            /// </summary>
            Bilinear = 1,
            /// <summary>
            /// <para>Performs cubic interpolation. If the image is resized, it will be blurry. This mode often gives better results compared to <see cref="Godot.Image.Interpolation.Bilinear"/>, at the cost of being slower.</para>
            /// </summary>
            Cubic = 2,
            /// <summary>
            /// <para>Performs bilinear separately on the two most-suited mipmap levels, then linearly interpolates between them.</para>
            /// <para>It's slower than <see cref="Godot.Image.Interpolation.Bilinear"/>, but produces higher-quality results with far fewer aliasing artifacts.</para>
            /// <para>If the image does not have mipmaps, they will be generated and used internally, but no mipmaps will be generated on the resulting image.</para>
            /// <para>Note: If you intend to scale multiple copies of the original image, it's better to call <see cref="Godot.Image.GenerateMipmaps"/>] on it in advance, to avoid wasting processing power in generating them again and again.</para>
            /// <para>On the other hand, if the image already has mipmaps, they will be used, and a new set will be generated for the resulting image.</para>
            /// </summary>
            Trilinear = 3,
            /// <summary>
            /// <para>Performs Lanczos interpolation. This is the slowest image resizing mode, but it typically gives the best results, especially when downscalng images.</para>
            /// </summary>
            Lanczos = 4
        }

        public enum CompressMode
        {
            /// <summary>
            /// <para>Use S3TC compression.</para>
            /// </summary>
            S3tc = 0,
            /// <summary>
            /// <para>Use PVRTC2 compression.</para>
            /// </summary>
            Pvrtc2 = 1,
            /// <summary>
            /// <para>Use PVRTC4 compression.</para>
            /// </summary>
            Pvrtc4 = 2,
            /// <summary>
            /// <para>Use ETC compression.</para>
            /// </summary>
            Etc = 3,
            /// <summary>
            /// <para>Use ETC2 compression.</para>
            /// </summary>
            Etc2 = 4
        }

        public enum Format
        {
            /// <summary>
            /// <para>Texture format with a single 8-bit depth representing luminance.</para>
            /// </summary>
            L8 = 0,
            /// <summary>
            /// <para>OpenGL texture format with two values, luminance and alpha each stored with 8 bits.</para>
            /// </summary>
            La8 = 1,
            /// <summary>
            /// <para>OpenGL texture format <c>RED</c> with a single component and a bitdepth of 8.</para>
            /// <para>Note: When using the GLES2 backend, this uses the alpha channel instead of the red channel for storage.</para>
            /// </summary>
            R8 = 2,
            /// <summary>
            /// <para>OpenGL texture format <c>RG</c> with two components and a bitdepth of 8 for each.</para>
            /// </summary>
            Rg8 = 3,
            /// <summary>
            /// <para>OpenGL texture format <c>RGB</c> with three components, each with a bitdepth of 8.</para>
            /// <para>Note: When creating an <see cref="Godot.ImageTexture"/>, an sRGB to linear color space conversion is performed.</para>
            /// </summary>
            Rgb8 = 4,
            /// <summary>
            /// <para>OpenGL texture format <c>RGBA</c> with four components, each with a bitdepth of 8.</para>
            /// <para>Note: When creating an <see cref="Godot.ImageTexture"/>, an sRGB to linear color space conversion is performed.</para>
            /// </summary>
            Rgba8 = 5,
            /// <summary>
            /// <para>OpenGL texture format <c>RGBA</c> with four components, each with a bitdepth of 4.</para>
            /// </summary>
            Rgba4444 = 6,
            /// <summary>
            /// <para>OpenGL texture format <c>GL_RGB5_A1</c> where 5 bits of depth for each component of RGB and one bit for alpha.</para>
            /// </summary>
            Rgba5551 = 7,
            /// <summary>
            /// <para>OpenGL texture format <c>GL_R32F</c> where there's one component, a 32-bit floating-point value.</para>
            /// </summary>
            Rf = 8,
            /// <summary>
            /// <para>OpenGL texture format <c>GL_RG32F</c> where there are two components, each a 32-bit floating-point values.</para>
            /// </summary>
            Rgf = 9,
            /// <summary>
            /// <para>OpenGL texture format <c>GL_RGB32F</c> where there are three components, each a 32-bit floating-point values.</para>
            /// </summary>
            Rgbf = 10,
            /// <summary>
            /// <para>OpenGL texture format <c>GL_RGBA32F</c> where there are four components, each a 32-bit floating-point values.</para>
            /// </summary>
            Rgbaf = 11,
            /// <summary>
            /// <para>OpenGL texture format <c>GL_R32F</c> where there's one component, a 16-bit "half-precision" floating-point value.</para>
            /// </summary>
            Rh = 12,
            /// <summary>
            /// <para>OpenGL texture format <c>GL_RG32F</c> where there are two components, each a 16-bit "half-precision" floating-point value.</para>
            /// </summary>
            Rgh = 13,
            /// <summary>
            /// <para>OpenGL texture format <c>GL_RGB32F</c> where there are three components, each a 16-bit "half-precision" floating-point value.</para>
            /// </summary>
            Rgbh = 14,
            /// <summary>
            /// <para>OpenGL texture format <c>GL_RGBA32F</c> where there are four components, each a 16-bit "half-precision" floating-point value.</para>
            /// </summary>
            Rgbah = 15,
            /// <summary>
            /// <para>A special OpenGL texture format where the three color components have 9 bits of precision and all three share a single 5-bit exponent.</para>
            /// </summary>
            Rgbe9995 = 16,
            /// <summary>
            /// <para>The <a href="https://en.wikipedia.org/wiki/S3_Texture_Compression">S3TC</a> texture format that uses Block Compression 1, and is the smallest variation of S3TC, only providing 1 bit of alpha and color data being premultiplied with alpha.</para>
            /// <para>Note: When creating an <see cref="Godot.ImageTexture"/>, an sRGB to linear color space conversion is performed.</para>
            /// </summary>
            Dxt1 = 17,
            /// <summary>
            /// <para>The <a href="https://en.wikipedia.org/wiki/S3_Texture_Compression">S3TC</a> texture format that uses Block Compression 2, and color data is interpreted as not having been premultiplied by alpha. Well suited for images with sharp alpha transitions between translucent and opaque areas.</para>
            /// <para>Note: When creating an <see cref="Godot.ImageTexture"/>, an sRGB to linear color space conversion is performed.</para>
            /// </summary>
            Dxt3 = 18,
            /// <summary>
            /// <para>The <a href="https://en.wikipedia.org/wiki/S3_Texture_Compression">S3TC</a> texture format also known as Block Compression 3 or BC3 that contains 64 bits of alpha channel data followed by 64 bits of DXT1-encoded color data. Color data is not premultiplied by alpha, same as DXT3. DXT5 generally produces superior results for transparent gradients compared to DXT3.</para>
            /// <para>Note: When creating an <see cref="Godot.ImageTexture"/>, an sRGB to linear color space conversion is performed.</para>
            /// </summary>
            Dxt5 = 19,
            /// <summary>
            /// <para>Texture format that uses <a href="https://www.khronos.org/opengl/wiki/Red_Green_Texture_Compression">Red Green Texture Compression</a>, normalizing the red channel data using the same compression algorithm that DXT5 uses for the alpha channel.</para>
            /// </summary>
            RgtcR = 20,
            /// <summary>
            /// <para>Texture format that uses <a href="https://www.khronos.org/opengl/wiki/Red_Green_Texture_Compression">Red Green Texture Compression</a>, normalizing the red and green channel data using the same compression algorithm that DXT5 uses for the alpha channel.</para>
            /// </summary>
            RgtcRg = 21,
            /// <summary>
            /// <para>Texture format that uses <a href="https://www.khronos.org/opengl/wiki/BPTC_Texture_Compression">BPTC</a> compression with unsigned normalized RGBA components.</para>
            /// <para>Note: When creating an <see cref="Godot.ImageTexture"/>, an sRGB to linear color space conversion is performed.</para>
            /// </summary>
            BptcRgba = 22,
            /// <summary>
            /// <para>Texture format that uses <a href="https://www.khronos.org/opengl/wiki/BPTC_Texture_Compression">BPTC</a> compression with signed floating-point RGB components.</para>
            /// </summary>
            BptcRgbf = 23,
            /// <summary>
            /// <para>Texture format that uses <a href="https://www.khronos.org/opengl/wiki/BPTC_Texture_Compression">BPTC</a> compression with unsigned floating-point RGB components.</para>
            /// </summary>
            BptcRgbfu = 24,
            /// <summary>
            /// <para>Texture format used on PowerVR-supported mobile platforms, uses 2-bit color depth with no alpha. More information can be found <a href="https://en.wikipedia.org/wiki/PVRTC">here</a>.</para>
            /// <para>Note: When creating an <see cref="Godot.ImageTexture"/>, an sRGB to linear color space conversion is performed.</para>
            /// </summary>
            Pvrtc2 = 25,
            /// <summary>
            /// <para>Same as <a href="https://en.wikipedia.org/wiki/PVRTC">PVRTC2</a>, but with an alpha component.</para>
            /// </summary>
            Pvrtc2a = 26,
            /// <summary>
            /// <para>Similar to <a href="https://en.wikipedia.org/wiki/PVRTC">PVRTC2</a>, but with 4-bit color depth and no alpha.</para>
            /// </summary>
            Pvrtc4 = 27,
            /// <summary>
            /// <para>Same as <a href="https://en.wikipedia.org/wiki/PVRTC">PVRTC4</a>, but with an alpha component.</para>
            /// </summary>
            Pvrtc4a = 28,
            /// <summary>
            /// <para><a href="https://en.wikipedia.org/wiki/Ericsson_Texture_Compression#ETC1">Ericsson Texture Compression format 1</a>, also referred to as "ETC1", and is part of the OpenGL ES graphics standard. This format cannot store an alpha channel.</para>
            /// </summary>
            Etc = 29,
            /// <summary>
            /// <para><a href="https://en.wikipedia.org/wiki/Ericsson_Texture_Compression#ETC2_and_EAC">Ericsson Texture Compression format 2</a> (<c>R11_EAC</c> variant), which provides one channel of unsigned data.</para>
            /// </summary>
            Etc2R11 = 30,
            /// <summary>
            /// <para><a href="https://en.wikipedia.org/wiki/Ericsson_Texture_Compression#ETC2_and_EAC">Ericsson Texture Compression format 2</a> (<c>SIGNED_R11_EAC</c> variant), which provides one channel of signed data.</para>
            /// </summary>
            Etc2R11s = 31,
            /// <summary>
            /// <para><a href="https://en.wikipedia.org/wiki/Ericsson_Texture_Compression#ETC2_and_EAC">Ericsson Texture Compression format 2</a> (<c>RG11_EAC</c> variant), which provides two channels of unsigned data.</para>
            /// </summary>
            Etc2Rg11 = 32,
            /// <summary>
            /// <para><a href="https://en.wikipedia.org/wiki/Ericsson_Texture_Compression#ETC2_and_EAC">Ericsson Texture Compression format 2</a> (<c>SIGNED_RG11_EAC</c> variant), which provides two channels of signed data.</para>
            /// </summary>
            Etc2Rg11s = 33,
            /// <summary>
            /// <para><a href="https://en.wikipedia.org/wiki/Ericsson_Texture_Compression#ETC2_and_EAC">Ericsson Texture Compression format 2</a> (<c>RGB8</c> variant), which is a follow-up of ETC1 and compresses RGB888 data.</para>
            /// <para>Note: When creating an <see cref="Godot.ImageTexture"/>, an sRGB to linear color space conversion is performed.</para>
            /// </summary>
            Etc2Rgb8 = 34,
            /// <summary>
            /// <para><a href="https://en.wikipedia.org/wiki/Ericsson_Texture_Compression#ETC2_and_EAC">Ericsson Texture Compression format 2</a> (<c>RGBA8</c>variant), which compresses RGBA8888 data with full alpha support.</para>
            /// <para>Note: When creating an <see cref="Godot.ImageTexture"/>, an sRGB to linear color space conversion is performed.</para>
            /// </summary>
            Etc2Rgba8 = 35,
            /// <summary>
            /// <para><a href="https://en.wikipedia.org/wiki/Ericsson_Texture_Compression#ETC2_and_EAC">Ericsson Texture Compression format 2</a> (<c>RGB8_PUNCHTHROUGH_ALPHA1</c> variant), which compresses RGBA data to make alpha either fully transparent or fully opaque.</para>
            /// <para>Note: When creating an <see cref="Godot.ImageTexture"/>, an sRGB to linear color space conversion is performed.</para>
            /// </summary>
            Etc2Rgb8a1 = 36,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.Image.Format"/> enum.</para>
            /// </summary>
            Max = 37
        }

        /// <summary>
        /// <para>Holds all the image's color data in a given format. See <see cref="Godot.Image.Format"/> constants.</para>
        /// </summary>
        public Godot.Collections.Dictionary Data
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetData();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetData(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Image";

        public Image() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Image_Ctor(this);
        }

        internal Image(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_width");

        /// <summary>
        /// <para>Returns the image's width.</para>
        /// </summary>
        [GodotMethod("get_width")]
        public int GetWidth()
        {
            return NativeCalls.godot_icall_0_5(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_height");

        /// <summary>
        /// <para>Returns the image's height.</para>
        /// </summary>
        [GodotMethod("get_height")]
        public int GetHeight()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_size");

        /// <summary>
        /// <para>Returns the image's size (width and height).</para>
        /// </summary>
        [GodotMethod("get_size")]
        public Vector2 GetSize()
        {
            NativeCalls.godot_icall_0_18(method_bind_2, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_mipmaps");

        /// <summary>
        /// <para>Returns <c>true</c> if the image has generated mipmaps.</para>
        /// </summary>
        [GodotMethod("has_mipmaps")]
        public bool HasMipmaps()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_format");

        /// <summary>
        /// <para>Returns the image's format. See <see cref="Godot.Image.Format"/> constants.</para>
        /// </summary>
        [GodotMethod("get_format")]
        public Image.Format GetFormat()
        {
            return (Image.Format)NativeCalls.godot_icall_0_501(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_data");

        /// <summary>
        /// <para>Returns a copy of the image's raw data.</para>
        /// </summary>
        [GodotMethod("get_data")]
        public byte[] GetData()
        {
            return NativeCalls.godot_icall_0_2(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "convert");

        /// <summary>
        /// <para>Converts the image's format. See <see cref="Godot.Image.Format"/> constants.</para>
        /// </summary>
        [GodotMethod("convert")]
        public void Convert(Image.Format format)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), (int)format);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mipmap_offset");

        /// <summary>
        /// <para>Returns the offset where the image's mipmap with index <c>mipmap</c> is stored in the <c>data</c> dictionary.</para>
        /// </summary>
        [GodotMethod("get_mipmap_offset")]
        public int GetMipmapOffset(int mipmap)
        {
            return NativeCalls.godot_icall_1_11(method_bind_7, Object.GetPtr(this), mipmap);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "resize_to_po2");

        /// <summary>
        /// <para>Resizes the image to the nearest power of 2 for the width and height. If <c>square</c> is <c>true</c> then set width and height to be the same. New pixels are calculated using the <c>interpolation</c> mode defined via <see cref="Godot.Image.Interpolation"/> constants.</para>
        /// </summary>
        [GodotMethod("resize_to_po2")]
        public void ResizeToPo2(bool square = false, Image.Interpolation interpolation = (Image.Interpolation)1)
        {
            NativeCalls.godot_icall_2_502(method_bind_8, Object.GetPtr(this), square, (int)interpolation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "resize");

        /// <summary>
        /// <para>Resizes the image to the given <c>width</c> and <c>height</c>. New pixels are calculated using the <c>interpolation</c> mode defined via <see cref="Godot.Image.Interpolation"/> constants.</para>
        /// </summary>
        [GodotMethod("resize")]
        public void Resize(int width, int height, Image.Interpolation interpolation = (Image.Interpolation)1)
        {
            NativeCalls.godot_icall_3_176(method_bind_9, Object.GetPtr(this), width, height, (int)interpolation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shrink_x2");

        /// <summary>
        /// <para>Shrinks the image by a factor of 2.</para>
        /// </summary>
        [GodotMethod("shrink_x2")]
        public void ShrinkX2()
        {
            NativeCalls.godot_icall_0_3(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "expand_x2_hq2x");

        /// <summary>
        /// <para>Stretches the image and enlarges it by a factor of 2. No interpolation is done.</para>
        /// </summary>
        [GodotMethod("expand_x2_hq2x")]
        public void ExpandX2Hq2x()
        {
            NativeCalls.godot_icall_0_3(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "crop");

        /// <summary>
        /// <para>Crops the image to the given <c>width</c> and <c>height</c>. If the specified size is larger than the current size, the extra area is filled with black pixels.</para>
        /// </summary>
        [GodotMethod("crop")]
        public void Crop(int width, int height)
        {
            NativeCalls.godot_icall_2_65(method_bind_12, Object.GetPtr(this), width, height);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "flip_x");

        /// <summary>
        /// <para>Flips the image horizontally.</para>
        /// </summary>
        [GodotMethod("flip_x")]
        public void FlipX()
        {
            NativeCalls.godot_icall_0_3(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "flip_y");

        /// <summary>
        /// <para>Flips the image vertically.</para>
        /// </summary>
        [GodotMethod("flip_y")]
        public void FlipY()
        {
            NativeCalls.godot_icall_0_3(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "generate_mipmaps");

        /// <summary>
        /// <para>Generates mipmaps for the image. Mipmaps are precalculated lower-resolution copies of the image that are automatically used if the image needs to be scaled down when rendered. They help improve image quality and performance when rendering. This method returns an error if the image is compressed, in a custom format, or if the image's width/height is <c>0</c>.</para>
        /// <para>Note: Mipmap generation is done on the CPU, is single-threaded and is always done on the main thread. This means generating mipmaps will result in noticeable stuttering during gameplay, even if <see cref="Godot.Image.GenerateMipmaps"/> is called from a <see cref="Godot.Thread"/>.</para>
        /// </summary>
        [GodotMethod("generate_mipmaps")]
        public Error GenerateMipmaps(bool renormalize = false)
        {
            return (Error)NativeCalls.godot_icall_1_503(method_bind_15, Object.GetPtr(this), renormalize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_mipmaps");

        /// <summary>
        /// <para>Removes the image's mipmaps.</para>
        /// </summary>
        [GodotMethod("clear_mipmaps")]
        public void ClearMipmaps()
        {
            NativeCalls.godot_icall_0_3(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create");

        /// <summary>
        /// <para>Creates an empty image of given size and format. See <see cref="Godot.Image.Format"/> constants. If <c>use_mipmaps</c> is <c>true</c> then generate mipmaps for this image. See the <see cref="Godot.Image.GenerateMipmaps"/>.</para>
        /// </summary>
        [GodotMethod("create")]
        public void Create(int width, int height, bool useMipmaps, Image.Format format)
        {
            NativeCalls.godot_icall_4_504(method_bind_17, Object.GetPtr(this), width, height, useMipmaps, (int)format);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_from_data");

        /// <summary>
        /// <para>Creates a new image of given size and format. See <see cref="Godot.Image.Format"/> constants. Fills the image with the given raw data. If <c>use_mipmaps</c> is <c>true</c> then loads mipmaps for this image from <c>data</c>. See <see cref="Godot.Image.GenerateMipmaps"/>.</para>
        /// </summary>
        [GodotMethod("create_from_data")]
        public void CreateFromData(int width, int height, bool useMipmaps, Image.Format format, byte[] data)
        {
            NativeCalls.godot_icall_5_505(method_bind_18, Object.GetPtr(this), width, height, useMipmaps, (int)format, data);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_empty");

        /// <summary>
        /// <para>Returns <c>true</c> if the image has no data.</para>
        /// </summary>
        [GodotMethod("is_empty")]
        public bool IsEmpty()
        {
            return NativeCalls.godot_icall_0_7(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "load");

        /// <summary>
        /// <para>Loads an image from file <c>path</c>. See <a href="$DOCS_URL/tutorials/assets_pipeline/importing_images.html#supported-image-formats">Supported image formats</a> for a list of supported image formats and limitations.</para>
        /// <para>Warning: This method should only be used in the editor or in cases when you need to load external images at run-time, such as images located at the <c>user://</c> directory, and may not work in exported projects.</para>
        /// <para>See also <see cref="Godot.ImageTexture"/> description for usage examples.</para>
        /// </summary>
        [GodotMethod("load")]
        public Error Load(string path)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_20, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "save_png");

        /// <summary>
        /// <para>Saves the image as a PNG file to <c>path</c>.</para>
        /// </summary>
        [GodotMethod("save_png")]
        public Error SavePng(string path)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_21, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "save_png_to_buffer");

        [GodotMethod("save_png_to_buffer")]
        public byte[] SavePngToBuffer()
        {
            return NativeCalls.godot_icall_0_2(method_bind_22, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "save_exr");

        /// <summary>
        /// <para>Saves the image as an EXR file to <c>path</c>. If <c>grayscale</c> is <c>true</c> and the image has only one channel, it will be saved explicitly as monochrome rather than one red channel. This function will return <c>ERR_UNAVAILABLE</c> if Godot was compiled without the TinyEXR module.</para>
        /// <para>Note: The TinyEXR module is disabled in non-editor builds, which means <see cref="Godot.Image.SaveExr"/> will return <c>ERR_UNAVAILABLE</c> when it is called from an exported project.</para>
        /// </summary>
        [GodotMethod("save_exr")]
        public Error SaveExr(string path, bool grayscale = false)
        {
            return (Error)NativeCalls.godot_icall_2_337(method_bind_23, Object.GetPtr(this), path, grayscale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "detect_alpha");

        /// <summary>
        /// <para>Returns <see cref="Godot.Image.AlphaMode.Blend"/> if the image has data for alpha values. Returns <see cref="Godot.Image.AlphaMode.Bit"/> if all the alpha values are stored in a single bit. Returns <see cref="Godot.Image.AlphaMode.None"/> if no data for alpha values is found.</para>
        /// </summary>
        [GodotMethod("detect_alpha")]
        public Image.AlphaMode DetectAlpha()
        {
            return (Image.AlphaMode)NativeCalls.godot_icall_0_506(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_invisible");

        /// <summary>
        /// <para>Returns <c>true</c> if all the image's pixels have an alpha value of 0. Returns <c>false</c> if any pixel has an alpha value higher than 0.</para>
        /// </summary>
        [GodotMethod("is_invisible")]
        public bool IsInvisible()
        {
            return NativeCalls.godot_icall_0_7(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "compress");

        /// <summary>
        /// <para>Compresses the image to use less memory. Can not directly access pixel data while the image is compressed. Returns error if the chosen compression mode is not available. See <see cref="Godot.Image.CompressMode"/> and <see cref="Godot.Image.CompressSource"/> constants.</para>
        /// </summary>
        [GodotMethod("compress")]
        public Error Compress(Image.CompressMode mode, Image.CompressSource source, float lossyQuality)
        {
            return (Error)NativeCalls.godot_icall_3_507(method_bind_26, Object.GetPtr(this), (int)mode, (int)source, lossyQuality);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "decompress");

        /// <summary>
        /// <para>Decompresses the image if it is compressed. Returns an error if decompress function is not available.</para>
        /// </summary>
        [GodotMethod("decompress")]
        public Error Decompress()
        {
            return (Error)NativeCalls.godot_icall_0_389(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_compressed");

        /// <summary>
        /// <para>Returns <c>true</c> if the image is compressed.</para>
        /// </summary>
        [GodotMethod("is_compressed")]
        public bool IsCompressed()
        {
            return NativeCalls.godot_icall_0_7(method_bind_28, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "fix_alpha_edges");

        /// <summary>
        /// <para>Blends low-alpha pixels with nearby pixels.</para>
        /// </summary>
        [GodotMethod("fix_alpha_edges")]
        public void FixAlphaEdges()
        {
            NativeCalls.godot_icall_0_3(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "premultiply_alpha");

        /// <summary>
        /// <para>Multiplies color values with alpha values. Resulting color values for a pixel are <c>(color * alpha)/256</c>.</para>
        /// </summary>
        [GodotMethod("premultiply_alpha")]
        public void PremultiplyAlpha()
        {
            NativeCalls.godot_icall_0_3(method_bind_30, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "srgb_to_linear");

        /// <summary>
        /// <para>Converts the raw data from the sRGB colorspace to a linear scale.</para>
        /// </summary>
        [GodotMethod("srgb_to_linear")]
        public void SrgbToLinear()
        {
            NativeCalls.godot_icall_0_3(method_bind_31, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "normalmap_to_xy");

        /// <summary>
        /// <para>Converts the image's data to represent coordinates on a 3D plane. This is used when the image represents a normalmap. A normalmap can add lots of detail to a 3D surface without increasing the polygon count.</para>
        /// </summary>
        [GodotMethod("normalmap_to_xy")]
        public void NormalmapToXy()
        {
            NativeCalls.godot_icall_0_3(method_bind_32, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rgbe_to_srgb");

        /// <summary>
        /// <para>Converts a standard RGBE (Red Green Blue Exponent) image to an sRGB image.</para>
        /// </summary>
        [GodotMethod("rgbe_to_srgb")]
        public Image RgbeToSrgb()
        {
            return NativeCalls.godot_icall_0_216(method_bind_33, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "bumpmap_to_normalmap");

        /// <summary>
        /// <para>Converts a bumpmap to a normalmap. A bumpmap provides a height offset per-pixel, while a normalmap provides a normal direction per pixel.</para>
        /// </summary>
        [GodotMethod("bumpmap_to_normalmap")]
        public void BumpmapToNormalmap(float bumpScale = 1f)
        {
            NativeCalls.godot_icall_1_15(method_bind_34, Object.GetPtr(this), bumpScale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "blit_rect");

        /// <summary>
        /// <para>Copies <c>src_rect</c> from <c>src</c> image to this image at coordinates <c>dst</c>, clipped accordingly to both image bounds. This image and <c>src</c> image must have the same format. <c>src_rect</c> with not positive size is treated as empty.</para>
        /// </summary>
        [GodotMethod("blit_rect")]
        public void BlitRect(Image src, Rect2 srcRect, Vector2 dst)
        {
            NativeCalls.godot_icall_3_508(method_bind_35, Object.GetPtr(this), Object.GetPtr(src), ref srcRect, ref dst);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "blit_rect_mask");

        /// <summary>
        /// <para>Blits <c>src_rect</c> area from <c>src</c> image to this image at the coordinates given by <c>dst</c>, clipped accordingly to both image bounds. <c>src</c> pixel is copied onto <c>dst</c> if the corresponding <c>mask</c> pixel's alpha value is not 0. This image and <c>src</c> image must have the same format. <c>src</c> image and <c>mask</c> image must have the same size (width and height) but they can have different formats. <c>src_rect</c> with not positive size is treated as empty.</para>
        /// </summary>
        [GodotMethod("blit_rect_mask")]
        public void BlitRectMask(Image src, Image mask, Rect2 srcRect, Vector2 dst)
        {
            NativeCalls.godot_icall_4_509(method_bind_36, Object.GetPtr(this), Object.GetPtr(src), Object.GetPtr(mask), ref srcRect, ref dst);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "blend_rect");

        /// <summary>
        /// <para>Alpha-blends <c>src_rect</c> from <c>src</c> image to this image at coordinates <c>dest</c>, clipped accordingly to both image bounds. This image and <c>src</c> image must have the same format. <c>src_rect</c> with not positive size is treated as empty.</para>
        /// </summary>
        [GodotMethod("blend_rect")]
        public void BlendRect(Image src, Rect2 srcRect, Vector2 dst)
        {
            NativeCalls.godot_icall_3_508(method_bind_37, Object.GetPtr(this), Object.GetPtr(src), ref srcRect, ref dst);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "blend_rect_mask");

        /// <summary>
        /// <para>Alpha-blends <c>src_rect</c> from <c>src</c> image to this image using <c>mask</c> image at coordinates <c>dst</c>, clipped accordingly to both image bounds. Alpha channels are required for both <c>src</c> and <c>mask</c>. <c>dst</c> pixels and <c>src</c> pixels will blend if the corresponding mask pixel's alpha value is not 0. This image and <c>src</c> image must have the same format. <c>src</c> image and <c>mask</c> image must have the same size (width and height) but they can have different formats. <c>src_rect</c> with not positive size is treated as empty.</para>
        /// </summary>
        [GodotMethod("blend_rect_mask")]
        public void BlendRectMask(Image src, Image mask, Rect2 srcRect, Vector2 dst)
        {
            NativeCalls.godot_icall_4_509(method_bind_38, Object.GetPtr(this), Object.GetPtr(src), Object.GetPtr(mask), ref srcRect, ref dst);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "fill");

        /// <summary>
        /// <para>Fills the image with <c>color</c>.</para>
        /// </summary>
        [GodotMethod("fill")]
        public void Fill(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_39, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "fill_rect");

        /// <summary>
        /// <para>Fills <c>rect</c> with <c>color</c>.</para>
        /// </summary>
        [GodotMethod("fill_rect")]
        public void FillRect(Rect2 rect, Color color)
        {
            NativeCalls.godot_icall_2_510(method_bind_40, Object.GetPtr(this), ref rect, ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_used_rect");

        /// <summary>
        /// <para>Returns a <see cref="Godot.Rect2"/> enclosing the visible portion of the image, considering each pixel with a non-zero alpha channel as visible.</para>
        /// </summary>
        [GodotMethod("get_used_rect")]
        public Rect2 GetUsedRect()
        {
            NativeCalls.godot_icall_0_163(method_bind_41, Object.GetPtr(this), out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rect");

        /// <summary>
        /// <para>Returns a new image that is a copy of the image's area specified with <c>rect</c>.</para>
        /// </summary>
        [GodotMethod("get_rect")]
        public Image GetRect(Rect2 rect)
        {
            return NativeCalls.godot_icall_1_511(method_bind_42, Object.GetPtr(this), ref rect);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "copy_from");

        /// <summary>
        /// <para>Copies <c>src</c> image to this image.</para>
        /// </summary>
        [GodotMethod("copy_from")]
        public void CopyFrom(Image src)
        {
            NativeCalls.godot_icall_1_24(method_bind_43, Object.GetPtr(this), Object.GetPtr(src));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_data");

        [Obsolete("_SetData is deprecated. Use the Data property instead.")]
        internal void _SetData(Godot.Collections.Dictionary data)
        {
            NativeCalls.godot_icall_1_213(method_bind_44, Object.GetPtr(this), data.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_data");

        [Obsolete("_GetData is deprecated. Use the Data property instead.")]
        internal Godot.Collections.Dictionary _GetData()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_45, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "lock");

        /// <summary>
        /// <para>Locks the data for reading and writing access. Sends an error to the console if the image is not locked when reading or writing a pixel.</para>
        /// </summary>
        [GodotMethod("lock")]
        public void Lock()
        {
            NativeCalls.godot_icall_0_3(method_bind_46, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "unlock");

        /// <summary>
        /// <para>Unlocks the data and prevents changes.</para>
        /// </summary>
        [GodotMethod("unlock")]
        public void Unlock()
        {
            NativeCalls.godot_icall_0_3(method_bind_47, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pixelv");

        /// <summary>
        /// <para>Returns the color of the pixel at <c>src</c> if the image is locked. If the image is unlocked, it always returns a <see cref="Godot.Color"/> with the value <c>(0, 0, 0, 1.0)</c>. This is the same as <see cref="Godot.Image.GetPixel"/>, but with a Vector2 argument instead of two integer arguments.</para>
        /// </summary>
        [GodotMethod("get_pixelv")]
        public Color GetPixelv(Vector2 src)
        {
            NativeCalls.godot_icall_1_512(method_bind_48, Object.GetPtr(this), ref src, out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pixel");

        /// <summary>
        /// <para>Returns the color of the pixel at <c>(x, y)</c> if the image is locked. If the image is unlocked, it always returns a <see cref="Godot.Color"/> with the value <c>(0, 0, 0, 1.0)</c>. This is the same as <see cref="Godot.Image.GetPixelv"/>, but two integer arguments instead of a Vector2 argument.</para>
        /// </summary>
        [GodotMethod("get_pixel")]
        public Color GetPixel(int x, int y)
        {
            NativeCalls.godot_icall_2_513(method_bind_49, Object.GetPtr(this), x, y, out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pixelv");

        /// <summary>
        /// <para>Sets the <see cref="Godot.Color"/> of the pixel at <c>(dst.x, dst.y)</c> if the image is locked. Note that the <c>dst</c> values must be integers. Example:</para>
        /// <para><code>
        /// var img = Image.new()
        /// img.create(img_width, img_height, false, Image.FORMAT_RGBA8)
        /// img.lock()
        /// img.set_pixelv(Vector2(x, y), color) # Works
        /// img.unlock()
        /// img.set_pixelv(Vector2(x, y), color) # Does not have an effect
        /// </code></para>
        /// </summary>
        [GodotMethod("set_pixelv")]
        public void SetPixelv(Vector2 dst, Color color)
        {
            NativeCalls.godot_icall_2_514(method_bind_50, Object.GetPtr(this), ref dst, ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pixel");

        /// <summary>
        /// <para>Sets the <see cref="Godot.Color"/> of the pixel at <c>(x, y)</c> if the image is locked. Example:</para>
        /// <para><code>
        /// var img = Image.new()
        /// img.create(img_width, img_height, false, Image.FORMAT_RGBA8)
        /// img.lock()
        /// img.set_pixel(x, y, color) # Works
        /// img.unlock()
        /// img.set_pixel(x, y, color) # Does not have an effect
        /// </code></para>
        /// </summary>
        [GodotMethod("set_pixel")]
        public void SetPixel(int x, int y, Color color)
        {
            NativeCalls.godot_icall_3_515(method_bind_51, Object.GetPtr(this), x, y, ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "load_png_from_buffer");

        /// <summary>
        /// <para>Loads an image from the binary contents of a PNG file.</para>
        /// </summary>
        [GodotMethod("load_png_from_buffer")]
        public Error LoadPngFromBuffer(byte[] buffer)
        {
            return (Error)NativeCalls.godot_icall_1_487(method_bind_52, Object.GetPtr(this), buffer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_53 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "load_jpg_from_buffer");

        /// <summary>
        /// <para>Loads an image from the binary contents of a JPEG file.</para>
        /// </summary>
        [GodotMethod("load_jpg_from_buffer")]
        public Error LoadJpgFromBuffer(byte[] buffer)
        {
            return (Error)NativeCalls.godot_icall_1_487(method_bind_53, Object.GetPtr(this), buffer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_54 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "load_webp_from_buffer");

        /// <summary>
        /// <para>Loads an image from the binary contents of a WebP file.</para>
        /// </summary>
        [GodotMethod("load_webp_from_buffer")]
        public Error LoadWebpFromBuffer(byte[] buffer)
        {
            return (Error)NativeCalls.godot_icall_1_487(method_bind_54, Object.GetPtr(this), buffer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_55 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "load_tga_from_buffer");

        /// <summary>
        /// <para>Loads an image from the binary contents of a TGA file.</para>
        /// </summary>
        [GodotMethod("load_tga_from_buffer")]
        public Error LoadTgaFromBuffer(byte[] buffer)
        {
            return (Error)NativeCalls.godot_icall_1_487(method_bind_55, Object.GetPtr(this), buffer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_56 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "load_bmp_from_buffer");

        /// <summary>
        /// <para>Loads an image from the binary contents of a BMP file.</para>
        /// <para>Note: Godot's BMP module doesn't support 16-bit per pixel images. Only 1-bit, 4-bit, 8-bit, 24-bit, and 32-bit per pixel images are supported.</para>
        /// </summary>
        [GodotMethod("load_bmp_from_buffer")]
        public Error LoadBmpFromBuffer(byte[] buffer)
        {
            return (Error)NativeCalls.godot_icall_1_487(method_bind_56, Object.GetPtr(this), buffer);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
