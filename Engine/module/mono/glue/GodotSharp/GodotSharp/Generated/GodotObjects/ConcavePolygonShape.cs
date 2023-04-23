using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Concave polygon shape resource, which can be set into a <see cref="Godot.PhysicsBody"/> or area. This shape is created by feeding a list of triangles.</para>
    /// <para>Note: When used for collision, <see cref="Godot.ConcavePolygonShape"/> is intended to work with static <see cref="Godot.PhysicsBody"/> nodes like <see cref="Godot.StaticBody"/> and will not work with <see cref="Godot.KinematicBody"/> or <see cref="Godot.RigidBody"/> with a mode other than Static.</para>
    /// <para>Warning: Using this shape for an <see cref="Godot.Area"/> (via a <see cref="Godot.CollisionShape"/> node, created e.g. by using the Create Trimesh Collision Sibling option in the Mesh menu that appears when selecting a <see cref="Godot.MeshInstance"/> node) may give unexpected results: when using Godot Physics, the area will only detect collisions with the triangle faces in the <see cref="Godot.ConcavePolygonShape"/> (and not with any "inside" of the shape, for example), and when using Bullet Physics the area will not detect any collisions with the concave shape at all (this is a known bug).</para>
    /// </summary>
    public partial class ConcavePolygonShape : Shape
    {
        public Vector3[] Data
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFaces();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFaces(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ConcavePolygonShape";

        public ConcavePolygonShape() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ConcavePolygonShape_Ctor(this);
        }

        internal ConcavePolygonShape(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_faces");

        /// <summary>
        /// <para>Sets the faces (an array of triangles).</para>
        /// </summary>
        [GodotMethod("set_faces")]
        [Obsolete("SetFaces is deprecated. Use the Data property instead.")]
        public void SetFaces(Vector3[] faces)
        {
            NativeCalls.godot_icall_1_229(method_bind_0, Object.GetPtr(this), faces);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_faces");

        /// <summary>
        /// <para>Returns the faces (an array of triangles).</para>
        /// </summary>
        [GodotMethod("get_faces")]
        [Obsolete("GetFaces is deprecated. Use the Data property instead.")]
        public Vector3[] GetFaces()
        {
            return NativeCalls.godot_icall_0_230(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
