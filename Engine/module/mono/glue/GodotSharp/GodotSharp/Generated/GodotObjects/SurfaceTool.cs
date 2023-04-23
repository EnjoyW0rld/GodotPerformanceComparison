using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The <see cref="Godot.SurfaceTool"/> is used to construct a <see cref="Godot.Mesh"/> by specifying vertex attributes individually. It can be used to construct a <see cref="Godot.Mesh"/> from a script. All properties except indices need to be added before calling <see cref="Godot.SurfaceTool.AddVertex"/>. For example, to add vertex colors and UVs:</para>
    /// <para><code>
    /// var st = SurfaceTool.new()
    /// st.begin(Mesh.PRIMITIVE_TRIANGLES)
    /// st.add_color(Color(1, 0, 0))
    /// st.add_uv(Vector2(0, 0))
    /// st.add_vertex(Vector3(0, 0, 0))
    /// </code></para>
    /// <para>The above <see cref="Godot.SurfaceTool"/> now contains one vertex of a triangle which has a UV coordinate and a specified <see cref="Godot.Color"/>. If another vertex were added without calling <see cref="Godot.SurfaceTool.AddUv"/> or <see cref="Godot.SurfaceTool.AddColor"/>, then the last values would be used.</para>
    /// <para>Vertex attributes must be passed before calling <see cref="Godot.SurfaceTool.AddVertex"/>. Failure to do so will result in an error when committing the vertex information to a mesh.</para>
    /// <para>Additionally, the attributes used before the first vertex is added determine the format of the mesh. For example, if you only add UVs to the first vertex, you cannot add color to any of the subsequent vertices.</para>
    /// <para>See also <see cref="Godot.ArrayMesh"/>, <see cref="Godot.ImmediateGeometry"/> and <see cref="Godot.MeshDataTool"/> for procedural geometry generation.</para>
    /// <para>Note: Godot uses clockwise <a href="https://learnopengl.com/Advanced-OpenGL/Face-culling">winding order</a> for front faces of triangle primitive modes.</para>
    /// </summary>
    public partial class SurfaceTool : Reference
    {
        private const string nativeName = "SurfaceTool";

        public SurfaceTool() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_SurfaceTool_Ctor(this);
        }

        internal SurfaceTool(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "begin");

        /// <summary>
        /// <para>Called before adding any vertices. Takes the primitive type as an argument (e.g. <see cref="Godot.Mesh.PrimitiveType.Triangles"/>).</para>
        /// </summary>
        [GodotMethod("begin")]
        public void Begin(Mesh.PrimitiveType primitive)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)primitive);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_vertex");

        /// <summary>
        /// <para>Specifies the position of current vertex. Should be called after specifying other vertex properties (e.g. Color, UV).</para>
        /// </summary>
        [GodotMethod("add_vertex")]
        public void AddVertex(Vector3 vertex)
        {
            NativeCalls.godot_icall_1_148(method_bind_1, Object.GetPtr(this), ref vertex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_color");

        /// <summary>
        /// <para>Specifies a <see cref="Godot.Color"/> to use for the next vertex. If every vertex needs to have this information set and you fail to submit it for the first vertex, this information may not be used at all.</para>
        /// <para>Note: The material must have <see cref="Godot.SpatialMaterial.VertexColorUseAsAlbedo"/> enabled for the vertex color to be visible.</para>
        /// </summary>
        [GodotMethod("add_color")]
        public void AddColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_2, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_normal");

        /// <summary>
        /// <para>Specifies a normal to use for the next vertex. If every vertex needs to have this information set and you fail to submit it for the first vertex, this information may not be used at all.</para>
        /// </summary>
        [GodotMethod("add_normal")]
        public void AddNormal(Vector3 normal)
        {
            NativeCalls.godot_icall_1_148(method_bind_3, Object.GetPtr(this), ref normal);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_tangent");

        /// <summary>
        /// <para>Specifies a tangent to use for the next vertex. If every vertex needs to have this information set and you fail to submit it for the first vertex, this information may not be used at all.</para>
        /// </summary>
        [GodotMethod("add_tangent")]
        public void AddTangent(Plane tangent)
        {
            NativeCalls.godot_icall_1_519(method_bind_4, Object.GetPtr(this), ref tangent);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_uv");

        /// <summary>
        /// <para>Specifies a set of UV coordinates to use for the next vertex. If every vertex needs to have this information set and you fail to submit it for the first vertex, this information may not be used at all.</para>
        /// </summary>
        [GodotMethod("add_uv")]
        public void AddUv(Vector2 uv)
        {
            NativeCalls.godot_icall_1_57(method_bind_5, Object.GetPtr(this), ref uv);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_uv2");

        /// <summary>
        /// <para>Specifies an optional second set of UV coordinates to use for the next vertex. If every vertex needs to have this information set and you fail to submit it for the first vertex, this information may not be used at all.</para>
        /// </summary>
        [GodotMethod("add_uv2")]
        public void AddUv2(Vector2 uv2)
        {
            NativeCalls.godot_icall_1_57(method_bind_6, Object.GetPtr(this), ref uv2);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_bones");

        /// <summary>
        /// <para>Specifies an array of bones to use for the next vertex. <c>bones</c> must contain 4 integers.</para>
        /// </summary>
        [GodotMethod("add_bones")]
        public void AddBones(int[] bones)
        {
            NativeCalls.godot_icall_1_102(method_bind_7, Object.GetPtr(this), bones);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_weights");

        /// <summary>
        /// <para>Specifies weight values to use for the next vertex. <c>weights</c> must contain 4 values. If every vertex needs to have this information set and you fail to submit it for the first vertex, this information may not be used at all.</para>
        /// </summary>
        [GodotMethod("add_weights")]
        public void AddWeights(float[] weights)
        {
            NativeCalls.godot_icall_1_452(method_bind_8, Object.GetPtr(this), weights);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_smooth_group");

        /// <summary>
        /// <para>Specifies whether the current vertex (if using only vertex arrays) or current index (if also using index arrays) should use smooth normals for normal calculation.</para>
        /// </summary>
        [GodotMethod("add_smooth_group")]
        public void AddSmoothGroup(bool smooth)
        {
            NativeCalls.godot_icall_1_16(method_bind_9, Object.GetPtr(this), smooth);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_triangle_fan");

        /// <summary>
        /// <para>Inserts a triangle fan made of array data into <see cref="Godot.Mesh"/> being constructed.</para>
        /// <para>Requires the primitive type be set to <see cref="Godot.Mesh.PrimitiveType.Triangles"/>.</para>
        /// </summary>
        /// <param name="uvs">If the parameter is null, then the default value is Array.Empty&lt;Vector2&gt;()</param>
        /// <param name="colors">If the parameter is null, then the default value is Array.Empty&lt;Color&gt;()</param>
        /// <param name="uv2s">If the parameter is null, then the default value is Array.Empty&lt;Vector2&gt;()</param>
        /// <param name="normals">If the parameter is null, then the default value is Array.Empty&lt;Vector3&gt;()</param>
        /// <param name="tangents">If the parameter is null, then the default value is new Godot.Collections.Array { }</param>
        [GodotMethod("add_triangle_fan")]
        public void AddTriangleFan(Vector3[] vertices, Vector2[] uvs = null, Color[] colors = null, Vector2[] uv2s = null, Vector3[] normals = null, Godot.Collections.Array tangents = null)
        {
            Vector2[] uvs_in = uvs != null ? uvs : Array.Empty<Vector2>();
            Color[] colors_in = colors != null ? colors : Array.Empty<Color>();
            Vector2[] uv2s_in = uv2s != null ? uv2s : Array.Empty<Vector2>();
            Vector3[] normals_in = normals != null ? normals : Array.Empty<Vector3>();
            Godot.Collections.Array tangents_in = tangents != null ? tangents : new Godot.Collections.Array { };
            NativeCalls.godot_icall_6_905(method_bind_10, Object.GetPtr(this), vertices, uvs_in, colors_in, uv2s_in, normals_in, tangents_in.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_index");

        /// <summary>
        /// <para>Adds an index to index array if you are using indexed vertices. Does not need to be called before adding vertices.</para>
        /// </summary>
        [GodotMethod("add_index")]
        public void AddIndex(int index)
        {
            NativeCalls.godot_icall_1_4(method_bind_11, Object.GetPtr(this), index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "index");

        /// <summary>
        /// <para>Shrinks the vertex array by creating an index array. This can improve performance by avoiding vertex reuse.</para>
        /// </summary>
        [GodotMethod("index")]
        public void Index()
        {
            NativeCalls.godot_icall_0_3(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "deindex");

        /// <summary>
        /// <para>Removes the index array by expanding the vertex array.</para>
        /// </summary>
        [GodotMethod("deindex")]
        public void Deindex()
        {
            NativeCalls.godot_icall_0_3(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "generate_normals");

        /// <summary>
        /// <para>Generates normals from vertices so you do not have to do it manually. If <c>flip</c> is <c>true</c>, the resulting normals will be inverted. <see cref="Godot.SurfaceTool.GenerateNormals"/> should be called after generating geometry and before committing the mesh using <see cref="Godot.SurfaceTool.Commit"/> or <see cref="Godot.SurfaceTool.CommitToArrays"/>. For correct display of normal-mapped surfaces, you will also have to generate tangents using <see cref="Godot.SurfaceTool.GenerateTangents"/>.</para>
        /// <para>Note: <see cref="Godot.SurfaceTool.GenerateNormals"/> only works if the primitive type to be set to <see cref="Godot.Mesh.PrimitiveType.Triangles"/>.</para>
        /// </summary>
        [GodotMethod("generate_normals")]
        public void GenerateNormals(bool flip = false)
        {
            NativeCalls.godot_icall_1_16(method_bind_14, Object.GetPtr(this), flip);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "generate_tangents");

        /// <summary>
        /// <para>Generates a tangent vector for each vertex. Requires that each vertex have UVs and normals set already (see <see cref="Godot.SurfaceTool.GenerateNormals"/>).</para>
        /// </summary>
        [GodotMethod("generate_tangents")]
        public void GenerateTangents()
        {
            NativeCalls.godot_icall_0_3(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_material");

        /// <summary>
        /// <para>Sets <see cref="Godot.Material"/> to be used by the <see cref="Godot.Mesh"/> you are constructing.</para>
        /// </summary>
        [GodotMethod("set_material")]
        public void SetMaterial(Material material)
        {
            NativeCalls.godot_icall_1_24(method_bind_16, Object.GetPtr(this), Object.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Clear all information passed into the surface tool so far.</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_from");

        /// <summary>
        /// <para>Creates a vertex array from an existing <see cref="Godot.Mesh"/>.</para>
        /// </summary>
        [GodotMethod("create_from")]
        public void CreateFrom(Mesh existing, int surface)
        {
            NativeCalls.godot_icall_2_906(method_bind_18, Object.GetPtr(this), Object.GetPtr(existing), surface);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_from_blend_shape");

        /// <summary>
        /// <para>Creates a vertex array from the specified blend shape of an existing <see cref="Godot.Mesh"/>. This can be used to extract a specific pose from a blend shape.</para>
        /// </summary>
        [GodotMethod("create_from_blend_shape")]
        public void CreateFromBlendShape(Mesh existing, int surface, string blendShape)
        {
            NativeCalls.godot_icall_3_907(method_bind_19, Object.GetPtr(this), Object.GetPtr(existing), surface, blendShape);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "append_from");

        /// <summary>
        /// <para>Append vertices from a given <see cref="Godot.Mesh"/> surface onto the current vertex array with specified <see cref="Godot.Transform"/>.</para>
        /// <para>Note: Using <see cref="Godot.SurfaceTool.AppendFrom"/> on a <see cref="Godot.Thread"/> is much slower as the GPU must communicate data back to the CPU, while also causing the main thread to stall (as OpenGL is not thread-safe). Consider requesting a copy of the mesh, converting it to an <see cref="Godot.ArrayMesh"/> and adding vertices manually instead.</para>
        /// </summary>
        [GodotMethod("append_from")]
        public void AppendFrom(Mesh existing, int surface, Transform transform)
        {
            NativeCalls.godot_icall_3_908(method_bind_20, Object.GetPtr(this), Object.GetPtr(existing), surface, ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "commit");

        /// <summary>
        /// <para>Returns a constructed <see cref="Godot.ArrayMesh"/> from current information passed in. If an existing <see cref="Godot.ArrayMesh"/> is passed in as an argument, will add an extra surface to the existing <see cref="Godot.ArrayMesh"/>.</para>
        /// <para>Default flag is <see cref="Godot.Mesh.ArrayFormat.CompressDefault"/> if compression is enabled. If compression is disabled the default flag is <see cref="Godot.Mesh.ArrayFormat.FlagUseOctahedralCompression"/>. See <c>ARRAY_COMPRESS_*</c> constants in <see cref="Godot.Mesh.ArrayFormat"/> for other flags.</para>
        /// </summary>
        [GodotMethod("commit")]
        public ArrayMesh Commit(ArrayMesh existing = null, uint flags = (uint)2194432)
        {
            return NativeCalls.godot_icall_2_909(method_bind_21, Object.GetPtr(this), Object.GetPtr(existing), flags);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "commit_to_arrays");

        /// <summary>
        /// <para>Commits the data to the same format used by <see cref="Godot.ArrayMesh.AddSurfaceFromArrays"/>. This way you can further process the mesh data using the <see cref="Godot.ArrayMesh"/> API.</para>
        /// </summary>
        [GodotMethod("commit_to_arrays")]
        public Godot.Collections.Array CommitToArrays()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_22, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
