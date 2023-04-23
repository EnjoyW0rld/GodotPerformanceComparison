using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This is a helper spatial node that is linked to the tracking of controllers. It also offers several handy passthroughs to the state of buttons and such on the controllers.</para>
    /// <para>Controllers are linked by their ID. You can create controller nodes before the controllers are available. If your game always uses two controllers (one for each hand), you can predefine the controllers with ID 1 and 2; they will become active as soon as the controllers are identified. If you expect additional controllers to be used, you should react to the signals and add ARVRController nodes to your scene.</para>
    /// <para>The position of the controller node is automatically updated by the <see cref="Godot.ARVRServer"/>. This makes this node ideal to add child nodes to visualize the controller.</para>
    /// </summary>
    public partial class ARVRController : Spatial
    {
        /// <summary>
        /// <para>The controller's ID.</para>
        /// <para>A controller ID of 0 is unbound and will always result in an inactive node. Controller ID 1 is reserved for the first controller that identifies itself as the left-hand controller and ID 2 is reserved for the first controller that identifies itself as the right-hand controller.</para>
        /// <para>For any other controller that the <see cref="Godot.ARVRServer"/> detects, we continue with controller ID 3.</para>
        /// <para>When a controller is turned off, its slot is freed. This ensures controllers will keep the same ID even when controllers with lower IDs are turned off.</para>
        /// </summary>
        public int ControllerId
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetControllerId();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetControllerId(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The degree to which the controller vibrates. Ranges from <c>0.0</c> to <c>1.0</c>. If changed, updates <see cref="Godot.ARVRPositionalTracker.Rumble"/> accordingly.</para>
        /// <para>This is a useful property to animate if you want the controller to vibrate for a limited duration.</para>
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

        private const string nativeName = "ARVRController";

        public ARVRController() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ARVRController_Ctor(this);
        }

        internal ARVRController(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_controller_id");

        [GodotMethod("set_controller_id")]
        [Obsolete("SetControllerId is deprecated. Use the ControllerId property instead.")]
        public void SetControllerId(int controllerId)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), controllerId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_controller_id");

        [GodotMethod("get_controller_id")]
        [Obsolete("GetControllerId is deprecated. Use the ControllerId property instead.")]
        public int GetControllerId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_controller_name");

        /// <summary>
        /// <para>If active, returns the name of the associated controller if provided by the AR/VR SDK used.</para>
        /// </summary>
        [GodotMethod("get_controller_name")]
        public string GetControllerName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_joystick_id");

        /// <summary>
        /// <para>Returns the ID of the joystick object bound to this. Every controller tracked by the <see cref="Godot.ARVRServer"/> that has buttons and axis will also be registered as a joystick within Godot. This means that all the normal joystick tracking and input mapping will work for buttons and axis found on the AR/VR controllers. This ID is purely offered as information so you can link up the controller with its joystick entry.</para>
        /// </summary>
        [GodotMethod("get_joystick_id")]
        public int GetJoystickId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_button_pressed");

        /// <summary>
        /// <para>Returns <c>true</c> if the button at index <c>button</c> is pressed. See <see cref="Godot.JoystickList"/>, in particular the <c>JOY_VR_*</c> constants.</para>
        /// </summary>
        [GodotMethod("is_button_pressed")]
        public int IsButtonPressed(int button)
        {
            return NativeCalls.godot_icall_1_11(method_bind_4, Object.GetPtr(this), button);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_joystick_axis");

        /// <summary>
        /// <para>Returns the value of the given axis for things like triggers, touchpads, etc. that are embedded into the controller.</para>
        /// </summary>
        [GodotMethod("get_joystick_axis")]
        public float GetJoystickAxis(int axis)
        {
            return NativeCalls.godot_icall_1_12(method_bind_5, Object.GetPtr(this), axis);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_is_active");

        /// <summary>
        /// <para>Returns <c>true</c> if the bound controller is active. ARVR systems attempt to track active controllers.</para>
        /// </summary>
        [GodotMethod("get_is_active")]
        public bool GetIsActive()
        {
            return NativeCalls.godot_icall_0_7(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_hand");

        /// <summary>
        /// <para>Returns the hand holding this controller, if known. See <see cref="Godot.ARVRPositionalTracker.TrackerHand"/>.</para>
        /// </summary>
        [GodotMethod("get_hand")]
        public ARVRPositionalTracker.TrackerHand GetHand()
        {
            return (ARVRPositionalTracker.TrackerHand)NativeCalls.godot_icall_0_13(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rumble");

        [GodotMethod("get_rumble")]
        [Obsolete("GetRumble is deprecated. Use the Rumble property instead.")]
        public float GetRumble()
        {
            return NativeCalls.godot_icall_0_14(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rumble");

        [GodotMethod("set_rumble")]
        [Obsolete("SetRumble is deprecated. Use the Rumble property instead.")]
        public void SetRumble(float rumble)
        {
            NativeCalls.godot_icall_1_15(method_bind_9, Object.GetPtr(this), rumble);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mesh");

        /// <summary>
        /// <para>If provided by the <see cref="Godot.ARVRInterface"/>, this returns a mesh associated with the controller. This can be used to visualize the controller.</para>
        /// </summary>
        [GodotMethod("get_mesh")]
        public Mesh GetMesh()
        {
            return NativeCalls.godot_icall_0_10(method_bind_10, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
