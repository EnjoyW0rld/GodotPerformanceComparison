using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Special button that brings up a <see cref="Godot.PopupMenu"/> when clicked.</para>
    /// <para>New items can be created inside this <see cref="Godot.PopupMenu"/> using <c>get_popup().add_item("My Item Name")</c>. You can also create them directly from the editor. To do so, select the <see cref="Godot.MenuButton"/> node, then in the toolbar at the top of the 2D editor, click Items then click Add in the popup. You will be able to give each item new properties.</para>
    /// <para>See also <see cref="Godot.BaseButton"/> which contains common properties and methods associated with this node.</para>
    /// </summary>
    public partial class MenuButton : Button
    {
        public Godot.Collections.Array Items
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetItems();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetItems(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, when the cursor hovers above another <see cref="Godot.MenuButton"/> within the same parent which also has <c>switch_on_hover</c> enabled, it will close the current <see cref="Godot.MenuButton"/> and open the other one.</para>
        /// </summary>
        public bool SwitchOnHover
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsSwitchOnHover();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSwitchOnHover(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "MenuButton";

        public MenuButton() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_MenuButton_Ctor(this);
        }

        internal MenuButton(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_popup");

        /// <summary>
        /// <para>Returns the <see cref="Godot.PopupMenu"/> contained in this button.</para>
        /// <para>Warning: This is a required internal node, removing and freeing it may cause a crash. If you wish to hide it or any of its children, use their <see cref="Godot.CanvasItem.Visible"/> property.</para>
        /// </summary>
        [GodotMethod("get_popup")]
        public PopupMenu GetPopup()
        {
            return NativeCalls.godot_icall_0_591(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_items");

        [Obsolete("_SetItems is deprecated. Use the Items property instead.")]
        internal void _SetItems(Godot.Collections.Array arg0)
        {
            NativeCalls.godot_icall_1_92(method_bind_1, Object.GetPtr(this), arg0.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_items");

        [Obsolete("_GetItems is deprecated. Use the Items property instead.")]
        internal Godot.Collections.Array _GetItems()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_2, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_switch_on_hover");

        [GodotMethod("set_switch_on_hover")]
        [Obsolete("SetSwitchOnHover is deprecated. Use the SwitchOnHover property instead.")]
        public void SetSwitchOnHover(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_3, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_switch_on_hover");

        [GodotMethod("is_switch_on_hover")]
        [Obsolete("IsSwitchOnHover is deprecated. Use the SwitchOnHover property instead.")]
        public bool IsSwitchOnHover()
        {
            return NativeCalls.godot_icall_0_7(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_disable_shortcuts");

        /// <summary>
        /// <para>If <c>true</c>, shortcuts are disabled and cannot be used to trigger the button.</para>
        /// </summary>
        [GodotMethod("set_disable_shortcuts")]
        public void SetDisableShortcuts(bool disabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_5, Object.GetPtr(this), disabled);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
