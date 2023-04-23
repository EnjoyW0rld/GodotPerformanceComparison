using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Defines the API that the editor uses to extract information from the underlying VCS. The implementation of this API is included in VCS plugins, which are scripts that inherit <see cref="Godot.EditorVCSInterface"/> and are attached (on demand) to the singleton instance of <see cref="Godot.EditorVCSInterface"/>. Instead of performing the task themselves, all the virtual functions listed below are calling the internally overridden functions in the VCS plugins to provide a plug-n-play experience. A custom VCS plugin is supposed to inherit from <see cref="Godot.EditorVCSInterface"/> and override these virtual functions.</para>
    /// </summary>
    public partial class EditorVCSInterface : Object
    {
        public enum ChangeType
        {
            /// <summary>
            /// <para>A new file has been added.</para>
            /// </summary>
            New = 0,
            /// <summary>
            /// <para>An earlier added file has been modified.</para>
            /// </summary>
            Modified = 1,
            /// <summary>
            /// <para>An earlier added file has been renamed.</para>
            /// </summary>
            Renamed = 2,
            /// <summary>
            /// <para>An earlier added file has been deleted.</para>
            /// </summary>
            Deleted = 3,
            /// <summary>
            /// <para>An earlier added file has been typechanged.</para>
            /// </summary>
            Typechange = 4,
            /// <summary>
            /// <para>A file is left unmerged.</para>
            /// </summary>
            Unmerged = 5
        }

        public enum TreeArea
        {
            /// <summary>
            /// <para>A commit is encountered from the commit area.</para>
            /// </summary>
            Commit = 0,
            /// <summary>
            /// <para>A file is encountered from the staged area.</para>
            /// </summary>
            Staged = 1,
            /// <summary>
            /// <para>A file is encountered from the unstaged area.</para>
            /// </summary>
            Unstaged = 2
        }

        private const string nativeName = "EditorVCSInterface";

        public EditorVCSInterface() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_EditorVCSInterface_Ctor(this);
        }

        internal EditorVCSInterface(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>Checks out a <c>branch_name</c> in the VCS.</para>
        /// </summary>
        [GodotMethod("_checkout_branch")]
        public virtual bool _CheckoutBranch(string branchName)
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Commits the currently staged changes and applies the commit <c>msg</c> to the resulting commit.</para>
        /// </summary>
        [GodotMethod("_commit")]
        public virtual void _Commit(string msg)
        {
            return;
        }

        /// <summary>
        /// <para>Creates a new branch named <c>branch_name</c> in the VCS.</para>
        /// </summary>
        [GodotMethod("_create_branch")]
        public virtual void _CreateBranch(string branchName)
        {
            return;
        }

        /// <summary>
        /// <para>Creates a new remote destination with name <c>remote_name</c> and points it to <c>remote_url</c>. This can be both an HTTPS remote or an SSH remote.</para>
        /// </summary>
        [GodotMethod("_create_remote")]
        public virtual void _CreateRemote(string remoteName, string remoteUrl)
        {
            return;
        }

        /// <summary>
        /// <para>Discards the changes made in file present at <c>file_path</c>.</para>
        /// </summary>
        [GodotMethod("_discard_file")]
        public virtual void _DiscardFile(string filePath)
        {
            return;
        }

        /// <summary>
        /// <para>Fetches new changes from the remote, but doesn't write changes to the current working directory. Equivalent to <c>git fetch</c>.</para>
        /// </summary>
        [GodotMethod("_fetch")]
        public virtual void _Fetch(string remote)
        {
            return;
        }

        /// <summary>
        /// <para>Gets an instance of an <see cref="Godot.Collections.Array"/> of <see cref="string"/>s containing available branch names in the VCS.</para>
        /// </summary>
        [GodotMethod("_get_branch_list")]
        public virtual Godot.Collections.Array _GetBranchList()
        {
            return default(Godot.Collections.Array);
        }

        /// <summary>
        /// <para>Gets the current branch name defined in the VCS.</para>
        /// </summary>
        [GodotMethod("_get_current_branch_name")]
        public virtual string _GetCurrentBranchName()
        {
            return default(string);
        }

        /// <summary>
        /// <para>Returns an <see cref="Godot.Collections.Array"/> of <see cref="Godot.Collections.Dictionary"/> items (see <see cref="Godot.EditorVCSInterface.CreateDiffFile"/>, <see cref="Godot.EditorVCSInterface.CreateDiffHunk"/>, <see cref="Godot.EditorVCSInterface.CreateDiffLine"/>, <see cref="Godot.EditorVCSInterface.AddLineDiffsIntoDiffHunk"/> and <see cref="Godot.EditorVCSInterface.AddDiffHunksIntoDiffFile"/>), each containing information about a diff. If <c>identifier</c> is a file path, returns a file diff, and if it is a commit identifier, then returns a commit diff.</para>
        /// </summary>
        [GodotMethod("_get_diff")]
        public virtual Godot.Collections.Array _GetDiff(string identifier, int area)
        {
            return default(Godot.Collections.Array);
        }

        /// <summary>
        /// <para>Returns an <see cref="Godot.Collections.Array"/> of <see cref="Godot.Collections.Dictionary"/> items (see <see cref="Godot.EditorVCSInterface.CreateDiffHunk"/>), each containing a line diff between a file at <c>file_path</c> and the <c>text</c> which is passed in.</para>
        /// </summary>
        [GodotMethod("_get_line_diff")]
        public virtual Godot.Collections.Array _GetLineDiff(string filePath, string text)
        {
            return default(Godot.Collections.Array);
        }

        /// <summary>
        /// <para>Returns an <see cref="Godot.Collections.Array"/> of <see cref="Godot.Collections.Dictionary"/> items (see <see cref="Godot.EditorVCSInterface.CreateStatusFile"/>), each containing the status data of every modified file in the project folder.</para>
        /// </summary>
        [GodotMethod("_get_modified_files_data")]
        public virtual Godot.Collections.Array _GetModifiedFilesData()
        {
            return default(Godot.Collections.Array);
        }

        /// <summary>
        /// <para>Returns an <see cref="Godot.Collections.Array"/> of <see cref="Godot.Collections.Dictionary"/> items (see <see cref="Godot.EditorVCSInterface.CreateCommit"/>), each containing the data for a past commit.</para>
        /// </summary>
        [GodotMethod("_get_previous_commits")]
        public virtual Godot.Collections.Array _GetPreviousCommits(int maxCommits)
        {
            return default(Godot.Collections.Array);
        }

        /// <summary>
        /// <para>Returns an <see cref="Godot.Collections.Array"/> of <see cref="string"/>s, each containing the name of a remote configured in the VCS.</para>
        /// </summary>
        [GodotMethod("_get_remotes")]
        public virtual Godot.Collections.Array _GetRemotes()
        {
            return default(Godot.Collections.Array);
        }

        /// <summary>
        /// <para>Returns the name of the underlying VCS provider.</para>
        /// </summary>
        [GodotMethod("_get_vcs_name")]
        public virtual string _GetVcsName()
        {
            return default(string);
        }

        /// <summary>
        /// <para>Initializes the VCS plugin when called from the editor. Returns whether or not the plugin was successfully initialized. A VCS project is initialized at <c>project_path</c>.</para>
        /// </summary>
        [GodotMethod("_initialize")]
        public virtual bool _Initialize(string projectPath)
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Pulls changes from the remote. This can give rise to merge conflicts.</para>
        /// </summary>
        [GodotMethod("_pull")]
        public virtual void _Pull(string remote)
        {
            return;
        }

        /// <summary>
        /// <para>Pushes changes to the <c>remote</c>. Optionally, if <c>force</c> is set to true, a force push will override the change history already present on the remote.</para>
        /// </summary>
        [GodotMethod("_push")]
        public virtual void _Push(string remote, bool force)
        {
            return;
        }

        /// <summary>
        /// <para>Remove a branch from the local VCS.</para>
        /// </summary>
        [GodotMethod("_remove_branch")]
        public virtual void _RemoveBranch(string branchName)
        {
            return;
        }

        /// <summary>
        /// <para>Remove a remote from the local VCS.</para>
        /// </summary>
        [GodotMethod("_remove_remote")]
        public virtual void _RemoveRemote(string remoteName)
        {
            return;
        }

        /// <summary>
        /// <para>Set user credentials in the underlying VCS. <c>username</c> and <c>password</c> are used only during HTTPS authentication unless not already mentioned in the remote URL. <c>ssh_public_key_path</c>, <c>ssh_private_key_path</c>, and <c>ssh_passphrase</c> are only used during SSH authentication.</para>
        /// </summary>
        [GodotMethod("_set_credentials")]
        public virtual void _SetCredentials(string username, string password, string sshPublicKeyPath, string sshPrivateKeyPath, string sshPassphrase)
        {
            return;
        }

        /// <summary>
        /// <para>Shuts down VCS plugin instance. Called when the user either closes the editor or shuts down the VCS plugin through the editor UI.</para>
        /// </summary>
        [GodotMethod("_shut_down")]
        public virtual bool _ShutDown()
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Stages the file present at <c>file_path</c> to the staged area.</para>
        /// </summary>
        [GodotMethod("_stage_file")]
        public virtual void _StageFile(string filePath)
        {
            return;
        }

        /// <summary>
        /// <para>Unstages the file present at <c>file_path</c> from the staged area to the unstaged area.</para>
        /// </summary>
        [GodotMethod("_unstage_file")]
        public virtual void _UnstageFile(string filePath)
        {
            return;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_diff_line");

        /// <summary>
        /// <para>Helper function to create a <c>Dictionary</c> for storing a line diff. <c>new_line_no</c> is the line number in the new file (can be <c>-1</c> if the line is deleted). <c>old_line_no</c> is the line number in the old file (can be <c>-1</c> if the line is added). <c>content</c> is the diff text. <c>status</c> is a single character string which stores the line origin.</para>
        /// </summary>
        [GodotMethod("create_diff_line")]
        public Godot.Collections.Dictionary CreateDiffLine(int newLineNo, int oldLineNo, string content, string status)
        {
            return new Godot.Collections.Dictionary(EditorNativeCalls.godot_icall_4_418(method_bind_0, Object.GetPtr(this), newLineNo, oldLineNo, content, status));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_diff_hunk");

        /// <summary>
        /// <para>Helper function to create a <c>Dictionary</c> for storing diff hunk data. <c>old_start</c> is the starting line number in old file. <c>new_start</c> is the starting line number in new file. <c>old_lines</c> is the number of lines in the old file. <c>new_lines</c> is the number of lines in the new file.</para>
        /// </summary>
        [GodotMethod("create_diff_hunk")]
        public Godot.Collections.Dictionary CreateDiffHunk(int oldStart, int newStart, int oldLines, int newLines)
        {
            return new Godot.Collections.Dictionary(EditorNativeCalls.godot_icall_4_419(method_bind_1, Object.GetPtr(this), oldStart, newStart, oldLines, newLines));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_diff_file");

        /// <summary>
        /// <para>Helper function to create a <c>Dictionary</c> for storing old and new diff file paths.</para>
        /// </summary>
        [GodotMethod("create_diff_file")]
        public Godot.Collections.Dictionary CreateDiffFile(string newFile, string oldFile)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_2_420(method_bind_2, Object.GetPtr(this), newFile, oldFile));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_commit");

        /// <summary>
        /// <para>Helper function to create a commit <see cref="Godot.Collections.Dictionary"/> item. <c>msg</c> is the commit message of the commit. <c>author</c> is a single human-readable string containing all the author's details, e.g. the email and name configured in the VCS. <c>id</c> is the identifier of the commit, in whichever format your VCS may provide an identifier to commits. <c>unix_timestamp</c> is the UTC Unix timestamp of when the commit was created. <c>offset_minutes</c> is the timezone offset in minutes, recorded from the system timezone where the commit was created.</para>
        /// </summary>
        [GodotMethod("create_commit")]
        public Godot.Collections.Dictionary CreateCommit(string msg, string author, string id, long unixTimestamp, long offsetMinutes)
        {
            return new Godot.Collections.Dictionary(EditorNativeCalls.godot_icall_5_421(method_bind_3, Object.GetPtr(this), msg, author, id, unixTimestamp, offsetMinutes));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_status_file");

        /// <summary>
        /// <para>Helper function to create a <c>Dictionary</c> used by editor to read the status of a file.</para>
        /// </summary>
        [GodotMethod("create_status_file")]
        public Godot.Collections.Dictionary CreateStatusFile(string filePath, EditorVCSInterface.ChangeType changeType, EditorVCSInterface.TreeArea area)
        {
            return new Godot.Collections.Dictionary(EditorNativeCalls.godot_icall_3_422(method_bind_4, Object.GetPtr(this), filePath, (int)changeType, (int)area));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_diff_hunks_into_diff_file");

        /// <summary>
        /// <para>Helper function to add an array of <c>diff_hunks</c> into a <c>diff_file</c>.</para>
        /// </summary>
        [GodotMethod("add_diff_hunks_into_diff_file")]
        public Godot.Collections.Dictionary AddDiffHunksIntoDiffFile(Godot.Collections.Dictionary diffFile, Godot.Collections.Array diffHunks)
        {
            return new Godot.Collections.Dictionary(EditorNativeCalls.godot_icall_2_423(method_bind_5, Object.GetPtr(this), diffFile.GetPtr(), diffHunks.GetPtr()));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_line_diffs_into_diff_hunk");

        /// <summary>
        /// <para>Helper function to add an array of <c>line_diffs</c> into a <c>diff_hunk</c>.</para>
        /// </summary>
        [GodotMethod("add_line_diffs_into_diff_hunk")]
        public Godot.Collections.Dictionary AddLineDiffsIntoDiffHunk(Godot.Collections.Dictionary diffHunk, Godot.Collections.Array lineDiffs)
        {
            return new Godot.Collections.Dictionary(EditorNativeCalls.godot_icall_2_423(method_bind_6, Object.GetPtr(this), diffHunk.GetPtr(), lineDiffs.GetPtr()));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "popup_error");

        /// <summary>
        /// <para>Pops up an error message in the edior.</para>
        /// </summary>
        [GodotMethod("popup_error")]
        public void PopupError(string msg)
        {
            NativeCalls.godot_icall_1_54(method_bind_7, Object.GetPtr(this), msg);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
