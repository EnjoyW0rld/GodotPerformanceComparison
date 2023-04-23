using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class NativeScript : Script
    {
        public string ClassName
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetClassName();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetClassName(value);
            }
#pragma warning restore CS0618
        }

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

        public string ScriptClassName
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetScriptClassName();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetScriptClassName(value);
            }
#pragma warning restore CS0618
        }

        public string ScriptClassIconPath
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetScriptClassIconPath();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetScriptClassIconPath(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "NativeScript";

        public NativeScript() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_NativeScript_Ctor(this);
        }

        internal NativeScript(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_class_name");

        [GodotMethod("set_class_name")]
        [Obsolete("SetClassName is deprecated. Use the ClassName property instead.")]
        public void SetClassName(string className)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), className);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_class_name");

        [GodotMethod("get_class_name")]
        [Obsolete("GetClassName is deprecated. Use the ClassName property instead.")]
        public string GetClassName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_library");

        [GodotMethod("set_library")]
        [Obsolete("SetLibrary is deprecated. Use the Library property instead.")]
        public void SetLibrary(GDNativeLibrary library)
        {
            NativeCalls.godot_icall_1_24(method_bind_2, Object.GetPtr(this), Object.GetPtr(library));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_library");

        [GodotMethod("get_library")]
        [Obsolete("GetLibrary is deprecated. Use the Library property instead.")]
        public GDNativeLibrary GetLibrary()
        {
            return NativeCalls.godot_icall_0_444(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_script_class_name");

        [GodotMethod("set_script_class_name")]
        [Obsolete("SetScriptClassName is deprecated. Use the ScriptClassName property instead.")]
        public void SetScriptClassName(string className)
        {
            NativeCalls.godot_icall_1_54(method_bind_4, Object.GetPtr(this), className);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_script_class_name");

        [GodotMethod("get_script_class_name")]
        [Obsolete("GetScriptClassName is deprecated. Use the ScriptClassName property instead.")]
        public string GetScriptClassName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_script_class_icon_path");

        [GodotMethod("set_script_class_icon_path")]
        [Obsolete("SetScriptClassIconPath is deprecated. Use the ScriptClassIconPath property instead.")]
        public void SetScriptClassIconPath(string iconPath)
        {
            NativeCalls.godot_icall_1_54(method_bind_6, Object.GetPtr(this), iconPath);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_script_class_icon_path");

        [GodotMethod("get_script_class_icon_path")]
        [Obsolete("GetScriptClassIconPath is deprecated. Use the ScriptClassIconPath property instead.")]
        public string GetScriptClassIconPath()
        {
            return NativeCalls.godot_icall_0_6(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_class_documentation");

        /// <summary>
        /// <para>Returns the documentation string that was previously set with <c>godot_nativescript_set_class_documentation</c>.</para>
        /// </summary>
        [GodotMethod("get_class_documentation")]
        public string GetClassDocumentation()
        {
            return NativeCalls.godot_icall_0_6(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_method_documentation");

        /// <summary>
        /// <para>Returns the documentation string that was previously set with <c>godot_nativescript_set_method_documentation</c>.</para>
        /// </summary>
        [GodotMethod("get_method_documentation")]
        public string GetMethodDocumentation(string method)
        {
            return NativeCalls.godot_icall_1_124(method_bind_9, Object.GetPtr(this), method);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_signal_documentation");

        /// <summary>
        /// <para>Returns the documentation string that was previously set with <c>godot_nativescript_set_signal_documentation</c>.</para>
        /// </summary>
        [GodotMethod("get_signal_documentation")]
        public string GetSignalDocumentation(string signalName)
        {
            return NativeCalls.godot_icall_1_124(method_bind_10, Object.GetPtr(this), signalName);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_property_documentation");

        /// <summary>
        /// <para>Returns the documentation string that was previously set with <c>godot_nativescript_set_property_documentation</c>.</para>
        /// </summary>
        [GodotMethod("get_property_documentation")]
        public string GetPropertyDocumentation(string path)
        {
            return NativeCalls.godot_icall_1_124(method_bind_11, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "new");

        /// <summary>
        /// <para>Constructs a new object of the base type with a script of this type already attached.</para>
        /// <para>Note: Any arguments passed to this function will be ignored and not passed to the native constructor function. This will change with in a future API extension.</para>
        /// </summary>
        [GodotMethod("new")]
        public object New(params object[] @args)
        {
            return NativeCalls.godot_icall_1_242(method_bind_12, Object.GetPtr(this), @args);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
