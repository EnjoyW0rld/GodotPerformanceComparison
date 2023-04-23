using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This is the control that implements property editing in the editor's Settings dialogs, the Inspector dock, etc. To get the <see cref="Godot.EditorInspector"/> used in the editor's Inspector dock, use <see cref="Godot.EditorInterface.GetInspector"/>.</para>
    /// <para><see cref="Godot.EditorInspector"/> will show properties in the same order as the array returned by <see cref="Godot.Object.GetPropertyList"/>.</para>
    /// <para>If a property's name is path-like (i.e. if it contains forward slashes), <see cref="Godot.EditorInspector"/> will create nested sections for "directories" along the path. For example, if a property is named <c>highlighting/gdscript/node_path_color</c>, it will be shown as "Node Path Color" inside the "GDScript" section nested inside the "Highlighting" section.</para>
    /// <para>If a property has <c>@GlobalScope.PROPERTY_USAGE_GROUP</c> usage, it will group subsequent properties whose name starts with the property's hint string. The group ends when a property does not start with that hint string or when a new group starts. An empty group name effectively ends the current group. <see cref="Godot.EditorInspector"/> will create a top-level section for each group. For example, if a property with group usage is named <c>Collide With</c> and its hint string is <c>collide_with_</c>, a subsequent <c>collide_with_area</c> property will be shown as "Area" inside the "Collide With" section.</para>
    /// <para>Note: Unlike sections created from path-like property names, <see cref="Godot.EditorInspector"/> won't capitalize the name for sections created from groups. So properties with group usage usually use capitalized names instead of snake_cased names.</para>
    /// </summary>
    public partial class EditorInspector : ScrollContainer
    {
        private const string nativeName = "EditorInspector";

        public EditorInspector() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_EditorInspector_Ctor(this);
        }

        internal EditorInspector(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "refresh");

        /// <summary>
        /// <para>Refreshes the inspector.</para>
        /// <para>Note: To save on CPU resources, calling this method will do nothing if the time specified in <c>docks/property_editor/auto_refresh_interval</c> editor setting hasn't passed yet since this method was last called. (By default, this interval is set to 0.3 seconds.)</para>
        /// </summary>
        [GodotMethod("refresh")]
        public void Refresh()
        {
            NativeCalls.godot_icall_0_3(method_bind_0, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
