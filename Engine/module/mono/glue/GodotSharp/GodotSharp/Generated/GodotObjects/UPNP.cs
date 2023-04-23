using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This class can be used to discover compatible <see cref="Godot.UPNPDevice"/>s on the local network and execute commands on them, like managing port mappings (for port forwarding/NAT traversal) and querying the local and remote network IP address. Note that methods on this class are synchronous and block the calling thread.</para>
    /// <para>To forward a specific port (here <c>7777</c>, note both <see cref="Godot.UPNP.Discover"/> and <see cref="Godot.UPNP.AddPortMapping"/> can return errors that should be checked):</para>
    /// <para><code>
    /// var upnp = UPNP.new()
    /// upnp.discover()
    /// upnp.add_port_mapping(7777)
    /// </code></para>
    /// <para>To close a specific port (e.g. after you have finished using it):</para>
    /// <para><code>
    /// upnp.delete_port_mapping(port)
    /// </code></para>
    /// <para>Note: UPnP discovery blocks the current thread. To perform discovery without blocking the main thread, use <see cref="Godot.Thread"/>s like this:</para>
    /// <para><code>
    /// # Emitted when UPnP port mapping setup is completed (regardless of success or failure).
    /// signal upnp_completed(error)
    /// 
    /// # Replace this with your own server port number between 1024 and 65535.
    /// const SERVER_PORT = 3928
    /// var thread = null
    /// 
    /// func _upnp_setup(server_port):
    ///     # UPNP queries take some time.
    ///     var upnp = UPNP.new()
    ///     var err = upnp.discover()
    /// 
    ///     if err != OK:
    ///         push_error(str(err))
    ///         emit_signal("upnp_completed", err)
    ///         return
    /// 
    ///     if upnp.get_gateway() and upnp.get_gateway().is_valid_gateway():
    ///         upnp.add_port_mapping(server_port, server_port, ProjectSettings.get_setting("application/config/name"), "UDP")
    ///         upnp.add_port_mapping(server_port, server_port, ProjectSettings.get_setting("application/config/name"), "TCP")
    ///         emit_signal("upnp_completed", OK)
    /// 
    /// func _ready():
    ///     thread = Thread.new()
    ///     thread.start(self, "_upnp_setup", SERVER_PORT)
    /// 
    /// func _exit_tree():
    ///     # Wait for thread finish here to handle game exit while the thread is running.
    ///     thread.wait_to_finish()
    /// </code></para>
    /// <para>Terminology: In the context of UPnP networking, "gateway" (or "internet gateway device", short IGD) refers to network devices that allow computers in the local network to access the internet ("wide area network", WAN). These gateways are often also called "routers".</para>
    /// <para>Pitfalls:</para>
    /// <para>- As explained above, these calls are blocking and shouldn't be run on the main thread, especially as they can block for multiple seconds at a time. Use threading!</para>
    /// <para>- Networking is physical and messy. Packets get lost in transit or get filtered, addresses, free ports and assigned mappings change, and devices may leave or join the network at any time. Be mindful of this, be diligent when checking and handling errors, and handle these gracefully if you can: add clear error UI, timeouts and re-try handling.</para>
    /// <para>- Port mappings may change (and be removed) at any time, and the remote/external IP address of the gateway can change likewise. You should consider re-querying the external IP and try to update/refresh the port mapping periodically (for example, every 5 minutes and on networking failures).</para>
    /// <para>- Not all devices support UPnP, and some users disable UPnP support. You need to handle this (e.g. documenting and requiring the user to manually forward ports, or adding alternative methods of NAT traversal, like a relay/mirror server, or NAT hole punching, STUN/TURN, etc.).</para>
    /// <para>- Consider what happens on mapping conflicts. Maybe multiple users on the same network would like to play your game at the same time, or maybe another application uses the same port. Make the port configurable, and optimally choose a port automatically (re-trying with a different port on failure).</para>
    /// <para>Further reading: If you want to know more about UPnP (and the Internet Gateway Device (IGD) and Port Control Protocol (PCP) specifically), <a href="https://en.wikipedia.org/wiki/Universal_Plug_and_Play">Wikipedia</a> is a good first stop, the specification can be found at the <a href="https://openconnectivity.org/developer/specifications/upnp-resources/upnp/">Open Connectivity Foundation</a> and Godot's implementation is based on the <a href="https://github.com/miniupnp/miniupnp">MiniUPnP client</a>.</para>
    /// </summary>
    public partial class UPNP : Reference
    {
        public enum UPNPResult
        {
            /// <summary>
            /// <para>UPNP command or discovery was successful.</para>
            /// </summary>
            Success = 0,
            /// <summary>
            /// <para>Not authorized to use the command on the <see cref="Godot.UPNPDevice"/>. May be returned when the user disabled UPNP on their router.</para>
            /// </summary>
            NotAuthorized = 1,
            /// <summary>
            /// <para>No port mapping was found for the given port, protocol combination on the given <see cref="Godot.UPNPDevice"/>.</para>
            /// </summary>
            PortMappingNotFound = 2,
            /// <summary>
            /// <para>Inconsistent parameters.</para>
            /// </summary>
            InconsistentParameters = 3,
            /// <summary>
            /// <para>No such entry in array. May be returned if a given port, protocol combination is not found on an <see cref="Godot.UPNPDevice"/>.</para>
            /// </summary>
            NoSuchEntryInArray = 4,
            /// <summary>
            /// <para>The action failed.</para>
            /// </summary>
            ActionFailed = 5,
            /// <summary>
            /// <para>The <see cref="Godot.UPNPDevice"/> does not allow wildcard values for the source IP address.</para>
            /// </summary>
            SrcIpWildcardNotPermitted = 6,
            /// <summary>
            /// <para>The <see cref="Godot.UPNPDevice"/> does not allow wildcard values for the external port.</para>
            /// </summary>
            ExtPortWildcardNotPermitted = 7,
            /// <summary>
            /// <para>The <see cref="Godot.UPNPDevice"/> does not allow wildcard values for the internal port.</para>
            /// </summary>
            IntPortWildcardNotPermitted = 8,
            /// <summary>
            /// <para>The remote host value must be a wildcard.</para>
            /// </summary>
            RemoteHostMustBeWildcard = 9,
            /// <summary>
            /// <para>The external port value must be a wildcard.</para>
            /// </summary>
            ExtPortMustBeWildcard = 10,
            /// <summary>
            /// <para>No port maps are available. May also be returned if port mapping functionality is not available.</para>
            /// </summary>
            NoPortMapsAvailable = 11,
            /// <summary>
            /// <para>Conflict with other mechanism. May be returned instead of <see cref="Godot.UPNP.UPNPResult.ConflictWithOtherMapping"/> if a port mapping conflicts with an existing one.</para>
            /// </summary>
            ConflictWithOtherMechanism = 12,
            /// <summary>
            /// <para>Conflict with an existing port mapping.</para>
            /// </summary>
            ConflictWithOtherMapping = 13,
            /// <summary>
            /// <para>External and internal port values must be the same.</para>
            /// </summary>
            SamePortValuesRequired = 14,
            /// <summary>
            /// <para>Only permanent leases are supported. Do not use the <c>duration</c> parameter when adding port mappings.</para>
            /// </summary>
            OnlyPermanentLeaseSupported = 15,
            /// <summary>
            /// <para>Invalid gateway.</para>
            /// </summary>
            InvalidGateway = 16,
            /// <summary>
            /// <para>Invalid port.</para>
            /// </summary>
            InvalidPort = 17,
            /// <summary>
            /// <para>Invalid protocol.</para>
            /// </summary>
            InvalidProtocol = 18,
            /// <summary>
            /// <para>Invalid duration.</para>
            /// </summary>
            InvalidDuration = 19,
            /// <summary>
            /// <para>Invalid arguments.</para>
            /// </summary>
            InvalidArgs = 20,
            /// <summary>
            /// <para>Invalid response.</para>
            /// </summary>
            InvalidResponse = 21,
            /// <summary>
            /// <para>Invalid parameter.</para>
            /// </summary>
            InvalidParam = 22,
            /// <summary>
            /// <para>HTTP error.</para>
            /// </summary>
            HttpError = 23,
            /// <summary>
            /// <para>Socket error.</para>
            /// </summary>
            SocketError = 24,
            /// <summary>
            /// <para>Error allocating memory.</para>
            /// </summary>
            MemAllocError = 25,
            /// <summary>
            /// <para>No gateway available. You may need to call <see cref="Godot.UPNP.Discover"/> first, or discovery didn't detect any valid IGDs (InternetGatewayDevices).</para>
            /// </summary>
            NoGateway = 26,
            /// <summary>
            /// <para>No devices available. You may need to call <see cref="Godot.UPNP.Discover"/> first, or discovery didn't detect any valid <see cref="Godot.UPNPDevice"/>s.</para>
            /// </summary>
            NoDevices = 27,
            /// <summary>
            /// <para>Unknown error.</para>
            /// </summary>
            UnknownError = 28
        }

        /// <summary>
        /// <para>Multicast interface to use for discovery. Uses the default multicast interface if empty.</para>
        /// </summary>
        public string DiscoverMulticastIf
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDiscoverMulticastIf();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDiscoverMulticastIf(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>0</c>, the local port to use for discovery is chosen automatically by the system. If <c>1</c>, discovery will be done from the source port 1900 (same as destination port). Otherwise, the value will be used as the port.</para>
        /// </summary>
        public int DiscoverLocalPort
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDiscoverLocalPort();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDiscoverLocalPort(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, IPv6 is used for <see cref="Godot.UPNPDevice"/> discovery.</para>
        /// </summary>
        public bool DiscoverIpv6
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsDiscoverIpv6();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDiscoverIpv6(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "UPNP";

        public UPNP() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_UPNP_Ctor(this);
        }

        internal UPNP(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_device_count");

        /// <summary>
        /// <para>Returns the number of discovered <see cref="Godot.UPNPDevice"/>s.</para>
        /// </summary>
        [GodotMethod("get_device_count")]
        public int GetDeviceCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_device");

        /// <summary>
        /// <para>Returns the <see cref="Godot.UPNPDevice"/> at the given <c>index</c>.</para>
        /// </summary>
        [GodotMethod("get_device")]
        public UPNPDevice GetDevice(int index)
        {
            return NativeCalls.godot_icall_1_1000(method_bind_1, Object.GetPtr(this), index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_device");

        /// <summary>
        /// <para>Adds the given <see cref="Godot.UPNPDevice"/> to the list of discovered devices.</para>
        /// </summary>
        [GodotMethod("add_device")]
        public void AddDevice(UPNPDevice device)
        {
            NativeCalls.godot_icall_1_24(method_bind_2, Object.GetPtr(this), Object.GetPtr(device));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_device");

        /// <summary>
        /// <para>Sets the device at <c>index</c> from the list of discovered devices to <c>device</c>.</para>
        /// </summary>
        [GodotMethod("set_device")]
        public void SetDevice(int index, UPNPDevice device)
        {
            NativeCalls.godot_icall_2_58(method_bind_3, Object.GetPtr(this), index, Object.GetPtr(device));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_device");

        /// <summary>
        /// <para>Removes the device at <c>index</c> from the list of discovered devices.</para>
        /// </summary>
        [GodotMethod("remove_device")]
        public void RemoveDevice(int index)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_devices");

        /// <summary>
        /// <para>Clears the list of discovered devices.</para>
        /// </summary>
        [GodotMethod("clear_devices")]
        public void ClearDevices()
        {
            NativeCalls.godot_icall_0_3(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_gateway");

        /// <summary>
        /// <para>Returns the default gateway. That is the first discovered <see cref="Godot.UPNPDevice"/> that is also a valid IGD (InternetGatewayDevice).</para>
        /// </summary>
        [GodotMethod("get_gateway")]
        public UPNPDevice GetGateway()
        {
            return NativeCalls.godot_icall_0_1001(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "discover");

        /// <summary>
        /// <para>Discovers local <see cref="Godot.UPNPDevice"/>s. Clears the list of previously discovered devices.</para>
        /// <para>Filters for IGD (InternetGatewayDevice) type devices by default, as those manage port forwarding. <c>timeout</c> is the time to wait for responses in milliseconds. <c>ttl</c> is the time-to-live; only touch this if you know what you're doing.</para>
        /// <para>See <see cref="Godot.UPNP.UPNPResult"/> for possible return values.</para>
        /// </summary>
        [GodotMethod("discover")]
        public int Discover(int timeout = 2000, int ttl = 2, string deviceFilter = "InternetGatewayDevice")
        {
            return NativeCalls.godot_icall_3_1002(method_bind_7, Object.GetPtr(this), timeout, ttl, deviceFilter);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "query_external_address");

        /// <summary>
        /// <para>Returns the external <see cref="Godot.IP"/> address of the default gateway (see <see cref="Godot.UPNP.GetGateway"/>) as string. Returns an empty string on error.</para>
        /// </summary>
        [GodotMethod("query_external_address")]
        public string QueryExternalAddress()
        {
            return NativeCalls.godot_icall_0_6(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_port_mapping");

        /// <summary>
        /// <para>Adds a mapping to forward the external <c>port</c> (between 1 and 65535, although recommended to use port 1024 or above) on the default gateway (see <see cref="Godot.UPNP.GetGateway"/>) to the <c>internal_port</c> on the local machine for the given protocol <c>proto</c> (either <c>TCP</c> or <c>UDP</c>, with UDP being the default). If a port mapping for the given port and protocol combination already exists on that gateway device, this method tries to overwrite it. If that is not desired, you can retrieve the gateway manually with <see cref="Godot.UPNP.GetGateway"/> and call <see cref="Godot.UPNP.AddPortMapping"/> on it, if any. Note that forwarding a well-known port (below 1024) with UPnP may fail depending on the device.</para>
        /// <para>Depending on the gateway device, if a mapping for that port already exists, it will either be updated or it will refuse this command due to that conflict, especially if the existing mapping for that port wasn't created via UPnP or points to a different network address (or device) than this one.</para>
        /// <para>If <c>internal_port</c> is <c>0</c> (the default), the same port number is used for both the external and the internal port (the <c>port</c> value).</para>
        /// <para>The description (<c>desc</c>) is shown in some routers management UIs and can be used to point out which application added the mapping.</para>
        /// <para>The mapping's lease <c>duration</c> can be limited by specifying a duration in seconds. The default of <c>0</c> means no duration, i.e. a permanent lease and notably some devices only support these permanent leases. Note that whether permanent or not, this is only a request and the gateway may still decide at any point to remove the mapping (which usually happens on a reboot of the gateway, when its external IP address changes, or on some models when it detects a port mapping has become inactive, i.e. had no traffic for multiple minutes). If not <c>0</c> (permanent), the allowed range according to spec is between <c>120</c> (2 minutes) and <c>86400</c> seconds (24 hours).</para>
        /// <para>See <see cref="Godot.UPNP.UPNPResult"/> for possible return values.</para>
        /// </summary>
        [GodotMethod("add_port_mapping")]
        public int AddPortMapping(int port, int portInternal = 0, string desc = "", string proto = "UDP", int duration = 0)
        {
            return NativeCalls.godot_icall_5_1003(method_bind_9, Object.GetPtr(this), port, portInternal, desc, proto, duration);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "delete_port_mapping");

        /// <summary>
        /// <para>Deletes the port mapping for the given port and protocol combination on the default gateway (see <see cref="Godot.UPNP.GetGateway"/>) if one exists. <c>port</c> must be a valid port between 1 and 65535, <c>proto</c> can be either <c>TCP</c> or <c>UDP</c>. May be refused for mappings pointing to addresses other than this one, for well-known ports (below 1024), or for mappings not added via UPnP. See <see cref="Godot.UPNP.UPNPResult"/> for possible return values.</para>
        /// </summary>
        [GodotMethod("delete_port_mapping")]
        public int DeletePortMapping(int port, string proto = "UDP")
        {
            return NativeCalls.godot_icall_2_1004(method_bind_10, Object.GetPtr(this), port, proto);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_discover_multicast_if");

        [GodotMethod("set_discover_multicast_if")]
        [Obsolete("SetDiscoverMulticastIf is deprecated. Use the DiscoverMulticastIf property instead.")]
        public void SetDiscoverMulticastIf(string mIf)
        {
            NativeCalls.godot_icall_1_54(method_bind_11, Object.GetPtr(this), mIf);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_discover_multicast_if");

        [GodotMethod("get_discover_multicast_if")]
        [Obsolete("GetDiscoverMulticastIf is deprecated. Use the DiscoverMulticastIf property instead.")]
        public string GetDiscoverMulticastIf()
        {
            return NativeCalls.godot_icall_0_6(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_discover_local_port");

        [GodotMethod("set_discover_local_port")]
        [Obsolete("SetDiscoverLocalPort is deprecated. Use the DiscoverLocalPort property instead.")]
        public void SetDiscoverLocalPort(int port)
        {
            NativeCalls.godot_icall_1_4(method_bind_13, Object.GetPtr(this), port);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_discover_local_port");

        [GodotMethod("get_discover_local_port")]
        [Obsolete("GetDiscoverLocalPort is deprecated. Use the DiscoverLocalPort property instead.")]
        public int GetDiscoverLocalPort()
        {
            return NativeCalls.godot_icall_0_5(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_discover_ipv6");

        [GodotMethod("set_discover_ipv6")]
        [Obsolete("SetDiscoverIpv6 is deprecated. Use the DiscoverIpv6 property instead.")]
        public void SetDiscoverIpv6(bool ipv6)
        {
            NativeCalls.godot_icall_1_16(method_bind_15, Object.GetPtr(this), ipv6);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_discover_ipv6");

        [GodotMethod("is_discover_ipv6")]
        [Obsolete("IsDiscoverIpv6 is deprecated. Use the DiscoverIpv6 property instead.")]
        public bool IsDiscoverIpv6()
        {
            return NativeCalls.godot_icall_0_7(method_bind_16, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
