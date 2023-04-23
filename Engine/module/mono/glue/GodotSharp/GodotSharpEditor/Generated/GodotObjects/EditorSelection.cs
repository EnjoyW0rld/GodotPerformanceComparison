using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This object manages the SceneTree selection in the editor.</para>
    /// <para>Note: This class shouldn't be instantiated directly. Instead, access the singleton using <see cref="Godot.EditorInterface.GetSelection"/>.</para>
    /// </summary>
    public partial class EditorSelection : Object
    {
        private const string nativeName = "EditorSelection";

        public EditorSelection() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_EditorSelection_Ctor(this);
        }

        internal EditorSelection(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Clear the selection.</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_node");

        /// <summary>
        /// <para>Adds a node to the selection.</para>
        /// <para>Note: The newly selected node will not be automatically edited in the inspector. If you want to edit a node, use <see cref="Godot.EditorInterface.EditNode"/>.</para>
        /// </summary>
        [GodotMethod("add_node")]
        public void AddNode(Node node)
        {
            NativeCalls.godot_icall_1_53(method_bind_1, Object.GetPtr(this), Object.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_node");

        /// <summary>
        /// <para>Removes a node from the selection.</para>
        /// </summary>
        [GodotMethod("remove_node")]
        public void RemoveNode(Node node)
        {
            NativeCalls.godot_icall_1_53(method_bind_2, Object.GetPtr(this), Object.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_selected_nodes");

        /// <summary>
        /// <para>Gets the list of selected nodes.</para>
        /// </summary>
        [GodotMethod("get_selected_nodes")]
        public Godot.Collections.Array GetSelectedNodes()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_3, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_transformable_selected_nodes");

        /// <summary>
        /// <para>Gets the list of selected nodes, optimized for transform operations (i.e. moving them, rotating, etc). This list avoids situations where a node is selected and also child/grandchild.</para>
        /// </summary>
        [GodotMethod("get_transformable_selected_nodes")]
        public Godot.Collections.Array GetTransformableSelectedNodes()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_4, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
