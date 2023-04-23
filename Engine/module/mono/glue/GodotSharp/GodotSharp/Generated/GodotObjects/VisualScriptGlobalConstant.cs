using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A Visual Script node returning a constant from <c>@GlobalScope</c>.</para>
    /// </summary>
    public partial class VisualScriptGlobalConstant : VisualScriptNode
    {
        /// <summary>
        /// <para>The constant to be used.</para>
        /// </summary>
        public int Constant
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGlobalConstant();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlobalConstant(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptGlobalConstant";

        public VisualScriptGlobalConstant() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptGlobalConstant_Ctor(this);
        }

        internal VisualScriptGlobalConstant(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_global_constant");

        [GodotMethod("set_global_constant")]
        [Obsolete("SetGlobalConstant is deprecated. Use the Constant property instead.")]
        public void SetGlobalConstant(int index)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_global_constant");

        [GodotMethod("get_global_constant")]
        [Obsolete("GetGlobalConstant is deprecated. Use the Constant property instead.")]
        public int GetGlobalConstant()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
