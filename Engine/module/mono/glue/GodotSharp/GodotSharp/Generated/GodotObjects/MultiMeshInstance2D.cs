using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.MultiMeshInstance2D"/> is a specialized node to instance a <see cref="Godot.MultiMesh"/> resource in 2D.</para>
    /// <para>Usage is the same as <see cref="Godot.MultiMeshInstance"/>.</para>
    /// </summary>
    public partial class MultiMeshInstance2D : Node2D
    {
        /// <summary>
        /// <para>The <see cref="Godot.MultiMesh"/> that will be drawn by the <see cref="Godot.MultiMeshInstance2D"/>.</para>
        /// </summary>
        public MultiMesh Multimesh
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMultimesh();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMultimesh(value);
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

        private const string nativeName = "MultiMeshInstance2D";

        public MultiMeshInstance2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_MultiMeshInstance2D_Ctor(this);
        }

        internal MultiMeshInstance2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_multimesh");

        [GodotMethod("set_multimesh")]
        [Obsolete("SetMultimesh is deprecated. Use the Multimesh property instead.")]
        public void SetMultimesh(MultiMesh multimesh)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(multimesh));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_multimesh");

        [GodotMethod("get_multimesh")]
        [Obsolete("GetMultimesh is deprecated. Use the Multimesh property instead.")]
        public MultiMesh GetMultimesh()
        {
            return NativeCalls.godot_icall_0_620(method_bind_1, Object.GetPtr(this));
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
