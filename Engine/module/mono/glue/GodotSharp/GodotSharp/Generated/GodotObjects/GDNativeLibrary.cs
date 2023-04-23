using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A GDNative library can implement <see cref="Godot.NativeScript"/>s, global functions to call with the <see cref="Godot.GDNative"/> class, or low-level engine extensions through interfaces such as <see cref="Godot.ARVRInterfaceGDNative"/>. The library must be compiled for each platform and architecture that the project will run on.</para>
    /// </summary>
    public partial class GDNativeLibrary : Resource
    {
        /// <summary>
        /// <para>This resource in INI-style <see cref="Godot.ConfigFile"/> format, as in <c>.gdnlib</c> files.</para>
        /// </summary>
        public ConfigFile ConfigFile
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetConfigFile();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetConfigFile(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, Godot loads only one copy of the library and each script that references the library will share static data like static or global variables.</para>
        /// <para>If <c>false</c>, Godot loads a separate copy of the library into memory for each script that references it.</para>
        /// </summary>
        public bool LoadOnce
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return ShouldLoadOnce();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLoadOnce(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, Godot loads the library at startup rather than the first time a script uses the library, calling <c>{prefix}gdnative_singleton</c> after initializing the library (where <c>{prefix}</c> is the value of <see cref="Godot.GDNativeLibrary.SymbolPrefix"/>). The library remains loaded as long as Godot is running.</para>
        /// <para>Note: A singleton library cannot be <see cref="Godot.GDNativeLibrary.Reloadable"/>.</para>
        /// </summary>
        public bool Singleton
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsSingleton();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSingleton(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The prefix this library's entry point functions begin with. For example, a GDNativeLibrary would declare its <c>gdnative_init</c> function as <c>godot_gdnative_init</c> by default.</para>
        /// <para>On platforms that require statically linking libraries (currently only iOS), each library must have a different <c>symbol_prefix</c>.</para>
        /// </summary>
        public string SymbolPrefix
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSymbolPrefix();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSymbolPrefix(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the editor will temporarily unload the library whenever the user switches away from the editor window, allowing the user to recompile the library without restarting Godot.</para>
        /// <para>Note: If the library defines tool scripts that run inside the editor, <c>reloadable</c> must be <c>false</c>. Otherwise, the editor will attempt to unload the tool scripts while they're in use and crash.</para>
        /// </summary>
        public bool Reloadable
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsReloadable();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetReloadable(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "GDNativeLibrary";

        public GDNativeLibrary() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GDNativeLibrary_Ctor(this);
        }

        internal GDNativeLibrary(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_config_file");

        [GodotMethod("get_config_file")]
        [Obsolete("GetConfigFile is deprecated. Use the ConfigFile property instead.")]
        public ConfigFile GetConfigFile()
        {
            return NativeCalls.godot_icall_0_446(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_config_file");

        [GodotMethod("set_config_file")]
        [Obsolete("SetConfigFile is deprecated. Use the ConfigFile property instead.")]
        public void SetConfigFile(ConfigFile configFile)
        {
            NativeCalls.godot_icall_1_24(method_bind_1, Object.GetPtr(this), Object.GetPtr(configFile));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_library_path");

        /// <summary>
        /// <para>Returns the path to the dynamic library file for the current platform and architecture.</para>
        /// </summary>
        [GodotMethod("get_current_library_path")]
        public string GetCurrentLibraryPath()
        {
            return NativeCalls.godot_icall_0_6(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_dependencies");

        /// <summary>
        /// <para>Returns paths to all dependency libraries for the current platform and architecture.</para>
        /// </summary>
        [GodotMethod("get_current_dependencies")]
        public string[] GetCurrentDependencies()
        {
            return NativeCalls.godot_icall_0_119(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "should_load_once");

        [GodotMethod("should_load_once")]
        [Obsolete("ShouldLoadOnce is deprecated. Use the LoadOnce property instead.")]
        public bool ShouldLoadOnce()
        {
            return NativeCalls.godot_icall_0_7(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_singleton");

        [GodotMethod("is_singleton")]
        [Obsolete("IsSingleton is deprecated. Use the Singleton property instead.")]
        public bool IsSingleton()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_symbol_prefix");

        [GodotMethod("get_symbol_prefix")]
        [Obsolete("GetSymbolPrefix is deprecated. Use the SymbolPrefix property instead.")]
        public string GetSymbolPrefix()
        {
            return NativeCalls.godot_icall_0_6(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_reloadable");

        [GodotMethod("is_reloadable")]
        [Obsolete("IsReloadable is deprecated. Use the Reloadable property instead.")]
        public bool IsReloadable()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_load_once");

        [GodotMethod("set_load_once")]
        [Obsolete("SetLoadOnce is deprecated. Use the LoadOnce property instead.")]
        public void SetLoadOnce(bool loadOnce)
        {
            NativeCalls.godot_icall_1_16(method_bind_8, Object.GetPtr(this), loadOnce);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_singleton");

        [GodotMethod("set_singleton")]
        [Obsolete("SetSingleton is deprecated. Use the Singleton property instead.")]
        public void SetSingleton(bool singleton)
        {
            NativeCalls.godot_icall_1_16(method_bind_9, Object.GetPtr(this), singleton);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_symbol_prefix");

        [GodotMethod("set_symbol_prefix")]
        [Obsolete("SetSymbolPrefix is deprecated. Use the SymbolPrefix property instead.")]
        public void SetSymbolPrefix(string symbolPrefix)
        {
            NativeCalls.godot_icall_1_54(method_bind_10, Object.GetPtr(this), symbolPrefix);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_reloadable");

        [GodotMethod("set_reloadable")]
        [Obsolete("SetReloadable is deprecated. Use the Reloadable property instead.")]
        public void SetReloadable(bool reloadable)
        {
            NativeCalls.godot_icall_1_16(method_bind_11, Object.GetPtr(this), reloadable);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
