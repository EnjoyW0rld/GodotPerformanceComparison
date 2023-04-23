using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Class that has everything pertaining to a 2D world. A physics space, a visual scenario, a navigation map and a sound space. 2D nodes register their resources into the current 2D world.</para>
    /// </summary>
    public partial class World2D : Resource
    {
        /// <summary>
        /// <para>The <see cref="Godot.RID"/> of this world's canvas resource. Used by the <see cref="Godot.VisualServer"/> for 2D drawing.</para>
        /// </summary>
        public RID Canvas
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCanvas();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The <see cref="Godot.RID"/> of this world's physics space resource. Used by the <see cref="Godot.Physics2DServer"/> for 2D physics, treating it as both a space and an area.</para>
        /// </summary>
        public RID Space
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSpace();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The <see cref="Godot.RID"/> of this world's navigation map. Used by the <see cref="Godot.Navigation2DServer"/>.</para>
        /// </summary>
        public RID NavigationMap
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNavigationMap();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Direct access to the world's physics 2D space state. Used for querying current and potential collisions. When using multi-threaded physics, access is limited to <c>_physics_process(delta)</c> in the main thread.</para>
        /// </summary>
        public Physics2DDirectSpaceState DirectSpaceState
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDirectSpaceState();
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "World2D";

        public World2D() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_World2D_Ctor(this);
        }

        internal World2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_canvas");

        [GodotMethod("get_canvas")]
        [Obsolete("GetCanvas is deprecated. Use the Canvas property instead.")]
        public RID GetCanvas()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_0, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_space");

        [GodotMethod("get_space")]
        [Obsolete("GetSpace is deprecated. Use the Space property instead.")]
        public RID GetSpace()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_1, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_navigation_map");

        [GodotMethod("get_navigation_map")]
        [Obsolete("GetNavigationMap is deprecated. Use the NavigationMap property instead.")]
        public RID GetNavigationMap()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_2, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_direct_space_state");

        [GodotMethod("get_direct_space_state")]
        [Obsolete("GetDirectSpaceState is deprecated. Use the DirectSpaceState property instead.")]
        public Physics2DDirectSpaceState GetDirectSpaceState()
        {
            return NativeCalls.godot_icall_0_734(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
