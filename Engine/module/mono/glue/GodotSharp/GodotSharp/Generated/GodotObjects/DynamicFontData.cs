using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Used with <see cref="Godot.DynamicFont"/> to describe the location of a vector font file for dynamic rendering at runtime.</para>
    /// </summary>
    public partial class DynamicFontData : Resource
    {
        public enum HintingEnum
        {
            /// <summary>
            /// <para>Disables font hinting (smoother but less crisp).</para>
            /// </summary>
            None = 0,
            /// <summary>
            /// <para>Use the light font hinting mode.</para>
            /// </summary>
            Light = 1,
            /// <summary>
            /// <para>Use the default font hinting mode (crisper but less smooth).</para>
            /// </summary>
            Normal = 2
        }

        /// <summary>
        /// <para>If <c>true</c>, the font is rendered with anti-aliasing. This property applies both to the main font and its outline (if it has one).</para>
        /// </summary>
        public bool Antialiased
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsAntialiased();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAntialiased(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The font hinting mode used by FreeType. See <see cref="Godot.DynamicFontData.HintingEnum"/> for options.</para>
        /// </summary>
        public DynamicFontData.HintingEnum Hinting
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHinting();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHinting(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If set to a value greater than <c>0.0</c>, it will override default font oversampling, ignoring <see cref="Godot.SceneTree.UseFontOversampling"/> value and viewport stretch mode.</para>
        /// </summary>
        public float OverrideOversampling
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOverrideOversampling();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOverrideOversampling(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The path to the vector font file.</para>
        /// </summary>
        public string FontPath
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFontPath();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFontPath(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "DynamicFontData";

        public DynamicFontData() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_DynamicFontData_Ctor(this);
        }

        internal DynamicFontData(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_antialiased");

        [GodotMethod("set_antialiased")]
        [Obsolete("SetAntialiased is deprecated. Use the Antialiased property instead.")]
        public void SetAntialiased(bool antialiased)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), antialiased);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_antialiased");

        [GodotMethod("is_antialiased")]
        [Obsolete("IsAntialiased is deprecated. Use the Antialiased property instead.")]
        public bool IsAntialiased()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_font_path");

        [GodotMethod("set_font_path")]
        [Obsolete("SetFontPath is deprecated. Use the FontPath property instead.")]
        public void SetFontPath(string path)
        {
            NativeCalls.godot_icall_1_54(method_bind_2, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_font_path");

        [GodotMethod("get_font_path")]
        [Obsolete("GetFontPath is deprecated. Use the FontPath property instead.")]
        public string GetFontPath()
        {
            return NativeCalls.godot_icall_0_6(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_hinting");

        [GodotMethod("set_hinting")]
        [Obsolete("SetHinting is deprecated. Use the Hinting property instead.")]
        public void SetHinting(DynamicFontData.HintingEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_hinting");

        [GodotMethod("get_hinting")]
        [Obsolete("GetHinting is deprecated. Use the Hinting property instead.")]
        public DynamicFontData.HintingEnum GetHinting()
        {
            return (DynamicFontData.HintingEnum)NativeCalls.godot_icall_0_366(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_override_oversampling");

        [GodotMethod("get_override_oversampling")]
        [Obsolete("GetOverrideOversampling is deprecated. Use the OverrideOversampling property instead.")]
        public float GetOverrideOversampling()
        {
            return NativeCalls.godot_icall_0_14(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_override_oversampling");

        [GodotMethod("set_override_oversampling")]
        [Obsolete("SetOverrideOversampling is deprecated. Use the OverrideOversampling property instead.")]
        public void SetOverrideOversampling(float oversampling)
        {
            NativeCalls.godot_icall_1_15(method_bind_7, Object.GetPtr(this), oversampling);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
