using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This <see cref="Godot.Control"/> node is used in the editor's Inspector dock to allow editing of <see cref="Godot.Resource"/> type properties. It provides options for creating, loading, saving and converting resources. Can be used with <see cref="Godot.EditorInspectorPlugin"/> to recreate the same behavior.</para>
    /// <para>Note: This <see cref="Godot.Control"/> does not include any editor for the resource, as editing is controlled by the Inspector dock itself or sub-Inspectors.</para>
    /// </summary>
    public partial class EditorResourcePicker : HBoxContainer
    {
        /// <summary>
        /// <para>The base type of allowed resource types. Can be a comma-separated list of several options.</para>
        /// </summary>
        public string BaseType
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBaseType();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBaseType(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The edited resource value.</para>
        /// </summary>
        public Resource EditedResource
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEditedResource();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEditedResource(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the value can be selected and edited.</para>
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
        /// <para>If <c>true</c>, the main button with the resource preview works in the toggle mode. Use <see cref="Godot.EditorResourcePicker.SetTogglePressed"/> to manually set the state.</para>
        /// </summary>
        public bool ToggleMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsToggleMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetToggleMode(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "EditorResourcePicker";

        public EditorResourcePicker() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_EditorResourcePicker_Ctor(this);
        }

        internal EditorResourcePicker(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>This virtual method can be implemented to handle context menu items not handled by default. See <see cref="Godot.EditorResourcePicker.SetCreateOptions"/>.</para>
        /// </summary>
        [GodotMethod("handle_menu_selected")]
        public virtual bool HandleMenuSelected(int id)
        {
            return default(bool);
        }

        /// <summary>
        /// <para>This virtual method is called when updating the context menu of <see cref="Godot.EditorResourcePicker"/>. Implement this method to override the "New ..." items with your own options. <c>menu_node</c> is a reference to the <see cref="Godot.PopupMenu"/> node.</para>
        /// <para>Note: Implement <see cref="Godot.EditorResourcePicker.HandleMenuSelected"/> to handle these custom items.</para>
        /// </summary>
        [GodotMethod("set_create_options")]
        public virtual void SetCreateOptions(Object menuNode)
        {
            return;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_drag_data_fw");

        [GodotMethod("get_drag_data_fw")]
        public object GetDragDataFw(Vector2 position, Control from)
        {
            return EditorNativeCalls.godot_icall_2_399(method_bind_0, Object.GetPtr(this), ref position, Object.GetPtr(from));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "can_drop_data_fw");

        [GodotMethod("can_drop_data_fw")]
        public bool CanDropDataFw(Vector2 position, object data, Control from)
        {
            return EditorNativeCalls.godot_icall_3_400(method_bind_1, Object.GetPtr(this), ref position, data, Object.GetPtr(from));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "drop_data_fw");

        [GodotMethod("drop_data_fw")]
        public void DropDataFw(Vector2 position, object data, Control from)
        {
            EditorNativeCalls.godot_icall_3_401(method_bind_2, Object.GetPtr(this), ref position, data, Object.GetPtr(from));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_base_type");

        [GodotMethod("set_base_type")]
        [Obsolete("SetBaseType is deprecated. Use the BaseType property instead.")]
        public void SetBaseType(string baseType)
        {
            NativeCalls.godot_icall_1_54(method_bind_3, Object.GetPtr(this), baseType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_base_type");

        [GodotMethod("get_base_type")]
        [Obsolete("GetBaseType is deprecated. Use the BaseType property instead.")]
        public string GetBaseType()
        {
            return NativeCalls.godot_icall_0_6(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_allowed_types");

        /// <summary>
        /// <para>Returns a list of all allowed types and subtypes corresponding to the <see cref="Godot.EditorResourcePicker.BaseType"/>. If the <see cref="Godot.EditorResourcePicker.BaseType"/> is empty, an empty list is returned.</para>
        /// </summary>
        [GodotMethod("get_allowed_types")]
        public string[] GetAllowedTypes()
        {
            return NativeCalls.godot_icall_0_119(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_edited_resource");

        [GodotMethod("set_edited_resource")]
        [Obsolete("SetEditedResource is deprecated. Use the EditedResource property instead.")]
        public void SetEditedResource(Resource resource)
        {
            NativeCalls.godot_icall_1_24(method_bind_6, Object.GetPtr(this), Object.GetPtr(resource));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_edited_resource");

        [GodotMethod("get_edited_resource")]
        [Obsolete("GetEditedResource is deprecated. Use the EditedResource property instead.")]
        public Resource GetEditedResource()
        {
            return NativeCalls.godot_icall_0_402(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_toggle_mode");

        [GodotMethod("set_toggle_mode")]
        [Obsolete("SetToggleMode is deprecated. Use the ToggleMode property instead.")]
        public void SetToggleMode(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_8, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_toggle_mode");

        [GodotMethod("is_toggle_mode")]
        [Obsolete("IsToggleMode is deprecated. Use the ToggleMode property instead.")]
        public bool IsToggleMode()
        {
            return NativeCalls.godot_icall_0_7(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_toggle_pressed");

        /// <summary>
        /// <para>Sets the toggle mode state for the main button. Works only if <see cref="Godot.EditorResourcePicker.ToggleMode"/> is set to <c>true</c>.</para>
        /// </summary>
        [GodotMethod("set_toggle_pressed")]
        public void SetTogglePressed(bool pressed)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), pressed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_editable");

        [GodotMethod("set_editable")]
        [Obsolete("SetEditable is deprecated. Use the Editable property instead.")]
        public void SetEditable(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_11, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_editable");

        [GodotMethod("is_editable")]
        [Obsolete("IsEditable is deprecated. Use the Editable property instead.")]
        public bool IsEditable()
        {
            return NativeCalls.godot_icall_0_7(method_bind_12, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
