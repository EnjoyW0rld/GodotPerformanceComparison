using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Camera node for 2D scenes. It forces the screen (current layer) to scroll following this node. This makes it easier (and faster) to program scrollable scenes than manually changing the position of <see cref="Godot.CanvasItem"/>-based nodes.</para>
    /// <para>This node is intended to be a simple helper to get things going quickly, but more functionality may be desired to change how the camera works. To make your own custom camera node, inherit it from <see cref="Godot.Node2D"/> and change the transform of the canvas by setting <see cref="Godot.Viewport.CanvasTransform"/> in <see cref="Godot.Viewport"/> (you can obtain the current <see cref="Godot.Viewport"/> by using <see cref="Godot.Node.GetViewport"/>).</para>
    /// <para>Note that the <see cref="Godot.Camera2D"/> node's <c>position</c> doesn't represent the actual position of the screen, which may differ due to applied smoothing or limits. You can use <see cref="Godot.Camera2D.GetCameraScreenCenter"/> to get the real position.</para>
    /// </summary>
    public partial class Camera2D : Node2D
    {
        public enum Camera2DProcessMode
        {
            /// <summary>
            /// <para>The camera updates with the <c>_physics_process</c> callback.</para>
            /// </summary>
            Physics = 0,
            /// <summary>
            /// <para>The camera updates with the <c>_process</c> callback.</para>
            /// </summary>
            Idle = 1
        }

        public enum AnchorModeEnum
        {
            /// <summary>
            /// <para>The camera's position is fixed so that the top-left corner is always at the origin.</para>
            /// </summary>
            FixedTopLeft = 0,
            /// <summary>
            /// <para>The camera's position takes into account vertical/horizontal offsets and the screen size.</para>
            /// </summary>
            DragCenter = 1
        }

        /// <summary>
        /// <para>The camera's offset, useful for looking around or camera shake animations.</para>
        /// </summary>
        public Vector2 Offset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The Camera2D's anchor point. See <see cref="Godot.Camera2D.AnchorModeEnum"/> constants.</para>
        /// </summary>
        public Camera2D.AnchorModeEnum AnchorMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAnchorMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAnchorMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the camera view rotates with the target.</para>
        /// </summary>
        public bool Rotating
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsRotating();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRotating(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the camera is the active camera for the current scene. Only one camera can be current, so setting a different camera <c>current</c> will disable this one.</para>
        /// </summary>
        public bool Current
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsCurrent();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetCurrent(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The camera's zoom relative to the viewport. Values larger than <c>Vector2(1, 1)</c> zoom out and smaller values zoom in. For an example, use <c>Vector2(0.5, 0.5)</c> for a 2× zoom-in, and <c>Vector2(4, 4)</c> for a 4× zoom-out.</para>
        /// </summary>
        public Vector2 Zoom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetZoom();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetZoom(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The custom <see cref="Godot.Viewport"/> node attached to the <see cref="Godot.Camera2D"/>. If <c>null</c> or not a <see cref="Godot.Viewport"/>, uses the default viewport instead.</para>
        /// </summary>
        public Node CustomViewport
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCustomViewport();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCustomViewport(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The camera's process callback. See <see cref="Godot.Camera2D.Camera2DProcessMode"/>.</para>
        /// </summary>
        public Camera2D.Camera2DProcessMode ProcessMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetProcessMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetProcessMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Left scroll limit in pixels. The camera stops moving when reaching this value.</para>
        /// </summary>
        public int LimitLeft
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLimit((Margin)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLimit((Margin)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Top scroll limit in pixels. The camera stops moving when reaching this value.</para>
        /// </summary>
        public int LimitTop
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLimit((Margin)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLimit((Margin)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Right scroll limit in pixels. The camera stops moving when reaching this value.</para>
        /// </summary>
        public int LimitRight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLimit((Margin)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLimit((Margin)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Bottom scroll limit in pixels. The camera stops moving when reaching this value.</para>
        /// </summary>
        public int LimitBottom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLimit((Margin)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLimit((Margin)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the camera smoothly stops when reaches its limits.</para>
        /// <para>This property has no effect if <see cref="Godot.Camera2D.SmoothingEnabled"/> is <c>false</c>.</para>
        /// <para>Note: To immediately update the camera's position to be within limits without smoothing, even with this setting enabled, invoke <see cref="Godot.Camera2D.ResetSmoothing"/>.</para>
        /// </summary>
        public bool LimitSmoothed
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsLimitSmoothingEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLimitSmoothingEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the camera only moves when reaching the horizontal drag margins. If <c>false</c>, the camera moves horizontally regardless of margins.</para>
        /// </summary>
        public bool DragMarginHEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsHDragEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHDragEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the camera only moves when reaching the vertical drag margins. If <c>false</c>, the camera moves vertically regardless of margins.</para>
        /// </summary>
        public bool DragMarginVEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsVDragEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVDragEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the camera smoothly moves towards the target at <see cref="Godot.Camera2D.SmoothingSpeed"/>.</para>
        /// </summary>
        public bool SmoothingEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsFollowSmoothingEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnableFollowSmoothing(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Speed in pixels per second of the camera's smoothing effect when <see cref="Godot.Camera2D.SmoothingEnabled"/> is <c>true</c>.</para>
        /// </summary>
        public float SmoothingSpeed
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFollowSmoothing();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFollowSmoothing(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The horizontal offset of the camera, relative to the drag margins.</para>
        /// <para>Note: Offset H is used only to force offset relative to margins. It's not updated in any way if drag margins are enabled and can be used to set initial offset.</para>
        /// </summary>
        public float OffsetH
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The vertical offset of the camera, relative to the drag margins.</para>
        /// <para>Note: Used the same as <see cref="Godot.Camera2D.OffsetH"/>.</para>
        /// </summary>
        public float OffsetV
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Left margin needed to drag the camera. A value of <c>1</c> makes the camera move only when reaching the edge of the screen.</para>
        /// </summary>
        public float DragMarginLeft
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDragMargin((Margin)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDragMargin((Margin)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Top margin needed to drag the camera. A value of <c>1</c> makes the camera move only when reaching the edge of the screen.</para>
        /// </summary>
        public float DragMarginTop
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDragMargin((Margin)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDragMargin((Margin)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Right margin needed to drag the camera. A value of <c>1</c> makes the camera move only when reaching the edge of the screen.</para>
        /// </summary>
        public float DragMarginRight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDragMargin((Margin)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDragMargin((Margin)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Bottom margin needed to drag the camera. A value of <c>1</c> makes the camera move only when reaching the edge of the screen.</para>
        /// </summary>
        public float DragMarginBottom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDragMargin((Margin)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDragMargin((Margin)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, draws the camera's screen rectangle in the editor.</para>
        /// </summary>
        public bool EditorDrawScreen
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsScreenDrawingEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetScreenDrawingEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, draws the camera's limits rectangle in the editor.</para>
        /// </summary>
        public bool EditorDrawLimits
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsLimitDrawingEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLimitDrawingEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, draws the camera's drag margin rectangle in the editor.</para>
        /// </summary>
        public bool EditorDrawDragMargin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsMarginDrawingEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMarginDrawingEnabled(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Camera2D";

        public Camera2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Camera2D_Ctor(this);
        }

        internal Camera2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_offset");

        [GodotMethod("set_offset")]
        [Obsolete("SetOffset is deprecated. Use the Offset property instead.")]
        public void SetOffset(Vector2 offset)
        {
            NativeCalls.godot_icall_1_57(method_bind_0, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_offset");

        [GodotMethod("get_offset")]
        [Obsolete("GetOffset is deprecated. Use the Offset property instead.")]
        public Vector2 GetOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_1, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_anchor_mode");

        [GodotMethod("set_anchor_mode")]
        [Obsolete("SetAnchorMode is deprecated. Use the AnchorMode property instead.")]
        public void SetAnchorMode(Camera2D.AnchorModeEnum anchorMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)anchorMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_anchor_mode");

        [GodotMethod("get_anchor_mode")]
        [Obsolete("GetAnchorMode is deprecated. Use the AnchorMode property instead.")]
        public Camera2D.AnchorModeEnum GetAnchorMode()
        {
            return (Camera2D.AnchorModeEnum)NativeCalls.godot_icall_0_255(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rotating");

        [GodotMethod("set_rotating")]
        [Obsolete("SetRotating is deprecated. Use the Rotating property instead.")]
        public void SetRotating(bool rotating)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), rotating);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_rotating");

        [GodotMethod("is_rotating")]
        [Obsolete("IsRotating is deprecated. Use the Rotating property instead.")]
        public bool IsRotating()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "make_current");

        /// <summary>
        /// <para>Make this the current 2D camera for the scene (viewport and layer), in case there are many cameras in the scene.</para>
        /// </summary>
        [GodotMethod("make_current")]
        public void MakeCurrent()
        {
            NativeCalls.godot_icall_0_3(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_current");

        /// <summary>
        /// <para>Removes any <see cref="Godot.Camera2D"/> from the ancestor <see cref="Godot.Viewport"/>'s internal currently-assigned camera.</para>
        /// </summary>
        [GodotMethod("clear_current")]
        public void ClearCurrent()
        {
            NativeCalls.godot_icall_0_3(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_process_mode");

        [GodotMethod("set_process_mode")]
        [Obsolete("SetProcessMode is deprecated. Use the ProcessMode property instead.")]
        public void SetProcessMode(Camera2D.Camera2DProcessMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_8, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_process_mode");

        [GodotMethod("get_process_mode")]
        [Obsolete("GetProcessMode is deprecated. Use the ProcessMode property instead.")]
        public Camera2D.Camera2DProcessMode GetProcessMode()
        {
            return (Camera2D.Camera2DProcessMode)NativeCalls.godot_icall_0_256(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_current");

        [Obsolete("_SetCurrent is deprecated. Use the Current property instead.")]
        internal void _SetCurrent(bool current)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), current);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_current");

        [GodotMethod("is_current")]
        [Obsolete("IsCurrent is deprecated. Use the Current property instead.")]
        public bool IsCurrent()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_limit");

        /// <summary>
        /// <para>Sets the specified camera limit. See also <see cref="Godot.Camera2D.LimitBottom"/>, <see cref="Godot.Camera2D.LimitTop"/>, <see cref="Godot.Camera2D.LimitLeft"/>, and <see cref="Godot.Camera2D.LimitRight"/>.</para>
        /// </summary>
        [GodotMethod("set_limit")]
        [Obsolete("SetLimit is deprecated. Use the LimitBottom property instead.")]
        public void SetLimit(Margin margin, int limit)
        {
            NativeCalls.godot_icall_2_65(method_bind_12, Object.GetPtr(this), (int)margin, limit);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_limit");

        /// <summary>
        /// <para>Returns the specified camera limit. See also <see cref="Godot.Camera2D.LimitBottom"/>, <see cref="Godot.Camera2D.LimitTop"/>, <see cref="Godot.Camera2D.LimitLeft"/>, and <see cref="Godot.Camera2D.LimitRight"/>.</para>
        /// </summary>
        [GodotMethod("get_limit")]
        [Obsolete("GetLimit is deprecated. Use the LimitBottom property instead.")]
        public int GetLimit(Margin margin)
        {
            return NativeCalls.godot_icall_1_11(method_bind_13, Object.GetPtr(this), (int)margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_limit_smoothing_enabled");

        [GodotMethod("set_limit_smoothing_enabled")]
        [Obsolete("SetLimitSmoothingEnabled is deprecated. Use the LimitSmoothed property instead.")]
        public void SetLimitSmoothingEnabled(bool limitSmoothingEnabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_14, Object.GetPtr(this), limitSmoothingEnabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_limit_smoothing_enabled");

        [GodotMethod("is_limit_smoothing_enabled")]
        [Obsolete("IsLimitSmoothingEnabled is deprecated. Use the LimitSmoothed property instead.")]
        public bool IsLimitSmoothingEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_v_drag_enabled");

        [GodotMethod("set_v_drag_enabled")]
        [Obsolete("SetVDragEnabled is deprecated. Use the DragMarginVEnabled property instead.")]
        public void SetVDragEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_16, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_v_drag_enabled");

        [GodotMethod("is_v_drag_enabled")]
        [Obsolete("IsVDragEnabled is deprecated. Use the DragMarginVEnabled property instead.")]
        public bool IsVDragEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_h_drag_enabled");

        [GodotMethod("set_h_drag_enabled")]
        [Obsolete("SetHDragEnabled is deprecated. Use the DragMarginHEnabled property instead.")]
        public void SetHDragEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_18, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_h_drag_enabled");

        [GodotMethod("is_h_drag_enabled")]
        [Obsolete("IsHDragEnabled is deprecated. Use the DragMarginHEnabled property instead.")]
        public bool IsHDragEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_v_offset");

        [GodotMethod("set_v_offset")]
        [Obsolete("SetVOffset is deprecated. Use the OffsetV property instead.")]
        public void SetVOffset(float ofs)
        {
            NativeCalls.godot_icall_1_15(method_bind_20, Object.GetPtr(this), ofs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_v_offset");

        [GodotMethod("get_v_offset")]
        [Obsolete("GetVOffset is deprecated. Use the OffsetV property instead.")]
        public float GetVOffset()
        {
            return NativeCalls.godot_icall_0_14(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_h_offset");

        [GodotMethod("set_h_offset")]
        [Obsolete("SetHOffset is deprecated. Use the OffsetH property instead.")]
        public void SetHOffset(float ofs)
        {
            NativeCalls.godot_icall_1_15(method_bind_22, Object.GetPtr(this), ofs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_h_offset");

        [GodotMethod("get_h_offset")]
        [Obsolete("GetHOffset is deprecated. Use the OffsetH property instead.")]
        public float GetHOffset()
        {
            return NativeCalls.godot_icall_0_14(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_drag_margin");

        /// <summary>
        /// <para>Sets the specified margin. See also <see cref="Godot.Camera2D.DragMarginBottom"/>, <see cref="Godot.Camera2D.DragMarginTop"/>, <see cref="Godot.Camera2D.DragMarginLeft"/>, and <see cref="Godot.Camera2D.DragMarginRight"/>.</para>
        /// </summary>
        [GodotMethod("set_drag_margin")]
        [Obsolete("SetDragMargin is deprecated. Use the DragMarginBottom property instead.")]
        public void SetDragMargin(Margin margin, float dragMargin)
        {
            NativeCalls.godot_icall_2_34(method_bind_24, Object.GetPtr(this), (int)margin, dragMargin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_drag_margin");

        /// <summary>
        /// <para>Returns the specified margin. See also <see cref="Godot.Camera2D.DragMarginBottom"/>, <see cref="Godot.Camera2D.DragMarginTop"/>, <see cref="Godot.Camera2D.DragMarginLeft"/>, and <see cref="Godot.Camera2D.DragMarginRight"/>.</para>
        /// </summary>
        [GodotMethod("get_drag_margin")]
        [Obsolete("GetDragMargin is deprecated. Use the DragMarginBottom property instead.")]
        public float GetDragMargin(Margin margin)
        {
            return NativeCalls.godot_icall_1_12(method_bind_25, Object.GetPtr(this), (int)margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_camera_position");

        /// <summary>
        /// <para>Returns the camera's <c>position</c> (the tracked point the camera attempts to follow), relative to the origin.</para>
        /// <para>Note: The returned value is not the same as <see cref="Godot.Node2D.Position"/> or <see cref="Godot.Node2D.GlobalPosition"/>, as it is affected by the <c>drag</c> properties.</para>
        /// </summary>
        [GodotMethod("get_camera_position")]
        public Vector2 GetCameraPosition()
        {
            NativeCalls.godot_icall_0_18(method_bind_26, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_camera_screen_center");

        /// <summary>
        /// <para>Returns the location of the <see cref="Godot.Camera2D"/>'s screen-center, relative to the origin.</para>
        /// <para>Note: The real <c>position</c> of the camera may be different, see <see cref="Godot.Camera2D.GetCameraPosition"/>.</para>
        /// </summary>
        [GodotMethod("get_camera_screen_center")]
        public Vector2 GetCameraScreenCenter()
        {
            NativeCalls.godot_icall_0_18(method_bind_27, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_zoom");

        [GodotMethod("set_zoom")]
        [Obsolete("SetZoom is deprecated. Use the Zoom property instead.")]
        public void SetZoom(Vector2 zoom)
        {
            NativeCalls.godot_icall_1_57(method_bind_28, Object.GetPtr(this), ref zoom);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_zoom");

        [GodotMethod("get_zoom")]
        [Obsolete("GetZoom is deprecated. Use the Zoom property instead.")]
        public Vector2 GetZoom()
        {
            NativeCalls.godot_icall_0_18(method_bind_29, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_custom_viewport");

        [GodotMethod("set_custom_viewport")]
        [Obsolete("SetCustomViewport is deprecated. Use the CustomViewport property instead.")]
        public void SetCustomViewport(Node viewport)
        {
            NativeCalls.godot_icall_1_53(method_bind_30, Object.GetPtr(this), Object.GetPtr(viewport));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_custom_viewport");

        [GodotMethod("get_custom_viewport")]
        [Obsolete("GetCustomViewport is deprecated. Use the CustomViewport property instead.")]
        public Node GetCustomViewport()
        {
            return NativeCalls.godot_icall_0_257(method_bind_31, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_follow_smoothing");

        [GodotMethod("set_follow_smoothing")]
        [Obsolete("SetFollowSmoothing is deprecated. Use the SmoothingSpeed property instead.")]
        public void SetFollowSmoothing(float followSmoothing)
        {
            NativeCalls.godot_icall_1_15(method_bind_32, Object.GetPtr(this), followSmoothing);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_follow_smoothing");

        [GodotMethod("get_follow_smoothing")]
        [Obsolete("GetFollowSmoothing is deprecated. Use the SmoothingSpeed property instead.")]
        public float GetFollowSmoothing()
        {
            return NativeCalls.godot_icall_0_14(method_bind_33, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_enable_follow_smoothing");

        [GodotMethod("set_enable_follow_smoothing")]
        [Obsolete("SetEnableFollowSmoothing is deprecated. Use the SmoothingEnabled property instead.")]
        public void SetEnableFollowSmoothing(bool followSmoothing)
        {
            NativeCalls.godot_icall_1_16(method_bind_34, Object.GetPtr(this), followSmoothing);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_follow_smoothing_enabled");

        [GodotMethod("is_follow_smoothing_enabled")]
        [Obsolete("IsFollowSmoothingEnabled is deprecated. Use the SmoothingEnabled property instead.")]
        public bool IsFollowSmoothingEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_35, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "force_update_scroll");

        /// <summary>
        /// <para>Forces the camera to update scroll immediately.</para>
        /// </summary>
        [GodotMethod("force_update_scroll")]
        public void ForceUpdateScroll()
        {
            NativeCalls.godot_icall_0_3(method_bind_36, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reset_smoothing");

        /// <summary>
        /// <para>Sets the camera's position immediately to its current smoothing destination.</para>
        /// <para>This method has no effect if <see cref="Godot.Camera2D.SmoothingEnabled"/> is <c>false</c>.</para>
        /// </summary>
        [GodotMethod("reset_smoothing")]
        public void ResetSmoothing()
        {
            NativeCalls.godot_icall_0_3(method_bind_37, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "align");

        /// <summary>
        /// <para>Aligns the camera to the tracked node.</para>
        /// </summary>
        [GodotMethod("align")]
        public void Align()
        {
            NativeCalls.godot_icall_0_3(method_bind_38, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_screen_drawing_enabled");

        [GodotMethod("set_screen_drawing_enabled")]
        [Obsolete("SetScreenDrawingEnabled is deprecated. Use the EditorDrawScreen property instead.")]
        public void SetScreenDrawingEnabled(bool screenDrawingEnabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_39, Object.GetPtr(this), screenDrawingEnabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_screen_drawing_enabled");

        [GodotMethod("is_screen_drawing_enabled")]
        [Obsolete("IsScreenDrawingEnabled is deprecated. Use the EditorDrawScreen property instead.")]
        public bool IsScreenDrawingEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_40, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_limit_drawing_enabled");

        [GodotMethod("set_limit_drawing_enabled")]
        [Obsolete("SetLimitDrawingEnabled is deprecated. Use the EditorDrawLimits property instead.")]
        public void SetLimitDrawingEnabled(bool limitDrawingEnabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_41, Object.GetPtr(this), limitDrawingEnabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_limit_drawing_enabled");

        [GodotMethod("is_limit_drawing_enabled")]
        [Obsolete("IsLimitDrawingEnabled is deprecated. Use the EditorDrawLimits property instead.")]
        public bool IsLimitDrawingEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_42, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_margin_drawing_enabled");

        [GodotMethod("set_margin_drawing_enabled")]
        [Obsolete("SetMarginDrawingEnabled is deprecated. Use the EditorDrawDragMargin property instead.")]
        public void SetMarginDrawingEnabled(bool marginDrawingEnabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_43, Object.GetPtr(this), marginDrawingEnabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_margin_drawing_enabled");

        [GodotMethod("is_margin_drawing_enabled")]
        [Obsolete("IsMarginDrawingEnabled is deprecated. Use the EditorDrawDragMargin property instead.")]
        public bool IsMarginDrawingEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_44, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
