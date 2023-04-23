using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This class is responsible for creating and clearing 3D navigation meshes used as <see cref="Godot.NavigationMesh"/> resources inside <see cref="Godot.NavigationMeshInstance"/>. The <see cref="Godot.NavigationMeshGenerator"/> has very limited to no use for 2D as the navigation mesh baking process expects 3D node types and 3D source geometry to parse.</para>
    /// <para>The entire navigation mesh baking is best done in a separate thread as the voxelization, collision tests and mesh optimization steps involved are very performance and time hungry operations.</para>
    /// <para>Navigation mesh baking happens in multiple steps and the result depends on 3D source geometry and properties of the <see cref="Godot.NavigationMesh"/> resource. In the first step, starting from a root node and depending on <see cref="Godot.NavigationMesh"/> properties all valid 3D source geometry nodes are collected from the <see cref="Godot.SceneTree"/>. Second, all collected nodes are parsed for their relevant 3D geometry data and a combined 3D mesh is build. Due to the many different types of parsable objects, from normal <see cref="Godot.MeshInstance"/>s to <see cref="Godot.CSGShape"/>s or various <see cref="Godot.CollisionObject"/>s, some operations to collect geometry data can trigger <see cref="Godot.VisualServer"/> and <see cref="Godot.PhysicsServer"/> synchronizations. Server synchronization can have a negative effect on baking time or framerate as it often involves <see cref="Godot.Mutex"/> locking for thread security. Many parsable objects and the continuous synchronization with other threaded Servers can increase the baking time significantly. On the other hand only a few but very large and complex objects will take some time to prepare for the Servers which can noticeably stall the next frame render. As a general rule the total amount of parsable objects and their individual size and complexity should be balanced to avoid framerate issues or very long baking times. The combined mesh is then passed to the Recast Navigation Object to test the source geometry for walkable terrain suitable to <see cref="Godot.NavigationMesh"/> agent properties by creating a voxel world around the meshes bounding area.</para>
    /// <para>The finalized navigation mesh is then returned and stored inside the <see cref="Godot.NavigationMesh"/> for use as a resource inside <see cref="Godot.NavigationMeshInstance"/> nodes.</para>
    /// <para>Note: Using meshes to not only define walkable surfaces but also obstruct navigation baking does not always work. The navigation baking has no concept of what is a geometry "inside" when dealing with mesh source geometry and this is intentional. Depending on current baking parameters, as soon as the obstructing mesh is large enough to fit a navigation mesh area inside, the baking will generate navigation mesh areas that are inside the obstructing source geometry mesh.</para>
    /// </summary>
    public static partial class NavigationMeshGenerator
    {
        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(NavigationMeshGenerator).Name);
                return singleton;
            }
        }

        private const string nativeName = "NavigationMeshGenerator";
        internal static IntPtr ptr = NativeCalls.godot_icall_NavigationMeshGenerator_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "bake");

        /// <summary>
        /// <para>Bakes navigation data to the provided <c>nav_mesh</c> by parsing child nodes under the provided <c>root_node</c> or a specific group of nodes for potential source geometry. The parse behavior can be controlled with the <see cref="Godot.NavigationMesh.GeometryParsedGeometryType"/> and <see cref="Godot.NavigationMesh.GeometrySourceGeometryMode"/> properties on the <see cref="Godot.NavigationMesh"/> resource.</para>
        /// </summary>
        [GodotMethod("bake")]
        public static void Bake(NavigationMesh navMesh, Node rootNode)
        {
            NativeCalls.godot_icall_2_651(method_bind_0, ptr, Object.GetPtr(navMesh), Object.GetPtr(rootNode));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Removes all polygons and vertices from the provided <c>nav_mesh</c> resource.</para>
        /// </summary>
        [GodotMethod("clear")]
        public static void Clear(NavigationMesh navMesh)
        {
            NativeCalls.godot_icall_1_24(method_bind_1, ptr, Object.GetPtr(navMesh));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
