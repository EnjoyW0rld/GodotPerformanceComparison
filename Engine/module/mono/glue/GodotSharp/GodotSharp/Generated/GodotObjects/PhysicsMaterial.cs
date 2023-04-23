using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Provides a means of modifying the collision properties of a <see cref="Godot.PhysicsBody"/>.</para>
    /// </summary>
    public partial class PhysicsMaterial : Resource
    {
        /// <summary>
        /// <para>The body's friction. Values range from <c>0</c> (frictionless) to <c>1</c> (maximum friction).</para>
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
        /// <para>If <c>true</c>, the physics engine will use the friction of the object marked as "rough" when two objects collide. If <c>false</c>, the physics engine will use the lowest friction of all colliding objects instead. If <c>true</c> for both colliding objects, the physics engine will use the highest friction.</para>
        /// </summary>
        public bool Rough
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsRough();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRough(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The body's bounciness. Values range from <c>0</c> (no bounce) to <c>1</c> (full bounciness).</para>
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
        /// <para>If <c>true</c>, subtracts the bounciness from the colliding object's bounciness instead of adding it.</para>
        /// </summary>
        public bool Absorbent
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsAbsorbent();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAbsorbent(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "PhysicsMaterial";

        public PhysicsMaterial() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PhysicsMaterial_Ctor(this);
        }

        internal PhysicsMaterial(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_friction");

        [GodotMethod("set_friction")]
        [Obsolete("SetFriction is deprecated. Use the Friction property instead.")]
        public void SetFriction(float friction)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), friction);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_friction");

        [GodotMethod("get_friction")]
        [Obsolete("GetFriction is deprecated. Use the Friction property instead.")]
        public float GetFriction()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rough");

        [GodotMethod("set_rough")]
        [Obsolete("SetRough is deprecated. Use the Rough property instead.")]
        public void SetRough(bool rough)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), rough);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_rough");

        [GodotMethod("is_rough")]
        [Obsolete("IsRough is deprecated. Use the Rough property instead.")]
        public bool IsRough()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bounce");

        [GodotMethod("set_bounce")]
        [Obsolete("SetBounce is deprecated. Use the Bounce property instead.")]
        public void SetBounce(float bounce)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), bounce);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bounce");

        [GodotMethod("get_bounce")]
        [Obsolete("GetBounce is deprecated. Use the Bounce property instead.")]
        public float GetBounce()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_absorbent");

        [GodotMethod("set_absorbent")]
        [Obsolete("SetAbsorbent is deprecated. Use the Absorbent property instead.")]
        public void SetAbsorbent(bool absorbent)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), absorbent);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_absorbent");

        [GodotMethod("is_absorbent")]
        [Obsolete("IsAbsorbent is deprecated. Use the Absorbent property instead.")]
        public bool IsAbsorbent()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
