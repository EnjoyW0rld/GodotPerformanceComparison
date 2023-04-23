using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Skeleton provides a hierarchical interface for managing bones, including pose, rest and animation (see <see cref="Godot.Animation"/>). It can also use ragdoll physics.</para>
    /// <para>The overall transform of a bone with respect to the skeleton is determined by the following hierarchical order: rest pose, custom pose and pose.</para>
    /// <para>Note that "global pose" below refers to the overall transform of the bone with respect to skeleton, so it not the actual global/world transform of the bone.</para>
    /// </summary>
    public partial class Skeleton : Spatial
    {
        public const int NotificationUpdateSkeleton = 50;

        private const string nativeName = "Skeleton";

        public Skeleton() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Skeleton_Ctor(this);
        }

        internal Skeleton(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_bone");

        /// <summary>
        /// <para>Adds a bone, with name <c>name</c>. <see cref="Godot.Skeleton.GetBoneCount"/> will become the bone index.</para>
        /// </summary>
        [GodotMethod("add_bone")]
        public void AddBone(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "find_bone");

        /// <summary>
        /// <para>Returns the bone index that matches <c>name</c> as its name.</para>
        /// </summary>
        [GodotMethod("find_bone")]
        public int FindBone(string name)
        {
            return NativeCalls.godot_icall_1_138(method_bind_1, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bone_name");

        /// <summary>
        /// <para>Returns the name of the bone at index <c>index</c>.</para>
        /// </summary>
        [GodotMethod("get_bone_name")]
        public string GetBoneName(int boneIdx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_2, Object.GetPtr(this), boneIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bone_name");

        [GodotMethod("set_bone_name")]
        public void SetBoneName(int boneIdx, string name)
        {
            NativeCalls.godot_icall_2_121(method_bind_3, Object.GetPtr(this), boneIdx, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bone_parent");

        /// <summary>
        /// <para>Returns the bone index which is the parent of the bone at <c>bone_idx</c>. If -1, then bone has no parent.</para>
        /// <para>Note: The parent bone returned will always be less than <c>bone_idx</c>.</para>
        /// </summary>
        [GodotMethod("get_bone_parent")]
        public int GetBoneParent(int boneIdx)
        {
            return NativeCalls.godot_icall_1_11(method_bind_4, Object.GetPtr(this), boneIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bone_parent");

        /// <summary>
        /// <para>Sets the bone index <c>parent_idx</c> as the parent of the bone at <c>bone_idx</c>. If -1, then bone has no parent.</para>
        /// <para>Note: <c>parent_idx</c> must be less than <c>bone_idx</c>.</para>
        /// </summary>
        [GodotMethod("set_bone_parent")]
        public void SetBoneParent(int boneIdx, int parentIdx)
        {
            NativeCalls.godot_icall_2_65(method_bind_5, Object.GetPtr(this), boneIdx, parentIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bone_count");

        /// <summary>
        /// <para>Returns the amount of bones in the skeleton.</para>
        /// </summary>
        [GodotMethod("get_bone_count")]
        public int GetBoneCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "unparent_bone_and_rest");

        [GodotMethod("unparent_bone_and_rest")]
        public void UnparentBoneAndRest(int boneIdx)
        {
            NativeCalls.godot_icall_1_4(method_bind_7, Object.GetPtr(this), boneIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bone_rest");

        /// <summary>
        /// <para>Returns the rest transform for a bone <c>bone_idx</c>.</para>
        /// </summary>
        [GodotMethod("get_bone_rest")]
        public Transform GetBoneRest(int boneIdx)
        {
            NativeCalls.godot_icall_1_609(method_bind_8, Object.GetPtr(this), boneIdx, out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bone_rest");

        /// <summary>
        /// <para>Sets the rest transform for bone <c>bone_idx</c>.</para>
        /// </summary>
        [GodotMethod("set_bone_rest")]
        public void SetBoneRest(int boneIdx, Transform rest)
        {
            NativeCalls.godot_icall_2_606(method_bind_9, Object.GetPtr(this), boneIdx, ref rest);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "register_skin");

        [GodotMethod("register_skin")]
        public SkinReference RegisterSkin(Skin skin)
        {
            return NativeCalls.godot_icall_1_860(method_bind_10, Object.GetPtr(this), Object.GetPtr(skin));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "localize_rests");

        [GodotMethod("localize_rests")]
        public void LocalizeRests()
        {
            NativeCalls.godot_icall_0_3(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bone_disable_rest");

        [GodotMethod("set_bone_disable_rest")]
        public void SetBoneDisableRest(int boneIdx, bool disable)
        {
            NativeCalls.godot_icall_2_23(method_bind_12, Object.GetPtr(this), boneIdx, disable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_bone_rest_disabled");

        [GodotMethod("is_bone_rest_disabled")]
        public bool IsBoneRestDisabled(int boneIdx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_13, Object.GetPtr(this), boneIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "bind_child_node_to_bone");

        /// <summary>
        /// <para>Deprecated soon.</para>
        /// </summary>
        [GodotMethod("bind_child_node_to_bone")]
        public void BindChildNodeToBone(int boneIdx, Node node)
        {
            NativeCalls.godot_icall_2_390(method_bind_14, Object.GetPtr(this), boneIdx, Object.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "unbind_child_node_from_bone");

        /// <summary>
        /// <para>Deprecated soon.</para>
        /// </summary>
        [GodotMethod("unbind_child_node_from_bone")]
        public void UnbindChildNodeFromBone(int boneIdx, Node node)
        {
            NativeCalls.godot_icall_2_390(method_bind_15, Object.GetPtr(this), boneIdx, Object.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bound_child_nodes_to_bone");

        /// <summary>
        /// <para>Deprecated soon.</para>
        /// </summary>
        [GodotMethod("get_bound_child_nodes_to_bone")]
        public Godot.Collections.Array GetBoundChildNodesToBone(int boneIdx)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_1_483(method_bind_16, Object.GetPtr(this), boneIdx));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_bones");

        /// <summary>
        /// <para>Clear all the bones in this skeleton.</para>
        /// </summary>
        [GodotMethod("clear_bones")]
        public void ClearBones()
        {
            NativeCalls.godot_icall_0_3(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bone_pose");

        /// <summary>
        /// <para>Returns the pose transform of the specified bone. Pose is applied on top of the custom pose, which is applied on top the rest pose.</para>
        /// </summary>
        [GodotMethod("get_bone_pose")]
        public Transform GetBonePose(int boneIdx)
        {
            NativeCalls.godot_icall_1_609(method_bind_18, Object.GetPtr(this), boneIdx, out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bone_pose");

        /// <summary>
        /// <para>Sets the pose transform for bone <c>bone_idx</c>.</para>
        /// </summary>
        [GodotMethod("set_bone_pose")]
        public void SetBonePose(int boneIdx, Transform pose)
        {
            NativeCalls.godot_icall_2_606(method_bind_19, Object.GetPtr(this), boneIdx, ref pose);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_bones_global_pose_override");

        [GodotMethod("clear_bones_global_pose_override")]
        public void ClearBonesGlobalPoseOverride()
        {
            NativeCalls.godot_icall_0_3(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bone_global_pose_override");

        [GodotMethod("set_bone_global_pose_override")]
        public void SetBoneGlobalPoseOverride(int boneIdx, Transform pose, float amount, bool persistent = false)
        {
            NativeCalls.godot_icall_4_861(method_bind_21, Object.GetPtr(this), boneIdx, ref pose, amount, persistent);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bone_global_pose");

        /// <summary>
        /// <para>Returns the overall transform of the specified bone, with respect to the skeleton. Being relative to the skeleton frame, this is not the actual "global" transform of the bone.</para>
        /// </summary>
        [GodotMethod("get_bone_global_pose")]
        public Transform GetBoneGlobalPose(int boneIdx)
        {
            NativeCalls.godot_icall_1_609(method_bind_22, Object.GetPtr(this), boneIdx, out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bone_global_pose_no_override");

        /// <summary>
        /// <para>Returns the overall transform of the specified bone, with respect to the skeleton, but without any global pose overrides. Being relative to the skeleton frame, this is not the actual "global" transform of the bone.</para>
        /// </summary>
        [GodotMethod("get_bone_global_pose_no_override")]
        public Transform GetBoneGlobalPoseNoOverride(int boneIdx)
        {
            NativeCalls.godot_icall_1_609(method_bind_23, Object.GetPtr(this), boneIdx, out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bone_custom_pose");

        /// <summary>
        /// <para>Returns the custom pose of the specified bone. Custom pose is applied on top of the rest pose.</para>
        /// </summary>
        [GodotMethod("get_bone_custom_pose")]
        public Transform GetBoneCustomPose(int boneIdx)
        {
            NativeCalls.godot_icall_1_609(method_bind_24, Object.GetPtr(this), boneIdx, out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bone_custom_pose");

        [GodotMethod("set_bone_custom_pose")]
        public void SetBoneCustomPose(int boneIdx, Transform customPose)
        {
            NativeCalls.godot_icall_2_606(method_bind_25, Object.GetPtr(this), boneIdx, ref customPose);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "physical_bones_stop_simulation");

        [GodotMethod("physical_bones_stop_simulation")]
        public void PhysicalBonesStopSimulation()
        {
            NativeCalls.godot_icall_0_3(method_bind_26, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "physical_bones_start_simulation");

        /// <param name="bones">If the parameter is null, then the default value is new Godot.Collections.Array { }</param>
        [GodotMethod("physical_bones_start_simulation")]
        public void PhysicalBonesStartSimulation(Godot.Collections.Array bones = null)
        {
            Godot.Collections.Array bones_in = bones != null ? bones : new Godot.Collections.Array { };
            NativeCalls.godot_icall_1_92(method_bind_27, Object.GetPtr(this), bones_in.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "physical_bones_add_collision_exception");

        [GodotMethod("physical_bones_add_collision_exception")]
        public void PhysicalBonesAddCollisionException(RID exception)
        {
            NativeCalls.godot_icall_1_285(method_bind_28, Object.GetPtr(this), RID.GetPtr(exception));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "physical_bones_remove_collision_exception");

        [GodotMethod("physical_bones_remove_collision_exception")]
        public void PhysicalBonesRemoveCollisionException(RID exception)
        {
            NativeCalls.godot_icall_1_285(method_bind_29, Object.GetPtr(this), RID.GetPtr(exception));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
