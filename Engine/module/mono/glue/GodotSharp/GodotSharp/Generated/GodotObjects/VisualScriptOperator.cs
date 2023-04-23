using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Input Ports:</para>
    /// <para>- Data (variant): <c>A</c></para>
    /// <para>- Data (variant): <c>B</c></para>
    /// <para>Output Ports:</para>
    /// <para>- Data (variant): <c>result</c></para>
    /// </summary>
    public partial class VisualScriptOperator : VisualScriptNode
    {
        /// <summary>
        /// <para>The operation to be performed. See <see cref="Godot.Variant.Operator"/> for available options.</para>
        /// </summary>
        public Variant.Operator Operator
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

        /// <summary>
        /// <para>The type of the values for this operation. See <see cref="Godot.Variant.Type"/> for available options.</para>
        /// </summary>
        public Variant.Type Type
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTyped();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTyped(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptOperator";

        public VisualScriptOperator() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptOperator_Ctor(this);
        }

        internal VisualScriptOperator(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_operator");

        [GodotMethod("set_operator")]
        [Obsolete("SetOperator is deprecated. Use the Operator property instead.")]
        public void SetOperator(Variant.Operator op)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)op);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_operator");

        [GodotMethod("get_operator")]
        [Obsolete("GetOperator is deprecated. Use the Operator property instead.")]
        public Variant.Operator GetOperator()
        {
            return (Variant.Operator)NativeCalls.godot_icall_0_1039(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_typed");

        [GodotMethod("set_typed")]
        [Obsolete("SetTyped is deprecated. Use the Type property instead.")]
        public void SetTyped(Variant.Type type)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_typed");

        [GodotMethod("get_typed")]
        [Obsolete("GetTyped is deprecated. Use the Type property instead.")]
        public Variant.Type GetTyped()
        {
            return (Variant.Type)NativeCalls.godot_icall_0_1030(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
