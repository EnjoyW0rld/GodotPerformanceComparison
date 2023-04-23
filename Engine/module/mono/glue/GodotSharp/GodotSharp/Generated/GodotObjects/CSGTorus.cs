using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This node allows you to create a torus for use with the CSG system.</para>
    /// <para>Note: CSG nodes are intended to be used for level prototyping. Creating CSG nodes has a significant CPU cost compared to creating a <see cref="Godot.MeshInstance"/> with a <see cref="Godot.PrimitiveMesh"/>. Moving a CSG node within another CSG node also has a significant CPU cost, so it should be avoided during gameplay.</para>
    /// </summary>
    public partial class CSGTorus : CSGPrimitive
    {
        /// <summary>
        /// <para>The inner radius of the torus.</para>
        /// </summary>
        public float InnerRadius
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInnerRadius();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInnerRadius(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The outer radius of the torus.</para>
        /// </summary>
        public float OuterRadius
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOuterRadius();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOuterRadius(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The number of slices the torus is constructed of.</para>
        /// </summary>
        public int Sides
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSides();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSides(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The number of edges each ring of the torus is constructed of.</para>
        /// </summary>
        public int RingSides
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRingSides();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRingSides(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c> the normals of the torus are set to give a smooth effect making the torus seem rounded. If <c>false</c> the torus will have a flat shaded look.</para>
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
        /// <para>The material used to render the torus.</para>
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

        private const string nativeName = "CSGTorus";

        public CSGTorus() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CSGTorus_Ctor(this);
        }

        internal CSGTorus(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_inner_radius");

        [GodotMethod("set_inner_radius")]
        [Obsolete("SetInnerRadius is deprecated. Use the InnerRadius property instead.")]
        public void SetInnerRadius(float radius)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), radius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_inner_radius");

        [GodotMethod("get_inner_radius")]
        [Obsolete("GetInnerRadius is deprecated. Use the InnerRadius property instead.")]
        public float GetInnerRadius()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_outer_radius");

        [GodotMethod("set_outer_radius")]
        [Obsolete("SetOuterRadius is deprecated. Use the OuterRadius property instead.")]
        public void SetOuterRadius(float radius)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), radius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_outer_radius");

        [GodotMethod("get_outer_radius")]
        [Obsolete("GetOuterRadius is deprecated. Use the OuterRadius property instead.")]
        public float GetOuterRadius()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sides");

        [GodotMethod("set_sides")]
        [Obsolete("SetSides is deprecated. Use the Sides property instead.")]
        public void SetSides(int sides)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), sides);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sides");

        [GodotMethod("get_sides")]
        [Obsolete("GetSides is deprecated. Use the Sides property instead.")]
        public int GetSides()
        {
            return NativeCalls.godot_icall_0_5(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ring_sides");

        [GodotMethod("set_ring_sides")]
        [Obsolete("SetRingSides is deprecated. Use the RingSides property instead.")]
        public void SetRingSides(int sides)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), sides);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ring_sides");

        [GodotMethod("get_ring_sides")]
        [Obsolete("GetRingSides is deprecated. Use the RingSides property instead.")]
        public int GetRingSides()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
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

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_smooth_faces");

        [GodotMethod("set_smooth_faces")]
        [Obsolete("SetSmoothFaces is deprecated. Use the SmoothFaces property instead.")]
        public void SetSmoothFaces(bool smoothFaces)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), smoothFaces);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_smooth_faces");

        [GodotMethod("get_smooth_faces")]
        [Obsolete("GetSmoothFaces is deprecated. Use the SmoothFaces property instead.")]
        public bool GetSmoothFaces()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
