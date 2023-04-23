using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Simple texture that uses a mesh to draw itself. It's limited because flags can't be changed and region drawing is not supported.</para>
    /// </summary>
    public partial class MeshTexture : Texture
    {
        /// <summary>
        /// <para>Sets the mesh used to draw. It must be a mesh using 2D vertices.</para>
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
        /// <para>Sets the base texture that the Mesh will use to draw.</para>
        /// </summary>
        public Texture BaseTexture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBaseTexture();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBaseTexture(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the size of the image, needed for reference.</para>
        /// </summary>
        public Vector2 ImageSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetImageSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetImageSize(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "MeshTexture";

        public MeshTexture() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_MeshTexture_Ctor(this);
        }

        internal MeshTexture(bool memoryOwn) : base(memoryOwn) {}

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
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_image_size");

        [GodotMethod("set_image_size")]
        [Obsolete("SetImageSize is deprecated. Use the ImageSize property instead.")]
        public void SetImageSize(Vector2 size)
        {
            NativeCalls.godot_icall_1_57(method_bind_2, Object.GetPtr(this), ref size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_image_size");

        [GodotMethod("get_image_size")]
        [Obsolete("GetImageSize is deprecated. Use the ImageSize property instead.")]
        public Vector2 GetImageSize()
        {
            NativeCalls.godot_icall_0_18(method_bind_3, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_base_texture");

        [GodotMethod("set_base_texture")]
        [Obsolete("SetBaseTexture is deprecated. Use the BaseTexture property instead.")]
        public void SetBaseTexture(Texture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_4, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_base_texture");

        [GodotMethod("get_base_texture")]
        [Obsolete("GetBaseTexture is deprecated. Use the BaseTexture property instead.")]
        public Texture GetBaseTexture()
        {
            return NativeCalls.godot_icall_0_161(method_bind_5, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
