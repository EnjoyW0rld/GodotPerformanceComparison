using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Has two output ports representing RGB and alpha channels of <see cref="Godot.Color"/>.</para>
    /// <para>Translated to <c>vec3 rgb</c> and <c>float alpha</c> in the shader language.</para>
    /// </summary>
    public partial class VisualShaderNodeColorConstant : VisualShaderNode
    {
        /// <summary>
        /// <para>A <see cref="Godot.Color"/> constant which represents a state of this node.</para>
        /// </summary>
        public Color Constant
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetConstant();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetConstant(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualShaderNodeColorConstant";

        public VisualShaderNodeColorConstant() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeColorConstant_Ctor(this);
        }

        internal VisualShaderNodeColorConstant(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_constant");

        [GodotMethod("set_constant")]
        [Obsolete("SetConstant is deprecated. Use the Constant property instead.")]
        public void SetConstant(Color value)
        {
            NativeCalls.godot_icall_1_199(method_bind_0, Object.GetPtr(this), ref value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_constant");

        [GodotMethod("get_constant")]
        [Obsolete("GetConstant is deprecated. Use the Constant property instead.")]
        public Color GetConstant()
        {
            NativeCalls.godot_icall_0_200(method_bind_1, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
