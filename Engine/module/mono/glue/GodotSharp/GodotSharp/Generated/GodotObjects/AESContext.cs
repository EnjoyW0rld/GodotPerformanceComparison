using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This class provides access to AES encryption/decryption of raw data. Both AES-ECB and AES-CBC mode are supported.</para>
    /// <para><code>
    /// extends Node
    /// 
    /// var aes = AESContext.new()
    /// 
    /// func _ready():
    ///     var key = "My secret key!!!" # Key must be either 16 or 32 bytes.
    ///     var data = "My secret text!!" # Data size must be multiple of 16 bytes, apply padding if needed.
    ///     # Encrypt ECB
    ///     aes.start(AESContext.MODE_ECB_ENCRYPT, key.to_utf8())
    ///     var encrypted = aes.update(data.to_utf8())
    ///     aes.finish()
    ///     # Decrypt ECB
    ///     aes.start(AESContext.MODE_ECB_DECRYPT, key.to_utf8())
    ///     var decrypted = aes.update(encrypted)
    ///     aes.finish()
    ///     # Check ECB
    ///     assert(decrypted == data.to_utf8())
    /// 
    ///     var iv = "My secret iv!!!!" # IV must be of exactly 16 bytes.
    ///     # Encrypt CBC
    ///     aes.start(AESContext.MODE_CBC_ENCRYPT, key.to_utf8(), iv.to_utf8())
    ///     encrypted = aes.update(data.to_utf8())
    ///     aes.finish()
    ///     # Decrypt CBC
    ///     aes.start(AESContext.MODE_CBC_DECRYPT, key.to_utf8(), iv.to_utf8())
    ///     decrypted = aes.update(encrypted)
    ///     aes.finish()
    ///     # Check CBC
    ///     assert(decrypted == data.to_utf8())
    /// </code></para>
    /// </summary>
    public partial class AESContext : Reference
    {
        public enum Mode
        {
            /// <summary>
            /// <para>AES electronic codebook encryption mode.</para>
            /// </summary>
            EcbEncrypt = 0,
            /// <summary>
            /// <para>AES electronic codebook decryption mode.</para>
            /// </summary>
            EcbDecrypt = 1,
            /// <summary>
            /// <para>AES cipher blocker chaining encryption mode.</para>
            /// </summary>
            CbcEncrypt = 2,
            /// <summary>
            /// <para>AES cipher blocker chaining decryption mode.</para>
            /// </summary>
            CbcDecrypt = 3,
            /// <summary>
            /// <para>Maximum value for the mode enum.</para>
            /// </summary>
            Max = 4
        }

        private const string nativeName = "AESContext";

        public AESContext() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AESContext_Ctor(this);
        }

        internal AESContext(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "start");

        /// <summary>
        /// <para>Start the AES context in the given <c>mode</c>. A <c>key</c> of either 16 or 32 bytes must always be provided, while an <c>iv</c> (initialization vector) of exactly 16 bytes, is only needed when <c>mode</c> is either <see cref="Godot.AESContext.Mode.CbcEncrypt"/> or <see cref="Godot.AESContext.Mode.CbcDecrypt"/>.</para>
        /// </summary>
        /// <param name="iv">If the parameter is null, then the default value is Array.Empty&lt;byte&gt;()</param>
        [GodotMethod("start")]
        public Error Start(AESContext.Mode mode, byte[] key, byte[] iv = null)
        {
            byte[] iv_in = iv != null ? iv : Array.Empty<byte>();
            return (Error)NativeCalls.godot_icall_3_0(method_bind_0, Object.GetPtr(this), (int)mode, key, iv_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "update");

        /// <summary>
        /// <para>Run the desired operation for this AES context. Will return a <see cref="byte"/> containing the result of encrypting (or decrypting) the given <c>src</c>. See <see cref="Godot.AESContext.Start"/> for mode of operation.</para>
        /// <para>Note: The size of <c>src</c> must be a multiple of 16. Apply some padding if needed.</para>
        /// </summary>
        [GodotMethod("update")]
        public byte[] Update(byte[] src)
        {
            return NativeCalls.godot_icall_1_1(method_bind_1, Object.GetPtr(this), src);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_iv_state");

        /// <summary>
        /// <para>Get the current IV state for this context (IV gets updated when calling <see cref="Godot.AESContext.Update"/>). You normally don't need this function.</para>
        /// <para>Note: This function only makes sense when the context is started with <see cref="Godot.AESContext.Mode.CbcEncrypt"/> or <see cref="Godot.AESContext.Mode.CbcDecrypt"/>.</para>
        /// </summary>
        [GodotMethod("get_iv_state")]
        public byte[] GetIvState()
        {
            return NativeCalls.godot_icall_0_2(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "finish");

        /// <summary>
        /// <para>Close this AES context so it can be started again. See <see cref="Godot.AESContext.Start"/>.</para>
        /// </summary>
        [GodotMethod("finish")]
        public void Finish()
        {
            NativeCalls.godot_icall_0_3(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
