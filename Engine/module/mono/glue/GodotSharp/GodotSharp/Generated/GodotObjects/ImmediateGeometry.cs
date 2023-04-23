using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Draws simple geometry from code. Uses a drawing mode similar to OpenGL 1.x.</para>
    /// <para>See also <see cref="Godot.ArrayMesh"/>, <see cref="Godot.MeshDataTool"/> and <see cref="Godot.SurfaceTool"/> for procedural geometry generation.</para>
    /// <para>Note: ImmediateGeometry3D is best suited to small amounts of mesh data that change every frame. It will be slow when handling large amounts of mesh data. If mesh data doesn't change often, use <see cref="Godot.ArrayMesh"/>, <see cref="Godot.MeshDataTool"/> or <see cref="Godot.SurfaceTool"/> instead.</para>
    /// <para>Note: Godot uses clockwise <a href="https://learnopengl.com/Advanced-OpenGL/Face-culling">winding order</a> for front faces of triangle primitive modes.</para>
    /// <para>Note: In case of missing points when handling large amounts of mesh data, try increasing its buffer size limit under .</para>
    /// </summary>
    public partial class ImmediateGeometry : GeometryInstance
    {
        private const string nativeName = "ImmediateGeometry";

        public ImmediateGeometry() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ImmediateGeometry_Ctor(this);
        }

        internal ImmediateGeometry(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "begin");

        /// <summary>
        /// <para>Begin drawing (and optionally pass a texture override). When done call <see cref="Godot.ImmediateGeometry.End"/>. For more information on how this works, search for <c>glBegin()</c> and <c>glEnd()</c> references.</para>
        /// <para>For the type of primitive, see the <see cref="Godot.Mesh.PrimitiveType"/> enum.</para>
        /// </summary>
        [GodotMethod("begin")]
        public void Begin(Mesh.PrimitiveType primitive, Texture texture = null)
        {
            NativeCalls.godot_icall_2_58(method_bind_0, Object.GetPtr(this), (int)primitive, Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_normal");

        /// <summary>
        /// <para>The next vertex's normal.</para>
        /// </summary>
        [GodotMethod("set_normal")]
        public void SetNormal(Vector3 normal)
        {
            NativeCalls.godot_icall_1_148(method_bind_1, Object.GetPtr(this), ref normal);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tangent");

        /// <summary>
        /// <para>The next vertex's tangent (and binormal facing).</para>
        /// </summary>
        [GodotMethod("set_tangent")]
        public void SetTangent(Plane tangent)
        {
            NativeCalls.godot_icall_1_519(method_bind_2, Object.GetPtr(this), ref tangent);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_color");

        /// <summary>
        /// <para>The current drawing color.</para>
        /// </summary>
        [GodotMethod("set_color")]
        public void SetColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_3, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_uv");

        /// <summary>
        /// <para>The next vertex's UV.</para>
        /// </summary>
        [GodotMethod("set_uv")]
        public void SetUv(Vector2 uv)
        {
            NativeCalls.godot_icall_1_57(method_bind_4, Object.GetPtr(this), ref uv);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_uv2");

        /// <summary>
        /// <para>The next vertex's second layer UV.</para>
        /// </summary>
        [GodotMethod("set_uv2")]
        public void SetUv2(Vector2 uv)
        {
            NativeCalls.godot_icall_1_57(method_bind_5, Object.GetPtr(this), ref uv);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_vertex");

        /// <summary>
        /// <para>Adds a vertex in local coordinate space with the currently set color/uv/etc.</para>
        /// </summary>
        [GodotMethod("add_vertex")]
        public void AddVertex(Vector3 position)
        {
            NativeCalls.godot_icall_1_148(method_bind_6, Object.GetPtr(this), ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_sphere");

        /// <summary>
        /// <para>Simple helper to draw an UV sphere with given latitude, longitude and radius.</para>
        /// </summary>
        [GodotMethod("add_sphere")]
        public void AddSphere(int lats, int lons, float radius, bool addUv = true)
        {
            NativeCalls.godot_icall_4_520(method_bind_7, Object.GetPtr(this), lats, lons, radius, addUv);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "end");

        /// <summary>
        /// <para>Ends a drawing context and displays the results.</para>
        /// </summary>
        [GodotMethod("end")]
        public void End()
        {
            NativeCalls.godot_icall_0_3(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Clears everything that was drawn using begin/end.</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_9, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
