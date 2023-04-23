using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.EditorInspectorPlugin"/> allows adding custom property editors to <see cref="Godot.EditorInspector"/>.</para>
    /// <para>When an object is edited, the <see cref="Godot.EditorInspectorPlugin.CanHandle"/> function is called and must return <c>true</c> if the object type is supported.</para>
    /// <para>If supported, the function <see cref="Godot.EditorInspectorPlugin.ParseBegin"/> will be called, allowing to place custom controls at the beginning of the class.</para>
    /// <para>Subsequently, the <see cref="Godot.EditorInspectorPlugin.ParseCategory"/> and <see cref="Godot.EditorInspectorPlugin.ParseProperty"/> are called for every category and property. They offer the ability to add custom controls to the inspector too.</para>
    /// <para>Finally, <see cref="Godot.EditorInspectorPlugin.ParseEnd"/> will be called.</para>
    /// <para>On each of these calls, the "add" functions can be called.</para>
    /// <para>To use <see cref="Godot.EditorInspectorPlugin"/>, register it using the <see cref="Godot.EditorPlugin.AddInspectorPlugin"/> method first.</para>
    /// </summary>
    public partial class EditorInspectorPlugin : Reference
    {
        private const string nativeName = "EditorInspectorPlugin";

        public EditorInspectorPlugin() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_EditorInspectorPlugin_Ctor(this);
        }

        internal EditorInspectorPlugin(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>Returns <c>true</c> if this object can be handled by this plugin.</para>
        /// </summary>
        [GodotMethod("can_handle")]
        public virtual bool CanHandle(Object @object)
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Called to allow adding controls at the beginning of the list.</para>
        /// </summary>
        [GodotMethod("parse_begin")]
        public virtual void ParseBegin(Object @object)
        {
            return;
        }

        /// <summary>
        /// <para>Called to allow adding controls at the beginning of the category.</para>
        /// </summary>
        [GodotMethod("parse_category")]
        public virtual void ParseCategory(Object @object, string category)
        {
            return;
        }

        /// <summary>
        /// <para>Called to allow adding controls at the end of the list.</para>
        /// </summary>
        [GodotMethod("parse_end")]
        public virtual void ParseEnd()
        {
            return;
        }

        /// <summary>
        /// <para>Called to allow adding property specific editors to the inspector. Usually these inherit <see cref="Godot.EditorProperty"/>. Returning <c>true</c> removes the built-in editor for this property, otherwise allows to insert a custom editor before the built-in one.</para>
        /// </summary>
        [GodotMethod("parse_property")]
        public virtual bool ParseProperty(Object @object, int type, string path, int hint, string hintText, int usage)
        {
            return default(bool);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_custom_control");

        /// <summary>
        /// <para>Adds a custom control, which is not necessarily a property editor.</para>
        /// </summary>
        [GodotMethod("add_custom_control")]
        public void AddCustomControl(Control control)
        {
            NativeCalls.godot_icall_1_53(method_bind_0, Object.GetPtr(this), Object.GetPtr(control));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_property_editor");

        /// <summary>
        /// <para>Adds a property editor for an individual property. The <c>editor</c> control must extend <see cref="Godot.EditorProperty"/>.</para>
        /// </summary>
        [GodotMethod("add_property_editor")]
        public void AddPropertyEditor(string property, Control editor)
        {
            NativeCalls.godot_icall_2_377(method_bind_1, Object.GetPtr(this), property, Object.GetPtr(editor));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_property_editor_for_multiple_properties");

        /// <summary>
        /// <para>Adds an editor that allows modifying multiple properties. The <c>editor</c> control must extend <see cref="Godot.EditorProperty"/>.</para>
        /// </summary>
        [GodotMethod("add_property_editor_for_multiple_properties")]
        public void AddPropertyEditorForMultipleProperties(string label, string[] properties, Control editor)
        {
            EditorNativeCalls.godot_icall_3_378(method_bind_2, Object.GetPtr(this), label, properties, Object.GetPtr(editor));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
