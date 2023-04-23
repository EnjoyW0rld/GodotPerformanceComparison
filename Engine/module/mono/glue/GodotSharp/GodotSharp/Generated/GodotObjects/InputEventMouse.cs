using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Stores general mouse events information.</para>
    /// </summary>
    public abstract partial class InputEventMouse : InputEventWithModifiers
    {
        /// <summary>
        /// <para>The mouse button mask identifier, one of or a bitwise combination of the <see cref="Godot.ButtonList"/> button masks.</para>
        /// </summary>
        public int ButtonMask
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetButtonMask();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetButtonMask(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When received in <see cref="Godot.Node._Input"/> or <see cref="Godot.Node._UnhandledInput"/>, returns the mouse's position in the <see cref="Godot.Viewport"/> this <see cref="Godot.Node"/> is in using the coordinate system of this <see cref="Godot.Viewport"/>.</para>
        /// <para>When received in <see cref="Godot.Control._GuiInput"/>, returns the mouse's position in the <see cref="Godot.Control"/> using the local coordinate system of the <see cref="Godot.Control"/>.</para>
        /// </summary>
        public Vector2 Position
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPosition();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPosition(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When received in <see cref="Godot.Node._Input"/> or <see cref="Godot.Node._UnhandledInput"/>, returns the mouse's position in the root <see cref="Godot.Viewport"/> using the coordinate system of the root <see cref="Godot.Viewport"/>.</para>
        /// <para>When received in <see cref="Godot.Control._GuiInput"/>, returns the mouse's position in the <see cref="Godot.CanvasLayer"/> that the <see cref="Godot.Control"/> is in using the coordinate system of the <see cref="Godot.CanvasLayer"/>.</para>
        /// </summary>
        public Vector2 GlobalPosition
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGlobalPosition();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlobalPosition(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "InputEventMouse";

        internal InputEventMouse() {}

        internal InputEventMouse(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_button_mask");

        [GodotMethod("set_button_mask")]
        [Obsolete("SetButtonMask is deprecated. Use the ButtonMask property instead.")]
        public void SetButtonMask(int buttonMask)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), buttonMask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_button_mask");

        [GodotMethod("get_button_mask")]
        [Obsolete("GetButtonMask is deprecated. Use the ButtonMask property instead.")]
        public int GetButtonMask()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_position");

        [GodotMethod("set_position")]
        [Obsolete("SetPosition is deprecated. Use the Position property instead.")]
        public void SetPosition(Vector2 position)
        {
            NativeCalls.godot_icall_1_57(method_bind_2, Object.GetPtr(this), ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_position");

        [GodotMethod("get_position")]
        [Obsolete("GetPosition is deprecated. Use the Position property instead.")]
        public Vector2 GetPosition()
        {
            NativeCalls.godot_icall_0_18(method_bind_3, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_global_position");

        [GodotMethod("set_global_position")]
        [Obsolete("SetGlobalPosition is deprecated. Use the GlobalPosition property instead.")]
        public void SetGlobalPosition(Vector2 globalPosition)
        {
            NativeCalls.godot_icall_1_57(method_bind_4, Object.GetPtr(this), ref globalPosition);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_global_position");

        [GodotMethod("get_global_position")]
        [Obsolete("GetGlobalPosition is deprecated. Use the GlobalPosition property instead.")]
        public Vector2 GetGlobalPosition()
        {
            NativeCalls.godot_icall_0_18(method_bind_5, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
