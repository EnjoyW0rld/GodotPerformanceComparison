using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Base class for all primitive meshes. Handles applying a <see cref="Godot.Material"/> to a primitive mesh. Examples include <see cref="Godot.CapsuleMesh"/>, <see cref="Godot.CubeMesh"/>, <see cref="Godot.CylinderMesh"/>, <see cref="Godot.PlaneMesh"/>, <see cref="Godot.PrismMesh"/>, <see cref="Godot.QuadMesh"/>, and <see cref="Godot.SphereMesh"/>.</para>
    /// </summary>
    public abstract partial class PrimitiveMesh : Mesh
    {
        /// <summary>
        /// <para>The current <see cref="Godot.Material"/> of the primitive mesh.</para>
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

        /// <summary>
        /// <para>Overrides the <see cref="Godot.AABB"/> with one defined by user for use with frustum culling. Especially useful to avoid unexpected culling when using a shader to offset vertices.</para>
        /// </summary>
        public AABB CustomAabb
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCustomAabb();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCustomAabb(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If set, the order of the vertices in each triangle are reversed resulting in the backside of the mesh being drawn.</para>
        /// <para>This gives the same result as using <see cref="Godot.SpatialMaterial.CullMode.Back"/> in <see cref="Godot.SpatialMaterial.ParamsCullMode"/>.</para>
        /// </summary>
        public bool FlipFaces
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlipFaces();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlipFaces(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "PrimitiveMesh";

        internal PrimitiveMesh() {}

        internal PrimitiveMesh(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_material");

        [GodotMethod("set_material")]
        [Obsolete("SetMaterial is deprecated. Use the Material property instead.")]
        public void SetMaterial(Material material)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_material");

        [GodotMethod("get_material")]
        [Obsolete("GetMaterial is deprecated. Use the Material property instead.")]
        public Material GetMaterial()
        {
            return NativeCalls.godot_icall_0_237(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mesh_arrays");

        /// <summary>
        /// <para>Returns mesh arrays used to constitute surface of <see cref="Godot.Mesh"/>. The result can be passed to <see cref="Godot.ArrayMesh.AddSurfaceFromArrays"/> to create a new surface. For example:</para>
        /// <para><code>
        /// var c := CylinderMesh.new()
        /// var arr_mesh := ArrayMesh.new()
        /// arr_mesh.add_surface_from_arrays(Mesh.PRIMITIVE_TRIANGLES, c.get_mesh_arrays())
        /// </code></para>
        /// </summary>
        [GodotMethod("get_mesh_arrays")]
        public Godot.Collections.Array GetMeshArrays()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_2, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_custom_aabb");

        [GodotMethod("set_custom_aabb")]
        [Obsolete("SetCustomAabb is deprecated. Use the CustomAabb property instead.")]
        public void SetCustomAabb(AABB aabb)
        {
            NativeCalls.godot_icall_1_157(method_bind_3, Object.GetPtr(this), ref aabb);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_custom_aabb");

        [GodotMethod("get_custom_aabb")]
        [Obsolete("GetCustomAabb is deprecated. Use the CustomAabb property instead.")]
        public AABB GetCustomAabb()
        {
            NativeCalls.godot_icall_0_158(method_bind_4, Object.GetPtr(this), out AABB argRet); return (AABB)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flip_faces");

        [GodotMethod("set_flip_faces")]
        [Obsolete("SetFlipFaces is deprecated. Use the FlipFaces property instead.")]
        public void SetFlipFaces(bool flipFaces)
        {
            NativeCalls.godot_icall_1_16(method_bind_5, Object.GetPtr(this), flipFaces);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_flip_faces");

        [GodotMethod("get_flip_faces")]
        [Obsolete("GetFlipFaces is deprecated. Use the FlipFaces property instead.")]
        public bool GetFlipFaces()
        {
            return NativeCalls.godot_icall_0_7(method_bind_6, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
