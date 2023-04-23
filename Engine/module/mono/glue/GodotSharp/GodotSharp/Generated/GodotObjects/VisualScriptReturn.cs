using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Ends the execution of a function and returns control to the calling function. Optionally, it can return a <c>Variant</c> value.</para>
    /// <para>Input Ports:</para>
    /// <para>- Sequence</para>
    /// <para>- Data (variant): <c>result</c> (optional)</para>
    /// <para>Output Ports:</para>
    /// <para>none</para>
    /// </summary>
    public partial class VisualScriptReturn : VisualScriptNode
    {
        /// <summary>
        /// <para>If <c>true</c>, the <c>return</c> input port is available.</para>
        /// </summary>
        public bool ReturnEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsReturnValueEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnableReturnValue(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The return value's data type.</para>
        /// </summary>
        public Variant.Type ReturnType
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetReturnType();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetReturnType(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptReturn";

        public VisualScriptReturn() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptReturn_Ctor(this);
        }

        internal VisualScriptReturn(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_return_type");

        [GodotMethod("set_return_type")]
        [Obsolete("SetReturnType is deprecated. Use the ReturnType property instead.")]
        public void SetReturnType(Variant.Type type)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_return_type");

        [GodotMethod("get_return_type")]
        [Obsolete("GetReturnType is deprecated. Use the ReturnType property instead.")]
        public Variant.Type GetReturnType()
        {
            return (Variant.Type)NativeCalls.godot_icall_0_1030(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_enable_return_value");

        [GodotMethod("set_enable_return_value")]
        [Obsolete("SetEnableReturnValue is deprecated. Use the ReturnEnabled property instead.")]
        public void SetEnableReturnValue(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_return_value_enabled");

        [GodotMethod("is_return_value_enabled")]
        [Obsolete("IsReturnValueEnabled is deprecated. Use the ReturnEnabled property instead.")]
        public bool IsReturnValueEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
