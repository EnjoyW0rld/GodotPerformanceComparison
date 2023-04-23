using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The CryptoKey class represents a cryptographic key. Keys can be loaded and saved like any other <see cref="Godot.Resource"/>.</para>
    /// <para>They can be used to generate a self-signed <see cref="Godot.X509Certificate"/> via <see cref="Godot.Crypto.GenerateSelfSignedCertificate"/> and as private key in <see cref="Godot.StreamPeerSSL.AcceptStream"/> along with the appropriate certificate.</para>
    /// </summary>
    public partial class CryptoKey : Resource
    {
        private const string nativeName = "CryptoKey";

        public CryptoKey() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CryptoKey_Ctor(this);
        }

        internal CryptoKey(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "save");

        /// <summary>
        /// <para>Saves a key to the given <c>path</c>. If <c>public_only</c> is <c>true</c>, only the public key will be saved.</para>
        /// <para>Note: <c>path</c> should be a "*.pub" file if <c>public_only</c> is <c>true</c>, a "*.key" file otherwise.</para>
        /// </summary>
        [GodotMethod("save")]
        public Error Save(string path, bool publicOnly = false)
        {
            return (Error)NativeCalls.godot_icall_2_337(method_bind_0, Object.GetPtr(this), path, publicOnly);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "load");

        /// <summary>
        /// <para>Loads a key from <c>path</c>. If <c>public_only</c> is <c>true</c>, only the public key will be loaded.</para>
        /// <para>Note: <c>path</c> should be a "*.pub" file if <c>public_only</c> is <c>true</c>, a "*.key" file otherwise.</para>
        /// </summary>
        [GodotMethod("load")]
        public Error Load(string path, bool publicOnly = false)
        {
            return (Error)NativeCalls.godot_icall_2_337(method_bind_1, Object.GetPtr(this), path, publicOnly);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_public_only");

        /// <summary>
        /// <para>Return <c>true</c> if this CryptoKey only has the public part, and not the private one.</para>
        /// </summary>
        [GodotMethod("is_public_only")]
        public bool IsPublicOnly()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "save_to_string");

        /// <summary>
        /// <para>Returns a string containing the key in PEM format. If <c>public_only</c> is <c>true</c>, only the public key will be included.</para>
        /// </summary>
        [GodotMethod("save_to_string")]
        public string SaveToString(bool publicOnly = false)
        {
            return NativeCalls.godot_icall_1_338(method_bind_3, Object.GetPtr(this), publicOnly);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "load_from_string");

        /// <summary>
        /// <para>Loads a key from the given <c>string</c>. If <c>public_only</c> is <c>true</c>, only the public key will be loaded.</para>
        /// </summary>
        [GodotMethod("load_from_string")]
        public Error LoadFromString(string stringKey, bool publicOnly = false)
        {
            return (Error)NativeCalls.godot_icall_2_337(method_bind_4, Object.GetPtr(this), stringKey, publicOnly);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
