using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Base node for containers. A <see cref="Godot.Container"/> contains other controls and automatically arranges them in a certain way.</para>
    /// <para>A Control can inherit this to create custom container classes.</para>
    /// </summary>
    public partial class Container : Control
    {
        /// <summary>
        /// <para>Notification for when sorting the children, it must be obeyed immediately.</para>
        /// </summary>
        public const int NotificationSortChildren = 50;

        private const string nativeName = "Container";

        public Container() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Container_Ctor(this);
        }

        internal Container(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "queue_sort");

        /// <summary>
        /// <para>Queue resort of the contained children. This is called automatically anyway, but can be called upon request.</para>
        /// </summary>
        [GodotMethod("queue_sort")]
        public void QueueSort()
        {
            NativeCalls.godot_icall_0_3(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "fit_child_in_rect");

        /// <summary>
        /// <para>Fit a child control in a given rect. This is mainly a helper for creating custom container classes.</para>
        /// </summary>
        [GodotMethod("fit_child_in_rect")]
        public void FitChildInRect(Control child, Rect2 rect)
        {
            NativeCalls.godot_icall_2_311(method_bind_1, Object.GetPtr(this), Object.GetPtr(child), ref rect);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
