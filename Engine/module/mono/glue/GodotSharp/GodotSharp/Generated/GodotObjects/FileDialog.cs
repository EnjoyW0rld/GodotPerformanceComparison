using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>FileDialog is a preset dialog used to choose files and directories in the filesystem. It supports filter masks. The FileDialog automatically sets its window title according to the <see cref="Godot.FileDialog.Mode"/>. If you want to use a custom title, disable this by setting <see cref="Godot.FileDialog.ModeOverridesTitle"/> to <c>false</c>.</para>
    /// </summary>
    public partial class FileDialog : ConfirmationDialog
    {
        public enum ModeEnum
        {
            /// <summary>
            /// <para>The dialog allows selecting one, and only one file.</para>
            /// </summary>
            OpenFile = 0,
            /// <summary>
            /// <para>The dialog allows selecting multiple files.</para>
            /// </summary>
            OpenFiles = 1,
            /// <summary>
            /// <para>The dialog only allows selecting a directory, disallowing the selection of any file.</para>
            /// </summary>
            OpenDir = 2,
            /// <summary>
            /// <para>The dialog allows selecting one file or directory.</para>
            /// </summary>
            OpenAny = 3,
            /// <summary>
            /// <para>The dialog will warn when a file exists.</para>
            /// </summary>
            SaveFile = 4
        }

        public enum AccessEnum
        {
            /// <summary>
            /// <para>The dialog only allows accessing files under the <see cref="Godot.Resource"/> path (<c>res://</c>).</para>
            /// </summary>
            Resources = 0,
            /// <summary>
            /// <para>The dialog only allows accessing files under user data path (<c>user://</c>).</para>
            /// </summary>
            Userdata = 1,
            /// <summary>
            /// <para>The dialog allows accessing files on the whole file system.</para>
            /// </summary>
            Filesystem = 2
        }

        /// <summary>
        /// <para>If <c>true</c>, changing the <c>Mode</c> property will set the window title accordingly (e.g. setting mode to <see cref="Godot.FileDialog.ModeEnum.OpenFile"/> will change the window title to "Open a File").</para>
        /// </summary>
        public bool ModeOverridesTitle
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsModeOverridingTitle();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetModeOverridesTitle(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The dialog's open or save mode, which affects the selection behavior. See enum <c>Mode</c> constants.</para>
        /// </summary>
        public FileDialog.ModeEnum Mode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The file system access scope. See enum <c>Access</c> constants.</para>
        /// <para>Warning: Currently, in sandboxed environments such as HTML5 builds or sandboxed macOS apps, FileDialog cannot access the host file system. See <a href="https://github.com/godotengine/godot-proposals/issues/1123">godot-proposals#1123</a>.</para>
        /// </summary>
        public FileDialog.AccessEnum Access
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAccess();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAccess(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The available file type filters. For example, this shows only <c>.png</c> and <c>.gd</c> files: <c>set_filters(PoolStringArray(["*.png ; PNG Images","*.gd ; GDScript Files"]))</c>. Multiple file types can also be specified in a single filter. <c>"*.png, *.jpg, *.jpeg ; Supported Images"</c> will show both PNG and JPEG files when selected.</para>
        /// </summary>
        public string[] Filters
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFilters();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFilters(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the dialog will show hidden files.</para>
        /// </summary>
        public bool ShowHiddenFiles
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsShowingHiddenFiles();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShowHiddenFiles(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The current working directory of the file dialog.</para>
        /// </summary>
        public string CurrentDir
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCurrentDir();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCurrentDir(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The currently selected file of the file dialog.</para>
        /// </summary>
        public string CurrentFile
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCurrentFile();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCurrentFile(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The currently selected file path of the file dialog.</para>
        /// </summary>
        public string CurrentPath
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCurrentPath();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCurrentPath(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "FileDialog";

        public FileDialog() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_FileDialog_Ctor(this);
        }

        internal FileDialog(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_filters");

        /// <summary>
        /// <para>Clear all the added filters in the dialog.</para>
        /// </summary>
        [GodotMethod("clear_filters")]
        public void ClearFilters()
        {
            NativeCalls.godot_icall_0_3(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_filter");

        /// <summary>
        /// <para>Adds <c>filter</c> to the list of filters, which restricts what files can be picked.</para>
        /// <para>A <c>filter</c> should be of the form <c>"filename.extension ; Description"</c>, where filename and extension can be <c>*</c> to match any string. Filters starting with <c>.</c> (i.e. empty filenames) are not allowed.</para>
        /// <para>Example filters: <c>"*.png ; PNG Images"</c>, <c>"project.godot ; Godot Project"</c>.</para>
        /// </summary>
        [GodotMethod("add_filter")]
        public void AddFilter(string filter)
        {
            NativeCalls.godot_icall_1_54(method_bind_1, Object.GetPtr(this), filter);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_filters");

        [GodotMethod("set_filters")]
        [Obsolete("SetFilters is deprecated. Use the Filters property instead.")]
        public void SetFilters(string[] filters)
        {
            NativeCalls.godot_icall_1_407(method_bind_2, Object.GetPtr(this), filters);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_filters");

        [GodotMethod("get_filters")]
        [Obsolete("GetFilters is deprecated. Use the Filters property instead.")]
        public string[] GetFilters()
        {
            return NativeCalls.godot_icall_0_119(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_dir");

        [GodotMethod("get_current_dir")]
        [Obsolete("GetCurrentDir is deprecated. Use the CurrentDir property instead.")]
        public string GetCurrentDir()
        {
            return NativeCalls.godot_icall_0_6(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_file");

        [GodotMethod("get_current_file")]
        [Obsolete("GetCurrentFile is deprecated. Use the CurrentFile property instead.")]
        public string GetCurrentFile()
        {
            return NativeCalls.godot_icall_0_6(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_path");

        [GodotMethod("get_current_path")]
        [Obsolete("GetCurrentPath is deprecated. Use the CurrentPath property instead.")]
        public string GetCurrentPath()
        {
            return NativeCalls.godot_icall_0_6(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_current_dir");

        [GodotMethod("set_current_dir")]
        [Obsolete("SetCurrentDir is deprecated. Use the CurrentDir property instead.")]
        public void SetCurrentDir(string dir)
        {
            NativeCalls.godot_icall_1_54(method_bind_7, Object.GetPtr(this), dir);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_current_file");

        [GodotMethod("set_current_file")]
        [Obsolete("SetCurrentFile is deprecated. Use the CurrentFile property instead.")]
        public void SetCurrentFile(string file)
        {
            NativeCalls.godot_icall_1_54(method_bind_8, Object.GetPtr(this), file);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_current_path");

        [GodotMethod("set_current_path")]
        [Obsolete("SetCurrentPath is deprecated. Use the CurrentPath property instead.")]
        public void SetCurrentPath(string path)
        {
            NativeCalls.godot_icall_1_54(method_bind_9, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mode_overrides_title");

        [GodotMethod("set_mode_overrides_title")]
        [Obsolete("SetModeOverridesTitle is deprecated. Use the ModeOverridesTitle property instead.")]
        public void SetModeOverridesTitle(bool @override)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), @override);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_mode_overriding_title");

        [GodotMethod("is_mode_overriding_title")]
        [Obsolete("IsModeOverridingTitle is deprecated. Use the ModeOverridesTitle property instead.")]
        public bool IsModeOverridingTitle()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mode");

        [GodotMethod("set_mode")]
        [Obsolete("SetMode is deprecated. Use the Mode property instead.")]
        public void SetMode(FileDialog.ModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_12, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mode");

        [GodotMethod("get_mode")]
        [Obsolete("GetMode is deprecated. Use the Mode property instead.")]
        public FileDialog.ModeEnum GetMode()
        {
            return (FileDialog.ModeEnum)NativeCalls.godot_icall_0_433(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_vbox");

        /// <summary>
        /// <para>Returns the vertical box container of the dialog, custom controls can be added to it.</para>
        /// <para>Warning: This is a required internal node, removing and freeing it may cause a crash. If you wish to hide it or any of its children, use their <see cref="Godot.CanvasItem.Visible"/> property.</para>
        /// </summary>
        [GodotMethod("get_vbox")]
        public VBoxContainer GetVbox()
        {
            return NativeCalls.godot_icall_0_371(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_line_edit");

        /// <summary>
        /// <para>Returns the LineEdit for the selected file.</para>
        /// <para>Warning: This is a required internal node, removing and freeing it may cause a crash. If you wish to hide it or any of its children, use their <see cref="Godot.CanvasItem.Visible"/> property.</para>
        /// </summary>
        [GodotMethod("get_line_edit")]
        public LineEdit GetLineEdit()
        {
            return NativeCalls.godot_icall_0_434(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_access");

        [GodotMethod("set_access")]
        [Obsolete("SetAccess is deprecated. Use the Access property instead.")]
        public void SetAccess(FileDialog.AccessEnum access)
        {
            NativeCalls.godot_icall_1_4(method_bind_16, Object.GetPtr(this), (int)access);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_access");

        [GodotMethod("get_access")]
        [Obsolete("GetAccess is deprecated. Use the Access property instead.")]
        public FileDialog.AccessEnum GetAccess()
        {
            return (FileDialog.AccessEnum)NativeCalls.godot_icall_0_435(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_show_hidden_files");

        [GodotMethod("set_show_hidden_files")]
        [Obsolete("SetShowHiddenFiles is deprecated. Use the ShowHiddenFiles property instead.")]
        public void SetShowHiddenFiles(bool show)
        {
            NativeCalls.godot_icall_1_16(method_bind_18, Object.GetPtr(this), show);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_showing_hidden_files");

        [GodotMethod("is_showing_hidden_files")]
        [Obsolete("IsShowingHiddenFiles is deprecated. Use the ShowHiddenFiles property instead.")]
        public bool IsShowingHiddenFiles()
        {
            return NativeCalls.godot_icall_0_7(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "deselect_items");

        /// <summary>
        /// <para>Clear currently selected items in the dialog.</para>
        /// </summary>
        [GodotMethod("deselect_items")]
        public void DeselectItems()
        {
            NativeCalls.godot_icall_0_3(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "invalidate");

        /// <summary>
        /// <para>Invalidate and update the current dialog content list.</para>
        /// </summary>
        [GodotMethod("invalidate")]
        public void Invalidate()
        {
            NativeCalls.godot_icall_0_3(method_bind_21, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
