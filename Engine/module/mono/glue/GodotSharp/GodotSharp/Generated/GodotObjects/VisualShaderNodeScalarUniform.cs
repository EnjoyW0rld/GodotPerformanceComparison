using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class VisualShaderNodeScalarUniform : VisualShaderNodeUniform
    {
        public enum HintEnum
        {
            /// <summary>
            /// <para>No hint used.</para>
            /// </summary>
            None = 0,
            /// <summary>
            /// <para>A range hint for scalar value, which limits possible input values between <see cref="Godot.VisualShaderNodeScalarUniform.Min"/> and <see cref="Godot.VisualShaderNodeScalarUniform.Max"/>. Translated to <c>hint_range(min, max)</c> in shader code.</para>
            /// </summary>
            Range = 1,
            /// <summary>
            /// <para>A range hint for scalar value with step, which limits possible input values between <see cref="Godot.VisualShaderNodeScalarUniform.Min"/> and <see cref="Godot.VisualShaderNodeScalarUniform.Max"/>, with a step (increment) of <see cref="Godot.VisualShaderNodeScalarUniform.Step"/>). Translated to <c>hint_range(min, max, step)</c> in shader code.</para>
            /// </summary>
            RangeStep = 2,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.VisualShaderNodeScalarUniform.HintEnum"/> enum.</para>
            /// </summary>
            Max = 3
        }

        /// <summary>
        /// <para>A hint applied to the uniform, which controls the values it can take when set through the inspector.</para>
        /// </summary>
        public VisualShaderNodeScalarUniform.HintEnum Hint
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHint();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHint(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Maximum value for range hints. Used if <see cref="Godot.VisualShaderNodeScalarUniform.Hint"/> is set to <see cref="Godot.VisualShaderNodeScalarUniform.HintEnum.Range"/> or <see cref="Godot.VisualShaderNodeScalarUniform.HintEnum.RangeStep"/>.</para>
        /// </summary>
        public float Min
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMin(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Minimum value for range hints. Used if <see cref="Godot.VisualShaderNodeScalarUniform.Hint"/> is set to <see cref="Godot.VisualShaderNodeScalarUniform.HintEnum.Range"/> or <see cref="Godot.VisualShaderNodeScalarUniform.HintEnum.RangeStep"/>.</para>
        /// </summary>
        public float Max
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMax();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMax(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Step (increment) value for the range hint with step. Used if <see cref="Godot.VisualShaderNodeScalarUniform.Hint"/> is set to <see cref="Godot.VisualShaderNodeScalarUniform.HintEnum.RangeStep"/>.</para>
        /// </summary>
        public float Step
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetStep();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetStep(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Enables usage of the <see cref="Godot.VisualShaderNodeScalarUniform.DefaultValue"/>.</para>
        /// </summary>
        public bool DefaultValueEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDefaultValueEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDefaultValueEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A default value to be assigned within the shader.</para>
        /// </summary>
        public float DefaultValue
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDefaultValue();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDefaultValue(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualShaderNodeScalarUniform";

        public VisualShaderNodeScalarUniform() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeScalarUniform_Ctor(this);
        }

        internal VisualShaderNodeScalarUniform(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_hint");

        [GodotMethod("set_hint")]
        [Obsolete("SetHint is deprecated. Use the Hint property instead.")]
        public void SetHint(VisualShaderNodeScalarUniform.HintEnum hint)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)hint);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_hint");

        [GodotMethod("get_hint")]
        [Obsolete("GetHint is deprecated. Use the Hint property instead.")]
        public VisualShaderNodeScalarUniform.HintEnum GetHint()
        {
            return (VisualShaderNodeScalarUniform.HintEnum)NativeCalls.godot_icall_0_1139(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_min");

        [GodotMethod("set_min")]
        [Obsolete("SetMin is deprecated. Use the Min property instead.")]
        public void SetMin(float value)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_min");

        [GodotMethod("get_min")]
        [Obsolete("GetMin is deprecated. Use the Min property instead.")]
        public float GetMin()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max");

        [GodotMethod("set_max")]
        [Obsolete("SetMax is deprecated. Use the Max property instead.")]
        public void SetMax(float value)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max");

        [GodotMethod("get_max")]
        [Obsolete("GetMax is deprecated. Use the Max property instead.")]
        public float GetMax()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_step");

        [GodotMethod("set_step")]
        [Obsolete("SetStep is deprecated. Use the Step property instead.")]
        public void SetStep(float value)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_step");

        [GodotMethod("get_step")]
        [Obsolete("GetStep is deprecated. Use the Step property instead.")]
        public float GetStep()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_default_value_enabled");

        [GodotMethod("set_default_value_enabled")]
        [Obsolete("SetDefaultValueEnabled is deprecated. Use the DefaultValueEnabled property instead.")]
        public void SetDefaultValueEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_8, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_default_value_enabled");

        [GodotMethod("is_default_value_enabled")]
        [Obsolete("IsDefaultValueEnabled is deprecated. Use the DefaultValueEnabled property instead.")]
        public bool IsDefaultValueEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_default_value");

        [GodotMethod("set_default_value")]
        [Obsolete("SetDefaultValue is deprecated. Use the DefaultValue property instead.")]
        public void SetDefaultValue(float value)
        {
            NativeCalls.godot_icall_1_15(method_bind_10, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_default_value");

        [GodotMethod("get_default_value")]
        [Obsolete("GetDefaultValue is deprecated. Use the DefaultValue property instead.")]
        public float GetDefaultValue()
        {
            return NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
