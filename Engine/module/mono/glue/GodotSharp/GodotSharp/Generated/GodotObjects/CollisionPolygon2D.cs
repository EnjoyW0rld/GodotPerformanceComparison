using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Provides a 2D collision polygon to a <see cref="Godot.CollisionObject2D"/> parent. Polygons can be drawn in the editor or specified by a list of vertices.</para>
    /// </summary>
    public partial class CollisionPolygon2D : Node2D
    {
        public enum BuildModeEnum
        {
            /// <summary>
            /// <para>Collisions will include the polygon and its contained area.</para>
            /// </summary>
            Solids = 0,
            /// <summary>
            /// <para>Collisions will only include the polygon edges.</para>
            /// </summary>
            Segments = 1
        }

        /// <summary>
        /// <para>Collision build mode. Use one of the <see cref="Godot.CollisionPolygon2D.BuildModeEnum"/> constants.</para>
        /// </summary>
        public CollisionPolygon2D.BuildModeEnum BuildMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBuildMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBuildMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The polygon's list of vertices. The final point will be connected to the first. The returned value is a clone of the <see cref="Godot.Vector2"/>, not a reference.</para>
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
        /// <para>If <c>true</c>, no collisions will be detected.</para>
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
        /// <para>If <c>true</c>, only edges that face up, relative to <see cref="Godot.CollisionPolygon2D"/>'s rotation, will collide with other objects.</para>
        /// <para>Note: This property has no effect if this <see cref="Godot.CollisionPolygon2D"/> is a child of an <see cref="Godot.Area2D"/> node.</para>
        /// </summary>
        public bool OneWayCollision
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsOneWayCollisionEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOneWayCollision(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The margin used for one-way collision (in pixels). Higher values will make the shape thicker, and work better for colliders that enter the polygon at a high velocity.</para>
        /// </summary>
        public float OneWayCollisionMargin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOneWayCollisionMargin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOneWayCollisionMargin(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "CollisionPolygon2D";

        public CollisionPolygon2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CollisionPolygon2D_Ctor(this);
        }

        internal CollisionPolygon2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_polygon");

        [GodotMethod("set_polygon")]
        [Obsolete("SetPolygon is deprecated. Use the Polygon property instead.")]
        public void SetPolygon(Vector2[] polygon)
        {
            NativeCalls.godot_icall_1_235(method_bind_0, Object.GetPtr(this), polygon);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_polygon");

        [GodotMethod("get_polygon")]
        [Obsolete("GetPolygon is deprecated. Use the Polygon property instead.")]
        public Vector2[] GetPolygon()
        {
            return NativeCalls.godot_icall_0_236(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_build_mode");

        [GodotMethod("set_build_mode")]
        [Obsolete("SetBuildMode is deprecated. Use the BuildMode property instead.")]
        public void SetBuildMode(CollisionPolygon2D.BuildModeEnum buildMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)buildMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_build_mode");

        [GodotMethod("get_build_mode")]
        [Obsolete("GetBuildMode is deprecated. Use the BuildMode property instead.")]
        public CollisionPolygon2D.BuildModeEnum GetBuildMode()
        {
            return (CollisionPolygon2D.BuildModeEnum)NativeCalls.godot_icall_0_302(method_bind_3, Object.GetPtr(this));
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
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_one_way_collision");

        [GodotMethod("set_one_way_collision")]
        [Obsolete("SetOneWayCollision is deprecated. Use the OneWayCollision property instead.")]
        public void SetOneWayCollision(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_one_way_collision_enabled");

        [GodotMethod("is_one_way_collision_enabled")]
        [Obsolete("IsOneWayCollisionEnabled is deprecated. Use the OneWayCollision property instead.")]
        public bool IsOneWayCollisionEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_one_way_collision_margin");

        [GodotMethod("set_one_way_collision_margin")]
        [Obsolete("SetOneWayCollisionMargin is deprecated. Use the OneWayCollisionMargin property instead.")]
        public void SetOneWayCollisionMargin(float margin)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_one_way_collision_margin");

        [GodotMethod("get_one_way_collision_margin")]
        [Obsolete("GetOneWayCollisionMargin is deprecated. Use the OneWayCollisionMargin property instead.")]
        public float GetOneWayCollisionMargin()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
