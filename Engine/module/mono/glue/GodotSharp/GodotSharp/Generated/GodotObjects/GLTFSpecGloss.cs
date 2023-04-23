using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Note: This class is only compiled in editor builds. Run-time glTF loading and saving is not available in exported projects. References to <see cref="Godot.GLTFSpecGloss"/> within a script will cause an error in an exported project.</para>
    /// </summary>
    public partial class GLTFSpecGloss : Resource
    {
        public Image DiffuseImg
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDiffuseImg();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDiffuseImg(value);
            }
#pragma warning restore CS0618
        }

        public Color DiffuseFactor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDiffuseFactor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDiffuseFactor(value);
            }
#pragma warning restore CS0618
        }

        public float GlossFactor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGlossFactor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlossFactor(value);
            }
#pragma warning restore CS0618
        }

        public Color SpecularFactor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSpecularFactor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSpecularFactor(value);
            }
#pragma warning restore CS0618
        }

        public Image SpecGlossImg
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSpecGlossImg();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSpecGlossImg(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "GLTFSpecGloss";

        public GLTFSpecGloss() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GLTFSpecGloss_Ctor(this);
        }

        internal GLTFSpecGloss(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_diffuse_img");

        [GodotMethod("get_diffuse_img")]
        [Obsolete("GetDiffuseImg is deprecated. Use the DiffuseImg property instead.")]
        public Image GetDiffuseImg()
        {
            return NativeCalls.godot_icall_0_216(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_diffuse_img");

        [GodotMethod("set_diffuse_img")]
        [Obsolete("SetDiffuseImg is deprecated. Use the DiffuseImg property instead.")]
        public void SetDiffuseImg(Image diffuseImg)
        {
            NativeCalls.godot_icall_1_24(method_bind_1, Object.GetPtr(this), Object.GetPtr(diffuseImg));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_diffuse_factor");

        [GodotMethod("get_diffuse_factor")]
        [Obsolete("GetDiffuseFactor is deprecated. Use the DiffuseFactor property instead.")]
        public Color GetDiffuseFactor()
        {
            NativeCalls.godot_icall_0_200(method_bind_2, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_diffuse_factor");

        [GodotMethod("set_diffuse_factor")]
        [Obsolete("SetDiffuseFactor is deprecated. Use the DiffuseFactor property instead.")]
        public void SetDiffuseFactor(Color diffuseFactor)
        {
            NativeCalls.godot_icall_1_199(method_bind_3, Object.GetPtr(this), ref diffuseFactor);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_gloss_factor");

        [GodotMethod("get_gloss_factor")]
        [Obsolete("GetGlossFactor is deprecated. Use the GlossFactor property instead.")]
        public float GetGlossFactor()
        {
            return NativeCalls.godot_icall_0_14(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_gloss_factor");

        [GodotMethod("set_gloss_factor")]
        [Obsolete("SetGlossFactor is deprecated. Use the GlossFactor property instead.")]
        public void SetGlossFactor(float glossFactor)
        {
            NativeCalls.godot_icall_1_15(method_bind_5, Object.GetPtr(this), glossFactor);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_specular_factor");

        [GodotMethod("get_specular_factor")]
        [Obsolete("GetSpecularFactor is deprecated. Use the SpecularFactor property instead.")]
        public Color GetSpecularFactor()
        {
            NativeCalls.godot_icall_0_200(method_bind_6, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_specular_factor");

        [GodotMethod("set_specular_factor")]
        [Obsolete("SetSpecularFactor is deprecated. Use the SpecularFactor property instead.")]
        public void SetSpecularFactor(Color specularFactor)
        {
            NativeCalls.godot_icall_1_199(method_bind_7, Object.GetPtr(this), ref specularFactor);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_spec_gloss_img");

        [GodotMethod("get_spec_gloss_img")]
        [Obsolete("GetSpecGlossImg is deprecated. Use the SpecGlossImg property instead.")]
        public Image GetSpecGlossImg()
        {
            return NativeCalls.godot_icall_0_216(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_spec_gloss_img");

        [GodotMethod("set_spec_gloss_img")]
        [Obsolete("SetSpecGlossImg is deprecated. Use the SpecGlossImg property instead.")]
        public void SetSpecGlossImg(Image specGlossImg)
        {
            NativeCalls.godot_icall_1_24(method_bind_9, Object.GetPtr(this), Object.GetPtr(specGlossImg));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
