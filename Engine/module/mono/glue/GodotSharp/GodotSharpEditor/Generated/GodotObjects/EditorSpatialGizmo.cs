using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Custom gizmo that is used for providing custom visualization and editing (handles) for 3D Spatial objects. See <see cref="Godot.EditorSpatialGizmoPlugin"/> for more information.</para>
    /// </summary>
    public partial class EditorSpatialGizmo : SpatialGizmo
    {
        private const string nativeName = "EditorSpatialGizmo";

        public EditorSpatialGizmo() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_EditorSpatialGizmo_Ctor(this);
        }

        internal EditorSpatialGizmo(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>Commit a handle being edited (handles must have been previously added by <see cref="Godot.EditorSpatialGizmo.AddHandles"/>).</para>
        /// <para>If the <c>cancel</c> parameter is <c>true</c>, an option to restore the edited value to the original is provided.</para>
        /// </summary>
        [GodotMethod("commit_handle")]
        public virtual void CommitHandle(int index, object restore, bool cancel)
        {
            return;
        }

        /// <summary>
        /// <para>Gets the name of an edited handle (handles must have been previously added by <see cref="Godot.EditorSpatialGizmo.AddHandles"/>).</para>
        /// <para>Handles can be named for reference to the user when editing.</para>
        /// </summary>
        [GodotMethod("get_handle_name")]
        public virtual string GetHandleName(int index)
        {
            return default(string);
        }

        /// <summary>
        /// <para>Gets actual value of a handle. This value can be anything and used for eventually undoing the motion when calling <see cref="Godot.EditorSpatialGizmo.CommitHandle"/>.</para>
        /// </summary>
        [GodotMethod("get_handle_value")]
        public virtual object GetHandleValue(int index)
        {
            return default(object);
        }

        /// <summary>
        /// <para>Returns <c>true</c> if the handle at index <c>index</c> is highlighted by being hovered with the mouse.</para>
        /// </summary>
        [GodotMethod("is_handle_highlighted")]
        public virtual bool IsHandleHighlighted(int index)
        {
            return default(bool);
        }

        /// <summary>
        /// <para>This function is called when the <see cref="Godot.Spatial"/> this gizmo refers to changes (the <see cref="Godot.Spatial.UpdateGizmo"/> is called).</para>
        /// </summary>
        [GodotMethod("redraw")]
        public virtual void Redraw()
        {
            return;
        }

        /// <summary>
        /// <para>This function is used when the user drags a gizmo handle (previously added with <see cref="Godot.EditorSpatialGizmo.AddHandles"/>) in screen coordinates.</para>
        /// <para>The <see cref="Godot.Camera"/> is also provided so screen coordinates can be converted to raycasts.</para>
        /// </summary>
        [GodotMethod("set_handle")]
        public virtual void SetHandle(int index, Camera camera, Vector2 point)
        {
            return;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_lines");

        /// <summary>
        /// <para>Adds lines to the gizmo (as sets of 2 points), with a given material. The lines are used for visualizing the gizmo. Call this function during <see cref="Godot.EditorSpatialGizmo.Redraw"/>.</para>
        /// </summary>
        /// <param name="modulate">If the parameter is null, then the default value is new Color(1, 1, 1, 1)</param>
        [GodotMethod("add_lines")]
        public void AddLines(Vector3[] lines, Material material, bool billboard = false, Nullable<Color> modulate = null)
        {
            Color modulate_in = modulate.HasValue ? modulate.Value : new Color(1, 1, 1, 1);
            EditorNativeCalls.godot_icall_4_408(method_bind_0, Object.GetPtr(this), lines, Object.GetPtr(material), billboard, ref modulate_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_mesh");

        /// <summary>
        /// <para>Adds a mesh to the gizmo with the specified <c>billboard</c> state, <c>skeleton</c> and <c>material</c>. If <c>billboard</c> is <c>true</c>, the mesh will rotate to always face the camera. Call this function during <see cref="Godot.EditorSpatialGizmo.Redraw"/>.</para>
        /// </summary>
        [GodotMethod("add_mesh")]
        public void AddMesh(Mesh mesh, bool billboard = false, SkinReference skeleton = null, Material material = null)
        {
            EditorNativeCalls.godot_icall_4_409(method_bind_1, Object.GetPtr(this), Object.GetPtr(mesh), billboard, Object.GetPtr(skeleton), Object.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_collision_segments");

        /// <summary>
        /// <para>Adds the specified <c>segments</c> to the gizmo's collision shape for picking. Call this function during <see cref="Godot.EditorSpatialGizmo.Redraw"/>.</para>
        /// </summary>
        [GodotMethod("add_collision_segments")]
        public void AddCollisionSegments(Vector3[] segments)
        {
            NativeCalls.godot_icall_1_229(method_bind_2, Object.GetPtr(this), segments);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_collision_triangles");

        /// <summary>
        /// <para>Adds collision triangles to the gizmo for picking. A <see cref="Godot.TriangleMesh"/> can be generated from a regular <see cref="Godot.Mesh"/> too. Call this function during <see cref="Godot.EditorSpatialGizmo.Redraw"/>.</para>
        /// </summary>
        [GodotMethod("add_collision_triangles")]
        public void AddCollisionTriangles(TriangleMesh triangles)
        {
            NativeCalls.godot_icall_1_24(method_bind_3, Object.GetPtr(this), Object.GetPtr(triangles));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_unscaled_billboard");

        /// <summary>
        /// <para>Adds an unscaled billboard for visualization. Call this function during <see cref="Godot.EditorSpatialGizmo.Redraw"/>.</para>
        /// </summary>
        /// <param name="modulate">If the parameter is null, then the default value is new Color(1, 1, 1, 1)</param>
        [GodotMethod("add_unscaled_billboard")]
        public void AddUnscaledBillboard(Material material, float defaultScale = (float)1, Nullable<Color> modulate = null)
        {
            Color modulate_in = modulate.HasValue ? modulate.Value : new Color(1, 1, 1, 1);
            EditorNativeCalls.godot_icall_3_410(method_bind_4, Object.GetPtr(this), Object.GetPtr(material), defaultScale, ref modulate_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_handles");

        /// <summary>
        /// <para>Adds a list of handles (points) which can be used to deform the object being edited.</para>
        /// <para>There are virtual functions which will be called upon editing of these handles. Call this function during <see cref="Godot.EditorSpatialGizmo.Redraw"/>.</para>
        /// </summary>
        [GodotMethod("add_handles")]
        public void AddHandles(Vector3[] handles, Material material, bool billboard = false, bool secondary = false)
        {
            EditorNativeCalls.godot_icall_4_411(method_bind_5, Object.GetPtr(this), handles, Object.GetPtr(material), billboard, secondary);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_spatial_node");

        /// <summary>
        /// <para>Sets the reference <see cref="Godot.Spatial"/> node for the gizmo. <c>node</c> must inherit from <see cref="Godot.Spatial"/>.</para>
        /// </summary>
        [GodotMethod("set_spatial_node")]
        public void SetSpatialNode(Node node)
        {
            NativeCalls.godot_icall_1_53(method_bind_6, Object.GetPtr(this), Object.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_spatial_node");

        /// <summary>
        /// <para>Returns the Spatial node associated with this gizmo.</para>
        /// </summary>
        [GodotMethod("get_spatial_node")]
        public Spatial GetSpatialNode()
        {
            return NativeCalls.godot_icall_0_412(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_plugin");

        /// <summary>
        /// <para>Returns the <see cref="Godot.EditorSpatialGizmoPlugin"/> that owns this gizmo. It's useful to retrieve materials using <see cref="Godot.EditorSpatialGizmoPlugin.GetMaterial"/>.</para>
        /// </summary>
        [GodotMethod("get_plugin")]
        public EditorSpatialGizmoPlugin GetPlugin()
        {
            return EditorNativeCalls.godot_icall_0_413(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Removes everything in the gizmo including meshes, collisions and handles.</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_hidden");

        /// <summary>
        /// <para>Sets the gizmo's hidden state. If <c>true</c>, the gizmo will be hidden. If <c>false</c>, it will be shown.</para>
        /// </summary>
        [GodotMethod("set_hidden")]
        public void SetHidden(bool hidden)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), hidden);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
