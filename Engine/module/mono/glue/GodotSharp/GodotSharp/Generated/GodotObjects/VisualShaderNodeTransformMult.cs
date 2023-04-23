using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A multiplication operation on two transforms (4x4 matrices), with support for different multiplication operators.</para>
    /// </summary>
    public partial class VisualShaderNodeTransformMult : VisualShaderNode
    {
        public enum OperatorEnum
        {
            /// <summary>
            /// <para>Multiplies transform <c>a</c> by the transform <c>b</c>.</para>
            /// </summary>
            Axb = 0,
            /// <summary>
            /// <para>Multiplies transform <c>b</c> by the transform <c>a</c>.</para>
            /// </summary>
            Bxa = 1,
            /// <summary>
            /// <para>Performs a component-wise multiplication of transform <c>a</c> by the transform <c>b</c>.</para>
            /// </summary>
            AxbComp = 2,
            /// <summary>
            /// <para>Performs a component-wise multiplication of transform <c>b</c> by the transform <c>a</c>.</para>
            /// </summary>
            BxaComp = 3
        }

        /// <summary>
        /// <para>The multiplication type to be performed on the transforms. See <see cref="Godot.VisualShaderNodeTransformMult.OperatorEnum"/> for options.</para>
        /// </summary>
        public VisualShaderNodeTransformMult.OperatorEnum Operator
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

        private const string nativeName = "VisualShaderNodeTransformMult";

        public VisualShaderNodeTransformMult() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeTransformMult_Ctor(this);
        }

        internal VisualShaderNodeTransformMult(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_operator");

        [GodotMethod("set_operator")]
        [Obsolete("SetOperator is deprecated. Use the Operator property instead.")]
        public void SetOperator(VisualShaderNodeTransformMult.OperatorEnum op)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)op);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_operator");

        [GodotMethod("get_operator")]
        [Obsolete("GetOperator is deprecated. Use the Operator property instead.")]
        public VisualShaderNodeTransformMult.OperatorEnum GetOperator()
        {
            return (VisualShaderNodeTransformMult.OperatorEnum)NativeCalls.godot_icall_0_1145(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
