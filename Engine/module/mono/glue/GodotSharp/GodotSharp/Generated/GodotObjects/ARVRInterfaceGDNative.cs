using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This is a wrapper class for GDNative implementations of the ARVR interface. To use a GDNative ARVR interface, simply instantiate this object and set your GDNative library containing the ARVR interface implementation.</para>
    /// </summary>
    public partial class ARVRInterfaceGDNative : ARVRInterface
    {
        private const string nativeName = "ARVRInterfaceGDNative";

        public ARVRInterfaceGDNative() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ARVRInterfaceGDNative_Ctor(this);
        }

        internal ARVRInterfaceGDNative(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
