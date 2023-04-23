using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Base class of anything 2D. Canvas items are laid out in a tree; children inherit and extend their parent's transform. <see cref="Godot.CanvasItem"/> is extended by <see cref="Godot.Control"/> for anything GUI-related, and by <see cref="Godot.Node2D"/> for anything related to the 2D engine.</para>
    /// <para>Any <see cref="Godot.CanvasItem"/> can draw. For this, <see cref="Godot.CanvasItem.Update"/> is called by the engine, then <see cref="Godot.CanvasItem.NotificationDraw"/> will be received on idle time to request redraw. Because of this, canvas items don't need to be redrawn on every frame, improving the performance significantly. Several functions for drawing on the <see cref="Godot.CanvasItem"/> are provided (see <c>draw_*</c> functions). However, they can only be used inside <see cref="Godot.CanvasItem._Draw"/>, its corresponding <see cref="Godot.Object._Notification"/> or methods connected to the <c>draw</c> signal.</para>
    /// <para>Canvas items are drawn in tree order. By default, children are on top of their parents so a root <see cref="Godot.CanvasItem"/> will be drawn behind everything. This behavior can be changed on a per-item basis.</para>
    /// <para>A <see cref="Godot.CanvasItem"/> can also be hidden, which will also hide its children. It provides many ways to change parameters such as modulation (for itself and its children) and self modulation (only for itself), as well as its blend mode.</para>
    /// <para>Ultimately, a transform notification can be requested, which will notify the node that its global position changed in case the parent tree changed.</para>
    /// <para>Note: Unless otherwise specified, all methods that have angle parameters must have angles specified as radians. To convert degrees to radians, use <c>@GDScript.deg2rad</c>.</para>
    /// </summary>
    public abstract partial class CanvasItem : Node
    {
        /// <summary>
        /// <para>The <see cref="Godot.CanvasItem"/>'s global transform has changed. This notification is only received if enabled by <see cref="Godot.CanvasItem.SetNotifyTransform"/>.</para>
        /// </summary>
        public const int NotificationTransformChanged = 2000;
        /// <summary>
        /// <para>The <see cref="Godot.CanvasItem"/>'s local transform has changed. This notification is only received if enabled by <see cref="Godot.CanvasItem.SetNotifyLocalTransform"/>.</para>
        /// </summary>
        public const int NotificationLocalTransformChanged = 35;
        /// <summary>
        /// <para>The <see cref="Godot.CanvasItem"/> is requested to draw (see <see cref="Godot.CanvasItem._Draw"/>).</para>
        /// </summary>
        public const int NotificationDraw = 30;
        /// <summary>
        /// <para>The <see cref="Godot.CanvasItem"/>'s visibility has changed.</para>
        /// </summary>
        public const int NotificationVisibilityChanged = 31;
        /// <summary>
        /// <para>The <see cref="Godot.CanvasItem"/> has entered the canvas.</para>
        /// </summary>
        public const int NotificationEnterCanvas = 32;
        /// <summary>
        /// <para>The <see cref="Godot.CanvasItem"/> has exited the canvas.</para>
        /// </summary>
        public const int NotificationExitCanvas = 33;

        public enum BlendMode
        {
            /// <summary>
            /// <para>Mix blending mode. Colors are assumed to be independent of the alpha (opacity) value.</para>
            /// </summary>
            Mix = 0,
            /// <summary>
            /// <para>Additive blending mode.</para>
            /// </summary>
            Add = 1,
            /// <summary>
            /// <para>Subtractive blending mode.</para>
            /// </summary>
            Sub = 2,
            /// <summary>
            /// <para>Multiplicative blending mode.</para>
            /// </summary>
            Mul = 3,
            /// <summary>
            /// <para>Mix blending mode. Colors are assumed to be premultiplied by the alpha (opacity) value.</para>
            /// </summary>
            PremultAlpha = 4,
            /// <summary>
            /// <para>Disables blending mode. Colors including alpha are written as-is. Only applicable for render targets with a transparent background. No lighting will be applied.</para>
            /// </summary>
            Disabled = 5
        }

        /// <summary>
        /// <para>If <c>true</c>, this <see cref="Godot.CanvasItem"/> is drawn. The node is only visible if all of its antecedents are visible as well (in other words, <see cref="Godot.CanvasItem.IsVisibleInTree"/> must return <c>true</c>).</para>
        /// <para>Note: For controls that inherit <see cref="Godot.Popup"/>, the correct way to make them visible is to call one of the multiple <c>popup*()</c> functions instead.</para>
        /// </summary>
        public bool Visible
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsVisible();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVisible(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The color applied to textures on this <see cref="Godot.CanvasItem"/>.</para>
        /// </summary>
        public Color Modulate
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetModulate();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetModulate(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The color applied to textures on this <see cref="Godot.CanvasItem"/>. This is not inherited by children <see cref="Godot.CanvasItem"/>s.</para>
        /// </summary>
        public Color SelfModulate
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSelfModulate();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSelfModulate(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the object draws behind its parent.</para>
        /// </summary>
        public bool ShowBehindParent
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDrawBehindParentEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDrawBehindParent(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the object draws on top of its parent.</para>
        /// </summary>
        public bool ShowOnTop
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _IsOnTop();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetOnTop(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The rendering layers in which this <see cref="Godot.CanvasItem"/> responds to <see cref="Godot.Light2D"/> nodes.</para>
        /// </summary>
        public int LightMask
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLightMask();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLightMask(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The material applied to textures on this <see cref="Godot.CanvasItem"/>.</para>
        /// </summary>
        public Material Material
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaterial();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaterial(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the parent <see cref="Godot.CanvasItem"/>'s <see cref="Godot.CanvasItem.Material"/> property is used as this one's material.</para>
        /// </summary>
        public bool UseParentMaterial
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUseParentMaterial();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseParentMaterial(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "CanvasItem";

        internal CanvasItem() {}

        internal CanvasItem(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>Called when <see cref="Godot.CanvasItem"/> has been requested to redraw (when <see cref="Godot.CanvasItem.Update"/> is called, either manually or by the engine).</para>
        /// <para>Corresponds to the <see cref="Godot.CanvasItem.NotificationDraw"/> notification in <see cref="Godot.Object._Notification"/>.</para>
        /// </summary>
        [GodotMethod("_draw")]
        public virtual void _Draw()
        {
            return;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_canvas_item");

        /// <summary>
        /// <para>Returns the canvas item RID used by <see cref="Godot.VisualServer"/> for this item.</para>
        /// </summary>
        [GodotMethod("get_canvas_item")]
        public RID GetCanvasItem()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_0, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_visible");

        [GodotMethod("set_visible")]
        [Obsolete("SetVisible is deprecated. Use the Visible property instead.")]
        public void SetVisible(bool visible)
        {
            NativeCalls.godot_icall_1_16(method_bind_1, Object.GetPtr(this), visible);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_visible");

        [GodotMethod("is_visible")]
        [Obsolete("IsVisible is deprecated. Use the Visible property instead.")]
        public bool IsVisible()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_visible_in_tree");

        /// <summary>
        /// <para>Returns <c>true</c> if the node is present in the <see cref="Godot.SceneTree"/>, its <see cref="Godot.CanvasItem.Visible"/> property is <c>true</c> and all its antecedents are also visible. If any antecedent is hidden, this node will not be visible in the scene tree, and is consequently not drawn (see <see cref="Godot.CanvasItem._Draw"/>).</para>
        /// </summary>
        [GodotMethod("is_visible_in_tree")]
        public bool IsVisibleInTree()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "show");

        /// <summary>
        /// <para>Show the <see cref="Godot.CanvasItem"/> if it's currently hidden. This is equivalent to setting <see cref="Godot.CanvasItem.Visible"/> to <c>true</c>. For controls that inherit <see cref="Godot.Popup"/>, the correct way to make them visible is to call one of the multiple <c>popup*()</c> functions instead.</para>
        /// </summary>
        [GodotMethod("show")]
        public void Show()
        {
            NativeCalls.godot_icall_0_3(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "hide");

        /// <summary>
        /// <para>Hide the <see cref="Godot.CanvasItem"/> if it's currently visible. This is equivalent to setting <see cref="Godot.CanvasItem.Visible"/> to <c>false</c>.</para>
        /// </summary>
        [GodotMethod("hide")]
        public void Hide()
        {
            NativeCalls.godot_icall_0_3(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "update");

        /// <summary>
        /// <para>Queues the <see cref="Godot.CanvasItem"/> to redraw. During idle time, if <see cref="Godot.CanvasItem"/> is visible, <see cref="Godot.CanvasItem.NotificationDraw"/> is sent and <see cref="Godot.CanvasItem._Draw"/> is called. This only occurs once per frame, even if this method has been called multiple times.</para>
        /// </summary>
        [GodotMethod("update")]
        public void Update()
        {
            NativeCalls.godot_icall_0_3(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_as_toplevel");

        /// <summary>
        /// <para>If <c>enable</c> is <c>true</c>, this <see cref="Godot.CanvasItem"/> will not inherit its transform from parent <see cref="Godot.CanvasItem"/>s. Its draw order will also be changed to make it draw on top of other <see cref="Godot.CanvasItem"/>s that are not set as top-level. The <see cref="Godot.CanvasItem"/> will effectively act as if it was placed as a child of a bare <see cref="Godot.Node"/>. See also <see cref="Godot.CanvasItem.IsSetAsToplevel"/>.</para>
        /// </summary>
        [GodotMethod("set_as_toplevel")]
        public void SetAsToplevel(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_7, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_set_as_toplevel");

        /// <summary>
        /// <para>Returns <c>true</c> if the node is set as top-level. See <see cref="Godot.CanvasItem.SetAsToplevel"/>.</para>
        /// </summary>
        [GodotMethod("is_set_as_toplevel")]
        public bool IsSetAsToplevel()
        {
            return NativeCalls.godot_icall_0_7(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_light_mask");

        [GodotMethod("set_light_mask")]
        [Obsolete("SetLightMask is deprecated. Use the LightMask property instead.")]
        public void SetLightMask(int lightMask)
        {
            NativeCalls.godot_icall_1_4(method_bind_9, Object.GetPtr(this), lightMask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_light_mask");

        [GodotMethod("get_light_mask")]
        [Obsolete("GetLightMask is deprecated. Use the LightMask property instead.")]
        public int GetLightMask()
        {
            return NativeCalls.godot_icall_0_5(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_modulate");

        [GodotMethod("set_modulate")]
        [Obsolete("SetModulate is deprecated. Use the Modulate property instead.")]
        public void SetModulate(Color modulate)
        {
            NativeCalls.godot_icall_1_199(method_bind_11, Object.GetPtr(this), ref modulate);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_modulate");

        [GodotMethod("get_modulate")]
        [Obsolete("GetModulate is deprecated. Use the Modulate property instead.")]
        public Color GetModulate()
        {
            NativeCalls.godot_icall_0_200(method_bind_12, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_self_modulate");

        [GodotMethod("set_self_modulate")]
        [Obsolete("SetSelfModulate is deprecated. Use the SelfModulate property instead.")]
        public void SetSelfModulate(Color selfModulate)
        {
            NativeCalls.godot_icall_1_199(method_bind_13, Object.GetPtr(this), ref selfModulate);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_self_modulate");

        [GodotMethod("get_self_modulate")]
        [Obsolete("GetSelfModulate is deprecated. Use the SelfModulate property instead.")]
        public Color GetSelfModulate()
        {
            NativeCalls.godot_icall_0_200(method_bind_14, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_draw_behind_parent");

        [GodotMethod("set_draw_behind_parent")]
        [Obsolete("SetDrawBehindParent is deprecated. Use the ShowBehindParent property instead.")]
        public void SetDrawBehindParent(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_15, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_draw_behind_parent_enabled");

        [GodotMethod("is_draw_behind_parent_enabled")]
        [Obsolete("IsDrawBehindParentEnabled is deprecated. Use the ShowBehindParent property instead.")]
        public bool IsDrawBehindParentEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_on_top");

        [Obsolete("_SetOnTop is deprecated. Use the ShowOnTop property instead.")]
        internal void _SetOnTop(bool onTop)
        {
            NativeCalls.godot_icall_1_16(method_bind_17, Object.GetPtr(this), onTop);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_is_on_top");

        [Obsolete("_IsOnTop is deprecated. Use the ShowOnTop property instead.")]
        internal bool _IsOnTop()
        {
            return NativeCalls.godot_icall_0_7(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_line");

        /// <summary>
        /// <para>Draws a line from a 2D point to another, with a given color and width. It can be optionally antialiased. See also <see cref="Godot.CanvasItem.DrawMultiline"/> and <see cref="Godot.CanvasItem.DrawPolyline"/>.</para>
        /// <para>Note: Line drawing is not accelerated by batching if <c>antialiased</c> is <c>true</c>.</para>
        /// <para>Note: Due to how it works, built-in antialiasing will not look correct for translucent lines and may not work on certain platforms. As a workaround, install the <a href="https://github.com/godot-extended-libraries/godot-antialiased-line2d">Antialiased Line2D</a> add-on then create an AntialiasedLine2D node. That node relies on a texture with custom mipmaps to perform antialiasing. 2D batching is also still supported with those antialiased lines.</para>
        /// </summary>
        [GodotMethod("draw_line")]
        public void DrawLine(Vector2 from, Vector2 to, Color color, float width = 1f, bool antialiased = false)
        {
            NativeCalls.godot_icall_5_261(method_bind_19, Object.GetPtr(this), ref from, ref to, ref color, width, antialiased);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_polyline");

        /// <summary>
        /// <para>Draws interconnected line segments with a uniform <c>color</c> and <c>width</c> and optional antialiasing. When drawing large amounts of lines, this is faster than using individual <see cref="Godot.CanvasItem.DrawLine"/> calls. To draw disconnected lines, use <see cref="Godot.CanvasItem.DrawMultiline"/> instead. See also <see cref="Godot.CanvasItem.DrawPolygon"/>.</para>
        /// <para>Note: Due to how it works, built-in antialiasing will not look correct for translucent polygons and may not work on certain platforms. As a workaround, install the <a href="https://github.com/godot-extended-libraries/godot-antialiased-line2d">Antialiased Line2D</a> add-on then create an AntialiasedPolygon2D node. That node relies on a texture with custom mipmaps to perform antialiasing.</para>
        /// </summary>
        [GodotMethod("draw_polyline")]
        public void DrawPolyline(Vector2[] points, Color color, float width = 1f, bool antialiased = false)
        {
            NativeCalls.godot_icall_4_262(method_bind_20, Object.GetPtr(this), points, ref color, width, antialiased);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_polyline_colors");

        /// <summary>
        /// <para>Draws interconnected line segments with a uniform <c>width</c> and segment-by-segment coloring, and optional antialiasing. Colors assigned to line segments match by index between <c>points</c> and <c>colors</c>. When drawing large amounts of lines, this is faster than using individual <see cref="Godot.CanvasItem.DrawLine"/> calls. To draw disconnected lines, use <see cref="Godot.CanvasItem.DrawMultilineColors"/> instead. See also <see cref="Godot.CanvasItem.DrawPolygon"/>.</para>
        /// <para>Note: Due to how it works, built-in antialiasing will not look correct for translucent polygons and may not work on certain platforms. As a workaround, install the <a href="https://github.com/godot-extended-libraries/godot-antialiased-line2d">Antialiased Line2D</a> add-on then create an AntialiasedPolygon2D node. That node relies on a texture with custom mipmaps to perform antialiasing.</para>
        /// </summary>
        [GodotMethod("draw_polyline_colors")]
        public void DrawPolylineColors(Vector2[] points, Color[] colors, float width = 1f, bool antialiased = false)
        {
            NativeCalls.godot_icall_4_263(method_bind_21, Object.GetPtr(this), points, colors, width, antialiased);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_arc");

        /// <summary>
        /// <para>Draws a unfilled arc between the given angles. The larger the value of <c>point_count</c>, the smoother the curve. See also <see cref="Godot.CanvasItem.DrawCircle"/>.</para>
        /// <para>Note: Line drawing is not accelerated by batching if <c>antialiased</c> is <c>true</c>.</para>
        /// <para>Note: Due to how it works, built-in antialiasing will not look correct for translucent lines and may not work on certain platforms. As a workaround, install the <a href="https://github.com/godot-extended-libraries/godot-antialiased-line2d">Antialiased Line2D</a> add-on then create an AntialiasedRegularPolygon2D node. That node relies on a texture with custom mipmaps to perform antialiasing. 2D batching is also still supported with those antialiased lines.</para>
        /// </summary>
        [GodotMethod("draw_arc")]
        public void DrawArc(Vector2 center, float radius, float startAngle, float endAngle, int pointCount, Color color, float width = 1f, bool antialiased = false)
        {
            NativeCalls.godot_icall_8_264(method_bind_22, Object.GetPtr(this), ref center, radius, startAngle, endAngle, pointCount, ref color, width, antialiased);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_multiline");

        /// <summary>
        /// <para>Draws multiple disconnected lines with a uniform <c>color</c>. When drawing large amounts of lines, this is faster than using individual <see cref="Godot.CanvasItem.DrawLine"/> calls. To draw interconnected lines, use <see cref="Godot.CanvasItem.DrawPolyline"/> instead.</para>
        /// <para>Note: <c>width</c> and <c>antialiased</c> are currently not implemented and have no effect. As a workaround, install the <a href="https://github.com/godot-extended-libraries/godot-antialiased-line2d">Antialiased Line2D</a> add-on then create an AntialiasedLine2D node. That node relies on a texture with custom mipmaps to perform antialiasing. 2D batching is also still supported with those antialiased lines.</para>
        /// </summary>
        [GodotMethod("draw_multiline")]
        public void DrawMultiline(Vector2[] points, Color color, float width = 1f, bool antialiased = false)
        {
            NativeCalls.godot_icall_4_262(method_bind_23, Object.GetPtr(this), points, ref color, width, antialiased);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_multiline_colors");

        /// <summary>
        /// <para>Draws multiple disconnected lines with a uniform <c>width</c> and segment-by-segment coloring. Colors assigned to line segments match by index between <c>points</c> and <c>colors</c>. When drawing large amounts of lines, this is faster than using individual <see cref="Godot.CanvasItem.DrawLine"/> calls. To draw interconnected lines, use <see cref="Godot.CanvasItem.DrawPolylineColors"/> instead.</para>
        /// <para>Note: <c>width</c> and <c>antialiased</c> are currently not implemented and have no effect. As a workaround, install the <a href="https://github.com/godot-extended-libraries/godot-antialiased-line2d">Antialiased Line2D</a> add-on then create an AntialiasedLine2D node. That node relies on a texture with custom mipmaps to perform antialiasing. 2D batching is also still supported with those antialiased lines.</para>
        /// </summary>
        [GodotMethod("draw_multiline_colors")]
        public void DrawMultilineColors(Vector2[] points, Color[] colors, float width = 1f, bool antialiased = false)
        {
            NativeCalls.godot_icall_4_263(method_bind_24, Object.GetPtr(this), points, colors, width, antialiased);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_rect");

        /// <summary>
        /// <para>Draws a rectangle. If <c>filled</c> is <c>true</c>, the rectangle will be filled with the <c>color</c> specified. If <c>filled</c> is <c>false</c>, the rectangle will be drawn as a stroke with the <c>color</c> and <c>width</c> specified. If <c>antialiased</c> is <c>true</c>, the lines will attempt to perform antialiasing using OpenGL line smoothing.</para>
        /// <para>Note: <c>width</c> and <c>antialiased</c> are only effective if <c>filled</c> is <c>false</c>.</para>
        /// <para>Note: Due to how it works, built-in antialiasing will not look correct for translucent polygons and may not work on certain platforms. As a workaround, install the <a href="https://github.com/godot-extended-libraries/godot-antialiased-line2d">Antialiased Line2D</a> add-on then create an AntialiasedPolygon2D node. That node relies on a texture with custom mipmaps to perform antialiasing.</para>
        /// </summary>
        [GodotMethod("draw_rect")]
        public void DrawRect(Rect2 rect, Color color, bool filled = true, float width = 1f, bool antialiased = false)
        {
            NativeCalls.godot_icall_5_265(method_bind_25, Object.GetPtr(this), ref rect, ref color, filled, width, antialiased);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_circle");

        /// <summary>
        /// <para>Draws a colored, filled circle. See also <see cref="Godot.CanvasItem.DrawArc"/>, <see cref="Godot.CanvasItem.DrawPolyline"/> and <see cref="Godot.CanvasItem.DrawPolygon"/>.</para>
        /// <para>Note: Built-in antialiasing is not provided for <see cref="Godot.CanvasItem.DrawCircle"/>. As a workaround, install the <a href="https://github.com/godot-extended-libraries/godot-antialiased-line2d">Antialiased Line2D</a> add-on then create an AntialiasedRegularPolygon2D node. That node relies on a texture with custom mipmaps to perform antialiasing.</para>
        /// </summary>
        [GodotMethod("draw_circle")]
        public void DrawCircle(Vector2 position, float radius, Color color)
        {
            NativeCalls.godot_icall_3_266(method_bind_26, Object.GetPtr(this), ref position, radius, ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_texture");

        /// <summary>
        /// <para>Draws a texture at a given position.</para>
        /// </summary>
        /// <param name="modulate">If the parameter is null, then the default value is new Color(1, 1, 1, 1)</param>
        [GodotMethod("draw_texture")]
        public void DrawTexture(Texture texture, Vector2 position, Nullable<Color> modulate = null, Texture normalMap = null)
        {
            Color modulate_in = modulate.HasValue ? modulate.Value : new Color(1, 1, 1, 1);
            NativeCalls.godot_icall_4_267(method_bind_27, Object.GetPtr(this), Object.GetPtr(texture), ref position, ref modulate_in, Object.GetPtr(normalMap));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_texture_rect");

        /// <summary>
        /// <para>Draws a textured rectangle at a given position, optionally modulated by a color. If <c>transpose</c> is <c>true</c>, the texture will have its X and Y coordinates swapped.</para>
        /// </summary>
        /// <param name="modulate">If the parameter is null, then the default value is new Color(1, 1, 1, 1)</param>
        [GodotMethod("draw_texture_rect")]
        public void DrawTextureRect(Texture texture, Rect2 rect, bool tile, Nullable<Color> modulate = null, bool transpose = false, Texture normalMap = null)
        {
            Color modulate_in = modulate.HasValue ? modulate.Value : new Color(1, 1, 1, 1);
            NativeCalls.godot_icall_6_268(method_bind_28, Object.GetPtr(this), Object.GetPtr(texture), ref rect, tile, ref modulate_in, transpose, Object.GetPtr(normalMap));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_texture_rect_region");

        /// <summary>
        /// <para>Draws a textured rectangle region at a given position, optionally modulated by a color. If <c>transpose</c> is <c>true</c>, the texture will have its X and Y coordinates swapped.</para>
        /// </summary>
        /// <param name="modulate">If the parameter is null, then the default value is new Color(1, 1, 1, 1)</param>
        [GodotMethod("draw_texture_rect_region")]
        public void DrawTextureRectRegion(Texture texture, Rect2 rect, Rect2 srcRect, Nullable<Color> modulate = null, bool transpose = false, Texture normalMap = null, bool clipUv = true)
        {
            Color modulate_in = modulate.HasValue ? modulate.Value : new Color(1, 1, 1, 1);
            NativeCalls.godot_icall_7_269(method_bind_29, Object.GetPtr(this), Object.GetPtr(texture), ref rect, ref srcRect, ref modulate_in, transpose, Object.GetPtr(normalMap), clipUv);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_style_box");

        /// <summary>
        /// <para>Draws a styled rectangle.</para>
        /// </summary>
        [GodotMethod("draw_style_box")]
        public void DrawStyleBox(StyleBox styleBox, Rect2 rect)
        {
            NativeCalls.godot_icall_2_270(method_bind_30, Object.GetPtr(this), Object.GetPtr(styleBox), ref rect);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_primitive");

        /// <summary>
        /// <para>Draws a custom primitive. 1 point for a point, 2 points for a line, 3 points for a triangle, and 4 points for a quad. If 0 points or more than 4 points are specified, nothing will be drawn and an error message will be printed. See also <see cref="Godot.CanvasItem.DrawLine"/>, <see cref="Godot.CanvasItem.DrawPolyline"/>, <see cref="Godot.CanvasItem.DrawPolygon"/>, and <see cref="Godot.CanvasItem.DrawRect"/>.</para>
        /// </summary>
        [GodotMethod("draw_primitive")]
        public void DrawPrimitive(Vector2[] points, Color[] colors, Vector2[] uvs, Texture texture = null, float width = 1f, Texture normalMap = null)
        {
            NativeCalls.godot_icall_6_271(method_bind_31, Object.GetPtr(this), points, colors, uvs, Object.GetPtr(texture), width, Object.GetPtr(normalMap));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_polygon");

        /// <summary>
        /// <para>Draws a solid polygon of any amount of points, convex or concave. Unlike <see cref="Godot.CanvasItem.DrawColoredPolygon"/>, each point's color can be changed individually. See also <see cref="Godot.CanvasItem.DrawPolyline"/> and <see cref="Godot.CanvasItem.DrawPolylineColors"/>.</para>
        /// <para>Note: Due to how it works, built-in antialiasing will not look correct for translucent polygons and may not work on certain platforms. As a workaround, install the <a href="https://github.com/godot-extended-libraries/godot-antialiased-line2d">Antialiased Line2D</a> add-on then create an AntialiasedPolygon2D node. That node relies on a texture with custom mipmaps to perform antialiasing.</para>
        /// </summary>
        /// <param name="uvs">If the parameter is null, then the default value is Array.Empty&lt;Vector2&gt;()</param>
        [GodotMethod("draw_polygon")]
        public void DrawPolygon(Vector2[] points, Color[] colors, Vector2[] uvs = null, Texture texture = null, Texture normalMap = null, bool antialiased = false)
        {
            Vector2[] uvs_in = uvs != null ? uvs : Array.Empty<Vector2>();
            NativeCalls.godot_icall_6_272(method_bind_32, Object.GetPtr(this), points, colors, uvs_in, Object.GetPtr(texture), Object.GetPtr(normalMap), antialiased);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_colored_polygon");

        /// <summary>
        /// <para>Draws a colored polygon of any amount of points, convex or concave. Unlike <see cref="Godot.CanvasItem.DrawPolygon"/>, a single color must be specified for the whole polygon.</para>
        /// <para>Note: Due to how it works, built-in antialiasing will not look correct for translucent polygons and may not work on certain platforms. As a workaround, install the <a href="https://github.com/godot-extended-libraries/godot-antialiased-line2d">Antialiased Line2D</a> add-on then create an AntialiasedPolygon2D node. That node relies on a texture with custom mipmaps to perform antialiasing.</para>
        /// </summary>
        /// <param name="uvs">If the parameter is null, then the default value is Array.Empty&lt;Vector2&gt;()</param>
        [GodotMethod("draw_colored_polygon")]
        public void DrawColoredPolygon(Vector2[] points, Color color, Vector2[] uvs = null, Texture texture = null, Texture normalMap = null, bool antialiased = false)
        {
            Vector2[] uvs_in = uvs != null ? uvs : Array.Empty<Vector2>();
            NativeCalls.godot_icall_6_273(method_bind_33, Object.GetPtr(this), points, ref color, uvs_in, Object.GetPtr(texture), Object.GetPtr(normalMap), antialiased);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_string");

        /// <summary>
        /// <para>Draws <c>text</c> using the specified <c>font</c> at the <c>position</c> (bottom-left corner using the baseline of the font). The text will have its color multiplied by <c>modulate</c>. If <c>clip_w</c> is greater than or equal to 0, the text will be clipped if it exceeds the specified width.</para>
        /// <para>Example using the default project font:</para>
        /// <para><code>
        /// # If using this method in a script that redraws constantly, move the
        /// # `default_font` declaration to a member variable assigned in `_ready()`
        /// # so the Control is only created once.
        /// var default_font = Control.new().get_font("font")
        /// draw_string(default_font, Vector2(64, 64), "Hello world")
        /// </code></para>
        /// <para>See also <see cref="Godot.Font.Draw"/>.</para>
        /// </summary>
        /// <param name="modulate">If the parameter is null, then the default value is new Color(1, 1, 1, 1)</param>
        [GodotMethod("draw_string")]
        public void DrawString(Font font, Vector2 position, string text, Nullable<Color> modulate = null, int clipW = -1)
        {
            Color modulate_in = modulate.HasValue ? modulate.Value : new Color(1, 1, 1, 1);
            NativeCalls.godot_icall_5_274(method_bind_34, Object.GetPtr(this), Object.GetPtr(font), ref position, text, ref modulate_in, clipW);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_char");

        /// <summary>
        /// <para>Draws a string character using a custom font. Returns the advance, depending on the character width and kerning with an optional next character.</para>
        /// </summary>
        /// <param name="modulate">If the parameter is null, then the default value is new Color(1, 1, 1, 1)</param>
        [GodotMethod("draw_char")]
        public float DrawChar(Font font, Vector2 position, string @char, string next, Nullable<Color> modulate = null)
        {
            Color modulate_in = modulate.HasValue ? modulate.Value : new Color(1, 1, 1, 1);
            return NativeCalls.godot_icall_5_275(method_bind_35, Object.GetPtr(this), Object.GetPtr(font), ref position, @char, next, ref modulate_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_mesh");

        /// <summary>
        /// <para>Draws a <see cref="Godot.Mesh"/> in 2D, using the provided texture. See <see cref="Godot.MeshInstance2D"/> for related documentation.</para>
        /// </summary>
        /// <param name="transform">If the parameter is null, then the default value is Transform2D.Identity</param>
        /// <param name="modulate">If the parameter is null, then the default value is new Color(1, 1, 1, 1)</param>
        [GodotMethod("draw_mesh")]
        public void DrawMesh(Mesh mesh, Texture texture, Texture normalMap = null, Nullable<Transform2D> transform = null, Nullable<Color> modulate = null)
        {
            Transform2D transform_in = transform.HasValue ? transform.Value : Transform2D.Identity;
            Color modulate_in = modulate.HasValue ? modulate.Value : new Color(1, 1, 1, 1);
            NativeCalls.godot_icall_5_276(method_bind_36, Object.GetPtr(this), Object.GetPtr(mesh), Object.GetPtr(texture), Object.GetPtr(normalMap), ref transform_in, ref modulate_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_multimesh");

        /// <summary>
        /// <para>Draws a <see cref="Godot.MultiMesh"/> in 2D with the provided texture. See <see cref="Godot.MultiMeshInstance2D"/> for related documentation.</para>
        /// </summary>
        [GodotMethod("draw_multimesh")]
        public void DrawMultimesh(MultiMesh multimesh, Texture texture, Texture normalMap = null)
        {
            NativeCalls.godot_icall_3_277(method_bind_37, Object.GetPtr(this), Object.GetPtr(multimesh), Object.GetPtr(texture), Object.GetPtr(normalMap));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_set_transform");

        /// <summary>
        /// <para>Sets a custom transform for drawing via components. Anything drawn afterwards will be transformed by this.</para>
        /// </summary>
        [GodotMethod("draw_set_transform")]
        public void DrawSetTransform(Vector2 position, float rotation, Vector2 scale)
        {
            NativeCalls.godot_icall_3_278(method_bind_38, Object.GetPtr(this), ref position, rotation, ref scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw_set_transform_matrix");

        /// <summary>
        /// <para>Sets a custom transform for drawing via matrix. Anything drawn afterwards will be transformed by this.</para>
        /// </summary>
        [GodotMethod("draw_set_transform_matrix")]
        public void DrawSetTransformMatrix(Transform2D xform)
        {
            NativeCalls.godot_icall_1_220(method_bind_39, Object.GetPtr(this), ref xform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_transform");

        /// <summary>
        /// <para>Returns the transform matrix of this item.</para>
        /// </summary>
        [GodotMethod("get_transform")]
        public Transform2D GetTransform()
        {
            NativeCalls.godot_icall_0_221(method_bind_40, Object.GetPtr(this), out Transform2D argRet); return (Transform2D)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_global_transform");

        /// <summary>
        /// <para>Returns the global transform matrix of this item.</para>
        /// </summary>
        [GodotMethod("get_global_transform")]
        public Transform2D GetGlobalTransform()
        {
            NativeCalls.godot_icall_0_221(method_bind_41, Object.GetPtr(this), out Transform2D argRet); return (Transform2D)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_global_transform_with_canvas");

        /// <summary>
        /// <para>Returns the global transform matrix of this item in relation to the canvas.</para>
        /// </summary>
        [GodotMethod("get_global_transform_with_canvas")]
        public Transform2D GetGlobalTransformWithCanvas()
        {
            NativeCalls.godot_icall_0_221(method_bind_42, Object.GetPtr(this), out Transform2D argRet); return (Transform2D)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_viewport_transform");

        /// <summary>
        /// <para>Returns this item's transform in relation to the viewport.</para>
        /// </summary>
        [GodotMethod("get_viewport_transform")]
        public Transform2D GetViewportTransform()
        {
            NativeCalls.godot_icall_0_221(method_bind_43, Object.GetPtr(this), out Transform2D argRet); return (Transform2D)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_viewport_rect");

        /// <summary>
        /// <para>Returns the viewport's boundaries as a <see cref="Godot.Rect2"/>.</para>
        /// </summary>
        [GodotMethod("get_viewport_rect")]
        public Rect2 GetViewportRect()
        {
            NativeCalls.godot_icall_0_163(method_bind_44, Object.GetPtr(this), out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_canvas_transform");

        /// <summary>
        /// <para>Returns the transform matrix of this item's canvas.</para>
        /// </summary>
        [GodotMethod("get_canvas_transform")]
        public Transform2D GetCanvasTransform()
        {
            NativeCalls.godot_icall_0_221(method_bind_45, Object.GetPtr(this), out Transform2D argRet); return (Transform2D)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_local_mouse_position");

        /// <summary>
        /// <para>Returns the mouse's position in this <see cref="Godot.CanvasItem"/> using the local coordinate system of this <see cref="Godot.CanvasItem"/>.</para>
        /// </summary>
        [GodotMethod("get_local_mouse_position")]
        public Vector2 GetLocalMousePosition()
        {
            NativeCalls.godot_icall_0_18(method_bind_46, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_global_mouse_position");

        /// <summary>
        /// <para>Returns the mouse's position in the <see cref="Godot.CanvasLayer"/> that this <see cref="Godot.CanvasItem"/> is in using the coordinate system of the <see cref="Godot.CanvasLayer"/>.</para>
        /// </summary>
        [GodotMethod("get_global_mouse_position")]
        public Vector2 GetGlobalMousePosition()
        {
            NativeCalls.godot_icall_0_18(method_bind_47, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_canvas");

        /// <summary>
        /// <para>Returns the <see cref="Godot.RID"/> of the <see cref="Godot.World2D"/> canvas where this item is in.</para>
        /// </summary>
        [GodotMethod("get_canvas")]
        public RID GetCanvas()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_48, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_world_2d");

        /// <summary>
        /// <para>Returns the <see cref="Godot.World2D"/> where this item is in.</para>
        /// </summary>
        [GodotMethod("get_world_2d")]
        public World2D GetWorld2d()
        {
            return NativeCalls.godot_icall_0_279(method_bind_49, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_material");

        [GodotMethod("set_material")]
        [Obsolete("SetMaterial is deprecated. Use the Material property instead.")]
        public void SetMaterial(Material material)
        {
            NativeCalls.godot_icall_1_24(method_bind_50, Object.GetPtr(this), Object.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_material");

        [GodotMethod("get_material")]
        [Obsolete("GetMaterial is deprecated. Use the Material property instead.")]
        public Material GetMaterial()
        {
            return NativeCalls.godot_icall_0_237(method_bind_51, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_parent_material");

        [GodotMethod("set_use_parent_material")]
        [Obsolete("SetUseParentMaterial is deprecated. Use the UseParentMaterial property instead.")]
        public void SetUseParentMaterial(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_52, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_53 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_use_parent_material");

        [GodotMethod("get_use_parent_material")]
        [Obsolete("GetUseParentMaterial is deprecated. Use the UseParentMaterial property instead.")]
        public bool GetUseParentMaterial()
        {
            return NativeCalls.godot_icall_0_7(method_bind_53, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_54 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_notify_local_transform");

        /// <summary>
        /// <para>If <c>enable</c> is <c>true</c>, this node will receive <see cref="Godot.CanvasItem.NotificationLocalTransformChanged"/> when its local transform changes.</para>
        /// </summary>
        [GodotMethod("set_notify_local_transform")]
        public void SetNotifyLocalTransform(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_54, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_55 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_local_transform_notification_enabled");

        /// <summary>
        /// <para>Returns <c>true</c> if local transform notifications are communicated to children.</para>
        /// </summary>
        [GodotMethod("is_local_transform_notification_enabled")]
        public bool IsLocalTransformNotificationEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_55, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_56 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_notify_transform");

        /// <summary>
        /// <para>If <c>enable</c> is <c>true</c>, this node will receive <see cref="Godot.CanvasItem.NotificationTransformChanged"/> when its global transform changes.</para>
        /// </summary>
        [GodotMethod("set_notify_transform")]
        public void SetNotifyTransform(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_56, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_57 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_transform_notification_enabled");

        /// <summary>
        /// <para>Returns <c>true</c> if global transform notifications are communicated to children.</para>
        /// </summary>
        [GodotMethod("is_transform_notification_enabled")]
        public bool IsTransformNotificationEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_57, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_58 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "force_update_transform");

        /// <summary>
        /// <para>Forces the transform to update. Transform changes in physics are not instant for performance reasons. Transforms are accumulated and then set. Use this if you need an up-to-date transform when doing physics operations.</para>
        /// </summary>
        [GodotMethod("force_update_transform")]
        public void ForceUpdateTransform()
        {
            NativeCalls.godot_icall_0_3(method_bind_58, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_59 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "make_canvas_position_local");

        /// <summary>
        /// <para>Assigns <c>screen_point</c> as this node's new local transform.</para>
        /// </summary>
        [GodotMethod("make_canvas_position_local")]
        public Vector2 MakeCanvasPositionLocal(Vector2 screenPoint)
        {
            NativeCalls.godot_icall_1_47(method_bind_59, Object.GetPtr(this), ref screenPoint, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_60 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "make_input_local");

        /// <summary>
        /// <para>Transformations issued by <c>event</c>'s inputs are applied in local space instead of global space.</para>
        /// </summary>
        [GodotMethod("make_input_local")]
        public InputEvent MakeInputLocal(InputEvent @event)
        {
            return NativeCalls.godot_icall_1_280(method_bind_60, Object.GetPtr(this), Object.GetPtr(@event));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
