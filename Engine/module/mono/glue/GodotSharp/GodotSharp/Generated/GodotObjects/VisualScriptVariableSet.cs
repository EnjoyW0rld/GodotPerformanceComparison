using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Changes a variable's value to the given input.</para>
    /// <para>Input Ports:</para>
    /// <para>- Sequence</para>
    /// <para>- Data (variant): <c>set</c></para>
    /// <para>Output Ports:</para>
    /// <para>- Sequence</para>
    /// </summary>
    public partial class VisualScriptVariableSet : VisualScriptNode
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

        private const string nativeName = "VisualScriptVariableSet";

        public VisualScriptVariableSet() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptVariableSet_Ctor(this);
        }

        internal VisualScriptVariableSet(bool memoryOwn) : base(memoryOwn) {}

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
