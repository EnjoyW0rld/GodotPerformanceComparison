using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><a href="https://www.jsonrpc.org/">JSON-RPC</a> is a standard which wraps a method call in a <see cref="Godot.JSON"/> object. The object has a particular structure and identifies which method is called, the parameters to that function, and carries an ID to keep track of responses. This class implements that standard on top of <see cref="Godot.Collections.Dictionary"/>; you will have to convert between a <see cref="Godot.Collections.Dictionary"/> and <see cref="Godot.JSON"/> with other functions.</para>
    /// </summary>
    public partial class JSONRPC : Object
    {
        public enum ErrorCode
        {
            ParseError = -32700,
            InvalidRequest = -32600,
            /// <summary>
            /// <para>A method call was requested but no function of that name existed in the JSONRPC subclass.</para>
            /// </summary>
            MethodNotFound = -32601,
            InvalidParams = -32602,
            InternalError = -32603
        }

        private const string nativeName = "JSONRPC";

        public JSONRPC() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_JSONRPC_Ctor(this);
        }

        internal JSONRPC(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_scope");

        [GodotMethod("set_scope")]
        public void SetScope(string scope, Object target)
        {
            NativeCalls.godot_icall_2_377(method_bind_0, Object.GetPtr(this), scope, Object.GetPtr(target));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "process_action");

        /// <summary>
        /// <para>Given a Dictionary which takes the form of a JSON-RPC request: unpack the request and run it. Methods are resolved by looking at the field called "method" and looking for an equivalently named function in the JSONRPC object. If one is found that method is called.</para>
        /// <para>To add new supported methods extend the JSONRPC class and call <see cref="Godot.JSONRPC.ProcessAction"/> on your subclass.</para>
        /// <para><c>action</c>: The action to be run, as a Dictionary in the form of a JSON-RPC request or notification.</para>
        /// </summary>
        [GodotMethod("process_action")]
        public object ProcessAction(object action, bool recurse = false)
        {
            return NativeCalls.godot_icall_2_549(method_bind_1, Object.GetPtr(this), action, recurse);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "process_string");

        [GodotMethod("process_string")]
        public string ProcessString(string action)
        {
            return NativeCalls.godot_icall_1_124(method_bind_2, Object.GetPtr(this), action);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "make_request");

        /// <summary>
        /// <para>Returns a dictionary in the form of a JSON-RPC request. Requests are sent to a server with the expectation of a response. The ID field is used for the server to specify which exact request it is responding to.</para>
        /// <para>- <c>method</c>: Name of the method being called.</para>
        /// <para>- <c>params</c>: An array or dictionary of parameters being passed to the method.</para>
        /// <para>- <c>id</c>: Uniquely identifies this request. The server is expected to send a response with the same ID.</para>
        /// </summary>
        [GodotMethod("make_request")]
        public Godot.Collections.Dictionary MakeRequest(string method, object @params, object id)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_3_550(method_bind_3, Object.GetPtr(this), method, @params, id));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "make_response");

        /// <summary>
        /// <para>When a server has received and processed a request, it is expected to send a response. If you did not want a response then you need to have sent a Notification instead.</para>
        /// <para>- <c>result</c>: The return value of the function which was called.</para>
        /// <para>- <c>id</c>: The ID of the request this response is targeted to.</para>
        /// </summary>
        [GodotMethod("make_response")]
        public Godot.Collections.Dictionary MakeResponse(object result, object id)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_2_551(method_bind_4, Object.GetPtr(this), result, id));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "make_notification");

        /// <summary>
        /// <para>Returns a dictionary in the form of a JSON-RPC notification. Notifications are one-shot messages which do not expect a response.</para>
        /// <para>- <c>method</c>: Name of the method being called.</para>
        /// <para>- <c>params</c>: An array or dictionary of parameters being passed to the method.</para>
        /// </summary>
        [GodotMethod("make_notification")]
        public Godot.Collections.Dictionary MakeNotification(string method, object @params)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_2_552(method_bind_5, Object.GetPtr(this), method, @params));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "make_response_error");

        /// <summary>
        /// <para>Creates a response which indicates a previous reply has failed in some way.</para>
        /// <para>- <c>code</c>: The error code corresponding to what kind of error this is. See the <see cref="Godot.JSONRPC.ErrorCode"/> constants.</para>
        /// <para>- <c>message</c>: A custom message about this error.</para>
        /// <para>- <c>id</c>: The request this error is a response to.</para>
        /// </summary>
        [GodotMethod("make_response_error")]
        public Godot.Collections.Dictionary MakeResponseError(int code, string message, object id = null)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_3_553(method_bind_6, Object.GetPtr(this), code, message, id));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
