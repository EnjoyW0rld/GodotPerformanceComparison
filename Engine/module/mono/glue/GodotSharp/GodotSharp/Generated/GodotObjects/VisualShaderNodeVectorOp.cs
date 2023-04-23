using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A visual shader node for use of vector operators. Operates on vector <c>a</c> and vector <c>b</c>.</para>
    /// </summary>
    public partial class VisualShaderNodeVectorOp : VisualShaderNode
    {
        public enum OperatorEnum
        {
            /// <summary>
            /// <para>Adds two vectors.</para>
            /// </summary>
            Add = 0,
            /// <summary>
            /// <para>Subtracts a vector from a vector.</para>
            /// </summary>
            Sub = 1,
            /// <summary>
            /// <para>Multiplies two vectors.</para>
            /// </summary>
            Mul = 2,
            /// <summary>
            /// <para>Divides vector by vector.</para>
            /// </summary>
            Div = 3,
            /// <summary>
            /// <para>Returns the remainder of the two vectors.</para>
            /// </summary>
            Mod = 4,
            /// <summary>
            /// <para>Returns the value of the first parameter raised to the power of the second, for each component of the vectors.</para>
            /// </summary>
            Pow = 5,
            /// <summary>
            /// <para>Returns the greater of two values, for each component of the vectors.</para>
            /// </summary>
            Max = 6,
            /// <summary>
            /// <para>Returns the lesser of two values, for each component of the vectors.</para>
            /// </summary>
            Min = 7,
            /// <summary>
            /// <para>Calculates the cross product of two vectors.</para>
            /// </summary>
            Cross = 8,
            /// <summary>
            /// <para>Returns the arc-tangent of the parameters.</para>
            /// </summary>
            Atan2 = 9,
            /// <summary>
            /// <para>Returns the vector that points in the direction of reflection. <c>a</c> is incident vector and <c>b</c> is the normal vector.</para>
            /// </summary>
            Reflect = 10,
            /// <summary>
            /// <para>Vector step operator. Returns <c>0.0</c> if <c>a</c> is smaller than <c>b</c> and <c>1.0</c> otherwise.</para>
            /// </summary>
            Step = 11
        }

        /// <summary>
        /// <para>The operator to be used. See <see cref="Godot.VisualShaderNodeVectorOp.OperatorEnum"/> for options.</para>
        /// </summary>
        public VisualShaderNodeVectorOp.OperatorEnum Operator
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

        private const string nativeName = "VisualShaderNodeVectorOp";

        public VisualShaderNodeVectorOp() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeVectorOp_Ctor(this);
        }

        internal VisualShaderNodeVectorOp(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_operator");

        [GodotMethod("set_operator")]
        [Obsolete("SetOperator is deprecated. Use the Operator property instead.")]
        public void SetOperator(VisualShaderNodeVectorOp.OperatorEnum op)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)op);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_operator");

        [GodotMethod("get_operator")]
        [Obsolete("GetOperator is deprecated. Use the Operator property instead.")]
        public VisualShaderNodeVectorOp.OperatorEnum GetOperator()
        {
            return (VisualShaderNodeVectorOp.OperatorEnum)NativeCalls.godot_icall_0_1149(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
