using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Accept a <see cref="Godot.Color"/> to the input port and transform it according to <see cref="Godot.VisualShaderNodeColorFunc.Function"/>.</para>
    /// </summary>
    public partial class VisualShaderNodeColorFunc : VisualShaderNode
    {
        public enum FunctionEnum
        {
            /// <summary>
            /// <para>Converts the color to grayscale using the following formula:</para>
            /// <para><code>
            /// vec3 c = input;
            /// float max1 = max(c.r, c.g);
            /// float max2 = max(max1, c.b);
            /// float max3 = max(max1, max2);
            /// return vec3(max3, max3, max3);
            /// </code></para>
            /// </summary>
            Grayscale = 0,
            /// <summary>
            /// <para>Applies sepia tone effect using the following formula:</para>
            /// <para><code>
            /// vec3 c = input;
            /// float r = (c.r * 0.393) + (c.g * 0.769) + (c.b * 0.189);
            /// float g = (c.r * 0.349) + (c.g * 0.686) + (c.b * 0.168);
            /// float b = (c.r * 0.272) + (c.g * 0.534) + (c.b * 0.131);
            /// return vec3(r, g, b);
            /// </code></para>
            /// </summary>
            Sepia = 1
        }

        /// <summary>
        /// <para>A function to be applied to the input color. See <see cref="Godot.VisualShaderNodeColorFunc.FunctionEnum"/> for options.</para>
        /// </summary>
        public VisualShaderNodeColorFunc.FunctionEnum Function
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

        private const string nativeName = "VisualShaderNodeColorFunc";

        public VisualShaderNodeColorFunc() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeColorFunc_Ctor(this);
        }

        internal VisualShaderNodeColorFunc(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_function");

        [GodotMethod("set_function")]
        [Obsolete("SetFunction is deprecated. Use the Function property instead.")]
        public void SetFunction(VisualShaderNodeColorFunc.FunctionEnum func)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)func);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_function");

        [GodotMethod("get_function")]
        [Obsolete("GetFunction is deprecated. Use the Function property instead.")]
        public VisualShaderNodeColorFunc.FunctionEnum GetFunction()
        {
            return (VisualShaderNodeColorFunc.FunctionEnum)NativeCalls.godot_icall_0_1127(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
