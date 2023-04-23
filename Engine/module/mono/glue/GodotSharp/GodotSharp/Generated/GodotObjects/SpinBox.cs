using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>SpinBox is a numerical input text field. It allows entering integers and floats.</para>
    /// <para>Example:</para>
    /// <para><code>
    /// var spin_box = SpinBox.new()
    /// add_child(spin_box)
    /// var line_edit = spin_box.get_line_edit()
    /// line_edit.context_menu_enabled = false
    /// spin_box.align = LineEdit.ALIGN_RIGHT
    /// </code></para>
    /// <para>The above code will create a <see cref="Godot.SpinBox"/>, disable context menu on it and set the text alignment to right.</para>
    /// <para>See <see cref="Godot.Range"/> class for more options over the <see cref="Godot.SpinBox"/>.</para>
    /// <para>Note: <see cref="Godot.SpinBox"/> relies on an underlying <see cref="Godot.LineEdit"/> node. To theme a <see cref="Godot.SpinBox"/>'s background, add theme items for <see cref="Godot.LineEdit"/> and customize them.</para>
    /// <para>Note: If you want to implement drag and drop for the underlying <see cref="Godot.LineEdit"/>, you can use <see cref="Godot.Control.SetDragForwarding"/> on the node returned by <see cref="Godot.SpinBox.GetLineEdit"/>.</para>
    /// </summary>
    public partial class SpinBox : Range
    {
        /// <summary>
        /// <para>Sets the text alignment of the <see cref="Godot.SpinBox"/>.</para>
        /// </summary>
        public LineEdit.AlignEnum Align
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAlign();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAlign(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the <see cref="Godot.SpinBox"/> will be editable. Otherwise, it will be read only.</para>
        /// </summary>
        public bool Editable
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsEditable();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEditable(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Adds the specified <c>prefix</c> string before the numerical value of the <see cref="Godot.SpinBox"/>.</para>
        /// </summary>
        public string Prefix
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPrefix();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPrefix(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Adds the specified <c>suffix</c> string after the numerical value of the <see cref="Godot.SpinBox"/>.</para>
        /// </summary>
        public string Suffix
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSuffix();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSuffix(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "SpinBox";

        public SpinBox() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_SpinBox_Ctor(this);
        }

        internal SpinBox(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_align");

        [GodotMethod("set_align")]
        [Obsolete("SetAlign is deprecated. Use the Align property instead.")]
        public void SetAlign(LineEdit.AlignEnum align)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)align);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_align");

        [GodotMethod("get_align")]
        [Obsolete("GetAlign is deprecated. Use the Align property instead.")]
        public LineEdit.AlignEnum GetAlign()
        {
            return (LineEdit.AlignEnum)NativeCalls.godot_icall_0_590(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_suffix");

        [GodotMethod("set_suffix")]
        [Obsolete("SetSuffix is deprecated. Use the Suffix property instead.")]
        public void SetSuffix(string suffix)
        {
            NativeCalls.godot_icall_1_54(method_bind_2, Object.GetPtr(this), suffix);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_suffix");

        [GodotMethod("get_suffix")]
        [Obsolete("GetSuffix is deprecated. Use the Suffix property instead.")]
        public string GetSuffix()
        {
            return NativeCalls.godot_icall_0_6(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_prefix");

        [GodotMethod("set_prefix")]
        [Obsolete("SetPrefix is deprecated. Use the Prefix property instead.")]
        public void SetPrefix(string prefix)
        {
            NativeCalls.godot_icall_1_54(method_bind_4, Object.GetPtr(this), prefix);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_prefix");

        [GodotMethod("get_prefix")]
        [Obsolete("GetPrefix is deprecated. Use the Prefix property instead.")]
        public string GetPrefix()
        {
            return NativeCalls.godot_icall_0_6(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_editable");

        [GodotMethod("set_editable")]
        [Obsolete("SetEditable is deprecated. Use the Editable property instead.")]
        public void SetEditable(bool editable)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), editable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_editable");

        [GodotMethod("is_editable")]
        [Obsolete("IsEditable is deprecated. Use the Editable property instead.")]
        public bool IsEditable()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "apply");

        /// <summary>
        /// <para>Applies the current value of this <see cref="Godot.SpinBox"/>.</para>
        /// </summary>
        [GodotMethod("apply")]
        public void Apply()
        {
            NativeCalls.godot_icall_0_3(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_line_edit");

        /// <summary>
        /// <para>Returns the <see cref="Godot.LineEdit"/> instance from this <see cref="Godot.SpinBox"/>. You can use it to access properties and methods of <see cref="Godot.LineEdit"/>.</para>
        /// <para>Warning: This is a required internal node, removing and freeing it may cause a crash. If you wish to hide it or any of its children, use their <see cref="Godot.CanvasItem.Visible"/> property.</para>
        /// </summary>
        [GodotMethod("get_line_edit")]
        public LineEdit GetLineEdit()
        {
            return NativeCalls.godot_icall_0_434(method_bind_9, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
