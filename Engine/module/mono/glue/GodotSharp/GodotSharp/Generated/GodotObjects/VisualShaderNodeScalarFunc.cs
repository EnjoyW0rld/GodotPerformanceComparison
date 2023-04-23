using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class VisualShaderNodeScalarFunc : VisualShaderNode
    {
        public enum FunctionEnum
        {
            Sin = 0,
            Cos = 1,
            Tan = 2,
            Asin = 3,
            Acos = 4,
            Atan = 5,
            Sinh = 6,
            Cosh = 7,
            Tanh = 8,
            Log = 9,
            Exp = 10,
            Sqrt = 11,
            Abs = 12,
            Sign = 13,
            Floor = 14,
            Round = 15,
            Ceil = 16,
            Frac = 17,
            Saturate = 18,
            Negate = 19,
            Acosh = 20,
            Asinh = 21,
            Atanh = 22,
            Degrees = 23,
            Exp2 = 24,
            InverseSqrt = 25,
            Log2 = 26,
            Radians = 27,
            Reciprocal = 28,
            Roundeven = 29,
            Trunc = 30,
            Oneminus = 31
        }

        public VisualShaderNodeScalarFunc.FunctionEnum Function
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFunction();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFunction(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualShaderNodeScalarFunc";

        public VisualShaderNodeScalarFunc() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeScalarFunc_Ctor(this);
        }

        internal VisualShaderNodeScalarFunc(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_function");

        [GodotMethod("set_function")]
        [Obsolete("SetFunction is deprecated. Use the Function property instead.")]
        public void SetFunction(VisualShaderNodeScalarFunc.FunctionEnum func)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)func);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_function");

        [GodotMethod("get_function")]
        [Obsolete("GetFunction is deprecated. Use the Function property instead.")]
        public VisualShaderNodeScalarFunc.FunctionEnum GetFunction()
        {
            return (VisualShaderNodeScalarFunc.FunctionEnum)NativeCalls.godot_icall_0_1137(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
