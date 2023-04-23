using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Enable support for the OpenGL ES external texture extension as defined by <a href="https://www.khronos.org/registry/OpenGL/extensions/OES/OES_EGL_image_external.txt">OES_EGL_image_external</a>.</para>
    /// <para>Note: This is only supported for Android platforms.</para>
    /// </summary>
    public partial class ExternalTexture : Texture
    {
        /// <summary>
        /// <para>External texture size.</para>
        /// </summary>
        public Vector2 Size
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSize(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ExternalTexture";

        public ExternalTexture() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ExternalTexture_Ctor(this);
        }

        internal ExternalTexture(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_size");

        [GodotMethod("set_size")]
        [Obsolete("SetSize is deprecated. Use the Size property instead.")]
        public void SetSize(Vector2 size)
        {
            NativeCalls.godot_icall_1_57(method_bind_0, Object.GetPtr(this), ref size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_external_texture_id");

        /// <summary>
        /// <para>Returns the external texture name.</para>
        /// </summary>
        [GodotMethod("get_external_texture_id")]
        public uint GetExternalTextureId()
        {
            return NativeCalls.godot_icall_0_188(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
