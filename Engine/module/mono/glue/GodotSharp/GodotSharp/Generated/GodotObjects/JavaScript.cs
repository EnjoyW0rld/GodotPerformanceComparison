using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The JavaScript singleton is implemented only in the HTML5 export. It's used to access the browser's JavaScript context. This allows interaction with embedding pages or calling third-party JavaScript APIs.</para>
    /// <para>Note: This singleton can be disabled at build-time to improve security. By default, the JavaScript singleton is enabled. Official export templates also have the JavaScript singleton enabled. See <a href="$DOCS_URL/development/compiling/compiling_for_web.html">Compiling for the Web</a> in the documentation for more information.</para>
    /// </summary>
    public static partial class JavaScript
    {
        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(JavaScript).Name);
                return singleton;
            }
        }

        private const string nativeName = "JavaScript";
        internal static IntPtr ptr = NativeCalls.godot_icall_JavaScript_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "eval");

        /// <summary>
        /// <para>Execute the string <c>code</c> as JavaScript code within the browser window. This is a call to the actual global JavaScript function <c>eval()</c>.</para>
        /// <para>If <c>use_global_execution_context</c> is <c>true</c>, the code will be evaluated in the global execution context. Otherwise, it is evaluated in the execution context of a function within the engine's runtime environment.</para>
        /// </summary>
        [GodotMethod("eval")]
        public static object Eval(string code, bool useGlobalExecutionContext = false)
        {
            return NativeCalls.godot_icall_2_555(method_bind_0, ptr, code, useGlobalExecutionContext);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_interface");

        /// <summary>
        /// <para>Returns an interface to a JavaScript object that can be used by scripts. The <c>interface</c> must be a valid property of the JavaScript <c>window</c>. The callback must accept a single <see cref="Godot.Collections.Array"/> argument, which will contain the JavaScript <c>arguments</c>. See <see cref="Godot.JavaScriptObject"/> for usage.</para>
        /// </summary>
        [GodotMethod("get_interface")]
        public static JavaScriptObject GetInterface(string @interface)
        {
            return NativeCalls.godot_icall_1_556(method_bind_1, ptr, @interface);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_callback");

        /// <summary>
        /// <para>Creates a reference to a script function that can be used as a callback by JavaScript. The reference must be kept until the callback happens, or it won't be called at all. See <see cref="Godot.JavaScriptObject"/> for usage.</para>
        /// </summary>
        [GodotMethod("create_callback")]
        public static JavaScriptObject CreateCallback(Object @object, string method)
        {
            return NativeCalls.godot_icall_2_557(method_bind_2, ptr, Object.GetPtr(@object), method);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_object");

        /// <summary>
        /// <para>Creates a new JavaScript object using the <c>new</c> constructor. The <c>object</c> must a valid property of the JavaScript <c>window</c>. See <see cref="Godot.JavaScriptObject"/> for usage.</para>
        /// </summary>
        [GodotMethod("create_object")]
        public static object CreateObject(string @object, params object[] @args)
        {
            return NativeCalls.godot_icall_2_558(method_bind_3, ptr, @object, @args);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "download_buffer");

        /// <summary>
        /// <para>Prompts the user to download a file containing the specified <c>buffer</c>. The file will have the given <c>name</c> and <c>mime</c> type.</para>
        /// <para>Note: The browser may override the <a href="https://en.wikipedia.org/wiki/Media_type">MIME type</a> provided based on the file <c>name</c>'s extension.</para>
        /// <para>Note: Browsers might block the download if <see cref="Godot.JavaScript.DownloadBuffer"/> is not being called from a user interaction (e.g. button click).</para>
        /// <para>Note: Browsers might ask the user for permission or block the download if multiple download requests are made in a quick succession.</para>
        /// </summary>
        [GodotMethod("download_buffer")]
        public static void DownloadBuffer(byte[] buffer, string name, string mime = "application/octet-stream")
        {
            NativeCalls.godot_icall_3_559(method_bind_4, ptr, buffer, name, mime);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "pwa_needs_update");

        /// <summary>
        /// <para>Returns <c>true</c> if a new version of the progressive web app is waiting to be activated.</para>
        /// <para>Note: Only relevant when exported as a Progressive Web App.</para>
        /// </summary>
        [GodotMethod("pwa_needs_update")]
        public static bool PwaNeedsUpdate()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "pwa_update");

        /// <summary>
        /// <para>Performs the live update of the progressive web app. Forcing the new version to be installed and the page to be reloaded.</para>
        /// <para>Note: Your application will be reloaded in all browser tabs.</para>
        /// <para>Note: Only relevant when exported as a Progressive Web App and <see cref="Godot.JavaScript.PwaNeedsUpdate"/> returns <c>true</c>.</para>
        /// </summary>
        [GodotMethod("pwa_update")]
        public static Error PwaUpdate()
        {
            return (Error)NativeCalls.godot_icall_0_389(method_bind_6, ptr);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
