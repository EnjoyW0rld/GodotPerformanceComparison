using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Custom Godot Shading Language expression, with a custom amount of input and output ports.</para>
    /// <para>The provided code is directly injected into the graph's matching shader function (<c>vertex</c>, <c>fragment</c>, or <c>light</c>), so it cannot be used to declare functions, varyings, uniforms, or global constants. See <see cref="Godot.VisualShaderNodeGlobalExpression"/> for such global definitions.</para>
    /// </summary>
    public partial class VisualShaderNodeExpression : VisualShaderNodeGroupBase
    {
        /// <summary>
        /// <para>An expression in Godot Shading Language, which will be injected at the start of the graph's matching shader function (<c>vertex</c>, <c>fragment</c>, or <c>light</c>), and thus cannot be used to declare functions, varyings, uniforms, or global constants.</para>
        /// </summary>
        public string Expression
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetExpression();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExpression(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualShaderNodeExpression";

        public VisualShaderNodeExpression() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeExpression_Ctor(this);
        }

        internal VisualShaderNodeExpression(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_expression");

        [GodotMethod("set_expression")]
        [Obsolete("SetExpression is deprecated. Use the Expression property instead.")]
        public void SetExpression(string expression)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), expression);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_expression");

        [GodotMethod("get_expression")]
        [Obsolete("GetExpression is deprecated. Use the Expression property instead.")]
        public string GetExpression()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
