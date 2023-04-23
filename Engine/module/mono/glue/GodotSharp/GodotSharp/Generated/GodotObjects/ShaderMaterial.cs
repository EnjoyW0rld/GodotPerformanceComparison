using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A material that uses a custom <see cref="Godot.Shader"/> program to render either items to screen or process particles. You can create multiple materials for the same shader but configure different values for the uniforms defined in the shader.</para>
    /// <para>Note: Due to a renderer limitation, emissive <see cref="Godot.ShaderMaterial"/>s cannot emit light when used in a <see cref="Godot.GIProbe"/>. Only emissive <see cref="Godot.SpatialMaterial"/>s can emit light in a <see cref="Godot.GIProbe"/>.</para>
    /// </summary>
    public partial class ShaderMaterial : Material
    {
        /// <summary>
        /// <para>The <see cref="Godot.Shader"/> program used to render this material.</para>
        /// </summary>
        public Shader Shader
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShader();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShader(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ShaderMaterial";

        public ShaderMaterial() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ShaderMaterial_Ctor(this);
        }

        internal ShaderMaterial(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shader");

        [GodotMethod("set_shader")]
        [Obsolete("SetShader is deprecated. Use the Shader property instead.")]
        public void SetShader(Shader shader)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(shader));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shader");

        [GodotMethod("get_shader")]
        [Obsolete("GetShader is deprecated. Use the Shader property instead.")]
        public Shader GetShader()
        {
            return NativeCalls.godot_icall_0_853(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shader_param");

        /// <summary>
        /// <para>Changes the value set for this material of a uniform in the shader.</para>
        /// <para>Note: <c>param</c> must match the name of the uniform in the code exactly.</para>
        /// </summary>
        [GodotMethod("set_shader_param")]
        public void SetShaderParam(string param, object value)
        {
            NativeCalls.godot_icall_2_96(method_bind_2, Object.GetPtr(this), param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shader_param");

        /// <summary>
        /// <para>Returns the current value set for this material of a uniform in the shader.</para>
        /// </summary>
        [GodotMethod("get_shader_param")]
        public object GetShaderParam(string param)
        {
            return NativeCalls.godot_icall_1_97(method_bind_3, Object.GetPtr(this), param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "property_can_revert");

        /// <summary>
        /// <para>Returns <c>true</c> if the property identified by <c>name</c> can be reverted to a default value.</para>
        /// </summary>
        [GodotMethod("property_can_revert")]
        public bool PropertyCanRevert(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_4, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "property_get_revert");

        /// <summary>
        /// <para>Returns the default value of the material property with given <c>name</c>.</para>
        /// </summary>
        [GodotMethod("property_get_revert")]
        public object PropertyGetRevert(string name)
        {
            return NativeCalls.godot_icall_1_97(method_bind_5, Object.GetPtr(this), name);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
