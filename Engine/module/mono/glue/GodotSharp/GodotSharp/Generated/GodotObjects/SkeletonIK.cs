using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>SkeletonIK is used to place the end bone of a <see cref="Godot.Skeleton"/> bone chain at a certain point in 3D by rotating all bones in the chain accordingly. A typical scenario for IK in games is to place a characters feet on the ground or a characters hands on a currently hold object. SkeletonIK uses FabrikInverseKinematic internally to solve the bone chain and applies the results to the <see cref="Godot.Skeleton"/> <c>bones_global_pose_override</c> property for all affected bones in the chain. If fully applied this overwrites any bone transform from <see cref="Godot.Animation"/>s or bone custom poses set by users. The applied amount can be controlled with the <c>interpolation</c> property.</para>
    /// <para><code>
    /// # Apply IK effect automatically on every new frame (not the current)
    /// skeleton_ik_node.start()
    /// 
    /// # Apply IK effect only on the current frame
    /// skeleton_ik_node.start(true)
    /// 
    /// # Stop IK effect and reset bones_global_pose_override on Skeleton
    /// skeleton_ik_node.stop()
    /// 
    /// # Apply full IK effect
    /// skeleton_ik_node.set_interpolation(1.0)
    /// 
    /// # Apply half IK effect
    /// skeleton_ik_node.set_interpolation(0.5)
    /// 
    /// # Apply zero IK effect (a value at or below 0.01 also removes bones_global_pose_override on Skeleton)
    /// skeleton_ik_node.set_interpolation(0.0)
    /// </code></para>
    /// </summary>
    public partial class SkeletonIK : Node
    {
        /// <summary>
        /// <para>The name of the current root bone, the first bone in the IK chain.</para>
        /// </summary>
        public string RootBone
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRootBone();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRootBone(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The name of the current tip bone, the last bone in the IK chain placed at the <see cref="Godot.SkeletonIK.Target"/> transform (or <see cref="Godot.SkeletonIK.TargetNode"/> if defined).</para>
        /// </summary>
        public string TipBone
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTipBone();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTipBone(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Interpolation value for how much the IK results are applied to the current skeleton bone chain. A value of <c>1.0</c> will overwrite all skeleton bone transforms completely while a value of <c>0.0</c> will visually disable the SkeletonIK. A value at or below <c>0.01</c> also calls <see cref="Godot.Skeleton.ClearBonesGlobalPoseOverride"/>.</para>
        /// </summary>
        public float Interpolation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInterpolation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInterpolation(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>First target of the IK chain where the tip bone is placed and, if <see cref="Godot.SkeletonIK.OverrideTipBasis"/> is <c>true</c>, how the tip bone is rotated. If a <see cref="Godot.SkeletonIK.TargetNode"/> path is available the nodes transform is used instead and this property is ignored.</para>
        /// </summary>
        public Transform Target
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTargetTransform();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTargetTransform(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c> overwrites the rotation of the tip bone with the rotation of the <see cref="Godot.SkeletonIK.Target"/> (or <see cref="Godot.SkeletonIK.TargetNode"/> if defined).</para>
        /// </summary>
        public bool OverrideTipBasis
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsOverrideTipBasis();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOverrideTipBasis(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, instructs the IK solver to consider the secondary magnet target (pole target) when calculating the bone chain. Use the magnet position (pole target) to control the bending of the IK chain.</para>
        /// </summary>
        public bool UseMagnet
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUsingMagnet();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseMagnet(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Secondary target position (first is <see cref="Godot.SkeletonIK.Target"/> property or <see cref="Godot.SkeletonIK.TargetNode"/>) for the IK chain. Use magnet position (pole target) to control the bending of the IK chain. Only works if the bone chain has more than 2 bones. The middle chain bone position will be linearly interpolated with the magnet position.</para>
        /// </summary>
        public Vector3 Magnet
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMagnetPosition();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMagnetPosition(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Target node <see cref="Godot.NodePath"/> for the IK chain. If available, the node's current <see cref="Godot.Transform"/> is used instead of the <see cref="Godot.SkeletonIK.Target"/> property.</para>
        /// </summary>
        public NodePath TargetNode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTargetNode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTargetNode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The minimum distance between bone and goal target. If the distance is below this value, the IK solver stops further iterations.</para>
        /// </summary>
        public float MinDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMinDistance();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMinDistance(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Number of iteration loops used by the IK solver to produce more accurate (and elegant) bone chain results.</para>
        /// </summary>
        public int MaxIterations
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaxIterations();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaxIterations(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "SkeletonIK";

        public SkeletonIK() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_SkeletonIK_Ctor(this);
        }

        internal SkeletonIK(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_root_bone");

        [GodotMethod("set_root_bone")]
        [Obsolete("SetRootBone is deprecated. Use the RootBone property instead.")]
        public void SetRootBone(string rootBone)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), rootBone);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_root_bone");

        [GodotMethod("get_root_bone")]
        [Obsolete("GetRootBone is deprecated. Use the RootBone property instead.")]
        public string GetRootBone()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tip_bone");

        [GodotMethod("set_tip_bone")]
        [Obsolete("SetTipBone is deprecated. Use the TipBone property instead.")]
        public void SetTipBone(string tipBone)
        {
            NativeCalls.godot_icall_1_54(method_bind_2, Object.GetPtr(this), tipBone);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tip_bone");

        [GodotMethod("get_tip_bone")]
        [Obsolete("GetTipBone is deprecated. Use the TipBone property instead.")]
        public string GetTipBone()
        {
            return NativeCalls.godot_icall_0_6(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_interpolation");

        [GodotMethod("set_interpolation")]
        [Obsolete("SetInterpolation is deprecated. Use the Interpolation property instead.")]
        public void SetInterpolation(float interpolation)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), interpolation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_interpolation");

        [GodotMethod("get_interpolation")]
        [Obsolete("GetInterpolation is deprecated. Use the Interpolation property instead.")]
        public float GetInterpolation()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_target_transform");

        [GodotMethod("set_target_transform")]
        [Obsolete("SetTargetTransform is deprecated. Use the Target property instead.")]
        public void SetTargetTransform(Transform target)
        {
            NativeCalls.godot_icall_1_202(method_bind_6, Object.GetPtr(this), ref target);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_target_transform");

        [GodotMethod("get_target_transform")]
        [Obsolete("GetTargetTransform is deprecated. Use the Target property instead.")]
        public Transform GetTargetTransform()
        {
            NativeCalls.godot_icall_0_22(method_bind_7, Object.GetPtr(this), out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_target_node");

        [GodotMethod("set_target_node")]
        [Obsolete("SetTargetNode is deprecated. Use the TargetNode property instead.")]
        public void SetTargetNode(NodePath node)
        {
            NativeCalls.godot_icall_1_129(method_bind_8, Object.GetPtr(this), NodePath.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_target_node");

        [GodotMethod("get_target_node")]
        [Obsolete("GetTargetNode is deprecated. Use the TargetNode property instead.")]
        public NodePath GetTargetNode()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_9, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_override_tip_basis");

        [GodotMethod("set_override_tip_basis")]
        [Obsolete("SetOverrideTipBasis is deprecated. Use the OverrideTipBasis property instead.")]
        public void SetOverrideTipBasis(bool @override)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), @override);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_override_tip_basis");

        [GodotMethod("is_override_tip_basis")]
        [Obsolete("IsOverrideTipBasis is deprecated. Use the OverrideTipBasis property instead.")]
        public bool IsOverrideTipBasis()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_magnet");

        [GodotMethod("set_use_magnet")]
        [Obsolete("SetUseMagnet is deprecated. Use the UseMagnet property instead.")]
        public void SetUseMagnet(bool use)
        {
            NativeCalls.godot_icall_1_16(method_bind_12, Object.GetPtr(this), use);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_using_magnet");

        [GodotMethod("is_using_magnet")]
        [Obsolete("IsUsingMagnet is deprecated. Use the UseMagnet property instead.")]
        public bool IsUsingMagnet()
        {
            return NativeCalls.godot_icall_0_7(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_magnet_position");

        [GodotMethod("set_magnet_position")]
        [Obsolete("SetMagnetPosition is deprecated. Use the Magnet property instead.")]
        public void SetMagnetPosition(Vector3 localPosition)
        {
            NativeCalls.godot_icall_1_148(method_bind_14, Object.GetPtr(this), ref localPosition);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_magnet_position");

        [GodotMethod("get_magnet_position")]
        [Obsolete("GetMagnetPosition is deprecated. Use the Magnet property instead.")]
        public Vector3 GetMagnetPosition()
        {
            NativeCalls.godot_icall_0_8(method_bind_15, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_parent_skeleton");

        /// <summary>
        /// <para>Returns the parent <see cref="Godot.Skeleton"/> Node that was present when SkeletonIK entered the <see cref="Godot.SceneTree"/>. Returns null if the parent node was not a <see cref="Godot.Skeleton"/> Node when SkeletonIK entered the <see cref="Godot.SceneTree"/>.</para>
        /// </summary>
        [GodotMethod("get_parent_skeleton")]
        public Skeleton GetParentSkeleton()
        {
            return NativeCalls.godot_icall_0_456(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_running");

        /// <summary>
        /// <para>Returns <c>true</c> if SkeletonIK is applying IK effects on continues frames to the <see cref="Godot.Skeleton"/> bones. Returns <c>false</c> if SkeletonIK is stopped or <see cref="Godot.SkeletonIK.Start"/> was used with the <c>one_time</c> parameter set to <c>true</c>.</para>
        /// </summary>
        [GodotMethod("is_running")]
        public bool IsRunning()
        {
            return NativeCalls.godot_icall_0_7(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_min_distance");

        [GodotMethod("set_min_distance")]
        [Obsolete("SetMinDistance is deprecated. Use the MinDistance property instead.")]
        public void SetMinDistance(float minDistance)
        {
            NativeCalls.godot_icall_1_15(method_bind_18, Object.GetPtr(this), minDistance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_min_distance");

        [GodotMethod("get_min_distance")]
        [Obsolete("GetMinDistance is deprecated. Use the MinDistance property instead.")]
        public float GetMinDistance()
        {
            return NativeCalls.godot_icall_0_14(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max_iterations");

        [GodotMethod("set_max_iterations")]
        [Obsolete("SetMaxIterations is deprecated. Use the MaxIterations property instead.")]
        public void SetMaxIterations(int iterations)
        {
            NativeCalls.godot_icall_1_4(method_bind_20, Object.GetPtr(this), iterations);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max_iterations");

        [GodotMethod("get_max_iterations")]
        [Obsolete("GetMaxIterations is deprecated. Use the MaxIterations property instead.")]
        public int GetMaxIterations()
        {
            return NativeCalls.godot_icall_0_5(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "start");

        /// <summary>
        /// <para>Starts applying IK effects on each frame to the <see cref="Godot.Skeleton"/> bones but will only take effect starting on the next frame. If <c>one_time</c> is <c>true</c>, this will take effect immediately but also reset on the next frame.</para>
        /// </summary>
        [GodotMethod("start")]
        public void Start(bool oneTime = false)
        {
            NativeCalls.godot_icall_1_16(method_bind_22, Object.GetPtr(this), oneTime);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "stop");

        /// <summary>
        /// <para>Stops applying IK effects on each frame to the <see cref="Godot.Skeleton"/> bones and also calls <see cref="Godot.Skeleton.ClearBonesGlobalPoseOverride"/> to remove existing overrides on all bones.</para>
        /// </summary>
        [GodotMethod("stop")]
        public void Stop()
        {
            NativeCalls.godot_icall_0_3(method_bind_23, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
