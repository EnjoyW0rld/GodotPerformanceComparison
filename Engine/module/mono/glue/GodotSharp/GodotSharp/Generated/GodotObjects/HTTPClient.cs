using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Hyper-text transfer protocol client (sometimes called "User Agent"). Used to make HTTP requests to download web content, upload files and other data or to communicate with various services, among other use cases.</para>
    /// <para>See the <see cref="Godot.HTTPRequest"/> node for a higher-level alternative.</para>
    /// <para>Note: This client only needs to connect to a host once (see <see cref="Godot.HTTPClient.ConnectToHost"/>) to send multiple requests. Because of this, methods that take URLs usually take just the part after the host instead of the full URL, as the client is already connected to a host. See <see cref="Godot.HTTPClient.Request"/> for a full example and to get started.</para>
    /// <para>A <see cref="Godot.HTTPClient"/> should be reused between multiple requests or to connect to different hosts instead of creating one client per request. Supports SSL and SSL server certificate verification. HTTP status codes in the 2xx range indicate success, 3xx redirection (i.e. "try again, but over here"), 4xx something was wrong with the request, and 5xx something went wrong on the server's side.</para>
    /// <para>For more information on HTTP, see https://developer.mozilla.org/en-US/docs/Web/HTTP (or read RFC 2616 to get it straight from the source: https://tools.ietf.org/html/rfc2616).</para>
    /// <para>Note: When performing HTTP requests from a project exported to HTML5, keep in mind the remote server may not allow requests from foreign origins due to <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS">CORS</a>. If you host the server in question, you should modify its backend to allow requests from foreign origins by adding the <c>Access-Control-Allow-Origin: *</c> HTTP header.</para>
    /// <para>Note: SSL/TLS support is currently limited to TLS 1.0, TLS 1.1, and TLS 1.2. Attempting to connect to a TLS 1.3-only server will return an error.</para>
    /// <para>Warning: SSL/TLS certificate revocation and certificate pinning are currently not supported. Revoked certificates are accepted as long as they are otherwise valid. If this is a concern, you may want to use automatically managed certificates with a short validity period.</para>
    /// </summary>
    public partial class HTTPClient : Reference
    {
        public enum Status
        {
            /// <summary>
            /// <para>Status: Disconnected from the server.</para>
            /// </summary>
            Disconnected = 0,
            /// <summary>
            /// <para>Status: Currently resolving the hostname for the given URL into an IP.</para>
            /// </summary>
            Resolving = 1,
            /// <summary>
            /// <para>Status: DNS failure: Can't resolve the hostname for the given URL.</para>
            /// </summary>
            CantResolve = 2,
            /// <summary>
            /// <para>Status: Currently connecting to server.</para>
            /// </summary>
            Connecting = 3,
            /// <summary>
            /// <para>Status: Can't connect to the server.</para>
            /// </summary>
            CantConnect = 4,
            /// <summary>
            /// <para>Status: Connection established.</para>
            /// </summary>
            Connected = 5,
            /// <summary>
            /// <para>Status: Currently sending request.</para>
            /// </summary>
            Requesting = 6,
            /// <summary>
            /// <para>Status: HTTP body received.</para>
            /// </summary>
            Body = 7,
            /// <summary>
            /// <para>Status: Error in HTTP connection.</para>
            /// </summary>
            ConnectionError = 8,
            /// <summary>
            /// <para>Status: Error in SSL handshake.</para>
            /// </summary>
            SslHandshakeError = 9
        }

        public enum Method
        {
            /// <summary>
            /// <para>HTTP GET method. The GET method requests a representation of the specified resource. Requests using GET should only retrieve data.</para>
            /// </summary>
            Get = 0,
            /// <summary>
            /// <para>HTTP HEAD method. The HEAD method asks for a response identical to that of a GET request, but without the response body. This is useful to request metadata like HTTP headers or to check if a resource exists.</para>
            /// </summary>
            Head = 1,
            /// <summary>
            /// <para>HTTP POST method. The POST method is used to submit an entity to the specified resource, often causing a change in state or side effects on the server. This is often used for forms and submitting data or uploading files.</para>
            /// </summary>
            Post = 2,
            /// <summary>
            /// <para>HTTP PUT method. The PUT method asks to replace all current representations of the target resource with the request payload. (You can think of POST as "create or update" and PUT as "update", although many services tend to not make a clear distinction or change their meaning).</para>
            /// </summary>
            Put = 3,
            /// <summary>
            /// <para>HTTP DELETE method. The DELETE method requests to delete the specified resource.</para>
            /// </summary>
            Delete = 4,
            /// <summary>
            /// <para>HTTP OPTIONS method. The OPTIONS method asks for a description of the communication options for the target resource. Rarely used.</para>
            /// </summary>
            Options = 5,
            /// <summary>
            /// <para>HTTP TRACE method. The TRACE method performs a message loop-back test along the path to the target resource. Returns the entire HTTP request received in the response body. Rarely used.</para>
            /// </summary>
            Trace = 6,
            /// <summary>
            /// <para>HTTP CONNECT method. The CONNECT method establishes a tunnel to the server identified by the target resource. Rarely used.</para>
            /// </summary>
            Connect = 7,
            /// <summary>
            /// <para>HTTP PATCH method. The PATCH method is used to apply partial modifications to a resource.</para>
            /// </summary>
            Patch = 8,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.HTTPClient.Method"/> enum.</para>
            /// </summary>
            Max = 9
        }

        public enum ResponseCode
        {
            /// <summary>
            /// <para>HTTP status code <c>100 Continue</c>. Interim response that indicates everything so far is OK and that the client should continue with the request (or ignore this status if already finished).</para>
            /// </summary>
            Continue = 100,
            /// <summary>
            /// <para>HTTP status code <c>101 Switching Protocol</c>. Sent in response to an <c>Upgrade</c> request header by the client. Indicates the protocol the server is switching to.</para>
            /// </summary>
            SwitchingProtocols = 101,
            /// <summary>
            /// <para>HTTP status code <c>102 Processing</c> (WebDAV). Indicates that the server has received and is processing the request, but no response is available yet.</para>
            /// </summary>
            Processing = 102,
            /// <summary>
            /// <para>HTTP status code <c>200 OK</c>. The request has succeeded. Default response for successful requests. Meaning varies depending on the request. GET: The resource has been fetched and is transmitted in the message body. HEAD: The entity headers are in the message body. POST: The resource describing the result of the action is transmitted in the message body. TRACE: The message body contains the request message as received by the server.</para>
            /// </summary>
            Ok = 200,
            /// <summary>
            /// <para>HTTP status code <c>201 Created</c>. The request has succeeded and a new resource has been created as a result of it. This is typically the response sent after a PUT request.</para>
            /// </summary>
            Created = 201,
            /// <summary>
            /// <para>HTTP status code <c>202 Accepted</c>. The request has been received but not yet acted upon. It is non-committal, meaning that there is no way in HTTP to later send an asynchronous response indicating the outcome of processing the request. It is intended for cases where another process or server handles the request, or for batch processing.</para>
            /// </summary>
            Accepted = 202,
            /// <summary>
            /// <para>HTTP status code <c>203 Non-Authoritative Information</c>. This response code means returned meta-information set is not exact set as available from the origin server, but collected from a local or a third party copy. Except this condition, 200 OK response should be preferred instead of this response.</para>
            /// </summary>
            NonAuthoritativeInformation = 203,
            /// <summary>
            /// <para>HTTP status code <c>204 No Content</c>. There is no content to send for this request, but the headers may be useful. The user-agent may update its cached headers for this resource with the new ones.</para>
            /// </summary>
            NoContent = 204,
            /// <summary>
            /// <para>HTTP status code <c>205 Reset Content</c>. The server has fulfilled the request and desires that the client resets the "document view" that caused the request to be sent to its original state as received from the origin server.</para>
            /// </summary>
            ResetContent = 205,
            /// <summary>
            /// <para>HTTP status code <c>206 Partial Content</c>. This response code is used because of a range header sent by the client to separate download into multiple streams.</para>
            /// </summary>
            PartialContent = 206,
            /// <summary>
            /// <para>HTTP status code <c>207 Multi-Status</c> (WebDAV). A Multi-Status response conveys information about multiple resources in situations where multiple status codes might be appropriate.</para>
            /// </summary>
            MultiStatus = 207,
            /// <summary>
            /// <para>HTTP status code <c>208 Already Reported</c> (WebDAV). Used inside a DAV: propstat response element to avoid enumerating the internal members of multiple bindings to the same collection repeatedly.</para>
            /// </summary>
            AlreadyReported = 208,
            /// <summary>
            /// <para>HTTP status code <c>226 IM Used</c> (WebDAV). The server has fulfilled a GET request for the resource, and the response is a representation of the result of one or more instance-manipulations applied to the current instance.</para>
            /// </summary>
            ImUsed = 226,
            /// <summary>
            /// <para>HTTP status code <c>300 Multiple Choice</c>. The request has more than one possible responses and there is no standardized way to choose one of the responses. User-agent or user should choose one of them.</para>
            /// </summary>
            MultipleChoices = 300,
            /// <summary>
            /// <para>HTTP status code <c>301 Moved Permanently</c>. Redirection. This response code means the URI of requested resource has been changed. The new URI is usually included in the response.</para>
            /// </summary>
            MovedPermanently = 301,
            /// <summary>
            /// <para>HTTP status code <c>302 Found</c>. Temporary redirection. This response code means the URI of requested resource has been changed temporarily. New changes in the URI might be made in the future. Therefore, this same URI should be used by the client in future requests.</para>
            /// </summary>
            Found = 302,
            /// <summary>
            /// <para>HTTP status code <c>303 See Other</c>. The server is redirecting the user agent to a different resource, as indicated by a URI in the Location header field, which is intended to provide an indirect response to the original request.</para>
            /// </summary>
            SeeOther = 303,
            /// <summary>
            /// <para>HTTP status code <c>304 Not Modified</c>. A conditional GET or HEAD request has been received and would have resulted in a 200 OK response if it were not for the fact that the condition evaluated to <c>false</c>.</para>
            /// </summary>
            NotModified = 304,
            /// <summary>
            /// <para>HTTP status code <c>305 Use Proxy</c>. Deprecated. Do not use.</para>
            /// </summary>
            UseProxy = 305,
            /// <summary>
            /// <para>HTTP status code <c>306 Switch Proxy</c>. Deprecated. Do not use.</para>
            /// </summary>
            SwitchProxy = 306,
            /// <summary>
            /// <para>HTTP status code <c>307 Temporary Redirect</c>. The target resource resides temporarily under a different URI and the user agent MUST NOT change the request method if it performs an automatic redirection to that URI.</para>
            /// </summary>
            TemporaryRedirect = 307,
            /// <summary>
            /// <para>HTTP status code <c>308 Permanent Redirect</c>. The target resource has been assigned a new permanent URI and any future references to this resource ought to use one of the enclosed URIs.</para>
            /// </summary>
            PermanentRedirect = 308,
            /// <summary>
            /// <para>HTTP status code <c>400 Bad Request</c>. The request was invalid. The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, invalid request contents, or deceptive request routing).</para>
            /// </summary>
            BadRequest = 400,
            /// <summary>
            /// <para>HTTP status code <c>401 Unauthorized</c>. Credentials required. The request has not been applied because it lacks valid authentication credentials for the target resource.</para>
            /// </summary>
            Unauthorized = 401,
            /// <summary>
            /// <para>HTTP status code <c>402 Payment Required</c>. This response code is reserved for future use. Initial aim for creating this code was using it for digital payment systems, however this is not currently used.</para>
            /// </summary>
            PaymentRequired = 402,
            /// <summary>
            /// <para>HTTP status code <c>403 Forbidden</c>. The client does not have access rights to the content, i.e. they are unauthorized, so server is rejecting to give proper response. Unlike <c>401</c>, the client's identity is known to the server.</para>
            /// </summary>
            Forbidden = 403,
            /// <summary>
            /// <para>HTTP status code <c>404 Not Found</c>. The server can not find requested resource. Either the URL is not recognized or the endpoint is valid but the resource itself does not exist. May also be sent instead of 403 to hide existence of a resource if the client is not authorized.</para>
            /// </summary>
            NotFound = 404,
            /// <summary>
            /// <para>HTTP status code <c>405 Method Not Allowed</c>. The request's HTTP method is known by the server but has been disabled and cannot be used. For example, an API may forbid DELETE-ing a resource. The two mandatory methods, GET and HEAD, must never be disabled and should not return this error code.</para>
            /// </summary>
            MethodNotAllowed = 405,
            /// <summary>
            /// <para>HTTP status code <c>406 Not Acceptable</c>. The target resource does not have a current representation that would be acceptable to the user agent, according to the proactive negotiation header fields received in the request. Used when negotiation content.</para>
            /// </summary>
            NotAcceptable = 406,
            /// <summary>
            /// <para>HTTP status code <c>407 Proxy Authentication Required</c>. Similar to 401 Unauthorized, but it indicates that the client needs to authenticate itself in order to use a proxy.</para>
            /// </summary>
            ProxyAuthenticationRequired = 407,
            /// <summary>
            /// <para>HTTP status code <c>408 Request Timeout</c>. The server did not receive a complete request message within the time that it was prepared to wait.</para>
            /// </summary>
            RequestTimeout = 408,
            /// <summary>
            /// <para>HTTP status code <c>409 Conflict</c>. The request could not be completed due to a conflict with the current state of the target resource. This code is used in situations where the user might be able to resolve the conflict and resubmit the request.</para>
            /// </summary>
            Conflict = 409,
            /// <summary>
            /// <para>HTTP status code <c>410 Gone</c>. The target resource is no longer available at the origin server and this condition is likely permanent.</para>
            /// </summary>
            Gone = 410,
            /// <summary>
            /// <para>HTTP status code <c>411 Length Required</c>. The server refuses to accept the request without a defined Content-Length header.</para>
            /// </summary>
            LengthRequired = 411,
            /// <summary>
            /// <para>HTTP status code <c>412 Precondition Failed</c>. One or more conditions given in the request header fields evaluated to <c>false</c> when tested on the server.</para>
            /// </summary>
            PreconditionFailed = 412,
            /// <summary>
            /// <para>HTTP status code <c>413 Entity Too Large</c>. The server is refusing to process a request because the request payload is larger than the server is willing or able to process.</para>
            /// </summary>
            RequestEntityTooLarge = 413,
            /// <summary>
            /// <para>HTTP status code <c>414 Request-URI Too Long</c>. The server is refusing to service the request because the request-target is longer than the server is willing to interpret.</para>
            /// </summary>
            RequestUriTooLong = 414,
            /// <summary>
            /// <para>HTTP status code <c>415 Unsupported Media Type</c>. The origin server is refusing to service the request because the payload is in a format not supported by this method on the target resource.</para>
            /// </summary>
            UnsupportedMediaType = 415,
            /// <summary>
            /// <para>HTTP status code <c>416 Requested Range Not Satisfiable</c>. None of the ranges in the request's Range header field overlap the current extent of the selected resource or the set of ranges requested has been rejected due to invalid ranges or an excessive request of small or overlapping ranges.</para>
            /// </summary>
            RequestedRangeNotSatisfiable = 416,
            /// <summary>
            /// <para>HTTP status code <c>417 Expectation Failed</c>. The expectation given in the request's Expect header field could not be met by at least one of the inbound servers.</para>
            /// </summary>
            ExpectationFailed = 417,
            /// <summary>
            /// <para>HTTP status code <c>418 I'm A Teapot</c>. Any attempt to brew coffee with a teapot should result in the error code "418 I'm a teapot". The resulting entity body MAY be short and stout.</para>
            /// </summary>
            ImATeapot = 418,
            /// <summary>
            /// <para>HTTP status code <c>421 Misdirected Request</c>. The request was directed at a server that is not able to produce a response. This can be sent by a server that is not configured to produce responses for the combination of scheme and authority that are included in the request URI.</para>
            /// </summary>
            MisdirectedRequest = 421,
            /// <summary>
            /// <para>HTTP status code <c>422 Unprocessable Entity</c> (WebDAV). The server understands the content type of the request entity (hence a 415 Unsupported Media Type status code is inappropriate), and the syntax of the request entity is correct (thus a 400 Bad Request status code is inappropriate) but was unable to process the contained instructions.</para>
            /// </summary>
            UnprocessableEntity = 422,
            /// <summary>
            /// <para>HTTP status code <c>423 Locked</c> (WebDAV). The source or destination resource of a method is locked.</para>
            /// </summary>
            Locked = 423,
            /// <summary>
            /// <para>HTTP status code <c>424 Failed Dependency</c> (WebDAV). The method could not be performed on the resource because the requested action depended on another action and that action failed.</para>
            /// </summary>
            FailedDependency = 424,
            /// <summary>
            /// <para>HTTP status code <c>426 Upgrade Required</c>. The server refuses to perform the request using the current protocol but might be willing to do so after the client upgrades to a different protocol.</para>
            /// </summary>
            UpgradeRequired = 426,
            /// <summary>
            /// <para>HTTP status code <c>428 Precondition Required</c>. The origin server requires the request to be conditional.</para>
            /// </summary>
            PreconditionRequired = 428,
            /// <summary>
            /// <para>HTTP status code <c>429 Too Many Requests</c>. The user has sent too many requests in a given amount of time (see "rate limiting"). Back off and increase time between requests or try again later.</para>
            /// </summary>
            TooManyRequests = 429,
            /// <summary>
            /// <para>HTTP status code <c>431 Request Header Fields Too Large</c>. The server is unwilling to process the request because its header fields are too large. The request MAY be resubmitted after reducing the size of the request header fields.</para>
            /// </summary>
            RequestHeaderFieldsTooLarge = 431,
            /// <summary>
            /// <para>HTTP status code <c>451 Response Unavailable For Legal Reasons</c>. The server is denying access to the resource as a consequence of a legal demand.</para>
            /// </summary>
            UnavailableForLegalReasons = 451,
            /// <summary>
            /// <para>HTTP status code <c>500 Internal Server Error</c>. The server encountered an unexpected condition that prevented it from fulfilling the request.</para>
            /// </summary>
            InternalServerError = 500,
            /// <summary>
            /// <para>HTTP status code <c>501 Not Implemented</c>. The server does not support the functionality required to fulfill the request.</para>
            /// </summary>
            NotImplemented = 501,
            /// <summary>
            /// <para>HTTP status code <c>502 Bad Gateway</c>. The server, while acting as a gateway or proxy, received an invalid response from an inbound server it accessed while attempting to fulfill the request. Usually returned by load balancers or proxies.</para>
            /// </summary>
            BadGateway = 502,
            /// <summary>
            /// <para>HTTP status code <c>503 Service Unavailable</c>. The server is currently unable to handle the request due to a temporary overload or scheduled maintenance, which will likely be alleviated after some delay. Try again later.</para>
            /// </summary>
            ServiceUnavailable = 503,
            /// <summary>
            /// <para>HTTP status code <c>504 Gateway Timeout</c>. The server, while acting as a gateway or proxy, did not receive a timely response from an upstream server it needed to access in order to complete the request. Usually returned by load balancers or proxies.</para>
            /// </summary>
            GatewayTimeout = 504,
            /// <summary>
            /// <para>HTTP status code <c>505 HTTP Version Not Supported</c>. The server does not support, or refuses to support, the major version of HTTP that was used in the request message.</para>
            /// </summary>
            HttpVersionNotSupported = 505,
            /// <summary>
            /// <para>HTTP status code <c>506 Variant Also Negotiates</c>. The server has an internal configuration error: the chosen variant resource is configured to engage in transparent content negotiation itself, and is therefore not a proper end point in the negotiation process.</para>
            /// </summary>
            VariantAlsoNegotiates = 506,
            /// <summary>
            /// <para>HTTP status code <c>507 Insufficient Storage</c>. The method could not be performed on the resource because the server is unable to store the representation needed to successfully complete the request.</para>
            /// </summary>
            InsufficientStorage = 507,
            /// <summary>
            /// <para>HTTP status code <c>508 Loop Detected</c>. The server terminated an operation because it encountered an infinite loop while processing a request with "Depth: infinity". This status indicates that the entire operation failed.</para>
            /// </summary>
            LoopDetected = 508,
            /// <summary>
            /// <para>HTTP status code <c>510 Not Extended</c>. The policy for accessing the resource has not been met in the request. The server should send back all the information necessary for the client to issue an extended request.</para>
            /// </summary>
            NotExtended = 510,
            /// <summary>
            /// <para>HTTP status code <c>511 Network Authentication Required</c>. The client needs to authenticate to gain network access.</para>
            /// </summary>
            NetworkAuthRequired = 511
        }

        /// <summary>
        /// <para>If <c>true</c>, execution will block until all data is read from the response.</para>
        /// </summary>
        public bool BlockingModeEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsBlockingModeEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlockingMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The connection to use for this client.</para>
        /// </summary>
        public StreamPeer Connection
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetConnection();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetConnection(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The size of the buffer used and maximum bytes to read per iteration. See <see cref="Godot.HTTPClient.ReadResponseBodyChunk"/>.</para>
        /// </summary>
        public int ReadChunkSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetReadChunkSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetReadChunkSize(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "HTTPClient";

        public HTTPClient() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_HTTPClient_Ctor(this);
        }

        internal HTTPClient(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "connect_to_host");

        /// <summary>
        /// <para>Connects to a host. This needs to be done before any requests are sent.</para>
        /// <para>The host should not have http:// prepended but will strip the protocol identifier if provided.</para>
        /// <para>If no <c>port</c> is specified (or <c>-1</c> is used), it is automatically set to 80 for HTTP and 443 for HTTPS (if <c>use_ssl</c> is enabled).</para>
        /// <para><c>verify_host</c> will check the SSL identity of the host if set to <c>true</c>.</para>
        /// </summary>
        [GodotMethod("connect_to_host")]
        public Error ConnectToHost(string host, int port = -1, bool useSsl = false, bool verifyHost = true)
        {
            return (Error)NativeCalls.godot_icall_4_488(method_bind_0, Object.GetPtr(this), host, port, useSsl, verifyHost);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_connection");

        [GodotMethod("set_connection")]
        [Obsolete("SetConnection is deprecated. Use the Connection property instead.")]
        public void SetConnection(StreamPeer connection)
        {
            NativeCalls.godot_icall_1_24(method_bind_1, Object.GetPtr(this), Object.GetPtr(connection));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connection");

        [GodotMethod("get_connection")]
        [Obsolete("GetConnection is deprecated. Use the Connection property instead.")]
        public StreamPeer GetConnection()
        {
            return NativeCalls.godot_icall_0_489(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "request_raw");

        /// <summary>
        /// <para>Sends a raw request to the connected host.</para>
        /// <para>The URL parameter is usually just the part after the host, so for <c>http://somehost.com/index.php</c>, it is <c>/index.php</c>. When sending requests to an HTTP proxy server, it should be an absolute URL. For <see cref="Godot.HTTPClient.Method.Options"/> requests, <c>*</c> is also allowed. For <see cref="Godot.HTTPClient.Method.Connect"/> requests, it should be the authority component (<c>host:port</c>).</para>
        /// <para>Headers are HTTP request headers. For available HTTP methods, see <see cref="Godot.HTTPClient.Method"/>.</para>
        /// <para>Sends the body data raw, as a byte array and does not encode it in any way.</para>
        /// </summary>
        [GodotMethod("request_raw")]
        public Error RequestRaw(HTTPClient.Method method, string url, string[] headers, byte[] body)
        {
            return (Error)NativeCalls.godot_icall_4_490(method_bind_3, Object.GetPtr(this), (int)method, url, headers, body);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "request");

        /// <summary>
        /// <para>Sends a request to the connected host.</para>
        /// <para>The URL parameter is usually just the part after the host, so for <c>http://somehost.com/index.php</c>, it is <c>/index.php</c>. When sending requests to an HTTP proxy server, it should be an absolute URL. For <see cref="Godot.HTTPClient.Method.Options"/> requests, <c>*</c> is also allowed. For <see cref="Godot.HTTPClient.Method.Connect"/> requests, it should be the authority component (<c>host:port</c>).</para>
        /// <para>Headers are HTTP request headers. For available HTTP methods, see <see cref="Godot.HTTPClient.Method"/>.</para>
        /// <para>To create a POST request with query strings to push to the server, do:</para>
        /// <para><code>
        /// var fields = {"username" : "user", "password" : "pass"}
        /// var query_string = http_client.query_string_from_dict(fields)
        /// var headers = ["Content-Type: application/x-www-form-urlencoded", "Content-Length: " + str(query_string.length())]
        /// var result = http_client.request(http_client.METHOD_POST, "/index.php", headers, query_string)
        /// </code></para>
        /// <para>Note: The <c>request_data</c> parameter is ignored if <c>method</c> is <see cref="Godot.HTTPClient.Method.Get"/>. This is because GET methods can't contain request data. As a workaround, you can pass request data as a query string in the URL. See <c>String.http_escape</c> for an example.</para>
        /// </summary>
        [GodotMethod("request")]
        public Error Request(HTTPClient.Method method, string url, string[] headers, string body = "")
        {
            return (Error)NativeCalls.godot_icall_4_491(method_bind_4, Object.GetPtr(this), (int)method, url, headers, body);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "close");

        /// <summary>
        /// <para>Closes the current connection, allowing reuse of this <see cref="Godot.HTTPClient"/>.</para>
        /// </summary>
        [GodotMethod("close")]
        public void Close()
        {
            NativeCalls.godot_icall_0_3(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_response");

        /// <summary>
        /// <para>If <c>true</c>, this <see cref="Godot.HTTPClient"/> has a response available.</para>
        /// </summary>
        [GodotMethod("has_response")]
        public bool HasResponse()
        {
            return NativeCalls.godot_icall_0_7(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_response_chunked");

        /// <summary>
        /// <para>If <c>true</c>, this <see cref="Godot.HTTPClient"/> has a response that is chunked.</para>
        /// </summary>
        [GodotMethod("is_response_chunked")]
        public bool IsResponseChunked()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_response_code");

        /// <summary>
        /// <para>Returns the response's HTTP status code.</para>
        /// </summary>
        [GodotMethod("get_response_code")]
        public int GetResponseCode()
        {
            return NativeCalls.godot_icall_0_5(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_response_headers");

        /// <summary>
        /// <para>Returns the response headers.</para>
        /// </summary>
        [GodotMethod("get_response_headers")]
        public string[] GetResponseHeaders()
        {
            return NativeCalls.godot_icall_0_119(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_response_headers_as_dictionary");

        /// <summary>
        /// <para>Returns all response headers as a Dictionary of structure <c>{ "key": "value1; value2" }</c> where the case-sensitivity of the keys and values is kept like the server delivers it. A value is a simple String, this string can have more than one value where "; " is used as separator.</para>
        /// <para>Example:</para>
        /// <para><code>
        /// {
        ///     "content-length": 12,
        ///     "Content-Type": "application/json; charset=UTF-8",
        /// }
        /// </code></para>
        /// </summary>
        [GodotMethod("get_response_headers_as_dictionary")]
        public Godot.Collections.Dictionary GetResponseHeadersAsDictionary()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_10, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_response_body_length");

        /// <summary>
        /// <para>Returns the response's body length.</para>
        /// <para>Note: Some Web servers may not send a body length. In this case, the value returned will be <c>-1</c>. If using chunked transfer encoding, the body length will also be <c>-1</c>.</para>
        /// </summary>
        [GodotMethod("get_response_body_length")]
        public long GetResponseBodyLength()
        {
            return NativeCalls.godot_icall_0_165(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "read_response_body_chunk");

        /// <summary>
        /// <para>Reads one chunk from the response.</para>
        /// </summary>
        [GodotMethod("read_response_body_chunk")]
        public byte[] ReadResponseBodyChunk()
        {
            return NativeCalls.godot_icall_0_2(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_read_chunk_size");

        [GodotMethod("set_read_chunk_size")]
        [Obsolete("SetReadChunkSize is deprecated. Use the ReadChunkSize property instead.")]
        public void SetReadChunkSize(int bytes)
        {
            NativeCalls.godot_icall_1_4(method_bind_13, Object.GetPtr(this), bytes);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_read_chunk_size");

        [GodotMethod("get_read_chunk_size")]
        [Obsolete("GetReadChunkSize is deprecated. Use the ReadChunkSize property instead.")]
        public int GetReadChunkSize()
        {
            return NativeCalls.godot_icall_0_5(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_blocking_mode");

        [GodotMethod("set_blocking_mode")]
        [Obsolete("SetBlockingMode is deprecated. Use the BlockingModeEnabled property instead.")]
        public void SetBlockingMode(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_15, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_blocking_mode_enabled");

        [GodotMethod("is_blocking_mode_enabled")]
        [Obsolete("IsBlockingModeEnabled is deprecated. Use the BlockingModeEnabled property instead.")]
        public bool IsBlockingModeEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_status");

        /// <summary>
        /// <para>Returns a <see cref="Godot.HTTPClient.Status"/> constant. Need to call <see cref="Godot.HTTPClient.Poll"/> in order to get status updates.</para>
        /// </summary>
        [GodotMethod("get_status")]
        public HTTPClient.Status GetStatus()
        {
            return (HTTPClient.Status)NativeCalls.godot_icall_0_492(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "poll");

        /// <summary>
        /// <para>This needs to be called in order to have any request processed. Check results with <see cref="Godot.HTTPClient.GetStatus"/>.</para>
        /// </summary>
        [GodotMethod("poll")]
        public Error Poll()
        {
            return (Error)NativeCalls.godot_icall_0_389(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_http_proxy");

        /// <summary>
        /// <para>Sets the proxy server for HTTP requests.</para>
        /// <para>The proxy server is unset if <c>host</c> is empty or <c>port</c> is -1.</para>
        /// </summary>
        [GodotMethod("set_http_proxy")]
        public void SetHttpProxy(string host, int port)
        {
            NativeCalls.godot_icall_2_110(method_bind_19, Object.GetPtr(this), host, port);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_https_proxy");

        /// <summary>
        /// <para>Sets the proxy server for HTTPS requests.</para>
        /// <para>The proxy server is unset if <c>host</c> is empty or <c>port</c> is -1.</para>
        /// </summary>
        [GodotMethod("set_https_proxy")]
        public void SetHttpsProxy(string host, int port)
        {
            NativeCalls.godot_icall_2_110(method_bind_20, Object.GetPtr(this), host, port);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "query_string_from_dict");

        /// <summary>
        /// <para>Generates a GET/POST application/x-www-form-urlencoded style query string from a provided dictionary, e.g.:</para>
        /// <para><code>
        /// var fields = {"username": "user", "password": "pass"}
        /// var query_string = http_client.query_string_from_dict(fields)
        /// # Returns "username=user&amp;password=pass"
        /// </code></para>
        /// <para>Furthermore, if a key has a <c>null</c> value, only the key itself is added, without equal sign and value. If the value is an array, for each value in it a pair with the same key is added.</para>
        /// <para><code>
        /// var fields = {"single": 123, "not_valued": null, "multiple": [22, 33, 44]}
        /// var query_string = http_client.query_string_from_dict(fields)
        /// # Returns "single=123&amp;not_valued&amp;multiple=22&amp;multiple=33&amp;multiple=44"
        /// </code></para>
        /// </summary>
        [GodotMethod("query_string_from_dict")]
        public string QueryStringFromDict(Godot.Collections.Dictionary fields)
        {
            return NativeCalls.godot_icall_1_493(method_bind_21, Object.GetPtr(this), fields.GetPtr());
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
