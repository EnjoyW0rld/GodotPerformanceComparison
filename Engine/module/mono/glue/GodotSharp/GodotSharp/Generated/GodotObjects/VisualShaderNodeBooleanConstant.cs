using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Has only one output port and no inputs.</para>
    /// <para>Translated to <c>bool</c> in the shader language.</para>
    /// </summary>
    public partial class VisualShaderNodeBooleanConstant : VisualShaderNode
    {
        /// <summary>
        /// <para>A boolean constant which represents a state of this node.</para>
        /// </summary>
        public bool Constant
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetConstant();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetConstant(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualShaderNodeBooleanConstant";

        public VisualShaderNodeBooleanConstant() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeBooleanConstant_Ctor(this);
        }

        internal VisualShaderNodeBooleanConstant(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_constant");

        [GodotMethod("set_constant")]
        [Obsolete("SetConstant is deprecated. Use the Constant property instead.")]
        public void SetConstant(bool value)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_constant");

        [GodotMethod("get_constant")]
        [Obsolete("GetConstant is deprecated. Use the Constant property instead.")]
        public bool GetConstant()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
