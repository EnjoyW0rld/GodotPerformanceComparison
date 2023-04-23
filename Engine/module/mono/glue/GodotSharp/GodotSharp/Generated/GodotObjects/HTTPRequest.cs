using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A node with the ability to send HTTP requests. Uses <see cref="Godot.HTTPClient"/> internally.</para>
    /// <para>Can be used to make HTTP requests, i.e. download or upload files or web content via HTTP.</para>
    /// <para>Warning: See the notes and warnings on <see cref="Godot.HTTPClient"/> for limitations, especially regarding SSL security.</para>
    /// <para>Example of contacting a REST API and printing one of its returned fields:</para>
    /// <para><code>
    /// func _ready():
    ///     # Create an HTTP request node and connect its completion signal.
    ///     var http_request = HTTPRequest.new()
    ///     add_child(http_request)
    ///     http_request.connect("request_completed", self, "_http_request_completed")
    /// 
    ///     # Perform a GET request. The URL below returns JSON as of writing.
    ///     var error = http_request.request("https://httpbin.org/get")
    ///     if error != OK:
    ///         push_error("An error occurred in the HTTP request.")
    /// 
    ///     # Perform a POST request. The URL below returns JSON as of writing.
    ///     # Note: Don't make simultaneous requests using a single HTTPRequest node.
    ///     # The snippet below is provided for reference only.
    ///     var body = to_json({"name": "Godette"})
    ///     error = http_request.request("https://httpbin.org/post", [], true, HTTPClient.METHOD_POST, body)
    ///     if error != OK:
    ///         push_error("An error occurred in the HTTP request.")
    /// 
    /// 
    /// # Called when the HTTP request is completed.
    /// func _http_request_completed(result, response_code, headers, body):
    ///     var response = parse_json(body.get_string_from_utf8())
    /// 
    ///     # Will print the user agent string used by the HTTPRequest node (as recognized by httpbin.org).
    ///     print(response.headers["User-Agent"])
    /// </code></para>
    /// <para>Example of loading and displaying an image using HTTPRequest:</para>
    /// <para><code>
    /// func _ready():
    ///     # Create an HTTP request node and connect its completion signal.
    ///     var http_request = HTTPRequest.new()
    ///     add_child(http_request)
    ///     http_request.connect("request_completed", self, "_http_request_completed")
    /// 
    ///     # Perform the HTTP request. The URL below returns a PNG image as of writing.
    ///     var error = http_request.request("https://via.placeholder.com/512")
    ///     if error != OK:
    ///         push_error("An error occurred in the HTTP request.")
    /// 
    /// 
    /// # Called when the HTTP request is completed.
    /// func _http_request_completed(result, response_code, headers, body):
    ///     var image = Image.new()
    ///     var error = image.load_png_from_buffer(body)
    ///     if error != OK:
    ///         push_error("Couldn't load the image.")
    /// 
    ///     var texture = ImageTexture.new()
    ///     texture.create_from_image(image)
    /// 
    ///     # Display the image in a TextureRect node.
    ///     var texture_rect = TextureRect.new()
    ///     add_child(texture_rect)
    ///     texture_rect.texture = texture
    /// </code></para>
    /// </summary>
    public partial class HTTPRequest : Node
    {
        public enum Result
        {
            /// <summary>
            /// <para>Request successful.</para>
            /// </summary>
            Success = 0,
            ChunkedBodySizeMismatch = 1,
            /// <summary>
            /// <para>Request failed while connecting.</para>
            /// </summary>
            CantConnect = 2,
            /// <summary>
            /// <para>Request failed while resolving.</para>
            /// </summary>
            CantResolve = 3,
            /// <summary>
            /// <para>Request failed due to connection (read/write) error.</para>
            /// </summary>
            ConnectionError = 4,
            /// <summary>
            /// <para>Request failed on SSL handshake.</para>
            /// </summary>
            SslHandshakeError = 5,
            /// <summary>
            /// <para>Request does not have a response (yet).</para>
            /// </summary>
            NoResponse = 6,
            /// <summary>
            /// <para>Request exceeded its maximum size limit, see <see cref="Godot.HTTPRequest.BodySizeLimit"/>.</para>
            /// </summary>
            BodySizeLimitExceeded = 7,
            /// <summary>
            /// <para>Request failed (currently unused).</para>
            /// </summary>
            RequestFailed = 8,
            /// <summary>
            /// <para>HTTPRequest couldn't open the download file.</para>
            /// </summary>
            DownloadFileCantOpen = 9,
            /// <summary>
            /// <para>HTTPRequest couldn't write to the download file.</para>
            /// </summary>
            DownloadFileWriteError = 10,
            /// <summary>
            /// <para>Request reached its maximum redirect limit, see <see cref="Godot.HTTPRequest.MaxRedirects"/>.</para>
            /// </summary>
            RedirectLimitReached = 11,
            Timeout = 12
        }

        /// <summary>
        /// <para>The file to download into. If set to a non-empty string, the request output will be written to the file located at the path. If a file already exists at the specified location, it will be overwritten as soon as body data begins to be received.</para>
        /// <para>Note: Folders are not automatically created when the file is created. If <see cref="Godot.HTTPRequest.DownloadFile"/> points to a subfolder, it's recommended to create the necessary folders beforehand using <see cref="Godot.Directory.MakeDirRecursive"/> to ensure the file can be written.</para>
        /// </summary>
        public string DownloadFile
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDownloadFile();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDownloadFile(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The size of the buffer used and maximum bytes to read per iteration. See <see cref="Godot.HTTPClient.ReadChunkSize"/>.</para>
        /// <para>Set this to a lower value (e.g. 4096 for 4 KiB) when downloading small files to decrease memory usage at the cost of download speeds.</para>
        /// </summary>
        public int DownloadChunkSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDownloadChunkSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDownloadChunkSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, multithreading is used to improve performance.</para>
        /// </summary>
        public bool UseThreads
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUsingThreads();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseThreads(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Maximum allowed size for response bodies (<c>-1</c> means no limit). When only small files are expected, this can be used to prevent disallow receiving files that are too large, preventing potential denial of service attacks.</para>
        /// </summary>
        public int BodySizeLimit
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBodySizeLimit();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBodySizeLimit(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Maximum number of allowed redirects. This is used to prevent endless redirect loops.</para>
        /// </summary>
        public int MaxRedirects
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaxRedirects();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaxRedirects(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If set to a value greater than <c>0.0</c> before the request starts, the HTTP request will time out after <c>timeout</c> seconds have passed and the request is not completed yet. For small HTTP requests such as REST API usage, set <see cref="Godot.HTTPRequest.Timeout"/> to a value between <c>10.0</c> and <c>30.0</c> to prevent the application from getting stuck if the request fails to get a response in a timely manner. For file downloads, leave this to <c>0.0</c> to prevent the download from failing if it takes too much time.</para>
        /// </summary>
        public double Timeout
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTimeout();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTimeout(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "HTTPRequest";

        public HTTPRequest() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_HTTPRequest_Ctor(this);
        }

        internal HTTPRequest(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "request_raw");

        /// <summary>
        /// <para>Creates request on the underlying <see cref="Godot.HTTPClient"/> using a raw array of bytes for the request body. If there is no configuration errors, it tries to connect using <see cref="Godot.HTTPClient.ConnectToHost"/> and passes parameters onto <see cref="Godot.HTTPClient.Request"/>.</para>
        /// <para>Returns <c>OK</c> if request is successfully created. (Does not imply that the server has responded), <c>ERR_UNCONFIGURED</c> if not in the tree, <c>ERR_BUSY</c> if still processing previous request, <c>ERR_INVALID_PARAMETER</c> if given string is not a valid URL format, or <c>ERR_CANT_CONNECT</c> if not using thread and the <see cref="Godot.HTTPClient"/> cannot connect to host.</para>
        /// </summary>
        /// <param name="customHeaders">If the parameter is null, then the default value is Array.Empty&lt;string&gt;()</param>
        /// <param name="requestDataRaw">If the parameter is null, then the default value is Array.Empty&lt;byte&gt;()</param>
        [GodotMethod("request_raw")]
        public Error RequestRaw(string url, string[] customHeaders = null, bool sslValidateDomain = true, HTTPClient.Method method = (HTTPClient.Method)0, byte[] requestDataRaw = null)
        {
            string[] customHeaders_in = customHeaders != null ? customHeaders : Array.Empty<string>();
            byte[] requestDataRaw_in = requestDataRaw != null ? requestDataRaw : Array.Empty<byte>();
            return (Error)NativeCalls.godot_icall_5_494(method_bind_0, Object.GetPtr(this), url, customHeaders_in, sslValidateDomain, (int)method, requestDataRaw_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "request");

        /// <summary>
        /// <para>Creates request on the underlying <see cref="Godot.HTTPClient"/>. If there is no configuration errors, it tries to connect using <see cref="Godot.HTTPClient.ConnectToHost"/> and passes parameters onto <see cref="Godot.HTTPClient.Request"/>.</para>
        /// <para>Returns <c>OK</c> if request is successfully created. (Does not imply that the server has responded), <c>ERR_UNCONFIGURED</c> if not in the tree, <c>ERR_BUSY</c> if still processing previous request, <c>ERR_INVALID_PARAMETER</c> if given string is not a valid URL format, or <c>ERR_CANT_CONNECT</c> if not using thread and the <see cref="Godot.HTTPClient"/> cannot connect to host.</para>
        /// <para>Note: When <c>method</c> is <see cref="Godot.HTTPClient.Method.Get"/>, the payload sent via <c>request_data</c> might be ignored by the server or even cause the server to reject the request (check <a href="https://datatracker.ietf.org/doc/html/rfc7231#section-4.3.1">RFC 7231 section 4.3.1</a> for more details). As a workaround, you can send data as a query string in the URL. See <c>String.http_escape</c> for an example.</para>
        /// </summary>
        /// <param name="customHeaders">If the parameter is null, then the default value is Array.Empty&lt;string&gt;()</param>
        [GodotMethod("request")]
        public Error Request(string url, string[] customHeaders = null, bool sslValidateDomain = true, HTTPClient.Method method = (HTTPClient.Method)0, string requestData = "")
        {
            string[] customHeaders_in = customHeaders != null ? customHeaders : Array.Empty<string>();
            return (Error)NativeCalls.godot_icall_5_495(method_bind_1, Object.GetPtr(this), url, customHeaders_in, sslValidateDomain, (int)method, requestData);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "cancel_request");

        /// <summary>
        /// <para>Cancels the current request.</para>
        /// </summary>
        [GodotMethod("cancel_request")]
        public void CancelRequest()
        {
            NativeCalls.godot_icall_0_3(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_http_client_status");

        /// <summary>
        /// <para>Returns the current status of the underlying <see cref="Godot.HTTPClient"/>. See <see cref="Godot.HTTPClient.Status"/>.</para>
        /// </summary>
        [GodotMethod("get_http_client_status")]
        public HTTPClient.Status GetHttpClientStatus()
        {
            return (HTTPClient.Status)NativeCalls.godot_icall_0_492(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_threads");

        [GodotMethod("set_use_threads")]
        [Obsolete("SetUseThreads is deprecated. Use the UseThreads property instead.")]
        public void SetUseThreads(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_using_threads");

        [GodotMethod("is_using_threads")]
        [Obsolete("IsUsingThreads is deprecated. Use the UseThreads property instead.")]
        public bool IsUsingThreads()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_body_size_limit");

        [GodotMethod("set_body_size_limit")]
        [Obsolete("SetBodySizeLimit is deprecated. Use the BodySizeLimit property instead.")]
        public void SetBodySizeLimit(int bytes)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), bytes);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_body_size_limit");

        [GodotMethod("get_body_size_limit")]
        [Obsolete("GetBodySizeLimit is deprecated. Use the BodySizeLimit property instead.")]
        public int GetBodySizeLimit()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max_redirects");

        [GodotMethod("set_max_redirects")]
        [Obsolete("SetMaxRedirects is deprecated. Use the MaxRedirects property instead.")]
        public void SetMaxRedirects(int amount)
        {
            NativeCalls.godot_icall_1_4(method_bind_8, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max_redirects");

        [GodotMethod("get_max_redirects")]
        [Obsolete("GetMaxRedirects is deprecated. Use the MaxRedirects property instead.")]
        public int GetMaxRedirects()
        {
            return NativeCalls.godot_icall_0_5(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_download_file");

        [GodotMethod("set_download_file")]
        [Obsolete("SetDownloadFile is deprecated. Use the DownloadFile property instead.")]
        public void SetDownloadFile(string path)
        {
            NativeCalls.godot_icall_1_54(method_bind_10, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_download_file");

        [GodotMethod("get_download_file")]
        [Obsolete("GetDownloadFile is deprecated. Use the DownloadFile property instead.")]
        public string GetDownloadFile()
        {
            return NativeCalls.godot_icall_0_6(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_downloaded_bytes");

        /// <summary>
        /// <para>Returns the amount of bytes this HTTPRequest downloaded.</para>
        /// </summary>
        [GodotMethod("get_downloaded_bytes")]
        public int GetDownloadedBytes()
        {
            return NativeCalls.godot_icall_0_5(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_body_size");

        /// <summary>
        /// <para>Returns the response body length.</para>
        /// <para>Note: Some Web servers may not send a body length. In this case, the value returned will be <c>-1</c>. If using chunked transfer encoding, the body length will also be <c>-1</c>.</para>
        /// </summary>
        [GodotMethod("get_body_size")]
        public int GetBodySize()
        {
            return NativeCalls.godot_icall_0_5(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_timeout");

        [GodotMethod("set_timeout")]
        [Obsolete("SetTimeout is deprecated. Use the Timeout property instead.")]
        public void SetTimeout(double timeout)
        {
            NativeCalls.godot_icall_1_496(method_bind_14, Object.GetPtr(this), timeout);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_timeout");

        [GodotMethod("get_timeout")]
        [Obsolete("GetTimeout is deprecated. Use the Timeout property instead.")]
        public double GetTimeout()
        {
            return NativeCalls.godot_icall_0_179(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_download_chunk_size");

        [GodotMethod("set_download_chunk_size")]
        [Obsolete("SetDownloadChunkSize is deprecated. Use the DownloadChunkSize property instead.")]
        public void SetDownloadChunkSize(int chunkSize)
        {
            NativeCalls.godot_icall_1_4(method_bind_16, Object.GetPtr(this), chunkSize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_download_chunk_size");

        [GodotMethod("get_download_chunk_size")]
        [Obsolete("GetDownloadChunkSize is deprecated. Use the DownloadChunkSize property instead.")]
        public int GetDownloadChunkSize()
        {
            return NativeCalls.godot_icall_0_5(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_http_proxy");

        /// <summary>
        /// <para>Sets the proxy server for HTTP requests.</para>
        /// <para>The proxy server is unset if <c>host</c> is empty or <c>port</c> is -1.</para>
        /// </summary>
        [GodotMethod("set_http_proxy")]
        public void SetHttpProxy(string host, int port)
        {
            NativeCalls.godot_icall_2_110(method_bind_18, Object.GetPtr(this), host, port);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_https_proxy");

        /// <summary>
        /// <para>Sets the proxy server for HTTPS requests.</para>
        /// <para>The proxy server is unset if <c>host</c> is empty or <c>port</c> is -1.</para>
        /// </summary>
        [GodotMethod("set_https_proxy")]
        public void SetHttpsProxy(string host, int port)
        {
            NativeCalls.godot_icall_2_110(method_bind_19, Object.GetPtr(this), host, port);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
