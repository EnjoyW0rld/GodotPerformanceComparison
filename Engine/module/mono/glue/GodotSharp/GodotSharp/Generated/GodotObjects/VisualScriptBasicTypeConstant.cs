using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A Visual Script node representing a constant from base types, such as <c>Vector3.AXIS_X</c>.</para>
    /// </summary>
    public partial class VisualScriptBasicTypeConstant : VisualScriptNode
    {
        /// <summary>
        /// <para>The type to get the constant from.</para>
        /// </summary>
        public Variant.Type BasicType
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBasicType();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBasicType(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The name of the constant to return.</para>
        /// </summary>
        public string Constant
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBasicTypeConstant();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBasicTypeConstant(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptBasicTypeConstant";

        public VisualScriptBasicTypeConstant() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptBasicTypeConstant_Ctor(this);
        }

        internal VisualScriptBasicTypeConstant(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_basic_type");

        [GodotMethod("set_basic_type")]
        [Obsolete("SetBasicType is deprecated. Use the BasicType property instead.")]
        public void SetBasicType(Variant.Type name)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_basic_type");

        [GodotMethod("get_basic_type")]
        [Obsolete("GetBasicType is deprecated. Use the BasicType property instead.")]
        public Variant.Type GetBasicType()
        {
            return (Variant.Type)NativeCalls.godot_icall_0_1030(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_basic_type_constant");

        [GodotMethod("set_basic_type_constant")]
        [Obsolete("SetBasicTypeConstant is deprecated. Use the Constant property instead.")]
        public void SetBasicTypeConstant(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_2, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_basic_type_constant");

        [GodotMethod("get_basic_type_constant")]
        [Obsolete("GetBasicTypeConstant is deprecated. Use the Constant property instead.")]
        public string GetBasicTypeConstant()
        {
            return NativeCalls.godot_icall_0_6(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
