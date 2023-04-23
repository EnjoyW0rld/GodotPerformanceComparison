using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A script implemented in the GDScript programming language. The script extends the functionality of all objects that instance it.</para>
    /// <para><see cref="Godot.GDScript.New"/> creates a new instance of the script. <see cref="Godot.Object.SetScript"/> extends an existing object, if that object's class matches one of the script's base classes.</para>
    /// </summary>
    public partial class GDScript : Script
    {
        private const string nativeName = "GDScript";

        public GDScript() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GDScript_Ctor(this);
        }

        internal GDScript(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "new");

        /// <summary>
        /// <para>Returns a new instance of the script.</para>
        /// <para>For example:</para>
        /// <para><code>
        /// var MyClass = load("myclass.gd")
        /// var instance = MyClass.new()
        /// assert(instance.get_script() == MyClass)
        /// </code></para>
        /// </summary>
        [GodotMethod("new")]
        public object New(params object[] @args)
        {
            return NativeCalls.godot_icall_1_242(method_bind_0, Object.GetPtr(this), @args);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_as_byte_code");

        /// <summary>
        /// <para>Returns byte code for the script source code.</para>
        /// </summary>
        [GodotMethod("get_as_byte_code")]
        public byte[] GetAsByteCode()
        {
            return NativeCalls.godot_icall_0_2(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
