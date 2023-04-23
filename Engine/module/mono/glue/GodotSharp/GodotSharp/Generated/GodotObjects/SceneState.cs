using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Maintains a list of resources, nodes, exported, and overridden properties, and built-in scripts associated with a scene.</para>
    /// <para>This class cannot be instantiated directly, it is retrieved for a given scene as the result of <see cref="Godot.PackedScene.GetState"/>.</para>
    /// </summary>
    public abstract partial class SceneState : Reference
    {
        public enum GenEditState
        {
            /// <summary>
            /// <para>If passed to <see cref="Godot.PackedScene.Instance"/>, blocks edits to the scene state.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>If passed to <see cref="Godot.PackedScene.Instance"/>, provides inherited scene resources to the local scene.</para>
            /// <para>Note: Only available in editor builds.</para>
            /// </summary>
            Instance = 1,
            /// <summary>
            /// <para>If passed to <see cref="Godot.PackedScene.Instance"/>, provides local scene resources to the local scene. Only the main scene should receive the main edit state.</para>
            /// <para>Note: Only available in editor builds.</para>
            /// </summary>
            Main = 2,
            /// <summary>
            /// <para>If passed to <see cref="Godot.PackedScene.Instance"/>, it's similar to <see cref="Godot.SceneState.GenEditState.Main"/>, but for the case where the scene is being instantiated to be the base of another one.</para>
            /// <para>Note: Only available in editor builds.</para>
            /// </summary>
            MainInherited = 3
        }

        private const string nativeName = "SceneState";

        internal SceneState() {}

        internal SceneState(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_count");

        /// <summary>
        /// <para>Returns the number of nodes in the scene.</para>
        /// <para>The <c>idx</c> argument used to query node data in other <c>get_node_*</c> methods in the interval <c>[0, get_node_count() - 1]</c>.</para>
        /// </summary>
        [GodotMethod("get_node_count")]
        public int GetNodeCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_type");

        /// <summary>
        /// <para>Returns the type of the node at <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_node_type")]
        public string GetNodeType(int idx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_1, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_name");

        /// <summary>
        /// <para>Returns the name of the node at <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_node_name")]
        public string GetNodeName(int idx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_2, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_path");

        /// <summary>
        /// <para>Returns the path to the node at <c>idx</c>.</para>
        /// <para>If <c>for_parent</c> is <c>true</c>, returns the path of the <c>idx</c> node's parent instead.</para>
        /// </summary>
        [GodotMethod("get_node_path")]
        public NodePath GetNodePath(int idx, bool forParent = false)
        {
            return new NodePath(NativeCalls.godot_icall_2_830(method_bind_3, Object.GetPtr(this), idx, forParent));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_owner_path");

        /// <summary>
        /// <para>Returns the path to the owner of the node at <c>idx</c>, relative to the root node.</para>
        /// </summary>
        [GodotMethod("get_node_owner_path")]
        public NodePath GetNodeOwnerPath(int idx)
        {
            return new NodePath(NativeCalls.godot_icall_1_62(method_bind_4, Object.GetPtr(this), idx));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_node_instance_placeholder");

        /// <summary>
        /// <para>Returns <c>true</c> if the node at <c>idx</c> is an <see cref="Godot.InstancePlaceholder"/>.</para>
        /// </summary>
        [GodotMethod("is_node_instance_placeholder")]
        public bool IsNodeInstancePlaceholder(int idx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_5, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_instance_placeholder");

        /// <summary>
        /// <para>Returns the path to the represented scene file if the node at <c>idx</c> is an <see cref="Godot.InstancePlaceholder"/>.</para>
        /// </summary>
        [GodotMethod("get_node_instance_placeholder")]
        public string GetNodeInstancePlaceholder(int idx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_6, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_instance");

        /// <summary>
        /// <para>Returns a <see cref="Godot.PackedScene"/> for the node at <c>idx</c> (i.e. the whole branch starting at this node, with its child nodes and resources), or <c>null</c> if the node is not an instance.</para>
        /// </summary>
        [GodotMethod("get_node_instance")]
        public PackedScene GetNodeInstance(int idx)
        {
            return NativeCalls.godot_icall_1_831(method_bind_7, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_groups");

        /// <summary>
        /// <para>Returns the list of group names associated with the node at <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_node_groups")]
        public string[] GetNodeGroups(int idx)
        {
            return NativeCalls.godot_icall_1_832(method_bind_8, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_index");

        /// <summary>
        /// <para>Returns the node's index, which is its position relative to its siblings. This is only relevant and saved in scenes for cases where new nodes are added to an instanced or inherited scene among siblings from the base scene. Despite the name, this index is not related to the <c>idx</c> argument used here and in other methods.</para>
        /// </summary>
        [GodotMethod("get_node_index")]
        public int GetNodeIndex(int idx)
        {
            return NativeCalls.godot_icall_1_11(method_bind_9, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_property_count");

        /// <summary>
        /// <para>Returns the number of exported or overridden properties for the node at <c>idx</c>.</para>
        /// <para>The <c>prop_idx</c> argument used to query node property data in other <c>get_node_property_*</c> methods in the interval <c>[0, get_node_property_count() - 1]</c>.</para>
        /// </summary>
        [GodotMethod("get_node_property_count")]
        public int GetNodePropertyCount(int idx)
        {
            return NativeCalls.godot_icall_1_11(method_bind_10, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_property_name");

        /// <summary>
        /// <para>Returns the name of the property at <c>prop_idx</c> for the node at <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_node_property_name")]
        public string GetNodePropertyName(int idx, int propIdx)
        {
            return NativeCalls.godot_icall_2_78(method_bind_11, Object.GetPtr(this), idx, propIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_property_value");

        /// <summary>
        /// <para>Returns the value of the property at <c>prop_idx</c> for the node at <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_node_property_value")]
        public object GetNodePropertyValue(int idx, int propIdx)
        {
            return NativeCalls.godot_icall_2_71(method_bind_12, Object.GetPtr(this), idx, propIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connection_count");

        /// <summary>
        /// <para>Returns the number of signal connections in the scene.</para>
        /// <para>The <c>idx</c> argument used to query connection metadata in other <c>get_connection_*</c> methods in the interval <c>[0, get_connection_count() - 1]</c>.</para>
        /// </summary>
        [GodotMethod("get_connection_count")]
        public int GetConnectionCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connection_source");

        /// <summary>
        /// <para>Returns the path to the node that owns the signal at <c>idx</c>, relative to the root node.</para>
        /// </summary>
        [GodotMethod("get_connection_source")]
        public NodePath GetConnectionSource(int idx)
        {
            return new NodePath(NativeCalls.godot_icall_1_62(method_bind_14, Object.GetPtr(this), idx));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connection_signal");

        /// <summary>
        /// <para>Returns the name of the signal at <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_connection_signal")]
        public string GetConnectionSignal(int idx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_15, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connection_target");

        /// <summary>
        /// <para>Returns the path to the node that owns the method connected to the signal at <c>idx</c>, relative to the root node.</para>
        /// </summary>
        [GodotMethod("get_connection_target")]
        public NodePath GetConnectionTarget(int idx)
        {
            return new NodePath(NativeCalls.godot_icall_1_62(method_bind_16, Object.GetPtr(this), idx));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connection_method");

        /// <summary>
        /// <para>Returns the method connected to the signal at <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_connection_method")]
        public string GetConnectionMethod(int idx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_17, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connection_flags");

        /// <summary>
        /// <para>Returns the connection flags for the signal at <c>idx</c>. See <see cref="Godot.Object.ConnectFlags"/> constants.</para>
        /// </summary>
        [GodotMethod("get_connection_flags")]
        public int GetConnectionFlags(int idx)
        {
            return NativeCalls.godot_icall_1_11(method_bind_18, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connection_binds");

        /// <summary>
        /// <para>Returns the list of bound parameters for the signal at <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_connection_binds")]
        public Godot.Collections.Array GetConnectionBinds(int idx)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_1_483(method_bind_19, Object.GetPtr(this), idx));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
