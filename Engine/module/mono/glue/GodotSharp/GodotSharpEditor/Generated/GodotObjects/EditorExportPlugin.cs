using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.EditorExportPlugin"/>s are automatically invoked whenever the user exports the project. Their most common use is to determine what files are being included in the exported project. For each plugin, <see cref="Godot.EditorExportPlugin._ExportBegin"/> is called at the beginning of the export process and then <see cref="Godot.EditorExportPlugin._ExportFile"/> is called for each exported file.</para>
    /// <para>To use <see cref="Godot.EditorExportPlugin"/>, register it using the <see cref="Godot.EditorPlugin.AddExportPlugin"/> method first.</para>
    /// </summary>
    public partial class EditorExportPlugin : Reference
    {
        private const string nativeName = "EditorExportPlugin";

        public EditorExportPlugin() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_EditorExportPlugin_Ctor(this);
        }

        internal EditorExportPlugin(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>Virtual method to be overridden by the user. It is called when the export starts and provides all information about the export. <c>features</c> is the list of features for the export, <c>is_debug</c> is <c>true</c> for debug builds, <c>path</c> is the target path for the exported project. <c>flags</c> is only used when running a runnable profile, e.g. when using native run on Android.</para>
        /// </summary>
        [GodotMethod("_export_begin")]
        public virtual void _ExportBegin(string[] features, bool isDebug, string path, int flags)
        {
            return;
        }

        /// <summary>
        /// <para>Virtual method to be overridden by the user. Called when the export is finished.</para>
        /// </summary>
        [GodotMethod("_export_end")]
        public virtual void _ExportEnd()
        {
            return;
        }

        /// <summary>
        /// <para>Virtual method to be overridden by the user. Called for each exported file, providing arguments that can be used to identify the file. <c>path</c> is the path of the file, <c>type</c> is the <see cref="Godot.Resource"/> represented by the file (e.g. <see cref="Godot.PackedScene"/>) and <c>features</c> is the list of features for the export.</para>
        /// <para>Calling <see cref="Godot.EditorExportPlugin.Skip"/> inside this callback will make the file not included in the export.</para>
        /// </summary>
        [GodotMethod("_export_file")]
        public virtual void _ExportFile(string path, string type, string[] features)
        {
            return;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_shared_object");

        /// <summary>
        /// <para>Adds a shared object or a directory containing only shared objects with the given <c>tags</c> and destination <c>path</c>.</para>
        /// <para>Note: In case of macOS exports, those shared objects will be added to <c>Frameworks</c> directory of app bundle.</para>
        /// <para>In case of a directory code-sign will error if you place non code object in directory.</para>
        /// </summary>
        [GodotMethod("add_shared_object")]
        public void AddSharedObject(string path, string[] tags)
        {
            EditorNativeCalls.godot_icall_2_367(method_bind_0, Object.GetPtr(this), path, tags);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_ios_project_static_lib");

        /// <summary>
        /// <para>Adds a static lib from the given <c>path</c> to the iOS project.</para>
        /// </summary>
        [GodotMethod("add_ios_project_static_lib")]
        public void AddIosProjectStaticLib(string path)
        {
            NativeCalls.godot_icall_1_54(method_bind_1, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_file");

        /// <summary>
        /// <para>Adds a custom file to be exported. <c>path</c> is the virtual path that can be used to load the file, <c>file</c> is the binary data of the file. If <c>remap</c> is <c>true</c>, file will not be exported, but instead remapped to the given <c>path</c>.</para>
        /// </summary>
        [GodotMethod("add_file")]
        public void AddFile(string path, byte[] file, bool remap)
        {
            EditorNativeCalls.godot_icall_3_368(method_bind_2, Object.GetPtr(this), path, file, remap);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_ios_framework");

        /// <summary>
        /// <para>Adds a static library (*.a) or dynamic library (*.dylib, *.framework) to Linking Phase in iOS's Xcode project.</para>
        /// </summary>
        [GodotMethod("add_ios_framework")]
        public void AddIosFramework(string path)
        {
            NativeCalls.godot_icall_1_54(method_bind_3, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_ios_embedded_framework");

        /// <summary>
        /// <para>Adds a dynamic library (*.dylib, *.framework) to Linking Phase in iOS's Xcode project and embeds it into resulting binary.</para>
        /// <para>Note: For static libraries (*.a) works in same way as <see cref="Godot.EditorExportPlugin.AddIosFramework"/>.</para>
        /// <para>This method should not be used for System libraries as they are already present on the device.</para>
        /// </summary>
        [GodotMethod("add_ios_embedded_framework")]
        public void AddIosEmbeddedFramework(string path)
        {
            NativeCalls.godot_icall_1_54(method_bind_4, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_ios_plist_content");

        /// <summary>
        /// <para>Adds content for iOS Property List files.</para>
        /// </summary>
        [GodotMethod("add_ios_plist_content")]
        public void AddIosPlistContent(string plistContent)
        {
            NativeCalls.godot_icall_1_54(method_bind_5, Object.GetPtr(this), plistContent);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_ios_linker_flags");

        /// <summary>
        /// <para>Adds linker flags for the iOS export.</para>
        /// </summary>
        [GodotMethod("add_ios_linker_flags")]
        public void AddIosLinkerFlags(string flags)
        {
            NativeCalls.godot_icall_1_54(method_bind_6, Object.GetPtr(this), flags);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_ios_bundle_file");

        /// <summary>
        /// <para>Adds an iOS bundle file from the given <c>path</c> to the exported project.</para>
        /// </summary>
        [GodotMethod("add_ios_bundle_file")]
        public void AddIosBundleFile(string path)
        {
            NativeCalls.godot_icall_1_54(method_bind_7, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_ios_cpp_code");

        /// <summary>
        /// <para>Adds a C++ code to the iOS export. The final code is created from the code appended by each active export plugin.</para>
        /// </summary>
        [GodotMethod("add_ios_cpp_code")]
        public void AddIosCppCode(string code)
        {
            NativeCalls.godot_icall_1_54(method_bind_8, Object.GetPtr(this), code);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_osx_plugin_file");

        /// <summary>
        /// <para>Adds file or directory matching <c>path</c> to <c>PlugIns</c> directory of macOS app bundle.</para>
        /// <para>Note: This is useful only for macOS exports.</para>
        /// </summary>
        [GodotMethod("add_osx_plugin_file")]
        public void AddOsxPluginFile(string path)
        {
            NativeCalls.godot_icall_1_54(method_bind_9, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "skip");

        /// <summary>
        /// <para>To be called inside <see cref="Godot.EditorExportPlugin._ExportFile"/>. Skips the current file, so it's not included in the export.</para>
        /// </summary>
        [GodotMethod("skip")]
        public void Skip()
        {
            NativeCalls.godot_icall_0_3(method_bind_10, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
