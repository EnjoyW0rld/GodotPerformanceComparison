using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Provides direct access to a physics body in the <see cref="Godot.Physics2DServer"/>, allowing safe changes to physics properties. This object is passed via the direct state callback of rigid/character bodies, and is intended for changing the direct state of that body. See <see cref="Godot.RigidBody2D._IntegrateForces"/>.</para>
    /// </summary>
    public abstract partial class Physics2DDirectBodyState : Object
    {
        /// <summary>
        /// <para>The timestep (delta) used for the simulation.</para>
        /// </summary>
        public float Step
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetStep();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The inverse of the mass of the body.</para>
        /// </summary>
        public float InverseMass
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInverseMass();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The inverse of the inertia of the body.</para>
        /// </summary>
        public float InverseInertia
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInverseInertia();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The rate at which the body stops rotating, if there are not any other forces moving it.</para>
        /// </summary>
        public float TotalAngularDamp
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTotalAngularDamp();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The rate at which the body stops moving, if there are not any other forces moving it.</para>
        /// </summary>
        public float TotalLinearDamp
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTotalLinearDamp();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The total gravity vector being currently applied to this body.</para>
        /// </summary>
        public Vector2 TotalGravity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTotalGravity();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The body's rotational velocity in radians per second.</para>
        /// </summary>
        public float AngularVelocity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAngularVelocity();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAngularVelocity(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The body's linear velocity in pixels per second.</para>
        /// </summary>
        public Vector2 LinearVelocity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLinearVelocity();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLinearVelocity(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, this body is currently sleeping (not active).</para>
        /// </summary>
        public bool Sleeping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsSleeping();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSleepState(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The body's transformation matrix.</para>
        /// </summary>
        public Transform2D Transform
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTransform();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTransform(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Physics2DDirectBodyState";

        internal Physics2DDirectBodyState() {}

        internal Physics2DDirectBodyState(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_total_gravity");

        [GodotMethod("get_total_gravity")]
        [Obsolete("GetTotalGravity is deprecated. Use the TotalGravity property instead.")]
        public Vector2 GetTotalGravity()
        {
            NativeCalls.godot_icall_0_18(method_bind_0, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_total_linear_damp");

        [GodotMethod("get_total_linear_damp")]
        [Obsolete("GetTotalLinearDamp is deprecated. Use the TotalLinearDamp property instead.")]
        public float GetTotalLinearDamp()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_total_angular_damp");

        [GodotMethod("get_total_angular_damp")]
        [Obsolete("GetTotalAngularDamp is deprecated. Use the TotalAngularDamp property instead.")]
        public float GetTotalAngularDamp()
        {
            return NativeCalls.godot_icall_0_14(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_inverse_mass");

        [GodotMethod("get_inverse_mass")]
        [Obsolete("GetInverseMass is deprecated. Use the InverseMass property instead.")]
        public float GetInverseMass()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_inverse_inertia");

        [GodotMethod("get_inverse_inertia")]
        [Obsolete("GetInverseInertia is deprecated. Use the InverseInertia property instead.")]
        public float GetInverseInertia()
        {
            return NativeCalls.godot_icall_0_14(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_linear_velocity");

        [GodotMethod("set_linear_velocity")]
        [Obsolete("SetLinearVelocity is deprecated. Use the LinearVelocity property instead.")]
        public void SetLinearVelocity(Vector2 velocity)
        {
            NativeCalls.godot_icall_1_57(method_bind_5, Object.GetPtr(this), ref velocity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_linear_velocity");

        [GodotMethod("get_linear_velocity")]
        [Obsolete("GetLinearVelocity is deprecated. Use the LinearVelocity property instead.")]
        public Vector2 GetLinearVelocity()
        {
            NativeCalls.godot_icall_0_18(method_bind_6, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_angular_velocity");

        [GodotMethod("set_angular_velocity")]
        [Obsolete("SetAngularVelocity is deprecated. Use the AngularVelocity property instead.")]
        public void SetAngularVelocity(float velocity)
        {
            NativeCalls.godot_icall_1_15(method_bind_7, Object.GetPtr(this), velocity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_angular_velocity");

        [GodotMethod("get_angular_velocity")]
        [Obsolete("GetAngularVelocity is deprecated. Use the AngularVelocity property instead.")]
        public float GetAngularVelocity()
        {
            return NativeCalls.godot_icall_0_14(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_transform");

        [GodotMethod("set_transform")]
        [Obsolete("SetTransform is deprecated. Use the Transform property instead.")]
        public void SetTransform(Transform2D transform)
        {
            NativeCalls.godot_icall_1_220(method_bind_9, Object.GetPtr(this), ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_transform");

        [GodotMethod("get_transform")]
        [Obsolete("GetTransform is deprecated. Use the Transform property instead.")]
        public Transform2D GetTransform()
        {
            NativeCalls.godot_icall_0_221(method_bind_10, Object.GetPtr(this), out Transform2D argRet); return (Transform2D)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_velocity_at_local_position");

        /// <summary>
        /// <para>Returns the body's velocity at the given relative position, including both translation and rotation.</para>
        /// </summary>
        [GodotMethod("get_velocity_at_local_position")]
        public Vector2 GetVelocityAtLocalPosition(Vector2 localPosition)
        {
            NativeCalls.godot_icall_1_47(method_bind_11, Object.GetPtr(this), ref localPosition, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_central_force");

        /// <summary>
        /// <para>Adds a constant directional force without affecting rotation.</para>
        /// </summary>
        [GodotMethod("add_central_force")]
        public void AddCentralForce(Vector2 force)
        {
            NativeCalls.godot_icall_1_57(method_bind_12, Object.GetPtr(this), ref force);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_force");

        /// <summary>
        /// <para>Adds a positioned force to the body. Both the force and the offset from the body origin are in global coordinates.</para>
        /// </summary>
        [GodotMethod("add_force")]
        public void AddForce(Vector2 offset, Vector2 force)
        {
            NativeCalls.godot_icall_2_731(method_bind_13, Object.GetPtr(this), ref offset, ref force);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_torque");

        /// <summary>
        /// <para>Adds a constant rotational force.</para>
        /// </summary>
        [GodotMethod("add_torque")]
        public void AddTorque(float torque)
        {
            NativeCalls.godot_icall_1_15(method_bind_14, Object.GetPtr(this), torque);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "apply_central_impulse");

        /// <summary>
        /// <para>Applies a directional impulse without affecting rotation.</para>
        /// </summary>
        [GodotMethod("apply_central_impulse")]
        public void ApplyCentralImpulse(Vector2 impulse)
        {
            NativeCalls.godot_icall_1_57(method_bind_15, Object.GetPtr(this), ref impulse);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "apply_torque_impulse");

        /// <summary>
        /// <para>Applies a rotational impulse to the body.</para>
        /// </summary>
        [GodotMethod("apply_torque_impulse")]
        public void ApplyTorqueImpulse(float impulse)
        {
            NativeCalls.godot_icall_1_15(method_bind_16, Object.GetPtr(this), impulse);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "apply_impulse");

        /// <summary>
        /// <para>Applies a positioned impulse to the body. An impulse is time-independent! Applying an impulse every frame would result in a framerate-dependent force. For this reason, it should only be used when simulating one-time impacts (use the "_force" functions otherwise). The offset uses the rotation of the global coordinate system, but is centered at the object's origin.</para>
        /// </summary>
        [GodotMethod("apply_impulse")]
        public void ApplyImpulse(Vector2 offset, Vector2 impulse)
        {
            NativeCalls.godot_icall_2_731(method_bind_17, Object.GetPtr(this), ref offset, ref impulse);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sleep_state");

        [GodotMethod("set_sleep_state")]
        [Obsolete("SetSleepState is deprecated. Use the Sleeping property instead.")]
        public void SetSleepState(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_18, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_sleeping");

        [GodotMethod("is_sleeping")]
        [Obsolete("IsSleeping is deprecated. Use the Sleeping property instead.")]
        public bool IsSleeping()
        {
            return NativeCalls.godot_icall_0_7(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_contact_count");

        /// <summary>
        /// <para>Returns the number of contacts this body has with other bodies.</para>
        /// <para>Note: By default, this returns 0 unless bodies are configured to monitor contacts. See <see cref="Godot.RigidBody2D.ContactMonitor"/>.</para>
        /// </summary>
        [GodotMethod("get_contact_count")]
        public int GetContactCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_contact_local_position");

        /// <summary>
        /// <para>Returns the local position of the contact point.</para>
        /// </summary>
        [GodotMethod("get_contact_local_position")]
        public Vector2 GetContactLocalPosition(int contactIdx)
        {
            NativeCalls.godot_icall_1_44(method_bind_21, Object.GetPtr(this), contactIdx, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_contact_local_normal");

        /// <summary>
        /// <para>Returns the local normal at the contact point.</para>
        /// </summary>
        [GodotMethod("get_contact_local_normal")]
        public Vector2 GetContactLocalNormal(int contactIdx)
        {
            NativeCalls.godot_icall_1_44(method_bind_22, Object.GetPtr(this), contactIdx, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_contact_local_shape");

        /// <summary>
        /// <para>Returns the local shape index of the collision.</para>
        /// </summary>
        [GodotMethod("get_contact_local_shape")]
        public int GetContactLocalShape(int contactIdx)
        {
            return NativeCalls.godot_icall_1_11(method_bind_23, Object.GetPtr(this), contactIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_contact_collider");

        /// <summary>
        /// <para>Returns the collider's <see cref="Godot.RID"/>.</para>
        /// </summary>
        [GodotMethod("get_contact_collider")]
        public RID GetContactCollider(int contactIdx)
        {
            return new RID(NativeCalls.godot_icall_1_484(method_bind_24, Object.GetPtr(this), contactIdx));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_contact_collider_position");

        /// <summary>
        /// <para>Returns the contact position in the collider.</para>
        /// </summary>
        [GodotMethod("get_contact_collider_position")]
        public Vector2 GetContactColliderPosition(int contactIdx)
        {
            NativeCalls.godot_icall_1_44(method_bind_25, Object.GetPtr(this), contactIdx, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_contact_collider_id");

        /// <summary>
        /// <para>Returns the collider's object id.</para>
        /// </summary>
        [GodotMethod("get_contact_collider_id")]
        public ulong GetContactColliderId(int contactIdx)
        {
            return NativeCalls.godot_icall_1_732(method_bind_26, Object.GetPtr(this), contactIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_contact_collider_object");

        /// <summary>
        /// <para>Returns the collider object. This depends on how it was created (will return a scene node if such was used to create it).</para>
        /// </summary>
        [GodotMethod("get_contact_collider_object")]
        public Object GetContactColliderObject(int contactIdx)
        {
            return NativeCalls.godot_icall_1_733(method_bind_27, Object.GetPtr(this), contactIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_contact_collider_shape");

        /// <summary>
        /// <para>Returns the collider's shape index.</para>
        /// </summary>
        [GodotMethod("get_contact_collider_shape")]
        public int GetContactColliderShape(int contactIdx)
        {
            return NativeCalls.godot_icall_1_11(method_bind_28, Object.GetPtr(this), contactIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_contact_collider_shape_metadata");

        /// <summary>
        /// <para>Returns the collided shape's metadata. This metadata is different from <see cref="Godot.Object.GetMeta"/>, and is set with <see cref="Godot.Physics2DServer.ShapeSetData"/>.</para>
        /// </summary>
        [GodotMethod("get_contact_collider_shape_metadata")]
        public object GetContactColliderShapeMetadata(int contactIdx)
        {
            return NativeCalls.godot_icall_1_543(method_bind_29, Object.GetPtr(this), contactIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_contact_collider_velocity_at_position");

        /// <summary>
        /// <para>Returns the linear velocity vector at the collider's contact point.</para>
        /// </summary>
        [GodotMethod("get_contact_collider_velocity_at_position")]
        public Vector2 GetContactColliderVelocityAtPosition(int contactIdx)
        {
            NativeCalls.godot_icall_1_44(method_bind_30, Object.GetPtr(this), contactIdx, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_step");

        [GodotMethod("get_step")]
        [Obsolete("GetStep is deprecated. Use the Step property instead.")]
        public float GetStep()
        {
            return NativeCalls.godot_icall_0_14(method_bind_31, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "integrate_forces");

        /// <summary>
        /// <para>Calls the built-in force integration code.</para>
        /// </summary>
        [GodotMethod("integrate_forces")]
        public void IntegrateForces()
        {
            NativeCalls.godot_icall_0_3(method_bind_32, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_space_state");

        /// <summary>
        /// <para>Returns the current state of the space, useful for queries.</para>
        /// </summary>
        [GodotMethod("get_space_state")]
        public Physics2DDirectSpaceState GetSpaceState()
        {
            return NativeCalls.godot_icall_0_734(method_bind_33, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
