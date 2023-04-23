using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This node is only available in <c>Fragment</c> and <c>Light</c> visual shaders.</para>
    /// </summary>
    public partial class VisualShaderNodeScalarDerivativeFunc : VisualShaderNode
    {
        public enum FunctionEnum
        {
            /// <summary>
            /// <para>Sum of absolute derivative in <c>x</c> and <c>y</c>.</para>
            /// </summary>
            Sum = 0,
            /// <summary>
            /// <para>Derivative in <c>x</c> using local differencing.</para>
            /// </summary>
            X = 1,
            /// <summary>
            /// <para>Derivative in <c>y</c> using local differencing.</para>
            /// </summary>
            Y = 2
        }

        /// <summary>
        /// <para>The derivative type. See <see cref="Godot.VisualShaderNodeScalarDerivativeFunc.FunctionEnum"/> for options.</para>
        /// </summary>
        public VisualShaderNodeScalarDerivativeFunc.FunctionEnum Function
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

        private const string nativeName = "VisualShaderNodeScalarDerivativeFunc";

        public VisualShaderNodeScalarDerivativeFunc() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeScalarDerivativeFunc_Ctor(this);
        }

        internal VisualShaderNodeScalarDerivativeFunc(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_function");

        [GodotMethod("set_function")]
        [Obsolete("SetFunction is deprecated. Use the Function property instead.")]
        public void SetFunction(VisualShaderNodeScalarDerivativeFunc.FunctionEnum func)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)func);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_function");

        [GodotMethod("get_function")]
        [Obsolete("GetFunction is deprecated. Use the Function property instead.")]
        public VisualShaderNodeScalarDerivativeFunc.FunctionEnum GetFunction()
        {
            return (VisualShaderNodeScalarDerivativeFunc.FunctionEnum)NativeCalls.godot_icall_0_1136(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
