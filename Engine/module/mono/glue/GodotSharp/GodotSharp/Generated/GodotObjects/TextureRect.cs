using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Used to draw icons and sprites in a user interface. The texture's placement can be controlled with the <see cref="Godot.TextureRect.StretchMode"/> property. It can scale, tile, or stay centered inside its bounding rectangle.</para>
    /// <para>Note: You should enable <see cref="Godot.TextureRect.FlipV"/> when using a TextureRect to display a <see cref="Godot.ViewportTexture"/>. Alternatively, you can enable <see cref="Godot.Viewport.RenderTargetVFlip"/> on the Viewport. Otherwise, the image will appear upside down.</para>
    /// </summary>
    public partial class TextureRect : Control
    {
        public enum StretchModeEnum
        {
            /// <summary>
            /// <para>Scale to fit the node's bounding rectangle, only if <c>expand</c> is <c>true</c>. Default <c>stretch_mode</c>, for backwards compatibility. Until you set <c>expand</c> to <c>true</c>, the texture will behave like <see cref="Godot.TextureRect.StretchModeEnum.Keep"/>.</para>
            /// </summary>
            ScaleOnExpand = 0,
            /// <summary>
            /// <para>Scale to fit the node's bounding rectangle.</para>
            /// </summary>
            Scale = 1,
            /// <summary>
            /// <para>Tile inside the node's bounding rectangle.</para>
            /// </summary>
            Tile = 2,
            /// <summary>
            /// <para>The texture keeps its original size and stays in the bounding rectangle's top-left corner.</para>
            /// </summary>
            Keep = 3,
            /// <summary>
            /// <para>The texture keeps its original size and stays centered in the node's bounding rectangle.</para>
            /// </summary>
            KeepCentered = 4,
            /// <summary>
            /// <para>Scale the texture to fit the node's bounding rectangle, but maintain the texture's aspect ratio.</para>
            /// </summary>
            KeepAspect = 5,
            /// <summary>
            /// <para>Scale the texture to fit the node's bounding rectangle, center it and maintain its aspect ratio.</para>
            /// </summary>
            KeepAspectCentered = 6,
            /// <summary>
            /// <para>Scale the texture so that the shorter side fits the bounding rectangle. The other side clips to the node's limits.</para>
            /// </summary>
            KeepAspectCovered = 7
        }

        /// <summary>
        /// <para>The node's <see cref="Godot.Texture"/> resource.</para>
        /// </summary>
        public Texture Texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexture();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexture(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the texture scales to fit its bounding rectangle.</para>
        /// </summary>
        public bool Expand
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return HasExpand();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExpand(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Controls the texture's behavior when resizing the node's bounding rectangle. See <see cref="Godot.TextureRect.StretchModeEnum"/>.</para>
        /// </summary>
        public TextureRect.StretchModeEnum StretchMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetStretchMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetStretchMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, texture is flipped horizontally.</para>
        /// </summary>
        public bool FlipH
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsFlippedH();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlipH(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, texture is flipped vertically.</para>
        /// </summary>
        public bool FlipV
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsFlippedV();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlipV(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "TextureRect";

        public TextureRect() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_TextureRect_Ctor(this);
        }

        internal TextureRect(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture");

        [GodotMethod("set_texture")]
        [Obsolete("SetTexture is deprecated. Use the Texture property instead.")]
        public void SetTexture(Texture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture");

        [GodotMethod("get_texture")]
        [Obsolete("GetTexture is deprecated. Use the Texture property instead.")]
        public Texture GetTexture()
        {
            return NativeCalls.godot_icall_0_161(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_expand");

        [GodotMethod("set_expand")]
        [Obsolete("SetExpand is deprecated. Use the Expand property instead.")]
        public void SetExpand(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_expand");

        [GodotMethod("has_expand")]
        [Obsolete("HasExpand is deprecated. Use the Expand property instead.")]
        public bool HasExpand()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flip_h");

        [GodotMethod("set_flip_h")]
        [Obsolete("SetFlipH is deprecated. Use the FlipH property instead.")]
        public void SetFlipH(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_flipped_h");

        [GodotMethod("is_flipped_h")]
        [Obsolete("IsFlippedH is deprecated. Use the FlipH property instead.")]
        public bool IsFlippedH()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flip_v");

        [GodotMethod("set_flip_v")]
        [Obsolete("SetFlipV is deprecated. Use the FlipV property instead.")]
        public void SetFlipV(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_flipped_v");

        [GodotMethod("is_flipped_v")]
        [Obsolete("IsFlippedV is deprecated. Use the FlipV property instead.")]
        public bool IsFlippedV()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_stretch_mode");

        [GodotMethod("set_stretch_mode")]
        [Obsolete("SetStretchMode is deprecated. Use the StretchMode property instead.")]
        public void SetStretchMode(TextureRect.StretchModeEnum stretchMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_8, Object.GetPtr(this), (int)stretchMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stretch_mode");

        [GodotMethod("get_stretch_mode")]
        [Obsolete("GetStretchMode is deprecated. Use the StretchMode property instead.")]
        public TextureRect.StretchModeEnum GetStretchMode()
        {
            return (TextureRect.StretchModeEnum)NativeCalls.godot_icall_0_931(method_bind_9, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
