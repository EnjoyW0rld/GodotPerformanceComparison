using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A built-in function used inside a <see cref="Godot.VisualScript"/>. It is usually a math function or an utility function.</para>
    /// <para>See also <c>@GDScript</c>, for the same functions in the GDScript language.</para>
    /// </summary>
    public partial class VisualScriptBuiltinFunc : VisualScriptNode
    {
        public enum BuiltinFunc
        {
            /// <summary>
            /// <para>Return the sine of the input.</para>
            /// </summary>
            MathSin = 0,
            /// <summary>
            /// <para>Return the cosine of the input.</para>
            /// </summary>
            MathCos = 1,
            /// <summary>
            /// <para>Return the tangent of the input.</para>
            /// </summary>
            MathTan = 2,
            /// <summary>
            /// <para>Return the hyperbolic sine of the input.</para>
            /// </summary>
            MathSinh = 3,
            /// <summary>
            /// <para>Return the hyperbolic cosine of the input.</para>
            /// </summary>
            MathCosh = 4,
            /// <summary>
            /// <para>Return the hyperbolic tangent of the input.</para>
            /// </summary>
            MathTanh = 5,
            /// <summary>
            /// <para>Return the arc sine of the input.</para>
            /// </summary>
            MathAsin = 6,
            /// <summary>
            /// <para>Return the arc cosine of the input.</para>
            /// </summary>
            MathAcos = 7,
            /// <summary>
            /// <para>Return the arc tangent of the input.</para>
            /// </summary>
            MathAtan = 8,
            /// <summary>
            /// <para>Return the arc tangent of the input, using the signs of both parameters to determine the exact angle.</para>
            /// </summary>
            MathAtan2 = 9,
            /// <summary>
            /// <para>Return the square root of the input.</para>
            /// </summary>
            MathSqrt = 10,
            /// <summary>
            /// <para>Return the remainder of one input divided by the other, using floating-point numbers.</para>
            /// </summary>
            MathFmod = 11,
            /// <summary>
            /// <para>Return the positive remainder of one input divided by the other, using floating-point numbers.</para>
            /// </summary>
            MathFposmod = 12,
            /// <summary>
            /// <para>Return the input rounded down.</para>
            /// </summary>
            MathFloor = 13,
            /// <summary>
            /// <para>Return the input rounded up.</para>
            /// </summary>
            MathCeil = 14,
            /// <summary>
            /// <para>Return the input rounded to the nearest integer.</para>
            /// </summary>
            MathRound = 15,
            /// <summary>
            /// <para>Return the absolute value of the input.</para>
            /// </summary>
            MathAbs = 16,
            /// <summary>
            /// <para>Return the sign of the input, turning it into 1, -1, or 0. Useful to determine if the input is positive or negative.</para>
            /// </summary>
            MathSign = 17,
            /// <summary>
            /// <para>Return the input raised to a given power.</para>
            /// </summary>
            MathPow = 18,
            /// <summary>
            /// <para>Return the natural logarithm of the input. Note that this is not the typical base-10 logarithm function calculators use.</para>
            /// </summary>
            MathLog = 19,
            /// <summary>
            /// <para>Return the mathematical constant e raised to the specified power of the input. e has an approximate value of 2.71828.</para>
            /// </summary>
            MathExp = 20,
            /// <summary>
            /// <para>Return whether the input is NaN (Not a Number) or not. NaN is usually produced by dividing 0 by 0, though other ways exist.</para>
            /// </summary>
            MathIsnan = 21,
            /// <summary>
            /// <para>Return whether the input is an infinite floating-point number or not. Infinity is usually produced by dividing a number by 0, though other ways exist.</para>
            /// </summary>
            MathIsinf = 22,
            /// <summary>
            /// <para>Easing function, based on exponent. 0 is constant, 1 is linear, 0 to 1 is ease-in, 1+ is ease out. Negative values are in-out/out in.</para>
            /// </summary>
            MathEase = 23,
            /// <summary>
            /// <para>Return the number of digit places after the decimal that the first non-zero digit occurs.</para>
            /// </summary>
            MathDecimals = 24,
            /// <summary>
            /// <para>Return the input snapped to a given step.</para>
            /// </summary>
            MathStepify = 25,
            /// <summary>
            /// <para>Return a number linearly interpolated between the first two inputs, based on the third input. Uses the formula <c>a + (a - b) * t</c>.</para>
            /// </summary>
            MathLerp = 26,
            MathInverseLerp = 27,
            MathRangeLerp = 28,
            /// <summary>
            /// <para>Moves the number toward a value, based on the third input.</para>
            /// </summary>
            MathMoveToward = 29,
            /// <summary>
            /// <para>Return the result of <c>value</c> decreased by <c>step</c> * <c>amount</c>.</para>
            /// </summary>
            MathDectime = 30,
            /// <summary>
            /// <para>Randomize the seed (or the internal state) of the random number generator. Current implementation reseeds using a number based on time.</para>
            /// </summary>
            MathRandomize = 31,
            /// <summary>
            /// <para>Return a random 32 bits integer value. To obtain a random value between 0 to N (where N is smaller than 2^32 - 1), you can use it with the remainder function.</para>
            /// </summary>
            MathRand = 32,
            /// <summary>
            /// <para>Return a random floating-point value between 0 and 1. To obtain a random value between 0 to N, you can use it with multiplication.</para>
            /// </summary>
            MathRandf = 33,
            /// <summary>
            /// <para>Return a random floating-point value between the two inputs.</para>
            /// </summary>
            MathRandom = 34,
            /// <summary>
            /// <para>Set the seed for the random number generator.</para>
            /// </summary>
            MathSeed = 35,
            /// <summary>
            /// <para>Return a random value from the given seed, along with the new seed.</para>
            /// </summary>
            MathRandseed = 36,
            /// <summary>
            /// <para>Convert the input from degrees to radians.</para>
            /// </summary>
            MathDeg2rad = 37,
            /// <summary>
            /// <para>Convert the input from radians to degrees.</para>
            /// </summary>
            MathRad2deg = 38,
            /// <summary>
            /// <para>Convert the input from linear volume to decibel volume.</para>
            /// </summary>
            MathLinear2db = 39,
            /// <summary>
            /// <para>Convert the input from decibel volume to linear volume.</para>
            /// </summary>
            MathDb2linear = 40,
            /// <summary>
            /// <para>Converts a 2D point expressed in the polar coordinate system (a distance from the origin <c>r</c> and an angle <c>th</c>) to the cartesian coordinate system (X and Y axis).</para>
            /// </summary>
            MathPolar2cartesian = 41,
            /// <summary>
            /// <para>Converts a 2D point expressed in the cartesian coordinate system (X and Y axis) to the polar coordinate system (a distance from the origin and an angle).</para>
            /// </summary>
            MathCartesian2polar = 42,
            MathWrap = 43,
            MathWrapf = 44,
            /// <summary>
            /// <para>Return the greater of the two numbers, also known as their maximum.</para>
            /// </summary>
            LogicMax = 45,
            /// <summary>
            /// <para>Return the lesser of the two numbers, also known as their minimum.</para>
            /// </summary>
            LogicMin = 46,
            /// <summary>
            /// <para>Return the input clamped inside the given range, ensuring the result is never outside it. Equivalent to <c>min(max(input, range_low), range_high)</c>.</para>
            /// </summary>
            LogicClamp = 47,
            /// <summary>
            /// <para>Return the nearest power of 2 to the input.</para>
            /// </summary>
            LogicNearestPo2 = 48,
            /// <summary>
            /// <para>Create a <see cref="Godot.WeakRef"/> from the input.</para>
            /// </summary>
            ObjWeakref = 49,
            /// <summary>
            /// <para>Create a <see cref="Godot.FuncRef"/> from the input.</para>
            /// </summary>
            FuncFuncref = 50,
            /// <summary>
            /// <para>Convert between types.</para>
            /// </summary>
            TypeConvert = 51,
            /// <summary>
            /// <para>Return the type of the input as an integer. Check <see cref="Godot.Variant.Type"/> for the integers that might be returned.</para>
            /// </summary>
            TypeOf = 52,
            /// <summary>
            /// <para>Checks if a type is registered in the <see cref="Godot.ClassDB"/>.</para>
            /// </summary>
            TypeExists = 53,
            /// <summary>
            /// <para>Return a character with the given ascii value.</para>
            /// </summary>
            TextChar = 54,
            /// <summary>
            /// <para>Convert the input to a string.</para>
            /// </summary>
            TextStr = 55,
            /// <summary>
            /// <para>Print the given string to the output window.</para>
            /// </summary>
            TextPrint = 56,
            /// <summary>
            /// <para>Print the given string to the standard error output.</para>
            /// </summary>
            TextPrinterr = 57,
            /// <summary>
            /// <para>Print the given string to the standard output, without adding a newline.</para>
            /// </summary>
            TextPrintraw = 58,
            /// <summary>
            /// <para>Serialize a <c>Variant</c> to a string.</para>
            /// </summary>
            VarToStr = 59,
            /// <summary>
            /// <para>Deserialize a <c>Variant</c> from a string serialized using <see cref="Godot.VisualScriptBuiltinFunc.BuiltinFunc.VarToStr"/>.</para>
            /// </summary>
            StrToVar = 60,
            /// <summary>
            /// <para>Serialize a <c>Variant</c> to a <see cref="byte"/>.</para>
            /// </summary>
            VarToBytes = 61,
            /// <summary>
            /// <para>Deserialize a <c>Variant</c> from a <see cref="byte"/> serialized using <see cref="Godot.VisualScriptBuiltinFunc.BuiltinFunc.VarToBytes"/>.</para>
            /// </summary>
            BytesToVar = 62,
            /// <summary>
            /// <para>Return the <see cref="Godot.Color"/> with the given name and alpha ranging from 0 to 1.</para>
            /// <para>Note: Names are defined in <c>color_names.inc</c>.</para>
            /// </summary>
            Colorn = 63,
            /// <summary>
            /// <para>Return a number smoothly interpolated between the first two inputs, based on the third input. Similar to <see cref="Godot.VisualScriptBuiltinFunc.BuiltinFunc.MathLerp"/>, but interpolates faster at the beginning and slower at the end. Using Hermite interpolation formula:</para>
            /// <para><code>
            /// var t = clamp((weight - from) / (to - from), 0.0, 1.0)
            /// return t * t * (3.0 - 2.0 * t)
            /// </code></para>
            /// </summary>
            MathSmoothstep = 64,
            MathPosmod = 65,
            MathLerpAngle = 66,
            TextOrd = 67,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.VisualScriptBuiltinFunc.BuiltinFunc"/> enum.</para>
            /// </summary>
            FuncMax = 68
        }

        /// <summary>
        /// <para>The function to be executed.</para>
        /// </summary>
        public VisualScriptBuiltinFunc.BuiltinFunc Function
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFunc();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFunc(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptBuiltinFunc";

        public VisualScriptBuiltinFunc() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptBuiltinFunc_Ctor(this);
        }

        internal VisualScriptBuiltinFunc(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_func");

        [GodotMethod("set_func")]
        [Obsolete("SetFunc is deprecated. Use the Function property instead.")]
        public void SetFunc(VisualScriptBuiltinFunc.BuiltinFunc which)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)which);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_func");

        [GodotMethod("get_func")]
        [Obsolete("GetFunc is deprecated. Use the Function property instead.")]
        public VisualScriptBuiltinFunc.BuiltinFunc GetFunc()
        {
            return (VisualScriptBuiltinFunc.BuiltinFunc)NativeCalls.godot_icall_0_1031(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
