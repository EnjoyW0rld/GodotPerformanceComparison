using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Can have <see cref="Godot.PathFollow"/> child nodes moving along the <see cref="Godot.Curve3D"/>. See <see cref="Godot.PathFollow"/> for more information on the usage.</para>
    /// <para>Note that the path is considered as relative to the moved nodes (children of <see cref="Godot.PathFollow"/>). As such, the curve should usually start with a zero vector <c>(0, 0, 0)</c>.</para>
    /// </summary>
    public partial class Path : Spatial
    {
        /// <summary>
        /// <para>A <see cref="Godot.Curve3D"/> describing the path.</para>
        /// </summary>
        public Curve3D Curve
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

        private const string nativeName = "Path";

        public Path() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Path_Ctor(this);
        }

        internal Path(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_curve");

        [GodotMethod("set_curve")]
        [Obsolete("SetCurve is deprecated. Use the Curve property instead.")]
        public void SetCurve(Curve3D curve)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(curve));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_curve");

        [GodotMethod("get_curve")]
        [Obsolete("GetCurve is deprecated. Use the Curve property instead.")]
        public Curve3D GetCurve()
        {
            return NativeCalls.godot_icall_0_726(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
