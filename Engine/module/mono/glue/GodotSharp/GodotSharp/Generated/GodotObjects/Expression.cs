using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>An expression can be made of any arithmetic operation, built-in math function call, method call of a passed instance, or built-in type construction call.</para>
    /// <para>An example expression text using the built-in math functions could be <c>sqrt(pow(3,2) + pow(4,2))</c>.</para>
    /// <para>In the following example we use a <see cref="Godot.LineEdit"/> node to write our expression and show the result.</para>
    /// <para><code>
    /// onready var expression = Expression.new()
    /// 
    /// func _ready():
    ///     $LineEdit.connect("text_entered", self, "_on_text_entered")
    /// 
    /// func _on_text_entered(command):
    ///     var error = expression.parse(command, [])
    ///     if error != OK:
    ///         print(expression.get_error_text())
    ///         return
    ///     var result = expression.execute([], null, true)
    ///     if not expression.has_execute_failed():
    ///         $LineEdit.text = str(result)
    /// </code></para>
    /// </summary>
    public partial class Expression : Reference
    {
        private const string nativeName = "Expression";

        public Expression() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Expression_Ctor(this);
        }

        internal Expression(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "parse");

        /// <summary>
        /// <para>Parses the expression and returns an <see cref="Godot.Error"/> code.</para>
        /// <para>You can optionally specify names of variables that may appear in the expression with <c>input_names</c>, so that you can bind them when it gets executed.</para>
        /// </summary>
        /// <param name="inputNames">If the parameter is null, then the default value is Array.Empty&lt;string&gt;()</param>
        [GodotMethod("parse")]
        public Error Parse(string expression, string[] inputNames = null)
        {
            string[] inputNames_in = inputNames != null ? inputNames : Array.Empty<string>();
            return (Error)NativeCalls.godot_icall_2_431(method_bind_0, Object.GetPtr(this), expression, inputNames_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "execute");

        /// <summary>
        /// <para>Executes the expression that was previously parsed by <see cref="Godot.Expression.Parse"/> and returns the result. Before you use the returned object, you should check if the method failed by calling <see cref="Godot.Expression.HasExecuteFailed"/>.</para>
        /// <para>If you defined input variables in <see cref="Godot.Expression.Parse"/>, you can specify their values in the inputs array, in the same order.</para>
        /// </summary>
        /// <param name="inputs">If the parameter is null, then the default value is new Godot.Collections.Array { }</param>
        [GodotMethod("execute")]
        public object Execute(Godot.Collections.Array inputs = null, Object baseInstance = null, bool showError = true)
        {
            Godot.Collections.Array inputs_in = inputs != null ? inputs : new Godot.Collections.Array { };
            return NativeCalls.godot_icall_3_432(method_bind_1, Object.GetPtr(this), inputs_in.GetPtr(), Object.GetPtr(baseInstance), showError);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_execute_failed");

        /// <summary>
        /// <para>Returns <c>true</c> if <see cref="Godot.Expression.Execute"/> has failed.</para>
        /// </summary>
        [GodotMethod("has_execute_failed")]
        public bool HasExecuteFailed()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_error_text");

        /// <summary>
        /// <para>Returns the error text if <see cref="Godot.Expression.Parse"/> has failed.</para>
        /// </summary>
        [GodotMethod("get_error_text")]
        public string GetErrorText()
        {
            return NativeCalls.godot_icall_0_6(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
