using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class Skin : Resource
    {
        private const string nativeName = "Skin";

        public Skin() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Skin_Ctor(this);
        }

        internal Skin(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bind_count");

        [GodotMethod("set_bind_count")]
        public void SetBindCount(int bindCount)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), bindCount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bind_count");

        [GodotMethod("get_bind_count")]
        public int GetBindCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_bind");

        [GodotMethod("add_bind")]
        public void AddBind(int bone, Transform pose)
        {
            NativeCalls.godot_icall_2_606(method_bind_2, Object.GetPtr(this), bone, ref pose);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bind_pose");

        [GodotMethod("set_bind_pose")]
        public void SetBindPose(int bindIndex, Transform pose)
        {
            NativeCalls.godot_icall_2_606(method_bind_3, Object.GetPtr(this), bindIndex, ref pose);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bind_pose");

        [GodotMethod("get_bind_pose")]
        public Transform GetBindPose(int bindIndex)
        {
            NativeCalls.godot_icall_1_609(method_bind_4, Object.GetPtr(this), bindIndex, out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bind_name");

        [GodotMethod("set_bind_name")]
        public void SetBindName(int bindIndex, string name)
        {
            NativeCalls.godot_icall_2_121(method_bind_5, Object.GetPtr(this), bindIndex, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bind_name");

        [GodotMethod("get_bind_name")]
        public string GetBindName(int bindIndex)
        {
            return NativeCalls.godot_icall_1_89(method_bind_6, Object.GetPtr(this), bindIndex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bind_bone");

        [GodotMethod("set_bind_bone")]
        public void SetBindBone(int bindIndex, int bone)
        {
            NativeCalls.godot_icall_2_65(method_bind_7, Object.GetPtr(this), bindIndex, bone);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bind_bone");

        [GodotMethod("get_bind_bone")]
        public int GetBindBone(int bindIndex)
        {
            return NativeCalls.godot_icall_1_11(method_bind_8, Object.GetPtr(this), bindIndex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_binds");

        [GodotMethod("clear_binds")]
        public void ClearBinds()
        {
            NativeCalls.godot_icall_0_3(method_bind_9, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
