using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>MeshDataTool provides access to individual vertices in a <see cref="Godot.Mesh"/>. It allows users to read and edit vertex data of meshes. It also creates an array of faces and edges.</para>
    /// <para>To use MeshDataTool, load a mesh with <see cref="Godot.MeshDataTool.CreateFromSurface"/>. When you are finished editing the data commit the data to a mesh with <see cref="Godot.MeshDataTool.CommitToSurface"/>.</para>
    /// <para>Below is an example of how MeshDataTool may be used.</para>
    /// <para><code>
    /// var mesh = ArrayMesh.new()
    /// mesh.add_surface_from_arrays(Mesh.PRIMITIVE_TRIANGLES, CubeMesh.new().get_mesh_arrays())
    /// var mdt = MeshDataTool.new()
    /// mdt.create_from_surface(mesh, 0)
    /// for i in range(mdt.get_vertex_count()):
    ///     var vertex = mdt.get_vertex(i)
    ///     # In this example we extend the mesh by one unit, which results in separated faces as it is flat shaded.
    ///     vertex += mdt.get_vertex_normal(i)
    ///     # Save your change.
    ///     mdt.set_vertex(i, vertex)
    /// mesh.surface_remove(0)
    /// mdt.commit_to_surface(mesh)
    /// var mi = MeshInstance.new()
    /// mi.mesh = mesh
    /// add_child(mi)
    /// </code></para>
    /// <para>See also <see cref="Godot.ArrayMesh"/>, <see cref="Godot.ImmediateGeometry"/> and <see cref="Godot.SurfaceTool"/> for procedural geometry generation.</para>
    /// <para>Note: Godot uses clockwise <a href="https://learnopengl.com/Advanced-OpenGL/Face-culling">winding order</a> for front faces of triangle primitive modes.</para>
    /// </summary>
    public partial class MeshDataTool : Reference
    {
        private const string nativeName = "MeshDataTool";

        public MeshDataTool() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_MeshDataTool_Ctor(this);
        }

        internal MeshDataTool(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Clears all data currently in MeshDataTool.</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_from_surface");

        /// <summary>
        /// <para>Uses specified surface of given <see cref="Godot.Mesh"/> to populate data for MeshDataTool.</para>
        /// <para>Requires <see cref="Godot.Mesh"/> with primitive type <see cref="Godot.Mesh.PrimitiveType.Triangles"/>.</para>
        /// </summary>
        [GodotMethod("create_from_surface")]
        public Error CreateFromSurface(ArrayMesh mesh, int surface)
        {
            return (Error)NativeCalls.godot_icall_2_597(method_bind_1, Object.GetPtr(this), Object.GetPtr(mesh), surface);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "commit_to_surface");

        /// <summary>
        /// <para>Adds a new surface to specified <see cref="Godot.Mesh"/> with edited data.</para>
        /// </summary>
        [GodotMethod("commit_to_surface")]
        public Error CommitToSurface(ArrayMesh mesh)
        {
            return (Error)NativeCalls.godot_icall_1_598(method_bind_2, Object.GetPtr(this), Object.GetPtr(mesh));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_format");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Mesh"/>'s format. Format is an integer made up of <see cref="Godot.Mesh"/> format flags combined together. For example, a mesh containing both vertices and normals would return a format of <c>3</c> because <see cref="Godot.ArrayMesh.ArrayFormat.Vertex"/> is <c>1</c> and <see cref="Godot.ArrayMesh.ArrayFormat.Normal"/> is <c>2</c>.</para>
        /// <para>See <see cref="Godot.ArrayMesh.ArrayFormat"/> for a list of format flags.</para>
        /// </summary>
        [GodotMethod("get_format")]
        public int GetFormat()
        {
            return NativeCalls.godot_icall_0_5(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_vertex_count");

        /// <summary>
        /// <para>Returns the total number of vertices in <see cref="Godot.Mesh"/>.</para>
        /// </summary>
        [GodotMethod("get_vertex_count")]
        public int GetVertexCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_edge_count");

        /// <summary>
        /// <para>Returns the number of edges in this <see cref="Godot.Mesh"/>.</para>
        /// </summary>
        [GodotMethod("get_edge_count")]
        public int GetEdgeCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_face_count");

        /// <summary>
        /// <para>Returns the number of faces in this <see cref="Godot.Mesh"/>.</para>
        /// </summary>
        [GodotMethod("get_face_count")]
        public int GetFaceCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_vertex");

        /// <summary>
        /// <para>Sets the position of the given vertex.</para>
        /// </summary>
        [GodotMethod("set_vertex")]
        public void SetVertex(int idx, Vector3 vertex)
        {
            NativeCalls.godot_icall_2_33(method_bind_7, Object.GetPtr(this), idx, ref vertex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_vertex");

        /// <summary>
        /// <para>Returns the vertex at given index.</para>
        /// </summary>
        [GodotMethod("get_vertex")]
        public Vector3 GetVertex(int idx)
        {
            NativeCalls.godot_icall_1_32(method_bind_8, Object.GetPtr(this), idx, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_vertex_normal");

        /// <summary>
        /// <para>Sets the normal of the given vertex.</para>
        /// </summary>
        [GodotMethod("set_vertex_normal")]
        public void SetVertexNormal(int idx, Vector3 normal)
        {
            NativeCalls.godot_icall_2_33(method_bind_9, Object.GetPtr(this), idx, ref normal);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_vertex_normal");

        /// <summary>
        /// <para>Returns the normal of the given vertex.</para>
        /// </summary>
        [GodotMethod("get_vertex_normal")]
        public Vector3 GetVertexNormal(int idx)
        {
            NativeCalls.godot_icall_1_32(method_bind_10, Object.GetPtr(this), idx, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_vertex_tangent");

        /// <summary>
        /// <para>Sets the tangent of the given vertex.</para>
        /// </summary>
        [GodotMethod("set_vertex_tangent")]
        public void SetVertexTangent(int idx, Plane tangent)
        {
            NativeCalls.godot_icall_2_599(method_bind_11, Object.GetPtr(this), idx, ref tangent);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_vertex_tangent");

        /// <summary>
        /// <para>Returns the tangent of the given vertex.</para>
        /// </summary>
        [GodotMethod("get_vertex_tangent")]
        public Plane GetVertexTangent(int idx)
        {
            NativeCalls.godot_icall_1_600(method_bind_12, Object.GetPtr(this), idx, out Plane argRet); return (Plane)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_vertex_uv");

        /// <summary>
        /// <para>Sets the UV of the given vertex.</para>
        /// </summary>
        [GodotMethod("set_vertex_uv")]
        public void SetVertexUv(int idx, Vector2 uv)
        {
            NativeCalls.godot_icall_2_45(method_bind_13, Object.GetPtr(this), idx, ref uv);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_vertex_uv");

        /// <summary>
        /// <para>Returns the UV of the given vertex.</para>
        /// </summary>
        [GodotMethod("get_vertex_uv")]
        public Vector2 GetVertexUv(int idx)
        {
            NativeCalls.godot_icall_1_44(method_bind_14, Object.GetPtr(this), idx, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_vertex_uv2");

        /// <summary>
        /// <para>Sets the UV2 of the given vertex.</para>
        /// </summary>
        [GodotMethod("set_vertex_uv2")]
        public void SetVertexUv2(int idx, Vector2 uv2)
        {
            NativeCalls.godot_icall_2_45(method_bind_15, Object.GetPtr(this), idx, ref uv2);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_vertex_uv2");

        /// <summary>
        /// <para>Returns the UV2 of the given vertex.</para>
        /// </summary>
        [GodotMethod("get_vertex_uv2")]
        public Vector2 GetVertexUv2(int idx)
        {
            NativeCalls.godot_icall_1_44(method_bind_16, Object.GetPtr(this), idx, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_vertex_color");

        /// <summary>
        /// <para>Sets the color of the given vertex.</para>
        /// </summary>
        [GodotMethod("set_vertex_color")]
        public void SetVertexColor(int idx, Color color)
        {
            NativeCalls.godot_icall_2_464(method_bind_17, Object.GetPtr(this), idx, ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_vertex_color");

        /// <summary>
        /// <para>Returns the color of the given vertex.</para>
        /// </summary>
        [GodotMethod("get_vertex_color")]
        public Color GetVertexColor(int idx)
        {
            NativeCalls.godot_icall_1_465(method_bind_18, Object.GetPtr(this), idx, out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_vertex_bones");

        /// <summary>
        /// <para>Sets the bones of the given vertex.</para>
        /// </summary>
        [GodotMethod("set_vertex_bones")]
        public void SetVertexBones(int idx, int[] bones)
        {
            NativeCalls.godot_icall_2_601(method_bind_19, Object.GetPtr(this), idx, bones);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_vertex_bones");

        /// <summary>
        /// <para>Returns the bones of the given vertex.</para>
        /// </summary>
        [GodotMethod("get_vertex_bones")]
        public int[] GetVertexBones(int idx)
        {
            return NativeCalls.godot_icall_1_36(method_bind_20, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_vertex_weights");

        /// <summary>
        /// <para>Sets the bone weights of the given vertex.</para>
        /// </summary>
        [GodotMethod("set_vertex_weights")]
        public void SetVertexWeights(int idx, float[] weights)
        {
            NativeCalls.godot_icall_2_602(method_bind_21, Object.GetPtr(this), idx, weights);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_vertex_weights");

        /// <summary>
        /// <para>Returns bone weights of the given vertex.</para>
        /// </summary>
        [GodotMethod("get_vertex_weights")]
        public float[] GetVertexWeights(int idx)
        {
            return NativeCalls.godot_icall_1_603(method_bind_22, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_vertex_meta");

        /// <summary>
        /// <para>Sets the metadata associated with the given vertex.</para>
        /// </summary>
        [GodotMethod("set_vertex_meta")]
        public void SetVertexMeta(int idx, object meta)
        {
            NativeCalls.godot_icall_2_542(method_bind_23, Object.GetPtr(this), idx, meta);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_vertex_meta");

        /// <summary>
        /// <para>Returns the metadata associated with the given vertex.</para>
        /// </summary>
        [GodotMethod("get_vertex_meta")]
        public object GetVertexMeta(int idx)
        {
            return NativeCalls.godot_icall_1_543(method_bind_24, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_vertex_edges");

        /// <summary>
        /// <para>Returns an array of edges that share the given vertex.</para>
        /// </summary>
        [GodotMethod("get_vertex_edges")]
        public int[] GetVertexEdges(int idx)
        {
            return NativeCalls.godot_icall_1_36(method_bind_25, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_vertex_faces");

        /// <summary>
        /// <para>Returns an array of faces that share the given vertex.</para>
        /// </summary>
        [GodotMethod("get_vertex_faces")]
        public int[] GetVertexFaces(int idx)
        {
            return NativeCalls.godot_icall_1_36(method_bind_26, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_edge_vertex");

        /// <summary>
        /// <para>Returns index of specified vertex connected to given edge.</para>
        /// <para>Vertex argument can only be 0 or 1 because edges are comprised of two vertices.</para>
        /// </summary>
        [GodotMethod("get_edge_vertex")]
        public int GetEdgeVertex(int idx, int vertex)
        {
            return NativeCalls.godot_icall_2_60(method_bind_27, Object.GetPtr(this), idx, vertex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_edge_faces");

        /// <summary>
        /// <para>Returns array of faces that touch given edge.</para>
        /// </summary>
        [GodotMethod("get_edge_faces")]
        public int[] GetEdgeFaces(int idx)
        {
            return NativeCalls.godot_icall_1_36(method_bind_28, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_edge_meta");

        /// <summary>
        /// <para>Sets the metadata of the given edge.</para>
        /// </summary>
        [GodotMethod("set_edge_meta")]
        public void SetEdgeMeta(int idx, object meta)
        {
            NativeCalls.godot_icall_2_542(method_bind_29, Object.GetPtr(this), idx, meta);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_edge_meta");

        /// <summary>
        /// <para>Returns meta information assigned to given edge.</para>
        /// </summary>
        [GodotMethod("get_edge_meta")]
        public object GetEdgeMeta(int idx)
        {
            return NativeCalls.godot_icall_1_543(method_bind_30, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_face_vertex");

        /// <summary>
        /// <para>Returns the specified vertex of the given face.</para>
        /// <para>Vertex argument must be either 0, 1, or 2 because faces contain three vertices.</para>
        /// </summary>
        [GodotMethod("get_face_vertex")]
        public int GetFaceVertex(int idx, int vertex)
        {
            return NativeCalls.godot_icall_2_60(method_bind_31, Object.GetPtr(this), idx, vertex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_face_edge");

        /// <summary>
        /// <para>Returns specified edge associated with given face.</para>
        /// <para>Edge argument must be either 0, 1, or 2 because a face only has three edges.</para>
        /// </summary>
        [GodotMethod("get_face_edge")]
        public int GetFaceEdge(int idx, int edge)
        {
            return NativeCalls.godot_icall_2_60(method_bind_32, Object.GetPtr(this), idx, edge);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_face_meta");

        /// <summary>
        /// <para>Sets the metadata of the given face.</para>
        /// </summary>
        [GodotMethod("set_face_meta")]
        public void SetFaceMeta(int idx, object meta)
        {
            NativeCalls.godot_icall_2_542(method_bind_33, Object.GetPtr(this), idx, meta);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_face_meta");

        /// <summary>
        /// <para>Returns the metadata associated with the given face.</para>
        /// </summary>
        [GodotMethod("get_face_meta")]
        public object GetFaceMeta(int idx)
        {
            return NativeCalls.godot_icall_1_543(method_bind_34, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_face_normal");

        /// <summary>
        /// <para>Calculates and returns the face normal of the given face.</para>
        /// </summary>
        [GodotMethod("get_face_normal")]
        public Vector3 GetFaceNormal(int idx)
        {
            NativeCalls.godot_icall_1_32(method_bind_35, Object.GetPtr(this), idx, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_material");

        /// <summary>
        /// <para>Sets the material to be used by newly-constructed <see cref="Godot.Mesh"/>.</para>
        /// </summary>
        [GodotMethod("set_material")]
        public void SetMaterial(Material material)
        {
            NativeCalls.godot_icall_1_24(method_bind_36, Object.GetPtr(this), Object.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_material");

        /// <summary>
        /// <para>Returns the material assigned to the <see cref="Godot.Mesh"/>.</para>
        /// </summary>
        [GodotMethod("get_material")]
        public Material GetMaterial()
        {
            return NativeCalls.godot_icall_0_237(method_bind_37, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
