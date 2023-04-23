using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Scrollbars are a <see cref="Godot.Range"/>-based <see cref="Godot.Control"/>, that display a draggable area (the size of the page). Horizontal (<see cref="Godot.HScrollBar"/>) and Vertical (<see cref="Godot.VScrollBar"/>) versions are available.</para>
    /// </summary>
    public abstract partial class ScrollBar : Range
    {
        /// <summary>
        /// <para>Overrides the step used when clicking increment and decrement buttons or when using arrow keys when the <see cref="Godot.ScrollBar"/> is focused.</para>
        /// </summary>
        public float CustomStep
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCustomStep();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCustomStep(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ScrollBar";

        internal ScrollBar() {}

        internal ScrollBar(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_custom_step");

        [GodotMethod("set_custom_step")]
        [Obsolete("SetCustomStep is deprecated. Use the CustomStep property instead.")]
        public void SetCustomStep(float step)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), step);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_custom_step");

        [GodotMethod("get_custom_step")]
        [Obsolete("GetCustomStep is deprecated. Use the CustomStep property instead.")]
        public float GetCustomStep()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
