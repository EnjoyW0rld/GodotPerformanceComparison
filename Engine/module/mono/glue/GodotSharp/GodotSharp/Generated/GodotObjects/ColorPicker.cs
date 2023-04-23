using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Displays a color picker widget. Useful for selecting a color from an RGB/RGBA colorspace.</para>
    /// <para>Note: This control is the color picker widget itself. You can use a <see cref="Godot.ColorPickerButton"/> instead if you need a button that brings up a <see cref="Godot.ColorPicker"/> in a pop-up.</para>
    /// </summary>
    public partial class ColorPicker : BoxContainer
    {
        /// <summary>
        /// <para>The currently selected color.</para>
        /// </summary>
        public Color Color
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPickColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPickColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, shows an alpha channel slider (opacity).</para>
        /// </summary>
        public bool EditAlpha
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsEditingAlpha();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEditAlpha(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, allows editing the color with Hue/Saturation/Value sliders.</para>
        /// <para>Note: Cannot be enabled if raw mode is on.</para>
        /// </summary>
        public bool HsvMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsHsvMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHsvMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, allows the color R, G, B component values to go beyond 1.0, which can be used for certain special operations that require it (like tinting without darkening or rendering sprites in HDR).</para>
        /// <para>Note: Cannot be enabled if HSV mode is on.</para>
        /// </summary>
        public bool RawMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsRawMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRawMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the color will apply only after the user releases the mouse button, otherwise it will apply immediately even in mouse motion event (which can cause performance issues).</para>
        /// </summary>
        public bool DeferredMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDeferredMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDeferredMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the "add preset" button is enabled.</para>
        /// </summary>
        public bool PresetsEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return ArePresetsEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPresetsEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, saved color presets are visible.</para>
        /// </summary>
        public bool PresetsVisible
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return ArePresetsVisible();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPresetsVisible(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ColorPicker";

        public ColorPicker() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ColorPicker_Ctor(this);
        }

        internal ColorPicker(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pick_color");

        [GodotMethod("set_pick_color")]
        [Obsolete("SetPickColor is deprecated. Use the Color property instead.")]
        public void SetPickColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_0, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pick_color");

        [GodotMethod("get_pick_color")]
        [Obsolete("GetPickColor is deprecated. Use the Color property instead.")]
        public Color GetPickColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_1, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_hsv_mode");

        [GodotMethod("set_hsv_mode")]
        [Obsolete("SetHsvMode is deprecated. Use the HsvMode property instead.")]
        public void SetHsvMode(bool mode)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_hsv_mode");

        [GodotMethod("is_hsv_mode")]
        [Obsolete("IsHsvMode is deprecated. Use the HsvMode property instead.")]
        public bool IsHsvMode()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_raw_mode");

        [GodotMethod("set_raw_mode")]
        [Obsolete("SetRawMode is deprecated. Use the RawMode property instead.")]
        public void SetRawMode(bool mode)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_raw_mode");

        [GodotMethod("is_raw_mode")]
        [Obsolete("IsRawMode is deprecated. Use the RawMode property instead.")]
        public bool IsRawMode()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_deferred_mode");

        [GodotMethod("set_deferred_mode")]
        [Obsolete("SetDeferredMode is deprecated. Use the DeferredMode property instead.")]
        public void SetDeferredMode(bool mode)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_deferred_mode");

        [GodotMethod("is_deferred_mode")]
        [Obsolete("IsDeferredMode is deprecated. Use the DeferredMode property instead.")]
        public bool IsDeferredMode()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_edit_alpha");

        [GodotMethod("set_edit_alpha")]
        [Obsolete("SetEditAlpha is deprecated. Use the EditAlpha property instead.")]
        public void SetEditAlpha(bool show)
        {
            NativeCalls.godot_icall_1_16(method_bind_8, Object.GetPtr(this), show);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_editing_alpha");

        [GodotMethod("is_editing_alpha")]
        [Obsolete("IsEditingAlpha is deprecated. Use the EditAlpha property instead.")]
        public bool IsEditingAlpha()
        {
            return NativeCalls.godot_icall_0_7(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_presets_enabled");

        [GodotMethod("set_presets_enabled")]
        [Obsolete("SetPresetsEnabled is deprecated. Use the PresetsEnabled property instead.")]
        public void SetPresetsEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "are_presets_enabled");

        [GodotMethod("are_presets_enabled")]
        [Obsolete("ArePresetsEnabled is deprecated. Use the PresetsEnabled property instead.")]
        public bool ArePresetsEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_presets_visible");

        [GodotMethod("set_presets_visible")]
        [Obsolete("SetPresetsVisible is deprecated. Use the PresetsVisible property instead.")]
        public void SetPresetsVisible(bool visible)
        {
            NativeCalls.godot_icall_1_16(method_bind_12, Object.GetPtr(this), visible);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "are_presets_visible");

        [GodotMethod("are_presets_visible")]
        [Obsolete("ArePresetsVisible is deprecated. Use the PresetsVisible property instead.")]
        public bool ArePresetsVisible()
        {
            return NativeCalls.godot_icall_0_7(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_preset");

        /// <summary>
        /// <para>Adds the given color to a list of color presets. The presets are displayed in the color picker and the user will be able to select them.</para>
        /// <para>Note: The presets list is only for this color picker.</para>
        /// </summary>
        [GodotMethod("add_preset")]
        public void AddPreset(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_14, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "erase_preset");

        /// <summary>
        /// <para>Removes the given color from the list of color presets of this color picker.</para>
        /// </summary>
        [GodotMethod("erase_preset")]
        public void ErasePreset(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_15, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_presets");

        /// <summary>
        /// <para>Returns the list of colors in the presets of the color picker.</para>
        /// </summary>
        [GodotMethod("get_presets")]
        public Color[] GetPresets()
        {
            return NativeCalls.godot_icall_0_232(method_bind_16, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
