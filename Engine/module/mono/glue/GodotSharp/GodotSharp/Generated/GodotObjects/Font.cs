using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Font contains a Unicode-compatible character set, as well as the ability to draw it with variable width, ascent, descent and kerning. For creating fonts from TTF files (or other font formats), see the editor support for fonts.</para>
    /// <para>Note: If a <see cref="Godot.DynamicFont"/> doesn't contain a character used in a string, the character in question will be replaced with codepoint <c>0xfffd</c> if it's available in the <see cref="Godot.DynamicFont"/>. If this replacement character isn't available in the DynamicFont, the character will be hidden without displaying any replacement character in the string.</para>
    /// <para>Note: If a <see cref="Godot.BitmapFont"/> doesn't contain a character used in a string, the character in question will be hidden without displaying any replacement character in the string.</para>
    /// <para>Note: Unicode characters after <c>0xffff</c> (such as most emoji) are not supported on Windows. They will display as unknown characters instead. This will be resolved in Godot 4.0.</para>
    /// </summary>
    public abstract partial class Font : Resource
    {
        public enum ContourPointTag
        {
            /// <summary>
            /// <para>Contour point is on the curve.</para>
            /// </summary>
            On = 1,
            /// <summary>
            /// <para>Contour point isn't on the curve, but serves as a control point for a conic (quadratic) Bézier arc.</para>
            /// </summary>
            OffConic = 0,
            /// <summary>
            /// <para>Contour point isn't on the curve, but serves as a control point for a cubic Bézier arc.</para>
            /// </summary>
            OffCubic = 2
        }

        private const string nativeName = "Font";

        internal Font() {}

        internal Font(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw");

        /// <summary>
        /// <para>Draw <c>string</c> into a canvas item using the font at a given position, with <c>modulate</c> color, and optionally clipping the width. <c>position</c> specifies the baseline, not the top. To draw from the top, ascent must be added to the Y axis.</para>
        /// <para>See also <see cref="Godot.CanvasItem.DrawString"/>.</para>
        /// </summary>
        /// <param name="modulate">If the parameter is null, then the default value is new Color(1, 1, 1, 1)</param>
        /// <param name="outlineModulate">If the parameter is null, then the default value is new Color(1, 1, 1, 1)</param>
        [GodotMethod("draw")]
        public void Draw(RID canvasItem, Vector2 position, string @string, Nullable<Color> modulate = null, int clipW = -1, Nullable<Color> outlineModulate = null)
        {
            Color modulate_in = modulate.HasValue ? modulate.Value : new Color(1, 1, 1, 1);
            Color outlineModulate_in = outlineModulate.HasValue ? outlineModulate.Value : new Color(1, 1, 1, 1);
            NativeCalls.godot_icall_6_436(method_bind_0, Object.GetPtr(this), RID.GetPtr(canvasItem), ref position, @string, ref modulate_in, clipW, ref outlineModulate_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ascent");

        /// <summary>
        /// <para>Returns the font ascent (number of pixels above the baseline).</para>
        /// </summary>
        [GodotMethod("get_ascent")]
        public float GetAscent()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_descent");

        /// <summary>
        /// <para>Returns the font descent (number of pixels below the baseline).</para>
        /// </summary>
        [GodotMethod("get_descent")]
        public float GetDescent()
        {
            return NativeCalls.godot_icall_0_14(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_height");

        /// <summary>
        /// <para>Returns the total font height (ascent plus descent) in pixels.</para>
        /// </summary>
        [GodotMethod("get_height")]
        public float GetHeight()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_distance_field_hint");

        [GodotMethod("is_distance_field_hint")]
        public bool IsDistanceFieldHint()
        {
            return NativeCalls.godot_icall_0_7(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_char_size");

        /// <summary>
        /// <para>Returns the size of a character, optionally taking kerning into account if the next character is provided. Note that the height returned is the font height (see <see cref="Godot.Font.GetHeight"/>) and has no relation to the glyph height.</para>
        /// </summary>
        [GodotMethod("get_char_size")]
        public Vector2 GetCharSize(int @char, int next = 0)
        {
            NativeCalls.godot_icall_2_82(method_bind_5, Object.GetPtr(this), @char, next, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_string_size");

        /// <summary>
        /// <para>Returns the size of a string, taking kerning and advance into account. Note that the height returned is the font height (see <see cref="Godot.Font.GetHeight"/>) and has no relation to the string.</para>
        /// </summary>
        [GodotMethod("get_string_size")]
        public Vector2 GetStringSize(string @string)
        {
            NativeCalls.godot_icall_1_112(method_bind_6, Object.GetPtr(this), @string, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_wordwrap_string_size");

        /// <summary>
        /// <para>Returns the size that the string would have with word wrapping enabled with a fixed <c>width</c>.</para>
        /// </summary>
        [GodotMethod("get_wordwrap_string_size")]
        public Vector2 GetWordwrapStringSize(string @string, float width)
        {
            NativeCalls.godot_icall_2_437(method_bind_7, Object.GetPtr(this), @string, width, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_outline");

        /// <summary>
        /// <para>Returns <c>true</c> if the font has an outline.</para>
        /// </summary>
        [GodotMethod("has_outline")]
        public bool HasOutline()
        {
            return NativeCalls.godot_icall_0_7(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_char");

        /// <summary>
        /// <para>Draw character <c>char</c> into a canvas item using the font at a given position, with <c>modulate</c> color, and optionally kerning if <c>next</c> is passed. clipping the width. <c>position</c> specifies the baseline, not the top. To draw from the top, ascent must be added to the Y axis. The width used by the character is returned, making this function useful for drawing strings character by character.</para>
        /// <para>If <c>outline</c> is <c>true</c>, the outline of the character is drawn instead of the character itself.</para>
        /// </summary>
        /// <param name="modulate">If the parameter is null, then the default value is new Color(1, 1, 1, 1)</param>
        [GodotMethod("draw_char")]
        public float DrawChar(RID canvasItem, Vector2 position, int @char, int next = -1, Nullable<Color> modulate = null, bool outline = false)
        {
            Color modulate_in = modulate.HasValue ? modulate.Value : new Color(1, 1, 1, 1);
            return NativeCalls.godot_icall_6_438(method_bind_9, Object.GetPtr(this), RID.GetPtr(canvasItem), ref position, @char, next, ref modulate_in, outline);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_char_texture");

        /// <summary>
        /// <para>Returns resource id of the cache texture containing the char.</para>
        /// </summary>
        [GodotMethod("get_char_texture")]
        public RID GetCharTexture(int @char, int next = 0, bool outline = false)
        {
            return new RID(NativeCalls.godot_icall_3_439(method_bind_10, Object.GetPtr(this), @char, next, outline));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_char_texture_size");

        /// <summary>
        /// <para>Returns size of the cache texture containing the char.</para>
        /// </summary>
        [GodotMethod("get_char_texture_size")]
        public Vector2 GetCharTextureSize(int @char, int next = 0, bool outline = false)
        {
            NativeCalls.godot_icall_3_440(method_bind_11, Object.GetPtr(this), @char, next, outline, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_char_tx_offset");

        /// <summary>
        /// <para>Returns char offset from the baseline.</para>
        /// </summary>
        [GodotMethod("get_char_tx_offset")]
        public Vector2 GetCharTxOffset(int @char, int next = 0, bool outline = false)
        {
            NativeCalls.godot_icall_3_440(method_bind_12, Object.GetPtr(this), @char, next, outline, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_char_tx_size");

        /// <summary>
        /// <para>Returns size of the char.</para>
        /// </summary>
        [GodotMethod("get_char_tx_size")]
        public Vector2 GetCharTxSize(int @char, int next = 0, bool outline = false)
        {
            NativeCalls.godot_icall_3_440(method_bind_13, Object.GetPtr(this), @char, next, outline, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_char_tx_uv_rect");

        /// <summary>
        /// <para>Returns rectangle in the cache texture containing the char.</para>
        /// </summary>
        [GodotMethod("get_char_tx_uv_rect")]
        public Rect2 GetCharTxUvRect(int @char, int next = 0, bool outline = false)
        {
            NativeCalls.godot_icall_3_441(method_bind_14, Object.GetPtr(this), @char, next, outline, out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "update_changes");

        /// <summary>
        /// <para>After editing a font (changing size, ascent, char rects, etc.). Call this function to propagate changes to controls that might use it.</para>
        /// </summary>
        [GodotMethod("update_changes")]
        public void UpdateChanges()
        {
            NativeCalls.godot_icall_0_3(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_char_contours");

        /// <summary>
        /// <para>Returns outline contours of the glyph as a <c>Dictionary</c> with the following contents:</para>
        /// <para><c>points</c>         - <see cref="Godot.Vector3"/>, containing outline points. <c>x</c> and <c>y</c> are point coordinates. <c>z</c> is the type of the point, using the <see cref="Godot.Font.ContourPointTag"/> values.</para>
        /// <para><c>contours</c>       - <see cref="int"/>, containing indices the end points of each contour.</para>
        /// <para><c>orientation</c>    - <see cref="bool"/>, contour orientation. If <c>true</c>, clockwise contours must be filled.</para>
        /// </summary>
        [GodotMethod("get_char_contours")]
        public Godot.Collections.Dictionary GetCharContours(int @char, int next = 0)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_2_442(method_bind_16, Object.GetPtr(this), @char, next));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
