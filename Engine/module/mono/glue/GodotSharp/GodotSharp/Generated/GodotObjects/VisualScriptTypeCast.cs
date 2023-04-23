using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.VisualScriptTypeCast"/> will perform a type conversion to an <see cref="Godot.Object"/>-derived type.</para>
    /// </summary>
    public partial class VisualScriptTypeCast : VisualScriptNode
    {
        /// <summary>
        /// <para>The target type to be converted to.</para>
        /// </summary>
        public string BaseType
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBaseType();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBaseType(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The target script class to be converted to. If none, only the <see cref="Godot.VisualScriptTypeCast.BaseType"/> will be used.</para>
        /// </summary>
        public string BaseScript
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBaseScript();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBaseScript(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptTypeCast";

        public VisualScriptTypeCast() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptTypeCast_Ctor(this);
        }

        internal VisualScriptTypeCast(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_base_type");

        [GodotMethod("set_base_type")]
        [Obsolete("SetBaseType is deprecated. Use the BaseType property instead.")]
        public void SetBaseType(string type)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_base_type");

        [GodotMethod("get_base_type")]
        [Obsolete("GetBaseType is deprecated. Use the BaseType property instead.")]
        public string GetBaseType()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_base_script");

        [GodotMethod("set_base_script")]
        [Obsolete("SetBaseScript is deprecated. Use the BaseScript property instead.")]
        public void SetBaseScript(string path)
        {
            NativeCalls.godot_icall_1_54(method_bind_2, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_base_script");

        [GodotMethod("get_base_script")]
        [Obsolete("GetBaseScript is deprecated. Use the BaseScript property instead.")]
        public string GetBaseScript()
        {
            return NativeCalls.godot_icall_0_6(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
