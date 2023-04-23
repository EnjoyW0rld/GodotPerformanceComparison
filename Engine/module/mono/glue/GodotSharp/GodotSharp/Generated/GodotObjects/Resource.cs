using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Resource is the base class for all Godot-specific resource types, serving primarily as data containers. Since they inherit from <see cref="Godot.Reference"/>, resources are reference-counted and freed when no longer in use. They are also cached once loaded from disk, so that any further attempts to load a resource from a given path will return the same reference (all this in contrast to a <see cref="Godot.Node"/>, which is not reference-counted and can be instanced from disk as many times as desired). Resources can be saved externally on disk or bundled into another object, such as a <see cref="Godot.Node"/> or another resource.</para>
    /// <para>Note: In C#, resources will not be freed instantly after they are no longer in use. Instead, garbage collection will run periodically and will free resources that are no longer in use. This means that unused resources will linger on for a while before being removed.</para>
    /// </summary>
    public partial class Resource : Reference
    {
        /// <summary>
        /// <para>If <c>true</c>, the resource will be made unique in each instance of its local scene. It can thus be modified in a scene instance without impacting other instances of that same scene.</para>
        /// </summary>
        public bool ResourceLocalToScene
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsLocalToScene();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLocalToScene(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The path to the resource. In case it has its own file, it will return its filepath. If it's tied to the scene, it will return the scene's path, followed by the resource's index.</para>
        /// </summary>
        public string ResourcePath
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPath();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPath(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The name of the resource. This is an optional identifier. If <see cref="Godot.Resource.ResourceName"/> is not empty, its value will be displayed to represent the current resource in the editor inspector. For built-in scripts, the <see cref="Godot.Resource.ResourceName"/> will be displayed as the tab name in the script editor.</para>
        /// </summary>
        public string ResourceName
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

        private const string nativeName = "Resource";

        public Resource() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Resource_Ctor(this);
        }

        internal Resource(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>Virtual function which can be overridden to customize the behavior value of <see cref="Godot.Resource.SetupLocalToScene"/>.</para>
        /// </summary>
        [GodotMethod("_setup_local_to_scene")]
        public virtual void _SetupLocalToScene()
        {
            return;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_path");

        [GodotMethod("set_path")]
        [Obsolete("SetPath is deprecated. Use the ResourcePath property instead.")]
        public void SetPath(string path)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "take_over_path");

        /// <summary>
        /// <para>Sets the path of the resource, potentially overriding an existing cache entry for this path. This differs from setting <see cref="Godot.Resource.ResourcePath"/>, as the latter would error out if another resource was already cached for the given path.</para>
        /// </summary>
        [GodotMethod("take_over_path")]
        public void TakeOverPath(string path)
        {
            NativeCalls.godot_icall_1_54(method_bind_1, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_path");

        [GodotMethod("get_path")]
        [Obsolete("GetPath is deprecated. Use the ResourcePath property instead.")]
        public string GetPath()
        {
            return NativeCalls.godot_icall_0_6(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_name");

        [GodotMethod("set_name")]
        [Obsolete("SetName is deprecated. Use the ResourceName property instead.")]
        public void SetName(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_3, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_name");

        [GodotMethod("get_name")]
        [Obsolete("GetName is deprecated. Use the ResourceName property instead.")]
        public string GetName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rid");

        /// <summary>
        /// <para>Returns the RID of the resource (or an empty RID). Many resources (such as <see cref="Godot.Texture"/>, <see cref="Godot.Mesh"/>, etc) are high-level abstractions of resources stored in a server, so this function will return the original RID.</para>
        /// </summary>
        [GodotMethod("get_rid")]
        public RID GetRid()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_5, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_local_to_scene");

        [GodotMethod("set_local_to_scene")]
        [Obsolete("SetLocalToScene is deprecated. Use the ResourceLocalToScene property instead.")]
        public void SetLocalToScene(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_local_to_scene");

        [GodotMethod("is_local_to_scene")]
        [Obsolete("IsLocalToScene is deprecated. Use the ResourceLocalToScene property instead.")]
        public bool IsLocalToScene()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_local_scene");

        /// <summary>
        /// <para>If <see cref="Godot.Resource.ResourceLocalToScene"/> is enabled and the resource was loaded from a <see cref="Godot.PackedScene"/> instantiation, returns the local scene where this resource's unique copy is in use. Otherwise, returns <c>null</c>.</para>
        /// </summary>
        [GodotMethod("get_local_scene")]
        public Node GetLocalScene()
        {
            return NativeCalls.godot_icall_0_257(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "setup_local_to_scene");

        /// <summary>
        /// <para>This method is called when a resource with <see cref="Godot.Resource.ResourceLocalToScene"/> enabled is loaded from a <see cref="Godot.PackedScene"/> instantiation. Its behavior can be customized by overriding <see cref="Godot.Resource._SetupLocalToScene"/> from script.</para>
        /// <para>For most resources, this method performs no base logic. <see cref="Godot.ViewportTexture"/> performs custom logic to properly set the proxy texture and flags in the local viewport.</para>
        /// </summary>
        [GodotMethod("setup_local_to_scene")]
        public void SetupLocalToScene()
        {
            NativeCalls.godot_icall_0_3(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "emit_changed");

        /// <summary>
        /// <para>Emits the <c>changed</c> signal.</para>
        /// <para>If external objects which depend on this resource should be updated, this method must be called manually whenever the state of this resource has changed (such as modification of properties).</para>
        /// <para>The method is equivalent to:</para>
        /// <para><code>
        /// emit_signal("changed")
        /// </code></para>
        /// <para>Note: This method is called automatically for built-in resources.</para>
        /// </summary>
        [GodotMethod("emit_changed")]
        public void EmitChanged()
        {
            NativeCalls.godot_icall_0_3(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "duplicate");

        /// <summary>
        /// <para>Duplicates the resource, returning a new resource with the exported members copied. Note: To duplicate the resource the constructor is called without arguments. This method will error when the constructor doesn't have default values.</para>
        /// <para>By default, sub-resources are shared between resource copies for efficiency. This can be changed by passing <c>true</c> to the <c>subresources</c> argument which will copy the subresources.</para>
        /// <para>Note: If <c>subresources</c> is <c>true</c>, this method will only perform a shallow copy. Nested resources within subresources will not be duplicated and will still be shared.</para>
        /// <para>Note: When duplicating a resource, only <c>export</c>ed properties are copied. Other properties will be set to their default value in the new resource.</para>
        /// </summary>
        [GodotMethod("duplicate")]
        public Resource Duplicate(bool subresources = false)
        {
            return NativeCalls.godot_icall_1_820(method_bind_11, Object.GetPtr(this), subresources);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
