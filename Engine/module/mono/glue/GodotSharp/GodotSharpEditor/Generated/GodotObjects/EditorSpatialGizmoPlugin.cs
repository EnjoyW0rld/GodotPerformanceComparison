using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.EditorSpatialGizmoPlugin"/> allows you to define a new type of Gizmo. There are two main ways to do so: extending <see cref="Godot.EditorSpatialGizmoPlugin"/> for the simpler gizmos, or creating a new <see cref="Godot.EditorSpatialGizmo"/> type. See the tutorial in the documentation for more info.</para>
    /// <para>To use <see cref="Godot.EditorSpatialGizmoPlugin"/>, register it using the <see cref="Godot.EditorPlugin.AddSpatialGizmoPlugin"/> method first.</para>
    /// </summary>
    public partial class EditorSpatialGizmoPlugin : Resource
    {
        private const string nativeName = "EditorSpatialGizmoPlugin";

        public EditorSpatialGizmoPlugin() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_EditorSpatialGizmoPlugin_Ctor(this);
        }

        internal EditorSpatialGizmoPlugin(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>Override this method to define whether the gizmo can be hidden or not. Returns <c>true</c> if not overridden.</para>
        /// </summary>
        [GodotMethod("can_be_hidden")]
        public virtual bool CanBeHidden()
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Override this method to commit gizmo handles. Called for this plugin's active gizmos.</para>
        /// </summary>
        [GodotMethod("commit_handle")]
        public virtual void CommitHandle(EditorSpatialGizmo gizmo, int index, object restore, bool cancel)
        {
            return;
        }

        /// <summary>
        /// <para>Override this method to return a custom <see cref="Godot.EditorSpatialGizmo"/> for the spatial nodes of your choice, return <c>null</c> for the rest of nodes. See also <see cref="Godot.EditorSpatialGizmoPlugin.HasGizmo"/>.</para>
        /// </summary>
        [GodotMethod("create_gizmo")]
        public virtual EditorSpatialGizmo CreateGizmo(Spatial spatial)
        {
            return default(EditorSpatialGizmo);
        }

        /// <summary>
        /// <para>Override this method to provide gizmo's handle names. Called for this plugin's active gizmos.</para>
        /// </summary>
        [GodotMethod("get_handle_name")]
        public virtual string GetHandleName(EditorSpatialGizmo gizmo, int index)
        {
            return default(string);
        }

        /// <summary>
        /// <para>Gets actual value of a handle from gizmo. Called for this plugin's active gizmos.</para>
        /// </summary>
        [GodotMethod("get_handle_value")]
        public virtual object GetHandleValue(EditorSpatialGizmo gizmo, int index)
        {
            return default(object);
        }

        /// <summary>
        /// <para>Override this method to provide the name that will appear in the gizmo visibility menu.</para>
        /// </summary>
        [GodotMethod("get_name")]
        public virtual string GetName()
        {
            return default(string);
        }

        /// <summary>
        /// <para>Override this method to set the gizmo's priority. Higher values correspond to higher priority. If a gizmo with higher priority conflicts with another gizmo, only the gizmo with higher priority will be used.</para>
        /// <para>All built-in editor gizmos return a priority of <c>-1</c>. If not overridden, this method will return <c>0</c>, which means custom gizmos will automatically override built-in gizmos.</para>
        /// </summary>
        [GodotMethod("get_priority")]
        public virtual int GetPriority()
        {
            return default(int);
        }

        /// <summary>
        /// <para>Override this method to define which Spatial nodes have a gizmo from this plugin. Whenever a <see cref="Godot.Spatial"/> node is added to a scene this method is called, if it returns <c>true</c> the node gets a generic <see cref="Godot.EditorSpatialGizmo"/> assigned and is added to this plugin's list of active gizmos.</para>
        /// </summary>
        [GodotMethod("has_gizmo")]
        public virtual bool HasGizmo(Spatial spatial)
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Gets whether a handle is highlighted or not. Called for this plugin's active gizmos.</para>
        /// </summary>
        [GodotMethod("is_handle_highlighted")]
        public virtual bool IsHandleHighlighted(EditorSpatialGizmo gizmo, int index)
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Override this method to define whether a Spatial with this gizmo should be selectable even when the gizmo is hidden.</para>
        /// </summary>
        [GodotMethod("is_selectable_when_hidden")]
        public virtual bool IsSelectableWhenHidden()
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Callback to redraw the provided gizmo. Called for this plugin's active gizmos.</para>
        /// </summary>
        [GodotMethod("redraw")]
        public virtual void Redraw(EditorSpatialGizmo gizmo)
        {
            return;
        }

        /// <summary>
        /// <para>Update the value of a handle after it has been updated. Called for this plugin's active gizmos.</para>
        /// </summary>
        [GodotMethod("set_handle")]
        public virtual void SetHandle(EditorSpatialGizmo gizmo, int index, Camera camera, Vector2 point)
        {
            return;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_material");

        /// <summary>
        /// <para>Creates an unshaded material with its variants (selected and/or editable) and adds them to the internal material list. They can then be accessed with <see cref="Godot.EditorSpatialGizmoPlugin.GetMaterial"/> and used in <see cref="Godot.EditorSpatialGizmo.AddMesh"/> and <see cref="Godot.EditorSpatialGizmo.AddLines"/>. Should not be overridden.</para>
        /// </summary>
        [GodotMethod("create_material")]
        public void CreateMaterial(string name, Color color, bool billboard = false, bool onTop = false, bool useVertexColor = false)
        {
            EditorNativeCalls.godot_icall_5_414(method_bind_0, Object.GetPtr(this), name, ref color, billboard, onTop, useVertexColor);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_icon_material");

        /// <summary>
        /// <para>Creates an icon material with its variants (selected and/or editable) and adds them to the internal material list. They can then be accessed with <see cref="Godot.EditorSpatialGizmoPlugin.GetMaterial"/> and used in <see cref="Godot.EditorSpatialGizmo.AddUnscaledBillboard"/>. Should not be overridden.</para>
        /// </summary>
        /// <param name="color">If the parameter is null, then the default value is new Color(1, 1, 1, 1)</param>
        [GodotMethod("create_icon_material")]
        public void CreateIconMaterial(string name, Texture texture, bool onTop = false, Nullable<Color> color = null)
        {
            Color color_in = color.HasValue ? color.Value : new Color(1, 1, 1, 1);
            EditorNativeCalls.godot_icall_4_415(method_bind_1, Object.GetPtr(this), name, Object.GetPtr(texture), onTop, ref color_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_handle_material");

        /// <summary>
        /// <para>Creates a handle material with its variants (selected and/or editable) and adds them to the internal material list. They can then be accessed with <see cref="Godot.EditorSpatialGizmoPlugin.GetMaterial"/> and used in <see cref="Godot.EditorSpatialGizmo.AddHandles"/>. Should not be overridden.</para>
        /// <para>You can optionally provide a texture to use instead of the default icon.</para>
        /// </summary>
        [GodotMethod("create_handle_material")]
        public void CreateHandleMaterial(string name, bool billboard = false, Texture texture = null)
        {
            EditorNativeCalls.godot_icall_3_416(method_bind_2, Object.GetPtr(this), name, billboard, Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_material");

        /// <summary>
        /// <para>Adds a new material to the internal material list for the plugin. It can then be accessed with <see cref="Godot.EditorSpatialGizmoPlugin.GetMaterial"/>. Should not be overridden.</para>
        /// </summary>
        [GodotMethod("add_material")]
        public void AddMaterial(string name, SpatialMaterial material)
        {
            NativeCalls.godot_icall_2_114(method_bind_3, Object.GetPtr(this), name, Object.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_material");

        /// <summary>
        /// <para>Gets material from the internal list of materials. If an <see cref="Godot.EditorSpatialGizmo"/> is provided, it will try to get the corresponding variant (selected and/or editable).</para>
        /// </summary>
        [GodotMethod("get_material")]
        public SpatialMaterial GetMaterial(string name, EditorSpatialGizmo gizmo = null)
        {
            return EditorNativeCalls.godot_icall_2_417(method_bind_4, Object.GetPtr(this), name, Object.GetPtr(gizmo));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
