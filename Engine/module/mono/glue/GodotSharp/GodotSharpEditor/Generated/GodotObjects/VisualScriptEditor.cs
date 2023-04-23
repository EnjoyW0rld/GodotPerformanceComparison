using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public static partial class VisualScriptEditor
    {
        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(VisualScriptEditor).Name);
                return singleton;
            }
        }

        private const string nativeName = "_VisualScriptEditor";
        internal static IntPtr ptr = EditorNativeCalls.godot_icall__VisualScriptEditor_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_custom_node");

        /// <summary>
        /// <para>Add a custom Visual Script node to the editor. It'll be placed under "Custom Nodes" with the <c>category</c> as the parameter.</para>
        /// </summary>
        [GodotMethod("add_custom_node")]
        public static void AddCustomNode(string name, string category, Script script)
        {
            NativeCalls.godot_icall_3_117(method_bind_0, ptr, name, category, Object.GetPtr(script));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_custom_node");

        /// <summary>
        /// <para>Remove a custom Visual Script node from the editor. Custom nodes already placed on scripts won't be removed.</para>
        /// </summary>
        [GodotMethod("remove_custom_node")]
        public static void RemoveCustomNode(string name, string category)
        {
            NativeCalls.godot_icall_2_107(method_bind_1, ptr, name, category);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
