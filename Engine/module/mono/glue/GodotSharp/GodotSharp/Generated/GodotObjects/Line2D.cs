using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A line through several points in 2D space. Supports varying width and color over the line's length, texturing, and several cap/joint types.</para>
    /// <para>Note: By default, Godot can only draw up to 4,096 polygon points at a time. To increase this limit, open the Project Settings and increase  and .</para>
    /// </summary>
    public partial class Line2D : Node2D
    {
        public enum LineTextureMode
        {
            /// <summary>
            /// <para>Takes the left pixels of the texture and renders it over the whole line.</para>
            /// </summary>
            None = 0,
            /// <summary>
            /// <para>Tiles the texture over the line. The texture must be imported with Repeat enabled for it to work properly.</para>
            /// </summary>
            Tile = 1,
            /// <summary>
            /// <para>Stretches the texture across the line. Import the texture with Repeat disabled for best results.</para>
            /// </summary>
            Stretch = 2
        }

        public enum LineCapMode
        {
            /// <summary>
            /// <para>Don't draw a line cap.</para>
            /// </summary>
            None = 0,
            /// <summary>
            /// <para>Draws the line cap as a box.</para>
            /// </summary>
            Box = 1,
            /// <summary>
            /// <para>Draws the line cap as a circle.</para>
            /// </summary>
            Round = 2
        }

        public enum LineJointMode
        {
            /// <summary>
            /// <para>The line's joints will be pointy. If <c>sharp_limit</c> is greater than the rotation of a joint, it becomes a bevel joint instead.</para>
            /// </summary>
            Sharp = 0,
            /// <summary>
            /// <para>The line's joints will be bevelled/chamfered.</para>
            /// </summary>
            Bevel = 1,
            /// <summary>
            /// <para>The line's joints will be rounded.</para>
            /// </summary>
            Round = 2
        }

        /// <summary>
        /// <para>The points that form the lines. The line is drawn between every point set in this array. Points are interpreted as local vectors.</para>
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

        /// <summary>
        /// <para>The line's width.</para>
        /// </summary>
        public float Width
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetWidth();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetWidth(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The line's width varies with the curve. The original width is simply multiply by the value of the Curve.</para>
        /// </summary>
        public Curve WidthCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCurve();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCurve(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The line's color. Will not be used if a gradient is set.</para>
        /// </summary>
        public Color DefaultColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDefaultColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDefaultColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The gradient is drawn through the whole line from start to finish. The default color will not be used if a gradient is set.</para>
        /// </summary>
        public Gradient Gradient
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGradient();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGradient(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The texture used for the line's texture. Uses <c>texture_mode</c> for drawing style.</para>
        /// </summary>
        public Texture Texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexture();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexture(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The style to render the <c>texture</c> on the line. Use <see cref="Godot.Line2D.LineTextureMode"/> constants.</para>
        /// </summary>
        public Line2D.LineTextureMode TextureMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTextureMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTextureMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The style for the points between the start and the end.</para>
        /// </summary>
        public Line2D.LineJointMode JointMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetJointMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetJointMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Controls the style of the line's first point. Use <see cref="Godot.Line2D.LineCapMode"/> constants.</para>
        /// </summary>
        public Line2D.LineCapMode BeginCapMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBeginCapMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBeginCapMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Controls the style of the line's last point. Use <see cref="Godot.Line2D.LineCapMode"/> constants.</para>
        /// </summary>
        public Line2D.LineCapMode EndCapMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEndCapMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEndCapMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The direction difference in radians between vector points. This value is only used if <see cref="Godot.Line2D.JointMode"/> is set to <see cref="Godot.Line2D.LineJointMode.Sharp"/>.</para>
        /// </summary>
        public float SharpLimit
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSharpLimit();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSharpLimit(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The smoothness of the rounded joints and caps. Higher values result in smoother corners, but are more demanding to render and update. This is only used if a cap or joint is set as round.</para>
        /// <para>Note: The default value is tuned for lines with the default <see cref="Godot.Line2D.Width"/>. For thin lines, this value should be reduced to a number between <c>2</c> and <c>4</c> to improve performance.</para>
        /// </summary>
        public int RoundPrecision
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRoundPrecision();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRoundPrecision(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the line's border will attempt to perform antialiasing by drawing thin OpenGL smooth lines on the line's edges.</para>
        /// <para>Note: Line2D is not accelerated by batching if <see cref="Godot.Line2D.Antialiased"/> is <c>true</c>.</para>
        /// <para>Note: Due to how it works, built-in antialiasing will not look correct for translucent lines and may not work on certain platforms. As a workaround, install the <a href="https://github.com/godot-extended-libraries/godot-antialiased-line2d">Antialiased Line2D</a> add-on then create an AntialiasedLine2D node. That node relies on a texture with custom mipmaps to perform antialiasing. 2D batching is also still supported with those antialiased lines.</para>
        /// </summary>
        public bool Antialiased
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAntialiased();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAntialiased(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Line2D";

        public Line2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Line2D_Ctor(this);
        }

        internal Line2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_points");

        [GodotMethod("set_points")]
        [Obsolete("SetPoints is deprecated. Use the Points property instead.")]
        public void SetPoints(Vector2[] points)
        {
            NativeCalls.godot_icall_1_235(method_bind_0, Object.GetPtr(this), points);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_points");

        [GodotMethod("get_points")]
        [Obsolete("GetPoints is deprecated. Use the Points property instead.")]
        public Vector2[] GetPoints()
        {
            return NativeCalls.godot_icall_0_236(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_point_position");

        /// <summary>
        /// <para>Overwrites the position of the point at index <c>index</c> with the supplied <c>position</c>.</para>
        /// </summary>
        [GodotMethod("set_point_position")]
        public void SetPointPosition(int index, Vector2 position)
        {
            NativeCalls.godot_icall_2_45(method_bind_2, Object.GetPtr(this), index, ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_point_position");

        /// <summary>
        /// <para>Returns the position of the point at index <c>index</c>.</para>
        /// </summary>
        [GodotMethod("get_point_position")]
        public Vector2 GetPointPosition(int index)
        {
            NativeCalls.godot_icall_1_44(method_bind_3, Object.GetPtr(this), index, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_point_count");

        /// <summary>
        /// <para>Returns the amount of points in the line.</para>
        /// </summary>
        [GodotMethod("get_point_count")]
        public int GetPointCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_point");

        /// <summary>
        /// <para>Adds a point with the specified <c>position</c> relative to the line's own position. Appends the new point at the end of the point list.</para>
        /// <para>If <c>index</c> is given, the new point is inserted before the existing point identified by index <c>index</c>. Every existing point starting from <c>index</c> is shifted further down the list of points. The index must be greater than or equal to <c>0</c> and must not exceed the number of existing points in the line. See <see cref="Godot.Line2D.GetPointCount"/>.</para>
        /// </summary>
        [GodotMethod("add_point")]
        public void AddPoint(Vector2 position, int index = -1)
        {
            NativeCalls.godot_icall_2_586(method_bind_5, Object.GetPtr(this), ref position, index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_point");

        /// <summary>
        /// <para>Removes the point at index <c>index</c> from the line.</para>
        /// </summary>
        [GodotMethod("remove_point")]
        public void RemovePoint(int index)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_points");

        /// <summary>
        /// <para>Removes all points from the line.</para>
        /// </summary>
        [GodotMethod("clear_points")]
        public void ClearPoints()
        {
            NativeCalls.godot_icall_0_3(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_width");

        [GodotMethod("set_width")]
        [Obsolete("SetWidth is deprecated. Use the Width property instead.")]
        public void SetWidth(float width)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), width);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_width");

        [GodotMethod("get_width")]
        [Obsolete("GetWidth is deprecated. Use the Width property instead.")]
        public float GetWidth()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_curve");

        [GodotMethod("set_curve")]
        [Obsolete("SetCurve is deprecated. Use the WidthCurve property instead.")]
        public void SetCurve(Curve curve)
        {
            NativeCalls.godot_icall_1_24(method_bind_10, Object.GetPtr(this), Object.GetPtr(curve));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_curve");

        [GodotMethod("get_curve")]
        [Obsolete("GetCurve is deprecated. Use the WidthCurve property instead.")]
        public Curve GetCurve()
        {
            return NativeCalls.godot_icall_0_359(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_default_color");

        [GodotMethod("set_default_color")]
        [Obsolete("SetDefaultColor is deprecated. Use the DefaultColor property instead.")]
        public void SetDefaultColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_12, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_default_color");

        [GodotMethod("get_default_color")]
        [Obsolete("GetDefaultColor is deprecated. Use the DefaultColor property instead.")]
        public Color GetDefaultColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_13, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_gradient");

        [GodotMethod("set_gradient")]
        [Obsolete("SetGradient is deprecated. Use the Gradient property instead.")]
        public void SetGradient(Gradient color)
        {
            NativeCalls.godot_icall_1_24(method_bind_14, Object.GetPtr(this), Object.GetPtr(color));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_gradient");

        [GodotMethod("get_gradient")]
        [Obsolete("GetGradient is deprecated. Use the Gradient property instead.")]
        public Gradient GetGradient()
        {
            return NativeCalls.godot_icall_0_227(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture");

        [GodotMethod("set_texture")]
        [Obsolete("SetTexture is deprecated. Use the Texture property instead.")]
        public void SetTexture(Texture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_16, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture");

        [GodotMethod("get_texture")]
        [Obsolete("GetTexture is deprecated. Use the Texture property instead.")]
        public Texture GetTexture()
        {
            return NativeCalls.godot_icall_0_161(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture_mode");

        [GodotMethod("set_texture_mode")]
        [Obsolete("SetTextureMode is deprecated. Use the TextureMode property instead.")]
        public void SetTextureMode(Line2D.LineTextureMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_18, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture_mode");

        [GodotMethod("get_texture_mode")]
        [Obsolete("GetTextureMode is deprecated. Use the TextureMode property instead.")]
        public Line2D.LineTextureMode GetTextureMode()
        {
            return (Line2D.LineTextureMode)NativeCalls.godot_icall_0_587(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_joint_mode");

        [GodotMethod("set_joint_mode")]
        [Obsolete("SetJointMode is deprecated. Use the JointMode property instead.")]
        public void SetJointMode(Line2D.LineJointMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_20, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_joint_mode");

        [GodotMethod("get_joint_mode")]
        [Obsolete("GetJointMode is deprecated. Use the JointMode property instead.")]
        public Line2D.LineJointMode GetJointMode()
        {
            return (Line2D.LineJointMode)NativeCalls.godot_icall_0_588(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_begin_cap_mode");

        [GodotMethod("set_begin_cap_mode")]
        [Obsolete("SetBeginCapMode is deprecated. Use the BeginCapMode property instead.")]
        public void SetBeginCapMode(Line2D.LineCapMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_22, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_begin_cap_mode");

        [GodotMethod("get_begin_cap_mode")]
        [Obsolete("GetBeginCapMode is deprecated. Use the BeginCapMode property instead.")]
        public Line2D.LineCapMode GetBeginCapMode()
        {
            return (Line2D.LineCapMode)NativeCalls.godot_icall_0_589(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_end_cap_mode");

        [GodotMethod("set_end_cap_mode")]
        [Obsolete("SetEndCapMode is deprecated. Use the EndCapMode property instead.")]
        public void SetEndCapMode(Line2D.LineCapMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_24, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_end_cap_mode");

        [GodotMethod("get_end_cap_mode")]
        [Obsolete("GetEndCapMode is deprecated. Use the EndCapMode property instead.")]
        public Line2D.LineCapMode GetEndCapMode()
        {
            return (Line2D.LineCapMode)NativeCalls.godot_icall_0_589(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sharp_limit");

        [GodotMethod("set_sharp_limit")]
        [Obsolete("SetSharpLimit is deprecated. Use the SharpLimit property instead.")]
        public void SetSharpLimit(float limit)
        {
            NativeCalls.godot_icall_1_15(method_bind_26, Object.GetPtr(this), limit);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sharp_limit");

        [GodotMethod("get_sharp_limit")]
        [Obsolete("GetSharpLimit is deprecated. Use the SharpLimit property instead.")]
        public float GetSharpLimit()
        {
            return NativeCalls.godot_icall_0_14(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_round_precision");

        [GodotMethod("set_round_precision")]
        [Obsolete("SetRoundPrecision is deprecated. Use the RoundPrecision property instead.")]
        public void SetRoundPrecision(int precision)
        {
            NativeCalls.godot_icall_1_4(method_bind_28, Object.GetPtr(this), precision);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_round_precision");

        [GodotMethod("get_round_precision")]
        [Obsolete("GetRoundPrecision is deprecated. Use the RoundPrecision property instead.")]
        public int GetRoundPrecision()
        {
            return NativeCalls.godot_icall_0_5(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_antialiased");

        [GodotMethod("set_antialiased")]
        [Obsolete("SetAntialiased is deprecated. Use the Antialiased property instead.")]
        public void SetAntialiased(bool antialiased)
        {
            NativeCalls.godot_icall_1_16(method_bind_30, Object.GetPtr(this), antialiased);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_antialiased");

        [GodotMethod("get_antialiased")]
        [Obsolete("GetAntialiased is deprecated. Use the Antialiased property instead.")]
        public bool GetAntialiased()
        {
            return NativeCalls.godot_icall_0_7(method_bind_31, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
