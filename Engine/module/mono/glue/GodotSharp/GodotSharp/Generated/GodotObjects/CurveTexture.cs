using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Renders a given <see cref="Godot.Curve"/> provided to it. Simplifies the task of drawing curves and/or saving them as image files.</para>
    /// </summary>
    public partial class CurveTexture : Texture
    {
        /// <summary>
        /// <para>The width of the texture (in pixels). Higher values make it possible to represent high-frequency data better (such as sudden direction changes), at the cost of increased generation time and memory usage.</para>
        /// </summary>
        public int Width
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
        /// <para>The <see cref="Godot.Curve"/> that is rendered onto the texture.</para>
        /// </summary>
        public Curve Curve
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

        private const string nativeName = "CurveTexture";

        public CurveTexture() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CurveTexture_Ctor(this);
        }

        internal CurveTexture(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_width");

        [GodotMethod("set_width")]
        [Obsolete("SetWidth is deprecated. Use the Width property instead.")]
        public void SetWidth(int width)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), width);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_curve");

        [GodotMethod("set_curve")]
        [Obsolete("SetCurve is deprecated. Use the Curve property instead.")]
        public void SetCurve(Curve curve)
        {
            NativeCalls.godot_icall_1_24(method_bind_1, Object.GetPtr(this), Object.GetPtr(curve));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_curve");

        [GodotMethod("get_curve")]
        [Obsolete("GetCurve is deprecated. Use the Curve property instead.")]
        public Curve GetCurve()
        {
            return NativeCalls.godot_icall_0_359(method_bind_2, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
