using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Note: This class shouldn't be instantiated directly. Instead, access the singleton using <see cref="Godot.EditorInterface.GetScriptEditor"/>.</para>
    /// </summary>
    public abstract partial class ScriptEditor : PanelContainer
    {
        private const string nativeName = "ScriptEditor";

        internal ScriptEditor() {}

        internal ScriptEditor(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_drag_data_fw");

        [GodotMethod("get_drag_data_fw")]
        public object GetDragDataFw(Vector2 point, Control from)
        {
            return EditorNativeCalls.godot_icall_2_399(method_bind_0, Object.GetPtr(this), ref point, Object.GetPtr(from));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "can_drop_data_fw");

        [GodotMethod("can_drop_data_fw")]
        public bool CanDropDataFw(Vector2 point, object data, Control from)
        {
            return EditorNativeCalls.godot_icall_3_400(method_bind_1, Object.GetPtr(this), ref point, data, Object.GetPtr(from));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "drop_data_fw");

        [GodotMethod("drop_data_fw")]
        public void DropDataFw(Vector2 point, object data, Control from)
        {
            EditorNativeCalls.godot_icall_3_401(method_bind_2, Object.GetPtr(this), ref point, data, Object.GetPtr(from));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "goto_line");

        /// <summary>
        /// <para>Goes to the specified line in the current script.</para>
        /// </summary>
        [GodotMethod("goto_line")]
        public void GotoLine(int lineNumber)
        {
            NativeCalls.godot_icall_1_4(method_bind_3, Object.GetPtr(this), lineNumber);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_script");

        /// <summary>
        /// <para>Returns a <see cref="Godot.Script"/> that is currently active in editor.</para>
        /// </summary>
        [GodotMethod("get_current_script")]
        public Script GetCurrentScript()
        {
            return NativeCalls.godot_icall_0_848(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_open_scripts");

        /// <summary>
        /// <para>Returns an array with all <see cref="Godot.Script"/> objects which are currently open in editor.</para>
        /// </summary>
        [GodotMethod("get_open_scripts")]
        public Godot.Collections.Array GetOpenScripts()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_5, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "open_script_create_dialog");

        /// <summary>
        /// <para>Opens the script create dialog. The script will extend <c>base_name</c>. The file extension can be omitted from <c>base_path</c>. It will be added based on the selected scripting language.</para>
        /// </summary>
        [GodotMethod("open_script_create_dialog")]
        public void OpenScriptCreateDialog(string baseName, string basePath)
        {
            NativeCalls.godot_icall_2_107(method_bind_6, Object.GetPtr(this), baseName, basePath);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reload_scripts");

        /// <summary>
        /// <para>Reload all currently opened scripts from disk in case the file contents are newer.</para>
        /// </summary>
        [GodotMethod("reload_scripts")]
        public void ReloadScripts()
        {
            NativeCalls.godot_icall_0_3(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
