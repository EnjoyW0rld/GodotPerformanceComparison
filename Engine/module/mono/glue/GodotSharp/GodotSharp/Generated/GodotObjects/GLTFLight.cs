using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Note: This class is only compiled in editor builds. Run-time glTF loading and saving is not available in exported projects. References to <see cref="Godot.GLTFLight"/> within a script will cause an error in an exported project.</para>
    /// </summary>
    public partial class GLTFLight : Resource
    {
        /// <summary>
        /// <para>The <see cref="Godot.Color"/> of the light. Defaults to white. A black color causes the light to have no effect.</para>
        /// </summary>
        public Color Color
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
        /// <para>The intensity of the light. This is expressed in candelas (lumens per steradian) for point and spot lights, and lux (lumens per m²) for directional lights. When creating a Godot light, this value is converted to a unitless multiplier.</para>
        /// </summary>
        public float Intensity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetIntensity();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetIntensity(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The type of the light. The values accepted by Godot are "point", "spot", and "directional", which correspond to Godot's <see cref="Godot.OmniLight"/>, <see cref="Godot.SpotLight"/>, and <see cref="Godot.DirectionalLight"/> respectively.</para>
        /// </summary>
        public string Type
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetType();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetType(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The range of the light, beyond which the light has no effect. GLTF lights with no range defined behave like physical lights (which have infinite range). When creating a Godot light, the range is clamped to 4096.</para>
        /// </summary>
        public float Range
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRange();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRange(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The inner angle of the cone in a spotlight. Must be less than or equal to the outer cone angle.</para>
        /// <para>Within this angle, the light is at full brightness. Between the inner and outer cone angles, there is a transition from full brightness to zero brightness. When creating a Godot <see cref="Godot.SpotLight"/>, the ratio between the inner and outer cone angles is used to calculate the attenuation of the light.</para>
        /// </summary>
        public float InnerConeAngle
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInnerConeAngle();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInnerConeAngle(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The outer angle of the cone in a spotlight. Must be greater than or equal to the inner angle.</para>
        /// <para>At this angle, the light drops off to zero brightness. Between the inner and outer cone angles, there is a transition from full brightness to zero brightness. If this angle is a half turn, then the spotlight emits in all directions. When creating a Godot <see cref="Godot.SpotLight"/>, the outer cone angle is used as the angle of the spotlight.</para>
        /// </summary>
        public float OuterConeAngle
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOuterConeAngle();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOuterConeAngle(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "GLTFLight";

        public GLTFLight() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GLTFLight_Ctor(this);
        }

        internal GLTFLight(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_color");

        [GodotMethod("get_color")]
        [Obsolete("GetColor is deprecated. Use the Color property instead.")]
        public Color GetColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_0, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_color");

        [GodotMethod("set_color")]
        [Obsolete("SetColor is deprecated. Use the Color property instead.")]
        public void SetColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_1, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_intensity");

        [GodotMethod("get_intensity")]
        [Obsolete("GetIntensity is deprecated. Use the Intensity property instead.")]
        public float GetIntensity()
        {
            return NativeCalls.godot_icall_0_14(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_intensity");

        [GodotMethod("set_intensity")]
        [Obsolete("SetIntensity is deprecated. Use the Intensity property instead.")]
        public void SetIntensity(float intensity)
        {
            NativeCalls.godot_icall_1_15(method_bind_3, Object.GetPtr(this), intensity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_type");

        [GodotMethod("get_type")]
        [Obsolete("GetType is deprecated. Use the Type property instead.")]
        public string GetType()
        {
            return NativeCalls.godot_icall_0_6(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_type");

        [GodotMethod("set_type")]
        [Obsolete("SetType is deprecated. Use the Type property instead.")]
        public void SetType(string type)
        {
            NativeCalls.godot_icall_1_54(method_bind_5, Object.GetPtr(this), type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_range");

        [GodotMethod("get_range")]
        [Obsolete("GetRange is deprecated. Use the Range property instead.")]
        public float GetRange()
        {
            return NativeCalls.godot_icall_0_14(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_range");

        [GodotMethod("set_range")]
        [Obsolete("SetRange is deprecated. Use the Range property instead.")]
        public void SetRange(float range)
        {
            NativeCalls.godot_icall_1_15(method_bind_7, Object.GetPtr(this), range);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_inner_cone_angle");

        [GodotMethod("get_inner_cone_angle")]
        [Obsolete("GetInnerConeAngle is deprecated. Use the InnerConeAngle property instead.")]
        public float GetInnerConeAngle()
        {
            return NativeCalls.godot_icall_0_14(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_inner_cone_angle");

        [GodotMethod("set_inner_cone_angle")]
        [Obsolete("SetInnerConeAngle is deprecated. Use the InnerConeAngle property instead.")]
        public void SetInnerConeAngle(float innerConeAngle)
        {
            NativeCalls.godot_icall_1_15(method_bind_9, Object.GetPtr(this), innerConeAngle);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_outer_cone_angle");

        [GodotMethod("get_outer_cone_angle")]
        [Obsolete("GetOuterConeAngle is deprecated. Use the OuterConeAngle property instead.")]
        public float GetOuterConeAngle()
        {
            return NativeCalls.godot_icall_0_14(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_outer_cone_angle");

        [GodotMethod("set_outer_cone_angle")]
        [Obsolete("SetOuterConeAngle is deprecated. Use the OuterConeAngle property instead.")]
        public void SetOuterConeAngle(float outerConeAngle)
        {
            NativeCalls.godot_icall_1_15(method_bind_11, Object.GetPtr(this), outerConeAngle);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
