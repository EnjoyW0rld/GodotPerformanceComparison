using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A constant <see cref="Godot.Transform"/>, which can be used as an input node.</para>
    /// </summary>
    public partial class VisualShaderNodeTransformConstant : VisualShaderNode
    {
        /// <summary>
        /// <para>A <see cref="Godot.Transform"/> constant which represents the state of this node.</para>
        /// </summary>
        public Transform Constant
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

        private const string nativeName = "VisualShaderNodeTransformConstant";

        public VisualShaderNodeTransformConstant() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeTransformConstant_Ctor(this);
        }

        internal VisualShaderNodeTransformConstant(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_constant");

        [GodotMethod("set_constant")]
        [Obsolete("SetConstant is deprecated. Use the Constant property instead.")]
        public void SetConstant(Transform value)
        {
            NativeCalls.godot_icall_1_202(method_bind_0, Object.GetPtr(this), ref value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_constant");

        [GodotMethod("get_constant")]
        [Obsolete("GetConstant is deprecated. Use the Constant property instead.")]
        public Transform GetConstant()
        {
            NativeCalls.godot_icall_0_22(method_bind_1, Object.GetPtr(this), out Transform argRet); return (Transform)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
