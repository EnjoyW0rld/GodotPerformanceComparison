using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Operating System functions. OS wraps the most common functionality to communicate with the host operating system, such as the clipboard, video driver, date and time, timers, environment variables, execution of binaries, command line, etc.</para>
    /// </summary>
    public static partial class OS
    {
        public enum VideoDriver
        {
            /// <summary>
            /// <para>The GLES2 rendering backend. It uses OpenGL ES 2.0 on mobile devices, OpenGL 2.1 on desktop platforms and WebGL 1.0 on the web.</para>
            /// </summary>
            Gles2 = 1,
            /// <summary>
            /// <para>The GLES3 rendering backend. It uses OpenGL ES 3.0 on mobile devices, OpenGL 3.3 on desktop platforms and WebGL 2.0 on the web.</para>
            /// </summary>
            Gles3 = 0
        }

        public enum SystemDir
        {
            /// <summary>
            /// <para>Desktop directory path.</para>
            /// </summary>
            Desktop = 0,
            /// <summary>
            /// <para>DCIM (Digital Camera Images) directory path.</para>
            /// </summary>
            Dcim = 1,
            /// <summary>
            /// <para>Documents directory path.</para>
            /// </summary>
            Documents = 2,
            /// <summary>
            /// <para>Downloads directory path.</para>
            /// </summary>
            Downloads = 3,
            /// <summary>
            /// <para>Movies directory path.</para>
            /// </summary>
            Movies = 4,
            /// <summary>
            /// <para>Music directory path.</para>
            /// </summary>
            Music = 5,
            /// <summary>
            /// <para>Pictures directory path.</para>
            /// </summary>
            Pictures = 6,
            /// <summary>
            /// <para>Ringtones directory path.</para>
            /// </summary>
            Ringtones = 7
        }

        public enum ScreenOrientationEnum
        {
            /// <summary>
            /// <para>Landscape screen orientation.</para>
            /// </summary>
            Landscape = 0,
            /// <summary>
            /// <para>Portrait screen orientation.</para>
            /// </summary>
            Portrait = 1,
            /// <summary>
            /// <para>Reverse landscape screen orientation.</para>
            /// </summary>
            ReverseLandscape = 2,
            /// <summary>
            /// <para>Reverse portrait screen orientation.</para>
            /// </summary>
            ReversePortrait = 3,
            /// <summary>
            /// <para>Uses landscape or reverse landscape based on the hardware sensor.</para>
            /// </summary>
            SensorLandscape = 4,
            /// <summary>
            /// <para>Uses portrait or reverse portrait based on the hardware sensor.</para>
            /// </summary>
            SensorPortrait = 5,
            /// <summary>
            /// <para>Uses most suitable orientation based on the hardware sensor.</para>
            /// </summary>
            Sensor = 6
        }

        public enum PowerState
        {
            /// <summary>
            /// <para>Unknown powerstate.</para>
            /// </summary>
            Unknown = 0,
            /// <summary>
            /// <para>Unplugged, running on battery.</para>
            /// </summary>
            OnBattery = 1,
            /// <summary>
            /// <para>Plugged in, no battery available.</para>
            /// </summary>
            NoBattery = 2,
            /// <summary>
            /// <para>Plugged in, battery charging.</para>
            /// </summary>
            Charging = 3,
            /// <summary>
            /// <para>Plugged in, battery fully charged.</para>
            /// </summary>
            Charged = 4
        }

        public enum HandleType
        {
            /// <summary>
            /// <para>Application handle:</para>
            /// <para>- Windows: <c>HINSTANCE</c> of the application</para>
            /// <para>- MacOS: <c>NSApplication*</c> of the application (not yet implemented)</para>
            /// <para>- Android: <c>JNIEnv*</c> of the application (not yet implemented)</para>
            /// </summary>
            ApplicationHandle = 0,
            /// <summary>
            /// <para>Display handle:</para>
            /// <para>- Linux: <c>X11::Display*</c> for the display</para>
            /// </summary>
            DisplayHandle = 1,
            /// <summary>
            /// <para>Window handle:</para>
            /// <para>- Windows: <c>HWND</c> of the main window</para>
            /// <para>- Linux: <c>X11::Window*</c> of the main window</para>
            /// <para>- MacOS: <c>NSWindow*</c> of the main window (not yet implemented)</para>
            /// <para>- Android: <c>jObject</c> the main android activity (not yet implemented)</para>
            /// </summary>
            WindowHandle = 2,
            /// <summary>
            /// <para>Window view:</para>
            /// <para>- Windows: <c>HDC</c> of the main window drawing context</para>
            /// <para>- MacOS: <c>NSView*</c> of the main windows view (not yet implemented)</para>
            /// </summary>
            WindowView = 3,
            /// <summary>
            /// <para>OpenGL Context:</para>
            /// <para>- Windows: <c>HGLRC</c></para>
            /// <para>- Linux: <c>X11::GLXContext</c></para>
            /// <para>- MacOS: <c>NSOpenGLContext*</c> (not yet implemented)</para>
            /// </summary>
            OpenglContext = 4
        }

        public enum Month
        {
            /// <summary>
            /// <para>January.</para>
            /// </summary>
            January = 1,
            /// <summary>
            /// <para>February.</para>
            /// </summary>
            February = 2,
            /// <summary>
            /// <para>March.</para>
            /// </summary>
            March = 3,
            /// <summary>
            /// <para>April.</para>
            /// </summary>
            April = 4,
            /// <summary>
            /// <para>May.</para>
            /// </summary>
            May = 5,
            /// <summary>
            /// <para>June.</para>
            /// </summary>
            June = 6,
            /// <summary>
            /// <para>July.</para>
            /// </summary>
            July = 7,
            /// <summary>
            /// <para>August.</para>
            /// </summary>
            August = 8,
            /// <summary>
            /// <para>September.</para>
            /// </summary>
            September = 9,
            /// <summary>
            /// <para>October.</para>
            /// </summary>
            October = 10,
            /// <summary>
            /// <para>November.</para>
            /// </summary>
            November = 11,
            /// <summary>
            /// <para>December.</para>
            /// </summary>
            December = 12
        }

        public enum Weekday
        {
            /// <summary>
            /// <para>Sunday.</para>
            /// </summary>
            Sunday = 0,
            /// <summary>
            /// <para>Monday.</para>
            /// </summary>
            Monday = 1,
            /// <summary>
            /// <para>Tuesday.</para>
            /// </summary>
            Tuesday = 2,
            /// <summary>
            /// <para>Wednesday.</para>
            /// </summary>
            Wednesday = 3,
            /// <summary>
            /// <para>Thursday.</para>
            /// </summary>
            Thursday = 4,
            /// <summary>
            /// <para>Friday.</para>
            /// </summary>
            Friday = 5,
            /// <summary>
            /// <para>Saturday.</para>
            /// </summary>
            Saturday = 6
        }

        /// <summary>
        /// <para>The current tablet driver in use.</para>
        /// </summary>
        public static string TabletDriver
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCurrentTabletDriver();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCurrentTabletDriver(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The clipboard from the host OS. Might be unavailable on some platforms.</para>
        /// </summary>
        public static string Clipboard
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetClipboard();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetClipboard(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The current screen index (starting from 0).</para>
        /// </summary>
        public static int CurrentScreen
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCurrentScreen();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCurrentScreen(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The exit code passed to the OS when the main loop exits. By convention, an exit code of <c>0</c> indicates success whereas a non-zero exit code indicates an error. For portability reasons, the exit code should be set between 0 and 125 (inclusive).</para>
        /// <para>Note: This value will be ignored if using <see cref="Godot.SceneTree.Quit"/> with an <c>exit_code</c> argument passed.</para>
        /// </summary>
        public static int ExitCode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetExitCode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExitCode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, vertical synchronization (Vsync) is enabled.</para>
        /// </summary>
        public static bool VsyncEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsVsyncEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseVsync(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c> and <c>vsync_enabled</c> is true, the operating system's window compositor will be used for vsync when the compositor is enabled and the game is in windowed mode.</para>
        /// <para>Note: This option is experimental and meant to alleviate stutter experienced by some users. However, some users have experienced a Vsync framerate halving (e.g. from 60 FPS to 30 FPS) when using it.</para>
        /// <para>Note: This property is only implemented on Windows.</para>
        /// </summary>
        public static bool VsyncViaCompositor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsVsyncViaCompositorEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVsyncViaCompositor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the engine filters the time delta measured between each frame, and attempts to compensate for random variation. This will only operate on systems where V-Sync is active.</para>
        /// </summary>
        public static bool DeltaSmoothing
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDeltaSmoothingEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDeltaSmoothing(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the engine optimizes for low processor usage by only refreshing the screen if needed. Can improve battery consumption on mobile.</para>
        /// </summary>
        public static bool LowProcessorUsageMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInLowProcessorUsageMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLowProcessorUsageMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of sleeping between frames when the low-processor usage mode is enabled (in microseconds). Higher values will result in lower CPU usage.</para>
        /// </summary>
        public static int LowProcessorUsageModeSleepUsec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLowProcessorUsageModeSleepUsec();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLowProcessorUsageModeSleepUsec(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the engine tries to keep the screen on while the game is running. Useful on mobile.</para>
        /// </summary>
        public static bool KeepScreenOn
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsKeepScreenOn();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetKeepScreenOn(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The minimum size of the window in pixels (without counting window manager decorations). Does not affect fullscreen mode. Set to <c>(0, 0)</c> to reset to the system's default value.</para>
        /// <para>Note: By default, the project window has a minimum size of <c>Vector2(64, 64)</c>. This prevents issues that can arise when the window is resized to a near-zero size.</para>
        /// </summary>
        public static Vector2 MinWindowSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMinWindowSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMinWindowSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The maximum size of the window (without counting window manager decorations). Does not affect fullscreen mode. Set to <c>(0, 0)</c> to reset to the system default value.</para>
        /// </summary>
        public static Vector2 MaxWindowSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaxWindowSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaxWindowSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The current screen orientation.</para>
        /// </summary>
        public static OS.ScreenOrientationEnum ScreenOrientation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetScreenOrientation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetScreenOrientation(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, removes the window frame.</para>
        /// <para>Note: Setting <c>window_borderless</c> to <c>false</c> disables per-pixel transparency.</para>
        /// </summary>
        public static bool WindowBorderless
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBorderlessWindow();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBorderlessWindow(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the window background is transparent and the window frame is removed.</para>
        /// <para>Use <c>get_tree().get_root().set_transparent_background(true)</c> to disable main viewport background rendering.</para>
        /// <para>Note: This property has no effect if  setting is disabled.</para>
        /// <para>Note: This property is implemented on HTML5, Linux, macOS, Windows, and Android. It can't be changed at runtime for Android. Use  to set it at startup instead.</para>
        /// </summary>
        public static bool WindowPerPixelTransparencyEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetWindowPerPixelTransparencyEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetWindowPerPixelTransparencyEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the window is fullscreen.</para>
        /// </summary>
        public static bool WindowFullscreen
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsWindowFullscreen();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetWindowFullscreen(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the window is maximized.</para>
        /// </summary>
        public static bool WindowMaximized
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsWindowMaximized();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetWindowMaximized(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the window is minimized.</para>
        /// </summary>
        public static bool WindowMinimized
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsWindowMinimized();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetWindowMinimized(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the window is resizable by the user.</para>
        /// </summary>
        public static bool WindowResizable
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsWindowResizable();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetWindowResizable(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The window position relative to the screen, the origin is the top left corner, +Y axis goes to the bottom and +X axis goes to the right.</para>
        /// </summary>
        public static Vector2 WindowPosition
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetWindowPosition();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetWindowPosition(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The size of the window (without counting window manager decorations).</para>
        /// </summary>
        public static Vector2 WindowSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetWindowSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetWindowSize(value);
            }
#pragma warning restore CS0618
        }

        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(OS).Name);
                return singleton;
            }
        }

        private const string nativeName = "_OS";
        internal static IntPtr ptr = NativeCalls.godot_icall__OS_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_clipboard");

        [GodotMethod("set_clipboard")]
        [Obsolete("SetClipboard is deprecated. Use the Clipboard property instead.")]
        public static void SetClipboard(string clipboard)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, ptr, clipboard);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_clipboard");

        [GodotMethod("get_clipboard")]
        [Obsolete("GetClipboard is deprecated. Use the Clipboard property instead.")]
        public static string GetClipboard()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_clipboard");

        /// <summary>
        /// <para>Returns <c>true</c> if there is content on the clipboard.</para>
        /// </summary>
        [GodotMethod("has_clipboard")]
        public static bool HasClipboard()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "global_menu_add_item");

        /// <summary>
        /// <para>Add a new item with text "label" to global menu. Use "_dock" menu to add item to the macOS dock icon menu.</para>
        /// <para>Note: This method is implemented on macOS.</para>
        /// </summary>
        [GodotMethod("global_menu_add_item")]
        public static void GlobalMenuAddItem(string menu, string label, object id, object meta)
        {
            NativeCalls.godot_icall_4_1212(method_bind_3, ptr, menu, label, id, meta);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "global_menu_add_separator");

        /// <summary>
        /// <para>Add a separator between items. Separators also occupy an index.</para>
        /// <para>Note: This method is implemented on macOS.</para>
        /// </summary>
        [GodotMethod("global_menu_add_separator")]
        public static void GlobalMenuAddSeparator(string menu)
        {
            NativeCalls.godot_icall_1_54(method_bind_4, ptr, menu);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "global_menu_remove_item");

        /// <summary>
        /// <para>Removes the item at index "idx" from the global menu. Note that the indexes of items after the removed item are going to be shifted by one.</para>
        /// <para>Note: This method is implemented on macOS.</para>
        /// </summary>
        [GodotMethod("global_menu_remove_item")]
        public static void GlobalMenuRemoveItem(string menu, int idx)
        {
            NativeCalls.godot_icall_2_110(method_bind_5, ptr, menu, idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "global_menu_clear");

        /// <summary>
        /// <para>Clear the global menu, in effect removing all items.</para>
        /// <para>Note: This method is implemented on macOS.</para>
        /// </summary>
        [GodotMethod("global_menu_clear")]
        public static void GlobalMenuClear(string menu)
        {
            NativeCalls.godot_icall_1_54(method_bind_6, ptr, menu);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_video_driver_count");

        /// <summary>
        /// <para>Returns the number of video drivers supported on the current platform.</para>
        /// </summary>
        [GodotMethod("get_video_driver_count")]
        public static int GetVideoDriverCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_video_driver_name");

        /// <summary>
        /// <para>Returns the name of the video driver matching the given <c>driver</c> index. This index is a value from <see cref="Godot.OS.VideoDriver"/>, and you can use <see cref="Godot.OS.GetCurrentVideoDriver"/> to get the current backend's index.</para>
        /// </summary>
        [GodotMethod("get_video_driver_name")]
        public static string GetVideoDriverName(OS.VideoDriver driver)
        {
            return NativeCalls.godot_icall_1_89(method_bind_8, ptr, (int)driver);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_video_driver");

        /// <summary>
        /// <para>Returns the currently used video driver, using one of the values from <see cref="Godot.OS.VideoDriver"/>.</para>
        /// </summary>
        [GodotMethod("get_current_video_driver")]
        public static OS.VideoDriver GetCurrentVideoDriver()
        {
            return (OS.VideoDriver)NativeCalls.godot_icall_0_1213(method_bind_9, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_audio_driver_count");

        /// <summary>
        /// <para>Returns the total number of available audio drivers.</para>
        /// </summary>
        [GodotMethod("get_audio_driver_count")]
        public static int GetAudioDriverCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_10, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_audio_driver_name");

        /// <summary>
        /// <para>Returns the audio driver name for the given index.</para>
        /// </summary>
        [GodotMethod("get_audio_driver_name")]
        public static string GetAudioDriverName(int driver)
        {
            return NativeCalls.godot_icall_1_89(method_bind_11, ptr, driver);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connected_midi_inputs");

        /// <summary>
        /// <para>Returns an array of MIDI device names.</para>
        /// <para>The returned array will be empty if the system MIDI driver has not previously been initialised with <see cref="Godot.OS.OpenMidiInputs"/>.</para>
        /// <para>Note: This method is implemented on Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("get_connected_midi_inputs")]
        public static string[] GetConnectedMidiInputs()
        {
            return NativeCalls.godot_icall_0_119(method_bind_12, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "open_midi_inputs");

        /// <summary>
        /// <para>Initialises the singleton for the system MIDI driver.</para>
        /// <para>Note: This method is implemented on Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("open_midi_inputs")]
        public static void OpenMidiInputs()
        {
            NativeCalls.godot_icall_0_3(method_bind_13, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "close_midi_inputs");

        /// <summary>
        /// <para>Shuts down system MIDI driver.</para>
        /// <para>Note: This method is implemented on Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("close_midi_inputs")]
        public static void CloseMidiInputs()
        {
            NativeCalls.godot_icall_0_3(method_bind_14, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_screen_count");

        /// <summary>
        /// <para>Returns the number of displays attached to the host machine.</para>
        /// </summary>
        [GodotMethod("get_screen_count")]
        public static int GetScreenCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_15, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_screen");

        [GodotMethod("get_current_screen")]
        [Obsolete("GetCurrentScreen is deprecated. Use the CurrentScreen property instead.")]
        public static int GetCurrentScreen()
        {
            return NativeCalls.godot_icall_0_5(method_bind_16, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_current_screen");

        [GodotMethod("set_current_screen")]
        [Obsolete("SetCurrentScreen is deprecated. Use the CurrentScreen property instead.")]
        public static void SetCurrentScreen(int screen)
        {
            NativeCalls.godot_icall_1_4(method_bind_17, ptr, screen);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_screen_position");

        /// <summary>
        /// <para>Returns the position of the specified screen by index. If <c>screen</c> is <c>-1</c> (the default value), the current screen will be used.</para>
        /// </summary>
        [GodotMethod("get_screen_position")]
        public static Vector2 GetScreenPosition(int screen = -1)
        {
            NativeCalls.godot_icall_1_44(method_bind_18, ptr, screen, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_screen_size");

        /// <summary>
        /// <para>Returns the dimensions in pixels of the specified screen. If <c>screen</c> is <c>-1</c> (the default value), the current screen will be used.</para>
        /// </summary>
        [GodotMethod("get_screen_size")]
        public static Vector2 GetScreenSize(int screen = -1)
        {
            NativeCalls.godot_icall_1_44(method_bind_19, ptr, screen, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_screen_dpi");

        /// <summary>
        /// <para>Returns the dots per inch density of the specified screen. If <c>screen</c> is <c>-1</c> (the default value), the current screen will be used.</para>
        /// <para>Note: On macOS, returned value is inaccurate if fractional display scaling mode is used.</para>
        /// <para>Note: On Android devices, the actual screen densities are grouped into six generalized densities:</para>
        /// <para><code>
        ///    ldpi - 120 dpi
        ///    mdpi - 160 dpi
        ///    hdpi - 240 dpi
        ///   xhdpi - 320 dpi
        ///  xxhdpi - 480 dpi
        /// xxxhdpi - 640 dpi
        /// </code></para>
        /// <para>Note: This method is implemented on Android, Linux, macOS and Windows. Returns <c>72</c> on unsupported platforms.</para>
        /// </summary>
        [GodotMethod("get_screen_dpi")]
        public static int GetScreenDpi(int screen = -1)
        {
            return NativeCalls.godot_icall_1_11(method_bind_20, ptr, screen);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_screen_scale");

        /// <summary>
        /// <para>Return the scale factor of the specified screen by index. If <c>screen</c> is <c>-1</c> (the default value), the current screen will be used.</para>
        /// <para>Note: On macOS returned value is <c>2.0</c> for hiDPI (Retina) screen, and <c>1.0</c> for all other cases.</para>
        /// <para>Note: This method is implemented on macOS.</para>
        /// </summary>
        [GodotMethod("get_screen_scale")]
        public static float GetScreenScale(int screen = -1)
        {
            return NativeCalls.godot_icall_1_12(method_bind_21, ptr, screen);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_screen_max_scale");

        /// <summary>
        /// <para>Return the greatest scale factor of all screens.</para>
        /// <para>Note: On macOS returned value is <c>2.0</c> if there is at least one hiDPI (Retina) screen in the system, and <c>1.0</c> in all other cases.</para>
        /// <para>Note: This method is implemented on macOS.</para>
        /// </summary>
        [GodotMethod("get_screen_max_scale")]
        public static float GetScreenMaxScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_22, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_screen_refresh_rate");

        /// <summary>
        /// <para>Returns the current refresh rate of the specified screen. If <c>screen</c> is <c>-1</c> (the default value), the current screen will be used.</para>
        /// <para>Note: Returns <c>-1.0</c> if Godot fails to find the refresh rate for the specified screen. On HTML5, <see cref="Godot.OS.GetScreenRefreshRate"/> will always return <c>-1.0</c> as there is no way to retrieve the refresh rate on that platform.</para>
        /// <para>To fallback to a default refresh rate if the method fails, try:</para>
        /// <para><code>
        /// var refresh_rate = OS.get_screen_refresh_rate()
        /// if refresh_rate &lt; 0:
        ///     refresh_rate = 60.0
        /// </code></para>
        /// </summary>
        [GodotMethod("get_screen_refresh_rate")]
        public static float GetScreenRefreshRate(int screen = -1)
        {
            return NativeCalls.godot_icall_1_12(method_bind_23, ptr, screen);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_window_position");

        [GodotMethod("get_window_position")]
        [Obsolete("GetWindowPosition is deprecated. Use the WindowPosition property instead.")]
        public static Vector2 GetWindowPosition()
        {
            NativeCalls.godot_icall_0_18(method_bind_24, ptr, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_window_position");

        [GodotMethod("set_window_position")]
        [Obsolete("SetWindowPosition is deprecated. Use the WindowPosition property instead.")]
        public static void SetWindowPosition(Vector2 position)
        {
            NativeCalls.godot_icall_1_57(method_bind_25, ptr, ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_window_size");

        [GodotMethod("get_window_size")]
        [Obsolete("GetWindowSize is deprecated. Use the WindowSize property instead.")]
        public static Vector2 GetWindowSize()
        {
            NativeCalls.godot_icall_0_18(method_bind_26, ptr, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max_window_size");

        [GodotMethod("get_max_window_size")]
        [Obsolete("GetMaxWindowSize is deprecated. Use the MaxWindowSize property instead.")]
        public static Vector2 GetMaxWindowSize()
        {
            NativeCalls.godot_icall_0_18(method_bind_27, ptr, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_min_window_size");

        [GodotMethod("get_min_window_size")]
        [Obsolete("GetMinWindowSize is deprecated. Use the MinWindowSize property instead.")]
        public static Vector2 GetMinWindowSize()
        {
            NativeCalls.godot_icall_0_18(method_bind_28, ptr, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max_window_size");

        [GodotMethod("set_max_window_size")]
        [Obsolete("SetMaxWindowSize is deprecated. Use the MaxWindowSize property instead.")]
        public static void SetMaxWindowSize(Vector2 size)
        {
            NativeCalls.godot_icall_1_57(method_bind_29, ptr, ref size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_min_window_size");

        [GodotMethod("set_min_window_size")]
        [Obsolete("SetMinWindowSize is deprecated. Use the MinWindowSize property instead.")]
        public static void SetMinWindowSize(Vector2 size)
        {
            NativeCalls.godot_icall_1_57(method_bind_30, ptr, ref size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_window_size");

        [GodotMethod("set_window_size")]
        [Obsolete("SetWindowSize is deprecated. Use the WindowSize property instead.")]
        public static void SetWindowSize(Vector2 size)
        {
            NativeCalls.godot_icall_1_57(method_bind_31, ptr, ref size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_window_safe_area");

        /// <summary>
        /// <para>Returns unobscured area of the window where interactive controls should be rendered.</para>
        /// </summary>
        [GodotMethod("get_window_safe_area")]
        public static Rect2 GetWindowSafeArea()
        {
            NativeCalls.godot_icall_0_163(method_bind_32, ptr, out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_display_cutouts");

        /// <summary>
        /// <para>Returns an <see cref="Godot.Collections.Array"/> of <see cref="Godot.Rect2"/>, each of which is the bounding rectangle for a display cutout or notch. These are non-functional areas on edge-to-edge screens used by cameras and sensors. Returns an empty array if the device does not have cutouts. See also <see cref="Godot.OS.GetWindowSafeArea"/>.</para>
        /// <para>Note: Currently only implemented on Android. Other platforms will return an empty array even if they do have display cutouts or notches.</para>
        /// </summary>
        [GodotMethod("get_display_cutouts")]
        public static Godot.Collections.Array GetDisplayCutouts()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_33, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_window_fullscreen");

        [GodotMethod("set_window_fullscreen")]
        [Obsolete("SetWindowFullscreen is deprecated. Use the WindowFullscreen property instead.")]
        public static void SetWindowFullscreen(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_34, ptr, enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_window_fullscreen");

        [GodotMethod("is_window_fullscreen")]
        [Obsolete("IsWindowFullscreen is deprecated. Use the WindowFullscreen property instead.")]
        public static bool IsWindowFullscreen()
        {
            return NativeCalls.godot_icall_0_7(method_bind_35, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_window_resizable");

        [GodotMethod("set_window_resizable")]
        [Obsolete("SetWindowResizable is deprecated. Use the WindowResizable property instead.")]
        public static void SetWindowResizable(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_36, ptr, enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_window_resizable");

        [GodotMethod("is_window_resizable")]
        [Obsolete("IsWindowResizable is deprecated. Use the WindowResizable property instead.")]
        public static bool IsWindowResizable()
        {
            return NativeCalls.godot_icall_0_7(method_bind_37, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_window_minimized");

        [GodotMethod("set_window_minimized")]
        [Obsolete("SetWindowMinimized is deprecated. Use the WindowMinimized property instead.")]
        public static void SetWindowMinimized(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_38, ptr, enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_window_minimized");

        [GodotMethod("is_window_minimized")]
        [Obsolete("IsWindowMinimized is deprecated. Use the WindowMinimized property instead.")]
        public static bool IsWindowMinimized()
        {
            return NativeCalls.godot_icall_0_7(method_bind_39, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_window_maximized");

        [GodotMethod("set_window_maximized")]
        [Obsolete("SetWindowMaximized is deprecated. Use the WindowMaximized property instead.")]
        public static void SetWindowMaximized(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_40, ptr, enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_window_maximized");

        [GodotMethod("is_window_maximized")]
        [Obsolete("IsWindowMaximized is deprecated. Use the WindowMaximized property instead.")]
        public static bool IsWindowMaximized()
        {
            return NativeCalls.godot_icall_0_7(method_bind_41, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_window_always_on_top");

        /// <summary>
        /// <para>Sets whether the window should always be on top.</para>
        /// <para>Note: This method is implemented on Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("set_window_always_on_top")]
        public static void SetWindowAlwaysOnTop(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_42, ptr, enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_window_always_on_top");

        /// <summary>
        /// <para>Returns <c>true</c> if the window should always be on top of other windows.</para>
        /// </summary>
        [GodotMethod("is_window_always_on_top")]
        public static bool IsWindowAlwaysOnTop()
        {
            return NativeCalls.godot_icall_0_7(method_bind_43, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_window_focused");

        /// <summary>
        /// <para>Returns <c>true</c> if the window is currently focused.</para>
        /// <para>Note: Only implemented on desktop platforms. On other platforms, it will always return <c>true</c>.</para>
        /// </summary>
        [GodotMethod("is_window_focused")]
        public static bool IsWindowFocused()
        {
            return NativeCalls.godot_icall_0_7(method_bind_44, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "request_attention");

        /// <summary>
        /// <para>Request the user attention to the window. It'll flash the taskbar button on Windows or bounce the dock icon on OSX.</para>
        /// <para>Note: This method is implemented on Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("request_attention")]
        public static void RequestAttention()
        {
            NativeCalls.godot_icall_0_3(method_bind_45, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_real_window_size");

        /// <summary>
        /// <para>Returns the window size including decorations like window borders.</para>
        /// </summary>
        [GodotMethod("get_real_window_size")]
        public static Vector2 GetRealWindowSize()
        {
            NativeCalls.godot_icall_0_18(method_bind_46, ptr, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "center_window");

        /// <summary>
        /// <para>Centers the window on the screen if in windowed mode.</para>
        /// </summary>
        [GodotMethod("center_window")]
        public static void CenterWindow()
        {
            NativeCalls.godot_icall_0_3(method_bind_47, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "move_window_to_foreground");

        /// <summary>
        /// <para>Moves the window to the front.</para>
        /// <para>Note: This method is implemented on Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("move_window_to_foreground")]
        public static void MoveWindowToForeground()
        {
            NativeCalls.godot_icall_0_3(method_bind_48, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_native_handle");

        /// <summary>
        /// <para>Returns internal structure pointers for use in GDNative plugins.</para>
        /// <para>Note: This method is implemented on Linux and Windows (other OSs will soon be supported).</para>
        /// </summary>
        [GodotMethod("get_native_handle")]
        public static long GetNativeHandle(OS.HandleType handleType)
        {
            return NativeCalls.godot_icall_1_1214(method_bind_49, ptr, (int)handleType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_borderless_window");

        [GodotMethod("set_borderless_window")]
        [Obsolete("SetBorderlessWindow is deprecated. Use the WindowBorderless property instead.")]
        public static void SetBorderlessWindow(bool borderless)
        {
            NativeCalls.godot_icall_1_16(method_bind_50, ptr, borderless);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_borderless_window");

        [GodotMethod("get_borderless_window")]
        [Obsolete("GetBorderlessWindow is deprecated. Use the WindowBorderless property instead.")]
        public static bool GetBorderlessWindow()
        {
            return NativeCalls.godot_icall_0_7(method_bind_51, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_window_per_pixel_transparency_enabled");

        [GodotMethod("get_window_per_pixel_transparency_enabled")]
        [Obsolete("GetWindowPerPixelTransparencyEnabled is deprecated. Use the WindowPerPixelTransparencyEnabled property instead.")]
        public static bool GetWindowPerPixelTransparencyEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_52, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_53 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_window_per_pixel_transparency_enabled");

        [GodotMethod("set_window_per_pixel_transparency_enabled")]
        [Obsolete("SetWindowPerPixelTransparencyEnabled is deprecated. Use the WindowPerPixelTransparencyEnabled property instead.")]
        public static void SetWindowPerPixelTransparencyEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_53, ptr, enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_54 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ime_active");

        /// <summary>
        /// <para>Sets whether IME input mode should be enabled.</para>
        /// <para>If active IME handles key events before the application and creates an composition string and suggestion list.</para>
        /// <para>Application can retrieve the composition status by using <see cref="Godot.OS.GetImeSelection"/> and <see cref="Godot.OS.GetImeText"/> functions.</para>
        /// <para>Completed composition string is committed when input is finished.</para>
        /// <para>Note: This method is implemented on Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("set_ime_active")]
        public static void SetImeActive(bool active)
        {
            NativeCalls.godot_icall_1_16(method_bind_54, ptr, active);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_55 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ime_position");

        /// <summary>
        /// <para>Sets position of IME suggestion list popup (in window coordinates).</para>
        /// <para>Note: This method is implemented on Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("set_ime_position")]
        public static void SetImePosition(Vector2 position)
        {
            NativeCalls.godot_icall_1_57(method_bind_55, ptr, ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_56 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ime_selection");

        /// <summary>
        /// <para>Returns the IME cursor position (the currently-edited portion of the string) relative to the characters in the composition string.</para>
        /// <para><see cref="Godot.MainLoop.NotificationOsImeUpdate"/> is sent to the application to notify it of changes to the IME cursor position.</para>
        /// <para>Note: This method is implemented on macOS.</para>
        /// </summary>
        [GodotMethod("get_ime_selection")]
        public static Vector2 GetImeSelection()
        {
            NativeCalls.godot_icall_0_18(method_bind_56, ptr, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_57 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ime_text");

        /// <summary>
        /// <para>Returns the IME intermediate composition string.</para>
        /// <para><see cref="Godot.MainLoop.NotificationOsImeUpdate"/> is sent to the application to notify it of changes to the IME composition string.</para>
        /// <para>Note: This method is implemented on macOS.</para>
        /// </summary>
        [GodotMethod("get_ime_text")]
        public static string GetImeText()
        {
            return NativeCalls.godot_icall_0_6(method_bind_57, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_58 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_screen_orientation");

        [GodotMethod("set_screen_orientation")]
        [Obsolete("SetScreenOrientation is deprecated. Use the ScreenOrientation property instead.")]
        public static void SetScreenOrientation(OS.ScreenOrientationEnum orientation)
        {
            NativeCalls.godot_icall_1_4(method_bind_58, ptr, (int)orientation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_59 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_screen_orientation");

        [GodotMethod("get_screen_orientation")]
        [Obsolete("GetScreenOrientation is deprecated. Use the ScreenOrientation property instead.")]
        public static OS.ScreenOrientationEnum GetScreenOrientation()
        {
            return (OS.ScreenOrientationEnum)NativeCalls.godot_icall_0_1215(method_bind_59, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_60 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_keep_screen_on");

        [GodotMethod("set_keep_screen_on")]
        [Obsolete("SetKeepScreenOn is deprecated. Use the KeepScreenOn property instead.")]
        public static void SetKeepScreenOn(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_60, ptr, enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_61 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_keep_screen_on");

        [GodotMethod("is_keep_screen_on")]
        [Obsolete("IsKeepScreenOn is deprecated. Use the KeepScreenOn property instead.")]
        public static bool IsKeepScreenOn()
        {
            return NativeCalls.godot_icall_0_7(method_bind_61, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_62 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_touchscreen_ui_hint");

        /// <summary>
        /// <para>Returns <c>true</c> if the device has a touchscreen or emulates one.</para>
        /// </summary>
        [GodotMethod("has_touchscreen_ui_hint")]
        public static bool HasTouchscreenUiHint()
        {
            return NativeCalls.godot_icall_0_7(method_bind_62, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_63 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_window_title");

        /// <summary>
        /// <para>Sets the window title to the specified string.</para>
        /// <para>Note: This should be used sporadically. Don't set this every frame, as that will negatively affect performance on some window managers.</para>
        /// <para>Note: This method is implemented on HTML5, Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("set_window_title")]
        public static void SetWindowTitle(string title)
        {
            NativeCalls.godot_icall_1_54(method_bind_63, ptr, title);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_64 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_window_mouse_passthrough");

        /// <summary>
        /// <para>Sets a polygonal region of the window which accepts mouse events. Mouse events outside the region will be passed through.</para>
        /// <para>Passing an empty array will disable passthrough support (all mouse events will be intercepted by the window, which is the default behavior).</para>
        /// <para><code>
        /// # Set region, using Path2D node.
        /// OS.set_window_mouse_passthrough($Path2D.curve.get_baked_points())
        /// 
        /// # Set region, using Polygon2D node.
        /// OS.set_window_mouse_passthrough($Polygon2D.polygon)
        /// 
        /// # Reset region to default.
        /// OS.set_window_mouse_passthrough([])
        /// </code></para>
        /// <para>Note: On Windows, the portion of a window that lies outside the region is not drawn, while on Linux and macOS it is.</para>
        /// <para>Note: This method is implemented on Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("set_window_mouse_passthrough")]
        public static void SetWindowMousePassthrough(Vector2[] region)
        {
            NativeCalls.godot_icall_1_235(method_bind_64, ptr, region);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_65 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_low_processor_usage_mode");

        [GodotMethod("set_low_processor_usage_mode")]
        [Obsolete("SetLowProcessorUsageMode is deprecated. Use the LowProcessorUsageMode property instead.")]
        public static void SetLowProcessorUsageMode(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_65, ptr, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_66 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_in_low_processor_usage_mode");

        [GodotMethod("is_in_low_processor_usage_mode")]
        [Obsolete("IsInLowProcessorUsageMode is deprecated. Use the LowProcessorUsageMode property instead.")]
        public static bool IsInLowProcessorUsageMode()
        {
            return NativeCalls.godot_icall_0_7(method_bind_66, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_67 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_low_processor_usage_mode_sleep_usec");

        [GodotMethod("set_low_processor_usage_mode_sleep_usec")]
        [Obsolete("SetLowProcessorUsageModeSleepUsec is deprecated. Use the LowProcessorUsageModeSleepUsec property instead.")]
        public static void SetLowProcessorUsageModeSleepUsec(int usec)
        {
            NativeCalls.godot_icall_1_4(method_bind_67, ptr, usec);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_68 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_low_processor_usage_mode_sleep_usec");

        [GodotMethod("get_low_processor_usage_mode_sleep_usec")]
        [Obsolete("GetLowProcessorUsageModeSleepUsec is deprecated. Use the LowProcessorUsageModeSleepUsec property instead.")]
        public static int GetLowProcessorUsageModeSleepUsec()
        {
            return NativeCalls.godot_icall_0_5(method_bind_68, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_69 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_processor_count");

        /// <summary>
        /// <para>Returns the number of logical CPU cores available on the host machine. On CPUs with HyperThreading enabled, this number will be greater than the number of physical CPU cores.</para>
        /// </summary>
        [GodotMethod("get_processor_count")]
        public static int GetProcessorCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_69, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_70 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_processor_name");

        /// <summary>
        /// <para>Returns the name of the CPU model on the host machine (e.g. "Intel(R) Core(TM) i7-6700K CPU @ 4.00GHz").</para>
        /// <para>Note: This method is only implemented on Windows, macOS, Linux and iOS. On Android, HTML5 and UWP, <see cref="Godot.OS.GetProcessorName"/> returns an empty string.</para>
        /// </summary>
        [GodotMethod("get_processor_name")]
        public static string GetProcessorName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_70, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_71 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_executable_path");

        /// <summary>
        /// <para>Returns the path to the current engine executable.</para>
        /// </summary>
        [GodotMethod("get_executable_path")]
        public static string GetExecutablePath()
        {
            return NativeCalls.godot_icall_0_6(method_bind_71, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_72 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "execute");

        /// <summary>
        /// <para>Execute the file at the given path with the arguments passed as an array of strings. Platform path resolution will take place. The resolved file must exist and be executable.</para>
        /// <para>The arguments are used in the given order and separated by a space, so <c>OS.execute("ping", ["-w", "3", "godotengine.org"], false)</c> will resolve to <c>ping -w 3 godotengine.org</c> in the system's shell.</para>
        /// <para>This method has slightly different behavior based on whether the <c>blocking</c> mode is enabled.</para>
        /// <para>If <c>blocking</c> is <c>true</c>, the Godot thread will pause its execution while waiting for the process to terminate. The shell output of the process will be written to the <c>output</c> array as a single string. When the process terminates, the Godot thread will resume execution.</para>
        /// <para>If <c>blocking</c> is <c>false</c>, the Godot thread will continue while the new process runs. It is not possible to retrieve the shell output in non-blocking mode, so <c>output</c> will be empty.</para>
        /// <para>On Windows, if <c>open_console</c> is <c>true</c> and process is console app, new terminal window will be opened, it's ignored on other platforms.</para>
        /// <para>The return value also depends on the blocking mode. When blocking, the method will return an exit code of the process. When non-blocking, the method returns a process ID, which you can use to monitor the process (and potentially terminate it with <see cref="Godot.OS.Kill"/>). If the process forking (non-blocking) or opening (blocking) fails, the method will return <c>-1</c> or another exit code.</para>
        /// <para>Example of blocking mode and retrieving the shell output:</para>
        /// <para><code>
        /// var output = []
        /// var exit_code = OS.execute("ls", ["-l", "/tmp"], true, output)
        /// </code></para>
        /// <para>Example of non-blocking mode, running another instance of the project and storing its process ID:</para>
        /// <para><code>
        /// var pid = OS.execute(OS.get_executable_path(), [], false)
        /// </code></para>
        /// <para>If you wish to access a shell built-in or perform a composite command, a platform-specific shell can be invoked. For example:</para>
        /// <para><code>
        /// OS.execute("CMD.exe", ["/C", "cd %TEMP% &amp;&amp; dir"], true, output)
        /// </code></para>
        /// <para>Note: This method is implemented on Android, iOS, Linux, macOS and Windows.</para>
        /// <para>Note: To execute a Windows command interpreter built-in command, specify <c>cmd.exe</c> in <c>path</c>, <c>/c</c> as the first argument, and the desired command as the second argument.</para>
        /// <para>Note: To execute a PowerShell built-in command, specify <c>powershell.exe</c> in <c>path</c>, <c>-Command</c> as the first argument, and the desired command as the second argument.</para>
        /// <para>Note: To execute a Unix shell built-in command, specify shell executable name in <c>path</c>, <c>-c</c> as the first argument, and the desired command as the second argument.</para>
        /// </summary>
        /// <param name="output">If the parameter is null, then the default value is new Godot.Collections.Array { }</param>
        [GodotMethod("execute")]
        public static int Execute(string path, string[] arguments, bool blocking = true, Godot.Collections.Array output = null, bool readStderr = false, bool openConsole = false)
        {
            Godot.Collections.Array output_in = output != null ? output : new Godot.Collections.Array { };
            return NativeCalls.godot_icall_6_1216(method_bind_72, ptr, path, arguments, blocking, output_in.GetPtr(), readStderr, openConsole);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_73 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "kill");

        /// <summary>
        /// <para>Kill (terminate) the process identified by the given process ID (<c>pid</c>), e.g. the one returned by <see cref="Godot.OS.Execute"/> in non-blocking mode. See also <see cref="Godot.OS.Crash"/>.</para>
        /// <para>Note: This method can also be used to kill processes that were not spawned by the game.</para>
        /// <para>Note: This method is implemented on Android, iOS, Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("kill")]
        public static Error Kill(int pid)
        {
            return (Error)NativeCalls.godot_icall_1_497(method_bind_73, ptr, pid);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_74 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shell_open");

        /// <summary>
        /// <para>Requests the OS to open a resource with the most appropriate program. For example:</para>
        /// <para>- <c>OS.shell_open("C:\\Users\name\Downloads")</c> on Windows opens the file explorer at the user's Downloads folder.</para>
        /// <para>- <c>OS.shell_open("https://godotengine.org")</c> opens the default web browser on the official Godot website.</para>
        /// <para>- <c>OS.shell_open("mailto:example@example.com")</c> opens the default email client with the "To" field set to <c>example@example.com</c>. See <a href="https://datatracker.ietf.org/doc/html/rfc2368">RFC 2368 - The <c>mailto</c> URL scheme</a> for a list of fields that can be added.</para>
        /// <para>Use <see cref="Godot.ProjectSettings.GlobalizePath"/> to convert a <c>res://</c> or <c>user://</c> path into a system path for use with this method.</para>
        /// <para>Note: Use <c>String.percent_encode</c> to encode characters within URLs in a URL-safe, portable way. This is especially required for line breaks. Otherwise, <see cref="Godot.OS.ShellOpen"/> may not work correctly in a project exported to the Web platform.</para>
        /// <para>Note: This method is implemented on Android, iOS, HTML5, Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("shell_open")]
        public static Error ShellOpen(string uri)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_74, ptr, uri);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_75 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_process_running");

        /// <summary>
        /// <para>Returns <c>true</c> if the child process ID (<c>pid</c>) is still running or <c>false</c> if it has terminated.</para>
        /// <para>Must be a valid ID generated from <see cref="Godot.OS.Execute"/>.</para>
        /// <para>Note: This method is implemented on Android, iOS, Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("is_process_running")]
        public static bool IsProcessRunning(int pid)
        {
            return NativeCalls.godot_icall_1_35(method_bind_75, ptr, pid);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_76 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_process_id");

        /// <summary>
        /// <para>Returns the project's process ID.</para>
        /// <para>Note: This method is implemented on Android, iOS, Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("get_process_id")]
        public static int GetProcessId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_76, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_77 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_environment");

        /// <summary>
        /// <para>Returns the value of an environment variable. Returns an empty string if the environment variable doesn't exist.</para>
        /// <para>Note: Double-check the casing of <c>variable</c>. Environment variable names are case-sensitive on all platforms except Windows.</para>
        /// </summary>
        [GodotMethod("get_environment")]
        public static string GetEnvironment(string variable)
        {
            return NativeCalls.godot_icall_1_124(method_bind_77, ptr, variable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_78 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_environment");

        /// <summary>
        /// <para>Sets the value of the environment variable <c>variable</c> to <c>value</c>. The environment variable will be set for the Godot process and any process executed with <see cref="Godot.OS.Execute"/> after running <see cref="Godot.OS.SetEnvironment"/>. The environment variable will not persist to processes run after the Godot process was terminated.</para>
        /// <para>Note: Double-check the casing of <c>variable</c>. Environment variable names are case-sensitive on all platforms except Windows.</para>
        /// </summary>
        [GodotMethod("set_environment")]
        public static bool SetEnvironment(string variable, string value)
        {
            return NativeCalls.godot_icall_2_116(method_bind_78, ptr, variable, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_79 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_environment");

        /// <summary>
        /// <para>Returns <c>true</c> if the environment variable with the name <c>variable</c> exists.</para>
        /// <para>Note: Double-check the casing of <c>variable</c>. Environment variable names are case-sensitive on all platforms except Windows.</para>
        /// </summary>
        [GodotMethod("has_environment")]
        public static bool HasEnvironment(string variable)
        {
            return NativeCalls.godot_icall_1_108(method_bind_79, ptr, variable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_80 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_name");

        /// <summary>
        /// <para>Returns the name of the host OS. Possible values are: <c>"Android"</c>, <c>"iOS"</c>, <c>"HTML5"</c>, <c>"OSX"</c>, <c>"Server"</c>, <c>"Windows"</c>, <c>"UWP"</c>, <c>"X11"</c>.</para>
        /// </summary>
        [GodotMethod("get_name")]
        public static string GetName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_80, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_81 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cmdline_args");

        /// <summary>
        /// <para>Returns the command-line arguments passed to the engine.</para>
        /// <para>Command-line arguments can be written in any form, including both <c>--key value</c> and <c>--key=value</c> forms so they can be properly parsed, as long as custom command-line arguments do not conflict with engine arguments.</para>
        /// <para>You can also incorporate environment variables using the <see cref="Godot.OS.GetEnvironment"/> method.</para>
        /// <para>You can set  to define command-line arguments to be passed by the editor when running the project.</para>
        /// <para>Here's a minimal example on how to parse command-line arguments into a dictionary using the <c>--key=value</c> form for arguments:</para>
        /// <para><code>
        /// var arguments = {}
        /// for argument in OS.get_cmdline_args():
        ///     if argument.find("=") &gt; -1:
        ///         var key_value = argument.split("=")
        ///         arguments[key_value[0].lstrip("--")] = key_value[1]
        ///     else:
        ///         # Options without an argument will be present in the dictionary,
        ///         # with the value set to an empty string.
        ///         arguments[argument.lstrip("--")] = ""
        /// </code></para>
        /// </summary>
        [GodotMethod("get_cmdline_args")]
        public static string[] GetCmdlineArgs()
        {
            return NativeCalls.godot_icall_0_119(method_bind_81, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_82 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_datetime");

        /// <summary>
        /// <para>Deprecated, use <see cref="Godot.Time.GetDatetimeDictFromSystem"/> instead.</para>
        /// <para>Returns current datetime as a dictionary of keys: <c>year</c>, <c>month</c>, <c>day</c>, <c>weekday</c>, <c>dst</c> (Daylight Savings Time), <c>hour</c>, <c>minute</c>, <c>second</c>.</para>
        /// </summary>
        [GodotMethod("get_datetime")]
        public static Godot.Collections.Dictionary GetDatetime(bool utc = false)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_1_536(method_bind_82, ptr, utc));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_83 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_date");

        /// <summary>
        /// <para>Deprecated, use <see cref="Godot.Time.GetDateDictFromSystem"/> instead.</para>
        /// <para>Returns current date as a dictionary of keys: <c>year</c>, <c>month</c>, <c>day</c>, <c>weekday</c>, <c>dst</c> (Daylight Savings Time).</para>
        /// </summary>
        [GodotMethod("get_date")]
        public static Godot.Collections.Dictionary GetDate(bool utc = false)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_1_536(method_bind_83, ptr, utc));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_84 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_time");

        /// <summary>
        /// <para>Deprecated, use <see cref="Godot.Time.GetTimeDictFromSystem"/> instead.</para>
        /// <para>Returns current time as a dictionary of keys: hour, minute, second.</para>
        /// </summary>
        [GodotMethod("get_time")]
        public static Godot.Collections.Dictionary GetTime(bool utc = false)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_1_536(method_bind_84, ptr, utc));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_85 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_time_zone_info");

        /// <summary>
        /// <para>Returns the current time zone as a dictionary with the keys: bias and name.</para>
        /// </summary>
        [GodotMethod("get_time_zone_info")]
        public static Godot.Collections.Dictionary GetTimeZoneInfo()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_85, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_86 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_unix_time");

        /// <summary>
        /// <para>Returns the current UNIX epoch timestamp in seconds.</para>
        /// <para>Important: This is the system clock that the user can manually set. Never use this method for precise time calculation since its results are also subject to automatic adjustments by the operating system. Always use <see cref="Godot.OS.GetTicksUsec"/> or <see cref="Godot.OS.GetTicksMsec"/> for precise time calculation instead, since they are guaranteed to be monotonic (i.e. never decrease).</para>
        /// <para>Note: To get a floating point timestamp with sub-second precision, use <see cref="Godot.Time.GetUnixTimeFromSystem"/>.</para>
        /// </summary>
        [GodotMethod("get_unix_time")]
        public static ulong GetUnixTime()
        {
            return NativeCalls.godot_icall_0_30(method_bind_86, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_87 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_datetime_from_unix_time");

        /// <summary>
        /// <para>Deprecated, use <see cref="Godot.Time.GetDatetimeDictFromUnixTime"/> instead.</para>
        /// <para>Gets a dictionary of time values corresponding to the given UNIX epoch time (in seconds).</para>
        /// <para>The returned Dictionary's values will be the same as <see cref="Godot.OS.GetDatetime"/>, with the exception of Daylight Savings Time as it cannot be determined from the epoch.</para>
        /// </summary>
        [GodotMethod("get_datetime_from_unix_time")]
        public static Godot.Collections.Dictionary GetDatetimeFromUnixTime(long unixTimeVal)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_1_963(method_bind_87, ptr, unixTimeVal));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_88 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_unix_time_from_datetime");

        /// <summary>
        /// <para>Gets an epoch time value from a dictionary of time values.</para>
        /// <para><c>datetime</c> must be populated with the following keys: <c>year</c>, <c>month</c>, <c>day</c>, <c>hour</c>, <c>minute</c>, <c>second</c>.</para>
        /// <para>If the dictionary is empty <c>0</c> is returned. If some keys are omitted, they default to the equivalent values for the UNIX epoch timestamp 0 (1970-01-01 at 00:00:00 UTC).</para>
        /// <para>You can pass the output from <see cref="Godot.OS.GetDatetimeFromUnixTime"/> directly into this function. Daylight Savings Time (<c>dst</c>), if present, is ignored.</para>
        /// </summary>
        [GodotMethod("get_unix_time_from_datetime")]
        public static long GetUnixTimeFromDatetime(Godot.Collections.Dictionary datetime)
        {
            return NativeCalls.godot_icall_1_968(method_bind_88, ptr, datetime.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_89 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_system_time_secs");

        /// <summary>
        /// <para>Returns the epoch time of the operating system in seconds.</para>
        /// </summary>
        [GodotMethod("get_system_time_secs")]
        public static ulong GetSystemTimeSecs()
        {
            return NativeCalls.godot_icall_0_30(method_bind_89, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_90 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_system_time_msecs");

        /// <summary>
        /// <para>Returns the epoch time of the operating system in milliseconds.</para>
        /// </summary>
        [GodotMethod("get_system_time_msecs")]
        public static ulong GetSystemTimeMsecs()
        {
            return NativeCalls.godot_icall_0_30(method_bind_90, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_91 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_native_icon");

        /// <summary>
        /// <para>Sets the game's icon using a multi-size platform-specific icon file (<c>*.ico</c> on Windows and <c>*.icns</c> on macOS).</para>
        /// <para>Appropriate size sub-icons are used for window caption, taskbar/dock and window selection dialog.</para>
        /// <para>Note: This method is implemented on macOS and Windows.</para>
        /// </summary>
        [GodotMethod("set_native_icon")]
        public static void SetNativeIcon(string filename)
        {
            NativeCalls.godot_icall_1_54(method_bind_91, ptr, filename);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_92 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_icon");

        /// <summary>
        /// <para>Sets the game's icon using an <see cref="Godot.Image"/> resource.</para>
        /// <para>The same image is used for window caption, taskbar/dock and window selection dialog. Image is scaled as needed.</para>
        /// <para>Note: This method is implemented on HTML5, Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("set_icon")]
        public static void SetIcon(Image icon)
        {
            NativeCalls.godot_icall_1_24(method_bind_92, ptr, Object.GetPtr(icon));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_93 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_exit_code");

        [GodotMethod("get_exit_code")]
        [Obsolete("GetExitCode is deprecated. Use the ExitCode property instead.")]
        public static int GetExitCode()
        {
            return NativeCalls.godot_icall_0_5(method_bind_93, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_94 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_exit_code");

        [GodotMethod("set_exit_code")]
        [Obsolete("SetExitCode is deprecated. Use the ExitCode property instead.")]
        public static void SetExitCode(int code)
        {
            NativeCalls.godot_icall_1_4(method_bind_94, ptr, code);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_95 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "delay_usec");

        /// <summary>
        /// <para>Delays execution of the current thread by <c>usec</c> microseconds. <c>usec</c> must be greater than or equal to <c>0</c>. Otherwise, <see cref="Godot.OS.DelayUsec"/> will do nothing and will print an error message.</para>
        /// <para>Note: <see cref="Godot.OS.DelayUsec"/> is a blocking way to delay code execution. To delay code execution in a non-blocking way, see <see cref="Godot.SceneTree.CreateTimer"/>. Yielding with <see cref="Godot.SceneTree.CreateTimer"/> will delay the execution of code placed below the <c>yield</c> without affecting the rest of the project (or editor, for <see cref="Godot.EditorPlugin"/>s and <see cref="Godot.EditorScript"/>s).</para>
        /// <para>Note: When <see cref="Godot.OS.DelayUsec"/> is called on the main thread, it will freeze the project and will prevent it from redrawing and registering input until the delay has passed. When using <see cref="Godot.OS.DelayUsec"/> as part of an <see cref="Godot.EditorPlugin"/> or <see cref="Godot.EditorScript"/>, it will freeze the editor but won't freeze the project if it is currently running (since the project is an independent child process).</para>
        /// </summary>
        [GodotMethod("delay_usec")]
        public static void DelayUsec(int usec)
        {
            NativeCalls.godot_icall_1_4(method_bind_95, ptr, usec);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_96 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "delay_msec");

        /// <summary>
        /// <para>Delays execution of the current thread by <c>msec</c> milliseconds. <c>msec</c> must be greater than or equal to <c>0</c>. Otherwise, <see cref="Godot.OS.DelayMsec"/> will do nothing and will print an error message.</para>
        /// <para>Note: <see cref="Godot.OS.DelayMsec"/> is a blocking way to delay code execution. To delay code execution in a non-blocking way, see <see cref="Godot.SceneTree.CreateTimer"/>. Yielding with <see cref="Godot.SceneTree.CreateTimer"/> will delay the execution of code placed below the <c>yield</c> without affecting the rest of the project (or editor, for <see cref="Godot.EditorPlugin"/>s and <see cref="Godot.EditorScript"/>s).</para>
        /// <para>Note: When <see cref="Godot.OS.DelayMsec"/> is called on the main thread, it will freeze the project and will prevent it from redrawing and registering input until the delay has passed. When using <see cref="Godot.OS.DelayMsec"/> as part of an <see cref="Godot.EditorPlugin"/> or <see cref="Godot.EditorScript"/>, it will freeze the editor but won't freeze the project if it is currently running (since the project is an independent child process).</para>
        /// </summary>
        [GodotMethod("delay_msec")]
        public static void DelayMsec(int msec)
        {
            NativeCalls.godot_icall_1_4(method_bind_96, ptr, msec);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_97 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ticks_msec");

        /// <summary>
        /// <para>Deprecated, use <see cref="Godot.Time.GetTicksMsec"/> instead.</para>
        /// <para>Returns the amount of time passed in milliseconds since the engine started.</para>
        /// </summary>
        [GodotMethod("get_ticks_msec")]
        public static ulong GetTicksMsec()
        {
            return NativeCalls.godot_icall_0_30(method_bind_97, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_98 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ticks_usec");

        /// <summary>
        /// <para>Deprecated, use <see cref="Godot.Time.GetTicksUsec"/> instead.</para>
        /// <para>Returns the amount of time passed in microseconds since the engine started.</para>
        /// </summary>
        [GodotMethod("get_ticks_usec")]
        public static ulong GetTicksUsec()
        {
            return NativeCalls.godot_icall_0_30(method_bind_98, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_99 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_splash_tick_msec");

        /// <summary>
        /// <para>Returns the amount of time in milliseconds it took for the boot logo to appear.</para>
        /// </summary>
        [GodotMethod("get_splash_tick_msec")]
        public static uint GetSplashTickMsec()
        {
            return NativeCalls.godot_icall_0_188(method_bind_99, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_100 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_locale");

        /// <summary>
        /// <para>Returns the host OS locale as a string of the form <c>language_Script_COUNTRY_VARIANT@extra</c>. If you want only the language code and not the fully specified locale from the OS, you can use <see cref="Godot.OS.GetLocaleLanguage"/>.</para>
        /// <para><c>language</c> - 2 or 3-letter <a href="https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes">language code</a>, in lower case.</para>
        /// <para><c>Script</c> - optional, 4-letter <a href="https://en.wikipedia.org/wiki/ISO_15924">script code</a>, in title case.</para>
        /// <para><c>COUNTRY</c> - optional, 2 or 3-letter <a href="https://en.wikipedia.org/wiki/ISO_3166-1">country code</a>, in upper case.</para>
        /// <para><c>VARIANT</c> - optional, language variant, region and sort order. Variant can have any number of underscored keywords.</para>
        /// <para><c>extra</c> - optional, semicolon separated list of additional key words. Currency, calendar, sort order and numbering system information.</para>
        /// </summary>
        [GodotMethod("get_locale")]
        public static string GetLocale()
        {
            return NativeCalls.godot_icall_0_6(method_bind_100, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_101 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_locale_language");

        /// <summary>
        /// <para>Returns the host OS locale's 2 or 3-letter <a href="https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes">language code</a> as a string which should be consistent on all platforms. This is equivalent to extracting the <c>language</c> part of the <see cref="Godot.OS.GetLocale"/> string.</para>
        /// <para>This can be used to narrow down fully specified locale strings to only the "common" language code, when you don't need the additional information about country code or variants. For example, for a French Canadian user with <c>fr_CA</c> locale, this would return <c>fr</c>.</para>
        /// </summary>
        [GodotMethod("get_locale_language")]
        public static string GetLocaleLanguage()
        {
            return NativeCalls.godot_icall_0_6(method_bind_101, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_102 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_latin_keyboard_variant");

        /// <summary>
        /// <para>Returns the current latin keyboard variant as a String.</para>
        /// <para>Possible return values are: <c>"QWERTY"</c>, <c>"AZERTY"</c>, <c>"QZERTY"</c>, <c>"DVORAK"</c>, <c>"NEO"</c>, <c>"COLEMAK"</c> or <c>"ERROR"</c>.</para>
        /// <para>Note: This method is implemented on Linux, macOS and Windows. Returns <c>"QWERTY"</c> on unsupported platforms.</para>
        /// </summary>
        [GodotMethod("get_latin_keyboard_variant")]
        public static string GetLatinKeyboardVariant()
        {
            return NativeCalls.godot_icall_0_6(method_bind_102, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_103 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_model_name");

        /// <summary>
        /// <para>Returns the model name of the current device.</para>
        /// <para>Note: This method is implemented on Android and iOS. Returns <c>"GenericDevice"</c> on unsupported platforms.</para>
        /// </summary>
        [GodotMethod("get_model_name")]
        public static string GetModelName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_103, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_104 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "keyboard_get_layout_count");

        /// <summary>
        /// <para>Returns the number of keyboard layouts.</para>
        /// <para>Note: This method is implemented on Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("keyboard_get_layout_count")]
        public static int KeyboardGetLayoutCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_104, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_105 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "keyboard_get_current_layout");

        /// <summary>
        /// <para>Returns active keyboard layout index.</para>
        /// <para>Note: This method is implemented on Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("keyboard_get_current_layout")]
        public static int KeyboardGetCurrentLayout()
        {
            return NativeCalls.godot_icall_0_5(method_bind_105, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_106 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "keyboard_set_current_layout");

        /// <summary>
        /// <para>Sets active keyboard layout.</para>
        /// <para>Note: This method is implemented on Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("keyboard_set_current_layout")]
        public static void KeyboardSetCurrentLayout(int index)
        {
            NativeCalls.godot_icall_1_4(method_bind_106, ptr, index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_107 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "keyboard_get_layout_language");

        /// <summary>
        /// <para>Returns the ISO-639/BCP-47 language code of the keyboard layout at position <c>index</c>.</para>
        /// <para>Note: This method is implemented on Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("keyboard_get_layout_language")]
        public static string KeyboardGetLayoutLanguage(int index)
        {
            return NativeCalls.godot_icall_1_89(method_bind_107, ptr, index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_108 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "keyboard_get_layout_name");

        /// <summary>
        /// <para>Returns the localized name of the keyboard layout at position <c>index</c>.</para>
        /// <para>Note: This method is implemented on Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("keyboard_get_layout_name")]
        public static string KeyboardGetLayoutName(int index)
        {
            return NativeCalls.godot_icall_1_89(method_bind_108, ptr, index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_109 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "keyboard_get_scancode_from_physical");

        /// <summary>
        /// <para>Converts a physical (US QWERTY) <c>scancode</c> to one in the active keyboard layout.</para>
        /// <para>Note: This method is implemented on Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("keyboard_get_scancode_from_physical")]
        public static uint KeyboardGetScancodeFromPhysical(uint scancode)
        {
            return NativeCalls.godot_icall_1_1217(method_bind_109, ptr, scancode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_110 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "can_draw");

        /// <summary>
        /// <para>Returns <c>true</c> if the host OS allows drawing.</para>
        /// </summary>
        [GodotMethod("can_draw")]
        public static bool CanDraw()
        {
            return NativeCalls.godot_icall_0_7(method_bind_110, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_111 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_userfs_persistent");

        /// <summary>
        /// <para>If <c>true</c>, the <c>user://</c> file system is persistent, so that its state is the same after a player quits and starts the game again. Relevant to the HTML5 platform, where this persistence may be unavailable.</para>
        /// </summary>
        [GodotMethod("is_userfs_persistent")]
        public static bool IsUserfsPersistent()
        {
            return NativeCalls.godot_icall_0_7(method_bind_111, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_112 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_stdout_verbose");

        /// <summary>
        /// <para>Returns <c>true</c> if the engine was executed with <c>-v</c> (verbose stdout).</para>
        /// </summary>
        [GodotMethod("is_stdout_verbose")]
        public static bool IsStdoutVerbose()
        {
            return NativeCalls.godot_icall_0_7(method_bind_112, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_113 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "can_use_threads");

        /// <summary>
        /// <para>Returns <c>true</c> if the current host platform is using multiple threads.</para>
        /// </summary>
        [GodotMethod("can_use_threads")]
        public static bool CanUseThreads()
        {
            return NativeCalls.godot_icall_0_7(method_bind_113, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_114 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_debug_build");

        /// <summary>
        /// <para>Returns <c>true</c> if the Godot binary used to run the project is a debug export template, or when running in the editor.</para>
        /// <para>Returns <c>false</c> if the Godot binary used to run the project is a release export template.</para>
        /// <para>To check whether the Godot binary used to run the project is an export template (debug or release), use <c>OS.has_feature("standalone")</c> instead.</para>
        /// </summary>
        [GodotMethod("is_debug_build")]
        public static bool IsDebugBuild()
        {
            return NativeCalls.godot_icall_0_7(method_bind_114, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_115 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "dump_memory_to_file");

        /// <summary>
        /// <para>Dumps the memory allocation ringlist to a file (only works in debug).</para>
        /// <para>Entry format per line: "Address - Size - Description".</para>
        /// </summary>
        [GodotMethod("dump_memory_to_file")]
        public static void DumpMemoryToFile(string file)
        {
            NativeCalls.godot_icall_1_54(method_bind_115, ptr, file);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_116 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "dump_resources_to_file");

        /// <summary>
        /// <para>Dumps all used resources to file (only works in debug).</para>
        /// <para>Entry format per line: "Resource Type : Resource Location".</para>
        /// <para>At the end of the file is a statistic of all used Resource Types.</para>
        /// </summary>
        [GodotMethod("dump_resources_to_file")]
        public static void DumpResourcesToFile(string file)
        {
            NativeCalls.godot_icall_1_54(method_bind_116, ptr, file);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_117 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_virtual_keyboard");

        /// <summary>
        /// <para>Returns <c>true</c> if the platform has a virtual keyboard, <c>false</c> otherwise.</para>
        /// </summary>
        [GodotMethod("has_virtual_keyboard")]
        public static bool HasVirtualKeyboard()
        {
            return NativeCalls.godot_icall_0_7(method_bind_117, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_118 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "show_virtual_keyboard");

        /// <summary>
        /// <para>Shows the virtual keyboard if the platform has one.</para>
        /// <para>The <c>existing_text</c> parameter is useful for implementing your own <see cref="Godot.LineEdit"/> or <see cref="Godot.TextEdit"/>, as it tells the virtual keyboard what text has already been typed (the virtual keyboard uses it for auto-correct and predictions).</para>
        /// <para>The <c>multiline</c> parameter needs to be set to <c>true</c> to be able to enter multiple lines of text, as in <see cref="Godot.TextEdit"/>.</para>
        /// <para>Note: This method is implemented on Android, iOS and UWP.</para>
        /// </summary>
        [GodotMethod("show_virtual_keyboard")]
        public static void ShowVirtualKeyboard(string existingText = "", bool multiline = false)
        {
            NativeCalls.godot_icall_2_56(method_bind_118, ptr, existingText, multiline);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_119 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "hide_virtual_keyboard");

        /// <summary>
        /// <para>Hides the virtual keyboard if it is shown, does nothing otherwise.</para>
        /// </summary>
        [GodotMethod("hide_virtual_keyboard")]
        public static void HideVirtualKeyboard()
        {
            NativeCalls.godot_icall_0_3(method_bind_119, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_120 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_virtual_keyboard_height");

        /// <summary>
        /// <para>Returns the on-screen keyboard's height in pixels. Returns 0 if there is no keyboard or if it is currently hidden.</para>
        /// </summary>
        [GodotMethod("get_virtual_keyboard_height")]
        public static int GetVirtualKeyboardHeight()
        {
            return NativeCalls.godot_icall_0_5(method_bind_120, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_121 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "print_resources_in_use");

        /// <summary>
        /// <para>Shows all resources currently used by the game.</para>
        /// </summary>
        [GodotMethod("print_resources_in_use")]
        public static void PrintResourcesInUse(bool @short = false)
        {
            NativeCalls.godot_icall_1_16(method_bind_121, ptr, @short);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_122 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "print_all_resources");

        /// <summary>
        /// <para>Shows all resources in the game. Optionally, the list can be written to a file by specifying a file path in <c>tofile</c>.</para>
        /// </summary>
        [GodotMethod("print_all_resources")]
        public static void PrintAllResources(string tofile = "")
        {
            NativeCalls.godot_icall_1_54(method_bind_122, ptr, tofile);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_123 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_static_memory_usage");

        /// <summary>
        /// <para>Returns the amount of static memory being used by the program in bytes (only works in debug).</para>
        /// </summary>
        [GodotMethod("get_static_memory_usage")]
        public static ulong GetStaticMemoryUsage()
        {
            return NativeCalls.godot_icall_0_30(method_bind_123, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_124 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_static_memory_peak_usage");

        /// <summary>
        /// <para>Returns the maximum amount of static memory used (only works in debug).</para>
        /// </summary>
        [GodotMethod("get_static_memory_peak_usage")]
        public static ulong GetStaticMemoryPeakUsage()
        {
            return NativeCalls.godot_icall_0_30(method_bind_124, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_125 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_dynamic_memory_usage");

        /// <summary>
        /// <para>Returns the total amount of dynamic memory used (only works in debug).</para>
        /// </summary>
        [GodotMethod("get_dynamic_memory_usage")]
        public static ulong GetDynamicMemoryUsage()
        {
            return NativeCalls.godot_icall_0_30(method_bind_125, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_126 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "move_to_trash");

        /// <summary>
        /// <para>Moves the file or directory to the system's recycle bin. See also <see cref="Godot.Directory.Remove"/>.</para>
        /// <para>The method takes only global paths, so you may need to use <see cref="Godot.ProjectSettings.GlobalizePath"/>. Do not use it for files in <c>res://</c> as it will not work in exported project.</para>
        /// <para>Note: If the user has disabled the recycle bin on their system, the file will be permanently deleted instead.</para>
        /// <para><code>
        /// var file_to_remove = "user://slot1.sav"
        /// OS.move_to_trash(ProjectSettings.globalize_path(file_to_remove))
        /// </code></para>
        /// </summary>
        [GodotMethod("move_to_trash")]
        public static Error MoveToTrash(string path)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_126, ptr, path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_127 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_user_data_dir");

        /// <summary>
        /// <para>Returns the absolute directory path where user data is written (<c>user://</c>).</para>
        /// <para>On Linux, this is <c>~/.local/share/godot/app_userdata/[project_name]</c>, or <c>~/.local/share/[custom_name]</c> if <c>use_custom_user_dir</c> is set.</para>
        /// <para>On macOS, this is <c>~/Library/Application Support/Godot/app_userdata/[project_name]</c>, or <c>~/Library/Application Support/[custom_name]</c> if <c>use_custom_user_dir</c> is set.</para>
        /// <para>On Windows, this is <c>%APPDATA%\Godot\app_userdata\[project_name]</c>, or <c>%APPDATA%\[custom_name]</c> if <c>use_custom_user_dir</c> is set. <c>%APPDATA%</c> expands to <c>%USERPROFILE%\AppData\Roaming</c>.</para>
        /// <para>If the project name is empty, <c>user://</c> falls back to <c>res://</c>.</para>
        /// <para>Not to be confused with <see cref="Godot.OS.GetDataDir"/>, which returns the global (non-project-specific) user data directory.</para>
        /// </summary>
        [GodotMethod("get_user_data_dir")]
        public static string GetUserDataDir()
        {
            return NativeCalls.godot_icall_0_6(method_bind_127, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_128 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_system_dir");

        /// <summary>
        /// <para>Returns the actual path to commonly used folders across different platforms. Available locations are specified in <see cref="Godot.OS.SystemDir"/>.</para>
        /// <para>Note: This method is implemented on Android, Linux, macOS and Windows.</para>
        /// <para>Note: Shared storage is implemented on Android and allows to differentiate between app specific and shared directories. Shared directories have additional restrictions on Android.</para>
        /// </summary>
        [GodotMethod("get_system_dir")]
        public static string GetSystemDir(OS.SystemDir dir, bool sharedStorage = true)
        {
            return NativeCalls.godot_icall_2_1218(method_bind_128, ptr, (int)dir, sharedStorage);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_129 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_config_dir");

        /// <summary>
        /// <para>Returns the global user configuration directory according to the operating system's standards. On Linux, this path can be overridden by setting the <c>XDG_CONFIG_HOME</c> environment variable before starting the project. See <a href="$DOCS_URL/tutorials/io/data_paths.html">File paths in Godot projects</a> in the documentation for more information. See also <see cref="Godot.OS.GetCacheDir"/> and <see cref="Godot.OS.GetDataDir"/>.</para>
        /// <para>Not to be confused with <see cref="Godot.OS.GetUserDataDir"/>, which returns the project-specific user data path.</para>
        /// </summary>
        [GodotMethod("get_config_dir")]
        public static string GetConfigDir()
        {
            return NativeCalls.godot_icall_0_6(method_bind_129, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_130 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_data_dir");

        /// <summary>
        /// <para>Returns the global user data directory according to the operating system's standards. On Linux, this path can be overridden by setting the <c>XDG_DATA_HOME</c> environment variable before starting the project. See <a href="$DOCS_URL/tutorials/io/data_paths.html">File paths in Godot projects</a> in the documentation for more information. See also <see cref="Godot.OS.GetCacheDir"/> and <see cref="Godot.OS.GetConfigDir"/>.</para>
        /// <para>Not to be confused with <see cref="Godot.OS.GetUserDataDir"/>, which returns the project-specific user data path.</para>
        /// </summary>
        [GodotMethod("get_data_dir")]
        public static string GetDataDir()
        {
            return NativeCalls.godot_icall_0_6(method_bind_130, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_131 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cache_dir");

        /// <summary>
        /// <para>Returns the global cache data directory according to the operating system's standards. On Linux, this path can be overridden by setting the <c>XDG_CACHE_HOME</c> environment variable before starting the project. See <a href="$DOCS_URL/tutorials/io/data_paths.html">File paths in Godot projects</a> in the documentation for more information. See also <see cref="Godot.OS.GetConfigDir"/> and <see cref="Godot.OS.GetDataDir"/>.</para>
        /// <para>Not to be confused with <see cref="Godot.OS.GetUserDataDir"/>, which returns the project-specific user data path.</para>
        /// </summary>
        [GodotMethod("get_cache_dir")]
        public static string GetCacheDir()
        {
            return NativeCalls.godot_icall_0_6(method_bind_131, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_132 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_unique_id");

        /// <summary>
        /// <para>Returns a string that is unique to the device.</para>
        /// <para>Note: This string may change without notice if the user reinstalls/upgrades their operating system or changes their hardware. This means it should generally not be used to encrypt persistent data as the data saved before an unexpected ID change would become inaccessible. The returned string may also be falsified using external programs, so do not rely on the string returned by <see cref="Godot.OS.GetUniqueId"/> for security purposes.</para>
        /// <para>Note: Returns an empty string on HTML5 and UWP, as this method isn't implemented on those platforms yet.</para>
        /// </summary>
        [GodotMethod("get_unique_id")]
        public static string GetUniqueId()
        {
            return NativeCalls.godot_icall_0_6(method_bind_132, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_133 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_ok_left_and_cancel_right");

        /// <summary>
        /// <para>Returns <c>true</c> if the OK button should appear on the left and Cancel on the right.</para>
        /// </summary>
        [GodotMethod("is_ok_left_and_cancel_right")]
        public static bool IsOkLeftAndCancelRight()
        {
            return NativeCalls.godot_icall_0_7(method_bind_133, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_134 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "print_all_textures_by_size");

        /// <summary>
        /// <para>Shows the list of loaded textures sorted by size in memory.</para>
        /// </summary>
        [GodotMethod("print_all_textures_by_size")]
        public static void PrintAllTexturesBySize()
        {
            NativeCalls.godot_icall_0_3(method_bind_134, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_135 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "print_resources_by_type");

        /// <summary>
        /// <para>Shows the number of resources loaded by the game of the given types.</para>
        /// </summary>
        [GodotMethod("print_resources_by_type")]
        public static void PrintResourcesByType(string[] types)
        {
            NativeCalls.godot_icall_1_407(method_bind_135, ptr, types);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_136 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "native_video_play");

        /// <summary>
        /// <para>Plays native video from the specified path, at the given volume and with audio and subtitle tracks.</para>
        /// <para>Note: This method is only implemented on iOS.</para>
        /// </summary>
        [GodotMethod("native_video_play")]
        public static Error NativeVideoPlay(string path, float volume, string audioTrack, string subtitleTrack)
        {
            return (Error)NativeCalls.godot_icall_4_1219(method_bind_136, ptr, path, volume, audioTrack, subtitleTrack);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_137 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "native_video_is_playing");

        /// <summary>
        /// <para>Returns <c>true</c> if native video is playing.</para>
        /// <para>Note: This method is only implemented on iOS.</para>
        /// </summary>
        [GodotMethod("native_video_is_playing")]
        public static bool NativeVideoIsPlaying()
        {
            return NativeCalls.godot_icall_0_7(method_bind_137, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_138 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "native_video_stop");

        /// <summary>
        /// <para>Stops native video playback.</para>
        /// <para>Note: This method is implemented on iOS.</para>
        /// </summary>
        [GodotMethod("native_video_stop")]
        public static void NativeVideoStop()
        {
            NativeCalls.godot_icall_0_3(method_bind_138, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_139 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "native_video_pause");

        /// <summary>
        /// <para>Pauses native video playback.</para>
        /// <para>Note: This method is only implemented on iOS.</para>
        /// </summary>
        [GodotMethod("native_video_pause")]
        public static void NativeVideoPause()
        {
            NativeCalls.godot_icall_0_3(method_bind_139, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_140 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "native_video_unpause");

        /// <summary>
        /// <para>Resumes native video playback.</para>
        /// <para>Note: This method is implemented on iOS.</para>
        /// </summary>
        [GodotMethod("native_video_unpause")]
        public static void NativeVideoUnpause()
        {
            NativeCalls.godot_icall_0_3(method_bind_140, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_141 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_scancode_string");

        /// <summary>
        /// <para>Returns the given scancode as a string (e.g. Return values: <c>"Escape"</c>, <c>"Shift+Escape"</c>).</para>
        /// <para>See also <see cref="Godot.InputEventKey.Scancode"/> and <see cref="Godot.InputEventKey.GetScancodeWithModifiers"/>.</para>
        /// </summary>
        [GodotMethod("get_scancode_string")]
        public static string GetScancodeString(uint code)
        {
            return NativeCalls.godot_icall_1_1220(method_bind_141, ptr, code);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_142 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_scancode_unicode");

        /// <summary>
        /// <para>Returns <c>true</c> if the input scancode corresponds to a Unicode character.</para>
        /// </summary>
        [GodotMethod("is_scancode_unicode")]
        public static bool IsScancodeUnicode(uint code)
        {
            return NativeCalls.godot_icall_1_291(method_bind_142, ptr, code);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_143 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "find_scancode_from_string");

        /// <summary>
        /// <para>Returns the scancode of the given string (e.g. "Escape").</para>
        /// </summary>
        [GodotMethod("find_scancode_from_string")]
        public static int FindScancodeFromString(string @string)
        {
            return NativeCalls.godot_icall_1_138(method_bind_143, ptr, @string);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_144 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_file_access_save_and_swap");

        /// <summary>
        /// <para>Enables backup saves if <c>enabled</c> is <c>true</c>.</para>
        /// </summary>
        [GodotMethod("set_use_file_access_save_and_swap")]
        public static void SetUseFileAccessSaveAndSwap(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_144, ptr, enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_145 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "alert");

        /// <summary>
        /// <para>Displays a modal dialog box using the host OS' facilities. Execution is blocked until the dialog is closed.</para>
        /// </summary>
        [GodotMethod("alert")]
        public static void Alert(string text, string title = "Alert!")
        {
            NativeCalls.godot_icall_2_107(method_bind_145, ptr, text, title);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_146 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "crash");

        /// <summary>
        /// <para>Crashes the engine (or the editor if called within a <c>tool</c> script). This should only be used for testing the system's crash handler, not for any other purpose. For general error reporting, use (in order of preference) <c>@GDScript.assert</c>, <c>@GDScript.push_error</c> or <see cref="Godot.OS.Alert"/>. See also <see cref="Godot.OS.Kill"/>.</para>
        /// </summary>
        [GodotMethod("crash")]
        public static void Crash(string message)
        {
            NativeCalls.godot_icall_1_54(method_bind_146, ptr, message);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_147 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_thread_name");

        /// <summary>
        /// <para>Sets the name of the current thread.</para>
        /// </summary>
        [GodotMethod("set_thread_name")]
        public static Error SetThreadName(string name)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_147, ptr, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_148 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_thread_caller_id");

        /// <summary>
        /// <para>Returns the ID of the current thread. This can be used in logs to ease debugging of multi-threaded applications.</para>
        /// <para>Note: Thread IDs are not deterministic and may be reused across application restarts.</para>
        /// </summary>
        [GodotMethod("get_thread_caller_id")]
        public static ulong GetThreadCallerId()
        {
            return NativeCalls.godot_icall_0_30(method_bind_148, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_149 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_main_thread_id");

        /// <summary>
        /// <para>Returns the ID of the main thread. See <see cref="Godot.OS.GetThreadCallerId"/>.</para>
        /// <para>Note: Thread IDs are not deterministic and may be reused across application restarts.</para>
        /// </summary>
        [GodotMethod("get_main_thread_id")]
        public static ulong GetMainThreadId()
        {
            return NativeCalls.godot_icall_0_30(method_bind_149, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_150 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_vsync");

        [GodotMethod("set_use_vsync")]
        [Obsolete("SetUseVsync is deprecated. Use the VsyncEnabled property instead.")]
        public static void SetUseVsync(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_150, ptr, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_151 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_vsync_enabled");

        [GodotMethod("is_vsync_enabled")]
        [Obsolete("IsVsyncEnabled is deprecated. Use the VsyncEnabled property instead.")]
        public static bool IsVsyncEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_151, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_152 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_vsync_via_compositor");

        [GodotMethod("set_vsync_via_compositor")]
        [Obsolete("SetVsyncViaCompositor is deprecated. Use the VsyncViaCompositor property instead.")]
        public static void SetVsyncViaCompositor(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_152, ptr, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_153 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_vsync_via_compositor_enabled");

        [GodotMethod("is_vsync_via_compositor_enabled")]
        [Obsolete("IsVsyncViaCompositorEnabled is deprecated. Use the VsyncViaCompositor property instead.")]
        public static bool IsVsyncViaCompositorEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_153, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_154 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_delta_smoothing");

        [GodotMethod("set_delta_smoothing")]
        [Obsolete("SetDeltaSmoothing is deprecated. Use the DeltaSmoothing property instead.")]
        public static void SetDeltaSmoothing(bool deltaSmoothingEnabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_154, ptr, deltaSmoothingEnabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_155 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_delta_smoothing_enabled");

        [GodotMethod("is_delta_smoothing_enabled")]
        [Obsolete("IsDeltaSmoothingEnabled is deprecated. Use the DeltaSmoothing property instead.")]
        public static bool IsDeltaSmoothingEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_155, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_156 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_feature");

        /// <summary>
        /// <para>Returns <c>true</c> if the feature for the given feature tag is supported in the currently running instance, depending on the platform, build etc. Can be used to check whether you're currently running a debug build, on a certain platform or arch, etc. Refer to the <a href="$DOCS_URL/tutorials/export/feature_tags.html">Feature Tags</a> documentation for more details.</para>
        /// <para>Note: Tag names are case-sensitive.</para>
        /// </summary>
        [GodotMethod("has_feature")]
        public static bool HasFeature(string tagName)
        {
            return NativeCalls.godot_icall_1_108(method_bind_156, ptr, tagName);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_157 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_power_state");

        /// <summary>
        /// <para>Returns the current state of the device regarding battery and power. See <see cref="Godot.OS.PowerState"/> constants.</para>
        /// <para>Note: This method is implemented on Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("get_power_state")]
        public static OS.PowerState GetPowerState()
        {
            return (OS.PowerState)NativeCalls.godot_icall_0_1221(method_bind_157, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_158 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_power_seconds_left");

        /// <summary>
        /// <para>Returns an estimate of the time left in seconds before the device runs out of battery. Returns <c>-1</c> if power state is unknown.</para>
        /// <para>Note: This method is implemented on Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("get_power_seconds_left")]
        public static int GetPowerSecondsLeft()
        {
            return NativeCalls.godot_icall_0_5(method_bind_158, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_159 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_power_percent_left");

        /// <summary>
        /// <para>Returns the amount of battery left in the device as a percentage. Returns <c>-1</c> if power state is unknown.</para>
        /// <para>Note: This method is implemented on Linux, macOS and Windows.</para>
        /// </summary>
        [GodotMethod("get_power_percent_left")]
        public static int GetPowerPercentLeft()
        {
            return NativeCalls.godot_icall_0_5(method_bind_159, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_160 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "request_permission");

        /// <summary>
        /// <para>At the moment this function is only used by <c>AudioDriverOpenSL</c> to request permission for <c>RECORD_AUDIO</c> on Android.</para>
        /// </summary>
        [GodotMethod("request_permission")]
        public static bool RequestPermission(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_160, ptr, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_161 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "request_permissions");

        /// <summary>
        /// <para>With this function, you can request dangerous permissions since normal permissions are automatically granted at install time in Android applications.</para>
        /// <para>Note: This method is implemented on Android.</para>
        /// </summary>
        [GodotMethod("request_permissions")]
        public static bool RequestPermissions()
        {
            return NativeCalls.godot_icall_0_7(method_bind_161, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_162 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_granted_permissions");

        /// <summary>
        /// <para>With this function, you can get the list of dangerous permissions that have been granted to the Android application.</para>
        /// <para>Note: This method is implemented on Android.</para>
        /// </summary>
        [GodotMethod("get_granted_permissions")]
        public static string[] GetGrantedPermissions()
        {
            return NativeCalls.godot_icall_0_119(method_bind_162, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_163 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tablet_driver_count");

        /// <summary>
        /// <para>Returns the total number of available tablet drivers.</para>
        /// <para>Note: This method is implemented on Windows.</para>
        /// </summary>
        [GodotMethod("get_tablet_driver_count")]
        public static int GetTabletDriverCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_163, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_164 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tablet_driver_name");

        /// <summary>
        /// <para>Returns the tablet driver name for the given index.</para>
        /// <para>Note: This method is implemented on Windows.</para>
        /// </summary>
        [GodotMethod("get_tablet_driver_name")]
        public static string GetTabletDriverName(int idx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_164, ptr, idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_165 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_tablet_driver");

        [GodotMethod("get_current_tablet_driver")]
        [Obsolete("GetCurrentTabletDriver is deprecated. Use the TabletDriver property instead.")]
        public static string GetCurrentTabletDriver()
        {
            return NativeCalls.godot_icall_0_6(method_bind_165, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_166 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_current_tablet_driver");

        [GodotMethod("set_current_tablet_driver")]
        [Obsolete("SetCurrentTabletDriver is deprecated. Use the TabletDriver property instead.")]
        public static void SetCurrentTabletDriver(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_166, ptr, name);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
