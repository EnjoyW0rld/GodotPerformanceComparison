using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Convex polygon shape resource, which can be added to a <see cref="Godot.PhysicsBody"/> or area.</para>
    /// </summary>
    public partial class ConvexPolygonShape : Shape
    {
        /// <summary>
        /// <para>The list of 3D points forming the convex polygon shape.</para>
        /// </summary>
        public Vector3[] Points
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPoints();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPoints(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ConvexPolygonShape";

        public ConvexPolygonShape() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ConvexPolygonShape_Ctor(this);
        }

        internal ConvexPolygonShape(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_points");

        [GodotMethod("set_points")]
        [Obsolete("SetPoints is deprecated. Use the Points property instead.")]
        public void SetPoints(Vector3[] points)
        {
            NativeCalls.godot_icall_1_229(method_bind_0, Object.GetPtr(this), points);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_points");

        [GodotMethod("get_points")]
        [Obsolete("GetPoints is deprecated. Use the Points property instead.")]
        public Vector3[] GetPoints()
        {
            return NativeCalls.godot_icall_0_230(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
