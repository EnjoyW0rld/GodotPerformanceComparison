using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class Physics2DTestMotionResult : Reference
    {
        public Vector2 Motion
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMotion();
            }
#pragma warning restore CS0618
        }

        public Vector2 MotionRemainder
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMotionRemainder();
            }
#pragma warning restore CS0618
        }

        public Vector2 CollisionPoint
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCollisionPoint();
            }
#pragma warning restore CS0618
        }

        public Vector2 CollisionNormal
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCollisionNormal();
            }
#pragma warning restore CS0618
        }

        public Vector2 ColliderVelocity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetColliderVelocity();
            }
#pragma warning restore CS0618
        }

        public ulong ColliderId
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetColliderId();
            }
#pragma warning restore CS0618
        }

        public RID ColliderRid
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetColliderRid();
            }
#pragma warning restore CS0618
        }

        public Object Collider
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCollider();
            }
#pragma warning restore CS0618
        }

        public int ColliderShape
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetColliderShape();
            }
#pragma warning restore CS0618
        }

        public float CollisionDepth
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCollisionDepth();
            }
#pragma warning restore CS0618
        }

        public float CollisionSafeFraction
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCollisionSafeFraction();
            }
#pragma warning restore CS0618
        }

        public float CollisionUnsafeFraction
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCollisionUnsafeFraction();
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Physics2DTestMotionResult";

        public Physics2DTestMotionResult() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Physics2DTestMotionResult_Ctor(this);
        }

        internal Physics2DTestMotionResult(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_motion");

        [GodotMethod("get_motion")]
        [Obsolete("GetMotion is deprecated. Use the Motion property instead.")]
        public Vector2 GetMotion()
        {
            NativeCalls.godot_icall_0_18(method_bind_0, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_motion_remainder");

        [GodotMethod("get_motion_remainder")]
        [Obsolete("GetMotionRemainder is deprecated. Use the MotionRemainder property instead.")]
        public Vector2 GetMotionRemainder()
        {
            NativeCalls.godot_icall_0_18(method_bind_1, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_point");

        [GodotMethod("get_collision_point")]
        [Obsolete("GetCollisionPoint is deprecated. Use the CollisionPoint property instead.")]
        public Vector2 GetCollisionPoint()
        {
            NativeCalls.godot_icall_0_18(method_bind_2, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_normal");

        [GodotMethod("get_collision_normal")]
        [Obsolete("GetCollisionNormal is deprecated. Use the CollisionNormal property instead.")]
        public Vector2 GetCollisionNormal()
        {
            NativeCalls.godot_icall_0_18(method_bind_3, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collider_velocity");

        [GodotMethod("get_collider_velocity")]
        [Obsolete("GetColliderVelocity is deprecated. Use the ColliderVelocity property instead.")]
        public Vector2 GetColliderVelocity()
        {
            NativeCalls.godot_icall_0_18(method_bind_4, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collider_id");

        [GodotMethod("get_collider_id")]
        [Obsolete("GetColliderId is deprecated. Use the ColliderId property instead.")]
        public ulong GetColliderId()
        {
            return NativeCalls.godot_icall_0_30(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collider_rid");

        [GodotMethod("get_collider_rid")]
        [Obsolete("GetColliderRid is deprecated. Use the ColliderRid property instead.")]
        public RID GetColliderRid()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_6, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collider");

        [GodotMethod("get_collider")]
        [Obsolete("GetCollider is deprecated. Use the Collider property instead.")]
        public Object GetCollider()
        {
            return NativeCalls.godot_icall_0_397(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collider_shape");

        [GodotMethod("get_collider_shape")]
        [Obsolete("GetColliderShape is deprecated. Use the ColliderShape property instead.")]
        public int GetColliderShape()
        {
            return NativeCalls.godot_icall_0_5(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_depth");

        [GodotMethod("get_collision_depth")]
        [Obsolete("GetCollisionDepth is deprecated. Use the CollisionDepth property instead.")]
        public float GetCollisionDepth()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_safe_fraction");

        [GodotMethod("get_collision_safe_fraction")]
        [Obsolete("GetCollisionSafeFraction is deprecated. Use the CollisionSafeFraction property instead.")]
        public float GetCollisionSafeFraction()
        {
            return NativeCalls.godot_icall_0_14(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_unsafe_fraction");

        [GodotMethod("get_collision_unsafe_fraction")]
        [Obsolete("GetCollisionUnsafeFraction is deprecated. Use the CollisionUnsafeFraction property instead.")]
        public float GetCollisionUnsafeFraction()
        {
            return NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
