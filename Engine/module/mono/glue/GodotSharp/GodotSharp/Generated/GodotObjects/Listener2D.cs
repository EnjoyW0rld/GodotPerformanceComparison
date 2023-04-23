using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Once added to the scene tree and enabled using <see cref="Godot.Listener2D.MakeCurrent"/>, this node will override the location sounds are heard from. Only one <see cref="Godot.Listener2D"/> can be current. Using <see cref="Godot.Listener2D.MakeCurrent"/> will disable the previous <see cref="Godot.Listener2D"/>.</para>
    /// <para>If there is no active <see cref="Godot.Listener2D"/> in the current <see cref="Godot.Viewport"/>, center of the screen will be used as a hearing point for the audio. <see cref="Godot.Listener2D"/> needs to be inside <see cref="Godot.SceneTree"/> to function.</para>
    /// </summary>
    public partial class Listener2D : Node2D
    {
        private const string nativeName = "Listener2D";

        public Listener2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Listener2D_Ctor(this);
        }

        internal Listener2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "make_current");

        /// <summary>
        /// <para>Makes the <see cref="Godot.Listener2D"/> active, setting it as the hearing point for the sounds. If there is already another active <see cref="Godot.Listener2D"/>, it will be disabled.</para>
        /// <para>This method will have no effect if the <see cref="Godot.Listener2D"/> is not added to <see cref="Godot.SceneTree"/>.</para>
        /// </summary>
        [GodotMethod("make_current")]
        public void MakeCurrent()
        {
            NativeCalls.godot_icall_0_3(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_current");

        /// <summary>
        /// <para>Disables the <see cref="Godot.Listener2D"/>. If it's not set as current, this method will have no effect.</para>
        /// </summary>
        [GodotMethod("clear_current")]
        public void ClearCurrent()
        {
            NativeCalls.godot_icall_0_3(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_current");

        /// <summary>
        /// <para>Returns <c>true</c> if this <see cref="Godot.Listener2D"/> is currently active.</para>
        /// </summary>
        [GodotMethod("is_current")]
        public bool IsCurrent()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
