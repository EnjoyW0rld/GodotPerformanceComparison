using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The AR/VR server is the heart of our Advanced and Virtual Reality solution and handles all the processing.</para>
    /// </summary>
    public static partial class ARVRServer
    {
        public enum RotationMode
        {
            /// <summary>
            /// <para>Fully reset the orientation of the HMD. Regardless of what direction the user is looking to in the real world. The user will look dead ahead in the virtual world.</para>
            /// </summary>
            ResetFullRotation = 0,
            /// <summary>
            /// <para>Resets the orientation but keeps the tilt of the device. So if we're looking down, we keep looking down but heading will be reset.</para>
            /// </summary>
            ResetButKeepTilt = 1,
            /// <summary>
            /// <para>Does not reset the orientation of the HMD, only the position of the player gets centered.</para>
            /// </summary>
            DontResetRotation = 2
        }

        public enum TrackerType
        {
            /// <summary>
            /// <para>The tracker tracks the location of a controller.</para>
            /// </summary>
            Controller = 1,
            /// <summary>
            /// <para>The tracker tracks the location of a base station.</para>
            /// </summary>
            Basestation = 2,
            /// <summary>
            /// <para>The tracker tracks the location and size of an AR anchor.</para>
            /// </summary>
            Anchor = 4,
            /// <summary>
            /// <para>Used internally to filter trackers of any known type.</para>
            /// </summary>
            AnyKnown = 127,
            /// <summary>
            /// <para>Used internally if we haven't set the tracker type yet.</para>
            /// </summary>
            Unknown = 128,
            /// <summary>
            /// <para>Used internally to select all trackers.</para>
            /// </summary>
            Any = 255
        }

        /// <summary>
        /// <para>Allows you to adjust the scale to your game's units. Most AR/VR platforms assume a scale of 1 game world unit = 1 real world meter.</para>
        /// </summary>
        public static float WorldScale
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

        /// <summary>
        /// <para>The primary <see cref="Godot.ARVRInterface"/> currently bound to the <see cref="Godot.ARVRServer"/>.</para>
        /// </summary>
        public static ARVRInterface PrimaryInterface
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPrimaryInterface();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPrimaryInterface(value);
            }
#pragma warning restore CS0618
        }

        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(ARVRServer).Name);
                return singleton;
            }
        }

        private const string nativeName = "ARVRServer";
        internal static IntPtr ptr = NativeCalls.godot_icall_ARVRServer_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_world_scale");

        [GodotMethod("get_world_scale")]
        [Obsolete("GetWorldScale is deprecated. Use the WorldScale property instead.")]
        public static float GetWorldScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_0, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_world_scale");

        [GodotMethod("set_world_scale")]
        [Obsolete("SetWorldScale is deprecated. Use the WorldScale property instead.")]
        public static void SetWorldScale(float worldScale)
        {
            NativeCalls.godot_icall_1_15(method_bind_1, ptr, worldScale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_reference_frame");

        /// <summary>
        /// <para>Returns the reference frame transform. Mostly used internally and exposed for GDNative build interfaces.</para>
        /// </summary>
        [GodotMethod("get_reference_frame")]
        public static Transform GetReferenceFrame()
        {
            NativeCalls.godot_icall_0_22(method_bind_2, ptr, out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "center_on_hmd");

        /// <summary>
        /// <para>This is an important function to understand correctly. AR and VR platforms all handle positioning slightly differently.</para>
        /// <para>For platforms that do not offer spatial tracking, our origin point (0,0,0) is the location of our HMD, but you have little control over the direction the player is facing in the real world.</para>
        /// <para>For platforms that do offer spatial tracking, our origin point depends very much on the system. For OpenVR, our origin point is usually the center of the tracking space, on the ground. For other platforms, it's often the location of the tracking camera.</para>
        /// <para>This method allows you to center your tracker on the location of the HMD. It will take the current location of the HMD and use that to adjust all your tracking data; in essence, realigning the real world to your player's current position in the game world.</para>
        /// <para>For this method to produce usable results, tracking information must be available. This often takes a few frames after starting your game.</para>
        /// <para>You should call this method after a few seconds have passed. For instance, when the user requests a realignment of the display holding a designated button on a controller for a short period of time, or when implementing a teleport mechanism.</para>
        /// </summary>
        [GodotMethod("center_on_hmd")]
        public static void CenterOnHmd(ARVRServer.RotationMode rotationMode, bool keepHeight)
        {
            NativeCalls.godot_icall_2_23(method_bind_3, ptr, (int)rotationMode, keepHeight);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_hmd_transform");

        /// <summary>
        /// <para>Returns the primary interface's transformation.</para>
        /// </summary>
        [GodotMethod("get_hmd_transform")]
        public static Transform GetHmdTransform()
        {
            NativeCalls.godot_icall_0_22(method_bind_4, ptr, out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_interface");

        /// <summary>
        /// <para>Registers an <see cref="Godot.ARVRInterface"/> object.</para>
        /// </summary>
        [GodotMethod("add_interface")]
        public static void AddInterface(ARVRInterface @interface)
        {
            NativeCalls.godot_icall_1_24(method_bind_5, ptr, Object.GetPtr(@interface));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_primary_interface_if");

        /// <summary>
        /// <para>Clears our current primary interface if it is set to the provided interface.</para>
        /// </summary>
        [GodotMethod("clear_primary_interface_if")]
        public static void ClearPrimaryInterfaceIf(ARVRInterface @interface)
        {
            NativeCalls.godot_icall_1_24(method_bind_6, ptr, Object.GetPtr(@interface));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_interface_count");

        /// <summary>
        /// <para>Returns the number of interfaces currently registered with the AR/VR server. If your project supports multiple AR/VR platforms, you can look through the available interface, and either present the user with a selection or simply try to initialize each interface and use the first one that returns <c>true</c>.</para>
        /// </summary>
        [GodotMethod("get_interface_count")]
        public static int GetInterfaceCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_interface");

        /// <summary>
        /// <para>Removes this interface.</para>
        /// </summary>
        [GodotMethod("remove_interface")]
        public static void RemoveInterface(ARVRInterface @interface)
        {
            NativeCalls.godot_icall_1_24(method_bind_8, ptr, Object.GetPtr(@interface));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_interface");

        /// <summary>
        /// <para>Returns the interface registered at a given index in our list of interfaces.</para>
        /// </summary>
        [GodotMethod("get_interface")]
        public static ARVRInterface GetInterface(int idx)
        {
            return NativeCalls.godot_icall_1_25(method_bind_9, ptr, idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_interfaces");

        /// <summary>
        /// <para>Returns a list of available interfaces the ID and name of each interface.</para>
        /// </summary>
        [GodotMethod("get_interfaces")]
        public static Godot.Collections.Array GetInterfaces()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_10, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "find_interface");

        /// <summary>
        /// <para>Finds an interface by its name. For instance, if your project uses capabilities of an AR/VR platform, you can find the interface for that platform by name and initialize it.</para>
        /// </summary>
        [GodotMethod("find_interface")]
        public static ARVRInterface FindInterface(string name)
        {
            return NativeCalls.godot_icall_1_27(method_bind_11, ptr, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tracker_count");

        /// <summary>
        /// <para>Returns the number of trackers currently registered.</para>
        /// </summary>
        [GodotMethod("get_tracker_count")]
        public static int GetTrackerCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_12, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tracker");

        /// <summary>
        /// <para>Returns the positional tracker at the given ID.</para>
        /// </summary>
        [GodotMethod("get_tracker")]
        public static ARVRPositionalTracker GetTracker(int idx)
        {
            return NativeCalls.godot_icall_1_28(method_bind_13, ptr, idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_tracker");

        /// <summary>
        /// <para>Registers a new <see cref="Godot.ARVRPositionalTracker"/> that tracks a spatial location in real space.</para>
        /// </summary>
        [GodotMethod("add_tracker")]
        public static void AddTracker(ARVRPositionalTracker tracker)
        {
            NativeCalls.godot_icall_1_24(method_bind_14, ptr, Object.GetPtr(tracker));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_tracker");

        /// <summary>
        /// <para>Removes this positional tracker.</para>
        /// </summary>
        [GodotMethod("remove_tracker")]
        public static void RemoveTracker(ARVRPositionalTracker tracker)
        {
            NativeCalls.godot_icall_1_24(method_bind_15, ptr, Object.GetPtr(tracker));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_primary_interface");

        [GodotMethod("get_primary_interface")]
        [Obsolete("GetPrimaryInterface is deprecated. Use the PrimaryInterface property instead.")]
        public static ARVRInterface GetPrimaryInterface()
        {
            return NativeCalls.godot_icall_0_29(method_bind_16, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_primary_interface");

        [GodotMethod("set_primary_interface")]
        [Obsolete("SetPrimaryInterface is deprecated. Use the PrimaryInterface property instead.")]
        public static void SetPrimaryInterface(ARVRInterface @interface)
        {
            NativeCalls.godot_icall_1_24(method_bind_17, ptr, Object.GetPtr(@interface));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_last_process_usec");

        /// <summary>
        /// <para>Returns the absolute timestamp (in μs) of the last <see cref="Godot.ARVRServer"/> process callback. The value comes from an internal call to <see cref="Godot.OS.GetTicksUsec"/>.</para>
        /// </summary>
        [GodotMethod("get_last_process_usec")]
        public static ulong GetLastProcessUsec()
        {
            return NativeCalls.godot_icall_0_30(method_bind_18, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_last_commit_usec");

        /// <summary>
        /// <para>Returns the absolute timestamp (in μs) of the last <see cref="Godot.ARVRServer"/> commit of the AR/VR eyes to <see cref="Godot.VisualServer"/>. The value comes from an internal call to <see cref="Godot.OS.GetTicksUsec"/>.</para>
        /// </summary>
        [GodotMethod("get_last_commit_usec")]
        public static ulong GetLastCommitUsec()
        {
            return NativeCalls.godot_icall_0_30(method_bind_19, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_last_frame_usec");

        /// <summary>
        /// <para>Returns the duration (in μs) of the last frame. This is computed as the difference between <see cref="Godot.ARVRServer.GetLastCommitUsec"/> and <see cref="Godot.ARVRServer.GetLastProcessUsec"/> when committing.</para>
        /// </summary>
        [GodotMethod("get_last_frame_usec")]
        public static ulong GetLastFrameUsec()
        {
            return NativeCalls.godot_icall_0_30(method_bind_20, ptr);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
