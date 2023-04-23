using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This class describes a Bézier curve in 2D space. It is mainly used to give a shape to a <see cref="Godot.Path2D"/>, but can be manually sampled for other purposes.</para>
    /// <para>It keeps a cache of precalculated points along the curve, to speed up further calculations.</para>
    /// </summary>
    public partial class Curve2D : Resource
    {
        /// <summary>
        /// <para>The distance in pixels between two adjacent cached points. Changing it forces the cache to be recomputed the next time the <see cref="Godot.Curve2D.GetBakedPoints"/> or <see cref="Godot.Curve2D.GetBakedLength"/> function is called. The smaller the distance, the more points in the cache and the more memory it will consume, so use with care.</para>
        /// </summary>
        public float BakeInterval
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBakeInterval();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBakeInterval(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Dictionary _Data
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetData();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetData(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Curve2D";

        public Curve2D() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Curve2D_Ctor(this);
        }

        internal Curve2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_point_count");

        /// <summary>
        /// <para>Returns the number of points describing the curve.</para>
        /// </summary>
        [GodotMethod("get_point_count")]
        public int GetPointCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_point");

        /// <summary>
        /// <para>Adds a point with the specified <c>position</c> relative to the curve's own position, with control points <c>in</c> and <c>out</c>. Appends the new point at the end of the point list.</para>
        /// <para>If <c>index</c> is given, the new point is inserted before the existing point identified by index <c>index</c>. Every existing point starting from <c>index</c> is shifted further down the list of points. The index must be greater than or equal to <c>0</c> and must not exceed the number of existing points in the line. See <see cref="Godot.Curve2D.GetPointCount"/>.</para>
        /// </summary>
        /// <param name="in">If the parameter is null, then the default value is new Vector2(0, 0)</param>
        /// <param name="out">If the parameter is null, then the default value is new Vector2(0, 0)</param>
        [GodotMethod("add_point")]
        public void AddPoint(Vector2 position, Nullable<Vector2> @in = null, Nullable<Vector2> @out = null, int index = -1)
        {
            Vector2 @in_in = @in.HasValue ? @in.Value : new Vector2(0, 0);
            Vector2 @out_in = @out.HasValue ? @out.Value : new Vector2(0, 0);
            NativeCalls.godot_icall_4_346(method_bind_1, Object.GetPtr(this), ref position, ref @in_in, ref @out_in, index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_point_position");

        /// <summary>
        /// <para>Sets the position for the vertex <c>idx</c>. If the index is out of bounds, the function sends an error to the console.</para>
        /// </summary>
        [GodotMethod("set_point_position")]
        public void SetPointPosition(int idx, Vector2 position)
        {
            NativeCalls.godot_icall_2_45(method_bind_2, Object.GetPtr(this), idx, ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_point_position");

        /// <summary>
        /// <para>Returns the position of the vertex <c>idx</c>. If the index is out of bounds, the function sends an error to the console, and returns <c>(0, 0)</c>.</para>
        /// </summary>
        [GodotMethod("get_point_position")]
        public Vector2 GetPointPosition(int idx)
        {
            NativeCalls.godot_icall_1_44(method_bind_3, Object.GetPtr(this), idx, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_point_in");

        /// <summary>
        /// <para>Sets the position of the control point leading to the vertex <c>idx</c>. If the index is out of bounds, the function sends an error to the console. The position is relative to the vertex.</para>
        /// </summary>
        [GodotMethod("set_point_in")]
        public void SetPointIn(int idx, Vector2 position)
        {
            NativeCalls.godot_icall_2_45(method_bind_4, Object.GetPtr(this), idx, ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_point_in");

        /// <summary>
        /// <para>Returns the position of the control point leading to the vertex <c>idx</c>. The returned position is relative to the vertex <c>idx</c>. If the index is out of bounds, the function sends an error to the console, and returns <c>(0, 0)</c>.</para>
        /// </summary>
        [GodotMethod("get_point_in")]
        public Vector2 GetPointIn(int idx)
        {
            NativeCalls.godot_icall_1_44(method_bind_5, Object.GetPtr(this), idx, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_point_out");

        /// <summary>
        /// <para>Sets the position of the control point leading out of the vertex <c>idx</c>. If the index is out of bounds, the function sends an error to the console. The position is relative to the vertex.</para>
        /// </summary>
        [GodotMethod("set_point_out")]
        public void SetPointOut(int idx, Vector2 position)
        {
            NativeCalls.godot_icall_2_45(method_bind_6, Object.GetPtr(this), idx, ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_point_out");

        /// <summary>
        /// <para>Returns the position of the control point leading out of the vertex <c>idx</c>. The returned position is relative to the vertex <c>idx</c>. If the index is out of bounds, the function sends an error to the console, and returns <c>(0, 0)</c>.</para>
        /// </summary>
        [GodotMethod("get_point_out")]
        public Vector2 GetPointOut(int idx)
        {
            NativeCalls.godot_icall_1_44(method_bind_7, Object.GetPtr(this), idx, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_point");

        /// <summary>
        /// <para>Deletes the point <c>idx</c> from the curve. Sends an error to the console if <c>idx</c> is out of bounds.</para>
        /// </summary>
        [GodotMethod("remove_point")]
        public void RemovePoint(int idx)
        {
            NativeCalls.godot_icall_1_4(method_bind_8, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_points");

        /// <summary>
        /// <para>Removes all points from the curve.</para>
        /// </summary>
        [GodotMethod("clear_points")]
        public void ClearPoints()
        {
            NativeCalls.godot_icall_0_3(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "interpolate");

        /// <summary>
        /// <para>Returns the position between the vertex <c>idx</c> and the vertex <c>idx + 1</c>, where <c>t</c> controls if the point is the first vertex (<c>t = 0.0</c>), the last vertex (<c>t = 1.0</c>), or in between. Values of <c>t</c> outside the range (<c>0.0 &gt;= t &lt;=1</c>) give strange, but predictable results.</para>
        /// <para>If <c>idx</c> is out of bounds it is truncated to the first or last vertex, and <c>t</c> is ignored. If the curve has no points, the function sends an error to the console, and returns <c>(0, 0)</c>.</para>
        /// </summary>
        [GodotMethod("interpolate")]
        public Vector2 Interpolate(int idx, float t)
        {
            NativeCalls.godot_icall_2_347(method_bind_10, Object.GetPtr(this), idx, t, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "interpolatef");

        /// <summary>
        /// <para>Returns the position at the vertex <c>fofs</c>. It calls <see cref="Godot.Curve2D.Interpolate"/> using the integer part of <c>fofs</c> as <c>idx</c>, and its fractional part as <c>t</c>.</para>
        /// </summary>
        [GodotMethod("interpolatef")]
        public Vector2 Interpolatef(float fofs)
        {
            NativeCalls.godot_icall_1_348(method_bind_11, Object.GetPtr(this), fofs, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bake_interval");

        [GodotMethod("set_bake_interval")]
        [Obsolete("SetBakeInterval is deprecated. Use the BakeInterval property instead.")]
        public void SetBakeInterval(float distance)
        {
            NativeCalls.godot_icall_1_15(method_bind_12, Object.GetPtr(this), distance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bake_interval");

        [GodotMethod("get_bake_interval")]
        [Obsolete("GetBakeInterval is deprecated. Use the BakeInterval property instead.")]
        public float GetBakeInterval()
        {
            return NativeCalls.godot_icall_0_14(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_baked_length");

        /// <summary>
        /// <para>Returns the total length of the curve, based on the cached points. Given enough density (see <see cref="Godot.Curve2D.BakeInterval"/>), it should be approximate enough.</para>
        /// </summary>
        [GodotMethod("get_baked_length")]
        public float GetBakedLength()
        {
            return NativeCalls.godot_icall_0_14(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "interpolate_baked");

        /// <summary>
        /// <para>Returns a point within the curve at position <c>offset</c>, where <c>offset</c> is measured as a pixel distance along the curve.</para>
        /// <para>To do that, it finds the two cached points where the <c>offset</c> lies between, then interpolates the values. This interpolation is cubic if <c>cubic</c> is set to <c>true</c>, or linear if set to <c>false</c>.</para>
        /// <para>Cubic interpolation tends to follow the curves better, but linear is faster (and often, precise enough).</para>
        /// </summary>
        [GodotMethod("interpolate_baked")]
        public Vector2 InterpolateBaked(float offset, bool cubic = false)
        {
            NativeCalls.godot_icall_2_349(method_bind_15, Object.GetPtr(this), offset, cubic, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_baked_points");

        /// <summary>
        /// <para>Returns the cache of points as a <see cref="Godot.Vector2"/>.</para>
        /// </summary>
        [GodotMethod("get_baked_points")]
        public Vector2[] GetBakedPoints()
        {
            return NativeCalls.godot_icall_0_236(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_closest_point");

        /// <summary>
        /// <para>Returns the closest baked point (in curve's local space) to <c>to_point</c>.</para>
        /// <para><c>to_point</c> must be in this curve's local space.</para>
        /// </summary>
        [GodotMethod("get_closest_point")]
        public Vector2 GetClosestPoint(Vector2 toPoint)
        {
            NativeCalls.godot_icall_1_47(method_bind_17, Object.GetPtr(this), ref toPoint, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_closest_offset");

        /// <summary>
        /// <para>Returns the closest offset to <c>to_point</c>. This offset is meant to be used in <see cref="Godot.Curve2D.InterpolateBaked"/>.</para>
        /// <para><c>to_point</c> must be in this curve's local space.</para>
        /// </summary>
        [GodotMethod("get_closest_offset")]
        public float GetClosestOffset(Vector2 toPoint)
        {
            return NativeCalls.godot_icall_1_350(method_bind_18, Object.GetPtr(this), ref toPoint);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tessellate");

        /// <summary>
        /// <para>Returns a list of points along the curve, with a curvature controlled point density. That is, the curvier parts will have more points than the straighter parts.</para>
        /// <para>This approximation makes straight segments between each point, then subdivides those segments until the resulting shape is similar enough.</para>
        /// <para><c>max_stages</c> controls how many subdivisions a curve segment may face before it is considered approximate enough. Each subdivision splits the segment in half, so the default 5 stages may mean up to 32 subdivisions per curve segment. Increase with care!</para>
        /// <para><c>tolerance_degrees</c> controls how many degrees the midpoint of a segment may deviate from the real curve, before the segment has to be subdivided.</para>
        /// </summary>
        [GodotMethod("tessellate")]
        public Vector2[] Tessellate(int maxStages = 5, float toleranceDegrees = (float)4)
        {
            return NativeCalls.godot_icall_2_351(method_bind_19, Object.GetPtr(this), maxStages, toleranceDegrees);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_data");

        [Obsolete("_GetData is deprecated. Use the _Data property instead.")]
        internal Godot.Collections.Dictionary _GetData()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_20, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_data");

        [Obsolete("_SetData is deprecated. Use the _Data property instead.")]
        internal void _SetData(Godot.Collections.Dictionary arg0)
        {
            NativeCalls.godot_icall_1_213(method_bind_21, Object.GetPtr(this), arg0.GetPtr());
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
