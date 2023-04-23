using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Popup is a base <see cref="Godot.Control"/> used to show dialogs and popups. It's a subwindow and modal by default (see <see cref="Godot.Control"/>) and has helpers for custom popup behavior. All popup methods ensure correct placement within the viewport.</para>
    /// </summary>
    public partial class Popup : Control
    {
        /// <summary>
        /// <para>Notification sent right after the popup is shown.</para>
        /// </summary>
        public const int NotificationPostPopup = 80;
        /// <summary>
        /// <para>Notification sent right after the popup is hidden.</para>
        /// </summary>
        public const int NotificationPopupHide = 81;

        /// <summary>
        /// <para>If <c>true</c>, the popup will not be hidden when a click event occurs outside of it, or when it receives the <c>ui_cancel</c> action event.</para>
        /// <para>Note: Enabling this property doesn't affect the Close or Cancel buttons' behavior in dialogs that inherit from this class. As a workaround, you can use <see cref="Godot.WindowDialog.GetCloseButton"/> or <see cref="Godot.ConfirmationDialog.GetCancel"/> and hide the buttons in question by setting their <see cref="Godot.CanvasItem.Visible"/> property to <c>false</c>.</para>
        /// </summary>
        public bool PopupExclusive
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsExclusive();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExclusive(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Popup";

        public Popup() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Popup_Ctor(this);
        }

        internal Popup(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_as_minsize");

        /// <summary>
        /// <para>Shrink popup to keep to the minimum size of content.</para>
        /// </summary>
        [GodotMethod("set_as_minsize")]
        public void SetAsMinsize()
        {
            NativeCalls.godot_icall_0_3(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "popup_centered");

        /// <summary>
        /// <para>Popup (show the control in modal form) in the center of the screen relative to its current canvas transform, at the current size, or at a size determined by <c>size</c>.</para>
        /// </summary>
        /// <param name="size">If the parameter is null, then the default value is new Vector2(0, 0)</param>
        [GodotMethod("popup_centered")]
        public void PopupCentered(Nullable<Vector2> size = null)
        {
            Vector2 size_in = size.HasValue ? size.Value : new Vector2(0, 0);
            NativeCalls.godot_icall_1_57(method_bind_1, Object.GetPtr(this), ref size_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "popup_centered_ratio");

        /// <summary>
        /// <para>Popup (show the control in modal form) in the center of the screen relative to the current canvas transform, scaled at a ratio of size of the screen.</para>
        /// </summary>
        [GodotMethod("popup_centered_ratio")]
        public void PopupCenteredRatio(float ratio = 0.75f)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), ratio);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "popup_centered_minsize");

        /// <summary>
        /// <para>Popup (show the control in modal form) in the center of the screen relative to the current canvas transform, ensuring the size is never smaller than <c>minsize</c>.</para>
        /// </summary>
        /// <param name="minsize">If the parameter is null, then the default value is new Vector2(0, 0)</param>
        [GodotMethod("popup_centered_minsize")]
        public void PopupCenteredMinsize(Nullable<Vector2> minsize = null)
        {
            Vector2 minsize_in = minsize.HasValue ? minsize.Value : new Vector2(0, 0);
            NativeCalls.godot_icall_1_57(method_bind_3, Object.GetPtr(this), ref minsize_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "popup_centered_clamped");

        /// <summary>
        /// <para>Popup (show the control in modal form) in the center of the screen relative to the current canvas transform, clamping the size to <c>size</c>, then ensuring the popup is no larger than the viewport size multiplied by <c>fallback_ratio</c>.</para>
        /// </summary>
        /// <param name="size">If the parameter is null, then the default value is new Vector2(0, 0)</param>
        [GodotMethod("popup_centered_clamped")]
        public void PopupCenteredClamped(Nullable<Vector2> size = null, float fallbackRatio = 0.75f)
        {
            Vector2 size_in = size.HasValue ? size.Value : new Vector2(0, 0);
            NativeCalls.godot_icall_2_797(method_bind_4, Object.GetPtr(this), ref size_in, fallbackRatio);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "popup");

        /// <summary>
        /// <para>Popup (show the control in modal form).</para>
        /// </summary>
        /// <param name="bounds">If the parameter is null, then the default value is new Rect2(new Vector2(0, 0), new Vector2(0, 0))</param>
        [GodotMethod("popup")]
        public void Popup_(Nullable<Rect2> bounds = null)
        {
            Rect2 bounds_in = bounds.HasValue ? bounds.Value : new Rect2(new Vector2(0, 0), new Vector2(0, 0));
            NativeCalls.godot_icall_1_162(method_bind_5, Object.GetPtr(this), ref bounds_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_exclusive");

        [GodotMethod("set_exclusive")]
        [Obsolete("SetExclusive is deprecated. Use the PopupExclusive property instead.")]
        public void SetExclusive(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_exclusive");

        [GodotMethod("is_exclusive")]
        [Obsolete("IsExclusive is deprecated. Use the PopupExclusive property instead.")]
        public bool IsExclusive()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
