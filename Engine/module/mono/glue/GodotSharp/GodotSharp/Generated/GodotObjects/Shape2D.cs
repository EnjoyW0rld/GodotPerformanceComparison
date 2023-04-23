using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Base class for all 2D shapes. All 2D shape types inherit from this.</para>
    /// </summary>
    public abstract partial class Shape2D : Resource
    {
        /// <summary>
        /// <para>The shape's custom solver bias. Defines how much bodies react to enforce contact separation when this shape is involved.</para>
        /// <para>When set to <c>0.0</c>, the default value of <c>0.3</c> is used.</para>
        /// </summary>
        public float CustomSolverBias
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCustomSolverBias();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCustomSolverBias(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Shape2D";

        internal Shape2D() {}

        internal Shape2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_custom_solver_bias");

        [GodotMethod("set_custom_solver_bias")]
        [Obsolete("SetCustomSolverBias is deprecated. Use the CustomSolverBias property instead.")]
        public void SetCustomSolverBias(float bias)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), bias);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_custom_solver_bias");

        [GodotMethod("get_custom_solver_bias")]
        [Obsolete("GetCustomSolverBias is deprecated. Use the CustomSolverBias property instead.")]
        public float GetCustomSolverBias()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "collide");

        /// <summary>
        /// <para>Returns <c>true</c> if this shape is colliding with another.</para>
        /// <para>This method needs the transformation matrix for this shape (<c>local_xform</c>), the shape to check collisions with (<c>with_shape</c>), and the transformation matrix of that shape (<c>shape_xform</c>).</para>
        /// </summary>
        [GodotMethod("collide")]
        public bool Collide(Transform2D localXform, Shape2D withShape, Transform2D shapeXform)
        {
            return NativeCalls.godot_icall_3_854(method_bind_2, Object.GetPtr(this), ref localXform, Object.GetPtr(withShape), ref shapeXform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "collide_with_motion");

        /// <summary>
        /// <para>Returns whether this shape would collide with another, if a given movement was applied.</para>
        /// <para>This method needs the transformation matrix for this shape (<c>local_xform</c>), the movement to test on this shape (<c>local_motion</c>), the shape to check collisions with (<c>with_shape</c>), the transformation matrix of that shape (<c>shape_xform</c>), and the movement to test onto the other object (<c>shape_motion</c>).</para>
        /// </summary>
        [GodotMethod("collide_with_motion")]
        public bool CollideWithMotion(Transform2D localXform, Vector2 localMotion, Shape2D withShape, Transform2D shapeXform, Vector2 shapeMotion)
        {
            return NativeCalls.godot_icall_5_855(method_bind_3, Object.GetPtr(this), ref localXform, ref localMotion, Object.GetPtr(withShape), ref shapeXform, ref shapeMotion);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "collide_and_get_contacts");

        /// <summary>
        /// <para>Returns a list of contact point pairs where this shape touches another.</para>
        /// <para>If there are no collisions, the returned list is empty. Otherwise, the returned list contains contact points arranged in pairs, with entries alternating between points on the boundary of this shape and points on the boundary of <c>with_shape</c>.</para>
        /// <para>A collision pair A, B can be used to calculate the collision normal with <c>(B - A).normalized()</c>, and the collision depth with <c>(B - A).length()</c>. This information is typically used to separate shapes, particularly in collision solvers.</para>
        /// <para>This method needs the transformation matrix for this shape (<c>local_xform</c>), the shape to check collisions with (<c>with_shape</c>), and the transformation matrix of that shape (<c>shape_xform</c>).</para>
        /// </summary>
        [GodotMethod("collide_and_get_contacts")]
        public Godot.Collections.Array CollideAndGetContacts(Transform2D localXform, Shape2D withShape, Transform2D shapeXform)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_3_856(method_bind_4, Object.GetPtr(this), ref localXform, Object.GetPtr(withShape), ref shapeXform));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "collide_with_motion_and_get_contacts");

        /// <summary>
        /// <para>Returns a list of contact point pairs where this shape would touch another, if a given movement was applied.</para>
        /// <para>If there would be no collisions, the returned list is empty. Otherwise, the returned list contains contact points arranged in pairs, with entries alternating between points on the boundary of this shape and points on the boundary of <c>with_shape</c>.</para>
        /// <para>A collision pair A, B can be used to calculate the collision normal with <c>(B - A).normalized()</c>, and the collision depth with <c>(B - A).length()</c>. This information is typically used to separate shapes, particularly in collision solvers.</para>
        /// <para>This method needs the transformation matrix for this shape (<c>local_xform</c>), the movement to test on this shape (<c>local_motion</c>), the shape to check collisions with (<c>with_shape</c>), the transformation matrix of that shape (<c>shape_xform</c>), and the movement to test onto the other object (<c>shape_motion</c>).</para>
        /// </summary>
        [GodotMethod("collide_with_motion_and_get_contacts")]
        public Godot.Collections.Array CollideWithMotionAndGetContacts(Transform2D localXform, Vector2 localMotion, Shape2D withShape, Transform2D shapeXform, Vector2 shapeMotion)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_5_857(method_bind_5, Object.GetPtr(this), ref localXform, ref localMotion, Object.GetPtr(withShape), ref shapeXform, ref shapeMotion));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw");

        /// <summary>
        /// <para>Draws a solid shape onto a <see cref="Godot.CanvasItem"/> with the <see cref="Godot.VisualServer"/> API filled with the specified <c>color</c>. The exact drawing method is specific for each shape and cannot be configured.</para>
        /// </summary>
        [GodotMethod("draw")]
        public void Draw(RID canvasItem, Color color)
        {
            NativeCalls.godot_icall_2_858(method_bind_6, Object.GetPtr(this), RID.GetPtr(canvasItem), ref color);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
