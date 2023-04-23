using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Provides data transformation and encoding utility functions.</para>
    /// </summary>
    public static partial class Marshalls
    {
        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(Marshalls).Name);
                return singleton;
            }
        }

        private const string nativeName = "_Marshalls";
        internal static IntPtr ptr = NativeCalls.godot_icall__Marshalls_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "variant_to_base64");

        /// <summary>
        /// <para>Returns a Base64-encoded string of the <c>Variant</c> <c>variant</c>. If <c>full_objects</c> is <c>true</c>, encoding objects is allowed (and can potentially include code).</para>
        /// </summary>
        [GodotMethod("variant_to_base64")]
        public static string VariantToBase64(object variant, bool fullObjects = false)
        {
            return NativeCalls.godot_icall_2_1209(method_bind_0, ptr, variant, fullObjects);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "base64_to_variant");

        /// <summary>
        /// <para>Returns a decoded <c>Variant</c> corresponding to the Base64-encoded string <c>base64_str</c>. If <c>allow_objects</c> is <c>true</c>, decoding objects is allowed.</para>
        /// <para>Warning: Deserialized objects can contain code which gets executed. Do not use this option if the serialized object comes from untrusted sources to avoid potential security threats such as remote code execution.</para>
        /// </summary>
        [GodotMethod("base64_to_variant")]
        public static object Base64ToVariant(string base64Str, bool allowObjects = false)
        {
            return NativeCalls.godot_icall_2_555(method_bind_1, ptr, base64Str, allowObjects);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "raw_to_base64");

        /// <summary>
        /// <para>Returns a Base64-encoded string of a given <see cref="byte"/>.</para>
        /// </summary>
        [GodotMethod("raw_to_base64")]
        public static string RawToBase64(byte[] array)
        {
            return NativeCalls.godot_icall_1_1210(method_bind_2, ptr, array);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "base64_to_raw");

        /// <summary>
        /// <para>Returns a decoded <see cref="byte"/> corresponding to the Base64-encoded string <c>base64_str</c>.</para>
        /// </summary>
        [GodotMethod("base64_to_raw")]
        public static byte[] Base64ToRaw(string base64Str)
        {
            return NativeCalls.godot_icall_1_1211(method_bind_3, ptr, base64Str);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "utf8_to_base64");

        /// <summary>
        /// <para>Returns a Base64-encoded string of the UTF-8 string <c>utf8_str</c>.</para>
        /// </summary>
        [GodotMethod("utf8_to_base64")]
        public static string Utf8ToBase64(string utf8Str)
        {
            return NativeCalls.godot_icall_1_124(method_bind_4, ptr, utf8Str);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "base64_to_utf8");

        /// <summary>
        /// <para>Returns a decoded string corresponding to the Base64-encoded string <c>base64_str</c>.</para>
        /// </summary>
        [GodotMethod("base64_to_utf8")]
        public static string Base64ToUtf8(string base64Str)
        {
            return NativeCalls.godot_icall_1_124(method_bind_5, ptr, base64Str);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
