using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Convex polygon shape for 2D physics. A convex polygon, whatever its shape, is internally decomposed into as many convex polygons as needed to ensure all collision checks against it are always done on convex polygons (which are faster to check).</para>
    /// <para>The main difference between a <see cref="Godot.ConvexPolygonShape2D"/> and a <see cref="Godot.ConcavePolygonShape2D"/> is that a concave polygon assumes it is concave and uses a more complex method of collision detection, and a convex one forces itself to be convex in order to speed up collision detection.</para>
    /// </summary>
    public partial class ConvexPolygonShape2D : Shape2D
    {
        /// <summary>
        /// <para>The polygon's list of vertices. Can be in either clockwise or counterclockwise order. Only set this property with convex hull points, use <see cref="Godot.ConvexPolygonShape2D.SetPointCloud"/> to generate a convex hull shape from concave shape points.</para>
        /// </summary>
        public Vector2[] Points
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

        private const string nativeName = "ConvexPolygonShape2D";

        public ConvexPolygonShape2D() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ConvexPolygonShape2D_Ctor(this);
        }

        internal ConvexPolygonShape2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_point_cloud");

        /// <summary>
        /// <para>Based on the set of points provided, this creates and assigns the <see cref="Godot.ConvexPolygonShape2D.Points"/> property using the convex hull algorithm. Removing all unneeded points. See <see cref="Godot.Geometry.ConvexHull2d"/> for details.</para>
        /// </summary>
        [GodotMethod("set_point_cloud")]
        public void SetPointCloud(Vector2[] pointCloud)
        {
            NativeCalls.godot_icall_1_235(method_bind_0, Object.GetPtr(this), pointCloud);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_points");

        [GodotMethod("set_points")]
        [Obsolete("SetPoints is deprecated. Use the Points property instead.")]
        public void SetPoints(Vector2[] points)
        {
            NativeCalls.godot_icall_1_235(method_bind_1, Object.GetPtr(this), points);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_points");

        [GodotMethod("get_points")]
        [Obsolete("GetPoints is deprecated. Use the Points property instead.")]
        public Vector2[] GetPoints()
        {
            return NativeCalls.godot_icall_0_236(method_bind_2, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
