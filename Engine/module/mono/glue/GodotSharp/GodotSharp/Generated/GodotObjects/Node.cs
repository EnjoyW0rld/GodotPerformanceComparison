using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Nodes are Godot's building blocks. They can be assigned as the child of another node, resulting in a tree arrangement. A given node can contain any number of nodes as children with the requirement that all siblings (direct children of a node) should have unique names.</para>
    /// <para>A tree of nodes is called a scene. Scenes can be saved to the disk and then instanced into other scenes. This allows for very high flexibility in the architecture and data model of Godot projects.</para>
    /// <para>Scene tree: The <see cref="Godot.SceneTree"/> contains the active tree of nodes. When a node is added to the scene tree, it receives the <see cref="Godot.Node.NotificationEnterTree"/> notification and its <see cref="Godot.Node._EnterTree"/> callback is triggered. Child nodes are always added after their parent node, i.e. the <see cref="Godot.Node._EnterTree"/> callback of a parent node will be triggered before its child's.</para>
    /// <para>Once all nodes have been added in the scene tree, they receive the <see cref="Godot.Node.NotificationReady"/> notification and their respective <see cref="Godot.Node._Ready"/> callbacks are triggered. For groups of nodes, the <see cref="Godot.Node._Ready"/> callback is called in reverse order, starting with the children and moving up to the parent nodes.</para>
    /// <para>This means that when adding a node to the scene tree, the following order will be used for the callbacks: <see cref="Godot.Node._EnterTree"/> of the parent, <see cref="Godot.Node._EnterTree"/> of the children, <see cref="Godot.Node._Ready"/> of the children and finally <see cref="Godot.Node._Ready"/> of the parent (recursively for the entire scene tree).</para>
    /// <para>Processing: Nodes can override the "process" state, so that they receive a callback on each frame requesting them to process (do something). Normal processing (callback <see cref="Godot.Node._Process"/>, toggled with <see cref="Godot.Node.SetProcess"/>) happens as fast as possible and is dependent on the frame rate, so the processing time delta (in seconds) is passed as an argument. Physics processing (callback <see cref="Godot.Node._PhysicsProcess"/>, toggled with <see cref="Godot.Node.SetPhysicsProcess"/>) happens a fixed number of times per second (60 by default) and is useful for code related to the physics engine.</para>
    /// <para>Nodes can also process input events. When present, the <see cref="Godot.Node._Input"/> function will be called for each input that the program receives. In many cases, this can be overkill (unless used for simple projects), and the <see cref="Godot.Node._UnhandledInput"/> function might be preferred; it is called when the input event was not handled by anyone else (typically, GUI <see cref="Godot.Control"/> nodes), ensuring that the node only receives the events that were meant for it.</para>
    /// <para>To keep track of the scene hierarchy (especially when instancing scenes into other scenes), an "owner" can be set for the node with the <see cref="Godot.Node.Owner"/> property. This keeps track of who instanced what. This is mostly useful when writing editors and tools, though.</para>
    /// <para>Finally, when a node is freed with <see cref="Godot.Object.Free"/> or <see cref="Godot.Node.QueueFree"/>, it will also free all its children.</para>
    /// <para>Groups: Nodes can be added to as many groups as you want to be easy to manage, you could create groups like "enemies" or "collectables" for example, depending on your game. See <see cref="Godot.Node.AddToGroup"/>, <see cref="Godot.Node.IsInGroup"/> and <see cref="Godot.Node.RemoveFromGroup"/>. You can then retrieve all nodes in these groups, iterate them and even call methods on groups via the methods on <see cref="Godot.SceneTree"/>.</para>
    /// <para>Networking with nodes: After connecting to a server (or making one, see <see cref="Godot.NetworkedMultiplayerENet"/>), it is possible to use the built-in RPC (remote procedure call) system to communicate over the network. By calling <see cref="Godot.Node.Rpc"/> with a method name, it will be called locally and in all connected peers (peers = clients and the server that accepts connections). To identify which node receives the RPC call, Godot will use its <see cref="Godot.NodePath"/> (make sure node names are the same on all peers). Also, take a look at the high-level networking tutorial and corresponding demos.</para>
    /// </summary>
    public partial class Node : Object
    {
        /// <summary>
        /// <para>Notification received when the node enters a <see cref="Godot.SceneTree"/>.</para>
        /// <para>This notification is emitted before the related <c>tree_entered</c>.</para>
        /// </summary>
        public const int NotificationEnterTree = 10;
        /// <summary>
        /// <para>Notification received when the node is about to exit a <see cref="Godot.SceneTree"/>.</para>
        /// <para>This notification is emitted after the related <c>tree_exiting</c>.</para>
        /// </summary>
        public const int NotificationExitTree = 11;
        /// <summary>
        /// <para>Notification received when the node is moved in the parent.</para>
        /// </summary>
        public const int NotificationMovedInParent = 12;
        /// <summary>
        /// <para>Notification received when the node is ready. See <see cref="Godot.Node._Ready"/>.</para>
        /// </summary>
        public const int NotificationReady = 13;
        /// <summary>
        /// <para>Notification received when the node is paused.</para>
        /// </summary>
        public const int NotificationPaused = 14;
        /// <summary>
        /// <para>Notification received when the node is unpaused.</para>
        /// </summary>
        public const int NotificationUnpaused = 15;
        /// <summary>
        /// <para>Notification received every frame when the physics process flag is set (see <see cref="Godot.Node.SetPhysicsProcess"/>).</para>
        /// </summary>
        public const int NotificationPhysicsProcess = 16;
        /// <summary>
        /// <para>Notification received every frame when the process flag is set (see <see cref="Godot.Node.SetProcess"/>).</para>
        /// </summary>
        public const int NotificationProcess = 17;
        /// <summary>
        /// <para>Notification received when a node is set as a child of another node.</para>
        /// <para>Note: This doesn't mean that a node entered the <see cref="Godot.SceneTree"/>.</para>
        /// </summary>
        public const int NotificationParented = 18;
        /// <summary>
        /// <para>Notification received when a node is unparented (parent removed it from the list of children).</para>
        /// </summary>
        public const int NotificationUnparented = 19;
        /// <summary>
        /// <para>Notification received when the node is instanced.</para>
        /// </summary>
        public const int NotificationInstanced = 20;
        /// <summary>
        /// <para>Notification received when a drag operation begins. All nodes receive this notification, not only the dragged one.</para>
        /// <para>Can be triggered either by dragging a <see cref="Godot.Control"/> that provides drag data (see <see cref="Godot.Control.GetDragData"/>) or using <see cref="Godot.Control.ForceDrag"/>.</para>
        /// <para>Use <see cref="Godot.Viewport.GuiGetDragData"/> to get the dragged data.</para>
        /// </summary>
        public const int NotificationDragBegin = 21;
        /// <summary>
        /// <para>Notification received when a drag operation ends.</para>
        /// <para>Use <see cref="Godot.Viewport.GuiIsDragSuccessful"/> to check if the drag succeeded.</para>
        /// </summary>
        public const int NotificationDragEnd = 22;
        /// <summary>
        /// <para>Notification received when the node's <see cref="Godot.NodePath"/> changed.</para>
        /// </summary>
        public const int NotificationPathChanged = 23;
        /// <summary>
        /// <para>Notification received every frame when the internal process flag is set (see <see cref="Godot.Node.SetProcessInternal"/>).</para>
        /// </summary>
        public const int NotificationInternalProcess = 25;
        /// <summary>
        /// <para>Notification received every frame when the internal physics process flag is set (see <see cref="Godot.Node.SetPhysicsProcessInternal"/>).</para>
        /// </summary>
        public const int NotificationInternalPhysicsProcess = 26;
        /// <summary>
        /// <para>Notification received when the node is ready, just before <see cref="Godot.Node.NotificationReady"/> is received. Unlike the latter, it's sent every time the node enters tree, instead of only once.</para>
        /// </summary>
        public const int NotificationPostEnterTree = 27;
        /// <summary>
        /// <para>Notification received when <see cref="Godot.Node.ResetPhysicsInterpolation"/> is called on the node or parent nodes.</para>
        /// </summary>
        public const int NotificationResetPhysicsInterpolation = 28;
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

        public enum PauseModeEnum
        {
            /// <summary>
            /// <para>Inherits pause mode from the node's parent. For the root node, it is equivalent to <see cref="Godot.Node.PauseModeEnum.Stop"/>. Default.</para>
            /// </summary>
            Inherit = 0,
            /// <summary>
            /// <para>Stops processing when the <see cref="Godot.SceneTree"/> is paused.</para>
            /// </summary>
            Stop = 1,
            /// <summary>
            /// <para>Continue to process regardless of the <see cref="Godot.SceneTree"/> pause state.</para>
            /// </summary>
            Process = 2
        }

        public enum DuplicateFlags
        {
            /// <summary>
            /// <para>Duplicate the node's signals.</para>
            /// </summary>
            Signals = 1,
            /// <summary>
            /// <para>Duplicate the node's groups.</para>
            /// </summary>
            Groups = 2,
            /// <summary>
            /// <para>Duplicate the node's scripts.</para>
            /// </summary>
            Scripts = 4,
            /// <summary>
            /// <para>Duplicate using instancing.</para>
            /// <para>An instance stays linked to the original so when the original changes, the instance changes too.</para>
            /// </summary>
            UseInstancing = 8
        }

        public enum PhysicsInterpolationModeEnum
        {
            /// <summary>
            /// <para>Inherits physics interpolation mode from the node's parent. For the root node, it is equivalent to <see cref="Godot.Node.PhysicsInterpolationModeEnum.On"/>. Default.</para>
            /// </summary>
            Inherit = 0,
            /// <summary>
            /// <para>Turn off physics interpolation in this node and children set to <see cref="Godot.Node.PhysicsInterpolationModeEnum.Inherit"/>.</para>
            /// </summary>
            Off = 1,
            /// <summary>
            /// <para>Turn on physics interpolation in this node and children set to <see cref="Godot.Node.PhysicsInterpolationModeEnum.Inherit"/>.</para>
            /// </summary>
            On = 2
        }

        public string EditorDescription
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetEditorDescription();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetEditorDescription(value);
            }
#pragma warning restore CS0618
        }

        public NodePath _ImportPath
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetImportPath();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetImportPath(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Pause mode. How the node will behave if the <see cref="Godot.SceneTree"/> is paused.</para>
        /// </summary>
        public Node.PauseModeEnum PauseMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPauseMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPauseMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Allows enabling or disabling physics interpolation per node, offering a finer grain of control than turning physics interpolation on and off globally.</para>
        /// <para>Note: This can be especially useful for <see cref="Godot.Camera"/>s, where custom interpolation can sometimes give superior results.</para>
        /// </summary>
        public Node.PhysicsInterpolationModeEnum PhysicsInterpolationMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPhysicsInterpolationMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPhysicsInterpolationMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The name of the node. This name is unique among the siblings (other child nodes from the same parent). When set to an existing name, the node will be automatically renamed.</para>
        /// <para>Note: Auto-generated names might include the <c>@</c> character, which is reserved for unique names when using <see cref="Godot.Node.AddChild"/>. When setting the name manually, any <c>@</c> will be removed.</para>
        /// </summary>
        public string Name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetName();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetName(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets this node's name as a unique name in its <see cref="Godot.Node.Owner"/>. This allows the node to be accessed as <c>%Name</c> instead of the full path, from any node within that scene.</para>
        /// <para>If another node with the same owner already had that name declared as unique, that other node's name will no longer be set as having a unique name.</para>
        /// </summary>
        public bool UniqueNameInOwner
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUniqueNameInOwner();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUniqueNameInOwner(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If a scene is instantiated from a file, its topmost node contains the absolute file path from which it was loaded in <see cref="Godot.Node.Filename"/> (e.g. <c>res://levels/1.tscn</c>). Otherwise, <see cref="Godot.Node.Filename"/> is set to an empty string.</para>
        /// </summary>
        public string Filename
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFilename();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFilename(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The node owner. A node can have any other node as owner (as long as it is a valid parent, grandparent, etc. ascending in the tree). When saving a node (using <see cref="Godot.PackedScene"/>), all the nodes it owns will be saved with it. This allows for the creation of complex <see cref="Godot.SceneTree"/>s, with instancing and subinstancing.</para>
        /// <para>Note: If you want a child to be persisted to a <see cref="Godot.PackedScene"/>, you must set <see cref="Godot.Node.Owner"/> in addition to calling <see cref="Godot.Node.AddChild"/>. This is typically relevant for <a href="$DOCS_URL/tutorials/plugins/running_code_in_the_editor.html">tool scripts</a> and <a href="$DOCS_URL/tutorials/plugins/editor/index.html">editor plugins</a>. If <see cref="Godot.Node.AddChild"/> is called without setting <see cref="Godot.Node.Owner"/>, the newly added <see cref="Godot.Node"/> will not be visible in the scene tree, though it will be visible in the 2D/3D view.</para>
        /// </summary>
        public Node Owner
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOwner();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOwner(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The <see cref="Godot.MultiplayerAPI"/> instance associated with this node. Either the <see cref="Godot.Node.CustomMultiplayer"/>, or the default SceneTree one (if inside tree).</para>
        /// </summary>
        public MultiplayerAPI Multiplayer
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMultiplayer();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The override to the default <see cref="Godot.MultiplayerAPI"/>. Set to <c>null</c> to use the default <see cref="Godot.SceneTree"/> one.</para>
        /// </summary>
        public MultiplayerAPI CustomMultiplayer
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCustomMultiplayer();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCustomMultiplayer(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The node's priority in the execution order of the enabled processing callbacks (i.e. <see cref="Godot.Node.NotificationProcess"/>, <see cref="Godot.Node.NotificationPhysicsProcess"/> and their internal counterparts). Nodes whose process priority value is lower will have their processing callbacks executed first.</para>
        /// </summary>
        public int ProcessPriority
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetProcessPriority();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetProcessPriority(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Node";

        public Node() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Node_Ctor(this);
        }

        internal Node(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>Called when the node enters the <see cref="Godot.SceneTree"/> (e.g. upon instancing, scene changing, or after calling <see cref="Godot.Node.AddChild"/> in a script). If the node has children, its <see cref="Godot.Node._EnterTree"/> callback will be called first, and then that of the children.</para>
        /// <para>Corresponds to the <see cref="Godot.Node.NotificationEnterTree"/> notification in <see cref="Godot.Object._Notification"/>.</para>
        /// </summary>
        [GodotMethod("_enter_tree")]
        public virtual void _EnterTree()
        {
            return;
        }

        /// <summary>
        /// <para>Called when the node is about to leave the <see cref="Godot.SceneTree"/> (e.g. upon freeing, scene changing, or after calling <see cref="Godot.Node.RemoveChild"/> in a script). If the node has children, its <see cref="Godot.Node._ExitTree"/> callback will be called last, after all its children have left the tree.</para>
        /// <para>Corresponds to the <see cref="Godot.Node.NotificationExitTree"/> notification in <see cref="Godot.Object._Notification"/> and signal <c>tree_exiting</c>. To get notified when the node has already left the active tree, connect to the <c>tree_exited</c>.</para>
        /// </summary>
        [GodotMethod("_exit_tree")]
        public virtual void _ExitTree()
        {
            return;
        }

        /// <summary>
        /// <para>The string returned from this method is displayed as a warning in the Scene Dock if the script that overrides it is a <c>tool</c> script.</para>
        /// <para>Returning an empty string produces no warning.</para>
        /// <para>Call <see cref="Godot.Node.UpdateConfigurationWarning"/> when the warning needs to be updated for this node.</para>
        /// </summary>
        [GodotMethod("_get_configuration_warning")]
        public virtual string _GetConfigurationWarning()
        {
            return default(string);
        }

        /// <summary>
        /// <para>Called when there is an input event. The input event propagates up through the node tree until a node consumes it.</para>
        /// <para>It is only called if input processing is enabled, which is done automatically if this method is overridden, and can be toggled with <see cref="Godot.Node.SetProcessInput"/>.</para>
        /// <para>To consume the input event and stop it propagating further to other nodes, <see cref="Godot.SceneTree.SetInputAsHandled"/> can be called.</para>
        /// <para>For gameplay input, <see cref="Godot.Node._UnhandledInput"/> and <see cref="Godot.Node._UnhandledKeyInput"/> are usually a better fit as they allow the GUI to intercept the events first.</para>
        /// <para>Note: This method is only called if the node is present in the scene tree (i.e. if it's not an orphan).</para>
        /// </summary>
        [GodotMethod("_input")]
        public virtual void _Input(InputEvent @event)
        {
            return;
        }

        /// <summary>
        /// <para>Called during the physics processing step of the main loop. Physics processing means that the frame rate is synced to the physics, i.e. the <c>delta</c> variable should be constant. <c>delta</c> is in seconds.</para>
        /// <para>It is only called if physics processing is enabled, which is done automatically if this method is overridden, and can be toggled with <see cref="Godot.Node.SetPhysicsProcess"/>.</para>
        /// <para>Corresponds to the <see cref="Godot.Node.NotificationPhysicsProcess"/> notification in <see cref="Godot.Object._Notification"/>.</para>
        /// <para>Note: This method is only called if the node is present in the scene tree (i.e. if it's not an orphan).</para>
        /// </summary>
        [GodotMethod("_physics_process")]
        public virtual void _PhysicsProcess(float delta)
        {
            return;
        }

        /// <summary>
        /// <para>Called during the processing step of the main loop. Processing happens at every frame and as fast as possible, so the <c>delta</c> time since the previous frame is not constant. <c>delta</c> is in seconds.</para>
        /// <para>It is only called if processing is enabled, which is done automatically if this method is overridden, and can be toggled with <see cref="Godot.Node.SetProcess"/>.</para>
        /// <para>Corresponds to the <see cref="Godot.Node.NotificationProcess"/> notification in <see cref="Godot.Object._Notification"/>.</para>
        /// <para>Note: This method is only called if the node is present in the scene tree (i.e. if it's not an orphan).</para>
        /// </summary>
        [GodotMethod("_process")]
        public virtual void _Process(float delta)
        {
            return;
        }

        /// <summary>
        /// <para>Called when the node is "ready", i.e. when both the node and its children have entered the scene tree. If the node has children, their <see cref="Godot.Node._Ready"/> callbacks get triggered first, and the parent node will receive the ready notification afterwards.</para>
        /// <para>Corresponds to the <see cref="Godot.Node.NotificationReady"/> notification in <see cref="Godot.Object._Notification"/>. See also the <c>onready</c> keyword for variables.</para>
        /// <para>Usually used for initialization. For even earlier initialization,  may be used. See also <see cref="Godot.Node._EnterTree"/>.</para>
        /// <para>Note: <see cref="Godot.Node._Ready"/> may be called only once for each node. After removing a node from the scene tree and adding it again, <c>_ready</c> will not be called a second time. This can be bypassed by requesting another call with <see cref="Godot.Node.RequestReady"/>, which may be called anywhere before adding the node again.</para>
        /// </summary>
        [GodotMethod("_ready")]
        public virtual void _Ready()
        {
            return;
        }

        /// <summary>
        /// <para>Called when an <see cref="Godot.InputEvent"/> hasn't been consumed by <see cref="Godot.Node._Input"/> or any GUI <see cref="Godot.Control"/> item. The input event propagates up through the node tree until a node consumes it.</para>
        /// <para>It is only called if unhandled input processing is enabled, which is done automatically if this method is overridden, and can be toggled with <see cref="Godot.Node.SetProcessUnhandledInput"/>.</para>
        /// <para>To consume the input event and stop it propagating further to other nodes, <see cref="Godot.SceneTree.SetInputAsHandled"/> can be called.</para>
        /// <para>For gameplay input, this and <see cref="Godot.Node._UnhandledKeyInput"/> are usually a better fit than <see cref="Godot.Node._Input"/> as they allow the GUI to intercept the events first.</para>
        /// <para>Note: This method is only called if the node is present in the scene tree (i.e. if it's not an orphan).</para>
        /// </summary>
        [GodotMethod("_unhandled_input")]
        public virtual void _UnhandledInput(InputEvent @event)
        {
            return;
        }

        /// <summary>
        /// <para>Called when an <see cref="Godot.InputEventKey"/> hasn't been consumed by <see cref="Godot.Node._Input"/> or any GUI <see cref="Godot.Control"/> item. The input event propagates up through the node tree until a node consumes it.</para>
        /// <para>It is only called if unhandled key input processing is enabled, which is done automatically if this method is overridden, and can be toggled with <see cref="Godot.Node.SetProcessUnhandledKeyInput"/>.</para>
        /// <para>To consume the input event and stop it propagating further to other nodes, <see cref="Godot.SceneTree.SetInputAsHandled"/> can be called.</para>
        /// <para>For gameplay input, this and <see cref="Godot.Node._UnhandledInput"/> are usually a better fit than <see cref="Godot.Node._Input"/> as they allow the GUI to intercept the events first.</para>
        /// <para>Note: This method is only called if the node is present in the scene tree (i.e. if it's not an orphan).</para>
        /// </summary>
        [GodotMethod("_unhandled_key_input")]
        public virtual void _UnhandledKeyInput(InputEventKey @event)
        {
            return;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_child_below_node");

        /// <summary>
        /// <para>Adds <c>child_node</c> as a child. The child is placed below the given <c>node</c> in the list of children.</para>
        /// <para>If <c>legible_unique_name</c> is <c>true</c>, the child node will have a human-readable name based on the name of the node being instanced instead of its type.</para>
        /// </summary>
        [GodotMethod("add_child_below_node")]
        public void AddChildBelowNode(Node node, Node childNode, bool legibleUniqueName = false)
        {
            NativeCalls.godot_icall_3_672(method_bind_0, Object.GetPtr(this), Object.GetPtr(node), Object.GetPtr(childNode), legibleUniqueName);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_name");

        [GodotMethod("set_name")]
        [Obsolete("SetName is deprecated. Use the Name property instead.")]
        public void SetName(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_1, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_name");

        [GodotMethod("get_name")]
        [Obsolete("GetName is deprecated. Use the Name property instead.")]
        public string GetName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_child");

        /// <summary>
        /// <para>Adds a child node. Nodes can have any number of children, but every child must have a unique name. Child nodes are automatically deleted when the parent node is deleted, so an entire scene can be removed by deleting its topmost node.</para>
        /// <para>If <c>legible_unique_name</c> is <c>true</c>, the child node will have a human-readable name based on the name of the node being instanced instead of its type.</para>
        /// <para>Note: If the child node already has a parent, the function will fail. Use <see cref="Godot.Node.RemoveChild"/> first to remove the node from its current parent. For example:</para>
        /// <para><code>
        /// if child_node.get_parent():
        ///     child_node.get_parent().remove_child(child_node)
        /// add_child(child_node)
        /// </code></para>
        /// <para>Note: If you want a child to be persisted to a <see cref="Godot.PackedScene"/>, you must set <see cref="Godot.Node.Owner"/> in addition to calling <see cref="Godot.Node.AddChild"/>. This is typically relevant for <a href="$DOCS_URL/tutorials/plugins/running_code_in_the_editor.html">tool scripts</a> and <a href="$DOCS_URL/tutorials/plugins/editor/index.html">editor plugins</a>. If <see cref="Godot.Node.AddChild"/> is called without setting <see cref="Godot.Node.Owner"/>, the newly added <see cref="Godot.Node"/> will not be visible in the scene tree, though it will be visible in the 2D/3D view.</para>
        /// </summary>
        [GodotMethod("add_child")]
        public void AddChild(Node node, bool legibleUniqueName = false)
        {
            NativeCalls.godot_icall_2_451(method_bind_3, Object.GetPtr(this), Object.GetPtr(node), legibleUniqueName);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_child");

        /// <summary>
        /// <para>Removes a child node. The node is NOT deleted and must be deleted manually.</para>
        /// <para>Note: This function may set the <see cref="Godot.Node.Owner"/> of the removed Node (or its descendants) to be <c>null</c>, if that <see cref="Godot.Node.Owner"/> is no longer a parent or ancestor.</para>
        /// </summary>
        [GodotMethod("remove_child")]
        public void RemoveChild(Node node)
        {
            NativeCalls.godot_icall_1_53(method_bind_4, Object.GetPtr(this), Object.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_child_count");

        /// <summary>
        /// <para>Returns the number of child nodes.</para>
        /// </summary>
        [GodotMethod("get_child_count")]
        public int GetChildCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_children");

        /// <summary>
        /// <para>Returns an array of references to node's children.</para>
        /// </summary>
        [GodotMethod("get_children")]
        public Godot.Collections.Array GetChildren()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_6, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_child");

        /// <summary>
        /// <para>Returns a child node by its index (see <see cref="Godot.Node.GetChildCount"/>). This method is often used for iterating all children of a node.</para>
        /// <para>To access a child node via its name, use <see cref="Godot.Node.GetNode"/>.</para>
        /// </summary>
        [GodotMethod("get_child")]
        public Node GetChild(int idx)
        {
            return NativeCalls.godot_icall_1_460(method_bind_7, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_node");

        /// <summary>
        /// <para>Returns <c>true</c> if the node that the <see cref="Godot.NodePath"/> points to exists.</para>
        /// </summary>
        [GodotMethod("has_node")]
        public bool HasNode(NodePath path)
        {
            return NativeCalls.godot_icall_1_91(method_bind_8, Object.GetPtr(this), NodePath.GetPtr(path));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node");

        /// <summary>
        /// <para>Fetches a node. The <see cref="Godot.NodePath"/> can be either a relative path (from the current node) or an absolute path (in the scene tree) to a node. If the path does not exist, <c>null</c> is returned and an error is logged. Attempts to access methods on the return value will result in an "Attempt to call &lt;method&gt; on a null instance." error.</para>
        /// <para>Note: Fetching absolute paths only works when the node is inside the scene tree (see <see cref="Godot.Node.IsInsideTree"/>).</para>
        /// <para>Example: Assume your current node is Character and the following tree:</para>
        /// <para><code>
        /// /root
        /// /root/Character
        /// /root/Character/Sword
        /// /root/Character/Backpack/Dagger
        /// /root/MyGame
        /// /root/Swamp/Alligator
        /// /root/Swamp/Mosquito
        /// /root/Swamp/Goblin
        /// </code></para>
        /// <para>Possible paths are:</para>
        /// <para><code>
        /// get_node("Sword")
        /// get_node("Backpack/Dagger")
        /// get_node("../Swamp/Alligator")
        /// get_node("/root/MyGame")
        /// </code></para>
        /// </summary>
        [GodotMethod("get_node")]
        public Node GetNode(NodePath path)
        {
            return NativeCalls.godot_icall_1_673(method_bind_9, Object.GetPtr(this), NodePath.GetPtr(path));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_or_null");

        /// <summary>
        /// <para>Similar to <see cref="Godot.Node.GetNode"/>, but does not log an error if <c>path</c> does not point to a valid <see cref="Godot.Node"/>.</para>
        /// </summary>
        [GodotMethod("get_node_or_null")]
        public Node GetNodeOrNull(NodePath path)
        {
            return NativeCalls.godot_icall_1_673(method_bind_10, Object.GetPtr(this), NodePath.GetPtr(path));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_parent");

        /// <summary>
        /// <para>Returns the parent node of the current node, or <c>null</c> if the node lacks a parent.</para>
        /// </summary>
        [GodotMethod("get_parent")]
        public Node GetParent()
        {
            return NativeCalls.godot_icall_0_257(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "find_node");

        /// <summary>
        /// <para>Finds a descendant of this node whose name matches <c>mask</c> as in <c>String.match</c> (i.e. case-sensitive, but <c>"*"</c> matches zero or more characters and <c>"?"</c> matches any single character except <c>"."</c>). Returns <c>null</c> if no matching <see cref="Godot.Node"/> is found.</para>
        /// <para>Note: It does not match against the full path, just against individual node names.</para>
        /// <para>If <c>owned</c> is <c>true</c>, this method only finds nodes whose owner is this node. This is especially important for scenes instantiated through a script, because those scenes don't have an owner.</para>
        /// <para>Note: As this method walks through all the descendants of the node, it is the slowest way to get a reference to another node. Whenever possible, consider using <see cref="Godot.Node.GetNode"/> instead. To avoid using <see cref="Godot.Node.FindNode"/> too often, consider caching the node reference into a variable.</para>
        /// </summary>
        [GodotMethod("find_node")]
        public Node FindNode(string mask, bool recursive = true, bool owned = true)
        {
            return NativeCalls.godot_icall_3_674(method_bind_12, Object.GetPtr(this), mask, recursive, owned);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "find_parent");

        /// <summary>
        /// <para>Finds the first parent of the current node whose name matches <c>mask</c> as in <c>String.match</c> (i.e. case-sensitive, but <c>"*"</c> matches zero or more characters and <c>"?"</c> matches any single character except <c>"."</c>).</para>
        /// <para>Note: It does not match against the full path, just against individual node names.</para>
        /// <para>Note: As this method walks upwards in the scene tree, it can be slow in large, deeply nested scene trees. Whenever possible, consider using <see cref="Godot.Node.GetNode"/> instead. To avoid using <see cref="Godot.Node.FindParent"/> too often, consider caching the node reference into a variable.</para>
        /// </summary>
        [GodotMethod("find_parent")]
        public Node FindParent(string mask)
        {
            return NativeCalls.godot_icall_1_675(method_bind_13, Object.GetPtr(this), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_node_and_resource");

        /// <summary>
        /// <para>Returns <c>true</c> if the <see cref="Godot.NodePath"/> points to a valid node and its subname points to a valid resource, e.g. <c>Area2D/CollisionShape2D:shape</c>. Properties with a non-<see cref="Godot.Resource"/> type (e.g. nodes or primitive math types) are not considered resources.</para>
        /// </summary>
        [GodotMethod("has_node_and_resource")]
        public bool HasNodeAndResource(NodePath path)
        {
            return NativeCalls.godot_icall_1_91(method_bind_14, Object.GetPtr(this), NodePath.GetPtr(path));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_and_resource");

        /// <summary>
        /// <para>Fetches a node and one of its resources as specified by the <see cref="Godot.NodePath"/>'s subname (e.g. <c>Area2D/CollisionShape2D:shape</c>). If several nested resources are specified in the <see cref="Godot.NodePath"/>, the last one will be fetched.</para>
        /// <para>The return value is an array of size 3: the first index points to the <see cref="Godot.Node"/> (or <c>null</c> if not found), the second index points to the <see cref="Godot.Resource"/> (or <c>null</c> if not found), and the third index is the remaining <see cref="Godot.NodePath"/>, if any.</para>
        /// <para>For example, assuming that <c>Area2D/CollisionShape2D</c> is a valid node and that its <c>shape</c> property has been assigned a <see cref="Godot.RectangleShape2D"/> resource, one could have this kind of output:</para>
        /// <para><code>
        /// print(get_node_and_resource("Area2D/CollisionShape2D")) # [[CollisionShape2D:1161], Null, ]
        /// print(get_node_and_resource("Area2D/CollisionShape2D:shape")) # [[CollisionShape2D:1161], [RectangleShape2D:1156], ]
        /// print(get_node_and_resource("Area2D/CollisionShape2D:shape:extents")) # [[CollisionShape2D:1161], [RectangleShape2D:1156], :extents]
        /// </code></para>
        /// </summary>
        [GodotMethod("get_node_and_resource")]
        public Godot.Collections.Array GetNodeAndResource(NodePath path)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_1_676(method_bind_15, Object.GetPtr(this), NodePath.GetPtr(path)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_inside_tree");

        /// <summary>
        /// <para>Returns <c>true</c> if this node is currently inside a <see cref="Godot.SceneTree"/>.</para>
        /// </summary>
        [GodotMethod("is_inside_tree")]
        public bool IsInsideTree()
        {
            return NativeCalls.godot_icall_0_7(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_a_parent_of");

        /// <summary>
        /// <para>Returns <c>true</c> if the given node is a direct or indirect child of the current node.</para>
        /// </summary>
        [GodotMethod("is_a_parent_of")]
        public bool IsAParentOf(Node node)
        {
            return NativeCalls.godot_icall_1_149(method_bind_17, Object.GetPtr(this), Object.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_greater_than");

        /// <summary>
        /// <para>Returns <c>true</c> if the given node occurs later in the scene hierarchy than the current node.</para>
        /// </summary>
        [GodotMethod("is_greater_than")]
        public bool IsGreaterThan(Node node)
        {
            return NativeCalls.godot_icall_1_149(method_bind_18, Object.GetPtr(this), Object.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_path");

        /// <summary>
        /// <para>Returns the absolute path of the current node. This only works if the current node is inside the scene tree (see <see cref="Godot.Node.IsInsideTree"/>).</para>
        /// </summary>
        [GodotMethod("get_path")]
        public NodePath GetPath()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_19, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_path_to");

        /// <summary>
        /// <para>Returns the relative <see cref="Godot.NodePath"/> from this node to the specified <c>node</c>. Both nodes must be in the same scene or the function will fail.</para>
        /// </summary>
        [GodotMethod("get_path_to")]
        public NodePath GetPathTo(Node node)
        {
            return new NodePath(NativeCalls.godot_icall_1_677(method_bind_20, Object.GetPtr(this), Object.GetPtr(node)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_to_group");

        /// <summary>
        /// <para>Adds the node to a group. Groups are helpers to name and organize a subset of nodes, for example "enemies" or "collectables". A node can be in any number of groups. Nodes can be assigned a group at any time, but will not be added until they are inside the scene tree (see <see cref="Godot.Node.IsInsideTree"/>). See notes in the description, and the group methods in <see cref="Godot.SceneTree"/>.</para>
        /// <para>The <c>persistent</c> option is used when packing node to <see cref="Godot.PackedScene"/> and saving to file. Non-persistent groups aren't stored.</para>
        /// <para>Note: For performance reasons, the order of node groups is not guaranteed. The order of node groups should not be relied upon as it can vary across project runs.</para>
        /// </summary>
        [GodotMethod("add_to_group")]
        public void AddToGroup(string group, bool persistent = false)
        {
            NativeCalls.godot_icall_2_56(method_bind_21, Object.GetPtr(this), group, persistent);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_from_group");

        /// <summary>
        /// <para>Removes a node from a group. See notes in the description, and the group methods in <see cref="Godot.SceneTree"/>.</para>
        /// </summary>
        [GodotMethod("remove_from_group")]
        public void RemoveFromGroup(string group)
        {
            NativeCalls.godot_icall_1_54(method_bind_22, Object.GetPtr(this), group);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_in_group");

        /// <summary>
        /// <para>Returns <c>true</c> if this node is in the specified group. See notes in the description, and the group methods in <see cref="Godot.SceneTree"/>.</para>
        /// </summary>
        [GodotMethod("is_in_group")]
        public bool IsInGroup(string group)
        {
            return NativeCalls.godot_icall_1_108(method_bind_23, Object.GetPtr(this), group);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "move_child");

        /// <summary>
        /// <para>Moves a child node to a different position (order) among the other children. Since calls, signals, etc are performed by tree order, changing the order of children nodes may be useful.</para>
        /// </summary>
        [GodotMethod("move_child")]
        public void MoveChild(Node childNode, int toPosition)
        {
            NativeCalls.godot_icall_2_678(method_bind_24, Object.GetPtr(this), Object.GetPtr(childNode), toPosition);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_groups");

        /// <summary>
        /// <para>Returns an array listing the groups that the node is a member of.</para>
        /// <para>Note: For performance reasons, the order of node groups is not guaranteed. The order of node groups should not be relied upon as it can vary across project runs.</para>
        /// <para>Note: The engine uses some group names internally (all starting with an underscore). To avoid conflicts with internal groups, do not add custom groups whose name starts with an underscore. To exclude internal groups while looping over <see cref="Godot.Node.GetGroups"/>, use the following snippet:</para>
        /// <para><code>
        /// # Stores the node's non-internal groups only (as an array of Strings).
        /// var non_internal_groups = []
        /// for group in get_groups():
        ///     if not group.begins_with("_"):
        ///         non_internal_groups.push_back(group)
        /// </code></para>
        /// </summary>
        [GodotMethod("get_groups")]
        public Godot.Collections.Array GetGroups()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_25, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "raise");

        /// <summary>
        /// <para>Moves this node to the bottom of parent node's children hierarchy. This is often useful in GUIs (<see cref="Godot.Control"/> nodes), because their order of drawing depends on their order in the tree. The top Node is drawn first, then any siblings below the top Node in the hierarchy are successively drawn on top of it. After using <c>raise</c>, a Control will be drawn on top of its siblings.</para>
        /// </summary>
        [GodotMethod("raise")]
        public void Raise()
        {
            NativeCalls.godot_icall_0_3(method_bind_26, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_owner");

        [GodotMethod("set_owner")]
        [Obsolete("SetOwner is deprecated. Use the Owner property instead.")]
        public void SetOwner(Node owner)
        {
            NativeCalls.godot_icall_1_53(method_bind_27, Object.GetPtr(this), Object.GetPtr(owner));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_owner");

        [GodotMethod("get_owner")]
        [Obsolete("GetOwner is deprecated. Use the Owner property instead.")]
        public Node GetOwner()
        {
            return NativeCalls.godot_icall_0_257(method_bind_28, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_and_skip");

        /// <summary>
        /// <para>Removes a node and sets all its children as children of the parent node (if it exists). All event subscriptions that pass by the removed node will be unsubscribed.</para>
        /// </summary>
        [GodotMethod("remove_and_skip")]
        public void RemoveAndSkip()
        {
            NativeCalls.godot_icall_0_3(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_index");

        /// <summary>
        /// <para>Returns the node's index, i.e. its position among the siblings of its parent.</para>
        /// </summary>
        [GodotMethod("get_index")]
        public int GetIndex()
        {
            return NativeCalls.godot_icall_0_5(method_bind_30, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "print_tree");

        /// <summary>
        /// <para>Prints the tree to stdout. Used mainly for debugging purposes. This version displays the path relative to the current node, and is good for copy/pasting into the <see cref="Godot.Node.GetNode"/> function.</para>
        /// <para>Example output:</para>
        /// <para><code>
        /// TheGame
        /// TheGame/Menu
        /// TheGame/Menu/Label
        /// TheGame/Menu/Camera2D
        /// TheGame/SplashScreen
        /// TheGame/SplashScreen/Camera2D
        /// </code></para>
        /// </summary>
        [GodotMethod("print_tree")]
        public void PrintTree()
        {
            NativeCalls.godot_icall_0_3(method_bind_31, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "print_tree_pretty");

        /// <summary>
        /// <para>Similar to <see cref="Godot.Node.PrintTree"/>, this prints the tree to stdout. This version displays a more graphical representation similar to what is displayed in the scene inspector. It is useful for inspecting larger trees.</para>
        /// <para>Example output:</para>
        /// <para><code>
        ///  ┖╴TheGame
        ///     ┠╴Menu
        ///     ┃  ┠╴Label
        ///     ┃  ┖╴Camera2D
        ///     ┖╴SplashScreen
        ///        ┖╴Camera2D
        /// </code></para>
        /// </summary>
        [GodotMethod("print_tree_pretty")]
        public void PrintTreePretty()
        {
            NativeCalls.godot_icall_0_3(method_bind_32, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_filename");

        [GodotMethod("set_filename")]
        [Obsolete("SetFilename is deprecated. Use the Filename property instead.")]
        public void SetFilename(string filename)
        {
            NativeCalls.godot_icall_1_54(method_bind_33, Object.GetPtr(this), filename);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_filename");

        [GodotMethod("get_filename")]
        [Obsolete("GetFilename is deprecated. Use the Filename property instead.")]
        public string GetFilename()
        {
            return NativeCalls.godot_icall_0_6(method_bind_34, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "propagate_notification");

        /// <summary>
        /// <para>Notifies the current node and all its children recursively by calling <see cref="Godot.Object.Notification"/> on all of them.</para>
        /// </summary>
        [GodotMethod("propagate_notification")]
        public void PropagateNotification(int what)
        {
            NativeCalls.godot_icall_1_4(method_bind_35, Object.GetPtr(this), what);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "propagate_call");

        /// <summary>
        /// <para>Calls the given method (if present) with the arguments given in <c>args</c> on this node and recursively on all its children. If the <c>parent_first</c> argument is <c>true</c>, the method will be called on the current node first, then on all its children. If <c>parent_first</c> is <c>false</c>, the children will be called first.</para>
        /// </summary>
        /// <param name="args">If the parameter is null, then the default value is new Godot.Collections.Array { }</param>
        [GodotMethod("propagate_call")]
        public void PropagateCall(string method, Godot.Collections.Array args = null, bool parentFirst = false)
        {
            Godot.Collections.Array args_in = args != null ? args : new Godot.Collections.Array { };
            NativeCalls.godot_icall_3_679(method_bind_36, Object.GetPtr(this), method, args_in.GetPtr(), parentFirst);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_physics_process");

        /// <summary>
        /// <para>Enables or disables physics (i.e. fixed framerate) processing. When a node is being processed, it will receive a <see cref="Godot.Node.NotificationPhysicsProcess"/> at a fixed (usually 60 FPS, see <see cref="Godot.Engine.IterationsPerSecond"/> to change) interval (and the <see cref="Godot.Node._PhysicsProcess"/> callback will be called if exists). Enabled automatically if <see cref="Godot.Node._PhysicsProcess"/> is overridden. Any calls to this before <see cref="Godot.Node._Ready"/> will be ignored.</para>
        /// </summary>
        [GodotMethod("set_physics_process")]
        public void SetPhysicsProcess(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_37, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_physics_process_delta_time");

        /// <summary>
        /// <para>Returns the time elapsed (in seconds) since the last physics-bound frame (see <see cref="Godot.Node._PhysicsProcess"/>). This is always a constant value in physics processing unless the frames per second is changed via <see cref="Godot.Engine.IterationsPerSecond"/>.</para>
        /// </summary>
        [GodotMethod("get_physics_process_delta_time")]
        public float GetPhysicsProcessDeltaTime()
        {
            return NativeCalls.godot_icall_0_14(method_bind_38, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_physics_processing");

        /// <summary>
        /// <para>Returns <c>true</c> if physics processing is enabled (see <see cref="Godot.Node.SetPhysicsProcess"/>).</para>
        /// </summary>
        [GodotMethod("is_physics_processing")]
        public bool IsPhysicsProcessing()
        {
            return NativeCalls.godot_icall_0_7(method_bind_39, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_process_delta_time");

        /// <summary>
        /// <para>Returns the time elapsed (in seconds) since the last process callback. This value may vary from frame to frame.</para>
        /// </summary>
        [GodotMethod("get_process_delta_time")]
        public float GetProcessDeltaTime()
        {
            return NativeCalls.godot_icall_0_14(method_bind_40, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_process");

        /// <summary>
        /// <para>Enables or disables processing. When a node is being processed, it will receive a <see cref="Godot.Node.NotificationProcess"/> on every drawn frame (and the <see cref="Godot.Node._Process"/> callback will be called if exists). Enabled automatically if <see cref="Godot.Node._Process"/> is overridden. Any calls to this before <see cref="Godot.Node._Ready"/> will be ignored.</para>
        /// </summary>
        [GodotMethod("set_process")]
        public void SetProcess(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_41, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_process_priority");

        [GodotMethod("set_process_priority")]
        [Obsolete("SetProcessPriority is deprecated. Use the ProcessPriority property instead.")]
        public void SetProcessPriority(int priority)
        {
            NativeCalls.godot_icall_1_4(method_bind_42, Object.GetPtr(this), priority);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_process_priority");

        [GodotMethod("get_process_priority")]
        [Obsolete("GetProcessPriority is deprecated. Use the ProcessPriority property instead.")]
        public int GetProcessPriority()
        {
            return NativeCalls.godot_icall_0_5(method_bind_43, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_processing");

        /// <summary>
        /// <para>Returns <c>true</c> if processing is enabled (see <see cref="Godot.Node.SetProcess"/>).</para>
        /// </summary>
        [GodotMethod("is_processing")]
        public bool IsProcessing()
        {
            return NativeCalls.godot_icall_0_7(method_bind_44, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_process_input");

        /// <summary>
        /// <para>Enables or disables input processing. This is not required for GUI controls! Enabled automatically if <see cref="Godot.Node._Input"/> is overridden. Any calls to this before <see cref="Godot.Node._Ready"/> will be ignored.</para>
        /// </summary>
        [GodotMethod("set_process_input")]
        public void SetProcessInput(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_45, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_processing_input");

        /// <summary>
        /// <para>Returns <c>true</c> if the node is processing input (see <see cref="Godot.Node.SetProcessInput"/>).</para>
        /// </summary>
        [GodotMethod("is_processing_input")]
        public bool IsProcessingInput()
        {
            return NativeCalls.godot_icall_0_7(method_bind_46, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_process_unhandled_input");

        /// <summary>
        /// <para>Enables unhandled input processing. This is not required for GUI controls! It enables the node to receive all input that was not previously handled (usually by a <see cref="Godot.Control"/>). Enabled automatically if <see cref="Godot.Node._UnhandledInput"/> is overridden. Any calls to this before <see cref="Godot.Node._Ready"/> will be ignored.</para>
        /// </summary>
        [GodotMethod("set_process_unhandled_input")]
        public void SetProcessUnhandledInput(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_47, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_processing_unhandled_input");

        /// <summary>
        /// <para>Returns <c>true</c> if the node is processing unhandled input (see <see cref="Godot.Node.SetProcessUnhandledInput"/>).</para>
        /// </summary>
        [GodotMethod("is_processing_unhandled_input")]
        public bool IsProcessingUnhandledInput()
        {
            return NativeCalls.godot_icall_0_7(method_bind_48, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_process_unhandled_key_input");

        /// <summary>
        /// <para>Enables unhandled key input processing. Enabled automatically if <see cref="Godot.Node._UnhandledKeyInput"/> is overridden. Any calls to this before <see cref="Godot.Node._Ready"/> will be ignored.</para>
        /// </summary>
        [GodotMethod("set_process_unhandled_key_input")]
        public void SetProcessUnhandledKeyInput(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_49, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_processing_unhandled_key_input");

        /// <summary>
        /// <para>Returns <c>true</c> if the node is processing unhandled key input (see <see cref="Godot.Node.SetProcessUnhandledKeyInput"/>).</para>
        /// </summary>
        [GodotMethod("is_processing_unhandled_key_input")]
        public bool IsProcessingUnhandledKeyInput()
        {
            return NativeCalls.godot_icall_0_7(method_bind_50, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pause_mode");

        [GodotMethod("set_pause_mode")]
        [Obsolete("SetPauseMode is deprecated. Use the PauseMode property instead.")]
        public void SetPauseMode(Node.PauseModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_51, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pause_mode");

        [GodotMethod("get_pause_mode")]
        [Obsolete("GetPauseMode is deprecated. Use the PauseMode property instead.")]
        public Node.PauseModeEnum GetPauseMode()
        {
            return (Node.PauseModeEnum)NativeCalls.godot_icall_0_680(method_bind_52, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_53 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "can_process");

        /// <summary>
        /// <para>Returns <c>true</c> if the node can process while the scene tree is paused (see <see cref="Godot.Node.PauseMode"/>). Always returns <c>true</c> if the scene tree is not paused, and <c>false</c> if the node is not in the tree.</para>
        /// </summary>
        [GodotMethod("can_process")]
        public bool CanProcess()
        {
            return NativeCalls.godot_icall_0_7(method_bind_53, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_54 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "print_stray_nodes");

        /// <summary>
        /// <para>Prints all stray nodes (nodes outside the <see cref="Godot.SceneTree"/>). Used for debugging. Works only in debug builds.</para>
        /// </summary>
        [GodotMethod("print_stray_nodes")]
        public void PrintStrayNodes()
        {
            NativeCalls.godot_icall_0_3(method_bind_54, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_55 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_position_in_parent");

        /// <summary>
        /// <para>Returns the node's order in the scene tree branch. For example, if called on the first child node the position is <c>0</c>.</para>
        /// </summary>
        [GodotMethod("get_position_in_parent")]
        public int GetPositionInParent()
        {
            return NativeCalls.godot_icall_0_5(method_bind_55, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_56 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_display_folded");

        /// <summary>
        /// <para>Sets the folded state of the node in the Scene dock.</para>
        /// </summary>
        [GodotMethod("set_display_folded")]
        public void SetDisplayFolded(bool fold)
        {
            NativeCalls.godot_icall_1_16(method_bind_56, Object.GetPtr(this), fold);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_57 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_displayed_folded");

        /// <summary>
        /// <para>Returns <c>true</c> if the node is folded (collapsed) in the Scene dock.</para>
        /// </summary>
        [GodotMethod("is_displayed_folded")]
        public bool IsDisplayedFolded()
        {
            return NativeCalls.godot_icall_0_7(method_bind_57, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_58 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_process_internal");

        /// <summary>
        /// <para>Enables or disabled internal processing for this node. Internal processing happens in isolation from the normal <see cref="Godot.Node._Process"/> calls and is used by some nodes internally to guarantee proper functioning even if the node is paused or processing is disabled for scripting (<see cref="Godot.Node.SetProcess"/>). Only useful for advanced uses to manipulate built-in nodes' behavior.</para>
        /// <para>Warning: Built-in Nodes rely on the internal processing for their own logic, so changing this value from your code may lead to unexpected behavior. Script access to this internal logic is provided for specific advanced uses, but is unsafe and not supported.</para>
        /// </summary>
        [GodotMethod("set_process_internal")]
        public void SetProcessInternal(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_58, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_59 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_processing_internal");

        /// <summary>
        /// <para>Returns <c>true</c> if internal processing is enabled (see <see cref="Godot.Node.SetProcessInternal"/>).</para>
        /// </summary>
        [GodotMethod("is_processing_internal")]
        public bool IsProcessingInternal()
        {
            return NativeCalls.godot_icall_0_7(method_bind_59, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_60 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_physics_process_internal");

        /// <summary>
        /// <para>Enables or disables internal physics for this node. Internal physics processing happens in isolation from the normal <see cref="Godot.Node._PhysicsProcess"/> calls and is used by some nodes internally to guarantee proper functioning even if the node is paused or physics processing is disabled for scripting (<see cref="Godot.Node.SetPhysicsProcess"/>). Only useful for advanced uses to manipulate built-in nodes' behavior.</para>
        /// <para>Warning: Built-in Nodes rely on the internal processing for their own logic, so changing this value from your code may lead to unexpected behavior. Script access to this internal logic is provided for specific advanced uses, but is unsafe and not supported.</para>
        /// </summary>
        [GodotMethod("set_physics_process_internal")]
        public void SetPhysicsProcessInternal(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_60, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_61 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_physics_processing_internal");

        /// <summary>
        /// <para>Returns <c>true</c> if internal physics processing is enabled (see <see cref="Godot.Node.SetPhysicsProcessInternal"/>).</para>
        /// </summary>
        [GodotMethod("is_physics_processing_internal")]
        public bool IsPhysicsProcessingInternal()
        {
            return NativeCalls.godot_icall_0_7(method_bind_61, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_62 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_physics_interpolation_mode");

        [GodotMethod("set_physics_interpolation_mode")]
        [Obsolete("SetPhysicsInterpolationMode is deprecated. Use the PhysicsInterpolationMode property instead.")]
        public void SetPhysicsInterpolationMode(Node.PhysicsInterpolationModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_62, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_63 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_physics_interpolation_mode");

        [GodotMethod("get_physics_interpolation_mode")]
        [Obsolete("GetPhysicsInterpolationMode is deprecated. Use the PhysicsInterpolationMode property instead.")]
        public Node.PhysicsInterpolationModeEnum GetPhysicsInterpolationMode()
        {
            return (Node.PhysicsInterpolationModeEnum)NativeCalls.godot_icall_0_681(method_bind_63, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_64 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_physics_interpolated");

        /// <summary>
        /// <para>Returns <c>true</c> if the physics interpolated flag is set for this Node (see <see cref="Godot.Node.PhysicsInterpolationMode"/>).</para>
        /// <para>Note: Interpolation will only be active if both the flag is set and physics interpolation is enabled within the <see cref="Godot.SceneTree"/>. This can be tested using <see cref="Godot.Node.IsPhysicsInterpolatedAndEnabled"/>.</para>
        /// </summary>
        [GodotMethod("is_physics_interpolated")]
        public bool IsPhysicsInterpolated()
        {
            return NativeCalls.godot_icall_0_7(method_bind_64, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_65 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_physics_interpolated_and_enabled");

        /// <summary>
        /// <para>Returns <c>true</c> if physics interpolation is enabled (see <see cref="Godot.Node.PhysicsInterpolationMode"/>) and enabled in the <see cref="Godot.SceneTree"/>.</para>
        /// <para>This is a convenience version of <see cref="Godot.Node.IsPhysicsInterpolated"/> that also checks whether physics interpolation is enabled globally.</para>
        /// <para>See <see cref="Godot.SceneTree.PhysicsInterpolation"/> and .</para>
        /// </summary>
        [GodotMethod("is_physics_interpolated_and_enabled")]
        public bool IsPhysicsInterpolatedAndEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_65, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_66 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reset_physics_interpolation");

        /// <summary>
        /// <para>When physics interpolation is active, moving a node to a radically different transform (such as placement within a level) can result in a visible glitch as the object is rendered moving from the old to new position over the physics tick.</para>
        /// <para>This glitch can be prevented by calling <c>reset_physics_interpolation</c>, which temporarily turns off interpolation until the physics tick is complete.</para>
        /// <para><see cref="Godot.Node.NotificationResetPhysicsInterpolation"/> will be received by the node and all children recursively.</para>
        /// <para>Note: This function should be called after moving the node, rather than before.</para>
        /// </summary>
        [GodotMethod("reset_physics_interpolation")]
        public void ResetPhysicsInterpolation()
        {
            NativeCalls.godot_icall_0_3(method_bind_66, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_67 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tree");

        /// <summary>
        /// <para>Returns the <see cref="Godot.SceneTree"/> that contains this node.</para>
        /// </summary>
        [GodotMethod("get_tree")]
        public SceneTree GetTree()
        {
            return NativeCalls.godot_icall_0_682(method_bind_67, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_68 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_tween");

        /// <summary>
        /// <para>Creates a new <see cref="Godot.SceneTreeTween"/> and binds it to this node. This is equivalent of doing:</para>
        /// <para><code>
        /// get_tree().create_tween().bind_node(self)
        /// </code></para>
        /// </summary>
        [GodotMethod("create_tween")]
        public SceneTreeTween CreateTween()
        {
            return NativeCalls.godot_icall_0_683(method_bind_68, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_69 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "duplicate");

        /// <summary>
        /// <para>Duplicates the node, returning a new node.</para>
        /// <para>You can fine-tune the behavior using the <c>flags</c> (see <see cref="Godot.Node.DuplicateFlags"/>).</para>
        /// <para>Note: It will not work properly if the node contains a script with constructor arguments (i.e. needs to supply arguments to  method). In that case, the node will be duplicated without a script.</para>
        /// </summary>
        [GodotMethod("duplicate")]
        public Node Duplicate(int flags = 15)
        {
            return NativeCalls.godot_icall_1_460(method_bind_69, Object.GetPtr(this), flags);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_70 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "replace_by");

        /// <summary>
        /// <para>Replaces a node in a scene by the given one. Subscriptions that pass through this node will be lost.</para>
        /// <para>Note: The given node will become the new parent of any child nodes that the replaced node had.</para>
        /// <para>Note: The replaced node is not automatically freed, so you either need to keep it in a variable for later use or free it using <see cref="Godot.Object.Free"/>.</para>
        /// </summary>
        [GodotMethod("replace_by")]
        public void ReplaceBy(Node node, bool keepData = false)
        {
            NativeCalls.godot_icall_2_451(method_bind_70, Object.GetPtr(this), Object.GetPtr(node), keepData);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_71 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_scene_instance_load_placeholder");

        /// <summary>
        /// <para>Sets whether this is an instance load placeholder. See <see cref="Godot.InstancePlaceholder"/>.</para>
        /// </summary>
        [GodotMethod("set_scene_instance_load_placeholder")]
        public void SetSceneInstanceLoadPlaceholder(bool loadPlaceholder)
        {
            NativeCalls.godot_icall_1_16(method_bind_71, Object.GetPtr(this), loadPlaceholder);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_72 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_scene_instance_load_placeholder");

        /// <summary>
        /// <para>Returns <c>true</c> if this is an instance load placeholder. See <see cref="Godot.InstancePlaceholder"/>.</para>
        /// </summary>
        [GodotMethod("get_scene_instance_load_placeholder")]
        public bool GetSceneInstanceLoadPlaceholder()
        {
            return NativeCalls.godot_icall_0_7(method_bind_72, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_73 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_viewport");

        /// <summary>
        /// <para>Returns the node's <see cref="Godot.Viewport"/>.</para>
        /// </summary>
        [GodotMethod("get_viewport")]
        public Viewport GetViewport()
        {
            return NativeCalls.godot_icall_0_684(method_bind_73, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_74 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "queue_free");

        /// <summary>
        /// <para>Queues a node for deletion at the end of the current frame. When deleted, all of its child nodes will be deleted as well. This method ensures it's safe to delete the node, contrary to <see cref="Godot.Object.Free"/>. Use <see cref="Godot.Object.IsQueuedForDeletion"/> to check whether a node will be deleted at the end of the frame.</para>
        /// <para>Important: If you have a variable pointing to a node, it will not be assigned to <c>null</c> once the node is freed. Instead, it will point to a previously freed instance and you should validate it with <c>@GDScript.is_instance_valid</c> before attempting to call its methods or access its properties.</para>
        /// </summary>
        [GodotMethod("queue_free")]
        public void QueueFree()
        {
            NativeCalls.godot_icall_0_3(method_bind_74, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_75 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "request_ready");

        /// <summary>
        /// <para>Requests that <c>_ready</c> be called again. Note that the method won't be called immediately, but is scheduled for when the node is added to the scene tree again (see <see cref="Godot.Node._Ready"/>). <c>_ready</c> is called only for the node which requested it, which means that you need to request ready for each child if you want them to call <c>_ready</c> too (in which case, <c>_ready</c> will be called in the same order as it would normally).</para>
        /// </summary>
        [GodotMethod("request_ready")]
        public void RequestReady()
        {
            NativeCalls.godot_icall_0_3(method_bind_75, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_76 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_network_master");

        /// <summary>
        /// <para>Sets the node's network master to the peer with the given peer ID. The network master is the peer that has authority over the node on the network. Useful in conjunction with the <c>master</c> and <c>puppet</c> keywords. Inherited from the parent node by default, which ultimately defaults to peer ID 1 (the server). If <c>recursive</c>, the given peer is recursively set as the master for all children of this node.</para>
        /// </summary>
        [GodotMethod("set_network_master")]
        public void SetNetworkMaster(int id, bool recursive = true)
        {
            NativeCalls.godot_icall_2_23(method_bind_76, Object.GetPtr(this), id, recursive);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_77 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_network_master");

        /// <summary>
        /// <para>Returns the peer ID of the network master for this node. See <see cref="Godot.Node.SetNetworkMaster"/>.</para>
        /// </summary>
        [GodotMethod("get_network_master")]
        public int GetNetworkMaster()
        {
            return NativeCalls.godot_icall_0_5(method_bind_77, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_78 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_network_master");

        /// <summary>
        /// <para>Returns <c>true</c> if the local system is the master of this node.</para>
        /// </summary>
        [GodotMethod("is_network_master")]
        public bool IsNetworkMaster()
        {
            return NativeCalls.godot_icall_0_7(method_bind_78, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_79 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_multiplayer");

        [GodotMethod("get_multiplayer")]
        [Obsolete("GetMultiplayer is deprecated. Use the Multiplayer property instead.")]
        public MultiplayerAPI GetMultiplayer()
        {
            return NativeCalls.godot_icall_0_685(method_bind_79, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_80 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_custom_multiplayer");

        [GodotMethod("get_custom_multiplayer")]
        [Obsolete("GetCustomMultiplayer is deprecated. Use the CustomMultiplayer property instead.")]
        public MultiplayerAPI GetCustomMultiplayer()
        {
            return NativeCalls.godot_icall_0_685(method_bind_80, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_81 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_custom_multiplayer");

        [GodotMethod("set_custom_multiplayer")]
        [Obsolete("SetCustomMultiplayer is deprecated. Use the CustomMultiplayer property instead.")]
        public void SetCustomMultiplayer(MultiplayerAPI api)
        {
            NativeCalls.godot_icall_1_24(method_bind_81, Object.GetPtr(this), Object.GetPtr(api));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_82 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rpc_config");

        /// <summary>
        /// <para>Changes the RPC mode for the given <c>method</c> to the given <c>mode</c>. See <see cref="Godot.MultiplayerAPI.RPCMode"/>. An alternative is annotating methods and properties with the corresponding keywords (<c>remote</c>, <c>master</c>, <c>puppet</c>, <c>remotesync</c>, <c>mastersync</c>, <c>puppetsync</c>). By default, methods are not exposed to networking (and RPCs). See also <see cref="Godot.Node.Rset"/> and <see cref="Godot.Node.RsetConfig"/> for properties.</para>
        /// </summary>
        [GodotMethod("rpc_config")]
        public void RpcConfig(string method, MultiplayerAPI.RPCMode mode)
        {
            NativeCalls.godot_icall_2_110(method_bind_82, Object.GetPtr(this), method, (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_83 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rset_config");

        /// <summary>
        /// <para>Changes the RPC mode for the given <c>property</c> to the given <c>mode</c>. See <see cref="Godot.MultiplayerAPI.RPCMode"/>. An alternative is annotating methods and properties with the corresponding keywords (<c>remote</c>, <c>master</c>, <c>puppet</c>, <c>remotesync</c>, <c>mastersync</c>, <c>puppetsync</c>). By default, properties are not exposed to networking (and RPCs). See also <see cref="Godot.Node.Rpc"/> and <see cref="Godot.Node.RpcConfig"/> for methods.</para>
        /// </summary>
        [GodotMethod("rset_config")]
        public void RsetConfig(string property, MultiplayerAPI.RPCMode mode)
        {
            NativeCalls.godot_icall_2_110(method_bind_83, Object.GetPtr(this), property, (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_84 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_editor_description");

        [Obsolete("_SetEditorDescription is deprecated. Use the EditorDescription property instead.")]
        internal void _SetEditorDescription(string editorDescription)
        {
            NativeCalls.godot_icall_1_54(method_bind_84, Object.GetPtr(this), editorDescription);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_85 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_editor_description");

        [Obsolete("_GetEditorDescription is deprecated. Use the EditorDescription property instead.")]
        internal string _GetEditorDescription()
        {
            return NativeCalls.godot_icall_0_6(method_bind_85, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_86 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_import_path");

        [Obsolete("_SetImportPath is deprecated. Use the _ImportPath property instead.")]
        internal void _SetImportPath(NodePath importPath)
        {
            NativeCalls.godot_icall_1_129(method_bind_86, Object.GetPtr(this), NodePath.GetPtr(importPath));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_87 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_import_path");

        [Obsolete("_GetImportPath is deprecated. Use the _ImportPath property instead.")]
        internal NodePath _GetImportPath()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_87, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_88 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_unique_name_in_owner");

        [GodotMethod("set_unique_name_in_owner")]
        [Obsolete("SetUniqueNameInOwner is deprecated. Use the UniqueNameInOwner property instead.")]
        public void SetUniqueNameInOwner(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_88, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_89 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_unique_name_in_owner");

        [GodotMethod("is_unique_name_in_owner")]
        [Obsolete("IsUniqueNameInOwner is deprecated. Use the UniqueNameInOwner property instead.")]
        public bool IsUniqueNameInOwner()
        {
            return NativeCalls.godot_icall_0_7(method_bind_89, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_90 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rpc");

        /// <summary>
        /// <para>Sends a remote procedure call request for the given <c>method</c> to peers on the network (and locally), optionally sending all additional arguments as arguments to the method called by the RPC. The call request will only be received by nodes with the same <see cref="Godot.NodePath"/>, including the exact same node name. Behaviour depends on the RPC configuration for the given method, see <see cref="Godot.Node.RpcConfig"/>. Methods are not exposed to RPCs by default. See also <see cref="Godot.Node.Rset"/> and <see cref="Godot.Node.RsetConfig"/> for properties. Returns <c>null</c>.</para>
        /// <para>Note: You can only safely use RPCs on clients after you received the <c>connected_to_server</c> signal from the <see cref="Godot.SceneTree"/>. You also need to keep track of the connection state, either by the <see cref="Godot.SceneTree"/> signals like <c>server_disconnected</c> or by checking <c>SceneTree.network_peer.get_connection_status() == CONNECTION_CONNECTED</c>.</para>
        /// </summary>
        [GodotMethod("rpc")]
        public object Rpc(string method, params object[] @args)
        {
            return NativeCalls.godot_icall_2_558(method_bind_90, Object.GetPtr(this), method, @args);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_91 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rpc_unreliable");

        /// <summary>
        /// <para>Sends a <see cref="Godot.Node.Rpc"/> using an unreliable protocol. Returns <c>null</c>.</para>
        /// </summary>
        [GodotMethod("rpc_unreliable")]
        public object RpcUnreliable(string method, params object[] @args)
        {
            return NativeCalls.godot_icall_2_558(method_bind_91, Object.GetPtr(this), method, @args);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_92 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rpc_id");

        /// <summary>
        /// <para>Sends a <see cref="Godot.Node.Rpc"/> to a specific peer identified by <c>peer_id</c> (see <see cref="Godot.NetworkedMultiplayerPeer.SetTargetPeer"/>). Returns <c>null</c>.</para>
        /// </summary>
        [GodotMethod("rpc_id")]
        public object RpcId(int peerId, string method, params object[] @args)
        {
            return NativeCalls.godot_icall_3_686(method_bind_92, Object.GetPtr(this), peerId, method, @args);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_93 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rpc_unreliable_id");

        /// <summary>
        /// <para>Sends a <see cref="Godot.Node.Rpc"/> to a specific peer identified by <c>peer_id</c> using an unreliable protocol (see <see cref="Godot.NetworkedMultiplayerPeer.SetTargetPeer"/>). Returns <c>null</c>.</para>
        /// </summary>
        [GodotMethod("rpc_unreliable_id")]
        public object RpcUnreliableId(int peerId, string method, params object[] @args)
        {
            return NativeCalls.godot_icall_3_686(method_bind_93, Object.GetPtr(this), peerId, method, @args);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_94 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rset");

        /// <summary>
        /// <para>Remotely changes a property's value on other peers (and locally). Behaviour depends on the RPC configuration for the given property, see <see cref="Godot.Node.RsetConfig"/>. See also <see cref="Godot.Node.Rpc"/> for RPCs for methods, most information applies to this method as well.</para>
        /// </summary>
        [GodotMethod("rset")]
        public void Rset(string property, object value)
        {
            NativeCalls.godot_icall_2_96(method_bind_94, Object.GetPtr(this), property, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_95 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rset_id");

        /// <summary>
        /// <para>Remotely changes the property's value on a specific peer identified by <c>peer_id</c> (see <see cref="Godot.NetworkedMultiplayerPeer.SetTargetPeer"/>).</para>
        /// </summary>
        [GodotMethod("rset_id")]
        public void RsetId(int peerId, string property, object value)
        {
            NativeCalls.godot_icall_3_687(method_bind_95, Object.GetPtr(this), peerId, property, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_96 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rset_unreliable");

        /// <summary>
        /// <para>Remotely changes the property's value on other peers (and locally) using an unreliable protocol.</para>
        /// </summary>
        [GodotMethod("rset_unreliable")]
        public void RsetUnreliable(string property, object value)
        {
            NativeCalls.godot_icall_2_96(method_bind_96, Object.GetPtr(this), property, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_97 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rset_unreliable_id");

        /// <summary>
        /// <para>Remotely changes property's value on a specific peer identified by <c>peer_id</c> using an unreliable protocol (see <see cref="Godot.NetworkedMultiplayerPeer.SetTargetPeer"/>).</para>
        /// </summary>
        [GodotMethod("rset_unreliable_id")]
        public void RsetUnreliableId(int peerId, string property, object value)
        {
            NativeCalls.godot_icall_3_687(method_bind_97, Object.GetPtr(this), peerId, property, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_98 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "update_configuration_warning");

        /// <summary>
        /// <para>Updates the warning displayed for this node in the Scene Dock.</para>
        /// <para>Use <see cref="Godot.Node._GetConfigurationWarning"/> to setup the warning message to display.</para>
        /// </summary>
        [GodotMethod("update_configuration_warning")]
        public void UpdateConfigurationWarning()
        {
            NativeCalls.godot_icall_0_3(method_bind_98, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
