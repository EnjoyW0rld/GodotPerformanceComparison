using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Note: This class is only compiled in editor builds. Run-time glTF loading and saving is not available in exported projects. References to <see cref="Godot.GLTFCamera"/> within a script will cause an error in an exported project.</para>
    /// </summary>
    public partial class GLTFCamera : Resource
    {
        public bool Perspective
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPerspective();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPerspective(value);
            }
#pragma warning restore CS0618
        }

        public float FovSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFovSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFovSize(value);
            }
#pragma warning restore CS0618
        }

        public float Zfar
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetZfar();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetZfar(value);
            }
#pragma warning restore CS0618
        }

        public float Znear
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetZnear();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetZnear(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "GLTFCamera";

        public GLTFCamera() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GLTFCamera_Ctor(this);
        }

        internal GLTFCamera(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_perspective");

        [GodotMethod("get_perspective")]
        [Obsolete("GetPerspective is deprecated. Use the Perspective property instead.")]
        public bool GetPerspective()
        {
            return NativeCalls.godot_icall_0_7(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_perspective");

        [GodotMethod("set_perspective")]
        [Obsolete("SetPerspective is deprecated. Use the Perspective property instead.")]
        public void SetPerspective(bool perspective)
        {
            NativeCalls.godot_icall_1_16(method_bind_1, Object.GetPtr(this), perspective);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fov_size");

        [GodotMethod("get_fov_size")]
        [Obsolete("GetFovSize is deprecated. Use the FovSize property instead.")]
        public float GetFovSize()
        {
            return NativeCalls.godot_icall_0_14(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fov_size");

        [GodotMethod("set_fov_size")]
        [Obsolete("SetFovSize is deprecated. Use the FovSize property instead.")]
        public void SetFovSize(float fovSize)
        {
            NativeCalls.godot_icall_1_15(method_bind_3, Object.GetPtr(this), fovSize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_zfar");

        [GodotMethod("get_zfar")]
        [Obsolete("GetZfar is deprecated. Use the Zfar property instead.")]
        public float GetZfar()
        {
            return NativeCalls.godot_icall_0_14(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_zfar");

        [GodotMethod("set_zfar")]
        [Obsolete("SetZfar is deprecated. Use the Zfar property instead.")]
        public void SetZfar(float zfar)
        {
            NativeCalls.godot_icall_1_15(method_bind_5, Object.GetPtr(this), zfar);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_znear");

        [GodotMethod("get_znear")]
        [Obsolete("GetZnear is deprecated. Use the Znear property instead.")]
        public float GetZnear()
        {
            return NativeCalls.godot_icall_0_14(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_znear");

        [GodotMethod("set_znear")]
        [Obsolete("SetZnear is deprecated. Use the Znear property instead.")]
        public void SetZnear(float znear)
        {
            NativeCalls.godot_icall_1_15(method_bind_7, Object.GetPtr(this), znear);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
