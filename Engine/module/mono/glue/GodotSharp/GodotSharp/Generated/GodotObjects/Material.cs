using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Material is a base <see cref="Godot.Resource"/> used for coloring and shading geometry. All materials inherit from it and almost all <see cref="Godot.VisualInstance"/> derived nodes carry a Material. A few flags and parameters are shared between all material types and are configured here.</para>
    /// </summary>
    public abstract partial class Material : Resource
    {
        /// <summary>
        /// <para>Maximum value for the <see cref="Godot.Material.RenderPriority"/> parameter.</para>
        /// </summary>
        public const int RenderPriorityMax = 127;
        /// <summary>
        /// <para>Minimum value for the <see cref="Godot.Material.RenderPriority"/> parameter.</para>
        /// </summary>
        public const int RenderPriorityMin = -128;

        /// <summary>
        /// <para>Sets the render priority for transparent objects in 3D scenes. Higher priority objects will be sorted in front of lower priority objects.</para>
        /// <para>Note: This only applies to sorting of transparent objects. This will not impact how transparent objects are sorted relative to opaque objects. This is because opaque objects are not sorted, while transparent objects are sorted from back to front (subject to priority).</para>
        /// </summary>
        public int RenderPriority
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRenderPriority();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRenderPriority(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the <see cref="Godot.Material"/> to be used for the next pass. This renders the object again using a different material.</para>
        /// <para>Note: This only applies to <see cref="Godot.SpatialMaterial"/>s and <see cref="Godot.ShaderMaterial"/>s with type "Spatial".</para>
        /// </summary>
        public Material NextPass
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNextPass();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetNextPass(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Material";

        internal Material() {}

        internal Material(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_next_pass");

        [GodotMethod("set_next_pass")]
        [Obsolete("SetNextPass is deprecated. Use the NextPass property instead.")]
        public void SetNextPass(Material nextPass)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(nextPass));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_next_pass");

        [GodotMethod("get_next_pass")]
        [Obsolete("GetNextPass is deprecated. Use the NextPass property instead.")]
        public Material GetNextPass()
        {
            return NativeCalls.godot_icall_0_237(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_render_priority");

        [GodotMethod("set_render_priority")]
        [Obsolete("SetRenderPriority is deprecated. Use the RenderPriority property instead.")]
        public void SetRenderPriority(int priority)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), priority);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_render_priority");

        [GodotMethod("get_render_priority")]
        [Obsolete("GetRenderPriority is deprecated. Use the RenderPriority property instead.")]
        public int GetRenderPriority()
        {
            return NativeCalls.godot_icall_0_5(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
