using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Once added to the scene tree and enabled using <see cref="Godot.Listener.MakeCurrent"/>, this node will override the location sounds are heard from. This can be used to listen from a location different from the <see cref="Godot.Camera"/>.</para>
    /// </summary>
    public partial class Listener : Spatial
    {
        private const string nativeName = "Listener";

        public Listener() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Listener_Ctor(this);
        }

        internal Listener(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "make_current");

        /// <summary>
        /// <para>Enables the listener. This will override the current camera's listener.</para>
        /// </summary>
        [GodotMethod("make_current")]
        public void MakeCurrent()
        {
            NativeCalls.godot_icall_0_3(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_current");

        /// <summary>
        /// <para>Disables the listener to use the current camera's listener instead.</para>
        /// </summary>
        [GodotMethod("clear_current")]
        public void ClearCurrent()
        {
            NativeCalls.godot_icall_0_3(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_current");

        /// <summary>
        /// <para>Returns <c>true</c> if the listener was made current using <see cref="Godot.Listener.MakeCurrent"/>, <c>false</c> otherwise.</para>
        /// <para>Note: There may be more than one Listener marked as "current" in the scene tree, but only the one that was made current last will be used.</para>
        /// </summary>
        [GodotMethod("is_current")]
        public bool IsCurrent()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_listener_transform");

        /// <summary>
        /// <para>Returns the listener's global orthonormalized <see cref="Godot.Transform"/>.</para>
        /// </summary>
        [GodotMethod("get_listener_transform")]
        public Transform GetListenerTransform()
        {
            NativeCalls.godot_icall_0_22(method_bind_3, Object.GetPtr(this), out Transform argRet); return (Transform)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
