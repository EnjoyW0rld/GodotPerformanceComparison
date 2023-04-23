using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Gives access to input variables (built-ins) available for the shader. See the shading reference for the list of available built-ins for each shader type (check <c>Tutorials</c> section for link).</para>
    /// </summary>
    public partial class VisualShaderNodeInput : VisualShaderNode
    {
        /// <summary>
        /// <para>One of the several input constants in lower-case style like: "vertex"(<c>VERTEX</c>) or "point_size"(<c>POINT_SIZE</c>).</para>
        /// </summary>
        public string InputName
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputName();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputName(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualShaderNodeInput";

        public VisualShaderNodeInput() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeInput_Ctor(this);
        }

        internal VisualShaderNodeInput(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_input_name");

        [GodotMethod("set_input_name")]
        [Obsolete("SetInputName is deprecated. Use the InputName property instead.")]
        public void SetInputName(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_input_name");

        [GodotMethod("get_input_name")]
        [Obsolete("GetInputName is deprecated. Use the InputName property instead.")]
        public string GetInputName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_input_real_name");

        [GodotMethod("get_input_real_name")]
        public string GetInputRealName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_2, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
