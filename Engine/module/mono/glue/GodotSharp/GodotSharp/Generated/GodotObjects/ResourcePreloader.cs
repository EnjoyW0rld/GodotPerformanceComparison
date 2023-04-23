using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This node is used to preload sub-resources inside a scene, so when the scene is loaded, all the resources are ready to use and can be retrieved from the preloader.</para>
    /// <para>GDScript has a simplified <c>@GDScript.preload</c> built-in method which can be used in most situations, leaving the use of <see cref="Godot.ResourcePreloader"/> for more advanced scenarios.</para>
    /// </summary>
    public partial class ResourcePreloader : Node
    {
        public Godot.Collections.Array Resources
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetResources();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetResources(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ResourcePreloader";

        public ResourcePreloader() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ResourcePreloader_Ctor(this);
        }

        internal ResourcePreloader(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_resources");

        [Obsolete("_SetResources is deprecated. Use the Resources property instead.")]
        internal void _SetResources(Godot.Collections.Array arg0)
        {
            NativeCalls.godot_icall_1_92(method_bind_0, Object.GetPtr(this), arg0.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_resources");

        [Obsolete("_GetResources is deprecated. Use the Resources property instead.")]
        internal Godot.Collections.Array _GetResources()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_1, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_resource");

        /// <summary>
        /// <para>Adds a resource to the preloader with the given <c>name</c>. If a resource with the given <c>name</c> already exists, the new resource will be renamed to "<c>name</c> N" where N is an incrementing number starting from 2.</para>
        /// </summary>
        [GodotMethod("add_resource")]
        public void AddResource(string name, Resource resource)
        {
            NativeCalls.godot_icall_2_114(method_bind_2, Object.GetPtr(this), name, Object.GetPtr(resource));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_resource");

        /// <summary>
        /// <para>Removes the resource associated to <c>name</c> from the preloader.</para>
        /// </summary>
        [GodotMethod("remove_resource")]
        public void RemoveResource(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_3, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rename_resource");

        /// <summary>
        /// <para>Renames a resource inside the preloader from <c>name</c> to <c>newname</c>.</para>
        /// </summary>
        [GodotMethod("rename_resource")]
        public void RenameResource(string name, string newname)
        {
            NativeCalls.godot_icall_2_107(method_bind_4, Object.GetPtr(this), name, newname);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_resource");

        /// <summary>
        /// <para>Returns <c>true</c> if the preloader contains a resource associated to <c>name</c>.</para>
        /// </summary>
        [GodotMethod("has_resource")]
        public bool HasResource(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_5, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_resource");

        /// <summary>
        /// <para>Returns the resource associated to <c>name</c>.</para>
        /// </summary>
        [GodotMethod("get_resource")]
        public Resource GetResource(string name)
        {
            return NativeCalls.godot_icall_1_821(method_bind_6, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_resource_list");

        /// <summary>
        /// <para>Returns the list of resources inside the preloader.</para>
        /// </summary>
        [GodotMethod("get_resource_list")]
        public string[] GetResourceList()
        {
            return NativeCalls.godot_icall_0_119(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
