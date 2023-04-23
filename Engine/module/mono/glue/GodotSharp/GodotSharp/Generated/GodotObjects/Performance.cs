using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This class provides access to a number of different monitors related to performance, such as memory usage, draw calls, and FPS. These are the same as the values displayed in the Monitor tab in the editor's Debugger panel. By using the <see cref="Godot.Performance.GetMonitor"/> method of this class, you can access this data from your code.</para>
    /// <para>Note: A few of these monitors are only available in debug mode and will always return 0 when used in a release build.</para>
    /// <para>Note: Many of these monitors are not updated in real-time, so there may be a short delay between changes.</para>
    /// </summary>
    public static partial class Performance
    {
        public enum Monitor
        {
            /// <summary>
            /// <para>Number of frames per second.</para>
            /// </summary>
            TimeFps = 0,
            /// <summary>
            /// <para>Time it took to complete one frame, in seconds.</para>
            /// </summary>
            TimeProcess = 1,
            /// <summary>
            /// <para>Time it took to complete one physics frame, in seconds.</para>
            /// </summary>
            TimePhysicsProcess = 2,
            /// <summary>
            /// <para>Static memory currently used, in bytes. Not available in release builds.</para>
            /// </summary>
            MemoryStatic = 3,
            /// <summary>
            /// <para>Dynamic memory currently used, in bytes. Not available in release builds.</para>
            /// </summary>
            MemoryDynamic = 4,
            /// <summary>
            /// <para>Available static memory. Not available in release builds.</para>
            /// </summary>
            MemoryStaticMax = 5,
            /// <summary>
            /// <para>Available dynamic memory. Not available in release builds.</para>
            /// </summary>
            MemoryDynamicMax = 6,
            /// <summary>
            /// <para>Largest amount of memory the message queue buffer has used, in bytes. The message queue is used for deferred functions calls and notifications.</para>
            /// </summary>
            MemoryMessageBufferMax = 7,
            /// <summary>
            /// <para>Number of objects currently instanced (including nodes).</para>
            /// </summary>
            ObjectCount = 8,
            /// <summary>
            /// <para>Number of resources currently used.</para>
            /// </summary>
            ObjectResourceCount = 9,
            /// <summary>
            /// <para>Number of nodes currently instanced in the scene tree. This also includes the root node.</para>
            /// </summary>
            ObjectNodeCount = 10,
            /// <summary>
            /// <para>Number of orphan nodes, i.e. nodes which are not parented to a node of the scene tree.</para>
            /// </summary>
            ObjectOrphanNodeCount = 11,
            /// <summary>
            /// <para>3D objects drawn per frame.</para>
            /// </summary>
            RenderObjectsInFrame = 12,
            /// <summary>
            /// <para>Vertices drawn per frame. 3D only.</para>
            /// </summary>
            RenderVerticesInFrame = 13,
            /// <summary>
            /// <para>Material changes per frame. 3D only.</para>
            /// </summary>
            RenderMaterialChangesInFrame = 14,
            /// <summary>
            /// <para>Shader changes per frame. 3D only.</para>
            /// </summary>
            RenderShaderChangesInFrame = 15,
            /// <summary>
            /// <para>Render surface changes per frame. 3D only.</para>
            /// </summary>
            RenderSurfaceChangesInFrame = 16,
            /// <summary>
            /// <para>Draw calls per frame. 3D only.</para>
            /// </summary>
            RenderDrawCallsInFrame = 17,
            /// <summary>
            /// <para>Items or joined items drawn per frame.</para>
            /// </summary>
            Render2dItemsInFrame = 18,
            /// <summary>
            /// <para>Draw calls per frame.</para>
            /// </summary>
            Render2dDrawCallsInFrame = 19,
            /// <summary>
            /// <para>The amount of video memory used, i.e. texture and vertex memory combined.</para>
            /// </summary>
            RenderVideoMemUsed = 20,
            /// <summary>
            /// <para>The amount of texture memory used.</para>
            /// </summary>
            RenderTextureMemUsed = 21,
            /// <summary>
            /// <para>The amount of vertex memory used.</para>
            /// </summary>
            RenderVertexMemUsed = 22,
            /// <summary>
            /// <para>Unimplemented in the GLES2 and GLES3 rendering backends, always returns 0.</para>
            /// </summary>
            RenderUsageVideoMemTotal = 23,
            /// <summary>
            /// <para>Number of active <see cref="Godot.RigidBody2D"/> nodes in the game.</para>
            /// </summary>
            Physics2dActiveObjects = 24,
            /// <summary>
            /// <para>Number of collision pairs in the 2D physics engine.</para>
            /// </summary>
            Physics2dCollisionPairs = 25,
            /// <summary>
            /// <para>Number of islands in the 2D physics engine.</para>
            /// </summary>
            Physics2dIslandCount = 26,
            /// <summary>
            /// <para>Number of active <see cref="Godot.RigidBody"/> and <see cref="Godot.VehicleBody"/> nodes in the game.</para>
            /// </summary>
            Physics3dActiveObjects = 27,
            /// <summary>
            /// <para>Number of collision pairs in the 3D physics engine.</para>
            /// </summary>
            Physics3dCollisionPairs = 28,
            /// <summary>
            /// <para>Number of islands in the 3D physics engine.</para>
            /// </summary>
            Physics3dIslandCount = 29,
            /// <summary>
            /// <para>Output latency of the <see cref="Godot.AudioServer"/>.</para>
            /// </summary>
            AudioOutputLatency = 30,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.Performance.Monitor"/> enum.</para>
            /// </summary>
            MonitorMax = 31
        }

        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(Performance).Name);
                return singleton;
            }
        }

        private const string nativeName = "Performance";
        internal static IntPtr ptr = NativeCalls.godot_icall_Performance_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_monitor");

        /// <summary>
        /// <para>Returns the value of one of the available monitors. You should provide one of the <see cref="Godot.Performance.Monitor"/> constants as the argument, like this:</para>
        /// <para><code>
        /// print(Performance.get_monitor(Performance.TIME_FPS)) # Prints the FPS to the console
        /// </code></para>
        /// </summary>
        [GodotMethod("get_monitor")]
        public static float GetMonitor(Performance.Monitor monitor)
        {
            return NativeCalls.godot_icall_1_12(method_bind_0, ptr, (int)monitor);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
