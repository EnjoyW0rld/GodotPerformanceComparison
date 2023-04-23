using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This node returns a constant's value.</para>
    /// <para>Input Ports:</para>
    /// <para>none</para>
    /// <para>Output Ports:</para>
    /// <para>- Data (variant): <c>get</c></para>
    /// </summary>
    public partial class VisualScriptConstant : VisualScriptNode
    {
        /// <summary>
        /// <para>The constant's type.</para>
        /// </summary>
        public Variant.Type Type
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetConstantType();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetConstantType(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The constant's value.</para>
        /// </summary>
        public object Value
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetConstantValue();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetConstantValue(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptConstant";

        public VisualScriptConstant() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptConstant_Ctor(this);
        }

        internal VisualScriptConstant(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_constant_type");

        [GodotMethod("set_constant_type")]
        [Obsolete("SetConstantType is deprecated. Use the Type property instead.")]
        public void SetConstantType(Variant.Type type)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_constant_type");

        [GodotMethod("get_constant_type")]
        [Obsolete("GetConstantType is deprecated. Use the Type property instead.")]
        public Variant.Type GetConstantType()
        {
            return (Variant.Type)NativeCalls.godot_icall_0_1030(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_constant_value");

        [GodotMethod("set_constant_value")]
        [Obsolete("SetConstantValue is deprecated. Use the Value property instead.")]
        public void SetConstantValue(object value)
        {
            NativeCalls.godot_icall_1_548(method_bind_2, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_constant_value");

        [GodotMethod("get_constant_value")]
        [Obsolete("GetConstantValue is deprecated. Use the Value property instead.")]
        public object GetConstantValue()
        {
            return NativeCalls.godot_icall_0_547(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
