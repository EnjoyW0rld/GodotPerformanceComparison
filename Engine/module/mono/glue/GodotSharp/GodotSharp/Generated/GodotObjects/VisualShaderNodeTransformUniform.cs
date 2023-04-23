using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Translated to <c>uniform mat4</c> in the shader language.</para>
    /// </summary>
    public partial class VisualShaderNodeTransformUniform : VisualShaderNodeUniform
    {
        /// <summary>
        /// <para>Enables usage of the <see cref="Godot.VisualShaderNodeTransformUniform.DefaultValue"/>.</para>
        /// </summary>
        public bool DefaultValueEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDefaultValueEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDefaultValueEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A default value to be assigned within the shader.</para>
        /// </summary>
        public Transform DefaultValue
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDefaultValue();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDefaultValue(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualShaderNodeTransformUniform";

        public VisualShaderNodeTransformUniform() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeTransformUniform_Ctor(this);
        }

        internal VisualShaderNodeTransformUniform(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_default_value_enabled");

        [GodotMethod("set_default_value_enabled")]
        [Obsolete("SetDefaultValueEnabled is deprecated. Use the DefaultValueEnabled property instead.")]
        public void SetDefaultValueEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_default_value_enabled");

        [GodotMethod("is_default_value_enabled")]
        [Obsolete("IsDefaultValueEnabled is deprecated. Use the DefaultValueEnabled property instead.")]
        public bool IsDefaultValueEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_default_value");

        [GodotMethod("set_default_value")]
        [Obsolete("SetDefaultValue is deprecated. Use the DefaultValue property instead.")]
        public void SetDefaultValue(Transform value)
        {
            NativeCalls.godot_icall_1_202(method_bind_2, Object.GetPtr(this), ref value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_default_value");

        [GodotMethod("get_default_value")]
        [Obsolete("GetDefaultValue is deprecated. Use the DefaultValue property instead.")]
        public Transform GetDefaultValue()
        {
            NativeCalls.godot_icall_0_22(method_bind_3, Object.GetPtr(this), out Transform argRet); return (Transform)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
