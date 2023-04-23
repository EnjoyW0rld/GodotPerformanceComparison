using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The VisibilityNotifier detects when it is visible on the screen. It also notifies when its bounding rectangle enters or exits the screen or a <see cref="Godot.Camera"/>'s view.</para>
    /// <para>If you want nodes to be disabled automatically when they exit the screen, use <see cref="Godot.VisibilityEnabler"/> instead.</para>
    /// <para>Note: VisibilityNotifier uses an approximate heuristic for performance reasons. It doesn't take walls and other occlusion into account (unless you are using <see cref="Godot.Portal"/>s). The heuristic is an implementation detail and may change in future versions. If you need precise visibility checking, use another method such as adding an <see cref="Godot.Area"/> node as a child of a <see cref="Godot.Camera"/> node and/or <c>Vector3.dot</c>.</para>
    /// </summary>
    public partial class VisibilityNotifier : CullInstance
    {
        /// <summary>
        /// <para>The VisibilityNotifier's bounding box.</para>
        /// </summary>
        public AABB Aabb
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAabb();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAabb(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>In addition to checking whether a node is on screen or within a <see cref="Godot.Camera"/>'s view, VisibilityNotifier can also optionally check whether a node is within a specified maximum distance when using a <see cref="Godot.Camera"/> with perspective projection. This is useful for throttling the performance requirements of nodes that are far away.</para>
        /// <para>Note: This feature will be disabled if set to 0.0.</para>
        /// </summary>
        public float MaxDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaxDistance();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaxDistance(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisibilityNotifier";

        public VisibilityNotifier() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisibilityNotifier_Ctor(this);
        }

        internal VisibilityNotifier(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_aabb");

        [GodotMethod("set_aabb")]
        [Obsolete("SetAabb is deprecated. Use the Aabb property instead.")]
        public void SetAabb(AABB rect)
        {
            NativeCalls.godot_icall_1_157(method_bind_0, Object.GetPtr(this), ref rect);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_aabb");

        [GodotMethod("get_aabb")]
        [Obsolete("GetAabb is deprecated. Use the Aabb property instead.")]
        public AABB GetAabb()
        {
            NativeCalls.godot_icall_0_158(method_bind_1, Object.GetPtr(this), out AABB argRet); return (AABB)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_on_screen");

        /// <summary>
        /// <para>If <c>true</c>, the bounding box is on the screen.</para>
        /// <para>Note: It takes one frame for the node's visibility to be assessed once added to the scene tree, so this method will return <c>false</c> right after it is instantiated, even if it will be on screen in the draw pass.</para>
        /// </summary>
        [GodotMethod("is_on_screen")]
        public bool IsOnScreen()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max_distance");

        [GodotMethod("set_max_distance")]
        [Obsolete("SetMaxDistance is deprecated. Use the MaxDistance property instead.")]
        public void SetMaxDistance(float distance)
        {
            NativeCalls.godot_icall_1_15(method_bind_3, Object.GetPtr(this), distance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max_distance");

        [GodotMethod("get_max_distance")]
        [Obsolete("GetMaxDistance is deprecated. Use the MaxDistance property instead.")]
        public float GetMaxDistance()
        {
            return NativeCalls.godot_icall_0_14(method_bind_4, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
