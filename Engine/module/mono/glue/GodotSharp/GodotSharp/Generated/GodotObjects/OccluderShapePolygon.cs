using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.OccluderShape"/>s are resources used by <see cref="Godot.Occluder"/> nodes, allowing geometric occlusion culling.</para>
    /// <para>The polygon must be a convex polygon. The polygon points can be created and deleted either in the Editor inspector or by calling <c>set_polygon_points</c>. The points of the edges can be set by dragging the handles in the Editor viewport.</para>
    /// <para>Additionally each polygon occluder can optionally support a single hole. If you add at least three points in the Editor inspector to the hole, you can drag the edge points of the hole in the Editor viewport.</para>
    /// <para>In general, the lower the number of edges in polygons and holes, the faster the system will operate at runtime, so in most cases you will want to use 4 points for each.</para>
    /// </summary>
    public partial class OccluderShapePolygon : OccluderShape
    {
        /// <summary>
        /// <para>Specifies whether the occluder should operate from both sides. If <c>false</c>, the occluder will operate one way only.</para>
        /// </summary>
        public bool TwoWay
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsTwoWay();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTwoWay(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Allows changing the polygon geometry from code.</para>
        /// </summary>
        public Vector2[] PolygonPoints
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPolygonPoints();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPolygonPoints(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Allows changing the hole geometry from code.</para>
        /// </summary>
        public Vector2[] HolePoints
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHolePoints();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHolePoints(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "OccluderShapePolygon";

        public OccluderShapePolygon() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_OccluderShapePolygon_Ctor(this);
        }

        internal OccluderShapePolygon(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_two_way");

        [GodotMethod("set_two_way")]
        [Obsolete("SetTwoWay is deprecated. Use the TwoWay property instead.")]
        public void SetTwoWay(bool twoWay)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), twoWay);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_two_way");

        [GodotMethod("is_two_way")]
        [Obsolete("IsTwoWay is deprecated. Use the TwoWay property instead.")]
        public bool IsTwoWay()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_polygon_points");

        [GodotMethod("set_polygon_points")]
        [Obsolete("SetPolygonPoints is deprecated. Use the PolygonPoints property instead.")]
        public void SetPolygonPoints(Vector2[] points)
        {
            NativeCalls.godot_icall_1_235(method_bind_2, Object.GetPtr(this), points);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_polygon_points");

        [GodotMethod("get_polygon_points")]
        [Obsolete("GetPolygonPoints is deprecated. Use the PolygonPoints property instead.")]
        public Vector2[] GetPolygonPoints()
        {
            return NativeCalls.godot_icall_0_236(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_polygon_point");

        /// <summary>
        /// <para>Sets an individual polygon point position.</para>
        /// </summary>
        [GodotMethod("set_polygon_point")]
        public void SetPolygonPoint(int index, Vector2 position)
        {
            NativeCalls.godot_icall_2_45(method_bind_4, Object.GetPtr(this), index, ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_hole_points");

        [GodotMethod("set_hole_points")]
        [Obsolete("SetHolePoints is deprecated. Use the HolePoints property instead.")]
        public void SetHolePoints(Vector2[] points)
        {
            NativeCalls.godot_icall_1_235(method_bind_5, Object.GetPtr(this), points);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_hole_points");

        [GodotMethod("get_hole_points")]
        [Obsolete("GetHolePoints is deprecated. Use the HolePoints property instead.")]
        public Vector2[] GetHolePoints()
        {
            return NativeCalls.godot_icall_0_236(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_hole_point");

        /// <summary>
        /// <para>Sets an individual hole point position.</para>
        /// </summary>
        [GodotMethod("set_hole_point")]
        public void SetHolePoint(int index, Vector2 position)
        {
            NativeCalls.godot_icall_2_45(method_bind_7, Object.GetPtr(this), index, ref position);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
