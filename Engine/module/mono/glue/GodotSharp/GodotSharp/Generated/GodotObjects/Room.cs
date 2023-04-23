using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The <see cref="Godot.Portal"/> culling system requires levels to be built using objects grouped together by location in areas called <see cref="Godot.Room"/>s. In many cases these will correspond to actual rooms in buildings, but not necessarily (a canyon area may be treated as a room).</para>
    /// <para>Any <see cref="Godot.VisualInstance"/> that is a child or grandchild of a <see cref="Godot.Room"/> will be assigned to that room, if the <c>portal_mode</c> of that <see cref="Godot.VisualInstance"/> is set to <c>STATIC</c> (does not move) or <c>DYNAMIC</c> (moves only within the room).</para>
    /// <para>Internally the room boundary must form a convex hull, and by default this is determined automatically by the geometry of the objects you place within the room.</para>
    /// <para>You can alternatively precisely specify a manual bound. If you place a <see cref="Godot.MeshInstance"/> with a name prefixed by <c>Bound_</c>, it will turn off the bound generation from geometry, and instead use the vertices of this MeshInstance to directly calculate a convex hull during the conversion stage (see <see cref="Godot.RoomManager"/>).</para>
    /// <para>In order to see from one room into an adjacent room, <see cref="Godot.Portal"/>s must be placed over non-occluded openings between rooms. These will often be placed over doors and windows.</para>
    /// </summary>
    public partial class Room : Spatial
    {
        /// <summary>
        /// <para>The room hull simplification can either use the default value set in the <see cref="Godot.RoomManager"/>, or override this and use the per room setting.</para>
        /// </summary>
        public bool UseDefaultSimplify
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUseDefaultSimplify();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseDefaultSimplify(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The <c>simplify</c> value determines to what degree room hulls (bounds) are simplified, by removing similar planes. A value of 0 gives no simplification, 1 gives maximum simplification.</para>
        /// </summary>
        public float RoomSimplify
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRoomSimplify();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRoomSimplify(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>points</c> are set, the <see cref="Godot.Room"/> bounding convex hull will be built from these points. If no points are set, the room bound will either be derived from a manual bound (<see cref="Godot.MeshInstance"/> with name prefix <c>Bound_</c>), or from the geometry within the room.</para>
        /// <para>Note that you can use the <c>Generate Points</c> editor button to get started. This will use either the geometry or manual bound to generate the room hull, and save the resulting points, allowing you to edit them to further refine the bound.</para>
        /// </summary>
        public Vector3[] Points
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPoints();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPoints(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Room";

        public Room() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Room_Ctor(this);
        }

        internal Room(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_default_simplify");

        [GodotMethod("set_use_default_simplify")]
        [Obsolete("SetUseDefaultSimplify is deprecated. Use the UseDefaultSimplify property instead.")]
        public void SetUseDefaultSimplify(bool pUse)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), pUse);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_use_default_simplify");

        [GodotMethod("get_use_default_simplify")]
        [Obsolete("GetUseDefaultSimplify is deprecated. Use the UseDefaultSimplify property instead.")]
        public bool GetUseDefaultSimplify()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_room_simplify");

        [GodotMethod("set_room_simplify")]
        [Obsolete("SetRoomSimplify is deprecated. Use the RoomSimplify property instead.")]
        public void SetRoomSimplify(float pValue)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), pValue);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_room_simplify");

        [GodotMethod("get_room_simplify")]
        [Obsolete("GetRoomSimplify is deprecated. Use the RoomSimplify property instead.")]
        public float GetRoomSimplify()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_points");

        [GodotMethod("set_points")]
        [Obsolete("SetPoints is deprecated. Use the Points property instead.")]
        public void SetPoints(Vector3[] points)
        {
            NativeCalls.godot_icall_1_229(method_bind_4, Object.GetPtr(this), points);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_points");

        [GodotMethod("get_points")]
        [Obsolete("GetPoints is deprecated. Use the Points property instead.")]
        public Vector3[] GetPoints()
        {
            return NativeCalls.godot_icall_0_230(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_point");

        /// <summary>
        /// <para>Sets individual points. Primarily for use by the editor.</para>
        /// </summary>
        [GodotMethod("set_point")]
        public void SetPoint(int index, Vector3 position)
        {
            NativeCalls.godot_icall_2_33(method_bind_6, Object.GetPtr(this), index, ref position);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
