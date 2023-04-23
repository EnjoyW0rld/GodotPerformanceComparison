using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.EditorImportPlugin"/>s provide a way to extend the editor's resource import functionality. Use them to import resources from custom files or to provide alternatives to the editor's existing importers.</para>
    /// <para>EditorImportPlugins work by associating with specific file extensions and a resource type. See <see cref="Godot.EditorImportPlugin.GetRecognizedExtensions"/> and <see cref="Godot.EditorImportPlugin.GetResourceType"/>. They may optionally specify some import presets that affect the import process. EditorImportPlugins are responsible for creating the resources and saving them in the <c>.import</c> directory (see ).</para>
    /// <para>Below is an example EditorImportPlugin that imports a <see cref="Godot.Mesh"/> from a file with the extension ".special" or ".spec":</para>
    /// <para><code>
    /// tool
    /// extends EditorImportPlugin
    /// 
    /// func get_importer_name():
    ///     return "my.special.plugin"
    /// 
    /// func get_visible_name():
    ///     return "Special Mesh"
    /// 
    /// func get_recognized_extensions():
    ///     return ["special", "spec"]
    /// 
    /// func get_save_extension():
    ///     return "mesh"
    /// 
    /// func get_resource_type():
    ///     return "Mesh"
    /// 
    /// func get_preset_count():
    ///     return 1
    /// 
    /// func get_preset_name(i):
    ///     return "Default"
    /// 
    /// func get_import_options(i):
    ///     return [{"name": "my_option", "default_value": false}]
    /// 
    /// func import(source_file, save_path, options, platform_variants, gen_files):
    ///     var file = File.new()
    ///     if file.open(source_file, File.READ) != OK:
    ///         return FAILED
    /// 
    ///     var mesh = Mesh.new()
    ///     # Fill the Mesh with data read in "file", left as an exercise to the reader
    /// 
    ///     var filename = save_path + "." + get_save_extension()
    ///     return ResourceSaver.save(filename, mesh)
    /// </code></para>
    /// <para>To use <see cref="Godot.EditorImportPlugin"/>, register it using the <see cref="Godot.EditorPlugin.AddImportPlugin"/> method first.</para>
    /// </summary>
    public partial class EditorImportPlugin : ResourceImporter
    {
        private const string nativeName = "EditorImportPlugin";

        public EditorImportPlugin() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_EditorImportPlugin_Ctor(this);
        }

        internal EditorImportPlugin(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>Gets the options and default values for the preset at this index. Returns an Array of Dictionaries with the following keys: <c>name</c>, <c>default_value</c>, <c>property_hint</c> (optional), <c>hint_string</c> (optional), <c>usage</c> (optional).</para>
        /// </summary>
        [GodotMethod("get_import_options")]
        public virtual Godot.Collections.Array GetImportOptions(int preset)
        {
            return default(Godot.Collections.Array);
        }

        /// <summary>
        /// <para>Gets the order of this importer to be run when importing resources. Importers with lower import orders will be called first, and higher values will be called later. Use this to ensure the importer runs after the dependencies are already imported. The default import order is <c>0</c> unless overridden by a specific importer. See <see cref="Godot.ResourceImporter.ImportOrder"/> for some predefined values.</para>
        /// </summary>
        [GodotMethod("get_import_order")]
        public virtual int GetImportOrder()
        {
            return default(int);
        }

        /// <summary>
        /// <para>Gets the unique name of the importer.</para>
        /// </summary>
        [GodotMethod("get_importer_name")]
        public virtual string GetImporterName()
        {
            return default(string);
        }

        /// <summary>
        /// <para>This method can be overridden to hide specific import options if conditions are met. This is mainly useful for hiding options that depend on others if one of them is disabled. For example:</para>
        /// <para><code>
        /// func get_option_visibility(option, options):
        ///     # Only show the lossy quality setting if the compression mode is set to "Lossy".
        ///     if option == "compress/lossy_quality" and options.has("compress/mode"):
        ///         return int(options["compress/mode"]) == COMPRESS_LOSSY
        /// 
        ///     return true
        /// </code></para>
        /// <para>Return <c>true</c> to make all options always visible.</para>
        /// </summary>
        [GodotMethod("get_option_visibility")]
        public virtual bool GetOptionVisibility(string option, Godot.Collections.Dictionary options)
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Gets the number of initial presets defined by the plugin. Use <see cref="Godot.EditorImportPlugin.GetImportOptions"/> to get the default options for the preset and <see cref="Godot.EditorImportPlugin.GetPresetName"/> to get the name of the preset.</para>
        /// </summary>
        [GodotMethod("get_preset_count")]
        public virtual int GetPresetCount()
        {
            return default(int);
        }

        /// <summary>
        /// <para>Gets the name of the options preset at this index.</para>
        /// </summary>
        [GodotMethod("get_preset_name")]
        public virtual string GetPresetName(int preset)
        {
            return default(string);
        }

        /// <summary>
        /// <para>Gets the priority of this plugin for the recognized extension. Higher priority plugins will be preferred. The default priority is <c>1.0</c>.</para>
        /// </summary>
        [GodotMethod("get_priority")]
        public virtual float GetPriority()
        {
            return default(float);
        }

        /// <summary>
        /// <para>Gets the list of file extensions to associate with this loader (case-insensitive). e.g. <c>["obj"]</c>.</para>
        /// </summary>
        [GodotMethod("get_recognized_extensions")]
        public virtual Godot.Collections.Array GetRecognizedExtensions()
        {
            return default(Godot.Collections.Array);
        }

        /// <summary>
        /// <para>Gets the Godot resource type associated with this loader. e.g. <c>"Mesh"</c> or <c>"Animation"</c>.</para>
        /// </summary>
        [GodotMethod("get_resource_type")]
        public virtual string GetResourceType()
        {
            return default(string);
        }

        /// <summary>
        /// <para>Gets the extension used to save this resource in the <c>.import</c> directory (see ).</para>
        /// </summary>
        [GodotMethod("get_save_extension")]
        public virtual string GetSaveExtension()
        {
            return default(string);
        }

        /// <summary>
        /// <para>Gets the name to display in the import window. You should choose this name as a continuation to "Import as", e.g. "Import as Special Mesh".</para>
        /// </summary>
        [GodotMethod("get_visible_name")]
        public virtual string GetVisibleName()
        {
            return default(string);
        }

        /// <summary>
        /// <para>Imports <c>source_file</c> into <c>save_path</c> with the import <c>options</c> specified. The <c>platform_variants</c> and <c>gen_files</c> arrays will be modified by this function.</para>
        /// <para>This method must be overridden to do the actual importing work. See this class' description for an example of overriding this method.</para>
        /// </summary>
        [GodotMethod("import")]
        public virtual int Import(string sourceFile, string savePath, Godot.Collections.Dictionary options, Godot.Collections.Array platformVariants, Godot.Collections.Array genFiles)
        {
            return default(int);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
