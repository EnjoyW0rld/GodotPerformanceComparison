using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A uniform represents a variable in the shader which is set externally, i.e. from the <see cref="Godot.ShaderMaterial"/>. Uniforms are exposed as properties in the <see cref="Godot.ShaderMaterial"/> and can be assigned from the inspector or from a script.</para>
    /// </summary>
    public abstract partial class VisualShaderNodeUniform : VisualShaderNode
    {
        /// <summary>
        /// <para>Name of the uniform, by which it can be accessed through the <see cref="Godot.ShaderMaterial"/> properties.</para>
        /// </summary>
        public string UniformName
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUniformName();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUniformName(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualShaderNodeUniform";

        internal VisualShaderNodeUniform() {}

        internal VisualShaderNodeUniform(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_uniform_name");

        [GodotMethod("set_uniform_name")]
        [Obsolete("SetUniformName is deprecated. Use the UniformName property instead.")]
        public void SetUniformName(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_uniform_name");

        [GodotMethod("get_uniform_name")]
        [Obsolete("GetUniformName is deprecated. Use the UniformName property instead.")]
        public string GetUniformName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
