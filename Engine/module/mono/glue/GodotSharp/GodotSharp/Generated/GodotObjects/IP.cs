using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>IP contains support functions for the Internet Protocol (IP). TCP/IP support is in different classes (see <see cref="Godot.StreamPeerTCP"/> and <see cref="Godot.TCP_Server"/>). IP provides DNS hostname resolution support, both blocking and threaded.</para>
    /// </summary>
    public static partial class IP
    {
        /// <summary>
        /// <para>Maximum number of concurrent DNS resolver queries allowed, <see cref="Godot.IP.ResolverInvalidId"/> is returned if exceeded.</para>
        /// </summary>
        public const int ResolverMaxQueries = 256;
        /// <summary>
        /// <para>Invalid ID constant. Returned if <see cref="Godot.IP.ResolverMaxQueries"/> is exceeded.</para>
        /// </summary>
        public const int ResolverInvalidId = -1;

        public enum ResolverStatus
        {
            /// <summary>
            /// <para>DNS hostname resolver status: No status.</para>
            /// </summary>
            None = 0,
            /// <summary>
            /// <para>DNS hostname resolver status: Waiting.</para>
            /// </summary>
            Waiting = 1,
            /// <summary>
            /// <para>DNS hostname resolver status: Done.</para>
            /// </summary>
            Done = 2,
            /// <summary>
            /// <para>DNS hostname resolver status: Error.</para>
            /// </summary>
            Error = 3
        }

        public enum Type
        {
            /// <summary>
            /// <para>Address type: None.</para>
            /// </summary>
            None = 0,
            /// <summary>
            /// <para>Address type: Internet protocol version 4 (IPv4).</para>
            /// </summary>
            Ipv4 = 1,
            /// <summary>
            /// <para>Address type: Internet protocol version 6 (IPv6).</para>
            /// </summary>
            Ipv6 = 2,
            /// <summary>
            /// <para>Address type: Any.</para>
            /// </summary>
            Any = 3
        }

        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(IP).Name);
                return singleton;
            }
        }

        private const string nativeName = "IP";
        internal static IntPtr ptr = NativeCalls.godot_icall_IP_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "resolve_hostname");

        /// <summary>
        /// <para>Returns a given hostname's IPv4 or IPv6 address when resolved (blocking-type method). The address type returned depends on the <see cref="Godot.IP.Type"/> constant given as <c>ip_type</c>.</para>
        /// </summary>
        [GodotMethod("resolve_hostname")]
        public static string ResolveHostname(string host, IP.Type ipType = (IP.Type)3)
        {
            return NativeCalls.godot_icall_2_139(method_bind_0, ptr, host, (int)ipType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "resolve_hostname_addresses");

        /// <summary>
        /// <para>Resolves a given hostname in a blocking way. Addresses are returned as an <see cref="Godot.Collections.Array"/> of IPv4 or IPv6 depending on <c>ip_type</c>.</para>
        /// </summary>
        [GodotMethod("resolve_hostname_addresses")]
        public static Godot.Collections.Array ResolveHostnameAddresses(string host, IP.Type ipType = (IP.Type)3)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_2_498(method_bind_1, ptr, host, (int)ipType));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "resolve_hostname_queue_item");

        /// <summary>
        /// <para>Creates a queue item to resolve a hostname to an IPv4 or IPv6 address depending on the <see cref="Godot.IP.Type"/> constant given as <c>ip_type</c>. Returns the queue ID if successful, or <see cref="Godot.IP.ResolverInvalidId"/> on error.</para>
        /// </summary>
        [GodotMethod("resolve_hostname_queue_item")]
        public static int ResolveHostnameQueueItem(string host, IP.Type ipType = (IP.Type)3)
        {
            return NativeCalls.godot_icall_2_499(method_bind_2, ptr, host, (int)ipType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_resolve_item_status");

        /// <summary>
        /// <para>Returns a queued hostname's status as a <see cref="Godot.IP.ResolverStatus"/> constant, given its queue <c>id</c>.</para>
        /// </summary>
        [GodotMethod("get_resolve_item_status")]
        public static IP.ResolverStatus GetResolveItemStatus(int id)
        {
            return (IP.ResolverStatus)NativeCalls.godot_icall_1_500(method_bind_3, ptr, id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_resolve_item_address");

        /// <summary>
        /// <para>Returns a queued hostname's IP address, given its queue <c>id</c>. Returns an empty string on error or if resolution hasn't happened yet (see <see cref="Godot.IP.GetResolveItemStatus"/>).</para>
        /// </summary>
        [GodotMethod("get_resolve_item_address")]
        public static string GetResolveItemAddress(int id)
        {
            return NativeCalls.godot_icall_1_89(method_bind_4, ptr, id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_resolve_item_addresses");

        /// <summary>
        /// <para>Return resolved addresses, or an empty array if an error happened or resolution didn't happen yet (see <see cref="Godot.IP.GetResolveItemStatus"/>).</para>
        /// </summary>
        [GodotMethod("get_resolve_item_addresses")]
        public static Godot.Collections.Array GetResolveItemAddresses(int id)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_1_483(method_bind_5, ptr, id));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "erase_resolve_item");

        /// <summary>
        /// <para>Removes a given item <c>id</c> from the queue. This should be used to free a queue after it has completed to enable more queries to happen.</para>
        /// </summary>
        [GodotMethod("erase_resolve_item")]
        public static void EraseResolveItem(int id)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, ptr, id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_local_addresses");

        /// <summary>
        /// <para>Returns all the user's current IPv4 and IPv6 addresses as an array.</para>
        /// </summary>
        [GodotMethod("get_local_addresses")]
        public static Godot.Collections.Array GetLocalAddresses()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_7, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_local_interfaces");

        /// <summary>
        /// <para>Returns all network adapters as an array.</para>
        /// <para>Each adapter is a dictionary of the form:</para>
        /// <para><code>
        /// {
        ///     "index": "1", # Interface index.
        ///     "name": "eth0", # Interface name.
        ///     "friendly": "Ethernet One", # A friendly name (might be empty).
        ///     "addresses": ["192.168.1.101"], # An array of IP addresses associated to this interface.
        /// }
        /// </code></para>
        /// </summary>
        [GodotMethod("get_local_interfaces")]
        public static Godot.Collections.Array GetLocalInterfaces()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_8, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_cache");

        /// <summary>
        /// <para>Removes all of a <c>hostname</c>'s cached references. If no <c>hostname</c> is given, all cached IP addresses are removed.</para>
        /// </summary>
        [GodotMethod("clear_cache")]
        public static void ClearCache(string hostname = "")
        {
            NativeCalls.godot_icall_1_54(method_bind_9, ptr, hostname);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
