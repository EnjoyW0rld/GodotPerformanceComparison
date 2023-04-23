using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Button is the standard themed button. It can contain text and an icon, and will display them according to the current <see cref="Godot.Theme"/>.</para>
    /// <para>Example of creating a button and assigning an action when pressed by code:</para>
    /// <para><code>
    /// func _ready():
    ///     var button = Button.new()
    ///     button.text = "Click me"
    ///     button.connect("pressed", self, "_button_pressed")
    ///     add_child(button)
    /// 
    /// func _button_pressed():
    ///     print("Hello world!")
    /// </code></para>
    /// <para>Buttons (like all Control nodes) can also be created in the editor, but some situations may require creating them from code.</para>
    /// <para>See also <see cref="Godot.BaseButton"/> which contains common properties and methods associated with this node.</para>
    /// <para>Note: Buttons do not interpret touch input and therefore don't support multitouch, since mouse emulation can only press one button at a given time. Use <see cref="Godot.TouchScreenButton"/> for buttons that trigger gameplay movement or actions, as <see cref="Godot.TouchScreenButton"/> supports multitouch.</para>
    /// </summary>
    public partial class Button : BaseButton
    {
        public enum TextAlign
        {
            /// <summary>
            /// <para>Align the text to the left.</para>
            /// </summary>
            Left = 0,
            /// <summary>
            /// <para>Align the text to the center.</para>
            /// </summary>
            Center = 1,
            /// <summary>
            /// <para>Align the text to the right.</para>
            /// </summary>
            Right = 2
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
        /// <para>Button's icon, if text is present the icon will be placed before the text.</para>
        /// <para>To edit margin and spacing of the icon, use <c>hseparation</c> theme property of <see cref="Godot.Button"/> and <c>content_margin_*</c> properties of the used <see cref="Godot.StyleBox"/>es.</para>
        /// </summary>
        public Texture Icon
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetButtonIcon();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetButtonIcon(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Flat buttons don't display decoration.</para>
        /// </summary>
        public bool Flat
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsFlat();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlat(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When this property is enabled, text that is too large to fit the button is clipped, when disabled the Button will always be wide enough to hold the text.</para>
        /// </summary>
        public bool ClipText
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetClipText();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetClipText(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Text alignment policy for the button's text, use one of the <see cref="Godot.Button.TextAlign"/> constants.</para>
        /// </summary>
        public Button.TextAlign Align
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTextAlign();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTextAlign(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Specifies if the icon should be aligned to the left, right, or center of a button. Uses the same <see cref="Godot.Button.TextAlign"/> constants as the text alignment. If centered, text will draw on top of the icon.</para>
        /// </summary>
        public Button.TextAlign IconAlign
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetIconAlign();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetIconAlign(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When enabled, the button's icon will expand/shrink to fit the button's size while keeping its aspect.</para>
        /// </summary>
        public bool ExpandIcon
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsExpandIcon();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExpandIcon(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Button";

        public Button() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Button_Ctor(this);
        }

        internal Button(bool memoryOwn) : base(memoryOwn) {}

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
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_button_icon");

        [GodotMethod("set_button_icon")]
        [Obsolete("SetButtonIcon is deprecated. Use the Icon property instead.")]
        public void SetButtonIcon(Texture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_2, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_button_icon");

        [GodotMethod("get_button_icon")]
        [Obsolete("GetButtonIcon is deprecated. Use the Icon property instead.")]
        public Texture GetButtonIcon()
        {
            return NativeCalls.godot_icall_0_161(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flat");

        [GodotMethod("set_flat")]
        [Obsolete("SetFlat is deprecated. Use the Flat property instead.")]
        public void SetFlat(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_flat");

        [GodotMethod("is_flat")]
        [Obsolete("IsFlat is deprecated. Use the Flat property instead.")]
        public bool IsFlat()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_clip_text");

        [GodotMethod("set_clip_text")]
        [Obsolete("SetClipText is deprecated. Use the ClipText property instead.")]
        public void SetClipText(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_clip_text");

        [GodotMethod("get_clip_text")]
        [Obsolete("GetClipText is deprecated. Use the ClipText property instead.")]
        public bool GetClipText()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_text_align");

        [GodotMethod("set_text_align")]
        [Obsolete("SetTextAlign is deprecated. Use the Align property instead.")]
        public void SetTextAlign(Button.TextAlign align)
        {
            NativeCalls.godot_icall_1_4(method_bind_8, Object.GetPtr(this), (int)align);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_text_align");

        [GodotMethod("get_text_align")]
        [Obsolete("GetTextAlign is deprecated. Use the Align property instead.")]
        public Button.TextAlign GetTextAlign()
        {
            return (Button.TextAlign)NativeCalls.godot_icall_0_223(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_icon_align");

        [GodotMethod("set_icon_align")]
        [Obsolete("SetIconAlign is deprecated. Use the IconAlign property instead.")]
        public void SetIconAlign(Button.TextAlign iconAlign)
        {
            NativeCalls.godot_icall_1_4(method_bind_10, Object.GetPtr(this), (int)iconAlign);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_icon_align");

        [GodotMethod("get_icon_align")]
        [Obsolete("GetIconAlign is deprecated. Use the IconAlign property instead.")]
        public Button.TextAlign GetIconAlign()
        {
            return (Button.TextAlign)NativeCalls.godot_icall_0_223(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_expand_icon");

        [GodotMethod("set_expand_icon")]
        [Obsolete("SetExpandIcon is deprecated. Use the ExpandIcon property instead.")]
        public void SetExpandIcon(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_12, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_expand_icon");

        [GodotMethod("is_expand_icon")]
        [Obsolete("IsExpandIcon is deprecated. Use the ExpandIcon property instead.")]
        public bool IsExpandIcon()
        {
            return NativeCalls.godot_icall_0_7(method_bind_13, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
