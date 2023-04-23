using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This <see cref="Godot.Control"/> node is used in the editor's Inspector dock to allow editing of numeric values. Can be used with <see cref="Godot.EditorInspectorPlugin"/> to recreate the same behavior.</para>
    /// </summary>
    public partial class EditorSpinSlider : Range
    {
        public string Label
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLabel();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLabel(value);
            }
#pragma warning restore CS0618
        }

        public bool ReadOnly
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsReadOnly();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetReadOnly(value);
            }
#pragma warning restore CS0618
        }

        public bool Flat
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsFlat();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlat(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the slider is hidden.</para>
        /// </summary>
        public bool HideSlider
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsHidingSlider();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHideSlider(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "EditorSpinSlider";

        public EditorSpinSlider() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_EditorSpinSlider_Ctor(this);
        }

        internal EditorSpinSlider(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_label");

        [GodotMethod("set_label")]
        [Obsolete("SetLabel is deprecated. Use the Label property instead.")]
        public void SetLabel(string label)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), label);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_label");

        [GodotMethod("get_label")]
        [Obsolete("GetLabel is deprecated. Use the Label property instead.")]
        public string GetLabel()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_read_only");

        [GodotMethod("set_read_only")]
        [Obsolete("SetReadOnly is deprecated. Use the ReadOnly property instead.")]
        public void SetReadOnly(bool readOnly)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), readOnly);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_read_only");

        [GodotMethod("is_read_only")]
        [Obsolete("IsReadOnly is deprecated. Use the ReadOnly property instead.")]
        public bool IsReadOnly()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flat");

        [GodotMethod("set_flat")]
        [Obsolete("SetFlat is deprecated. Use the Flat property instead.")]
        public void SetFlat(bool flat)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), flat);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_flat");

        [GodotMethod("is_flat")]
        [Obsolete("IsFlat is deprecated. Use the Flat property instead.")]
        public bool IsFlat()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_hide_slider");

        [GodotMethod("set_hide_slider")]
        [Obsolete("SetHideSlider is deprecated. Use the HideSlider property instead.")]
        public void SetHideSlider(bool hideSlider)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), hideSlider);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_hiding_slider");

        [GodotMethod("is_hiding_slider")]
        [Obsolete("IsHidingSlider is deprecated. Use the HideSlider property instead.")]
        public bool IsHidingSlider()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
