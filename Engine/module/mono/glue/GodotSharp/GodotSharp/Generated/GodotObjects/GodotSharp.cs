using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This class is a bridge between Godot and the Mono runtime. It exposes several low-level operations and is only available in Mono-enabled Godot builds.</para>
    /// <para>See also <see cref="Godot.CSharpScript"/>.</para>
    /// </summary>
    public static partial class GodotSharp
    {
        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(GodotSharp).Name);
                return singleton;
            }
        }

        private const string nativeName = "_GodotSharp";
        internal static IntPtr ptr = NativeCalls.godot_icall__GodotSharp_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "attach_thread");

        /// <summary>
        /// <para>Attaches the current thread to the Mono runtime.</para>
        /// </summary>
        [GodotMethod("attach_thread")]
        public static void AttachThread()
        {
            NativeCalls.godot_icall_0_3(method_bind_0, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "detach_thread");

        /// <summary>
        /// <para>Detaches the current thread from the Mono runtime.</para>
        /// </summary>
        [GodotMethod("detach_thread")]
        public static void DetachThread()
        {
            NativeCalls.godot_icall_0_3(method_bind_1, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_domain_id");

        /// <summary>
        /// <para>Returns the current MonoDomain ID.</para>
        /// <para>Note: The Mono runtime must be initialized for this method to work (use <see cref="Godot.GodotSharp.IsRuntimeInitialized"/> to check). If the Mono runtime isn't initialized at the time this method is called, the engine will crash.</para>
        /// </summary>
        [GodotMethod("get_domain_id")]
        public static int GetDomainId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_2, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_scripts_domain_id");

        /// <summary>
        /// <para>Returns the scripts MonoDomain's ID. This will be the same MonoDomain ID as <see cref="Godot.GodotSharp.GetDomainId"/>, unless the scripts domain isn't loaded.</para>
        /// <para>Note: The Mono runtime must be initialized for this method to work (use <see cref="Godot.GodotSharp.IsRuntimeInitialized"/> to check). If the Mono runtime isn't initialized at the time this method is called, the engine will crash.</para>
        /// </summary>
        [GodotMethod("get_scripts_domain_id")]
        public static int GetScriptsDomainId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_3, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_scripts_domain_loaded");

        /// <summary>
        /// <para>Returns <c>true</c> if the scripts domain is loaded, <c>false</c> otherwise.</para>
        /// </summary>
        [GodotMethod("is_scripts_domain_loaded")]
        public static bool IsScriptsDomainLoaded()
        {
            return NativeCalls.godot_icall_0_7(method_bind_4, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_domain_finalizing_for_unload");

        /// <summary>
        /// <para>Returns <c>true</c> if the domain is being finalized, <c>false</c> otherwise.</para>
        /// </summary>
        [GodotMethod("is_domain_finalizing_for_unload")]
        public static bool IsDomainFinalizingForUnload(int domainId)
        {
            return NativeCalls.godot_icall_1_35(method_bind_5, ptr, domainId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_runtime_shutting_down");

        /// <summary>
        /// <para>Returns <c>true</c> if the Mono runtime is shutting down, <c>false</c> otherwise.</para>
        /// </summary>
        [GodotMethod("is_runtime_shutting_down")]
        public static bool IsRuntimeShuttingDown()
        {
            return NativeCalls.godot_icall_0_7(method_bind_6, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_runtime_initialized");

        /// <summary>
        /// <para>Returns <c>true</c> if the Mono runtime is initialized, <c>false</c> otherwise.</para>
        /// </summary>
        [GodotMethod("is_runtime_initialized")]
        public static bool IsRuntimeInitialized()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, ptr);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
