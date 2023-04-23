using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This class allows you to define a custom shader program that can be used for various materials to render objects.</para>
    /// <para>The visual shader editor creates the shader.</para>
    /// </summary>
    public partial class VisualShader : Shader
    {
        public const int NodeIdInvalid = -1;
        public const int NodeIdOutput = 0;

        public enum Type
        {
            /// <summary>
            /// <para>A vertex shader, operating on vertices.</para>
            /// </summary>
            Vertex = 0,
            /// <summary>
            /// <para>A fragment shader, operating on fragments (pixels).</para>
            /// </summary>
            Fragment = 1,
            /// <summary>
            /// <para>A shader for light calculations.</para>
            /// </summary>
            Light = 2,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.VisualShader.Type"/> enum.</para>
            /// </summary>
            Max = 3
        }

        /// <summary>
        /// <para>The offset vector of the whole graph.</para>
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

        private const string nativeName = "VisualShader";

        public VisualShader() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShader_Ctor(this);
        }

        internal VisualShader(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mode");

        /// <summary>
        /// <para>Sets the mode of this shader.</para>
        /// </summary>
        [GodotMethod("set_mode")]
        public void SetMode(Shader.Mode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_node");

        /// <summary>
        /// <para>Adds the specified node to the shader.</para>
        /// </summary>
        [GodotMethod("add_node")]
        public void AddNode(VisualShader.Type type, VisualShaderNode node, Vector2 position, int id)
        {
            NativeCalls.godot_icall_4_1123(method_bind_1, Object.GetPtr(this), (int)type, Object.GetPtr(node), ref position, id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node");

        /// <summary>
        /// <para>Returns the shader node instance with specified <c>type</c> and <c>id</c>.</para>
        /// </summary>
        [GodotMethod("get_node")]
        public VisualShaderNode GetNode(VisualShader.Type type, int id)
        {
            return NativeCalls.godot_icall_2_1124(method_bind_2, Object.GetPtr(this), (int)type, id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_node_position");

        /// <summary>
        /// <para>Sets the position of the specified node.</para>
        /// </summary>
        [GodotMethod("set_node_position")]
        public void SetNodePosition(VisualShader.Type type, int id, Vector2 position)
        {
            NativeCalls.godot_icall_3_81(method_bind_3, Object.GetPtr(this), (int)type, id, ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_position");

        /// <summary>
        /// <para>Returns the position of the specified node within the shader graph.</para>
        /// </summary>
        [GodotMethod("get_node_position")]
        public Vector2 GetNodePosition(VisualShader.Type type, int id)
        {
            NativeCalls.godot_icall_2_82(method_bind_4, Object.GetPtr(this), (int)type, id, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_list");

        /// <summary>
        /// <para>Returns the list of all nodes in the shader with the specified type.</para>
        /// </summary>
        [GodotMethod("get_node_list")]
        public int[] GetNodeList(VisualShader.Type type)
        {
            return NativeCalls.godot_icall_1_36(method_bind_5, Object.GetPtr(this), (int)type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_valid_node_id");

        [GodotMethod("get_valid_node_id")]
        public int GetValidNodeId(VisualShader.Type type)
        {
            return NativeCalls.godot_icall_1_11(method_bind_6, Object.GetPtr(this), (int)type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_node");

        /// <summary>
        /// <para>Removes the specified node from the shader.</para>
        /// </summary>
        [GodotMethod("remove_node")]
        public void RemoveNode(VisualShader.Type type, int id)
        {
            NativeCalls.godot_icall_2_65(method_bind_7, Object.GetPtr(this), (int)type, id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_node_connection");

        /// <summary>
        /// <para>Returns <c>true</c> if the specified node and port connection exist.</para>
        /// </summary>
        [GodotMethod("is_node_connection")]
        public bool IsNodeConnection(VisualShader.Type type, int fromNode, int fromPort, int toNode, int toPort)
        {
            return NativeCalls.godot_icall_5_1125(method_bind_8, Object.GetPtr(this), (int)type, fromNode, fromPort, toNode, toPort);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "can_connect_nodes");

        /// <summary>
        /// <para>Returns <c>true</c> if the specified nodes and ports can be connected together.</para>
        /// </summary>
        [GodotMethod("can_connect_nodes")]
        public bool CanConnectNodes(VisualShader.Type type, int fromNode, int fromPort, int toNode, int toPort)
        {
            return NativeCalls.godot_icall_5_1125(method_bind_9, Object.GetPtr(this), (int)type, fromNode, fromPort, toNode, toPort);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "connect_nodes");

        /// <summary>
        /// <para>Connects the specified nodes and ports.</para>
        /// </summary>
        [GodotMethod("connect_nodes")]
        public Error ConnectNodes(VisualShader.Type type, int fromNode, int fromPort, int toNode, int toPort)
        {
            return (Error)NativeCalls.godot_icall_5_1126(method_bind_10, Object.GetPtr(this), (int)type, fromNode, fromPort, toNode, toPort);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "disconnect_nodes");

        /// <summary>
        /// <para>Connects the specified nodes and ports.</para>
        /// </summary>
        [GodotMethod("disconnect_nodes")]
        public void DisconnectNodes(VisualShader.Type type, int fromNode, int fromPort, int toNode, int toPort)
        {
            NativeCalls.godot_icall_5_479(method_bind_11, Object.GetPtr(this), (int)type, fromNode, fromPort, toNode, toPort);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "connect_nodes_forced");

        /// <summary>
        /// <para>Connects the specified nodes and ports, even if they can't be connected. Such connection is invalid and will not function properly.</para>
        /// </summary>
        [GodotMethod("connect_nodes_forced")]
        public void ConnectNodesForced(VisualShader.Type type, int fromNode, int fromPort, int toNode, int toPort)
        {
            NativeCalls.godot_icall_5_479(method_bind_12, Object.GetPtr(this), (int)type, fromNode, fromPort, toNode, toPort);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_connections");

        /// <summary>
        /// <para>Returns the list of connected nodes with the specified type.</para>
        /// </summary>
        [GodotMethod("get_node_connections")]
        public Godot.Collections.Array GetNodeConnections(VisualShader.Type type)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_1_483(method_bind_13, Object.GetPtr(this), (int)type));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_graph_offset");

        [GodotMethod("set_graph_offset")]
        [Obsolete("SetGraphOffset is deprecated. Use the GraphOffset property instead.")]
        public void SetGraphOffset(Vector2 offset)
        {
            NativeCalls.godot_icall_1_57(method_bind_14, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_graph_offset");

        [GodotMethod("get_graph_offset")]
        [Obsolete("GetGraphOffset is deprecated. Use the GraphOffset property instead.")]
        public Vector2 GetGraphOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_15, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
