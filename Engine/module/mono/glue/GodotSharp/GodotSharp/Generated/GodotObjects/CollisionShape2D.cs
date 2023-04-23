using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Editor facility for creating and editing collision shapes in 2D space. Set the <see cref="Godot.CollisionShape2D.Shape"/> property to configure the shape. IMPORTANT: this is an Editor-only helper to create shapes, use <see cref="Godot.CollisionObject2D.ShapeOwnerGetShape"/> to get the actual shape.</para>
    /// <para>You can use this node to represent all sorts of collision shapes, for example, add this to an <see cref="Godot.Area2D"/> to give it a detection shape, or add it to a <see cref="Godot.PhysicsBody2D"/> to create a solid object.</para>
    /// </summary>
    public partial class CollisionShape2D : Node2D
    {
        /// <summary>
        /// <para>The actual shape owned by this collision shape.</para>
        /// </summary>
        public Shape2D Shape
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
        /// <para>A disabled collision shape has no effect in the world. This property should be changed with <see cref="Godot.Object.SetDeferred"/>.</para>
        /// </summary>
        public bool Disabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDisabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDisabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets whether this collision shape should only detect collision on one side (top or bottom).</para>
        /// <para>Note: This property has no effect if this <see cref="Godot.CollisionShape2D"/> is a child of an <see cref="Godot.Area2D"/> node.</para>
        /// </summary>
        public bool OneWayCollision
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsOneWayCollisionEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOneWayCollision(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The margin used for one-way collision (in pixels). Higher values will make the shape thicker, and work better for colliders that enter the shape at a high velocity.</para>
        /// </summary>
        public float OneWayCollisionMargin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOneWayCollisionMargin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOneWayCollisionMargin(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "CollisionShape2D";

        public CollisionShape2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CollisionShape2D_Ctor(this);
        }

        internal CollisionShape2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shape");

        [GodotMethod("set_shape")]
        [Obsolete("SetShape is deprecated. Use the Shape property instead.")]
        public void SetShape(Shape2D shape)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(shape));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shape");

        [GodotMethod("get_shape")]
        [Obsolete("GetShape is deprecated. Use the Shape property instead.")]
        public Shape2D GetShape()
        {
            return NativeCalls.godot_icall_0_304(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_disabled");

        [GodotMethod("set_disabled")]
        [Obsolete("SetDisabled is deprecated. Use the Disabled property instead.")]
        public void SetDisabled(bool disabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), disabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_disabled");

        [GodotMethod("is_disabled")]
        [Obsolete("IsDisabled is deprecated. Use the Disabled property instead.")]
        public bool IsDisabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_one_way_collision");

        [GodotMethod("set_one_way_collision")]
        [Obsolete("SetOneWayCollision is deprecated. Use the OneWayCollision property instead.")]
        public void SetOneWayCollision(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_one_way_collision_enabled");

        [GodotMethod("is_one_way_collision_enabled")]
        [Obsolete("IsOneWayCollisionEnabled is deprecated. Use the OneWayCollision property instead.")]
        public bool IsOneWayCollisionEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_one_way_collision_margin");

        [GodotMethod("set_one_way_collision_margin")]
        [Obsolete("SetOneWayCollisionMargin is deprecated. Use the OneWayCollisionMargin property instead.")]
        public void SetOneWayCollisionMargin(float margin)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_one_way_collision_margin");

        [GodotMethod("get_one_way_collision_margin")]
        [Obsolete("GetOneWayCollisionMargin is deprecated. Use the OneWayCollisionMargin property instead.")]
        public float GetOneWayCollisionMargin()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
