using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.TextureButton"/> has the same functionality as <see cref="Godot.Button"/>, except it uses sprites instead of Godot's <see cref="Godot.Theme"/> resource. It is faster to create, but it doesn't support localization like more complex <see cref="Godot.Control"/>s.</para>
    /// <para>The "normal" state must contain a texture (<see cref="Godot.TextureButton.TextureNormal"/>); other textures are optional.</para>
    /// <para>See also <see cref="Godot.BaseButton"/> which contains common properties and methods associated with this node.</para>
    /// </summary>
    public partial class TextureButton : BaseButton
    {
        public enum StretchModeEnum
        {
            /// <summary>
            /// <para>Scale to fit the node's bounding rectangle.</para>
            /// </summary>
            Scale = 0,
            /// <summary>
            /// <para>Tile inside the node's bounding rectangle.</para>
            /// </summary>
            Tile = 1,
            /// <summary>
            /// <para>The texture keeps its original size and stays in the bounding rectangle's top-left corner.</para>
            /// </summary>
            Keep = 2,
            /// <summary>
            /// <para>The texture keeps its original size and stays centered in the node's bounding rectangle.</para>
            /// </summary>
            KeepCentered = 3,
            /// <summary>
            /// <para>Scale the texture to fit the node's bounding rectangle, but maintain the texture's aspect ratio.</para>
            /// </summary>
            KeepAspect = 4,
            /// <summary>
            /// <para>Scale the texture to fit the node's bounding rectangle, center it, and maintain its aspect ratio.</para>
            /// </summary>
            KeepAspectCentered = 5,
            /// <summary>
            /// <para>Scale the texture so that the shorter side fits the bounding rectangle. The other side clips to the node's limits.</para>
            /// </summary>
            KeepAspectCovered = 6
        }

        /// <summary>
        /// <para>Texture to display by default, when the node is not in the disabled, focused, hover or pressed state.</para>
        /// </summary>
        public Texture TextureNormal
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNormalTexture();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetNormalTexture(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Texture to display on mouse down over the node, if the node has keyboard focus and the player presses the Enter key or if the player presses the <see cref="Godot.BaseButton.Shortcut"/> key.</para>
        /// </summary>
        public Texture TexturePressed
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPressedTexture();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPressedTexture(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Texture to display when the mouse hovers the node.</para>
        /// </summary>
        public Texture TextureHover
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHoverTexture();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHoverTexture(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Texture to display when the node is disabled. See <see cref="Godot.BaseButton.Disabled"/>.</para>
        /// </summary>
        public Texture TextureDisabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDisabledTexture();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDisabledTexture(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Texture to display when the node has mouse or keyboard focus.</para>
        /// </summary>
        public Texture TextureFocused
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFocusedTexture();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFocusedTexture(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Pure black and white <see cref="Godot.BitMap"/> image to use for click detection. On the mask, white pixels represent the button's clickable area. Use it to create buttons with curved shapes.</para>
        /// </summary>
        public BitMap TextureClickMask
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetClickMask();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetClickMask(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the texture stretches to the edges of the node's bounding rectangle using the <see cref="Godot.TextureButton.StretchMode"/>. If <c>false</c>, the texture will not scale with the node.</para>
        /// </summary>
        public bool Expand
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetExpand();
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
        /// <para>Controls the texture's behavior when you resize the node's bounding rectangle, only if <see cref="Godot.TextureButton.Expand"/> is <c>true</c>. Set it to one of the <see cref="Godot.TextureButton.StretchModeEnum"/> constants. See the constants to learn more.</para>
        /// </summary>
        public TextureButton.StretchModeEnum StretchMode
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

        private const string nativeName = "TextureButton";

        public TextureButton() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_TextureButton_Ctor(this);
        }

        internal TextureButton(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_normal_texture");

        [GodotMethod("set_normal_texture")]
        [Obsolete("SetNormalTexture is deprecated. Use the TextureNormal property instead.")]
        public void SetNormalTexture(Texture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pressed_texture");

        [GodotMethod("set_pressed_texture")]
        [Obsolete("SetPressedTexture is deprecated. Use the TexturePressed property instead.")]
        public void SetPressedTexture(Texture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_1, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_hover_texture");

        [GodotMethod("set_hover_texture")]
        [Obsolete("SetHoverTexture is deprecated. Use the TextureHover property instead.")]
        public void SetHoverTexture(Texture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_2, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_disabled_texture");

        [GodotMethod("set_disabled_texture")]
        [Obsolete("SetDisabledTexture is deprecated. Use the TextureDisabled property instead.")]
        public void SetDisabledTexture(Texture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_3, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_focused_texture");

        [GodotMethod("set_focused_texture")]
        [Obsolete("SetFocusedTexture is deprecated. Use the TextureFocused property instead.")]
        public void SetFocusedTexture(Texture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_4, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_click_mask");

        [GodotMethod("set_click_mask")]
        [Obsolete("SetClickMask is deprecated. Use the TextureClickMask property instead.")]
        public void SetClickMask(BitMap mask)
        {
            NativeCalls.godot_icall_1_24(method_bind_5, Object.GetPtr(this), Object.GetPtr(mask));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_expand");

        [GodotMethod("set_expand")]
        [Obsolete("SetExpand is deprecated. Use the Expand property instead.")]
        public void SetExpand(bool pExpand)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), pExpand);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_stretch_mode");

        [GodotMethod("set_stretch_mode")]
        [Obsolete("SetStretchMode is deprecated. Use the StretchMode property instead.")]
        public void SetStretchMode(TextureButton.StretchModeEnum pMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_7, Object.GetPtr(this), (int)pMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flip_h");

        [GodotMethod("set_flip_h")]
        [Obsolete("SetFlipH is deprecated. Use the FlipH property instead.")]
        public void SetFlipH(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_8, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_flipped_h");

        [GodotMethod("is_flipped_h")]
        [Obsolete("IsFlippedH is deprecated. Use the FlipH property instead.")]
        public bool IsFlippedH()
        {
            return NativeCalls.godot_icall_0_7(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flip_v");

        [GodotMethod("set_flip_v")]
        [Obsolete("SetFlipV is deprecated. Use the FlipV property instead.")]
        public void SetFlipV(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_flipped_v");

        [GodotMethod("is_flipped_v")]
        [Obsolete("IsFlippedV is deprecated. Use the FlipV property instead.")]
        public bool IsFlippedV()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_normal_texture");

        [GodotMethod("get_normal_texture")]
        [Obsolete("GetNormalTexture is deprecated. Use the TextureNormal property instead.")]
        public Texture GetNormalTexture()
        {
            return NativeCalls.godot_icall_0_161(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pressed_texture");

        [GodotMethod("get_pressed_texture")]
        [Obsolete("GetPressedTexture is deprecated. Use the TexturePressed property instead.")]
        public Texture GetPressedTexture()
        {
            return NativeCalls.godot_icall_0_161(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_hover_texture");

        [GodotMethod("get_hover_texture")]
        [Obsolete("GetHoverTexture is deprecated. Use the TextureHover property instead.")]
        public Texture GetHoverTexture()
        {
            return NativeCalls.godot_icall_0_161(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_disabled_texture");

        [GodotMethod("get_disabled_texture")]
        [Obsolete("GetDisabledTexture is deprecated. Use the TextureDisabled property instead.")]
        public Texture GetDisabledTexture()
        {
            return NativeCalls.godot_icall_0_161(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_focused_texture");

        [GodotMethod("get_focused_texture")]
        [Obsolete("GetFocusedTexture is deprecated. Use the TextureFocused property instead.")]
        public Texture GetFocusedTexture()
        {
            return NativeCalls.godot_icall_0_161(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_click_mask");

        [GodotMethod("get_click_mask")]
        [Obsolete("GetClickMask is deprecated. Use the TextureClickMask property instead.")]
        public BitMap GetClickMask()
        {
            return NativeCalls.godot_icall_0_928(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_expand");

        [GodotMethod("get_expand")]
        [Obsolete("GetExpand is deprecated. Use the Expand property instead.")]
        public bool GetExpand()
        {
            return NativeCalls.godot_icall_0_7(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stretch_mode");

        [GodotMethod("get_stretch_mode")]
        [Obsolete("GetStretchMode is deprecated. Use the StretchMode property instead.")]
        public TextureButton.StretchModeEnum GetStretchMode()
        {
            return (TextureButton.StretchModeEnum)NativeCalls.godot_icall_0_929(method_bind_19, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
