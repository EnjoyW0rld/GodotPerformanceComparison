using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Dialog for confirmation of actions. This dialog inherits from <see cref="Godot.AcceptDialog"/>, but has by default an OK and Cancel button (in host OS order).</para>
    /// <para>To get cancel action, you can use:</para>
    /// <para><code>
    /// get_cancel().connect("pressed", self, "cancelled")
    /// </code>.</para>
    /// </summary>
    public partial class ConfirmationDialog : AcceptDialog
    {
        private const string nativeName = "ConfirmationDialog";

        public ConfirmationDialog() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ConfirmationDialog_Ctor(this);
        }

        internal ConfirmationDialog(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cancel");

        /// <summary>
        /// <para>Returns the cancel button.</para>
        /// <para>Warning: This is a required internal node, removing and freeing it may cause a crash. If you wish to hide it or any of its children, use their <see cref="Godot.CanvasItem.Visible"/> property.</para>
        /// </summary>
        [GodotMethod("get_cancel")]
        public Button GetCancel()
        {
            return NativeCalls.godot_icall_0_49(method_bind_0, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
