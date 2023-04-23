using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Returns a local variable's value. "Var Name" must be supplied, with an optional type.</para>
    /// <para>Input Ports:</para>
    /// <para>none</para>
    /// <para>Output Ports:</para>
    /// <para>- Data (variant): <c>get</c></para>
    /// </summary>
    public partial class VisualScriptLocalVar : VisualScriptNode
    {
        /// <summary>
        /// <para>The local variable's name.</para>
        /// </summary>
        public string VarName
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVarName();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVarName(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The local variable's type.</para>
        /// </summary>
        public Variant.Type Type
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVarType();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVarType(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptLocalVar";

        public VisualScriptLocalVar() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptLocalVar_Ctor(this);
        }

        internal VisualScriptLocalVar(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_var_name");

        [GodotMethod("set_var_name")]
        [Obsolete("SetVarName is deprecated. Use the VarName property instead.")]
        public void SetVarName(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_var_name");

        [GodotMethod("get_var_name")]
        [Obsolete("GetVarName is deprecated. Use the VarName property instead.")]
        public string GetVarName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_var_type");

        [GodotMethod("set_var_type")]
        [Obsolete("SetVarType is deprecated. Use the Type property instead.")]
        public void SetVarType(Variant.Type type)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_var_type");

        [GodotMethod("get_var_type")]
        [Obsolete("GetVarType is deprecated. Use the Type property instead.")]
        public Variant.Type GetVarType()
        {
            return (Variant.Type)NativeCalls.godot_icall_0_1030(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
