using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Given a set of colors, this resource will interpolate them in order. This means that if you have color 1, color 2 and color 3, the gradient will interpolate from color 1 to color 2 and from color 2 to color 3. The gradient will initially have 2 colors (black and white), one (black) at gradient lower offset 0 and the other (white) at the gradient higher offset 1.</para>
    /// <para>See also <see cref="Godot.Curve"/> which supports more complex easing methods, but does not support colors.</para>
    /// </summary>
    public partial class Gradient : Resource
    {
        public enum InterpolationModeEnum
        {
            /// <summary>
            /// <para>Linear interpolation.</para>
            /// </summary>
            Linear = 0,
            /// <summary>
            /// <para>Constant interpolation, color changes abruptly at each point and stays uniform between. This might cause visible aliasing when used for a gradient texture in some cases.</para>
            /// </summary>
            Constant = 1,
            /// <summary>
            /// <para>Cubic interpolation.</para>
            /// </summary>
            Cubic = 2
        }

        /// <summary>
        /// <para>Defines how the colors between points of the gradient are interpolated. See <see cref="Godot.Gradient.InterpolationModeEnum"/> for available modes.</para>
        /// </summary>
        public Gradient.InterpolationModeEnum InterpolationMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInterpolationMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInterpolationMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Gradient's offsets returned as a <see cref="float"/>.</para>
        /// </summary>
        public float[] Offsets
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOffsets();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOffsets(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Gradient's colors returned as a <see cref="Godot.Color"/>.</para>
        /// </summary>
        public Color[] Colors
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetColors();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetColors(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Gradient";

        public Gradient() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Gradient_Ctor(this);
        }

        internal Gradient(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_point");

        /// <summary>
        /// <para>Adds the specified color to the end of the ramp, with the specified offset.</para>
        /// </summary>
        [GodotMethod("add_point")]
        public void AddPoint(float offset, Color color)
        {
            NativeCalls.godot_icall_2_463(method_bind_0, Object.GetPtr(this), offset, ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_point");

        /// <summary>
        /// <para>Removes the color at the index <c>point</c>.</para>
        /// </summary>
        [GodotMethod("remove_point")]
        public void RemovePoint(int point)
        {
            NativeCalls.godot_icall_1_4(method_bind_1, Object.GetPtr(this), point);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_offset");

        /// <summary>
        /// <para>Sets the offset for the ramp color at index <c>point</c>.</para>
        /// </summary>
        [GodotMethod("set_offset")]
        public void SetOffset(int point, float offset)
        {
            NativeCalls.godot_icall_2_34(method_bind_2, Object.GetPtr(this), point, offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_offset");

        /// <summary>
        /// <para>Returns the offset of the ramp color at index <c>point</c>.</para>
        /// </summary>
        [GodotMethod("get_offset")]
        public float GetOffset(int point)
        {
            return NativeCalls.godot_icall_1_12(method_bind_3, Object.GetPtr(this), point);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_color");

        /// <summary>
        /// <para>Sets the color of the ramp color at index <c>point</c>.</para>
        /// </summary>
        [GodotMethod("set_color")]
        public void SetColor(int point, Color color)
        {
            NativeCalls.godot_icall_2_464(method_bind_4, Object.GetPtr(this), point, ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_color");

        /// <summary>
        /// <para>Returns the color of the ramp color at index <c>point</c>.</para>
        /// </summary>
        [GodotMethod("get_color")]
        public Color GetColor(int point)
        {
            NativeCalls.godot_icall_1_465(method_bind_5, Object.GetPtr(this), point, out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "interpolate");

        /// <summary>
        /// <para>Returns the interpolated color specified by <c>offset</c>.</para>
        /// </summary>
        [GodotMethod("interpolate")]
        public Color Interpolate(float offset)
        {
            NativeCalls.godot_icall_1_466(method_bind_6, Object.GetPtr(this), offset, out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_point_count");

        /// <summary>
        /// <para>Returns the number of colors in the ramp.</para>
        /// </summary>
        [GodotMethod("get_point_count")]
        public int GetPointCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_offsets");

        [GodotMethod("set_offsets")]
        [Obsolete("SetOffsets is deprecated. Use the Offsets property instead.")]
        public void SetOffsets(float[] offsets)
        {
            NativeCalls.godot_icall_1_452(method_bind_8, Object.GetPtr(this), offsets);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_offsets");

        [GodotMethod("get_offsets")]
        [Obsolete("GetOffsets is deprecated. Use the Offsets property instead.")]
        public float[] GetOffsets()
        {
            return NativeCalls.godot_icall_0_356(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_colors");

        [GodotMethod("set_colors")]
        [Obsolete("SetColors is deprecated. Use the Colors property instead.")]
        public void SetColors(Color[] colors)
        {
            NativeCalls.godot_icall_1_231(method_bind_10, Object.GetPtr(this), colors);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_colors");

        [GodotMethod("get_colors")]
        [Obsolete("GetColors is deprecated. Use the Colors property instead.")]
        public Color[] GetColors()
        {
            return NativeCalls.godot_icall_0_232(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_interpolation_mode");

        [GodotMethod("set_interpolation_mode")]
        [Obsolete("SetInterpolationMode is deprecated. Use the InterpolationMode property instead.")]
        public void SetInterpolationMode(Gradient.InterpolationModeEnum interpolationMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_12, Object.GetPtr(this), (int)interpolationMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_interpolation_mode");

        [GodotMethod("get_interpolation_mode")]
        [Obsolete("GetInterpolationMode is deprecated. Use the InterpolationMode property instead.")]
        public Gradient.InterpolationModeEnum GetInterpolationMode()
        {
            return (Gradient.InterpolationModeEnum)NativeCalls.godot_icall_0_467(method_bind_13, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
