using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Contains collision data for <see cref="Godot.KinematicBody"/> collisions. When a <see cref="Godot.KinematicBody"/> is moved using <see cref="Godot.KinematicBody.MoveAndCollide"/>, it stops if it detects a collision with another body. If a collision is detected, a KinematicCollision object is returned.</para>
    /// <para>This object contains information about the collision, including the colliding object, the remaining motion, and the collision position. This information can be used to calculate a collision response.</para>
    /// </summary>
    public partial class KinematicCollision : Reference
    {
        /// <summary>
        /// <para>The point of collision, in global coordinates.</para>
        /// </summary>
        public Vector3 Position
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPosition();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The colliding body's shape's normal at the point of collision.</para>
        /// </summary>
        public Vector3 Normal
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNormal();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The distance the moving object traveled before collision.</para>
        /// </summary>
        public Vector3 Travel
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTravel();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The moving object's remaining movement vector.</para>
        /// </summary>
        public Vector3 Remainder
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRemainder();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The moving object's colliding shape.</para>
        /// </summary>
        public Object LocalShape
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLocalShape();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The colliding body.</para>
        /// </summary>
        public Object Collider
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCollider();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The colliding body's unique instance ID. See <see cref="Godot.Object.GetInstanceId"/>.</para>
        /// </summary>
        public ulong ColliderId
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetColliderId();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The colliding body's <see cref="Godot.RID"/> used by the <see cref="Godot.PhysicsServer"/>.</para>
        /// </summary>
        public RID ColliderRid
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetColliderRid();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The colliding body's shape.</para>
        /// </summary>
        public Object ColliderShape
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetColliderShape();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The colliding shape's index. See <see cref="Godot.CollisionObject"/>.</para>
        /// </summary>
        public int ColliderShapeIndex
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetColliderShapeIndex();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The colliding object's velocity.</para>
        /// </summary>
        public Vector3 ColliderVelocity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetColliderVelocity();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The colliding body's metadata. See <see cref="Godot.Object"/>.</para>
        /// </summary>
        public object ColliderMetadata
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetColliderMetadata();
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "KinematicCollision";

        public KinematicCollision() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_KinematicCollision_Ctor(this);
        }

        internal KinematicCollision(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_position");

        [GodotMethod("get_position")]
        [Obsolete("GetPosition is deprecated. Use the Position property instead.")]
        public Vector3 GetPosition()
        {
            NativeCalls.godot_icall_0_8(method_bind_0, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_normal");

        [GodotMethod("get_normal")]
        [Obsolete("GetNormal is deprecated. Use the Normal property instead.")]
        public Vector3 GetNormal()
        {
            NativeCalls.godot_icall_0_8(method_bind_1, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_travel");

        [GodotMethod("get_travel")]
        [Obsolete("GetTravel is deprecated. Use the Travel property instead.")]
        public Vector3 GetTravel()
        {
            NativeCalls.godot_icall_0_8(method_bind_2, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_remainder");

        [GodotMethod("get_remainder")]
        [Obsolete("GetRemainder is deprecated. Use the Remainder property instead.")]
        public Vector3 GetRemainder()
        {
            NativeCalls.godot_icall_0_8(method_bind_3, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_angle");

        /// <summary>
        /// <para>The collision angle according to <c>up_direction</c>, which is <c>Vector3.UP</c> by default. This value is always positive.</para>
        /// </summary>
        /// <param name="upDirection">If the parameter is null, then the default value is new Vector3(0, 1, 0)</param>
        [GodotMethod("get_angle")]
        public float GetAngle(Nullable<Vector3> upDirection = null)
        {
            Vector3 upDirection_in = upDirection.HasValue ? upDirection.Value : new Vector3(0, 1, 0);
            return NativeCalls.godot_icall_1_357(method_bind_4, Object.GetPtr(this), ref upDirection_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_local_shape");

        [GodotMethod("get_local_shape")]
        [Obsolete("GetLocalShape is deprecated. Use the LocalShape property instead.")]
        public Object GetLocalShape()
        {
            return NativeCalls.godot_icall_0_397(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collider");

        [GodotMethod("get_collider")]
        [Obsolete("GetCollider is deprecated. Use the Collider property instead.")]
        public Object GetCollider()
        {
            return NativeCalls.godot_icall_0_397(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collider_id");

        [GodotMethod("get_collider_id")]
        [Obsolete("GetColliderId is deprecated. Use the ColliderId property instead.")]
        public ulong GetColliderId()
        {
            return NativeCalls.godot_icall_0_30(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collider_rid");

        [GodotMethod("get_collider_rid")]
        [Obsolete("GetColliderRid is deprecated. Use the ColliderRid property instead.")]
        public RID GetColliderRid()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_8, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collider_shape");

        [GodotMethod("get_collider_shape")]
        [Obsolete("GetColliderShape is deprecated. Use the ColliderShape property instead.")]
        public Object GetColliderShape()
        {
            return NativeCalls.godot_icall_0_397(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collider_shape_index");

        [GodotMethod("get_collider_shape_index")]
        [Obsolete("GetColliderShapeIndex is deprecated. Use the ColliderShapeIndex property instead.")]
        public int GetColliderShapeIndex()
        {
            return NativeCalls.godot_icall_0_5(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collider_velocity");

        [GodotMethod("get_collider_velocity")]
        [Obsolete("GetColliderVelocity is deprecated. Use the ColliderVelocity property instead.")]
        public Vector3 GetColliderVelocity()
        {
            NativeCalls.godot_icall_0_8(method_bind_11, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collider_metadata");

        [GodotMethod("get_collider_metadata")]
        [Obsolete("GetColliderMetadata is deprecated. Use the ColliderMetadata property instead.")]
        public object GetColliderMetadata()
        {
            return NativeCalls.godot_icall_0_547(method_bind_12, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
