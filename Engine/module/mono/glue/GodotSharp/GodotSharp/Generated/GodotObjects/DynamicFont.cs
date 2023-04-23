using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>DynamicFont renders vector font files dynamically at runtime instead of using a prerendered texture atlas like <see cref="Godot.BitmapFont"/>. This trades the faster loading time of <see cref="Godot.BitmapFont"/>s for the ability to change font parameters like size and spacing during runtime. <see cref="Godot.DynamicFontData"/> is used for referencing the font file paths. DynamicFont also supports defining one or more fallback fonts, which will be used when displaying a character not supported by the main font.</para>
    /// <para>DynamicFont uses the <a href="https://www.freetype.org/">FreeType</a> library for rasterization. Supported formats are TrueType (<c>.ttf</c>), OpenType (<c>.otf</c>), Web Open Font Format 1 (<c>.woff</c>), and  Web Open Font Format 2 (<c>.woff2</c>).</para>
    /// <para><code>
    /// var dynamic_font = DynamicFont.new()
    /// dynamic_font.font_data = load("res://BarlowCondensed-Bold.ttf")
    /// dynamic_font.size = 64
    /// $"Label".set("custom_fonts/font", dynamic_font)
    /// </code></para>
    /// <para>Note: DynamicFont doesn't support features such as kerning, right-to-left typesetting, ligatures, text shaping, variable fonts and optional font features yet. If you wish to "bake" an optional font feature into a TTF font file, you can use <a href="https://fontforge.org/">FontForge</a> to do so. In FontForge, use File &gt; Generate Fonts, click Options, choose the desired features then generate the font.</para>
    /// </summary>
    public partial class DynamicFont : Font
    {
        public enum SpacingType
        {
            /// <summary>
            /// <para>Spacing at the top.</para>
            /// </summary>
            Top = 0,
            /// <summary>
            /// <para>Spacing at the bottom.</para>
            /// </summary>
            Bottom = 1,
            /// <summary>
            /// <para>Spacing for each character.</para>
            /// </summary>
            Char = 2,
            /// <summary>
            /// <para>Spacing for the space character.</para>
            /// </summary>
            Space = 3
        }

        /// <summary>
        /// <para>The font size in pixels.</para>
        /// </summary>
        public int Size
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The font outline's thickness in pixels (not relative to the font size).</para>
        /// </summary>
        public int OutlineSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOutlineSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOutlineSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The font outline's color.</para>
        /// <para>Note: It's recommended to leave this at the default value so that you can adjust it in individual controls. For example, if the outline is made black here, it won't be possible to change its color using a Label's font outline modulate theme item.</para>
        /// </summary>
        public Color OutlineColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOutlineColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOutlineColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, mipmapping is used. This improves the font's appearance when downscaling it if font oversampling is disabled or ineffective.</para>
        /// </summary>
        public bool UseMipmaps
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUseMipmaps();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseMipmaps(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, filtering is used. This makes the font blurry instead of pixelated when scaling it if font oversampling is disabled or ineffective. It's recommended to enable this when using the font in a control whose size changes over time, unless a pixel art aesthetic is desired.</para>
        /// </summary>
        public bool UseFilter
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUseFilter();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseFilter(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Extra spacing at the top in pixels.</para>
        /// </summary>
        public int ExtraSpacingTop
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSpacing(0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSpacing(0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Extra spacing at the bottom in pixels.</para>
        /// </summary>
        public int ExtraSpacingBottom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSpacing(1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSpacing(1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Extra spacing for each character in pixels.</para>
        /// <para>This can be a negative number to make the distance between characters smaller.</para>
        /// </summary>
        public int ExtraSpacingChar
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSpacing(2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSpacing(2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Extra spacing for the space character (in addition to <see cref="Godot.DynamicFont.ExtraSpacingChar"/>) in pixels.</para>
        /// <para>This can be a negative number to make the distance between words smaller.</para>
        /// </summary>
        public int ExtraSpacingSpace
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSpacing(3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSpacing(3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The font data.</para>
        /// </summary>
        public DynamicFontData FontData
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFontData();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFontData(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "DynamicFont";

        public DynamicFont() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_DynamicFont_Ctor(this);
        }

        internal DynamicFont(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_font_data");

        [GodotMethod("set_font_data")]
        [Obsolete("SetFontData is deprecated. Use the FontData property instead.")]
        public void SetFontData(DynamicFontData data)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(data));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_font_data");

        [GodotMethod("get_font_data")]
        [Obsolete("GetFontData is deprecated. Use the FontData property instead.")]
        public DynamicFontData GetFontData()
        {
            return NativeCalls.godot_icall_0_364(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_available_chars");

        /// <summary>
        /// <para>Returns a string containing all the characters available in the main and all the fallback fonts.</para>
        /// <para>If a given character is included in more than one font, it appears only once in the returned string.</para>
        /// </summary>
        [GodotMethod("get_available_chars")]
        public string GetAvailableChars()
        {
            return NativeCalls.godot_icall_0_6(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_size");

        [GodotMethod("set_size")]
        [Obsolete("SetSize is deprecated. Use the Size property instead.")]
        public void SetSize(int data)
        {
            NativeCalls.godot_icall_1_4(method_bind_3, Object.GetPtr(this), data);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_size");

        [GodotMethod("get_size")]
        [Obsolete("GetSize is deprecated. Use the Size property instead.")]
        public int GetSize()
        {
            return NativeCalls.godot_icall_0_5(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_outline_size");

        [GodotMethod("set_outline_size")]
        [Obsolete("SetOutlineSize is deprecated. Use the OutlineSize property instead.")]
        public void SetOutlineSize(int size)
        {
            NativeCalls.godot_icall_1_4(method_bind_5, Object.GetPtr(this), size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_outline_size");

        [GodotMethod("get_outline_size")]
        [Obsolete("GetOutlineSize is deprecated. Use the OutlineSize property instead.")]
        public int GetOutlineSize()
        {
            return NativeCalls.godot_icall_0_5(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_outline_color");

        [GodotMethod("set_outline_color")]
        [Obsolete("SetOutlineColor is deprecated. Use the OutlineColor property instead.")]
        public void SetOutlineColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_7, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_outline_color");

        [GodotMethod("get_outline_color")]
        [Obsolete("GetOutlineColor is deprecated. Use the OutlineColor property instead.")]
        public Color GetOutlineColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_8, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_mipmaps");

        [GodotMethod("set_use_mipmaps")]
        [Obsolete("SetUseMipmaps is deprecated. Use the UseMipmaps property instead.")]
        public void SetUseMipmaps(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_9, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_use_mipmaps");

        [GodotMethod("get_use_mipmaps")]
        [Obsolete("GetUseMipmaps is deprecated. Use the UseMipmaps property instead.")]
        public bool GetUseMipmaps()
        {
            return NativeCalls.godot_icall_0_7(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_filter");

        [GodotMethod("set_use_filter")]
        [Obsolete("SetUseFilter is deprecated. Use the UseFilter property instead.")]
        public void SetUseFilter(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_11, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_use_filter");

        [GodotMethod("get_use_filter")]
        [Obsolete("GetUseFilter is deprecated. Use the UseFilter property instead.")]
        public bool GetUseFilter()
        {
            return NativeCalls.godot_icall_0_7(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_spacing");

        /// <summary>
        /// <para>Sets the spacing for <c>type</c> (see <see cref="Godot.DynamicFont.SpacingType"/>) to <c>value</c> in pixels (not relative to the font size).</para>
        /// </summary>
        [GodotMethod("set_spacing")]
        [Obsolete("SetSpacing is deprecated. Use the ExtraSpacingSpace property instead.")]
        public void SetSpacing(int type, int value)
        {
            NativeCalls.godot_icall_2_65(method_bind_13, Object.GetPtr(this), type, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_spacing");

        /// <summary>
        /// <para>Returns the spacing for the given <c>type</c> (see <see cref="Godot.DynamicFont.SpacingType"/>).</para>
        /// </summary>
        [GodotMethod("get_spacing")]
        [Obsolete("GetSpacing is deprecated. Use the ExtraSpacingSpace property instead.")]
        public int GetSpacing(int type)
        {
            return NativeCalls.godot_icall_1_11(method_bind_14, Object.GetPtr(this), type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_fallback");

        /// <summary>
        /// <para>Adds a fallback font.</para>
        /// </summary>
        [GodotMethod("add_fallback")]
        public void AddFallback(DynamicFontData data)
        {
            NativeCalls.godot_icall_1_24(method_bind_15, Object.GetPtr(this), Object.GetPtr(data));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fallback");

        /// <summary>
        /// <para>Sets the fallback font at index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("set_fallback")]
        public void SetFallback(int idx, DynamicFontData data)
        {
            NativeCalls.godot_icall_2_58(method_bind_16, Object.GetPtr(this), idx, Object.GetPtr(data));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fallback");

        /// <summary>
        /// <para>Returns the fallback font at index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_fallback")]
        public DynamicFontData GetFallback(int idx)
        {
            return NativeCalls.godot_icall_1_365(method_bind_17, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_fallback");

        /// <summary>
        /// <para>Removes the fallback font at index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("remove_fallback")]
        public void RemoveFallback(int idx)
        {
            NativeCalls.godot_icall_1_4(method_bind_18, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fallback_count");

        /// <summary>
        /// <para>Returns the number of fallback fonts.</para>
        /// </summary>
        [GodotMethod("get_fallback_count")]
        public int GetFallbackCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_19, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
