using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The HashingContext class provides an interface for computing cryptographic hashes over multiple iterations. This is useful for example when computing hashes of big files (so you don't have to load them all in memory), network streams, and data streams in general (so you don't have to hold buffers).</para>
    /// <para>The <see cref="Godot.HashingContext.HashType"/> enum shows the supported hashing algorithms.</para>
    /// <para><code>
    /// const CHUNK_SIZE = 1024
    /// 
    /// func hash_file(path):
    ///     var ctx = HashingContext.new()
    ///     var file = File.new()
    ///     # Start a SHA-256 context.
    ///     ctx.start(HashingContext.HASH_SHA256)
    ///     # Check that file exists.
    ///     if not file.file_exists(path):
    ///         return
    ///     # Open the file to hash.
    ///     file.open(path, File.READ)
    ///     # Update the context after reading each chunk.
    ///     while not file.eof_reached():
    ///         ctx.update(file.get_buffer(CHUNK_SIZE))
    ///     # Get the computed hash.
    ///     var res = ctx.finish()
    ///     # Print the result as hex string and array.
    ///     printt(res.hex_encode(), Array(res))
    /// </code></para>
    /// </summary>
    public partial class HashingContext : Reference
    {
        public enum HashType
        {
            /// <summary>
            /// <para>Hashing algorithm: MD5.</para>
            /// </summary>
            Md5 = 0,
            /// <summary>
            /// <para>Hashing algorithm: SHA-1.</para>
            /// </summary>
            Sha1 = 1,
            /// <summary>
            /// <para>Hashing algorithm: SHA-256.</para>
            /// </summary>
            Sha256 = 2
        }

        private const string nativeName = "HashingContext";

        public HashingContext() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_HashingContext_Ctor(this);
        }

        internal HashingContext(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "start");

        /// <summary>
        /// <para>Starts a new hash computation of the given <c>type</c> (e.g. <see cref="Godot.HashingContext.HashType.Sha256"/> to start computation of a SHA-256).</para>
        /// </summary>
        [GodotMethod("start")]
        public Error Start(HashingContext.HashType type)
        {
            return (Error)NativeCalls.godot_icall_1_497(method_bind_0, Object.GetPtr(this), (int)type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "update");

        /// <summary>
        /// <para>Updates the computation with the given <c>chunk</c> of data.</para>
        /// </summary>
        [GodotMethod("update")]
        public Error Update(byte[] chunk)
        {
            return (Error)NativeCalls.godot_icall_1_487(method_bind_1, Object.GetPtr(this), chunk);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "finish");

        /// <summary>
        /// <para>Closes the current context, and return the computed hash.</para>
        /// </summary>
        [GodotMethod("finish")]
        public byte[] Finish()
        {
            return NativeCalls.godot_icall_0_2(method_bind_2, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
