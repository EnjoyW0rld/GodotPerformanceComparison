using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A multiplication operation on a transform (4x4 matrix) and a vector, with support for different multiplication operators.</para>
    /// </summary>
    public partial class VisualShaderNodeTransformVecMult : VisualShaderNode
    {
        public enum OperatorEnum
        {
            /// <summary>
            /// <para>Multiplies transform <c>a</c> by the vector <c>b</c>.</para>
            /// </summary>
            Axb = 0,
            /// <summary>
            /// <para>Multiplies vector <c>b</c> by the transform <c>a</c>.</para>
            /// </summary>
            Bxa = 1,
            /// <summary>
            /// <para>Multiplies transform <c>a</c> by the vector <c>b</c>, skipping the last row and column of the transform.</para>
            /// </summary>
            Op3x3Axb = 2,
            /// <summary>
            /// <para>Multiplies vector <c>b</c> by the transform <c>a</c>, skipping the last row and column of the transform.</para>
            /// </summary>
            Op3x3Bxa = 3
        }

        /// <summary>
        /// <para>The multiplication type to be performed. See <see cref="Godot.VisualShaderNodeTransformVecMult.OperatorEnum"/> for options.</para>
        /// </summary>
        public VisualShaderNodeTransformVecMult.OperatorEnum Operator
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

        private const string nativeName = "VisualShaderNodeTransformVecMult";

        public VisualShaderNodeTransformVecMult() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeTransformVecMult_Ctor(this);
        }

        internal VisualShaderNodeTransformVecMult(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_operator");

        [GodotMethod("set_operator")]
        [Obsolete("SetOperator is deprecated. Use the Operator property instead.")]
        public void SetOperator(VisualShaderNodeTransformVecMult.OperatorEnum op)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)op);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_operator");

        [GodotMethod("get_operator")]
        [Obsolete("GetOperator is deprecated. Use the Operator property instead.")]
        public VisualShaderNodeTransformVecMult.OperatorEnum GetOperator()
        {
            return (VisualShaderNodeTransformVecMult.OperatorEnum)NativeCalls.godot_icall_0_1146(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
