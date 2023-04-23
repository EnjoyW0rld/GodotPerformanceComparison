using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Renders text using <c>*.fnt</c> fonts containing texture atlases. Supports distance fields. For using vector font files like TTF directly, see <see cref="Godot.DynamicFont"/>.</para>
    /// </summary>
    public partial class BitmapFont : Font
    {
        public Godot.Collections.Array Textures
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetTextures();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetTextures(value);
            }
#pragma warning restore CS0618
        }

        public int[] Chars
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetChars();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetChars(value);
            }
#pragma warning restore CS0618
        }

        public int[] Kernings
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetKernings();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetKernings(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Total font height (ascent plus descent) in pixels.</para>
        /// </summary>
        public float Height
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
        /// <para>Ascent (number of pixels above the baseline).</para>
        /// </summary>
        public float Ascent
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAscent();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAscent(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, distance field hint is enabled.</para>
        /// </summary>
        public bool DistanceField
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDistanceFieldHint();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDistanceFieldHint(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The fallback font.</para>
        /// </summary>
        public BitmapFont Fallback
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFallback();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFallback(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "BitmapFont";

        public BitmapFont() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_BitmapFont_Ctor(this);
        }

        internal BitmapFont(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_from_fnt");

        /// <summary>
        /// <para>Creates a BitmapFont from the <c>*.fnt</c> file at <c>path</c>.</para>
        /// </summary>
        [GodotMethod("create_from_fnt")]
        public Error CreateFromFnt(string path)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_0, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_height");

        [GodotMethod("set_height")]
        [Obsolete("SetHeight is deprecated. Use the Height property instead.")]
        public void SetHeight(float px)
        {
            NativeCalls.godot_icall_1_15(method_bind_1, Object.GetPtr(this), px);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ascent");

        [GodotMethod("set_ascent")]
        [Obsolete("SetAscent is deprecated. Use the Ascent property instead.")]
        public void SetAscent(float px)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), px);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_kerning_pair");

        /// <summary>
        /// <para>Adds a kerning pair to the <see cref="Godot.BitmapFont"/> as a difference. Kerning pairs are special cases where a typeface advance is determined by the next character.</para>
        /// </summary>
        [GodotMethod("add_kerning_pair")]
        public void AddKerningPair(int charA, int charB, int kerning)
        {
            NativeCalls.godot_icall_3_176(method_bind_3, Object.GetPtr(this), charA, charB, kerning);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_kerning_pair");

        /// <summary>
        /// <para>Returns a kerning pair as a difference.</para>
        /// </summary>
        [GodotMethod("get_kerning_pair")]
        public int GetKerningPair(int charA, int charB)
        {
            return NativeCalls.godot_icall_2_60(method_bind_4, Object.GetPtr(this), charA, charB);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_texture");

        /// <summary>
        /// <para>Adds a texture to the <see cref="Godot.BitmapFont"/>.</para>
        /// </summary>
        [GodotMethod("add_texture")]
        public void AddTexture(Texture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_5, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_char");

        /// <summary>
        /// <para>Adds a character to the font, where <c>character</c> is the Unicode value, <c>texture</c> is the texture index, <c>rect</c> is the region in the texture (in pixels!), <c>align</c> is the (optional) alignment for the character and <c>advance</c> is the (optional) advance.</para>
        /// </summary>
        /// <param name="align">If the parameter is null, then the default value is new Vector2(0, 0)</param>
        [GodotMethod("add_char")]
        public void AddChar(int character, int texture, Rect2 rect, Nullable<Vector2> align = null, float advance = (float)-1)
        {
            Vector2 align_in = align.HasValue ? align.Value : new Vector2(0, 0);
            NativeCalls.godot_icall_5_218(method_bind_6, Object.GetPtr(this), character, texture, ref rect, ref align_in, advance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture_count");

        /// <summary>
        /// <para>Returns the number of textures in the BitmapFont atlas.</para>
        /// </summary>
        [GodotMethod("get_texture_count")]
        public int GetTextureCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture");

        /// <summary>
        /// <para>Returns the font atlas texture at index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_texture")]
        public Texture GetTexture(int idx)
        {
            return NativeCalls.godot_icall_1_59(method_bind_8, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_distance_field_hint");

        [GodotMethod("set_distance_field_hint")]
        [Obsolete("SetDistanceFieldHint is deprecated. Use the DistanceField property instead.")]
        public void SetDistanceFieldHint(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_9, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Clears all the font data and settings.</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_chars");

        [Obsolete("_SetChars is deprecated. Use the Chars property instead.")]
        internal void _SetChars(int[] arg0)
        {
            NativeCalls.godot_icall_1_102(method_bind_11, Object.GetPtr(this), arg0);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_chars");

        [Obsolete("_GetChars is deprecated. Use the Chars property instead.")]
        internal int[] _GetChars()
        {
            return NativeCalls.godot_icall_0_103(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_kernings");

        [Obsolete("_SetKernings is deprecated. Use the Kernings property instead.")]
        internal void _SetKernings(int[] arg0)
        {
            NativeCalls.godot_icall_1_102(method_bind_13, Object.GetPtr(this), arg0);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_kernings");

        [Obsolete("_GetKernings is deprecated. Use the Kernings property instead.")]
        internal int[] _GetKernings()
        {
            return NativeCalls.godot_icall_0_103(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_textures");

        [Obsolete("_SetTextures is deprecated. Use the Textures property instead.")]
        internal void _SetTextures(Godot.Collections.Array arg0)
        {
            NativeCalls.godot_icall_1_92(method_bind_15, Object.GetPtr(this), arg0.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_textures");

        [Obsolete("_GetTextures is deprecated. Use the Textures property instead.")]
        internal Godot.Collections.Array _GetTextures()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_16, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fallback");

        [GodotMethod("set_fallback")]
        [Obsolete("SetFallback is deprecated. Use the Fallback property instead.")]
        public void SetFallback(BitmapFont fallback)
        {
            NativeCalls.godot_icall_1_24(method_bind_17, Object.GetPtr(this), Object.GetPtr(fallback));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fallback");

        [GodotMethod("get_fallback")]
        [Obsolete("GetFallback is deprecated. Use the Fallback property instead.")]
        public BitmapFont GetFallback()
        {
            return NativeCalls.godot_icall_0_219(method_bind_18, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
