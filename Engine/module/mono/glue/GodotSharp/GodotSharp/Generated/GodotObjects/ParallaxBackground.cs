using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A ParallaxBackground uses one or more <see cref="Godot.ParallaxLayer"/> child nodes to create a parallax effect. Each <see cref="Godot.ParallaxLayer"/> can move at a different speed using <see cref="Godot.ParallaxLayer.MotionOffset"/>. This creates an illusion of depth in a 2D game. If not used with a <see cref="Godot.Camera2D"/>, you must manually calculate the <see cref="Godot.ParallaxBackground.ScrollOffset"/>.</para>
    /// </summary>
    public partial class ParallaxBackground : CanvasLayer
    {
        /// <summary>
        /// <para>The ParallaxBackground's scroll value. Calculated automatically when using a <see cref="Godot.Camera2D"/>, but can be used to manually manage scrolling when no camera is present.</para>
        /// </summary>
        public Vector2 ScrollOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetScrollOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetScrollOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The base position offset for all <see cref="Godot.ParallaxLayer"/> children.</para>
        /// </summary>
        public Vector2 ScrollBaseOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetScrollBaseOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetScrollBaseOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The base motion scale for all <see cref="Godot.ParallaxLayer"/> children.</para>
        /// </summary>
        public Vector2 ScrollBaseScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetScrollBaseScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetScrollBaseScale(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Top-left limits for scrolling to begin. If the camera is outside of this limit, the background will stop scrolling. Must be lower than <see cref="Godot.ParallaxBackground.ScrollLimitEnd"/> to work.</para>
        /// </summary>
        public Vector2 ScrollLimitBegin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLimitBegin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLimitBegin(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Bottom-right limits for scrolling to end. If the camera is outside of this limit, the background will stop scrolling. Must be higher than <see cref="Godot.ParallaxBackground.ScrollLimitBegin"/> to work.</para>
        /// </summary>
        public Vector2 ScrollLimitEnd
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLimitEnd();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLimitEnd(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, elements in <see cref="Godot.ParallaxLayer"/> child aren't affected by the zoom level of the camera.</para>
        /// </summary>
        public bool ScrollIgnoreCameraZoom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsIgnoreCameraZoom();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetIgnoreCameraZoom(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ParallaxBackground";

        public ParallaxBackground() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ParallaxBackground_Ctor(this);
        }

        internal ParallaxBackground(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_scroll_offset");

        [GodotMethod("set_scroll_offset")]
        [Obsolete("SetScrollOffset is deprecated. Use the ScrollOffset property instead.")]
        public void SetScrollOffset(Vector2 ofs)
        {
            NativeCalls.godot_icall_1_57(method_bind_0, Object.GetPtr(this), ref ofs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_scroll_offset");

        [GodotMethod("get_scroll_offset")]
        [Obsolete("GetScrollOffset is deprecated. Use the ScrollOffset property instead.")]
        public Vector2 GetScrollOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_1, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_scroll_base_offset");

        [GodotMethod("set_scroll_base_offset")]
        [Obsolete("SetScrollBaseOffset is deprecated. Use the ScrollBaseOffset property instead.")]
        public void SetScrollBaseOffset(Vector2 ofs)
        {
            NativeCalls.godot_icall_1_57(method_bind_2, Object.GetPtr(this), ref ofs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_scroll_base_offset");

        [GodotMethod("get_scroll_base_offset")]
        [Obsolete("GetScrollBaseOffset is deprecated. Use the ScrollBaseOffset property instead.")]
        public Vector2 GetScrollBaseOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_3, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_scroll_base_scale");

        [GodotMethod("set_scroll_base_scale")]
        [Obsolete("SetScrollBaseScale is deprecated. Use the ScrollBaseScale property instead.")]
        public void SetScrollBaseScale(Vector2 scale)
        {
            NativeCalls.godot_icall_1_57(method_bind_4, Object.GetPtr(this), ref scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_scroll_base_scale");

        [GodotMethod("get_scroll_base_scale")]
        [Obsolete("GetScrollBaseScale is deprecated. Use the ScrollBaseScale property instead.")]
        public Vector2 GetScrollBaseScale()
        {
            NativeCalls.godot_icall_0_18(method_bind_5, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_limit_begin");

        [GodotMethod("set_limit_begin")]
        [Obsolete("SetLimitBegin is deprecated. Use the ScrollLimitBegin property instead.")]
        public void SetLimitBegin(Vector2 ofs)
        {
            NativeCalls.godot_icall_1_57(method_bind_6, Object.GetPtr(this), ref ofs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_limit_begin");

        [GodotMethod("get_limit_begin")]
        [Obsolete("GetLimitBegin is deprecated. Use the ScrollLimitBegin property instead.")]
        public Vector2 GetLimitBegin()
        {
            NativeCalls.godot_icall_0_18(method_bind_7, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_limit_end");

        [GodotMethod("set_limit_end")]
        [Obsolete("SetLimitEnd is deprecated. Use the ScrollLimitEnd property instead.")]
        public void SetLimitEnd(Vector2 ofs)
        {
            NativeCalls.godot_icall_1_57(method_bind_8, Object.GetPtr(this), ref ofs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_limit_end");

        [GodotMethod("get_limit_end")]
        [Obsolete("GetLimitEnd is deprecated. Use the ScrollLimitEnd property instead.")]
        public Vector2 GetLimitEnd()
        {
            NativeCalls.godot_icall_0_18(method_bind_9, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ignore_camera_zoom");

        [GodotMethod("set_ignore_camera_zoom")]
        [Obsolete("SetIgnoreCameraZoom is deprecated. Use the ScrollIgnoreCameraZoom property instead.")]
        public void SetIgnoreCameraZoom(bool ignore)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), ignore);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_ignore_camera_zoom");

        [GodotMethod("is_ignore_camera_zoom")]
        [Obsolete("IsIgnoreCameraZoom is deprecated. Use the ScrollIgnoreCameraZoom property instead.")]
        public bool IsIgnoreCameraZoom()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
