using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A directional light is a type of <see cref="Godot.Light"/> node that models an infinite number of parallel rays covering the entire scene. It is used for lights with strong intensity that are located far away from the scene to model sunlight or moonlight. The worldspace location of the DirectionalLight transform (origin) is ignored. Only the basis is used to determine light direction.</para>
    /// </summary>
    public partial class DirectionalLight : Light
    {
        public enum ShadowMode
        {
            /// <summary>
            /// <para>Renders the entire scene's shadow map from an orthogonal point of view. This is the fastest directional shadow mode. May result in blurrier shadows on close objects.</para>
            /// </summary>
            Orthogonal = 0,
            /// <summary>
            /// <para>Splits the view frustum in 2 areas, each with its own shadow map. This shadow mode is a compromise between <see cref="Godot.DirectionalLight.ShadowMode.Orthogonal"/> and <see cref="Godot.DirectionalLight.ShadowMode.Parallel4Splits"/> in terms of performance.</para>
            /// </summary>
            Parallel2Splits = 1,
            /// <summary>
            /// <para>Splits the view frustum in 4 areas, each with its own shadow map. This is the slowest directional shadow mode.</para>
            /// </summary>
            Parallel4Splits = 2
        }

        public enum ShadowDepthRange
        {
            /// <summary>
            /// <para>Keeps the shadow stable when the camera moves, at the cost of lower effective shadow resolution.</para>
            /// </summary>
            Stable = 0,
            /// <summary>
            /// <para>Tries to achieve maximum shadow resolution. May result in saw effect on shadow edges. This mode typically works best in games where the camera will often move at high speeds, such as most racing games.</para>
            /// </summary>
            Optimized = 1
        }

        /// <summary>
        /// <para>The light's shadow rendering algorithm. See <see cref="Godot.DirectionalLight.ShadowMode"/>.</para>
        /// </summary>
        public DirectionalLight.ShadowMode DirectionalShadowMode
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
        /// <para>The distance from camera to shadow split 1. Relative to <see cref="Godot.DirectionalLight.DirectionalShadowMaxDistance"/>. Only used when <see cref="Godot.DirectionalLight.DirectionalShadowMode"/> is <see cref="Godot.DirectionalLight.ShadowMode.Parallel2Splits"/> or <see cref="Godot.DirectionalLight.ShadowMode.Parallel4Splits"/>.</para>
        /// </summary>
        public float DirectionalShadowSplit1
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((Light.Param)10);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((Light.Param)10, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The distance from shadow split 1 to split 2. Relative to <see cref="Godot.DirectionalLight.DirectionalShadowMaxDistance"/>. Only used when <see cref="Godot.DirectionalLight.DirectionalShadowMode"/> is <see cref="Godot.DirectionalLight.ShadowMode.Parallel2Splits"/> or <see cref="Godot.DirectionalLight.ShadowMode.Parallel4Splits"/>.</para>
        /// </summary>
        public float DirectionalShadowSplit2
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((Light.Param)11);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((Light.Param)11, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The distance from shadow split 2 to split 3. Relative to <see cref="Godot.DirectionalLight.DirectionalShadowMaxDistance"/>. Only used when <see cref="Godot.DirectionalLight.DirectionalShadowMode"/> is <see cref="Godot.DirectionalLight.ShadowMode.Parallel4Splits"/>.</para>
        /// </summary>
        public float DirectionalShadowSplit3
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((Light.Param)12);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((Light.Param)12, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, shadow detail is sacrificed in exchange for smoother transitions between splits. Enabling shadow blend splitting also has a moderate performance cost. This is ignored when <see cref="Godot.DirectionalLight.DirectionalShadowMode"/> is <see cref="Godot.DirectionalLight.ShadowMode.Orthogonal"/>.</para>
        /// </summary>
        public bool DirectionalShadowBlendSplits
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsBlendSplitsEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendSplits(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Can be used to fix special cases of self shadowing when objects are perpendicular to the light.</para>
        /// </summary>
        public float DirectionalShadowNormalBias
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((Light.Param)13);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((Light.Param)13, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Amount of extra bias for shadow splits that are far away. If self-shadowing occurs only on the splits far away, increasing this value can fix them. This is ignored when <see cref="Godot.DirectionalLight.DirectionalShadowMode"/> is <see cref="Godot.DirectionalLight.ShadowMode.Orthogonal"/>.</para>
        /// </summary>
        public float DirectionalShadowBiasSplitScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((Light.Param)15);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((Light.Param)15, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Optimizes shadow rendering for detail versus movement. See <see cref="Godot.DirectionalLight.ShadowDepthRange"/>.</para>
        /// </summary>
        public DirectionalLight.ShadowDepthRange DirectionalShadowDepthRange
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShadowDepthRange();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShadowDepthRange(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum distance for shadow splits. Increasing this value will make directional shadows visible from further away, at the cost of lower overall shadow detail and performance (since more objects need to be included in the directional shadow rendering).</para>
        /// </summary>
        public float DirectionalShadowMaxDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((Light.Param)9);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((Light.Param)9, value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "DirectionalLight";

        public DirectionalLight() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_DirectionalLight_Ctor(this);
        }

        internal DirectionalLight(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shadow_mode");

        [GodotMethod("set_shadow_mode")]
        [Obsolete("SetShadowMode is deprecated. Use the DirectionalShadowMode property instead.")]
        public void SetShadowMode(DirectionalLight.ShadowMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shadow_mode");

        [GodotMethod("get_shadow_mode")]
        [Obsolete("GetShadowMode is deprecated. Use the DirectionalShadowMode property instead.")]
        public DirectionalLight.ShadowMode GetShadowMode()
        {
            return (DirectionalLight.ShadowMode)NativeCalls.godot_icall_0_362(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shadow_depth_range");

        [GodotMethod("set_shadow_depth_range")]
        [Obsolete("SetShadowDepthRange is deprecated. Use the DirectionalShadowDepthRange property instead.")]
        public void SetShadowDepthRange(DirectionalLight.ShadowDepthRange mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shadow_depth_range");

        [GodotMethod("get_shadow_depth_range")]
        [Obsolete("GetShadowDepthRange is deprecated. Use the DirectionalShadowDepthRange property instead.")]
        public DirectionalLight.ShadowDepthRange GetShadowDepthRange()
        {
            return (DirectionalLight.ShadowDepthRange)NativeCalls.godot_icall_0_363(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_blend_splits");

        [GodotMethod("set_blend_splits")]
        [Obsolete("SetBlendSplits is deprecated. Use the DirectionalShadowBlendSplits property instead.")]
        public void SetBlendSplits(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_blend_splits_enabled");

        [GodotMethod("is_blend_splits_enabled")]
        [Obsolete("IsBlendSplitsEnabled is deprecated. Use the DirectionalShadowBlendSplits property instead.")]
        public bool IsBlendSplitsEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
