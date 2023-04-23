using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A resource referenced in an <see cref="Godot.Environment"/> that is used to draw a background. The Panorama sky functions similar to skyboxes in other engines, except it uses an equirectangular sky map instead of a cube map.</para>
    /// <para>Using an HDR panorama is strongly recommended for accurate, high-quality reflections. Godot supports the Radiance HDR (<c>.hdr</c>) and OpenEXR (<c>.exr</c>) image formats for this purpose.</para>
    /// <para>You can use <a href="https://danilw.github.io/GLSL-howto/cubemap_to_panorama_js/cubemap_to_panorama.html">this tool</a> to convert a cube map to an equirectangular sky map.</para>
    /// </summary>
    public partial class PanoramaSky : Sky
    {
        /// <summary>
        /// <para><see cref="Godot.Texture"/> to be applied to the PanoramaSky.</para>
        /// </summary>
        public Texture Panorama
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPanorama();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPanorama(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "PanoramaSky";

        public PanoramaSky() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PanoramaSky_Ctor(this);
        }

        internal PanoramaSky(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_panorama");

        [GodotMethod("set_panorama")]
        [Obsolete("SetPanorama is deprecated. Use the Panorama property instead.")]
        public void SetPanorama(Texture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_panorama");

        [GodotMethod("get_panorama")]
        [Obsolete("GetPanorama is deprecated. Use the Panorama property instead.")]
        public Texture GetPanorama()
        {
            return NativeCalls.godot_icall_0_161(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
