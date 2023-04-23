using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Base class for GUI sliders.</para>
    /// <para>Note: The <c>Range.changed</c> and <c>Range.value_changed</c> signals are part of the <see cref="Godot.Range"/> class which this class inherits from.</para>
    /// </summary>
    public abstract partial class Slider : Range
    {
        /// <summary>
        /// <para>If <c>true</c>, the slider can be interacted with. If <c>false</c>, the value can be changed only by code.</para>
        /// </summary>
        public bool Editable
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsEditable();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEditable(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the value can be changed using the mouse wheel.</para>
        /// </summary>
        public bool Scrollable
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsScrollable();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetScrollable(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Number of ticks displayed on the slider, including border ticks. Ticks are uniformly-distributed value markers.</para>
        /// </summary>
        public int TickCount
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTicks();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTicks(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the slider will display ticks for minimum and maximum values.</para>
        /// </summary>
        public bool TicksOnBorders
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTicksOnBorders();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTicksOnBorders(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Slider";

        internal Slider() {}

        internal Slider(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ticks");

        [GodotMethod("set_ticks")]
        [Obsolete("SetTicks is deprecated. Use the TickCount property instead.")]
        public void SetTicks(int count)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), count);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ticks");

        [GodotMethod("get_ticks")]
        [Obsolete("GetTicks is deprecated. Use the TickCount property instead.")]
        public int GetTicks()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ticks_on_borders");

        [GodotMethod("get_ticks_on_borders")]
        [Obsolete("GetTicksOnBorders is deprecated. Use the TicksOnBorders property instead.")]
        public bool GetTicksOnBorders()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ticks_on_borders");

        [GodotMethod("set_ticks_on_borders")]
        [Obsolete("SetTicksOnBorders is deprecated. Use the TicksOnBorders property instead.")]
        public void SetTicksOnBorders(bool ticksOnBorder)
        {
            NativeCalls.godot_icall_1_16(method_bind_3, Object.GetPtr(this), ticksOnBorder);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_editable");

        [GodotMethod("set_editable")]
        [Obsolete("SetEditable is deprecated. Use the Editable property instead.")]
        public void SetEditable(bool editable)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), editable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_editable");

        [GodotMethod("is_editable")]
        [Obsolete("IsEditable is deprecated. Use the Editable property instead.")]
        public bool IsEditable()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_scrollable");

        [GodotMethod("set_scrollable")]
        [Obsolete("SetScrollable is deprecated. Use the Scrollable property instead.")]
        public void SetScrollable(bool scrollable)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), scrollable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_scrollable");

        [GodotMethod("is_scrollable")]
        [Obsolete("IsScrollable is deprecated. Use the Scrollable property instead.")]
        public bool IsScrollable()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
