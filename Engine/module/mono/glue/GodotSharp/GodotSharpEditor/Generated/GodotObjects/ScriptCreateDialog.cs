using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The <see cref="Godot.ScriptCreateDialog"/> creates script files according to a given template for a given scripting language. The standard use is to configure its fields prior to calling one of the <see cref="Godot.Popup.Popup_"/> methods.</para>
    /// <para><code>
    /// func _ready():
    ///     dialog.config("Node", "res://new_node.gd") # For in-engine types
    ///     dialog.config("\"res://base_node.gd\"", "res://derived_node.gd") # For script types
    ///     dialog.popup_centered()
    /// </code></para>
    /// </summary>
    public partial class ScriptCreateDialog : ConfirmationDialog
    {
        private const string nativeName = "ScriptCreateDialog";

        public ScriptCreateDialog() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_ScriptCreateDialog_Ctor(this);
        }

        internal ScriptCreateDialog(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "config");

        /// <summary>
        /// <para>Prefills required fields to configure the ScriptCreateDialog for use.</para>
        /// </summary>
        [GodotMethod("config")]
        public void Config(string inherits, string path, bool builtInEnabled = true, bool loadEnabled = true)
        {
            EditorNativeCalls.godot_icall_4_849(method_bind_0, Object.GetPtr(this), inherits, path, builtInEnabled, loadEnabled);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
