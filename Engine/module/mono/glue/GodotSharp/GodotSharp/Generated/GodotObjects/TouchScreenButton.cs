using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>TouchScreenButton allows you to create on-screen buttons for touch devices. It's intended for gameplay use, such as a unit you have to touch to move. Unlike <see cref="Godot.Button"/>, TouchScreenButton supports multitouch out of the box. Several TouchScreenButtons can be pressed at the same time with touch input.</para>
    /// <para>This node inherits from <see cref="Godot.Node2D"/>. Unlike with <see cref="Godot.Control"/> nodes, you cannot set anchors on it. If you want to create menus or user interfaces, you may want to use <see cref="Godot.Button"/> nodes instead. To make button nodes react to touch events, you can enable the Emulate Mouse option in the Project Settings.</para>
    /// <para>You can configure TouchScreenButton to be visible only on touch devices, helping you develop your game both for desktop and mobile devices.</para>
    /// </summary>
    public partial class TouchScreenButton : Node2D
    {
        public enum VisibilityModeEnum
        {
            /// <summary>
            /// <para>Always visible.</para>
            /// </summary>
            Always = 0,
            /// <summary>
            /// <para>Visible on touch screens only.</para>
            /// </summary>
            TouchscreenOnly = 1
        }

        /// <summary>
        /// <para>The button's texture for the normal state.</para>
        /// </summary>
        public Texture Normal
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexture();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexture(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The button's texture for the pressed state.</para>
        /// </summary>
        public Texture Pressed
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexturePressed();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexturePressed(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The button's bitmask.</para>
        /// </summary>
        public BitMap Bitmask
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBitmask();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBitmask(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The button's shape.</para>
        /// </summary>
        public Shape2D Shape
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShape();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShape(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the button's shape is centered in the provided texture. If no texture is used, this property has no effect.</para>
        /// </summary>
        public bool ShapeCentered
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsShapeCentered();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShapeCentered(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the button's shape is visible.</para>
        /// </summary>
        public bool ShapeVisible
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsShapeVisible();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShapeVisible(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the <c>pressed</c> and <c>released</c> signals are emitted whenever a pressed finger goes in and out of the button, even if the pressure started outside the active area of the button.</para>
        /// <para>Note: This is a "pass-by" (not "bypass") press mode.</para>
        /// </summary>
        public bool PassbyPress
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsPassbyPressEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPassbyPress(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The button's action. Actions can be handled with <see cref="Godot.InputEventAction"/>.</para>
        /// </summary>
        public string Action
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAction();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAction(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The button's visibility mode. See <see cref="Godot.TouchScreenButton.VisibilityModeEnum"/> for possible values.</para>
        /// </summary>
        public TouchScreenButton.VisibilityModeEnum VisibilityMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVisibilityMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVisibilityMode(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "TouchScreenButton";

        public TouchScreenButton() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_TouchScreenButton_Ctor(this);
        }

        internal TouchScreenButton(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture");

        [GodotMethod("set_texture")]
        [Obsolete("SetTexture is deprecated. Use the Normal property instead.")]
        public void SetTexture(Texture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture");

        [GodotMethod("get_texture")]
        [Obsolete("GetTexture is deprecated. Use the Normal property instead.")]
        public Texture GetTexture()
        {
            return NativeCalls.godot_icall_0_161(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture_pressed");

        [GodotMethod("set_texture_pressed")]
        [Obsolete("SetTexturePressed is deprecated. Use the Pressed property instead.")]
        public void SetTexturePressed(Texture texturePressed)
        {
            NativeCalls.godot_icall_1_24(method_bind_2, Object.GetPtr(this), Object.GetPtr(texturePressed));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture_pressed");

        [GodotMethod("get_texture_pressed")]
        [Obsolete("GetTexturePressed is deprecated. Use the Pressed property instead.")]
        public Texture GetTexturePressed()
        {
            return NativeCalls.godot_icall_0_161(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bitmask");

        [GodotMethod("set_bitmask")]
        [Obsolete("SetBitmask is deprecated. Use the Bitmask property instead.")]
        public void SetBitmask(BitMap bitmask)
        {
            NativeCalls.godot_icall_1_24(method_bind_4, Object.GetPtr(this), Object.GetPtr(bitmask));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bitmask");

        [GodotMethod("get_bitmask")]
        [Obsolete("GetBitmask is deprecated. Use the Bitmask property instead.")]
        public BitMap GetBitmask()
        {
            return NativeCalls.godot_icall_0_928(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shape");

        [GodotMethod("set_shape")]
        [Obsolete("SetShape is deprecated. Use the Shape property instead.")]
        public void SetShape(Shape2D shape)
        {
            NativeCalls.godot_icall_1_24(method_bind_6, Object.GetPtr(this), Object.GetPtr(shape));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shape");

        [GodotMethod("get_shape")]
        [Obsolete("GetShape is deprecated. Use the Shape property instead.")]
        public Shape2D GetShape()
        {
            return NativeCalls.godot_icall_0_304(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shape_centered");

        [GodotMethod("set_shape_centered")]
        [Obsolete("SetShapeCentered is deprecated. Use the ShapeCentered property instead.")]
        public void SetShapeCentered(bool @bool)
        {
            NativeCalls.godot_icall_1_16(method_bind_8, Object.GetPtr(this), @bool);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_shape_centered");

        [GodotMethod("is_shape_centered")]
        [Obsolete("IsShapeCentered is deprecated. Use the ShapeCentered property instead.")]
        public bool IsShapeCentered()
        {
            return NativeCalls.godot_icall_0_7(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shape_visible");

        [GodotMethod("set_shape_visible")]
        [Obsolete("SetShapeVisible is deprecated. Use the ShapeVisible property instead.")]
        public void SetShapeVisible(bool @bool)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), @bool);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_shape_visible");

        [GodotMethod("is_shape_visible")]
        [Obsolete("IsShapeVisible is deprecated. Use the ShapeVisible property instead.")]
        public bool IsShapeVisible()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_action");

        [GodotMethod("set_action")]
        [Obsolete("SetAction is deprecated. Use the Action property instead.")]
        public void SetAction(string action)
        {
            NativeCalls.godot_icall_1_54(method_bind_12, Object.GetPtr(this), action);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_action");

        [GodotMethod("get_action")]
        [Obsolete("GetAction is deprecated. Use the Action property instead.")]
        public string GetAction()
        {
            return NativeCalls.godot_icall_0_6(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_visibility_mode");

        [GodotMethod("set_visibility_mode")]
        [Obsolete("SetVisibilityMode is deprecated. Use the VisibilityMode property instead.")]
        public void SetVisibilityMode(TouchScreenButton.VisibilityModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_14, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_visibility_mode");

        [GodotMethod("get_visibility_mode")]
        [Obsolete("GetVisibilityMode is deprecated. Use the VisibilityMode property instead.")]
        public TouchScreenButton.VisibilityModeEnum GetVisibilityMode()
        {
            return (TouchScreenButton.VisibilityModeEnum)NativeCalls.godot_icall_0_972(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_passby_press");

        [GodotMethod("set_passby_press")]
        [Obsolete("SetPassbyPress is deprecated. Use the PassbyPress property instead.")]
        public void SetPassbyPress(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_16, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_passby_press_enabled");

        [GodotMethod("is_passby_press_enabled")]
        [Obsolete("IsPassbyPressEnabled is deprecated. Use the PassbyPress property instead.")]
        public bool IsPassbyPressEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_pressed");

        /// <summary>
        /// <para>Returns <c>true</c> if this button is currently pressed.</para>
        /// </summary>
        [GodotMethod("is_pressed")]
        public bool IsPressed()
        {
            return NativeCalls.godot_icall_0_7(method_bind_18, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
