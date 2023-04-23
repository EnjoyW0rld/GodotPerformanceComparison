using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This object holds information of all resources in the filesystem, their types, etc.</para>
    /// <para>Note: This class shouldn't be instantiated directly. Instead, access the singleton using <see cref="Godot.EditorInterface.GetResourceFilesystem"/>.</para>
    /// </summary>
    public abstract partial class EditorFileSystem : Node
    {
        private const string nativeName = "EditorFileSystem";

        internal EditorFileSystem() {}

        internal EditorFileSystem(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_filesystem");

        /// <summary>
        /// <para>Gets the root directory object.</para>
        /// </summary>
        [GodotMethod("get_filesystem")]
        public EditorFileSystemDirectory GetFilesystem()
        {
            return EditorNativeCalls.godot_icall_0_374(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_scanning");

        /// <summary>
        /// <para>Returns <c>true</c> if the filesystem is being scanned.</para>
        /// </summary>
        [GodotMethod("is_scanning")]
        public bool IsScanning()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_scanning_progress");

        /// <summary>
        /// <para>Returns the scan progress for 0 to 1 if the FS is being scanned.</para>
        /// </summary>
        [GodotMethod("get_scanning_progress")]
        public float GetScanningProgress()
        {
            return NativeCalls.godot_icall_0_14(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "scan");

        /// <summary>
        /// <para>Scan the filesystem for changes.</para>
        /// </summary>
        [GodotMethod("scan")]
        public void Scan()
        {
            NativeCalls.godot_icall_0_3(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "scan_sources");

        /// <summary>
        /// <para>Check if the source of any imported resource changed.</para>
        /// </summary>
        [GodotMethod("scan_sources")]
        public void ScanSources()
        {
            NativeCalls.godot_icall_0_3(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "update_file");

        /// <summary>
        /// <para>Update a file information. Call this if an external program (not Godot) modified the file.</para>
        /// </summary>
        [GodotMethod("update_file")]
        public void UpdateFile(string path)
        {
            NativeCalls.godot_icall_1_54(method_bind_5, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_filesystem_path");

        /// <summary>
        /// <para>Returns a view into the filesystem at <c>path</c>.</para>
        /// </summary>
        [GodotMethod("get_filesystem_path")]
        public EditorFileSystemDirectory GetFilesystemPath(string path)
        {
            return EditorNativeCalls.godot_icall_1_375(method_bind_6, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_file_type");

        /// <summary>
        /// <para>Returns the resource type of the file, given the full path. This returns a string such as <c>"Resource"</c> or <c>"GDScript"</c>, not a file extension such as <c>".gd"</c>.</para>
        /// </summary>
        [GodotMethod("get_file_type")]
        public string GetFileType(string path)
        {
            return NativeCalls.godot_icall_1_124(method_bind_7, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "update_script_classes");

        /// <summary>
        /// <para>Scans the script files and updates the list of custom class names.</para>
        /// </summary>
        [GodotMethod("update_script_classes")]
        public void UpdateScriptClasses()
        {
            NativeCalls.godot_icall_0_3(method_bind_8, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
