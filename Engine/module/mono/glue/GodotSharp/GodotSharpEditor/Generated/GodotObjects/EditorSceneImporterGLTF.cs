using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Note: This class is only compiled in editor builds. Run-time glTF loading and saving is not available in exported projects. References to <see cref="Godot.EditorSceneImporterGLTF"/> within a script will cause an error in an exported project.</para>
    /// </summary>
    public partial class EditorSceneImporterGLTF : EditorSceneImporter
    {
        private const string nativeName = "EditorSceneImporterGLTF";

        public EditorSceneImporterGLTF() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_EditorSceneImporterGLTF_Ctor(this);
        }

        internal EditorSceneImporterGLTF(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
