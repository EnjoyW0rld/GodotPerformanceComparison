using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A simplified interface to a scene file. Provides access to operations and checks that can be performed on the scene resource itself.</para>
    /// <para>Can be used to save a node to a file. When saving, the node as well as all the nodes it owns get saved (see <c>owner</c> property on <see cref="Godot.Node"/>).</para>
    /// <para>Note: The node doesn't need to own itself.</para>
    /// <para>Example of loading a saved scene:</para>
    /// <para><code>
    /// # Use `load()` instead of `preload()` if the path isn't known at compile-time.
    /// var scene = preload("res://scene.tscn").instance()
    /// # Add the node as a child of the node the script is attached to.
    /// add_child(scene)
    /// </code></para>
    /// <para>Example of saving a node with different owners: The following example creates 3 objects: <c>Node2D</c> (<c>node</c>), <c>RigidBody2D</c> (<c>rigid</c>) and <c>CollisionObject2D</c> (<c>collision</c>). <c>collision</c> is a child of <c>rigid</c> which is a child of <c>node</c>. Only <c>rigid</c> is owned by <c>node</c> and <c>pack</c> will therefore only save those two nodes, but not <c>collision</c>.</para>
    /// <para><code>
    /// # Create the objects.
    /// var node = Node2D.new()
    /// var rigid = RigidBody2D.new()
    /// var collision = CollisionShape2D.new()
    /// 
    /// # Create the object hierarchy.
    /// rigid.add_child(collision)
    /// node.add_child(rigid)
    /// 
    /// # Change owner of `rigid`, but not of `collision`.
    /// rigid.owner = node
    /// 
    /// var scene = PackedScene.new()
    /// # Only `node` and `rigid` are now packed.
    /// var result = scene.pack(node)
    /// if result == OK:
    ///     var error = ResourceSaver.save("res://path/name.scn", scene)  # Or "user://..."
    ///     if error != OK:
    ///         push_error("An error occurred while saving the scene to disk.")
    /// </code></para>
    /// </summary>
    public partial class PackedScene : Resource
    {
        public enum GenEditState
        {
            /// <summary>
            /// <para>If passed to <see cref="Godot.PackedScene.Instance"/>, blocks edits to the scene state.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>If passed to <see cref="Godot.PackedScene.Instance"/>, provides local scene resources to the local scene.</para>
            /// <para>Note: Only available in editor builds.</para>
            /// </summary>
            Instance = 1,
            /// <summary>
            /// <para>If passed to <see cref="Godot.PackedScene.Instance"/>, provides local scene resources to the local scene. Only the main scene should receive the main edit state.</para>
            /// <para>Note: Only available in editor builds.</para>
            /// </summary>
            Main = 2,
            /// <summary>
            /// <para>It's similar to <see cref="Godot.PackedScene.GenEditState.Main"/>, but for the case where the scene is being instantiated to be the base of another one.</para>
            /// <para>Note: Only available in editor builds.</para>
            /// </summary>
            MainInherited = 3
        }

        /// <summary>
        /// <para>A dictionary representation of the scene contents.</para>
        /// <para>Available keys include "rnames" and "variants" for resources, "node_count", "nodes", "node_paths" for nodes, "editable_instances" for base scene children overrides, "conn_count" and "conns" for signal connections, and "version" for the format style of the PackedScene.</para>
        /// </summary>
        public Godot.Collections.Dictionary _Bundled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetBundledScene();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetBundledScene(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "PackedScene";

        public PackedScene() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PackedScene_Ctor(this);
        }

        internal PackedScene(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "pack");

        /// <summary>
        /// <para>Pack will ignore any sub-nodes not owned by given node. See <see cref="Godot.Node.Owner"/>.</para>
        /// </summary>
        [GodotMethod("pack")]
        public Error Pack(Node path)
        {
            return (Error)NativeCalls.godot_icall_1_711(method_bind_0, Object.GetPtr(this), Object.GetPtr(path));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance");

        /// <summary>
        /// <para>Instantiates the scene's node hierarchy. Triggers child scene instantiation(s). Triggers a <see cref="Godot.Node.NotificationInstanced"/> notification on the root node.</para>
        /// </summary>
        [GodotMethod("instance")]
        public Node Instance(PackedScene.GenEditState editState = (PackedScene.GenEditState)0)
        {
            return NativeCalls.godot_icall_1_460(method_bind_1, Object.GetPtr(this), (int)editState);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "can_instance");

        /// <summary>
        /// <para>Returns <c>true</c> if the scene file has nodes.</para>
        /// </summary>
        [GodotMethod("can_instance")]
        public bool CanInstance()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_bundled_scene");

        [Obsolete("_SetBundledScene is deprecated. Use the _Bundled property instead.")]
        internal void _SetBundledScene(Godot.Collections.Dictionary arg0)
        {
            NativeCalls.godot_icall_1_213(method_bind_3, Object.GetPtr(this), arg0.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_bundled_scene");

        [Obsolete("_GetBundledScene is deprecated. Use the _Bundled property instead.")]
        internal Godot.Collections.Dictionary _GetBundledScene()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_4, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_state");

        /// <summary>
        /// <para>Returns the <c>SceneState</c> representing the scene file contents.</para>
        /// </summary>
        [GodotMethod("get_state")]
        public SceneState GetState()
        {
            return NativeCalls.godot_icall_0_712(method_bind_5, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
