using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Chooses between two input values based on a Boolean condition.</para>
    /// <para>Input Ports:</para>
    /// <para>- Data (boolean): <c>cond</c></para>
    /// <para>- Data (variant): <c>a</c></para>
    /// <para>- Data (variant): <c>b</c></para>
    /// <para>Output Ports:</para>
    /// <para>- Data (variant): <c>out</c></para>
    /// </summary>
    public partial class VisualScriptSelect : VisualScriptNode
    {
        /// <summary>
        /// <para>The input variables' type.</para>
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

        private const string nativeName = "VisualScriptSelect";

        public VisualScriptSelect() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptSelect_Ctor(this);
        }

        internal VisualScriptSelect(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_typed");

        [GodotMethod("set_typed")]
        [Obsolete("SetTyped is deprecated. Use the Type property instead.")]
        public void SetTyped(Variant.Type type)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_typed");

        [GodotMethod("get_typed")]
        [Obsolete("GetTyped is deprecated. Use the Type property instead.")]
        public Variant.Type GetTyped()
        {
            return (Variant.Type)NativeCalls.godot_icall_0_1030(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
