using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Note: This class is only compiled in editor builds. Run-time glTF loading and saving is not available in exported projects. References to <see cref="Godot.GLTFSkeleton"/> within a script will cause an error in an exported project.</para>
    /// </summary>
    public partial class GLTFSkeleton : Resource
    {
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

        public Godot.Collections.Array UniqueNames
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUniqueNames();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUniqueNames(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Dictionary GodotBoneNode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGodotBoneNode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGodotBoneNode(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "GLTFSkeleton";

        public GLTFSkeleton() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GLTFSkeleton_Ctor(this);
        }

        internal GLTFSkeleton(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_joints");

        [GodotMethod("get_joints")]
        [Obsolete("GetJoints is deprecated. Use the Joints property instead.")]
        public int[] GetJoints()
        {
            return NativeCalls.godot_icall_0_103(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_joints");

        [GodotMethod("set_joints")]
        [Obsolete("SetJoints is deprecated. Use the Joints property instead.")]
        public void SetJoints(int[] joints)
        {
            NativeCalls.godot_icall_1_102(method_bind_1, Object.GetPtr(this), joints);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_roots");

        [GodotMethod("get_roots")]
        [Obsolete("GetRoots is deprecated. Use the Roots property instead.")]
        public int[] GetRoots()
        {
            return NativeCalls.godot_icall_0_103(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_roots");

        [GodotMethod("set_roots")]
        [Obsolete("SetRoots is deprecated. Use the Roots property instead.")]
        public void SetRoots(int[] roots)
        {
            NativeCalls.godot_icall_1_102(method_bind_3, Object.GetPtr(this), roots);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_godot_skeleton");

        [GodotMethod("get_godot_skeleton")]
        public Skeleton GetGodotSkeleton()
        {
            return NativeCalls.godot_icall_0_456(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_unique_names");

        [GodotMethod("get_unique_names")]
        [Obsolete("GetUniqueNames is deprecated. Use the UniqueNames property instead.")]
        public Godot.Collections.Array GetUniqueNames()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_5, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_unique_names");

        [GodotMethod("set_unique_names")]
        [Obsolete("SetUniqueNames is deprecated. Use the UniqueNames property instead.")]
        public void SetUniqueNames(Godot.Collections.Array uniqueNames)
        {
            NativeCalls.godot_icall_1_92(method_bind_6, Object.GetPtr(this), uniqueNames.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_godot_bone_node");

        [GodotMethod("get_godot_bone_node")]
        [Obsolete("GetGodotBoneNode is deprecated. Use the GodotBoneNode property instead.")]
        public Godot.Collections.Dictionary GetGodotBoneNode()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_7, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_godot_bone_node");

        [GodotMethod("set_godot_bone_node")]
        [Obsolete("SetGodotBoneNode is deprecated. Use the GodotBoneNode property instead.")]
        public void SetGodotBoneNode(Godot.Collections.Dictionary godotBoneNode)
        {
            NativeCalls.godot_icall_1_213(method_bind_8, Object.GetPtr(this), godotBoneNode.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bone_attachment_count");

        [GodotMethod("get_bone_attachment_count")]
        public int GetBoneAttachmentCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bone_attachment");

        [GodotMethod("get_bone_attachment")]
        public BoneAttachment GetBoneAttachment(int idx)
        {
            return NativeCalls.godot_icall_1_457(method_bind_10, Object.GetPtr(this), idx);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
