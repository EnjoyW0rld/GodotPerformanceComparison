using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>An instance of this object represents a device that is tracked, such as a controller or anchor point. HMDs aren't represented here as they are handled internally.</para>
    /// <para>As controllers are turned on and the AR/VR interface detects them, instances of this object are automatically added to this list of active tracking objects accessible through the <see cref="Godot.ARVRServer"/>.</para>
    /// <para>The <see cref="Godot.ARVRController"/> and <see cref="Godot.ARVRAnchor"/> both consume objects of this type and should be used in your project. The positional trackers are just under-the-hood objects that make this all work. These are mostly exposed so that GDNative-based interfaces can interact with them.</para>
    /// </summary>
    public partial class ARVRPositionalTracker : Reference
    {
        public enum TrackerHand
        {
            /// <summary>
            /// <para>The hand this tracker is held in is unknown or not applicable.</para>
            /// </summary>
            HandUnknown = 0,
            /// <summary>
            /// <para>This tracker is the left hand controller.</para>
            /// </summary>
            LeftHand = 1,
            /// <summary>
            /// <para>This tracker is the right hand controller.</para>
            /// </summary>
            RightHand = 2
        }

        /// <summary>
        /// <para>The degree to which the tracker rumbles. Ranges from <c>0.0</c> to <c>1.0</c> with precision <c>.01</c>.</para>
        /// </summary>
        public float Rumble
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRumble();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRumble(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ARVRPositionalTracker";

        public ARVRPositionalTracker() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ARVRPositionalTracker_Ctor(this);
        }

        internal ARVRPositionalTracker(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_type");

        /// <summary>
        /// <para>Returns the tracker's type.</para>
        /// </summary>
        [GodotMethod("get_type")]
        public ARVRServer.TrackerType GetType()
        {
            return (ARVRServer.TrackerType)NativeCalls.godot_icall_0_19(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tracker_id");

        /// <summary>
        /// <para>Returns the internal tracker ID. This uniquely identifies the tracker per tracker type and matches the ID you need to specify for nodes such as the <see cref="Godot.ARVRController"/> and <see cref="Godot.ARVRAnchor"/> nodes.</para>
        /// </summary>
        [GodotMethod("get_tracker_id")]
        public int GetTrackerId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_name");

        /// <summary>
        /// <para>Returns the controller or anchor point's name if available.</para>
        /// </summary>
        [GodotMethod("get_name")]
        public string GetName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_joy_id");

        /// <summary>
        /// <para>If this is a controller that is being tracked, the controller will also be represented by a joystick entry with this ID.</para>
        /// </summary>
        [GodotMethod("get_joy_id")]
        public int GetJoyId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tracks_orientation");

        /// <summary>
        /// <para>Returns <c>true</c> if this device tracks orientation.</para>
        /// </summary>
        [GodotMethod("get_tracks_orientation")]
        public bool GetTracksOrientation()
        {
            return NativeCalls.godot_icall_0_7(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_orientation");

        /// <summary>
        /// <para>Returns the controller's orientation matrix.</para>
        /// </summary>
        [GodotMethod("get_orientation")]
        public Basis GetOrientation()
        {
            NativeCalls.godot_icall_0_20(method_bind_5, Object.GetPtr(this), out Basis argRet); return (Basis)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tracks_position");

        /// <summary>
        /// <para>Returns <c>true</c> if this device tracks position.</para>
        /// </summary>
        [GodotMethod("get_tracks_position")]
        public bool GetTracksPosition()
        {
            return NativeCalls.godot_icall_0_7(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_position");

        /// <summary>
        /// <para>Returns the world-space controller position.</para>
        /// </summary>
        [GodotMethod("get_position")]
        public Vector3 GetPosition()
        {
            NativeCalls.godot_icall_0_8(method_bind_7, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_hand");

        /// <summary>
        /// <para>Returns the hand holding this tracker, if known. See <see cref="Godot.ARVRPositionalTracker.TrackerHand"/> constants.</para>
        /// </summary>
        [GodotMethod("get_hand")]
        public ARVRPositionalTracker.TrackerHand GetHand()
        {
            return (ARVRPositionalTracker.TrackerHand)NativeCalls.godot_icall_0_13(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_transform");

        /// <summary>
        /// <para>Returns the transform combining this device's orientation and position.</para>
        /// </summary>
        [GodotMethod("get_transform")]
        public Transform GetTransform(bool adjustByReferenceFrame)
        {
            NativeCalls.godot_icall_1_21(method_bind_9, Object.GetPtr(this), adjustByReferenceFrame, out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mesh");

        /// <summary>
        /// <para>Returns the mesh related to a controller or anchor point if one is available.</para>
        /// </summary>
        [GodotMethod("get_mesh")]
        public Mesh GetMesh()
        {
            return NativeCalls.godot_icall_0_10(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rumble");

        [GodotMethod("get_rumble")]
        [Obsolete("GetRumble is deprecated. Use the Rumble property instead.")]
        public float GetRumble()
        {
            return NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rumble");

        [GodotMethod("set_rumble")]
        [Obsolete("SetRumble is deprecated. Use the Rumble property instead.")]
        public void SetRumble(float rumble)
        {
            NativeCalls.godot_icall_1_15(method_bind_12, Object.GetPtr(this), rumble);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
