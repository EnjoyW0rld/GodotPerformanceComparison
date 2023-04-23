using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The <see cref="Godot.ArrayMesh"/> is used to construct a <see cref="Godot.Mesh"/> by specifying the attributes as arrays.</para>
    /// <para>The most basic example is the creation of a single triangle:</para>
    /// <para><code>
    /// var vertices = PoolVector3Array()
    /// vertices.push_back(Vector3(0, 1, 0))
    /// vertices.push_back(Vector3(1, 0, 0))
    /// vertices.push_back(Vector3(0, 0, 1))
    /// # Initialize the ArrayMesh.
    /// var arr_mesh = ArrayMesh.new()
    /// var arrays = []
    /// arrays.resize(ArrayMesh.ARRAY_MAX)
    /// arrays[ArrayMesh.ARRAY_VERTEX] = vertices
    /// # Create the Mesh.
    /// arr_mesh.add_surface_from_arrays(Mesh.PRIMITIVE_TRIANGLES, arrays)
    /// var m = MeshInstance.new()
    /// m.mesh = arr_mesh
    /// </code></para>
    /// <para>The <see cref="Godot.MeshInstance"/> is ready to be added to the <see cref="Godot.SceneTree"/> to be shown.</para>
    /// <para>See also <see cref="Godot.ImmediateGeometry"/>, <see cref="Godot.MeshDataTool"/> and <see cref="Godot.SurfaceTool"/> for procedural geometry generation.</para>
    /// <para>Note: Godot uses clockwise <a href="https://learnopengl.com/Advanced-OpenGL/Face-culling">winding order</a> for front faces of triangle primitive modes.</para>
    /// </summary>
    public partial class ArrayMesh : Mesh
    {
        /// <summary>
        /// <para>Value used internally when no indices are present.</para>
        /// </summary>
        public const int NoIndexArray = -1;
        /// <summary>
        /// <para>Amount of weights/bone indices per vertex (always 4).</para>
        /// </summary>
        public const int ArrayWeightsSize = 4;

        public enum ArrayFormat
        {
            /// <summary>
            /// <para>Array format will include vertices (mandatory).</para>
            /// </summary>
            Vertex = 1,
            /// <summary>
            /// <para>Array format will include normals.</para>
            /// </summary>
            Normal = 2,
            /// <summary>
            /// <para>Array format will include tangents.</para>
            /// </summary>
            Tangent = 4,
            /// <summary>
            /// <para>Array format will include a color array.</para>
            /// </summary>
            Color = 8,
            /// <summary>
            /// <para>Array format will include UVs.</para>
            /// </summary>
            TexUv = 16,
            /// <summary>
            /// <para>Array format will include another set of UVs.</para>
            /// </summary>
            TexUv2 = 32,
            /// <summary>
            /// <para>Array format will include bone indices.</para>
            /// </summary>
            Bones = 64,
            /// <summary>
            /// <para>Array format will include bone weights.</para>
            /// </summary>
            Weights = 128,
            /// <summary>
            /// <para>Index array will be used.</para>
            /// </summary>
            Index = 256
        }

        public enum ArrayType
        {
            /// <summary>
            /// <para><see cref="Godot.Vector3"/>, <see cref="Godot.Vector2"/>, or <see cref="Godot.Collections.Array"/> of vertex positions.</para>
            /// </summary>
            Vertex = 0,
            /// <summary>
            /// <para><see cref="Godot.Vector3"/> of vertex normals.</para>
            /// </summary>
            Normal = 1,
            /// <summary>
            /// <para><see cref="float"/> of vertex tangents. Each element in groups of 4 floats, first 3 floats determine the tangent, and the last the binormal direction as -1 or 1.</para>
            /// </summary>
            Tangent = 2,
            /// <summary>
            /// <para><see cref="Godot.Color"/> of vertex colors.</para>
            /// </summary>
            Color = 3,
            /// <summary>
            /// <para><see cref="Godot.Vector2"/> for UV coordinates.</para>
            /// </summary>
            TexUv = 4,
            /// <summary>
            /// <para><see cref="Godot.Vector2"/> for second UV coordinates.</para>
            /// </summary>
            TexUv2 = 5,
            /// <summary>
            /// <para><see cref="float"/> or <see cref="int"/> of bone indices. Each element in groups of 4 floats.</para>
            /// </summary>
            Bones = 6,
            /// <summary>
            /// <para><see cref="float"/> of bone weights. Each element in groups of 4 floats.</para>
            /// </summary>
            Weights = 7,
            /// <summary>
            /// <para><see cref="int"/> of integers used as indices referencing vertices, colors, normals, tangents, and textures. All of those arrays must have the same number of elements as the vertex array. No index can be beyond the vertex array size. When this index array is present, it puts the function into "index mode," where the index selects the *i*'th vertex, normal, tangent, color, UV, etc. This means if you want to have different normals or colors along an edge, you have to duplicate the vertices.</para>
            /// <para>For triangles, the index array is interpreted as triples, referring to the vertices of each triangle. For lines, the index array is in pairs indicating the start and end of each line.</para>
            /// </summary>
            Index = 8,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.ArrayMesh.ArrayType"/> enum.</para>
            /// </summary>
            Max = 9
        }

        /// <summary>
        /// <para>Sets the blend shape mode to one of <see cref="Godot.Mesh.BlendShapeMode"/>.</para>
        /// </summary>
        public Mesh.BlendShapeMode BlendShapeMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendShapeMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendShapeMode(value);
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

        private const string nativeName = "ArrayMesh";

        public ArrayMesh() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ArrayMesh_Ctor(this);
        }

        internal ArrayMesh(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_blend_shape");

        /// <summary>
        /// <para>Adds name for a blend shape that will be added with <see cref="Godot.ArrayMesh.AddSurfaceFromArrays"/>. Must be called before surface is added.</para>
        /// </summary>
        [GodotMethod("add_blend_shape")]
        public void AddBlendShape(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_blend_shape_count");

        /// <summary>
        /// <para>Returns the number of blend shapes that the <see cref="Godot.ArrayMesh"/> holds.</para>
        /// </summary>
        [GodotMethod("get_blend_shape_count")]
        public int GetBlendShapeCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_blend_shape_name");

        /// <summary>
        /// <para>Returns the name of the blend shape at this index.</para>
        /// </summary>
        [GodotMethod("get_blend_shape_name")]
        public string GetBlendShapeName(int index)
        {
            return NativeCalls.godot_icall_1_89(method_bind_2, Object.GetPtr(this), index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_blend_shape_name");

        [GodotMethod("set_blend_shape_name")]
        public void SetBlendShapeName(int index, string name)
        {
            NativeCalls.godot_icall_2_121(method_bind_3, Object.GetPtr(this), index, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_blend_shapes");

        /// <summary>
        /// <para>Removes all blend shapes from this <see cref="Godot.ArrayMesh"/>.</para>
        /// </summary>
        [GodotMethod("clear_blend_shapes")]
        public void ClearBlendShapes()
        {
            NativeCalls.godot_icall_0_3(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_blend_shape_mode");

        [GodotMethod("set_blend_shape_mode")]
        [Obsolete("SetBlendShapeMode is deprecated. Use the BlendShapeMode property instead.")]
        public void SetBlendShapeMode(Mesh.BlendShapeMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_5, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_blend_shape_mode");

        [GodotMethod("get_blend_shape_mode")]
        [Obsolete("GetBlendShapeMode is deprecated. Use the BlendShapeMode property instead.")]
        public Mesh.BlendShapeMode GetBlendShapeMode()
        {
            return (Mesh.BlendShapeMode)NativeCalls.godot_icall_0_151(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_surface_from_arrays");

        /// <summary>
        /// <para>Creates a new surface.</para>
        /// <para>Surfaces are created to be rendered using a <c>primitive</c>, which may be any of the types defined in <see cref="Godot.Mesh.PrimitiveType"/>. (As a note, when using indices, it is recommended to only use points, lines, or triangles.) <see cref="Godot.Mesh.GetSurfaceCount"/> will become the <c>surf_idx</c> for this new surface.</para>
        /// <para>The <c>arrays</c> argument is an array of arrays. See <see cref="Godot.ArrayMesh.ArrayType"/> for the values used in this array. For example, <c>arrays[0]</c> is the array of vertices. That first vertex sub-array is always required; the others are optional. Adding an index array puts this function into "index mode" where the vertex and other arrays become the sources of data and the index array defines the vertex order. All sub-arrays must have the same length as the vertex array or be empty, except for <see cref="Godot.ArrayMesh.ArrayType.Index"/> if it is used.</para>
        /// <para><c>compress_flags</c> is a bitfield made of <see cref="Godot.Mesh.ArrayFormat"/> values. It defaults to <see cref="Godot.Mesh.ArrayFormat.CompressDefault"/>.</para>
        /// <para>Note: The default <c>compress_flags</c> enable <see cref="Godot.Mesh.ArrayFormat.CompressColor"/>, which makes vertex colors stored as 8-bit unsigned integers. This will clamp overbright vertex colors to <c>Color(1, 1, 1, 1)</c> and reduce their precision. To store HDR vertex colors, remove the vertex color compression flag by passing <c>Mesh.ARRAY_COMPRESS_DEFAULT ^ Mesh.ARRAY_COMPRESS_COLOR</c> as the value of <c>compress_flags</c>.</para>
        /// </summary>
        /// <param name="blendShapes">If the parameter is null, then the default value is new Godot.Collections.Array { }</param>
        [GodotMethod("add_surface_from_arrays")]
        public void AddSurfaceFromArrays(Mesh.PrimitiveType primitive, Godot.Collections.Array arrays, Godot.Collections.Array blendShapes = null, uint compressFlags = (uint)2194432)
        {
            Godot.Collections.Array blendShapes_in = blendShapes != null ? blendShapes : new Godot.Collections.Array { };
            NativeCalls.godot_icall_4_152(method_bind_7, Object.GetPtr(this), (int)primitive, arrays.GetPtr(), blendShapes_in.GetPtr(), compressFlags);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_surfaces");

        /// <summary>
        /// <para>Removes all surfaces from this <see cref="Godot.ArrayMesh"/>.</para>
        /// </summary>
        [GodotMethod("clear_surfaces")]
        public void ClearSurfaces()
        {
            NativeCalls.godot_icall_0_3(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "surface_remove");

        /// <summary>
        /// <para>Removes a surface at position <c>surf_idx</c>, shifting greater surfaces one <c>surf_idx</c> slot down.</para>
        /// </summary>
        [GodotMethod("surface_remove")]
        public void SurfaceRemove(int surfIdx)
        {
            NativeCalls.godot_icall_1_4(method_bind_9, Object.GetPtr(this), surfIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "surface_update_region");

        /// <summary>
        /// <para>Updates a specified region of mesh arrays on the GPU.</para>
        /// <para>Warning: Only use if you know what you are doing. You can easily cause crashes by calling this function with improper arguments.</para>
        /// </summary>
        [GodotMethod("surface_update_region")]
        public void SurfaceUpdateRegion(int surfIdx, int offset, byte[] data)
        {
            NativeCalls.godot_icall_3_153(method_bind_10, Object.GetPtr(this), surfIdx, offset, data);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "surface_get_array_len");

        /// <summary>
        /// <para>Returns the length in vertices of the vertex array in the requested surface (see <see cref="Godot.ArrayMesh.AddSurfaceFromArrays"/>).</para>
        /// </summary>
        [GodotMethod("surface_get_array_len")]
        public int SurfaceGetArrayLen(int surfIdx)
        {
            return NativeCalls.godot_icall_1_11(method_bind_11, Object.GetPtr(this), surfIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "surface_get_array_index_len");

        /// <summary>
        /// <para>Returns the length in indices of the index array in the requested surface (see <see cref="Godot.ArrayMesh.AddSurfaceFromArrays"/>).</para>
        /// </summary>
        [GodotMethod("surface_get_array_index_len")]
        public int SurfaceGetArrayIndexLen(int surfIdx)
        {
            return NativeCalls.godot_icall_1_11(method_bind_12, Object.GetPtr(this), surfIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "surface_get_format");

        /// <summary>
        /// <para>Returns the format mask of the requested surface (see <see cref="Godot.ArrayMesh.AddSurfaceFromArrays"/>).</para>
        /// </summary>
        [GodotMethod("surface_get_format")]
        public uint SurfaceGetFormat(int surfIdx)
        {
            return NativeCalls.godot_icall_1_154(method_bind_13, Object.GetPtr(this), surfIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "surface_get_primitive_type");

        /// <summary>
        /// <para>Returns the primitive type of the requested surface (see <see cref="Godot.ArrayMesh.AddSurfaceFromArrays"/>).</para>
        /// </summary>
        [GodotMethod("surface_get_primitive_type")]
        public Mesh.PrimitiveType SurfaceGetPrimitiveType(int surfIdx)
        {
            return (Mesh.PrimitiveType)NativeCalls.godot_icall_1_155(method_bind_14, Object.GetPtr(this), surfIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "surface_find_by_name");

        /// <summary>
        /// <para>Returns the index of the first surface with this name held within this <see cref="Godot.ArrayMesh"/>. If none are found, -1 is returned.</para>
        /// </summary>
        [GodotMethod("surface_find_by_name")]
        public int SurfaceFindByName(string name)
        {
            return NativeCalls.godot_icall_1_138(method_bind_15, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "surface_set_name");

        /// <summary>
        /// <para>Sets a name for a given surface.</para>
        /// </summary>
        [GodotMethod("surface_set_name")]
        public void SurfaceSetName(int surfIdx, string name)
        {
            NativeCalls.godot_icall_2_121(method_bind_16, Object.GetPtr(this), surfIdx, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "surface_get_name");

        /// <summary>
        /// <para>Gets the name assigned to this surface.</para>
        /// </summary>
        [GodotMethod("surface_get_name")]
        public string SurfaceGetName(int surfIdx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_17, Object.GetPtr(this), surfIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "regen_normalmaps");

        /// <summary>
        /// <para>Will regenerate normal maps for the <see cref="Godot.ArrayMesh"/>.</para>
        /// </summary>
        [GodotMethod("regen_normalmaps")]
        public void RegenNormalmaps()
        {
            NativeCalls.godot_icall_0_3(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "lightmap_unwrap");

        /// <summary>
        /// <para>Will perform a UV unwrap on the <see cref="Godot.ArrayMesh"/> to prepare the mesh for lightmapping.</para>
        /// </summary>
        [GodotMethod("lightmap_unwrap")]
        public Error LightmapUnwrap(Transform transform, float texelSize)
        {
            return (Error)NativeCalls.godot_icall_2_156(method_bind_19, Object.GetPtr(this), ref transform, texelSize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_custom_aabb");

        [GodotMethod("set_custom_aabb")]
        [Obsolete("SetCustomAabb is deprecated. Use the CustomAabb property instead.")]
        public void SetCustomAabb(AABB aabb)
        {
            NativeCalls.godot_icall_1_157(method_bind_20, Object.GetPtr(this), ref aabb);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_custom_aabb");

        [GodotMethod("get_custom_aabb")]
        [Obsolete("GetCustomAabb is deprecated. Use the CustomAabb property instead.")]
        public AABB GetCustomAabb()
        {
            NativeCalls.godot_icall_0_158(method_bind_21, Object.GetPtr(this), out AABB argRet); return (AABB)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
