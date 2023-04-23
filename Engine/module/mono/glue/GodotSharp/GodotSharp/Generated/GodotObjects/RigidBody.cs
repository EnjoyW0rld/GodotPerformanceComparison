using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This is the node that implements full 3D physics. This means that you do not control a RigidBody directly. Instead, you can apply forces to it (gravity, impulses, etc.), and the physics simulation will calculate the resulting movement, collision, bouncing, rotating, etc.</para>
    /// <para>A RigidBody has 4 behavior <see cref="Godot.RigidBody.Mode"/>s: Rigid, Static, Character, and Kinematic.</para>
    /// <para>Note: Don't change a RigidBody's position every frame or very often. Sporadic changes work fine, but physics runs at a different granularity (fixed Hz) than usual rendering (process callback) and maybe even in a separate thread, so changing this from a process loop may result in strange behavior. If you need to directly affect the body's state, use <see cref="Godot.RigidBody._IntegrateForces"/>, which allows you to directly access the physics state.</para>
    /// <para>If you need to override the default physics behavior, you can write a custom force integration function. See <see cref="Godot.RigidBody.CustomIntegrator"/>.</para>
    /// <para>With Bullet physics (the default), the center of mass is the RigidBody3D center. With GodotPhysics, the center of mass is the average of the <see cref="Godot.CollisionShape"/> centers.</para>
    /// </summary>
    public partial class RigidBody : PhysicsBody
    {
        public enum ModeEnum
        {
            /// <summary>
            /// <para>Rigid body mode. This is the "natural" state of a rigid body. It is affected by forces, and can move, rotate, and be affected by user code.</para>
            /// </summary>
            Rigid = 0,
            /// <summary>
            /// <para>Static mode. The body behaves like a <see cref="Godot.StaticBody"/>, and can only move by user code.</para>
            /// </summary>
            Static = 1,
            /// <summary>
            /// <para>Character body mode. This behaves like a rigid body, but can not rotate.</para>
            /// </summary>
            Character = 2,
            /// <summary>
            /// <para>Kinematic body mode. The body behaves like a <see cref="Godot.KinematicBody"/>, and can only move by user code.</para>
            /// </summary>
            Kinematic = 3
        }

        /// <summary>
        /// <para>The body mode. See <see cref="Godot.RigidBody.ModeEnum"/> for possible values.</para>
        /// </summary>
        public RigidBody.ModeEnum Mode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The body's mass.</para>
        /// </summary>
        public float Mass
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMass();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMass(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The body's weight based on its mass and the global 3D gravity. Global values are set in Project &gt; Project Settings &gt; Physics &gt; 3d.</para>
        /// </summary>
        public float Weight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetWeight();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetWeight(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The body's friction, from 0 (frictionless) to 1 (max friction).</para>
        /// <para>Deprecated, use <see cref="Godot.PhysicsMaterial.Friction"/> instead via <see cref="Godot.RigidBody.PhysicsMaterialOverride"/>.</para>
        /// </summary>
        public float Friction
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFriction();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFriction(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The body's bounciness. Values range from <c>0</c> (no bounce) to <c>1</c> (full bounciness).</para>
        /// <para>Deprecated, use <see cref="Godot.PhysicsMaterial.Bounce"/> instead via <see cref="Godot.RigidBody.PhysicsMaterialOverride"/>.</para>
        /// </summary>
        public float Bounce
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBounce();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBounce(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The physics material override for the body.</para>
        /// <para>If a material is assigned to this property, it will be used instead of any other physics material, such as an inherited one.</para>
        /// </summary>
        public PhysicsMaterial PhysicsMaterialOverride
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPhysicsMaterialOverride();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPhysicsMaterialOverride(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>This is multiplied by the global 3D gravity setting found in Project &gt; Project Settings &gt; Physics &gt; 3d to produce RigidBody's gravity. For example, a value of 1 will be normal gravity, 2 will apply double gravity, and 0.5 will apply half gravity to this object.</para>
        /// </summary>
        public float GravityScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGravityScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGravityScale(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, internal force integration will be disabled (like gravity or air friction) for this body. Other than collision response, the body will only move as determined by the <see cref="Godot.RigidBody._IntegrateForces"/> function, if defined.</para>
        /// </summary>
        public bool CustomIntegrator
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUsingCustomIntegrator();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseCustomIntegrator(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, continuous collision detection is used.</para>
        /// <para>Continuous collision detection tries to predict where a moving body will collide, instead of moving it and correcting its movement if it collided. Continuous collision detection is more precise, and misses fewer impacts by small, fast-moving objects. Not using continuous collision detection is faster to compute, but can miss small, fast-moving objects.</para>
        /// </summary>
        public bool ContinuousCd
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUsingContinuousCollisionDetection();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseContinuousCollisionDetection(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum number of contacts that will be recorded. Requires <see cref="Godot.RigidBody.ContactMonitor"/> to be set to <c>true</c>.</para>
        /// <para>Note: The number of contacts is different from the number of collisions. Collisions between parallel edges will result in two contacts (one at each end), and collisions between parallel faces will result in four contacts (one at each corner).</para>
        /// </summary>
        public int ContactsReported
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaxContactsReported();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaxContactsReported(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the RigidBody will emit signals when it collides with another RigidBody. See also <see cref="Godot.RigidBody.ContactsReported"/>.</para>
        /// </summary>
        public bool ContactMonitor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsContactMonitorEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetContactMonitor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the body will not move and will not calculate forces until woken up by another body through, for example, a collision, or by using the <see cref="Godot.RigidBody.ApplyImpulse"/> or <see cref="Godot.RigidBody.AddForce"/> methods.</para>
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
                SetSleeping(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the body can enter sleep mode when there is no movement. See <see cref="Godot.RigidBody.Sleeping"/>.</para>
        /// <para>Note: A RigidBody3D will never enter sleep mode automatically if its <see cref="Godot.RigidBody.Mode"/> is <see cref="Godot.RigidBody.ModeEnum.Character"/>. It can still be put to sleep manually by setting its <see cref="Godot.RigidBody.Sleeping"/> property to <c>true</c>.</para>
        /// </summary>
        public bool CanSleep
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsAbleToSleep();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCanSleep(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Lock the body's movement in the X axis.</para>
        /// </summary>
        public bool AxisLockLinearX
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAxisLock((PhysicsServer.BodyAxis)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAxisLock((PhysicsServer.BodyAxis)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Lock the body's movement in the Y axis.</para>
        /// </summary>
        public bool AxisLockLinearY
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAxisLock((PhysicsServer.BodyAxis)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAxisLock((PhysicsServer.BodyAxis)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Lock the body's movement in the Z axis.</para>
        /// </summary>
        public bool AxisLockLinearZ
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAxisLock((PhysicsServer.BodyAxis)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAxisLock((PhysicsServer.BodyAxis)4, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Lock the body's rotation in the X axis.</para>
        /// </summary>
        public bool AxisLockAngularX
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAxisLock((PhysicsServer.BodyAxis)8);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAxisLock((PhysicsServer.BodyAxis)8, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Lock the body's rotation in the Y axis.</para>
        /// </summary>
        public bool AxisLockAngularY
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAxisLock((PhysicsServer.BodyAxis)16);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAxisLock((PhysicsServer.BodyAxis)16, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Lock the body's rotation in the Z axis.</para>
        /// </summary>
        public bool AxisLockAngularZ
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAxisLock((PhysicsServer.BodyAxis)32);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAxisLock((PhysicsServer.BodyAxis)32, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The body's linear velocity in units per second. Can be used sporadically, but don't set this every frame, because physics may run in another thread and runs at a different granularity. Use <see cref="Godot.RigidBody._IntegrateForces"/> as your process loop for precise control of the body state.</para>
        /// </summary>
        public Vector3 LinearVelocity
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
        /// <para>The body's linear damp. Cannot be less than -1.0. If this value is different from -1.0 it will be added to any linear damp derived from the world or areas.</para>
        /// <para>See  for more details about damping.</para>
        /// </summary>
        public float LinearDamp
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLinearDamp();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLinearDamp(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The body's rotational velocity in axis-angle format. The magnitude of the vector is the rotation rate in radians per second.</para>
        /// </summary>
        public Vector3 AngularVelocity
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
        /// <para>Damps the body's rotational forces. If this value is different from -1.0 it will be added to any angular damp derived from the world or areas.</para>
        /// <para>See  for more details about damping.</para>
        /// </summary>
        public float AngularDamp
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAngularDamp();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAngularDamp(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "RigidBody";

        public RigidBody() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_RigidBody_Ctor(this);
        }

        internal RigidBody(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>Called during physics processing, allowing you to read and safely modify the simulation state for the object. By default, it works in addition to the usual physics behavior, but the <see cref="Godot.RigidBody.CustomIntegrator"/> property allows you to disable the default behavior and do fully custom force integration for a body.</para>
        /// </summary>
        [GodotMethod("_integrate_forces")]
        public virtual void _IntegrateForces(PhysicsDirectBodyState state)
        {
            return;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mode");

        [GodotMethod("set_mode")]
        [Obsolete("SetMode is deprecated. Use the Mode property instead.")]
        public void SetMode(RigidBody.ModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mode");

        [GodotMethod("get_mode")]
        [Obsolete("GetMode is deprecated. Use the Mode property instead.")]
        public RigidBody.ModeEnum GetMode()
        {
            return (RigidBody.ModeEnum)NativeCalls.godot_icall_0_825(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mass");

        [GodotMethod("set_mass")]
        [Obsolete("SetMass is deprecated. Use the Mass property instead.")]
        public void SetMass(float mass)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), mass);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mass");

        [GodotMethod("get_mass")]
        [Obsolete("GetMass is deprecated. Use the Mass property instead.")]
        public float GetMass()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_weight");

        [GodotMethod("set_weight")]
        [Obsolete("SetWeight is deprecated. Use the Weight property instead.")]
        public void SetWeight(float weight)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), weight);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_weight");

        [GodotMethod("get_weight")]
        [Obsolete("GetWeight is deprecated. Use the Weight property instead.")]
        public float GetWeight()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_friction");

        [GodotMethod("set_friction")]
        [Obsolete("SetFriction is deprecated. Use the Friction property instead.")]
        public void SetFriction(float friction)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), friction);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_friction");

        [GodotMethod("get_friction")]
        [Obsolete("GetFriction is deprecated. Use the Friction property instead.")]
        public float GetFriction()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bounce");

        [GodotMethod("set_bounce")]
        [Obsolete("SetBounce is deprecated. Use the Bounce property instead.")]
        public void SetBounce(float bounce)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), bounce);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bounce");

        [GodotMethod("get_bounce")]
        [Obsolete("GetBounce is deprecated. Use the Bounce property instead.")]
        public float GetBounce()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_physics_material_override");

        [GodotMethod("set_physics_material_override")]
        [Obsolete("SetPhysicsMaterialOverride is deprecated. Use the PhysicsMaterialOverride property instead.")]
        public void SetPhysicsMaterialOverride(PhysicsMaterial physicsMaterialOverride)
        {
            NativeCalls.godot_icall_1_24(method_bind_10, Object.GetPtr(this), Object.GetPtr(physicsMaterialOverride));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_physics_material_override");

        [GodotMethod("get_physics_material_override")]
        [Obsolete("GetPhysicsMaterialOverride is deprecated. Use the PhysicsMaterialOverride property instead.")]
        public PhysicsMaterial GetPhysicsMaterialOverride()
        {
            return NativeCalls.godot_icall_0_477(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_linear_velocity");

        [GodotMethod("set_linear_velocity")]
        [Obsolete("SetLinearVelocity is deprecated. Use the LinearVelocity property instead.")]
        public void SetLinearVelocity(Vector3 linearVelocity)
        {
            NativeCalls.godot_icall_1_148(method_bind_12, Object.GetPtr(this), ref linearVelocity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_linear_velocity");

        [GodotMethod("get_linear_velocity")]
        [Obsolete("GetLinearVelocity is deprecated. Use the LinearVelocity property instead.")]
        public Vector3 GetLinearVelocity()
        {
            NativeCalls.godot_icall_0_8(method_bind_13, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_angular_velocity");

        [GodotMethod("set_angular_velocity")]
        [Obsolete("SetAngularVelocity is deprecated. Use the AngularVelocity property instead.")]
        public void SetAngularVelocity(Vector3 angularVelocity)
        {
            NativeCalls.godot_icall_1_148(method_bind_14, Object.GetPtr(this), ref angularVelocity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_angular_velocity");

        [GodotMethod("get_angular_velocity")]
        [Obsolete("GetAngularVelocity is deprecated. Use the AngularVelocity property instead.")]
        public Vector3 GetAngularVelocity()
        {
            NativeCalls.godot_icall_0_8(method_bind_15, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_inverse_inertia_tensor");

        /// <summary>
        /// <para>Returns the inverse inertia tensor basis. This is used to calculate the angular acceleration resulting from a torque applied to the RigidBody.</para>
        /// </summary>
        [GodotMethod("get_inverse_inertia_tensor")]
        public Basis GetInverseInertiaTensor()
        {
            NativeCalls.godot_icall_0_20(method_bind_16, Object.GetPtr(this), out Basis argRet); return (Basis)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_gravity_scale");

        [GodotMethod("set_gravity_scale")]
        [Obsolete("SetGravityScale is deprecated. Use the GravityScale property instead.")]
        public void SetGravityScale(float gravityScale)
        {
            NativeCalls.godot_icall_1_15(method_bind_17, Object.GetPtr(this), gravityScale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_gravity_scale");

        [GodotMethod("get_gravity_scale")]
        [Obsolete("GetGravityScale is deprecated. Use the GravityScale property instead.")]
        public float GetGravityScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_linear_damp");

        [GodotMethod("set_linear_damp")]
        [Obsolete("SetLinearDamp is deprecated. Use the LinearDamp property instead.")]
        public void SetLinearDamp(float linearDamp)
        {
            NativeCalls.godot_icall_1_15(method_bind_19, Object.GetPtr(this), linearDamp);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_linear_damp");

        [GodotMethod("get_linear_damp")]
        [Obsolete("GetLinearDamp is deprecated. Use the LinearDamp property instead.")]
        public float GetLinearDamp()
        {
            return NativeCalls.godot_icall_0_14(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_angular_damp");

        [GodotMethod("set_angular_damp")]
        [Obsolete("SetAngularDamp is deprecated. Use the AngularDamp property instead.")]
        public void SetAngularDamp(float angularDamp)
        {
            NativeCalls.godot_icall_1_15(method_bind_21, Object.GetPtr(this), angularDamp);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_angular_damp");

        [GodotMethod("get_angular_damp")]
        [Obsolete("GetAngularDamp is deprecated. Use the AngularDamp property instead.")]
        public float GetAngularDamp()
        {
            return NativeCalls.godot_icall_0_14(method_bind_22, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max_contacts_reported");

        [GodotMethod("set_max_contacts_reported")]
        [Obsolete("SetMaxContactsReported is deprecated. Use the ContactsReported property instead.")]
        public void SetMaxContactsReported(int amount)
        {
            NativeCalls.godot_icall_1_4(method_bind_23, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max_contacts_reported");

        [GodotMethod("get_max_contacts_reported")]
        [Obsolete("GetMaxContactsReported is deprecated. Use the ContactsReported property instead.")]
        public int GetMaxContactsReported()
        {
            return NativeCalls.godot_icall_0_5(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_custom_integrator");

        [GodotMethod("set_use_custom_integrator")]
        [Obsolete("SetUseCustomIntegrator is deprecated. Use the CustomIntegrator property instead.")]
        public void SetUseCustomIntegrator(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_25, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_using_custom_integrator");

        [GodotMethod("is_using_custom_integrator")]
        [Obsolete("IsUsingCustomIntegrator is deprecated. Use the CustomIntegrator property instead.")]
        public bool IsUsingCustomIntegrator()
        {
            return NativeCalls.godot_icall_0_7(method_bind_26, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_contact_monitor");

        [GodotMethod("set_contact_monitor")]
        [Obsolete("SetContactMonitor is deprecated. Use the ContactMonitor property instead.")]
        public void SetContactMonitor(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_27, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_contact_monitor_enabled");

        [GodotMethod("is_contact_monitor_enabled")]
        [Obsolete("IsContactMonitorEnabled is deprecated. Use the ContactMonitor property instead.")]
        public bool IsContactMonitorEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_28, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_continuous_collision_detection");

        [GodotMethod("set_use_continuous_collision_detection")]
        [Obsolete("SetUseContinuousCollisionDetection is deprecated. Use the ContinuousCd property instead.")]
        public void SetUseContinuousCollisionDetection(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_29, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_using_continuous_collision_detection");

        [GodotMethod("is_using_continuous_collision_detection")]
        [Obsolete("IsUsingContinuousCollisionDetection is deprecated. Use the ContinuousCd property instead.")]
        public bool IsUsingContinuousCollisionDetection()
        {
            return NativeCalls.godot_icall_0_7(method_bind_30, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_axis_velocity");

        /// <summary>
        /// <para>Sets an axis velocity. The velocity in the given vector axis will be set as the given vector length. This is useful for jumping behavior.</para>
        /// </summary>
        [GodotMethod("set_axis_velocity")]
        public void SetAxisVelocity(Vector3 axisVelocity)
        {
            NativeCalls.godot_icall_1_148(method_bind_31, Object.GetPtr(this), ref axisVelocity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_central_force");

        /// <summary>
        /// <para>Adds a constant directional force (i.e. acceleration) without affecting rotation.</para>
        /// <para>This is equivalent to <c>add_force(force, Vector3(0,0,0))</c>.</para>
        /// </summary>
        [GodotMethod("add_central_force")]
        public void AddCentralForce(Vector3 force)
        {
            NativeCalls.godot_icall_1_148(method_bind_32, Object.GetPtr(this), ref force);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_force");

        /// <summary>
        /// <para>Adds a constant directional force (i.e. acceleration).</para>
        /// <para>The position uses the rotation of the global coordinate system, but is centered at the object's origin.</para>
        /// </summary>
        [GodotMethod("add_force")]
        public void AddForce(Vector3 force, Vector3 position)
        {
            NativeCalls.godot_icall_2_729(method_bind_33, Object.GetPtr(this), ref force, ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_torque");

        /// <summary>
        /// <para>Adds a constant rotational force (i.e. a motor) without affecting position.</para>
        /// </summary>
        [GodotMethod("add_torque")]
        public void AddTorque(Vector3 torque)
        {
            NativeCalls.godot_icall_1_148(method_bind_34, Object.GetPtr(this), ref torque);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "apply_central_impulse");

        /// <summary>
        /// <para>Applies a directional impulse without affecting rotation.</para>
        /// <para>This is equivalent to <c>apply_impulse(Vector3(0,0,0), impulse)</c>.</para>
        /// </summary>
        [GodotMethod("apply_central_impulse")]
        public void ApplyCentralImpulse(Vector3 impulse)
        {
            NativeCalls.godot_icall_1_148(method_bind_35, Object.GetPtr(this), ref impulse);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "apply_impulse");

        /// <summary>
        /// <para>Applies a positioned impulse to the body. An impulse is time independent! Applying an impulse every frame would result in a framerate-dependent force. For this reason it should only be used when simulating one-time impacts. The position uses the rotation of the global coordinate system, but is centered at the object's origin.</para>
        /// </summary>
        [GodotMethod("apply_impulse")]
        public void ApplyImpulse(Vector3 position, Vector3 impulse)
        {
            NativeCalls.godot_icall_2_729(method_bind_36, Object.GetPtr(this), ref position, ref impulse);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "apply_torque_impulse");

        /// <summary>
        /// <para>Applies a torque impulse which will be affected by the body mass and shape. This will rotate the body around the <c>impulse</c> vector passed.</para>
        /// </summary>
        [GodotMethod("apply_torque_impulse")]
        public void ApplyTorqueImpulse(Vector3 impulse)
        {
            NativeCalls.godot_icall_1_148(method_bind_37, Object.GetPtr(this), ref impulse);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sleeping");

        [GodotMethod("set_sleeping")]
        [Obsolete("SetSleeping is deprecated. Use the Sleeping property instead.")]
        public void SetSleeping(bool sleeping)
        {
            NativeCalls.godot_icall_1_16(method_bind_38, Object.GetPtr(this), sleeping);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_sleeping");

        [GodotMethod("is_sleeping")]
        [Obsolete("IsSleeping is deprecated. Use the Sleeping property instead.")]
        public bool IsSleeping()
        {
            return NativeCalls.godot_icall_0_7(method_bind_39, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_can_sleep");

        [GodotMethod("set_can_sleep")]
        [Obsolete("SetCanSleep is deprecated. Use the CanSleep property instead.")]
        public void SetCanSleep(bool ableToSleep)
        {
            NativeCalls.godot_icall_1_16(method_bind_40, Object.GetPtr(this), ableToSleep);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_able_to_sleep");

        [GodotMethod("is_able_to_sleep")]
        [Obsolete("IsAbleToSleep is deprecated. Use the CanSleep property instead.")]
        public bool IsAbleToSleep()
        {
            return NativeCalls.godot_icall_0_7(method_bind_41, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_axis_lock");

        /// <summary>
        /// <para>Locks the specified linear or rotational axis.</para>
        /// </summary>
        [GodotMethod("set_axis_lock")]
        [Obsolete("SetAxisLock is deprecated. Use the AxisLockAngularZ property instead.")]
        public void SetAxisLock(PhysicsServer.BodyAxis axis, bool @lock)
        {
            NativeCalls.godot_icall_2_23(method_bind_42, Object.GetPtr(this), (int)axis, @lock);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_axis_lock");

        /// <summary>
        /// <para>Returns <c>true</c> if the specified linear or rotational axis is locked.</para>
        /// </summary>
        [GodotMethod("get_axis_lock")]
        [Obsolete("GetAxisLock is deprecated. Use the AxisLockAngularZ property instead.")]
        public bool GetAxisLock(PhysicsServer.BodyAxis axis)
        {
            return NativeCalls.godot_icall_1_35(method_bind_43, Object.GetPtr(this), (int)axis);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_colliding_bodies");

        /// <summary>
        /// <para>Returns a list of the bodies colliding with this one. Requires <see cref="Godot.RigidBody.ContactMonitor"/> to be set to <c>true</c> and <see cref="Godot.RigidBody.ContactsReported"/> to be set high enough to detect all the collisions.</para>
        /// <para>Note: The result of this test is not immediate after moving objects. For performance, list of collisions is updated once per frame and before the physics step. Consider using signals instead.</para>
        /// </summary>
        [GodotMethod("get_colliding_bodies")]
        public Godot.Collections.Array GetCollidingBodies()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_44, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
