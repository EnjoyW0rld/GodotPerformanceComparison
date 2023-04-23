using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Server that manages all translations. Translations can be set to it and removed from it.</para>
    /// </summary>
    public static partial class TranslationServer
    {
        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(TranslationServer).Name);
                return singleton;
            }
        }

        private const string nativeName = "TranslationServer";
        internal static IntPtr ptr = NativeCalls.godot_icall_TranslationServer_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_locale");

        /// <summary>
        /// <para>Sets the locale of the project. The <c>locale</c> string will be standardized to match known locales (e.g. <c>en-US</c> would be matched to <c>en_US</c>).</para>
        /// <para>If translations have been loaded beforehand for the new locale, they will be applied.</para>
        /// </summary>
        [GodotMethod("set_locale")]
        public static void SetLocale(string locale)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, ptr, locale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_locale");

        /// <summary>
        /// <para>Returns the current locale of the project.</para>
        /// <para>See also <see cref="Godot.OS.GetLocale"/> and <see cref="Godot.OS.GetLocaleLanguage"/> to query the locale of the user system.</para>
        /// </summary>
        [GodotMethod("get_locale")]
        public static string GetLocale()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_locale_name");

        /// <summary>
        /// <para>Returns a locale's language and its variant (e.g. <c>"en_US"</c> would return <c>"English (United States)"</c>).</para>
        /// </summary>
        [GodotMethod("get_locale_name")]
        public static string GetLocaleName(string locale)
        {
            return NativeCalls.godot_icall_1_124(method_bind_2, ptr, locale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "translate");

        /// <summary>
        /// <para>Returns the current locale's translation for the given message (key).</para>
        /// </summary>
        [GodotMethod("translate")]
        public static string Translate(string message)
        {
            return NativeCalls.godot_icall_1_124(method_bind_3, ptr, message);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_translation");

        /// <summary>
        /// <para>Adds a <see cref="Godot.Translation"/> resource.</para>
        /// </summary>
        [GodotMethod("add_translation")]
        public static void AddTranslation(Translation translation)
        {
            NativeCalls.godot_icall_1_24(method_bind_4, ptr, Object.GetPtr(translation));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_translation");

        /// <summary>
        /// <para>Removes the given translation from the server.</para>
        /// </summary>
        [GodotMethod("remove_translation")]
        public static void RemoveTranslation(Translation translation)
        {
            NativeCalls.godot_icall_1_24(method_bind_5, ptr, Object.GetPtr(translation));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Clears the server from all translations.</para>
        /// </summary>
        [GodotMethod("clear")]
        public static void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_6, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_loaded_locales");

        /// <summary>
        /// <para>Returns an array of all loaded locales of the project.</para>
        /// </summary>
        [GodotMethod("get_loaded_locales")]
        public static Godot.Collections.Array GetLoadedLocales()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_7, ptr));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
