using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The HMACContext class is useful for advanced HMAC use cases, such as streaming the message as it supports creating the message over time rather than providing it all at once.</para>
    /// <para><code>
    /// extends Node
    /// var ctx = HMACContext.new()
    /// 
    /// func _ready():
    ///     var key = "supersecret".to_utf8()
    ///     var err = ctx.start(HashingContext.HASH_SHA256, key)
    ///     assert(err == OK)
    ///     var msg1 = "this is ".to_utf8()
    ///     var msg2 = "super duper secret".to_utf8()
    ///     err = ctx.update(msg1)
    ///     assert(err == OK)
    ///     err = ctx.update(msg2)
    ///     assert(err == OK)
    ///     var hmac = ctx.finish()
    ///     print(hmac.hex_encode())
    /// </code></para>
    /// <para>And in C# we can use the following.</para>
    /// <para><code>
    /// using Godot;
    /// using System;
    /// using System.Diagnostics;
    /// 
    /// public class CryptoNode : Node
    /// {
    ///     private HMACContext ctx = new HMACContext();
    ///     public override void _Ready()
    ///     {
    ///         PoolByteArray key = String("supersecret").to_utf8();
    ///         Error err = ctx.Start(HashingContext.HASH_SHA256, key);
    ///         GD.Assert(err == OK);
    ///         PoolByteArray msg1 = String("this is ").to_utf8();
    ///         PoolByteArray msg2 = String("super duper secret").to_utf8();
    ///         err = ctx.Update(msg1);
    ///         GD.Assert(err == OK);
    ///         err = ctx.Update(msg2);
    ///         GD.Assert(err == OK);
    ///         PoolByteArray hmac = ctx.Finish();
    ///         GD.Print(hmac.HexEncode());
    ///     }
    /// }
    /// </code></para>
    /// <para>Note: Not available in HTML5 exports.</para>
    /// </summary>
    public partial class HMACContext : Reference
    {
        private const string nativeName = "HMACContext";

        public HMACContext() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_HMACContext_Ctor(this);
        }

        internal HMACContext(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "start");

        /// <summary>
        /// <para>Initializes the HMACContext. This method cannot be called again on the same HMACContext until <see cref="Godot.HMACContext.Finish"/> has been called.</para>
        /// </summary>
        [GodotMethod("start")]
        public Error Start(HashingContext.HashType hashType, byte[] key)
        {
            return (Error)NativeCalls.godot_icall_2_486(method_bind_0, Object.GetPtr(this), (int)hashType, key);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "update");

        /// <summary>
        /// <para>Updates the message to be HMACed. This can be called multiple times before <see cref="Godot.HMACContext.Finish"/> is called to append <c>data</c> to the message, but cannot be called until <see cref="Godot.HMACContext.Start"/> has been called.</para>
        /// </summary>
        [GodotMethod("update")]
        public Error Update(byte[] data)
        {
            return (Error)NativeCalls.godot_icall_1_487(method_bind_1, Object.GetPtr(this), data);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "finish");

        /// <summary>
        /// <para>Returns the resulting HMAC. If the HMAC failed, an empty <see cref="byte"/> is returned.</para>
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
