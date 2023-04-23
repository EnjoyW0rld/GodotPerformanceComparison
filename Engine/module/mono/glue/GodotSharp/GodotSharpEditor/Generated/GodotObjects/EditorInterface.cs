using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>EditorInterface gives you control over Godot editor's window. It allows customizing the window, saving and (re-)loading scenes, rendering mesh previews, inspecting and editing resources and objects, and provides access to <see cref="Godot.EditorSettings"/>, <see cref="Godot.EditorFileSystem"/>, <see cref="Godot.EditorResourcePreview"/>, <see cref="Godot.ScriptEditor"/>, the editor viewport, and information about scenes.</para>
    /// <para>Note: This class shouldn't be instantiated directly. Instead, access the singleton using <see cref="Godot.EditorPlugin.GetEditorInterface"/>.</para>
    /// </summary>
    public abstract partial class EditorInterface : Node
    {
        /// <summary>
        /// <para>If <c>true</c>, enables distraction-free mode which hides side docks to increase the space available for the main view.</para>
        /// </summary>
        public bool DistractionFreeMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDistractionFreeModeEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDistractionFreeMode(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "EditorInterface";

        internal EditorInterface() {}

        internal EditorInterface(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "inspect_object");

        /// <summary>
        /// <para>Shows the given property on the given <c>object</c> in the editor's Inspector dock. If <c>inspector_only</c> is <c>true</c>, plugins will not attempt to edit <c>object</c>.</para>
        /// </summary>
        [GodotMethod("inspect_object")]
        public void InspectObject(Object @object, string forProperty = "", bool inspectorOnly = false)
        {
            EditorNativeCalls.godot_icall_3_379(method_bind_0, Object.GetPtr(this), Object.GetPtr(@object), forProperty, inspectorOnly);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_selection");

        /// <summary>
        /// <para>Returns the editor's <see cref="Godot.EditorSelection"/> instance.</para>
        /// </summary>
        [GodotMethod("get_selection")]
        public EditorSelection GetSelection()
        {
            return EditorNativeCalls.godot_icall_0_380(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_editor_settings");

        /// <summary>
        /// <para>Returns the editor's <see cref="Godot.EditorSettings"/> instance.</para>
        /// </summary>
        [GodotMethod("get_editor_settings")]
        public EditorSettings GetEditorSettings()
        {
            return EditorNativeCalls.godot_icall_0_381(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_script_editor");

        /// <summary>
        /// <para>Returns the editor's <see cref="Godot.ScriptEditor"/> instance.</para>
        /// <para>Warning: Removing and freeing this node will render a part of the editor useless and may cause a crash.</para>
        /// </summary>
        [GodotMethod("get_script_editor")]
        public ScriptEditor GetScriptEditor()
        {
            return EditorNativeCalls.godot_icall_0_382(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_base_control");

        /// <summary>
        /// <para>Returns the main container of Godot editor's window. For example, you can use it to retrieve the size of the container and place your controls accordingly.</para>
        /// <para>Warning: Removing and freeing this node will render the editor useless and may cause a crash.</para>
        /// </summary>
        [GodotMethod("get_base_control")]
        public Control GetBaseControl()
        {
            return NativeCalls.godot_icall_0_314(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_editor_scale");

        /// <summary>
        /// <para>Returns the actual scale of the editor UI (<c>1.0</c> being 100% scale). This can be used to adjust position and dimensions of the UI added by plugins.</para>
        /// <para>Note: This value is set via the <c>interface/editor/display_scale</c> and <c>interface/editor/custom_display_scale</c> editor settings. Editor must be restarted for changes to be properly applied.</para>
        /// </summary>
        [GodotMethod("get_editor_scale")]
        public float GetEditorScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "edit_resource");

        /// <summary>
        /// <para>Edits the given <see cref="Godot.Resource"/>. If the resource is a <see cref="Godot.Script"/> you can also edit it with <see cref="Godot.EditorInterface.EditScript"/> to specify the line and column position.</para>
        /// </summary>
        [GodotMethod("edit_resource")]
        public void EditResource(Resource resource)
        {
            NativeCalls.godot_icall_1_24(method_bind_6, Object.GetPtr(this), Object.GetPtr(resource));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "edit_node");

        /// <summary>
        /// <para>Edits the given <see cref="Godot.Node"/>. The node will be also selected if it's inside the scene tree.</para>
        /// </summary>
        [GodotMethod("edit_node")]
        public void EditNode(Node node)
        {
            NativeCalls.godot_icall_1_53(method_bind_7, Object.GetPtr(this), Object.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "edit_script");

        /// <summary>
        /// <para>Edits the given <see cref="Godot.Script"/>. The line and column on which to open the script can also be specified. The script will be open with the user-configured editor for the script's language which may be an external editor.</para>
        /// </summary>
        [GodotMethod("edit_script")]
        public void EditScript(Script script, int line = -1, int column = 0, bool grabFocus = true)
        {
            EditorNativeCalls.godot_icall_4_383(method_bind_8, Object.GetPtr(this), Object.GetPtr(script), line, column, grabFocus);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "open_scene_from_path");

        /// <summary>
        /// <para>Opens the scene at the given path.</para>
        /// </summary>
        [GodotMethod("open_scene_from_path")]
        public void OpenSceneFromPath(string sceneFilepath)
        {
            NativeCalls.godot_icall_1_54(method_bind_9, Object.GetPtr(this), sceneFilepath);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reload_scene_from_path");

        /// <summary>
        /// <para>Reloads the scene at the given path.</para>
        /// </summary>
        [GodotMethod("reload_scene_from_path")]
        public void ReloadSceneFromPath(string sceneFilepath)
        {
            NativeCalls.godot_icall_1_54(method_bind_10, Object.GetPtr(this), sceneFilepath);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "play_main_scene");

        /// <summary>
        /// <para>Plays the main scene.</para>
        /// </summary>
        [GodotMethod("play_main_scene")]
        public void PlayMainScene()
        {
            NativeCalls.godot_icall_0_3(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "play_current_scene");

        /// <summary>
        /// <para>Plays the currently active scene.</para>
        /// </summary>
        [GodotMethod("play_current_scene")]
        public void PlayCurrentScene()
        {
            NativeCalls.godot_icall_0_3(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "play_custom_scene");

        /// <summary>
        /// <para>Plays the scene specified by its filepath.</para>
        /// </summary>
        [GodotMethod("play_custom_scene")]
        public void PlayCustomScene(string sceneFilepath)
        {
            NativeCalls.godot_icall_1_54(method_bind_13, Object.GetPtr(this), sceneFilepath);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "stop_playing_scene");

        /// <summary>
        /// <para>Stops the scene that is currently playing.</para>
        /// </summary>
        [GodotMethod("stop_playing_scene")]
        public void StopPlayingScene()
        {
            NativeCalls.godot_icall_0_3(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_playing_scene");

        /// <summary>
        /// <para>Returns <c>true</c> if a scene is currently being played, <c>false</c> otherwise. Paused scenes are considered as being played.</para>
        /// </summary>
        [GodotMethod("is_playing_scene")]
        public bool IsPlayingScene()
        {
            return NativeCalls.godot_icall_0_7(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_playing_scene");

        /// <summary>
        /// <para>Returns the name of the scene that is being played. If no scene is currently being played, returns an empty string.</para>
        /// </summary>
        [GodotMethod("get_playing_scene")]
        public string GetPlayingScene()
        {
            return NativeCalls.godot_icall_0_6(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_open_scenes");

        /// <summary>
        /// <para>Returns an <see cref="Godot.Collections.Array"/> with the file paths of the currently opened scenes.</para>
        /// </summary>
        [GodotMethod("get_open_scenes")]
        public Godot.Collections.Array GetOpenScenes()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_17, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_edited_scene_root");

        /// <summary>
        /// <para>Returns the edited (current) scene's root <see cref="Godot.Node"/>.</para>
        /// </summary>
        [GodotMethod("get_edited_scene_root")]
        public Node GetEditedSceneRoot()
        {
            return NativeCalls.godot_icall_0_257(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_resource_previewer");

        /// <summary>
        /// <para>Returns the editor's <see cref="Godot.EditorResourcePreview"/> instance.</para>
        /// </summary>
        [GodotMethod("get_resource_previewer")]
        public EditorResourcePreview GetResourcePreviewer()
        {
            return EditorNativeCalls.godot_icall_0_384(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_resource_filesystem");

        /// <summary>
        /// <para>Returns the editor's <see cref="Godot.EditorFileSystem"/> instance.</para>
        /// </summary>
        [GodotMethod("get_resource_filesystem")]
        public EditorFileSystem GetResourceFilesystem()
        {
            return EditorNativeCalls.godot_icall_0_385(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_editor_viewport");

        /// <summary>
        /// <para>Returns the main editor control. Use this as a parent for main screens.</para>
        /// <para>Note: This returns the main editor control containing the whole editor, not the 2D or 3D viewports specifically.</para>
        /// <para>Warning: Removing and freeing this node will render a part of the editor useless and may cause a crash.</para>
        /// </summary>
        [GodotMethod("get_editor_viewport")]
        public Control GetEditorViewport()
        {
            return NativeCalls.godot_icall_0_314(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "make_mesh_previews");

        /// <summary>
        /// <para>Returns mesh previews rendered at the given size as an <see cref="Godot.Collections.Array"/> of <see cref="Godot.Texture"/>s.</para>
        /// </summary>
        [GodotMethod("make_mesh_previews")]
        public Godot.Collections.Array MakeMeshPreviews(Godot.Collections.Array meshes, int previewSize)
        {
            return new Godot.Collections.Array(EditorNativeCalls.godot_icall_2_386(method_bind_22, Object.GetPtr(this), meshes.GetPtr(), previewSize));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "select_file");

        /// <summary>
        /// <para>Selects the file, with the path provided by <c>file</c>, in the FileSystem dock.</para>
        /// </summary>
        [GodotMethod("select_file")]
        public void SelectFile(string file)
        {
            NativeCalls.godot_icall_1_54(method_bind_23, Object.GetPtr(this), file);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_selected_path");

        /// <summary>
        /// <para>Returns the path of the directory currently selected in the <see cref="Godot.FileSystemDock"/>. If a file is selected, its base directory will be returned using <c>String.get_base_dir</c> instead.</para>
        /// </summary>
        [GodotMethod("get_selected_path")]
        public string GetSelectedPath()
        {
            return NativeCalls.godot_icall_0_6(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_path");

        /// <summary>
        /// <para>Returns the current path being viewed in the <see cref="Godot.FileSystemDock"/>.</para>
        /// </summary>
        [GodotMethod("get_current_path")]
        public string GetCurrentPath()
        {
            return NativeCalls.godot_icall_0_6(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_file_system_dock");

        /// <summary>
        /// <para>Returns the editor's <see cref="Godot.FileSystemDock"/> instance.</para>
        /// <para>Warning: Removing and freeing this node will render a part of the editor useless and may cause a crash.</para>
        /// </summary>
        [GodotMethod("get_file_system_dock")]
        public FileSystemDock GetFileSystemDock()
        {
            return EditorNativeCalls.godot_icall_0_387(method_bind_26, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_plugin_enabled");

        /// <summary>
        /// <para>Sets the enabled status of a plugin. The plugin name is the same as its directory name.</para>
        /// </summary>
        [GodotMethod("set_plugin_enabled")]
        public void SetPluginEnabled(string plugin, bool enabled)
        {
            NativeCalls.godot_icall_2_56(method_bind_27, Object.GetPtr(this), plugin, enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_plugin_enabled");

        /// <summary>
        /// <para>Returns <c>true</c> if the specified <c>plugin</c> is enabled. The plugin name is the same as its directory name.</para>
        /// </summary>
        [GodotMethod("is_plugin_enabled")]
        public bool IsPluginEnabled(string plugin)
        {
            return NativeCalls.godot_icall_1_108(method_bind_28, Object.GetPtr(this), plugin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_inspector");

        /// <summary>
        /// <para>Returns the editor's <see cref="Godot.EditorInspector"/> instance.</para>
        /// <para>Warning: Removing and freeing this node will render a part of the editor useless and may cause a crash.</para>
        /// </summary>
        [GodotMethod("get_inspector")]
        public EditorInspector GetInspector()
        {
            return EditorNativeCalls.godot_icall_0_388(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "save_scene");

        /// <summary>
        /// <para>Saves the scene. Returns either <c>OK</c> or <c>ERR_CANT_CREATE</c> (see <c>@GlobalScope</c> constants).</para>
        /// </summary>
        [GodotMethod("save_scene")]
        public Error SaveScene()
        {
            return (Error)NativeCalls.godot_icall_0_389(method_bind_30, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "save_scene_as");

        /// <summary>
        /// <para>Saves the scene as a file at <c>path</c>.</para>
        /// </summary>
        [GodotMethod("save_scene_as")]
        public void SaveSceneAs(string path, bool withPreview = true)
        {
            NativeCalls.godot_icall_2_56(method_bind_31, Object.GetPtr(this), path, withPreview);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_main_screen_editor");

        /// <summary>
        /// <para>Sets the editor's current main screen to the one specified in <c>name</c>. <c>name</c> must match the text of the tab in question exactly (<c>2D</c>, <c>3D</c>, <c>Script</c>, <c>AssetLib</c>).</para>
        /// </summary>
        [GodotMethod("set_main_screen_editor")]
        public void SetMainScreenEditor(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_32, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_distraction_free_mode");

        [GodotMethod("set_distraction_free_mode")]
        [Obsolete("SetDistractionFreeMode is deprecated. Use the DistractionFreeMode property instead.")]
        public void SetDistractionFreeMode(bool enter)
        {
            NativeCalls.godot_icall_1_16(method_bind_33, Object.GetPtr(this), enter);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_distraction_free_mode_enabled");

        [GodotMethod("is_distraction_free_mode_enabled")]
        [Obsolete("IsDistractionFreeModeEnabled is deprecated. Use the DistractionFreeMode property instead.")]
        public bool IsDistractionFreeModeEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_34, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
