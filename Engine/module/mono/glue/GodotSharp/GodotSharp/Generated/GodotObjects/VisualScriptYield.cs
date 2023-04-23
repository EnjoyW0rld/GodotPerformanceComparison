using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.VisualScriptYield"/> will pause the function call and return <see cref="Godot.VisualScriptFunctionState"/>, which can be used to resume the function.</para>
    /// </summary>
    public partial class VisualScriptYield : VisualScriptNode
    {
        public enum YieldMode
        {
            /// <summary>
            /// <para>Yields during an idle frame.</para>
            /// </summary>
            Frame = 1,
            /// <summary>
            /// <para>Yields during a physics frame.</para>
            /// </summary>
            PhysicsFrame = 2,
            /// <summary>
            /// <para>Yields a function and waits the given time.</para>
            /// </summary>
            Wait = 3
        }

        /// <summary>
        /// <para>The mode to use for yielding. See <see cref="Godot.VisualScriptYield.YieldMode"/> for available options.</para>
        /// </summary>
        public VisualScriptYield.YieldMode Mode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetYieldMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetYieldMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The time to wait when <see cref="Godot.VisualScriptYield.Mode"/> is set to <see cref="Godot.VisualScriptYield.YieldMode.Wait"/>.</para>
        /// </summary>
        public float WaitTime
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetWaitTime();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetWaitTime(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptYield";

        public VisualScriptYield() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptYield_Ctor(this);
        }

        internal VisualScriptYield(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_yield_mode");

        [GodotMethod("set_yield_mode")]
        [Obsolete("SetYieldMode is deprecated. Use the Mode property instead.")]
        public void SetYieldMode(VisualScriptYield.YieldMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_yield_mode");

        [GodotMethod("get_yield_mode")]
        [Obsolete("GetYieldMode is deprecated. Use the Mode property instead.")]
        public VisualScriptYield.YieldMode GetYieldMode()
        {
            return (VisualScriptYield.YieldMode)NativeCalls.godot_icall_0_1043(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_wait_time");

        [GodotMethod("set_wait_time")]
        [Obsolete("SetWaitTime is deprecated. Use the WaitTime property instead.")]
        public void SetWaitTime(float sec)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), sec);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_wait_time");

        [GodotMethod("get_wait_time")]
        [Obsolete("GetWaitTime is deprecated. Use the WaitTime property instead.")]
        public float GetWaitTime()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
