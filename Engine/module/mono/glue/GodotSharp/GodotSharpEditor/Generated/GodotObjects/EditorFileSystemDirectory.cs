using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A more generalized, low-level variation of the directory concept.</para>
    /// </summary>
    public partial class EditorFileSystemDirectory : Object
    {
        private const string nativeName = "EditorFileSystemDirectory";

        public EditorFileSystemDirectory() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_EditorFileSystemDirectory_Ctor(this);
        }

        internal EditorFileSystemDirectory(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_subdir_count");

        /// <summary>
        /// <para>Returns the number of subdirectories in this directory.</para>
        /// </summary>
        [GodotMethod("get_subdir_count")]
        public int GetSubdirCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_subdir");

        /// <summary>
        /// <para>Returns the subdirectory at index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_subdir")]
        public EditorFileSystemDirectory GetSubdir(int idx)
        {
            return EditorNativeCalls.godot_icall_1_376(method_bind_1, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_file_count");

        /// <summary>
        /// <para>Returns the number of files in this directory.</para>
        /// </summary>
        [GodotMethod("get_file_count")]
        public int GetFileCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_file");

        /// <summary>
        /// <para>Returns the name of the file at index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_file")]
        public string GetFile(int idx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_3, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_file_path");

        /// <summary>
        /// <para>Returns the path to the file at index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_file_path")]
        public string GetFilePath(int idx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_4, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_file_type");

        /// <summary>
        /// <para>Returns the resource type of the file at index <c>idx</c>. This returns a string such as <c>"Resource"</c> or <c>"GDScript"</c>, not a file extension such as <c>".gd"</c>.</para>
        /// </summary>
        [GodotMethod("get_file_type")]
        public string GetFileType(int idx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_5, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_file_script_class_name");

        /// <summary>
        /// <para>Returns the name of the script class defined in the file at index <c>idx</c>. If the file doesn't define a script class using the <c>class_name</c> syntax, this will return an empty string.</para>
        /// </summary>
        [GodotMethod("get_file_script_class_name")]
        public string GetFileScriptClassName(int idx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_6, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_file_script_class_extends");

        /// <summary>
        /// <para>Returns the base class of the script class defined in the file at index <c>idx</c>. If the file doesn't define a script class using the <c>class_name</c> syntax, this will return an empty string.</para>
        /// </summary>
        [GodotMethod("get_file_script_class_extends")]
        public string GetFileScriptClassExtends(int idx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_7, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_file_import_is_valid");

        /// <summary>
        /// <para>Returns <c>true</c> if the file at index <c>idx</c> imported properly.</para>
        /// </summary>
        [GodotMethod("get_file_import_is_valid")]
        public bool GetFileImportIsValid(int idx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_8, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_name");

        /// <summary>
        /// <para>Returns the name of this directory.</para>
        /// </summary>
        [GodotMethod("get_name")]
        public string GetName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_path");

        /// <summary>
        /// <para>Returns the path to this directory.</para>
        /// </summary>
        [GodotMethod("get_path")]
        public string GetPath()
        {
            return NativeCalls.godot_icall_0_6(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_parent");

        /// <summary>
        /// <para>Returns the parent directory for this directory or <c>null</c> if called on a directory at <c>res://</c> or <c>user://</c>.</para>
        /// </summary>
        [GodotMethod("get_parent")]
        public EditorFileSystemDirectory GetParent()
        {
            return EditorNativeCalls.godot_icall_0_374(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "find_file_index");

        /// <summary>
        /// <para>Returns the index of the file with name <c>name</c> or <c>-1</c> if not found.</para>
        /// </summary>
        [GodotMethod("find_file_index")]
        public int FindFileIndex(string name)
        {
            return NativeCalls.godot_icall_1_138(method_bind_12, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "find_dir_index");

        /// <summary>
        /// <para>Returns the index of the directory with name <c>name</c> or <c>-1</c> if not found.</para>
        /// </summary>
        [GodotMethod("find_dir_index")]
        public int FindDirIndex(string name)
        {
            return NativeCalls.godot_icall_1_138(method_bind_13, Object.GetPtr(this), name);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
