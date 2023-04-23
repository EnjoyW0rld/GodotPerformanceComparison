using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>WebXR is an open standard that allows creating VR and AR applications that run in the web browser.</para>
    /// <para>As such, this interface is only available when running in an HTML5 export.</para>
    /// <para>WebXR supports a wide range of devices, from the very capable (like Valve Index, HTC Vive, Oculus Rift and Quest) down to the much less capable (like Google Cardboard, Oculus Go, GearVR, or plain smartphones).</para>
    /// <para>Since WebXR is based on Javascript, it makes extensive use of callbacks, which means that <see cref="Godot.WebXRInterface"/> is forced to use signals, where other AR/VR interfaces would instead use functions that return a result immediately. This makes <see cref="Godot.WebXRInterface"/> quite a bit more complicated to initialize than other AR/VR interfaces.</para>
    /// <para>Here's the minimum code required to start an immersive VR session:</para>
    /// <para><code>
    /// extends Spatial
    /// 
    /// var webxr_interface
    /// var vr_supported = false
    /// 
    /// func _ready():
    ///     # We assume this node has a button as a child.
    ///     # This button is for the user to consent to entering immersive VR mode.
    ///     $Button.connect("pressed", self, "_on_Button_pressed")
    /// 
    ///     webxr_interface = ARVRServer.find_interface("WebXR")
    ///     if webxr_interface:
    ///         # Map to the standard button/axis ids when possible.
    ///         webxr_interface.xr_standard_mapping = true
    /// 
    ///         # WebXR uses a lot of asynchronous callbacks, so we connect to various
    ///         # signals in order to receive them.
    ///         webxr_interface.connect("session_supported", self, "_webxr_session_supported")
    ///         webxr_interface.connect("session_started", self, "_webxr_session_started")
    ///         webxr_interface.connect("session_ended", self, "_webxr_session_ended")
    ///         webxr_interface.connect("session_failed", self, "_webxr_session_failed")
    /// 
    ///         # This returns immediately - our _webxr_session_supported() method
    ///         # (which we connected to the "session_supported" signal above) will
    ///         # be called sometime later to let us know if it's supported or not.
    ///         webxr_interface.is_session_supported("immersive-vr")
    /// 
    /// func _webxr_session_supported(session_mode, supported):
    ///     if session_mode == 'immersive-vr':
    ///         vr_supported = supported
    /// 
    /// func _on_Button_pressed():
    ///     if not vr_supported:
    ///         OS.alert("Your browser doesn't support VR")
    ///         return
    /// 
    ///     # We want an immersive VR session, as opposed to AR ('immersive-ar') or a
    ///     # simple 3DoF viewer ('viewer').
    ///     webxr_interface.session_mode = 'immersive-vr'
    ///     # 'bounded-floor' is room scale, 'local-floor' is a standing or sitting
    ///     # experience (it puts you 1.6m above the ground if you have 3DoF headset),
    ///     # whereas as 'local' puts you down at the ARVROrigin.
    ///     # This list means it'll first try to request 'bounded-floor', then
    ///     # fallback on 'local-floor' and ultimately 'local', if nothing else is
    ///     # supported.
    ///     webxr_interface.requested_reference_space_types = 'bounded-floor, local-floor, local'
    ///     # In order to use 'local-floor' or 'bounded-floor' we must also
    ///     # mark the features as required or optional.
    ///     webxr_interface.required_features = 'local-floor'
    ///     webxr_interface.optional_features = 'bounded-floor'
    /// 
    ///     # This will return false if we're unable to even request the session,
    ///     # however, it can still fail asynchronously later in the process, so we
    ///     # only know if it's really succeeded or failed when our
    ///     # _webxr_session_started() or _webxr_session_failed() methods are called.
    ///     if not webxr_interface.initialize():
    ///         OS.alert("Failed to initialize")
    ///         return
    /// 
    /// func _webxr_session_started():
    ///     $Button.visible = false
    ///     # This tells Godot to start rendering to the headset.
    ///     get_viewport().arvr = true
    ///     # This will be the reference space type you ultimately got, out of the
    ///     # types that you requested above. This is useful if you want the game to
    ///     # work a little differently in 'bounded-floor' versus 'local-floor'.
    ///     print ("Reference space type: " + webxr_interface.reference_space_type)
    /// 
    /// func _webxr_session_ended():
    ///     $Button.visible = true
    ///     # If the user exits immersive mode, then we tell Godot to render to the web
    ///     # page again.
    ///     get_viewport().arvr = false
    /// 
    /// func _webxr_session_failed(message):
    ///     OS.alert("Failed to initialize: " + message)
    /// </code></para>
    /// <para>There are several ways to handle "controller" input:</para>
    /// <para>- Using <see cref="Godot.ARVRController"/> nodes and their <c>ARVRController.button_pressed</c> and <c>ARVRController.button_release</c> signals. This is how controllers are typically handled in AR/VR apps in Godot, however, this will only work with advanced VR controllers like the Oculus Touch or Index controllers, for example. The buttons codes are defined by <a href="https://immersive-web.github.io/webxr-gamepads-module/#xr-standard-gamepad-mapping">Section 3.3 of the WebXR Gamepads Module</a>.</para>
    /// <para>- Using <see cref="Godot.Node._UnhandledInput"/> and <see cref="Godot.InputEventJoypadButton"/> or <see cref="Godot.InputEventJoypadMotion"/>. This works the same as normal joypads, except the <see cref="Godot.InputEvent.Device"/> starts at 100, so the left controller is 100 and the right controller is 101, and the button codes are also defined by <a href="https://immersive-web.github.io/webxr-gamepads-module/#xr-standard-gamepad-mapping">Section 3.3 of the WebXR Gamepads Module</a>.</para>
    /// <para>- Using the <c>select</c>, <c>squeeze</c> and related signals. This method will work for both advanced VR controllers, and non-traditional "controllers" like a tap on the screen, a spoken voice command or a button press on the device itself. The <c>controller_id</c> passed to these signals is the same id as used in <see cref="Godot.ARVRController.ControllerId"/>.</para>
    /// <para>You can use one or all of these methods to allow your game or app to support a wider or narrower set of devices and input methods, or to allow more advanced interactions with more advanced devices.</para>
    /// </summary>
    public abstract partial class WebXRInterface : ARVRInterface
    {
        public enum TargetRayMode
        {
            /// <summary>
            /// <para>We don't know the target ray mode.</para>
            /// </summary>
            Unknown = 0,
            /// <summary>
            /// <para>Target ray originates at the viewer's eyes and points in the direction they are looking.</para>
            /// </summary>
            Gaze = 1,
            /// <summary>
            /// <para>Target ray from a handheld pointer, most likely a VR touch controller.</para>
            /// </summary>
            TrackedPointer = 2,
            /// <summary>
            /// <para>Target ray from touch screen, mouse or other tactile input device.</para>
            /// </summary>
            Screen = 3
        }

        /// <summary>
        /// <para>The session mode used by <see cref="Godot.ARVRInterface.Initialize"/> when setting up the WebXR session.</para>
        /// <para>This doesn't have any effect on the interface when already initialized.</para>
        /// <para>Possible values come from <a href="https://developer.mozilla.org/en-US/docs/Web/API/XRSessionMode">WebXR's XRSessionMode</a>, including: <c>"immersive-vr"</c>, <c>"immersive-ar"</c>, and <c>"inline"</c>.</para>
        /// </summary>
        public string SessionMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSessionMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSessionMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A comma-seperated list of required features used by <see cref="Godot.ARVRInterface.Initialize"/> when setting up the WebXR session.</para>
        /// <para>If a user's browser or device doesn't support one of the given features, initialization will fail and <c>session_failed</c> will be emitted.</para>
        /// <para>This doesn't have any effect on the interface when already initialized.</para>
        /// <para>Possible values come from <a href="https://developer.mozilla.org/en-US/docs/Web/API/XRReferenceSpaceType">WebXR's XRReferenceSpaceType</a>. If you want to use a particular reference space type, it must be listed in either <see cref="Godot.WebXRInterface.RequiredFeatures"/> or <see cref="Godot.WebXRInterface.OptionalFeatures"/>.</para>
        /// </summary>
        public string RequiredFeatures
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRequiredFeatures();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRequiredFeatures(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A comma-seperated list of optional features used by <see cref="Godot.ARVRInterface.Initialize"/> when setting up the WebXR session.</para>
        /// <para>If a user's browser or device doesn't support one of the given features, initialization will continue, but you won't be able to use the requested feature.</para>
        /// <para>This doesn't have any effect on the interface when already initialized.</para>
        /// <para>Possible values come from <a href="https://developer.mozilla.org/en-US/docs/Web/API/XRReferenceSpaceType">WebXR's XRReferenceSpaceType</a>. If you want to use a particular reference space type, it must be listed in either <see cref="Godot.WebXRInterface.RequiredFeatures"/> or <see cref="Godot.WebXRInterface.OptionalFeatures"/>.</para>
        /// </summary>
        public string OptionalFeatures
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOptionalFeatures();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOptionalFeatures(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A comma-seperated list of reference space types used by <see cref="Godot.ARVRInterface.Initialize"/> when setting up the WebXR session.</para>
        /// <para>The reference space types are requested in order, and the first on supported by the users device or browser will be used. The <see cref="Godot.WebXRInterface.ReferenceSpaceType"/> property contains the reference space type that was ultimately used.</para>
        /// <para>This doesn't have any effect on the interface when already initialized.</para>
        /// <para>Possible values come from <a href="https://developer.mozilla.org/en-US/docs/Web/API/XRReferenceSpaceType">WebXR's XRReferenceSpaceType</a>. If you want to use a particular reference space type, it must be listed in either <see cref="Godot.WebXRInterface.RequiredFeatures"/> or <see cref="Godot.WebXRInterface.OptionalFeatures"/>.</para>
        /// </summary>
        public string RequestedReferenceSpaceTypes
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRequestedReferenceSpaceTypes();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRequestedReferenceSpaceTypes(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The reference space type (from the list of requested types set in the <see cref="Godot.WebXRInterface.RequestedReferenceSpaceTypes"/> property), that was ultimately used by <see cref="Godot.ARVRInterface.Initialize"/> when setting up the WebXR session.</para>
        /// <para>Possible values come from <a href="https://developer.mozilla.org/en-US/docs/Web/API/XRReferenceSpaceType">WebXR's XRReferenceSpaceType</a>. If you want to use a particular reference space type, it must be listed in either <see cref="Godot.WebXRInterface.RequiredFeatures"/> or <see cref="Godot.WebXRInterface.OptionalFeatures"/>.</para>
        /// </summary>
        public string ReferenceSpaceType
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetReferenceSpaceType();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Indicates if the WebXR session's imagery is visible to the user.</para>
        /// <para>Possible values come from <a href="https://developer.mozilla.org/en-US/docs/Web/API/XRVisibilityState">WebXR's XRVisibilityState</a>, including <c>"hidden"</c>, <c>"visible"</c>, and <c>"visible-blurred"</c>.</para>
        /// </summary>
        public string VisibilityState
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVisibilityState();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The vertices of a polygon which defines the boundaries of the user's play area.</para>
        /// <para>This will only be available if <see cref="Godot.WebXRInterface.ReferenceSpaceType"/> is <c>"bounded-floor"</c> and only on certain browsers and devices that support it.</para>
        /// <para>The <c>reference_space_reset</c> signal may indicate when this changes.</para>
        /// </summary>
        public Vector3[] BoundsGeometry
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBoundsGeometry();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If set to true, the button and axes ids will be converted to match the standard ids used by other AR/VR interfaces, when possible.</para>
        /// <para>Otherwise, the ids will be passed through unaltered from WebXR.</para>
        /// </summary>
        public bool XrStandardMapping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetXrStandardMapping();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetXrStandardMapping(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "WebXRInterface";

        internal WebXRInterface() {}

        internal WebXRInterface(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_session_supported");

        /// <summary>
        /// <para>Checks if the given <c>session_mode</c> is supported by the user's browser.</para>
        /// <para>Possible values come from <a href="https://developer.mozilla.org/en-US/docs/Web/API/XRSessionMode">WebXR's XRSessionMode</a>, including: <c>"immersive-vr"</c>, <c>"immersive-ar"</c>, and <c>"inline"</c>.</para>
        /// <para>This method returns nothing, instead it emits the <c>session_supported</c> signal with the result.</para>
        /// </summary>
        [GodotMethod("is_session_supported")]
        public void IsSessionSupported(string sessionMode)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), sessionMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_session_mode");

        [GodotMethod("set_session_mode")]
        [Obsolete("SetSessionMode is deprecated. Use the SessionMode property instead.")]
        public void SetSessionMode(string sessionMode)
        {
            NativeCalls.godot_icall_1_54(method_bind_1, Object.GetPtr(this), sessionMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_session_mode");

        [GodotMethod("get_session_mode")]
        [Obsolete("GetSessionMode is deprecated. Use the SessionMode property instead.")]
        public string GetSessionMode()
        {
            return NativeCalls.godot_icall_0_6(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_required_features");

        [GodotMethod("set_required_features")]
        [Obsolete("SetRequiredFeatures is deprecated. Use the RequiredFeatures property instead.")]
        public void SetRequiredFeatures(string requiredFeatures)
        {
            NativeCalls.godot_icall_1_54(method_bind_3, Object.GetPtr(this), requiredFeatures);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_required_features");

        [GodotMethod("get_required_features")]
        [Obsolete("GetRequiredFeatures is deprecated. Use the RequiredFeatures property instead.")]
        public string GetRequiredFeatures()
        {
            return NativeCalls.godot_icall_0_6(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_optional_features");

        [GodotMethod("set_optional_features")]
        [Obsolete("SetOptionalFeatures is deprecated. Use the OptionalFeatures property instead.")]
        public void SetOptionalFeatures(string optionalFeatures)
        {
            NativeCalls.godot_icall_1_54(method_bind_5, Object.GetPtr(this), optionalFeatures);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_optional_features");

        [GodotMethod("get_optional_features")]
        [Obsolete("GetOptionalFeatures is deprecated. Use the OptionalFeatures property instead.")]
        public string GetOptionalFeatures()
        {
            return NativeCalls.godot_icall_0_6(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_reference_space_type");

        [GodotMethod("get_reference_space_type")]
        [Obsolete("GetReferenceSpaceType is deprecated. Use the ReferenceSpaceType property instead.")]
        public string GetReferenceSpaceType()
        {
            return NativeCalls.godot_icall_0_6(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_requested_reference_space_types");

        [GodotMethod("set_requested_reference_space_types")]
        [Obsolete("SetRequestedReferenceSpaceTypes is deprecated. Use the RequestedReferenceSpaceTypes property instead.")]
        public void SetRequestedReferenceSpaceTypes(string requestedReferenceSpaceTypes)
        {
            NativeCalls.godot_icall_1_54(method_bind_8, Object.GetPtr(this), requestedReferenceSpaceTypes);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_requested_reference_space_types");

        [GodotMethod("get_requested_reference_space_types")]
        [Obsolete("GetRequestedReferenceSpaceTypes is deprecated. Use the RequestedReferenceSpaceTypes property instead.")]
        public string GetRequestedReferenceSpaceTypes()
        {
            return NativeCalls.godot_icall_0_6(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_controller");

        /// <summary>
        /// <para>Gets an <see cref="Godot.ARVRPositionalTracker"/> for the given <c>controller_id</c>.</para>
        /// <para>In the context of WebXR, a "controller" can be an advanced VR controller like the Oculus Touch or Index controllers, or even a tap on the screen, a spoken voice command or a button press on the device itself. When a non-traditional controller is used, interpret the position and orientation of the <see cref="Godot.ARVRPositionalTracker"/> as a ray pointing at the object the user wishes to interact with.</para>
        /// <para>Use this method to get information about the controller that triggered one of these signals:</para>
        /// <para>- <c>selectstart</c></para>
        /// <para>- <c>select</c></para>
        /// <para>- <c>selectend</c></para>
        /// <para>- <c>squeezestart</c></para>
        /// <para>- <c>squeeze</c></para>
        /// <para>- <c>squeezestart</c></para>
        /// </summary>
        [GodotMethod("get_controller")]
        public ARVRPositionalTracker GetController(int controllerId)
        {
            return NativeCalls.godot_icall_1_28(method_bind_10, Object.GetPtr(this), controllerId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_controller_target_ray_mode");

        /// <summary>
        /// <para>Returns the target ray mode for the given <c>controller_id</c>.</para>
        /// <para>This can help interpret the input coming from that controller. See <a href="https://developer.mozilla.org/en-US/docs/Web/API/XRInputSource/targetRayMode">XRInputSource.targetRayMode</a> for more information.</para>
        /// </summary>
        [GodotMethod("get_controller_target_ray_mode")]
        public WebXRInterface.TargetRayMode GetControllerTargetRayMode(int controllerId)
        {
            return (WebXRInterface.TargetRayMode)NativeCalls.godot_icall_1_1164(method_bind_11, Object.GetPtr(this), controllerId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_visibility_state");

        [GodotMethod("get_visibility_state")]
        [Obsolete("GetVisibilityState is deprecated. Use the VisibilityState property instead.")]
        public string GetVisibilityState()
        {
            return NativeCalls.godot_icall_0_6(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bounds_geometry");

        [GodotMethod("get_bounds_geometry")]
        [Obsolete("GetBoundsGeometry is deprecated. Use the BoundsGeometry property instead.")]
        public Vector3[] GetBoundsGeometry()
        {
            return NativeCalls.godot_icall_0_230(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_xr_standard_mapping");

        [GodotMethod("set_xr_standard_mapping")]
        [Obsolete("SetXrStandardMapping is deprecated. Use the XrStandardMapping property instead.")]
        public void SetXrStandardMapping(bool arg0)
        {
            NativeCalls.godot_icall_1_16(method_bind_14, Object.GetPtr(this), arg0);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_xr_standard_mapping");

        [GodotMethod("get_xr_standard_mapping")]
        [Obsolete("GetXrStandardMapping is deprecated. Use the XrStandardMapping property instead.")]
        public bool GetXrStandardMapping()
        {
            return NativeCalls.godot_icall_0_7(method_bind_15, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
