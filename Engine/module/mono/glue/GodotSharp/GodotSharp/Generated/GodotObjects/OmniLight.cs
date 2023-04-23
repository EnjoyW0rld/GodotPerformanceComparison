using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>An Omnidirectional light is a type of <see cref="Godot.Light"/> that emits light in all directions. The light is attenuated by distance and this attenuation can be configured by changing its energy, radius, and attenuation parameters.</para>
    /// <para>Note: By default, only 32 OmniLights may affect a single mesh resource at once. Consider splitting your level into several meshes to decrease the likelihood that more than 32 lights will affect the same mesh resource. Splitting the level mesh will also improve frustum culling effectiveness, leading to greater performance. If you need to use more lights per mesh, you can increase  at the cost of shader compilation times.</para>
    /// </summary>
    public partial class OmniLight : Light
    {
        public enum ShadowMode
        {
            /// <summary>
            /// <para>Shadows are rendered to a dual-paraboloid texture. Faster than <see cref="Godot.OmniLight.ShadowMode.Cube"/>, but lower-quality.</para>
            /// </summary>
            DualParaboloid = 0,
            /// <summary>
            /// <para>Shadows are rendered to a cubemap. Slower than <see cref="Godot.OmniLight.ShadowMode.DualParaboloid"/>, but higher-quality. Only supported on GPUs that feature support for depth cubemaps.</para>
            /// </summary>
            Cube = 1
        }

        public enum ShadowDetail
        {
            /// <summary>
            /// <para>Use more detail vertically when computing the shadow.</para>
            /// </summary>
            Vertical = 0,
            /// <summary>
            /// <para>Use more detail horizontally when computing the shadow.</para>
            /// </summary>
            Horizontal = 1
        }

        /// <summary>
        /// <para>The light's radius. Note that the effectively lit area may appear to be smaller depending on the <see cref="Godot.OmniLight.OmniAttenuation"/> in use. No matter the <see cref="Godot.OmniLight.OmniAttenuation"/> in use, the light will never reach anything outside this radius.</para>
        /// <para>Note: <see cref="Godot.OmniLight.OmniRange"/> is not affected by <see cref="Godot.Spatial.Scale"/> (the light's scale or its parent's scale).</para>
        /// </summary>
        public float OmniRange
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((Light.Param)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((Light.Param)4, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The light's attenuation (drop-off) curve. A number of presets are available in the Inspector by right-clicking the curve.</para>
        /// </summary>
        public float OmniAttenuation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((Light.Param)5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((Light.Param)5, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The shadow rendering mode to use for this <see cref="Godot.OmniLight"/>. See <see cref="Godot.OmniLight.ShadowMode"/>.</para>
        /// <para>Note: In GLES2, <see cref="Godot.OmniLight.ShadowMode.Cube"/> is only supported on GPUs that feature support for depth cubemaps. Old GPUs such as the Radeon HD 4000 series don't support cubemap shadows and will fall back to dual paraboloid shadows as a result.</para>
        /// </summary>
        public OmniLight.ShadowMode OmniShadowMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShadowMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShadowMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>See <see cref="Godot.OmniLight.ShadowDetail"/>.</para>
        /// </summary>
        public OmniLight.ShadowDetail OmniShadowDetail
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShadowDetail();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShadowDetail(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "OmniLight";

        public OmniLight() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_OmniLight_Ctor(this);
        }

        internal OmniLight(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shadow_mode");

        [GodotMethod("set_shadow_mode")]
        [Obsolete("SetShadowMode is deprecated. Use the OmniShadowMode property instead.")]
        public void SetShadowMode(OmniLight.ShadowMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shadow_mode");

        [GodotMethod("get_shadow_mode")]
        [Obsolete("GetShadowMode is deprecated. Use the OmniShadowMode property instead.")]
        public OmniLight.ShadowMode GetShadowMode()
        {
            return (OmniLight.ShadowMode)NativeCalls.godot_icall_0_702(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shadow_detail");

        [GodotMethod("set_shadow_detail")]
        [Obsolete("SetShadowDetail is deprecated. Use the OmniShadowDetail property instead.")]
        public void SetShadowDetail(OmniLight.ShadowDetail detail)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)detail);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shadow_detail");

        [GodotMethod("get_shadow_detail")]
        [Obsolete("GetShadowDetail is deprecated. Use the OmniShadowDetail property instead.")]
        public OmniLight.ShadowDetail GetShadowDetail()
        {
            return (OmniLight.ShadowDetail)NativeCalls.godot_icall_0_703(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
