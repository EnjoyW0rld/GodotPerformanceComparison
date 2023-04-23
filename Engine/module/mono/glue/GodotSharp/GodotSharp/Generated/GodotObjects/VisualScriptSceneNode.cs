using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A direct reference to a node.</para>
    /// <para>Input Ports:</para>
    /// <para>none</para>
    /// <para>Output Ports:</para>
    /// <para>- Data: <c>node</c> (obj)</para>
    /// </summary>
    public partial class VisualScriptSceneNode : VisualScriptNode
    {
        /// <summary>
        /// <para>The node's path in the scene tree.</para>
        /// </summary>
        public NodePath NodePath
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNodePath();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetNodePath(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptSceneNode";

        public VisualScriptSceneNode() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptSceneNode_Ctor(this);
        }

        internal VisualScriptSceneNode(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_node_path");

        [GodotMethod("set_node_path")]
        [Obsolete("SetNodePath is deprecated. Use the NodePath property instead.")]
        public void SetNodePath(NodePath path)
        {
            NativeCalls.godot_icall_1_129(method_bind_0, Object.GetPtr(this), NodePath.GetPtr(path));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_path");

        [GodotMethod("get_node_path")]
        [Obsolete("GetNodePath is deprecated. Use the NodePath property instead.")]
        public NodePath GetNodePath()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_1, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
