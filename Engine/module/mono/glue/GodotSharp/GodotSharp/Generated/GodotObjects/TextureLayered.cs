using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Base class for <see cref="Godot.Texture3D"/> and <see cref="Godot.TextureArray"/>. Cannot be used directly, but contains all the functions necessary for accessing and using <see cref="Godot.Texture3D"/> and <see cref="Godot.TextureArray"/>. Data is set on a per-layer basis. For <see cref="Godot.Texture3D"/>s, the layer specifies the depth or Z-index, they can be treated as a bunch of 2D slices. Similarly, for <see cref="Godot.TextureArray"/>s, the layer specifies the array layer.</para>
    /// </summary>
    public abstract partial class TextureLayered : Resource
    {
        public enum FlagsEnum
        {
            /// <summary>
            /// <para>Default flags for <see cref="Godot.TextureArray"/>. <see cref="Godot.TextureLayered.FlagsEnum.FlagMipmaps"/>, <see cref="Godot.TextureLayered.FlagsEnum.FlagRepeat"/> and <see cref="Godot.TextureLayered.FlagsEnum.FlagFilter"/> are enabled.</para>
            /// </summary>
            FlagsDefaultTextureArray = 7,
            /// <summary>
            /// <para>Default flags for <see cref="Godot.Texture3D"/>. <see cref="Godot.TextureLayered.FlagsEnum.FlagFilter"/> is enabled.</para>
            /// </summary>
            FlagsDefaultTexture3d = 4,
            /// <summary>
            /// <para>Texture will generate mipmaps on creation.</para>
            /// </summary>
            FlagMipmaps = 1,
            /// <summary>
            /// <para>Texture will repeat when UV used is outside the 0-1 range.</para>
            /// </summary>
            FlagRepeat = 2,
            /// <summary>
            /// <para>Use filtering when reading from texture. Filtering smooths out pixels. Turning filtering off is slightly faster and more appropriate when you need access to individual pixels.</para>
            /// </summary>
            FlagFilter = 4,
            /// <summary>
            /// <para>Uses anisotropic mipmap filtering. Generates smaller versions of the same texture with different aspect ratios.</para>
            /// <para>This results in better-looking textures when viewed from oblique angles.</para>
            /// </summary>
            FlagAnisotropicFilter = 8
        }

        /// <summary>
        /// <para>Specifies which <see cref="Godot.TextureLayered.FlagsEnum"/> apply to this texture.</para>
        /// </summary>
        public uint Flags
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlags();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlags(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Returns a dictionary with all the data used by this texture.</para>
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

        private const string nativeName = "TextureLayered";

        internal TextureLayered() {}

        internal TextureLayered(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flags");

        [GodotMethod("set_flags")]
        [Obsolete("SetFlags is deprecated. Use the Flags property instead.")]
        public void SetFlags(uint flags)
        {
            NativeCalls.godot_icall_1_187(method_bind_0, Object.GetPtr(this), flags);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_flags");

        [GodotMethod("get_flags")]
        [Obsolete("GetFlags is deprecated. Use the Flags property instead.")]
        public uint GetFlags()
        {
            return NativeCalls.godot_icall_0_188(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_format");

        /// <summary>
        /// <para>Returns the current format being used by this texture. See <see cref="Godot.Image.Format"/> for details.</para>
        /// </summary>
        [GodotMethod("get_format")]
        public Image.Format GetFormat()
        {
            return (Image.Format)NativeCalls.godot_icall_0_501(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_width");

        /// <summary>
        /// <para>Returns the width of the texture. Width is typically represented by the X-axis.</para>
        /// </summary>
        [GodotMethod("get_width")]
        public uint GetWidth()
        {
            return NativeCalls.godot_icall_0_188(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_height");

        /// <summary>
        /// <para>Returns the height of the texture. Height is typically represented by the Y-axis.</para>
        /// </summary>
        [GodotMethod("get_height")]
        public uint GetHeight()
        {
            return NativeCalls.godot_icall_0_188(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_depth");

        /// <summary>
        /// <para>Returns the depth of the texture. Depth is the 3rd dimension (typically Z-axis).</para>
        /// </summary>
        [GodotMethod("get_depth")]
        public uint GetDepth()
        {
            return NativeCalls.godot_icall_0_188(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_layer_data");

        /// <summary>
        /// <para>Sets the data for the specified layer. Data takes the form of a 2-dimensional <see cref="Godot.Image"/> resource.</para>
        /// </summary>
        [GodotMethod("set_layer_data")]
        public void SetLayerData(Image image, int layer)
        {
            NativeCalls.godot_icall_2_906(method_bind_6, Object.GetPtr(this), Object.GetPtr(image), layer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_layer_data");

        /// <summary>
        /// <para>Returns an <see cref="Godot.Image"/> resource with the data from specified <c>layer</c>.</para>
        /// </summary>
        [GodotMethod("get_layer_data")]
        public Image GetLayerData(int layer)
        {
            return NativeCalls.godot_icall_1_339(method_bind_7, Object.GetPtr(this), layer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_data_partial");

        /// <summary>
        /// <para>Partially sets the data for a specified <c>layer</c> by overwriting using the data of the specified <c>image</c>. <c>x_offset</c> and <c>y_offset</c> determine where the <see cref="Godot.Image"/> is "stamped" over the texture. The <c>image</c> must fit within the texture.</para>
        /// </summary>
        [GodotMethod("set_data_partial")]
        public void SetDataPartial(Image image, int xOffset, int yOffset, int layer, int mipmap = 0)
        {
            NativeCalls.godot_icall_5_930(method_bind_8, Object.GetPtr(this), Object.GetPtr(image), xOffset, yOffset, layer, mipmap);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_data");

        [Obsolete("_SetData is deprecated. Use the Data property instead.")]
        internal void _SetData(Godot.Collections.Dictionary data)
        {
            NativeCalls.godot_icall_1_213(method_bind_9, Object.GetPtr(this), data.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_data");

        [Obsolete("_GetData is deprecated. Use the Data property instead.")]
        internal Godot.Collections.Dictionary _GetData()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_10, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
