using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Although <see cref="Godot.Room"/> behavior can be specified individually, sometimes it is faster and more convenient to write functionality for a group of rooms.</para>
    /// <para><see cref="Godot.RoomGroup"/>s should be placed as children of the room list (the parent <see cref="Godot.Node"/> of your <see cref="Godot.Room"/>s), and <see cref="Godot.Room"/>s should be placed in turn as children of a <see cref="Godot.RoomGroup"/> in order to assign them to the RoomGroup.</para>
    /// <para>A <see cref="Godot.RoomGroup"/> can for example be used to specify <see cref="Godot.Room"/>s that are outside, and switch on or off a directional light, sky, or rain effect as the player enters / exits the area.</para>
    /// <para><see cref="Godot.RoomGroup"/>s receive gameplay callbacks when the <c>gameplay_monitor</c> is switched on, as <c>signal</c>s or <c>notification</c>s as they enter and exit the gameplay area (see <see cref="Godot.RoomManager"/> for details).</para>
    /// </summary>
    public partial class RoomGroup : Spatial
    {
        /// <summary>
        /// <para>This priority will be applied to <see cref="Godot.Room"/>s within the group. The <see cref="Godot.Room"/> priority allows the use of internal rooms, rooms within another room or rooms.</para>
        /// <para>When the <see cref="Godot.Camera"/> is within more than one room (regular and internal), the higher priority room will take precedence. So with for example, a house inside a terrain 'room', you would make the house higher priority, so that when the camera is within the house, the house is used as the source room, but outside the house, the terrain room would be used instead.</para>
        /// </summary>
        public int RoomgroupPriority
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRoomgroupPriority();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRoomgroupPriority(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "RoomGroup";

        public RoomGroup() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_RoomGroup_Ctor(this);
        }

        internal RoomGroup(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_roomgroup_priority");

        [GodotMethod("set_roomgroup_priority")]
        [Obsolete("SetRoomgroupPriority is deprecated. Use the RoomgroupPriority property instead.")]
        public void SetRoomgroupPriority(int pPriority)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), pPriority);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_roomgroup_priority");

        [GodotMethod("get_roomgroup_priority")]
        [Obsolete("GetRoomgroupPriority is deprecated. Use the RoomgroupPriority property instead.")]
        public int GetRoomgroupPriority()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
