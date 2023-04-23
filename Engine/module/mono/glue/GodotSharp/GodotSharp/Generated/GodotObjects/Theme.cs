using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A theme for skinning controls. Controls can be skinned individually, but for complex applications, it's more practical to just create a global theme that defines everything. This theme can be applied to any <see cref="Godot.Control"/>; the Control and its children will automatically use it.</para>
    /// <para>Theme resources can alternatively be loaded by writing them in a <c>.theme</c> file, see the documentation for more information.</para>
    /// </summary>
    public partial class Theme : Resource
    {
        public enum DataType
        {
            /// <summary>
            /// <para>Theme's <see cref="Godot.Color"/> item type.</para>
            /// </summary>
            Color = 0,
            /// <summary>
            /// <para>Theme's constant item type.</para>
            /// </summary>
            Constant = 1,
            /// <summary>
            /// <para>Theme's <see cref="Godot.Font"/> item type.</para>
            /// </summary>
            Font = 2,
            /// <summary>
            /// <para>Theme's icon <see cref="Godot.Texture"/> item type.</para>
            /// </summary>
            Icon = 3,
            /// <summary>
            /// <para>Theme's <see cref="Godot.StyleBox"/> item type.</para>
            /// </summary>
            Stylebox = 4,
            /// <summary>
            /// <para>Maximum value for the DataType enum.</para>
            /// </summary>
            Max = 5
        }

        /// <summary>
        /// <para>The default font of this <see cref="Godot.Theme"/> resource. Used as a fallback value for font items defined in this theme, but having invalid values. If this value is also invalid, the global default value is used.</para>
        /// <para>Use <see cref="Godot.Theme.HasDefaultFont"/> to check if this value is valid.</para>
        /// </summary>
        public Font DefaultFont
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDefaultFont();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDefaultFont(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Theme";

        public Theme() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Theme_Ctor(this);
        }

        internal Theme(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_icon");

        /// <summary>
        /// <para>Sets the theme's icon <see cref="Godot.Texture"/> to <c>texture</c> at <c>name</c> in <c>theme_type</c>.</para>
        /// <para>Creates <c>theme_type</c> if the theme does not have it.</para>
        /// </summary>
        [GodotMethod("set_icon")]
        public void SetIcon(string name, string themeType, Texture texture)
        {
            NativeCalls.godot_icall_3_117(method_bind_0, Object.GetPtr(this), name, themeType, Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_icon");

        /// <summary>
        /// <para>Returns the icon <see cref="Godot.Texture"/> at <c>name</c> if the theme has <c>theme_type</c>.</para>
        /// </summary>
        [GodotMethod("get_icon")]
        public Texture GetIcon(string name, string themeType)
        {
            return NativeCalls.godot_icall_2_317(method_bind_1, Object.GetPtr(this), name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_icon");

        /// <summary>
        /// <para>Returns <c>true</c> if icon <see cref="Godot.Texture"/> with <c>name</c> is in <c>theme_type</c>.</para>
        /// <para>Returns <c>false</c> if the theme does not have <c>theme_type</c>.</para>
        /// </summary>
        [GodotMethod("has_icon")]
        public bool HasIcon(string name, string themeType)
        {
            return NativeCalls.godot_icall_2_116(method_bind_2, Object.GetPtr(this), name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rename_icon");

        /// <summary>
        /// <para>Renames the icon at <c>old_name</c> to <c>name</c> if the theme has <c>theme_type</c>. If <c>name</c> is already taken, this method fails.</para>
        /// </summary>
        [GodotMethod("rename_icon")]
        public void RenameIcon(string oldName, string name, string themeType)
        {
            NativeCalls.godot_icall_3_932(method_bind_3, Object.GetPtr(this), oldName, name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_icon");

        /// <summary>
        /// <para>Clears the icon at <c>name</c> if the theme has <c>theme_type</c>.</para>
        /// </summary>
        [GodotMethod("clear_icon")]
        public void ClearIcon(string name, string themeType)
        {
            NativeCalls.godot_icall_2_107(method_bind_4, Object.GetPtr(this), name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_icon_list");

        /// <summary>
        /// <para>Returns all the icons as a <see cref="string"/> filled with each <see cref="Godot.Texture"/>'s name, for use in <see cref="Godot.Theme.GetIcon"/>, if the theme has <c>theme_type</c>.</para>
        /// </summary>
        [GodotMethod("get_icon_list")]
        public string[] GetIconList(string themeType)
        {
            return NativeCalls.godot_icall_1_309(method_bind_5, Object.GetPtr(this), themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_icon_types");

        /// <summary>
        /// <para>Returns all the icon types as a <see cref="string"/> filled with unique type names, for use in <see cref="Godot.Theme.GetIcon"/> and/or <see cref="Godot.Theme.GetIconList"/>.</para>
        /// </summary>
        [GodotMethod("get_icon_types")]
        public string[] GetIconTypes()
        {
            return NativeCalls.godot_icall_0_119(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_stylebox");

        /// <summary>
        /// <para>Sets theme's <see cref="Godot.StyleBox"/> to <c>stylebox</c> at <c>name</c> in <c>theme_type</c>.</para>
        /// <para>Creates <c>theme_type</c> if the theme does not have it.</para>
        /// </summary>
        [GodotMethod("set_stylebox")]
        public void SetStylebox(string name, string themeType, StyleBox texture)
        {
            NativeCalls.godot_icall_3_117(method_bind_7, Object.GetPtr(this), name, themeType, Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stylebox");

        /// <summary>
        /// <para>Returns the <see cref="Godot.StyleBox"/> at <c>name</c> if the theme has <c>theme_type</c>.</para>
        /// <para>Valid <c>name</c>s may be found using <see cref="Godot.Theme.GetStyleboxList"/>. Valid <c>theme_type</c>s may be found using <see cref="Godot.Theme.GetStyleboxTypes"/>.</para>
        /// </summary>
        [GodotMethod("get_stylebox")]
        public StyleBox GetStylebox(string name, string themeType)
        {
            return NativeCalls.godot_icall_2_318(method_bind_8, Object.GetPtr(this), name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_stylebox");

        /// <summary>
        /// <para>Returns <c>true</c> if <see cref="Godot.StyleBox"/> with <c>name</c> is in <c>theme_type</c>.</para>
        /// <para>Returns <c>false</c> if the theme does not have <c>theme_type</c>.</para>
        /// </summary>
        [GodotMethod("has_stylebox")]
        public bool HasStylebox(string name, string themeType)
        {
            return NativeCalls.godot_icall_2_116(method_bind_9, Object.GetPtr(this), name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rename_stylebox");

        /// <summary>
        /// <para>Renames <see cref="Godot.StyleBox"/> at <c>old_name</c> to <c>name</c> if the theme has <c>theme_type</c>. If <c>name</c> is already taken, this method fails.</para>
        /// </summary>
        [GodotMethod("rename_stylebox")]
        public void RenameStylebox(string oldName, string name, string themeType)
        {
            NativeCalls.godot_icall_3_932(method_bind_10, Object.GetPtr(this), oldName, name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_stylebox");

        /// <summary>
        /// <para>Clears <see cref="Godot.StyleBox"/> at <c>name</c> if the theme has <c>theme_type</c>.</para>
        /// </summary>
        [GodotMethod("clear_stylebox")]
        public void ClearStylebox(string name, string themeType)
        {
            NativeCalls.godot_icall_2_107(method_bind_11, Object.GetPtr(this), name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stylebox_list");

        /// <summary>
        /// <para>Returns all the <see cref="Godot.StyleBox"/>s as a <see cref="string"/> filled with each <see cref="Godot.StyleBox"/>'s name, for use in <see cref="Godot.Theme.GetStylebox"/>, if the theme has <c>theme_type</c>.</para>
        /// <para>Valid <c>theme_type</c>s may be found using <see cref="Godot.Theme.GetStyleboxTypes"/>.</para>
        /// </summary>
        [GodotMethod("get_stylebox_list")]
        public string[] GetStyleboxList(string themeType)
        {
            return NativeCalls.godot_icall_1_309(method_bind_12, Object.GetPtr(this), themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stylebox_types");

        /// <summary>
        /// <para>Returns all the <see cref="Godot.StyleBox"/> types as a <see cref="string"/> filled with unique type names, for use in <see cref="Godot.Theme.GetStylebox"/> and/or <see cref="Godot.Theme.GetStyleboxList"/>.</para>
        /// </summary>
        [GodotMethod("get_stylebox_types")]
        public string[] GetStyleboxTypes()
        {
            return NativeCalls.godot_icall_0_119(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_font");

        /// <summary>
        /// <para>Sets the theme's <see cref="Godot.Font"/> to <c>font</c> at <c>name</c> in <c>theme_type</c>.</para>
        /// <para>Creates <c>theme_type</c> if the theme does not have it.</para>
        /// </summary>
        [GodotMethod("set_font")]
        public void SetFont(string name, string themeType, Font font)
        {
            NativeCalls.godot_icall_3_117(method_bind_14, Object.GetPtr(this), name, themeType, Object.GetPtr(font));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_font");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Font"/> at <c>name</c> if the theme has <c>theme_type</c>. If such item does not exist and <see cref="Godot.Theme.DefaultFont"/> is set on the theme, the default font will be returned.</para>
        /// </summary>
        [GodotMethod("get_font")]
        public Font GetFont(string name, string themeType)
        {
            return NativeCalls.godot_icall_2_319(method_bind_15, Object.GetPtr(this), name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_font");

        /// <summary>
        /// <para>Returns <c>true</c> if <see cref="Godot.Font"/> with <c>name</c> is in <c>theme_type</c>.</para>
        /// <para>Returns <c>false</c> if the theme does not have <c>theme_type</c>.</para>
        /// </summary>
        [GodotMethod("has_font")]
        public bool HasFont(string name, string themeType)
        {
            return NativeCalls.godot_icall_2_116(method_bind_16, Object.GetPtr(this), name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rename_font");

        /// <summary>
        /// <para>Renames the <see cref="Godot.Font"/> at <c>old_name</c> to <c>name</c> if the theme has <c>theme_type</c>. If <c>name</c> is already taken, this method fails.</para>
        /// </summary>
        [GodotMethod("rename_font")]
        public void RenameFont(string oldName, string name, string themeType)
        {
            NativeCalls.godot_icall_3_932(method_bind_17, Object.GetPtr(this), oldName, name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_font");

        /// <summary>
        /// <para>Clears the <see cref="Godot.Font"/> at <c>name</c> if the theme has <c>theme_type</c>.</para>
        /// </summary>
        [GodotMethod("clear_font")]
        public void ClearFont(string name, string themeType)
        {
            NativeCalls.godot_icall_2_107(method_bind_18, Object.GetPtr(this), name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_font_list");

        /// <summary>
        /// <para>Returns all the <see cref="Godot.Font"/>s as a <see cref="string"/> filled with each <see cref="Godot.Font"/>'s name, for use in <see cref="Godot.Theme.GetFont"/>, if the theme has <c>theme_type</c>.</para>
        /// </summary>
        [GodotMethod("get_font_list")]
        public string[] GetFontList(string themeType)
        {
            return NativeCalls.godot_icall_1_309(method_bind_19, Object.GetPtr(this), themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_font_types");

        /// <summary>
        /// <para>Returns all the <see cref="Godot.Font"/> types as a <see cref="string"/> filled with unique type names, for use in <see cref="Godot.Theme.GetFont"/> and/or <see cref="Godot.Theme.GetFontList"/>.</para>
        /// </summary>
        [GodotMethod("get_font_types")]
        public string[] GetFontTypes()
        {
            return NativeCalls.godot_icall_0_119(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_color");

        /// <summary>
        /// <para>Sets the theme's <see cref="Godot.Color"/> to <c>color</c> at <c>name</c> in <c>theme_type</c>.</para>
        /// <para>Creates <c>theme_type</c> if the theme does not have it.</para>
        /// </summary>
        [GodotMethod("set_color")]
        public void SetColor(string name, string themeType, Color color)
        {
            NativeCalls.godot_icall_3_933(method_bind_21, Object.GetPtr(this), name, themeType, ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_color");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Color"/> at <c>name</c> if the theme has <c>theme_type</c>.</para>
        /// </summary>
        [GodotMethod("get_color")]
        public Color GetColor(string name, string themeType)
        {
            NativeCalls.godot_icall_2_320(method_bind_22, Object.GetPtr(this), name, themeType, out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_color");

        /// <summary>
        /// <para>Returns <c>true</c> if <see cref="Godot.Color"/> with <c>name</c> is in <c>theme_type</c>.</para>
        /// <para>Returns <c>false</c> if the theme does not have <c>theme_type</c>.</para>
        /// </summary>
        [GodotMethod("has_color")]
        public bool HasColor(string name, string themeType)
        {
            return NativeCalls.godot_icall_2_116(method_bind_23, Object.GetPtr(this), name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rename_color");

        /// <summary>
        /// <para>Renames the <see cref="Godot.Color"/> at <c>old_name</c> to <c>name</c> if the theme has <c>theme_type</c>. If <c>name</c> is already taken, this method fails.</para>
        /// </summary>
        [GodotMethod("rename_color")]
        public void RenameColor(string oldName, string name, string themeType)
        {
            NativeCalls.godot_icall_3_932(method_bind_24, Object.GetPtr(this), oldName, name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_color");

        /// <summary>
        /// <para>Clears the <see cref="Godot.Color"/> at <c>name</c> if the theme has <c>theme_type</c>.</para>
        /// </summary>
        [GodotMethod("clear_color")]
        public void ClearColor(string name, string themeType)
        {
            NativeCalls.godot_icall_2_107(method_bind_25, Object.GetPtr(this), name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_color_list");

        /// <summary>
        /// <para>Returns all the <see cref="Godot.Color"/>s as a <see cref="string"/> filled with each <see cref="Godot.Color"/>'s name, for use in <see cref="Godot.Theme.GetColor"/>, if the theme has <c>theme_type</c>.</para>
        /// </summary>
        [GodotMethod("get_color_list")]
        public string[] GetColorList(string themeType)
        {
            return NativeCalls.godot_icall_1_309(method_bind_26, Object.GetPtr(this), themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_color_types");

        /// <summary>
        /// <para>Returns all the <see cref="Godot.Color"/> types as a <see cref="string"/> filled with unique type names, for use in <see cref="Godot.Theme.GetColor"/> and/or <see cref="Godot.Theme.GetColorList"/>.</para>
        /// </summary>
        [GodotMethod("get_color_types")]
        public string[] GetColorTypes()
        {
            return NativeCalls.godot_icall_0_119(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_constant");

        /// <summary>
        /// <para>Sets the theme's constant to <c>constant</c> at <c>name</c> in <c>theme_type</c>.</para>
        /// <para>Creates <c>theme_type</c> if the theme does not have it.</para>
        /// </summary>
        [GodotMethod("set_constant")]
        public void SetConstant(string name, string themeType, int constant)
        {
            NativeCalls.godot_icall_3_803(method_bind_28, Object.GetPtr(this), name, themeType, constant);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_constant");

        /// <summary>
        /// <para>Returns the constant at <c>name</c> if the theme has <c>theme_type</c>.</para>
        /// </summary>
        [GodotMethod("get_constant")]
        public int GetConstant(string name, string themeType)
        {
            return NativeCalls.godot_icall_2_321(method_bind_29, Object.GetPtr(this), name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_constant");

        /// <summary>
        /// <para>Returns <c>true</c> if constant with <c>name</c> is in <c>theme_type</c>.</para>
        /// <para>Returns <c>false</c> if the theme does not have <c>theme_type</c>.</para>
        /// </summary>
        [GodotMethod("has_constant")]
        public bool HasConstant(string name, string themeType)
        {
            return NativeCalls.godot_icall_2_116(method_bind_30, Object.GetPtr(this), name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rename_constant");

        /// <summary>
        /// <para>Renames the constant at <c>old_name</c> to <c>name</c> if the theme has <c>theme_type</c>. If <c>name</c> is already taken, this method fails.</para>
        /// </summary>
        [GodotMethod("rename_constant")]
        public void RenameConstant(string oldName, string name, string themeType)
        {
            NativeCalls.godot_icall_3_932(method_bind_31, Object.GetPtr(this), oldName, name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_constant");

        /// <summary>
        /// <para>Clears the constant at <c>name</c> if the theme has <c>theme_type</c>.</para>
        /// </summary>
        [GodotMethod("clear_constant")]
        public void ClearConstant(string name, string themeType)
        {
            NativeCalls.godot_icall_2_107(method_bind_32, Object.GetPtr(this), name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_constant_list");

        /// <summary>
        /// <para>Returns all the constants as a <see cref="string"/> filled with each constant's name, for use in <see cref="Godot.Theme.GetConstant"/>, if the theme has <c>theme_type</c>.</para>
        /// </summary>
        [GodotMethod("get_constant_list")]
        public string[] GetConstantList(string themeType)
        {
            return NativeCalls.godot_icall_1_309(method_bind_33, Object.GetPtr(this), themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_constant_types");

        /// <summary>
        /// <para>Returns all the constant types as a <see cref="string"/> filled with unique type names, for use in <see cref="Godot.Theme.GetConstant"/> and/or <see cref="Godot.Theme.GetConstantList"/>.</para>
        /// </summary>
        [GodotMethod("get_constant_types")]
        public string[] GetConstantTypes()
        {
            return NativeCalls.godot_icall_0_119(method_bind_34, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_default_font");

        [GodotMethod("set_default_font")]
        [Obsolete("SetDefaultFont is deprecated. Use the DefaultFont property instead.")]
        public void SetDefaultFont(Font font)
        {
            NativeCalls.godot_icall_1_24(method_bind_35, Object.GetPtr(this), Object.GetPtr(font));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_default_font");

        [GodotMethod("get_default_font")]
        [Obsolete("GetDefaultFont is deprecated. Use the DefaultFont property instead.")]
        public Font GetDefaultFont()
        {
            return NativeCalls.godot_icall_0_322(method_bind_36, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_default_font");

        /// <summary>
        /// <para>Returns <c>true</c> if this theme has a valid <see cref="Godot.Theme.DefaultFont"/> value.</para>
        /// </summary>
        [GodotMethod("has_default_font")]
        public bool HasDefaultFont()
        {
            return NativeCalls.godot_icall_0_7(method_bind_37, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_theme_item");

        /// <summary>
        /// <para>Sets the theme item of <c>data_type</c> to <c>value</c> at <c>name</c> in <c>theme_type</c>.</para>
        /// <para>Does nothing if the <c>value</c> type does not match <c>data_type</c>.</para>
        /// <para>Creates <c>theme_type</c> if the theme does not have it.</para>
        /// </summary>
        [GodotMethod("set_theme_item")]
        public void SetThemeItem(Theme.DataType dataType, string name, string themeType, object value)
        {
            NativeCalls.godot_icall_4_934(method_bind_38, Object.GetPtr(this), (int)dataType, name, themeType, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_theme_item");

        /// <summary>
        /// <para>Returns the theme item of <c>data_type</c> at <c>name</c> if the theme has <c>theme_type</c>.</para>
        /// <para>Valid <c>name</c>s may be found using <see cref="Godot.Theme.GetThemeItemList"/> or a data type specific method. Valid <c>theme_type</c>s may be found using <see cref="Godot.Theme.GetThemeItemTypes"/> or a data type specific method.</para>
        /// </summary>
        [GodotMethod("get_theme_item")]
        public object GetThemeItem(Theme.DataType dataType, string name, string themeType)
        {
            return NativeCalls.godot_icall_3_935(method_bind_39, Object.GetPtr(this), (int)dataType, name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_theme_item");

        /// <summary>
        /// <para>Returns <c>true</c> if a theme item of <c>data_type</c> with <c>name</c> is in <c>theme_type</c>.</para>
        /// <para>Returns <c>false</c> if the theme does not have <c>theme_type</c>.</para>
        /// </summary>
        [GodotMethod("has_theme_item")]
        public bool HasThemeItem(Theme.DataType dataType, string name, string themeType)
        {
            return NativeCalls.godot_icall_3_936(method_bind_40, Object.GetPtr(this), (int)dataType, name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rename_theme_item");

        /// <summary>
        /// <para>Renames the theme item of <c>data_type</c> at <c>old_name</c> to <c>name</c> if the theme has <c>theme_type</c>. If <c>name</c> is already taken, this method fails.</para>
        /// </summary>
        [GodotMethod("rename_theme_item")]
        public void RenameThemeItem(Theme.DataType dataType, string oldName, string name, string themeType)
        {
            NativeCalls.godot_icall_4_937(method_bind_41, Object.GetPtr(this), (int)dataType, oldName, name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_theme_item");

        /// <summary>
        /// <para>Clears the theme item of <c>data_type</c> at <c>name</c> if the theme has <c>theme_type</c>.</para>
        /// </summary>
        [GodotMethod("clear_theme_item")]
        public void ClearThemeItem(Theme.DataType dataType, string name, string themeType)
        {
            NativeCalls.godot_icall_3_938(method_bind_42, Object.GetPtr(this), (int)dataType, name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_theme_item_list");

        /// <summary>
        /// <para>Returns all the theme items of <c>data_type</c> as a <see cref="string"/> filled with each theme items's name, for use in <see cref="Godot.Theme.GetThemeItem"/> or a data type specific method, if the theme has <c>theme_type</c>.</para>
        /// <para>Valid <c>theme_type</c>s may be found using <see cref="Godot.Theme.GetThemeItemTypes"/> or a data type specific method.</para>
        /// </summary>
        [GodotMethod("get_theme_item_list")]
        public string[] GetThemeItemList(Theme.DataType dataType, string themeType)
        {
            return NativeCalls.godot_icall_2_939(method_bind_43, Object.GetPtr(this), (int)dataType, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_theme_item_types");

        /// <summary>
        /// <para>Returns all the theme items of <c>data_type</c> types as a <see cref="string"/> filled with unique type names, for use in <see cref="Godot.Theme.GetThemeItem"/>, <see cref="Godot.Theme.GetThemeItemList"/> or data type specific methods.</para>
        /// </summary>
        [GodotMethod("get_theme_item_types")]
        public string[] GetThemeItemTypes(Theme.DataType dataType)
        {
            return NativeCalls.godot_icall_1_832(method_bind_44, Object.GetPtr(this), (int)dataType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_type_variation");

        /// <summary>
        /// <para>Marks <c>theme_type</c> as a variation of <c>base_type</c>.</para>
        /// <para>This adds <c>theme_type</c> as a suggested option for <see cref="Godot.Control.ThemeTypeVariation"/> on a <see cref="Godot.Control"/> that is of the <c>base_type</c> class.</para>
        /// <para>Variations can also be nested, i.e. <c>base_type</c> can be another variation. If a chain of variations ends with a <c>base_type</c> matching the class of the <see cref="Godot.Control"/>, the whole chain is going to be suggested as options.</para>
        /// <para>Note: Suggestions only show up if this theme resource is set as the project default theme. See .</para>
        /// </summary>
        [GodotMethod("set_type_variation")]
        public void SetTypeVariation(string themeType, string baseType)
        {
            NativeCalls.godot_icall_2_107(method_bind_45, Object.GetPtr(this), themeType, baseType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_type_variation");

        /// <summary>
        /// <para>Returns <c>true</c> if <c>theme_type</c> is marked as a variation of <c>base_type</c>.</para>
        /// </summary>
        [GodotMethod("is_type_variation")]
        public bool IsTypeVariation(string themeType, string baseType)
        {
            return NativeCalls.godot_icall_2_116(method_bind_46, Object.GetPtr(this), themeType, baseType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_type_variation");

        /// <summary>
        /// <para>Unmarks <c>theme_type</c> as being a variation of another theme type. See <see cref="Godot.Theme.SetTypeVariation"/>.</para>
        /// </summary>
        [GodotMethod("clear_type_variation")]
        public void ClearTypeVariation(string themeType)
        {
            NativeCalls.godot_icall_1_54(method_bind_47, Object.GetPtr(this), themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_type_variation_base");

        /// <summary>
        /// <para>Returns the name of the base theme type if <c>theme_type</c> is a valid variation type. Returns an empty string otherwise.</para>
        /// </summary>
        [GodotMethod("get_type_variation_base")]
        public string GetTypeVariationBase(string themeType)
        {
            return NativeCalls.godot_icall_1_124(method_bind_48, Object.GetPtr(this), themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_type_variation_list");

        /// <summary>
        /// <para>Returns a list of all type variations for the given <c>base_type</c>.</para>
        /// </summary>
        [GodotMethod("get_type_variation_list")]
        public string[] GetTypeVariationList(string baseType)
        {
            return NativeCalls.godot_icall_1_309(method_bind_49, Object.GetPtr(this), baseType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_type");

        /// <summary>
        /// <para>Adds an empty theme type for every valid data type.</para>
        /// <para>Note: Empty types are not saved with the theme. This method only exists to perform in-memory changes to the resource. Use available <c>set_*</c> methods to add theme items.</para>
        /// </summary>
        [GodotMethod("add_type")]
        public void AddType(string themeType)
        {
            NativeCalls.godot_icall_1_54(method_bind_50, Object.GetPtr(this), themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_type");

        /// <summary>
        /// <para>Removes the theme type, gracefully discarding defined theme items. If the type is a variation, this information is also erased. If the type is a base for type variations, those variations lose their base.</para>
        /// </summary>
        [GodotMethod("remove_type")]
        public void RemoveType(string themeType)
        {
            NativeCalls.godot_icall_1_54(method_bind_51, Object.GetPtr(this), themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_type_list");

        /// <summary>
        /// <para>Returns all the theme types as a <see cref="string"/> filled with unique type names, for use in other <c>get_*</c> functions of this theme.</para>
        /// <para>Note: <c>theme_type</c> has no effect and will be removed in future version.</para>
        /// </summary>
        [GodotMethod("get_type_list")]
        public string[] GetTypeList(string themeType)
        {
            return NativeCalls.godot_icall_1_309(method_bind_52, Object.GetPtr(this), themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_53 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "copy_default_theme");

        /// <summary>
        /// <para>Sets the theme's values to a copy of the default theme values.</para>
        /// </summary>
        [GodotMethod("copy_default_theme")]
        public void CopyDefaultTheme()
        {
            NativeCalls.godot_icall_0_3(method_bind_53, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_54 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "copy_theme");

        /// <summary>
        /// <para>Sets the theme's values to a copy of a given theme.</para>
        /// </summary>
        [GodotMethod("copy_theme")]
        public void CopyTheme(Theme other)
        {
            NativeCalls.godot_icall_1_24(method_bind_54, Object.GetPtr(this), Object.GetPtr(other));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_55 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "merge_with");

        /// <summary>
        /// <para>Adds missing and overrides existing definitions with values from the <c>other</c> <see cref="Godot.Theme"/>.</para>
        /// <para>Note: This modifies the current theme. If you want to merge two themes together without modifying either one, create a new empty theme and merge the other two into it one after another.</para>
        /// </summary>
        [GodotMethod("merge_with")]
        public void MergeWith(Theme other)
        {
            NativeCalls.godot_icall_1_24(method_bind_55, Object.GetPtr(this), Object.GetPtr(other));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_56 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Clears all values on the theme.</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_56, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
