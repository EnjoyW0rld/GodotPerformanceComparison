using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Joints are used to bind together two physics bodies. They have a solver priority and can define if the bodies of the two attached nodes should be able to collide with each other.</para>
    /// </summary>
    public abstract partial class Joint : Spatial
    {
        /// <summary>
        /// <para>The node attached to the first side (A) of the joint.</para>
        /// </summary>
        public NodePath Nodes__nodeA
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNodeA();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetNodeA(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The node attached to the second side (B) of the joint.</para>
        /// </summary>
        public NodePath Nodes__nodeB
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNodeB();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetNodeB(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The priority used to define which solver is executed first for multiple joints. The lower the value, the higher the priority.</para>
        /// </summary>
        public int Solver__priority
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSolverPriority();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSolverPriority(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the two bodies of the nodes are not able to collide with each other.</para>
        /// </summary>
        public bool Collision__excludeNodes
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetExcludeNodesFromCollision();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExcludeNodesFromCollision(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Joint";

        internal Joint() {}

        internal Joint(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_node_a");

        [GodotMethod("set_node_a")]
        [Obsolete("SetNodeA is deprecated. Use the Nodes__nodeA property instead.")]
        public void SetNodeA(NodePath node)
        {
            NativeCalls.godot_icall_1_129(method_bind_0, Object.GetPtr(this), NodePath.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_a");

        [GodotMethod("get_node_a")]
        [Obsolete("GetNodeA is deprecated. Use the Nodes__nodeA property instead.")]
        public NodePath GetNodeA()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_1, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_node_b");

        [GodotMethod("set_node_b")]
        [Obsolete("SetNodeB is deprecated. Use the Nodes__nodeB property instead.")]
        public void SetNodeB(NodePath node)
        {
            NativeCalls.godot_icall_1_129(method_bind_2, Object.GetPtr(this), NodePath.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_b");

        [GodotMethod("get_node_b")]
        [Obsolete("GetNodeB is deprecated. Use the Nodes__nodeB property instead.")]
        public NodePath GetNodeB()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_3, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_solver_priority");

        [GodotMethod("set_solver_priority")]
        [Obsolete("SetSolverPriority is deprecated. Use the Solver__priority property instead.")]
        public void SetSolverPriority(int priority)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), priority);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_solver_priority");

        [GodotMethod("get_solver_priority")]
        [Obsolete("GetSolverPriority is deprecated. Use the Solver__priority property instead.")]
        public int GetSolverPriority()
        {
            return NativeCalls.godot_icall_0_5(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_exclude_nodes_from_collision");

        [GodotMethod("set_exclude_nodes_from_collision")]
        [Obsolete("SetExcludeNodesFromCollision is deprecated. Use the Collision__excludeNodes property instead.")]
        public void SetExcludeNodesFromCollision(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_exclude_nodes_from_collision");

        [GodotMethod("get_exclude_nodes_from_collision")]
        [Obsolete("GetExcludeNodesFromCollision is deprecated. Use the Collision__excludeNodes property instead.")]
        public bool GetExcludeNodesFromCollision()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
