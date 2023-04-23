using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Godot loads resources in the editor or in exported games using ResourceFormatLoaders. They are queried automatically via the <see cref="Godot.ResourceLoader"/> singleton, or when a resource with internal dependencies is loaded. Each file type may load as a different resource type, so multiple ResourceFormatLoaders are registered in the engine.</para>
    /// <para>Extending this class allows you to define your own loader. Be sure to respect the documented return types and values. You should give it a global class name with <c>class_name</c> for it to be registered. Like built-in ResourceFormatLoaders, it will be called automatically when loading resources of its handled type(s). You may also implement a <see cref="Godot.ResourceFormatSaver"/>.</para>
    /// <para>Note: You can also extend <see cref="Godot.EditorImportPlugin"/> if the resource type you need exists but Godot is unable to load its format. Choosing one way over another depends on if the format is suitable or not for the final exported game. For example, it's better to import <c>.png</c> textures as <c>.stex</c> (<see cref="Godot.StreamTexture"/>) first, so they can be loaded with better efficiency on the graphics card.</para>
    /// </summary>
    public partial class ResourceFormatLoader : Reference
    {
        private const string nativeName = "ResourceFormatLoader";

        public ResourceFormatLoader() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ResourceFormatLoader_Ctor(this);
        }

        internal ResourceFormatLoader(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>If implemented, gets the dependencies of a given resource. If <c>add_types</c> is <c>true</c>, paths should be appended <c>::TypeName</c>, where <c>TypeName</c> is the class name of the dependency.</para>
        /// <para>Note: Custom resource types defined by scripts aren't known by the <see cref="Godot.ClassDB"/>, so you might just return <c>"Resource"</c> for them.</para>
        /// </summary>
        [GodotMethod("get_dependencies")]
        public virtual void GetDependencies(string path, string addTypes)
        {
            return;
        }

        /// <summary>
        /// <para>Gets the list of extensions for files this loader is able to read.</para>
        /// </summary>
        [GodotMethod("get_recognized_extensions")]
        public virtual string[] GetRecognizedExtensions()
        {
            return default(string[]);
        }

        /// <summary>
        /// <para>Gets the class name of the resource associated with the given path. If the loader cannot handle it, it should return <c>""</c>.</para>
        /// <para>Note: Custom resource types defined by scripts aren't known by the <see cref="Godot.ClassDB"/>, so you might just return <c>"Resource"</c> for them.</para>
        /// </summary>
        [GodotMethod("get_resource_type")]
        public virtual string GetResourceType(string path)
        {
            return default(string);
        }

        /// <summary>
        /// <para>Tells which resource class this loader can load.</para>
        /// <para>Note: Custom resource types defined by scripts aren't known by the <see cref="Godot.ClassDB"/>, so you might just handle <c>"Resource"</c> for them.</para>
        /// </summary>
        [GodotMethod("handles_type")]
        public virtual bool HandlesType(string typename)
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Loads a resource when the engine finds this loader to be compatible. If the loaded resource is the result of an import, <c>original_path</c> will target the source file. Returns a <see cref="Godot.Resource"/> object on success, or an <see cref="Godot.Error"/> constant in case of failure.</para>
        /// </summary>
        [GodotMethod("load")]
        public virtual object Load(string path, string originalPath)
        {
            return default(object);
        }

        /// <summary>
        /// <para>If implemented, renames dependencies within the given resource and saves it. <c>renames</c> is a dictionary <c>{ String =&gt; String }</c> mapping old dependency paths to new paths.</para>
        /// <para>Returns <c>OK</c> on success, or an <see cref="Godot.Error"/> constant in case of failure.</para>
        /// </summary>
        [GodotMethod("rename_dependencies")]
        public virtual int RenameDependencies(string path, string renames)
        {
            return default(int);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
