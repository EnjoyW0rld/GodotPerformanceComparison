using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class WebRTCPeerConnectionGDNative : WebRTCPeerConnection
    {
        private const string nativeName = "WebRTCPeerConnectionGDNative";

        public WebRTCPeerConnectionGDNative() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_WebRTCPeerConnectionGDNative_Ctor(this);
        }

        internal WebRTCPeerConnectionGDNative(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
