using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public abstract partial class FileSystemDock : VBoxContainer
    {
        private const string nativeName = "FileSystemDock";

        internal FileSystemDock() {}

        internal FileSystemDock(bool memoryOwn) : base(memoryOwn) {}

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
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "navigate_to_path");

        [GodotMethod("navigate_to_path")]
        public void NavigateToPath(string path)
        {
            NativeCalls.godot_icall_1_54(method_bind_3, Object.GetPtr(this), path);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
