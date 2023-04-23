using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Casts light in a 2D environment. Light is defined by a (usually grayscale) texture, a color, an energy value, a mode (see constants), and various other parameters (range and shadows-related).</para>
    /// <para>Note: Light2D can also be used as a mask.</para>
    /// </summary>
    public partial class Light2D : Node2D
    {
        public enum ShadowFilterEnum
        {
            /// <summary>
            /// <para>No filter applies to the shadow map. See <see cref="Godot.Light2D.ShadowFilter"/>.</para>
            /// </summary>
            None = 0,
            /// <summary>
            /// <para>Percentage closer filtering (3 samples) applies to the shadow map. See <see cref="Godot.Light2D.ShadowFilter"/>.</para>
            /// </summary>
            Pcf3 = 1,
            /// <summary>
            /// <para>Percentage closer filtering (5 samples) applies to the shadow map. See <see cref="Godot.Light2D.ShadowFilter"/>.</para>
            /// </summary>
            Pcf5 = 2,
            /// <summary>
            /// <para>Percentage closer filtering (7 samples) applies to the shadow map. See <see cref="Godot.Light2D.ShadowFilter"/>.</para>
            /// </summary>
            Pcf7 = 3,
            /// <summary>
            /// <para>Percentage closer filtering (9 samples) applies to the shadow map. See <see cref="Godot.Light2D.ShadowFilter"/>.</para>
            /// </summary>
            Pcf9 = 4,
            /// <summary>
            /// <para>Percentage closer filtering (13 samples) applies to the shadow map. See <see cref="Godot.Light2D.ShadowFilter"/>.</para>
            /// </summary>
            Pcf13 = 5
        }

        public enum ModeEnum
        {
            /// <summary>
            /// <para>Adds the value of pixels corresponding to the Light2D to the values of pixels under it. This is the common behavior of a light.</para>
            /// </summary>
            Add = 0,
            /// <summary>
            /// <para>Subtracts the value of pixels corresponding to the Light2D to the values of pixels under it, resulting in inversed light effect.</para>
            /// </summary>
            Sub = 1,
            /// <summary>
            /// <para>Mix the value of pixels corresponding to the Light2D to the values of pixels under it by linear interpolation.</para>
            /// </summary>
            Mix = 2,
            /// <summary>
            /// <para>The light texture of the Light2D is used as a mask, hiding or revealing parts of the screen underneath depending on the value of each pixel of the light (mask) texture.</para>
            /// </summary>
            Mask = 3
        }

        /// <summary>
        /// <para>If <c>true</c>, Light2D will emit light.</para>
        /// </summary>
        public bool Enabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, Light2D will only appear when editing the scene.</para>
        /// </summary>
        public bool EditorOnly
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsEditorOnly();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEditorOnly(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para><see cref="Godot.Texture"/> used for the Light2D's appearance.</para>
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
        /// <para>The offset of the Light2D's <c>texture</c>.</para>
        /// </summary>
        public Vector2 Offset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTextureOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTextureOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The <c>texture</c>'s scale factor.</para>
        /// </summary>
        public float TextureScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTextureScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTextureScale(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The Light2D's <see cref="Godot.Color"/>.</para>
        /// </summary>
        public Color Color
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The Light2D's energy value. The larger the value, the stronger the light.</para>
        /// </summary>
        public float Energy
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEnergy();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnergy(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The Light2D's mode. See <see cref="Godot.Light2D.ModeEnum"/> constants for values.</para>
        /// </summary>
        public Light2D.ModeEnum Mode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The height of the Light2D. Used with 2D normal mapping.</para>
        /// </summary>
        public float RangeHeight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHeight();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHeight(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Minimum <c>z</c> value of objects that are affected by the Light2D.</para>
        /// </summary>
        public int RangeZMin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetZRangeMin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetZRangeMin(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Maximum <c>z</c> value of objects that are affected by the Light2D.</para>
        /// </summary>
        public int RangeZMax
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetZRangeMax();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetZRangeMax(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Minimum layer value of objects that are affected by the Light2D.</para>
        /// </summary>
        public int RangeLayerMin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLayerRangeMin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLayerRangeMin(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Maximum layer value of objects that are affected by the Light2D.</para>
        /// </summary>
        public int RangeLayerMax
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLayerRangeMax();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLayerRangeMax(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The layer mask. Only objects with a matching mask will be affected by the Light2D.</para>
        /// </summary>
        public int RangeItemCullMask
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetItemCullMask();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetItemCullMask(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the Light2D will cast shadows.</para>
        /// </summary>
        public bool ShadowEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsShadowEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShadowEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para><see cref="Godot.Color"/> of shadows cast by the Light2D.</para>
        /// </summary>
        public Color ShadowColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShadowColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShadowColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Shadow buffer size.</para>
        /// </summary>
        public int ShadowBufferSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShadowBufferSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShadowBufferSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Smooth shadow gradient length.</para>
        /// </summary>
        public float ShadowGradientLength
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShadowGradientLength();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShadowGradientLength(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Shadow filter type. See <see cref="Godot.Light2D.ShadowFilterEnum"/> for possible values.</para>
        /// </summary>
        public Light2D.ShadowFilterEnum ShadowFilter
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShadowFilter();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShadowFilter(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Smoothing value for shadows.</para>
        /// </summary>
        public float ShadowFilterSmooth
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShadowSmooth();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShadowSmooth(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The shadow mask. Used with <see cref="Godot.LightOccluder2D"/> to cast shadows. Only occluders with a matching light mask will cast shadows.</para>
        /// </summary>
        public int ShadowItemCullMask
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetItemShadowCullMask();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetItemShadowCullMask(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Light2D";

        public Light2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Light2D_Ctor(this);
        }

        internal Light2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_enabled");

        [GodotMethod("set_enabled")]
        [Obsolete("SetEnabled is deprecated. Use the Enabled property instead.")]
        public void SetEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_enabled");

        [GodotMethod("is_enabled")]
        [Obsolete("IsEnabled is deprecated. Use the Enabled property instead.")]
        public bool IsEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_editor_only");

        [GodotMethod("set_editor_only")]
        [Obsolete("SetEditorOnly is deprecated. Use the EditorOnly property instead.")]
        public void SetEditorOnly(bool editorOnly)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), editorOnly);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_editor_only");

        [GodotMethod("is_editor_only")]
        [Obsolete("IsEditorOnly is deprecated. Use the EditorOnly property instead.")]
        public bool IsEditorOnly()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture");

        [GodotMethod("set_texture")]
        [Obsolete("SetTexture is deprecated. Use the Texture property instead.")]
        public void SetTexture(Texture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_4, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture");

        [GodotMethod("get_texture")]
        [Obsolete("GetTexture is deprecated. Use the Texture property instead.")]
        public Texture GetTexture()
        {
            return NativeCalls.godot_icall_0_161(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture_offset");

        [GodotMethod("set_texture_offset")]
        [Obsolete("SetTextureOffset is deprecated. Use the Offset property instead.")]
        public void SetTextureOffset(Vector2 textureOffset)
        {
            NativeCalls.godot_icall_1_57(method_bind_6, Object.GetPtr(this), ref textureOffset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture_offset");

        [GodotMethod("get_texture_offset")]
        [Obsolete("GetTextureOffset is deprecated. Use the Offset property instead.")]
        public Vector2 GetTextureOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_7, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_color");

        [GodotMethod("set_color")]
        [Obsolete("SetColor is deprecated. Use the Color property instead.")]
        public void SetColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_8, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_color");

        [GodotMethod("get_color")]
        [Obsolete("GetColor is deprecated. Use the Color property instead.")]
        public Color GetColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_9, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_height");

        [GodotMethod("set_height")]
        [Obsolete("SetHeight is deprecated. Use the RangeHeight property instead.")]
        public void SetHeight(float height)
        {
            NativeCalls.godot_icall_1_15(method_bind_10, Object.GetPtr(this), height);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_height");

        [GodotMethod("get_height")]
        [Obsolete("GetHeight is deprecated. Use the RangeHeight property instead.")]
        public float GetHeight()
        {
            return NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_energy");

        [GodotMethod("set_energy")]
        [Obsolete("SetEnergy is deprecated. Use the Energy property instead.")]
        public void SetEnergy(float energy)
        {
            NativeCalls.godot_icall_1_15(method_bind_12, Object.GetPtr(this), energy);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_energy");

        [GodotMethod("get_energy")]
        [Obsolete("GetEnergy is deprecated. Use the Energy property instead.")]
        public float GetEnergy()
        {
            return NativeCalls.godot_icall_0_14(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture_scale");

        [GodotMethod("set_texture_scale")]
        [Obsolete("SetTextureScale is deprecated. Use the TextureScale property instead.")]
        public void SetTextureScale(float textureScale)
        {
            NativeCalls.godot_icall_1_15(method_bind_14, Object.GetPtr(this), textureScale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture_scale");

        [GodotMethod("get_texture_scale")]
        [Obsolete("GetTextureScale is deprecated. Use the TextureScale property instead.")]
        public float GetTextureScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_z_range_min");

        [GodotMethod("set_z_range_min")]
        [Obsolete("SetZRangeMin is deprecated. Use the RangeZMin property instead.")]
        public void SetZRangeMin(int z)
        {
            NativeCalls.godot_icall_1_4(method_bind_16, Object.GetPtr(this), z);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_z_range_min");

        [GodotMethod("get_z_range_min")]
        [Obsolete("GetZRangeMin is deprecated. Use the RangeZMin property instead.")]
        public int GetZRangeMin()
        {
            return NativeCalls.godot_icall_0_5(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_z_range_max");

        [GodotMethod("set_z_range_max")]
        [Obsolete("SetZRangeMax is deprecated. Use the RangeZMax property instead.")]
        public void SetZRangeMax(int z)
        {
            NativeCalls.godot_icall_1_4(method_bind_18, Object.GetPtr(this), z);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_z_range_max");

        [GodotMethod("get_z_range_max")]
        [Obsolete("GetZRangeMax is deprecated. Use the RangeZMax property instead.")]
        public int GetZRangeMax()
        {
            return NativeCalls.godot_icall_0_5(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_layer_range_min");

        [GodotMethod("set_layer_range_min")]
        [Obsolete("SetLayerRangeMin is deprecated. Use the RangeLayerMin property instead.")]
        public void SetLayerRangeMin(int layer)
        {
            NativeCalls.godot_icall_1_4(method_bind_20, Object.GetPtr(this), layer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_layer_range_min");

        [GodotMethod("get_layer_range_min")]
        [Obsolete("GetLayerRangeMin is deprecated. Use the RangeLayerMin property instead.")]
        public int GetLayerRangeMin()
        {
            return NativeCalls.godot_icall_0_5(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_layer_range_max");

        [GodotMethod("set_layer_range_max")]
        [Obsolete("SetLayerRangeMax is deprecated. Use the RangeLayerMax property instead.")]
        public void SetLayerRangeMax(int layer)
        {
            NativeCalls.godot_icall_1_4(method_bind_22, Object.GetPtr(this), layer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_layer_range_max");

        [GodotMethod("get_layer_range_max")]
        [Obsolete("GetLayerRangeMax is deprecated. Use the RangeLayerMax property instead.")]
        public int GetLayerRangeMax()
        {
            return NativeCalls.godot_icall_0_5(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_cull_mask");

        [GodotMethod("set_item_cull_mask")]
        [Obsolete("SetItemCullMask is deprecated. Use the RangeItemCullMask property instead.")]
        public void SetItemCullMask(int itemCullMask)
        {
            NativeCalls.godot_icall_1_4(method_bind_24, Object.GetPtr(this), itemCullMask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_cull_mask");

        [GodotMethod("get_item_cull_mask")]
        [Obsolete("GetItemCullMask is deprecated. Use the RangeItemCullMask property instead.")]
        public int GetItemCullMask()
        {
            return NativeCalls.godot_icall_0_5(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_shadow_cull_mask");

        [GodotMethod("set_item_shadow_cull_mask")]
        [Obsolete("SetItemShadowCullMask is deprecated. Use the ShadowItemCullMask property instead.")]
        public void SetItemShadowCullMask(int itemShadowCullMask)
        {
            NativeCalls.godot_icall_1_4(method_bind_26, Object.GetPtr(this), itemShadowCullMask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_shadow_cull_mask");

        [GodotMethod("get_item_shadow_cull_mask")]
        [Obsolete("GetItemShadowCullMask is deprecated. Use the ShadowItemCullMask property instead.")]
        public int GetItemShadowCullMask()
        {
            return NativeCalls.godot_icall_0_5(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mode");

        [GodotMethod("set_mode")]
        [Obsolete("SetMode is deprecated. Use the Mode property instead.")]
        public void SetMode(Light2D.ModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_28, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mode");

        [GodotMethod("get_mode")]
        [Obsolete("GetMode is deprecated. Use the Mode property instead.")]
        public Light2D.ModeEnum GetMode()
        {
            return (Light2D.ModeEnum)NativeCalls.godot_icall_0_583(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shadow_enabled");

        [GodotMethod("set_shadow_enabled")]
        [Obsolete("SetShadowEnabled is deprecated. Use the ShadowEnabled property instead.")]
        public void SetShadowEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_30, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_shadow_enabled");

        [GodotMethod("is_shadow_enabled")]
        [Obsolete("IsShadowEnabled is deprecated. Use the ShadowEnabled property instead.")]
        public bool IsShadowEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_31, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shadow_buffer_size");

        [GodotMethod("set_shadow_buffer_size")]
        [Obsolete("SetShadowBufferSize is deprecated. Use the ShadowBufferSize property instead.")]
        public void SetShadowBufferSize(int size)
        {
            NativeCalls.godot_icall_1_4(method_bind_32, Object.GetPtr(this), size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shadow_buffer_size");

        [GodotMethod("get_shadow_buffer_size")]
        [Obsolete("GetShadowBufferSize is deprecated. Use the ShadowBufferSize property instead.")]
        public int GetShadowBufferSize()
        {
            return NativeCalls.godot_icall_0_5(method_bind_33, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shadow_smooth");

        [GodotMethod("set_shadow_smooth")]
        [Obsolete("SetShadowSmooth is deprecated. Use the ShadowFilterSmooth property instead.")]
        public void SetShadowSmooth(float smooth)
        {
            NativeCalls.godot_icall_1_15(method_bind_34, Object.GetPtr(this), smooth);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shadow_smooth");

        [GodotMethod("get_shadow_smooth")]
        [Obsolete("GetShadowSmooth is deprecated. Use the ShadowFilterSmooth property instead.")]
        public float GetShadowSmooth()
        {
            return NativeCalls.godot_icall_0_14(method_bind_35, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shadow_gradient_length");

        [GodotMethod("set_shadow_gradient_length")]
        [Obsolete("SetShadowGradientLength is deprecated. Use the ShadowGradientLength property instead.")]
        public void SetShadowGradientLength(float multiplier)
        {
            NativeCalls.godot_icall_1_15(method_bind_36, Object.GetPtr(this), multiplier);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shadow_gradient_length");

        [GodotMethod("get_shadow_gradient_length")]
        [Obsolete("GetShadowGradientLength is deprecated. Use the ShadowGradientLength property instead.")]
        public float GetShadowGradientLength()
        {
            return NativeCalls.godot_icall_0_14(method_bind_37, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shadow_filter");

        [GodotMethod("set_shadow_filter")]
        [Obsolete("SetShadowFilter is deprecated. Use the ShadowFilter property instead.")]
        public void SetShadowFilter(Light2D.ShadowFilterEnum filter)
        {
            NativeCalls.godot_icall_1_4(method_bind_38, Object.GetPtr(this), (int)filter);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shadow_filter");

        [GodotMethod("get_shadow_filter")]
        [Obsolete("GetShadowFilter is deprecated. Use the ShadowFilter property instead.")]
        public Light2D.ShadowFilterEnum GetShadowFilter()
        {
            return (Light2D.ShadowFilterEnum)NativeCalls.godot_icall_0_584(method_bind_39, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shadow_color");

        [GodotMethod("set_shadow_color")]
        [Obsolete("SetShadowColor is deprecated. Use the ShadowColor property instead.")]
        public void SetShadowColor(Color shadowColor)
        {
            NativeCalls.godot_icall_1_199(method_bind_40, Object.GetPtr(this), ref shadowColor);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shadow_color");

        [GodotMethod("get_shadow_color")]
        [Obsolete("GetShadowColor is deprecated. Use the ShadowColor property instead.")]
        public Color GetShadowColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_41, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
