using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This node returns a constant from a given class, such as <c>TYPE_INT</c>. See the given class' documentation for available constants.</para>
    /// <para>Input Ports:</para>
    /// <para>none</para>
    /// <para>Output Ports:</para>
    /// <para>- Data (variant): <c>value</c></para>
    /// </summary>
    public partial class VisualScriptClassConstant : VisualScriptNode
    {
        /// <summary>
        /// <para>The constant's parent class.</para>
        /// </summary>
        public string BaseType
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBaseType();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBaseType(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The constant to return. See the given class for its available constants.</para>
        /// </summary>
        public string Constant
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetClassConstant();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetClassConstant(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptClassConstant";

        public VisualScriptClassConstant() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptClassConstant_Ctor(this);
        }

        internal VisualScriptClassConstant(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_class_constant");

        [GodotMethod("set_class_constant")]
        [Obsolete("SetClassConstant is deprecated. Use the Constant property instead.")]
        public void SetClassConstant(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_class_constant");

        [GodotMethod("get_class_constant")]
        [Obsolete("GetClassConstant is deprecated. Use the Constant property instead.")]
        public string GetClassConstant()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_base_type");

        [GodotMethod("set_base_type")]
        [Obsolete("SetBaseType is deprecated. Use the BaseType property instead.")]
        public void SetBaseType(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_2, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_base_type");

        [GodotMethod("get_base_type")]
        [Obsolete("GetBaseType is deprecated. Use the BaseType property instead.")]
        public string GetBaseType()
        {
            return NativeCalls.godot_icall_0_6(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
