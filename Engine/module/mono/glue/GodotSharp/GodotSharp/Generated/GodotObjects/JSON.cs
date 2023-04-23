using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Helper class for parsing JSON data. For usage example and other important hints, see <see cref="Godot.JSONParseResult"/>.</para>
    /// </summary>
    public static partial class JSON
    {
        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(JSON).Name);
                return singleton;
            }
        }

        private const string nativeName = "_JSON";
        internal static IntPtr ptr = NativeCalls.godot_icall__JSON_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "print");

        /// <summary>
        /// <para>Converts a <c>Variant</c> var to JSON text and returns the result. Useful for serializing data to store or send over the network.</para>
        /// <para>Note: The JSON specification does not define integer or float types, but only a number type. Therefore, converting a Variant to JSON text will convert all numerical values to <see cref="float"/> types.</para>
        /// <para>The <c>indent</c> parameter controls if and how something is indented, the string used for this parameter will be used where there should be an indent in the output, even spaces like <c>"   "</c> will work. <c>\t</c> and <c>\n</c> can also be used for a tab indent, or to make a newline for each indent respectively.</para>
        /// <para>Example output:</para>
        /// <para><code>
        /// ## JSON.print(my_dictionary)
        /// {"name":"my_dictionary","version":"1.0.0","entities":[{"name":"entity_0","value":"value_0"},{"name":"entity_1","value":"value_1"}]}
        /// 
        /// ## JSON.print(my_dictionary, "\t")
        /// {
        ///     "name": "my_dictionary",
        ///     "version": "1.0.0",
        ///     "entities": [
        ///         {
        ///             "name": "entity_0",
        ///             "value": "value_0"
        ///         },
        ///         {
        ///             "name": "entity_1",
        ///             "value": "value_1"
        ///         }
        ///     ]
        /// }
        /// 
        /// ## JSON.print(my_dictionary, "...")
        /// {
        /// ..."name": "my_dictionary",
        /// ..."version": "1.0.0",
        /// ..."entities": [
        /// ......{
        /// ........."name": "entity_0",
        /// ........."value": "value_0"
        /// ......},
        /// ......{
        /// ........."name": "entity_1",
        /// ........."value": "value_1"
        /// ......}
        /// ...]
        /// }
        /// </code></para>
        /// </summary>
        [GodotMethod("print")]
        public static string Print(object value, string indent = "", bool sortKeys = false)
        {
            return NativeCalls.godot_icall_3_1207(method_bind_0, ptr, value, indent, sortKeys);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "parse");

        /// <summary>
        /// <para>Parses a JSON-encoded string and returns a <see cref="Godot.JSONParseResult"/> containing the result.</para>
        /// </summary>
        [GodotMethod("parse")]
        public static JSONParseResult Parse(string json)
        {
            return NativeCalls.godot_icall_1_1208(method_bind_1, ptr, json);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
