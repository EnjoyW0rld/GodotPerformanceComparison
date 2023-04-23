using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Compares <c>a</c> and <c>b</c> of <see cref="Godot.VisualShaderNodeCompare.Type"/> by <see cref="Godot.VisualShaderNodeCompare.Function"/>. Returns a boolean scalar. Translates to <c>if</c> instruction in shader code.</para>
    /// </summary>
    public partial class VisualShaderNodeCompare : VisualShaderNode
    {
        public enum ComparisonType
        {
            /// <summary>
            /// <para>A floating-point scalar.</para>
            /// </summary>
            Scalar = 0,
            /// <summary>
            /// <para>A 3D vector type.</para>
            /// </summary>
            Vector = 1,
            /// <summary>
            /// <para>A boolean type.</para>
            /// </summary>
            Boolean = 2,
            /// <summary>
            /// <para>A transform (<c>mat4</c>) type.</para>
            /// </summary>
            Transform = 3
        }

        public enum FunctionEnum
        {
            /// <summary>
            /// <para>Comparison for equality (<c>a == b</c>).</para>
            /// </summary>
            Equal = 0,
            /// <summary>
            /// <para>Comparison for inequality (<c>a != b</c>).</para>
            /// </summary>
            NotEqual = 1,
            /// <summary>
            /// <para>Comparison for greater than (<c>a &gt; b</c>). Cannot be used if <see cref="Godot.VisualShaderNodeCompare.Type"/> set to <see cref="Godot.VisualShaderNodeCompare.ComparisonType.Boolean"/> or <see cref="Godot.VisualShaderNodeCompare.ComparisonType.Transform"/>.</para>
            /// </summary>
            GreaterThan = 2,
            /// <summary>
            /// <para>Comparison for greater than or equal (<c>a &gt;= b</c>). Cannot be used if <see cref="Godot.VisualShaderNodeCompare.Type"/> set to <see cref="Godot.VisualShaderNodeCompare.ComparisonType.Boolean"/> or <see cref="Godot.VisualShaderNodeCompare.ComparisonType.Transform"/>.</para>
            /// </summary>
            GreaterThanEqual = 3,
            /// <summary>
            /// <para>Comparison for less than (<c>a &lt; b</c>). Cannot be used if <see cref="Godot.VisualShaderNodeCompare.Type"/> set to <see cref="Godot.VisualShaderNodeCompare.ComparisonType.Boolean"/> or <see cref="Godot.VisualShaderNodeCompare.ComparisonType.Transform"/>.</para>
            /// </summary>
            LessThan = 4,
            /// <summary>
            /// <para>Comparison for less than or equal (<c>a &lt; b</c>). Cannot be used if <see cref="Godot.VisualShaderNodeCompare.Type"/> set to <see cref="Godot.VisualShaderNodeCompare.ComparisonType.Boolean"/> or <see cref="Godot.VisualShaderNodeCompare.ComparisonType.Transform"/>.</para>
            /// </summary>
            LessThanEqual = 5
        }

        public enum ConditionEnum
        {
            /// <summary>
            /// <para>The result will be true if all of component in vector satisfy the comparison condition.</para>
            /// </summary>
            All = 0,
            /// <summary>
            /// <para>The result will be true if any of component in vector satisfy the comparison condition.</para>
            /// </summary>
            Any = 1
        }

        /// <summary>
        /// <para>The type to be used in the comparison. See <see cref="Godot.VisualShaderNodeCompare.ComparisonType"/> for options.</para>
        /// </summary>
        public VisualShaderNodeCompare.ComparisonType Type
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetComparisonType();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetComparisonType(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A comparison function. See <see cref="Godot.VisualShaderNodeCompare.FunctionEnum"/> for options.</para>
        /// </summary>
        public VisualShaderNodeCompare.FunctionEnum Function
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

        /// <summary>
        /// <para>Extra condition which is applied if <see cref="Godot.VisualShaderNodeCompare.Type"/> is set to <see cref="Godot.VisualShaderNodeCompare.ComparisonType.Vector"/>.</para>
        /// </summary>
        public VisualShaderNodeCompare.ConditionEnum Condition
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCondition();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCondition(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualShaderNodeCompare";

        public VisualShaderNodeCompare() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeCompare_Ctor(this);
        }

        internal VisualShaderNodeCompare(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_comparison_type");

        [GodotMethod("set_comparison_type")]
        [Obsolete("SetComparisonType is deprecated. Use the Type property instead.")]
        public void SetComparisonType(VisualShaderNodeCompare.ComparisonType type)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_comparison_type");

        [GodotMethod("get_comparison_type")]
        [Obsolete("GetComparisonType is deprecated. Use the Type property instead.")]
        public VisualShaderNodeCompare.ComparisonType GetComparisonType()
        {
            return (VisualShaderNodeCompare.ComparisonType)NativeCalls.godot_icall_0_1129(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_function");

        [GodotMethod("set_function")]
        [Obsolete("SetFunction is deprecated. Use the Function property instead.")]
        public void SetFunction(VisualShaderNodeCompare.FunctionEnum func)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)func);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_function");

        [GodotMethod("get_function")]
        [Obsolete("GetFunction is deprecated. Use the Function property instead.")]
        public VisualShaderNodeCompare.FunctionEnum GetFunction()
        {
            return (VisualShaderNodeCompare.FunctionEnum)NativeCalls.godot_icall_0_1130(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_condition");

        [GodotMethod("set_condition")]
        [Obsolete("SetCondition is deprecated. Use the Condition property instead.")]
        public void SetCondition(VisualShaderNodeCompare.ConditionEnum condition)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), (int)condition);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_condition");

        [GodotMethod("get_condition")]
        [Obsolete("GetCondition is deprecated. Use the Condition property instead.")]
        public VisualShaderNodeCompare.ConditionEnum GetCondition()
        {
            return (VisualShaderNodeCompare.ConditionEnum)NativeCalls.godot_icall_0_1131(method_bind_5, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
