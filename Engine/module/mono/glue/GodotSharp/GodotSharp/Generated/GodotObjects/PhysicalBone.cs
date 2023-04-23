using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class PhysicalBone : PhysicsBody
    {
        public enum JointTypeEnum
        {
            None = 0,
            Pin = 1,
            Cone = 2,
            Hinge = 3,
            Slider = 4,
            Type6dof = 5
        }

        public PhysicalBone.JointTypeEnum JointType
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetJointType();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetJointType(value);
            }
#pragma warning restore CS0618
        }

        public Transform JointOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetJointOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetJointOffset(value);
            }
#pragma warning restore CS0618
        }

        public Transform BodyOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBodyOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBodyOffset(value);
            }
#pragma warning restore CS0618
        }

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

        private const string nativeName = "PhysicalBone";

        public PhysicalBone() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PhysicalBone_Ctor(this);
        }

        internal PhysicalBone(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "apply_central_impulse");

        [GodotMethod("apply_central_impulse")]
        public void ApplyCentralImpulse(Vector3 impulse)
        {
            NativeCalls.godot_icall_1_148(method_bind_0, Object.GetPtr(this), ref impulse);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "apply_impulse");

        [GodotMethod("apply_impulse")]
        public void ApplyImpulse(Vector3 position, Vector3 impulse)
        {
            NativeCalls.godot_icall_2_729(method_bind_1, Object.GetPtr(this), ref position, ref impulse);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_joint_type");

        [GodotMethod("set_joint_type")]
        [Obsolete("SetJointType is deprecated. Use the JointType property instead.")]
        public void SetJointType(PhysicalBone.JointTypeEnum jointType)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)jointType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_joint_type");

        [GodotMethod("get_joint_type")]
        [Obsolete("GetJointType is deprecated. Use the JointType property instead.")]
        public PhysicalBone.JointTypeEnum GetJointType()
        {
            return (PhysicalBone.JointTypeEnum)NativeCalls.godot_icall_0_730(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_joint_offset");

        [GodotMethod("set_joint_offset")]
        [Obsolete("SetJointOffset is deprecated. Use the JointOffset property instead.")]
        public void SetJointOffset(Transform offset)
        {
            NativeCalls.godot_icall_1_202(method_bind_4, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_joint_offset");

        [GodotMethod("get_joint_offset")]
        [Obsolete("GetJointOffset is deprecated. Use the JointOffset property instead.")]
        public Transform GetJointOffset()
        {
            NativeCalls.godot_icall_0_22(method_bind_5, Object.GetPtr(this), out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_body_offset");

        [GodotMethod("set_body_offset")]
        [Obsolete("SetBodyOffset is deprecated. Use the BodyOffset property instead.")]
        public void SetBodyOffset(Transform offset)
        {
            NativeCalls.godot_icall_1_202(method_bind_6, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_body_offset");

        [GodotMethod("get_body_offset")]
        [Obsolete("GetBodyOffset is deprecated. Use the BodyOffset property instead.")]
        public Transform GetBodyOffset()
        {
            NativeCalls.godot_icall_0_22(method_bind_7, Object.GetPtr(this), out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_static_body");

        [GodotMethod("is_static_body")]
        public bool IsStaticBody()
        {
            return NativeCalls.godot_icall_0_7(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_simulate_physics");

        [GodotMethod("get_simulate_physics")]
        public bool GetSimulatePhysics()
        {
            return NativeCalls.godot_icall_0_7(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_simulating_physics");

        [GodotMethod("is_simulating_physics")]
        public bool IsSimulatingPhysics()
        {
            return NativeCalls.godot_icall_0_7(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bone_id");

        [GodotMethod("get_bone_id")]
        public int GetBoneId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mass");

        [GodotMethod("set_mass")]
        [Obsolete("SetMass is deprecated. Use the Mass property instead.")]
        public void SetMass(float mass)
        {
            NativeCalls.godot_icall_1_15(method_bind_12, Object.GetPtr(this), mass);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mass");

        [GodotMethod("get_mass")]
        [Obsolete("GetMass is deprecated. Use the Mass property instead.")]
        public float GetMass()
        {
            return NativeCalls.godot_icall_0_14(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_weight");

        [GodotMethod("set_weight")]
        [Obsolete("SetWeight is deprecated. Use the Weight property instead.")]
        public void SetWeight(float weight)
        {
            NativeCalls.godot_icall_1_15(method_bind_14, Object.GetPtr(this), weight);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_weight");

        [GodotMethod("get_weight")]
        [Obsolete("GetWeight is deprecated. Use the Weight property instead.")]
        public float GetWeight()
        {
            return NativeCalls.godot_icall_0_14(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_friction");

        [GodotMethod("set_friction")]
        [Obsolete("SetFriction is deprecated. Use the Friction property instead.")]
        public void SetFriction(float friction)
        {
            NativeCalls.godot_icall_1_15(method_bind_16, Object.GetPtr(this), friction);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_friction");

        [GodotMethod("get_friction")]
        [Obsolete("GetFriction is deprecated. Use the Friction property instead.")]
        public float GetFriction()
        {
            return NativeCalls.godot_icall_0_14(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bounce");

        [GodotMethod("set_bounce")]
        [Obsolete("SetBounce is deprecated. Use the Bounce property instead.")]
        public void SetBounce(float bounce)
        {
            NativeCalls.godot_icall_1_15(method_bind_18, Object.GetPtr(this), bounce);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bounce");

        [GodotMethod("get_bounce")]
        [Obsolete("GetBounce is deprecated. Use the Bounce property instead.")]
        public float GetBounce()
        {
            return NativeCalls.godot_icall_0_14(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_gravity_scale");

        [GodotMethod("set_gravity_scale")]
        [Obsolete("SetGravityScale is deprecated. Use the GravityScale property instead.")]
        public void SetGravityScale(float gravityScale)
        {
            NativeCalls.godot_icall_1_15(method_bind_20, Object.GetPtr(this), gravityScale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_gravity_scale");

        [GodotMethod("get_gravity_scale")]
        [Obsolete("GetGravityScale is deprecated. Use the GravityScale property instead.")]
        public float GetGravityScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_21, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
