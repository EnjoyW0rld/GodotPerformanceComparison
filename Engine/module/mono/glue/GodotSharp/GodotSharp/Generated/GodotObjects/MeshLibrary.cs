using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A library of meshes. Contains a list of <see cref="Godot.Mesh"/> resources, each with a name and ID. Each item can also include collision and navigation shapes. This resource is used in <see cref="Godot.GridMap"/>.</para>
    /// </summary>
    public partial class MeshLibrary : Resource
    {
        private const string nativeName = "MeshLibrary";

        public MeshLibrary() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_MeshLibrary_Ctor(this);
        }

        internal MeshLibrary(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_item");

        /// <summary>
        /// <para>Creates a new item in the library with the given ID.</para>
        /// <para>You can get an unused ID from <see cref="Godot.MeshLibrary.GetLastUnusedItemId"/>.</para>
        /// </summary>
        [GodotMethod("create_item")]
        public void CreateItem(int id)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_name");

        /// <summary>
        /// <para>Sets the item's name.</para>
        /// <para>This name is shown in the editor. It can also be used to look up the item later using <see cref="Godot.MeshLibrary.FindItemByName"/>.</para>
        /// </summary>
        [GodotMethod("set_item_name")]
        public void SetItemName(int id, string name)
        {
            NativeCalls.godot_icall_2_121(method_bind_1, Object.GetPtr(this), id, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_mesh");

        /// <summary>
        /// <para>Sets the item's mesh.</para>
        /// </summary>
        [GodotMethod("set_item_mesh")]
        public void SetItemMesh(int id, Mesh mesh)
        {
            NativeCalls.godot_icall_2_58(method_bind_2, Object.GetPtr(this), id, Object.GetPtr(mesh));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_mesh_transform");

        /// <summary>
        /// <para>Sets the transform to apply to the item's mesh.</para>
        /// </summary>
        [GodotMethod("set_item_mesh_transform")]
        public void SetItemMeshTransform(int id, Transform meshTransform)
        {
            NativeCalls.godot_icall_2_606(method_bind_3, Object.GetPtr(this), id, ref meshTransform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_navmesh");

        /// <summary>
        /// <para>Sets the item's navigation mesh.</para>
        /// </summary>
        [GodotMethod("set_item_navmesh")]
        public void SetItemNavmesh(int id, NavigationMesh navmesh)
        {
            NativeCalls.godot_icall_2_58(method_bind_4, Object.GetPtr(this), id, Object.GetPtr(navmesh));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_navmesh_transform");

        /// <summary>
        /// <para>Sets the transform to apply to the item's navigation mesh.</para>
        /// </summary>
        [GodotMethod("set_item_navmesh_transform")]
        public void SetItemNavmeshTransform(int id, Transform navmesh)
        {
            NativeCalls.godot_icall_2_606(method_bind_5, Object.GetPtr(this), id, ref navmesh);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_shapes");

        /// <summary>
        /// <para>Sets an item's collision shapes.</para>
        /// <para>The array should consist of <see cref="Godot.Shape"/> objects, each followed by a <see cref="Godot.Transform"/> that will be applied to it. For shapes that should not have a transform, use <c>Transform.IDENTITY</c>.</para>
        /// </summary>
        [GodotMethod("set_item_shapes")]
        public void SetItemShapes(int id, Godot.Collections.Array shapes)
        {
            NativeCalls.godot_icall_2_607(method_bind_6, Object.GetPtr(this), id, shapes.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_item_preview");

        /// <summary>
        /// <para>Sets a texture to use as the item's preview icon in the editor.</para>
        /// </summary>
        [GodotMethod("set_item_preview")]
        public void SetItemPreview(int id, Texture texture)
        {
            NativeCalls.godot_icall_2_58(method_bind_7, Object.GetPtr(this), id, Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_name");

        /// <summary>
        /// <para>Returns the item's name.</para>
        /// </summary>
        [GodotMethod("get_item_name")]
        public string GetItemName(int id)
        {
            return NativeCalls.godot_icall_1_89(method_bind_8, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_mesh");

        /// <summary>
        /// <para>Returns the item's mesh.</para>
        /// </summary>
        [GodotMethod("get_item_mesh")]
        public Mesh GetItemMesh(int id)
        {
            return NativeCalls.godot_icall_1_608(method_bind_9, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_mesh_transform");

        /// <summary>
        /// <para>Returns the transform applied to the item's mesh.</para>
        /// </summary>
        [GodotMethod("get_item_mesh_transform")]
        public Transform GetItemMeshTransform(int id)
        {
            NativeCalls.godot_icall_1_609(method_bind_10, Object.GetPtr(this), id, out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_navmesh");

        /// <summary>
        /// <para>Returns the item's navigation mesh.</para>
        /// </summary>
        [GodotMethod("get_item_navmesh")]
        public NavigationMesh GetItemNavmesh(int id)
        {
            return NativeCalls.godot_icall_1_610(method_bind_11, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_navmesh_transform");

        /// <summary>
        /// <para>Returns the transform applied to the item's navigation mesh.</para>
        /// </summary>
        [GodotMethod("get_item_navmesh_transform")]
        public Transform GetItemNavmeshTransform(int id)
        {
            NativeCalls.godot_icall_1_609(method_bind_12, Object.GetPtr(this), id, out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_shapes");

        /// <summary>
        /// <para>Returns an item's collision shapes.</para>
        /// <para>The array consists of each <see cref="Godot.Shape"/> followed by its <see cref="Godot.Transform"/>.</para>
        /// </summary>
        [GodotMethod("get_item_shapes")]
        public Godot.Collections.Array GetItemShapes(int id)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_1_483(method_bind_13, Object.GetPtr(this), id));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_preview");

        /// <summary>
        /// <para>When running in the editor, returns a generated item preview (a 3D rendering in isometric perspective). When used in a running project, returns the manually-defined item preview which can be set using <see cref="Godot.MeshLibrary.SetItemPreview"/>. Returns an empty <see cref="Godot.Texture"/> if no preview was manually set in a running project.</para>
        /// </summary>
        [GodotMethod("get_item_preview")]
        public Texture GetItemPreview(int id)
        {
            return NativeCalls.godot_icall_1_59(method_bind_14, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_item");

        /// <summary>
        /// <para>Removes the item.</para>
        /// </summary>
        [GodotMethod("remove_item")]
        public void RemoveItem(int id)
        {
            NativeCalls.godot_icall_1_4(method_bind_15, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "find_item_by_name");

        /// <summary>
        /// <para>Returns the first item with the given name.</para>
        /// </summary>
        [GodotMethod("find_item_by_name")]
        public int FindItemByName(string name)
        {
            return NativeCalls.godot_icall_1_138(method_bind_16, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Clears the library.</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_list");

        /// <summary>
        /// <para>Returns the list of item IDs in use.</para>
        /// </summary>
        [GodotMethod("get_item_list")]
        public int[] GetItemList()
        {
            return NativeCalls.godot_icall_0_103(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_last_unused_item_id");

        /// <summary>
        /// <para>Gets an unused ID for a new item.</para>
        /// </summary>
        [GodotMethod("get_last_unused_item_id")]
        public int GetLastUnusedItemId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_19, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
