using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Skeleton2D parents a hierarchy of <see cref="Godot.Bone2D"/> objects. It is a requirement of <see cref="Godot.Bone2D"/>. Skeleton2D holds a reference to the rest pose of its children and acts as a single point of access to its bones.</para>
    /// </summary>
    public partial class Skeleton2D : Node2D
    {
        private const string nativeName = "Skeleton2D";

        public Skeleton2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Skeleton2D_Ctor(this);
        }

        internal Skeleton2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bone_count");

        /// <summary>
        /// <para>Returns the number of <see cref="Godot.Bone2D"/> nodes in the node hierarchy parented by Skeleton2D.</para>
        /// </summary>
        [GodotMethod("get_bone_count")]
        public int GetBoneCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bone");

        /// <summary>
        /// <para>Returns a <see cref="Godot.Bone2D"/> from the node hierarchy parented by Skeleton2D. The object to return is identified by the parameter <c>idx</c>. Bones are indexed by descending the node hierarchy from top to bottom, adding the children of each branch before moving to the next sibling.</para>
        /// </summary>
        [GodotMethod("get_bone")]
        public Bone2D GetBone(int idx)
        {
            return NativeCalls.godot_icall_1_862(method_bind_1, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_skeleton");

        /// <summary>
        /// <para>Returns the <see cref="Godot.RID"/> of a Skeleton2D instance.</para>
        /// </summary>
        [GodotMethod("get_skeleton")]
        public RID GetSkeleton()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_2, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
