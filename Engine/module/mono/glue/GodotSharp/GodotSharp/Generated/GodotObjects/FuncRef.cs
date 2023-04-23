using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>In GDScript, functions are not first-class objects. This means it is impossible to store them directly as variables, return them from another function, or pass them as arguments.</para>
    /// <para>However, by creating a <see cref="Godot.FuncRef"/> using the <c>@GDScript.funcref</c> function, a reference to a function in a given object can be created, passed around and called.</para>
    /// </summary>
    public partial class FuncRef : Reference
    {
        /// <summary>
        /// <para>The name of the referenced function.</para>
        /// </summary>
        public string Function
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFunction();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFunction(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "FuncRef";

        public FuncRef() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_FuncRef_Ctor(this);
        }

        internal FuncRef(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "call_func");

        /// <summary>
        /// <para>Calls the referenced function previously set in <see cref="Godot.FuncRef.Function"/> or <c>@GDScript.funcref</c>.</para>
        /// </summary>
        [GodotMethod("call_func")]
        public object CallFunc(params object[] @args)
        {
            return NativeCalls.godot_icall_1_242(method_bind_0, Object.GetPtr(this), @args);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "call_funcv");

        /// <summary>
        /// <para>Calls the referenced function previously set in <see cref="Godot.FuncRef.Function"/> or <c>@GDScript.funcref</c>. Contrarily to <see cref="Godot.FuncRef.CallFunc"/>, this method does not support a variable number of arguments but expects all parameters to be passed via a single <see cref="Godot.Collections.Array"/>.</para>
        /// </summary>
        [GodotMethod("call_funcv")]
        public object CallFuncv(Godot.Collections.Array argArray)
        {
            return NativeCalls.godot_icall_1_443(method_bind_1, Object.GetPtr(this), argArray.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_instance");

        /// <summary>
        /// <para>The object containing the referenced function. This object must be of a type actually inheriting from <see cref="Godot.Object"/>, not a built-in type such as <see cref="int"/>, <see cref="Godot.Vector2"/> or <see cref="Godot.Collections.Dictionary"/>.</para>
        /// </summary>
        [GodotMethod("set_instance")]
        public void SetInstance(Object instance)
        {
            NativeCalls.godot_icall_1_53(method_bind_2, Object.GetPtr(this), Object.GetPtr(instance));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_valid");

        /// <summary>
        /// <para>Returns whether the object still exists and has the function assigned.</para>
        /// </summary>
        [GodotMethod("is_valid")]
        public bool IsValid()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_function");

        [GodotMethod("set_function")]
        [Obsolete("SetFunction is deprecated. Use the Function property instead.")]
        public void SetFunction(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_4, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_function");

        [GodotMethod("get_function")]
        [Obsolete("GetFunction is deprecated. Use the Function property instead.")]
        public string GetFunction()
        {
            return NativeCalls.godot_icall_0_6(method_bind_5, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
