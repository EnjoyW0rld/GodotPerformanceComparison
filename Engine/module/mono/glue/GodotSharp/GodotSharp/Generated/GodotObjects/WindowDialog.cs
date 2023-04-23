using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Windowdialog is the base class for all window-based dialogs. It's a by-default toplevel <see cref="Godot.Control"/> that draws a window decoration and allows motion and resizing.</para>
    /// </summary>
    public partial class WindowDialog : Popup
    {
        /// <summary>
        /// <para>The text displayed in the window's title bar.</para>
        /// </summary>
        public string WindowTitle
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTitle();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTitle(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the user can resize the window.</para>
        /// </summary>
        public bool Resizable
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetResizable();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetResizable(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "WindowDialog";

        public WindowDialog() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_WindowDialog_Ctor(this);
        }

        internal WindowDialog(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_title");

        [GodotMethod("set_title")]
        [Obsolete("SetTitle is deprecated. Use the WindowTitle property instead.")]
        public void SetTitle(string title)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), title);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_title");

        [GodotMethod("get_title")]
        [Obsolete("GetTitle is deprecated. Use the WindowTitle property instead.")]
        public string GetTitle()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_resizable");

        [GodotMethod("set_resizable")]
        [Obsolete("SetResizable is deprecated. Use the Resizable property instead.")]
        public void SetResizable(bool resizable)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), resizable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_resizable");

        [GodotMethod("get_resizable")]
        [Obsolete("GetResizable is deprecated. Use the Resizable property instead.")]
        public bool GetResizable()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_close_button");

        /// <summary>
        /// <para>Returns the close <see cref="Godot.TextureButton"/>.</para>
        /// <para>Warning: This is a required internal node, removing and freeing it may cause a crash. If you wish to hide it or any of its children, use their <see cref="Godot.CanvasItem.Visible"/> property.</para>
        /// </summary>
        [GodotMethod("get_close_button")]
        public TextureButton GetCloseButton()
        {
            return NativeCalls.godot_icall_0_1165(method_bind_4, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
