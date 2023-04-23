using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.TextureArray"/>s store an array of <see cref="Godot.Image"/>s in a single <see cref="Godot.Texture"/> primitive. Each layer of the texture array has its own mipmap chain. This makes it is a good alternative to texture atlases. See also <see cref="Godot.Texture3D"/>.</para>
    /// <para><see cref="Godot.TextureArray"/>s must be displayed using shaders. After importing your file as a <see cref="Godot.TextureArray"/> and setting the appropriate Horizontal and Vertical Slices, display it by setting it as a uniform to a shader, for example (2D):</para>
    /// <para><code>
    /// shader_type canvas_item;
    /// 
    /// uniform sampler2DArray tex;
    /// uniform int index;
    /// 
    /// void fragment() {
    ///     COLOR = texture(tex, vec3(UV.x, UV.y, float(index)));
    /// }
    /// </code></para>
    /// <para>Set the integer uniform "index" to show a particular part of the texture as defined by the Horizontal and Vertical Slices in the importer.</para>
    /// <para>Note: When sampling an albedo texture from a texture array in 3D, the sRGB -&gt; linear conversion hint (<c>hint_albedo</c>) should be used to prevent colors from looking washed out:</para>
    /// <para><code>
    /// shader_type spatial;
    /// 
    /// uniform sampler2DArray tex : hint_albedo;
    /// uniform int index;
    /// 
    /// void fragment() {
    ///     ALBEDO = texture(tex, vec3(UV.x, UV.y, float(index)));
    /// }
    /// </code></para>
    /// <para>Note: <see cref="Godot.TextureArray"/>s can only be sampled in shaders in the GLES3 backend. In GLES2, their data can be accessed via scripting, but there is no way to render them in a hardware-accelerated manner.</para>
    /// </summary>
    public partial class TextureArray : TextureLayered
    {
        private const string nativeName = "TextureArray";

        public TextureArray() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_TextureArray_Ctor(this);
        }

        internal TextureArray(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create");

        /// <summary>
        /// <para>Creates the TextureArray with specified <c>width</c>, <c>height</c>, and <c>depth</c>. See <see cref="Godot.Image.Format"/> for <c>format</c> options. See <see cref="Godot.TextureLayered.FlagsEnum"/> enumerator for <c>flags</c> options.</para>
        /// </summary>
        [GodotMethod("create")]
        public void Create(uint width, uint height, uint depth, Image.Format format, uint flags = (uint)7)
        {
            NativeCalls.godot_icall_5_927(method_bind_0, Object.GetPtr(this), width, height, depth, (int)format, flags);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
