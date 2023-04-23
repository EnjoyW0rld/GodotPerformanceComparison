using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This class contains the shape and other parameters for 2D intersection/collision queries.</para>
    /// </summary>
    public partial class Physics2DShapeQueryParameters : Reference
    {
        /// <summary>
        /// <para>The physics layer(s) the query will take into account (as a bitmask). See <a href="$DOCS_URL/tutorials/physics/physics_introduction.html#collision-layers-and-masks">Collision layers and masks</a> in the documentation for more information.</para>
        /// </summary>
        public uint CollisionLayer
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCollisionLayer();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCollisionLayer(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The list of objects or object <see cref="Godot.RID"/>s that will be excluded from collisions.</para>
        /// </summary>
        public Godot.Collections.Array Exclude
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetExclude();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExclude(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The collision margin for the shape.</para>
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

        /// <summary>
        /// <para>The motion of the shape being queried for.</para>
        /// </summary>
        public Vector2 Motion
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMotion();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMotion(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The queried shape's <see cref="Godot.RID"/>. See also <see cref="Godot.Physics2DShapeQueryParameters.SetShape"/>.</para>
        /// </summary>
        public RID ShapeRid
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShapeRid();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShapeRid(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The queried shape's transform matrix.</para>
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

        /// <summary>
        /// <para>If <c>true</c>, the query will take <see cref="Godot.PhysicsBody2D"/>s into account.</para>
        /// </summary>
        public bool CollideWithBodies
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsCollideWithBodiesEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCollideWithBodies(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the query will take <see cref="Godot.Area2D"/>s into account.</para>
        /// </summary>
        public bool CollideWithAreas
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsCollideWithAreasEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCollideWithAreas(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Physics2DShapeQueryParameters";

        public Physics2DShapeQueryParameters() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Physics2DShapeQueryParameters_Ctor(this);
        }

        internal Physics2DShapeQueryParameters(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shape");

        /// <summary>
        /// <para>Sets the <see cref="Godot.Shape2D"/> that will be used for collision/intersection queries.</para>
        /// </summary>
        [GodotMethod("set_shape")]
        public void SetShape(Resource shape)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(shape));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shape_rid");

        [GodotMethod("set_shape_rid")]
        [Obsolete("SetShapeRid is deprecated. Use the ShapeRid property instead.")]
        public void SetShapeRid(RID shape)
        {
            NativeCalls.godot_icall_1_285(method_bind_1, Object.GetPtr(this), RID.GetPtr(shape));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shape_rid");

        [GodotMethod("get_shape_rid")]
        [Obsolete("GetShapeRid is deprecated. Use the ShapeRid property instead.")]
        public RID GetShapeRid()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_2, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_transform");

        [GodotMethod("set_transform")]
        [Obsolete("SetTransform is deprecated. Use the Transform property instead.")]
        public void SetTransform(Transform2D transform)
        {
            NativeCalls.godot_icall_1_220(method_bind_3, Object.GetPtr(this), ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_transform");

        [GodotMethod("get_transform")]
        [Obsolete("GetTransform is deprecated. Use the Transform property instead.")]
        public Transform2D GetTransform()
        {
            NativeCalls.godot_icall_0_221(method_bind_4, Object.GetPtr(this), out Transform2D argRet); return (Transform2D)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_motion");

        [GodotMethod("set_motion")]
        [Obsolete("SetMotion is deprecated. Use the Motion property instead.")]
        public void SetMotion(Vector2 motion)
        {
            NativeCalls.godot_icall_1_57(method_bind_5, Object.GetPtr(this), ref motion);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_motion");

        [GodotMethod("get_motion")]
        [Obsolete("GetMotion is deprecated. Use the Motion property instead.")]
        public Vector2 GetMotion()
        {
            NativeCalls.godot_icall_0_18(method_bind_6, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_margin");

        [GodotMethod("set_margin")]
        [Obsolete("SetMargin is deprecated. Use the Margin property instead.")]
        public void SetMargin(float margin)
        {
            NativeCalls.godot_icall_1_15(method_bind_7, Object.GetPtr(this), margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_margin");

        [GodotMethod("get_margin")]
        [Obsolete("GetMargin is deprecated. Use the Margin property instead.")]
        public float GetMargin()
        {
            return NativeCalls.godot_icall_0_14(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_layer");

        [GodotMethod("set_collision_layer")]
        [Obsolete("SetCollisionLayer is deprecated. Use the CollisionLayer property instead.")]
        public void SetCollisionLayer(uint collisionLayer)
        {
            NativeCalls.godot_icall_1_187(method_bind_9, Object.GetPtr(this), collisionLayer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_layer");

        [GodotMethod("get_collision_layer")]
        [Obsolete("GetCollisionLayer is deprecated. Use the CollisionLayer property instead.")]
        public uint GetCollisionLayer()
        {
            return NativeCalls.godot_icall_0_188(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_exclude");

        [GodotMethod("set_exclude")]
        [Obsolete("SetExclude is deprecated. Use the Exclude property instead.")]
        public void SetExclude(Godot.Collections.Array exclude)
        {
            NativeCalls.godot_icall_1_92(method_bind_11, Object.GetPtr(this), exclude.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_exclude");

        [GodotMethod("get_exclude")]
        [Obsolete("GetExclude is deprecated. Use the Exclude property instead.")]
        public Godot.Collections.Array GetExclude()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_12, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collide_with_bodies");

        [GodotMethod("set_collide_with_bodies")]
        [Obsolete("SetCollideWithBodies is deprecated. Use the CollideWithBodies property instead.")]
        public void SetCollideWithBodies(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_13, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_collide_with_bodies_enabled");

        [GodotMethod("is_collide_with_bodies_enabled")]
        [Obsolete("IsCollideWithBodiesEnabled is deprecated. Use the CollideWithBodies property instead.")]
        public bool IsCollideWithBodiesEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collide_with_areas");

        [GodotMethod("set_collide_with_areas")]
        [Obsolete("SetCollideWithAreas is deprecated. Use the CollideWithAreas property instead.")]
        public void SetCollideWithAreas(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_15, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_collide_with_areas_enabled");

        [GodotMethod("is_collide_with_areas_enabled")]
        [Obsolete("IsCollideWithAreasEnabled is deprecated. Use the CollideWithAreas property instead.")]
        public bool IsCollideWithAreasEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_16, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
