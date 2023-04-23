using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Concave polygon 2D shape resource for physics. It is made out of segments and is optimal for complex polygonal concave collisions. However, it is not advised to use for <see cref="Godot.RigidBody2D"/> nodes. A CollisionPolygon2D in convex decomposition mode (solids) or several convex objects are advised for that instead. Otherwise, a concave polygon 2D shape is better for static collisions.</para>
    /// <para>The main difference between a <see cref="Godot.ConvexPolygonShape2D"/> and a <see cref="Godot.ConcavePolygonShape2D"/> is that a concave polygon assumes it is concave and uses a more complex method of collision detection, and a convex one forces itself to be convex in order to speed up collision detection.</para>
    /// <para>Warning: Using this shape for an <see cref="Godot.Area2D"/> (via a <see cref="Godot.CollisionShape2D"/> node) may give unexpected results: the area will only detect collisions with the segments in the <see cref="Godot.ConcavePolygonShape2D"/> (and not with any "inside" of the shape, for example).</para>
    /// </summary>
    public partial class ConcavePolygonShape2D : Shape2D
    {
        /// <summary>
        /// <para>The array of points that make up the <see cref="Godot.ConcavePolygonShape2D"/>'s line segments.</para>
        /// </summary>
        public Vector2[] Segments
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSegments();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSegments(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ConcavePolygonShape2D";

        public ConcavePolygonShape2D() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ConcavePolygonShape2D_Ctor(this);
        }

        internal ConcavePolygonShape2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_segments");

        [GodotMethod("set_segments")]
        [Obsolete("SetSegments is deprecated. Use the Segments property instead.")]
        public void SetSegments(Vector2[] segments)
        {
            NativeCalls.godot_icall_1_235(method_bind_0, Object.GetPtr(this), segments);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_segments");

        [GodotMethod("get_segments")]
        [Obsolete("GetSegments is deprecated. Use the Segments property instead.")]
        public Vector2[] GetSegments()
        {
            return NativeCalls.godot_icall_0_236(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
