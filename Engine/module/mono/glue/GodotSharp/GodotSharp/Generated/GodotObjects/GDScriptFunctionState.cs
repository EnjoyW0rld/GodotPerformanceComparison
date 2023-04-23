using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Calling <c>@GDScript.yield</c> within a function will cause that function to yield and return its current state as an object of this type. The yielded function call can then be resumed later by calling <see cref="Godot.GDScriptFunctionState.Resume"/> on this state object.</para>
    /// </summary>
    public abstract partial class GDScriptFunctionState : Reference
    {
        private const string nativeName = "GDScriptFunctionState";

        internal GDScriptFunctionState() {}

        internal GDScriptFunctionState(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "resume");

        /// <summary>
        /// <para>Resume execution of the yielded function call.</para>
        /// <para>If handed an argument, return the argument from the <c>@GDScript.yield</c> call in the yielded function call. You can pass e.g. an <see cref="Godot.Collections.Array"/> to hand multiple arguments.</para>
        /// <para>This function returns what the resumed function call returns, possibly another function state if yielded again.</para>
        /// </summary>
        [GodotMethod("resume")]
        public object Resume(object arg = null)
        {
            return NativeCalls.godot_icall_1_447(method_bind_0, Object.GetPtr(this), arg);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_valid");

        /// <summary>
        /// <para>Check whether the function call may be resumed. This is not the case if the function state was already resumed.</para>
        /// <para>If <c>extended_check</c> is enabled, it also checks if the associated script and object still exist. The extended check is done in debug mode as part of <see cref="Godot.GDScriptFunctionState.Resume"/>, but you can use this if you know you may be trying to resume without knowing for sure the object and/or script have survived up to that point.</para>
        /// </summary>
        [GodotMethod("is_valid")]
        public bool IsValid(bool extendedCheck = false)
        {
            return NativeCalls.godot_icall_1_448(method_bind_1, Object.GetPtr(this), extendedCheck);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
