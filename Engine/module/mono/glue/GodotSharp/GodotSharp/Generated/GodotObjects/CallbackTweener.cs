using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.CallbackTweener"/> is used to call a method in a tweening sequence. See <see cref="Godot.SceneTreeTween.TweenCallback"/> for more usage information.</para>
    /// <para>Note: <see cref="Godot.SceneTreeTween.TweenCallback"/> is the only correct way to create <see cref="Godot.CallbackTweener"/>. Any <see cref="Godot.CallbackTweener"/> created manually will not function correctly.</para>
    /// </summary>
    public partial class CallbackTweener : Tweener
    {
        private const string nativeName = "CallbackTweener";

        public CallbackTweener() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CallbackTweener_Ctor(this);
        }

        internal CallbackTweener(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_delay");

        /// <summary>
        /// <para>Makes the callback call delayed by given time in seconds. Example:</para>
        /// <para><code>
        /// var tween = get_tree().create_tween()
        /// tween.tween_callback(queue_free).set_delay(2) #this will call queue_free() after 2 seconds
        /// </code></para>
        /// </summary>
        [GodotMethod("set_delay")]
        public CallbackTweener SetDelay(float delay)
        {
            return NativeCalls.godot_icall_1_243(method_bind_0, Object.GetPtr(this), delay);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
