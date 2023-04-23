using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Turning on the option Load As Placeholder for an instanced scene in the editor causes it to be replaced by an InstancePlaceholder when running the game. This makes it possible to delay actually loading the scene until calling <see cref="Godot.InstancePlaceholder.ReplaceByInstance"/>. This is useful to avoid loading large scenes all at once by loading parts of it selectively.</para>
    /// <para>The InstancePlaceholder does not have a transform. This causes any child nodes to be positioned relatively to the Viewport from point (0,0), rather than their parent as displayed in the editor. Replacing the placeholder with a scene with a transform will transform children relatively to their parent again.</para>
    /// </summary>
    public abstract partial class InstancePlaceholder : Node
    {
        private const string nativeName = "InstancePlaceholder";

        internal InstancePlaceholder() {}

        internal InstancePlaceholder(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stored_values");

        /// <summary>
        /// <para>Returns the list of properties that will be applied to the node when <see cref="Godot.InstancePlaceholder.CreateInstance"/> is called.</para>
        /// <para>If <c>with_order</c> is <c>true</c>, a key named <c>.order</c> (note the leading period) is added to the dictionary. This <c>.order</c> key is an <see cref="Godot.Collections.Array"/> of <see cref="string"/> property names specifying the order in which properties will be applied (with index 0 being the first).</para>
        /// </summary>
        [GodotMethod("get_stored_values")]
        public Godot.Collections.Dictionary GetStoredValues(bool withOrder = false)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_1_536(method_bind_0, Object.GetPtr(this), withOrder));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_instance");

        /// <summary>
        /// <para>Call this method to actually load in the node. The created node will be placed as a sibling above the <see cref="Godot.InstancePlaceholder"/> in the scene tree. The <see cref="Godot.Node"/>'s reference is also returned for convenience.</para>
        /// <para>Note: <see cref="Godot.InstancePlaceholder.CreateInstance"/> is not thread-safe. Use <see cref="Godot.Object.CallDeferred"/> if calling from a thread.</para>
        /// </summary>
        [GodotMethod("create_instance")]
        public Node CreateInstance(bool replace = false, PackedScene customScene = null)
        {
            return NativeCalls.godot_icall_2_537(method_bind_1, Object.GetPtr(this), replace, Object.GetPtr(customScene));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "replace_by_instance");

        /// <summary>
        /// <para>Replaces this placeholder by the scene handed as an argument, or the original scene if no argument is given. As for all resources, the scene is loaded only if it's not loaded already. By manually loading the scene beforehand, delays caused by this function can be avoided.</para>
        /// </summary>
        [GodotMethod("replace_by_instance")]
        public void ReplaceByInstance(PackedScene customScene = null)
        {
            NativeCalls.godot_icall_1_24(method_bind_2, Object.GetPtr(this), Object.GetPtr(customScene));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_instance_path");

        /// <summary>
        /// <para>Gets the path to the <see cref="Godot.PackedScene"/> resource file that is loaded by default when calling <see cref="Godot.InstancePlaceholder.ReplaceByInstance"/>. Not thread-safe. Use <see cref="Godot.Object.CallDeferred"/> if calling from a thread.</para>
        /// </summary>
        [GodotMethod("get_instance_path")]
        public string GetInstancePath()
        {
            return NativeCalls.godot_icall_0_6(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
