using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Object that holds the project-independent editor settings. These settings are generally visible in the Editor &gt; Editor Settings menu.</para>
    /// <para>Property names use slash delimiters to distinguish sections. Setting values can be of any <c>Variant</c> type. It's recommended to use <c>snake_case</c> for editor settings to be consistent with the Godot editor itself.</para>
    /// <para>Accessing the settings can be done using the following methods, such as:</para>
    /// <para><code>
    /// # `settings.set("some/property", value)` also works as this class overrides `_set()` internally.
    /// settings.set_setting("some/property",value)
    /// 
    /// # `settings.get("some/property", value)` also works as this class overrides `_get()` internally.
    /// settings.get_setting("some/property")
    /// 
    /// var list_of_settings = settings.get_property_list()
    /// </code></para>
    /// <para>Note: This class shouldn't be instantiated directly. Instead, access the singleton using <see cref="Godot.EditorInterface.GetEditorSettings"/>.</para>
    /// </summary>
    public abstract partial class EditorSettings : Resource
    {
        /// <summary>
        /// <para>Emitted after any editor setting has changed. It's used by various editor plugins to update their visuals on theme changes or logic on configuration changes.</para>
        /// </summary>
        public const int NotificationEditorSettingsChanged = 10000;

        private const string nativeName = "EditorSettings";

        internal EditorSettings() {}

        internal EditorSettings(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_setting");

        /// <summary>
        /// <para>Returns <c>true</c> if the setting specified by <c>name</c> exists, <c>false</c> otherwise.</para>
        /// </summary>
        [GodotMethod("has_setting")]
        public bool HasSetting(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_0, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_setting");

        /// <summary>
        /// <para>Sets the <c>value</c> of the setting specified by <c>name</c>. This is equivalent to using <see cref="Godot.Object.Set"/> on the EditorSettings instance.</para>
        /// </summary>
        [GodotMethod("set_setting")]
        public void SetSetting(string name, object value)
        {
            NativeCalls.godot_icall_2_96(method_bind_1, Object.GetPtr(this), name, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_setting");

        /// <summary>
        /// <para>Returns the value of the setting specified by <c>name</c>. This is equivalent to using <see cref="Godot.Object.Get"/> on the EditorSettings instance.</para>
        /// </summary>
        [GodotMethod("get_setting")]
        public object GetSetting(string name)
        {
            return NativeCalls.godot_icall_1_97(method_bind_2, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "erase");

        /// <summary>
        /// <para>Erases the setting whose name is specified by <c>property</c>.</para>
        /// </summary>
        [GodotMethod("erase")]
        public void Erase(string property)
        {
            NativeCalls.godot_icall_1_54(method_bind_3, Object.GetPtr(this), property);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_initial_value");

        /// <summary>
        /// <para>Sets the initial value of the setting specified by <c>name</c> to <c>value</c>. This is used to provide a value for the Revert button in the Editor Settings. If <c>update_current</c> is true, the current value of the setting will be set to <c>value</c> as well.</para>
        /// </summary>
        [GodotMethod("set_initial_value")]
        public void SetInitialValue(string name, object value, bool updateCurrent)
        {
            NativeCalls.godot_icall_3_406(method_bind_4, Object.GetPtr(this), name, value, updateCurrent);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "property_can_revert");

        /// <summary>
        /// <para>Returns <c>true</c> if the setting specified by <c>name</c> can have its value reverted to the default value, <c>false</c> otherwise. When this method returns <c>true</c>, a Revert button will display next to the setting in the Editor Settings.</para>
        /// </summary>
        [GodotMethod("property_can_revert")]
        public bool PropertyCanRevert(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_5, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "property_get_revert");

        /// <summary>
        /// <para>Returns the default value of the setting specified by <c>name</c>. This is the value that would be applied when clicking the Revert button in the Editor Settings.</para>
        /// </summary>
        [GodotMethod("property_get_revert")]
        public object PropertyGetRevert(string name)
        {
            return NativeCalls.godot_icall_1_97(method_bind_6, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_property_info");

        /// <summary>
        /// <para>Adds a custom property info to a property. The dictionary must contain:</para>
        /// <para>- <c>name</c>: <see cref="string"/> (the name of the property)</para>
        /// <para>- <c>type</c>: <see cref="int"/> (see <see cref="Godot.Variant.Type"/>)</para>
        /// <para>- optionally <c>hint</c>: <see cref="int"/> (see <see cref="Godot.PropertyHint"/>) and <c>hint_string</c>: <see cref="string"/></para>
        /// <para>Example:</para>
        /// <para><code>
        /// editor_settings.set("category/property_name", 0)
        /// 
        /// var property_info = {
        ///     "name": "category/property_name",
        ///     "type": TYPE_INT,
        ///     "hint": PROPERTY_HINT_ENUM,
        ///     "hint_string": "one,two,three"
        /// }
        /// 
        /// editor_settings.add_property_info(property_info)
        /// </code></para>
        /// </summary>
        [GodotMethod("add_property_info")]
        public void AddPropertyInfo(Godot.Collections.Dictionary info)
        {
            NativeCalls.godot_icall_1_213(method_bind_7, Object.GetPtr(this), info.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_settings_dir");

        /// <summary>
        /// <para>Gets the global settings path for the engine. Inside this path, you can find some standard paths such as:</para>
        /// <para><c>settings/tmp</c> - Used for temporary storage of files</para>
        /// <para><c>settings/templates</c> - Where export templates are located</para>
        /// </summary>
        [GodotMethod("get_settings_dir")]
        public string GetSettingsDir()
        {
            return NativeCalls.godot_icall_0_6(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_project_settings_dir");

        /// <summary>
        /// <para>Returns the project-specific settings path. Projects all have a unique subdirectory inside the settings path where project-specific settings are saved.</para>
        /// </summary>
        [GodotMethod("get_project_settings_dir")]
        public string GetProjectSettingsDir()
        {
            return NativeCalls.godot_icall_0_6(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_project_metadata");

        /// <summary>
        /// <para>Sets project-specific metadata with the <c>section</c>, <c>key</c> and <c>data</c> specified. This metadata is stored outside the project folder and therefore won't be checked into version control. See also <see cref="Godot.EditorSettings.GetProjectMetadata"/>.</para>
        /// </summary>
        [GodotMethod("set_project_metadata")]
        public void SetProjectMetadata(string section, string key, object data)
        {
            NativeCalls.godot_icall_3_307(method_bind_10, Object.GetPtr(this), section, key, data);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_project_metadata");

        /// <summary>
        /// <para>Returns project-specific metadata for the <c>section</c> and <c>key</c> specified. If the metadata doesn't exist, <c>default</c> will be returned instead. See also <see cref="Godot.EditorSettings.SetProjectMetadata"/>.</para>
        /// </summary>
        [GodotMethod("get_project_metadata")]
        public object GetProjectMetadata(string section, string key, object @default = null)
        {
            return NativeCalls.godot_icall_3_308(method_bind_11, Object.GetPtr(this), section, key, @default);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_favorites");

        /// <summary>
        /// <para>Sets the list of favorite files and directories for this project.</para>
        /// </summary>
        [GodotMethod("set_favorites")]
        public void SetFavorites(string[] dirs)
        {
            NativeCalls.godot_icall_1_407(method_bind_12, Object.GetPtr(this), dirs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_favorites");

        /// <summary>
        /// <para>Returns the list of favorite files and directories for this project.</para>
        /// </summary>
        [GodotMethod("get_favorites")]
        public string[] GetFavorites()
        {
            return NativeCalls.godot_icall_0_119(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_recent_dirs");

        /// <summary>
        /// <para>Sets the list of recently visited folders in the file dialog for this project.</para>
        /// </summary>
        [GodotMethod("set_recent_dirs")]
        public void SetRecentDirs(string[] dirs)
        {
            NativeCalls.godot_icall_1_407(method_bind_14, Object.GetPtr(this), dirs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_recent_dirs");

        /// <summary>
        /// <para>Returns the list of recently visited folders in the file dialog for this project.</para>
        /// </summary>
        [GodotMethod("get_recent_dirs")]
        public string[] GetRecentDirs()
        {
            return NativeCalls.godot_icall_0_119(method_bind_15, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
