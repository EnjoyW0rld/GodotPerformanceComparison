using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class VisualShaderNodeScalarConstant : VisualShaderNode
    {
        public float Constant
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

        private const string nativeName = "VisualShaderNodeScalarConstant";

        public VisualShaderNodeScalarConstant() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeScalarConstant_Ctor(this);
        }

        internal VisualShaderNodeScalarConstant(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_constant");

        [GodotMethod("set_constant")]
        [Obsolete("SetConstant is deprecated. Use the Constant property instead.")]
        public void SetConstant(float value)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_constant");

        [GodotMethod("get_constant")]
        [Obsolete("GetConstant is deprecated. Use the Constant property instead.")]
        public float GetConstant()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
