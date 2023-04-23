using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Contains multiple nodes representing animation states, connected in a graph. Node transitions can be configured to happen automatically or via code, using a shortest-path algorithm. Retrieve the <see cref="Godot.AnimationNodeStateMachinePlayback"/> object from the <see cref="Godot.AnimationTree"/> node to control it programmatically.</para>
    /// <para>Example:</para>
    /// <para><code>
    /// var state_machine = $AnimationTree.get("parameters/playback")
    /// state_machine.travel("some_state")
    /// </code></para>
    /// </summary>
    public partial class AnimationNodeStateMachine : AnimationRootNode
    {
        private const string nativeName = "AnimationNodeStateMachine";

        public AnimationNodeStateMachine() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AnimationNodeStateMachine_Ctor(this);
        }

        internal AnimationNodeStateMachine(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_node");

        /// <summary>
        /// <para>Adds a new node to the graph. The <c>position</c> is used for display in the editor.</para>
        /// </summary>
        /// <param name="position">If the parameter is null, then the default value is new Vector2(0, 0)</param>
        [GodotMethod("add_node")]
        public void AddNode(string name, AnimationNode node, Nullable<Vector2> position = null)
        {
            Vector2 position_in = position.HasValue ? position.Value : new Vector2(0, 0);
            NativeCalls.godot_icall_3_105(method_bind_0, Object.GetPtr(this), name, Object.GetPtr(node), ref position_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "replace_node");

        /// <summary>
        /// <para>Replaces the node and keeps its transitions unchanged.</para>
        /// </summary>
        [GodotMethod("replace_node")]
        public void ReplaceNode(string name, AnimationNode node)
        {
            NativeCalls.godot_icall_2_114(method_bind_1, Object.GetPtr(this), name, Object.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node");

        /// <summary>
        /// <para>Returns the animation node with the given name.</para>
        /// </summary>
        [GodotMethod("get_node")]
        public AnimationNode GetNode(string name)
        {
            return NativeCalls.godot_icall_1_106(method_bind_2, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_node");

        /// <summary>
        /// <para>Deletes the given node from the graph.</para>
        /// </summary>
        [GodotMethod("remove_node")]
        public void RemoveNode(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_3, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rename_node");

        /// <summary>
        /// <para>Renames the given node.</para>
        /// </summary>
        [GodotMethod("rename_node")]
        public void RenameNode(string name, string newName)
        {
            NativeCalls.godot_icall_2_107(method_bind_4, Object.GetPtr(this), name, newName);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_node");

        /// <summary>
        /// <para>Returns <c>true</c> if the graph contains the given node.</para>
        /// </summary>
        [GodotMethod("has_node")]
        public bool HasNode(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_5, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_name");

        /// <summary>
        /// <para>Returns the given animation node's name.</para>
        /// </summary>
        [GodotMethod("get_node_name")]
        public string GetNodeName(AnimationNode node)
        {
            return NativeCalls.godot_icall_1_115(method_bind_6, Object.GetPtr(this), Object.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_node_position");

        /// <summary>
        /// <para>Sets the node's coordinates. Used for display in the editor.</para>
        /// </summary>
        [GodotMethod("set_node_position")]
        public void SetNodePosition(string name, Vector2 position)
        {
            NativeCalls.godot_icall_2_111(method_bind_7, Object.GetPtr(this), name, ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_position");

        /// <summary>
        /// <para>Returns the given node's coordinates. Used for display in the editor.</para>
        /// </summary>
        [GodotMethod("get_node_position")]
        public Vector2 GetNodePosition(string name)
        {
            NativeCalls.godot_icall_1_112(method_bind_8, Object.GetPtr(this), name, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_transition");

        /// <summary>
        /// <para>Returns <c>true</c> if there is a transition between the given nodes.</para>
        /// </summary>
        [GodotMethod("has_transition")]
        public bool HasTransition(string from, string to)
        {
            return NativeCalls.godot_icall_2_116(method_bind_9, Object.GetPtr(this), from, to);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_transition");

        /// <summary>
        /// <para>Adds a transition between the given nodes.</para>
        /// </summary>
        [GodotMethod("add_transition")]
        public void AddTransition(string from, string to, AnimationNodeStateMachineTransition transition)
        {
            NativeCalls.godot_icall_3_117(method_bind_10, Object.GetPtr(this), from, to, Object.GetPtr(transition));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_transition");

        /// <summary>
        /// <para>Returns the given transition.</para>
        /// </summary>
        [GodotMethod("get_transition")]
        public AnimationNodeStateMachineTransition GetTransition(int idx)
        {
            return NativeCalls.godot_icall_1_118(method_bind_11, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_transition_from");

        /// <summary>
        /// <para>Returns the given transition's start node.</para>
        /// </summary>
        [GodotMethod("get_transition_from")]
        public string GetTransitionFrom(int idx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_12, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_transition_to");

        /// <summary>
        /// <para>Returns the given transition's end node.</para>
        /// </summary>
        [GodotMethod("get_transition_to")]
        public string GetTransitionTo(int idx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_13, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_transition_count");

        /// <summary>
        /// <para>Returns the number of connections in the graph.</para>
        /// </summary>
        [GodotMethod("get_transition_count")]
        public int GetTransitionCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_transition_by_index");

        /// <summary>
        /// <para>Deletes the given transition by index.</para>
        /// </summary>
        [GodotMethod("remove_transition_by_index")]
        public void RemoveTransitionByIndex(int idx)
        {
            NativeCalls.godot_icall_1_4(method_bind_15, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_transition");

        /// <summary>
        /// <para>Deletes the transition between the two specified nodes.</para>
        /// </summary>
        [GodotMethod("remove_transition")]
        public void RemoveTransition(string from, string to)
        {
            NativeCalls.godot_icall_2_107(method_bind_16, Object.GetPtr(this), from, to);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_start_node");

        /// <summary>
        /// <para>Sets the given node as the graph start point.</para>
        /// </summary>
        [GodotMethod("set_start_node")]
        public void SetStartNode(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_17, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_start_node");

        /// <summary>
        /// <para>Returns the graph's end node.</para>
        /// </summary>
        [GodotMethod("get_start_node")]
        public string GetStartNode()
        {
            return NativeCalls.godot_icall_0_6(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_end_node");

        /// <summary>
        /// <para>Sets the given node as the graph end point.</para>
        /// </summary>
        [GodotMethod("set_end_node")]
        public void SetEndNode(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_19, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_end_node");

        /// <summary>
        /// <para>Returns the graph's end node.</para>
        /// </summary>
        [GodotMethod("get_end_node")]
        public string GetEndNode()
        {
            return NativeCalls.godot_icall_0_6(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_graph_offset");

        /// <summary>
        /// <para>Sets the draw offset of the graph. Used for display in the editor.</para>
        /// </summary>
        [GodotMethod("set_graph_offset")]
        public void SetGraphOffset(Vector2 offset)
        {
            NativeCalls.godot_icall_1_57(method_bind_21, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_graph_offset");

        /// <summary>
        /// <para>Returns the draw offset of the graph. Used for display in the editor.</para>
        /// </summary>
        [GodotMethod("get_graph_offset")]
        public Vector2 GetGraphOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_22, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
