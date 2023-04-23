using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This node must be the child of a <see cref="Godot.Skeleton"/> node. You can then select a bone for this node to attach to. The BoneAttachment node will copy the transform of the selected bone.</para>
    /// </summary>
    public partial class BoneAttachment : Spatial
    {
        /// <summary>
        /// <para>The name of the attached bone.</para>
        /// </summary>
        public string BoneName
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBoneName();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBoneName(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "BoneAttachment";

        public BoneAttachment() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_BoneAttachment_Ctor(this);
        }

        internal BoneAttachment(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bone_name");

        [GodotMethod("set_bone_name")]
        [Obsolete("SetBoneName is deprecated. Use the BoneName property instead.")]
        public void SetBoneName(string boneName)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), boneName);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bone_name");

        [GodotMethod("get_bone_name")]
        [Obsolete("GetBoneName is deprecated. Use the BoneName property instead.")]
        public string GetBoneName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
