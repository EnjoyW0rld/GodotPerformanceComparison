using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A synchronization mutex (mutual exclusion). This is used to synchronize multiple <see cref="Godot.Thread"/>s, and is equivalent to a binary <see cref="Godot.Semaphore"/>. It guarantees that only one thread can ever acquire the lock at a time. A mutex can be used to protect a critical section; however, be careful to avoid deadlocks.</para>
    /// </summary>
    public partial class Mutex : Reference
    {
        private const string nativeName = "_Mutex";

        public Mutex() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Mutex_Ctor(this);
        }

        internal Mutex(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "lock");

        /// <summary>
        /// <para>Locks this <see cref="Godot.Mutex"/>, blocks until it is unlocked by the current owner.</para>
        /// <para>Note: This function returns without blocking if the thread already has ownership of the mutex.</para>
        /// </summary>
        [GodotMethod("lock")]
        public void Lock()
        {
            NativeCalls.godot_icall_0_3(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "try_lock");

        /// <summary>
        /// <para>Tries locking this <see cref="Godot.Mutex"/>, but does not block. Returns <c>OK</c> on success, <c>ERR_BUSY</c> otherwise.</para>
        /// <para>Note: This function returns <c>OK</c> if the thread already has ownership of the mutex.</para>
        /// </summary>
        [GodotMethod("try_lock")]
        public Error TryLock()
        {
            return (Error)NativeCalls.godot_icall_0_389(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "unlock");

        /// <summary>
        /// <para>Unlocks this <see cref="Godot.Mutex"/>, leaving it to other threads.</para>
        /// <para>Note: If a thread called <see cref="Godot.Mutex.Lock"/> or <see cref="Godot.Mutex.TryLock"/> multiple times while already having ownership of the mutex, it must also call <see cref="Godot.Mutex.Unlock"/> the same number of times in order to unlock it correctly.</para>
        /// </summary>
        [GodotMethod("unlock")]
        public void Unlock()
        {
            NativeCalls.godot_icall_0_3(method_bind_2, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
