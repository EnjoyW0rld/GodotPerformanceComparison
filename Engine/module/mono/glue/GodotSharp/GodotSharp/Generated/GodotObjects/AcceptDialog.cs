using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This dialog is useful for small notifications to the user about an event. It can only be accepted or closed, with the same result.</para>
    /// </summary>
    public partial class AcceptDialog : WindowDialog
    {
        /// <summary>
        /// <para>The text displayed by the dialog.</para>
        /// </summary>
        public string DialogText
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetText();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetText(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the dialog is hidden when the OK button is pressed. You can set it to <c>false</c> if you want to do e.g. input validation when receiving the <c>confirmed</c> signal, and handle hiding the dialog in your own logic.</para>
        /// <para>Note: Some nodes derived from this class can have a different default value, and potentially their own built-in logic overriding this setting. For example <see cref="Godot.FileDialog"/> defaults to <c>false</c>, and has its own input validation code that is called when you press OK, which eventually hides the dialog if the input is valid. As such, this property can't be used in <see cref="Godot.FileDialog"/> to disable hiding the dialog when pressing OK.</para>
        /// </summary>
        public bool DialogHideOnOk
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHideOnOk();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHideOnOk(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets autowrapping for the text in the dialog.</para>
        /// </summary>
        public bool DialogAutowrap
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return HasAutowrap();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAutowrap(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AcceptDialog";

        public AcceptDialog() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AcceptDialog_Ctor(this);
        }

        internal AcceptDialog(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ok");

        /// <summary>
        /// <para>Returns the OK <see cref="Godot.Button"/> instance.</para>
        /// <para>Warning: This is a required internal node, removing and freeing it may cause a crash. If you wish to hide it or any of its children, use their <see cref="Godot.CanvasItem.Visible"/> property.</para>
        /// </summary>
        [GodotMethod("get_ok")]
        public Button GetOk()
        {
            return NativeCalls.godot_icall_0_49(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_label");

        /// <summary>
        /// <para>Returns the label used for built-in text.</para>
        /// <para>Warning: This is a required internal node, removing and freeing it may cause a crash. If you wish to hide it or any of its children, use their <see cref="Godot.CanvasItem.Visible"/> property.</para>
        /// </summary>
        [GodotMethod("get_label")]
        public Label GetLabel()
        {
            return NativeCalls.godot_icall_0_50(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_hide_on_ok");

        [GodotMethod("set_hide_on_ok")]
        [Obsolete("SetHideOnOk is deprecated. Use the DialogHideOnOk property instead.")]
        public void SetHideOnOk(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_hide_on_ok");

        [GodotMethod("get_hide_on_ok")]
        [Obsolete("GetHideOnOk is deprecated. Use the DialogHideOnOk property instead.")]
        public bool GetHideOnOk()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_button");

        /// <summary>
        /// <para>Adds a button with label <c>text</c> and a custom <c>action</c> to the dialog and returns the created button. <c>action</c> will be passed to the <c>custom_action</c> signal when pressed.</para>
        /// <para>If <c>true</c>, <c>right</c> will place the button to the right of any sibling buttons.</para>
        /// <para>You can use <see cref="Godot.AcceptDialog.RemoveButton"/> method to remove a button created with this method from the dialog.</para>
        /// </summary>
        [GodotMethod("add_button")]
        public Button AddButton(string text, bool right = false, string action = "")
        {
            return NativeCalls.godot_icall_3_51(method_bind_4, Object.GetPtr(this), text, right, action);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_cancel");

        /// <summary>
        /// <para>Adds a button with label <c>name</c> and a cancel action to the dialog and returns the created button.</para>
        /// <para>You can use <see cref="Godot.AcceptDialog.RemoveButton"/> method to remove a button created with this method from the dialog.</para>
        /// </summary>
        [GodotMethod("add_cancel")]
        public Button AddCancel(string name)
        {
            return NativeCalls.godot_icall_1_52(method_bind_5, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_button");

        /// <summary>
        /// <para>Removes the <c>button</c> from the dialog. Does NOT free the <c>button</c>. The <c>button</c> must be a <see cref="Godot.Button"/> added with <see cref="Godot.AcceptDialog.AddButton"/> or <see cref="Godot.AcceptDialog.AddCancel"/> method. After removal, pressing the <c>button</c> will no longer emit this dialog's <c>custom_action</c> signal or cancel this dialog.</para>
        /// </summary>
        [GodotMethod("remove_button")]
        public void RemoveButton(Control button)
        {
            NativeCalls.godot_icall_1_53(method_bind_6, Object.GetPtr(this), Object.GetPtr(button));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "register_text_enter");

        /// <summary>
        /// <para>Registers a <see cref="Godot.LineEdit"/> in the dialog. When the enter key is pressed, the dialog will be accepted.</para>
        /// </summary>
        [GodotMethod("register_text_enter")]
        public void RegisterTextEnter(Node lineEdit)
        {
            NativeCalls.godot_icall_1_53(method_bind_7, Object.GetPtr(this), Object.GetPtr(lineEdit));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_text");

        [GodotMethod("set_text")]
        [Obsolete("SetText is deprecated. Use the DialogText property instead.")]
        public void SetText(string text)
        {
            NativeCalls.godot_icall_1_54(method_bind_8, Object.GetPtr(this), text);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_text");

        [GodotMethod("get_text")]
        [Obsolete("GetText is deprecated. Use the DialogText property instead.")]
        public string GetText()
        {
            return NativeCalls.godot_icall_0_6(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_autowrap");

        [GodotMethod("set_autowrap")]
        [Obsolete("SetAutowrap is deprecated. Use the DialogAutowrap property instead.")]
        public void SetAutowrap(bool autowrap)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), autowrap);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_autowrap");

        [GodotMethod("has_autowrap")]
        [Obsolete("HasAutowrap is deprecated. Use the DialogAutowrap property instead.")]
        public bool HasAutowrap()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
