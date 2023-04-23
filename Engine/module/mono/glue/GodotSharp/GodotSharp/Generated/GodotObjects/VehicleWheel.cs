using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This node needs to be used as a child node of <see cref="Godot.VehicleBody"/> and simulates the behavior of one of its wheels. This node also acts as a collider to detect if the wheel is touching a surface.</para>
    /// <para>Note: This class has known issues and isn't designed to provide realistic 3D vehicle physics. If you want advanced vehicle physics, you will probably have to write your own physics integration using another <see cref="Godot.PhysicsBody"/> class.</para>
    /// </summary>
    public partial class VehicleWheel : Spatial
    {
        /// <summary>
        /// <para>Accelerates the wheel by applying an engine force. The wheel is only sped up if it is in contact with a surface. The <see cref="Godot.RigidBody.Mass"/> of the vehicle has an effect on the acceleration of the vehicle. For a vehicle with a mass set to 1000, try a value in the 25 - 50 range for acceleration.</para>
        /// <para>Note: The simulation does not take the effect of gears into account, you will need to add logic for this if you wish to simulate gears.</para>
        /// <para>A negative value will result in the wheel reversing.</para>
        /// </summary>
        public float EngineForce
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEngineForce();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEngineForce(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Slows down the wheel by applying a braking force. The wheel is only slowed down if it is in contact with a surface. The force you need to apply to adequately slow down your vehicle depends on the <see cref="Godot.RigidBody.Mass"/> of the vehicle. For a vehicle with a mass set to 1000, try a value in the 25 - 30 range for hard braking.</para>
        /// </summary>
        public float Brake
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBrake();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBrake(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The steering angle for the wheel. Setting this to a non-zero value will result in the vehicle turning when it's moving.</para>
        /// </summary>
        public float Steering
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSteering();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSteering(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, this wheel transfers engine force to the ground to propel the vehicle forward. This value is used in conjunction with <see cref="Godot.VehicleBody.EngineForce"/> and ignored if you are using the per-wheel <see cref="Godot.VehicleWheel.EngineForce"/> value instead.</para>
        /// </summary>
        public bool UseAsTraction
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUsedAsTraction();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseAsTraction(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, this wheel will be turned when the car steers. This value is used in conjunction with <see cref="Godot.VehicleBody.Steering"/> and ignored if you are using the per-wheel <see cref="Godot.VehicleWheel.Steering"/> value instead.</para>
        /// </summary>
        public bool UseAsSteering
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUsedAsSteering();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseAsSteering(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>This value affects the roll of your vehicle. If set to 1.0 for all wheels, your vehicle will be prone to rolling over, while a value of 0.0 will resist body roll.</para>
        /// </summary>
        public float WheelRollInfluence
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRollInfluence();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRollInfluence(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The radius of the wheel in meters.</para>
        /// </summary>
        public float WheelRadius
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRadius();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRadius(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>This is the distance in meters the wheel is lowered from its origin point. Don't set this to 0.0 and move the wheel into position, instead move the origin point of your wheel (the gizmo in Godot) to the position the wheel will take when bottoming out, then use the rest length to move the wheel down to the position it should be in when the car is in rest.</para>
        /// </summary>
        public float WheelRestLength
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSuspensionRestLength();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSuspensionRestLength(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>This determines how much grip this wheel has. It is combined with the friction setting of the surface the wheel is in contact with. 0.0 means no grip, 1.0 is normal grip. For a drift car setup, try setting the grip of the rear wheels slightly lower than the front wheels, or use a lower value to simulate tire wear.</para>
        /// <para>It's best to set this to 1.0 when starting out.</para>
        /// </summary>
        public float WheelFrictionSlip
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrictionSlip();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrictionSlip(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>This is the distance the suspension can travel. As Godot units are equivalent to meters, keep this setting relatively low. Try a value between 0.1 and 0.3 depending on the type of car.</para>
        /// </summary>
        public float SuspensionTravel
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSuspensionTravel();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSuspensionTravel(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>This value defines the stiffness of the suspension. Use a value lower than 50 for an off-road car, a value between 50 and 100 for a race car and try something around 200 for something like a Formula 1 car.</para>
        /// </summary>
        public float SuspensionStiffness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSuspensionStiffness();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSuspensionStiffness(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum force the spring can resist. This value should be higher than a quarter of the <see cref="Godot.RigidBody.Mass"/> of the <see cref="Godot.VehicleBody"/> or the spring will not carry the weight of the vehicle. Good results are often obtained by a value that is about 3× to 4× this number.</para>
        /// </summary>
        public float SuspensionMaxForce
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSuspensionMaxForce();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSuspensionMaxForce(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The damping applied to the spring when the spring is being compressed. This value should be between 0.0 (no damping) and 1.0. A value of 0.0 means the car will keep bouncing as the spring keeps its energy. A good value for this is around 0.3 for a normal car, 0.5 for a race car.</para>
        /// </summary>
        public float DampingCompression
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDampingCompression();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDampingCompression(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The damping applied to the spring when relaxing. This value should be between 0.0 (no damping) and 1.0. This value should always be slightly higher than the <see cref="Godot.VehicleWheel.DampingCompression"/> property. For a <see cref="Godot.VehicleWheel.DampingCompression"/> value of 0.3, try a relaxation value of 0.5.</para>
        /// </summary>
        public float DampingRelaxation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDampingRelaxation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDampingRelaxation(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VehicleWheel";

        public VehicleWheel() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VehicleWheel_Ctor(this);
        }

        internal VehicleWheel(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_radius");

        [GodotMethod("set_radius")]
        [Obsolete("SetRadius is deprecated. Use the WheelRadius property instead.")]
        public void SetRadius(float length)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), length);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_radius");

        [GodotMethod("get_radius")]
        [Obsolete("GetRadius is deprecated. Use the WheelRadius property instead.")]
        public float GetRadius()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_suspension_rest_length");

        [GodotMethod("set_suspension_rest_length")]
        [Obsolete("SetSuspensionRestLength is deprecated. Use the WheelRestLength property instead.")]
        public void SetSuspensionRestLength(float length)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), length);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_suspension_rest_length");

        [GodotMethod("get_suspension_rest_length")]
        [Obsolete("GetSuspensionRestLength is deprecated. Use the WheelRestLength property instead.")]
        public float GetSuspensionRestLength()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_suspension_travel");

        [GodotMethod("set_suspension_travel")]
        [Obsolete("SetSuspensionTravel is deprecated. Use the SuspensionTravel property instead.")]
        public void SetSuspensionTravel(float length)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), length);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_suspension_travel");

        [GodotMethod("get_suspension_travel")]
        [Obsolete("GetSuspensionTravel is deprecated. Use the SuspensionTravel property instead.")]
        public float GetSuspensionTravel()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_suspension_stiffness");

        [GodotMethod("set_suspension_stiffness")]
        [Obsolete("SetSuspensionStiffness is deprecated. Use the SuspensionStiffness property instead.")]
        public void SetSuspensionStiffness(float length)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), length);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_suspension_stiffness");

        [GodotMethod("get_suspension_stiffness")]
        [Obsolete("GetSuspensionStiffness is deprecated. Use the SuspensionStiffness property instead.")]
        public float GetSuspensionStiffness()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_suspension_max_force");

        [GodotMethod("set_suspension_max_force")]
        [Obsolete("SetSuspensionMaxForce is deprecated. Use the SuspensionMaxForce property instead.")]
        public void SetSuspensionMaxForce(float length)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), length);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_suspension_max_force");

        [GodotMethod("get_suspension_max_force")]
        [Obsolete("GetSuspensionMaxForce is deprecated. Use the SuspensionMaxForce property instead.")]
        public float GetSuspensionMaxForce()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_damping_compression");

        [GodotMethod("set_damping_compression")]
        [Obsolete("SetDampingCompression is deprecated. Use the DampingCompression property instead.")]
        public void SetDampingCompression(float length)
        {
            NativeCalls.godot_icall_1_15(method_bind_10, Object.GetPtr(this), length);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_damping_compression");

        [GodotMethod("get_damping_compression")]
        [Obsolete("GetDampingCompression is deprecated. Use the DampingCompression property instead.")]
        public float GetDampingCompression()
        {
            return NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_damping_relaxation");

        [GodotMethod("set_damping_relaxation")]
        [Obsolete("SetDampingRelaxation is deprecated. Use the DampingRelaxation property instead.")]
        public void SetDampingRelaxation(float length)
        {
            NativeCalls.godot_icall_1_15(method_bind_12, Object.GetPtr(this), length);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_damping_relaxation");

        [GodotMethod("get_damping_relaxation")]
        [Obsolete("GetDampingRelaxation is deprecated. Use the DampingRelaxation property instead.")]
        public float GetDampingRelaxation()
        {
            return NativeCalls.godot_icall_0_14(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_as_traction");

        [GodotMethod("set_use_as_traction")]
        [Obsolete("SetUseAsTraction is deprecated. Use the UseAsTraction property instead.")]
        public void SetUseAsTraction(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_14, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_used_as_traction");

        [GodotMethod("is_used_as_traction")]
        [Obsolete("IsUsedAsTraction is deprecated. Use the UseAsTraction property instead.")]
        public bool IsUsedAsTraction()
        {
            return NativeCalls.godot_icall_0_7(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_as_steering");

        [GodotMethod("set_use_as_steering")]
        [Obsolete("SetUseAsSteering is deprecated. Use the UseAsSteering property instead.")]
        public void SetUseAsSteering(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_16, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_used_as_steering");

        [GodotMethod("is_used_as_steering")]
        [Obsolete("IsUsedAsSteering is deprecated. Use the UseAsSteering property instead.")]
        public bool IsUsedAsSteering()
        {
            return NativeCalls.godot_icall_0_7(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_friction_slip");

        [GodotMethod("set_friction_slip")]
        [Obsolete("SetFrictionSlip is deprecated. Use the WheelFrictionSlip property instead.")]
        public void SetFrictionSlip(float length)
        {
            NativeCalls.godot_icall_1_15(method_bind_18, Object.GetPtr(this), length);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_friction_slip");

        [GodotMethod("get_friction_slip")]
        [Obsolete("GetFrictionSlip is deprecated. Use the WheelFrictionSlip property instead.")]
        public float GetFrictionSlip()
        {
            return NativeCalls.godot_icall_0_14(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_in_contact");

        /// <summary>
        /// <para>Returns <c>true</c> if this wheel is in contact with a surface.</para>
        /// </summary>
        [GodotMethod("is_in_contact")]
        public bool IsInContact()
        {
            return NativeCalls.godot_icall_0_7(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_contact_body");

        /// <summary>
        /// <para>Returns the contacting body node if valid in the tree, as <see cref="Godot.Spatial"/>. At the moment, <see cref="Godot.GridMap"/> is not supported so the node will be always of type <see cref="Godot.PhysicsBody"/>.</para>
        /// <para>Returns <c>null</c> if the wheel is not in contact with a surface, or the contact body is not a <see cref="Godot.PhysicsBody"/>.</para>
        /// </summary>
        [GodotMethod("get_contact_body")]
        public Spatial GetContactBody()
        {
            return NativeCalls.godot_icall_0_412(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_roll_influence");

        [GodotMethod("set_roll_influence")]
        [Obsolete("SetRollInfluence is deprecated. Use the WheelRollInfluence property instead.")]
        public void SetRollInfluence(float rollInfluence)
        {
            NativeCalls.godot_icall_1_15(method_bind_22, Object.GetPtr(this), rollInfluence);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_roll_influence");

        [GodotMethod("get_roll_influence")]
        [Obsolete("GetRollInfluence is deprecated. Use the WheelRollInfluence property instead.")]
        public float GetRollInfluence()
        {
            return NativeCalls.godot_icall_0_14(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_skidinfo");

        /// <summary>
        /// <para>Returns a value between 0.0 and 1.0 that indicates whether this wheel is skidding. 0.0 is skidding (the wheel has lost grip, e.g. icy terrain), 1.0 means not skidding (the wheel has full grip, e.g. dry asphalt road).</para>
        /// </summary>
        [GodotMethod("get_skidinfo")]
        public float GetSkidinfo()
        {
            return NativeCalls.godot_icall_0_14(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rpm");

        /// <summary>
        /// <para>Returns the rotational speed of the wheel in revolutions per minute.</para>
        /// </summary>
        [GodotMethod("get_rpm")]
        public float GetRpm()
        {
            return NativeCalls.godot_icall_0_14(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_engine_force");

        [GodotMethod("set_engine_force")]
        [Obsolete("SetEngineForce is deprecated. Use the EngineForce property instead.")]
        public void SetEngineForce(float engineForce)
        {
            NativeCalls.godot_icall_1_15(method_bind_26, Object.GetPtr(this), engineForce);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_engine_force");

        [GodotMethod("get_engine_force")]
        [Obsolete("GetEngineForce is deprecated. Use the EngineForce property instead.")]
        public float GetEngineForce()
        {
            return NativeCalls.godot_icall_0_14(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_brake");

        [GodotMethod("set_brake")]
        [Obsolete("SetBrake is deprecated. Use the Brake property instead.")]
        public void SetBrake(float brake)
        {
            NativeCalls.godot_icall_1_15(method_bind_28, Object.GetPtr(this), brake);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_brake");

        [GodotMethod("get_brake")]
        [Obsolete("GetBrake is deprecated. Use the Brake property instead.")]
        public float GetBrake()
        {
            return NativeCalls.godot_icall_0_14(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_steering");

        [GodotMethod("set_steering")]
        [Obsolete("SetSteering is deprecated. Use the Steering property instead.")]
        public void SetSteering(float steering)
        {
            NativeCalls.godot_icall_1_15(method_bind_30, Object.GetPtr(this), steering);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_steering");

        [GodotMethod("get_steering")]
        [Obsolete("GetSteering is deprecated. Use the Steering property instead.")]
        public float GetSteering()
        {
            return NativeCalls.godot_icall_0_14(method_bind_31, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
