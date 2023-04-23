using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.OccluderShape"/>s are resources used by <see cref="Godot.Occluder"/> nodes, allowing geometric occlusion culling.</para>
    /// <para>This shape can include multiple spheres. These can be created and deleted either in the Editor inspector or by calling <c>set_spheres</c>. The sphere positions can be set by dragging the handle in the Editor viewport. The radius can be set with the smaller handle.</para>
    /// </summary>
    public partial class OccluderShapeSphere : OccluderShape
    {
        /// <summary>
        /// <para>The sphere data can be accessed as an array of <see cref="Godot.Plane"/>s. The position of each sphere is stored in the <c>normal</c>, and the radius is stored in the <c>d</c> value of the plane.</para>
        /// </summary>
        public Godot.Collections.Array Spheres
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSpheres();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSpheres(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "OccluderShapeSphere";

        public OccluderShapeSphere() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_OccluderShapeSphere_Ctor(this);
        }

        internal OccluderShapeSphere(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_spheres");

        [GodotMethod("set_spheres")]
        [Obsolete("SetSpheres is deprecated. Use the Spheres property instead.")]
        public void SetSpheres(Godot.Collections.Array spheres)
        {
            NativeCalls.godot_icall_1_92(method_bind_0, Object.GetPtr(this), spheres.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_spheres");

        [GodotMethod("get_spheres")]
        [Obsolete("GetSpheres is deprecated. Use the Spheres property instead.")]
        public Godot.Collections.Array GetSpheres()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_1, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sphere_position");

        /// <summary>
        /// <para>Sets an individual sphere's position.</para>
        /// </summary>
        [GodotMethod("set_sphere_position")]
        public void SetSpherePosition(int index, Vector3 position)
        {
            NativeCalls.godot_icall_2_33(method_bind_2, Object.GetPtr(this), index, ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sphere_radius");

        /// <summary>
        /// <para>Sets an individual sphere's radius.</para>
        /// </summary>
        [GodotMethod("set_sphere_radius")]
        public void SetSphereRadius(int index, float radius)
        {
            NativeCalls.godot_icall_2_34(method_bind_3, Object.GetPtr(this), index, radius);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
