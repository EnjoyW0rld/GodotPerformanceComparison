using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This object is used to generate previews for resources of files.</para>
    /// <para>Note: This class shouldn't be instantiated directly. Instead, access the singleton using <see cref="Godot.EditorInterface.GetResourcePreviewer"/>.</para>
    /// </summary>
    public abstract partial class EditorResourcePreview : Node
    {
        private const string nativeName = "EditorResourcePreview";

        internal EditorResourcePreview() {}

        internal EditorResourcePreview(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "queue_resource_preview");

        /// <summary>
        /// <para>Queue a resource file located at <c>path</c> for preview. Once the preview is ready, the <c>receiver</c>'s <c>receiver_func</c> will be called. The <c>receiver_func</c> must take the following four arguments: <see cref="string"/> path, <see cref="Godot.Texture"/> preview, <see cref="Godot.Texture"/> thumbnail_preview, <c>Variant</c> userdata. <c>userdata</c> can be anything, and will be returned when <c>receiver_func</c> is called.</para>
        /// <para>Note: If it was not possible to create the preview the <c>receiver_func</c> will still be called, but the preview will be null.</para>
        /// </summary>
        [GodotMethod("queue_resource_preview")]
        public void QueueResourcePreview(string path, Object receiver, string receiverFunc, object userdata)
        {
            EditorNativeCalls.godot_icall_4_392(method_bind_0, Object.GetPtr(this), path, Object.GetPtr(receiver), receiverFunc, userdata);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "queue_edited_resource_preview");

        /// <summary>
        /// <para>Queue the <c>resource</c> being edited for preview. Once the preview is ready, the <c>receiver</c>'s <c>receiver_func</c> will be called. The <c>receiver_func</c> must take the following four arguments: <see cref="string"/> path, <see cref="Godot.Texture"/> preview, <see cref="Godot.Texture"/> thumbnail_preview, <c>Variant</c> userdata. <c>userdata</c> can be anything, and will be returned when <c>receiver_func</c> is called.</para>
        /// <para>Note: If it was not possible to create the preview the <c>receiver_func</c> will still be called, but the preview will be null.</para>
        /// </summary>
        [GodotMethod("queue_edited_resource_preview")]
        public void QueueEditedResourcePreview(Resource resource, Object receiver, string receiverFunc, object userdata)
        {
            EditorNativeCalls.godot_icall_4_403(method_bind_1, Object.GetPtr(this), Object.GetPtr(resource), Object.GetPtr(receiver), receiverFunc, userdata);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_preview_generator");

        /// <summary>
        /// <para>Create an own, custom preview generator.</para>
        /// </summary>
        [GodotMethod("add_preview_generator")]
        public void AddPreviewGenerator(EditorResourcePreviewGenerator generator)
        {
            NativeCalls.godot_icall_1_24(method_bind_2, Object.GetPtr(this), Object.GetPtr(generator));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_preview_generator");

        /// <summary>
        /// <para>Removes a custom preview generator.</para>
        /// </summary>
        [GodotMethod("remove_preview_generator")]
        public void RemovePreviewGenerator(EditorResourcePreviewGenerator generator)
        {
            NativeCalls.godot_icall_1_24(method_bind_3, Object.GetPtr(this), Object.GetPtr(generator));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "check_for_invalidation");

        /// <summary>
        /// <para>Check if the resource changed, if so, it will be invalidated and the corresponding signal emitted.</para>
        /// </summary>
        [GodotMethod("check_for_invalidation")]
        public void CheckForInvalidation(string path)
        {
            NativeCalls.godot_icall_1_54(method_bind_4, Object.GetPtr(this), path);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
