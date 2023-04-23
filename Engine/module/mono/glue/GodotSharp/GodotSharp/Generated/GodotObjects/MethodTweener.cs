using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.MethodTweener"/> is similar to a combination of <see cref="Godot.CallbackTweener"/> and <see cref="Godot.PropertyTweener"/>. It calls a method providing an interpolated value as a parameter. See <see cref="Godot.SceneTreeTween.TweenMethod"/> for more usage information.</para>
    /// <para>Note: <see cref="Godot.SceneTreeTween.TweenMethod"/> is the only correct way to create <see cref="Godot.MethodTweener"/>. Any <see cref="Godot.MethodTweener"/> created manually will not function correctly.</para>
    /// </summary>
    public partial class MethodTweener : Tweener
    {
        private const string nativeName = "MethodTweener";

        public MethodTweener() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_MethodTweener_Ctor(this);
        }

        internal MethodTweener(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_delay");

        /// <summary>
        /// <para>Sets the time in seconds after which the <see cref="Godot.MethodTweener"/> will start interpolating. By default there's no delay.</para>
        /// </summary>
        [GodotMethod("set_delay")]
        public MethodTweener SetDelay(float delay)
        {
            return NativeCalls.godot_icall_1_611(method_bind_0, Object.GetPtr(this), delay);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_trans");

        /// <summary>
        /// <para>Sets the type of used transition from <see cref="Godot.Tween.TransitionType"/>. If not set, the default transition is used from the <see cref="Godot.SceneTreeTween"/> that contains this Tweener.</para>
        /// </summary>
        [GodotMethod("set_trans")]
        public MethodTweener SetTrans(Tween.TransitionType trans)
        {
            return NativeCalls.godot_icall_1_612(method_bind_1, Object.GetPtr(this), (int)trans);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ease");

        /// <summary>
        /// <para>Sets the type of used easing from <see cref="Godot.Tween.EaseType"/>. If not set, the default easing is used from the <see cref="Godot.SceneTreeTween"/> that contains this Tweener.</para>
        /// </summary>
        [GodotMethod("set_ease")]
        public MethodTweener SetEase(Tween.EaseType ease)
        {
            return NativeCalls.godot_icall_1_612(method_bind_2, Object.GetPtr(this), (int)ease);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
