using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class GLTFSkin : Resource
    {
        public int SkinRoot
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSkinRoot();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSkinRoot(value);
            }
#pragma warning restore CS0618
        }

        public int[] JointsOriginal
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetJointsOriginal();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetJointsOriginal(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array InverseBinds
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInverseBinds();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInverseBinds(value);
            }
#pragma warning restore CS0618
        }

        public int[] Joints
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetJoints();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetJoints(value);
            }
#pragma warning restore CS0618
        }

        public int[] NonJoints
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNonJoints();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetNonJoints(value);
            }
#pragma warning restore CS0618
        }

        public int[] Roots
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRoots();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRoots(value);
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

        public Godot.Collections.Dictionary JointIToBoneI
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetJointIToBoneI();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetJointIToBoneI(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Dictionary JointIToName
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetJointIToName();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetJointIToName(value);
            }
#pragma warning restore CS0618
        }

        public Skin GodotSkin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGodotSkin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGodotSkin(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "GLTFSkin";

        public GLTFSkin() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GLTFSkin_Ctor(this);
        }

        internal GLTFSkin(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_skin_root");

        [GodotMethod("get_skin_root")]
        [Obsolete("GetSkinRoot is deprecated. Use the SkinRoot property instead.")]
        public int GetSkinRoot()
        {
            return NativeCalls.godot_icall_0_5(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_skin_root");

        [GodotMethod("set_skin_root")]
        [Obsolete("SetSkinRoot is deprecated. Use the SkinRoot property instead.")]
        public void SetSkinRoot(int skinRoot)
        {
            NativeCalls.godot_icall_1_4(method_bind_1, Object.GetPtr(this), skinRoot);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_joints_original");

        [GodotMethod("get_joints_original")]
        [Obsolete("GetJointsOriginal is deprecated. Use the JointsOriginal property instead.")]
        public int[] GetJointsOriginal()
        {
            return NativeCalls.godot_icall_0_103(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_joints_original");

        [GodotMethod("set_joints_original")]
        [Obsolete("SetJointsOriginal is deprecated. Use the JointsOriginal property instead.")]
        public void SetJointsOriginal(int[] jointsOriginal)
        {
            NativeCalls.godot_icall_1_102(method_bind_3, Object.GetPtr(this), jointsOriginal);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_inverse_binds");

        [GodotMethod("get_inverse_binds")]
        [Obsolete("GetInverseBinds is deprecated. Use the InverseBinds property instead.")]
        public Godot.Collections.Array GetInverseBinds()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_4, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_inverse_binds");

        [GodotMethod("set_inverse_binds")]
        [Obsolete("SetInverseBinds is deprecated. Use the InverseBinds property instead.")]
        public void SetInverseBinds(Godot.Collections.Array inverseBinds)
        {
            NativeCalls.godot_icall_1_92(method_bind_5, Object.GetPtr(this), inverseBinds.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_joints");

        [GodotMethod("get_joints")]
        [Obsolete("GetJoints is deprecated. Use the Joints property instead.")]
        public int[] GetJoints()
        {
            return NativeCalls.godot_icall_0_103(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_joints");

        [GodotMethod("set_joints")]
        [Obsolete("SetJoints is deprecated. Use the Joints property instead.")]
        public void SetJoints(int[] joints)
        {
            NativeCalls.godot_icall_1_102(method_bind_7, Object.GetPtr(this), joints);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_non_joints");

        [GodotMethod("get_non_joints")]
        [Obsolete("GetNonJoints is deprecated. Use the NonJoints property instead.")]
        public int[] GetNonJoints()
        {
            return NativeCalls.godot_icall_0_103(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_non_joints");

        [GodotMethod("set_non_joints")]
        [Obsolete("SetNonJoints is deprecated. Use the NonJoints property instead.")]
        public void SetNonJoints(int[] nonJoints)
        {
            NativeCalls.godot_icall_1_102(method_bind_9, Object.GetPtr(this), nonJoints);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_roots");

        [GodotMethod("get_roots")]
        [Obsolete("GetRoots is deprecated. Use the Roots property instead.")]
        public int[] GetRoots()
        {
            return NativeCalls.godot_icall_0_103(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_roots");

        [GodotMethod("set_roots")]
        [Obsolete("SetRoots is deprecated. Use the Roots property instead.")]
        public void SetRoots(int[] roots)
        {
            NativeCalls.godot_icall_1_102(method_bind_11, Object.GetPtr(this), roots);
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
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_joint_i_to_bone_i");

        [GodotMethod("get_joint_i_to_bone_i")]
        [Obsolete("GetJointIToBoneI is deprecated. Use the JointIToBoneI property instead.")]
        public Godot.Collections.Dictionary GetJointIToBoneI()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_14, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_joint_i_to_bone_i");

        [GodotMethod("set_joint_i_to_bone_i")]
        [Obsolete("SetJointIToBoneI is deprecated. Use the JointIToBoneI property instead.")]
        public void SetJointIToBoneI(Godot.Collections.Dictionary jointIToBoneI)
        {
            NativeCalls.godot_icall_1_213(method_bind_15, Object.GetPtr(this), jointIToBoneI.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_joint_i_to_name");

        [GodotMethod("get_joint_i_to_name")]
        [Obsolete("GetJointIToName is deprecated. Use the JointIToName property instead.")]
        public Godot.Collections.Dictionary GetJointIToName()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_16, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_joint_i_to_name");

        [GodotMethod("set_joint_i_to_name")]
        [Obsolete("SetJointIToName is deprecated. Use the JointIToName property instead.")]
        public void SetJointIToName(Godot.Collections.Dictionary jointIToName)
        {
            NativeCalls.godot_icall_1_213(method_bind_17, Object.GetPtr(this), jointIToName.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_godot_skin");

        [GodotMethod("get_godot_skin")]
        [Obsolete("GetGodotSkin is deprecated. Use the GodotSkin property instead.")]
        public Skin GetGodotSkin()
        {
            return NativeCalls.godot_icall_0_458(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_godot_skin");

        [GodotMethod("set_godot_skin")]
        [Obsolete("SetGodotSkin is deprecated. Use the GodotSkin property instead.")]
        public void SetGodotSkin(Skin godotSkin)
        {
            NativeCalls.godot_icall_1_24(method_bind_19, Object.GetPtr(this), Object.GetPtr(godotSkin));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
