using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A Polygon2D is defined by a set of points. Each point is connected to the next, with the final point being connected to the first, resulting in a closed polygon. Polygon2Ds can be filled with color (solid or gradient) or filled with a given texture.</para>
    /// <para>Note: By default, Godot can only draw up to 4,096 polygon points at a time. To increase this limit, open the Project Settings and increase  and .</para>
    /// </summary>
    public partial class Polygon2D : Node2D
    {
        /// <summary>
        /// <para>The polygon's fill color. If <c>texture</c> is defined, it will be multiplied by this color. It will also be the default color for vertices not set in <c>vertex_colors</c>.</para>
        /// </summary>
        public Color Color
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The offset applied to each vertex.</para>
        /// </summary>
        public Vector2 Offset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, attempts to perform antialiasing for polygon edges by drawing a thin OpenGL smooth line on the edges.</para>
        /// <para>Note: Due to how it works, built-in antialiasing will not look correct for translucent polygons and may not work on certain platforms. As a workaround, install the <a href="https://github.com/godot-extended-libraries/godot-antialiased-line2d">Antialiased Line2D</a> add-on then create an AntialiasedPolygon2D node. That node relies on a texture with custom mipmaps to perform antialiasing.</para>
        /// </summary>
        public bool Antialiased
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAntialiased();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAntialiased(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The polygon's fill texture. Use <c>uv</c> to set texture coordinates.</para>
        /// </summary>
        public Texture Texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexture();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexture(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Amount to offset the polygon's <c>texture</c>. If <c>(0, 0)</c> the texture's origin (its top-left corner) will be placed at the polygon's <c>position</c>.</para>
        /// </summary>
        public Vector2 TextureOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTextureOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTextureOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Amount to multiply the <c>uv</c> coordinates when using a <c>texture</c>. Larger values make the texture smaller, and vice versa.</para>
        /// </summary>
        public Vector2 TextureScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTextureScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTextureScale(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The texture's rotation in degrees.</para>
        /// </summary>
        public float TextureRotationDegrees
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTextureRotationDegrees();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTextureRotationDegrees(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The texture's rotation in radians.</para>
        /// </summary>
        public float TextureRotation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTextureRotation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTextureRotation(value);
            }
#pragma warning restore CS0618
        }

        public NodePath Skeleton
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSkeleton();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSkeleton(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, polygon will be inverted, containing the area outside the defined points and extending to the <c>invert_border</c>.</para>
        /// </summary>
        public bool InvertEnable
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInvert();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInvert(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Added padding applied to the bounding box when using <c>invert</c>. Setting this value too small may result in a "Bad Polygon" error.</para>
        /// </summary>
        public float InvertBorder
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInvertBorder();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInvertBorder(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The polygon's list of vertices. The final point will be connected to the first.</para>
        /// <para>Note: This returns a copy of the <see cref="Godot.Vector2"/> rather than a reference.</para>
        /// </summary>
        public Vector2[] Polygon
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPolygon();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPolygon(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Texture coordinates for each vertex of the polygon. There should be one <c>uv</c> per polygon vertex. If there are fewer, undefined vertices will use <c>(0, 0)</c>.</para>
        /// </summary>
        public Vector2[] Uv
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUv();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUv(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Color for each vertex. Colors are interpolated between vertices, resulting in smooth gradients. There should be one per polygon vertex. If there are fewer, undefined vertices will use <c>color</c>.</para>
        /// </summary>
        public Color[] VertexColors
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVertexColors();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVertexColors(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array Polygons
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPolygons();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPolygons(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array Bones
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetBones();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetBones(value);
            }
#pragma warning restore CS0618
        }

        public int InternalVertexCount
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInternalVertexCount();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInternalVertexCount(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Polygon2D";

        public Polygon2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Polygon2D_Ctor(this);
        }

        internal Polygon2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_polygon");

        [GodotMethod("set_polygon")]
        [Obsolete("SetPolygon is deprecated. Use the Polygon property instead.")]
        public void SetPolygon(Vector2[] polygon)
        {
            NativeCalls.godot_icall_1_235(method_bind_0, Object.GetPtr(this), polygon);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_polygon");

        [GodotMethod("get_polygon")]
        [Obsolete("GetPolygon is deprecated. Use the Polygon property instead.")]
        public Vector2[] GetPolygon()
        {
            return NativeCalls.godot_icall_0_236(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_uv");

        [GodotMethod("set_uv")]
        [Obsolete("SetUv is deprecated. Use the Uv property instead.")]
        public void SetUv(Vector2[] uv)
        {
            NativeCalls.godot_icall_1_235(method_bind_2, Object.GetPtr(this), uv);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_uv");

        [GodotMethod("get_uv")]
        [Obsolete("GetUv is deprecated. Use the Uv property instead.")]
        public Vector2[] GetUv()
        {
            return NativeCalls.godot_icall_0_236(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_color");

        [GodotMethod("set_color")]
        [Obsolete("SetColor is deprecated. Use the Color property instead.")]
        public void SetColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_4, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_color");

        [GodotMethod("get_color")]
        [Obsolete("GetColor is deprecated. Use the Color property instead.")]
        public Color GetColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_5, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_polygons");

        [GodotMethod("set_polygons")]
        [Obsolete("SetPolygons is deprecated. Use the Polygons property instead.")]
        public void SetPolygons(Godot.Collections.Array polygons)
        {
            NativeCalls.godot_icall_1_92(method_bind_6, Object.GetPtr(this), polygons.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_polygons");

        [GodotMethod("get_polygons")]
        [Obsolete("GetPolygons is deprecated. Use the Polygons property instead.")]
        public Godot.Collections.Array GetPolygons()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_7, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_vertex_colors");

        [GodotMethod("set_vertex_colors")]
        [Obsolete("SetVertexColors is deprecated. Use the VertexColors property instead.")]
        public void SetVertexColors(Color[] vertexColors)
        {
            NativeCalls.godot_icall_1_231(method_bind_8, Object.GetPtr(this), vertexColors);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_vertex_colors");

        [GodotMethod("get_vertex_colors")]
        [Obsolete("GetVertexColors is deprecated. Use the VertexColors property instead.")]
        public Color[] GetVertexColors()
        {
            return NativeCalls.godot_icall_0_232(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture");

        [GodotMethod("set_texture")]
        [Obsolete("SetTexture is deprecated. Use the Texture property instead.")]
        public void SetTexture(Texture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_10, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture");

        [GodotMethod("get_texture")]
        [Obsolete("GetTexture is deprecated. Use the Texture property instead.")]
        public Texture GetTexture()
        {
            return NativeCalls.godot_icall_0_161(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture_offset");

        [GodotMethod("set_texture_offset")]
        [Obsolete("SetTextureOffset is deprecated. Use the TextureOffset property instead.")]
        public void SetTextureOffset(Vector2 textureOffset)
        {
            NativeCalls.godot_icall_1_57(method_bind_12, Object.GetPtr(this), ref textureOffset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture_offset");

        [GodotMethod("get_texture_offset")]
        [Obsolete("GetTextureOffset is deprecated. Use the TextureOffset property instead.")]
        public Vector2 GetTextureOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_13, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture_rotation");

        [GodotMethod("set_texture_rotation")]
        [Obsolete("SetTextureRotation is deprecated. Use the TextureRotation property instead.")]
        public void SetTextureRotation(float textureRotation)
        {
            NativeCalls.godot_icall_1_15(method_bind_14, Object.GetPtr(this), textureRotation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture_rotation");

        [GodotMethod("get_texture_rotation")]
        [Obsolete("GetTextureRotation is deprecated. Use the TextureRotation property instead.")]
        public float GetTextureRotation()
        {
            return NativeCalls.godot_icall_0_14(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture_rotation_degrees");

        [GodotMethod("set_texture_rotation_degrees")]
        [Obsolete("SetTextureRotationDegrees is deprecated. Use the TextureRotationDegrees property instead.")]
        public void SetTextureRotationDegrees(float textureRotation)
        {
            NativeCalls.godot_icall_1_15(method_bind_16, Object.GetPtr(this), textureRotation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture_rotation_degrees");

        [GodotMethod("get_texture_rotation_degrees")]
        [Obsolete("GetTextureRotationDegrees is deprecated. Use the TextureRotationDegrees property instead.")]
        public float GetTextureRotationDegrees()
        {
            return NativeCalls.godot_icall_0_14(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture_scale");

        [GodotMethod("set_texture_scale")]
        [Obsolete("SetTextureScale is deprecated. Use the TextureScale property instead.")]
        public void SetTextureScale(Vector2 textureScale)
        {
            NativeCalls.godot_icall_1_57(method_bind_18, Object.GetPtr(this), ref textureScale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture_scale");

        [GodotMethod("get_texture_scale")]
        [Obsolete("GetTextureScale is deprecated. Use the TextureScale property instead.")]
        public Vector2 GetTextureScale()
        {
            NativeCalls.godot_icall_0_18(method_bind_19, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_invert");

        [GodotMethod("set_invert")]
        [Obsolete("SetInvert is deprecated. Use the InvertEnable property instead.")]
        public void SetInvert(bool invert)
        {
            NativeCalls.godot_icall_1_16(method_bind_20, Object.GetPtr(this), invert);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_invert");

        [GodotMethod("get_invert")]
        [Obsolete("GetInvert is deprecated. Use the InvertEnable property instead.")]
        public bool GetInvert()
        {
            return NativeCalls.godot_icall_0_7(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_antialiased");

        [GodotMethod("set_antialiased")]
        [Obsolete("SetAntialiased is deprecated. Use the Antialiased property instead.")]
        public void SetAntialiased(bool antialiased)
        {
            NativeCalls.godot_icall_1_16(method_bind_22, Object.GetPtr(this), antialiased);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_antialiased");

        [GodotMethod("get_antialiased")]
        [Obsolete("GetAntialiased is deprecated. Use the Antialiased property instead.")]
        public bool GetAntialiased()
        {
            return NativeCalls.godot_icall_0_7(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_invert_border");

        [GodotMethod("set_invert_border")]
        [Obsolete("SetInvertBorder is deprecated. Use the InvertBorder property instead.")]
        public void SetInvertBorder(float invertBorder)
        {
            NativeCalls.godot_icall_1_15(method_bind_24, Object.GetPtr(this), invertBorder);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_invert_border");

        [GodotMethod("get_invert_border")]
        [Obsolete("GetInvertBorder is deprecated. Use the InvertBorder property instead.")]
        public float GetInvertBorder()
        {
            return NativeCalls.godot_icall_0_14(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_offset");

        [GodotMethod("set_offset")]
        [Obsolete("SetOffset is deprecated. Use the Offset property instead.")]
        public void SetOffset(Vector2 offset)
        {
            NativeCalls.godot_icall_1_57(method_bind_26, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_offset");

        [GodotMethod("get_offset")]
        [Obsolete("GetOffset is deprecated. Use the Offset property instead.")]
        public Vector2 GetOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_27, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_bone");

        /// <summary>
        /// <para>Adds a bone with the specified <c>path</c> and <c>weights</c>.</para>
        /// </summary>
        [GodotMethod("add_bone")]
        public void AddBone(NodePath path, float[] weights)
        {
            NativeCalls.godot_icall_2_794(method_bind_28, Object.GetPtr(this), NodePath.GetPtr(path), weights);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bone_count");

        /// <summary>
        /// <para>Returns the number of bones in this <see cref="Godot.Polygon2D"/>.</para>
        /// </summary>
        [GodotMethod("get_bone_count")]
        public int GetBoneCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bone_path");

        /// <summary>
        /// <para>Returns the path to the node associated with the specified bone.</para>
        /// </summary>
        [GodotMethod("get_bone_path")]
        public NodePath GetBonePath(int index)
        {
            return new NodePath(NativeCalls.godot_icall_1_62(method_bind_30, Object.GetPtr(this), index));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bone_weights");

        /// <summary>
        /// <para>Returns the height values of the specified bone.</para>
        /// </summary>
        [GodotMethod("get_bone_weights")]
        public float[] GetBoneWeights(int index)
        {
            return NativeCalls.godot_icall_1_603(method_bind_31, Object.GetPtr(this), index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "erase_bone");

        /// <summary>
        /// <para>Removes the specified bone from this <see cref="Godot.Polygon2D"/>.</para>
        /// </summary>
        [GodotMethod("erase_bone")]
        public void EraseBone(int index)
        {
            NativeCalls.godot_icall_1_4(method_bind_32, Object.GetPtr(this), index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_bones");

        /// <summary>
        /// <para>Removes all bones from this <see cref="Godot.Polygon2D"/>.</para>
        /// </summary>
        [GodotMethod("clear_bones")]
        public void ClearBones()
        {
            NativeCalls.godot_icall_0_3(method_bind_33, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bone_path");

        /// <summary>
        /// <para>Sets the path to the node associated with the specified bone.</para>
        /// </summary>
        [GodotMethod("set_bone_path")]
        public void SetBonePath(int index, NodePath path)
        {
            NativeCalls.godot_icall_2_63(method_bind_34, Object.GetPtr(this), index, NodePath.GetPtr(path));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bone_weights");

        /// <summary>
        /// <para>Sets the weight values for the specified bone.</para>
        /// </summary>
        [GodotMethod("set_bone_weights")]
        public void SetBoneWeights(int index, float[] weights)
        {
            NativeCalls.godot_icall_2_602(method_bind_35, Object.GetPtr(this), index, weights);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_skeleton");

        [GodotMethod("set_skeleton")]
        [Obsolete("SetSkeleton is deprecated. Use the Skeleton property instead.")]
        public void SetSkeleton(NodePath skeleton)
        {
            NativeCalls.godot_icall_1_129(method_bind_36, Object.GetPtr(this), NodePath.GetPtr(skeleton));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_skeleton");

        [GodotMethod("get_skeleton")]
        [Obsolete("GetSkeleton is deprecated. Use the Skeleton property instead.")]
        public NodePath GetSkeleton()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_37, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_internal_vertex_count");

        [GodotMethod("set_internal_vertex_count")]
        [Obsolete("SetInternalVertexCount is deprecated. Use the InternalVertexCount property instead.")]
        public void SetInternalVertexCount(int internalVertexCount)
        {
            NativeCalls.godot_icall_1_4(method_bind_38, Object.GetPtr(this), internalVertexCount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_internal_vertex_count");

        [GodotMethod("get_internal_vertex_count")]
        [Obsolete("GetInternalVertexCount is deprecated. Use the InternalVertexCount property instead.")]
        public int GetInternalVertexCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_39, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_bones");

        [Obsolete("_SetBones is deprecated. Use the Bones property instead.")]
        internal void _SetBones(Godot.Collections.Array bones)
        {
            NativeCalls.godot_icall_1_92(method_bind_40, Object.GetPtr(this), bones.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_bones");

        [Obsolete("_GetBones is deprecated. Use the Bones property instead.")]
        internal Godot.Collections.Array _GetBones()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_41, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
