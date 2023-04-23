using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public static partial class JavaClassWrapper
    {
        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(JavaClassWrapper).Name);
                return singleton;
            }
        }

        private const string nativeName = "JavaClassWrapper";
        internal static IntPtr ptr = NativeCalls.godot_icall_JavaClassWrapper_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "wrap");

        [GodotMethod("wrap")]
        public static JavaClass Wrap(string name)
        {
            return NativeCalls.godot_icall_1_554(method_bind_0, ptr, name);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
