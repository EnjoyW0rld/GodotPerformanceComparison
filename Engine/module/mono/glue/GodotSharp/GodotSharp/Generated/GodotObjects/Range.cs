using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Range is a base class for <see cref="Godot.Control"/> nodes that change a floating-point <see cref="Godot.Range.Value"/> between a <see cref="Godot.Range.MinValue"/> and <see cref="Godot.Range.MaxValue"/>, using a configured <see cref="Godot.Range.Step"/> and <see cref="Godot.Range.Page"/> size. See e.g. <see cref="Godot.ScrollBar"/> and <see cref="Godot.Slider"/> for examples of higher level nodes using Range.</para>
    /// </summary>
    public abstract partial class Range : Control
    {
        /// <summary>
        /// <para>Minimum value. Range is clamped if <c>value</c> is less than <c>min_value</c>.</para>
        /// </summary>
        public double MinValue
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
        /// <para>Maximum value. Range is clamped if <c>value</c> is greater than <c>max_value</c>.</para>
        /// </summary>
        public double MaxValue
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
        /// <para>If greater than 0, <c>value</c> will always be rounded to a multiple of <c>step</c>. If <c>rounded</c> is also <c>true</c>, <c>value</c> will first be rounded to a multiple of <c>step</c> then rounded to the nearest integer.</para>
        /// </summary>
        public double Step
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
        /// <para>Page size. Used mainly for <see cref="Godot.ScrollBar"/>. ScrollBar's length is its size multiplied by <c>page</c> over the difference between <c>min_value</c> and <c>max_value</c>.</para>
        /// </summary>
        public double Page
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPage();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPage(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Range's current value.</para>
        /// </summary>
        public double Value
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetValue();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetValue(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The value mapped between 0 and 1.</para>
        /// </summary>
        public double Ratio
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAsRatio();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAsRatio(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, and <c>min_value</c> is greater than 0, <c>value</c> will be represented exponentially rather than linearly.</para>
        /// </summary>
        public bool ExpEdit
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsRatioExp();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExpRatio(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, <c>value</c> will always be rounded to the nearest integer.</para>
        /// </summary>
        public bool Rounded
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUsingRoundedValues();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseRoundedValues(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, <see cref="Godot.Range.Value"/> may be greater than <see cref="Godot.Range.MaxValue"/>.</para>
        /// </summary>
        public bool AllowGreater
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsGreaterAllowed();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAllowGreater(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, <see cref="Godot.Range.Value"/> may be less than <see cref="Godot.Range.MinValue"/>.</para>
        /// </summary>
        public bool AllowLesser
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsLesserAllowed();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAllowLesser(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Range";

        internal Range() {}

        internal Range(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_value");

        [GodotMethod("get_value")]
        [Obsolete("GetValue is deprecated. Use the Value property instead.")]
        public double GetValue()
        {
            return NativeCalls.godot_icall_0_179(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_min");

        [GodotMethod("get_min")]
        [Obsolete("GetMin is deprecated. Use the MinValue property instead.")]
        public double GetMin()
        {
            return NativeCalls.godot_icall_0_179(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max");

        [GodotMethod("get_max")]
        [Obsolete("GetMax is deprecated. Use the MaxValue property instead.")]
        public double GetMax()
        {
            return NativeCalls.godot_icall_0_179(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_step");

        [GodotMethod("get_step")]
        [Obsolete("GetStep is deprecated. Use the Step property instead.")]
        public double GetStep()
        {
            return NativeCalls.godot_icall_0_179(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_page");

        [GodotMethod("get_page")]
        [Obsolete("GetPage is deprecated. Use the Page property instead.")]
        public double GetPage()
        {
            return NativeCalls.godot_icall_0_179(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_as_ratio");

        [GodotMethod("get_as_ratio")]
        [Obsolete("GetAsRatio is deprecated. Use the Ratio property instead.")]
        public double GetAsRatio()
        {
            return NativeCalls.godot_icall_0_179(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_value");

        [GodotMethod("set_value")]
        [Obsolete("SetValue is deprecated. Use the Value property instead.")]
        public void SetValue(double value)
        {
            NativeCalls.godot_icall_1_496(method_bind_6, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_min");

        [GodotMethod("set_min")]
        [Obsolete("SetMin is deprecated. Use the MinValue property instead.")]
        public void SetMin(double minimum)
        {
            NativeCalls.godot_icall_1_496(method_bind_7, Object.GetPtr(this), minimum);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max");

        [GodotMethod("set_max")]
        [Obsolete("SetMax is deprecated. Use the MaxValue property instead.")]
        public void SetMax(double maximum)
        {
            NativeCalls.godot_icall_1_496(method_bind_8, Object.GetPtr(this), maximum);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_step");

        [GodotMethod("set_step")]
        [Obsolete("SetStep is deprecated. Use the Step property instead.")]
        public void SetStep(double step)
        {
            NativeCalls.godot_icall_1_496(method_bind_9, Object.GetPtr(this), step);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_page");

        [GodotMethod("set_page")]
        [Obsolete("SetPage is deprecated. Use the Page property instead.")]
        public void SetPage(double pagesize)
        {
            NativeCalls.godot_icall_1_496(method_bind_10, Object.GetPtr(this), pagesize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_as_ratio");

        [GodotMethod("set_as_ratio")]
        [Obsolete("SetAsRatio is deprecated. Use the Ratio property instead.")]
        public void SetAsRatio(double value)
        {
            NativeCalls.godot_icall_1_496(method_bind_11, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_rounded_values");

        [GodotMethod("set_use_rounded_values")]
        [Obsolete("SetUseRoundedValues is deprecated. Use the Rounded property instead.")]
        public void SetUseRoundedValues(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_12, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_using_rounded_values");

        [GodotMethod("is_using_rounded_values")]
        [Obsolete("IsUsingRoundedValues is deprecated. Use the Rounded property instead.")]
        public bool IsUsingRoundedValues()
        {
            return NativeCalls.godot_icall_0_7(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_exp_ratio");

        [GodotMethod("set_exp_ratio")]
        [Obsolete("SetExpRatio is deprecated. Use the ExpEdit property instead.")]
        public void SetExpRatio(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_14, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_ratio_exp");

        [GodotMethod("is_ratio_exp")]
        [Obsolete("IsRatioExp is deprecated. Use the ExpEdit property instead.")]
        public bool IsRatioExp()
        {
            return NativeCalls.godot_icall_0_7(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_allow_greater");

        [GodotMethod("set_allow_greater")]
        [Obsolete("SetAllowGreater is deprecated. Use the AllowGreater property instead.")]
        public void SetAllowGreater(bool allow)
        {
            NativeCalls.godot_icall_1_16(method_bind_16, Object.GetPtr(this), allow);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_greater_allowed");

        [GodotMethod("is_greater_allowed")]
        [Obsolete("IsGreaterAllowed is deprecated. Use the AllowGreater property instead.")]
        public bool IsGreaterAllowed()
        {
            return NativeCalls.godot_icall_0_7(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_allow_lesser");

        [GodotMethod("set_allow_lesser")]
        [Obsolete("SetAllowLesser is deprecated. Use the AllowLesser property instead.")]
        public void SetAllowLesser(bool allow)
        {
            NativeCalls.godot_icall_1_16(method_bind_18, Object.GetPtr(this), allow);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_lesser_allowed");

        [GodotMethod("is_lesser_allowed")]
        [Obsolete("IsLesserAllowed is deprecated. Use the AllowLesser property instead.")]
        public bool IsLesserAllowed()
        {
            return NativeCalls.godot_icall_0_7(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "share");

        /// <summary>
        /// <para>Binds two <see cref="Godot.Range"/>s together along with any ranges previously grouped with either of them. When any of range's member variables change, it will share the new value with all other ranges in its group.</para>
        /// </summary>
        [GodotMethod("share")]
        public void Share(Node with)
        {
            NativeCalls.godot_icall_1_53(method_bind_20, Object.GetPtr(this), Object.GetPtr(with));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "unshare");

        /// <summary>
        /// <para>Stops the <see cref="Godot.Range"/> from sharing its member variables with any other.</para>
        /// </summary>
        [GodotMethod("unshare")]
        public void Unshare()
        {
            NativeCalls.godot_icall_0_3(method_bind_21, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
