using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Stores multi-touch press/release information. Supports touch press, touch release and <see cref="Godot.InputEventScreenTouch.Index"/> for multi-touch count and order.</para>
    /// </summary>
    public partial class InputEventScreenTouch : InputEvent
    {
        /// <summary>
        /// <para>The touch index in the case of a multi-touch event. One index = one finger.</para>
        /// </summary>
        public int Index
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetIndex();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetIndex(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The touch position.</para>
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
        /// <para>If <c>true</c>, the touch's state is pressed. If <c>false</c>, the touch's state is released.</para>
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

        private const string nativeName = "InputEventScreenTouch";

        public InputEventScreenTouch() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_InputEventScreenTouch_Ctor(this);
        }

        internal InputEventScreenTouch(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_index");

        [GodotMethod("set_index")]
        [Obsolete("SetIndex is deprecated. Use the Index property instead.")]
        public void SetIndex(int index)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_index");

        [GodotMethod("get_index")]
        [Obsolete("GetIndex is deprecated. Use the Index property instead.")]
        public int GetIndex()
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
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pressed");

        [GodotMethod("set_pressed")]
        [Obsolete("SetPressed is deprecated. Use the Pressed property instead.")]
        public void SetPressed(bool pressed)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), pressed);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
