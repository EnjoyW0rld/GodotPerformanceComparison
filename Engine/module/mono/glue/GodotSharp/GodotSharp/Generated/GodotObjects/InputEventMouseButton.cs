using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Contains mouse click information. See <see cref="Godot.Node._Input"/>.</para>
    /// </summary>
    public partial class InputEventMouseButton : InputEventMouse
    {
        /// <summary>
        /// <para>The amount (or delta) of the event. When used for high-precision scroll events, this indicates the scroll amount (vertical or horizontal). This is only supported on some platforms; the reported sensitivity varies depending on the platform. May be <c>0</c> if not supported.</para>
        /// </summary>
        public float Factor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFactor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFactor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The mouse button identifier, one of the <see cref="Godot.ButtonList"/> button or button wheel constants.</para>
        /// </summary>
        public int ButtonIndex
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetButtonIndex();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetButtonIndex(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the mouse button's state is pressed. If <c>false</c>, the mouse button's state is released.</para>
        /// </summary>
        public bool Pressed
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsPressed();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPressed(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the mouse button's state is a double-click.</para>
        /// </summary>
        public bool Doubleclick
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDoubleclick();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDoubleclick(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "InputEventMouseButton";

        public InputEventMouseButton() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_InputEventMouseButton_Ctor(this);
        }

        internal InputEventMouseButton(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_factor");

        [GodotMethod("set_factor")]
        [Obsolete("SetFactor is deprecated. Use the Factor property instead.")]
        public void SetFactor(float factor)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), factor);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_factor");

        [GodotMethod("get_factor")]
        [Obsolete("GetFactor is deprecated. Use the Factor property instead.")]
        public float GetFactor()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_button_index");

        [GodotMethod("set_button_index")]
        [Obsolete("SetButtonIndex is deprecated. Use the ButtonIndex property instead.")]
        public void SetButtonIndex(int buttonIndex)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), buttonIndex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_button_index");

        [GodotMethod("get_button_index")]
        [Obsolete("GetButtonIndex is deprecated. Use the ButtonIndex property instead.")]
        public int GetButtonIndex()
        {
            return NativeCalls.godot_icall_0_5(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pressed");

        [GodotMethod("set_pressed")]
        [Obsolete("SetPressed is deprecated. Use the Pressed property instead.")]
        public void SetPressed(bool pressed)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), pressed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_doubleclick");

        [GodotMethod("set_doubleclick")]
        [Obsolete("SetDoubleclick is deprecated. Use the Doubleclick property instead.")]
        public void SetDoubleclick(bool doubleclick)
        {
            NativeCalls.godot_icall_1_16(method_bind_5, Object.GetPtr(this), doubleclick);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_doubleclick");

        [GodotMethod("is_doubleclick")]
        [Obsolete("IsDoubleclick is deprecated. Use the Doubleclick property instead.")]
        public bool IsDoubleclick()
        {
            return NativeCalls.godot_icall_0_7(method_bind_6, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
