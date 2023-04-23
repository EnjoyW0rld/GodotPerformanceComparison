using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Texture3D is a 3-dimensional <see cref="Godot.Texture"/> that has a width, height, and depth. See also <see cref="Godot.TextureArray"/>.</para>
    /// <para>Note: <see cref="Godot.Texture3D"/>s can only be sampled in shaders in the GLES3 backend. In GLES2, their data can be accessed via scripting, but there is no way to render them in a hardware-accelerated manner.</para>
    /// </summary>
    public partial class Texture3D : TextureLayered
    {
        private const string nativeName = "Texture3D";

        public Texture3D() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Texture3D_Ctor(this);
        }

        internal Texture3D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create");

        /// <summary>
        /// <para>Creates the Texture3D with specified <c>width</c>, <c>height</c>, and <c>depth</c>. See <see cref="Godot.Image.Format"/> for <c>format</c> options. See <see cref="Godot.TextureLayered.FlagsEnum"/> enumerator for <c>flags</c> options.</para>
        /// </summary>
        [GodotMethod("create")]
        public void Create(uint width, uint height, uint depth, Image.Format format, uint flags = (uint)4)
        {
            NativeCalls.godot_icall_5_927(method_bind_0, Object.GetPtr(this), width, height, depth, (int)format, flags);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
