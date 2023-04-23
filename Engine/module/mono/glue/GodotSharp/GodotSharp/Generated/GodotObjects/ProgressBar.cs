using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>General-purpose progress bar. Shows fill percentage from right to left.</para>
    /// </summary>
    public partial class ProgressBar : Range
    {
        /// <summary>
        /// <para>If <c>true</c>, the fill percentage is displayed on the bar.</para>
        /// </summary>
        public bool PercentVisible
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsPercentVisible();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPercentVisible(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ProgressBar";

        public ProgressBar() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ProgressBar_Ctor(this);
        }

        internal ProgressBar(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_percent_visible");

        [GodotMethod("set_percent_visible")]
        [Obsolete("SetPercentVisible is deprecated. Use the PercentVisible property instead.")]
        public void SetPercentVisible(bool visible)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), visible);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_percent_visible");

        [GodotMethod("is_percent_visible")]
        [Obsolete("IsPercentVisible is deprecated. Use the PercentVisible property instead.")]
        public bool IsPercentVisible()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
