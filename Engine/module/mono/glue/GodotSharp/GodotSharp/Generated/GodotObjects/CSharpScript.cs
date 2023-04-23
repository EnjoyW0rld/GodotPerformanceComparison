using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This class represents a C# script. It is the C# equivalent of the <see cref="Godot.GDScript"/> class and is only available in Mono-enabled Godot builds.</para>
    /// <para>See also <see cref="Godot.GodotSharp"/>.</para>
    /// </summary>
    public partial class CSharpScript : Script
    {
        private const string nativeName = "CSharpScript";

        public CSharpScript() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CSharpScript_Ctor(this);
        }

        internal CSharpScript(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "new");

        /// <summary>
        /// <para>Returns a new instance of the script.</para>
        /// </summary>
        [GodotMethod("new")]
        public object New(params object[] @args)
        {
            return NativeCalls.godot_icall_1_242(method_bind_0, Object.GetPtr(this), @args);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
