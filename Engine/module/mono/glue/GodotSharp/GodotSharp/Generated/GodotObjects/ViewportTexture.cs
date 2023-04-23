using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Displays the content of a <see cref="Godot.Viewport"/> node as a dynamic <see cref="Godot.Texture"/>. This can be used to mix controls, 2D, and 3D elements in the same scene.</para>
    /// <para>To create a ViewportTexture in code, use the <see cref="Godot.Viewport.GetTexture"/> method on the target viewport.</para>
    /// </summary>
    public partial class ViewportTexture : Texture
    {
        /// <summary>
        /// <para>The path to the <see cref="Godot.Viewport"/> node to display. This is relative to the scene root, not to the node which uses the texture.</para>
        /// </summary>
        public NodePath ViewportPath
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetViewportPathInScene();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetViewportPathInScene(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ViewportTexture";

        public ViewportTexture() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ViewportTexture_Ctor(this);
        }

        internal ViewportTexture(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_viewport_path_in_scene");

        [GodotMethod("set_viewport_path_in_scene")]
        [Obsolete("SetViewportPathInScene is deprecated. Use the ViewportPath property instead.")]
        public void SetViewportPathInScene(NodePath path)
        {
            NativeCalls.godot_icall_1_129(method_bind_0, Object.GetPtr(this), NodePath.GetPtr(path));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_viewport_path_in_scene");

        [GodotMethod("get_viewport_path_in_scene")]
        [Obsolete("GetViewportPathInScene is deprecated. Use the ViewportPath property instead.")]
        public NodePath GetViewportPathInScene()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_1, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
