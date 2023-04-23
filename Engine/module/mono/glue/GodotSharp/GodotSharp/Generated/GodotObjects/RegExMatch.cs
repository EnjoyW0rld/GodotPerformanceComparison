using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Contains the results of a single <see cref="Godot.RegEx"/> match returned by <see cref="Godot.RegEx.Search"/> and <see cref="Godot.RegEx.SearchAll"/>. It can be used to find the position and range of the match and its capturing groups, and it can extract its substring for you.</para>
    /// </summary>
    public partial class RegExMatch : Reference
    {
        /// <summary>
        /// <para>The source string used with the search pattern to find this matching result.</para>
        /// </summary>
        public string Subject
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSubject();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A dictionary of named groups and its corresponding group number. Only groups that were matched are included. If multiple groups have the same name, that name would refer to the first matching one.</para>
        /// </summary>
        public Godot.Collections.Dictionary Names
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNames();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>An <see cref="Godot.Collections.Array"/> of the match and its capturing groups.</para>
        /// </summary>
        public Godot.Collections.Array Strings
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetStrings();
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "RegExMatch";

        public RegExMatch() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_RegExMatch_Ctor(this);
        }

        internal RegExMatch(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_subject");

        [GodotMethod("get_subject")]
        [Obsolete("GetSubject is deprecated. Use the Subject property instead.")]
        public string GetSubject()
        {
            return NativeCalls.godot_icall_0_6(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_group_count");

        /// <summary>
        /// <para>Returns the number of capturing groups.</para>
        /// </summary>
        [GodotMethod("get_group_count")]
        public int GetGroupCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_names");

        [GodotMethod("get_names")]
        [Obsolete("GetNames is deprecated. Use the Names property instead.")]
        public Godot.Collections.Dictionary GetNames()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_2, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_strings");

        [GodotMethod("get_strings")]
        [Obsolete("GetStrings is deprecated. Use the Strings property instead.")]
        public Godot.Collections.Array GetStrings()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_3, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_string");

        /// <summary>
        /// <para>Returns the substring of the match from the source string. Capturing groups can be retrieved by providing its group number as an integer or its string name (if it's a named group). The default value of 0 refers to the whole pattern.</para>
        /// <para>Returns an empty string if the group did not match or doesn't exist.</para>
        /// </summary>
        /// <param name="name">If the parameter is null, then the default value is (object)0</param>
        [GodotMethod("get_string")]
        public string GetString(object name = null)
        {
            object name_in = name != null ? name : (object)0;
            return NativeCalls.godot_icall_1_818(method_bind_4, Object.GetPtr(this), name_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_start");

        /// <summary>
        /// <para>Returns the starting position of the match within the source string. The starting position of capturing groups can be retrieved by providing its group number as an integer or its string name (if it's a named group). The default value of 0 refers to the whole pattern.</para>
        /// <para>Returns -1 if the group did not match or doesn't exist.</para>
        /// </summary>
        /// <param name="name">If the parameter is null, then the default value is (object)0</param>
        [GodotMethod("get_start")]
        public int GetStart(object name = null)
        {
            object name_in = name != null ? name : (object)0;
            return NativeCalls.godot_icall_1_819(method_bind_5, Object.GetPtr(this), name_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_end");

        /// <summary>
        /// <para>Returns the end position of the match within the source string. The end position of capturing groups can be retrieved by providing its group number as an integer or its string name (if it's a named group). The default value of 0 refers to the whole pattern.</para>
        /// <para>Returns -1 if the group did not match or doesn't exist.</para>
        /// </summary>
        /// <param name="name">If the parameter is null, then the default value is (object)0</param>
        [GodotMethod("get_end")]
        public int GetEnd(object name = null)
        {
            object name_in = name != null ? name : (object)0;
            return NativeCalls.godot_icall_1_819(method_bind_6, Object.GetPtr(this), name_in);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
