using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Occludes light cast by a Light2D, casting shadows. The LightOccluder2D must be provided with an <see cref="Godot.OccluderPolygon2D"/> in order for the shadow to be computed.</para>
    /// </summary>
    public partial class LightOccluder2D : Node2D
    {
        /// <summary>
        /// <para>The <see cref="Godot.OccluderPolygon2D"/> used to compute the shadow.</para>
        /// </summary>
        public OccluderPolygon2D Occluder
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOccluderPolygon();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOccluderPolygon(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The LightOccluder2D's light mask. The LightOccluder2D will cast shadows only from Light2D(s) that have the same light mask(s).</para>
        /// </summary>
        public int LightMask
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOccluderLightMask();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOccluderLightMask(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "LightOccluder2D";

        public LightOccluder2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_LightOccluder2D_Ctor(this);
        }

        internal LightOccluder2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_occluder_polygon");

        [GodotMethod("set_occluder_polygon")]
        [Obsolete("SetOccluderPolygon is deprecated. Use the Occluder property instead.")]
        public void SetOccluderPolygon(OccluderPolygon2D polygon)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(polygon));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_occluder_polygon");

        [GodotMethod("get_occluder_polygon")]
        [Obsolete("GetOccluderPolygon is deprecated. Use the Occluder property instead.")]
        public OccluderPolygon2D GetOccluderPolygon()
        {
            return NativeCalls.godot_icall_0_585(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_occluder_light_mask");

        [GodotMethod("set_occluder_light_mask")]
        [Obsolete("SetOccluderLightMask is deprecated. Use the LightMask property instead.")]
        public void SetOccluderLightMask(int mask)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_occluder_light_mask");

        [GodotMethod("get_occluder_light_mask")]
        [Obsolete("GetOccluderLightMask is deprecated. Use the LightMask property instead.")]
        public int GetOccluderLightMask()
        {
            return NativeCalls.godot_icall_0_5(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
