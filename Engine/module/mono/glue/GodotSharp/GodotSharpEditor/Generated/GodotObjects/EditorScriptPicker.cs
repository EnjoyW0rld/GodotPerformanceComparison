using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Similar to <see cref="Godot.EditorResourcePicker"/> this <see cref="Godot.Control"/> node is used in the editor's Inspector dock, but only to edit the <c>script</c> property of a <see cref="Godot.Node"/>. Default options for creating new resources of all possible subtypes are replaced with dedicated buttons that open the "Attach Node Script" dialog. Can be used with <see cref="Godot.EditorInspectorPlugin"/> to recreate the same behavior.</para>
    /// <para>Note: You must set the <see cref="Godot.EditorScriptPicker.ScriptOwner"/> for the custom context menu items to work.</para>
    /// </summary>
    public partial class EditorScriptPicker : EditorResourcePicker
    {
        /// <summary>
        /// <para>The owner <see cref="Godot.Node"/> of the script property that holds the edited resource.</para>
        /// </summary>
        public Node ScriptOwner
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetScriptOwner();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetScriptOwner(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "EditorScriptPicker";

        public EditorScriptPicker() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_EditorScriptPicker_Ctor(this);
        }

        internal EditorScriptPicker(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_script_owner");

        [GodotMethod("set_script_owner")]
        [Obsolete("SetScriptOwner is deprecated. Use the ScriptOwner property instead.")]
        public void SetScriptOwner(Node ownerNode)
        {
            NativeCalls.godot_icall_1_53(method_bind_0, Object.GetPtr(this), Object.GetPtr(ownerNode));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_script_owner");

        [GodotMethod("get_script_owner")]
        [Obsolete("GetScriptOwner is deprecated. Use the ScriptOwner property instead.")]
        public Node GetScriptOwner()
        {
            return NativeCalls.godot_icall_0_257(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
