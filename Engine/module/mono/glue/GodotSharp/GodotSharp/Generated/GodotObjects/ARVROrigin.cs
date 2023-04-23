using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This is a special node within the AR/VR system that maps the physical location of the center of our tracking space to the virtual location within our game world.</para>
    /// <para>There should be only one of these nodes in your scene and you must have one. All the ARVRCamera, ARVRController and ARVRAnchor nodes should be direct children of this node for spatial tracking to work correctly.</para>
    /// <para>It is the position of this node that you update when your character needs to move through your game world while we're not moving in the real world. Movement in the real world is always in relation to this origin point.</para>
    /// <para>For example, if your character is driving a car, the ARVROrigin node should be a child node of this car. Or, if you're implementing a teleport system to move your character, you should change the position of this node.</para>
    /// </summary>
    public partial class ARVROrigin : Spatial
    {
        /// <summary>
        /// <para>Allows you to adjust the scale to your game's units. Most AR/VR platforms assume a scale of 1 game world unit = 1 real world meter.</para>
        /// <para>Note: This method is a passthrough to the <see cref="Godot.ARVRServer"/> itself.</para>
        /// </summary>
        public float WorldScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetWorldScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetWorldScale(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ARVROrigin";

        public ARVROrigin() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ARVROrigin_Ctor(this);
        }

        internal ARVROrigin(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_world_scale");

        [GodotMethod("set_world_scale")]
        [Obsolete("SetWorldScale is deprecated. Use the WorldScale property instead.")]
        public void SetWorldScale(float worldScale)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), worldScale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_world_scale");

        [GodotMethod("get_world_scale")]
        [Obsolete("GetWorldScale is deprecated. Use the WorldScale property instead.")]
        public float GetWorldScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
