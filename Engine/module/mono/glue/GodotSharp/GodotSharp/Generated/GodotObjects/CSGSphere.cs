using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This node allows you to create a sphere for use with the CSG system.</para>
    /// <para>Note: CSG nodes are intended to be used for level prototyping. Creating CSG nodes has a significant CPU cost compared to creating a <see cref="Godot.MeshInstance"/> with a <see cref="Godot.PrimitiveMesh"/>. Moving a CSG node within another CSG node also has a significant CPU cost, so it should be avoided during gameplay.</para>
    /// </summary>
    public partial class CSGSphere : CSGPrimitive
    {
        /// <summary>
        /// <para>Radius of the sphere.</para>
        /// </summary>
        public float Radius
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRadius();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRadius(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Number of vertical slices for the sphere.</para>
        /// </summary>
        public int RadialSegments
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRadialSegments();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRadialSegments(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Number of horizontal slices for the sphere.</para>
        /// </summary>
        public int Rings
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRings();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRings(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c> the normals of the sphere are set to give a smooth effect making the sphere seem rounded. If <c>false</c> the sphere will have a flat shaded look.</para>
        /// </summary>
        public bool SmoothFaces
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSmoothFaces();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSmoothFaces(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The material used to render the sphere.</para>
        /// </summary>
        public Material Material
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaterial();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaterial(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "CSGSphere";

        public CSGSphere() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CSGSphere_Ctor(this);
        }

        internal CSGSphere(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_radius");

        [GodotMethod("set_radius")]
        [Obsolete("SetRadius is deprecated. Use the Radius property instead.")]
        public void SetRadius(float radius)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), radius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_radius");

        [GodotMethod("get_radius")]
        [Obsolete("GetRadius is deprecated. Use the Radius property instead.")]
        public float GetRadius()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_radial_segments");

        [GodotMethod("set_radial_segments")]
        [Obsolete("SetRadialSegments is deprecated. Use the RadialSegments property instead.")]
        public void SetRadialSegments(int radialSegments)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), radialSegments);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_radial_segments");

        [GodotMethod("get_radial_segments")]
        [Obsolete("GetRadialSegments is deprecated. Use the RadialSegments property instead.")]
        public int GetRadialSegments()
        {
            return NativeCalls.godot_icall_0_5(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rings");

        [GodotMethod("set_rings")]
        [Obsolete("SetRings is deprecated. Use the Rings property instead.")]
        public void SetRings(int rings)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), rings);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rings");

        [GodotMethod("get_rings")]
        [Obsolete("GetRings is deprecated. Use the Rings property instead.")]
        public int GetRings()
        {
            return NativeCalls.godot_icall_0_5(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_smooth_faces");

        [GodotMethod("set_smooth_faces")]
        [Obsolete("SetSmoothFaces is deprecated. Use the SmoothFaces property instead.")]
        public void SetSmoothFaces(bool smoothFaces)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), smoothFaces);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_smooth_faces");

        [GodotMethod("get_smooth_faces")]
        [Obsolete("GetSmoothFaces is deprecated. Use the SmoothFaces property instead.")]
        public bool GetSmoothFaces()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_material");

        [GodotMethod("set_material")]
        [Obsolete("SetMaterial is deprecated. Use the Material property instead.")]
        public void SetMaterial(Material material)
        {
            NativeCalls.godot_icall_1_24(method_bind_8, Object.GetPtr(this), Object.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_material");

        [GodotMethod("get_material")]
        [Obsolete("GetMaterial is deprecated. Use the Material property instead.")]
        public Material GetMaterial()
        {
            return NativeCalls.godot_icall_0_237(method_bind_9, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
