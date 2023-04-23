using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>As one of the most important classes, the <see cref="Godot.SceneTree"/> manages the hierarchy of nodes in a scene as well as scenes themselves. Nodes can be added, retrieved and removed. The whole scene tree (and thus the current scene) can be paused. Scenes can be loaded, switched and reloaded.</para>
    /// <para>You can also use the <see cref="Godot.SceneTree"/> to organize your nodes into groups: every node can be assigned as many groups as you want to create, e.g. an "enemy" group. You can then iterate these groups or even call methods and set properties on all the group's members at once.</para>
    /// <para><see cref="Godot.SceneTree"/> is the default <see cref="Godot.MainLoop"/> implementation used by scenes, and is thus in charge of the game loop.</para>
    /// </summary>
    public partial class SceneTree : MainLoop
    {
        public enum StretchAspect
        {
            /// <summary>
            /// <para>Fill the window with the content stretched to cover excessive space. Content may appear stretched.</para>
            /// </summary>
            Ignore = 0,
            /// <summary>
            /// <para>Retain the same aspect ratio by padding with black bars on either axis. This prevents distortion.</para>
            /// </summary>
            Keep = 1,
            /// <summary>
            /// <para>Expand vertically. Left/right black bars may appear if the window is too wide.</para>
            /// </summary>
            KeepWidth = 2,
            /// <summary>
            /// <para>Expand horizontally. Top/bottom black bars may appear if the window is too tall.</para>
            /// </summary>
            KeepHeight = 3,
            /// <summary>
            /// <para>Expand in both directions, retaining the same aspect ratio. This prevents distortion while avoiding black bars.</para>
            /// </summary>
            Expand = 4
        }

        public enum GroupCallFlags
        {
            /// <summary>
            /// <para>Call a group with no flags (default).</para>
            /// </summary>
            Default = 0,
            /// <summary>
            /// <para>Call a group in reverse scene order.</para>
            /// </summary>
            Reverse = 1,
            /// <summary>
            /// <para>Call a group immediately (calls are normally made on idle).</para>
            /// </summary>
            Realtime = 2,
            /// <summary>
            /// <para>Call a group only once even if the call is executed many times.</para>
            /// <para>Note: Arguments are not taken into account when deciding whether the call is unique or not. Therefore when the same method is called with different arguments, only the first call will be performed.</para>
            /// </summary>
            Unique = 4
        }

        public enum StretchMode
        {
            /// <summary>
            /// <para>No stretching.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>Render stretching in higher resolution (interpolated).</para>
            /// </summary>
            Mode2d = 1,
            /// <summary>
            /// <para>Keep the specified display resolution. No interpolation. Content may appear pixelated.</para>
            /// </summary>
            Viewport = 2
        }

        /// <summary>
        /// <para>If <c>true</c>, the application automatically accepts quitting.</para>
        /// <para>For mobile platforms, see <see cref="Godot.SceneTree.QuitOnGoBack"/>.</para>
        /// </summary>
        public bool AutoAcceptQuit
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsAutoAcceptQuit();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAutoAcceptQuit(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the application quits automatically on going back (e.g. on Android).</para>
        /// <para>To handle 'Go Back' button when this option is disabled, use <see cref="Godot.MainLoop.NotificationWmGoBackRequest"/>.</para>
        /// </summary>
        public bool QuitOnGoBack
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsQuitOnGoBack();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetQuitOnGoBack(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, collision shapes will be visible when running the game from the editor for debugging purposes.</para>
        /// <para>Note: This property is not designed to be changed at run-time. Changing the value of <see cref="Godot.SceneTree.DebugCollisionsHint"/> while the project is running will not have the desired effect.</para>
        /// </summary>
        public bool DebugCollisionsHint
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDebuggingCollisionsHint();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDebugCollisionsHint(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, navigation polygons will be visible when running the game from the editor for debugging purposes.</para>
        /// <para>Note: This property is not designed to be changed at run-time. Changing the value of <see cref="Godot.SceneTree.DebugNavigationHint"/> while the project is running will not have the desired effect.</para>
        /// </summary>
        public bool DebugNavigationHint
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDebuggingNavigationHint();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDebugNavigationHint(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the <see cref="Godot.SceneTree"/> is paused. Doing so will have the following behavior:</para>
        /// <para>- 2D and 3D physics will be stopped. This includes signals and collision detection.</para>
        /// <para>- <see cref="Godot.Node._Process"/>, <see cref="Godot.Node._PhysicsProcess"/> and <see cref="Godot.Node._Input"/> will not be called anymore in nodes.</para>
        /// </summary>
        public bool Paused
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsPaused();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPause(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the <see cref="Godot.SceneTree"/>'s <see cref="Godot.SceneTree.NetworkPeer"/> refuses new incoming connections.</para>
        /// </summary>
        public bool RefuseNewNetworkConnections
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsRefusingNewNetworkConnections();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRefuseNewNetworkConnections(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, font oversampling is enabled. This means that <see cref="Godot.DynamicFont"/>s will be rendered at higher or lower size than configured based on the viewport's scaling ratio. For example, in a viewport scaled with a factor 1.5, a font configured with size 14 would be rendered with size 21 (<c>14 * 1.5</c>).</para>
        /// <para>Note: Font oversampling is only used if the viewport stretch mode is <see cref="Godot.SceneTree.StretchMode.Viewport"/>, and if the stretch aspect mode is different from <see cref="Godot.SceneTree.StretchAspect.Ignore"/>.</para>
        /// <para>Note: This property is set automatically for the active <see cref="Godot.SceneTree"/> when the project starts based on the configuration of <c>rendering/quality/dynamic_fonts/use_oversampling</c> in <see cref="Godot.ProjectSettings"/>. The property can however be overridden at runtime as needed.</para>
        /// </summary>
        public bool UseFontOversampling
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUsingFontOversampling();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseFontOversampling(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The root of the edited scene.</para>
        /// </summary>
        public Node EditedSceneRoot
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEditedSceneRoot();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEditedSceneRoot(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The current scene.</para>
        /// </summary>
        public Node CurrentScene
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCurrentScene();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCurrentScene(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The peer object to handle the RPC system (effectively enabling networking when set). Depending on the peer itself, the <see cref="Godot.SceneTree"/> will become a network server (check with <see cref="Godot.SceneTree.IsNetworkServer"/>) and will set the root node's network mode to master, or it will become a regular peer with the root node set to puppet. All child nodes are set to inherit the network mode by default. Handling of networking-related events (connection, disconnection, new clients) is done by connecting to <see cref="Godot.SceneTree"/>'s signals.</para>
        /// </summary>
        public NetworkedMultiplayerPeer NetworkPeer
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNetworkPeer();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetNetworkPeer(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The <see cref="Godot.SceneTree"/>'s root <see cref="Godot.Viewport"/>.</para>
        /// </summary>
        public Viewport Root
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRoot();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The default <see cref="Godot.MultiplayerAPI"/> instance for this <see cref="Godot.SceneTree"/>.</para>
        /// </summary>
        public MultiplayerAPI Multiplayer
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMultiplayer();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMultiplayer(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c> (default value), enables automatic polling of the <see cref="Godot.MultiplayerAPI"/> for this SceneTree during <c>idle_frame</c>.</para>
        /// <para>If <c>false</c>, you need to manually call <see cref="Godot.MultiplayerAPI.Poll"/> to process network packets and deliver RPCs/RSETs. This allows running RPCs/RSETs in a different loop (e.g. physics, thread, specific time step) and for manual <see cref="Godot.Mutex"/> protection when accessing the <see cref="Godot.MultiplayerAPI"/> from threads.</para>
        /// </summary>
        public bool MultiplayerPoll
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsMultiplayerPollEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMultiplayerPollEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Although physics interpolation would normally be globally turned on and off using , this property allows control over interpolation at runtime.</para>
        /// </summary>
        public bool PhysicsInterpolation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsPhysicsInterpolationEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPhysicsInterpolationEnabled(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "SceneTree";

        public SceneTree() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_SceneTree_Ctor(this);
        }

        internal SceneTree(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_root");

        [GodotMethod("get_root")]
        [Obsolete("GetRoot is deprecated. Use the Root property instead.")]
        public Viewport GetRoot()
        {
            return NativeCalls.godot_icall_0_684(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_group");

        /// <summary>
        /// <para>Returns <c>true</c> if the given group exists.</para>
        /// </summary>
        [GodotMethod("has_group")]
        public bool HasGroup(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_1, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_auto_accept_quit");

        [GodotMethod("is_auto_accept_quit")]
        [Obsolete("IsAutoAcceptQuit is deprecated. Use the AutoAcceptQuit property instead.")]
        public bool IsAutoAcceptQuit()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_auto_accept_quit");

        [GodotMethod("set_auto_accept_quit")]
        [Obsolete("SetAutoAcceptQuit is deprecated. Use the AutoAcceptQuit property instead.")]
        public void SetAutoAcceptQuit(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_3, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_quit_on_go_back");

        [GodotMethod("is_quit_on_go_back")]
        [Obsolete("IsQuitOnGoBack is deprecated. Use the QuitOnGoBack property instead.")]
        public bool IsQuitOnGoBack()
        {
            return NativeCalls.godot_icall_0_7(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_quit_on_go_back");

        [GodotMethod("set_quit_on_go_back")]
        [Obsolete("SetQuitOnGoBack is deprecated. Use the QuitOnGoBack property instead.")]
        public void SetQuitOnGoBack(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_5, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_debug_collisions_hint");

        [GodotMethod("set_debug_collisions_hint")]
        [Obsolete("SetDebugCollisionsHint is deprecated. Use the DebugCollisionsHint property instead.")]
        public void SetDebugCollisionsHint(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_debugging_collisions_hint");

        [GodotMethod("is_debugging_collisions_hint")]
        [Obsolete("IsDebuggingCollisionsHint is deprecated. Use the DebugCollisionsHint property instead.")]
        public bool IsDebuggingCollisionsHint()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_debug_navigation_hint");

        [GodotMethod("set_debug_navigation_hint")]
        [Obsolete("SetDebugNavigationHint is deprecated. Use the DebugNavigationHint property instead.")]
        public void SetDebugNavigationHint(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_8, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_debugging_navigation_hint");

        [GodotMethod("is_debugging_navigation_hint")]
        [Obsolete("IsDebuggingNavigationHint is deprecated. Use the DebugNavigationHint property instead.")]
        public bool IsDebuggingNavigationHint()
        {
            return NativeCalls.godot_icall_0_7(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_edited_scene_root");

        [GodotMethod("set_edited_scene_root")]
        [Obsolete("SetEditedSceneRoot is deprecated. Use the EditedSceneRoot property instead.")]
        public void SetEditedSceneRoot(Node scene)
        {
            NativeCalls.godot_icall_1_53(method_bind_10, Object.GetPtr(this), Object.GetPtr(scene));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_edited_scene_root");

        [GodotMethod("get_edited_scene_root")]
        [Obsolete("GetEditedSceneRoot is deprecated. Use the EditedSceneRoot property instead.")]
        public Node GetEditedSceneRoot()
        {
            return NativeCalls.godot_icall_0_257(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pause");

        [GodotMethod("set_pause")]
        [Obsolete("SetPause is deprecated. Use the Paused property instead.")]
        public void SetPause(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_12, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_paused");

        [GodotMethod("is_paused")]
        [Obsolete("IsPaused is deprecated. Use the Paused property instead.")]
        public bool IsPaused()
        {
            return NativeCalls.godot_icall_0_7(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_input_as_handled");

        /// <summary>
        /// <para>Marks the most recent <see cref="Godot.InputEvent"/> as handled.</para>
        /// </summary>
        [GodotMethod("set_input_as_handled")]
        public void SetInputAsHandled()
        {
            NativeCalls.godot_icall_0_3(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_input_handled");

        /// <summary>
        /// <para>Returns <c>true</c> if the most recent <see cref="Godot.InputEvent"/> was marked as handled with <see cref="Godot.SceneTree.SetInputAsHandled"/>.</para>
        /// </summary>
        [GodotMethod("is_input_handled")]
        public bool IsInputHandled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_timer");

        /// <summary>
        /// <para>Returns a <see cref="Godot.SceneTreeTimer"/> which will <c>SceneTreeTimer.timeout</c> after the given time in seconds elapsed in this <see cref="Godot.SceneTree"/>. If <c>pause_mode_process</c> is set to <c>false</c>, pausing the <see cref="Godot.SceneTree"/> will also pause the timer.</para>
        /// <para>Commonly used to create a one-shot delay timer as in the following example:</para>
        /// <para><code>
        /// func some_function():
        ///     print("start")
        ///     yield(get_tree().create_timer(1.0), "timeout")
        ///     print("end")
        /// </code></para>
        /// <para>The timer will be automatically freed after its time elapses.</para>
        /// </summary>
        [GodotMethod("create_timer")]
        public SceneTreeTimer CreateTimer(float timeSec, bool pauseModeProcess = true)
        {
            return NativeCalls.godot_icall_2_833(method_bind_16, Object.GetPtr(this), timeSec, pauseModeProcess);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_tween");

        /// <summary>
        /// <para>Creates and returns a new <see cref="Godot.SceneTreeTween"/>.</para>
        /// </summary>
        [GodotMethod("create_tween")]
        public SceneTreeTween CreateTween()
        {
            return NativeCalls.godot_icall_0_683(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_processed_tweens");

        /// <summary>
        /// <para>Returns an array of currently existing <see cref="Godot.SceneTreeTween"/>s in the <see cref="Godot.SceneTree"/> (both running and paused).</para>
        /// </summary>
        [GodotMethod("get_processed_tweens")]
        public Godot.Collections.Array GetProcessedTweens()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_18, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_count");

        /// <summary>
        /// <para>Returns the number of nodes in this <see cref="Godot.SceneTree"/>.</para>
        /// </summary>
        [GodotMethod("get_node_count")]
        public int GetNodeCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_frame");

        /// <summary>
        /// <para>Returns the current frame number, i.e. the total frame count since the application started.</para>
        /// </summary>
        [GodotMethod("get_frame")]
        public long GetFrame()
        {
            return NativeCalls.godot_icall_0_165(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "quit");

        /// <summary>
        /// <para>Quits the application at the end of the current iteration. A process <c>exit_code</c> can optionally be passed as an argument. If this argument is <c>0</c> or greater, it will override the <see cref="Godot.OS.ExitCode"/> defined before quitting the application.</para>
        /// <para>Note: On iOS this method doesn't work. Instead, as recommended by the iOS Human Interface Guidelines, the user is expected to close apps via the Home button.</para>
        /// </summary>
        [GodotMethod("quit")]
        public void Quit(int exitCode = -1)
        {
            NativeCalls.godot_icall_1_4(method_bind_21, Object.GetPtr(this), exitCode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_screen_stretch");

        /// <summary>
        /// <para>Configures screen stretching to the given <see cref="Godot.SceneTree.StretchMode"/>, <see cref="Godot.SceneTree.StretchAspect"/>, minimum size and <c>scale</c>.</para>
        /// </summary>
        [GodotMethod("set_screen_stretch")]
        public void SetScreenStretch(SceneTree.StretchMode mode, SceneTree.StretchAspect aspect, Vector2 minsize, float scale = (float)1)
        {
            NativeCalls.godot_icall_4_834(method_bind_22, Object.GetPtr(this), (int)mode, (int)aspect, ref minsize, scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_physics_interpolation_enabled");

        [GodotMethod("set_physics_interpolation_enabled")]
        [Obsolete("SetPhysicsInterpolationEnabled is deprecated. Use the PhysicsInterpolation property instead.")]
        public void SetPhysicsInterpolationEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_23, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_physics_interpolation_enabled");

        [GodotMethod("is_physics_interpolation_enabled")]
        [Obsolete("IsPhysicsInterpolationEnabled is deprecated. Use the PhysicsInterpolation property instead.")]
        public bool IsPhysicsInterpolationEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "queue_delete");

        /// <summary>
        /// <para>Queues the given object for deletion, delaying the call to <see cref="Godot.Object.Free"/> to after the current frame.</para>
        /// </summary>
        [GodotMethod("queue_delete")]
        public void QueueDelete(Object obj)
        {
            NativeCalls.godot_icall_1_53(method_bind_25, Object.GetPtr(this), Object.GetPtr(obj));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "call_group_flags");

        /// <summary>
        /// <para>Calls <c>method</c> on each member of the given group, respecting the given <see cref="Godot.SceneTree.GroupCallFlags"/>. You can pass arguments to <c>method</c> by specifying them at the end of the method call.</para>
        /// <para>Note: <c>method</c> may only have 5 arguments at most (8 arguments passed to this method in total).</para>
        /// <para>Note: Due to design limitations, <see cref="Godot.SceneTree.CallGroupFlags"/> will fail silently if one of the arguments is <c>null</c>.</para>
        /// <para><code>
        /// # Call the method immediately and in reverse order.
        /// get_tree().call_group_flags(SceneTree.GROUP_CALL_REALTIME | SceneTree.GROUP_CALL_REVERSE, "bases", "destroy")
        /// </code></para>
        /// </summary>
        [GodotMethod("call_group_flags")]
        public object CallGroupFlags(int flags, string group, string method, params object[] @args)
        {
            return NativeCalls.godot_icall_4_835(method_bind_26, Object.GetPtr(this), flags, group, method, @args);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "notify_group_flags");

        /// <summary>
        /// <para>Sends the given notification to all members of the <c>group</c>, respecting the given <see cref="Godot.SceneTree.GroupCallFlags"/>.</para>
        /// </summary>
        [GodotMethod("notify_group_flags")]
        public void NotifyGroupFlags(uint callFlags, string group, int notification)
        {
            NativeCalls.godot_icall_3_836(method_bind_27, Object.GetPtr(this), callFlags, group, notification);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_group_flags");

        /// <summary>
        /// <para>Sets the given <c>property</c> to <c>value</c> on all members of the given group, respecting the given <see cref="Godot.SceneTree.GroupCallFlags"/>.</para>
        /// </summary>
        [GodotMethod("set_group_flags")]
        public void SetGroupFlags(uint callFlags, string group, string property, object value)
        {
            NativeCalls.godot_icall_4_837(method_bind_28, Object.GetPtr(this), callFlags, group, property, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "call_group");

        /// <summary>
        /// <para>Calls <c>method</c> on each member of the given group. You can pass arguments to <c>method</c> by specifying them at the end of the method call. This method is equivalent of calling <see cref="Godot.SceneTree.CallGroupFlags"/> with <see cref="Godot.SceneTree.GroupCallFlags.Default"/> flag.</para>
        /// <para>Note: <c>method</c> may only have 5 arguments at most (7 arguments passed to this method in total).</para>
        /// <para>Note: Due to design limitations, <see cref="Godot.SceneTree.CallGroup"/> will fail silently if one of the arguments is <c>null</c>.</para>
        /// <para>Note: <see cref="Godot.SceneTree.CallGroup"/> will always call methods with an one-frame delay, in a way similar to <see cref="Godot.Object.CallDeferred"/>. To call methods immediately, use <see cref="Godot.SceneTree.CallGroupFlags"/> with the <see cref="Godot.SceneTree.GroupCallFlags.Realtime"/> flag.</para>
        /// </summary>
        [GodotMethod("call_group")]
        public object CallGroup(string group, string method, params object[] @args)
        {
            return NativeCalls.godot_icall_3_838(method_bind_29, Object.GetPtr(this), group, method, @args);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "notify_group");

        /// <summary>
        /// <para>Sends the given notification to all members of the <c>group</c>.</para>
        /// </summary>
        [GodotMethod("notify_group")]
        public void NotifyGroup(string group, int notification)
        {
            NativeCalls.godot_icall_2_110(method_bind_30, Object.GetPtr(this), group, notification);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_group");

        /// <summary>
        /// <para>Sets the given <c>property</c> to <c>value</c> on all members of the given group.</para>
        /// </summary>
        [GodotMethod("set_group")]
        public void SetGroup(string group, string property, object value)
        {
            NativeCalls.godot_icall_3_307(method_bind_31, Object.GetPtr(this), group, property, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_nodes_in_group");

        /// <summary>
        /// <para>Returns a list of all nodes assigned to the given group.</para>
        /// </summary>
        [GodotMethod("get_nodes_in_group")]
        public Godot.Collections.Array GetNodesInGroup(string group)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_1_534(method_bind_32, Object.GetPtr(this), group));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_current_scene");

        [GodotMethod("set_current_scene")]
        [Obsolete("SetCurrentScene is deprecated. Use the CurrentScene property instead.")]
        public void SetCurrentScene(Node childNode)
        {
            NativeCalls.godot_icall_1_53(method_bind_33, Object.GetPtr(this), Object.GetPtr(childNode));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_scene");

        [GodotMethod("get_current_scene")]
        [Obsolete("GetCurrentScene is deprecated. Use the CurrentScene property instead.")]
        public Node GetCurrentScene()
        {
            return NativeCalls.godot_icall_0_257(method_bind_34, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "change_scene");

        /// <summary>
        /// <para>Changes the running scene to the one at the given <c>path</c>, after loading it into a <see cref="Godot.PackedScene"/> and creating a new instance.</para>
        /// <para>Returns <c>OK</c> on success, <c>ERR_CANT_OPEN</c> if the <c>path</c> cannot be loaded into a <see cref="Godot.PackedScene"/>, or <c>ERR_CANT_CREATE</c> if that scene cannot be instantiated.</para>
        /// <para>Note: The scene change is deferred, which means that the new scene node is added on the next idle frame. You won't be able to access it immediately after the <see cref="Godot.SceneTree.ChangeScene"/> call.</para>
        /// </summary>
        [GodotMethod("change_scene")]
        public Error ChangeScene(string path)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_35, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "change_scene_to");

        /// <summary>
        /// <para>Changes the running scene to a new instance of the given <see cref="Godot.PackedScene"/>.</para>
        /// <para>Returns <c>OK</c> on success or <c>ERR_CANT_CREATE</c> if the scene cannot be instantiated.</para>
        /// <para>Note: The scene change is deferred, which means that the new scene node is added on the next idle frame. You won't be able to access it immediately after the <see cref="Godot.SceneTree.ChangeSceneTo"/> call.</para>
        /// <para>Note: Passing a value of <c>null</c> into the method will unload the current scene without loading a new one.</para>
        /// </summary>
        [GodotMethod("change_scene_to")]
        public Error ChangeSceneTo(PackedScene packedScene)
        {
            return (Error)NativeCalls.godot_icall_1_598(method_bind_36, Object.GetPtr(this), Object.GetPtr(packedScene));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reload_current_scene");

        /// <summary>
        /// <para>Reloads the currently active scene.</para>
        /// <para>Returns <c>OK</c> on success, <c>ERR_UNCONFIGURED</c> if no <see cref="Godot.SceneTree.CurrentScene"/> was defined yet, <c>ERR_CANT_OPEN</c> if <see cref="Godot.SceneTree.CurrentScene"/> cannot be loaded into a <see cref="Godot.PackedScene"/>, or <c>ERR_CANT_CREATE</c> if the scene cannot be instantiated.</para>
        /// </summary>
        [GodotMethod("reload_current_scene")]
        public Error ReloadCurrentScene()
        {
            return (Error)NativeCalls.godot_icall_0_389(method_bind_37, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_multiplayer");

        [GodotMethod("set_multiplayer")]
        [Obsolete("SetMultiplayer is deprecated. Use the Multiplayer property instead.")]
        public void SetMultiplayer(MultiplayerAPI multiplayer)
        {
            NativeCalls.godot_icall_1_24(method_bind_38, Object.GetPtr(this), Object.GetPtr(multiplayer));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_multiplayer");

        [GodotMethod("get_multiplayer")]
        [Obsolete("GetMultiplayer is deprecated. Use the Multiplayer property instead.")]
        public MultiplayerAPI GetMultiplayer()
        {
            return NativeCalls.godot_icall_0_685(method_bind_39, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_multiplayer_poll_enabled");

        [GodotMethod("set_multiplayer_poll_enabled")]
        [Obsolete("SetMultiplayerPollEnabled is deprecated. Use the MultiplayerPoll property instead.")]
        public void SetMultiplayerPollEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_40, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_multiplayer_poll_enabled");

        [GodotMethod("is_multiplayer_poll_enabled")]
        [Obsolete("IsMultiplayerPollEnabled is deprecated. Use the MultiplayerPoll property instead.")]
        public bool IsMultiplayerPollEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_41, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_network_peer");

        [GodotMethod("set_network_peer")]
        [Obsolete("SetNetworkPeer is deprecated. Use the NetworkPeer property instead.")]
        public void SetNetworkPeer(NetworkedMultiplayerPeer peer)
        {
            NativeCalls.godot_icall_1_24(method_bind_42, Object.GetPtr(this), Object.GetPtr(peer));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_network_peer");

        [GodotMethod("get_network_peer")]
        [Obsolete("GetNetworkPeer is deprecated. Use the NetworkPeer property instead.")]
        public NetworkedMultiplayerPeer GetNetworkPeer()
        {
            return NativeCalls.godot_icall_0_622(method_bind_43, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_network_server");

        /// <summary>
        /// <para>Returns <c>true</c> if this <see cref="Godot.SceneTree"/>'s <see cref="Godot.SceneTree.NetworkPeer"/> is in server mode (listening for connections).</para>
        /// </summary>
        [GodotMethod("is_network_server")]
        public bool IsNetworkServer()
        {
            return NativeCalls.godot_icall_0_7(method_bind_44, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_network_peer");

        /// <summary>
        /// <para>Returns <c>true</c> if there is a <see cref="Godot.SceneTree.NetworkPeer"/> set.</para>
        /// </summary>
        [GodotMethod("has_network_peer")]
        public bool HasNetworkPeer()
        {
            return NativeCalls.godot_icall_0_7(method_bind_45, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_network_connected_peers");

        /// <summary>
        /// <para>Returns the peer IDs of all connected peers of this <see cref="Godot.SceneTree"/>'s <see cref="Godot.SceneTree.NetworkPeer"/>.</para>
        /// </summary>
        [GodotMethod("get_network_connected_peers")]
        public int[] GetNetworkConnectedPeers()
        {
            return NativeCalls.godot_icall_0_103(method_bind_46, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_network_unique_id");

        /// <summary>
        /// <para>Returns the unique peer ID of this <see cref="Godot.SceneTree"/>'s <see cref="Godot.SceneTree.NetworkPeer"/>.</para>
        /// </summary>
        [GodotMethod("get_network_unique_id")]
        public int GetNetworkUniqueId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_47, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rpc_sender_id");

        /// <summary>
        /// <para>Returns the sender's peer ID for the most recently received RPC call.</para>
        /// </summary>
        [GodotMethod("get_rpc_sender_id")]
        public int GetRpcSenderId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_48, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_refuse_new_network_connections");

        [GodotMethod("set_refuse_new_network_connections")]
        [Obsolete("SetRefuseNewNetworkConnections is deprecated. Use the RefuseNewNetworkConnections property instead.")]
        public void SetRefuseNewNetworkConnections(bool refuse)
        {
            NativeCalls.godot_icall_1_16(method_bind_49, Object.GetPtr(this), refuse);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_refusing_new_network_connections");

        [GodotMethod("is_refusing_new_network_connections")]
        [Obsolete("IsRefusingNewNetworkConnections is deprecated. Use the RefuseNewNetworkConnections property instead.")]
        public bool IsRefusingNewNetworkConnections()
        {
            return NativeCalls.godot_icall_0_7(method_bind_50, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_font_oversampling");

        [GodotMethod("set_use_font_oversampling")]
        [Obsolete("SetUseFontOversampling is deprecated. Use the UseFontOversampling property instead.")]
        public void SetUseFontOversampling(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_51, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_using_font_oversampling");

        [GodotMethod("is_using_font_oversampling")]
        [Obsolete("IsUsingFontOversampling is deprecated. Use the UseFontOversampling property instead.")]
        public bool IsUsingFontOversampling()
        {
            return NativeCalls.godot_icall_0_7(method_bind_52, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
