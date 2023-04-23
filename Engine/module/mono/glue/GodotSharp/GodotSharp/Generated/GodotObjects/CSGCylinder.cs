using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This node allows you to create a cylinder (or cone) for use with the CSG system.</para>
    /// <para>Note: CSG nodes are intended to be used for level prototyping. Creating CSG nodes has a significant CPU cost compared to creating a <see cref="Godot.MeshInstance"/> with a <see cref="Godot.PrimitiveMesh"/>. Moving a CSG node within another CSG node also has a significant CPU cost, so it should be avoided during gameplay.</para>
    /// </summary>
    public partial class CSGCylinder : CSGPrimitive
    {
        /// <summary>
        /// <para>The radius of the cylinder.</para>
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
        /// <para>The height of the cylinder.</para>
        /// </summary>
        public float Height
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHeight();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHeight(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The number of sides of the cylinder, the higher this number the more detail there will be in the cylinder.</para>
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
        /// <para>If <c>true</c> a cone is created, the <see cref="Godot.CSGCylinder.Radius"/> will only apply to one side.</para>
        /// </summary>
        public bool Cone
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsCone();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCone(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c> the normals of the cylinder are set to give a smooth effect making the cylinder seem rounded. If <c>false</c> the cylinder will have a flat shaded look.</para>
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
        /// <para>The material used to render the cylinder.</para>
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

        private const string nativeName = "CSGCylinder";

        public CSGCylinder() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CSGCylinder_Ctor(this);
        }

        internal CSGCylinder(bool memoryOwn) : base(memoryOwn) {}

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
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_height");

        [GodotMethod("set_height")]
        [Obsolete("SetHeight is deprecated. Use the Height property instead.")]
        public void SetHeight(float height)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), height);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_height");

        [GodotMethod("get_height")]
        [Obsolete("GetHeight is deprecated. Use the Height property instead.")]
        public float GetHeight()
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
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cone");

        [GodotMethod("set_cone")]
        [Obsolete("SetCone is deprecated. Use the Cone property instead.")]
        public void SetCone(bool cone)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), cone);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_cone");

        [GodotMethod("is_cone")]
        [Obsolete("IsCone is deprecated. Use the Cone property instead.")]
        public bool IsCone()
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
