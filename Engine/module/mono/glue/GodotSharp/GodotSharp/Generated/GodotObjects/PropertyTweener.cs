using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.PropertyTweener"/> is used to interpolate a property in an object. See <see cref="Godot.SceneTreeTween.TweenProperty"/> for more usage information.</para>
    /// <para>Note: <see cref="Godot.SceneTreeTween.TweenProperty"/> is the only correct way to create <see cref="Godot.PropertyTweener"/>. Any <see cref="Godot.PropertyTweener"/> created manually will not function correctly.</para>
    /// </summary>
    public partial class PropertyTweener : Tweener
    {
        private const string nativeName = "PropertyTweener";

        public PropertyTweener() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PropertyTweener_Ctor(this);
        }

        internal PropertyTweener(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "from");

        /// <summary>
        /// <para>Sets a custom initial value to the <see cref="Godot.PropertyTweener"/>. Example:</para>
        /// <para><code>
        /// var tween = get_tree().create_tween()
        /// tween.tween_property(self, "position", Vector2(200, 100), 1).from(Vector2(100, 100) #this will move the node from position (100, 100) to (200, 100)
        /// </code></para>
        /// </summary>
        [GodotMethod("from")]
        public PropertyTweener From(object value)
        {
            return NativeCalls.godot_icall_1_809(method_bind_0, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "from_current");

        /// <summary>
        /// <para>Makes the <see cref="Godot.PropertyTweener"/> use the current property value (i.e. at the time of creating this <see cref="Godot.PropertyTweener"/>) as a starting point. This is equivalent of using <see cref="Godot.PropertyTweener.From"/> with the current value. These two calls will do the same:</para>
        /// <para><code>
        /// tween.tween_property(self, "position", Vector2(200, 100), 1).from(position)
        /// tween.tween_property(self, "position", Vector2(200, 100), 1).from_current()
        /// </code></para>
        /// </summary>
        [GodotMethod("from_current")]
        public PropertyTweener FromCurrent()
        {
            return NativeCalls.godot_icall_0_810(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "as_relative");

        /// <summary>
        /// <para>When called, the final value will be used as a relative value instead. Example:</para>
        /// <para><code>
        /// var tween = get_tree().create_tween()
        /// tween.tween_property(self, "position", Vector2.RIGHT * 100, 1).as_relative() #the node will move by 100 pixels to the right
        /// </code></para>
        /// </summary>
        [GodotMethod("as_relative")]
        public PropertyTweener AsRelative()
        {
            return NativeCalls.godot_icall_0_810(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_trans");

        /// <summary>
        /// <para>Sets the type of used transition from <see cref="Godot.Tween.TransitionType"/>. If not set, the default transition is used from the <see cref="Godot.SceneTreeTween"/> that contains this Tweener.</para>
        /// </summary>
        [GodotMethod("set_trans")]
        public PropertyTweener SetTrans(Tween.TransitionType trans)
        {
            return NativeCalls.godot_icall_1_811(method_bind_3, Object.GetPtr(this), (int)trans);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ease");

        /// <summary>
        /// <para>Sets the type of used easing from <see cref="Godot.Tween.EaseType"/>. If not set, the default easing is used from the <see cref="Godot.SceneTreeTween"/> that contains this Tweener.</para>
        /// </summary>
        [GodotMethod("set_ease")]
        public PropertyTweener SetEase(Tween.EaseType ease)
        {
            return NativeCalls.godot_icall_1_811(method_bind_4, Object.GetPtr(this), (int)ease);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_delay");

        /// <summary>
        /// <para>Sets the time in seconds after which the <see cref="Godot.PropertyTweener"/> will start interpolating. By default there's no delay.</para>
        /// </summary>
        [GodotMethod("set_delay")]
        public PropertyTweener SetDelay(float delay)
        {
            return NativeCalls.godot_icall_1_812(method_bind_5, Object.GetPtr(this), delay);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
