using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Can have <see cref="Godot.PathFollow2D"/> child nodes moving along the <see cref="Godot.Curve2D"/>. See <see cref="Godot.PathFollow2D"/> for more information on usage.</para>
    /// <para>Note: The path is considered as relative to the moved nodes (children of <see cref="Godot.PathFollow2D"/>). As such, the curve should usually start with a zero vector (<c>(0, 0)</c>).</para>
    /// </summary>
    public partial class Path2D : Node2D
    {
        /// <summary>
        /// <para>A <see cref="Godot.Curve2D"/> describing the path.</para>
        /// </summary>
        public Curve2D Curve
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

        private const string nativeName = "Path2D";

        public Path2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Path2D_Ctor(this);
        }

        internal Path2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_curve");

        [GodotMethod("set_curve")]
        [Obsolete("SetCurve is deprecated. Use the Curve property instead.")]
        public void SetCurve(Curve2D curve)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(curve));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_curve");

        [GodotMethod("get_curve")]
        [Obsolete("GetCurve is deprecated. Use the Curve property instead.")]
        public Curve2D GetCurve()
        {
            return NativeCalls.godot_icall_0_727(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
