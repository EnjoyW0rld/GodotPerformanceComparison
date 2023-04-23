using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Static body for 3D physics. A static body is a simple body that is not intended to move. In contrast to <see cref="Godot.RigidBody"/>, they don't consume any CPU resources as long as they don't move.</para>
    /// <para>Additionally, a constant linear or angular velocity can be set for the static body, so even if it doesn't move, it affects other bodies as if it was moving (this is useful for simulating conveyor belts or conveyor wheels).</para>
    /// </summary>
    public partial class StaticBody : PhysicsBody
    {
        /// <summary>
        /// <para>The body's friction, from 0 (frictionless) to 1 (full friction).</para>
        /// <para>Deprecated, use <see cref="Godot.PhysicsMaterial.Friction"/> instead via <see cref="Godot.StaticBody.PhysicsMaterialOverride"/>.</para>
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
        /// <para>Deprecated, use <see cref="Godot.PhysicsMaterial.Bounce"/> instead via <see cref="Godot.StaticBody.PhysicsMaterialOverride"/>.</para>
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
        /// <para>The body's constant linear velocity. This does not move the body, but affects other bodies that touch it, as if it was in a state of movement.</para>
        /// </summary>
        public Vector3 ConstantLinearVelocity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetConstantLinearVelocity();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetConstantLinearVelocity(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The body's constant angular velocity. This does not rotate the body, but affects other bodies that touch it, as if it was in a state of rotation.</para>
        /// </summary>
        public Vector3 ConstantAngularVelocity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetConstantAngularVelocity();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetConstantAngularVelocity(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "StaticBody";

        public StaticBody() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_StaticBody_Ctor(this);
        }

        internal StaticBody(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_constant_linear_velocity");

        [GodotMethod("set_constant_linear_velocity")]
        [Obsolete("SetConstantLinearVelocity is deprecated. Use the ConstantLinearVelocity property instead.")]
        public void SetConstantLinearVelocity(Vector3 vel)
        {
            NativeCalls.godot_icall_1_148(method_bind_0, Object.GetPtr(this), ref vel);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_constant_angular_velocity");

        [GodotMethod("set_constant_angular_velocity")]
        [Obsolete("SetConstantAngularVelocity is deprecated. Use the ConstantAngularVelocity property instead.")]
        public void SetConstantAngularVelocity(Vector3 vel)
        {
            NativeCalls.godot_icall_1_148(method_bind_1, Object.GetPtr(this), ref vel);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_constant_linear_velocity");

        [GodotMethod("get_constant_linear_velocity")]
        [Obsolete("GetConstantLinearVelocity is deprecated. Use the ConstantLinearVelocity property instead.")]
        public Vector3 GetConstantLinearVelocity()
        {
            NativeCalls.godot_icall_0_8(method_bind_2, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_constant_angular_velocity");

        [GodotMethod("get_constant_angular_velocity")]
        [Obsolete("GetConstantAngularVelocity is deprecated. Use the ConstantAngularVelocity property instead.")]
        public Vector3 GetConstantAngularVelocity()
        {
            NativeCalls.godot_icall_0_8(method_bind_3, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_friction");

        [GodotMethod("set_friction")]
        [Obsolete("SetFriction is deprecated. Use the Friction property instead.")]
        public void SetFriction(float friction)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), friction);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_friction");

        [GodotMethod("get_friction")]
        [Obsolete("GetFriction is deprecated. Use the Friction property instead.")]
        public float GetFriction()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bounce");

        [GodotMethod("set_bounce")]
        [Obsolete("SetBounce is deprecated. Use the Bounce property instead.")]
        public void SetBounce(float bounce)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), bounce);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bounce");

        [GodotMethod("get_bounce")]
        [Obsolete("GetBounce is deprecated. Use the Bounce property instead.")]
        public float GetBounce()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_physics_material_override");

        [GodotMethod("set_physics_material_override")]
        [Obsolete("SetPhysicsMaterialOverride is deprecated. Use the PhysicsMaterialOverride property instead.")]
        public void SetPhysicsMaterialOverride(PhysicsMaterial physicsMaterialOverride)
        {
            NativeCalls.godot_icall_1_24(method_bind_8, Object.GetPtr(this), Object.GetPtr(physicsMaterialOverride));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_physics_material_override");

        [GodotMethod("get_physics_material_override")]
        [Obsolete("GetPhysicsMaterialOverride is deprecated. Use the PhysicsMaterialOverride property instead.")]
        public PhysicsMaterial GetPhysicsMaterialOverride()
        {
            return NativeCalls.godot_icall_0_477(method_bind_9, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
