using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This class needs to be implemented to make an AR or VR platform available to Godot and these should be implemented as C++ modules or GDNative modules (note that for GDNative the subclass ARVRScriptInterface should be used). Part of the interface is exposed to GDScript so you can detect, enable and configure an AR or VR platform.</para>
    /// <para>Interfaces should be written in such a way that simply enabling them will give us a working setup. You can query the available interfaces through <see cref="Godot.ARVRServer"/>.</para>
    /// </summary>
    public abstract partial class ARVRInterface : Reference
    {
        public enum Tracking_status
        {
            /// <summary>
            /// <para>Tracking is behaving as expected.</para>
            /// </summary>
            NormalTracking = 0,
            /// <summary>
            /// <para>Tracking is hindered by excessive motion (the player is moving faster than tracking can keep up).</para>
            /// </summary>
            ExcessiveMotion = 1,
            /// <summary>
            /// <para>Tracking is hindered by insufficient features, it's too dark (for camera-based tracking), player is blocked, etc.</para>
            /// </summary>
            InsufficientFeatures = 2,
            /// <summary>
            /// <para>We don't know the status of the tracking or this interface does not provide feedback.</para>
            /// </summary>
            UnknownTracking = 3,
            /// <summary>
            /// <para>Tracking is not functional (camera not plugged in or obscured, lighthouses turned off, etc.).</para>
            /// </summary>
            NotTracking = 4
        }

        public enum Eyes
        {
            /// <summary>
            /// <para>Mono output, this is mostly used internally when retrieving positioning information for our camera node or when stereo scopic rendering is not supported.</para>
            /// </summary>
            Mono = 0,
            /// <summary>
            /// <para>Left eye output, this is mostly used internally when rendering the image for the left eye and obtaining positioning and projection information.</para>
            /// </summary>
            Left = 1,
            /// <summary>
            /// <para>Right eye output, this is mostly used internally when rendering the image for the right eye and obtaining positioning and projection information.</para>
            /// </summary>
            Right = 2
        }

        public enum Capabilities
        {
            /// <summary>
            /// <para>No ARVR capabilities.</para>
            /// </summary>
            None = 0,
            /// <summary>
            /// <para>This interface can work with normal rendering output (non-HMD based AR).</para>
            /// </summary>
            Mono = 1,
            /// <summary>
            /// <para>This interface supports stereoscopic rendering.</para>
            /// </summary>
            Stereo = 2,
            /// <summary>
            /// <para>This interface supports AR (video background and real world tracking).</para>
            /// </summary>
            Ar = 4,
            /// <summary>
            /// <para>This interface outputs to an external device. If the main viewport is used, the on screen output is an unmodified buffer of either the left or right eye (stretched if the viewport size is not changed to the same aspect ratio of <see cref="Godot.ARVRInterface.GetRenderTargetsize"/>). Using a separate viewport node frees up the main viewport for other purposes.</para>
            /// </summary>
            External = 8
        }

        /// <summary>
        /// <para><c>true</c> if this is the primary interface.</para>
        /// </summary>
        public bool InterfaceIsPrimary
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsPrimary();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetIsPrimary(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para><c>true</c> if this interface been initialized.</para>
        /// </summary>
        public bool InterfaceIsInitialized
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInitialized();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetIsInitialized(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>On an AR interface, <c>true</c> if anchor detection is enabled.</para>
        /// </summary>
        public bool ArIsAnchorDetectionEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAnchorDetectionIsEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAnchorDetectionIsEnabled(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ARVRInterface";

        internal ARVRInterface() {}

        internal ARVRInterface(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_name");

        /// <summary>
        /// <para>Returns the name of this interface (OpenVR, OpenHMD, ARKit, etc).</para>
        /// </summary>
        [GodotMethod("get_name")]
        public string GetName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_capabilities");

        /// <summary>
        /// <para>Returns a combination of <see cref="Godot.ARVRInterface.Capabilities"/> flags providing information about the capabilities of this interface.</para>
        /// </summary>
        [GodotMethod("get_capabilities")]
        public int GetCapabilities()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_primary");

        [GodotMethod("is_primary")]
        [Obsolete("IsPrimary is deprecated. Use the InterfaceIsPrimary property instead.")]
        public bool IsPrimary()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_is_primary");

        [GodotMethod("set_is_primary")]
        [Obsolete("SetIsPrimary is deprecated. Use the InterfaceIsPrimary property instead.")]
        public void SetIsPrimary(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_3, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_initialized");

        [GodotMethod("is_initialized")]
        [Obsolete("IsInitialized is deprecated. Use the InterfaceIsInitialized property instead.")]
        public bool IsInitialized()
        {
            return NativeCalls.godot_icall_0_7(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_is_initialized");

        [GodotMethod("set_is_initialized")]
        [Obsolete("SetIsInitialized is deprecated. Use the InterfaceIsInitialized property instead.")]
        public void SetIsInitialized(bool initialized)
        {
            NativeCalls.godot_icall_1_16(method_bind_5, Object.GetPtr(this), initialized);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "initialize");

        /// <summary>
        /// <para>Call this to initialize this interface. The first interface that is initialized is identified as the primary interface and it will be used for rendering output.</para>
        /// <para>After initializing the interface you want to use you then need to enable the AR/VR mode of a viewport and rendering should commence.</para>
        /// <para>Note: You must enable the AR/VR mode on the main viewport for any device that uses the main output of Godot, such as for mobile VR.</para>
        /// <para>If you do this for a platform that handles its own output (such as OpenVR) Godot will show just one eye without distortion on screen. Alternatively, you can add a separate viewport node to your scene and enable AR/VR on that viewport. It will be used to output to the HMD, leaving you free to do anything you like in the main window, such as using a separate camera as a spectator camera or rendering something completely different.</para>
        /// <para>While currently not used, you can activate additional interfaces. You may wish to do this if you want to track controllers from other platforms. However, at this point in time only one interface can render to an HMD.</para>
        /// </summary>
        [GodotMethod("initialize")]
        public bool Initialize()
        {
            return NativeCalls.godot_icall_0_7(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "uninitialize");

        /// <summary>
        /// <para>Turns the interface off.</para>
        /// </summary>
        [GodotMethod("uninitialize")]
        public void Uninitialize()
        {
            NativeCalls.godot_icall_0_3(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tracking_status");

        /// <summary>
        /// <para>If supported, returns the status of our tracking. This will allow you to provide feedback to the user whether there are issues with positional tracking.</para>
        /// </summary>
        [GodotMethod("get_tracking_status")]
        public ARVRInterface.Tracking_status GetTrackingStatus()
        {
            return (ARVRInterface.Tracking_status)NativeCalls.godot_icall_0_17(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_render_targetsize");

        /// <summary>
        /// <para>Returns the resolution at which we should render our intermediate results before things like lens distortion are applied by the VR platform.</para>
        /// </summary>
        [GodotMethod("get_render_targetsize")]
        public Vector2 GetRenderTargetsize()
        {
            NativeCalls.godot_icall_0_18(method_bind_9, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_stereo");

        /// <summary>
        /// <para>Returns <c>true</c> if the current output of this interface is in stereo.</para>
        /// </summary>
        [GodotMethod("is_stereo")]
        public bool IsStereo()
        {
            return NativeCalls.godot_icall_0_7(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_anchor_detection_is_enabled");

        [GodotMethod("get_anchor_detection_is_enabled")]
        [Obsolete("GetAnchorDetectionIsEnabled is deprecated. Use the ArIsAnchorDetectionEnabled property instead.")]
        public bool GetAnchorDetectionIsEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_anchor_detection_is_enabled");

        [GodotMethod("set_anchor_detection_is_enabled")]
        [Obsolete("SetAnchorDetectionIsEnabled is deprecated. Use the ArIsAnchorDetectionEnabled property instead.")]
        public void SetAnchorDetectionIsEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_12, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_camera_feed_id");

        /// <summary>
        /// <para>If this is an AR interface that requires displaying a camera feed as the background, this method returns the feed ID in the <see cref="Godot.CameraServer"/> for this interface.</para>
        /// </summary>
        [GodotMethod("get_camera_feed_id")]
        public int GetCameraFeedId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_13, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
