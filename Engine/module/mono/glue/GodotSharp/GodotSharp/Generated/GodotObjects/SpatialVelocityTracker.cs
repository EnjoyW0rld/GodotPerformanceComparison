using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class SpatialVelocityTracker : Reference
    {
        public bool TrackPhysicsStep
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsTrackingPhysicsStep();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTrackPhysicsStep(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "SpatialVelocityTracker";

        public SpatialVelocityTracker() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_SpatialVelocityTracker_Ctor(this);
        }

        internal SpatialVelocityTracker(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_track_physics_step");

        [GodotMethod("set_track_physics_step")]
        [Obsolete("SetTrackPhysicsStep is deprecated. Use the TrackPhysicsStep property instead.")]
        public void SetTrackPhysicsStep(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_tracking_physics_step");

        [GodotMethod("is_tracking_physics_step")]
        [Obsolete("IsTrackingPhysicsStep is deprecated. Use the TrackPhysicsStep property instead.")]
        public bool IsTrackingPhysicsStep()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "update_position");

        [GodotMethod("update_position")]
        public void UpdatePosition(Vector3 position)
        {
            NativeCalls.godot_icall_1_148(method_bind_2, Object.GetPtr(this), ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tracked_linear_velocity");

        [GodotMethod("get_tracked_linear_velocity")]
        public Vector3 GetTrackedLinearVelocity()
        {
            NativeCalls.godot_icall_0_8(method_bind_3, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reset");

        [GodotMethod("reset")]
        public void Reset(Vector3 position)
        {
            NativeCalls.godot_icall_1_148(method_bind_4, Object.GetPtr(this), ref position);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
