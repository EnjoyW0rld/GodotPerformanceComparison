using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class VisualShaderNodeScalarOp : VisualShaderNode
    {
        public enum OperatorEnum
        {
            Add = 0,
            Sub = 1,
            Mul = 2,
            Div = 3,
            Mod = 4,
            Pow = 5,
            Max = 6,
            Min = 7,
            Atan2 = 8,
            Step = 9
        }

        public VisualShaderNodeScalarOp.OperatorEnum Operator
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOperator();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOperator(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualShaderNodeScalarOp";

        public VisualShaderNodeScalarOp() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeScalarOp_Ctor(this);
        }

        internal VisualShaderNodeScalarOp(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_operator");

        [GodotMethod("set_operator")]
        [Obsolete("SetOperator is deprecated. Use the Operator property instead.")]
        public void SetOperator(VisualShaderNodeScalarOp.OperatorEnum op)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)op);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_operator");

        [GodotMethod("get_operator")]
        [Obsolete("GetOperator is deprecated. Use the Operator property instead.")]
        public VisualShaderNodeScalarOp.OperatorEnum GetOperator()
        {
            return (VisualShaderNodeScalarOp.OperatorEnum)NativeCalls.godot_icall_0_1138(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
