using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Singleton used to load resource files from the filesystem.</para>
    /// <para>It uses the many <see cref="Godot.ResourceFormatLoader"/> classes registered in the engine (either built-in or from a plugin) to load files into memory and convert them to a format that can be used by the engine.</para>
    /// </summary>
    public static partial class ResourceLoader
    {
        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(ResourceLoader).Name);
                return singleton;
            }
        }

        private const string nativeName = "_ResourceLoader";
        internal static IntPtr ptr = NativeCalls.godot_icall__ResourceLoader_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "load_interactive");

        /// <summary>
        /// <para>Starts loading a resource interactively. The returned <see cref="Godot.ResourceInteractiveLoader"/> object allows to load with high granularity, calling its <see cref="Godot.ResourceInteractiveLoader.Poll"/> method successively to load chunks.</para>
        /// <para>An optional <c>type_hint</c> can be used to further specify the <see cref="Godot.Resource"/> type that should be handled by the <see cref="Godot.ResourceFormatLoader"/>. Anything that inherits from <see cref="Godot.Resource"/> can be used as a type hint, for example <see cref="Godot.Image"/>.</para>
        /// </summary>
        [GodotMethod("load_interactive")]
        public static ResourceInteractiveLoader LoadInteractive(string path, string typeHint = "")
        {
            return NativeCalls.godot_icall_2_1222(method_bind_0, ptr, path, typeHint);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "load");

        /// <summary>
        /// <para>Loads a resource at the given <c>path</c>, caching the result for further access.</para>
        /// <para>The registered <see cref="Godot.ResourceFormatLoader"/>s are queried sequentially to find the first one which can handle the file's extension, and then attempt loading. If loading fails, the remaining ResourceFormatLoaders are also attempted.</para>
        /// <para>An optional <c>type_hint</c> can be used to further specify the <see cref="Godot.Resource"/> type that should be handled by the <see cref="Godot.ResourceFormatLoader"/>. Anything that inherits from <see cref="Godot.Resource"/> can be used as a type hint, for example <see cref="Godot.Image"/>.</para>
        /// <para>If <c>no_cache</c> is <c>true</c>, the resource cache will be bypassed and the resource will be loaded anew. Otherwise, the cached resource will be returned if it exists.</para>
        /// <para>Returns an empty resource if no <see cref="Godot.ResourceFormatLoader"/> could handle the file.</para>
        /// <para>GDScript has a simplified <c>@GDScript.load</c> built-in method which can be used in most situations, leaving the use of <see cref="Godot.ResourceLoader"/> for more advanced scenarios.</para>
        /// </summary>
        [GodotMethod("load")]
        public static Resource Load(string path, string typeHint = "", bool noCache = false)
        {
            return NativeCalls.godot_icall_3_1223(method_bind_1, ptr, path, typeHint, noCache);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_recognized_extensions_for_type");

        /// <summary>
        /// <para>Returns the list of recognized extensions for a resource type.</para>
        /// </summary>
        [GodotMethod("get_recognized_extensions_for_type")]
        public static string[] GetRecognizedExtensionsForType(string type)
        {
            return NativeCalls.godot_icall_1_309(method_bind_2, ptr, type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_abort_on_missing_resources");

        /// <summary>
        /// <para>Changes the behavior on missing sub-resources. The default behavior is to abort loading.</para>
        /// </summary>
        [GodotMethod("set_abort_on_missing_resources")]
        public static void SetAbortOnMissingResources(bool abort)
        {
            NativeCalls.godot_icall_1_16(method_bind_3, ptr, abort);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_dependencies");

        /// <summary>
        /// <para>Returns the dependencies for the resource at the given <c>path</c>.</para>
        /// </summary>
        [GodotMethod("get_dependencies")]
        public static string[] GetDependencies(string path)
        {
            return NativeCalls.godot_icall_1_309(method_bind_4, ptr, path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_cached");

        /// <summary>
        /// <para>Returns whether a cached resource is available for the given <c>path</c>.</para>
        /// <para>Once a resource has been loaded by the engine, it is cached in memory for faster access, and future calls to the <see cref="Godot.ResourceLoader.Load"/> or <see cref="Godot.ResourceLoader.LoadInteractive"/> methods will use the cached version. The cached resource can be overridden by using <see cref="Godot.Resource.TakeOverPath"/> on a new resource for that same path.</para>
        /// </summary>
        [GodotMethod("has_cached")]
        public static bool HasCached(string path)
        {
            return NativeCalls.godot_icall_1_108(method_bind_5, ptr, path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "exists");

        /// <summary>
        /// <para>Returns whether a recognized resource exists for the given <c>path</c>.</para>
        /// <para>An optional <c>type_hint</c> can be used to further specify the <see cref="Godot.Resource"/> type that should be handled by the <see cref="Godot.ResourceFormatLoader"/>.</para>
        /// </summary>
        [GodotMethod("exists")]
        public static bool Exists(string path, string typeHint = "")
        {
            return NativeCalls.godot_icall_2_116(method_bind_6, ptr, path, typeHint);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has");

        /// <summary>
        /// <para>Deprecated method. Use <see cref="Godot.ResourceLoader.HasCached"/> or <see cref="Godot.ResourceLoader.Exists"/> instead.</para>
        /// </summary>
        [GodotMethod("has")]
        public static bool Has(string path)
        {
            return NativeCalls.godot_icall_1_108(method_bind_7, ptr, path);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
