using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>An infinite plane shape for 3D collisions. Note that the <see cref="Godot.Plane"/>'s normal matters; anything "below" the plane will collide with it. If the <see cref="Godot.PlaneShape"/> is used in a <see cref="Godot.PhysicsBody"/>, it will cause colliding objects placed "below" it to teleport "above" the plane.</para>
    /// </summary>
    public partial class PlaneShape : Shape
    {
        /// <summary>
        /// <para>The <see cref="Godot.Plane"/> used by the <see cref="Godot.PlaneShape"/> for collision.</para>
        /// </summary>
        public Plane Plane
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPlane();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPlane(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "PlaneShape";

        public PlaneShape() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PlaneShape_Ctor(this);
        }

        internal PlaneShape(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_plane");

        [GodotMethod("set_plane")]
        [Obsolete("SetPlane is deprecated. Use the Plane property instead.")]
        public void SetPlane(Plane plane)
        {
            NativeCalls.godot_icall_1_519(method_bind_0, Object.GetPtr(this), ref plane);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_plane");

        [GodotMethod("get_plane")]
        [Obsolete("GetPlane is deprecated. Use the Plane property instead.")]
        public Plane GetPlane()
        {
            NativeCalls.godot_icall_0_9(method_bind_1, Object.GetPtr(this), out Plane argRet); return (Plane)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
