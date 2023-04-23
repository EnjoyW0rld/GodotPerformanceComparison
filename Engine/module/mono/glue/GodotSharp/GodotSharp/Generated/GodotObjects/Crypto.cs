using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The Crypto class allows you to access some more advanced cryptographic functionalities in Godot.</para>
    /// <para>For now, this includes generating cryptographically secure random bytes, RSA keys and self-signed X509 certificates generation, asymmetric key encryption/decryption, and signing/verification.</para>
    /// <para><code>
    /// extends Node
    /// 
    /// var crypto = Crypto.new()
    /// var key = CryptoKey.new()
    /// var cert = X509Certificate.new()
    /// 
    /// func _ready():
    ///     # Generate new RSA key.
    ///     key = crypto.generate_rsa(4096)
    ///     # Generate new self-signed certificate with the given key.
    ///     cert = crypto.generate_self_signed_certificate(key, "CN=mydomain.com,O=My Game Company,C=IT")
    ///     # Save key and certificate in the user folder.
    ///     key.save("user://generated.key")
    ///     cert.save("user://generated.crt")
    ///     # Encryption
    ///     var data = "Some data"
    ///     var encrypted = crypto.encrypt(key, data.to_utf8())
    ///     # Decryption
    ///     var decrypted = crypto.decrypt(key, encrypted)
    ///     # Signing
    ///     var signature = crypto.sign(HashingContext.HASH_SHA256, data.sha256_buffer(), key)
    ///     # Verifying
    ///     var verified = crypto.verify(HashingContext.HASH_SHA256, data.sha256_buffer(), signature, key)
    ///     # Checks
    ///     assert(verified)
    ///     assert(data.to_utf8() == decrypted)
    /// </code></para>
    /// <para>Note: Not available in HTML5 exports.</para>
    /// </summary>
    public partial class Crypto : Reference
    {
        private const string nativeName = "Crypto";

        public Crypto() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Crypto_Ctor(this);
        }

        internal Crypto(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "generate_random_bytes");

        /// <summary>
        /// <para>Generates a <see cref="byte"/> of cryptographically secure random bytes with given <c>size</c>.</para>
        /// </summary>
        [GodotMethod("generate_random_bytes")]
        public byte[] GenerateRandomBytes(int size)
        {
            return NativeCalls.godot_icall_1_329(method_bind_0, Object.GetPtr(this), size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "generate_rsa");

        /// <summary>
        /// <para>Generates an RSA <see cref="Godot.CryptoKey"/> that can be used for creating self-signed certificates and passed to <see cref="Godot.StreamPeerSSL.AcceptStream"/>.</para>
        /// </summary>
        [GodotMethod("generate_rsa")]
        public CryptoKey GenerateRsa(int size)
        {
            return NativeCalls.godot_icall_1_330(method_bind_1, Object.GetPtr(this), size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "generate_self_signed_certificate");

        /// <summary>
        /// <para>Generates a self-signed <see cref="Godot.X509Certificate"/> from the given <see cref="Godot.CryptoKey"/> and <c>issuer_name</c>. The certificate validity will be defined by <c>not_before</c> and <c>not_after</c> (first valid date and last valid date). The <c>issuer_name</c> must contain at least "CN=" (common name, i.e. the domain name), "O=" (organization, i.e. your company name), "C=" (country, i.e. 2 lettered ISO-3166 code of the country the organization is based in).</para>
        /// <para>A small example to generate an RSA key and a X509 self-signed certificate.</para>
        /// <para><code>
        /// var crypto = Crypto.new()
        /// # Generate 4096 bits RSA key.
        /// var key = crypto.generate_rsa(4096)
        /// # Generate self-signed certificate using the given key.
        /// var cert = crypto.generate_self_signed_certificate(key, "CN=example.com,O=A Game Company,C=IT")
        /// </code></para>
        /// </summary>
        [GodotMethod("generate_self_signed_certificate")]
        public X509Certificate GenerateSelfSignedCertificate(CryptoKey key, string issuerName = "CN=myserver,O=myorganisation,C=IT", string notBefore = "20140101000000", string notAfter = "20340101000000")
        {
            return NativeCalls.godot_icall_4_331(method_bind_2, Object.GetPtr(this), Object.GetPtr(key), issuerName, notBefore, notAfter);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "sign");

        /// <summary>
        /// <para>Sign a given <c>hash</c> of type <c>hash_type</c> with the provided private <c>key</c>.</para>
        /// </summary>
        [GodotMethod("sign")]
        public byte[] Sign(HashingContext.HashType hashType, byte[] hash, CryptoKey key)
        {
            return NativeCalls.godot_icall_3_332(method_bind_3, Object.GetPtr(this), (int)hashType, hash, Object.GetPtr(key));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "verify");

        /// <summary>
        /// <para>Verify that a given <c>signature</c> for <c>hash</c> of type <c>hash_type</c> against the provided public <c>key</c>.</para>
        /// </summary>
        [GodotMethod("verify")]
        public bool Verify(HashingContext.HashType hashType, byte[] hash, byte[] signature, CryptoKey key)
        {
            return NativeCalls.godot_icall_4_333(method_bind_4, Object.GetPtr(this), (int)hashType, hash, signature, Object.GetPtr(key));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "encrypt");

        /// <summary>
        /// <para>Encrypt the given <c>plaintext</c> with the provided public <c>key</c>.</para>
        /// <para>Note: The maximum size of accepted plaintext is limited by the key size.</para>
        /// </summary>
        [GodotMethod("encrypt")]
        public byte[] Encrypt(CryptoKey key, byte[] plaintext)
        {
            return NativeCalls.godot_icall_2_334(method_bind_5, Object.GetPtr(this), Object.GetPtr(key), plaintext);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "decrypt");

        /// <summary>
        /// <para>Decrypt the given <c>ciphertext</c> with the provided private <c>key</c>.</para>
        /// <para>Note: The maximum size of accepted ciphertext is limited by the key size.</para>
        /// </summary>
        [GodotMethod("decrypt")]
        public byte[] Decrypt(CryptoKey key, byte[] ciphertext)
        {
            return NativeCalls.godot_icall_2_334(method_bind_6, Object.GetPtr(this), Object.GetPtr(key), ciphertext);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "hmac_digest");

        /// <summary>
        /// <para>Generates an <a href="https://en.wikipedia.org/wiki/HMAC">HMAC</a> digest of <c>msg</c> using <c>key</c>. The <c>hash_type</c> parameter is the hashing algorithm that is used for the inner and outer hashes.</para>
        /// <para>Currently, only <see cref="Godot.HashingContext.HashType.Sha256"/> and <see cref="Godot.HashingContext.HashType.Sha1"/> are supported.</para>
        /// </summary>
        [GodotMethod("hmac_digest")]
        public byte[] HmacDigest(HashingContext.HashType hashType, byte[] key, byte[] msg)
        {
            return NativeCalls.godot_icall_3_335(method_bind_7, Object.GetPtr(this), (int)hashType, key, msg);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "constant_time_compare");

        /// <summary>
        /// <para>Compares two <see cref="byte"/>s for equality without leaking timing information in order to prevent timing attacks.</para>
        /// <para>See <a href="https://paragonie.com/blog/2015/11/preventing-timing-attacks-on-string-comparison-with-double-hmac-strategy">this blog post</a> for more information.</para>
        /// </summary>
        [GodotMethod("constant_time_compare")]
        public bool ConstantTimeCompare(byte[] trusted, byte[] received)
        {
            return NativeCalls.godot_icall_2_336(method_bind_8, Object.GetPtr(this), trusted, received);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
