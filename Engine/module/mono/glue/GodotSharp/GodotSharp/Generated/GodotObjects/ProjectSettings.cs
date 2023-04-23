using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Contains global variables accessible from everywhere. Use <see cref="Godot.ProjectSettings.GetSetting"/>, <see cref="Godot.ProjectSettings.SetSetting"/> or <see cref="Godot.ProjectSettings.HasSetting"/> to access them. Variables stored in <c>project.godot</c> are also loaded into ProjectSettings, making this object very useful for reading custom game configuration options.</para>
    /// <para>When naming a Project Settings property, use the full path to the setting including the category. For example, <c>"application/config/name"</c> for the project name. Category and property names can be viewed in the Project Settings dialog.</para>
    /// <para>Feature tags: Project settings can be overridden for specific platforms and configurations (debug, release, ...) using <a href="$DOCS_URL/tutorials/export/feature_tags.html">feature tags</a>.</para>
    /// <para>Overriding: Any project setting can be overridden by creating a file named <c>override.cfg</c> in the project's root directory. This can also be used in exported projects by placing this file in the same directory as the project binary. Overriding will still take the base project settings' <a href="$DOCS_URL/tutorials/export/feature_tags.html">feature tags</a> in account. Therefore, make sure to also override the setting with the desired feature tags if you want them to override base project settings on all platforms and configurations.</para>
    /// </summary>
    public static partial class ProjectSettings
    {
        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(ProjectSettings).Name);
                return singleton;
            }
        }

        private const string nativeName = "ProjectSettings";
        internal static IntPtr ptr = NativeCalls.godot_icall_ProjectSettings_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_setting");

        /// <summary>
        /// <para>Returns <c>true</c> if a configuration value is present.</para>
        /// </summary>
        [GodotMethod("has_setting")]
        public static bool HasSetting(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_0, ptr, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_setting");

        /// <summary>
        /// <para>Sets the value of a setting.</para>
        /// <para>Example:</para>
        /// <para><code>
        /// ProjectSettings.set_setting("application/config/name", "Example")
        /// </code></para>
        /// <para>This can also be used to erase custom project settings. To do this change the setting value to <c>null</c>.</para>
        /// </summary>
        [GodotMethod("set_setting")]
        public static void SetSetting(string name, object value)
        {
            NativeCalls.godot_icall_2_96(method_bind_1, ptr, name, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_setting");

        /// <summary>
        /// <para>Returns the value of a setting.</para>
        /// <para>Example:</para>
        /// <para><code>
        /// print(ProjectSettings.get_setting("application/config/name"))
        /// </code></para>
        /// </summary>
        [GodotMethod("get_setting")]
        public static object GetSetting(string name)
        {
            return NativeCalls.godot_icall_1_97(method_bind_2, ptr, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_order");

        /// <summary>
        /// <para>Sets the order of a configuration value (influences when saved to the config file).</para>
        /// </summary>
        [GodotMethod("set_order")]
        public static void SetOrder(string name, int position)
        {
            NativeCalls.godot_icall_2_110(method_bind_3, ptr, name, position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_order");

        /// <summary>
        /// <para>Returns the order of a configuration value (influences when saved to the config file).</para>
        /// </summary>
        [GodotMethod("get_order")]
        public static int GetOrder(string name)
        {
            return NativeCalls.godot_icall_1_138(method_bind_4, ptr, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_initial_value");

        /// <summary>
        /// <para>Sets the specified property's initial value. This is the value the property reverts to.</para>
        /// </summary>
        [GodotMethod("set_initial_value")]
        public static void SetInitialValue(string name, object value)
        {
            NativeCalls.godot_icall_2_96(method_bind_5, ptr, name, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_property_info");

        /// <summary>
        /// <para>Adds a custom property info to a property. The dictionary must contain:</para>
        /// <para>- <c>name</c>: <see cref="string"/> (the property's name)</para>
        /// <para>- <c>type</c>: <see cref="int"/> (see <see cref="Godot.Variant.Type"/>)</para>
        /// <para>- optionally <c>hint</c>: <see cref="int"/> (see <see cref="Godot.PropertyHint"/>) and <c>hint_string</c>: <see cref="string"/></para>
        /// <para>Example:</para>
        /// <para><code>
        /// ProjectSettings.set("category/property_name", 0)
        /// 
        /// var property_info = {
        ///     "name": "category/property_name",
        ///     "type": TYPE_INT,
        ///     "hint": PROPERTY_HINT_ENUM,
        ///     "hint_string": "one,two,three"
        /// }
        /// 
        /// ProjectSettings.add_property_info(property_info)
        /// </code></para>
        /// </summary>
        [GodotMethod("add_property_info")]
        public static void AddPropertyInfo(Godot.Collections.Dictionary hint)
        {
            NativeCalls.godot_icall_1_213(method_bind_6, ptr, hint.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Clears the whole configuration (not recommended, may break things).</para>
        /// </summary>
        [GodotMethod("clear")]
        public static void Clear(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_7, ptr, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "localize_path");

        /// <summary>
        /// <para>Returns the localized path (starting with <c>res://</c>) corresponding to the absolute, native OS <c>path</c>. See also <see cref="Godot.ProjectSettings.GlobalizePath"/>.</para>
        /// </summary>
        [GodotMethod("localize_path")]
        public static string LocalizePath(string path)
        {
            return NativeCalls.godot_icall_1_124(method_bind_8, ptr, path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "globalize_path");

        /// <summary>
        /// <para>Returns the absolute, native OS path corresponding to the localized <c>path</c> (starting with <c>res://</c> or <c>user://</c>). The returned path will vary depending on the operating system and user preferences. See <a href="$DOCS_URL/tutorials/io/data_paths.html">File paths in Godot projects</a> to see what those paths convert to. See also <see cref="Godot.ProjectSettings.LocalizePath"/>.</para>
        /// <para>Note: <see cref="Godot.ProjectSettings.GlobalizePath"/> with <c>res://</c> will not work in an exported project. Instead, prepend the executable's base directory to the path when running from an exported project:</para>
        /// <para><code>
        /// var path = ""
        /// if OS.has_feature("editor"):
        ///     # Running from an editor binary.
        ///     # `path` will contain the absolute path to `hello.txt` located in the project root.
        ///     path = ProjectSettings.globalize_path("res://hello.txt")
        /// else:
        ///     # Running from an exported project.
        ///     # `path` will contain the absolute path to `hello.txt` next to the executable.
        ///     # This is *not* identical to using `ProjectSettings.globalize_path()` with a `res://` path,
        ///     # but is close enough in spirit.
        ///     path = OS.get_executable_path().get_base_dir().plus_file("hello.txt")
        /// </code></para>
        /// </summary>
        [GodotMethod("globalize_path")]
        public static string GlobalizePath(string path)
        {
            return NativeCalls.godot_icall_1_124(method_bind_9, ptr, path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "save");

        /// <summary>
        /// <para>Saves the configuration to the <c>project.godot</c> file.</para>
        /// <para>Note: This method is intended to be used by editor plugins, as modified <see cref="Godot.ProjectSettings"/> can't be loaded back in the running app. If you want to change project settings in exported projects, use <see cref="Godot.ProjectSettings.SaveCustom"/> to save <c>override.cfg</c> file.</para>
        /// </summary>
        [GodotMethod("save")]
        public static Error Save()
        {
            return (Error)NativeCalls.godot_icall_0_389(method_bind_10, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "load_resource_pack");

        /// <summary>
        /// <para>Loads the contents of the .pck or .zip file specified by <c>pack</c> into the resource filesystem (<c>res://</c>). Returns <c>true</c> on success.</para>
        /// <para>Note: If a file from <c>pack</c> shares the same path as a file already in the resource filesystem, any attempts to load that file will use the file from <c>pack</c> unless <c>replace_files</c> is set to <c>false</c>.</para>
        /// <para>Note: The optional <c>offset</c> parameter can be used to specify the offset in bytes to the start of the resource pack. This is only supported for .pck files.</para>
        /// </summary>
        [GodotMethod("load_resource_pack")]
        public static bool LoadResourcePack(string pack, bool replaceFiles = true, int offset = 0)
        {
            return NativeCalls.godot_icall_3_808(method_bind_11, ptr, pack, replaceFiles, offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "property_can_revert");

        /// <summary>
        /// <para>Returns <c>true</c> if the specified property exists and its initial value differs from the current value.</para>
        /// </summary>
        [GodotMethod("property_can_revert")]
        public static bool PropertyCanRevert(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_12, ptr, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "property_get_revert");

        /// <summary>
        /// <para>Returns the specified property's initial value. Returns <c>null</c> if the property does not exist.</para>
        /// </summary>
        [GodotMethod("property_get_revert")]
        public static object PropertyGetRevert(string name)
        {
            return NativeCalls.godot_icall_1_97(method_bind_13, ptr, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "save_custom");

        /// <summary>
        /// <para>Saves the configuration to a custom file. The file extension must be <c>.godot</c> (to save in text-based <see cref="Godot.ConfigFile"/> format) or <c>.binary</c> (to save in binary format). You can also save <c>override.cfg</c> file, which is also text, but can be used in exported projects unlike other formats.</para>
        /// </summary>
        [GodotMethod("save_custom")]
        public static Error SaveCustom(string file)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_14, ptr, file);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
