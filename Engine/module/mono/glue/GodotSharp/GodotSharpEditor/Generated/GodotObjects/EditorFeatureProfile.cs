using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>An editor feature profile can be used to disable specific features of the Godot editor. When disabled, the features won't appear in the editor, which makes the editor less cluttered. This is useful in education settings to reduce confusion or when working in a team. For example, artists and level designers could use a feature profile that disables the script editor to avoid accidentally making changes to files they aren't supposed to edit.</para>
    /// <para>To manage editor feature profiles visually, use Editor &gt; Manage Feature Profiles... at the top of the editor window.</para>
    /// </summary>
    public partial class EditorFeatureProfile : Reference
    {
        public enum Feature
        {
            /// <summary>
            /// <para>The 3D editor. If this feature is disabled, the 3D editor won't display but 3D nodes will still display in the Create New Node dialog.</para>
            /// </summary>
            Feature3d = 0,
            /// <summary>
            /// <para>The Script tab, which contains the script editor and class reference browser. If this feature is disabled, the Script tab won't display.</para>
            /// </summary>
            Script = 1,
            /// <summary>
            /// <para>The AssetLib tab. If this feature is disabled, the AssetLib tab won't display.</para>
            /// </summary>
            AssetLib = 2,
            /// <summary>
            /// <para>Scene tree editing. If this feature is disabled, the Scene tree dock will still be visible but will be read-only.</para>
            /// </summary>
            SceneTree = 3,
            /// <summary>
            /// <para>The Node dock. If this feature is disabled, signals and groups won't be visible and modifiable from the editor.</para>
            /// </summary>
            NodeDock = 4,
            /// <summary>
            /// <para>The FileSystem dock. If this feature is disabled, the FileSystem dock won't be visible.</para>
            /// </summary>
            FilesystemDock = 5,
            /// <summary>
            /// <para>The Import dock. If this feature is disabled, the Import dock won't be visible.</para>
            /// </summary>
            ImportDock = 6,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.EditorFeatureProfile.Feature"/> enum.</para>
            /// </summary>
            Max = 7
        }

        private const string nativeName = "EditorFeatureProfile";

        public EditorFeatureProfile() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_EditorFeatureProfile_Ctor(this);
        }

        internal EditorFeatureProfile(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_disable_class");

        /// <summary>
        /// <para>If <c>disable</c> is <c>true</c>, disables the class specified by <c>class_name</c>. When disabled, the class won't appear in the Create New Node dialog.</para>
        /// </summary>
        [GodotMethod("set_disable_class")]
        public void SetDisableClass(string className, bool disable)
        {
            NativeCalls.godot_icall_2_56(method_bind_0, Object.GetPtr(this), className, disable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_class_disabled");

        /// <summary>
        /// <para>Returns <c>true</c> if the class specified by <c>class_name</c> is disabled. When disabled, the class won't appear in the Create New Node dialog.</para>
        /// </summary>
        [GodotMethod("is_class_disabled")]
        public bool IsClassDisabled(string className)
        {
            return NativeCalls.godot_icall_1_108(method_bind_1, Object.GetPtr(this), className);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_disable_class_editor");

        /// <summary>
        /// <para>If <c>disable</c> is <c>true</c>, disables editing for the class specified by <c>class_name</c>. When disabled, the class will still appear in the Create New Node dialog but the inspector will be read-only when selecting a node that extends the class.</para>
        /// </summary>
        [GodotMethod("set_disable_class_editor")]
        public void SetDisableClassEditor(string className, bool disable)
        {
            NativeCalls.godot_icall_2_56(method_bind_2, Object.GetPtr(this), className, disable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_class_editor_disabled");

        /// <summary>
        /// <para>Returns <c>true</c> if editing for the class specified by <c>class_name</c> is disabled. When disabled, the class will still appear in the Create New Node dialog but the inspector will be read-only when selecting a node that extends the class.</para>
        /// </summary>
        [GodotMethod("is_class_editor_disabled")]
        public bool IsClassEditorDisabled(string className)
        {
            return NativeCalls.godot_icall_1_108(method_bind_3, Object.GetPtr(this), className);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_disable_class_property");

        /// <summary>
        /// <para>If <c>disable</c> is <c>true</c>, disables editing for <c>property</c> in the class specified by <c>class_name</c>. When a property is disabled, it won't appear in the inspector when selecting a node that extends the class specified by <c>class_name</c>.</para>
        /// </summary>
        [GodotMethod("set_disable_class_property")]
        public void SetDisableClassProperty(string className, string property, bool disable)
        {
            EditorNativeCalls.godot_icall_3_369(method_bind_4, Object.GetPtr(this), className, property, disable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_class_property_disabled");

        /// <summary>
        /// <para>Returns <c>true</c> if <c>property</c> is disabled in the class specified by <c>class_name</c>. When a property is disabled, it won't appear in the inspector when selecting a node that extends the class specified by <c>class_name</c>.</para>
        /// </summary>
        [GodotMethod("is_class_property_disabled")]
        public bool IsClassPropertyDisabled(string className, string property)
        {
            return NativeCalls.godot_icall_2_116(method_bind_5, Object.GetPtr(this), className, property);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_disable_feature");

        /// <summary>
        /// <para>If <c>disable</c> is <c>true</c>, disables the editor feature specified in <c>feature</c>. When a feature is disabled, it will disappear from the editor entirely.</para>
        /// </summary>
        [GodotMethod("set_disable_feature")]
        public void SetDisableFeature(EditorFeatureProfile.Feature feature, bool disable)
        {
            NativeCalls.godot_icall_2_23(method_bind_6, Object.GetPtr(this), (int)feature, disable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_feature_disabled");

        /// <summary>
        /// <para>Returns <c>true</c> if the <c>feature</c> is disabled. When a feature is disabled, it will disappear from the editor entirely.</para>
        /// </summary>
        [GodotMethod("is_feature_disabled")]
        public bool IsFeatureDisabled(EditorFeatureProfile.Feature feature)
        {
            return NativeCalls.godot_icall_1_35(method_bind_7, Object.GetPtr(this), (int)feature);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_feature_name");

        /// <summary>
        /// <para>Returns the specified <c>feature</c>'s human-readable name.</para>
        /// </summary>
        [GodotMethod("get_feature_name")]
        public string GetFeatureName(EditorFeatureProfile.Feature feature)
        {
            return NativeCalls.godot_icall_1_89(method_bind_8, Object.GetPtr(this), (int)feature);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "save_to_file");

        /// <summary>
        /// <para>Saves the editor feature profile to a file in JSON format. It can then be imported using the feature profile manager's Import button or the <see cref="Godot.EditorFeatureProfile.LoadFromFile"/> method.</para>
        /// </summary>
        [GodotMethod("save_to_file")]
        public Error SaveToFile(string path)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_9, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "load_from_file");

        /// <summary>
        /// <para>Loads an editor feature profile from a file. The file must follow the JSON format obtained by using the feature profile manager's Export button or the <see cref="Godot.EditorFeatureProfile.SaveToFile"/> method.</para>
        /// </summary>
        [GodotMethod("load_from_file")]
        public Error LoadFromFile(string path)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_10, Object.GetPtr(this), path);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
