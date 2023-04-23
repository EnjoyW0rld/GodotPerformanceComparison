using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A unit of execution in a process. Can run methods on <see cref="Godot.Object"/>s simultaneously. The use of synchronization via <see cref="Godot.Mutex"/> or <see cref="Godot.Semaphore"/> is advised if working with shared objects.</para>
    /// <para>Note: Breakpoints won't break on code if it's running in a thread. This is a current limitation of the GDScript debugger.</para>
    /// </summary>
    public partial class Thread : Reference
    {
        public enum Priority
        {
            /// <summary>
            /// <para>A thread running with lower priority than normally.</para>
            /// </summary>
            Low = 0,
            /// <summary>
            /// <para>A thread with a standard priority.</para>
            /// </summary>
            Normal = 1,
            /// <summary>
            /// <para>A thread running with higher priority than normally.</para>
            /// </summary>
            High = 2
        }

        private const string nativeName = "_Thread";

        public Thread() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Thread_Ctor(this);
        }

        internal Thread(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "start");

        /// <summary>
        /// <para>Starts a new <see cref="Godot.Thread"/> that runs <c>method</c> on object <c>instance</c> with <c>userdata</c> passed as an argument. Even if no userdata is passed, <c>method</c> must accept one argument and it will be null. The <c>priority</c> of the <see cref="Godot.Thread"/> can be changed by passing a value from the <see cref="Godot.Thread.Priority"/> enum.</para>
        /// <para>Returns <c>OK</c> on success, or <c>ERR_CANT_CREATE</c> on failure.</para>
        /// </summary>
        [GodotMethod("start")]
        public Error Start(Object instance, string method, object userdata = null, Thread.Priority priority = (Thread.Priority)1)
        {
            return (Error)NativeCalls.godot_icall_4_1226(method_bind_0, Object.GetPtr(this), Object.GetPtr(instance), method, userdata, (int)priority);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_id");

        /// <summary>
        /// <para>Returns the current <see cref="Godot.Thread"/>'s ID, uniquely identifying it among all threads. If the <see cref="Godot.Thread"/> is not running this returns an empty string.</para>
        /// </summary>
        [GodotMethod("get_id")]
        public string GetId()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_active");

        /// <summary>
        /// <para>Returns <c>true</c> if this <see cref="Godot.Thread"/> has been started. Once started, this will return <c>true</c> until it is joined using <see cref="Godot.Thread.WaitToFinish"/>. For checking if a <see cref="Godot.Thread"/> is still executing its task, use <see cref="Godot.Thread.IsAlive"/>.</para>
        /// </summary>
        [GodotMethod("is_active")]
        public bool IsActive()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_alive");

        /// <summary>
        /// <para>Returns <c>true</c> if this <see cref="Godot.Thread"/> is currently running. This is useful for determining if <see cref="Godot.Thread.WaitToFinish"/> can be called without blocking the calling thread.</para>
        /// <para>To check if a <see cref="Godot.Thread"/> is joinable, use <see cref="Godot.Thread.IsActive"/>.</para>
        /// </summary>
        [GodotMethod("is_alive")]
        public bool IsAlive()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "wait_to_finish");

        /// <summary>
        /// <para>Joins the <see cref="Godot.Thread"/> and waits for it to finish. Returns the output of the method passed to <see cref="Godot.Thread.Start"/>.</para>
        /// <para>Should either be used when you want to retrieve the value returned from the method called by the <see cref="Godot.Thread"/> or before freeing the instance that contains the <see cref="Godot.Thread"/>.</para>
        /// <para>To determine if this can be called without blocking the calling thread, check if <see cref="Godot.Thread.IsAlive"/> is <c>false</c>.</para>
        /// <para>Note: After the <see cref="Godot.Thread"/> finishes joining it will be disposed. If you want to use it again you will have to create a new instance of it.</para>
        /// </summary>
        [GodotMethod("wait_to_finish")]
        public object WaitToFinish()
        {
            return NativeCalls.godot_icall_0_547(method_bind_4, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
