using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Creating a reference to a <see cref="Godot.VisualShaderNodeUniform"/> allows you to reuse this uniform in different shaders or shader stages easily.</para>
    /// </summary>
    public partial class VisualShaderNodeUniformRef : VisualShaderNode
    {
        /// <summary>
        /// <para>The name of the uniform which this reference points to.</para>
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

        private const string nativeName = "VisualShaderNodeUniformRef";

        public VisualShaderNodeUniformRef() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeUniformRef_Ctor(this);
        }

        internal VisualShaderNodeUniformRef(bool memoryOwn) : base(memoryOwn) {}

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
