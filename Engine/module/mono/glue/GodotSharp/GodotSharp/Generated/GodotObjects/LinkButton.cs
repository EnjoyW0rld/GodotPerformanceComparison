using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This kind of button is primarily used when the interaction with the button causes a context change (like linking to a web page).</para>
    /// <para>See also <see cref="Godot.BaseButton"/> which contains common properties and methods associated with this node.</para>
    /// </summary>
    public partial class LinkButton : BaseButton
    {
        public enum UnderlineMode
        {
            /// <summary>
            /// <para>The LinkButton will always show an underline at the bottom of its text.</para>
            /// </summary>
            Always = 0,
            /// <summary>
            /// <para>The LinkButton will show an underline at the bottom of its text when the mouse cursor is over it.</para>
            /// </summary>
            OnHover = 1,
            /// <summary>
            /// <para>The LinkButton will never show an underline at the bottom of its text.</para>
            /// </summary>
            Never = 2
        }

        /// <summary>
        /// <para>The button's text that will be displayed inside the button's area.</para>
        /// </summary>
        public string Text
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
        /// <para>Determines when to show the underline. See <see cref="Godot.LinkButton.UnderlineMode"/> for options.</para>
        /// </summary>
        public LinkButton.UnderlineMode Underline
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUnderlineMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUnderlineMode(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "LinkButton";

        public LinkButton() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_LinkButton_Ctor(this);
        }

        internal LinkButton(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_text");

        [GodotMethod("set_text")]
        [Obsolete("SetText is deprecated. Use the Text property instead.")]
        public void SetText(string text)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), text);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_text");

        [GodotMethod("get_text")]
        [Obsolete("GetText is deprecated. Use the Text property instead.")]
        public string GetText()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_underline_mode");

        [GodotMethod("set_underline_mode")]
        [Obsolete("SetUnderlineMode is deprecated. Use the Underline property instead.")]
        public void SetUnderlineMode(LinkButton.UnderlineMode underlineMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)underlineMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_underline_mode");

        [GodotMethod("get_underline_mode")]
        [Obsolete("GetUnderlineMode is deprecated. Use the Underline property instead.")]
        public LinkButton.UnderlineMode GetUnderlineMode()
        {
            return (LinkButton.UnderlineMode)NativeCalls.godot_icall_0_592(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
