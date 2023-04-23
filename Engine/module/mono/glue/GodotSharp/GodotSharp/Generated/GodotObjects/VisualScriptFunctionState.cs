using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.VisualScriptFunctionState"/> is returned from <see cref="Godot.VisualScriptYield"/> and can be used to resume a paused function call.</para>
    /// </summary>
    public partial class VisualScriptFunctionState : Reference
    {
        private const string nativeName = "VisualScriptFunctionState";

        public VisualScriptFunctionState() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptFunctionState_Ctor(this);
        }

        internal VisualScriptFunctionState(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "connect_to_signal");

        /// <summary>
        /// <para>Connects this <see cref="Godot.VisualScriptFunctionState"/> to a signal in the given object to automatically resume when it's emitted.</para>
        /// </summary>
        [GodotMethod("connect_to_signal")]
        public void ConnectToSignal(Object obj, string signals, Godot.Collections.Array args)
        {
            NativeCalls.godot_icall_3_1034(method_bind_0, Object.GetPtr(this), Object.GetPtr(obj), signals, args.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "resume");

        /// <summary>
        /// <para>Resumes the function to run from the point it was yielded.</para>
        /// </summary>
        [GodotMethod("resume")]
        public object Resume(Godot.Collections.Array args = null)
        {
            return NativeCalls.godot_icall_1_443(method_bind_1, Object.GetPtr(this), args.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_valid");

        /// <summary>
        /// <para>Returns whether the function state is valid.</para>
        /// </summary>
        [GodotMethod("is_valid")]
        public bool IsValid()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
