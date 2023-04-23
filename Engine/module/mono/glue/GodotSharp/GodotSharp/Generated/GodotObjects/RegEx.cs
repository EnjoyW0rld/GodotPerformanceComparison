using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A regular expression (or regex) is a compact language that can be used to recognise strings that follow a specific pattern, such as URLs, email addresses, complete sentences, etc. For instance, a regex of <c>ab[0-9]</c> would find any string that is <c>ab</c> followed by any number from <c>0</c> to <c>9</c>. For a more in-depth look, you can easily find various tutorials and detailed explanations on the Internet.</para>
    /// <para>To begin, the RegEx object needs to be compiled with the search pattern using <see cref="Godot.RegEx.Compile"/> before it can be used.</para>
    /// <para><code>
    /// var regex = RegEx.new()
    /// regex.compile("\\w-(\\d+)")
    /// </code></para>
    /// <para>The search pattern must be escaped first for GDScript before it is escaped for the expression. For example, <c>compile("\\d+")</c> would be read by RegEx as <c>\d+</c>. Similarly, <c>compile("\"(?:\\\\.|[^\"])*\"")</c> would be read as <c>"(?:\\.|[^"])*"</c>.</para>
    /// <para>Using <see cref="Godot.RegEx.Search"/>, you can find the pattern within the given text. If a pattern is found, <see cref="Godot.RegExMatch"/> is returned and you can retrieve details of the results using methods such as <see cref="Godot.RegExMatch.GetString"/> and <see cref="Godot.RegExMatch.GetStart"/>.</para>
    /// <para><code>
    /// var regex = RegEx.new()
    /// regex.compile("\\w-(\\d+)")
    /// var result = regex.search("abc n-0123")
    /// if result:
    ///     print(result.get_string()) # Would print n-0123
    /// </code></para>
    /// <para>The results of capturing groups <c>()</c> can be retrieved by passing the group number to the various methods in <see cref="Godot.RegExMatch"/>. Group 0 is the default and will always refer to the entire pattern. In the above example, calling <c>result.get_string(1)</c> would give you <c>0123</c>.</para>
    /// <para>This version of RegEx also supports named capturing groups, and the names can be used to retrieve the results. If two or more groups have the same name, the name would only refer to the first one with a match.</para>
    /// <para><code>
    /// var regex = RegEx.new()
    /// regex.compile("d(?&lt;digit&gt;[0-9]+)|x(?&lt;digit&gt;[0-9a-f]+)")
    /// var result = regex.search("the number is x2f")
    /// if result:
    ///     print(result.get_string("digit")) # Would print 2f
    /// </code></para>
    /// <para>If you need to process multiple results, <see cref="Godot.RegEx.SearchAll"/> generates a list of all non-overlapping results. This can be combined with a <c>for</c> loop for convenience.</para>
    /// <para><code>
    /// for result in regex.search_all("d01, d03, d0c, x3f and x42"):
    ///     print(result.get_string("digit"))
    /// # Would print 01 03 0 3f 42
    /// </code></para>
    /// <para>Example of splitting a string using a RegEx:</para>
    /// <para><code>
    /// var regex = RegEx.new()
    /// regex.compile("\\S+") # Negated whitespace character class.
    /// var results = []
    /// for result in regex.search_all("One  Two \n\tThree"):
    ///     results.push_back(result.get_string())
    /// # The `results` array now contains "One", "Two", "Three".
    /// </code></para>
    /// <para>Note: Godot's regex implementation is based on the <a href="https://www.pcre.org/">PCRE2</a> library. You can view the full pattern reference <a href="https://www.pcre.org/current/doc/html/pcre2pattern.html">here</a>.</para>
    /// <para>Tip: You can use <a href="https://regexr.com/">Regexr</a> to test regular expressions online.</para>
    /// </summary>
    public partial class RegEx : Reference
    {
        private const string nativeName = "RegEx";

        public RegEx() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_RegEx_Ctor(this);
        }

        internal RegEx(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>This method resets the state of the object, as if it was freshly created. Namely, it unassigns the regular expression of this object.</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "compile");

        /// <summary>
        /// <para>Compiles and assign the search pattern to use. Returns <c>OK</c> if the compilation is successful. If an error is encountered, details are printed to standard output and an error is returned.</para>
        /// </summary>
        [GodotMethod("compile")]
        public Error Compile(string pattern)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_1, Object.GetPtr(this), pattern);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "search");

        /// <summary>
        /// <para>Searches the text for the compiled pattern. Returns a <see cref="Godot.RegExMatch"/> container of the first matching result if found, otherwise <c>null</c>.</para>
        /// <para>The region to search within can be specified with <c>offset</c> and <c>end</c>. This is useful when searching for another match in the same <c>subject</c> by calling this method again after a previous success. Setting these parameters differs from passing over a shortened string. For example, the start anchor <c>^</c> is not affected by <c>offset</c>, and the character before <c>offset</c> will be checked for the word boundary <c>\b</c>.</para>
        /// </summary>
        [GodotMethod("search")]
        public RegExMatch Search(string subject, int offset = 0, int end = -1)
        {
            return NativeCalls.godot_icall_3_815(method_bind_2, Object.GetPtr(this), subject, offset, end);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "search_all");

        /// <summary>
        /// <para>Searches the text for the compiled pattern. Returns an array of <see cref="Godot.RegExMatch"/> containers for each non-overlapping result. If no results were found, an empty array is returned instead.</para>
        /// <para>The region to search within can be specified with <c>offset</c> and <c>end</c>. This is useful when searching for another match in the same <c>subject</c> by calling this method again after a previous success. Setting these parameters differs from passing over a shortened string. For example, the start anchor <c>^</c> is not affected by <c>offset</c>, and the character before <c>offset</c> will be checked for the word boundary <c>\b</c>.</para>
        /// </summary>
        [GodotMethod("search_all")]
        public Godot.Collections.Array SearchAll(string subject, int offset = 0, int end = -1)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_3_816(method_bind_3, Object.GetPtr(this), subject, offset, end));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "sub");

        /// <summary>
        /// <para>Searches the text for the compiled pattern and replaces it with the specified string. Escapes and backreferences such as <c>$1</c> and <c>$name</c> are expanded and resolved. By default, only the first instance is replaced, but it can be changed for all instances (global replacement).</para>
        /// <para>The region to search within can be specified with <c>offset</c> and <c>end</c>. This is useful when searching for another match in the same <c>subject</c> by calling this method again after a previous success. Setting these parameters differs from passing over a shortened string. For example, the start anchor <c>^</c> is not affected by <c>offset</c>, and the character before <c>offset</c> will be checked for the word boundary <c>\b</c>.</para>
        /// </summary>
        [GodotMethod("sub")]
        public string Sub(string subject, string replacement, bool all = false, int offset = 0, int end = -1)
        {
            return NativeCalls.godot_icall_5_817(method_bind_4, Object.GetPtr(this), subject, replacement, all, offset, end);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_valid");

        /// <summary>
        /// <para>Returns whether this object has a valid search pattern assigned.</para>
        /// </summary>
        [GodotMethod("is_valid")]
        public bool IsValid()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pattern");

        /// <summary>
        /// <para>Returns the original search pattern that was compiled.</para>
        /// </summary>
        [GodotMethod("get_pattern")]
        public string GetPattern()
        {
            return NativeCalls.godot_icall_0_6(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_group_count");

        /// <summary>
        /// <para>Returns the number of capturing groups in compiled pattern.</para>
        /// </summary>
        [GodotMethod("get_group_count")]
        public int GetGroupCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_names");

        /// <summary>
        /// <para>Returns an array of names of named capturing groups in the compiled pattern. They are ordered by appearance.</para>
        /// </summary>
        [GodotMethod("get_names")]
        public Godot.Collections.Array GetNames()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_8, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
