using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The <see cref="Godot.Engine"/> singleton allows you to query and modify the project's run-time parameters, such as frames per second, time scale, and others.</para>
    /// </summary>
    public static partial class Engine
    {
        /// <summary>
        /// <para>If <c>true</c>, the script is currently running inside the editor. This is useful for <c>tool</c> scripts to conditionally draw editor helpers, or prevent accidentally running "game" code that would affect the scene state while in the editor:</para>
        /// <para><code>
        /// if Engine.editor_hint:
        ///     draw_gizmos()
        /// else:
        ///     simulate_physics()
        /// </code></para>
        /// <para>See <a href="$DOCS_URL/tutorials/plugins/running_code_in_the_editor.html">Running code in the editor</a> in the documentation for more information.</para>
        /// <para>Note: To detect whether the script is run from an editor build (e.g. when pressing <c>F5</c>), use <see cref="Godot.OS.HasFeature"/> with the <c>"editor"</c> argument instead. <c>OS.has_feature("editor")</c> will evaluate to <c>true</c> both when the code is running in the editor and when running the project from the editor, but it will evaluate to <c>false</c> when the code is run from an exported project.</para>
        /// </summary>
        public static bool EditorHint
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsEditorHint();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEditorHint(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>false</c>, stops printing error and warning messages to the console and editor Output log. This can be used to hide error and warning messages during unit test suite runs. This property is equivalent to the  project setting.</para>
        /// <para>Warning: If you set this to <c>false</c> anywhere in the project, important error messages may be hidden even if they are emitted from other scripts. If this is set to <c>false</c> in a <c>tool</c> script, this will also impact the editor itself. Do not report bugs before ensuring error messages are enabled (as they are by default).</para>
        /// <para>Note: This property does not impact the editor's Errors tab when running a project from the editor.</para>
        /// </summary>
        public static bool PrintErrorMessages
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsPrintingErrorMessages();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPrintErrorMessages(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The number of fixed iterations per second. This controls how often physics simulation and <see cref="Godot.Node._PhysicsProcess"/> methods are run. This value should generally always be set to <c>60</c> or above, as Godot doesn't interpolate the physics step. As a result, values lower than <c>60</c> will look stuttery. This value can be increased to make input more reactive or work around collision tunneling issues, but keep in mind doing so will increase CPU usage. See also <see cref="Godot.Engine.TargetFps"/> and .</para>
        /// <para>Note: Only 8 physics ticks may be simulated per rendered frame at most. If more than 8 physics ticks have to be simulated per rendered frame to keep up with rendering, the game will appear to slow down (even if <c>delta</c> is used consistently in physics calculations). Therefore, it is recommended not to increase <see cref="Godot.Engine.IterationsPerSecond"/> above 240. Otherwise, the game will slow down when the rendering framerate goes below 30 FPS.</para>
        /// </summary>
        public static int IterationsPerSecond
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetIterationsPerSecond();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetIterationsPerSecond(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The desired frames per second. If the hardware cannot keep up, this setting may not be respected. A value of 0 means no limit.</para>
        /// </summary>
        public static int TargetFps
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTargetFps();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTargetFps(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Controls how fast or slow the in-game clock ticks versus the real life one. It defaults to 1.0. A value of 2.0 means the game moves twice as fast as real life, whilst a value of 0.5 means the game moves at half the regular speed.</para>
        /// </summary>
        public static float TimeScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTimeScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTimeScale(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Controls how much physics ticks are synchronized with real time. For 0 or less, the ticks are synchronized. Such values are recommended for network games, where clock synchronization matters. Higher values cause higher deviation of the in-game clock and real clock but smooth out framerate jitters. The default value of 0.5 should be fine for most; values above 2 could cause the game to react to dropped frames with a noticeable delay and are not recommended.</para>
        /// <para>Note: For best results, when using a custom physics interpolation solution, the physics jitter fix should be disabled by setting <see cref="Godot.Engine.PhysicsJitterFix"/> to <c>0</c>.</para>
        /// </summary>
        public static float PhysicsJitterFix
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPhysicsJitterFix();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPhysicsJitterFix(value);
            }
#pragma warning restore CS0618
        }

        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(Engine).Name);
                return singleton;
            }
        }

        private const string nativeName = "_Engine";
        internal static IntPtr ptr = NativeCalls.godot_icall__Engine_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_iterations_per_second");

        [GodotMethod("set_iterations_per_second")]
        [Obsolete("SetIterationsPerSecond is deprecated. Use the IterationsPerSecond property instead.")]
        public static void SetIterationsPerSecond(int iterationsPerSecond)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, ptr, iterationsPerSecond);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_iterations_per_second");

        [GodotMethod("get_iterations_per_second")]
        [Obsolete("GetIterationsPerSecond is deprecated. Use the IterationsPerSecond property instead.")]
        public static int GetIterationsPerSecond()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_physics_jitter_fix");

        [GodotMethod("set_physics_jitter_fix")]
        [Obsolete("SetPhysicsJitterFix is deprecated. Use the PhysicsJitterFix property instead.")]
        public static void SetPhysicsJitterFix(float physicsJitterFix)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, ptr, physicsJitterFix);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_physics_jitter_fix");

        [GodotMethod("get_physics_jitter_fix")]
        [Obsolete("GetPhysicsJitterFix is deprecated. Use the PhysicsJitterFix property instead.")]
        public static float GetPhysicsJitterFix()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_physics_interpolation_fraction");

        /// <summary>
        /// <para>Returns the fraction through the current physics tick we are at the time of rendering the frame. This can be used to implement fixed timestep interpolation.</para>
        /// </summary>
        [GodotMethod("get_physics_interpolation_fraction")]
        public static float GetPhysicsInterpolationFraction()
        {
            return NativeCalls.godot_icall_0_14(method_bind_4, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_target_fps");

        [GodotMethod("set_target_fps")]
        [Obsolete("SetTargetFps is deprecated. Use the TargetFps property instead.")]
        public static void SetTargetFps(int targetFps)
        {
            NativeCalls.godot_icall_1_4(method_bind_5, ptr, targetFps);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_target_fps");

        [GodotMethod("get_target_fps")]
        [Obsolete("GetTargetFps is deprecated. Use the TargetFps property instead.")]
        public static int GetTargetFps()
        {
            return NativeCalls.godot_icall_0_5(method_bind_6, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_time_scale");

        [GodotMethod("set_time_scale")]
        [Obsolete("SetTimeScale is deprecated. Use the TimeScale property instead.")]
        public static void SetTimeScale(float timeScale)
        {
            NativeCalls.godot_icall_1_15(method_bind_7, ptr, timeScale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_time_scale");

        [GodotMethod("get_time_scale")]
        [Obsolete("GetTimeScale is deprecated. Use the TimeScale property instead.")]
        public static float GetTimeScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_8, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_frames_drawn");

        /// <summary>
        /// <para>Returns the total number of frames drawn. On headless platforms, or if the render loop is disabled with <c>--disable-render-loop</c> via command line, <see cref="Godot.Engine.GetFramesDrawn"/> always returns <c>0</c>. See <see cref="Godot.Engine.GetIdleFrames"/>.</para>
        /// </summary>
        [GodotMethod("get_frames_drawn")]
        public static int GetFramesDrawn()
        {
            return NativeCalls.godot_icall_0_5(method_bind_9, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_frames_per_second");

        /// <summary>
        /// <para>Returns the frames per second of the running game.</para>
        /// </summary>
        [GodotMethod("get_frames_per_second")]
        public static float GetFramesPerSecond()
        {
            return NativeCalls.godot_icall_0_14(method_bind_10, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_physics_frames");

        /// <summary>
        /// <para>Returns the total number of frames passed since engine initialization which is advanced on each physics frame. See also <see cref="Godot.Engine.GetIdleFrames"/>.</para>
        /// <para><see cref="Godot.Engine.GetPhysicsFrames"/> can be used to run expensive logic less often without relying on a <see cref="Godot.Timer"/>:</para>
        /// <para><code>
        /// func _physics_process(_delta):
        ///     if Engine.get_physics_frames() % 2 == 0:
        ///         pass  # Run expensive logic only once every 2 physics frames here.
        /// </code></para>
        /// </summary>
        [GodotMethod("get_physics_frames")]
        public static ulong GetPhysicsFrames()
        {
            return NativeCalls.godot_icall_0_30(method_bind_11, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_idle_frames");

        /// <summary>
        /// <para>Returns the total number of frames passed since engine initialization which is advanced on each idle frame, regardless of whether the render loop is enabled. See also <see cref="Godot.Engine.GetFramesDrawn"/> and <see cref="Godot.Engine.GetPhysicsFrames"/>.</para>
        /// <para><see cref="Godot.Engine.GetIdleFrames"/> can be used to run expensive logic less often without relying on a <see cref="Godot.Timer"/>:</para>
        /// <para><code>
        /// func _process(_delta):
        ///     if Engine.get_idle_frames() % 2 == 0:
        ///         pass  # Run expensive logic only once every 2 idle (render) frames here.
        /// </code></para>
        /// </summary>
        [GodotMethod("get_idle_frames")]
        public static ulong GetIdleFrames()
        {
            return NativeCalls.godot_icall_0_30(method_bind_12, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_main_loop");

        /// <summary>
        /// <para>Returns the main loop object (see <see cref="Godot.MainLoop"/> and <see cref="Godot.SceneTree"/>).</para>
        /// </summary>
        [GodotMethod("get_main_loop")]
        public static MainLoop GetMainLoop()
        {
            return NativeCalls.godot_icall_0_1176(method_bind_13, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_version_info");

        /// <summary>
        /// <para>Returns the current engine version information in a Dictionary.</para>
        /// <para><c>major</c>    - Holds the major version number as an int</para>
        /// <para><c>minor</c>    - Holds the minor version number as an int</para>
        /// <para><c>patch</c>    - Holds the patch version number as an int</para>
        /// <para><c>hex</c>      - Holds the full version number encoded as a hexadecimal int with one byte (2 places) per number (see example below)</para>
        /// <para><c>status</c>   - Holds the status (e.g. "beta", "rc1", "rc2", ... "stable") as a String</para>
        /// <para><c>build</c>    - Holds the build name (e.g. "custom_build") as a String</para>
        /// <para><c>hash</c>     - Holds the full Git commit hash as a String</para>
        /// <para><c>year</c>     - Holds the year the version was released in as an int</para>
        /// <para><c>string</c>   - <c>major</c> + <c>minor</c> + <c>patch</c> + <c>status</c> + <c>build</c> in a single String</para>
        /// <para>The <c>hex</c> value is encoded as follows, from left to right: one byte for the major, one byte for the minor, one byte for the patch version. For example, "3.1.12" would be <c>0x03010C</c>. Note: It's still an int internally, and printing it will give you its decimal representation, which is not particularly meaningful. Use hexadecimal literals for easy version comparisons from code:</para>
        /// <para><code>
        /// if Engine.get_version_info().hex &gt;= 0x030200:
        ///     # Do things specific to version 3.2 or later
        /// else:
        ///     # Do things specific to versions before 3.2
        /// </code></para>
        /// </summary>
        [GodotMethod("get_version_info")]
        public static Godot.Collections.Dictionary GetVersionInfo()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_14, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_author_info");

        /// <summary>
        /// <para>Returns engine author information in a Dictionary.</para>
        /// <para><c>lead_developers</c>    - Array of Strings, lead developer names</para>
        /// <para><c>founders</c>           - Array of Strings, founder names</para>
        /// <para><c>project_managers</c>   - Array of Strings, project manager names</para>
        /// <para><c>developers</c>         - Array of Strings, developer names</para>
        /// </summary>
        [GodotMethod("get_author_info")]
        public static Godot.Collections.Dictionary GetAuthorInfo()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_15, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_copyright_info");

        /// <summary>
        /// <para>Returns an Array of copyright information Dictionaries.</para>
        /// <para><c>name</c>    - String, component name</para>
        /// <para><c>parts</c>   - Array of Dictionaries {<c>files</c>, <c>copyright</c>, <c>license</c>} describing subsections of the component</para>
        /// </summary>
        [GodotMethod("get_copyright_info")]
        public static Godot.Collections.Array GetCopyrightInfo()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_16, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_donor_info");

        /// <summary>
        /// <para>Returns a Dictionary of Arrays of donor names.</para>
        /// <para>{<c>platinum_sponsors</c>, <c>gold_sponsors</c>, <c>silver_sponsors</c>, <c>bronze_sponsors</c>, <c>mini_sponsors</c>, <c>gold_donors</c>, <c>silver_donors</c>, <c>bronze_donors</c>}</para>
        /// </summary>
        [GodotMethod("get_donor_info")]
        public static Godot.Collections.Dictionary GetDonorInfo()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_17, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_license_info");

        /// <summary>
        /// <para>Returns Dictionary of licenses used by Godot and included third party components.</para>
        /// </summary>
        [GodotMethod("get_license_info")]
        public static Godot.Collections.Dictionary GetLicenseInfo()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_18, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_license_text");

        /// <summary>
        /// <para>Returns Godot license text.</para>
        /// </summary>
        [GodotMethod("get_license_text")]
        public static string GetLicenseText()
        {
            return NativeCalls.godot_icall_0_6(method_bind_19, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_in_physics_frame");

        /// <summary>
        /// <para>Returns <c>true</c> if the game is inside the fixed process and physics phase of the game loop.</para>
        /// </summary>
        [GodotMethod("is_in_physics_frame")]
        public static bool IsInPhysicsFrame()
        {
            return NativeCalls.godot_icall_0_7(method_bind_20, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_singleton");

        /// <summary>
        /// <para>Returns <c>true</c> if a singleton with given <c>name</c> exists in global scope.</para>
        /// </summary>
        [GodotMethod("has_singleton")]
        public static bool HasSingleton(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_21, ptr, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_singleton");

        /// <summary>
        /// <para>Returns a global singleton with given <c>name</c>. Often used for plugins, e.g. <c>GodotPayment</c> on Android.</para>
        /// </summary>
        [GodotMethod("get_singleton")]
        public static Object GetSingleton(string name)
        {
            return NativeCalls.godot_icall_1_1177(method_bind_22, ptr, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_editor_hint");

        [GodotMethod("set_editor_hint")]
        [Obsolete("SetEditorHint is deprecated. Use the EditorHint property instead.")]
        public static void SetEditorHint(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_23, ptr, enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_editor_hint");

        [GodotMethod("is_editor_hint")]
        [Obsolete("IsEditorHint is deprecated. Use the EditorHint property instead.")]
        public static bool IsEditorHint()
        {
            return NativeCalls.godot_icall_0_7(method_bind_24, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_print_error_messages");

        [GodotMethod("set_print_error_messages")]
        [Obsolete("SetPrintErrorMessages is deprecated. Use the PrintErrorMessages property instead.")]
        public static void SetPrintErrorMessages(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_25, ptr, enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_printing_error_messages");

        [GodotMethod("is_printing_error_messages")]
        [Obsolete("IsPrintingErrorMessages is deprecated. Use the PrintErrorMessages property instead.")]
        public static bool IsPrintingErrorMessages()
        {
            return NativeCalls.godot_icall_0_7(method_bind_26, ptr);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
