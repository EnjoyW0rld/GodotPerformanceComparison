using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Node used for displaying a <see cref="Godot.Mesh"/> in 2D. A <see cref="Godot.MeshInstance2D"/> can be automatically created from an existing <see cref="Godot.Sprite"/> via a tool in the editor toolbar. Select the <see cref="Godot.Sprite"/> node, then choose Sprite &gt; Convert to MeshInstance2D at the top of the 2D editor viewport.</para>
    /// </summary>
    public partial class MeshInstance2D : Node2D
    {
        /// <summary>
        /// <para>The <see cref="Godot.Mesh"/> that will be drawn by the <see cref="Godot.MeshInstance2D"/>.</para>
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
        /// <para>The <see cref="Godot.Texture"/> that will be used if using the default <see cref="Godot.CanvasItemMaterial"/>. Can be accessed as <c>TEXTURE</c> in CanvasItem shader.</para>
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
        /// <para>The normal map that will be used if using the default <see cref="Godot.CanvasItemMaterial"/>.</para>
        /// <para>Note: Godot expects the normal map to use X+, Y+, and Z+ coordinates. See <a href="http://wiki.polycount.com/wiki/Normal_Map_Technical_Details#Common_Swizzle_Coordinates">this page</a> for a comparison of normal map coordinates expected by popular engines.</para>
        /// </summary>
        public Texture NormalMap
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNormalMap();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetNormalMap(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "MeshInstance2D";

        public MeshInstance2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_MeshInstance2D_Ctor(this);
        }

        internal MeshInstance2D(bool memoryOwn) : base(memoryOwn) {}

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
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture");

        [GodotMethod("set_texture")]
        [Obsolete("SetTexture is deprecated. Use the Texture property instead.")]
        public void SetTexture(Texture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_2, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture");

        [GodotMethod("get_texture")]
        [Obsolete("GetTexture is deprecated. Use the Texture property instead.")]
        public Texture GetTexture()
        {
            return NativeCalls.godot_icall_0_161(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_normal_map");

        [GodotMethod("set_normal_map")]
        [Obsolete("SetNormalMap is deprecated. Use the NormalMap property instead.")]
        public void SetNormalMap(Texture normalMap)
        {
            NativeCalls.godot_icall_1_24(method_bind_4, Object.GetPtr(this), Object.GetPtr(normalMap));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_normal_map");

        [GodotMethod("get_normal_map")]
        [Obsolete("GetNormalMap is deprecated. Use the NormalMap property instead.")]
        public Texture GetNormalMap()
        {
            return NativeCalls.godot_icall_0_161(method_bind_5, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
