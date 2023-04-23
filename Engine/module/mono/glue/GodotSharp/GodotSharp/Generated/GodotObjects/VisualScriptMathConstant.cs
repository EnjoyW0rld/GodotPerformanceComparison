using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Provides common math constants, such as Pi, on an output Data port.</para>
    /// <para>Input Ports:</para>
    /// <para>none</para>
    /// <para>Output Ports:</para>
    /// <para>- Data (variant): <c>get</c></para>
    /// </summary>
    public partial class VisualScriptMathConstant : VisualScriptNode
    {
        public enum MathConstant
        {
            /// <summary>
            /// <para>Unity: <c>1</c>.</para>
            /// </summary>
            One = 0,
            /// <summary>
            /// <para>Pi: <c>3.141593</c>.</para>
            /// </summary>
            Pi = 1,
            /// <summary>
            /// <para>Pi divided by two: <c>1.570796</c>.</para>
            /// </summary>
            HalfPi = 2,
            /// <summary>
            /// <para>Tau: <c>6.283185</c>.</para>
            /// </summary>
            Tau = 3,
            /// <summary>
            /// <para>Mathematical constant <c>e</c>, the natural log base: <c>2.718282</c>.</para>
            /// </summary>
            E = 4,
            /// <summary>
            /// <para>Square root of two: <c>1.414214</c>.</para>
            /// </summary>
            Sqrt2 = 5,
            /// <summary>
            /// <para>Infinity: <c>inf</c>.</para>
            /// </summary>
            Inf = 6,
            /// <summary>
            /// <para>Not a number: <c>nan</c>.</para>
            /// </summary>
            Nan = 7,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.VisualScriptMathConstant.MathConstant"/> enum.</para>
            /// </summary>
            Max = 8
        }

        /// <summary>
        /// <para>The math constant.</para>
        /// </summary>
        public VisualScriptMathConstant.MathConstant Constant
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMathConstant();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMathConstant(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptMathConstant";

        public VisualScriptMathConstant() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptMathConstant_Ctor(this);
        }

        internal VisualScriptMathConstant(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_math_constant");

        [GodotMethod("set_math_constant")]
        [Obsolete("SetMathConstant is deprecated. Use the Constant property instead.")]
        public void SetMathConstant(VisualScriptMathConstant.MathConstant which)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)which);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_math_constant");

        [GodotMethod("get_math_constant")]
        [Obsolete("GetMathConstant is deprecated. Use the Constant property instead.")]
        public VisualScriptMathConstant.MathConstant GetMathConstant()
        {
            return (VisualScriptMathConstant.MathConstant)NativeCalls.godot_icall_0_1037(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
