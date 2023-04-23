using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public abstract partial class InputEventGesture : InputEventWithModifiers
    {
        /// <summary>
        /// <para>The local gesture position relative to the <see cref="Godot.Viewport"/>. If used in <see cref="Godot.Control._GuiInput"/>, the position is relative to the current <see cref="Godot.Control"/> that received this gesture.</para>
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

        private const string nativeName = "InputEventGesture";

        internal InputEventGesture() {}

        internal InputEventGesture(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_position");

        [GodotMethod("set_position")]
        [Obsolete("SetPosition is deprecated. Use the Position property instead.")]
        public void SetPosition(Vector2 position)
        {
            NativeCalls.godot_icall_1_57(method_bind_0, Object.GetPtr(this), ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_position");

        [GodotMethod("get_position")]
        [Obsolete("GetPosition is deprecated. Use the Position property instead.")]
        public Vector2 GetPosition()
        {
            NativeCalls.godot_icall_0_18(method_bind_1, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
