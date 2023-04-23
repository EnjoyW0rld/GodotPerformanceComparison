using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The <see cref="Godot.ARVRAnchor"/> point is a spatial node that maps a real world location identified by the AR platform to a position within the game world. For example, as long as plane detection in ARKit is on, ARKit will identify and update the position of planes (tables, floors, etc) and create anchors for them.</para>
    /// <para>This node is mapped to one of the anchors through its unique ID. When you receive a signal that a new anchor is available, you should add this node to your scene for that anchor. You can predefine nodes and set the ID; the nodes will simply remain on 0,0,0 until a plane is recognized.</para>
    /// <para>Keep in mind that, as long as plane detection is enabled, the size, placing and orientation of an anchor will be updated as the detection logic learns more about the real world out there especially if only part of the surface is in view.</para>
    /// </summary>
    public partial class ARVRAnchor : Spatial
    {
        /// <summary>
        /// <para>The anchor's ID. You can set this before the anchor itself exists. The first anchor gets an ID of <c>1</c>, the second an ID of <c>2</c>, etc. When anchors get removed, the engine can then assign the corresponding ID to new anchors. The most common situation where anchors "disappear" is when the AR server identifies that two anchors represent different parts of the same plane and merges them.</para>
        /// </summary>
        public int AnchorId
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAnchorId();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAnchorId(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ARVRAnchor";

        public ARVRAnchor() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ARVRAnchor_Ctor(this);
        }

        internal ARVRAnchor(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_anchor_id");

        [GodotMethod("set_anchor_id")]
        [Obsolete("SetAnchorId is deprecated. Use the AnchorId property instead.")]
        public void SetAnchorId(int anchorId)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), anchorId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_anchor_id");

        [GodotMethod("get_anchor_id")]
        [Obsolete("GetAnchorId is deprecated. Use the AnchorId property instead.")]
        public int GetAnchorId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_anchor_name");

        /// <summary>
        /// <para>Returns the name given to this anchor.</para>
        /// </summary>
        [GodotMethod("get_anchor_name")]
        public string GetAnchorName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_is_active");

        /// <summary>
        /// <para>Returns <c>true</c> if the anchor is being tracked and <c>false</c> if no anchor with this ID is currently known.</para>
        /// </summary>
        [GodotMethod("get_is_active")]
        public bool GetIsActive()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_size");

        /// <summary>
        /// <para>Returns the estimated size of the plane that was detected. Say when the anchor relates to a table in the real world, this is the estimated size of the surface of that table.</para>
        /// </summary>
        [GodotMethod("get_size")]
        public Vector3 GetSize()
        {
            NativeCalls.godot_icall_0_8(method_bind_4, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_plane");

        /// <summary>
        /// <para>Returns a plane aligned with our anchor; handy for intersection testing.</para>
        /// </summary>
        [GodotMethod("get_plane")]
        public Plane GetPlane()
        {
            NativeCalls.godot_icall_0_9(method_bind_5, Object.GetPtr(this), out Plane argRet); return (Plane)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mesh");

        /// <summary>
        /// <para>If provided by the <see cref="Godot.ARVRInterface"/>, this returns a mesh object for the anchor. For an anchor, this can be a shape related to the object being tracked or it can be a mesh that provides topology related to the anchor and can be used to create shadows/reflections on surfaces or for generating collision shapes.</para>
        /// </summary>
        [GodotMethod("get_mesh")]
        public Mesh GetMesh()
        {
            return NativeCalls.godot_icall_0_10(method_bind_6, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
