using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Applies <see cref="Godot.VisualShaderNodeColorOp.Operator"/> to two color inputs.</para>
    /// </summary>
    public partial class VisualShaderNodeColorOp : VisualShaderNode
    {
        public enum OperatorEnum
        {
            /// <summary>
            /// <para>Produce a screen effect with the following formula:</para>
            /// <para><code>
            /// result = vec3(1.0) - (vec3(1.0) - a) * (vec3(1.0) - b);
            /// </code></para>
            /// </summary>
            Screen = 0,
            /// <summary>
            /// <para>Produce a difference effect with the following formula:</para>
            /// <para><code>
            /// result = abs(a - b);
            /// </code></para>
            /// </summary>
            Difference = 1,
            /// <summary>
            /// <para>Produce a darken effect with the following formula:</para>
            /// <para><code>
            /// result = min(a, b);
            /// </code></para>
            /// </summary>
            Darken = 2,
            /// <summary>
            /// <para>Produce a lighten effect with the following formula:</para>
            /// <para><code>
            /// result = max(a, b);
            /// </code></para>
            /// </summary>
            Lighten = 3,
            /// <summary>
            /// <para>Produce an overlay effect with the following formula:</para>
            /// <para><code>
            /// for (int i = 0; i &lt; 3; i++) {
            ///     float base = a[i];
            ///     float blend = b[i];
            ///     if (base &lt; 0.5) {
            ///         result[i] = 2.0 * base * blend;
            ///     } else {
            ///         result[i] = 1.0 - 2.0 * (1.0 - blend) * (1.0 - base);
            ///     }
            /// }
            /// </code></para>
            /// </summary>
            Overlay = 4,
            /// <summary>
            /// <para>Produce a dodge effect with the following formula:</para>
            /// <para><code>
            /// result = a / (vec3(1.0) - b);
            /// </code></para>
            /// </summary>
            Dodge = 5,
            /// <summary>
            /// <para>Produce a burn effect with the following formula:</para>
            /// <para><code>
            /// result = vec3(1.0) - (vec3(1.0) - a) / b;
            /// </code></para>
            /// </summary>
            Burn = 6,
            /// <summary>
            /// <para>Produce a soft light effect with the following formula:</para>
            /// <para><code>
            /// for (int i = 0; i &lt; 3; i++) {
            ///     float base = a[i];
            ///     float blend = b[i];
            ///     if (base &lt; 0.5) {
            ///         result[i] = base * (blend + 0.5);
            ///     } else {
            ///         result[i] = 1.0 - (1.0 - base) * (1.0 - (blend - 0.5));
            ///     }
            /// }
            /// </code></para>
            /// </summary>
            SoftLight = 7,
            /// <summary>
            /// <para>Produce a hard light effect with the following formula:</para>
            /// <para><code>
            /// for (int i = 0; i &lt; 3; i++) {
            ///     float base = a[i];
            ///     float blend = b[i];
            ///     if (base &lt; 0.5) {
            ///         result[i] = base * (2.0 * blend);
            ///     } else {
            ///         result[i] = 1.0 - (1.0 - base) * (1.0 - 2.0 * (blend - 0.5));
            ///     }
            /// }
            /// </code></para>
            /// </summary>
            HardLight = 8
        }

        /// <summary>
        /// <para>An operator to be applied to the inputs. See <see cref="Godot.VisualShaderNodeColorOp.OperatorEnum"/> for options.</para>
        /// </summary>
        public VisualShaderNodeColorOp.OperatorEnum Operator
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

        private const string nativeName = "VisualShaderNodeColorOp";

        public VisualShaderNodeColorOp() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeColorOp_Ctor(this);
        }

        internal VisualShaderNodeColorOp(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_operator");

        [GodotMethod("set_operator")]
        [Obsolete("SetOperator is deprecated. Use the Operator property instead.")]
        public void SetOperator(VisualShaderNodeColorOp.OperatorEnum op)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)op);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_operator");

        [GodotMethod("get_operator")]
        [Obsolete("GetOperator is deprecated. Use the Operator property instead.")]
        public VisualShaderNodeColorOp.OperatorEnum GetOperator()
        {
            return (VisualShaderNodeColorOp.OperatorEnum)NativeCalls.godot_icall_0_1128(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
