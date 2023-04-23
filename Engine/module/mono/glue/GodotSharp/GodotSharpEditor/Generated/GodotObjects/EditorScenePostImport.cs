using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Imported scenes can be automatically modified right after import by setting their Custom Script Import property to a <c>tool</c> script that inherits from this class.</para>
    /// <para>The <see cref="Godot.EditorScenePostImport.PostImport"/> callback receives the imported scene's root node and returns the modified version of the scene. Usage example:</para>
    /// <para><code>
    /// tool # Needed so it runs in editor
    /// extends EditorScenePostImport
    /// 
    /// # This sample changes all node names
    /// 
    /// # Called right after the scene is imported and gets the root node
    /// func post_import(scene):
    ///     # Change all node names to "modified_[oldnodename]"
    ///     iterate(scene)
    ///     return scene # Remember to return the imported scene
    /// 
    /// func iterate(node):
    ///     if node != null:
    ///         node.name = "modified_" + node.name
    ///         for child in node.get_children():
    ///             iterate(child)
    /// </code></para>
    /// </summary>
    public partial class EditorScenePostImport : Reference
    {
        private const string nativeName = "EditorScenePostImport";

        public EditorScenePostImport() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_EditorScenePostImport_Ctor(this);
        }

        internal EditorScenePostImport(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>Called after the scene was imported. This method must return the modified version of the scene.</para>
        /// </summary>
        [GodotMethod("post_import")]
        public virtual Object PostImport(Object scene)
        {
            return default(Object);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_source_folder");

        /// <summary>
        /// <para>Returns the resource folder the imported scene file is located in.</para>
        /// </summary>
        [GodotMethod("get_source_folder")]
        public string GetSourceFolder()
        {
            return NativeCalls.godot_icall_0_6(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_source_file");

        /// <summary>
        /// <para>Returns the source file path which got imported (e.g. <c>res://scene.dae</c>).</para>
        /// </summary>
        [GodotMethod("get_source_file")]
        public string GetSourceFile()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
