using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A node to be used for advanced animation transitions in an <see cref="Godot.AnimationPlayer"/>.</para>
    /// <para>Note: When linked with an <see cref="Godot.AnimationPlayer"/>, several properties and methods of the corresponding <see cref="Godot.AnimationPlayer"/> will not function as expected. Playback and transitions should be handled using only the <see cref="Godot.AnimationTree"/> and its constituent <see cref="Godot.AnimationNode"/>(s). The <see cref="Godot.AnimationPlayer"/> node should be used solely for adding, deleting, and editing animations.</para>
    /// </summary>
    public partial class AnimationTree : Node
    {
        public enum AnimationProcessMode
        {
            /// <summary>
            /// <para>The animations will progress during the physics frame (i.e. <see cref="Godot.Node._PhysicsProcess"/>).</para>
            /// </summary>
            Physics = 0,
            /// <summary>
            /// <para>The animations will progress during the idle frame (i.e. <see cref="Godot.Node._Process"/>).</para>
            /// </summary>
            Idle = 1,
            /// <summary>
            /// <para>The animations will only progress manually (see <see cref="Godot.AnimationTree.Advance"/>).</para>
            /// </summary>
            Manual = 2
        }

        /// <summary>
        /// <para>The root animation node of this <see cref="Godot.AnimationTree"/>. See <see cref="Godot.AnimationNode"/>.</para>
        /// </summary>
        public AnimationNode TreeRoot
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTreeRoot();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTreeRoot(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The path to the <see cref="Godot.AnimationPlayer"/> used for animating.</para>
        /// </summary>
        public NodePath AnimPlayer
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAnimationPlayer();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAnimationPlayer(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the <see cref="Godot.AnimationTree"/> will be processing.</para>
        /// </summary>
        public bool Active
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsActive();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetActive(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The process mode of this <see cref="Godot.AnimationTree"/>. See <see cref="Godot.AnimationTree.AnimationProcessMode"/> for available modes.</para>
        /// </summary>
        public AnimationTree.AnimationProcessMode ProcessMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetProcessMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetProcessMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The path to the Animation track used for root motion. Paths must be valid scene-tree paths to a node, and must be specified starting from the parent node of the node that will reproduce the animation. To specify a track that controls properties or bones, append its name after the path, separated by <c>":"</c>. For example, <c>"character/skeleton:ankle"</c> or <c>"character/mesh:transform/local"</c>.</para>
        /// <para>If the track has type <see cref="Godot.Animation.TrackType.Transform"/>, the transformation will be cancelled visually, and the animation will appear to stay in place. See also <see cref="Godot.AnimationTree.GetRootMotionTransform"/> and <c>RootMotionView</c>.</para>
        /// </summary>
        public NodePath RootMotionTrack
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRootMotionTrack();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRootMotionTrack(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AnimationTree";

        public AnimationTree() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AnimationTree_Ctor(this);
        }

        internal AnimationTree(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_active");

        [GodotMethod("set_active")]
        [Obsolete("SetActive is deprecated. Use the Active property instead.")]
        public void SetActive(bool active)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), active);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_active");

        [GodotMethod("is_active")]
        [Obsolete("IsActive is deprecated. Use the Active property instead.")]
        public bool IsActive()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tree_root");

        [GodotMethod("set_tree_root")]
        [Obsolete("SetTreeRoot is deprecated. Use the TreeRoot property instead.")]
        public void SetTreeRoot(AnimationNode root)
        {
            NativeCalls.godot_icall_1_24(method_bind_2, Object.GetPtr(this), Object.GetPtr(root));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tree_root");

        [GodotMethod("get_tree_root")]
        [Obsolete("GetTreeRoot is deprecated. Use the TreeRoot property instead.")]
        public AnimationNode GetTreeRoot()
        {
            return NativeCalls.godot_icall_0_134(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_process_mode");

        [GodotMethod("set_process_mode")]
        [Obsolete("SetProcessMode is deprecated. Use the ProcessMode property instead.")]
        public void SetProcessMode(AnimationTree.AnimationProcessMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_process_mode");

        [GodotMethod("get_process_mode")]
        [Obsolete("GetProcessMode is deprecated. Use the ProcessMode property instead.")]
        public AnimationTree.AnimationProcessMode GetProcessMode()
        {
            return (AnimationTree.AnimationProcessMode)NativeCalls.godot_icall_0_135(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_animation_player");

        [GodotMethod("set_animation_player")]
        [Obsolete("SetAnimationPlayer is deprecated. Use the AnimPlayer property instead.")]
        public void SetAnimationPlayer(NodePath root)
        {
            NativeCalls.godot_icall_1_129(method_bind_6, Object.GetPtr(this), NodePath.GetPtr(root));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_animation_player");

        [GodotMethod("get_animation_player")]
        [Obsolete("GetAnimationPlayer is deprecated. Use the AnimPlayer property instead.")]
        public NodePath GetAnimationPlayer()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_7, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_root_motion_track");

        [GodotMethod("set_root_motion_track")]
        [Obsolete("SetRootMotionTrack is deprecated. Use the RootMotionTrack property instead.")]
        public void SetRootMotionTrack(NodePath path)
        {
            NativeCalls.godot_icall_1_129(method_bind_8, Object.GetPtr(this), NodePath.GetPtr(path));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_root_motion_track");

        [GodotMethod("get_root_motion_track")]
        [Obsolete("GetRootMotionTrack is deprecated. Use the RootMotionTrack property instead.")]
        public NodePath GetRootMotionTrack()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_9, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_root_motion_transform");

        /// <summary>
        /// <para>Retrieve the motion of the <see cref="Godot.AnimationTree.RootMotionTrack"/> as a <see cref="Godot.Transform"/> that can be used elsewhere. If <see cref="Godot.AnimationTree.RootMotionTrack"/> is not a path to a track of type <see cref="Godot.Animation.TrackType.Transform"/>, returns an identity transformation. See also <see cref="Godot.AnimationTree.RootMotionTrack"/> and <c>RootMotionView</c>.</para>
        /// </summary>
        [GodotMethod("get_root_motion_transform")]
        public Transform GetRootMotionTransform()
        {
            NativeCalls.godot_icall_0_22(method_bind_10, Object.GetPtr(this), out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rename_parameter");

        [GodotMethod("rename_parameter")]
        public void RenameParameter(string oldName, string newName)
        {
            NativeCalls.godot_icall_2_107(method_bind_11, Object.GetPtr(this), oldName, newName);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "advance");

        /// <summary>
        /// <para>Manually advance the animations by the specified time (in seconds).</para>
        /// </summary>
        [GodotMethod("advance")]
        public void Advance(float delta)
        {
            NativeCalls.godot_icall_1_15(method_bind_12, Object.GetPtr(this), delta);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
