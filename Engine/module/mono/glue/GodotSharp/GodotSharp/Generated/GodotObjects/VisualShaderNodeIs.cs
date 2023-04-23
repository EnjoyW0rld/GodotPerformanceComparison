using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Returns the boolean result of the comparison between <c>INF</c> or <c>NaN</c> and a scalar parameter.</para>
    /// </summary>
    public partial class VisualShaderNodeIs : VisualShaderNode
    {
        public enum FunctionEnum
        {
            /// <summary>
            /// <para>Comparison with <c>INF</c> (Infinity).</para>
            /// </summary>
            Inf = 0,
            /// <summary>
            /// <para>Comparison with <c>NaN</c> (Not a Number; denotes invalid numeric results, e.g. division by zero).</para>
            /// </summary>
            Nan = 1
        }

        /// <summary>
        /// <para>The comparison function. See <see cref="Godot.VisualShaderNodeIs.FunctionEnum"/> for options.</para>
        /// </summary>
        public VisualShaderNodeIs.FunctionEnum Function
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFunction();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFunction(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualShaderNodeIs";

        public VisualShaderNodeIs() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeIs_Ctor(this);
        }

        internal VisualShaderNodeIs(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_function");

        [GodotMethod("set_function")]
        [Obsolete("SetFunction is deprecated. Use the Function property instead.")]
        public void SetFunction(VisualShaderNodeIs.FunctionEnum func)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)func);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_function");

        [GodotMethod("get_function")]
        [Obsolete("GetFunction is deprecated. Use the Function property instead.")]
        public VisualShaderNodeIs.FunctionEnum GetFunction()
        {
            return (VisualShaderNodeIs.FunctionEnum)NativeCalls.godot_icall_0_1135(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
