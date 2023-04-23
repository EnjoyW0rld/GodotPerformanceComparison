using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The engine can save resources when you do it from the editor, or when you use the <see cref="Godot.ResourceSaver"/> singleton. This is accomplished thanks to multiple <see cref="Godot.ResourceFormatSaver"/>s, each handling its own format and called automatically by the engine.</para>
    /// <para>By default, Godot saves resources as <c>.tres</c> (text-based), <c>.res</c> (binary) or another built-in format, but you can choose to create your own format by extending this class. Be sure to respect the documented return types and values. You should give it a global class name with <c>class_name</c> for it to be registered. Like built-in ResourceFormatSavers, it will be called automatically when saving resources of its recognized type(s). You may also implement a <see cref="Godot.ResourceFormatLoader"/>.</para>
    /// </summary>
    public partial class ResourceFormatSaver : Reference
    {
        private const string nativeName = "ResourceFormatSaver";

        public ResourceFormatSaver() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ResourceFormatSaver_Ctor(this);
        }

        internal ResourceFormatSaver(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>Returns the list of extensions available for saving the resource object, provided it is recognized (see <see cref="Godot.ResourceFormatSaver.Recognize"/>).</para>
        /// </summary>
        [GodotMethod("get_recognized_extensions")]
        public virtual string[] GetRecognizedExtensions(Resource resource)
        {
            return default(string[]);
        }

        /// <summary>
        /// <para>Returns whether the given resource object can be saved by this saver.</para>
        /// </summary>
        [GodotMethod("recognize")]
        public virtual bool Recognize(Resource resource)
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Saves the given resource object to a file at the target <c>path</c>. <c>flags</c> is a bitmask composed with <see cref="Godot.ResourceSaver.SaverFlags"/> constants.</para>
        /// <para>Returns <c>OK</c> on success, or an <see cref="Godot.Error"/> constant in case of failure.</para>
        /// </summary>
        [GodotMethod("save")]
        public virtual int Save(string path, Resource resource, int flags)
        {
            return default(int);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
