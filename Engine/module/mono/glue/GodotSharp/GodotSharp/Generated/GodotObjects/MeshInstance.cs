using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>MeshInstance is a node that takes a <see cref="Godot.Mesh"/> resource and adds it to the current scenario by creating an instance of it. This is the class most often used to get 3D geometry rendered and can be used to instance a single <see cref="Godot.Mesh"/> in many places. This allows reusing geometry, which can save on resources. When a <see cref="Godot.Mesh"/> has to be instanced more than thousands of times at close proximity, consider using a <see cref="Godot.MultiMesh"/> in a <see cref="Godot.MultiMeshInstance"/> instead.</para>
    /// </summary>
    public partial class MeshInstance : GeometryInstance
    {
        /// <summary>
        /// <para>The <see cref="Godot.Mesh"/> resource for the instance.</para>
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
        /// <para>Sets the skin to be used by this instance.</para>
        /// </summary>
        public Skin Skin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSkin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSkin(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para><see cref="Godot.NodePath"/> to the <see cref="Godot.Skeleton"/> associated with the instance.</para>
        /// </summary>
        public NodePath Skeleton
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSkeletonPath();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSkeletonPath(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, normals are transformed when software skinning is used. Set to <c>false</c> when normals are not needed for better performance.</para>
        /// <para>See  for details about how software skinning is enabled.</para>
        /// </summary>
        public bool SoftwareSkinningTransformNormals
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsSoftwareSkinningTransformNormalsEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSoftwareSkinningTransformNormals(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "MeshInstance";

        public MeshInstance() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_MeshInstance_Ctor(this);
        }

        internal MeshInstance(bool memoryOwn) : base(memoryOwn) {}

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
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_skeleton_path");

        [GodotMethod("set_skeleton_path")]
        [Obsolete("SetSkeletonPath is deprecated. Use the Skeleton property instead.")]
        public void SetSkeletonPath(NodePath skeletonPath)
        {
            NativeCalls.godot_icall_1_129(method_bind_2, Object.GetPtr(this), NodePath.GetPtr(skeletonPath));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_skeleton_path");

        [GodotMethod("get_skeleton_path")]
        [Obsolete("GetSkeletonPath is deprecated. Use the Skeleton property instead.")]
        public NodePath GetSkeletonPath()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_3, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_skin");

        [GodotMethod("set_skin")]
        [Obsolete("SetSkin is deprecated. Use the Skin property instead.")]
        public void SetSkin(Skin skin)
        {
            NativeCalls.godot_icall_1_24(method_bind_4, Object.GetPtr(this), Object.GetPtr(skin));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_skin");

        [GodotMethod("get_skin")]
        [Obsolete("GetSkin is deprecated. Use the Skin property instead.")]
        public Skin GetSkin()
        {
            return NativeCalls.godot_icall_0_458(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_surface_material_count");

        /// <summary>
        /// <para>Returns the number of surface override materials.</para>
        /// </summary>
        [GodotMethod("get_surface_material_count")]
        public int GetSurfaceMaterialCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_surface_material");

        /// <summary>
        /// <para>Sets the override <see cref="Godot.Material"/> for the specified surface of the <see cref="Godot.Mesh"/> resource. This material is associated with this <see cref="Godot.MeshInstance"/> rather than with the <see cref="Godot.Mesh"/> resource.</para>
        /// </summary>
        [GodotMethod("set_surface_material")]
        public void SetSurfaceMaterial(int surface, Material material)
        {
            NativeCalls.godot_icall_2_58(method_bind_7, Object.GetPtr(this), surface, Object.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_surface_material");

        /// <summary>
        /// <para>Returns the override <see cref="Godot.Material"/> for a surface of the <see cref="Godot.Mesh"/> resource.</para>
        /// <para>Note: This function only returns override materials associated with this <see cref="Godot.MeshInstance"/>. Consider using <see cref="Godot.MeshInstance.GetActiveMaterial"/> or <see cref="Godot.Mesh.SurfaceGetMaterial"/> to get materials associated with the <see cref="Godot.Mesh"/> resource.</para>
        /// </summary>
        [GodotMethod("get_surface_material")]
        public Material GetSurfaceMaterial(int surface)
        {
            return NativeCalls.godot_icall_1_594(method_bind_8, Object.GetPtr(this), surface);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_active_material");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Material"/> that will be used by the <see cref="Godot.Mesh"/> when drawing. This can return the <see cref="Godot.GeometryInstance.MaterialOverride"/>, the surface override <see cref="Godot.Material"/> defined in this <see cref="Godot.MeshInstance"/>, or the surface <see cref="Godot.Material"/> defined in the <see cref="Godot.Mesh"/>. For example, if <see cref="Godot.GeometryInstance.MaterialOverride"/> is used, all surfaces will return the override material.</para>
        /// </summary>
        [GodotMethod("get_active_material")]
        public Material GetActiveMaterial(int surface)
        {
            return NativeCalls.godot_icall_1_594(method_bind_9, Object.GetPtr(this), surface);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_software_skinning_transform_normals");

        [GodotMethod("set_software_skinning_transform_normals")]
        [Obsolete("SetSoftwareSkinningTransformNormals is deprecated. Use the SoftwareSkinningTransformNormals property instead.")]
        public void SetSoftwareSkinningTransformNormals(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_software_skinning_transform_normals_enabled");

        [GodotMethod("is_software_skinning_transform_normals_enabled")]
        [Obsolete("IsSoftwareSkinningTransformNormalsEnabled is deprecated. Use the SoftwareSkinningTransformNormals property instead.")]
        public bool IsSoftwareSkinningTransformNormalsEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_trimesh_collision");

        /// <summary>
        /// <para>This helper creates a <see cref="Godot.StaticBody"/> child node with a <see cref="Godot.ConcavePolygonShape"/> collision shape calculated from the mesh geometry. It's mainly used for testing.</para>
        /// </summary>
        [GodotMethod("create_trimesh_collision")]
        public void CreateTrimeshCollision()
        {
            NativeCalls.godot_icall_0_3(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_multiple_convex_collisions");

        /// <summary>
        /// <para>This helper creates a <see cref="Godot.StaticBody"/> child node with multiple <see cref="Godot.ConvexPolygonShape"/> collision shapes calculated from the mesh geometry via convex decomposition. It's mainly used for testing.</para>
        /// </summary>
        [GodotMethod("create_multiple_convex_collisions")]
        public void CreateMultipleConvexCollisions()
        {
            NativeCalls.godot_icall_0_3(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_convex_collision");

        /// <summary>
        /// <para>This helper creates a <see cref="Godot.StaticBody"/> child node with a <see cref="Godot.ConvexPolygonShape"/> collision shape calculated from the mesh geometry. It's mainly used for testing.</para>
        /// <para>If <c>clean</c> is <c>true</c> (default), duplicate and interior vertices are removed automatically. You can set it to <c>false</c> to make the process faster if not needed.</para>
        /// <para>If <c>simplify</c> is <c>true</c>, the geometry can be further simplified to reduce the amount of vertices. Disabled by default.</para>
        /// </summary>
        [GodotMethod("create_convex_collision")]
        public void CreateConvexCollision(bool clean = true, bool simplify = false)
        {
            NativeCalls.godot_icall_2_604(method_bind_14, Object.GetPtr(this), clean, simplify);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_debug_tangents");

        /// <summary>
        /// <para>This helper creates a <see cref="Godot.MeshInstance"/> child node with gizmos at every vertex calculated from the mesh geometry. It's mainly used for testing.</para>
        /// </summary>
        [GodotMethod("create_debug_tangents")]
        public void CreateDebugTangents()
        {
            NativeCalls.godot_icall_0_3(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_mergeable_with");

        /// <summary>
        /// <para>Returns <c>true</c> if this <see cref="Godot.MeshInstance"/> can be merged with the specified <c>other_mesh_instance</c>, using the <see cref="Godot.MeshInstance.MergeMeshes"/> function.</para>
        /// <para>In order to be mergeable, properties of the <see cref="Godot.MeshInstance"/> must match, and each surface must match, in terms of material, attributes and vertex format.</para>
        /// </summary>
        [GodotMethod("is_mergeable_with")]
        public bool IsMergeableWith(Node otherMeshInstance)
        {
            return NativeCalls.godot_icall_1_149(method_bind_16, Object.GetPtr(this), Object.GetPtr(otherMeshInstance));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "merge_meshes");

        /// <summary>
        /// <para>This function can merge together the data from several source <see cref="Godot.MeshInstance"/>s into a single destination <see cref="Godot.MeshInstance"/> (the MeshInstance the function is called from). This is primarily useful for improving performance by reducing the number of drawcalls and <see cref="Godot.Node"/>s.</para>
        /// <para>Merging should only be attempted for simple meshes that do not contain animation.</para>
        /// <para>The final vertices can either be returned in global space, or in local space relative to the destination <see cref="Godot.MeshInstance"/> global transform (the destination Node must be inside the <see cref="Godot.SceneTree"/> for local space to work).</para>
        /// <para>The function will make a final check for compatibility between the <see cref="Godot.MeshInstance"/>s by default, this should always be used unless you have previously checked for compatibility using <see cref="Godot.MeshInstance.IsMergeableWith"/>. If the compatibility check is omitted and the meshes are merged, you may see rendering errors.</para>
        /// <para>Note: The requirements for similarity between meshes are quite stringent. They can be checked using the <see cref="Godot.MeshInstance.IsMergeableWith"/> function prior to calling <see cref="Godot.MeshInstance.MergeMeshes"/>.</para>
        /// <para>Also note that any initial data in the destination <see cref="Godot.MeshInstance"/> data will be discarded.</para>
        /// </summary>
        /// <param name="meshInstances">If the parameter is null, then the default value is new Godot.Collections.Array { }</param>
        [GodotMethod("merge_meshes")]
        public bool MergeMeshes(Godot.Collections.Array meshInstances = null, bool useGlobalSpace = false, bool checkCompatibility = true)
        {
            Godot.Collections.Array meshInstances_in = meshInstances != null ? meshInstances : new Godot.Collections.Array { };
            return NativeCalls.godot_icall_3_605(method_bind_17, Object.GetPtr(this), meshInstances_in.GetPtr(), useGlobalSpace, checkCompatibility);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
