using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A synchronization semaphore which can be used to synchronize multiple <see cref="Godot.Thread"/>s. Initialized to zero on creation. Be careful to avoid deadlocks. For a binary version, see <see cref="Godot.Mutex"/>.</para>
    /// </summary>
    public partial class Semaphore : Reference
    {
        private const string nativeName = "_Semaphore";

        public Semaphore() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Semaphore_Ctor(this);
        }

        internal Semaphore(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "wait");

        /// <summary>
        /// <para>Waits for the <see cref="Godot.Semaphore"/>, if its value is zero, blocks until non-zero.</para>
        /// <para>Note: This method internals' can't possibly fail, but an error code is returned for backwards compatibility, which will always be <c>OK</c>.</para>
        /// </summary>
        [GodotMethod("wait")]
        public Error Wait()
        {
            return (Error)NativeCalls.godot_icall_0_389(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "post");

        /// <summary>
        /// <para>Lowers the <see cref="Godot.Semaphore"/>, allowing one more thread in.</para>
        /// <para>Note: This method internals' can't possibly fail, but an error code is returned for backwards compatibility, which will always be <c>OK</c>.</para>
        /// </summary>
        [GodotMethod("post")]
        public Error Post()
        {
            return (Error)NativeCalls.godot_icall_0_389(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "try_wait");

        /// <summary>
        /// <para>Like <see cref="Godot.Semaphore.Wait"/>, but won't block, so if the value is zero, fails immediately and returns <c>ERR_BUSY</c>. If non-zero, it returns <c>OK</c> to report success.</para>
        /// </summary>
        [GodotMethod("try_wait")]
        public Error TryWait()
        {
            return (Error)NativeCalls.godot_icall_0_389(method_bind_2, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
