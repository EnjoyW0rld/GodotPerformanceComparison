using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Emits a specified signal when it is executed.</para>
    /// <para>Input Ports:</para>
    /// <para>- Sequence: <c>emit</c></para>
    /// <para>Output Ports:</para>
    /// <para>- Sequence</para>
    /// </summary>
    public partial class VisualScriptEmitSignal : VisualScriptNode
    {
        /// <summary>
        /// <para>The signal to emit.</para>
        /// </summary>
        public string Signal
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSignal();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSignal(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptEmitSignal";

        public VisualScriptEmitSignal() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptEmitSignal_Ctor(this);
        }

        internal VisualScriptEmitSignal(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_signal");

        [GodotMethod("set_signal")]
        [Obsolete("SetSignal is deprecated. Use the Signal property instead.")]
        public void SetSignal(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_signal");

        [GodotMethod("get_signal")]
        [Obsolete("GetSignal is deprecated. Use the Signal property instead.")]
        public string GetSignal()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
