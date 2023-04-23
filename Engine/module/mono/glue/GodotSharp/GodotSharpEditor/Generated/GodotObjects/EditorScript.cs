using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Scripts extending this class and implementing its <see cref="Godot.EditorScript._Run"/> method can be executed from the Script Editor's File &gt; Run menu option (or by pressing <c>Ctrl+Shift+X</c>) while the editor is running. This is useful for adding custom in-editor functionality to Godot. For more complex additions, consider using <see cref="Godot.EditorPlugin"/>s instead.</para>
    /// <para>Note: Extending scripts need to have <c>tool</c> mode enabled.</para>
    /// <para>Example script:</para>
    /// <para><code>
    /// tool
    /// extends EditorScript
    /// 
    /// func _run():
    ///     print("Hello from the Godot Editor!")
    /// </code></para>
    /// <para>Note: The script is run in the Editor context, which means the output is visible in the console window started with the Editor (stdout) instead of the usual Godot Output dock.</para>
    /// <para>Note: EditorScript is reference counted, meaning it is destroyed when nothing references it. This can cause errors during asynchronous operations if there are no references to the script.</para>
    /// </summary>
    public partial class EditorScript : Reference
    {
        private const string nativeName = "EditorScript";

        public EditorScript() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_EditorScript_Ctor(this);
        }

        internal EditorScript(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>This method is executed by the Editor when File &gt; Run is used.</para>
        /// </summary>
        [GodotMethod("_run")]
        public virtual void _Run()
        {
            return;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_root_node");

        /// <summary>
        /// <para>Adds <c>node</c> as a child of the root node in the editor context.</para>
        /// <para>Warning: The implementation of this method is currently disabled.</para>
        /// </summary>
        [GodotMethod("add_root_node")]
        public void AddRootNode(Node node)
        {
            NativeCalls.godot_icall_1_53(method_bind_0, Object.GetPtr(this), Object.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_scene");

        /// <summary>
        /// <para>Returns the Editor's currently active scene.</para>
        /// </summary>
        [GodotMethod("get_scene")]
        public Node GetScene()
        {
            return NativeCalls.godot_icall_0_257(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_editor_interface");

        /// <summary>
        /// <para>Returns the <see cref="Godot.EditorInterface"/> singleton instance.</para>
        /// </summary>
        [GodotMethod("get_editor_interface")]
        public EditorInterface GetEditorInterface()
        {
            return EditorNativeCalls.godot_icall_0_395(method_bind_2, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
