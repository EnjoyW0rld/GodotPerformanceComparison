using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Returns a variable's value. "Var Name" must be supplied, with an optional type.</para>
    /// <para>Input Ports:</para>
    /// <para>none</para>
    /// <para>Output Ports:</para>
    /// <para>- Data (variant): <c>value</c></para>
    /// </summary>
    public partial class VisualScriptVariableGet : VisualScriptNode
    {
        /// <summary>
        /// <para>The variable's name.</para>
        /// </summary>
        public string VarName
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVariable();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVariable(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptVariableGet";

        public VisualScriptVariableGet() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptVariableGet_Ctor(this);
        }

        internal VisualScriptVariableGet(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_variable");

        [GodotMethod("set_variable")]
        [Obsolete("SetVariable is deprecated. Use the VarName property instead.")]
        public void SetVariable(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_variable");

        [GodotMethod("get_variable")]
        [Obsolete("GetVariable is deprecated. Use the VarName property instead.")]
        public string GetVariable()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
