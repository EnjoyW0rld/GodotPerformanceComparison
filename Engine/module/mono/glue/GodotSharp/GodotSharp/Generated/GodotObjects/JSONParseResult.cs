using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Returned by <see cref="Godot.JSON.Parse"/>, <see cref="Godot.JSONParseResult"/> contains the decoded JSON or error information if the JSON source wasn't successfully parsed. You can check if the JSON source was successfully parsed with <c>if json_result.error == OK</c>.</para>
    /// </summary>
    public partial class JSONParseResult : Reference
    {
        /// <summary>
        /// <para>The error type if the JSON source was not successfully parsed. See the <see cref="Godot.Error"/> constants.</para>
        /// </summary>
        public Error Error
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetError();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetError(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The error message if the JSON source was not successfully parsed. See the <see cref="Godot.Error"/> constants.</para>
        /// </summary>
        public string ErrorString
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetErrorString();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetErrorString(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The line number where the error occurred if the JSON source was not successfully parsed.</para>
        /// </summary>
        public int ErrorLine
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetErrorLine();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetErrorLine(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A <c>Variant</c> containing the parsed JSON. Use <c>@GDScript.typeof</c> or the <c>is</c> keyword to check if it is what you expect. For example, if the JSON source starts with curly braces (<c>{}</c>), a <see cref="Godot.Collections.Dictionary"/> will be returned. If the JSON source starts with brackets (<c>[]</c>), an <see cref="Godot.Collections.Array"/> will be returned.</para>
        /// <para>Note: The JSON specification does not define integer or float types, but only a number type. Therefore, parsing a JSON text will convert all numerical values to <see cref="float"/> types.</para>
        /// <para>Note: JSON objects do not preserve key order like Godot dictionaries, thus, you should not rely on keys being in a certain order if a dictionary is constructed from JSON. In contrast, JSON arrays retain the order of their elements:</para>
        /// <para><code>
        /// var p = JSON.parse('["hello", "world", "!"]')
        /// if typeof(p.result) == TYPE_ARRAY:
        ///     print(p.result[0]) # Prints "hello"
        /// else:
        ///     push_error("Unexpected results.")
        /// </code></para>
        /// </summary>
        public object Result
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetResult();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetResult(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "JSONParseResult";

        public JSONParseResult() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_JSONParseResult_Ctor(this);
        }

        internal JSONParseResult(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_error");

        [GodotMethod("get_error")]
        [Obsolete("GetError is deprecated. Use the Error property instead.")]
        public Error GetError()
        {
            return (Error)NativeCalls.godot_icall_0_389(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_error_string");

        [GodotMethod("get_error_string")]
        [Obsolete("GetErrorString is deprecated. Use the ErrorString property instead.")]
        public string GetErrorString()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_error_line");

        [GodotMethod("get_error_line")]
        [Obsolete("GetErrorLine is deprecated. Use the ErrorLine property instead.")]
        public int GetErrorLine()
        {
            return NativeCalls.godot_icall_0_5(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_result");

        [GodotMethod("get_result")]
        [Obsolete("GetResult is deprecated. Use the Result property instead.")]
        public object GetResult()
        {
            return NativeCalls.godot_icall_0_547(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_error");

        [GodotMethod("set_error")]
        [Obsolete("SetError is deprecated. Use the Error property instead.")]
        public void SetError(Error error)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), (int)error);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_error_string");

        [GodotMethod("set_error_string")]
        [Obsolete("SetErrorString is deprecated. Use the ErrorString property instead.")]
        public void SetErrorString(string errorString)
        {
            NativeCalls.godot_icall_1_54(method_bind_5, Object.GetPtr(this), errorString);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_error_line");

        [GodotMethod("set_error_line")]
        [Obsolete("SetErrorLine is deprecated. Use the ErrorLine property instead.")]
        public void SetErrorLine(int errorLine)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), errorLine);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_result");

        [GodotMethod("set_result")]
        [Obsolete("SetResult is deprecated. Use the Result property instead.")]
        public void SetResult(object result)
        {
            NativeCalls.godot_icall_1_548(method_bind_7, Object.GetPtr(this), result);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
