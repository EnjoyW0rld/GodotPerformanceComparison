using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Base node for all joint constraints in 2D physics. Joints take 2 bodies and apply a custom constraint.</para>
    /// </summary>
    public abstract partial class Joint2D : Node2D
    {
        /// <summary>
        /// <para>The first body attached to the joint. Must derive from <see cref="Godot.PhysicsBody2D"/>.</para>
        /// </summary>
        public NodePath NodeA
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
        /// <para>The second body attached to the joint. Must derive from <see cref="Godot.PhysicsBody2D"/>.</para>
        /// </summary>
        public NodePath NodeB
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
        /// <para>When <see cref="Godot.Joint2D.NodeA"/> and <see cref="Godot.Joint2D.NodeB"/> move in different directions the <c>bias</c> controls how fast the joint pulls them back to their original position. The lower the <c>bias</c> the more the two bodies can pull on the joint.</para>
        /// </summary>
        public float Bias
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBias();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBias(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, <see cref="Godot.Joint2D.NodeA"/> and <see cref="Godot.Joint2D.NodeB"/> can not collide.</para>
        /// </summary>
        public bool DisableCollision
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

        private const string nativeName = "Joint2D";

        internal Joint2D() {}

        internal Joint2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_node_a");

        [GodotMethod("set_node_a")]
        [Obsolete("SetNodeA is deprecated. Use the NodeA property instead.")]
        public void SetNodeA(NodePath node)
        {
            NativeCalls.godot_icall_1_129(method_bind_0, Object.GetPtr(this), NodePath.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_a");

        [GodotMethod("get_node_a")]
        [Obsolete("GetNodeA is deprecated. Use the NodeA property instead.")]
        public NodePath GetNodeA()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_1, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_node_b");

        [GodotMethod("set_node_b")]
        [Obsolete("SetNodeB is deprecated. Use the NodeB property instead.")]
        public void SetNodeB(NodePath node)
        {
            NativeCalls.godot_icall_1_129(method_bind_2, Object.GetPtr(this), NodePath.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_b");

        [GodotMethod("get_node_b")]
        [Obsolete("GetNodeB is deprecated. Use the NodeB property instead.")]
        public NodePath GetNodeB()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_3, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bias");

        [GodotMethod("set_bias")]
        [Obsolete("SetBias is deprecated. Use the Bias property instead.")]
        public void SetBias(float bias)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), bias);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bias");

        [GodotMethod("get_bias")]
        [Obsolete("GetBias is deprecated. Use the Bias property instead.")]
        public float GetBias()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_exclude_nodes_from_collision");

        [GodotMethod("set_exclude_nodes_from_collision")]
        [Obsolete("SetExcludeNodesFromCollision is deprecated. Use the DisableCollision property instead.")]
        public void SetExcludeNodesFromCollision(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_exclude_nodes_from_collision");

        [GodotMethod("get_exclude_nodes_from_collision")]
        [Obsolete("GetExcludeNodesFromCollision is deprecated. Use the DisableCollision property instead.")]
        public bool GetExcludeNodesFromCollision()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
