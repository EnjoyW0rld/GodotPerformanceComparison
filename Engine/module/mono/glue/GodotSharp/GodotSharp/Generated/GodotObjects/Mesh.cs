using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Mesh is a type of <see cref="Godot.Resource"/> that contains vertex array-based geometry, divided in surfaces. Each surface contains a completely separate array and a material used to draw it. Design wise, a mesh with multiple surfaces is preferred to a single surface, because objects created in 3D editing software commonly contain multiple materials.</para>
    /// </summary>
    public abstract partial class Mesh : Resource
    {
        public enum BlendShapeMode
        {
            /// <summary>
            /// <para>Blend shapes are normalized.</para>
            /// </summary>
            Normalized = 0,
            /// <summary>
            /// <para>Blend shapes are relative to base weight.</para>
            /// </summary>
            Relative = 1
        }

        public enum PrimitiveType
        {
            /// <summary>
            /// <para>Render array as points (one vertex equals one point).</para>
            /// </summary>
            Points = 0,
            /// <summary>
            /// <para>Render array as lines (every two vertices a line is created).</para>
            /// </summary>
            Lines = 1,
            /// <summary>
            /// <para>Render array as line strip.</para>
            /// </summary>
            LineStrip = 2,
            /// <summary>
            /// <para>Render array as line loop (like line strip, but closed).</para>
            /// </summary>
            LineLoop = 3,
            /// <summary>
            /// <para>Render array as triangles (every three vertices a triangle is created).</para>
            /// </summary>
            Triangles = 4,
            /// <summary>
            /// <para>Render array as triangle strips.</para>
            /// </summary>
            TriangleStrip = 5,
            /// <summary>
            /// <para>Render array as triangle fans.</para>
            /// </summary>
            TriangleFan = 6
        }

        public enum ArrayFormat
        {
            /// <summary>
            /// <para>Mesh array contains vertices. All meshes require a vertex array so this should always be present.</para>
            /// </summary>
            FormatVertex = 1,
            /// <summary>
            /// <para>Mesh array contains normals.</para>
            /// </summary>
            FormatNormal = 2,
            /// <summary>
            /// <para>Mesh array contains tangents.</para>
            /// </summary>
            FormatTangent = 4,
            /// <summary>
            /// <para>Mesh array contains colors.</para>
            /// </summary>
            FormatColor = 8,
            /// <summary>
            /// <para>Mesh array contains UVs.</para>
            /// </summary>
            FormatTexUv = 16,
            /// <summary>
            /// <para>Mesh array contains second UV.</para>
            /// </summary>
            FormatTexUv2 = 32,
            /// <summary>
            /// <para>Mesh array contains bones.</para>
            /// </summary>
            FormatBones = 64,
            /// <summary>
            /// <para>Mesh array contains bone weights.</para>
            /// </summary>
            FormatWeights = 128,
            /// <summary>
            /// <para>Mesh array uses indices.</para>
            /// </summary>
            FormatIndex = 256,
            /// <summary>
            /// <para>Used internally to calculate other <c>ARRAY_COMPRESS_*</c> enum values. Do not use.</para>
            /// </summary>
            CompressBase = 9,
            /// <summary>
            /// <para>Flag used to mark a compressed (half float) vertex array.</para>
            /// </summary>
            CompressVertex = 512,
            /// <summary>
            /// <para>Flag used to mark a compressed (half float) normal array.</para>
            /// </summary>
            CompressNormal = 1024,
            /// <summary>
            /// <para>Flag used to mark a compressed (half float) tangent array.</para>
            /// </summary>
            CompressTangent = 2048,
            /// <summary>
            /// <para>Flag used to mark a compressed (half float) color array.</para>
            /// <para>Note: If this flag is enabled, vertex colors will be stored as 8-bit unsigned integers. This will clamp overbright colors to <c>Color(1, 1, 1, 1)</c> and reduce colors' precision.</para>
            /// </summary>
            CompressColor = 4096,
            /// <summary>
            /// <para>Flag used to mark a compressed (half float) UV coordinates array.</para>
            /// </summary>
            CompressTexUv = 8192,
            /// <summary>
            /// <para>Flag used to mark a compressed (half float) UV coordinates array for the second UV coordinates.</para>
            /// </summary>
            CompressTexUv2 = 16384,
            /// <summary>
            /// <para>Flag used to mark a compressed bone array.</para>
            /// </summary>
            CompressBones = 32768,
            /// <summary>
            /// <para>Flag used to mark a compressed (half float) weight array.</para>
            /// </summary>
            CompressWeights = 65536,
            /// <summary>
            /// <para>Flag used to mark a compressed index array.</para>
            /// </summary>
            CompressIndex = 131072,
            /// <summary>
            /// <para>Flag used to mark that the array contains 2D vertices.</para>
            /// </summary>
            FlagUse2dVertices = 262144,
            /// <summary>
            /// <para>Flag used to mark that the array uses 16-bit bones instead of 8-bit.</para>
            /// </summary>
            FlagUse16BitBones = 524288,
            /// <summary>
            /// <para>Flag used to mark that the array uses an octahedral representation of normal and tangent vectors rather than cartesian.</para>
            /// </summary>
            FlagUseOctahedralCompression = 2097152,
            /// <summary>
            /// <para>Used to set flags <see cref="Godot.Mesh.ArrayFormat.CompressVertex"/>, <see cref="Godot.Mesh.ArrayFormat.CompressNormal"/>, <see cref="Godot.Mesh.ArrayFormat.CompressTangent"/>, <see cref="Godot.Mesh.ArrayFormat.CompressColor"/>, <see cref="Godot.Mesh.ArrayFormat.CompressTexUv"/>, <see cref="Godot.Mesh.ArrayFormat.CompressTexUv2"/>, <see cref="Godot.Mesh.ArrayFormat.CompressWeights"/>, and <see cref="Godot.Mesh.ArrayFormat.FlagUseOctahedralCompression"/> quickly.</para>
            /// <para>Note: Since this flag enables <see cref="Godot.Mesh.ArrayFormat.CompressColor"/>, vertex colors will be stored as 8-bit unsigned integers. This will clamp overbright colors to <c>Color(1, 1, 1, 1)</c> and reduce colors' precision.</para>
            /// </summary>
            CompressDefault = 2194432
        }

        public enum ArrayType
        {
            /// <summary>
            /// <para>Array of vertices.</para>
            /// </summary>
            Vertex = 0,
            /// <summary>
            /// <para>Array of normals.</para>
            /// </summary>
            Normal = 1,
            /// <summary>
            /// <para>Array of tangents as an array of floats, 4 floats per tangent.</para>
            /// </summary>
            Tangent = 2,
            /// <summary>
            /// <para>Array of colors.</para>
            /// </summary>
            Color = 3,
            /// <summary>
            /// <para>Array of UV coordinates.</para>
            /// </summary>
            TexUv = 4,
            /// <summary>
            /// <para>Array of second set of UV coordinates.</para>
            /// </summary>
            TexUv2 = 5,
            /// <summary>
            /// <para>Array of bone data.</para>
            /// </summary>
            Bones = 6,
            /// <summary>
            /// <para>Array of weights.</para>
            /// </summary>
            Weights = 7,
            /// <summary>
            /// <para>Array of indices.</para>
            /// </summary>
            Index = 8,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.Mesh.ArrayType"/> enum.</para>
            /// </summary>
            Max = 9
        }

        /// <summary>
        /// <para>Sets a hint to be used for lightmap resolution in <see cref="Godot.BakedLightmap"/>. Overrides <see cref="Godot.BakedLightmap.DefaultTexelsPerUnit"/>.</para>
        /// </summary>
        public Vector2 LightmapSizeHint
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLightmapSizeHint();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLightmapSizeHint(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Mesh";

        internal Mesh() {}

        internal Mesh(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_lightmap_size_hint");

        [GodotMethod("set_lightmap_size_hint")]
        [Obsolete("SetLightmapSizeHint is deprecated. Use the LightmapSizeHint property instead.")]
        public void SetLightmapSizeHint(Vector2 size)
        {
            NativeCalls.godot_icall_1_57(method_bind_0, Object.GetPtr(this), ref size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_lightmap_size_hint");

        [GodotMethod("get_lightmap_size_hint")]
        [Obsolete("GetLightmapSizeHint is deprecated. Use the LightmapSizeHint property instead.")]
        public Vector2 GetLightmapSizeHint()
        {
            NativeCalls.godot_icall_0_18(method_bind_1, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_aabb");

        /// <summary>
        /// <para>Returns the smallest <see cref="Godot.AABB"/> enclosing this mesh in local space. Not affected by <c>custom_aabb</c>. See also <see cref="Godot.VisualInstance.GetTransformedAabb"/>.</para>
        /// <para>Note: This is only implemented for <see cref="Godot.ArrayMesh"/> and <see cref="Godot.PrimitiveMesh"/>.</para>
        /// </summary>
        [GodotMethod("get_aabb")]
        public AABB GetAabb()
        {
            NativeCalls.godot_icall_0_158(method_bind_2, Object.GetPtr(this), out AABB argRet); return (AABB)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_surface_count");

        /// <summary>
        /// <para>Returns the amount of surfaces that the <see cref="Godot.Mesh"/> holds.</para>
        /// </summary>
        [GodotMethod("get_surface_count")]
        public int GetSurfaceCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "surface_get_arrays");

        /// <summary>
        /// <para>Returns the arrays for the vertices, normals, uvs, etc. that make up the requested surface (see <see cref="Godot.ArrayMesh.AddSurfaceFromArrays"/>).</para>
        /// </summary>
        [GodotMethod("surface_get_arrays")]
        public Godot.Collections.Array SurfaceGetArrays(int surfIdx)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_1_483(method_bind_4, Object.GetPtr(this), surfIdx));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "surface_get_blend_shape_arrays");

        /// <summary>
        /// <para>Returns the blend shape arrays for the requested surface.</para>
        /// </summary>
        [GodotMethod("surface_get_blend_shape_arrays")]
        public Godot.Collections.Array SurfaceGetBlendShapeArrays(int surfIdx)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_1_483(method_bind_5, Object.GetPtr(this), surfIdx));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "surface_set_material");

        /// <summary>
        /// <para>Sets a <see cref="Godot.Material"/> for a given surface. Surface will be rendered using this material.</para>
        /// </summary>
        [GodotMethod("surface_set_material")]
        public void SurfaceSetMaterial(int surfIdx, Material material)
        {
            NativeCalls.godot_icall_2_58(method_bind_6, Object.GetPtr(this), surfIdx, Object.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "surface_get_material");

        /// <summary>
        /// <para>Returns a <see cref="Godot.Material"/> in a given surface. Surface is rendered using this material.</para>
        /// </summary>
        [GodotMethod("surface_get_material")]
        public Material SurfaceGetMaterial(int surfIdx)
        {
            return NativeCalls.godot_icall_1_594(method_bind_7, Object.GetPtr(this), surfIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_trimesh_shape");

        /// <summary>
        /// <para>Calculate a <see cref="Godot.ConcavePolygonShape"/> from the mesh.</para>
        /// </summary>
        [GodotMethod("create_trimesh_shape")]
        public Shape CreateTrimeshShape()
        {
            return NativeCalls.godot_icall_0_303(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_convex_shape");

        /// <summary>
        /// <para>Calculate a <see cref="Godot.ConvexPolygonShape"/> from the mesh.</para>
        /// <para>If <c>clean</c> is <c>true</c> (default), duplicate and interior vertices are removed automatically. You can set it to <c>false</c> to make the process faster if not needed.</para>
        /// <para>If <c>simplify</c> is <c>true</c>, the geometry can be further simplified to reduce the amount of vertices. Disabled by default.</para>
        /// </summary>
        [GodotMethod("create_convex_shape")]
        public Shape CreateConvexShape(bool clean = true, bool simplify = false)
        {
            return NativeCalls.godot_icall_2_595(method_bind_9, Object.GetPtr(this), clean, simplify);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_outline");

        /// <summary>
        /// <para>Calculate an outline mesh at a defined offset (margin) from the original mesh.</para>
        /// <para>Note: This method typically returns the vertices in reverse order (e.g. clockwise to counterclockwise).</para>
        /// </summary>
        [GodotMethod("create_outline")]
        public Mesh CreateOutline(float margin)
        {
            return NativeCalls.godot_icall_1_596(method_bind_10, Object.GetPtr(this), margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_faces");

        /// <summary>
        /// <para>Returns all the vertices that make up the faces of the mesh. Each three vertices represent one triangle.</para>
        /// </summary>
        [GodotMethod("get_faces")]
        public Vector3[] GetFaces()
        {
            return NativeCalls.godot_icall_0_230(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "generate_triangle_mesh");

        /// <summary>
        /// <para>Generate a <see cref="Godot.TriangleMesh"/> from the mesh.</para>
        /// </summary>
        [GodotMethod("generate_triangle_mesh")]
        public TriangleMesh GenerateTriangleMesh()
        {
            return NativeCalls.godot_icall_0_580(method_bind_12, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
