using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Singleton for saving Godot-specific resource types to the filesystem.</para>
    /// <para>It uses the many <see cref="Godot.ResourceFormatSaver"/> classes registered in the engine (either built-in or from a plugin) to save engine-specific resource data to text-based (e.g. <c>.tres</c> or <c>.tscn</c>) or binary files (e.g. <c>.res</c> or <c>.scn</c>).</para>
    /// </summary>
    public static partial class ResourceSaver
    {
        public enum SaverFlags
        {
            /// <summary>
            /// <para>Save the resource with a path relative to the scene which uses it.</para>
            /// </summary>
            RelativePaths = 1,
            /// <summary>
            /// <para>Bundles external resources.</para>
            /// </summary>
            BundleResources = 2,
            /// <summary>
            /// <para>Changes the <see cref="Godot.Resource.ResourcePath"/> of the saved resource to match its new location.</para>
            /// </summary>
            ChangePath = 4,
            /// <summary>
            /// <para>Do not save editor-specific metadata (identified by their <c>__editor</c> prefix).</para>
            /// </summary>
            OmitEditorProperties = 8,
            /// <summary>
            /// <para>Save as big endian (see <see cref="Godot.File.EndianSwap"/>).</para>
            /// </summary>
            SaveBigEndian = 16,
            /// <summary>
            /// <para>Compress the resource on save using <see cref="Godot.File.CompressionMode.Zstd"/>. Only available for binary resource types.</para>
            /// </summary>
            Compress = 32,
            /// <summary>
            /// <para>Take over the paths of the saved subresources (see <see cref="Godot.Resource.TakeOverPath"/>).</para>
            /// </summary>
            ReplaceSubresourcePaths = 64
        }

        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(ResourceSaver).Name);
                return singleton;
            }
        }

        private const string nativeName = "_ResourceSaver";
        internal static IntPtr ptr = NativeCalls.godot_icall__ResourceSaver_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "save");

        /// <summary>
        /// <para>Saves a resource to disk to the given path, using a <see cref="Godot.ResourceFormatSaver"/> that recognizes the resource object.</para>
        /// <para>The <c>flags</c> bitmask can be specified to customize the save behavior.</para>
        /// <para>Returns <c>OK</c> on success.</para>
        /// </summary>
        [GodotMethod("save")]
        public static Error Save(string path, Resource resource, ResourceSaver.SaverFlags flags = (ResourceSaver.SaverFlags)0)
        {
            return (Error)NativeCalls.godot_icall_3_1224(method_bind_0, ptr, path, Object.GetPtr(resource), (int)flags);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_recognized_extensions");

        /// <summary>
        /// <para>Returns the list of extensions available for saving a resource of a given type.</para>
        /// </summary>
        [GodotMethod("get_recognized_extensions")]
        public static string[] GetRecognizedExtensions(Resource type)
        {
            return NativeCalls.godot_icall_1_1225(method_bind_1, ptr, Object.GetPtr(type));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
