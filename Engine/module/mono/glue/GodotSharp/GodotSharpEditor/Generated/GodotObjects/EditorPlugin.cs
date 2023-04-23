using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Plugins are used by the editor to extend functionality. The most common types of plugins are those which edit a given node or resource type, import plugins and export plugins. See also <see cref="Godot.EditorScript"/> to add functions to the editor.</para>
    /// </summary>
    public partial class EditorPlugin : Node
    {
        public enum DockSlot
        {
            LeftUl = 0,
            LeftBl = 1,
            LeftUr = 2,
            LeftBr = 3,
            RightUl = 4,
            RightBl = 5,
            RightUr = 6,
            RightBr = 7,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.EditorPlugin.DockSlot"/> enum.</para>
            /// </summary>
            Max = 8
        }

        public enum CustomControlContainer
        {
            Toolbar = 0,
            SpatialEditorMenu = 1,
            SpatialEditorSideLeft = 2,
            SpatialEditorSideRight = 3,
            SpatialEditorBottom = 4,
            CanvasEditorMenu = 5,
            CanvasEditorSideLeft = 6,
            CanvasEditorSideRight = 7,
            CanvasEditorBottom = 8,
            PropertyEditorBottom = 9,
            ProjectSettingTabLeft = 10,
            ProjectSettingTabRight = 11
        }

        private const string nativeName = "EditorPlugin";

        public EditorPlugin() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_EditorPlugin_Ctor(this);
        }

        internal EditorPlugin(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>This method is called when the editor is about to save the project, switch to another tab, etc. It asks the plugin to apply any pending state changes to ensure consistency.</para>
        /// <para>This is used, for example, in shader editors to let the plugin know that it must apply the shader code being written by the user to the object.</para>
        /// </summary>
        [GodotMethod("apply_changes")]
        public virtual void ApplyChanges()
        {
            return;
        }

        /// <summary>
        /// <para>This method is called when the editor is about to run the project. The plugin can then perform required operations before the project runs.</para>
        /// <para>This method must return a boolean. If this method returns <c>false</c>, the project will not run. The run is aborted immediately, so this also prevents all other plugins' <see cref="Godot.EditorPlugin.Build"/> methods from running.</para>
        /// </summary>
        [GodotMethod("build")]
        public virtual bool Build()
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Clear all the state and reset the object being edited to zero. This ensures your plugin does not keep editing a currently existing node, or a node from the wrong scene.</para>
        /// </summary>
        [GodotMethod("clear")]
        public virtual void Clear()
        {
            return;
        }

        /// <summary>
        /// <para>Called by the engine when the user disables the <see cref="Godot.EditorPlugin"/> in the Plugin tab of the project settings window.</para>
        /// </summary>
        [GodotMethod("disable_plugin")]
        public virtual void DisablePlugin()
        {
            return;
        }

        /// <summary>
        /// <para>This function is used for plugins that edit specific object types (nodes or resources). It requests the editor to edit the given object.</para>
        /// </summary>
        [GodotMethod("edit")]
        public virtual void Edit(Object @object)
        {
            return;
        }

        /// <summary>
        /// <para>Called by the engine when the user enables the <see cref="Godot.EditorPlugin"/> in the Plugin tab of the project settings window.</para>
        /// </summary>
        [GodotMethod("enable_plugin")]
        public virtual void EnablePlugin()
        {
            return;
        }

        /// <summary>
        /// <para>Called by the engine when the 2D editor's viewport is updated. Use the <c>overlay</c> <see cref="Godot.Control"/> for drawing. You can update the viewport manually by calling <see cref="Godot.EditorPlugin.UpdateOverlays"/>.</para>
        /// <para><code>
        /// func forward_canvas_draw_over_viewport(overlay):
        ///     # Draw a circle at cursor position.
        ///     overlay.draw_circle(overlay.get_local_mouse_position(), 64, Color.white)
        /// 
        /// func forward_canvas_gui_input(event):
        ///     if event is InputEventMouseMotion:
        ///         # Redraw viewport when cursor is moved.
        ///         update_overlays()
        ///         return true
        ///     return false
        /// </code></para>
        /// </summary>
        [GodotMethod("forward_canvas_draw_over_viewport")]
        public virtual void ForwardCanvasDrawOverViewport(Control overlay)
        {
            return;
        }

        /// <summary>
        /// <para>This method is the same as <see cref="Godot.EditorPlugin.ForwardCanvasDrawOverViewport"/>, except it draws on top of everything. Useful when you need an extra layer that shows over anything else.</para>
        /// <para>You need to enable calling of this method by using <see cref="Godot.EditorPlugin.SetForceDrawOverForwardingEnabled"/>.</para>
        /// </summary>
        [GodotMethod("forward_canvas_force_draw_over_viewport")]
        public virtual void ForwardCanvasForceDrawOverViewport(Control overlay)
        {
            return;
        }

        /// <summary>
        /// <para>Called when there is a root node in the current edited scene, <see cref="Godot.EditorPlugin.Handles"/> is implemented and an <see cref="Godot.InputEvent"/> happens in the 2D viewport. Intercepts the <see cref="Godot.InputEvent"/>, if <c>return true</c> <see cref="Godot.EditorPlugin"/> consumes the <c>event</c>, otherwise forwards <c>event</c> to other Editor classes. Example:</para>
        /// <para><code>
        /// # Prevents the InputEvent to reach other Editor classes
        /// func forward_canvas_gui_input(event):
        ///     var forward = true
        ///     return forward
        /// </code></para>
        /// <para>Must <c>return false</c> in order to forward the <see cref="Godot.InputEvent"/> to other Editor classes. Example:</para>
        /// <para><code>
        /// # Consumes InputEventMouseMotion and forwards other InputEvent types
        /// func forward_canvas_gui_input(event):
        ///     var forward = false
        ///     if event is InputEventMouseMotion:
        ///         forward = true
        ///     return forward
        /// </code></para>
        /// </summary>
        [GodotMethod("forward_canvas_gui_input")]
        public virtual bool ForwardCanvasGuiInput(InputEvent @event)
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Called by the engine when the 3D editor's viewport is updated. Use the <c>overlay</c> <see cref="Godot.Control"/> for drawing. You can update the viewport manually by calling <see cref="Godot.EditorPlugin.UpdateOverlays"/>.</para>
        /// <para><code>
        /// func forward_spatial_draw_over_viewport(overlay):
        ///     # Draw a circle at cursor position.
        ///     overlay.draw_circle(overlay.get_local_mouse_position(), 64)
        /// 
        /// func forward_spatial_gui_input(camera, event):
        ///     if event is InputEventMouseMotion:
        ///         # Redraw viewport when cursor is moved.
        ///         update_overlays()
        ///         return true
        ///     return false
        /// </code></para>
        /// </summary>
        [GodotMethod("forward_spatial_draw_over_viewport")]
        public virtual void ForwardSpatialDrawOverViewport(Control overlay)
        {
            return;
        }

        /// <summary>
        /// <para>This method is the same as <see cref="Godot.EditorPlugin.ForwardSpatialDrawOverViewport"/>, except it draws on top of everything. Useful when you need an extra layer that shows over anything else.</para>
        /// <para>You need to enable calling of this method by using <see cref="Godot.EditorPlugin.SetForceDrawOverForwardingEnabled"/>.</para>
        /// </summary>
        [GodotMethod("forward_spatial_force_draw_over_viewport")]
        public virtual void ForwardSpatialForceDrawOverViewport(Control overlay)
        {
            return;
        }

        /// <summary>
        /// <para>Called when there is a root node in the current edited scene, <see cref="Godot.EditorPlugin.Handles"/> is implemented and an <see cref="Godot.InputEvent"/> happens in the 3D viewport. Intercepts the <see cref="Godot.InputEvent"/>, if <c>return true</c> <see cref="Godot.EditorPlugin"/> consumes the <c>event</c>, otherwise forwards <c>event</c> to other Editor classes. Example:</para>
        /// <para><code>
        /// # Prevents the InputEvent to reach other Editor classes
        /// func forward_spatial_gui_input(camera, event):
        ///     var forward = true
        ///     return forward
        /// </code></para>
        /// <para>Must <c>return false</c> in order to forward the <see cref="Godot.InputEvent"/> to other Editor classes. Example:</para>
        /// <para><code>
        /// # Consumes InputEventMouseMotion and forwards other InputEvent types
        /// func forward_spatial_gui_input(camera, event):
        ///     var forward = false
        ///     if event is InputEventMouseMotion:
        ///         forward = true
        ///     return forward
        /// </code></para>
        /// </summary>
        [GodotMethod("forward_spatial_gui_input")]
        public virtual bool ForwardSpatialGuiInput(Camera camera, InputEvent @event)
        {
            return default(bool);
        }

        /// <summary>
        /// <para>This is for editors that edit script-based objects. You can return a list of breakpoints in the format (<c>script:line</c>), for example: <c>res://path_to_script.gd:25</c>.</para>
        /// </summary>
        [GodotMethod("get_breakpoints")]
        public virtual string[] GetBreakpoints()
        {
            return default(string[]);
        }

        /// <summary>
        /// <para>Override this method in your plugin to return a <see cref="Godot.Texture"/> in order to give it an icon.</para>
        /// <para>For main screen plugins, this appears at the top of the screen, to the right of the "2D", "3D", "Script", and "AssetLib" buttons.</para>
        /// <para>Ideally, the plugin icon should be white with a transparent background and 16x16 pixels in size.</para>
        /// <para><code>
        /// func get_plugin_icon():
        ///     # You can use a custom icon:
        ///     return preload("res://addons/my_plugin/my_plugin_icon.svg")
        ///     # Or use a built-in icon:
        ///     return get_editor_interface().get_base_control().get_icon("Node", "EditorIcons")
        /// </code></para>
        /// </summary>
        [GodotMethod("get_plugin_icon")]
        public virtual Texture GetPluginIcon()
        {
            return default(Texture);
        }

        /// <summary>
        /// <para>Override this method in your plugin to provide the name of the plugin when displayed in the Godot editor.</para>
        /// <para>For main screen plugins, this appears at the top of the screen, to the right of the "2D", "3D", "Script", and "AssetLib" buttons.</para>
        /// </summary>
        [GodotMethod("get_plugin_name")]
        public virtual string GetPluginName()
        {
            return default(string);
        }

        /// <summary>
        /// <para>Override this method to provide a state data you want to be saved, like view position, grid settings, folding, etc. This is used when saving the scene (so state is kept when opening it again) and for switching tabs (so state can be restored when the tab returns). This data is automatically saved for each scene in an <c>editstate</c> file in the editor metadata folder. If you want to store global (scene-independent) editor data for your plugin, you can use <see cref="Godot.EditorPlugin.GetWindowLayout"/> instead.</para>
        /// <para>Use <see cref="Godot.EditorPlugin.SetState"/> to restore your saved state.</para>
        /// <para>Note: This method should not be used to save important settings that should persist with the project.</para>
        /// <para>Note: You must implement <see cref="Godot.EditorPlugin.GetPluginName"/> for the state to be stored and restored correctly.</para>
        /// <para><code>
        /// func get_state():
        ///     var state = {"zoom": zoom, "preferred_color": my_color}
        ///     return state
        /// </code></para>
        /// </summary>
        [GodotMethod("get_state")]
        public virtual Godot.Collections.Dictionary GetState()
        {
            return default(Godot.Collections.Dictionary);
        }

        /// <summary>
        /// <para>Override this method to provide the GUI layout of the plugin or any other data you want to be stored. This is used to save the project's editor layout when <see cref="Godot.EditorPlugin.QueueSaveLayout"/> is called or the editor layout was changed (for example changing the position of a dock). The data is stored in the <c>editor_layout.cfg</c> file in the editor metadata directory.</para>
        /// <para>Use <see cref="Godot.EditorPlugin.SetWindowLayout"/> to restore your saved layout.</para>
        /// <para><code>
        /// func get_window_layout(configuration):
        ///     configuration.set_value("MyPlugin", "window_position", $Window.position)
        ///     configuration.set_value("MyPlugin", "icon_color", $Icon.modulate)
        /// </code></para>
        /// </summary>
        [GodotMethod("get_window_layout")]
        public virtual void GetWindowLayout(ConfigFile layout)
        {
            return;
        }

        /// <summary>
        /// <para>Implement this function if your plugin edits a specific type of object (Resource or Node). If you return <c>true</c>, then you will get the functions <see cref="Godot.EditorPlugin.Edit"/> and <see cref="Godot.EditorPlugin.MakeVisible"/> called when the editor requests them. If you have declared the methods <see cref="Godot.EditorPlugin.ForwardCanvasGuiInput"/> and <see cref="Godot.EditorPlugin.ForwardSpatialGuiInput"/> these will be called too.</para>
        /// </summary>
        [GodotMethod("handles")]
        public virtual bool Handles(Object @object)
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Returns <c>true</c> if this is a main screen editor plugin (it goes in the workspace selector together with 2D, 3D, Script and AssetLib).</para>
        /// </summary>
        [GodotMethod("has_main_screen")]
        public virtual bool HasMainScreen()
        {
            return default(bool);
        }

        /// <summary>
        /// <para>This function will be called when the editor is requested to become visible. It is used for plugins that edit a specific object type.</para>
        /// <para>Remember that you have to manage the visibility of all your editor controls manually.</para>
        /// </summary>
        [GodotMethod("make_visible")]
        public virtual void MakeVisible(bool visible)
        {
            return;
        }

        /// <summary>
        /// <para>This method is called after the editor saves the project or when it's closed. It asks the plugin to save edited external scenes/resources.</para>
        /// </summary>
        [GodotMethod("save_external_data")]
        public virtual void SaveExternalData()
        {
            return;
        }

        /// <summary>
        /// <para>Restore the state saved by <see cref="Godot.EditorPlugin.GetState"/>. This method is called when the current scene tab is changed in the editor.</para>
        /// <para>Note: Your plugin must implement <see cref="Godot.EditorPlugin.GetPluginName"/>, otherwise it will not be recognized and this method will not be called.</para>
        /// <para><code>
        /// func set_state(data):
        ///     zoom = data.get("zoom", 1.0)
        ///     preferred_color = data.get("my_color", Color.white)
        /// </code></para>
        /// </summary>
        [GodotMethod("set_state")]
        public virtual void SetState(Godot.Collections.Dictionary state)
        {
            return;
        }

        /// <summary>
        /// <para>Restore the plugin GUI layout and data saved by <see cref="Godot.EditorPlugin.GetWindowLayout"/>. This method is called for every plugin on editor startup. Use the provided <c>configuration</c> file to read your saved data.</para>
        /// <para><code>
        /// func set_window_layout(configuration):
        ///     $Window.position = configuration.get_value("MyPlugin", "window_position", Vector2())
        ///     $Icon.modulate = configuration.get_value("MyPlugin", "icon_color", Color.white)
        /// </code></para>
        /// </summary>
        [GodotMethod("set_window_layout")]
        public virtual void SetWindowLayout(ConfigFile layout)
        {
            return;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_control_to_container");

        /// <summary>
        /// <para>Adds a custom control to a container (see <see cref="Godot.EditorPlugin.CustomControlContainer"/>). There are many locations where custom controls can be added in the editor UI.</para>
        /// <para>Please remember that you have to manage the visibility of your custom controls yourself (and likely hide it after adding it).</para>
        /// <para>When your plugin is deactivated, make sure to remove your custom control with <see cref="Godot.EditorPlugin.RemoveControlFromContainer"/> and free it with <see cref="Godot.Node.QueueFree"/>.</para>
        /// </summary>
        [GodotMethod("add_control_to_container")]
        public void AddControlToContainer(EditorPlugin.CustomControlContainer container, Control control)
        {
            NativeCalls.godot_icall_2_390(method_bind_0, Object.GetPtr(this), (int)container, Object.GetPtr(control));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_control_to_bottom_panel");

        /// <summary>
        /// <para>Adds a control to the bottom panel (together with Output, Debug, Animation, etc). Returns a reference to the button added. It's up to you to hide/show the button when needed. When your plugin is deactivated, make sure to remove your custom control with <see cref="Godot.EditorPlugin.RemoveControlFromBottomPanel"/> and free it with <see cref="Godot.Node.QueueFree"/>.</para>
        /// </summary>
        [GodotMethod("add_control_to_bottom_panel")]
        public ToolButton AddControlToBottomPanel(Control control, string title)
        {
            return EditorNativeCalls.godot_icall_2_391(method_bind_1, Object.GetPtr(this), Object.GetPtr(control), title);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_control_to_dock");

        /// <summary>
        /// <para>Adds the control to a specific dock slot (see <see cref="Godot.EditorPlugin.DockSlot"/> for options).</para>
        /// <para>If the dock is repositioned and as long as the plugin is active, the editor will save the dock position on further sessions.</para>
        /// <para>When your plugin is deactivated, make sure to remove your custom control with <see cref="Godot.EditorPlugin.RemoveControlFromDocks"/> and free it with <see cref="Godot.Node.QueueFree"/>.</para>
        /// </summary>
        [GodotMethod("add_control_to_dock")]
        public void AddControlToDock(EditorPlugin.DockSlot slot, Control control)
        {
            NativeCalls.godot_icall_2_390(method_bind_2, Object.GetPtr(this), (int)slot, Object.GetPtr(control));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_control_from_docks");

        /// <summary>
        /// <para>Removes the control from the dock. You have to manually <see cref="Godot.Node.QueueFree"/> the control.</para>
        /// </summary>
        [GodotMethod("remove_control_from_docks")]
        public void RemoveControlFromDocks(Control control)
        {
            NativeCalls.godot_icall_1_53(method_bind_3, Object.GetPtr(this), Object.GetPtr(control));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_control_from_bottom_panel");

        /// <summary>
        /// <para>Removes the control from the bottom panel. You have to manually <see cref="Godot.Node.QueueFree"/> the control.</para>
        /// </summary>
        [GodotMethod("remove_control_from_bottom_panel")]
        public void RemoveControlFromBottomPanel(Control control)
        {
            NativeCalls.godot_icall_1_53(method_bind_4, Object.GetPtr(this), Object.GetPtr(control));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_control_from_container");

        /// <summary>
        /// <para>Removes the control from the specified container. You have to manually <see cref="Godot.Node.QueueFree"/> the control.</para>
        /// </summary>
        [GodotMethod("remove_control_from_container")]
        public void RemoveControlFromContainer(EditorPlugin.CustomControlContainer container, Control control)
        {
            NativeCalls.godot_icall_2_390(method_bind_5, Object.GetPtr(this), (int)container, Object.GetPtr(control));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_tool_menu_item");

        /// <summary>
        /// <para>Adds a custom menu item to Project &gt; Tools as <c>name</c> that calls <c>callback</c> on an instance of <c>handler</c> with a parameter <c>ud</c> when user activates it.</para>
        /// </summary>
        [GodotMethod("add_tool_menu_item")]
        public void AddToolMenuItem(string name, Object handler, string callback, object ud = null)
        {
            EditorNativeCalls.godot_icall_4_392(method_bind_6, Object.GetPtr(this), name, Object.GetPtr(handler), callback, ud);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_tool_submenu_item");

        /// <summary>
        /// <para>Adds a custom submenu under Project &gt; Tools &gt; <c>name</c>. <c>submenu</c> should be an object of class <see cref="Godot.PopupMenu"/>. This submenu should be cleaned up using <c>remove_tool_menu_item(name)</c>.</para>
        /// </summary>
        [GodotMethod("add_tool_submenu_item")]
        public void AddToolSubmenuItem(string name, Object submenu)
        {
            NativeCalls.godot_icall_2_377(method_bind_7, Object.GetPtr(this), name, Object.GetPtr(submenu));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_tool_menu_item");

        /// <summary>
        /// <para>Removes a menu <c>name</c> from Project &gt; Tools.</para>
        /// </summary>
        [GodotMethod("remove_tool_menu_item")]
        public void RemoveToolMenuItem(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_8, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_custom_type");

        /// <summary>
        /// <para>Adds a custom type, which will appear in the list of nodes or resources. An icon can be optionally passed.</para>
        /// <para>When given node or resource is selected, the base type will be instanced (ie, "Spatial", "Control", "Resource"), then the script will be loaded and set to this object.</para>
        /// <para>You can use the virtual method <see cref="Godot.EditorPlugin.Handles"/> to check if your custom object is being edited by checking the script or using the <c>is</c> keyword.</para>
        /// <para>During run-time, this will be a simple object with a script so this function does not need to be called then.</para>
        /// </summary>
        [GodotMethod("add_custom_type")]
        public void AddCustomType(string type, string @base, Script script, Texture icon)
        {
            EditorNativeCalls.godot_icall_4_393(method_bind_9, Object.GetPtr(this), type, @base, Object.GetPtr(script), Object.GetPtr(icon));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_custom_type");

        /// <summary>
        /// <para>Removes a custom type added by <see cref="Godot.EditorPlugin.AddCustomType"/>.</para>
        /// </summary>
        [GodotMethod("remove_custom_type")]
        public void RemoveCustomType(string type)
        {
            NativeCalls.godot_icall_1_54(method_bind_10, Object.GetPtr(this), type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_autoload_singleton");

        /// <summary>
        /// <para>Adds a script at <c>path</c> to the Autoload list as <c>name</c>.</para>
        /// </summary>
        [GodotMethod("add_autoload_singleton")]
        public void AddAutoloadSingleton(string name, string path)
        {
            NativeCalls.godot_icall_2_107(method_bind_11, Object.GetPtr(this), name, path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_autoload_singleton");

        /// <summary>
        /// <para>Removes an Autoload <c>name</c> from the list.</para>
        /// </summary>
        [GodotMethod("remove_autoload_singleton")]
        public void RemoveAutoloadSingleton(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_12, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "update_overlays");

        /// <summary>
        /// <para>Updates the overlays of the 2D and 3D editor viewport. Causes methods <see cref="Godot.EditorPlugin.ForwardCanvasDrawOverViewport"/>, <see cref="Godot.EditorPlugin.ForwardCanvasForceDrawOverViewport"/>, <see cref="Godot.EditorPlugin.ForwardSpatialDrawOverViewport"/> and <see cref="Godot.EditorPlugin.ForwardSpatialForceDrawOverViewport"/> to be called.</para>
        /// </summary>
        [GodotMethod("update_overlays")]
        public int UpdateOverlays()
        {
            return NativeCalls.godot_icall_0_5(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "make_bottom_panel_item_visible");

        /// <summary>
        /// <para>Makes a specific item in the bottom panel visible.</para>
        /// </summary>
        [GodotMethod("make_bottom_panel_item_visible")]
        public void MakeBottomPanelItemVisible(Control item)
        {
            NativeCalls.godot_icall_1_53(method_bind_14, Object.GetPtr(this), Object.GetPtr(item));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "hide_bottom_panel");

        /// <summary>
        /// <para>Minimizes the bottom panel.</para>
        /// </summary>
        [GodotMethod("hide_bottom_panel")]
        public void HideBottomPanel()
        {
            NativeCalls.godot_icall_0_3(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_undo_redo");

        /// <summary>
        /// <para>Gets the undo/redo object. Most actions in the editor can be undoable, so use this object to make sure this happens when it's worth it.</para>
        /// </summary>
        [GodotMethod("get_undo_redo")]
        public UndoRedo GetUndoRedo()
        {
            return EditorNativeCalls.godot_icall_0_394(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "queue_save_layout");

        /// <summary>
        /// <para>Queue save the project's editor layout.</para>
        /// </summary>
        [GodotMethod("queue_save_layout")]
        public void QueueSaveLayout()
        {
            NativeCalls.godot_icall_0_3(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_import_plugin");

        /// <summary>
        /// <para>Registers a new <see cref="Godot.EditorImportPlugin"/>. Import plugins are used to import custom and unsupported assets as a custom <see cref="Godot.Resource"/> type.</para>
        /// <para>Note: If you want to import custom 3D asset formats use <see cref="Godot.EditorPlugin.AddSceneImportPlugin"/> instead.</para>
        /// <para>See <see cref="Godot.EditorPlugin.AddInspectorPlugin"/> for an example of how to register a plugin.</para>
        /// </summary>
        [GodotMethod("add_import_plugin")]
        public void AddImportPlugin(EditorImportPlugin importer)
        {
            NativeCalls.godot_icall_1_24(method_bind_18, Object.GetPtr(this), Object.GetPtr(importer));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_import_plugin");

        /// <summary>
        /// <para>Removes an import plugin registered by <see cref="Godot.EditorPlugin.AddImportPlugin"/>.</para>
        /// </summary>
        [GodotMethod("remove_import_plugin")]
        public void RemoveImportPlugin(EditorImportPlugin importer)
        {
            NativeCalls.godot_icall_1_24(method_bind_19, Object.GetPtr(this), Object.GetPtr(importer));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_scene_import_plugin");

        /// <summary>
        /// <para>Registers a new <see cref="Godot.EditorSceneImporter"/>. Scene importers are used to import custom 3D asset formats as scenes.</para>
        /// </summary>
        [GodotMethod("add_scene_import_plugin")]
        public void AddSceneImportPlugin(EditorSceneImporter sceneImporter)
        {
            NativeCalls.godot_icall_1_24(method_bind_20, Object.GetPtr(this), Object.GetPtr(sceneImporter));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_scene_import_plugin");

        /// <summary>
        /// <para>Removes a scene importer registered by <see cref="Godot.EditorPlugin.AddSceneImportPlugin"/>.</para>
        /// </summary>
        [GodotMethod("remove_scene_import_plugin")]
        public void RemoveSceneImportPlugin(EditorSceneImporter sceneImporter)
        {
            NativeCalls.godot_icall_1_24(method_bind_21, Object.GetPtr(this), Object.GetPtr(sceneImporter));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_export_plugin");

        /// <summary>
        /// <para>Registers a new <see cref="Godot.EditorExportPlugin"/>. Export plugins are used to perform tasks when the project is being exported.</para>
        /// <para>See <see cref="Godot.EditorPlugin.AddInspectorPlugin"/> for an example of how to register a plugin.</para>
        /// </summary>
        [GodotMethod("add_export_plugin")]
        public void AddExportPlugin(EditorExportPlugin plugin)
        {
            NativeCalls.godot_icall_1_24(method_bind_22, Object.GetPtr(this), Object.GetPtr(plugin));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_export_plugin");

        /// <summary>
        /// <para>Removes an export plugin registered by <see cref="Godot.EditorPlugin.AddExportPlugin"/>.</para>
        /// </summary>
        [GodotMethod("remove_export_plugin")]
        public void RemoveExportPlugin(EditorExportPlugin plugin)
        {
            NativeCalls.godot_icall_1_24(method_bind_23, Object.GetPtr(this), Object.GetPtr(plugin));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_spatial_gizmo_plugin");

        /// <summary>
        /// <para>Registers a new <see cref="Godot.EditorSpatialGizmoPlugin"/>. Gizmo plugins are used to add custom gizmos to the 3D preview viewport for a <see cref="Godot.Spatial"/>.</para>
        /// <para>See <see cref="Godot.EditorPlugin.AddInspectorPlugin"/> for an example of how to register a plugin.</para>
        /// </summary>
        [GodotMethod("add_spatial_gizmo_plugin")]
        public void AddSpatialGizmoPlugin(EditorSpatialGizmoPlugin plugin)
        {
            NativeCalls.godot_icall_1_24(method_bind_24, Object.GetPtr(this), Object.GetPtr(plugin));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_spatial_gizmo_plugin");

        /// <summary>
        /// <para>Removes a gizmo plugin registered by <see cref="Godot.EditorPlugin.AddSpatialGizmoPlugin"/>.</para>
        /// </summary>
        [GodotMethod("remove_spatial_gizmo_plugin")]
        public void RemoveSpatialGizmoPlugin(EditorSpatialGizmoPlugin plugin)
        {
            NativeCalls.godot_icall_1_24(method_bind_25, Object.GetPtr(this), Object.GetPtr(plugin));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_inspector_plugin");

        /// <summary>
        /// <para>Registers a new <see cref="Godot.EditorInspectorPlugin"/>. Inspector plugins are used to extend <see cref="Godot.EditorInspector"/> and provide custom configuration tools for your object's properties.</para>
        /// <para>Note: Always use <see cref="Godot.EditorPlugin.RemoveInspectorPlugin"/> to remove the registered <see cref="Godot.EditorInspectorPlugin"/> when your <see cref="Godot.EditorPlugin"/> is disabled to prevent leaks and an unexpected behavior.</para>
        /// <para><code>
        /// const MyInspectorPlugin = preload("res://addons/your_addon/path/to/your/script.gd")
        /// var inspector_plugin = MyInspectorPlugin.new()
        /// 
        /// func _enter_tree():
        ///     add_inspector_plugin(inspector_plugin)
        /// 
        /// func _exit_tree():
        ///     remove_inspector_plugin(inspector_plugin)
        /// </code></para>
        /// </summary>
        [GodotMethod("add_inspector_plugin")]
        public void AddInspectorPlugin(EditorInspectorPlugin plugin)
        {
            NativeCalls.godot_icall_1_24(method_bind_26, Object.GetPtr(this), Object.GetPtr(plugin));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_inspector_plugin");

        /// <summary>
        /// <para>Removes an inspector plugin registered by <see cref="Godot.EditorPlugin.AddImportPlugin"/></para>
        /// </summary>
        [GodotMethod("remove_inspector_plugin")]
        public void RemoveInspectorPlugin(EditorInspectorPlugin plugin)
        {
            NativeCalls.godot_icall_1_24(method_bind_27, Object.GetPtr(this), Object.GetPtr(plugin));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_input_event_forwarding_always_enabled");

        /// <summary>
        /// <para>Use this method if you always want to receive inputs from 3D view screen inside <see cref="Godot.EditorPlugin.ForwardSpatialGuiInput"/>. It might be especially usable if your plugin will want to use raycast in the scene.</para>
        /// </summary>
        [GodotMethod("set_input_event_forwarding_always_enabled")]
        public void SetInputEventForwardingAlwaysEnabled()
        {
            NativeCalls.godot_icall_0_3(method_bind_28, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_force_draw_over_forwarding_enabled");

        /// <summary>
        /// <para>Enables calling of <see cref="Godot.EditorPlugin.ForwardCanvasForceDrawOverViewport"/> for the 2D editor and <see cref="Godot.EditorPlugin.ForwardSpatialForceDrawOverViewport"/> for the 3D editor when their viewports are updated. You need to call this method only once and it will work permanently for this plugin.</para>
        /// </summary>
        [GodotMethod("set_force_draw_over_forwarding_enabled")]
        public void SetForceDrawOverForwardingEnabled()
        {
            NativeCalls.godot_icall_0_3(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_editor_interface");

        /// <summary>
        /// <para>Returns the <see cref="Godot.EditorInterface"/> object that gives you control over Godot editor's window and its functionalities.</para>
        /// </summary>
        [GodotMethod("get_editor_interface")]
        public EditorInterface GetEditorInterface()
        {
            return EditorNativeCalls.godot_icall_0_395(method_bind_30, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_script_create_dialog");

        /// <summary>
        /// <para>Gets the Editor's dialog used for making scripts.</para>
        /// <para>Note: Users can configure it before use.</para>
        /// <para>Warning: Removing and freeing this node will render a part of the editor useless and may cause a crash.</para>
        /// </summary>
        [GodotMethod("get_script_create_dialog")]
        public ScriptCreateDialog GetScriptCreateDialog()
        {
            return EditorNativeCalls.godot_icall_0_396(method_bind_31, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
