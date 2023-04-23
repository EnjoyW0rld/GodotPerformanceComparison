using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A curve that can be saved and re-used for other objects. By default, it ranges between <c>0</c> and <c>1</c> on the Y axis and positions points relative to the <c>0.5</c> Y position.</para>
    /// <para>See also <see cref="Godot.Gradient"/> which is designed for color interpolation. See also <see cref="Godot.Curve2D"/> and <see cref="Godot.Curve3D"/>.</para>
    /// </summary>
    public partial class Curve : Resource
    {
        public enum TangentMode
        {
            /// <summary>
            /// <para>The tangent on this side of the point is user-defined.</para>
            /// </summary>
            Free = 0,
            /// <summary>
            /// <para>The curve calculates the tangent on this side of the point as the slope halfway towards the adjacent point.</para>
            /// </summary>
            Linear = 1,
            /// <summary>
            /// <para>The total number of available tangent modes.</para>
            /// </summary>
            ModeCount = 2
        }

        /// <summary>
        /// <para>The minimum value the curve can reach.</para>
        /// </summary>
        public float MinValue
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMinValue();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMinValue(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum value the curve can reach.</para>
        /// </summary>
        public float MaxValue
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaxValue();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaxValue(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The number of points to include in the baked (i.e. cached) curve data.</para>
        /// </summary>
        public int BakeResolution
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBakeResolution();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBakeResolution(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array _Data
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

        private const string nativeName = "Curve";

        public Curve() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Curve_Ctor(this);
        }

        internal Curve(bool memoryOwn) : base(memoryOwn) {}

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
        /// <para>Adds a point to the curve. For each side, if the <c>*_mode</c> is <see cref="Godot.Curve.TangentMode.Linear"/>, the <c>*_tangent</c> angle (in degrees) uses the slope of the curve halfway to the adjacent point. Allows custom assignments to the <c>*_tangent</c> angle if <c>*_mode</c> is set to <see cref="Godot.Curve.TangentMode.Free"/>.</para>
        /// </summary>
        [GodotMethod("add_point")]
        public int AddPoint(Vector2 position, float leftTangent = (float)0, float rightTangent = (float)0, Curve.TangentMode leftMode = (Curve.TangentMode)0, Curve.TangentMode rightMode = (Curve.TangentMode)0)
        {
            return NativeCalls.godot_icall_5_342(method_bind_1, Object.GetPtr(this), ref position, leftTangent, rightTangent, (int)leftMode, (int)rightMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_point");

        /// <summary>
        /// <para>Removes the point at <c>index</c> from the curve.</para>
        /// </summary>
        [GodotMethod("remove_point")]
        public void RemovePoint(int index)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_points");

        /// <summary>
        /// <para>Removes all points from the curve.</para>
        /// </summary>
        [GodotMethod("clear_points")]
        public void ClearPoints()
        {
            NativeCalls.godot_icall_0_3(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_point_position");

        /// <summary>
        /// <para>Returns the curve coordinates for the point at <c>index</c>.</para>
        /// </summary>
        [GodotMethod("get_point_position")]
        public Vector2 GetPointPosition(int index)
        {
            NativeCalls.godot_icall_1_44(method_bind_4, Object.GetPtr(this), index, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_point_value");

        /// <summary>
        /// <para>Assigns the vertical position <c>y</c> to the point at <c>index</c>.</para>
        /// </summary>
        [GodotMethod("set_point_value")]
        public void SetPointValue(int index, float y)
        {
            NativeCalls.godot_icall_2_34(method_bind_5, Object.GetPtr(this), index, y);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_point_offset");

        /// <summary>
        /// <para>Sets the offset from <c>0.5</c>.</para>
        /// </summary>
        [GodotMethod("set_point_offset")]
        public int SetPointOffset(int index, float offset)
        {
            return NativeCalls.godot_icall_2_343(method_bind_6, Object.GetPtr(this), index, offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "interpolate");

        /// <summary>
        /// <para>Returns the Y value for the point that would exist at the X position <c>offset</c> along the curve.</para>
        /// </summary>
        [GodotMethod("interpolate")]
        public float Interpolate(float offset)
        {
            return NativeCalls.godot_icall_1_344(method_bind_7, Object.GetPtr(this), offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "interpolate_baked");

        /// <summary>
        /// <para>Returns the Y value for the point that would exist at the X position <c>offset</c> along the curve using the baked cache. Bakes the curve's points if not already baked.</para>
        /// </summary>
        [GodotMethod("interpolate_baked")]
        public float InterpolateBaked(float offset)
        {
            return NativeCalls.godot_icall_1_344(method_bind_8, Object.GetPtr(this), offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_point_left_tangent");

        /// <summary>
        /// <para>Returns the left tangent angle (in degrees) for the point at <c>index</c>.</para>
        /// </summary>
        [GodotMethod("get_point_left_tangent")]
        public float GetPointLeftTangent(int index)
        {
            return NativeCalls.godot_icall_1_12(method_bind_9, Object.GetPtr(this), index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_point_right_tangent");

        /// <summary>
        /// <para>Returns the right tangent angle (in degrees) for the point at <c>index</c>.</para>
        /// </summary>
        [GodotMethod("get_point_right_tangent")]
        public float GetPointRightTangent(int index)
        {
            return NativeCalls.godot_icall_1_12(method_bind_10, Object.GetPtr(this), index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_point_left_mode");

        /// <summary>
        /// <para>Returns the left <see cref="Godot.Curve.TangentMode"/> for the point at <c>index</c>.</para>
        /// </summary>
        [GodotMethod("get_point_left_mode")]
        public Curve.TangentMode GetPointLeftMode(int index)
        {
            return (Curve.TangentMode)NativeCalls.godot_icall_1_345(method_bind_11, Object.GetPtr(this), index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_point_right_mode");

        /// <summary>
        /// <para>Returns the right <see cref="Godot.Curve.TangentMode"/> for the point at <c>index</c>.</para>
        /// </summary>
        [GodotMethod("get_point_right_mode")]
        public Curve.TangentMode GetPointRightMode(int index)
        {
            return (Curve.TangentMode)NativeCalls.godot_icall_1_345(method_bind_12, Object.GetPtr(this), index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_point_left_tangent");

        /// <summary>
        /// <para>Sets the left tangent angle for the point at <c>index</c> to <c>tangent</c>.</para>
        /// </summary>
        [GodotMethod("set_point_left_tangent")]
        public void SetPointLeftTangent(int index, float tangent)
        {
            NativeCalls.godot_icall_2_34(method_bind_13, Object.GetPtr(this), index, tangent);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_point_right_tangent");

        /// <summary>
        /// <para>Sets the right tangent angle for the point at <c>index</c> to <c>tangent</c>.</para>
        /// </summary>
        [GodotMethod("set_point_right_tangent")]
        public void SetPointRightTangent(int index, float tangent)
        {
            NativeCalls.godot_icall_2_34(method_bind_14, Object.GetPtr(this), index, tangent);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_point_left_mode");

        /// <summary>
        /// <para>Sets the left <see cref="Godot.Curve.TangentMode"/> for the point at <c>index</c> to <c>mode</c>.</para>
        /// </summary>
        [GodotMethod("set_point_left_mode")]
        public void SetPointLeftMode(int index, Curve.TangentMode mode)
        {
            NativeCalls.godot_icall_2_65(method_bind_15, Object.GetPtr(this), index, (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_point_right_mode");

        /// <summary>
        /// <para>Sets the right <see cref="Godot.Curve.TangentMode"/> for the point at <c>index</c> to <c>mode</c>.</para>
        /// </summary>
        [GodotMethod("set_point_right_mode")]
        public void SetPointRightMode(int index, Curve.TangentMode mode)
        {
            NativeCalls.godot_icall_2_65(method_bind_16, Object.GetPtr(this), index, (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_min_value");

        [GodotMethod("get_min_value")]
        [Obsolete("GetMinValue is deprecated. Use the MinValue property instead.")]
        public float GetMinValue()
        {
            return NativeCalls.godot_icall_0_14(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_min_value");

        [GodotMethod("set_min_value")]
        [Obsolete("SetMinValue is deprecated. Use the MinValue property instead.")]
        public void SetMinValue(float min)
        {
            NativeCalls.godot_icall_1_15(method_bind_18, Object.GetPtr(this), min);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max_value");

        [GodotMethod("get_max_value")]
        [Obsolete("GetMaxValue is deprecated. Use the MaxValue property instead.")]
        public float GetMaxValue()
        {
            return NativeCalls.godot_icall_0_14(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max_value");

        [GodotMethod("set_max_value")]
        [Obsolete("SetMaxValue is deprecated. Use the MaxValue property instead.")]
        public void SetMaxValue(float max)
        {
            NativeCalls.godot_icall_1_15(method_bind_20, Object.GetPtr(this), max);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clean_dupes");

        /// <summary>
        /// <para>Removes points that are closer than <c>CMP_EPSILON</c> (0.00001) units to their neighbor on the curve.</para>
        /// </summary>
        [GodotMethod("clean_dupes")]
        public void CleanDupes()
        {
            NativeCalls.godot_icall_0_3(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "bake");

        /// <summary>
        /// <para>Recomputes the baked cache of points for the curve.</para>
        /// </summary>
        [GodotMethod("bake")]
        public void Bake()
        {
            NativeCalls.godot_icall_0_3(method_bind_22, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bake_resolution");

        [GodotMethod("get_bake_resolution")]
        [Obsolete("GetBakeResolution is deprecated. Use the BakeResolution property instead.")]
        public int GetBakeResolution()
        {
            return NativeCalls.godot_icall_0_5(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bake_resolution");

        [GodotMethod("set_bake_resolution")]
        [Obsolete("SetBakeResolution is deprecated. Use the BakeResolution property instead.")]
        public void SetBakeResolution(int resolution)
        {
            NativeCalls.godot_icall_1_4(method_bind_24, Object.GetPtr(this), resolution);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_data");

        [Obsolete("_GetData is deprecated. Use the _Data property instead.")]
        internal Godot.Collections.Array _GetData()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_25, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_data");

        [Obsolete("_SetData is deprecated. Use the _Data property instead.")]
        internal void _SetData(Godot.Collections.Array data)
        {
            NativeCalls.godot_icall_1_92(method_bind_26, Object.GetPtr(this), data.GetPtr());
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
