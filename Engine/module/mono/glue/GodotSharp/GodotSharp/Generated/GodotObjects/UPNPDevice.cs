using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Universal Plug and Play (UPnP) device. See <see cref="Godot.UPNP"/> for UPnP discovery and utility functions. Provides low-level access to UPNP control commands. Allows to manage port mappings (port forwarding) and to query network information of the device (like local and external IP address and status). Note that methods on this class are synchronous and block the calling thread.</para>
    /// </summary>
    public partial class UPNPDevice : Reference
    {
        public enum IGDStatus
        {
            /// <summary>
            /// <para>OK.</para>
            /// </summary>
            Ok = 0,
            /// <summary>
            /// <para>HTTP error.</para>
            /// </summary>
            HttpError = 1,
            /// <summary>
            /// <para>Empty HTTP response.</para>
            /// </summary>
            HttpEmpty = 2,
            /// <summary>
            /// <para>Returned response contained no URLs.</para>
            /// </summary>
            NoUrls = 3,
            /// <summary>
            /// <para>Not a valid IGD.</para>
            /// </summary>
            NoIgd = 4,
            /// <summary>
            /// <para>Disconnected.</para>
            /// </summary>
            Disconnected = 5,
            /// <summary>
            /// <para>Unknown device.</para>
            /// </summary>
            UnknownDevice = 6,
            /// <summary>
            /// <para>Invalid control.</para>
            /// </summary>
            InvalidControl = 7,
            /// <summary>
            /// <para>Memory allocation error.</para>
            /// </summary>
            MallocError = 8,
            /// <summary>
            /// <para>Unknown error.</para>
            /// </summary>
            UnknownError = 9
        }

        /// <summary>
        /// <para>URL to the device description.</para>
        /// </summary>
        public string DescriptionUrl
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDescriptionUrl();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDescriptionUrl(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Service type.</para>
        /// </summary>
        public string ServiceType
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetServiceType();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetServiceType(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>IDG control URL.</para>
        /// </summary>
        public string IgdControlUrl
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetIgdControlUrl();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetIgdControlUrl(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>IGD service type.</para>
        /// </summary>
        public string IgdServiceType
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetIgdServiceType();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetIgdServiceType(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Address of the local machine in the network connecting it to this <see cref="Godot.UPNPDevice"/>.</para>
        /// </summary>
        public string IgdOurAddr
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetIgdOurAddr();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetIgdOurAddr(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>IGD status. See <see cref="Godot.UPNPDevice.IGDStatus"/>.</para>
        /// </summary>
        public UPNPDevice.IGDStatus IgdStatus
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetIgdStatus();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetIgdStatus(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "UPNPDevice";

        public UPNPDevice() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_UPNPDevice_Ctor(this);
        }

        internal UPNPDevice(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_valid_gateway");

        /// <summary>
        /// <para>Returns <c>true</c> if this is a valid IGD (InternetGatewayDevice) which potentially supports port forwarding.</para>
        /// </summary>
        [GodotMethod("is_valid_gateway")]
        public bool IsValidGateway()
        {
            return NativeCalls.godot_icall_0_7(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "query_external_address");

        /// <summary>
        /// <para>Returns the external IP address of this <see cref="Godot.UPNPDevice"/> or an empty string.</para>
        /// </summary>
        [GodotMethod("query_external_address")]
        public string QueryExternalAddress()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_port_mapping");

        /// <summary>
        /// <para>Adds a port mapping to forward the given external port on this <see cref="Godot.UPNPDevice"/> for the given protocol to the local machine. See <see cref="Godot.UPNP.AddPortMapping"/>.</para>
        /// </summary>
        [GodotMethod("add_port_mapping")]
        public int AddPortMapping(int port, int portInternal = 0, string desc = "", string proto = "UDP", int duration = 0)
        {
            return NativeCalls.godot_icall_5_1003(method_bind_2, Object.GetPtr(this), port, portInternal, desc, proto, duration);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "delete_port_mapping");

        /// <summary>
        /// <para>Deletes the port mapping identified by the given port and protocol combination on this device. See <see cref="Godot.UPNP.DeletePortMapping"/>.</para>
        /// </summary>
        [GodotMethod("delete_port_mapping")]
        public int DeletePortMapping(int port, string proto = "UDP")
        {
            return NativeCalls.godot_icall_2_1004(method_bind_3, Object.GetPtr(this), port, proto);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_description_url");

        [GodotMethod("set_description_url")]
        [Obsolete("SetDescriptionUrl is deprecated. Use the DescriptionUrl property instead.")]
        public void SetDescriptionUrl(string url)
        {
            NativeCalls.godot_icall_1_54(method_bind_4, Object.GetPtr(this), url);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_description_url");

        [GodotMethod("get_description_url")]
        [Obsolete("GetDescriptionUrl is deprecated. Use the DescriptionUrl property instead.")]
        public string GetDescriptionUrl()
        {
            return NativeCalls.godot_icall_0_6(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_service_type");

        [GodotMethod("set_service_type")]
        [Obsolete("SetServiceType is deprecated. Use the ServiceType property instead.")]
        public void SetServiceType(string type)
        {
            NativeCalls.godot_icall_1_54(method_bind_6, Object.GetPtr(this), type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_service_type");

        [GodotMethod("get_service_type")]
        [Obsolete("GetServiceType is deprecated. Use the ServiceType property instead.")]
        public string GetServiceType()
        {
            return NativeCalls.godot_icall_0_6(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_igd_control_url");

        [GodotMethod("set_igd_control_url")]
        [Obsolete("SetIgdControlUrl is deprecated. Use the IgdControlUrl property instead.")]
        public void SetIgdControlUrl(string url)
        {
            NativeCalls.godot_icall_1_54(method_bind_8, Object.GetPtr(this), url);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_igd_control_url");

        [GodotMethod("get_igd_control_url")]
        [Obsolete("GetIgdControlUrl is deprecated. Use the IgdControlUrl property instead.")]
        public string GetIgdControlUrl()
        {
            return NativeCalls.godot_icall_0_6(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_igd_service_type");

        [GodotMethod("set_igd_service_type")]
        [Obsolete("SetIgdServiceType is deprecated. Use the IgdServiceType property instead.")]
        public void SetIgdServiceType(string type)
        {
            NativeCalls.godot_icall_1_54(method_bind_10, Object.GetPtr(this), type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_igd_service_type");

        [GodotMethod("get_igd_service_type")]
        [Obsolete("GetIgdServiceType is deprecated. Use the IgdServiceType property instead.")]
        public string GetIgdServiceType()
        {
            return NativeCalls.godot_icall_0_6(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_igd_our_addr");

        [GodotMethod("set_igd_our_addr")]
        [Obsolete("SetIgdOurAddr is deprecated. Use the IgdOurAddr property instead.")]
        public void SetIgdOurAddr(string addr)
        {
            NativeCalls.godot_icall_1_54(method_bind_12, Object.GetPtr(this), addr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_igd_our_addr");

        [GodotMethod("get_igd_our_addr")]
        [Obsolete("GetIgdOurAddr is deprecated. Use the IgdOurAddr property instead.")]
        public string GetIgdOurAddr()
        {
            return NativeCalls.godot_icall_0_6(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_igd_status");

        [GodotMethod("set_igd_status")]
        [Obsolete("SetIgdStatus is deprecated. Use the IgdStatus property instead.")]
        public void SetIgdStatus(UPNPDevice.IGDStatus status)
        {
            NativeCalls.godot_icall_1_4(method_bind_14, Object.GetPtr(this), (int)status);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_igd_status");

        [GodotMethod("get_igd_status")]
        [Obsolete("GetIgdStatus is deprecated. Use the IgdStatus property instead.")]
        public UPNPDevice.IGDStatus GetIgdStatus()
        {
            return (UPNPDevice.IGDStatus)NativeCalls.godot_icall_0_1005(method_bind_15, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
