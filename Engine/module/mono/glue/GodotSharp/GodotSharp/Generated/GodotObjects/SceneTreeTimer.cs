using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A one-shot timer managed by the scene tree, which emits <c>timeout</c> on completion. See also <see cref="Godot.SceneTree.CreateTimer"/>.</para>
    /// <para>As opposed to <see cref="Godot.Timer"/>, it does not require the instantiation of a node. Commonly used to create a one-shot delay timer as in the following example:</para>
    /// <para><code>
    /// func some_function():
    ///     print("Timer started.")
    ///     yield(get_tree().create_timer(1.0), "timeout")
    ///     print("Timer ended.")
    /// </code></para>
    /// <para>The timer will be dereferenced after its time elapses. To preserve the timer, you can keep a reference to it. See <see cref="Godot.Reference"/>.</para>
    /// </summary>
    public abstract partial class SceneTreeTimer : Reference
    {
        /// <summary>
        /// <para>The time remaining (in seconds).</para>
        /// </summary>
        public float TimeLeft
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTimeLeft();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTimeLeft(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "SceneTreeTimer";

        internal SceneTreeTimer() {}

        internal SceneTreeTimer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_time_left");

        [GodotMethod("set_time_left")]
        [Obsolete("SetTimeLeft is deprecated. Use the TimeLeft property instead.")]
        public void SetTimeLeft(float time)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), time);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_time_left");

        [GodotMethod("get_time_left")]
        [Obsolete("GetTimeLeft is deprecated. Use the TimeLeft property instead.")]
        public float GetTimeLeft()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
