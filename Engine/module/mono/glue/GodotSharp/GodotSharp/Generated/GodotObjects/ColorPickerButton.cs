using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Encapsulates a <see cref="Godot.ColorPicker"/> making it accessible by pressing a button. Pressing the button will toggle the <see cref="Godot.ColorPicker"/> visibility.</para>
    /// <para>See also <see cref="Godot.BaseButton"/> which contains common properties and methods associated with this node.</para>
    /// <para>Note: By default, the button may not be wide enough for the color preview swatch to be visible. Make sure to set <see cref="Godot.Control.RectMinSize"/> to a big enough value to give the button enough space.</para>
    /// </summary>
    public partial class ColorPickerButton : Button
    {
        /// <summary>
        /// <para>The currently selected color.</para>
        /// </summary>
        public Color Color
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPickColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPickColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the alpha channel in the displayed <see cref="Godot.ColorPicker"/> will be visible.</para>
        /// </summary>
        public bool EditAlpha
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsEditingAlpha();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEditAlpha(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ColorPickerButton";

        public ColorPickerButton() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ColorPickerButton_Ctor(this);
        }

        internal ColorPickerButton(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pick_color");

        [GodotMethod("set_pick_color")]
        [Obsolete("SetPickColor is deprecated. Use the Color property instead.")]
        public void SetPickColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_0, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pick_color");

        [GodotMethod("get_pick_color")]
        [Obsolete("GetPickColor is deprecated. Use the Color property instead.")]
        public Color GetPickColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_1, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_picker");

        /// <summary>
        /// <para>Returns the <see cref="Godot.ColorPicker"/> that this node toggles.</para>
        /// <para>Warning: This is a required internal node, removing and freeing it may cause a crash. If you wish to hide it or any of its children, use their <see cref="Godot.CanvasItem.Visible"/> property.</para>
        /// </summary>
        [GodotMethod("get_picker")]
        public ColorPicker GetPicker()
        {
            return NativeCalls.godot_icall_0_305(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_popup");

        /// <summary>
        /// <para>Returns the control's <see cref="Godot.PopupPanel"/> which allows you to connect to popup signals. This allows you to handle events when the ColorPicker is shown or hidden.</para>
        /// <para>Warning: This is a required internal node, removing and freeing it may cause a crash. If you wish to hide it or any of its children, use their <see cref="Godot.CanvasItem.Visible"/> property.</para>
        /// </summary>
        [GodotMethod("get_popup")]
        public PopupPanel GetPopup()
        {
            return NativeCalls.godot_icall_0_306(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_edit_alpha");

        [GodotMethod("set_edit_alpha")]
        [Obsolete("SetEditAlpha is deprecated. Use the EditAlpha property instead.")]
        public void SetEditAlpha(bool show)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), show);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_editing_alpha");

        [GodotMethod("is_editing_alpha")]
        [Obsolete("IsEditingAlpha is deprecated. Use the EditAlpha property instead.")]
        public bool IsEditingAlpha()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
