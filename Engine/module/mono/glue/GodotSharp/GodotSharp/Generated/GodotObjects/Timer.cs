using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Counts down a specified interval and emits a signal on reaching 0. Can be set to repeat or "one-shot" mode.</para>
    /// <para>Note: To create a one-shot timer without instantiating a node, use <see cref="Godot.SceneTree.CreateTimer"/>.</para>
    /// </summary>
    public partial class Timer : Node
    {
        public enum TimerProcessMode
        {
            /// <summary>
            /// <para>Update the timer during the physics step at each frame (fixed framerate processing).</para>
            /// </summary>
            Physics = 0,
            /// <summary>
            /// <para>Update the timer during the idle time at each frame.</para>
            /// </summary>
            Idle = 1
        }

        /// <summary>
        /// <para>Processing mode. See <see cref="Godot.Timer.TimerProcessMode"/>.</para>
        /// </summary>
        public Timer.TimerProcessMode ProcessMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTimerProcessMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTimerProcessMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The wait time in seconds.</para>
        /// <para>Note: Timers can only emit once per rendered frame at most (or once per physics frame if <see cref="Godot.Timer.ProcessMode"/> is <see cref="Godot.Timer.TimerProcessMode.Physics"/>). This means very low wait times (lower than 0.05 seconds) will behave in significantly different ways depending on the rendered framerate. For very low wait times, it is recommended to use a process loop in a script instead of using a Timer node.</para>
        /// </summary>
        public float WaitTime
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetWaitTime();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetWaitTime(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the timer will stop when reaching 0. If <c>false</c>, it will restart.</para>
        /// </summary>
        public bool OneShot
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsOneShot();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOneShot(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the timer will automatically start when entering the scene tree.</para>
        /// <para>Note: This property is automatically set to <c>false</c> after the timer enters the scene tree and starts.</para>
        /// </summary>
        public bool Autostart
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return HasAutostart();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAutostart(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the timer is paused and will not process until it is unpaused again, even if <see cref="Godot.Timer.Start"/> is called.</para>
        /// </summary>
        public bool Paused
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsPaused();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPaused(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The timer's remaining time in seconds. Returns 0 if the timer is inactive.</para>
        /// <para>Note: You cannot set this value. To change the timer's remaining time, use <see cref="Godot.Timer.Start"/>.</para>
        /// </summary>
        public float TimeLeft
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTimeLeft();
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Timer";

        public Timer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Timer_Ctor(this);
        }

        internal Timer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_wait_time");

        [GodotMethod("set_wait_time")]
        [Obsolete("SetWaitTime is deprecated. Use the WaitTime property instead.")]
        public void SetWaitTime(float timeSec)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), timeSec);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_wait_time");

        [GodotMethod("get_wait_time")]
        [Obsolete("GetWaitTime is deprecated. Use the WaitTime property instead.")]
        public float GetWaitTime()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_one_shot");

        [GodotMethod("set_one_shot")]
        [Obsolete("SetOneShot is deprecated. Use the OneShot property instead.")]
        public void SetOneShot(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_one_shot");

        [GodotMethod("is_one_shot")]
        [Obsolete("IsOneShot is deprecated. Use the OneShot property instead.")]
        public bool IsOneShot()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_autostart");

        [GodotMethod("set_autostart")]
        [Obsolete("SetAutostart is deprecated. Use the Autostart property instead.")]
        public void SetAutostart(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_autostart");

        [GodotMethod("has_autostart")]
        [Obsolete("HasAutostart is deprecated. Use the Autostart property instead.")]
        public bool HasAutostart()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "start");

        /// <summary>
        /// <para>Starts the timer. Sets <c>wait_time</c> to <c>time_sec</c> if <c>time_sec &gt; 0</c>. This also resets the remaining time to <c>wait_time</c>.</para>
        /// <para>Note: This method will not resume a paused timer. See <see cref="Godot.Timer.Paused"/>.</para>
        /// </summary>
        [GodotMethod("start")]
        public void Start(float timeSec = (float)-1)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), timeSec);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "stop");

        /// <summary>
        /// <para>Stops the timer.</para>
        /// </summary>
        [GodotMethod("stop")]
        public void Stop()
        {
            NativeCalls.godot_icall_0_3(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_paused");

        [GodotMethod("set_paused")]
        [Obsolete("SetPaused is deprecated. Use the Paused property instead.")]
        public void SetPaused(bool paused)
        {
            NativeCalls.godot_icall_1_16(method_bind_8, Object.GetPtr(this), paused);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_paused");

        [GodotMethod("is_paused")]
        [Obsolete("IsPaused is deprecated. Use the Paused property instead.")]
        public bool IsPaused()
        {
            return NativeCalls.godot_icall_0_7(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_stopped");

        /// <summary>
        /// <para>Returns <c>true</c> if the timer is stopped.</para>
        /// </summary>
        [GodotMethod("is_stopped")]
        public bool IsStopped()
        {
            return NativeCalls.godot_icall_0_7(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_time_left");

        [GodotMethod("get_time_left")]
        [Obsolete("GetTimeLeft is deprecated. Use the TimeLeft property instead.")]
        public float GetTimeLeft()
        {
            return NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_timer_process_mode");

        [GodotMethod("set_timer_process_mode")]
        [Obsolete("SetTimerProcessMode is deprecated. Use the ProcessMode property instead.")]
        public void SetTimerProcessMode(Timer.TimerProcessMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_12, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_timer_process_mode");

        [GodotMethod("get_timer_process_mode")]
        [Obsolete("GetTimerProcessMode is deprecated. Use the ProcessMode property instead.")]
        public Timer.TimerProcessMode GetTimerProcessMode()
        {
            return (Timer.TimerProcessMode)NativeCalls.godot_icall_0_971(method_bind_13, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
