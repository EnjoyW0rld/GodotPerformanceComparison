using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Note: This class is only compiled in editor builds. Run-time glTF loading and saving is not available in exported projects. References to <see cref="Godot.GLTFNode"/> within a script will cause an error in an exported project.</para>
    /// </summary>
    public partial class GLTFNode : Resource
    {
        public int Parent
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParent();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParent(value);
            }
#pragma warning restore CS0618
        }

        public int Height
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHeight();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHeight(value);
            }
#pragma warning restore CS0618
        }

        public Transform Xform
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetXform();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetXform(value);
            }
#pragma warning restore CS0618
        }

        public int Mesh
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

        public int Camera
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCamera();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCamera(value);
            }
#pragma warning restore CS0618
        }

        public int Skin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSkin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSkin(value);
            }
#pragma warning restore CS0618
        }

        public int Skeleton
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

        public bool Joint
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetJoint();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetJoint(value);
            }
#pragma warning restore CS0618
        }

        public Vector3 Translation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTranslation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTranslation(value);
            }
#pragma warning restore CS0618
        }

        public Quat Rotation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRotation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRotation(value);
            }
#pragma warning restore CS0618
        }

        public Vector3 Scale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetScale(value);
            }
#pragma warning restore CS0618
        }

        public int[] Children
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetChildren();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetChildren(value);
            }
#pragma warning restore CS0618
        }

        public int Light
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLight();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLight(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "GLTFNode";

        public GLTFNode() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GLTFNode_Ctor(this);
        }

        internal GLTFNode(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_parent");

        [GodotMethod("get_parent")]
        [Obsolete("GetParent is deprecated. Use the Parent property instead.")]
        public int GetParent()
        {
            return NativeCalls.godot_icall_0_5(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_parent");

        [GodotMethod("set_parent")]
        [Obsolete("SetParent is deprecated. Use the Parent property instead.")]
        public void SetParent(int parent)
        {
            NativeCalls.godot_icall_1_4(method_bind_1, Object.GetPtr(this), parent);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_height");

        [GodotMethod("get_height")]
        [Obsolete("GetHeight is deprecated. Use the Height property instead.")]
        public int GetHeight()
        {
            return NativeCalls.godot_icall_0_5(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_height");

        [GodotMethod("set_height")]
        [Obsolete("SetHeight is deprecated. Use the Height property instead.")]
        public void SetHeight(int height)
        {
            NativeCalls.godot_icall_1_4(method_bind_3, Object.GetPtr(this), height);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_xform");

        [GodotMethod("get_xform")]
        [Obsolete("GetXform is deprecated. Use the Xform property instead.")]
        public Transform GetXform()
        {
            NativeCalls.godot_icall_0_22(method_bind_4, Object.GetPtr(this), out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_xform");

        [GodotMethod("set_xform")]
        [Obsolete("SetXform is deprecated. Use the Xform property instead.")]
        public void SetXform(Transform xform)
        {
            NativeCalls.godot_icall_1_202(method_bind_5, Object.GetPtr(this), ref xform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mesh");

        [GodotMethod("get_mesh")]
        [Obsolete("GetMesh is deprecated. Use the Mesh property instead.")]
        public int GetMesh()
        {
            return NativeCalls.godot_icall_0_5(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mesh");

        [GodotMethod("set_mesh")]
        [Obsolete("SetMesh is deprecated. Use the Mesh property instead.")]
        public void SetMesh(int mesh)
        {
            NativeCalls.godot_icall_1_4(method_bind_7, Object.GetPtr(this), mesh);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_camera");

        [GodotMethod("get_camera")]
        [Obsolete("GetCamera is deprecated. Use the Camera property instead.")]
        public int GetCamera()
        {
            return NativeCalls.godot_icall_0_5(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_camera");

        [GodotMethod("set_camera")]
        [Obsolete("SetCamera is deprecated. Use the Camera property instead.")]
        public void SetCamera(int camera)
        {
            NativeCalls.godot_icall_1_4(method_bind_9, Object.GetPtr(this), camera);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_skin");

        [GodotMethod("get_skin")]
        [Obsolete("GetSkin is deprecated. Use the Skin property instead.")]
        public int GetSkin()
        {
            return NativeCalls.godot_icall_0_5(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_skin");

        [GodotMethod("set_skin")]
        [Obsolete("SetSkin is deprecated. Use the Skin property instead.")]
        public void SetSkin(int skin)
        {
            NativeCalls.godot_icall_1_4(method_bind_11, Object.GetPtr(this), skin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_skeleton");

        [GodotMethod("get_skeleton")]
        [Obsolete("GetSkeleton is deprecated. Use the Skeleton property instead.")]
        public int GetSkeleton()
        {
            return NativeCalls.godot_icall_0_5(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_skeleton");

        [GodotMethod("set_skeleton")]
        [Obsolete("SetSkeleton is deprecated. Use the Skeleton property instead.")]
        public void SetSkeleton(int skeleton)
        {
            NativeCalls.godot_icall_1_4(method_bind_13, Object.GetPtr(this), skeleton);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_joint");

        [GodotMethod("get_joint")]
        [Obsolete("GetJoint is deprecated. Use the Joint property instead.")]
        public bool GetJoint()
        {
            return NativeCalls.godot_icall_0_7(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_joint");

        [GodotMethod("set_joint")]
        [Obsolete("SetJoint is deprecated. Use the Joint property instead.")]
        public void SetJoint(bool joint)
        {
            NativeCalls.godot_icall_1_16(method_bind_15, Object.GetPtr(this), joint);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_translation");

        [GodotMethod("get_translation")]
        [Obsolete("GetTranslation is deprecated. Use the Translation property instead.")]
        public Vector3 GetTranslation()
        {
            NativeCalls.godot_icall_0_8(method_bind_16, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_translation");

        [GodotMethod("set_translation")]
        [Obsolete("SetTranslation is deprecated. Use the Translation property instead.")]
        public void SetTranslation(Vector3 translation)
        {
            NativeCalls.godot_icall_1_148(method_bind_17, Object.GetPtr(this), ref translation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rotation");

        [GodotMethod("get_rotation")]
        [Obsolete("GetRotation is deprecated. Use the Rotation property instead.")]
        public Quat GetRotation()
        {
            NativeCalls.godot_icall_0_454(method_bind_18, Object.GetPtr(this), out Quat argRet); return (Quat)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rotation");

        [GodotMethod("set_rotation")]
        [Obsolete("SetRotation is deprecated. Use the Rotation property instead.")]
        public void SetRotation(Quat rotation)
        {
            NativeCalls.godot_icall_1_455(method_bind_19, Object.GetPtr(this), ref rotation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_scale");

        [GodotMethod("get_scale")]
        [Obsolete("GetScale is deprecated. Use the Scale property instead.")]
        public Vector3 GetScale()
        {
            NativeCalls.godot_icall_0_8(method_bind_20, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_scale");

        [GodotMethod("set_scale")]
        [Obsolete("SetScale is deprecated. Use the Scale property instead.")]
        public void SetScale(Vector3 scale)
        {
            NativeCalls.godot_icall_1_148(method_bind_21, Object.GetPtr(this), ref scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_children");

        [GodotMethod("get_children")]
        [Obsolete("GetChildren is deprecated. Use the Children property instead.")]
        public int[] GetChildren()
        {
            return NativeCalls.godot_icall_0_103(method_bind_22, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_children");

        [GodotMethod("set_children")]
        [Obsolete("SetChildren is deprecated. Use the Children property instead.")]
        public void SetChildren(int[] children)
        {
            NativeCalls.godot_icall_1_102(method_bind_23, Object.GetPtr(this), children);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_light");

        [GodotMethod("get_light")]
        [Obsolete("GetLight is deprecated. Use the Light property instead.")]
        public int GetLight()
        {
            return NativeCalls.godot_icall_0_5(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_light");

        [GodotMethod("set_light")]
        [Obsolete("SetLight is deprecated. Use the Light property instead.")]
        public void SetLight(int light)
        {
            NativeCalls.godot_icall_1_4(method_bind_25, Object.GetPtr(this), light);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
