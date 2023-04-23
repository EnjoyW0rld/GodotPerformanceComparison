using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.MainLoop"/> is the abstract base class for a Godot project's game loop. It is inherited by <see cref="Godot.SceneTree"/>, which is the default game loop implementation used in Godot projects, though it is also possible to write and use one's own <see cref="Godot.MainLoop"/> subclass instead of the scene tree.</para>
    /// <para>Upon the application start, a <see cref="Godot.MainLoop"/> implementation must be provided to the OS; otherwise, the application will exit. This happens automatically (and a <see cref="Godot.SceneTree"/> is created) unless a main <see cref="Godot.Script"/> is provided from the command line (with e.g. <c>godot -s my_loop.gd</c>, which should then be a <see cref="Godot.MainLoop"/> implementation.</para>
    /// <para>Here is an example script implementing a simple <see cref="Godot.MainLoop"/>:</para>
    /// <para><code>
    /// extends MainLoop
    /// 
    /// var time_elapsed = 0
    /// var keys_typed = []
    /// var quit = false
    /// 
    /// func _initialize():
    ///     print("Initialized:")
    ///     print("  Starting time: %s" % str(time_elapsed))
    /// 
    /// func _idle(delta):
    ///     time_elapsed += delta
    ///     # Return true to end the main loop.
    ///     return quit
    /// 
    /// func _input_event(event):
    ///     # Record keys.
    ///     if event is InputEventKey and event.pressed and !event.echo:
    ///         keys_typed.append(OS.get_scancode_string(event.scancode))
    ///         # Quit on Escape press.
    ///         if event.scancode == KEY_ESCAPE:
    ///             quit = true
    ///     # Quit on any mouse click.
    ///     if event is InputEventMouseButton:
    ///         quit = true
    /// 
    /// func _finalize():
    ///     print("Finalized:")
    ///     print("  End time: %s" % str(time_elapsed))
    ///     print("  Keys typed: %s" % var2str(keys_typed))
    /// </code></para>
    /// </summary>
    public partial class MainLoop : Object
    {
        /// <summary>
        /// <para>Notification received from the OS when the mouse enters the game window.</para>
        /// <para>Implemented on desktop and web platforms.</para>
        /// </summary>
        public const int NotificationWmMouseEnter = 1002;
        /// <summary>
        /// <para>Notification received from the OS when the mouse leaves the game window.</para>
        /// <para>Implemented on desktop and web platforms.</para>
        /// </summary>
        public const int NotificationWmMouseExit = 1003;
        /// <summary>
        /// <para>Notification received from the OS when the game window is focused.</para>
        /// <para>Implemented on all platforms.</para>
        /// </summary>
        public const int NotificationWmFocusIn = 1004;
        /// <summary>
        /// <para>Notification received from the OS when the game window is unfocused.</para>
        /// <para>Implemented on all platforms.</para>
        /// </summary>
        public const int NotificationWmFocusOut = 1005;
        /// <summary>
        /// <para>Notification received from the OS when a quit request is sent (e.g. closing the window with a "Close" button or Alt+F4).</para>
        /// <para>Implemented on desktop platforms.</para>
        /// </summary>
        public const int NotificationWmQuitRequest = 1006;
        /// <summary>
        /// <para>Notification received from the OS when a go back request is sent (e.g. pressing the "Back" button on Android).</para>
        /// <para>Specific to the Android platform.</para>
        /// </summary>
        public const int NotificationWmGoBackRequest = 1007;
        /// <summary>
        /// <para>Notification received from the OS when an unfocus request is sent (e.g. another OS window wants to take the focus).</para>
        /// <para>No supported platforms currently send this notification.</para>
        /// </summary>
        public const int NotificationWmUnfocusRequest = 1008;
        /// <summary>
        /// <para>Notification received from the OS when the application is exceeding its allocated memory.</para>
        /// <para>Specific to the iOS platform.</para>
        /// </summary>
        public const int NotificationOsMemoryWarning = 1009;
        /// <summary>
        /// <para>Notification received when translations may have changed. Can be triggered by the user changing the locale. Can be used to respond to language changes, for example to change the UI strings on the fly. Useful when working with the built-in translation support, like <see cref="Godot.Object.Tr"/>.</para>
        /// </summary>
        public const int NotificationTranslationChanged = 1010;
        /// <summary>
        /// <para>Notification received from the OS when a request for "About" information is sent.</para>
        /// <para>Specific to the macOS platform.</para>
        /// </summary>
        public const int NotificationWmAbout = 1011;
        /// <summary>
        /// <para>Notification received from Godot's crash handler when the engine is about to crash.</para>
        /// <para>Implemented on desktop platforms if the crash handler is enabled.</para>
        /// </summary>
        public const int NotificationCrash = 1012;
        /// <summary>
        /// <para>Notification received from the OS when an update of the Input Method Engine occurs (e.g. change of IME cursor position or composition string).</para>
        /// <para>Specific to the macOS platform.</para>
        /// </summary>
        public const int NotificationOsImeUpdate = 1013;
        /// <summary>
        /// <para>Notification received from the OS when the app is resumed.</para>
        /// <para>Specific to the Android platform.</para>
        /// </summary>
        public const int NotificationAppResumed = 1014;
        /// <summary>
        /// <para>Notification received from the OS when the app is paused.</para>
        /// <para>Specific to the Android platform.</para>
        /// </summary>
        public const int NotificationAppPaused = 1015;

        private const string nativeName = "MainLoop";

        public MainLoop() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_MainLoop_Ctor(this);
        }

        internal MainLoop(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>Called when files are dragged from the OS file manager and dropped in the game window. The arguments are a list of file paths and the identifier of the screen where the drag originated.</para>
        /// </summary>
        [GodotMethod("_drop_files")]
        public virtual void _DropFiles(string[] files, int fromScreen)
        {
            return;
        }

        /// <summary>
        /// <para>Called before the program exits.</para>
        /// </summary>
        [GodotMethod("_finalize")]
        public virtual void _Finalize()
        {
            return;
        }

        /// <summary>
        /// <para>Called when the user performs an action in the system global menu (e.g. the Mac OS menu bar).</para>
        /// </summary>
        [GodotMethod("_global_menu_action")]
        public virtual void _GlobalMenuAction(object id, object meta)
        {
            return;
        }

        /// <summary>
        /// <para>Called each idle frame with the time since the last idle frame as argument (in seconds). Equivalent to <see cref="Godot.Node._Process"/>.</para>
        /// <para>If implemented, the method must return a boolean value. <c>true</c> ends the main loop, while <c>false</c> lets it proceed to the next frame.</para>
        /// </summary>
        [GodotMethod("_idle")]
        public virtual bool _Idle(float delta)
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Called once during initialization.</para>
        /// </summary>
        [GodotMethod("_initialize")]
        public virtual void _Initialize()
        {
            return;
        }

        /// <summary>
        /// <para>Called whenever an <see cref="Godot.InputEvent"/> is received by the main loop.</para>
        /// </summary>
        [GodotMethod("_input_event")]
        public virtual void _InputEvent(InputEvent @event)
        {
            return;
        }

        /// <summary>
        /// <para>Deprecated callback, does not do anything. Use <see cref="Godot.MainLoop._InputEvent"/> to parse text input. Will be removed in Godot 4.0.</para>
        /// </summary>
        [GodotMethod("_input_text")]
        public virtual void _InputText(string text)
        {
            return;
        }

        /// <summary>
        /// <para>Called each physics frame with the time since the last physics frame as argument (<c>delta</c>, in seconds). Equivalent to <see cref="Godot.Node._PhysicsProcess"/>.</para>
        /// <para>If implemented, the method must return a boolean value. <c>true</c> ends the main loop, while <c>false</c> lets it proceed to the next frame.</para>
        /// </summary>
        [GodotMethod("_iteration")]
        public virtual bool _Iteration(float delta)
        {
            return default(bool);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "input_event");

        /// <summary>
        /// <para>Should not be called manually, override <see cref="Godot.MainLoop._InputEvent"/> instead. Will be removed in Godot 4.0.</para>
        /// </summary>
        [GodotMethod("input_event")]
        public void InputEvent(InputEvent @event)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(@event));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "input_text");

        /// <summary>
        /// <para>Should not be called manually, override <see cref="Godot.MainLoop._InputText"/> instead. Will be removed in Godot 4.0.</para>
        /// </summary>
        [GodotMethod("input_text")]
        public void InputText(string text)
        {
            NativeCalls.godot_icall_1_54(method_bind_1, Object.GetPtr(this), text);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "init");

        /// <summary>
        /// <para>Should not be called manually, override <see cref="Godot.MainLoop._Initialize"/> instead. Will be removed in Godot 4.0.</para>
        /// </summary>
        [GodotMethod("init")]
        public void Init()
        {
            NativeCalls.godot_icall_0_3(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "iteration");

        /// <summary>
        /// <para>Should not be called manually, override <see cref="Godot.MainLoop._Iteration"/> instead. Will be removed in Godot 4.0.</para>
        /// </summary>
        [GodotMethod("iteration")]
        public bool Iteration(float delta)
        {
            return NativeCalls.godot_icall_1_593(method_bind_3, Object.GetPtr(this), delta);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "idle");

        /// <summary>
        /// <para>Should not be called manually, override <see cref="Godot.MainLoop._Idle"/> instead. Will be removed in Godot 4.0.</para>
        /// </summary>
        [GodotMethod("idle")]
        public bool Idle(float delta)
        {
            return NativeCalls.godot_icall_1_593(method_bind_4, Object.GetPtr(this), delta);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "finish");

        /// <summary>
        /// <para>Should not be called manually, override <see cref="Godot.MainLoop._Finalize"/> instead. Will be removed in Godot 4.0.</para>
        /// </summary>
        [GodotMethod("finish")]
        public void Finish()
        {
            NativeCalls.godot_icall_0_3(method_bind_5, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
