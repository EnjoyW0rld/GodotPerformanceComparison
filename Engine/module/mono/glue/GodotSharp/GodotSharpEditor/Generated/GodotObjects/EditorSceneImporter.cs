using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.EditorSceneImporter"/> allows to define an importer script for a third-party 3D format.</para>
    /// <para>To use <see cref="Godot.EditorSceneImporter"/>, register it using the <see cref="Godot.EditorPlugin.AddSceneImportPlugin"/> method first.</para>
    /// </summary>
    public partial class EditorSceneImporter : Reference
    {
        public const int ImportScene = 1;
        public const int ImportAnimation = 2;
        public const int ImportAnimationDetectLoop = 4;
        public const int ImportAnimationOptimize = 8;
        public const int ImportAnimationForceAllTracksInAllClips = 16;
        public const int ImportAnimationKeepValueTracks = 32;
        public const int ImportGenerateTangentArrays = 256;
        public const int ImportFailOnMissingDependencies = 512;
        public const int ImportMaterialsInInstances = 1024;

        private const string nativeName = "EditorSceneImporter";

        public EditorSceneImporter() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_EditorSceneImporter_Ctor(this);
        }

        internal EditorSceneImporter(bool memoryOwn) : base(memoryOwn) {}

        [GodotMethod("_get_extensions")]
        public virtual Godot.Collections.Array _GetExtensions()
        {
            return default(Godot.Collections.Array);
        }

        [GodotMethod("_get_import_flags")]
        public virtual int _GetImportFlags()
        {
            return default(int);
        }

        [GodotMethod("_import_animation")]
        public virtual Animation _ImportAnimation(string path, int flags, int bakeFps)
        {
            return default(Animation);
        }

        [GodotMethod("_import_scene")]
        public virtual Node _ImportScene(string path, int flags, int bakeFps)
        {
            return default(Node);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "import_scene_from_other_importer");

        [GodotMethod("import_scene_from_other_importer")]
        public Node ImportSceneFromOtherImporter(string path, uint flags, int bakeFps, uint compressFlags)
        {
            return EditorNativeCalls.godot_icall_4_404(method_bind_0, Object.GetPtr(this), path, flags, bakeFps, compressFlags);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "import_animation_from_other_importer");

        [GodotMethod("import_animation_from_other_importer")]
        public Animation ImportAnimationFromOtherImporter(string path, uint flags, int bakeFps)
        {
            return EditorNativeCalls.godot_icall_3_405(method_bind_1, Object.GetPtr(this), path, flags, bakeFps);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
