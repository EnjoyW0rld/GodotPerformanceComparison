using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This CSG node allows you to use any mesh resource as a CSG shape, provided it is closed, does not self-intersect, does not contain internal faces and has no edges that connect to more than two faces. See also <see cref="Godot.CSGPolygon"/> for drawing 2D extruded polygons to be used as CSG nodes.</para>
    /// <para>Note: CSG nodes are intended to be used for level prototyping. Creating CSG nodes has a significant CPU cost compared to creating a <see cref="Godot.MeshInstance"/> with a <see cref="Godot.PrimitiveMesh"/>. Moving a CSG node within another CSG node also has a significant CPU cost, so it should be avoided during gameplay.</para>
    /// </summary>
    public partial class CSGMesh : CSGPrimitive
    {
        /// <summary>
        /// <para>The <see cref="Godot.Mesh"/> resource to use as a CSG shape.</para>
        /// <para>Note: When using an <see cref="Godot.ArrayMesh"/>, avoid meshes with vertex normals unless a flat shader is required. By default, CSGMesh will ignore the mesh's vertex normals and use a smooth shader calculated using the faces' normals. If a flat shader is required, ensure that all faces' vertex normals are parallel.</para>
        /// </summary>
        public Mesh Mesh
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMesh();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMesh(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The <see cref="Godot.Material"/> used in drawing the CSG shape.</para>
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

        private const string nativeName = "CSGMesh";

        public CSGMesh() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CSGMesh_Ctor(this);
        }

        internal CSGMesh(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mesh");

        [GodotMethod("set_mesh")]
        [Obsolete("SetMesh is deprecated. Use the Mesh property instead.")]
        public void SetMesh(Mesh mesh)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(mesh));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mesh");

        [GodotMethod("get_mesh")]
        [Obsolete("GetMesh is deprecated. Use the Mesh property instead.")]
        public Mesh GetMesh()
        {
            return NativeCalls.godot_icall_0_10(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_material");

        [GodotMethod("set_material")]
        [Obsolete("SetMaterial is deprecated. Use the Material property instead.")]
        public void SetMaterial(Material material)
        {
            NativeCalls.godot_icall_1_24(method_bind_2, Object.GetPtr(this), Object.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_material");

        [GodotMethod("get_material")]
        [Obsolete("GetMaterial is deprecated. Use the Material property instead.")]
        public Material GetMaterial()
        {
            return NativeCalls.godot_icall_0_237(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
