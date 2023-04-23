using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class EditorFileDialog : ConfirmationDialog
    {
        public enum DisplayModeEnum
        {
            /// <summary>
            /// <para>The <see cref="Godot.EditorFileDialog"/> displays resources as thumbnails.</para>
            /// </summary>
            Thumbnails = 0,
            /// <summary>
            /// <para>The <see cref="Godot.EditorFileDialog"/> displays resources as a list of filenames.</para>
            /// </summary>
            List = 1
        }

        public enum ModeEnum
        {
            /// <summary>
            /// <para>The <see cref="Godot.EditorFileDialog"/> can select only one file. Accepting the window will open the file.</para>
            /// </summary>
            OpenFile = 0,
            /// <summary>
            /// <para>The <see cref="Godot.EditorFileDialog"/> can select multiple files. Accepting the window will open all files.</para>
            /// </summary>
            OpenFiles = 1,
            /// <summary>
            /// <para>The <see cref="Godot.EditorFileDialog"/> can select only one directory. Accepting the window will open the directory.</para>
            /// </summary>
            OpenDir = 2,
            /// <summary>
            /// <para>The <see cref="Godot.EditorFileDialog"/> can select a file or directory. Accepting the window will open it.</para>
            /// </summary>
            OpenAny = 3,
            /// <summary>
            /// <para>The <see cref="Godot.EditorFileDialog"/> can select only one file. Accepting the window will save the file.</para>
            /// </summary>
            SaveFile = 4
        }

        public enum AccessEnum
        {
            /// <summary>
            /// <para>The <see cref="Godot.EditorFileDialog"/> can only view <c>res://</c> directory contents.</para>
            /// </summary>
            Resources = 0,
            /// <summary>
            /// <para>The <see cref="Godot.EditorFileDialog"/> can only view <c>user://</c> directory contents.</para>
            /// </summary>
            Userdata = 1,
            /// <summary>
            /// <para>The <see cref="Godot.EditorFileDialog"/> can view the entire local file system.</para>
            /// </summary>
            Filesystem = 2
        }

        /// <summary>
        /// <para>The location from which the user may select a file, including <c>res://</c>, <c>user://</c>, and the local file system.</para>
        /// </summary>
        public EditorFileDialog.AccessEnum Access
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
        /// <para>The view format in which the <see cref="Godot.EditorFileDialog"/> displays resources to the user.</para>
        /// </summary>
        public EditorFileDialog.DisplayModeEnum DisplayMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDisplayMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDisplayMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The purpose of the <see cref="Godot.EditorFileDialog"/>, which defines the allowed behaviors.</para>
        /// </summary>
        public EditorFileDialog.ModeEnum Mode
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
        /// <para>The currently occupied directory.</para>
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
        /// <para>The currently selected file.</para>
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
        /// <para>The file system path in the address bar.</para>
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

        /// <summary>
        /// <para>If <c>true</c>, hidden files and directories will be visible in the <see cref="Godot.EditorFileDialog"/>.</para>
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
        /// <para>If <c>true</c>, the <see cref="Godot.EditorFileDialog"/> will not warn the user before overwriting files.</para>
        /// </summary>
        public bool DisableOverwriteWarning
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsOverwriteWarningDisabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDisableOverwriteWarning(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "EditorFileDialog";

        public EditorFileDialog() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_EditorFileDialog_Ctor(this);
        }

        internal EditorFileDialog(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_filters");

        /// <summary>
        /// <para>Removes all filters except for "All Files (*)".</para>
        /// </summary>
        [GodotMethod("clear_filters")]
        public void ClearFilters()
        {
            NativeCalls.godot_icall_0_3(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_filter");

        /// <summary>
        /// <para>Adds a comma-delimited file extension filter option to the <see cref="Godot.EditorFileDialog"/> with an optional semi-colon-delimited label.</para>
        /// <para>For example, <c>"*.tscn, *.scn; Scenes"</c> results in filter text "Scenes (*.tscn, *.scn)".</para>
        /// </summary>
        [GodotMethod("add_filter")]
        public void AddFilter(string filter)
        {
            NativeCalls.godot_icall_1_54(method_bind_1, Object.GetPtr(this), filter);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_dir");

        [GodotMethod("get_current_dir")]
        [Obsolete("GetCurrentDir is deprecated. Use the CurrentDir property instead.")]
        public string GetCurrentDir()
        {
            return NativeCalls.godot_icall_0_6(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_file");

        [GodotMethod("get_current_file")]
        [Obsolete("GetCurrentFile is deprecated. Use the CurrentFile property instead.")]
        public string GetCurrentFile()
        {
            return NativeCalls.godot_icall_0_6(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_path");

        [GodotMethod("get_current_path")]
        [Obsolete("GetCurrentPath is deprecated. Use the CurrentPath property instead.")]
        public string GetCurrentPath()
        {
            return NativeCalls.godot_icall_0_6(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_current_dir");

        [GodotMethod("set_current_dir")]
        [Obsolete("SetCurrentDir is deprecated. Use the CurrentDir property instead.")]
        public void SetCurrentDir(string dir)
        {
            NativeCalls.godot_icall_1_54(method_bind_5, Object.GetPtr(this), dir);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_current_file");

        [GodotMethod("set_current_file")]
        [Obsolete("SetCurrentFile is deprecated. Use the CurrentFile property instead.")]
        public void SetCurrentFile(string file)
        {
            NativeCalls.godot_icall_1_54(method_bind_6, Object.GetPtr(this), file);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_current_path");

        [GodotMethod("set_current_path")]
        [Obsolete("SetCurrentPath is deprecated. Use the CurrentPath property instead.")]
        public void SetCurrentPath(string path)
        {
            NativeCalls.godot_icall_1_54(method_bind_7, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mode");

        [GodotMethod("set_mode")]
        [Obsolete("SetMode is deprecated. Use the Mode property instead.")]
        public void SetMode(EditorFileDialog.ModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_8, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mode");

        [GodotMethod("get_mode")]
        [Obsolete("GetMode is deprecated. Use the Mode property instead.")]
        public EditorFileDialog.ModeEnum GetMode()
        {
            return (EditorFileDialog.ModeEnum)EditorNativeCalls.godot_icall_0_370(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_vbox");

        /// <summary>
        /// <para>Returns the <c>VBoxContainer</c> used to display the file system.</para>
        /// <para>Warning: This is a required internal node, removing and freeing it may cause a crash. If you wish to hide it or any of its children, use their <see cref="Godot.CanvasItem.Visible"/> property.</para>
        /// </summary>
        [GodotMethod("get_vbox")]
        public VBoxContainer GetVbox()
        {
            return NativeCalls.godot_icall_0_371(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_access");

        [GodotMethod("set_access")]
        [Obsolete("SetAccess is deprecated. Use the Access property instead.")]
        public void SetAccess(EditorFileDialog.AccessEnum access)
        {
            NativeCalls.godot_icall_1_4(method_bind_11, Object.GetPtr(this), (int)access);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_access");

        [GodotMethod("get_access")]
        [Obsolete("GetAccess is deprecated. Use the Access property instead.")]
        public EditorFileDialog.AccessEnum GetAccess()
        {
            return (EditorFileDialog.AccessEnum)EditorNativeCalls.godot_icall_0_372(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_show_hidden_files");

        [GodotMethod("set_show_hidden_files")]
        [Obsolete("SetShowHiddenFiles is deprecated. Use the ShowHiddenFiles property instead.")]
        public void SetShowHiddenFiles(bool show)
        {
            NativeCalls.godot_icall_1_16(method_bind_13, Object.GetPtr(this), show);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_showing_hidden_files");

        [GodotMethod("is_showing_hidden_files")]
        [Obsolete("IsShowingHiddenFiles is deprecated. Use the ShowHiddenFiles property instead.")]
        public bool IsShowingHiddenFiles()
        {
            return NativeCalls.godot_icall_0_7(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_display_mode");

        [GodotMethod("set_display_mode")]
        [Obsolete("SetDisplayMode is deprecated. Use the DisplayMode property instead.")]
        public void SetDisplayMode(EditorFileDialog.DisplayModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_15, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_display_mode");

        [GodotMethod("get_display_mode")]
        [Obsolete("GetDisplayMode is deprecated. Use the DisplayMode property instead.")]
        public EditorFileDialog.DisplayModeEnum GetDisplayMode()
        {
            return (EditorFileDialog.DisplayModeEnum)EditorNativeCalls.godot_icall_0_373(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_disable_overwrite_warning");

        [GodotMethod("set_disable_overwrite_warning")]
        [Obsolete("SetDisableOverwriteWarning is deprecated. Use the DisableOverwriteWarning property instead.")]
        public void SetDisableOverwriteWarning(bool disable)
        {
            NativeCalls.godot_icall_1_16(method_bind_17, Object.GetPtr(this), disable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_overwrite_warning_disabled");

        [GodotMethod("is_overwrite_warning_disabled")]
        [Obsolete("IsOverwriteWarningDisabled is deprecated. Use the DisableOverwriteWarning property instead.")]
        public bool IsOverwriteWarningDisabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "invalidate");

        /// <summary>
        /// <para>Notify the <see cref="Godot.EditorFileDialog"/> that its view of the data is no longer accurate. Updates the view contents on next view update.</para>
        /// </summary>
        [GodotMethod("invalidate")]
        public void Invalidate()
        {
            NativeCalls.godot_icall_0_3(method_bind_19, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
