using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>2D obstacle used in navigation for collision avoidance. The obstacle needs navigation data to work correctly. This can be done by having the obstacle as a child of a <see cref="Godot.Navigation2D"/> node, or using <see cref="Godot.NavigationObstacle2D.SetNavigation"/>. <see cref="Godot.NavigationObstacle2D"/> is physics safe.</para>
    /// <para>Note: Obstacles are intended as a last resort option for constantly moving objects that cannot be (re)baked to a navigation mesh efficiently.</para>
    /// </summary>
    public partial class NavigationObstacle2D : Node
    {
        /// <summary>
        /// <para>Enables radius estimation algorithm which uses parent's collision shapes to determine the obstacle radius.</para>
        /// </summary>
        public bool EstimateRadius
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsRadiusEstimated();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEstimateRadius(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The radius of the agent. Used only if <see cref="Godot.NavigationObstacle2D.EstimateRadius"/> is set to <c>false</c>.</para>
        /// </summary>
        public float Radius
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRadius();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRadius(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "NavigationObstacle2D";

        public NavigationObstacle2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_NavigationObstacle2D_Ctor(this);
        }

        internal NavigationObstacle2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rid");

        /// <summary>
        /// <para>Returns the <see cref="Godot.RID"/> of this obstacle on the <see cref="Godot.Navigation2DServer"/>.</para>
        /// </summary>
        [GodotMethod("get_rid")]
        public RID GetRid()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_0, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_navigation");

        /// <summary>
        /// <para>Sets the <see cref="Godot.Navigation2D"/> node used by the obstacle. Useful when you don't want to make the obstacle a child of a <see cref="Godot.Navigation2D"/> node.</para>
        /// </summary>
        [GodotMethod("set_navigation")]
        public void SetNavigation(Node navigation)
        {
            NativeCalls.godot_icall_1_53(method_bind_1, Object.GetPtr(this), Object.GetPtr(navigation));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_navigation");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Navigation2D"/> node that the obstacle is using for its navigation system.</para>
        /// </summary>
        [GodotMethod("get_navigation")]
        public Node GetNavigation()
        {
            return NativeCalls.godot_icall_0_257(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_estimate_radius");

        [GodotMethod("set_estimate_radius")]
        [Obsolete("SetEstimateRadius is deprecated. Use the EstimateRadius property instead.")]
        public void SetEstimateRadius(bool estimateRadius)
        {
            NativeCalls.godot_icall_1_16(method_bind_3, Object.GetPtr(this), estimateRadius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_radius_estimated");

        [GodotMethod("is_radius_estimated")]
        [Obsolete("IsRadiusEstimated is deprecated. Use the EstimateRadius property instead.")]
        public bool IsRadiusEstimated()
        {
            return NativeCalls.godot_icall_0_7(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_radius");

        [GodotMethod("set_radius")]
        [Obsolete("SetRadius is deprecated. Use the Radius property instead.")]
        public void SetRadius(float radius)
        {
            NativeCalls.godot_icall_1_15(method_bind_5, Object.GetPtr(this), radius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_radius");

        [GodotMethod("get_radius")]
        [Obsolete("GetRadius is deprecated. Use the Radius property instead.")]
        public float GetRadius()
        {
            return NativeCalls.godot_icall_0_14(method_bind_6, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
