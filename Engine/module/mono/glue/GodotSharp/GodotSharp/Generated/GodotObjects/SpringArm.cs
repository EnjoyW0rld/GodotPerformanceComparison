using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The SpringArm node is a node that casts a ray (or collision shape) along its z axis and moves all its direct children to the collision point, minus a margin.</para>
    /// <para>The most common use case for this is to make a 3rd person camera that reacts to collisions in the environment.</para>
    /// <para>The SpringArm will either cast a ray, or if a shape is given, it will cast the shape in the direction of its z axis.</para>
    /// <para>If you use the SpringArm as a camera controller for your player, you might need to exclude the player's collider from the SpringArm's collision check.</para>
    /// </summary>
    public partial class SpringArm : Spatial
    {
        /// <summary>
        /// <para>The layers against which the collision check shall be done. See <a href="$DOCS_URL/tutorials/physics/physics_introduction.html#collision-layers-and-masks">Collision layers and masks</a> in the documentation for more information.</para>
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
        /// <para>The <see cref="Godot.Shape"/> to use for the SpringArm.</para>
        /// <para>When the shape is set, the SpringArm will cast the <see cref="Godot.Shape"/> on its z axis instead of performing a ray cast.</para>
        /// </summary>
        public Shape Shape
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShape();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShape(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum extent of the SpringArm. This is used as a length for both the ray and the shape cast used internally to calculate the desired position of the SpringArm's child nodes.</para>
        /// <para>To know more about how to perform a shape cast or a ray cast, please consult the <see cref="Godot.PhysicsDirectSpaceState"/> documentation.</para>
        /// </summary>
        public float SpringLength
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLength();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLength(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When the collision check is made, a candidate length for the SpringArm is given.</para>
        /// <para>The margin is then subtracted to this length and the translation is applied to the child objects of the SpringArm.</para>
        /// <para>This margin is useful for when the SpringArm has a <see cref="Godot.Camera"/> as a child node: without the margin, the <see cref="Godot.Camera"/> would be placed on the exact point of collision, while with the margin the <see cref="Godot.Camera"/> would be placed close to the point of collision.</para>
        /// </summary>
        public float Margin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMargin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMargin(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "SpringArm";

        public SpringArm() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_SpringArm_Ctor(this);
        }

        internal SpringArm(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_hit_length");

        /// <summary>
        /// <para>Returns the spring arm's current length.</para>
        /// </summary>
        [GodotMethod("get_hit_length")]
        public float GetHitLength()
        {
            return NativeCalls.godot_icall_0_14(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_length");

        [GodotMethod("set_length")]
        [Obsolete("SetLength is deprecated. Use the SpringLength property instead.")]
        public void SetLength(float length)
        {
            NativeCalls.godot_icall_1_15(method_bind_1, Object.GetPtr(this), length);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_length");

        [GodotMethod("get_length")]
        [Obsolete("GetLength is deprecated. Use the SpringLength property instead.")]
        public float GetLength()
        {
            return NativeCalls.godot_icall_0_14(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shape");

        [GodotMethod("set_shape")]
        [Obsolete("SetShape is deprecated. Use the Shape property instead.")]
        public void SetShape(Shape shape)
        {
            NativeCalls.godot_icall_1_24(method_bind_3, Object.GetPtr(this), Object.GetPtr(shape));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shape");

        [GodotMethod("get_shape")]
        [Obsolete("GetShape is deprecated. Use the Shape property instead.")]
        public Shape GetShape()
        {
            return NativeCalls.godot_icall_0_303(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_excluded_object");

        /// <summary>
        /// <para>Adds the <see cref="Godot.PhysicsBody"/> object with the given <see cref="Godot.RID"/> to the list of <see cref="Godot.PhysicsBody"/> objects excluded from the collision check.</para>
        /// </summary>
        [GodotMethod("add_excluded_object")]
        public void AddExcludedObject(RID RID)
        {
            NativeCalls.godot_icall_1_285(method_bind_5, Object.GetPtr(this), RID.GetPtr(RID));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_excluded_object");

        /// <summary>
        /// <para>Removes the given <see cref="Godot.RID"/> from the list of <see cref="Godot.PhysicsBody"/> objects excluded from the collision check.</para>
        /// </summary>
        [GodotMethod("remove_excluded_object")]
        public bool RemoveExcludedObject(RID RID)
        {
            return NativeCalls.godot_icall_1_629(method_bind_6, Object.GetPtr(this), RID.GetPtr(RID));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_excluded_objects");

        /// <summary>
        /// <para>Clears the list of <see cref="Godot.PhysicsBody"/> objects excluded from the collision check.</para>
        /// </summary>
        [GodotMethod("clear_excluded_objects")]
        public void ClearExcludedObjects()
        {
            NativeCalls.godot_icall_0_3(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_mask");

        [GodotMethod("set_collision_mask")]
        [Obsolete("SetCollisionMask is deprecated. Use the CollisionMask property instead.")]
        public void SetCollisionMask(uint mask)
        {
            NativeCalls.godot_icall_1_187(method_bind_8, Object.GetPtr(this), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_mask");

        [GodotMethod("get_collision_mask")]
        [Obsolete("GetCollisionMask is deprecated. Use the CollisionMask property instead.")]
        public uint GetCollisionMask()
        {
            return NativeCalls.godot_icall_0_188(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_margin");

        [GodotMethod("set_margin")]
        [Obsolete("SetMargin is deprecated. Use the Margin property instead.")]
        public void SetMargin(float margin)
        {
            NativeCalls.godot_icall_1_15(method_bind_10, Object.GetPtr(this), margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_margin");

        [GodotMethod("get_margin")]
        [Obsolete("GetMargin is deprecated. Use the Margin property instead.")]
        public float GetMargin()
        {
            return NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
