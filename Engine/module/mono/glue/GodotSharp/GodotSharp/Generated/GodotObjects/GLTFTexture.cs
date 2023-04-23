using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Note: This class is only compiled in editor builds. Run-time glTF loading and saving is not available in exported projects. References to <see cref="Godot.GLTFTexture"/> within a script will cause an error in an exported project.</para>
    /// </summary>
    public partial class GLTFTexture : Resource
    {
        public int SrcImage
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSrcImage();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSrcImage(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "GLTFTexture";

        public GLTFTexture() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GLTFTexture_Ctor(this);
        }

        internal GLTFTexture(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_src_image");

        [GodotMethod("get_src_image")]
        [Obsolete("GetSrcImage is deprecated. Use the SrcImage property instead.")]
        public int GetSrcImage()
        {
            return NativeCalls.godot_icall_0_5(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_src_image");

        [GodotMethod("set_src_image")]
        [Obsolete("SetSrcImage is deprecated. Use the SrcImage property instead.")]
        public void SetSrcImage(int srcImage)
        {
            NativeCalls.godot_icall_1_4(method_bind_1, Object.GetPtr(this), srcImage);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
