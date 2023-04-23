using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Class that has everything pertaining to a world. A physics space, a visual scenario, a navigation map and a sound space. Spatial nodes register their resources into the current world.</para>
    /// </summary>
    public partial class World : Resource
    {
        /// <summary>
        /// <para>The World's <see cref="Godot.Environment"/>.</para>
        /// </summary>
        public Environment Environment
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEnvironment();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnvironment(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The World's fallback environment will be used if <see cref="Godot.World.Environment"/> fails or is missing.</para>
        /// </summary>
        public Environment FallbackEnvironment
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFallbackEnvironment();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFallbackEnvironment(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The World's physics space.</para>
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
        /// <para>The World's visual scenario.</para>
        /// </summary>
        public RID Scenario
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetScenario();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The <see cref="Godot.RID"/> of this world's navigation map. Used by the <see cref="Godot.NavigationServer"/>.</para>
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
        /// <para>Direct access to the world's physics 3D space state. Used for querying current and potential collisions.</para>
        /// </summary>
        public PhysicsDirectSpaceState DirectSpaceState
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDirectSpaceState();
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "World";

        public World() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_World_Ctor(this);
        }

        internal World(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_space");

        [GodotMethod("get_space")]
        [Obsolete("GetSpace is deprecated. Use the Space property instead.")]
        public RID GetSpace()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_0, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_scenario");

        [GodotMethod("get_scenario")]
        [Obsolete("GetScenario is deprecated. Use the Scenario property instead.")]
        public RID GetScenario()
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
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_environment");

        [GodotMethod("set_environment")]
        [Obsolete("SetEnvironment is deprecated. Use the Environment property instead.")]
        public void SetEnvironment(Environment env)
        {
            NativeCalls.godot_icall_1_24(method_bind_3, Object.GetPtr(this), Object.GetPtr(env));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_environment");

        [GodotMethod("get_environment")]
        [Obsolete("GetEnvironment is deprecated. Use the Environment property instead.")]
        public Environment GetEnvironment()
        {
            return NativeCalls.godot_icall_0_251(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fallback_environment");

        [GodotMethod("set_fallback_environment")]
        [Obsolete("SetFallbackEnvironment is deprecated. Use the FallbackEnvironment property instead.")]
        public void SetFallbackEnvironment(Environment env)
        {
            NativeCalls.godot_icall_1_24(method_bind_5, Object.GetPtr(this), Object.GetPtr(env));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fallback_environment");

        [GodotMethod("get_fallback_environment")]
        [Obsolete("GetFallbackEnvironment is deprecated. Use the FallbackEnvironment property instead.")]
        public Environment GetFallbackEnvironment()
        {
            return NativeCalls.godot_icall_0_251(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_direct_space_state");

        [GodotMethod("get_direct_space_state")]
        [Obsolete("GetDirectSpaceState is deprecated. Use the DirectSpaceState property instead.")]
        public PhysicsDirectSpaceState GetDirectSpaceState()
        {
            return NativeCalls.godot_icall_0_770(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
