using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A RayCast represents a line from its origin to its destination position, <c>cast_to</c>. It is used to query the 3D space in order to find the closest object along the path of the ray.</para>
    /// <para>RayCast can ignore some objects by adding them to the exception list via <c>add_exception</c> or by setting proper filtering with collision layers and masks.</para>
    /// <para>RayCast can be configured to report collisions with <see cref="Godot.Area"/>s (<see cref="Godot.RayCast.CollideWithAreas"/>) and/or <see cref="Godot.PhysicsBody"/>s (<see cref="Godot.RayCast.CollideWithBodies"/>).</para>
    /// <para>Only enabled raycasts will be able to query the space and report collisions.</para>
    /// <para>RayCast calculates intersection every physics frame (see <see cref="Godot.Node"/>), and the result is cached so it can be used later until the next frame. If multiple queries are required between physics frames (or during the same frame), use <see cref="Godot.RayCast.ForceRaycastUpdate"/> after adjusting the raycast.</para>
    /// </summary>
    public partial class RayCast : Spatial
    {
        /// <summary>
        /// <para>If <c>true</c>, collisions will be reported.</para>
        /// </summary>
        public bool Enabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, collisions will be ignored for this RayCast's immediate parent.</para>
        /// </summary>
        public bool ExcludeParent
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetExcludeParentBody();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExcludeParentBody(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The ray's destination point, relative to the RayCast's <c>position</c>.</para>
        /// </summary>
        public Vector3 CastTo
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCastTo();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCastTo(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The ray's collision mask. Only objects in at least one collision layer enabled in the mask will be detected. See <a href="$DOCS_URL/tutorials/physics/physics_introduction.html#collision-layers-and-masks">Collision layers and masks</a> in the documentation for more information.</para>
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
        /// <para>If <c>true</c>, collision with <see cref="Godot.Area"/>s will be reported.</para>
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

        /// <summary>
        /// <para>If <c>true</c>, collision with <see cref="Godot.PhysicsBody"/>s will be reported.</para>
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
        /// <para>The custom color to use to draw the shape in the editor and at run-time if Visible Collision Shapes is enabled in the Debug menu. This color will be highlighted at run-time if the <see cref="Godot.RayCast"/> is colliding with something.</para>
        /// <para>If set to <c>Color(0.0, 0.0, 0.0)</c> (by default), the color set in  is used.</para>
        /// </summary>
        public Color DebugShapeCustomColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDebugShapeCustomColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDebugShapeCustomColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If set to <c>1</c>, a line is used as the debug shape. Otherwise, a truncated pyramid is drawn to represent the <see cref="Godot.RayCast"/>. Requires Visible Collision Shapes to be enabled in the Debug menu for the debug shape to be visible at run-time.</para>
        /// </summary>
        public int DebugShapeThickness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDebugShapeThickness();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDebugShapeThickness(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "RayCast";

        public RayCast() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_RayCast_Ctor(this);
        }

        internal RayCast(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_enabled");

        [GodotMethod("set_enabled")]
        [Obsolete("SetEnabled is deprecated. Use the Enabled property instead.")]
        public void SetEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_enabled");

        [GodotMethod("is_enabled")]
        [Obsolete("IsEnabled is deprecated. Use the Enabled property instead.")]
        public bool IsEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cast_to");

        [GodotMethod("set_cast_to")]
        [Obsolete("SetCastTo is deprecated. Use the CastTo property instead.")]
        public void SetCastTo(Vector3 localPoint)
        {
            NativeCalls.godot_icall_1_148(method_bind_2, Object.GetPtr(this), ref localPoint);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cast_to");

        [GodotMethod("get_cast_to")]
        [Obsolete("GetCastTo is deprecated. Use the CastTo property instead.")]
        public Vector3 GetCastTo()
        {
            NativeCalls.godot_icall_0_8(method_bind_3, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_colliding");

        /// <summary>
        /// <para>Returns whether any object is intersecting with the ray's vector (considering the vector length).</para>
        /// </summary>
        [GodotMethod("is_colliding")]
        public bool IsColliding()
        {
            return NativeCalls.godot_icall_0_7(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "force_raycast_update");

        /// <summary>
        /// <para>Updates the collision information for the ray. Use this method to update the collision information immediately instead of waiting for the next <c>_physics_process</c> call, for example if the ray or its parent has changed state.</para>
        /// <para>Note: <c>enabled</c> is not required for this to work.</para>
        /// </summary>
        [GodotMethod("force_raycast_update")]
        public void ForceRaycastUpdate()
        {
            NativeCalls.godot_icall_0_3(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collider");

        /// <summary>
        /// <para>Returns the first object that the ray intersects, or <c>null</c> if no object is intersecting the ray (i.e. <see cref="Godot.RayCast.IsColliding"/> returns <c>false</c>).</para>
        /// </summary>
        [GodotMethod("get_collider")]
        public Object GetCollider()
        {
            return NativeCalls.godot_icall_0_397(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collider_shape");

        /// <summary>
        /// <para>Returns the shape ID of the first object that the ray intersects, or <c>0</c> if no object is intersecting the ray (i.e. <see cref="Godot.RayCast.IsColliding"/> returns <c>false</c>).</para>
        /// </summary>
        [GodotMethod("get_collider_shape")]
        public int GetColliderShape()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_point");

        /// <summary>
        /// <para>Returns the collision point at which the ray intersects the closest object.</para>
        /// <para>Note: This point is in the global coordinate system.</para>
        /// </summary>
        [GodotMethod("get_collision_point")]
        public Vector3 GetCollisionPoint()
        {
            NativeCalls.godot_icall_0_8(method_bind_8, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_normal");

        /// <summary>
        /// <para>Returns the normal of the intersecting object's shape at the collision point.</para>
        /// </summary>
        [GodotMethod("get_collision_normal")]
        public Vector3 GetCollisionNormal()
        {
            NativeCalls.godot_icall_0_8(method_bind_9, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_exception_rid");

        /// <summary>
        /// <para>Adds a collision exception so the ray does not report collisions with the specified <see cref="Godot.RID"/>.</para>
        /// </summary>
        [GodotMethod("add_exception_rid")]
        public void AddExceptionRid(RID rid)
        {
            NativeCalls.godot_icall_1_285(method_bind_10, Object.GetPtr(this), RID.GetPtr(rid));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_exception");

        /// <summary>
        /// <para>Adds a collision exception so the ray does not report collisions with the specified node.</para>
        /// </summary>
        [GodotMethod("add_exception")]
        public void AddException(Object node)
        {
            NativeCalls.godot_icall_1_53(method_bind_11, Object.GetPtr(this), Object.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_exception_rid");

        /// <summary>
        /// <para>Removes a collision exception so the ray does report collisions with the specified <see cref="Godot.RID"/>.</para>
        /// </summary>
        [GodotMethod("remove_exception_rid")]
        public void RemoveExceptionRid(RID rid)
        {
            NativeCalls.godot_icall_1_285(method_bind_12, Object.GetPtr(this), RID.GetPtr(rid));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_exception");

        /// <summary>
        /// <para>Removes a collision exception so the ray does report collisions with the specified node.</para>
        /// </summary>
        [GodotMethod("remove_exception")]
        public void RemoveException(Object node)
        {
            NativeCalls.godot_icall_1_53(method_bind_13, Object.GetPtr(this), Object.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_exceptions");

        /// <summary>
        /// <para>Removes all collision exceptions for this ray.</para>
        /// </summary>
        [GodotMethod("clear_exceptions")]
        public void ClearExceptions()
        {
            NativeCalls.godot_icall_0_3(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_mask");

        [GodotMethod("set_collision_mask")]
        [Obsolete("SetCollisionMask is deprecated. Use the CollisionMask property instead.")]
        public void SetCollisionMask(uint mask)
        {
            NativeCalls.godot_icall_1_187(method_bind_15, Object.GetPtr(this), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_mask");

        [GodotMethod("get_collision_mask")]
        [Obsolete("GetCollisionMask is deprecated. Use the CollisionMask property instead.")]
        public uint GetCollisionMask()
        {
            return NativeCalls.godot_icall_0_188(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_mask_bit");

        /// <summary>
        /// <para>Sets the bit index passed to the <c>value</c> passed.</para>
        /// <para>Note: Bit indexes range from 0-19.</para>
        /// </summary>
        [GodotMethod("set_collision_mask_bit")]
        public void SetCollisionMaskBit(int bit, bool value)
        {
            NativeCalls.godot_icall_2_23(method_bind_17, Object.GetPtr(this), bit, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_mask_bit");

        /// <summary>
        /// <para>Returns <c>true</c> if the bit index passed is turned on.</para>
        /// <para>Note: Bit indices range from 0-19.</para>
        /// </summary>
        [GodotMethod("get_collision_mask_bit")]
        public bool GetCollisionMaskBit(int bit)
        {
            return NativeCalls.godot_icall_1_35(method_bind_18, Object.GetPtr(this), bit);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_exclude_parent_body");

        [GodotMethod("set_exclude_parent_body")]
        [Obsolete("SetExcludeParentBody is deprecated. Use the ExcludeParent property instead.")]
        public void SetExcludeParentBody(bool mask)
        {
            NativeCalls.godot_icall_1_16(method_bind_19, Object.GetPtr(this), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_exclude_parent_body");

        [GodotMethod("get_exclude_parent_body")]
        [Obsolete("GetExcludeParentBody is deprecated. Use the ExcludeParent property instead.")]
        public bool GetExcludeParentBody()
        {
            return NativeCalls.godot_icall_0_7(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collide_with_areas");

        [GodotMethod("set_collide_with_areas")]
        [Obsolete("SetCollideWithAreas is deprecated. Use the CollideWithAreas property instead.")]
        public void SetCollideWithAreas(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_21, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_collide_with_areas_enabled");

        [GodotMethod("is_collide_with_areas_enabled")]
        [Obsolete("IsCollideWithAreasEnabled is deprecated. Use the CollideWithAreas property instead.")]
        public bool IsCollideWithAreasEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_22, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collide_with_bodies");

        [GodotMethod("set_collide_with_bodies")]
        [Obsolete("SetCollideWithBodies is deprecated. Use the CollideWithBodies property instead.")]
        public void SetCollideWithBodies(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_23, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_collide_with_bodies_enabled");

        [GodotMethod("is_collide_with_bodies_enabled")]
        [Obsolete("IsCollideWithBodiesEnabled is deprecated. Use the CollideWithBodies property instead.")]
        public bool IsCollideWithBodiesEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_debug_shape_custom_color");

        [GodotMethod("set_debug_shape_custom_color")]
        [Obsolete("SetDebugShapeCustomColor is deprecated. Use the DebugShapeCustomColor property instead.")]
        public void SetDebugShapeCustomColor(Color debugShapeCustomColor)
        {
            NativeCalls.godot_icall_1_199(method_bind_25, Object.GetPtr(this), ref debugShapeCustomColor);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_debug_shape_custom_color");

        [GodotMethod("get_debug_shape_custom_color")]
        [Obsolete("GetDebugShapeCustomColor is deprecated. Use the DebugShapeCustomColor property instead.")]
        public Color GetDebugShapeCustomColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_26, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_debug_shape_thickness");

        [GodotMethod("set_debug_shape_thickness")]
        [Obsolete("SetDebugShapeThickness is deprecated. Use the DebugShapeThickness property instead.")]
        public void SetDebugShapeThickness(int debugShapeThickness)
        {
            NativeCalls.godot_icall_1_4(method_bind_27, Object.GetPtr(this), debugShapeThickness);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_debug_shape_thickness");

        [GodotMethod("get_debug_shape_thickness")]
        [Obsolete("GetDebugShapeThickness is deprecated. Use the DebugShapeThickness property instead.")]
        public int GetDebugShapeThickness()
        {
            return NativeCalls.godot_icall_0_5(method_bind_28, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
