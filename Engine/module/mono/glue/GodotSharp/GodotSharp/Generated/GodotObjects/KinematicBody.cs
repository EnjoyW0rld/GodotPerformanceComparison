using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Kinematic bodies are special types of bodies that are meant to be user-controlled. They are not affected by physics at all; to other types of bodies, such as a character or a rigid body, these are the same as a static body. However, they have two main uses:</para>
    /// <para>Simulated motion: When these bodies are moved manually, either from code or from an <see cref="Godot.AnimationPlayer"/> (with <see cref="Godot.AnimationPlayer.PlaybackProcessMode"/> set to "physics"), the physics will automatically compute an estimate of their linear and angular velocity. This makes them very useful for moving platforms or other AnimationPlayer-controlled objects (like a door, a bridge that opens, etc).</para>
    /// <para>Kinematic characters: KinematicBody also has an API for moving objects (the <see cref="Godot.KinematicBody.MoveAndCollide"/> and <see cref="Godot.KinematicBody.MoveAndSlide"/> methods) while performing collision tests. This makes them really useful to implement characters that collide against a world, but don't require advanced physics.</para>
    /// </summary>
    public partial class KinematicBody : PhysicsBody
    {
        public enum MovingPlatformApplyVelocityOnLeaveEnum
        {
            /// <summary>
            /// <para>Add the last platform velocity when you leave a moving platform.</para>
            /// </summary>
            Always = 0,
            /// <summary>
            /// <para>Add the last platform velocity when you leave a moving platform, but any downward motion is ignored. It's useful to keep full jump height even when the platform is moving down.</para>
            /// </summary>
            UpwardOnly = 1,
            /// <summary>
            /// <para>Do nothing when leaving a platform.</para>
            /// </summary>
            Never = 2
        }

        /// <summary>
        /// <para>Lock the body's X axis movement.</para>
        /// </summary>
        public bool AxisLockMotionX
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAxisLock((PhysicsServer.BodyAxis)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAxisLock((PhysicsServer.BodyAxis)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Lock the body's Y axis movement.</para>
        /// </summary>
        public bool AxisLockMotionY
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAxisLock((PhysicsServer.BodyAxis)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAxisLock((PhysicsServer.BodyAxis)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Lock the body's Z axis movement.</para>
        /// </summary>
        public bool AxisLockMotionZ
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAxisLock((PhysicsServer.BodyAxis)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAxisLock((PhysicsServer.BodyAxis)4, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Lock the body's X axis movement. Deprecated alias for <see cref="Godot.KinematicBody.AxisLockMotionX"/>.</para>
        /// </summary>
        public bool MoveLockX
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAxisLock((PhysicsServer.BodyAxis)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAxisLock((PhysicsServer.BodyAxis)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Lock the body's Y axis movement. Deprecated alias for <see cref="Godot.KinematicBody.AxisLockMotionY"/>.</para>
        /// </summary>
        public bool MoveLockY
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAxisLock((PhysicsServer.BodyAxis)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAxisLock((PhysicsServer.BodyAxis)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Lock the body's Z axis movement. Deprecated alias for <see cref="Godot.KinematicBody.AxisLockMotionZ"/>.</para>
        /// </summary>
        public bool MoveLockZ
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAxisLock((PhysicsServer.BodyAxis)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAxisLock((PhysicsServer.BodyAxis)4, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Extra margin used for collision recovery in motion functions (see <see cref="Godot.KinematicBody.MoveAndCollide"/>, <see cref="Godot.KinematicBody.MoveAndSlide"/>, <see cref="Godot.KinematicBody.MoveAndSlideWithSnap"/>).</para>
        /// <para>If the body is at least this close to another body, it will consider them to be colliding and will be pushed away before performing the actual motion.</para>
        /// <para>A higher value means it's more flexible for detecting collision, which helps with consistently detecting walls and floors.</para>
        /// <para>A lower value forces the collision algorithm to use more exact detection, so it can be used in cases that specifically require precision, e.g at very low scale to avoid visible jittering, or for stability with a stack of kinematic bodies.</para>
        /// </summary>
        public float Collision__safeMargin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSafeMargin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSafeMargin(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the body's movement will be synchronized to the physics frame. This is useful when animating movement via <see cref="Godot.AnimationPlayer"/>, for example on moving platforms. Do not use together with <see cref="Godot.KinematicBody.MoveAndSlide"/> or <see cref="Godot.KinematicBody.MoveAndCollide"/> functions.</para>
        /// </summary>
        public bool Motion__syncToPhysics
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsSyncToPhysicsEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSyncToPhysics(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the behavior to apply when you leave a moving platform. By default, to be physically accurate, when you leave the last platform velocity is applied. See <see cref="Godot.KinematicBody.MovingPlatformApplyVelocityOnLeaveEnum"/> constants for available behavior.</para>
        /// </summary>
        public KinematicBody.MovingPlatformApplyVelocityOnLeaveEnum MovingPlatformApplyVelocityOnLeave
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMovingPlatformApplyVelocityOnLeave();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMovingPlatformApplyVelocityOnLeave(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "KinematicBody";

        public KinematicBody() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_KinematicBody_Ctor(this);
        }

        internal KinematicBody(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "move_and_collide");

        /// <summary>
        /// <para>Moves the body along the vector <c>rel_vec</c>. The body will stop if it collides. Returns a <see cref="Godot.KinematicCollision"/>, which contains information about the collision when stopped, or when touching another body along the motion.</para>
        /// <para>If <c>test_only</c> is <c>true</c>, the body does not move but the would-be collision information is given.</para>
        /// </summary>
        [GodotMethod("move_and_collide")]
        public KinematicCollision MoveAndCollide(Vector3 relVec, bool infiniteInertia = true, bool excludeRaycastShapes = true, bool testOnly = false)
        {
            return NativeCalls.godot_icall_4_560(method_bind_0, Object.GetPtr(this), ref relVec, infiniteInertia, excludeRaycastShapes, testOnly);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "move_and_slide");

        /// <summary>
        /// <para>Moves the body along a vector. If the body collides with another, it will slide along the other body rather than stop immediately. If the other body is a <see cref="Godot.KinematicBody"/> or <see cref="Godot.RigidBody"/>, it will also be affected by the motion of the other body. You can use this to make moving and rotating platforms, or to make nodes push other nodes.</para>
        /// <para>This method should be used in <see cref="Godot.Node._PhysicsProcess"/> (or in a method called by <see cref="Godot.Node._PhysicsProcess"/>), as it uses the physics step's <c>delta</c> value automatically in calculations. Otherwise, the simulation will run at an incorrect speed.</para>
        /// <para><c>linear_velocity</c> is the velocity vector (typically meters per second). Unlike in <see cref="Godot.KinematicBody.MoveAndCollide"/>, you should not multiply it by <c>delta</c> — the physics engine handles applying the velocity.</para>
        /// <para><c>up_direction</c> is the up direction, used to determine what is a wall and what is a floor or a ceiling. If set to the default value of <c>Vector3(0, 0, 0)</c>, everything is considered a wall.</para>
        /// <para>If <c>stop_on_slope</c> is <c>true</c>, body will not slide on slopes when you include gravity in <c>linear_velocity</c> and the body is standing still.</para>
        /// <para>If the body collides, it will change direction a maximum of <c>max_slides</c> times before it stops.</para>
        /// <para><c>floor_max_angle</c> is the maximum angle (in radians) where a slope is still considered a floor (or a ceiling), rather than a wall. The default value equals 45 degrees.</para>
        /// <para>If <c>infinite_inertia</c> is <c>true</c>, body will be able to push <see cref="Godot.RigidBody"/> nodes, but it won't also detect any collisions with them. If <c>false</c>, it will interact with <see cref="Godot.RigidBody"/> nodes like with <see cref="Godot.StaticBody"/>.</para>
        /// <para>Returns the <c>linear_velocity</c> vector, rotated and/or scaled if a slide collision occurred. To get detailed information about collisions that occurred, use <see cref="Godot.KinematicBody.GetSlideCollision"/>.</para>
        /// <para>When the body touches a moving platform, the platform's velocity is automatically added to the body motion. If a collision occurs due to the platform's motion, it will always be first in the slide collisions.</para>
        /// </summary>
        /// <param name="upDirection">If the parameter is null, then the default value is new Vector3(0, 0, 0)</param>
        [GodotMethod("move_and_slide")]
        public Vector3 MoveAndSlide(Vector3 linearVelocity, Nullable<Vector3> upDirection = null, bool stopOnSlope = false, int maxSlides = 4, float floorMaxAngle = 0.785398f, bool infiniteInertia = true)
        {
            Vector3 upDirection_in = upDirection.HasValue ? upDirection.Value : new Vector3(0, 0, 0);
            NativeCalls.godot_icall_6_561(method_bind_1, Object.GetPtr(this), ref linearVelocity, ref upDirection_in, stopOnSlope, maxSlides, floorMaxAngle, infiniteInertia, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "move_and_slide_with_snap");

        /// <summary>
        /// <para>Moves the body while keeping it attached to slopes. Similar to <see cref="Godot.KinematicBody.MoveAndSlide"/>.</para>
        /// <para>As long as the <c>snap</c> vector is in contact with the ground, the body will remain attached to the surface. This means you must disable snap in order to jump, for example. You can do this by setting <c>snap</c> to <c>(0, 0, 0)</c> or by using <see cref="Godot.KinematicBody.MoveAndSlide"/> instead.</para>
        /// </summary>
        /// <param name="upDirection">If the parameter is null, then the default value is new Vector3(0, 0, 0)</param>
        [GodotMethod("move_and_slide_with_snap")]
        public Vector3 MoveAndSlideWithSnap(Vector3 linearVelocity, Vector3 snap, Nullable<Vector3> upDirection = null, bool stopOnSlope = false, int maxSlides = 4, float floorMaxAngle = 0.785398f, bool infiniteInertia = true)
        {
            Vector3 upDirection_in = upDirection.HasValue ? upDirection.Value : new Vector3(0, 0, 0);
            NativeCalls.godot_icall_7_562(method_bind_2, Object.GetPtr(this), ref linearVelocity, ref snap, ref upDirection_in, stopOnSlope, maxSlides, floorMaxAngle, infiniteInertia, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "test_move");

        /// <summary>
        /// <para>Checks for collisions without moving the body. Virtually sets the node's position, scale and rotation to that of the given <see cref="Godot.Transform"/>, then tries to move the body along the vector <c>rel_vec</c>. Returns <c>true</c> if a collision would stop the body from moving along the whole path.</para>
        /// <para>Use <see cref="Godot.KinematicBody.MoveAndCollide"/> instead for detecting collision with touching bodies.</para>
        /// </summary>
        [GodotMethod("test_move")]
        public bool TestMove(Transform from, Vector3 relVec, bool infiniteInertia = true)
        {
            return NativeCalls.godot_icall_3_563(method_bind_3, Object.GetPtr(this), ref from, ref relVec, infiniteInertia);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_on_floor");

        /// <summary>
        /// <para>Returns <c>true</c> if the body collided with the floor on the last call of <see cref="Godot.KinematicBody.MoveAndSlide"/> or <see cref="Godot.KinematicBody.MoveAndSlideWithSnap"/>. Otherwise, returns <c>false</c>.</para>
        /// </summary>
        [GodotMethod("is_on_floor")]
        public bool IsOnFloor()
        {
            return NativeCalls.godot_icall_0_7(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_on_ceiling");

        /// <summary>
        /// <para>Returns <c>true</c> if the body collided with the ceiling on the last call of <see cref="Godot.KinematicBody.MoveAndSlide"/> or <see cref="Godot.KinematicBody.MoveAndSlideWithSnap"/>. Otherwise, returns <c>false</c>.</para>
        /// </summary>
        [GodotMethod("is_on_ceiling")]
        public bool IsOnCeiling()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_on_wall");

        /// <summary>
        /// <para>Returns <c>true</c> if the body collided with a wall on the last call of <see cref="Godot.KinematicBody.MoveAndSlide"/> or <see cref="Godot.KinematicBody.MoveAndSlideWithSnap"/>. Otherwise, returns <c>false</c>.</para>
        /// </summary>
        [GodotMethod("is_on_wall")]
        public bool IsOnWall()
        {
            return NativeCalls.godot_icall_0_7(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_floor_normal");

        /// <summary>
        /// <para>Returns the surface normal of the floor at the last collision point. Only valid after calling <see cref="Godot.KinematicBody.MoveAndSlide"/> or <see cref="Godot.KinematicBody.MoveAndSlideWithSnap"/> and when <see cref="Godot.KinematicBody.IsOnFloor"/> returns <c>true</c>.</para>
        /// </summary>
        [GodotMethod("get_floor_normal")]
        public Vector3 GetFloorNormal()
        {
            NativeCalls.godot_icall_0_8(method_bind_7, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_floor_angle");

        /// <summary>
        /// <para>Returns the floor's collision angle at the last collision point according to <c>up_direction</c>, which is <c>Vector3.UP</c> by default. This value is always positive and only valid after calling <see cref="Godot.KinematicBody.MoveAndSlide"/> and when <see cref="Godot.KinematicBody.IsOnFloor"/> returns <c>true</c>.</para>
        /// </summary>
        /// <param name="upDirection">If the parameter is null, then the default value is new Vector3(0, 1, 0)</param>
        [GodotMethod("get_floor_angle")]
        public float GetFloorAngle(Nullable<Vector3> upDirection = null)
        {
            Vector3 upDirection_in = upDirection.HasValue ? upDirection.Value : new Vector3(0, 1, 0);
            return NativeCalls.godot_icall_1_357(method_bind_8, Object.GetPtr(this), ref upDirection_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_floor_velocity");

        /// <summary>
        /// <para>Returns the linear velocity of the floor at the last collision point. Only valid after calling <see cref="Godot.KinematicBody.MoveAndSlide"/> or <see cref="Godot.KinematicBody.MoveAndSlideWithSnap"/> and when <see cref="Godot.KinematicBody.IsOnFloor"/> returns <c>true</c>.</para>
        /// </summary>
        [GodotMethod("get_floor_velocity")]
        public Vector3 GetFloorVelocity()
        {
            NativeCalls.godot_icall_0_8(method_bind_9, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_axis_lock");

        /// <summary>
        /// <para>Locks or unlocks the specified <c>axis</c> depending on the value of <c>lock</c>. See also <see cref="Godot.KinematicBody.MoveLockX"/>, <see cref="Godot.KinematicBody.MoveLockY"/> and <see cref="Godot.KinematicBody.MoveLockZ"/>.</para>
        /// </summary>
        [GodotMethod("set_axis_lock")]
        [Obsolete("SetAxisLock is deprecated. Use the MoveLockZ property instead.")]
        public void SetAxisLock(PhysicsServer.BodyAxis axis, bool @lock)
        {
            NativeCalls.godot_icall_2_23(method_bind_10, Object.GetPtr(this), (int)axis, @lock);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_axis_lock");

        /// <summary>
        /// <para>Returns <c>true</c> if the specified <c>axis</c> is locked. See also <see cref="Godot.KinematicBody.MoveLockX"/>, <see cref="Godot.KinematicBody.MoveLockY"/> and <see cref="Godot.KinematicBody.MoveLockZ"/>.</para>
        /// </summary>
        [GodotMethod("get_axis_lock")]
        [Obsolete("GetAxisLock is deprecated. Use the MoveLockZ property instead.")]
        public bool GetAxisLock(PhysicsServer.BodyAxis axis)
        {
            return NativeCalls.godot_icall_1_35(method_bind_11, Object.GetPtr(this), (int)axis);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_safe_margin");

        [GodotMethod("set_safe_margin")]
        [Obsolete("SetSafeMargin is deprecated. Use the Collision__safeMargin property instead.")]
        public void SetSafeMargin(float pixels)
        {
            NativeCalls.godot_icall_1_15(method_bind_12, Object.GetPtr(this), pixels);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_safe_margin");

        [GodotMethod("get_safe_margin")]
        [Obsolete("GetSafeMargin is deprecated. Use the Collision__safeMargin property instead.")]
        public float GetSafeMargin()
        {
            return NativeCalls.godot_icall_0_14(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_moving_platform_apply_velocity_on_leave");

        [GodotMethod("set_moving_platform_apply_velocity_on_leave")]
        [Obsolete("SetMovingPlatformApplyVelocityOnLeave is deprecated. Use the MovingPlatformApplyVelocityOnLeave property instead.")]
        public void SetMovingPlatformApplyVelocityOnLeave(KinematicBody.MovingPlatformApplyVelocityOnLeaveEnum onLeaveApplyVelocity)
        {
            NativeCalls.godot_icall_1_4(method_bind_14, Object.GetPtr(this), (int)onLeaveApplyVelocity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_moving_platform_apply_velocity_on_leave");

        [GodotMethod("get_moving_platform_apply_velocity_on_leave")]
        [Obsolete("GetMovingPlatformApplyVelocityOnLeave is deprecated. Use the MovingPlatformApplyVelocityOnLeave property instead.")]
        public KinematicBody.MovingPlatformApplyVelocityOnLeaveEnum GetMovingPlatformApplyVelocityOnLeave()
        {
            return (KinematicBody.MovingPlatformApplyVelocityOnLeaveEnum)NativeCalls.godot_icall_0_564(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_slide_count");

        /// <summary>
        /// <para>Returns the number of times the body collided and changed direction during the last call to <see cref="Godot.KinematicBody.MoveAndSlide"/> or <see cref="Godot.KinematicBody.MoveAndSlideWithSnap"/>.</para>
        /// </summary>
        [GodotMethod("get_slide_count")]
        public int GetSlideCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_slide_collision");

        /// <summary>
        /// <para>Returns a <see cref="Godot.KinematicCollision"/>, which contains information about a collision that occurred during the last call to <see cref="Godot.KinematicBody.MoveAndSlide"/> or <see cref="Godot.KinematicBody.MoveAndSlideWithSnap"/>. Since the body can collide several times in a single call to <see cref="Godot.KinematicBody.MoveAndSlide"/>, you must specify the index of the collision in the range 0 to (<see cref="Godot.KinematicBody.GetSlideCount"/> - 1).</para>
        /// </summary>
        [GodotMethod("get_slide_collision")]
        public KinematicCollision GetSlideCollision(int slideIdx)
        {
            return NativeCalls.godot_icall_1_565(method_bind_17, Object.GetPtr(this), slideIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_last_slide_collision");

        /// <summary>
        /// <para>Returns a <see cref="Godot.KinematicCollision"/>, which contains information about the latest collision that occurred during the last call to <see cref="Godot.KinematicBody.MoveAndSlide"/>.</para>
        /// </summary>
        [GodotMethod("get_last_slide_collision")]
        public KinematicCollision GetLastSlideCollision()
        {
            return NativeCalls.godot_icall_0_566(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sync_to_physics");

        [GodotMethod("set_sync_to_physics")]
        [Obsolete("SetSyncToPhysics is deprecated. Use the Motion__syncToPhysics property instead.")]
        public void SetSyncToPhysics(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_19, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_sync_to_physics_enabled");

        [GodotMethod("is_sync_to_physics_enabled")]
        [Obsolete("IsSyncToPhysicsEnabled is deprecated. Use the Motion__syncToPhysics property instead.")]
        public bool IsSyncToPhysicsEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_20, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
