using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A visual shader node able to perform different functions using vectors.</para>
    /// </summary>
    public partial class VisualShaderNodeVectorFunc : VisualShaderNode
    {
        public enum FunctionEnum
        {
            /// <summary>
            /// <para>Normalizes the vector so that it has a length of <c>1</c> but points in the same direction.</para>
            /// </summary>
            Normalize = 0,
            /// <summary>
            /// <para>Clamps the value between <c>0.0</c> and <c>1.0</c>.</para>
            /// </summary>
            Saturate = 1,
            /// <summary>
            /// <para>Returns the opposite value of the parameter.</para>
            /// </summary>
            Negate = 2,
            /// <summary>
            /// <para>Returns <c>1/vector</c>.</para>
            /// </summary>
            Reciprocal = 3,
            /// <summary>
            /// <para>Converts RGB vector to HSV equivalent.</para>
            /// </summary>
            Rgb2hsv = 4,
            /// <summary>
            /// <para>Converts HSV vector to RGB equivalent.</para>
            /// </summary>
            Hsv2rgb = 5,
            /// <summary>
            /// <para>Returns the absolute value of the parameter.</para>
            /// </summary>
            Abs = 6,
            /// <summary>
            /// <para>Returns the arc-cosine of the parameter.</para>
            /// </summary>
            Acos = 7,
            /// <summary>
            /// <para>Returns the inverse hyperbolic cosine of the parameter.</para>
            /// </summary>
            Acosh = 8,
            /// <summary>
            /// <para>Returns the arc-sine of the parameter.</para>
            /// </summary>
            Asin = 9,
            /// <summary>
            /// <para>Returns the inverse hyperbolic sine of the parameter.</para>
            /// </summary>
            Asinh = 10,
            /// <summary>
            /// <para>Returns the arc-tangent of the parameter.</para>
            /// </summary>
            Atan = 11,
            /// <summary>
            /// <para>Returns the inverse hyperbolic tangent of the parameter.</para>
            /// </summary>
            Atanh = 12,
            /// <summary>
            /// <para>Finds the nearest integer that is greater than or equal to the parameter.</para>
            /// </summary>
            Ceil = 13,
            /// <summary>
            /// <para>Returns the cosine of the parameter.</para>
            /// </summary>
            Cos = 14,
            /// <summary>
            /// <para>Returns the hyperbolic cosine of the parameter.</para>
            /// </summary>
            Cosh = 15,
            /// <summary>
            /// <para>Converts a quantity in radians to degrees.</para>
            /// </summary>
            Degrees = 16,
            /// <summary>
            /// <para>Base-e Exponential.</para>
            /// </summary>
            Exp = 17,
            /// <summary>
            /// <para>Base-2 Exponential.</para>
            /// </summary>
            Exp2 = 18,
            /// <summary>
            /// <para>Finds the nearest integer less than or equal to the parameter.</para>
            /// </summary>
            Floor = 19,
            /// <summary>
            /// <para>Computes the fractional part of the argument.</para>
            /// </summary>
            Frac = 20,
            /// <summary>
            /// <para>Returns the inverse of the square root of the parameter.</para>
            /// </summary>
            InverseSqrt = 21,
            /// <summary>
            /// <para>Natural logarithm.</para>
            /// </summary>
            Log = 22,
            /// <summary>
            /// <para>Base-2 logarithm.</para>
            /// </summary>
            Log2 = 23,
            /// <summary>
            /// <para>Converts a quantity in degrees to radians.</para>
            /// </summary>
            Radians = 24,
            /// <summary>
            /// <para>Finds the nearest integer to the parameter.</para>
            /// </summary>
            Round = 25,
            /// <summary>
            /// <para>Finds the nearest even integer to the parameter.</para>
            /// </summary>
            Roundeven = 26,
            /// <summary>
            /// <para>Extracts the sign of the parameter, i.e. returns <c>-1</c> if the parameter is negative, <c>1</c> if it's positive and <c>0</c> otherwise.</para>
            /// </summary>
            Sign = 27,
            /// <summary>
            /// <para>Returns the sine of the parameter.</para>
            /// </summary>
            Sin = 28,
            /// <summary>
            /// <para>Returns the hyperbolic sine of the parameter.</para>
            /// </summary>
            Sinh = 29,
            /// <summary>
            /// <para>Returns the square root of the parameter.</para>
            /// </summary>
            Sqrt = 30,
            /// <summary>
            /// <para>Returns the tangent of the parameter.</para>
            /// </summary>
            Tan = 31,
            /// <summary>
            /// <para>Returns the hyperbolic tangent of the parameter.</para>
            /// </summary>
            Tanh = 32,
            /// <summary>
            /// <para>Returns a value equal to the nearest integer to the parameter whose absolute value is not larger than the absolute value of the parameter.</para>
            /// </summary>
            Trunc = 33,
            /// <summary>
            /// <para>Returns <c>1.0 - vector</c>.</para>
            /// </summary>
            Oneminus = 34
        }

        /// <summary>
        /// <para>The function to be performed. See <see cref="Godot.VisualShaderNodeVectorFunc.FunctionEnum"/> for options.</para>
        /// </summary>
        public VisualShaderNodeVectorFunc.FunctionEnum Function
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

        private const string nativeName = "VisualShaderNodeVectorFunc";

        public VisualShaderNodeVectorFunc() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeVectorFunc_Ctor(this);
        }

        internal VisualShaderNodeVectorFunc(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_function");

        [GodotMethod("set_function")]
        [Obsolete("SetFunction is deprecated. Use the Function property instead.")]
        public void SetFunction(VisualShaderNodeVectorFunc.FunctionEnum func)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)func);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_function");

        [GodotMethod("get_function")]
        [Obsolete("GetFunction is deprecated. Use the Function property instead.")]
        public VisualShaderNodeVectorFunc.FunctionEnum GetFunction()
        {
            return (VisualShaderNodeVectorFunc.FunctionEnum)NativeCalls.godot_icall_0_1148(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
