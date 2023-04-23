using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class InputEventPanGesture : InputEventGesture
    {
        public Vector2 Delta
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDelta();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDelta(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "InputEventPanGesture";

        public InputEventPanGesture() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_InputEventPanGesture_Ctor(this);
        }

        internal InputEventPanGesture(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_delta");

        [GodotMethod("set_delta")]
        [Obsolete("SetDelta is deprecated. Use the Delta property instead.")]
        public void SetDelta(Vector2 delta)
        {
            NativeCalls.godot_icall_1_57(method_bind_0, Object.GetPtr(this), ref delta);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_delta");

        [GodotMethod("get_delta")]
        [Obsolete("GetDelta is deprecated. Use the Delta property instead.")]
        public Vector2 GetDelta()
        {
            NativeCalls.godot_icall_0_18(method_bind_1, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
