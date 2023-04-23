using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This is an FBX 3D asset importer with full support for most FBX features.</para>
    /// <para>If exporting a FBX scene from Autodesk Maya, use these FBX export settings:</para>
    /// <para><code>
    /// - Smoothing Groups
    /// - Smooth Mesh
    /// - Triangluate (for meshes with blend shapes)
    /// - Bake Animation
    /// - Resample All
    /// - Deformed Models
    /// - Skins
    /// - Blend Shapes
    /// - Curve Filters
    /// - Constant Key Reducer
    /// - Auto Tangents Only
    /// - *Do not check* Constraints (as it will break the file)
    /// - Can check Embed Media (embeds textures into the exported FBX file)
    ///   - Note that when importing embedded media, the texture and mesh will be a single immutable file.
    ///   - You will have to re-export then re-import the FBX if the texture has changed.
    /// - Units: Centimeters
    /// - Up Axis: Y
    /// - Binary format in FBX 2017
    /// </code></para>
    /// </summary>
    public partial class EditorSceneImporterFBX : EditorSceneImporter
    {
        private const string nativeName = "EditorSceneImporterFBX";

        public EditorSceneImporterFBX() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_EditorSceneImporterFBX_Ctor(this);
        }

        internal EditorSceneImporterFBX(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
