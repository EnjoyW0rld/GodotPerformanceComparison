using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Light is the abstract base class for light nodes. As it can't be instanced, it shouldn't be used directly. Other types of light nodes inherit from it. Light contains the common variables and parameters used for lighting.</para>
    /// </summary>
    public abstract partial class Light : VisualInstance
    {
        public enum BakeMode
        {
            /// <summary>
            /// <para>Light is ignored when baking.</para>
            /// <para>Note: Hiding a light does not affect baking.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>Only indirect lighting will be baked (default).</para>
            /// </summary>
            Indirect = 1,
            /// <summary>
            /// <para>Both direct and indirect light will be baked.</para>
            /// <para>Note: You should hide the light if you don't want it to appear twice (dynamic and baked).</para>
            /// </summary>
            All = 2
        }

        public enum Param
        {
            /// <summary>
            /// <para>Constant for accessing <see cref="Godot.Light.LightEnergy"/>.</para>
            /// </summary>
            Energy = 0,
            /// <summary>
            /// <para>Constant for accessing <see cref="Godot.Light.LightIndirectEnergy"/>.</para>
            /// </summary>
            IndirectEnergy = 1,
            /// <summary>
            /// <para>Constant for accessing <see cref="Godot.Light.LightSize"/>.</para>
            /// </summary>
            Size = 2,
            /// <summary>
            /// <para>Constant for accessing <see cref="Godot.Light.LightSpecular"/>.</para>
            /// </summary>
            Specular = 3,
            /// <summary>
            /// <para>Constant for accessing <see cref="Godot.OmniLight.OmniRange"/> or <see cref="Godot.SpotLight.SpotRange"/>.</para>
            /// </summary>
            Range = 4,
            /// <summary>
            /// <para>Constant for accessing <see cref="Godot.OmniLight.OmniAttenuation"/> or <see cref="Godot.SpotLight.SpotAttenuation"/>.</para>
            /// </summary>
            Attenuation = 5,
            /// <summary>
            /// <para>Constant for accessing <see cref="Godot.SpotLight.SpotAngle"/>.</para>
            /// </summary>
            SpotAngle = 6,
            /// <summary>
            /// <para>Constant for accessing <see cref="Godot.SpotLight.SpotAngleAttenuation"/>.</para>
            /// </summary>
            SpotAttenuation = 7,
            /// <summary>
            /// <para>Constant for accessing <see cref="Godot.Light.ShadowContact"/>.</para>
            /// </summary>
            ContactShadowSize = 8,
            /// <summary>
            /// <para>Constant for accessing <see cref="Godot.DirectionalLight.DirectionalShadowMaxDistance"/>.</para>
            /// </summary>
            ShadowMaxDistance = 9,
            /// <summary>
            /// <para>Constant for accessing <see cref="Godot.DirectionalLight.DirectionalShadowSplit1"/>.</para>
            /// </summary>
            ShadowSplit1Offset = 10,
            /// <summary>
            /// <para>Constant for accessing <see cref="Godot.DirectionalLight.DirectionalShadowSplit2"/>.</para>
            /// </summary>
            ShadowSplit2Offset = 11,
            /// <summary>
            /// <para>Constant for accessing <see cref="Godot.DirectionalLight.DirectionalShadowSplit3"/>.</para>
            /// </summary>
            ShadowSplit3Offset = 12,
            /// <summary>
            /// <para>Constant for accessing <see cref="Godot.DirectionalLight.DirectionalShadowNormalBias"/>.</para>
            /// </summary>
            ShadowNormalBias = 13,
            /// <summary>
            /// <para>Constant for accessing <see cref="Godot.Light.ShadowBias"/>.</para>
            /// </summary>
            ShadowBias = 14,
            /// <summary>
            /// <para>Constant for accessing <see cref="Godot.DirectionalLight.DirectionalShadowBiasSplitScale"/>.</para>
            /// </summary>
            ShadowBiasSplitScale = 15,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.Light.Param"/> enum.</para>
            /// </summary>
            Max = 16
        }

        /// <summary>
        /// <para>The light's color. An overbright color can be used to achieve a result equivalent to increasing the light's <see cref="Godot.Light.LightEnergy"/>.</para>
        /// </summary>
        public Color LightColor
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
        /// <para>The light's strength multiplier (this is not a physical unit). For <see cref="Godot.OmniLight"/> and <see cref="Godot.SpotLight"/>, changing this value will only change the light color's intensity, not the light's radius.</para>
        /// </summary>
        public float LightEnergy
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((Light.Param)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((Light.Param)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Secondary multiplier used with indirect light (light bounces). This works on both <see cref="Godot.BakedLightmap"/> and <see cref="Godot.GIProbe"/>.</para>
        /// </summary>
        public float LightIndirectEnergy
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((Light.Param)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((Light.Param)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The size of the light in Godot units. Only considered in baked lightmaps and only if <see cref="Godot.Light.LightBakeMode"/> is set to <see cref="Godot.Light.BakeMode.All"/>. Increasing this value will make the shadows appear blurrier. This can be used to simulate area lights to an extent.</para>
        /// <para>Note: <see cref="Godot.Light.LightSize"/> is not affected by <see cref="Godot.Spatial.Scale"/> (the light's scale or its parent's scale).</para>
        /// </summary>
        public float LightSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((Light.Param)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((Light.Param)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the light's effect is reversed, darkening areas and casting bright shadows.</para>
        /// </summary>
        public bool LightNegative
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsNegative();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetNegative(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The intensity of the specular blob in objects affected by the light. At <c>0</c>, the light becomes a pure diffuse light. When not baking emission, this can be used to avoid unrealistic reflections when placing lights above an emissive surface.</para>
        /// </summary>
        public float LightSpecular
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((Light.Param)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((Light.Param)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The light's bake mode. See <see cref="Godot.Light.BakeMode"/>.</para>
        /// </summary>
        public Light.BakeMode LightBakeMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBakeMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBakeMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The light will affect objects in the selected layers.</para>
        /// </summary>
        public uint LightCullMask
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCullMask();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCullMask(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the light will cast shadows.</para>
        /// </summary>
        public bool ShadowEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return HasShadow();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShadow(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The color of shadows cast by this light.</para>
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
        /// <para>Used to adjust shadow appearance. Too small a value results in self-shadowing ("shadow acne"), while too large a value causes shadows to separate from casters ("peter-panning"). Adjust as needed.</para>
        /// </summary>
        public float ShadowBias
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((Light.Param)14);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((Light.Param)14, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Attempts to reduce <see cref="Godot.Light.ShadowBias"/> gap by rendering screen-space contact shadows. This has a performance impact, especially at higher values.</para>
        /// <para>Note: Contact shadows can look broken, so leaving this property to <c>0.0</c> is recommended.</para>
        /// </summary>
        public float ShadowContact
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((Light.Param)8);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((Light.Param)8, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, reverses the backface culling of the mesh. This can be useful when you have a flat mesh that has a light behind it. If you need to cast a shadow on both sides of the mesh, set the mesh to use double-sided shadows with <see cref="Godot.GeometryInstance.ShadowCastingSetting.DoubleSided"/>.</para>
        /// </summary>
        public bool ShadowReverseCullFace
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShadowReverseCullFace();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShadowReverseCullFace(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the light only appears in the editor and will not be visible at runtime.</para>
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

        private const string nativeName = "Light";

        internal Light() {}

        internal Light(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_editor_only");

        [GodotMethod("set_editor_only")]
        [Obsolete("SetEditorOnly is deprecated. Use the EditorOnly property instead.")]
        public void SetEditorOnly(bool editorOnly)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), editorOnly);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_editor_only");

        [GodotMethod("is_editor_only")]
        [Obsolete("IsEditorOnly is deprecated. Use the EditorOnly property instead.")]
        public bool IsEditorOnly()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_param");

        /// <summary>
        /// <para>Sets the value of the specified <see cref="Godot.Light.Param"/> parameter.</para>
        /// </summary>
        [GodotMethod("set_param")]
        [Obsolete("SetParam is deprecated. Use the ShadowContact property instead.")]
        public void SetParam(Light.Param param, float value)
        {
            NativeCalls.godot_icall_2_34(method_bind_2, Object.GetPtr(this), (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_param");

        /// <summary>
        /// <para>Returns the value of the specified <see cref="Godot.Light.Param"/> parameter.</para>
        /// </summary>
        [GodotMethod("get_param")]
        [Obsolete("GetParam is deprecated. Use the ShadowContact property instead.")]
        public float GetParam(Light.Param param)
        {
            return NativeCalls.godot_icall_1_12(method_bind_3, Object.GetPtr(this), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shadow");

        [GodotMethod("set_shadow")]
        [Obsolete("SetShadow is deprecated. Use the ShadowEnabled property instead.")]
        public void SetShadow(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_shadow");

        [GodotMethod("has_shadow")]
        [Obsolete("HasShadow is deprecated. Use the ShadowEnabled property instead.")]
        public bool HasShadow()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_negative");

        [GodotMethod("set_negative")]
        [Obsolete("SetNegative is deprecated. Use the LightNegative property instead.")]
        public void SetNegative(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_negative");

        [GodotMethod("is_negative")]
        [Obsolete("IsNegative is deprecated. Use the LightNegative property instead.")]
        public bool IsNegative()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cull_mask");

        [GodotMethod("set_cull_mask")]
        [Obsolete("SetCullMask is deprecated. Use the LightCullMask property instead.")]
        public void SetCullMask(uint cullMask)
        {
            NativeCalls.godot_icall_1_187(method_bind_8, Object.GetPtr(this), cullMask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cull_mask");

        [GodotMethod("get_cull_mask")]
        [Obsolete("GetCullMask is deprecated. Use the LightCullMask property instead.")]
        public uint GetCullMask()
        {
            return NativeCalls.godot_icall_0_188(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_color");

        [GodotMethod("set_color")]
        [Obsolete("SetColor is deprecated. Use the LightColor property instead.")]
        public void SetColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_10, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_color");

        [GodotMethod("get_color")]
        [Obsolete("GetColor is deprecated. Use the LightColor property instead.")]
        public Color GetColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_11, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shadow_reverse_cull_face");

        [GodotMethod("set_shadow_reverse_cull_face")]
        [Obsolete("SetShadowReverseCullFace is deprecated. Use the ShadowReverseCullFace property instead.")]
        public void SetShadowReverseCullFace(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_12, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shadow_reverse_cull_face");

        [GodotMethod("get_shadow_reverse_cull_face")]
        [Obsolete("GetShadowReverseCullFace is deprecated. Use the ShadowReverseCullFace property instead.")]
        public bool GetShadowReverseCullFace()
        {
            return NativeCalls.godot_icall_0_7(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shadow_color");

        [GodotMethod("set_shadow_color")]
        [Obsolete("SetShadowColor is deprecated. Use the ShadowColor property instead.")]
        public void SetShadowColor(Color shadowColor)
        {
            NativeCalls.godot_icall_1_199(method_bind_14, Object.GetPtr(this), ref shadowColor);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shadow_color");

        [GodotMethod("get_shadow_color")]
        [Obsolete("GetShadowColor is deprecated. Use the ShadowColor property instead.")]
        public Color GetShadowColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_15, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bake_mode");

        [GodotMethod("set_bake_mode")]
        [Obsolete("SetBakeMode is deprecated. Use the LightBakeMode property instead.")]
        public void SetBakeMode(Light.BakeMode bakeMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_16, Object.GetPtr(this), (int)bakeMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bake_mode");

        [GodotMethod("get_bake_mode")]
        [Obsolete("GetBakeMode is deprecated. Use the LightBakeMode property instead.")]
        public Light.BakeMode GetBakeMode()
        {
            return (Light.BakeMode)NativeCalls.godot_icall_0_582(method_bind_17, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
