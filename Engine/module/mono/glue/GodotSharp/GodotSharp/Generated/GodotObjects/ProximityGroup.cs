using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>General-purpose proximity detection node. <see cref="Godot.ProximityGroup"/> can be used for approximate distance checks, which are faster than exact distance checks using <c>Vector3.distance_to</c> or <c>Vector3.distance_squared_to</c>.</para>
    /// <para><see cref="Godot.ProximityGroup"/> nodes are automatically grouped together, as long as they share the same <see cref="Godot.ProximityGroup.GroupName"/> and intersect with each other. By calling the <see cref="Godot.ProximityGroup.Broadcast"/>, you can invoke a specified method with various parameters to all intersecting members.</para>
    /// <para><see cref="Godot.ProximityGroup"/> is cuboid-shaped and consists of a cluster of <see cref="Godot.Vector3"/> coordinates. The coordinates are automatically calculated by calling <see cref="Godot.ProximityGroup.GridRadius"/>. To allow <see cref="Godot.ProximityGroup"/> to find its peers (and perform automatic grouping), you need to define its <see cref="Godot.ProximityGroup.GroupName"/> to a non-empty <see cref="string"/>. As soon as this object's shape intersects with another <see cref="Godot.ProximityGroup"/> object' shape, and both share the same <see cref="Godot.ProximityGroup.GroupName"/>, they will belong together for as long as they intersect.</para>
    /// <para>Since <see cref="Godot.ProximityGroup"/> doesn't rely the physics engine, you don't need to add any other node as a child (unlike <see cref="Godot.PhysicsBody"/>).</para>
    /// <para>The <see cref="Godot.ProximityGroup"/> uses the <see cref="Godot.SceneTree"/> groups in the background by calling the method <see cref="Godot.Node.AddToGroup"/> internally. The <see cref="Godot.SceneTree"/> group names are constructed by combining the <see cref="Godot.ProximityGroup.GroupName"/> with its coordinates, which are calculated using the <see cref="Godot.ProximityGroup.GridRadius"/> you defined beforehand.</para>
    /// <para>Example: A <see cref="Godot.ProximityGroup"/> node named <c>"PlanetEarth"</c> at position <c>Vector3(6, 6, 6)</c> with a <see cref="Godot.ProximityGroup.GroupName"/> set to <c>"planets"</c> and a <see cref="Godot.ProximityGroup.GridRadius"/> of <c>Vector3(1, 2, 3)</c> will create the following <see cref="Godot.SceneTree"/> group names:</para>
    /// <para><code>
    /// - "planets|5|4|3"
    /// - "planets|5|4|4"
    /// - "planets|5|4|5"
    /// - "planets|5|4|6"
    /// - "planets|5|4|7"
    /// - "planets|5|4|8"
    /// - "planets|5|4|9"
    /// - ...
    /// </code></para>
    /// <para>If there is another <see cref="Godot.ProximityGroup"/> named <c>"PlanetMars"</c> with group name <c>"planets"</c>, and one of its coordinates is <c>Vector3(5, 4, 7)</c>, it would normally create the <see cref="Godot.SceneTree"/> group called <c>"planets|5|4|7"</c>. However, since this group name already exists, this <see cref="Godot.ProximityGroup"/> object will be added to the existing one. <c>"PlanetEarth"</c> is already in this group. As long as both nodes don't change their transform and stop intersecting (or exit the scene tree), they are grouped together. As long as this intersection exists, any call to <see cref="Godot.ProximityGroup.Broadcast"/> will affect both <see cref="Godot.ProximityGroup"/> nodes.</para>
    /// <para>There are 3 caveats to keep in mind when using <see cref="Godot.ProximityGroup"/>:</para>
    /// <para>- The larger the grid radius, the more coordinates and the more <see cref="Godot.SceneTree"/> groups are created. This can have a performance impact if too many groups are created.</para>
    /// <para>- If the <see cref="Godot.ProximityGroup"/> node is transformed in any way (or is removed from the scene tree), the groupings will have to be recalculated. This can also have a performance impact.</para>
    /// <para>- If your <see cref="Godot.ProximityGroup.GridRadius"/> is smaller than <c>Vector3(1, 1, 1)</c>, it will be rounded up to <c>Vector3(1, 1, 1)</c>. Therefore, small grid radius values may lead to unwanted groupings.</para>
    /// <para>Note: <see cref="Godot.ProximityGroup"/> will be removed in Godot 4.0 in favor of more effective and faster <see cref="Godot.VisibilityNotifier"/> functionality. For most use cases, <c>Vector3.distance_to</c> or <c>Vector3.distance_squared_to</c> are fast enough too, especially if you call them less often using a <see cref="Godot.Timer"/> node.</para>
    /// </summary>
    public partial class ProximityGroup : Spatial
    {
        public enum DispatchModeEnum
        {
            /// <summary>
            /// <para>This <see cref="Godot.ProximityGroup"/>'s parent will be target of <see cref="Godot.ProximityGroup.Broadcast"/>.</para>
            /// </summary>
            Proxy = 0,
            /// <summary>
            /// <para>This <see cref="Godot.ProximityGroup"/> will emit the <c>broadcast</c> signal when calling the <see cref="Godot.ProximityGroup.Broadcast"/> method.</para>
            /// </summary>
            Signal = 1
        }

        /// <summary>
        /// <para>Specify the common group name, to let other <see cref="Godot.ProximityGroup"/> nodes know, if they should be auto-grouped with this node in case they intersect with each other.</para>
        /// <para>For example, if you have a <see cref="Godot.ProximityGroup"/> node named <c>"Earth"</c> and another called <c>"Mars"</c>, with both nodes having <c>"planet"</c> as their <see cref="Godot.ProximityGroup.GroupName"/>. Give both planets a significantly larger <see cref="Godot.ProximityGroup.GridRadius"/> than their actual radius, position them close enough and they'll be automatically grouped.</para>
        /// </summary>
        public string GroupName
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGroupName();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGroupName(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Specifies which node gets contacted on a call of method <see cref="Godot.ProximityGroup.Broadcast"/>.</para>
        /// </summary>
        public ProximityGroup.DispatchModeEnum DispatchMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDispatchMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDispatchMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The size of the space in 3D units. This also sets the amount of coordinates required to calculate whether two <see cref="Godot.ProximityGroup"/> nodes are intersecting or not. Smaller <see cref="Godot.ProximityGroup.GridRadius"/> values can be used for more precise proximity checks at the cost of performance, since more groups will be created.</para>
        /// </summary>
        public Vector3 GridRadius
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGridRadius();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGridRadius(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ProximityGroup";

        public ProximityGroup() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ProximityGroup_Ctor(this);
        }

        internal ProximityGroup(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_group_name");

        [GodotMethod("set_group_name")]
        [Obsolete("SetGroupName is deprecated. Use the GroupName property instead.")]
        public void SetGroupName(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_group_name");

        [GodotMethod("get_group_name")]
        [Obsolete("GetGroupName is deprecated. Use the GroupName property instead.")]
        public string GetGroupName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dispatch_mode");

        [GodotMethod("set_dispatch_mode")]
        [Obsolete("SetDispatchMode is deprecated. Use the DispatchMode property instead.")]
        public void SetDispatchMode(ProximityGroup.DispatchModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_dispatch_mode");

        [GodotMethod("get_dispatch_mode")]
        [Obsolete("GetDispatchMode is deprecated. Use the DispatchMode property instead.")]
        public ProximityGroup.DispatchModeEnum GetDispatchMode()
        {
            return (ProximityGroup.DispatchModeEnum)NativeCalls.godot_icall_0_813(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_grid_radius");

        [GodotMethod("set_grid_radius")]
        [Obsolete("SetGridRadius is deprecated. Use the GridRadius property instead.")]
        public void SetGridRadius(Vector3 radius)
        {
            NativeCalls.godot_icall_1_148(method_bind_4, Object.GetPtr(this), ref radius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_grid_radius");

        [GodotMethod("get_grid_radius")]
        [Obsolete("GetGridRadius is deprecated. Use the GridRadius property instead.")]
        public Vector3 GetGridRadius()
        {
            NativeCalls.godot_icall_0_8(method_bind_5, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "broadcast");

        /// <summary>
        /// <para>Calls on all intersecting <see cref="Godot.ProximityGroup"/> the given method and parameters.</para>
        /// <para>If the <see cref="Godot.ProximityGroup.DispatchMode"/> is set to <see cref="Godot.ProximityGroup.DispatchModeEnum.Proxy"/> (the default), all calls are delegated to their respective parent <see cref="Godot.Node"/>.</para>
        /// </summary>
        [GodotMethod("broadcast")]
        public void Broadcast(string method, object parameters)
        {
            NativeCalls.godot_icall_2_96(method_bind_6, Object.GetPtr(this), method, parameters);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
