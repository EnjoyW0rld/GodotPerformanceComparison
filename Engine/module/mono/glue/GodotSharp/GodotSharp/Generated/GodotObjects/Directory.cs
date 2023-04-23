using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Directory type. It is used to manage directories and their content (not restricted to the project folder).</para>
    /// <para>When creating a new <see cref="Godot.Directory"/>, its default opened directory will be <c>res://</c>. This may change in the future, so it is advised to always use <see cref="Godot.Directory.Open"/> to initialize your <see cref="Godot.Directory"/> where you want to operate, with explicit error checking.</para>
    /// <para>Note: Many resources types are imported (e.g. textures or sound files), and their source asset will not be included in the exported game, as only the imported version is used. Use <see cref="Godot.ResourceLoader"/> to access imported resources.</para>
    /// <para>Here is an example on how to iterate through the files of a directory:</para>
    /// <para><code>
    /// func dir_contents(path):
    ///     var dir = Directory.new()
    ///     if dir.open(path) == OK:
    ///         dir.list_dir_begin()
    ///         var file_name = dir.get_next()
    ///         while file_name != "":
    ///             if dir.current_is_dir():
    ///                 print("Found directory: " + file_name)
    ///             else:
    ///                 print("Found file: " + file_name)
    ///             file_name = dir.get_next()
    ///     else:
    ///         print("An error occurred when trying to access the path.")
    /// </code></para>
    /// </summary>
    public partial class Directory : Reference
    {
        private const string nativeName = "_Directory";

        public Directory() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Directory_Ctor(this);
        }

        internal Directory(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "open");

        /// <summary>
        /// <para>Opens an existing directory of the filesystem. The <c>path</c> argument can be within the project tree (<c>res://folder</c>), the user directory (<c>user://folder</c>) or an absolute path of the user filesystem (e.g. <c>/tmp/folder</c> or <c>C:\tmp\folder</c>).</para>
        /// <para>Returns one of the <see cref="Godot.Error"/> code constants (<c>OK</c> on success).</para>
        /// </summary>
        [GodotMethod("open")]
        public Error Open(string path)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_0, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "list_dir_begin");

        /// <summary>
        /// <para>Initializes the stream used to list all files and directories using the <see cref="Godot.Directory.GetNext"/> function, closing the currently opened stream if needed. Once the stream has been processed, it should typically be closed with <see cref="Godot.Directory.ListDirEnd"/>.</para>
        /// <para>If <c>skip_navigational</c> is <c>true</c>, <c>.</c> and <c>..</c> are filtered out.</para>
        /// <para>If <c>skip_hidden</c> is <c>true</c>, hidden files are filtered out.</para>
        /// </summary>
        [GodotMethod("list_dir_begin")]
        public Error ListDirBegin(bool skipNavigational = false, bool skipHidden = false)
        {
            return (Error)NativeCalls.godot_icall_2_1175(method_bind_1, Object.GetPtr(this), skipNavigational, skipHidden);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_next");

        /// <summary>
        /// <para>Returns the next element (file or directory) in the current directory (including <c>.</c> and <c>..</c>, unless <c>skip_navigational</c> was given to <see cref="Godot.Directory.ListDirBegin"/>).</para>
        /// <para>The name of the file or directory is returned (and not its full path). Once the stream has been fully processed, the method returns an empty String and closes the stream automatically (i.e. <see cref="Godot.Directory.ListDirEnd"/> would not be mandatory in such a case).</para>
        /// </summary>
        [GodotMethod("get_next")]
        public string GetNext()
        {
            return NativeCalls.godot_icall_0_6(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "current_is_dir");

        /// <summary>
        /// <para>Returns whether the current item processed with the last <see cref="Godot.Directory.GetNext"/> call is a directory (<c>.</c> and <c>..</c> are considered directories).</para>
        /// </summary>
        [GodotMethod("current_is_dir")]
        public bool CurrentIsDir()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "list_dir_end");

        /// <summary>
        /// <para>Closes the current stream opened with <see cref="Godot.Directory.ListDirBegin"/> (whether it has been fully processed with <see cref="Godot.Directory.GetNext"/> does not matter).</para>
        /// </summary>
        [GodotMethod("list_dir_end")]
        public void ListDirEnd()
        {
            NativeCalls.godot_icall_0_3(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_drive_count");

        /// <summary>
        /// <para>On Windows, returns the number of drives (partitions) mounted on the current filesystem.</para>
        /// <para>On macOS, returns the number of mounted volumes.</para>
        /// <para>On Linux, returns the number of mounted volumes and GTK 3 bookmarks.</para>
        /// <para>On other platforms, the method returns 0.</para>
        /// </summary>
        [GodotMethod("get_drive_count")]
        public int GetDriveCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_drive");

        /// <summary>
        /// <para>On Windows, returns the name of the drive (partition) passed as an argument (e.g. <c>C:</c>).</para>
        /// <para>On macOS, returns the path to the mounted volume passed as an argument.</para>
        /// <para>On Linux, returns the path to the mounted volume or GTK 3 bookmark passed as an argument.</para>
        /// <para>On other platforms, or if the requested drive does not exist, the method returns an empty String.</para>
        /// </summary>
        [GodotMethod("get_drive")]
        public string GetDrive(int idx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_6, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_drive");

        /// <summary>
        /// <para>Returns the currently opened directory's drive index. See <see cref="Godot.Directory.GetDrive"/> to convert returned index to the name of the drive.</para>
        /// </summary>
        [GodotMethod("get_current_drive")]
        public int GetCurrentDrive()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "change_dir");

        /// <summary>
        /// <para>Changes the currently opened directory to the one passed as an argument. The argument can be relative to the current directory (e.g. <c>newdir</c> or <c>../newdir</c>), or an absolute path (e.g. <c>/tmp/newdir</c> or <c>res://somedir/newdir</c>).</para>
        /// <para>Returns one of the <see cref="Godot.Error"/> code constants (<c>OK</c> on success).</para>
        /// </summary>
        [GodotMethod("change_dir")]
        public Error ChangeDir(string todir)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_8, Object.GetPtr(this), todir);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_dir");

        /// <summary>
        /// <para>Returns the absolute path to the currently opened directory (e.g. <c>res://folder</c> or <c>C:\tmp\folder</c>).</para>
        /// </summary>
        [GodotMethod("get_current_dir")]
        public string GetCurrentDir()
        {
            return NativeCalls.godot_icall_0_6(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "make_dir");

        /// <summary>
        /// <para>Creates a directory. The argument can be relative to the current directory, or an absolute path. The target directory should be placed in an already existing directory (to create the full path recursively, see <see cref="Godot.Directory.MakeDirRecursive"/>).</para>
        /// <para>Returns one of the <see cref="Godot.Error"/> code constants (<c>OK</c> on success).</para>
        /// </summary>
        [GodotMethod("make_dir")]
        public Error MakeDir(string path)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_10, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "make_dir_recursive");

        /// <summary>
        /// <para>Creates a target directory and all necessary intermediate directories in its path, by calling <see cref="Godot.Directory.MakeDir"/> recursively. The argument can be relative to the current directory, or an absolute path.</para>
        /// <para>Returns one of the <see cref="Godot.Error"/> code constants (<c>OK</c> on success).</para>
        /// </summary>
        [GodotMethod("make_dir_recursive")]
        public Error MakeDirRecursive(string path)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_11, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "file_exists");

        /// <summary>
        /// <para>Returns whether the target file exists. The argument can be relative to the current directory, or an absolute path.</para>
        /// </summary>
        [GodotMethod("file_exists")]
        public bool FileExists(string path)
        {
            return NativeCalls.godot_icall_1_108(method_bind_12, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "dir_exists");

        /// <summary>
        /// <para>Returns whether the target directory exists. The argument can be relative to the current directory, or an absolute path.</para>
        /// </summary>
        [GodotMethod("dir_exists")]
        public bool DirExists(string path)
        {
            return NativeCalls.godot_icall_1_108(method_bind_13, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_space_left");

        /// <summary>
        /// <para>On UNIX desktop systems, returns the available space on the current directory's disk. On other platforms, this information is not available and the method returns 0 or -1.</para>
        /// </summary>
        [GodotMethod("get_space_left")]
        public ulong GetSpaceLeft()
        {
            return NativeCalls.godot_icall_0_30(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "copy");

        /// <summary>
        /// <para>Copies the <c>from</c> file to the <c>to</c> destination. Both arguments should be paths to files, either relative or absolute. If the destination file exists and is not access-protected, it will be overwritten.</para>
        /// <para>Returns one of the <see cref="Godot.Error"/> code constants (<c>OK</c> on success).</para>
        /// </summary>
        [GodotMethod("copy")]
        public Error Copy(string from, string to)
        {
            return (Error)NativeCalls.godot_icall_2_136(method_bind_15, Object.GetPtr(this), from, to);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rename");

        /// <summary>
        /// <para>Renames (move) the <c>from</c> file or directory to the <c>to</c> destination. Both arguments should be paths to files or directories, either relative or absolute. If the destination file or directory exists and is not access-protected, it will be overwritten.</para>
        /// <para>Returns one of the <see cref="Godot.Error"/> code constants (<c>OK</c> on success).</para>
        /// </summary>
        [GodotMethod("rename")]
        public Error Rename(string from, string to)
        {
            return (Error)NativeCalls.godot_icall_2_136(method_bind_16, Object.GetPtr(this), from, to);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove");

        /// <summary>
        /// <para>Permanently deletes the target file or an empty directory. The argument can be relative to the current directory, or an absolute path. If the target directory is not empty, the operation will fail.</para>
        /// <para>If you don't want to delete the file/directory permanently, use <see cref="Godot.OS.MoveToTrash"/> instead.</para>
        /// <para>Returns one of the <see cref="Godot.Error"/> code constants (<c>OK</c> on success).</para>
        /// </summary>
        [GodotMethod("remove")]
        public Error Remove(string path)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_17, Object.GetPtr(this), path);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
