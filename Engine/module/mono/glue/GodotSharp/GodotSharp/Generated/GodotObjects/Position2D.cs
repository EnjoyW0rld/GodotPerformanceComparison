using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Generic 2D position hint for editing. It's just like a plain <see cref="Godot.Node2D"/>, but it displays as a cross in the 2D editor at all times. You can set cross' visual size by using the gizmo in the 2D editor while the node is selected.</para>
    /// </summary>
    public partial class Position2D : Node2D
    {
        public float GizmoExtents
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetGizmoExtents();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetGizmoExtents(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Position2D";

        public Position2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Position2D_Ctor(this);
        }

        internal Position2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_gizmo_extents");

        [Obsolete("_SetGizmoExtents is deprecated. Use the GizmoExtents property instead.")]
        internal void _SetGizmoExtents(float extents)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), extents);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_gizmo_extents");

        [Obsolete("_GetGizmoExtents is deprecated. Use the GizmoExtents property instead.")]
        internal float _GetGizmoExtents()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
