using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A texture works by registering an image in the video hardware, which then can be used in 3D models or 2D <see cref="Godot.Sprite"/> or GUI <see cref="Godot.Control"/>.</para>
    /// <para>Textures are often created by loading them from a file. See <c>@GDScript.load</c>.</para>
    /// <para><see cref="Godot.Texture"/> is a base for other resources. It cannot be used directly.</para>
    /// <para>Note: The maximum texture size is 16384×16384 pixels due to graphics hardware limitations. Larger textures may fail to import.</para>
    /// </summary>
    public abstract partial class Texture : Resource
    {
        public enum FlagsEnum
        {
            /// <summary>
            /// <para>Default flags. <see cref="Godot.Texture.FlagsEnum.Mipmaps"/>, <see cref="Godot.Texture.FlagsEnum.Repeat"/> and <see cref="Godot.Texture.FlagsEnum.Filter"/> are enabled.</para>
            /// </summary>
            Default = 7,
            /// <summary>
            /// <para>Generates mipmaps, which are smaller versions of the same texture to use when zoomed out, keeping the aspect ratio.</para>
            /// </summary>
            Mipmaps = 1,
            /// <summary>
            /// <para>Repeats the texture (instead of clamp to edge).</para>
            /// <para>Note: Ignored when using an <see cref="Godot.AtlasTexture"/> as these don't support repetition.</para>
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
            /// <para>Note: Ignored when using an <see cref="Godot.AtlasTexture"/> as these don't support repetition.</para>
            /// </summary>
            MirroredRepeat = 32,
            /// <summary>
            /// <para>Texture is a video surface.</para>
            /// </summary>
            VideoSurface = 2048
        }

        /// <summary>
        /// <para>The texture's <see cref="Godot.Texture.FlagsEnum"/>. <see cref="Godot.Texture.FlagsEnum"/> are used to set various properties of the <see cref="Godot.Texture"/>.</para>
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

        private const string nativeName = "Texture";

        internal Texture() {}

        internal Texture(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_width");

        /// <summary>
        /// <para>Returns the texture width.</para>
        /// </summary>
        [GodotMethod("get_width")]
        public int GetWidth()
        {
            return NativeCalls.godot_icall_0_5(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_height");

        /// <summary>
        /// <para>Returns the texture height.</para>
        /// </summary>
        [GodotMethod("get_height")]
        public int GetHeight()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_size");

        /// <summary>
        /// <para>Returns the texture size.</para>
        /// </summary>
        [GodotMethod("get_size")]
        public Vector2 GetSize()
        {
            NativeCalls.godot_icall_0_18(method_bind_2, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_alpha");

        /// <summary>
        /// <para>Returns <c>true</c> if this <see cref="Godot.Texture"/> has an alpha channel.</para>
        /// </summary>
        [GodotMethod("has_alpha")]
        public bool HasAlpha()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flags");

        [GodotMethod("set_flags")]
        [Obsolete("SetFlags is deprecated. Use the Flags property instead.")]
        public void SetFlags(uint flags)
        {
            NativeCalls.godot_icall_1_187(method_bind_4, Object.GetPtr(this), flags);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_flags");

        [GodotMethod("get_flags")]
        [Obsolete("GetFlags is deprecated. Use the Flags property instead.")]
        public uint GetFlags()
        {
            return NativeCalls.godot_icall_0_188(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw");

        /// <summary>
        /// <para>Draws the texture using a <see cref="Godot.CanvasItem"/> with the <see cref="Godot.VisualServer"/> API at the specified <c>position</c>. Equivalent to <see cref="Godot.VisualServer.CanvasItemAddTextureRect"/> with a rect at <c>position</c> and the size of this <see cref="Godot.Texture"/>.</para>
        /// </summary>
        /// <param name="modulate">If the parameter is null, then the default value is new Color(1, 1, 1, 1)</param>
        [GodotMethod("draw")]
        public void Draw(RID canvasItem, Vector2 position, Nullable<Color> modulate = null, bool transpose = false, Texture normalMap = null)
        {
            Color modulate_in = modulate.HasValue ? modulate.Value : new Color(1, 1, 1, 1);
            NativeCalls.godot_icall_5_924(method_bind_6, Object.GetPtr(this), RID.GetPtr(canvasItem), ref position, ref modulate_in, transpose, Object.GetPtr(normalMap));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_rect");

        /// <summary>
        /// <para>Draws the texture using a <see cref="Godot.CanvasItem"/> with the <see cref="Godot.VisualServer"/> API. Equivalent to <see cref="Godot.VisualServer.CanvasItemAddTextureRect"/>.</para>
        /// </summary>
        /// <param name="modulate">If the parameter is null, then the default value is new Color(1, 1, 1, 1)</param>
        [GodotMethod("draw_rect")]
        public void DrawRect(RID canvasItem, Rect2 rect, bool tile, Nullable<Color> modulate = null, bool transpose = false, Texture normalMap = null)
        {
            Color modulate_in = modulate.HasValue ? modulate.Value : new Color(1, 1, 1, 1);
            NativeCalls.godot_icall_6_925(method_bind_7, Object.GetPtr(this), RID.GetPtr(canvasItem), ref rect, tile, ref modulate_in, transpose, Object.GetPtr(normalMap));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_rect_region");

        /// <summary>
        /// <para>Draws a part of the texture using a <see cref="Godot.CanvasItem"/> with the <see cref="Godot.VisualServer"/> API. Equivalent to <see cref="Godot.VisualServer.CanvasItemAddTextureRectRegion"/>.</para>
        /// </summary>
        /// <param name="modulate">If the parameter is null, then the default value is new Color(1, 1, 1, 1)</param>
        [GodotMethod("draw_rect_region")]
        public void DrawRectRegion(RID canvasItem, Rect2 rect, Rect2 srcRect, Nullable<Color> modulate = null, bool transpose = false, Texture normalMap = null, bool clipUv = true)
        {
            Color modulate_in = modulate.HasValue ? modulate.Value : new Color(1, 1, 1, 1);
            NativeCalls.godot_icall_7_926(method_bind_8, Object.GetPtr(this), RID.GetPtr(canvasItem), ref rect, ref srcRect, ref modulate_in, transpose, Object.GetPtr(normalMap), clipUv);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_data");

        /// <summary>
        /// <para>Returns an <see cref="Godot.Image"/> that is a copy of data from this <see cref="Godot.Texture"/>. <see cref="Godot.Image"/>s can be accessed and manipulated directly.</para>
        /// </summary>
        [GodotMethod("get_data")]
        public Image GetData()
        {
            return NativeCalls.godot_icall_0_216(method_bind_9, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
