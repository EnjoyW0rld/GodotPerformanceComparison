using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Allows editing a collision polygon's vertices on a selected plane. Can also set a depth perpendicular to that plane. This class is only available in the editor. It will not appear in the scene tree at run-time. Creates a <see cref="Godot.Shape"/> for gameplay. Properties modified during gameplay will have no effect.</para>
    /// </summary>
    public partial class CollisionPolygon : Spatial
    {
        /// <summary>
        /// <para>Length that the resulting collision extends in either direction perpendicular to its polygon.</para>
        /// </summary>
        public float Depth
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDepth();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDepth(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, no collision will be produced.</para>
        /// </summary>
        public bool Disabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDisabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDisabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Array of vertices which define the polygon.</para>
        /// <para>Note: The returned value is a copy of the original. Methods which mutate the size or properties of the return value will not impact the original polygon. To change properties of the polygon, assign it to a temporary variable and make changes before reassigning the <c>polygon</c> member.</para>
        /// </summary>
        public Vector2[] Polygon
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPolygon();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPolygon(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The collision margin for the generated <see cref="Godot.Shape"/>. See <see cref="Godot.Shape.Margin"/> for more details.</para>
        /// </summary>
        public float Margin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMargin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMargin(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "CollisionPolygon";

        public CollisionPolygon() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CollisionPolygon_Ctor(this);
        }

        internal CollisionPolygon(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_depth");

        [GodotMethod("set_depth")]
        [Obsolete("SetDepth is deprecated. Use the Depth property instead.")]
        public void SetDepth(float depth)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), depth);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_depth");

        [GodotMethod("get_depth")]
        [Obsolete("GetDepth is deprecated. Use the Depth property instead.")]
        public float GetDepth()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_polygon");

        [GodotMethod("set_polygon")]
        [Obsolete("SetPolygon is deprecated. Use the Polygon property instead.")]
        public void SetPolygon(Vector2[] polygon)
        {
            NativeCalls.godot_icall_1_235(method_bind_2, Object.GetPtr(this), polygon);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_polygon");

        [GodotMethod("get_polygon")]
        [Obsolete("GetPolygon is deprecated. Use the Polygon property instead.")]
        public Vector2[] GetPolygon()
        {
            return NativeCalls.godot_icall_0_236(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_disabled");

        [GodotMethod("set_disabled")]
        [Obsolete("SetDisabled is deprecated. Use the Disabled property instead.")]
        public void SetDisabled(bool disabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), disabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_disabled");

        [GodotMethod("is_disabled")]
        [Obsolete("IsDisabled is deprecated. Use the Disabled property instead.")]
        public bool IsDisabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_margin");

        [GodotMethod("set_margin")]
        [Obsolete("SetMargin is deprecated. Use the Margin property instead.")]
        public void SetMargin(float margin)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_margin");

        [GodotMethod("get_margin")]
        [Obsolete("GetMargin is deprecated. Use the Margin property instead.")]
        public float GetMargin()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
