using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The base class for <see cref="Godot.PanoramaSky"/> and <see cref="Godot.ProceduralSky"/>.</para>
    /// </summary>
    public abstract partial class Sky : Resource
    {
        public enum RadianceSizeEnum
        {
            /// <summary>
            /// <para>Radiance texture size is 32×32 pixels.</para>
            /// </summary>
            Size32 = 0,
            /// <summary>
            /// <para>Radiance texture size is 64×64 pixels.</para>
            /// </summary>
            Size64 = 1,
            /// <summary>
            /// <para>Radiance texture size is 128×128 pixels.</para>
            /// </summary>
            Size128 = 2,
            /// <summary>
            /// <para>Radiance texture size is 256×256 pixels.</para>
            /// </summary>
            Size256 = 3,
            /// <summary>
            /// <para>Radiance texture size is 512×512 pixels.</para>
            /// </summary>
            Size512 = 4,
            /// <summary>
            /// <para>Radiance texture size is 1024×1024 pixels.</para>
            /// <para>Note: <see cref="Godot.Sky.RadianceSizeEnum.Size1024"/> is not exposed in the inspector as it is known to cause GPU hangs on certain systems.</para>
            /// </summary>
            Size1024 = 5,
            /// <summary>
            /// <para>Radiance texture size is 2048×2048 pixels.</para>
            /// <para>Note: <see cref="Godot.Sky.RadianceSizeEnum.Size2048"/> is not exposed in the inspector as it is known to cause GPU hangs on certain systems.</para>
            /// </summary>
            Size2048 = 6,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.Sky.RadianceSizeEnum"/> enum.</para>
            /// </summary>
            Max = 7
        }

        /// <summary>
        /// <para>The <see cref="Godot.Sky"/>'s radiance map size. The higher the radiance map size, the more detailed the lighting from the <see cref="Godot.Sky"/> will be.</para>
        /// <para>See <see cref="Godot.Sky.RadianceSizeEnum"/> constants for values.</para>
        /// <para>Note: You will only benefit from high radiance sizes if you have perfectly sharp reflective surfaces in your project and are not using <see cref="Godot.ReflectionProbe"/>s or <see cref="Godot.GIProbe"/>s. For most projects, keeping <see cref="Godot.Sky.RadianceSize"/> to the default value is the best compromise between visuals and performance. Be careful when using high radiance size values as these can cause crashes on low-end GPUs.</para>
        /// </summary>
        public Sky.RadianceSizeEnum RadianceSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRadianceSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRadianceSize(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Sky";

        internal Sky() {}

        internal Sky(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_radiance_size");

        [GodotMethod("set_radiance_size")]
        [Obsolete("SetRadianceSize is deprecated. Use the RadianceSize property instead.")]
        public void SetRadianceSize(Sky.RadianceSizeEnum size)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_radiance_size");

        [GodotMethod("get_radiance_size")]
        [Obsolete("GetRadianceSize is deprecated. Use the RadianceSize property instead.")]
        public Sky.RadianceSizeEnum GetRadianceSize()
        {
            return (Sky.RadianceSizeEnum)NativeCalls.godot_icall_0_863(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
