using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A deformable physics body. Used to create elastic or deformable objects such as cloth, rubber, or other flexible materials.</para>
    /// <para>Note: There are many known bugs in <see cref="Godot.SoftBody"/>. Therefore, it's not recommended to use them for things that can affect gameplay (such as a player character made entirely out of soft bodies).</para>
    /// </summary>
    public partial class SoftBody : MeshInstance
    {
        /// <summary>
        /// <para>If <c>true</c>, the <see cref="Godot.SoftBody"/> is simulated in physics. Can be set to <c>false</c> to pause the physics simulation.</para>
        /// </summary>
        public bool PhysicsEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsPhysicsEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPhysicsEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The physics layers this SoftBody is in.</para>
        /// <para>Collidable objects can exist in any of 32 different layers. These layers work like a tagging system, and are not visual. A collidable can use these layers to select with which objects it can collide, using the collision_mask property.</para>
        /// <para>A contact is detected if object A is in any of the layers that object B scans, or object B is in any layer scanned by object A. See <a href="$DOCS_URL/tutorials/physics/physics_introduction.html#collision-layers-and-masks">Collision layers and masks</a> in the documentation for more information.</para>
        /// </summary>
        public uint CollisionLayer
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCollisionLayer();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCollisionLayer(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The physics layers this SoftBody scans for collisions. See <a href="$DOCS_URL/tutorials/physics/physics_introduction.html#collision-layers-and-masks">Collision layers and masks</a> in the documentation for more information.</para>
        /// </summary>
        public uint CollisionMask
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCollisionMask();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCollisionMask(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para><see cref="Godot.NodePath"/> to a <see cref="Godot.CollisionObject"/> this SoftBody should avoid clipping.</para>
        /// </summary>
        public NodePath ParentCollisionIgnore
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParentCollisionIgnore();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParentCollisionIgnore(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Increasing this value will improve the resulting simulation, but can affect performance. Use with care.</para>
        /// </summary>
        public int SimulationPrecision
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSimulationPrecision();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSimulationPrecision(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The SoftBody's mass.</para>
        /// </summary>
        public float TotalMass
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTotalMass();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTotalMass(value);
            }
#pragma warning restore CS0618
        }

        public float LinearStiffness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLinearStiffness();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLinearStiffness(value);
            }
#pragma warning restore CS0618
        }

        public float AreaAngularStiffness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAreaAngularStiffness();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAreaAngularStiffness(value);
            }
#pragma warning restore CS0618
        }

        public float VolumeStiffness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVolumeStiffness();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVolumeStiffness(value);
            }
#pragma warning restore CS0618
        }

        public float PressureCoefficient
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPressureCoefficient();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPressureCoefficient(value);
            }
#pragma warning restore CS0618
        }

        public float DampingCoefficient
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDampingCoefficient();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDampingCoefficient(value);
            }
#pragma warning restore CS0618
        }

        public float DragCoefficient
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDragCoefficient();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDragCoefficient(value);
            }
#pragma warning restore CS0618
        }

        public float PoseMatchingCoefficient
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPoseMatchingCoefficient();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPoseMatchingCoefficient(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the <see cref="Godot.SoftBody"/> will respond to <see cref="Godot.RayCast"/>s.</para>
        /// </summary>
        public bool RayPickable
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsRayPickable();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRayPickable(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "SoftBody";

        public SoftBody() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_SoftBody_Ctor(this);
        }

        internal SoftBody(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_physics_enabled");

        [GodotMethod("set_physics_enabled")]
        [Obsolete("SetPhysicsEnabled is deprecated. Use the PhysicsEnabled property instead.")]
        public void SetPhysicsEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_physics_enabled");

        [GodotMethod("is_physics_enabled")]
        [Obsolete("IsPhysicsEnabled is deprecated. Use the PhysicsEnabled property instead.")]
        public bool IsPhysicsEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_mask");

        [GodotMethod("set_collision_mask")]
        [Obsolete("SetCollisionMask is deprecated. Use the CollisionMask property instead.")]
        public void SetCollisionMask(uint collisionMask)
        {
            NativeCalls.godot_icall_1_187(method_bind_2, Object.GetPtr(this), collisionMask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_mask");

        [GodotMethod("get_collision_mask")]
        [Obsolete("GetCollisionMask is deprecated. Use the CollisionMask property instead.")]
        public uint GetCollisionMask()
        {
            return NativeCalls.godot_icall_0_188(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_layer");

        [GodotMethod("set_collision_layer")]
        [Obsolete("SetCollisionLayer is deprecated. Use the CollisionLayer property instead.")]
        public void SetCollisionLayer(uint collisionLayer)
        {
            NativeCalls.godot_icall_1_187(method_bind_4, Object.GetPtr(this), collisionLayer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_layer");

        [GodotMethod("get_collision_layer")]
        [Obsolete("GetCollisionLayer is deprecated. Use the CollisionLayer property instead.")]
        public uint GetCollisionLayer()
        {
            return NativeCalls.godot_icall_0_188(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_mask_bit");

        /// <summary>
        /// <para>Sets individual bits on the collision mask. Use this if you only need to change one layer's value.</para>
        /// </summary>
        [GodotMethod("set_collision_mask_bit")]
        public void SetCollisionMaskBit(int bit, bool value)
        {
            NativeCalls.godot_icall_2_23(method_bind_6, Object.GetPtr(this), bit, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_mask_bit");

        /// <summary>
        /// <para>Returns an individual bit on the collision mask.</para>
        /// </summary>
        [GodotMethod("get_collision_mask_bit")]
        public bool GetCollisionMaskBit(int bit)
        {
            return NativeCalls.godot_icall_1_35(method_bind_7, Object.GetPtr(this), bit);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_layer_bit");

        /// <summary>
        /// <para>Sets individual bits on the layer mask. Use this if you only need to change one layer's value.</para>
        /// </summary>
        [GodotMethod("set_collision_layer_bit")]
        public void SetCollisionLayerBit(int bit, bool value)
        {
            NativeCalls.godot_icall_2_23(method_bind_8, Object.GetPtr(this), bit, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_layer_bit");

        /// <summary>
        /// <para>Returns an individual bit on the collision mask.</para>
        /// </summary>
        [GodotMethod("get_collision_layer_bit")]
        public bool GetCollisionLayerBit(int bit)
        {
            return NativeCalls.godot_icall_1_35(method_bind_9, Object.GetPtr(this), bit);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_parent_collision_ignore");

        [GodotMethod("set_parent_collision_ignore")]
        [Obsolete("SetParentCollisionIgnore is deprecated. Use the ParentCollisionIgnore property instead.")]
        public void SetParentCollisionIgnore(NodePath parentCollisionIgnore)
        {
            NativeCalls.godot_icall_1_129(method_bind_10, Object.GetPtr(this), NodePath.GetPtr(parentCollisionIgnore));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_parent_collision_ignore");

        [GodotMethod("get_parent_collision_ignore")]
        [Obsolete("GetParentCollisionIgnore is deprecated. Use the ParentCollisionIgnore property instead.")]
        public NodePath GetParentCollisionIgnore()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_11, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_exceptions");

        /// <summary>
        /// <para>Returns an array of nodes that were added as collision exceptions for this body.</para>
        /// </summary>
        [GodotMethod("get_collision_exceptions")]
        public Godot.Collections.Array GetCollisionExceptions()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_12, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_collision_exception_with");

        /// <summary>
        /// <para>Adds a body to the list of bodies that this body can't collide with.</para>
        /// </summary>
        [GodotMethod("add_collision_exception_with")]
        public void AddCollisionExceptionWith(Node body)
        {
            NativeCalls.godot_icall_1_53(method_bind_13, Object.GetPtr(this), Object.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_collision_exception_with");

        /// <summary>
        /// <para>Removes a body from the list of bodies that this body can't collide with.</para>
        /// </summary>
        [GodotMethod("remove_collision_exception_with")]
        public void RemoveCollisionExceptionWith(Node body)
        {
            NativeCalls.godot_icall_1_53(method_bind_14, Object.GetPtr(this), Object.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_simulation_precision");

        [GodotMethod("set_simulation_precision")]
        [Obsolete("SetSimulationPrecision is deprecated. Use the SimulationPrecision property instead.")]
        public void SetSimulationPrecision(int simulationPrecision)
        {
            NativeCalls.godot_icall_1_4(method_bind_15, Object.GetPtr(this), simulationPrecision);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_simulation_precision");

        [GodotMethod("get_simulation_precision")]
        [Obsolete("GetSimulationPrecision is deprecated. Use the SimulationPrecision property instead.")]
        public int GetSimulationPrecision()
        {
            return NativeCalls.godot_icall_0_5(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_total_mass");

        [GodotMethod("set_total_mass")]
        [Obsolete("SetTotalMass is deprecated. Use the TotalMass property instead.")]
        public void SetTotalMass(float mass)
        {
            NativeCalls.godot_icall_1_15(method_bind_17, Object.GetPtr(this), mass);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_total_mass");

        [GodotMethod("get_total_mass")]
        [Obsolete("GetTotalMass is deprecated. Use the TotalMass property instead.")]
        public float GetTotalMass()
        {
            return NativeCalls.godot_icall_0_14(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_linear_stiffness");

        [GodotMethod("set_linear_stiffness")]
        [Obsolete("SetLinearStiffness is deprecated. Use the LinearStiffness property instead.")]
        public void SetLinearStiffness(float linearStiffness)
        {
            NativeCalls.godot_icall_1_15(method_bind_19, Object.GetPtr(this), linearStiffness);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_linear_stiffness");

        [GodotMethod("get_linear_stiffness")]
        [Obsolete("GetLinearStiffness is deprecated. Use the LinearStiffness property instead.")]
        public float GetLinearStiffness()
        {
            return NativeCalls.godot_icall_0_14(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_areaAngular_stiffness");

        [GodotMethod("set_areaAngular_stiffness")]
        [Obsolete("SetAreaAngularStiffness is deprecated. Use the AreaAngularStiffness property instead.")]
        public void SetAreaAngularStiffness(float areaAngularStiffness)
        {
            NativeCalls.godot_icall_1_15(method_bind_21, Object.GetPtr(this), areaAngularStiffness);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_areaAngular_stiffness");

        [GodotMethod("get_areaAngular_stiffness")]
        [Obsolete("GetAreaAngularStiffness is deprecated. Use the AreaAngularStiffness property instead.")]
        public float GetAreaAngularStiffness()
        {
            return NativeCalls.godot_icall_0_14(method_bind_22, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_volume_stiffness");

        [GodotMethod("set_volume_stiffness")]
        [Obsolete("SetVolumeStiffness is deprecated. Use the VolumeStiffness property instead.")]
        public void SetVolumeStiffness(float volumeStiffness)
        {
            NativeCalls.godot_icall_1_15(method_bind_23, Object.GetPtr(this), volumeStiffness);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_volume_stiffness");

        [GodotMethod("get_volume_stiffness")]
        [Obsolete("GetVolumeStiffness is deprecated. Use the VolumeStiffness property instead.")]
        public float GetVolumeStiffness()
        {
            return NativeCalls.godot_icall_0_14(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pressure_coefficient");

        [GodotMethod("set_pressure_coefficient")]
        [Obsolete("SetPressureCoefficient is deprecated. Use the PressureCoefficient property instead.")]
        public void SetPressureCoefficient(float pressureCoefficient)
        {
            NativeCalls.godot_icall_1_15(method_bind_25, Object.GetPtr(this), pressureCoefficient);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pressure_coefficient");

        [GodotMethod("get_pressure_coefficient")]
        [Obsolete("GetPressureCoefficient is deprecated. Use the PressureCoefficient property instead.")]
        public float GetPressureCoefficient()
        {
            return NativeCalls.godot_icall_0_14(method_bind_26, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pose_matching_coefficient");

        [GodotMethod("set_pose_matching_coefficient")]
        [Obsolete("SetPoseMatchingCoefficient is deprecated. Use the PoseMatchingCoefficient property instead.")]
        public void SetPoseMatchingCoefficient(float poseMatchingCoefficient)
        {
            NativeCalls.godot_icall_1_15(method_bind_27, Object.GetPtr(this), poseMatchingCoefficient);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pose_matching_coefficient");

        [GodotMethod("get_pose_matching_coefficient")]
        [Obsolete("GetPoseMatchingCoefficient is deprecated. Use the PoseMatchingCoefficient property instead.")]
        public float GetPoseMatchingCoefficient()
        {
            return NativeCalls.godot_icall_0_14(method_bind_28, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_damping_coefficient");

        [GodotMethod("set_damping_coefficient")]
        [Obsolete("SetDampingCoefficient is deprecated. Use the DampingCoefficient property instead.")]
        public void SetDampingCoefficient(float dampingCoefficient)
        {
            NativeCalls.godot_icall_1_15(method_bind_29, Object.GetPtr(this), dampingCoefficient);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_damping_coefficient");

        [GodotMethod("get_damping_coefficient")]
        [Obsolete("GetDampingCoefficient is deprecated. Use the DampingCoefficient property instead.")]
        public float GetDampingCoefficient()
        {
            return NativeCalls.godot_icall_0_14(method_bind_30, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_drag_coefficient");

        [GodotMethod("set_drag_coefficient")]
        [Obsolete("SetDragCoefficient is deprecated. Use the DragCoefficient property instead.")]
        public void SetDragCoefficient(float dragCoefficient)
        {
            NativeCalls.godot_icall_1_15(method_bind_31, Object.GetPtr(this), dragCoefficient);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_drag_coefficient");

        [GodotMethod("get_drag_coefficient")]
        [Obsolete("GetDragCoefficient is deprecated. Use the DragCoefficient property instead.")]
        public float GetDragCoefficient()
        {
            return NativeCalls.godot_icall_0_14(method_bind_32, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_point_transform");

        /// <summary>
        /// <para>Returns local translation of a vertex in the surface array.</para>
        /// </summary>
        [GodotMethod("get_point_transform")]
        public Vector3 GetPointTransform(int pointIndex)
        {
            NativeCalls.godot_icall_1_32(method_bind_33, Object.GetPtr(this), pointIndex, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_point_pinned");

        /// <summary>
        /// <para>Sets the pinned state of a surface vertex. When set to <c>true</c>, the optional <c>attachment_path</c> can define a <see cref="Godot.Spatial"/> the pinned vertex will be attached to.</para>
        /// </summary>
        /// <param name="attachmentPath">If the parameter is null, then the default value is (NodePath)""</param>
        [GodotMethod("set_point_pinned")]
        public void SetPointPinned(int pointIndex, bool pinned, NodePath attachmentPath = null)
        {
            NodePath attachmentPath_in = attachmentPath != null ? attachmentPath : (NodePath)"";
            NativeCalls.godot_icall_3_864(method_bind_34, Object.GetPtr(this), pointIndex, pinned, NodePath.GetPtr(attachmentPath_in));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_point_pinned");

        /// <summary>
        /// <para>Returns <c>true</c> if vertex is set to pinned.</para>
        /// </summary>
        [GodotMethod("is_point_pinned")]
        public bool IsPointPinned(int pointIndex)
        {
            return NativeCalls.godot_icall_1_35(method_bind_35, Object.GetPtr(this), pointIndex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ray_pickable");

        [GodotMethod("set_ray_pickable")]
        [Obsolete("SetRayPickable is deprecated. Use the RayPickable property instead.")]
        public void SetRayPickable(bool rayPickable)
        {
            NativeCalls.godot_icall_1_16(method_bind_36, Object.GetPtr(this), rayPickable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_ray_pickable");

        [GodotMethod("is_ray_pickable")]
        [Obsolete("IsRayPickable is deprecated. Use the RayPickable property instead.")]
        public bool IsRayPickable()
        {
            return NativeCalls.godot_icall_0_7(method_bind_37, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
