using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A <see cref="Godot.Texture"/> based on an <see cref="Godot.Image"/>. For an image to be displayed, an <see cref="Godot.ImageTexture"/> has to be created from it using the <see cref="Godot.ImageTexture.CreateFromImage"/> method:</para>
    /// <para><code>
    /// var texture = ImageTexture.new()
    /// var image = Image.new()
    /// image.load("res://icon.png")
    /// texture.create_from_image(image)
    /// $Sprite.texture = texture
    /// </code></para>
    /// <para>This way, textures can be created at run-time by loading images both from within the editor and externally.</para>
    /// <para>Warning: Prefer to load imported textures with <c>@GDScript.load</c> over loading them from within the filesystem dynamically with <see cref="Godot.Image.Load"/>, as it may not work in exported projects:</para>
    /// <para><code>
    /// var texture = load("res://icon.png")
    /// $Sprite.texture = texture
    /// </code></para>
    /// <para>This is because images have to be imported as <see cref="Godot.StreamTexture"/> first to be loaded with <c>@GDScript.load</c>. If you'd still like to load an image file just like any other <see cref="Godot.Resource"/>, import it as an <see cref="Godot.Image"/> resource instead, and then load it normally using the <c>@GDScript.load</c> method.</para>
    /// <para>But do note that the image data can still be retrieved from an imported texture as well using the <see cref="Godot.Texture.GetData"/> method, which returns a copy of the data:</para>
    /// <para><code>
    /// var texture = load("res://icon.png")
    /// var image : Image = texture.get_data()
    /// </code></para>
    /// <para>An <see cref="Godot.ImageTexture"/> is not meant to be operated from within the editor interface directly, and is mostly useful for rendering images on screen dynamically via code. If you need to generate images procedurally from within the editor, consider saving and importing images as custom texture resources implementing a new <see cref="Godot.EditorImportPlugin"/>.</para>
    /// <para>Note: The maximum texture size is 16384×16384 pixels due to graphics hardware limitations.</para>
    /// </summary>
    public partial class ImageTexture : Texture
    {
        public enum StorageEnum
        {
            /// <summary>
            /// <para><see cref="Godot.Image"/> data is stored raw and unaltered.</para>
            /// </summary>
            Raw = 0,
            /// <summary>
            /// <para><see cref="Godot.Image"/> data is compressed with a lossy algorithm. You can set the storage quality with <see cref="Godot.ImageTexture.LossyQuality"/>.</para>
            /// </summary>
            CompressLossy = 1,
            /// <summary>
            /// <para><see cref="Godot.Image"/> data is compressed with a lossless algorithm.</para>
            /// </summary>
            CompressLossless = 2
        }

        /// <summary>
        /// <para>The storage type (raw, lossy, or compressed).</para>
        /// </summary>
        public ImageTexture.StorageEnum Storage
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetStorage();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetStorage(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The storage quality for <see cref="Godot.ImageTexture.StorageEnum.CompressLossy"/>.</para>
        /// </summary>
        public float LossyQuality
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLossyStorageQuality();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLossyStorageQuality(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ImageTexture";

        public ImageTexture() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ImageTexture_Ctor(this);
        }

        internal ImageTexture(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create");

        /// <summary>
        /// <para>Create a new <see cref="Godot.ImageTexture"/> with <c>width</c> and <c>height</c>.</para>
        /// <para><c>format</c> is a value from <see cref="Godot.Image.Format"/>, <c>flags</c> is any combination of <see cref="Godot.Texture.FlagsEnum"/>.</para>
        /// </summary>
        [GodotMethod("create")]
        public void Create(int width, int height, Image.Format format, uint flags = (uint)7)
        {
            NativeCalls.godot_icall_4_516(method_bind_0, Object.GetPtr(this), width, height, (int)format, flags);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_from_image");

        /// <summary>
        /// <para>Initializes the texture by allocating and setting the data from an <see cref="Godot.Image"/> with <c>flags</c> from <see cref="Godot.Texture.FlagsEnum"/>. An sRGB to linear color space conversion can take place, according to <see cref="Godot.Image.Format"/>.</para>
        /// </summary>
        [GodotMethod("create_from_image")]
        public void CreateFromImage(Image image, uint flags = (uint)7)
        {
            NativeCalls.godot_icall_2_517(method_bind_1, Object.GetPtr(this), Object.GetPtr(image), flags);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_format");

        /// <summary>
        /// <para>Returns the format of the texture, one of <see cref="Godot.Image.Format"/>.</para>
        /// </summary>
        [GodotMethod("get_format")]
        public Image.Format GetFormat()
        {
            return (Image.Format)NativeCalls.godot_icall_0_501(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "load");

        /// <summary>
        /// <para>Loads an image from a file path and creates a texture from it.</para>
        /// <para>Note: This method is deprecated and will be removed in Godot 4.0, use <see cref="Godot.Image.Load"/> and <see cref="Godot.ImageTexture.CreateFromImage"/> instead.</para>
        /// </summary>
        [GodotMethod("load")]
        public Error Load(string path)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_3, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_data");

        /// <summary>
        /// <para>Replaces the texture's data with a new <see cref="Godot.Image"/>.</para>
        /// <para>Note: The texture has to be initialized first with the <see cref="Godot.ImageTexture.CreateFromImage"/> method before it can be updated. The new image dimensions, format, and mipmaps configuration should match the existing texture's image configuration, otherwise it has to be re-created with the <see cref="Godot.ImageTexture.CreateFromImage"/> method.</para>
        /// <para>Use this method over <see cref="Godot.ImageTexture.CreateFromImage"/> if you need to update the texture frequently, which is faster than allocating additional memory for a new texture each time.</para>
        /// </summary>
        [GodotMethod("set_data")]
        public void SetData(Image image)
        {
            NativeCalls.godot_icall_1_24(method_bind_4, Object.GetPtr(this), Object.GetPtr(image));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_storage");

        [GodotMethod("set_storage")]
        [Obsolete("SetStorage is deprecated. Use the Storage property instead.")]
        public void SetStorage(ImageTexture.StorageEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_5, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_storage");

        [GodotMethod("get_storage")]
        [Obsolete("GetStorage is deprecated. Use the Storage property instead.")]
        public ImageTexture.StorageEnum GetStorage()
        {
            return (ImageTexture.StorageEnum)NativeCalls.godot_icall_0_518(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_lossy_storage_quality");

        [GodotMethod("set_lossy_storage_quality")]
        [Obsolete("SetLossyStorageQuality is deprecated. Use the LossyQuality property instead.")]
        public void SetLossyStorageQuality(float quality)
        {
            NativeCalls.godot_icall_1_15(method_bind_7, Object.GetPtr(this), quality);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_lossy_storage_quality");

        [GodotMethod("get_lossy_storage_quality")]
        [Obsolete("GetLossyStorageQuality is deprecated. Use the LossyQuality property instead.")]
        public float GetLossyStorageQuality()
        {
            return NativeCalls.godot_icall_0_14(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_size_override");

        /// <summary>
        /// <para>Resizes the texture to the specified dimensions.</para>
        /// </summary>
        [GodotMethod("set_size_override")]
        public void SetSizeOverride(Vector2 size)
        {
            NativeCalls.godot_icall_1_57(method_bind_9, Object.GetPtr(this), ref size);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
