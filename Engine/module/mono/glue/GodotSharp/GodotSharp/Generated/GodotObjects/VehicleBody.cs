using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This node implements all the physics logic needed to simulate a car. It is based on the raycast vehicle system commonly found in physics engines. You will need to add a <see cref="Godot.CollisionShape"/> for the main body of your vehicle and add <see cref="Godot.VehicleWheel"/> nodes for the wheels. You should also add a <see cref="Godot.MeshInstance"/> to this node for the 3D model of your car but this model should not include meshes for the wheels. You should control the vehicle by using the <see cref="Godot.VehicleBody.Brake"/>, <see cref="Godot.VehicleBody.EngineForce"/>, and <see cref="Godot.VehicleBody.Steering"/> properties and not change the position or orientation of this node directly.</para>
    /// <para>Note: The origin point of your VehicleBody will determine the center of gravity of your vehicle so it is better to keep this low and move the <see cref="Godot.CollisionShape"/> and <see cref="Godot.MeshInstance"/> upwards.</para>
    /// <para>Note: This class has known issues and isn't designed to provide realistic 3D vehicle physics. If you want advanced vehicle physics, you will probably have to write your own physics integration using another <see cref="Godot.PhysicsBody"/> class.</para>
    /// </summary>
    public partial class VehicleBody : RigidBody
    {
        /// <summary>
        /// <para>Accelerates the vehicle by applying an engine force. The vehicle is only sped up if the wheels that have <see cref="Godot.VehicleWheel.UseAsTraction"/> set to <c>true</c> and are in contact with a surface. The <see cref="Godot.RigidBody.Mass"/> of the vehicle has an effect on the acceleration of the vehicle. For a vehicle with a mass set to 1000, try a value in the 25 - 50 range for acceleration.</para>
        /// <para>Note: The simulation does not take the effect of gears into account, you will need to add logic for this if you wish to simulate gears.</para>
        /// <para>A negative value will result in the vehicle reversing.</para>
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
        /// <para>Slows down the vehicle by applying a braking force. The vehicle is only slowed down if the wheels are in contact with a surface. The force you need to apply to adequately slow down your vehicle depends on the <see cref="Godot.RigidBody.Mass"/> of the vehicle. For a vehicle with a mass set to 1000, try a value in the 25 - 30 range for hard braking.</para>
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
        /// <para>The steering angle for the vehicle. Setting this to a non-zero value will result in the vehicle turning when it's moving. Wheels that have <see cref="Godot.VehicleWheel.UseAsSteering"/> set to <c>true</c> will automatically be rotated.</para>
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

        private const string nativeName = "VehicleBody";

        public VehicleBody() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VehicleBody_Ctor(this);
        }

        internal VehicleBody(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_engine_force");

        [GodotMethod("set_engine_force")]
        [Obsolete("SetEngineForce is deprecated. Use the EngineForce property instead.")]
        public void SetEngineForce(float engineForce)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), engineForce);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_engine_force");

        [GodotMethod("get_engine_force")]
        [Obsolete("GetEngineForce is deprecated. Use the EngineForce property instead.")]
        public float GetEngineForce()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_brake");

        [GodotMethod("set_brake")]
        [Obsolete("SetBrake is deprecated. Use the Brake property instead.")]
        public void SetBrake(float brake)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), brake);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_brake");

        [GodotMethod("get_brake")]
        [Obsolete("GetBrake is deprecated. Use the Brake property instead.")]
        public float GetBrake()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_steering");

        [GodotMethod("set_steering")]
        [Obsolete("SetSteering is deprecated. Use the Steering property instead.")]
        public void SetSteering(float steering)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), steering);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_steering");

        [GodotMethod("get_steering")]
        [Obsolete("GetSteering is deprecated. Use the Steering property instead.")]
        public float GetSteering()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
