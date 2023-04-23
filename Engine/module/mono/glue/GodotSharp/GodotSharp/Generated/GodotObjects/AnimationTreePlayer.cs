using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Deprecated. A node graph tool for blending multiple animations bound to an <see cref="Godot.AnimationPlayer"/>. Especially useful for animating characters or other skeleton-based rigs. It can combine several animations to form a desired pose.</para>
    /// <para>It takes <see cref="Godot.Animation"/>s from an <see cref="Godot.AnimationPlayer"/> node and mixes them depending on the graph.</para>
    /// <para>See <see cref="Godot.AnimationTree"/> for a more full-featured replacement of this node.</para>
    /// </summary>
    public partial class AnimationTreePlayer : Node
    {
        public enum AnimationProcessMode
        {
            /// <summary>
            /// <para>Process animation during the physics process. This is especially useful when animating physics bodies.</para>
            /// </summary>
            Physics = 0,
            /// <summary>
            /// <para>Process animation during the idle process.</para>
            /// </summary>
            Idle = 1
        }

        public enum NodeType
        {
            /// <summary>
            /// <para>Output node.</para>
            /// </summary>
            Output = 0,
            /// <summary>
            /// <para>Animation node.</para>
            /// </summary>
            Animation = 1,
            /// <summary>
            /// <para>OneShot node.</para>
            /// </summary>
            Oneshot = 2,
            /// <summary>
            /// <para>Mix node.</para>
            /// </summary>
            Mix = 3,
            /// <summary>
            /// <para>Blend2 node.</para>
            /// </summary>
            Blend2 = 4,
            /// <summary>
            /// <para>Blend3 node.</para>
            /// </summary>
            Blend3 = 5,
            /// <summary>
            /// <para>Blend4 node.</para>
            /// </summary>
            Blend4 = 6,
            /// <summary>
            /// <para>TimeScale node.</para>
            /// </summary>
            Timescale = 7,
            /// <summary>
            /// <para>TimeSeek node.</para>
            /// </summary>
            Timeseek = 8,
            /// <summary>
            /// <para>Transition node.</para>
            /// </summary>
            Transition = 9
        }

        /// <summary>
        /// <para>The thread in which to update animations.</para>
        /// </summary>
        public AnimationTreePlayer.AnimationProcessMode PlaybackProcessMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAnimationProcessMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAnimationProcessMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The path to the <see cref="Godot.AnimationPlayer"/> from which this <see cref="Godot.AnimationTreePlayer"/> binds animations to animation nodes.</para>
        /// <para>Once set, <see cref="Godot.Animation"/> nodes can be added to the <see cref="Godot.AnimationTreePlayer"/>.</para>
        /// </summary>
        public NodePath MasterPlayer
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMasterPlayer();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMasterPlayer(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The node from which to relatively access other nodes.</para>
        /// <para>It accesses the bones, so it should point to the same node the <see cref="Godot.AnimationPlayer"/> would point its Root Node at.</para>
        /// </summary>
        public NodePath BasePath
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBasePath();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBasePath(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the <see cref="Godot.AnimationTreePlayer"/> is able to play animations.</para>
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

        private const string nativeName = "AnimationTreePlayer";

        public AnimationTreePlayer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AnimationTreePlayer_Ctor(this);
        }

        internal AnimationTreePlayer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_node");

        /// <summary>
        /// <para>Adds a <c>type</c> node to the graph with name <c>id</c>.</para>
        /// </summary>
        [GodotMethod("add_node")]
        public void AddNode(AnimationTreePlayer.NodeType type, string id)
        {
            NativeCalls.godot_icall_2_121(method_bind_0, Object.GetPtr(this), (int)type, id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "node_exists");

        /// <summary>
        /// <para>Check if a node exists (by name).</para>
        /// </summary>
        [GodotMethod("node_exists")]
        public bool NodeExists(string node)
        {
            return NativeCalls.godot_icall_1_108(method_bind_1, Object.GetPtr(this), node);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "node_rename");

        /// <summary>
        /// <para>Renames a node in the graph.</para>
        /// </summary>
        [GodotMethod("node_rename")]
        public Error NodeRename(string node, string newName)
        {
            return (Error)NativeCalls.godot_icall_2_136(method_bind_2, Object.GetPtr(this), node, newName);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "node_get_type");

        /// <summary>
        /// <para>Gets the node type, will return from <see cref="Godot.AnimationTreePlayer.NodeType"/> enum.</para>
        /// </summary>
        [GodotMethod("node_get_type")]
        public AnimationTreePlayer.NodeType NodeGetType(string id)
        {
            return (AnimationTreePlayer.NodeType)NativeCalls.godot_icall_1_137(method_bind_3, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "node_get_input_count");

        /// <summary>
        /// <para>Returns the input count for a given node. Different types of nodes have different amount of inputs.</para>
        /// </summary>
        [GodotMethod("node_get_input_count")]
        public int NodeGetInputCount(string id)
        {
            return NativeCalls.godot_icall_1_138(method_bind_4, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "node_get_input_source");

        /// <summary>
        /// <para>Returns the input source for a given node input.</para>
        /// </summary>
        [GodotMethod("node_get_input_source")]
        public string NodeGetInputSource(string id, int idx)
        {
            return NativeCalls.godot_icall_2_139(method_bind_5, Object.GetPtr(this), id, idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "animation_node_set_animation");

        /// <summary>
        /// <para>Binds a new <see cref="Godot.Animation"/> from the <see cref="Godot.AnimationTreePlayer.MasterPlayer"/> to the <see cref="Godot.AnimationTreePlayer"/>'s animation node with name <c>id</c>.</para>
        /// </summary>
        [GodotMethod("animation_node_set_animation")]
        public void AnimationNodeSetAnimation(string id, Animation animation)
        {
            NativeCalls.godot_icall_2_114(method_bind_6, Object.GetPtr(this), id, Object.GetPtr(animation));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "animation_node_get_animation");

        /// <summary>
        /// <para>Returns the <see cref="Godot.AnimationPlayer"/>'s <see cref="Godot.Animation"/> bound to the <see cref="Godot.AnimationTreePlayer"/>'s animation node with name <c>id</c>.</para>
        /// </summary>
        [GodotMethod("animation_node_get_animation")]
        public Animation AnimationNodeGetAnimation(string id)
        {
            return NativeCalls.godot_icall_1_123(method_bind_7, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "animation_node_set_master_animation");

        /// <summary>
        /// <para>Binds the <see cref="Godot.Animation"/> named <c>source</c> from <see cref="Godot.AnimationTreePlayer.MasterPlayer"/> to the animation node <c>id</c>. Recalculates caches.</para>
        /// </summary>
        [GodotMethod("animation_node_set_master_animation")]
        public void AnimationNodeSetMasterAnimation(string id, string source)
        {
            NativeCalls.godot_icall_2_107(method_bind_8, Object.GetPtr(this), id, source);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "animation_node_get_master_animation");

        /// <summary>
        /// <para>Returns the name of the <see cref="Godot.AnimationTreePlayer.MasterPlayer"/>'s <see cref="Godot.Animation"/> bound to this animation node.</para>
        /// </summary>
        [GodotMethod("animation_node_get_master_animation")]
        public string AnimationNodeGetMasterAnimation(string id)
        {
            return NativeCalls.godot_icall_1_124(method_bind_9, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "animation_node_get_position");

        /// <summary>
        /// <para>Returns the absolute playback timestamp of the animation node with name <c>id</c>.</para>
        /// </summary>
        [GodotMethod("animation_node_get_position")]
        public float AnimationNodeGetPosition(string id)
        {
            return NativeCalls.godot_icall_1_140(method_bind_10, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "animation_node_set_filter_path");

        /// <summary>
        /// <para>If <c>enable</c> is <c>true</c>, the animation node with ID <c>id</c> turns off the track modifying the property at <c>path</c>. The modified node's children continue to animate.</para>
        /// </summary>
        [GodotMethod("animation_node_set_filter_path")]
        public void AnimationNodeSetFilterPath(string id, NodePath path, bool enable)
        {
            NativeCalls.godot_icall_3_141(method_bind_11, Object.GetPtr(this), id, NodePath.GetPtr(path), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "oneshot_node_set_fadein_time");

        /// <summary>
        /// <para>Sets the fade in time of a OneShot node given its name and value in seconds.</para>
        /// </summary>
        [GodotMethod("oneshot_node_set_fadein_time")]
        public void OneshotNodeSetFadeinTime(string id, float timeSec)
        {
            NativeCalls.godot_icall_2_128(method_bind_12, Object.GetPtr(this), id, timeSec);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "oneshot_node_get_fadein_time");

        /// <summary>
        /// <para>Returns the fade in time of a OneShot node given its name.</para>
        /// </summary>
        [GodotMethod("oneshot_node_get_fadein_time")]
        public float OneshotNodeGetFadeinTime(string id)
        {
            return NativeCalls.godot_icall_1_140(method_bind_13, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "oneshot_node_set_fadeout_time");

        /// <summary>
        /// <para>Sets the fade out time of a OneShot node given its name and value in seconds.</para>
        /// </summary>
        [GodotMethod("oneshot_node_set_fadeout_time")]
        public void OneshotNodeSetFadeoutTime(string id, float timeSec)
        {
            NativeCalls.godot_icall_2_128(method_bind_14, Object.GetPtr(this), id, timeSec);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "oneshot_node_get_fadeout_time");

        /// <summary>
        /// <para>Returns the fade out time of a OneShot node given its name.</para>
        /// </summary>
        [GodotMethod("oneshot_node_get_fadeout_time")]
        public float OneshotNodeGetFadeoutTime(string id)
        {
            return NativeCalls.godot_icall_1_140(method_bind_15, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "oneshot_node_set_autorestart");

        /// <summary>
        /// <para>Sets the autorestart property of a OneShot node given its name and value.</para>
        /// </summary>
        [GodotMethod("oneshot_node_set_autorestart")]
        public void OneshotNodeSetAutorestart(string id, bool enable)
        {
            NativeCalls.godot_icall_2_56(method_bind_16, Object.GetPtr(this), id, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "oneshot_node_set_autorestart_delay");

        /// <summary>
        /// <para>Sets the autorestart delay of a OneShot node given its name and value in seconds.</para>
        /// </summary>
        [GodotMethod("oneshot_node_set_autorestart_delay")]
        public void OneshotNodeSetAutorestartDelay(string id, float delaySec)
        {
            NativeCalls.godot_icall_2_128(method_bind_17, Object.GetPtr(this), id, delaySec);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "oneshot_node_set_autorestart_random_delay");

        /// <summary>
        /// <para>Sets the autorestart random delay of a OneShot node given its name and value in seconds.</para>
        /// </summary>
        [GodotMethod("oneshot_node_set_autorestart_random_delay")]
        public void OneshotNodeSetAutorestartRandomDelay(string id, float randSec)
        {
            NativeCalls.godot_icall_2_128(method_bind_18, Object.GetPtr(this), id, randSec);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "oneshot_node_has_autorestart");

        /// <summary>
        /// <para>Returns whether a OneShot node will auto restart given its name.</para>
        /// </summary>
        [GodotMethod("oneshot_node_has_autorestart")]
        public bool OneshotNodeHasAutorestart(string id)
        {
            return NativeCalls.godot_icall_1_108(method_bind_19, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "oneshot_node_get_autorestart_delay");

        /// <summary>
        /// <para>Returns the autostart delay of a OneShot node given its name.</para>
        /// </summary>
        [GodotMethod("oneshot_node_get_autorestart_delay")]
        public float OneshotNodeGetAutorestartDelay(string id)
        {
            return NativeCalls.godot_icall_1_140(method_bind_20, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "oneshot_node_get_autorestart_random_delay");

        /// <summary>
        /// <para>Returns the autostart random delay of a OneShot node given its name.</para>
        /// </summary>
        [GodotMethod("oneshot_node_get_autorestart_random_delay")]
        public float OneshotNodeGetAutorestartRandomDelay(string id)
        {
            return NativeCalls.godot_icall_1_140(method_bind_21, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "oneshot_node_start");

        /// <summary>
        /// <para>Starts a OneShot node given its name.</para>
        /// </summary>
        [GodotMethod("oneshot_node_start")]
        public void OneshotNodeStart(string id)
        {
            NativeCalls.godot_icall_1_54(method_bind_22, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "oneshot_node_stop");

        /// <summary>
        /// <para>Stops the OneShot node with name <c>id</c>.</para>
        /// </summary>
        [GodotMethod("oneshot_node_stop")]
        public void OneshotNodeStop(string id)
        {
            NativeCalls.godot_icall_1_54(method_bind_23, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "oneshot_node_is_active");

        /// <summary>
        /// <para>Returns whether a OneShot node is active given its name.</para>
        /// </summary>
        [GodotMethod("oneshot_node_is_active")]
        public bool OneshotNodeIsActive(string id)
        {
            return NativeCalls.godot_icall_1_108(method_bind_24, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "oneshot_node_set_filter_path");

        /// <summary>
        /// <para>If <c>enable</c> is <c>true</c>, the OneShot node with ID <c>id</c> turns off the track modifying the property at <c>path</c>. The modified node's children continue to animate.</para>
        /// </summary>
        [GodotMethod("oneshot_node_set_filter_path")]
        public void OneshotNodeSetFilterPath(string id, NodePath path, bool enable)
        {
            NativeCalls.godot_icall_3_141(method_bind_25, Object.GetPtr(this), id, NodePath.GetPtr(path), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mix_node_set_amount");

        /// <summary>
        /// <para>Sets the mix amount of a Mix node given its name and value.</para>
        /// <para>A Mix node adds input b to input a by the amount given by ratio.</para>
        /// </summary>
        [GodotMethod("mix_node_set_amount")]
        public void MixNodeSetAmount(string id, float ratio)
        {
            NativeCalls.godot_icall_2_128(method_bind_26, Object.GetPtr(this), id, ratio);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "mix_node_get_amount");

        /// <summary>
        /// <para>Returns the mix amount of a Mix node given its name.</para>
        /// </summary>
        [GodotMethod("mix_node_get_amount")]
        public float MixNodeGetAmount(string id)
        {
            return NativeCalls.godot_icall_1_140(method_bind_27, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "blend2_node_set_amount");

        /// <summary>
        /// <para>Sets the blend amount of a Blend2 node given its name and value.</para>
        /// <para>A Blend2 node blends two animations (A and B) with the amount between 0 and 1.</para>
        /// <para>At 0, output is input A. Towards 1, the influence of A gets lessened, the influence of B gets raised. At 1, output is input B.</para>
        /// </summary>
        [GodotMethod("blend2_node_set_amount")]
        public void Blend2NodeSetAmount(string id, float blend)
        {
            NativeCalls.godot_icall_2_128(method_bind_28, Object.GetPtr(this), id, blend);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "blend2_node_get_amount");

        /// <summary>
        /// <para>Returns the blend amount of a Blend2 node given its name.</para>
        /// </summary>
        [GodotMethod("blend2_node_get_amount")]
        public float Blend2NodeGetAmount(string id)
        {
            return NativeCalls.godot_icall_1_140(method_bind_29, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "blend2_node_set_filter_path");

        /// <summary>
        /// <para>If <c>enable</c> is <c>true</c>, the Blend2 node with name <c>id</c> turns off the track modifying the property at <c>path</c>. The modified node's children continue to animate.</para>
        /// </summary>
        [GodotMethod("blend2_node_set_filter_path")]
        public void Blend2NodeSetFilterPath(string id, NodePath path, bool enable)
        {
            NativeCalls.godot_icall_3_141(method_bind_30, Object.GetPtr(this), id, NodePath.GetPtr(path), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "blend3_node_set_amount");

        /// <summary>
        /// <para>Sets the blend amount of a Blend3 node given its name and value.</para>
        /// <para>A Blend3 Node blends three animations (A, B-, B+) with the amount between -1 and 1.</para>
        /// <para>At -1, output is input B-. From -1 to 0, the influence of B- gets lessened, the influence of A gets raised and the influence of B+ is 0. At 0, output is input A. From 0 to 1, the influence of A gets lessened, the influence of B+ gets raised and the influence of B+ is 0. At 1, output is input B+.</para>
        /// </summary>
        [GodotMethod("blend3_node_set_amount")]
        public void Blend3NodeSetAmount(string id, float blend)
        {
            NativeCalls.godot_icall_2_128(method_bind_31, Object.GetPtr(this), id, blend);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "blend3_node_get_amount");

        /// <summary>
        /// <para>Returns the blend amount of a Blend3 node given its name.</para>
        /// </summary>
        [GodotMethod("blend3_node_get_amount")]
        public float Blend3NodeGetAmount(string id)
        {
            return NativeCalls.godot_icall_1_140(method_bind_32, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "blend4_node_set_amount");

        /// <summary>
        /// <para>Sets the blend amount of a Blend4 node given its name and value.</para>
        /// <para>A Blend4 Node blends two pairs of animations.</para>
        /// <para>The two pairs are blended like Blend2 and then added together.</para>
        /// </summary>
        [GodotMethod("blend4_node_set_amount")]
        public void Blend4NodeSetAmount(string id, Vector2 blend)
        {
            NativeCalls.godot_icall_2_111(method_bind_33, Object.GetPtr(this), id, ref blend);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "blend4_node_get_amount");

        /// <summary>
        /// <para>Returns the blend amount of a Blend4 node given its name.</para>
        /// </summary>
        [GodotMethod("blend4_node_get_amount")]
        public Vector2 Blend4NodeGetAmount(string id)
        {
            NativeCalls.godot_icall_1_112(method_bind_34, Object.GetPtr(this), id, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "timescale_node_set_scale");

        /// <summary>
        /// <para>Sets the time scale of the TimeScale node with name <c>id</c> to <c>scale</c>.</para>
        /// <para>The TimeScale node is used to speed <see cref="Godot.Animation"/>s up if the scale is above 1 or slow them down if it is below 1.</para>
        /// <para>If applied after a blend or mix, affects all input animations to that blend or mix.</para>
        /// </summary>
        [GodotMethod("timescale_node_set_scale")]
        public void TimescaleNodeSetScale(string id, float scale)
        {
            NativeCalls.godot_icall_2_128(method_bind_35, Object.GetPtr(this), id, scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "timescale_node_get_scale");

        /// <summary>
        /// <para>Returns the time scale value of the TimeScale node with name <c>id</c>.</para>
        /// </summary>
        [GodotMethod("timescale_node_get_scale")]
        public float TimescaleNodeGetScale(string id)
        {
            return NativeCalls.godot_icall_1_140(method_bind_36, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "timeseek_node_seek");

        /// <summary>
        /// <para>Sets the time seek value of the TimeSeek node with name <c>id</c> to <c>seconds</c>.</para>
        /// <para>This functions as a seek in the <see cref="Godot.Animation"/> or the blend or mix of <see cref="Godot.Animation"/>s input in it.</para>
        /// </summary>
        [GodotMethod("timeseek_node_seek")]
        public void TimeseekNodeSeek(string id, float seconds)
        {
            NativeCalls.godot_icall_2_128(method_bind_37, Object.GetPtr(this), id, seconds);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "transition_node_set_input_count");

        /// <summary>
        /// <para>Resizes the number of inputs available for the transition node with name <c>id</c>.</para>
        /// </summary>
        [GodotMethod("transition_node_set_input_count")]
        public void TransitionNodeSetInputCount(string id, int count)
        {
            NativeCalls.godot_icall_2_110(method_bind_38, Object.GetPtr(this), id, count);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "transition_node_get_input_count");

        /// <summary>
        /// <para>Returns the number of inputs for the transition node with name <c>id</c>. You can add inputs by right-clicking on the transition node.</para>
        /// </summary>
        [GodotMethod("transition_node_get_input_count")]
        public int TransitionNodeGetInputCount(string id)
        {
            return NativeCalls.godot_icall_1_138(method_bind_39, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "transition_node_delete_input");

        /// <summary>
        /// <para>Deletes the input at <c>input_idx</c> for the transition node with name <c>id</c>.</para>
        /// </summary>
        [GodotMethod("transition_node_delete_input")]
        public void TransitionNodeDeleteInput(string id, int inputIdx)
        {
            NativeCalls.godot_icall_2_110(method_bind_40, Object.GetPtr(this), id, inputIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "transition_node_set_input_auto_advance");

        /// <summary>
        /// <para>The transition node with name <c>id</c> advances to its next input automatically when the input at <c>input_idx</c> completes.</para>
        /// </summary>
        [GodotMethod("transition_node_set_input_auto_advance")]
        public void TransitionNodeSetInputAutoAdvance(string id, int inputIdx, bool enable)
        {
            NativeCalls.godot_icall_3_142(method_bind_41, Object.GetPtr(this), id, inputIdx, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "transition_node_has_input_auto_advance");

        /// <summary>
        /// <para>Returns <c>true</c> if the input at <c>input_idx</c> on the transition node with name <c>id</c> is set to automatically advance to the next input upon completion.</para>
        /// </summary>
        [GodotMethod("transition_node_has_input_auto_advance")]
        public bool TransitionNodeHasInputAutoAdvance(string id, int inputIdx)
        {
            return NativeCalls.godot_icall_2_143(method_bind_42, Object.GetPtr(this), id, inputIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "transition_node_set_xfade_time");

        /// <summary>
        /// <para>The transition node with name <c>id</c> sets its cross fade time to <c>time_sec</c>.</para>
        /// </summary>
        [GodotMethod("transition_node_set_xfade_time")]
        public void TransitionNodeSetXfadeTime(string id, float timeSec)
        {
            NativeCalls.godot_icall_2_128(method_bind_43, Object.GetPtr(this), id, timeSec);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "transition_node_get_xfade_time");

        /// <summary>
        /// <para>Returns the cross fade time for the transition node with name <c>id</c>.</para>
        /// </summary>
        [GodotMethod("transition_node_get_xfade_time")]
        public float TransitionNodeGetXfadeTime(string id)
        {
            return NativeCalls.godot_icall_1_140(method_bind_44, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "transition_node_set_current");

        /// <summary>
        /// <para>The transition node with name <c>id</c> sets its current input at <c>input_idx</c>.</para>
        /// </summary>
        [GodotMethod("transition_node_set_current")]
        public void TransitionNodeSetCurrent(string id, int inputIdx)
        {
            NativeCalls.godot_icall_2_110(method_bind_45, Object.GetPtr(this), id, inputIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "transition_node_get_current");

        /// <summary>
        /// <para>Returns the index of the currently evaluated input for the transition node with name <c>id</c>.</para>
        /// </summary>
        [GodotMethod("transition_node_get_current")]
        public int TransitionNodeGetCurrent(string id)
        {
            return NativeCalls.godot_icall_1_138(method_bind_46, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "node_set_position");

        /// <summary>
        /// <para>Sets the position of a node in the graph given its name and position.</para>
        /// </summary>
        [GodotMethod("node_set_position")]
        public void NodeSetPosition(string id, Vector2 screenPosition)
        {
            NativeCalls.godot_icall_2_111(method_bind_47, Object.GetPtr(this), id, ref screenPosition);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "node_get_position");

        /// <summary>
        /// <para>Returns position of a node in the graph given its name.</para>
        /// </summary>
        [GodotMethod("node_get_position")]
        public Vector2 NodeGetPosition(string id)
        {
            NativeCalls.godot_icall_1_112(method_bind_48, Object.GetPtr(this), id, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_node");

        /// <summary>
        /// <para>Removes the animation node with name <c>id</c>.</para>
        /// </summary>
        [GodotMethod("remove_node")]
        public void RemoveNode(string id)
        {
            NativeCalls.godot_icall_1_54(method_bind_49, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "connect_nodes");

        /// <summary>
        /// <para>Connects node <c>id</c> to <c>dst_id</c> at the specified input slot.</para>
        /// </summary>
        [GodotMethod("connect_nodes")]
        public Error ConnectNodes(string id, string dstId, int dstInputIdx)
        {
            return (Error)NativeCalls.godot_icall_3_144(method_bind_50, Object.GetPtr(this), id, dstId, dstInputIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "are_nodes_connected");

        /// <summary>
        /// <para>Returns whether node <c>id</c> and <c>dst_id</c> are connected at the specified slot.</para>
        /// </summary>
        [GodotMethod("are_nodes_connected")]
        public bool AreNodesConnected(string id, string dstId, int dstInputIdx)
        {
            return NativeCalls.godot_icall_3_145(method_bind_51, Object.GetPtr(this), id, dstId, dstInputIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "disconnect_nodes");

        /// <summary>
        /// <para>Disconnects nodes connected to <c>id</c> at the specified input slot.</para>
        /// </summary>
        [GodotMethod("disconnect_nodes")]
        public void DisconnectNodes(string id, int dstInputIdx)
        {
            NativeCalls.godot_icall_2_110(method_bind_52, Object.GetPtr(this), id, dstInputIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_53 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_active");

        [GodotMethod("set_active")]
        [Obsolete("SetActive is deprecated. Use the Active property instead.")]
        public void SetActive(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_53, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_54 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_active");

        [GodotMethod("is_active")]
        [Obsolete("IsActive is deprecated. Use the Active property instead.")]
        public bool IsActive()
        {
            return NativeCalls.godot_icall_0_7(method_bind_54, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_55 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_base_path");

        [GodotMethod("set_base_path")]
        [Obsolete("SetBasePath is deprecated. Use the BasePath property instead.")]
        public void SetBasePath(NodePath path)
        {
            NativeCalls.godot_icall_1_129(method_bind_55, Object.GetPtr(this), NodePath.GetPtr(path));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_56 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_base_path");

        [GodotMethod("get_base_path")]
        [Obsolete("GetBasePath is deprecated. Use the BasePath property instead.")]
        public NodePath GetBasePath()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_56, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_57 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_master_player");

        [GodotMethod("set_master_player")]
        [Obsolete("SetMasterPlayer is deprecated. Use the MasterPlayer property instead.")]
        public void SetMasterPlayer(NodePath nodepath)
        {
            NativeCalls.godot_icall_1_129(method_bind_57, Object.GetPtr(this), NodePath.GetPtr(nodepath));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_58 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_master_player");

        [GodotMethod("get_master_player")]
        [Obsolete("GetMasterPlayer is deprecated. Use the MasterPlayer property instead.")]
        public NodePath GetMasterPlayer()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_58, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_59 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_list");

        /// <summary>
        /// <para>Returns a <see cref="string"/> containing the name of all nodes.</para>
        /// </summary>
        [GodotMethod("get_node_list")]
        public string[] GetNodeList()
        {
            return NativeCalls.godot_icall_0_119(method_bind_59, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_60 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_animation_process_mode");

        [GodotMethod("set_animation_process_mode")]
        [Obsolete("SetAnimationProcessMode is deprecated. Use the PlaybackProcessMode property instead.")]
        public void SetAnimationProcessMode(AnimationTreePlayer.AnimationProcessMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_60, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_61 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_animation_process_mode");

        [GodotMethod("get_animation_process_mode")]
        [Obsolete("GetAnimationProcessMode is deprecated. Use the PlaybackProcessMode property instead.")]
        public AnimationTreePlayer.AnimationProcessMode GetAnimationProcessMode()
        {
            return (AnimationTreePlayer.AnimationProcessMode)NativeCalls.godot_icall_0_146(method_bind_61, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_62 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "advance");

        /// <summary>
        /// <para>Shifts position in the animation timeline. <c>delta</c> is the time in seconds to shift. Events between the current frame and <c>delta</c> are handled.</para>
        /// </summary>
        [GodotMethod("advance")]
        public void Advance(float delta)
        {
            NativeCalls.godot_icall_1_15(method_bind_62, Object.GetPtr(this), delta);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_63 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reset");

        /// <summary>
        /// <para>Resets this <see cref="Godot.AnimationTreePlayer"/>.</para>
        /// </summary>
        [GodotMethod("reset")]
        public void Reset()
        {
            NativeCalls.godot_icall_0_3(method_bind_63, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_64 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "recompute_caches");

        /// <summary>
        /// <para>Manually recalculates the cache of track information generated from animation nodes. Needed when external sources modify the animation nodes' state.</para>
        /// </summary>
        [GodotMethod("recompute_caches")]
        public void RecomputeCaches()
        {
            NativeCalls.godot_icall_0_3(method_bind_64, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
