using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Editor facility for creating and editing collision shapes in 3D space. Set the <see cref="Godot.CollisionShape.Shape"/> property to configure the shape. IMPORTANT: this is an Editor-only helper to create shapes, use <see cref="Godot.CollisionObject.ShapeOwnerGetShape"/> to get the actual shape.</para>
    /// <para>You can use this node to represent all sorts of collision shapes, for example, add this to an <see cref="Godot.Area"/> to give it a detection shape, or add it to a <see cref="Godot.PhysicsBody"/> to create a solid object.</para>
    /// </summary>
    public partial class CollisionShape : Spatial
    {
        /// <summary>
        /// <para>The actual shape owned by this collision shape.</para>
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
        /// <para>A disabled collision shape has no effect in the world.</para>
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

        private const string nativeName = "CollisionShape";

        public CollisionShape() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CollisionShape_Ctor(this);
        }

        internal CollisionShape(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "resource_changed");

        /// <summary>
        /// <para>If this method exists within a script it will be called whenever the shape resource has been modified.</para>
        /// </summary>
        [GodotMethod("resource_changed")]
        public void ResourceChanged(Resource resource)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(resource));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shape");

        [GodotMethod("set_shape")]
        [Obsolete("SetShape is deprecated. Use the Shape property instead.")]
        public void SetShape(Shape shape)
        {
            NativeCalls.godot_icall_1_24(method_bind_1, Object.GetPtr(this), Object.GetPtr(shape));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shape");

        [GodotMethod("get_shape")]
        [Obsolete("GetShape is deprecated. Use the Shape property instead.")]
        public Shape GetShape()
        {
            return NativeCalls.godot_icall_0_303(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_disabled");

        [GodotMethod("set_disabled")]
        [Obsolete("SetDisabled is deprecated. Use the Disabled property instead.")]
        public void SetDisabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_3, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_disabled");

        [GodotMethod("is_disabled")]
        [Obsolete("IsDisabled is deprecated. Use the Disabled property instead.")]
        public bool IsDisabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "make_convex_from_brothers");

        /// <summary>
        /// <para>Sets the collision shape's shape to the addition of all its convexed <see cref="Godot.MeshInstance"/> siblings geometry.</para>
        /// </summary>
        [GodotMethod("make_convex_from_brothers")]
        public void MakeConvexFromBrothers()
        {
            NativeCalls.godot_icall_0_3(method_bind_5, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
