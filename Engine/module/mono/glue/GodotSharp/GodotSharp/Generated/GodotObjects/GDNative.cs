using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class GDNative : Reference
    {
        public GDNativeLibrary Library
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLibrary();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLibrary(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "GDNative";

        public GDNative() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GDNative_Ctor(this);
        }

        internal GDNative(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_library");

        [GodotMethod("set_library")]
        [Obsolete("SetLibrary is deprecated. Use the Library property instead.")]
        public void SetLibrary(GDNativeLibrary library)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(library));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_library");

        [GodotMethod("get_library")]
        [Obsolete("GetLibrary is deprecated. Use the Library property instead.")]
        public GDNativeLibrary GetLibrary()
        {
            return NativeCalls.godot_icall_0_444(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "initialize");

        [GodotMethod("initialize")]
        public bool Initialize()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "terminate");

        [GodotMethod("terminate")]
        public bool Terminate()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "call_native");

        [GodotMethod("call_native")]
        public object CallNative(string callingType, string procedureName, Godot.Collections.Array arguments)
        {
            return NativeCalls.godot_icall_3_445(method_bind_4, Object.GetPtr(this), callingType, procedureName, arguments.GetPtr());
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
