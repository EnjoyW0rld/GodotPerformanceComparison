using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This control allows property editing for one or multiple properties into <see cref="Godot.EditorInspector"/>. It is added via <see cref="Godot.EditorInspectorPlugin"/>.</para>
    /// </summary>
    public partial class EditorProperty : Container
    {
        /// <summary>
        /// <para>Set this property to change the label (if you want to show one).</para>
        /// </summary>
        public string Label
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLabel();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLabel(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Used by the inspector, set to <c>true</c> when the property is read-only.</para>
        /// </summary>
        public bool ReadOnly
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsReadOnly();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetReadOnly(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Used by the inspector, set to <c>true</c> when the property is checkable.</para>
        /// </summary>
        public bool Checkable
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsCheckable();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCheckable(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Used by the inspector, set to <c>true</c> when the property is checked.</para>
        /// </summary>
        public bool Checked
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsChecked();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetChecked(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Used by the inspector, set to <c>true</c> when the property is drawn with the editor theme's warning color. This is used for editable children's properties.</para>
        /// </summary>
        public bool DrawRed
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDrawRed();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDrawRed(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Used by the inspector, set to <c>true</c> when the property can add keys for animation.</para>
        /// </summary>
        public bool Keying
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsKeying();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetKeying(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "EditorProperty";

        public EditorProperty() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_EditorProperty_Ctor(this);
        }

        internal EditorProperty(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>When this virtual function is called, you must update your editor.</para>
        /// </summary>
        [GodotMethod("update_property")]
        public virtual void UpdateProperty()
        {
            return;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_label");

        [GodotMethod("set_label")]
        [Obsolete("SetLabel is deprecated. Use the Label property instead.")]
        public void SetLabel(string text)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), text);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_label");

        [GodotMethod("get_label")]
        [Obsolete("GetLabel is deprecated. Use the Label property instead.")]
        public string GetLabel()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_read_only");

        [GodotMethod("set_read_only")]
        [Obsolete("SetReadOnly is deprecated. Use the ReadOnly property instead.")]
        public void SetReadOnly(bool readOnly)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), readOnly);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_read_only");

        [GodotMethod("is_read_only")]
        [Obsolete("IsReadOnly is deprecated. Use the ReadOnly property instead.")]
        public bool IsReadOnly()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_checkable");

        [GodotMethod("set_checkable")]
        [Obsolete("SetCheckable is deprecated. Use the Checkable property instead.")]
        public void SetCheckable(bool checkable)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), checkable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_checkable");

        [GodotMethod("is_checkable")]
        [Obsolete("IsCheckable is deprecated. Use the Checkable property instead.")]
        public bool IsCheckable()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_checked");

        [GodotMethod("set_checked")]
        [Obsolete("SetChecked is deprecated. Use the Checked property instead.")]
        public void SetChecked(bool @checked)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), @checked);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_checked");

        [GodotMethod("is_checked")]
        [Obsolete("IsChecked is deprecated. Use the Checked property instead.")]
        public bool IsChecked()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_draw_red");

        [GodotMethod("set_draw_red")]
        [Obsolete("SetDrawRed is deprecated. Use the DrawRed property instead.")]
        public void SetDrawRed(bool drawRed)
        {
            NativeCalls.godot_icall_1_16(method_bind_8, Object.GetPtr(this), drawRed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_draw_red");

        [GodotMethod("is_draw_red")]
        [Obsolete("IsDrawRed is deprecated. Use the DrawRed property instead.")]
        public bool IsDrawRed()
        {
            return NativeCalls.godot_icall_0_7(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_keying");

        [GodotMethod("set_keying")]
        [Obsolete("SetKeying is deprecated. Use the Keying property instead.")]
        public void SetKeying(bool keying)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), keying);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_keying");

        [GodotMethod("is_keying")]
        [Obsolete("IsKeying is deprecated. Use the Keying property instead.")]
        public bool IsKeying()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_edited_property");

        /// <summary>
        /// <para>Gets the edited property. If your editor is for a single property (added via <see cref="Godot.EditorInspectorPlugin.ParseProperty"/>), then this will return the property.</para>
        /// </summary>
        [GodotMethod("get_edited_property")]
        public string GetEditedProperty()
        {
            return NativeCalls.godot_icall_0_6(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_edited_object");

        /// <summary>
        /// <para>Gets the edited object.</para>
        /// </summary>
        [GodotMethod("get_edited_object")]
        public Object GetEditedObject()
        {
            return NativeCalls.godot_icall_0_397(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tooltip_text");

        /// <summary>
        /// <para>Must be implemented to provide a custom tooltip to the property editor.</para>
        /// </summary>
        [GodotMethod("get_tooltip_text")]
        public string GetTooltipText()
        {
            return NativeCalls.godot_icall_0_6(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_focusable");

        /// <summary>
        /// <para>If any of the controls added can gain keyboard focus, add it here. This ensures that focus will be restored if the inspector is refreshed.</para>
        /// </summary>
        [GodotMethod("add_focusable")]
        public void AddFocusable(Control control)
        {
            NativeCalls.godot_icall_1_53(method_bind_15, Object.GetPtr(this), Object.GetPtr(control));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bottom_editor");

        /// <summary>
        /// <para>Puts the <c>editor</c> control below the property label. The control must be previously added using <see cref="Godot.Node.AddChild"/>.</para>
        /// </summary>
        [GodotMethod("set_bottom_editor")]
        public void SetBottomEditor(Control editor)
        {
            NativeCalls.godot_icall_1_53(method_bind_16, Object.GetPtr(this), Object.GetPtr(editor));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "emit_changed");

        /// <summary>
        /// <para>If one or several properties have changed, this must be called. <c>field</c> is used in case your editor can modify fields separately (as an example, Vector3.x). The <c>changing</c> argument avoids the editor requesting this property to be refreshed (leave as <c>false</c> if unsure).</para>
        /// </summary>
        [GodotMethod("emit_changed")]
        public void EmitChanged(string property, object value, string field = "", bool changing = false)
        {
            EditorNativeCalls.godot_icall_4_398(method_bind_17, Object.GetPtr(this), property, value, field, changing);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
