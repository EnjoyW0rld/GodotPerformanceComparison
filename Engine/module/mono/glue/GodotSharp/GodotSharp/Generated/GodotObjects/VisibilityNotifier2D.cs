using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The VisibilityNotifier2D detects when it is visible on the screen. It also notifies when its bounding rectangle enters or exits the screen or a viewport.</para>
    /// <para>If you want nodes to be disabled automatically when they exit the screen, use <see cref="Godot.VisibilityEnabler2D"/> instead.</para>
    /// <para>Note: For performance reasons, VisibilityNotifier2D uses an approximate heuristic with precision determined by . If you need precise visibility checking, use another method such as adding an <see cref="Godot.Area2D"/> node as a child of a <see cref="Godot.Camera2D"/> node.</para>
    /// </summary>
    public partial class VisibilityNotifier2D : Node2D
    {
        /// <summary>
        /// <para>The VisibilityNotifier2D's bounding rectangle.</para>
        /// </summary>
        public Rect2 Rect
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRect();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRect(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisibilityNotifier2D";

        public VisibilityNotifier2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisibilityNotifier2D_Ctor(this);
        }

        internal VisibilityNotifier2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rect");

        [GodotMethod("set_rect")]
        [Obsolete("SetRect is deprecated. Use the Rect property instead.")]
        public void SetRect(Rect2 rect)
        {
            NativeCalls.godot_icall_1_162(method_bind_0, Object.GetPtr(this), ref rect);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rect");

        [GodotMethod("get_rect")]
        [Obsolete("GetRect is deprecated. Use the Rect property instead.")]
        public Rect2 GetRect()
        {
            NativeCalls.godot_icall_0_163(method_bind_1, Object.GetPtr(this), out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_on_screen");

        /// <summary>
        /// <para>If <c>true</c>, the bounding rectangle is on the screen.</para>
        /// <para>Note: It takes one frame for the node's visibility to be assessed once added to the scene tree, so this method will return <c>false</c> right after it is instantiated, even if it will be on screen in the draw pass.</para>
        /// </summary>
        [GodotMethod("is_on_screen")]
        public bool IsOnScreen()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
