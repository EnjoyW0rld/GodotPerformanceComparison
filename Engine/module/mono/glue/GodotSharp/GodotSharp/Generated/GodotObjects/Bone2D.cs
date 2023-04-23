using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Use a hierarchy of <c>Bone2D</c> bound to a <see cref="Godot.Skeleton2D"/> to control, and animate other <see cref="Godot.Node2D"/> nodes.</para>
    /// <para>You can use <c>Bone2D</c> and <c>Skeleton2D</c> nodes to animate 2D meshes created with the Polygon 2D UV editor.</para>
    /// <para>Each bone has a <see cref="Godot.Bone2D.Rest"/> transform that you can reset to with <see cref="Godot.Bone2D.ApplyRest"/>. These rest poses are relative to the bone's parent.</para>
    /// <para>If in the editor, you can set the rest pose of an entire skeleton using a menu option, from the code, you need to iterate over the bones to set their individual rest poses.</para>
    /// </summary>
    public partial class Bone2D : Node2D
    {
        /// <summary>
        /// <para>Rest transform of the bone. You can reset the node's transforms to this value using <see cref="Godot.Bone2D.ApplyRest"/>.</para>
        /// </summary>
        public Transform2D Rest
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRest();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRest(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Length of the bone's representation drawn in the editor's viewport in pixels.</para>
        /// </summary>
        public float DefaultLength
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDefaultLength();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDefaultLength(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Bone2D";

        public Bone2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Bone2D_Ctor(this);
        }

        internal Bone2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rest");

        [GodotMethod("set_rest")]
        [Obsolete("SetRest is deprecated. Use the Rest property instead.")]
        public void SetRest(Transform2D rest)
        {
            NativeCalls.godot_icall_1_220(method_bind_0, Object.GetPtr(this), ref rest);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rest");

        [GodotMethod("get_rest")]
        [Obsolete("GetRest is deprecated. Use the Rest property instead.")]
        public Transform2D GetRest()
        {
            NativeCalls.godot_icall_0_221(method_bind_1, Object.GetPtr(this), out Transform2D argRet); return (Transform2D)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "apply_rest");

        /// <summary>
        /// <para>Stores the node's current transforms in <see cref="Godot.Bone2D.Rest"/>.</para>
        /// </summary>
        [GodotMethod("apply_rest")]
        public void ApplyRest()
        {
            NativeCalls.godot_icall_0_3(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_skeleton_rest");

        /// <summary>
        /// <para>Returns the node's <see cref="Godot.Bone2D.Rest"/> <c>Transform2D</c> if it doesn't have a parent, or its rest pose relative to its parent.</para>
        /// </summary>
        [GodotMethod("get_skeleton_rest")]
        public Transform2D GetSkeletonRest()
        {
            NativeCalls.godot_icall_0_221(method_bind_3, Object.GetPtr(this), out Transform2D argRet); return (Transform2D)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_index_in_skeleton");

        /// <summary>
        /// <para>Returns the node's index as part of the entire skeleton. See <see cref="Godot.Skeleton2D"/>.</para>
        /// </summary>
        [GodotMethod("get_index_in_skeleton")]
        public int GetIndexInSkeleton()
        {
            return NativeCalls.godot_icall_0_5(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_default_length");

        [GodotMethod("set_default_length")]
        [Obsolete("SetDefaultLength is deprecated. Use the DefaultLength property instead.")]
        public void SetDefaultLength(float defaultLength)
        {
            NativeCalls.godot_icall_1_15(method_bind_5, Object.GetPtr(this), defaultLength);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_default_length");

        [GodotMethod("get_default_length")]
        [Obsolete("GetDefaultLength is deprecated. Use the DefaultLength property instead.")]
        public float GetDefaultLength()
        {
            return NativeCalls.godot_icall_0_14(method_bind_6, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
