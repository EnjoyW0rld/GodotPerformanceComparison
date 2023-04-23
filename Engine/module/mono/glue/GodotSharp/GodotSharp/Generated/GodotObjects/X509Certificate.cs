using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The X509Certificate class represents an X509 certificate. Certificates can be loaded and saved like any other <see cref="Godot.Resource"/>.</para>
    /// <para>They can be used as the server certificate in <see cref="Godot.StreamPeerSSL.AcceptStream"/> (along with the proper <see cref="Godot.CryptoKey"/>), and to specify the only certificate that should be accepted when connecting to an SSL server via <see cref="Godot.StreamPeerSSL.ConnectToStream"/>.</para>
    /// </summary>
    public partial class X509Certificate : Resource
    {
        private const string nativeName = "X509Certificate";

        public X509Certificate() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_X509Certificate_Ctor(this);
        }

        internal X509Certificate(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "save");

        /// <summary>
        /// <para>Saves a certificate to the given <c>path</c> (should be a "*.crt" file).</para>
        /// </summary>
        [GodotMethod("save")]
        public Error Save(string path)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_0, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "load");

        /// <summary>
        /// <para>Loads a certificate from <c>path</c> ("*.crt" file).</para>
        /// </summary>
        [GodotMethod("load")]
        public Error Load(string path)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_1, Object.GetPtr(this), path);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
