using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class InputEventMagnifyGesture : InputEventGesture
    {
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

        private const string nativeName = "InputEventMagnifyGesture";

        public InputEventMagnifyGesture() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_InputEventMagnifyGesture_Ctor(this);
        }

        internal InputEventMagnifyGesture(bool memoryOwn) : base(memoryOwn) {}

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
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
