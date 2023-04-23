using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.Occluder"/>s that are placed within your scene will automatically cull objects that are hidden from view by the occluder. This can increase performance by decreasing the amount of objects drawn.</para>
    /// <para><see cref="Godot.Occluder"/>s are totally dynamic, you can move them as you wish. This means you can for example, place occluders on a moving spaceship, and have it occlude objects as it flies past.</para>
    /// <para>You can place a large number of <see cref="Godot.Occluder"/>s within a scene. As it would be counterproductive to cull against hundreds of occluders, the system will automatically choose a selection of these for active use during any given frame, based a screen space metric. Larger occluders are favored, as well as those close to the camera. Note that a small occluder close to the camera may be a better occluder in terms of screen space than a large occluder far in the distance.</para>
    /// <para>The type of occlusion primitive is determined by the <see cref="Godot.OccluderShape"/> that you add to the <see cref="Godot.Occluder"/>. Some <see cref="Godot.OccluderShape"/>s may allow more than one primitive in a single, node, for greater efficiency.</para>
    /// <para>Although <see cref="Godot.Occluder"/>s work in general use, they also become even more powerful when used in conjunction with the portal system. Occluders are placed in rooms (based on their origin), and can block portals (and thus entire rooms) as well as objects from rendering.</para>
    /// </summary>
    public partial class Occluder : Spatial
    {
        public OccluderShape Shape
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShape();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShape(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Occluder";

        public Occluder() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Occluder_Ctor(this);
        }

        internal Occluder(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "resource_changed");

        [GodotMethod("resource_changed")]
        public void ResourceChanged(Resource resource)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(resource));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shape");

        [GodotMethod("set_shape")]
        [Obsolete("SetShape is deprecated. Use the Shape property instead.")]
        public void SetShape(OccluderShape shape)
        {
            NativeCalls.godot_icall_1_24(method_bind_1, Object.GetPtr(this), Object.GetPtr(shape));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shape");

        [GodotMethod("get_shape")]
        [Obsolete("GetShape is deprecated. Use the Shape property instead.")]
        public OccluderShape GetShape()
        {
            return NativeCalls.godot_icall_0_700(method_bind_2, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
