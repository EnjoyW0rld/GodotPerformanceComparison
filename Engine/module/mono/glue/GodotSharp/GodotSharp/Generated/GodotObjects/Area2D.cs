using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>2D area that detects <see cref="Godot.CollisionObject2D"/> nodes overlapping, entering, or exiting. Can also alter or override local physics parameters (gravity, damping) and route audio to a custom audio bus.</para>
    /// <para>To give the area its shape, add a <see cref="Godot.CollisionShape2D"/> or a <see cref="Godot.CollisionPolygon2D"/> node as a direct child (or add multiple such nodes as direct children) of the area.</para>
    /// <para>Warning: See <see cref="Godot.ConcavePolygonShape2D"/> for a warning about possibly unexpected behavior when using that shape for an area.</para>
    /// </summary>
    public partial class Area2D : CollisionObject2D
    {
        public enum SpaceOverrideEnum
        {
            /// <summary>
            /// <para>This area does not affect gravity/damping.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>This area adds its gravity/damping values to whatever has been calculated so far (in <see cref="Godot.Area2D.Priority"/> order).</para>
            /// </summary>
            Combine = 1,
            /// <summary>
            /// <para>This area adds its gravity/damping values to whatever has been calculated so far (in <see cref="Godot.Area2D.Priority"/> order), ignoring any lower priority areas.</para>
            /// </summary>
            CombineReplace = 2,
            /// <summary>
            /// <para>This area replaces any gravity/damping, even the defaults, ignoring any lower priority areas.</para>
            /// </summary>
            Replace = 3,
            /// <summary>
            /// <para>This area replaces any gravity/damping calculated so far (in <see cref="Godot.Area2D.Priority"/> order), but keeps calculating the rest of the areas.</para>
            /// </summary>
            ReplaceCombine = 4
        }

        /// <summary>
        /// <para>If <c>true</c>, the area detects bodies or areas entering and exiting it.</para>
        /// </summary>
        public bool Monitoring
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsMonitoring();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMonitoring(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, other monitoring areas can detect this area.</para>
        /// </summary>
        public bool Monitorable
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsMonitorable();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMonitorable(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The area's priority. Higher priority areas are processed first.</para>
        /// </summary>
        public float Priority
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPriority();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPriority(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Override mode for gravity and damping calculations within this area. See <see cref="Godot.Area2D.SpaceOverrideEnum"/> for possible values.</para>
        /// </summary>
        public Area2D.SpaceOverrideEnum SpaceOverride
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSpaceOverrideMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSpaceOverrideMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, gravity is calculated from a point (set via <see cref="Godot.Area2D.GravityVec"/>). See also <see cref="Godot.Area2D.SpaceOverride"/>.</para>
        /// </summary>
        public bool GravityPoint
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsGravityAPoint();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGravityIsPoint(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The falloff factor for point gravity. The greater the value, the faster gravity decreases with distance.</para>
        /// </summary>
        public float GravityDistanceScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGravityDistanceScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGravityDistanceScale(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The area's gravity vector (not normalized). If gravity is a point (see <see cref="Godot.Area2D.GravityPoint"/>), this will be the point of attraction.</para>
        /// </summary>
        public Vector2 GravityVec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGravityVector();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGravityVector(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The area's gravity intensity (in pixels per second squared). This value multiplies the gravity vector. This is useful to alter the force of gravity without altering its direction.</para>
        /// </summary>
        public float Gravity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGravity();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGravity(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The rate at which objects stop moving in this area. Represents the linear velocity lost per second.</para>
        /// <para>See  for more details about damping.</para>
        /// </summary>
        public float LinearDamp
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLinearDamp();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLinearDamp(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The rate at which objects stop spinning in this area. Represents the angular velocity lost per second.</para>
        /// <para>See  for more details about damping.</para>
        /// </summary>
        public float AngularDamp
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAngularDamp();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAngularDamp(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the area's audio bus overrides the default audio bus.</para>
        /// </summary>
        public bool AudioBusOverride
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsOverridingAudioBus();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAudioBusOverride(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The name of the area's audio bus.</para>
        /// </summary>
        public string AudioBusName
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAudioBusName();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAudioBusName(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Area2D";

        public Area2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Area2D_Ctor(this);
        }

        internal Area2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_space_override_mode");

        [GodotMethod("set_space_override_mode")]
        [Obsolete("SetSpaceOverrideMode is deprecated. Use the SpaceOverride property instead.")]
        public void SetSpaceOverrideMode(Area2D.SpaceOverrideEnum spaceOverrideMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)spaceOverrideMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_space_override_mode");

        [GodotMethod("get_space_override_mode")]
        [Obsolete("GetSpaceOverrideMode is deprecated. Use the SpaceOverride property instead.")]
        public Area2D.SpaceOverrideEnum GetSpaceOverrideMode()
        {
            return (Area2D.SpaceOverrideEnum)NativeCalls.godot_icall_0_150(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_gravity_is_point");

        [GodotMethod("set_gravity_is_point")]
        [Obsolete("SetGravityIsPoint is deprecated. Use the GravityPoint property instead.")]
        public void SetGravityIsPoint(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_gravity_a_point");

        [GodotMethod("is_gravity_a_point")]
        [Obsolete("IsGravityAPoint is deprecated. Use the GravityPoint property instead.")]
        public bool IsGravityAPoint()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_gravity_distance_scale");

        [GodotMethod("set_gravity_distance_scale")]
        [Obsolete("SetGravityDistanceScale is deprecated. Use the GravityDistanceScale property instead.")]
        public void SetGravityDistanceScale(float distanceScale)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), distanceScale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_gravity_distance_scale");

        [GodotMethod("get_gravity_distance_scale")]
        [Obsolete("GetGravityDistanceScale is deprecated. Use the GravityDistanceScale property instead.")]
        public float GetGravityDistanceScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_gravity_vector");

        [GodotMethod("set_gravity_vector")]
        [Obsolete("SetGravityVector is deprecated. Use the GravityVec property instead.")]
        public void SetGravityVector(Vector2 vector)
        {
            NativeCalls.godot_icall_1_57(method_bind_6, Object.GetPtr(this), ref vector);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_gravity_vector");

        [GodotMethod("get_gravity_vector")]
        [Obsolete("GetGravityVector is deprecated. Use the GravityVec property instead.")]
        public Vector2 GetGravityVector()
        {
            NativeCalls.godot_icall_0_18(method_bind_7, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_gravity");

        [GodotMethod("set_gravity")]
        [Obsolete("SetGravity is deprecated. Use the Gravity property instead.")]
        public void SetGravity(float gravity)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), gravity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_gravity");

        [GodotMethod("get_gravity")]
        [Obsolete("GetGravity is deprecated. Use the Gravity property instead.")]
        public float GetGravity()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_linear_damp");

        [GodotMethod("set_linear_damp")]
        [Obsolete("SetLinearDamp is deprecated. Use the LinearDamp property instead.")]
        public void SetLinearDamp(float linearDamp)
        {
            NativeCalls.godot_icall_1_15(method_bind_10, Object.GetPtr(this), linearDamp);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_linear_damp");

        [GodotMethod("get_linear_damp")]
        [Obsolete("GetLinearDamp is deprecated. Use the LinearDamp property instead.")]
        public float GetLinearDamp()
        {
            return NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_angular_damp");

        [GodotMethod("set_angular_damp")]
        [Obsolete("SetAngularDamp is deprecated. Use the AngularDamp property instead.")]
        public void SetAngularDamp(float angularDamp)
        {
            NativeCalls.godot_icall_1_15(method_bind_12, Object.GetPtr(this), angularDamp);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_angular_damp");

        [GodotMethod("get_angular_damp")]
        [Obsolete("GetAngularDamp is deprecated. Use the AngularDamp property instead.")]
        public float GetAngularDamp()
        {
            return NativeCalls.godot_icall_0_14(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_priority");

        [GodotMethod("set_priority")]
        [Obsolete("SetPriority is deprecated. Use the Priority property instead.")]
        public void SetPriority(float priority)
        {
            NativeCalls.godot_icall_1_15(method_bind_14, Object.GetPtr(this), priority);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_priority");

        [GodotMethod("get_priority")]
        [Obsolete("GetPriority is deprecated. Use the Priority property instead.")]
        public float GetPriority()
        {
            return NativeCalls.godot_icall_0_14(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_monitoring");

        [GodotMethod("set_monitoring")]
        [Obsolete("SetMonitoring is deprecated. Use the Monitoring property instead.")]
        public void SetMonitoring(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_16, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_monitoring");

        [GodotMethod("is_monitoring")]
        [Obsolete("IsMonitoring is deprecated. Use the Monitoring property instead.")]
        public bool IsMonitoring()
        {
            return NativeCalls.godot_icall_0_7(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_monitorable");

        [GodotMethod("set_monitorable")]
        [Obsolete("SetMonitorable is deprecated. Use the Monitorable property instead.")]
        public void SetMonitorable(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_18, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_monitorable");

        [GodotMethod("is_monitorable")]
        [Obsolete("IsMonitorable is deprecated. Use the Monitorable property instead.")]
        public bool IsMonitorable()
        {
            return NativeCalls.godot_icall_0_7(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_overlapping_bodies");

        /// <summary>
        /// <para>Returns a list of intersecting <see cref="Godot.PhysicsBody2D"/>s. The overlapping body's <see cref="Godot.CollisionObject2D.CollisionLayer"/> must be part of this area's <see cref="Godot.CollisionObject2D.CollisionMask"/> in order to be detected.</para>
        /// <para>For performance reasons (collisions are all processed at the same time) this list is modified once during the physics step, not immediately after objects are moved. Consider using signals instead.</para>
        /// </summary>
        [GodotMethod("get_overlapping_bodies")]
        public Godot.Collections.Array GetOverlappingBodies()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_20, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_overlapping_areas");

        /// <summary>
        /// <para>Returns a list of intersecting <see cref="Godot.Area2D"/>s. The overlapping area's <see cref="Godot.CollisionObject2D.CollisionLayer"/> must be part of this area's <see cref="Godot.CollisionObject2D.CollisionMask"/> in order to be detected.</para>
        /// <para>For performance reasons (collisions are all processed at the same time) this list is modified once during the physics step, not immediately after objects are moved. Consider using signals instead.</para>
        /// </summary>
        [GodotMethod("get_overlapping_areas")]
        public Godot.Collections.Array GetOverlappingAreas()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_21, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "overlaps_body");

        /// <summary>
        /// <para>If <c>true</c>, the given physics body overlaps the Area2D.</para>
        /// <para>Note: The result of this test is not immediate after moving objects. For performance, list of overlaps is updated once per frame and before the physics step. Consider using signals instead.</para>
        /// <para>The <c>body</c> argument can either be a <see cref="Godot.PhysicsBody2D"/> or a <see cref="Godot.TileMap"/> instance (while TileMaps are not physics bodies themselves, they register their tiles with collision shapes as a virtual physics body).</para>
        /// </summary>
        [GodotMethod("overlaps_body")]
        public bool OverlapsBody(Node body)
        {
            return NativeCalls.godot_icall_1_149(method_bind_22, Object.GetPtr(this), Object.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "overlaps_area");

        /// <summary>
        /// <para>If <c>true</c>, the given area overlaps the Area2D.</para>
        /// <para>Note: The result of this test is not immediate after moving objects. For performance, the list of overlaps is updated once per frame and before the physics step. Consider using signals instead.</para>
        /// </summary>
        [GodotMethod("overlaps_area")]
        public bool OverlapsArea(Node area)
        {
            return NativeCalls.godot_icall_1_149(method_bind_23, Object.GetPtr(this), Object.GetPtr(area));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_audio_bus_name");

        [GodotMethod("set_audio_bus_name")]
        [Obsolete("SetAudioBusName is deprecated. Use the AudioBusName property instead.")]
        public void SetAudioBusName(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_24, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_audio_bus_name");

        [GodotMethod("get_audio_bus_name")]
        [Obsolete("GetAudioBusName is deprecated. Use the AudioBusName property instead.")]
        public string GetAudioBusName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_audio_bus_override");

        [GodotMethod("set_audio_bus_override")]
        [Obsolete("SetAudioBusOverride is deprecated. Use the AudioBusOverride property instead.")]
        public void SetAudioBusOverride(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_26, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_overriding_audio_bus");

        [GodotMethod("is_overriding_audio_bus")]
        [Obsolete("IsOverridingAudioBus is deprecated. Use the AudioBusOverride property instead.")]
        public bool IsOverridingAudioBus()
        {
            return NativeCalls.godot_icall_0_7(method_bind_27, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
