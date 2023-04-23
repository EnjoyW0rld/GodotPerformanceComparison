using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This node may contain a sub-tree of any other blend type nodes, such as <see cref="Godot.AnimationNodeTransition"/>, <see cref="Godot.AnimationNodeBlend2"/>, <see cref="Godot.AnimationNodeBlend3"/>, <see cref="Godot.AnimationNodeOneShot"/>, etc. This is one of the most commonly used roots.</para>
    /// <para>An <see cref="Godot.AnimationNodeOutput"/> node named <c>output</c> is created by default.</para>
    /// </summary>
    public partial class AnimationNodeBlendTree : AnimationRootNode
    {
        /// <summary>
        /// <para>The connection was successful.</para>
        /// </summary>
        public const int ConnectionOk = 0;
        /// <summary>
        /// <para>The input node is <c>null</c>.</para>
        /// </summary>
        public const int ConnectionErrorNoInput = 1;
        /// <summary>
        /// <para>The specified input port is out of range.</para>
        /// </summary>
        public const int ConnectionErrorNoInputIndex = 2;
        /// <summary>
        /// <para>The output node is <c>null</c>.</para>
        /// </summary>
        public const int ConnectionErrorNoOutput = 3;
        /// <summary>
        /// <para>Input and output nodes are the same.</para>
        /// </summary>
        public const int ConnectionErrorSameNode = 4;
        /// <summary>
        /// <para>The specified connection already exists.</para>
        /// </summary>
        public const int ConnectionErrorConnectionExists = 5;

        /// <summary>
        /// <para>The global offset of all sub-nodes.</para>
        /// </summary>
        public Vector2 GraphOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGraphOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGraphOffset(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AnimationNodeBlendTree";

        public AnimationNodeBlendTree() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AnimationNodeBlendTree_Ctor(this);
        }

        internal AnimationNodeBlendTree(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_node");

        /// <summary>
        /// <para>Adds an <see cref="Godot.AnimationNode"/> at the given <c>position</c>. The <c>name</c> is used to identify the created sub-node later.</para>
        /// </summary>
        /// <param name="position">If the parameter is null, then the default value is new Vector2(0, 0)</param>
        [GodotMethod("add_node")]
        public void AddNode(string name, AnimationNode node, Nullable<Vector2> position = null)
        {
            Vector2 position_in = position.HasValue ? position.Value : new Vector2(0, 0);
            NativeCalls.godot_icall_3_105(method_bind_0, Object.GetPtr(this), name, Object.GetPtr(node), ref position_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node");

        /// <summary>
        /// <para>Returns the sub-node with the specified <c>name</c>.</para>
        /// </summary>
        [GodotMethod("get_node")]
        public AnimationNode GetNode(string name)
        {
            return NativeCalls.godot_icall_1_106(method_bind_1, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_node");

        /// <summary>
        /// <para>Removes a sub-node.</para>
        /// </summary>
        [GodotMethod("remove_node")]
        public void RemoveNode(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_2, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rename_node");

        /// <summary>
        /// <para>Changes the name of a sub-node.</para>
        /// </summary>
        [GodotMethod("rename_node")]
        public void RenameNode(string name, string newName)
        {
            NativeCalls.godot_icall_2_107(method_bind_3, Object.GetPtr(this), name, newName);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_node");

        /// <summary>
        /// <para>Returns <c>true</c> if a sub-node with specified <c>name</c> exists.</para>
        /// </summary>
        [GodotMethod("has_node")]
        public bool HasNode(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_4, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "connect_node");

        /// <summary>
        /// <para>Connects the output of an <see cref="Godot.AnimationNode"/> as input for another <see cref="Godot.AnimationNode"/>, at the input port specified by <c>input_index</c>.</para>
        /// </summary>
        [GodotMethod("connect_node")]
        public void ConnectNode(string inputNode, int inputIndex, string outputNode)
        {
            NativeCalls.godot_icall_3_109(method_bind_5, Object.GetPtr(this), inputNode, inputIndex, outputNode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "disconnect_node");

        /// <summary>
        /// <para>Disconnects the node connected to the specified input.</para>
        /// </summary>
        [GodotMethod("disconnect_node")]
        public void DisconnectNode(string inputNode, int inputIndex)
        {
            NativeCalls.godot_icall_2_110(method_bind_6, Object.GetPtr(this), inputNode, inputIndex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_node_position");

        /// <summary>
        /// <para>Modifies the position of a sub-node.</para>
        /// </summary>
        [GodotMethod("set_node_position")]
        public void SetNodePosition(string name, Vector2 position)
        {
            NativeCalls.godot_icall_2_111(method_bind_7, Object.GetPtr(this), name, ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_position");

        /// <summary>
        /// <para>Returns the position of the sub-node with the specified <c>name</c>.</para>
        /// </summary>
        [GodotMethod("get_node_position")]
        public Vector2 GetNodePosition(string name)
        {
            NativeCalls.godot_icall_1_112(method_bind_8, Object.GetPtr(this), name, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_graph_offset");

        [GodotMethod("set_graph_offset")]
        [Obsolete("SetGraphOffset is deprecated. Use the GraphOffset property instead.")]
        public void SetGraphOffset(Vector2 offset)
        {
            NativeCalls.godot_icall_1_57(method_bind_9, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_graph_offset");

        [GodotMethod("get_graph_offset")]
        [Obsolete("GetGraphOffset is deprecated. Use the GraphOffset property instead.")]
        public Vector2 GetGraphOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_10, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
