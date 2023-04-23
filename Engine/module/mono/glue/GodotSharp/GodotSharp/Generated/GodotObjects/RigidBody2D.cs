using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This node implements simulated 2D physics. You do not control a RigidBody2D directly. Instead, you apply forces to it (gravity, impulses, etc.) and the physics simulation calculates the resulting movement based on its mass, friction, and other physical properties.</para>
    /// <para>A RigidBody2D has 4 behavior <see cref="Godot.RigidBody2D.Mode"/>s: Rigid, Static, Character, and Kinematic.</para>
    /// <para>Note: You should not change a RigidBody2D's <c>position</c> or <c>linear_velocity</c> every frame or even very often. If you need to directly affect the body's state, use <see cref="Godot.RigidBody2D._IntegrateForces"/>, which allows you to directly access the physics state.</para>
    /// <para>Please also keep in mind that physics bodies manage their own transform which overwrites the ones you set. So any direct or indirect transformation (including scaling of the node or its parent) will be visible in the editor only, and immediately reset at runtime.</para>
    /// <para>If you need to override the default physics behavior or add a transformation at runtime, you can write a custom force integration. See <see cref="Godot.RigidBody2D.CustomIntegrator"/>.</para>
    /// <para>The center of mass is always located at the node's origin without taking into account the <see cref="Godot.CollisionShape2D"/> centroid offsets.</para>
    /// </summary>
    public partial class RigidBody2D : PhysicsBody2D
    {
        public enum ModeEnum
        {
            /// <summary>
            /// <para>Rigid mode. The body behaves as a physical object. It collides with other bodies and responds to forces applied to it. This is the default mode.</para>
            /// </summary>
            Rigid = 0,
            /// <summary>
            /// <para>Static mode. The body behaves like a <see cref="Godot.StaticBody2D"/> and does not move.</para>
            /// </summary>
            Static = 1,
            /// <summary>
            /// <para>Character mode. Similar to <see cref="Godot.RigidBody2D.ModeEnum.Rigid"/>, but the body can not rotate.</para>
            /// </summary>
            Character = 2,
            /// <summary>
            /// <para>Kinematic mode. The body behaves like a <see cref="Godot.KinematicBody2D"/>, and must be moved by code.</para>
            /// </summary>
            Kinematic = 3
        }

        public enum CCDMode
        {
            /// <summary>
            /// <para>Continuous collision detection disabled. This is the fastest way to detect body collisions, but can miss small, fast-moving objects.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>Continuous collision detection enabled using raycasting. This is faster than shapecasting but less precise.</para>
            /// </summary>
            CastRay = 1,
            /// <summary>
            /// <para>Continuous collision detection enabled using shapecasting. This is the slowest CCD method and the most precise.</para>
            /// </summary>
            CastShape = 2
        }

        /// <summary>
        /// <para>The body's mode. See <see cref="Godot.RigidBody2D.ModeEnum"/> for possible values.</para>
        /// </summary>
        public RigidBody2D.ModeEnum Mode
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
        /// <para>The body's moment of inertia. This is like mass, but for rotation: it determines how much torque it takes to rotate the body. The moment of inertia is usually computed automatically from the mass and the shapes, but this function allows you to set a custom value. Set 0 inertia to return to automatically computing it.</para>
        /// </summary>
        public float Inertia
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInertia();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInertia(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The body's weight based on its mass and the Default Gravity value in Project &gt; Project Settings &gt; Physics &gt; 2d.</para>
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
        /// <para>The body's friction. Values range from <c>0</c> (frictionless) to <c>1</c> (maximum friction).</para>
        /// <para>Deprecated, use <see cref="Godot.PhysicsMaterial.Friction"/> instead via <see cref="Godot.RigidBody2D.PhysicsMaterialOverride"/>.</para>
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
        /// <para>Deprecated, use <see cref="Godot.PhysicsMaterial.Bounce"/> instead via <see cref="Godot.RigidBody2D.PhysicsMaterialOverride"/>.</para>
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
        /// <para>Multiplies the gravity applied to the body. The body's gravity is calculated from the Default Gravity value in Project &gt; Project Settings &gt; Physics &gt; 2d and/or any additional gravity vector applied by <see cref="Godot.Area2D"/>s.</para>
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
        /// <para>If <c>true</c>, internal force integration is disabled for this body. Aside from collision response, the body will only move as determined by the <see cref="Godot.RigidBody2D._IntegrateForces"/> function.</para>
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
        /// <para>Continuous collision detection mode.</para>
        /// <para>Continuous collision detection tries to predict where a moving body will collide instead of moving it and correcting its movement after collision. Continuous collision detection is slower, but more precise and misses fewer collisions with small, fast-moving objects. Raycasting and shapecasting methods are available. See <see cref="Godot.RigidBody2D.CCDMode"/> for details.</para>
        /// </summary>
        public RigidBody2D.CCDMode ContinuousCd
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetContinuousCollisionDetectionMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetContinuousCollisionDetectionMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum number of contacts that will be recorded. Requires <see cref="Godot.RigidBody2D.ContactMonitor"/> to be set to <c>true</c>.</para>
        /// <para>Note: The number of contacts is different from the number of collisions. Collisions between parallel edges will result in two contacts (one at each end).</para>
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
        /// <para>If <c>true</c>, the body will emit signals when it collides with another RigidBody2D. See also <see cref="Godot.RigidBody2D.ContactsReported"/>.</para>
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
        /// <para>If <c>true</c>, the body will not move and will not calculate forces until woken up by another body through, for example, a collision, or by using the <see cref="Godot.RigidBody2D.ApplyImpulse"/> or <see cref="Godot.RigidBody2D.AddForce"/> methods.</para>
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
        /// <para>If <c>true</c>, the body can enter sleep mode when there is no movement. See <see cref="Godot.RigidBody2D.Sleeping"/>.</para>
        /// <para>Note: A RigidBody2D will never enter sleep mode automatically if its <see cref="Godot.RigidBody2D.Mode"/> is <see cref="Godot.RigidBody2D.ModeEnum.Character"/>. It can still be put to sleep manually by setting its <see cref="Godot.RigidBody2D.Sleeping"/> property to <c>true</c>.</para>
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
        /// <para>The body's linear velocity in pixels per second. Can be used sporadically, but don't set this every frame, because physics may run in another thread and runs at a different granularity. Use <see cref="Godot.RigidBody2D._IntegrateForces"/> as your process loop for precise control of the body state.</para>
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
        /// <para>Damps the body's <see cref="Godot.RigidBody2D.LinearVelocity"/>. If <c>-1</c>, the body will use the Default Linear Damp in Project &gt; Project Settings &gt; Physics &gt; 2d. If greater than <c>-1</c> it will be added to the default project value.</para>
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
        /// <para>Damps the body's <see cref="Godot.RigidBody2D.AngularVelocity"/>. If <c>-1</c>, the body will use the Default Angular Damp defined in Project &gt; Project Settings &gt; Physics &gt; 2d. If greater than <c>-1</c> it will be added to the default project value.</para>
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

        /// <summary>
        /// <para>The body's total applied force.</para>
        /// </summary>
        public Vector2 AppliedForce
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAppliedForce();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAppliedForce(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The body's total applied torque.</para>
        /// </summary>
        public float AppliedTorque
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAppliedTorque();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAppliedTorque(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "RigidBody2D";

        public RigidBody2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_RigidBody2D_Ctor(this);
        }

        internal RigidBody2D(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>Allows you to read and safely modify the simulation state for the object. Use this instead of <see cref="Godot.Node._PhysicsProcess"/> if you need to directly change the body's <c>position</c> or other physics properties. By default, it works in addition to the usual physics behavior, but <see cref="Godot.RigidBody2D.CustomIntegrator"/> allows you to disable the default behavior and write custom force integration for a body.</para>
        /// </summary>
        [GodotMethod("_integrate_forces")]
        public virtual void _IntegrateForces(Physics2DDirectBodyState state)
        {
            return;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mode");

        [GodotMethod("set_mode")]
        [Obsolete("SetMode is deprecated. Use the Mode property instead.")]
        public void SetMode(RigidBody2D.ModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mode");

        [GodotMethod("get_mode")]
        [Obsolete("GetMode is deprecated. Use the Mode property instead.")]
        public RigidBody2D.ModeEnum GetMode()
        {
            return (RigidBody2D.ModeEnum)NativeCalls.godot_icall_0_826(method_bind_1, Object.GetPtr(this));
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
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_inertia");

        [GodotMethod("get_inertia")]
        [Obsolete("GetInertia is deprecated. Use the Inertia property instead.")]
        public float GetInertia()
        {
            return NativeCalls.godot_icall_0_14(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_inertia");

        [GodotMethod("set_inertia")]
        [Obsolete("SetInertia is deprecated. Use the Inertia property instead.")]
        public void SetInertia(float inertia)
        {
            NativeCalls.godot_icall_1_15(method_bind_5, Object.GetPtr(this), inertia);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_weight");

        [GodotMethod("set_weight")]
        [Obsolete("SetWeight is deprecated. Use the Weight property instead.")]
        public void SetWeight(float weight)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), weight);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_weight");

        [GodotMethod("get_weight")]
        [Obsolete("GetWeight is deprecated. Use the Weight property instead.")]
        public float GetWeight()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_friction");

        [GodotMethod("set_friction")]
        [Obsolete("SetFriction is deprecated. Use the Friction property instead.")]
        public void SetFriction(float friction)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), friction);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_friction");

        [GodotMethod("get_friction")]
        [Obsolete("GetFriction is deprecated. Use the Friction property instead.")]
        public float GetFriction()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bounce");

        [GodotMethod("set_bounce")]
        [Obsolete("SetBounce is deprecated. Use the Bounce property instead.")]
        public void SetBounce(float bounce)
        {
            NativeCalls.godot_icall_1_15(method_bind_10, Object.GetPtr(this), bounce);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bounce");

        [GodotMethod("get_bounce")]
        [Obsolete("GetBounce is deprecated. Use the Bounce property instead.")]
        public float GetBounce()
        {
            return NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_physics_material_override");

        [GodotMethod("set_physics_material_override")]
        [Obsolete("SetPhysicsMaterialOverride is deprecated. Use the PhysicsMaterialOverride property instead.")]
        public void SetPhysicsMaterialOverride(PhysicsMaterial physicsMaterialOverride)
        {
            NativeCalls.godot_icall_1_24(method_bind_12, Object.GetPtr(this), Object.GetPtr(physicsMaterialOverride));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_physics_material_override");

        [GodotMethod("get_physics_material_override")]
        [Obsolete("GetPhysicsMaterialOverride is deprecated. Use the PhysicsMaterialOverride property instead.")]
        public PhysicsMaterial GetPhysicsMaterialOverride()
        {
            return NativeCalls.godot_icall_0_477(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_gravity_scale");

        [GodotMethod("set_gravity_scale")]
        [Obsolete("SetGravityScale is deprecated. Use the GravityScale property instead.")]
        public void SetGravityScale(float gravityScale)
        {
            NativeCalls.godot_icall_1_15(method_bind_14, Object.GetPtr(this), gravityScale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_gravity_scale");

        [GodotMethod("get_gravity_scale")]
        [Obsolete("GetGravityScale is deprecated. Use the GravityScale property instead.")]
        public float GetGravityScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_linear_damp");

        [GodotMethod("set_linear_damp")]
        [Obsolete("SetLinearDamp is deprecated. Use the LinearDamp property instead.")]
        public void SetLinearDamp(float linearDamp)
        {
            NativeCalls.godot_icall_1_15(method_bind_16, Object.GetPtr(this), linearDamp);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_linear_damp");

        [GodotMethod("get_linear_damp")]
        [Obsolete("GetLinearDamp is deprecated. Use the LinearDamp property instead.")]
        public float GetLinearDamp()
        {
            return NativeCalls.godot_icall_0_14(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_angular_damp");

        [GodotMethod("set_angular_damp")]
        [Obsolete("SetAngularDamp is deprecated. Use the AngularDamp property instead.")]
        public void SetAngularDamp(float angularDamp)
        {
            NativeCalls.godot_icall_1_15(method_bind_18, Object.GetPtr(this), angularDamp);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_angular_damp");

        [GodotMethod("get_angular_damp")]
        [Obsolete("GetAngularDamp is deprecated. Use the AngularDamp property instead.")]
        public float GetAngularDamp()
        {
            return NativeCalls.godot_icall_0_14(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_linear_velocity");

        [GodotMethod("set_linear_velocity")]
        [Obsolete("SetLinearVelocity is deprecated. Use the LinearVelocity property instead.")]
        public void SetLinearVelocity(Vector2 linearVelocity)
        {
            NativeCalls.godot_icall_1_57(method_bind_20, Object.GetPtr(this), ref linearVelocity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_linear_velocity");

        [GodotMethod("get_linear_velocity")]
        [Obsolete("GetLinearVelocity is deprecated. Use the LinearVelocity property instead.")]
        public Vector2 GetLinearVelocity()
        {
            NativeCalls.godot_icall_0_18(method_bind_21, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_angular_velocity");

        [GodotMethod("set_angular_velocity")]
        [Obsolete("SetAngularVelocity is deprecated. Use the AngularVelocity property instead.")]
        public void SetAngularVelocity(float angularVelocity)
        {
            NativeCalls.godot_icall_1_15(method_bind_22, Object.GetPtr(this), angularVelocity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_angular_velocity");

        [GodotMethod("get_angular_velocity")]
        [Obsolete("GetAngularVelocity is deprecated. Use the AngularVelocity property instead.")]
        public float GetAngularVelocity()
        {
            return NativeCalls.godot_icall_0_14(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max_contacts_reported");

        [GodotMethod("set_max_contacts_reported")]
        [Obsolete("SetMaxContactsReported is deprecated. Use the ContactsReported property instead.")]
        public void SetMaxContactsReported(int amount)
        {
            NativeCalls.godot_icall_1_4(method_bind_24, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max_contacts_reported");

        [GodotMethod("get_max_contacts_reported")]
        [Obsolete("GetMaxContactsReported is deprecated. Use the ContactsReported property instead.")]
        public int GetMaxContactsReported()
        {
            return NativeCalls.godot_icall_0_5(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_custom_integrator");

        [GodotMethod("set_use_custom_integrator")]
        [Obsolete("SetUseCustomIntegrator is deprecated. Use the CustomIntegrator property instead.")]
        public void SetUseCustomIntegrator(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_26, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_using_custom_integrator");

        [GodotMethod("is_using_custom_integrator")]
        [Obsolete("IsUsingCustomIntegrator is deprecated. Use the CustomIntegrator property instead.")]
        public bool IsUsingCustomIntegrator()
        {
            return NativeCalls.godot_icall_0_7(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_contact_monitor");

        [GodotMethod("set_contact_monitor")]
        [Obsolete("SetContactMonitor is deprecated. Use the ContactMonitor property instead.")]
        public void SetContactMonitor(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_28, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_contact_monitor_enabled");

        [GodotMethod("is_contact_monitor_enabled")]
        [Obsolete("IsContactMonitorEnabled is deprecated. Use the ContactMonitor property instead.")]
        public bool IsContactMonitorEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_continuous_collision_detection_mode");

        [GodotMethod("set_continuous_collision_detection_mode")]
        [Obsolete("SetContinuousCollisionDetectionMode is deprecated. Use the ContinuousCd property instead.")]
        public void SetContinuousCollisionDetectionMode(RigidBody2D.CCDMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_30, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_continuous_collision_detection_mode");

        [GodotMethod("get_continuous_collision_detection_mode")]
        [Obsolete("GetContinuousCollisionDetectionMode is deprecated. Use the ContinuousCd property instead.")]
        public RigidBody2D.CCDMode GetContinuousCollisionDetectionMode()
        {
            return (RigidBody2D.CCDMode)NativeCalls.godot_icall_0_827(method_bind_31, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_axis_velocity");

        /// <summary>
        /// <para>Sets the body's velocity on the given axis. The velocity in the given vector axis will be set as the given vector length. This is useful for jumping behavior.</para>
        /// </summary>
        [GodotMethod("set_axis_velocity")]
        public void SetAxisVelocity(Vector2 axisVelocity)
        {
            NativeCalls.godot_icall_1_57(method_bind_32, Object.GetPtr(this), ref axisVelocity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "apply_central_impulse");

        /// <summary>
        /// <para>Applies a directional impulse without affecting rotation.</para>
        /// </summary>
        [GodotMethod("apply_central_impulse")]
        public void ApplyCentralImpulse(Vector2 impulse)
        {
            NativeCalls.godot_icall_1_57(method_bind_33, Object.GetPtr(this), ref impulse);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "apply_impulse");

        /// <summary>
        /// <para>Applies a positioned impulse to the body. An impulse is time-independent! Applying an impulse every frame would result in a framerate-dependent force. For this reason it should only be used when simulating one-time impacts (use the "_force" functions otherwise). The position uses the rotation of the global coordinate system, but is centered at the object's origin.</para>
        /// </summary>
        [GodotMethod("apply_impulse")]
        public void ApplyImpulse(Vector2 offset, Vector2 impulse)
        {
            NativeCalls.godot_icall_2_731(method_bind_34, Object.GetPtr(this), ref offset, ref impulse);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "apply_torque_impulse");

        /// <summary>
        /// <para>Applies a rotational impulse to the body.</para>
        /// </summary>
        [GodotMethod("apply_torque_impulse")]
        public void ApplyTorqueImpulse(float torque)
        {
            NativeCalls.godot_icall_1_15(method_bind_35, Object.GetPtr(this), torque);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_applied_force");

        [GodotMethod("set_applied_force")]
        [Obsolete("SetAppliedForce is deprecated. Use the AppliedForce property instead.")]
        public void SetAppliedForce(Vector2 force)
        {
            NativeCalls.godot_icall_1_57(method_bind_36, Object.GetPtr(this), ref force);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_applied_force");

        [GodotMethod("get_applied_force")]
        [Obsolete("GetAppliedForce is deprecated. Use the AppliedForce property instead.")]
        public Vector2 GetAppliedForce()
        {
            NativeCalls.godot_icall_0_18(method_bind_37, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_applied_torque");

        [GodotMethod("set_applied_torque")]
        [Obsolete("SetAppliedTorque is deprecated. Use the AppliedTorque property instead.")]
        public void SetAppliedTorque(float torque)
        {
            NativeCalls.godot_icall_1_15(method_bind_38, Object.GetPtr(this), torque);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_applied_torque");

        [GodotMethod("get_applied_torque")]
        [Obsolete("GetAppliedTorque is deprecated. Use the AppliedTorque property instead.")]
        public float GetAppliedTorque()
        {
            return NativeCalls.godot_icall_0_14(method_bind_39, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_central_force");

        /// <summary>
        /// <para>Adds a constant directional force without affecting rotation.</para>
        /// </summary>
        [GodotMethod("add_central_force")]
        public void AddCentralForce(Vector2 force)
        {
            NativeCalls.godot_icall_1_57(method_bind_40, Object.GetPtr(this), ref force);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_force");

        /// <summary>
        /// <para>Adds a positioned force to the body. Both the force and the offset from the body origin are in global coordinates.</para>
        /// </summary>
        [GodotMethod("add_force")]
        public void AddForce(Vector2 offset, Vector2 force)
        {
            NativeCalls.godot_icall_2_731(method_bind_41, Object.GetPtr(this), ref offset, ref force);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_torque");

        /// <summary>
        /// <para>Adds a constant rotational force.</para>
        /// </summary>
        [GodotMethod("add_torque")]
        public void AddTorque(float torque)
        {
            NativeCalls.godot_icall_1_15(method_bind_42, Object.GetPtr(this), torque);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sleeping");

        [GodotMethod("set_sleeping")]
        [Obsolete("SetSleeping is deprecated. Use the Sleeping property instead.")]
        public void SetSleeping(bool sleeping)
        {
            NativeCalls.godot_icall_1_16(method_bind_43, Object.GetPtr(this), sleeping);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_sleeping");

        [GodotMethod("is_sleeping")]
        [Obsolete("IsSleeping is deprecated. Use the Sleeping property instead.")]
        public bool IsSleeping()
        {
            return NativeCalls.godot_icall_0_7(method_bind_44, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_can_sleep");

        [GodotMethod("set_can_sleep")]
        [Obsolete("SetCanSleep is deprecated. Use the CanSleep property instead.")]
        public void SetCanSleep(bool ableToSleep)
        {
            NativeCalls.godot_icall_1_16(method_bind_45, Object.GetPtr(this), ableToSleep);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_able_to_sleep");

        [GodotMethod("is_able_to_sleep")]
        [Obsolete("IsAbleToSleep is deprecated. Use the CanSleep property instead.")]
        public bool IsAbleToSleep()
        {
            return NativeCalls.godot_icall_0_7(method_bind_46, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "test_motion");

        /// <summary>
        /// <para>Returns <c>true</c> if a collision would result from moving in the given vector. <c>margin</c> increases the size of the shapes involved in the collision detection, and <c>result</c> is an object of type <see cref="Godot.Physics2DTestMotionResult"/>, which contains additional information about the collision (should there be one).</para>
        /// </summary>
        [GodotMethod("test_motion")]
        public bool TestMotion(Vector2 motion, bool infiniteInertia = true, float margin = 0.08f, Physics2DTestMotionResult result = null)
        {
            return NativeCalls.godot_icall_4_828(method_bind_47, Object.GetPtr(this), ref motion, infiniteInertia, margin, Object.GetPtr(result));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_colliding_bodies");

        /// <summary>
        /// <para>Returns a list of the bodies colliding with this one. Requires <see cref="Godot.RigidBody2D.ContactMonitor"/> to be set to <c>true</c> and <see cref="Godot.RigidBody2D.ContactsReported"/> to be set high enough to detect all the collisions.</para>
        /// <para>Note: The result of this test is not immediate after moving objects. For performance, list of collisions is updated once per frame and before the physics step. Consider using signals instead.</para>
        /// </summary>
        [GodotMethod("get_colliding_bodies")]
        public Godot.Collections.Array GetCollidingBodies()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_48, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
