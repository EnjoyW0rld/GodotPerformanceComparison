using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Canvas drawing layer. <see cref="Godot.CanvasItem"/> nodes that are direct or indirect children of a <see cref="Godot.CanvasLayer"/> will be drawn in that layer. The layer is a numeric index that defines the draw order. The default 2D scene renders with index 0, so a <see cref="Godot.CanvasLayer"/> with index -1 will be drawn below, and one with index 1 will be drawn above. This is very useful for HUDs (in layer 1+ or above), or backgrounds (in layer -1 or below).</para>
    /// </summary>
    public partial class CanvasLayer : Node
    {
        /// <summary>
        /// <para>Layer index for draw order. Lower values are drawn first.</para>
        /// </summary>
        public int Layer
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLayer();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLayer(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>false</c>, any <see cref="Godot.CanvasItem"/> under this <see cref="Godot.CanvasLayer"/> will be hidden.</para>
        /// <para>Unlike <see cref="Godot.CanvasItem.Visible"/>, visibility of a <see cref="Godot.CanvasLayer"/> isn't propagated to underlying layers.</para>
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
        /// <para>The layer's base offset.</para>
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
        /// <para>The layer's rotation in degrees.</para>
        /// </summary>
        public float RotationDegrees
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRotationDegrees();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRotationDegrees(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The layer's rotation in radians.</para>
        /// </summary>
        public float Rotation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRotation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRotation(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The layer's scale.</para>
        /// </summary>
        public Vector2 Scale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetScale(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The layer's transform.</para>
        /// </summary>
        public Transform2D Transform
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTransform();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTransform(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The custom <see cref="Godot.Viewport"/> node assigned to the <see cref="Godot.CanvasLayer"/>. If <c>null</c>, uses the default viewport instead.</para>
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
        /// <para>If enabled, the <see cref="Godot.CanvasLayer"/> will use the viewport's transform, so it will move when camera moves instead of being anchored in a fixed position on the screen.</para>
        /// <para>Together with <see cref="Godot.CanvasLayer.FollowViewportScale"/> it can be used for a pseudo 3D effect.</para>
        /// </summary>
        public bool FollowViewportEnable
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsFollowingViewport();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFollowViewport(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Scales the layer when using <see cref="Godot.CanvasLayer.FollowViewportEnable"/>. Layers moving into the foreground should have increasing scales, while layers moving into the background should have decreasing scales.</para>
        /// </summary>
        public float FollowViewportScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFollowViewportScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFollowViewportScale(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "CanvasLayer";

        public CanvasLayer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CanvasLayer_Ctor(this);
        }

        internal CanvasLayer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_layer");

        [GodotMethod("set_layer")]
        [Obsolete("SetLayer is deprecated. Use the Layer property instead.")]
        public void SetLayer(int layer)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), layer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_layer");

        [GodotMethod("get_layer")]
        [Obsolete("GetLayer is deprecated. Use the Layer property instead.")]
        public int GetLayer()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_visible");

        [GodotMethod("set_visible")]
        [Obsolete("SetVisible is deprecated. Use the Visible property instead.")]
        public void SetVisible(bool visible)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), visible);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_visible");

        [GodotMethod("is_visible")]
        [Obsolete("IsVisible is deprecated. Use the Visible property instead.")]
        public bool IsVisible()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "show");

        /// <summary>
        /// <para>Shows any <see cref="Godot.CanvasItem"/> under this <see cref="Godot.CanvasLayer"/>. This is equivalent to setting <see cref="Godot.CanvasLayer.Visible"/> to <c>true</c>.</para>
        /// </summary>
        [GodotMethod("show")]
        public void Show()
        {
            NativeCalls.godot_icall_0_3(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "hide");

        /// <summary>
        /// <para>Hides any <see cref="Godot.CanvasItem"/> under this <see cref="Godot.CanvasLayer"/>. This is equivalent to setting <see cref="Godot.CanvasLayer.Visible"/> to <c>false</c>.</para>
        /// </summary>
        [GodotMethod("hide")]
        public void Hide()
        {
            NativeCalls.godot_icall_0_3(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_transform");

        [GodotMethod("set_transform")]
        [Obsolete("SetTransform is deprecated. Use the Transform property instead.")]
        public void SetTransform(Transform2D transform)
        {
            NativeCalls.godot_icall_1_220(method_bind_6, Object.GetPtr(this), ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_transform");

        [GodotMethod("get_transform")]
        [Obsolete("GetTransform is deprecated. Use the Transform property instead.")]
        public Transform2D GetTransform()
        {
            NativeCalls.godot_icall_0_221(method_bind_7, Object.GetPtr(this), out Transform2D argRet); return (Transform2D)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_offset");

        [GodotMethod("set_offset")]
        [Obsolete("SetOffset is deprecated. Use the Offset property instead.")]
        public void SetOffset(Vector2 offset)
        {
            NativeCalls.godot_icall_1_57(method_bind_8, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_offset");

        [GodotMethod("get_offset")]
        [Obsolete("GetOffset is deprecated. Use the Offset property instead.")]
        public Vector2 GetOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_9, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rotation");

        [GodotMethod("set_rotation")]
        [Obsolete("SetRotation is deprecated. Use the Rotation property instead.")]
        public void SetRotation(float radians)
        {
            NativeCalls.godot_icall_1_15(method_bind_10, Object.GetPtr(this), radians);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rotation");

        [GodotMethod("get_rotation")]
        [Obsolete("GetRotation is deprecated. Use the Rotation property instead.")]
        public float GetRotation()
        {
            return NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rotation_degrees");

        [GodotMethod("set_rotation_degrees")]
        [Obsolete("SetRotationDegrees is deprecated. Use the RotationDegrees property instead.")]
        public void SetRotationDegrees(float degrees)
        {
            NativeCalls.godot_icall_1_15(method_bind_12, Object.GetPtr(this), degrees);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rotation_degrees");

        [GodotMethod("get_rotation_degrees")]
        [Obsolete("GetRotationDegrees is deprecated. Use the RotationDegrees property instead.")]
        public float GetRotationDegrees()
        {
            return NativeCalls.godot_icall_0_14(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_scale");

        [GodotMethod("set_scale")]
        [Obsolete("SetScale is deprecated. Use the Scale property instead.")]
        public void SetScale(Vector2 scale)
        {
            NativeCalls.godot_icall_1_57(method_bind_14, Object.GetPtr(this), ref scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_scale");

        [GodotMethod("get_scale")]
        [Obsolete("GetScale is deprecated. Use the Scale property instead.")]
        public Vector2 GetScale()
        {
            NativeCalls.godot_icall_0_18(method_bind_15, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_follow_viewport");

        [GodotMethod("set_follow_viewport")]
        [Obsolete("SetFollowViewport is deprecated. Use the FollowViewportEnable property instead.")]
        public void SetFollowViewport(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_16, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_following_viewport");

        [GodotMethod("is_following_viewport")]
        [Obsolete("IsFollowingViewport is deprecated. Use the FollowViewportEnable property instead.")]
        public bool IsFollowingViewport()
        {
            return NativeCalls.godot_icall_0_7(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_follow_viewport_scale");

        [GodotMethod("set_follow_viewport_scale")]
        [Obsolete("SetFollowViewportScale is deprecated. Use the FollowViewportScale property instead.")]
        public void SetFollowViewportScale(float scale)
        {
            NativeCalls.godot_icall_1_15(method_bind_18, Object.GetPtr(this), scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_follow_viewport_scale");

        [GodotMethod("get_follow_viewport_scale")]
        [Obsolete("GetFollowViewportScale is deprecated. Use the FollowViewportScale property instead.")]
        public float GetFollowViewportScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_custom_viewport");

        [GodotMethod("set_custom_viewport")]
        [Obsolete("SetCustomViewport is deprecated. Use the CustomViewport property instead.")]
        public void SetCustomViewport(Node viewport)
        {
            NativeCalls.godot_icall_1_53(method_bind_20, Object.GetPtr(this), Object.GetPtr(viewport));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_custom_viewport");

        [GodotMethod("get_custom_viewport")]
        [Obsolete("GetCustomViewport is deprecated. Use the CustomViewport property instead.")]
        public Node GetCustomViewport()
        {
            return NativeCalls.godot_icall_0_257(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_canvas");

        /// <summary>
        /// <para>Returns the RID of the canvas used by this layer.</para>
        /// </summary>
        [GodotMethod("get_canvas")]
        public RID GetCanvas()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_22, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
